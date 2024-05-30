using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestDemosran
{
    public partial class Reg : Form
    {
        public Reg()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            string fio = textBoxFIO.Text;
            string phone = textBoxPhone.Text;
            string login = textBoxLogin.Text;
            string password = textBoxPassword.Text;

            if (string.IsNullOrWhiteSpace(fio) || string.IsNullOrWhiteSpace(phone) ||
                string.IsNullOrWhiteSpace(login) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Все поля должны быть заполнены.");
                return;
            }

            using (var context = new Model1())
            {
                var existingUser = context.Users.FirstOrDefault(u => u.login == login);

                if (existingUser != null)
                {
                    MessageBox.Show("Этот логин уже используется.");
                    return;
                }

                Users newUser = new Users
                {
                    fio = fio,
                    phone = phone,
                    login = login,
                    password = password,
                    type = "Заказчик"
                };

                context.Users.Add(newUser);
                context.SaveChanges();

                MessageBox.Show("Аккаунт успешно создан.");

                Log logForm = new Log();
                logForm.Show();
                this.Close();
            }
        }

        private void textBoxPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxFIO_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
