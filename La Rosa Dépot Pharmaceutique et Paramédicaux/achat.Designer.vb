<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class achat
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(achat))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Date_achat = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_qtea = New System.Windows.Forms.TextBox()
        Me.txt_notea = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btn_supprimer = New System.Windows.Forms.Button()
        Me.btn_modifier = New System.Windows.Forms.Button()
        Me.btn_nouveau = New System.Windows.Forms.Button()
        Me.btn_enregistrer = New System.Windows.Forms.Button()
        Me.txt_ida = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_idadmin = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_idprod = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_id_four = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Combo_pro = New System.Windows.Forms.ComboBox()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.ListView = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.lbl_prod = New System.Windows.Forms.Label()
        Me.lbl_qte = New System.Windows.Forms.Label()
        Me.lbl_total = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.txt_rech = New System.Windows.Forms.TextBox()
        Me.combo_rech = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Green
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Date_achat)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txt_qtea)
        Me.Panel1.Controls.Add(Me.txt_notea)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.btn_supprimer)
        Me.Panel1.Controls.Add(Me.btn_modifier)
        Me.Panel1.Controls.Add(Me.btn_nouveau)
        Me.Panel1.Controls.Add(Me.btn_enregistrer)
        Me.Panel1.Controls.Add(Me.txt_ida)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txt_idadmin)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.txt_idprod)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.txt_id_four)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Location = New System.Drawing.Point(4, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(980, 210)
        Me.Panel1.TabIndex = 7
        '
        'Date_achat
        '
        Me.Date_achat.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Date_achat.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Date_achat.Location = New System.Drawing.Point(758, 21)
        Me.Date_achat.Name = "Date_achat"
        Me.Date_achat.Size = New System.Drawing.Size(200, 26)
        Me.Date_achat.TabIndex = 52
        Me.Date_achat.Value = New Date(2021, 9, 6, 0, 0, 0, 0)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(711, 28)
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
        Me.Label3.Location = New System.Drawing.Point(677, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 19)
        Me.Label3.TabIndex = 48
        Me.Label3.Text = "Qte Achat"
        '
        'txt_qtea
        '
        Me.txt_qtea.BackColor = System.Drawing.Color.GhostWhite
        Me.txt_qtea.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_qtea.Location = New System.Drawing.Point(758, 53)
        Me.txt_qtea.Name = "txt_qtea"
        Me.txt_qtea.Size = New System.Drawing.Size(200, 26)
        Me.txt_qtea.TabIndex = 50
        '
        'txt_notea
        '
        Me.txt_notea.BackColor = System.Drawing.Color.GhostWhite
        Me.txt_notea.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_notea.Location = New System.Drawing.Point(681, 85)
        Me.txt_notea.Multiline = True
        Me.txt_notea.Name = "txt_notea"
        Me.txt_notea.Size = New System.Drawing.Size(277, 101)
        Me.txt_notea.TabIndex = 51
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(633, 167)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 19)
        Me.Label6.TabIndex = 49
        Me.Label6.Text = "Note "
        '
        'btn_supprimer
        '
        Me.btn_supprimer.BackColor = System.Drawing.Color.Red
        Me.btn_supprimer.FlatAppearance.BorderSize = 0
        Me.btn_supprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_supprimer.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_supprimer.ForeColor = System.Drawing.Color.White
        Me.btn_supprimer.Location = New System.Drawing.Point(347, 151)
        Me.btn_supprimer.Name = "btn_supprimer"
        Me.btn_supprimer.Size = New System.Drawing.Size(116, 34)
        Me.btn_supprimer.TabIndex = 43
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
        Me.btn_modifier.Location = New System.Drawing.Point(109, 151)
        Me.btn_modifier.Name = "btn_modifier"
        Me.btn_modifier.Size = New System.Drawing.Size(116, 34)
        Me.btn_modifier.TabIndex = 44
        Me.btn_modifier.Text = "Modifier"
        Me.btn_modifier.UseVisualStyleBackColor = False
        '
        'btn_nouveau
        '
        Me.btn_nouveau.BackColor = System.Drawing.Color.Navy
        Me.btn_nouveau.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_nouveau.FlatAppearance.BorderSize = 0
        Me.btn_nouveau.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_nouveau.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_nouveau.ForeColor = System.Drawing.Color.White
        Me.btn_nouveau.Location = New System.Drawing.Point(109, 111)
        Me.btn_nouveau.Name = "btn_nouveau"
        Me.btn_nouveau.Size = New System.Drawing.Size(116, 34)
        Me.btn_nouveau.TabIndex = 45
        Me.btn_nouveau.Text = "Nouveau"
        Me.btn_nouveau.UseVisualStyleBackColor = False
        '
        'btn_enregistrer
        '
        Me.btn_enregistrer.BackColor = System.Drawing.Color.DarkViolet
        Me.btn_enregistrer.FlatAppearance.BorderSize = 0
        Me.btn_enregistrer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_enregistrer.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_enregistrer.ForeColor = System.Drawing.Color.White
        Me.btn_enregistrer.Location = New System.Drawing.Point(347, 111)
        Me.btn_enregistrer.Name = "btn_enregistrer"
        Me.btn_enregistrer.Size = New System.Drawing.Size(116, 34)
        Me.btn_enregistrer.TabIndex = 46
        Me.btn_enregistrer.Text = "Enregistrer"
        Me.btn_enregistrer.UseVisualStyleBackColor = False
        '
        'txt_ida
        '
        Me.txt_ida.BackColor = System.Drawing.Color.GhostWhite
        Me.txt_ida.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ida.Location = New System.Drawing.Point(93, 31)
        Me.txt_ida.Name = "txt_ida"
        Me.txt_ida.Size = New System.Drawing.Size(116, 26)
        Me.txt_ida.TabIndex = 39
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(18, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 19)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "Id Achat"
        '
        'txt_idadmin
        '
        Me.txt_idadmin.BackColor = System.Drawing.Color.GhostWhite
        Me.txt_idadmin.Enabled = False
        Me.txt_idadmin.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_idadmin.Location = New System.Drawing.Point(496, 31)
        Me.txt_idadmin.Name = "txt_idadmin"
        Me.txt_idadmin.Size = New System.Drawing.Size(116, 26)
        Me.txt_idadmin.TabIndex = 40
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(417, 38)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(69, 19)
        Me.Label7.TabIndex = 36
        Me.Label7.Text = "Id Admin"
        '
        'txt_idprod
        '
        Me.txt_idprod.BackColor = System.Drawing.Color.GhostWhite
        Me.txt_idprod.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_idprod.Location = New System.Drawing.Point(93, 64)
        Me.txt_idprod.Name = "txt_idprod"
        Me.txt_idprod.Size = New System.Drawing.Size(91, 26)
        Me.txt_idprod.TabIndex = 41
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(8, 71)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 19)
        Me.Label4.TabIndex = 37
        Me.Label4.Text = "Id Produit"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(380, 71)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(106, 19)
        Me.Label5.TabIndex = 38
        Me.Label5.Text = "Id Fournisseur"
        '
        'txt_id_four
        '
        Me.txt_id_four.BackColor = System.Drawing.Color.GhostWhite
        Me.txt_id_four.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_id_four.Location = New System.Drawing.Point(496, 64)
        Me.txt_id_four.Name = "txt_id_four"
        Me.txt_id_four.Size = New System.Drawing.Size(116, 26)
        Me.txt_id_four.TabIndex = 42
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.Combo_pro)
        Me.Panel2.Controls.Add(Me.Panel6)
        Me.Panel2.Location = New System.Drawing.Point(4, 11)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(616, 185)
        Me.Panel2.TabIndex = 53
        '
        'Combo_pro
        '
        Me.Combo_pro.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Combo_pro.FormattingEnabled = True
        Me.Combo_pro.Location = New System.Drawing.Point(182, 50)
        Me.Combo_pro.Name = "Combo_pro"
        Me.Combo_pro.Size = New System.Drawing.Size(186, 27)
        Me.Combo_pro.TabIndex = 1
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.DarkGray
        Me.Panel6.Location = New System.Drawing.Point(-1, 81)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(610, 5)
        Me.Panel6.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Location = New System.Drawing.Point(626, 11)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(345, 185)
        Me.Panel3.TabIndex = 54
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
        Me.ListView.Location = New System.Drawing.Point(4, 266)
        Me.ListView.Name = "ListView"
        Me.ListView.Size = New System.Drawing.Size(980, 322)
        Me.ListView.TabIndex = 8
        Me.ListView.UseCompatibleStateImageBehavior = False
        Me.ListView.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Id_Achat"
        Me.ColumnHeader1.Width = 95
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Date"
        Me.ColumnHeader2.Width = 175
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Quantite"
        Me.ColumnHeader3.Width = 112
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Id_Prod"
        Me.ColumnHeader4.Width = 109
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Id_Fourn"
        Me.ColumnHeader5.Width = 93
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Id_Admin"
        Me.ColumnHeader6.Width = 124
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Note"
        Me.ColumnHeader7.Width = 236
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Purple
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.lbl_prod)
        Me.Panel5.Controls.Add(Me.lbl_qte)
        Me.Panel5.Controls.Add(Me.lbl_total)
        Me.Panel5.Location = New System.Drawing.Point(4, 591)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(980, 45)
        Me.Panel5.TabIndex = 10
        '
        'lbl_prod
        '
        Me.lbl_prod.BackColor = System.Drawing.Color.Thistle
        Me.lbl_prod.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_prod.ForeColor = System.Drawing.Color.Black
        Me.lbl_prod.Location = New System.Drawing.Point(624, 5)
        Me.lbl_prod.Name = "lbl_prod"
        Me.lbl_prod.Size = New System.Drawing.Size(288, 32)
        Me.lbl_prod.TabIndex = 0
        Me.lbl_prod.Text = "Label11"
        Me.lbl_prod.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_qte
        '
        Me.lbl_qte.BackColor = System.Drawing.Color.Thistle
        Me.lbl_qte.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_qte.ForeColor = System.Drawing.Color.Black
        Me.lbl_qte.Location = New System.Drawing.Point(306, 5)
        Me.lbl_qte.Name = "lbl_qte"
        Me.lbl_qte.Size = New System.Drawing.Size(288, 32)
        Me.lbl_qte.TabIndex = 0
        Me.lbl_qte.Text = "Label11"
        Me.lbl_qte.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.Panel4.Location = New System.Drawing.Point(4, 216)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(980, 46)
        Me.Panel4.TabIndex = 11
        '
        'txt_rech
        '
        Me.txt_rech.Location = New System.Drawing.Point(253, 12)
        Me.txt_rech.Name = "txt_rech"
        Me.txt_rech.Size = New System.Drawing.Size(160, 20)
        Me.txt_rech.TabIndex = 1
        '
        'combo_rech
        '
        Me.combo_rech.FormattingEnabled = True
        Me.combo_rech.Items.AddRange(New Object() {"id_achat", "date_achat", "qte_achat", "id_prod", "id_fourn", "id_users", "note_achat"})
        Me.combo_rech.Location = New System.Drawing.Point(123, 12)
        Me.combo_rech.Name = "combo_rech"
        Me.combo_rech.Size = New System.Drawing.Size(124, 21)
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
        'achat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MediumOrchid
        Me.ClientSize = New System.Drawing.Size(988, 639)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ListView)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "achat"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "achat"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents ListView As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents Panel5 As Panel
    Friend WithEvents lbl_prod As Label
    Friend WithEvents lbl_qte As Label
    Friend WithEvents lbl_total As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents txt_rech As TextBox
    Friend WithEvents combo_rech As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Date_achat As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_qtea As TextBox
    Friend WithEvents txt_notea As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btn_supprimer As Button
    Friend WithEvents btn_modifier As Button
    Friend WithEvents btn_nouveau As Button
    Friend WithEvents btn_enregistrer As Button
    Friend WithEvents txt_ida As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_idadmin As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_idprod As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_id_four As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Combo_pro As ComboBox
End Class
