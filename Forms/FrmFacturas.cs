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
    public partial class FrmFacturas : MaterialForm
    {
        public FrmFacturas()
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

        private void materialButton3_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Form1.Reservas.Exists(r=>r.Id==TxtReserva.Text))
                {
                    throw new Exception("Reserva no Existe");
                }
                if (!Form1.Clientes.Exists(r => r.Id == TxtCliente.Text))
                {
                    throw new Exception("Cliente no Existe");
                }
                if (!Form1.Empleados.Exists(r => r.Id == TxtEmpleado.Text))
                {
                    throw new Exception("Empleado no Existe");
                }
                if (!Double.TryParse(TxtMonto.Text,out _))
                {
                    throw new Exception("Monto Invalido");
                }
                var item = new Factura();
                item.ReservaId = TxtReserva.Text;
                item.ClienteId = TxtCliente.Text;
                item.EmpleadoId = TxtEmpleado.Text;
                item.FechaEmision = DateTime.Now;
                item.Id = Form1.Facturas.Count+"";
                Form1.Facturas.Add(item);
                if (Form1.AlertDialog("Desea Agregar mas?"))
                {
                     TxtReserva.Text = "";
                     TxtCliente.Text= "";
                     TxtEmpleado.Text="";
                    DtgDatos.DataSource = null;
                    DtgDatos.DataSource = Form1.Facturas;
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

        private void FrmFacturas_Load(object sender, EventArgs e)
        {
            DtgDatos.DataSource = Form1.Facturas;

        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            if (DtgDatos.SelectedCells.Count > 0)
            {
                if (Form1.AlertDialog($"Desea Eliminar?"))
                {
                    Form1.Facturas.RemoveAll(v => v.Id == DtgDatos.Rows[DtgDatos.SelectedCells[0].RowIndex].Cells[0].Value.ToString());
                }
                DtgDatos.DataSource = null;
                DtgDatos.DataSource = Form1.Facturas;
            }
        }
    }
}
