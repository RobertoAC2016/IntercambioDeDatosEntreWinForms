namespace WinFormControlDemo
{
    partial class frmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnsave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.lblname = new System.Windows.Forms.Label();
            this.lbllastname = new System.Windows.Forms.Label();
            this.txtlastname = new System.Windows.Forms.TextBox();
            this.lblphone = new System.Windows.Forms.Label();
            this.txtphone = new System.Windows.Forms.TextBox();
            this.lbljob = new System.Windows.Forms.Label();
            this.txtjob = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(101, 294);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(75, 23);
            this.btnsave.TabIndex = 0;
            this.btnsave.Text = "Guardar";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "Captura de datos";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(157, 74);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(100, 23);
            this.txtname.TabIndex = 2;
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(31, 82);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(51, 15);
            this.lblname.TabIndex = 3;
            this.lblname.Text = "Nombre";
            // 
            // lbllastname
            // 
            this.lbllastname.AutoSize = true;
            this.lbllastname.Location = new System.Drawing.Point(31, 133);
            this.lbllastname.Name = "lbllastname";
            this.lbllastname.Size = new System.Drawing.Size(51, 15);
            this.lbllastname.TabIndex = 5;
            this.lbllastname.Text = "Apellido";
            // 
            // txtlastname
            // 
            this.txtlastname.Location = new System.Drawing.Point(157, 125);
            this.txtlastname.Name = "txtlastname";
            this.txtlastname.Size = new System.Drawing.Size(100, 23);
            this.txtlastname.TabIndex = 4;
            // 
            // lblphone
            // 
            this.lblphone.AutoSize = true;
            this.lblphone.Location = new System.Drawing.Point(31, 195);
            this.lblphone.Name = "lblphone";
            this.lblphone.Size = new System.Drawing.Size(52, 15);
            this.lblphone.TabIndex = 7;
            this.lblphone.Text = "Telefono";
            // 
            // txtphone
            // 
            this.txtphone.Location = new System.Drawing.Point(157, 187);
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(100, 23);
            this.txtphone.TabIndex = 6;
            // 
            // lbljob
            // 
            this.lbljob.AutoSize = true;
            this.lbljob.Location = new System.Drawing.Point(31, 258);
            this.lbljob.Name = "lbljob";
            this.lbljob.Size = new System.Drawing.Size(45, 15);
            this.lbljob.TabIndex = 9;
            this.lbljob.Text = "Trabajo";
            // 
            // txtjob
            // 
            this.txtjob.Location = new System.Drawing.Point(157, 250);
            this.txtjob.Name = "txtjob";
            this.txtjob.Size = new System.Drawing.Size(100, 23);
            this.txtjob.TabIndex = 8;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 366);
            this.Controls.Add(this.lbljob);
            this.Controls.Add(this.txtjob);
            this.Controls.Add(this.lblphone);
            this.Controls.Add(this.txtphone);
            this.Controls.Add(this.lbllastname);
            this.Controls.Add(this.txtlastname);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnsave);
            this.Name = "frmPrincipal";
            this.Text = "Forma principal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnsave;
        private Label label1;
        private TextBox txtname;
        private Label lblname;
        private Label lbllastname;
        private TextBox txtlastname;
        private Label lblphone;
        private TextBox txtphone;
        private Label lbljob;
        private TextBox txtjob;
    }
}