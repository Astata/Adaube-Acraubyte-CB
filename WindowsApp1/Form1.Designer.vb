<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.Fichier = New System.Windows.Forms.ToolStripMenuItem()
        Me.NouveauToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OuvrirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnregistrerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnregistrerSousToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AffichageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FenêtreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AideToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AllerSurLeSiteDeAdaubeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InformationDuLApplicationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OutilsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip3 = New System.Windows.Forms.MenuStrip()
        Me.ListeDeFichierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RécentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnvoyerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DocumentCloudToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CreativeCloudToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AjouterUnCompteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem6 = New System.Windows.Forms.ToolStripMenuItem()
        Me.VotreComtpeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem7 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip2.SuspendLayout()
        Me.MenuStrip3.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Fichier, Me.EditionToolStripMenuItem, Me.AffichageToolStripMenuItem, Me.FenêtreToolStripMenuItem, Me.AideToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(127, 426)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MenuStrip1.Size = New System.Drawing.Size(673, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'Fichier
        '
        Me.Fichier.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NouveauToolStripMenuItem, Me.OuvrirToolStripMenuItem, Me.EnregistrerToolStripMenuItem, Me.EnregistrerSousToolStripMenuItem})
        Me.Fichier.Name = "Fichier"
        Me.Fichier.Size = New System.Drawing.Size(54, 20)
        Me.Fichier.Text = "Fichier"
        '
        'NouveauToolStripMenuItem
        '
        Me.NouveauToolStripMenuItem.Name = "NouveauToolStripMenuItem"
        Me.NouveauToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.NouveauToolStripMenuItem.Text = "Nouveau"
        '
        'OuvrirToolStripMenuItem
        '
        Me.OuvrirToolStripMenuItem.Name = "OuvrirToolStripMenuItem"
        Me.OuvrirToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.OuvrirToolStripMenuItem.Text = "Ouvrir"
        '
        'EnregistrerToolStripMenuItem
        '
        Me.EnregistrerToolStripMenuItem.Name = "EnregistrerToolStripMenuItem"
        Me.EnregistrerToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.EnregistrerToolStripMenuItem.Text = "Enregistrer"
        '
        'EnregistrerSousToolStripMenuItem
        '
        Me.EnregistrerSousToolStripMenuItem.Name = "EnregistrerSousToolStripMenuItem"
        Me.EnregistrerSousToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.EnregistrerSousToolStripMenuItem.Text = "Enregistrer Sous"
        '
        'EditionToolStripMenuItem
        '
        Me.EditionToolStripMenuItem.Name = "EditionToolStripMenuItem"
        Me.EditionToolStripMenuItem.Size = New System.Drawing.Size(56, 20)
        Me.EditionToolStripMenuItem.Text = "Edition"
        '
        'AffichageToolStripMenuItem
        '
        Me.AffichageToolStripMenuItem.Name = "AffichageToolStripMenuItem"
        Me.AffichageToolStripMenuItem.Size = New System.Drawing.Size(70, 20)
        Me.AffichageToolStripMenuItem.Text = "Affichage"
        '
        'FenêtreToolStripMenuItem
        '
        Me.FenêtreToolStripMenuItem.Name = "FenêtreToolStripMenuItem"
        Me.FenêtreToolStripMenuItem.Size = New System.Drawing.Size(58, 20)
        Me.FenêtreToolStripMenuItem.Text = "Fenêtre"
        '
        'AideToolStripMenuItem
        '
        Me.AideToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AllerSurLeSiteDeAdaubeToolStripMenuItem, Me.InformationDuLApplicationToolStripMenuItem})
        Me.AideToolStripMenuItem.Name = "AideToolStripMenuItem"
        Me.AideToolStripMenuItem.Size = New System.Drawing.Size(251, 20)
        Me.AideToolStripMenuItem.Text = "Coucou le coucou qui dit coucou le coucou"
        '
        'AllerSurLeSiteDeAdaubeToolStripMenuItem
        '
        Me.AllerSurLeSiteDeAdaubeToolStripMenuItem.Name = "AllerSurLeSiteDeAdaubeToolStripMenuItem"
        Me.AllerSurLeSiteDeAdaubeToolStripMenuItem.Size = New System.Drawing.Size(222, 22)
        Me.AllerSurLeSiteDeAdaubeToolStripMenuItem.Text = "Aller sur le site de Adaube"
        '
        'InformationDuLApplicationToolStripMenuItem
        '
        Me.InformationDuLApplicationToolStripMenuItem.Name = "InformationDuLApplicationToolStripMenuItem"
        Me.InformationDuLApplicationToolStripMenuItem.Size = New System.Drawing.Size(222, 22)
        Me.InformationDuLApplicationToolStripMenuItem.Text = "Information du l'application"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(0, 427)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Rasputin"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'MenuStrip2
        '
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem, Me.OutilsToolStripMenuItem, Me.ToolStripMenuItem5, Me.ToolStripMenuItem6, Me.VotreComtpeToolStripMenuItem, Me.ToolStripMenuItem7})
        Me.MenuStrip2.Location = New System.Drawing.Point(127, 0)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Size = New System.Drawing.Size(673, 24)
        Me.MenuStrip2.TabIndex = 2
        Me.MenuStrip2.Text = "MenuStrip2"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.MenuToolStripMenuItem.Text = "Menu"
        '
        'OutilsToolStripMenuItem
        '
        Me.OutilsToolStripMenuItem.Name = "OutilsToolStripMenuItem"
        Me.OutilsToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.OutilsToolStripMenuItem.Text = "Outils"
        '
        'MenuStrip3
        '
        Me.MenuStrip3.Dock = System.Windows.Forms.DockStyle.Left
        Me.MenuStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ListeDeFichierToolStripMenuItem, Me.RécentToolStripMenuItem, Me.EnvoyerToolStripMenuItem, Me.ToolStripMenuItem1, Me.ToolStripMenuItem2, Me.ToolStripMenuItem3, Me.ToolStripMenuItem4, Me.DocumentCloudToolStripMenuItem, Me.CreativeCloudToolStripMenuItem, Me.AjouterUnCompteToolStripMenuItem})
        Me.MenuStrip3.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip3.Name = "MenuStrip3"
        Me.MenuStrip3.Size = New System.Drawing.Size(127, 450)
        Me.MenuStrip3.TabIndex = 3
        Me.MenuStrip3.Text = "MenuStrip3"
        '
        'ListeDeFichierToolStripMenuItem
        '
        Me.ListeDeFichierToolStripMenuItem.Name = "ListeDeFichierToolStripMenuItem"
        Me.ListeDeFichierToolStripMenuItem.Size = New System.Drawing.Size(114, 19)
        Me.ListeDeFichierToolStripMenuItem.Text = "Liste de fichier"
        '
        'RécentToolStripMenuItem
        '
        Me.RécentToolStripMenuItem.Name = "RécentToolStripMenuItem"
        Me.RécentToolStripMenuItem.Size = New System.Drawing.Size(114, 19)
        Me.RécentToolStripMenuItem.Text = "Récent"
        '
        'EnvoyerToolStripMenuItem
        '
        Me.EnvoyerToolStripMenuItem.Name = "EnvoyerToolStripMenuItem"
        Me.EnvoyerToolStripMenuItem.Size = New System.Drawing.Size(114, 19)
        Me.EnvoyerToolStripMenuItem.Text = "Envoyer"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(114, 19)
        Me.ToolStripMenuItem1.Text = "   "
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(114, 19)
        Me.ToolStripMenuItem2.Text = "    "
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(114, 19)
        Me.ToolStripMenuItem3.Text = "   "
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(114, 19)
        Me.ToolStripMenuItem4.Text = "Mon Ordinateur"
        '
        'DocumentCloudToolStripMenuItem
        '
        Me.DocumentCloudToolStripMenuItem.Name = "DocumentCloudToolStripMenuItem"
        Me.DocumentCloudToolStripMenuItem.Size = New System.Drawing.Size(114, 19)
        Me.DocumentCloudToolStripMenuItem.Text = "Document Cloud"
        '
        'CreativeCloudToolStripMenuItem
        '
        Me.CreativeCloudToolStripMenuItem.Name = "CreativeCloudToolStripMenuItem"
        Me.CreativeCloudToolStripMenuItem.Size = New System.Drawing.Size(114, 19)
        Me.CreativeCloudToolStripMenuItem.Text = "Nuage Créatif"
        '
        'AjouterUnCompteToolStripMenuItem
        '
        Me.AjouterUnCompteToolStripMenuItem.Name = "AjouterUnCompteToolStripMenuItem"
        Me.AjouterUnCompteToolStripMenuItem.Size = New System.Drawing.Size(114, 19)
        Me.AjouterUnCompteToolStripMenuItem.Text = "Ajouter un Compte"
        '
        'ToolStripMenuItem5
        '
        Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        Me.ToolStripMenuItem5.Size = New System.Drawing.Size(199, 20)
        Me.ToolStripMenuItem5.Text = "                                                            "
        '
        'ToolStripMenuItem6
        '
        Me.ToolStripMenuItem6.Name = "ToolStripMenuItem6"
        Me.ToolStripMenuItem6.Size = New System.Drawing.Size(145, 20)
        Me.ToolStripMenuItem6.Text = "                                          "
        '
        'VotreComtpeToolStripMenuItem
        '
        Me.VotreComtpeToolStripMenuItem.Name = "VotreComtpeToolStripMenuItem"
        Me.VotreComtpeToolStripMenuItem.Size = New System.Drawing.Size(92, 20)
        Me.VotreComtpeToolStripMenuItem.Text = "Votre Compte"
        '
        'ToolStripMenuItem7
        '
        Me.ToolStripMenuItem7.Name = "ToolStripMenuItem7"
        Me.ToolStripMenuItem7.Size = New System.Drawing.Size(12, 20)
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.MenuStrip2)
        Me.Controls.Add(Me.MenuStrip3)
        Me.Cursor = System.Windows.Forms.Cursors.Cross
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Text = "Adaube Acraubyte CB"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        Me.MenuStrip3.ResumeLayout(False)
        Me.MenuStrip3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents Fichier As ToolStripMenuItem
    Friend WithEvents NouveauToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OuvrirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EnregistrerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EnregistrerToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents EditionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FenêtreToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AideToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AllerSurLeSiteDeAdaubeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InformationDuLApplicationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EnregistrerSousToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents Button1 As Button
    Friend WithEvents AffichageToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuStrip2 As MenuStrip
    Friend WithEvents MenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OutilsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuStrip3 As MenuStrip
    Friend WithEvents ListeDeFichierToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RécentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EnvoyerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As ToolStripMenuItem
    Friend WithEvents DocumentCloudToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CreativeCloudToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AjouterUnCompteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem5 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem6 As ToolStripMenuItem
    Friend WithEvents VotreComtpeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem7 As ToolStripMenuItem
End Class
