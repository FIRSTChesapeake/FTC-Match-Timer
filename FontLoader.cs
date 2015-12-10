using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.Drawing.Text;
using DevComponents.DotNetBar;

namespace FTC_Timer_Display
{
    public static class FontLoader
    {
        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont,
            IntPtr pdv, [System.Runtime.InteropServices.In] ref uint pcFonts);

        private static PrivateFontCollection fonts = new PrivateFontCollection();

        public static bool setLabelFont(ref LabelX lbl, byte[] fontResource)
        {
            try
            {
                IntPtr fontPtr = System.Runtime.InteropServices.Marshal.AllocCoTaskMem(fontResource.Length);
                System.Runtime.InteropServices.Marshal.Copy(fontResource, 0, fontPtr, fontResource.Length);
                uint dummy = 0;
                fonts.AddMemoryFont(fontPtr, fontResource.Length);
                AddFontMemResourceEx(fontPtr, (uint)fontResource.Length, IntPtr.Zero, ref dummy);
                System.Runtime.InteropServices.Marshal.FreeCoTaskMem(fontPtr);

                lbl.Font = new Font(fonts.Families[0], lbl.Font.Size, lbl.Font.Style);
                return true;
            }
            catch
            { return false; }
        }

        public static bool sizeLabelFont(ref LabelX lbl)
        {
            try
            {
                Image img = new Bitmap(1, 1);
                Graphics g = Graphics.FromImage(img);
                SizeF extent = g.MeasureString(lbl.Text, lbl.Font);
                float hRatio = lbl.Height / extent.Height;
                float wRatio = lbl.Width / extent.Width;
                float ratio = (hRatio > wRatio) ? hRatio : wRatio;

                float newSize = lbl.Font.Size * ratio;
                lbl.Font = new Font(lbl.Font.FontFamily, newSize, lbl.Font.Style);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
