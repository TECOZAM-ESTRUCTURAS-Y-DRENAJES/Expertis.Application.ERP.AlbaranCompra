<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCantRechazo
    Inherits Solmicro.Expertis.Engine.UI.FormBase

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
        Me.components = New System.ComponentModel.Container
        Dim GrdRechazadas_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCantRechazo))
        Me.PnlButtons = New Solmicro.Expertis.Engine.UI.Panel
        Me.BtnCancelar = New Solmicro.Expertis.Engine.UI.Button
        Me.BtnAceptar = New Solmicro.Expertis.Engine.UI.Button
        Me.GrdRechazadas = New Solmicro.Expertis.Engine.UI.Grid
        Me.PnlButtons.suspendlayout()
        CType(Me.GrdRechazadas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PnlButtons
        '
        Me.PnlButtons.Controls.Add(Me.BtnCancelar)
        Me.PnlButtons.Controls.Add(Me.BtnAceptar)
        Me.PnlButtons.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PnlButtons.Location = New System.Drawing.Point(0, 218)
        Me.PnlButtons.Name = "PnlButtons"
        Me.PnlButtons.Size = New System.Drawing.Size(555, 47)
        Me.PnlButtons.TabIndex = 2
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Location = New System.Drawing.Point(295, 7)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(86, 32)
        Me.BtnCancelar.TabIndex = 4
        Me.BtnCancelar.Text = "&Cancelar"
        '
        'BtnAceptar
        '
        Me.BtnAceptar.Location = New System.Drawing.Point(189, 7)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(86, 32)
        Me.BtnAceptar.TabIndex = 3
        Me.BtnAceptar.Text = "&Aceptar"
        '
        'GrdRechazadas
        '
        Me.GrdRechazadas.AdvSearchColumns = New Solmicro.Expertis.Engine.UI.AdvSearchColumns(New Solmicro.Expertis.Engine.UI.AdvSearchColumn() {New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDCausaRechazo", "CausaRechazo", "IDCausaRechazo", New Solmicro.Expertis.Engine.UI.ASSelectedColumns(New Solmicro.Expertis.Engine.UI.ASSelectedColumn() {New Solmicro.Expertis.Engine.UI.ASSelectedColumn("DescCausaRechazo", "DescCausaRechazo")}))})
        GrdRechazadas_DesignTimeLayout.LayoutString = resources.GetString("GrdRechazadas_DesignTimeLayout.LayoutString")
        Me.GrdRechazadas.DesignTimeLayout = GrdRechazadas_DesignTimeLayout
        Me.GrdRechazadas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GrdRechazadas.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.GrdRechazadas.EntityName = "AlbaranCompraRechazo"
        Me.GrdRechazadas.KeyField = "IDAlbaranCompraRechazo"
        Me.GrdRechazadas.Location = New System.Drawing.Point(0, 0)
        Me.GrdRechazadas.Name = "GrdRechazadas"
        Me.GrdRechazadas.PrimaryDataFields = ""
        Me.GrdRechazadas.RequeryManually = True
        Me.GrdRechazadas.SecondaryDataFields = ""
        Me.GrdRechazadas.Size = New System.Drawing.Size(555, 218)
        Me.GrdRechazadas.TabIndex = 1
        Me.GrdRechazadas.ViewName = "vFrmAlbaranCompraRechazo"
        '
        'FrmCantRechazo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(555, 265)
        Me.Controls.Add(Me.GrdRechazadas)
        Me.Controls.Add(Me.PnlButtons)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.HelpButton = False
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmCantRechazo"
        Me.NavigationFields = ""
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cantidades Rechazadas"
        Me.PnlButtons.ResumeLayout(False)
        CType(Me.GrdRechazadas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PnlButtons As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents BtnCancelar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents BtnAceptar As Solmicro.Expertis.Engine.UI.Button
    Protected Friend WithEvents GrdRechazadas As Solmicro.Expertis.Engine.UI.Grid
End Class
