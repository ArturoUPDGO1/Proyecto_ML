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
        //Constructor
        public FormConsulta()
        {
            InitializeComponent();
        }

        Consulta consul = new Consulta();

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
            DataTable dt = (DataTable)dgvDatos.DataSource;
            if (dt == null)
            {

            }
            else
            {
                dt.Clear();
            }
            

            string id, ot;
            id = (String.IsNullOrEmpty(txtID_buscar.Text)) ? null : txtID_buscar.Text;
            ot = (String.IsNullOrEmpty(txtOT_buscar.Text)) ? null : txtOT_buscar.Text;

            dgvDatos.DataSource = consul.MostrarFacturas(id,ot);

            txtID_buscar.Text = "";
            txtOT_buscar.Text = "";
        }
    }
}
