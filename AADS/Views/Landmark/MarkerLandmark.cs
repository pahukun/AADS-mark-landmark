using GMap.NET;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AADS.Views.Landmark
{
    public class MarkerLandmark
    {
        public Bitmap icon;
        private int id;
        private PointLatLng location;
        private string name;
        private string label;
        
        public int ID
        {
            get { return id; }
            set { id = value; }
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
    }
    
}
