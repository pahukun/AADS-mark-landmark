
namespace AADS.Views.Landmark
{
    partial class main
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLocationLandmark = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNameLandmark = new System.Windows.Forms.TextBox();
            this.txtLabelLandmark = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbTypeLandmark = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(290, 45);
            this.panel1.TabIndex = 55;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Landmark";
            // 
            // txtLocationLandmark
            // 
            this.txtLocationLandmark.ForeColor = System.Drawing.Color.Gray;
            this.txtLocationLandmark.Location = new System.Drawing.Point(83, 79);
            this.txtLocationLandmark.Name = "txtLocationLandmark";
            this.txtLocationLandmark.Size = new System.Drawing.Size(134, 20);
            this.txtLocationLandmark.TabIndex = 56;
            this.txtLocationLandmark.Text = "Select Location on Map";
            this.txtLocationLandmark.Enter += new System.EventHandler(this.txtLocationLandmark_Enter);
            this.txtLocationLandmark.Leave += new System.EventHandler(this.txtLocationLandmark_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 57;
            this.label2.Text = "Location :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 58;
            this.label3.Text = "Type :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 59;
            this.label4.Text = "Name :";
            // 
            // txtNameLandmark
            // 
            this.txtNameLandmark.ForeColor = System.Drawing.Color.Gray;
            this.txtNameLandmark.Location = new System.Drawing.Point(83, 159);
            this.txtNameLandmark.Name = "txtNameLandmark";
            this.txtNameLandmark.Size = new System.Drawing.Size(180, 20);
            this.txtNameLandmark.TabIndex = 60;
            this.txtNameLandmark.Text = "Landmark Name";
            this.txtNameLandmark.Enter += new System.EventHandler(this.txtNameLandmark_Enter);
            this.txtNameLandmark.Leave += new System.EventHandler(this.txtNameLandmark_Leave);
            // 
            // txtLabelLandmark
            // 
            this.txtLabelLandmark.ForeColor = System.Drawing.Color.Gray;
            this.txtLabelLandmark.Location = new System.Drawing.Point(83, 198);
            this.txtLabelLandmark.Name = "txtLabelLandmark";
            this.txtLabelLandmark.Size = new System.Drawing.Size(72, 20);
            this.txtLabelLandmark.TabIndex = 62;
            this.txtLabelLandmark.Text = "Short Name";
            this.txtLabelLandmark.Enter += new System.EventHandler(this.txtLabelLandmark_Enter);
            this.txtLabelLandmark.Leave += new System.EventHandler(this.txtLabelLandmark_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 61;
            this.label5.Text = "Label :";
            // 
            // cmbTypeLandmark
            // 
            this.cmbTypeLandmark.ForeColor = System.Drawing.Color.Gray;
            this.cmbTypeLandmark.FormattingEnabled = true;
            this.cmbTypeLandmark.Items.AddRange(new object[] {
            "testMarker",
            "test2"});
            this.cmbTypeLandmark.Location = new System.Drawing.Point(83, 121);
            this.cmbTypeLandmark.Name = "cmbTypeLandmark";
            this.cmbTypeLandmark.Size = new System.Drawing.Size(180, 21);
            this.cmbTypeLandmark.TabIndex = 63;
            this.cmbTypeLandmark.Text = "Please Select Type of Landmark";
            this.cmbTypeLandmark.DropDown += new System.EventHandler(this.cmbTypeLandmark_DropDown);
            this.cmbTypeLandmark.SelectedIndexChanged += new System.EventHandler(this.cmbTypeLandmark_SelectedIndexChanged);
            this.cmbTypeLandmark.Leave += new System.EventHandler(this.cmbTypeLandmark_Leave);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(106, 241);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 47);
            this.button1.TabIndex = 64;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmbTypeLandmark);
            this.Controls.Add(this.txtLabelLandmark);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNameLandmark);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtLocationLandmark);
            this.Controls.Add(this.panel1);
            this.Name = "main";
            this.Size = new System.Drawing.Size(290, 556);
            this.Load += new System.EventHandler(this.main_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLocationLandmark;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNameLandmark;
        private System.Windows.Forms.TextBox txtLabelLandmark;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbTypeLandmark;
        private System.Windows.Forms.Button button1;
    }
}
