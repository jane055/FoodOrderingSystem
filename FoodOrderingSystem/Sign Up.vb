Imports System.Data.SqlClient
Public Class Sign_Up
    Private Sub BtnSignup_Click(sender As Object, e As EventArgs) Handles btnSignup.Click
        Try
            Dim conn As New SqlConnection
            Dim cmd As New SqlCommand
            Dim dataReader As SqlDataReader

            conn.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\jojo\source\repos\FoodOrderingSystem\FoodOrderingSystem\DBFood.mdf;Integrated Security=True"
            conn.Open()
            cmd.Connection = conn
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "select * from signup where email='" & txtEmail.Text & "' "
            dataReader = cmd.ExecuteReader
            If dataReader.HasRows Then
                MsgBox("Email has already been used. Please use other email.", MsgBoxStyle.Critical)
                conn.Close()
            Else
                conn.Close()
                conn.Open()
                cmd = New SqlCommand("INSERT INTO signup values('" & txtName.Text & "', '" & txtEmail.Text & "',
                        '" & txtPass.Text & "')", conn)
                If (txtName.Text = "" And txtEmail.Text = "" And txtPass.Text = "") Then
                    MessageBox.Show("Please fill in the required fields")
                Else
                    cmd.ExecuteNonQuery()
                    MsgBox("Successfully registered!", MsgBoxStyle.Information, "Success")
                    Me.Hide()
                    'login.show() --> to be created later!!!
                    txtName.Clear()
                    txtEmail.Clear()
                    txtPass.Clear()
                End If
                conn.Close()
            End If
            conn.Close()
        Catch ex As Exception
            MsgBox("Error")
        End Try

    End Sub
End Class