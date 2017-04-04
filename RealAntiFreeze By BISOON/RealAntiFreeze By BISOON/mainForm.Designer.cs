namespace RealAntiFreeze_By_BISOON
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.mainSkin = new theme.FormSkin();
            this.closeBtn = new theme.FlatButton();
            this.flatMini1 = new theme.FlatMini();
            this.cexCh = new System.Windows.Forms.RadioButton();
            this.dexCh = new System.Windows.Forms.RadioButton();
            this.runAntiBtn = new theme.FlatButton();
            this.conBtn = new theme.FlatButton();
            this.lblInfo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.byBisBtn = new theme.FlatButton();
            this.mainSkin.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainSkin
            // 
            this.mainSkin.BackColor = System.Drawing.Color.White;
            this.mainSkin.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.mainSkin.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(58)))), ((int)(((byte)(60)))));
            this.mainSkin.Controls.Add(this.byBisBtn);
            this.mainSkin.Controls.Add(this.label2);
            this.mainSkin.Controls.Add(this.label1);
            this.mainSkin.Controls.Add(this.lblInfo);
            this.mainSkin.Controls.Add(this.closeBtn);
            this.mainSkin.Controls.Add(this.flatMini1);
            this.mainSkin.Controls.Add(this.cexCh);
            this.mainSkin.Controls.Add(this.dexCh);
            this.mainSkin.Controls.Add(this.runAntiBtn);
            this.mainSkin.Controls.Add(this.conBtn);
            this.mainSkin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainSkin.FlatColor = System.Drawing.Color.Teal;
            this.mainSkin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.mainSkin.HeaderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.mainSkin.HeaderMaximize = false;
            this.mainSkin.Location = new System.Drawing.Point(0, 0);
            this.mainSkin.Name = "mainSkin";
            this.mainSkin.Size = new System.Drawing.Size(385, 231);
            this.mainSkin.TabIndex = 0;
            this.mainSkin.Text = "BO II  AntiFreeze";
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.Color.Transparent;
            this.closeBtn.BaseColor = System.Drawing.Color.Teal;
            this.closeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.closeBtn.Location = new System.Drawing.Point(364, 3);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Rounded = false;
            this.closeBtn.Size = new System.Drawing.Size(18, 18);
            this.closeBtn.TabIndex = 16;
            this.closeBtn.Text = "X";
            this.closeBtn.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // flatMini1
            // 
            this.flatMini1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flatMini1.BackColor = System.Drawing.Color.White;
            this.flatMini1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.flatMini1.Font = new System.Drawing.Font("Marlett", 12F);
            this.flatMini1.Location = new System.Drawing.Point(340, 2);
            this.flatMini1.Name = "flatMini1";
            this.flatMini1.Size = new System.Drawing.Size(18, 18);
            this.flatMini1.TabIndex = 15;
            this.flatMini1.Text = "flatMini1";
            this.flatMini1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            // 
            // cexCh
            // 
            this.cexCh.AutoSize = true;
            this.cexCh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.cexCh.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cexCh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.cexCh.Location = new System.Drawing.Point(128, 54);
            this.cexCh.Name = "cexCh";
            this.cexCh.Size = new System.Drawing.Size(57, 25);
            this.cexCh.TabIndex = 13;
            this.cexCh.TabStop = true;
            this.cexCh.Text = "CEX";
            this.cexCh.UseVisualStyleBackColor = false;
            // 
            // dexCh
            // 
            this.dexCh.AutoSize = true;
            this.dexCh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.dexCh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.dexCh.Location = new System.Drawing.Point(191, 54);
            this.dexCh.Name = "dexCh";
            this.dexCh.Size = new System.Drawing.Size(59, 25);
            this.dexCh.TabIndex = 12;
            this.dexCh.TabStop = true;
            this.dexCh.Text = "DEX";
            this.dexCh.UseVisualStyleBackColor = false;
            // 
            // runAntiBtn
            // 
            this.runAntiBtn.BackColor = System.Drawing.Color.Transparent;
            this.runAntiBtn.BaseColor = System.Drawing.Color.Teal;
            this.runAntiBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.runAntiBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.runAntiBtn.Location = new System.Drawing.Point(69, 137);
            this.runAntiBtn.Name = "runAntiBtn";
            this.runAntiBtn.Rounded = false;
            this.runAntiBtn.Size = new System.Drawing.Size(240, 36);
            this.runAntiBtn.TabIndex = 11;
            this.runAntiBtn.Text = "Run AntiFreeze";
            this.runAntiBtn.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.runAntiBtn.Click += new System.EventHandler(this.runAntiBtn_Click);
            // 
            // conBtn
            // 
            this.conBtn.BackColor = System.Drawing.Color.Transparent;
            this.conBtn.BaseColor = System.Drawing.Color.Teal;
            this.conBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.conBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.conBtn.Location = new System.Drawing.Point(69, 84);
            this.conBtn.Name = "conBtn";
            this.conBtn.Rounded = false;
            this.conBtn.Size = new System.Drawing.Size(240, 36);
            this.conBtn.TabIndex = 10;
            this.conBtn.Text = "Connect / Attach";
            this.conBtn.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.conBtn.Click += new System.EventHandler(this.conBtn_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.BackColor = System.Drawing.Color.Transparent;
            this.lblInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.lblInfo.Location = new System.Drawing.Point(118, 176);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(143, 21);
            this.lblInfo.TabIndex = 17;
            this.lblInfo.Text = "AntiFreeze  [ Off ]";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.label2.Location = new System.Drawing.Point(112, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 21);
            this.label2.TabIndex = 19;
            this.label2.Text = ".com";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Click += new System.EventHandler(this.websitEvent);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(3, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 21);
            this.label1.TabIndex = 18;
            this.label1.Text = "ArabModding";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Click += new System.EventHandler(this.websitEvent);
            // 
            // byBisBtn
            // 
            this.byBisBtn.BackColor = System.Drawing.Color.Transparent;
            this.byBisBtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.byBisBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.byBisBtn.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.byBisBtn.Location = new System.Drawing.Point(311, 213);
            this.byBisBtn.Name = "byBisBtn";
            this.byBisBtn.Rounded = false;
            this.byBisBtn.Size = new System.Drawing.Size(71, 20);
            this.byBisBtn.TabIndex = 20;
            this.byBisBtn.Text = "By BISOON";
            this.byBisBtn.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.byBisBtn.Click += new System.EventHandler(this.byBisBtn_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 231);
            this.Controls.Add(this.mainSkin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AntiFreeze By BISOON";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.mainSkin.ResumeLayout(false);
            this.mainSkin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private theme.FormSkin mainSkin;
        private theme.FlatMini flatMini1;
        private System.Windows.Forms.RadioButton cexCh;
        private System.Windows.Forms.RadioButton dexCh;
        private theme.FlatButton runAntiBtn;
        private theme.FlatButton conBtn;
        private theme.FlatButton closeBtn;
        private System.Windows.Forms.Label lblInfo;
        private theme.FlatButton byBisBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

