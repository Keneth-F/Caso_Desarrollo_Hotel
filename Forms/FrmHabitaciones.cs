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
    public partial class FrmHabitaciones : MaterialForm
    {
        public FrmHabitaciones()
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
                if (Form1.Hotel.Habitaciones.Exists(r => r.Id == TxtNumero.Text))
                {
                    throw new Exception("Ya existe");
                }
                if (!int.TryParse(TxtCapacidad.Text, out _))
                {
                    throw new Exception("Capacidad Invalido");
                }
                if (!Double.TryParse(TxtPrecio.Text, out _))
                {
                    throw new Exception("Precio Invalido");
                }
                if (CbTipo.SelectedItem==null)
                {
                    throw new Exception("Tipo no Indicado");
                }
                
                
                var item = new Habitacion();
                item.Capacidad = int.Parse(TxtCapacidad.Text);
                item.Numero = int.Parse(TxtNumero.Text);
                item.Precio =Double.Parse( TxtPrecio.Text);
                item.Tipo = CbTipo.SelectedItem.ToString();
                item.HotelId = Form1.Hotel.Id;
                item.Id = Form1.Facturas.Count + "";
                Form1.Hotel.Habitaciones.Add(item);
                if (Form1.AlertDialog("Desea Agregar mas?"))
                {
                    TxtCapacidad.Text = "";
                    TxtNumero.Text = "";
                    TxtPrecio.Text= "";
                    DtgDatos.DataSource = null;
                    DtgDatos.DataSource = Form1.Hotel.Habitaciones;
                }
                else
                {
                    var frm = new Main();
                    Hide();
                    frm.ShowDialog();
                    Close();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }

        }

        private void FrmHabitaciones_Load(object sender, EventArgs e)
        {
            DtgDatos.DataSource = Form1.Hotel.Habitaciones;

        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (DtgDatos.SelectedCells.Count > 0)
            {
                if (Form1.AlertDialog($"Desea Eliminar?"))
                {
                    Form1.Hotel.Habitaciones.RemoveAll(v => v.Id == DtgDatos.Rows[DtgDatos.SelectedCells[0].RowIndex].Cells[0].Value.ToString());
                }
                DtgDatos.DataSource = null;
                DtgDatos.DataSource = Form1.Hotel.Habitaciones;
            }
        }
    }
}
