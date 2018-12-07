<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Menuu
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Menuu))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.SandwichsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PlatsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PizzasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaladesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SpecialsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BoissonsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GlacesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UersManagToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SandwichsToolStripMenuItem, Me.PlatsToolStripMenuItem, Me.PizzasToolStripMenuItem, Me.SaladesToolStripMenuItem, Me.SpecialsToolStripMenuItem, Me.BoissonsToolStripMenuItem, Me.GlacesToolStripMenuItem, Me.UersManagToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(809, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'SandwichsToolStripMenuItem
        '
        Me.SandwichsToolStripMenuItem.Name = "SandwichsToolStripMenuItem"
        Me.SandwichsToolStripMenuItem.Size = New System.Drawing.Size(81, 20)
        Me.SandwichsToolStripMenuItem.Text = "Sandwiches"
        '
        'PlatsToolStripMenuItem
        '
        Me.PlatsToolStripMenuItem.Name = "PlatsToolStripMenuItem"
        Me.PlatsToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.PlatsToolStripMenuItem.Text = "Dishes"
        '
        'PizzasToolStripMenuItem
        '
        Me.PizzasToolStripMenuItem.Name = "PizzasToolStripMenuItem"
        Me.PizzasToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.PizzasToolStripMenuItem.Text = "Pizzas"
        '
        'SaladesToolStripMenuItem
        '
        Me.SaladesToolStripMenuItem.Name = "SaladesToolStripMenuItem"
        Me.SaladesToolStripMenuItem.Size = New System.Drawing.Size(58, 20)
        Me.SaladesToolStripMenuItem.Text = "Salades"
        '
        'SpecialsToolStripMenuItem
        '
        Me.SpecialsToolStripMenuItem.Name = "SpecialsToolStripMenuItem"
        Me.SpecialsToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.SpecialsToolStripMenuItem.Text = "Specials"
        '
        'BoissonsToolStripMenuItem
        '
        Me.BoissonsToolStripMenuItem.Name = "BoissonsToolStripMenuItem"
        Me.BoissonsToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.BoissonsToolStripMenuItem.Text = "Drinks"
        '
        'GlacesToolStripMenuItem
        '
        Me.GlacesToolStripMenuItem.Name = "GlacesToolStripMenuItem"
        Me.GlacesToolStripMenuItem.Size = New System.Drawing.Size(77, 20)
        Me.GlacesToolStripMenuItem.Text = "Ice Creams"
        '
        'UersManagToolStripMenuItem
        '
        Me.UersManagToolStripMenuItem.Name = "UersManagToolStripMenuItem"
        Me.UersManagToolStripMenuItem.Size = New System.Drawing.Size(79, 20)
        Me.UersManagToolStripMenuItem.Text = "UersManag"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'Menuu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(809, 446)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Menuu"
        Me.Text = "Menu"
        Me.TransparencyKey = System.Drawing.Color.White
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents SandwichsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PlatsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PizzasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaladesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SpecialsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BoissonsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GlacesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UersManagToolStripMenuItem As ToolStripMenuItem
End Class
