using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dotn_projekt
{
    public partial class Form1 : Form
    {
        razrediEntities db = new razrediEntities();
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var popisOdjela = new razredi();
            popisOdjela.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'razrediDataSet.raz_odjel' table. You can move, or remove it, as needed.
            this.raz_odjelTableAdapter.Fill(this.razrediDataSet.raz_odjel);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (db.ucenik.Any(u => u.oib == textBox3.Text))
            {
                label6.Text = @"Učenik s navedenim OIB-om već postoji!";
            }
            else
            {
                db.ucenik.Add(new ucenik()
                {
                    ime = textBox1.Text,
                    prezime = textBox2.Text,
                    oib = textBox3.Text,
                    raz_id = int.Parse(comboBox1.SelectedValue.ToString())
                });
                db.SaveChanges();

                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var popisUcenika = new popisUcenika();
            popisUcenika.Show();
        }
    }
}
