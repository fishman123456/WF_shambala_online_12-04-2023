using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Drawing;

namespace WF_shambala_online_12_04_2023
{
    public class Work_sistem_DLL
    {
        public enum SystemMetric
        {
            VirtualScreenWidth = 78, // CXVIRTUALSCREEN 0x0000004E 
            VirtualScreenHeight = 79, // CYVIRTUALSCREEN 0x0000004F 
        }
        [DllImport("user32.dll")]
        public static extern int GetSystemMetrics(SystemMetric metric);
        public static Size GetVirtualDisplaySize()
        {
            var width = GetSystemMetrics(SystemMetric.VirtualScreenWidth);
            var height = GetSystemMetrics(SystemMetric.VirtualScreenHeight);
            return new Size(width, height);
        }


        [DllImport("gdi32.dll")]
        static extern int GetDeviceCaps(IntPtr hdc, int nIndex);
        public static int GetRealScreenDiag(int cap)
        {
            using (System.Drawing.Graphics g = System.Drawing.Graphics.FromHwnd(IntPtr.Zero))
            {
                IntPtr hdc = g.GetHdc();

                int result = GetDeviceCaps(hdc, cap);
               
                g.ReleaseHdc();

                return result;

            }
        }

    }
}
