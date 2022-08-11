namespace SearchADUser
{
    partial class SearchADUser
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.DisplayPnl = new System.Windows.Forms.Panel();
            this.lblUsernameDisplay2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtDomain = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Search = new System.Windows.Forms.Button();
            this.txtADUser = new System.Windows.Forms.TextBox();
            this.lblUsernameDisplay = new System.Windows.Forms.Label();
            this.lblTelephone = new System.Windows.Forms.Label();
            this.lblPostal = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblCompany = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblEmailId = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblMiddleName = new System.Windows.Forms.Label();
            this.lblFirstname = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.DisplayPnl.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.txtUserName);
            this.groupBox1.Controls.Add(this.lblPassword);
            this.groupBox1.Controls.Add(this.lblUserName);
            this.groupBox1.Location = new System.Drawing.Point(52, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(308, 124);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(113, 55);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(146, 20);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(115, 24);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(145, 20);
            this.txtUserName.TabIndex = 2;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(16, 53);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 13);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Password";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(15, 29);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(57, 13);
            this.lblUserName.TabIndex = 0;
            this.lblUserName.Text = "UserName";
            // 
            // DisplayPnl
            // 
            this.DisplayPnl.Controls.Add(this.lblUsernameDisplay2);
            this.DisplayPnl.Location = new System.Drawing.Point(36, 275);
            this.DisplayPnl.Name = "DisplayPnl";
            this.DisplayPnl.Size = new System.Drawing.Size(768, 237);
            this.DisplayPnl.TabIndex = 34;
            // 
            // lblUsernameDisplay2
            // 
            this.lblUsernameDisplay2.AutoSize = true;
            this.lblUsernameDisplay2.Location = new System.Drawing.Point(13, 21);
            this.lblUsernameDisplay2.Name = "lblUsernameDisplay2";
            this.lblUsernameDisplay2.Size = new System.Drawing.Size(105, 13);
            this.lblUsernameDisplay2.TabIndex = 0;
            this.lblUsernameDisplay2.Text = "lblUsernameDisplay2";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtDomain);
            this.groupBox2.Location = new System.Drawing.Point(503, 18);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(317, 118);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Domain";
            // 
            // txtDomain
            // 
            this.txtDomain.Location = new System.Drawing.Point(19, 55);
            this.txtDomain.Name = "txtDomain";
            this.txtDomain.Size = new System.Drawing.Size(282, 20);
            this.txtDomain.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Search);
            this.groupBox3.Controls.Add(this.txtADUser);
            this.groupBox3.Location = new System.Drawing.Point(52, 171);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(694, 71);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "UserAccount";
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(585, 32);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(75, 23);
            this.Search.TabIndex = 1;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // txtADUser
            // 
            this.txtADUser.Location = new System.Drawing.Point(90, 34);
            this.txtADUser.Name = "txtADUser";
            this.txtADUser.Size = new System.Drawing.Size(476, 20);
            this.txtADUser.TabIndex = 0;
            // 
            // lblUsernameDisplay
            // 
            this.lblUsernameDisplay.AutoSize = true;
            this.lblUsernameDisplay.Location = new System.Drawing.Point(52, 280);
            this.lblUsernameDisplay.Name = "lblUsernameDisplay";
            this.lblUsernameDisplay.Size = new System.Drawing.Size(61, 13);
            this.lblUsernameDisplay.TabIndex = 32;
            this.lblUsernameDisplay.Text = "Username :";
            // 
            // lblTelephone
            // 
            this.lblTelephone.AutoSize = true;
            this.lblTelephone.Location = new System.Drawing.Point(345, 103);
            this.lblTelephone.Name = "lblTelephone";
            this.lblTelephone.Size = new System.Drawing.Size(84, 13);
            this.lblTelephone.TabIndex = 31;
            this.lblTelephone.Text = "Telephone No. :";
            this.lblTelephone.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPostal
            // 
            this.lblPostal.AutoSize = true;
            this.lblPostal.Location = new System.Drawing.Point(359, 78);
            this.lblPostal.Name = "lblPostal";
            this.lblPostal.Size = new System.Drawing.Size(70, 13);
            this.lblPostal.TabIndex = 30;
            this.lblPostal.Text = "Postal Code :";
            this.lblPostal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(380, 55);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(49, 13);
            this.lblCountry.TabIndex = 29;
            this.lblCountry.Text = "Country :";
            this.lblCountry.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(391, 31);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(38, 13);
            this.lblState.TabIndex = 28;
            this.lblState.Text = "State :";
            this.lblState.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(62, 186);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(30, 13);
            this.lblCity.TabIndex = 27;
            this.lblCity.Text = "City :";
            this.lblCity.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCompany
            // 
            this.lblCompany.AutoSize = true;
            this.lblCompany.Location = new System.Drawing.Point(35, 163);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(57, 13);
            this.lblCompany.TabIndex = 26;
            this.lblCompany.Text = "Company :";
            this.lblCompany.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(59, 139);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(33, 13);
            this.lblTitle.TabIndex = 25;
            this.lblTitle.Text = "Title :";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblEmailId
            // 
            this.lblEmailId.AutoSize = true;
            this.lblEmailId.Location = new System.Drawing.Point(40, 115);
            this.lblEmailId.Name = "lblEmailId";
            this.lblEmailId.Size = new System.Drawing.Size(52, 13);
            this.lblEmailId.TabIndex = 24;
            this.lblEmailId.Text = "Email ID :";
            this.lblEmailId.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(28, 90);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(64, 13);
            this.lblLastName.TabIndex = 23;
            this.lblLastName.Text = "Last Name :";
            this.lblLastName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblMiddleName
            // 
            this.lblMiddleName.AutoSize = true;
            this.lblMiddleName.Location = new System.Drawing.Point(17, 67);
            this.lblMiddleName.Name = "lblMiddleName";
            this.lblMiddleName.Size = new System.Drawing.Size(75, 13);
            this.lblMiddleName.TabIndex = 22;
            this.lblMiddleName.Text = "Middle Name :";
            this.lblMiddleName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFirstname
            // 
            this.lblFirstname.AutoSize = true;
            this.lblFirstname.Location = new System.Drawing.Point(29, 43);
            this.lblFirstname.Name = "lblFirstname";
            this.lblFirstname.Size = new System.Drawing.Size(63, 13);
            this.lblFirstname.TabIndex = 21;
            this.lblFirstname.Text = "First Name :";
            this.lblFirstname.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // SearchADUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 575);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DisplayPnl);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Name = "SearchADUser";
            this.Text = "SearchADUser";
            this.Load += new System.EventHandler(this.SearchADUser_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.DisplayPnl.ResumeLayout(false);
            this.DisplayPnl.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtDomain;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.TextBox txtADUser;

        private System.Windows.Forms.Label lblTelephone;
        private System.Windows.Forms.Label lblPostal;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblCompany;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblEmailId;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblMiddleName;
        private System.Windows.Forms.Label lblFirstname;
        private System.Windows.Forms.Label lblUsernameDisplay;
        private System.Windows.Forms.Label lblUsernameDisplay2;

        private System.Windows.Forms.Panel DisplayPnl;
        
    }
}

