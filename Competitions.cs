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
    public partial class Competitions : Form
    {
        public Competitions()
        {
            InitializeComponent();
        }

        private void Competitions_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "archiveOfStudentsOfTheProgrammingCircleDataSet.учащийся". При необходимости она может быть перемещена или удалена.
            this.учащийсяTableAdapter.Fill(this.archiveOfStudentsOfTheProgrammingCircleDataSet.учащийся);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "archiveOfStudentsOfTheProgrammingCircleDataSet.участники_сорвевнований". При необходимости она может быть перемещена или удалена.
            this.участники_сорвевнованийTableAdapter.Fill(this.archiveOfStudentsOfTheProgrammingCircleDataSet.участники_сорвевнований);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "archiveOfStudentsOfTheProgrammingCircleDataSet.соревнование". При необходимости она может быть перемещена или удалена.
            this.соревнованиеTableAdapter.Fill(this.archiveOfStudentsOfTheProgrammingCircleDataSet.соревнование);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "archiveOfStudentsOfTheProgrammingCircleDataSet.виды_соревнований". При необходимости она может быть перемещена или удалена.
            this.виды_соревнованийTableAdapter.Fill(this.archiveOfStudentsOfTheProgrammingCircleDataSet.виды_соревнований);

        }

        private void toolStripButton13_Click(object sender, EventArgs e)
        {
            // включаем код в обработчик ошибок
            try
            {
                // опреледяем данные таблицы как законченные редактироваться и говотвые к обновлению
                видыСоревнованийBindingSource.EndEdit();
                // обновляем данные в бд
                this.виды_соревнованийTableAdapter.Update(archiveOfStudentsOfTheProgrammingCircleDataSet);
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
            this.виды_соревнованийTableAdapter.Fill(archiveOfStudentsOfTheProgrammingCircleDataSet.виды_соревнований);

        }

        private void toolStripButton14_Click(object sender, EventArgs e)
        {
            // включаем код в обработчик ошибок
            try
            {
                // опреледяем данные таблицы как законченные редактироваться и говотвые к обновлению
                соревнованиеibfk1BindingSource.EndEdit();
                // обновляем данные в бд
                this.соревнованиеTableAdapter.Update(archiveOfStudentsOfTheProgrammingCircleDataSet);
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
            this.соревнованиеTableAdapter.Fill(archiveOfStudentsOfTheProgrammingCircleDataSet.соревнование);

        }

        private void toolStripButton15_Click(object sender, EventArgs e)
        {
            // включаем код в обработчик ошибок
            try
            {
                // опреледяем данные таблицы как законченные редактироваться и говотвые к обновлению
                участникиСорвевнованийibfk1BindingSource.EndEdit();
                // обновляем данные в бд
                this.участники_сорвевнованийTableAdapter.Update(archiveOfStudentsOfTheProgrammingCircleDataSet);
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
            this.участники_сорвевнованийTableAdapter.Fill(archiveOfStudentsOfTheProgrammingCircleDataSet.участники_сорвевнований);

        }

        private void dataGridView3_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void Competitions_FormClosing(object sender, FormClosingEventArgs e)
        {
            Main.main.Show();
        }
    }
}
