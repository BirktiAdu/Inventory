using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Invontory.Model
{
    internal class Product
    {
        public int Number { get; set; }
        public string Date { get; set; }
        public int InvestoryNumber { get; set; }
        public string ItemName { get; set; }
        public int Count { get; set; }
        public double Price { get; set; }

        public void save()
        {
            MessageBox.Show("Data Base Conected");
        }
    }
   
}
