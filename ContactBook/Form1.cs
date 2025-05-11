using Npgsql;
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ContactBook
{
    public partial class Form1 : Form
    {
        private string connectionString = "Host=localhost;Port=5432;Username=postgres;Password=123;Database=contactbook;";
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtName.Text) ||
                string.IsNullOrEmpty(txtEmail.Text) ||
                string.IsNullOrEmpty(txtPhone.Text)
                ) { return; }

            string name = txtName.Text;
            string phone = txtPhone.Text;
            string email = txtEmail.Text;

            //connect database
            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "INSERT INTO contacts (name, email, phone) VALUES (@name, @email, @phone)";

                    // Add parameters
                    cmd.Parameters.AddWithValue("name", name);
                    cmd.Parameters.AddWithValue("email", email);
                    cmd.Parameters.AddWithValue("phone", phone);

                    // Execute command
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("data added to DB");
                LoadContacts();
            }

        }

        //view all contacts
        private void LoadContacts()
        {
            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand("SELECT * FROM contacts", conn))
                using (var reader = cmd.ExecuteReader())
                {
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    dgvContacts.DataSource = dt;
                }
            }
        }

        //update contact
        private void UpdateContacts()
        {
            // get input data to update
            string name = txtName.Text;
            string email = txtEmail.Text;
            string phone = txtPhone.Text;
            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                //dealing only with the id to update
                if (dgvContacts.CurrentRow == null) return;

                //get id here
                int id = Convert.ToInt32(dgvContacts.CurrentRow.Cells["id"].Value);

                using (var cmd = new NpgsqlCommand("UPDATE contacts SET name = @name," +
                    "email = @email, phone = @phone WHERE id=@id", conn))
                {
                    cmd.Parameters.AddWithValue("id", id);
                    cmd.Parameters.AddWithValue("name", txtName.Text);
                    cmd.Parameters.AddWithValue("email", email);
                    cmd.Parameters.AddWithValue("phone", phone);
                    // Execute command
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("data updated to DB");
                LoadContacts(); //refreshing the the contacts
            }
        }

        private void DeleteAContact()
        {
            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                //dealing only with the id to update
                if (dgvContacts.CurrentRow == null) return;

                //get id here
                int id = Convert.ToInt32(dgvContacts.CurrentRow.Cells["id"].Value);

                using (var cmd = new NpgsqlCommand("DELETE FROM contacts where id=@id", conn))
                {
                    cmd.Parameters.AddWithValue("id", id);
                    
                    // Execute command
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Data Deleted ");
                LoadContacts(); //refreshing the the contacts
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            LoadContacts();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateContacts();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteAContact();
        }
    }
}
