using GMap.NET;
using GMap.NET.WindowsForms;
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

        MarkerLandmark markerLandmark = new MarkerLandmark();
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
            var marker = new GmapMarkerWithLabel(PositionConverter.ParsePointFromString(txtLocationLandmark.Text), txtLabelLandmark.Text.ToString(), markerLandmark.icon, 20);
            GMapOverlay overlay = mainForm.GetInstance().GetOverlay("markersP");
            overlay.Markers.Add(marker);
            mainForm.GetInstance().GetmainMap().Overlays.Add(overlay);
           
            txtLabelLandmark.Text = "Short Name";
            txtLabelLandmark.ForeColor = Color.Gray;

            txtNameLandmark.Text = "Landmark Name";
            txtNameLandmark.ForeColor = Color.Gray;

            cmbTypeLandmark.Text = "Please Select Type of Landmark";
            cmbTypeLandmark.ForeColor = Color.Gray;
        }


        private void main_Load(object sender, EventArgs e)
        {

        }

    }
}
