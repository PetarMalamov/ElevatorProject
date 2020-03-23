Imports Microsoft.VisualBasic.ApplicationServices

Namespace My
	''' <summary>
	''' Клас с входната точка на програмата.
	''' </summary>
	Partial Class MyApplication
		''' <summary>
		''' Входна точка. Създава и показва главната форма на програмата.
		''' </summary>
		Public Sub New()
			MyBase.New(AuthenticationMode.Windows)
			Me.IsSingleInstance = False
			Me.EnableVisualStyles = True
			Me.SaveMySettingsOnExit = False ' MySettings are not supported in SharpDevelop.
			Me.ShutDownStyle = ShutdownMode.AfterMainFormCloses
		End Sub
		
		Protected Overrides Sub OnCreateMainForm()
			Me.MainForm = My.Forms.MainForm
		End Sub
	End Class
End Namespace
