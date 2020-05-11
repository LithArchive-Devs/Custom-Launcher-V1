<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Port = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.IPAddress = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Window = New System.Windows.Forms.CheckBox()
        Me.Width = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Height = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Name = New System.Windows.Forms.TextBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.FogEnabled = New System.Windows.Forms.CheckBox()
        Me.DrawBox = New System.Windows.Forms.CheckBox()
        Me.Skeletons = New System.Windows.Forms.CheckBox()
        Me.Wireframe = New System.Windows.Forms.CheckBox()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(-1, -1)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(182, 178)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Button1)
        Me.TabPage1.Controls.Add(Me.Port)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.IPAddress)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(174, 152)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "IP:Port"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(9, 84)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(154, 61)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Join"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Port
        '
        Me.Port.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Port.Location = New System.Drawing.Point(6, 58)
        Me.Port.Name = "Port"
        Me.Port.Size = New System.Drawing.Size(162, 20)
        Me.Port.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(70, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Port"
        '
        'IPAddress
        '
        Me.IPAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.IPAddress.Location = New System.Drawing.Point(6, 19)
        Me.IPAddress.Name = "IPAddress"
        Me.IPAddress.Size = New System.Drawing.Size(162, 20)
        Me.IPAddress.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(79, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(17, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "IP"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Button2)
        Me.TabPage2.Controls.Add(Me.Window)
        Me.TabPage2.Controls.Add(Me.Width)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.Height)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.Name)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(174, 152)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Player Setup"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Window
        '
        Me.Window.AutoSize = True
        Me.Window.Location = New System.Drawing.Point(12, 119)
        Me.Window.Name = "Window"
        Me.Window.Size = New System.Drawing.Size(65, 17)
        Me.Window.TabIndex = 7
        Me.Window.Text = "Window"
        Me.Window.UseVisualStyleBackColor = True
        '
        'Width
        '
        Me.Width.Location = New System.Drawing.Point(112, 81)
        Me.Width.Name = "Width"
        Me.Width.Size = New System.Drawing.Size(55, 20)
        Me.Width.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(128, 65)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(35, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Width"
        '
        'Height
        '
        Me.Height.Location = New System.Drawing.Point(3, 81)
        Me.Height.Name = "Height"
        Me.Height.Size = New System.Drawing.Size(55, 20)
        Me.Height.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 65)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Height"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(36, 42)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Screen Resolution"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(51, 3)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Player Name"
        '
        'Name
        '
        Me.Name.Location = New System.Drawing.Point(3, 19)
        Me.Name.Name = "Name"
        Me.Name.Size = New System.Drawing.Size(165, 20)
        Me.Name.TabIndex = 0
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.FogEnabled)
        Me.TabPage3.Controls.Add(Me.DrawBox)
        Me.TabPage3.Controls.Add(Me.Skeletons)
        Me.TabPage3.Controls.Add(Me.Wireframe)
        Me.TabPage3.Controls.Add(Me.CheckBox3)
        Me.TabPage3.Controls.Add(Me.CheckBox2)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(174, 152)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Admin Tab"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'FogEnabled
        '
        Me.FogEnabled.AutoSize = True
        Me.FogEnabled.Location = New System.Drawing.Point(82, 128)
        Me.FogEnabled.Name = "FogEnabled"
        Me.FogEnabled.Size = New System.Drawing.Size(86, 17)
        Me.FogEnabled.TabIndex = 5
        Me.FogEnabled.Text = "Fog Enabled"
        Me.FogEnabled.UseVisualStyleBackColor = True
        '
        'DrawBox
        '
        Me.DrawBox.AutoSize = True
        Me.DrawBox.Location = New System.Drawing.Point(3, 128)
        Me.DrawBox.Name = "DrawBox"
        Me.DrawBox.Size = New System.Drawing.Size(55, 17)
        Me.DrawBox.TabIndex = 4
        Me.DrawBox.Text = "Boxes"
        Me.DrawBox.UseVisualStyleBackColor = True
        '
        'Skeletons
        '
        Me.Skeletons.AutoSize = True
        Me.Skeletons.Location = New System.Drawing.Point(3, 78)
        Me.Skeletons.Name = "Skeletons"
        Me.Skeletons.Size = New System.Drawing.Size(73, 17)
        Me.Skeletons.TabIndex = 3
        Me.Skeletons.Text = "Skeletons"
        Me.Skeletons.UseVisualStyleBackColor = True
        '
        'Wireframe
        '
        Me.Wireframe.AutoSize = True
        Me.Wireframe.Location = New System.Drawing.Point(82, 78)
        Me.Wireframe.Name = "Wireframe"
        Me.Wireframe.Size = New System.Drawing.Size(74, 17)
        Me.Wireframe.TabIndex = 2
        Me.Wireframe.Text = "Wireframe"
        Me.Wireframe.UseVisualStyleBackColor = True
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Location = New System.Drawing.Point(3, 30)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(52, 17)
        Me.CheckBox3.TabIndex = 1
        Me.CheckBox3.Text = "Other"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(82, 30)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(52, 17)
        Me.CheckBox2.TabIndex = 0
        Me.CheckBox2.Text = "Other"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(86, 107)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(77, 38)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(178, 178)
        Me.ControlBox = False
        Me.Controls.Add(Me.TabControl1)
        Me.HelpButton = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "TPSLauncher"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "TPS"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Port As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents IPAddress As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Window As System.Windows.Forms.CheckBox
    Friend WithEvents Width As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Height As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Name As System.Windows.Forms.TextBox
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents FogEnabled As System.Windows.Forms.CheckBox
    Friend WithEvents DrawBox As System.Windows.Forms.CheckBox
    Friend WithEvents Skeletons As System.Windows.Forms.CheckBox
    Friend WithEvents Wireframe As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox3 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents Button2 As System.Windows.Forms.Button

End Class
