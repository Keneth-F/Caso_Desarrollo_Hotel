namespace Caso_Desarrollo_Hotel.Forms
{
    partial class FrmPagos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DtgDatos = new System.Windows.Forms.DataGridView();
            this.BtnReturn = new MaterialSkin.Controls.MaterialButton();
            this.TxtMonto = new MaterialSkin.Controls.MaterialTextBox2();
            this.TxtReserva = new MaterialSkin.Controls.MaterialTextBox2();
            this.Rbtn1 = new MaterialSkin.Controls.MaterialRadioButton();
            this.Rbtn2 = new MaterialSkin.Controls.MaterialRadioButton();
            this.Rbtn3 = new MaterialSkin.Controls.MaterialRadioButton();
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
            this.DtgDatos.Location = new System.Drawing.Point(260, 70);
            this.DtgDatos.Margin = new System.Windows.Forms.Padding(2);
            this.DtgDatos.Name = "DtgDatos";
            this.DtgDatos.RowHeadersWidth = 51;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkGray;
            this.DtgDatos.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.DtgDatos.RowTemplate.Height = 24;
            this.DtgDatos.Size = new System.Drawing.Size(552, 346);
            this.DtgDatos.TabIndex = 21;
            // 
            // BtnReturn
            // 
            this.BtnReturn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnReturn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.BtnReturn.Depth = 0;
            this.BtnReturn.HighEmphasis = true;
            this.BtnReturn.Icon = global::Caso_Desarrollo_Hotel.Properties.Resources.arrow_left;
            this.BtnReturn.Location = new System.Drawing.Point(17, 384);
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
            // TxtMonto
            // 
            this.TxtMonto.AnimateReadOnly = false;
            this.TxtMonto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TxtMonto.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.TxtMonto.Depth = 0;
            this.TxtMonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TxtMonto.HideSelection = true;
            this.TxtMonto.Hint = "Monto";
            this.TxtMonto.LeadingIcon = null;
            this.TxtMonto.Location = new System.Drawing.Point(16, 114);
            this.TxtMonto.Margin = new System.Windows.Forms.Padding(2);
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
            this.TxtMonto.Size = new System.Drawing.Size(188, 48);
            this.TxtMonto.TabIndex = 12;
            this.TxtMonto.TabStop = false;
            this.TxtMonto.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtMonto.TrailingIcon = null;
            this.TxtMonto.UseSystemPasswordChar = false;
            // 
            // TxtReserva
            // 
            this.TxtReserva.AnimateReadOnly = false;
            this.TxtReserva.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TxtReserva.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.TxtReserva.Depth = 0;
            this.TxtReserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TxtReserva.HideSelection = true;
            this.TxtReserva.Hint = "Reserva Id";
            this.TxtReserva.LeadingIcon = null;
            this.TxtReserva.Location = new System.Drawing.Point(16, 70);
            this.TxtReserva.Margin = new System.Windows.Forms.Padding(2);
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
            this.TxtReserva.Size = new System.Drawing.Size(188, 48);
            this.TxtReserva.TabIndex = 11;
            this.TxtReserva.TabStop = false;
            this.TxtReserva.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtReserva.TrailingIcon = null;
            this.TxtReserva.UseSystemPasswordChar = false;
            // 
            // Rbtn1
            // 
            this.Rbtn1.AutoSize = true;
            this.Rbtn1.Checked = true;
            this.Rbtn1.Depth = 0;
            this.Rbtn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rbtn1.Location = new System.Drawing.Point(-5, 164);
            this.Rbtn1.Margin = new System.Windows.Forms.Padding(0);
            this.Rbtn1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.Rbtn1.MouseState = MaterialSkin.MouseState.HOVER;
            this.Rbtn1.Name = "Rbtn1";
            this.Rbtn1.Ripple = true;
            this.Rbtn1.Size = new System.Drawing.Size(214, 37);
            this.Rbtn1.TabIndex = 22;
            this.Rbtn1.TabStop = true;
            this.Rbtn1.Text = "tarjeta de crédito o débito";
            this.Rbtn1.UseVisualStyleBackColor = true;
            // 
            // Rbtn2
            // 
            this.Rbtn2.AutoSize = true;
            this.Rbtn2.Depth = 0;
            this.Rbtn2.Location = new System.Drawing.Point(-5, 192);
            this.Rbtn2.Margin = new System.Windows.Forms.Padding(0);
            this.Rbtn2.MouseLocation = new System.Drawing.Point(-1, -1);
            this.Rbtn2.MouseState = MaterialSkin.MouseState.HOVER;
            this.Rbtn2.Name = "Rbtn2";
            this.Rbtn2.Ripple = true;
            this.Rbtn2.Size = new System.Drawing.Size(215, 37);
            this.Rbtn2.TabIndex = 23;
            this.Rbtn2.TabStop = true;
            this.Rbtn2.Text = "Transferencias bancarias";
            this.Rbtn2.UseVisualStyleBackColor = true;
            // 
            // Rbtn3
            // 
            this.Rbtn3.AutoSize = true;
            this.Rbtn3.Depth = 0;
            this.Rbtn3.Location = new System.Drawing.Point(-5, 222);
            this.Rbtn3.Margin = new System.Windows.Forms.Padding(0);
            this.Rbtn3.MouseLocation = new System.Drawing.Point(-1, -1);
            this.Rbtn3.MouseState = MaterialSkin.MouseState.HOVER;
            this.Rbtn3.Name = "Rbtn3";
            this.Rbtn3.Ripple = true;
            this.Rbtn3.Size = new System.Drawing.Size(220, 37);
            this.Rbtn3.TabIndex = 24;
            this.Rbtn3.TabStop = true;
            this.Rbtn3.Text = "Pagos con criptomonedas";
            this.Rbtn3.UseVisualStyleBackColor = true;
            // 
            // BtnDelete
            // 
            this.BtnDelete.AutoSize = false;
            this.BtnDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnDelete.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.BtnDelete.Depth = 0;
            this.BtnDelete.HighEmphasis = true;
            this.BtnDelete.Icon = global::Caso_Desarrollo_Hotel.Properties.Resources.trash;
            this.BtnDelete.Location = new System.Drawing.Point(212, 150);
            this.BtnDelete.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.BtnDelete.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.NoAccentTextColor = System.Drawing.Color.Empty;
            this.BtnDelete.Size = new System.Drawing.Size(43, 37);
            this.BtnDelete.TabIndex = 28;
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
            this.BtnEdit.Location = new System.Drawing.Point(212, 111);
            this.BtnEdit.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.BtnEdit.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.NoAccentTextColor = System.Drawing.Color.Empty;
            this.BtnEdit.Size = new System.Drawing.Size(43, 37);
            this.BtnEdit.TabIndex = 27;
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
            this.BtnAdd.Location = new System.Drawing.Point(212, 70);
            this.BtnAdd.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.BtnAdd.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.NoAccentTextColor = System.Drawing.Color.Empty;
            this.BtnAdd.Size = new System.Drawing.Size(43, 37);
            this.BtnAdd.TabIndex = 26;
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
            this.BtnSearch.Location = new System.Drawing.Point(212, 189);
            this.BtnSearch.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.BtnSearch.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.NoAccentTextColor = System.Drawing.Color.Empty;
            this.BtnSearch.Size = new System.Drawing.Size(43, 37);
            this.BtnSearch.TabIndex = 25;
            this.BtnSearch.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.BtnSearch.UseAccentColor = false;
            this.BtnSearch.UseVisualStyleBackColor = true;
            // 
            // FrmPagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 427);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.Rbtn3);
            this.Controls.Add(this.Rbtn2);
            this.Controls.Add(this.Rbtn1);
            this.Controls.Add(this.DtgDatos);
            this.Controls.Add(this.BtnReturn);
            this.Controls.Add(this.TxtMonto);
            this.Controls.Add(this.TxtReserva);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmPagos";
            this.Padding = new System.Windows.Forms.Padding(2, 52, 2, 2);
            this.Text = "FrmPagos";
            this.Load += new System.EventHandler(this.FrmPagos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DtgDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DtgDatos;
        private MaterialSkin.Controls.MaterialButton BtnReturn;
        private MaterialSkin.Controls.MaterialTextBox2 TxtMonto;
        private MaterialSkin.Controls.MaterialTextBox2 TxtReserva;
        private MaterialSkin.Controls.MaterialRadioButton Rbtn1;
        private MaterialSkin.Controls.MaterialRadioButton Rbtn2;
        private MaterialSkin.Controls.MaterialRadioButton Rbtn3;
        private MaterialSkin.Controls.MaterialButton BtnDelete;
        private MaterialSkin.Controls.MaterialButton BtnEdit;
        private MaterialSkin.Controls.MaterialButton BtnAdd;
        private MaterialSkin.Controls.MaterialButton BtnSearch;
    }
}