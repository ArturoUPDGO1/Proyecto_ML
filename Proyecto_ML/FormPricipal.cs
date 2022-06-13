using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace Proyecto_ML
{
    public partial class FormPricipal : Form
    {

        //Campos
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;

        //Constructor
        public FormPricipal()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);
            //Formulario
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        //Estructuras
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }


        //Metodos
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Boton
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //Borde izquierdo del boton
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                //Icon Current Child Form
                iconCurrentChildForm.IconChar = currentBtn.IconChar;
                iconCurrentChildForm.IconColor = color;
            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                //Boton
                currentBtn.BackColor = Color.FromArgb(31, 30, 68);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitleChildForm.Text = childForm.Text;
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormAgregarRegistro());
            ActivateButton(sender, RGBColors.color1);
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormConsulta());
            ActivateButton(sender, RGBColors.color4);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {

            

            if (currentChildForm == null){
                
            }
            else
            {
                currentChildForm.Close();
                lblFacturas();
                graphDate();
                chartEstado();
                Reset();
            }
            
            
        }

        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            iconCurrentChildForm.IconChar = IconChar.Home;
            iconCurrentChildForm.IconColor = Color.MediumPurple;
            lblTitleChildForm.Text = "Menú Principal";
        }

        //Arrastrar formularios
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelBarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void iconButton3_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_design1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormShowAll());

        }

        private void btn_design_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormConfig());
            iconCurrentChildForm.IconChar = IconChar.Home;
            iconCurrentChildForm.IconColor = Color.MediumPurple;
        }



        private void lblFacturas()
        {
            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["unica"].ConnectionString);
            cn.Open();

            //Imprimir en label el numero de facturas activas con una consulta tipo COUNT
            SqlCommand cmd = new SqlCommand("USE testfacturas; SELECT COUNT(*) FROM registros WHERE estat LIKE 1; ", cn);

            lblTotalFacturas.Text = (string)cmd.ExecuteScalar().ToString() + ".";

            cn.Close();
        }


        ArrayList graph_cantidad = new ArrayList();
        ArrayList graph_fecha = new ArrayList();

        private void graphDate()
        {
            graph_cantidad.Clear();
            graph_fecha.Clear();

            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["unica"].ConnectionString);
            cn.Open();

            //Usar SqlReader para llenar la gráfica con un proceso almacenado.
            SqlCommand cmdgraph = new SqlCommand("USE testfacturas; SELECT TOP 4 fecha_cot, COUNT(*) AS cantidad FROM registros WHERE estat = '1' GROUP BY fecha_cot ORDER  BY fecha_cot DESC", cn);
            SqlDataReader drgraph;

            drgraph = cmdgraph.ExecuteReader();

            while (drgraph.Read())
            {
                graph_cantidad.Add(drgraph.GetInt32(1));
                graph_fecha.Add(drgraph.GetDateTime(0));
            }

            chrtFechaCantidad.ChartAreas[0].AxisX.LabelStyle.ForeColor = Color.White;
            chrtFechaCantidad.ChartAreas[0].AxisY.LabelStyle.ForeColor = Color.White;
            chrtFechaCantidad.Series[0].Points.DataBindXY(graph_fecha, graph_cantidad);

            drgraph.Close();
            cn.Close();
        }


        ArrayList graph_cant = new ArrayList();
        ArrayList graph_raz = new ArrayList();

        private void chartEstado()
        {
            graph_cant.Clear();
            graph_raz.Clear();

            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["unica"].ConnectionString);
            cn.Open();

            //Usar SqlReader para llenar la gráfica con un proceso almacenado.
            SqlCommand cmdchartraz = new SqlCommand("USE testfacturas; SELECT TOP 5 ciudad, COUNT(*) AS cantidad FROM registros WHERE estat = '1' GROUP BY ciudad ORDER  BY cantidad DESC", cn);
            SqlDataReader drcharrazon;

            drcharrazon = cmdchartraz.ExecuteReader();

            while (drcharrazon.Read())
            {
                graph_cant.Add(drcharrazon.GetInt32(1));
                graph_raz.Add(drcharrazon.GetString(0));
            }

            chrtRazonSocial.Series[0].Points.DataBindXY(graph_raz, graph_cant);

            drcharrazon.Close();
            cn.Close();
        }

        private void getlblFecha()
        {
            lblFecha.Text = DateTime.Now.ToLongDateString()+ ".";
        }

        private void FormPricipal_Load(object sender, EventArgs e)
        {
            lblFacturas();
            graphDate();
            chartEstado();
            getlblFecha();

        }
    }
}
