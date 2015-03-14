Public Class notetag
    Inherits Control

    Public RM As New ContextMenuStrip
    Public WithEvents DMI As New ToolStripMenuItem
    Public dispic As Integer
    Public value As String
    Private tn As note

    Private Sub notetag_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseClick

        If e.Button = Windows.Forms.MouseButtons.Right Then

            RM.Show(New Point(Me.Location.X + Me.Parent.Left + Me.Parent.FindForm.Left, Me.Location.Y + Me.Height))

        End If

    End Sub

    Private Sub notetag_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.MouseEnter

        Dim n As New note
        n.Contents = value
        n.Top = Me.Top + Me.Height
        If Me.Left + Me.Parent.Left + Me.Parent.FindForm.Left + n.Width > My.Computer.Screen.WorkingArea.Width Then

            n.Left = My.Computer.Screen.WorkingArea.Width - n.Width

        Else

            n.Left = Me.Left + Me.Parent.Left + Me.Parent.FindForm.Left

        End If

        Dim bs As New Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height, Drawing.Imaging.PixelFormat.Format32bppArgb)
        Dim g As Graphics = Graphics.FromImage(bs)
        g.CopyFromScreen(Screen.PrimaryScreen.Bounds.X + n.Left, Screen.PrimaryScreen.Bounds.Y + n.Top, 0, 0, n.Size, CopyPixelOperation.SourceCopy)
        n.SGrab = Image.FromHbitmap(bs.GetHbitmap)

        n.Show()
        tn = n

    End Sub

    Private Sub notetag_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.MouseLeave

        tn.Hide()
        tn.Dispose()

    End Sub

    Private Sub notetag_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint

        If dispic = 0 Then

            Dim r As New Random()
            dispic = r.Next(1, 4)
            r = Nothing

        End If

        Select Case dispic

            Case 1

                e.Graphics.DrawImage(My.Resources.lsn1, 0, 0, 24, 24)

            Case 2

                e.Graphics.DrawImage(My.Resources.lsn2, 0, 0, 24, 24)

            Case Else

                e.Graphics.DrawImage(My.Resources.lsn3, 0, 0, 24, 24)

        End Select

    End Sub

    Public Sub New()

        Me.Width = 24
        Me.Height = 24
        Me.Visible = True
        Me.Padding = New Padding(0)
        Me.Margin = New Padding(0)

        DMI.Text = "Delete Stickie"
        RM.Items.Add(DMI)

    End Sub

    Private Sub DMI_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DMI.Click

        Me.Parent.Controls.Remove(Me)
        Me.Dispose()

    End Sub

End Class
