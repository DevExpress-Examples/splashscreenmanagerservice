using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;
using System;
using System.Threading;

namespace SplashScreenService.ViewModel {
    [POCOViewModel]
    public class MainViewModel {
        public virtual int Delay { get; set; }

        protected ISplashScreenManagerService SplashScreenManagerService { get { return this.GetService<ISplashScreenManagerService>();} }

        public MainViewModel() {
            Delay = 5;
        }

        public void Display() {
            SplashScreenManagerService.ViewModel.Subtitle = "Powered by DevExpress";
            SplashScreenManagerService.ViewModel.Logo = new Uri("../../Images/Logo.png", UriKind.Relative);
            SplashScreenManagerService.Show();
            Thread.Sleep(TimeSpan.FromSeconds(Delay));
            SplashScreenManagerService.Close();
        }
    }
}
