using System;
using System.Drawing;
using System.Diagnostics;
using System.Threading;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;

namespace WindowsServiceTool11
{
    public partial class Form1 : Form
    {
        private NotifyIcon notifyIcon;
        private ContextMenuStrip contextMenuStrip;
        private bool runOnStartup = false;
        private const string RegistryKeyPath = @"SOFTWARE\WindowsServiceTool11";
        private const string AlwaysOnTopRegistryValueName = "AlwaysOnTop";
        private static Mutex mutex = new Mutex(true, "{E8B8C952-47D9-4BE9-81B4-05912365F7A7}");

        public Form1()
        {
            // Attempt to create a named mutex
            bool createdNew;
            mutex = new Mutex(true, "WindowsServiceTool11Mutex", out createdNew);

            if (!createdNew)
            {
                // If another instance is already running, notify the user and exit
                MessageBox.Show("An instance of the application is already running.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Close();
                return;
            }

            InitializeComponent();
            InitializeSystemTray();
            LoadAlwaysOnTopSetting();

            // Apply dark theme color to the form background
            this.BackColor = Color.FromArgb(30, 30, 30);

            // Subscribe to the FormClosing event
            this.FormClosing += Form1_FormClosing;

            // Subscribe to the MouseClick event of the NotifyIcon
            notifyIcon.MouseClick += NotifyIcon_MouseClick;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Cancel the closing event to prevent the form from being closed
            e.Cancel = true;

            // Hide the form instead of minimizing it to the taskbar
            this.Hide();
        }

        private void NotifyIcon_MouseClick(object sender, MouseEventArgs e)
        {
            // Check if the left mouse button was clicked
            if (e.Button == MouseButtons.Left)
            {
                // Show the form
                this.Show();
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void InitializeSystemTray()
        {
            // Create NotifyIcon
            notifyIcon = new NotifyIcon();
            notifyIcon.Icon = new Icon(@"C:\Users\Futanarly\source\repos\WindowsServiceTool11\WSTIcon.ico"); // Specify the path to your icon file
            notifyIcon.Visible = true;

            // Create ContextMenuStrip
            contextMenuStrip = new ContextMenuStrip();

            // Create ToolStripMenuItems for each website
            ToolStripMenuItem menuItemWebsites = new ToolStripMenuItem("Websites");
            ToolStripMenuItem websiteItem1 = new ToolStripMenuItem("Github");
            ToolStripMenuItem websiteItem2 = new ToolStripMenuItem("X");

            // Add Click event handler to each website menu item
            websiteItem1.Click += (sender, e) =>
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = "cmd.exe",
                    Arguments = "/c start https://github.com/JoTechOfficial",
                    CreateNoWindow = true,
                    WindowStyle = ProcessWindowStyle.Hidden
                });
            };

            websiteItem2.Click += (sender, e) =>
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = "cmd.exe",
                    Arguments = "/c start https://x.com/JoTechOfficial",
                    CreateNoWindow = true,
                    WindowStyle = ProcessWindowStyle.Hidden
                });
            };

            // Add website menu items to the main menu item
            menuItemWebsites.DropDownItems.Add(websiteItem1);
            menuItemWebsites.DropDownItems.Add(websiteItem2);

            // Add the main menu item to the ContextMenuStrip
            contextMenuStrip.Items.Add(menuItemWebsites);

            // Add Run on Startup menu item
            ToolStripMenuItem runOnStartupMenuItem = new ToolStripMenuItem("Run on Startup");
            runOnStartupMenuItem.Click += ToggleRunOnStartup;
            contextMenuStrip.Items.Add(runOnStartupMenuItem);

            // Add Exit menu item
            contextMenuStrip.Items.Add("Exit", null, ExitApplication);

            // Assign ContextMenuStrip to NotifyIcon
            notifyIcon.ContextMenuStrip = contextMenuStrip;

            // Load the current startup setting
            LoadStartupSetting();
        }

        private void ToggleRunOnStartup(object sender, EventArgs e)
        {
            runOnStartup = !runOnStartup;
            UpdateStartupSetting(runOnStartup);
            UpdateRunOnStartupMenuItem();
        }

        private void UpdateRunOnStartupMenuItem()
        {
            foreach (ToolStripMenuItem item in contextMenuStrip.Items)
            {
                if (item.Text == "Run on Startup")
                {
                    item.Checked = runOnStartup;
                    return;
                }
            }
        }

        private void LoadStartupSetting()
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", true);
            runOnStartup = key.GetValue("Windows Service Tool") != null;
            UpdateRunOnStartupMenuItem();
        }

        private void UpdateStartupSetting(bool runOnStartup)
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", true);
            if (runOnStartup)
            {
                key.SetValue("Windows Service Tool", Application.ExecutablePath);
            }
            else
            {
                // Remove the value from the startup registry
                if (key.GetValue("Windows Service Tool") != null)
                {
                    key.DeleteValue("Windows Service Tool", false);
                }
            }
        }

        private void ExitApplication(object sender, EventArgs e)
        {
            // Cleanup and force exit the application
            notifyIcon.Dispose();
            Environment.Exit(0);
        }

        private void LoadAlwaysOnTopSetting()
        {
            // Load the always on top setting from the registry
            using (RegistryKey key = Registry.CurrentUser.OpenSubKey(RegistryKeyPath))
            {
                if (key != null)
                {
                    object value = key.GetValue(AlwaysOnTopRegistryValueName);
                    if (value != null && bool.TryParse(value.ToString(), out bool alwaysOnTop))
                    {
                        chkboxAlwaysOnTop.Checked = alwaysOnTop; // Set the checkbox state based on the loaded setting
                        this.TopMost = alwaysOnTop; // Set the TopMost property of the form based on the loaded setting
                    }
                }
            }
        }

        private void SaveAlwaysOnTopSetting(bool alwaysOnTop)
        {
            // Save the always on top setting to the registry
            using (RegistryKey key = Registry.CurrentUser.CreateSubKey(RegistryKeyPath))
            {
                if (key != null)
                {
                    key.SetValue(AlwaysOnTopRegistryValueName, alwaysOnTop);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                // Retrieve CPU information using PowerShell
                string cpuInfo = ExecutePowerShellCommand("Get-WmiObject Win32_Processor | Select-Object -ExpandProperty Name");
                cpuLabel.Text = "CPU: " + cpuInfo;

                // Retrieve GPU information using Environment class
                string gpuInfo = GetGPUName();
                gpuLabel.Text = "GPU: " + gpuInfo;

                // Retrieve RAM information using Environment class
                string ramInfo = GetTotalPhysicalMemory();
                ramLabel.Text = "Total System RAM: " + ramInfo;

                // Retrieve Windows build information
                string windowsVersion = GetWindowsBuildVersion();
                windowsLabel.Text = "OS Version: " + windowsVersion;

                // Retrieve BIOS information using PowerShell
                string biosInfo = GetBiosInformation();
                BiosLabel.Text = "Mobo Name/BIOS Version: " + biosInfo;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string ExecutePowerShellCommand(string command)
        {
            StringBuilder output = new StringBuilder();
            using (Process process = new Process())
            {
                process.StartInfo.FileName = "powershell.exe";
                process.StartInfo.Arguments = $"-Command \"{command}\"";
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.RedirectStandardOutput = true;
                process.StartInfo.CreateNoWindow = true;
                process.Start();

                while (!process.StandardOutput.EndOfStream)
                {
                    output.AppendLine(process.StandardOutput.ReadLine());
                }
            }
            return output.ToString();
        }

        private string GetGPUName()
        {
            string powerShellScript = @"
                $gpuInfo = Get-WmiObject Win32_VideoController | Select-Object -ExpandProperty Name
                if ($gpuInfo -eq $null) {
                    Write-Host 'N/A'
                } else {
                    Write-Host $gpuInfo
                }
            ";

            string powerShellExecutable = Path.Combine(Environment.SystemDirectory, "WindowsPowerShell\\v1.0\\powershell.exe");
            string arguments = $"-NoProfile -ExecutionPolicy unrestricted -Command \"{powerShellScript}\"";

            ProcessStartInfo processStartInfo = new ProcessStartInfo(powerShellExecutable, arguments)
            {
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            using (Process process = Process.Start(processStartInfo))
            {
                process.WaitForExit();
                string output = process.StandardOutput.ReadToEnd();
                return output.Trim();
            }
        }

        private string GetTotalPhysicalMemory()
        {
            ulong totalRam = new Microsoft.VisualBasic.Devices.ComputerInfo().TotalPhysicalMemory;
            double totalRamInGB = (double)totalRam / (1024 * 1024 * 1024);
            return $"{totalRamInGB:N2} GB";
        }

        private string GetWindowsBuildVersion()
        {
            Version osVersion = Environment.OSVersion.Version;
            string versionString = osVersion.ToString();
            string buildNumber = osVersion.Build.ToString();
            return $"{versionString} (Build {buildNumber})";
        }

        private string GetBiosInformation()
        {
            string biosInfo = ExecutePowerShellCommand(@"
        $bios = Get-WmiObject Win32_BIOS
        $model = $bios.SMBIOSBIOSVersion

        $baseboard = Get-WmiObject Win32_BaseBoard
        $baseboardProduct = $baseboard.Product
        $baseboardProduct + ' ' + $model
    ");

            return biosInfo.Trim();
        }

        private void btnDisableMMAgent_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Click Yes If You Have 16GB Of Ram Or More, Click No If You Don't.", "CAUTION: ONLY RUN ONCE", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start("CMD.exe", "/C powershell -Command Start-Process PowerShell -Verb RunAs");
                Clipboard.SetText("Disable-MMAgent -mc");

                DateTime Tthen = DateTime.Now;
                do
                {
                    Application.DoEvents();
                } while (Tthen.AddSeconds(1.35) > DateTime.Now);

                MessageBox.Show(new Form() { TopMost = true }, "In Powershell Press (Ctrl & V) at the same time, and then hit enter");
            }
            else if (dialogResult == DialogResult.No)
            {
                this.Visible = true;
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void btnTempFolder_Click(object sender, EventArgs e)
        {
            {
                // Open Temp Folder For User To See
                ProcessStartInfo psiOpenTempFolder = new ProcessStartInfo
                {
                    FileName = "cmd.exe",
                    Arguments = "/c start %TEMP%",
                    UseShellExecute = false,
                    CreateNoWindow = true
                };

                // Start the process to open the temp folder
                Process.Start(psiOpenTempFolder);

                // Delete Temp Files
                ProcessStartInfo psiDeleteTempFiles = new ProcessStartInfo
                {
                    FileName = "cmd.exe",
                    Arguments = "/c rd /s /q %TEMP%",
                    UseShellExecute = false,
                    CreateNoWindow = true
                };

                // Start the process to delete temp files
                Process.Start(psiDeleteTempFiles);

                DateTime Tthen = DateTime.Now;
                do
                {
                    Application.DoEvents();
                } while (Tthen.AddSeconds(3) > DateTime.Now);

                using (var successMessageBox = new Form())
                {
                    successMessageBox.TopMost = true;
                    MessageBox.Show(successMessageBox, "Temporary folder opened and files deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnDiskCleanup_Click(object sender, EventArgs e)
        {
            Process.Start("cleanmgr.exe");
        }

        private void btnWindowsUpdate_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "cmd.exe",
                Arguments = "/c start ms-settings:windowsupdate",
                CreateNoWindow = true,
                WindowStyle = ProcessWindowStyle.Hidden
            });
            DateTime Tthen = DateTime.Now;
            do
            {
                Application.DoEvents();
            } while (Tthen.AddSeconds(3) > DateTime.Now);
            Process.Start(new ProcessStartInfo
            {
                FileName = "UsoClient.exe",
                Arguments = "StartInteractiveScan",
                Verb = "runas" // Run as administrator
            });
        }

        private void btnInstalledApps_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "cmd.exe",
                Arguments = "/c start ms-settings:appsfeatures",
                CreateNoWindow = true,
                WindowStyle = ProcessWindowStyle.Hidden
            });
        }

        private void btnStartupApps_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "cmd.exe",
                Arguments = "/c start ms-settings:startupapps",
                CreateNoWindow = true,
                WindowStyle = ProcessWindowStyle.Hidden
            });
        }

        private void btnNetworkConnections_Click(object sender, EventArgs e)
        {
            Process.Start("control.exe", "ncpa.cpl");
        }

        private void btnSoundControlPanel_Click(object sender, EventArgs e)
        {
            Process.Start("control", "/name Microsoft.Sound");
        }

        private void btnDiskManagement_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "cmd.exe",
                Arguments = "/c start diskmgmt.msc",
                CreateNoWindow = true,
                WindowStyle = ProcessWindowStyle.Hidden
            });
        }

        private void btnDefragmentDrives_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "cmd.exe",
                Arguments = "/c start dfrgui",
                CreateNoWindow = true,
                WindowStyle = ProcessWindowStyle.Hidden
            });
        }

        private void btnDisableSystemRestore_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "cmd.exe",
                Arguments = "/c start control sysdm.cpl,,4",
                CreateNoWindow = true,
                WindowStyle = ProcessWindowStyle.Hidden
            });
        }

        private void btnBluetoothSettings_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "cmd.exe",
                Arguments = "/c start ms-settings:bluetooth",
                CreateNoWindow = true,
                WindowStyle = ProcessWindowStyle.Hidden
            });
        }

        private void chkboxAlwaysOnTop_CheckedChanged(object sender, EventArgs e)
        {
            this.TopMost = chkboxAlwaysOnTop.Checked; // Set the TopMost property of the form based on the checkbox state
            SaveAlwaysOnTopSetting(chkboxAlwaysOnTop.Checked); // Save the always on top setting to registry
        }
    }
}