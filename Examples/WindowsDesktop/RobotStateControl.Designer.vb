<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RobotStateControl
    Inherits System.Windows.Forms.UserControl

    'UserControl remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.grid = New System.Windows.Forms.PropertyGrid()
        Me.lbl = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'grid
        '
        Me.grid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grid.HelpVisible = False
        Me.grid.Location = New System.Drawing.Point(0, 37)
        Me.grid.Name = "grid"
        Me.grid.PropertySort = System.Windows.Forms.PropertySort.NoSort
        Me.grid.Size = New System.Drawing.Size(287, 401)
        Me.grid.TabIndex = 1
        Me.grid.ToolbarVisible = False
        '
        'lbl
        '
        Me.lbl.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lbl.Location = New System.Drawing.Point(0, 0)
        Me.lbl.Name = "lbl"
        Me.lbl.Size = New System.Drawing.Size(287, 37)
        Me.lbl.TabIndex = 0
        Me.lbl.Text = "Label1"
        Me.lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RobotStateControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.grid)
        Me.Controls.Add(Me.lbl)
        Me.Name = "RobotStateControl"
        Me.Size = New System.Drawing.Size(287, 438)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grid As System.Windows.Forms.PropertyGrid
    Friend WithEvents lbl As System.Windows.Forms.Label

End Class
