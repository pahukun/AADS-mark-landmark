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
        public Bitmap iconLandmark = (Bitmap)Image.FromFile("Resources/AADS-icons/Landmark.svg");
        public int idLandmark;
        public float locationLandmark;
        public string nameLandmark;
        public string labelLandmark;
    }
}
