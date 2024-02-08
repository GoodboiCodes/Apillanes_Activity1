<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Label1 = New Label()
        Label2 = New Label()
        lblAdd = New Label()
        txtFirstnum = New TextBox()
        txtSecondNum = New TextBox()
        btnAdd = New Button()
        Label3 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 53)
        Label1.Name = "Label1"
        Label1.Size = New Size(79, 15)
        Label1.TabIndex = 0
        Label1.Text = "First Number:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(12, 93)
        Label2.Name = "Label2"
        Label2.Size = New Size(96, 15)
        Label2.TabIndex = 1
        Label2.Text = "Second Number:"
        ' 
        ' lblAdd
        ' 
        lblAdd.AutoSize = True
        lblAdd.Location = New Point(145, 138)
        lblAdd.Name = "lblAdd"
        lblAdd.Size = New Size(48, 15)
        lblAdd.TabIndex = 2
        lblAdd.Text = "Result..."
        ' 
        ' txtFirstnum
        ' 
        txtFirstnum.Location = New Point(114, 50)
        txtFirstnum.Name = "txtFirstnum"
        txtFirstnum.Size = New Size(100, 23)
        txtFirstnum.TabIndex = 3
        ' 
        ' txtSecondNum
        ' 
        txtSecondNum.Location = New Point(114, 90)
        txtSecondNum.Name = "txtSecondNum"
        txtSecondNum.Size = New Size(100, 23)
        txtSecondNum.TabIndex = 4
        ' 
        ' btnAdd
        ' 
        btnAdd.Location = New Point(11, 134)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(75, 23)
        btnAdd.TabIndex = 5
        btnAdd.Text = "Add"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(83, 9)
        Label3.Name = "Label3"
        Label3.Size = New Size(110, 15)
        Label3.TabIndex = 6
        Label3.Text = "Addition Calculator"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(275, 178)
        Controls.Add(Label3)
        Controls.Add(btnAdd)
        Controls.Add(txtSecondNum)
        Controls.Add(txtFirstnum)
        Controls.Add(lblAdd)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblAdd As Label
    Friend WithEvents txtFirstnum As TextBox
    Friend WithEvents txtSecondNum As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents Label3 As Label
End Class
