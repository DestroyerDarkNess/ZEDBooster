Imports System.IO
Imports System.Threading
Public Class Form1



#Region "Booster"

    Public Shared Function ConverterEmMB(ByVal Valor As Double)

        Valor = FormatNumber(Valor / 1048576, 2)

        Return Valor

    End Function
    Private Sub LoadAntigo()
        Try


            Processos.Icons.Images.Add(0, imgIcons.Images(0))
            lwProcs.SmallImageList = Processos.Icons
            Processos.AddToListView(lwProcs, False)
            UsoMemoriaFisica_Progress.Maximum = ConverterEmMB(My.Computer.Info.TotalPhysicalMemory)
            UsoMemoriaVirtual_Progress.Maximum = ConverterEmMB(My.Computer.Info.TotalVirtualMemory)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        LoadAntigo()
        Try
            Me.Size = New Size(743, 202)
            UsoMemoriaFisica_Progress.Maximum = ConverterEmMB(My.Computer.Info.TotalPhysicalMemory)
            UsoMemoriaVirtual_Progress.Maximum = ConverterEmMB(My.Computer.Info.TotalVirtualMemory)
            FlatStatusBar1.Text = " " & My.Computer.Info.OSFullName & "      " & "Platform: " & My.Computer.Info.OSPlatform & "      " & "OSversion: " & My.Computer.Info.OSVersion & "      " & "Idiom: " & My.Computer.Info.InstalledUICulture.ToString
        Catch ex As Exception

        End Try
    End Sub









#End Region


    Private Sub FlatButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FlatButton1.Click
        lwProcs.Items.Clear()
        Processos.AddToListView(lwProcs, True)
    End Sub

    Private Sub MemoriaRamX_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MemoriaRamX.Tick
        On Error Resume Next
        Label1.Text = (My.Computer.Info.TotalVirtualMemory - My.Computer.Info.AvailableVirtualMemory) / My.Computer.Info.TotalVirtualMemory * 100 & " MB &H433455 HEX 3B4O5B"
        ProgressBar1.Value = (My.Computer.Info.TotalPhysicalMemory - My.Computer.Info.AvailablePhysicalMemory) / My.Computer.Info.TotalPhysicalMemory * 100
        Label6.Text = ProgressBar1.Value & " %"
        RamCPU.RamProcentagem(ProgressBar1.Value, Label1.Text)
        'Dim ValorCPU As Double = CPUUtilizado.NextValue
        Dim ValorRAMFisica As Double = My.Computer.Info.AvailablePhysicalMemory
        Dim ValorRAMVirtual As Double = My.Computer.Info.AvailableVirtualMemory
        'UsoCPU_Label.Text = FormatNumber(ValorCPU, 2) & "%"
        'UsoCPU_Progress.Value = ValorCPU
        UsoMemoriaFisica_Label.Text = " PhysicalMemory " & ConverterEmMB(ValorRAMFisica) & " Mb de " & ConverterEmMB(My.Computer.Info.TotalPhysicalMemory) & " Mb"
        UsoMemoriaFisica_Progress.Value = ConverterEmMB(ValorRAMFisica)
        UsoMemoriaVirtual_Label.Text = " VirtualMemory " & ConverterEmMB(ValorRAMVirtual) & " Mb de " & ConverterEmMB(My.Computer.Info.TotalVirtualMemory) & " Mb"
        UsoMemoriaVirtual_Progress.Value = ConverterEmMB(ValorRAMVirtual)
        RamCPU.MemoriaRam_(UsoMemoriaFisica_Label.Text, UsoMemoriaVirtual_Label.Text, _
        UsoMemoriaFisica_Progress.Value, UsoMemoriaVirtual_Progress.Value)
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If Timer1.Interval = 100 Then
            Processos.AddToListView(lwProcs, False)
        Else
            Processos.AddToListView(lwProcs, False)
        End If
    End Sub

    Private Sub FlatToggle1_CheckedChanged(ByVal sender As System.Object) Handles FlatToggle1.CheckedChanged
        If (FlatToggle1.Checked) = True Then
            Me.Size = New Size(743, 202)
        Else
            Me.Size = New Size(743, 477)
        End If
    End Sub

    Private Sub FlatButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FlatButton2.Click
        Processos.AddToListView(lwProcs, False)
    End Sub
End Class
