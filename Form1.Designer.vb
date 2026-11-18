<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        textCelsius = New TextBox()
        Label1 = New Label()
        btnConvert = New Button()
        lblResult = New Label()
        SuspendLayout()
        ' 
        ' textCelsius
        ' 
        textCelsius.Location = New Point(560, 193)
        textCelsius.Name = "textCelsius"
        textCelsius.Size = New Size(125, 27)
        textCelsius.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(267, 210)
        Label1.Name = "Label1"
        Label1.Size = New Size(0, 20)
        Label1.TabIndex = 1
        ' 
        ' btnConvert
        ' 
        btnConvert.Location = New Point(454, 313)
        btnConvert.Name = "btnConvert"
        btnConvert.Size = New Size(94, 29)
        btnConvert.TabIndex = 2
        btnConvert.Text = "Button1"
        btnConvert.UseVisualStyleBackColor = True
        ' 
        ' lblResult
        ' 
        lblResult.AutoSize = True
        lblResult.Location = New Point(300, 220)
        lblResult.Name = "lblResult"
        lblResult.Size = New Size(53, 20)
        lblResult.TabIndex = 3
        lblResult.Text = "Label2"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lblResult)
        Controls.Add(btnConvert)
        Controls.Add(Label1)
        Controls.Add(textCelsius)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents textCelsius As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnConvert As Button
    Friend WithEvents lblResult As Label

End Class
