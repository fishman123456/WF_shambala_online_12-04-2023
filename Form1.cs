using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using static WF_shambala_online_12_04_2023.Work_sistem_DLL;

namespace WF_shambala_online_12_04_2023
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Work_sistem_DLL one = new Work_sistem_DLL();
            textBox1.Text = Work_sistem_DLL.GetVirtualDisplaySize().ToString();
            int wight = Work_sistem_DLL.GetRealScreenDiag(4);
            int hight = Work_sistem_DLL.GetRealScreenDiag(6);
            textBox2.Text = wight.ToString() + "   " + hight.ToString();
            double diag = (Math.Sqrt((wight * wight) + (hight * hight)))/25.4;
            textBox3.Text = diag.ToString();
        }
    }
}
//weight
//           height