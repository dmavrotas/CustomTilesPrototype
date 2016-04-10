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
            Tile = new Tile(1, "A nice tile", null, "some data", "some more data");
        }

        #endregion

        #region Events



        #endregion
    }
}