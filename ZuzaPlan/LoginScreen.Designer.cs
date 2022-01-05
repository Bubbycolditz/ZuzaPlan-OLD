namespace ZuzaPlan {
    partial class LoginScreen {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginScreen));
            this.signinButton = new System.Windows.Forms.Button();
            this.emailInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.passwordInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.signupLink = new System.Windows.Forms.LinkLabel();
            this.phoneInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.signinLink = new System.Windows.Forms.LinkLabel();
            this.signupButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // signinButton
            // 
            this.signinButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(153)))), ((int)(((byte)(221)))));
            this.signinButton.Location = new System.Drawing.Point(627, 615);
            this.signinButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.signinButton.Name = "signinButton";
            this.signinButton.Size = new System.Drawing.Size(200, 55);
            this.signinButton.TabIndex = 0;
            this.signinButton.Text = "Sign In";
            this.signinButton.UseVisualStyleBackColor = false;
            // 
            // emailInput
            // 
            this.emailInput.BackColor = System.Drawing.Color.DarkGray;
            this.emailInput.Location = new System.Drawing.Point(563, 303);
            this.emailInput.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.emailInput.Name = "emailInput";
            this.emailInput.Size = new System.Drawing.Size(297, 38);
            this.emailInput.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(339, 303);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Email:";
            // 
            // passwordInput
            // 
            this.passwordInput.BackColor = System.Drawing.Color.DarkGray;
            this.passwordInput.Location = new System.Drawing.Point(563, 458);
            this.passwordInput.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.passwordInput.Name = "passwordInput";
            this.passwordInput.Size = new System.Drawing.Size(297, 38);
            this.passwordInput.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(339, 465);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password:";
            // 
            // signupLink
            // 
            this.signupLink.AutoSize = true;
            this.signupLink.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(156)))), ((int)(((byte)(50)))));
            this.signupLink.Location = new System.Drawing.Point(515, 775);
            this.signupLink.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.signupLink.Name = "signupLink";
            this.signupLink.Size = new System.Drawing.Size(409, 32);
            this.signupLink.TabIndex = 5;
            this.signupLink.TabStop = true;
            this.signupLink.Text = "Dont have an account? Sign up";
            this.signupLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.signupLink_LinkClicked);
            // 
            // phoneInput
            // 
            this.phoneInput.BackColor = System.Drawing.Color.DarkGray;
            this.phoneInput.Location = new System.Drawing.Point(563, 620);
            this.phoneInput.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.phoneInput.Name = "phoneInput";
            this.phoneInput.Size = new System.Drawing.Size(297, 38);
            this.phoneInput.TabIndex = 6;
            this.phoneInput.Visible = false;
            this.phoneInput.TextChanged += new System.EventHandler(this.phoneInput_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(304, 627);
            this.label3.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(212, 32);
            this.label3.TabIndex = 7;
            this.label3.Text = "Phone Number:";
            this.label3.Visible = false;
            // 
            // signinLink
            // 
            this.signinLink.AutoSize = true;
            this.signinLink.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(156)))), ((int)(((byte)(50)))));
            this.signinLink.Location = new System.Drawing.Point(515, 887);
            this.signinLink.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.signinLink.Name = "signinLink";
            this.signinLink.Size = new System.Drawing.Size(437, 32);
            this.signinLink.TabIndex = 8;
            this.signinLink.TabStop = true;
            this.signinLink.Text = "Already have an account? Sign in";
            this.signinLink.Visible = false;
            this.signinLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.signinLink_LinkClicked);
            // 
            // signupButton
            // 
            this.signupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(153)))), ((int)(((byte)(221)))));
            this.signupButton.Location = new System.Drawing.Point(627, 751);
            this.signupButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.signupButton.Name = "signupButton";
            this.signupButton.Size = new System.Drawing.Size(200, 55);
            this.signupButton.TabIndex = 9;
            this.signupButton.Text = "Sign up";
            this.signupButton.UseVisualStyleBackColor = false;
            this.signupButton.Visible = false;
            // 
            // LoginScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.ClientSize = new System.Drawing.Size(1432, 1288);
            this.Controls.Add(this.signupButton);
            this.Controls.Add(this.signinLink);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.phoneInput);
            this.Controls.Add(this.signupLink);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.passwordInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.emailInput);
            this.Controls.Add(this.signinButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "LoginScreen";
            this.Text = "ZuzaPlan Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button signinButton;
        private System.Windows.Forms.TextBox emailInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox passwordInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel signupLink;
        private System.Windows.Forms.TextBox phoneInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel signinLink;
        private System.Windows.Forms.Button signupButton;
    }
}