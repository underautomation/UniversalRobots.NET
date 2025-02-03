
Partial Class LogControl
    ''' <summary> 
    ''' Variable nécessaire au concepteur.
    ''' </summary>
    Private components As ComponentModel.IContainer = Nothing

    ''' <summary> 
    ''' Nettoyage des ressources utilisées.
    ''' </summary>
    ''' <paramname="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
    Protected Overrides Sub Dispose(disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

#Region "Code généré par le Concepteur de composants"

    ''' <summary> 
    ''' Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
    ''' le contenu de cette méthode avec l'éditeur de code.
    ''' </summary>
    Private Sub InitializeComponent()
        dlgOpen = New Windows.Forms.OpenFileDialog()
        txtLog = New Windows.Forms.RichTextBox()
        SuspendLayout()
        ' 
        ' dlgOpen
        ' 
        dlgOpen.Filter = "Program or installation|*.urp;*.installation|All files|*.*"
        dlgOpen.RestoreDirectory = True
        ' 
        ' txtLog
        ' 
        txtLog.Dock = Windows.Forms.DockStyle.Fill
        txtLog.Location = New Drawing.Point(0, 0)
        txtLog.Name = "txtLog"
        txtLog.ReadOnly = True
        txtLog.Size = New Drawing.Size(660, 476)
        txtLog.TabIndex = 0
        txtLog.Text = ""
        ' 
        ' LogControl
        ' 
        AutoScaleDimensions = New Drawing.SizeF(6F, 13F)
        AutoScaleMode = Windows.Forms.AutoScaleMode.Font
        Controls.Add(txtLog)
        Name = "LogControl"
        Size = New Drawing.Size(660, 476)
        ResumeLayout(False)

    End Sub

#End Region
    Private dlgOpen As Windows.Forms.OpenFileDialog
    Private txtLog As Windows.Forms.RichTextBox
End Class
