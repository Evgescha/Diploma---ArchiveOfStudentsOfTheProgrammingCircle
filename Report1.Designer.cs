
namespace ArchiveOfStudentsOfTheProgrammingCircle
{
    partial class Report1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ArchiveOfStudentsOfTheProgrammingCircleDataSet = new ArchiveOfStudentsOfTheProgrammingCircle.ArchiveOfStudentsOfTheProgrammingCircleDataSet();
            this.журнал_оценокBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.журнал_оценокTableAdapter = new ArchiveOfStudentsOfTheProgrammingCircle.ArchiveOfStudentsOfTheProgrammingCircleDataSetTableAdapters.журнал_оценокTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ArchiveOfStudentsOfTheProgrammingCircleDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.журнал_оценокBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.журнал_оценокBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ArchiveOfStudentsOfTheProgrammingCircle.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // ArchiveOfStudentsOfTheProgrammingCircleDataSet
            // 
            this.ArchiveOfStudentsOfTheProgrammingCircleDataSet.DataSetName = "ArchiveOfStudentsOfTheProgrammingCircleDataSet";
            this.ArchiveOfStudentsOfTheProgrammingCircleDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // журнал_оценокBindingSource
            // 
            this.журнал_оценокBindingSource.DataMember = "журнал оценок";
            this.журнал_оценокBindingSource.DataSource = this.ArchiveOfStudentsOfTheProgrammingCircleDataSet;
            // 
            // журнал_оценокTableAdapter
            // 
            this.журнал_оценокTableAdapter.ClearBeforeFill = true;
            // 
            // Report1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Report1";
            this.Text = "Отчет по оценкам";
            this.Load += new System.EventHandler(this.Report1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ArchiveOfStudentsOfTheProgrammingCircleDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.журнал_оценокBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource журнал_оценокBindingSource;
        private ArchiveOfStudentsOfTheProgrammingCircleDataSet ArchiveOfStudentsOfTheProgrammingCircleDataSet;
        private ArchiveOfStudentsOfTheProgrammingCircleDataSetTableAdapters.журнал_оценокTableAdapter журнал_оценокTableAdapter;
    }
}