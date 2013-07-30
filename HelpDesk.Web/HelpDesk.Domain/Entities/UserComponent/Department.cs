using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDesk.Domain.Entities.UserComponent
{
    public class Department
    {
        public virtual Guid Id { get; set; }
        public virtual string Name { get; set; }
        public virtual Hospital Hospital { get; set; }
    }
}
