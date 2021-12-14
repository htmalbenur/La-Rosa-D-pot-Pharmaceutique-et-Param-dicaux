Imports System.Data.SqlClient

Public Class admin

    Public dr As SqlDataReader
    Public cmd As New SqlCommand

    Public dr2 As SqlDataReader
    Public cmd2 As New SqlCommand

    Private Sub affiche()
        'Pour afficher la liste view dans client
        cn.Open()
        Dim listems As ListViewItem
        Dim str As String = "select * from users"
        cmd = New SqlCommand(str, cn)
        dr = cmd.ExecuteReader
        ListView.Items.Clear()
        While (dr.Read)
            listems = Me.ListView.Items.Add(dr("id_users"))
            listems.SubItems.Add(dr("login_users"))
            listems.SubItems.Add(dr("password_users"))
            listems.SubItems.Add(dr("nom_users"))
            listems.SubItems.Add(dr("prenom_users"))
            listems.SubItems.Add(dr("tel_users"))
            listems.SubItems.Add(dr("type_users"))
            listems.SubItems.Add(dr("note"))

        End While
        dr.Close()
        cn.Close()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
        affiche()
    End Sub

    ' Pour Ajouter un nouveau enregistrement ..... pour clear l'interface du formulaire
    Private Sub btn_nouveau_Click(sender As Object, e As EventArgs) Handles btn_nouveau.Click
        txt_idadm.Text = Nothing
        txt_login.Text = Nothing
        txt_mp.Text = Nothing
        txt_nom.Text = Nothing
        txt_prenom.Text = Nothing
        txt_tele.Text = Nothing
        combo_type.Text = Nothing
        txt_note.Text = Nothing

        txt_idadm.Focus() ' pour que le curser reste sur la premiere txt_idprod
    End Sub


    Private Sub ListView_Click(sender As Object, e As EventArgs) Handles ListView.Click
        ' Pour AFFICHER les informations dans le tableau a partir de listview
        If ListView.SelectedItems.Count = 0 Then
            MsgBox("Selectionner un Admin !")
        Else
            cn.Open()
            cmd.CommandText = "select * from users where id_users='" & ListView.SelectedItems(0).Text.ToString & "'"
            cmd.ExecuteNonQuery()
            Dim dr As SqlDataReader = cmd.ExecuteReader()
            If dr.Read Then
                Me.txt_idadm.Text = dr.Item(0).ToString
                Me.txt_login.Text = dr.Item(1).ToString
                Me.txt_mp.Text = dr.Item(2).ToString
                Me.txt_nom.Text = dr.Item(3).ToString
                Me.txt_prenom.Text = dr.Item(4).ToString
                Me.txt_tele.Text = dr.Item(5).ToString
                Me.combo_type.Text = dr.Item(6).ToString
                Me.txt_note.Text = dr.Item(7).ToString
                dr.Close()
            End If
            cn.Close()
        End If
    End Sub

    ' Pour le Bouton ENREGISTRER
    Private Sub btn_enregistrer_Click(sender As Object, e As EventArgs) Handles btn_enregistrer.Click
        ' Pour dire qu'il faut remplir tous les champs
        If txt_idadm.Text = Nothing Or txt_login.Text = Nothing Or txt_mp.Text = Nothing Or txt_nom.Text = Nothing Or txt_prenom.Text = Nothing Or txt_tele.Text = Nothing Or combo_type.Text = Nothing Or txt_note.Text = Nothing Then
            MsgBox("Remplir Tous les Champs pour Ajouter !")
        Else
            If MsgBox("Voulez vous Vraiment Ajouter ?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo) = Windows.Forms.DialogResult.Yes Then
                cn.Open()
                cmd.CommandText = "insert into users values('" & txt_idadm.Text & "', '" & txt_login.Text & "', '" & txt_mp.Text & "', '" & txt_nom.Text & "', '" & txt_prenom.Text & "', '" & txt_tele.Text & "', '" & combo_type.Text & "', '" & txt_note.Text & "')"
                cmd.ExecuteNonQuery()
                MsgBox("Ajouté avec succès : !")
                cn.Close()
                affiche()
            End If
        End If
    End Sub

    ' Pour le Bouton MODIFIER
    Private Sub btn_modifier_Click(sender As Object, e As EventArgs) Handles btn_modifier.Click
        ' Pour dire qu'il faut remplir tous les champs
        If txt_idadm.Text = Nothing Or txt_login.Text = Nothing Or txt_mp.Text = Nothing Or txt_nom.Text = Nothing Or txt_prenom.Text = Nothing Or txt_tele.Text = Nothing Or combo_type.Text = Nothing Or txt_note.Text = Nothing Then
            MsgBox("Remplir Tous les Champs pour Ajouter !")
        Else
            If MsgBox("Voulez vous Vraiment Modifier ?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo) = Windows.Forms.DialogResult.Yes Then
                cn.Open()
                cmd.CommandText = "update users set login_users ='" & txt_login.Text & "', password_users = '" & txt_mp.Text & "', nom_users = '" & txt_nom.Text & "', prenom_users = '" & txt_prenom.Text & "', tel_users = '" & txt_tele.Text & "', type_users = '" & combo_type.Text & "', note = '" & txt_note.Text & "'  where id_users = (" & txt_idadm.Text & ") "
                cmd.ExecuteNonQuery()
                MsgBox("Modifier avec succès :!")
                cn.Close()
                affiche()
            End If
        End If
    End Sub

    ' Pour le bouton SUPPRIMER
    Private Sub btn_supprimer_Click(sender As Object, e As EventArgs) Handles btn_supprimer.Click
        ' Pour dire qu'il faut remplir tous les champs
        If txt_idadm.Text = Nothing Or txt_login.Text = Nothing Or txt_mp.Text = Nothing Or txt_nom.Text = Nothing Or txt_prenom.Text = Nothing Or txt_tele.Text = Nothing Or combo_type.Text = Nothing Or txt_note.Text = Nothing Then
            MsgBox("Remplir Tous les Champs pour Ajouter !")
        Else
            If MsgBox("Voulez vous Vraiment Supprimer ?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo) = Windows.Forms.DialogResult.Yes Then
                cn.Open()
                cmd.CommandText = " delete from users where id_users = '" & txt_idadm.Text & "'"
                cmd.ExecuteNonQuery()
                MsgBox("Suppression avec succès :!")
                cn.Close()
                affiche()
            End If
        End If
    End Sub


End Class