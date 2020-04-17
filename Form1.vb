
Public Class Form1

    '窗口移动
    Private blnDragging As Boolean = False
    Private OriginalLocation As Point
    Private MoveToPoint As Point

    Private Sub FormMouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        Me.blnDragging = True
        Me.OriginalLocation = New Point(e.X, e.Y)
    End Sub

    Private Sub FormMouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        If Me.blnDragging Then
            Me.MoveToPoint = Me.PointToScreen(New Point(e.X, e.Y))
            Me.MoveToPoint.Offset(Me.OriginalLocation.X * -1, Me.OriginalLocation.Y * -1)
            Me.Location = Me.MoveToPoint
        End If
        Me.CloseButton.Visible = True
    End Sub

    Private Sub FormMouseUp(sender As Object, e As MouseEventArgs) Handles Me.MouseUp
        Me.blnDragging = False
    End Sub

    Private Sub TimerTick(sender As Object, e As EventArgs) Handles Timer.Tick
        Me.Label.Text = Format(Expression:=Now, Style:="HH:mm")
        Me.DateLabel.Text = Format(Expression:=Now, Style:="MM月dd日")
        Me.CloseButton.Visible = False
    End Sub

    Private Sub CloseButtonClick(sender As Object, e As EventArgs) Handles CloseButton.Click
        End
    End Sub

    '打开控制面板
    Private Sub ControlButton_Click(sender As Object, e As EventArgs) Handles ControlButton.Click
        RunCommand("control")
    End Sub

    '打开计算器
    Private Sub CalcButton_Click(sender As Object, e As EventArgs) Handles CalcButton.Click
        RunCommand("calc.exe")
    End Sub

    'RunCommand函数，在CMD终端运行命令。
    Private Function RunCommand(command As String)
        Dim p = New Process()
        p.StartInfo.FileName = "cmd.exe"
        p.StartInfo.UseShellExecute = False
        p.StartInfo.CreateNoWindow = True
        p.StartInfo.RedirectStandardInput = True
        p.Start()
        p.StandardInput.WriteLine(command)
        p.StandardInput.AutoFlush = True
        p.WaitForExit(1000)
        p.Close()
    End Function

    ' 启动cmd窗口
    Private Sub CmdButton_Click(sender As Object, e As EventArgs) Handles CmdButton.Click
        Dim p = New Process()
        p.StartInfo.FileName = "cmd.exe"
        p.StartInfo.UseShellExecute = False
        p.StartInfo.CreateNoWindow = False
        p.Start()
    End Sub

End Class
