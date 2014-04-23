using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WPFXCommand;

namespace WpfXTestApp
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        #region Properties
        private string description = "Place Pointer Here";
        public string Description
        {
            get
            {
                return description;
            }
            set
            {
                description = value;
                OnPropertyChanged("Description");
            }
        }

        private string gridDescription;
        public string GridDescription
        {
            get
            {
                return gridDescription;
            }
            set
            {
                gridDescription = value;
                OnPropertyChanged("GridDescription");
            }
        }

        private string bgColor = "#FF000C22";
        public string BgColor
        {
            get
            {
                return bgColor;
            }
            set
            {
                bgColor = value;
                OnPropertyChanged("BgColor");
            }
        }

        private string fgColor = "White";
        public string FgColor
        {
            get
            {
                return fgColor;
            }
            set
            {
                fgColor = value;
                OnPropertyChanged("FgColor");
            }
        }
        #endregion

        #region Commands
        #region GridPointerMovedCommand
        ICommand gridPointerMovedCommand;
        public ICommand GridPointerMovedCommand
        {
            get
            {
                if (gridPointerMovedCommand == null)
                {
                    gridPointerMovedCommand = new RelayCommand(GridPointerMovedCommandExecute, CanGridPointerMovedCommandExecute);
                }
                return gridPointerMovedCommand;
            }
        }

        private bool CanGridPointerMovedCommandExecute(object param)
        {
            return true;
        }
        private void GridPointerMovedCommandExecute(object param)
        {
            Description = "Grid Pointer Moving";
            BgColor = "#FFFFFFFF";
            GridDescription = param as string;
        }
        #endregion

        #region GridPointerPressedCommand
        ICommand gridPointerPressedCommand;
        public ICommand GridPointerPressedCommand
        {
            get
            {
                if (gridPointerPressedCommand == null)
                {
                    gridPointerPressedCommand = new RelayCommand(GridPointerPressedCommandExecute, CanGridPointerPressedCommandExecute);
                }
                return gridPointerPressedCommand;
            }
        }

        private bool CanGridPointerPressedCommandExecute(object param)
        {
            return true;
        }
        private void GridPointerPressedCommandExecute(object param)
        {
            Description = "Grid Pointer Pressed";
            BgColor = "#FFFF3333";
            GridDescription = param as string;
        }
        #endregion

        #region GridPointerReleasedCommand
        ICommand gridPointerReleasedCommand;
        public ICommand GridPointerReleasedCommand
        {
            get
            {
                if (gridPointerReleasedCommand == null)
                {
                    gridPointerReleasedCommand = new RelayCommand(GridPointerReleasedCommandExecute, CanGridPointerReleasedCommandExecute);
                }
                return gridPointerReleasedCommand;
            }
        }

        private bool CanGridPointerReleasedCommandExecute(object param)
        {
            return true;
        }
        private void GridPointerReleasedCommandExecute(object param)
        {
            Description = "Grid Pointer Released";
            BgColor = "#FFFF0000";
            GridDescription = param as string;
        }
        #endregion

        #region GridPointerExitedCommand
        ICommand gridPointerExitedCommand;
        public ICommand GridPointerExitedCommand
        {
            get
            {
                if (gridPointerExitedCommand == null)
                {
                    gridPointerExitedCommand = new RelayCommand(GridPointerExitedCommandExecute, CanGridPointerExitedCommandExecute);
                }
                return gridPointerExitedCommand;
            }
        }

        private bool CanGridPointerExitedCommandExecute(object param)
        {
            return true;
        }
        private void GridPointerExitedCommandExecute(object param)
        {
            Description = "Place Pointer Here";
            BgColor = "#FF000C22";
            GridDescription = param as string;
        }
        #endregion

        #region TextBlockPointerMovedCommand
        ICommand textBlockPointerMovedCommand;
        public ICommand TextBlockPointerMovedCommand
        {
            get
            {
                if (textBlockPointerMovedCommand == null)
                {
                    textBlockPointerMovedCommand = new RelayCommand(TextBlockPointerMovedCommandExecute, CanTextBlockPointerMovedCommandExecute);
                }
                return textBlockPointerMovedCommand;
            }
        }

        private bool CanTextBlockPointerMovedCommandExecute(object param)
        {
            return true;
        }
        private void TextBlockPointerMovedCommandExecute(object param)
        {
            FgColor = "Orange";
            Description = "Click Pointer Here";
        }
        #endregion

        #region TextBlockPointerPressedCommand
        ICommand textBlockPointerPressedCommand;
        public ICommand TextBlockPointerPressedCommand
        {
            get
            {
                if (textBlockPointerPressedCommand == null)
                {
                    textBlockPointerPressedCommand = new RelayCommand(TextBlockPointerPressedCommandExecute, CanTextBlockPointerPressedCommandExecute);
                }
                return textBlockPointerPressedCommand;
            }
        }

        private bool CanTextBlockPointerPressedCommandExecute(object param)
        {
            return true;
        }
        private void TextBlockPointerPressedCommandExecute(object param)
        {
            FgColor = "Green";
        }
        #endregion

        #region TextBlockPointerExitedCommand
        ICommand textBlockPointerExitedCommand;
        public ICommand TextBlockPointerExitedCommand
        {
            get
            {
                if (textBlockPointerExitedCommand == null)
                {
                    textBlockPointerExitedCommand = new RelayCommand(TextBlockPointerExitedCommandExecute, CanTextBlockPointerExitedCommandExecute);
                }
                return textBlockPointerExitedCommand;
            }
        }

        private bool CanTextBlockPointerExitedCommandExecute(object param)
        {
            return true;
        }
        private void TextBlockPointerExitedCommandExecute(object param)
        {
            FgColor = "White";
            Description = "Place Pointer Here";
        }
        #endregion
        #endregion


        #region INotifyPropertyChanged section
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string name)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(name));
            }
        }
        #endregion
    }
}
