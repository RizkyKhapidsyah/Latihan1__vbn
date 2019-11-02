<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DemoAngka
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
        Me.ListBoxHasil = New System.Windows.Forms.ListBox()
        Me.TextKelipatan = New System.Windows.Forms.TextBox()
        Me.LabelKelipatan = New System.Windows.Forms.Label()
        Me.ButtonProses = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ListBoxHasil
        '
        Me.ListBoxHasil.FormattingEnabled = True
        Me.ListBoxHasil.Location = New System.Drawing.Point(12, 12)
        Me.ListBoxHasil.Name = "ListBoxHasil"
        Me.ListBoxHasil.Size = New System.Drawing.Size(419, 95)
        Me.ListBoxHasil.TabIndex = 0
        '
        'TextKelipatan
        '
        Me.TextKelipatan.Location = New System.Drawing.Point(12, 126)
        Me.TextKelipatan.Name = "TextKelipatan"
        Me.TextKelipatan.Size = New System.Drawing.Size(39, 20)
        Me.TextKelipatan.TabIndex = 1
        '
        'LabelKelipatan
        '
        Me.LabelKelipatan.AutoSize = True
        Me.LabelKelipatan.Location = New System.Drawing.Point(12, 110)
        Me.LabelKelipatan.Name = "LabelKelipatan"
        Me.LabelKelipatan.Size = New System.Drawing.Size(39, 13)
        Me.LabelKelipatan.TabIndex = 2
        Me.LabelKelipatan.Text = "Label1"
        '
        'ButtonProses
        '
        Me.ButtonProses.Location = New System.Drawing.Point(356, 113)
        Me.ButtonProses.Name = "ButtonProses"
        Me.ButtonProses.Size = New System.Drawing.Size(75, 33)
        Me.ButtonProses.TabIndex = 3
        Me.ButtonProses.Text = "Button1"
        Me.ButtonProses.UseVisualStyleBackColor = True
        '
        'DemoAngka
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(443, 160)
        Me.Controls.Add(Me.ButtonProses)
        Me.Controls.Add(Me.LabelKelipatan)
        Me.Controls.Add(Me.TextKelipatan)
        Me.Controls.Add(Me.ListBoxHasil)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "DemoAngka"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListBoxHasil As ListBox
    Friend WithEvents TextKelipatan As TextBox
    Friend WithEvents LabelKelipatan As Label
    Friend WithEvents ButtonProses As Button
End Class
