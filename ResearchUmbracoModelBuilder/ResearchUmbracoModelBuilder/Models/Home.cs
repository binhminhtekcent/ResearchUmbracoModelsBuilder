using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ResearchUmbracoModelBuilder.Models
{
    public partial class Home
    {
        private List<News> listNews=new List<News>();
        
        public List<News> ListNews
        {
            get
            {
                foreach (News item in Children)
                {
                    listNews.Add(item);
                }
                return listNews;
            }
        }
    }
}