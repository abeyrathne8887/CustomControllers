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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.toggleButton1 = new CustomControllers.ToggleButton();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(240, 227);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 45);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // toggleButton1
            // 
            this.toggleButton1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.toggleButton1.DisplayText = "";
            this.toggleButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.toggleButton1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.toggleButton1.Image = global::CustomControllers.Properties.Resources._1468252351_device_volume_loudspeaker_speaker_up_glyph;
            this.toggleButton1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toggleButton1.Location = new System.Drawing.Point(54, 109);
            this.toggleButton1.Name = "toggleButton1";
            this.toggleButton1.Size = new System.Drawing.Size(63, 50);
            this.toggleButton1.TabIndex = 0;
            this.toggleButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.toggleButton1.ToggleOffColor = System.Drawing.SystemColors.Control;
            this.toggleButton1.ToggleOnColor = System.Drawing.SystemColors.Highlight;
            this.toggleButton1.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 395);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.toggleButton1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private ToggleButton toggleButton1;
        private System.Windows.Forms.Button button1;
    }
}

