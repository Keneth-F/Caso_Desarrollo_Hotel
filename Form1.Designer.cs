namespace Caso_Desarrollo_Hotel
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.materialButton9 = new MaterialSkin.Controls.MaterialButton();
            this.TxtClave = new MaterialSkin.Controls.MaterialTextBox();
            this.TxtUsuario = new MaterialSkin.Controls.MaterialTextBox();
            this.SuspendLayout();
            // 
            // materialButton9
            // 
            this.materialButton9.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton9.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton9.Depth = 0;
            this.materialButton9.HighEmphasis = true;
            this.materialButton9.Icon = null;
            this.materialButton9.Location = new System.Drawing.Point(71, 270);
            this.materialButton9.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton9.Name = "materialButton9";
            this.materialButton9.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton9.Size = new System.Drawing.Size(91, 36);
            this.materialButton9.TabIndex = 42;
            this.materialButton9.Text = "Ingresar";
            this.materialButton9.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton9.UseAccentColor = false;
            this.materialButton9.UseVisualStyleBackColor = true;
            this.materialButton9.Click += new System.EventHandler(this.materialButton9_Click);
            // 
            // TxtClave
            // 
            this.TxtClave.AnimateReadOnly = false;
            this.TxtClave.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtClave.Depth = 0;
            this.TxtClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TxtClave.Hint = "Clave";
            this.TxtClave.LeadingIcon = null;
            this.TxtClave.Location = new System.Drawing.Point(44, 174);
            this.TxtClave.MaxLength = 50;
            this.TxtClave.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtClave.Multiline = false;
            this.TxtClave.Name = "TxtClave";
            this.TxtClave.Password = true;
            this.TxtClave.Size = new System.Drawing.Size(158, 50);
            this.TxtClave.TabIndex = 41;
            this.TxtClave.Text = "";
            this.TxtClave.TrailingIcon = null;
            // 
            // TxtUsuario
            // 
            this.TxtUsuario.AnimateReadOnly = false;
            this.TxtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtUsuario.Depth = 0;
            this.TxtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TxtUsuario.Hint = "Usuario";
            this.TxtUsuario.LeadingIcon = null;
            this.TxtUsuario.Location = new System.Drawing.Point(44, 90);
            this.TxtUsuario.MaxLength = 50;
            this.TxtUsuario.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtUsuario.Multiline = false;
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.Size = new System.Drawing.Size(158, 50);
            this.TxtUsuario.TabIndex = 40;
            this.TxtUsuario.Text = "";
            this.TxtUsuario.TrailingIcon = null;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 343);
            this.Controls.Add(this.materialButton9);
            this.Controls.Add(this.TxtClave);
            this.Controls.Add(this.TxtUsuario);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(2, 52, 2, 2);
            this.Text = "Hotel Las Amapolas";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialButton materialButton9;
        private MaterialSkin.Controls.MaterialTextBox TxtClave;
        private MaterialSkin.Controls.MaterialTextBox TxtUsuario;
    }
}

