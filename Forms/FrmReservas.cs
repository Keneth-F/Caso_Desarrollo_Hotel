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
    public partial class FrmReservas : MaterialForm
    {
        public FrmReservas()
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
                if (!Form1.Clientes.Exists(r => r.Id == TxtCliente.Text))
                {
                    throw new Exception("Cliente no Existe");
                }
                if (!Form1.Hotel.Habitaciones.Exists(r => r.Id == TxtHabitacion.Text))
                {
                    throw new Exception("Habitacion no Existe");
                }                
                if (Form1.Reservas.Exists(
                    r =>
                    r.Id == TxtHabitacion.Text 
                    && (DtpInicio.Value.Year >=r.FechaInicio.Year && DtpInicio.Value.Year <= r.FechaFin.Year)
                    && (DtpInicio.Value.Month >= r.FechaInicio.Month && DtpInicio.Value.Month <= r.FechaFin.Month)
                    && (DtpInicio.Value.Date >= r.FechaInicio.Date && DtpInicio.Value.Date <= r.FechaFin.Date)
                    ))
                {
                    throw new Exception("Habitacion ya Reservada ese dia");
                }
               
                
                var item = new Reserva();
                item.Estado = ChbReserved.Checked;
                item.ClienteId = TxtCliente.Text;
                item.HabitacionId = TxtHabitacion.Text;
                item.FechaInicio = DtpInicio.Value;
                item.FechaFin = DtpFinal.Value;
                item.Id = Form1.Reservas.Count + "";
                Form1.Reservas.Add(item);
                if (Form1.AlertDialog("Desea Agregar mas?"))
                {
                    TxtCliente.Text = "";
                    TxtHabitacion.Text = "";
                    DtgDatos.DataSource = null;
                    DtgDatos.DataSource = Form1.Reservas;
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

        private void FrmReservas_Load(object sender, EventArgs e)
        {
            DtgDatos.DataSource = Form1.Reservas;

        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (DtgDatos.SelectedCells.Count > 0)
            {
                if (Form1.AlertDialog($"Desea Eliminar?"))
                {
                    Form1.Reservas.RemoveAll(v => v.Id == DtgDatos.Rows[DtgDatos.SelectedCells[0].RowIndex].Cells[0].Value.ToString());
                }
                DtgDatos.DataSource = null;
                DtgDatos.DataSource = Form1.Reservas;
            }
        }
    }
}
