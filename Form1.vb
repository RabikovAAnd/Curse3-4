Imports System.Drawing
Imports System.Windows.Forms

Public Class Form1
    Private Sub btnRectangle_Click(sender As Object, e As EventArgs) Handles btnRectangle.Click
        ' Создаем прямоугольник
        Dim rect As New Rectangle(
            New Point(10, 10),
            New Point(100, 60),
            Color.Red,
            Color.Yellow)

        ' Вычисляем периметр и площадь
        lblPerimeter.Text = "Периметр: " & rect.CalculatePerimeter().ToString()
        lblArea.Text = "Площадь: " & rect.CalculateArea().ToString()

        ' Рисуем прямоугольник
        rect.Draw(Me)
    End Sub

    Private Sub btnTax_Click(sender As Object, e As EventArgs) Handles btnTax.Click
        ' Создаем объект транспортного налога
        Dim tax As New TransportTax(
            "Москва",
            2023,
            "Легковой автомобиль",
            150,
            12,
            True)

        ' Рассчитываем налог
        Dim taxAmount As Decimal = tax.CalculateTax()
        Dim discount As Decimal = tax.CalculateDiscount()

        lblTaxAmount.Text = "Сумма налога: " & taxAmount.ToString("C")
        lblDiscount.Text = "Льгота: " & discount.ToString("C")
        lblTotal.Text = "Итого к оплате: " & (taxAmount - discount).ToString("C")
    End Sub
End Class

' Класс Прямоугольник
Public Class Rectangle
    Public Property TopLeft As Point
    Public Property BottomRight As Point
    Public Property BorderColor As Color
    Public Property FillColor As Color

    Public ReadOnly Property Width As Integer
        Get
            Return BottomRight.X - TopLeft.X
        End Get
    End Property

    Public ReadOnly Property Height As Integer
        Get
            Return BottomRight.Y - TopLeft.Y
        End Get
    End Property

    Public Sub New(topLeft As Point, bottomRight As Point, borderColor As Color, fillColor As Color)
        Me.TopLeft = topLeft
        Me.BottomRight = bottomRight
        Me.BorderColor = borderColor
        Me.FillColor = fillColor
    End Sub

    Public Function CalculatePerimeter() As Integer
        Return 2 * (Width + Height)
    End Function

    Public Function CalculateArea() As Integer
        Return Width * Height
    End Function

    Public Sub Draw(form As Form)
        Dim g As Graphics = form.CreateGraphics()

        ' Рисуем заливку
        Using brush As New SolidBrush(FillColor)
            g.FillRectangle(brush, TopLeft.X, TopLeft.Y, Width, Height)
        End Using

        ' Рисуем границу
        Using pen As New Pen(BorderColor, 2)
            g.DrawRectangle(pen, TopLeft.X, TopLeft.Y, Width, Height)
        End Using
    End Sub
End Class

' Класс Транспортный налог
Public Class TransportTax
    Public Property Region As String
    Public Property Year As Integer
    Public Property VehicleType As String
    Public Property Power As Integer ' в л.с.
    Public Property Period As Integer ' в месяцах
    Public Property HasDiscount As Boolean

    Public Sub New(region As String, year As Integer, vehicleType As String, power As Integer, period As Integer, hasDiscount As Boolean)
        Me.Region = region
        Me.Year = year
        Me.VehicleType = vehicleType
        Me.Power = power
        Me.Period = period
        Me.HasDiscount = hasDiscount
    End Sub

    Public Function CalculateTax() As Decimal
        ' Базовая ставка (руб/л.с.)
        Dim baseRate As Decimal = 0

        ' Определяем ставку в зависимости от региона
        Select Case Region.ToLower()
            Case "москва"
                If Power <= 100 Then
                    baseRate = 12
                ElseIf Power <= 150 Then
                    baseRate = 25
                Else
                    baseRate = 50
                End If
            Case "санкт-петербург"
                If Power <= 100 Then
                    baseRate = 10
                ElseIf Power <= 150 Then
                    baseRate = 20
                Else
                    baseRate = 45
                End If
            Case Else
                If Power <= 100 Then
                    baseRate = 8
                ElseIf Power <= 150 Then
                    baseRate = 15
                Else
                    baseRate = 30
                End If
        End Select

        ' Рассчитываем налог с учетом периода владения
        Dim tax As Decimal = baseRate * Power * (Period / 12)
        Return tax
    End Function

    Public Function CalculateDiscount() As Decimal
        If Not HasDiscount Then Return 0

        ' Размер льготы (например, 50% от суммы налога)
        Dim discountRate As Decimal = 0.5D
        Return CalculateTax() * discountRate
    End Function

    Public Sub Recalculate(newPower As Integer, newPeriod As Integer)
        Power = newPower
        Period = newPeriod
    End Sub
End Class