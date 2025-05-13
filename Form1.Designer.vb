<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
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

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnRectangle = New System.Windows.Forms.Button()
        Me.lblPerimeter = New System.Windows.Forms.Label()
        Me.lblArea = New System.Windows.Forms.Label()
        Me.btnTax = New System.Windows.Forms.Button()
        Me.lblTaxAmount = New System.Windows.Forms.Label()
        Me.lblDiscount = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnRectangle
        '
        Me.btnRectangle.Location = New System.Drawing.Point(12, 12)
        Me.btnRectangle.Name = "btnRectangle"
        Me.btnRectangle.Size = New System.Drawing.Size(200, 40)
        Me.btnRectangle.TabIndex = 0
        Me.btnRectangle.Text = "Создать прямоугольник"
        Me.btnRectangle.UseVisualStyleBackColor = True
        '
        'lblPerimeter
        '
        Me.lblPerimeter.AutoSize = True
        Me.lblPerimeter.Location = New System.Drawing.Point(12, 65)
        Me.lblPerimeter.Name = "lblPerimeter"
        Me.lblPerimeter.Size = New System.Drawing.Size(62, 13)
        Me.lblPerimeter.TabIndex = 1
        Me.lblPerimeter.Text = "Периметр:"
        '
        'lblArea
        '
        Me.lblArea.AutoSize = True
        Me.lblArea.Location = New System.Drawing.Point(12, 88)
        Me.lblArea.Name = "lblArea"
        Me.lblArea.Size = New System.Drawing.Size(57, 13)
        Me.lblArea.TabIndex = 2
        Me.lblArea.Text = "Площадь:"
        '
        'btnTax
        '
        Me.btnTax.Location = New System.Drawing.Point(12, 120)
        Me.btnTax.Name = "btnTax"
        Me.btnTax.Size = New System.Drawing.Size(200, 40)
        Me.btnTax.TabIndex = 3
        Me.btnTax.Text = "Рассчитать транспортный налог"
        Me.btnTax.UseVisualStyleBackColor = True
        '
        'lblTaxAmount
        '
        Me.lblTaxAmount.AutoSize = True
        Me.lblTaxAmount.Location = New System.Drawing.Point(12, 173)
        Me.lblTaxAmount.Name = "lblTaxAmount"
        Me.lblTaxAmount.Size = New System.Drawing.Size(75, 13)
        Me.lblTaxAmount.TabIndex = 4
        Me.lblTaxAmount.Text = "Сумма налога"
        '
        'lblDiscount
        '
        Me.lblDiscount.AutoSize = True
        Me.lblDiscount.Location = New System.Drawing.Point(12, 196)
        Me.lblDiscount.Name = "lblDiscount"
        Me.lblDiscount.Size = New System.Drawing.Size(42, 13)
        Me.lblDiscount.TabIndex = 5
        Me.lblDiscount.Text = "Льгота"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(12, 219)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(80, 13)
        Me.lblTotal.TabIndex = 6
        Me.lblTotal.Text = "Итого к оплате"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 261)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lblDiscount)
        Me.Controls.Add(Me.lblTaxAmount)
        Me.Controls.Add(Me.btnTax)
        Me.Controls.Add(Me.lblArea)
        Me.Controls.Add(Me.lblPerimeter)
        Me.Controls.Add(Me.btnRectangle)
        Me.Name = "Form1"
        Me.Text = "ООП - Вариант 1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnRectangle As Button
    Friend WithEvents lblPerimeter As Label
    Friend WithEvents lblArea As Label
    Friend WithEvents btnTax As Button
    Friend WithEvents lblTaxAmount As Label
    Friend WithEvents lblDiscount As Label
    Friend WithEvents lblTotal As Label
End Class