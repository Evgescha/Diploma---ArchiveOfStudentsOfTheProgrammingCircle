﻿using System;
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
    public partial class Report1 : Form
    {
        public Report1()
        {
            InitializeComponent();
        }

        private void Report1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ArchiveOfStudentsOfTheProgrammingCircleDataSet.SchoolerThemeTable". При необходимости она может быть перемещена или удалена.
            this.SchoolerThemeTableTableAdapter.Fill(this.ArchiveOfStudentsOfTheProgrammingCircleDataSet.SchoolerThemeTable);
            this.reportViewer1.RefreshReport();
        }
    }
}
