Imports Infragistics.Win
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraPrinting
Imports DevExpress.Spreadsheet
Imports System.Globalization


Public Class frmllistatResumCompres

    Dim _DTC As New DTCDataContext(BD.Conexion)

#Region "M_ToolForm"
    Private Sub ToolForm_m_ToolForm_Salir() Handles ToolForm.m_ToolForm_Salir
        Me.FormTancar()
    End Sub

#End Region

#Region "Metodes"
    Public Sub Entrada()
        Me.AplicarDisseny()

        Util.Cargar_Combo(Me.C_Planta, "SELECT ID_Planta, Descripcion FROM Planta Where Activo=1 and ID_Planta <> 10 ORDER BY Descripcion", True, True)

        If IsNothing(Seguretat.oUser.CampoAux1) = False And IsDBNull(Seguretat.oUser.CampoAux1) = False Then
            Me.C_Planta.Value = Seguretat.oUser.CampoAux1
            If Seguretat.oUser.CampoAux1 = 1 Then
                Me.C_Planta.ReadOnly = False
            Else
                Me.C_Planta.ReadOnly = True
            End If
        End If

        Me.DT_Inicio.Value = New Date(Now.Year, Now.Month, 1)
        Me.DT_Fin.Value = New Date(Now.Year, Now.Month, Util.RetornaUltimDiaDelMes(Now.Year, Now.Month).Day)
   

        Dim BotoCancelar As UltraWinEditors.EditorButton
        BotoCancelar = New UltraWinEditors.EditorButton
        BotoCancelar.Key = "Cancelar"
        Dim oDisseny As New M_Disseny.ClsDisseny
        BotoCancelar.Appearance.Image = oDisseny.Leer_Imagen("text_cancelar.gif")
        BotoCancelar.Width = 16
        BotoCancelar.Appearance.BackColor = Color.White
        BotoCancelar.Appearance.BorderAlpha = Alpha.Transparent

        'Me.C_Planta.ButtonsRight.Add(BotoCancelar.Clone)
        Me.C_Proveedor.ButtonsRight.Add(BotoCancelar.Clone)

        Call CargarGrid_entrades()

    End Sub

    Private Sub Validar_Click(sender As Object, e As EventArgs) Handles Validar.Click
        If ComprovacioCampsRequeritsError() = True Then
            Mensaje.Mostrar_Mensaje(M_Mensaje.Missatge_Tipus.MISSATGE_TEXTE_REQUERIT, "")
            Exit Sub
        End If

        Call CargarGrid_entrades()
    End Sub

    Private Function ComprovacioCampsRequeritsError() As Boolean
        Try
            Dim oClsControls As New clsControles(ErrorProvider1)

            With Me
                ErrorProvider1.Clear()
                'oClsControls.ControlBuit(.TE_Codigo)
                oClsControls.ControlBuit(.DT_Inicio)
                oClsControls.ControlBuit(.DT_Fin)
                'oClsControls.ControlBuit(.C_Planta)
            End With

            ComprovacioCampsRequeritsError = oClsControls.pCampRequeritTrobat

        Catch ex As Exception
            Mensaje.Mostrar_Mensaje_Error(ex)
        End Try
    End Function

#End Region

#Region "Grid entrades"
    Private Sub CargarGrid_entrades()
        Dim _SQLPRoveedor As String
        If Me.C_Proveedor.SelectedIndex <> -1 Then
            _SQLPRoveedor = " CodigoProveedor= '" & Me.C_Proveedor.Value & "' and "
        End If

        Dim _DTS As New DataSet
        Dim _Planta As String = ""
        If Me.C_Planta.Value > 0 Then
            _Planta = _DTC.Planta.Where(Function(F) F.ID_Planta = CInt(Me.C_Planta.Value)).FirstOrDefault.Iniciales_LCLARIANA

            BD.CargarDataSet(_DTS, "Select CodigoArticulo as Codigo, DescripcionArticulo as Descripcion, Sum(Unidades) as TotalUnidades, Sum(BaseImponible) as TotalBaseImponible From C_LineasAlbaranCompra where " & _SQLPRoveedor & "  Planta = '" & _Planta & "' and FechaAlbaran between '" & CDate(Me.DT_Inicio.Value) & "' and '" & CDate(Me.DT_Fin.Value) & "' Group by CodigoArticulo, DescripcionArticulo Order by Descripcion ")
            BD.CargarDataSet(_DTS, "Select * From C_LineasAlbaranCompra where " & _SQLPRoveedor & "  Planta = '" & _Planta & "' and FechaAlbaran between '" & CDate(Me.DT_Inicio.Value) & "' and '" & CDate(Me.DT_Fin.Value) & "'  Order by FechaAlbaran ", "Table2", 0, "Codigo", "CodigoArticulo", True)
        Else
            BD.CargarDataSet(_DTS, "Select CodigoArticulo as Codigo, DescripcionArticulo as Descripcion, Sum(Unidades) as TotalUnidades, Sum(BaseImponible) as TotalBaseImponible From C_LineasAlbaranCompra where " & _SQLPRoveedor & " FechaAlbaran between '" & CDate(Me.DT_Inicio.Value) & "' and '" & CDate(Me.DT_Fin.Value) & "' Group by CodigoArticulo, DescripcionArticulo Order by Descripcion ")
            BD.CargarDataSet(_DTS, "Select * From C_LineasAlbaranCompra where " & _SQLPRoveedor & " FechaAlbaran between '" & CDate(Me.DT_Inicio.Value) & "' and '" & CDate(Me.DT_Fin.Value) & "'  Order by FechaAlbaran ", "Table2", 0, "Codigo", "CodigoArticulo", True)
        End If

        _DTS.Tables(0).TableName = "Root"
        Me.GridControl1.DataSource = _DTS.Tables(0)

    End Sub

#End Region

#Region "Altres events"
    Private Sub C_Proveedor_BeforeDropDown(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles C_Proveedor.BeforeDropDown
        Dim _SQLPlanta As String = ""

        If IsNothing(DT_Inicio.Value) Or IsNothing(DT_Fin.Value) Then
            Mensaje.Mostrar_Mensaje("Introduzca correctamente los datos", M_Mensaje.Missatge_Modo.INFORMACIO, , , True)
        Else
            If Me.C_Planta.SelectedIndex <> -1 Then
                Dim _Planta As String = _DTC.Planta.Where(Function(F) F.ID_Planta = CInt(Me.C_Planta.Value)).FirstOrDefault.Iniciales_LCLARIANA
                _SQLPlanta = " planta= '" & _Planta & "' and "
            End If
        End If


        Util.Cargar_Combo(Me.C_Proveedor, "SELECT codigoproveedor, Proveedor FROM C_LineasAlbaranCompra Where " & _SQLPlanta & "  FechaAlbaran Between '" & Me.DT_Inicio.Value & "' and '" & Me.DT_Fin.Value & "' group by codigoproveedor, Proveedor ", False, False)

        '  Me.C_Personal.Value = oLinqParte.ID_Personal
    End Sub

    Private Sub C_Proveedor_EditorButtonClick(sender As Object, e As UltraWinEditors.EditorButtonEventArgs) Handles C_Proveedor.EditorButtonClick
        If e.Button.Key = "Cancelar" Then
            Me.C_Proveedor.SelectedIndex = -1
        End If
    End Sub
#End Region

End Class