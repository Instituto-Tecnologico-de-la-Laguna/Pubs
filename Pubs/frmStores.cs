using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pubs
{
    public partial class frmStores : Form
    {
        Datos dt = new Datos();
        public frmStores()
        {
            InitializeComponent();
        }

        private void Actualizar()
        {
            DataSet ds;
            ds = dt.comandoDS("Select stor_id as [No. Tienda], " +
                "stor_name as [Nombre],stor_address as [Direccion], " +
                "city as Ciudad, state as Estado,zip as [C.P.] " +
                "from Stores");
            if (ds != null)
            {
                dgvTienda.DataSource = ds.Tables[0];
            }
        }
        private void frmStores_Load(object sender, EventArgs e)
        {
            Actualizar();

        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            DataSet ds;
            ds = dt.comandoDS("Select stor_id as [No. Tienda], " +
                "stor_name as [Nombre],stor_address as [Direccion], " +
                "city as Ciudad, state as Estado,zip as [C.P.] " +
                "from Stores " +
                "Where stor_name like '"+txtBusqueda .Text +"%'");
            if (ds != null)
            {
                dgvTienda.DataSource = ds.Tables[0];
            }

        }

        private void toolStripMenuActualizar_Click(object sender, EventArgs e)
        {
            int i = dgvTienda.CurrentRow.Index;
            frmStoreUnico storeUnico = new frmStoreUnico(
                Convert.ToInt32(dgvTienda.Rows[i].Cells[0].Value),
                dgvTienda.Rows[i].Cells[1].Value.ToString(),
                dgvTienda.Rows[i].Cells[2].Value.ToString(),
                dgvTienda.Rows[i].Cells[3].Value.ToString(),
                dgvTienda.Rows[i].Cells[4].Value.ToString(),
                dgvTienda.Rows[i].Cells[5].Value.ToString());
            storeUnico.Show();
        }

        private void frmStores_Activated(object sender, EventArgs e)
        {
            Actualizar();
        }
    }
}
