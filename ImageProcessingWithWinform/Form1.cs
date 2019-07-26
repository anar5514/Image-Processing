using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageProcessingWithWinform
{
    public partial class Form1 : Form
    {
        Color color = new Color();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image File (*bmp, *jpg)|*bmp; *jpg;";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    originalPic.Image = new Bitmap(ofd.FileName);
                }
            }
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            Bitmap copy = new Bitmap(this.originalPic.Image);

            Processing.ConvertToSelectedColor(copy, color);

            resultPic.Image = copy;
        }

        private void btnSelectColor_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
               color = cd.Color;

            }
        }
    }
}
