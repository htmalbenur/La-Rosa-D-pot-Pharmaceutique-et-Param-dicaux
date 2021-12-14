Imports System.Data.SqlClient

Public Class client

    Public dr As SqlDataReader
    Public cmd As New SqlCommand

    Private Sub affiche()
        'Pour afficher la liste view dans client
        cn.Open()
        Dim listems As ListViewItem
        Dim str As String = "select * from client"
        cmd = New SqlCommand(str, cn)
        dr = cmd.ExecuteReader
        ListView.Items.Clear()
        While (dr.Read)
            listems = Me.ListView.Items.Add(dr("id_client"))
            listems.SubItems.Add(dr("nom_client"))
            listems.SubItems.Add(dr("adresse_client"))
            listems.SubItems.Add(dr("tel_client"))
            listems.SubItems.Add(dr("note_client"))
        End While
        dr.Close()
        cn.Close()
    End Sub





    Private Sub client_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        affiche()
    End Sub

    ' Pour Ajouter un nouveau enregistrement ..... pour clear l'interface du formulaire
    Private Sub btn_nouveau_Click(sender As Object, e As EventArgs) Handles btn_nouveau.Click
        txt_idclient.Text = Nothing
        txt_nomclient.Text = Nothing
        txt_adresseclient.Text = Nothing
        txt_telclient.Text = Nothing
        txt_noteclient.Text = Nothing
        txt_idclient.Focus() ' pour que le curser reste sur la premiere txt_idprod
    End Sub

    Private Sub ListView_Click(sender As Object, e As EventArgs) Handles ListView.Click
        ' Pour AFFICHER les informations dans le tableau a partir de listview
        If ListView.SelectedItems.Count = 0 Then
            MsgBox("Selectionner un Produit !")
        Else
            cn.Open()
            cmd.CommandText = "select * from client where id_client='" & ListView.SelectedItems(0).Text.ToString & "'"
            cmd.ExecuteNonQuery()
            Dim dr As SqlDataReader = cmd.ExecuteReader()
            If dr.Read Then
                Me.txt_idclient.Text = dr.Item(0).ToString
                Me.txt_nomclient.Text = dr.Item(1).ToString
                Me.txt_adresseclient.Text = dr.Item(2).ToString
                Me.txt_telclient.Text = dr.Item(3).ToString
                Me.txt_noteclient.Text = dr.Item(4).ToString
                dr.Close()
            End If
            cn.Close()
        End If
    End Sub

    ' Bouton pour ENREGISTRER
    Private Sub btn_enregistrer_Click(sender As Object, e As EventArgs) Handles btn_enregistrer.Click
        ' Pour dire qu'il faut remplir tous les champs
        If txt_idclient.Text = Nothing Or txt_nomclient.Text = Nothing Or txt_adresseclient.Text = Nothing Or txt_telclient.Text = Nothing Or txt_noteclient.Text = Nothing Then
            MsgBox("Remplir Tous les Champs pour Ajouter !")
        Else
            If MsgBox("Voulez vous Vraiment Ajouter ?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo) = Windows.Forms.DialogResult.Yes Then
                cn.Open()
                cmd.CommandText = "insert into client values('" & txt_idclient.Text & "', '" & txt_nomclient.Text & "', '" & txt_adresseclient.Text & "',  '" & txt_telclient.Text & "', '" & txt_noteclient.Text & "')"
                cmd.ExecuteNonQuery()
                MsgBox("Ajouté avec succès :!")
                cn.Close()
                affiche()
            End If
        End If
    End Sub

    ' Pour le Bouton MODIFIER
    Private Sub btn_modifier_Click(sender As Object, e As EventArgs) Handles btn_modifier.Click
        ' Pour dire qu'il faut remplir tous les champs
        If txt_idclient.Text = Nothing Or txt_nomclient.Text = Nothing Or txt_adresseclient.Text = Nothing Or txt_telclient.Text = Nothing Or txt_noteclient.Text = Nothing Then
            MsgBox("Remplir Tous les Champs pour Ajouter !")
        Else
            If MsgBox("Voulez vous Vraiment Modifier ?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo) = Windows.Forms.DialogResult.Yes Then
                cn.Open()
                cmd.CommandText = "update client set nom_client ='" & txt_nomclient.Text & "', adresse_client = '" & txt_adresseclient.Text & "', tel_client = '" & txt_telclient.Text & "', note_client = '" & txt_noteclient.Text & "' where id_client = (" & txt_idclient.Text & ") "
                cmd.ExecuteNonQuery()
                MsgBox("Modifier avec succès :!")
                cn.Close()
                affiche()
            End If
        End If
    End Sub

    'Pour le Bouton Supprimer
    Private Sub btn_supprimer_Click(sender As Object, e As EventArgs) Handles btn_supprimer.Click
        ' Pour dire qu'il faut remplir tous les champs
        If txt_idclient.Text = Nothing Or txt_nomclient.Text = Nothing Or txt_adresseclient.Text = Nothing Or txt_telclient.Text = Nothing Or txt_noteclient.Text = Nothing Then
            MsgBox("Remplir Tous les Champs pour Ajouter !")
        Else

            If MsgBox("Voulez vous Vraiment Supprimer ?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo) = Windows.Forms.DialogResult.Yes Then
                cn.Open()
                cmd.CommandText = " delete from client where id_client = '" & txt_idclient.Text & "'"
                cmd.ExecuteNonQuery()
                MsgBox("Suppression avec succès :!")
                cn.Close()
                affiche()
            End If
        End If
    End Sub
End Class