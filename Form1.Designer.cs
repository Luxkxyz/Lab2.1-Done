namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            Save = new Button();
            TBinputName = new TextBox();
            label2 = new Label();
            label4 = new Label();
            label1 = new Label();
            TBinputPoint = new TextBox();
            TBinputID = new TextBox();
            groupBox2 = new GroupBox();
            label10 = new Label();
            average = new TextBox();
            Lowpoint = new TextBox();
            Highpoint = new TextBox();
            LowName = new TextBox();
            HighName = new TextBox();
            HighID = new TextBox();
            LowID = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label15);
            groupBox1.Controls.Add(label14);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(Save);
            groupBox1.Controls.Add(TBinputName);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(TBinputPoint);
            groupBox1.Controls.Add(TBinputID);
            groupBox1.Location = new Point(24, 28);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(336, 413);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "กรอกข้อมูล";
            // 
            // Save
            // 
            Save.Location = new Point(136, 206);
            Save.Name = "Save";
            Save.Size = new Size(75, 23);
            Save.TabIndex = 1;
            Save.Text = "บันทึก";
            Save.UseVisualStyleBackColor = true;
            Save.Click += Save_Click;
            // 
            // TBinputName
            // 
            TBinputName.Font = new Font("Leelawadee UI", 10F);
            TBinputName.Location = new Point(111, 112);
            TBinputName.Name = "TBinputName";
            TBinputName.Size = new Size(100, 25);
            TBinputName.TabIndex = 1;
            TBinputName.TextChanged += TBinputName_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 117);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 1;
            label2.Text = "ชื่อ-นามสกุล";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Leelawadee UI", 12F);
            label4.Location = new Point(40, 166);
            label4.Name = "label4";
            label4.Size = new Size(52, 21);
            label4.TabIndex = 5;
            label4.Text = "คะแนน";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 66);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 1;
            label1.Text = "รหัสนักศึกษา";
            // 
            // TBinputPoint
            // 
            TBinputPoint.Font = new Font("Leelawadee UI", 10F);
            TBinputPoint.Location = new Point(111, 162);
            TBinputPoint.Name = "TBinputPoint";
            TBinputPoint.Size = new Size(100, 25);
            TBinputPoint.TabIndex = 2;
            TBinputPoint.TextChanged += TBinputPoint_TextChanged;
            // 
            // TBinputID
            // 
            TBinputID.Font = new Font("Leelawadee UI", 10F);
            TBinputID.Location = new Point(111, 61);
            TBinputID.Name = "TBinputID";
            TBinputID.Size = new Size(100, 25);
            TBinputID.TabIndex = 0;
            TBinputID.TextChanged += TBinputID_TextChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label16);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(average);
            groupBox2.Controls.Add(Lowpoint);
            groupBox2.Controls.Add(Highpoint);
            groupBox2.Controls.Add(LowName);
            groupBox2.Controls.Add(HighName);
            groupBox2.Controls.Add(HighID);
            groupBox2.Controls.Add(LowID);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label3);
            groupBox2.Location = new Point(391, 28);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(397, 413);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "ผลลัพท์";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Leelawadee UI", 9F);
            label10.Location = new Point(194, 206);
            label10.Name = "label10";
            label10.Size = new Size(60, 15);
            label10.TabIndex = 15;
            label10.Text = "คะแนนเฉลี่ย";
            // 
            // average
            // 
            average.Location = new Point(274, 203);
            average.Name = "average";
            average.Size = new Size(94, 23);
            average.TabIndex = 10;
            // 
            // Lowpoint
            // 
            Lowpoint.Location = new Point(274, 152);
            Lowpoint.Name = "Lowpoint";
            Lowpoint.Size = new Size(94, 23);
            Lowpoint.TabIndex = 14;
            // 
            // Highpoint
            // 
            Highpoint.Location = new Point(274, 88);
            Highpoint.Name = "Highpoint";
            Highpoint.Size = new Size(94, 23);
            Highpoint.TabIndex = 13;
            // 
            // LowName
            // 
            LowName.Location = new Point(174, 152);
            LowName.Name = "LowName";
            LowName.Size = new Size(94, 23);
            LowName.TabIndex = 12;
            // 
            // HighName
            // 
            HighName.Location = new Point(174, 88);
            HighName.Name = "HighName";
            HighName.Size = new Size(94, 23);
            HighName.TabIndex = 11;
            // 
            // HighID
            // 
            HighID.Location = new Point(74, 88);
            HighID.Name = "HighID";
            HighID.Size = new Size(94, 23);
            HighID.TabIndex = 10;
            HighID.TextChanged += HighID_TextChanged;
            // 
            // LowID
            // 
            LowID.Location = new Point(75, 152);
            LowID.Name = "LowID";
            LowID.Size = new Size(94, 23);
            LowID.TabIndex = 9;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Leelawadee UI", 9F);
            label9.Location = new Point(6, 152);
            label9.Name = "label9";
            label9.Size = new Size(63, 15);
            label9.TabIndex = 8;
            label9.Text = "คะแนนต่ำสุด";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Leelawadee UI", 9F);
            label8.Location = new Point(6, 88);
            label8.Name = "label8";
            label8.Size = new Size(62, 15);
            label8.TabIndex = 7;
            label8.Text = "คะแนนสูงสุด";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Leelawadee UI", 9F);
            label7.Location = new Point(299, 61);
            label7.Name = "label7";
            label7.Size = new Size(38, 15);
            label7.TabIndex = 6;
            label7.Text = "คะแนน";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(191, 61);
            label6.Name = "label6";
            label6.Size = new Size(63, 15);
            label6.TabIndex = 2;
            label6.Text = "ชื่อ-นามสกุล";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(86, 61);
            label5.Name = "label5";
            label5.Size = new Size(65, 15);
            label5.TabIndex = 2;
            label5.Text = "รหัสนักศึกษา";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(45, 43);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 0;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(369, 270);
            label11.Name = "label11";
            label11.Size = new Size(0, 15);
            label11.TabIndex = 2;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Leelawadee UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(11, 286);
            label12.Name = "label12";
            label12.Size = new Size(224, 21);
            label12.TabIndex = 6;
            label12.Text = "เสฎฐวุฒิ สุทธิสมณ์ 663450044-4";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Leelawadee UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.Location = new Point(11, 242);
            label13.Name = "label13";
            label13.Size = new Size(81, 21);
            label13.TabIndex = 7;
            label13.Text = "สมาชิกกลุ่ม";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Leelawadee UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.Location = new Point(6, 378);
            label14.Name = "label14";
            label14.Size = new Size(219, 21);
            label14.TabIndex = 8;
            label14.Text = "กีรติ สุวรรณภูสิทธิ์ 663450172-5";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Leelawadee UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label15.Location = new Point(11, 328);
            label15.Name = "label15";
            label15.Size = new Size(193, 21);
            label15.TabIndex = 9;
            label15.Text = "ปภพ สุระทิพย์ 663450176-7";
            label15.Click += label15_Click;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Leelawadee UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label16.Location = new Point(10, 286);
            label16.Name = "label16";
            label16.Size = new Size(224, 21);
            label16.TabIndex = 10;
            label16.Text = "กัมปนาท โต้เพชร 6634500034-7";
            label16.Click += label16_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label11);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button Save;
        private TextBox TBinputName;
        private Label label2;
        private Label label4;
        private TextBox TBinputPoint;
        private TextBox TBinputID;
        private Label label1;
        private GroupBox groupBox2;
        private Label label10;
        private TextBox average;
        private TextBox Lowpoint;
        private TextBox Highpoint;
        private TextBox LowName;
        private TextBox HighName;
        private TextBox HighID;
        private TextBox LowID;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label3;
        private Label label11;
        private Label label15;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label16;
    }
}
