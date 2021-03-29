namespace dbviewer {
    partial class DbLocaionForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbDbUser = new System.Windows.Forms.TextBox();
            this.TbDbPass = new System.Windows.Forms.TextBox();
            this.tbDbName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lbStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(38, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "User:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label2.Location = new System.Drawing.Point(38, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 26);
            this.label2.TabIndex = 0;
            this.label2.Text = "Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label3.Location = new System.Drawing.Point(38, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 26);
            this.label3.TabIndex = 0;
            this.label3.Text = "Database Name:";
            // 
            // tbDbUser
            // 
            this.tbDbUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.tbDbUser.Location = new System.Drawing.Point(249, 36);
            this.tbDbUser.Name = "tbDbUser";
            this.tbDbUser.Size = new System.Drawing.Size(282, 32);
            this.tbDbUser.TabIndex = 1;
            this.tbDbUser.TabStop = false;
            this.tbDbUser.KeyDown += new System.Windows.Forms.KeyEventHandler(this.button1_KeyDown);
            // 
            // TbDbPass
            // 
            this.TbDbPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.TbDbPass.Location = new System.Drawing.Point(249, 85);
            this.TbDbPass.Name = "TbDbPass";
            this.TbDbPass.Size = new System.Drawing.Size(282, 32);
            this.TbDbPass.TabIndex = 2;
            this.TbDbPass.TabStop = false;
            this.TbDbPass.UseSystemPasswordChar = true;
            this.TbDbPass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.button1_KeyDown);
            // 
            // tbDbName
            // 
            this.tbDbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.tbDbName.Location = new System.Drawing.Point(249, 134);
            this.tbDbName.Name = "tbDbName";
            this.tbDbName.Size = new System.Drawing.Size(282, 32);
            this.tbDbName.TabIndex = 3;
            this.tbDbName.TabStop = false;
            this.tbDbName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.button1_KeyDown);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(409, 197);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 30);
            this.button1.TabIndex = 4;
            this.button1.TabStop = false;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.button1_KeyDown);
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lbStatus.ForeColor = System.Drawing.Color.Red;
            this.lbStatus.Location = new System.Drawing.Point(38, 197);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(0, 26);
            this.lbStatus.TabIndex = 0;
            // 
            // DbLocaionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(577, 253);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbDbName);
            this.Controls.Add(this.TbDbPass);
            this.Controls.Add(this.tbDbUser);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(593, 292);
            this.MinimumSize = new System.Drawing.Size(593, 248);
            this.Name = "DbLocaionForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Database Location";
            this.Load += new System.EventHandler(this.DbLocaionForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbDbUser;
        private System.Windows.Forms.TextBox TbDbPass;
        private System.Windows.Forms.TextBox tbDbName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbStatus;
    }
}