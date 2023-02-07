using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordHasher
{
    public partial class Hasher : Form
    {
        public Hasher()
        {
            InitializeComponent();
            hashedPassword.ReadOnly = true;
        }

        public static string HashPassword(string password)
        {
            SHA1CryptoServiceProvider sha1 = new SHA1CryptoServiceProvider();

            byte[] passwod_bytes = Encoding.ASCII.GetBytes(password);
            byte[] encrypted_bytes = sha1.ComputeHash(passwod_bytes);

            return Convert.ToBase64String(encrypted_bytes);
        }

        private void copyPassword_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(hashedPassword.Text.Trim());
            copyStatus.Text = "Copied to clipboard!";
        }

        private void hash_Click(object sender, EventArgs e)
        {
            string password = originalPassword.Text.Trim();

            string hashed = HashPassword(password);

            //Show hashed password in textbox
            copyStatus.Text = "-";
            hashedPassword.Text = hashed;
            copyPassword.Enabled = true;

        }
    }
}
