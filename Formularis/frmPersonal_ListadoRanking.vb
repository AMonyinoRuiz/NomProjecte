Imports Infragistics.Win


Public Class frmPersonal_ListadoRanking
    Dim _DTC As New DTCDataContext(BD.Conexion)
    Dim total_horas As Decimal = 0

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
        Informes.ObrirInformePreparacio(__DTC, 5, "", "Listado Ranking", , , , , , False)
    End Sub

#End Region

#Region "Metodes"

    Public Sub Entrada()
        Me.AplicarDisseny()
        Util.Cargar_Combo(Me.C_Any, "SELECT ID_Año, Descripcion FROM Año ORDER BY ID_Año", True, , False)

        Me.C_Any.Text = Now.Year

        Me.ToolForm.M.Botons.tImprimir.SharedProps.Visible = True
    End Sub

    Private Function ComprovacioCampsRequeritsError() As Boolean
        Try
            Dim oClsControls As New clsControles(ErrorProvider1)

            With Me
                ErrorProvider1.Clear()
                'oClsControls.ControlBuit(.TE_Codigo)
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
        BD.EjecutarConsulta("Delete from Temp_Ranking")
    End Sub

    Public Sub OmplirTaulaTemp()
        Try
            Dim _DT As DataTable = BD.RetornaDataTable("Select * From Temp_Ranking", True)

            Dim _DT_Ausencias As DataTable = BD.RetornaDataTable("Select ID_Personal, ID_AusenciaTipo,  case when Sum(NumHores) is not null then SUM(numhores) else COUNT(*)*8 end as NumHores From Personal_Ausencia Where YEAR(Fecha) = " & CInt(Me.C_Any.Text) & " group by ID_Personal, ID_AusenciaTipo", True)

            Dim _Personal As Personal
            For Each _Personal In _DTC.Personal.Where(Function(F) F.Activo = True)

                total_horas = 0
                Dim _DTRow As DataRow
                _DTRow = _DT.NewRow()
                _DTRow.Item("ID_Personal") = _Personal.ID_Personal
                _DTRow.Item("Nom_Empleat") = _Personal.Nombre

                Call Omplir_Camp_Taula(_DTRow, _Personal, EnumAusenciaTipo.Asuntos_propios, "Asuntos_propios", _DT_Ausencias)
                Call Omplir_Camp_Taula(_DTRow, _Personal, EnumAusenciaTipo.Matrimonio, "Matrimonio", _DT_Ausencias)
                Call Omplir_Camp_Taula(_DTRow, _Personal, EnumAusenciaTipo.Nacimiento_hijo, "Nacimiento_hijo", _DT_Ausencias)
                Call Omplir_Camp_Taula(_DTRow, _Personal, EnumAusenciaTipo.Adopcion_Acogimiento, "Adopcion_acogimiento", _DT_Ausencias)
                Call Omplir_Camp_Taula(_DTRow, _Personal, EnumAusenciaTipo.Accidente_Enfermedad_Hospitalizacion_intervencion_de_un_familiar, "Accidente_Enfermedad_Hospitalizacion", _DT_Ausencias)
                Call Omplir_Camp_Taula(_DTRow, _Personal, EnumAusenciaTipo.Fallecimiento_familiar, "Fallecimiento_de_un_familiar", _DT_Ausencias)
                Call Omplir_Camp_Taula(_DTRow, _Personal, EnumAusenciaTipo.Mudanza, "Mudanza", _DT_Ausencias)
                Call Omplir_Camp_Taula(_DTRow, _Personal, EnumAusenciaTipo.Cumplimiento_deber_inexcusable, "Cumplimiento_deber_inexcusable", _DT_Ausencias)
                Call Omplir_Camp_Taula(_DTRow, _Personal, EnumAusenciaTipo.Formacion, "Formacion", _DT_Ausencias)
                Call Omplir_Camp_Taula(_DTRow, _Personal, EnumAusenciaTipo.Formacion_prenatal, "Formacion_prenatal", _DT_Ausencias)
                Call Omplir_Camp_Taula(_DTRow, _Personal, EnumAusenciaTipo.Baja_sin_justificar, "Baja_sin_justificar", _DT_Ausencias)
                Call Omplir_Camp_Taula(_DTRow, _Personal, EnumAusenciaTipo.Enfermedad_comun, "Enfermedad_comun", _DT_Ausencias)
                Call Omplir_Camp_Taula(_DTRow, _Personal, EnumAusenciaTipo.Baja_accidente_laboral, "Baja_accidente_laboral", _DT_Ausencias)
                Call Omplir_Camp_Taula(_DTRow, _Personal, EnumAusenciaTipo.Medico_especialista, "Medico_especialista", _DT_Ausencias)
                Call Omplir_Camp_Taula(_DTRow, _Personal, EnumAusenciaTipo.Festivos_nacionales, "Festivos_nacionales", _DT_Ausencias)
                Call Omplir_Camp_Taula(_DTRow, _Personal, EnumAusenciaTipo.Acompanar_menor_12, "Acompanar_menor_12", _DT_Ausencias)
                Call Omplir_Camp_Taula(_DTRow, _Personal, EnumAusenciaTipo.Intervencion_quirurgica, "Intervencion_quirurgica", _DT_Ausencias)
                Call Omplir_Camp_Taula(_DTRow, _Personal, EnumAusenciaTipo.Ausencia_sin_justificar, "Ausencia_sin_justificar", _DT_Ausencias)
                Call Omplir_Camp_Taula(_DTRow, _Personal, EnumAusenciaTipo.Horas_sindicales, "Horas_sindicales", _DT_Ausencias)
                Call Omplir_Camp_Taula(_DTRow, _Personal, EnumAusenciaTipo.Medico_privado, "Medico_privado_dentista_etc", _DT_Ausencias)


                _DTRow.Item("Total_hores_empleat") = total_horas
                _DTRow.Item("Ano") = CInt(Me.C_Any.Text)

                _DT.Rows.Add(_DTRow)

            Next

            Dim _BD As New M_Conexion.clsConexion
            _BD = New M_Conexion.clsConexion
            _BD.Conectar(BD.pBDNomInstancia, BD.pBDNomBaseDades, BD.pBDUsuari, BD.pBDContrasenya)
            Dim oDA As SqlClient.SqlDataAdapter
            Dim oCB As SqlClient.SqlCommandBuilder

            'Util.Exportacio_BD(_DT) '0000000000

            oDA = New SqlClient.SqlDataAdapter("Select * From Temp_Ranking", _BD.Conexion)
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

    Public Sub Omplir_Camp_Taula(ByVal _DTRow As DataRow, ByVal pPersonal As Personal, ByVal TipusAusencia As Integer, ByVal NomCamp As String, ByVal _DT_Ausencias As DataTable)

        Dim _Resultats_Ausencia() As DataRow = _DT_Ausencias.Select("ID_Personal=" & pPersonal.ID_Personal & " and ID_AusenciaTipo = " & TipusAusencia)
        If _Resultats_Ausencia.Length > 0 Then
            _DTRow.Item(NomCamp) = _Resultats_Ausencia(0).Item("NumHores")
        Else
            _DTRow.Item(NomCamp) = 0.0
        End If

        total_horas = total_horas + _DTRow.Item(NomCamp)

    End Sub

#End Region


End Class