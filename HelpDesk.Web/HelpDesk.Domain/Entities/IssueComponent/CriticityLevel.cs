using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDesk.Domain.Entities.IssueComponent
{
    /// <summary>
    /// Minor, High, Cosmetic
    /// </summary>
    public class CriticityLevel
    {
        public virtual Guid Id { get; set; }
        public virtual string Name { get; set; }
    }
}
