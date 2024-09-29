Public Class Separator

    Private darkPanel As Panel

    Public Sub New()
        InitializeComponent()
        MyBase.Height = 2
        MyBase.BackColor = Color.White

        darkPanel = New Panel With {
            .Height = 1,
            .BackColor = Color.FromArgb(160, 160, 160),
            .Dock = DockStyle.Top
        }
        MyBase.Controls.Add(darkPanel)
    End Sub

    Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)
        MyBase.OnPaint(e)
    End Sub
End Class
