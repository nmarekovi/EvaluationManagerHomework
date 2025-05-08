namespace Evaluation_Manager
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        string username = "nastavnik";
        string passowrd = "test";
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                MessageBox.Show("Korisnicko ime nije uneseno!", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtPassword.Text == "")
            {
                MessageBox.Show("Password nije unesen!", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (txtUsername.Text == username && txtPassword.Text == passowrd)
                {
                    MessageBox.Show("Dobrodosli!", "Prijavljeni ste", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Krivi podaci!", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
