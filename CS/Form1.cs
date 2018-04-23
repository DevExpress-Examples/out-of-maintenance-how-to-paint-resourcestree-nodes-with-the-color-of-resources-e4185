using System;
using System.Windows.Forms;
using DevExpress.XtraScheduler;
using DevExpress.XtraTreeList;

namespace SchedulerResourcesTreeColors {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            // TODO: This line of code loads data into the 'tasksDataSet1.Resources' table. You can move, or remove it, as needed.
            this.resourcesTableAdapter.Fill(this.tasksDataSet1.Resources);
            // TODO: This line of code loads data into the 'tasksDataSet1.TaskDependencies' table. You can move, or remove it, as needed.
            this.taskDependenciesTableAdapter.Fill(this.tasksDataSet1.TaskDependencies);
            // TODO: This line of code loads data into the 'tasksDataSet1.Tasks' table. You can move, or remove it, as needed.
            this.tasksTableAdapter.Fill(this.tasksDataSet1.Tasks);

            schedulerControl1.Storage.Appointments.CommitIdToDataSource = false;
        }

        private void resourcesTree1_CustomDrawNodeCell(object sender, CustomDrawNodeCellEventArgs e) {
            if (schedulerControl1.Storage != null)
            {
                Resource resource = schedulerControl1.Storage.Resources.Items.Find(r => r.Caption == e.CellText);
                e.Appearance.BackColor = resource.GetColor();
            }
        }
    }
}