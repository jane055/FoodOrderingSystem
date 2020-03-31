<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Starter
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
        Me.btnStarter = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnStarter
        '
        Me.btnStarter.Font = New System.Drawing.Font("MS Reference Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStarter.Location = New System.Drawing.Point(0, 24)
        Me.btnStarter.Name = "btnStarter"
        Me.btnStarter.Size = New System.Drawing.Size(471, 256)
        Me.btnStarter.TabIndex = 0
        Me.btnStarter.Text = " Click to begin order!"
        Me.btnStarter.UseVisualStyleBackColor = False
        '
        'Starter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(471, 315)
        Me.Controls.Add(Me.btnStarter)
        Me.Name = "Starter"
        Me.Text = "Starter"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnStarter As Button
End Class
