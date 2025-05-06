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
        bool bandera = false;
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
            bandera = true;

        }

        private void frmStoreUnico_Load(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Datos dt = new Datos();
            if (bandera == true)
            {
                //Actualizar
                string sql = "Update Stores set stor_name='" + txtNombre.Text 
                    + "',stor_address='" + txtDireccion.Text +
                    "',city='" + txtCiudad.Text +
                    "',state='" + txtEstado.Text +
                    "',zip='" + txtCP.Text +
                    "' where stor_id=" + id;             
                dt.EjecutarComando(sql); 
                MessageBox.Show("Tienda Actualizada");
                
            }
            else
            {
                //Insertar
                string sql = "Insert into Stores(stor_name,stor_address," +
                    "city,state,zip) " +
                    "values('" + txtNombre.Text + "','" + txtDireccion.Text +
                    "','" + txtCiudad.Text + "','" + txtEstado.Text +
                    "','" + txtCP.Text + "')";               
                dt.EjecutarComando(sql);
                MessageBox.Show("Tienda Agregada");

            }
            this.Close();
        }
    }
}
