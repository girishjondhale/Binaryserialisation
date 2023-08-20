using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Folders1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncreatefolder_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"C:\Abcd";
                if (Directory.Exists(path))
                {
                    MessageBox.Show("folder exists");
                }
                else 
                {
                    Directory.CreateDirectory(path);
                    MessageBox.Show("folder created");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void btncreatefile_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"C:\Abc.txt";
                if (File.Exists(path))
                {
                    MessageBox.Show("file exists");
                }
                else
                {
                    File.Create(path);
                    MessageBox.Show("file created");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void btnwrite_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"C:\Abcd\product.dat";

                FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write);
                BinaryWriter bw = new BinaryWriter(fs);
                bw.Write(Convert.ToInt32(txtid.Text));
                bw.Write(txtname.Text);
                bw.Write(Convert.ToDouble(txtprice.Text));
                bw.Close(); 
                fs.Close();
                MessageBox.Show("Done");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }

        private void btnread_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"C:\Abcd\product.dat";

                FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                txtid.Text = br.ReadInt32().ToString();
                txtname.Text = br.ReadString().ToString();
                txtprice.Text = br.ReadDouble().ToString();
                br.Close();
                fs.Close();
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
