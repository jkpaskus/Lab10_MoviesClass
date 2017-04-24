using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10_MovieSorting
{
    class Movies
    {
        private string Category;
        private string Title;

        #region properties
        public string MovieTitle
        {
            get
            {
                return Title;
            }

            set
            {
                Title = value;
            }
        }

        public string MovieCategory
        {
            get
            {
                return Category;
            }

            set
            {
                Category = value;
            }
        }
        #endregion

        #region constructors
        public Movies()
        {
            Category = "-----";
            Title = "-----";
        }

        public Movies(string MTitle, string MCategory)
        {  //this refers to global variable!! (class field)

            Title = MTitle;
            Category = MCategory;
            
        }

        #endregion
    }
}
