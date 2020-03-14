<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.nameField = New System.Windows.Forms.TextBox()
        Me.programTitle = New System.Windows.Forms.Label()
        Me.ageLbl = New System.Windows.Forms.Label()
        Me.ageField = New System.Windows.Forms.TextBox()
        Me.addressLbl = New System.Windows.Forms.Label()
        Me.addressField = New System.Windows.Forms.TextBox()
        Me.nameLbl = New System.Windows.Forms.Label()
        Me.txtBtn = New System.Windows.Forms.Button()
        Me.xmlBtn = New System.Windows.Forms.Button()
        Me.jsonBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'nameField
        '
        Me.nameField.Location = New System.Drawing.Point(50, 93)
        Me.nameField.Name = "nameField"
        Me.nameField.Size = New System.Drawing.Size(302, 20)
        Me.nameField.TabIndex = 0
        '
        'programTitle
        '
        Me.programTitle.AutoSize = True
        Me.programTitle.Font = New System.Drawing.Font("Impact", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.programTitle.Location = New System.Drawing.Point(122, 31)
        Me.programTitle.Name = "programTitle"
        Me.programTitle.Size = New System.Drawing.Size(161, 29)
        Me.programTitle.TabIndex = 1
        Me.programTitle.Text = "WRITE-TO-FILE"
        '
        'ageLbl
        '
        Me.ageLbl.AutoSize = True
        Me.ageLbl.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ageLbl.Location = New System.Drawing.Point(48, 124)
        Me.ageLbl.Name = "ageLbl"
        Me.ageLbl.Size = New System.Drawing.Size(32, 20)
        Me.ageLbl.TabIndex = 3
        Me.ageLbl.Text = "AGE"
        '
        'ageField
        '
        Me.ageField.AcceptsReturn = True
        Me.ageField.Location = New System.Drawing.Point(50, 147)
        Me.ageField.Name = "ageField"
        Me.ageField.Size = New System.Drawing.Size(302, 20)
        Me.ageField.TabIndex = 2
        '
        'addressLbl
        '
        Me.addressLbl.AutoSize = True
        Me.addressLbl.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addressLbl.Location = New System.Drawing.Point(48, 178)
        Me.addressLbl.Name = "addressLbl"
        Me.addressLbl.Size = New System.Drawing.Size(66, 20)
        Me.addressLbl.TabIndex = 5
        Me.addressLbl.Text = "ADDRESS"
        '
        'addressField
        '
        Me.addressField.Location = New System.Drawing.Point(50, 201)
        Me.addressField.Name = "addressField"
        Me.addressField.Size = New System.Drawing.Size(302, 20)
        Me.addressField.TabIndex = 4
        '
        'nameLbl
        '
        Me.nameLbl.AutoSize = True
        Me.nameLbl.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nameLbl.Location = New System.Drawing.Point(46, 70)
        Me.nameLbl.Name = "nameLbl"
        Me.nameLbl.Size = New System.Drawing.Size(43, 20)
        Me.nameLbl.TabIndex = 6
        Me.nameLbl.Text = "NAME"
        '
        'txtBtn
        '
        Me.txtBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtBtn.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBtn.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtBtn.Location = New System.Drawing.Point(12, 259)
        Me.txtBtn.Name = "txtBtn"
        Me.txtBtn.Size = New System.Drawing.Size(112, 42)
        Me.txtBtn.TabIndex = 7
        Me.txtBtn.Text = "TXT"
        Me.txtBtn.UseVisualStyleBackColor = False
        '
        'xmlBtn
        '
        Me.xmlBtn.BackColor = System.Drawing.Color.Lime
        Me.xmlBtn.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xmlBtn.Location = New System.Drawing.Point(143, 259)
        Me.xmlBtn.Name = "xmlBtn"
        Me.xmlBtn.Size = New System.Drawing.Size(112, 42)
        Me.xmlBtn.TabIndex = 8
        Me.xmlBtn.Text = "XML"
        Me.xmlBtn.UseVisualStyleBackColor = False
        '
        'jsonBtn
        '
        Me.jsonBtn.BackColor = System.Drawing.Color.Fuchsia
        Me.jsonBtn.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.jsonBtn.Location = New System.Drawing.Point(274, 259)
        Me.jsonBtn.Name = "jsonBtn"
        Me.jsonBtn.Size = New System.Drawing.Size(112, 42)
        Me.jsonBtn.TabIndex = 9
        Me.jsonBtn.Text = "JSON"
        Me.jsonBtn.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CornflowerBlue
        Me.ClientSize = New System.Drawing.Size(398, 332)
        Me.Controls.Add(Me.jsonBtn)
        Me.Controls.Add(Me.xmlBtn)
        Me.Controls.Add(Me.txtBtn)
        Me.Controls.Add(Me.nameLbl)
        Me.Controls.Add(Me.addressLbl)
        Me.Controls.Add(Me.addressField)
        Me.Controls.Add(Me.ageLbl)
        Me.Controls.Add(Me.ageField)
        Me.Controls.Add(Me.programTitle)
        Me.Controls.Add(Me.nameField)
        Me.Name = "Form1"
        Me.Text = "Sodela's Homework"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents nameField As TextBox
    Friend WithEvents programTitle As Label
    Friend WithEvents ageLbl As Label
    Friend WithEvents ageField As TextBox
    Friend WithEvents addressLbl As Label
    Friend WithEvents addressField As TextBox
    Friend WithEvents nameLbl As Label
    Friend WithEvents txtBtn As Button
    Friend WithEvents xmlBtn As Button
    Friend WithEvents jsonBtn As Button
End Class
