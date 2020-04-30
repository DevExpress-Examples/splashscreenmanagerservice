Imports DevExpress.Mvvm
Imports DevExpress.Mvvm.DataAnnotations
Imports DevExpress.Mvvm.POCO
Imports System
Imports System.Threading

Namespace SplashScreenService.ViewModel
	<POCOViewModel>
	Public Class MainViewModel
		Public Overridable Property Delay() As Integer

		Protected ReadOnly Property SplashScreenManagerService() As ISplashScreenManagerService
			Get
				Return Me.GetService(Of ISplashScreenManagerService)()
			End Get
		End Property

		Public Sub New()
			Delay = 5
		End Sub

		Public Sub Display()
			SplashScreenManagerService.ViewModel = New DXSplashScreenViewModel()
			SplashScreenManagerService.ViewModel.Subtitle = "Powered by DevExpress"
			SplashScreenManagerService.ViewModel.Logo = New Uri("../../Images/Logo.png", UriKind.Relative)
			SplashScreenManagerService.Show()
			Thread.Sleep(TimeSpan.FromSeconds(Delay))
			SplashScreenManagerService.Close()
		End Sub
	End Class
End Namespace
