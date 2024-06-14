namespace Caso_Desarrollo_Hotel.Forms
{
    partial class FrmFacturas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DtgDatos = new System.Windows.Forms.DataGridView();
            this.TxtMonto = new MaterialSkin.Controls.MaterialTextBox2();
            this.TxtEmpleado = new MaterialSkin.Controls.MaterialTextBox2();
            this.TxtCliente = new MaterialSkin.Controls.MaterialTextBox2();
            this.TxtReserva = new MaterialSkin.Controls.MaterialTextBox2();
            this.BtnReturn = new MaterialSkin.Controls.MaterialButton();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.materialButton2 = new MaterialSkin.Controls.MaterialButton();
            this.materialButton3 = new MaterialSkin.Controls.MaterialButton();
            this.materialButton4 = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.DtgDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // DtgDatos
            // 
            this.DtgDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgDatos.Location = new System.Drawing.Point(344, 77);
            this.DtgDatos.Name = "DtgDatos";
            this.DtgDatos.RowHeadersWidth = 51;
            this.DtgDatos.RowTemplate.Height = 24;
            this.DtgDatos.Size = new System.Drawing.Size(666, 426);
            this.DtgDatos.TabIndex = 21;
            // 
            // TxtMonto
            // 
            this.TxtMonto.AnimateReadOnly = false;
            this.TxtMonto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TxtMonto.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.TxtMonto.Depth = 0;
            this.TxtMonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TxtMonto.HideSelection = true;
            this.TxtMonto.Hint = "Monto Total";
            this.TxtMonto.LeadingIcon = null;
            this.TxtMonto.Location = new System.Drawing.Point(15, 242);
            this.TxtMonto.MaxLength = 32767;
            this.TxtMonto.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtMonto.Name = "TxtMonto";
            this.TxtMonto.PasswordChar = '\0';
            this.TxtMonto.PrefixSuffixText = null;
            this.TxtMonto.ReadOnly = false;
            this.TxtMonto.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TxtMonto.SelectedText = "";
            this.TxtMonto.SelectionLength = 0;
            this.TxtMonto.SelectionStart = 0;
            this.TxtMonto.ShortcutsEnabled = true;
            this.TxtMonto.Size = new System.Drawing.Size(250, 48);
            this.TxtMonto.TabIndex = 14;
            this.TxtMonto.TabStop = false;
            this.TxtMonto.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtMonto.TrailingIcon = null;
            this.TxtMonto.UseSystemPasswordChar = false;
            // 
            // TxtEmpleado
            // 
            this.TxtEmpleado.AnimateReadOnly = false;
            this.TxtEmpleado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TxtEmpleado.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.TxtEmpleado.Depth = 0;
            this.TxtEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TxtEmpleado.HideSelection = true;
            this.TxtEmpleado.Hint = "Empleado";
            this.TxtEmpleado.LeadingIcon = null;
            this.TxtEmpleado.Location = new System.Drawing.Point(15, 188);
            this.TxtEmpleado.MaxLength = 32767;
            this.TxtEmpleado.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtEmpleado.Name = "TxtEmpleado";
            this.TxtEmpleado.PasswordChar = '\0';
            this.TxtEmpleado.PrefixSuffixText = null;
            this.TxtEmpleado.ReadOnly = false;
            this.TxtEmpleado.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TxtEmpleado.SelectedText = "";
            this.TxtEmpleado.SelectionLength = 0;
            this.TxtEmpleado.SelectionStart = 0;
            this.TxtEmpleado.ShortcutsEnabled = true;
            this.TxtEmpleado.Size = new System.Drawing.Size(250, 48);
            this.TxtEmpleado.TabIndex = 13;
            this.TxtEmpleado.TabStop = false;
            this.TxtEmpleado.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtEmpleado.TrailingIcon = null;
            this.TxtEmpleado.UseSystemPasswordChar = false;
            // 
            // TxtCliente
            // 
            this.TxtCliente.AnimateReadOnly = false;
            this.TxtCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TxtCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.TxtCliente.Depth = 0;
            this.TxtCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TxtCliente.HideSelection = true;
            this.TxtCliente.Hint = "Id Cliente";
            this.TxtCliente.LeadingIcon = null;
            this.TxtCliente.Location = new System.Drawing.Point(15, 134);
            this.TxtCliente.MaxLength = 32767;
            this.TxtCliente.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtCliente.Name = "TxtCliente";
            this.TxtCliente.PasswordChar = '\0';
            this.TxtCliente.PrefixSuffixText = null;
            this.TxtCliente.ReadOnly = false;
            this.TxtCliente.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TxtCliente.SelectedText = "";
            this.TxtCliente.SelectionLength = 0;
            this.TxtCliente.SelectionStart = 0;
            this.TxtCliente.ShortcutsEnabled = true;
            this.TxtCliente.Size = new System.Drawing.Size(250, 48);
            this.TxtCliente.TabIndex = 12;
            this.TxtCliente.TabStop = false;
            this.TxtCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtCliente.TrailingIcon = null;
            this.TxtCliente.UseSystemPasswordChar = false;
            // 
            // TxtReserva
            // 
            this.TxtReserva.AnimateReadOnly = false;
            this.TxtReserva.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TxtReserva.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.TxtReserva.Depth = 0;
            this.TxtReserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TxtReserva.HideSelection = true;
            this.TxtReserva.Hint = "Id Reserva";
            this.TxtReserva.LeadingIcon = null;
            this.TxtReserva.Location = new System.Drawing.Point(15, 80);
            this.TxtReserva.MaxLength = 32767;
            this.TxtReserva.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtReserva.Name = "TxtReserva";
            this.TxtReserva.PasswordChar = '\0';
            this.TxtReserva.PrefixSuffixText = null;
            this.TxtReserva.ReadOnly = false;
            this.TxtReserva.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TxtReserva.SelectedText = "";
            this.TxtReserva.SelectionLength = 0;
            this.TxtReserva.SelectionStart = 0;
            this.TxtReserva.ShortcutsEnabled = true;
            this.TxtReserva.Size = new System.Drawing.Size(250, 48);
            this.TxtReserva.TabIndex = 11;
            this.TxtReserva.TabStop = false;
            this.TxtReserva.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtReserva.TrailingIcon = null;
            this.TxtReserva.UseSystemPasswordChar = false;
            // 
            // BtnReturn
            // 
            this.BtnReturn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnReturn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.BtnReturn.Depth = 0;
            this.BtnReturn.HighEmphasis = true;
            this.BtnReturn.Icon = global::Caso_Desarrollo_Hotel.Properties.Resources.arrow_left;
            this.BtnReturn.Location = new System.Drawing.Point(16, 467);
            this.BtnReturn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BtnReturn.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnReturn.Name = "BtnReturn";
            this.BtnReturn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.BtnReturn.Size = new System.Drawing.Size(122, 36);
            this.BtnReturn.TabIndex = 20;
            this.BtnReturn.Text = "Regresar";
            this.BtnReturn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.BtnReturn.UseAccentColor = false;
            this.BtnReturn.UseVisualStyleBackColor = true;
            this.BtnReturn.Click += new System.EventHandler(this.BtnReturn_Click);
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSize = false;
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = global::Caso_Desarrollo_Hotel.Properties.Resources.trash;
            this.materialButton1.Location = new System.Drawing.Point(280, 179);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(57, 45);
            this.materialButton1.TabIndex = 25;
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            // 
            // materialButton2
            // 
            this.materialButton2.AutoSize = false;
            this.materialButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton2.Depth = 0;
            this.materialButton2.HighEmphasis = true;
            this.materialButton2.Icon = global::Caso_Desarrollo_Hotel.Properties.Resources.edit;
            this.materialButton2.Location = new System.Drawing.Point(280, 131);
            this.materialButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton2.Name = "materialButton2";
            this.materialButton2.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton2.Size = new System.Drawing.Size(57, 45);
            this.materialButton2.TabIndex = 24;
            this.materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton2.UseAccentColor = false;
            this.materialButton2.UseVisualStyleBackColor = true;
            // 
            // materialButton3
            // 
            this.materialButton3.AutoSize = false;
            this.materialButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton3.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton3.Depth = 0;
            this.materialButton3.HighEmphasis = true;
            this.materialButton3.Icon = global::Caso_Desarrollo_Hotel.Properties.Resources.check;
            this.materialButton3.Location = new System.Drawing.Point(280, 80);
            this.materialButton3.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton3.Name = "materialButton3";
            this.materialButton3.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton3.Size = new System.Drawing.Size(57, 45);
            this.materialButton3.TabIndex = 23;
            this.materialButton3.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton3.UseAccentColor = false;
            this.materialButton3.UseVisualStyleBackColor = true;
            // 
            // materialButton4
            // 
            this.materialButton4.AutoSize = false;
            this.materialButton4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton4.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton4.Depth = 0;
            this.materialButton4.HighEmphasis = true;
            this.materialButton4.Icon = global::Caso_Desarrollo_Hotel.Properties.Resources.search;
            this.materialButton4.Location = new System.Drawing.Point(280, 227);
            this.materialButton4.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton4.Name = "materialButton4";
            this.materialButton4.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton4.Size = new System.Drawing.Size(57, 45);
            this.materialButton4.TabIndex = 22;
            this.materialButton4.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton4.UseAccentColor = false;
            this.materialButton4.UseVisualStyleBackColor = true;
            // 
            // FrmFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 520);
            this.Controls.Add(this.materialButton1);
            this.Controls.Add(this.materialButton2);
            this.Controls.Add(this.materialButton3);
            this.Controls.Add(this.materialButton4);
            this.Controls.Add(this.DtgDatos);
            this.Controls.Add(this.BtnReturn);
            this.Controls.Add(this.TxtMonto);
            this.Controls.Add(this.TxtEmpleado);
            this.Controls.Add(this.TxtCliente);
            this.Controls.Add(this.TxtReserva);
            this.Name = "FrmFacturas";
            this.Text = "FrmFacturas";
            ((System.ComponentModel.ISupportInitialize)(this.DtgDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DtgDatos;
        private MaterialSkin.Controls.MaterialButton BtnReturn;
        private MaterialSkin.Controls.MaterialTextBox2 TxtMonto;
        private MaterialSkin.Controls.MaterialTextBox2 TxtEmpleado;
        private MaterialSkin.Controls.MaterialTextBox2 TxtCliente;
        private MaterialSkin.Controls.MaterialTextBox2 TxtReserva;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialButton materialButton2;
        private MaterialSkin.Controls.MaterialButton materialButton3;
        private MaterialSkin.Controls.MaterialButton materialButton4;
    }
}