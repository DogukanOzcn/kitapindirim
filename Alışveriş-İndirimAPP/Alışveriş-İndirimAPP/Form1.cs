namespace Alışveriş_İndirimAPP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int kitapadet;
            double fiyat, toplam;
            kitapadet = Convert.ToInt16(textBox1.Text);
            if (kitapadet >= 0 && kitapadet <= 20) 
            {
                toplam = (kitapadet * 8) - (kitapadet * 8 * 0.20);
                label3.Text = toplam + " TL";
                label4.Text = "Tebrikler %20 indirim kazandınız.";

            }
            if (kitapadet >=21 && kitapadet <=40)
            {
                toplam = (kitapadet * 8) - (kitapadet * 8 * 0.20);
                label3.Text = toplam + " TL";
                label4.Text = "Tebrikler %40 indirim kazandınız.";
            }
            if (kitapadet>=41)
            {
                toplam = (kitapadet * 8) - (kitapadet * 8 * 0.50);
                label3.Text = toplam + " TL";
                label4.Text = "Tebrikler %50 indirim kazandınız.";

            }
        }
    }
}