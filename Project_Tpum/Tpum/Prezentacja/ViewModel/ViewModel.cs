using Prezentacja.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Threading;

namespace Prezentacja.ViewModel
{
	public class ViewModel:INotifyPropertyChanged
    {
        TemperaturaModel roomservice = new TemperaturaModel();
        public ICommand SubmitButtonCommand { get; set; }
        public DispatcherTimer _timer;
       
        private double actual;
        public double Actual
		{
            get => actual;
            set
            {
                actual = value;
                OnPropertyChanged("Actual");
            }
        }

        private string selectedRoom = "";
        public string SelectedRoom
        {
            get { return selectedRoom; }
            set
            {
                selectedRoom = value;
                roomservice.setGoalTemp(SelectedRoom, 0);
                OnPropertyChanged();
            }
        }

        private double goalTemp;
        public double GoalTemp
        {
            get
            {
                return goalTemp;
            }
            set
            {
                goalTemp = value;
                CheckAndEnableButton();
                OnPropertyChanged();
            }
        }

        public ViewModel()
        {
            _timer = new DispatcherTimer(DispatcherPriority.Render);
			_timer.Interval = TimeSpan.FromSeconds(1);
			_timer.Tick += (sender, args) =>
			{
                Actual = roomservice.getActualTemp();
            };
			_timer.Start();
		}


        public void CheckAndEnableButton()
        {
            string result = string.Empty;

            if (GoalTemp >= 17 && GoalTemp <= 28)
                {
                    result = string.Format("Goal temperature is set: \n{0}", GoalTemp);
                    SubmitButtonCommand = new RelayCommand((ob) => { return true; }, (ob) => {
                        MessageBox.Show(result);
                        roomservice.setGoalTemp(SelectedRoom, GoalTemp);
                    });
                }
                else if (GoalTemp > 28)
                {
                    result = result = string.Format("Goal temperature \n{0} is too high. Enter lower temperature", GoalTemp);
                    SubmitButtonCommand = new RelayCommand((ob) => { return true; }, (ob) => {
                        MessageBox.Show(result);
                    });
                }
                else
                {
                    result = result = string.Format("Goal temperature \n{0} is too low. Enter higher temperature", GoalTemp);
                    SubmitButtonCommand = new RelayCommand((ob) => { return true; }, (ob) => {
                        MessageBox.Show(result);
                    });
                }
            

            OnPropertyChanged("SubmitButtonCommand");

        }
        public event PropertyChangedEventHandler PropertyChanged;
        public void  OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }


    }
}
