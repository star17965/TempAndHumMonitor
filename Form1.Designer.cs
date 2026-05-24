namespace MyCounter111
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
            components = new System.ComponentModel.Container();
            LiveChartsCore.SkiaSharpView.SKCharts.SKDefaultLegend skDefaultLegend1 = new LiveChartsCore.SkiaSharpView.SKCharts.SKDefaultLegend();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            LiveChartsCore.Drawing.Padding padding1 = new LiveChartsCore.Drawing.Padding();
            LiveChartsCore.SkiaSharpView.SKCharts.SKDefaultTooltip skDefaultTooltip1 = new LiveChartsCore.SkiaSharpView.SKCharts.SKDefaultTooltip();
            LiveChartsCore.Drawing.Padding padding2 = new LiveChartsCore.Drawing.Padding();
            lblShow = new Label();
            btnStart = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            btnAdd = new Button();
            btnQuery = new Button();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            lblHumidityTitle = new Label();
            lblHumidity = new Label();
            bindingSource1 = new BindingSource(components);
            cartesianChart1 = new LiveChartsCore.SkiaSharpView.WinForms.CartesianChart();
            btnAddh = new Button();
            btnClear = new Button();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // lblShow
            // 
            lblShow.AutoSize = true;
            lblShow.BackColor = SystemColors.ActiveCaption;
            lblShow.Font = new Font("Microsoft YaHei UI", 15F);
            lblShow.Location = new Point(228, 487);
            lblShow.Name = "lblShow";
            lblShow.Size = new Size(35, 39);
            lblShow.TabIndex = 0;
            lblShow.Text = "0";
            // 
            // btnStart
            // 
            btnStart.Font = new Font("Microsoft YaHei UI", 20F);
            btnStart.Location = new Point(416, 498);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(112, 60);
            btnStart.TabIndex = 1;
            btnStart.Text = "开始";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick_1;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Microsoft YaHei UI", 20F);
            btnAdd.Location = new Point(543, 498);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(112, 60);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "加热";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnQuery
            // 
            btnQuery.Location = new Point(53, 581);
            btnQuery.Name = "btnQuery";
            btnQuery.Size = new Size(112, 37);
            btnQuery.TabIndex = 3;
            btnQuery.Text = "查询历史";
            btnQuery.UseVisualStyleBackColor = true;
            btnQuery.Click += btnQuery_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(356, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(431, 350);
            dataGridView1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 15F);
            label1.Location = new Point(88, 487);
            label1.Name = "label1";
            label1.Size = new Size(144, 39);
            label1.TabIndex = 5;
            label1.Text = "当前温度:";
            label1.Click += label1_Click;
            // 
            // lblHumidityTitle
            // 
            lblHumidityTitle.AutoSize = true;
            lblHumidityTitle.Font = new Font("Microsoft YaHei UI", 15F);
            lblHumidityTitle.Location = new Point(88, 424);
            lblHumidityTitle.Name = "lblHumidityTitle";
            lblHumidityTitle.Size = new Size(144, 39);
            lblHumidityTitle.TabIndex = 6;
            lblHumidityTitle.Text = "当前湿度:";
            // 
            // lblHumidity
            // 
            lblHumidity.AutoSize = true;
            lblHumidity.BackColor = SystemColors.ActiveCaption;
            lblHumidity.Font = new Font("Microsoft YaHei UI", 15F);
            lblHumidity.Location = new Point(228, 424);
            lblHumidity.Name = "lblHumidity";
            lblHumidity.Size = new Size(35, 39);
            lblHumidity.TabIndex = 7;
            lblHumidity.Text = "0";
            // 
            // cartesianChart1
            // 
            cartesianChart1.AutoUpdateEnabled = true;
            cartesianChart1.ChartTheme = null;
            skDefaultLegend1.AnimationsSpeed = TimeSpan.Parse("00:00:00.1500000");
            skDefaultLegend1.Content = null;
            skDefaultLegend1.IsValid = false;
            skDefaultLegend1.Opacity = 1F;
            padding1.Bottom = 0F;
            padding1.Left = 0F;
            padding1.Right = 0F;
            padding1.Top = 0F;
            skDefaultLegend1.Padding = padding1;
            skDefaultLegend1.RemoveOnCompleted = false;
            skDefaultLegend1.RotateTransform = 0F;
            skDefaultLegend1.X = 0F;
            skDefaultLegend1.Y = 0F;
            cartesianChart1.Legend = skDefaultLegend1;
            cartesianChart1.Location = new Point(0, 0);
            cartesianChart1.MatchAxesScreenDataRatio = true;
            cartesianChart1.Name = "cartesianChart1";
            cartesianChart1.Size = new Size(350, 350);
            cartesianChart1.TabIndex = 8;
            skDefaultTooltip1.AnimationsSpeed = TimeSpan.Parse("00:00:00.1500000");
            skDefaultTooltip1.Content = null;
            skDefaultTooltip1.IsValid = false;
            skDefaultTooltip1.Opacity = 1F;
            padding2.Bottom = 0F;
            padding2.Left = 0F;
            padding2.Right = 0F;
            padding2.Top = 0F;
            skDefaultTooltip1.Padding = padding2;
            skDefaultTooltip1.RemoveOnCompleted = false;
            skDefaultTooltip1.RotateTransform = 0F;
            skDefaultTooltip1.Wedge = 10;
            skDefaultTooltip1.X = 0F;
            skDefaultTooltip1.Y = 0F;
            cartesianChart1.Tooltip = skDefaultTooltip1;
            cartesianChart1.TooltipFindingStrategy = LiveChartsCore.Measure.TooltipFindingStrategy.Automatic;
            cartesianChart1.UpdaterThrottler = TimeSpan.Parse("00:00:00.0500000");
            // 
            // btnAddh
            // 
            btnAddh.Font = new Font("Microsoft YaHei UI", 20F);
            btnAddh.Location = new Point(662, 498);
            btnAddh.Name = "btnAddh";
            btnAddh.Size = new Size(112, 60);
            btnAddh.TabIndex = 9;
            btnAddh.Text = "加湿";
            btnAddh.UseVisualStyleBackColor = true;
            btnAddh.Click += btnAddh_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(209, 581);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(112, 34);
            btnClear.TabIndex = 10;
            btnClear.Text = "清除历史";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(111, 367);
            label2.Name = "label2";
            label2.Size = new Size(152, 27);
            label2.TabIndex = 11;
            label2.Text = "温湿度实时曲线";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(503, 367);
            label3.Name = "label3";
            label3.Size = new Size(152, 27);
            label3.TabIndex = 12;
            label3.Text = "历史记录查询表";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(786, 666);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnClear);
            Controls.Add(btnAddh);
            Controls.Add(cartesianChart1);
            Controls.Add(lblHumidity);
            Controls.Add(lblHumidityTitle);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(btnQuery);
            Controls.Add(btnAdd);
            Controls.Add(btnStart);
            Controls.Add(lblShow);
            Font = new Font("Microsoft YaHei UI", 10F);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblShow;
        private Button btnStart;
        private System.Windows.Forms.Timer timer1;
        private Button btnAdd;
        private Button btnQuery;
        private DataGridView dataGridView1;
        private Label label1;
        private Label lblHumidityTitle;
        private Label lblHumidity;
        private BindingSource bindingSource1;
        private LiveChartsCore.SkiaSharpView.WinForms.CartesianChart cartesianChart1;
        private Button btnAddh;
        private Button btnClear;
        private Label label2;
        private Label label3;
    }
}
