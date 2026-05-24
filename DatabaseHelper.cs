using System;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;// 新增，为了使用 Application.StartupPath

namespace MyCounter111
{
    internal class DatabaseHelper
    {
        private string _dbPath;
        private string _connectionString;

        public DatabaseHelper()
        {
            // 数据库文件放在程序运行目录下，名为 Data.db 
            _dbPath = Path.Combine(Application.StartupPath, "Data.db");
            _connectionString = $"Data Source={_dbPath};Version=3;";
            CreateTable();
        }
        // 创建数据表（只创建一次)
        private void CreateTable()
        {
            string sql = @"CREATE TABLE IF NOT EXISTS TempLog(
                           Id INTEGER PRIMARY KEY AUTOINCREMENT,
                           Temperature REAL NOT NULL,
                           Humidity REAL NOT NULL,
                           RecordTime DATETIME NOT NULL
                          );";
            using (var conn = new SQLiteConnection(_connectionString))
            {
                conn.Open();
                using (var cmd = new SQLiteCommand(sql, conn))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }
        // 插入一条温度记录
        public void InsertTemperatureAndHumidity(double temperature, double humidity)
        {
            string sql = "INSERT INTO TempLog (Temperature,Humidity,RecordTime) VALUES(@temp,@Hum,@time)";
            using (var conn = new SQLiteConnection(_connectionString)) // 新增这一行，创建连接
            {
                conn.Open();                                           // 新增这一行，打开连接
                using (var cmd = new SQLiteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@temp", temperature);
                    cmd.Parameters.AddWithValue("@Hum", humidity);
                    cmd.Parameters.AddWithValue("@time", DateTime.Now);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        // 查询最近 N 条记录（用于显示在表格里）
        public DataTable GetRecentRecords(int count = 20)
        {
            string sql = $"SELECT * FROM TempLog ORDER BY Id DESC LIMIT {count}";
            using (var conn = new SQLiteConnection(_connectionString))
            {
                conn.Open();
                using (var adapter = new SQLiteDataAdapter(sql, conn))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
            }
        }
        //清空历史所有数据
        public void ClearAllRecords()
        {
            using (var conn = new SQLiteConnection(_connectionString))
            {
                conn.Open();
                using (var cmd = new SQLiteCommand(conn))
                {
                    // 1. 直接删掉整张表
                    cmd.CommandText = "DROP TABLE IF EXISTS TempLog";
                    cmd.ExecuteNonQuery();

                    // 2. 重新创建一张全新的空表
                    cmd.CommandText = @"CREATE TABLE TempLog (
                                Id INTEGER PRIMARY KEY AUTOINCREMENT,
                                Temperature REAL NOT NULL,
                                Humidity REAL NOT NULL,
                                RecordTime DATETIME NOT NULL
                               )";
                    cmd.ExecuteNonQuery();
                }
            }
        }

    }
}
