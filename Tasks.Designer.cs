namespace CakeShop
{
    partial class Tasks
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource5 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource6 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource7 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource8 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ciocolataToolStrip = new System.Windows.Forms.ToolStrip();
            this.ciocolataToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.ciocolataToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.ciocolataToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.zToolStrip = new System.Windows.Forms.ToolStrip();
            this.productToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.productToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.zToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.task3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tasksDataSet = new CakeShop.TasksDataSet();
            this.task4BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.task5BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.task6BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.task7BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.task8BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.task9BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.task10BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.task3TableAdapter = new CakeShop.TasksDataSetTableAdapters.task3TableAdapter();
            this.task4TableAdapter = new CakeShop.TasksDataSetTableAdapters.task4TableAdapter();
            this.task5TableAdapter = new CakeShop.TasksDataSetTableAdapters.task5TableAdapter();
            this.task6TableAdapter = new CakeShop.TasksDataSetTableAdapters.task6TableAdapter();
            this.task7TableAdapter = new CakeShop.TasksDataSetTableAdapters.task7TableAdapter();
            this.task8TableAdapter = new CakeShop.TasksDataSetTableAdapters.task8TableAdapter();
            this.task9TableAdapter = new CakeShop.TasksDataSetTableAdapters.task9TableAdapter();
            this.task10TableAdapter = new CakeShop.TasksDataSetTableAdapters.task10TableAdapter();
            this.ciocolataToolStrip.SuspendLayout();
            this.zToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.task3BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tasksDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.task4BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.task5BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.task6BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.task7BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.task8BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.task9BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.task10BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "task3";
            reportDataSource1.Value = this.task3BindingSource;
            reportDataSource2.Name = "task4";
            reportDataSource2.Value = this.task4BindingSource;
            reportDataSource3.Name = "task5";
            reportDataSource3.Value = this.task5BindingSource;
            reportDataSource4.Name = "task6";
            reportDataSource4.Value = this.task6BindingSource;
            reportDataSource5.Name = "task7";
            reportDataSource5.Value = this.task7BindingSource;
            reportDataSource6.Name = "task8";
            reportDataSource6.Value = this.task8BindingSource;
            reportDataSource7.Name = "task9";
            reportDataSource7.Value = this.task9BindingSource;
            reportDataSource8.Name = "task10";
            reportDataSource8.Value = this.task10BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource5);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource6);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource7);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource8);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CakeShop.Report.Tasks.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 69);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(783, 507);
            this.reportViewer1.TabIndex = 0;
            // 
            // ciocolataToolStrip
            // 
            this.ciocolataToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ciocolataToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ciocolataToolStripLabel,
            this.ciocolataToolStripTextBox,
            this.ciocolataToolStripButton});
            this.ciocolataToolStrip.Location = new System.Drawing.Point(0, 0);
            this.ciocolataToolStrip.Name = "ciocolataToolStrip";
            this.ciocolataToolStrip.Size = new System.Drawing.Size(815, 27);
            this.ciocolataToolStrip.TabIndex = 1;
            this.ciocolataToolStrip.Text = "ciocolataToolStrip";
            // 
            // ciocolataToolStripLabel
            // 
            this.ciocolataToolStripLabel.Name = "ciocolataToolStripLabel";
            this.ciocolataToolStripLabel.Size = new System.Drawing.Size(75, 24);
            this.ciocolataToolStripLabel.Text = "Ciocolata:";
            // 
            // ciocolataToolStripTextBox
            // 
            this.ciocolataToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ciocolataToolStripTextBox.Name = "ciocolataToolStripTextBox";
            this.ciocolataToolStripTextBox.Size = new System.Drawing.Size(100, 27);
            // 
            // ciocolataToolStripButton
            // 
            this.ciocolataToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ciocolataToolStripButton.Name = "ciocolataToolStripButton";
            this.ciocolataToolStripButton.Size = new System.Drawing.Size(76, 24);
            this.ciocolataToolStripButton.Text = "Ciocolata";
            this.ciocolataToolStripButton.Click += new System.EventHandler(this.ciocolataToolStripButton_Click);
            // 
            // zToolStrip
            // 
            this.zToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.zToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productToolStripLabel,
            this.productToolStripTextBox,
            this.zToolStripButton});
            this.zToolStrip.Location = new System.Drawing.Point(0, 27);
            this.zToolStrip.Name = "zToolStrip";
            this.zToolStrip.Size = new System.Drawing.Size(815, 27);
            this.zToolStrip.TabIndex = 2;
            this.zToolStrip.Text = "zToolStrip";
            // 
            // productToolStripLabel
            // 
            this.productToolStripLabel.Name = "productToolStripLabel";
            this.productToolStripLabel.Size = new System.Drawing.Size(63, 24);
            this.productToolStripLabel.Text = "Product:";
            // 
            // productToolStripTextBox
            // 
            this.productToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.productToolStripTextBox.Name = "productToolStripTextBox";
            this.productToolStripTextBox.Size = new System.Drawing.Size(100, 27);
            // 
            // zToolStripButton
            // 
            this.zToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.zToolStripButton.Name = "zToolStripButton";
            this.zToolStripButton.Size = new System.Drawing.Size(29, 24);
            this.zToolStripButton.Text = "Z";
            this.zToolStripButton.Click += new System.EventHandler(this.zToolStripButton_Click);
            // 
            // task3BindingSource
            // 
            this.task3BindingSource.DataMember = "task3";
            this.task3BindingSource.DataSource = this.tasksDataSet;
            // 
            // tasksDataSet
            // 
            this.tasksDataSet.DataSetName = "TasksDataSet";
            this.tasksDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // task4BindingSource
            // 
            this.task4BindingSource.DataMember = "task4";
            this.task4BindingSource.DataSource = this.tasksDataSet;
            // 
            // task5BindingSource
            // 
            this.task5BindingSource.DataMember = "task5";
            this.task5BindingSource.DataSource = this.tasksDataSet;
            // 
            // task6BindingSource
            // 
            this.task6BindingSource.DataMember = "task6";
            this.task6BindingSource.DataSource = this.tasksDataSet;
            // 
            // task7BindingSource
            // 
            this.task7BindingSource.DataMember = "task7";
            this.task7BindingSource.DataSource = this.tasksDataSet;
            // 
            // task8BindingSource
            // 
            this.task8BindingSource.DataMember = "task8";
            this.task8BindingSource.DataSource = this.tasksDataSet;
            // 
            // task9BindingSource
            // 
            this.task9BindingSource.DataMember = "task9";
            this.task9BindingSource.DataSource = this.tasksDataSet;
            // 
            // task10BindingSource
            // 
            this.task10BindingSource.DataMember = "task10";
            this.task10BindingSource.DataSource = this.tasksDataSet;
            // 
            // task3TableAdapter
            // 
            this.task3TableAdapter.ClearBeforeFill = true;
            // 
            // task4TableAdapter
            // 
            this.task4TableAdapter.ClearBeforeFill = true;
            // 
            // task5TableAdapter
            // 
            this.task5TableAdapter.ClearBeforeFill = true;
            // 
            // task6TableAdapter
            // 
            this.task6TableAdapter.ClearBeforeFill = true;
            // 
            // task7TableAdapter
            // 
            this.task7TableAdapter.ClearBeforeFill = true;
            // 
            // task8TableAdapter
            // 
            this.task8TableAdapter.ClearBeforeFill = true;
            // 
            // task9TableAdapter
            // 
            this.task9TableAdapter.ClearBeforeFill = true;
            // 
            // task10TableAdapter
            // 
            this.task10TableAdapter.ClearBeforeFill = true;
            // 
            // Tasks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 588);
            this.Controls.Add(this.zToolStrip);
            this.Controls.Add(this.ciocolataToolStrip);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Tasks";
            this.Text = "Tasks";
            this.Load += new System.EventHandler(this.Tasks_Load);
            this.ciocolataToolStrip.ResumeLayout(false);
            this.ciocolataToolStrip.PerformLayout();
            this.zToolStrip.ResumeLayout(false);
            this.zToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.task3BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tasksDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.task4BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.task5BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.task6BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.task7BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.task8BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.task9BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.task10BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private TasksDataSet tasksDataSet;
        private System.Windows.Forms.BindingSource task3BindingSource;
        private TasksDataSetTableAdapters.task3TableAdapter task3TableAdapter;
        private System.Windows.Forms.BindingSource task4BindingSource;
        private TasksDataSetTableAdapters.task4TableAdapter task4TableAdapter;
        private System.Windows.Forms.BindingSource task5BindingSource;
        private TasksDataSetTableAdapters.task5TableAdapter task5TableAdapter;
        private System.Windows.Forms.BindingSource task6BindingSource;
        private TasksDataSetTableAdapters.task6TableAdapter task6TableAdapter;
        private System.Windows.Forms.BindingSource task7BindingSource;
        private TasksDataSetTableAdapters.task7TableAdapter task7TableAdapter;
        private System.Windows.Forms.BindingSource task8BindingSource;
        private TasksDataSetTableAdapters.task8TableAdapter task8TableAdapter;
        private System.Windows.Forms.BindingSource task9BindingSource;
        private TasksDataSetTableAdapters.task9TableAdapter task9TableAdapter;
        private System.Windows.Forms.BindingSource task10BindingSource;
        private TasksDataSetTableAdapters.task10TableAdapter task10TableAdapter;
        private System.Windows.Forms.ToolStrip ciocolataToolStrip;
        private System.Windows.Forms.ToolStripLabel ciocolataToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox ciocolataToolStripTextBox;
        private System.Windows.Forms.ToolStripButton ciocolataToolStripButton;
        private System.Windows.Forms.ToolStrip zToolStrip;
        private System.Windows.Forms.ToolStripLabel productToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox productToolStripTextBox;
        private System.Windows.Forms.ToolStripButton zToolStripButton;
    }
}