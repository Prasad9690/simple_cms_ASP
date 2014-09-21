﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CMS.Models
{
    public class CMSInitializer : DropCreateDatabaseIfModelChanges<CMSContext>
    {
        protected override void Seed(CMSContext context)
        {
            var subjects = new List<Subject>
            {
                new Subject{SubjectName="Campus",SubjectPosition=1,SubjectVisible=true},
                new Subject{SubjectName="Cube",SubjectPosition=2,SubjectVisible=true}
            };
            foreach (var temp in subjects)
            {
                context.Subjects.Add(temp);
            }
            context.SaveChanges();

            var pages = new List<Page>
            {
                new Page{PageName="Life",PagePosition=1,PageVisible=true},
                new Page{PageName="Facilities",PagePosition=2,PageVisible=true},
                new Page{PageName="Opening time",PagePosition=1,PageVisible=true},
                new Page{PageName="Weekly Special",PagePosition=2,PageVisible=true}
            };
            foreach (var temp in pages)
            {
                context.Pages.Add(temp);
            }
            context.SaveChanges();

            var contents = new List<Content>
            {
                new Content{SubjectId=1,PageId=1,PageContent="Content for Life"},
                new Content{SubjectId=1,PageId=2,PageContent="Content for Facilities"},
                new Content{SubjectId=2,PageId=3,PageContent="Content for Opening Time"},
                new Content{SubjectId=2,PageId=4,PageContent="Content for Weekly special"}
            };
            foreach (var temp in contents)
            {
                context.Contents.Add(temp);
            }
            context.SaveChanges();
        }
    }
}