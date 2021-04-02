using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsOptimizer
{
    public partial class frmWinApps : Form
    {
        public frmWinApps()
        {
            InitializeComponent();
        }
        string[] itemlissdsd = { };
        List<string> itemlist = new List<string>();
        private string test;
        private CheckBox cba;
        
        private void checkBox38_CheckedChanged(object sender, EventArgs e)
        {

        }
        void unselect()
        {
            foreach (CheckBox cb in panelservicelist.Controls)
            {
                cb.Checked = false;
            }
            foreach (CheckBox cb2 in panelother.Controls)
            {
                cb2.Checked = false;
            }
        }
        void selrec()
        {
            unselect();
            foreach (CheckBox cb in panelservicelist.Controls)
            {
                cb.Checked = true;
            }
        }
        void cbactive(object obj)
        {
            cba = obj as CheckBox;
            if (cba.Checked == true)
            {
                cba.ForeColor = Color.Yellow;
            }
            else
                cba.ForeColor = Color.White;
        }
        void selectall()
        {
            foreach (CheckBox cb in panelservicelist.Controls)
            {
                cb.Checked = true;
            }
            foreach (CheckBox cb2 in panelother.Controls)
            {
                cb2.Checked = true;
            }
        }
        
        void uninstallselected()
        {
            itemlist.Clear();
            test = "";


            foreach (CheckBox cb in panelservicelist.Controls) { 
                if (cb.Checked == true)
                {
                    
                    switch (cb.Text)
                    {
                        case "3D Viewer":                            
                            frmMain.cmdstr = "Get-AppxPackage Microsoft.Microsoft3DViewer | Remove-AppxPackage";
                            frmMain.shellrun();
                            itemlist.Add(cb.Text);
                            break;
                        case "Skype":
                            frmMain.cmdstr = "Get-AppxPackage Microsoft.SkypeApp | Remove-AppxPackage";
                            frmMain.shellrun();
                            itemlist.Add(cb.Text);
                            break;
                        case "Maps":
                            frmMain.cmdstr = "Get-AppxPackage Microsoft.WindowsMaps | Remove-AppxPackage";
                            frmMain.shellrun();
                            itemlist.Add(cb.Text);
                            break;
                        case "Get Started":
                            frmMain.cmdstr = "Get-AppxPackage Microsoft.Getstarted | Remove-AppxPackage";
                            frmMain.shellrun();
                            itemlist.Add(cb.Text);
                            break;
                        case "YourPhone":
                            frmMain.cmdstr = "Get-AppxPackage Microsoft.YourPhone | Remove-AppxPackage";
                            frmMain.shellrun();
                            itemlist.Add(cb.Text);
                            break;
                        case "Money":
                            frmMain.cmdstr = "Get-AppxPackage *bingfinance* | Remove-AppxPackage";
                            frmMain.shellrun();
                            itemlist.Add(cb.Text);
                            break;
                        case "Wallet":
                            frmMain.cmdstr = "Get-AppxPackage Microsoft.Wallet | Remove-AppxPackage";
                            frmMain.shellrun();
                            itemlist.Add(cb.Text);
                            break;
                        case "News":
                            frmMain.cmdstr = "Get-AppxPackage Microsoft.BingNews | Remove-AppxPackage";
                            frmMain.shellrun();
                            itemlist.Add(cb.Text);
                            break;
                        case "People":
                            frmMain.cmdstr = "Get-AppxPackage Microsoft.People | Remove-AppxPackage ";
                            frmMain.shellrun();
                            itemlist.Add(cb.Text);
                            break;
                        case "Phone Companion":
                            frmMain.cmdstr = "Get-AppxPackage *windowsphone* | Remove-AppxPackage";
                            frmMain.shellrun();
                            itemlist.Add(cb.Text);
                            break;
                        case "Sports":
                            frmMain.cmdstr = "Get-AppxPackage *bingsports* | Remove-AppxPackage";
                            frmMain.shellrun();
                            itemlist.Add(cb.Text);
                            break;
                        case "Weather":
                            frmMain.cmdstr = "Get-AppxPackage Microsoft.BingWeather | Remove-AppxPackage";
                            frmMain.shellrun();
                            itemlist.Add(cb.Text);
                            break;
                        case "Get Help":
                            frmMain.cmdstr = "Get-AppxPackage Microsoft.GetHelp | Remove-AppxPackage";
                            frmMain.shellrun();
                            itemlist.Add(cb.Text);
                            break;
                        case "Fitbit":
                            frmMain.cmdstr = "Get-AppxPackage *fitbit* | Remove-AppxPackage";
                            frmMain.shellrun();
                            itemlist.Add(cb.Text);
                            break;
                        case "Netflix":
                            frmMain.cmdstr = "Get-AppxPackage *netflix* | Remove-AppxPackage";
                            frmMain.shellrun();
                            itemlist.Add(cb.Text);
                            break;
                        case "Bing":
                            frmMain.cmdstr = "Get-AppxPackage *bing* | Remove-AppxPackage";
                            frmMain.shellrun();
                            itemlist.Add(cb.Text);
                            break;
                        case "Dolby":
                            frmMain.cmdstr = "Get-AppxPackage *dolby* | Remove-AppxPackage";
                            frmMain.shellrun();
                            itemlist.Add(cb.Text);
                            break;
                        case "Get Office":
                            frmMain.cmdstr = "Get-AppxPackage *officehub* | Remove-AppxPackage";
                            frmMain.shellrun();
                            itemlist.Add(cb.Text);
                            break;
                        case "Mail":
                            frmMain.cmdstr = "Get-AppxPackage Microsoft.windowscommunicationsapps | Remove-AppxPackage";
                            frmMain.shellrun();
                            itemlist.Add(cb.Text);
                            break;
                        case "Camera":
                            frmMain.cmdstr = "Get-AppxPackage Microsoft.WindowsCamera | Remove-AppxPackage";
                            frmMain.shellrun();
                            itemlist.Add(cb.Text);
                            break;
                        case "StickyNotes":
                            frmMain.cmdstr = "Get-AppxPackage Microsoft.MicrosoftStickyNotes | Remove-AppxPackage";
                            frmMain.shellrun();
                            itemlist.Add(cb.Text);
                            break;
                        case "Alarm and Clock":
                            frmMain.cmdstr = "Get-AppxPackage Microsoft.WindowsAlarms | Remove-AppxPackage";
                            frmMain.shellrun();
                            itemlist.Add(cb.Text);
                            break;
                        case "Solitaire Collection":
                            frmMain.cmdstr = "Get-AppxPackage Microsoft.MicrosoftSolitaireCollection | Remove-AppxPackage";
                            frmMain.shellrun();
                            itemlist.Add(cb.Text);
                            break;
                        case "OneDrive":
                            frmMain.cmdstr = "ps onedrive | Stop-Process -Force";
                            frmMain.shellrun();
                            frmMain.cmdstr = WindowsOptimizer.Properties.Resources.onedrivereg.ToString(); ;
                            frmMain.shellrun();
                            frmMain.cmdstr = "start-process \"$env: windir\\SysWOW64\\OneDriveSetup.exe\" \" / uninstall\"";
                            frmMain.shellrun();
                            itemlist.Add(cb.Text);
                            break;
                        case "OneNote":
                            frmMain.cmdstr = "Get-AppxPackage Microsoft.Office.OneNote | Remove-AppxPackage";
                            frmMain.shellrun();
                            itemlist.Add(cb.Text);
                            break;
                        case "Feedback Hub":
                            frmMain.cmdstr = "Get-AppxPackage Microsoft.WindowsFeedbackHub | Remove-AppxPackage";
                            frmMain.shellrun();
                            itemlist.Add(cb.Text);
                            break;
                        case "Messaging":
                            frmMain.cmdstr = "Get - AppxPackage Microsoft.Messaging | Remove - AppxPackage";
                            frmMain.shellrun();
                            itemlist.Add(cb.Text);
                            break;
                            
                    }


                }
                else
                {
                    continue;
                }

            }

            foreach (CheckBox cb in panelother.Controls)
            {

                if (cb.Checked == true)
                {
                    switch (cb.Text)
                    {
                        case "Calculator":
                            frmMain.cmdstr = "Get-AppxPackage *windowscalculator* | Remove-AppxPackage";
                            frmMain.shellrun();
                            itemlist.Add(cb.Text);
                            break;
                        case "Xbox":
                            frmMain.cmdstr = "Get-AppxPackage Microsoft.XboxApp | Remove-AppxPackage";
                            frmMain.shellrun();
                            itemlist.Add(cb.Text);
                            break;
                        case "Paint":
                            frmMain.cmdstr = "Get-AppxPackage Microsoft.Windows.MSPaint | Remove-AppxPackage";
                            frmMain.shellrun();
                            itemlist.Add(cb.Text);
                            break;
                        case "Store":
                            frmMain.cmdstr = "Get-AppxPackage *windowsstore* | Remove-AppxPackage";
                            frmMain.shellrun();
                            itemlist.Add(cb.Text);
                            break;
                        case "Photos":
                            frmMain.cmdstr = "Get-AppxPackage *photos* | Remove-AppxPackage";
                            frmMain.shellrun();
                            itemlist.Add(cb.Text);
                            break;
                        case "Movies and TV":
                            frmMain.cmdstr = "Get-AppxPackage Microsoft.ZuneVideo | Remove-AppxPackage";
                            frmMain.shellrun();
                            itemlist.Add(cb.Text);
                            break;
                        case "Groove Music":
                            frmMain.cmdstr = "Get-AppxPackage Microsoft.ZuneMusic | Remove-AppxPackage";
                            frmMain.shellrun();
                            itemlist.Add(cb.Text);
                            break;
                        case "Sound Recorder":
                            frmMain.cmdstr = "Get-AppxPackage Microsoft.WindowsSoundRecorder | Remove-AppxPackage";
                            frmMain.shellrun();
                            itemlist.Add(cb.Text);
                            break;
                        case "Screen Sketch":
                            frmMain.cmdstr = "Get-AppxPackage Microsoft.ScreenSketch | Remove-AppxPackage";
                            frmMain.shellrun();
                            itemlist.Add(cb.Text);
                            break;
                            
                    }

                }
                else continue;
            }
            for (int i = 0; i < itemlist.Count; i++)
            {
              test =  test +  "\n" + itemlist[i];
                
            }
            if (test != "")
            {
                MessageBox.Show("Listed apps deleted successfully; " + test);
            }
            else
            {
                MessageBox.Show("Please select apps to delete");
            }            



        }
        private void btnrecommend_Click(object sender, EventArgs e)
        {
            
            selrec();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            unselect();
        }

        private void btnall_Click(object sender, EventArgs e)
        {
            selectall();
            
        }

        private void cbDisableInf_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void frmWinServices_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Are you sure you want to uninstall selected apps ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                uninstallselected();
            }
            else return;
            
        }

        private void btnreinstall_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Are you sure you want to reinstall Windows apps package ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                frmMain.cmdstr = "Get-AppxPackage -AllUsers| Foreach {Add-AppxPackage -DisableDevelopmentMode -Register \"$($_.InstallLocation)\\AppXManifest.xml\"}";
                frmMain.shellrun();
                MessageBox.Show("Windows apps package successfully installed.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else return; 
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            cbactive(sender);
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            cbactive(sender);
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            cbactive(sender);
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            cbactive(sender);
        }

        private void checkBox20_CheckedChanged(object sender, EventArgs e)
        {
            cbactive(sender);
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            cbactive(sender);
        }

        private void checkBox26_CheckedChanged(object sender, EventArgs e)
        {
            cbactive(sender);
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            cbactive(sender);
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            cbactive(sender);
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            cbactive(sender);
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            cbactive(sender);
        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            cbactive(sender);
        }

        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {
            cbactive(sender);
        }

        private void checkBox19_CheckedChanged(object sender, EventArgs e)
        {
            cbactive(sender);
        }

        private void checkBox16_CheckedChanged(object sender, EventArgs e)
        {
            cbactive(sender);
        }

        private void checkBox17_CheckedChanged(object sender, EventArgs e)
        {
            cbactive(sender);
        }

        private void checkBox18_CheckedChanged(object sender, EventArgs e)
        {
            cbactive(sender);
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            cbactive(sender);
        }

        private void checkBox21_CheckedChanged(object sender, EventArgs e)
        {
            cbactive(sender);
        }

        private void checkBox23_CheckedChanged(object sender, EventArgs e)
        {
            cbactive(sender);
        }

        private void checkBox24_CheckedChanged(object sender, EventArgs e)
        {
            cbactive(sender);
        }

        private void checkBox25_CheckedChanged(object sender, EventArgs e)
        {
            cbactive(sender);
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            cbactive(sender);
        }

        private void checkBox39_CheckedChanged(object sender, EventArgs e)
        {
            cbactive(sender);
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            cbactive(sender);
        }

        private void checkBox22_CheckedChanged(object sender, EventArgs e)
        {
            cbactive(sender);
        }

        private void checkBox28_CheckedChanged(object sender, EventArgs e)
        {
            cbactive(sender);
        }

        private void checkBox35_CheckedChanged(object sender, EventArgs e)
        {
            cbactive(sender);
        }

        private void checkBox29_CheckedChanged(object sender, EventArgs e)
        {
            cbactive(sender);
        }

        private void checkBox41_CheckedChanged(object sender, EventArgs e)
        {
            cbactive(sender);
        }

        private void checkBox34_CheckedChanged(object sender, EventArgs e)
        {
            cbactive(sender);
        }

        private void checkBox31_CheckedChanged(object sender, EventArgs e)
        {
            cbactive(sender);
        }

        private void checkBox33_CheckedChanged(object sender, EventArgs e)
        {
            cbactive(sender);
        }

        private void checkBox32_CheckedChanged(object sender, EventArgs e)
        {
            cbactive(sender);
        }

        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {
            cbactive(sender);
        }

        private void checkBox27_CheckedChanged(object sender, EventArgs e)
        {
            cbactive(sender);
        }
    }
}
