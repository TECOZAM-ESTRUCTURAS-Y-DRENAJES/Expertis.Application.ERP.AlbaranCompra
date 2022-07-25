Imports Janus.Windows.GridEX
Public Class FrmGastos
    Inherits Solmicro.Expertis.Engine.UI.FormBase

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()
        Me.Grid.RelationMode = RelationMode.NoRelation
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
    Friend WithEvents FraDatosLinea As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents ulDescArticulo As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Friend WithEvents pnlImportes As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents lblImporte As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblTotalLineas As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtImporte As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents txtTotalLineas As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents Panel1 As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents CmbAceptar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents cmbCancelar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents lblArticulo As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtIDArticulo As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents Grid As Solmicro.Expertis.Engine.UI.Grid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim Grid_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim Grid_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.ImageList.ImageStream")
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmGastos))
        Me.FraDatosLinea = New Solmicro.Expertis.Engine.UI.Frame
        Me.ulDescArticulo = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.lblArticulo = New Solmicro.Expertis.Engine.UI.Label
        Me.txtIDArticulo = New Solmicro.Expertis.Engine.UI.TextBox
        Me.pnlImportes = New Solmicro.Expertis.Engine.UI.Panel
        Me.lblImporte = New Solmicro.Expertis.Engine.UI.Label
        Me.lblTotalLineas = New Solmicro.Expertis.Engine.UI.Label
        Me.txtImporte = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.txtTotalLineas = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.Panel1 = New Solmicro.Expertis.Engine.UI.Panel
        Me.CmbAceptar = New Solmicro.Expertis.Engine.UI.Button
        Me.cmbCancelar = New Solmicro.Expertis.Engine.UI.Button
        Me.Grid = New Solmicro.Expertis.Engine.UI.Grid
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.FraDatosLinea.SuspendLayout()
        Me.pnlImportes.suspendlayout()
        Me.Panel1.suspendlayout()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FraDatosLinea
        '
        Me.FraDatosLinea.Controls.Add(Me.ulDescArticulo)
        Me.FraDatosLinea.Controls.Add(Me.lblArticulo)
        Me.FraDatosLinea.Controls.Add(Me.txtIDArticulo)
        Me.FraDatosLinea.Dock = System.Windows.Forms.DockStyle.Top
        Me.FraDatosLinea.Location = New System.Drawing.Point(0, 0)
        Me.FraDatosLinea.Name = "FraDatosLinea"
        Me.FraDatosLinea.Size = New System.Drawing.Size(595, 53)
        Me.FraDatosLinea.TabIndex = 1
        Me.FraDatosLinea.TabStop = False
        Me.FraDatosLinea.Text = "Datos Línea"
        '
        'ulDescArticulo
        '
        Me.ulDescArticulo.Location = New System.Drawing.Point(178, 21)
        Me.ulDescArticulo.Name = "ulDescArticulo"
        Me.ulDescArticulo.Size = New System.Drawing.Size(342, 21)
        Me.ulDescArticulo.TabIndex = 5
        '
        'lblArticulo
        '
        Me.lblArticulo.Location = New System.Drawing.Point(9, 21)
        Me.lblArticulo.Name = "lblArticulo"
        Me.lblArticulo.Size = New System.Drawing.Size(50, 13)
        Me.lblArticulo.TabIndex = 0
        Me.lblArticulo.Text = "Artículo"
        '
        'txtIDArticulo
        '
        Me.txtIDArticulo.DisabledBackColor = System.Drawing.Color.White
        Me.txtIDArticulo.Enabled = False
        Me.txtIDArticulo.Location = New System.Drawing.Point(64, 21)
        Me.txtIDArticulo.Name = "txtIDArticulo"
        Me.txtIDArticulo.Size = New System.Drawing.Size(112, 21)
        Me.txtIDArticulo.TabIndex = 3
        '
        'pnlImportes
        '
        Me.pnlImportes.Controls.Add(Me.lblImporte)
        Me.pnlImportes.Controls.Add(Me.lblTotalLineas)
        Me.pnlImportes.Controls.Add(Me.txtImporte)
        Me.pnlImportes.Controls.Add(Me.txtTotalLineas)
        Me.pnlImportes.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlImportes.Location = New System.Drawing.Point(0, 238)
        Me.pnlImportes.Name = "pnlImportes"
        Me.pnlImportes.Size = New System.Drawing.Size(595, 27)
        Me.pnlImportes.TabIndex = 13
        '
        'lblImporte
        '
        Me.lblImporte.Location = New System.Drawing.Point(251, 7)
        Me.lblImporte.Name = "lblImporte"
        Me.lblImporte.Size = New System.Drawing.Size(53, 13)
        Me.lblImporte.TabIndex = 9
        Me.lblImporte.Text = "Importe"
        '
        'lblTotalLineas
        '
        Me.lblTotalLineas.Location = New System.Drawing.Point(416, 7)
        Me.lblTotalLineas.Name = "lblTotalLineas"
        Me.lblTotalLineas.Size = New System.Drawing.Size(72, 13)
        Me.lblTotalLineas.TabIndex = 11
        Me.lblTotalLineas.Text = "Total líneas"
        '
        'txtImporte
        '
        Me.txtImporte.DisabledBackColor = System.Drawing.Color.White
        Me.txtImporte.Enabled = False
        Me.txtImporte.Location = New System.Drawing.Point(307, 3)
        Me.txtImporte.Name = "txtImporte"
        Me.txtImporte.Size = New System.Drawing.Size(100, 21)
        Me.txtImporte.TabIndex = 10
        Me.txtImporte.TabStop = False
        '
        'txtTotalLineas
        '
        Me.txtTotalLineas.DisabledBackColor = System.Drawing.Color.White
        Me.txtTotalLineas.Enabled = False
        Me.txtTotalLineas.Location = New System.Drawing.Point(491, 3)
        Me.txtTotalLineas.Name = "txtTotalLineas"
        Me.txtTotalLineas.Size = New System.Drawing.Size(100, 21)
        Me.txtTotalLineas.TabIndex = 8
        Me.txtTotalLineas.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.CmbAceptar)
        Me.Panel1.Controls.Add(Me.cmbCancelar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 265)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(595, 40)
        Me.Panel1.TabIndex = 12
        '
        'CmbAceptar
        '
        Me.CmbAceptar.Location = New System.Drawing.Point(210, 7)
        Me.CmbAceptar.Name = "CmbAceptar"
        Me.CmbAceptar.Size = New System.Drawing.Size(94, 29)
        Me.CmbAceptar.TabIndex = 19
        Me.CmbAceptar.Text = "Aceptar"
        '
        'cmbCancelar
        '
        Me.cmbCancelar.Location = New System.Drawing.Point(310, 7)
        Me.cmbCancelar.Name = "cmbCancelar"
        Me.cmbCancelar.Size = New System.Drawing.Size(94, 29)
        Me.cmbCancelar.TabIndex = 20
        Me.cmbCancelar.Text = "Cancelar"
        '
        'Grid
        '
        Me.Grid.AdvSearchColumns = New Solmicro.Expertis.Engine.UI.AdvSearchColumns(New Solmicro.Expertis.Engine.UI.AdvSearchColumn() {New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDArticulo", "Articulo", "IDArticulo", New Solmicro.Expertis.Engine.UI.ASSelectedColumns(New Solmicro.Expertis.Engine.UI.ASSelectedColumn() {New Solmicro.Expertis.Engine.UI.ASSelectedColumn("DescArticulo", "DescArticulo")}))})
        Grid_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("Grid_DesignTimeLayout_Reference_0.Instance"), Object)
        Grid_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {Grid_DesignTimeLayout_Reference_0})
        Grid_DesignTimeLayout.LayoutString = resources.GetString("Grid_DesignTimeLayout.LayoutString")
        Me.Grid.DesignTimeLayout = Grid_DesignTimeLayout
        Me.Grid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Grid.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.Grid.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.Grid.EntityName = "AlbaranCompraPrecio"
        Me.Grid.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.Grid.ImageList = Me.ImageList1
        Me.Grid.Location = New System.Drawing.Point(0, 53)
        Me.Grid.Name = "Grid"
        Me.Grid.PrimaryDataFields = ""
        Me.Grid.RelationMode = Solmicro.Expertis.Engine.RelationMode.NoRelation
        Me.Grid.SecondaryDataFields = ""
        Me.Grid.Size = New System.Drawing.Size(595, 185)
        Me.Grid.TabIndex = 14
        Me.Grid.ViewName = "vFrmAlbaranCompraGastos"
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "mail_attachment.ico")
        '
        'FrmGastos
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(595, 305)
        Me.Controls.Add(Me.Grid)
        Me.Controls.Add(Me.pnlImportes)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.FraDatosLinea)
        Me.CreateTransaction = True
        Me.Name = "FrmGastos"
        Me.NavigationFields = ""
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Imputación de Gastos"
        Me.FraDatosLinea.ResumeLayout(False)
        Me.FraDatosLinea.PerformLayout()
        Me.pnlImportes.ResumeLayout(False)
        Me.pnlImportes.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public mdtArtEspecial As DataTable
    Public mblnArtEspecial As Boolean
    Private mdblCambioA, mdblCambioB As Double
    Private IDMoneda As String
    Private mSoloLectura As Boolean

    Public Overrides ReadOnly Property RequeryRecords() As Engine.RequeryMode
        Get
            Return RequeryMode.AllRecords
        End Get
    End Property

    Public Sub AbrirGastos(ByVal intIDLineaAlbaran As Integer, ByVal intIDAlbaran As Integer, _
                           ByVal strIDArticulo As String, ByVal strDescArticulo As String, _
                           ByVal dblPrecio As Double, ByVal dblImporte As Double, ByVal IDMoneda As String, _
                           ByVal dblCambioA As Double, ByVal dblCambioB As Double, ByVal Abreviatura As String, Optional ByVal SoloLectura As Boolean = False)

        txtIDArticulo.Text = strIDArticulo
        ulDescArticulo.Text = strDescArticulo
        txtImporte.Value = dblImporte
        mdblCambioA = dblCambioA
        mdblCambioB = dblCambioB

        Me.IDMoneda = IDMoneda
        If Length(txtIDArticulo.Text) > 0 Then
            Dim de As New BE.DataEngine
            Dim f As New Filter
            f.Add(New StringFilterItem("IDArticulo", strIDArticulo))
            Dim dt As DataTable = de.Filter("vfrmArticuloEspecial", f)
            If Not IsNothing(dt) AndAlso dt.Rows.Count > 0 Then
                mblnArtEspecial = dt.Rows(0)("Especial")
            End If

            pnlImportes.Visible = mblnArtEspecial
            With Grid
                .Columns("IDLineaAlbaran").Visible = mblnArtEspecial
                .Columns("IDLineaAlbaranHija").Visible = Not mblnArtEspecial
                .Columns("IDArticuloHijo").Visible = mblnArtEspecial
                .Columns("DescArticuloHijo").Visible = mblnArtEspecial
                .Columns("IDArticulo").Visible = Not mblnArtEspecial
                .Columns("DescArticulo").Visible = Not mblnArtEspecial

                f.Clear()
                If mblnArtEspecial Then
                    .Columns("IDLineaAlbaranHija").DefaultValue = intIDLineaAlbaran
                    .Columns("IDArticulo").DefaultValue = txtIDArticulo.Text
                    .Columns("DescArticulo").DefaultValue = ulDescArticulo.Text
                    .Columns("Precio").DefaultValue = dblImporte
                    .Columns("Abreviatura").DefaultValue = Abreviatura

                    Dim f2 As New Filter
                    f2.Add(New NumberFilterItem("IDAlbaran", intIDAlbaran))
                    f2.Add(New BooleanFilterItem("Especial", False))
                    mdtArtEspecial = de.Filter("vFrmAlbaranArticulosEspeciales", f2)

                    .Columns("IDLineaAlbaran").DropDown.SetDataBinding(mdtArtEspecial, String.Empty)
                    f.Add(New NumberFilterItem("IDLineaAlbaranHija", intIDLineaAlbaran))
                Else
                    .Columns("IDLineaAlbaran").DefaultValue = intIDLineaAlbaran
                    .Columns("IDArticulo").DefaultValue = txtIDArticulo.Text
                    .Columns("DescArticulo").DefaultValue = ulDescArticulo.Text
                    '.Columns("Precio").DefaultValue = dblImporte
                    .Columns("Abreviatura").DefaultValue = Abreviatura

                    Dim f2 As New Filter
                    f2.Add(New NumberFilterItem("IDAlbaran", intIDAlbaran))
                    f2.Add(New BooleanFilterItem("Especial", True))
                    mdtArtEspecial = de.Filter("vFrmAlbaranArticulosEspeciales", f2)

                    .Columns("IDLineaAlbaranHija").DropDown.SetDataBinding(mdtArtEspecial, String.Empty)

                    f.Add(New NumberFilterItem("IDLineaAlbaran", intIDLineaAlbaran))
                End If

                .Filter = f
            End With
        End If
        mSoloLectura = SoloLectura
        If SoloLectura Then
            'Grid.AllowEdit = False
            Grid.AllowDelete = False
            Grid.AllowAddNew = False
        End If
        Me.ShowDialog()
    End Sub

    Private Sub frmGastos_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CalcularTotales(Grid, New EventArgs)
    End Sub

#Region " Grid "

    Private Sub Grid_EditingCell(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.EditingCellEventArgs) Handles Grid.EditingCell
        With Grid
            Select Case e.Column.Key
                Case "IDArticulo"
                    If Length(.Value("IDLineaAlbaranHija")) > 0 OrElse mSoloLectura Then
                        .Columns("IDArticulo").ButtonStyle = Janus.Windows.GridEX.ButtonStyle.NoButton
                        e.Cancel = True
                    Else
                        .Columns("IDArticulo").ButtonStyle = Janus.Windows.GridEX.ButtonStyle.Image
                    End If
                Case "DescArticulo"
                    If Length(.Value("IDLineaAlbaranHija")) > 0 Then
                        e.Cancel = True
                    End If
                Case "IDLineaAlbaranHija"
                    If mblnArtEspecial Then e.Cancel = True
                Case "Porcentaje"
                    If Not Nz(.Value("PorPorcentaje"), False) Then e.Cancel = True
            End Select
        End With
        If mSoloLectura AndAlso e.Column.Key <> "IDArticulo" Then
            e.Cancel = True
        End If
    End Sub

    Private Sub Grid_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Grid.Click
        Dim hit As GridArea
        With Grid
            hit = .HitTest()
            If hit = GridArea.Cell Or hit = GridArea.NewRowCell Then
                Dim c As GridEXColumn = .ColumnFromPoint()
                If Not IsNothing(c) Then
                    Select Case c.Key
                        Case "Albaran"
                            If Not mSoloLectura Then
                                Dim frm As New frmAlbaranesEspeciales
                                Dim dr As DataRow = frm.AbrirGastos(.Value("IDLineaAlbaran"), mblnArtEspecial)
                                If Not IsNothing(dr) Then
                                    If mblnArtEspecial Then
                                        .Value("IDLineaAlbaran") = dr("IDLineaAlbaran")
                                        .Value("IDArticuloHijo") = dr("IDArticulo")
                                        .Value("DescArticuloHijo") = dr("DescArticulo")
                                    Else
                                        .Value("IDLineaAlbaranHija") = dr("IDLineaAlbaran")
                                        .Value("IDArticulo") = dr("IDArticulo")
                                        .Value("DescArticulo") = dr("DescArticulo")
                                        .Value("Precio") = dr("Importe")
                                        .Value("ImporteAHija") = dr("ImporteA")
                                        .Value("ImporteBHija") = dr("ImporteB")
                                        .Value("Abreviatura") = dr("Abreviatura")
                                    End If
                                End If
                            End If

                    End Select
                End If
            End If
        End With
    End Sub

    Private Sub Grid_UpdatingRecord(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Grid.UpdatingRecord
        With Grid
            If Length(.Value("IDArticulo")) = 0 OrElse Length(.Value("DescArticulo")) = 0 Then
                e.Cancel = True
                ExpertisApp.GenerateMessage("Artículo y Desc. Artículo son obligatorios.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        End With
    End Sub

    Private Sub Grid_AdvSearchSetPredefinedFilter(ByVal sender As System.Object, ByVal e As Solmicro.Expertis.Engine.UI.GridAdvSearchFilterEventArgs) Handles Grid.AdvSearchSetPredefinedFilter
        Select Case e.Key
            Case "IDArticulo"
                e.Filter.Add(New BooleanFilterItem("Especial", True))
        End Select
    End Sub

    Private Sub CalcularTotales(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Grid.RecordAdded, Grid.RecordUpdated, Grid.RecordsDeleted
        txtTotalLineas.Value = Grid.GetTotal(Grid.Columns("Importe"), Janus.Windows.GridEX.AggregateFunction.Sum)
    End Sub

#End Region

    Private Sub CmbAceptar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmbAceptar.Click
        Me.UpdateData()

        Me.Close()
    End Sub

    Private Sub cmbCancelar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbCancelar.Click
        Me.Close()
    End Sub

    Private Sub FrmGastos_BusinessCalling(ByVal sender As Object, ByVal e As Engine.UI.BusinessCallingEventArgs) Handles MyBase.BusinessCalling
        e.Data.Context.Clear()
        If e.EntityName = Grid.EntityName Then
            e.Data.Context("IDMoneda") = Me.IDMoneda
            e.Data.Context("CambioA") = mdblCambioA
            e.Data.Context("CambioB") = mdblCambioB
            e.Data.Context("dtArtEspecial") = mdtArtEspecial
        End If
    End Sub

End Class
