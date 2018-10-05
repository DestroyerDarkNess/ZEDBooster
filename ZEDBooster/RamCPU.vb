Public Class RamCPU
    Public Shared ValorRAMFisica As Double = My.Computer.Info.AvailablePhysicalMemory
    Public Shared ValorRAMVirtual As Double = My.Computer.Info.AvailableVirtualMemory
    Public Shared CPUUtilizado As PerformanceCounter = New System.Diagnostics.PerformanceCounter
    Public Shared ValorCPU As Double = CPUUtilizado.NextValue

    Public Shared Function CPU_Load()

        Try
            CPUUtilizado.CategoryName = "Processor"
            CPUUtilizado.CounterName = "% Processor Time"
            CPUUtilizado.InstanceName = "_Total"
        Catch ex As Exception

        End Try

    End Function
    Public Shared Function ConverterEmMB(ByVal Valor As Double)
        Valor = FormatNumber(Valor / 1048576, 2)
        Return Valor
    End Function
    Public Shared Function TotalRamFisica() As Double
        TotalRamFisica = ConverterEmMB(My.Computer.Info.TotalPhysicalMemory)
    End Function
    Public Shared Function TotalRamVirtual() As Double
        TotalRamVirtual = ConverterEmMB(My.Computer.Info.TotalVirtualMemory)
    End Function

    Public Shared Function ProgressRamFisica() As Double
        ProgressRamFisica = ConverterEmMB(ValorRAMFisica)
    End Function
    Public Shared Function ProgressRamVirtual() As Double
        ProgressRamVirtual = ConverterEmMB(ValorRAMVirtual)
    End Function

    Public Shared Function TextoRamFisica() As String
        TextoRamFisica = ConverterEmMB(ValorRAMFisica) & " Mb de " & TotalRamFisica() & " Mb"
    End Function
    Public Shared Function TextoRamVirtual() As String
        TextoRamVirtual = ConverterEmMB(ValorRAMVirtual) & " Mb de " & TotalRamVirtual() & " Mb"
    End Function
    Public Shared Function MemoriaRamLoad(ByRef ProgressTotalFisica As Double, ByRef ProgressTotalVirtual As Double)
        ProgressTotalFisica = TotalRamFisica()
        ProgressTotalVirtual = TotalRamVirtual()
    End Function

    Public Shared Function MemoriaRam_(ByRef labelRamfisica As String, ByRef labelRamvirtual As String _
       , ByRef ProgressFisica As Double, ByRef ProgressVirtual As Double _
       )
        labelRamfisica = TextoRamFisica()
        labelRamvirtual = TextoRamVirtual()
        ProgressFisica = ProgressRamFisica()
        ProgressVirtual = ProgressRamVirtual()

    End Function

    Public Shared Function CPU(ByRef Labell As String, ByRef ProgressCPU As Double)
        Labell = FormatNumber(ValorCPU, 2) & "%"
        ProgressCPU = ValorCPU
    End Function

    Public Shared Function RamProcentagem(ByRef PorCen As Integer, ByRef labell As String)
        PorCen = (My.Computer.Info.TotalPhysicalMemory - My.Computer.Info.AvailablePhysicalMemory) / My.Computer.Info.TotalPhysicalMemory * 100
        labell = PorCen
    End Function
End Class
