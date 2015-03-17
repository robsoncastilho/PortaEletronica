using System;
using System.Collections.Generic;
using System.Linq;

namespace ExemploPortaEletronica.Dominio
{
    public class PortaEletronica
    {
        private readonly IProvedorDeHorario _provedorDeHorario;

        private readonly IList<RegistroDeEntrada> _registrosDeEntrada = new List<RegistroDeEntrada>();
        public IEnumerable<RegistroDeEntrada> RegistrosDeEntrada { get { return _registrosDeEntrada; } }

        public IEnumerable<RegistroDeEntrada> EntradasForaDoExpediente { get { return _registrosDeEntrada.Where(registro => !registro.FoiEmHorarioDeExpediente()); } }

        public PortaEletronica(IProvedorDeHorario provedorDeHorario)
        {
            if (provedorDeHorario == null) throw new ArgumentNullException("provedorDeHorario");
            _provedorDeHorario = provedorDeHorario;
        }

        public void RegistrarEntrada()
        {
            var dataHoraAtual = _provedorDeHorario.DataHoraCorrente;
            _registrosDeEntrada.Add(new RegistroDeEntrada(dataHoraAtual));
        }
    }
}
