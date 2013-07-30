using HelpDesk.Domain.Entities.UserComponent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDesk.Domain.Entities.IssueComponent
{
    public class Comments
    {
        public virtual Guid Id { get; set; }
        public virtual string Comment { get; set; }
        public virtual DateTime Date { get; set; }

        public virtual IList<Attachment> Attachments { get; set; }
        public virtual User Owner { get; set; }
    }
}
