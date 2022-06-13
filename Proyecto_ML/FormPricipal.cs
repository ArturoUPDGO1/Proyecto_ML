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
            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["principalDB"].ConnectionString);
            cn.Open();

            //Imprimir en label el numero de facturas activas con una consulta tipo COUNT
            SqlCommand cmd = new SqlCommand("USE db_mlfacturas; SELECT COUNT(*) FROM registros WHERE estat LIKE 1; ", cn);

            lblTotalFacturas.Text = (string)cmd.ExecuteScalar().ToString() + ".";

            cn.Close();
        }


        ArrayList graph_cantidad = new ArrayList();
        ArrayList graph_fecha = new ArrayList();

        private void graphDate()
        {
            graph_cantidad.Clear();
            graph_fecha.Clear();

            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["principalDB"].ConnectionString);
            cn.Open();

            //Usar SqlReader para llenar la gráfica con un proceso almacenado.
            SqlCommand cmdgraph = new SqlCommand("USE db_mlfacturas; SELECT TOP 4 fecha_cot, COUNT(*) AS cantidad FROM registros WHERE estat = '1' GROUP BY fecha_cot ORDER  BY fecha_cot DESC", cn);
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

            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["principalDB"].ConnectionString);
            cn.Open();

            //Usar SqlReader para llenar la gráfica con un proceso almacenado.
            SqlCommand cmdchartraz = new SqlCommand("USE db_mlfacturas; SELECT TOP 5 ciudad, COUNT(*) AS cantidad FROM registros WHERE estat = '1' GROUP BY ciudad ORDER  BY cantidad DESC", cn);
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
            lblFecha.Text = DateTime.Today.ToLongDateString()+ ".";
        }

        private void FormPricipal_Load(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["unica"].ConnectionString);
            cn.Open();

            SqlCommand ifcommand = new SqlCommand("IF EXISTS (SELECT name FROM master.dbo.sysdatabases WHERE name = N'db_mlfacturas') BEGIN SELECT 'TRUE' AS Message END ELSE BEGIN SELECT 'FALSE' AS Message END", cn);
            SqlDataReader ifdr = ifcommand.ExecuteReader();

            if (ifdr.Read())
            {
                string res = ifdr["Message"].ToString();
                if (res == "FALSE")
                {
                    CrearBD();
                    //MessageBox.Show("La base de datos fue creada");
                }
                else
                {
                    //MessageBox.Show("La base de datos ya existe");
                }
            }

            ifdr.Close();
            cn.Close();

            lblFacturas();
            graphDate();
            chartEstado();
            getlblFecha();

        }

        public void CrearBD()
        {
            string querycreatedb = @"CREATE DATABASE[db_mlfacturas]";

            string querycreatetbs = @"USE [db_mlfacturas]
            CREATE TABLE[dbo].[folderpath](
            [id_path][int] IDENTITY(1, 1) NOT NULL,
            [pathdirectory] [varchar](500) NULL,
            CONSTRAINT[PK_path] PRIMARY KEY CLUSTERED
            (
            [id_path] ASC
            )WITH(PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON[PRIMARY]
            ) ON[PRIMARY];
            
            CREATE TABLE[dbo].[registros](
            [id_main][int] IDENTITY(1, 1) NOT NULL,
            [ot] [varchar](50) NULL,
            [eco] [varchar](50) NULL,
            [monto] [varchar](50) NULL,
            [fecha_cot] [date] NULL,
            [razon_social] [varchar](100) NULL,
            [num_factura] [varchar](50) NULL,
            [conceptos] [varchar](300) NULL,
            [ciudad] [varchar](50) NULL,
            [monto_cimpuesto] [varchar](50) NULL,
            [estat] [varchar](50) NOT NULL,
            CONSTRAINT[PK_registros] PRIMARY KEY CLUSTERED(
            [id_main] ASC
            )WITH(PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON[PRIMARY]
            ) ON[PRIMARY];";

            string querycreatesp1 = @"
            CREATE PROCEDURE [dbo].[sp_DeleteRegistroFacturas]
            @IdMain int = NULL,
            @OrdenDeTrabajo varchar(50) = NULL,
            @NumEconomico varchar(50) = NULL,
            @NumFactura varchar(50) = NULL
            AS
            BEGIN
	            DELETE FROM registros
                WHERE  (@IdMain IS NULL OR id_main = @IdMain) AND
			            (@OrdenDeTrabajo IS NULL OR ot = @OrdenDeTrabajo) AND
			            (@NumEconomico IS NULL OR eco = @NumEconomico) AND
			            (@NumFactura IS NULL OR num_factura = @NumFactura)

            END";

            string querycreatesp2 = @"
            CREATE PROCEDURE [dbo].[sp_InsertRegistroFacturas]
            @OrdenDeTrabajo varchar(50),
            @NumEconomico varchar(50),
            @Monto varchar(50),
            @FechaCot date = NULL,
            @RazonSocial varchar(100),
            @NumFactura varchar(50),
            @Conceptos varchar(300),
            @Ciudad varchar(50),
            @MontoCImpuesto varchar(50)
            AS
            BEGIN
                INSERT INTO registros
                (ot, eco, monto, fecha_cot, razon_social, num_factura, conceptos, ciudad, monto_cimpuesto, estat)
                VALUES
                (@OrdenDeTrabajo, @NumEconomico, @Monto, @FechaCot, @RazonSocial, @NumFactura, @Conceptos, @Ciudad, @MontoCImpuesto, '1')
            END";

            string querycreatesp3 = @"
            CREATE PROCEDURE[dbo].[sp_PreviewRegistroFacturas]
            @IdMain varchar(50) = NULL,
            @OrdenDeTrabajo varchar(50) = NULL,
            @NumEconomico varchar(50) = NULL,
            @NumFactura varchar(50) = NULL
            AS
            BEGIN
                SELECT* FROM registros
                WHERE(@IdMain IS NULL OR id_main = @IdMain) AND
                     (@OrdenDeTrabajo IS NULL OR ot = @OrdenDeTrabajo) AND
                     (@NumEconomico IS NULL OR eco = @NumEconomico) AND
                     (@NumFactura IS NULL OR num_factura = @NumFactura)
            END";

            string querycreatesp4 = @"
            CREATE PROCEDURE[dbo].[sp_SelectPathFolder]
            AS
            BEGIN
                SELECT(pathdirectory) FROM folderpath
                WHERE(id_path = '1')
            END";

            string querycreatesp5 = @"
            CREATE PROCEDURE[dbo].[sp_SelectRegistroFacturas]
            @IdMain varchar(50) = NULL,
            @OrdenDeTrabajo varchar(50) = NULL,
            @NumEconomico varchar(50) = NULL,
            @Monto varchar(50) = NULL,
            @FechaCot varchar(50) = NULL,
            @RazonSocial varchar(100) = NULL,
            @NumFactura varchar(50) = NULL,
            @Conceptos varchar(300) = NULL,
            @Ciudad varchar(50) = NULL,
            @MontoCImpuesto varchar(50) = NULL,
            @Estatus varchar(50) = NULL
            AS
            BEGIN
                SELECT
                    id_main AS 'ID PRINCIPAL',
                    ot AS 'ORDEN DE TRABAJO' ,
                    eco AS 'NUMERO ECONOMICO',
                    monto AS MONTO,
                    fecha_cot AS 'FECHA COTIZACION',
                    razon_social AS 'RAZON SOCIAL',
                    num_factura AS 'NUMERO DE FACTURA',
                    conceptos AS CONCEPTOS,
                    ciudad AS ESTADO,
                    monto_cimpuesto AS 'MONTO CON IMPUESTO',
                    estat AS ESTATUS
                FROM registros
                    WHERE(@IdMain IS NULL OR id_main LIKE @IdMain + '%') AND
                         (@OrdenDeTrabajo IS NULL OR ot LIKE @OrdenDeTrabajo + '%') AND
                         (@NumEconomico IS NULL OR eco LIKE @NumEconomico + '%') AND
                         (@Monto IS NULL OR monto LIKE @Monto + '%') AND
                         (@FechaCot IS NULL OR fecha_cot = @FechaCot) AND
                         (@RazonSocial IS NULL OR razon_social LIKE @RazonSocial + '%') AND
                         (@NumFactura IS NULL OR num_factura LIKE @NumFactura + '%') AND
                         (@Conceptos IS NULL OR conceptos LIKE @Conceptos + '%') AND
                         (@Ciudad IS NULL OR ciudad LIKE @Ciudad + '%') AND
                         (@MontoCImpuesto IS NULL OR monto_cimpuesto LIKE @MontoCImpuesto + '%') AND
                         (@Estatus IS NULL OR estat LIKE @Estatus)
            END";

            string querycreatesp6 = @"
            CREATE PROCEDURE[dbo].[sp_UpdateFolderPath]
            @DirectoryPath varchar(500)
            AS
            BEGIN
                UPDATE folderpath
                    SET pathdirectory = @DirectoryPath
                        WHERE id_path = '1'
            END";

            string querycreatesp7 = @"
            CREATE PROCEDURE[dbo].[sp_UpdateRegistroFacturas]
            @IdMain int,
            @OrdenDeTrabajo varchar(50),
            @NumEconomico varchar(50),
            @Monto varchar(50),
            @FechaCot date,
            @RazonSocial varchar(100),
            @NumFactura varchar(50),
            @Conceptos varchar(300),
            @Ciudad varchar(50),
            @MontoCImpuesto varchar(50),
            @Estatus varchar(50)
            AS
            BEGIN
                UPDATE registros
                    SET ot = @OrdenDeTrabajo,
                        eco = @NumEconomico,
                        monto = @Monto,
                        fecha_cot = @FechaCot,
                        razon_social = @RazonSocial,
                        num_factura = @NumFactura,
                        conceptos = @Conceptos,
                        ciudad = @Ciudad,
                        monto_cimpuesto = @MontoCImpuesto,
                        estat = @Estatus
                    WHERE id_main = @IdMain
            END";

            string querydefaultinsertfolderpath = @"
            INSERT INTO[dbo].[folderpath]
                ([pathdirectory])
            VALUES
                ('Seleccione un directorio')";
            

            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["unica"].ConnectionString);
            cn.Open();

            SqlCommand createdbcommand = new SqlCommand(querycreatedb, cn);
            createdbcommand.ExecuteNonQuery();

            SqlCommand createtbscommand = new SqlCommand(querycreatetbs, cn);
            createtbscommand.ExecuteNonQuery();

            SqlCommand createSP1command = new SqlCommand(querycreatesp1, cn);
            createSP1command.ExecuteNonQuery();

            SqlCommand createSP2command = new SqlCommand(querycreatesp2, cn);
            createSP2command.ExecuteNonQuery();

            SqlCommand createSP3command = new SqlCommand(querycreatesp3, cn);
            createSP3command.ExecuteNonQuery();

            SqlCommand createSP4command = new SqlCommand(querycreatesp4, cn);
            createSP4command.ExecuteNonQuery();

            SqlCommand createSP5command = new SqlCommand(querycreatesp5, cn);
            createSP5command.ExecuteNonQuery();

            SqlCommand createSP6command = new SqlCommand(querycreatesp6, cn);
            createSP6command.ExecuteNonQuery();

            SqlCommand createSP7command = new SqlCommand(querycreatesp7, cn);
            createSP7command.ExecuteNonQuery();

            SqlCommand insertdefaultpathcommand = new SqlCommand(querydefaultinsertfolderpath, cn);
            insertdefaultpathcommand.ExecuteNonQuery();
            

            cn.Close();
        }
    }
}
