namespace CSharpChart.Sample
{
    partial class BarChartForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button4 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.barTitleImageHeightNumeric = new System.Windows.Forms.NumericUpDown();
            this.barTitleImageWidthNumeric = new System.Windows.Forms.NumericUpDown();
            this.barTitleImagePictureBox = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.loadOptionButton = new System.Windows.Forms.Button();
            this.saveOptionButton = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.axisColorLabel = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.axisSpacingNumeric = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.barCaptionColorLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.autoBarCaptionColorCheckBox = new System.Windows.Forms.CheckBox();
            this.barCaptionFontLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.barCaptionVisibleCheckBox = new System.Windows.Forms.CheckBox();
            this.barValueFontLabel = new System.Windows.Forms.Label();
            this.barValueVisibleCheckBox = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.autoBarSizeCheckBox = new System.Windows.Forms.CheckBox();
            this.barSpacingNumeric = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.barSizeNumeric = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.fontDialog = new System.Windows.Forms.FontDialog();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.실행ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.중지ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.보기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.하단숨김ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.우측숨김ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.항목이미지설정ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label5 = new System.Windows.Forms.Label();
            this.chartLeftPaddingNumeric = new System.Windows.Forms.NumericUpDown();
            this.horizontalBarChart1 = new CSharpChart.Bar.HorizontalBarChart();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barTitleImageHeightNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barTitleImageWidthNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barTitleImagePictureBox)).BeginInit();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axisSpacingNumeric)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barSpacingNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barSizeNumeric)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartLeftPaddingNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(65, 49);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 29);
            this.button1.TabIndex = 1;
            this.button1.Text = "Serie 추가";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(335, 12);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 29);
            this.button2.TabIndex = 2;
            this.button2.Text = "serie 값 +";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(335, 49);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(86, 29);
            this.button3.TabIndex = 3;
            this.button3.Text = "Serie 값 -";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(533, 12);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(155, 29);
            this.button4.TabIndex = 4;
            this.button4.Text = "랜덤 타이머 토글";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 1608F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 28);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 112F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1608, 1200);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button7);
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 1092);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(1602, 104);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "제어";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(695, 12);
            this.button7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(89, 29);
            this.button7.TabIndex = 7;
            this.button7.Text = "컬러 변경";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.Button7_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(695, 49);
            this.button6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(89, 29);
            this.button6.TabIndex = 6;
            this.button6.Text = "항목 변경";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.Button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(533, 49);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(155, 29);
            this.button5.TabIndex = 5;
            this.button5.Text = "지정 항목 + 10";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 352F));
            this.tableLayoutPanel2.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.groupBox3, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 4);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1602, 1080);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.horizontalBarChart1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(0);
            this.groupBox1.Size = new System.Drawing.Size(1250, 1080);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chart";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox7);
            this.groupBox3.Controls.Add(this.loadOptionButton);
            this.groupBox3.Controls.Add(this.saveOptionButton);
            this.groupBox3.Controls.Add(this.groupBox6);
            this.groupBox3.Controls.Add(this.groupBox5);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(1253, 4);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Size = new System.Drawing.Size(346, 1072);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "차트 설정";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.chartLeftPaddingNumeric);
            this.groupBox7.Controls.Add(this.label5);
            this.groupBox7.Controls.Add(this.barTitleImageHeightNumeric);
            this.groupBox7.Controls.Add(this.barTitleImageWidthNumeric);
            this.groupBox7.Controls.Add(this.barTitleImagePictureBox);
            this.groupBox7.Controls.Add(this.label4);
            this.groupBox7.Location = new System.Drawing.Point(7, 826);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox7.Size = new System.Drawing.Size(331, 238);
            this.groupBox7.TabIndex = 17;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "이미지 설정";
            // 
            // barTitleImageHeightNumeric
            // 
            this.barTitleImageHeightNumeric.Location = new System.Drawing.Point(130, 152);
            this.barTitleImageHeightNumeric.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barTitleImageHeightNumeric.Name = "barTitleImageHeightNumeric";
            this.barTitleImageHeightNumeric.Size = new System.Drawing.Size(88, 25);
            this.barTitleImageHeightNumeric.TabIndex = 19;
            this.barTitleImageHeightNumeric.ValueChanged += new System.EventHandler(this.OptionValue_Changed);
            // 
            // barTitleImageWidthNumeric
            // 
            this.barTitleImageWidthNumeric.Location = new System.Drawing.Point(26, 152);
            this.barTitleImageWidthNumeric.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barTitleImageWidthNumeric.Name = "barTitleImageWidthNumeric";
            this.barTitleImageWidthNumeric.Size = new System.Drawing.Size(97, 25);
            this.barTitleImageWidthNumeric.TabIndex = 18;
            this.barTitleImageWidthNumeric.ValueChanged += new System.EventHandler(this.OptionValue_Changed);
            // 
            // barTitleImagePictureBox
            // 
            this.barTitleImagePictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.barTitleImagePictureBox.Location = new System.Drawing.Point(26, 68);
            this.barTitleImagePictureBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barTitleImagePictureBox.Name = "barTitleImagePictureBox";
            this.barTitleImagePictureBox.Size = new System.Drawing.Size(192, 78);
            this.barTitleImagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.barTitleImagePictureBox.TabIndex = 17;
            this.barTitleImagePictureBox.TabStop = false;
            this.barTitleImagePictureBox.DoubleClick += new System.EventHandler(this.BarTitleImagePictureBox_DoubleClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 34);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(198, 15);
            this.label4.TabIndex = 16;
            this.label4.Text = "상단이미지 / 가로 세로 크기";
            // 
            // loadOptionButton
            // 
            this.loadOptionButton.Location = new System.Drawing.Point(191, 25);
            this.loadOptionButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.loadOptionButton.Name = "loadOptionButton";
            this.loadOptionButton.Size = new System.Drawing.Size(133, 29);
            this.loadOptionButton.TabIndex = 16;
            this.loadOptionButton.Text = "설정 불러오기";
            this.loadOptionButton.UseVisualStyleBackColor = true;
            this.loadOptionButton.Click += new System.EventHandler(this.LoadOptionButton_Click);
            // 
            // saveOptionButton
            // 
            this.saveOptionButton.Location = new System.Drawing.Point(25, 25);
            this.saveOptionButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.saveOptionButton.Name = "saveOptionButton";
            this.saveOptionButton.Size = new System.Drawing.Size(133, 29);
            this.saveOptionButton.TabIndex = 15;
            this.saveOptionButton.Text = "현재 설정 저장";
            this.saveOptionButton.UseVisualStyleBackColor = true;
            this.saveOptionButton.Click += new System.EventHandler(this.SaveOptionButton_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.axisColorLabel);
            this.groupBox6.Controls.Add(this.label11);
            this.groupBox6.Controls.Add(this.axisSpacingNumeric);
            this.groupBox6.Controls.Add(this.label9);
            this.groupBox6.Location = new System.Drawing.Point(7, 640);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox6.Size = new System.Drawing.Size(331, 179);
            this.groupBox6.TabIndex = 14;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "축 설정";
            // 
            // axisColorLabel
            // 
            this.axisColorLabel.AutoSize = true;
            this.axisColorLabel.Location = new System.Drawing.Point(24, 141);
            this.axisColorLabel.Name = "axisColorLabel";
            this.axisColorLabel.Size = new System.Drawing.Size(57, 15);
            this.axisColorLabel.TabIndex = 15;
            this.axisColorLabel.Text = "축 색상";
            this.axisColorLabel.ForeColorChanged += new System.EventHandler(this.OptionValue_Changed);
            this.axisColorLabel.DoubleClick += new System.EventHandler(this.colorLabel_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(24, 114);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(148, 15);
            this.label11.TabIndex = 14;
            this.label11.Text = "AxisColor ( 축 색상 )";
            // 
            // axisSpacingNumeric
            // 
            this.axisSpacingNumeric.Location = new System.Drawing.Point(26, 68);
            this.axisSpacingNumeric.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.axisSpacingNumeric.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.axisSpacingNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            327680});
            this.axisSpacingNumeric.Name = "axisSpacingNumeric";
            this.axisSpacingNumeric.Size = new System.Drawing.Size(137, 25);
            this.axisSpacingNumeric.TabIndex = 5;
            this.axisSpacingNumeric.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.axisSpacingNumeric.ValueChanged += new System.EventHandler(this.OptionValue_Changed);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(166, 15);
            this.label9.TabIndex = 4;
            this.label9.Text = "AxisSpacing ( 축 간격 )";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.barCaptionColorLabel);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.autoBarCaptionColorCheckBox);
            this.groupBox5.Controls.Add(this.barCaptionFontLabel);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.barCaptionVisibleCheckBox);
            this.groupBox5.Controls.Add(this.barValueFontLabel);
            this.groupBox5.Controls.Add(this.barValueVisibleCheckBox);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Location = new System.Drawing.Point(7, 289);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox5.Size = new System.Drawing.Size(331, 344);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "정보 표시";
            // 
            // barCaptionColorLabel
            // 
            this.barCaptionColorLabel.AutoSize = true;
            this.barCaptionColorLabel.Location = new System.Drawing.Point(24, 302);
            this.barCaptionColorLabel.Name = "barCaptionColorLabel";
            this.barCaptionColorLabel.Size = new System.Drawing.Size(107, 15);
            this.barCaptionColorLabel.TabIndex = 13;
            this.barCaptionColorLabel.Text = "항목 캡션 색상";
            this.barCaptionColorLabel.ForeColorChanged += new System.EventHandler(this.OptionValue_Changed);
            this.barCaptionColorLabel.DoubleClick += new System.EventHandler(this.colorLabel_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 275);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(241, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "BarCaptionColor ( 항목 캡션 색상 )";
            // 
            // autoBarCaptionColorCheckBox
            // 
            this.autoBarCaptionColorCheckBox.AutoSize = true;
            this.autoBarCaptionColorCheckBox.Location = new System.Drawing.Point(26, 165);
            this.autoBarCaptionColorCheckBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.autoBarCaptionColorCheckBox.Name = "autoBarCaptionColorCheckBox";
            this.autoBarCaptionColorCheckBox.Size = new System.Drawing.Size(229, 19);
            this.autoBarCaptionColorCheckBox.TabIndex = 11;
            this.autoBarCaptionColorCheckBox.Text = "자동으로 항목 캡션 색상 설정";
            this.autoBarCaptionColorCheckBox.UseVisualStyleBackColor = true;
            this.autoBarCaptionColorCheckBox.CheckedChanged += new System.EventHandler(this.OptionValue_Changed);
            // 
            // barCaptionFontLabel
            // 
            this.barCaptionFontLabel.AutoSize = true;
            this.barCaptionFontLabel.Location = new System.Drawing.Point(24, 234);
            this.barCaptionFontLabel.Name = "barCaptionFontLabel";
            this.barCaptionFontLabel.Size = new System.Drawing.Size(107, 15);
            this.barCaptionFontLabel.TabIndex = 10;
            this.barCaptionFontLabel.Text = "항목 캡션 폰트";
            this.barCaptionFontLabel.TextChanged += new System.EventHandler(this.OptionValue_Changed);
            this.barCaptionFontLabel.DoubleClick += new System.EventHandler(this.fontLabel_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 208);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(235, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "BarCaptionFont ( 항목 캡션 폰트 )";
            // 
            // barCaptionVisibleCheckBox
            // 
            this.barCaptionVisibleCheckBox.AutoSize = true;
            this.barCaptionVisibleCheckBox.Location = new System.Drawing.Point(26, 138);
            this.barCaptionVisibleCheckBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barCaptionVisibleCheckBox.Name = "barCaptionVisibleCheckBox";
            this.barCaptionVisibleCheckBox.Size = new System.Drawing.Size(304, 19);
            this.barCaptionVisibleCheckBox.TabIndex = 8;
            this.barCaptionVisibleCheckBox.Text = "BarCaptionVisible ( 항목 캡션 표시 여부 )";
            this.barCaptionVisibleCheckBox.UseVisualStyleBackColor = true;
            this.barCaptionVisibleCheckBox.CheckedChanged += new System.EventHandler(this.OptionValue_Changed);
            // 
            // barValueFontLabel
            // 
            this.barValueFontLabel.AutoSize = true;
            this.barValueFontLabel.Location = new System.Drawing.Point(24, 88);
            this.barValueFontLabel.Name = "barValueFontLabel";
            this.barValueFontLabel.Size = new System.Drawing.Size(92, 15);
            this.barValueFontLabel.TabIndex = 7;
            this.barValueFontLabel.Text = "항목 값 폰트";
            this.barValueFontLabel.TextChanged += new System.EventHandler(this.OptionValue_Changed);
            this.barValueFontLabel.DoubleClick += new System.EventHandler(this.fontLabel_Click);
            // 
            // barValueVisibleCheckBox
            // 
            this.barValueVisibleCheckBox.AutoSize = true;
            this.barValueVisibleCheckBox.Location = new System.Drawing.Point(26, 25);
            this.barValueVisibleCheckBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barValueVisibleCheckBox.Name = "barValueVisibleCheckBox";
            this.barValueVisibleCheckBox.Size = new System.Drawing.Size(274, 19);
            this.barValueVisibleCheckBox.TabIndex = 1;
            this.barValueVisibleCheckBox.Text = "BarValueVisible ( 항목 값 표시 여부 )";
            this.barValueVisibleCheckBox.UseVisualStyleBackColor = true;
            this.barValueVisibleCheckBox.CheckedChanged += new System.EventHandler(this.OptionValue_Changed);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(205, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "BarValueFont ( 항목 값 폰트 )";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.autoBarSizeCheckBox);
            this.groupBox4.Controls.Add(this.barSpacingNumeric);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.barSizeNumeric);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Location = new System.Drawing.Point(7, 72);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox4.Size = new System.Drawing.Size(331, 209);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Bar 모양";
            // 
            // autoBarSizeCheckBox
            // 
            this.autoBarSizeCheckBox.AutoSize = true;
            this.autoBarSizeCheckBox.Location = new System.Drawing.Point(192, 79);
            this.autoBarSizeCheckBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.autoBarSizeCheckBox.Name = "autoBarSizeCheckBox";
            this.autoBarSizeCheckBox.Size = new System.Drawing.Size(119, 19);
            this.autoBarSizeCheckBox.TabIndex = 4;
            this.autoBarSizeCheckBox.Text = "자동 바 크기 ";
            this.autoBarSizeCheckBox.UseVisualStyleBackColor = true;
            this.autoBarSizeCheckBox.CheckedChanged += new System.EventHandler(this.OptionValue_Changed);
            // 
            // barSpacingNumeric
            // 
            this.barSpacingNumeric.Location = new System.Drawing.Point(26, 151);
            this.barSpacingNumeric.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barSpacingNumeric.Name = "barSpacingNumeric";
            this.barSpacingNumeric.Size = new System.Drawing.Size(137, 25);
            this.barSpacingNumeric.TabIndex = 3;
            this.barSpacingNumeric.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.barSpacingNumeric.ValueChanged += new System.EventHandler(this.OptionValue_Changed);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "BarSpacing ( 바 간격 )";
            // 
            // barSizeNumeric
            // 
            this.barSizeNumeric.Location = new System.Drawing.Point(26, 72);
            this.barSizeNumeric.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barSizeNumeric.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.barSizeNumeric.Name = "barSizeNumeric";
            this.barSizeNumeric.Size = new System.Drawing.Size(137, 25);
            this.barSizeNumeric.TabIndex = 1;
            this.barSizeNumeric.Value = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.barSizeNumeric.ValueChanged += new System.EventHandler(this.OptionValue_Changed);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "BarSize ( 바 크기 )";
            // 
            // timer2
            // 
            this.timer2.Interval = 1;
            this.timer2.Tick += new System.EventHandler(this.Timer2_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.실행ToolStripMenuItem,
            this.중지ToolStripMenuItem,
            this.보기ToolStripMenuItem,
            this.항목이미지설정ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1608, 28);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 실행ToolStripMenuItem
            // 
            this.실행ToolStripMenuItem.Name = "실행ToolStripMenuItem";
            this.실행ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.실행ToolStripMenuItem.Text = "실행";
            this.실행ToolStripMenuItem.Click += new System.EventHandler(this.실행ToolStripMenuItem_Click);
            // 
            // 중지ToolStripMenuItem
            // 
            this.중지ToolStripMenuItem.Name = "중지ToolStripMenuItem";
            this.중지ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.중지ToolStripMenuItem.Text = "중지";
            this.중지ToolStripMenuItem.Click += new System.EventHandler(this.중지ToolStripMenuItem_Click);
            // 
            // 보기ToolStripMenuItem
            // 
            this.보기ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.하단숨김ToolStripMenuItem,
            this.우측숨김ToolStripMenuItem});
            this.보기ToolStripMenuItem.Name = "보기ToolStripMenuItem";
            this.보기ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.보기ToolStripMenuItem.Text = "보기";
            // 
            // 하단숨김ToolStripMenuItem
            // 
            this.하단숨김ToolStripMenuItem.Name = "하단숨김ToolStripMenuItem";
            this.하단숨김ToolStripMenuItem.Size = new System.Drawing.Size(149, 26);
            this.하단숨김ToolStripMenuItem.Text = "하단 숨김";
            this.하단숨김ToolStripMenuItem.Click += new System.EventHandler(this.하단숨김ToolStripMenuItem_Click);
            // 
            // 우측숨김ToolStripMenuItem
            // 
            this.우측숨김ToolStripMenuItem.Name = "우측숨김ToolStripMenuItem";
            this.우측숨김ToolStripMenuItem.Size = new System.Drawing.Size(149, 26);
            this.우측숨김ToolStripMenuItem.Text = "우측 숨김";
            this.우측숨김ToolStripMenuItem.Click += new System.EventHandler(this.우측숨김ToolStripMenuItem_Click);
            // 
            // 항목이미지설정ToolStripMenuItem
            // 
            this.항목이미지설정ToolStripMenuItem.Name = "항목이미지설정ToolStripMenuItem";
            this.항목이미지설정ToolStripMenuItem.Size = new System.Drawing.Size(136, 24);
            this.항목이미지설정ToolStripMenuItem.Text = "항목 이미지 설정";
            this.항목이미지설정ToolStripMenuItem.Click += new System.EventHandler(this.항목이미지설정ToolStripMenuItem_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 190);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(172, 15);
            this.label5.TabIndex = 20;
            this.label5.Text = "항목 이미지 가로 사이즈";
            // 
            // chartLeftPaddingNumeric
            // 
            this.chartLeftPaddingNumeric.Location = new System.Drawing.Point(27, 213);
            this.chartLeftPaddingNumeric.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chartLeftPaddingNumeric.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.chartLeftPaddingNumeric.Name = "chartLeftPaddingNumeric";
            this.chartLeftPaddingNumeric.Size = new System.Drawing.Size(97, 25);
            this.chartLeftPaddingNumeric.TabIndex = 21;
            this.chartLeftPaddingNumeric.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.chartLeftPaddingNumeric.ValueChanged += new System.EventHandler(this.OptionValue_Changed);
            // 
            // horizontalBarChart1
            // 
            this.horizontalBarChart1.AutoBarCaptionColor = true;
            this.horizontalBarChart1.AutoBarSize = false;
            this.horizontalBarChart1.AutoBarSpacing = false;
            this.horizontalBarChart1.AxisColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.horizontalBarChart1.AxisLineSpacing = 100F;
            this.horizontalBarChart1.BackColor = System.Drawing.Color.White;
            this.horizontalBarChart1.BarCaptionColor = System.Drawing.Color.Black;
            this.horizontalBarChart1.BarCaptionFont = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.horizontalBarChart1.BarCaptionVisible = true;
            this.horizontalBarChart1.BarSize = 40F;
            this.horizontalBarChart1.BarSpacing = 10F;
            this.horizontalBarChart1.BarTitleImage = global::CSharpChart.Sample.Properties.Resources.charttitle;
            this.horizontalBarChart1.BarTitleImageSize = new System.Drawing.Size(350, 100);
            this.horizontalBarChart1.BarValueFont = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.horizontalBarChart1.BarValueVisible = true;
            this.horizontalBarChart1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.horizontalBarChart1.Location = new System.Drawing.Point(0, 18);
            this.horizontalBarChart1.Margin = new System.Windows.Forms.Padding(0);
            this.horizontalBarChart1.Name = "horizontalBarChart1";
            this.horizontalBarChart1.Padding = new System.Windows.Forms.Padding(250, 250, 229, 250);
            this.horizontalBarChart1.Size = new System.Drawing.Size(1250, 1062);
            this.horizontalBarChart1.TabIndex = 0;
            this.horizontalBarChart1.Text = "horizontalBarChart1";
            // 
            // BarChartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1608, 1228);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "BarChartForm";
            this.Text = "Barrrrrrrrrrrr";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barTitleImageHeightNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barTitleImageWidthNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barTitleImagePictureBox)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axisSpacingNumeric)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barSpacingNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barSizeNumeric)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartLeftPaddingNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private Bar.HorizontalBarChart horizontalBarChart1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.NumericUpDown barSizeNumeric;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.CheckBox barValueVisibleCheckBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox autoBarSizeCheckBox;
        private System.Windows.Forms.NumericUpDown barSpacingNumeric;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FontDialog fontDialog;
        private System.Windows.Forms.Label barValueFontLabel;
        private System.Windows.Forms.CheckBox autoBarCaptionColorCheckBox;
        private System.Windows.Forms.Label barCaptionFontLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox barCaptionVisibleCheckBox;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label axisColorLabel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown axisSpacingNumeric;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label barCaptionColorLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 실행ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 중지ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 보기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 하단숨김ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 우측숨김ToolStripMenuItem;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button loadOptionButton;
        private System.Windows.Forms.Button saveOptionButton;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.PictureBox barTitleImagePictureBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown barTitleImageHeightNumeric;
        private System.Windows.Forms.NumericUpDown barTitleImageWidthNumeric;
        private System.Windows.Forms.ToolStripMenuItem 항목이미지설정ToolStripMenuItem;
        private System.Windows.Forms.NumericUpDown chartLeftPaddingNumeric;
        private System.Windows.Forms.Label label5;
    }
}

