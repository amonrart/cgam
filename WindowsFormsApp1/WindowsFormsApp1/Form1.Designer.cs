namespace WindowsFormsApp1
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
            this.btnDraw = new System.Windows.Forms.Button();
            this.lblCo = new System.Windows.Forms.Label();
            this.btnColor = new System.Windows.Forms.Button();
            this.lblColor = new System.Windows.Forms.Label();
            this.txtW = new System.Windows.Forms.TextBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.btnClear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtXs = new System.Windows.Forms.TextBox();
            this.txtXe = new System.Windows.Forms.TextBox();
            this.txtYs = new System.Windows.Forms.TextBox();
            this.txtYe = new System.Windows.Forms.TextBox();
            this.btnClearData = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbLine = new System.Windows.Forms.RadioButton();
            this.rdbRect = new System.Windows.Forms.RadioButton();
            this.rdbCir = new System.Windows.Forms.RadioButton();
            this.chkMouseDraw = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDraw
            // 
            this.btnDraw.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnDraw.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDraw.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnDraw.Location = new System.Drawing.Point(807, 238);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(91, 34);
            this.btnDraw.TabIndex = 0;
            this.btnDraw.Text = "วาดรูป";
            this.btnDraw.UseVisualStyleBackColor = false;
            this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);
            // 
            // lblCo
            // 
            this.lblCo.AutoSize = true;
            this.lblCo.Location = new System.Drawing.Point(766, 362);
            this.lblCo.Name = "lblCo";
            this.lblCo.Size = new System.Drawing.Size(51, 13);
            this.lblCo.TabIndex = 1;
            this.lblCo.Text = "จุดพิกัด =";
            // 
            // btnColor
            // 
            this.btnColor.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnColor.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnColor.Location = new System.Drawing.Point(769, 24);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(91, 31);
            this.btnColor.TabIndex = 2;
            this.btnColor.Text = "เลือกสี";
            this.btnColor.UseVisualStyleBackColor = false;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblColor.Location = new System.Drawing.Point(876, 32);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(52, 16);
            this.lblColor.TabIndex = 3;
            this.lblColor.Text = "แสดงค่าสี";
            // 
            // txtW
            // 
            this.txtW.Location = new System.Drawing.Point(946, 24);
            this.txtW.Multiline = true;
            this.txtW.Name = "txtW";
            this.txtW.Size = new System.Drawing.Size(71, 31);
            this.txtW.TabIndex = 4;
            this.txtW.Text = "10";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnClear.Location = new System.Drawing.Point(925, 238);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(92, 34);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "ลบรูป";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.Location = new System.Drawing.Point(755, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "จุดเริ่ม";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.Location = new System.Drawing.Point(755, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "จุดสิ้นสุด";
            // 
            // txtXs
            // 
            this.txtXs.Location = new System.Drawing.Point(825, 83);
            this.txtXs.Multiline = true;
            this.txtXs.Name = "txtXs";
            this.txtXs.Size = new System.Drawing.Size(73, 31);
            this.txtXs.TabIndex = 8;
            this.txtXs.Text = "50";
            // 
            // txtXe
            // 
            this.txtXe.Location = new System.Drawing.Point(825, 122);
            this.txtXe.Multiline = true;
            this.txtXe.Name = "txtXe";
            this.txtXe.Size = new System.Drawing.Size(73, 27);
            this.txtXe.TabIndex = 9;
            this.txtXe.Text = "204";
            // 
            // txtYs
            // 
            this.txtYs.Location = new System.Drawing.Point(943, 82);
            this.txtYs.Multiline = true;
            this.txtYs.Name = "txtYs";
            this.txtYs.Size = new System.Drawing.Size(71, 30);
            this.txtYs.TabIndex = 10;
            this.txtYs.Text = "305";
            // 
            // txtYe
            // 
            this.txtYe.Location = new System.Drawing.Point(943, 122);
            this.txtYe.Multiline = true;
            this.txtYe.Name = "txtYe";
            this.txtYe.Size = new System.Drawing.Size(71, 30);
            this.txtYe.TabIndex = 11;
            this.txtYe.Text = "102";
            // 
            // btnClearData
            // 
            this.btnClearData.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClearData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnClearData.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnClearData.Location = new System.Drawing.Point(815, 164);
            this.btnClearData.Name = "btnClearData";
            this.btnClearData.Size = new System.Drawing.Size(181, 34);
            this.btnClearData.TabIndex = 12;
            this.btnClearData.Text = "ล้างข้อมูล";
            this.btnClearData.UseVisualStyleBackColor = false;
            this.btnClearData.Click += new System.EventHandler(this.btnClearData_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbCir);
            this.groupBox1.Controls.Add(this.rdbRect);
            this.groupBox1.Controls.Add(this.rdbLine);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(279, 205);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "เลือกรูปทรง";
            // 
            // rdbLine
            // 
            this.rdbLine.AutoSize = true;
            this.rdbLine.Location = new System.Drawing.Point(6, 37);
            this.rdbLine.Name = "rdbLine";
            this.rdbLine.Size = new System.Drawing.Size(73, 24);
            this.rdbLine.TabIndex = 0;
            this.rdbLine.TabStop = true;
            this.rdbLine.Text = "เส้นตรง";
            this.rdbLine.UseVisualStyleBackColor = true;
            // 
            // rdbRect
            // 
            this.rdbRect.AutoSize = true;
            this.rdbRect.Location = new System.Drawing.Point(131, 37);
            this.rdbRect.Name = "rdbRect";
            this.rdbRect.Size = new System.Drawing.Size(76, 24);
            this.rdbRect.TabIndex = 1;
            this.rdbRect.TabStop = true;
            this.rdbRect.Text = "สี่เหลี่ยม";
            this.rdbRect.UseVisualStyleBackColor = true;
            // 
            // rdbCir
            // 
            this.rdbCir.AutoSize = true;
            this.rdbCir.Location = new System.Drawing.Point(7, 82);
            this.rdbCir.Name = "rdbCir";
            this.rdbCir.Size = new System.Drawing.Size(93, 24);
            this.rdbCir.TabIndex = 2;
            this.rdbCir.TabStop = true;
            this.rdbCir.Text = "วงกลม/วงรี";
            this.rdbCir.UseVisualStyleBackColor = true;
            // 
            // chkMouseDraw
            // 
            this.chkMouseDraw.AutoSize = true;
            this.chkMouseDraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.chkMouseDraw.Location = new System.Drawing.Point(313, 24);
            this.chkMouseDraw.Name = "chkMouseDraw";
            this.chkMouseDraw.Size = new System.Drawing.Size(145, 24);
            this.chkMouseDraw.TabIndex = 14;
            this.chkMouseDraw.Text = "วาดรูปเส้นด้วยเมาส์";
            this.chkMouseDraw.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 571);
            this.Controls.Add(this.chkMouseDraw);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnClearData);
            this.Controls.Add(this.txtYe);
            this.Controls.Add(this.txtYs);
            this.Controls.Add(this.txtXe);
            this.Controls.Add(this.txtXs);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtW);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.lblCo);
            this.Controls.Add(this.btnDraw);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDraw;
        private System.Windows.Forms.Label lblCo;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.TextBox txtW;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtXs;
        private System.Windows.Forms.TextBox txtXe;
        private System.Windows.Forms.TextBox txtYs;
        private System.Windows.Forms.TextBox txtYe;
        private System.Windows.Forms.Button btnClearData;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbCir;
        private System.Windows.Forms.RadioButton rdbRect;
        private System.Windows.Forms.RadioButton rdbLine;
        private System.Windows.Forms.CheckBox chkMouseDraw;
    }
}

