namespace Lift
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
            this.panelBuilding = new System.Windows.Forms.Panel();
            this.panelLift = new System.Windows.Forms.Panel();
            this.labelFloor = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFloor = new System.Windows.Forms.RichTextBox();
            this.buttonShift = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelBuilding.SuspendLayout();
            this.panelLift.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBuilding
            // 
            this.panelBuilding.BackColor = System.Drawing.Color.Gray;
            this.panelBuilding.Controls.Add(this.panelLift);
            this.panelBuilding.Controls.Add(this.label8);
            this.panelBuilding.Controls.Add(this.label7);
            this.panelBuilding.Controls.Add(this.label6);
            this.panelBuilding.Controls.Add(this.label5);
            this.panelBuilding.Controls.Add(this.label4);
            this.panelBuilding.Controls.Add(this.label3);
            this.panelBuilding.Controls.Add(this.label2);
            this.panelBuilding.Location = new System.Drawing.Point(12, 105);
            this.panelBuilding.Name = "panelBuilding";
            this.panelBuilding.Size = new System.Drawing.Size(350, 400);
            this.panelBuilding.TabIndex = 0;
            // 
            // panelLift
            // 
            this.panelLift.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panelLift.Controls.Add(this.labelFloor);
            this.panelLift.Location = new System.Drawing.Point(116, 351);
            this.panelLift.Name = "panelLift";
            this.panelLift.Size = new System.Drawing.Size(120, 50);
            this.panelLift.TabIndex = 0;
            // 
            // labelFloor
            // 
            this.labelFloor.AutoSize = true;
            this.labelFloor.Location = new System.Drawing.Point(53, 20);
            this.labelFloor.Name = "labelFloor";
            this.labelFloor.Size = new System.Drawing.Size(13, 13);
            this.labelFloor.TabIndex = 0;
            this.labelFloor.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(-2, 293);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(355, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "-----2---------------------------------------------------------------------------" +
                "----------------------------------";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(0, 243);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(355, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "-----3---------------------------------------------------------------------------" +
                "----------------------------------";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(0, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(355, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "-----4---------------------------------------------------------------------------" +
                "----------------------------------";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(-2, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(355, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "-----5---------------------------------------------------------------------------" +
                "----------------------------------";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(-2, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(355, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "-----6---------------------------------------------------------------------------" +
                "----------------------------------";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-3, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(355, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "-----7---------------------------------------------------------------------------" +
                "----------------------------------";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 343);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(355, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "-----1---------------------------------------------------------------------------" +
                "----------------------------------";
            // 
            // txtFloor
            // 
            this.txtFloor.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFloor.Location = new System.Drawing.Point(46, 49);
            this.txtFloor.Name = "txtFloor";
            this.txtFloor.Size = new System.Drawing.Size(157, 41);
            this.txtFloor.TabIndex = 1;
            this.txtFloor.Text = "";
            // 
            // buttonShift
            // 
            this.buttonShift.Location = new System.Drawing.Point(236, 46);
            this.buttonShift.Name = "buttonShift";
            this.buttonShift.Size = new System.Drawing.Size(90, 44);
            this.buttonShift.TabIndex = 2;
            this.buttonShift.Text = " Shift";
            this.buttonShift.UseVisualStyleBackColor = true;
            this.buttonShift.Click += new System.EventHandler(this.buttonShift_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(12, 525);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(350, 44);
            this.buttonExit.TabIndex = 3;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(374, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 581);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonShift);
            this.Controls.Add(this.txtFloor);
            this.Controls.Add(this.panelBuilding);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Lift";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelBuilding.ResumeLayout(false);
            this.panelBuilding.PerformLayout();
            this.panelLift.ResumeLayout(false);
            this.panelLift.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelBuilding;
        private System.Windows.Forms.RichTextBox txtFloor;
        private System.Windows.Forms.Button buttonShift;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Panel panelLift;
        private System.Windows.Forms.Label labelFloor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

