Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        NotifyIcon1.Visible = True
        Me.Hide()
        Dim mn As New ContextMenu
        NotifyIcon1.ContextMenu = mn
        Dim mi1 As New MenuItem("Close")
        mn.MenuItems.Add(mi1)
        AddHandler mi1.Click, AddressOf Closer

        Dim p As New Media.SoundPlayer(My.Resources.silz)
        p.PlayLooping()
    End Sub

    Private Sub Closer(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

End Class
