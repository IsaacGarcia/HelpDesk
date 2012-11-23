using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelpDesk.Domain.Repository;
using NUnit.Framework;

namespace HelpDesk.Test.Domain.Repository
{
    [TestFixture]
    public class ChamadosTest
    {
        [Test]
        public void obter_todos_os_chamados_em_atrasso_com_sucesso()
        {
            var chamados = new Chamados();
            
            var chamadosEmAtraso = chamados.EmAtrasoDeAcordoCom(1);
            var dataDeSolicitacao = chamadosEmAtraso.First().DataDeSolicitacao;

            Assert.AreEqual(dataDeSolicitacao.Day, 20);
        }
    }
}