using FlightSimulator.Model;
using FlightSimulator.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace FlightSimulator
{
    class AutoPilotVM : BaseNotify
    {
        private AutoPilotModel model;
        private bool sentCommands = false;
        public AutoPilotVM()
        {
            TextBox = "";
            model = new AutoPilotModel();
        }
        /// <summary>
        /// color property, define background of the textbox. 
        /// </summary>
        public string color;
        public string Color
        {
            get
            {
                // in case the textbox empty or data is changed, set color to white.
                if (textBox == "" || sentCommands)
                    color = "White";
                else
                {
                    color = "LightPink";
                }
                return color;
            }
        }
        private string textBox;

        public string TextBox
        {
            get { return textBox; }
            set
            {
                // notify to view whanever there is a change in textbox content.
                sentCommands = false;
                textBox = value;
                NotifyPropertyChanged("Color");
                NotifyPropertyChanged("TextBox");
            }
        }
        private ICommand _clickCommand;
        //click command return command that send textbox command.
        public ICommand ClickCommand
        {
            get
            {
                return _clickCommand ?? (_clickCommand = new CommandHandler(() => OnClick()));
            }
        }
        private void OnClick()
        {
            // in case Textbox isnt empty, send the commands to server.
            if (TextBox != "")
                model.SendCommands(textBox);
            sentCommands = true;
            NotifyPropertyChanged("Color");
        }
        private ICommand _clearCommand;
        //Clear command return command that reolad Settings of the model.
        public ICommand ClearCommand
        {
            get
            {
                return _clearCommand ?? (_clearCommand = new CommandHandler(() => OnClear()));
            }
        }
        
        // clear the conent of the textbox.
        private void OnClear()
        {
            TextBox = "";
            NotifyPropertyChanged("Color");
            NotifyPropertyChanged("TextBox");
        }
    }
}

