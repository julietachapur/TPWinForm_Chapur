using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace JCTP1
{
    public partial class frmAlta : Form
    {
        private Archivo arch = null;
        private OpenFileDialog carpeta = null;
        public frmAlta()
        {
            InitializeComponent();
        }

        public frmAlta(Archivo archivo)
        {
            InitializeComponent();
            this.arch = archivo;
            Text = "Modificar";
        }


        private void btnAceptar_Click(object sender, EventArgs e)
        {
            ArchivoNegocio negocio = new ArchivoNegocio();
            try
            {
                if (arch == null)
                    arch = new Archivo();
                arch.Codigo = txtCodigo.Text;
                arch.Nombre = txtNombre.Text;
                arch.Descripcion = txtDescripcion.Text;
                arch.Marca = (Marcas)cmbxMarca.SelectedItem;
                arch.ImagenUrl = txtImagen.Text;
                arch.Categoria = (Categorias)cmbxCategoria.SelectedItem;
                arch.Precio = decimal.Parse(txtPrecio.Text);

                if (arch.Id != 0)
                {
                    if (arch.Codigo == "" || arch.Nombre == "" || arch.Descripcion == "")
                    {
                        MessageBox.Show("Complete los campos vacios");
                        return;
                    }
                    negocio.modificar(arch);
                    MessageBox.Show("Modificado exitosamente");
                }
                else
                {
                    negocio.agregar(arch);
                    MessageBox.Show("Agregado exitosamente");
                }

                if (carpeta != null && !(txtImagen.Text.ToUpper().Contains("HTTP")))
                    File.Copy(carpeta.FileName, ConfigurationManager.AppSettings["images-folder"] + carpeta.SafeFileName);
                
                Close();

            }
            catch(Exception)
            {
                MessageBox.Show("Datos incorrectos, vuelva a intentar");
                return;
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmAlta_Load(object sender, EventArgs e)
        {
            MarcasNegocio marcasNegocio = new MarcasNegocio();
            CategoriasNegocio categoriasNegocio = new CategoriasNegocio();
            try
            {
                cmbxMarca.DataSource = marcasNegocio.listar();
                cmbxMarca.ValueMember = "Id";
                cmbxMarca.DisplayMember = "Descripcion";
                cmbxCategoria.DataSource = categoriasNegocio.listar();
                cmbxCategoria.ValueMember = "Id";
                cmbxCategoria.DisplayMember = "Descripcion";

                if (arch!= null)
                {
                    txtCodigo.Text = arch.Codigo;
                    txtNombre.Text = arch.Nombre;
                    txtDescripcion.Text = arch.Descripcion;
                    txtImagen.Text = arch.ImagenUrl;
                    cargarImagen(arch.ImagenUrl);
                    cmbxMarca.SelectedValue = arch.Marca.Id;
                    cmbxCategoria.SelectedValue = arch.Categoria.Id;
                    txtPrecio.Text = arch.Precio.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
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
    }
}
