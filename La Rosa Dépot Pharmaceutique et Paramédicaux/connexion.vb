Imports System.Data.SqlClient
Module connexion

    Public cn As New SqlConnection("Data Source=DESKTOP-H9C3IO5;Initial Catalog=GestRosa;Integrated Security=True")

    'Declaration des variables pour l'authentification du user
    Public id As Integer
    Public nom As String
    Public prenom As String


End Module
