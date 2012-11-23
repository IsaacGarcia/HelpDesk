using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelpDesk.Domain.ComponenteChamado;

namespace HelpDesk.Domain.Repository
{
    public class Chamados
    {
        public IList<Chamado> EmAtrasoDeAcordoCom(int tempoEmHorasDeRespostaAceitavel) {

            var hoje = DateTime.Now;

            var chamados = new List<Chamado>();
            
            var chamado = new Chamado();
            chamado.DataDeSolicitacao = new DateTime(2012, 11, 20);

            var chamado2 = new Chamado();
            chamado2.DataDeSolicitacao = new DateTime(2012, 11, 22);

            chamados.Add(chamado);
            chamados.Add(chamado2);

            return chamados.Where(x => hoje.Subtract(x.DataDeSolicitacao).TotalHours > tempoEmHorasDeRespostaAceitavel).ToList<Chamado>();
        }
    }
}