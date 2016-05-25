using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OwinSelfhostSample
{
    public class Category
    {
        public string Name { get; set; }
        public int Num { get; set; }
        public string Text { get; set; }
        public string ImageUrl { get; set; }
        public List<SubCategory> Subs { get; set; }

        public Category()
        {
            Subs = new List<SubCategory>();
        }
    }

    public class SubCategory
    {
        public int Num { get; set; }
        public string Text { get; set; }
        public string HoverText { get; set; }
        public decimal Percentage { get; set; }
        public bool Selected { get; set; }
    }
}
