using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
namespace WindowsFormsApp1
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

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.Dispose();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics; Bitmap bmp = new Bitmap("C:\\Capture.PNG");
            this.SetClientSizeCore(bmp.Width, bmp.Height);
            Rectangle destRect = new Rectangle(0, 0, bmp.Width, bmp.Height);
            Brush myBrush = new SolidBrush(Color.Coral); g.DrawImage(bmp, destRect);
            g.DrawString("Hello World",// String 
          
            new Font("Verdana", 30, FontStyle.Bold), // Font, size, style 
            myBrush,

             0, // x position to display font            
             0);   // y position to display font g.Dispose();






        }
    }
    }

