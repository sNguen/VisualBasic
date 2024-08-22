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
        Me.txtExamScore = New System.Windows.Forms.TextBox()
        Me.lblExamScore = New System.Windows.Forms.Label()
        Me.btnGetGrade = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtExamScore
        '
        Me.txtExamScore.Location = New System.Drawing.Point(434, 107)
        Me.txtExamScore.MaxLength = 3
        Me.txtExamScore.Name = "txtExamScore"
        Me.txtExamScore.Size = New System.Drawing.Size(193, 27)
        Me.txtExamScore.TabIndex = 0
        '
        'lblExamScore
        '
        Me.lblExamScore.AutoSize = True
        Me.lblExamScore.Location = New System.Drawing.Point(205, 110)
        Me.lblExamScore.Name = "lblExamScore"
        Me.lblExamScore.Size = New System.Drawing.Size(193, 20)
        Me.lblExamScore.TabIndex = 1
        Me.lblExamScore.Text = "Enter the examination score"
        '
        'btnGetGrade
        '
        Me.btnGetGrade.Location = New System.Drawing.Point(351, 204)
        Me.btnGetGrade.Name = "btnGetGrade"
        Me.btnGetGrade.Size = New System.Drawing.Size(151, 79)
        Me.btnGetGrade.TabIndex = 2
        Me.btnGetGrade.Text = "Get Grade"
        Me.btnGetGrade.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnGetGrade)
        Me.Controls.Add(Me.lblExamScore)
        Me.Controls.Add(Me.txtExamScore)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtExamScore As TextBox
    Friend WithEvents lblExamScore As Label
    Friend WithEvents btnGetGrade As Button
End Class
