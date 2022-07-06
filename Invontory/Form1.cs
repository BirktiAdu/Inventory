using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Invontory.Model;
namespace Invontory
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            Product p = new Product();
            p.Number = int.Parse(txt_Number.Text);
            p.Date = dp_date.Text;
            p.Count = int.Parse(txt_Count.Text);
            p.ItemName = txt_ItemName.Text;
            p.InvestoryNumber = int.Parse(txt_InventoryNumber.Text);
            p.Price = double.Parse(txt_Price.Text);
            p.save();
            MessageBox.Show("ADDED");
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
