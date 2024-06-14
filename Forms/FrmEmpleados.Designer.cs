namespace Caso_Desarrollo_Hotel.Forms
{
    partial class FrmEmpleados
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DtgDatos = new System.Windows.Forms.DataGridView();
            this.BtnReturn = new MaterialSkin.Controls.MaterialButton();
            this.BtnDelete = new MaterialSkin.Controls.MaterialButton();
            this.BtnEdit = new MaterialSkin.Controls.MaterialButton();
            this.BtnAdd = new MaterialSkin.Controls.MaterialButton();
            this.BtnSearch = new MaterialSkin.Controls.MaterialButton();
            this.TxtTel = new MaterialSkin.Controls.MaterialTextBox2();
            this.TxtEmail = new MaterialSkin.Controls.MaterialTextBox2();
            this.TxtPos = new MaterialSkin.Controls.MaterialTextBox2();
            this.TxtApellidos = new MaterialSkin.Controls.MaterialTextBox2();
            this.TxtNombre = new MaterialSkin.Controls.MaterialTextBox2();
            ((System.ComponentModel.ISupportInitialize)(this.DtgDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // DtgDatos
            // 
            this.DtgDatos.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.DtgDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgDatos.Location = new System.Drawing.Point(246, 83);
            this.DtgDatos.Margin = new System.Windows.Forms.Padding(2);
            this.DtgDatos.Name = "DtgDatos";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DtgDatos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DtgDatos.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.DarkGray;
            this.DtgDatos.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DtgDatos.RowTemplate.Height = 24;
            this.DtgDatos.Size = new System.Drawing.Size(662, 346);
            this.DtgDatos.TabIndex = 21;
            // 
            // BtnReturn
            // 
            this.BtnReturn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnReturn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.BtnReturn.Depth = 0;
            this.BtnReturn.HighEmphasis = true;
            this.BtnReturn.Icon = global::Caso_Desarrollo_Hotel.Properties.Resources.arrow_left;
            this.BtnReturn.Location = new System.Drawing.Point(6, 397);
            this.BtnReturn.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
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
            // BtnDelete
            // 
            this.BtnDelete.AutoSize = false;
            this.BtnDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnDelete.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.BtnDelete.Depth = 0;
            this.BtnDelete.HighEmphasis = true;
            this.BtnDelete.Icon = global::Caso_Desarrollo_Hotel.Properties.Resources.trash;
            this.BtnDelete.Location = new System.Drawing.Point(198, 166);
            this.BtnDelete.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.BtnDelete.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.NoAccentTextColor = System.Drawing.Color.Empty;
            this.BtnDelete.Size = new System.Drawing.Size(43, 37);
            this.BtnDelete.TabIndex = 19;
            this.BtnDelete.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.BtnDelete.UseAccentColor = false;
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnEdit
            // 
            this.BtnEdit.AutoSize = false;
            this.BtnEdit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnEdit.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.BtnEdit.Depth = 0;
            this.BtnEdit.HighEmphasis = true;
            this.BtnEdit.Icon = global::Caso_Desarrollo_Hotel.Properties.Resources.edit;
            this.BtnEdit.Location = new System.Drawing.Point(198, 127);
            this.BtnEdit.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.BtnEdit.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.NoAccentTextColor = System.Drawing.Color.Empty;
            this.BtnEdit.Size = new System.Drawing.Size(43, 37);
            this.BtnEdit.TabIndex = 18;
            this.BtnEdit.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.BtnEdit.UseAccentColor = false;
            this.BtnEdit.UseVisualStyleBackColor = true;
            // 
            // BtnAdd
            // 
            this.BtnAdd.AutoSize = false;
            this.BtnAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnAdd.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.BtnAdd.Depth = 0;
            this.BtnAdd.HighEmphasis = true;
            this.BtnAdd.Icon = global::Caso_Desarrollo_Hotel.Properties.Resources.check;
            this.BtnAdd.Location = new System.Drawing.Point(198, 85);
            this.BtnAdd.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.BtnAdd.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.NoAccentTextColor = System.Drawing.Color.Empty;
            this.BtnAdd.Size = new System.Drawing.Size(43, 37);
            this.BtnAdd.TabIndex = 17;
            this.BtnAdd.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.BtnAdd.UseAccentColor = false;
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnSearch
            // 
            this.BtnSearch.AutoSize = false;
            this.BtnSearch.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnSearch.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.BtnSearch.Depth = 0;
            this.BtnSearch.HighEmphasis = true;
            this.BtnSearch.Icon = global::Caso_Desarrollo_Hotel.Properties.Resources.search;
            this.BtnSearch.Location = new System.Drawing.Point(198, 205);
            this.BtnSearch.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.BtnSearch.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.NoAccentTextColor = System.Drawing.Color.Empty;
            this.BtnSearch.Size = new System.Drawing.Size(43, 37);
            this.BtnSearch.TabIndex = 16;
            this.BtnSearch.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.BtnSearch.UseAccentColor = false;
            this.BtnSearch.UseVisualStyleBackColor = true;
            // 
            // TxtTel
            // 
            this.TxtTel.AnimateReadOnly = false;
            this.TxtTel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TxtTel.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.TxtTel.Depth = 0;
            this.TxtTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TxtTel.HideSelection = true;
            this.TxtTel.Hint = "Telefono";
            this.TxtTel.LeadingIcon = null;
            this.TxtTel.Location = new System.Drawing.Point(5, 258);
            this.TxtTel.Margin = new System.Windows.Forms.Padding(2);
            this.TxtTel.MaxLength = 32767;
            this.TxtTel.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtTel.Name = "TxtTel";
            this.TxtTel.PasswordChar = '\0';
            this.TxtTel.PrefixSuffixText = null;
            this.TxtTel.ReadOnly = false;
            this.TxtTel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TxtTel.SelectedText = "";
            this.TxtTel.SelectionLength = 0;
            this.TxtTel.SelectionStart = 0;
            this.TxtTel.ShortcutsEnabled = true;
            this.TxtTel.Size = new System.Drawing.Size(188, 48);
            this.TxtTel.TabIndex = 15;
            this.TxtTel.TabStop = false;
            this.TxtTel.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtTel.TrailingIcon = null;
            this.TxtTel.UseSystemPasswordChar = false;
            // 
            // TxtEmail
            // 
            this.TxtEmail.AnimateReadOnly = false;
            this.TxtEmail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TxtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.TxtEmail.Depth = 0;
            this.TxtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TxtEmail.HideSelection = true;
            this.TxtEmail.Hint = "Email";
            this.TxtEmail.LeadingIcon = null;
            this.TxtEmail.Location = new System.Drawing.Point(5, 214);
            this.TxtEmail.Margin = new System.Windows.Forms.Padding(2);
            this.TxtEmail.MaxLength = 32767;
            this.TxtEmail.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.PasswordChar = '\0';
            this.TxtEmail.PrefixSuffixText = null;
            this.TxtEmail.ReadOnly = false;
            this.TxtEmail.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TxtEmail.SelectedText = "";
            this.TxtEmail.SelectionLength = 0;
            this.TxtEmail.SelectionStart = 0;
            this.TxtEmail.ShortcutsEnabled = true;
            this.TxtEmail.Size = new System.Drawing.Size(188, 48);
            this.TxtEmail.TabIndex = 14;
            this.TxtEmail.TabStop = false;
            this.TxtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtEmail.TrailingIcon = null;
            this.TxtEmail.UseSystemPasswordChar = false;
            // 
            // TxtPos
            // 
            this.TxtPos.AnimateReadOnly = false;
            this.TxtPos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TxtPos.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.TxtPos.Depth = 0;
            this.TxtPos.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TxtPos.HideSelection = true;
            this.TxtPos.Hint = "Posicion";
            this.TxtPos.LeadingIcon = null;
            this.TxtPos.Location = new System.Drawing.Point(5, 171);
            this.TxtPos.Margin = new System.Windows.Forms.Padding(2);
            this.TxtPos.MaxLength = 32767;
            this.TxtPos.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtPos.Name = "TxtPos";
            this.TxtPos.PasswordChar = '\0';
            this.TxtPos.PrefixSuffixText = null;
            this.TxtPos.ReadOnly = false;
            this.TxtPos.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TxtPos.SelectedText = "";
            this.TxtPos.SelectionLength = 0;
            this.TxtPos.SelectionStart = 0;
            this.TxtPos.ShortcutsEnabled = true;
            this.TxtPos.Size = new System.Drawing.Size(188, 48);
            this.TxtPos.TabIndex = 13;
            this.TxtPos.TabStop = false;
            this.TxtPos.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtPos.TrailingIcon = null;
            this.TxtPos.UseSystemPasswordChar = false;
            // 
            // TxtApellidos
            // 
            this.TxtApellidos.AnimateReadOnly = false;
            this.TxtApellidos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TxtApellidos.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.TxtApellidos.Depth = 0;
            this.TxtApellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TxtApellidos.HideSelection = true;
            this.TxtApellidos.Hint = "Apellidos";
            this.TxtApellidos.LeadingIcon = null;
            this.TxtApellidos.Location = new System.Drawing.Point(5, 127);
            this.TxtApellidos.Margin = new System.Windows.Forms.Padding(2);
            this.TxtApellidos.MaxLength = 32767;
            this.TxtApellidos.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtApellidos.Name = "TxtApellidos";
            this.TxtApellidos.PasswordChar = '\0';
            this.TxtApellidos.PrefixSuffixText = null;
            this.TxtApellidos.ReadOnly = false;
            this.TxtApellidos.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TxtApellidos.SelectedText = "";
            this.TxtApellidos.SelectionLength = 0;
            this.TxtApellidos.SelectionStart = 0;
            this.TxtApellidos.ShortcutsEnabled = true;
            this.TxtApellidos.Size = new System.Drawing.Size(188, 48);
            this.TxtApellidos.TabIndex = 12;
            this.TxtApellidos.TabStop = false;
            this.TxtApellidos.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtApellidos.TrailingIcon = null;
            this.TxtApellidos.UseSystemPasswordChar = false;
            // 
            // TxtNombre
            // 
            this.TxtNombre.AnimateReadOnly = false;
            this.TxtNombre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TxtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.TxtNombre.Depth = 0;
            this.TxtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TxtNombre.HideSelection = true;
            this.TxtNombre.Hint = "Nombre";
            this.TxtNombre.LeadingIcon = null;
            this.TxtNombre.Location = new System.Drawing.Point(5, 83);
            this.TxtNombre.Margin = new System.Windows.Forms.Padding(2);
            this.TxtNombre.MaxLength = 32767;
            this.TxtNombre.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.PasswordChar = '\0';
            this.TxtNombre.PrefixSuffixText = null;
            this.TxtNombre.ReadOnly = false;
            this.TxtNombre.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TxtNombre.SelectedText = "";
            this.TxtNombre.SelectionLength = 0;
            this.TxtNombre.SelectionStart = 0;
            this.TxtNombre.ShortcutsEnabled = true;
            this.TxtNombre.Size = new System.Drawing.Size(188, 48);
            this.TxtNombre.TabIndex = 11;
            this.TxtNombre.TabStop = false;
            this.TxtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtNombre.TrailingIcon = null;
            this.TxtNombre.UseSystemPasswordChar = false;
            // 
            // FrmEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 451);
            this.Controls.Add(this.DtgDatos);
            this.Controls.Add(this.BtnReturn);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.TxtTel);
            this.Controls.Add(this.TxtEmail);
            this.Controls.Add(this.TxtPos);
            this.Controls.Add(this.TxtApellidos);
            this.Controls.Add(this.TxtNombre);
            this.Name = "FrmEmpleados";
            this.Text = "FrmEmpleados";
            this.Load += new System.EventHandler(this.FrmEmpleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DtgDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DtgDatos;
        private MaterialSkin.Controls.MaterialButton BtnReturn;
        private MaterialSkin.Controls.MaterialButton BtnDelete;
        private MaterialSkin.Controls.MaterialButton BtnEdit;
        private MaterialSkin.Controls.MaterialButton BtnAdd;
        private MaterialSkin.Controls.MaterialButton BtnSearch;
        private MaterialSkin.Controls.MaterialTextBox2 TxtTel;
        private MaterialSkin.Controls.MaterialTextBox2 TxtEmail;
        private MaterialSkin.Controls.MaterialTextBox2 TxtPos;
        private MaterialSkin.Controls.MaterialTextBox2 TxtApellidos;
        private MaterialSkin.Controls.MaterialTextBox2 TxtNombre;
    }
}