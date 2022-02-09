using System;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace ControlLibrary
{
    public enum EMode
    {
        Dec, Hex
    }

    public partial class NumberTextBox : TextBox
    {
        private readonly string[] hexChars = new string[] { "A", "B", "C", "D", "F" };

        private EMode mode;

        public EventHandler ModeChanged;

        public EMode Mode
        {
            get
            {
                return mode;
            }
            set
            {
                mode = value;
                OnModeChanged(new EventArgs());
            }
        }

        public int NumValue { get; set; }

        public NumberTextBox()
        {
            InitializeComponent();
            Mode = EMode.Dec;
        }

        public NumberTextBox(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
            Mode = EMode.Dec;
        }

        protected override void OnKeyPress (KeyPressEventArgs e)
        {
            /* привести введённый символ к верхнему регистру */
            e.KeyChar = char.ToUpper(e.KeyChar);

            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                if (Mode == EMode.Dec || Mode == EMode.Hex && !hexChars.Contains(e.KeyChar.ToString()))
                    e.Handled = true;
            }
            base.OnKeyPress(e);
        }

        protected override void OnTextChanged(EventArgs e)
        {
            int value;

            if (Mode == EMode.Dec)
            {
                if (!int.TryParse(Text, out value) || value < 0)
                {
                    value = 0;
                    Text = "0";
                }
                else if (value > 255)
                {
                    value = 255;
                    Text = "255";
                }
                else
                    Text = value.ToString();
            }

            else
            {
                if (!int.TryParse(Text, NumberStyles.HexNumber, CultureInfo.CurrentCulture, out value) || value < 0)
                {
                    value = 0;
                    Text = "0";
                }
                else if (value > 255)
                {
                    value = 255;
                    Text = "FF";
                }
                else
                    Text = value.ToString("X");
            }

            NumValue = value;

            /* переместить курсор в конец введённых символов */
            SelectionStart = Text.Length;

            base.OnTextChanged(e);
        }

        protected void OnModeChanged (EventArgs e)
        {
            if (ModeChanged != null)
                ModeChanged(this, new EventArgs());

            switch (Mode)
            {
                case EMode.Dec:
                    Text = Text == "" ? "" : int.Parse(Text, NumberStyles.HexNumber).ToString();
                    break;
                case EMode.Hex:
                    Text = $"{int.Parse(Text):X}";
                    break;
            }
        }
    }
}
