<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.txtNum = New System.Windows.Forms.TextBox()
        Me.lblDato = New System.Windows.Forms.Label()
        Me.lblResultado = New System.Windows.Forms.Label()
        Me.cmdEjecutar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblTitulo.Location = New System.Drawing.Point(58, 26)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(322, 25)
        Me.lblTitulo.TabIndex = 0
        Me.lblTitulo.Text = "Introduce un numero diferente a 0"
        '
        'txtNum
        '
        Me.txtNum.Location = New System.Drawing.Point(152, 120)
        Me.txtNum.Name = "txtNum"
        Me.txtNum.Size = New System.Drawing.Size(100, 23)
        Me.txtNum.TabIndex = 1
        '
        'lblDato
        '
        Me.lblDato.AutoSize = True
        Me.lblDato.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblDato.Location = New System.Drawing.Point(152, 86)
        Me.lblDato.Name = "lblDato"
        Me.lblDato.Size = New System.Drawing.Size(149, 20)
        Me.lblDato.TabIndex = 2
        Me.lblDato.Text = "Introduce el numero"
        '
        'lblResultado
        '
        Me.lblResultado.AutoSize = True
        Me.lblResultado.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblResultado.Location = New System.Drawing.Point(152, 200)
        Me.lblResultado.Name = "lblResultado"
        Me.lblResultado.Size = New System.Drawing.Size(0, 21)
        Me.lblResultado.TabIndex = 3
        '
        'cmdEjecutar
        '
        Me.cmdEjecutar.Location = New System.Drawing.Point(165, 162)
        Me.cmdEjecutar.Name = "cmdEjecutar"
        Me.cmdEjecutar.Size = New System.Drawing.Size(75, 23)
        Me.cmdEjecutar.TabIndex = 4
        Me.cmdEjecutar.Text = "Ejecutar"
        Me.cmdEjecutar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(426, 408)
        Me.Controls.Add(Me.cmdEjecutar)
        Me.Controls.Add(Me.lblResultado)
        Me.Controls.Add(Me.lblDato)
        Me.Controls.Add(Me.txtNum)
        Me.Controls.Add(Me.lblTitulo)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitulo As Label
    Friend WithEvents txtNum As TextBox
    Friend WithEvents lblDato As Label
    Friend WithEvents lblResultado As Label
    Friend WithEvents cmdEjecutar As Button
End Class
