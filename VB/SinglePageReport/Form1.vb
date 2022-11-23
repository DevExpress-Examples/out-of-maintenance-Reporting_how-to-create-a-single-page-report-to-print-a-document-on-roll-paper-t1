Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraReports.UI

Namespace SinglePageReport

    Public Partial Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim list As List(Of Data) = New List(Of Data)()
            Dim random As Random = New Random()
            For i As Integer = 0 To 500 - 1
                Dim data As Data = New Data() With {.Name = String.Format("Name{0}", i), .Group = String.Format("Group{0}", random.Next(10)), .Description = String.Format("Item Description {0}", i), .Value = random.Next(1000)}
                list.Add(data)
            Next

            Dim report As SampleReport = New SampleReport() With {.DataSource = list}
            GenerateSinglePageReport(report)
            Dim printTool As ReportPrintTool = New ReportPrintTool(report)
            printTool.ShowPreviewDialog()
        End Sub
    End Class
End Namespace
