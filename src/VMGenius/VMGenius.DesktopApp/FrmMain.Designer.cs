namespace VMGenius.DesktopApp
{
    partial class FrmMain
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
            this.BtnMain = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnMain
            // 
            this.BtnMain.Location = new System.Drawing.Point(44, 73);
            this.BtnMain.Name = "BtnMain";
            this.BtnMain.Size = new System.Drawing.Size(112, 34);
            this.BtnMain.TabIndex = 0;
            this.BtnMain.Text = "&Run";
            this.BtnMain.UseVisualStyleBackColor = true;
            this.BtnMain.Click += new System.EventHandler(this.BtnMain_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnMain);
            this.Name = "FrmMain";
            this.Text = "VMGenius";
            this.ResumeLayout(false);

        }

        #endregion

        private Button BtnMain;
    }
}