using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TiendaCarros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        carro n = new carro();
        inicio a;
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            a = new inicio();
            a.pla = txtPlacas.Text;
            a.mar = txtModelo.Text;
            a.mo = txtMarca.Text;
            a.tel = txtTelefono.Text;
            a.ano = txtAño.Text;
            n.agregar(a);
            if (n.i < n.t)
            {
                MessageBox.Show(" agregado correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Sin espacio", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            txtPlacas.Clear();
            txtMarca.Clear();
            txtModelo.Clear();
            txtTelefono.Clear();
            txtAño.Clear();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            //listar
            txtMostrar.Text = Convert.ToString(n.listar()); 
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //buscar
            if (n.buscar(a.pla) == null)
            {
                txtMostrar.Clear();

                a.pla = txtPlacas.Text;

                MessageBox.Show(" encontrado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("no encontrado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            txtMostrar.Clear();
            a.pla = txtPlacas.Text;
            a.mar = txtMarca.Text;
            a.mo = txtModelo.Text;
            a.tel = txtTelefono.Text;
            a.ano = txtAño.Text;
            MessageBox.Show(" eliminado correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            //insertar
            int pso = Convert.ToInt32(txtPosicion.Text);
            txtMostrar.Clear();
            a.pla = txtPlacas.Text;
            a.mar = txtMarca.Text;
            a.mo = txtModelo.Text;
            a.tel = txtTelefono.Text;
            a.ano = txtAño.Text;
            MessageBox.Show("insertado correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
