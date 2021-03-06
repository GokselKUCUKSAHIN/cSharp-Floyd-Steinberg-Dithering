﻿namespace SteinbergDithering
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
            this.pictureBoxView = new System.Windows.Forms.PictureBox();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.buttonDither = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.factorSlider = new System.Windows.Forms.TrackBar();
            this.isGrayScaleCheckbox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.factorSlider)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxView
            // 
            this.pictureBoxView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxView.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pictureBoxView.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxView.Name = "pictureBoxView";
            this.pictureBoxView.Size = new System.Drawing.Size(604, 476);
            this.pictureBoxView.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxView.TabIndex = 0;
            this.pictureBoxView.TabStop = false;
            // 
            // buttonLoad
            // 
            this.buttonLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonLoad.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonLoad.Location = new System.Drawing.Point(12, 497);
            this.buttonLoad.MaximumSize = new System.Drawing.Size(94, 37);
            this.buttonLoad.MinimumSize = new System.Drawing.Size(94, 37);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(94, 37);
            this.buttonLoad.TabIndex = 1;
            this.buttonLoad.Text = "Load";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.ButtonLoad_Click);
            // 
            // buttonDither
            // 
            this.buttonDither.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDither.Enabled = false;
            this.buttonDither.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonDither.Location = new System.Drawing.Point(422, 497);
            this.buttonDither.MaximumSize = new System.Drawing.Size(94, 37);
            this.buttonDither.MinimumSize = new System.Drawing.Size(94, 37);
            this.buttonDither.Name = "buttonDither";
            this.buttonDither.Size = new System.Drawing.Size(94, 37);
            this.buttonDither.TabIndex = 2;
            this.buttonDither.Text = "Dither";
            this.buttonDither.UseVisualStyleBackColor = true;
            this.buttonDither.Click += new System.EventHandler(this.ButtonDither_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave.Enabled = false;
            this.buttonSave.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonSave.Location = new System.Drawing.Point(522, 497);
            this.buttonSave.MaximumSize = new System.Drawing.Size(94, 37);
            this.buttonSave.MinimumSize = new System.Drawing.Size(94, 37);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(94, 37);
            this.buttonSave.TabIndex = 3;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // factorSlider
            // 
            this.factorSlider.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.factorSlider.AutoSize = false;
            this.factorSlider.Location = new System.Drawing.Point(112, 497);
            this.factorSlider.Maximum = 5;
            this.factorSlider.Minimum = 1;
            this.factorSlider.Name = "factorSlider";
            this.factorSlider.Size = new System.Drawing.Size(268, 37);
            this.factorSlider.TabIndex = 4;
            this.factorSlider.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.factorSlider.Value = 2;
            this.factorSlider.Scroll += new System.EventHandler(this.FactorSlider_Scroll);
            // 
            // isGrayScaleCheckbox
            // 
            this.isGrayScaleCheckbox.AutoSize = true;
            this.isGrayScaleCheckbox.Location = new System.Drawing.Point(390, 510);
            this.isGrayScaleCheckbox.Name = "isGrayScaleCheckbox";
            this.isGrayScaleCheckbox.Size = new System.Drawing.Size(15, 14);
            this.isGrayScaleCheckbox.TabIndex = 5;
            this.isGrayScaleCheckbox.UseVisualStyleBackColor = true;
            this.isGrayScaleCheckbox.CheckedChanged += new System.EventHandler(this.IsGrayScale_Changed);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 543);
            this.Controls.Add(this.isGrayScaleCheckbox);
            this.Controls.Add(this.factorSlider);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonDither);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.pictureBoxView);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(644, 582);
            this.Name = "Form1";
            this.Text = "JellyBeanci Steinberg Dithering";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.factorSlider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxView;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.Button buttonDither;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TrackBar factorSlider;
        private System.Windows.Forms.CheckBox isGrayScaleCheckbox;
    }
}

