using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComplexPasswordGen
{
    public partial class Form1 : Form
    {



        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            password.Enabled = false;
        }

        private void bunifuCustomLabel2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }

        private void GenBtn_Click(object sender, EventArgs e)
        {
            string allowedChars = "";
            allowedChars = "a,b,c,d,e,f,g,h,i,j,k,l,m,n,o,p,q,r,s,t,u,v,w,x,y,z,";
            allowedChars += "A,B,C,D,E,F,G,H,I,J,K,L,M,N,O,P,Q,R,S,T,U,V,W,X,Y,Z,";
            allowedChars += "1,2,3,4,5,6,7,8,9,0,!,@,#,$,%,&,?";

            char[] sep = { ',' };

            string[] arr = allowedChars.Split(sep);

            string passwordString = "";

            string temp = "";

            Random rand = new Random();

            for (int i = 0; i < Convert.ToInt32(lengthvalue.Text); i++)
            {
                temp = arr[rand.Next(0, arr.Length)];
                passwordString += temp;
            }
            password.Text = passwordString;
        }

        private void CopyPassword_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(password.Text);
            MessageBox.Show("Passowrd copied to clipboard");
        }

        int mouseX = 0, mouseY = 0;
        bool mouseDown;

        private void panel4_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
        }

        private void panel4_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void bunifuTrackbar1_ValueChanged(object sender, EventArgs e)
        {
            lengthvalue.Text = "" + bunifuTrackbar1.Value;
        }

        private void panel4_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                mouseX = MousePosition.X - 100;
                mouseY = MousePosition.Y - 10;

                this.SetDesktopLocation(mouseX, mouseY);
            }
        }
    }
}
