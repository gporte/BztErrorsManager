using System;
using System.Threading;
using System.Windows;
using System.Windows.Markup;

namespace BztErrorsManager.Client
{
	/// <summary>
	/// Logique d'interaction pour MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow() {
			try {
				InitializeComponent();
				this.Language = XmlLanguage.GetLanguage(Thread.CurrentThread.CurrentCulture.Name);
				this.DataContext = new MainViewModel();
			}
			catch (Exception ex) {
				MessageBox.Show(ex.Message);
				throw;
			}
		}
	}
}
