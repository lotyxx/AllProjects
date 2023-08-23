using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void displayImage_Click(object sender, EventArgs e)
        {
            // open file dialog   
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Fotka JPG (*.jpg)|*.jpg|Fotka PNG (*.png)|*.png|Fotka BMP (*.bmp)|*.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box  
                displayImageInWindow.Image = new Bitmap(open.FileName); 
                // image file path  
                displayImage.Text = open.FileName;
            }
        }
    }
}
