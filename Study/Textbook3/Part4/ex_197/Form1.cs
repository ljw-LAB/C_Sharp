﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Windows.Forms.DataVisualization.Charting;
using System.Data.SqlClient;

namespace ex_197
{
    public partial class Form1 : Form
    {
        SerialPort sPort;
        private double xCount = 200;
        List<SensorData> myData = new List<SensorData>();
        string connString = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\study\C#\Study\Textbook3\Part4\ex_197\SensorData.mdf;Integrated Security = True";

        public Form1()
        {
            InitializeComponent();

            foreach (var ports in SerialPort.GetPortNames())
            {
                comboBox1.Items.Add(ports);
            }
            comboBox1.Text = "Select Port";

            progressBar1.Minimum = 0;
            progressBar1.Maximum = 1023;

            ChartSetting();

            btnPortValue.BackColor = Color.Blue;
            btnPortValue.ForeColor = Color.White;
            btnPortValue.Text = "";
            btnPortValue.Font = new Font("맑은 고딕", 16, FontStyle.Bold);

            label1.Text = "Connection Time : ";
            textBox1.TextAlign = HorizontalAlignment.Center;
            btnConnect.Enabled = false;
            btnDisconnect.Enabled = false;
        }

        private void ChartSetting()
        {
            chart1.ChartAreas.Clear();
            chart1.ChartAreas.Add("draw");
            chart1.ChartAreas["draw"].AxisX.Minimum = 0;
            chart1.ChartAreas["draw"].AxisX.Maximum = xCount;
            chart1.ChartAreas["draw"].AxisX.Interval = xCount / 4;
            chart1.ChartAreas["draw"].AxisX.MajorGrid.LineColor = Color.White;
            chart1.ChartAreas["draw"].AxisX.MajorGrid.LineDashStyle = ChartDashStyle.Dash;

            chart1.ChartAreas["draw"].AxisY.Minimum = 0;
            chart1.ChartAreas["draw"].AxisY.Maximum = 1024;
            chart1.ChartAreas["draw"].AxisY.Interval = 200;
            chart1.ChartAreas["draw"].AxisY.MajorGrid.LineColor = Color.White;
            chart1.ChartAreas["draw"].AxisY.LineDashStyle = ChartDashStyle.Dash;

            chart1.ChartAreas["draw"].BackColor = Color.Blue;
            chart1.ChartAreas["draw"].CursorX.AutoScroll = true;
            chart1.ChartAreas["draw"].AxisX.ScaleView.Zoomable = true;
            chart1.ChartAreas["draw"].AxisX.ScrollBar.ButtonStyle = ScrollBarButtonStyles.SmallScroll;
            chart1.ChartAreas["draw"].AxisX.ScrollBar.ButtonColor = Color.LightSteelBlue;

            chart1.Series.Clear();
            chart1.Series.Add("PhotoCell");
            chart1.Series["PhotoCell"].ChartType = SeriesChartType.Line;
            chart1.Series["PhotoCell"].Color = Color.LightSeaGreen;
            chart1.Series["PhotoCell"].BorderWidth = 3;
            if (chart1.Legends.Count > 0)
                chart1.Legends.RemoveAt(0);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            sPort = new SerialPort(cb.SelectedItem.ToString());
            sPort.Open();
            sPort.DataReceived += SPort_DataReceived;

            label1.Text = "Connection Time : " + DateTime.Now.ToString();
            btnDisconnect.Enabled = true;

        }

        // 시리얼 포트의 Data_Received 이벤트
        private void SPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string s = sPort.ReadLine();
            this.BeginInvoke((new Action(delegate { ShowValue(s); })));
        }

        // 시리얼 포트로 받은 값을 보여주는 delegate 함수
        private void ShowValue(string s)
        {
            //int v = Int32.Parse(s);
            int v = 300;

            if (v < 0 || v > 1023)  // 처음 시작할 때 작은 값이나 큰 값이 들어오는 경우 배제
                return;

            SensorData data = new SensorData(
              DateTime.Now.ToShortDateString(),
              //DateTimeOffset.Now.ToString("HH:mm:ss.fff tt"), v);
              DateTime.Now.ToString("HH:mm:ss.ffff"), v);
            myData.Add(data);
            DBInsert(data);

            textBox1.Text = myData.Count.ToString();    // myData의 갯수를 표시
                                                        //progressBar1.Value = Int32.Parse(s);

            // ListBox에 시간과 값을 표시
            string item = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss.ffff") + "\t" + s;
            listBox1.Items.Add(item);
            listBox1.SelectedIndex = listBox1.Items.Count - 1;  // 계속 스크롤이 되도록 처리

            // Chart 표시
            chart1.Series["PhotoCell"].Points.Add(v);

            // zoom을 위해 200개까지는 기본, 데이터 갯수가 많아지면 200개만 보이지만, 스크롤 나타남
            chart1.ChartAreas["draw"].AxisX.Minimum = 0;
            chart1.ChartAreas["draw"].AxisX.Maximum = (myData.Count >= xCount) ? myData.Count : xCount;

            // change chart range : Zoom 사용  
            if (myData.Count > xCount)
            {
                chart1.ChartAreas["draw"].AxisX.ScaleView.Zoom(myData.Count - xCount, myData.Count);
            }
            else
            {
                chart1.ChartAreas["draw"].AxisX.ScaleView.Zoom(0, xCount);
            }

            // 숫자버튼 표시
            if (simulationFlag == false)
                btnPortValue.Text = sPort.PortName + "\n" + s;
            else
                btnPortValue.Text = s;
        }

        // SensorData를 DB에 저장
        private void DBInsert(SensorData data)
        {
            string sql = string.Format("Insert into SensorTable(Date, Time, Value) Values('{0}','{1}',{2})",
              data.Date, data.Time, data.Value);

            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                using (SqlCommand comm = new SqlCommand(sql, conn))
                {
                    conn.Open();
                    comm.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            sPort.Open();

            // Connect 버튼 비활성화, Disconnect 버튼 활성화
            btnConnect.Enabled = false;
            btnDisconnect.Enabled = true;
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            sPort.Close();
            btnConnect.Enabled = true;
            btnDisconnect.Enabled = false;
        }

        private void btnViewAll_Click(object sender, EventArgs e)
        {
            chart1.ChartAreas["draw"].AxisX.Minimum = 0;
            chart1.ChartAreas["draw"].AxisX.Maximum = myData.Count;

            chart1.ChartAreas["draw"].AxisX.ScaleView.Zoom(0, myData.Count);
            chart1.ChartAreas["draw"].AxisX.Interval = myData.Count / 4;
        }

        private void btnZoom_Click(object sender, EventArgs e)
        {
            chart1.ChartAreas["draw"].AxisX.Minimum = 0;
            chart1.ChartAreas["draw"].AxisX.Maximum = myData.Count;

            chart1.ChartAreas["draw"].AxisX.ScaleView.Zoom(myData.Count - xCount, myData.Count);
            chart1.ChartAreas["draw"].AxisX.Interval = xCount / 4;
        }
        Timer t = new Timer();
        Random r = new Random();
        private bool simulationFlag;

        private void 시작ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            simulationFlag = true;
            t.Interval = 1000;
            t.Tick += T_Tick;
            t.Start();
        }

        private void T_Tick(object sender, EventArgs e)
        {
            int value = r.Next(1024);
            ShowValue(value.ToString());
        }

        private void 끝ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            t.Stop();
            simulationFlag = false;
        }
    }
}
