using LiveChartsCore;
using LiveChartsCore.SkiaSharpView;
using System.Data;

namespace MyCounter111
{
    public partial class Form1 : Form
    {
        // 随机数生成器和当前温度变量（数据与界面分离）
        private Random _random = new Random();// 用来生成随机波动
        private double _currentTemp = 25.0;// 用一个变量专门存放温度数值
        private DatabaseHelper _db;// 新增这行
        private double _currentHumidity = 50.0;//新增湿度变量
        private System.Collections.ObjectModel.ObservableCollection<double> _tempValues = new System.Collections.ObjectModel.ObservableCollection<double>();
        private System.Collections.ObjectModel.ObservableCollection<double> _humValues = new System.Collections.ObjectModel.ObservableCollection<double>();
        private int _maxPoints = 100;

        public Form1()
        {
            InitializeComponent();
            _db = new DatabaseHelper();// 新增这行
        }

        // 双击“开始”按钮自动生成的事件
        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Start();           // 启动定时器
            btnStart.Enabled = false; // 防止重复点击
        }

        // 从变量 _currentTemp 读取当前温度（不碰界面文本）
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            // 1. 生成随机波动（-0.5 ~ +0.5）,读取当前温度
            double change = (_random.NextDouble() - 0.5) * 1.0;
            double humChange = (_random.NextDouble() - 0.5) * 4.0;
            _currentTemp += change;
            _currentHumidity += humChange;

            // 2. 缓慢上升，方便看报警效果
            _currentTemp += 0.2;
            if (_currentTemp > 35)
                _currentTemp = 20.0;// 超过35度重置回20度
            _currentHumidity += 0.5;
            if (_currentHumidity > 90)
                _currentHumidity = 40.0;//超过90%重置回40%

            // 3. 显示在标签上（只显示，不参与计算）
            lblShow.Text = _currentTemp.ToString("f1") + " ℃";
            lblHumidity.Text = _currentHumidity.ToString("F1") + " %RH";
            // 存入数据库
            // _db.InsertTemperature(_currentTemp);
            _db.InsertTemperatureAndHumidity(_currentTemp, _currentHumidity);

            // 4. 报警：超过30℃变红，否则黑色
            if (_currentTemp > 30)
                lblShow.ForeColor = Color.Red;
            else
                lblShow.ForeColor = Color.Black;
            if (_currentHumidity > 70)
                lblHumidity.ForeColor = Color.Red;
            else
                lblHumidity.ForeColor = Color.Black;

            // 把新数据加入集合
            _tempValues.Add(_currentTemp);
            _humValues.Add(_currentHumidity);

            // 超过最大点数，移除最旧的数据
            if (_tempValues.Count > _maxPoints) _tempValues.RemoveAt(0);
            if (_humValues.Count > _maxPoints) _humValues.RemoveAt(0);

            // 设置横轴（X轴）范围：10 到 100
            cartesianChart1.XAxes = new Axis[]
            {
    new Axis
    {
        MinLimit = 10,   // 起点
        MaxLimit = 100   // 终点
    }
            };

            // 设置纵轴（Y轴）范围：10 到 100
            cartesianChart1.YAxes = new Axis[]
            {
    new Axis
    {
        MinLimit = 10,
        MaxLimit = 100
    }
            };

            // 直接给 Series 属性赋一个新的数组，新版本不需要 Clear()
            cartesianChart1.Series = new ISeries[]
            {
                new LineSeries<double>
                {
                 Values = _tempValues,
                 Name = "温度 (℃)",
                 Stroke = null,    // 后续可设置颜色
                 GeometrySize = 0, // 不显示数据点
                 LineSmoothness = 0
                },
                new LineSeries<double>
                {
                 Values = _humValues,
                 Name = "湿度 (%RH)",
                 Stroke = null,
                 GeometrySize = 0,
                 LineSmoothness = 0
                }
            };
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            _currentTemp += 0.5;//模拟每次升温
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            //从数据库获取最近20条记录
            DataTable dt = _db.GetRecentRecords(20);
            //把数据绑定到表格控件上
            dataGridView1.DataSource = dt;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAddh_Click(object sender, EventArgs e)
        {
            _currentHumidity += 1;//模拟每次升温
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            _db.ClearAllRecords();
            dataGridView1.DataSource = null;
            MessageBox.Show("历史数据已清除");
        }
    }
}
