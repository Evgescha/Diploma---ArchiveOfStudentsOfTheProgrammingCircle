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
    public partial class Schooler : Form
    {
        public Schooler()
        {
            InitializeComponent();
        }

        private void Schooler_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "archiveOfStudentsOfTheProgrammingCircleDataSet.соревнование". При необходимости она может быть перемещена или удалена.
            this.соревнованиеTableAdapter.Fill(this.archiveOfStudentsOfTheProgrammingCircleDataSet.соревнование);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "archiveOfStudentsOfTheProgrammingCircleDataSet.участники_сорвевнований". При необходимости она может быть перемещена или удалена.
            this.участники_сорвевнованийTableAdapter.Fill(this.archiveOfStudentsOfTheProgrammingCircleDataSet.участники_сорвевнований);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "archiveOfStudentsOfTheProgrammingCircleDataSet.вклад_в_развитие". При необходимости она может быть перемещена или удалена.
            this.вклад_в_развитиеTableAdapter.Fill(this.archiveOfStudentsOfTheProgrammingCircleDataSet.вклад_в_развитие);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "archiveOfStudentsOfTheProgrammingCircleDataSet.учащийся". При необходимости она может быть перемещена или удалена.
            this.учащийсяTableAdapter.Fill(this.archiveOfStudentsOfTheProgrammingCircleDataSet.учащийся);

        }

        private void toolStripButton13_Click(object sender, EventArgs e)
        {
            // включаем код в обработчик ошибок
            try
            {
                // опреледяем данные таблицы как законченные редактироваться и говотвые к обновлению
                учащийсяBindingSource.EndEdit();
                // обновляем данные в бд
                this.учащийсяTableAdapter.Update(archiveOfStudentsOfTheProgrammingCircleDataSet);
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
            this.учащийсяTableAdapter.Fill(archiveOfStudentsOfTheProgrammingCircleDataSet.учащийся);

        }

        private void toolStripButton14_Click(object sender, EventArgs e)
        {
            try
            {
                // опреледяем данные таблицы как законченные редактироваться и говотвые к обновлению
                вкладВРазвитиеibfk1BindingSource.EndEdit();
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

        private void dataGridView3_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }
    }
}
