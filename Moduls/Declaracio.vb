Public Module Declaracio
    Public BD As M_Conexion.clsConexion
    Public BD2 As M_Conexion.clsConexion
    Public Util As M_Util.clsFunciones
    Public Mensaje As M_Mensaje.clsMensaje
    Public Seguretat As M_Seguretat.clsSeguretat
    Public frmPrincipal As Principal
    Public Informes As M_Informes.clsInformes
    Public LlistatsADV As M_LlistatADV.clsLlistatADV
    Public RichTextCaixaText As M_RichText.M_RichText

    'Public oUser As Usuario
    Public oclsPilaFormularis As New clsPilaFormularis
    Public Temps As Long
    Public Const ConstNivellSeguretatMaxim As Integer = 100


    Enum EnumBancos As Integer
        LaCaixa = 1
        Bankia = 2
        BBVA = 3
        Santander = 4
        Sabadell = 5
        Ibercaja = 6
        Cajamar = 7
    End Enum

    Enum EnumAusenciaTipo As Integer
        Vacaciones = 1
        Dias_acordados = 2
        Asuntos_propios = 3
        Matrimonio = 13
        Nacimiento_hijo = 32
        Adopcion_Acogimiento = 33
        Accidente_Enfermedad_Hospitalizacion_intervencion_de_un_familiar = 36
        Fallecimiento_familiar = 37
        Mudanza = 39
        Cumplimiento_deber_inexcusable = 40
        Formacion = 41
        Formacion_prenatal = 42
        Baja_sin_justificar = 43
        Enfermedad_comun = 44
        Baja_accidente_laboral = 45
        Medico_especialista = 46
        Festivos_nacionales = 47
        Intervencion_quirurgica = 49
        Ausencia_sin_justificar = 50
        Horas_sindicales = 51
        Medico_privado = 52
        Acompanar_menor_12 = 53

    End Enum

    Enum EnumTipoSolicitud As Integer
        Autorizacion = 1
        Solicitud = 2
    End Enum

    Enum EnumTipoAusencia As Integer
        Vacaciones = 1
        Medico = 2
        Otros = 3
    End Enum

    Enum EnumEstatPersonal As Integer
        Alta = 1
        Baixa = 2
    End Enum

    Enum EnumInforme As Integer
        Ofertas = 1
        Colecciones = 2
        Catalogo = 1002
        PLV = 1003
    End Enum

    Enum EnumEstatsSolicitud As Integer
        Pendiente = 1
        EnCurso = 2
        Aceptada = 3
        Denegada = 4
    End Enum

    Enum EnumEstatsPartes As Integer
        Pendiente = 1
        Aceptado = 2
        Denegado = 3
    End Enum

    Enum EnumTipusUsuari As Integer
        Autoritzador = 1
        Solicitant = 2
    End Enum

    Enum EnumRRHH As Integer
        Si = 1
    End Enum

    Enum EnumIdioma As Integer
        Castella = 1
        Catala = 2
    End Enum

    Enum EnumTiposFicheros As Integer
        Ninguna = 0
        FotoPrincipal = 1
        FotoPrincipalWeb = 2
        FotoQR = 3
        FotosCatalogoWeb = 4
        PDFManual = 5
        PDFSAT = 6
        PDFFicha = 7
        WordFicha = 8
        FotoFicha = 9
    End Enum

    Enum EnumEstadoTrabajador As Integer
        Trabajo = 1
        Vacaciones = 2
        Baja = 3
    End Enum

End Module
