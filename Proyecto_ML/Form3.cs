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
            dateCOT_update.Value = DateTime.Now;
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

            SqlParameter param = new SqlParameter("@OrdenDeTrabajo", txtOT_update.Text);
            command.Parameters.Add(param);
            param = new SqlParameter("@NumEconomico", txtECO_update.Text);
            command.Parameters.Add(param);
            param = new SqlParameter("@Monto", txtMON_update.Text);
            command.Parameters.Add(param);
            param = new SqlParameter("@FechaCot", Convert.ToDateTime(dateCOT_update.Text).ToString("yyyy-MM-dd"));
            command.Parameters.Add(param);
            param = new SqlParameter("@RazonSocial", cboxRS_update.SelectedItem.ToString());
            command.Parameters.Add(param);
            param = new SqlParameter("@NumFactura", txtNFAC_update.Text);
            command.Parameters.Add(param);
            param = new SqlParameter("@Conceptos", txtCON_update.Text);
            command.Parameters.Add(param);
            param = new SqlParameter("@Ciudad", cboxCIUDAD_update.SelectedItem.ToString());
            command.Parameters.Add(param);
            param = new SqlParameter("@MontoCImpuesto", txtMCI_update.Text);
            command.Parameters.Add(param);

            command.ExecuteNonQuery();
            cn.Close();

            //MessageBox.Show("Insertado");

            txtOT_update.Text = "";
            txtECO_update.Text = "";
            txtMON_update.Text = "";
            dateCOT_update.Value = DateTime.Now;
            cboxRS_update.SelectedItem = null;
            txtNFAC_update.Text = "";
            txtCON_update.Text = "";
            cboxCIUDAD_update.SelectedItem = null;
            txtMCI_update.Text = "";
        }

        private void txtOT_updel_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void txtECO_updel_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtMON_updel_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void dateCOT_updel_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cboxRS_reg_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtNFAC_reg_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void txtCON_reg_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["unica"].ConnectionString);
            cn.Open();

            SqlCommand command = new SqlCommand("sp_PreviewRegistroFacturas", cn);
            command.CommandType = CommandType.StoredProcedure;

            SqlParameter param = new SqlParameter("@OrdenDeTrabajo", txtOT_update.Text);
            command.Parameters.Add(param);
            param = new SqlParameter("@OrdenDeTrabajo", txtOT_update.Text);
            command.Parameters.Add(param);
            param = new SqlParameter("@NumEconomico", txtECO_update.Text);
            command.Parameters.Add(param);
            param = new SqlParameter("@NumFactura", txtNFAC_update.Text);
            command.Parameters.Add(param);

            command.ExecuteNonQuery();
            cn.Close();
        }
    }
}
