using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{

        
        public class Book
        {
            public int BookID { get; set; }
            public string BookName { get; set; }
            public string Author { get; set; }
            public int PageCount { get; set; }
            public bool IsAvailable { get; set; }
        }
    }

