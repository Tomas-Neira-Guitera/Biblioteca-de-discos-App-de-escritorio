namespace Proyecto_1
{
    partial class Informacion
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
            this.dataGridViewGeneros = new System.Windows.Forms.DataGridView();
            this.dataGridViewEdiciones = new System.Windows.Forms.DataGridView();
            this.labelGeneros = new System.Windows.Forms.Label();
            this.labelEdiciones = new System.Windows.Forms.Label();
            this.pictureBoxFondo = new System.Windows.Forms.PictureBox();
            this.buttonCerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGeneros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEdiciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFondo)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewGeneros
            // 
            this.dataGridViewGeneros.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridViewGeneros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGeneros.Location = new System.Drawing.Point(12, 62);
            this.dataGridViewGeneros.Name = "dataGridViewGeneros";
            this.dataGridViewGeneros.Size = new System.Drawing.Size(248, 176);
            this.dataGridViewGeneros.TabIndex = 0;
            // 
            // dataGridViewEdiciones
            // 
            this.dataGridViewEdiciones.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridViewEdiciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEdiciones.Location = new System.Drawing.Point(340, 62);
            this.dataGridViewEdiciones.Name = "dataGridViewEdiciones";
            this.dataGridViewEdiciones.Size = new System.Drawing.Size(249, 176);
            this.dataGridViewEdiciones.TabIndex = 1;
            // 
            // labelGeneros
            // 
            this.labelGeneros.AutoSize = true;
            this.labelGeneros.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelGeneros.ForeColor = System.Drawing.Color.White;
            this.labelGeneros.Location = new System.Drawing.Point(12, 36);
            this.labelGeneros.Name = "labelGeneros";
            this.labelGeneros.Size = new System.Drawing.Size(60, 13);
            this.labelGeneros.TabIndex = 2;
            this.labelGeneros.Text = "GENEROS";
            // 
            // labelEdiciones
            // 
            this.labelEdiciones.AutoSize = true;
            this.labelEdiciones.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelEdiciones.ForeColor = System.Drawing.Color.White;
            this.labelEdiciones.Location = new System.Drawing.Point(337, 36);
            this.labelEdiciones.Name = "labelEdiciones";
            this.labelEdiciones.Size = new System.Drawing.Size(65, 13);
            this.labelEdiciones.TabIndex = 3;
            this.labelEdiciones.Text = "EDICIONES";
            // 
            // pictureBoxFondo
            // 
            this.pictureBoxFondo.Location = new System.Drawing.Point(-7, -9);
            this.pictureBoxFondo.Name = "pictureBoxFondo";
            this.pictureBoxFondo.Size = new System.Drawing.Size(621, 308);
            this.pictureBoxFondo.TabIndex = 4;
            this.pictureBoxFondo.TabStop = false;
            // 
            // buttonCerrar
            // 
            this.buttonCerrar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonCerrar.ForeColor = System.Drawing.Color.White;
            this.buttonCerrar.Location = new System.Drawing.Point(257, 253);
            this.buttonCerrar.Name = "buttonCerrar";
            this.buttonCerrar.Size = new System.Drawing.Size(83, 26);
            this.buttonCerrar.TabIndex = 5;
            this.buttonCerrar.Text = "CERRAR";
            this.buttonCerrar.UseVisualStyleBackColor = false;
            this.buttonCerrar.Click += new System.EventHandler(this.buttonCerrar_Click);
            // 
            // Informacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(601, 285);
            this.Controls.Add(this.buttonCerrar);
            this.Controls.Add(this.labelEdiciones);
            this.Controls.Add(this.labelGeneros);
            this.Controls.Add(this.dataGridViewEdiciones);
            this.Controls.Add(this.dataGridViewGeneros);
            this.Controls.Add(this.pictureBoxFondo);
            this.MaximumSize = new System.Drawing.Size(617, 324);
            this.MinimumSize = new System.Drawing.Size(617, 324);
            this.Name = "Informacion";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Informacion";
            this.Load += new System.EventHandler(this.Informacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGeneros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEdiciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFondo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewGeneros;
        private System.Windows.Forms.DataGridView dataGridViewEdiciones;
        private System.Windows.Forms.Label labelGeneros;
        private System.Windows.Forms.Label labelEdiciones;
        private System.Windows.Forms.PictureBox pictureBoxFondo;
        private System.Windows.Forms.Button buttonCerrar;
    }
}