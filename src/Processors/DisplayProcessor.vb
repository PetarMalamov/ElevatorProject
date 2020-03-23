Imports System.Drawing.Drawing2D

Namespace Draw
	''' <summary>
	''' Класът, който ще бъде използван при управляване на дисплейната система.
	''' </summary>
	Public Class DisplayProcessor
		#Region "Constructor"

		Public Sub New()
		End Sub

		#End Region

		#Region "Properties"

		''' <summary>
		''' Списък с всички елементи формиращи изображението.
		''' </summary>
		Private m_shapeList As New List(Of Shape)()
		Public Property ShapeList() As List(Of Shape)
			Get
				Return m_shapeList
			End Get
			Set
				m_shapeList = value
			End Set
		End Property

		#End Region

		#Region "Drawing"

		''' <summary>
		''' Прерисува всички елементи в shapeList върху e.Graphics
		''' </summary>
		Public Sub ReDraw(ByVal sender As Object, ByVal e As PaintEventArgs)
			e.Graphics.SmoothingMode = SmoothingMode.AntiAlias
			Draw(e.Graphics)
		End Sub

		''' <summary>
		''' Визуализация.
		''' Обхождане на всички елементи в списъка и извикване на визуализиращия им метод.
		''' </summary>
		''' <param name="grfx">Къде да се извърши визуализацията.</param>
		Public Overridable Sub Draw(ByVal grfx As Graphics)
			For Each item As Shape In ShapeList
				DrawShape(grfx, item)
			Next
		End Sub

		''' <summary>
		''' Визуализира даден елемент от изображението.
		''' </summary>
		''' <param name="grfx">Къде да се извърши визуализацията.</param>
		''' <param name="item">Елемент за визуализиране.</param>
		Public Overridable Sub DrawShape(ByVal grfx As Graphics, ByVal item As Shape)
			item.DrawSelf(grfx)
		End Sub

		#End Region
	End Class
End Namespace
