using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace Explorer.Shared.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        #region Public Properties
        public string FilePath { get; set; }

        public ObservableCollection<FileEntityViewModel> DirectoriesAndFiles { get; set; } = new ObservableCollection<FileEntityViewModel>();

        #endregion

        #region Commands

        public ICommand OpenCommand { get; }

        #endregion

        #region Constructor

        public MainViewModel()
        {
            OpenCommand = new DelegateCommand(Open);

            foreach (var LogicalDrive in Directory.GetLogicalDrives())
            {
                DirectoriesAndFiles.Add(new DirectoryViewModel(LogicalDrive));
            }
        }

        #endregion

        #region Commands Methods

        private void Open(object parameter)
        { 
        
        }

        #endregion

    }
}