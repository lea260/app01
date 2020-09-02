using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app01
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = dtgvProductos.Rows.Add();
            dtgvProductos.Rows[n].Cells[0].Value = "hola";
            dtgvProductos.Rows[n].Cells[0].Value = "hola";
            dtgvProductos.Rows[n].Cells[0].Value = "hola";
        }

        private void btnVer_Click(object sender, EventArgs e)
        {

        }

        private void dtgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int n = e.RowIndex;
            if (n!=-1)
        }
    }
}
