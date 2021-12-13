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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.classScheduleLink = new System.Windows.Forms.Button();
            this.projectsLink = new System.Windows.Forms.Button();
            this.onlineMeetingLinks = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.assignmentsLink = new System.Windows.Forms.Button();
            this.notesLink = new System.Windows.Forms.Button();
            this.calenderLinks = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.AccessibleDescription = "";
            this.textBox1.Location = new System.Drawing.Point(1331, 749);
            this.textBox1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(367, 38);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "Todays Date";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Image = global::ZuzaPlan.Properties.Resources.ZuzaPlan_Logo;
            this.pictureBox1.Location = new System.Drawing.Point(-237, -75);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1029, 410);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.panel1.Controls.Add(this.projectsLink);
            this.panel1.Controls.Add(this.assignmentsLink);
            this.panel1.Controls.Add(this.calenderLinks);
            this.panel1.Controls.Add(this.classScheduleLink);
            this.panel1.Controls.Add(this.notesLink);
            this.panel1.Controls.Add(this.onlineMeetingLinks);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(559, 1524);
            this.panel1.TabIndex = 5;
            // 
            // classScheduleLink
            // 
            this.classScheduleLink.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.classScheduleLink.FlatAppearance.BorderSize = 0;
            this.classScheduleLink.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.classScheduleLink.Font = new System.Drawing.Font("Century", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classScheduleLink.ForeColor = System.Drawing.Color.White;
            this.classScheduleLink.Location = new System.Drawing.Point(-3, 817);
            this.classScheduleLink.Name = "classScheduleLink";
            this.classScheduleLink.Size = new System.Drawing.Size(559, 153);
            this.classScheduleLink.TabIndex = 7;
            this.classScheduleLink.Text = "Class Schedule";
            this.classScheduleLink.UseVisualStyleBackColor = false;
            // 
            // projectsLink
            // 
            this.projectsLink.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.projectsLink.FlatAppearance.BorderSize = 0;
            this.projectsLink.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.projectsLink.Font = new System.Drawing.Font("Century", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projectsLink.ForeColor = System.Drawing.Color.White;
            this.projectsLink.Location = new System.Drawing.Point(-3, 658);
            this.projectsLink.Name = "projectsLink";
            this.projectsLink.Size = new System.Drawing.Size(559, 153);
            this.projectsLink.TabIndex = 8;
            this.projectsLink.Text = "Projects";
            this.projectsLink.UseVisualStyleBackColor = false;
            this.projectsLink.Click += new System.EventHandler(this.projectsLink_Click);
            // 
            // onlineMeetingLinks
            // 
            this.onlineMeetingLinks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.onlineMeetingLinks.FlatAppearance.BorderSize = 0;
            this.onlineMeetingLinks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.onlineMeetingLinks.Font = new System.Drawing.Font("Century", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.onlineMeetingLinks.ForeColor = System.Drawing.Color.White;
            this.onlineMeetingLinks.Location = new System.Drawing.Point(-3, 961);
            this.onlineMeetingLinks.Name = "onlineMeetingLinks";
            this.onlineMeetingLinks.Size = new System.Drawing.Size(559, 153);
            this.onlineMeetingLinks.TabIndex = 9;
            this.onlineMeetingLinks.Text = "Online Meetings";
            this.onlineMeetingLinks.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset;
            this.tableLayoutPanel2.ColumnCount = 7;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.85593F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.14407F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 209F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 214F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 210F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 173F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 155F));
            this.tableLayoutPanel2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(604, 301);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.6738F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.3262F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 173F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 205F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 216F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1377, 977);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // assignmentsLink
            // 
            this.assignmentsLink.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.assignmentsLink.FlatAppearance.BorderSize = 0;
            this.assignmentsLink.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.assignmentsLink.Font = new System.Drawing.Font("Century", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assignmentsLink.ForeColor = System.Drawing.Color.White;
            this.assignmentsLink.Location = new System.Drawing.Point(0, 499);
            this.assignmentsLink.Name = "assignmentsLink";
            this.assignmentsLink.Size = new System.Drawing.Size(556, 153);
            this.assignmentsLink.TabIndex = 10;
            this.assignmentsLink.Text = "Assignments ";
            this.assignmentsLink.UseVisualStyleBackColor = false;
            // 
            // notesLink
            // 
            this.notesLink.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.notesLink.FlatAppearance.BorderSize = 0;
            this.notesLink.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.notesLink.Font = new System.Drawing.Font("Century", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notesLink.ForeColor = System.Drawing.Color.White;
            this.notesLink.Location = new System.Drawing.Point(0, 182);
            this.notesLink.Name = "notesLink";
            this.notesLink.Size = new System.Drawing.Size(556, 153);
            this.notesLink.TabIndex = 11;
            this.notesLink.Text = "Notes";
            this.notesLink.UseVisualStyleBackColor = false;
            // 
            // calenderLinks
            // 
            this.calenderLinks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.calenderLinks.FlatAppearance.BorderSize = 0;
            this.calenderLinks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calenderLinks.Font = new System.Drawing.Font("Century", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calenderLinks.ForeColor = System.Drawing.Color.White;
            this.calenderLinks.Location = new System.Drawing.Point(-3, 345);
            this.calenderLinks.Name = "calenderLinks";
            this.calenderLinks.Size = new System.Drawing.Size(559, 153);
            this.calenderLinks.TabIndex = 12;
            this.calenderLinks.Text = "Calender";
            this.calenderLinks.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.ClientSize = new System.Drawing.Size(2013, 1524);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "Form1";
            this.Text = "ZuzaPlan";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button onlineMeetingLinks;
        private System.Windows.Forms.Button projectsLink;
        private System.Windows.Forms.Button classScheduleLink;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button calenderLinks;
        private System.Windows.Forms.Button notesLink;
        private System.Windows.Forms.Button assignmentsLink;
    }
}
#endregion