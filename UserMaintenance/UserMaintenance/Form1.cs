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

                for (int i = 0; i < listBox1.Items.Count; i++)
                {
                    writer.WriteLine(listBox1.Items[i]);
                }
               
                writer.Close();

                //for (int i = 0; i < listBox1; i++)
                //{

                //}
                    
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
           // listBox1.Items.RemoveAt(listBox1.SelectedIndex);
        }
    }
}
