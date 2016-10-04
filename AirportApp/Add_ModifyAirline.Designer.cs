namespace AirportApp
{
    partial class Add_ModifyAirline
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_ModifyAirline));
            this.lb_title = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_country = new System.Windows.Forms.TextBox();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.lbl_info = new System.Windows.Forms.Label();
            this.tb_address = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.tb_telephone = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lb_title
            // 
            this.lb_title.AutoSize = true;
            this.lb_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_title.Location = new System.Drawing.Point(98, 9);
            this.lb_title.Name = "lb_title";
            this.lb_title.Size = new System.Drawing.Size(63, 24);
            this.lb_title.TabIndex = 0;
            this.lb_title.Text = "Airline";
            this.lb_title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Country";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Name";
            // 
            // tb_country
            // 
            this.tb_country.Location = new System.Drawing.Point(102, 72);
            this.tb_country.Name = "tb_country";
            this.tb_country.Size = new System.Drawing.Size(121, 20);
            this.tb_country.TabIndex = 2;
            this.tb_country.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.enter);
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(102, 46);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(121, 20);
            this.tb_name.TabIndex = 1;
            this.tb_name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.enter);
            // 
            // btn_add
            // 
            this.btn_add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_add.Location = new System.Drawing.Point(117, 217);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 6;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cancel.Location = new System.Drawing.Point(198, 217);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 7;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // lbl_info
            // 
            this.lbl_info.AutoSize = true;
            this.lbl_info.ForeColor = System.Drawing.Color.Red;
            this.lbl_info.Location = new System.Drawing.Point(15, 183);
            this.lbl_info.Name = "lbl_info";
            this.lbl_info.Size = new System.Drawing.Size(96, 13);
            this.lbl_info.TabIndex = 9;
            this.lbl_info.Text = "Missing information";
            // 
            // tb_address
            // 
            this.tb_address.Location = new System.Drawing.Point(102, 99);
            this.tb_address.Name = "tb_address";
            this.tb_address.Size = new System.Drawing.Size(121, 20);
            this.tb_address.TabIndex = 3;
            this.tb_address.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Telephone";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Email";
            // 
            // tb_email
            // 
            this.tb_email.Location = new System.Drawing.Point(102, 151);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(121, 20);
            this.tb_email.TabIndex = 5;
            this.tb_email.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.enter);
            // 
            // tb_telephone
            // 
            this.tb_telephone.Location = new System.Drawing.Point(102, 125);
            this.tb_telephone.Name = "tb_telephone";
            this.tb_telephone.Size = new System.Drawing.Size(121, 20);
            this.tb_telephone.TabIndex = 4;
            this.tb_telephone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.enter);
            // 
            // Add_ModifyAirline
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 252);
            this.Controls.Add(this.tb_telephone);
            this.Controls.Add(this.tb_email);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_address);
            this.Controls.Add(this.lbl_info);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.tb_country);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Add_ModifyAirline";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Airport";
            this.Load += new System.EventHandler(this.Add_ModifyAirline_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_country;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Label lbl_info;
        private System.Windows.Forms.TextBox tb_address;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.TextBox tb_telephone;
    }
}