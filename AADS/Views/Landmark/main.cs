using GMap.NET;
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

            }
            else
            {

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
            if (string.IsNullOrEmpty(txtLabelLandmark.Text))
            {

            }
        }


        private void main_Load(object sender, EventArgs e)
        {

        }

    }
}
