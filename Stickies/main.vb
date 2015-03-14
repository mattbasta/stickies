Public Class Main

    Private Declare Auto Function SetProcessWorkingSetSize Lib "kernel32.dll" (ByVal procHandle As IntPtr, ByVal min As Int32, ByVal max As Int32) As Boolean

    Public Sub SetSize()
        Try
            Dim Mem As Process
            Mem = Process.GetCurrentProcess()
            SetProcessWorkingSetSize(Mem.Handle, -1, -1)
        Catch ex As Exception
            MsgBox(ex.ToString)
            End
        End Try
    End Sub

    Private Sub Main_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim xw As New Xml.XmlTextWriter(My.Application.Info.DirectoryPath & "\sticky.xml", System.Text.Encoding.Default)
        xw.WriteStartDocument()
        xw.WriteStartElement("stickies")
        For Each n As Control In sks.Controls
            Dim c As notetag = CType(n, notetag)
            xw.WriteStartElement("note")
            xw.WriteAttributeString("dispic", c.dispic.ToString)
            xw.WriteString(c.value)
            xw.WriteEndElement()
        Next
        xw.WriteEndElement()
        xw.WriteEndDocument()

        xw.Flush()
        xw.Close()

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.Left = My.Computer.Screen.WorkingArea.Width - Me.Width - 100
        Me.Height = 25

        Try

            Dim xd As New Xml.XmlDocument
            xd.Load(My.Application.Info.DirectoryPath & "\sticky.xml")

            For Each n As Xml.XmlNode In xd.SelectNodes("stickies/note")

                Dim x As New notetag
                x.dispic = n.Attributes.GetNamedItem("dispic").Value
                x.value = n.InnerText
                sks.Controls.Add(x)

            Next

            xd = Nothing

        Catch ex As Exception

        End Try

    End Sub

    Private Sub Main_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize

        Me.Height = 25

    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click

        Me.Close()

    End Sub

    Private Sub AddStickyNoteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddStickyNoteToolStripMenuItem.Click

        Dim val As String = InputBox("Enter the text for the sticky note:", "Contents")
        If val = "" Then Exit Sub
        If val.Contains("<") OrElse val.Contains(">") OrElse val.Contains("&") Then

            MsgBox("You can't include brackets or ampersands in your stickies.")
            Exit Sub

        End If
        Dim nt As New notetag
        nt.value = val
        sks.Controls.Add(nt)

        If sks.Controls.Count * 24 > sks.Width Then

            Me.Width += 24
            Me.Left -= 24

        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        CMS.Show(Button1, New Point(Button1.Left, Button1.Top + Button1.Height))
    End Sub

    Private Sub GCInvoker_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GCInvoker.Tick
        SetSize()
    End Sub
End Class
