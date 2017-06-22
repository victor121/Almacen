using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Almacen
{
    public partial class IngresarDineroForm : Form
    {
        public IngresarDineroForm()
        {
            InitializeComponent();
        }

        private void btnIngresarDinero_Click(object sender, EventArgs e)
        {
            try
            {
                int plata = Convert.ToInt32(txtIngresarDinero.Text);
                var caja = new caja();
                caja.ingresarDinero(plata);
                MessageBox.Show("Dinero agregado exitosamente");
                txtIngresarDinero.Text = "";
                
            }
            catch (Exception ex)
            {
            }
            
        }

        private void IngresarDineroForm_Load(object sender, EventArgs e)
        {

        }
    }
}
