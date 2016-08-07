using CustomTilesPrototype.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CustomTilesPrototype.Controls
{
    /// <summary>
    /// Interaction logic for DashboardControl.xaml
    /// </summary>
    public partial class DashboardControl : UserControl, INotifyPropertyChanged
    {
        #region Members

        private DashboardViewModel _viewModel;

        public DashboardViewModel ViewModel
        {
            get { return _viewModel; }
            set
            {
                _viewModel = value;
                NotifyPropertyChanged("ViewModel");
            }
        }

        #endregion

        #region INotifyPropertyChanged Members

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged(string info)
        {
            if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs(info));
        }

        #endregion

        #region Constructors

        public DashboardControl()
        {
            InitializeComponent();
            InitializeProperties();
            DataContext = ViewModel;
        }

        #endregion

        #region Methods

        private void InitializeProperties()
        {
            ViewModel = new DashboardViewModel();
            //TileClicked = new RelayCommand<short>(PerformClick);
        }

        #endregion
    }
}
