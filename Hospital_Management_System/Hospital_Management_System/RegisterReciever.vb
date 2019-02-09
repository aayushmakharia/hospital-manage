Imports System.Data.OleDb

Public Class RegisterReciever

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles AddBtn.Click

        Dim myconnection As OleDbConnection = New OleDbConnection
        Dim cmd As OleDbCommand
        'Connection String
        myconnection.ConnectionString = Form1.provider & Form1.datafile
        If Not Validate_data() Then
            Exit Sub
        End If
        myconnection.Open()
        'MessageBox.Show("Connected")
        Dim query As String
        'Insert into database 
        query = "Insert Into [Recievers] ([Name],[Gender],[Age],[Blood Group],[Contact Number],[Blood Recieved],[Date of Recieve]) Values (?,?,?,?,?,?,?)"
        cmd = New OleDbCommand(query, myconnection)
        Try
            'Specify the parameters and corresponding values
            cmd.Parameters.Add(New OleDbParameter("Name", CType(NameTxt.Text.ToLower, String)))
            cmd.Parameters.Add(New OleDbParameter("Age", CType(Convert.ToInt16(AgeTxt.Text), Integer)))
            cmd.Parameters.Add(New OleDbParameter("Gender", CType(GenderTxt.Text.ToLower, String)))
            cmd.Parameters.Add(New OleDbParameter("Contact Number", CType(MobileTxt.Text.ToString, String)))
            cmd.Parameters.Add(New OleDbParameter("Blood Group", CType(BlooodGrpCombo.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("Blood Recieved", CType(QuantityTxt.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("Date of Recieve", CType(DateTxt.Text, String)))

            cmd.ExecuteNonQuery()
            cmd.Dispose()
            'Close the Connection
            myconnection.Close()
            'Display Success Message
            SuccessMsg.Visible = True
            SuccessMsg.Text = "Patient Successfully Registered !!"
            SuccessMsg.BackColor = Color.Green
            'Start timer
            Timer1.Start()

        Catch ex As Exception
            'Close the connection
            myconnection.Close()
            'Display failure Message
            SuccessMsg.Visible = True
            SuccessMsg.Text = "Invalid Credentials"
            SuccessMsg.BackColor = Color.Red
            'Start timer
            Timer1.Start()
        End Try


    End Sub

    Private Function Validate_data() As Boolean
        If Not Form1.Name_Validation(NameTxt.Text.ToLower) Then
            'Display failure Message
            SuccessMsg.Visible = True
            SuccessMsg.Text = "Invalid Name"
            SuccessMsg.BackColor = Color.Red
            'Start timer
            Timer1.Start()
            Return False
        End If
        If Not Form1.age_validator(AgeTxt.Text) Then
            'Display failure Message
            SuccessMsg.Visible = True
            SuccessMsg.Text = "Invalid Age"
            SuccessMsg.BackColor = Color.Red
            'Start timer
            Timer1.Start()
            Return False
        End If
        If Not Form1.Gender_Validator(GenderTxt.Text.ToLower) Then
            'Display failure Message
            SuccessMsg.Visible = True
            SuccessMsg.Text = "Invalid Gender"
            SuccessMsg.BackColor = Color.Red
            'Start timer
            Timer1.Start()
            Return False
        End If
        If Not Form1.Mobile_Validator(MobileTxt.Text) Then
            'Display failure Message
            SuccessMsg.Visible = True
            SuccessMsg.Text = "Invalid Mobile Number"
            SuccessMsg.BackColor = Color.Red
            'Start timer
            Timer1.Start()
            Return False
        End If
        If BlooodGrpCombo.SelectedIndex = 0 Then
            'Display failure Message
            SuccessMsg.Visible = True
            SuccessMsg.Text = "Select Proper Blood Group"
            SuccessMsg.BackColor = Color.Red
            'Start timer
            Timer1.Start()
            Return False
        End If
        ' If Not Form1.Decimal_Validation(QuantityTxt.Text) Then
        'Display failure Message
        'SuccessMsg.Visible = True
        'SuccessMsg.Text = "Invalid Quantity"
        'SuccessMsg.BackColor = Color.Red
        'Start timer
        'Timer1.Start()
        'Return False
        'End If
        Return True
    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles ClearBtn.Click
        NameTxt.Clear()
        AgeTxt.Clear()
        GenderTxt.Text = ""
        MobileTxt.Clear()
        BlooodGrpCombo.SelectedIndex = 0
        DateTxt.Clear()
        QuantityTxt.Clear()

    End Sub

    Private Sub RegisterReciever_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DateTxt.Text = Date.Today.ToShortDateString
        BlooodGrpCombo.SelectedIndex = 0
    End Sub
End Class
