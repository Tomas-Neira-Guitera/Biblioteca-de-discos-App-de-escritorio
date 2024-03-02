namespace Proyecto_1
{
    partial class FormDiscos
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
            this.labelBiblioteca = new System.Windows.Forms.Label();
            this.dataGridViewDiscos = new System.Windows.Forms.DataGridView();
            this.pictureBoxDisco = new System.Windows.Forms.PictureBox();
            this.pictureBoxFondo = new System.Windows.Forms.PictureBox();
            this.buttonInfo = new System.Windows.Forms.Button();
            this.buttoneAgregar = new System.Windows.Forms.Button();
            this.buttonEliminarDisco = new System.Windows.Forms.Button();
            this.buttonModificar = new System.Windows.Forms.Button();
            this.textBoxBuscador = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDiscos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDisco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFondo)).BeginInit();
            this.SuspendLayout();
            // 
            // labelBiblioteca
            // 
            this.labelBiblioteca.AutoSize = true;
            this.labelBiblioteca.BackColor = System.Drawing.Color.Black;
            this.labelBiblioteca.Font = new System.Drawing.Font("Algerian", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBiblioteca.ForeColor = System.Drawing.Color.White;
            this.labelBiblioteca.Location = new System.Drawing.Point(12, 29);
            this.labelBiblioteca.Name = "labelBiblioteca";
            this.labelBiblioteca.Size = new System.Drawing.Size(157, 26);
            this.labelBiblioteca.TabIndex = 0;
            this.labelBiblioteca.Text = "BIBLIOTECA";
            // 
            // dataGridViewDiscos
            // 
            this.dataGridViewDiscos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewDiscos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewDiscos.BackgroundColor = System.Drawing.Color.Black;
            this.dataGridViewDiscos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewDiscos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridViewDiscos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDiscos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewDiscos.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridViewDiscos.Location = new System.Drawing.Point(12, 68);
            this.dataGridViewDiscos.MaximumSize = new System.Drawing.Size(557, 211);
            this.dataGridViewDiscos.MinimumSize = new System.Drawing.Size(557, 211);
            this.dataGridViewDiscos.MultiSelect = false;
            this.dataGridViewDiscos.Name = "dataGridViewDiscos";
            this.dataGridViewDiscos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDiscos.Size = new System.Drawing.Size(557, 211);
            this.dataGridViewDiscos.TabIndex = 1;
            this.dataGridViewDiscos.SelectionChanged += new System.EventHandler(this.dataGridViewDiscos_SelectionChanged);
            // 
            // pictureBoxDisco
            // 
            this.pictureBoxDisco.Location = new System.Drawing.Point(575, 68);
            this.pictureBoxDisco.Name = "pictureBoxDisco";
            this.pictureBoxDisco.Size = new System.Drawing.Size(221, 211);
            this.pictureBoxDisco.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxDisco.TabIndex = 2;
            this.pictureBoxDisco.TabStop = false;
            // 
            // pictureBoxFondo
            // 
            this.pictureBoxFondo.Location = new System.Drawing.Point(-3, -8);
            this.pictureBoxFondo.Name = "pictureBoxFondo";
            this.pictureBoxFondo.Size = new System.Drawing.Size(819, 345);
            this.pictureBoxFondo.TabIndex = 3;
            this.pictureBoxFondo.TabStop = false;
            // 
            // buttonInfo
            // 
            this.buttonInfo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonInfo.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonInfo.Location = new System.Drawing.Point(12, 296);
            this.buttonInfo.Name = "buttonInfo";
            this.buttonInfo.Size = new System.Drawing.Size(124, 24);
            this.buttonInfo.TabIndex = 2;
            this.buttonInfo.Text = "INFORMACION";
            this.buttonInfo.UseVisualStyleBackColor = false;
            this.buttonInfo.Click += new System.EventHandler(this.buttonInfo_Click);
            // 
            // buttoneAgregar
            // 
            this.buttoneAgregar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttoneAgregar.ForeColor = System.Drawing.SystemColors.Control;
            this.buttoneAgregar.Location = new System.Drawing.Point(151, 296);
            this.buttoneAgregar.Name = "buttoneAgregar";
            this.buttoneAgregar.Size = new System.Drawing.Size(124, 24);
            this.buttoneAgregar.TabIndex = 3;
            this.buttoneAgregar.Text = "AGREGAR DISCO";
            this.buttoneAgregar.UseVisualStyleBackColor = false;
            this.buttoneAgregar.Click += new System.EventHandler(this.buttoneAgregar_Click);
            // 
            // buttonEliminarDisco
            // 
            this.buttonEliminarDisco.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonEliminarDisco.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonEliminarDisco.Location = new System.Drawing.Point(290, 296);
            this.buttonEliminarDisco.Name = "buttonEliminarDisco";
            this.buttonEliminarDisco.Size = new System.Drawing.Size(124, 24);
            this.buttonEliminarDisco.TabIndex = 4;
            this.buttonEliminarDisco.Text = "ELIMINAR DISCO";
            this.buttonEliminarDisco.UseVisualStyleBackColor = false;
            this.buttonEliminarDisco.Click += new System.EventHandler(this.buttonEliminarDisco_Click);
            // 
            // buttonModificar
            // 
            this.buttonModificar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonModificar.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonModificar.Location = new System.Drawing.Point(429, 296);
            this.buttonModificar.Name = "buttonModificar";
            this.buttonModificar.Size = new System.Drawing.Size(124, 24);
            this.buttonModificar.TabIndex = 5;
            this.buttonModificar.Text = "MODIFICAR DISCO";
            this.buttonModificar.UseVisualStyleBackColor = false;
            this.buttonModificar.Click += new System.EventHandler(this.buttonModificar_Click);
            // 
            // textBoxBuscador
            // 
            this.textBoxBuscador.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBoxBuscador.Location = new System.Drawing.Point(175, 32);
            this.textBoxBuscador.Name = "textBoxBuscador";
            this.textBoxBuscador.Size = new System.Drawing.Size(239, 20);
            this.textBoxBuscador.TabIndex = 6;
            this.textBoxBuscador.TextChanged += new System.EventHandler(this.textBoxBuscador_TextChanged);
            // 
            // FormDiscos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(808, 332);
            this.Controls.Add(this.textBoxBuscador);
            this.Controls.Add(this.buttonModificar);
            this.Controls.Add(this.buttonEliminarDisco);
            this.Controls.Add(this.buttoneAgregar);
            this.Controls.Add(this.buttonInfo);
            this.Controls.Add(this.pictureBoxDisco);
            this.Controls.Add(this.dataGridViewDiscos);
            this.Controls.Add(this.labelBiblioteca);
            this.Controls.Add(this.pictureBoxFondo);
            this.MaximumSize = new System.Drawing.Size(824, 371);
            this.MinimumSize = new System.Drawing.Size(824, 371);
            this.Name = "FormDiscos";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Discos";
            this.Load += new System.EventHandler(this.FormDiscos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDiscos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDisco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFondo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelBiblioteca;
        private System.Windows.Forms.DataGridView dataGridViewDiscos;
        private System.Windows.Forms.PictureBox pictureBoxDisco;
        private System.Windows.Forms.PictureBox pictureBoxFondo;
        private System.Windows.Forms.Button buttonInfo;
        private System.Windows.Forms.Button buttoneAgregar;
        private System.Windows.Forms.Button buttonEliminarDisco;
        private System.Windows.Forms.Button buttonModificar;
        private System.Windows.Forms.TextBox textBoxBuscador;
    }
}

