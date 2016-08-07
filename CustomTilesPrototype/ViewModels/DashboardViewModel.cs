using CustomTilesPrototype.Controls;
using GalaSoft.MvvmLight;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Controls;

namespace CustomTilesPrototype.ViewModels
{
    /// <summary>
    /// This class contains properties that a View can data bind to.
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class DashboardViewModel : ViewModelBase, INotifyPropertyChanged
    {
        #region Members

        private ObservableCollection<GenericTile> _tiles;

        public ObservableCollection<GenericTile> Tiles
        {
            get { return _tiles; }
            set
            {
                _tiles = value;
                NotifyPropertyChanged("Tiles");
            }
        }

        private Orientation _dashboardOrientation;

        public Orientation DashboardOrientation
        {
            get { return _dashboardOrientation; }
            set
            {
                _dashboardOrientation = value;
                NotifyPropertyChanged("DashboardOrientation");
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

        /// <summary>
        /// Initializes a new instance of the DashboardViewModel class.
        /// </summary>
        public DashboardViewModel()
        {
            Tiles = new ObservableCollection<GenericTile>();
            Tiles.Add(new GenericTile());
            Tiles.Add(new GenericTile());
            DashboardOrientation = Orientation.Horizontal;
        }

        #endregion

        #region Events



        #endregion
    }
}