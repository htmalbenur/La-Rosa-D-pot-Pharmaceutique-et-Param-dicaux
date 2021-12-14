Public Class Menu_g
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lbl_date.Text = Date.Now
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.ShowDialog()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        achat.ShowDialog()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        vente.ShowDialog()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        fournisseur.ShowDialog()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        client.ShowDialog()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        admin.ShowDialog()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If MsgBox("Voulez-vous Vraiment Déconnecté?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo) = Windows.Forms.DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub Menu_g_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Pour afficher le label dans le Menu lors du login
        lbl_nomadmin.Text = connexion.prenom & "" & connexion.nom
    End Sub

    Private Sub btn_printRP_Click(sender As Object, e As EventArgs) Handles btn_printRP.Click
        'Pour afficher le boutoun pour print le rapport produit
        'PrintRP.ShowDialog()
    End Sub
End Class