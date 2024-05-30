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
    public partial class ManagerForm : Form
    {
        public ManagerForm()
        {
            InitializeComponent();
        }

        private void ManagerForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testDemoDataSet.Requests". При необходимости она может быть перемещена или удалена.
            this.requestsTableAdapter.Fill(this.testDemoDataSet.Requests);
            // Отображаем статистику
           // DisplayStatistics();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            FilterRequests();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FilterRequests()
        {
            if (int.TryParse(textBox1.Text, out int requestId))
            {
                requestsBindingSource.Filter = $"requestID = {requestId}";
            }
            else
            {
                requestsBindingSource.RemoveFilter();
            }
        }

        private void buttonSaveDate_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.requestsBindingSource.EndEdit();
            this.requestsTableAdapter.Update(this.testDemoDataSet.Requests);
            // Обновляем статистику
          //  DisplayStatistics();
        }

        private void labelCountReq_Click(object sender, EventArgs e)
        {

        }

        private void labelAvgDate_Click(object sender, EventArgs e)
        {

        }
       // private void DisplayStatistics()
       // {
           
                // Количество выполненных заявок
            //    int completedRequestsCount = testDemoDataSet.Requests
             //       .Count(r => r.requestStatus != null && r.requestStatus == "Completed");

                // Среднее время выполнения заявки
              //  double? averageCompletionDays = testDemoDataSet.Requests
               //     .Where(r => r.completionDate != null && r.startDate != null && r.requestStatus == "Completed")
                  //  .Average(r => (r.completionDate - r.startDate)?.TotalDays);

                // Отображаем информацию на метках
           //     labelCountReq.Text = $"Количество выполненных заявок: {completedRequestsCount}";
              //  labelAvgDate.Text = $"Среднее время выполнения заявки: {(averageCompletionDays.HasValue ? averageCompletionDays.Value.ToString() : "Нет данных")} дней";
            

     //  }


    }
}
