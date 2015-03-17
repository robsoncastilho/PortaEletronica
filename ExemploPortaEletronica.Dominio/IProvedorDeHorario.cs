using System;

namespace ExemploPortaEletronica.Dominio
{
    /// <summary>
    /// Abstração que fornece data/hora corrente.    
    /// Podemos também fazer uso do padrão de DI "Ambient Context" ao invés de injetar esta dependência via construtor:
    /// http://robsoncastilho.com.br/2015/01/19/padroes-de-di-ambient-context/ (código fonte do artigo no repositorio "TimeProvider")    
    /// </summary>
    public interface IProvedorDeHorario
    {
        DateTime DataHoraCorrente { get; }
    }
}