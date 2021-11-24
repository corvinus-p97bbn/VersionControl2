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
using UserMaintenance.Entities;

namespace UserMaintenance
{
    public partial class Form1 : Form
    {
        BindingList<User> users = new BindingList<User>();

        public Form1()
        {
            InitializeComponent();
            label1.Text = Resource1.FullName;
            button1.Text = Resource1.Add;
            button2.Text = Resource1.Write;
            button3.Text=Resource1.Delete;
            listBox1.DataSource = users;
            listBox1.ValueMember = "ID";
            listBox1.DisplayMember = "FullName";

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var u = new User()
            {
               FullName = textBox1.Text,
            };
            users.Add(u);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog writefile = new SaveFileDialog();

            if (writefile.ShowDialog() == DialogResult.OK)
            { 
                StreamWriter writer = new StreamWriter(writefile.FileName);
                
                MessageBox.Show(writefile.FileName);
                foreach (var user in users)
                {
                    writer.WriteLine("ID: " + user.ID.ToString() + "; Name: " + user.FullName);
                }
                writer.Close();
                

                    
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            users.Clear();
        }
    }
}
