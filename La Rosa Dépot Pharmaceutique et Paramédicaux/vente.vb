Imports System.Data.SqlClient

Public Class vente

    Public dr As SqlDataReader
    Public cmd As New SqlCommand

    Public dr2 As SqlDataReader
    Public cmd2 As New SqlCommand

    Private Sub affiche()

        ' Pour afficher  les champs dans la listeview
        cn.Open()
        Dim listems As ListViewItem
        Dim str As String = "select * from vente"
        cmd = New SqlCommand(str, cn)
        dr = cmd.ExecuteReader
        ListView.Items.Clear()
        While (dr.Read)
            listems = Me.ListView.Items.Add(dr("id_vente"))
            listems.SubItems.Add(dr("date_vente"))
            listems.SubItems.Add(dr("qte_vente"))
            listems.SubItems.Add(dr("pu_achat"))
            listems.SubItems.Add(dr("pu_vente"))
            listems.SubItems.Add(dr("mouvement"))
            listems.SubItems.Add(dr("rn_vente"))
            listems.SubItems.Add(dr("id_prod"))
            listems.SubItems.Add(dr("id_client"))
            listems.SubItems.Add(dr("id_users"))
            listems.SubItems.Add(dr("note_vente"))
        End While
        dr.Close()

        Dim str2 As String = "select count(*), sum(qte_vente), sum(rn_vente) from vente "
        cmd2 = New SqlCommand(str2, cn)
        dr2 = cmd2.ExecuteReader
        dr2.Read()
        Me.lbl_1.Text = "Nombre Vente : " & dr2.Item(0).ToString
        Me.lbl_2.Text = "T. Qte : " & dr2.Item(1).ToString
        Me.lbl_3.Text = "Profit : " & dr2.Item(2).ToString
        dr2.Close()
        cn.Close()
    End Sub

    ' Pour afficher automatiquement le prix Unitaire et le prix de vente dans le formulaire vente
    Private Sub txt_idprod_KeyUp(sender As Object, e As KeyEventArgs) Handles txt_idprod.KeyUp

        Dim achat As Integer
        Dim vente As Integer

        cn.Open()
        Dim str2 As String = "select pu_prod, prix_vente from produits where id_prod='" & txt_idprod.Text & "' "
        cmd2 = New SqlCommand(str2, cn)
        dr2 = cmd2.ExecuteReader
        If (dr2.Read) Then
            txt_pua.Text = dr2.Item(0)
            txt_puv.Text = dr2.Item(1)
        Else
            txt_pua.Text = 0
            txt_puv.Text = 0
        End If
        dr2.Close()

        '----------------------------------------------------------------------------------------------------------------------------
        ' Pour remplir le Tableau quantites achats provenant dans le formulaire ACHAT
        Dim str3 As String = " select COALESCE(sum(COALESCE(qte_achat,0)),0) from achat where id_prod ='" & txt_idprod.Text & "' "
        cmd2 = New SqlCommand(str3, cn)
        dr2 = cmd2.ExecuteReader
        If dr2.Read Then
            achat = dr2.Item(0).ToString
            dr2.Close()
        End If

        ' Pour remplir le Tableau quantites achats provenant dans le formulaire ACHAT
        Dim str4 As String = " select COALESCE(sum(COALESCE(qte_vente,0)),0) from vente where id_prod ='" & txt_idprod.Text & "' "
        cmd2 = New SqlCommand(str4, cn)
        dr2 = cmd2.ExecuteReader
        If dr2.Read Then
            vente = dr2.Item(0).ToString
            dr2.Close()
        End If

        ' Code pour controler le STOCK
        lbl_stock.Text = Nothing
        lbl_stock.Text = achat - vente
        cn.Close()

    End Sub

    ' Pour calculer la quantite et le profit dans le formulaire de vente dans le KEYUp
    Private Sub txt_qtev_KeyUp(sender As Object, e As KeyEventArgs) Handles txt_qtev.KeyUp
        If (txt_pua.Text = Nothing Or txt_puv.Text = Nothing Or txt_qtev.Text = Nothing) Then
            txt_rn_vente.Text = ""
        Else
            txt_rn_vente.Text = (txt_puv.Text - txt_pua.Text) * txt_qtev.Text

        End If

        '---------------------------------------Pour calculer si les est remplir ou vide-------------------------------------------
        ' Code pour change de couleur si les quantite sont negatifs ou positifs
        If (Val(txt_qtev.Text) > Val(lbl_stock.Text)) Then
            lbl_msg_stock.Text = "Incorect !"
        Else
            lbl_msg_stock.Text = ""
        End If

    End Sub

    ' Pour le bouton ENREGISTRER les informations dans le formulaire
    Private Sub btn_enregistrer_Click(sender As Object, e As EventArgs) Handles btn_enregistrer.Click

        ' Message disant il faut remplir tous les champs
        If txt_idv.Text = Nothing Or Date_vente.Text = Nothing Or txt_idprod.Text = Nothing Or txt_pua.Text = Nothing Or txt_puv.Text = Nothing Or txt_qtev.Text = Nothing Or txt_rn_vente.Text = Nothing Or Combo_mov.Text = Nothing Or txt_idadmin.Text = Nothing Or txt_client.Text = Nothing Or txt_note.Text = Nothing Then
            MsgBox("Remplir Tous les Champs pour Ajouter !")
        Else
            If MsgBox("Voulez vous Vraiment Ajouter ?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo) = Windows.Forms.DialogResult.Yes Then
                cn.Open()
                cmd.CommandText = "insert into vente values('" & txt_idv.Text & "', '" & Date_vente.Text & "', '" & txt_qtev.Text & "', '" & txt_pua.Text & "', '" & txt_puv.Text & "', '" & Combo_mov.Text & "', '" & txt_rn_vente.Text & "', '" & txt_idprod.Text & "', '" & txt_client.Text & "', '" & txt_idadmin.Text & "', '" & txt_note.Text & "' )"
                cmd.ExecuteNonQuery()
                MsgBox("Ajouté avec succès :)")
                cn.Close()
                affiche()
            End If
        End If
    End Sub

    Private Sub btn_modifier_Click(sender As Object, e As EventArgs) Handles btn_modifier.Click

        ' Message disant il faut remplir tous les champs
        If txt_idv.Text = Nothing Or Date_vente.Text = Nothing Or txt_idprod.Text = Nothing Or txt_pua.Text = Nothing Or txt_puv.Text = Nothing Or txt_qtev.Text = Nothing Or txt_rn_vente.Text = Nothing Or Combo_mov.Text = Nothing Or txt_idadmin.Text = Nothing Or txt_client.Text = Nothing Or txt_note.Text = Nothing Then
            MsgBox("Remplir Tous les Champs pour Ajouter !")
        Else

            If MsgBox("Voulez vous Vraiment Modifier ?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo) = Windows.Forms.DialogResult.Yes Then
                cn.Open()
                cmd.CommandText = "update vente set Date_vente = '" & Date_vente.Text & "', qte_vente =" & txt_qtev.Text & ", pu_achat='" & txt_pua.Text & "', pu_vente=" & txt_puv.Text & ", mouvement ='" & Combo_mov.Text & "', rn_vente ='" & txt_rn_vente.Text & "', id_prod ='" & txt_idprod.Text & "', id_client ='" & txt_client.Text & "', id_users ='" & txt_idadmin.Text & "', note_vente ='" & txt_note.Text & "' where id_vente=(" & txt_idv.Text & ") "
                cmd.ExecuteNonQuery()
                MsgBox("Modifier avec succès :)")
                cn.Close()
                affiche()
            End If
        End If

    End Sub

    'Pour afficher dans la liste view avec l'evenment CLICK dans listeview
    Private Sub ListView_Click(sender As Object, e As EventArgs) Handles ListView.Click
        If ListView.SelectedItems.Count = 0 Then
            MsgBox("Selectionner un Produit !")
        Else
            cn.Open()
            cmd.CommandText = "select * from vente where id_vente='" & ListView.SelectedItems(0).Text.ToString & "'"
            cmd.ExecuteNonQuery()
            Dim dr As SqlDataReader = cmd.ExecuteReader()
            If dr.Read Then
                Me.txt_idv.Text = dr.Item(0).ToString
                Me.Date_vente.Text = dr.Item(1).ToString
                Me.txt_qtev.Text = dr.Item(2).ToString
                Me.txt_pua.Text = dr.Item(3).ToString
                Me.txt_puv.Text = dr.Item(4).ToString
                Me.Combo_mov.Text = dr.Item(5).ToString
                Me.txt_rn_vente.Text = dr.Item(6).ToString
                Me.txt_idprod.Text = dr.Item(7).ToString
                Me.txt_client.Text = dr.Item(8).ToString
                Me.txt_idadmin.Text = dr.Item(9).ToString
                Me.txt_note.Text = dr.Item(10).ToString
                dr.Close()
            End If
            cn.Close()
        End If
    End Sub

    ' Pour le bouton Supprimer dans le formulaire
    Private Sub btn_supprimer_Click(sender As Object, e As EventArgs) Handles btn_supprimer.Click

        ' Message disant il faut remplir tous les champs
        If txt_idv.Text = Nothing Or Date_vente.Text = Nothing Or txt_idprod.Text = Nothing Or txt_pua.Text = Nothing Or txt_puv.Text = Nothing Or txt_qtev.Text = Nothing Or txt_rn_vente.Text = Nothing Or Combo_mov.Text = Nothing Or txt_idadmin.Text = Nothing Or txt_client.Text = Nothing Or txt_note.Text = Nothing Then
            MsgBox("Remplir Tous les Champs pour Ajouter !")
        Else

            If MsgBox("Voulez vous Vraiment Supprimer ?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo) = Windows.Forms.DialogResult.Yes Then
                cn.Open()
                cmd.CommandText = " delete from vente where id_vente= '" & txt_idv.Text & "'"
                cmd.ExecuteNonQuery()
                MsgBox("Suppression avec succès :)")
                cn.Close()
                affiche()
            End If
        End If
    End Sub

    ' Pour clear le Formulaire pour ajouter de nouvelle donnee
    Private Sub btn_nouveau_Click(sender As Object, e As EventArgs) Handles btn_nouveau.Click
        txt_idv.Text = Nothing
        Date_vente.Text = Date.Now
        txt_qtev.Text = Nothing
        Me.txt_pua.Text = Nothing
        Me.txt_puv.Text = Nothing
        Me.Combo_mov.Text = Nothing
        Me.txt_rn_vente.Text = Nothing
        Me.txt_idprod.Text = Nothing
        Me.txt_client.Text = Nothing
        Me.txt_idadmin.Text = Nothing
        Me.txt_note.Text = Nothing
        Me.Combo_pro.Text = Nothing
        txt_idv.Focus() ' pour que le curser reste sur la premiere txt_idprod
    End Sub

    Private Sub txt_rech_KeyUp(sender As Object, e As KeyEventArgs) Handles txt_rechv.KeyUp

        cn.Open()
        Dim listems As ListViewItem
        Dim str As String = "select * from vente where " & combo_rechv.Text & " Like '%' + @1 + '%'"
        cmd = New SqlCommand(str, cn)
        cmd.Parameters.AddWithValue("@1", txt_rechv.Text)
        dr = cmd.ExecuteReader
        ListView.Items.Clear()
        While (dr.Read)
            listems = Me.ListView.Items.Add(dr("id_vente"))
            listems.SubItems.Add(dr("date_vente"))
            listems.SubItems.Add(dr("qte_vente"))
            listems.SubItems.Add(dr("pu_achat"))
            listems.SubItems.Add(dr("pu_vente"))
            listems.SubItems.Add(dr("mouvement"))
            listems.SubItems.Add(dr("rn_vente"))
            listems.SubItems.Add(dr("id_prod"))
            listems.SubItems.Add(dr("id_client"))
            listems.SubItems.Add(dr("id_users"))
            listems.SubItems.Add(dr("note_vente"))
        End While
        dr.Close()

        'Pour afficher le Min et le Max lorsquon fait la recherche
        Dim str2 As String = "select count(*), sum(qte_vente), sum(rn_vente) from vente where " & combo_rechv.Text & " Like '%' + @1 + '%' "
        cmd2 = New SqlCommand(str2, cn)
        cmd2.Parameters.AddWithValue("@1", txt_rechv.Text)
        dr2 = cmd2.ExecuteReader
        dr2.Read()
        Me.lbl_1.Text = "N. Vente : " & dr2.Item(0).ToString
        Me.lbl_2.Text = "T. Qte : " & dr2.Item(1).ToString
        Me.lbl_3.Text = "Profit : " & dr2.Item(2).ToString
        dr2.Close()
        cn.Close()
    End Sub

    Private Sub combo_rech_TextChanged(sender As Object, e As EventArgs) Handles combo_rechv.TextChanged
        txt_rechv.Text = Nothing 'Pour que le curser reste sur l'espace de recherche
        txt_rechv.Focus()
    End Sub

    Private Sub vente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        affiche()
        txt_idadmin.Text = connexion.id 'Pour Affiche id_admin automatic dans la table vente

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


        Dim achat As Integer
        Dim vente As Integer

        cn.Open()
        Dim str2 As String = "select pu_prod, prix_vente from produits where id_prod='" & txt_idprod.Text & "' "
        cmd2 = New SqlCommand(str2, cn)
        dr2 = cmd2.ExecuteReader
        If (dr2.Read) Then
            txt_pua.Text = dr2.Item(0)
            txt_puv.Text = dr2.Item(1)
        Else
            txt_pua.Text = 0
            txt_puv.Text = 0
        End If
        dr2.Close()

        '----------------------------------------------------------------------------------------------------------------------------
        ' Pour remplir le Tableau quantites achats provenant dans le formulaire ACHAT
        Dim str3 As String = " select COALESCE(sum(COALESCE(qte_achat,0)),0) from achat where id_prod ='" & txt_idprod.Text & "' "
        cmd2 = New SqlCommand(str3, cn)
        dr2 = cmd2.ExecuteReader
        If dr2.Read Then
            achat = dr2.Item(0).ToString
            dr2.Close()
        End If

        ' Pour remplir le Tableau quantites achats provenant dans le formulaire ACHAT
        Dim str4 As String = " select COALESCE(sum(COALESCE(qte_vente,0)),0) from vente where id_prod ='" & txt_idprod.Text & "' "
        cmd2 = New SqlCommand(str4, cn)
        dr2 = cmd2.ExecuteReader
        If dr2.Read Then
            vente = dr2.Item(0).ToString
            dr2.Close()
        End If

        ' Code pour controler le STOCK
        lbl_stock.Text = Nothing
        lbl_stock.Text = achat - vente
        cn.Close()


    End Sub
End Class