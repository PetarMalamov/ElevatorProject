Namespace Draw
	''' <summary>
	''' Базовия клас на примитивите, който съдържа общите характеристики на примитивите.
	''' </summary>
	Public MustInherit Class Shape
		#Region "Constructors"

		Public Sub New()
		End Sub

		Public Sub New(ByVal rect As RectangleF)
			m_rectangle = rect
		End Sub

		Public Sub New(ByVal shape As Shape)
			Me.Height = shape.Height
			Me.Location = shape.Location
			Me.m_rectangle = shape.rectangle
			Me.Width = shape.Width

			Me.FillColor = shape.FillColor
		End Sub
		#End Region

		#Region "Properties"

		''' <summary>
		''' Обхващащ правоъгълник на елемента. В случая двата съвпадат.
		''' </summary>
		Private m_rectangle As RectangleF
		Public Overridable Property Rectangle() As RectangleF
			Get
				Return m_rectangle
			End Get
			Set
				m_rectangle = value
			End Set
		End Property

		''' <summary>
		''' Широчина на елемента.
		''' </summary>
		Public Overridable Property Width() As Single
			Get
				Return Rectangle.Width
			End Get
			Set
				m_rectangle.Width = value
			End Set
		End Property

		''' <summary>
		''' Височина на елемента.
		''' </summary>
		Public Overridable Property Height() As Single
			Get
				Return Rectangle.Height
			End Get
			Set
				m_rectangle.Height = value
			End Set
		End Property

		''' <summary>
		''' Горен ляв ъгъл на елемента.
		''' </summary>
		Public Overridable Property Location() As PointF
			Get
				Return Rectangle.Location
			End Get
			Set
				m_rectangle.Location = value
			End Set
		End Property

		''' <summary>
		''' Цвят на елемента.
		''' </summary>
		Private m_fillColor As Color
		Public Overridable Property FillColor() As Color
			Get
				Return m_fillColor
			End Get
			Set
				m_fillColor = value
			End Set
		End Property

		#End Region


		''' <summary>
		''' Проверка дали точка point принадлежи на елемента.
		''' </summary>
		''' <param name="point">Точка</param>
		''' <returns>Връща true, ако точката принадлежи на елемента и
		''' false, ако не пренадлежи</returns>
		Public Overridable Function Contains(ByVal point As PointF) As Boolean
			Return Rectangle.Contains(point.X, point.Y)
		End Function

		''' <summary>
		''' Визуализира елемента.
		''' </summary>
		''' <param name="grfx">Къде да бъде визуализиран елемента.</param>
		Public Overridable Sub DrawSelf(ByVal grfx As Graphics)
			' shape.Rectangle.Inflate(shape.BorderWidth, shape.BorderWidth);
		End Sub

	End Class
End Namespace
