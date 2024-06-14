using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using MaterialSkin;
using Caso_Desarrollo_Hotel.Clases;
namespace Caso_Desarrollo_Hotel.Forms
{
    public partial class FrmHotel : MaterialForm
    {
        public FrmHotel()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Green400, Primary.Green200,
                 Primary.Green500, Accent.Green700, TextShade.WHITE
                );
        }

        private void BtnReturn_Click(object sender, EventArgs e)
        {
            var frm = new Main();
            Hide();
            frm.ShowDialog();
            Close();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(TxtNombre.Text))
                {
                    throw new Exception("Nombre no puede estar vacio");
                }
                if (string.IsNullOrEmpty(TxtCiudad.Text))
                {
                    throw new Exception("Ciudad no puede estar vacio");
                }
                if (string.IsNullOrEmpty(TxtDir.Text))
                {
                    throw new Exception("Direccion no puede estar vacio");
                }
                if (string.IsNullOrEmpty(TxtPais.Text))
                {
                    throw new Exception("Pais no puede estar vacio");
                }
                //Main.Hotel.Habitaciones=
                Form1.Hotel.Nombre = TxtNombre.Text;
                Form1.Hotel.Ciudad = TxtCiudad.Text;
                Form1.Hotel.Direccion = TxtDir.Text;
                Form1.Hotel.Pais = TxtPais.Text;
                Form1.Hotel.Estrellas = SlEstrellas.Value;

                var frm = new Main();
                Hide();
                frm.ShowDialog();
                Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void FrmHotel_Load(object sender, EventArgs e)
        {
            DtgDatos.DataSource = Form1.Hotel.Habitaciones;
            TxtNombre.Text=       Form1.Hotel.Nombre;
            TxtCiudad.Text=       Form1.Hotel.Ciudad;
            TxtDir.Text =         Form1.Hotel.Direccion;
            TxtPais.Text=         Form1.Hotel.Pais;
            SlEstrellas.Value= Form1.Hotel.Estrellas;

        }
    }
}
