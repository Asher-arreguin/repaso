<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.num1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.num2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BTNSUMA = New System.Windows.Forms.Button()
        Me.RESTA = New System.Windows.Forms.Button()
        Me.MULTIPLICAR = New System.Windows.Forms.Button()
        Me.DIVIDIR = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'num1
        '
        Me.num1.Location = New System.Drawing.Point(307, 23)
        Me.num1.Name = "num1"
        Me.num1.Size = New System.Drawing.Size(100, 20)
        Me.num1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(17, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(205, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "PRIMER NUMERO"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(674, 409)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 29)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "SUMA"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(317, 112)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(24, 25)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "0"
        '
        'num2
        '
        Me.num2.Location = New System.Drawing.Point(307, 49)
        Me.num2.Name = "num2"
        Me.num2.Size = New System.Drawing.Size(100, 20)
        Me.num2.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(17, 49)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(230, 25)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "SEGUNDO NUMERO"
        '
        'BTNSUMA
        '
        Me.BTNSUMA.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNSUMA.Location = New System.Drawing.Point(22, 86)
        Me.BTNSUMA.Name = "BTNSUMA"
        Me.BTNSUMA.Size = New System.Drawing.Size(75, 23)
        Me.BTNSUMA.TabIndex = 6
        Me.BTNSUMA.Text = "SUMA"
        Me.BTNSUMA.UseVisualStyleBackColor = True
        '
        'RESTA
        '
        Me.RESTA.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RESTA.Location = New System.Drawing.Point(22, 116)
        Me.RESTA.Name = "RESTA"
        Me.RESTA.Size = New System.Drawing.Size(75, 23)
        Me.RESTA.TabIndex = 7
        Me.RESTA.Text = "RESTA"
        Me.RESTA.UseVisualStyleBackColor = True
        '
        'MULTIPLICAR
        '
        Me.MULTIPLICAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MULTIPLICAR.Location = New System.Drawing.Point(22, 145)
        Me.MULTIPLICAR.Name = "MULTIPLICAR"
        Me.MULTIPLICAR.Size = New System.Drawing.Size(104, 23)
        Me.MULTIPLICAR.TabIndex = 8
        Me.MULTIPLICAR.Text = "MULTIPLICAR"
        Me.MULTIPLICAR.UseVisualStyleBackColor = True
        '
        'DIVIDIR
        '
        Me.DIVIDIR.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DIVIDIR.Location = New System.Drawing.Point(22, 174)
        Me.DIVIDIR.Name = "DIVIDIR"
        Me.DIVIDIR.Size = New System.Drawing.Size(104, 23)
        Me.DIVIDIR.TabIndex = 9
        Me.DIVIDIR.Text = "DIVIDIR"
        Me.DIVIDIR.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.DIVIDIR)
        Me.Controls.Add(Me.MULTIPLICAR)
        Me.Controls.Add(Me.RESTA)
        Me.Controls.Add(Me.BTNSUMA)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.num2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.num1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents num1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents num2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents BTNSUMA As Button
    Friend WithEvents RESTA As Button
    Friend WithEvents MULTIPLICAR As Button
    Friend WithEvents DIVIDIR As Button
End Class
