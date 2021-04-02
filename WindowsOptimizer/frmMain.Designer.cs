
namespace WindowsOptimizer
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.leftpanel = new System.Windows.Forms.Panel();
            this.btncontact = new System.Windows.Forms.Button();
            this.btndriveclean = new System.Windows.Forms.Button();
            this.btnwinapps = new System.Windows.Forms.Button();
            this.btnwinser = new System.Windows.Forms.Button();
            this.panelChild = new System.Windows.Forms.Panel();
            this.leftpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftpanel
            // 
            this.leftpanel.Controls.Add(this.btncontact);
            this.leftpanel.Controls.Add(this.btndriveclean);
            this.leftpanel.Controls.Add(this.btnwinapps);
            this.leftpanel.Controls.Add(this.btnwinser);
            this.leftpanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftpanel.Location = new System.Drawing.Point(0, 0);
            this.leftpanel.Name = "leftpanel";
            this.leftpanel.Size = new System.Drawing.Size(170, 308);
            this.leftpanel.TabIndex = 0;
            // 
            // btncontact
            // 
            this.btncontact.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.btncontact.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btncontact.FlatAppearance.BorderSize = 0;
            this.btncontact.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.btncontact.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.btncontact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncontact.Font = new System.Drawing.Font("Reem Kufi", 14.25F);
            this.btncontact.Location = new System.Drawing.Point(0, 240);
            this.btncontact.Name = "btncontact";
            this.btncontact.Size = new System.Drawing.Size(170, 68);
            this.btncontact.TabIndex = 1;
            this.btncontact.Text = "Contact";
            this.btncontact.UseVisualStyleBackColor = false;
            this.btncontact.Click += new System.EventHandler(this.btncontact_Click);
            // 
            // btndriveclean
            // 
            this.btndriveclean.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.btndriveclean.Dock = System.Windows.Forms.DockStyle.Top;
            this.btndriveclean.FlatAppearance.BorderSize = 0;
            this.btndriveclean.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.btndriveclean.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.btndriveclean.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndriveclean.Font = new System.Drawing.Font("Reem Kufi", 14.25F);
            this.btndriveclean.Location = new System.Drawing.Point(0, 160);
            this.btndriveclean.Name = "btndriveclean";
            this.btndriveclean.Size = new System.Drawing.Size(170, 80);
            this.btndriveclean.TabIndex = 5123;
            this.btndriveclean.Text = "Drive Cleaner";
            this.btndriveclean.UseVisualStyleBackColor = false;
            this.btndriveclean.Click += new System.EventHandler(this.btndriveclean_Click);
            // 
            // btnwinapps
            // 
            this.btnwinapps.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.btnwinapps.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnwinapps.FlatAppearance.BorderSize = 0;
            this.btnwinapps.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.btnwinapps.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.btnwinapps.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnwinapps.Font = new System.Drawing.Font("Reem Kufi", 14.25F);
            this.btnwinapps.Location = new System.Drawing.Point(0, 80);
            this.btnwinapps.Name = "btnwinapps";
            this.btnwinapps.Size = new System.Drawing.Size(170, 80);
            this.btnwinapps.TabIndex = 0;
            this.btnwinapps.Text = "Uninstall Windows Apps";
            this.btnwinapps.UseVisualStyleBackColor = false;
            this.btnwinapps.Click += new System.EventHandler(this.btnwservices_Click);
            // 
            // btnwinser
            // 
            this.btnwinser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.btnwinser.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnwinser.FlatAppearance.BorderSize = 0;
            this.btnwinser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.btnwinser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.btnwinser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnwinser.Font = new System.Drawing.Font("Reem Kufi", 14.25F);
            this.btnwinser.Location = new System.Drawing.Point(0, 0);
            this.btnwinser.Name = "btnwinser";
            this.btnwinser.Size = new System.Drawing.Size(170, 80);
            this.btnwinser.TabIndex = 1;
            this.btnwinser.Text = "Optimize Windows";
            this.btnwinser.UseVisualStyleBackColor = false;
            this.btnwinser.Click += new System.EventHandler(this.btnwinser_Click);
            // 
            // panelChild
            // 
            this.panelChild.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChild.Location = new System.Drawing.Point(170, 0);
            this.panelChild.Name = "panelChild";
            this.panelChild.Size = new System.Drawing.Size(0, 308);
            this.panelChild.TabIndex = 1;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.ClientSize = new System.Drawing.Size(169, 308);
            this.Controls.Add(this.panelChild);
            this.Controls.Add(this.leftpanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(185, 347);
            this.Name = "frmMain";
            this.Text = "WindowsOptimizer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.leftpanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel leftpanel;
        private System.Windows.Forms.Button btnwinser;
        private System.Windows.Forms.Button btncontact;
        private System.Windows.Forms.Button btndriveclean;
        private System.Windows.Forms.Button btnwinapps;
        private System.Windows.Forms.Panel panelChild;
    }
}

