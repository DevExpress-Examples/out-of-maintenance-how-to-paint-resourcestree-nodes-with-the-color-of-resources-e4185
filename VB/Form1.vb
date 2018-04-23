Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraScheduler
Imports DevExpress.XtraTreeList

Namespace SchedulerResourcesTreeColors
    Partial Public Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            ' TODO: This line of code loads data into the 'tasksDataSet1.Resources' table. You can move, or remove it, as needed.
            Me.resourcesTableAdapter.Fill(Me.tasksDataSet1.Resources)
            ' TODO: This line of code loads data into the 'tasksDataSet1.TaskDependencies' table. You can move, or remove it, as needed.
            Me.taskDependenciesTableAdapter.Fill(Me.tasksDataSet1.TaskDependencies)
            ' TODO: This line of code loads data into the 'tasksDataSet1.Tasks' table. You can move, or remove it, as needed.
            Me.tasksTableAdapter.Fill(Me.tasksDataSet1.Tasks)

            schedulerControl1.Storage.Appointments.CommitIdToDataSource = False
        End Sub

        Private Sub resourcesTree1_CustomDrawNodeCell(ByVal sender As Object, ByVal e As CustomDrawNodeCellEventArgs) Handles resourcesTree1.CustomDrawNodeCell
            If (schedulerControl1.Storage IsNot Nothing) Then
                Dim resource As Resource = schedulerControl1.Storage.Resources.Items.Find(Function(r) r.Caption = e.CellText)
                e.Appearance.BackColor = resource.GetColor()
            End If
        End Sub
    End Class
End Namespace