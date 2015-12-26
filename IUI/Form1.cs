using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ClassLibrary1.UIHide class1 = new ClassLibrary1.UIHide(this, new Timer());

        }
        public void shmain() 
        {
            if (this.Top < 0)
            {
                this.Location = new Point(this.Location.X, 1);
            }
            else if (this.Left <= 0)
            {
                //stopAnchor = AnchorStyles.Left;
            }
            else if (this.Left >= Screen.PrimaryScreen.Bounds.Width - this.Width)
            {
                //stopAnchor = AnchorStyles.Right;
            }
            else if (this.Top >= Screen.PrimaryScreen.Bounds.Height - this.Height)
            {
                //stopAnchor = AnchorStyles.Bottom;
            }
            else
            {
                //stopAnchor = AnchorStyles.None;
            }
            this.Show();                                //窗体显示
            this.WindowState = FormWindowState.Normal;  //窗体状态默认大小
            this.Activate();
        }
        private void showmain(object sender, EventArgs e)
        {
            shmain();
        }

        private void exitmain(object sender, EventArgs e)
        {
            this.Close();
        }

        private void showmain(object sender, MouseEventArgs e)
        {
            shmain();
        }

        private void formdeactive(object sender, EventArgs e)
        {
            if (this.Top == 1)
            {
                this.Location = new Point(this.Location.X, 0);
            }
        }

    }
}
