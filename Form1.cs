using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1PictureBox
{
    public partial class dogPictureForm : Form
    {
        public dogPictureForm()
        {
            InitializeComponent();
        }

        private void dogPictureLabel_Click(object sender, EventArgs e)
        {

        }

        private void dogPictureForm_Load(object sender, EventArgs e)
        {

        }

        private void onePictureBox_Click(object sender, EventArgs e)
        {
            
        }

        private void pressMeOneLabel_Click(object sender, EventArgs e)
        {
            //Makes picture above visible on click
            onePictureBox.Visible = true;

            //Makes all other pictures invisible
            twoPictureBox.Visible = false;
            threePictureBox.Visible = false;
            fourPictureBox.Visible = false;
            fivePictureBox.Visible = false;

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            //Makes all pictures invisible
            onePictureBox.Visible = false;
            twoPictureBox.Visible = false;
            threePictureBox.Visible = false;
            fourPictureBox.Visible = false;
            fivePictureBox.Visible = false;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //The following will close the program
            MessageBox.Show("This will terminate the program");
            this.Close();
        }

        private void pressMeTwoLabel_Click(object sender, EventArgs e)
        {
            //Makes picture above visible on click
            twoPictureBox.Visible = true;

            // Makes all other pictures invisible
            onePictureBox.Visible = false;
            threePictureBox.Visible = false;
            fourPictureBox.Visible = false;
            fivePictureBox.Visible = false;
        }

        private void twoPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void pressMeThreeLabel_Click(object sender, EventArgs e)
        {
            //Makes picture above visible on click
            threePictureBox.Visible = true;

            // Makes all other pictures invisible
            onePictureBox.Visible = false;
            twoPictureBox.Visible = false;
            fourPictureBox.Visible = false;
            fivePictureBox.Visible = false;
        }

        private void pressMeFourLabel_Click(object sender, EventArgs e)
        {
            //Makes picture above visible on click
            fourPictureBox.Visible = true;

            // Makes all other pictures invisible
            onePictureBox.Visible = false;
            twoPictureBox.Visible = false;
            threePictureBox.Visible = false;
            fivePictureBox.Visible = false;
        }

        private void pressMeFiveLabel_Click(object sender, EventArgs e)
        {
            //Makes picture above visible on click
            fivePictureBox.Visible = true;

            // Makes all other pictures invisible
            onePictureBox.Visible = false;
            twoPictureBox.Visible = false;
            threePictureBox.Visible = false;
            fourPictureBox.Visible = false;
        }

        private void fivePictureBox_Click(object sender, EventArgs e)
        {
            
        }
    }
}
