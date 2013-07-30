using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDesk.Domain.Entities.IssueComponent
{
    /// <summary>
    /// Suporte nivel 1, nivel 2, nivel 3
    /// </summary>
    public class Level
    {
        public virtual Guid Id { get; set; }
        public virtual string Name { get; set; }
    }
}
