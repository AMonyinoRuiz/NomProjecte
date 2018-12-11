

Partial Class DTCDataContext

End Class

Partial Public Class Movimiento
    Public Property pDiferenciaTeoricAmbReal() As Integer
        Get
            If Me.HorarioTeoricoSalida.HasValue = True And Me.HorarioRealSalida.HasValue = True Then
                Return CInt(DateDiff(DateInterval.Minute, CDate(Me.HorarioRealSalida).AddDays(-1), CDate(Me.HorarioTeoricoSalida), FirstDayOfWeek.Monday, FirstWeekOfYear.System))
            Else
                Return Nothing
            End If

        End Get
        Set(ByVal Value As Integer)

        End Set
    End Property

    Public Property pDiferenciaEntradaAmbSortida() As Integer
        Get
            If Me.HorarioRealLlegada.HasValue = True And Me.HorarioRealSalida.HasValue = True Then
                Return CInt(DateDiff(DateInterval.Minute, CDate(Me.HorarioRealSalida), CDate(Me.HorarioRealLlegada), FirstDayOfWeek.Monday, FirstWeekOfYear.System))
            Else
                Return Nothing
            End If

        End Get
        Set(ByVal Value As Integer)

        End Set
    End Property
End Class


