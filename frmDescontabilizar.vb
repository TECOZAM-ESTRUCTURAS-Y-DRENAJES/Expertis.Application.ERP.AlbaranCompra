Public Class frmDescontabilizar

    Private mLineasAlbaran As List(Of Object)
    Public WriteOnly Property LineasAlbaran() As List(Of Object)
        Set(ByVal value As List(Of Object))
            mLineasAlbaran = value
        End Set
    End Property

#Region " Carga del formulario "

    Private Sub frmDescontabilizar_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Me.DesignMode Then
            LoadGrids()
        End If
    End Sub

    Private Sub LoadGrids()
        Dim datGetDesconta As New ProcesoAlbaranCompra.DataGetLineasDescontabilizar(mLineasAlbaran.ToArray) ', False)
        datGetDesconta = ExpertisApp.ExecuteTask(Of ProcesoAlbaranCompra.DataGetLineasDescontabilizar, ProcesoAlbaranCompra.DataGetLineasDescontabilizar)(AddressOf ProcesoAlbaranCompra.GetLineasDescontabilizar, datGetDesconta)

        GrdApuntesAlbaran.DataSource = datGetDesconta.ApuntesAlbaran
    End Sub

#End Region


#Region " Aceptar/Cancelar "

    Private Sub cmdAceptar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        Try

            Dim AsientoEnPeriodoCerrado As List(Of DataRow) = (From c In CType(GrdApuntesAlbaran.DataSource, DataTable) _
                                                                Where Not c.IsNull("MesCierre") OrElse c("EjercicioCerrado") <> 0).ToList()

            If AsientoEnPeriodoCerrado.Count > 0 Then
                ExpertisApp.GenerateMessage("Existen Albaranes contabilizados en un período cerrado. No se pueden descontabilizar.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            Dim datDescont As New DataDescontabilizacion(CType(GrdApuntesAlbaran.DataSource, DataTable))
            ExpertisApp.ExecuteTask(Of DataDescontabilizacion)(AddressOf ContabilizacionAlbaranCompra.Descontabilizar, datDescont)

            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        Catch ex As Exception
            ExpertisApp.GenerateMessage(ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Me.Close()
    End Sub

#End Region

End Class