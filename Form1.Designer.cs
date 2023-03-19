
namespace Excel_to_SQL_Import_Wizard
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
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.headerLabel = new System.Windows.Forms.Label();
            this.settingsLabel1 = new System.Windows.Forms.Label();
            this.settingsLabel2 = new System.Windows.Forms.Label();
            this.settingsLabel3 = new System.Windows.Forms.Label();
            this.uploadLabel = new System.Windows.Forms.Label();
            this.serverNameLabel = new System.Windows.Forms.Label();
            this.databaseNameLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.sqlTableNameLabel = new System.Windows.Forms.Label();
            this.serverInstanceTextBox = new System.Windows.Forms.TextBox();
            this.databaseNameTextBox = new System.Windows.Forms.TextBox();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.tableTextBox = new System.Windows.Forms.TextBox();
            this.columnsTextBox = new System.Windows.Forms.RichTextBox();
            this.saveSettingsButton1 = new System.Windows.Forms.Button();
            this.saveSettingsButton2 = new System.Windows.Forms.Button();
            this.selectFileButton = new System.Windows.Forms.Button();
            this.uploadDataButton = new System.Windows.Forms.Button();
            this.visualDividerLabel = new System.Windows.Forms.Label();
            this.filePathLabel = new System.Windows.Forms.Label();
            this.columnsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.logoPictureBox.BackgroundImage = global::Excel_to_SQL_Import_Wizard.Properties.Resources.AuNyx_Banner001;
            this.logoPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.logoPictureBox.Location = new System.Drawing.Point(12, 12);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(282, 96);
            this.logoPictureBox.TabIndex = 0;
            this.logoPictureBox.TabStop = false;
            // 
            // headerLabel
            // 
            this.headerLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.headerLabel.AutoSize = true;
            this.headerLabel.BackColor = System.Drawing.Color.Transparent;
            this.headerLabel.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.Location = new System.Drawing.Point(417, 26);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(650, 56);
            this.headerLabel.TabIndex = 1;
            this.headerLabel.Text = "Excel to SQL Import Wizard";
            this.headerLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // settingsLabel1
            // 
            this.settingsLabel1.AutoSize = true;
            this.settingsLabel1.BackColor = System.Drawing.Color.Transparent;
            this.settingsLabel1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsLabel1.Location = new System.Drawing.Point(36, 127);
            this.settingsLabel1.Name = "settingsLabel1";
            this.settingsLabel1.Size = new System.Drawing.Size(129, 32);
            this.settingsLabel1.TabIndex = 5;
            this.settingsLabel1.Text = "Settings";
            // 
            // settingsLabel2
            // 
            this.settingsLabel2.AutoSize = true;
            this.settingsLabel2.BackColor = System.Drawing.Color.Transparent;
            this.settingsLabel2.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsLabel2.Location = new System.Drawing.Point(37, 169);
            this.settingsLabel2.Name = "settingsLabel2";
            this.settingsLabel2.Size = new System.Drawing.Size(353, 25);
            this.settingsLabel2.TabIndex = 3;
            this.settingsLabel2.Text = "SQL Database Connection Settings";
            // 
            // settingsLabel3
            // 
            this.settingsLabel3.AutoSize = true;
            this.settingsLabel3.BackColor = System.Drawing.Color.Transparent;
            this.settingsLabel3.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsLabel3.Location = new System.Drawing.Point(37, 333);
            this.settingsLabel3.Name = "settingsLabel3";
            this.settingsLabel3.Size = new System.Drawing.Size(197, 25);
            this.settingsLabel3.TabIndex = 4;
            this.settingsLabel3.Text = "SQL Table Settings";
            // 
            // uploadLabel
            // 
            this.uploadLabel.AutoSize = true;
            this.uploadLabel.BackColor = System.Drawing.Color.Transparent;
            this.uploadLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uploadLabel.Location = new System.Drawing.Point(36, 603);
            this.uploadLabel.Name = "uploadLabel";
            this.uploadLabel.Size = new System.Drawing.Size(163, 32);
            this.uploadLabel.TabIndex = 5;
            this.uploadLabel.Text = "Import File";
            // 
            // serverNameLabel
            // 
            this.serverNameLabel.AutoSize = true;
            this.serverNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.serverNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serverNameLabel.Location = new System.Drawing.Point(57, 204);
            this.serverNameLabel.Name = "serverNameLabel";
            this.serverNameLabel.Size = new System.Drawing.Size(120, 22);
            this.serverNameLabel.TabIndex = 6;
            this.serverNameLabel.Text = "Server Name:";
            // 
            // databaseNameLabel
            // 
            this.databaseNameLabel.AutoSize = true;
            this.databaseNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.databaseNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.databaseNameLabel.Location = new System.Drawing.Point(423, 204);
            this.databaseNameLabel.Name = "databaseNameLabel";
            this.databaseNameLabel.Size = new System.Drawing.Size(144, 22);
            this.databaseNameLabel.TabIndex = 7;
            this.databaseNameLabel.Text = "Database Name:";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.BackColor = System.Drawing.Color.Transparent;
            this.usernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.Location = new System.Drawing.Point(733, 204);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(97, 22);
            this.usernameLabel.TabIndex = 8;
            this.usernameLabel.Text = "Username:";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.BackColor = System.Drawing.Color.Transparent;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.Location = new System.Drawing.Point(949, 204);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(94, 22);
            this.passwordLabel.TabIndex = 9;
            this.passwordLabel.Text = "Password:";
            // 
            // sqlTableNameLabel
            // 
            this.sqlTableNameLabel.AutoSize = true;
            this.sqlTableNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.sqlTableNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sqlTableNameLabel.Location = new System.Drawing.Point(57, 372);
            this.sqlTableNameLabel.Name = "sqlTableNameLabel";
            this.sqlTableNameLabel.Size = new System.Drawing.Size(113, 22);
            this.sqlTableNameLabel.TabIndex = 10;
            this.sqlTableNameLabel.Text = "Table Name:";
            // 
            // serverInstanceTextBox
            // 
            this.serverInstanceTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.serverInstanceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serverInstanceTextBox.Location = new System.Drawing.Point(61, 230);
            this.serverInstanceTextBox.Name = "serverInstanceTextBox";
            this.serverInstanceTextBox.Size = new System.Drawing.Size(335, 28);
            this.serverInstanceTextBox.TabIndex = 12;
            // 
            // databaseNameTextBox
            // 
            this.databaseNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.databaseNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.databaseNameTextBox.Location = new System.Drawing.Point(427, 230);
            this.databaseNameTextBox.Name = "databaseNameTextBox";
            this.databaseNameTextBox.Size = new System.Drawing.Size(280, 28);
            this.databaseNameTextBox.TabIndex = 13;
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.usernameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTextBox.Location = new System.Drawing.Point(736, 230);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(192, 28);
            this.usernameTextBox.TabIndex = 14;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextBox.Location = new System.Drawing.Point(953, 230);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(192, 28);
            this.passwordTextBox.TabIndex = 15;
            // 
            // tableTextBox
            // 
            this.tableTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tableTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableTextBox.Location = new System.Drawing.Point(61, 398);
            this.tableTextBox.Name = "tableTextBox";
            this.tableTextBox.Size = new System.Drawing.Size(280, 28);
            this.tableTextBox.TabIndex = 16;
            // 
            // columnsTextBox
            // 
            this.columnsTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.columnsTextBox.Location = new System.Drawing.Point(427, 398);
            this.columnsTextBox.Name = "columnsTextBox";
            this.columnsTextBox.Size = new System.Drawing.Size(720, 89);
            this.columnsTextBox.TabIndex = 17;
            this.columnsTextBox.Text = "";
            // 
            // saveSettingsButton1
            // 
            this.saveSettingsButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveSettingsButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveSettingsButton1.Location = new System.Drawing.Point(61, 272);
            this.saveSettingsButton1.Name = "saveSettingsButton1";
            this.saveSettingsButton1.Size = new System.Drawing.Size(158, 35);
            this.saveSettingsButton1.TabIndex = 18;
            this.saveSettingsButton1.Text = "Save";
            this.saveSettingsButton1.UseVisualStyleBackColor = true;
            this.saveSettingsButton1.Click += new System.EventHandler(this.saveSettingsButton1_Click_1);
            // 
            // saveSettingsButton2
            // 
            this.saveSettingsButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveSettingsButton2.Location = new System.Drawing.Point(427, 504);
            this.saveSettingsButton2.Name = "saveSettingsButton2";
            this.saveSettingsButton2.Size = new System.Drawing.Size(158, 35);
            this.saveSettingsButton2.TabIndex = 19;
            this.saveSettingsButton2.Text = "Save";
            this.saveSettingsButton2.UseVisualStyleBackColor = true;
            this.saveSettingsButton2.Click += new System.EventHandler(this.saveSettingsButton2_Click_1);
            // 
            // selectFileButton
            // 
            this.selectFileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectFileButton.Location = new System.Drawing.Point(61, 658);
            this.selectFileButton.Name = "selectFileButton";
            this.selectFileButton.Size = new System.Drawing.Size(158, 35);
            this.selectFileButton.TabIndex = 20;
            this.selectFileButton.Text = "Select File";
            this.selectFileButton.UseVisualStyleBackColor = true;
            this.selectFileButton.Click += new System.EventHandler(this.selectFileButton_Click_1);
            // 
            // uploadDataButton
            // 
            this.uploadDataButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uploadDataButton.Location = new System.Drawing.Point(61, 709);
            this.uploadDataButton.Name = "uploadDataButton";
            this.uploadDataButton.Size = new System.Drawing.Size(158, 35);
            this.uploadDataButton.TabIndex = 21;
            this.uploadDataButton.Text = "Upload";
            this.uploadDataButton.UseVisualStyleBackColor = true;
            this.uploadDataButton.Click += new System.EventHandler(this.uploadDataButton_Click_1);
            // 
            // visualDividerLabel
            // 
            this.visualDividerLabel.AutoSize = true;
            this.visualDividerLabel.BackColor = System.Drawing.Color.Transparent;
            this.visualDividerLabel.Location = new System.Drawing.Point(38, 553);
            this.visualDividerLabel.Name = "visualDividerLabel";
            this.visualDividerLabel.Size = new System.Drawing.Size(1116, 20);
            this.visualDividerLabel.TabIndex = 22;
            this.visualDividerLabel.Text = "_________________________________________________________________________________" +
    "__________________________________________";
            // 
            // filePathLabel
            // 
            this.filePathLabel.AutoSize = true;
            this.filePathLabel.BackColor = System.Drawing.Color.Transparent;
            this.filePathLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filePathLabel.Location = new System.Drawing.Point(229, 665);
            this.filePathLabel.Name = "filePathLabel";
            this.filePathLabel.Size = new System.Drawing.Size(22, 25);
            this.filePathLabel.TabIndex = 23;
            this.filePathLabel.Text = "  ";
            // 
            // columnsLabel
            // 
            this.columnsLabel.AutoSize = true;
            this.columnsLabel.BackColor = System.Drawing.Color.Transparent;
            this.columnsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.columnsLabel.Location = new System.Drawing.Point(423, 372);
            this.columnsLabel.Name = "columnsLabel";
            this.columnsLabel.Size = new System.Drawing.Size(85, 22);
            this.columnsLabel.TabIndex = 24;
            this.columnsLabel.Text = "Columns:";
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::Excel_to_SQL_Import_Wizard.Properties.Resources.BG003;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1258, 764);
            this.Controls.Add(this.columnsLabel);
            this.Controls.Add(this.filePathLabel);
            this.Controls.Add(this.visualDividerLabel);
            this.Controls.Add(this.uploadDataButton);
            this.Controls.Add(this.selectFileButton);
            this.Controls.Add(this.saveSettingsButton2);
            this.Controls.Add(this.saveSettingsButton1);
            this.Controls.Add(this.columnsTextBox);
            this.Controls.Add(this.tableTextBox);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.databaseNameTextBox);
            this.Controls.Add(this.serverInstanceTextBox);
            this.Controls.Add(this.sqlTableNameLabel);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.databaseNameLabel);
            this.Controls.Add(this.serverNameLabel);
            this.Controls.Add(this.uploadLabel);
            this.Controls.Add(this.settingsLabel3);
            this.Controls.Add(this.settingsLabel2);
            this.Controls.Add(this.settingsLabel1);
            this.Controls.Add(this.headerLabel);
            this.Controls.Add(this.logoPictureBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Excel to SQL Import Wizard";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Label settingsLabel1;
        private System.Windows.Forms.Label settingsLabel2;
        private System.Windows.Forms.Label settingsLabel3;
        private System.Windows.Forms.Label uploadLabel;
        private System.Windows.Forms.Label serverNameLabel;
        private System.Windows.Forms.Label databaseNameLabel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label sqlTableNameLabel;
        private System.Windows.Forms.TextBox serverInstanceTextBox;
        private System.Windows.Forms.TextBox databaseNameTextBox;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox tableTextBox;
        private System.Windows.Forms.RichTextBox columnsTextBox;
        private System.Windows.Forms.Button saveSettingsButton1;
        private System.Windows.Forms.Button saveSettingsButton2;
        private System.Windows.Forms.Button selectFileButton;
        private System.Windows.Forms.Button uploadDataButton;
        private System.Windows.Forms.Label visualDividerLabel;
        private System.Windows.Forms.Label filePathLabel;
        private System.Windows.Forms.Label columnsLabel;
    }
}

