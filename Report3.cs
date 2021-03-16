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
    public partial class Report3 : Form
    {
        public Report3()
        {
            InitializeComponent();
        }

        private void Report3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ArchiveOfStudentsOfTheProgrammingCircleDataSet.CompetentionsSchooler". При необходимости она может быть перемещена или удалена.
            this.CompetentionsSchoolerTableAdapter.Fill(this.ArchiveOfStudentsOfTheProgrammingCircleDataSet.CompetentionsSchooler);

            this.reportViewer1.RefreshReport();
        }
    }
}
