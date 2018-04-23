Imports Microsoft.VisualBasic
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
			schedulerControl1.GanttView.GetBaseTimeScale().Width = 100

			If schedulerStorage1.Appointments.Count > 0 Then
				schedulerControl1.Start = schedulerStorage1.Appointments(0).Start
			End If
		End Sub

		Private Sub resourcesTree1_CustomDrawNodeCell(ByVal sender As Object, ByVal e As CustomDrawNodeCellEventArgs) Handles resourcesTree1.CustomDrawNodeCell
			Dim resource As Resource = schedulerControl1.Storage.Resources.Items.Find(Function(r) r.Caption = e.CellText)
			e.Appearance.BackColor = resource.Color
		End Sub
	End Class
End Namespace