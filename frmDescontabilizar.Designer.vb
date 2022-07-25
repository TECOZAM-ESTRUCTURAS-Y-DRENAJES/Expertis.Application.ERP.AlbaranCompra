<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDescontabilizar
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
        Dim GrdApuntesAlbaran_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDescontabilizar))
        Me.pnlBottom = New Solmicro.Expertis.Engine.UI.Panel
        Me.cmdCancelar = New Solmicro.Expertis.Engine.UI.Button
        Me.cmdAceptar = New Solmicro.Expertis.Engine.UI.Button
        Me.FraApuntesAlbaran = New Solmicro.Expertis.Engine.UI.Frame
        Me.GrdApuntesAlbaran = New Solmicro.Expertis.Engine.UI.Grid
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.pnlBottom.suspendlayout()
        Me.FraApuntesAlbaran.SuspendLayout()
        CType(Me.GrdApuntesAlbaran, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlBottom
        '
        Me.pnlBottom.Controls.Add(Me.cmdCancelar)
        Me.pnlBottom.Controls.Add(Me.cmdAceptar)
        Me.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlBottom.Location = New System.Drawing.Point(0, 552)
        Me.pnlBottom.Name = "pnlBottom"
        Me.pnlBottom.Size = New System.Drawing.Size(1041, 59)
        Me.pnlBottom.TabIndex = 0
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Location = New System.Drawing.Point(542, 16)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(92, 31)
        Me.cmdCancelar.TabIndex = 1
        Me.cmdCancelar.Text = "Cancelar"
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Location = New System.Drawing.Point(412, 16)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(92, 31)
        Me.cmdAceptar.TabIndex = 0
        Me.cmdAceptar.Text = "Aceptar"
        '
        'FraApuntesAlbaran
        '
        Me.FraApuntesAlbaran.Controls.Add(Me.GrdApuntesAlbaran)
        Me.FraApuntesAlbaran.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FraApuntesAlbaran.Location = New System.Drawing.Point(0, 0)
        Me.FraApuntesAlbaran.Name = "FraApuntesAlbaran"
        Me.FraApuntesAlbaran.Size = New System.Drawing.Size(1041, 552)
        Me.FraApuntesAlbaran.TabIndex = 1
        Me.FraApuntesAlbaran.TabStop = False
        Me.FraApuntesAlbaran.Text = "Apuntes de Albarán"
        '
        'GrdApuntesAlbaran
        '
        Me.GrdApuntesAlbaran.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GrdApuntesAlbaran.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GrdApuntesAlbaran.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        GrdApuntesAlbaran_DesignTimeLayout.LayoutString = resources.GetString("GrdApuntesAlbaran_DesignTimeLayout.LayoutString")
        Me.GrdApuntesAlbaran.DesignTimeLayout = GrdApuntesAlbaran_DesignTimeLayout
        Me.GrdApuntesAlbaran.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GrdApuntesAlbaran.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.GrdApuntesAlbaran.EntityName = ""
        Me.GrdApuntesAlbaran.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrdApuntesAlbaran.Location = New System.Drawing.Point(3, 17)
        Me.GrdApuntesAlbaran.Name = "GrdApuntesAlbaran"
        Me.GrdApuntesAlbaran.PrimaryDataFields = Nothing
        Me.GrdApuntesAlbaran.RelationMode = Solmicro.Expertis.Engine.RelationMode.NoRelation
        Me.GrdApuntesAlbaran.RequeryManually = True
        Me.GrdApuntesAlbaran.SecondaryDataFields = Nothing
        Me.GrdApuntesAlbaran.Size = New System.Drawing.Size(1035, 532)
        Me.GrdApuntesAlbaran.TabIndex = 9
        Me.GrdApuntesAlbaran.Tag = ""
        Me.GrdApuntesAlbaran.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.GrdApuntesAlbaran.ViewName = ""
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.FraApuntesAlbaran)
        Me.SplitContainer1.Panel2Collapsed = True
        Me.SplitContainer1.Size = New System.Drawing.Size(1041, 552)
        Me.SplitContainer1.SplitterDistance = 276
        Me.SplitContainer1.TabIndex = 3
        '
        'frmDescontabilizar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1041, 611)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.pnlBottom)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmDescontabilizar"
        Me.Text = "Descontabilización Albaranes"
        Me.pnlBottom.ResumeLayout(False)
        Me.FraApuntesAlbaran.ResumeLayout(False)
        CType(Me.GrdApuntesAlbaran, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlBottom As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents FraApuntesAlbaran As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents GrdApuntesAlbaran As Solmicro.Expertis.Engine.UI.Grid
    Friend WithEvents cmdCancelar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents cmdAceptar As Solmicro.Expertis.Engine.UI.Button
End Class
