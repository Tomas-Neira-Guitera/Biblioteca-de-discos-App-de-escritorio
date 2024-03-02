namespace Proyecto_1
{
    partial class EliminarDisco
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
            this.labelIdDisco = new System.Windows.Forms.Label();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.pictureBoxFondo = new System.Windows.Forms.PictureBox();
            this.comboBoxDiscoAEliminar = new System.Windows.Forms.ComboBox();
            this.pictureBoxImagenTapa = new System.Windows.Forms.PictureBox();
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
            this.labelInformacion.Location = new System.Drawing.Point(12, 30);
            this.labelInformacion.Name = "labelInformacion";
            this.labelInformacion.Size = new System.Drawing.Size(245, 20);
            this.labelInformacion.TabIndex = 0;
            this.labelInformacion.Text = "INFORMACION DEL DISCO";
            // 
            // labelIdDisco
            // 
            this.labelIdDisco.AutoSize = true;
            this.labelIdDisco.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelIdDisco.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIdDisco.ForeColor = System.Drawing.Color.White;
            this.labelIdDisco.Location = new System.Drawing.Point(13, 84);
            this.labelIdDisco.Name = "labelIdDisco";
            this.labelIdDisco.Size = new System.Drawing.Size(148, 16);
            this.labelIdDisco.TabIndex = 1;
            this.labelIdDisco.Text = "TITULO DEL DISCO";
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Location = new System.Drawing.Point(12, 201);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(102, 28);
            this.buttonEliminar.TabIndex = 3;
            this.buttonEliminar.Text = "ELIMINAR";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(155, 201);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(102, 28);
            this.buttonCancelar.TabIndex = 4;
            this.buttonCancelar.Text = "CERRAR";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // pictureBoxFondo
            // 
            this.pictureBoxFondo.Location = new System.Drawing.Point(-7, 0);
            this.pictureBoxFondo.Name = "pictureBoxFondo";
            this.pictureBoxFondo.Size = new System.Drawing.Size(510, 289);
            this.pictureBoxFondo.TabIndex = 6;
            this.pictureBoxFondo.TabStop = false;
            // 
            // comboBoxDiscoAEliminar
            // 
            this.comboBoxDiscoAEliminar.FormattingEnabled = true;
            this.comboBoxDiscoAEliminar.Location = new System.Drawing.Point(12, 119);
            this.comboBoxDiscoAEliminar.Name = "comboBoxDiscoAEliminar";
            this.comboBoxDiscoAEliminar.Size = new System.Drawing.Size(245, 21);
            this.comboBoxDiscoAEliminar.TabIndex = 2;
            this.comboBoxDiscoAEliminar.SelectionChangeCommitted += new System.EventHandler(this.comboBoxDiscoAEliminar_SelectionChangeCommitted);
            // 
            // pictureBoxImagenTapa
            // 
            this.pictureBoxImagenTapa.Location = new System.Drawing.Point(289, 58);
            this.pictureBoxImagenTapa.Name = "pictureBoxImagenTapa";
            this.pictureBoxImagenTapa.Size = new System.Drawing.Size(188, 171);
            this.pictureBoxImagenTapa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxImagenTapa.TabIndex = 8;
            this.pictureBoxImagenTapa.TabStop = false;
            // 
            // EliminarDisco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(489, 271);
            this.Controls.Add(this.pictureBoxImagenTapa);
            this.Controls.Add(this.comboBoxDiscoAEliminar);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.labelIdDisco);
            this.Controls.Add(this.labelInformacion);
            this.Controls.Add(this.pictureBoxFondo);
            this.MaximumSize = new System.Drawing.Size(505, 310);
            this.MinimumSize = new System.Drawing.Size(505, 310);
            this.Name = "EliminarDisco";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eliminar Disco";
            this.Load += new System.EventHandler(this.EliminarDisco_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFondo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagenTapa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelInformacion;
        private System.Windows.Forms.Label labelIdDisco;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.PictureBox pictureBoxFondo;
        private System.Windows.Forms.ComboBox comboBoxDiscoAEliminar;
        private System.Windows.Forms.PictureBox pictureBoxImagenTapa;
    }
}