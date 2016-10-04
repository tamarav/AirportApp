namespace AirportApp
{
    partial class AddModifyAirplane
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddModifyAirplane));
            this.lbl_title = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.tb_numberOfSeats = new System.Windows.Forms.TextBox();
            this.cb_airlines = new System.Windows.Forms.ComboBox();
            this.lbl_info = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_title
            // 
            this.lbl_title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(90, 9);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(117, 24);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "Add airplane";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Number of seats";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Airline company";
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(108, 55);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(121, 20);
            this.tb_name.TabIndex = 1;
            this.tb_name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.enter);
            // 
            // tb_numberOfSeats
            // 
            this.tb_numberOfSeats.Location = new System.Drawing.Point(108, 81);
            this.tb_numberOfSeats.Name = "tb_numberOfSeats";
            this.tb_numberOfSeats.Size = new System.Drawing.Size(121, 20);
            this.tb_numberOfSeats.TabIndex = 2;
            this.tb_numberOfSeats.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.enter);
            // 
            // cb_airlines
            // 
            this.cb_airlines.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_airlines.FormattingEnabled = true;
            this.cb_airlines.Location = new System.Drawing.Point(108, 107);
            this.cb_airlines.Name = "cb_airlines";
            this.cb_airlines.Size = new System.Drawing.Size(121, 21);
            this.cb_airlines.TabIndex = 3;
            this.cb_airlines.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.enter);
            // 
            // lbl_info
            // 
            this.lbl_info.AutoSize = true;
            this.lbl_info.ForeColor = System.Drawing.Color.Red;
            this.lbl_info.Location = new System.Drawing.Point(12, 141);
            this.lbl_info.Name = "lbl_info";
            this.lbl_info.Size = new System.Drawing.Size(15, 13);
            this.lbl_info.TabIndex = 7;
            this.lbl_info.Text = "m";
            // 
            // btn_add
            // 
            this.btn_add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_add.Location = new System.Drawing.Point(108, 201);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 4;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_close
            // 
            this.btn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_close.Location = new System.Drawing.Point(189, 201);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 23);
            this.btn_close.TabIndex = 5;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // AddModifyAirplane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 252);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.lbl_info);
            this.Controls.Add(this.cb_airlines);
            this.Controls.Add(this.tb_numberOfSeats);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "AddModifyAirplane";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Airplane";
            this.Load += new System.EventHandler(this.AddModifyAirplane_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.TextBox tb_numberOfSeats;
        private System.Windows.Forms.ComboBox cb_airlines;
        private System.Windows.Forms.Label lbl_info;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_close;
    }
}