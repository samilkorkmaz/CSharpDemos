using System;
using System.Drawing;
using System.Windows.Forms;

namespace TransparentDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            pbFront.BackColor = Color.Transparent;
            pbFront.Parent = pbBack;
            pbFront.Location = new Point(0,0); //this is relative to parent, i.e. pbBack!
        }

        private void cbHightlight_CheckedChanged(object sender, EventArgs e)
        {
            if (cbHightlight.Checked)
            {
                pbFront.Parent = pbBack;
                pbFront.Location = new Point(0, 0);
            }
            else
            {
                pbFront.Parent = this; //if you don't make the parent this form, pbFront will be invisible when pbBack becomes invisible.
                pbFront.Location = pbBack.Location;
            }
            pbBack.Visible = cbHightlight.Checked;
        }
    }
}
