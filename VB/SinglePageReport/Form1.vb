Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraReports.UI

Namespace SinglePageReport
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			Dim list As New List(Of Data)()
			Dim random As New Random()

			For i As Integer = 0 To 499
				Dim data As New Data() With {.Name = String.Format("Name{0}", i), .Group = String.Format("Group{0}", random.Next(10)), .Description = String.Format("Item Description {0}", i), .Value = random.Next(1000)}

				list.Add(data)
			Next i

			Dim report As New SampleReport() With {.DataSource = list}

			SinglePageHelper.GenerateSinglePageReport(report)

			Dim printTool As New ReportPrintTool(report)
			printTool.ShowPreviewDialog()
		End Sub
	End Class
End Namespace
