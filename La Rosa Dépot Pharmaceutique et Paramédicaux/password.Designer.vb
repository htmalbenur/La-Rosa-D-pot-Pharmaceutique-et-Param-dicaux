<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class password
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(password))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txt_login = New System.Windows.Forms.TextBox()
        Me.txt_mp = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Red
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Cooper Black", 18.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(0, 505)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(385, 51)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Valider"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'txt_login
        '
        Me.txt_login.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_login.Location = New System.Drawing.Point(144, 272)
        Me.txt_login.Name = "txt_login"
        Me.txt_login.Size = New System.Drawing.Size(174, 26)
        Me.txt_login.TabIndex = 2
        Me.txt_login.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_mp
        '
        Me.txt_mp.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_mp.Location = New System.Drawing.Point(144, 304)
        Me.txt_mp.Name = "txt_mp"
        Me.txt_mp.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_mp.Size = New System.Drawing.Size(174, 26)
        Me.txt_mp.TabIndex = 3
        Me.txt_mp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.La_Rosa_Dépot_Pharmaceutique_et_Paramédicaux.My.Resources.Resources.Rosa_Print
        Me.PictureBox1.Location = New System.Drawing.Point(103, 38)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(179, 168)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(66, 279)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 19)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Login"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(66, 311)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 19)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Password"
        '
        'password
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Snow
        Me.ClientSize = New System.Drawing.Size(385, 556)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txt_mp)
        Me.Controls.Add(Me.txt_login)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "password"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "password"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As Button
    Friend WithEvents txt_login As TextBox
    Friend WithEvents txt_mp As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
