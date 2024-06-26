﻿using System;
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
    public partial class FrmClientes : MaterialForm
    {
        public FrmClientes()
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
                if (string.IsNullOrEmpty(TxtApellidos.Text))
                {
                    throw new Exception("Apellidos no puede estar vacio");
                }
                if (string.IsNullOrEmpty(TxtEmail.Text))
                {
                    throw new Exception("Email no puede estar vacio");
                }
                if (string.IsNullOrEmpty(TxtTel.Text))
                {
                    throw new Exception("Telefono no puede estar vacio");
                }
                if (string.IsNullOrEmpty(TxtDir.Text))
                {
                    throw new Exception("Direccion no puede estar vacio");
                }
                var cliente = new Cliente();
                cliente.Nombre = TxtNombre.Text;
                cliente.Email = TxtEmail.Text;
                cliente.Direccion = TxtDir.Text;
                cliente.Telefono = TxtTel.Text;
                cliente.Apellidos = TxtApellidos.Text;
                cliente.Id = Form1.Clientes.Count + "";
                Form1.Clientes.Add(cliente);
                if (Form1.AlertDialog("Desea Agregar mas?"))
                {
                    TxtNombre.Text = "";
                    TxtEmail.Text = "";
                    TxtDir.Text = "";
                    TxtTel.Text = "";
                    TxtApellidos.Text = "";
                    DtgDatos.DataSource = null;
                    DtgDatos.DataSource = Form1.Clientes;
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

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            DtgDatos.DataSource = Form1.Clientes;

        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (DtgDatos.SelectedCells.Count>0)
            {
                if (Form1.AlertDialog($"Desea Eliminar?"))
                {
                    Form1.Clientes.RemoveAll(v => v.Id == DtgDatos.Rows[DtgDatos.SelectedCells[0].RowIndex].Cells[0].Value.ToString());
                }
                DtgDatos.DataSource = null;
                DtgDatos.DataSource = Form1.Clientes;
            }
        }
    }
}
