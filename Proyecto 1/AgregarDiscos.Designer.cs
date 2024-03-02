namespace Proyecto_1
{
    partial class AgregarDiscos
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
            this.labelInformacion = new System.Windows.Forms.Label();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.labelFechaLanzamiento = new System.Windows.Forms.Label();
            this.labelCantCanciones = new System.Windows.Forms.Label();
            this.labelTapaImagen = new System.Windows.Forms.Label();
            this.labelEstilo = new System.Windows.Forms.Label();
            this.labelEdicion = new System.Windows.Forms.Label();
            this.textBoxTitulo = new System.Windows.Forms.TextBox();
            this.dateTimePickerFechaDeLanzamineto = new System.Windows.Forms.DateTimePicker();
            this.numericUpDownCantCanciones = new System.Windows.Forms.NumericUpDown();
            this.textBoxUrlTapaImagen = new System.Windows.Forms.TextBox();
            this.pictureBoxFondo = new System.Windows.Forms.PictureBox();
            this.buttonEnvian = new System.Windows.Forms.Button();
            this.buttonCerrar = new System.Windows.Forms.Button();
            this.comboBoxEstilo = new System.Windows.Forms.ComboBox();
            this.comboBoxEdicion = new System.Windows.Forms.ComboBox();
            this.pictureBoxImagenTapa = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCantCanciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFondo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagenTapa)).BeginInit();
            this.SuspendLayout();
            // 
            // labelInformacion
            // 
            this.labelInformacion.AutoSize = true;
            this.labelInformacion.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelInformacion.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInformacion.ForeColor = System.Drawing.Color.White;
            this.labelInformacion.Location = new System.Drawing.Point(11, 35);
            this.labelInformacion.Name = "labelInformacion";
            this.labelInformacion.Size = new System.Drawing.Size(245, 20);
            this.labelInformacion.TabIndex = 0;
            this.labelInformacion.Text = "INFORMACION DEL DISCO";
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelTitulo.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.ForeColor = System.Drawing.Color.White;
            this.labelTitulo.Location = new System.Drawing.Point(12, 78);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(62, 16);
            this.labelTitulo.TabIndex = 1;
            this.labelTitulo.Text = "TITULO";
            // 
            // labelFechaLanzamiento
            // 
            this.labelFechaLanzamiento.AutoSize = true;
            this.labelFechaLanzamiento.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelFechaLanzamiento.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFechaLanzamiento.ForeColor = System.Drawing.Color.White;
            this.labelFechaLanzamiento.Location = new System.Drawing.Point(12, 115);
            this.labelFechaLanzamiento.Name = "labelFechaLanzamiento";
            this.labelFechaLanzamiento.Size = new System.Drawing.Size(192, 16);
            this.labelFechaLanzamiento.TabIndex = 2;
            this.labelFechaLanzamiento.Text = "FECHA DE LANZAMIENTO";
            // 
            // labelCantCanciones
            // 
            this.labelCantCanciones.AutoSize = true;
            this.labelCantCanciones.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelCantCanciones.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCantCanciones.ForeColor = System.Drawing.Color.White;
            this.labelCantCanciones.Location = new System.Drawing.Point(12, 152);
            this.labelCantCanciones.Name = "labelCantCanciones";
            this.labelCantCanciones.Size = new System.Drawing.Size(200, 16);
            this.labelCantCanciones.TabIndex = 3;
            this.labelCantCanciones.Text = "CANTIDAD DE CANCIONES";
            // 
            // labelTapaImagen
            // 
            this.labelTapaImagen.AutoSize = true;
            this.labelTapaImagen.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelTapaImagen.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTapaImagen.ForeColor = System.Drawing.Color.White;
            this.labelTapaImagen.Location = new System.Drawing.Point(12, 187);
            this.labelTapaImagen.Name = "labelTapaImagen";
            this.labelTapaImagen.Size = new System.Drawing.Size(158, 16);
            this.labelTapaImagen.TabIndex = 4;
            this.labelTapaImagen.Text = "IMAGEN DE LA TAPA";
            // 
            // labelEstilo
            // 
            this.labelEstilo.AutoSize = true;
            this.labelEstilo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelEstilo.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEstilo.ForeColor = System.Drawing.Color.White;
            this.labelEstilo.Location = new System.Drawing.Point(12, 221);
            this.labelEstilo.Name = "labelEstilo";
            this.labelEstilo.Size = new System.Drawing.Size(61, 16);
            this.labelEstilo.TabIndex = 5;
            this.labelEstilo.Text = "ESTILO";
            // 
            // labelEdicion
            // 
            this.labelEdicion.AutoSize = true;
            this.labelEdicion.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelEdicion.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEdicion.ForeColor = System.Drawing.Color.White;
            this.labelEdicion.Location = new System.Drawing.Point(12, 259);
            this.labelEdicion.Name = "labelEdicion";
            this.labelEdicion.Size = new System.Drawing.Size(69, 16);
            this.labelEdicion.TabIndex = 6;
            this.labelEdicion.Text = "EDICION";
            // 
            // textBoxTitulo
            // 
            this.textBoxTitulo.Location = new System.Drawing.Point(80, 74);
            this.textBoxTitulo.Name = "textBoxTitulo";
            this.textBoxTitulo.Size = new System.Drawing.Size(232, 20);
            this.textBoxTitulo.TabIndex = 1;
            // 
            // dateTimePickerFechaDeLanzamineto
            // 
            this.dateTimePickerFechaDeLanzamineto.Location = new System.Drawing.Point(210, 111);
            this.dateTimePickerFechaDeLanzamineto.Name = "dateTimePickerFechaDeLanzamineto";
            this.dateTimePickerFechaDeLanzamineto.Size = new System.Drawing.Size(196, 20);
            this.dateTimePickerFechaDeLanzamineto.TabIndex = 2;
            // 
            // numericUpDownCantCanciones
            // 
            this.numericUpDownCantCanciones.Location = new System.Drawing.Point(223, 151);
            this.numericUpDownCantCanciones.Name = "numericUpDownCantCanciones";
            this.numericUpDownCantCanciones.Size = new System.Drawing.Size(58, 20);
            this.numericUpDownCantCanciones.TabIndex = 3;
            // 
            // textBoxUrlTapaImagen
            // 
            this.textBoxUrlTapaImagen.Location = new System.Drawing.Point(176, 183);
            this.textBoxUrlTapaImagen.Name = "textBoxUrlTapaImagen";
            this.textBoxUrlTapaImagen.Size = new System.Drawing.Size(230, 20);
            this.textBoxUrlTapaImagen.TabIndex = 4;
            this.textBoxUrlTapaImagen.Leave += new System.EventHandler(this.textBoxUrlTapaImagen_Leave);
            // 
            // pictureBoxFondo
            // 
            this.pictureBoxFondo.Location = new System.Drawing.Point(-9, -4);
            this.pictureBoxFondo.Name = "pictureBoxFondo";
            this.pictureBoxFondo.Size = new System.Drawing.Size(711, 385);
            this.pictureBoxFondo.TabIndex = 13;
            this.pictureBoxFondo.TabStop = false;
            // 
            // buttonEnvian
            // 
            this.buttonEnvian.Location = new System.Drawing.Point(15, 314);
            this.buttonEnvian.Name = "buttonEnvian";
            this.buttonEnvian.Size = new System.Drawing.Size(145, 24);
            this.buttonEnvian.TabIndex = 7;
            this.buttonEnvian.Text = "SUBIR";
            this.buttonEnvian.UseVisualStyleBackColor = true;
            this.buttonEnvian.Click += new System.EventHandler(this.buttonEnvian_Click);
            // 
            // buttonCerrar
            // 
            this.buttonCerrar.Location = new System.Drawing.Point(261, 314);
            this.buttonCerrar.Name = "buttonCerrar";
            this.buttonCerrar.Size = new System.Drawing.Size(145, 24);
            this.buttonCerrar.TabIndex = 8;
            this.buttonCerrar.Text = "CERRAR";
            this.buttonCerrar.UseVisualStyleBackColor = true;
            this.buttonCerrar.Click += new System.EventHandler(this.buttonCerrar_Click);
            // 
            // comboBoxEstilo
            // 
            this.comboBoxEstilo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEstilo.FormattingEnabled = true;
            this.comboBoxEstilo.Location = new System.Drawing.Point(79, 221);
            this.comboBoxEstilo.Name = "comboBoxEstilo";
            this.comboBoxEstilo.Size = new System.Drawing.Size(104, 21);
            this.comboBoxEstilo.TabIndex = 5;
            // 
            // comboBoxEdicion
            // 
            this.comboBoxEdicion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEdicion.FormattingEnabled = true;
            this.comboBoxEdicion.Location = new System.Drawing.Point(87, 258);
            this.comboBoxEdicion.Name = "comboBoxEdicion";
            this.comboBoxEdicion.Size = new System.Drawing.Size(104, 21);
            this.comboBoxEdicion.TabIndex = 6;
            // 
            // pictureBoxImagenTapa
            // 
            this.pictureBoxImagenTapa.Location = new System.Drawing.Point(434, 74);
            this.pictureBoxImagenTapa.Name = "pictureBoxImagenTapa";
            this.pictureBoxImagenTapa.Size = new System.Drawing.Size(216, 204);
            this.pictureBoxImagenTapa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxImagenTapa.TabIndex = 18;
            this.pictureBoxImagenTapa.TabStop = false;
            // 
            // AgregarDiscos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(681, 359);
            this.Controls.Add(this.pictureBoxImagenTapa);
            this.Controls.Add(this.comboBoxEdicion);
            this.Controls.Add(this.comboBoxEstilo);
            this.Controls.Add(this.buttonCerrar);
            this.Controls.Add(this.buttonEnvian);
            this.Controls.Add(this.textBoxUrlTapaImagen);
            this.Controls.Add(this.numericUpDownCantCanciones);
            this.Controls.Add(this.dateTimePickerFechaDeLanzamineto);
            this.Controls.Add(this.textBoxTitulo);
            this.Controls.Add(this.labelEdicion);
            this.Controls.Add(this.labelEstilo);
            this.Controls.Add(this.labelTapaImagen);
            this.Controls.Add(this.labelCantCanciones);
            this.Controls.Add(this.labelFechaLanzamiento);
            this.Controls.Add(this.labelTitulo);
            this.Controls.Add(this.labelInformacion);
            this.Controls.Add(this.pictureBoxFondo);
            this.MaximumSize = new System.Drawing.Size(697, 398);
            this.MinimumSize = new System.Drawing.Size(697, 398);
            this.Name = "AgregarDiscos";
            this.ShowIcon = false;
            this.Text = "Agregar Disco";
            this.Load += new System.EventHandler(this.AgregarDiscos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCantCanciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFondo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagenTapa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelInformacion;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Label labelFechaLanzamiento;
        private System.Windows.Forms.Label labelCantCanciones;
        private System.Windows.Forms.Label labelTapaImagen;
        private System.Windows.Forms.Label labelEstilo;
        private System.Windows.Forms.Label labelEdicion;
        private System.Windows.Forms.TextBox textBoxTitulo;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaDeLanzamineto;
        private System.Windows.Forms.NumericUpDown numericUpDownCantCanciones;
        private System.Windows.Forms.TextBox textBoxUrlTapaImagen;
        private System.Windows.Forms.PictureBox pictureBoxFondo;
        private System.Windows.Forms.Button buttonEnvian;
        private System.Windows.Forms.Button buttonCerrar;
        private System.Windows.Forms.ComboBox comboBoxEstilo;
        private System.Windows.Forms.ComboBox comboBoxEdicion;
        private System.Windows.Forms.PictureBox pictureBoxImagenTapa;
    }
}