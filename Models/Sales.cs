using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace __P01_SalesDatabase.Models
{
    internal class Sales
    {
        public int SalesID { get; set; }
        public string Date { get; set; }
        public string Customer { get; set; }
        public string Product { get; set; }
        public string Store { get; set; }
    }
}
