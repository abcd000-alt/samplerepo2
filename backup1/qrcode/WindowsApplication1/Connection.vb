Imports MySql.Data.MySqlClient
Imports System.IO

Module Connection
    'Public startpath As String = Application.StartupPath
    'Public SR As StreamReader
    'Public srvr As String
    ' Public loc As String = ()
    Public con As New MySqlConnection
    Public cm As New MySqlCommand
    Public dr As MySqlDataReader
    Public da As New MySqlDataAdapter
    Public ds As New DataSet
    Public dt As New DataTable
    Public str As String
    Public query As String

    Public Function GetConnection() As MySqlConnection
        Dim connectionString As String = "SERVER = localhost; USER ID = root; password = ; database = qrsc_db ;"
        Dim connection As MySqlConnection = Nothing

        Try
            connection = New MySqlConnection(connectionString)
        Catch ex As Exception
            MessageBox.Show("Error Connecting to database" & ex.Message)
        End Try
        Return connection
    End Function


End Module

