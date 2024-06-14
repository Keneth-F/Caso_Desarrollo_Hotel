namespace Caso_Desarrollo_Hotel.Forms
{
    partial class FrmHabitaciones
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
            this.TxtPrecio = new MaterialSkin.Controls.MaterialTextBox2();
            this.TxtCapacidad = new MaterialSkin.Controls.MaterialTextBox2();
            this.TxtNumero = new MaterialSkin.Controls.MaterialTextBox2();
            this.CbTipo = new MaterialSkin.Controls.MaterialComboBox();
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
            this.DtgDatos.Location = new System.Drawing.Point(254, 70);
            this.DtgDatos.Margin = new System.Windows.Forms.Padding(2);
            this.DtgDatos.Name = "DtgDatos";
            this.DtgDatos.RowHeadersWidth = 51;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkGray;
            this.DtgDatos.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DtgDatos.RowTemplate.Height = 24;
            this.DtgDatos.Size = new System.Drawing.Size(658, 346);
            this.DtgDatos.TabIndex = 31;
            // 
            // BtnReturn
            // 
            this.BtnReturn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnReturn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.BtnReturn.Depth = 0;
            this.BtnReturn.HighEmphasis = true;
            this.BtnReturn.Icon = global::Caso_Desarrollo_Hotel.Properties.Resources.arrow_left;
            this.BtnReturn.Location = new System.Drawing.Point(10, 387);
            this.BtnReturn.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.BtnReturn.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnReturn.Name = "BtnReturn";
            this.BtnReturn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.BtnReturn.Size = new System.Drawing.Size(122, 36);
            this.BtnReturn.TabIndex = 30;
            this.BtnReturn.Text = "Regresar";
            this.BtnReturn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.BtnReturn.UseAccentColor = false;
            this.BtnReturn.UseVisualStyleBackColor = true;
            this.BtnReturn.Click += new System.EventHandler(this.BtnReturn_Click);
            // 
            // TxtPrecio
            // 
            this.TxtPrecio.AnimateReadOnly = false;
            this.TxtPrecio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TxtPrecio.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.TxtPrecio.Depth = 0;
            this.TxtPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TxtPrecio.HideSelection = true;
            this.TxtPrecio.Hint = "Precio Noche";
            this.TxtPrecio.LeadingIcon = null;
            this.TxtPrecio.Location = new System.Drawing.Point(8, 160);
            this.TxtPrecio.Margin = new System.Windows.Forms.Padding(2);
            this.TxtPrecio.MaxLength = 32767;
            this.TxtPrecio.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtPrecio.Name = "TxtPrecio";
            this.TxtPrecio.PasswordChar = '\0';
            this.TxtPrecio.PrefixSuffixText = null;
            this.TxtPrecio.ReadOnly = false;
            this.TxtPrecio.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TxtPrecio.SelectedText = "";
            this.TxtPrecio.SelectionLength = 0;
            this.TxtPrecio.SelectionStart = 0;
            this.TxtPrecio.ShortcutsEnabled = true;
            this.TxtPrecio.Size = new System.Drawing.Size(188, 48);
            this.TxtPrecio.TabIndex = 25;
            this.TxtPrecio.TabStop = false;
            this.TxtPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtPrecio.TrailingIcon = null;
            this.TxtPrecio.UseSystemPasswordChar = false;
            // 
            // TxtCapacidad
            // 
            this.TxtCapacidad.AnimateReadOnly = false;
            this.TxtCapacidad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TxtCapacidad.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.TxtCapacidad.Depth = 0;
            this.TxtCapacidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TxtCapacidad.HideSelection = true;
            this.TxtCapacidad.Hint = "Capacidad";
            this.TxtCapacidad.LeadingIcon = null;
            this.TxtCapacidad.Location = new System.Drawing.Point(8, 116);
            this.TxtCapacidad.Margin = new System.Windows.Forms.Padding(2);
            this.TxtCapacidad.MaxLength = 32767;
            this.TxtCapacidad.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtCapacidad.Name = "TxtCapacidad";
            this.TxtCapacidad.PasswordChar = '\0';
            this.TxtCapacidad.PrefixSuffixText = null;
            this.TxtCapacidad.ReadOnly = false;
            this.TxtCapacidad.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TxtCapacidad.SelectedText = "";
            this.TxtCapacidad.SelectionLength = 0;
            this.TxtCapacidad.SelectionStart = 0;
            this.TxtCapacidad.ShortcutsEnabled = true;
            this.TxtCapacidad.Size = new System.Drawing.Size(188, 48);
            this.TxtCapacidad.TabIndex = 24;
            this.TxtCapacidad.TabStop = false;
            this.TxtCapacidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtCapacidad.TrailingIcon = null;
            this.TxtCapacidad.UseSystemPasswordChar = false;
            // 
            // TxtNumero
            // 
            this.TxtNumero.AnimateReadOnly = false;
            this.TxtNumero.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TxtNumero.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.TxtNumero.Depth = 0;
            this.TxtNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TxtNumero.HideSelection = true;
            this.TxtNumero.Hint = "Numero Habitacion";
            this.TxtNumero.LeadingIcon = null;
            this.TxtNumero.Location = new System.Drawing.Point(9, 72);
            this.TxtNumero.Margin = new System.Windows.Forms.Padding(2);
            this.TxtNumero.MaxLength = 32767;
            this.TxtNumero.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtNumero.Name = "TxtNumero";
            this.TxtNumero.PasswordChar = '\0';
            this.TxtNumero.PrefixSuffixText = null;
            this.TxtNumero.ReadOnly = false;
            this.TxtNumero.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TxtNumero.SelectedText = "";
            this.TxtNumero.SelectionLength = 0;
            this.TxtNumero.SelectionStart = 0;
            this.TxtNumero.ShortcutsEnabled = true;
            this.TxtNumero.Size = new System.Drawing.Size(188, 48);
            this.TxtNumero.TabIndex = 22;
            this.TxtNumero.TabStop = false;
            this.TxtNumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtNumero.TrailingIcon = null;
            this.TxtNumero.UseSystemPasswordChar = false;
            // 
            // CbTipo
            // 
            this.CbTipo.AutoResize = false;
            this.CbTipo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CbTipo.Depth = 0;
            this.CbTipo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.CbTipo.DropDownHeight = 174;
            this.CbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbTipo.DropDownWidth = 121;
            this.CbTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.CbTipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CbTipo.FormattingEnabled = true;
            this.CbTipo.IntegralHeight = false;
            this.CbTipo.ItemHeight = 43;
            this.CbTipo.Items.AddRange(new object[] {
            "individual",
            "terraza",
            "familiares",
            "suites"});
            this.CbTipo.Location = new System.Drawing.Point(8, 204);
            this.CbTipo.Margin = new System.Windows.Forms.Padding(2);
            this.CbTipo.MaxDropDownItems = 4;
            this.CbTipo.MouseState = MaterialSkin.MouseState.OUT;
            this.CbTipo.Name = "CbTipo";
            this.CbTipo.Size = new System.Drawing.Size(187, 49);
            this.CbTipo.StartIndex = 0;
            this.CbTipo.TabIndex = 32;
            // 
            // BtnDelete
            // 
            this.BtnDelete.AutoSize = false;
            this.BtnDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnDelete.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.BtnDelete.Depth = 0;
            this.BtnDelete.HighEmphasis = true;
            this.BtnDelete.Icon = global::Caso_Desarrollo_Hotel.Properties.Resources.trash;
            this.BtnDelete.Location = new System.Drawing.Point(206, 153);
            this.BtnDelete.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.BtnDelete.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.NoAccentTextColor = System.Drawing.Color.Empty;
            this.BtnDelete.Size = new System.Drawing.Size(43, 37);
            this.BtnDelete.TabIndex = 36;
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
            this.BtnEdit.Location = new System.Drawing.Point(206, 114);
            this.BtnEdit.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.BtnEdit.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.NoAccentTextColor = System.Drawing.Color.Empty;
            this.BtnEdit.Size = new System.Drawing.Size(43, 37);
            this.BtnEdit.TabIndex = 35;
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
            this.BtnAdd.Location = new System.Drawing.Point(206, 72);
            this.BtnAdd.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.BtnAdd.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.NoAccentTextColor = System.Drawing.Color.Empty;
            this.BtnAdd.Size = new System.Drawing.Size(43, 37);
            this.BtnAdd.TabIndex = 34;
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
            this.BtnSearch.Location = new System.Drawing.Point(206, 192);
            this.BtnSearch.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.BtnSearch.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.NoAccentTextColor = System.Drawing.Color.Empty;
            this.BtnSearch.Size = new System.Drawing.Size(43, 37);
            this.BtnSearch.TabIndex = 33;
            this.BtnSearch.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.BtnSearch.UseAccentColor = false;
            this.BtnSearch.UseVisualStyleBackColor = true;
            // 
            // FrmHabitaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 430);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.CbTipo);
            this.Controls.Add(this.DtgDatos);
            this.Controls.Add(this.BtnReturn);
            this.Controls.Add(this.TxtPrecio);
            this.Controls.Add(this.TxtCapacidad);
            this.Controls.Add(this.TxtNumero);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmHabitaciones";
            this.Padding = new System.Windows.Forms.Padding(2, 52, 2, 2);
            this.Text = "FrmHabitaciones";
            this.Load += new System.EventHandler(this.FrmHabitaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DtgDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DtgDatos;
        private MaterialSkin.Controls.MaterialButton BtnReturn;
        private MaterialSkin.Controls.MaterialTextBox2 TxtPrecio;
        private MaterialSkin.Controls.MaterialTextBox2 TxtCapacidad;
        private MaterialSkin.Controls.MaterialTextBox2 TxtNumero;
        private MaterialSkin.Controls.MaterialComboBox CbTipo;
        private MaterialSkin.Controls.MaterialButton BtnDelete;
        private MaterialSkin.Controls.MaterialButton BtnEdit;
        private MaterialSkin.Controls.MaterialButton BtnAdd;
        private MaterialSkin.Controls.MaterialButton BtnSearch;
    }
}