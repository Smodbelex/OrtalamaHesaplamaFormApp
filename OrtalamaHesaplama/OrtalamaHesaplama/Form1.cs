namespace OrtalamaHesaplama
{
    public partial class Form1 : Form
    {
        public Form1()

        {
            InitializeComponent();
        }
        private void btnHesapla_Click(object sender, EventArgs e)
        {
            int Sinav1 = 0, Sinav2 = 0, Sinav3 = 0, Sonuc = 0;

            if (txtSinav1.Text.Length > 0)
                int.TryParse(txtSinav1.Text.ToString(), out Sinav1);
            if (txtSinav2.Text.Length > 0)
                int.TryParse(txtSinav2.Text.ToString(), out Sinav2);
            if (txtSinav3.Text.Length > 0)
                int.TryParse(txtSinav3.Text.ToString(), out Sinav3);

            if (Sinav1 > 0 && Sinav2 > 0 && Sinav3 > 0)
            {
                Sonuc = (Sinav1 + Sinav2 + Sinav3) / 3;
                label5.Text = Sonuc.ToString();
            }
            else
                MessageBox.Show("Deðer Eksik Girildi");
        }
    }
}