<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label = New System.Windows.Forms.Label()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.CloseButton = New System.Windows.Forms.Button()
        Me.DateLabel = New System.Windows.Forms.Label()
        Me.Seperator = New System.Windows.Forms.Label()
        Me.ControlButton = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.CalcButton = New System.Windows.Forms.Button()
        Me.CmdButton = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label
        '
        Me.Label.Font = New System.Drawing.Font("微软雅黑", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label.ForeColor = System.Drawing.Color.White
        Me.Label.Location = New System.Drawing.Point(14, 27)
        Me.Label.Name = "Label"
        Me.Label.Size = New System.Drawing.Size(312, 88)
        Me.Label.TabIndex = 1
        Me.Label.Text = "00:00"
        '
        'Timer
        '
        Me.Timer.Enabled = True
        Me.Timer.Interval = 1000
        '
        'CloseButton
        '
        Me.CloseButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CloseButton.BackColor = System.Drawing.Color.Transparent
        Me.CloseButton.FlatAppearance.BorderSize = 0
        Me.CloseButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Tomato
        Me.CloseButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CloseButton.Font = New System.Drawing.Font("宋体", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.CloseButton.Location = New System.Drawing.Point(438, 15)
        Me.CloseButton.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(44, 38)
        Me.CloseButton.TabIndex = 4
        Me.CloseButton.Text = "×"
        Me.CloseButton.UseVisualStyleBackColor = False
        Me.CloseButton.Visible = False
        '
        'DateLabel
        '
        Me.DateLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DateLabel.Font = New System.Drawing.Font("微软雅黑", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.DateLabel.ForeColor = System.Drawing.Color.White
        Me.DateLabel.Location = New System.Drawing.Point(292, 78)
        Me.DateLabel.Name = "DateLabel"
        Me.DateLabel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DateLabel.Size = New System.Drawing.Size(159, 39)
        Me.DateLabel.TabIndex = 5
        Me.DateLabel.Text = "01月01日"
        Me.DateLabel.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Seperator
        '
        Me.Seperator.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Seperator.BackColor = System.Drawing.Color.Transparent
        Me.Seperator.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Seperator.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Seperator.Location = New System.Drawing.Point(29, 111)
        Me.Seperator.Name = "Seperator"
        Me.Seperator.Size = New System.Drawing.Size(430, 41)
        Me.Seperator.TabIndex = 6
        Me.Seperator.Text = "—————————————————"
        Me.Seperator.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ControlButton
        '
        Me.ControlButton.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ControlButton.BackColor = System.Drawing.Color.Transparent
        Me.ControlButton.BackgroundImage = CType(resources.GetObject("ControlButton.BackgroundImage"), System.Drawing.Image)
        Me.ControlButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ControlButton.FlatAppearance.BorderSize = 0
        Me.ControlButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray
        Me.ControlButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ControlButton.Location = New System.Drawing.Point(332, 5)
        Me.ControlButton.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ControlButton.Name = "ControlButton"
        Me.ControlButton.Size = New System.Drawing.Size(76, 44)
        Me.ControlButton.TabIndex = 7
        Me.ControlButton.UseVisualStyleBackColor = False
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel1.ColumnCount = 5
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.ControlButton, 4, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.CalcButton, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.CmdButton, 3, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(38, 155)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(412, 54)
        Me.TableLayoutPanel1.TabIndex = 8
        '
        'CalcButton
        '
        Me.CalcButton.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CalcButton.BackColor = System.Drawing.Color.Transparent
        Me.CalcButton.BackgroundImage = CType(resources.GetObject("CalcButton.BackgroundImage"), System.Drawing.Image)
        Me.CalcButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.CalcButton.FlatAppearance.BorderSize = 0
        Me.CalcButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray
        Me.CalcButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CalcButton.Location = New System.Drawing.Point(86, 5)
        Me.CalcButton.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CalcButton.Name = "CalcButton"
        Me.CalcButton.Size = New System.Drawing.Size(75, 44)
        Me.CalcButton.TabIndex = 8
        Me.CalcButton.UseVisualStyleBackColor = False
        '
        'CmdButton
        '
        Me.CmdButton.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmdButton.BackColor = System.Drawing.Color.Transparent
        Me.CmdButton.BackgroundImage = CType(resources.GetObject("CmdButton.BackgroundImage"), System.Drawing.Image)
        Me.CmdButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.CmdButton.FlatAppearance.BorderSize = 0
        Me.CmdButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray
        Me.CmdButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmdButton.Location = New System.Drawing.Point(250, 5)
        Me.CmdButton.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CmdButton.Name = "CmdButton"
        Me.CmdButton.Size = New System.Drawing.Size(75, 44)
        Me.CmdButton.TabIndex = 9
        Me.CmdButton.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(14.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(494, 382)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.DateLabel)
        Me.Controls.Add(Me.Label)
        Me.Controls.Add(Me.CloseButton)
        Me.Controls.Add(Me.Seperator)
        Me.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Form1"
        Me.Opacity = 0.6R
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "DesktopTool"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label As Label
    Friend WithEvents Timer As Timer
    Friend WithEvents CloseButton As Button
    Friend WithEvents DateLabel As Label
    Friend WithEvents Seperator As Label
    Friend WithEvents ControlButton As Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents CalcButton As Button
    Friend WithEvents CmdButton As Button
End Class
