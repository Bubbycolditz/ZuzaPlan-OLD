namespace ZuzaPlan
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.zoomLink = new System.Windows.Forms.LinkLabel();
            this.projects = new System.Windows.Forms.LinkLabel();
            this.assignmentLink = new System.Windows.Forms.LinkLabel();
            this.notesLink = new System.Windows.Forms.LinkLabel();
            this.classScheduleLink = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.AccessibleDescription = "";
            this.textBox1.Location = new System.Drawing.Point(400, 187);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(140, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "Todays Date";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.76543F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.23457F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 88F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 83F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 94F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(385, 236);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.67567F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.32433F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 71F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 73F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 79F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(185, 142);
            this.tableLayoutPanel1.TabIndex = 3;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.zoomLink, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.projects, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.assignmentLink, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.notesLink, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.classScheduleLink, 0, 3);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 156);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 6;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.26027F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.73973F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 71F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 74F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 163F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(295, 482);
            this.tableLayoutPanel2.TabIndex = 4;
            this.tableLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel2_Paint);
            // 
            // zoomLink
            // 
            this.zoomLink.AccessibleName = "Notes ";
            this.zoomLink.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(111)))), ((int)(((byte)(156)))));
            this.zoomLink.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.zoomLink.AutoSize = true;
            this.zoomLink.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.zoomLink.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.zoomLink.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(170)))), ((int)(((byte)(225)))));
            this.zoomLink.Location = new System.Drawing.Point(118, 272);
            this.zoomLink.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.zoomLink.Name = "zoomLink";
            this.zoomLink.Size = new System.Drawing.Size(58, 13);
            this.zoomLink.TabIndex = 4;
            this.zoomLink.TabStop = true;
            this.zoomLink.Text = "Zoom links";
            // 
            // projects
            // 
            this.projects.AccessibleName = "Notes ";
            this.projects.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(111)))), ((int)(((byte)(156)))));
            this.projects.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.projects.AutoSize = true;
            this.projects.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.projects.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.projects.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(170)))), ((int)(((byte)(225)))));
            this.projects.Location = new System.Drawing.Point(125, 129);
            this.projects.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.projects.Name = "projects";
            this.projects.Size = new System.Drawing.Size(45, 13);
            this.projects.TabIndex = 2;
            this.projects.TabStop = true;
            this.projects.Text = "Projects";
            // 
            // assignmentLink
            // 
            this.assignmentLink.AccessibleName = "Notes ";
            this.assignmentLink.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(111)))), ((int)(((byte)(156)))));
            this.assignmentLink.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.assignmentLink.AutoSize = true;
            this.assignmentLink.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.assignmentLink.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.assignmentLink.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(170)))), ((int)(((byte)(225)))));
            this.assignmentLink.Location = new System.Drawing.Point(114, 68);
            this.assignmentLink.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.assignmentLink.Name = "assignmentLink";
            this.assignmentLink.Size = new System.Drawing.Size(66, 13);
            this.assignmentLink.TabIndex = 1;
            this.assignmentLink.TabStop = true;
            this.assignmentLink.Text = "Assignments";
            // 
            // notesLink
            // 
            this.notesLink.AccessibleName = "Notes ";
            this.notesLink.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(111)))), ((int)(((byte)(156)))));
            this.notesLink.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.notesLink.AutoSize = true;
            this.notesLink.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.notesLink.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.notesLink.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(170)))), ((int)(((byte)(225)))));
            this.notesLink.Location = new System.Drawing.Point(130, 18);
            this.notesLink.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.notesLink.Name = "notesLink";
            this.notesLink.Size = new System.Drawing.Size(35, 13);
            this.notesLink.TabIndex = 0;
            this.notesLink.TabStop = true;
            this.notesLink.Text = "Notes";
            this.notesLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.notesLink_LinkClicked);
            // 
            // classScheduleLink
            // 
            this.classScheduleLink.AccessibleName = "Notes ";
            this.classScheduleLink.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(111)))), ((int)(((byte)(156)))));
            this.classScheduleLink.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.classScheduleLink.AutoSize = true;
            this.classScheduleLink.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.classScheduleLink.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.classScheduleLink.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(170)))), ((int)(((byte)(225)))));
            this.classScheduleLink.Location = new System.Drawing.Point(107, 199);
            this.classScheduleLink.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.classScheduleLink.Name = "classScheduleLink";
            this.classScheduleLink.Size = new System.Drawing.Size(80, 13);
            this.classScheduleLink.TabIndex = 3;
            this.classScheduleLink.TabStop = true;
            this.classScheduleLink.Text = "Class Schedule";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-68, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(462, 209);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.ClientSize = new System.Drawing.Size(755, 639);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "ZuzaPlan";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.LinkLabel notesLink;
        private System.Windows.Forms.LinkLabel zoomLink;
        private System.Windows.Forms.LinkLabel projects;
        private System.Windows.Forms.LinkLabel assignmentLink;
        private System.Windows.Forms.LinkLabel classScheduleLink;
    }
}
#endregion