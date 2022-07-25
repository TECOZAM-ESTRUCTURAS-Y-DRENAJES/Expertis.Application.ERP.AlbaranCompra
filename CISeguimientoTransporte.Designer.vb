<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CISeguimientoTransporte
    Inherits Solmicro.Expertis.Engine.UI.CIMnto

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim Grid_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CISeguimientoTransporte))
        Me.AdvAlbaranHasta = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.LblAlbaranHasta = New Solmicro.Expertis.Engine.UI.Label
        Me.LblAlbaranDesde = New Solmicro.Expertis.Engine.UI.Label
        Me.AdvAlbaranDesde = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblProveedorDesde = New Solmicro.Expertis.Engine.UI.Label
        Me.advProveedorDesde = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.FwiFechaHasta = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.fwiFechaDesde = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.LblFechaHasta = New Solmicro.Expertis.Engine.UI.Label
        Me.lblFechaDesde = New Solmicro.Expertis.Engine.UI.Label
        Me.LblTransportista = New Solmicro.Expertis.Engine.UI.Label
        Me.AdvFormaEnvio = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblProveedorHasta = New Solmicro.Expertis.Engine.UI.Label
        Me.advProveedorHasta = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.FilterPanel.SuspendLayout()
        Me.CIMntoGridPanel.suspendlayout()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Toolbar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Menubar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainPanel.SuspendLayout()
        Me.MainPanelCIMntoContainer.SuspendLayout()
        Me.SuspendLayout()
        '
        'FilterPanel
        '
        Me.FilterPanel.Controls.Add(Me.advProveedorHasta)
        Me.FilterPanel.Controls.Add(Me.lblProveedorHasta)
        Me.FilterPanel.Controls.Add(Me.LblTransportista)
        Me.FilterPanel.Controls.Add(Me.AdvFormaEnvio)
        Me.FilterPanel.Controls.Add(Me.FwiFechaHasta)
        Me.FilterPanel.Controls.Add(Me.fwiFechaDesde)
        Me.FilterPanel.Controls.Add(Me.LblFechaHasta)
        Me.FilterPanel.Controls.Add(Me.lblFechaDesde)
        Me.FilterPanel.Controls.Add(Me.advProveedorDesde)
        Me.FilterPanel.Controls.Add(Me.lblProveedorDesde)
        Me.FilterPanel.Controls.Add(Me.AdvAlbaranHasta)
        Me.FilterPanel.Controls.Add(Me.LblAlbaranHasta)
        Me.FilterPanel.Controls.Add(Me.LblAlbaranDesde)
        Me.FilterPanel.Controls.Add(Me.AdvAlbaranDesde)
        Me.FilterPanel.Location = New System.Drawing.Point(0, 320)
        Me.FilterPanel.Size = New System.Drawing.Size(699, 116)
        '
        'CIMntoGridPanel
        '
        Me.CIMntoGridPanel.Size = New System.Drawing.Size(699, 320)
        '
        'Grid
        '
        Grid_DesignTimeLayout.LayoutString = resources.GetString("Grid_DesignTimeLayout.LayoutString")
        Me.Grid.DesignTimeLayout = Grid_DesignTimeLayout
        Me.Grid.EntityName = "AlbaranCompraCabecera"
        Me.Grid.KeyField = "IDAlbaran"
        Me.Grid.Size = New System.Drawing.Size(699, 320)
        Me.Grid.ViewName = "vFrmSeguimientoTransporte"
        '
        'Toolbar
        '
        Me.Toolbar.Size = New System.Drawing.Size(245, 28)
        '
        'Menubar
        '
        Me.Menubar.Location = New System.Drawing.Point(0, 28)
        '
        'MainPanel
        '
        Me.MainPanel.Size = New System.Drawing.Size(699, 436)
        '
        'MainPanelCIMntoContainer
        '
        Me.MainPanelCIMntoContainer.Size = New System.Drawing.Size(699, 436)
        '
        'AdvAlbaranHasta
        '
        Me.AdvAlbaranHasta.DisabledBackColor = System.Drawing.Color.White
        Me.AdvAlbaranHasta.DisplayField = "NAlbaran"
        Me.AdvAlbaranHasta.EntityName = "AlbaranCompraCabecera"
        Me.AdvAlbaranHasta.Location = New System.Drawing.Point(275, 51)
        Me.AdvAlbaranHasta.Name = "AdvAlbaranHasta"
        Me.AdvAlbaranHasta.SecondaryDataFields = "IDAlbaran"
        Me.AdvAlbaranHasta.Size = New System.Drawing.Size(112, 23)
        Me.AdvAlbaranHasta.TabIndex = 24
        Me.AdvAlbaranHasta.ViewName = "tbAlbaranCompraCabecera"
        '
        'LblAlbaranHasta
        '
        Me.LblAlbaranHasta.Location = New System.Drawing.Point(235, 56)
        Me.LblAlbaranHasta.Name = "LblAlbaranHasta"
        Me.LblAlbaranHasta.Size = New System.Drawing.Size(39, 13)
        Me.LblAlbaranHasta.TabIndex = 26
        Me.LblAlbaranHasta.Text = "Hasta"
        Me.LblAlbaranHasta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblAlbaranDesde
        '
        Me.LblAlbaranDesde.Location = New System.Drawing.Point(8, 56)
        Me.LblAlbaranDesde.Name = "LblAlbaranDesde"
        Me.LblAlbaranDesde.Size = New System.Drawing.Size(91, 13)
        Me.LblAlbaranDesde.TabIndex = 25
        Me.LblAlbaranDesde.Text = "Albarán Desde"
        Me.LblAlbaranDesde.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'AdvAlbaranDesde
        '
        Me.AdvAlbaranDesde.DisabledBackColor = System.Drawing.Color.White
        Me.AdvAlbaranDesde.DisplayField = "NAlbaran"
        Me.AdvAlbaranDesde.EntityName = "AlbaranCompraCabecera"
        Me.AdvAlbaranDesde.Location = New System.Drawing.Point(115, 51)
        Me.AdvAlbaranDesde.Name = "AdvAlbaranDesde"
        Me.AdvAlbaranDesde.SecondaryDataFields = "IDAlbaran"
        Me.AdvAlbaranDesde.Size = New System.Drawing.Size(112, 23)
        Me.AdvAlbaranDesde.TabIndex = 23
        Me.AdvAlbaranDesde.ViewName = "tbAlbaranCompraCabecera"
        '
        'lblProveedorDesde
        '
        Me.lblProveedorDesde.Location = New System.Drawing.Point(8, 22)
        Me.lblProveedorDesde.Name = "lblProveedorDesde"
        Me.lblProveedorDesde.Size = New System.Drawing.Size(106, 13)
        Me.lblProveedorDesde.TabIndex = 27
        Me.lblProveedorDesde.Text = "Proveedor Desde"
        '
        'advProveedorDesde
        '
        Me.advProveedorDesde.DisabledBackColor = System.Drawing.Color.White
        Me.advProveedorDesde.EntityName = "Proveedor"
        Me.advProveedorDesde.Location = New System.Drawing.Point(115, 17)
        Me.advProveedorDesde.Name = "advProveedorDesde"
        Me.advProveedorDesde.SecondaryDataFields = "IDProveedor"
        Me.advProveedorDesde.Size = New System.Drawing.Size(112, 23)
        Me.advProveedorDesde.TabIndex = 28
        Me.advProveedorDesde.ViewName = "tbMaestroProveedor"
        '
        'FwiFechaHasta
        '
        Me.FwiFechaHasta.DisabledBackColor = System.Drawing.Color.White
        Me.FwiFechaHasta.Location = New System.Drawing.Point(275, 85)
        Me.FwiFechaHasta.Name = "FwiFechaHasta"
        Me.FwiFechaHasta.Size = New System.Drawing.Size(112, 21)
        Me.FwiFechaHasta.TabIndex = 32
        '
        'fwiFechaDesde
        '
        Me.fwiFechaDesde.DisabledBackColor = System.Drawing.Color.White
        Me.fwiFechaDesde.Location = New System.Drawing.Point(115, 85)
        Me.fwiFechaDesde.Name = "fwiFechaDesde"
        Me.fwiFechaDesde.Size = New System.Drawing.Size(112, 21)
        Me.fwiFechaDesde.TabIndex = 31
        '
        'LblFechaHasta
        '
        Me.LblFechaHasta.Location = New System.Drawing.Point(233, 90)
        Me.LblFechaHasta.Name = "LblFechaHasta"
        Me.LblFechaHasta.Size = New System.Drawing.Size(39, 13)
        Me.LblFechaHasta.TabIndex = 34
        Me.LblFechaHasta.Text = "Hasta"
        Me.LblFechaHasta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblFechaDesde
        '
        Me.lblFechaDesde.Location = New System.Drawing.Point(8, 90)
        Me.lblFechaDesde.Name = "lblFechaDesde"
        Me.lblFechaDesde.Size = New System.Drawing.Size(80, 13)
        Me.lblFechaDesde.TabIndex = 33
        Me.lblFechaDesde.Text = "Fecha Desde"
        Me.lblFechaDesde.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblTransportista
        '
        Me.LblTransportista.Location = New System.Drawing.Point(407, 22)
        Me.LblTransportista.Name = "LblTransportista"
        Me.LblTransportista.Size = New System.Drawing.Size(81, 13)
        Me.LblTransportista.TabIndex = 36
        Me.LblTransportista.Text = "Transportista"
        Me.LblTransportista.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'AdvFormaEnvio
        '
        Me.AdvFormaEnvio.DisabledBackColor = System.Drawing.Color.White
        Me.AdvFormaEnvio.DisplayField = "IDFormaEnvio"
        Me.AdvFormaEnvio.EntityName = "FormaEnvio"
        Me.AdvFormaEnvio.Location = New System.Drawing.Point(506, 17)
        Me.AdvFormaEnvio.Name = "AdvFormaEnvio"
        Me.AdvFormaEnvio.SecondaryDataFields = "IDFormaEnvio"
        Me.AdvFormaEnvio.Size = New System.Drawing.Size(112, 23)
        Me.AdvFormaEnvio.TabIndex = 35
        Me.AdvFormaEnvio.ViewName = "tbMaestroFormaEnvio"
        '
        'lblProveedorHasta
        '
        Me.lblProveedorHasta.Location = New System.Drawing.Point(233, 22)
        Me.lblProveedorHasta.Name = "lblProveedorHasta"
        Me.lblProveedorHasta.Size = New System.Drawing.Size(39, 13)
        Me.lblProveedorHasta.TabIndex = 37
        Me.lblProveedorHasta.Text = "Hasta"
        '
        'advProveedorHasta
        '
        Me.advProveedorHasta.DisabledBackColor = System.Drawing.Color.White
        Me.advProveedorHasta.EntityName = "Proveedor"
        Me.advProveedorHasta.Location = New System.Drawing.Point(275, 17)
        Me.advProveedorHasta.Name = "advProveedorHasta"
        Me.advProveedorHasta.SecondaryDataFields = "IDProveedor"
        Me.advProveedorHasta.Size = New System.Drawing.Size(112, 23)
        Me.advProveedorHasta.TabIndex = 38
        Me.advProveedorHasta.ViewName = "tbMaestroProveedor"
        '
        'CISeguimientoTransporte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(707, 524)
        Me.EntityName = "AlbaranCompraCabecera"
        Me.KeyField = "IDAlbaran"
        Me.Name = "CISeguimientoTransporte"
        Me.ViewName = "vFrmSeguimientoTransporte"
        Me.FilterPanel.ResumeLayout(False)
        Me.FilterPanel.PerformLayout()
        Me.CIMntoGridPanel.ResumeLayout(False)
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Toolbar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Menubar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainPanel.ResumeLayout(False)
        Me.MainPanelCIMntoContainer.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents advProveedorDesde As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblProveedorDesde As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents AdvAlbaranHasta As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents LblAlbaranHasta As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents LblAlbaranDesde As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents AdvAlbaranDesde As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents FwiFechaHasta As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents fwiFechaDesde As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents LblFechaHasta As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblFechaDesde As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents LblTransportista As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents AdvFormaEnvio As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents advProveedorHasta As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblProveedorHasta As Solmicro.Expertis.Engine.UI.Label
End Class
