namespace ZuzaPlan
{
    partial class MainScreen
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lineSeparator = new System.Windows.Forms.Label();
            this.projectsButton = new System.Windows.Forms.Button();
            this.assignmentsButton = new System.Windows.Forms.Button();
            this.calenderButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.classScheduleButton = new System.Windows.Forms.Button();
            this.notesButton = new System.Windows.Forms.Button();
            this.onlineMeetingButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.aboutButton = new System.Windows.Forms.Button();
            this.signInButton = new System.Windows.Forms.Button();
            this.navbar = new System.Windows.Forms.Panel();
            this.minimizeButton = new System.Windows.Forms.Button();
            this.maximizeButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.navbar.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.AccessibleDescription = "";
            this.textBox1.Location = new System.Drawing.Point(498, 353);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(140, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "Todays Date";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.panel1.Controls.Add(this.lineSeparator);
            this.panel1.Controls.Add(this.projectsButton);
            this.panel1.Controls.Add(this.assignmentsButton);
            this.panel1.Controls.Add(this.calenderButton);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.classScheduleButton);
            this.panel1.Controls.Add(this.notesButton);
            this.panel1.Controls.Add(this.onlineMeetingButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(210, 750);
            this.panel1.TabIndex = 5;
            // 
            // lineSeparator
            // 
            this.lineSeparator.BackColor = System.Drawing.Color.White;
            this.lineSeparator.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lineSeparator.Location = new System.Drawing.Point(-1, 112);
            this.lineSeparator.Name = "lineSeparator";
            this.lineSeparator.Size = new System.Drawing.Size(240, 3);
            this.lineSeparator.TabIndex = 8;
            this.lineSeparator.Click += new System.EventHandler(this.label1_Click);
            // 
            // projectsButton
            // 
            this.projectsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.projectsButton.FlatAppearance.BorderSize = 0;
            this.projectsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.projectsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projectsButton.ForeColor = System.Drawing.Color.White;
            this.projectsButton.Location = new System.Drawing.Point(0, 309);
            this.projectsButton.Margin = new System.Windows.Forms.Padding(1);
            this.projectsButton.Name = "projectsButton";
            this.projectsButton.Size = new System.Drawing.Size(208, 64);
            this.projectsButton.TabIndex = 8;
            this.projectsButton.Text = "Projects";
            this.projectsButton.UseVisualStyleBackColor = false;
            this.projectsButton.Click += new System.EventHandler(this.projectsLink_Click);
            // 
            // assignmentsButton
            // 
            this.assignmentsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.assignmentsButton.FlatAppearance.BorderSize = 0;
            this.assignmentsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.assignmentsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assignmentsButton.ForeColor = System.Drawing.Color.White;
            this.assignmentsButton.Location = new System.Drawing.Point(2, 248);
            this.assignmentsButton.Margin = new System.Windows.Forms.Padding(1);
            this.assignmentsButton.Name = "assignmentsButton";
            this.assignmentsButton.Size = new System.Drawing.Size(208, 64);
            this.assignmentsButton.TabIndex = 10;
            this.assignmentsButton.Text = "Assignments ";
            this.assignmentsButton.UseVisualStyleBackColor = false;
            // 
            // calenderButton
            // 
            this.calenderButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.calenderButton.FlatAppearance.BorderSize = 0;
            this.calenderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calenderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calenderButton.ForeColor = System.Drawing.Color.White;
            this.calenderButton.Location = new System.Drawing.Point(-1, 182);
            this.calenderButton.Margin = new System.Windows.Forms.Padding(1);
            this.calenderButton.Name = "calenderButton";
            this.calenderButton.Size = new System.Drawing.Size(208, 64);
            this.calenderButton.TabIndex = 12;
            this.calenderButton.Text = "Calender";
            this.calenderButton.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Image = global::ZuzaPlan.Properties.Resources.ZuzaPlan_Logo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(189, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // classScheduleButton
            // 
            this.classScheduleButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.classScheduleButton.FlatAppearance.BorderSize = 0;
            this.classScheduleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.classScheduleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classScheduleButton.ForeColor = System.Drawing.Color.White;
            this.classScheduleButton.Location = new System.Drawing.Point(1, 375);
            this.classScheduleButton.Margin = new System.Windows.Forms.Padding(1);
            this.classScheduleButton.Name = "classScheduleButton";
            this.classScheduleButton.Size = new System.Drawing.Size(208, 64);
            this.classScheduleButton.TabIndex = 7;
            this.classScheduleButton.Text = "Class Schedule";
            this.classScheduleButton.UseVisualStyleBackColor = false;
            // 
            // notesButton
            // 
            this.notesButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.notesButton.FlatAppearance.BorderSize = 0;
            this.notesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.notesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notesButton.ForeColor = System.Drawing.Color.White;
            this.notesButton.Location = new System.Drawing.Point(2, 116);
            this.notesButton.Margin = new System.Windows.Forms.Padding(1);
            this.notesButton.Name = "notesButton";
            this.notesButton.Size = new System.Drawing.Size(208, 64);
            this.notesButton.TabIndex = 11;
            this.notesButton.Text = "Notes";
            this.notesButton.UseVisualStyleBackColor = false;
            // 
            // onlineMeetingButton
            // 
            this.onlineMeetingButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.onlineMeetingButton.FlatAppearance.BorderSize = 0;
            this.onlineMeetingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.onlineMeetingButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.onlineMeetingButton.ForeColor = System.Drawing.Color.White;
            this.onlineMeetingButton.Location = new System.Drawing.Point(0, 441);
            this.onlineMeetingButton.Margin = new System.Windows.Forms.Padding(1);
            this.onlineMeetingButton.Name = "onlineMeetingButton";
            this.onlineMeetingButton.Size = new System.Drawing.Size(208, 64);
            this.onlineMeetingButton.TabIndex = 9;
            this.onlineMeetingButton.Text = "Online Meetings";
            this.onlineMeetingButton.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset;
            this.tableLayoutPanel2.ColumnCount = 7;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.3007F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.6993F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 174F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 172F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 163F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 164F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 169F));
            this.tableLayoutPanel2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(236, 165);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(1);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.21459F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.78541F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 101F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 102F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 105F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1185, 534);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // aboutButton
            // 
            this.aboutButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.aboutButton.FlatAppearance.BorderSize = 0;
            this.aboutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aboutButton.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.aboutButton.Location = new System.Drawing.Point(53, 0);
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.Size = new System.Drawing.Size(52, 27);
            this.aboutButton.TabIndex = 7;
            this.aboutButton.Text = "About";
            this.aboutButton.UseVisualStyleBackColor = false;
            this.aboutButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // signInButton
            // 
            this.signInButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.signInButton.FlatAppearance.BorderSize = 0;
            this.signInButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signInButton.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signInButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.signInButton.Location = new System.Drawing.Point(0, 0);
            this.signInButton.Name = "signInButton";
            this.signInButton.Size = new System.Drawing.Size(56, 27);
            this.signInButton.TabIndex = 8;
            this.signInButton.Text = "Sign In";
            this.signInButton.UseVisualStyleBackColor = false;
            // 
            // navbar
            // 
            this.navbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.navbar.Controls.Add(this.minimizeButton);
            this.navbar.Controls.Add(this.signInButton);
            this.navbar.Controls.Add(this.aboutButton);
            this.navbar.Controls.Add(this.maximizeButton);
            this.navbar.Controls.Add(this.exitButton);
            this.navbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.navbar.Location = new System.Drawing.Point(210, 0);
            this.navbar.Name = "navbar";
            this.navbar.Size = new System.Drawing.Size(1243, 27);
            this.navbar.TabIndex = 9;
            this.navbar.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // minimizeButton
            // 
            this.minimizeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.minimizeButton.BackgroundImage = global::ZuzaPlan.Properties.Resources.Minimize;
            this.minimizeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.minimizeButton.FlatAppearance.BorderSize = 0;
            this.minimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeButton.Location = new System.Drawing.Point(1096, 0);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(45, 27);
            this.minimizeButton.TabIndex = 10;
            this.minimizeButton.UseVisualStyleBackColor = false;
            this.minimizeButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // maximizeButton
            // 
            this.maximizeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.maximizeButton.BackgroundImage = global::ZuzaPlan.Properties.Resources.Maximize;
            this.maximizeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.maximizeButton.FlatAppearance.BorderSize = 0;
            this.maximizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.maximizeButton.Location = new System.Drawing.Point(1147, 0);
            this.maximizeButton.Name = "maximizeButton";
            this.maximizeButton.Size = new System.Drawing.Size(45, 27);
            this.maximizeButton.TabIndex = 11;
            this.maximizeButton.UseVisualStyleBackColor = false;
            this.maximizeButton.Click += new System.EventHandler(this.maximizeButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.exitButton.BackgroundImage = global::ZuzaPlan.Properties.Resources.Exit;
            this.exitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Location = new System.Drawing.Point(1198, 0);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(45, 27);
            this.exitButton.TabIndex = 0;
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.ClientSize = new System.Drawing.Size(1453, 750);
            this.Controls.Add(this.navbar);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainScreen";
            this.Text = "ZuzaPlan";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.navbar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button onlineMeetingButton;
        private System.Windows.Forms.Button projectsButton;
        private System.Windows.Forms.Button classScheduleButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button calenderButton;
        private System.Windows.Forms.Button notesButton;
        private System.Windows.Forms.Button assignmentsButton;
        private System.Windows.Forms.Button aboutButton;
        private System.Windows.Forms.Label lineSeparator;
        private System.Windows.Forms.Button signInButton;
        private System.Windows.Forms.Panel navbar;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button minimizeButton;
        private System.Windows.Forms.Button maximizeButton;
    }
}
#endregion