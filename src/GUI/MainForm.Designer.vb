Namespace Draw
	Partial Class MainForm
		Inherits Form

		''' <summary>
		''' Designer variable used to keep track of non-visual components.
		''' </summary>
		Private components As System.ComponentModel.IContainer

		''' <summary>
		''' Disposes resources used by the form.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing Then
				If components IsNot Nothing Then
					components.Dispose()
				End If
			End If
			MyBase.Dispose(disposing)
		End Sub

		''' <summary>
		''' This method is required for Windows Forms designer support.
		''' Do not change the method contents inside the source code editor. The Forms designer might
		''' not be able to load this method if it was changed manually.
		''' </summary>
		Private Sub InitializeComponent()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
			Me.mainMenu = New System.Windows.Forms.MenuStrip()
			Me.fileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.exitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.editToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.imageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.helpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.aboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.statusBar = New System.Windows.Forms.StatusStrip()
			Me.currentStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
			Me.speedMenu = New System.Windows.Forms.ToolStrip()
			Me.drawRectangleSpeedButton = New System.Windows.Forms.ToolStripButton()
			Me.pickUpSpeedButton = New System.Windows.Forms.ToolStripButton()
			Me.viewPort = New Draw.DoubleBufferedPanel()
			Me.mainMenu.SuspendLayout()
			Me.statusBar.SuspendLayout()
			Me.speedMenu.SuspendLayout()
			Me.SuspendLayout()
			' 
			' mainMenu
			' 
			Me.mainMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.fileToolStripMenuItem, Me.editToolStripMenuItem, Me.imageToolStripMenuItem, Me.helpToolStripMenuItem})
			Me.mainMenu.Location = New System.Drawing.Point(0, 0)
			Me.mainMenu.Name = "mainMenu"
			Me.mainMenu.Size = New System.Drawing.Size(693, 24)
			Me.mainMenu.TabIndex = 1
			Me.mainMenu.Text = "menuStrip1"
			' 
			' fileToolStripMenuItem
			' 
			Me.fileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.exitToolStripMenuItem})
			Me.fileToolStripMenuItem.Name = "fileToolStripMenuItem"
			Me.fileToolStripMenuItem.Size = New System.Drawing.Size(35, 20)
			Me.fileToolStripMenuItem.Text = "File"
			' 
			' exitToolStripMenuItem
			' 
			Me.exitToolStripMenuItem.Name = "exitToolStripMenuItem"
			Me.exitToolStripMenuItem.Size = New System.Drawing.Size(92, 22)
			Me.exitToolStripMenuItem.Text = "Exit"
			AddHandler Me.exitToolStripMenuItem.Click, AddressOf Me.ExitToolStripMenuItemClick
			' 
			' editToolStripMenuItem
			' 
			Me.editToolStripMenuItem.Name = "editToolStripMenuItem"
			Me.editToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
			Me.editToolStripMenuItem.Text = "Edit"
			' 
			' imageToolStripMenuItem
			' 
			Me.imageToolStripMenuItem.Name = "imageToolStripMenuItem"
			Me.imageToolStripMenuItem.Size = New System.Drawing.Size(49, 20)
			Me.imageToolStripMenuItem.Text = "Image"
			' 
			' helpToolStripMenuItem
			' 
			Me.helpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.aboutToolStripMenuItem})
			Me.helpToolStripMenuItem.Name = "helpToolStripMenuItem"
			Me.helpToolStripMenuItem.Size = New System.Drawing.Size(40, 20)
			Me.helpToolStripMenuItem.Text = "Help"
			' 
			' aboutToolStripMenuItem
			' 
			Me.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem"
			Me.aboutToolStripMenuItem.Size = New System.Drawing.Size(115, 22)
			Me.aboutToolStripMenuItem.Text = "About..."
			' 
			' statusBar
			' 
			Me.statusBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.currentStatusLabel})
			Me.statusBar.Location = New System.Drawing.Point(0, 401)
			Me.statusBar.Name = "statusBar"
			Me.statusBar.Size = New System.Drawing.Size(693, 22)
			Me.statusBar.TabIndex = 2
			Me.statusBar.Text = "statusStrip1"
			' 
			' currentStatusLabel
			' 
			Me.currentStatusLabel.Name = "currentStatusLabel"
			Me.currentStatusLabel.Size = New System.Drawing.Size(0, 17)
			' 
			' speedMenu
			' 
			Me.speedMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.drawRectangleSpeedButton, Me.pickUpSpeedButton})
			Me.speedMenu.Location = New System.Drawing.Point(0, 24)
			Me.speedMenu.Name = "speedMenu"
			Me.speedMenu.Size = New System.Drawing.Size(693, 25)
			Me.speedMenu.TabIndex = 3
			Me.speedMenu.Text = "toolStrip1"
			' 
			' drawRectangleSpeedButton
			' 
			Me.drawRectangleSpeedButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
			Me.drawRectangleSpeedButton.Image = DirectCast((resources.GetObject("drawRectangleSpeedButton.Image")), System.Drawing.Image)
			Me.drawRectangleSpeedButton.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.drawRectangleSpeedButton.Name = "drawRectangleSpeedButton"
			Me.drawRectangleSpeedButton.Size = New System.Drawing.Size(23, 22)
			Me.drawRectangleSpeedButton.Text = "DrawRectangleButton"
			AddHandler Me.drawRectangleSpeedButton.Click, AddressOf Me.DrawRectangleSpeedButtonClick
			' 
			' pickUpSpeedButton
			' 
			Me.pickUpSpeedButton.CheckOnClick = True
			Me.pickUpSpeedButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
			Me.pickUpSpeedButton.Image = DirectCast((resources.GetObject("pickUpSpeedButton.Image")), System.Drawing.Image)
			Me.pickUpSpeedButton.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.pickUpSpeedButton.Name = "pickUpSpeedButton"
			Me.pickUpSpeedButton.Size = New System.Drawing.Size(23, 22)
			Me.pickUpSpeedButton.Text = "toolStripButton1"
			' 
			' viewPort
			' 
			Me.viewPort.Dock = System.Windows.Forms.DockStyle.Fill
			Me.viewPort.Location = New System.Drawing.Point(0, 49)
			Me.viewPort.Name = "viewPort"
			Me.viewPort.Size = New System.Drawing.Size(693, 352)
			Me.viewPort.TabIndex = 4
			AddHandler Me.viewPort.Paint, AddressOf Me.ViewPortPaint
			AddHandler Me.viewPort.MouseMove, AddressOf Me.ViewPortMouseMove
			AddHandler Me.viewPort.MouseDown, AddressOf Me.ViewPortMouseDown
			AddHandler Me.viewPort.MouseUp, AddressOf Me.ViewPortMouseUp
			' 
			' MainForm
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(693, 423)
			Me.Controls.Add(Me.viewPort)
			Me.Controls.Add(Me.speedMenu)
			Me.Controls.Add(Me.statusBar)
			Me.Controls.Add(Me.mainMenu)
			Me.Icon = DirectCast((resources.GetObject("$this.Icon")), System.Drawing.Icon)
			Me.MainMenuStrip = Me.mainMenu
			Me.Name = "MainForm"
			Me.Text = "Draw"
			Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
			Me.mainMenu.ResumeLayout(False)
			Me.mainMenu.PerformLayout()
			Me.statusBar.ResumeLayout(False)
			Me.statusBar.PerformLayout()
			Me.speedMenu.ResumeLayout(False)
			Me.speedMenu.PerformLayout()
			Me.ResumeLayout(False)
			Me.PerformLayout()
		End Sub

		Private currentStatusLabel As System.Windows.Forms.ToolStripStatusLabel
		Private viewPort As Draw.DoubleBufferedPanel
		Private pickUpSpeedButton As System.Windows.Forms.ToolStripButton
		Private drawRectangleSpeedButton As System.Windows.Forms.ToolStripButton
		Private aboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private helpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private imageToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private editToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private exitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private fileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private speedMenu As System.Windows.Forms.ToolStrip
		Private statusBar As System.Windows.Forms.StatusStrip
		Private mainMenu As System.Windows.Forms.MenuStrip
	End Class
End Namespace
