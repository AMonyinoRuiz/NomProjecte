Imports Infragistics.Win


Public Class frmPersonal_ListadoCuadrante
    Dim _DTC As New DTCDataContext(BD.Conexion)

#Region "M_ToolForm"
    Private Sub ToolForm_m_ToolForm_Salir() Handles ToolForm.m_ToolForm_Salir
        Me.FormTancar()
    End Sub

    Private Sub ToolForm_m_ToolForm_Imprimir() Handles ToolForm.m_ToolForm_Imprimir

        If ComprovacioCampsRequeritsError() = True Then
            Mensaje.Mostrar_Mensaje(M_Mensaje.Missatge_Tipus.MISSATGE_TEXTE_REQUERIT, "")
            Exit Sub
        End If

        Util.WaitFormObrir()

        Call BuidarTaulaTemp()

        Call OmplirTaulaTemp()

        Util.WaitFormTancar()

        Dim __DTC As New DTCDataContext(BD.Conexion)
        Informes.ObrirInformePreparacio(__DTC, 4, "", "Listado Cuadrante", , , , , , False)
    End Sub

#End Region

#Region "Metodes"

    Public Sub Entrada()
        Me.AplicarDisseny()
        Util.Cargar_Combo(Me.C_Mes, "SELECT ID_Mes, Descripcion FROM Mes ORDER BY ID_Mes", True, , False)
        Util.Cargar_Combo(Me.C_Any, "SELECT ID_Año, Descripcion FROM Año ORDER BY ID_Año", True, , False)

        Me.C_Any.Text = Now.Year
        Me.C_Mes.Value = Now.Month

        Me.ToolForm.M.Botons.tImprimir.SharedProps.Visible = True
    End Sub

    Private Function ComprovacioCampsRequeritsError() As Boolean
        Try
            Dim oClsControls As New clsControles(ErrorProvider1)

            With Me
                ErrorProvider1.Clear()
                'oClsControls.ControlBuit(.TE_Codigo)
                oClsControls.ControlBuit(.C_Mes)
                oClsControls.ControlBuit(.C_Any)
            End With

            ComprovacioCampsRequeritsError = oClsControls.pCampRequeritTrobat

        Catch ex As Exception
            Mensaje.Mostrar_Mensaje_Error(ex)
        End Try
    End Function

#End Region

#Region "Events Varis"

    Public Sub BuidarTaulaTemp()
        BD.EjecutarConsulta("Delete from Temp_ListadoCuadrante")
    End Sub

    Public Sub OmplirTaulaTemp()
        Try
            Dim _DT As DataTable = BD.RetornaDataTable("Select * From Temp_ListadoCuadrante", True)


            Dim _DT_Ausencias As DataTable = BD.RetornaDataTable("Select ID_Personal, Fecha, sum(Numhores) as numhores From Personal_Ausencia where month(Fecha) = " & CInt(Me.C_Mes.Value) & " and Year(Fecha) = " & CInt(Me.C_Any.Text) & " Group by ID_Personal, Fecha", True)


            Dim _Personal As Personal
            For Each _Personal In _DTC.Personal.Where(Function(F) F.Activo = True And F.ID_Personal_Estat <> 2)

                Dim _DTRow As DataRow
                _DTRow = _DT.NewRow()
                _DTRow.Item("ID_Personal") = _Personal.ID_Personal
                _DTRow.Item("Personal_Nombre") = _Personal.Nombre
                _DTRow.Item("NumAny") = CInt(Me.C_Any.Text)
                _DTRow.Item("NumMes") = CInt(Me.C_Mes.Value)

                If IsNothing(_Personal.ID_Planta) = True Then
                    _DTRow.Item("ID_Planta") = 0
                    _DTRow.Item("Planta_Nombre") = "-"
                Else
                    _DTRow.Item("ID_Planta") = _Personal.ID_Planta
                    _DTRow.Item("Planta_Nombre") = _Personal.Planta.Iniciales
                End If

                Dim _DiasDelMes As Integer = DateTime.DaysInMonth(CInt(Me.C_Any.Text), CInt(Me.C_Mes.Value))

                Dim _FechaInici As New Date(CInt(Me.C_Any.Text), CInt(Me.C_Mes.Value), 1)
                Dim _FechaFi As New Date(CInt(Me.C_Any.Text), CInt(Me.C_Mes.Value), _DiasDelMes)
                Dim _FechaTemp As Date = _FechaInici

                Do Until _FechaTemp >= _FechaFi
                    'Dim _HoresPerDias As Decimal = _Personal.Personal_Ausencia.Where(Function(F) F.Fecha = CDate(_FechaTemp)).Sum(Function(y) y.NumHores)
                    Dim _Resultats_Ausencia() As DataRow = _DT_Ausencias.Select("ID_Personal=" & _Personal.ID_Personal & " and Fecha = '" & CDate(_FechaTemp) & "'")
                    Dim _HoresPerDias As Decimal = 0
                    If _Resultats_Ausencia.Length > 0 Then
                        _HoresPerDias = Util.Comprobar_NULL_Per_0_Decimal(_Resultats_Ausencia(0).Item("NumHores"))

                        If _HoresPerDias <> 0 Then
                            _DTRow.Item("Dia" & _FechaTemp.Day) = _HoresPerDias
                        End If

                    End If

                    _FechaTemp = _FechaTemp.AddDays(1)
                Loop

                _DT.Rows.Add(_DTRow)

            Next

            Dim _BD As New M_Conexion.clsConexion
            _BD = New M_Conexion.clsConexion
            _BD.Conectar(BD.pBDNomInstancia, BD.pBDNomBaseDades, BD.pBDUsuari, BD.pBDContrasenya)
            Dim oDA As SqlClient.SqlDataAdapter
            Dim oCB As SqlClient.SqlCommandBuilder
            'Util.Exportacio_BD(_DTAll_Year1) '0000000000
            oDA = New SqlClient.SqlDataAdapter("Select * From Temp_ListadoCuadrante", _BD.Conexion)
            oCB = New SqlClient.SqlCommandBuilder(oDA)
            oDA.Update(_DT)
            oDA.Dispose()
            oCB.Dispose()
            oDA = Nothing
            oCB = Nothing
            _DTC.SubmitChanges()

        Catch ex As Exception
            Mensaje.Mostrar_Mensaje_Error(ex)
        End Try
    End Sub
#End Region


End Class