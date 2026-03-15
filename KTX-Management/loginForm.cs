namespace KTX_Management
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }

        private void signUpLinkLb_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            registerForm registerForm = new registerForm();
            registerForm.ShowDialog();
        }

        private void LoginAccountNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void LoginTitleLabel_Click(object sender, EventArgs e)
        {

        }

        private void LoginTopPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
