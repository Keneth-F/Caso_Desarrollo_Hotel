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
    public partial class FrmPagos : MaterialForm
    {
        public FrmPagos()
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
                if (Form1.Pagos.Exists(r => r.Id == TxtReserva.Text))
                {
                    throw new Exception("Ya existe");
                }
                if (!Double.TryParse(TxtMonto.Text, out _))
                {
                    throw new Exception("Monto Invalido");
                }
                string metodoPago = Rbtn1.Text ;
                if (Rbtn2.Checked)
                {
                    metodoPago= Rbtn2 .Text ;
                }
                else
                {
                    metodoPago = Rbtn3.Text;
                }


                var item = new Pago();
                item.FechaPago = DateTime.Now;
                item.MetodoPago = metodoPago;
                item.ReservaId = TxtReserva.Text;
                item.Monto =Double.Parse(TxtMonto.Text);
                item.Id = Form1.Pagos.Count + "";
                Form1.Pagos.Add(item);
                if (Form1.AlertDialog("Desea Agregar mas?"))
                {
                    TxtReserva.Text = "";
                    TxtMonto.Text = "";
                    DtgDatos.DataSource = null;
                    DtgDatos.DataSource = Form1.Pagos;
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

        private void FrmPagos_Load(object sender, EventArgs e)
        {
            DtgDatos.DataSource = Form1.Pagos;

        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (DtgDatos.SelectedCells.Count > 0)
            {
                if (Form1.AlertDialog($"Desea Eliminar?"))
                {
                    Form1.Pagos.RemoveAll(v => v.Id == DtgDatos.Rows[DtgDatos.SelectedCells[0].RowIndex].Cells[0].Value.ToString());
                }
                DtgDatos.DataSource = null;
                DtgDatos.DataSource = Form1.Pagos;
            }
        }
    }
}
