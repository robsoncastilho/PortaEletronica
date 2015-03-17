using System;

namespace ExemploPortaEletronica.Dominio
{
    /// <summary>
    /// Abstra��o que fornece data/hora corrente.    
    /// Podemos tamb�m fazer uso do padr�o de DI "Ambient Context" ao inv�s de injetar esta depend�ncia via construtor:
    /// http://robsoncastilho.com.br/2015/01/19/padroes-de-di-ambient-context/ (c�digo fonte do artigo no repositorio "TimeProvider")    
    /// </summary>
    public interface IProvedorDeHorario
    {
        DateTime DataHoraCorrente { get; }
    }
}