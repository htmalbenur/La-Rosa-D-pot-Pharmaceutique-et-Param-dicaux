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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_Idprod = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_libelle = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_pu = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_pv = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_note = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_cb = New System.Windows.Forms.TextBox()
        Me.Combo_type = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btn_supprimer = New System.Windows.Forms.Button()
        Me.btn_nouveau = New System.Windows.Forms.Button()
        Me.btn_modifier = New System.Windows.Forms.Button()
        Me.btn_enregistrer = New System.Windows.Forms.Button()
        Me.ListView = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lbl_stock = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lbl_vente = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lbl_achat = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.lbl_pumin = New System.Windows.Forms.Label()
        Me.lbl_pumax = New System.Windows.Forms.Label()
        Me.lbl_total = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.txt_rech = New System.Windows.Forms.TextBox()
        Me.combo_rech = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(13, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Id Produit"
        '
        'txt_Idprod
        '
        Me.txt_Idprod.BackColor = System.Drawing.Color.GhostWhite
        Me.txt_Idprod.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Idprod.Location = New System.Drawing.Point(115, 17)
        Me.txt_Idprod.Name = "txt_Idprod"
        Me.txt_Idprod.Size = New System.Drawing.Size(212, 26)
        Me.txt_Idprod.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(13, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 19)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Libelle"
        '
        'txt_libelle
        '
        Me.txt_libelle.BackColor = System.Drawing.Color.GhostWhite
        Me.txt_libelle.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_libelle.Location = New System.Drawing.Point(115, 50)
        Me.txt_libelle.Name = "txt_libelle"
        Me.txt_libelle.Size = New System.Drawing.Size(212, 26)
        Me.txt_libelle.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(13, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 19)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Prix Unitaire "
        '
        'txt_pu
        '
        Me.txt_pu.BackColor = System.Drawing.Color.GhostWhite
        Me.txt_pu.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_pu.Location = New System.Drawing.Point(115, 83)
        Me.txt_pu.Name = "txt_pu"
        Me.txt_pu.Size = New System.Drawing.Size(142, 26)
        Me.txt_pu.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(13, 124)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 19)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Type "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(13, 157)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 19)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Prix Vente"
        '
        'txt_pv
        '
        Me.txt_pv.BackColor = System.Drawing.Color.GhostWhite
        Me.txt_pv.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_pv.Location = New System.Drawing.Point(115, 150)
        Me.txt_pv.Name = "txt_pv"
        Me.txt_pv.Size = New System.Drawing.Size(142, 26)
        Me.txt_pv.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(13, 190)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 19)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Note "
        '
        'txt_note
        '
        Me.txt_note.BackColor = System.Drawing.Color.GhostWhite
        Me.txt_note.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_note.Location = New System.Drawing.Point(115, 183)
        Me.txt_note.Name = "txt_note"
        Me.txt_note.Size = New System.Drawing.Size(212, 26)
        Me.txt_note.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(13, 223)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(87, 19)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Code Barre"
        '
        'txt_cb
        '
        Me.txt_cb.BackColor = System.Drawing.Color.GhostWhite
        Me.txt_cb.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cb.Location = New System.Drawing.Point(115, 216)
        Me.txt_cb.Name = "txt_cb"
        Me.txt_cb.Size = New System.Drawing.Size(212, 26)
        Me.txt_cb.TabIndex = 1
        '
        'Combo_type
        '
        Me.Combo_type.BackColor = System.Drawing.Color.GhostWhite
        Me.Combo_type.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Combo_type.FormattingEnabled = True
        Me.Combo_type.Location = New System.Drawing.Point(115, 116)
        Me.Combo_type.Name = "Combo_type"
        Me.Combo_type.Size = New System.Drawing.Size(212, 27)
        Me.Combo_type.TabIndex = 2
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(292, 89)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(31, 19)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "HT"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(292, 156)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(31, 19)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "HT"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Indigo
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.txt_Idprod)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Combo_type)
        Me.Panel1.Controls.Add(Me.txt_libelle)
        Me.Panel1.Controls.Add(Me.txt_cb)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.txt_pu)
        Me.Panel1.Controls.Add(Me.txt_note)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.txt_pv)
        Me.Panel1.Location = New System.Drawing.Point(19, 13)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(498, 263)
        Me.Panel1.TabIndex = 4
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.btn_supprimer)
        Me.Panel2.Controls.Add(Me.btn_nouveau)
        Me.Panel2.Controls.Add(Me.btn_modifier)
        Me.Panel2.Controls.Add(Me.btn_enregistrer)
        Me.Panel2.Location = New System.Drawing.Point(335, 17)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(148, 225)
        Me.Panel2.TabIndex = 7
        '
        'btn_supprimer
        '
        Me.btn_supprimer.BackColor = System.Drawing.Color.Red
        Me.btn_supprimer.FlatAppearance.BorderSize = 0
        Me.btn_supprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_supprimer.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_supprimer.ForeColor = System.Drawing.Color.White
        Me.btn_supprimer.Location = New System.Drawing.Point(14, 175)
        Me.btn_supprimer.Name = "btn_supprimer"
        Me.btn_supprimer.Size = New System.Drawing.Size(116, 34)
        Me.btn_supprimer.TabIndex = 6
        Me.btn_supprimer.Text = "Supprimer"
        Me.btn_supprimer.UseVisualStyleBackColor = False
        '
        'btn_nouveau
        '
        Me.btn_nouveau.BackColor = System.Drawing.Color.RoyalBlue
        Me.btn_nouveau.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_nouveau.FlatAppearance.BorderSize = 0
        Me.btn_nouveau.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_nouveau.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_nouveau.ForeColor = System.Drawing.Color.White
        Me.btn_nouveau.Location = New System.Drawing.Point(14, 16)
        Me.btn_nouveau.Name = "btn_nouveau"
        Me.btn_nouveau.Size = New System.Drawing.Size(116, 34)
        Me.btn_nouveau.TabIndex = 6
        Me.btn_nouveau.Text = "Nouveau"
        Me.btn_nouveau.UseVisualStyleBackColor = False
        '
        'btn_modifier
        '
        Me.btn_modifier.BackColor = System.Drawing.Color.Maroon
        Me.btn_modifier.FlatAppearance.BorderSize = 0
        Me.btn_modifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_modifier.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_modifier.ForeColor = System.Drawing.Color.LightCyan
        Me.btn_modifier.Location = New System.Drawing.Point(14, 122)
        Me.btn_modifier.Name = "btn_modifier"
        Me.btn_modifier.Size = New System.Drawing.Size(116, 34)
        Me.btn_modifier.TabIndex = 6
        Me.btn_modifier.Text = "Modifier"
        Me.btn_modifier.UseVisualStyleBackColor = False
        '
        'btn_enregistrer
        '
        Me.btn_enregistrer.BackColor = System.Drawing.Color.Green
        Me.btn_enregistrer.FlatAppearance.BorderSize = 0
        Me.btn_enregistrer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_enregistrer.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_enregistrer.ForeColor = System.Drawing.Color.White
        Me.btn_enregistrer.Location = New System.Drawing.Point(14, 69)
        Me.btn_enregistrer.Name = "btn_enregistrer"
        Me.btn_enregistrer.Size = New System.Drawing.Size(116, 34)
        Me.btn_enregistrer.TabIndex = 6
        Me.btn_enregistrer.Text = "Enregistrer"
        Me.btn_enregistrer.UseVisualStyleBackColor = False
        '
        'ListView
        '
        Me.ListView.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7})
        Me.ListView.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ListView.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView.FullRowSelect = True
        Me.ListView.HideSelection = False
        Me.ListView.Location = New System.Drawing.Point(19, 281)
        Me.ListView.Name = "ListView"
        Me.ListView.Size = New System.Drawing.Size(951, 298)
        Me.ListView.TabIndex = 5
        Me.ListView.UseCompatibleStateImageBehavior = False
        Me.ListView.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Id_Produit"
        Me.ColumnHeader1.Width = 100
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Libelle"
        Me.ColumnHeader2.Width = 172
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Prix Unit"
        Me.ColumnHeader3.Width = 88
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Type"
        Me.ColumnHeader4.Width = 133
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Prix Vente"
        Me.ColumnHeader5.Width = 93
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Note"
        Me.ColumnHeader6.Width = 213
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Code Barre"
        Me.ColumnHeader7.Width = 110
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.GroupBox3)
        Me.Panel3.Controls.Add(Me.GroupBox2)
        Me.Panel3.Controls.Add(Me.GroupBox1)
        Me.Panel3.Controls.Add(Me.Panel5)
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Location = New System.Drawing.Point(10, 8)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(969, 623)
        Me.Panel3.TabIndex = 6
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lbl_stock)
        Me.GroupBox3.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.White
        Me.GroupBox3.Location = New System.Drawing.Point(814, 18)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(144, 70)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "En Stock"
        '
        'lbl_stock
        '
        Me.lbl_stock.AutoSize = True
        Me.lbl_stock.BackColor = System.Drawing.Color.Yellow
        Me.lbl_stock.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_stock.ForeColor = System.Drawing.Color.Black
        Me.lbl_stock.Location = New System.Drawing.Point(27, 31)
        Me.lbl_stock.Name = "lbl_stock"
        Me.lbl_stock.Size = New System.Drawing.Size(90, 22)
        Me.lbl_stock.TabIndex = 0
        Me.lbl_stock.Text = "00000000"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lbl_vente)
        Me.GroupBox2.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(664, 18)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(144, 70)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Qte Vente"
        '
        'lbl_vente
        '
        Me.lbl_vente.AutoSize = True
        Me.lbl_vente.BackColor = System.Drawing.Color.Magenta
        Me.lbl_vente.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_vente.ForeColor = System.Drawing.Color.Black
        Me.lbl_vente.Location = New System.Drawing.Point(27, 31)
        Me.lbl_vente.Name = "lbl_vente"
        Me.lbl_vente.Size = New System.Drawing.Size(90, 22)
        Me.lbl_vente.TabIndex = 0
        Me.lbl_vente.Text = "00000000"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lbl_achat)
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(514, 18)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(144, 70)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Qte Achat"
        '
        'lbl_achat
        '
        Me.lbl_achat.AutoSize = True
        Me.lbl_achat.BackColor = System.Drawing.Color.Cyan
        Me.lbl_achat.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_achat.ForeColor = System.Drawing.Color.Black
        Me.lbl_achat.Location = New System.Drawing.Point(27, 31)
        Me.lbl_achat.Name = "lbl_achat"
        Me.lbl_achat.Size = New System.Drawing.Size(90, 22)
        Me.lbl_achat.TabIndex = 0
        Me.lbl_achat.Text = "00000000"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Purple
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.lbl_pumin)
        Me.Panel5.Controls.Add(Me.lbl_pumax)
        Me.Panel5.Controls.Add(Me.lbl_total)
        Me.Panel5.Location = New System.Drawing.Point(8, 573)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(951, 45)
        Me.Panel5.TabIndex = 1
        '
        'lbl_pumin
        '
        Me.lbl_pumin.BackColor = System.Drawing.Color.Thistle
        Me.lbl_pumin.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_pumin.ForeColor = System.Drawing.Color.Black
        Me.lbl_pumin.Location = New System.Drawing.Point(624, 5)
        Me.lbl_pumin.Name = "lbl_pumin"
        Me.lbl_pumin.Size = New System.Drawing.Size(288, 32)
        Me.lbl_pumin.TabIndex = 0
        Me.lbl_pumin.Text = "Label11"
        Me.lbl_pumin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_pumax
        '
        Me.lbl_pumax.BackColor = System.Drawing.Color.Thistle
        Me.lbl_pumax.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_pumax.ForeColor = System.Drawing.Color.Black
        Me.lbl_pumax.Location = New System.Drawing.Point(306, 5)
        Me.lbl_pumax.Name = "lbl_pumax"
        Me.lbl_pumax.Size = New System.Drawing.Size(288, 32)
        Me.lbl_pumax.TabIndex = 0
        Me.lbl_pumax.Text = "Label11"
        Me.lbl_pumax.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_total
        '
        Me.lbl_total.BackColor = System.Drawing.Color.Thistle
        Me.lbl_total.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_total.ForeColor = System.Drawing.Color.Black
        Me.lbl_total.Location = New System.Drawing.Point(36, 5)
        Me.lbl_total.Name = "lbl_total"
        Me.lbl_total.Size = New System.Drawing.Size(240, 32)
        Me.lbl_total.TabIndex = 0
        Me.lbl_total.Text = "Label11"
        Me.lbl_total.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Purple
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.txt_rech)
        Me.Panel4.Controls.Add(Me.combo_rech)
        Me.Panel4.Controls.Add(Me.Label10)
        Me.Panel4.Location = New System.Drawing.Point(508, 221)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(451, 46)
        Me.Panel4.TabIndex = 0
        '
        'txt_rech
        '
        Me.txt_rech.Location = New System.Drawing.Point(258, 12)
        Me.txt_rech.Name = "txt_rech"
        Me.txt_rech.Size = New System.Drawing.Size(186, 20)
        Me.txt_rech.TabIndex = 1
        '
        'combo_rech
        '
        Me.combo_rech.FormattingEnabled = True
        Me.combo_rech.Items.AddRange(New Object() {"libelle", "id_prod", "type_prod", "pu_prod", "prix_vente", "note_prod", "code_barre"})
        Me.combo_rech.Location = New System.Drawing.Point(123, 12)
        Me.combo_rech.Name = "combo_rech"
        Me.combo_rech.Size = New System.Drawing.Size(129, 21)
        Me.combo_rech.TabIndex = 1
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(3, 16)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(119, 17)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Rechercher par :"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkViolet
        Me.ClientSize = New System.Drawing.Size(988, 639)
        Me.Controls.Add(Me.ListView)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Produits"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txt_Idprod As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_libelle As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_pu As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_pv As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_note As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_cb As TextBox
    Friend WithEvents Combo_type As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btn_supprimer As Button
    Friend WithEvents btn_nouveau As Button
    Friend WithEvents btn_modifier As Button
    Friend WithEvents btn_enregistrer As Button
    Friend WithEvents ListView As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label10 As Label
    Friend WithEvents combo_rech As ComboBox
    Friend WithEvents txt_rech As TextBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents lbl_pumin As Label
    Friend WithEvents lbl_pumax As Label
    Friend WithEvents lbl_total As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lbl_achat As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents lbl_stock As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lbl_vente As Label
End Class
