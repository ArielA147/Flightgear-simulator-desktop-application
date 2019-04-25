using FlightSimulator.Model;
using FlightSimulator.ViewModels;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace FlightSimulator
{
    class LeftVm : BaseNotify
    {
        
        private SettingsAndConnectionModel model;
        private Settings settings = null;
        public LeftVm()
        {
            settings = new Settings();
            model = new SettingsAndConnectionModel();
        }

        private ICommand _settingsCommand;
        //click command return command that send textbox command.
        public ICommand SettingsCommand
        {
            get
            {
                return _settingsCommand ?? (_settingsCommand = new CommandHandler(() => OnClick()));
            }
        }
        private void OnClick()
        {
            if (!settings.IsLoaded)
            {
                settings = new Settings();
                settings.Show();
            }
            else { settings.Show(); }
        }

        private ICommand _connactCommand;
        //click command return command that send textbox command.
        public ICommand ConnactCommand
        {
            get
            {
                return _connactCommand ?? (_connactCommand = new CommandHandler(() => ConnactClick()));
            }
        }
        private void ConnactClick()
        {
            model.ConnectCommand();
            model.OpenServer();

        }

        private void DisconnactClick()
        {
            model.CloseConnection();
        }

        private ICommand _disconnectCommand;
        public ICommand DisconnectCommand
        {
            get
            {
                return _disconnectCommand ?? (_disconnectCommand = new CommandHandler(() => DisconnactClick()));
            }

        }

    }
}
