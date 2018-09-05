using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OfficeOpenXml;
using System.IO;

namespace dotn_projekt
{
    public partial class popisUcenika : Form
    {
        razrediEntities db = new razrediEntities();
        public popisUcenika()
        {
            InitializeComponent();
        }

        private void popisUcenika_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'razrediDataSet1.ucenik' table. You can move, or remove it, as needed.
            this.ucenikTableAdapter.Fill(this.razrediDataSet1.ucenik);
            // TODO: This line of code loads data into the 'razrediDataSet1.raz_odjel' table. You can move, or remove it, as needed.
            this.raz_odjelTableAdapter.Fill(this.razrediDataSet1.raz_odjel);

            var ucenici = from u in db.ucenik
                          join r in db.raz_odjel on u.raz_id equals r.id
                          select new {ime=u.ime, prezime=u.prezime, oib=u.oib, odjel=r.odjel, nastavnik=r.nastavnik };
            dataGridView1.DataSource=ucenici.ToList();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {            
                var odjelId = int.Parse(comboBox1.SelectedValue.ToString());
                var ucenici = from u in db.ucenik
                              join r in db.raz_odjel on u.raz_id equals r.id
                              where u.raz_id==odjelId
                              select new { ime = u.ime, prezime = u.prezime, oib = u.oib, odjel = r.odjel, nastavnik = r.nastavnik };
                dataGridView1.DataSource = ucenici.ToList();
        }

        private void ucenikBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var ucenici = from u in db.ucenik
                          join r in db.raz_odjel on u.raz_id equals r.id
                          select new { ime = u.ime, prezime = u.prezime, oib = u.oib, odjel = r.odjel, nastavnik = r.nastavnik };
            dataGridView1.DataSource = ucenici.ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int celija = 2;
            var rezultati = razrediDataSet1.ucenik;

            var wb = new ExcelPackage();
            var ws = wb.Workbook.Worksheets.Add("Popis učenika");
            ws.Cells[1, 1].Value = "Ime učenika";
            ws.Cells[1, 2].Value = "Prezime učenika";
            ws.Cells[1, 3].Value = "OIB učenika";         
            ws.Cells[1, 4].Value = "Odjel";
            ws.Cells[1, 5].Value = "Nastavnik";

            foreach (var rez in rezultati)
            {
                
                var odjel = db.raz_odjel.First(o => o.id == rez.raz_id);

                ws.Cells[celija, 1].Value = rez.ime;
                ws.Cells[celija, 2].Value = rez.prezime;
                ws.Cells[celija, 3].Value = rez.oib;
                ws.Cells[celija, 4].Value = odjel.odjel;
                ws.Cells[celija, 5].Value = odjel.nastavnik;
                celija++;
            }

            
            wb.SaveAs(new FileInfo(@"C:\Temp\PopisUcenika.xlsx"));
        }
    }
}
