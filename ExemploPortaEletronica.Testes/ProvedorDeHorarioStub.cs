using ExemploPortaEletronica.Dominio;
using System;

namespace ExemploPortaEletronica.Testes
{
    public class ProvedorDeHorarioStub : IProvedorDeHorario
    {
        public DateTime DataHoraCorrente { get; set; }
    }
}