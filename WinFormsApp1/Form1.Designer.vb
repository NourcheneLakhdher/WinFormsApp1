<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Rdproposition1 = New RadioButton()
        Rdproposition2 = New RadioButton()
        Rdproposition3 = New RadioButton()
        Chk1 = New CheckBox()
        Chk2 = New CheckBox()
        Chk3 = New CheckBox()
        Chk4 = New CheckBox()
        Btn_aff = New Button()
        RichTextBox1 = New RichTextBox()
        lsttaille = New ComboBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(56, 46)
        Label1.Name = "Label1"
        Label1.Size = New Size(96, 15)
        Label1.TabIndex = 0
        Label1.Text = "Taille de la pizza :"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(60, 106)
        Label2.Name = "Label2"
        Label2.Size = New Size(92, 15)
        Label2.TabIndex = 1
        Label2.Text = "Type de Croute :"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(56, 163)
        Label3.Name = "Label3"
        Label3.Size = New Size(177, 15)
        Label3.TabIndex = 2
        Label3.Text = "Les ingrédients supplémentaire :"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(56, 283)
        Label4.Name = "Label4"
        Label4.Size = New Size(91, 15)
        Label4.TabIndex = 3
        Label4.Text = "Le récapitulatif :"
        ' 
        ' Rdproposition1
        ' 
        Rdproposition1.AutoSize = True
        Rdproposition1.Location = New Point(287, 102)
        Rdproposition1.Name = "Rdproposition1"
        Rdproposition1.Size = New Size(86, 19)
        Rdproposition1.TabIndex = 5
        Rdproposition1.TabStop = True
        Rdproposition1.Text = "Croute Fine"
        Rdproposition1.UseVisualStyleBackColor = True
        ' 
        ' Rdproposition2
        ' 
        Rdproposition2.AutoSize = True
        Rdproposition2.Location = New Point(436, 102)
        Rdproposition2.Name = "Rdproposition2"
        Rdproposition2.Size = New Size(114, 19)
        Rdproposition2.TabIndex = 6
        Rdproposition2.TabStop = True
        Rdproposition2.Text = "Croute Classique"
        Rdproposition2.UseVisualStyleBackColor = True
        ' 
        ' Rdproposition3
        ' 
        Rdproposition3.AutoSize = True
        Rdproposition3.Location = New Point(632, 102)
        Rdproposition3.Name = "Rdproposition3"
        Rdproposition3.Size = New Size(102, 19)
        Rdproposition3.TabIndex = 7
        Rdproposition3.TabStop = True
        Rdproposition3.Text = "Croute épaisse"
        Rdproposition3.UseVisualStyleBackColor = True
        ' 
        ' Chk1
        ' 
        Chk1.AutoSize = True
        Chk1.Location = New Point(297, 158)
        Chk1.Name = "Chk1"
        Chk1.Size = New Size(101, 19)
        Chk1.TabIndex = 8
        Chk1.Text = "Champignons"
        Chk1.UseVisualStyleBackColor = True
        ' 
        ' Chk2
        ' 
        Chk2.AutoSize = True
        Chk2.Location = New Point(492, 158)
        Chk2.Name = "Chk2"
        Chk2.Size = New Size(58, 19)
        Chk2.TabIndex = 9
        Chk2.Text = "Olives"
        Chk2.UseVisualStyleBackColor = True
        ' 
        ' Chk3
        ' 
        Chk3.AutoSize = True
        Chk3.Location = New Point(647, 158)
        Chk3.Name = "Chk3"
        Chk3.Size = New Size(72, 19)
        Chk3.TabIndex = 10
        Chk3.Text = "Poivrons"
        Chk3.UseVisualStyleBackColor = True
        ' 
        ' Chk4
        ' 
        Chk4.AutoSize = True
        Chk4.Location = New Point(436, 196)
        Chk4.Name = "Chk4"
        Chk4.Size = New Size(165, 19)
        Chk4.TabIndex = 11
        Chk4.Text = "Frommage supplémentaie"
        Chk4.UseVisualStyleBackColor = True
        ' 
        ' Btn_aff
        ' 
        Btn_aff.Location = New Point(241, 279)
        Btn_aff.Name = "Btn_aff"
        Btn_aff.Size = New Size(75, 23)
        Btn_aff.TabIndex = 12
        Btn_aff.Text = "Afficher"
        Btn_aff.UseVisualStyleBackColor = True
        ' 
        ' RichTextBox1
        ' 
        RichTextBox1.Location = New Point(450, 252)
        RichTextBox1.Name = "RichTextBox1"
        RichTextBox1.Size = New Size(227, 96)
        RichTextBox1.TabIndex = 13
        RichTextBox1.Text = ""
        ' 
        ' lsttaille
        ' 
        lsttaille.FormattingEnabled = True
        lsttaille.Items.AddRange(New Object() {"petite", "moyenne", "grande"})
        lsttaille.Location = New Point(284, 42)
        lsttaille.Name = "lsttaille"
        lsttaille.Size = New Size(121, 23)
        lsttaille.TabIndex = 14
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources._7df1bf31_c9fe_4467_b531_fc316d7b5d0a
        ClientSize = New Size(800, 450)
        Controls.Add(lsttaille)
        Controls.Add(RichTextBox1)
        Controls.Add(Btn_aff)
        Controls.Add(Chk4)
        Controls.Add(Chk3)
        Controls.Add(Chk2)
        Controls.Add(Chk1)
        Controls.Add(Rdproposition3)
        Controls.Add(Rdproposition2)
        Controls.Add(Rdproposition1)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Olives"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Btn_aff As ComboBox
    Friend WithEvents Rdproposition1 As RadioButton
    Friend WithEvents Rdproposition2 As RadioButton
    Friend WithEvents Rdproposition3 As RadioButton
    Friend WithEvents Chk1 As CheckBox
    Friend WithEvents Chk2 As CheckBox
    Friend WithEvents Chk3 As CheckBox
    Friend WithEvents Chk4 As CheckBox
    Friend WithEvents Btn_aff As Button
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents lsttaille As ComboBox

End Class
