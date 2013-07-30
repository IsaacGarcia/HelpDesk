using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDesk.Domain.Entities.IssueComponent
{
    public class Attachment
    {
        public virtual Guid Id { get; set; }
        public virtual string Name { get; set; }
        public virtual string Extension { get; set; }
        public virtual string Path { get; set; }
        public virtual DateTime Date { get; set; }
    }
}
