﻿
namespace Renaming_Prog
{
    partial class Error
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
            this.Error_label = new System.Windows.Forms.Label();
            this.Confirm = new System.Windows.Forms.Button();
            this.Errorlabel2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Error_label
            // 
            this.Error_label.AutoSize = true;
            this.Error_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Error_label.Location = new System.Drawing.Point(-1, 9);
            this.Error_label.Name = "Error_label";
            this.Error_label.Size = new System.Drawing.Size(204, 16);
            this.Error_label.TabIndex = 0;
            this.Error_label.Text = "Hiba! Nincs megadva az útvonal!";
            // 
            // Confirm
            // 
            this.Confirm.Location = new System.Drawing.Point(65, 68);
            this.Confirm.Name = "Confirm";
            this.Confirm.Size = new System.Drawing.Size(75, 23);
            this.Confirm.TabIndex = 1;
            this.Confirm.Text = "Ok";
            this.Confirm.UseVisualStyleBackColor = true;
            this.Confirm.Click += new System.EventHandler(this.Confirm_Click);
            // 
            // Errorlabel2
            // 
            this.Errorlabel2.AutoSize = true;
            this.Errorlabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Errorlabel2.Location = new System.Drawing.Point(2, 34);
            this.Errorlabel2.Name = "Errorlabel2";
            this.Errorlabel2.Size = new System.Drawing.Size(201, 16);
            this.Errorlabel2.TabIndex = 2;
            this.Errorlabel2.Text = "Adja meg helyesen az útvonalat!";
            // 
            // Error
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(206, 113);
            this.Controls.Add(this.Errorlabel2);
            this.Controls.Add(this.Confirm);
            this.Controls.Add(this.Error_label);
            this.Name = "Error";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Error";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Error_label;
        private System.Windows.Forms.Button Confirm;
        private System.Windows.Forms.Label Errorlabel2;
    }
}