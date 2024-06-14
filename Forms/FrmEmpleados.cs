using Caso_Desarrollo_Hotel.Clases;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caso_Desarrollo_Hotel.Forms
{
    public partial class FrmEmpleados : MaterialForm
    {
        public FrmEmpleados()
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

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(TxtNombre.Text))
                {
                    throw new Exception("Nombre no puede estar vacio");
                }
                if (string.IsNullOrEmpty(TxtApellidos.Text))
                {
                    throw new Exception("Apellidos no puede estar vacio");
                }
                if (string.IsNullOrEmpty(TxtPos.Text))
                {
                    throw new Exception("Posicion no puede estar vacio");
                }
                if (string.IsNullOrEmpty(TxtEmail.Text))
                {
                    throw new Exception("Email no puede estar vacio");
                }
                if (string.IsNullOrEmpty(TxtTel.Text))
                {
                    throw new Exception("Telefono no puede estar vacio");
                }
                var item = new Empleado();
                item.Nombre = TxtNombre.Text;
                item.Email = TxtEmail.Text;
                item.Posicion = TxtPos.Text;
                item.Telefono = TxtTel.Text;
                item.Apellidos = TxtApellidos.Text;
                item.Id = Form1.Empleados.Count + "";
                if (Form1.AlertDialog("Desea Agregar mas?"))
                {
                    TxtNombre.Text = "";
                    TxtEmail.Text = "";
                    TxtPos.Text = "";
                    TxtTel.Text = "";
                    TxtApellidos.Text = "";
                    DtgDatos.DataSource = null;
                    DtgDatos.DataSource = Form1.Empleados;
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

        private void FrmEmpleados_Load(object sender, EventArgs e)
        {
            DtgDatos.DataSource = Form1.Empleados;

        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (DtgDatos.SelectedCells.Count > 0)
            {
                if (Form1.AlertDialog($"Desea Eliminar?"))
                {
                    Form1.Empleados.RemoveAll(v => v.Id == DtgDatos.Rows[DtgDatos.SelectedCells[0].RowIndex].Cells[0].Value.ToString());
                }
                DtgDatos.DataSource = null;
                DtgDatos.DataSource = Form1.Empleados;
            }
        }

        private void BtnReturn_Click(object sender, EventArgs e)
        {
            var frm = new Main();
            Hide();
            frm.ShowDialog();
            Close();
        }
    }
}
