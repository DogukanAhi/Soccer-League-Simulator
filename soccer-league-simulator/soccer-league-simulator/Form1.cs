namespace fff
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox2.PasswordChar = '*';

        }
        private void button1_Click(object sender, EventArgs e)
        {
              
            if(textBox1.Text=="admin"&& textBox2.Text == "admin123")
            {
                MessageBox.Show("Giris Basarili!");
                Form2 yeni = new Form2();
                yeni.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatali Giriþ");
                textBox1.Clear();
                textBox2.Clear();
            }
           


        }
    }
}