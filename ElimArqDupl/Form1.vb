Public Class Form1
    Enum TipoOpc
        Arquivo
        Diretorio
    End Enum

    Class Lista
        Public Nome As String
        Public Tam As Long
        Public Qtd As Long
        Public Tipo As TipoOpc
        Public NomeCompl As String

        Public Sub Carrega(ByVal Local As String)
            If System.IO.File.Exists(Local) Then
                Tam = New Icraft.IcftBase.ArquivoDet(Local).Tamanho
                Nome = System.IO.Path.GetFileName(Local)
                Qtd = 1
                Tipo = TipoOpc.Arquivo
                NomeCompl = Local
            ElseIf System.IO.Directory.Exists(Local) Then
                Tam = Icraft.IcftBase.TamDir(Local)
                Nome = System.IO.Path.GetFileName(Local)
                Qtd = New System.IO.DirectoryInfo(Local).GetFiles("*.*", IO.SearchOption.AllDirectories).Count
                Tipo = TipoOpc.Diretorio
                NomeCompl = Local
            Else
                Throw New Exception("no apontamento. '" & Local & "' não localizado.")
            End If
        End Sub

        Public Sub New(ByVal local As String)
            Carrega(local)
        End Sub

        Public Shared Function ProcuraPrimeiro(ByVal Compara As List(Of Lista), ByVal Ref As Lista) As Lista
            Dim Ret As List(Of Lista) = Procura(Compara, Ref, TipoProcuraOpc.Primeiro)
            If Ret.Count > 0 Then
                Return Ret(0)
            End If
            Return Nothing
        End Function

        Public Enum TipoProcuraOpc
            Todos
            Primeiro
        End Enum

        Public Shared Function Procura(ByVal Compara As List(Of Lista), ByVal Ref As Lista, ByVal TipoProcura As TipoProcuraOpc) As List(Of Lista)
            Dim Ig As New List(Of Lista)
            For Each Obj As Lista In Compara
                If Icraft.IcftBase.Compare(Obj.Nome, Ref.Nome, True) Then
                    Ig.Add(Obj)
                    If TipoProcura = TipoProcuraOpc.Primeiro Then
                        Exit For
                    End If
                End If
            Next
            Return Ig
        End Function
    End Class

    Public QtdAp As Long = 0
    Public QtdMb As Long = 0

    Sub Notifica(ByVal Texto As String)
        MsgBox(Texto)
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.Text &= " - " & Icraft.IcftBase.VersaoApl
            frmLog.Text = Me.Text & " - Resultado"
            frmRenomear.Text = Me.Text & " - Renomear"
            Icraft.IcftBase.Form.Conteudo(Me, "txt") = Icraft.IcftBase.RegApl("Princ")
        Catch EX As Exception
            MsgBox(EX.Message)
        End Try

    End Sub

    Private Sub RenomearDirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RenomearDirToolStripMenuItem.Click
        Try
            frmRenomear.Show()
            frmRenomear.Focus()
        Catch EX As Exception
            MsgBox(EX.Message)
        End Try
    End Sub

    Sub Acompanha(ByVal Texto As String, Optional ByVal f As Form1 = Nothing)
        If IsNothing(f) Then
            f = Me
        End If
        f.lblAcompanha.Text = Texto
        Application.DoEvents()
    End Sub

    Private Sub btnExec_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExec.Click
        btnExec.Enabled = False
        BGProcura.RunWorkerAsync(Me)
    End Sub

    Delegate Sub ExecProcuraDelegate(ByVal sender As System.ComponentModel.BackgroundWorker, ByVal e As System.ComponentModel.DoWorkEventArgs)
    Public Sub ExecProcura(ByVal sender As System.ComponentModel.BackgroundWorker, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BGProcura.DoWork
        If InvokeRequired Then
            BeginInvoke(New ExecProcuraDelegate(AddressOf ExecProcura), sender, e)
            Exit Sub
        End If
        Dim log As New System.Text.StringBuilder
        Try
            btnCancelar.Visible = True
            Icraft.IcftBase.RegApl("Princ") = Icraft.IcftBase.Form.Conteudo(Me, "txt")
            QtdAp = 0
            QtdMb = 0
            Informa()


            If MsgBox("Arquivos e diretórios SEMELHANTES em '" & txtELIM.Text & "' que existam no diretório de referência serão eliminados. Confirma?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

                log.AppendLine("Início em " & Format(Now, "yyyy-MM-dd HH:mm:ss" & "."))

                Dim Compara As New List(Of Form1.Lista)

                Acompanha("Carregando nomes de arquivos da referência.")
                Dim Ref As ArrayList = Icraft.IcftBase.ParamArrayToArrayList(System.IO.Directory.GetFiles(txtPesq.Text, "*.*", IIf(txtSubRef.Checked, IO.SearchOption.AllDirectories, IO.SearchOption.TopDirectoryOnly)), System.IO.Directory.GetDirectories(txtPesq.Text, "*", IIf(txtSubRef.Checked, IO.SearchOption.AllDirectories, IO.SearchOption.TopDirectoryOnly)))
                Dim RefPos As Long = 0

                If BGProcura.CancellationPending Then
                    Throw New Exception("Procedimento cancelado.")
                End If

                Acompanha("Carregando nomes de arquivos do diretório de busca.")
                Dim BUSCA As ArrayList = Icraft.IcftBase.ParamArrayToArrayList(System.IO.Directory.GetFiles(txtELIM.Text, "*.*", IIf(txtSubBusca.Checked, IO.SearchOption.AllDirectories, IO.SearchOption.TopDirectoryOnly)), System.IO.Directory.GetDirectories(txtELIM.Text, "*.*", IIf(txtSubBusca.Checked, IO.SearchOption.AllDirectories, IO.SearchOption.TopDirectoryOnly)))

                If BGProcura.CancellationPending Then
                    Throw New Exception("Procedimento cancelado.")
                End If


                For Each arq As String In BUSCA
                    Try
                        If BGProcura.CancellationPending Then
                            Throw New Exception("Procedimento cancelado.")
                        End If

                        Acompanha("Procurando " & arq & ".")
                        Dim Atual As New Form1.Lista(arq)
                        Dim ProcL As List(Of Form1.Lista) = Form1.Lista.Procura(Compara, Atual, Form1.Lista.TipoProcuraOpc.Todos)

                        Dim El As Boolean = False

                        If ProcL.Count > 0 Then
                            For Each Proc As Form1.Lista In ProcL
                                If BGProcura.CancellationPending Then
                                    Throw New Exception("Procedimento cancelado.")
                                End If

                                If Icraft.IcftBase.Compare(Atual.Nome, Proc.Nome) AndAlso Atual.Tipo = Proc.Tipo AndAlso Atual.Tam = Proc.Tam AndAlso Atual.Qtd = Proc.Qtd Then
                                    El = True
                                    Exit For
                                End If
                            Next
                        Else
                            Do While RefPos < Ref.Count
                                If BGProcura.CancellationPending Then
                                    Throw New Exception("Procedimento cancelado.")
                                End If

                                If (RefPos Mod 100) = 0 Then
                                    Acompanha("Carregando detalhes de referências: " & RefPos + 1 & " de " & Ref.Count)
                                End If
                                Dim RefDet As New Form1.Lista(Ref(RefPos))
                                RefPos += 1
                                Compara.Add(RefDet)
                                If Icraft.IcftBase.Compare(Atual.Nome, RefDet.Nome) AndAlso Atual.Tipo = RefDet.Tipo AndAlso Atual.Tam = RefDet.Tam AndAlso Atual.Qtd = RefDet.Qtd Then
                                    El = True
                                    Exit Do
                                End If
                            Loop
                            Acompanha("Carga de detalhes das referências concluída. Total: " & Ref.Count)
                        End If
                        If El Then
                            Try
                                If Atual.Tipo = Form1.TipoOpc.Arquivo Then
                                    System.IO.File.Delete(Atual.NomeCompl)
                                    If System.IO.File.Exists(Atual.NomeCompl) Then
                                        log.AppendLine("Não foi possível apagar " & Atual.NomeCompl & ".")
                                    Else
                                        log.AppendLine("Eliminado: " & Atual.NomeCompl & ".")

                                        QtdAp += Atual.Qtd
                                        QtdMb += Int(Atual.Tam / 1024)
                                        Informa()

                                    End If
                                Else
                                    System.IO.Directory.Delete(Atual.NomeCompl, True)
                                    If System.IO.Directory.Exists(Atual.NomeCompl) Then
                                        Dim R As New Form1.Lista(Atual.NomeCompl)
                                        If Not Icraft.IcftBase.Compare(R.Nome, Atual.Nome) OrElse R.Qtd <> Atual.Qtd OrElse R.Tam <> Atual.Tam Then
                                            log.AppendLine("Não foi possível apagar parte do diretório " & Atual.NomeCompl & ".")
                                            QtdAp += Atual.Qtd - R.Qtd
                                            QtdMb += Atual.Tam - R.Tam
                                            Informa()

                                        Else
                                            log.AppendLine("Não foi possível apagar todo o diretório " & Atual.NomeCompl & ".")
                                        End If
                                    Else
                                        log.AppendLine("Eliminado: " & Atual.NomeCompl & ".")

                                        QtdAp += Atual.Qtd
                                        QtdMb += Int(Atual.Tam / 1024)
                                        Informa()

                                    End If
                                End If
                            Catch ex As Exception
                                Throw New Exception("ao tentar apagar " & Atual.NomeCompl & ": " & ex.Message & ".")
                            End Try
                        End If
                    Catch ex As Exception
                        If ex.Message = "Procedimento cancelado." Then
                            Throw ex
                        End If
                        log.AppendLine("Erro " & ex.Message)
                    End Try
                Next
                Acompanha("Procura concluída.")

                log.AppendLine("Concluído em " & Format(Now, "yyyy-MM-dd HH:mm:ss" & "."))
                log.AppendLine("Resultado: " & QtdAp & " " & Icraft.IcftBase.Pl(QtdAp, "arquivo") & " " & Icraft.IcftBase.Pl(QtdAp, "eliminado") & ". Total de " & QtdMb & "Mb.")
            End If
        Catch EX As Exception
            log.AppendLine("Em " & Format(Now, "yyyy-MM-dd HH:mm:ss") & " " & EX.Message)
            Notifica(EX.Message)
            Acompanha(EX.Message)
        End Try
        AposExecFunc(log.ToString)
    End Sub


    ' MÉTODOS INVOCADOS

    Delegate Sub AposExecFuncDelegate(ByVal LOG As String)
    Sub AposExecFunc(ByVal LOG As String)
        If InvokeRequired Then
            BeginInvoke(New AposExecFuncDelegate(AddressOf AposExecFunc), LOG)
            Exit Sub
        End If
        btnExec.Enabled = True
        btnCancelar.Visible = False
        If LOG <> "" Then
            frmLog.txtlog.Text = LOG.ToString
            frmLog.Show()
            frmLog.Focus()
            MsgBox("OK")
        End If
    End Sub

    Delegate Sub InformaDelegate()
    Sub Informa()
        If InvokeRequired Then
            BeginInvoke(New InformaDelegate(AddressOf Informa))
            Exit Sub
        End If
        lblQTD.Text = Format(QtdAp, "000")
        LBLtAM.Text = QtdMb & "Mb"
        Refresh()
    End Sub



    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        BGProcura.CancelAsync()
    End Sub
End Class
