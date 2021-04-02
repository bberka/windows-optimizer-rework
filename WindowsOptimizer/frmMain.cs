using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace WindowsOptimizer
{
    public partial class frmMain : Form
    {
        private Form activeFrm;
        private Button currentBtn;
        public static string cmdstr;
        public static string path;
       
        public frmMain()
        {
            InitializeComponent();
        }

        #region chilform
        private void ActiveBtn(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentBtn != (Button)btnSender)
                {
                    DisableBtn();
                    currentBtn = (Button)btnSender;
                    currentBtn.Enabled = false;
                    
                }
            }
        }
        private void DisableBtn()
        {
            foreach(Control pBtn in leftpanel.Controls)
            {
                if (pBtn.GetType() == typeof(Button))
                {
                    pBtn.Enabled = true;
                }
            }
        }
        private void OpenChildForm(Form childFrm, object senderBtn)
        {
            if (activeFrm!=null)
            {
                activeFrm.Close();
            }
            //this.Width = MinimumSize.Width;
            //this.Height = MinimumSize.Height;
            ActiveBtn(senderBtn);
            activeFrm = childFrm;
            childFrm.TopLevel = false;
            childFrm.FormBorderStyle = FormBorderStyle.None;
            childFrm.Dock = DockStyle.Fill;
            this.panelChild.Controls.Add(childFrm);
            this.panelChild.Tag = childFrm;
            this.Height = MinimumSize.Height + (childFrm.Height  - MinimumSize.Height) +40;
            this.Width = 185 + childFrm.Width;
            childFrm.BringToFront();
            childFrm.Show();
        }
       
        #endregion
        public static void delregfiles()
        {
            if (File.Exists(frmDriveC.currentdir + "\\remove_takeown.reg"))
            {
                File.Delete(frmDriveC.currentdir + "\\remove_takeown.reg");
            }
            else if (File.Exists(frmDriveC.currentdir + "\\add_takeown.reg"))
            {
                File.Delete(frmDriveC.currentdir + "\\add_takeown.reg");
            }
        }
        public static void cmdrun()//runs cmd command 
        {
            //before calling this method define the command string in "cmdstr"
            //you can add messagebox afterwards

            Process cmd = new Process();
            cmd.StartInfo.FileName = @"cmd.exe";
            cmd.StartInfo.RedirectStandardInput = true;
            cmd.StartInfo.RedirectStandardOutput = true;
            cmd.StartInfo.CreateNoWindow = true;
            cmd.StartInfo.UseShellExecute = false;
            cmd.Start();

            cmd.StandardInput.WriteLine(cmdstr);
            cmd.StandardInput.Flush();
            cmd.StandardInput.Close();
            cmd.WaitForExit();
            Console.WriteLine(cmd.StandardOutput.ReadToEnd());
            cmdstr = "";
        }
        public static void shellrun()
        {
            Process shell = new Process();
            shell.StartInfo.FileName = @"powershell.exe";
            shell.StartInfo.RedirectStandardInput = true;
            shell.StartInfo.RedirectStandardOutput = true;
            shell.StartInfo.CreateNoWindow = true;
            shell.StartInfo.UseShellExecute = false;
            shell.Start();

            shell.StandardInput.WriteLine(cmdstr);
            shell.StandardInput.Flush();
            shell.StandardInput.Close();
            shell.WaitForExit();
            Console.WriteLine(shell.StandardOutput.ReadToEnd());
            cmdstr = "";
        }
        public static void delfile()
        {

            DirectoryInfo di = new DirectoryInfo(path);

            foreach (FileInfo file in di.GetFiles())
            {
                try
                {

                    file.Delete();
                }
                catch
                {
                    continue;
                }
            }
            foreach (DirectoryInfo dir in di.GetDirectories())
            {
                try
                {
                    dir.Delete(true);
                }
                catch
                {
                    continue;
                }
            }
        }
        private void btnwservices_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmWinApps(), sender);
        }

        private void Main_Load(object sender, EventArgs e)
        {
            
            MessageBox.Show("This tool is in beta stage and not all features may run properly also be aware that this tool will edit or delete registery keys. \n\nIt's highly recommended that before doing anything you create a backup in Optimize Windows section.\n\nIf you encounter with any issues or you want to suggest a feature you can find information about how to reach me in Contact section.", "Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
        }

        private void btnwinser_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmWinSrv(), sender);
        }

        private void btncontact_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmContact(), sender);
        }

       

        private void btndriveclean_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmDriveC(), sender);
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
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
