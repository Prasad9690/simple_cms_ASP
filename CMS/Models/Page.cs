﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CMS.Models
{
    public class Page
    {
        public int PageId { get; set; }
//        public int SubjectId { get; set; }
        public string PageName { get; set; }
        public int PagePosition { get; set; }
        public bool PageVisible { get; set; }
 //       public string PageContent { get; set; }

        public ICollection<Content> Contents { get; set; }        
       
    }
}