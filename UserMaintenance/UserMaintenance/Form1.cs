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
            label1.Text = "Név";
            button1.Text = Resource1.Add;

            listBox1.DataSource = users;
            listBox1.ValueMember = "ID";
            listBox1.DisplayMember = "FullName";

            button2.Text = Resource1.Write;
            button3.Text = Resource1.Delete;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var u = new User();
            u.fullName = textBox1.Text;
            users.Add(u);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            //Opcionális rész
            sfd.InitialDirectory = Application.StartupPath;
            sfd.Filter = "Comma Seperated Values (*.csv)|*.csv";
            sfd.DefaultExt = "csv";
            sfd.AddExtension = true;

            if (sfd.ShowDialog() != DialogResult.OK) return;
            using (StreamWriter sw = new StreamWriter(sfd.FileName, false, Encoding.UTF8))
            {
                // Végigmegyünk a hallgató lista elemein
                foreach (var s in users)
                {
                    sw.Write(s.ID);
                    sw.Write(";");
                    sw.Write(s.fullName);
                    sw.Write(";");
                    sw.WriteLine();
                }
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            users.Clear();
        }
    }
}
