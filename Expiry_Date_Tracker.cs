using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Expiry_Date_Tracker_Program
{
    public partial class Expiry_Date_Tracker : Form
    {
        public Expiry_Date_Tracker()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'productDataDataSet2.tblProduct' table. You can move, or remove it, as needed.
            this.tblProductTableAdapter1.Fill(this.productDataDataSet2.tblProduct);

        }
    }
}
