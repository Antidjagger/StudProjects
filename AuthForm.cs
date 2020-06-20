using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace AISFonotekaFrameWork
{
    public partial class AuthForm : Form
    {
        private string Login;
        private string Password;
        private string salt;
        private int Role;
        public AuthForm()
        {
            InitializeComponent();
            Login = "";
            Password = "";
            salt = "AIS";
            lblCheck.Visible = false;
            Role = 0;
            this.btnAuth.Focus();
        }

        string GetMd5Hash(MD5 md5Hash, string input)
        {

            // Convert the input string to a byte array and compute the hash.
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Create a new Stringbuilder to collect the bytes
            // and create a string.
            StringBuilder sBuilder = new StringBuilder();

            // Loop through each byte of the hashed data
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            // Return the hexadecimal string.
            return sBuilder.ToString();
        }

        // Verify a hash against a string.
        bool VerifyMd5Hash(MD5 md5Hash, string input, string hash)
        {
            // Hash the input.
            string hashOfInput = GetMd5Hash(md5Hash, input);

            // Create a StringComparer an compare the hashes.
            StringComparer comparer = StringComparer.OrdinalIgnoreCase;

            if (0 == comparer.Compare(hashOfInput, hash))
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        private void btnAuth_Click(object sender, EventArgs e)
        {
            lblCheck.Visible = false;
            Login = tbLogin.Text;
            Password = tbPassword.Text;
            string source = Password;
            this.usersTableAdapter.Fill(this.UsersDataSet.Users);
            this.logJournalTableAdapter.Fill(this.aisFonotekaTablesDataSetlog.LogJournal);
           
                
            string SaltedLogin = Login + salt;
            string SaltedPassword = salt + Login;
            string DBLogin;
            string DBPassword;
            bool check = false;

            using (MD5 md5Hash = MD5.Create())
            {
                string hash = GetMd5Hash(md5Hash, SaltedLogin);
                string passhash = GetMd5Hash(md5Hash, SaltedPassword);
                Console.WriteLine("The MD5 hash of " + Login + " is: " + hash + ".");
                Console.WriteLine("The MD5 hash of " + Password + " is: " + passhash + ".");

                Console.WriteLine("Verifying the hash...");

                check = false;
                for (int i = 0; i < UsersDataSet.Users.Count(); i++)
                {
                    DBLogin = UsersDataSet.Users[i].Username;
                    if /*(VerifyMd5Hash(md5Hash, DBLogin, hash))*/(hash == DBLogin)
                    {
                        Console.WriteLine("Username success");
                        DBPassword = UsersDataSet.Users[i].Password;
                        if /*(VerifyMd5Hash(md5Hash, DBPassword, passhash))*/ (DBPassword == passhash)
                        {
                            check = true;
                            Console.WriteLine("Password Success");
                            logJournalTableAdapter.InsertQuery3("Успешный вход в систему пользоваетелем "+Login);
                            
                            Role = UsersDataSet.Users[i].Role;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Password deny");
                            logJournalTableAdapter.InsertQuery3("Попытка входа в систему пользоваетелем " + Login + " Неверный пароль");
                            check = false;
                            break;
                        }
                    }

                }

                if (check)
                {
                    MainForm mainForm = new MainForm(Role);
                    mainForm.Show();
                    this.Hide();
                    this.Enabled = false;
                    Console.WriteLine("Auth success");
                    
                }
                else
                {
                    Console.WriteLine("Auth fail");
                    lblCheck.Visible = true;
                    logJournalTableAdapter.InsertQuery3("Попытка входа в систему пользоваетелем " + Login + " Нет такого пользователя!");
                }

            }
           
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
