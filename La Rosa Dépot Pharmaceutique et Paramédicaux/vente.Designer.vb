<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class vente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(vente))
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.txt_rechv = New System.Windows.Forms.TextBox()
        Me.combo_rechv = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Combo_pro = New System.Windows.Forms.ComboBox()
        Me.lbl_msg_stock = New System.Windows.Forms.Label()
        Me.lbl_stock = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Combo_mov = New System.Windows.Forms.ComboBox()
        Me.Date_vente = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_qtev = New System.Windows.Forms.TextBox()
        Me.txt_puv = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_rn_vente = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btn_supprimer = New System.Windows.Forms.Button()
        Me.btn_modifier = New System.Windows.Forms.Button()
        Me.btn_nouveau = New System.Windows.Forms.Button()
        Me.btn_enregistrer = New System.Windows.Forms.Button()
        Me.txt_idv = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_idadmin = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_pua = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_note = New System.Windows.Forms.TextBox()
        Me.txt_client = New System.Windows.Forms.TextBox()
        Me.txt_idprod = New System.Windows.Forms.TextBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.lbl_3 = New System.Windows.Forms.Label()
        Me.lbl_2 = New System.Windows.Forms.Label()
        Me.lbl_1 = New System.Windows.Forms.Label()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ListView = New System.Windows.Forms.ListView()
        Me.Panel4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.DarkBlue
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.txt_rechv)
        Me.Panel4.Controls.Add(Me.combo_rechv)
        Me.Panel4.Controls.Add(Me.Label10)
        Me.Panel4.Location = New System.Drawing.Point(12, 258)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(964, 46)
        Me.Panel4.TabIndex = 14
        '
        'txt_rechv
        '
        Me.txt_rechv.Location = New System.Drawing.Point(253, 12)
        Me.txt_rechv.Name = "txt_rechv"
        Me.txt_rechv.Size = New System.Drawing.Size(160, 20)
        Me.txt_rechv.TabIndex = 1
        '
        'combo_rechv
        '
        Me.combo_rechv.FormattingEnabled = True
        Me.combo_rechv.Items.AddRange(New Object() {"id_vente", "date_vente", "qte_vente", "pu_achat", "pu_vente", "mouvement", "rn_vente", "id_prod", "id_client", "id_users", "note_vente"})
        Me.combo_rechv.Location = New System.Drawing.Point(123, 12)
        Me.combo_rechv.Name = "combo_rechv"
        Me.combo_rechv.Size = New System.Drawing.Size(124, 21)
        Me.combo_rechv.TabIndex = 1
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
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Blue
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Combo_pro)
        Me.Panel1.Controls.Add(Me.lbl_msg_stock)
        Me.Panel1.Controls.Add(Me.lbl_stock)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Combo_mov)
        Me.Panel1.Controls.Add(Me.Date_vente)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txt_qtev)
        Me.Panel1.Controls.Add(Me.txt_puv)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.txt_rn_vente)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.btn_supprimer)
        Me.Panel1.Controls.Add(Me.btn_modifier)
        Me.Panel1.Controls.Add(Me.btn_nouveau)
        Me.Panel1.Controls.Add(Me.btn_enregistrer)
        Me.Panel1.Controls.Add(Me.txt_idv)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txt_idadmin)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.txt_pua)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.txt_note)
        Me.Panel1.Controls.Add(Me.txt_client)
        Me.Panel1.Controls.Add(Me.txt_idprod)
        Me.Panel1.Location = New System.Drawing.Point(12, 6)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(964, 250)
        Me.Panel1.TabIndex = 12
        '
        'Combo_pro
        '
        Me.Combo_pro.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Combo_pro.FormattingEnabled = True
        Me.Combo_pro.Location = New System.Drawing.Point(206, 41)
        Me.Combo_pro.Name = "Combo_pro"
        Me.Combo_pro.Size = New System.Drawing.Size(264, 27)
        Me.Combo_pro.TabIndex = 16
        '
        'lbl_msg_stock
        '
        Me.lbl_msg_stock.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_msg_stock.ForeColor = System.Drawing.Color.Red
        Me.lbl_msg_stock.Location = New System.Drawing.Point(223, 144)
        Me.lbl_msg_stock.Name = "lbl_msg_stock"
        Me.lbl_msg_stock.Size = New System.Drawing.Size(115, 23)
        Me.lbl_msg_stock.TabIndex = 55
        Me.lbl_msg_stock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_stock
        '
        Me.lbl_stock.AutoSize = True
        Me.lbl_stock.BackColor = System.Drawing.Color.Black
        Me.lbl_stock.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_stock.ForeColor = System.Drawing.Color.Yellow
        Me.lbl_stock.Location = New System.Drawing.Point(397, 19)
        Me.lbl_stock.Name = "lbl_stock"
        Me.lbl_stock.Size = New System.Drawing.Size(73, 19)
        Me.lbl_stock.TabIndex = 54
        Me.lbl_stock.Text = "00000000"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Black
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Yellow
        Me.Label11.Location = New System.Drawing.Point(336, 19)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(56, 19)
        Me.Label11.TabIndex = 54
        Me.Label11.Text = "Stock :"
        '
        'Combo_mov
        '
        Me.Combo_mov.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Combo_mov.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Combo_mov.FormattingEnabled = True
        Me.Combo_mov.Items.AddRange(New Object() {"Payé", "Non Payé"})
        Me.Combo_mov.Location = New System.Drawing.Point(100, 206)
        Me.Combo_mov.Name = "Combo_mov"
        Me.Combo_mov.Size = New System.Drawing.Size(215, 27)
        Me.Combo_mov.TabIndex = 53
        '
        'Date_vente
        '
        Me.Date_vente.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Date_vente.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Date_vente.Location = New System.Drawing.Point(559, 19)
        Me.Date_vente.Name = "Date_vente"
        Me.Date_vente.Size = New System.Drawing.Size(181, 26)
        Me.Date_vente.TabIndex = 52
        Me.Date_vente.Value = New Date(2021, 9, 6, 0, 0, 0, 0)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(511, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 19)
        Me.Label2.TabIndex = 47
        Me.Label2.Text = "Date"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(6, 148)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 19)
        Me.Label3.TabIndex = 48
        Me.Label3.Text = "Qte Vente"
        '
        'txt_qtev
        '
        Me.txt_qtev.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txt_qtev.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_qtev.Location = New System.Drawing.Point(100, 141)
        Me.txt_qtev.Name = "txt_qtev"
        Me.txt_qtev.Size = New System.Drawing.Size(117, 26)
        Me.txt_qtev.TabIndex = 50
        '
        'txt_puv
        '
        Me.txt_puv.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txt_puv.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_puv.Location = New System.Drawing.Point(100, 108)
        Me.txt_puv.Multiline = True
        Me.txt_puv.Name = "txt_puv"
        Me.txt_puv.Size = New System.Drawing.Size(215, 26)
        Me.txt_puv.TabIndex = 51
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(6, 115)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(69, 19)
        Me.Label9.TabIndex = 49
        Me.Label9.Text = "Pu Vente"
        '
        'txt_rn_vente
        '
        Me.txt_rn_vente.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txt_rn_vente.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_rn_vente.Location = New System.Drawing.Point(100, 174)
        Me.txt_rn_vente.Multiline = True
        Me.txt_rn_vente.Name = "txt_rn_vente"
        Me.txt_rn_vente.Size = New System.Drawing.Size(215, 26)
        Me.txt_rn_vente.TabIndex = 51
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(6, 181)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 19)
        Me.Label6.TabIndex = 49
        Me.Label6.Text = "Profit"
        '
        'btn_supprimer
        '
        Me.btn_supprimer.BackColor = System.Drawing.Color.Red
        Me.btn_supprimer.FlatAppearance.BorderSize = 0
        Me.btn_supprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_supprimer.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_supprimer.ForeColor = System.Drawing.Color.White
        Me.btn_supprimer.Location = New System.Drawing.Point(837, 182)
        Me.btn_supprimer.Name = "btn_supprimer"
        Me.btn_supprimer.Size = New System.Drawing.Size(116, 34)
        Me.btn_supprimer.TabIndex = 43
        Me.btn_supprimer.Text = "Supprimer"
        Me.btn_supprimer.UseVisualStyleBackColor = False
        '
        'btn_modifier
        '
        Me.btn_modifier.BackColor = System.Drawing.Color.Firebrick
        Me.btn_modifier.FlatAppearance.BorderSize = 0
        Me.btn_modifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_modifier.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_modifier.ForeColor = System.Drawing.Color.LightCyan
        Me.btn_modifier.Location = New System.Drawing.Point(837, 135)
        Me.btn_modifier.Name = "btn_modifier"
        Me.btn_modifier.Size = New System.Drawing.Size(116, 34)
        Me.btn_modifier.TabIndex = 44
        Me.btn_modifier.Text = "Modifier"
        Me.btn_modifier.UseVisualStyleBackColor = False
        '
        'btn_nouveau
        '
        Me.btn_nouveau.BackColor = System.Drawing.Color.DarkOrchid
        Me.btn_nouveau.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_nouveau.FlatAppearance.BorderSize = 0
        Me.btn_nouveau.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_nouveau.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_nouveau.ForeColor = System.Drawing.Color.White
        Me.btn_nouveau.Location = New System.Drawing.Point(837, 41)
        Me.btn_nouveau.Name = "btn_nouveau"
        Me.btn_nouveau.Size = New System.Drawing.Size(116, 34)
        Me.btn_nouveau.TabIndex = 45
        Me.btn_nouveau.Text = "Nouveau"
        Me.btn_nouveau.UseVisualStyleBackColor = False
        '
        'btn_enregistrer
        '
        Me.btn_enregistrer.BackColor = System.Drawing.Color.MediumVioletRed
        Me.btn_enregistrer.FlatAppearance.BorderSize = 0
        Me.btn_enregistrer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_enregistrer.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_enregistrer.ForeColor = System.Drawing.Color.White
        Me.btn_enregistrer.Location = New System.Drawing.Point(837, 88)
        Me.btn_enregistrer.Name = "btn_enregistrer"
        Me.btn_enregistrer.Size = New System.Drawing.Size(116, 34)
        Me.btn_enregistrer.TabIndex = 46
        Me.btn_enregistrer.Text = "Enregistrer"
        Me.btn_enregistrer.UseVisualStyleBackColor = False
        '
        'txt_idv
        '
        Me.txt_idv.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txt_idv.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_idv.Location = New System.Drawing.Point(100, 9)
        Me.txt_idv.Name = "txt_idv"
        Me.txt_idv.Size = New System.Drawing.Size(215, 26)
        Me.txt_idv.TabIndex = 39
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(6, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 19)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "Id vente"
        '
        'txt_idadmin
        '
        Me.txt_idadmin.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txt_idadmin.Enabled = False
        Me.txt_idadmin.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_idadmin.Location = New System.Drawing.Point(560, 54)
        Me.txt_idadmin.Name = "txt_idadmin"
        Me.txt_idadmin.Size = New System.Drawing.Size(181, 26)
        Me.txt_idadmin.TabIndex = 40
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(486, 96)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(67, 19)
        Me.Label7.TabIndex = 36
        Me.Label7.Text = "Id Client"
        '
        'txt_pua
        '
        Me.txt_pua.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txt_pua.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_pua.Location = New System.Drawing.Point(100, 75)
        Me.txt_pua.Name = "txt_pua"
        Me.txt_pua.Size = New System.Drawing.Size(215, 26)
        Me.txt_pua.TabIndex = 41
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(6, 82)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 19)
        Me.Label4.TabIndex = 37
        Me.Label4.Text = "Pu Achat"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(6, 214)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(90, 19)
        Me.Label8.TabIndex = 38
        Me.Label8.Text = "Mouvement"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(511, 201)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(42, 19)
        Me.Label12.TabIndex = 38
        Me.Label12.Text = "Note"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(484, 61)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(69, 19)
        Me.Label13.TabIndex = 38
        Me.Label13.Text = "Id Admin"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(6, 49)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 19)
        Me.Label5.TabIndex = 38
        Me.Label5.Text = "Id Produit"
        '
        'txt_note
        '
        Me.txt_note.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txt_note.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_note.Location = New System.Drawing.Point(560, 124)
        Me.txt_note.Multiline = True
        Me.txt_note.Name = "txt_note"
        Me.txt_note.Size = New System.Drawing.Size(271, 94)
        Me.txt_note.TabIndex = 42
        '
        'txt_client
        '
        Me.txt_client.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txt_client.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_client.Location = New System.Drawing.Point(560, 89)
        Me.txt_client.Name = "txt_client"
        Me.txt_client.Size = New System.Drawing.Size(181, 26)
        Me.txt_client.TabIndex = 42
        '
        'txt_idprod
        '
        Me.txt_idprod.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txt_idprod.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_idprod.Location = New System.Drawing.Point(100, 42)
        Me.txt_idprod.Name = "txt_idprod"
        Me.txt_idprod.Size = New System.Drawing.Size(100, 26)
        Me.txt_idprod.TabIndex = 42
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Navy
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.lbl_3)
        Me.Panel5.Controls.Add(Me.lbl_2)
        Me.Panel5.Controls.Add(Me.lbl_1)
        Me.Panel5.Location = New System.Drawing.Point(12, 591)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(964, 45)
        Me.Panel5.TabIndex = 15
        '
        'lbl_3
        '
        Me.lbl_3.BackColor = System.Drawing.Color.Thistle
        Me.lbl_3.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_3.ForeColor = System.Drawing.Color.Black
        Me.lbl_3.Location = New System.Drawing.Point(624, 5)
        Me.lbl_3.Name = "lbl_3"
        Me.lbl_3.Size = New System.Drawing.Size(288, 32)
        Me.lbl_3.TabIndex = 0
        Me.lbl_3.Text = "Label11"
        Me.lbl_3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_2
        '
        Me.lbl_2.BackColor = System.Drawing.Color.Thistle
        Me.lbl_2.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_2.ForeColor = System.Drawing.Color.Black
        Me.lbl_2.Location = New System.Drawing.Point(306, 5)
        Me.lbl_2.Name = "lbl_2"
        Me.lbl_2.Size = New System.Drawing.Size(288, 32)
        Me.lbl_2.TabIndex = 0
        Me.lbl_2.Text = "Label11"
        Me.lbl_2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_1
        '
        Me.lbl_1.BackColor = System.Drawing.Color.Thistle
        Me.lbl_1.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_1.ForeColor = System.Drawing.Color.Black
        Me.lbl_1.Location = New System.Drawing.Point(36, 5)
        Me.lbl_1.Name = "lbl_1"
        Me.lbl_1.Size = New System.Drawing.Size(240, 32)
        Me.lbl_1.TabIndex = 0
        Me.lbl_1.Text = "Label11"
        Me.lbl_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Id Vente"
        Me.ColumnHeader1.Width = 73
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Date"
        Me.ColumnHeader2.Width = 80
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Quantite"
        Me.ColumnHeader3.Width = 70
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Pu Achat"
        Me.ColumnHeader4.Width = 80
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Pu Vente"
        Me.ColumnHeader5.Width = 75
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Mouvement"
        Me.ColumnHeader6.Width = 106
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Rn Vente"
        Me.ColumnHeader7.Width = 87
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Id Prod"
        Me.ColumnHeader8.Width = 68
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Id Client"
        Me.ColumnHeader9.Width = 75
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Id Admin"
        Me.ColumnHeader10.Width = 73
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "Note"
        Me.ColumnHeader11.Width = 168
        '
        'ListView
        '
        Me.ListView.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader10, Me.ColumnHeader11})
        Me.ListView.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ListView.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView.FullRowSelect = True
        Me.ListView.HideSelection = False
        Me.ListView.Location = New System.Drawing.Point(12, 307)
        Me.ListView.Name = "ListView"
        Me.ListView.Size = New System.Drawing.Size(964, 283)
        Me.ListView.TabIndex = 13
        Me.ListView.UseCompatibleStateImageBehavior = False
        Me.ListView.View = System.Windows.Forms.View.Details
        '
        'vente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.ClientSize = New System.Drawing.Size(988, 639)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ListView)
        Me.ForeColor = System.Drawing.Color.Navy
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "vente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "vente"
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel4 As Panel
    Friend WithEvents txt_rechv As TextBox
    Friend WithEvents combo_rechv As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_qtev As TextBox
    Friend WithEvents txt_rn_vente As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btn_supprimer As Button
    Friend WithEvents btn_modifier As Button
    Friend WithEvents btn_nouveau As Button
    Friend WithEvents btn_enregistrer As Button
    Friend WithEvents txt_idv As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_pua As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Combo_mov As ComboBox
    Friend WithEvents txt_puv As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents lbl_3 As Label
    Friend WithEvents lbl_2 As Label
    Friend WithEvents lbl_1 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents lbl_stock As Label
    Friend WithEvents lbl_msg_stock As Label
    Friend WithEvents Combo_pro As ComboBox
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents ColumnHeader9 As ColumnHeader
    Friend WithEvents ColumnHeader10 As ColumnHeader
    Friend WithEvents ColumnHeader11 As ColumnHeader
    Friend WithEvents ListView As ListView
    Friend WithEvents Date_vente As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_idadmin As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents txt_note As TextBox
    Friend WithEvents txt_client As TextBox
    Friend WithEvents txt_idprod As TextBox
End Class
