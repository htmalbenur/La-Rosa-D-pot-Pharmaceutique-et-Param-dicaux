Imports System.Data.SqlClient

Public Class fournisseur

    Public dr As SqlDataReader
    Public cmd As New SqlCommand

    'Pour afficher la liste view dans produits
    Private Sub affiche()
        cn.Open()
        Dim listems As ListViewItem
        Dim str As String = "select * from fournisseur"
        cmd = New SqlCommand(str, cn)
        dr = cmd.ExecuteReader
        ListView.Items.Clear()
        While (dr.Read)
            listems = Me.ListView.Items.Add(dr("id_fourn"))
            listems.SubItems.Add(dr("nom_fourn"))
            listems.SubItems.Add(dr("adresse_fourn"))
            listems.SubItems.Add(dr("tel_fourn"))
            listems.SubItems.Add(dr("note_fourn"))
        End While
        dr.Close()
        cn.Close()
    End Sub

    Private Sub fournisseur_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        affiche()
    End Sub

    ' Pour Ajouter un nouveau enregistrement ..... pour clear l'interface du formulaire
    Private Sub btn_nouveau_Click(sender As Object, e As EventArgs) Handles btn_nouveau.Click
        txt_Idfourn.Text = Nothing
        txt_nom.Text = Nothing
        txt_adresse.Text = Nothing
        txt_tele.Text = Nothing
        txt_note.Text = Nothing
        txt_Idfourn.Focus() ' pour que le curser reste sur la premiere txt_idprod
    End Sub

    ' Pour AFFICHER les informations dans le tableau a partir de listview
    Private Sub ListView_Click(sender As Object, e As EventArgs) Handles ListView.Click
        If ListView.SelectedItems.Count = 0 Then
            MsgBox("Selectionner un Produit !")
        Else
            cn.Open()
            cmd.CommandText = "select * from fournisseur where id_fourn='" & ListView.SelectedItems(0).Text.ToString & "'"
            cmd.ExecuteNonQuery()
            Dim dr As SqlDataReader = cmd.ExecuteReader()
            If dr.Read Then
                Me.txt_Idfourn.Text = dr.Item(0).ToString
                Me.txt_nom.Text = dr.Item(1).ToString
                Me.txt_adresse.Text = dr.Item(2).ToString
                Me.txt_tele.Text = dr.Item(3).ToString
                Me.txt_note.Text = dr.Item(4).ToString
                dr.Close()
            End If
            cn.Close()
        End If
    End Sub

    Private Sub btn_enregistrer_Click(sender As Object, e As EventArgs) Handles btn_enregistrer.Click
        ' Pour dire qu'il faut remplir tous les champs
        If txt_Idfourn.Text = Nothing Or txt_nom.Text = Nothing Or txt_adresse.Text = Nothing Or txt_tele.Text = Nothing Or txt_note.Text = Nothing Then
            MsgBox("Remplir Tous les Champs pour Ajouter !")
        Else
            If MsgBox("Voulez vous Vraiment Ajouter ?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo) = Windows.Forms.DialogResult.Yes Then
                cn.Open()
                cmd.CommandText = "insert into fournisseur values('" & txt_Idfourn.Text & "', '" & txt_nom.Text & "', '" & txt_adresse.Text & "',  '" & txt_tele.Text & "', '" & txt_note.Text & "')"
                cmd.ExecuteNonQuery()
                MsgBox("Ajouté avec succès :)")
                cn.Close()
                affiche()
            End If
        End If
    End Sub

    ' Bouton Pour MODIFIER le Formulaire
    Private Sub btn_modifier_Click(sender As Object, e As EventArgs) Handles btn_modifier.Click

        ' Pour dire qu'il faut remplir tous les champs
        If txt_Idfourn.Text = Nothing Or txt_nom.Text = Nothing Or txt_adresse.Text = Nothing Or txt_tele.Text = Nothing Or txt_note.Text = Nothing Then
            MsgBox("Remplir Tous les Champs pour Modifier !")
        Else
            If MsgBox("Voulez vous Vraiment Modifier ?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo) = Windows.Forms.DialogResult.Yes Then
                cn.Open()
                cmd.CommandText = "update fournisseur set nom_fourn ='" & txt_nom.Text & "', adresse_fourn = '" & txt_adresse.Text & "', tel_fourn = '" & txt_tele.Text & "', note_fourn = '" & txt_note.Text & "' where id_fourn = (" & txt_Idfourn.Text & ") "
                cmd.ExecuteNonQuery()
                MsgBox("Modifier avec succès :)")
                cn.Close()
                affiche()
            End If
        End If
    End Sub


    ' Bouton Pour Supprimer dans le formulaire

    Private Sub btn_supprimer_Click(sender As Object, e As EventArgs) Handles btn_supprimer.Click

        If txt_Idfourn.Text = Nothing Or txt_nom.Text = Nothing Or txt_adresse.Text = Nothing Or txt_tele.Text = Nothing Or txt_note.Text = Nothing Then
            MsgBox("Remplir Tous les Champs pour Modifier !")
        Else
            If MsgBox("Voulez vous Vraiment Supprimer ?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo) = Windows.Forms.DialogResult.Yes Then
                cn.Open()
                cmd.CommandText = " delete from fournisseur where id_fourn = '" & txt_Idfourn.Text & "'"
                cmd.ExecuteNonQuery()
                MsgBox("Suppression avec succès :)")
                cn.Close()
                affiche()
            End If
        End If
    End Sub
End Class