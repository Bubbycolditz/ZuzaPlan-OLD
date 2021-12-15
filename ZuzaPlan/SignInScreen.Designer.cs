namespace ZuzaPlan
{
    partial class SignInScreen
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
            this.signinButton.Location = new System.Drawing.Point(235, 258);
            this.signinButton.Name = "signinButton";
            this.signinButton.Size = new System.Drawing.Size(75, 23);
            this.signinButton.TabIndex = 0;
            this.signinButton.Text = "Sign In";
            this.signinButton.UseVisualStyleBackColor = true;
            // 
            // emailInput
            // 
            this.emailInput.Location = new System.Drawing.Point(211, 127);
            this.emailInput.Name = "emailInput";
            this.emailInput.Size = new System.Drawing.Size(114, 20);
            this.emailInput.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(127, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Email:";
            // 
            // passwordInput
            // 
            this.passwordInput.Location = new System.Drawing.Point(211, 192);
            this.passwordInput.Name = "passwordInput";
            this.passwordInput.Size = new System.Drawing.Size(114, 20);
            this.passwordInput.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(127, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password:";
            // 
            // signupLink
            // 
            this.signupLink.AutoSize = true;
            this.signupLink.Location = new System.Drawing.Point(193, 325);
            this.signupLink.Name = "signupLink";
            this.signupLink.Size = new System.Drawing.Size(159, 13);
            this.signupLink.TabIndex = 5;
            this.signupLink.TabStop = true;
            this.signupLink.Text = "Dont have an account? Sign up";
            this.signupLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.signupLink_LinkClicked);
            // 
            // phoneInput
            // 
            this.phoneInput.Location = new System.Drawing.Point(211, 260);
            this.phoneInput.Name = "phoneInput";
            this.phoneInput.Size = new System.Drawing.Size(114, 20);
            this.phoneInput.TabIndex = 6;
            this.phoneInput.Visible = false;
            this.phoneInput.TextChanged += new System.EventHandler(this.phoneInput_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(114, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Phone Number:";
            this.label3.Visible = false;
            // 
            // signinLink
            // 
            this.signinLink.AutoSize = true;
            this.signinLink.Location = new System.Drawing.Point(193, 372);
            this.signinLink.Name = "signinLink";
            this.signinLink.Size = new System.Drawing.Size(167, 13);
            this.signinLink.TabIndex = 8;
            this.signinLink.TabStop = true;
            this.signinLink.Text = "Already have an account? Sign in";
            this.signinLink.Visible = false;
            this.signinLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.signinLink_LinkClicked);
            // 
            // signupButton
            // 
            this.signupButton.Location = new System.Drawing.Point(235, 315);
            this.signupButton.Name = "signupButton";
            this.signupButton.Size = new System.Drawing.Size(75, 23);
            this.signupButton.TabIndex = 9;
            this.signupButton.Text = "Sign up";
            this.signupButton.UseVisualStyleBackColor = true;
            this.signupButton.Visible = false;
            // 
            // SignInScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 540);
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
            this.Name = "SignInScreen";
            this.Text = "Form1";
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