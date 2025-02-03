
Partial Class PrimaryInterfacePackageControl
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
        grid = New Windows.Forms.PropertyGrid()
        lbl = New Windows.Forms.Label()
        tableLayoutPanel1 = New Windows.Forms.TableLayoutPanel()
        tableLayoutPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' grid
        ' 
        grid.Dock = Windows.Forms.DockStyle.Fill
        grid.HelpVisible = False
        grid.Location = New Drawing.Point(0, 20)
        grid.Name = "grid"
        grid.PropertySort = Windows.Forms.PropertySort.NoSort
        grid.Size = New Drawing.Size(378, 500)
        grid.TabIndex = 3
        grid.ToolbarVisible = False
        ' 
        ' lbl
        ' 
        lbl.Anchor = Windows.Forms.AnchorStyles.None
        lbl.AutoSize = True
        lbl.Font = New Drawing.Font("Microsoft Sans Serif", 12F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, 0)
        lbl.Location = New Drawing.Point(157, 0)
        lbl.Name = "lbl"
        lbl.Size = New Drawing.Size(63, 20)
        lbl.TabIndex = 3
        lbl.Text = "Label1"
        lbl.TextAlign = Drawing.ContentAlignment.MiddleCenter
        ' 
        ' tableLayoutPanel1
        ' 
        tableLayoutPanel1.AutoSize = True
        tableLayoutPanel1.ColumnCount = 1
        tableLayoutPanel1.ColumnStyles.Add(New Windows.Forms.ColumnStyle(Windows.Forms.SizeType.Percent, 50F))
        tableLayoutPanel1.Controls.Add(lbl, 0, 0)
        tableLayoutPanel1.Dock = Windows.Forms.DockStyle.Top
        tableLayoutPanel1.Location = New Drawing.Point(0, 0)
        tableLayoutPanel1.Name = "tableLayoutPanel1"
        tableLayoutPanel1.RowCount = 1
        tableLayoutPanel1.RowStyles.Add(New Windows.Forms.RowStyle(Windows.Forms.SizeType.Percent, 50F))
        tableLayoutPanel1.Size = New Drawing.Size(378, 20)
        tableLayoutPanel1.TabIndex = 5
        ' 
        ' PrimaryInterfacePackageControl
        ' 
        AutoScaleDimensions = New Drawing.SizeF(6F, 13F)
        AutoScaleMode = Windows.Forms.AutoScaleMode.Font
        BackColor = Drawing.SystemColors.Window
        BorderStyle = Windows.Forms.BorderStyle.FixedSingle
        Controls.Add(grid)
        Controls.Add(tableLayoutPanel1)
        Name = "PrimaryInterfacePackageControl"
        Size = New Drawing.Size(378, 520)
        tableLayoutPanel1.ResumeLayout(False)
        tableLayoutPanel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()

    End Sub

#End Region

    Friend grid As Windows.Forms.PropertyGrid
    Friend lbl As Windows.Forms.Label
    Private tableLayoutPanel1 As Windows.Forms.TableLayoutPanel
End Class
