using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NMLT_WINFORM
{
    public partial class HangPopup : Form
    {
        public HangPopup()
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
                case 3:
                    return textBox3.Text;
                case 4:
                    return textBox4.Text;
                case 5:
                    return textBox5.Text;
                case 6:
                    {
                        if (comboBox1.SelectedItem == null)
                            return null;
                        else
                            return comboBox1.SelectedItem.ToString();
                    }
                default:
                    break;
            }
            //khi goi ham nay thi n nen da co san trong khoang 1 - 6
            return textBox1.Text; //dong nay chi de ham ko co loi
        }
        public void ChuyenDL(string a, string b, string c, string d, string e, string f)
        {
            textBox1.Text = a;
            textBox2.Text = b;
            textBox3.Text = c;
            textBox4.Text = d;
            textBox5.Text = e;
            comboBox1.Items.Add(f);
            comboBox1.SelectedIndex = 0;
        }
        public void addLhang(string n)
        {
            comboBox1.Items.Add(n);
        }

    }
}
