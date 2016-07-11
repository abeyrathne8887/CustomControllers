namespace CustomControllers
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
            this.toggleButton1 = new CustomControllers.ToggleButton();
            this.toggleButton2 = new CustomControllers.ToggleButton();
            this.SuspendLayout();
            // 
            // toggleButton1
            // 
            this.toggleButton1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.toggleButton1.DisplayText = "";
            this.toggleButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.toggleButton1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.toggleButton1.Image = global::CustomControllers.Properties.Resources._1468252351_device_volume_loudspeaker_speaker_up_glyph;
            this.toggleButton1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toggleButton1.Location = new System.Drawing.Point(54, 105);
            this.toggleButton1.Name = "toggleButton1";
            this.toggleButton1.Size = new System.Drawing.Size(58, 54);
            this.toggleButton1.TabIndex = 0;
            this.toggleButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.toggleButton1.ToggleOffColor = System.Drawing.SystemColors.Control;
            this.toggleButton1.ToggleOnColor = System.Drawing.SystemColors.Highlight;
            this.toggleButton1.UseVisualStyleBackColor = false;
            // 
            // toggleButton2
            // 
            this.toggleButton2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.toggleButton2.DisplayText = "";
            this.toggleButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.toggleButton2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.toggleButton2.Image = global::CustomControllers.Properties.Resources._1468252351_device_volume_loudspeaker_speaker_up_glyph;
            this.toggleButton2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toggleButton2.Location = new System.Drawing.Point(118, 105);
            this.toggleButton2.Name = "toggleButton2";
            this.toggleButton2.Size = new System.Drawing.Size(58, 54);
            this.toggleButton2.TabIndex = 1;
            this.toggleButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.toggleButton2.ToggleOffColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.toggleButton2.ToggleOnColor = System.Drawing.Color.Red;
            this.toggleButton2.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 395);
            this.Controls.Add(this.toggleButton2);
            this.Controls.Add(this.toggleButton1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private ToggleButton toggleButton1;
        private ToggleButton toggleButton2;
    }
}

