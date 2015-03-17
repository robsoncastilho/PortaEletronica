using System;

namespace ExemploPortaEletronica.Dominio
{
    public interface IProvedorDeHorario
    {
        DateTime DataHoraCorrente { get; }
    }
}