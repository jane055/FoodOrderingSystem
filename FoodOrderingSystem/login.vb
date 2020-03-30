Public Class login
    Dim a As Integer = 0

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtStaffID.Text = My.Settings.StaffID Then
            a += 1
        End If
        If txtPassword.Text = My.Settings.Password Then
            a += 1
        End If
        If a = 2 Then
            'event - show next form mybe
        Else
            'show msg
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked

    End Sub
End Class
