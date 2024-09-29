Public Class Separator

    Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)
        MyBase.OnPaint(e)

        MyBase.Height = 2
        MyBase.BackColor = Color.White
        Dim dark As New Panel
        With dark
            .Height = 1
            .BackColor = Color.FromArgb(160, 160, 160)
            .Dock = DockStyle.Top

        End With
        MyBase.Controls.Add(dark)
    End Sub
End Class
