Public Class CISeguimientoTransporte
    Private Sub LoadGridActions()
        Me.Grid.Actions.Add("Abrir Proveedor", AddressOf AccionAbrirProveedor)
        Me.Grid.Actions.Add("Abrir Albaran", AddressOf AccionAbrirAlbaran)
    End Sub

    Private Sub AccionAbrirProveedor()
        If ExpertisApp.IsFormOpen("MPROV") Then ExpertisApp.CloseForm("MPROV")
        ExpertisApp.OpenForm("MPROV", New FilterItem("IDProveedor", FilterOperator.Equal, Me.Grid.GetValue("IDProveedor")))
    End Sub

    Private Sub AccionAbrirAlbaran()
        If ExpertisApp.IsFormOpen("MALBC") Then ExpertisApp.CloseForm("MALBC")
        ExpertisApp.OpenForm("MALBC", New FilterItem("IDAlbaran", FilterOperator.Equal, Me.Grid.GetValue("IDAlbaran")))
    End Sub

    Private Sub AplicarFiltros(ByRef e As Engine.UI.QueryExecutingEventArgs)
        e.Filter.Add("FechaAlbaran", FilterOperator.GreaterThanOrEqual, fwiFechaDesde.Value, FilterType.DateTime)
        e.Filter.Add("FechaAlbaran", FilterOperator.LessThanOrEqual, FwiFechaHasta.Value, FilterType.DateTime)
        e.Filter.Add("IDAlbaran", FilterOperator.GreaterThanOrEqual, AdvAlbaranDesde.Value, FilterType.Numeric)
        e.Filter.Add("IDAlbaran", FilterOperator.LessThanOrEqual, AdvAlbaranHasta.Value, FilterType.Numeric)
        e.Filter.Add("IDFormaEnvio", FilterOperator.Equal, AdvFormaEnvio.Value, FilterType.String)
        e.Filter.Add("IDProveedor", FilterOperator.GreaterThanOrEqual, advProveedorDesde.Value, FilterType.String)
        e.Filter.Add("IDProveedor", FilterOperator.LessThanOrEqual, advProveedorHasta.Value, FilterType.String)
    End Sub

    Private Sub LimpiarFiltros()
        AdvAlbaranDesde.Text = String.Empty
        AdvAlbaranDesde.Value = Nothing
        AdvAlbaranHasta.Text = String.Empty
        AdvAlbaranHasta.Value = Nothing
        fwiFechaDesde.TextBox.Clear()
        FwiFechaHasta.TextBox.Clear()
        AdvFormaEnvio.Text = String.Empty
        AdvFormaEnvio.Value = Nothing
    End Sub

    Private Sub CISeguimientoTransporte_FilterCleared(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.FilterCleared
        LimpiarFiltros()
    End Sub

    Private Sub CISeguimientoTransporte_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        LoadGridActions()
    End Sub

    Private Sub CISeguimientoTransporte_QueryExecuting(ByVal sender As Object, ByRef e As Engine.UI.QueryExecutingEventArgs) Handles Me.QueryExecuting
        AplicarFiltros(e)
    End Sub
End Class