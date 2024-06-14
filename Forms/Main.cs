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
    public partial class Main : MaterialForm
    {
        public Main()
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

        private void Main_Load(object sender, EventArgs e)
        {
            Text = "Hotel " + Form1.Hotel.Nombre;

        }
        private void materialButton8_Click(object sender, EventArgs e)
        {
            LoadForm(new FrmEmpleados());
        }
        private void materialButton6_Click(object sender, EventArgs e)
        {
            LoadForm(new FrmHotel());
        }

        private void LoadForm(Form frm)
        {
            Hide();
            frm.ShowDialog();
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            LoadForm(new FrmFacturas());
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            LoadForm(new FrmHabitaciones());
        }

        private void materialButton4_Click(object sender, EventArgs e)
        {
            LoadForm(new FrmClientes());
        }

        private void materialButton3_Click(object sender, EventArgs e)
        {
            LoadForm(new FrmReservas());
        }

        private void materialButton5_Click(object sender, EventArgs e)
        {
            LoadForm(new FrmPagos());
        }

        private void materialButton7_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
