<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class client
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(client))
        Me.ListView = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_supprimer = New System.Windows.Forms.Button()
        Me.btn_modifier = New System.Windows.Forms.Button()
        Me.btn_nouveau = New System.Windows.Forms.Button()
        Me.btn_enregistrer = New System.Windows.Forms.Button()
        Me.txt_idclient = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_nomclient = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_adresseclient = New System.Windows.Forms.TextBox()
        Me.txt_noteclient = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_telclient = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ListView
        '
        Me.ListView.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5})
        Me.ListView.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ListView.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView.FullRowSelect = True
        Me.ListView.HideSelection = False
        Me.ListView.Location = New System.Drawing.Point(28, 331)
        Me.ListView.Name = "ListView"
        Me.ListView.Size = New System.Drawing.Size(933, 298)
        Me.ListView.TabIndex = 11
        Me.ListView.UseCompatibleStateImageBehavior = False
        Me.ListView.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Id Client"
        Me.ColumnHeader1.Width = 80
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Nom & Prenom"
        Me.ColumnHeader2.Width = 200
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Adresse"
        Me.ColumnHeader3.Width = 350
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Telephone"
        Me.ColumnHeader4.Width = 120
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Note"
        Me.ColumnHeader5.Width = 170
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.IndianRed
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btn_supprimer)
        Me.Panel1.Controls.Add(Me.btn_modifier)
        Me.Panel1.Controls.Add(Me.btn_nouveau)
        Me.Panel1.Controls.Add(Me.btn_enregistrer)
        Me.Panel1.Controls.Add(Me.txt_idclient)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txt_nomclient)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txt_adresseclient)
        Me.Panel1.Controls.Add(Me.txt_noteclient)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.txt_telclient)
        Me.Panel1.Location = New System.Drawing.Point(28, 10)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(933, 315)
        Me.Panel1.TabIndex = 10
        '
        'btn_supprimer
        '
        Me.btn_supprimer.BackColor = System.Drawing.Color.Red
        Me.btn_supprimer.FlatAppearance.BorderSize = 0
        Me.btn_supprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_supprimer.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_supprimer.ForeColor = System.Drawing.Color.White
        Me.btn_supprimer.Location = New System.Drawing.Point(766, 176)
        Me.btn_supprimer.Name = "btn_supprimer"
        Me.btn_supprimer.Size = New System.Drawing.Size(116, 34)
        Me.btn_supprimer.TabIndex = 6
        Me.btn_supprimer.Text = "Supprimer"
        Me.btn_supprimer.UseVisualStyleBackColor = False
        '
        'btn_modifier
        '
        Me.btn_modifier.BackColor = System.Drawing.Color.Maroon
        Me.btn_modifier.FlatAppearance.BorderSize = 0
        Me.btn_modifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_modifier.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_modifier.ForeColor = System.Drawing.Color.LightCyan
        Me.btn_modifier.Location = New System.Drawing.Point(615, 176)
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
        Me.btn_nouveau.Location = New System.Drawing.Point(615, 99)
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
        Me.btn_enregistrer.Location = New System.Drawing.Point(766, 99)
        Me.btn_enregistrer.Name = "btn_enregistrer"
        Me.btn_enregistrer.Size = New System.Drawing.Size(116, 34)
        Me.btn_enregistrer.TabIndex = 6
        Me.btn_enregistrer.Text = "Enregistrer"
        Me.btn_enregistrer.UseVisualStyleBackColor = False
        '
        'txt_idclient
        '
        Me.txt_idclient.BackColor = System.Drawing.Color.GhostWhite
        Me.txt_idclient.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_idclient.Location = New System.Drawing.Point(115, 17)
        Me.txt_idclient.Name = "txt_idclient"
        Me.txt_idclient.Size = New System.Drawing.Size(212, 26)
        Me.txt_idclient.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(13, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Id Client"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(13, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 19)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Nom & Prenom"
        '
        'txt_nomclient
        '
        Me.txt_nomclient.BackColor = System.Drawing.Color.GhostWhite
        Me.txt_nomclient.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nomclient.Location = New System.Drawing.Point(115, 62)
        Me.txt_nomclient.Name = "txt_nomclient"
        Me.txt_nomclient.Size = New System.Drawing.Size(408, 26)
        Me.txt_nomclient.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(13, 114)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 19)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Adresse"
        '
        'txt_adresseclient
        '
        Me.txt_adresseclient.BackColor = System.Drawing.Color.GhostWhite
        Me.txt_adresseclient.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_adresseclient.Location = New System.Drawing.Point(115, 107)
        Me.txt_adresseclient.Name = "txt_adresseclient"
        Me.txt_adresseclient.Size = New System.Drawing.Size(408, 26)
        Me.txt_adresseclient.TabIndex = 1
        '
        'txt_noteclient
        '
        Me.txt_noteclient.BackColor = System.Drawing.Color.GhostWhite
        Me.txt_noteclient.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_noteclient.Location = New System.Drawing.Point(115, 197)
        Me.txt_noteclient.Multiline = True
        Me.txt_noteclient.Name = "txt_noteclient"
        Me.txt_noteclient.Size = New System.Drawing.Size(408, 101)
        Me.txt_noteclient.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(13, 204)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 19)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Note "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(13, 159)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 19)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Telephone"
        '
        'txt_telclient
        '
        Me.txt_telclient.BackColor = System.Drawing.Color.GhostWhite
        Me.txt_telclient.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_telclient.Location = New System.Drawing.Point(115, 152)
        Me.txt_telclient.Name = "txt_telclient"
        Me.txt_telclient.Size = New System.Drawing.Size(212, 26)
        Me.txt_telclient.TabIndex = 1
        '
        'client
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSalmon
        Me.ClientSize = New System.Drawing.Size(988, 639)
        Me.Controls.Add(Me.ListView)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "client"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "client"
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
    Friend WithEvents txt_idclient As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_nomclient As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_adresseclient As TextBox
    Friend WithEvents txt_noteclient As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_telclient As TextBox
End Class
