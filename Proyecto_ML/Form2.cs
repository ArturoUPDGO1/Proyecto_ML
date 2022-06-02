using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_ML
{
    public partial class FormConsulta : Form
    {
        Consulta consul = new Consulta();
        //Constructor
        public FormConsulta()
        {
            InitializeComponent();

            var fecot = dateCOT_buscar.Value;

            string id, ot, eco, mon, fc, rs, nf, con, ciu, mci;

            id = (String.IsNullOrEmpty(txtID_buscar.Text)) ? null : txtID_buscar.Text;
            ot = (String.IsNullOrEmpty(txtOT_buscar.Text)) ? null : txtOT_buscar.Text;
            eco = (String.IsNullOrEmpty(txtECO_buscar.Text)) ? null : txtECO_buscar.Text;
            mon = (String.IsNullOrEmpty(txtMON_buscar.Text)) ? null : txtMON_buscar.Text;
            fc = null;
            if (cboxRS_buscar.SelectedItem == null ||
                String.IsNullOrEmpty(cboxRS_buscar.SelectedItem.ToString()))
            {
                rs = null;
            }
            else
            {
                rs = cboxRS_buscar.SelectedItem.ToString();
            }
            nf = (String.IsNullOrEmpty(txtNFAC_buscar.Text)) ? null : txtNFAC_buscar.Text;
            con = (String.IsNullOrEmpty(txtCON_buscar.Text)) ? null : txtCON_buscar.Text;
            if (cboxCIUDAD_buscar.SelectedItem == null ||
                String.IsNullOrEmpty(cboxCIUDAD_buscar.SelectedItem.ToString()))
            {
                ciu = null;
            }
            else
            {
                ciu = cboxCIUDAD_buscar.SelectedItem.ToString();
            }
            mci = (String.IsNullOrEmpty(txtMCI_buscar.Text)) ? null : txtMCI_buscar.Text;

            dgvDatos.DataSource = consul.MostrarFacturas(id, ot, eco, mon, fc, rs, nf, con, ciu, mci);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            string fecot = dateCOT_buscar.Value.ToShortDateString();

            DataTable dt = (DataTable)dgvDatos.DataSource;
            if (dt == null)
            {

            }
            else
            {
                dt.Clear();
            }


            string id, ot, eco, mon, fc, rs, nf, con, ciu, mci;
            //DateTime fc = this.dateCOT_buscar.Value.Date;

            id = (String.IsNullOrEmpty(txtID_buscar.Text)) ? null : txtID_buscar.Text;
            ot = (String.IsNullOrEmpty(txtOT_buscar.Text)) ? null : txtOT_buscar.Text;
            eco = (String.IsNullOrEmpty(txtECO_buscar.Text)) ? null : txtECO_buscar.Text;
            mon = (String.IsNullOrEmpty(txtMON_buscar.Text)) ? null : txtMON_buscar.Text;
            string fcConf = Convert.ToDateTime(fecot).ToString("yyyy-MM-dd");
            string fh = Convert.ToDateTime(DateTime.Today.ToString()).ToString("yyyy-MM-dd");
            if (fcConf == fh)
            {
                fc = null;
            }
            else
            {
                fc = fcConf;
            }
            if (cboxRS_buscar.SelectedItem == null ||
                String.IsNullOrEmpty(cboxRS_buscar.SelectedItem.ToString()))
            {
                rs = null;
            }
            else
            {
                rs = cboxRS_buscar.SelectedItem.ToString();
            }
            nf = (String.IsNullOrEmpty(txtNFAC_buscar.Text)) ? null : txtNFAC_buscar.Text;
            con = (String.IsNullOrEmpty(txtCON_buscar.Text)) ? null : txtCON_buscar.Text;
            if (cboxCIUDAD_buscar.SelectedItem == null ||
                String.IsNullOrEmpty(cboxCIUDAD_buscar.SelectedItem.ToString()))
            {
                ciu = null;
            }
            else
            {
                ciu = cboxCIUDAD_buscar.SelectedItem.ToString();
            }
            mci = (String.IsNullOrEmpty(txtMCI_buscar.Text)) ? null : txtMCI_buscar.Text;

            dgvDatos.DataSource = consul.MostrarFacturas(id, ot, eco, mon, fc, rs, nf, con, ciu, mci);

            txtID_buscar.Text = "";
            txtOT_buscar.Text = "";
            txtECO_buscar.Text = "";
            txtMON_buscar.Text = "";
            dateCOT_buscar.Value = DateTime.Now;
            cboxRS_buscar.SelectedItem = null;
            txtNFAC_buscar.Text = "";
            txtCON_buscar.Text = "";
            cboxCIUDAD_buscar.SelectedItem = null;
            txtMCI_buscar.Text = "";

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new FormAgregarRegistro());
            Heredado.Load("Hola");
            Heredado.Show();
        }
    }
}
