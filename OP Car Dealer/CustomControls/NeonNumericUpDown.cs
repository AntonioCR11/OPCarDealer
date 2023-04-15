using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OP_Car_Dealer.CustomControls
{
    [DefaultEvent("_TextChanged")]
    public partial class NeonNumericUpDown : UserControl
    {
        //Fields
        private Color borderColor = Color.MediumSlateBlue;
        private Color borderFocusColor = Color.HotPink;
        private int borderSize = 2;
        private bool isFocused = false;
        private Int64 interval = 1;
        private Int64 minimumValue = 0;
        private Int64 maximumValue = 100;

        public NeonNumericUpDown()
        {
            InitializeComponent();
            Texts = MinimumValue.ToString();
        }

        //Events
        public event EventHandler _TextChanged;

        //Properties
        [Category("RJ Code Advance")]
        public Int64 Interval
        {
            get { return interval; }
            set { interval = value; }
        }
        
        [Category("RJ Code Advance")]
        public Int64 MinimumValue
        {
            get { return minimumValue; }
            set {
                minimumValue = value;
                if (Convert.ToInt32(Texts) < minimumValue)
                    Texts = value.ToString();
            }
        }
        
        
        [Category("RJ Code Advance")]
        public Int64 MaximumValue
        {
            get { return maximumValue; }
            set {
                maximumValue = value;
                if (Convert.ToInt64(Texts) > maximumValue)
                    Texts = value.ToString();
            }
        }

        [Category("RJ Code Advance")]
        public Color BorderColor
        {
            get { return borderColor; }
            set
            {
                borderColor = value;
                upButton.BackColor = value;
                downButton.BackColor = value;
                this.Invalidate();
            }
        }

        [Category("RJ Code Advance")]
        public int BorderSize
        {
            get { return borderSize; }
            set
            {
                borderSize = value;
                this.Invalidate();
            }
        }

        [Category("RJ Code Advance")]
        public override Color BackColor
        {
            get { return base.BackColor; }
            set
            {
                base.BackColor = value;
                textBox1.BackColor = value;
            }
        }

        [Category("RJ Code Advance")]
        public override Color ForeColor
        {
            get { return base.ForeColor; }
            set
            {
                base.ForeColor = value;
                textBox1.ForeColor = value;
                upButton.ForeColor = value;
                downButton.ForeColor = value;
            }
        }

        [Category("RJ Code Advance")]
        public override Font Font
        {
            get { return base.Font; }
            set
            {
                base.Font = value;
                textBox1.Font = value;
                if (this.DesignMode)
                {
                    UpdateControlHeight() ;
                    UpdateControlWidth();
                }
            }
        }

        [Category("RJ Code Advance")]
        public string Texts
        {
            get { return textBox1.Text; }
            set {
                bool isValid = validateText(value);

                if (isValid) textBox1.Text = value;
                else Texts = minimumValue.ToString();
            }
        }

        [Category("RJ Code Advance")]
        public Color BorderFocusColor
        {
            get { return borderFocusColor; }
            set { borderFocusColor = value; }
        }

        //Overridden methods
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics graph = e.Graphics;

            //Draw border
            using (Pen penBorder = new Pen(borderColor, borderSize))
            {
                penBorder.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset;
                if (isFocused)
                {
                    penBorder.Color = borderFocusColor;
                    upButton.BackColor = borderFocusColor;
                    downButton.BackColor = borderFocusColor;
                }
                else
                {
                    upButton.BackColor = borderColor;
                    downButton.BackColor = borderColor;
                }

                graph.DrawRectangle(penBorder, 0, 0, this.Width - 0.5F, this.Height - 0.5F);
            }
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if (this.DesignMode)
            {
                UpdateControlHeight();
                UpdateControlWidth();
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            UpdateControlHeight();
            UpdateControlWidth();
            setMaxMin();
        }

        //Private methods
        private void UpdateControlHeight()
        {
            if (textBox1.Multiline == false)
            {
                int txtHeight = TextRenderer.MeasureText("Text", this.Font).Height + 1;
                textBox1.Multiline = true;
                textBox1.MinimumSize = new Size(0, txtHeight);
                textBox1.Multiline = false;

                this.Height = textBox1.Height + this.Padding.Top + this.Padding.Bottom;
            }
        }

        private void UpdateControlWidth()
        {
            int txtWidth = TextRenderer.MeasureText("Text", this.Font).Width + 1;

            int minWidth = this.Padding.Left + this.Padding.Right + upButton.Width + downButton.Width + txtWidth;
            if (this.Width < minWidth)
            {
                this.Width = minWidth;
            }
        }

        private void setMaxMin()
        {
            bool isValid = validateText(Texts);
            if (isValid)
            {
                if (Convert.ToInt64(Texts) < minimumValue)
                    Texts = minimumValue.ToString();
                else if (Convert.ToInt64(Texts) > maximumValue)
                    Texts = MaximumValue.ToString();
            }
            else Texts = minimumValue.ToString();
        }

        private bool validateText(string value)
        {
            if (String.IsNullOrEmpty(value))
                return false;

            int parsedValue;
            if (!int.TryParse(value, out parsedValue))
            {
                MessageBox.Show("This field is for numbers only!", "NumericUpDown Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        //TextBox events
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (_TextChanged != null)
                _TextChanged.Invoke(sender, e);
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
        }

        private void textBox1_MouseEnter(object sender, EventArgs e)
        {
            this.OnMouseEnter(e);
        }

        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
            this.OnMouseLeave(e);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.OnKeyPress(e);
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            isFocused = true;
            this.Invalidate();
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            isFocused = false;

            setMaxMin();

            this.Invalidate();
        }

        // Button Events
        private void downButton_Click(object sender, EventArgs e)
        {
            Int64 newValue = Convert.ToInt64(Texts) - interval;

            if (newValue >= minimumValue)
                Texts = newValue.ToString();
            else
                Texts = minimumValue.ToString();
        }

        private void upButton_Click(object sender, EventArgs e)
        {
            Int64 newValue = Convert.ToInt64(Texts) + interval;

            if (newValue <= maximumValue)
                Texts = newValue.ToString();
            else
                Texts = maximumValue.ToString();
        }
    }
}
