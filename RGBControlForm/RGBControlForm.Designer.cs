namespace RGBControlForm
{
    partial class RGBControlForm
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
            this.myRgbControl = new ControlLibrary.RGBControl();
            this.SuspendLayout();
            // 
            // myRgbControl
            // 
            this.myRgbControl.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.myRgbControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myRgbControl.Location = new System.Drawing.Point(0, 0);
            this.myRgbControl.Name = "myRgbControl";
            this.myRgbControl.Size = new System.Drawing.Size(197, 112);
            this.myRgbControl.TabIndex = 0;
            // 
            // RGBControlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(197, 112);
            this.Controls.Add(this.myRgbControl);
            this.MaximizeBox = false;
            this.Name = "RGBControlForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RGB";
            this.ResumeLayout(false);

        }

        #endregion

        private ControlLibrary.RGBControl myRgbControl;
    }
}