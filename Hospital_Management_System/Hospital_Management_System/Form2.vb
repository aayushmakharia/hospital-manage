Imports System.Data.OleDb
Public Class Form2
    Dim myconnection As OleDbConnection = New OleDbConnection
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        myconnection.ConnectionString = Form1.provider & Form1.datafile
    End Sub

    Private Sub CheckUpBtn_Click(sender As Object, e As EventArgs) Handles CheckUpBtn.Click
        PatientPanel1.BackColor = Color.DarkBlue
        PatientPanel2.BackColor = Color.DarkBlue
        BloodBankPanel1.BackColor = Color.Transparent
        BloodBankPanel2.BackColor = Color.Transparent
        StaffPanel2.BackColor = Color.Transparent
        StaffPanel1.BackColor = Color.Transparent
        PersonalInfoPanel1.BackColor = Color.Transparent
        PersonalInfoPanel2.BackColor = Color.Transparent
        PatientPanel1.Top = CheckUpBtn.Top
        PatientPanel2.Top = CheckUpBtn.Top

        StaffPanel.Controls.Clear()
        StaffPanel.Controls.Add(New CheckUp())

    End Sub

    Private Sub RegistrationBtn_Click(sender As Object, e As EventArgs) Handles RegistrationBtn.Click
        PatientPanel1.BackColor = Color.DarkBlue
        PatientPanel2.BackColor = Color.DarkBlue
        BloodBankPanel1.BackColor = Color.Transparent
        BloodBankPanel2.BackColor = Color.Transparent
        StaffPanel2.BackColor = Color.Transparent
        StaffPanel1.BackColor = Color.Transparent
        PersonalInfoPanel1.BackColor = Color.Transparent
        PersonalInfoPanel2.BackColor = Color.Transparent
        PatientPanel1.Top = RegistrationBtn.Top
        PatientPanel2.Top = RegistrationBtn.Top

        StaffPanel.Controls.Clear()
        StaffPanel.Controls.Add(New Registration())
    End Sub

    Private Sub AdmitBtn_Click(sender As Object, e As EventArgs) Handles AdmitBtn.Click
        PatientPanel1.BackColor = Color.DarkBlue
        PatientPanel2.BackColor = Color.DarkBlue
        BloodBankPanel1.BackColor = Color.Transparent
        BloodBankPanel2.BackColor = Color.Transparent
        StaffPanel2.BackColor = Color.Transparent
        StaffPanel1.BackColor = Color.Transparent
        PersonalInfoPanel1.BackColor = Color.Transparent
        PersonalInfoPanel2.BackColor = Color.Transparent
        PatientPanel1.Top = AdmitBtn.Top
        PatientPanel2.Top = AdmitBtn.Top

        StaffPanel.Controls.Clear()
        StaffPanel.Controls.Add(New Admit())
    End Sub

    Private Sub UpdateDetailsBtn_Click(sender As Object, e As EventArgs) Handles UpdateDetailsBtn.Click
        PatientPanel1.BackColor = Color.DarkBlue
        PatientPanel2.BackColor = Color.DarkBlue
        BloodBankPanel1.BackColor = Color.Transparent
        BloodBankPanel2.BackColor = Color.Transparent
        StaffPanel2.BackColor = Color.Transparent
        StaffPanel1.BackColor = Color.Transparent
        PersonalInfoPanel1.BackColor = Color.Transparent
        PersonalInfoPanel2.BackColor = Color.Transparent
        PatientPanel1.Top = UpdateDetailsBtn.Top
        PatientPanel2.Top = UpdateDetailsBtn.Top

        StaffPanel.Controls.Clear()
        StaffPanel.Controls.Add(New UpdateDetails())
    End Sub

    Private Sub RegisterRecieverBtn_Click(sender As Object, e As EventArgs) Handles RegisterRecieverBtn.Click
        PatientPanel1.BackColor = Color.Transparent
        PatientPanel2.BackColor = Color.Transparent
        StaffPanel1.BackColor = Color.Transparent
        StaffPanel2.BackColor = Color.Transparent
        BloodBankPanel1.BackColor = Color.DarkBlue
        BloodBankPanel2.BackColor = Color.DarkBlue
        PersonalInfoPanel1.BackColor = Color.Transparent
        PersonalInfoPanel2.BackColor = Color.Transparent
        BloodBankPanel1.Top = RegisterRecieverBtn.Top
        BloodBankPanel2.Top = RegisterRecieverBtn.Top

        StaffPanel.Controls.Clear()
        StaffPanel.Controls.Add(New RegisterReciever())
    End Sub

    Private Sub AvailabilityBtn_Click(sender As Object, e As EventArgs) Handles AvailabilityBtn.Click
        PatientPanel1.BackColor = Color.Transparent
        PatientPanel2.BackColor = Color.Transparent
        BloodBankPanel1.BackColor = Color.Transparent
        BloodBankPanel2.BackColor = Color.Transparent
        StaffPanel2.BackColor = Color.DarkBlue
        StaffPanel1.BackColor = Color.DarkBlue
        PersonalInfoPanel1.BackColor = Color.Transparent
        PersonalInfoPanel2.BackColor = Color.Transparent

        StaffPanel.Controls.Clear()
        StaffPanel.Controls.Add(New Availability())
    End Sub

    Private Sub RegisterDonorBtn_Click(sender As Object, e As EventArgs) Handles RegisterDonorBtn.Click
        PatientPanel1.BackColor = Color.Transparent
        PatientPanel2.BackColor = Color.Transparent
        StaffPanel1.BackColor = Color.Transparent
        StaffPanel2.BackColor = Color.Transparent
        BloodBankPanel1.BackColor = Color.DarkBlue
        BloodBankPanel2.BackColor = Color.DarkBlue
        PersonalInfoPanel1.BackColor = Color.Transparent
        PersonalInfoPanel2.BackColor = Color.Transparent
        BloodBankPanel1.Top = RegisterDonorBtn.Top
        BloodBankPanel2.Top = RegisterDonorBtn.Top

        StaffPanel.Controls.Clear()
        StaffPanel.Controls.Add(New RegisterDonor())
    End Sub

    Private Sub BloodAvailabilityBtn_Click(sender As Object, e As EventArgs) Handles BloodAvailabilityBtn.Click
        PatientPanel1.BackColor = Color.Transparent
        PatientPanel2.BackColor = Color.Transparent
        StaffPanel1.BackColor = Color.Transparent
        StaffPanel2.BackColor = Color.Transparent
        BloodBankPanel1.BackColor = Color.DarkBlue
        BloodBankPanel2.BackColor = Color.DarkBlue
        PersonalInfoPanel1.BackColor = Color.Transparent
        PersonalInfoPanel2.BackColor = Color.Transparent
        BloodBankPanel1.Top = BloodAvailabilityBtn.Top
        BloodBankPanel2.Top = BloodAvailabilityBtn.Top

        StaffPanel.Controls.Clear()
        StaffPanel.Controls.Add(New BloodAvailability())
    End Sub

    Private Sub BloodDonationBtn_Click(sender As Object, e As EventArgs) Handles BloodDonationBtn.Click
        PatientPanel1.BackColor = Color.Transparent
        PatientPanel2.BackColor = Color.Transparent
        StaffPanel1.BackColor = Color.Transparent
        StaffPanel2.BackColor = Color.Transparent
        BloodBankPanel1.BackColor = Color.DarkBlue
        BloodBankPanel2.BackColor = Color.DarkBlue
        PersonalInfoPanel1.BackColor = Color.Transparent
        PersonalInfoPanel2.BackColor = Color.Transparent
        BloodBankPanel1.Top = BloodDonationBtn.Top
        BloodBankPanel2.Top = BloodDonationBtn.Top
    End Sub

    Private Sub EditProfileBtn_Click(sender As Object, e As EventArgs) Handles EditProfileBtn.Click
        PatientPanel1.BackColor = Color.Transparent
        PatientPanel2.BackColor = Color.Transparent
        BloodBankPanel1.BackColor = Color.Transparent
        BloodBankPanel2.BackColor = Color.Transparent
        StaffPanel2.BackColor = Color.Transparent
        StaffPanel1.BackColor = Color.Transparent
        PersonalInfoPanel1.BackColor = Color.DarkBlue
        PersonalInfoPanel2.BackColor = Color.DarkBlue
        PersonalInfoPanel1.Top = EditProfileBtn.Top
        PersonalInfoPanel2.Top = EditProfileBtn.Top

        StaffPanel.Controls.Clear()
        StaffPanel.Controls.Add(New EditProfile())
    End Sub

    Private Sub LogoutBtn_Click(sender As Object, e As EventArgs) Handles LogoutBtn.Click
        PatientPanel1.BackColor = Color.Transparent
        PatientPanel2.BackColor = Color.Transparent
        BloodBankPanel1.BackColor = Color.Transparent
        BloodBankPanel2.BackColor = Color.Transparent
        StaffPanel2.BackColor = Color.Transparent
        StaffPanel1.BackColor = Color.Transparent
        PersonalInfoPanel1.BackColor = Color.DarkBlue
        PersonalInfoPanel2.BackColor = Color.DarkBlue
        PersonalInfoPanel1.Top = LogoutBtn.Top
        PersonalInfoPanel2.Top = LogoutBtn.Top

    End Sub

    Private Sub Form2_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Form1.username = ""
        Form1.Show()
    End Sub
End Class