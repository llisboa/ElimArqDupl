Public Class frmRenomear

    Private Sub btnVisualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVisualizar.Click
        Try
            Icraft.IcftBase.RegApl("Ren") = Icraft.IcftBase.Form.Conteudo(Me, "txt")
            Dim Log As New System.Text.StringBuilder
            Log.AppendLine("Verificação: como será a substituição...")
            Dim Ref As ArrayList = Icraft.IcftBase.ParamArrayToArrayList(System.IO.Directory.GetFiles(txtREN.Text), System.IO.Directory.GetDirectories(txtREN.Text))
            For Each Arq As String In Ref
                Dim arqd As String = Troca(Arq, txtDe.Text, txtPara.Text)
                If Arq <> arqd Then
                    Log.AppendLine(Arq & " ==> " & arqd)
                End If
            Next
            frmLog.txtlog.Text = Log.ToString
            frmLog.Show()
            frmLog.Focus()
        Catch EX As Exception
            MsgBox(EX.Message)
        End Try

    End Sub

    Function Troca(ByVal Arquivo As String, ByVal De As String, ByVal Para As String) As String
        Dim Arq As String = System.IO.Path.GetFileName(Arquivo)
        Dim DD As String = System.IO.Path.GetDirectoryName(Arquivo)
        Arq = Replace(Arq, De, Para)
        Return Icraft.IcftBase.FileExpr(DD, Arq)
    End Function

    Private Sub frmRenomear_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.Text = Form1.Text & " - RENOMEAR"
            Icraft.IcftBase.Form.Conteudo(Me, "txt") = Icraft.IcftBase.RegApl("Ren")
            txtREN.Text = Form1.txtELIM.Text
        Catch EX As Exception
            MsgBox(EX.Message)
        End Try

    End Sub

    Private Sub btnRenomear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRenomear.Click
        Try
            If MsgBox("Deseja renomear os diretórios conforme critério de substituição?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Icraft.IcftBase.RegApl("Ren") = Icraft.IcftBase.Form.Conteudo(Me, "txt")

                Dim Log As New System.Text.StringBuilder
                Log.AppendLine("Resultado da substituição...")
                Dim Ref As ArrayList = Icraft.IcftBase.ParamArrayToArrayList(System.IO.Directory.GetFiles(txtREN.Text), System.IO.Directory.GetDirectories(txtREN.Text))
                For Each Arq As String In Ref
                    Dim arqd As String = Troca(Arq, txtDe.Text, txtPara.Text)
                    If Arq <> arqd Then
                        Try
                            If System.IO.File.Exists(Arq) Then
                                System.IO.File.Move(Arq, arqd)
                            Else
                                System.IO.Directory.Move(Arq, arqd)
                            End If

                            Log.AppendLine(Arq & " ==> " & arqd)

                        Catch ex As Exception
                            Log.AppendLine("Erro ao tentar trocar " & Arq & " por " & arqd & ": " & ex.Message & ".")
                        End Try
                    End If
                Next
                frmLog.txtlog.Text = Log.ToString
                frmLog.Show()
                frmLog.Focus()
                MsgBox("OK")
            End If
        Catch EX As Exception
            MsgBox(EX.Message)
        End Try

    End Sub

    Private Sub btnFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFechar.Click
        Me.Close()
    End Sub
End Class