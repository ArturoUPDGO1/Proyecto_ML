﻿using System;
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

            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();

            string id, ot, eco, mon, fc, rs, nf, con, ciu, mci, estml;

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
            if (cboxActivo.SelectedItem == null ||
                String.IsNullOrEmpty(cboxActivo.SelectedItem.ToString()))
            {
                estml = "1";
            }
            else
            {
                estml = cboxActivo.SelectedItem.ToString();
                if (estml == "Activo")
                {
                    estml = "1";
                }
                else if (estml == "Inactivo")
                {
                    estml = "0";
                }
                else
                {
                    estml = null;
                }
            }

            dgvDatos.DataSource = consul.MostrarFacturas(id, ot, eco, mon, fc, rs, nf, con, ciu, mci, estml);
            //if (dgvDatos.Columns.Count > 11)
            //{
            //}
            //else
            //{
            //dgvDatos.Columns.Add(btn);
            //btn.HeaderText = "ACTUALIZAR REGISTRO";
            //btn.Text = "<---";
            //btn.Name = "btn";
            //btn.UseColumnTextForButtonValue = true;
            //}
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
            dgvDatos.Columns.Clear();
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            //dgvDatos.Columns.Remove(btn);

            string fecot = dateCOT_buscar.Value.ToShortDateString();

            DataTable dt = (DataTable)dgvDatos.DataSource;
            if (dt == null)
            {

            }
            else
            {
                dt.Clear();
            }


            string id, ot, eco, mon, fc, rs, nf, con, ciu, mci, estml;
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
            if (cboxActivo.SelectedItem == null ||
                String.IsNullOrEmpty(cboxActivo.SelectedItem.ToString()))
            {
                estml = "1";
            }
            else
            {
                estml = cboxActivo.SelectedItem.ToString();
                if (estml == "Activo")
                {
                    estml = "1";
                }
                else if (estml == "Inactivo")
                {
                    estml = "0";
                }
                else
                {
                    estml = null;
                }
            }

            dgvDatos.DataSource = consul.MostrarFacturas(id, ot, eco, mon, fc, rs, nf, con, ciu, mci, estml);
            //if (dgvDatos.Columns.Count > 11)
            //{

            //}
            //else
            //{
            dgvDatos.Columns.Add(btn);
            btn.HeaderText = "ACTUALIZAR REGISTRO";
            btn.Text = "<---";
            btn.Name = "btn";
            btn.UseColumnTextForButtonValue = true;
            //}


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
            cboxActivo.SelectedItem = null;

        }

        private void dgvDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 11)
            {
                //MessageBox.Show((e.RowIndex+1) + " Row " + (e.ColumnIndex+1) + " Column button clicked ");
                string id_ml = dgvDatos.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtID_buscar.Text = id_ml;
                string ot = dgvDatos.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtOT_buscar.Text = ot;
                string eco = dgvDatos.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtECO_buscar.Text = eco;
                string mon = dgvDatos.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtMON_buscar.Text = mon;
                string fc = dgvDatos.Rows[e.RowIndex].Cells[4].Value.ToString();
                dateCOT_buscar.Value = DateTime.Parse(fc);
                string rs = dgvDatos.Rows[e.RowIndex].Cells[5].Value.ToString();
                cboxRS_buscar.SelectedItem = rs;
                string nf = dgvDatos.Rows[e.RowIndex].Cells[6].Value.ToString();
                txtNFAC_buscar.Text = nf;
                string con = dgvDatos.Rows[e.RowIndex].Cells[7].Value.ToString();
                txtCON_buscar.Text = con;
                string ciu = dgvDatos.Rows[e.RowIndex].Cells[8].Value.ToString();
                cboxCIUDAD_buscar.SelectedItem = ciu;
                string mci = dgvDatos.Rows[e.RowIndex].Cells[9].Value.ToString();
                txtMCI_buscar.Text = mci;
                string estml = dgvDatos.Rows[e.RowIndex].Cells[10].Value.ToString();
                if (estml == "1")
                {
                    cboxActivo.SelectedItem = "Activo";
                }
                else
                {
                    cboxActivo.SelectedItem = "Inactivo";
                }
                txtID_buscar.Enabled = false;
                button2.Enabled = false;
                button2.Visible = false;
                cboxActivo.Items.Remove("Mostrar todos");
                button1.Enabled = true;
                button1.Visible = true;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            txtID_buscar.Enabled = true;
            button2.Enabled = true;
            button2.Visible = true;
            cboxActivo.Items.Add("Mostrar todos");



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
            cboxActivo.SelectedItem = null;
            button1.Enabled = false;
            button1.Visible = false;
        }
    }
}
