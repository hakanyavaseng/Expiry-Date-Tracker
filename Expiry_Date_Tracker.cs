using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Office;


namespace Expiry_Date_Tracker_Program
{
    public partial class Expiry_Date_Tracker : Form
    {
        public Expiry_Date_Tracker()
        {
            InitializeComponent();
        }


        private void clear()
        {
            mtxtBarcode.Text = string.Empty;    
            mtxtProductNo.Text = string.Empty;
            mtxtProductName.Text= string.Empty;
            mtxtAmount.Text = string.Empty; 
        }

        SqlConnection conn = new SqlConnection("Data Source=Hakan;Initial Catalog=ProductData;Integrated Security=True");
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'productDataDataSet4.tblProduct' table. You can move, or remove it, as needed.
     
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
           
           if(mtxtBarcode.Text == "" && mtxtProductNo.Text == "" && mtxtAmount.Text == "" && mtxtProductName.Text == "")
            {
                MessageBox.Show("You must enter product informations.");
            }

            else
            {
                conn.Open();
                SqlCommand add = new SqlCommand("insert into tblProduct (pBarcode, pNumber, pName, pDate, pAmount) values (@p1,@p2,@p3,@p4, @p5)", conn);
                add.Parameters.AddWithValue("@p1", mtxtBarcode.Text);
                add.Parameters.AddWithValue("@p2", mtxtProductNo.Text);
                add.Parameters.AddWithValue("@p3", mtxtProductName.Text);
                DateTime dt = dateTimePicker1.Value.Date;
                add.Parameters.AddWithValue("@p4", dt);
                add.Parameters.AddWithValue("@p5", mtxtAmount.Text);
                add.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Product has been added to database.");
            }

           
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            this.tblProductTableAdapter.Fill(this.productDataDataSet4.tblProduct);

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int selectedIndex = dataGridView1.SelectedCells[0].RowIndex;

            mtxtBarcode.Text = dataGridView1.Rows[selectedIndex].Cells[0].Value.ToString();
            mtxtProductNo.Text = dataGridView1.Rows[selectedIndex].Cells[1].Value.ToString();
            mtxtProductName.Text = dataGridView1.Rows[selectedIndex].Cells[2].Value.ToString();
            mtxtAmount.Text = dataGridView1.Rows[selectedIndex].Cells[4].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            conn.Open();
            int selectedIndex = dataGridView1.SelectedCells[0].RowIndex;

            SqlCommand delete = new SqlCommand("Delete from tblProduct where pBarcode = @p1", conn);

            delete.Parameters.AddWithValue("@p1", dataGridView1.Rows[selectedIndex].Cells[0].Value.ToString());
            delete.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("Selected product has been deleted!");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.clear();
        }
        private void copyAlltoClipboard()
        {
            dataGridView1.SelectAll();
            DataObject dataObj = dataGridView1.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
        } 
        private void btnExport_Click(object sender, EventArgs e)
        {
                copyAlltoClipboard();
                Microsoft.Office.Interop.Excel.Application xlexcel;
                Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
                Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
                object misValue = System.Reflection.Missing.Value;
                xlexcel = new Microsoft.Office.Interop.Excel.Application();
                xlexcel.Visible = true;
                xlWorkBook = xlexcel.Workbooks.Add(misValue);
                xlWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
                 Microsoft.Office.Interop.Excel.Range CR = (Microsoft.Office.Interop.Excel.Range)xlWorkSheet.Cells[1, 1];
                CR.Select();
                xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);
        
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            conn.Open();
            int selectedIndex = dataGridView1.SelectedCells[0].RowIndex;

            SqlCommand update = new SqlCommand("Update tblProduct set pBarcode = @p1, pNumber = @p2, pName = @p3, pDate = @p4, pAmount = @p5 where pBarcode = @p6 ", conn);

            update.Parameters.AddWithValue("@p1", mtxtBarcode.Text);
            update.Parameters.AddWithValue("@p2", mtxtProductNo.Text);
            update.Parameters.AddWithValue("@p3", mtxtProductName.Text);
            DateTime dt = dateTimePicker1.Value.Date;
            update.Parameters.AddWithValue("@p4", dt);
            update.Parameters.AddWithValue("@p5", mtxtAmount.Text);
            update.Parameters.AddWithValue("@p6", dataGridView1.Rows[selectedIndex].Cells[0].Value.ToString());
            update.ExecuteNonQuery();
            MessageBox.Show("Product has been updated!");

        }
    }
}
