Imports Infragistics.Win
Imports Infragistics.Win.UltraWinGrid
Imports System.IO

Public Class frmArticulo
    Implements IDisposable
    Dim oDTC As DTCDataContext
    Dim oLinqArticulo As Articulo
    ' Dim Fichero As M_Archivos_Binarios.clsArchivosBinarios2

#Region "M_ToolForm"

    Private Sub M_ToolForm1_m_ToolForm_Guardar() Handles ToolForm.m_ToolForm_Guardar
        Call Guardar()
    End Sub

    Private Sub M_ToolForm1_m_ToolForm_Sortir() Handles ToolForm.m_ToolForm_Salir
        Me.FormTancar()
    End Sub

    Private Sub ToolForm_m_ToolForm_Buscar() Handles ToolForm.m_ToolForm_Buscar
        Call Cridar_Llistat_Generic()
    End Sub

    Private Sub ToolForm_m_ToolForm_Nuevo() Handles ToolForm.m_ToolForm_Nuevo
        Call Netejar_Pantalla()
    End Sub

    Private Sub ToolForm_m_ToolForm_Eliminar() Handles ToolForm.m_ToolForm_Eliminar
        Try
            If oLinqArticulo.ID_Articulo <> 0 Then
                'If oLinqMarca.tabla.Count > 0 Then
                '    Mensaje.Mostrar_Mensaje("Imposible eliminar la marca porque está asiganda a uno o más artículos", M_Mensaje.Missatge_Modo.INFORMACIO, , , True)
                '    Exit Sub
                'End If

                If Mensaje.Mostrar_Mensaje(M_Mensaje.Missatge_Tipus.MISSATGE_ELIMINAR_REGISTRE_PREGUNTA) = M_Mensaje.Botons.SI Then
                    oDTC.Articulo.DeleteOnSubmit(oLinqArticulo)
                    oDTC.Articulo_Aux.DeleteOnSubmit(oLinqArticulo.Articulo_Aux)
                    oDTC.SubmitChanges()
                    Mensaje.Mostrar_Mensaje(M_Mensaje.Missatge_Tipus.MISSATGE_ELIMINAR_REGISTRE)
                    Call Netejar_Pantalla()
                End If
            End If
        Catch ex As Exception
            Mensaje.Mostrar_Mensaje_Error(ex)

        End Try
    End Sub

    Private Sub ToolForm_m_ToolForm_ToolClick_Botones_Extras(Sender As Object, e As UltraWinToolbars.ToolClickEventArgs) Handles ToolForm.m_ToolForm_ToolClick_Botones_Extras
        Select Case e.Tool.Key
            Case "SubAccions1"
                Dim _NewArticulo As New Articulo
                _NewArticulo.Catalogo = oLinqArticulo.Catalogo
                _NewArticulo.Codigo = oLinqArticulo.Codigo & "-Copia"
                _NewArticulo.CodigoBarras = oLinqArticulo.CodigoBarras
                _NewArticulo.CodigoBlister = oLinqArticulo.CodigoBlister
                _NewArticulo.CodigoQR = oLinqArticulo.CodigoQR
                _NewArticulo.CodigoRiver = oLinqArticulo.CodigoRiver & "-Copia"
                _NewArticulo.Descripcion = oLinqArticulo.Descripcion & "-Copia"
                _NewArticulo.DUN_14 = oLinqArticulo.DUN_14
                _NewArticulo.EmbalajeObservaciones = oLinqArticulo.EmbalajeObservaciones
                _NewArticulo.EmbalajeUnidades = oLinqArticulo.EmbalajeUnidades
                _NewArticulo.Familia = oLinqArticulo.Familia
                _NewArticulo.IVA = oLinqArticulo.IVA
                _NewArticulo.LinkVideo = oLinqArticulo.LinkVideo
                _NewArticulo.Marca = oLinqArticulo.Marca
                _NewArticulo.Observaciones = oLinqArticulo.Observaciones
                _NewArticulo.Posicion = oLinqArticulo.Posicion
                _NewArticulo.PVP = oLinqArticulo.PVP
                _NewArticulo.RAEE = oLinqArticulo.RAEE
                _NewArticulo.Subfamilia = oLinqArticulo.Subfamilia
                _NewArticulo.FechaAlta = Now.Date
                _NewArticulo.Obsoleto = False
                _NewArticulo.Exportat = False
                _NewArticulo.DataModificacio = Now.Date

                Dim _NewAux As New Articulo_Aux
                _NewAux.FotoArticulo = oLinqArticulo.Articulo_Aux.FotoArticulo
                _NewAux.CaracteristicasCatalogoOferta = oLinqArticulo.Articulo_Aux.CaracteristicasCatalogoOferta
                _NewAux.CaracteristicasFichaProducto1 = oLinqArticulo.Articulo_Aux.CaracteristicasFichaProducto1
                _NewAux.CaracteristicasFichaProducto2 = oLinqArticulo.Articulo_Aux.CaracteristicasFichaProducto2
                _NewAux.DescripcionCorta = oLinqArticulo.Articulo_Aux.DescripcionCorta
                _NewAux.DescripcionLarga = oLinqArticulo.Articulo_Aux.DescripcionLarga
                _NewArticulo.Articulo_Aux = _NewAux

                oDTC.Articulo.InsertOnSubmit(_NewArticulo)
                oDTC.SubmitChanges()

                Call Netejar_Pantalla()
                Call Cargar_Form(_NewArticulo.ID_Articulo)

            Case "SubAccions2"
                Dim CP As DevExpress.XtraRichEdit.API.Native.CharacterProperties = Me.R_Oferta.RichText.Document.BeginUpdateCharacters(Me.R_Oferta.RichText.Document.Range)
                CP.FontName = "Calibri"
                CP.FontSize = 10
                'CP.ForeColor = Color.Black
                'CP.BackColor = Color.Snow
                Me.R_Oferta.RichText.Document.EndUpdateCharacters(CP)

                Call ConfigurarFichas()

                'CP = Me.R_Ficha1.RichText.Document.BeginUpdateCharacters(Me.R_Ficha1.RichText.Document.Range)
                'CP.FontName = "Calibri"
                'CP.FontSize = 10
                ''CP.ForeColor = Color.Black
                ''CP.BackColor = Color.Snow
                'Me.R_Ficha1.RichText.Document.EndUpdateCharacters(CP)

                'CP = Me.R_Ficha2.RichText.Document.BeginUpdateCharacters(Me.R_Ficha2.RichText.Document.Range)
                'CP.FontName = "Calibri"
                'CP.FontSize = 10
                ''CP.ForeColor = Color.Black
                ''CP.BackColor = Color.Snow
                'Me.R_Ficha2.RichText.Document.EndUpdateCharacters(CP)

            Case "SubAccions3"

                With Me.R_Oferta
                    .RichText.CreateNewDocument()
                    .RichText.ActiveViewType = DevExpress.XtraRichEdit.RichEditViewType.PrintLayout
                    .RichText.Document.DefaultCharacterProperties.FontSize = 10
                    .RichText.Document.DefaultCharacterProperties.FontName = "Calibri"
                    Dim CP As DevExpress.XtraRichEdit.API.Native.CharacterProperties = .RichText.Document.BeginUpdateCharacters(.RichText.Document.Range)
                    CP.FontName = "Calibri"
                    CP.FontSize = 10

                    .RichText.Document.Sections(0).Page.PaperKind = Drawing.Printing.PaperKind.A4
                    .RichText.Document.Sections(0).Margins.Left = 200
                    .RichText.Document.Sections(0).Margins.Right = 200
                    .RichText.Document.Sections(0).Margins.Top = 200
                    .RichText.LayoutUnit = DevExpress.XtraRichEdit.DocumentLayoutUnit.Pixel
                    .RichText.Document.EndUpdateCharacters(CP)




                    'Me.R_Ficha1.RichText.ActiveView.AllowDisplayLineNumbers = True
                    '.RichText.Document.Sections(0).Page.PaperKind = Drawing.Printing.PaperKind.A6
                    '.RichText.Document.Sections(0).Margins.Left = 0
                    '.RichText.Document.Sections(0).Margins.Right = 270
                    '.RichText.Document.Sections(0).Margins.Top = 0
                    '.RichText.ActiveView.ZoomFactor = 1.28





                    ' Dim _Point2 As New Point(400, 400)
                    'Dim _Point As New Point(DevExpress.Office.Utils.Units.PixelsToDocuments(_Point2, .RichText.DpiX, .RichText.DpiY))
                    'Dim _Pos As DevExpress.XtraRichEdit.API.Native.DocumentPosition = Me.R_Oferta.RichText.GetPositionFromPoint(_Point2)




                    '  .RichText.Document.Images.Insert(.RichText.Document.CaretPosition, _Foto)
                    '  .RichText.Document.Shapes.InsertPicture(.RichText.Document.CaretPosition, _Foto)
                    '  .RichText.Document.Images(0).Size = New System.Drawing.SizeF(1000, 1000)
                    '.RichText.Document.Images(0).Range
                    '   Dim pepe As New DevExpress.XtraRichEdit.Commands.InsertFloatingObjectPictureCommand(.RichText)
                    '      .RichText.ActiveViewType = DevExpress.XtraRichEdit.RichEditViewType.PrintLayout


                    If oLinqArticulo.Marca.Logo Is Nothing = False Then
                        ''Dim _Texte As String
                        ''_Texte = _Texte & oLinqArticulo.Marca.Descripcion & " " & oLinqArticulo.Descripcion

                        ' ''.RichText.Document.InsertText(.RichText.Document.CaretPosition, _Texte)
                        ' '' Dim _Range As DevExpress.XtraRichEdit.API.Native.DocumentRange
                        ''Dim _Range As DevExpress.XtraRichEdit.API.Native.DocumentRange
                        ' ''Using model = New DevExpress.XtraRichEdit.Model.DocumentModel(DevExpress.XtraRichEdit.Internal.DocumentFormatsDependencies.Empty)

                        ''Dim _rtfConverter As New DevExpress.XtraEditors.Controls.Rtf.StringEditValueToDocumentModelConverter(DevExpress.XtraRichEdit.DocumentFormat.PlainText, System.Text.Encoding.Default)
                        ''Dim _stringConverter As New DevExpress.XtraEditors.Controls.Rtf.DocumentModelToStringConverter(DevExpress.XtraRichEdit.DocumentFormat.Rtf, System.Text.Encoding.Default)
                        ''_rtfConverter.ConvertToDocumentModel(.RichText.Model, _Texte)
                        ''Dim texteRTF As String = _stringConverter.ConvertToEditValue(.RichText.Model)
                        ' '' Me.R_Oferta.RichText.RtfText = ""
                        ''_Range = .RichText.Document.InsertRtfText(.RichText.Document.Range.Start, texteRTF)
                        ' '' End Using

                        ' ''.RichText.Document.Selection = .RichText.Document.CreateRange(.RichText.Document.CaretPosition, 1000)
                        ''Dim _CP As DevExpress.XtraRichEdit.API.Native.CharacterProperties = .RichText.Document.BeginUpdateCharacters(_Range)  '.RichText.Document.CaretPosition, 1000)

                        ''_CP.Bold = True
                        ''_CP.Underline = DevExpress.XtraRichEdit.API.Native.UnderlineType.Single
                        ''.RichText.Document.EndUpdateCharacters(_CP)

                        Dim _Logo As System.Drawing.Image = Util.BinaryToImage(oLinqArticulo.Marca.Logo.ToArray)
                        Dim _BB As DevExpress.XtraRichEdit.API.Native.Shape = .RichText.Document.InsertPicture(.RichText.Document.CaretPosition, _Logo)
                        _BB.Offset = New PointF(1900, 100)

                        Dim _X As Integer = _BB.OriginalSize.Height
                        Dim _Y As Integer = _BB.OriginalSize.Width
                        Dim _Rati As Decimal = 1

                        Do Until _X < 600 And _Y < 600
                            _Rati = _Rati - 0.1
                            _Y = _BB.OriginalSize.Height * _Rati
                            _X = _BB.OriginalSize.Width * _Rati
                        Loop

                        _BB.ScaleX = _Rati
                        _BB.ScaleY = _Rati
                        .RichText.Document.EndUpdateCharacters(CP)

                        'If Me.R_Oferta.RichText.ActiveViewType <> DevExpress.XtraRichEdit.RichEditViewType.PrintLayout Then
                        '    Me.R_Oferta.RichText.ActiveViewType = DevExpress.XtraRichEdit.RichEditViewType.PrintLayout
                        'End If
                    End If


                    If oLinqArticulo.Articulo_Fichero.Where(Function(F) F.ID_Articulo_FicheroTipo = CInt(EnumTiposFicheros.FotoPrincipal)).Count > 0 Then
                        Me.Picture_FotoArticulo.Image = Util.BinaryToImage(oLinqArticulo.Articulo_Fichero.Where(Function(F) F.ID_Articulo_FicheroTipo = CInt(EnumTiposFicheros.FotoPrincipal)).FirstOrDefault.Archivo.CampoBinario.ToArray)
                    Else
                        Me.Picture_FotoArticulo.Image = Nothing
                    End If

                    If Me.Picture_FotoArticulo.Image Is Nothing = False Then
                        Dim _Foto As System.Drawing.Image = M_Util.clsFunciones.CompressImage(Me.Picture_FotoArticulo.Image)
                        Dim _AA As DevExpress.XtraRichEdit.API.Native.Shape = .RichText.Document.InsertPicture(.RichText.Document.CaretPosition, _Foto)
                        _AA.Offset = New PointF(300, 350)

                        Dim _X As Integer = _AA.OriginalSize.Height
                        Dim _Y As Integer = _AA.OriginalSize.Width
                        Dim _Rati As Decimal = 1

                        Do Until _X < 1200 And _Y < 1200
                            _Rati = _Rati - 0.1
                            _Y = _AA.OriginalSize.Height * _Rati
                            _X = _AA.OriginalSize.Width * _Rati
                        Loop

                        _AA.ScaleX = _Rati
                        _AA.ScaleY = _Rati
                        .RichText.Document.EndUpdateCharacters(CP)
                        '  Me.R_Oferta.RichText.ActiveViewType = DevExpress.XtraRichEdit.RichEditViewType.PrintLayout
                    End If
  
                    Call Cargar()
                    Me.R_Oferta.RichText.Modified = True 'Fem això pq es detecti que s'ha modificat i al guardar es generin els 3 fitxers
                    Call Guardar()
                End With

        End Select


    End Sub

    Private Sub Cargar()

        Dim textToInsert As String = ""
        textToInsert = System.Environment.NewLine + System.Environment.NewLine + System.Environment.NewLine + System.Environment.NewLine + System.Environment.NewLine + System.Environment.NewLine + System.Environment.NewLine + System.Environment.NewLine + System.Environment.NewLine + System.Environment.NewLine + System.Environment.NewLine + System.Environment.NewLine + System.Environment.NewLine + System.Environment.NewLine + System.Environment.NewLine + System.Environment.NewLine + System.Environment.NewLine + System.Environment.NewLine + System.Environment.NewLine + System.Environment.NewLine + System.Environment.NewLine + System.Environment.NewLine + System.Environment.NewLine + System.Environment.NewLine + System.Environment.NewLine
        textToInsert = textToInsert & oLinqArticulo.Marca.Descripcion & " " & oLinqArticulo.Descripcion + System.Environment.NewLine
        ' textToInsert = textToInsert & System.Environment.NewLine + oLinqArticulo.Articulo_Aux.DescripcionCorta & System.Environment.NewLine
        Dim docuPosition As DevExpress.XtraRichEdit.API.Native.DocumentPosition = Me.R_Oferta.RichText.Document.CreatePosition(0)
        Me.R_Oferta.RichText.Document.InsertText(docuPosition, textToInsert)
        docuPosition = Me.R_Oferta.RichText.Document.CreatePosition(0)

        Dim insertedRange As DevExpress.XtraRichEdit.API.Native.DocumentRange = Me.R_Oferta.RichText.Document.CreateRange(docuPosition, textToInsert.Length)

        Dim properties As DevExpress.XtraRichEdit.API.Native.CharacterProperties = Me.R_Oferta.RichText.Document.BeginUpdateCharacters(insertedRange)
        properties.Bold = True
        properties.Underline = DevExpress.XtraRichEdit.API.Native.UnderlineType.Single
        Me.R_Oferta.RichText.Document.EndUpdateCharacters(properties)

        Dim pos As DevExpress.XtraRichEdit.API.Native.DocumentPosition = Me.R_Oferta.RichText.Document.CaretPosition
        Dim rangeToReset As DevExpress.XtraRichEdit.API.Native.DocumentRange = Me.R_Oferta.RichText.Document.CreateRange(pos, 1)
        Dim propertiesReset As DevExpress.XtraRichEdit.API.Native.CharacterProperties = Me.R_Oferta.RichText.Document.BeginUpdateCharacters(rangeToReset)
        propertiesReset.Bold = False
        propertiesReset.Underline = DevExpress.XtraRichEdit.API.Native.UnderlineType.None
        Me.R_Oferta.RichText.Document.EndUpdateCharacters(propertiesReset)

        Me.R_Oferta.RichText.Focus()

        textToInsert = System.Environment.NewLine + oLinqArticulo.Articulo_Aux.DescripcionCorta & System.Environment.NewLine & System.Environment.NewLine
        Me.R_Oferta.RichText.Document.InsertText(Me.R_Oferta.RichText.Document.Range.End, textToInsert)
        Me.R_Oferta.RichText.Document.InsertRtfText(Me.R_Oferta.RichText.Document.Range.End, Me.R_Ficha1.RichText.Document.RtfText)
        Me.R_Oferta.RichText.Document.InsertRtfText(Me.R_Oferta.RichText.Document.Range.End, Me.R_Ficha2.RichText.Document.RtfText)


        Dim _Final As String
        _Final = oLinqArticulo.LinkVideo & System.Environment.NewLine
        If IsNothing(oLinqArticulo.LinkVideo2) = False AndAlso oLinqArticulo.LinkVideo2.Length > 0 Then
            _Final = _Final & oLinqArticulo.LinkVideo2 & System.Environment.NewLine
        End If
        _Final = _Final + "Código de Barras: " & oLinqArticulo.CodigoBarras & " - Unidades de Embalaje: " & oLinqArticulo.EmbalajeUnidades



        Me.R_Oferta.RichText.Document.InsertText(Me.R_Oferta.RichText.Document.Range.End, _Final)


        'Dim _Boto As DevExpress.XtraRichEdit.Commands.InsertTextCommand = New DevExpress.XtraRichEdit.Commands.InsertTextCommand(Me.R_Oferta.RichText)
        '_Boto.CommandSourceType = DevExpress.Utils.Commands.CommandSourceType.Keyboard
        '_Boto.Text = "Prova"
        '_Boto.Execute()

        'Dim _Range As DevExpress.XtraRichEdit.API.Native.DocumentRange = Me.R_Oferta.RichText.Document.Range
        'Dim _Properties As DevExpress.XtraRichEdit.API.Native.CharacterProperties = Me.R_Oferta.RichText.Document.BeginUpdateCharacters(_Range)
        '_Properties.Reset()
        'Me.R_Oferta.RichText.Document.EndUpdateCharacters(_Properties)
    End Sub

#End Region

#Region "Metodes"

    Public Sub Entrada(Optional ByVal pID As Integer = 0)

        Try

            Me.AplicarDisseny()

            '   Me.ToolForm.M.Botons.tImprimir.SharedProps.Visible = True

            ' Fichero = New M_Archivos_Binarios.clsArchivosBinarios2(BD, Me.GRD_Ficheros, "Articulo_Archivo", 1)

            Util.Cargar_Combo(Me.C_Marca, "Select ID_Marca, Descripcion From Marca order by Descripcion", False)
            Util.Cargar_Combo(Me.C_IVA, "Select ID_IVA, Porcentaje From IVA order by ID_Iva", True)
            Util.Cargar_Combo(Me.C_TipoFichero, "Select ID_Articulo_FicheroTipo, Descripcion From Articulo_FicheroTipo order by ID_Articulo_FicheroTipo", True)

            Me.ToolForm.M.Botons.tAccions.SharedProps.Visible = True
            Me.ToolForm.M.clsToolBar.Activar_BotoAccionsPredeterminats(m_ToolForm.clsToolForm.EnumBotonsAccions.tSubAccions1, "Duplicar", True)
            Me.ToolForm.M.clsToolBar.Activar_BotoAccionsPredeterminats(m_ToolForm.clsToolForm.EnumBotonsAccions.tSubAccions2, "Cambiar la fuente", True)
            Me.ToolForm.M.clsToolBar.Activar_BotoAccionsPredeterminats(m_ToolForm.clsToolForm.EnumBotonsAccions.tSubAccions3, "Crear Word", True)

            Me.R_Oferta.RichText.Document.DefaultCharacterProperties.FontName = "Calibri"
            Me.R_Oferta.RichText.Document.DefaultCharacterProperties.FontSize = 10
            Me.R_Oferta.RichText.Document.Sections(0).Margins.Left = 200
            Me.R_Oferta.RichText.Document.Sections(0).Margins.Right = 200
            Me.R_Oferta.RichText.Document.Sections(0).Margins.Top = 200
            Me.R_Oferta.RichText.ActiveViewType = DevExpress.XtraRichEdit.RichEditViewType.PrintLayout

            Me.GRD_FicherosAvanzados.M.clsToolBar.Boto_Afegir("Descargar", "Descargar", True)


            Call ConfigurarFichas()


            Picture_FotoArticulo.Properties.ContextMenuStrip = New ContextMenuStrip
            Picture_FotoQR.Properties.ContextMenuStrip = New ContextMenuStrip

            'Me.R_Ficha1.RichText.Document.DefaultCharacterProperties.FontName = "Calibri"
            'Me.R_Ficha1.RichText.Document.DefaultCharacterProperties.FontSize = 10

            'Me.R_Ficha2.RichText.Document.DefaultCharacterProperties.FontName = "Calibri"
            'Me.R_Ficha2.RichText.Document.DefaultCharacterProperties.FontSize = 10

            'Me.GRD_Ficheros.M.clsToolBar.Boto_Afegir("FotoPredeterminada", "Foto Predeterminada", True)
            'Me.GRD_Ficheros.M.clsToolBar.Boto_Afegir("QuitarFotoPredeterminada", "Quitar foto predeterminada", True)

            'Me.TL_Cliente.ButtonsRight("Lupeta").Enabled = True
            'Me.TL_Cliente.ButtonsRight("Ficha").Enabled = True

            If pID <> 0 Then
                Call Cargar_Form(pID)
            Else
                Call Netejar_Pantalla()
            End If

            Me.KeyPreview = False

        Catch ex As Exception
            Mensaje.Mostrar_Mensaje_Error(ex)
        End Try

    End Sub

    Private Sub ConfigurarFichas()
        Call ConfigurarFicha(Me.R_Ficha1)
        Call ConfigurarFicha(Me.R_Ficha2)
    End Sub

    Private Sub ConfigurarFicha(ByRef pRichText As M_RichText.M_RichText)
        With pRichText
            ' .RichText.CreateNewDocument()
            .RichText.ActiveViewType = DevExpress.XtraRichEdit.RichEditViewType.Draft
            'Me.R_Ficha1.RichText.ActiveView.AllowDisplayLineNumbers = True
            .RichText.Document.Sections(0).Page.PaperKind = Drawing.Printing.PaperKind.A6
            .RichText.Document.Sections(0).Margins.Left = 0
            .RichText.Document.Sections(0).Margins.Right = 360
            .RichText.Document.Sections(0).Margins.Top = 0
            .RichText.ActiveView.ZoomFactor = 0.9 '1.28

            .RichText.Document.DefaultCharacterProperties.FontSize = 10
            .RichText.Document.DefaultCharacterProperties.FontName = "Calibri"

            Dim CP As DevExpress.XtraRichEdit.API.Native.CharacterProperties = .RichText.Document.BeginUpdateCharacters(.RichText.Document.Range)
            CP.FontName = "Calibri"
            CP.FontSize = 10
            .RichText.Document.EndUpdateCharacters(CP)
        End With
    End Sub

    Private Sub ConfigurarWord()
        With Me.R_Oferta
            .RichText.CreateNewDocument()
            .RichText.ActiveViewType = DevExpress.XtraRichEdit.RichEditViewType.PrintLayout
            .RichText.Document.DefaultCharacterProperties.FontSize = 10
            .RichText.Document.DefaultCharacterProperties.FontName = "Calibri"
            Dim CP As DevExpress.XtraRichEdit.API.Native.CharacterProperties = .RichText.Document.BeginUpdateCharacters(.RichText.Document.Range)
            CP.FontName = "Calibri"
            CP.FontSize = 10

            .RichText.Document.Sections(0).Page.PaperKind = Drawing.Printing.PaperKind.A4
            .RichText.Document.Sections(0).Margins.Left = 200
            .RichText.Document.Sections(0).Margins.Right = 200
            .RichText.Document.Sections(0).Margins.Top = 200
            .RichText.LayoutUnit = DevExpress.XtraRichEdit.DocumentLayoutUnit.Pixel
            .RichText.Document.EndUpdateCharacters(CP)
        End With
    End Sub

    Private Function Guardar() As Boolean
        Guardar = False
        Try
            Me.TE_Codigo.Focus()

            If ComprovacioCampsRequeritsError() = True Then
                Mensaje.Mostrar_Mensaje(M_Mensaje.Missatge_Tipus.MISSATGE_TEXTE_REQUERIT, "")
                Exit Function
            End If

            Call GetFromForm(oLinqArticulo)

            If oLinqArticulo.ID_Articulo = 0 Then  ' Comprovacio per saber si es un insertar o un nou
                oDTC.Articulo.InsertOnSubmit(oLinqArticulo)
                oDTC.SubmitChanges()

                Me.TE_Codigo.Value = oLinqArticulo.ID_Articulo
                Mensaje.Mostrar_Mensaje(M_Mensaje.Missatge_Tipus.MISSATGE_AFEGIR_REGISTRE)

                ' Call Fichero.Cargar_GRID(oLinqArticulo.ID_Articulo)

            Else
                oDTC.SubmitChanges()
                Mensaje.Mostrar_Mensaje(M_Mensaje.Missatge_Tipus.MISSATGE_MODIFICAR_REGISTRE)
                If R_Oferta.RichText.Modified = True Then
                    Call GuardarFitxersDelWord(oDTC, oLinqArticulo, Me.R_Oferta)
                End If
                Call CargarGrid_FicherosAvanzados(oLinqArticulo.ID_Articulo)

            End If

            Me.EstableixCaptionForm("Artículo: " & (oLinqArticulo.Descripcion))

            Guardar = True

        Catch ex As Exception
            Mensaje.Mostrar_Mensaje_Error(ex)
        End Try
    End Function

    Private Sub SetToForm()
        Try
            With oLinqArticulo
                Me.TE_Codigo.Text = .ID_Articulo
                Me.C_Marca.Value = .ID_Marca
                Me.C_Familia.Value = .ID_Familia
                Me.C_Subfamilia.Value = .ID_Subfamilia
                Me.C_IVA.Value = .ID_IVA
                Me.T_CodigoRiver.Text = .CodigoRiver
                Me.T_Codigo.Text = .Codigo
                Me.T_Descripcion.Text = .Descripcion
                Me.T_CodigoBarras.Text = .CodigoBarras
                Me.T_UnidadesEmbalaje.Value = DbnullToNothing(.EmbalajeUnidades)
                Me.T_ObservacionesEmbalaje.Text = .EmbalajeObservaciones
                Me.T_RAEE.Value = DbnullToNothing(.RAEE)
                Me.T_PVP.Value = DbnullToNothing(.PVP)
                Me.T_Dun14.Value = .DUN_14
                Me.T_Posicion.Value = DbnullToNothing(.Posicion)
                'Me.CH_Catalogo.Checked = .Catalogo
                Me.T_Observaciones.Text = .Observaciones
                Me.T_LinkVideo.Text = .LinkVideo
                Me.T_LinkVideo2.Text = .LinkVideo2
                'Me.T_CodigoQR.Text = .CodigoQR
                Me.DT_FechaAlta.Value = .FechaAlta
                Me.CH_Obsoleto.Checked = .Obsoleto
                Me.T_CodigoBlister.Text = .CodigoBlister

                If .Articulo_Fichero.Where(Function(F) F.ID_Articulo_FicheroTipo = CInt(EnumTiposFicheros.FotoPrincipal)).Count > 0 Then
                    Me.Picture_FotoArticulo.Image = Util.BinaryToImage(.Articulo_Fichero.Where(Function(F) F.ID_Articulo_FicheroTipo = CInt(EnumTiposFicheros.FotoPrincipal)).FirstOrDefault.Archivo.CampoBinario.ToArray)
                Else
                    Me.Picture_FotoArticulo.Image = Nothing
                End If

                If .Articulo_Fichero.Where(Function(F) F.ID_Articulo_FicheroTipo = CInt(EnumTiposFicheros.FotoQR)).Count > 0 Then
                    Me.Picture_FotoQR.Image = Util.BinaryToImage(.Articulo_Fichero.Where(Function(F) F.ID_Articulo_FicheroTipo = CInt(EnumTiposFicheros.FotoQR)).FirstOrDefault.Archivo.CampoBinario.ToArray)
                Else
                    Me.Picture_FotoQR.Image = Nothing
                End If

                Me.CH_Catalogo.Checked = CBool(BD.RetornaValorSQL("Select Catalogo From C_Articulo Where ID_Articulo=" & oLinqArticulo.ID_Articulo))

                'If oLinqArticulo.ID_Archivo_FotoPrincipal.HasValue = True Then
                '    Me.Picture_FotoArticulo.Image = Util.BinaryToImage(oLinqArticulo.Archivo.CampoBinario.ToArray)
                'Else
                '    Me.Picture_FotoArticulo.Image = Nothing
                'End If

                'If .Articulo_Aux.FotoQR Is Nothing = False Then
                '    Me.Picture_FotoQR.Image = Util.BinaryToImage(.Articulo_Aux.FotoQR.ToArray)
                'Else
                '    Me.Picture_FotoQR.Image = Nothing
                'End If

                Me.R_Ficha1.RichText.HtmlText = .Articulo_Aux.CaracteristicasFichaProducto1
                ' Me.R_Ficha1.pText = .Articulo_Aux.CaracteristicasFichaProducto1
                Me.R_Ficha2.RichText.HtmlText = .Articulo_Aux.CaracteristicasFichaProducto2
                Me.R_Oferta.RichText.RtfText = .Articulo_Aux.CaracteristicasCatalogoOferta
                Me.T_DescripcionCorta.Text = .Articulo_Aux.DescripcionCorta
                Me.T_DescripcionLarga.Text = .Articulo_Aux.DescripcionLarga

            End With

        Catch ex As Exception
            Mensaje.Mostrar_Mensaje_Error(ex)
        End Try
    End Sub

    Private Sub GetFromForm(ByRef pArticulo As Articulo)
        Try
            With pArticulo
                .CodigoRiver = Me.T_CodigoRiver.Text
                .Descripcion = Me.T_Descripcion.Text
                .CodigoBarras = Me.T_CodigoBarras.Text
                .Codigo = Me.T_Codigo.Text
                .EmbalajeUnidades = DbnullToNothing(Me.T_UnidadesEmbalaje.Value)
                .EmbalajeObservaciones = Me.T_ObservacionesEmbalaje.Text
                .RAEE = DbnullToNothing(Me.T_RAEE.Value)
                .PVP = DbnullToNothing(Me.T_PVP.Value)
                .DUN_14 = Me.T_Dun14.Value
                .Posicion = DbnullToNothing(Me.T_Posicion.Value)
                '.Catalogo = Me.CH_Catalogo.Checked
                .Observaciones = Me.T_Observaciones.Text
                .LinkVideo = Me.T_LinkVideo.Text
                .LinkVideo2 = Me.T_LinkVideo2.Text
                '.CodigoQR = Me.T_CodigoQR.Text
                .FechaAlta = Me.DT_FechaAlta.Value
                .Obsoleto = Me.CH_Obsoleto.Checked
                .CodigoBlister = Me.T_CodigoBlister.Text

                .Marca = oDTC.Marca.Where(Function(F) F.ID_Marca = CInt(Me.C_Marca.Value)).FirstOrDefault
                .Familia = oDTC.Familia.Where(Function(F) F.ID_Familia = CInt(Me.C_Familia.Value)).FirstOrDefault
                If Me.C_Subfamilia.SelectedIndex = -1 Then
                    .Subfamilia = Nothing
                Else
                    .Subfamilia = oDTC.Subfamilia.Where(Function(F) F.ID_Subfamilia = CInt(Me.C_Subfamilia.Value)).FirstOrDefault
                End If
                .IVA = oDTC.IVA.Where(Function(F) F.ID_IVA = CInt(Me.C_IVA.Value)).FirstOrDefault


                Dim _aux As Articulo_Aux

                If pArticulo.ID_Articulo = 0 Then
                    _aux = New Articulo_Aux
                    .Articulo_Aux = _aux
                Else
                    _aux = .Articulo_Aux
                End If

                _aux.CaracteristicasFichaProducto1 = Me.R_Ficha1.RichText.HtmlText
                _aux.CaracteristicasFichaProducto2 = Me.R_Ficha2.RichText.HtmlText
                _aux.CaracteristicasCatalogoOferta = Me.R_Oferta.RichText.RtfText
                _aux.DescripcionCorta = Me.T_DescripcionCorta.Text
                _aux.DescripcionLarga = Me.T_DescripcionLarga.Text

                .DataModificacio = Now
                .Exportat = False

                'If Me.Picture_FotoArticulo.Image Is Nothing Then
                '    _aux.FotoArticulo = Nothing
                'Else
                '    _aux.FotoArticulo = Util.ImageToBinary(Me.Picture_FotoArticulo.Image).ToArray
                'End If

                'If Me.Picture_FotoQR.Image Is Nothing Then
                '    _aux.FotoQR = Nothing
                'Else
                '    _aux.FotoQR = Util.ImageToBinary(Me.Picture_FotoQR.Image).ToArray
                'End If
            End With

        Catch ex As Exception
            Mensaje.Mostrar_Mensaje_Error(ex)
        End Try
    End Sub

    Private Sub Cargar_Form(ByVal pID As Integer)
        Try

            Call Netejar_Pantalla()

            oLinqArticulo = (From taula In oDTC.Articulo Where taula.ID_Articulo = pID Select taula).FirstOrDefault

            Call SetToForm()

            Call ConfigurarFichas()

            ' Fichero.Cargar_GRID(pID)
            Call CargarGrid_FicherosAvanzados(pID)

            Me.EstableixCaptionForm("Artículo: " & (oLinqArticulo.Descripcion))

        Catch ex As Exception
            Mensaje.Mostrar_Mensaje_Error(ex)
        End Try
    End Sub

    Private Sub Netejar_Pantalla()

        oLinqArticulo = New Articulo
        oDTC = New DTCDataContext(BD.Conexion)

        Util.Blanquejar(Me, M_Util.Enum_Controles_Activacion.TODOS_MENOS_ALGUNOS, True, C_Familia, C_Marca, C_Subfamilia)

        Me.TE_Codigo.Value = Nothing
        Me.TE_Codigo.Tag = Nothing

        Me.C_IVA.SelectedIndex = 0
        Me.C_Familia.SelectedIndex = -1
        Me.C_Subfamilia.SelectedIndex = -1
        Me.C_Marca.SelectedIndex = -1

        Me.DT_FechaAlta.Value = Now.Date

        Me.Picture_FotoArticulo.Image = Nothing
        Me.Picture_FotoQR.Image = Nothing

        ' Fichero.Cargar_GRID(0)
        Call CargarGrid_FicherosAvanzados(0)

        Me.EstableixCaptionForm("Artículo")

        ErrorProvider1.Clear()

        Call ConfigurarFichas()
        Call ConfigurarWord()
    End Sub

    Private Function ComprovacioCampsRequeritsError() As Boolean
        Try
            Dim oClsControls As New clsControles(ErrorProvider1)

            With Me
                ErrorProvider1.Clear()
                oClsControls.ControlBuit(.T_Descripcion)
                ' oClsControls.ControlBuit(.T_CodigoRiver)
                oClsControls.ControlBuit(.C_IVA)
                oClsControls.ControlBuit(.C_Marca)
                oClsControls.ControlBuit(.C_Familia)
                oClsControls.ControlBuit(.C_Subfamilia)


            End With

            ComprovacioCampsRequeritsError = oClsControls.pCampRequeritTrobat

        Catch ex As Exception
            Mensaje.Mostrar_Mensaje_Error(ex)
        End Try
    End Function

    Public Function DbnullToNothing(ByVal pValor As Object) As Decimal?
        ' DbnullToNothing = pValor
        Try
            If pValor Is Nothing = False Then
                If IsDBNull(pValor) = True Then
                    Return Nothing
                Else
                    Return CDbl(pValor)
                End If
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub Cridar_Llistat_Generic()
        Dim LlistatGeneric As New M_LlistatGeneric.clsLlistatGeneric
        LlistatGeneric.Mostrar_Llistat("Select * From C_Articulo order by Marca, Descripcion", Me.TE_Codigo, "ID_Articulo", "ID_Articulo")

        AddHandler LlistatGeneric.AlTancarLlistatGeneric, AddressOf AlTancarLlistat

    End Sub

    Private Sub AlTancarLlistat(ByVal pID As String)
        Try
            Call Cargar_Form(pID)
        Catch ex As Exception
            Mensaje.Mostrar_Mensaje_Error(ex)
        End Try

    End Sub

#End Region

#Region "Events Varis"
    Private Sub TE_Codigo_EditorButtonClick(sender As Object, e As UltraWinEditors.EditorButtonEventArgs) Handles TE_Codigo.EditorButtonClick
        If e.Button.Key = "Lupeta" Then
            Call Cridar_Llistat_Generic()
        End If
    End Sub

    Private Sub C_Marca_ValueChanged(sender As Object, e As EventArgs) Handles C_Marca.ValueChanged
        Dim _ID_Marca As Integer
        If Me.C_Marca.Value Is Nothing OrElse IsNumeric(Me.C_Marca.Value) = False Then
            Exit Sub
        Else
            _ID_Marca = Me.C_Marca.Value
        End If

        Util.Cargar_Combo(Me.C_Familia, "Select ID_Familia, TipusFamilia From C_Familia Where ID_Marca=" & Me.C_Marca.Value & " order by TipusFamilia", False)

        If oLinqArticulo.ID_Articulo = 0 Then
            Dim _Marca As Marca = oDTC.Marca.Where(Function(F) F.ID_Marca = _ID_Marca).FirstOrDefault
            'Me.T_RAEE.Value = _Marca.RAEE
            Me.C_IVA.Value = _Marca.ID_IVA
        End If
    End Sub

    Private Sub C_Familia_ValueChanged(sender As Object, e As EventArgs) Handles C_Familia.ValueChanged
        Dim _ID_Familia As Integer
        If Me.C_Familia.Value Is Nothing OrElse IsNumeric(Me.C_Familia.Value) = False Then
            Exit Sub
        Else
            _ID_Familia = Me.C_Familia.Value
        End If

        Util.Cargar_Combo(Me.C_Subfamilia, "Select ID_Subfamilia, Descripcion From SubFamilia Where ID_Familia=" & Me.C_Familia.Value & " order by Descripcion", False)

    End Sub

    Private Sub Tab_Principal_SelectedTabChanged(sender As Object, e As UltraWinTabControl.SelectedTabChangedEventArgs) Handles Tab_Principal.SelectedTabChanged
        Select Case e.Tab.Key
            Case "Ficheros"
                Call DespresDeCarregarDadesGridArchivos()
            Case "FichaTecnica"
                'Me.R_Oferta.RichText.RtfText = oLinqArticulo.Articulo_Aux.CaracteristicasCatalogoOferta
        End Select
    End Sub
    Private Sub C_TipoFichero_ValueChanged(sender As Object, e As EventArgs) Handles C_TipoFichero.ValueChanged
        If oLinqArticulo Is Nothing = False Then
            Call CargarGrid_FicherosAvanzados(oLinqArticulo.ID_Articulo)
        End If
    End Sub

#End Region

#Region "Ficheros"
    Private Sub GRD_Ficheros_M_ToolGrid_ToolClickBotonsExtras2(ByRef sender As UltraWinToolbars.UltraToolbarsManager, ByRef e As UltraWinToolbars.ToolClickEventArgs, ByRef pGrid As M_UltraGrid.m_UltraGrid) Handles GRD_Ficheros.M_ToolGrid_ToolClickBotonsExtras2
        If e.Tool.Key = "FotoPredeterminada" AndAlso Me.GRD_Ficheros.GRID.Selected.Rows.Count = 1 Then
            Dim _IDArchivo As Integer = Me.GRD_Ficheros.GRID.Selected.Rows(0).Cells("ID_Archivo").Value
            Dim _Archivo As Archivo
            _Archivo = oDTC.Archivo.Where(Function(F) F.ID_Archivo = _IDArchivo).FirstOrDefault
            If _Archivo.Tipo.ToString.ToLower.Contains("image") = True Or _Archivo.Tipo.ToString.ToLower.Contains("jpg") = True Or _Archivo.Tipo.ToString.ToLower.Contains("jpeg") = True Or _Archivo.Tipo.ToString.ToLower.Contains("png") = True Or _Archivo.Tipo.ToString.ToLower.Contains("tiff") = True Or _Archivo.Tipo.ToString.ToLower.Contains("gif") = True Or _Archivo.Tipo.ToString.ToLower.Contains("bmp") = True Then
            Else
                Mensaje.Mostrar_Mensaje("Sólo se pueden predeterminar ficheros de tipo imagen", M_Mensaje.Missatge_Modo.INFORMACIO, , , True)
                Exit Sub
            End If
            oLinqArticulo.Archivo = _Archivo
            oDTC.SubmitChanges()
            Call DespresDeCarregarDadesGridArchivos()
        End If

        If e.Tool.Key = "QuitarFotoPredeterminada" Then
            'Dim _IDArchivo As Integer = Me.GRD_Ficheros.GRID.Selected.Rows(0).Cells("ID_Archivo").Value
            'Dim _Archivo As Archivo
            '_Archivo = oDTC.Archivo.Where(Function(F) F.ID_Archivo = _IDArchivo).FirstOrDefault
            'If _Archivo.ID_Archivo = oLinqProducto.ID_Archivo_FotoPredeterminada Then
            oLinqArticulo.Archivo = Nothing
            oDTC.SubmitChanges()
            'End If
            Call DespresDeCarregarDadesGridArchivos()
        End If
    End Sub

    Private Sub DespresDeCarregarDadesGridArchivos()
        Try
            If Me.GRD_Ficheros.GRID.Rows.Count > 0 Then
                Dim pRow As UltraGridRow
                For Each pRow In Me.GRD_Ficheros.GRID.Rows
                    If oLinqArticulo.ID_Archivo_FotoPrincipal.HasValue = True AndAlso pRow.Cells("ID_Archivo").Value = oLinqArticulo.ID_Archivo_FotoPrincipal Then
                        pRow.CellAppearance.BackColor = Color.LightGreen
                    Else
                        pRow.CellAppearance.BackColor = Color.White
                    End If
                Next
                Me.GRD_Ficheros.GRID.ActiveRow = Nothing
                Me.GRD_Ficheros.GRID.Selected.Rows.Clear()

                If oLinqArticulo.ID_Archivo_FotoPrincipal.HasValue = True Then
                    Me.Picture_FotoArticulo.Image = Util.BinaryToImage(oLinqArticulo.Archivo.CampoBinario.ToArray)
                Else
                    Me.Picture_FotoArticulo.Image = Nothing
                End If
            End If
        Catch ex As Exception
            Mensaje.Mostrar_Mensaje_Error(ex)
        End Try
    End Sub

    Private Sub GRD_Ficheros_M_ToolGrid_ToolEliminar(ByRef sender As UltraWinToolbars.UltraToolbarsManager, ByRef e As UltraWinToolbars.ToolClickEventArgs) Handles GRD_Ficheros.M_ToolGrid_ToolEliminar
        oLinqArticulo.Archivo = Nothing
        oDTC.SubmitChanges()
    End Sub
#End Region

#Region "Ficheros avanzados"

    Private Sub CargarGrid_FicherosAvanzados(ByVal pIDArticulo As Integer)
        Try
            With Me.GRD_FicherosAvanzados
                If Me.C_TipoFichero.Value = CInt(EnumTiposFicheros.PDFSAT) Then
                    .M.clsUltraGrid.Cargar("Select null as Foto,*, " & oLinqArticulo.ID_Articulo & " as ID_Articulo From C_Marca_Archivo Where ID_Marca_Archivo=" & oLinqArticulo.ID_Marca & " Order by ID_Articulo_FicheroTipo", BD)
                Else
                    .M.clsUltraGrid.Cargar("Select null as Foto,* From C_Articulo_FicherosAvanzados Where ID_Articulo=" & pIDArticulo & " and ID_Articulo_FicheroTipo=" & Me.C_TipoFichero.Value & " Order by ID_Articulo_FicheroTipo", BD)
                End If



                Dim _Column As Infragistics.Win.UltraWinGrid.UltraGridColumn

                For Each _Column In .GRID.DisplayLayout.Bands(0).Columns
                    _Column.CellActivation = Activation.NoEdit
                Next

                If CInt(Me.C_TipoFichero.Value) = CInt(EnumTiposFicheros.FotosCatalogoWeb) Then
                    Call PosarEditableColumnes(0, "OrdreCataleg")
                    Call PosarEditableColumnes(0, "OrdreWeb")
                Else
                    Me.GRD_FicherosAvanzados.GRID.DisplayLayout.Bands(0).Columns("OrdreCataleg").Hidden = True
                    Me.GRD_FicherosAvanzados.GRID.DisplayLayout.Bands(0).Columns("OrdreWeb").Hidden = True
                End If

                .M_Editable()
                .GRID.Selected.Rows.Clear()
                .GRID.ActiveRow = Nothing


            End With
        Catch ex As Exception
            Mensaje.Mostrar_Mensaje_Error(ex)
        End Try
    End Sub

    Private Sub PosarEditableColumnes(ByVal pIDBanda As Integer, ByVal pNomColumna As String)
        Try
            With Me.GRD_FicherosAvanzados.GRID
                .DisplayLayout.Bands(pIDBanda).Columns(pNomColumna).CellActivation = Activation.AllowEdit
                .DisplayLayout.Bands(pIDBanda).Columns(pNomColumna).CellClickAction = CellClickAction.EditAndSelectText
                .DisplayLayout.Bands(pIDBanda).Columns(pNomColumna).Nullable = Nullable.Null
            End With
        Catch ex As Exception
            Mensaje.Mostrar_Mensaje_Error(ex)
        End Try
    End Sub

    Private Sub GRD_FicherosAvanzados_M_GRID_DoubleClickRow2(ByRef sender As M_UltraGrid.m_UltraGrid, ByRef e As UltraGridRow) Handles GRD_FicherosAvanzados.M_GRID_DoubleClickRow2
        Dim pepe As New M_Archivos_Binarios.clsArchivosBinarios2(BD)
        Call pepe.Ejecutar_Aplicacion("fichero", e.Cells("ID_Archivo").Value)

    End Sub

    'Private Sub GRD_Linies_M_GRID_AfterCellUpdate(sender As Object, e As CellEventArgs) Handles GRD_Linies.M_GRID_AfterCellUpdate
    '    Dim _Linea As OfertaColeccion_Linea = oDTC.OfertaColeccion_Linea.Where(Function(F) F.ID_OfertaColeccion_Linea = CInt(e.Cell.Row.Cells("ID_OfertaColeccion_Linea").Value)).FirstOrDefault

    '    Select Case e.Cell.Column.Key
    '        Case "Linea_PVP"
    '            If IsDBNull(e.Cell.Value) Then
    '                _Linea.PVP = Nothing
    '            Else
    '                _Linea.PVP = e.Cell.Value
    '            End If
    '        Case "Linea_Precio"
    '            If IsDBNull(e.Cell.Value) Then
    '                _Linea.Precio = Nothing
    '            Else
    '                _Linea.Precio = e.Cell.Value
    '            End If
    '        Case "Linea_Observaciones"
    '            If IsDBNull(e.Cell.Value) Then
    '                _Linea.Observaciones = Nothing
    '            Else
    '                _Linea.Observaciones = e.Cell.Value
    '            End If
    '        Case "Linea_Posicion"
    '            If IsDBNull(e.Cell.Value) Then
    '                _Linea.Posicion = Nothing
    '            Else
    '                _Linea.Posicion = e.Cell.Value
    '            End If
    '        Case "Linea_Espacios"
    '            If IsDBNull(e.Cell.Value) Then
    '                _Linea.Espacios = Nothing
    '            Else
    '                _Linea.Espacios = e.Cell.Value
    '            End If
    '    End Select
    '    oDTC.SubmitChanges()
    'End Sub

    Private Sub GRD_Linies_M_ToolGrid_ToolAfegir(ByRef sender As UltraWinToolbars.UltraToolbarsManager, ByRef e As UltraWinToolbars.ToolClickEventArgs) Handles GRD_FicherosAvanzados.M_ToolGrid_ToolAfegir
        If oLinqArticulo.ID_Articulo = 0 Then
            Exit Sub
        End If

        Dim _MultiSelect As Boolean
        Dim _Extension As String = ""
        Dim _NumeroDeFitxersPossiblesAImportar As Integer = 0
        Dim pepe As EnumTiposFicheros = CInt(Me.C_TipoFichero.Value)

        Select Case pepe
            Case EnumTiposFicheros.FotoPrincipal
                _MultiSelect = False
                _Extension = "JPG Files|*.jpg"
                _NumeroDeFitxersPossiblesAImportar = 1
            Case EnumTiposFicheros.FotoPrincipalWeb
                _MultiSelect = False
                _Extension = "JPG Files|*.jpg"
                _NumeroDeFitxersPossiblesAImportar = 1
            Case EnumTiposFicheros.FotoQR
                _MultiSelect = False
                _Extension = "JPG Files|*.jpg"
                _NumeroDeFitxersPossiblesAImportar = 1
            Case EnumTiposFicheros.FotosCatalogoWeb
                _MultiSelect = True
                _Extension = "JPG Files|*.jpg"
                _NumeroDeFitxersPossiblesAImportar = 99
            Case EnumTiposFicheros.PDFManual
                _MultiSelect = False
                _Extension = "PDF Files|*.pdf"
                _NumeroDeFitxersPossiblesAImportar = 1
            Case EnumTiposFicheros.PDFSAT
                _MultiSelect = False
                _Extension = "PDF Files|*.pdf"
                _NumeroDeFitxersPossiblesAImportar = 0
            Case EnumTiposFicheros.PDFFicha
                _MultiSelect = False
                _Extension = "PDF Files|*.pdf"
                _NumeroDeFitxersPossiblesAImportar = 0
            Case EnumTiposFicheros.WordFicha
                _MultiSelect = False
                _Extension = "JPG Files|*.jpg"
                _NumeroDeFitxersPossiblesAImportar = 0
            Case EnumTiposFicheros.FotoFicha
                _MultiSelect = False
                _Extension = "JPG Files|*.jpg"
                _NumeroDeFitxersPossiblesAImportar = 0
        End Select

        If Me.GRD_FicherosAvanzados.GRID.Rows.Count + 1 > _NumeroDeFitxersPossiblesAImportar Then
            Mensaje.Mostrar_Mensaje("Imposible asignar ficheros de este tipo", M_Mensaje.Missatge_Modo.INFORMACIO, "")
            Exit Sub
        End If

        Dim _Dialogo As New OpenFileDialog
        With _Dialogo
            .DefaultExt = "*.JPG"

            .DereferenceLinks = True
            .Multiselect = True
            .Title = "Seleccionar ficheros:"
            '.DefaultExt = "*.jpg"
            .Filter = _Extension
            '.Filter = _Extension
            .FilterIndex = 1
            Dim oFitxer As New Scripting.FileSystemObject
            If .ShowDialog = Windows.Forms.DialogResult.OK Then

                Dim i As Integer = 0

                For i = 0 To .FileNames.Count - 1
                    Dim _RutaComplerta As String = .FileNames(i)
                    Dim _NomFitxer As String = .SafeFileNames(i)
                    Dim oFichero As New M_Util.clsFichero
                    oFichero.Obtener_extension()
                    Dim ID_ArxiuInsertat As Integer
                    ID_ArxiuInsertat = Guardar_en_BaseDades(_RutaComplerta, _NomFitxer, System.Drawing.Color.White.ToArgb, M_Archivos_Binarios.clsArchivosBinarios2.Obtener_tamaño(_RutaComplerta), M_Archivos_Binarios.clsArchivosBinarios2.Obtener_extension(_RutaComplerta), Now, 100)
                    If ID_ArxiuInsertat = 0 Then
                        Mensaje.Mostrar_Mensaje("Los ficheros no se han guardado correctamente.", M_Mensaje.Missatge_Modo.INFORMACIO, "Inserción múltiple")
                        Exit Sub
                    End If
                    'Ahora hay que guardar en la tabla relacionada!
                    'If oID_TablaRelacion > 0 Then
                    Call GuardarFicheroAvanzado(ID_ArxiuInsertat, oDTC, oLinqArticulo, Me.C_TipoFichero.Value)
                    'End If
                    Call CargarGrid_FicherosAvanzados(oLinqArticulo.ID_Articulo)
                    'RaiseEvent AlAfegirRegistre(ID_ArxiuInsertat)

                Next
                Mensaje.Mostrar_Mensaje("Ficheros añadidos correctamente", M_Mensaje.Missatge_Modo.INFORMACIO, "")

            End If
        End With

        'Dim frm As New frmOfertaColeccion_Assignacion
        'frm.Entrada(oDTC, oLinqOfertaColeccion, oDTFotosProductos)
        'frm.FormObrir(Me, True)

        'AddHandler frm.AlTancarForm, AddressOf AlTancarFormSeleccio

    End Sub

    Private Sub GRD_Linies_M_ToolGrid_ToolEliminarRow(ByRef sender As UltraGrid, ByRef e As UltraGridRow) Handles GRD_FicherosAvanzados.M_ToolGrid_ToolEliminarRow
        If oLinqArticulo.ID_Articulo = 0 Then
            Exit Sub
        End If

        If Mensaje.Mostrar_Mensaje(M_Mensaje.Missatge_Tipus.MISSATGE_ELIMINAR_REGISTRE_PREGUNTA) = M_Mensaje.Botons.SI Then
            Dim _IDArticulo As Integer = CInt(e.Cells("ID_Articulo_Fichero").Value)
            Dim _Articulo As Articulo_Fichero = oDTC.Articulo_Fichero.Where(Function(F) F.ID_Articulo_Fichero = _IDArticulo).FirstOrDefault
            oDTC.Archivo.DeleteOnSubmit(_Articulo.Archivo)
            oDTC.Articulo_Fichero.DeleteOnSubmit(_Articulo)
            oDTC.SubmitChanges()
            Call CargarGrid_FicherosAvanzados(oLinqArticulo.ID_Articulo)
        End If
    End Sub

    Private Sub GRD_FicherosAvanzados_M_GRID_AfterCellUpdate(sender As Object, e As CellEventArgs) Handles GRD_FicherosAvanzados.M_GRID_AfterCellUpdate
        Dim _Linea As Articulo_Fichero = oDTC.Articulo_Fichero.Where(Function(F) F.ID_Articulo_Fichero = CInt(e.Cell.Row.Cells("ID_Articulo_Fichero").Value)).FirstOrDefault

        Select Case e.Cell.Column.Key
            Case "OrdreCataleg"
                If IsDBNull(e.Cell.Value) Then
                    _Linea.OrdreCataleg = Nothing
                Else
                    _Linea.OrdreCataleg = e.Cell.Value
                End If
                _Linea.DataModificacio = Date.Now
                _Linea.Exportat = False
            Case "OrdreWeb"
                If IsDBNull(e.Cell.Value) Then
                    _Linea.OrdreWeb = Nothing
                Else
                    _Linea.OrdreWeb = e.Cell.Value
                End If
                _Linea.DataModificacio = Date.Now
                _Linea.Exportat = False
        End Select
        oDTC.SubmitChanges()
    End Sub

    Private Sub GRD_FicherosAvanzados_M_Grid_InitializeRow(Sender As Object, e As InitializeRowEventArgs) Handles GRD_FicherosAvanzados.M_Grid_InitializeRow
        e.Row.Height = 50

        'Dim ID_Archivo As Integer = Util.Comprobar_NULL_Per_0(BD.RetornaValorSQL("Select ID_Archivo_FotoPrincipal From Articulo Where ID_Articulo=" & e.Row.Cells("ID_Articulo").Value))
        '  If ID_Archivo > 0 Then
        If e.Row.Cells("Descripcion").Value.ToString.ToUpper.Contains("JPG") Then
            e.Row.Cells("Foto").Appearance.Image = Util.BinaryToImage(BD.RetornaValorSQL("Select CampoBinario From Archivo Where ID_Archivo=" & e.Row.Cells("ID_Archivo").Value))
            'e.Row.Cells("ID_Archivo").Appearance.ImageBackground = Util.BinaryToImage(BD.RetornaValorSQL("Select CampoBinario From Archivo Where ID_Archivo=" & e.Row.Cells("ID_Archivo").Value))
            'e.Row.Cells("ID_Archivo").Appearance.ImageBackgroundStyle = ImageBackgroundStyle.Stretched
            'e.Row.Cells("ID_Archivo").Style = ColumnStyle.Image
        End If
        '  End If
    End Sub

    Private Sub GRD_FicherosAvanzados_M_ToolGrid_ToolClickBotonsExtras2(ByRef sender As UltraWinToolbars.UltraToolbarsManager, ByRef e As UltraWinToolbars.ToolClickEventArgs, ByRef pGrid As M_UltraGrid.m_UltraGrid) Handles GRD_FicherosAvanzados.M_ToolGrid_ToolClickBotonsExtras2
        Select Case e.Tool.Key
            Case "Descargar"
                If GRD_FicherosAvanzados.GRID.Selected.Rows.Count > 0 Then
                    Dim _ID_Archivo As Integer = GRD_FicherosAvanzados.GRID.Selected.Rows(0).Cells("ID_Archivo").Value
                    Dim _NombreFichero As String = BD.RetornaValorSQL("Select Ruta_Fichero From Archivo Where ID_Archivo=" & _ID_Archivo)
                    Dim _SaveDialog As New SaveFileDialog
                    _SaveDialog.RestoreDirectory = True
                    _SaveDialog.FileName = _NombreFichero
                    If _SaveDialog.ShowDialog = DialogResult.OK Then
                        Call Guardar_en_Archivo(_SaveDialog.FileName, _ID_Archivo)
                    End If
                End If
        End Select
    End Sub

    'Private Sub AlTancarFormSeleccio(ByRef pCancel As Boolean)
    '    Try
    '        Call CargarGrid_ArticulosSeleccionados(oLinqOfertaColeccion.ID_OfertaColeccion)
    '    Catch ex As Exception
    '        Mensaje.Mostrar_Mensaje_Error(ex)
    '    End Try
    'End Sub

    'Private Sub GRD_Linies_M_Grid_InitializeRow(Sender As Object, e As Infragistics.Win.UltraWinGrid.InitializeRowEventArgs) Handles GRD_Linies.M_Grid_InitializeRow
    '    'With Me.GRD_Linies
    '    '    If oDTFotosProductos Is Nothing = False Then
    '    '        Dim DTRow As DataRow() = oDTFotosProductos.Select("ID_Articulo=" & e.Row.Cells("ID_Articulo").Value)
    '    '        If DTRow Is Nothing = False AndAlso DTRow.Length <> 0 Then
    '    '            If IsDBNull(DTRow(0).Item("FotoArticulo")) = False Then
    '    '                e.Row.Cells("Foto").Appearance.Image = Util.BinaryToImage(DTRow(0).Item("FotoArticulo"))
    '    '            End If
    '    '        End If
    '    '    End If
    '    'End With
    '    'With Me.GRD_Linies
    '    '    '   If oDTFotosProductos Is Nothing = False Then
    '    '    'Dim DTRow As DataRow() = oDTFotosProductos.Select("ID_Articulo=" & e.Row.Cells("ID_Articulo").Value)

    '    '    Dim ID_Archivo As Integer = Util.Comprobar_NULL_Per_0(BD.RetornaValorSQL("Select ID_Archivo_FotoPrincipal From Articulo Where ID_Articulo=" & e.Row.Cells("ID_Articulo").Value))
    '    '    If ID_Archivo > 0 Then
    '    '        e.Row.Cells("Foto").Appearance.Image = Util.BinaryToImage(BD.RetornaValorSQL("Select CampoBinario From Archivo Where ID_Archivo=" & ID_Archivo))
    '    '    End If

    '    'End With

    'End Sub

    'Private Sub GRD_Linies_M_GRID_AfterRowUpdate(sender As Object, e As RowEventArgs) Handles GRD_Linies.M_GRID_AfterRowUpdate
    '    If e.Row.Cells("Linea_Posicion").Value <> e.Row.Cells("Linea_Posicion").OriginalValue Then
    '        Call ReordenarLinies(e.Row.Cells("ID_OfertaColeccion_Linea").Value, e.Row.Cells("Linea_Posicion").Value)
    '        Call CargarGrid_ArticulosSeleccionados(oLinqOfertaColeccion.ID_OfertaColeccion)
    '    End If
    'End Sub

    'Private Sub GRD_Linies_M_GRID_AfterSelectChange(ByRef sender As UltraGrid, ByRef e As AfterSelectChangeEventArgs) Handles GRD_Linies.M_GRID_AfterSelectChange
    '    Me.R_Observaciones.RichText.HtmlText = ""
    '    If Me.GRD_Linies.GRID.Selected.Rows.Count = 0 Then
    '        'BD.EjecutarConsulta("Update OfertaColeccion_Linea Set Observaciones='" & Me.R_Observaciones.RichText.HtmlText & "' Where ")

    '        ' Me.R_Observaciones.Tag = Nothing
    '    End If
    'End Sub

    'Private Sub GRD_Linies_M_GRID_ClickRow2(ByRef sender As M_UltraGrid.m_UltraGrid, ByRef e As UltraGridRow) Handles GRD_Linies.M_GRID_ClickRow2
    '    Me.R_Observaciones.RichText.HtmlText = Util.Comprobar_NULL(BD.RetornaValorSQL("Select Observaciones From OfertaColeccion_Linea Where ID_OfertaColeccion_Linea=" & e.Cells("ID_OfertaColeccion_Linea").Value))

    '    'Dim CP As DevExpress.XtraRichEdit.API.Native.CharacterProperties = Me.R_Observaciones.RichText.Document.BeginUpdateCharacters(Me.R_Observaciones.RichText.Document.Range)
    '    'CP.FontName = "Calibri"
    '    'CP.FontSize = 10
    '    'CP.ForeColor = Color.Red
    '    'CP.Bold = True
    '    ''CP.BackColor = Color.Snow
    '    'Me.R_Observaciones.RichText.Document.EndUpdateCharacters(CP)
    '    Me.R_Observaciones.RichText.Document.DefaultCharacterProperties.FontSize = 10
    '    Me.R_Observaciones.RichText.Document.DefaultCharacterProperties.FontName = "Calibri"
    '    Me.R_Observaciones.RichText.Document.DefaultCharacterProperties.ForeColor = Color.Red
    '    Me.R_Observaciones.RichText.Document.DefaultCharacterProperties.Bold = True

    'End Sub

    'Private Sub GRD_Linies_M_ToolGrid_ToolClickBotonsExtras2(ByRef sender As UltraWinToolbars.UltraToolbarsManager, ByRef e As UltraWinToolbars.ToolClickEventArgs, ByRef pGrid As M_UltraGrid.m_UltraGrid) Handles GRD_Linies.M_ToolGrid_ToolClickBotonsExtras2
    '    Select Case e.Tool.Key
    '        Case "guardar_observaciones"
    '            If Me.GRD_Linies.GRID.Selected.Rows.Count = 1 Then
    '                Dim _Linea As OfertaColeccion_Linea = oDTC.OfertaColeccion_Linea.Where(Function(F) F.ID_OfertaColeccion_Linea = CInt(Me.GRD_Linies.GRID.Selected.Rows(0).Cells("ID_OfertaColeccion_Linea").Value)).FirstOrDefault
    '                _Linea.Observaciones = Me.R_Observaciones.RichText.HtmlText
    '                oDTC.SubmitChanges()
    '                Mensaje.Mostrar_Mensaje("Observaciones guardadas correctamente", M_Mensaje.Missatge_Modo.INFORMACIO, "")



    '                'BD.EjecutarConsulta("Update OfertaColeccion_Linea Set Observaciones='" & Me.R_Observaciones.RichText.HtmlText & "' Where ID_OfertaColeccion_Linea=" & Me.GRD_Linies.GRID.Selected.Rows(0).Cells("ID_OfertaColeccion_Linea").Value)
    '                ' Me.R_Observaciones.RichText.HtmlText = ""
    '                ' Me.R_Observaciones.Tag = Nothing
    '            End If
    '    End Select
    'End Sub

#End Region

#Region "IDisposable Support"
    Private disposedValue As Boolean ' Para detectar llamadas redundantes

    ' IDisposable
    Protected Overrides Sub Dispose(disposing As Boolean)
        If Not Me.disposedValue Then
            If disposing Then
                If components IsNot Nothing Then components.Dispose()
                ' TODO: eliminar estado administrado (objetos administrados).

                If oDTC Is Nothing = False Then
                    ' Fichero.Dispose()
                End If

                If oDTC Is Nothing = False Then
                    oDTC.Dispose()
                End If

                Me.GRD_Ficheros.GRID.Dispose()
                Me.GRD_Ficheros.Dispose()
                Me.GRD_FicherosAvanzados.GRID.Dispose()
                Me.GRD_FicherosAvanzados.Dispose()
                Me.R_Ficha1.RichText.Dispose()
                Me.R_Ficha1.Dispose()
                Me.R_Ficha2.RichText.Dispose()
                Me.R_Ficha2.Dispose()
                Me.R_Oferta.RichText.Dispose()
                Me.R_Oferta.Dispose()

                ' Fichero = Nothing
            End If

            Me.GRD_Ficheros.GRID = Nothing
            Me.GRD_Ficheros = Nothing
            Me.GRD_FicherosAvanzados.GRID = Nothing
            Me.GRD_FicherosAvanzados = Nothing
            Me.R_Ficha1 = Nothing
            Me.R_Ficha2 = Nothing
            Me.R_Oferta = Nothing



            ' TODO: liberar recursos no administrados (objetos no administrados) e invalidar Finalize() below.
            ' TODO: Establecer campos grandes como Null.

            oDTC = Nothing

        End If
        Me.disposedValue = True
        ' Me.Dispose(True)
        MyBase.Dispose(True)
    End Sub
#End Region



End Class