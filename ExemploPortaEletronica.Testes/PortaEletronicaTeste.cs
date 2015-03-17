using ExemploPortaEletronica.Dominio;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace ExemploPortaEletronica.Testes
{
    /// <summary>
    /// Testa o registro de entrada em uma agencia bancaria ao passar pela porta eletronica, usando um stub para simular data/hora corrente
    /// Considere o uso de builders para refatorar os testes (para criar a porta eletronica, por ex):
    /// http://robsoncastilho.com.br/2012/02/12/construindo-objetos-complexos-com-builders-parte-2-de-2/
    /// </summary>
    [TestFixture]
    public class PortaEletronicaTeste
    {
        [Test]
        public void Deve_registrar_entrada_com_data_e_hora_corretos()
        {
            var horarioDeEntrada = new DateTime(2015, 03, 16, 17, 0, 0);
            var provedorDeHorarioStub = new ProvedorDeHorarioStub { DataHoraCorrente = horarioDeEntrada };
            var portaEletronica = new PortaEletronica(provedorDeHorarioStub);

            portaEletronica.RegistrarEntrada();

            var registrosEsperados = new List<RegistroDeEntrada> { new RegistroDeEntrada(horarioDeEntrada) };
            CollectionAssert.AreEquivalent(registrosEsperados, portaEletronica.RegistrosDeEntrada);
        }

        [Test]
        public void Deve_retornar_entradas_fora_do_horario_de_expediente()
        {
            var horarioForaDoExpediente = new DateTime(2015, 03, 16, 17, 0, 0);
            var provedorDeHorarioStub = new ProvedorDeHorarioStub { DataHoraCorrente = horarioForaDoExpediente };
            var portaEletronica = new PortaEletronica(provedorDeHorarioStub);
            portaEletronica.RegistrarEntrada();

            var entradasForaDoExpediente = portaEletronica.EntradasForaDoExpediente;

            var registrosEsperados = new List<RegistroDeEntrada> { new RegistroDeEntrada(horarioForaDoExpediente) };
            CollectionAssert.AreEquivalent(registrosEsperados, entradasForaDoExpediente);
        }
    }
}