<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormlistaVentas
    Inherits System.Windows.Forms.Form

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
        Me.Dgventas = New System.Windows.Forms.DataGridView()
        Me.txtbsucar = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.Dgventas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Dgventas
        '
        Me.Dgventas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgventas.Location = New System.Drawing.Point(12, 87)
        Me.Dgventas.Name = "Dgventas"
        Me.Dgventas.Size = New System.Drawing.Size(630, 376)
        Me.Dgventas.TabIndex = 0
        '
        'txtbsucar
        '
        Me.txtbsucar.Location = New System.Drawing.Point(228, 38)
        Me.txtbsucar.Name = "txtbsucar"
        Me.txtbsucar.Size = New System.Drawing.Size(307, 20)
        Me.txtbsucar.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(126, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Buscar :"
        '
        'FormlistaVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(654, 475)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtbsucar)
        Me.Controls.Add(Me.Dgventas)
        Me.Name = "FormlistaVentas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ventas Realizadas"
        CType(Me.Dgventas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Dgventas As DataGridView
    Friend WithEvents txtbsucar As TextBox
    Friend WithEvents Label1 As Label
End Class
