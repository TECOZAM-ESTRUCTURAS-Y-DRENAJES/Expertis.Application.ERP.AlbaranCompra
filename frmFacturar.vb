Public Class frmFacturar
    Inherits Solmicro.Expertis.Engine.UI.FormBase

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()

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
    Public WithEvents fwiSuFecha As Solmicro.Expertis.Engine.UI.CalendarBox
    Public WithEvents fwiSuFactura As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents lblfwiSuFactura As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents cmdCancelar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents cmdAceptar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents lblfwiSuFecha As Solmicro.Expertis.Engine.UI.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.fwiSuFecha = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.fwiSuFactura = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblfwiSuFactura = New Solmicro.Expertis.Engine.UI.Label
        Me.lblfwiSuFecha = New Solmicro.Expertis.Engine.UI.Label
        Me.cmdCancelar = New Solmicro.Expertis.Engine.UI.Button
        Me.cmdAceptar = New Solmicro.Expertis.Engine.UI.Button
        Me.SuspendLayout()
        '
        'fwiSuFecha
        '
        Me.fwiSuFecha.DisabledBackColor = System.Drawing.Color.White
        Me.fwiSuFecha.Location = New System.Drawing.Point(104, 39)
        Me.fwiSuFecha.Name = "fwiSuFecha"
        Me.fwiSuFecha.Size = New System.Drawing.Size(99, 21)
        Me.fwiSuFecha.TabIndex = 1
        '
        'fwiSuFactura
        '
        Me.fwiSuFactura.DisabledBackColor = System.Drawing.Color.White
        Me.fwiSuFactura.Location = New System.Drawing.Point(104, 12)
        Me.fwiSuFactura.Name = "fwiSuFactura"
        Me.fwiSuFactura.Size = New System.Drawing.Size(99, 21)
        Me.fwiSuFactura.TabIndex = 0
        '
        'lblfwiSuFactura
        '
        Me.lblfwiSuFactura.Location = New System.Drawing.Point(24, 12)
        Me.lblfwiSuFactura.Name = "lblfwiSuFactura"
        Me.lblfwiSuFactura.Size = New System.Drawing.Size(68, 13)
        Me.lblfwiSuFactura.TabIndex = 4
        Me.lblfwiSuFactura.Text = "Su Factura"
        '
        'lblfwiSuFecha
        '
        Me.lblfwiSuFecha.Location = New System.Drawing.Point(24, 39)
        Me.lblfwiSuFecha.Name = "lblfwiSuFecha"
        Me.lblfwiSuFecha.Size = New System.Drawing.Size(59, 13)
        Me.lblfwiSuFecha.TabIndex = 5
        Me.lblfwiSuFecha.Text = "Su Fecha"
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Location = New System.Drawing.Point(145, 73)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(95, 28)
        Me.cmdCancelar.TabIndex = 7
        Me.cmdCancelar.Text = "Cancelar"
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Location = New System.Drawing.Point(47, 73)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(95, 28)
        Me.cmdAceptar.TabIndex = 6
        Me.cmdAceptar.Text = "Aceptar"
        '
        'frmFacturar
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(286, 109)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.cmdAceptar)
        Me.Controls.Add(Me.lblfwiSuFecha)
        Me.Controls.Add(Me.lblfwiSuFactura)
        Me.Controls.Add(Me.fwiSuFecha)
        Me.Controls.Add(Me.fwiSuFactura)
        Me.Name = "frmFacturar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Datos para la Facturación"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Public OK As Boolean
    Private Sub cmdCancelar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        OK = False
        Me.Close()
    End Sub

    Private Sub cmdAceptar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        If IsDate(Me.fwiSuFecha.Value) Then
            OK = True
            Me.Visible = False
        Else
            ExpertisApp.GenerateMessage("La fecha es obligatoria", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

End Class
