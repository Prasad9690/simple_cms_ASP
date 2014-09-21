using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CMS.Models
{
    public class Content
    {
        public int ContentId { get; set; }
        public int SubjectId { get; set; }
        public int PageId { get; set; }

        public Subject subject { get; set; }
        public Page page { get; set; }
    }
}