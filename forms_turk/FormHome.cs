using forms_turk.Context;
using forms_turk.Models;
using forms_turk.Queries;
using Microsoft.EntityFrameworkCore;

namespace forms_turk
{
    public partial class FormHome : Form
    {

        private readonly AppDbContext _context;

        int index;

        public FormHome()
        {
            InitializeComponent();


            _context = new AppDbContext();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (index == 3)
            {
                try
                {
                    listBox1.Items.Clear();
                    foreach (var item in await GetPersonelListAsync())
                    {

                        listBox1.Items.Add(item.Ad + " " + item.Soyad + " " + item.TelNo);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString
                        ());
                }
            }
            if (index == 1)
            {
                try
                {
                    listBox1.Items.Clear();
                    foreach (var item in await GetSehirsAsync())
                    {
                        listBox1.Items.Add(item.SehirAdi + " " + item.Id);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString
                        ());
                }
            }
        }


        public async Task AddPersonel()
        {
            var newPersonel = new Personel { Ad = txtBoxEAd.Text, Soyad = txtBoxESoyad.Text, TelNo = txtBoxENumara.Text };
            _context.Add(newPersonel);
            await _context.SaveChangesAsync();

        }




        public async Task<List<Personel>> GetPersonelListAsync()
        {
            using (var context = new AppDbContext())
            {
                var list = await context.Personel.ToListAsync();
                return list;
            }
        }

        public async Task<List<Sehir>> GetSehirsAsync()
        {
            using (var context = new AppDbContext())
            {
                var list = await context.Sehir.ToListAsync();
                return list;
            }
        }



        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {


        }
        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnUrunEkle_Click(object sender, EventArgs e)
        {

        }

        private void btnStockAdd_Click(object sender, EventArgs e)
        {
            panelStock.BringToFront();
            index = 5;
        }

        private void btnBackAdress1_Click(object sender, EventArgs e)
        {
            panelMenu.BringToFront();
        }

        private void btnBackStock1_Click(object sender, EventArgs e)
        {
            panelMenu.BringToFront();
        }

        private void txtBoxUrun_TextChanged(object sender, EventArgs e)
        {

        }

        private async void button4_Click(object sender, EventArgs e)
        {
            await AddPersonel();
        }

        private void btnEmployeeAdd_Click(object sender, EventArgs e)
        {
            panelEmployee.BringToFront();
            index = 3;
        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

