using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CakeShop
{
    public partial class Tasks : Form
    {
        public Tasks()
        {
            InitializeComponent();
        }

        private void Tasks_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tasksDataSet.task10' table. You can move, or remove it, as needed.
            this.task10TableAdapter.Fill(this.tasksDataSet.task10);
            // TODO: This line of code loads data into the 'tasksDataSet.task9' table. You can move, or remove it, as needed.
            this.task9TableAdapter.Fill(this.tasksDataSet.task9);
            // TODO: This line of code loads data into the 'tasksDataSet.task8' table. You can move, or remove it, as needed.
            this.task8TableAdapter.Fill(this.tasksDataSet.task8);
            // TODO: This line of code loads data into the 'tasksDataSet.task7' table. You can move, or remove it, as needed.
            this.task7TableAdapter.Fill(this.tasksDataSet.task7);
            // TODO: This line of code loads data into the 'tasksDataSet.task6' table. You can move, or remove it, as needed.
            this.task6TableAdapter.Fill(this.tasksDataSet.task6);
            // TODO: This line of code loads data into the 'tasksDataSet.task5' table. You can move, or remove it, as needed.
            this.task5TableAdapter.Fill(this.tasksDataSet.task5);
            // TODO: This line of code loads data into the 'tasksDataSet.task4' table. You can move, or remove it, as needed.
            this.task4TableAdapter.Fill(this.tasksDataSet.task4);
            // TODO: This line of code loads data into the 'tasksDataSet.task3' table. You can move, or remove it, as needed.
            this.task3TableAdapter.Fill(this.tasksDataSet.task3);

            this.reportViewer1.RefreshReport();
        }

        private void ciocolataToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.task5TableAdapter.Ciocolata(this.tasksDataSet.task5, ((int)(System.Convert.ChangeType(ciocolataToolStripTextBox.Text, typeof(int)))));
                this.reportViewer1.RefreshReport();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void zToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.task6TableAdapter.Z(this.tasksDataSet.task6, productToolStripTextBox.Text);
                this.reportViewer1.RefreshReport();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
