Imports System.Data.SqlClient

Public Class password

    Public dr As SqlDataReader
    Public cmd As New SqlCommand


    Private Sub password_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Pour faire la connexion avec le menu 
        If txt_login.Text = Nothing Then
            MessageBox.Show("Remplir Login !")
        ElseIf (txt_mp.Text = Nothing) Then
            MessageBox.Show("Remplir le Password !")

        Else
            cn.Open()
            Dim str As String = "select * from users where login_users ='" & txt_login.Text & "' and password_users = '" & txt_mp.Text & "' "
            cmd = New SqlCommand(str, cn)
            dr = cmd.ExecuteReader
            If dr.Read Then

                'Pour que l'Id du users puisse paraitre dans le forme automatic
                connexion.id = dr.Item("id_users").ToString
                connexion.nom = dr.Item("nom_users").ToString
                connexion.prenom = dr.Item("prenom_users").ToString
                Menu_g.Show()
                dr.Close()
                cn.Close()
                Me.Hide()
            Else
                MessageBox.Show("Mot de Passe Incorrect")
                dr.Close()
                cn.Close()
            End If
            dr.Close()
            cn.Close()
        End If
    End Sub

End Class