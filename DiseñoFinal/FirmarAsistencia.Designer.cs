﻿using System.Runtime.InteropServices;
namespace DiseñoFinal
{
    partial class FirmarAsistencia
    {

        #region MoverPantalla
        [DllImport("user32.DLL", EntryPoint = "SendMessage")] //Médodos para importar librerias necesarias de la interface de usuario
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        private void MoveForm()
        {
            ReleaseCapture(); //Habilita la posibilidad de arrastrar el control y mover el formulario con el
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion

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
            this.components = new System.ComponentModel.Container();
            this.txt_Loginn = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Continuar = new System.Windows.Forms.Button();
            this.txt_Paswordd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pBSalir2 = new System.Windows.Forms.PictureBox();
            this.lbl_HoraActual = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_FechaActual = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBSalir2)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_Loginn
            // 
            this.txt_Loginn.Location = new System.Drawing.Point(102, 101);
            this.txt_Loginn.Name = "txt_Loginn";
            this.txt_Loginn.Size = new System.Drawing.Size(164, 20);
            this.txt_Loginn.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingrese sus credenciales para continuar";
            // 
            // btn_Continuar
            // 
            this.btn_Continuar.Location = new System.Drawing.Point(147, 158);
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
            this.txt_Paswordd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Paswordd.Location = new System.Drawing.Point(102, 127);
            this.txt_Paswordd.Name = "txt_Paswordd";
            this.txt_Paswordd.Size = new System.Drawing.Size(164, 21);
            this.txt_Paswordd.TabIndex = 1;
            this.txt_Paswordd.UseSystemPasswordChar = true;
            this.txt_Paswordd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Paswordd_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Usuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Contraseña";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::DiseñoFinal.Properties.Resources.Invisible_20px;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(269, 127);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(23, 21);
            this.button1.TabIndex = 6;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(96, 18);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "FIRMAR ASISTENCIA";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txt_Loginn);
            this.panel1.Controls.Add(this.txt_Paswordd);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btn_Continuar);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(0, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(340, 191);
            this.panel1.TabIndex = 8;
            // 
            // pBSalir2
            // 
            this.pBSalir2.BackColor = System.Drawing.Color.Transparent;
            this.pBSalir2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pBSalir2.Image = global::DiseñoFinal.Properties.Resources.salir11;
            this.pBSalir2.Location = new System.Drawing.Point(312, 7);
            this.pBSalir2.Name = "pBSalir2";
            this.pBSalir2.Size = new System.Drawing.Size(21, 19);
            this.pBSalir2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBSalir2.TabIndex = 27;
            this.pBSalir2.TabStop = false;
            this.pBSalir2.Click += new System.EventHandler(this.pBSalir2_Click);
            // 
            // lbl_HoraActual
            // 
            this.lbl_HoraActual.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_HoraActual.BackColor = System.Drawing.Color.Transparent;
            this.lbl_HoraActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_HoraActual.Location = new System.Drawing.Point(4, 9);
            this.lbl_HoraActual.Name = "lbl_HoraActual";
            this.lbl_HoraActual.Size = new System.Drawing.Size(332, 22);
            this.lbl_HoraActual.TabIndex = 9;
            this.lbl_HoraActual.Text = "12:00:00 PM";
            this.lbl_HoraActual.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Azure;
            this.panel2.Controls.Add(this.lbl_FechaActual);
            this.panel2.Controls.Add(this.lbl_HoraActual);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(339, 65);
            this.panel2.TabIndex = 10;
            // 
            // lbl_FechaActual
            // 
            this.lbl_FechaActual.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_FechaActual.BackColor = System.Drawing.Color.Transparent;
            this.lbl_FechaActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FechaActual.Location = new System.Drawing.Point(4, 32);
            this.lbl_FechaActual.Name = "lbl_FechaActual";
            this.lbl_FechaActual.Size = new System.Drawing.Size(332, 22);
            this.lbl_FechaActual.TabIndex = 10;
            this.lbl_FechaActual.Text = "Miercoles, 15 de Noviembre del 2017";
            this.lbl_FechaActual.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FirmarAsistencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = global::DiseñoFinal.Properties.Resources.Login;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(340, 244);
            this.Controls.Add(this.pBSalir2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FirmarAsistencia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FirmarAsistencia";
            this.Click += new System.EventHandler(this.FirmarAsistencia_Click);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FirmarAsistencia_MouseDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBSalir2)).EndInit();
            this.panel2.ResumeLayout(false);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pBSalir2;
        private System.Windows.Forms.Label lbl_HoraActual;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_FechaActual;
    }
}