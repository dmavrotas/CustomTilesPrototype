using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace CustomTilesPrototype.Models
{
    public class Tile : INotifyPropertyChanged
    {
        #region Members

        private short _id;

        public short ID
        {
            get { return _id; }
            set
            {
                _id = value;
                NotifyPropertyChanged("ID");
            }
        }

        private string _tileTitle;

        public string TileTitle
        {
            get { return _tileTitle; }
            set
            {
                _tileTitle = value;
                NotifyPropertyChanged("TileTitle");
            }
        }

        private ImageSource _tileImage;

        public ImageSource TileImage
        {
            get { return _tileImage; }
            set
            {
                _tileImage = value;
                NotifyPropertyChanged("TileImage");
            }
        }

        private string _tileData1;

        public string TileData1
        {
            get { return _tileData1; }
            set
            {
                _tileData1 = value;
                NotifyPropertyChanged("TileData1");
            }
        }

        private string _tileData2;

        public string TileData2
        {
            get { return _tileData2; }
            set
            {
                _tileData2 = value;
                NotifyPropertyChanged("TileData2");
            }
        }

        private Brush _backgroundColor;

        public Brush BackgroundColor
        {
            get { return _backgroundColor; }
            set
            {
                _backgroundColor = value;
                NotifyPropertyChanged("BackgroundColor");
            }
        }

        #endregion

        #region INotifyPropertyChanged Members

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged(string info)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(info));
        }

        #endregion

        #region Constructors

        public Tile(short id, string title, ImageSource image, string data1, string data2, Brush color)
        {
            ID = id;
            TileTitle = title;
            TileImage = image;
            TileData1 = data1;
            TileData2 = data2;
            BackgroundColor = color;
        }

        #endregion
    }
}
