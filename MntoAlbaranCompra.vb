Imports Janus.Windows.GridEX
Imports Solmicro.Expertis.Engine.BE

Public Class MntoAlbaranCompra
    Inherits Solmicro.Expertis.Engine.UI.SimpleMnto

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()
        InitializeComponent()

        mLotes = New ERP.CommonClasses.LoteStockableUserDialog
        mLotes.Text = "ALBARAN DE COMPRA"
        mLotes.ClaseMovimiento = [Shared].ClaseMovimiento.Entrada
        mLotes.DataSource = jngLineaAlbaran
        mLotes.DataSchema.Cantidad = "QInterna"
        mLotes.DataSchema.Cantidad2 = "QInterna2"

        mSeries = New ERP.CommonClasses.NSerieStockableUserDialogIN
        mSeries.Text = "ALBARAN DE COMPRA"
        mSeries.ClaseMovimiento = [Shared].ClaseMovimiento.SoloEntradas
        mSeries.DataSource = jngLineaAlbaran
        mSeries.DataSchema.Cantidad = "QInterna"

        mSeries2 = New ERP.CommonClasses.NSerieStockableUserDialog
        mSeries2.ClaseMovimiento = [Shared].ClaseMovimiento.Salida
        mSeries2.ValorPorDefectoSeleccionEstado = ERP.CommonClasses.NSerie.ESTADO_BAJA
        mSeries2.ModoRecuentoSalidas = [Shared].ModoRecuentoSalidas.Bajas
        mSeries2.UsarColumnaSeleccion = True
        mSeries2.DataSource = jngLineaAlbaran
        mSeries2.DataSchema.Cantidad = "QInterna"
    End Sub

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
    'Puede modificarse utilizando el Diseñador de Windows Forms. 
    'No lo modifique con el editor de código.
    Private WithEvents mLotes As ERP.CommonClasses.LoteStockableUserDialog
    Private mSeries As ERP.CommonClasses.NSerieStockableUserDialogIN
    Private mSeries2 As ERP.CommonClasses.NSerieStockableUserDialog
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents Panel2 As Solmicro.Expertis.Engine.UI.Panel
    Public WithEvents WLFrame4 As Solmicro.Expertis.Engine.UI.Frame
    Public WithEvents fwiDto As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents lblfwiCambioA As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents fwiCambioA As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents lblfwiCambioB As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents fwiCambioB As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents fwiDescMonedaA As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents fwiDescMonedaB As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents lblfwiImporteA As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents fwiImporteA As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents lblfwiImporteB As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents fwiImporteB As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents lblfwiImporte As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents fwiImporte As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents WLFrame3 As Solmicro.Expertis.Engine.UI.Frame
    Public WithEvents ULblCentroCoste As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Public WithEvents AdvCentroCoste As Solmicro.Expertis.Engine.UI.AdvSearch
    Public WithEvents LblCentroCoste As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblfwiIdCondPago As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblcfwiIdCondPago As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Public WithEvents fwiIdCondPago As Solmicro.Expertis.Engine.UI.AdvSearch
    Public WithEvents lblfwiIdFormaPago As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblcfwiIdFormaPago As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Public WithEvents fwiIdFormaPago As Solmicro.Expertis.Engine.UI.AdvSearch
    Public WithEvents lblfwiIdMoneda As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblcfwiIdMoneda As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Public WithEvents fwiIdMoneda As Solmicro.Expertis.Engine.UI.AdvSearch
    Public WithEvents lblfwiFechaEntrega As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents fwiFechaEntrega As Solmicro.Expertis.Engine.UI.CalendarBox
    Public WithEvents lblfwiNAlbaran As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents fwiSuAlbaran As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents Panel3 As Solmicro.Expertis.Engine.UI.Panel
    Public WithEvents FrmResEcon As Solmicro.Expertis.Engine.UI.Frame
    Public WithEvents UiGroupBox1 As Janus.Windows.EditControls.UIGroupBox
    Public WithEvents LineDescuentos As Janus.Windows.EditControls.UIGroupBox
    Public WithEvents LblImpTotal As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents LblPorcenRecFinan As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents LblPorcenDtoAlb As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents LblPorcenProntoPago As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents LblDtoAlb As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents NtbDtoAlbaran As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents LblRecFinan As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents NtbRecFinan As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents LblIVA As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents NtbIVA As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents LblRE As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents NtbRE As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents NtbImporteAlbaran As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents LblImpLineasSeg As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents NtbImpTotalLineasRes As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents LblBaseImponible As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents NtbBaseImponible As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents LblProntoPago As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents NtbDtoProntoPago As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents jngLineaAlbaran As Solmicro.Expertis.Engine.UI.Grid
    Public WithEvents Panel4 As Solmicro.Expertis.Engine.UI.Panel
    Public WithEvents LblImpIva As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents NtbImpIva As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents LblImpLineas As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents NtbImpLineas As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents LblImporteTotal As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents NtbImporteTotal As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents WLFrame1 As Solmicro.Expertis.Engine.UI.Frame
    Public WithEvents WLFrame2 As Solmicro.Expertis.Engine.UI.Frame
    Public WithEvents fwiRazonSocial As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents lblfwiRazonSocial As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents fwiDirProv As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents lblfwiDirProv As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents fwiCodPostal As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents fwiPoblacion As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents fwiProvincia As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents fwiFax As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents lblfwiFax As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents fwiIdProveedor As Solmicro.Expertis.Engine.UI.AdvSearch
    Public WithEvents lblfwiIdProveedor As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblcfwiIdProveedor As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Public WithEvents fwiCIF As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents lblfwiCIF As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents fwiTel As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents lblfwiTel As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblfwiIDAlbaran As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents fwiFechaAlbaran As Solmicro.Expertis.Engine.UI.CalendarBox
    Public WithEvents lblfwiFechaAlbaran As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents FwiNAlbaran As Solmicro.Expertis.Engine.UI.CounterTextBox
    Public WithEvents advIDDireccion As Solmicro.Expertis.Engine.UI.AdvSearch
    Public WithEvents picActualizacionesPendientes As Solmicro.Expertis.Engine.UI.Panel
    Public WithEvents lblRegPendientes As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents PicCabecera As Solmicro.Expertis.Engine.UI.Panel
    Public WithEvents lblIDDireccion As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents TabAlbaranes As Solmicro.Expertis.Engine.UI.Tab
    Public WithEvents TabPagePicLineas As Janus.Windows.UI.Tab.UITabPage
    Public WithEvents lblDescMonedaA As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents TabPagePicCentroRecepcion As Janus.Windows.UI.Tab.UITabPage
    Public WithEvents lblfwiTelefonoCG As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents fwiTelefonoCG As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents lblfwiCorreoCG As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents fwiCorreoCG As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents lblfwiFaxCG As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents fwiFaxCG As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents lblfwiCodPostalCG As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents fwiCodPostalCG As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents lblfwiPoblacionCG As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents fwiPoblacionCG As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents lblfwiProvinciaCG As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents fwiProvinciaCG As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents lblfwiDirCentroGestion As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents fwiDirCentroGestion As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents lblFwiIdAlmacen As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblcFwiIdAlmacen As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Public WithEvents FwiIdAlmacen As Solmicro.Expertis.Engine.UI.AdvSearch
    Public WithEvents TabPagePicDatosEconomicos As Janus.Windows.UI.Tab.UITabPage
    Public WithEvents TabPagePicAnotaciones As Janus.Windows.UI.Tab.UITabPage
    Public WithEvents WLFrame8 As Solmicro.Expertis.Engine.UI.Frame
    Public WithEvents fwiTextoAlbaran As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents TabPagePicSeguimiento As Janus.Windows.UI.Tab.UITabPage
    Public WithEvents WLFactGeneradas As Solmicro.Expertis.Engine.UI.Frame
    Public WithEvents lstFacturasGeneradas As System.Windows.Forms.ListBox
    Public WithEvents WLFrame9 As Solmicro.Expertis.Engine.UI.Frame
    Public WithEvents lblfwiEstado As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents fwiEstado As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents pnlLineas As Solmicro.Expertis.Engine.UI.Panel
    Public WithEvents lblfwiIdCentroGestion As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblcfwiIdCentroGestion As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Friend WithEvents UiTabEnvio As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents FraPE As Solmicro.Expertis.Engine.UI.Frame
    Public WithEvents TxtNumBultos As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents LblNumBultos As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents LblPesoNetoManual As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents NtbPesoNetoManual As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents LblPesoNeto As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents NtbPesoNeto As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents LblPesoManual As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents NtbPesoBrutoManual As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents LblPesoBruto As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents NtbPesoBruto As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents WLFrame7 As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents txtRemolque As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents txtEmpresa As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents lblRemolque As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents Label7 As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtMatricula As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents lblMatricula As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtCifTransp As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents txtDniConductor As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents Label6 As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblDniConductor As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblFwiModoTransporte As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtConductor As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents lblcFwiModoTransporte As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Friend WithEvents lblConductor As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents FwiModoTransporte As Solmicro.Expertis.Engine.UI.AdvSearch
    Public WithEvents lblfwiIdCondEnvio As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblcfwiIdCondEnvio As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Public WithEvents fwiIdCondEnvio As Solmicro.Expertis.Engine.UI.AdvSearch
    Public WithEvents lblfwiIDFormaEnvio As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblcfwiIDFormaEnvio As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Public WithEvents fwiIDFormaEnvio As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents cmbDetalles As Solmicro.Expertis.Engine.UI.ComboBox
    Friend WithEvents FrmDAA As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents LblDAA As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents TxtARC As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents TxtDAA As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents LblARC As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents fwiIdCentroGestion As Solmicro.Expertis.Engine.UI.AdvSearch
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim jngLineaAlbaran_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim jngLineaAlbaran_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column8.ButtonImage")
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MntoAlbaranCompra))
        Dim jngLineaAlbaran_DesignTimeLayout_Reference_1 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column10.ButtonImage")
        Dim jngLineaAlbaran_DesignTimeLayout_Reference_2 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column11.ButtonImage")
        Dim jngLineaAlbaran_DesignTimeLayout_Reference_3 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column14.ButtonImage")
        Dim jngLineaAlbaran_DesignTimeLayout_Reference_4 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column27.ButtonImage")
        Dim jngLineaAlbaran_DesignTimeLayout_Reference_5 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column29.ButtonImage")
        Dim jngLineaAlbaran_DesignTimeLayout_Reference_6 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column30.ButtonImage")
        Dim jngLineaAlbaran_DesignTimeLayout_Reference_7 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column36.ButtonImage")
        Dim jngLineaAlbaran_DesignTimeLayout_Reference_8 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column37.ButtonImage")
        Dim jngLineaAlbaran_DesignTimeLayout_Reference_9 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column38.ButtonImage")
        Dim jngLineaAlbaran_DesignTimeLayout_Reference_10 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column41.ButtonImage")
        Dim jngLineaAlbaran_DesignTimeLayout_Reference_11 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column49.ButtonImage")
        Dim jngLineaAlbaran_DesignTimeLayout_Reference_12 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column55.ButtonImage")
        Dim jngLineaAlbaran_DesignTimeLayout_Reference_13 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column59.ButtonImage")
        Dim jngLineaAlbaran_DesignTimeLayout_Reference_14 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column60.ButtonImage")
        Dim jngLineaAlbaran_DesignTimeLayout_Reference_15 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.ImageList.ImageStream")
        Dim cmbDetalles_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.picActualizacionesPendientes = New Solmicro.Expertis.Engine.UI.Panel
        Me.lblRegPendientes = New Solmicro.Expertis.Engine.UI.Label
        Me.PicCabecera = New Solmicro.Expertis.Engine.UI.Panel
        Me.WLFrame2 = New Solmicro.Expertis.Engine.UI.Frame
        Me.fwiFechaEntrega = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lblfwiFechaEntrega = New Solmicro.Expertis.Engine.UI.Label
        Me.FwiNAlbaran = New Solmicro.Expertis.Engine.UI.CounterTextBox
        Me.WLFrame1 = New Solmicro.Expertis.Engine.UI.Frame
        Me.lblfwiNAlbaran = New Solmicro.Expertis.Engine.UI.Label
        Me.fwiSuAlbaran = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblfwiRazonSocial = New Solmicro.Expertis.Engine.UI.Label
        Me.fwiRazonSocial = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblfwiDirProv = New Solmicro.Expertis.Engine.UI.Label
        Me.fwiDirProv = New Solmicro.Expertis.Engine.UI.TextBox
        Me.fwiCodPostal = New Solmicro.Expertis.Engine.UI.TextBox
        Me.fwiPoblacion = New Solmicro.Expertis.Engine.UI.TextBox
        Me.fwiProvincia = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblfwiFax = New Solmicro.Expertis.Engine.UI.Label
        Me.fwiFax = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblfwiIdProveedor = New Solmicro.Expertis.Engine.UI.Label
        Me.lblcfwiIdProveedor = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.fwiIdProveedor = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblfwiCIF = New Solmicro.Expertis.Engine.UI.Label
        Me.fwiCIF = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblfwiTel = New Solmicro.Expertis.Engine.UI.Label
        Me.fwiTel = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblfwiIDAlbaran = New Solmicro.Expertis.Engine.UI.Label
        Me.lblfwiFechaAlbaran = New Solmicro.Expertis.Engine.UI.Label
        Me.fwiFechaAlbaran = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lblIDDireccion = New Solmicro.Expertis.Engine.UI.Label
        Me.advIDDireccion = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.pnlLineas = New Solmicro.Expertis.Engine.UI.Panel
        Me.TabAlbaranes = New Solmicro.Expertis.Engine.UI.Tab
        Me.TabPagePicLineas = New Janus.Windows.UI.Tab.UITabPage
        Me.jngLineaAlbaran = New Solmicro.Expertis.Engine.UI.Grid
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Panel4 = New Solmicro.Expertis.Engine.UI.Panel
        Me.LblImpIva = New Solmicro.Expertis.Engine.UI.Label
        Me.NtbImpIva = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.LblImpLineas = New Solmicro.Expertis.Engine.UI.Label
        Me.NtbImpLineas = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.LblImporteTotal = New Solmicro.Expertis.Engine.UI.Label
        Me.NtbImporteTotal = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblDescMonedaA = New Solmicro.Expertis.Engine.UI.Label
        Me.TabPagePicCentroRecepcion = New Janus.Windows.UI.Tab.UITabPage
        Me.lblfwiIdCentroGestion = New Solmicro.Expertis.Engine.UI.Label
        Me.lblcfwiIdCentroGestion = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.fwiIdCentroGestion = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblfwiTelefonoCG = New Solmicro.Expertis.Engine.UI.Label
        Me.fwiTelefonoCG = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblfwiCorreoCG = New Solmicro.Expertis.Engine.UI.Label
        Me.fwiCorreoCG = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblfwiFaxCG = New Solmicro.Expertis.Engine.UI.Label
        Me.fwiFaxCG = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblfwiCodPostalCG = New Solmicro.Expertis.Engine.UI.Label
        Me.fwiCodPostalCG = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblfwiPoblacionCG = New Solmicro.Expertis.Engine.UI.Label
        Me.fwiPoblacionCG = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblfwiProvinciaCG = New Solmicro.Expertis.Engine.UI.Label
        Me.fwiProvinciaCG = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblfwiDirCentroGestion = New Solmicro.Expertis.Engine.UI.Label
        Me.fwiDirCentroGestion = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblFwiIdAlmacen = New Solmicro.Expertis.Engine.UI.Label
        Me.lblcFwiIdAlmacen = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.FwiIdAlmacen = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.TabPagePicDatosEconomicos = New Janus.Windows.UI.Tab.UITabPage
        Me.Panel3 = New Solmicro.Expertis.Engine.UI.Panel
        Me.FrmResEcon = New Solmicro.Expertis.Engine.UI.Frame
        Me.UiGroupBox1 = New Janus.Windows.EditControls.UIGroupBox
        Me.LineDescuentos = New Janus.Windows.EditControls.UIGroupBox
        Me.LblImpTotal = New Solmicro.Expertis.Engine.UI.Label
        Me.LblPorcenRecFinan = New Solmicro.Expertis.Engine.UI.Label
        Me.LblPorcenDtoAlb = New Solmicro.Expertis.Engine.UI.Label
        Me.LblPorcenProntoPago = New Solmicro.Expertis.Engine.UI.Label
        Me.LblDtoAlb = New Solmicro.Expertis.Engine.UI.Label
        Me.NtbDtoAlbaran = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.LblRecFinan = New Solmicro.Expertis.Engine.UI.Label
        Me.NtbRecFinan = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.LblIVA = New Solmicro.Expertis.Engine.UI.Label
        Me.NtbIVA = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.LblRE = New Solmicro.Expertis.Engine.UI.Label
        Me.NtbRE = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.NtbImporteAlbaran = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.LblImpLineasSeg = New Solmicro.Expertis.Engine.UI.Label
        Me.NtbImpTotalLineasRes = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.LblBaseImponible = New Solmicro.Expertis.Engine.UI.Label
        Me.NtbBaseImponible = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.LblProntoPago = New Solmicro.Expertis.Engine.UI.Label
        Me.NtbDtoProntoPago = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.Panel2 = New Solmicro.Expertis.Engine.UI.Panel
        Me.WLFrame4 = New Solmicro.Expertis.Engine.UI.Frame
        Me.fwiDto = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblfwiCambioA = New Solmicro.Expertis.Engine.UI.Label
        Me.fwiCambioA = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblfwiCambioB = New Solmicro.Expertis.Engine.UI.Label
        Me.fwiCambioB = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.fwiDescMonedaA = New Solmicro.Expertis.Engine.UI.TextBox
        Me.fwiDescMonedaB = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblfwiImporteA = New Solmicro.Expertis.Engine.UI.Label
        Me.fwiImporteA = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblfwiImporteB = New Solmicro.Expertis.Engine.UI.Label
        Me.fwiImporteB = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblfwiImporte = New Solmicro.Expertis.Engine.UI.Label
        Me.fwiImporte = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.WLFrame3 = New Solmicro.Expertis.Engine.UI.Frame
        Me.ULblCentroCoste = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.AdvCentroCoste = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.LblCentroCoste = New Solmicro.Expertis.Engine.UI.Label
        Me.lblfwiIdCondPago = New Solmicro.Expertis.Engine.UI.Label
        Me.lblcfwiIdCondPago = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.fwiIdCondPago = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblfwiIdFormaPago = New Solmicro.Expertis.Engine.UI.Label
        Me.lblcfwiIdFormaPago = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.fwiIdFormaPago = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblfwiIdMoneda = New Solmicro.Expertis.Engine.UI.Label
        Me.lblcfwiIdMoneda = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.fwiIdMoneda = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.UiTabEnvio = New Janus.Windows.UI.Tab.UITabPage
        Me.FrmDAA = New Solmicro.Expertis.Engine.UI.Frame
        Me.TxtARC = New Solmicro.Expertis.Engine.UI.TextBox
        Me.TxtDAA = New Solmicro.Expertis.Engine.UI.TextBox
        Me.LblARC = New Solmicro.Expertis.Engine.UI.Label
        Me.LblDAA = New Solmicro.Expertis.Engine.UI.Label
        Me.FraPE = New Solmicro.Expertis.Engine.UI.Frame
        Me.TxtNumBultos = New Solmicro.Expertis.Engine.UI.TextBox
        Me.LblPesoNetoManual = New Solmicro.Expertis.Engine.UI.Label
        Me.LblNumBultos = New Solmicro.Expertis.Engine.UI.Label
        Me.NtbPesoNetoManual = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.LblPesoManual = New Solmicro.Expertis.Engine.UI.Label
        Me.NtbPesoBrutoManual = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.LblPesoBruto = New Solmicro.Expertis.Engine.UI.Label
        Me.LblPesoNeto = New Solmicro.Expertis.Engine.UI.Label
        Me.NtbPesoBruto = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.NtbPesoNeto = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.WLFrame7 = New Solmicro.Expertis.Engine.UI.Frame
        Me.txtRemolque = New Solmicro.Expertis.Engine.UI.TextBox
        Me.txtEmpresa = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblRemolque = New Solmicro.Expertis.Engine.UI.Label
        Me.Label7 = New Solmicro.Expertis.Engine.UI.Label
        Me.txtMatricula = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblMatricula = New Solmicro.Expertis.Engine.UI.Label
        Me.txtCifTransp = New Solmicro.Expertis.Engine.UI.TextBox
        Me.txtDniConductor = New Solmicro.Expertis.Engine.UI.TextBox
        Me.Label6 = New Solmicro.Expertis.Engine.UI.Label
        Me.lblDniConductor = New Solmicro.Expertis.Engine.UI.Label
        Me.lblFwiModoTransporte = New Solmicro.Expertis.Engine.UI.Label
        Me.txtConductor = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblcFwiModoTransporte = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.lblConductor = New Solmicro.Expertis.Engine.UI.Label
        Me.FwiModoTransporte = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblfwiIdCondEnvio = New Solmicro.Expertis.Engine.UI.Label
        Me.lblcfwiIdCondEnvio = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.fwiIdCondEnvio = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblfwiIDFormaEnvio = New Solmicro.Expertis.Engine.UI.Label
        Me.lblcfwiIDFormaEnvio = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.fwiIDFormaEnvio = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.cmbDetalles = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.TabPagePicAnotaciones = New Janus.Windows.UI.Tab.UITabPage
        Me.WLFrame8 = New Solmicro.Expertis.Engine.UI.Frame
        Me.fwiTextoAlbaran = New Solmicro.Expertis.Engine.UI.TextBox
        Me.TabPagePicSeguimiento = New Janus.Windows.UI.Tab.UITabPage
        Me.WLFactGeneradas = New Solmicro.Expertis.Engine.UI.Frame
        Me.lstFacturasGeneradas = New System.Windows.Forms.ListBox
        Me.WLFrame9 = New Solmicro.Expertis.Engine.UI.Frame
        Me.lblfwiEstado = New Solmicro.Expertis.Engine.UI.Label
        Me.fwiEstado = New Solmicro.Expertis.Engine.UI.TextBox
        CType(Me.ToolBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MenuBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainPanel.suspendlayout()
        Me.picActualizacionesPendientes.suspendlayout()
        Me.PicCabecera.suspendlayout()
        Me.pnlLineas.suspendlayout()
        CType(Me.TabAlbaranes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabAlbaranes.SuspendLayout()
        Me.TabPagePicLineas.SuspendLayout()
        CType(Me.jngLineaAlbaran, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.suspendlayout()
        Me.TabPagePicCentroRecepcion.SuspendLayout()
        Me.TabPagePicDatosEconomicos.SuspendLayout()
        Me.Panel3.suspendlayout()
        Me.FrmResEcon.SuspendLayout()
        CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LineDescuentos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.suspendlayout()
        Me.WLFrame4.SuspendLayout()
        Me.WLFrame3.SuspendLayout()
        Me.UiTabEnvio.SuspendLayout()
        Me.FrmDAA.SuspendLayout()
        Me.FraPE.SuspendLayout()
        Me.WLFrame7.SuspendLayout()
        CType(Me.cmbDetalles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPagePicAnotaciones.SuspendLayout()
        Me.WLFrame8.SuspendLayout()
        Me.TabPagePicSeguimiento.SuspendLayout()
        Me.WLFactGeneradas.SuspendLayout()
        Me.WLFrame9.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolBar
        '
        Me.ToolBar.Size = New System.Drawing.Size(721, 39)
        '
        'MenuBar
        '
        Me.MenuBar.Location = New System.Drawing.Point(0, 39)
        Me.MenuBar.Size = New System.Drawing.Size(504, 26)
        '
        'Delete
        '
        Me.Delete.Enabled = Janus.Windows.UI.InheritableBoolean.[False]
        '
        'NewRow
        '
        Me.NewRow.Enabled = Janus.Windows.UI.InheritableBoolean.[False]
        '
        'MainPanel
        '
        Me.MainPanel.Controls.Add(Me.pnlLineas)
        Me.MainPanel.Controls.Add(Me.picActualizacionesPendientes)
        Me.MainPanel.Controls.Add(Me.PicCabecera)
        Me.MainPanel.Controls.Add(Me.lblIDDireccion)
        Me.MainPanel.Controls.Add(Me.advIDDireccion)
        Me.MainPanel.Size = New System.Drawing.Size(786, 497)
        '
        'picActualizacionesPendientes
        '
        Me.picActualizacionesPendientes.Controls.Add(Me.lblRegPendientes)
        Me.picActualizacionesPendientes.Location = New System.Drawing.Point(0, 243)
        Me.picActualizacionesPendientes.Name = "picActualizacionesPendientes"
        Me.picActualizacionesPendientes.Size = New System.Drawing.Size(673, 24)
        Me.picActualizacionesPendientes.TabIndex = 1
        '
        'lblRegPendientes
        '
        Me.lblRegPendientes.Location = New System.Drawing.Point(27, 3)
        Me.lblRegPendientes.Name = "lblRegPendientes"
        Me.lblRegPendientes.Size = New System.Drawing.Size(0, 13)
        Me.lblRegPendientes.TabIndex = 0
        Me.lblRegPendientes.Tag = "IdRec=0;"
        '
        'PicCabecera
        '
        Me.PicCabecera.Controls.Add(Me.WLFrame2)
        Me.PicCabecera.Controls.Add(Me.fwiFechaEntrega)
        Me.PicCabecera.Controls.Add(Me.lblfwiFechaEntrega)
        Me.PicCabecera.Controls.Add(Me.FwiNAlbaran)
        Me.PicCabecera.Controls.Add(Me.WLFrame1)
        Me.PicCabecera.Controls.Add(Me.lblfwiNAlbaran)
        Me.PicCabecera.Controls.Add(Me.fwiSuAlbaran)
        Me.PicCabecera.Controls.Add(Me.lblfwiRazonSocial)
        Me.PicCabecera.Controls.Add(Me.fwiRazonSocial)
        Me.PicCabecera.Controls.Add(Me.lblfwiDirProv)
        Me.PicCabecera.Controls.Add(Me.fwiDirProv)
        Me.PicCabecera.Controls.Add(Me.fwiCodPostal)
        Me.PicCabecera.Controls.Add(Me.fwiPoblacion)
        Me.PicCabecera.Controls.Add(Me.fwiProvincia)
        Me.PicCabecera.Controls.Add(Me.lblfwiFax)
        Me.PicCabecera.Controls.Add(Me.fwiFax)
        Me.PicCabecera.Controls.Add(Me.lblfwiIdProveedor)
        Me.PicCabecera.Controls.Add(Me.lblcfwiIdProveedor)
        Me.PicCabecera.Controls.Add(Me.fwiIdProveedor)
        Me.PicCabecera.Controls.Add(Me.lblfwiCIF)
        Me.PicCabecera.Controls.Add(Me.fwiCIF)
        Me.PicCabecera.Controls.Add(Me.lblfwiTel)
        Me.PicCabecera.Controls.Add(Me.fwiTel)
        Me.PicCabecera.Controls.Add(Me.lblfwiIDAlbaran)
        Me.PicCabecera.Controls.Add(Me.lblfwiFechaAlbaran)
        Me.PicCabecera.Controls.Add(Me.fwiFechaAlbaran)
        Me.PicCabecera.Dock = System.Windows.Forms.DockStyle.Top
        Me.PicCabecera.Location = New System.Drawing.Point(0, 0)
        Me.PicCabecera.Name = "PicCabecera"
        Me.PicCabecera.Size = New System.Drawing.Size(786, 174)
        Me.PicCabecera.TabIndex = 2
        '
        'WLFrame2
        '
        Me.WLFrame2.Location = New System.Drawing.Point(1, 164)
        Me.WLFrame2.Name = "WLFrame2"
        Me.WLFrame2.Size = New System.Drawing.Size(790, 3)
        Me.WLFrame2.TabIndex = 57
        Me.WLFrame2.TabStop = False
        Me.WLFrame2.Tag = "IdRec=0;"
        '
        'fwiFechaEntrega
        '
        Me.TryDataBinding(fwiFechaEntrega, New System.Windows.Forms.Binding("Text", Me, "SuFecha", True))
        Me.fwiFechaEntrega.DisabledBackColor = System.Drawing.Color.White
        Me.fwiFechaEntrega.Location = New System.Drawing.Point(9, 139)
        Me.fwiFechaEntrega.Name = "fwiFechaEntrega"
        Me.fwiFechaEntrega.Size = New System.Drawing.Size(101, 21)
        Me.fwiFechaEntrega.TabIndex = 3
        '
        'lblfwiFechaEntrega
        '
        Me.lblfwiFechaEntrega.Location = New System.Drawing.Point(7, 124)
        Me.lblfwiFechaEntrega.Name = "lblfwiFechaEntrega"
        Me.lblfwiFechaEntrega.Size = New System.Drawing.Size(107, 13)
        Me.lblfwiFechaEntrega.TabIndex = 0
        Me.lblfwiFechaEntrega.Tag = "IdRec=4406;"
        Me.lblfwiFechaEntrega.Text = "Su Fecha Albarán"
        '
        'FwiNAlbaran
        '
        Me.TryDataBinding(FwiNAlbaran, New System.Windows.Forms.Binding("Text", Me, "NAlbaran", True))
        Me.FwiNAlbaran.DisabledBackColor = System.Drawing.Color.White
        Me.FwiNAlbaran.Location = New System.Drawing.Point(8, 20)
        Me.FwiNAlbaran.Name = "FwiNAlbaran"
        Me.FwiNAlbaran.ReadOnly = True
        Me.FwiNAlbaran.Size = New System.Drawing.Size(102, 23)
        Me.FwiNAlbaran.TabIndex = 0
        '
        'WLFrame1
        '
        Me.WLFrame1.Location = New System.Drawing.Point(116, -3)
        Me.WLFrame1.Name = "WLFrame1"
        Me.WLFrame1.Size = New System.Drawing.Size(2, 171)
        Me.WLFrame1.TabIndex = 58
        Me.WLFrame1.TabStop = False
        Me.WLFrame1.Tag = "IdRec=0;"
        '
        'lblfwiNAlbaran
        '
        Me.lblfwiNAlbaran.Location = New System.Drawing.Point(7, 86)
        Me.lblfwiNAlbaran.Name = "lblfwiNAlbaran"
        Me.lblfwiNAlbaran.Size = New System.Drawing.Size(88, 13)
        Me.lblfwiNAlbaran.TabIndex = 14
        Me.lblfwiNAlbaran.Tag = "IdRec=4407;"
        Me.lblfwiNAlbaran.Text = "Su Nº Albarán"
        '
        'fwiSuAlbaran
        '
        Me.TryDataBinding(fwiSuAlbaran, New System.Windows.Forms.Binding("Text", Me, "SuAlbaran", True))
        Me.fwiSuAlbaran.DisabledBackColor = System.Drawing.Color.White
        Me.fwiSuAlbaran.Location = New System.Drawing.Point(9, 102)
        Me.fwiSuAlbaran.Name = "fwiSuAlbaran"
        Me.fwiSuAlbaran.Size = New System.Drawing.Size(101, 21)
        Me.fwiSuAlbaran.TabIndex = 2
        '
        'lblfwiRazonSocial
        '
        Me.lblfwiRazonSocial.Location = New System.Drawing.Point(288, 35)
        Me.lblfwiRazonSocial.Name = "lblfwiRazonSocial"
        Me.lblfwiRazonSocial.Size = New System.Drawing.Size(80, 13)
        Me.lblfwiRazonSocial.TabIndex = 62
        Me.lblfwiRazonSocial.Tag = "IdRec=4426;"
        Me.lblfwiRazonSocial.Text = "Razón Social"
        '
        'fwiRazonSocial
        '
        Me.TryDataBinding(fwiRazonSocial, New System.Windows.Forms.Binding("Text", Me.advIDDireccion, "RazonSocial", True))
        Me.fwiRazonSocial.DisabledBackColor = System.Drawing.Color.White
        Me.fwiRazonSocial.Enabled = False
        Me.fwiRazonSocial.Location = New System.Drawing.Point(371, 35)
        Me.fwiRazonSocial.Name = "fwiRazonSocial"
        Me.fwiRazonSocial.Size = New System.Drawing.Size(406, 21)
        Me.fwiRazonSocial.TabIndex = 6
        '
        'lblfwiDirProv
        '
        Me.lblfwiDirProv.Location = New System.Drawing.Point(123, 61)
        Me.lblfwiDirProv.Name = "lblfwiDirProv"
        Me.lblfwiDirProv.Size = New System.Drawing.Size(60, 13)
        Me.lblfwiDirProv.TabIndex = 63
        Me.lblfwiDirProv.Tag = "IdRec=4410;"
        Me.lblfwiDirProv.Text = "Dirección"
        '
        'fwiDirProv
        '
        Me.TryDataBinding(fwiDirProv, New System.Windows.Forms.Binding("Text", Me.advIDDireccion, "Direccion", True))
        Me.fwiDirProv.DisabledBackColor = System.Drawing.Color.White
        Me.fwiDirProv.Enabled = False
        Me.fwiDirProv.Location = New System.Drawing.Point(191, 61)
        Me.fwiDirProv.Name = "fwiDirProv"
        Me.fwiDirProv.Size = New System.Drawing.Size(586, 21)
        Me.fwiDirProv.TabIndex = 7
        '
        'fwiCodPostal
        '
        Me.TryDataBinding(fwiCodPostal, New System.Windows.Forms.Binding("Text", Me.advIDDireccion, "CodPostal", True))
        Me.fwiCodPostal.DisabledBackColor = System.Drawing.Color.White
        Me.fwiCodPostal.Enabled = False
        Me.fwiCodPostal.Location = New System.Drawing.Point(191, 87)
        Me.fwiCodPostal.Name = "fwiCodPostal"
        Me.fwiCodPostal.Size = New System.Drawing.Size(116, 21)
        Me.fwiCodPostal.TabIndex = 8
        '
        'fwiPoblacion
        '
        Me.TryDataBinding(fwiPoblacion, New System.Windows.Forms.Binding("Text", Me.advIDDireccion, "Poblacion", True))
        Me.fwiPoblacion.DisabledBackColor = System.Drawing.Color.White
        Me.fwiPoblacion.Enabled = False
        Me.fwiPoblacion.Location = New System.Drawing.Point(312, 87)
        Me.fwiPoblacion.Name = "fwiPoblacion"
        Me.fwiPoblacion.Size = New System.Drawing.Size(236, 21)
        Me.fwiPoblacion.TabIndex = 9
        '
        'fwiProvincia
        '
        Me.TryDataBinding(fwiProvincia, New System.Windows.Forms.Binding("Text", Me.advIDDireccion, "Provincia", True))
        Me.fwiProvincia.DisabledBackColor = System.Drawing.Color.White
        Me.fwiProvincia.Enabled = False
        Me.fwiProvincia.Location = New System.Drawing.Point(551, 87)
        Me.fwiProvincia.Name = "fwiProvincia"
        Me.fwiProvincia.Size = New System.Drawing.Size(226, 21)
        Me.fwiProvincia.TabIndex = 10
        '
        'lblfwiFax
        '
        Me.lblfwiFax.Location = New System.Drawing.Point(125, 143)
        Me.lblfwiFax.Name = "lblfwiFax"
        Me.lblfwiFax.Size = New System.Drawing.Size(26, 13)
        Me.lblfwiFax.TabIndex = 64
        Me.lblfwiFax.Tag = "IdRec=4415;"
        Me.lblfwiFax.Text = "Fax"
        '
        'fwiFax
        '
        Me.TryDataBinding(fwiFax, New System.Windows.Forms.Binding("Text", Me.advIDDireccion, "Fax", True))
        Me.fwiFax.DisabledBackColor = System.Drawing.Color.White
        Me.fwiFax.Enabled = False
        Me.fwiFax.Location = New System.Drawing.Point(191, 139)
        Me.fwiFax.Name = "fwiFax"
        Me.fwiFax.Size = New System.Drawing.Size(116, 21)
        Me.fwiFax.TabIndex = 12
        '
        'lblfwiIdProveedor
        '
        Me.lblfwiIdProveedor.Location = New System.Drawing.Point(123, 9)
        Me.lblfwiIdProveedor.Name = "lblfwiIdProveedor"
        Me.lblfwiIdProveedor.Size = New System.Drawing.Size(66, 13)
        Me.lblfwiIdProveedor.TabIndex = 65
        Me.lblfwiIdProveedor.Tag = "IdRec=4352;"
        Me.lblfwiIdProveedor.Text = "Proveedor"
        '
        'lblcfwiIdProveedor
        '
        Me.TryDataBinding(lblcfwiIdProveedor, New System.Windows.Forms.Binding("Text", Me.fwiIdProveedor, "DescProveedor", True))
        Me.lblcfwiIdProveedor.Location = New System.Drawing.Point(309, 10)
        Me.lblcfwiIdProveedor.Name = "lblcfwiIdProveedor"
        Me.lblcfwiIdProveedor.Size = New System.Drawing.Size(468, 21)
        Me.lblcfwiIdProveedor.TabIndex = 66
        '
        'fwiIdProveedor
        '
        Me.TryDataBinding(fwiIdProveedor, New System.Windows.Forms.Binding("Text", Me, "IDProveedor", True))
        Me.fwiIdProveedor.DisabledBackColor = System.Drawing.Color.White
        Me.fwiIdProveedor.EntityName = "Proveedor"
        Me.fwiIdProveedor.Location = New System.Drawing.Point(191, 9)
        Me.fwiIdProveedor.Name = "fwiIdProveedor"
        Me.fwiIdProveedor.PrimaryDataFields = "IDProveedor"
        Me.fwiIdProveedor.SecondaryDataFields = "IDProveedor"
        Me.fwiIdProveedor.Size = New System.Drawing.Size(116, 23)
        Me.fwiIdProveedor.TabIndex = 4
        Me.fwiIdProveedor.ViewName = "tbMaestroProveedor"
        '
        'lblfwiCIF
        '
        Me.lblfwiCIF.Location = New System.Drawing.Point(123, 36)
        Me.lblfwiCIF.Name = "lblfwiCIF"
        Me.lblfwiCIF.Size = New System.Drawing.Size(37, 13)
        Me.lblfwiCIF.TabIndex = 67
        Me.lblfwiCIF.Tag = ""
        Me.lblfwiCIF.Text = "C.I.F."
        '
        'fwiCIF
        '
        Me.TryDataBinding(fwiCIF, New System.Windows.Forms.Binding("Text", Me.fwiIdProveedor, "CifProveedor", True))
        Me.fwiCIF.DisabledBackColor = System.Drawing.Color.White
        Me.fwiCIF.Enabled = False
        Me.fwiCIF.Location = New System.Drawing.Point(191, 36)
        Me.fwiCIF.Name = "fwiCIF"
        Me.fwiCIF.Size = New System.Drawing.Size(92, 21)
        Me.fwiCIF.TabIndex = 5
        '
        'lblfwiTel
        '
        Me.lblfwiTel.Location = New System.Drawing.Point(123, 111)
        Me.lblfwiTel.Name = "lblfwiTel"
        Me.lblfwiTel.Size = New System.Drawing.Size(55, 13)
        Me.lblfwiTel.TabIndex = 68
        Me.lblfwiTel.Tag = "IdRec=4411;"
        Me.lblfwiTel.Text = "Teléfono"
        '
        'fwiTel
        '
        Me.TryDataBinding(fwiTel, New System.Windows.Forms.Binding("Text", Me.advIDDireccion, "Telefono", True))
        Me.fwiTel.DisabledBackColor = System.Drawing.Color.White
        Me.fwiTel.Enabled = False
        Me.fwiTel.Location = New System.Drawing.Point(191, 112)
        Me.fwiTel.Name = "fwiTel"
        Me.fwiTel.Size = New System.Drawing.Size(116, 21)
        Me.fwiTel.TabIndex = 11
        '
        'lblfwiIDAlbaran
        '
        Me.lblfwiIDAlbaran.Location = New System.Drawing.Point(8, 5)
        Me.lblfwiIDAlbaran.Name = "lblfwiIDAlbaran"
        Me.lblfwiIDAlbaran.Size = New System.Drawing.Size(51, 13)
        Me.lblfwiIDAlbaran.TabIndex = 69
        Me.lblfwiIDAlbaran.Tag = "IdRec=4424;"
        Me.lblfwiIDAlbaran.Text = "Albarán"
        '
        'lblfwiFechaAlbaran
        '
        Me.lblfwiFechaAlbaran.Location = New System.Drawing.Point(6, 47)
        Me.lblfwiFechaAlbaran.Name = "lblfwiFechaAlbaran"
        Me.lblfwiFechaAlbaran.Size = New System.Drawing.Size(88, 13)
        Me.lblfwiFechaAlbaran.TabIndex = 70
        Me.lblfwiFechaAlbaran.Tag = "IdRec=4423;"
        Me.lblfwiFechaAlbaran.Text = "Fecha Albarán"
        '
        'fwiFechaAlbaran
        '
        Me.TryDataBinding(fwiFechaAlbaran, New System.Windows.Forms.Binding("BindableValue", Me, "FechaAlbaran", True))
        Me.fwiFechaAlbaran.DisabledBackColor = System.Drawing.Color.White
        Me.fwiFechaAlbaran.Location = New System.Drawing.Point(8, 62)
        Me.fwiFechaAlbaran.Name = "fwiFechaAlbaran"
        Me.fwiFechaAlbaran.Size = New System.Drawing.Size(102, 21)
        Me.fwiFechaAlbaran.TabIndex = 1
        '
        'lblIDDireccion
        '
        Me.lblIDDireccion.Location = New System.Drawing.Point(570, 87)
        Me.lblIDDireccion.Name = "lblIDDireccion"
        Me.lblIDDireccion.Size = New System.Drawing.Size(74, 13)
        Me.lblIDDireccion.TabIndex = 3
        Me.lblIDDireccion.Text = "IDDireccion"
        '
        'advIDDireccion
        '
        Me.TryDataBinding(advIDDireccion, New System.Windows.Forms.Binding("Text", Me, "IDDireccion", True))
        Me.advIDDireccion.DisabledBackColor = System.Drawing.Color.White
        Me.advIDDireccion.EntityName = "ProveedorDireccion"
        Me.advIDDireccion.Location = New System.Drawing.Point(640, 87)
        Me.advIDDireccion.Name = "advIDDireccion"
        Me.advIDDireccion.PrimaryDataFields = "IDDireccion"
        Me.advIDDireccion.SecondaryDataFields = "IDDireccion"
        Me.advIDDireccion.Size = New System.Drawing.Size(121, 23)
        Me.advIDDireccion.TabIndex = 4
        '
        'pnlLineas
        '
        Me.pnlLineas.Controls.Add(Me.TabAlbaranes)
        Me.pnlLineas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlLineas.Location = New System.Drawing.Point(0, 174)
        Me.pnlLineas.Name = "pnlLineas"
        Me.pnlLineas.Size = New System.Drawing.Size(786, 323)
        Me.pnlLineas.TabIndex = 5
        '
        'TabAlbaranes
        '
        Me.TabAlbaranes.BackColor = System.Drawing.Color.White
        Me.TabAlbaranes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabAlbaranes.Location = New System.Drawing.Point(0, 0)
        Me.TabAlbaranes.Name = "TabAlbaranes"
        Me.TabAlbaranes.Size = New System.Drawing.Size(786, 323)
        Me.TabAlbaranes.TabIndex = 3
        Me.TabAlbaranes.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.TabPagePicLineas, Me.TabPagePicCentroRecepcion, Me.TabPagePicDatosEconomicos, Me.UiTabEnvio, Me.TabPagePicAnotaciones, Me.TabPagePicSeguimiento})
        Me.TabAlbaranes.Text = "Seguimiento"
        Me.TabAlbaranes.UseThemes = True
        '
        'TabPagePicLineas
        '
        Me.TabPagePicLineas.Controls.Add(Me.jngLineaAlbaran)
        Me.TabPagePicLineas.Controls.Add(Me.Panel4)
        Me.TabPagePicLineas.Controls.Add(Me.lblDescMonedaA)
        Me.TabPagePicLineas.Key = "Lineas"
        Me.TabPagePicLineas.Location = New System.Drawing.Point(1, 21)
        Me.TabPagePicLineas.Name = "TabPagePicLineas"
        Me.TabPagePicLineas.Size = New System.Drawing.Size(784, 301)
        Me.TabPagePicLineas.TabStop = True
        Me.TabPagePicLineas.Text = "Líneas"
        '
        'jngLineaAlbaran
        '
        Me.jngLineaAlbaran.AdvSearchColumns = New Solmicro.Expertis.Engine.UI.AdvSearchColumns(New Solmicro.Expertis.Engine.UI.AdvSearchColumn() {New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDArticulo", "Articulo", "IDArticulo", New Solmicro.Expertis.Engine.UI.ASSelectedColumns(New Solmicro.Expertis.Engine.UI.ASSelectedColumn() {New Solmicro.Expertis.Engine.UI.ASSelectedColumn("GestionStockPorLotes", "GestionStockPorLotes"), New Solmicro.Expertis.Engine.UI.ASSelectedColumn("NSerieObligatorio", "NSerieObligatorio")}), "advArticulo"), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("RefProveedor", "ArticuloProveedor", "RefProveedor", New Solmicro.Expertis.Engine.UI.ASSelectedColumns(New Solmicro.Expertis.Engine.UI.ASSelectedColumn() {New Solmicro.Expertis.Engine.UI.ASSelectedColumn("IDArticulo", "IDArticulo")}), "advArticuloProveedor"), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("CContable", "PlanContable", "IDCContable"), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDAlmacen", "Almacen", "IDAlmacen", "advAlmacen"), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDTipoIVA", "TipoIVA", "IDTipoIVA"), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDCondicionPago", "CondicionPago", "IDCondicionPago"), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDFormaPago", "FormaPago", "IDFormaPago"), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDUdMedida", "UdMedida", "IDUdMedida"), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDCentroGestion", "CentroGestion", "IDCentroGestion"), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDActivoAImputar", "Activo", "IDActivo"), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IdContrato", "ContratoLinea", "IdContrato", New Solmicro.Expertis.Engine.UI.ASSelectedColumns(New Solmicro.Expertis.Engine.UI.ASSelectedColumn() {New Solmicro.Expertis.Engine.UI.ASSelectedColumn("UdValoracion", "UdValoracion"), New Solmicro.Expertis.Engine.UI.ASSelectedColumn("Precio", "Precio"), New Solmicro.Expertis.Engine.UI.ASSelectedColumn("IDUdCompra", "IDUdMedida"), New Solmicro.Expertis.Engine.UI.ASSelectedColumn("IdLineaContrato", "IdLineaContrato")}), "vFrmPedidoCompraContratosArticulo"), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("NOrden", "OrdenRuta", "NOrden", New Solmicro.Expertis.Engine.UI.ASSelectedColumns(New Solmicro.Expertis.Engine.UI.ASSelectedColumn() {New Solmicro.Expertis.Engine.UI.ASSelectedColumn("Secuencia", "Secuencia"), New Solmicro.Expertis.Engine.UI.ASSelectedColumn("IDOrdenRuta", "IDOrdenRuta"), New Solmicro.Expertis.Engine.UI.ASSelectedColumn("IDOrden", "IDOrden")}), "vFrmSearchArticuloOrdenRuta"), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("NROT", "MntoOTPrevLinea", "NROT", New Solmicro.Expertis.Engine.UI.ASSelectedColumns(New Solmicro.Expertis.Engine.UI.ASSelectedColumn() {New Solmicro.Expertis.Engine.UI.ASSelectedColumn("IDOT", "IDOT"), New Solmicro.Expertis.Engine.UI.ASSelectedColumn("IDMntoOTPrev", "IDMntoOTPrev")}), "vAdvOTsConPrevisto"), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("NObra", "ObraCabecera", "NObra", New Solmicro.Expertis.Engine.UI.ASSelectedColumns(New Solmicro.Expertis.Engine.UI.ASSelectedColumn() {New Solmicro.Expertis.Engine.UI.ASSelectedColumn("IDObra", "IDObra")}), "tbObraCabecera"), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("CodTrabajo", "ObraTrabajo", "CodTrabajo", New Solmicro.Expertis.Engine.UI.ASSelectedColumns(New Solmicro.Expertis.Engine.UI.ASSelectedColumn() {New Solmicro.Expertis.Engine.UI.ASSelectedColumn("IDObra", "IDObra"), New Solmicro.Expertis.Engine.UI.ASSelectedColumn("NObra", "NObra"), New Solmicro.Expertis.Engine.UI.ASSelectedColumn("IDTrabajo", "IDTrabajo")}), "advObraTrabajo")})
        jngLineaAlbaran_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("jngLineaAlbaran_DesignTimeLayout_Reference_0.Instance"), Object)
        jngLineaAlbaran_DesignTimeLayout_Reference_1.Instance = CType(resources.GetObject("jngLineaAlbaran_DesignTimeLayout_Reference_1.Instance"), Object)
        jngLineaAlbaran_DesignTimeLayout_Reference_2.Instance = CType(resources.GetObject("jngLineaAlbaran_DesignTimeLayout_Reference_2.Instance"), Object)
        jngLineaAlbaran_DesignTimeLayout_Reference_3.Instance = CType(resources.GetObject("jngLineaAlbaran_DesignTimeLayout_Reference_3.Instance"), Object)
        jngLineaAlbaran_DesignTimeLayout_Reference_4.Instance = CType(resources.GetObject("jngLineaAlbaran_DesignTimeLayout_Reference_4.Instance"), Object)
        jngLineaAlbaran_DesignTimeLayout_Reference_5.Instance = CType(resources.GetObject("jngLineaAlbaran_DesignTimeLayout_Reference_5.Instance"), Object)
        jngLineaAlbaran_DesignTimeLayout_Reference_6.Instance = CType(resources.GetObject("jngLineaAlbaran_DesignTimeLayout_Reference_6.Instance"), Object)
        jngLineaAlbaran_DesignTimeLayout_Reference_7.Instance = CType(resources.GetObject("jngLineaAlbaran_DesignTimeLayout_Reference_7.Instance"), Object)
        jngLineaAlbaran_DesignTimeLayout_Reference_8.Instance = CType(resources.GetObject("jngLineaAlbaran_DesignTimeLayout_Reference_8.Instance"), Object)
        jngLineaAlbaran_DesignTimeLayout_Reference_9.Instance = CType(resources.GetObject("jngLineaAlbaran_DesignTimeLayout_Reference_9.Instance"), Object)
        jngLineaAlbaran_DesignTimeLayout_Reference_10.Instance = CType(resources.GetObject("jngLineaAlbaran_DesignTimeLayout_Reference_10.Instance"), Object)
        jngLineaAlbaran_DesignTimeLayout_Reference_11.Instance = CType(resources.GetObject("jngLineaAlbaran_DesignTimeLayout_Reference_11.Instance"), Object)
        jngLineaAlbaran_DesignTimeLayout_Reference_12.Instance = CType(resources.GetObject("jngLineaAlbaran_DesignTimeLayout_Reference_12.Instance"), Object)
        jngLineaAlbaran_DesignTimeLayout_Reference_13.Instance = CType(resources.GetObject("jngLineaAlbaran_DesignTimeLayout_Reference_13.Instance"), Object)
        jngLineaAlbaran_DesignTimeLayout_Reference_14.Instance = CType(resources.GetObject("jngLineaAlbaran_DesignTimeLayout_Reference_14.Instance"), Object)
        jngLineaAlbaran_DesignTimeLayout_Reference_15.Instance = CType(resources.GetObject("jngLineaAlbaran_DesignTimeLayout_Reference_15.Instance"), Object)
        jngLineaAlbaran_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {jngLineaAlbaran_DesignTimeLayout_Reference_0, jngLineaAlbaran_DesignTimeLayout_Reference_1, jngLineaAlbaran_DesignTimeLayout_Reference_2, jngLineaAlbaran_DesignTimeLayout_Reference_3, jngLineaAlbaran_DesignTimeLayout_Reference_4, jngLineaAlbaran_DesignTimeLayout_Reference_5, jngLineaAlbaran_DesignTimeLayout_Reference_6, jngLineaAlbaran_DesignTimeLayout_Reference_7, jngLineaAlbaran_DesignTimeLayout_Reference_8, jngLineaAlbaran_DesignTimeLayout_Reference_9, jngLineaAlbaran_DesignTimeLayout_Reference_10, jngLineaAlbaran_DesignTimeLayout_Reference_11, jngLineaAlbaran_DesignTimeLayout_Reference_12, jngLineaAlbaran_DesignTimeLayout_Reference_13, jngLineaAlbaran_DesignTimeLayout_Reference_14, jngLineaAlbaran_DesignTimeLayout_Reference_15})
        jngLineaAlbaran_DesignTimeLayout.LayoutString = resources.GetString("jngLineaAlbaran_DesignTimeLayout.LayoutString")
        Me.jngLineaAlbaran.DesignTimeLayout = jngLineaAlbaran_DesignTimeLayout
        Me.jngLineaAlbaran.Dock = System.Windows.Forms.DockStyle.Fill
        Me.jngLineaAlbaran.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.jngLineaAlbaran.EntityName = "AlbaranCompraLinea"
        Me.jngLineaAlbaran.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.jngLineaAlbaran.FrozenColumns = 7
        Me.jngLineaAlbaran.ImageList = Me.ImageList1
        Me.jngLineaAlbaran.Location = New System.Drawing.Point(0, 0)
        Me.jngLineaAlbaran.Name = "jngLineaAlbaran"
        Me.jngLineaAlbaran.PrimaryDataFields = "IDAlbaran"
        Me.jngLineaAlbaran.SecondaryDataFields = "IDAlbaran"
        Me.jngLineaAlbaran.Size = New System.Drawing.Size(784, 268)
        Me.jngLineaAlbaran.TabIndex = 107
        Me.jngLineaAlbaran.Tag = ""
        Me.jngLineaAlbaran.ViewName = "VFrmMntoAlbaranCompraLinea"
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "note_edit.ico")
        Me.ImageList1.Images.SetKeyName(1, "folders.ico")
        Me.ImageList1.Images.SetKeyName(2, "certificate.ico")
        Me.ImageList1.Images.SetKeyName(3, "briefcase_out.ico")
        Me.ImageList1.Images.SetKeyName(4, "cubes_yellow.ico")
        Me.ImageList1.Images.SetKeyName(5, "BarCode.ico")
        Me.ImageList1.Images.SetKeyName(6, "find_again.ico")
        Me.ImageList1.Images.SetKeyName(7, "box_delete.ico")
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.LblImpIva)
        Me.Panel4.Controls.Add(Me.NtbImpIva)
        Me.Panel4.Controls.Add(Me.LblImpLineas)
        Me.Panel4.Controls.Add(Me.NtbImpLineas)
        Me.Panel4.Controls.Add(Me.LblImporteTotal)
        Me.Panel4.Controls.Add(Me.NtbImporteTotal)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 268)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(784, 33)
        Me.Panel4.TabIndex = 106
        '
        'LblImpIva
        '
        Me.LblImpIva.Location = New System.Drawing.Point(380, 10)
        Me.LblImpIva.Name = "LblImpIva"
        Me.LblImpIva.Size = New System.Drawing.Size(78, 13)
        Me.LblImpIva.TabIndex = 109
        Me.LblImpIva.Tag = "IdRec=5766;"
        Me.LblImpIva.Text = "Importe IVA"
        '
        'NtbImpIva
        '
        Me.TryDataBinding(NtbImpIva, New System.Windows.Forms.Binding("Value", Me, "ImpIva", True))
        Me.NtbImpIva.DisabledBackColor = System.Drawing.Color.White
        Me.NtbImpIva.Enabled = False
        Me.NtbImpIva.Location = New System.Drawing.Point(463, 7)
        Me.NtbImpIva.Name = "NtbImpIva"
        Me.NtbImpIva.Size = New System.Drawing.Size(100, 21)
        Me.NtbImpIva.TabIndex = 108
        '
        'LblImpLineas
        '
        Me.LblImpLineas.Location = New System.Drawing.Point(158, 10)
        Me.LblImpLineas.Name = "LblImpLineas"
        Me.LblImpLineas.Size = New System.Drawing.Size(93, 13)
        Me.LblImpLineas.TabIndex = 110
        Me.LblImpLineas.Tag = "IdRec=9324;"
        Me.LblImpLineas.Text = "Importe Lineas"
        '
        'NtbImpLineas
        '
        Me.TryDataBinding(NtbImpLineas, New System.Windows.Forms.Binding("Value", Me, "Importe", True))
        Me.NtbImpLineas.DisabledBackColor = System.Drawing.Color.White
        Me.NtbImpLineas.Enabled = False
        Me.NtbImpLineas.Location = New System.Drawing.Point(256, 7)
        Me.NtbImpLineas.Name = "NtbImpLineas"
        Me.NtbImpLineas.Size = New System.Drawing.Size(102, 21)
        Me.NtbImpLineas.TabIndex = 107
        '
        'LblImporteTotal
        '
        Me.LblImporteTotal.Location = New System.Drawing.Point(589, 10)
        Me.LblImporteTotal.Name = "LblImporteTotal"
        Me.LblImporteTotal.Size = New System.Drawing.Size(82, 13)
        Me.LblImporteTotal.TabIndex = 111
        Me.LblImporteTotal.Tag = "IdRec=5767;"
        Me.LblImporteTotal.Text = "Importe total"
        '
        'NtbImporteTotal
        '
        Me.TryDataBinding(NtbImporteTotal, New System.Windows.Forms.Binding("Value", Me, "ImpTotal", True))
        Me.NtbImporteTotal.DisabledBackColor = System.Drawing.Color.White
        Me.NtbImporteTotal.Enabled = False
        Me.NtbImporteTotal.Location = New System.Drawing.Point(676, 7)
        Me.NtbImporteTotal.Name = "NtbImporteTotal"
        Me.NtbImporteTotal.Size = New System.Drawing.Size(100, 21)
        Me.NtbImporteTotal.TabIndex = 106
        '
        'lblDescMonedaA
        '
        Me.lblDescMonedaA.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblDescMonedaA.Location = New System.Drawing.Point(144, 276)
        Me.lblDescMonedaA.Name = "lblDescMonedaA"
        Me.lblDescMonedaA.Size = New System.Drawing.Size(0, 13)
        Me.lblDescMonedaA.TabIndex = 43
        Me.lblDescMonedaA.Tag = "IdRec=0;"
        '
        'TabPagePicCentroRecepcion
        '
        Me.TabPagePicCentroRecepcion.Controls.Add(Me.lblfwiIdCentroGestion)
        Me.TabPagePicCentroRecepcion.Controls.Add(Me.lblcfwiIdCentroGestion)
        Me.TabPagePicCentroRecepcion.Controls.Add(Me.fwiIdCentroGestion)
        Me.TabPagePicCentroRecepcion.Controls.Add(Me.lblfwiTelefonoCG)
        Me.TabPagePicCentroRecepcion.Controls.Add(Me.fwiTelefonoCG)
        Me.TabPagePicCentroRecepcion.Controls.Add(Me.lblfwiCorreoCG)
        Me.TabPagePicCentroRecepcion.Controls.Add(Me.fwiCorreoCG)
        Me.TabPagePicCentroRecepcion.Controls.Add(Me.lblfwiFaxCG)
        Me.TabPagePicCentroRecepcion.Controls.Add(Me.fwiFaxCG)
        Me.TabPagePicCentroRecepcion.Controls.Add(Me.lblfwiCodPostalCG)
        Me.TabPagePicCentroRecepcion.Controls.Add(Me.fwiCodPostalCG)
        Me.TabPagePicCentroRecepcion.Controls.Add(Me.lblfwiPoblacionCG)
        Me.TabPagePicCentroRecepcion.Controls.Add(Me.fwiPoblacionCG)
        Me.TabPagePicCentroRecepcion.Controls.Add(Me.lblfwiProvinciaCG)
        Me.TabPagePicCentroRecepcion.Controls.Add(Me.fwiProvinciaCG)
        Me.TabPagePicCentroRecepcion.Controls.Add(Me.lblfwiDirCentroGestion)
        Me.TabPagePicCentroRecepcion.Controls.Add(Me.fwiDirCentroGestion)
        Me.TabPagePicCentroRecepcion.Controls.Add(Me.lblFwiIdAlmacen)
        Me.TabPagePicCentroRecepcion.Controls.Add(Me.lblcFwiIdAlmacen)
        Me.TabPagePicCentroRecepcion.Controls.Add(Me.FwiIdAlmacen)
        Me.TabPagePicCentroRecepcion.Key = "CentroRecepcion"
        Me.TabPagePicCentroRecepcion.Location = New System.Drawing.Point(1, 21)
        Me.TabPagePicCentroRecepcion.Name = "TabPagePicCentroRecepcion"
        Me.TabPagePicCentroRecepcion.Size = New System.Drawing.Size(784, 294)
        Me.TabPagePicCentroRecepcion.TabStop = True
        Me.TabPagePicCentroRecepcion.Text = "Centro Recepción"
        Me.TabPagePicCentroRecepcion.Visible = False
        '
        'lblfwiIdCentroGestion
        '
        Me.lblfwiIdCentroGestion.Location = New System.Drawing.Point(10, 40)
        Me.lblfwiIdCentroGestion.Name = "lblfwiIdCentroGestion"
        Me.lblfwiIdCentroGestion.Size = New System.Drawing.Size(93, 13)
        Me.lblfwiIdCentroGestion.TabIndex = 46
        Me.lblfwiIdCentroGestion.Tag = "IdRec=4409;"
        Me.lblfwiIdCentroGestion.Text = "Centro Gestión"
        '
        'lblcfwiIdCentroGestion
        '
        Me.TryDataBinding(lblcfwiIdCentroGestion, New System.Windows.Forms.Binding("Text", Me.fwiIdCentroGestion, "DescCentroGestion", True))
        Me.lblcfwiIdCentroGestion.Location = New System.Drawing.Point(198, 40)
        Me.lblcfwiIdCentroGestion.Name = "lblcfwiIdCentroGestion"
        Me.lblcfwiIdCentroGestion.Size = New System.Drawing.Size(562, 22)
        Me.lblcfwiIdCentroGestion.TabIndex = 47
        '
        'fwiIdCentroGestion
        '
        Me.TryDataBinding(fwiIdCentroGestion, New System.Windows.Forms.Binding("Text", Me, "IDCentroGestion", True))
        Me.fwiIdCentroGestion.DisabledBackColor = System.Drawing.Color.White
        Me.fwiIdCentroGestion.EntityName = "CentroGestion"
        Me.fwiIdCentroGestion.Location = New System.Drawing.Point(106, 40)
        Me.fwiIdCentroGestion.Name = "fwiIdCentroGestion"
        Me.fwiIdCentroGestion.PrimaryDataFields = "IDCentroGestion"
        Me.fwiIdCentroGestion.SecondaryDataFields = "IDCentroGestion"
        Me.fwiIdCentroGestion.Size = New System.Drawing.Size(88, 23)
        Me.fwiIdCentroGestion.TabIndex = 4
        Me.fwiIdCentroGestion.ViewName = "tbMaestroCentroGestion"
        '
        'lblfwiTelefonoCG
        '
        Me.lblfwiTelefonoCG.Location = New System.Drawing.Point(10, 168)
        Me.lblfwiTelefonoCG.Name = "lblfwiTelefonoCG"
        Me.lblfwiTelefonoCG.Size = New System.Drawing.Size(55, 13)
        Me.lblfwiTelefonoCG.TabIndex = 0
        Me.lblfwiTelefonoCG.Tag = "IdRec=4411;"
        Me.lblfwiTelefonoCG.Text = "Teléfono"
        '
        'fwiTelefonoCG
        '
        Me.TryDataBinding(fwiTelefonoCG, New System.Windows.Forms.Binding("Text", Me, "TelefonoCG", True))
        Me.fwiTelefonoCG.DisabledBackColor = System.Drawing.Color.White
        Me.fwiTelefonoCG.Enabled = False
        Me.fwiTelefonoCG.Location = New System.Drawing.Point(106, 168)
        Me.fwiTelefonoCG.Name = "fwiTelefonoCG"
        Me.fwiTelefonoCG.Size = New System.Drawing.Size(96, 21)
        Me.fwiTelefonoCG.TabIndex = 30
        '
        'lblfwiCorreoCG
        '
        Me.lblfwiCorreoCG.Location = New System.Drawing.Point(10, 232)
        Me.lblfwiCorreoCG.Name = "lblfwiCorreoCG"
        Me.lblfwiCorreoCG.Size = New System.Drawing.Size(41, 13)
        Me.lblfwiCorreoCG.TabIndex = 31
        Me.lblfwiCorreoCG.Tag = "IdRec=4416;"
        Me.lblfwiCorreoCG.Text = "e-Mail"
        '
        'fwiCorreoCG
        '
        Me.TryDataBinding(fwiCorreoCG, New System.Windows.Forms.Binding("Text", Me, "EmailCG", True))
        Me.fwiCorreoCG.DisabledBackColor = System.Drawing.Color.White
        Me.fwiCorreoCG.Enabled = False
        Me.fwiCorreoCG.Location = New System.Drawing.Point(106, 232)
        Me.fwiCorreoCG.Name = "fwiCorreoCG"
        Me.fwiCorreoCG.Size = New System.Drawing.Size(316, 21)
        Me.fwiCorreoCG.TabIndex = 35
        '
        'lblfwiFaxCG
        '
        Me.lblfwiFaxCG.Location = New System.Drawing.Point(10, 200)
        Me.lblfwiFaxCG.Name = "lblfwiFaxCG"
        Me.lblfwiFaxCG.Size = New System.Drawing.Size(26, 13)
        Me.lblfwiFaxCG.TabIndex = 36
        Me.lblfwiFaxCG.Tag = "IdRec=4415;"
        Me.lblfwiFaxCG.Text = "Fax"
        '
        'fwiFaxCG
        '
        Me.TryDataBinding(fwiFaxCG, New System.Windows.Forms.Binding("Text", Me, "FaxCG", True))
        Me.fwiFaxCG.DisabledBackColor = System.Drawing.Color.White
        Me.fwiFaxCG.Enabled = False
        Me.fwiFaxCG.Location = New System.Drawing.Point(106, 200)
        Me.fwiFaxCG.Name = "fwiFaxCG"
        Me.fwiFaxCG.Size = New System.Drawing.Size(96, 21)
        Me.fwiFaxCG.TabIndex = 34
        '
        'lblfwiCodPostalCG
        '
        Me.lblfwiCodPostalCG.Location = New System.Drawing.Point(10, 136)
        Me.lblfwiCodPostalCG.Name = "lblfwiCodPostalCG"
        Me.lblfwiCodPostalCG.Size = New System.Drawing.Size(29, 13)
        Me.lblfwiCodPostalCG.TabIndex = 37
        Me.lblfwiCodPostalCG.Tag = "IdRec=4414;"
        Me.lblfwiCodPostalCG.Text = "C.P."
        '
        'fwiCodPostalCG
        '
        Me.TryDataBinding(fwiCodPostalCG, New System.Windows.Forms.Binding("Text", Me, "CodPostalCG", True))
        Me.fwiCodPostalCG.DisabledBackColor = System.Drawing.Color.White
        Me.fwiCodPostalCG.Enabled = False
        Me.fwiCodPostalCG.Location = New System.Drawing.Point(106, 136)
        Me.fwiCodPostalCG.Name = "fwiCodPostalCG"
        Me.fwiCodPostalCG.Size = New System.Drawing.Size(58, 21)
        Me.fwiCodPostalCG.TabIndex = 33
        '
        'lblfwiPoblacionCG
        '
        Me.lblfwiPoblacionCG.Location = New System.Drawing.Point(174, 136)
        Me.lblfwiPoblacionCG.Name = "lblfwiPoblacionCG"
        Me.lblfwiPoblacionCG.Size = New System.Drawing.Size(61, 13)
        Me.lblfwiPoblacionCG.TabIndex = 38
        Me.lblfwiPoblacionCG.Tag = "IdRec=4413;"
        Me.lblfwiPoblacionCG.Text = "Población"
        '
        'fwiPoblacionCG
        '
        Me.TryDataBinding(fwiPoblacionCG, New System.Windows.Forms.Binding("Text", Me, "PoblacionCG", True))
        Me.fwiPoblacionCG.DisabledBackColor = System.Drawing.Color.White
        Me.fwiPoblacionCG.Enabled = False
        Me.fwiPoblacionCG.Location = New System.Drawing.Point(241, 136)
        Me.fwiPoblacionCG.Name = "fwiPoblacionCG"
        Me.fwiPoblacionCG.Size = New System.Drawing.Size(220, 21)
        Me.fwiPoblacionCG.TabIndex = 32
        '
        'lblfwiProvinciaCG
        '
        Me.lblfwiProvinciaCG.Location = New System.Drawing.Point(471, 136)
        Me.lblfwiProvinciaCG.Name = "lblfwiProvinciaCG"
        Me.lblfwiProvinciaCG.Size = New System.Drawing.Size(59, 13)
        Me.lblfwiProvinciaCG.TabIndex = 39
        Me.lblfwiProvinciaCG.Tag = "IdRec=4412;"
        Me.lblfwiProvinciaCG.Text = "Provincia"
        '
        'fwiProvinciaCG
        '
        Me.TryDataBinding(fwiProvinciaCG, New System.Windows.Forms.Binding("Text", Me, "ProvinciaCG", True))
        Me.fwiProvinciaCG.DisabledBackColor = System.Drawing.Color.White
        Me.fwiProvinciaCG.Enabled = False
        Me.fwiProvinciaCG.Location = New System.Drawing.Point(538, 136)
        Me.fwiProvinciaCG.Name = "fwiProvinciaCG"
        Me.fwiProvinciaCG.Size = New System.Drawing.Size(222, 21)
        Me.fwiProvinciaCG.TabIndex = 31
        '
        'lblfwiDirCentroGestion
        '
        Me.lblfwiDirCentroGestion.Location = New System.Drawing.Point(10, 104)
        Me.lblfwiDirCentroGestion.Name = "lblfwiDirCentroGestion"
        Me.lblfwiDirCentroGestion.Size = New System.Drawing.Size(60, 13)
        Me.lblfwiDirCentroGestion.TabIndex = 40
        Me.lblfwiDirCentroGestion.Tag = "IdRec=4410;"
        Me.lblfwiDirCentroGestion.Text = "Dirección"
        '
        'fwiDirCentroGestion
        '
        Me.TryDataBinding(fwiDirCentroGestion, New System.Windows.Forms.Binding("Text", Me, "DireccionCG", True))
        Me.fwiDirCentroGestion.DisabledBackColor = System.Drawing.Color.White
        Me.fwiDirCentroGestion.Enabled = False
        Me.fwiDirCentroGestion.Location = New System.Drawing.Point(106, 104)
        Me.fwiDirCentroGestion.Name = "fwiDirCentroGestion"
        Me.fwiDirCentroGestion.Size = New System.Drawing.Size(654, 21)
        Me.fwiDirCentroGestion.TabIndex = 29
        '
        'lblFwiIdAlmacen
        '
        Me.lblFwiIdAlmacen.Location = New System.Drawing.Point(10, 72)
        Me.lblFwiIdAlmacen.Name = "lblFwiIdAlmacen"
        Me.lblFwiIdAlmacen.Size = New System.Drawing.Size(56, 13)
        Me.lblFwiIdAlmacen.TabIndex = 41
        Me.lblFwiIdAlmacen.Tag = "IdRec=4408;"
        Me.lblFwiIdAlmacen.Text = "Almacén"
        '
        'lblcFwiIdAlmacen
        '
        Me.TryDataBinding(lblcFwiIdAlmacen, New System.Windows.Forms.Binding("Text", Me.FwiIdAlmacen, "DescAlmacen", True))
        Me.lblcFwiIdAlmacen.Location = New System.Drawing.Point(198, 72)
        Me.lblcFwiIdAlmacen.Name = "lblcFwiIdAlmacen"
        Me.lblcFwiIdAlmacen.Size = New System.Drawing.Size(562, 21)
        Me.lblcFwiIdAlmacen.TabIndex = 42
        '
        'FwiIdAlmacen
        '
        Me.TryDataBinding(FwiIdAlmacen, New System.Windows.Forms.Binding("Text", Me, "IDAlmacen", True))
        Me.FwiIdAlmacen.DisabledBackColor = System.Drawing.Color.White
        Me.FwiIdAlmacen.EntityName = "Almacen"
        Me.FwiIdAlmacen.Location = New System.Drawing.Point(106, 72)
        Me.FwiIdAlmacen.Name = "FwiIdAlmacen"
        Me.FwiIdAlmacen.PrimaryDataFields = "IDAlmacen"
        Me.FwiIdAlmacen.SecondaryDataFields = "IDAlmacen"
        Me.FwiIdAlmacen.Size = New System.Drawing.Size(88, 23)
        Me.FwiIdAlmacen.TabIndex = 5
        Me.FwiIdAlmacen.ViewName = "tbMaestroAlmacen"
        '
        'TabPagePicDatosEconomicos
        '
        Me.TabPagePicDatosEconomicos.Controls.Add(Me.Panel3)
        Me.TabPagePicDatosEconomicos.Controls.Add(Me.Panel2)
        Me.TabPagePicDatosEconomicos.Key = "DatosEconomicos"
        Me.TabPagePicDatosEconomicos.Location = New System.Drawing.Point(1, 21)
        Me.TabPagePicDatosEconomicos.Name = "TabPagePicDatosEconomicos"
        Me.TabPagePicDatosEconomicos.Size = New System.Drawing.Size(784, 297)
        Me.TabPagePicDatosEconomicos.TabStop = True
        Me.TabPagePicDatosEconomicos.Text = "Datos Económicos"
        Me.TabPagePicDatosEconomicos.Visible = False
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.FrmResEcon)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(364, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(420, 297)
        Me.Panel3.TabIndex = 31
        '
        'FrmResEcon
        '
        Me.FrmResEcon.Controls.Add(Me.UiGroupBox1)
        Me.FrmResEcon.Controls.Add(Me.LineDescuentos)
        Me.FrmResEcon.Controls.Add(Me.LblImpTotal)
        Me.FrmResEcon.Controls.Add(Me.LblPorcenRecFinan)
        Me.FrmResEcon.Controls.Add(Me.LblPorcenDtoAlb)
        Me.FrmResEcon.Controls.Add(Me.LblPorcenProntoPago)
        Me.FrmResEcon.Controls.Add(Me.LblDtoAlb)
        Me.FrmResEcon.Controls.Add(Me.NtbDtoAlbaran)
        Me.FrmResEcon.Controls.Add(Me.LblRecFinan)
        Me.FrmResEcon.Controls.Add(Me.NtbRecFinan)
        Me.FrmResEcon.Controls.Add(Me.LblIVA)
        Me.FrmResEcon.Controls.Add(Me.NtbIVA)
        Me.FrmResEcon.Controls.Add(Me.LblRE)
        Me.FrmResEcon.Controls.Add(Me.NtbRE)
        Me.FrmResEcon.Controls.Add(Me.NtbImporteAlbaran)
        Me.FrmResEcon.Controls.Add(Me.LblImpLineasSeg)
        Me.FrmResEcon.Controls.Add(Me.NtbImpTotalLineasRes)
        Me.FrmResEcon.Controls.Add(Me.LblBaseImponible)
        Me.FrmResEcon.Controls.Add(Me.NtbBaseImponible)
        Me.FrmResEcon.Controls.Add(Me.LblProntoPago)
        Me.FrmResEcon.Controls.Add(Me.NtbDtoProntoPago)
        Me.FrmResEcon.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FrmResEcon.Location = New System.Drawing.Point(0, 0)
        Me.FrmResEcon.Name = "FrmResEcon"
        Me.FrmResEcon.Size = New System.Drawing.Size(420, 297)
        Me.FrmResEcon.TabIndex = 98
        Me.FrmResEcon.TabStop = False
        Me.FrmResEcon.Text = "Resumen económico"
        '
        'UiGroupBox1
        '
        Me.UiGroupBox1.Location = New System.Drawing.Point(183, 179)
        Me.UiGroupBox1.Name = "UiGroupBox1"
        Me.UiGroupBox1.Size = New System.Drawing.Size(231, 3)
        Me.UiGroupBox1.TabIndex = 136
        '
        'LineDescuentos
        '
        Me.LineDescuentos.Location = New System.Drawing.Point(183, 102)
        Me.LineDescuentos.Name = "LineDescuentos"
        Me.LineDescuentos.Size = New System.Drawing.Size(231, 3)
        Me.LineDescuentos.TabIndex = 135
        '
        'LblImpTotal
        '
        Me.LblImpTotal.Location = New System.Drawing.Point(183, 187)
        Me.LblImpTotal.Name = "LblImpTotal"
        Me.LblImpTotal.Size = New System.Drawing.Size(84, 13)
        Me.LblImpTotal.TabIndex = 133
        Me.LblImpTotal.Tag = ""
        Me.LblImpTotal.Text = "Importe Total"
        Me.LblImpTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblPorcenRecFinan
        '
        Me.LblPorcenRecFinan.Location = New System.Drawing.Point(155, 182)
        Me.LblPorcenRecFinan.Name = "LblPorcenRecFinan"
        Me.LblPorcenRecFinan.Size = New System.Drawing.Size(19, 13)
        Me.LblPorcenRecFinan.TabIndex = 130
        Me.LblPorcenRecFinan.Text = "%"
        Me.LblPorcenRecFinan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblPorcenDtoAlb
        '
        Me.LblPorcenDtoAlb.Location = New System.Drawing.Point(155, 103)
        Me.LblPorcenDtoAlb.Name = "LblPorcenDtoAlb"
        Me.LblPorcenDtoAlb.Size = New System.Drawing.Size(19, 13)
        Me.LblPorcenDtoAlb.TabIndex = 131
        Me.LblPorcenDtoAlb.Text = "%"
        Me.LblPorcenDtoAlb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblPorcenProntoPago
        '
        Me.LblPorcenProntoPago.Location = New System.Drawing.Point(155, 127)
        Me.LblPorcenProntoPago.Name = "LblPorcenProntoPago"
        Me.LblPorcenProntoPago.Size = New System.Drawing.Size(19, 13)
        Me.LblPorcenProntoPago.TabIndex = 132
        Me.LblPorcenProntoPago.Text = "%"
        Me.LblPorcenProntoPago.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblDtoAlb
        '
        Me.LblDtoAlb.Location = New System.Drawing.Point(6, 103)
        Me.LblDtoAlb.Name = "LblDtoAlb"
        Me.LblDtoAlb.Size = New System.Drawing.Size(79, 13)
        Me.LblDtoAlb.TabIndex = 119
        Me.LblDtoAlb.Tag = ""
        Me.LblDtoAlb.Text = "Dto. Albarán"
        Me.LblDtoAlb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'NtbDtoAlbaran
        '
        Me.NtbDtoAlbaran.BorderStyle = Janus.Windows.GridEX.BorderStyle.None
        Me.TryDataBinding(NtbDtoAlbaran, New System.Windows.Forms.Binding("Value", Me, "Dto", True))
        Me.NtbDtoAlbaran.DisabledBackColor = System.Drawing.Color.White
        Me.NtbDtoAlbaran.Location = New System.Drawing.Point(88, 103)
        Me.NtbDtoAlbaran.Name = "NtbDtoAlbaran"
        Me.NtbDtoAlbaran.Size = New System.Drawing.Size(64, 19)
        Me.NtbDtoAlbaran.TabIndex = 46
        '
        'LblRecFinan
        '
        Me.LblRecFinan.Location = New System.Drawing.Point(6, 182)
        Me.LblRecFinan.Name = "LblRecFinan"
        Me.LblRecFinan.Size = New System.Drawing.Size(70, 13)
        Me.LblRecFinan.TabIndex = 123
        Me.LblRecFinan.Tag = "IdRec=10600;"
        Me.LblRecFinan.Text = "Rec. Finan."
        Me.LblRecFinan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'NtbRecFinan
        '
        Me.NtbRecFinan.BorderStyle = Janus.Windows.GridEX.BorderStyle.None
        Me.TryDataBinding(NtbRecFinan, New System.Windows.Forms.Binding("Value", Me, "RecFinan", True))
        Me.NtbRecFinan.DisabledBackColor = System.Drawing.Color.White
        Me.NtbRecFinan.Enabled = False
        Me.NtbRecFinan.Location = New System.Drawing.Point(88, 182)
        Me.NtbRecFinan.Name = "NtbRecFinan"
        Me.NtbRecFinan.Size = New System.Drawing.Size(64, 19)
        Me.NtbRecFinan.TabIndex = 48
        '
        'LblIVA
        '
        Me.LblIVA.Location = New System.Drawing.Point(204, 134)
        Me.LblIVA.Name = "LblIVA"
        Me.LblIVA.Size = New System.Drawing.Size(38, 13)
        Me.LblIVA.TabIndex = 124
        Me.LblIVA.Tag = "IdRec=5045;"
        Me.LblIVA.Text = "I.V.A."
        Me.LblIVA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'NtbIVA
        '
        Me.NtbIVA.BorderStyle = Janus.Windows.GridEX.BorderStyle.None
        Me.TryDataBinding(NtbIVA, New System.Windows.Forms.Binding("Value", Me, "ImpIVA", True))
        Me.NtbIVA.DisabledBackColor = System.Drawing.Color.White
        Me.NtbIVA.Enabled = False
        Me.NtbIVA.Location = New System.Drawing.Point(292, 134)
        Me.NtbIVA.Name = "NtbIVA"
        Me.NtbIVA.Size = New System.Drawing.Size(100, 19)
        Me.NtbIVA.TabIndex = 85
        '
        'LblRE
        '
        Me.LblRE.Location = New System.Drawing.Point(204, 158)
        Me.LblRE.Name = "LblRE"
        Me.LblRE.Size = New System.Drawing.Size(30, 13)
        Me.LblRE.TabIndex = 125
        Me.LblRE.Tag = "IdRec=5062;"
        Me.LblRE.Text = "R.E."
        Me.LblRE.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'NtbRE
        '
        Me.NtbRE.BorderStyle = Janus.Windows.GridEX.BorderStyle.None
        Me.TryDataBinding(NtbRE, New System.Windows.Forms.Binding("Value", Me, "ImpRE", True))
        Me.NtbRE.DisabledBackColor = System.Drawing.Color.White
        Me.NtbRE.Enabled = False
        Me.NtbRE.Location = New System.Drawing.Point(292, 158)
        Me.NtbRE.Name = "NtbRE"
        Me.NtbRE.Size = New System.Drawing.Size(100, 19)
        Me.NtbRE.TabIndex = 86
        '
        'NtbImporteAlbaran
        '
        Me.NtbImporteAlbaran.BorderStyle = Janus.Windows.GridEX.BorderStyle.None
        Me.TryDataBinding(NtbImporteAlbaran, New System.Windows.Forms.Binding("Value", Me, "ImpTotal", True))
        Me.NtbImporteAlbaran.DisabledBackColor = System.Drawing.Color.White
        Me.NtbImporteAlbaran.Enabled = False
        Me.NtbImporteAlbaran.Location = New System.Drawing.Point(292, 187)
        Me.NtbImporteAlbaran.Name = "NtbImporteAlbaran"
        Me.NtbImporteAlbaran.Size = New System.Drawing.Size(116, 19)
        Me.NtbImporteAlbaran.TabIndex = 87
        '
        'LblImpLineasSeg
        '
        Me.LblImpLineasSeg.Location = New System.Drawing.Point(183, 79)
        Me.LblImpLineasSeg.Name = "LblImpLineasSeg"
        Me.LblImpLineasSeg.Size = New System.Drawing.Size(93, 13)
        Me.LblImpLineasSeg.TabIndex = 127
        Me.LblImpLineasSeg.Tag = "IdRec=5067;"
        Me.LblImpLineasSeg.Text = "Importe Líneas"
        Me.LblImpLineasSeg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'NtbImpTotalLineasRes
        '
        Me.NtbImpTotalLineasRes.BorderStyle = Janus.Windows.GridEX.BorderStyle.None
        Me.TryDataBinding(NtbImpTotalLineasRes, New System.Windows.Forms.Binding("Value", Me, "Importe", True))
        Me.NtbImpTotalLineasRes.DisabledBackColor = System.Drawing.Color.White
        Me.NtbImpTotalLineasRes.Enabled = False
        Me.NtbImpTotalLineasRes.Location = New System.Drawing.Point(292, 79)
        Me.NtbImpTotalLineasRes.Name = "NtbImpTotalLineasRes"
        Me.NtbImpTotalLineasRes.Size = New System.Drawing.Size(116, 19)
        Me.NtbImpTotalLineasRes.TabIndex = 88
        '
        'LblBaseImponible
        '
        Me.LblBaseImponible.Location = New System.Drawing.Point(183, 110)
        Me.LblBaseImponible.Name = "LblBaseImponible"
        Me.LblBaseImponible.Size = New System.Drawing.Size(96, 13)
        Me.LblBaseImponible.TabIndex = 128
        Me.LblBaseImponible.Tag = "IdRec=5044;"
        Me.LblBaseImponible.Text = "Base Imponible"
        Me.LblBaseImponible.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'NtbBaseImponible
        '
        Me.NtbBaseImponible.BorderStyle = Janus.Windows.GridEX.BorderStyle.None
        Me.TryDataBinding(NtbBaseImponible, New System.Windows.Forms.Binding("Value", Me, "BaseImponible", True))
        Me.NtbBaseImponible.DisabledBackColor = System.Drawing.Color.White
        Me.NtbBaseImponible.Enabled = False
        Me.NtbBaseImponible.Location = New System.Drawing.Point(292, 110)
        Me.NtbBaseImponible.Name = "NtbBaseImponible"
        Me.NtbBaseImponible.Size = New System.Drawing.Size(116, 19)
        Me.NtbBaseImponible.TabIndex = 89
        '
        'LblProntoPago
        '
        Me.LblProntoPago.Location = New System.Drawing.Point(6, 127)
        Me.LblProntoPago.Name = "LblProntoPago"
        Me.LblProntoPago.Size = New System.Drawing.Size(76, 13)
        Me.LblProntoPago.TabIndex = 129
        Me.LblProntoPago.Tag = "IdRec=5068;"
        Me.LblProntoPago.Text = "Pronto Pago"
        Me.LblProntoPago.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'NtbDtoProntoPago
        '
        Me.NtbDtoProntoPago.BorderStyle = Janus.Windows.GridEX.BorderStyle.None
        Me.TryDataBinding(NtbDtoProntoPago, New System.Windows.Forms.Binding("Value", Me, "DtoProntoPago", True))
        Me.NtbDtoProntoPago.DisabledBackColor = System.Drawing.Color.White
        Me.NtbDtoProntoPago.Enabled = False
        Me.NtbDtoProntoPago.Location = New System.Drawing.Point(88, 127)
        Me.NtbDtoProntoPago.Name = "NtbDtoProntoPago"
        Me.NtbDtoProntoPago.Size = New System.Drawing.Size(64, 19)
        Me.NtbDtoProntoPago.TabIndex = 47
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.WLFrame4)
        Me.Panel2.Controls.Add(Me.WLFrame3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(364, 297)
        Me.Panel2.TabIndex = 29
        '
        'WLFrame4
        '
        Me.WLFrame4.Controls.Add(Me.fwiDto)
        Me.WLFrame4.Controls.Add(Me.lblfwiCambioA)
        Me.WLFrame4.Controls.Add(Me.fwiCambioA)
        Me.WLFrame4.Controls.Add(Me.lblfwiCambioB)
        Me.WLFrame4.Controls.Add(Me.fwiCambioB)
        Me.WLFrame4.Controls.Add(Me.fwiDescMonedaA)
        Me.WLFrame4.Controls.Add(Me.fwiDescMonedaB)
        Me.WLFrame4.Controls.Add(Me.lblfwiImporteA)
        Me.WLFrame4.Controls.Add(Me.fwiImporteA)
        Me.WLFrame4.Controls.Add(Me.lblfwiImporteB)
        Me.WLFrame4.Controls.Add(Me.fwiImporteB)
        Me.WLFrame4.Controls.Add(Me.lblfwiImporte)
        Me.WLFrame4.Controls.Add(Me.fwiImporte)
        Me.WLFrame4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WLFrame4.Location = New System.Drawing.Point(0, 131)
        Me.WLFrame4.Name = "WLFrame4"
        Me.WLFrame4.Size = New System.Drawing.Size(364, 166)
        Me.WLFrame4.TabIndex = 27
        Me.WLFrame4.TabStop = False
        Me.WLFrame4.Tag = ""
        Me.WLFrame4.Text = "Valoración Albarán"
        '
        'fwiDto
        '
        Me.TryDataBinding(fwiDto, New System.Windows.Forms.Binding("Value", Me, "Dto", True))
        Me.fwiDto.DisabledBackColor = System.Drawing.Color.White
        Me.fwiDto.Location = New System.Drawing.Point(41, 35)
        Me.fwiDto.Name = "fwiDto"
        Me.fwiDto.Size = New System.Drawing.Size(45, 21)
        Me.fwiDto.TabIndex = 35
        Me.fwiDto.Visible = False
        '
        'lblfwiCambioA
        '
        Me.lblfwiCambioA.Location = New System.Drawing.Point(25, 63)
        Me.lblfwiCambioA.Name = "lblfwiCambioA"
        Me.lblfwiCambioA.Size = New System.Drawing.Size(63, 13)
        Me.lblfwiCambioA.TabIndex = 0
        Me.lblfwiCambioA.Tag = "IdRec=4395;"
        Me.lblfwiCambioA.Text = "Cambio A"
        '
        'fwiCambioA
        '
        Me.TryDataBinding(fwiCambioA, New System.Windows.Forms.Binding("Text", Me, "CambioA", True))
        Me.fwiCambioA.DisabledBackColor = System.Drawing.Color.White
        Me.fwiCambioA.Enabled = False
        Me.fwiCambioA.Location = New System.Drawing.Point(89, 59)
        Me.fwiCambioA.Name = "fwiCambioA"
        Me.fwiCambioA.Size = New System.Drawing.Size(101, 21)
        Me.fwiCambioA.TabIndex = 23
        '
        'lblfwiCambioB
        '
        Me.lblfwiCambioB.Location = New System.Drawing.Point(25, 111)
        Me.lblfwiCambioB.Name = "lblfwiCambioB"
        Me.lblfwiCambioB.Size = New System.Drawing.Size(63, 13)
        Me.lblfwiCambioB.TabIndex = 24
        Me.lblfwiCambioB.Tag = "IdRec=4399;"
        Me.lblfwiCambioB.Text = "Cambio B"
        '
        'fwiCambioB
        '
        Me.TryDataBinding(fwiCambioB, New System.Windows.Forms.Binding("Text", Me, "CambioB", True))
        Me.fwiCambioB.DisabledBackColor = System.Drawing.Color.White
        Me.fwiCambioB.Enabled = False
        Me.fwiCambioB.Location = New System.Drawing.Point(89, 107)
        Me.fwiCambioB.Name = "fwiCambioB"
        Me.fwiCambioB.Size = New System.Drawing.Size(101, 21)
        Me.fwiCambioB.TabIndex = 22
        '
        'fwiDescMonedaA
        '
        Me.fwiDescMonedaA.DisabledBackColor = System.Drawing.Color.White
        Me.fwiDescMonedaA.Enabled = False
        Me.fwiDescMonedaA.Location = New System.Drawing.Point(193, 59)
        Me.fwiDescMonedaA.Name = "fwiDescMonedaA"
        Me.fwiDescMonedaA.Size = New System.Drawing.Size(113, 21)
        Me.fwiDescMonedaA.TabIndex = 20
        '
        'fwiDescMonedaB
        '
        Me.fwiDescMonedaB.DisabledBackColor = System.Drawing.Color.White
        Me.fwiDescMonedaB.Enabled = False
        Me.fwiDescMonedaB.Location = New System.Drawing.Point(193, 107)
        Me.fwiDescMonedaB.Name = "fwiDescMonedaB"
        Me.fwiDescMonedaB.Size = New System.Drawing.Size(113, 21)
        Me.fwiDescMonedaB.TabIndex = 19
        '
        'lblfwiImporteA
        '
        Me.lblfwiImporteA.Location = New System.Drawing.Point(105, 87)
        Me.lblfwiImporteA.Name = "lblfwiImporteA"
        Me.lblfwiImporteA.Size = New System.Drawing.Size(65, 13)
        Me.lblfwiImporteA.TabIndex = 25
        Me.lblfwiImporteA.Tag = "IdRec=4401;"
        Me.lblfwiImporteA.Text = "Importe A"
        '
        'fwiImporteA
        '
        Me.TryDataBinding(fwiImporteA, New System.Windows.Forms.Binding("Value", Me, "ImporteA", True))
        Me.fwiImporteA.DisabledBackColor = System.Drawing.Color.White
        Me.fwiImporteA.Enabled = False
        Me.fwiImporteA.Location = New System.Drawing.Point(193, 83)
        Me.fwiImporteA.Name = "fwiImporteA"
        Me.fwiImporteA.Size = New System.Drawing.Size(113, 21)
        Me.fwiImporteA.TabIndex = 18
        '
        'lblfwiImporteB
        '
        Me.lblfwiImporteB.Location = New System.Drawing.Point(105, 136)
        Me.lblfwiImporteB.Name = "lblfwiImporteB"
        Me.lblfwiImporteB.Size = New System.Drawing.Size(65, 13)
        Me.lblfwiImporteB.TabIndex = 26
        Me.lblfwiImporteB.Tag = "IdRec=4402;"
        Me.lblfwiImporteB.Text = "Importe B"
        '
        'fwiImporteB
        '
        Me.TryDataBinding(fwiImporteB, New System.Windows.Forms.Binding("Value", Me, "ImporteB", True))
        Me.fwiImporteB.DisabledBackColor = System.Drawing.Color.White
        Me.fwiImporteB.Enabled = False
        Me.fwiImporteB.Location = New System.Drawing.Point(193, 132)
        Me.fwiImporteB.Name = "fwiImporteB"
        Me.fwiImporteB.Size = New System.Drawing.Size(113, 21)
        Me.fwiImporteB.TabIndex = 17
        '
        'lblfwiImporte
        '
        Me.lblfwiImporte.Location = New System.Drawing.Point(105, 39)
        Me.lblfwiImporte.Name = "lblfwiImporte"
        Me.lblfwiImporte.Size = New System.Drawing.Size(53, 13)
        Me.lblfwiImporte.TabIndex = 27
        Me.lblfwiImporte.Tag = "IdRec=4389;"
        Me.lblfwiImporte.Text = "Importe"
        '
        'fwiImporte
        '
        Me.TryDataBinding(fwiImporte, New System.Windows.Forms.Binding("Value", Me, "Importe", True))
        Me.fwiImporte.DisabledBackColor = System.Drawing.Color.White
        Me.fwiImporte.Enabled = False
        Me.fwiImporte.Location = New System.Drawing.Point(193, 35)
        Me.fwiImporte.Name = "fwiImporte"
        Me.fwiImporte.Size = New System.Drawing.Size(113, 21)
        Me.fwiImporte.TabIndex = 16
        '
        'WLFrame3
        '
        Me.WLFrame3.Controls.Add(Me.ULblCentroCoste)
        Me.WLFrame3.Controls.Add(Me.AdvCentroCoste)
        Me.WLFrame3.Controls.Add(Me.LblCentroCoste)
        Me.WLFrame3.Controls.Add(Me.lblfwiIdCondPago)
        Me.WLFrame3.Controls.Add(Me.lblcfwiIdCondPago)
        Me.WLFrame3.Controls.Add(Me.fwiIdCondPago)
        Me.WLFrame3.Controls.Add(Me.lblfwiIdFormaPago)
        Me.WLFrame3.Controls.Add(Me.lblcfwiIdFormaPago)
        Me.WLFrame3.Controls.Add(Me.fwiIdFormaPago)
        Me.WLFrame3.Controls.Add(Me.lblfwiIdMoneda)
        Me.WLFrame3.Controls.Add(Me.lblcfwiIdMoneda)
        Me.WLFrame3.Controls.Add(Me.fwiIdMoneda)
        Me.WLFrame3.Dock = System.Windows.Forms.DockStyle.Top
        Me.WLFrame3.Location = New System.Drawing.Point(0, 0)
        Me.WLFrame3.Name = "WLFrame3"
        Me.WLFrame3.Size = New System.Drawing.Size(364, 131)
        Me.WLFrame3.TabIndex = 26
        Me.WLFrame3.TabStop = False
        Me.WLFrame3.Tag = "IdRec=4420;"
        Me.WLFrame3.Text = "Condiciones Económicas"
        '
        'ULblCentroCoste
        '
        Me.TryDataBinding(ULblCentroCoste, New System.Windows.Forms.Binding("Text", Me.AdvCentroCoste, "DescCentroCoste", True))
        Me.ULblCentroCoste.Location = New System.Drawing.Point(168, 100)
        Me.ULblCentroCoste.Name = "ULblCentroCoste"
        Me.ULblCentroCoste.Size = New System.Drawing.Size(184, 23)
        Me.ULblCentroCoste.TabIndex = 67
        '
        'AdvCentroCoste
        '
        Me.TryDataBinding(AdvCentroCoste, New System.Windows.Forms.Binding("Value", Me, "IDCentroCoste", True))
        Me.AdvCentroCoste.DisabledBackColor = System.Drawing.Color.White
        Me.AdvCentroCoste.DisplayField = "IDCentroCoste"
        Me.AdvCentroCoste.EntityName = "CentroCosteAnalitica"
        Me.AdvCentroCoste.Location = New System.Drawing.Point(89, 100)
        Me.AdvCentroCoste.Name = "AdvCentroCoste"
        Me.AdvCentroCoste.PrimaryDataFields = "IDCentroCoste"
        Me.AdvCentroCoste.SecondaryDataFields = "IDCentroCoste"
        Me.AdvCentroCoste.Size = New System.Drawing.Size(75, 23)
        Me.AdvCentroCoste.TabIndex = 9
        Me.AdvCentroCoste.ViewName = "tbMaestroCentroCosteAnalitica"
        '
        'LblCentroCoste
        '
        Me.LblCentroCoste.Location = New System.Drawing.Point(6, 105)
        Me.LblCentroCoste.Name = "LblCentroCoste"
        Me.LblCentroCoste.Size = New System.Drawing.Size(83, 13)
        Me.LblCentroCoste.TabIndex = 48
        Me.LblCentroCoste.Text = "Centro Coste"
        Me.LblCentroCoste.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblfwiIdCondPago
        '
        Me.lblfwiIdCondPago.Location = New System.Drawing.Point(6, 51)
        Me.lblfwiIdCondPago.Name = "lblfwiIdCondPago"
        Me.lblfwiIdCondPago.Size = New System.Drawing.Size(52, 13)
        Me.lblfwiIdCondPago.TabIndex = 0
        Me.lblfwiIdCondPago.Tag = "IdRec=4396;"
        Me.lblfwiIdCondPago.Text = "C. Pago"
        Me.lblfwiIdCondPago.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblcfwiIdCondPago
        '
        Me.TryDataBinding(lblcfwiIdCondPago, New System.Windows.Forms.Binding("Text", Me.fwiIdCondPago, "DescCondicionPago", True))
        Me.lblcfwiIdCondPago.Location = New System.Drawing.Point(168, 46)
        Me.lblcfwiIdCondPago.Name = "lblcfwiIdCondPago"
        Me.lblcfwiIdCondPago.Size = New System.Drawing.Size(183, 23)
        Me.lblcfwiIdCondPago.TabIndex = 1
        '
        'fwiIdCondPago
        '
        Me.TryDataBinding(fwiIdCondPago, New System.Windows.Forms.Binding("Text", Me, "IdCondicionPago", True))
        Me.fwiIdCondPago.DisabledBackColor = System.Drawing.Color.White
        Me.fwiIdCondPago.EntityName = "CondicionPago"
        Me.fwiIdCondPago.Location = New System.Drawing.Point(89, 46)
        Me.fwiIdCondPago.Name = "fwiIdCondPago"
        Me.fwiIdCondPago.PrimaryDataFields = "IDCondicionPago"
        Me.fwiIdCondPago.SecondaryDataFields = "IDCondicionPago"
        Me.fwiIdCondPago.Size = New System.Drawing.Size(75, 23)
        Me.fwiIdCondPago.TabIndex = 7
        Me.fwiIdCondPago.ViewName = "tbMaestroCondicionPago"
        '
        'lblfwiIdFormaPago
        '
        Me.lblfwiIdFormaPago.Location = New System.Drawing.Point(6, 24)
        Me.lblfwiIdFormaPago.Name = "lblfwiIdFormaPago"
        Me.lblfwiIdFormaPago.Size = New System.Drawing.Size(47, 13)
        Me.lblfwiIdFormaPago.TabIndex = 8
        Me.lblfwiIdFormaPago.Tag = "IdRec=4397;"
        Me.lblfwiIdFormaPago.Text = "F. Pago"
        Me.lblfwiIdFormaPago.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblcfwiIdFormaPago
        '
        Me.TryDataBinding(lblcfwiIdFormaPago, New System.Windows.Forms.Binding("Text", Me.fwiIdFormaPago, "DescFormaPago", True))
        Me.lblcfwiIdFormaPago.Location = New System.Drawing.Point(168, 19)
        Me.lblcfwiIdFormaPago.Name = "lblcfwiIdFormaPago"
        Me.lblcfwiIdFormaPago.Size = New System.Drawing.Size(183, 23)
        Me.lblcfwiIdFormaPago.TabIndex = 9
        '
        'fwiIdFormaPago
        '
        Me.TryDataBinding(fwiIdFormaPago, New System.Windows.Forms.Binding("Text", Me, "IDFormaPago", True))
        Me.fwiIdFormaPago.DisabledBackColor = System.Drawing.Color.White
        Me.fwiIdFormaPago.EntityName = "FormaPago"
        Me.fwiIdFormaPago.Location = New System.Drawing.Point(89, 19)
        Me.fwiIdFormaPago.Name = "fwiIdFormaPago"
        Me.fwiIdFormaPago.PrimaryDataFields = "IDFormaPago"
        Me.fwiIdFormaPago.SecondaryDataFields = "IDFormaPago"
        Me.fwiIdFormaPago.Size = New System.Drawing.Size(75, 23)
        Me.fwiIdFormaPago.TabIndex = 6
        Me.fwiIdFormaPago.ViewName = "tbMaestroFormaPago"
        '
        'lblfwiIdMoneda
        '
        Me.lblfwiIdMoneda.Location = New System.Drawing.Point(6, 78)
        Me.lblfwiIdMoneda.Name = "lblfwiIdMoneda"
        Me.lblfwiIdMoneda.Size = New System.Drawing.Size(51, 13)
        Me.lblfwiIdMoneda.TabIndex = 10
        Me.lblfwiIdMoneda.Tag = "IdRec=4398;"
        Me.lblfwiIdMoneda.Text = "Moneda"
        Me.lblfwiIdMoneda.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblcfwiIdMoneda
        '
        Me.TryDataBinding(lblcfwiIdMoneda, New System.Windows.Forms.Binding("Text", Me.fwiIdMoneda, "DescMoneda", True))
        Me.lblcfwiIdMoneda.Location = New System.Drawing.Point(168, 73)
        Me.lblcfwiIdMoneda.Name = "lblcfwiIdMoneda"
        Me.lblcfwiIdMoneda.Size = New System.Drawing.Size(183, 23)
        Me.lblcfwiIdMoneda.TabIndex = 11
        '
        'fwiIdMoneda
        '
        Me.TryDataBinding(fwiIdMoneda, New System.Windows.Forms.Binding("Text", Me, "IDMoneda", True))
        Me.fwiIdMoneda.DisabledBackColor = System.Drawing.Color.White
        Me.fwiIdMoneda.EntityName = "Moneda"
        Me.fwiIdMoneda.Location = New System.Drawing.Point(89, 73)
        Me.fwiIdMoneda.Name = "fwiIdMoneda"
        Me.fwiIdMoneda.PrimaryDataFields = "IDMoneda"
        Me.fwiIdMoneda.SecondaryDataFields = "IDMoneda"
        Me.fwiIdMoneda.Size = New System.Drawing.Size(75, 23)
        Me.fwiIdMoneda.TabIndex = 8
        Me.fwiIdMoneda.ViewName = "tbMaestroMoneda"
        '
        'UiTabEnvio
        '
        Me.UiTabEnvio.Controls.Add(Me.FrmDAA)
        Me.UiTabEnvio.Controls.Add(Me.FraPE)
        Me.UiTabEnvio.Controls.Add(Me.WLFrame7)
        Me.UiTabEnvio.Key = "Envios"
        Me.UiTabEnvio.Location = New System.Drawing.Point(1, 21)
        Me.UiTabEnvio.Name = "UiTabEnvio"
        Me.UiTabEnvio.Size = New System.Drawing.Size(784, 301)
        Me.UiTabEnvio.TabStop = True
        Me.UiTabEnvio.Text = "Envios"
        '
        'FrmDAA
        '
        Me.FrmDAA.Controls.Add(Me.TxtARC)
        Me.FrmDAA.Controls.Add(Me.TxtDAA)
        Me.FrmDAA.Controls.Add(Me.LblARC)
        Me.FrmDAA.Controls.Add(Me.LblDAA)
        Me.FrmDAA.Location = New System.Drawing.Point(8, 181)
        Me.FrmDAA.Name = "FrmDAA"
        Me.FrmDAA.Size = New System.Drawing.Size(465, 79)
        Me.FrmDAA.TabIndex = 45
        Me.FrmDAA.TabStop = False
        Me.FrmDAA.Text = "D.A.A."
        '
        'TxtARC
        '
        Me.TryDataBinding(TxtARC, New System.Windows.Forms.Binding("Text", Me, "AadReferenceCode", True))
        Me.TxtARC.DisabledBackColor = System.Drawing.Color.White
        Me.TxtARC.Location = New System.Drawing.Point(113, 47)
        Me.TxtARC.Name = "TxtARC"
        Me.TxtARC.Size = New System.Drawing.Size(346, 21)
        Me.TxtARC.TabIndex = 3
        '
        'TxtDAA
        '
        Me.TryDataBinding(TxtDAA, New System.Windows.Forms.Binding("Text", Me, "NDaa", True))
        Me.TxtDAA.DisabledBackColor = System.Drawing.Color.White
        Me.TxtDAA.Location = New System.Drawing.Point(113, 20)
        Me.TxtDAA.Name = "TxtDAA"
        Me.TxtDAA.Size = New System.Drawing.Size(346, 21)
        Me.TxtDAA.TabIndex = 2
        '
        'LblARC
        '
        Me.LblARC.Location = New System.Drawing.Point(12, 51)
        Me.LblARC.Name = "LblARC"
        Me.LblARC.Size = New System.Drawing.Size(44, 13)
        Me.LblARC.TabIndex = 1
        Me.LblARC.Text = "A.R.C."
        '
        'LblDAA
        '
        Me.LblDAA.Location = New System.Drawing.Point(12, 25)
        Me.LblDAA.Name = "LblDAA"
        Me.LblDAA.Size = New System.Drawing.Size(44, 13)
        Me.LblDAA.TabIndex = 0
        Me.LblDAA.Text = "D.A.A."
        '
        'FraPE
        '
        Me.FraPE.Controls.Add(Me.TxtNumBultos)
        Me.FraPE.Controls.Add(Me.LblPesoNetoManual)
        Me.FraPE.Controls.Add(Me.LblNumBultos)
        Me.FraPE.Controls.Add(Me.NtbPesoNetoManual)
        Me.FraPE.Controls.Add(Me.LblPesoManual)
        Me.FraPE.Controls.Add(Me.NtbPesoBrutoManual)
        Me.FraPE.Controls.Add(Me.LblPesoBruto)
        Me.FraPE.Controls.Add(Me.LblPesoNeto)
        Me.FraPE.Controls.Add(Me.NtbPesoBruto)
        Me.FraPE.Controls.Add(Me.NtbPesoNeto)
        Me.FraPE.Location = New System.Drawing.Point(479, 3)
        Me.FraPE.Name = "FraPE"
        Me.FraPE.Size = New System.Drawing.Size(249, 172)
        Me.FraPE.TabIndex = 44
        Me.FraPE.TabStop = False
        Me.FraPE.Text = "Pesos y embalajes"
        '
        'TxtNumBultos
        '
        Me.TryDataBinding(TxtNumBultos, New System.Windows.Forms.Binding("Text", Me, "NBultos", True))
        Me.TxtNumBultos.DisabledBackColor = System.Drawing.Color.White
        Me.TxtNumBultos.Location = New System.Drawing.Point(100, 131)
        Me.TxtNumBultos.Name = "TxtNumBultos"
        Me.TxtNumBultos.Size = New System.Drawing.Size(123, 21)
        Me.TxtNumBultos.TabIndex = 50
        Me.TxtNumBultos.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
        '
        'LblPesoNetoManual
        '
        Me.LblPesoNetoManual.Location = New System.Drawing.Point(6, 110)
        Me.LblPesoNetoManual.Name = "LblPesoNetoManual"
        Me.LblPesoNetoManual.Size = New System.Drawing.Size(94, 13)
        Me.LblPesoNetoManual.TabIndex = 49
        Me.LblPesoNetoManual.Tag = ""
        Me.LblPesoNetoManual.Text = "Peso N. Manual"
        '
        'LblNumBultos
        '
        Me.LblNumBultos.Location = New System.Drawing.Point(9, 135)
        Me.LblNumBultos.Name = "LblNumBultos"
        Me.LblNumBultos.Size = New System.Drawing.Size(60, 13)
        Me.LblNumBultos.TabIndex = 51
        Me.LblNumBultos.Tag = ""
        Me.LblNumBultos.Text = "Nº Bultos"
        '
        'NtbPesoNetoManual
        '
        Me.TryDataBinding(NtbPesoNetoManual, New System.Windows.Forms.Binding("Text", Me, "PesoNetoManual", True))
        Me.NtbPesoNetoManual.DisabledBackColor = System.Drawing.Color.White
        Me.NtbPesoNetoManual.Location = New System.Drawing.Point(100, 104)
        Me.NtbPesoNetoManual.Name = "NtbPesoNetoManual"
        Me.NtbPesoNetoManual.Size = New System.Drawing.Size(123, 21)
        Me.NtbPesoNetoManual.TabIndex = 48
        '
        'LblPesoManual
        '
        Me.LblPesoManual.Location = New System.Drawing.Point(4, 56)
        Me.LblPesoManual.Name = "LblPesoManual"
        Me.LblPesoManual.Size = New System.Drawing.Size(94, 13)
        Me.LblPesoManual.TabIndex = 45
        Me.LblPesoManual.Tag = ""
        Me.LblPesoManual.Text = "Peso B. Manual"
        '
        'NtbPesoBrutoManual
        '
        Me.TryDataBinding(NtbPesoBrutoManual, New System.Windows.Forms.Binding("Text", Me, "PesoBrutoManual", True))
        Me.NtbPesoBrutoManual.DisabledBackColor = System.Drawing.Color.White
        Me.NtbPesoBrutoManual.Location = New System.Drawing.Point(100, 52)
        Me.NtbPesoBrutoManual.Name = "NtbPesoBrutoManual"
        Me.NtbPesoBrutoManual.Size = New System.Drawing.Size(123, 21)
        Me.NtbPesoBrutoManual.TabIndex = 44
        '
        'LblPesoBruto
        '
        Me.LblPesoBruto.Location = New System.Drawing.Point(4, 27)
        Me.LblPesoBruto.Name = "LblPesoBruto"
        Me.LblPesoBruto.Size = New System.Drawing.Size(69, 13)
        Me.LblPesoBruto.TabIndex = 45
        Me.LblPesoBruto.Tag = "IdRec=4441;"
        Me.LblPesoBruto.Text = "Peso Bruto"
        '
        'LblPesoNeto
        '
        Me.LblPesoNeto.Location = New System.Drawing.Point(6, 84)
        Me.LblPesoNeto.Name = "LblPesoNeto"
        Me.LblPesoNeto.Size = New System.Drawing.Size(64, 13)
        Me.LblPesoNeto.TabIndex = 46
        Me.LblPesoNeto.Tag = "IdRec=4440;"
        Me.LblPesoNeto.Text = "Peso Neto"
        '
        'NtbPesoBruto
        '
        Me.TryDataBinding(NtbPesoBruto, New System.Windows.Forms.Binding("Text", Me, "PesoBruto", True))
        Me.NtbPesoBruto.DisabledBackColor = System.Drawing.Color.White
        Me.NtbPesoBruto.Enabled = False
        Me.NtbPesoBruto.Location = New System.Drawing.Point(100, 23)
        Me.NtbPesoBruto.Name = "NtbPesoBruto"
        Me.NtbPesoBruto.Size = New System.Drawing.Size(123, 21)
        Me.NtbPesoBruto.TabIndex = 44
        '
        'NtbPesoNeto
        '
        Me.TryDataBinding(NtbPesoNeto, New System.Windows.Forms.Binding("Text", Me, "PesoNeto", True))
        Me.NtbPesoNeto.DisabledBackColor = System.Drawing.Color.White
        Me.NtbPesoNeto.Enabled = False
        Me.NtbPesoNeto.Location = New System.Drawing.Point(100, 77)
        Me.NtbPesoNeto.Name = "NtbPesoNeto"
        Me.NtbPesoNeto.Size = New System.Drawing.Size(123, 21)
        Me.NtbPesoNeto.TabIndex = 47
        '
        'WLFrame7
        '
        Me.WLFrame7.Controls.Add(Me.txtRemolque)
        Me.WLFrame7.Controls.Add(Me.txtEmpresa)
        Me.WLFrame7.Controls.Add(Me.lblRemolque)
        Me.WLFrame7.Controls.Add(Me.Label7)
        Me.WLFrame7.Controls.Add(Me.txtMatricula)
        Me.WLFrame7.Controls.Add(Me.lblMatricula)
        Me.WLFrame7.Controls.Add(Me.txtCifTransp)
        Me.WLFrame7.Controls.Add(Me.txtDniConductor)
        Me.WLFrame7.Controls.Add(Me.Label6)
        Me.WLFrame7.Controls.Add(Me.lblDniConductor)
        Me.WLFrame7.Controls.Add(Me.lblFwiModoTransporte)
        Me.WLFrame7.Controls.Add(Me.txtConductor)
        Me.WLFrame7.Controls.Add(Me.lblcFwiModoTransporte)
        Me.WLFrame7.Controls.Add(Me.lblConductor)
        Me.WLFrame7.Controls.Add(Me.FwiModoTransporte)
        Me.WLFrame7.Controls.Add(Me.lblfwiIdCondEnvio)
        Me.WLFrame7.Controls.Add(Me.lblcfwiIdCondEnvio)
        Me.WLFrame7.Controls.Add(Me.fwiIdCondEnvio)
        Me.WLFrame7.Controls.Add(Me.lblfwiIDFormaEnvio)
        Me.WLFrame7.Controls.Add(Me.lblcfwiIDFormaEnvio)
        Me.WLFrame7.Controls.Add(Me.fwiIDFormaEnvio)
        Me.WLFrame7.Controls.Add(Me.cmbDetalles)
        Me.WLFrame7.Location = New System.Drawing.Point(7, 3)
        Me.WLFrame7.Name = "WLFrame7"
        Me.WLFrame7.Size = New System.Drawing.Size(466, 172)
        Me.WLFrame7.TabIndex = 43
        Me.WLFrame7.TabStop = False
        Me.WLFrame7.Tag = "IdRec=4419;"
        Me.WLFrame7.Text = "Condiciones de Envío"
        '
        'txtRemolque
        '
        Me.TryDataBinding(txtRemolque, New System.Windows.Forms.Binding("Text", Me, "Remolque", True))
        Me.txtRemolque.DisabledBackColor = System.Drawing.Color.White
        Me.txtRemolque.Location = New System.Drawing.Point(385, 143)
        Me.txtRemolque.Name = "txtRemolque"
        Me.txtRemolque.Size = New System.Drawing.Size(75, 21)
        Me.txtRemolque.TabIndex = 20
        '
        'txtEmpresa
        '
        Me.TryDataBinding(txtEmpresa, New System.Windows.Forms.Binding("Text", Me, "EmpresaTransp", True))
        Me.txtEmpresa.DisabledBackColor = System.Drawing.Color.White
        Me.txtEmpresa.Location = New System.Drawing.Point(114, 97)
        Me.txtEmpresa.Name = "txtEmpresa"
        Me.txtEmpresa.Size = New System.Drawing.Size(162, 21)
        Me.txtEmpresa.TabIndex = 15
        '
        'lblRemolque
        '
        Me.lblRemolque.Location = New System.Drawing.Point(282, 147)
        Me.lblRemolque.Name = "lblRemolque"
        Me.lblRemolque.Size = New System.Drawing.Size(64, 13)
        Me.lblRemolque.TabIndex = 8
        Me.lblRemolque.Text = "Remolque"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(7, 101)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(57, 13)
        Me.Label7.TabIndex = 191
        Me.Label7.Text = "Empresa"
        '
        'txtMatricula
        '
        Me.TryDataBinding(txtMatricula, New System.Windows.Forms.Binding("Text", Me, "Matricula", True))
        Me.txtMatricula.DisabledBackColor = System.Drawing.Color.White
        Me.txtMatricula.Location = New System.Drawing.Point(114, 143)
        Me.txtMatricula.Name = "txtMatricula"
        Me.txtMatricula.Size = New System.Drawing.Size(162, 21)
        Me.txtMatricula.TabIndex = 19
        '
        'lblMatricula
        '
        Me.lblMatricula.Location = New System.Drawing.Point(7, 147)
        Me.lblMatricula.Name = "lblMatricula"
        Me.lblMatricula.Size = New System.Drawing.Size(58, 13)
        Me.lblMatricula.TabIndex = 6
        Me.lblMatricula.Text = "Matrícula"
        '
        'txtCifTransp
        '
        Me.TryDataBinding(txtCifTransp, New System.Windows.Forms.Binding("Text", Me, "CifTransportista", True))
        Me.txtCifTransp.DisabledBackColor = System.Drawing.Color.White
        Me.txtCifTransp.Location = New System.Drawing.Point(385, 97)
        Me.txtCifTransp.Name = "txtCifTransp"
        Me.txtCifTransp.Size = New System.Drawing.Size(75, 21)
        Me.txtCifTransp.TabIndex = 16
        '
        'txtDniConductor
        '
        Me.TryDataBinding(txtDniConductor, New System.Windows.Forms.Binding("Text", Me, "DNIConductor", True))
        Me.txtDniConductor.DisabledBackColor = System.Drawing.Color.White
        Me.txtDniConductor.Location = New System.Drawing.Point(385, 120)
        Me.txtDniConductor.Name = "txtDniConductor"
        Me.txtDniConductor.Size = New System.Drawing.Size(75, 21)
        Me.txtDniConductor.TabIndex = 18
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(282, 101)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 13)
        Me.Label6.TabIndex = 193
        Me.Label6.Text = "Cif Tansp."
        '
        'lblDniConductor
        '
        Me.lblDniConductor.Location = New System.Drawing.Point(282, 124)
        Me.lblDniConductor.Name = "lblDniConductor"
        Me.lblDniConductor.Size = New System.Drawing.Size(89, 13)
        Me.lblDniConductor.TabIndex = 4
        Me.lblDniConductor.Text = "Dni Conductor"
        '
        'lblFwiModoTransporte
        '
        Me.lblFwiModoTransporte.Location = New System.Drawing.Point(6, 43)
        Me.lblFwiModoTransporte.Name = "lblFwiModoTransporte"
        Me.lblFwiModoTransporte.Size = New System.Drawing.Size(102, 13)
        Me.lblFwiModoTransporte.TabIndex = 0
        Me.lblFwiModoTransporte.Tag = ""
        Me.lblFwiModoTransporte.Text = "Modo Transporte"
        Me.lblFwiModoTransporte.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtConductor
        '
        Me.TryDataBinding(txtConductor, New System.Windows.Forms.Binding("Text", Me, "Conductor", True))
        Me.txtConductor.DisabledBackColor = System.Drawing.Color.White
        Me.txtConductor.Location = New System.Drawing.Point(114, 120)
        Me.txtConductor.Name = "txtConductor"
        Me.txtConductor.Size = New System.Drawing.Size(162, 21)
        Me.txtConductor.TabIndex = 17
        '
        'lblcFwiModoTransporte
        '
        Me.lblcFwiModoTransporte.Location = New System.Drawing.Point(193, 38)
        Me.lblcFwiModoTransporte.Name = "lblcFwiModoTransporte"
        Me.lblcFwiModoTransporte.Size = New System.Drawing.Size(267, 23)
        Me.lblcFwiModoTransporte.TabIndex = 1
        '
        'lblConductor
        '
        Me.lblConductor.Location = New System.Drawing.Point(7, 124)
        Me.lblConductor.Name = "lblConductor"
        Me.lblConductor.Size = New System.Drawing.Size(66, 13)
        Me.lblConductor.TabIndex = 2
        Me.lblConductor.Text = "Conductor"
        '
        'FwiModoTransporte
        '
        Me.TryDataBinding(FwiModoTransporte, New System.Windows.Forms.Binding("Text", Me, "IDModoTransporte", True))
        Me.FwiModoTransporte.DisabledBackColor = System.Drawing.Color.White
        Me.FwiModoTransporte.EntityName = "ModoTrasporte"
        Me.FwiModoTransporte.Location = New System.Drawing.Point(114, 43)
        Me.FwiModoTransporte.Name = "FwiModoTransporte"
        Me.FwiModoTransporte.PrimaryDataFields = "IDModoTransporte"
        Me.FwiModoTransporte.SecondaryDataFields = "IDModoTransporte"
        Me.FwiModoTransporte.Size = New System.Drawing.Size(75, 23)
        Me.FwiModoTransporte.TabIndex = 12
        Me.FwiModoTransporte.ViewName = "tbMaestroModoTrasporte"
        '
        'lblfwiIdCondEnvio
        '
        Me.lblfwiIdCondEnvio.Location = New System.Drawing.Point(7, 18)
        Me.lblfwiIdCondEnvio.Name = "lblfwiIdCondEnvio"
        Me.lblfwiIdCondEnvio.Size = New System.Drawing.Size(55, 13)
        Me.lblfwiIdCondEnvio.TabIndex = 12
        Me.lblfwiIdCondEnvio.Tag = "IdRec=4403;"
        Me.lblfwiIdCondEnvio.Text = "C. Envío"
        Me.lblfwiIdCondEnvio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblcfwiIdCondEnvio
        '
        Me.lblcfwiIdCondEnvio.Location = New System.Drawing.Point(193, 13)
        Me.lblcfwiIdCondEnvio.Name = "lblcfwiIdCondEnvio"
        Me.lblcfwiIdCondEnvio.Size = New System.Drawing.Size(267, 23)
        Me.lblcfwiIdCondEnvio.TabIndex = 13
        '
        'fwiIdCondEnvio
        '
        Me.TryDataBinding(fwiIdCondEnvio, New System.Windows.Forms.Binding("Text", Me, "IDCondicionEnvio", True))
        Me.fwiIdCondEnvio.DisabledBackColor = System.Drawing.Color.White
        Me.fwiIdCondEnvio.EntityName = "CondicionEnvio"
        Me.fwiIdCondEnvio.Location = New System.Drawing.Point(114, 18)
        Me.fwiIdCondEnvio.Name = "fwiIdCondEnvio"
        Me.fwiIdCondEnvio.PrimaryDataFields = "IDCondicionEnvio"
        Me.fwiIdCondEnvio.SecondaryDataFields = "IDCondicionEnvio"
        Me.fwiIdCondEnvio.Size = New System.Drawing.Size(75, 23)
        Me.fwiIdCondEnvio.TabIndex = 11
        Me.fwiIdCondEnvio.ViewName = "tbMaestroCondicionEnvio"
        '
        'lblfwiIDFormaEnvio
        '
        Me.lblfwiIDFormaEnvio.Location = New System.Drawing.Point(7, 68)
        Me.lblfwiIDFormaEnvio.Name = "lblfwiIDFormaEnvio"
        Me.lblfwiIDFormaEnvio.Size = New System.Drawing.Size(50, 13)
        Me.lblfwiIDFormaEnvio.TabIndex = 14
        Me.lblfwiIDFormaEnvio.Tag = "IdRec=4404;"
        Me.lblfwiIDFormaEnvio.Text = "F. Envío"
        Me.lblfwiIDFormaEnvio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblcfwiIDFormaEnvio
        '
        Me.lblcfwiIDFormaEnvio.Location = New System.Drawing.Point(221, 68)
        Me.lblcfwiIDFormaEnvio.Name = "lblcfwiIDFormaEnvio"
        Me.lblcfwiIDFormaEnvio.Size = New System.Drawing.Size(239, 23)
        Me.lblcfwiIDFormaEnvio.TabIndex = 15
        '
        'fwiIDFormaEnvio
        '
        Me.TryDataBinding(fwiIDFormaEnvio, New System.Windows.Forms.Binding("Text", Me, "IDFormaEnvio", True))
        Me.fwiIDFormaEnvio.DisabledBackColor = System.Drawing.Color.White
        Me.fwiIDFormaEnvio.EntityName = "FormaEnvio"
        Me.fwiIDFormaEnvio.Location = New System.Drawing.Point(114, 68)
        Me.fwiIDFormaEnvio.Name = "fwiIDFormaEnvio"
        Me.fwiIDFormaEnvio.PrimaryDataFields = "IDFormaEnvio"
        Me.fwiIDFormaEnvio.SecondaryDataFields = "IDFormaEnvio"
        Me.fwiIDFormaEnvio.Size = New System.Drawing.Size(75, 23)
        Me.fwiIDFormaEnvio.TabIndex = 13
        Me.fwiIDFormaEnvio.ViewName = "tbMaestroFormaEnvio"
        '
        'cmbDetalles
        '
        cmbDetalles_DesignTimeLayout.LayoutString = resources.GetString("cmbDetalles_DesignTimeLayout.LayoutString")
        Me.cmbDetalles.DesignTimeLayout = cmbDetalles_DesignTimeLayout
        Me.cmbDetalles.DisabledBackColor = System.Drawing.Color.White
        Me.cmbDetalles.EntityName = "FormaEnvioDetalle"
        Me.cmbDetalles.Location = New System.Drawing.Point(195, 68)
        Me.cmbDetalles.MaximumSize = New System.Drawing.Size(19, 21)
        Me.cmbDetalles.Name = "cmbDetalles"
        Me.cmbDetalles.PrimaryDataFields = "IDFormaEnvioDetalle"
        Me.cmbDetalles.SecondaryDataFields = "IDFormaEnvioDetalle"
        Me.cmbDetalles.SelectedIndex = -1
        Me.cmbDetalles.SelectedItem = Nothing
        Me.cmbDetalles.Size = New System.Drawing.Size(19, 21)
        Me.cmbDetalles.TabIndex = 14
        '
        'TabPagePicAnotaciones
        '
        Me.TabPagePicAnotaciones.Controls.Add(Me.WLFrame8)
        Me.TabPagePicAnotaciones.Key = "Anotaciones"
        Me.TabPagePicAnotaciones.Location = New System.Drawing.Point(1, 21)
        Me.TabPagePicAnotaciones.Name = "TabPagePicAnotaciones"
        Me.TabPagePicAnotaciones.Size = New System.Drawing.Size(784, 297)
        Me.TabPagePicAnotaciones.TabStop = True
        Me.TabPagePicAnotaciones.Text = "Anotaciones"
        Me.TabPagePicAnotaciones.Visible = False
        '
        'WLFrame8
        '
        Me.WLFrame8.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WLFrame8.Controls.Add(Me.fwiTextoAlbaran)
        Me.WLFrame8.Location = New System.Drawing.Point(8, 8)
        Me.WLFrame8.Name = "WLFrame8"
        Me.WLFrame8.Size = New System.Drawing.Size(770, 320)
        Me.WLFrame8.TabIndex = 37
        Me.WLFrame8.TabStop = False
        Me.WLFrame8.Tag = "IdRec=4421;"
        Me.WLFrame8.Text = "Comentarios"
        '
        'fwiTextoAlbaran
        '
        Me.fwiTextoAlbaran.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TryDataBinding(fwiTextoAlbaran, New System.Windows.Forms.Binding("Text", Me, "Texto", True))
        Me.fwiTextoAlbaran.DisabledBackColor = System.Drawing.Color.White
        Me.fwiTextoAlbaran.Location = New System.Drawing.Point(41, 44)
        Me.fwiTextoAlbaran.Multiline = True
        Me.fwiTextoAlbaran.Name = "fwiTextoAlbaran"
        Me.fwiTextoAlbaran.Size = New System.Drawing.Size(686, 242)
        Me.fwiTextoAlbaran.TabIndex = 14
        '
        'TabPagePicSeguimiento
        '
        Me.TabPagePicSeguimiento.Controls.Add(Me.WLFactGeneradas)
        Me.TabPagePicSeguimiento.Controls.Add(Me.WLFrame9)
        Me.TabPagePicSeguimiento.Key = "Seguimiento"
        Me.TabPagePicSeguimiento.Location = New System.Drawing.Point(1, 21)
        Me.TabPagePicSeguimiento.Name = "TabPagePicSeguimiento"
        Me.TabPagePicSeguimiento.Size = New System.Drawing.Size(784, 294)
        Me.TabPagePicSeguimiento.TabStop = True
        Me.TabPagePicSeguimiento.Text = "Seguimiento"
        Me.TabPagePicSeguimiento.Visible = False
        '
        'WLFactGeneradas
        '
        Me.WLFactGeneradas.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.WLFactGeneradas.Controls.Add(Me.lstFacturasGeneradas)
        Me.WLFactGeneradas.Location = New System.Drawing.Point(387, 8)
        Me.WLFactGeneradas.Name = "WLFactGeneradas"
        Me.WLFactGeneradas.Size = New System.Drawing.Size(390, 284)
        Me.WLFactGeneradas.TabIndex = 41
        Me.WLFactGeneradas.TabStop = False
        Me.WLFactGeneradas.Tag = "IdRec=5445;"
        Me.WLFactGeneradas.Text = "Facturas Generadas"
        '
        'lstFacturasGeneradas
        '
        Me.lstFacturasGeneradas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstFacturasGeneradas.Location = New System.Drawing.Point(3, 17)
        Me.lstFacturasGeneradas.Name = "lstFacturasGeneradas"
        Me.lstFacturasGeneradas.Size = New System.Drawing.Size(384, 264)
        Me.lstFacturasGeneradas.TabIndex = 0
        '
        'WLFrame9
        '
        Me.WLFrame9.Controls.Add(Me.lblfwiEstado)
        Me.WLFrame9.Controls.Add(Me.fwiEstado)
        Me.WLFrame9.Location = New System.Drawing.Point(5, 3)
        Me.WLFrame9.Name = "WLFrame9"
        Me.WLFrame9.Size = New System.Drawing.Size(248, 45)
        Me.WLFrame9.TabIndex = 40
        Me.WLFrame9.TabStop = False
        Me.WLFrame9.Tag = "IdRec=0;"
        '
        'lblfwiEstado
        '
        Me.lblfwiEstado.Location = New System.Drawing.Point(24, 17)
        Me.lblfwiEstado.Name = "lblfwiEstado"
        Me.lblfwiEstado.Size = New System.Drawing.Size(45, 13)
        Me.lblfwiEstado.TabIndex = 102
        Me.lblfwiEstado.Tag = "IdRec=4405;"
        Me.lblfwiEstado.Text = "Estado"
        '
        'fwiEstado
        '
        Me.fwiEstado.DisabledBackColor = System.Drawing.Color.White
        Me.fwiEstado.Enabled = False
        Me.fwiEstado.Location = New System.Drawing.Point(97, 17)
        Me.fwiEstado.Name = "fwiEstado"
        Me.fwiEstado.ReadOnly = True
        Me.fwiEstado.Size = New System.Drawing.Size(109, 21)
        Me.fwiEstado.TabIndex = 101
        Me.fwiEstado.TabStop = False
        '
        'MntoAlbaranCompra
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(794, 570)
        Me.EntityName = "AlbaranCompraCabecera"
        Me.FindTextField = "NAlbaran"
        Me.LastUsedDescFields = "NAlbaran"
        Me.Name = "MntoAlbaranCompra"
        Me.NavigationFields = "NAlbaran"
        Me.ViewName = "frmMntoAlbaranCompra"
        CType(Me.ToolBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MenuBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainPanel.ResumeLayout(False)
        Me.MainPanel.PerformLayout()
        Me.picActualizacionesPendientes.ResumeLayout(False)
        Me.picActualizacionesPendientes.PerformLayout()
        Me.PicCabecera.ResumeLayout(False)
        Me.PicCabecera.PerformLayout()
        Me.pnlLineas.ResumeLayout(False)
        CType(Me.TabAlbaranes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabAlbaranes.ResumeLayout(False)
        Me.TabPagePicLineas.ResumeLayout(False)
        Me.TabPagePicLineas.PerformLayout()
        CType(Me.jngLineaAlbaran, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.TabPagePicCentroRecepcion.ResumeLayout(False)
        Me.TabPagePicCentroRecepcion.PerformLayout()
        Me.TabPagePicDatosEconomicos.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.FrmResEcon.ResumeLayout(False)
        Me.FrmResEcon.PerformLayout()
        CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LineDescuentos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.WLFrame4.ResumeLayout(False)
        Me.WLFrame4.PerformLayout()
        Me.WLFrame3.ResumeLayout(False)
        Me.WLFrame3.PerformLayout()
        Me.UiTabEnvio.ResumeLayout(False)
        Me.FrmDAA.ResumeLayout(False)
        Me.FrmDAA.PerformLayout()
        Me.FraPE.ResumeLayout(False)
        Me.FraPE.PerformLayout()
        Me.WLFrame7.ResumeLayout(False)
        Me.WLFrame7.PerformLayout()
        CType(Me.cmbDetalles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPagePicAnotaciones.ResumeLayout(False)
        Me.WLFrame8.ResumeLayout(False)
        Me.WLFrame8.PerformLayout()
        Me.TabPagePicSeguimiento.ResumeLayout(False)
        Me.WLFactGeneradas.ResumeLayout(False)
        Me.WLFrame9.ResumeLayout(False)
        Me.WLFrame9.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Const cnABRIRARTICULO As String = "Abrir Artículo"
    Private Const cnABRIRCONTRATOCOMPRA As String = "Abrir Contrato Compra"
    Private Const cnABRIRPEDIDOCOMPRA As String = "Abrir Pedido Compra"
    Private Const cnABRIROBRA As String = "Abrir Proyecto"
    Private Const cnABRIRORDENFABRICACION As String = "Abrir Orden Fabricación"
    Private Const cnABRIRORDENTRABAJO As String = "Abrir Orden Trabajo"
    Private Const cnABRIRACTIVO As String = "Abrir Activo"

    Protected Const cnCONTABILIZAR As String = "Contabilizar Lineas Albarán"
    Protected Const cnDESCONTABILIZAR As String = "Descontabilizar Lineas Albarán"
    Protected Const cnCONTABILIZAR_LINEA As String = "Contabilizar Linea Albarán"
    Protected Const cnDESCONTABILIZAR_LINEA As String = "Descontabilizar Linea Albarán"

    Protected mstrIDEjercicio As String
    Private marrLineasPadre() As String
    Private mblnCAnalitica, mblnEliminarLineasHijas, mGestionNumeroSerieConActivos As Boolean
    Private mblnSAAS As Boolean
    Private mBlnEsBodega As Boolean
    Protected mblnActualizaStockAuto As Boolean

    Private mblnCambioPrecioManual As Boolean
    Private mPrecioAnterior As Double

    Private mblnStkDobleUnidad As Boolean
    Private mQInterna2 As Double
    Private mblnComprobarQInterna2 As Boolean

    Private mblnValidatingProv As Boolean
    Private MIDArticuloRef As String

    Protected mblnContabilidadMultiple As Boolean
    Protected mblnGestionInventarioPermanente As Boolean

    Private WithEvents FwBusquedaDireccion As AdvancedSearch

    Protected MDatArt As New AlbaranCompraLinea.DataBuscarArt

#Region " Load "

    Private Sub MntoAlbaranCompra_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        If Me.RecordsState = RecordsState.Saved Then Me.GotoRecord(DataProviderActions.GoRecord, , Me.CurrentData)
    End Sub

    Private Sub MntoAlbaranCompra_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Not Me.DesignMode Then
            LoadAdvancedSearchSettings()
            LoadERPData()
            LoadEnums()
            LoadToolActions()
            LoadGridActions()
            LoadDecimalesControlesCambio()
        End If
    End Sub

    Private Sub LoadAdvancedSearchSettings()
        FwBusquedaDireccion = New AdvancedSearch
        FwBusquedaDireccion.EntityName = "ProveedorDireccion"
    End Sub

    Private Sub LoadEnums()
        EnumData.PopulateValueList("enumaclEstadoFactura", jngLineaAlbaran.Columns("EstadoFactura"))
        EnumData.PopulateValueList("enumaclEstadoStock", jngLineaAlbaran.Columns("EstadoStock"))
        EnumData.PopulateValueList("enumfclTipoGastoObra", jngLineaAlbaran.Columns("TipoGastoObra"))
        EnumData.PopulateValueList("enumaclTipoLineaAlbaran", jngLineaAlbaran.Columns("TipoLineaCompra"))
        If mblnGestionInventarioPermanente Then EnumData.PopulateValueList("enumContabilizado", jngLineaAlbaran.Columns("Contabilizado"))
    End Sub

    Private Sub LoadERPData()
        Dim P As New Parametro
        mblnCAnalitica = P.CAnaliticPredet()
        mGestionNumeroSerieConActivos = P.GestionNumeroSerieConActivos()
        mblnSAAS = P.ExpertisSAAS
        mblnStkDobleUnidad = P.GestionDobleUnidad
        mblnContabilidadMultiple = P.ContabilidadMultiple
        mblnGestionInventarioPermanente = P.GestionInventarioPermanente
        mblnActualizaStockAuto = P.ActAutomaticaAlbCompra
        mBlnEsBodega = New ParametroGeneral().GestionBodegas
        jngLineaAlbaran.Columns("Contabilizado").Visible = mblnGestionInventarioPermanente
        jngLineaAlbaran.Columns("BotonAnalitica").Visible = mblnCAnalitica

        SettingDobleUnidad()
        DescripcionMonedasAB()

        If mblnSAAS Then
            Me.jngLineaAlbaran.Columns("BotonGastos").Visible = False
            Me.jngLineaAlbaran.Columns("Calidad").Visible = False
        End If
    End Sub

    Private Sub SettingDobleUnidad()
        If Me.jngLineaAlbaran.Columns.Contains("QInterna2") Then
            Me.jngLineaAlbaran.Columns("QInterna2").Visible = mblnStkDobleUnidad
            Me.jngLineaAlbaran.Columns("QInterna2").Position = Me.jngLineaAlbaran.Columns("QInterna").Position + 1
        End If
    End Sub

    Private Sub LoadToolActions()
        If Not mblnSAAS Then
            Me.FormActions.Add("Calcular Precio Optimo", AddressOf AccionPrecioOptimo, ExpertisApp.GetIcon("calculator.ico"))
            Me.AddSeparator()
            If mblnGestionInventarioPermanente Then
                Me.FormActions.Add(cnCONTABILIZAR, AddressOf AccionContabilizarLineasAlbaran) ', ExpertisApp.GetIcon("xConta.ico"))
                Me.FormActions.Add(cnDESCONTABILIZAR, AddressOf AccionDescontabilizarLineasAlbaran) ', ExpertisApp.GetIcon("xConta.ico"))
            End If
        End If
    End Sub

    Private Sub LoadGridActions()
        With jngLineaAlbaran
            .Actions.Add(cnABRIRARTICULO, AddressOf CargarMantenimientoArticulo, ExpertisApp.GetIcon("xArticulos.ico"))
            .Actions.Add(cnABRIRCONTRATOCOMPRA, AddressOf CargarMantenimientoContrato, ExpertisApp.GetIcon("xEstadistica.ico"))
            .Actions.Add(cnABRIRPEDIDOCOMPRA, AddressOf CargarMantenimientoPedidoCompra, ExpertisApp.GetIcon("xPedidoCompra.ico"))
            .Actions.Add(cnABRIROBRA, AddressOf CargarMantenimientoObra, ExpertisApp.GetIcon("xProyectos.ico"))
            .Actions.Add(cnABRIRORDENFABRICACION, AddressOf CargarMantenimientoOrdenFabricacion, ExpertisApp.GetIcon("xOrdenesFabricacion.ico"))
            .Actions.Add(cnABRIRORDENTRABAJO, AddressOf CargarMantenimientoOrdenTrabajo, ExpertisApp.GetIcon("xOrdenesFabricacion.ico"))
            .Actions.Add(cnABRIRACTIVO, AddressOf CargarMantenimientoActivo, ExpertisApp.GetIcon("xActivos.ico"))
            If mblnGestionInventarioPermanente Then
                .AddSeparator()
                .Actions.Add(cnCONTABILIZAR_LINEA, AddressOf AccionContabilizarLineaAlbaran, ExpertisApp.GetIcon("xConta.ico"))
                .Actions.Add(cnDESCONTABILIZAR_LINEA, AddressOf AccionDescontabilizarLineaAlbaran, ExpertisApp.GetIcon("xConta.ico"))
            End If
            If mBlnEsBodega Then
                .AddSeparator()
                .Actions.Add("Abrir Trazabilidad", AddressOf AccionAbrirTrazabilidad, ExpertisApp.GetIcon("xConsultaMovim.ico"))
            End If
        End With
    End Sub

    Private Sub LoadDecimalesControlesCambio()
        Dim FormatoCambios As String = "#,##0.########"
        fwiCambioA.FormatString = FormatoCambios
        fwiCambioB.FormatString = FormatoCambios
    End Sub

#End Region

#Region " Acciones Toolbar "

    Private Sub AccionPrecioOptimo()
        If IsNumeric(Me.CurrentRow("IDAlbaran")) Then
            Me.Cursor = Cursors.WaitCursor
            ExpertisApp.ExecuteTask(Of Integer)(AddressOf AlbaranCompraCabecera.PrecioOptimo, Me.CurrentRow("IDAlbaran"))
            Dim _filter As New Filter
            _filter.Add("IDAlbaran", Me.CurrentRow("IDAlbaran"))
            Me.GotoRecord(DataProviderActions.Refresh, _filter)
            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub BusquedaDireccion()
        FwBusquedaDireccion.Open()
    End Sub

    Private Sub AccionContabilizarLineasAlbaran()
        Dim LineasContabilizar As List(Of DataRow) = (From c In CType(Me.jngLineaAlbaran.DataSource, DataTable) _
                                                      Where Not c.IsNull("EstadoFactura") AndAlso _
                                                            c("EstadoFactura") = enumaclEstadoFactura.aclNoFacturado AndAlso _
                                                            Not c.IsNull("EstadoStock") AndAlso _
                                                             c("EstadoStock") = enumaclEstadoStock.aclActualizado Or (c("EstadoStock") = enumaclEstadoStock.aclSinGestion And c("Especial") = True) AndAlso _
                                                             Not c.IsNull("Contabilizado") AndAlso _
                                                            c("Contabilizado") <> enumContabilizado.Contabilizado).ToList()
        If LineasContabilizar.Count = 0 Then
            ExpertisApp.GenerateMessage("No hay lineas para contabilizar.", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Dim IDLineasAlbaran(-1) As Integer
            For Each drLinea As DataRow In LineasContabilizar
                ReDim Preserve IDLineasAlbaran(IDLineasAlbaran.Length)
                IDLineasAlbaran(IDLineasAlbaran.Length - 1) = drLinea("IDLineaAlbaran")
            Next

            Dim SimInfo As New DataSimulacionContableInfoAC(enumTipoContabilizacion.tcAlbaranCompra, IDLineasAlbaran)
            SimInfo.Caption = "Simulación Contable - ALBARAN COMPRA -"
            Dim oFrm As Form = ExpertisApp.OpenForm("CISIMUCONT", , SimInfo, Me)
            AddHandler oFrm.Closed, AddressOf FrmActionClosed
        End If
    End Sub

    Private Sub FrmActionClosed(ByVal sender As Object, ByVal e As System.EventArgs)
        RemoveHandler CType(sender, Form).Closed, AddressOf FrmActionClosed
        Me.Requery.InvokeOnClick()
    End Sub


    Private Sub AccionDescontabilizarLineasAlbaran()
        Dim LineasDescontabilizar As List(Of Object) = (From c In CType(Me.jngLineaAlbaran.DataSource, DataTable) _
                                                         Where Not c.IsNull("EstadoFactura") AndAlso _
                                                            c("EstadoFactura") = enumaclEstadoFactura.aclNoFacturado AndAlso _
                                                            Not c.IsNull("EstadoStock") AndAlso _
                                                            c("EstadoStock") = enumaclEstadoStock.aclActualizado Or (c("EstadoStock") = enumaclEstadoStock.aclSinGestion And c("Especial") = True) AndAlso _
                                                            Not c.IsNull("Contabilizado") AndAlso _
                                                           c("Contabilizado") <> enumContabilizado.NoContabilizado _
                                                        Select c("IDLineaAlbaran") Distinct).ToList()
        If LineasDescontabilizar.Count = 0 Then
            ExpertisApp.GenerateMessage("No hay lineas para Descontabilizar.", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Dim frm As New frmDescontabilizar
            frm.LineasAlbaran = LineasDescontabilizar
            If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                Me.Requery.InvokeOnClick()
            End If
        End If
    End Sub

    Private Sub AccionContabilizarLineaAlbaran()
        Dim LineasContabilizar As List(Of DataRow) = (From c In CType(Me.jngLineaAlbaran.DataSource, DataTable) _
                                                      Where Not c.IsNull("EstadoFactura") AndAlso _
                                                            c("EstadoFactura") = enumaclEstadoFactura.aclNoFacturado AndAlso _
                                                            Not c.IsNull("EstadoStock") AndAlso _
                                                            c("EstadoStock") = enumaclEstadoStock.aclActualizado Or (c("EstadoStock") = enumaclEstadoStock.aclSinGestion And c("Especial") = True) AndAlso _
                                                             Not c.IsNull("Contabilizado") AndAlso _
                                                            c("Contabilizado") <> enumContabilizado.Contabilizado AndAlso _
                                                            c("IDLineaAlbaran") = jngLineaAlbaran.Value("IDLineaAlbaran")).ToList()
        If LineasContabilizar.Count = 0 Then
            ExpertisApp.GenerateMessage("No es posible Contabilizar la linea.", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Dim IDLineasAlbaran(0) As Integer
            IDLineasAlbaran(0) = jngLineaAlbaran.Value("IDLineaAlbaran")

            Dim SimInfo As New DataSimulacionContableInfoAC(enumTipoContabilizacion.tcAlbaranCompra, IDLineasAlbaran)
            SimInfo.Caption = "Simulación Contable - ALBARAN COMPRA -"
            Dim oFrm As Form = ExpertisApp.OpenForm("CISIMUCONT", , SimInfo, Me)
            AddHandler oFrm.Closed, AddressOf FrmActionClosed
        End If
    End Sub

    Private Sub AccionDescontabilizarLineaAlbaran()
        Dim LineasDescontabilizar As List(Of DataRow) = (From c In CType(Me.jngLineaAlbaran.DataSource, DataTable) _
                                                         Where Not c.IsNull("EstadoFactura") AndAlso _
                                                                c("EstadoFactura") = enumaclEstadoFactura.aclNoFacturado AndAlso _
                                                                Not c.IsNull("EstadoStock") AndAlso _
                                                                 c("EstadoStock") = enumaclEstadoStock.aclActualizado Or (c("EstadoStock") = enumaclEstadoStock.aclSinGestion And c("Especial") = True) AndAlso _
                                                                Not c.IsNull("Contabilizado") AndAlso _
                                                                c("Contabilizado") <> enumContabilizado.NoContabilizado AndAlso _
                                                                c("IDLineaAlbaran") = jngLineaAlbaran.Value("IDLineaAlbaran")).ToList()
        If LineasDescontabilizar.Count = 0 Then
            ExpertisApp.GenerateMessage("No es posible Descontabilizar la linea.", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Dim lst As New List(Of Object)
            lst.Add(jngLineaAlbaran.Value("IDLineaAlbaran"))

            Dim frm As New frmDescontabilizar
            frm.LineasAlbaran = lst
            If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                Me.Requery.InvokeOnClick()
            End If
        End If
    End Sub

    Private Sub AccionAbrirTrazabilidad()
        Dim ht As New Hashtable
        ht.Add("Componente", True)
        ht.Add("IDArticulo", Me.jngLineaAlbaran.GetValue("IDArticulo"))
        Dim DtAlbLote As DataTable = New AlbaranCompraLote().Filter(New FilterItem("IDLineaAlbaran", FilterOperator.Equal, Me.jngLineaAlbaran.GetValue("IDLineaAlbaran")))
        If Not DtAlbLote Is Nothing AndAlso DtAlbLote.Rows.Count = 1 Then
            ht.Add("Lote", DtAlbLote.Rows(0)("Lote"))
        End If
        ExpertisApp.OpenForm("BDGCITR", , ht)
    End Sub

#End Region

#Region " Acciones Grid "

    Private Sub CargarMantenimientoArticulo()
        If Length(jngLineaAlbaran.GetValue("IDArticulo")) > 0 Then
            ExpertisApp.OpenForm("MARTICULO", New StringFilterItem("IDArticulo", FilterOperator.Equal, jngLineaAlbaran.GetValue("IDArticulo")))
        End If
    End Sub

    Private Sub CargarMantenimientoContrato()
        If Length(jngLineaAlbaran.GetValue("IdContrato")) > 0 Then
            ExpertisApp.OpenForm("MCONTRATO", New StringFilterItem("IdContrato", FilterOperator.Equal, jngLineaAlbaran.GetValue("IdContrato")))
        End If
    End Sub

    Private Sub CargarMantenimientoObra()
        If Length(jngLineaAlbaran.GetValue("IDObra")) > 0 Then
            ExpertisApp.OpenForm("MGEO", New NumberFilterItem("IDObra", FilterOperator.Equal, jngLineaAlbaran.GetValue("IDObra")))
        End If
    End Sub

    Private Sub CargarMantenimientoPedidoCompra()
        If Length(jngLineaAlbaran.GetValue("IDPedido")) > 0 Then
            ExpertisApp.OpenForm("MPEDC", New NumberFilterItem("IdPedido", FilterOperator.Equal, jngLineaAlbaran.GetValue("IdPedido")))
        End If
    End Sub

    Private Sub CargarMantenimientoOrdenFabricacion()
        If Length(jngLineaAlbaran.GetValue("IDOrden")) > 0 Then
            ExpertisApp.OpenForm("MORDFABR", New NumberFilterItem("IDOrden", FilterOperator.Equal, jngLineaAlbaran.GetValue("IDOrden")))
        End If
    End Sub

    Private Sub CargarMantenimientoOrdenTrabajo()
        If Length(jngLineaAlbaran.GetValue("IDOT")) > 0 Then
            ExpertisApp.OpenForm("MNTOOT", New NumberFilterItem("IDOT", FilterOperator.Equal, jngLineaAlbaran.GetValue("IDOT")))
        End If
    End Sub

    Private Sub CargarMantenimientoActivo()
        If Length(jngLineaAlbaran.GetValue("Lote")) > 0 Then
            If Not Nz(jngLineaAlbaran.GetValue("NSerieObligatorio"), False) Then
                ExpertisApp.GenerateMessage("El artículo no lleva Gestión de NºSerie.", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                ExpertisApp.OpenForm("MACT", New StringFilterItem("IDActivo", jngLineaAlbaran.GetValue("Lote")))
            End If
        End If
    End Sub

    Private Sub CargarPrecinta()
        With jngLineaAlbaran
            Dim strIDArticulo As String = .GetValue("IDArticulo")
            If (Length(strIDArticulo) > 0) Then
                Dim ht As New Hashtable
                ht.Add("IDArticulo", strIDArticulo)
                AccionAbrirConsultaPrecintas(ht)
            End If
        End With
    End Sub

    Private Const CN_CONSULTA As String = "BDGCIPREC"
    Private Sub AccionAbrirConsultaPrecintas(ByVal params As Hashtable)
        If (ExpertisApp.IsFormOpen(CN_CONSULTA)) Then
            ExpertisApp.CloseForm(CN_CONSULTA)
        End If
        ExpertisApp.OpenForm(CN_CONSULTA, , params)
    End Sub
#End Region

    Private Function ActualizacionesPendientes(ByVal strIN As String) As Boolean
        Dim strSelect As String
        Dim dt As DataTable
        Dim NvnApp As BE.DataEngine

        If Len(strIN) > 0 Then
            strSelect = "COUNT(IDOFcontrol) AS RegPendientes"
            Dim f As New Filter
            f.Add(New InListFilterItem("IDOFcontrol", Split(strIN, ","), FilterType.String))
            f.Add(New IsNullFilterItem("IDMovimiento"))
            f.Add(New IsNullFilterItem("IDLineaMovimiento"))
            f.Add(New BooleanFilterItem("GestionStock", True))
            If Len(strSelect) > 0 Then
                NvnApp = New BE.DataEngine
                dt = NvnApp.Filter("vCTLCIOFControlEstructura", f, strSelect)
                If Not dt Is Nothing Then
                    If dt.Rows.Count > 0 Then
                        ActualizacionesPendientes = (dt.Rows(0)("RegPendientes") > 0)
                    End If
                End If
            End If
        End If

    End Function

    Private Sub ChequearActualizacionesPendientes()
        Dim blnShowMsg As Boolean
        Dim strIN As String = String.Empty

        If Not jngLineaAlbaran.DataSource Is Nothing Then
            Dim dtGrid As DataTable = jngLineaAlbaran.DataSource.Clone

            If dtGrid.Rows.Count > 0 Then
                For Each dr As DataRow In dtGrid.Rows
                    If Not IsEmptyValue(dr("IDOrdenRuta")) Then
                        If Not IsEmptyValue(dr("IDOFControl")) Then
                            If dr("IDOFControl") > 0 Then
                                If Len(strIN) > 0 Then strIN = strIN & ","
                                strIN = strIN & dr("IDOFControl")
                            End If
                        End If
                    End If
                Next
                If Len(strIN) > 0 Then
                    If Len(lblRegPendientes.Text) = 0 Then
                        Dim strTexto As String = "Existen operaciones de subcontratación pendientes de actualizar el stock. Consulte los movimientos de stock asociados a la Orden de Fabricación."
                        If Len(lblRegPendientes.Text) = 0 Then
                            strTexto = "Existen operaciones de subcontratación pendientes de actualizar el stock. Compruebe los movimientos de stock asociados a la Orden de Fabricación."
                        End If
                        lblRegPendientes.Text = ExpertisApp.Traslate(strTexto)
                    End If

                    blnShowMsg = ActualizacionesPendientes(strIN)
                End If

                If blnShowMsg Then
                    If Not picActualizacionesPendientes.Visible Then
                        jngLineaAlbaran.Height = jngLineaAlbaran.Height - picActualizacionesPendientes.Height
                        picActualizacionesPendientes.Left = jngLineaAlbaran.Left
                        picActualizacionesPendientes.Top() = jngLineaAlbaran.Top + jngLineaAlbaran.Height
                        picActualizacionesPendientes.Width() = jngLineaAlbaran.Width
                        picActualizacionesPendientes.Visible = True
                    End If
                Else
                    If picActualizacionesPendientes.Visible Then
                        jngLineaAlbaran.Height = jngLineaAlbaran.Height + picActualizacionesPendientes.Height
                        picActualizacionesPendientes.Visible = False
                    End If
                End If
            End If
        End If
    End Sub

    Private Function EsSubcontratacion() As Boolean
        '//Para un producto terminado los lotes se introducen automaticamente en el proceso de actualizacion de stocks.
        '//Para lineas componentes de subcontratacion los lotes se introduciran en los movimientos de stock de la orden.
        If jngLineaAlbaran.GetRow.RowType = RowType.Record Then
            If jngLineaAlbaran.Value("TipoLineaCompra") = enumaclTipoLineaAlbaran.aclSubcontratacion Then
                'Or jngLineaAlbaran.Value("TipoLineaCompra") = enumaclTipoLineaAlbaran.aclComponente Then
                EsSubcontratacion = (IsNumeric(jngLineaAlbaran.GetValue("IDOrdenRuta")) AndAlso jngLineaAlbaran.GetValue("IDOrdenRuta") <> 0)
            End If
        End If
    End Function

    Private Function TipoMovimiento() As enumTipoMovimiento
        Dim tipo As enumTipoMovimiento = enumTipoMovimiento.tmEntAlbaranCompra

        If jngLineaAlbaran.GetValue("TipoLineaCompra") = enumaclTipoLineaAlbaran.aclSubcontratacion Then
            tipo = enumTipoMovimiento.tmEntSubcontratacion
            If Length(jngLineaAlbaran.GetValue("IDOrdenRuta")) Then
                tipo = enumTipoMovimiento.tmEntFabrica
            End If
        ElseIf jngLineaAlbaran.GetValue("TipoLineaCompra") = enumaclTipoLineaAlbaran.aclComponente Then
            If Length(jngLineaAlbaran.GetValue("IDOrdenRuta")) Then
                tipo = enumTipoMovimiento.tmSalFabrica
            Else
                Dim lineaPadre As New DataView(CType(jngLineaAlbaran.DataSource, DataTable))
                Dim f As New Filter
                f.Add(New NumberFilterItem("IDLineaAlbaran", FilterOperator.Equal, jngLineaAlbaran.GetValue("IDLineaPadre")))
                lineaPadre.RowFilter = f.Compose(New AdoFilterComposer)
                If lineaPadre.Count > 0 Then
                    If lineaPadre(0).Row("TipoLineaAlbaran") = enumaclTipoLineaAlbaran.aclSubcontratacion Then
                        tipo = enumTipoMovimiento.tmSalSubcontratacion
                    ElseIf lineaPadre(0).Row("TipoLineaAlbaran") = enumaclTipoLineaAlbaran.aclKit Then
                        tipo = enumTipoMovimiento.tmEntAlbaranCompra
                    End If
                End If
            End If
        End If
        TipoMovimiento = tipo
    End Function

    Public Sub FacturasGeneradas()

        lstFacturasGeneradas.Items.Clear()

        Dim strSelect As String = "Distinct NFactura, IdFactura,FechaFactura"

        Dim FwnConsulta As New BE.DataEngine
        Dim dt As DataTable
        dt = FwnConsulta.Filter("vFrmMntoAlbaranCompraFacturasGeneradas", New NumberFilterItem("IdAlbaran", Me.CurrentRow("IDAlbaran")), strSelect)
        If Not IsNothing(dt) AndAlso dt.Rows.Count > 0 Then
            lstFacturasGeneradas.Visible = True
            For Each dr As DataRow In dt.Rows
                lstFacturasGeneradas.Items.Add(dr("NFactura") & " - " & ExpertisApp.Traslate("Fecha Factura") & ": " & dr("FechaFactura"))
            Next
        Else
            lstFacturasGeneradas.Visible = False
        End If
    End Sub

    Private Sub DescripcionMonedasAB()
        Dim dtMoneda As DataTable

        dtMoneda = ExpertisApp.ExecuteTask(Of Object, DataTable)(AddressOf Moneda.ObtenerMonedaA, New Object)
        Dim strDesc As String
        If Not dtMoneda Is Nothing AndAlso dtMoneda.Rows.Count > 0 Then
            strDesc = dtMoneda.Rows(0)("DescMoneda") & String.Empty
            If Len(strDesc) > 0 Then fwiDescMonedaA.Text = strDesc
        End If

        strDesc = String.Empty
        dtMoneda = ExpertisApp.ExecuteTask(Of Object, DataTable)(AddressOf Moneda.ObtenerMonedaB, New Object)
        If Not dtMoneda Is Nothing AndAlso dtMoneda.Rows.Count > 0 Then
            strDesc = dtMoneda.Rows(0)("DescMoneda") & String.Empty
            If Len(strDesc) > 0 Then fwiDescMonedaB.Text = strDesc
        End If

    End Sub

    Private Sub LoadGridDefaultValues()
        With jngLineaAlbaran
            .Columns("QServida").DefaultValue = 0
            .Columns("cantidad").DefaultValue = 0
            .Columns("Factor").DefaultValue = 1
            .Columns("QInterna").DefaultValue = 0
            If mblnStkDobleUnidad Then .Columns("QInterna2").DefaultValue = 0
            .Columns("Precio").DefaultValue = 0
            .Columns("Importe").DefaultValue = 0
            .Columns("Dto1").DefaultValue = 0
            .Columns("Dto2").DefaultValue = 0
            .Columns("Dto3").DefaultValue = 0

            If Not fwiIdCondPago.SelectedRow Is Nothing AndAlso Nz(fwiIdCondPago.SelectedRow("DtoProntoPago"), 0) <> 0 Then
                .Columns("DtoProntoPago").DefaultValue = fwiIdCondPago.SelectedRow("DtoProntoPago")
            Else
                .Columns("DtoProntoPago").DefaultValue = 0
            End If

            If Not Me.CurrentRow Is Nothing AndAlso Me.CurrentRow.RowState <> DataRowState.Deleted Then
                .Columns("IDCondicionPago").DefaultValue = Me.CurrentRow("IdCondicionPago")
                .Columns("IDFormaPago").DefaultValue = Me.CurrentRow("IDFormaPago")
                .Columns("IDAlmacen").DefaultValue = Me.CurrentRow("IDAlmacen")
                .Columns("Dto").DefaultValue = Me.CurrentRow("Dto")
            Else
                .Columns("Dto").DefaultValue = 0
            End If
            .Columns("UdValoracion").DefaultValue = 1
            .Columns("EstadoStock").DefaultValue = CInt(enumaclEstadoStock.aclNoActualizado)
            .Columns("EstadoFactura").DefaultValue = CInt(enumaclEstadoFactura.aclNoFacturado)
            .Columns("IDLineaPadre").DefaultValue = System.DBNull.Value
            .Columns("TipoLineaCompra").DefaultValue = CInt(enumaclTipoLineaAlbaran.aclNormal)
            .Columns("TipoGastoObra").DefaultValue = CInt(enumfclTipoGastoObra.enumfclMaterial)
            .Columns("IDOrdenLinea").DefaultValue = jngLineaAlbaran.RowCount + 1
            If Len(fwiIdCentroGestion.Text) > 0 Then .Columns("IdCentroGestion").DefaultValue = fwiIdCentroGestion.Text
        End With
    End Sub

    Private Sub TabAlbaranes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabAlbaranes.Click
        If Length(Me.CurrentRow("IDAlbaran")) > 0 Then
            Select Case TabAlbaranes.SelectedTab.Key
                Case "Lineas"
                    lblDescMonedaA.Text = lblcfwiIdMoneda.Text
                Case "DatosEconomicos"
                    DescripcionMonedasAB()
                Case "Seguimiento"
                    FacturasGeneradas()
            End Select
        End If
    End Sub

    Private Sub FwBusquedaDireccion_SelectionChanged(ByVal sender As Object, ByVal e As Solmicro.Expertis.Engine.UI.AdvSearchSelectionChangedEventArgs) Handles FwBusquedaDireccion.SelectionChanged
        Me.CurrentRow("IDDireccion") = FwBusquedaDireccion.SelectedRow.Rows(0)("IDDireccion")
    End Sub

#Region " Grid "

    Private Sub jngLineaAlbaran_AdvSearchNotInList(ByVal sender As Object, ByVal e As Engine.UI.AdvSearchNotInListEventArgs) Handles jngLineaAlbaran.AdvSearchNotInList
        Select Case e.Key
            Case "IDArticulo"
                e.Cancel = False
                e.Handled = False
                MDatArt = ExpertisApp.ExecuteTask(Of String, AlbaranCompraLinea.DataBuscarArt)(AddressOf AlbaranCompraLinea.BuscarArticulo, e.Value)
                Me.jngLineaAlbaran.SetValue("IDArticulo", MDatArt.IDArticulo)
        End Select
    End Sub

    Private Sub jngLineaAlbaran_CellUpdated(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles jngLineaAlbaran.CellUpdated
        Select Case e.Column.Key
            Case "IDArticulo"
                If Not MDatArt Is Nothing AndAlso Length(MDatArt.IDArticulo) > 0 Then
                    Me.jngLineaAlbaran.SetValue("IDArticulo", MDatArt.IDArticulo)
                    MDatArt = Nothing
                End If
        End Select
    End Sub

    Private Sub jngLineaAlbaran_DeletingRecord(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionCancelEventArgs) Handles jngLineaAlbaran.DeletingRecord
        If mBlnEsBodega Then
            Dim FilLote As New Filter
            FilLote.Add("IDLineaAlbaran", FilterOperator.Equal, Me.jngLineaAlbaran.GetValue("IDLineaAlbaran"))
            FilLote.Add(New IsNullFilterItem("NEntrada", False))
            Dim DtLote As DataTable = New AlbaranCompraLote().Filter(FilLote)
            If Not DtLote Is Nothing AndAlso DtLote.Rows.Count > 0 Then
                ExpertisApp.GenerateMessage("No se puede borrar la línea, tiene desglose de Lotes con Entradas de Vino.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub jngLineaAlbaran_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles jngLineaAlbaran.GotFocus
        LoadGridDefaultValues()
    End Sub

    Private Sub CargarSeguimientoTarifa(ByVal strTexto As String, ByVal strLabel As String)
        Dim frm As New FormularioTexto
        frm.Text = strLabel
        frm.SoloLectura = False
        frm.Texto = strTexto
        frm.ShowDialog()
    End Sub

    Private Sub jngLineaAlbaran_EditingCell(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.EditingCellEventArgs) Handles jngLineaAlbaran.EditingCell
        Dim LineaComponente, LineaSubcontratacion As Boolean
        With jngLineaAlbaran
            If Me.CurrentRow("Estado") <> enumaccEstado.accFacturado Then
                If .Row <> Grid.newTopRowPosition Then
                    If .Value("EstadoFactura") = enumaclEstadoFactura.aclFacturado OrElse _
                        (mblnGestionInventarioPermanente AndAlso Nz(jngLineaAlbaran.GetValue("Contabilizado"), CInt(enumContabilizado.NoContabilizado) <> CInt(enumContabilizado.NoContabilizado))) Then
                        e.Cancel = True '(e.Column.Key <> "IDPedido")
                    Else
                        LineaComponente = (Not IsDBNull(.Value("IDLineaPadre")) And .Value("TipoLineaCompra") = enumaclTipoLineaAlbaran.aclComponente)
                        LineaSubcontratacion = (Nz(.Value("IDOrdenRuta"), 0) <> 0)
                    End If
                End If

                If LineaComponente Then 'Or (LineaSubcontratacion And ("EstadoStock") = enumaclEstadoStock.aclActualizado) Then
                    e.Column.ButtonStyle = ButtonStyle.NoButton
                    If e.Column.Key <> "Qinterna2" Then e.Cancel = True
                Else
                    Select Case e.Column.Key
                        Case "IDArticulo", "RefProveedor", "IDAlmacen", "IDUdMedida", "IDCentroGestion"
                            'Or .GetValue("EstadoStock") = enumaclEstadoStock.aclSinGestion _   
                            If .GetValue("EstadoStock") = enumaclEstadoStock.aclActualizado _
                            Or .GetValue("TipoLineaCompra") = enumaclTipoLineaAlbaran.aclKit _
                            Or (.GetValue("TipoLineaCompra") = enumaclTipoLineaAlbaran.aclSubcontratacion And Length(.Value("IDLineaPedido")) > 0) _
                            Or Nz(.GetValue("Lotes"), 0) > 0 Then
                                e.Column.ButtonStyle = ButtonStyle.NoButton
                                e.Cancel = True
                            ElseIf .GetValue("EstadoStock") = enumaclEstadoStock.aclNoActualizado OrElse _
                                  (.GetValue("EstadoStock") = enumaclEstadoStock.aclSinGestion AndAlso .GetValue("TipoLineaCompra") <> enumaclTipoLineaAlbaran.aclKit) Then
                                e.Column.ButtonStyle = ButtonStyle.Image
                                e.Column.EditType = EditType.TextBox
                            End If
                            If e.Column.Key = "IDArticulo" AndAlso Length(.Value("IDObra")) > 0 AndAlso .Row <> Grid.newTopRowPosition Then
                                e.Column.ButtonStyle = ButtonStyle.NoButton
                                e.Cancel = True
                            End If
                        Case "CContable", "IDTipoIva"
                            e.Column.EditType = EditType.TextBox
                            e.Column.ButtonStyle = ButtonStyle.Image
                        Case "QInterna", "QServida", "QInterna2"
                            e.Column.EditType = EditType.TextBox
                            If Nz(.GetValue("NSerieObligatorio"), False) AndAlso .GetValue("EstadoStock") = enumaclEstadoStock.aclActualizado Then
                                e.Cancel = True
                            ElseIf Nz(.GetValue("Lotes"), False) Then
                                e.Cancel = True
                            End If
                            If e.Cancel = False AndAlso .GetValue("TipoLineaCompra") = enumaclTipoLineaAlbaran.aclKit Then
                                e.Cancel = ModificarKit()
                            End If
                            If Not e.Cancel AndAlso mblnGestionInventarioPermanente AndAlso .Row <> Grid.newTopRowPosition AndAlso Nz(.GetValue("Contabilizado"), -1) <> enumContabilizado.NoContabilizado Then
                                e.Cancel = True
                            End If
                        Case "Factor"
                            e.Cancel = True
                        Case "IDActivoAImputar"
                            e.Column.EditType = EditType.TextBox
                            e.Column.ButtonStyle = ButtonStyle.Image
                        Case "IDObra", "NObra", "CodTrabajo"
                            If Nz(.Value("GeneradoControl"), False) Then
                                e.Column.ButtonStyle = ButtonStyle.NoButton
                                e.Cancel = True
                            ElseIf Length(.Value("IDLineaMaterialPedido")) = 0 Then
                                e.Column.ButtonStyle = ButtonStyle.Image
                            Else
                                e.Column.ButtonStyle = ButtonStyle.NoButton
                                e.Cancel = True
                            End If
                        Case "TipoGastoObra"
                            If Nz(.Value("GeneradoControl"), False) Then
                                e.Column.ButtonStyle = ButtonStyle.NoButton
                                e.Cancel = True
                            ElseIf Length(.Value("IDLineaMaterialPedido")) = 0 Then
                                e.Column.EditType = EditType.DropDownList
                            Else
                                'e.Column.ButtonStyle = ButtonStyle.NoButton
                                e.Cancel = True
                            End If
                        Case "IDConcepto"
                            '.Columns(e.Column.Index).EditType = Janus.Windows.GridEX.EditType.TextBox
                            '.Columns(e.Column.Index).ButtonStyle = Janus.Windows.GridEX.ButtonStyle.Image
                            AsignarEntidadSearchConcepto(e)
                        Case "IDLineaPadre"
                            If Nz(.Value("GeneradoControl"), False) Then
                                e.Column.ButtonStyle = ButtonStyle.NoButton
                                e.Cancel = True
                            ElseIf Length(.Value("IDLineaMaterialPedido")) > 0 Then
                                e.Cancel = True
                            Else
                                AsignarEntidadSearchLineaConcepto()
                            End If
                        Case "Importe", "EstadoFactura", "EstadoStock", "TipoLineaCompra", "IDOrdenRuta", "Secuencia", "IDOrden", "NROT"
                            e.Cancel = True
                        Case "NOrden"
                            If jngLineaAlbaran.Row = Grid.newTopRowPosition Or .Value("TipoLineaCompra") = enumaclTipoLineaAlbaran.aclSubcontratacion Then
                                e.Column.ButtonStyle = ButtonStyle.Image
                                e.Cancel = True
                            Else
                                e.Column.ButtonStyle = ButtonStyle.NoButton
                                e.Cancel = True
                            End If
                        Case "Lote"
                            If .Value("EstadoStock") = enumaclEstadoStock.aclActualizado Or .Value("EstadoStock") = enumaclEstadoStock.aclSinGestion Or Not .Value("NSerieObligatorio") Then
                                e.Cancel = True
                            End If
                            If Not e.Cancel AndAlso mblnGestionInventarioPermanente AndAlso .Row <> Grid.newTopRowPosition AndAlso Nz(.GetValue("Contabilizado"), -1) <> enumContabilizado.NoContabilizado Then
                                e.Cancel = True
                            End If
                        Case "Dto", "DtoProntoPago"
                            e.Cancel = Nz(.Value("Especial"), False)
                        Case "SeguimientoTarifa"
                            e.Column.ButtonStyle = Janus.Windows.GridEX.ButtonStyle.Ellipsis
                            e.Cancel = True
                        Case "IDUDInterna", "IDUDInterna2"
                            e.Column.ButtonStyle = ButtonStyle.NoButton
                            e.Cancel = True
                        Case "Contabilizado"
                            e.Cancel = True
                    End Select
                End If
            Else
                e.Column.ButtonStyle = ButtonStyle.NoButton
                e.Cancel = True
            End If
            If e.Column.Key = "IDArticulo" AndAlso jngLineaAlbaran.Row <> Grid.newTopRowPosition Then
                e.Column.ButtonStyle = ButtonStyle.NoButton
                e.Cancel = True
            End If
        End With
    End Sub

    Private Sub AsignarEntidadSearchConcepto(ByVal e As Janus.Windows.GridEX.EditingCellEventArgs)
        With jngLineaAlbaran
            If Length(.Value("TipoGastoObra")) > 0 AndAlso .Value("TipoGastoObra") <> enumfclTipoGastoObra.enumfclMaterial Then
                For Each Adv As AdvSearchColumn In .AdvSearchColumns
                    If Adv.Key = "IDConcepto" Then
                        .AdvSearchColumns.Remove(Adv)
                        Exit For
                    End If
                Next
                Select Case CType(.Value("TipoGastoObra"), enumfclTipoGastoObra)
                    Case enumfclTipoGastoObra.enumfclGastos
                        .AdvSearchColumns.Add("Gasto", "IdConcepto", "IdGasto")
                    Case enumfclTipoGastoObra.enumfclVarios
                        .AdvSearchColumns.Add("Varios", "IdConcepto", "IdVarios")
                End Select
                .Columns("IDConcepto").ButtonStyle = Janus.Windows.GridEX.ButtonStyle.Image
                .Columns("IDConcepto").ButtonImage = ImageList1.Images(6)
            Else
                .Columns("IDConcepto").ButtonStyle = Janus.Windows.GridEX.ButtonStyle.NoButton
                e.Cancel = True
            End If
        End With
    End Sub

    Private Sub AsignarEntidadSearchLineaConcepto()
        With jngLineaAlbaran
            If Length(.Value("TipoGastoObra")) > 0 Then
                For Each Adv As AdvSearchColumn In .AdvSearchColumns
                    If Adv.Key = "IDLineaPadre" Then
                        .AdvSearchColumns.Remove(Adv)
                        Exit For
                    End If
                Next
                If Length(.Value("IDLineaMaterialPedido")) = 0 Then
                    Dim Cols As New Engine.UI.ASSelectedColumns
                    Dim ColIDObra As New Engine.UI.ASSelectedColumn
                    ColIDObra.GridColumn = "IDObra"
                    ColIDObra.SelectedColumn = "IDObra"
                    Dim ColIDTrab As New Engine.UI.ASSelectedColumn
                    ColIDTrab.GridColumn = "IDTrabajo"
                    ColIDTrab.SelectedColumn = "IDTrabajo"
                    Cols.Add(ColIDObra) : Cols.Add(ColIDTrab)
                    Select Case CType(.Value("TipoGastoObra"), enumfclTipoGastoObra)
                        Case enumfclTipoGastoObra.enumfclMaterial
                            .AdvSearchColumns.Add("ObraMaterial", "IDLineaPadre", "IdLineaMaterial", Cols)
                        Case enumfclTipoGastoObra.enumfclGastos
                            .AdvSearchColumns.Add("ObraGasto", "IDLineaPadre", "IdLineaGasto", Cols)
                        Case enumfclTipoGastoObra.enumfclVarios
                            .AdvSearchColumns.Add("ObraVarios", "IDLineaPadre", "IdLineaVarios", Cols)
                    End Select
                    .Columns("IdLineaPadre").ButtonImage = ImageList1.Images(6)
                    .Columns("IdLineaPadre").ButtonStyle = ButtonStyle.Image
                Else
                    .Columns("IdLineaPadre").ButtonStyle = Janus.Windows.GridEX.ButtonStyle.NoButton
                End If
            Else
                .Columns("IdLineaPadre").ButtonStyle = Janus.Windows.GridEX.ButtonStyle.NoButton
            End If
        End With
    End Sub

    Private Sub jngLineaAlbaran_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles jngLineaAlbaran.KeyDown
        If e.KeyCode = Keys.F4 Then
            With jngLineaAlbaran
                Select Case .Col
                    Case .Columns("SeguimientoTarifa").Position
                        CargarSeguimientoTarifa(.Value("SeguimientoTarifa") & String.Empty, .Columns("SeguimientoTarifa").Caption)
                End Select
            End With
        End If
    End Sub

    Private Function ModificarKit() As Boolean
        Dim dt As DataTable = Me.jngLineaAlbaran.DataSource
        Dim filKit As New Filter
        filKit.Add("IdLineaPadre", FilterOperator.Equal, jngLineaAlbaran.GetValue("IdLineaAlbaran"))
        filKit.Add("Lotes", FilterOperator.GreaterThan, 0)
        Dim dr() As DataRow = dt.Select(filKit.Compose(New AdoFilterComposer))
        If dr.Length > 0 Then
            ExpertisApp.GenerateMessage("No se puede modificar la cantidad porque alguno de los componentes lleva gestión por lotes. Debe borrar previamente dichos lotes.", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub jngLineaAlbaran_ColumnButtonClick(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles jngLineaAlbaran.ColumnButtonClick
        With jngLineaAlbaran
            Select Case e.Column.Key
                Case "SeguimientoTarifa"
                    CargarSeguimientoTarifa(.Value(e.Column.Key) & String.Empty, .Columns(e.Column.Key).Caption)
            End Select
        End With
    End Sub

    Private Sub jngLineaAlbaran_UpdatingRecord(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles jngLineaAlbaran.UpdatingRecord
        Dim FwnPedidoCCab As PedidoCompraCabecera
        Dim fwnProveedor As Proveedor
        Dim lngIdPedido As Integer
        Dim strCondPago As String = String.Empty
        Dim strFormaPago As String = String.Empty

        If mblnStkDobleUnidad AndAlso Length(jngLineaAlbaran.Value("IDUDInterna2")) > 0 AndAlso _
            Not Nz(jngLineaAlbaran.Value("NSerieObligatorio"), False) Then
            If Nz(jngLineaAlbaran.Value("QInterna2"), 0) = 0 Then
                ExpertisApp.GenerateMessage("Debe introducir la Cantidad Interna en la Segunda Unidad.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                e.Cancel = True
            End If
        End If

        '22/03/2002:Ahora los campos IDFormaPago e IDCondicionPago se pueden modificar.
        'Se establecen por defecto en el grid si la cabecera es manual.
        'Si la cabecera es automatica no tendran valor a no ser que hayan sido modificados
        'por el usuario en la linea.
        'Si alguna de las condiciones economicas no tiene valor, se cogen de
        '1º - PedidoCompraCabecera
        '2º - (si no hay pedido)Proveedor
        If Len((jngLineaAlbaran.GetValue("IdCondicionPago"))) = 0 Or Len((jngLineaAlbaran.GetValue("IdFormaPago"))) = 0 Then
            'Comprobar si la cabecera es manual o automática
            If Len(fwiIdCondPago.Text) = 0 Or Len(fwiIdFormaPago.Text) = 0 Then

                If Len((jngLineaAlbaran.GetValue("IdPedido")) & vbNullString) > 0 Then
                    lngIdPedido = (jngLineaAlbaran.GetValue("IdPedido"))
                    FwnPedidoCCab = New PedidoCompraCabecera
                    Dim dtPedidoCCab As DataTable = FwnPedidoCCab.SelOnPrimaryKey(lngIdPedido)
                    If dtPedidoCCab.Rows.Count <> 0 Then
                        strCondPago = dtPedidoCCab.Rows(0)("IdCondicionPago") & vbNullString
                        strFormaPago = dtPedidoCCab.Rows(0)("IDFormaPago") & vbNullString
                    End If
                Else
                    fwnProveedor = New Proveedor
                    Dim dtProveedor As DataTable = fwnProveedor.SelOnPrimaryKey(fwiIdProveedor.Text)
                    If dtProveedor.Rows.Count <> 0 Then
                        strCondPago = dtProveedor.Rows(0)("IdCondicionPago") & vbNullString
                        strFormaPago = dtProveedor.Rows(0)("IDFormaPago") & vbNullString
                    End If
                End If

                If Len((jngLineaAlbaran.GetValue("IdCondicionPago"))) = 0 Then
                    jngLineaAlbaran.SetValue("IdCondicionPago", strCondPago)
                End If
                If Len((jngLineaAlbaran.GetValue("IdFormaPago"))) = 0 Then
                    jngLineaAlbaran.SetValue("IdFormaPago", strFormaPago)
                End If
            Else
                If Len(jngLineaAlbaran.GetValue("IdCondicionPago")) Then
                    jngLineaAlbaran.SetValue("IdCondicionPago", fwiIdCondPago.Text)
                End If
                If Len(jngLineaAlbaran.GetValue("IdFormaPago")) = 0 Then
                    jngLineaAlbaran.SetValue("IdFormaPago", fwiIdFormaPago.Text)
                End If
            End If
        End If
        If jngLineaAlbaran.Row = Grid.newTopRowPosition Then jngLineaAlbaran.SetValue("IdOrdenLinea", jngLineaAlbaran.RowCount + 1)
    End Sub

    Private Sub jngLineaAlbaran_RecordsDeleted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles jngLineaAlbaran.RecordsDeleted
        If mblnEliminarLineasHijas Then ComponenteEliminarLineas()
        VisibilidadColumnaDesglose()
    End Sub

    Private Sub ComponenteEliminarLineas()
        Dim i As Integer
        Dim dtGrid As DataTable = jngLineaAlbaran.DataSource
        If Not dtGrid Is Nothing AndAlso dtGrid.Rows.Count > 0 Then
            For i = LBound(marrLineasPadre) To UBound(marrLineasPadre)
                Dim DrGrid() As DataRow = dtGrid.Select("IDLineaPadre=" & CInt(marrLineasPadre(i)))
                If DrGrid.Length > 0 Then
                    For Each dr As DataRow In DrGrid
                        dr.Delete()
                    Next
                End If
            Next i
        End If
        jngLineaAlbaran.HoldFields()
        jngLineaAlbaran.DataSource = dtGrid

        mblnEliminarLineasHijas = False
    End Sub

    Private Sub jngLineaAlbaran_RecordsLoaded() Handles jngLineaAlbaran.RecordsLoaded
        ChequearActualizacionesPendientes()
    End Sub

    Private Sub jngLineaAlbaran_FormattingRow(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.RowLoadEventArgs) Handles jngLineaAlbaran.FormattingRow
        If Not IsDBNull(e.Row.Cells("IDLineaPadre").Value) And e.Row.Cells("TipoLineaCompra").Value = enumaclTipoLineaAlbaran.aclComponente Then
            e.Row.RowStyle = jngLineaAlbaran.FormatStyles("LineaHija")
        End If
        If mblnGestionInventarioPermanente Then
            If Nz(e.Row.Cells("Contabilizado").Value, enumContabilizado.NoContabilizado) <> enumContabilizado.NoContabilizado Then
                If Not e.Row.RowStyle Is Nothing Then
                    e.Row.RowStyle.FontBold = TriState.True
                Else
                    e.Row.RowStyle = jngLineaAlbaran.FormatStyles("Contabilizado")
                End If
            End If
        End If

        If Nz(e.Row.Cells("GestionStockPorLotes").Value, False) Then
            If e.Row.RowType = RowType.Record Then
                If e.Row.Cells("TipoLineaCompra").Value <> enumaclTipoLineaAlbaran.aclSubcontratacion OrElse _
                (e.Row.Cells("TipoLineaCompra").Value = enumaclTipoLineaAlbaran.aclSubcontratacion AndAlso Nz(e.Row.Cells("IDOrdenRuta").Value, 0) = 0) Then
                    e.Row.Cells("Desglose").ImageIndex = 4
                End If
            End If
        ElseIf Nz(e.Row.Cells("NSerieObligatorio").Value, False) Then
            e.Row.Cells("Desglose").ImageIndex = 5
        End If
    End Sub

    Protected Overridable Sub jngLineaAlbaran_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles jngLineaAlbaran.Click
        Dim hit As GridArea
        With jngLineaAlbaran
            hit = .HitTest()
            If hit = GridArea.Cell Or hit = GridArea.NewRowCell Then
                Dim c As GridEXColumn = .ColumnFromPoint()
                If Not IsNothing(c) Then
                    Select Case c.Key
                        Case "BotonAnalitica"
                            If Me.RecordsState = RecordsState.Saved Then
                                Analitica()
                            End If
                        Case "BotonGastos"
                            If Me.RecordsState = RecordsState.Saved Then
                                Gastos()
                            End If
                        Case "Texto"
                            If Me.RecordsState = RecordsState.Saved Then
                                FormularioObservaciones()
                            End If
                        Case "Desglose"
                            Desglose()
                        Case "Calidad"
                            ValoracionSuministro()
                        Case "BtnRechazadas"
                            If Me.RecordsState = UI.RecordsState.Saved Then
                                If Length(Me.jngLineaAlbaran.GetValue("IDLineaAlbaran")) > 0 AndAlso Length(Me.jngLineaAlbaran.GetValue("IDLineaPadre")) = 0 Then
                                    Dim FrmCantRec As New FrmCantRechazo
                                    FrmCantRec.IDLineaAlbaran = Me.jngLineaAlbaran.GetValue("IDLineaAlbaran")
                                    If FrmCantRec.ShowDialog = Windows.Forms.DialogResult.OK Then
                                        Me.jngLineaAlbaran.SetValue("QRechazada", Nz(FrmCantRec.QRechazadaTotal, 0))
                                        Dim DrFind() As DataRow = CType(Me.jngLineaAlbaran.DataSource, DataTable).Select("IDLineaPadre = " & Me.jngLineaAlbaran.GetValue("IDLineaAlbaran"))
                                        If DrFind.Length > 0 Then
                                            DrFind(0)("QRechazada") = Me.jngLineaAlbaran.GetValue("QRechazada")
                                        End If
                                        Me.Ok.InvokeOnClick()
                                        Me.Requery.InvokeOnClick()
                                    End If
                                End If
                            Else : ExpertisApp.GenerateMessage("Debe guardar antes la información del registro.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            End If
                    End Select
                End If
            End If
        End With
    End Sub

    Private Sub Analitica()
        With jngLineaAlbaran
            If .Row <> Grid.newTopRowPosition And Length(.Value("IDArticulo")) Then
                If ComprobarAnaliticaCuentas(.GetValue("CContable"), Me.CurrentRow("IDEjercicio")) Then
                    Dim frm As New CommonClasses.Analitica
                    frm.EntityName = "AlbaranCompraLinea"
                    frm.ViewName = "tbAlbaranCompraLinea"
                    frm.jngAnalitica.EntityName = "AlbaranCompraAnalitica"
                    frm.jngAnalitica.PrimaryDataFields = "IDLineaAlbaran"
                    frm.jngAnalitica.SecondaryDataFields = "IDLineaAlbaran"
                    frm.jngAnalitica.ViewName = "VfrmMntoAlbaranCompraAnalitica"
                    If .Value("EstadoFactura") = enumaclEstadoFactura.aclFacturado Or .Value("EstadoFactura") = enumaclEstadoFactura.aclParcFacturado Then
                        frm.SoloLectura = True
                    Else
                        frm.SoloLectura = False
                    End If
                    frm.IDMoneda = Me.CurrentRow("IDMoneda")
                    frm.Fecha = Me.CurrentRow("FechaAlbaran")
                    frm.FilterCriteria = New NumberFilterItem("IDLineaAlbaran", FilterOperator.Equal, .Value("IDLineaAlbaran"))
                    frm.ShowDialog()
                    frm.Dispose()
                End If
            End If
        End With
    End Sub

    Private Sub FormularioObservaciones()
        Dim frm As New FormularioTexto
        frm.Texto = jngLineaAlbaran.GetValue("Texto") & String.Empty
        frm.ShowDialog()
        If jngLineaAlbaran.GetValue("Texto") & String.Empty <> frm.Texto Then
            jngLineaAlbaran.SetValue("Texto", frm.Texto)
        End If
    End Sub

    Private Sub Desglose()
        If Not EsSubcontratacion() Then
            If jngLineaAlbaran.Row <> Grid.newTopRowPosition Then
                If jngLineaAlbaran.GetValue("GestionStockPorLotes") Then
                    If Me.RecordsState = RecordsState.Saved Then
                        Dim lotesAlbaran As DataTable
                        Dim negLote As New AlbaranCompraLote
                        lotesAlbaran = negLote.Filter(New NumberFilterItem("IDLineaAlbaran", jngLineaAlbaran.GetValue("IDLineaAlbaran")))
                        'lotesAlbaran = New BE.DataEngine().Filter("vBdgAlbaranCompraLote", New NumberFilterItem("IDLineaAlbaran", jngLineaAlbaran.GetValue("IDLineaAlbaran")))
                        If Not lotesAlbaran Is Nothing AndAlso lotesAlbaran.Rows.Count > 0 Then
                            Dim frm As New ERP.CommonClasses.AlbaranCompraLoteUserDialog
                            frm.mArticulo = jngLineaAlbaran.GetValue("IDArticulo") & String.Empty
                            frm.mAlmacen = jngLineaAlbaran.GetValue("IDAlmacen") & String.Empty
                            frm.mDocumento = Me.CurrentRow("NAlbaran")
                            frm.mTextoDocumento = "Albarán Nº. "
                            frm.Grid.DataSource = lotesAlbaran
                            AddHandler frm.RecordsDeleted, AddressOf Me.AlbaranLoteUserDialogRecordsDeleted
                            frm.ShowDialog()
                            RemoveHandler frm.RecordsDeleted, AddressOf Me.AlbaranLoteUserDialogRecordsDeleted
                            Me.Requery.InvokeOnClick()
                        Else
                            Dim StData As New DataArticuloAlmacen(Me.jngLineaAlbaran.GetValue("IDArticulo"), Me.jngLineaAlbaran.GetValue("IDAlmacen"))
                            ExpertisApp.ExecuteTask(Of DataArticuloAlmacen)(AddressOf ArticuloAlmacen.AltaArticuloAlmacen, StData)
                            mLotes.Width = Me.Width
                            Dim dlg As DialogResult = mLotes.ShowDialog(jngLineaAlbaran.GetValue("IDLineaAlbaran"))
                            If dlg = DialogResult.OK Then
                                If mblnActualizaStockAuto Then
                                    Dim log() As StockUpdateData = ExpertisApp.ExecuteTask(Of Integer, StockUpdateData())(AddressOf AlbaranCompraCabecera.ActualizarStockAlbaran, CInt(Me.CurrentRow("IDAlbaran")))
                                    If Not log Is Nothing AndAlso log.Length > 0 Then
                                        Dim detalle As New ERP.CommonClasses.DetalleActualizacionStock
                                        detalle.DataSource = log
                                        detalle.ShowDialog()
                                        Me.Requery.InvokeOnClick()
                                    End If
                                End If
                            End If
                        End If
                    Else
                        ExpertisApp.GenerateMessage("Existen actualizaciones pendientes.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                ElseIf jngLineaAlbaran.GetValue("NSerieObligatorio") Then
                    AbrirNSerie()
                End If
            End If
        End If
    End Sub

    Private Sub AlbaranLoteUserDialogRecordsDeleted(ByVal sender As Object, ByVal e As System.EventArgs)
        Me.RetrieveData(DataProviderActions.Refresh)
    End Sub

    Protected Overridable Sub AbrirNSerie()
        Dim EsSubcontratacion As Boolean = False
        With jngLineaAlbaran
            'If .Row <> .newTopRowPosition Then
            If Length(.GetValue("IDArticulo")) > 0 And Length(.GetValue("Lote")) > 0 Then
                Dim frm As New NSerieSituacion(.GetValue("IDArticulo"))
                frm.ShowDialog()
            ElseIf Length(.GetValue("IDArticulo")) > 0 And Length(.GetValue("IDAlmacen")) > 0 And Length(.GetValue("Lote")) = 0 Then
                If .GetValue("EstadoStock") = enumavlEstadoStock.avlNoActualizado AndAlso ComprobarDesglose() Then
                    If jngLineaAlbaran.GetValue("TipoLineaCompra") = CInt(enumaclTipoLineaAlbaran.aclComponente) Then
                        Dim IntIDLineaPadre As Integer = jngLineaAlbaran.GetValue("IDLineaPadre")
                        Dim DtGrid As DataTable = jngLineaAlbaran.DataSource
                        Dim DrSel() As DataRow = DtGrid.Select("IDLineaAlbaran = " & IntIDLineaPadre)
                        If DrSel.Length > 0 Then
                            If DrSel(0)("tipolineaalbaran") = 3 Then
                                EsSubcontratacion = True
                            End If
                        End If
                    End If

                    If .GetValue("QInterna") < 0 OrElse (.GetValue("QInterna") > 0 And EsSubcontratacion) Then
                        mSeries2.ValorPorDefectoSeleccionEstado = ERP.CommonClasses.NSerie.ESTADO_BAJA
                        mSeries2.Filtro.Clear()
                        mSeries2.Filtro.Add(New BooleanFilterItem("Disponible", True))
                        mSeries2.ModoRecuentoSalidas = [Shared].ModoRecuentoSalidas.Bajas
                        mSeries2.UsarColumnaSeleccion = True
                        If mSeries2.ShowDialog(CStr(.GetValue("IDLineaAlbaran"))) = DialogResult.OK Then
                            NumerosDeSerie()
                        End If
                    ElseIf Length(.GetValue("IDLineaAlbaran")) > 0 AndAlso .GetValue("QInterna") > 0 Then
                        If mSeries.ShowDialog(CStr(.GetValue("IDLineaAlbaran"))) = DialogResult.OK Then
                            NumerosDeSerie()
                        End If
                    End If
                End If
            End If
            'End If
        End With
    End Sub

    Private Function ComprobarDesglose() As Boolean
        If jngLineaAlbaran.GetValue("TipoLineaCompra") = CInt(enumaclTipoLineaAlbaran.aclComponente) Then
            Dim IntIDLineaPadre As Integer = jngLineaAlbaran.GetValue("IDLineaPadre")
            Dim DtGrid As DataTable = jngLineaAlbaran.DataSource
            Dim DrSel() As DataRow = DtGrid.Select("IDLineaAlbaran = " & IntIDLineaPadre)
            If DrSel.Length > 0 Then
                If DrSel(0)("EstadoStock") > 0 Or Length(DrSel(0)("Lote")) > 0 AndAlso Me.RecordsState = RecordsState.Saved Then
                    Return True
                Else
                    ExpertisApp.GenerateMessage("Debe desglosar primero las líneas padre antes que las lineas de componente.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Return False
                End If
            End If
        Else : Return True
        End If
    End Function

    Private Sub Gastos()
        If Me.RecordsState = RecordsState.Saved Then
            With jngLineaAlbaran
                If .Row <> Grid.newTopRowPosition AndAlso Length(("IDLineaAlbaran")) > 0 Then
                    If Not .GetValue("NSerieObligatorio") OrElse (.GetValue("NSerieObligatorio") AndAlso Length(.GetValue("Lote")) > 0) Then
                        Dim frmGasto As New FrmGastos
                        frmGasto.AbrirGastos(.Value("IDLineaAlbaran"), Me.CurrentRow("IDAlbaran"), _
                                             .Value("IDArticulo") & String.Empty, _
                                             .Value("DescArticulo") & String.Empty, Nz(.Value("Precio"), 0), _
                                             Nz(.Value("Importe"), 0), Me.fwiIdMoneda.Text, fwiCambioA.Text, fwiCambioB.Text, Nz(Me.fwiIdMoneda.SelectedRow("Abreviatura"), String.Empty), .Value("Contabilizado"))
                    Else : ExpertisApp.GenerateMessage("El artículo es por Números de Serie y es necesario crearlo previamente a la introducción de gastos.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    End If
                End If
            End With
        End If
    End Sub

    Private Sub ValoracionSuministro()
        With jngLineaAlbaran
            If Length(.GetValue("IDLineaAlbaran")) > 0 Then
                Dim frm As New frmValoracionSuministro
                frm.AbrirCriterioValSuministro(.GetValue("IDLineaAlbaran"), CurrentRow("NAlbaran"), _
                                               .GetValue("IDArticulo"), .GetValue("DescArticulo"), Me)
            End If
        End With
    End Sub

    Private Sub jngLineaAlbaran_AdvSearchSetPredefinedFilter(ByVal sender As System.Object, ByVal e As Solmicro.Expertis.Engine.UI.GridAdvSearchFilterEventArgs) Handles jngLineaAlbaran.AdvSearchSetPredefinedFilter
        With jngLineaAlbaran
            Select Case e.Key
                Case "IDArticulo"
                    e.Filter.Add(New BooleanFilterItem("Activo", FilterOperator.Equal, True))
                    e.Filter.Add(New BooleanFilterItem("Compra", FilterOperator.Equal, True))
                Case "IDAlmacen"
                    e.Filter.Add(New BooleanFilterItem("Activo", FilterOperator.Equal, True))
                Case "IDContrato"
                    e.Filter.Add(New StringFilterItem("IDProveedor", FilterOperator.Equal, fwiIdProveedor.Text))
                    e.Filter.Add(New StringFilterItem("IDArticulo", FilterOperator.Equal, .Value("IDArticulo")))
                    e.Filter.Add(New DateFilterItem("FechaInicioContrato", FilterOperator.LessThanOrEqual, fwiFechaAlbaran.Value))
                    e.Filter.Add(New DateFilterItem("FechaFinContrato", FilterOperator.GreaterThanOrEqual, fwiFechaAlbaran.Value))
                    e.Filter.Add(New NumberFilterItem("QSobrante", FilterOperator.GreaterThanOrEqual, .Value("QServida")))
                Case "RefProveedor"
                    If Len(fwiIdProveedor.Text) Then
                        e.Filter.Add(New StringFilterItem("IDProveedor", FilterOperator.Equal, fwiIdProveedor.Text))
                    End If
                Case "CodTrabajo"
                    If IsNumeric(.Value("IDObra")) Then
                        e.Filter.Add(New NumberFilterItem("IDObra", FilterOperator.Equal, .Value("IDObra")))
                    End If
                Case "IDLineaPadre"
                    If Length(.Value("IDObra")) > 0 Then
                        e.Filter.Add("IdObra", FilterOperator.Equal, .Value("IDObra"))
                    End If

                    If Length(.Value("IDTrabajo")) > 0 Then
                        e.Filter.Add("IDTrabajo", FilterOperator.Equal, .Value("IDTrabajo"))
                    End If

                    If Length(.Value("IDArticulo")) > 0 AndAlso .Value("TipoGastoObra") = enumfclTipoGastoObra.enumfclMaterial Then
                        e.Filter.Add("IDMaterial", FilterOperator.Equal, .Value("IDArticulo"))
                    End If
                Case "IDLineaAlbaran"
                    If IsNumeric(.Value("IDAlbaran")) Then
                        e.Filter.Add(New NumberFilterItem("IdAlbaran", FilterOperator.Equal, .Value("IDAlbaran")))
                    End If
                Case "CContable"
                    e.Filter.Add(New StringFilterItem("IDEjercicio", FilterOperator.Equal, mstrIDEjercicio))
                Case "NOrden"
                    If Length(("IDArticulo")) > 0 Then
                        e.Filter.Add(New StringFilterItem("IDArticulo", .Value("IDArticulo")))
                    End If
                Case "NROT"
                    If Length(.Value("IDArticulo")) > 0 Then
                        e.Filter.Add(New StringFilterItem("IDArticulo", .Value("IDArticulo")))
                    End If
            End Select
        End With
    End Sub

    Private Sub jngLineaAlbaran_AdvSearchSelectionChanged(ByVal sender As Object, ByVal e As Engine.UI.GridAdvSearchSelectionChangedEventArgs) Handles jngLineaAlbaran.AdvSearchSelectionChanged
        With jngLineaAlbaran
            Select Case e.Key
                Case "NROT"
                    .Value("IDOT") = e.Selected.Rows(0)("IDOT")
                    Dim dt As DataTable = New BE.DataEngine().Filter("vAdvOTsConPrevisto", New NumberFilterItem("IDOT", e.Selected.Rows(0)("IDOT")))
                    If Not dt Is Nothing AndAlso dt.Rows.Count > 0 Then
                        .Value("IDMntoOTPrev") = dt.Rows(0)("IDMntoOTPrev")
                    End If
                Case "IDLineaPadre"
                    If Not e.Selected Is Nothing AndAlso e.Selected.Rows.Count > 0 Then
                        If Length(e.Selected.Rows(0)("IDTrabajo")) > 0 Then
                            Dim CodTrabajo As String = New ObraTrabajo().SelOnPrimaryKey(e.Selected.Rows(0)("IDTrabajo")).Rows(0)("CodTrabajo")
                            .SetValue("CodTrabajo", CodTrabajo)
                        End If
                        If Length(e.Selected.Rows(0)("IDObra")) > 0 Then
                            Dim NObra As String = New ObraCabecera().SelOnPrimaryKey(e.Selected.Rows(0)("IDObra")).Rows(0)("NObra")
                            .SetValue("NObra", NObra)
                        End If
                    End If
                Case "RefProveedor"
                    If Not e.Selected Is Nothing AndAlso e.Selected.Rows.Count > 0 Then
                        MIDArticuloRef = e.Selected.Rows(0)("IDArticulo")
                    End If
            End Select
        End With
    End Sub

    Private Sub jngLineaAlbaran_AddingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles jngLineaAlbaran.AddingRecord
        'jngLineaAlbaran.Value("IDOrdenLinea") = jngLineaAlbaran.RowCount + 1
        With jngLineaAlbaran
            If Nz(.GetValue("NSerieObligatorio"), False) Then
                If ValidarNumerosSerie() Then
                    If .GetValue("QInterna") <> 1 AndAlso .GetValue("QInterna") <> -1 And Length(.GetValue("Lote")) > 0 Then
                        e.Cancel = True
                        ExpertisApp.GenerateMessage("La cantidad interna debe ser la unidad para un artículo con número de serie.", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    ElseIf .GetValue("QInterna") <> 0 And Length(.GetValue("Lote")) = 0 Then
                        If .GetValue("QInterna") < 0 Then
                            mSeries2.ValorPorDefectoSeleccionEstado = ERP.CommonClasses.NSerie.ESTADO_BAJA
                            mSeries2.Filtro.Clear()
                            mSeries2.Filtro.Add(New BooleanFilterItem("Disponible", True))
                            mSeries2.ModoRecuentoSalidas = [Shared].ModoRecuentoSalidas.Bajas
                            mSeries2.UsarColumnaSeleccion = True
                            If Length(.GetValue("IDLineaAlbaran")) > 0 Then
                                If mSeries2.ShowDialog(CStr(.GetValue("IDLineaAlbaran"))) <> DialogResult.OK Then
                                    e.Cancel = True
                                End If
                            End If
                        ElseIf .GetValue("QInterna") > 0 Then
                            If Length(.GetValue("IDLineaAlbaran")) > 0 Then
                                If mSeries.ShowDialog(CStr(.GetValue("IDLineaAlbaran"))) <> DialogResult.OK Then
                                    e.Cancel = True
                                End If
                            End If
                        End If
                    Else
                        If .GetValue("QInterna") <> 1 Or Length(.GetValue("Lote")) = 0 Then
                            e.Cancel = True
                            ExpertisApp.GenerateMessage("La especificación de los números de serie es obligatoria.", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        End If
                    End If
                Else
                    ExpertisApp.GenerateMessage("No se permiten introducir más numeros de serie a este albarán si son de signo contrario a las lineas ya introducidas en al albarán.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    e.Cancel = True
                End If
            ElseIf mblnStkDobleUnidad AndAlso Length(.Value("IDUDInterna2")) > 0 AndAlso Not Nz(.Value("NSerieObligatorio"), False) Then
                If Nz(.Value("QInterna2"), 0) = 0 Then
                    ExpertisApp.GenerateMessage("Debe introducir la Cantidad Interna en la Segunda Unidad.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    e.Cancel = True
                End If
            End If
        End With
    End Sub

    Private Function ValidarNumerosSerie() As Boolean
        Dim DtGrid As DataTable = jngLineaAlbaran.DataSource
        If Not DtGrid Is Nothing AndAlso DtGrid.Rows.Count > 0 Then
            For Each Dr As DataRow In DtGrid.Select
                If (jngLineaAlbaran.GetValue("QServida") < 0 AndAlso Dr("QServida") > 0) _
                OrElse (jngLineaAlbaran.GetValue("QServida") > 0 AndAlso Dr("QServida") < 0) Then
                    Return False
                End If
            Next
            Return True
        Else
            Return True
        End If
    End Function

    Private Sub jngLineaAlbaran_RecordAdded(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles jngLineaAlbaran.RecordAdded
        NumerosDeSerie()
        VisibilidadColumnaDesglose()
        jngLineaAlbaran.DataSource = TratarOrdenesLinea(jngLineaAlbaran.DataSource, "IDOrdenLinea", True)
    End Sub

    Private Sub jngLineaAlbaran_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles jngLineaAlbaran.MouseUp
        With jngLineaAlbaran
            If e.Button = MouseButtons.Right Then
                If Not IsNothing(jngLineaAlbaran) AndAlso .RowCount > 0 Then
                    .UiCommandManager1.Commands(cnABRIRCONTRATOCOMPRA).IsVisible = IIf(Length(jngLineaAlbaran.GetValue("IDContrato")) > 0, True, False)
                    .UiCommandManager1.Commands(cnABRIRPEDIDOCOMPRA).IsVisible = IIf(Length(jngLineaAlbaran.GetValue("IDPedido")) > 0, True, False)
                    .UiCommandManager1.Commands(cnABRIROBRA).IsVisible = IIf(Length(jngLineaAlbaran.GetValue("IDObra")) > 0, True, False)
                    .UiCommandManager1.Commands(cnABRIRORDENFABRICACION).IsVisible = IIf(Length(jngLineaAlbaran.GetValue("IDOrden")) > 0, True, False)
                    .UiCommandManager1.Commands(cnABRIRORDENTRABAJO).IsVisible = IIf(Length(jngLineaAlbaran.GetValue("IDOT")) > 0, True, False)
                    .UiCommandManager1.Commands(cnABRIRACTIVO).IsVisible = IIf(mGestionNumeroSerieConActivos AndAlso Length(.GetValue("Lote")) > 0, True, False)
                    If mblnGestionInventarioPermanente Then
                        If Nz(.GetValue("Contabilizado"), enumContabilizado.NoContabilizado) <> enumContabilizado.Contabilizado AndAlso _
                            (Nz(.GetValue("EstadoStock"), enumaclEstadoStock.aclSinGestion) = enumaclEstadoStock.aclActualizado Or (Nz(.GetValue("EstadoStock"), enumaclEstadoStock.aclSinGestion) = enumaclEstadoStock.aclSinGestion And Nz(.GetValue("Especial"), 0) = True)) AndAlso _
                           Nz(.GetValue("EstadoFactura"), enumaclEstadoFactura.aclNoFacturado) = enumaclEstadoFactura.aclNoFacturado Then
                            .UiCommandManager1.Commands(cnCONTABILIZAR_LINEA).IsVisible = True
                        Else
                            .UiCommandManager1.Commands(cnCONTABILIZAR_LINEA).IsVisible = False
                        End If
                        If Nz(.GetValue("Contabilizado"), enumContabilizado.NoContabilizado) <> enumContabilizado.NoContabilizado AndAlso _
                              (Nz(.GetValue("EstadoStock"), enumaclEstadoStock.aclSinGestion) = enumaclEstadoStock.aclActualizado Or (Nz(.GetValue("EstadoStock"), enumaclEstadoStock.aclSinGestion) = enumaclEstadoStock.aclSinGestion And Nz(.GetValue("Especial"), 0) = True)) AndAlso _
                           Nz(.GetValue("EstadoFactura"), enumaclEstadoFactura.aclNoFacturado) = enumaclEstadoFactura.aclNoFacturado Then
                            .UiCommandManager1.Commands(cnDESCONTABILIZAR_LINEA).IsVisible = True
                        Else
                            .UiCommandManager1.Commands(cnDESCONTABILIZAR_LINEA).IsVisible = False
                        End If
                    End If
                End If
            End If
        End With
    End Sub

#End Region

    Private Sub MntoFacturaCompra_RecordAdding(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.RecordAdding
        BloquearDatos()
    End Sub

    Private Sub BloquearDatos()
        If Not Me.RecordsState = RecordsState.Initialize Then
            Dim blnEnabled As Boolean = (Me.CurrentRow("Estado") = enumaccEstado.accFacturado)
            BloquearInformacion(Me.MainPanel, blnEnabled, FwiNAlbaran, fwiCIF, fwiRazonSocial, fwiDirProv, fwiCodPostal, _
                                fwiPoblacion, fwiProvincia, fwiTel, fwiFax, fwiDirCentroGestion, fwiCodPostalCG, _
                                fwiPoblacionCG, fwiProvinciaCG, fwiTelefonoCG, fwiFaxCG, fwiCorreoCG, fwiDto, _
                                fwiImporte, fwiImporteA, fwiImporteB, fwiCambioA, fwiDescMonedaA, fwiCambioB, _
                                fwiDescMonedaB, fwiEstado, NtbImpLineas, NtbImpIva, NtbImporteTotal, NtbDtoProntoPago, NtbRecFinan, NtbPesoBruto, NtbPesoNeto)

            'para que se puedan modificar estos datos para la declaración intrastat
            Me.fwiIdCondEnvio.Enabled = True
            Me.FwiModoTransporte.Enabled = True

            If blnEnabled Then
                jngLineaAlbaran.AllowAddNew = InheritableBoolean.False
                jngLineaAlbaran.AllowDelete = InheritableBoolean.False
            Else
                jngLineaAlbaran.AllowAddNew = InheritableBoolean.True
                jngLineaAlbaran.AllowDelete = InheritableBoolean.True
            End If

            BloquearAccionesContabilidad()
        End If
    End Sub


    Private Sub BloquearAccionesContabilidad()
        If Not mblnGestionInventarioPermanente Then Exit Sub
        Dim LineasContabilizar As List(Of DataRow) = (From c In CType(Me.jngLineaAlbaran.DataSource, DataTable) _
                                                      Where Not c.IsNull("EstadoFactura") AndAlso _
                                                              c("EstadoFactura") = enumaclEstadoFactura.aclNoFacturado AndAlso _
                                                              Not c.IsNull("EstadoStock") AndAlso _
                                                               c("EstadoStock") = enumaclEstadoStock.aclActualizado Or (c("EstadoStock") = enumaclEstadoStock.aclSinGestion And c("Especial") = True) AndAlso _
                                                               Not c.IsNull("Contabilizado") AndAlso _
                                                              c("Contabilizado") <> enumContabilizado.Contabilizado).ToList()

        Dim LineasDescontabilizar As List(Of DataRow) = (From c In CType(Me.jngLineaAlbaran.DataSource, DataTable) _
                                                         Where Not c.IsNull("EstadoFactura") AndAlso _
                                                                c("EstadoFactura") = enumaclEstadoFactura.aclNoFacturado AndAlso _
                                                                Not c.IsNull("EstadoStock") AndAlso _
                                                                  c("EstadoStock") = enumaclEstadoStock.aclActualizado Or (c("EstadoStock") = enumaclEstadoStock.aclSinGestion And c("Especial") = True) AndAlso _
                                                                Not c.IsNull("Contabilizado") AndAlso _
                                                                c("Contabilizado") <> enumContabilizado.NoContabilizado).ToList()

        If Not LineasContabilizar Is Nothing AndAlso LineasContabilizar.Count > 0 Then
            Me.UiCommandManager1.Commands(cnCONTABILIZAR).Enabled = Janus.Windows.UI.InheritableBoolean.True
        Else
            Me.UiCommandManager1.Commands(cnCONTABILIZAR).Enabled = Janus.Windows.UI.InheritableBoolean.False
        End If

        If Not LineasDescontabilizar Is Nothing AndAlso LineasDescontabilizar.Count > 0 Then
            Me.UiCommandManager1.Commands(cnDESCONTABILIZAR).Enabled = Janus.Windows.UI.InheritableBoolean.True
        Else
            Me.UiCommandManager1.Commands(cnDESCONTABILIZAR).Enabled = Janus.Windows.UI.InheritableBoolean.False
        End If

    End Sub
    Private Sub MntoAlbaranCompra_Navigated(ByVal sender As Object, ByVal e As Solmicro.Expertis.Engine.UI.NavigatedEventArgs) Handles MyBase.Navigated
        If Not IsNothing(Me.CurrentData) Then
            If Me.CurrentData.Rows.Count > 0 Then
                mblnValidatingProv = False
                fwiEstado.Text = RecuperarDescripcionEnumerado("enumaccEstado", Me.CurrentRow("Estado"))
                BloquearDatos()
                If Length(Me.CurrentRow("FechaAlbaran")) > 0 Then
                    mstrIDEjercicio = ExpertisApp.ExecuteTask(Of Date, String)(AddressOf EjercicioContable.Predeterminado, Me.CurrentRow("FechaAlbaran"))
                Else
                    mstrIDEjercicio = String.Empty
                End If
                'DigitosCContable()
                TabAlbaranes_Click(TabAlbaranes, New EventArgs)
            End If

            VisibilidadColumnaDesglose()
        End If
        BloquearCondicionesEconomicas()
        LoadGridDefaultValues()
        'If EstadoAlbaran() = False Then GenerateMessage(1090, vbOKOnly, ExpertisApp.Title) '1090- Ha ocurrido un error con el Estado del Albarán.,ExpertisApp.Title
        'fwiIDAlbaran.ReadOnly = True
        'If Me.RecordsState = RecordsState.Saved Then ActivaExecuteProcess()
        CargarDesplegableDetalles()
    End Sub

    Public Sub CargarDesplegableDetalles()
        If Length(fwiIDFormaEnvio.Value) > 0 Then
            Dim detalle As New FormaEnvioDetalle
            Dim dt As DataTable
            Dim filtro As New Filter
            filtro.Add("IDFormaEnvio", FilterOperator.Equal, fwiIDFormaEnvio.Value)
            dt = detalle.Filter(filtro)
            cmbDetalles.DataSource = dt
        End If
    End Sub

    Private Sub BloquearCondicionesEconomicas()
        If Not Me.CurrentRow Is Nothing Then
            Me.fwiIdCondPago.Enabled = Not Nz(Me.CurrentRow("Automatico"), False)
            Me.fwiIdFormaPago.Enabled = Not Nz(Me.CurrentRow("Automatico"), False)
            Me.fwiIdMoneda.Enabled = Not Nz(Me.CurrentRow("Automatico"), False)
            Me.AdvCentroCoste.Enabled = Not Nz(Me.CurrentRow("Automatico"), False)
            Me.NtbDtoAlbaran.Enabled = Not Nz(Me.CurrentRow("Automatico"), False)
        End If
    End Sub

    Private Sub VisibilidadColumnaDesglose()
        If jngLineaAlbaran.RowCount > 0 Then
            Dim lineasAlbaran As DataTable = CType(jngLineaAlbaran.DataSource, DataTable)
            Dim aux() As DataRow
            Dim f As New Filter(FilterUnionOperator.Or)
            f.Add(New BooleanFilterItem("GestionStockPorLotes", FilterOperator.Equal, True))
            f.Add(New BooleanFilterItem("NSerieObligatorio", FilterOperator.Equal, True))
            aux = lineasAlbaran.Select(f.Compose(New AdoFilterComposer))
            jngLineaAlbaran.Columns("Desglose").Visible = (aux.Length <> 0)
        End If
    End Sub

    Private Sub lstFacturasGeneradas_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstFacturasGeneradas.DoubleClick
        'TODO DATATABLE

        If Length(lstFacturasGeneradas.Text) > 0 Then
            'Se coge el NFactura a buscar(puede incluir guiones)
            Dim IntPos As Integer = Strings.InStr(1, lstFacturasGeneradas.Text, " - ")
            Dim StrFactura As String = Strings.Mid(lstFacturasGeneradas.Text, 1, IntPos - 1)

            Dim DtFCC As DataTable = New FacturaCompraCabecera().Filter(New FilterItem("NFactura", FilterOperator.Equal, StrFactura))
            'Como estamos buscando por NFactura, puede que haya varias con el mismo NFactura
            'Hay que buscar aquella factura que contenga ese albarán concreto
            Dim IntIDFact As Integer
            If Not DtFCC Is Nothing AndAlso DtFCC.Rows.Count > 1 Then
                For Each Dr As DataRow In DtFCC.Select
                    Dim DtFCL As DataTable = New FacturaCompraLinea().Filter(New FilterItem("IDFactura", FilterOperator.Equal, Dr("IDFactura")))
                    For Each DrLin As DataRow In DtFCL.Select
                        If DrLin("IDAlbaran") = CInt(Me.CurrentRow("IDAlbaran")) Then
                            IntIDFact = DrLin("IDFactura")
                            Exit For
                        End If
                    Next
                    If IntIDFact > 0 Then Exit For
                Next
            ElseIf Not DtFCC Is Nothing AndAlso DtFCC.Rows.Count > 0 Then
                IntIDFact = DtFCC.Rows(0)("IDFactura")
            End If
            If Not DtFCC Is Nothing AndAlso DtFCC.Rows.Count > 0 Then
                ExpertisApp.OpenForm("MFACC", New NumberFilterItem("IdFactura", IntIDFact))
            Else
                ExpertisApp.GenerateMessage("No se puede abrir la factura. No tiene una factura asociada.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation) 'No se puede abrir la factura. No tiene una factura asociada.
            End If
        End If
    End Sub

    Private Sub fwiEstado_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fwiEstado.DoubleClick
        If Length(Me.CurrentRow("IDAlbaran")) > 0 Then
            Dim IntEstado As Integer = CInt(Me.CurrentRow("Estado"))
            Dim IntEstadoLin As Integer
            Select Case IntEstado
                Case enumaccEstado.accNoFacturado
                    If ExpertisApp.GenerateMessage("Va a dar por facturado el albarán.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then Exit Sub
                    IntEstado = CInt(enumaccEstado.accFacturado)
                    IntEstadoLin = CInt(enumaclEstadoFactura.aclFacturado)
                Case enumaccEstado.accFacturado
                    Dim DtFCL As DataTable = New FacturaCompraLinea().Filter(New NumberFilterItem("IDAlbaran", Me.CurrentRow("IDAlbaran")), "", "Count(*)")
                    If DtFCL.Rows(0)(0) = 0 Then
                        If ExpertisApp.GenerateMessage("Va a dar por no facturado el albarán.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then Exit Sub
                    ElseIf DtFCL.Rows(0)(0) > 0 Then
                        ExpertisApp.GenerateMessage("No se puede marcar este albarán como no facturado.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Exit Sub
                    End If
                    IntEstado = CInt(enumaccEstado.accNoFacturado)
                    IntEstadoLin = CInt(enumaclEstadoFactura.aclNoFacturado)
            End Select
            Dim ClsACL As New AlbaranCompraLinea
            Dim DtACL As DataTable = ClsACL.Filter(New FilterItem("IDAlbaran", FilterOperator.Equal, CInt(Me.CurrentRow("IDAlbaran"))))
            For Each Dr As DataRow In DtACL.Select
                Dr("EstadoFactura") = IntEstadoLin
            Next
            ClsACL.Update(DtACL)
            Me.CurrentRow("Estado") = IntEstado
            fwiEstado.Text = RecuperarDescripcionEnumerado("enumaccEstado", Me.CurrentRow("Estado"))
        End If
    End Sub

    Private Sub MntoAlbaranCompra_SetReportOptions(ByVal sender As Object, ByVal e As Engine.UI.ReportExportOptionsEventArgs) Handles MyBase.SetReportExportOptions
        If e.Alias.ToUpper = "VRPTMNTOALBARANCOMPRA" Then
            e.Options.PromptUser = True
        End If
    End Sub

    Private Sub FwBusquedaDireccion_SetPredefinedFilter(ByVal sender As Object, ByVal e As Solmicro.Expertis.Engine.UI.AdvSearchFilterEventArgs) Handles FwBusquedaDireccion.SetPredefinedFilter
        'En el botón de búsqueda de direcciones de envio hacemos que únicamente salgan aquellas
        'correspondiente al cliente seleccionado, si dicho cliente tiene un grupo, las direcciones
        'que aparecerán serán las correspondientes a ese cliente-grupo.

        'Comprobamos si el cliene tiene grupo.
        Dim datClteGrupo As New Cliente.DataGrupoCliente
        datClteGrupo.IDCliente = fwiIdProveedor.Text
        datClteGrupo.TipoGrupo = "Direccion"
        Dim strIDGrupoDireccion As String = ExpertisApp.ExecuteTask(Of Cliente.DataGrupoCliente, String)(AddressOf Cliente.Grupo, datClteGrupo)
        If Length(strIDGrupoDireccion) > 0 Then
            e.Filter.Add("IDProveedor", FilterOperator.Equal, strIDGrupoDireccion)
        Else
            e.Filter.Add("IDProveedor", FilterOperator.Equal, fwiIdProveedor.Text)
        End If
        'e.Filter.Add("Tipo", FilterOperator.Equal, enumpdTipoDireccion.pdDireccionPedido)
        e.Filter.Add(New BooleanFilterItem("Envio", FilterOperator.Equal, True))
    End Sub

    Private Sub MntoAlbaranCompra_BusinessCalling(ByVal sender As Object, ByVal e As Engine.UI.BusinessCallingEventArgs) Handles MyBase.BusinessCalling
        e.Data.Context.Clear()
        Select Case e.EntityName
            Case jngLineaAlbaran.EntityName
                If Not MDatArt Is Nothing AndAlso Length(MDatArt.IDArticulo) > 0 Then
                    e.Data.CurrentData("IDArticulo") = MDatArt.IDArticulo
                    e.Data.NewData("IDArticulo") = MDatArt.IDArticulo
                End If
                e.Data.Context("IDProveedor") = Me.CurrentRow("IDProveedor")
                'e.Data.Context("IDEjercicio") = me.CurrentRow("IDEjercicio")
                e.Data.Context("Fecha") = Me.CurrentRow("FechaAlbaran")
                e.Data.Context("IDMoneda") = Me.CurrentRow("IDMoneda")
                e.Data.Context("CambioA") = Me.CurrentRow("CambioA")
                e.Data.Context("CambioB") = Me.CurrentRow("CambioB")
                e.Data.Context("IDAlmacen") = Me.CurrentRow("IDAlmacen")
                If MIDArticuloRef <> String.Empty Then e.Data.Context("IDArticuloRef") = MIDArticuloRef

                mblnCambioPrecioManual = False
                mPrecioAnterior = e.Data.CurrentData("Precio")
                If e.Data.NewData.Contains("Precio") Then
                    mblnCambioPrecioManual = True
                End If
        End Select
    End Sub

    Private Sub MntoAlbaranCompra_BusinessCalled(ByVal sender As Object, ByVal e As Engine.UI.BusinessCalledEventArgs) Handles Me.BusinessCalled
        If Not IsNothing(e.Data) Then
            Select Case e.EntityName
                Case jngLineaAlbaran.EntityName
                    If jngLineaAlbaran.Row <> jngLineaAlbaran.newTopRowPosition AndAlso Not mblnCambioPrecioManual AndAlso mPrecioAnterior <> e.Data("Precio") Then
                        If ExpertisApp.GenerateMessage("Ha cambiado el precio de manera automática. ¿Desea mantener el precio anterior?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                            e.Data = New AlbaranCompraLinea().ApplyBusinessRule("Precio", mPrecioAnterior, e.Data, New BusinessData(Me.CurrentRow))
                        End If
                    End If
                    MIDArticuloRef = String.Empty
            End Select
        End If
    End Sub

    Private Sub mLotes_ShowLotesDialog(ByVal sender As Object, ByVal e As CommonClasses.ShowDialogEventArgs) Handles mLotes.ShowLotesDialog
        Dim tipo As enumTipoMovimiento = TipoMovimiento()
        Select Case tipo
            Case enumTipoMovimiento.tmEntAlbaranCompra
                mLotes.Text = "ALBARAN DE ENTRADA"
                mLotes.ClaseMovimiento = [Shared].ClaseMovimiento.Entrada
            Case enumTipoMovimiento.tmEntSubcontratacion
                mLotes.Text = "ENTRADA SUBCONTRATACION"
                mLotes.ClaseMovimiento = [Shared].ClaseMovimiento.Entrada
            Case enumTipoMovimiento.tmSalSubcontratacion
                mLotes.Text = "SALIDA DE SUBCONTRATACION"
                mLotes.ClaseMovimiento = [Shared].ClaseMovimiento.Salida
            Case enumTipoMovimiento.tmEntFabrica
                mLotes.Text = "ENTRADA DE FABRICA"
                mLotes.ClaseMovimiento = [Shared].ClaseMovimiento.Entrada
            Case enumTipoMovimiento.tmSalFabrica
                mLotes.Text = "SALIDA DE FABRICA"
                mLotes.ClaseMovimiento = [Shared].ClaseMovimiento.Salida
        End Select
    End Sub

    Private Sub mLotes_ReturningData(ByVal sender As Object, ByVal e As CommonClasses.ReturningLoteDataEventArgs) Handles mLotes.ReturningData
        If e.DialogResult = DialogResult.OK Then
            Dim lotesAlbaran As DataTable
            Dim negLote As New AlbaranCompraLote
            lotesAlbaran = negLote.Filter(New NumberFilterItem("IDLineaAlbaran", jngLineaAlbaran.GetValue("IDLineaAlbaran")))

            If Not lotesAlbaran Is Nothing Then
                Dim f As New Filter
                For Each data As StockData In e.Lote.StockData
                    If data.Cantidad <> 0 Then
                        Dim newrow As DataRow = negLote.AddNewForm.Rows(0)
                        newrow("IDLineaAlbaran") = jngLineaAlbaran.GetValue("IDLineaAlbaran")
                        newrow("Lote") = data.Lote
                        newrow("Ubicacion") = data.Ubicacion
                        newrow("QInterna") = data.Cantidad
                        newrow("QInterna2") = data.Cantidad2
                        If (Length(data.PrecintaNSerie) > 0) Then newrow("SeriePrecinta") = data.PrecintaNSerie
                        If (Length(data.PrecintaHasta) > 0) Then newrow("NHastaPrecinta") = data.PrecintaHasta
                        If (Length(data.PrecintaDesde) > 0) Then newrow("NDesdePrecinta") = data.PrecintaDesde


                        lotesAlbaran.Rows.Add(newrow.ItemArray)
                    End If
                Next
                negLote.Update(lotesAlbaran)
                Me.RetrieveData(DataProviderActions.Refresh)
            End If
        End If
    End Sub

    Private Sub mLotes_CloseLotesDialog(ByVal sender As Object, ByVal e As System.EventArgs) Handles mLotes.CloseLotesDialog
        mLotes.LoteCollection.RemoveAt(jngLineaAlbaran.GetValue("IDLineaAlbaran"))
    End Sub

    Protected Overridable Sub NumerosDeSerie()
        If Nz(jngLineaAlbaran.GetValue("NSerieObligatorio"), False) AndAlso Length(jngLineaAlbaran.GetValue("IDLineaAlbaran")) > 0 Then
            Dim gridData As DataTable = CType(jngLineaAlbaran.DataSource, DataTable)
            Dim currentRecord As DataRow = CType(jngLineaAlbaran.GetRow.DataRow, DataRowView).Row
            Dim series As DataTable
            Dim EsKit As Boolean = False
            If jngLineaAlbaran.GetValue("TipoLineaCompra") = CInt(enumaclTipoLineaAlbaran.aclComponente) Then
                Dim IntIDLineaPadre As Integer = jngLineaAlbaran.GetValue("IDLineaPadre")
                Dim DtGrid As DataTable = jngLineaAlbaran.DataSource
                Dim DrSel() As DataRow = DtGrid.Select("IDLineaAlbaran = " & IntIDLineaPadre)
                If DrSel.Length > 0 Then
                    If DrSel(0)("tipolineaalbaran") = 1 Then
                        EsKit = True
                    End If
                End If
            End If
            If jngLineaAlbaran.GetValue("QServida") > 0 Then
                If jngLineaAlbaran.GetValue("TipolineaCompra") <> CInt(enumaclTipoLineaAlbaran.aclComponente) OrElse (jngLineaAlbaran.GetValue("TipolineaCompra") = CInt(enumaclTipoLineaAlbaran.aclComponente) And EsKit) Then
                    series = mSeries.SerieCollection.GetDataTable(jngLineaAlbaran.GetValue("IDLineaAlbaran"))
                Else
                    series = mSeries2.SerieCollection.SeriesDeBajaFormatoDataTable(jngLineaAlbaran.GetValue("IDLineaAlbaran"))
                End If
            Else
                If jngLineaAlbaran.GetValue("TipolineaCompra") <> CInt(enumaclTipoLineaAlbaran.aclComponente) OrElse (jngLineaAlbaran.GetValue("TipolineaCompra") = CInt(enumaclTipoLineaAlbaran.aclComponente) And EsKit) Then
                    series = mSeries2.SerieCollection.SeriesDeBajaFormatoDataTable(jngLineaAlbaran.GetValue("IDLineaAlbaran"))
                End If
            End If
            Dim context As New BusinessData
            context("NSerieObligatorio") = True
            Dim acl As New AlbaranCompraLinea

            If Not series Is Nothing AndAlso series.Rows.Count > 0 Then
                Dim currentData As New BusinessData(currentRecord)
                currentData = acl.ApplyBusinessRule("Lote", series.Rows(0)("NSerie"), currentData, context)
                For Each col As DataColumn In currentRecord.Table.Columns
                    currentRecord(col.ColumnName) = currentData(col.ColumnName)
                Next

                Dim DblImporte, DblTotal As Double
                DblTotal = currentRecord("Precio")
                DblImporte = (currentRecord("Precio") * currentRecord("Dto1")) / 100
                DblTotal -= DblImporte
                DblImporte = (DblTotal * currentRecord("Dto2")) / 100
                DblTotal -= DblImporte
                DblImporte = (DblTotal * currentRecord("Dto3")) / 100
                DblTotal -= DblImporte

                currentRecord("Importe") = IIf(currentRecord("QServida") > 0, DblTotal, -DblTotal)
                currentRecord("Lote") = series.Rows(0)("NSerie")
                If series.Columns.Contains("Ubicacion") Then currentRecord("Ubicacion") = series.Rows(0)("Ubicacion")
                currentRecord("IDEstadoActivo") = series.Rows(0)("IDEstadoActivo")
                For i As Integer = 1 To series.Rows.Count - 1
                    Dim newrow As DataRow = gridData.NewRow
                    newrow.ItemArray = currentRecord.ItemArray
                    newrow("IDLineaAlbaran") = DBNull.Value
                    Dim newdata As New BusinessData(newrow)
                    newdata = acl.ApplyBusinessRule("Lote", series.Rows(i)("NSerie"), newdata, context)
                    For Each col As DataColumn In newrow.Table.Columns
                        newrow(col.ColumnName) = newdata(col.ColumnName)
                    Next
                    If series.Columns.Contains("Ubicacion") Then newrow("Ubicacion") = series.Rows(i)("Ubicacion")
                    newrow("IDEstadoActivo") = series.Rows(i)("IDEstadoActivo")
                    newrow("Importe") = IIf(currentRecord("QServida") > 0, DblTotal, -DblTotal)
                    newrow("Lote") = series.Rows(i)("NSerie")
                    newrow("QServida") = IIf(currentRecord("QServida") > 0, 1, -1)
                    newrow("QInterna") = IIf(currentRecord("QServida") > 0, 1, -1)
                    gridData.Rows.Add(newrow)
                Next
                currentRecord("QServida") = IIf(currentRecord("QServida") > 0, 1, -1)
                currentRecord("QInterna") = currentRecord("QServida")
                currentRecord("IDOperario") = series.Rows(0)("IDOperario")
            End If
            '//borramos el desglose para volver a cargar en vacio el formulario de numeros de serie
            mSeries.SerieCollection.Clear()
            mSeries2.SerieCollection.Clear()
        End If
    End Sub

    Private Sub fwiIdAlmacen_SetPredefinedFilter(ByVal sender As System.Object, ByVal e As Solmicro.Expertis.Engine.UI.AdvSearchFilterEventArgs) Handles FwiIdAlmacen.SetPredefinedFilter
        'e.Filter.Add("Activo", FilterOperator.Equal, True)
        e.Filter.Add("IDCentroGestion", FilterOperator.Equal, fwiIdCentroGestion.Text)
    End Sub

    Private Sub fwiIdAlmacen_SelectionChanged(ByVal sender As Object, ByVal e As Engine.UI.AdvSearchSelectionChangedEventArgs) Handles FwiIdAlmacen.SelectionChanged
        If Length(FwiIdAlmacen) > 0 Then
            LoadGridDefaultValues()
        End If
    End Sub

    Private Sub fwiIdCentroGestion_SelectionChanged(ByVal sender As System.Object, ByVal e As Solmicro.Expertis.Engine.UI.AdvSearchSelectionChangedEventArgs) Handles fwiIdCentroGestion.SelectionChanged
        If Length(fwiIdCentroGestion) > 0 Then
            Dim ClsAlmacen As New Almacen
            Dim FilAlm As New Filter
            FilAlm.Add("IDCentroGestion", FilterOperator.Equal, fwiIdCentroGestion)
            FilAlm.Add("Activo", FilterOperator.Equal, True)
            FilAlm.Add("Principal", FilterOperator.Equal, True)
            Dim DtAlm As DataTable = ClsAlmacen.Filter(FilAlm)
            If Not DtAlm Is Nothing AndAlso DtAlm.Rows.Count > 0 Then
                FwiIdAlmacen = DtAlm.Rows(0)("IDAlmacen")
                FwiIdAlmacen.Text = DtAlm.Rows(0)("IDAlmacen")
            End If
            LoadGridDefaultValues()
        End If
    End Sub

    Private Sub fwiTextoAlbaran_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fwiTextoAlbaran.DoubleClick
        Dim frm As FormularioTexto
        frm = New FormularioTexto
        frm.Texto = fwiTextoAlbaran.Text & String.Empty
        Dim res As DialogResult
        res = frm.ShowDialog()
        If res = DialogResult.OK Then
            If fwiTextoAlbaran.Text & String.Empty <> frm.Texto Then
                fwiTextoAlbaran.Text = frm.Texto
            End If
        End If
        frm = Nothing

    End Sub

    Private Sub fwiIdCondPago_SelectionChanged(ByVal sender As Object, ByVal e As Engine.UI.AdvSearchSelectionChangedEventArgs) Handles fwiIdCondPago.SelectionChanged
        If Me.RecordsState = RecordsState.Initialize Then Exit Sub
        If Not Me.jngLineaAlbaran.DataSource Is Nothing AndAlso CType(jngLineaAlbaran.DataSource, DataTable).Rows.Count > 0 Then
            Dim ACL As New AlbaranCompraLinea
            Dim context As New BusinessData(Me.CurrentRow)
            Dim f As New Filter
            f.Add(New IsNullFilterItem("IDLineaPedido"))
            For Each drLinea As DataRow In CType(jngLineaAlbaran.DataSource, DataTable).Select(f.Compose(New AdoFilterComposer))
                Dim Current As New BusinessData(drLinea)
                Current = ACL.ApplyBusinessRule("IDCondicionPago", fwiIdCondPago.Value, Current, context)
                For Each col As DataColumn In drLinea.Table.Columns
                    drLinea(col.ColumnName) = Current(col.ColumnName)
                Next
            Next
        End If
    End Sub

    Private Sub fwiIdFormaPago_SelectionChanged(ByVal sender As Object, ByVal e As Engine.UI.AdvSearchSelectionChangedEventArgs) Handles fwiIdFormaPago.SelectionChanged
        If Me.RecordsState = RecordsState.Initialize Then Exit Sub
        If Not Me.jngLineaAlbaran.DataSource Is Nothing AndAlso CType(jngLineaAlbaran.DataSource, DataTable).Rows.Count > 0 Then
            Dim f As New Filter
            f.Add(New IsNullFilterItem("IDLineaPedido"))
            For Each drLinea As DataRow In CType(jngLineaAlbaran.DataSource, DataTable).Select(f.Compose(New AdoFilterComposer))
                drLinea("IDformaPago") = fwiIdFormaPago.Value
            Next
        End If
    End Sub

    Private Sub NtbDtoProntoPago_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles NtbDtoProntoPago.Validating
        If Me.NtbDtoProntoPago.Value > 100 Then
            ExpertisApp.GenerateMessage("El Descuento Pronto Pago no puede ser superior a 100%.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            e.Cancel = True
        End If
    End Sub

    Protected Overridable Sub NtbDtoAlbaran_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles NtbDtoAlbaran.Validating
        If Me.NtbDtoAlbaran.Value > 100 Then
            ExpertisApp.GenerateMessage("El Descuento Albarán no puede ser superior a 100%.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            e.Cancel = True
        End If
    End Sub

    Private Sub NtbDtoAlbaran_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles NtbDtoAlbaran.ValueChanged
        If Me.RecordsState = RecordsState.Initialize Then Exit Sub
        If Not Me.jngLineaAlbaran.DataSource Is Nothing AndAlso CType(jngLineaAlbaran.DataSource, DataTable).Rows.Count > 0 Then
            Dim ACL As New AlbaranCompraLinea
            Dim context As New BusinessData(Me.CurrentRow)
            Dim f As New Filter
            f.Add(New IsNullFilterItem("IDLineaPedido"))
            f.Add(New BooleanFilterItem("Especial", False))
            For Each drLinea As DataRow In CType(jngLineaAlbaran.DataSource, DataTable).Select(f.Compose(New AdoFilterComposer))
                Dim Current As New BusinessData(drLinea)
                Current = ACL.ApplyBusinessRule("Dto", NtbDtoAlbaran.Value, Current, context)
                For Each col As DataColumn In drLinea.Table.Columns
                    drLinea(col.ColumnName) = Current(col.ColumnName)
                Next
            Next
        End If
    End Sub


    Private Sub MntoAlbaranCompra_RecordUpdated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.RecordUpdated
        mblnValidatingProv = False
        MostrarDetalleActualizacionStocks()
        LoadGridDefaultValues()
        If mblnGestionInventarioPermanente Then BloquearAccionesContabilidad()
    End Sub

    Private Sub MostrarDetalleActualizacionStocks()
        Dim ActAcutomatica As Boolean = New Parametro().ActAutomaticaAlbCompra
        If ActAcutomatica Then
            Dim log As AlbaranLogProcess = System.Runtime.Remoting.Messaging.CallContext.GetData(GetType(AlbaranLogProcess).Name)
            System.Runtime.Remoting.Messaging.CallContext.FreeNamedDataSlot(GetType(AlbaranLogProcess).Name)
            If Not log Is Nothing AndAlso Not log.StockUpdateData Is Nothing AndAlso log.StockUpdateData.Length > 0 Then
                Dim detalle As New ERP.CommonClasses.DetalleActualizacionStock
                detalle.DataSource = log.StockUpdateData
                detalle.ShowDialog()
            End If
        End If
    End Sub

    Private Sub MntoAlbaranCompra_RecordStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.RecordStateChanged
        LoadGridDefaultValues()
    End Sub

    Private Sub fwiIdProveedor_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles fwiIdProveedor.Validated
        LoadGridDefaultValues()
        CargarDesplegableDetalles()
    End Sub

    Private Sub fwiIdFormaPago_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles fwiIdFormaPago.Validated
        LoadGridDefaultValues()
    End Sub

    Private Sub fwiIdCondPago_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles fwiIdCondPago.Validated
        LoadGridDefaultValues()
    End Sub

    Protected Overridable Sub jngLineaAlbaran_UpdatingCell(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.UpdatingCellEventArgs) Handles jngLineaAlbaran.UpdatingCell
        Select Case e.Column.Key
            Case "CContable"
                If Length(Me.CurrentRow("IDEjercicio")) > 0 Then
                    Dim objNegEjercicio As New EjercicioContable
                    Dim strEjercicio As String = Me.CurrentRow("IDEjercicio")
                    Dim intDigitosAuxiliar As Integer = objNegEjercicio.GetNDigitosAuxiliar(strEjercicio)
                    e.Value = PuntoPorCero(Nz(e.Value, String.Empty), intDigitosAuxiliar, strEjercicio)
                End If
            Case "Dto1", "Dto2", "Dto3", "Dto", "DtoProntoPago"
                If e.Value > 100 Then
                    ExpertisApp.GenerateMessage("El Descuento introducido no puede ser superior a 100%.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    e.Cancel = True
                End If
        End Select
    End Sub

    Private Sub ValidarCambioProveedor()
        If Length(Me.CurrentRow("IDProveedor")) > 0 AndAlso Not mblnValidatingProv Then
            If fwiIdProveedor.Value & String.Empty <> Me.CurrentRow("IDProveedor") & String.Empty AndAlso Me.jngLineaAlbaran.RowCount > 0 Then
                ExpertisApp.GenerateMessage("La modificación del proveedor no afectará a la información de las líneas")
            End If
        End If
    End Sub

    Private Sub fwiIdProveedor_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles fwiIdProveedor.Validating
        ValidarCambioProveedor()
    End Sub

    Private Sub fwiIdProveedor_SelectionChanged(ByVal sender As Object, ByVal e As Engine.UI.AdvSearchSelectionChangedEventArgs) Handles fwiIdProveedor.SelectionChanged
        ValidarCambioProveedor()
        mblnValidatingProv = True
    End Sub

    Private Sub fwiFechaAlbaran_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles fwiFechaAlbaran.Validated
        If Me.RecordsState = UI.RecordsState.Modified Then
            If Me.jngLineaAlbaran.RecordCount > 0 Then
                Dim FilHist As New Filter
                Dim StrIDArt As String = String.Empty
                Dim StrIDAlm As String = String.Empty
                For Each Dr As DataRow In CType(Me.jngLineaAlbaran.DataSource, DataTable).Select("", "IDArticulo, IDAlmacen")
                    If (StrIDArt <> Dr("IDArticulo") Or StrIDAlm <> Dr("IDAlmacen")) Then
                        If Dr("EstadoStock") = CInt(enumavlEstadoStock.avlActualizado) Then
                            'miramos si hay un inventario en medio de las dos fechas.
                            If Me.CurrentRow("FechaAlbaran") < Me.CurrentRow("FechaAlbaran", DataRowVersion.Original) Then
                                If New Parametro().TipoInventario = TipoInventario.PrimerMovimiento Then
                                    FilHist.Add("FechaDocumento", FilterOperator.GreaterThan, Me.CurrentRow("FechaAlbaran"))
                                    FilHist.Add("FechaDocumento", FilterOperator.LessThanOrEqual, Me.CurrentRow("FechaAlbaran", DataRowVersion.Original))
                                    FilHist.Add("IDTipoMovimiento", FilterOperator.Equal, enumTipoMovimiento.tmInventario)
                                    FilHist.Add("IDArticulo", FilterOperator.Equal, Dr("IDArticulo"))
                                    FilHist.Add("IDAlmacen", FilterOperator.Equal, Dr("IDAlmacen"))
                                Else
                                    FilHist.Add("FechaDocumento", FilterOperator.GreaterThanOrEqual, Me.CurrentRow("FechaAlbaran"))
                                    FilHist.Add("FechaDocumento", FilterOperator.LessThan, Me.CurrentRow("FechaAlbaran", DataRowVersion.Original))
                                    FilHist.Add("IDTipoMovimiento", FilterOperator.Equal, enumTipoMovimiento.tmInventario)
                                    FilHist.Add("IDArticulo", FilterOperator.Equal, Dr("IDArticulo"))
                                    FilHist.Add("IDAlmacen", FilterOperator.Equal, Dr("IDAlmacen"))
                                End If
                            Else
                                If New Parametro().TipoInventario = TipoInventario.PrimerMovimiento Then
                                    FilHist.Add("FechaDocumento", FilterOperator.LessThanOrEqual, Me.CurrentRow("FechaAlbaran"))
                                    FilHist.Add("FechaDocumento", FilterOperator.GreaterThan, Me.CurrentRow("FechaAlbaran", DataRowVersion.Original))
                                    FilHist.Add("IDTipoMovimiento", FilterOperator.Equal, enumTipoMovimiento.tmInventario)
                                    FilHist.Add("IDArticulo", FilterOperator.Equal, Dr("IDArticulo"))
                                    FilHist.Add("IDAlmacen", FilterOperator.Equal, Dr("IDAlmacen"))
                                Else
                                    FilHist.Add("FechaDocumento", FilterOperator.LessThan, Me.CurrentRow("FechaAlbaran"))
                                    FilHist.Add("FechaDocumento", FilterOperator.GreaterThanOrEqual, Me.CurrentRow("FechaAlbaran", DataRowVersion.Original))
                                    FilHist.Add("IDTipoMovimiento", FilterOperator.Equal, enumTipoMovimiento.tmInventario)
                                    FilHist.Add("IDArticulo", FilterOperator.Equal, Dr("IDArticulo"))
                                    FilHist.Add("IDAlmacen", FilterOperator.Equal, Dr("IDAlmacen"))
                                End If
                            End If
                            Dim DtHist As DataTable = New BE.DataEngine().Filter("tbHistoricoMovimiento", FilHist)
                            If Not DtHist Is Nothing AndAlso DtHist.Rows.Count > 0 Then
                                'si hay un inventario entre las dos fechas, miramos si ha habido otro inventario posterior. En ese caso no importaría modificar la fecha.
                                Dim FilPost As New Filter
                                If Me.CurrentRow("FechaAlbaran") < Me.CurrentRow("FechaAlbaran", DataRowVersion.Original) Then
                                    If New Parametro().TipoInventario = TipoInventario.PrimerMovimiento Then
                                        FilPost.Add("FechaDocumento", FilterOperator.GreaterThan, Me.CurrentRow("FechaAlbaran", DataRowVersion.Original))
                                        FilPost.Add("IDTipoMovimiento", FilterOperator.Equal, enumTipoMovimiento.tmInventario)
                                        FilPost.Add("IDArticulo", FilterOperator.Equal, Dr("IDArticulo"))
                                        FilPost.Add("IDAlmacen", FilterOperator.Equal, Dr("IDAlmacen"))
                                    Else
                                        FilPost.Add("FechaDocumento", FilterOperator.GreaterThanOrEqual, Me.CurrentRow("FechaAlbaran", DataRowVersion.Original))
                                        FilPost.Add("IDTipoMovimiento", FilterOperator.Equal, enumTipoMovimiento.tmInventario)
                                        FilPost.Add("IDArticulo", FilterOperator.Equal, Dr("IDArticulo"))
                                        FilPost.Add("IDAlmacen", FilterOperator.Equal, Dr("IDAlmacen"))
                                    End If
                                Else
                                    If New Parametro().TipoInventario = TipoInventario.PrimerMovimiento Then
                                        FilPost.Add("FechaDocumento", FilterOperator.GreaterThan, Me.CurrentRow("FechaAlbaran"))
                                        FilPost.Add("IDTipoMovimiento", FilterOperator.Equal, enumTipoMovimiento.tmInventario)
                                        FilPost.Add("IDArticulo", FilterOperator.Equal, Dr("IDArticulo"))
                                        FilPost.Add("IDAlmacen", FilterOperator.Equal, Dr("IDAlmacen"))
                                    Else
                                        FilPost.Add("FechaDocumento", FilterOperator.GreaterThanOrEqual, Me.CurrentRow("FechaAlbaran"))
                                        FilPost.Add("IDTipoMovimiento", FilterOperator.Equal, enumTipoMovimiento.tmInventario)
                                        FilPost.Add("IDArticulo", FilterOperator.Equal, Dr("IDArticulo"))
                                        FilPost.Add("IDAlmacen", FilterOperator.Equal, Dr("IDAlmacen"))
                                    End If
                                End If
                                Dim DtPost As DataTable = New BE.DataEngine().Filter("tbHistoricoMovimiento", FilPost)
                                If DtPost Is Nothing OrElse DtPost.Rows.Count = 0 Then
                                    ExpertisApp.GenerateMessage("No se puede modificar la fecha del Albarán, existe un movimiento de Inventario posterior a esa fecha.")
                                    Me.fwiFechaAlbaran.Value = Me.CurrentRow("FechaAlbaran", DataRowVersion.Original)
                                    Exit For
                                End If
                                FilPost.Clear()
                            End If
                            StrIDArt = Dr("IDArticulo") : StrIDAlm = Dr("IDAlmacen")
                            FilHist.Clear()
                        End If
                    End If
                Next
            End If
        End If
    End Sub

    Private Sub jngLineaAlbaran_RecordUpdated(ByVal sender As Object, ByVal e As System.EventArgs) Handles jngLineaAlbaran.RecordUpdated
        jngLineaAlbaran.DataSource = TratarOrdenesLinea(jngLineaAlbaran.DataSource, "IDOrdenLinea", True)
    End Sub

    Private Sub MntoAlbaranCompra_RecordDeleting(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.RecordDeleting
        If mBlnEsBodega Then
            Dim DtLineas As DataTable = Me.jngLineaAlbaran.DataSource
            For Each DrLinea As DataRow In DtLineas.Select
                Dim FilLote As New Filter
                FilLote.Add("IDLineaAlbaran", FilterOperator.Equal, DrLinea("IDLineaAlbaran"))
                FilLote.Add(New IsNullFilterItem("NEntrada", False))
                Dim DtLote As DataTable = New AlbaranCompraLote().Filter(FilLote)
                If Not DtLote Is Nothing AndAlso DtLote.Rows.Count > 0 Then
                    ExpertisApp.GenerateMessage("No se puede borrar la línea, tiene desglose de Lotes con Entradas de Vino.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    e.Cancel = True
                    Exit Sub
                End If
            Next
        End If
    End Sub

    Private Sub cmbDetalles_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim dr As DataRowView = cmbDetalles.SelectedItem()
        If Not dr Is Nothing Then
            txtConductor.Text = dr("Conductor")
            txtDniConductor.Text = dr("DNIConductor")
            txtMatricula.Text = dr("Matricula")
            txtRemolque.Text = dr("Remolque")
            cmbDetalles.Text = dr("Conductor")
            txtEmpresa.Focus()
        End If
    End Sub

    Private Sub fwiIDFormaEnvio_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles fwiIDFormaEnvio.Validated
        CargarDesplegableDetalles()
    End Sub

    Private Sub cmbDetalles_ValueChanged1(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbDetalles.ValueChanged
        Dim dr As DataRowView = cmbDetalles.SelectedItem()
        txtConductor.Text = Nz(dr("Conductor"), String.Empty)
        txtDniConductor.Text = Nz(dr("DNIConductor"), String.Empty)
        txtMatricula.Text = Nz(dr("Matricula"), String.Empty)
        txtRemolque.Text = Nz(dr("Remolque"), String.Empty)
        txtEmpresa.Focus()
    End Sub

End Class