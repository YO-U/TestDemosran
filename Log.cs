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
    public partial class Log : Form
    {
        public Log()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string login = textBoxLogin.Text;
            string password = textBoxPassword.Text;

            using (var context = new Model1())
            {
                var user = context.Users.FirstOrDefault(u => u.login == login && u.password == password);

                if (user != null)
                {
                    switch (user.type)
                    {
                        case "Менеджер":
                            ManagerForm managerForm = new ManagerForm();
                            managerForm.Show();
                            break;
                        case "Мастер":
                            MasterForm masterForm = new MasterForm();
                            masterForm.Show();
                            break;
                        case "Оператор":
                            OperatorForm operatorForm = new OperatorForm();
                            operatorForm.Show();
                            break;
                        case "Заказчик":
                            CustomerForm customerForm = new CustomerForm();
                            customerForm.Show();
                            break;
                        default:
                            MessageBox.Show("Неизвестный тип пользователя.");
                            break;
                    }
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Неверный логин или пароль.");
                }
            }
        }
        private void textBoxLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }
    } 
}
