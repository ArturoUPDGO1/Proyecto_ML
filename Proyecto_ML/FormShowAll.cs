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
    public partial class FormShowAll : Form
    {
        Consulta consulshow = new Consulta();
        public FormShowAll()
        {
            InitializeComponent();

            string id, ot, eco, mon, fc, rs, nf, con, ciu, mci, estml;

            id = null;
            ot = null;
            eco = null;
            mon = null;
            fc = null;
            rs = null;
            nf = null;
            con = null;
            ciu = null;
            mci = null;
            estml = "1";
           
            //Muestra todos los datos con valor estatus = activo 
            dgvAllDatos.DataSource = consulshow.MostrarFacturas(id, ot, eco, mon, fc, rs, nf, con, ciu, mci, estml);
        }



    }
}
