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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "archiveOfStudentsOfTheProgrammingCircleDataSet.учащийся". При необходимости она может быть перемещена или удалена.
            this.учащийсяTableAdapter.Fill(this.archiveOfStudentsOfTheProgrammingCircleDataSet.учащийся);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "archiveOfStudentsOfTheProgrammingCircleDataSet.журнал_оценок". При необходимости она может быть перемещена или удалена.
            this.журнал_оценокTableAdapter.Fill(this.archiveOfStudentsOfTheProgrammingCircleDataSet.журнал_оценок);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "archiveOfStudentsOfTheProgrammingCircleDataSet.темы". При необходимости она может быть перемещена или удалена.
            this.темыTableAdapter.Fill(this.archiveOfStudentsOfTheProgrammingCircleDataSet.темы);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "archiveOfStudentsOfTheProgrammingCircleDataSet.журнал_оценок". При необходимости она может быть перемещена или удалена.
            this.журнал_оценокTableAdapter.Fill(this.archiveOfStudentsOfTheProgrammingCircleDataSet.журнал_оценок);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "archiveOfStudentsOfTheProgrammingCircleDataSet.темы". При необходимости она может быть перемещена или удалена.
            this.темыTableAdapter.Fill(this.archiveOfStudentsOfTheProgrammingCircleDataSet.темы);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "archiveOfStudentsOfTheProgrammingCircleDataSet.журнал_оценок". При необходимости она может быть перемещена или удалена.
            this.журнал_оценокTableAdapter.Fill(this.archiveOfStudentsOfTheProgrammingCircleDataSet.журнал_оценок);

        }

        private void dataGridView2_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            // включаем код в обработчик ошибок
            try
            {
                // опреледяем данные таблицы как законченные редактироваться и говотвые к обновлению
                темыBindingSource.EndEdit();
                // обновляем данные в бд
                this.темыTableAdapter.Update(archiveOfStudentsOfTheProgrammingCircleDataSet);
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
            this.темыTableAdapter.Fill(archiveOfStudentsOfTheProgrammingCircleDataSet.темы);
        }

        private void toolStripLabel3_Click(object sender, EventArgs e)
        {
            // включаем код в обработчик ошибок
            try
            {
                // опреледяем данные таблицы как законченные редактироваться и говотвые к обновлению
                журналОценокibfk2BindingSource.EndEdit();
                // обновляем данные в бд
                this.журнал_оценокTableAdapter.Update(archiveOfStudentsOfTheProgrammingCircleDataSet);
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
            this.журнал_оценокTableAdapter.Fill(archiveOfStudentsOfTheProgrammingCircleDataSet.журнал_оценок);
        }
    }
}
