using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NMLT_WINFORM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Ham them hang
        private void ThemHang_Click(object sender, EventArgs e)
        {
            HangPopup Popup = new HangPopup();
            for (int i = 0; i < listLHang.Items.Count;i++)
            {
                Popup.addLhang(listLHang.Items[i].SubItems[0].Text);
            }
            DialogResult dialogresult = Popup.ShowDialog();
            if (dialogresult == DialogResult.OK)
            {
                listHang.Items.Add(new ListViewItem(new string[] { Popup.getText(1), Popup.getText(2), Popup.getText(3), Popup.getText(4), Popup.getText(5),Popup.getText(6) }));
            }
            Popup.Dispose(); //dispose: dong cua so popup khoi bo nho, neu ko co dispose thi cua so van se chay ngam
        }
        //ham sua chi tiet hang
        private void SuaHang_Click(object sender, EventArgs e)
        {
            string a1 = listHang.SelectedItems[0].SubItems[0].Text;
            string b1 = listHang.SelectedItems[0].SubItems[1].Text;
            string c1 = listHang.SelectedItems[0].SubItems[2].Text;
            string d1 = listHang.SelectedItems[0].SubItems[3].Text;
            string e1 = listHang.SelectedItems[0].SubItems[4].Text;
            string f1 = listHang.SelectedItems[0].SubItems[5].Text;
            HangPopup popup = new HangPopup();
            popup.ChuyenDL(a1, b1, c1, d1, e1, f1);
            for (int i = 0; i < listLHang.Items.Count; i++)
            {
                if (f1 != listLHang.Items[i].SubItems[0].Text)
                    popup.addLhang(listLHang.Items[i].SubItems[0].Text);
            }
            DialogResult dialogresult = popup.ShowDialog();
            if (dialogresult == DialogResult.OK)
            {
                listHang.SelectedItems[0].SubItems[0].Text = popup.getText(1); 
                listHang.SelectedItems[0].SubItems[1].Text = popup.getText(2);
                listHang.SelectedItems[0].SubItems[2].Text = popup.getText(3);
                listHang.SelectedItems[0].SubItems[3].Text = popup.getText(4);
                listHang.SelectedItems[0].SubItems[4].Text = popup.getText(5);
                listHang.SelectedItems[0].SubItems[5].Text = popup.getText(6);
            }
            popup.Dispose();
        }
        //ham xoa hang
        private void XoaHang_Click(object sender, EventArgs e)
        {
            listHang.SelectedItems[0].Remove();
        }
        //ham tim kiem hang
        private void TimHang_Click(object sender, EventArgs e)
        {
            search popup = new search();
            string a;
            DialogResult diag = popup.ShowDialog();
            if (diag == DialogResult.OK)
            { 
                a = popup.getText(); 
            }
            else
            {
                popup.Dispose();
                return;
            }
            for (int i = 0; i < listHang.Items.Count; i++)
            {
                if (a == listHang.Items[i].SubItems[0].Text)
                {
                    listHang.Items[i].Selected = true;
                    listHang.Select();
                    break;
                }
                else
                    MessageBox.Show("Khong co ket qua");
            }
            popup.Dispose();
        }
        //cac ham xu li loai hang
        //ham them loai hang
        private void ThemLHang_Click(object sender, EventArgs e)
        {
            LHangPopup Popup = new LHangPopup();
            DialogResult dialogresult = Popup.ShowDialog();
            if (dialogresult == DialogResult.OK)
            {
                listLHang.Items.Add(new ListViewItem(new string[] { Popup.getText(1), Popup.getText(2) }));
            }
            Popup.Dispose();
        }
        //ham sua loai hang
        private void SuaLHang_Click(object sender, EventArgs e)
        {
            string a = listLHang.SelectedItems[0].SubItems[0].Text;
            string b = listLHang.SelectedItems[0].SubItems[1].Text;
            LHangPopup popup = new LHangPopup();
            popup.ChuyenDL(a, b);
            DialogResult dialogresult = popup.ShowDialog();
            if (dialogresult == DialogResult.OK)
            {
                listLHang.SelectedItems[0].SubItems[0].Text = popup.getText(1);
                listLHang.SelectedItems[0].SubItems[1].Text = popup.getText(2);
            }
            popup.Dispose();
        }
        //ham xoa loai hang
        private void XoaLHang_Click(object sender, EventArgs e)
        {
            listLHang.SelectedItems[0].Remove();
        }
        //ham tim kiem loai hang
        private void TimLHang_Click(object sender, EventArgs e)
        {
            search popup = new search();
            string a;
            DialogResult diag = popup.ShowDialog();
            if (diag == DialogResult.OK)
            {
                a = popup.getText();
            }
            else
            {
                popup.Dispose();
                return;
            }
            for (int i = 0; i < listHang.Items.Count; i++)
            {
                if (a == listLHang.Items[i].SubItems[0].Text)
                {
                    listLHang.Items[i].Selected = true;
                    listLHang.Select();
                    break;
                }
                else
                    MessageBox.Show("Khong co ket qua");
            }
            popup.Dispose();
        }


        //2 ham kiem soat button sua, xoa 
        private void listHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listHang.SelectedItems.Count > 0)
            {
                SuaHang.Enabled = true;
                XoaHang.Enabled = true;
            }
            else
            {
                SuaHang.Enabled = false;
                XoaHang.Enabled = false;
            }
        }

        private void listLHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listLHang.SelectedItems.Count > 0)
            {
                SuaLHang.Enabled = true;
                XoaLHang.Enabled = true;
            }
            else
            {
                SuaLHang.Enabled = false;
                XoaLHang.Enabled = false;
            }
        }

        //nut test generate 4 items de test
        private void button1_Click(object sender, EventArgs e)
        {
            listLHang.Items.Add(new ListViewItem(new string[] { "Bánh","B01" }));
            listLHang.Items.Add(new ListViewItem(new string[] { "Điện thoại", "MB1" }));
            listHang.Items.Add(new ListViewItem(new string[] { "Bánh rán", "RAN", "1/1/2022", "Nhà máy rán", "2021", "Bánh" }));
            listHang.Items.Add(new ListViewItem(new string[] { "Samsung a12", "A12", "ko có", "Samsung", "2020", "Điện thoại" }));
        }

        
    }
}
