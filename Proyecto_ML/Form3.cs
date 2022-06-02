using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_ML
{
    public partial class FormUpdateDelete : Form
    {
        //Constructor
        public FormUpdateDelete()
        {
            InitializeComponent();
            dateCOT_updel.Value = DateTime.Now;
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["unica"].ConnectionString);
            cn.Open();

            SqlCommand command = new SqlCommand("sp_InsertRegistroFacturas", cn);
            command.CommandType = CommandType.StoredProcedure;

            SqlParameter param = new SqlParameter("@OrdenDeTrabajo", txtOT_updel.Text);
            command.Parameters.Add(param);
            param = new SqlParameter("@NumEconomico", txtECO_updel.Text);
            command.Parameters.Add(param);
            param = new SqlParameter("@Monto", txtMON_updel.Text);
            command.Parameters.Add(param);
            param = new SqlParameter("@FechaCot", Convert.ToDateTime(dateCOT_updel.Text).ToString("yyyy-MM-dd"));
            command.Parameters.Add(param);
            param = new SqlParameter("@RazonSocial", cboxRS_reg.SelectedItem.ToString());
            command.Parameters.Add(param);
            param = new SqlParameter("@NumFactura", txtNFAC_reg.Text);
            command.Parameters.Add(param);
            param = new SqlParameter("@Conceptos", txtCON_reg.Text);
            command.Parameters.Add(param);
            param = new SqlParameter("@Ciudad", cboxCIUDAD_reg.SelectedItem.ToString());
            command.Parameters.Add(param);
            param = new SqlParameter("@MontoCImpuesto", txtMCI_reg.Text);
            command.Parameters.Add(param);

            command.ExecuteNonQuery();
            cn.Close();

            //MessageBox.Show("Insertado");

            txtOT_updel.Text = "";
            txtECO_updel.Text = "";
            txtMON_updel.Text = "";
            dateCOT_updel.Value = DateTime.Now;
            cboxRS_reg.SelectedItem = null;
            txtNFAC_reg.Text = "";
            txtCON_reg.Text = "";
            cboxCIUDAD_reg.SelectedItem = null;
            txtMCI_reg.Text = "";
        }

    }
}
