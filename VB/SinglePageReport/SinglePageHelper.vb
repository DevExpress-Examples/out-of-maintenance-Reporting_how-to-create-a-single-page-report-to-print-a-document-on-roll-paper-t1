Imports System
Imports System.Drawing
Imports System.Drawing.Printing
Imports DevExpress.XtraPrinting
Imports DevExpress.XtraPrinting.Native
Imports DevExpress.XtraReports.UI

Namespace SinglePageReport

    Public Module SinglePageHelper

        Public Sub GenerateSinglePageReport(ByVal report As XtraReport)
            Dim sumHeight As Single = 0
            report.CreateDocument()
            Dim pageSettings As XtraPageSettingsBase = report.PrintingSystem.PageSettings
            Call XtraPageSettingsBase.ApplyPageSettings(pageSettings, PaperKind.Custom, New Size(pageSettings.Bounds.Width, pageSettings.Bounds.Height * report.Pages.Count), pageSettings.Margins, pageSettings.MinMargins, pageSettings.Landscape)
            Dim iterator As NestedBrickIterator = New NestedBrickIterator(report.Pages(0).InnerBricks)
            While iterator.MoveNext()
                If TypeOf iterator.CurrentBrick Is VisualBrick Then
                    Dim brick As VisualBrick = CType(iterator.CurrentBrick, VisualBrick)
                    Dim bottomPos As Single = brick.Rect.Bottom
                    If bottomPos > sumHeight Then sumHeight = bottomPos
                End If
            End While

            sumHeight = GraphicsUnitConverter.Convert(sumHeight, GraphicsUnit.Document, GraphicsUnit.Inch) * 100
            Dim totalPageHeight As Integer = pageSettings.Margins.Top + pageSettings.Margins.Bottom + Convert.ToInt32(sumHeight)
            Call XtraPageSettingsBase.ApplyPageSettings(pageSettings, PaperKind.Custom, New Size(pageSettings.Bounds.Width, totalPageHeight), pageSettings.Margins, pageSettings.MinMargins, pageSettings.Landscape)
        End Sub
    End Module
End Namespace
