namespace Robotic
{
	partial class frmRobotic
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
            this.txtX = new System.Windows.Forms.TextBox();
            this.txtY = new System.Windows.Forms.TextBox();
            this.lblX = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnArea = new System.Windows.Forms.Button();
            this.grpbxAreaDef = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnMapping = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRobotXCoor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRobotYCoor = new System.Windows.Forms.TextBox();
            this.cbxDirection = new System.Windows.Forms.ComboBox();
            this.grpArea = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRotations = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnRun = new System.Windows.Forms.Button();
            this.grpbxAreaDef.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(132, 25);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(67, 20);
            this.txtX.TabIndex = 0;
            this.txtX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtX_KeyPress);
            // 
            // txtY
            // 
            this.txtY.Location = new System.Drawing.Point(132, 51);
            this.txtY.Name = "txtY";
            this.txtY.Size = new System.Drawing.Size(67, 20);
            this.txtY.TabIndex = 1;
            this.txtY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtY_KeyPress);
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Location = new System.Drawing.Point(17, 28);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(85, 13);
            this.lblX.TabIndex = 2;
            this.lblX.Text = "Yatay Alan Birimi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Düşey Alan Birimi";
            // 
            // btnArea
            // 
            this.btnArea.Location = new System.Drawing.Point(107, 102);
            this.btnArea.Name = "btnArea";
            this.btnArea.Size = new System.Drawing.Size(92, 26);
            this.btnArea.TabIndex = 4;
            this.btnArea.Text = "Alanı Oluştur";
            this.btnArea.UseVisualStyleBackColor = true;
            this.btnArea.Click += new System.EventHandler(this.btnArea_Click);
            // 
            // grpbxAreaDef
            // 
            this.grpbxAreaDef.Controls.Add(this.lblX);
            this.grpbxAreaDef.Controls.Add(this.btnArea);
            this.grpbxAreaDef.Controls.Add(this.txtX);
            this.grpbxAreaDef.Controls.Add(this.label2);
            this.grpbxAreaDef.Controls.Add(this.txtY);
            this.grpbxAreaDef.Location = new System.Drawing.Point(12, 12);
            this.grpbxAreaDef.Name = "grpbxAreaDef";
            this.grpbxAreaDef.Size = new System.Drawing.Size(233, 163);
            this.grpbxAreaDef.TabIndex = 5;
            this.grpbxAreaDef.TabStop = false;
            this.grpbxAreaDef.Text = "Alan Tanımlama";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnMapping);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtRobotXCoor);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtRobotYCoor);
            this.groupBox1.Location = new System.Drawing.Point(251, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 163);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Robot Koordinatları";
            // 
            // btnMapping
            // 
            this.btnMapping.Location = new System.Drawing.Point(9, 102);
            this.btnMapping.Name = "btnMapping";
            this.btnMapping.Size = new System.Drawing.Size(176, 26);
            this.btnMapping.TabIndex = 5;
            this.btnMapping.Text = "Robot Konumunu Belirle";
            this.btnMapping.UseVisualStyleBackColor = true;
            this.btnMapping.Click += new System.EventHandler(this.place_click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Robot Yönü";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Yatay Koordinatı:";
            // 
            // txtRobotXCoor
            // 
            this.txtRobotXCoor.Location = new System.Drawing.Point(118, 22);
            this.txtRobotXCoor.Name = "txtRobotXCoor";
            this.txtRobotXCoor.Size = new System.Drawing.Size(67, 20);
            this.txtRobotXCoor.TabIndex = 4;
            this.txtRobotXCoor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRobotXCoor_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Düşey Koordiantı:";
            // 
            // txtRobotYCoor
            // 
            this.txtRobotYCoor.Location = new System.Drawing.Point(118, 47);
            this.txtRobotYCoor.Name = "txtRobotYCoor";
            this.txtRobotYCoor.Size = new System.Drawing.Size(67, 20);
            this.txtRobotYCoor.TabIndex = 5;
            this.txtRobotYCoor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRobotYCoor_KeyPress);
            // 
            // cbxDirection
            // 
            this.cbxDirection.FormattingEnabled = true;
            this.cbxDirection.Items.AddRange(new object[] {
            "→",
            "←",
            "↑",
            "↓"});
            this.cbxDirection.Location = new System.Drawing.Point(369, 84);
            this.cbxDirection.Name = "cbxDirection";
            this.cbxDirection.Size = new System.Drawing.Size(67, 21);
            this.cbxDirection.TabIndex = 7;
            // 
            // grpArea
            // 
            this.grpArea.Location = new System.Drawing.Point(12, 236);
            this.grpArea.Name = "grpArea";
            this.grpArea.Size = new System.Drawing.Size(439, 304);
            this.grpArea.TabIndex = 8;
            this.grpArea.TabStop = false;
            this.grpArea.Text = "Alan";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Robot için yön komutlarını giriniz..";
            // 
            // txtRotations
            // 
            this.txtRotations.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRotations.Location = new System.Drawing.Point(183, 17);
            this.txtRotations.Name = "txtRotations";
            this.txtRotations.Size = new System.Drawing.Size(152, 20);
            this.txtRotations.TabIndex = 10;
            this.txtRotations.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnRun);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtRotations);
            this.groupBox2.Location = new System.Drawing.Point(12, 181);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(439, 49);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(341, 15);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(83, 23);
            this.btnRun.TabIndex = 11;
            this.btnRun.Text = "Başla";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmRobotic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 549);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grpArea);
            this.Controls.Add(this.cbxDirection);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpbxAreaDef);
            this.Name = "frmRobotic";
            this.Text = "Haritalama";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpbxAreaDef.ResumeLayout(false);
            this.grpbxAreaDef.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TextBox txtX;
		private System.Windows.Forms.TextBox txtY;
		private System.Windows.Forms.Label lblX;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnArea;
		private System.Windows.Forms.GroupBox grpbxAreaDef;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtRobotXCoor;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtRobotYCoor;
		private System.Windows.Forms.ComboBox cbxDirection;
		private System.Windows.Forms.GroupBox grpArea;
		private System.Windows.Forms.Button btnMapping;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRotations;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnRun;
    }
}

