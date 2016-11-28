using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1_Lab10
{
    public class Movie
    {
        public Movie(string title, string category)
        {
            this._title = title;
            this.category = category;
        }

        private string _title;

        public string Title
        {
            get { return _title; }
            //set { _title = value; }
        }

        private string category;

        public string Category
        {
            get { return category; }
            //set { category = value; }
        }
    }
}

