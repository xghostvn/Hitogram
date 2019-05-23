using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        Bitmap bitmap;
         public static Bitmap h;
        public Form1()
        {
            InitializeComponent();
        }

  

   

       
 

        private void OpenImage(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            if (f.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                
                bitmap = new Bitmap(f.FileName);
                pictureBox1.Image = bitmap;
               h = MyHistogram.CreateHistogram(bitmap, false);

                String file_path = f.FileName;
                file_path = file_path.Substring(file_path.LastIndexOf("\\"));
              String  image_name = file_path.Remove(0, 1);
                file_name.Text = image_name;

                height.Text = bitmap.Height.ToString();
                width.Text = bitmap.Width.ToString();

                FileInfo fileInfo = new FileInfo(f.FileName);
                size.Text = fileInfo.Length.ToString();
               
               
               
            }
        }

        private void OpenHistogram(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
