using System;

namespace ExemploPortaEletronica.Dominio
{
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