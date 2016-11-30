namespace DHCP_IP_Changer
{
    partial class IP_Changer_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IP_Changer_Form));
            this.lbl_main = new System.Windows.Forms.Label();
            this.btn_change_ethernet = new System.Windows.Forms.Button();
            this.lbl_old_IP = new System.Windows.Forms.Label();
            this.lbl_newIP = new System.Windows.Forms.Label();
            this.lbl_wifi_IP = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_leaseObtained = new System.Windows.Forms.Label();
            this.lbl_leaseEnds = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pB_drag = new System.Windows.Forms.PictureBox();
            this.pB_close = new System.Windows.Forms.PictureBox();
            this.btn_change_wifi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pB_drag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB_close)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_main
            // 
            this.lbl_main.AutoSize = true;
            this.lbl_main.Font = new System.Drawing.Font("Lucida Sans Typewriter", 20F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_main.ForeColor = System.Drawing.Color.White;
            this.lbl_main.Location = new System.Drawing.Point(138, 30);
            this.lbl_main.Name = "lbl_main";
            this.lbl_main.Size = new System.Drawing.Size(254, 31);
            this.lbl_main.TabIndex = 0;
            this.lbl_main.Text = "DHCP-IP Changer";
            // 
            // btn_change_ethernet
            // 
            this.btn_change_ethernet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_change_ethernet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_change_ethernet.ForeColor = System.Drawing.Color.White;
            this.btn_change_ethernet.Location = new System.Drawing.Point(270, 362);
            this.btn_change_ethernet.Name = "btn_change_ethernet";
            this.btn_change_ethernet.Size = new System.Drawing.Size(171, 38);
            this.btn_change_ethernet.TabIndex = 2;
            this.btn_change_ethernet.Text = "Ethernet";
            this.btn_change_ethernet.UseVisualStyleBackColor = true;
            this.btn_change_ethernet.Click += new System.EventHandler(this.btn_change_ethernet_Click);
            // 
            // lbl_old_IP
            // 
            this.lbl_old_IP.AutoSize = true;
            this.lbl_old_IP.Font = new System.Drawing.Font("Lucida Sans Typewriter", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_old_IP.ForeColor = System.Drawing.Color.White;
            this.lbl_old_IP.Location = new System.Drawing.Point(266, 98);
            this.lbl_old_IP.Name = "lbl_old_IP";
            this.lbl_old_IP.Size = new System.Drawing.Size(154, 23);
            this.lbl_old_IP.TabIndex = 3;
            this.lbl_old_IP.Text = "Old IP here!";
            // 
            // lbl_newIP
            // 
            this.lbl_newIP.AutoSize = true;
            this.lbl_newIP.Font = new System.Drawing.Font("Lucida Sans Typewriter", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_newIP.ForeColor = System.Drawing.Color.White;
            this.lbl_newIP.Location = new System.Drawing.Point(266, 173);
            this.lbl_newIP.Name = "lbl_newIP";
            this.lbl_newIP.Size = new System.Drawing.Size(214, 23);
            this.lbl_newIP.TabIndex = 4;
            this.lbl_newIP.Text = "Not changed yet!!";
            // 
            // lbl_wifi_IP
            // 
            this.lbl_wifi_IP.AutoSize = true;
            this.lbl_wifi_IP.Font = new System.Drawing.Font("Lucida Sans Typewriter", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_wifi_IP.ForeColor = System.Drawing.Color.White;
            this.lbl_wifi_IP.Location = new System.Drawing.Point(266, 302);
            this.lbl_wifi_IP.Name = "lbl_wifi_IP";
            this.lbl_wifi_IP.Size = new System.Drawing.Size(166, 23);
            this.lbl_wifi_IP.TabIndex = 5;
            this.lbl_wifi_IP.Text = "Wifi IP here!";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Typewriter", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(46, 302);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "Current Wifi IP:-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans Typewriter", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(46, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "New Ethernet IP:-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans Typewriter", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(46, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(214, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Old Ethernet IP:-";
            // 
            // lbl_leaseObtained
            // 
            this.lbl_leaseObtained.AutoSize = true;
            this.lbl_leaseObtained.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_leaseObtained.ForeColor = System.Drawing.Color.White;
            this.lbl_leaseObtained.Location = new System.Drawing.Point(27, 225);
            this.lbl_leaseObtained.Name = "lbl_leaseObtained";
            this.lbl_leaseObtained.Size = new System.Drawing.Size(117, 12);
            this.lbl_leaseObtained.TabIndex = 9;
            this.lbl_leaseObtained.Text = "Lease Obtained:-";
            // 
            // lbl_leaseEnds
            // 
            this.lbl_leaseEnds.AutoSize = true;
            this.lbl_leaseEnds.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_leaseEnds.ForeColor = System.Drawing.Color.White;
            this.lbl_leaseEnds.Location = new System.Drawing.Point(27, 257);
            this.lbl_leaseEnds.Name = "lbl_leaseEnds";
            this.lbl_leaseEnds.Size = new System.Drawing.Size(96, 12);
            this.lbl_leaseEnds.TabIndex = 10;
            this.lbl_leaseEnds.Text = "Lease Expires";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans Typewriter", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(377, 412);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 11);
            this.label4.TabIndex = 11;
            this.label4.Text = "Created By:- Kaiser,WGT";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Lucida Sans Typewriter", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(9, 336);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(514, 23);
            this.label5.TabIndex = 12;
            this.label5.Text = "__________________________________________";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Sans Typewriter", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(9, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(514, 23);
            this.label6.TabIndex = 13;
            this.label6.Text = "__________________________________________";
            // 
            // pB_drag
            // 
            this.pB_drag.BackColor = System.Drawing.Color.Firebrick;
            this.pB_drag.BackgroundImage = global::DHCP_IP_Changer.Properties.Resources.Drag;
            this.pB_drag.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pB_drag.Location = new System.Drawing.Point(-3, 1);
            this.pB_drag.Name = "pB_drag";
            this.pB_drag.Size = new System.Drawing.Size(31, 31);
            this.pB_drag.TabIndex = 14;
            this.pB_drag.TabStop = false;
            this.pB_drag.MouseDown += new System.Windows.Forms.MouseEventHandler(this.startDrag);
            // 
            // pB_close
            // 
            this.pB_close.BackColor = System.Drawing.Color.DarkRed;
            this.pB_close.BackgroundImage = global::DHCP_IP_Changer.Properties.Resources.Cross_128__1_;
            this.pB_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pB_close.Location = new System.Drawing.Point(500, 1);
            this.pB_close.Name = "pB_close";
            this.pB_close.Size = new System.Drawing.Size(31, 31);
            this.pB_close.TabIndex = 1;
            this.pB_close.TabStop = false;
            this.pB_close.Click += new System.EventHandler(this.pB_close_Click);
            // 
            // btn_change_wifi
            // 
            this.btn_change_wifi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_change_wifi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_change_wifi.ForeColor = System.Drawing.Color.White;
            this.btn_change_wifi.Location = new System.Drawing.Point(89, 362);
            this.btn_change_wifi.Name = "btn_change_wifi";
            this.btn_change_wifi.Size = new System.Drawing.Size(171, 38);
            this.btn_change_wifi.TabIndex = 15;
            this.btn_change_wifi.Text = "Wifi";
            this.btn_change_wifi.UseVisualStyleBackColor = true;
            this.btn_change_wifi.Click += new System.EventHandler(this.btn_change_wifi_Click);
            // 
            // IP_Changer_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(532, 423);
            this.Controls.Add(this.btn_change_wifi);
            this.Controls.Add(this.pB_drag);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_leaseEnds);
            this.Controls.Add(this.lbl_leaseObtained);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_wifi_IP);
            this.Controls.Add(this.lbl_newIP);
            this.Controls.Add(this.lbl_old_IP);
            this.Controls.Add(this.btn_change_ethernet);
            this.Controls.Add(this.pB_close);
            this.Controls.Add(this.lbl_main);
            this.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "IP_Changer_Form";
            this.Opacity = 0.8D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IP Changer (Created By Kaiser 30th Nov 2016)";
            this.Load += new System.EventHandler(this.IP_Changer_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pB_drag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB_close)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_main;
        private System.Windows.Forms.PictureBox pB_close;
        private System.Windows.Forms.Button btn_change_ethernet;
        private System.Windows.Forms.Label lbl_old_IP;
        private System.Windows.Forms.Label lbl_newIP;
        private System.Windows.Forms.Label lbl_wifi_IP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_leaseObtained;
        private System.Windows.Forms.Label lbl_leaseEnds;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pB_drag;
        private System.Windows.Forms.Button btn_change_wifi;
    }
}

