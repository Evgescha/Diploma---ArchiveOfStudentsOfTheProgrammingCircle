
namespace ArchiveOfStudentsOfTheProgrammingCircle
{
    partial class Report2
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
            this.MoneyFromSchoolerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.MoneyFromSchoolerTableAdapter = new ArchiveOfStudentsOfTheProgrammingCircle.ArchiveOfStudentsOfTheProgrammingCircleDataSetTableAdapters.MoneyFromSchoolerTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ArchiveOfStudentsOfTheProgrammingCircleDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MoneyFromSchoolerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.MoneyFromSchoolerBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ArchiveOfStudentsOfTheProgrammingCircle.Report2.rdlc";
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
            // MoneyFromSchoolerBindingSource
            // 
            this.MoneyFromSchoolerBindingSource.DataMember = "MoneyFromSchooler";
            this.MoneyFromSchoolerBindingSource.DataSource = this.ArchiveOfStudentsOfTheProgrammingCircleDataSet;
            // 
            // MoneyFromSchoolerTableAdapter
            // 
            this.MoneyFromSchoolerTableAdapter.ClearBeforeFill = true;
            // 
            // Report2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Report2";
            this.Text = "Вклады учащихся в развитие кружка";
            this.Load += new System.EventHandler(this.Report2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ArchiveOfStudentsOfTheProgrammingCircleDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MoneyFromSchoolerBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource MoneyFromSchoolerBindingSource;
        private ArchiveOfStudentsOfTheProgrammingCircleDataSet ArchiveOfStudentsOfTheProgrammingCircleDataSet;
        private ArchiveOfStudentsOfTheProgrammingCircleDataSetTableAdapters.MoneyFromSchoolerTableAdapter MoneyFromSchoolerTableAdapter;
    }
}