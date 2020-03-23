Namespace Draw
	''' <summary>
	''' Класът правоъгълник е основен примитив, който е наследник на базовия Shape.
	''' </summary>
	Public Class RectangleShape
		Inherits Shape
		#Region "Constructor"

		Public Sub New(ByVal rect As RectangleF)
			MyBase.New(rect)
		End Sub

		Public Sub New(ByVal rectangle As RectangleShape)
			MyBase.New(rectangle)
		End Sub

		#End Region

		''' <summary>
		''' Проверка за принадлежност на точка point към правоъгълника.
		''' В случая на правоъгълник този метод може да не бъде пренаписван, защото
		''' Реализацията съвпада с тази на абстрактния клас Shape, който проверява
		''' дали точката е в обхващащия правоъгълник на елемента (а той съвпада с
		''' елемента в този случай).
		''' </summary>
		Public Overloads Overrides Function Contains(ByVal point As PointF) As Boolean
			If MyBase.Contains(point) Then
				Return True
			Else
				Return False
				' Проверка дали е в обекта само, ако точката е в обхващащия правоъгълник.
				' В случая на правоъгълник - директно връщаме true
				' Ако не е в обхващащия правоъгълникр, то неможе да е в обекта и => false
			End If
		End Function

		''' <summary>
		''' Частта, визуализираща конкретния примитив.
		''' </summary>
		Public Overloads Overrides Sub DrawSelf(ByVal grfx As Graphics)
			MyBase.DrawSelf(grfx)

			grfx.FillRectangle(New SolidBrush(FillColor), Rectangle.X, Rectangle.Y, Rectangle.Width, Rectangle.Height)
			grfx.DrawRectangle(Pens.Black, Rectangle.X, Rectangle.Y, Rectangle.Width, Rectangle.Height)

		End Sub
	End Class
End Namespace
