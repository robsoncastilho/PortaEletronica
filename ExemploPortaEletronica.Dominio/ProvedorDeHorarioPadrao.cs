using System;

namespace ExemploPortaEletronica.Dominio
{
    public class ProvedorDeHorarioPadrao : IProvedorDeHorario
    {
        public DateTime DataHoraCorrente { get { return DateTime.Now; } }
    }
}