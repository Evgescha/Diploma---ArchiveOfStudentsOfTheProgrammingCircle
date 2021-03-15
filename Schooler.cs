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
            // TODO: данная строка кода позволяет загрузить данные в таблицу "archiveOfStudentsOfTheProgrammingCircleDataSet.вклад_в_развитие". При необходимости она может быть перемещена или удалена.
            this.вклад_в_развитиеTableAdapter.Fill(this.archiveOfStudentsOfTheProgrammingCircleDataSet.вклад_в_развитие);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "archiveOfStudentsOfTheProgrammingCircleDataSet.учащийся". При необходимости она может быть перемещена или удалена.
            this.учащийсяTableAdapter.Fill(this.archiveOfStudentsOfTheProgrammingCircleDataSet.учащийся);

        }
    }
}
