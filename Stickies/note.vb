Imports Microsoft.VisualBasic
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports System.Drawing.Imaging
Imports System.Runtime.InteropServices

Public Class note

    Public Contents As String = ""
    Public SGrab As Image

    Private Sub note_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint

        With e.Graphics
            .DrawImage(SGrab, 0, 0)
            Dim myMatrix As Drawing2D.Matrix = .Transform
            .DrawImage(My.Resources.sticky, 0, 0, 250, 250)
            myMatrix.RotateAt(2, New PointF(125, 125), Drawing2D.MatrixOrder.Append)
            .Transform = myMatrix
            .SmoothingMode = Drawing2D.SmoothingMode.HighQuality
            .TextRenderingHint = Drawing.Text.TextRenderingHint.AntiAlias
            .DrawString(Contents, New Font(System.Drawing.FontFamily.GenericSansSerif, 12, FontStyle.Regular, GraphicsUnit.Pixel), Brushes.Black, New RectangleF(48, 48, 154, 154), System.Drawing.StringFormat.GenericDefault)
            myMatrix.Dispose()
        End With

    End Sub

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        Me.Visible = False

        ' Add any initialization after the InitializeComponent() call.

    End Sub
End Class
