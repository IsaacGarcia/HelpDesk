using HelpDesk.Domain.Entities.UserComponent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDesk.Domain.Entities.IssueComponent
{
    public class Issue
    {
        public virtual Guid Id { get; set; }
        public virtual string Description { get; set; }
        public virtual DateTime InitialDate { get; set; }
        public virtual DateTime LastUpdateDate { get; set; }
        public virtual DateTime ClosedDate { get; set; }

        public virtual User Owner { get; set; }
        public virtual Department AdressTo { get; set; }
        public virtual Level Level { get; set; }
        public virtual CriticityLevel CriticityLevel { get; set; }
        public virtual Status Status { get; set; }
        public virtual IList<Attachment> Attachments { get; set; }
        public virtual IList<Comments> Comments { get; set; }
    }
}
