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
    public partial class frmStoreUnico : Form
    {
        int id = 0;
        public frmStoreUnico() //Insertar
        {
            InitializeComponent();
        }       

        public frmStoreUnico(int id,string nombre,
            string direccion,string ciudad,string estado,
            string cp) //Actualizar
        {
            InitializeComponent();
            this.id = id;
            txtNombre.Text = nombre;
            txtDireccion.Text = direccion;
            txtCiudad.Text = ciudad;
            txtEstado.Text = estado;
            txtCP.Text = cp;
            
        }

        private void frmStoreUnico_Load(object sender, EventArgs e)
        {

        }
    }
}
