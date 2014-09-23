using CMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CMS.ViewModels
{
    public class SelectedPage
    {
        public List<Subject> subj { get; set; }
        public Page pg { get; set; }
        public List<Content> content {get; set; }
    }
}