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
using Caso_Desarrollo_Hotel.Clases;

namespace Caso_Desarrollo_Hotel
{
    public partial class Form1 : MaterialForm
    {
        public static List<Hotel> Hoteles = new List<Hotel>() { new Hotel("1", "Las Amapolas", "Upala Centro", "Upala", "CR", 3) };
        int intentos = 3;
        public static Hotel Hotel = Hoteles[0];
        public static List<Cliente> Clientes = new List<Cliente>();
        public static List<Empleado> Empleados = new List<Empleado>();

        public static List<Factura> Facturas = new List<Factura>();

        //public static List<Habitacion> Habitaciones = new List<Habitacion>();

        public static List<Pago> Pagos = new List<Pago>();
        public static List<Reserva> Reservas = new List<Reserva>();

        public Form1()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Green400, Primary.Green200,
                 Primary.Green50, Accent.Green700, TextShade.WHITE
                );
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
        }

       

        public static bool AlertDialog(string text)
        {
            return MessageBox.Show(text, "ALERTA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes;
        }

        private void materialButton9_Click(object sender, EventArgs e)
        {
            if (TxtUsuario.Text=="sa" && TxtClave.Text=="123")
            {
                var frm = new Main();
                Hide();
                frm.ShowDialog();
                Environment.Exit(0);
            }
            else
            {
                intentos--;
                if (intentos==0)
                {
                    Environment.Exit(0);
                }
                MessageBox.Show("Error "+ intentos+" intento restantes");
            }
        }
    }
}
