using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDesk.Domain.Entities.IssueComponent
{
    /// <summary>
    /// Open, Closed, Finish, resolved, Works for me
    /// </summary>
    public class Status
    {
        public virtual Guid Id { get; set; }
        public virtual string Name { get; set; }
    }
}
