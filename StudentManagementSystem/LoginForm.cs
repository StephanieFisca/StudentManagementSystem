using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace StudentManagementSystem
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            //Adding the image into the pictureBox by specifying file location
            pictureBox1.Image = Image.FromFile("../../../images/usericon.png");
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            StephDatabase stephDatabase = new StephDatabase();
            
            //MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter();
            DataTable dt = new DataTable();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM users WHERE username = @usn AND password= @pass", stephDatabase.GetConnection);
        
            cmd.Parameters.Add("@usn",MySqlDbType.VarChar).Value = textBoxUsername.Text;
            cmd.Parameters.Add("@pass",MySqlDbType.VarChar).Value = textBoxPassword.Text;
            MySqlDataAdapter mySqlDataAdapter = new MySql.Data.MySqlClient.MySqlDataAdapter(cmd);

            mySqlDataAdapter.Fill(dt);
            
            if (dt.Rows.Count > 0)
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Invalid Username Or Password","Login Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
