using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using mysqlconnection.myclass;

namespace mysqlconnection
{
    public partial class Form1 : Form
    {  
        connection_class con = new connection_class();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
             try
            {
                con.connectdb.Open();
                label1.Text = "You are Connected to the MySql Database!";
                label1.ForeColor = Color.Green;
                con.connectdb.Close();
            }
            catch (Exception)
            {
                label1.Text = "Failed to connect to MySql Database!";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
