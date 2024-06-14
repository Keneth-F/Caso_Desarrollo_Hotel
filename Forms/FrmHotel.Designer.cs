namespace Caso_Desarrollo_Hotel.Forms
{
    partial class FrmHotel
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DtgDatos = new System.Windows.Forms.DataGridView();
            this.BtnReturn = new MaterialSkin.Controls.MaterialButton();
            this.TxtDir = new MaterialSkin.Controls.MaterialTextBox2();
            this.TxtPais = new MaterialSkin.Controls.MaterialTextBox2();
            this.TxtCiudad = new MaterialSkin.Controls.MaterialTextBox2();
            this.TxtNombre = new MaterialSkin.Controls.MaterialTextBox2();
            this.SlEstrellas = new MaterialSkin.Controls.MaterialSlider();
            this.BtnDelete = new MaterialSkin.Controls.MaterialButton();
            this.BtnEdit = new MaterialSkin.Controls.MaterialButton();
            this.BtnAdd = new MaterialSkin.Controls.MaterialButton();
            this.BtnSearch = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.DtgDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // DtgDatos
            // 
            this.DtgDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgDatos.Location = new System.Drawing.Point(249, 70);
            this.DtgDatos.Margin = new System.Windows.Forms.Padding(2);
            this.DtgDatos.Name = "DtgDatos";
            this.DtgDatos.RowHeadersWidth = 51;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkGray;
            this.DtgDatos.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DtgDatos.RowTemplate.Height = 24;
            this.DtgDatos.Size = new System.Drawing.Size(668, 346);
            this.DtgDatos.TabIndex = 21;
            // 
            // BtnReturn
            // 
            this.BtnReturn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnReturn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.BtnReturn.Depth = 0;
            this.BtnReturn.HighEmphasis = true;
            this.BtnReturn.Icon = global::Caso_Desarrollo_Hotel.Properties.Resources.arrow_left;
            this.BtnReturn.Location = new System.Drawing.Point(4, 387);
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
            // TxtDir
            // 
            this.TxtDir.AnimateReadOnly = false;
            this.TxtDir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TxtDir.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.TxtDir.Depth = 0;
            this.TxtDir.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TxtDir.HideSelection = true;
            this.TxtDir.Hint = "Direccion";
            this.TxtDir.LeadingIcon = null;
            this.TxtDir.Location = new System.Drawing.Point(4, 248);
            this.TxtDir.Margin = new System.Windows.Forms.Padding(2);
            this.TxtDir.MaxLength = 32767;
            this.TxtDir.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtDir.Name = "TxtDir";
            this.TxtDir.PasswordChar = '\0';
            this.TxtDir.PrefixSuffixText = null;
            this.TxtDir.ReadOnly = false;
            this.TxtDir.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TxtDir.SelectedText = "";
            this.TxtDir.SelectionLength = 0;
            this.TxtDir.SelectionStart = 0;
            this.TxtDir.ShortcutsEnabled = true;
            this.TxtDir.Size = new System.Drawing.Size(188, 48);
            this.TxtDir.TabIndex = 15;
            this.TxtDir.TabStop = false;
            this.TxtDir.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtDir.TrailingIcon = null;
            this.TxtDir.UseSystemPasswordChar = false;
            // 
            // TxtPais
            // 
            this.TxtPais.AnimateReadOnly = false;
            this.TxtPais.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TxtPais.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.TxtPais.Depth = 0;
            this.TxtPais.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TxtPais.HideSelection = true;
            this.TxtPais.Hint = "Pais";
            this.TxtPais.LeadingIcon = null;
            this.TxtPais.Location = new System.Drawing.Point(4, 161);
            this.TxtPais.Margin = new System.Windows.Forms.Padding(2);
            this.TxtPais.MaxLength = 32767;
            this.TxtPais.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtPais.Name = "TxtPais";
            this.TxtPais.PasswordChar = '\0';
            this.TxtPais.PrefixSuffixText = null;
            this.TxtPais.ReadOnly = false;
            this.TxtPais.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TxtPais.SelectedText = "";
            this.TxtPais.SelectionLength = 0;
            this.TxtPais.SelectionStart = 0;
            this.TxtPais.ShortcutsEnabled = true;
            this.TxtPais.Size = new System.Drawing.Size(188, 48);
            this.TxtPais.TabIndex = 13;
            this.TxtPais.TabStop = false;
            this.TxtPais.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtPais.TrailingIcon = null;
            this.TxtPais.UseSystemPasswordChar = false;
            // 
            // TxtCiudad
            // 
            this.TxtCiudad.AnimateReadOnly = false;
            this.TxtCiudad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TxtCiudad.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.TxtCiudad.Depth = 0;
            this.TxtCiudad.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TxtCiudad.HideSelection = true;
            this.TxtCiudad.Hint = "Ciudad";
            this.TxtCiudad.LeadingIcon = null;
            this.TxtCiudad.Location = new System.Drawing.Point(4, 117);
            this.TxtCiudad.Margin = new System.Windows.Forms.Padding(2);
            this.TxtCiudad.MaxLength = 32767;
            this.TxtCiudad.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtCiudad.Name = "TxtCiudad";
            this.TxtCiudad.PasswordChar = '\0';
            this.TxtCiudad.PrefixSuffixText = null;
            this.TxtCiudad.ReadOnly = false;
            this.TxtCiudad.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TxtCiudad.SelectedText = "";
            this.TxtCiudad.SelectionLength = 0;
            this.TxtCiudad.SelectionStart = 0;
            this.TxtCiudad.ShortcutsEnabled = true;
            this.TxtCiudad.Size = new System.Drawing.Size(188, 48);
            this.TxtCiudad.TabIndex = 12;
            this.TxtCiudad.TabStop = false;
            this.TxtCiudad.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtCiudad.TrailingIcon = null;
            this.TxtCiudad.UseSystemPasswordChar = false;
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
            this.TxtNombre.Location = new System.Drawing.Point(4, 73);
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
            // SlEstrellas
            // 
            this.SlEstrellas.Depth = 0;
            this.SlEstrellas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.SlEstrellas.Location = new System.Drawing.Point(4, 204);
            this.SlEstrellas.Margin = new System.Windows.Forms.Padding(2);
            this.SlEstrellas.MouseState = MaterialSkin.MouseState.HOVER;
            this.SlEstrellas.Name = "SlEstrellas";
            this.SlEstrellas.RangeMax = 5;
            this.SlEstrellas.Size = new System.Drawing.Size(188, 40);
            this.SlEstrellas.TabIndex = 22;
            this.SlEstrellas.Text = "Estrellas";
            this.SlEstrellas.Value = 5;
            this.SlEstrellas.ValueMax = 5;
            // 
            // BtnDelete
            // 
            this.BtnDelete.AutoSize = false;
            this.BtnDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnDelete.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.BtnDelete.Depth = 0;
            this.BtnDelete.HighEmphasis = true;
            this.BtnDelete.Icon = global::Caso_Desarrollo_Hotel.Properties.Resources.trash;
            this.BtnDelete.Location = new System.Drawing.Point(196, 153);
            this.BtnDelete.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.BtnDelete.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.NoAccentTextColor = System.Drawing.Color.Empty;
            this.BtnDelete.Size = new System.Drawing.Size(43, 37);
            this.BtnDelete.TabIndex = 26;
            this.BtnDelete.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.BtnDelete.UseAccentColor = false;
            this.BtnDelete.UseVisualStyleBackColor = true;
            // 
            // BtnEdit
            // 
            this.BtnEdit.AutoSize = false;
            this.BtnEdit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnEdit.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.BtnEdit.Depth = 0;
            this.BtnEdit.HighEmphasis = true;
            this.BtnEdit.Icon = global::Caso_Desarrollo_Hotel.Properties.Resources.edit;
            this.BtnEdit.Location = new System.Drawing.Point(196, 114);
            this.BtnEdit.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.BtnEdit.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.NoAccentTextColor = System.Drawing.Color.Empty;
            this.BtnEdit.Size = new System.Drawing.Size(43, 37);
            this.BtnEdit.TabIndex = 25;
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
            this.BtnAdd.Location = new System.Drawing.Point(196, 73);
            this.BtnAdd.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.BtnAdd.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.NoAccentTextColor = System.Drawing.Color.Empty;
            this.BtnAdd.Size = new System.Drawing.Size(43, 37);
            this.BtnAdd.TabIndex = 24;
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
            this.BtnSearch.Location = new System.Drawing.Point(196, 192);
            this.BtnSearch.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.BtnSearch.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.NoAccentTextColor = System.Drawing.Color.Empty;
            this.BtnSearch.Size = new System.Drawing.Size(43, 37);
            this.BtnSearch.TabIndex = 23;
            this.BtnSearch.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.BtnSearch.UseAccentColor = false;
            this.BtnSearch.UseVisualStyleBackColor = true;
            // 
            // FrmHotel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 440);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.SlEstrellas);
            this.Controls.Add(this.DtgDatos);
            this.Controls.Add(this.BtnReturn);
            this.Controls.Add(this.TxtDir);
            this.Controls.Add(this.TxtPais);
            this.Controls.Add(this.TxtCiudad);
            this.Controls.Add(this.TxtNombre);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmHotel";
            this.Padding = new System.Windows.Forms.Padding(2, 52, 2, 2);
            this.Text = "FrmHotel";
            this.Load += new System.EventHandler(this.FrmHotel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DtgDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DtgDatos;
        private MaterialSkin.Controls.MaterialButton BtnReturn;
        private MaterialSkin.Controls.MaterialTextBox2 TxtDir;
        private MaterialSkin.Controls.MaterialTextBox2 TxtPais;
        private MaterialSkin.Controls.MaterialTextBox2 TxtCiudad;
        private MaterialSkin.Controls.MaterialTextBox2 TxtNombre;
        private MaterialSkin.Controls.MaterialSlider SlEstrellas;
        private MaterialSkin.Controls.MaterialButton BtnDelete;
        private MaterialSkin.Controls.MaterialButton BtnEdit;
        private MaterialSkin.Controls.MaterialButton BtnAdd;
        private MaterialSkin.Controls.MaterialButton BtnSearch;
    }
}