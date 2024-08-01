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
        BtnOk = New Button()
        NudHeightInCm = New NumericUpDown()
        CType(NudHeightInCm, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(37, 33)
        Label1.Name = "Label1"
        Label1.Size = New Size(148, 15)
        Label1.TabIndex = 0
        Label1.Text = "What is your height in cm?"
        ' 
        ' BtnOk
        ' 
        BtnOk.Location = New Point(153, 71)
        BtnOk.Name = "BtnOk"
        BtnOk.Size = New Size(52, 23)
        BtnOk.TabIndex = 2
        BtnOk.Text = "Ok"
        BtnOk.UseVisualStyleBackColor = True
        ' 
        ' NudHeightInCm
        ' 
        NudHeightInCm.Location = New Point(12, 71)
        NudHeightInCm.Maximum = New Decimal(New Integer() {200, 0, 0, 0})
        NudHeightInCm.Name = "NudHeightInCm"
        NudHeightInCm.Size = New Size(135, 23)
        NudHeightInCm.TabIndex = 3
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(217, 106)
        Controls.Add(NudHeightInCm)
        Controls.Add(BtnOk)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Height"
        CType(NudHeightInCm, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents BtnOk As Button
    Friend WithEvents NudHeightInCm As NumericUpDown

End Class
