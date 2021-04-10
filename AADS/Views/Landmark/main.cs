using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using Net_GmapMarkerWithLabel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AADS.Views.Landmark
{
    public partial class main : UserControl
    {
        public main()
        {
            InitializeComponent();
        }
        Dictionary<GMapMarker, MarkerLandmarkDetail> dicMarker = new Dictionary<GMapMarker, MarkerLandmarkDetail>();
        GMapMarker getMarker = null;

        //Location Landmark//
        public void setPosition(PointLatLng p)
        {
            txtLocationLandmark.ForeColor = Color.Black;
            txtLocationLandmark.Text = PositionConverter.ParsePointToString(p, "Signed Degree");
        }
        private void txtLocationLandmark_Enter(object sender, EventArgs e)
        {
            if (txtLocationLandmark.Text == "Select Location on Map")
            {
                txtLocationLandmark.Text = null;
            }
            txtLocationLandmark.ForeColor = Color.Black;
        }

        private void txtLocationLandmark_Leave(object sender, EventArgs e)
        {
            if (txtLocationLandmark.Text == "")
            {
                txtLocationLandmark.Text = "Select Location on Map";
                txtLocationLandmark.ForeColor = Color.Gray;
            }
            else
            {
                txtLocationLandmark.ForeColor = Color.Black;
            }
        }


        //Type Landmark//

        MarkerLandmarkDetail markerLandmark = new MarkerLandmarkDetail();
        private void cmbTypeLandmark_DropDown(object sender, EventArgs e)
        {
            cmbTypeLandmark.ForeColor = Color.Black;
        }
        private void cmbTypeLandmark_Leave(object sender, EventArgs e)
        {
            if (cmbTypeLandmark.Text == "")
            {
                cmbTypeLandmark.Text = "Please Select Type of Landmark";
                cmbTypeLandmark.ForeColor = Color.Gray;
            }
            else if (cmbTypeLandmark.Text == "Please Select Type of Landmark")
            {
                cmbTypeLandmark.ForeColor = Color.Gray;
            }
            else
            {
                cmbTypeLandmark.ForeColor = Color.Black;
            }
        }
        private void cmbTypeLandmark_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTypeLandmark.SelectedIndex == 0)
            {
                markerLandmark.icon = (Bitmap)Image.FromFile("AADS-icons/icon/Landmark.png");   
            }
            else if (cmbTypeLandmark.SelectedIndex == 1)
            {
                markerLandmark.icon = (Bitmap)Image.FromFile("AADS-icons/Landmark/014-hospital.png");
            }
            else if (cmbTypeLandmark.SelectedIndex == 2)
            {
                markerLandmark.icon = (Bitmap)Image.FromFile("AADS-icons/Landmark/026-police station.png");
            }
            else if (cmbTypeLandmark.SelectedIndex == 3)
            {
                markerLandmark.icon = (Bitmap)Image.FromFile("AADS-icons/Landmark/040-royal palace.png");
            }
            else if (cmbTypeLandmark.SelectedIndex == 4)
            {
                markerLandmark.icon = (Bitmap)Image.FromFile("AADS-icons/Landmark/011-education.png");
            }
            else if (cmbTypeLandmark.SelectedIndex == 5)
            {
                markerLandmark.icon = (Bitmap)Image.FromFile("AADS-icons/Landmark/039-temple.png");
            }
        }

        //Name Landmark//
        private void txtNameLandmark_Enter(object sender, EventArgs e)
        {
            if (txtNameLandmark.Text == "Landmark Name")
            {
                txtNameLandmark.Text = null;
            }
            txtNameLandmark.ForeColor = Color.Black;
        }

        private void txtNameLandmark_Leave(object sender, EventArgs e)
        {
            if (txtNameLandmark.Text == "")
            {
                txtNameLandmark.Text = "Landmark Name";
                txtNameLandmark.ForeColor = Color.Gray;
            }

            else
            {
                txtNameLandmark.ForeColor = Color.Black;
            }
        }

        //Label Landmark//
        private void txtLabelLandmark_Enter(object sender, EventArgs e)
        {
            if (txtLabelLandmark.Text == "Short Name")
            {
                txtLabelLandmark.Text = null;
            }
            txtLabelLandmark.ForeColor = Color.Black;
        }

        private void txtLabelLandmark_Leave(object sender, EventArgs e)
        {
            if (txtLabelLandmark.Text == "")
            {
                txtLabelLandmark.Text = "Short Name";
                txtLabelLandmark.ForeColor = Color.Gray;
            }

            else
            {
                txtLabelLandmark.ForeColor = Color.Black;
            }
        }

        //Button//
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtLocationLandmark.Text == "Select Location on Map")
            {
                MessageBox.Show("Please Select Location on Map", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cmbTypeLandmark.Text == "Please Select Type of Landmark")
            {
                MessageBox.Show("Please Select Type of Landmark", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (txtLabelLandmark.Text == "Short Name")
            {
                txtLabelLandmark.Text = "";
            }
            var marker = new GmapMarkerWithLabel(PositionConverter.ParsePointFromString(txtLocationLandmark.Text), null, markerLandmark.icon, 20);
            GMapOverlay overlay = mainForm.GetInstance().GetOverlay("markersP");
            MarkerLandmarkDetail detail = new MarkerLandmarkDetail(marker, cmbTypeLandmark.SelectedIndex, PositionConverter.ParsePointFromString(txtLocationLandmark.Text), txtNameLandmark.Text, txtLabelLandmark.Text);
            dicMarker.Add(marker, detail);
            marker.ToolTipText = "\n" + detail.Location.Lat.ToString() + " / " + detail.Location.Lng.ToString() + "\n" + detail.Label;
            marker.ToolTipMode = MarkerTooltipMode.OnMouseOver; 
            overlay.Markers.Add(marker);
            mainForm.GetInstance().GetmainMap().Overlays.Add(overlay);
           
            txtLabelLandmark.Text = "Short Name";
            txtLabelLandmark.ForeColor = Color.Gray;

            txtNameLandmark.Text = "Landmark Name";
            txtNameLandmark.ForeColor = Color.Gray;

            cmbTypeLandmark.Text = "Please Select Type of Landmark";
            cmbTypeLandmark.ForeColor = Color.Gray;
        }

        public void set_Detail(GMapMarker marker)
        {
            this.getMarker = marker;
            if (dicMarker.ContainsKey(marker))
            {
                txtLocationLandmark.Text = PositionConverter.ParsePointToString(dicMarker[marker].Location, "Signed Degree");
                cmbTypeLandmark.SelectedIndex = dicMarker[marker].Type; //ค่าไม่ยอมเปลี่ยนแบบเรียลไทม์ อย่าลืมแก้
                Console.WriteLine(dicMarker[marker].Type);
                txtNameLandmark.Text = dicMarker[marker].Name;
                txtLabelLandmark.Text = dicMarker[marker].Label;

                cmbTypeLandmark.ForeColor = Color.Black;
                txtNameLandmark.ForeColor = Color.Black;
                txtLabelLandmark.ForeColor = Color.Black;
            }
        }
        private void main_Load(object sender, EventArgs e)
        {

        }

    }
}
