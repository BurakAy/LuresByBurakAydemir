//Burak Aydemir

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace burakAydemirFinalProject
{
    class Lure
    {
        private string _LureID;
        private string _LureManufacturer;
        private string _LureName;
        private string _LureType;
        private string _LureLength;
        private string _LureWeight;
        private string _LureColor;
        private string _LurePrice;
        private string _LureDescription;
        private string _PictureName;

        public Lure() 
        {

        }


        public Lure(string ID, string manufacturer, string name, string type, string length, string weight, string color, string price, string description, string picture)
        {
            _LureID = ID;
            _LureManufacturer = manufacturer;
            _LureName = name;
            _LureType = type;
            _LureLength = length;
            _LureWeight = weight;
            _LureColor = color;
            _LurePrice = price;
            _LureDescription = description;
            _PictureName = picture;
        }


        public string LureID
        {
            get { return _LureID; }
            set { _LureID = value; }
        }
        

        public string LureManufacturer
        {
            get { return _LureManufacturer; }
            set { _LureManufacturer = value; }
        }
        

        public string LureName
        {
            get { return _LureName; }
            set { _LureName = value; }
        }
        

        public string LureType
        {
            get { return _LureType; }
            set { _LureType = value; }
        }
        

        public string LureLength
        {
            get { return _LureLength; }
            set { _LureLength = value; }
        }
        

        public string LureWeight
        {
            get { return _LureWeight; }
            set { _LureWeight = value; }
        }
        

        public string LureColor
        {
            get { return _LureColor; }
            set { _LureColor = value; }
        }


        public string LurePrice
        {
            get { return _LurePrice; }
            set { _LurePrice = value; }
        }
        

        public string LureDescription
        {
            get { return _LureDescription; }
            set { _LureDescription = value; }
        }


        public string PictureName
        {
            get { return _PictureName; }
            set { _PictureName = value; }
        }

    }
}
