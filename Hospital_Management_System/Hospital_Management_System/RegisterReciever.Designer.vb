﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegisterReciever
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.RegisterLbl = New System.Windows.Forms.Label()
        Me.RecieverInfoGrp = New System.Windows.Forms.GroupBox()
        Me.QuantityTxt = New System.Windows.Forms.TextBox()
        Me.QuantityLbl = New System.Windows.Forms.Label()
        Me.BlooodGrpCombo = New System.Windows.Forms.ComboBox()
        Me.BloodGrpLbl = New System.Windows.Forms.Label()
        Me.DateTxt = New System.Windows.Forms.TextBox()
        Me.DateLbl = New System.Windows.Forms.Label()
        Me.GenderTxt = New System.Windows.Forms.ComboBox()
        Me.AgeLbl = New System.Windows.Forms.Label()
        Me.AgeTxt = New System.Windows.Forms.TextBox()
        Me.MobileLbl = New System.Windows.Forms.Label()
        Me.GenderLbl = New System.Windows.Forms.Label()
        Me.NameLbl = New System.Windows.Forms.Label()
        Me.MobileTxt = New System.Windows.Forms.TextBox()
        Me.NameTxt = New System.Windows.Forms.TextBox()
        Me.AddBtn = New System.Windows.Forms.Button()
        Me.ClearBtn = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuccessMsg = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RecieverInfoGrp.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(295, 43)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(91, 82)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'RegisterLbl
        '
        Me.RegisterLbl.Font = New System.Drawing.Font("MS Reference Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RegisterLbl.Location = New System.Drawing.Point(392, 63)
        Me.RegisterLbl.Name = "RegisterLbl"
        Me.RegisterLbl.Size = New System.Drawing.Size(330, 47)
        Me.RegisterLbl.TabIndex = 10
        Me.RegisterLbl.Text = "Register Reciever"
        Me.RegisterLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RecieverInfoGrp
        '
        Me.RecieverInfoGrp.Controls.Add(Me.QuantityTxt)
        Me.RecieverInfoGrp.Controls.Add(Me.QuantityLbl)
        Me.RecieverInfoGrp.Controls.Add(Me.BlooodGrpCombo)
        Me.RecieverInfoGrp.Controls.Add(Me.BloodGrpLbl)
        Me.RecieverInfoGrp.Controls.Add(Me.DateTxt)
        Me.RecieverInfoGrp.Controls.Add(Me.DateLbl)
        Me.RecieverInfoGrp.Controls.Add(Me.GenderTxt)
        Me.RecieverInfoGrp.Controls.Add(Me.AgeLbl)
        Me.RecieverInfoGrp.Controls.Add(Me.AgeTxt)
        Me.RecieverInfoGrp.Controls.Add(Me.MobileLbl)
        Me.RecieverInfoGrp.Controls.Add(Me.GenderLbl)
        Me.RecieverInfoGrp.Controls.Add(Me.NameLbl)
        Me.RecieverInfoGrp.Controls.Add(Me.MobileTxt)
        Me.RecieverInfoGrp.Controls.Add(Me.NameTxt)
        Me.RecieverInfoGrp.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RecieverInfoGrp.Location = New System.Drawing.Point(215, 214)
        Me.RecieverInfoGrp.Name = "RecieverInfoGrp"
        Me.RecieverInfoGrp.Size = New System.Drawing.Size(520, 454)
        Me.RecieverInfoGrp.TabIndex = 11
        Me.RecieverInfoGrp.TabStop = False
        Me.RecieverInfoGrp.Text = "Receiver Information"
        '
        'QuantityTxt
        '
        Me.QuantityTxt.Location = New System.Drawing.Point(135, 262)
        Me.QuantityTxt.Name = "QuantityTxt"
        Me.QuantityTxt.Size = New System.Drawing.Size(86, 29)
        Me.QuantityTxt.TabIndex = 22
        '
        'QuantityLbl
        '
        Me.QuantityLbl.AutoSize = True
        Me.QuantityLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QuantityLbl.Location = New System.Drawing.Point(33, 269)
        Me.QuantityLbl.Name = "QuantityLbl"
        Me.QuantityLbl.Size = New System.Drawing.Size(80, 18)
        Me.QuantityLbl.TabIndex = 21
        Me.QuantityLbl.Text = "Quantity :"
        Me.QuantityLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BlooodGrpCombo
        '
        Me.BlooodGrpCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.BlooodGrpCombo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BlooodGrpCombo.FormattingEnabled = True
        Me.BlooodGrpCombo.Items.AddRange(New Object() {"--Select--", "A+", "A-", "B+", "B-", "AB+", "AB-", "O+", "O-"})
        Me.BlooodGrpCombo.Location = New System.Drawing.Point(186, 213)
        Me.BlooodGrpCombo.Name = "BlooodGrpCombo"
        Me.BlooodGrpCombo.Size = New System.Drawing.Size(129, 26)
        Me.BlooodGrpCombo.TabIndex = 20
        '
        'BloodGrpLbl
        '
        Me.BloodGrpLbl.AutoSize = True
        Me.BloodGrpLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BloodGrpLbl.Location = New System.Drawing.Point(33, 216)
        Me.BloodGrpLbl.Name = "BloodGrpLbl"
        Me.BloodGrpLbl.Size = New System.Drawing.Size(114, 18)
        Me.BloodGrpLbl.TabIndex = 19
        Me.BloodGrpLbl.Text = "Blood Group :"
        Me.BloodGrpLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DateTxt
        '
        Me.DateTxt.Location = New System.Drawing.Point(205, 382)
        Me.DateTxt.Name = "DateTxt"
        Me.DateTxt.ReadOnly = True
        Me.DateTxt.Size = New System.Drawing.Size(167, 29)
        Me.DateTxt.TabIndex = 16
        '
        'DateLbl
        '
        Me.DateLbl.AutoSize = True
        Me.DateLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateLbl.Location = New System.Drawing.Point(33, 389)
        Me.DateLbl.Name = "DateLbl"
        Me.DateLbl.Size = New System.Drawing.Size(138, 18)
        Me.DateLbl.TabIndex = 15
        Me.DateLbl.Text = "Recieptant Date :"
        Me.DateLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GenderTxt
        '
        Me.GenderTxt.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GenderTxt.FormattingEnabled = True
        Me.GenderTxt.Items.AddRange(New Object() {"MALE", "FEMALE", "OTHERS"})
        Me.GenderTxt.Location = New System.Drawing.Point(135, 327)
        Me.GenderTxt.Name = "GenderTxt"
        Me.GenderTxt.Size = New System.Drawing.Size(124, 27)
        Me.GenderTxt.TabIndex = 14
        '
        'AgeLbl
        '
        Me.AgeLbl.AutoSize = True
        Me.AgeLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AgeLbl.Location = New System.Drawing.Point(33, 109)
        Me.AgeLbl.Name = "AgeLbl"
        Me.AgeLbl.Size = New System.Drawing.Size(46, 18)
        Me.AgeLbl.TabIndex = 13
        Me.AgeLbl.Text = "Age :"
        Me.AgeLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'AgeTxt
        '
        Me.AgeTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AgeTxt.Location = New System.Drawing.Point(135, 109)
        Me.AgeTxt.Name = "AgeTxt"
        Me.AgeTxt.Size = New System.Drawing.Size(124, 24)
        Me.AgeTxt.TabIndex = 10
        '
        'MobileLbl
        '
        Me.MobileLbl.AutoSize = True
        Me.MobileLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MobileLbl.Location = New System.Drawing.Point(33, 163)
        Me.MobileLbl.Name = "MobileLbl"
        Me.MobileLbl.Size = New System.Drawing.Size(68, 18)
        Me.MobileLbl.TabIndex = 8
        Me.MobileLbl.Text = "Mobile :"
        Me.MobileLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GenderLbl
        '
        Me.GenderLbl.AutoSize = True
        Me.GenderLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GenderLbl.Location = New System.Drawing.Point(33, 330)
        Me.GenderLbl.Name = "GenderLbl"
        Me.GenderLbl.Size = New System.Drawing.Size(73, 18)
        Me.GenderLbl.TabIndex = 6
        Me.GenderLbl.Text = "Gender :"
        Me.GenderLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'NameLbl
        '
        Me.NameLbl.AutoSize = True
        Me.NameLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NameLbl.Location = New System.Drawing.Point(33, 58)
        Me.NameLbl.Name = "NameLbl"
        Me.NameLbl.Size = New System.Drawing.Size(62, 18)
        Me.NameLbl.TabIndex = 5
        Me.NameLbl.Text = "Name :"
        Me.NameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MobileTxt
        '
        Me.MobileTxt.Location = New System.Drawing.Point(135, 156)
        Me.MobileTxt.Name = "MobileTxt"
        Me.MobileTxt.Size = New System.Drawing.Size(190, 29)
        Me.MobileTxt.TabIndex = 2
        '
        'NameTxt
        '
        Me.NameTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NameTxt.Location = New System.Drawing.Point(135, 55)
        Me.NameTxt.Name = "NameTxt"
        Me.NameTxt.Size = New System.Drawing.Size(355, 24)
        Me.NameTxt.TabIndex = 0
        '
        'AddBtn
        '
        Me.AddBtn.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddBtn.Location = New System.Drawing.Point(587, 702)
        Me.AddBtn.Name = "AddBtn"
        Me.AddBtn.Size = New System.Drawing.Size(148, 51)
        Me.AddBtn.TabIndex = 13
        Me.AddBtn.Text = "Add Recieptant"
        Me.AddBtn.UseVisualStyleBackColor = True
        '
        'ClearBtn
        '
        Me.ClearBtn.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClearBtn.Location = New System.Drawing.Point(420, 702)
        Me.ClearBtn.Name = "ClearBtn"
        Me.ClearBtn.Size = New System.Drawing.Size(148, 51)
        Me.ClearBtn.TabIndex = 14
        Me.ClearBtn.Text = "Clear"
        Me.ClearBtn.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'SuccessMsg
        '
        Me.SuccessMsg.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SuccessMsg.Location = New System.Drawing.Point(312, 149)
        Me.SuccessMsg.Name = "SuccessMsg"
        Me.SuccessMsg.Size = New System.Drawing.Size(339, 45)
        Me.SuccessMsg.TabIndex = 15
        Me.SuccessMsg.Text = "Name :"
        Me.SuccessMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.SuccessMsg.Visible = False
        '
        'RegisterReciever
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SuccessMsg)
        Me.Controls.Add(Me.ClearBtn)
        Me.Controls.Add(Me.AddBtn)
        Me.Controls.Add(Me.RecieverInfoGrp)
        Me.Controls.Add(Me.RegisterLbl)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "RegisterReciever"
        Me.Size = New System.Drawing.Size(977, 804)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RecieverInfoGrp.ResumeLayout(False)
        Me.RecieverInfoGrp.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents RegisterLbl As System.Windows.Forms.Label
    Friend WithEvents RecieverInfoGrp As System.Windows.Forms.GroupBox
    Friend WithEvents QuantityTxt As System.Windows.Forms.TextBox
    Friend WithEvents QuantityLbl As System.Windows.Forms.Label
    Friend WithEvents BlooodGrpCombo As System.Windows.Forms.ComboBox
    Friend WithEvents BloodGrpLbl As System.Windows.Forms.Label
    Friend WithEvents DateTxt As System.Windows.Forms.TextBox
    Friend WithEvents DateLbl As System.Windows.Forms.Label
    Friend WithEvents GenderTxt As System.Windows.Forms.ComboBox
    Friend WithEvents AgeLbl As System.Windows.Forms.Label
    Friend WithEvents AgeTxt As System.Windows.Forms.TextBox
    Friend WithEvents MobileLbl As System.Windows.Forms.Label
    Friend WithEvents GenderLbl As System.Windows.Forms.Label
    Friend WithEvents NameLbl As System.Windows.Forms.Label
    Friend WithEvents MobileTxt As System.Windows.Forms.TextBox
    Friend WithEvents NameTxt As System.Windows.Forms.TextBox
    Friend WithEvents AddBtn As System.Windows.Forms.Button
    Friend WithEvents ClearBtn As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents SuccessMsg As System.Windows.Forms.Label

End Class
