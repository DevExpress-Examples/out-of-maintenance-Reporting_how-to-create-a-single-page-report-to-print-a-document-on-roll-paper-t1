Imports Microsoft.VisualBasic
Imports System
Namespace SinglePageReport
	Partial Public Class SampleReport
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary> 
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Dim xrSummary1 As New DevExpress.XtraReports.UI.XRSummary()
			Dim xrSummary2 As New DevExpress.XtraReports.UI.XRSummary()
			Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
			Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
			Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
			Me.bindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
			Me.GroupHeader1 = New DevExpress.XtraReports.UI.GroupHeaderBand()
			Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
			Me.xrTable1 = New DevExpress.XtraReports.UI.XRTable()
			Me.xrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
			Me.xrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableCell3 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.GroupFooter1 = New DevExpress.XtraReports.UI.GroupFooterBand()
			Me.xrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
			Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
			Me.xrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
			Me.ReportFooter = New DevExpress.XtraReports.UI.ReportFooterBand()
			Me.xrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
			CType(Me.bindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.xrTable1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			' 
			' Detail
			' 
			Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrTable1})
			Me.Detail.HeightF = 25F
			Me.Detail.Name = "Detail"
			Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' TopMargin
			' 
			Me.TopMargin.Name = "TopMargin"
			Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' BottomMargin
			' 
			Me.BottomMargin.Name = "BottomMargin"
			Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' bindingSource1
			' 
			Me.bindingSource1.DataSource = GetType(SinglePageReport.Data)
			' 
			' GroupHeader1
			' 
			Me.GroupHeader1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLabel1})
			Me.GroupHeader1.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() { New DevExpress.XtraReports.UI.GroupField("Group", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
			Me.GroupHeader1.HeightF = 23F
			Me.GroupHeader1.Name = "GroupHeader1"
			' 
			' xrLabel1
			' 
			Me.xrLabel1.BackColor = System.Drawing.Color.PowderBlue
			Me.xrLabel1.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
			Me.xrLabel1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Group")})
			Me.xrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
			Me.xrLabel1.Name = "xrLabel1"
			Me.xrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F)
			Me.xrLabel1.SizeF = New System.Drawing.SizeF(650F, 23F)
			Me.xrLabel1.StylePriority.UseBackColor = False
			Me.xrLabel1.StylePriority.UseBorders = False
			Me.xrLabel1.Text = "xrLabel1"
			' 
			' xrTable1
			' 
			Me.xrTable1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
			Me.xrTable1.Name = "xrTable1"
			Me.xrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() { Me.xrTableRow1})
			Me.xrTable1.SizeF = New System.Drawing.SizeF(650F, 25F)
			' 
			' xrTableRow1
			' 
			Me.xrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.xrTableCell1, Me.xrTableCell2, Me.xrTableCell3})
			Me.xrTableRow1.Name = "xrTableRow1"
			Me.xrTableRow1.Weight = 11.5R
			' 
			' xrTableCell1
			' 
			Me.xrTableCell1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Name")})
			Me.xrTableCell1.Name = "xrTableCell1"
			Me.xrTableCell1.Text = "xrTableCell1"
			Me.xrTableCell1.Weight = 0.2857142857142857R
			' 
			' xrTableCell2
			' 
			Me.xrTableCell2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Description")})
			Me.xrTableCell2.Name = "xrTableCell2"
			Me.xrTableCell2.Text = "xrTableCell2"
			Me.xrTableCell2.Weight = 0.2857142857142857R
			' 
			' xrTableCell3
			' 
			Me.xrTableCell3.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Value")})
			Me.xrTableCell3.Name = "xrTableCell3"
			Me.xrTableCell3.Text = "xrTableCell3"
			Me.xrTableCell3.Weight = 0.2857142857142857R
			' 
			' GroupFooter1
			' 
			Me.GroupFooter1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLabel2})
			Me.GroupFooter1.HeightF = 23F
			Me.GroupFooter1.Name = "GroupFooter1"
			' 
			' xrLabel2
			' 
			Me.xrLabel2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Value")})
			Me.xrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(433.3333F, 0F)
			Me.xrLabel2.Name = "xrLabel2"
			Me.xrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F)
			Me.xrLabel2.SizeF = New System.Drawing.SizeF(216.6667F, 23F)
			xrSummary1.FormatString = "Group Total: {0}"
			xrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
			Me.xrLabel2.Summary = xrSummary1
			' 
			' ReportHeader
			' 
			Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLabel3})
			Me.ReportHeader.HeightF = 78.125F
			Me.ReportHeader.Name = "ReportHeader"
			' 
			' xrLabel3
			' 
			Me.xrLabel3.Font = New System.Drawing.Font("Times New Roman", 32F)
			Me.xrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
			Me.xrLabel3.Name = "xrLabel3"
			Me.xrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F)
			Me.xrLabel3.SizeF = New System.Drawing.SizeF(650F, 78.125F)
			Me.xrLabel3.StylePriority.UseFont = False
			Me.xrLabel3.StylePriority.UseTextAlignment = False
			Me.xrLabel3.Text = "Single-page Report"
			Me.xrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
			' 
			' ReportFooter
			' 
			Me.ReportFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLabel4})
			Me.ReportFooter.HeightF = 23F
			Me.ReportFooter.Name = "ReportFooter"
			' 
			' xrLabel4
			' 
			Me.xrLabel4.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Value")})
			Me.xrLabel4.Font = New System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold)
			Me.xrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(433.3333F, 0F)
			Me.xrLabel4.Name = "xrLabel4"
			Me.xrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F)
			Me.xrLabel4.SizeF = New System.Drawing.SizeF(216.6667F, 23F)
			Me.xrLabel4.StylePriority.UseFont = False
			xrSummary2.FormatString = "Grand Total: {0}"
			xrSummary2.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
			Me.xrLabel4.Summary = xrSummary2
			' 
			' SampleReport
			' 
			Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail, Me.TopMargin, Me.BottomMargin, Me.GroupHeader1, Me.GroupFooter1, Me.ReportHeader, Me.ReportFooter})
			Me.DataSource = Me.bindingSource1
			Me.Version = "13.2"
			CType(Me.bindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.xrTable1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

		End Sub

		#End Region

		Private Detail As DevExpress.XtraReports.UI.DetailBand
		Private TopMargin As DevExpress.XtraReports.UI.TopMarginBand
		Private BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
		Private xrTable1 As DevExpress.XtraReports.UI.XRTable
		Private xrTableRow1 As DevExpress.XtraReports.UI.XRTableRow
		Private xrTableCell1 As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableCell2 As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableCell3 As DevExpress.XtraReports.UI.XRTableCell
		Private bindingSource1 As System.Windows.Forms.BindingSource
		Private GroupHeader1 As DevExpress.XtraReports.UI.GroupHeaderBand
		Private xrLabel1 As DevExpress.XtraReports.UI.XRLabel
		Private GroupFooter1 As DevExpress.XtraReports.UI.GroupFooterBand
		Private xrLabel2 As DevExpress.XtraReports.UI.XRLabel
		Private ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
		Private xrLabel3 As DevExpress.XtraReports.UI.XRLabel
		Private ReportFooter As DevExpress.XtraReports.UI.ReportFooterBand
		Private xrLabel4 As DevExpress.XtraReports.UI.XRLabel
	End Class
End Namespace
