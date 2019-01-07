<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRenomear
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRenomear))
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtREN = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtDe = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtPara = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.btnVisualizar = New System.Windows.Forms.Button
        Me.btnRenomear = New System.Windows.Forms.Button
        Me.btnFechar = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(211, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(217, 52)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Diretório indicado terá seus subdiretórios e " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "arquivos renomeados conforme másca" & _
            "ra de " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "substituição informada. Verifique antes como" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ficará o diretório."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(37, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(234, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Diretório que terá seus elementos renomeados..."
        '
        'txtREN
        '
        Me.txtREN.Location = New System.Drawing.Point(39, 92)
        Me.txtREN.Name = "txtREN"
        Me.txtREN.Size = New System.Drawing.Size(361, 20)
        Me.txtREN.TabIndex = 2
        Me.txtREN.Text = "C:\APAGAR"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(37, 128)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "De..."
        '
        'txtDe
        '
        Me.txtDe.Location = New System.Drawing.Point(39, 144)
        Me.txtDe.Name = "txtDe"
        Me.txtDe.Size = New System.Drawing.Size(169, 20)
        Me.txtDe.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(229, 128)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Para..."
        '
        'txtPara
        '
        Me.txtPara.Location = New System.Drawing.Point(231, 144)
        Me.txtPara.Name = "txtPara"
        Me.txtPara.Size = New System.Drawing.Size(169, 20)
        Me.txtPara.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(120, 48)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "RENOMEAR" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "CUIDADO"
        '
        'btnVisualizar
        '
        Me.btnVisualizar.Location = New System.Drawing.Point(50, 213)
        Me.btnVisualizar.Name = "btnVisualizar"
        Me.btnVisualizar.Size = New System.Drawing.Size(122, 34)
        Me.btnVisualizar.TabIndex = 9
        Me.btnVisualizar.Text = "Visualizar"
        Me.btnVisualizar.UseVisualStyleBackColor = True
        '
        'btnRenomear
        '
        Me.btnRenomear.Location = New System.Drawing.Point(178, 213)
        Me.btnRenomear.Name = "btnRenomear"
        Me.btnRenomear.Size = New System.Drawing.Size(122, 34)
        Me.btnRenomear.TabIndex = 9
        Me.btnRenomear.Text = "Renomear"
        Me.btnRenomear.UseVisualStyleBackColor = True
        '
        'btnFechar
        '
        Me.btnFechar.Location = New System.Drawing.Point(306, 213)
        Me.btnFechar.Name = "btnFechar"
        Me.btnFechar.Size = New System.Drawing.Size(122, 34)
        Me.btnFechar.TabIndex = 9
        Me.btnFechar.Text = "Fechar"
        Me.btnFechar.UseVisualStyleBackColor = True
        '
        'frmRenomear
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(456, 278)
        Me.Controls.Add(Me.btnFechar)
        Me.Controls.Add(Me.btnRenomear)
        Me.Controls.Add(Me.btnVisualizar)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtPara)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtDe)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtREN)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmRenomear"
        Me.ShowInTaskbar = False
        Me.Text = "Renomear"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtREN As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtDe As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtPara As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnVisualizar As System.Windows.Forms.Button
    Friend WithEvents btnRenomear As System.Windows.Forms.Button
    Friend WithEvents btnFechar As System.Windows.Forms.Button
End Class
