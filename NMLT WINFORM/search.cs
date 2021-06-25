using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NMLT_WINFORM
{
    public partial class search : Form
    {
        public search()
        {
            InitializeComponent();
        }

        public string getText()
        {
            return textBox1.Text;
        }
    }
}
