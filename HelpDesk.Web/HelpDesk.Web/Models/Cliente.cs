using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HelpDesk.Web.Models
{
    public class Pagina
    {
        public virtual IEnumerable<Cliente> Clientes { get; set; }
        public virtual Cliente Cliente { get; set; }
        public virtual IDictionary<string,Cliente> ClientesD { get; set; }
    }

    public class Cliente : IEnumerable<int>
    {
        public virtual string Nome { get; set; }
        public virtual string Endereco { get; set; }

        public IEnumerator<int> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}