Imports Solmicro.Expertis.Business.Calidad

Public Class frmValoracionSuministro
    Inherits Solmicro.Expertis.Engine.UI.FormBase

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()
        Me.jngValoracion.RelationMode = RelationMode.NoRelation
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
    Friend WithEvents fwiArticulo As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents lblfwiArticulo As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents fwiAlbaran As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents lblfwiAlbaran As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblcDescArticulo As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Friend WithEvents TextBox1 As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents Label1 As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents Frame1 As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents Panel1 As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents cmbCancelar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents cmbAceptar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents jngValoracion As Solmicro.Expertis.Engine.UI.Grid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim jngValoracion_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmValoracionSuministro))
        Me.fwiArticulo = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblfwiArticulo = New Solmicro.Expertis.Engine.UI.Label
        Me.fwiAlbaran = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblfwiAlbaran = New Solmicro.Expertis.Engine.UI.Label
        Me.Frame1 = New Solmicro.Expertis.Engine.UI.Frame
        Me.lblcDescArticulo = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.TextBox1 = New Solmicro.Expertis.Engine.UI.TextBox
        Me.Label1 = New Solmicro.Expertis.Engine.UI.Label
        Me.Panel1 = New Solmicro.Expertis.Engine.UI.Panel
        Me.cmbCancelar = New Solmicro.Expertis.Engine.UI.Button
        Me.cmbAceptar = New Solmicro.Expertis.Engine.UI.Button
        Me.jngValoracion = New Solmicro.Expertis.Engine.UI.Grid
        Me.Frame1.SuspendLayout()
        Me.Panel1.suspendlayout()
        CType(Me.jngValoracion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'fwiArticulo
        '
        Me.fwiArticulo.DisabledBackColor = System.Drawing.Color.White
        Me.fwiArticulo.Enabled = False
        Me.fwiArticulo.Location = New System.Drawing.Point(264, 12)
        Me.fwiArticulo.Name = "fwiArticulo"
        Me.fwiArticulo.Size = New System.Drawing.Size(120, 21)
        Me.fwiArticulo.TabIndex = 3
        '
        'lblfwiArticulo
        '
        Me.lblfwiArticulo.Location = New System.Drawing.Point(296, 16)
        Me.lblfwiArticulo.Name = "lblfwiArticulo"
        Me.lblfwiArticulo.Size = New System.Drawing.Size(50, 13)
        Me.lblfwiArticulo.TabIndex = 6
        Me.lblfwiArticulo.Text = "Artículo"
        '
        'fwiAlbaran
        '
        Me.fwiAlbaran.DisabledBackColor = System.Drawing.Color.White
        Me.fwiAlbaran.Enabled = False
        Me.fwiAlbaran.Location = New System.Drawing.Point(65, 16)
        Me.fwiAlbaran.Name = "fwiAlbaran"
        Me.fwiAlbaran.Size = New System.Drawing.Size(133, 21)
        Me.fwiAlbaran.TabIndex = 2
        '
        'lblfwiAlbaran
        '
        Me.lblfwiAlbaran.Location = New System.Drawing.Point(8, 16)
        Me.lblfwiAlbaran.Name = "lblfwiAlbaran"
        Me.lblfwiAlbaran.Size = New System.Drawing.Size(51, 13)
        Me.lblfwiAlbaran.TabIndex = 7
        Me.lblfwiAlbaran.Text = "Albarán"
        '
        'Frame1
        '
        Me.Frame1.Controls.Add(Me.lblcDescArticulo)
        Me.Frame1.Controls.Add(Me.fwiArticulo)
        Me.Frame1.Controls.Add(Me.lblfwiAlbaran)
        Me.Frame1.Controls.Add(Me.lblfwiArticulo)
        Me.Frame1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Frame1.Location = New System.Drawing.Point(0, 0)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Size = New System.Drawing.Size(768, 45)
        Me.Frame1.TabIndex = 1
        Me.Frame1.TabStop = False
        '
        'lblcDescArticulo
        '
        Me.lblcDescArticulo.Location = New System.Drawing.Point(392, 10)
        Me.lblcDescArticulo.Name = "lblcDescArticulo"
        Me.lblcDescArticulo.Size = New System.Drawing.Size(360, 24)
        Me.lblcDescArticulo.TabIndex = 4
        '
        'TextBox1
        '
        Me.TextBox1.DisabledBackColor = System.Drawing.Color.White
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(72, 16)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(133, 21)
        Me.TextBox1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(216, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Artículo"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.cmbCancelar)
        Me.Panel1.Controls.Add(Me.cmbAceptar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 302)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(768, 48)
        Me.Panel1.TabIndex = 9
        '
        'cmbCancelar
        '
        Me.cmbCancelar.Location = New System.Drawing.Point(393, 8)
        Me.cmbCancelar.Name = "cmbCancelar"
        Me.cmbCancelar.Size = New System.Drawing.Size(102, 33)
        Me.cmbCancelar.TabIndex = 10
        Me.cmbCancelar.Text = "Cancelar"
        '
        'cmbAceptar
        '
        Me.cmbAceptar.Location = New System.Drawing.Point(273, 8)
        Me.cmbAceptar.Name = "cmbAceptar"
        Me.cmbAceptar.Size = New System.Drawing.Size(102, 33)
        Me.cmbAceptar.TabIndex = 9
        Me.cmbAceptar.Text = "Aceptar"
        '
        'jngValoracion
        '
        Me.jngValoracion.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.jngValoracion.AutoEdit = True
        jngValoracion_DesignTimeLayout.LayoutString = resources.GetString("jngValoracion_DesignTimeLayout.LayoutString")
        Me.jngValoracion.DesignTimeLayout = jngValoracion_DesignTimeLayout
        Me.jngValoracion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.jngValoracion.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.jngValoracion.EntityName = ""
        Me.jngValoracion.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.jngValoracion.Location = New System.Drawing.Point(0, 45)
        Me.jngValoracion.Name = "jngValoracion"
        Me.jngValoracion.PrimaryDataFields = Nothing
        Me.jngValoracion.SecondaryDataFields = Nothing
        Me.jngValoracion.Size = New System.Drawing.Size(768, 257)
        Me.jngValoracion.TabIndex = 10
        Me.jngValoracion.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.jngValoracion.ViewName = ""
        '
        'frmValoracionSuministro
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(768, 350)
        Me.Controls.Add(Me.jngValoracion)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.fwiAlbaran)
        Me.Controls.Add(Me.Frame1)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "frmValoracionSuministro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Valoración del Suministro"
        Me.Frame1.ResumeLayout(False)
        Me.Frame1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.jngValoracion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

#Region " Código generado por el migrador "
    '    'Private Const FORMATSTRING_NUMERIC As String = "#,0.0###"
    '    'Private Const FORMATSTRING_DATE As String = "dd/mm/yyyy"
    '    Public mblnFormLoad As Boolean
    '    Public mlngIDAlbaran As Long
    '    Public mlngIDLineaAlbaran As Long
    '    Public mstrArticulo As String, mstrDescArticulo As String
    '    Private mrcsCriterio As Recordset
    '    Private mrcsDemerito As Recordset
    '    'CRF    Private mjsRowSelected As JSRowData

    '    'Private Sub ComboGridSetSize(ByVal grxGrid As Solmicro.Expertis.Engine.UI.Grid20.GridEX)
    '    'CRF    Private Sub ComboGridSetSize(ByVal grxGrid As Solmicro.Expertis.Engine.UI.Grid)
    '    '        Dim flds As Fields
    '    '        On Error GoTo TratarError
    '    '        With grxGrid
    '    '            If .RowCount < 10 Then
    '    '                .Height = (.RowCount * .RowHeight) + 50
    '    '            Else
    '    '                .Height = (10 * .RowHeight) + 50
    '    '            End If
    '    '            If Not .Datasource Is Nothing Then
    '    '                flds = .Datasource.Fields
    '    '                .Columns(flds(0).Name).Width = 100 * flds(0).DefinedSize
    '    '                .Columns(flds(1).Name).Width = 20 * flds(1).DefinedSize
    '    '            End If
    '    '        End With
    '    'Fin:
    '    '        flds = Nothing
    '    '        Exit Sub
    '    'TratarError:
    '    '        GenerateError(Err)
    '    '    End Sub

    '    'CRF    Private Sub ComboGridSetDataSource(ByVal grxGrid As Solmicro.Expertis.Engine.UI.Grid, ByVal rcsDataSource As Recordset, ByVal strIDField As String, ByVal strDescField As String)
    '    '        Dim fld As Field
    '    '        Dim rcsCombo As Recordset
    '    '        On Error GoTo TratarError

    '    '        If Not rcsDataSource Is Nothing Then
    '    '            rcsCombo = New Recordset
    '    '            fld = rcsDataSource.Fields(strIDField)
    '    '            rcsCombo.Fields.Append("Value", fld.Type, fld.DefinedSize)
    '    '            fld = rcsDataSource.Fields(strDescField)
    '    '            rcsCombo.Fields.Append("Text", fld.Type, fld.DefinedSize)
    '    '            rcsCombo.Open()

    '    '            If rcsDataSource.RecordCount > 0 Then
    '    '                Do Until rcsDataSource.EOF
    '    '                    rcsCombo.AddNew()
    '    '                    rcsCombo.Fields("Value").Value = rcsDataSource.Fields(strIDField).Value
    '    '                    rcsCombo.Fields("Text").Value = rcsDataSource.Fields(strDescField).Value
    '    '                    rcsDataSource.MoveNext()
    '    '                Loop
    '    '            End If
    '    '        End If

    '    '        With grxGrid
    '    '            .HoldFields()
    '    '            .Datasource = rcsCombo
    '    '        End With
    '    'Fin:
    '    '        fld = Nothing
    '    '        rcsCombo = Nothing
    '    '        Exit Sub
    '    'TratarError:
    '    '        GenerateError(Err)
    '    '        Resume Fin
    '    '    End Sub

    '    'CRF    Private Sub jngValoracion_FormattingRow(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowLoadEventArgs) Handles jngValoracion.FormattingRow
    '    '        Dim rs As Recordset
    '    '        On Error GoTo TratarError

    '    '        With jngValoracion
    '    '            rs = .DataSource
    '    '            '.DataSource.Bookmark = RowBookmark
    '    '            Select Case rs.Fields("TipoCriterio").Value
    '    '                Case enumCriteriosCalidad.CCCantidad
    '    '                    If e.Column.Index = .Columns("Previsto").Index Then
    '    '                        Value = Format(rs.Fields("QPedida").Value, FORMATSTRING_NUMERIC)
    '    '                    ElseIf e.Column.Index = .Columns("Real").Index Then
    '    '                        Value = Format(rs.Fields("QServida").Value, FORMATSTRING_NUMERIC)
    '    '                    End If
    '    '                Case enumCriteriosCalidad.ccCantidadPorcentaje
    '    '                    If e.Column.Index = .Columns("Previsto").Index Then
    '    '                        Value = 100 & " %"
    '    '                    ElseIf e.Column.Index = .Columns("Real").Index Then
    '    '                        If rs.Fields("QPedida").Value <> 0 Then
    '    '                            Value = 100 * (rs.Fields("QServida").Value / rs.Fields("QPedida").Value) & " %"
    '    '                        End If
    '    '                    End If
    '    '                Case enumCriteriosCalidad.CCFechas
    '    '                    If e.Column.Index = .Columns("Previsto").Index Then
    '    '                        Value = Format(rs.Fields("FechaEntrega").Value, FORMATSTRING_DATE, vbUseSystemDayOfWeek, vbUseSystem)
    '    '                    ElseIf e.Column.Index = .Columns("Real").Index Then
    '    '                        Value = Format(rs.Fields("FechaAlbaran").Value, FORMATSTRING_DATE, vbUseSystemDayOfWeek, vbUseSystem)
    '    '                    End If
    '    '            End Select
    '    '        End With

    '    'Fin:
    '    '        rs = Nothing
    '    '        Exit Sub
    '    'TratarError:
    '    '        GenerateError(Err)
    '    '        Resume Fin
    '    '    End Sub

    '    'CRF    Private Sub jngValoracion_DropDown(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles jngValoracion.DropDown
    '    '        On Error GoTo TratarError

    '    '        With jngValoracion
    '    '            Select Case e.Column.Index
    '    '                Case .Columns("IDCriterio").Index
    '    '                    ComboGridSetSize(jngDDCriterio)
    '    '                Case .Columns("IDDemerito").Index
    '    '                    ComboGridSetSize(jngDDDemerito)
    '    '            End Select
    '    '        End With

    '    '        Exit Sub
    '    'TratarError:
    '    '        GenerateError(Err)
    '    '    End Sub

    '    Private Sub jngValoracion_DeletingRecords(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles jngValoracion.DeletingRecords
    '        On Error GoTo TratarError

    '        'CRF        If GenerateMessage(6395, vbInformation + vbYesNo, ExpertisApp.Title) = vbYes Then
    '        ' Migration Cancel = (FwGrid.DeleteLine() = False)
    '        'CRF        Else
    '        'CRF            e.Cancel = True
    '        'CRF        End If
    'Fin:
    '        jngValoracion.Focus()
    '        Exit Sub
    'TratarError:
    '        e.Cancel = True
    '        GenerateError(Err)
    '        Resume Fin
    '    End Sub

    '    Private Sub jngValoracion_UpdatingCell(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.UpdatingCellEventArgs) Handles jngValoracion.UpdatingCell
    '        On Error GoTo TratarError

    '        With jngValoracion
    '            Select Case e.Column.Index
    '                Case .Columns("IDDemerito").Index
    '                    If Len(.Value(e.Column.Index) & vbNullString) > 0 Then
    '                        'CRF                        'If Not mjsRowSelected Is Nothing Then
    '                        '    .Value(.Columns("DescDemerito").Index) = mjsRowSelected.Value(2)
    '                        'End If
    '                    Else
    '                        .Value(.Columns("DescDemerito").Index) = vbNullString
    '                    End If
    '            End Select
    '        End With
    'Fin:
    '        jngValoracion.Focus()
    '        Exit Sub
    'TratarError:
    '        e.Cancel = True
    '        GenerateError(Err)
    '        Resume Fin
    '    End Sub

    '    Private Sub jngValoracion_EditingCell(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.EditingCellEventArgs) Handles jngValoracion.EditingCell
    '        On Error GoTo TratarError
    '        With jngValoracion
    '            Select Case e.Column.Index
    '                Case .Columns("IDCriterio").Index, .Columns("Correcto").Index, .Columns("Diferencia").Index
    '                    'CRF                    e.Cancel = (FwGrid.Row = .newTopRowPosition)
    '            End Select
    '        End With
    '        Exit Sub
    'TratarError:
    '        e.Cancel = True
    '        GenerateError(Err)
    '    End Sub

    '    '    Private Sub jngDDDemerito_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles jngDDDemerito.SelectionChanged
    '    '        On Error GoTo TratarError
    '    '        With jngDDDemerito
    '    ''CRF            If .RowCount > 0 Then mjsRowSelected = .GetRow(.Row)
    '    '        End With
    '    '        Exit Sub
    '    'TratarError:
    '    '        GenerateError(Err)
    '    '    End Sub

    '    'CRF     Private Sub jngValoracion_ColumnsFormatted() Handles jngValoracion.ColumnsFormatted
    '    'On Error GoTo TratarError
    '    'With jngValoracion
    '    '    .Columns("IDCriterio").DropDown = jngDDCriterio
    '    '    .Columns("IDCriterio").EditType = Janus.Windows.GridEX.EditType.Combo
    '    '    '.Columns("IDCriterio").Commandstyle = jgexButtonDownArrow

    '    '    .Columns("IDDemerito").DropDown = jngDDDemerito
    '    '    .Columns("IDDemerito").EditType = Janus.Windows.GridEX.EditType.Combo
    '    '    '.Columns("IDDemerito").Commandstyle = jgexButtonDownArrow
    '    'End With

    '    'With jngDDCriterio
    '    '    .ValueMember = .Columns("Value").Index
    '    '    .DisplayMember = .Columns("Text").Index
    '    '    .Columns("Text").AutoSize()

    '    '    ComboGridSetDataSource(jngDDCriterio, mrcsCriterio.Clone, "IDCriterio", "DescCriterio")
    '    'End With

    '    'With jngDDDemerito
    '    '    .ValueMember = .Columns("Value").Index
    '    '    .DisplayMember = .Columns("Value").Index
    '    '    .Columns("Text").AutoSize()

    '    '    ComboGridSetDataSource(jngDDDemerito, mrcsDemerito.Clone, "IDDemerito", "DescDemerito")
    '    'End With

    '    '        jngValoracion.Refresh()
    '    '        Exit Sub
    '    'TratarError:
    '    '        GenerateError(Err)
    '    '    End Sub

    '    Private Sub jngValoracion_FormattingColumns() Handles jngValoracion.FormattingColumns
    '        On Error GoTo TratarError
    '        With jngValoracion
    '            .Columns("IDLineaAlbaran").DefaultValue = mlngIDLineaAlbaran
    '            .Columns("Correcto").DefaultValue = True
    '            .Columns("Diferencia").DefaultValue = 0
    '            If Not mrcsDemerito Is Nothing Then
    '                If mrcsDemerito.RecordCount > 0 Then
    '                    mrcsDemerito.Sort = "IDDemerito"
    '                    .Columns("IDDemerito").DefaultValue = mrcsDemerito.Fields("IDDemerito").Value
    '                    .Columns("DescDemerito").DefaultValue = mrcsDemerito.Fields("DescDemerito").Value
    '                End If
    '            End If
    '        End With
    '        Exit Sub
    'TratarError:
    '        GenerateError(Err)
    '    End Sub


    '    Private Sub Form_QueryUnload(ByVal Cancel As Integer, ByVal UnloadMode As Integer)
    '        On Error GoTo TratarError
    '        'CRF        If UnloadMode = vbFormControlMenu Or UnloadMode = vbFormCode Then
    '        If jngValoracion.DataChanged Then
    '            'CRF                If GenerateMessage(10242, vbInformation Or vbYesNo, ExpertisApp.Title) = vbNo Then
    '            'CRF                    Cancel = 1
    '            'CRF                    jngValoracion.Focus()
    '            'CRF                End If
    '        End If
    '        'CRF        End If
    '        Exit Sub
    'TratarError:
    '        GenerateError(Err)
    '    End Sub

    '    Private Sub EnlazarControles()
    '        On Error GoTo TratarError
    '        fwiAlbaran.Text = mlngIDAlbaran
    '        fwiArticulo.Text = mstrArticulo
    '        fwiArticulo.Text = mstrDescArticulo
    '        Exit Sub
    'TratarError:
    '        GenerateError(Err)
    '    End Sub

    '    Private Sub jngValoracion_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
    '        Dim FwnApp As New BE.DataEngine
    '        On Error GoTo TratarError
    '        mblnFormLoad = True
    '        EnlazarControles()
    '        'CRF        EnlazarGrid()

    '        mrcsCriterio = FwnApp.Filter("tbMaestroCriterioValoracion", "*", "IDCriterio,DescCriterio")
    '        mrcsDemerito = FwnApp.Filter("tbMaestroDemerito", "*", "IDDemerito,DescDemerito")

    'Fin:
    '        FwnApp = Nothing
    '        Exit Sub
    'TratarError:
    '        GenerateError(Err)
    '        Resume Fin
    '    End Sub

    '    Private Sub Form_Activate()
    '        On Error GoTo TratarError
    '        If mblnFormLoad Then
    '            'FwGrid.Refresh()
    '            jngValoracion.Refresh()
    '            Me.Refresh()
    '        End If
    'Fin:
    '        mblnFormLoad = False
    '        Exit Sub
    'TratarError:
    '        GenerateError(Err)
    '        Resume Fin
    '    End Sub
#End Region

    Public Overrides ReadOnly Property RequeryRecords() As Engine.RequeryMode
        Get
            Return RequeryMode.AllRecords
        End Get
    End Property

    Public mlngIDLineaAlbaran As Long

    Private Function ObtenerDemeritos() As DataTable
        Dim dt As DataTable
        Dim fwn As New Demerito
        Dim ofilter As New Filter
        dt = fwn.Filter(ofilter)
        Return (dt)
    End Function

    Private Function ObtenerCriteriosValoracion() As DataTable
        Dim dt As DataTable
        Dim fwn As New CriterioValoracion
        Dim ofilter As New Filter
        dt = fwn.Filter(ofilter)
        Return (dt)
    End Function

    Public Sub AbrirCriterioValSuministro(ByVal lngIDLineaAlbaran As Long, ByVal lngIDAlbaran As String, ByVal mstrArticulo As String, ByVal mstrDescArticulo As String, ByVal OwnerForm As FormBase)
        Try
            mlngIDLineaAlbaran = lngIDLineaAlbaran
            fwiAlbaran.Text = lngIDAlbaran
            fwiArticulo.Text = mstrArticulo
            lblcDescArticulo.Text = mstrDescArticulo

            'Dim be As New Engine.BE.DataEngine
            ' Dim ofilter As New Filter
            'ofilter.Add("IDLineaAlbaran", lngIDLineaAlbaran)
            'Dim dtValoracion As DataTable = be.Filter("vFrmValoracionSuministro", ofilter)
            'jngValoracion.DataSource = dtValoracion
            With jngValoracion
                .EntityName = "AlbaranCompraValoracion"
                .ViewName = "vFrmValoracionSuministro"


                Dim f As New Filter
                f.Add(New StringFilterItem("IDLineaAlbaran", FilterOperator.Equal, lngIDLineaAlbaran))
                .Filter = f

                'Me.ShowDialog(OwnerForm)
            End With
            jngValoracion.DropDowns("Criterios").SetDataBinding(ObtenerCriteriosValoracion(), String.Empty)
            jngValoracion.DropDowns("Demeritos").SetDataBinding(ObtenerDemeritos(), String.Empty)

            Me.ShowDialog(OwnerForm)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    ''Private Sub jngValoracion_FormattingColumns() Handles jngValoracion.FormattingColumns
    ''    Try
    ''        With jngValoracion
    ''            .Columns("IDLineaAlbaran").DefaultValue = mlngIDLineaAlbaran
    ''            .Columns("Correcto").DefaultValue = True
    ''            .Columns("Diferencia").DefaultValue = 0
    ''            Dim dt As DataTable
    ''            dt = ObtenerDemeritos()
    ''            If Not dt Is Nothing AndAlso dt.Rows.Count > 0 Then
    ''                Dim dtview As New DataView
    ''                dtview = dt.DefaultView
    ''                dtview.Sort = "IDDemerito"
    ''                .Columns("IDDemerito").DefaultValue = dtview(0)("IDDemerito")
    ''                .Columns("DescDemerito").DefaultValue = dtview(0)("DescDemerito")
    ''            End If
    ''        End With

    ''    Catch ex As Exception
    ''        MessageBox.Show(ex.Message)
    ''    End Try
    ''End Sub

    'Private Sub jngValoracion_EditingCell(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.EditingCellEventArgs) Handles jngValoracion.EditingCell
    '    Try
    '        With jngValoracion
    '            Select Case e.Column.Key
    '                'Case "IDCriterio", "Correcto", "Diferencia"
    '                '    e.Cancel = (.Row <> .newTopRowPosition)
    '            Case "Previsto", "Real", "DescDemerito"
    '                    e.Cancel = True
    '            End Select
    '        End With
    '    Catch ex As Exception
    '        e.Cancel = True
    '        MessageBox.Show(ex.Message)
    '    End Try
    'End Sub

    Private Sub jngValoracion_CellUpdated(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles jngValoracion.CellUpdated
        With jngValoracion
            Select Case e.Column.Key
                Case "IDDemerito"
                    If Length(.GetValue(e.Column.Key)) > 0 Then
                        .SetValue("DescDemerito", jngValoracion.DropDowns("Demeritos").GetValue("DescDemerito"))
                    Else
                        .SetValue("DescDemerito", String.Empty)
                    End If
            End Select
        End With
    End Sub

    Private Sub cmbCancelar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbCancelar.Click
        Me.Close()
    End Sub

    Private Sub cmbAceptar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbAceptar.Click
        Me.UpdateData()
        Me.Close()
    End Sub

End Class
