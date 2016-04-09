using CustomTilesPrototype.Models;
using GalaSoft.MvvmLight;
using System.Collections.Generic;
using System.ComponentModel;

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

        private IList<Tile> _tiles;

        public IList<Tile> Tiles
        {
            get { return _tiles; }
            set
            {
                _tiles = value;
                NotifyPropertyChanged("Tiles");
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

        }

        #endregion

        #region Events



        #endregion
    }
}