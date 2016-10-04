namespace AirportApp
{
    partial class MainForm
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Flights");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Airlines");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Airplanes");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Airport", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.acountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.airlineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.airplaneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tvTypes = new System.Windows.Forms.TreeView();
            this.lv_Main = new System.Windows.Forms.ListView();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_modify = new System.Windows.Forms.Button();
            this.btn_remove = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acountToolStripMenuItem,
            this.addToolStripMenuItem3,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(499, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // acountToolStripMenuItem
            // 
            this.acountToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logOutToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.acountToolStripMenuItem.Name = "acountToolStripMenuItem";
            this.acountToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.acountToolStripMenuItem.Text = "Acount";
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.logOutToolStripMenuItem.Text = "Log out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // addToolStripMenuItem3
            // 
            this.addToolStripMenuItem3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.airlineToolStripMenuItem,
            this.airplaneToolStripMenuItem,
            this.flightToolStripMenuItem});
            this.addToolStripMenuItem3.Name = "addToolStripMenuItem3";
            this.addToolStripMenuItem3.Size = new System.Drawing.Size(41, 20);
            this.addToolStripMenuItem3.Text = "Add";
            // 
            // airlineToolStripMenuItem
            // 
            this.airlineToolStripMenuItem.Name = "airlineToolStripMenuItem";
            this.airlineToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.airlineToolStripMenuItem.Text = "Airline";
            this.airlineToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem1_Click);
            // 
            // airplaneToolStripMenuItem
            // 
            this.airplaneToolStripMenuItem.Name = "airplaneToolStripMenuItem";
            this.airplaneToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.airplaneToolStripMenuItem.Text = "Airplane";
            this.airplaneToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem2_Click);
            // 
            // flightToolStripMenuItem
            // 
            this.flightToolStripMenuItem.Name = "flightToolStripMenuItem";
            this.flightToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.flightToolStripMenuItem.Text = "Flight";
            this.flightToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
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
            // tvTypes
            // 
            this.tvTypes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tvTypes.Location = new System.Drawing.Point(0, 27);
            this.tvTypes.Name = "tvTypes";
            treeNode1.Name = "Node1";
            treeNode1.Text = "Flights";
            treeNode2.Name = "Node2";
            treeNode2.Text = "Airlines";
            treeNode3.Name = "Node3";
            treeNode3.Text = "Airplanes";
            treeNode4.Name = "Node0";
            treeNode4.Text = "Airport";
            this.tvTypes.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode4});
            this.tvTypes.Size = new System.Drawing.Size(121, 339);
            this.tvTypes.TabIndex = 1;
            this.tvTypes.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvTypes_AfterSelect);
            // 
            // lv_Main
            // 
            this.lv_Main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lv_Main.FullRowSelect = true;
            this.lv_Main.GridLines = true;
            this.lv_Main.Location = new System.Drawing.Point(127, 27);
            this.lv_Main.Name = "lv_Main";
            this.lv_Main.Size = new System.Drawing.Size(360, 339);
            this.lv_Main.TabIndex = 2;
            this.lv_Main.UseCompatibleStateImageBehavior = false;
            this.lv_Main.View = System.Windows.Forms.View.Details;
            this.lv_Main.SelectedIndexChanged += new System.EventHandler(this.lv_Main_SelectedIndexChanged);
            // 
            // btn_add
            // 
            this.btn_add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_add.Location = new System.Drawing.Point(250, 377);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 1;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_modify
            // 
            this.btn_modify.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_modify.Location = new System.Drawing.Point(331, 377);
            this.btn_modify.Name = "btn_modify";
            this.btn_modify.Size = new System.Drawing.Size(75, 23);
            this.btn_modify.TabIndex = 2;
            this.btn_modify.Text = "Modify";
            this.btn_modify.UseVisualStyleBackColor = true;
            this.btn_modify.Click += new System.EventHandler(this.btn_modify_Click);
            // 
            // btn_remove
            // 
            this.btn_remove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_remove.Location = new System.Drawing.Point(412, 377);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(75, 23);
            this.btn_remove.TabIndex = 3;
            this.btn_remove.Text = "Remove";
            this.btn_remove.UseVisualStyleBackColor = true;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 412);
            this.Controls.Add(this.btn_remove);
            this.Controls.Add(this.btn_modify);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.lv_Main);
            this.Controls.Add(this.tvTypes);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(417, 445);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Airport";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TreeView tvTypes;
        private System.Windows.Forms.ListView lv_Main;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_modify;
        private System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.ToolStripMenuItem acountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem airlineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem airplaneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem flightToolStripMenuItem;
    }
}