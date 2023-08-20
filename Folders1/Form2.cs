using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Folders1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnBinaryWrite_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"D:\DP4-2-Aug\prod.dat";
                FileStream fileStream = new FileStream(path, FileMode.Create, FileAccess.Write);
                BinaryFormatter formatter = new BinaryFormatter();
                Product p1 = new Product();
                p1.Id = Convert.ToInt32(txtId.Text);
                p1.Name = txtName.Text;
                p1.Price = Convert.ToInt32(txtPrice.Text);
                formatter.Serialize(fileStream, p1);
                fileStream.Close();
                MessageBox.Show("Done");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBinaryRead_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"C:\Abcd\product.dat";
                FileStream fileStream = new FileStream(path, FileMode.Open, FileAccess.Read);
                BinaryFormatter formatter = new BinaryFormatter();
                Product p1 = new Product();
                // we done explicit type casting from Object --> Product
                p1 = (Product)formatter.Deserialize(fileStream);
                txtId.Text = p1.Id.ToString();
                txtName.Text = p1.Name;
                txtPrice.Text = p1.Price.ToString();

                fileStream.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void btnXmlWrite_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"C:\Abcd\product.xml";
                FileStream fileStream = new FileStream(path, FileMode.Create, FileAccess.Write);
                //only public members get serialized
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Product));
                Product p1 = new Product();
                p1.Id = Convert.ToInt32(txtId.Text);
                p1.Name = txtName.Text;
                p1.Price = Convert.ToInt32(txtPrice.Text);
                xmlSerializer.Serialize(fileStream, p1);
                fileStream.Close();
                MessageBox.Show("Done");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXmlRead_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"C:\Abcd\product.xml";
                FileStream fileStream = new FileStream(path, FileMode.Open, FileAccess.Read);
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Product));
                Product p1 = new Product();
                // we done explicit type casting from Object --> Product
                p1 = (Product)xmlSerializer.Deserialize(fileStream);
                txtId.Text = p1.Id.ToString();
                txtName.Text = p1.Name;
                txtPrice.Text = p1.Price.ToString();

                fileStream.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSoapWrite_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"C:\Abcd\product.soap";
                FileStream fileStream = new FileStream(path, FileMode.Create, FileAccess.Write);
                //only public members get serialized
                SoapFormatter soapFormatter = new SoapFormatter();
                Product p1 = new Product();
                p1.Id = Convert.ToInt32(txtId.Text);
                p1.Name = txtName.Text;
                p1.Price = Convert.ToInt32(txtPrice.Text);
                soapFormatter.Serialize(fileStream, p1);
                fileStream.Close();
                MessageBox.Show("Done");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSoapRead_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"C:\Abcd\product.soap";
                FileStream fileStream = new FileStream(path, FileMode.Open, FileAccess.Read);
                SoapFormatter soapFormatter = new SoapFormatter();
                Product p1 = new Product();
                // we done explicit type casting from Object --> Product
                p1 = (Product)soapFormatter.Deserialize(fileStream);
                txtId.Text = p1.Id.ToString();
                txtName.Text = p1.Name;
                txtPrice.Text = p1.Price.ToString();

                fileStream.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void btnJsonWrite_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"C:\Abcd\product.json";
                FileStream fileStream = new FileStream(path, FileMode.Create, FileAccess.Write);
                Product p1 = new Product();
                p1.Id = Convert.ToInt32(txtId.Text);
                p1.Name = txtName.Text;
                p1.Price = Convert.ToInt32(txtPrice.Text);
                JsonSerializer.Serialize<Product>(fileStream, p1);
                fileStream.Close();
                MessageBox.Show("Done");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnJsonRead_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"C:\Abcd\product.json";
                FileStream fileStream = new FileStream(path, FileMode.Open, FileAccess.Read);
                Product p1 = new Product();
                p1 = JsonSerializer.Deserialize<Product>(fileStream);
                txtId.Text = p1.Id.ToString();
                txtName.Text = p1.Name;
                txtPrice.Text = p1.Price.ToString();

                fileStream.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
