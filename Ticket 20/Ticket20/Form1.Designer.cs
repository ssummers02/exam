using System;
using System.Drawing;

namespace Ticket20
{
    partial class Form1
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
            this.paintButton = new System.Windows.Forms.Button();
            this.cleanButton = new System.Windows.Forms.Button();

            this.SuspendLayout();
            // 
            // paintButton
            // 
            this.paintButton.Location = new System.Drawing.Point(20 , 20 + 35 * 8);
            this.paintButton.Name = "paintButton";
            this.paintButton.Size = new System.Drawing.Size(20 + 35 * 4, 20);
            this.paintButton.TabIndex = 1;
            this.paintButton.Text = "Посчитать";
            this.paintButton.UseVisualStyleBackColor = true;
            this.paintButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // cleanButton
            // 
            this.cleanButton.Location = new System.Drawing.Point(20 , 20 + 35 * 9);
            this.cleanButton.Name = "cleanButton";
            this.cleanButton.Size = new System.Drawing.Size(20 + 35 * 4, 20);
            this.cleanButton.TabIndex = 2;
            this.cleanButton.Text = "Очистить";
            this.cleanButton.UseVisualStyleBackColor = true;
            this.cleanButton.Click += new System.EventHandler(this.cleanButtonClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.paintButton);
            this.Controls.Add(this.cleanButton);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Графы";
            this.ResumeLayout(false);
        }
        private System.Windows.Forms.Label textLabel;
        private System.Windows.Forms.Label textLabel4;
        private System.Windows.Forms.Label textLabel5;
        private System.Windows.Forms.Label textLabel6;
        private System.Windows.Forms.Label textLabel7;
        private System.Windows.Forms.Label textLabel8;
        private System.Windows.Forms.Label textLabel9;

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button paintButton;
        private System.Windows.Forms.Button cleanButton;



        #endregion
    }
}