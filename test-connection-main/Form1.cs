using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using test_connection.Models;
using test_connection.Services;
namespace test_connection
{
    public partial class Form1 : Form
    {
        private ClientServices cs = new ClientServices();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var firstName = textBox1.Text;
            var lastName = textBox2.Text;
            var client = new Client();
            client.FirstName = firstName;
            client.LastName = lastName;
            cs.AddClient(client);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var firstName = textBox3.Text;
            var client = cs.GetClient(firstName);
            cs.DeleteClient(client);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var firstName = textBox4.Text;
            var client = cs.GetClient(firstName);
            client.FirstName = textBox5.Text;
            client.LastName = textBox6.Text;
            cs.Update(client);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
