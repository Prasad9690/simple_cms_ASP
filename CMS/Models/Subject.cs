using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CMS.Models
{
    public class Subject
    {
        public int SubjectId { get; set; }
        public string SubjectName { get; set; }
        public int SubjectPosition { get; set; }
        public bool SubjectVisible { get; set; }

        public ICollection<Content> Contents { get; set; }
    }
}