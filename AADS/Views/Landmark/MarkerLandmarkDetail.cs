using GMap.NET;
using GMap.NET.WindowsForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AADS.Views.Landmark
{
    public class MarkerLandmarkDetail
    {
        public Bitmap icon;
        private GMapMarker marker;
        private int type;
        private PointLatLng location;
        private string name;
        private string label;
        
        public GMapMarker Marker
        {
            get { return marker; }
            set { marker = value; }
        }
        public int Type
        {
            get { return type; }
            set { type = value; }
        }
        public PointLatLng Location
        {
            get { return location; }
            set { location = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Label
        {
            get { return label; }
            set { label = value; }
        }
        public MarkerLandmarkDetail()
        {

        }
        public MarkerLandmarkDetail(GMapMarker marker, int type, PointLatLng location, string name, string label)
        {
            this.Marker = marker;
            this.Type = type;
            this.Location = location;
            this.Name = name;
            this.Label = label;
        }
    }
    
}
