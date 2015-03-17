using System;

namespace ExemploPortaEletronica.Dominio
{
    /// <summary>
    /// RegistroDeEntrada implementada como um value object:
    /// http://robsoncastilho.com.br/2013/11/10/trabalhando-com-value-objects/
    /// 
    /// Horário de expediente da agencia bancária considerada no exemplo: das 10 às 16 hrs
    /// (Por simplicidade esse intervalo está hard-coded no metodo FoiEmHorarioDeExpediente. Em um projeto real, provavelmente isso seria evitado)
    /// </summary>
    public class RegistroDeEntrada
    {
        public DateTime DataHoraDeEntrada { get; private set; }

        public RegistroDeEntrada(DateTime dataHoraDeEntrada)
        {
            DataHoraDeEntrada = dataHoraDeEntrada;
        }

        public bool FoiEmHorarioDeExpediente()
        {
            var horarioDeExpediente = new TimeSpan(10, 0, 0);
            var horarioFinalDoExpediente = new TimeSpan(16, 0, 0);
            return DataHoraDeEntrada.TimeOfDay >= horarioDeExpediente && DataHoraDeEntrada.TimeOfDay <= horarioFinalDoExpediente;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;

            var registroDeEntrada = obj as RegistroDeEntrada;
            return registroDeEntrada != null && DataHoraDeEntrada == registroDeEntrada.DataHoraDeEntrada;
        }

        public override int GetHashCode()
        {
            return DataHoraDeEntrada.GetHashCode();
        }
    }
}