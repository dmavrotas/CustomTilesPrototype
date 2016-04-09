using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
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
    /// Interaction logic for GenericTile.xaml
    /// </summary>

    public partial class GenericTile : UserControl, INotifyPropertyChanged
    {
        #region Members

        private RelayCommand<short> _tileClicked;

        public RelayCommand<short> TileClicked
        {
            get { return _tileClicked; }
            set
            {
                _tileClicked = value;
                NotifyPropertyChanged("TileClicked");
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

        public GenericTile()
        {
            InitializeComponent();
            InitializeProperties();
        }

        #endregion

        #region Functions

        private void InitializeProperties()
        {
            TileClicked = new RelayCommand<short>(PerformClick);
        }

        #endregion

        #region Events

        private void PerformClick(short id)
        {
            //TO DO: Click Logic
        }

        #endregion
    }
}
