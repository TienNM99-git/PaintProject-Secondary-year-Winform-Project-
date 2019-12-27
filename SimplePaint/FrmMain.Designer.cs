namespace SimplePaint
{
    partial class FrmMain
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbShapeMode = new System.Windows.Forms.ComboBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnPolygon = new System.Windows.Forms.Button();
            this.btnBezier = new System.Windows.Forms.Button();
            this.btnCurve = new System.Windows.Forms.Button();
            this.btnCircle = new System.Windows.Forms.Button();
            this.btnSquare = new System.Windows.Forms.Button();
            this.btnEllipse = new System.Windows.Forms.Button();
            this.btnRectangle = new System.Windows.Forms.Button();
            this.btnLine = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmbDashMode = new System.Windows.Forms.ComboBox();
            this.btnColor = new System.Windows.Forms.Button();
            this.lblWidth = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.trkLineWidth = new System.Windows.Forms.TrackBar();
            this.panel3 = new System.Windows.Forms.Panel();
            this.clbShape = new System.Windows.Forms.CheckedListBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnUngroup = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnGroup = new System.Windows.Forms.Button();
            this.psfMain = new SimplePaint.PaintSurface();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkLineWidth)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmbShapeMode);
            this.panel1.Controls.Add(this.btnSelect);
            this.panel1.Controls.Add(this.btnPolygon);
            this.panel1.Controls.Add(this.btnBezier);
            this.panel1.Controls.Add(this.btnCurve);
            this.panel1.Controls.Add(this.btnCircle);
            this.panel1.Controls.Add(this.btnSquare);
            this.panel1.Controls.Add(this.btnEllipse);
            this.panel1.Controls.Add(this.btnRectangle);
            this.panel1.Controls.Add(this.btnLine);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1593, 58);
            this.panel1.TabIndex = 0;
            // 
            // cmbShapeMode
            // 
            this.cmbShapeMode.FormattingEnabled = true;
            this.cmbShapeMode.Items.AddRange(new object[] {
            "No fill shape",
            "Fill shape"});
            this.cmbShapeMode.Location = new System.Drawing.Point(17, 16);
            this.cmbShapeMode.Margin = new System.Windows.Forms.Padding(4);
            this.cmbShapeMode.Name = "cmbShapeMode";
            this.cmbShapeMode.Size = new System.Drawing.Size(207, 24);
            this.cmbShapeMode.TabIndex = 3;
            this.cmbShapeMode.SelectedIndexChanged += new System.EventHandler(this.CmbShapeMode_SelectedIndexChanged);
            // 
            // btnSelect
            // 
            this.btnSelect.BackColor = System.Drawing.Color.Transparent;
            this.btnSelect.FlatAppearance.BorderSize = 0;
            this.btnSelect.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnSelect.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnSelect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelect.Location = new System.Drawing.Point(727, 15);
            this.btnSelect.Margin = new System.Windows.Forms.Padding(4);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(60, 28);
            this.btnSelect.TabIndex = 2;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = false;
            this.btnSelect.Click += new System.EventHandler(this.BtnSelect_Click);
            // 
            // btnPolygon
            // 
            this.btnPolygon.BackColor = System.Drawing.Color.Transparent;
            this.btnPolygon.FlatAppearance.BorderSize = 0;
            this.btnPolygon.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnPolygon.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnPolygon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnPolygon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPolygon.Location = new System.Drawing.Point(657, 15);
            this.btnPolygon.Margin = new System.Windows.Forms.Padding(4);
            this.btnPolygon.Name = "btnPolygon";
            this.btnPolygon.Size = new System.Drawing.Size(72, 28);
            this.btnPolygon.TabIndex = 2;
            this.btnPolygon.Text = "Polygon";
            this.btnPolygon.UseVisualStyleBackColor = false;
            this.btnPolygon.Click += new System.EventHandler(this.BtnPolygon_Click);
            // 
            // btnBezier
            // 
            this.btnBezier.BackColor = System.Drawing.Color.Transparent;
            this.btnBezier.FlatAppearance.BorderSize = 0;
            this.btnBezier.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnBezier.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnBezier.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnBezier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBezier.Location = new System.Drawing.Point(601, 15);
            this.btnBezier.Margin = new System.Windows.Forms.Padding(4);
            this.btnBezier.Name = "btnBezier";
            this.btnBezier.Size = new System.Drawing.Size(59, 28);
            this.btnBezier.TabIndex = 2;
            this.btnBezier.Text = "Bezier";
            this.btnBezier.UseVisualStyleBackColor = false;
            this.btnBezier.Click += new System.EventHandler(this.BtnBezier_Click);
            // 
            // btnCurve
            // 
            this.btnCurve.BackColor = System.Drawing.Color.Transparent;
            this.btnCurve.FlatAppearance.BorderSize = 0;
            this.btnCurve.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnCurve.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnCurve.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnCurve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCurve.Location = new System.Drawing.Point(545, 15);
            this.btnCurve.Margin = new System.Windows.Forms.Padding(4);
            this.btnCurve.Name = "btnCurve";
            this.btnCurve.Size = new System.Drawing.Size(59, 28);
            this.btnCurve.TabIndex = 2;
            this.btnCurve.Text = "Curve";
            this.btnCurve.UseVisualStyleBackColor = false;
            this.btnCurve.Click += new System.EventHandler(this.BtnCurve_Click);
            // 
            // btnCircle
            // 
            this.btnCircle.BackColor = System.Drawing.Color.Transparent;
            this.btnCircle.FlatAppearance.BorderSize = 0;
            this.btnCircle.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnCircle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnCircle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnCircle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCircle.Location = new System.Drawing.Point(489, 15);
            this.btnCircle.Margin = new System.Windows.Forms.Padding(4);
            this.btnCircle.Name = "btnCircle";
            this.btnCircle.Size = new System.Drawing.Size(59, 28);
            this.btnCircle.TabIndex = 2;
            this.btnCircle.Text = "Circle";
            this.btnCircle.UseVisualStyleBackColor = false;
            this.btnCircle.Click += new System.EventHandler(this.BtnCircle_Click);
            // 
            // btnSquare
            // 
            this.btnSquare.BackColor = System.Drawing.Color.Transparent;
            this.btnSquare.FlatAppearance.BorderSize = 0;
            this.btnSquare.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnSquare.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnSquare.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnSquare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSquare.Location = new System.Drawing.Point(424, 15);
            this.btnSquare.Margin = new System.Windows.Forms.Padding(4);
            this.btnSquare.Name = "btnSquare";
            this.btnSquare.Size = new System.Drawing.Size(68, 28);
            this.btnSquare.TabIndex = 2;
            this.btnSquare.Text = "Square";
            this.btnSquare.UseVisualStyleBackColor = false;
            this.btnSquare.Click += new System.EventHandler(this.BtnSquare_Click);
            // 
            // btnEllipse
            // 
            this.btnEllipse.BackColor = System.Drawing.Color.Transparent;
            this.btnEllipse.FlatAppearance.BorderSize = 0;
            this.btnEllipse.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnEllipse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnEllipse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnEllipse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEllipse.Location = new System.Drawing.Point(365, 15);
            this.btnEllipse.Margin = new System.Windows.Forms.Padding(4);
            this.btnEllipse.Name = "btnEllipse";
            this.btnEllipse.Size = new System.Drawing.Size(61, 28);
            this.btnEllipse.TabIndex = 2;
            this.btnEllipse.Text = "Ellipse";
            this.btnEllipse.UseVisualStyleBackColor = false;
            this.btnEllipse.Click += new System.EventHandler(this.BtnEllipse_Click);
            // 
            // btnRectangle
            // 
            this.btnRectangle.BackColor = System.Drawing.Color.Transparent;
            this.btnRectangle.FlatAppearance.BorderSize = 0;
            this.btnRectangle.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnRectangle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnRectangle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnRectangle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRectangle.Location = new System.Drawing.Point(280, 15);
            this.btnRectangle.Margin = new System.Windows.Forms.Padding(4);
            this.btnRectangle.Name = "btnRectangle";
            this.btnRectangle.Size = new System.Drawing.Size(88, 28);
            this.btnRectangle.TabIndex = 2;
            this.btnRectangle.Text = "Rectangle";
            this.btnRectangle.UseVisualStyleBackColor = false;
            this.btnRectangle.Click += new System.EventHandler(this.BtnRectangle_Click);
            // 
            // btnLine
            // 
            this.btnLine.BackColor = System.Drawing.Color.Transparent;
            this.btnLine.FlatAppearance.BorderSize = 0;
            this.btnLine.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnLine.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnLine.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnLine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLine.Location = new System.Drawing.Point(233, 15);
            this.btnLine.Margin = new System.Windows.Forms.Padding(4);
            this.btnLine.Name = "btnLine";
            this.btnLine.Size = new System.Drawing.Size(49, 28);
            this.btnLine.TabIndex = 2;
            this.btnLine.Text = "Line";
            this.btnLine.UseVisualStyleBackColor = false;
            this.btnLine.Click += new System.EventHandler(this.BtnLine_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cmbDashMode);
            this.panel2.Controls.Add(this.btnColor);
            this.panel2.Controls.Add(this.lblWidth);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.trkLineWidth);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(869, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(724, 58);
            this.panel2.TabIndex = 0;
            // 
            // cmbDashMode
            // 
            this.cmbDashMode.FormattingEnabled = true;
            this.cmbDashMode.Items.AddRange(new object[] {
            "Solid",
            "Dash",
            "Dot",
            "Dash Dot",
            "Dash Dot Dot"});
            this.cmbDashMode.Location = new System.Drawing.Point(193, 17);
            this.cmbDashMode.Margin = new System.Windows.Forms.Padding(4);
            this.cmbDashMode.Name = "cmbDashMode";
            this.cmbDashMode.Size = new System.Drawing.Size(163, 24);
            this.cmbDashMode.TabIndex = 5;
            this.cmbDashMode.SelectedIndexChanged += new System.EventHandler(this.CmbDashMode_SelectedIndexChanged);
            // 
            // btnColor
            // 
            this.btnColor.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnColor.Location = new System.Drawing.Point(44, 9);
            this.btnColor.Margin = new System.Windows.Forms.Padding(4);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(48, 42);
            this.btnColor.TabIndex = 4;
            this.btnColor.UseVisualStyleBackColor = false;
            this.btnColor.Click += new System.EventHandler(this.BtnColor_Click);
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Location = new System.Drawing.Point(668, 17);
            this.lblWidth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(53, 17);
            this.lblWidth.TabIndex = 3;
            this.lblWidth.Text = "Default";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(383, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Line width";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(116, 22);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Dash style";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Color";
            // 
            // trkLineWidth
            // 
            this.trkLineWidth.Location = new System.Drawing.Point(455, 10);
            this.trkLineWidth.Margin = new System.Windows.Forms.Padding(4);
            this.trkLineWidth.Name = "trkLineWidth";
            this.trkLineWidth.Size = new System.Drawing.Size(211, 56);
            this.trkLineWidth.TabIndex = 1;
            this.trkLineWidth.Scroll += new System.EventHandler(this.TrkLineWidth_Scroll);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.clbShape);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(1322, 58);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(271, 711);
            this.panel3.TabIndex = 1;
            // 
            // clbShape
            // 
            this.clbShape.BackColor = System.Drawing.SystemColors.MenuBar;
            this.clbShape.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clbShape.CheckOnClick = true;
            this.clbShape.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clbShape.FormattingEnabled = true;
            this.clbShape.Location = new System.Drawing.Point(0, 98);
            this.clbShape.Margin = new System.Windows.Forms.Padding(0);
            this.clbShape.Name = "clbShape";
            this.clbShape.Size = new System.Drawing.Size(271, 613);
            this.clbShape.TabIndex = 1;
            this.clbShape.SelectedIndexChanged += new System.EventHandler(this.ClbShape_SelectedIndexChanged);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel5.Controls.Add(this.btnUngroup);
            this.panel5.Controls.Add(this.btnDelete);
            this.panel5.Controls.Add(this.btnGroup);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(271, 98);
            this.panel5.TabIndex = 0;
            // 
            // btnUngroup
            // 
            this.btnUngroup.BackColor = System.Drawing.Color.Silver;
            this.btnUngroup.FlatAppearance.BorderSize = 0;
            this.btnUngroup.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightGray;
            this.btnUngroup.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnUngroup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnUngroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUngroup.Location = new System.Drawing.Point(139, 15);
            this.btnUngroup.Margin = new System.Windows.Forms.Padding(4);
            this.btnUngroup.Name = "btnUngroup";
            this.btnUngroup.Size = new System.Drawing.Size(100, 28);
            this.btnUngroup.TabIndex = 0;
            this.btnUngroup.Text = "Ungroup";
            this.btnUngroup.UseVisualStyleBackColor = false;
            this.btnUngroup.Click += new System.EventHandler(this.BtnUngroup_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Silver;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightGray;
            this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Location = new System.Drawing.Point(31, 50);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 28);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // btnGroup
            // 
            this.btnGroup.BackColor = System.Drawing.Color.Silver;
            this.btnGroup.FlatAppearance.BorderSize = 0;
            this.btnGroup.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightGray;
            this.btnGroup.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnGroup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGroup.Location = new System.Drawing.Point(31, 15);
            this.btnGroup.Margin = new System.Windows.Forms.Padding(4);
            this.btnGroup.Name = "btnGroup";
            this.btnGroup.Size = new System.Drawing.Size(100, 28);
            this.btnGroup.TabIndex = 0;
            this.btnGroup.Text = "Group";
            this.btnGroup.UseVisualStyleBackColor = false;
            this.btnGroup.Click += new System.EventHandler(this.BtnGroup_Click);
            // 
            // psfMain
            // 
            this.psfMain.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.psfMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.psfMain.Location = new System.Drawing.Point(0, 58);
            this.psfMain.Margin = new System.Windows.Forms.Padding(4);
            this.psfMain.Name = "psfMain";
            this.psfMain.Size = new System.Drawing.Size(1322, 711);
            this.psfMain.TabIndex = 2;
            this.psfMain.Paint += new System.Windows.Forms.PaintEventHandler(this.PsfMain_Paint);
            this.psfMain.DoubleClick += new System.EventHandler(this.PsfMain_DoubleClick);
            this.psfMain.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PsfMain_MouseDown);
            this.psfMain.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PsfMain_MouseMove);
            this.psfMain.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PsfMain_MouseUp);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1593, 769);
            this.Controls.Add(this.psfMain);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1291, 750);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simple Paint";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmMain_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FrmMain_KeyUp);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkLineWidth)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.CheckedListBox clbShape;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnPolygon;
        private System.Windows.Forms.Button btnBezier;
        private System.Windows.Forms.Button btnCurve;
        private System.Windows.Forms.Button btnCircle;
        private System.Windows.Forms.Button btnSquare;
        private System.Windows.Forms.Button btnEllipse;
        private System.Windows.Forms.Button btnRectangle;
        private System.Windows.Forms.Button btnLine;
        private System.Windows.Forms.TrackBar trkLineWidth;
        private System.Windows.Forms.Button btnGroup;
        private System.Windows.Forms.Button btnUngroup;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.ComboBox cmbShapeMode;
        private PaintSurface psfMain;
        private System.Windows.Forms.ComboBox cmbDashMode;
        private System.Windows.Forms.Label label3;
    }
}

