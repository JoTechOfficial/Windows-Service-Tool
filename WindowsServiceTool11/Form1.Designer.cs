namespace WindowsServiceTool11
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            cpuLabel = new Label();
            gpuLabel = new Label();
            ramLabel = new Label();
            windowsLabel = new Label();
            BiosLabel = new Label();
            btnSoundControlPanel = new Button();
            btnNetworkConnections = new Button();
            btnStartupApps = new Button();
            btnInstalledApps = new Button();
            btnWindowsUpdate = new Button();
            btnDiskCleanup = new Button();
            btnTempFolder = new Button();
            btnDisableMMAgent = new Button();
            bindingSource1 = new BindingSource(components);
            btnDiskManagement = new Button();
            btnDefragmentDrives = new Button();
            btnDisableSystemRestore = new Button();
            btnBluetoothSettings = new Button();
            button1 = new Button();
            chkboxAlwaysOnTop = new CheckBox();
            button2 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // cpuLabel
            // 
            cpuLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            cpuLabel.AutoSize = true;
            cpuLabel.ForeColor = Color.White;
            cpuLabel.Location = new Point(12, 695);
            cpuLabel.Name = "cpuLabel";
            cpuLabel.Size = new Size(68, 30);
            cpuLabel.TabIndex = 0;
            cpuLabel.Text = "label1";
            cpuLabel.TextAlign = ContentAlignment.BottomLeft;
            // 
            // gpuLabel
            // 
            gpuLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            gpuLabel.AutoSize = true;
            gpuLabel.ForeColor = Color.White;
            gpuLabel.Location = new Point(12, 725);
            gpuLabel.Name = "gpuLabel";
            gpuLabel.Size = new Size(68, 30);
            gpuLabel.TabIndex = 1;
            gpuLabel.Text = "label1";
            gpuLabel.TextAlign = ContentAlignment.BottomLeft;
            // 
            // ramLabel
            // 
            ramLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            ramLabel.AutoSize = true;
            ramLabel.ForeColor = Color.White;
            ramLabel.Location = new Point(12, 755);
            ramLabel.Name = "ramLabel";
            ramLabel.Size = new Size(68, 30);
            ramLabel.TabIndex = 2;
            ramLabel.Text = "label1";
            ramLabel.TextAlign = ContentAlignment.BottomLeft;
            // 
            // windowsLabel
            // 
            windowsLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            windowsLabel.AutoSize = true;
            windowsLabel.ForeColor = Color.White;
            windowsLabel.Location = new Point(12, 785);
            windowsLabel.Name = "windowsLabel";
            windowsLabel.Size = new Size(68, 30);
            windowsLabel.TabIndex = 3;
            windowsLabel.Text = "label1";
            windowsLabel.TextAlign = ContentAlignment.BottomLeft;
            // 
            // BiosLabel
            // 
            BiosLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            BiosLabel.AutoSize = true;
            BiosLabel.ForeColor = Color.White;
            BiosLabel.Location = new Point(12, 815);
            BiosLabel.Name = "BiosLabel";
            BiosLabel.Size = new Size(68, 30);
            BiosLabel.TabIndex = 4;
            BiosLabel.Text = "label1";
            BiosLabel.TextAlign = ContentAlignment.BottomLeft;
            // 
            // btnSoundControlPanel
            // 
            btnSoundControlPanel.Anchor = AnchorStyles.Left;
            btnSoundControlPanel.BackColor = Color.FromArgb(55, 55, 55);
            btnSoundControlPanel.Cursor = Cursors.Hand;
            btnSoundControlPanel.FlatAppearance.BorderColor = Color.FromArgb(55, 55, 55);
            btnSoundControlPanel.Font = new Font("Segoe UI", 14.1428576F, FontStyle.Bold);
            btnSoundControlPanel.ForeColor = Color.White;
            btnSoundControlPanel.Location = new Point(154, 154);
            btnSoundControlPanel.Name = "btnSoundControlPanel";
            btnSoundControlPanel.Size = new Size(473, 72);
            btnSoundControlPanel.TabIndex = 9;
            btnSoundControlPanel.Text = "Sound Control Panel";
            btnSoundControlPanel.UseVisualStyleBackColor = false;
            btnSoundControlPanel.Click += btnSoundControlPanel_Click;
            // 
            // btnNetworkConnections
            // 
            btnNetworkConnections.Anchor = AnchorStyles.Left;
            btnNetworkConnections.BackColor = Color.FromArgb(55, 55, 55);
            btnNetworkConnections.Cursor = Cursors.Hand;
            btnNetworkConnections.FlatAppearance.BorderColor = Color.FromArgb(55, 55, 55);
            btnNetworkConnections.FlatAppearance.BorderSize = 0;
            btnNetworkConnections.Font = new Font("Segoe UI", 14.1428576F, FontStyle.Bold);
            btnNetworkConnections.ForeColor = Color.White;
            btnNetworkConnections.Location = new Point(154, 236);
            btnNetworkConnections.Name = "btnNetworkConnections";
            btnNetworkConnections.Size = new Size(473, 72);
            btnNetworkConnections.TabIndex = 10;
            btnNetworkConnections.Text = "Network Settings";
            btnNetworkConnections.UseVisualStyleBackColor = false;
            btnNetworkConnections.Click += btnNetworkConnections_Click;
            // 
            // btnStartupApps
            // 
            btnStartupApps.Anchor = AnchorStyles.Left;
            btnStartupApps.BackColor = Color.FromArgb(55, 55, 55);
            btnStartupApps.Cursor = Cursors.Hand;
            btnStartupApps.FlatAppearance.BorderColor = Color.FromArgb(55, 55, 55);
            btnStartupApps.FlatAppearance.BorderSize = 0;
            btnStartupApps.Font = new Font("Segoe UI", 14.1428576F, FontStyle.Bold);
            btnStartupApps.ForeColor = Color.White;
            btnStartupApps.Location = new Point(154, 400);
            btnStartupApps.Name = "btnStartupApps";
            btnStartupApps.Size = new Size(473, 72);
            btnStartupApps.TabIndex = 12;
            btnStartupApps.Text = "Startup Apps";
            btnStartupApps.UseVisualStyleBackColor = false;
            btnStartupApps.Click += btnStartupApps_Click;
            // 
            // btnInstalledApps
            // 
            btnInstalledApps.Anchor = AnchorStyles.Left;
            btnInstalledApps.BackColor = Color.FromArgb(55, 55, 55);
            btnInstalledApps.Cursor = Cursors.Hand;
            btnInstalledApps.FlatAppearance.BorderColor = Color.FromArgb(55, 55, 55);
            btnInstalledApps.FlatAppearance.BorderSize = 0;
            btnInstalledApps.Font = new Font("Segoe UI", 14.1428576F, FontStyle.Bold);
            btnInstalledApps.ForeColor = Color.White;
            btnInstalledApps.Location = new Point(154, 482);
            btnInstalledApps.Name = "btnInstalledApps";
            btnInstalledApps.Size = new Size(473, 72);
            btnInstalledApps.TabIndex = 13;
            btnInstalledApps.Text = "Installed Apps";
            btnInstalledApps.UseVisualStyleBackColor = false;
            btnInstalledApps.Click += btnInstalledApps_Click;
            // 
            // btnWindowsUpdate
            // 
            btnWindowsUpdate.Anchor = AnchorStyles.Right;
            btnWindowsUpdate.BackColor = Color.FromArgb(55, 55, 55);
            btnWindowsUpdate.Cursor = Cursors.Hand;
            btnWindowsUpdate.FlatAppearance.BorderColor = Color.FromArgb(55, 55, 55);
            btnWindowsUpdate.FlatAppearance.BorderSize = 0;
            btnWindowsUpdate.Font = new Font("Segoe UI", 14.1428576F, FontStyle.Bold);
            btnWindowsUpdate.ForeColor = Color.White;
            btnWindowsUpdate.Location = new Point(818, 154);
            btnWindowsUpdate.Name = "btnWindowsUpdate";
            btnWindowsUpdate.Size = new Size(473, 72);
            btnWindowsUpdate.TabIndex = 15;
            btnWindowsUpdate.Text = "Update Windows";
            btnWindowsUpdate.UseVisualStyleBackColor = false;
            btnWindowsUpdate.Click += btnWindowsUpdate_Click;
            // 
            // btnDiskCleanup
            // 
            btnDiskCleanup.Anchor = AnchorStyles.Right;
            btnDiskCleanup.BackColor = Color.FromArgb(55, 55, 55);
            btnDiskCleanup.Cursor = Cursors.Hand;
            btnDiskCleanup.FlatAppearance.BorderColor = Color.FromArgb(55, 55, 55);
            btnDiskCleanup.FlatAppearance.BorderSize = 0;
            btnDiskCleanup.Font = new Font("Segoe UI", 14.1428576F, FontStyle.Bold);
            btnDiskCleanup.ForeColor = Color.White;
            btnDiskCleanup.Location = new Point(818, 236);
            btnDiskCleanup.Name = "btnDiskCleanup";
            btnDiskCleanup.Size = new Size(473, 72);
            btnDiskCleanup.TabIndex = 16;
            btnDiskCleanup.Text = "Disk Cleanup";
            btnDiskCleanup.UseVisualStyleBackColor = false;
            btnDiskCleanup.Click += btnDiskCleanup_Click;
            // 
            // btnTempFolder
            // 
            btnTempFolder.Anchor = AnchorStyles.Right;
            btnTempFolder.BackColor = Color.FromArgb(55, 55, 55);
            btnTempFolder.Cursor = Cursors.Hand;
            btnTempFolder.FlatAppearance.BorderColor = Color.FromArgb(55, 55, 55);
            btnTempFolder.FlatAppearance.BorderSize = 0;
            btnTempFolder.Font = new Font("Segoe UI", 14.1428576F, FontStyle.Bold);
            btnTempFolder.ForeColor = Color.White;
            btnTempFolder.Location = new Point(818, 400);
            btnTempFolder.Name = "btnTempFolder";
            btnTempFolder.Size = new Size(473, 72);
            btnTempFolder.TabIndex = 18;
            btnTempFolder.Text = "Delete Temp Files";
            btnTempFolder.UseVisualStyleBackColor = false;
            btnTempFolder.Click += btnTempFolder_Click;
            // 
            // btnDisableMMAgent
            // 
            btnDisableMMAgent.Anchor = AnchorStyles.Right;
            btnDisableMMAgent.BackColor = Color.FromArgb(55, 55, 55);
            btnDisableMMAgent.Cursor = Cursors.Hand;
            btnDisableMMAgent.FlatAppearance.BorderColor = Color.FromArgb(55, 55, 55);
            btnDisableMMAgent.FlatAppearance.BorderSize = 0;
            btnDisableMMAgent.Font = new Font("Segoe UI", 14.1428576F, FontStyle.Bold);
            btnDisableMMAgent.ForeColor = Color.White;
            btnDisableMMAgent.Location = new Point(818, 482);
            btnDisableMMAgent.Name = "btnDisableMMAgent";
            btnDisableMMAgent.Size = new Size(473, 72);
            btnDisableMMAgent.TabIndex = 19;
            btnDisableMMAgent.Text = "Disable Ram Compression";
            btnDisableMMAgent.UseVisualStyleBackColor = false;
            btnDisableMMAgent.Click += btnDisableMMAgent_Click;
            // 
            // btnDiskManagement
            // 
            btnDiskManagement.Anchor = AnchorStyles.Left;
            btnDiskManagement.BackColor = Color.FromArgb(55, 55, 55);
            btnDiskManagement.Cursor = Cursors.Hand;
            btnDiskManagement.FlatAppearance.BorderColor = Color.FromArgb(55, 55, 55);
            btnDiskManagement.FlatAppearance.BorderSize = 0;
            btnDiskManagement.Font = new Font("Segoe UI", 14.1428576F, FontStyle.Bold);
            btnDiskManagement.ForeColor = Color.White;
            btnDiskManagement.Location = new Point(154, 564);
            btnDiskManagement.Name = "btnDiskManagement";
            btnDiskManagement.Size = new Size(473, 72);
            btnDiskManagement.TabIndex = 14;
            btnDiskManagement.Text = "Disk Management";
            btnDiskManagement.UseVisualStyleBackColor = false;
            btnDiskManagement.Click += btnDiskManagement_Click;
            // 
            // btnDefragmentDrives
            // 
            btnDefragmentDrives.Anchor = AnchorStyles.Right;
            btnDefragmentDrives.BackColor = Color.FromArgb(55, 55, 55);
            btnDefragmentDrives.Cursor = Cursors.Hand;
            btnDefragmentDrives.FlatAppearance.BorderColor = Color.FromArgb(55, 55, 55);
            btnDefragmentDrives.FlatAppearance.BorderSize = 0;
            btnDefragmentDrives.Font = new Font("Segoe UI", 14.1428576F, FontStyle.Bold);
            btnDefragmentDrives.ForeColor = Color.White;
            btnDefragmentDrives.Location = new Point(818, 318);
            btnDefragmentDrives.Name = "btnDefragmentDrives";
            btnDefragmentDrives.Size = new Size(473, 72);
            btnDefragmentDrives.TabIndex = 17;
            btnDefragmentDrives.Text = "Defragment Drives";
            btnDefragmentDrives.UseVisualStyleBackColor = false;
            btnDefragmentDrives.Click += btnDefragmentDrives_Click;
            // 
            // btnDisableSystemRestore
            // 
            btnDisableSystemRestore.Anchor = AnchorStyles.Right;
            btnDisableSystemRestore.BackColor = Color.FromArgb(55, 55, 55);
            btnDisableSystemRestore.Cursor = Cursors.Hand;
            btnDisableSystemRestore.FlatAppearance.BorderColor = Color.FromArgb(55, 55, 55);
            btnDisableSystemRestore.FlatAppearance.BorderSize = 0;
            btnDisableSystemRestore.Font = new Font("Segoe UI", 14.1428576F, FontStyle.Bold);
            btnDisableSystemRestore.ForeColor = Color.White;
            btnDisableSystemRestore.Location = new Point(818, 564);
            btnDisableSystemRestore.Name = "btnDisableSystemRestore";
            btnDisableSystemRestore.Size = new Size(473, 72);
            btnDisableSystemRestore.TabIndex = 20;
            btnDisableSystemRestore.Text = "Disable System Restore";
            btnDisableSystemRestore.UseVisualStyleBackColor = false;
            btnDisableSystemRestore.Click += btnDisableSystemRestore_Click;
            // 
            // btnBluetoothSettings
            // 
            btnBluetoothSettings.Anchor = AnchorStyles.Left;
            btnBluetoothSettings.BackColor = Color.FromArgb(55, 55, 55);
            btnBluetoothSettings.Cursor = Cursors.Hand;
            btnBluetoothSettings.FlatAppearance.BorderColor = Color.FromArgb(55, 55, 55);
            btnBluetoothSettings.FlatAppearance.BorderSize = 0;
            btnBluetoothSettings.Font = new Font("Segoe UI", 14.1428576F, FontStyle.Bold);
            btnBluetoothSettings.ForeColor = Color.White;
            btnBluetoothSettings.Location = new Point(154, 318);
            btnBluetoothSettings.Name = "btnBluetoothSettings";
            btnBluetoothSettings.Size = new Size(473, 72);
            btnBluetoothSettings.TabIndex = 11;
            btnBluetoothSettings.Text = "Bluetooth Settings";
            btnBluetoothSettings.UseVisualStyleBackColor = false;
            btnBluetoothSettings.Click += btnBluetoothSettings_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top;
            button1.BackColor = Color.FromArgb(30, 30, 30);
            button1.FlatAppearance.BorderColor = Color.FromArgb(30, 30, 30);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(30, 30, 30);
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 30, 30);
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.FromArgb(30, 30, 30);
            button1.Location = new Point(154, 3);
            button1.Name = "button1";
            button1.Size = new Size(1137, 10);
            button1.TabIndex = 8;
            button1.UseVisualStyleBackColor = false;
            // 
            // chkboxAlwaysOnTop
            // 
            chkboxAlwaysOnTop.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            chkboxAlwaysOnTop.AutoSize = true;
            chkboxAlwaysOnTop.Cursor = Cursors.Hand;
            chkboxAlwaysOnTop.FlatAppearance.BorderSize = 0;
            chkboxAlwaysOnTop.ForeColor = Color.White;
            chkboxAlwaysOnTop.Location = new Point(1256, 811);
            chkboxAlwaysOnTop.Name = "chkboxAlwaysOnTop";
            chkboxAlwaysOnTop.Size = new Size(176, 34);
            chkboxAlwaysOnTop.TabIndex = 21;
            chkboxAlwaysOnTop.Text = "Always On Top";
            chkboxAlwaysOnTop.UseVisualStyleBackColor = true;
            chkboxAlwaysOnTop.CheckedChanged += chkboxAlwaysOnTop_CheckedChanged;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Left;
            button2.BackColor = Color.FromArgb(30, 30, 30);
            button2.FlatAppearance.BorderColor = Color.FromArgb(30, 30, 30);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.FromArgb(30, 30, 30);
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 30, 30);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 26.1428585F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(154, 44);
            button2.Name = "button2";
            button2.Size = new Size(473, 104);
            button2.TabIndex = 22;
            button2.Text = "Easy Access";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Right;
            button3.BackColor = Color.FromArgb(30, 30, 30);
            button3.FlatAppearance.BorderColor = Color.FromArgb(30, 30, 30);
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.MouseDownBackColor = Color.FromArgb(30, 30, 30);
            button3.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 30, 30);
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 26.1428585F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(818, 44);
            button3.Name = "button3";
            button3.Size = new Size(473, 104);
            button3.TabIndex = 23;
            button3.Text = "Windows Tools";
            button3.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            ClientSize = new Size(1444, 854);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(chkboxAlwaysOnTop);
            Controls.Add(button1);
            Controls.Add(btnBluetoothSettings);
            Controls.Add(btnDisableSystemRestore);
            Controls.Add(btnDefragmentDrives);
            Controls.Add(btnDiskManagement);
            Controls.Add(btnDisableMMAgent);
            Controls.Add(btnTempFolder);
            Controls.Add(btnDiskCleanup);
            Controls.Add(btnWindowsUpdate);
            Controls.Add(btnInstalledApps);
            Controls.Add(btnStartupApps);
            Controls.Add(btnNetworkConnections);
            Controls.Add(btnSoundControlPanel);
            Controls.Add(BiosLabel);
            Controls.Add(windowsLabel);
            Controls.Add(ramLabel);
            Controls.Add(gpuLabel);
            Controls.Add(cpuLabel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            Text = "Windows Service Tool";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label cpuLabel;
        private Label gpuLabel;
        private Label ramLabel;
        private Label windowsLabel;
        private Label BiosLabel;
        private Button btnSoundControlPanel;
        private Button btnNetworkConnections;
        private Button btnStartupApps;
        private Button btnInstalledApps;
        private Button btnWindowsUpdate;
        private Button btnDiskCleanup;
        private Button btnTempFolder;
        private Button btnDisableMMAgent;
        private BindingSource bindingSource1;
        private Button btnDiskManagement;
        private Button btnDefragmentDrives;
        private Button btnDisableSystemRestore;
        private Button btnBluetoothSettings;
        private Button button1;
        private CheckBox chkboxAlwaysOnTop;
        private Button button2;
        private Button button3;
    }
}
