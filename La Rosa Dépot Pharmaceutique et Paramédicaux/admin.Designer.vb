<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class admin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(admin))
        Me.ListView = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.combo_type = New System.Windows.Forms.ComboBox()
        Me.btn_supprimer = New System.Windows.Forms.Button()
        Me.btn_modifier = New System.Windows.Forms.Button()
        Me.btn_nouveau = New System.Windows.Forms.Button()
        Me.btn_enregistrer = New System.Windows.Forms.Button()
        Me.txt_idadm = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_mp = New System.Windows.Forms.TextBox()
        Me.txt_login = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_prenom = New System.Windows.Forms.TextBox()
        Me.txt_nom = New System.Windows.Forms.TextBox()
        Me.txt_note = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_tele = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ListView
        '
        Me.ListView.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8})
        Me.ListView.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ListView.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView.FullRowSelect = True
        Me.ListView.HideSelection = False
        Me.ListView.Location = New System.Drawing.Point(28, 329)
        Me.ListView.Name = "ListView"
        Me.ListView.Size = New System.Drawing.Size(933, 298)
        Me.ListView.TabIndex = 13
        Me.ListView.UseCompatibleStateImageBehavior = False
        Me.ListView.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Id Admin"
        Me.ColumnHeader1.Width = 80
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Login"
        Me.ColumnHeader2.Width = 110
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Password"
        Me.ColumnHeader3.Width = 110
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Nom"
        Me.ColumnHeader4.Width = 120
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Prenom"
        Me.ColumnHeader5.Width = 130
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Telephone"
        Me.ColumnHeader6.Width = 130
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Type"
        Me.ColumnHeader7.Width = 100
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Note"
        Me.ColumnHeader8.Width = 145
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Maroon
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.combo_type)
        Me.Panel1.Controls.Add(Me.btn_supprimer)
        Me.Panel1.Controls.Add(Me.btn_modifier)
        Me.Panel1.Controls.Add(Me.btn_nouveau)
        Me.Panel1.Controls.Add(Me.btn_enregistrer)
        Me.Panel1.Controls.Add(Me.txt_idadm)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txt_mp)
        Me.Panel1.Controls.Add(Me.txt_login)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txt_prenom)
        Me.Panel1.Controls.Add(Me.txt_nom)
        Me.Panel1.Controls.Add(Me.txt_note)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.txt_tele)
        Me.Panel1.Location = New System.Drawing.Point(28, 10)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(933, 315)
        Me.Panel1.TabIndex = 12
        '
        'combo_type
        '
        Me.combo_type.FormattingEnabled = True
        Me.combo_type.Items.AddRange(New Object() {"Admin", "Directeur", "Employe", "Visiteur"})
        Me.combo_type.Location = New System.Drawing.Point(443, 108)
        Me.combo_type.Name = "combo_type"
        Me.combo_type.Size = New System.Drawing.Size(212, 21)
        Me.combo_type.TabIndex = 8
        '
        'btn_supprimer
        '
        Me.btn_supprimer.BackColor = System.Drawing.Color.Red
        Me.btn_supprimer.FlatAppearance.BorderSize = 0
        Me.btn_supprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_supprimer.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_supprimer.ForeColor = System.Drawing.Color.White
        Me.btn_supprimer.Location = New System.Drawing.Point(628, 254)
        Me.btn_supprimer.Name = "btn_supprimer"
        Me.btn_supprimer.Size = New System.Drawing.Size(116, 34)
        Me.btn_supprimer.TabIndex = 6
        Me.btn_supprimer.Text = "Supprimer"
        Me.btn_supprimer.UseVisualStyleBackColor = False
        '
        'btn_modifier
        '
        Me.btn_modifier.BackColor = System.Drawing.Color.Gold
        Me.btn_modifier.FlatAppearance.BorderSize = 0
        Me.btn_modifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_modifier.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_modifier.ForeColor = System.Drawing.Color.LightCyan
        Me.btn_modifier.Location = New System.Drawing.Point(472, 254)
        Me.btn_modifier.Name = "btn_modifier"
        Me.btn_modifier.Size = New System.Drawing.Size(116, 34)
        Me.btn_modifier.TabIndex = 6
        Me.btn_modifier.Text = "Modifier"
        Me.btn_modifier.UseVisualStyleBackColor = False
        '
        'btn_nouveau
        '
        Me.btn_nouveau.BackColor = System.Drawing.Color.RoyalBlue
        Me.btn_nouveau.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_nouveau.FlatAppearance.BorderSize = 0
        Me.btn_nouveau.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_nouveau.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_nouveau.ForeColor = System.Drawing.Color.White
        Me.btn_nouveau.Location = New System.Drawing.Point(186, 254)
        Me.btn_nouveau.Name = "btn_nouveau"
        Me.btn_nouveau.Size = New System.Drawing.Size(116, 34)
        Me.btn_nouveau.TabIndex = 6
        Me.btn_nouveau.Text = "Nouveau"
        Me.btn_nouveau.UseVisualStyleBackColor = False
        '
        'btn_enregistrer
        '
        Me.btn_enregistrer.BackColor = System.Drawing.Color.Green
        Me.btn_enregistrer.FlatAppearance.BorderSize = 0
        Me.btn_enregistrer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_enregistrer.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_enregistrer.ForeColor = System.Drawing.Color.White
        Me.btn_enregistrer.Location = New System.Drawing.Point(329, 254)
        Me.btn_enregistrer.Name = "btn_enregistrer"
        Me.btn_enregistrer.Size = New System.Drawing.Size(116, 34)
        Me.btn_enregistrer.TabIndex = 6
        Me.btn_enregistrer.Text = "Enregistrer"
        Me.btn_enregistrer.UseVisualStyleBackColor = False
        '
        'txt_idadm
        '
        Me.txt_idadm.BackColor = System.Drawing.Color.GhostWhite
        Me.txt_idadm.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_idadm.Location = New System.Drawing.Point(115, 32)
        Me.txt_idadm.Name = "txt_idadm"
        Me.txt_idadm.Size = New System.Drawing.Size(212, 26)
        Me.txt_idadm.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(13, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Id Admin"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(13, 117)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 19)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Password"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(13, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 19)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Login"
        '
        'txt_mp
        '
        Me.txt_mp.BackColor = System.Drawing.Color.GhostWhite
        Me.txt_mp.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_mp.Location = New System.Drawing.Point(115, 110)
        Me.txt_mp.Name = "txt_mp"
        Me.txt_mp.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_mp.Size = New System.Drawing.Size(212, 26)
        Me.txt_mp.TabIndex = 1
        '
        'txt_login
        '
        Me.txt_login.BackColor = System.Drawing.Color.GhostWhite
        Me.txt_login.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_login.Location = New System.Drawing.Point(115, 71)
        Me.txt_login.Name = "txt_login"
        Me.txt_login.Size = New System.Drawing.Size(212, 26)
        Me.txt_login.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(13, 195)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 19)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Prenom"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(13, 156)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 19)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Nom "
        '
        'txt_prenom
        '
        Me.txt_prenom.BackColor = System.Drawing.Color.GhostWhite
        Me.txt_prenom.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_prenom.Location = New System.Drawing.Point(115, 188)
        Me.txt_prenom.Name = "txt_prenom"
        Me.txt_prenom.Size = New System.Drawing.Size(212, 26)
        Me.txt_prenom.TabIndex = 1
        '
        'txt_nom
        '
        Me.txt_nom.BackColor = System.Drawing.Color.GhostWhite
        Me.txt_nom.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nom.Location = New System.Drawing.Point(115, 149)
        Me.txt_nom.Name = "txt_nom"
        Me.txt_nom.Size = New System.Drawing.Size(212, 26)
        Me.txt_nom.TabIndex = 1
        '
        'txt_note
        '
        Me.txt_note.BackColor = System.Drawing.Color.GhostWhite
        Me.txt_note.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_note.Location = New System.Drawing.Point(443, 136)
        Me.txt_note.Multiline = True
        Me.txt_note.Name = "txt_note"
        Me.txt_note.Size = New System.Drawing.Size(301, 78)
        Me.txt_note.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(392, 195)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 19)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Note "
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(396, 110)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(42, 19)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Type"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(360, 82)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 19)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Telephone"
        '
        'txt_tele
        '
        Me.txt_tele.BackColor = System.Drawing.Color.GhostWhite
        Me.txt_tele.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_tele.Location = New System.Drawing.Point(443, 75)
        Me.txt_tele.Name = "txt_tele"
        Me.txt_tele.Size = New System.Drawing.Size(212, 26)
        Me.txt_tele.TabIndex = 1
        '
        'admin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Firebrick
        Me.ClientSize = New System.Drawing.Size(988, 639)
        Me.Controls.Add(Me.ListView)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "admin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "admin"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ListView As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btn_supprimer As Button
    Friend WithEvents btn_modifier As Button
    Friend WithEvents btn_nouveau As Button
    Friend WithEvents btn_enregistrer As Button
    Friend WithEvents txt_idadm As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_login As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_nom As TextBox
    Friend WithEvents txt_note As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_tele As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_mp As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_prenom As TextBox
    Friend WithEvents combo_type As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents ColumnHeader8 As ColumnHeader
End Class
