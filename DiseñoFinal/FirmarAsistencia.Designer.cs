namespace DiseñoFinal
{
    partial class FirmarAsistencia
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
            this.txt_Loginn = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Continuar = new System.Windows.Forms.Button();
            this.txt_Paswordd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_Loginn
            // 
            this.txt_Loginn.Location = new System.Drawing.Point(74, 36);
            this.txt_Loginn.Name = "txt_Loginn";
            this.txt_Loginn.Size = new System.Drawing.Size(164, 20);
            this.txt_Loginn.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingrese sus credenciales para continuar";
            // 
            // btn_Continuar
            // 
            this.btn_Continuar.Location = new System.Drawing.Point(99, 94);
            this.btn_Continuar.Name = "btn_Continuar";
            this.btn_Continuar.Size = new System.Drawing.Size(75, 23);
            this.btn_Continuar.TabIndex = 2;
            this.btn_Continuar.Text = "Continuar";
            this.btn_Continuar.UseVisualStyleBackColor = true;
            this.btn_Continuar.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_Paswordd
            // 
            this.txt_Paswordd.AcceptsReturn = true;
            this.txt_Paswordd.Location = new System.Drawing.Point(74, 62);
            this.txt_Paswordd.Name = "txt_Paswordd";
            this.txt_Paswordd.Size = new System.Drawing.Size(164, 20);
            this.txt_Paswordd.TabIndex = 1;
            this.txt_Paswordd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Paswordd_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Usuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Contraseña";
            // 
            // FirmarAsistencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 129);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Paswordd);
            this.Controls.Add(this.btn_Continuar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Loginn);
            this.Name = "FirmarAsistencia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FirmarAsistencia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Loginn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Continuar;
        private System.Windows.Forms.TextBox txt_Paswordd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}