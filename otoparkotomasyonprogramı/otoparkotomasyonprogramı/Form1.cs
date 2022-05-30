namespace otoparkotomasyonprogramı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frmaraçotoparkkaydı kayit = new Frmaraçotoparkkaydı();
            kayit.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmaraçotoparkyerleri yer= new frmaraçotoparkyerleri();
                yer.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmaraçotoparkçıkışı çıkış = new frmaraçotoparkçıkışı();
            çıkış.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
    }
}