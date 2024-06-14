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
using Caso_Desarrollo_Hotel.Forms;

namespace Caso_Desarrollo_Hotel
{
    public partial class Form1 : MaterialForm
    {
        public Form1()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Green400, Primary.Green400,
                 Primary.Green400, Accent.Green400, TextShade.WHITE
                );
        }

        private void materialButton6_Click(object sender, EventArgs e)
        {
            LoadForm(new FrmHotel());
        }

        private void LoadForm(Form frm)
        {
            Hide();
            frm.ShowDialog();
            Close();
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
