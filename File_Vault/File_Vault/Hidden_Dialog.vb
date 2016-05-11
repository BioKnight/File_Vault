Public Class frm_Hidden_Dialog
    Private Sub frm_Hidden_Dialog_DoubleClick(sender As Object, e As EventArgs) Handles Me.DoubleClick
        Me.Close()
    End Sub

    Private Sub frm_Hidden_Dialog_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        ControlPaint.DrawBorder(e.Graphics, Me.ClientRectangle, Color.BlueViolet, ButtonBorderStyle.Solid)
    End Sub
End Class