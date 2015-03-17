using ExemploPortaEletronica.Dominio;
using NUnit.Framework;
using System;

namespace ExemploPortaEletronica.Testes
{
    [TestFixture]
    public class RegistroDeEntradaTeste
    {
        [Test]
        public void Deve_comparar_registros_de_entrada()
        {
            var registroDeEntrada = new RegistroDeEntrada(new DateTime(2015, 03, 17, 18, 0, 0));
            var outroRegistroDeEntrada = new RegistroDeEntrada(new DateTime(2015, 03, 17, 18, 0, 0));
            var registroDeEntradaDiferente = new RegistroDeEntrada(new DateTime(2015, 03, 17, 18, 0, 1));

            Assert.That(registroDeEntrada, Is.EqualTo(outroRegistroDeEntrada));
            Assert.That(registroDeEntrada, Is.Not.EqualTo(registroDeEntradaDiferente));
        }

        [TestCase(09, 59, 59, false, TestName = "Antes do horario de expediente")]
        [TestCase(15, 59, 59, true, TestName = "Dentro do horario de expediente")]
        [TestCase(16, 00, 01, false, TestName = "Depois do horario de expediente")]
        public void Deve_informar_se_esta_dentro_do_horario_de_expediente(int hora, int minuto, int segundo, bool resultadoEsperado)
        {
            var registroDeEntrada = new RegistroDeEntrada(new DateTime(2015, 03, 17, hora, minuto, segundo));

            Assert.AreEqual(resultadoEsperado, registroDeEntrada.FoiEmHorarioDeExpediente());
        }
    }
}