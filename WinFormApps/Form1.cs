namespace WinFormApps
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            RefreshForm();
        }

        //refresh the form
        public void RefreshForm()
        {
            GetName();
        }

        public void GetName()
        {
            if (string.IsNullOrEmpty(txtName.Text))
                return;

            txtName.Text = "";
        }
        public void GetEmail()
        {
            if (string.IsNullOrEmpty(txtEmail.Text))
                return;
            txtEmail.Text = "";
        }

        public void GetPhone() 
        {
            if (string.IsNullOrEmpty(txtPhone.Text))
                return;
            txtPhone.Text = "";
        }
    }
}
