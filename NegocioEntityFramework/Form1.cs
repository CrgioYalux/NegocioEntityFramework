using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaLogica.CLProductos;
using CapaLogica.ViewModels;

namespace NegocioEntityFramework
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CLProductos oCLProductos = new CLProductos();
            List<ProductoViewModel> lst = new List<ProductoViewModel>();
            lst = oCLProductos.TraerTodosLosProductos();

            dgvProductos.DataSource = lst;
            // dgvProductos.Columns.RemoveAt(dgvProductos.Columns.Count - 1); 
        }
    }
}
