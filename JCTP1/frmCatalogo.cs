using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JCTP1
{
    public partial class frmCatalogo : Form
    {
        private List<Archivo> listaArchivos;
        public frmCatalogo()
        {
            InitializeComponent();
        }

        private void frmCatalogo_Load(object sender, EventArgs e)
        {
            cargar();
            campoBox.Items.Add("Nombre");
            campoBox.Items.Add("Codigo");
            criterioBox.Items.Clear();
            criterioBox.Items.Add("Comienza con");
            criterioBox.Items.Add("Termina con");
            criterioBox.Items.Add("Contiene");
        }

        private void buscar_Click(object sender, EventArgs e)
        {
            List<Archivo>listaFiltrada;
            if (filtro.Text != "")
                listaFiltrada = listaArchivos.FindAll(x => x.Nombre.ToUpper().Contains(filtro.Text.ToUpper()));
            else
                listaFiltrada = listaArchivos;
            dgvArchivo.DataSource = null;
            dgvArchivo.DataSource = listaFiltrada;
            ocultarColumnas();
        }

        private void cargar()
        {
            ArchivoNegocio negocio = new ArchivoNegocio();
            try
            {
                listaArchivos = negocio.listar();
                dgvArchivo.DataSource = listaArchivos;
                ocultarColumnas();
                cargarImagen(listaArchivos[0].ImagenUrl);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void ocultarColumnas()
        {
            dgvArchivo.Columns["ImagenUrl"].Visible = false;
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                pbxArchivo.Load(imagen);
            }
            catch (Exception)
            {
                pbxArchivo.Load("https://efectocolibri.com/wp-content/uploads/2021/01/placeholder.png");
            }
        }

        private void dgvArchivo_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvArchivo.CurrentRow != null)
            {
                Archivo seleccionado = (Archivo)dgvArchivo.CurrentRow.DataBoundItem;
                cargarImagen(seleccionado.ImagenUrl);
            }
        }

        private void busquedaAvanzada_Click(object sender, EventArgs e)
        {
            ArchivoNegocio negocio = new ArchivoNegocio();
            try
            {
                if (validarFiltro())
                    return;

                string campo = campoBox.SelectedItem.ToString();
                string criterio = criterioBox.SelectedItem.ToString();
                string filtro = txtFiltroAvanzado.Text;
                dgvArchivo.DataSource = negocio.filtrar(campo, criterio, filtro);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private bool validarFiltro()
        {
            if (campoBox.SelectedIndex < 0)
            {
                MessageBox.Show("Por favor, seleccione el campo para filtrar.");
                return true;
            }
            if (criterioBox.SelectedIndex < 0)
            {
                MessageBox.Show("Por favor, seleccione el criterio para filtrar.");
                return true;
            }
            if(txtFiltroAvanzado.Text == "")
            {
                MessageBox.Show("Completar en filtro, por default vuelve a la tabla.");
                dgvArchivo.DataSource = listaArchivos;
                ocultarColumnas();
                return true;
            }
            return false;
        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            frmAlta alta = new frmAlta();
            alta.ShowDialog();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Archivo seleccionado;
            seleccionado = (Archivo)dgvArchivo.CurrentRow.DataBoundItem;
            frmAlta modificar = new frmAlta(seleccionado);
            modificar.ShowDialog();
            cargar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ArchivoNegocio negocio = new ArchivoNegocio();
            Archivo seleccionado;
            try 
            {
                seleccionado = (Archivo)dgvArchivo.CurrentRow.DataBoundItem;
                negocio.eliminar(seleccionado.Id);
                cargar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
