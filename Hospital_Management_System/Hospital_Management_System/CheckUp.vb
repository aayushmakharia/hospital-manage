Imports System.Data.OleDb
Public Class CheckUp
    Dim myconnection As OleDbConnection = New OleDbConnection
    Private Sub CheckUp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        myconnection.ConnectionString = Form1.provider & Form1.datafile
    End Sub

    Private Sub SearchBtn_Click(sender As Object, e As EventArgs) Handles SearchBtn.Click
        If Not Form1.Name_Validation(NameTxt.Text.ToLower) Or Not Form1.Mobile_Validator(MobileTxt.Text.ToLower) Then
            MessageBox.Show("No Results Found")
            Exit Sub
        End If
        myconnection.Open()

    End Sub
End Class
