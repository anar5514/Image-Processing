using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageProcessingWithWinform
{
    public class Processing
    {
        public static bool ConvertToSelectedColor(Bitmap b, Color c)
        {
            try
            {
                for (int i = 0; i < b.Width; i++)
                    for (int j = 0; j < b.Height; j++)
                    {
                        var color = b.GetPixel(i, j);
                        int r1 = color.R;
                        int g1 = color.G;
                        int b1 = color.B;

                        int gray = (byte)(c.R * r1 + c.G * g1 + c.B * b1);
                        r1 = gray;
                        g1 = gray;
                        b1 = gray;

                        b.SetPixel(i, j, Color.FromArgb(r1, g1, b1));
                    }

            }
            catch (Exception ex)
            {
               MessageBox.Show(ex.Message);
            }

            return true;
        }

    }
}
