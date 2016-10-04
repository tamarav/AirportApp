namespace AirportApp
{
    partial class AddFlightForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddFlightForm));
            this.lb_title = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_destination = new System.Windows.Forms.TextBox();
            this.cb_airline = new System.Windows.Forms.ComboBox();
            this.tb_startPoint = new System.Windows.Forms.TextBox();
            this.dt_pickerDeparture = new System.Windows.Forms.DateTimePicker();
            this.dtpicker_Landing = new System.Windows.Forms.DateTimePicker();
            this.lbl_info = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_title
            // 
            this.lb_title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lb_title.AutoSize = true;
            this.lb_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_title.Location = new System.Drawing.Point(117, 21);
            this.lb_title.Name = "lb_title";
            this.lb_title.Size = new System.Drawing.Size(96, 24);
            this.lb_title.TabIndex = 0;
            this.lb_title.Text = "Add Flight";
            this.lb_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Departure time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Desination";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Start point";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Time of arrival";
            // 
            // btn_add
            // 
            this.btn_add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_add.Location = new System.Drawing.Point(165, 257);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 6;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cancel.Location = new System.Drawing.Point(246, 257);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 7;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Airplane";
            // 
            // tb_destination
            // 
            this.tb_destination.Location = new System.Drawing.Point(94, 88);
            this.tb_destination.Name = "tb_destination";
            this.tb_destination.Size = new System.Drawing.Size(227, 20);
            this.tb_destination.TabIndex = 2;
            this.tb_destination.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.enter);
            // 
            // cb_airline
            // 
            this.cb_airline.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_airline.FormattingEnabled = true;
            this.cb_airline.Location = new System.Drawing.Point(94, 166);
            this.cb_airline.Name = "cb_airline";
            this.cb_airline.Size = new System.Drawing.Size(227, 21);
            this.cb_airline.TabIndex = 5;
            this.cb_airline.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.enter);
            // 
            // tb_startPoint
            // 
            this.tb_startPoint.Location = new System.Drawing.Point(94, 62);
            this.tb_startPoint.Name = "tb_startPoint";
            this.tb_startPoint.Size = new System.Drawing.Size(227, 20);
            this.tb_startPoint.TabIndex = 1;
            this.tb_startPoint.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.enter);
            // 
            // dt_pickerDeparture
            // 
            this.dt_pickerDeparture.Location = new System.Drawing.Point(94, 114);
            this.dt_pickerDeparture.Name = "dt_pickerDeparture";
            this.dt_pickerDeparture.Size = new System.Drawing.Size(227, 20);
            this.dt_pickerDeparture.TabIndex = 3;
            this.dt_pickerDeparture.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.enter);
            // 
            // dtpicker_Landing
            // 
            this.dtpicker_Landing.Location = new System.Drawing.Point(94, 140);
            this.dtpicker_Landing.Name = "dtpicker_Landing";
            this.dtpicker_Landing.Size = new System.Drawing.Size(227, 20);
            this.dtpicker_Landing.TabIndex = 4;
            this.dtpicker_Landing.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.enter);
            // 
            // lbl_info
            // 
            this.lbl_info.AutoSize = true;
            this.lbl_info.ForeColor = System.Drawing.Color.Red;
            this.lbl_info.Location = new System.Drawing.Point(15, 205);
            this.lbl_info.Name = "lbl_info";
            this.lbl_info.Size = new System.Drawing.Size(0, 13);
            this.lbl_info.TabIndex = 10;
            // 
            // AddFlightForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 292);
            this.Controls.Add(this.lbl_info);
            this.Controls.Add(this.dtpicker_Landing);
            this.Controls.Add(this.dt_pickerDeparture);
            this.Controls.Add(this.tb_startPoint);
            this.Controls.Add(this.cb_airline);
            this.Controls.Add(this.tb_destination);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lb_title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddFlightForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Airport";
            this.Load += new System.EventHandler(this.AddFlightForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_title;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_destination;
        private System.Windows.Forms.ComboBox cb_airline;
        private System.Windows.Forms.TextBox tb_startPoint;
        private System.Windows.Forms.DateTimePicker dt_pickerDeparture;
        private System.Windows.Forms.DateTimePicker dtpicker_Landing;
        private System.Windows.Forms.Label lbl_info;
    }
}