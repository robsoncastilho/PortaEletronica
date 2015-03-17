using ExemploPortaEletronica.Dominio;
using System;

namespace ExemploPortaEletronica.Testes
{
    /// <summary>
    /// Stub implementado para que possamos simular a data/hora corrente conforme a necessidade dos testes
    /// (o stub permanece no projeto de testes e não junto com o código de produção)
    /// </summary>
    public class ProvedorDeHorarioStub : IProvedorDeHorario
    {
        public DateTime DataHoraCorrente { get; set; }
    }
}