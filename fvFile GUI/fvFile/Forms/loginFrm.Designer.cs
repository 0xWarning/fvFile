namespace fvFile.Forms
{
    partial class loginFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginFrm));
            this.tabPane1 = new DevExpress.XtraBars.Navigation.TabPane();
            this.tabNavigationPage1 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.checkEdit1 = new DevExpress.XtraEditors.CheckEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.logPassEdit = new DevExpress.XtraEditors.TextEdit();
            this.logEmailEdit = new DevExpress.XtraEditors.TextEdit();
            this.tabNavigationPage2 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.regNameEdit = new DevExpress.XtraEditors.TextEdit();
            this.regRePassEdit = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.regPassEdit = new DevExpress.XtraEditors.TextEdit();
            this.regEmailEdit = new DevExpress.XtraEditors.TextEdit();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).BeginInit();
            this.tabPane1.SuspendLayout();
            this.tabNavigationPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logPassEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logEmailEdit.Properties)).BeginInit();
            this.tabNavigationPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.regNameEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.regRePassEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.regPassEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.regEmailEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPane1
            // 
            this.tabPane1.Controls.Add(this.tabNavigationPage1);
            this.tabPane1.Controls.Add(this.tabNavigationPage2);
            this.tabPane1.Location = new System.Drawing.Point(13, 89);
            this.tabPane1.Name = "tabPane1";
            this.tabPane1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.tabNavigationPage1,
            this.tabNavigationPage2});
            this.tabPane1.RegularSize = new System.Drawing.Size(220, 225);
            this.tabPane1.SelectedPage = this.tabNavigationPage1;
            this.tabPane1.Size = new System.Drawing.Size(220, 225);
            this.tabPane1.TabAlignment = DevExpress.XtraEditors.Alignment.Center;
            this.tabPane1.TabIndex = 7;
            this.tabPane1.Text = "Login";
            // 
            // tabNavigationPage1
            // 
            this.tabNavigationPage1.Caption = "Login";
            this.tabNavigationPage1.Controls.Add(this.labelControl1);
            this.tabNavigationPage1.Controls.Add(this.checkEdit1);
            this.tabNavigationPage1.Controls.Add(this.simpleButton1);
            this.tabNavigationPage1.Controls.Add(this.logPassEdit);
            this.tabNavigationPage1.Controls.Add(this.logEmailEdit);
            this.tabNavigationPage1.Name = "tabNavigationPage1";
            this.tabNavigationPage1.Size = new System.Drawing.Size(220, 184);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(34, 150);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(144, 13);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "Thank you for using File Vision";
            // 
            // checkEdit1
            // 
            this.checkEdit1.Enabled = false;
            this.checkEdit1.Location = new System.Drawing.Point(15, 84);
            this.checkEdit1.Name = "checkEdit1";
            this.checkEdit1.Properties.Caption = "Remember Me ?";
            this.checkEdit1.Size = new System.Drawing.Size(110, 22);
            this.checkEdit1.TabIndex = 3;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(15, 112);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(188, 23);
            this.simpleButton1.TabIndex = 2;
            this.simpleButton1.Text = "Login";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // logPassEdit
            // 
            this.logPassEdit.EditValue = "Password";
            this.logPassEdit.Location = new System.Drawing.Point(15, 50);
            this.logPassEdit.Name = "logPassEdit";
            this.logPassEdit.Size = new System.Drawing.Size(188, 28);
            this.logPassEdit.TabIndex = 1;
            // 
            // logEmailEdit
            // 
            this.logEmailEdit.EditValue = "Email";
            this.logEmailEdit.Location = new System.Drawing.Point(15, 16);
            this.logEmailEdit.Name = "logEmailEdit";
            this.logEmailEdit.Size = new System.Drawing.Size(188, 28);
            this.logEmailEdit.TabIndex = 0;
            // 
            // tabNavigationPage2
            // 
            this.tabNavigationPage2.Caption = "Sign Up";
            this.tabNavigationPage2.Controls.Add(this.regNameEdit);
            this.tabNavigationPage2.Controls.Add(this.regRePassEdit);
            this.tabNavigationPage2.Controls.Add(this.simpleButton2);
            this.tabNavigationPage2.Controls.Add(this.regPassEdit);
            this.tabNavigationPage2.Controls.Add(this.regEmailEdit);
            this.tabNavigationPage2.Name = "tabNavigationPage2";
            this.tabNavigationPage2.Size = new System.Drawing.Size(220, 184);
            // 
            // regNameEdit
            // 
            this.regNameEdit.EditValue = "Name";
            this.regNameEdit.Location = new System.Drawing.Point(16, 12);
            this.regNameEdit.Name = "regNameEdit";
            this.regNameEdit.Size = new System.Drawing.Size(188, 28);
            this.regNameEdit.TabIndex = 9;
            // 
            // regRePassEdit
            // 
            this.regRePassEdit.EditValue = "Re-Password";
            this.regRePassEdit.Location = new System.Drawing.Point(16, 114);
            this.regRePassEdit.Name = "regRePassEdit";
            this.regRePassEdit.Size = new System.Drawing.Size(188, 28);
            this.regRePassEdit.TabIndex = 8;
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(16, 148);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(188, 23);
            this.simpleButton2.TabIndex = 6;
            this.simpleButton2.Text = "Register";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // regPassEdit
            // 
            this.regPassEdit.EditValue = "Password";
            this.regPassEdit.Location = new System.Drawing.Point(16, 80);
            this.regPassEdit.Name = "regPassEdit";
            this.regPassEdit.Size = new System.Drawing.Size(188, 28);
            this.regPassEdit.TabIndex = 5;
            // 
            // regEmailEdit
            // 
            this.regEmailEdit.EditValue = "Email";
            this.regEmailEdit.Location = new System.Drawing.Point(16, 46);
            this.regEmailEdit.Name = "regEmailEdit";
            this.regEmailEdit.Size = new System.Drawing.Size(188, 28);
            this.regEmailEdit.TabIndex = 4;
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(13, 10);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Size = new System.Drawing.Size(220, 73);
            this.pictureEdit1.TabIndex = 8;
            // 
            // loginFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(246, 325);
            this.Controls.Add(this.tabPane1);
            this.Controls.Add(this.pictureEdit1);
            this.Name = "loginFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "loginFrm";
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).EndInit();
            this.tabPane1.ResumeLayout(false);
            this.tabNavigationPage1.ResumeLayout(false);
            this.tabNavigationPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logPassEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logEmailEdit.Properties)).EndInit();
            this.tabNavigationPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.regNameEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.regRePassEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.regPassEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.regEmailEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.TabPane tabPane1;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.CheckEdit checkEdit1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.TextEdit logPassEdit;
        private DevExpress.XtraEditors.TextEdit logEmailEdit;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage2;
        private DevExpress.XtraEditors.TextEdit regNameEdit;
        private DevExpress.XtraEditors.TextEdit regRePassEdit;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.TextEdit regPassEdit;
        private DevExpress.XtraEditors.TextEdit regEmailEdit;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
    }
}