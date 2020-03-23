Namespace Draw
	''' <summary>
	''' Класът, който ще бъде използван при управляване на диалога.
	''' </summary>
	Public Class DialogProcessor
		Inherits DisplayProcessor
		#Region "Constructor"

		Public Sub New()
		End Sub

		#End Region

		#Region "Properties"

		''' <summary>
		''' Избран елемент.
		''' </summary>
		Private m_selection As Shape
		Public Property Selection() As Shape
			Get
				Return m_selection
			End Get
			Set
				m_selection = value
			End Set
		End Property

		''' <summary>
		''' Дали в момента диалога е в състояние на "влачене" на избрания елемент.
		''' </summary>
		Private m_isDragging As Boolean
		Public Property IsDragging() As Boolean
			Get
				Return m_isDragging
			End Get
			Set
				m_isDragging = value
			End Set
		End Property

		''' <summary>
		''' Последна позиция на мишката при "влачене".
		''' Използва се за определяне на вектора на транслация.
		''' </summary>
		Private m_lastLocation As PointF
		Public Property LastLocation() As PointF
			Get
				Return m_lastLocation
			End Get
			Set
				m_lastLocation = value
			End Set
		End Property

		#End Region

		''' <summary>
		''' Добавя примитив - правоъгълник на произволно място върху клиентската област.
		''' </summary>
		Public Sub AddRandomRectangle()
			Dim rnd As New Random()
			Dim x As Integer = rnd.[Next](100, 1000)
			Dim y As Integer = rnd.[Next](100, 600)

			Dim rect As New RectangleShape(New Rectangle(x, y, 100, 200))
			rect.FillColor = Color.White

			ShapeList.Add(rect)
		End Sub

		''' <summary>
		''' Проверява дали дадена точка е в елемента.
		''' Обхожда в ред обратен на визуализацията с цел намиране на
		''' "най-горния" елемент т.е. този който виждаме под мишката.
		''' </summary>
		''' <param name="point">Указана точка</param>
		''' <returns>Елемента на изображението, на който принадлежи дадената точка.</returns>
		Public Function ContainsPoint(ByVal point As PointF) As Shape
			For i As Integer = ShapeList.Count - 1 To 0 Step -1
				If ShapeList(i).Contains(point) Then
					ShapeList(i).FillColor = Color.Red

					Return ShapeList(i)
				End If
			Next
			Return Nothing
		End Function

		''' <summary>
		''' Транслация на избраният елемент на вектор определен от <paramref name="p>p</paramref>
		''' </summary>
		''' <param name="p">Вектор на транслация.</param>
		Public Sub TranslateTo(ByVal p As PointF)
			If m_selection IsNot Nothing Then
				m_selection.Location = New PointF(m_selection.Location.X + p.X - m_lastLocation.X, m_selection.Location.Y + p.Y - m_lastLocation.Y)
				m_lastLocation = p
			End If
		End Sub
	End Class
End Namespace
