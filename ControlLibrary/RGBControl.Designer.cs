namespace ControlLibrary
{
    partial class RGBControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbColorRed = new System.Windows.Forms.Label();
            this.lbColorGreen = new System.Windows.Forms.Label();
            this.lbColorBlue = new System.Windows.Forms.Label();
            this.radioBtnDec = new System.Windows.Forms.RadioButton();
            this.radioBtnHex = new System.Windows.Forms.RadioButton();
            this.numTbColorBlue = new ControlLibrary.NumberTextBox();
            this.numTbColorGreen = new ControlLibrary.NumberTextBox();
            this.numTbColorRed = new ControlLibrary.NumberTextBox();
            this.SuspendLayout();
            // 
            // lbColorRed
            // 
            this.lbColorRed.AutoSize = true;
            this.lbColorRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lbColorRed.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbColorRed.Location = new System.Drawing.Point(3, 11);
            this.lbColorRed.Name = "lbColorRed";
            this.lbColorRed.Size = new System.Drawing.Size(33, 15);
            this.lbColorRed.TabIndex = 0;
            this.lbColorRed.Text = "Red";
            // 
            // lbColorGreen
            // 
            this.lbColorGreen.AutoSize = true;
            this.lbColorGreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lbColorGreen.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbColorGreen.Location = new System.Drawing.Point(2, 37);
            this.lbColorGreen.Name = "lbColorGreen";
            this.lbColorGreen.Size = new System.Drawing.Size(46, 15);
            this.lbColorGreen.TabIndex = 1;
            this.lbColorGreen.Text = "Green";
            // 
            // lbColorBlue
            // 
            this.lbColorBlue.AutoSize = true;
            this.lbColorBlue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lbColorBlue.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbColorBlue.Location = new System.Drawing.Point(3, 64);
            this.lbColorBlue.Name = "lbColorBlue";
            this.lbColorBlue.Size = new System.Drawing.Size(36, 15);
            this.lbColorBlue.TabIndex = 2;
            this.lbColorBlue.Text = "Blue";
            // 
            // radioBtnDec
            // 
            this.radioBtnDec.AutoSize = true;
            this.radioBtnDec.Checked = true;
            this.radioBtnDec.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.radioBtnDec.Location = new System.Drawing.Point(3, 91);
            this.radioBtnDec.Name = "radioBtnDec";
            this.radioBtnDec.Size = new System.Drawing.Size(45, 17);
            this.radioBtnDec.TabIndex = 6;
            this.radioBtnDec.TabStop = true;
            this.radioBtnDec.Text = "Dec";
            this.radioBtnDec.UseVisualStyleBackColor = true;
            this.radioBtnDec.CheckedChanged += new System.EventHandler(this.radioBtnDec_CheckedChanged);
            // 
            // radioBtnHex
            // 
            this.radioBtnHex.AutoSize = true;
            this.radioBtnHex.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.radioBtnHex.Location = new System.Drawing.Point(54, 91);
            this.radioBtnHex.Name = "radioBtnHex";
            this.radioBtnHex.Size = new System.Drawing.Size(44, 17);
            this.radioBtnHex.TabIndex = 7;
            this.radioBtnHex.TabStop = true;
            this.radioBtnHex.Text = "Hex";
            this.radioBtnHex.UseVisualStyleBackColor = true;
            this.radioBtnHex.CheckedChanged += new System.EventHandler(this.radioBtnHex_CheckedChanged);
            // 
            // numTbColorBlue
            // 
            this.numTbColorBlue.Location = new System.Drawing.Point(54, 63);
            this.numTbColorBlue.Mode = ControlLibrary.EMode.Dec;
            this.numTbColorBlue.Name = "numTbColorBlue";
            this.numTbColorBlue.Size = new System.Drawing.Size(44, 20);
            this.numTbColorBlue.TabIndex = 5;
            this.numTbColorBlue.TextChanged += new System.EventHandler(this.numTbColorBlue_TextChanged);
            // 
            // numTbColorGreen
            // 
            this.numTbColorGreen.Location = new System.Drawing.Point(54, 36);
            this.numTbColorGreen.Mode = ControlLibrary.EMode.Dec;
            this.numTbColorGreen.Name = "numTbColorGreen";
            this.numTbColorGreen.Size = new System.Drawing.Size(44, 20);
            this.numTbColorGreen.TabIndex = 4;
            this.numTbColorGreen.TextChanged += new System.EventHandler(this.numTbColorGreen_TextChanged);
            // 
            // numTbColorRed
            // 
            this.numTbColorRed.Location = new System.Drawing.Point(54, 10);
            this.numTbColorRed.Mode = ControlLibrary.EMode.Dec;
            this.numTbColorRed.Name = "numTbColorRed";
            this.numTbColorRed.Size = new System.Drawing.Size(44, 20);
            this.numTbColorRed.TabIndex = 3;
            this.numTbColorRed.TextChanged += new System.EventHandler(this.numTbColorRed_TextChanged);
            // 
            // RGBControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.radioBtnHex);
            this.Controls.Add(this.radioBtnDec);
            this.Controls.Add(this.numTbColorBlue);
            this.Controls.Add(this.numTbColorGreen);
            this.Controls.Add(this.numTbColorRed);
            this.Controls.Add(this.lbColorBlue);
            this.Controls.Add(this.lbColorGreen);
            this.Controls.Add(this.lbColorRed);
            this.Name = "RGBControl";
            this.Size = new System.Drawing.Size(211, 111);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbColorRed;
        private System.Windows.Forms.Label lbColorGreen;
        private System.Windows.Forms.Label lbColorBlue;
        private NumberTextBox numTbColorRed;
        private NumberTextBox numTbColorGreen;
        private NumberTextBox numTbColorBlue;
        private System.Windows.Forms.RadioButton radioBtnDec;
        private System.Windows.Forms.RadioButton radioBtnHex;
    }
}
