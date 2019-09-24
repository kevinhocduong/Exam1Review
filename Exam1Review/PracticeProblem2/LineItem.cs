using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblem2
{
    class LineItem
    {
        public string Item { get; set; }
        public double Price { get; set; }

        public LineItem()
        {
            Item = string.Empty;
            Price = 0.0;
        }
    }
}
