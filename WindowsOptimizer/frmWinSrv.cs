using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsOptimizer
{
    public partial class frmWinSrv : Form
    {
        public frmWinSrv()
        {
            InitializeComponent();
        }

        private void frmWinSrv_Load(object sender, EventArgs e)
        {
           
        }

       

        private void btn1_Click(object sender, EventArgs e)
        {
            
            if (DialogResult.Yes == MessageBox.Show("Are you sure you want to continue with this action: Disable Prefetch ?\n\nRemember this can take time so do not close the program.", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                frmMain.cmdstr = WindowsOptimizer.Properties.Resources.prefetchd.ToString();
                frmMain.cmdrun();
                MessageBox.Show("Action complete: Disable Prefetch", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else return;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            
            if (DialogResult.Yes == MessageBox.Show("Are you sure you want to continue with this action: Disable Useless Windows Services ?\n\nRemember this can take time so do not close the program.", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                frmMain.cmdstr = WindowsOptimizer.Properties.Resources.winsrvd.ToString();
                frmMain.shellrun();
                MessageBox.Show("Action complete: Disable Useless Windows Services", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else return;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This action will make copy of current registery keys that will or can be edited after using this program.\n" +
                "This action will take some time depending on your computers performance.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            frmMain.cmdstr = @"Reg export HKLM " + frmDriveC.desktopdir + @"\exportedHKLM.reg";
            frmMain.shellrun();
            frmMain.cmdstr = @"Reg export HKCU " + frmDriveC.desktopdir + @"\exportedHKCU.reg";
            frmMain.shellrun();
            MessageBox.Show("The complete backup of registery keys sent to your desktop. \nThere are 2 .reg backup files for LOCAL MACHINE and CURRENT USER. " +
                "\nIf you ever need to restore your registry keys simply click and run these files. " +
                "\n\nWARNING: Both files needs to be run for a complete backup otherwise you may encounter with some issues. " +
                "\nRestored setting will apply after you restart your computer.","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
           
        }

        private void btn4_Click(object sender, EventArgs e)
        {

            if (DialogResult.Yes == MessageBox.Show("Are you sure you want to continue with this action: Enable Useless Windows Services ?\nThis action will enable all services that been disabled by this program.\n\nRemember this can take time so do not close the program.", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                frmMain.cmdstr = WindowsOptimizer.Properties.Resources.winsrve.ToString();
                frmMain.shellrun();
                MessageBox.Show("Action complete: Enabled Useless Windows Services", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else return;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("This action will disable all possible meta data collection in windows. Be aware that this action can cause problems with some apps also this will take time so do not close the program." +
                "\nAre you sure you want to continue with this action: Disable All Tracking ?\n" +
                "\n\nWARNING: It's highly recommended that you create a backup before this action.", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                frmMain.cmdstr = WindowsOptimizer.Properties.Resources.diagtrack.ToString();
                frmMain.shellrun();
                MessageBox.Show("Action complete: Disable All Tracking", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else return;
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("This action will disable gamebar and anything related to it.\nAre you sure you want to continue with this action: Disable Windows Gamebar ?\nRemember this can take time so do not close the program.\n\nWARNING: It's highly recommended that you create a backup before this action.", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                frmMain.cmdstr = WindowsOptimizer.Properties.Resources.gamedvr.ToString();
                frmMain.shellrun();
                MessageBox.Show("Action complete: Disable Windows Gamebar", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else return;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("This action will disable full screen optimizations globally.\nAre you sure you want to continue with this action: Disable Full Screen Optimizations ?\nRemember this can take time so do not close the program.\n\nWARNING: It's highly recommended that you create a backup before this action.", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                frmMain.cmdstr = WindowsOptimizer.Properties.Resources.fullscroptdis.ToString();
                frmMain.shellrun();
                MessageBox.Show("Action complete: Disable Full Screen Optimizations", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else return;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("This action will enable full screen optimizations globally.\nAre you sure you want to continue with this action: Enable Full Screen Optimizations ?\nRemember this can take time so do not close the program.\n\nWARNING: It's highly recommended that you create a backup before this action.", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                frmMain.cmdstr = WindowsOptimizer.Properties.Resources.fullscropten.ToString();
                frmMain.shellrun();
                MessageBox.Show("Action complete: Enable Full Screen Optimizations", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else return;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("This action will make a duplicate of Ultimate Performance power plan if you have it already it will make another one, are you sure you want to continue ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                frmMain.cmdstr = "powercfg -duplicatescheme e9a42b02-d5df-448d-aa00-03f14749eb61";
                frmMain.cmdrun();
                MessageBox.Show("Ultimate performance battery plan successfully added.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Are you sure you want to continue with this action: Enable TRIM  ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                frmMain.cmdstr = "fsutil behavior set DisableDeleteNotify 0";
                frmMain.cmdrun();
                MessageBox.Show("TRIM is enabled, it is also recommended to increase the frequency TRIM is run for your SSD drive.\n TRIM allows proper maintenance of unused space on SSDs after files have been deleted.\nSearch Optimzie Drive, select your SSD and click change settings, ensure Scheduled Optimization is enabled and set to Daily for each of your drives.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else return;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Are you sure you want to continue with this action: Optimize NTFS File System  ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {

                frmMain.cmdstr = "fsutil behavior set disableLastAccess 1";
                frmMain.cmdrun();
                frmMain.cmdstr = "fsutil behavior set disable8dot3 1";
                frmMain.cmdrun();
                MessageBox.Show("Optimized NTFS file system.This action will require restart to take effect.\nOptimize NTFS file system parameters to reduce updates to some of the metadata that is tracked.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else return;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("This action will disable Windows Defender.\nAre you sure you want to continue with this action: Disable Windows Defender ?\nRemember this can take time so do not close the program.\n\nWARNING: It's highly recommended that you create a backup before this action.", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                frmMain.cmdstr = WindowsOptimizer.Properties.Resources.windefdis.ToString();
                frmMain.shellrun();
                MessageBox.Show("Action complete: Disable Windows Defender", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else return;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("This action will enable Windows Defender.\nAre you sure you want to continue with this action: Enable Windows Defender ?\nRemember this can take time so do not close the program.\n\nWARNING: It's highly recommended that you create a backup before this action.", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                frmMain.cmdstr = WindowsOptimizer.Properties.Resources.windefen.ToString();
                frmMain.shellrun();
                MessageBox.Show("Action complete: Enable Windows Defender", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else return;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("This action will disable background apps run by windows.\nAre you sure you want to continue with this action: Disable Background Apps ?\nRemember this can take time so do not close the program.\n\nWARNING: It's highly recommended that you create a backup before this action.", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                frmMain.cmdstr = WindowsOptimizer.Properties.Resources.bgapps.ToString();
                frmMain.shellrun();
                MessageBox.Show("Action complete: Disable Background Apps", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else return;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("This action will implement MMCSS Tweaks to improve gaming performance.\nAre you sure you want to continue with this action: Apply MMCSS Tweaks ?\nRemember this can take time so do not close the program.\n\nWARNING: It's highly recommended that you create a backup before this action.", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                frmMain.cmdstr = WindowsOptimizer.Properties.Resources.bgapps.ToString();
                frmMain.shellrun();
                MessageBox.Show("Action complete: Apply MMCSS Tweaks", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else return;
        }

        private void button25_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("This action will edit or delete reg keys to improve windows experience and performance.\nAre you sure you want to continue with this action: Optimize Registery Keys ?\nRemember this can take time so do not close the program.\n\nWARNING: It's highly recommended that you create a backup before this action.", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                frmMain.cmdstr = WindowsOptimizer.Properties.Resources.optregkeys.ToString();
                frmMain.shellrun();
                MessageBox.Show("Action complete: Optimize Registery Keys", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else return;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("This action will change Hex latency settings to Smooth.\nAre you sure you want to continue with this action: Hex 16 Smooth ?\nRemember this can take time so do not close the program.\n\nWARNING: It's highly recommended that you create a backup before this action.", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                frmMain.cmdstr = WindowsOptimizer.Properties.Resources.hex16.ToString();
                frmMain.shellrun();
                MessageBox.Show("Action complete: Hex 16 Smooth", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else return;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("This action will change Hex latency settings to Balance.\nAre you sure you want to continue with this action: Hex 25 Smooth ?\nRemember this can take time so do not close the program.\n\nWARNING: It's highly recommended that you create a backup before this action.", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                frmMain.cmdstr = WindowsOptimizer.Properties.Resources.hex25.ToString();
                frmMain.shellrun();
                MessageBox.Show("Action complete: Hex 25 Balance", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else return;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("This action will change Hex latency settings to Default.\nAre you sure you want to continue with this action: Hex 26 Balance ?\nRemember this can take time so do not close the program.\n\nWARNING: It's highly recommended that you create a backup before this action.", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                frmMain.cmdstr = WindowsOptimizer.Properties.Resources.hex26.ToString();
                frmMain.shellrun();
                MessageBox.Show("Action complete: Hex 26 Default", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else return;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("This action will change Hex latency settings to Lowest.\nAre you sure you want to continue with this action: Hex 28 Lowest ?\nRemember this can take time so do not close the program.\n\nWARNING: It's highly recommended that you create a backup before this action.", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                frmMain.cmdstr = WindowsOptimizer.Properties.Resources.hex28.ToString();
                frmMain.shellrun();
                MessageBox.Show("Action complete: Hex 28 Lowest", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else return;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("This action will disable Dynamic Tick, please continue this action if you know what you are doing.\nAre you sure you want to continue with this action: Disable Dynamic Tick ?\nRemember this can take time so do not close the program.", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                frmMain.cmdstr = "bcdedit /set disabledynamictick yes";
                frmMain.cmdrun();
                MessageBox.Show("Action complete: Disable Dynamic Tick", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else return;
            
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("This action will enable Dynamic Tick as it is default.\nAre you sure you want to continue with this action: Disable Dynamic Tick ?\nRemember this can take time so do not close the program.", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                frmMain.cmdstr = "bcdedit /deletevalue disabledynamictick";
                frmMain.cmdrun();
                MessageBox.Show("Action complete: Enable Dynamic Tick", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else return;
            
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("This action will disable Synthetic Timer.\nAre you sure you want to continue with this action: Disable Synthetic Timer ?\nRemember this can take time so do not close the program.", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                frmMain.cmdstr = "bcdedit /set useplatformtick yes";
                frmMain.cmdrun();
                MessageBox.Show("Action complete: Disable Synthetic Timer", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else return;
            
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("This action will enable Synthetic Timer, please continue this action if you know what you are doing.\nAre you sure you want to continue with this action: Enable Synthetic Timer ?\nRemember this can take time so do not close the program.", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                frmMain.cmdstr = "bcdedit /deletevalue useplatformtick";
                frmMain.cmdrun();
                MessageBox.Show("Action complete: Enable Synthetic Timer", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            else return;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("This action will disable Hyper Precision Timer, please continue this action if you know what you are doing.\nAre you sure you want to continue with this action: Disable Hyper Precision Timer ?\nRemember this can take time so do not close the program.", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                frmMain.cmdstr = "bcdedit /set  useplatformclock no";
                frmMain.cmdrun();
                MessageBox.Show("Action complete: Disable Hyper Precision Timer", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else return;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("This action will enable Hyper Precision Timer, please continue this action if you know what you are doing.\nAre you sure you want to continue with this action: Enable Hyper Precision Timer ?\nRemember this can take time so do not close the program.", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                frmMain.cmdstr = "bcdedit /deletevalue useplatformclock";
                frmMain.cmdrun();
                MessageBox.Show("Action complete: Enable Hyper Precision Timer", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            else return;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This action will add Take Ownership option to Context Menu.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            string fileName = frmDriveC.currentdir + "\\add_takeown.reg";
            File.WriteAllText(fileName, Properties.Resources.add_takeown);
            System.Diagnostics.Process.Start(fileName);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This action will remove Take Ownership option to Context Menu.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            string fileName = frmDriveC.currentdir + "\\remove_takeown.reg";
            File.WriteAllText(fileName, Properties.Resources.remove_takeown);
            System.Diagnostics.Process.Start(fileName);
        }

        private void frmWinSrv_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                File.Delete(frmDriveC.currentdir + "\\add_takeown.reg");
                File.Delete(frmDriveC.currentdir + "\\remove_takeown.reg");
            }


            catch
            {
                return;
            }

        }
    }
}
