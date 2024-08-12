<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class web_form
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        lbl_1 = New Label()
        lbl_2 = New Label()
        lbl_3 = New Label()
        Btn = New Button()
        txtId_pengguna = New TextBox()
        txtKata_laluan = New TextBox()
        SuspendLayout()
        ' 
        ' lbl_1
        ' 
        lbl_1.AutoSize = True
        lbl_1.Font = New Font("Tahoma", 15F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbl_1.Location = New Point(88, 22)
        lbl_1.Name = "lbl_1"
        lbl_1.Size = New Size(131, 24)
        lbl_1.TabIndex = 0
        lbl_1.Text = "LOG MASUK"
        ' 
        ' lbl_2
        ' 
        lbl_2.AutoSize = True
        lbl_2.Font = New Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbl_2.Location = New Point(10, 72)
        lbl_2.Name = "lbl_2"
        lbl_2.Size = New Size(136, 21)
        lbl_2.TabIndex = 1
        lbl_2.Text = "ID PENGGUNA :"
        ' 
        ' lbl_3
        ' 
        lbl_3.AutoSize = True
        lbl_3.Font = New Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbl_3.Location = New Point(10, 119)
        lbl_3.Name = "lbl_3"
        lbl_3.Size = New Size(134, 21)
        lbl_3.TabIndex = 2
        lbl_3.Text = "KATA LALUAN :"
        ' 
        ' Btn
        ' 
        Btn.Font = New Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Btn.Location = New Point(104, 170)
        Btn.Name = "Btn"
        Btn.Size = New Size(103, 27)
        Btn.TabIndex = 3
        Btn.Text = "LOGIN"
        Btn.UseVisualStyleBackColor = True
        ' 
        ' txtId_pengguna
        ' 
        txtId_pengguna.Location = New Point(144, 73)
        txtId_pengguna.Name = "txtId_pengguna"
        txtId_pengguna.Size = New Size(154, 23)
        txtId_pengguna.TabIndex = 4
        ' 
        ' txtKata_laluan
        ' 
        txtKata_laluan.Location = New Point(144, 120)
        txtKata_laluan.Name = "txtKata_laluan"
        txtKata_laluan.Size = New Size(154, 23)
        txtKata_laluan.TabIndex = 5
        ' 
        ' web_form
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(316, 218)
        Controls.Add(txtKata_laluan)
        Controls.Add(txtId_pengguna)
        Controls.Add(Btn)
        Controls.Add(lbl_3)
        Controls.Add(lbl_2)
        Controls.Add(lbl_1)
        Name = "web_form"
        Text = "Log In"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lbl_1 As Label
    Friend WithEvents lbl_2 As Label
    Friend WithEvents lbl_3 As Label
    Friend WithEvents Btn As Button
    Friend WithEvents txtId_pengguna As TextBox
    Friend WithEvents txtKata_laluan As TextBox

End Class
