namespace CustomControllers
{
    partial class ToggleButton
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnl_togle = new System.Windows.Forms.Panel();
            this.lbText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pnl_togle
            // 
            this.pnl_togle.BackColor = System.Drawing.SystemColors.Control;
            this.pnl_togle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnl_togle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_togle.ForeColor = System.Drawing.SystemColors.Control;
            this.pnl_togle.Location = new System.Drawing.Point(15, 60);
            this.pnl_togle.Name = "pnl_togle";
            this.pnl_togle.Size = new System.Drawing.Size(70, 10);
            this.pnl_togle.TabIndex = 0;
            // 
            // lbText
            // 
            this.lbText.AutoSize = true;
            this.lbText.Location = new System.Drawing.Point(26, 24);
            this.lbText.Name = "lbText";
            this.lbText.Size = new System.Drawing.Size(0, 13);
            this.lbText.TabIndex = 1;
            this.lbText.Click += new System.EventHandler(this.lbText_Click);
            // 
            // ToggleButton
            // 
            this.Controls.Add(this.lbText);
            this.Controls.Add(this.pnl_togle);
            this.Size = new System.Drawing.Size(100, 75);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_togle;
        private System.Windows.Forms.Label lbText;
    }
}
