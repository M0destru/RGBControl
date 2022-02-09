using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace ControlLibrary
{
    public partial class RGBControl : UserControl
    {
        private Color color;

        private EMode mode;

        public event EventHandler ColorChanged;

        public Color Color
        {
            get
            {
                return color;
            }
            set
            {
                Color oldColor = color;
                color = value;
                if (oldColor != color)
                {
                    OnColorChanged();
                }
            }
        }

        public RGBControl()
        {
            InitializeComponent();
            mode = EMode.Dec;
            Color = Color.Black;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics g = CreateGraphics();
            g.DrawRectangle(new Pen(color), 107, 8, 80, 75);
            g.FillRectangle(new SolidBrush(color), 107, 8, 80, 75);

        }

        protected void OnColorChanged()
        {
            if (ColorChanged != null)
                ColorChanged(this, new EventArgs());

            numTbColorRed.Text = numTbColorRed.Mode == EMode.Dec ? color.R.ToString() : color.R.ToString("X");
            numTbColorGreen.Text = numTbColorGreen.Mode == EMode.Dec ? color.G.ToString() : color.G.ToString("X");
            numTbColorBlue.Text = numTbColorBlue.Mode == EMode.Dec ? color.B.ToString() : color.B.ToString("X");
            Invalidate();

        }

        private void numTbColorRed_TextChanged(object sender, EventArgs e)
        {
            Color = Color.FromArgb(numTbColorRed.NumValue, Color.G, Color.B);
        }

        private void numTbColorGreen_TextChanged(object sender, EventArgs e)
        {
            Color = Color.FromArgb(Color.R, numTbColorGreen.NumValue, Color.B);
        }

        private void numTbColorBlue_TextChanged(object sender, EventArgs e)
        {
            Color = Color.FromArgb(Color.R, Color.G, numTbColorBlue.NumValue);
        }

        private void radioBtnDec_CheckedChanged(object sender, EventArgs e)
        {
            if (mode == EMode.Dec) return;

            mode = EMode.Dec;
            numTbColorRed.Mode = mode;
            numTbColorGreen.Mode = mode;
            numTbColorBlue.Mode = mode;
        }

        private void radioBtnHex_CheckedChanged(object sender, EventArgs e)
        {
            if (mode == EMode.Hex) return;

            mode = EMode.Hex;
            numTbColorRed.Mode = mode;
            numTbColorGreen.Mode = mode;
            numTbColorBlue.Mode = mode;
        }
    }

}
