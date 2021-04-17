using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using WpfTest.Models;

namespace WpfTest.ViewModels
{
	class MainViewModel : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;

		public void OnPropertyChanged([CallerMemberName] string prop = "")
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));

		}
		
		private double _Clicks;

		public double Clicks 
		{
			get {
				return _Clicks; 
			}
			set
			{
				_Clicks = value;
				OnPropertyChanged();

			}
		}
		public MainViewModel()
		{
			Task.Factory.StartNew(() =>
			{
				Temperatura temp = new Temperatura_aktualna();
				while (true)
				{
					Double temperatura = temp.StworzTemperature();
					Clicks = temperatura;
					Task.Delay(3000).Wait();

				}
			});
		}

	}

}
