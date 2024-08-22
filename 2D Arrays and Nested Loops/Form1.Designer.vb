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
        Me.btnRow = New System.Windows.Forms.Button()
        Me.btnColumn = New System.Windows.Forms.Button()
        Me.btnAtOnce = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnRow
        '
        Me.btnRow.Location = New System.Drawing.Point(327, 32)
        Me.btnRow.Name = "btnRow"
        Me.btnRow.Size = New System.Drawing.Size(145, 72)
        Me.btnRow.TabIndex = 0
        Me.btnRow.Text = "Display data item row wise"
        Me.btnRow.UseVisualStyleBackColor = True
        '
        'btnColumn
        '
        Me.btnColumn.Location = New System.Drawing.Point(327, 128)
        Me.btnColumn.Name = "btnColumn"
        Me.btnColumn.Size = New System.Drawing.Size(145, 80)
        Me.btnColumn.TabIndex = 1
        Me.btnColumn.Text = "Display data item column wise"
        Me.btnColumn.UseVisualStyleBackColor = True
        '
        'btnAtOnce
        '
        Me.btnAtOnce.Location = New System.Drawing.Point(327, 232)
        Me.btnAtOnce.Name = "btnAtOnce"
        Me.btnAtOnce.Size = New System.Drawing.Size(145, 80)
        Me.btnAtOnce.TabIndex = 2
        Me.btnAtOnce.Text = "Display all data items at once "
        Me.btnAtOnce.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(327, 336)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(145, 88)
        Me.btnSearch.TabIndex = 3
        Me.btnSearch.Text = "Search for a person"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.btnAtOnce)
        Me.Controls.Add(Me.btnColumn)
        Me.Controls.Add(Me.btnRow)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnRow As Button
    Friend WithEvents btnColumn As Button
    Friend WithEvents btnAtOnce As Button
    Friend WithEvents btnSearch As Button
End Class
