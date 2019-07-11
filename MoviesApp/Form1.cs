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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }


        private void search_Click(object sender, EventArgs e)
        {
            var movies = Program.SearchByName(textBox1.Text);

            foreach (var movie in movies)
            {
                ListViewItem item = new ListViewItem();
                item.Tag = movie.imdbID;
                item.Text = movie.Title;
                listView1.Items.Add(item);


                //listBox1.Items.Add(movie.Title);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 1)
            {
                var movie = Program.GetMovieById(listView1.SelectedItems[0].Tag.ToString());

                label5.Text = movie.Title;
                label7.Text = movie.Year;

                pictureBox1.LoadAsync(@"http://img.omdbapi.com/?apikey=d15aeb59&i=" + movie.imdbID);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            //Form2 f2 = new Form2();
            //f2.ShowDialog();

            var movie = Program.GetMovieById(listView1.SelectedItems[0].Tag.ToString());

            MessageBox.Show(
                "Title: " + movie.Title + "\n" +
                "Year: " + movie.Year + "\n" +
                "imdbID: " + movie.imdbID + "\n" +
                "Type: " + movie.Type + "\n" , "More details"



       );

            
        }
    }
}

