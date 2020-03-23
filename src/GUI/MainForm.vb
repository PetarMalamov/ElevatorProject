Namespace Draw
	''' <summary>
	''' Върху главната форма е поставен потребителски контрол,
	''' в който се осъществява визуализацията
	''' </summary>
	Public Partial Class MainForm
		''' <summary>
		''' Агрегирания диалогов процесор във формата улеснява манипулацията на модела.
		''' </summary>
		Private dialogProcessor As New DialogProcessor()

		Public Sub New()
			'
			' The InitializeComponent() call is required for Windows Forms designer support.
			'
			Me.InitializeComponent()
			
			'
			' TODO: Add constructor code after the InitializeComponent() call.
			'
		End Sub

		''' <summary>
		''' Изход от програмата. Затваря главната форма, а с това и програмата.
		''' </summary>
		Private Sub ExitToolStripMenuItemClick(ByVal sender As Object, ByVal e As EventArgs)
			Close()
		End Sub

		''' <summary>
		''' Събитието, което се прихваща, за да се превизуализира при изменение на модела.
		''' </summary>
		Private Sub ViewPortPaint(ByVal sender As Object, ByVal e As PaintEventArgs)
			dialogProcessor.ReDraw(sender, e)
		End Sub

		''' <summary>
		''' Бутон, който поставя на произволно място правоъгълник със зададените размери.
		''' Променя се лентата със състоянието и се инвалидира контрола, в който визуализираме.
		''' </summary>
		Private Sub DrawRectangleSpeedButtonClick(ByVal sender As Object, ByVal e As EventArgs)
			dialogProcessor.AddRandomRectangle()

			statusBar.Items(0).Text = "Последно действие: Рисуване на правоъгълник"

			viewPort.Invalidate()
		End Sub

		''' <summary>
		''' Прихващане на координатите при натискането на бутон на мишката и проверка (в обратен ред) дали не е
		''' щракнато върху елемент. Ако е така то той се отбелязва като селектиран и започва процес на "влачене".
		''' Промяна на статуса и инвалидиране на контрола, в който визуализираме.
		''' Реализацията се диалогът с потребителя, при който се избира "най-горния" елемент от екрана.
		''' </summary>
		Private Sub ViewPortMouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
			If pickUpSpeedButton.Checked Then
				dialogProcessor.Selection = dialogProcessor.ContainsPoint(e.Location)
				If dialogProcessor.Selection IsNot Nothing Then
					statusBar.Items(0).Text = "Последно действие: Селекция на примитив"
					dialogProcessor.IsDragging = True
					dialogProcessor.LastLocation = e.Location
					viewPort.Invalidate()
				End If
			End If
		End Sub

		''' <summary>
		''' Прихващане на преместването на мишката.
		''' Ако сме в режм на "влачене", то избрания елемент се транслира.
		''' </summary>
		Private Sub ViewPortMouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
			If dialogProcessor.IsDragging Then
				If dialogProcessor.Selection IsNot Nothing Then
					statusBar.Items(0).Text = "Последно действие: Влачене"
				End If
				dialogProcessor.TranslateTo(e.Location)
				viewPort.Invalidate()
			End If
		End Sub

		''' <summary>
		''' Прихващане на отпускането на бутона на мишката.
		''' Излизаме от режим "влачене".
		''' </summary>
		Private Sub ViewPortMouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
			dialogProcessor.IsDragging = False
		End Sub
	End Class
End Namespace
