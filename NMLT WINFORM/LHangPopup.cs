using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NMLT_WINFORM
{
    public partial class LHangPopup : Form
    {
        public LHangPopup()
        {
            InitializeComponent();
        }
        public string getText(int n)
        {
            switch (n)
            {
                case 1:
                    return textBox1.Text;
                case 2:
                    return textBox2.Text;
            }
            return textBox1.Text;
        }
        public void ChuyenDL(string a, string b)
        {
            textBox1.Text = a;
            textBox2.Text = b;
        }        
    }
}
