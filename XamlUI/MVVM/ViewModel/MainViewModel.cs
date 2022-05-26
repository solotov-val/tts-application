using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XamlUI.Core;

namespace XamlUI.MVVM.ViewModel
{
    internal class MainViewModel : ObservableObject
    {
        #region Variables
        private object _currentView;
        private object _currentTTSView;
        #endregion

        #region Getter-Setter
        public RelayCommand LoginViewCommand { get; set; }
        public RelayCommand RegisterViewCommand { get; set; }
        public RelayCommand DeleteViewCommand { get; set; }
        public RelayCommand TextViewCommand { get; set; }
        public RelayCommand FileViewCommand { get; set; }
        public RelayCommand TranslateViewCommand { get; set; }
        public RelayCommand AboutViewCommand { get; set; }
        public RelayCommand HelpViewCommand { get; set; }


        public LoginViewModel LoginVm { get; set; }
        public RegisterViewModel RegisterVm { get; set; }
        public DeleteViewModel DeleteVm { get; set; }
        public TextViewModel TextVm { get; set; }
        public FileViewModel FileVm { get; set; }
        public TrTextViewModel TrTextVm { get; set; }
        public TrFileViewModel TrFileVm { get; set; }
        public AboutViewModel AboutVm { get; set; }
        public HelpViewModel HelpVm { get; set; }
        #endregion

        #region Public Methods
        public object CurrentView
        {
            get { return _currentView; }
            set
            {
                _currentView = value;
                OnPropertyChanged();
            }
        }
        public object CurrentTTSView
        {
            get { return _currentTTSView; }
            set
            {
                _currentTTSView = value;
                OnPropertyChanged();
            }
        }
        #endregion

        public MainViewModel()
        {
            LoginVm = new LoginViewModel();
            RegisterVm = new RegisterViewModel();
            DeleteVm = new DeleteViewModel();
            TextVm = new TextViewModel();
            FileVm = new FileViewModel();
            TrTextVm = new TrTextViewModel();
            TrFileVm = new TrFileViewModel();
            AboutVm = new AboutViewModel();
            HelpVm = new HelpViewModel();


            CurrentView = LoginVm;
            CurrentTTSView = TextVm;

            // On Button Click Commands
            //for Login UI
            LoginViewCommand = new RelayCommand(o =>
            {
                CurrentView = LoginVm;
            });
            DeleteViewCommand = new RelayCommand(o =>
            {
                CurrentView = DeleteVm;
            });
            RegisterViewCommand = new RelayCommand(o =>
            {
                CurrentView = RegisterVm;
            });

            //for TTS
            TextViewCommand = new RelayCommand(o =>
            {
                CurrentTTSView = TextVm;
            });
            FileViewCommand = new RelayCommand(o =>
            {
                CurrentTTSView = FileVm;
            });
            TranslateViewCommand = new RelayCommand(o =>
            {
                if (CurrentTTSView == TextVm)
                {
                    CurrentTTSView = TrTextVm;
                }
                else if (CurrentTTSView == FileVm)
                {
                    CurrentTTSView = TrFileVm;
                }
            });
            AboutViewCommand = new RelayCommand(o =>
            {
                CurrentTTSView = AboutVm;
            });
            HelpViewCommand = new RelayCommand(o =>
            {
                CurrentTTSView = HelpVm;
            });
        }
    }
}
