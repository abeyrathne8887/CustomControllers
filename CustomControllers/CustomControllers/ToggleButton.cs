using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomControllers
{
    public partial class ToggleButton : Button
    {
        public ToggleButton()
        {
            InitializeComponent();
            DisplayText = "";
        }
        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
        bool isOneMode = false;

        Color toggleOnColor;
        public Color ToggleOnColor
        {
            get { return toggleOnColor; }
            set { toggleOnColor = value; Invalidate();}
        }

        Color toggleOffColor;
        public Color ToggleOffColor
        {
            get { return toggleOffColor; }
            set { toggleOffColor = value; Invalidate(); }
        }

        String StrDisplayText;
        public String DisplayText
        {
            get { return StrDisplayText; }
            set
            {StrDisplayText = value; Invalidate();}
        }

        private Image imgOnImage;

        public Image ImgOnImage
        {
            get { return imgOnImage; }
            set { imgOnImage = value; }
        }
        private Image imgOffImage;

        public Image ImgOffImage
        {
            get { return imgOffImage; }
            set { imgOffImage = value; }
        }


        //[Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
        //[Obsolete("just cast me to avoid all this hiding...", true)]
        //public new ContentAlignment TextAlign { get; set; }

        //[Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
        //[Obsolete("just cast me to avoid all this hiding...", true)]
        //public new Boolean Visible { get; set; }


        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            isOneMode = !isOneMode;
            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            if (!isOneMode)
            {
                pnl_togle.BackColor = ToggleOffColor;
                this.Image = ImgOffImage;
            }
            else
            {
                pnl_togle.BackColor = toggleOnColor; ;
                this.Image = imgOnImage;
            }
            lbText.Text = DisplayText;
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            pnl_togle.Width = this.Width - 20;
            pnl_togle.Location = new System.Drawing.Point(10,this.Height-15);
            Invalidate();
        }

        private void lbText_Click(object sender, EventArgs e)
        {
            OnClick(e);
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            //base.OnMouseEnter(e);
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            //base.OnMouseLeave(e);
        }
    }
}