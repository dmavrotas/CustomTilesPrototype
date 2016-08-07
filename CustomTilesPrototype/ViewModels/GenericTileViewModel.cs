using CustomTilesPrototype.Models;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace CustomTilesPrototype.ViewModels
{
    /// <summary>
    /// This class contains properties that a View can data bind to.
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class GenericTileViewModel : ViewModelBase, INotifyPropertyChanged
    {
        /// <summary>
        /// Initializes a new instance of the GenericTileViewModel class.
        /// </summary>

        #region Members

        private Tile _tile;

        public Tile Tile
        {
            get { return _tile; }
            set
            {
                _tile = value;
                NotifyPropertyChanged("Tile");
            }
        }

        private RelayCommand _tileClicked;

        public RelayCommand TileClicked
        {
            get { return _tileClicked; }
            set
            {
                _tileClicked = new RelayCommand(ClickTile);
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

        public GenericTileViewModel()
        {
            TileClicked = new RelayCommand(ClickTile);
            Tile = new Tile(1, "A nice tile", new BitmapImage(new Uri(@"\Assets\test.png", UriKind.Relative)), "some data", "some more data", new SolidColorBrush(Colors.Orange));
        }

        #endregion

        #region Events

        private void ClickTile()
        {

        }

        #endregion
    }
}