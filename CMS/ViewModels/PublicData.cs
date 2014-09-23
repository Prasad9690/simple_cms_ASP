using CMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CMS.ViewModels
{
    public class PublicData
    {
        public List<Subject> subj { get; set; }
        public List<Page> pg { get; set; }
        public Page pageObj { get; set; }
        public List<Content> content { get; set; } 
    }
}