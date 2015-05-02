<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class progressbar_form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(progressbar_form))
        Me.progress_bar = New System.Windows.Forms.ProgressBar()
        Me.SuspendLayout()
        '
        'progress_bar
        '
        Me.progress_bar.Location = New System.Drawing.Point(36, 26)
        Me.progress_bar.MarqueeAnimationSpeed = 30
        Me.progress_bar.Name = "progress_bar"
        Me.progress_bar.Size = New System.Drawing.Size(439, 24)
        Me.progress_bar.TabIndex = 1
        '
        'progressbar_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(514, 94)
        Me.ControlBox = False
        Me.Controls.Add(Me.progress_bar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "progressbar_form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PLEASE WAIT WHILE THE SYSTEM FETCH THE RECORDS"
        Me.TopMost = True
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents progress_bar As System.Windows.Forms.ProgressBar
End Class
