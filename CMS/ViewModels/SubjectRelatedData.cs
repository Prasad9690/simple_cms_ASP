﻿using CMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CMS.ViewModels
{
    //View Models
    public class SubjectRelatedData
    {
        public Subject subj { get; set; }
        public List<Page> pg { get; set; }
        public List<Content> content { get; set; } 
       
    }
}