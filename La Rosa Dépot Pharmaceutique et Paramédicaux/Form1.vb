Imports System.Data.SqlClient

Public Class Form1

    Public dr As SqlDataReader
    Public cmd As New SqlCommand

    Public dr2 As SqlDataReader
    Public cmd2 As New SqlCommand

    'Pour afficher la liste view dans produits
    Private Sub afficher()
        cn.Open()
        Dim listems As ListViewItem
        Dim str As String = "select * from produits"
        cmd = New SqlCommand(str, cn)
        dr = cmd.ExecuteReader
        ListView.Items.Clear()
        While (dr.Read)
            listems = Me.ListView.Items.Add(dr("id_prod"))
            listems.SubItems.Add(dr("libelle"))
            listems.SubItems.Add(dr("pu_prod"))
            listems.SubItems.Add(dr("type_prod"))
            listems.SubItems.Add(dr("prix_vente"))
            listems.SubItems.Add(dr("note_prod"))
            listems.SubItems.Add(dr("code_barre"))
        End While
        dr.Close()

        ' Pour afficher les MAX et les MIN dans le Formulaire Produits
        Dim str2 As String = "select count(*) as total, max(pu_prod) as maxpu, min(pu_prod) as minpu from produits"
        cmd2 = New SqlCommand(str2, cn)
        dr2 = cmd2.ExecuteReader
        dr2.Read()
        Me.lbl_total.Text = "Nombre Produits : " & dr2.Item(0).ToString
        Me.lbl_pumax.Text = "Prix Max Produits : " & dr2.Item(1).ToString
        Me.lbl_pumin.Text = "Prix Min Produits : " & dr2.Item(2).ToString
        dr2.Close()


        cn.Close()
    End Sub
    'Pour afficher le Combobox Type_Produit dans la forme produit
    Private Sub type()
        cn.Open()
        Dim str As String = "select distinct type_prod from produits"
        cmd = New SqlCommand(str, cn)
        dr = cmd.ExecuteReader
        While (dr.Read)
            Me.Combo_type.Items.Add(dr("type_prod")).ToString()
        End While
        dr.Close()
        cn.Close()
    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        afficher()
        type()
    End Sub

    'Configuration du bouton AJOUTER
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_enregistrer.Click

        ' Pour dire qu'il faut remplir tous les champs
        If txt_Idprod.Text = Nothing Or txt_libelle.Text = Nothing Or txt_pu.Text = Nothing Or Combo_type.Text = Nothing Or txt_pv.Text = Nothing Or txt_note.Text = Nothing Or txt_cb.Text = Nothing Then
            MsgBox("Remplir Tous les Champs pour Ajouter !")
        Else
            If MsgBox("Voulez vous Vraiment Ajouter ?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo) = Windows.Forms.DialogResult.Yes Then
                cn.Open()
                cmd.CommandText = "insert into produits values('" & txt_Idprod.Text & "', '" & txt_libelle.Text & "', '" & txt_pu.Text & "', '" & Combo_type.Text & "', '" & txt_pv.Text & "', '" & txt_note.Text & "', '" & txt_cb.Text & "')"
                cmd.ExecuteNonQuery()
                MsgBox("Ajouté avec succès :!")
                cn.Close()
                afficher()
            End If
        End If
    End Sub
    ' Pour AFFICHER les informations dans le tableau a partir de listview
    Private Sub ListView_Click(sender As Object, e As EventArgs) Handles ListView.Click
        If ListView.SelectedItems.Count = 0 Then
            MsgBox("Selectionner un Produit !")
        Else
            cn.Open()
            cmd.CommandText = "select * from produits where id_prod='" & ListView.SelectedItems(0).Text.ToString & "'"
            cmd.ExecuteNonQuery()
            Dim dr As SqlDataReader = cmd.ExecuteReader()
            If dr.Read Then
                Me.txt_Idprod.Text = dr.Item(0).ToString
                Me.txt_libelle.Text = dr.Item(1).ToString
                Me.txt_pu.Text = dr.Item(2).ToString
                Me.Combo_type.Text = dr.Item(3).ToString
                Me.txt_pv.Text = dr.Item(4).ToString
                Me.txt_note.Text = dr.Item(5).ToString
                Me.txt_cb.Text = dr.Item(6).ToString
                dr.Close()
            End If

            ' Pour remplir le Tableau quantites achats provenant dans le formulaire ACHAT
            Dim str2 As String = " select COALESCE(sum(COALESCE(qte_achat,0)),0) from achat where id_prod ='" & ListView.SelectedItems(0).Text.ToString & "' "
            cmd2 = New SqlCommand(str2, cn)
            dr2 = cmd2.ExecuteReader
            If dr2.Read Then
                lbl_achat.Text = dr2.Item(0).ToString
                dr2.Close()
            End If

            ' Pour remplir le Tableau quantites achats provenant dans le formulaire ACHAT
            Dim str3 As String = " select COALESCE(sum(COALESCE(qte_vente,0)),0) from vente where id_prod ='" & ListView.SelectedItems(0).Text.ToString & "' "
            cmd2 = New SqlCommand(str3, cn)
            dr2 = cmd2.ExecuteReader
            If dr2.Read Then
                lbl_vente.Text = dr2.Item(0).ToString
                dr2.Close()
            End If

            ' Code pour controler le STOCK
            lbl_stock.Text = lbl_achat.Text - lbl_vente.Text

            cn.Close()

        End If
    End Sub

    ' Pour MODIFIER les Informations entree dans le formulaire
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btn_modifier.Click
        If txt_Idprod.Text = Nothing Or txt_libelle.Text = Nothing Or txt_pu.Text = Nothing Or Combo_type.Text = Nothing Or txt_pv.Text = Nothing Or txt_note.Text = Nothing Or txt_cb.Text = Nothing Then
            MsgBox("Remplir Tous les Champs pour Modifier !")
        Else
            If MsgBox("Voulez vous Vraiment Modifier ?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo) = Windows.Forms.DialogResult.Yes Then
                cn.Open()
                cmd.CommandText = "update produits set libelle='" & txt_libelle.Text & "', pu_prod=" & txt_pu.Text & ", type_prod='" & Combo_type.Text & "', prix_vente=" & txt_pv.Text & ", note_prod='" & txt_note.Text & "', code_barre='" & txt_cb.Text & "' where id_prod=(" & txt_Idprod.Text & ") "
                cmd.ExecuteNonQuery()
                MsgBox("Modifier avec succès : !")
                cn.Close()
                afficher()
            End If
        End If
    End Sub

    ' Pour SUPPRIMER les enregistrement entre dans le formulaire

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btn_supprimer.Click
        If txt_Idprod.Text = Nothing Or txt_libelle.Text = Nothing Or txt_pu.Text = Nothing Or Combo_type.Text = Nothing Or txt_pv.Text = Nothing Or txt_note.Text = Nothing Or txt_cb.Text = Nothing Then
            MsgBox("Remplir Tous les Champs pour Supprimer !")
        Else
            If MsgBox("Voulez vous Vraiment Supprimer ?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo) = Windows.Forms.DialogResult.Yes Then
                cn.Open()
                cmd.CommandText = " delete from produits where id_prod= '" & txt_Idprod.Text & "'"
                cmd.ExecuteNonQuery()
                MsgBox("Suppression avec succès : !")
                cn.Close()
                afficher()
            End If
        End If

    End Sub

    ' Pour Ajouter un nouveau enregistrement ..... pour clear l'interface du formulaire
    Private Sub btn_nv_Click(sender As Object, e As EventArgs) Handles btn_nouveau.Click
        txt_Idprod.Text = Nothing
        txt_libelle.Text = Nothing
        txt_pu.Text = Nothing
        Combo_type.Text = Nothing
        txt_pv.Text = Nothing
        txt_note.Text = Nothing
        txt_cb.Text = Nothing
        txt_Idprod.Focus() ' pour que le curser reste sur la premiere txt_idprod

    End Sub

    ' Pour le module de recher dans le formulaire
    Private Sub TextBox1_KeyUp(sender As Object, e As KeyEventArgs) Handles txt_rech.KeyUp
        cn.Open()
        Dim listems As ListViewItem
        Dim str As String = "select * from produits where " & combo_rech.Text & " like + @1 + '%'"
        cmd = New SqlCommand(str, cn)
        cmd.Parameters.AddWithValue("@1", txt_rech.Text)
        dr = cmd.ExecuteReader
        ListView.Items.Clear()
        While (dr.Read)
            listems = Me.ListView.Items.Add(dr("id_prod"))
            listems.SubItems.Add(dr("libelle"))
            listems.SubItems.Add(dr("pu_prod"))
            listems.SubItems.Add(dr("type_prod"))
            listems.SubItems.Add(dr("prix_vente"))
            listems.SubItems.Add(dr("note_prod"))
            listems.SubItems.Add(dr("code_barre"))
        End While
        dr.Close()

        ' Pour afficher le Min et le Max lorsquon fait la recherche
        Dim str2 As String = "select count(*) as total, max(pu_prod) as maxpu, min(pu_prod) as minpu from produits where " & combo_rech.Text & " like + @1 + '%'"
        cmd2 = New SqlCommand(str2, cn)
        cmd2.Parameters.AddWithValue("@1", txt_rech.Text)
        dr2 = cmd2.ExecuteReader
        dr2.Read()
        Me.lbl_total.Text = "Nombre Produits : " & dr2.Item(0).ToString
        Me.lbl_pumax.Text = "Prix Max Produits : " & dr2.Item(1).ToString
        Me.lbl_pumin.Text = "Prix Min Produits : " & dr2.Item(2).ToString

        dr2.Close()
        cn.Close()
    End Sub

    Private Sub combo_rech_TextChanged(sender As Object, e As EventArgs) Handles combo_rech.TextChanged
        ' Pour que le curser reste focus sur le champ recherche
        txt_rech.Text = Nothing
        txt_rech.Focus()
    End Sub


End Class
