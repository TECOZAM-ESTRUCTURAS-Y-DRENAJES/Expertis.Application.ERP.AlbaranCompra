Public Class FrmCantRechazo

#Region "Propiedades Públicas"

    Private MIntIDLineaAlbaran As Integer
    Public WriteOnly Property IDLineaAlbaran() As Integer
        Set(ByVal value As Integer)
            MIntIDLineaAlbaran = value
        End Set
    End Property

    Private MDblQRechazadaTotal As Double
    Public ReadOnly Property QRechazadaTotal() As Double
        Get
            Return MDblQRechazadaTotal
        End Get
    End Property

#End Region

#Region "Procesos Privados"

    Private Sub LoadData()
        Me.GrdRechazadas.ReQuery(New FilterItem("IDAlbaranCompraLinea", FilterOperator.Equal, MIntIDLineaAlbaran))
        Me.GrdRechazadas.Columns("IDAlbaranCompraLinea").DefaultValue = MIntIDLineaAlbaran
    End Sub

    Private Sub SaveData()
        MDblQRechazadaTotal = Nz(Me.GrdRechazadas.GetTotal(GrdRechazadas.Columns("QRechazada"), Janus.Windows.GridEX.AggregateFunction.Sum), 0)
        Dim ClsAlbRech As New AlbaranCompraRechazo
        Dim DtGrid As DataTable = CType(Me.GrdRechazadas.DataSource, DataTable)
        If Not DtGrid Is Nothing AndAlso DtGrid.Rows.Count > 0 Then
            Dim DtNewModUpd As DataTable = DtGrid.Clone
            For Each Dr As DataRow In DtGrid.Select
                DtNewModUpd.ImportRow(Dr)
            Next
            'DtNewModUpd.TableName = "AlbaranCompraRechazo"
            ClsAlbRech.Update(DtNewModUpd)
        End If
        Dim DtDelete As DataTable = CType(Me.GrdRechazadas.DataSource, DataTable).GetChanges(DataRowState.Deleted)
        If Not DtDelete Is Nothing AndAlso DtDelete.Rows.Count > 0 Then
            DtDelete.TableName = "AlbaranCompraRechazo"
            DtDelete.RejectChanges()
            ClsAlbRech.Delete(DtDelete)
        End If
    End Sub

#End Region

#Region "Eventos FrmCantRechazo"

    Private Sub FrmCantRechazo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Not Me.DesignMode Then
            LoadData()
        End If
    End Sub

    Private Sub BtnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAceptar.Click
        SaveData()
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub BtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub GrdRechazadas_AddingRecord(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles GrdRechazadas.AddingRecord
        If Length(GrdRechazadas.GetValue("IDCausaRechazo")) = 0 Then
            ExpertisApp.GenerateMessage("No se puede dejar vacío la causa rechazo.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            e.Cancel = True
        End If
        If Length(GrdRechazadas.GetValue("QRechazada")) = 0 Then
            ExpertisApp.GenerateMessage("No se puede dejar vacío o a cero la cantidad rechazada.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            e.Cancel = True
        End If
    End Sub

    Private Sub GrdRechazadas_UpdatingCell(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.UpdatingCellEventArgs) Handles GrdRechazadas.UpdatingCell
        If GrdRechazadas.Row <> GrdRechazadas.newTopRowPosition Then
            If Length(GrdRechazadas.GetValue("IDCausaRechazo")) = 0 Then
                ExpertisApp.GenerateMessage("No se puede dejar vacío la causa rechazo.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                e.Cancel = True
            End If
            If Length(GrdRechazadas.GetValue("QRechazada")) = 0 Then
                ExpertisApp.GenerateMessage("No se puede dejar vacío o a cero la cantidad rechazada.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                e.Cancel = True
            End If
        End If
    End Sub

#End Region

End Class