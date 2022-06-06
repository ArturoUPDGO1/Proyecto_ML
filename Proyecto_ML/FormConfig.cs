using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_ML
{
    public partial class FormConfig : Form
    {
        public FormConfig()
        {
            InitializeComponent();

            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["unica"].ConnectionString);
            cn.Open();

            SqlCommand command = new SqlCommand("sp_SelectPathFolder", cn);
            command.CommandType = CommandType.StoredProcedure;

            SqlDataReader dbpath = command.ExecuteReader();

            if (dbpath.Read())
            {
                txtFilePath.Text = dbpath["pathdirectory"].ToString();
            }

            cn.Close();
        }

        private void btnSelectFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();

            var resultado = fbd.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                txtFilePath.Text = fbd.SelectedPath;
            }
        }

        private void btnConfirmAll_Click(object sender, EventArgs e)
        {
            string folderpath = txtFilePath.Text;
            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["unica"].ConnectionString);
            cn.Open();

            SqlCommand command = new SqlCommand("sp_UpdateFolderPath", cn);
            command.CommandType = CommandType.StoredProcedure;

            SqlParameter param = new SqlParameter("@DirectoryPath", folderpath);
            command.Parameters.Add(param);

            command.ExecuteNonQuery();
            cn.Close();

            cn.Open();

            SqlCommand command2 = new SqlCommand("sp_SelectPathFolder", cn);
            command2.CommandType = CommandType.StoredProcedure;

            SqlDataReader dbpath = command2.ExecuteReader();

            if (dbpath.Read())
            {
                txtFilePath.Text = dbpath["pathdirectory"].ToString();
            }

            cn.Close();
        }
    }
}
