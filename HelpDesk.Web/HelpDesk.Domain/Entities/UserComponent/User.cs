using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDesk.Domain.Entities.UserComponent
{
    public class User
    {
        public virtual Guid Id { get; set; }
        public virtual string Name { get; set; }
        public virtual string Password { get; set; }
        public virtual string Login { get; set; }
        public virtual string Email { get; set; }

        public virtual IList<Department> Department { get; set; }
        public virtual Profile Profile { get; set; }
    }
}
