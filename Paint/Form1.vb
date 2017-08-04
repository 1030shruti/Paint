Public Class Form1
    Dim myBrush As New SolidBrush(Color.Black)

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Location = New Point(0, 0)
    End Sub


    'Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
    '    Dim draw As System.Drawing.Graphics
    '    draw = Me.CreateGraphics
    '    Dim bluePen As New Pen(Color.Blue, 3)
    '    Dim redPen As New Pen(Color.Red, 3)

    '    draw.DrawEllipse(bluePen, 80, 200, 100, 100)
    '    draw.DrawLine(bluePen, 130, 300, 130, 400)
    '    draw.DrawLine(bluePen, 130, 400, 180, 320)
    '    draw.DrawLine(bluePen, 130, 400, 80, 320)
    '    draw.DrawLine(bluePen, 130, 400, 190, 530)
    '    draw.DrawLine(bluePen, 130, 400, 70, 530)
    '    draw.DrawEllipse(redPen, 300, 200, 100, 100)
    '    draw.DrawLine(redPen, 350, 300, 350, 400)
    '    draw.DrawLine(redPen, 350, 400, 300, 340)
    '    draw.DrawLine(redPen, 350, 400, 400, 350)
    '    draw.DrawLine(redPen, 350, 400, 410, 530)
    '    draw.DrawLine(redPen, 350, 400, 280, 530)
    'End Sub

    'Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
    '    Label1.Text = MousePosition.X
    '    Label2.Text = MousePosition.Y
    'End Sub
    Dim d As Boolean = False
    Private Sub Form1_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        Dim draw As System.Drawing.Graphics
        draw = Me.CreateGraphics
        Dim X As Integer = Form1.MousePosition.X - Me.Location.X - 10
        Dim Y As Integer = Form1.MousePosition.Y - Me.Location.Y - 35

        If d = True Then
            draw.FillEllipse(myBrush, X, Y, BrshSize.Value, BrshSize.Value)
        End If
    End Sub

    Private Sub Form1_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown

        Dim draw As System.Drawing.Graphics
        draw = Me.CreateGraphics
        d = True

        Dim X As Integer = Form1.MousePosition.X - Me.Location.X - 10
        Dim Y As Integer = Form1.MousePosition.Y - Me.Location.Y - 35





    End Sub

    Private Sub Form1_MouseUp(sender As Object, e As MouseEventArgs) Handles Me.MouseUp


        d = False


    End Sub

    Private Sub Red_Click(sender As Object, e As EventArgs) Handles Red.Click
        myBrush.Color = Color.Red
    End Sub

    Private Sub Blue_Click(sender As Object, e As EventArgs) Handles Blue.Click
        myBrush.Color = Color.Blue
    End Sub

    Private Sub Green_Click(sender As Object, e As EventArgs) Handles Green.Click
        myBrush.Color = Color.Green
    End Sub

    Private Sub Purple_Click(sender As Object, e As EventArgs) Handles Purple.Click
        myBrush.Color = Color.Purple
    End Sub

    Private Sub Pink_Click(sender As Object, e As EventArgs) Handles Pink.Click
        myBrush.Color = Color.LightCoral
    End Sub

    Private Sub Brown_Click(sender As Object, e As EventArgs) Handles Brown.Click
        myBrush.Color = Color.Brown
    End Sub

    Private Sub Black_Click(sender As Object, e As EventArgs) Handles Black.Click
        myBrush.Color = Color.Black
    End Sub

    Private Sub LightGreen_Click(sender As Object, e As EventArgs) Handles LightGreen.Click
        myBrush.Color = Color.LightGreen
    End Sub

    Private Sub LightBlue_Click(sender As Object, e As EventArgs) Handles LightBlue.Click
        myBrush.Color = Color.LightSkyBlue
    End Sub

    Private Sub LightPurple_Click(sender As Object, e As EventArgs) Handles LightPurple.Click
        myBrush.Color = Color.Lavender
    End Sub

    Private Sub LightPink_Click(sender As Object, e As EventArgs) Handles LightPink.Click
        myBrush.Color = Color.Pink
    End Sub

    Private Sub Eraser_Click(sender As Object, e As EventArgs) Handles Eraser.Click
        myBrush.Color = Color.White
    End Sub

    Private Sub HScrollBar1_Scroll(sender As Object, e As ScrollEventArgs) Handles BrshSize.Scroll

    End Sub

    Private Sub Yellow_Click(sender As Object, e As EventArgs) Handles Yellow.Click
        myBrush.Color = Color.Yellow
    End Sub
End Class