using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoviesApp
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();


        }


        private Form1 mainForm = null;
        public Form2(Form callingForm)
        {
            mainForm = callingForm as Form1;
            InitializeComponent();
        }



        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var movie = Program.GetMovieById(listView1.SelectedItems[0].Tag.ToString());

            label1.Text = movie.Title;
            label2.Text = movie.Year;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
