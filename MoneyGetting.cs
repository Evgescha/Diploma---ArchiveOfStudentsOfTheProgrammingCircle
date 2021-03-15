using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArchiveOfStudentsOfTheProgrammingCircle
{
    public partial class MoneyGetting : Form
    {
        public MoneyGetting()
        {
            InitializeComponent();
        }

        private void MoneyGetting_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "archiveOfStudentsOfTheProgrammingCircleDataSet.учащийся". При необходимости она может быть перемещена или удалена.
            this.учащийсяTableAdapter.Fill(this.archiveOfStudentsOfTheProgrammingCircleDataSet.учащийся);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "archiveOfStudentsOfTheProgrammingCircleDataSet.вклад_в_развитие". При необходимости она может быть перемещена или удалена.
            this.вклад_в_развитиеTableAdapter.Fill(this.archiveOfStudentsOfTheProgrammingCircleDataSet.вклад_в_развитие);

        }

        private void toolStripButton13_Click(object sender, EventArgs e)
        {
            // включаем код в обработчик ошибок
            try
            {
                // опреледяем данные таблицы как законченные редактироваться и говотвые к обновлению
                вкладВРазвитиеBindingSource.EndEdit();
                // обновляем данные в бд
                this.вклад_в_развитиеTableAdapter.Update(archiveOfStudentsOfTheProgrammingCircleDataSet);
                // выводим окно, что все орошо обновилось
                MessageBox.Show("Сохранено");
            }
            // на случай если пойдет какая-то ошибка, по типу удаления данных, которые используются в другой таблице
            catch (Exception ex)
            {
                // выводим окно с этой ошибкой, чтобы мы могли посмотреть с какой таблицей или местом это связано
                MessageBox.Show(ex.Message);
            }
            // вне зависимости от того, обновили даныне или нет, обновляем данные в текущей таблице, чтобы они всегда оставались актуальными
            this.вклад_в_развитиеTableAdapter.Fill(archiveOfStudentsOfTheProgrammingCircleDataSet.вклад_в_развитие);

        }

        private void MoneyGetting_FormClosing(object sender, FormClosingEventArgs e)
        {
            Main.main.Show();
        }
    }
}
