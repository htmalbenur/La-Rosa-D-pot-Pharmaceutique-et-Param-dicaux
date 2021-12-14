Imports System.Data.SqlClient
Public Class achat

    Public dr As SqlDataReader
    Public cmd As New SqlCommand

    Public dr2 As SqlDataReader
    Public cmd2 As New SqlCommand

    'Dim idpro As Integer ' Variable pour afficher le combo_pro 

    Private Sub affiche()
        ' Pour afficher  les champs dans la listeview
        cn.Open()
        Dim listems As ListViewItem
        Dim str As String = "select * from achat"
        cmd = New SqlCommand(str, cn)
        dr = cmd.ExecuteReader
        ListView.Items.Clear()
        While (dr.Read)
            listems = Me.ListView.Items.Add(dr("id_achat"))
            listems.SubItems.Add(dr("date_achat"))
            listems.SubItems.Add(dr("qte_achat"))
            listems.SubItems.Add(dr("id_prod"))
            listems.SubItems.Add(dr("id_fourn"))
            listems.SubItems.Add(dr("id_users"))
            listems.SubItems.Add(dr("note_achat"))
        End While
        dr.Close()

        ' Pour afficher les Total, Quantite, Montant des produits achetes
        Dim str2 As String = "select count(*), sum(qte_achat), count(distinct id_prod) from achat"
        cmd2 = New SqlCommand(str2, cn)
        dr2 = cmd2.ExecuteReader
        dr2.Read()
        Me.lbl_total.Text = "Nombre Achat : " & dr2.Item(0).ToString
        Me.lbl_qte.Text = "Total Qte : " & dr2.Item(1).ToString
        Me.lbl_prod.Text = "Total Prod : " & dr2.Item(2).ToString
        dr2.Close()
        cn.Close()
    End Sub

    Private Sub achat_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        affiche()
        txt_idadmin.Text = connexion.id 'Pour Affiche id_admin automatic dans la table achat

        ' Cette partie c'est pour le combo_pro pour afficher les Id automatic
        cn.Open()
        Dim str As String = "select libelle from produits"
        cmd = New SqlCommand(str, cn)
        dr = cmd.ExecuteReader
        Combo_pro.Items.Clear()
        While (dr.Read)
            Me.Combo_pro.Items.Add(dr("libelle"))
        End While
        dr.Close()
        cn.Close()
    End Sub

    'Pour afficher dans la liste view
    Private Sub ListView_Click(sender As Object, e As EventArgs) Handles ListView.Click
        If ListView.SelectedItems.Count = 0 Then
            MsgBox("Selectionner un Produit !")
        Else
            cn.Open()
            cmd.CommandText = "select * from achat where id_achat='" & ListView.SelectedItems(0).Text.ToString & "'"
            cmd.ExecuteNonQuery()
            Dim dr As SqlDataReader = cmd.ExecuteReader()
            If dr.Read Then
                Me.txt_ida.Text = dr.Item(0).ToString
                Me.Date_achat.Text = dr.Item(1).ToString
                Me.txt_qtea.Text = dr.Item(2).ToString
                Me.txt_idprod.Text = dr.Item(3).ToString
                Me.txt_id_four.Text = dr.Item(4).ToString
                Me.txt_idadmin.Text = dr.Item(5).ToString
                Me.txt_notea.Text = dr.Item(6).ToString
                dr.Close()
            End If
            cn.Close()
        End If
    End Sub

    ' Pour la recherche dans le menu keyUP
    Private Sub txt_rech_KeyUp(sender As Object, e As KeyEventArgs) Handles txt_rech.KeyUp
        cn.Open()
        Dim listems As ListViewItem
        Dim str As String = "select * from achat where " & combo_rech.Text & " like + @1 + '%'"
        cmd = New SqlCommand(str, cn)
        cmd.Parameters.AddWithValue("@1", txt_rech.Text)
        dr = cmd.ExecuteReader
        ListView.Items.Clear()
        While (dr.Read)
            listems = Me.ListView.Items.Add(dr("id_achat"))
            listems.SubItems.Add(dr("date_achat"))
            listems.SubItems.Add(dr("qte_achat"))
            listems.SubItems.Add(dr("id_prod"))
            listems.SubItems.Add(dr("id_fourn"))
            listems.SubItems.Add(dr("id_users"))
            listems.SubItems.Add(dr("note_achat"))
        End While
        dr.Close()

        ' Pour afficher le Min et le Max lorsquon fait la recherche
        Dim str2 As String = "select count(*), sum(qte_achat), count(distinct id_prod) from achat where " & combo_rech.Text & " like + @1 + '%'"
        cmd2 = New SqlCommand(str2, cn)
        cmd2.Parameters.AddWithValue("@1", txt_rech.Text)
        dr2 = cmd2.ExecuteReader
        dr2.Read()
        Me.lbl_total.Text = "Nombre Achat : " & dr2.Item(0).ToString
        Me.lbl_qte.Text = "Total Qte : " & dr2.Item(1).ToString
        Me.lbl_prod.Text = "Total Prod : " & dr2.Item(2).ToString
        dr2.Close()
        cn.Close()
    End Sub

    ' Pour que le curser reste sur l'endroit ou l'on veut
    Private Sub combo_rech_TextChanged(sender As Object, e As EventArgs) Handles combo_rech.TextChanged
        txt_rech.Text = Nothing
        txt_rech.Focus()
    End Sub

    ' Pour AJOUTER les informations entrees dans le formulaire
    Private Sub btn_enregistrer_Click(sender As Object, e As EventArgs) Handles btn_enregistrer.Click
        ' Message disant il faut remplir tous les champs
        If txt_ida.Text = Nothing Or Date_achat.Text = Nothing Or txt_qtea.Text = Nothing Or txt_idprod.Text = Nothing Or txt_id_four.Text = Nothing Or txt_idadmin.Text = Nothing Or txt_notea.Text = Nothing Then
            MsgBox("Remplir Tous les Champs pour Ajouter !")
        Else
            If MsgBox("Voulez vous Vraiment Ajouter ?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo) = Windows.Forms.DialogResult.Yes Then
                cn.Open()
                cmd.CommandText = "insert into achat values('" & txt_ida.Text & "', '" & Date_achat.Text & "', '" & txt_qtea.Text & "', '" & txt_idprod.Text & "', '" & txt_id_four.Text & "', '" & txt_idadmin.Text & "', '" & txt_notea.Text & "')"
                cmd.ExecuteNonQuery()
                MsgBox("Ajouté avec succès :)")
                cn.Close()
                affiche()
            End If
        End If
    End Sub

    ' Pour MODIFIER les donnees dans le formulaire
    Private Sub btn_modifier_Click(sender As Object, e As EventArgs) Handles btn_modifier.Click
        ' Message disant il faut remplir tous les champs
        If txt_ida.Text = Nothing Or Date_achat.Text = Nothing Or txt_qtea.Text = Nothing Or txt_idprod.Text = Nothing Or txt_id_four.Text = Nothing Or txt_idadmin.Text = Nothing Or txt_notea.Text = Nothing Then
            MsgBox("Remplir Tous les Champs pour Ajouter !")
        Else
            If MsgBox("Voulez vous Vraiment Modifier ?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo) = Windows.Forms.DialogResult.Yes Then
                cn.Open()
                cmd.CommandText = "update achat set date_achat = '" & Date_achat.Text & "', qte_achat =" & txt_qtea.Text & ", id_prod='" & txt_idprod.Text & "', id_fourn=" & txt_id_four.Text & ", id_users='" & txt_idadmin.Text & "', note_achat ='" & txt_notea.Text & "' where id_achat=(" & txt_ida.Text & ") "
                cmd.ExecuteNonQuery()
                MsgBox("Modifier avec succès :)")
                cn.Close()
                affiche()
            End If
        End If
    End Sub


    ' Pour SUPPRIMER dans le formulaire
    Private Sub btn_supprimer_Click(sender As Object, e As EventArgs) Handles btn_supprimer.Click

        ' Message disant il faut remplir tous les champs
        If txt_ida.Text = Nothing Or Date_achat.Text = Nothing Or txt_qtea.Text = Nothing Or txt_idprod.Text = Nothing Or txt_id_four.Text = Nothing Or txt_idadmin.Text = Nothing Or txt_notea.Text = Nothing Then
            MsgBox("Remplir Tous les Champs pour Supprimer !")
        Else
            If MsgBox("Voulez vous Vraiment Supprimer ?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo) = Windows.Forms.DialogResult.Yes Then
                cn.Open()
                cmd.CommandText = " delete from achat where id_achat= '" & txt_ida.Text & "'"
                cmd.ExecuteNonQuery()
                MsgBox("Suppression avec succès :)")
                cn.Close()
                affiche()
            End If
        End If
    End Sub

    ' Pour clear l'iterface du formulaire
    Private Sub btn_nouveau_Click(sender As Object, e As EventArgs) Handles btn_nouveau.Click
        txt_ida.Text = Nothing
        Date_achat.Text = Date.Now
        txt_qtea.Text = Nothing
        txt_idprod.Text = Nothing
        txt_id_four.Text = Nothing
        txt_idadmin.Text = Nothing
        txt_notea.Text = Nothing
        Me.Combo_pro.Text = Nothing
        txt_ida.Focus() ' pour que le curser reste sur la premiere txt_idprod
    End Sub

    Private Sub Combo_pro_TextChanged(sender As Object, e As EventArgs) Handles Combo_pro.TextChanged
        cn.Open()
        Dim str As String = "select id_prod from produits where libelle ='" & Combo_pro.Text & "'"
        cmd = New SqlCommand(str, cn)
        dr = cmd.ExecuteReader
        txt_idprod.Text = Nothing
        While (dr.Read)
            txt_idprod.Text = dr.Item("id_prod").ToString
        End While
        dr.Close()
        cn.Close()
    End Sub
End Class