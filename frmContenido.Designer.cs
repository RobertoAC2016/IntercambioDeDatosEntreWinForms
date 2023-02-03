namespace WinFormControlDemo
{
    partial class frmContenido
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
            this.dgvdatos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdatos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvdatos
            // 
            this.dgvdatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdatos.Location = new System.Drawing.Point(30, 30);
            this.dgvdatos.Name = "dgvdatos";
            this.dgvdatos.RowTemplate.Height = 25;
            this.dgvdatos.Size = new System.Drawing.Size(575, 306);
            this.dgvdatos.TabIndex = 0;
            // 
            // frmContenido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 371);
            this.Controls.Add(this.dgvdatos);
            this.Name = "frmContenido";
            this.Text = "Forma de contenido";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmContenido_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdatos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgvdatos;
    }
}