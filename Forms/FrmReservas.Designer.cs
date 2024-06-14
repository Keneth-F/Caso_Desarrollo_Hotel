namespace Caso_Desarrollo_Hotel.Forms
{
    partial class FrmReservas
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
            this.TxtHabitacion = new MaterialSkin.Controls.MaterialTextBox2();
            this.TxtCliente = new MaterialSkin.Controls.MaterialTextBox2();
            this.DtpInicio = new System.Windows.Forms.DateTimePicker();
            this.DtpFinal = new System.Windows.Forms.DateTimePicker();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.BtnDelete = new MaterialSkin.Controls.MaterialButton();
            this.BtnEdit = new MaterialSkin.Controls.MaterialButton();
            this.BtnAdd = new MaterialSkin.Controls.MaterialButton();
            this.BtnSearch = new MaterialSkin.Controls.MaterialButton();
            this.ChbReserved = new MaterialSkin.Controls.MaterialCheckbox();
            ((System.ComponentModel.ISupportInitialize)(this.DtgDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // DtgDatos
            // 
            this.DtgDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgDatos.Location = new System.Drawing.Point(258, 70);
            this.DtgDatos.Margin = new System.Windows.Forms.Padding(2);
            this.DtgDatos.Name = "DtgDatos";
            this.DtgDatos.RowHeadersWidth = 51;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkGray;
            this.DtgDatos.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DtgDatos.RowTemplate.Height = 24;
            this.DtgDatos.Size = new System.Drawing.Size(663, 346);
            this.DtgDatos.TabIndex = 21;
            // 
            // BtnReturn
            // 
            this.BtnReturn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnReturn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.BtnReturn.Depth = 0;
            this.BtnReturn.HighEmphasis = true;
            this.BtnReturn.Icon = global::Caso_Desarrollo_Hotel.Properties.Resources.arrow_left;
            this.BtnReturn.Location = new System.Drawing.Point(13, 387);
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
            // TxtHabitacion
            // 
            this.TxtHabitacion.AnimateReadOnly = false;
            this.TxtHabitacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TxtHabitacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.TxtHabitacion.Depth = 0;
            this.TxtHabitacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TxtHabitacion.HideSelection = true;
            this.TxtHabitacion.Hint = "Habitacion id";
            this.TxtHabitacion.LeadingIcon = null;
            this.TxtHabitacion.Location = new System.Drawing.Point(12, 116);
            this.TxtHabitacion.Margin = new System.Windows.Forms.Padding(2);
            this.TxtHabitacion.MaxLength = 32767;
            this.TxtHabitacion.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtHabitacion.Name = "TxtHabitacion";
            this.TxtHabitacion.PasswordChar = '\0';
            this.TxtHabitacion.PrefixSuffixText = null;
            this.TxtHabitacion.ReadOnly = false;
            this.TxtHabitacion.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TxtHabitacion.SelectedText = "";
            this.TxtHabitacion.SelectionLength = 0;
            this.TxtHabitacion.SelectionStart = 0;
            this.TxtHabitacion.ShortcutsEnabled = true;
            this.TxtHabitacion.Size = new System.Drawing.Size(188, 48);
            this.TxtHabitacion.TabIndex = 12;
            this.TxtHabitacion.TabStop = false;
            this.TxtHabitacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtHabitacion.TrailingIcon = null;
            this.TxtHabitacion.UseSystemPasswordChar = false;
            // 
            // TxtCliente
            // 
            this.TxtCliente.AnimateReadOnly = false;
            this.TxtCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TxtCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.TxtCliente.Depth = 0;
            this.TxtCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TxtCliente.HideSelection = true;
            this.TxtCliente.Hint = "Cliente id";
            this.TxtCliente.LeadingIcon = null;
            this.TxtCliente.Location = new System.Drawing.Point(12, 72);
            this.TxtCliente.Margin = new System.Windows.Forms.Padding(2);
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
            this.TxtCliente.Size = new System.Drawing.Size(188, 48);
            this.TxtCliente.TabIndex = 11;
            this.TxtCliente.TabStop = false;
            this.TxtCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtCliente.TrailingIcon = null;
            this.TxtCliente.UseSystemPasswordChar = false;
            // 
            // DtpInicio
            // 
            this.DtpInicio.CalendarMonthBackground = System.Drawing.Color.Transparent;
            this.DtpInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpInicio.Location = new System.Drawing.Point(103, 205);
            this.DtpInicio.Margin = new System.Windows.Forms.Padding(2);
            this.DtpInicio.Name = "DtpInicio";
            this.DtpInicio.Size = new System.Drawing.Size(103, 23);
            this.DtpInicio.TabIndex = 23;
            // 
            // DtpFinal
            // 
            this.DtpFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFinal.Location = new System.Drawing.Point(103, 238);
            this.DtpFinal.Margin = new System.Windows.Forms.Padding(2);
            this.DtpFinal.Name = "DtpFinal";
            this.DtpFinal.Size = new System.Drawing.Size(103, 23);
            this.DtpFinal.TabIndex = 24;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(13, 205);
            this.materialLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(86, 19);
            this.materialLabel1.TabIndex = 25;
            this.materialLabel1.Text = "Fecha Inicio";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(13, 238);
            this.materialLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(83, 19);
            this.materialLabel2.TabIndex = 26;
            this.materialLabel2.Text = "Fecha Final";
            // 
            // BtnDelete
            // 
            this.BtnDelete.AutoSize = false;
            this.BtnDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnDelete.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.BtnDelete.Depth = 0;
            this.BtnDelete.HighEmphasis = true;
            this.BtnDelete.Icon = global::Caso_Desarrollo_Hotel.Properties.Resources.trash;
            this.BtnDelete.Location = new System.Drawing.Point(210, 153);
            this.BtnDelete.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.BtnDelete.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.NoAccentTextColor = System.Drawing.Color.Empty;
            this.BtnDelete.Size = new System.Drawing.Size(43, 37);
            this.BtnDelete.TabIndex = 30;
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
            this.BtnEdit.Location = new System.Drawing.Point(210, 114);
            this.BtnEdit.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.BtnEdit.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.NoAccentTextColor = System.Drawing.Color.Empty;
            this.BtnEdit.Size = new System.Drawing.Size(43, 37);
            this.BtnEdit.TabIndex = 29;
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
            this.BtnAdd.Location = new System.Drawing.Point(210, 72);
            this.BtnAdd.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.BtnAdd.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.NoAccentTextColor = System.Drawing.Color.Empty;
            this.BtnAdd.Size = new System.Drawing.Size(43, 37);
            this.BtnAdd.TabIndex = 28;
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
            this.BtnSearch.Location = new System.Drawing.Point(210, 192);
            this.BtnSearch.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.BtnSearch.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.NoAccentTextColor = System.Drawing.Color.Empty;
            this.BtnSearch.Size = new System.Drawing.Size(43, 37);
            this.BtnSearch.TabIndex = 27;
            this.BtnSearch.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.BtnSearch.UseAccentColor = false;
            this.BtnSearch.UseVisualStyleBackColor = true;
            // 
            // ChbReserved
            // 
            this.ChbReserved.AutoSize = true;
            this.ChbReserved.Checked = true;
            this.ChbReserved.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChbReserved.Depth = 0;
            this.ChbReserved.Location = new System.Drawing.Point(12, 166);
            this.ChbReserved.Margin = new System.Windows.Forms.Padding(0);
            this.ChbReserved.MouseLocation = new System.Drawing.Point(-1, -1);
            this.ChbReserved.MouseState = MaterialSkin.MouseState.HOVER;
            this.ChbReserved.Name = "ChbReserved";
            this.ChbReserved.ReadOnly = false;
            this.ChbReserved.Ripple = true;
            this.ChbReserved.Size = new System.Drawing.Size(109, 37);
            this.ChbReserved.TabIndex = 31;
            this.ChbReserved.Text = "Reservado";
            this.ChbReserved.UseVisualStyleBackColor = true;
            // 
            // FrmReservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 432);
            this.Controls.Add(this.ChbReserved);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.DtpFinal);
            this.Controls.Add(this.DtpInicio);
            this.Controls.Add(this.DtgDatos);
            this.Controls.Add(this.BtnReturn);
            this.Controls.Add(this.TxtHabitacion);
            this.Controls.Add(this.TxtCliente);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmReservas";
            this.Padding = new System.Windows.Forms.Padding(2, 52, 2, 2);
            this.Text = "FrmReservas";
            this.Load += new System.EventHandler(this.FrmReservas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DtgDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DtgDatos;
        private MaterialSkin.Controls.MaterialButton BtnReturn;
        private MaterialSkin.Controls.MaterialTextBox2 TxtHabitacion;
        private MaterialSkin.Controls.MaterialTextBox2 TxtCliente;
        private System.Windows.Forms.DateTimePicker DtpInicio;
        private System.Windows.Forms.DateTimePicker DtpFinal;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialButton BtnDelete;
        private MaterialSkin.Controls.MaterialButton BtnEdit;
        private MaterialSkin.Controls.MaterialButton BtnAdd;
        private MaterialSkin.Controls.MaterialButton BtnSearch;
        private MaterialSkin.Controls.MaterialCheckbox ChbReserved;
    }
}