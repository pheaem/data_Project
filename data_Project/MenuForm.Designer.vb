<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuForm
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
        Me.btnEmployee = New System.Windows.Forms.Button()
        Me.btnInventory = New System.Windows.Forms.Button()
        Me.btnSaleMenu = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnEmployee
        '
        Me.btnEmployee.Location = New System.Drawing.Point(676, 229)
        Me.btnEmployee.Name = "btnEmployee"
        Me.btnEmployee.Size = New System.Drawing.Size(265, 187)
        Me.btnEmployee.TabIndex = 7
        Me.btnEmployee.Text = "Employee"
        Me.btnEmployee.UseVisualStyleBackColor = True
        '
        'btnInventory
        '
        Me.btnInventory.Location = New System.Drawing.Point(387, 229)
        Me.btnInventory.Name = "btnInventory"
        Me.btnInventory.Size = New System.Drawing.Size(265, 187)
        Me.btnInventory.TabIndex = 6
        Me.btnInventory.Text = "Inventory"
        Me.btnInventory.UseVisualStyleBackColor = True
        '
        'btnSaleMenu
        '
        Me.btnSaleMenu.Location = New System.Drawing.Point(88, 229)
        Me.btnSaleMenu.Name = "btnSaleMenu"
        Me.btnSaleMenu.Size = New System.Drawing.Size(265, 187)
        Me.btnSaleMenu.TabIndex = 5
        Me.btnSaleMenu.Text = "Sale Menu"
        Me.btnSaleMenu.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(487, 93)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Menu"
        '
        'MenuForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1028, 509)
        Me.Controls.Add(Me.btnEmployee)
        Me.Controls.Add(Me.btnInventory)
        Me.Controls.Add(Me.btnSaleMenu)
        Me.Controls.Add(Me.Label1)
        Me.Name = "MenuForm"
        Me.Text = "MenuForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnEmployee As Button
    Friend WithEvents btnInventory As Button
    Friend WithEvents btnSaleMenu As Button
    Friend WithEvents Label1 As Label
End Class
