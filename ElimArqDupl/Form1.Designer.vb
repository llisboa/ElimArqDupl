<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.txtELIM = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtPesq = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.lblQTD = New System.Windows.Forms.Label
        Me.btnExec = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.LBLtAM = New System.Windows.Forms.Label
        Me.mnuPrinc = New System.Windows.Forms.MenuStrip
        Me.UtilitáriosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RenomearDirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.lblAcompanha = New System.Windows.Forms.ToolStripStatusLabel
        Me.txtSubBusca = New System.Windows.Forms.CheckBox
        Me.txtSubRef = New System.Windows.Forms.CheckBox
        Me.BGProcura = New System.ComponentModel.BackgroundWorker
        Me.btnCancelar = New System.Windows.Forms.Button
        Me.mnuPrinc.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtELIM
        '
        Me.txtELIM.Location = New System.Drawing.Point(139, 48)
        Me.txtELIM.Name = "txtELIM"
        Me.txtELIM.Size = New System.Drawing.Size(361, 20)
        Me.txtELIM.TabIndex = 1
        Me.txtELIM.Text = "C:\APAGAR"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(137, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(363, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Diretório onde serão eliminados os arquivos ou diretórios SEMELHANTES..."
        '
        'txtPesq
        '
        Me.txtPesq.Location = New System.Drawing.Point(139, 118)
        Me.txtPesq.Name = "txtPesq"
        Me.txtPesq.Size = New System.Drawing.Size(361, 20)
        Me.txtPesq.TabIndex = 2
        Me.txtPesq.Text = "C:\REF"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(137, 102)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(230, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Diretório onde serão pesquisados os arquivos..."
        '
        'lblQTD
        '
        Me.lblQTD.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQTD.Location = New System.Drawing.Point(8, 56)
        Me.lblQTD.Name = "lblQTD"
        Me.lblQTD.Size = New System.Drawing.Size(121, 46)
        Me.lblQTD.TabIndex = 0
        Me.lblQTD.Text = "000"
        Me.lblQTD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnExec
        '
        Me.btnExec.Location = New System.Drawing.Point(381, 182)
        Me.btnExec.Name = "btnExec"
        Me.btnExec.Size = New System.Drawing.Size(125, 32)
        Me.btnExec.TabIndex = 3
        Me.btnExec.Text = "Executar"
        Me.btnExec.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(40, 47)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Eliminados"
        '
        'LBLtAM
        '
        Me.LBLtAM.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLtAM.Location = New System.Drawing.Point(7, 103)
        Me.LBLtAM.Name = "LBLtAM"
        Me.LBLtAM.Size = New System.Drawing.Size(122, 21)
        Me.LBLtAM.TabIndex = 5
        Me.LBLtAM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'mnuPrinc
        '
        Me.mnuPrinc.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UtilitáriosToolStripMenuItem})
        Me.mnuPrinc.Location = New System.Drawing.Point(0, 0)
        Me.mnuPrinc.Name = "mnuPrinc"
        Me.mnuPrinc.Size = New System.Drawing.Size(560, 24)
        Me.mnuPrinc.TabIndex = 6
        Me.mnuPrinc.Text = "MenuStrip1"
        '
        'UtilitáriosToolStripMenuItem
        '
        Me.UtilitáriosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RenomearDirToolStripMenuItem})
        Me.UtilitáriosToolStripMenuItem.Name = "UtilitáriosToolStripMenuItem"
        Me.UtilitáriosToolStripMenuItem.Size = New System.Drawing.Size(63, 20)
        Me.UtilitáriosToolStripMenuItem.Text = "Utilitários"
        '
        'RenomearDirToolStripMenuItem
        '
        Me.RenomearDirToolStripMenuItem.Name = "RenomearDirToolStripMenuItem"
        Me.RenomearDirToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.RenomearDirToolStripMenuItem.Text = "Renomear Dir"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(48, 247)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(458, 26)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Atenção: Este programa tem como objetivo a performance e por isso abre mão da pre" & _
            "cisão." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Critério de procura de arquivos é a semelhança pela comparação de NOME e" & _
            " tamanho apenas."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(48, 186)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(303, 26)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "FAÇA BACKUP ANTES DE EXECUTAR ESTE PROGRAMA." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "EXECUTE SOMENTE SE SOUBER O QUE EST" & _
            "Á FAZENDO."
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblAcompanha})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 288)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(560, 22)
        Me.StatusStrip1.TabIndex = 9
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lblAcompanha
        '
        Me.lblAcompanha.Name = "lblAcompanha"
        Me.lblAcompanha.Size = New System.Drawing.Size(0, 17)
        '
        'txtSubBusca
        '
        Me.txtSubBusca.AutoSize = True
        Me.txtSubBusca.Checked = True
        Me.txtSubBusca.CheckState = System.Windows.Forms.CheckState.Checked
        Me.txtSubBusca.Location = New System.Drawing.Point(344, 70)
        Me.txtSubBusca.Name = "txtSubBusca"
        Me.txtSubBusca.Size = New System.Drawing.Size(159, 17)
        Me.txtSubBusca.TabIndex = 10
        Me.txtSubBusca.Text = "Incluir Itens de Subdiretórios"
        Me.txtSubBusca.UseVisualStyleBackColor = True
        '
        'txtSubRef
        '
        Me.txtSubRef.AutoSize = True
        Me.txtSubRef.Checked = True
        Me.txtSubRef.CheckState = System.Windows.Forms.CheckState.Checked
        Me.txtSubRef.Location = New System.Drawing.Point(344, 141)
        Me.txtSubRef.Name = "txtSubRef"
        Me.txtSubRef.Size = New System.Drawing.Size(159, 17)
        Me.txtSubRef.TabIndex = 11
        Me.txtSubRef.Text = "Incluir Itens de Subdiretórios"
        Me.txtSubRef.UseVisualStyleBackColor = True
        '
        'BGProcura
        '
        Me.BGProcura.WorkerSupportsCancellation = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelar.Location = New System.Drawing.Point(442, 288)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(120, 24)
        Me.btnCancelar.TabIndex = 12
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        Me.btnCancelar.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(560, 310)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.txtSubRef)
        Me.Controls.Add(Me.txtSubBusca)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.mnuPrinc)
        Me.Controls.Add(Me.LBLtAM)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnExec)
        Me.Controls.Add(Me.lblQTD)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtPesq)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtELIM)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "ElimAplDupl - Intercraft Solutions - 2013"
        Me.mnuPrinc.ResumeLayout(False)
        Me.mnuPrinc.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtELIM As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtPesq As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblQTD As System.Windows.Forms.Label
    Friend WithEvents btnExec As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents LBLtAM As System.Windows.Forms.Label
    Friend WithEvents mnuPrinc As System.Windows.Forms.MenuStrip
    Friend WithEvents UtilitáriosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RenomearDirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents lblAcompanha As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents txtSubBusca As System.Windows.Forms.CheckBox
    Friend WithEvents txtSubRef As System.Windows.Forms.CheckBox
    Friend WithEvents BGProcura As System.ComponentModel.BackgroundWorker
    Friend WithEvents btnCancelar As System.Windows.Forms.Button

End Class
