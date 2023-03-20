using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void CuntLab_Click(object sender, EventArgs e)
        {

        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            WishList.Items.Clear();
        }

        private void CountBtn_Click(object sender, EventArgs e)
        {
            CuntBox.Text = Convert.ToString(WishList.Items.Count);
        }

        private void SelLab_Click(object sender, EventArgs e)
        {

        }

        private void FillBtn_Click(object sender, EventArgs e)
        {
            WishList.Items.Add("A Snake");
            WishList.Items.Add("Machete");
            WishList.Items.Add("Oppo Phone");
            WishList.Items.Add("GTX 4090");
            WishList.Items.Add("USB Air Fryer");
            WishList.Items.Add("Sundae");
        }

        private void WishList_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelBox.Text = WishList.Text;
        }

        private void CuntBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void SelBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Tit_Click(object sender, EventArgs e)
        {

        }

        private void SortBtn_Click(object sender, EventArgs e)
        {
            WishList.Sorted = true;
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
