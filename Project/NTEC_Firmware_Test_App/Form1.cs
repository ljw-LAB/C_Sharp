using System;
using System.IO.Ports;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text;
using System.Collections.Generic;
using System.Collections.Specialized;

namespace NTEC_Firmware_Test_App
{

    public partial class NTEC_Form : Form
    {
        Byte Stx_12_Byte = 0x02;
        Byte Etx_12_Byte = 0x03;

        int test_data = 0;
        static int Rx_Str_Cnt; // 수신데이트(문자열) 갯수 카운트 변수
        static int Tx_Str_Cnt; // 송신데이터(문자열 갯수 카운트 변수

        bool Multi_flag = false; // 연속 전송을 위한 플래그 변수

        byte NRG_Temp_NOR_1_8Ch_data = 0x00;  // NRG16 NOR1~8Ch 릴레이 채널 데이터
        byte NRG_Temp_NOR_9_16Ch_data = 0x00; // NRG16 NOR9~16Ch 릴레이 채널 데이터
        byte NRG_Temp_EMR_1_8Ch_data = 0x00;  // NRG16 EM1~8Ch 릴레이 채널 데이터
        byte NRG_Temp_EMR_9_16Ch_data = 0x00; // NRG16 EM9~16Ch 릴레이 채널 데이터

        byte NDT_Temp_NOR_1_8Ch_data = 0x00;  // NRT16 NOR1~8Ch 릴레이 채널 데이터
        byte NDT_Temp_NOR_9_16Ch_data = 0x00; // NRT16 NOR9~16Ch 릴레이 채널 데이터
        byte NDT_Temp_EMR_1_8Ch_data = 0x00;  // NRT16 EM1~8Ch 릴레이 채널 데이터
        byte NDT_Temp_EMR_9_16Ch_data = 0x00; // NRT16 EM9~16Ch 릴레이 채널 데이터

        byte NRT_Temp_NOR_1_8Ch_data = 0x00;   // NRT40 1~8Ch 릴레이 채널 데이터
        byte NRT_Temp_NOR_9_16Ch_data = 0x00;  // NRT40 9~16Ch 릴레이 채널 데이터
        byte NRT_Temp_NOR_17_24Ch_data = 0x00; // NRT40 17~24Ch 릴레이 채널 데이터
        byte NRT_Temp_NOR_25_32Ch_data = 0x00; // NRT40 25~32Ch 릴레이 채널 데이터
        byte NRT_Temp_NOR_33_40Ch_data = 0x00; // NRT40 33~40Ch 릴레이 채널 데이터

        byte NEI_Temp_data_1_7Ch_data = 0x00;
        byte NEI_Temp_data_8_14Ch_data = 0x00;
        byte NEI_Temp_data_15_21Ch_data = 0x00;
        byte NEI_Temp_data_22_28Ch_data = 0x00;
        byte NEI_Temp_data_29_35Ch_data = 0x00;
        byte NEI_Temp_data_36_42Ch_data = 0x00;

        public NTEC_Form()
        {
            InitializeComponent();
           
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            NMC_Cmd_comboBox.Text = "INIT";
            NMC44_ID_10_comboBox.Text = "0";
            NMC44_ID_1_comboBox.Text = "1";

            NRG_Cmd_comboBox.Text = "NOR";
            NRG16_ID_10_comboBox.Text = "0";
            NRG16_ID_1_comboBox.Text = "1";

            NDT_Cmd_comboBox.Text = "NOR";
            NRT16_ID_10_comboBox.Text = "0";
            NRT16_ID_1_comboBox.Text = "1";

            NRT_Cmd_comboBox.Text = "NOR";
            NRT40_ID_10_comboBox.Text = "0";
            NRT40_ID_1_comboBox.Text = "1";

            comboBox_Port_Number.DataSource = SerialPort.GetPortNames(); //연결 가능한 시리얼포트 이름을 콤보박스에 가져오기 

            comboBox_Port_Number.TabIndex = comboBox_Port_Number.SelectedIndex = 0;
            comboBox_Port_BaudRate.TabIndex = comboBox_Port_BaudRate.SelectedIndex = 4;
            comboBox_Port_DataBits.Text = "8";
            comboBox_Port_Parity.Text = "None";
            comboBox_Port_StopBits.Text = "1";
            comboBox_Port_FlowControl.Text = "None";

            Auto_RadioButton.Checked = true;
            Fire12Byte_Select_RadioButton.Checked = true;

            Hex_con_Monitoring_listBox_checkBox2.Checked = true;
            //DomainUpDown.DomainUpDownItemCollection NRT40_domainUpDown_1_collection = this.NRT40_domainUpDown_1.Items;
            //DomainUpDown.DomainUpDownItemCollection NRT40_domainUpDown_10_collection = this.NRT40_domainUpDown_10.Items;
            //DomainUpDown.DomainUpDownItemCollection NRT16_domainUpDown_1_collection  =  this.NRT16_domainUpDown_1.Items;
            //DomainUpDown.DomainUpDownItemCollection NRT16_domainUpDown_10_collection =  this.NRT16_domainUpDown_10.Items;
            //DomainUpDown.DomainUpDownItemCollection NRG16_domainUpDown_1_collection = this.NRG16_domainUpDown_1.Items;
            //DomainUpDown.DomainUpDownItemCollection NRG16_domainUpDown_10_collection = this.NRG16_domainUpDown_10.Items;

            //NRT40_domainUpDown_1_collection.Add("0"); NRT40_domainUpDown_1_collection.Add("1"); NRT40_domainUpDown_1_collection.Add("2");
            //NRT40_domainUpDown_1_collection.Add("3"); NRT40_domainUpDown_1_collection.Add("4"); NRT40_domainUpDown_1_collection.Add("5");
            //NRT40_domainUpDown_1_collection.Add("6"); NRT40_domainUpDown_1_collection.Add("7"); NRT40_domainUpDown_1_collection.Add("8");
            //NRT40_domainUpDown_1_collection.Add("9"); NRT40_domainUpDown_1_collection.Add("A"); NRT40_domainUpDown_1_collection.Add("B");
            //NRT40_domainUpDown_1_collection.Add("C"); NRT40_domainUpDown_1_collection.Add("D"); NRT40_domainUpDown_1_collection.Add("E");
            //NRT40_domainUpDown_1_collection.Add("F");

            //NRT40_domainUpDown_10_collection.Add("0"); NRT40_domainUpDown_10_collection.Add("1"); NRT40_domainUpDown_10_collection.Add("2");
            //NRT40_domainUpDown_10_collection.Add("3"); NRT40_domainUpDown_10_collection.Add("4"); NRT40_domainUpDown_10_collection.Add("5");
            //NRT40_domainUpDown_10_collection.Add("6"); NRT40_domainUpDown_10_collection.Add("7"); NRT40_domainUpDown_10_collection.Add("8");
            //NRT40_domainUpDown_10_collection.Add("9"); NRT40_domainUpDown_10_collection.Add("A"); NRT40_domainUpDown_10_collection.Add("B");
            //NRT40_domainUpDown_10_collection.Add("C"); NRT40_domainUpDown_10_collection.Add("D"); NRT40_domainUpDown_10_collection.Add("E");
            //NRT40_domainUpDown_10_collection.Add("F");

            //NRT16_domainUpDown_1_collection.Add("0"); NRT16_domainUpDown_1_collection.Add("1"); NRT16_domainUpDown_1_collection.Add("2");
            //NRT16_domainUpDown_1_collection.Add("3"); NRT16_domainUpDown_1_collection.Add("4"); NRT16_domainUpDown_1_collection.Add("5");
            //NRT16_domainUpDown_1_collection.Add("6"); NRT16_domainUpDown_1_collection.Add("7"); NRT16_domainUpDown_1_collection.Add("8");
            //NRT16_domainUpDown_1_collection.Add("9"); NRT16_domainUpDown_1_collection.Add("A"); NRT16_domainUpDown_1_collection.Add("B");
            //NRT16_domainUpDown_1_collection.Add("C"); NRT16_domainUpDown_1_collection.Add("D"); NRT16_domainUpDown_1_collection.Add("E");
            //NRT16_domainUpDown_1_collection.Add("F");

            //NRT16_domainUpDown_10_collection.Add("0"); NRT16_domainUpDown_10_collection.Add("1"); NRT16_domainUpDown_10_collection.Add("2");
            //NRT16_domainUpDown_10_collection.Add("3"); NRT16_domainUpDown_10_collection.Add("4"); NRT16_domainUpDown_10_collection.Add("5");
            //NRT16_domainUpDown_10_collection.Add("6"); NRT16_domainUpDown_10_collection.Add("7"); NRT16_domainUpDown_10_collection.Add("8");
            //NRT16_domainUpDown_10_collection.Add("9"); NRT16_domainUpDown_10_collection.Add("A"); NRT16_domainUpDown_10_collection.Add("B");
            //NRT16_domainUpDown_10_collection.Add("C"); NRT16_domainUpDown_10_collection.Add("D"); NRT16_domainUpDown_10_collection.Add("E");
            //NRT16_domainUpDown_10_collection.Add("F");

            //NRG16_domainUpDown_1_collection.Add("0"); NRG16_domainUpDown_1_collection.Add("1"); NRG16_domainUpDown_1_collection.Add("2");
            //NRG16_domainUpDown_1_collection.Add("3"); NRG16_domainUpDown_1_collection.Add("4"); NRG16_domainUpDown_1_collection.Add("5");
            //NRG16_domainUpDown_1_collection.Add("6"); NRG16_domainUpDown_1_collection.Add("7"); NRG16_domainUpDown_1_collection.Add("8");
            //NRG16_domainUpDown_1_collection.Add("9"); NRG16_domainUpDown_1_collection.Add("A"); NRG16_domainUpDown_1_collection.Add("B");
            //NRG16_domainUpDown_1_collection.Add("C"); NRG16_domainUpDown_1_collection.Add("D"); NRG16_domainUpDown_1_collection.Add("E");
            //NRG16_domainUpDown_1_collection.Add("F");

            //NRG16_domainUpDown_10_collection.Add("0"); NRG16_domainUpDown_10_collection.Add("1"); NRG16_domainUpDown_10_collection.Add("2");
            //NRG16_domainUpDown_10_collection.Add("3"); NRG16_domainUpDown_10_collection.Add("4"); NRG16_domainUpDown_10_collection.Add("5");
            //NRG16_domainUpDown_10_collection.Add("6"); NRG16_domainUpDown_10_collection.Add("7"); NRG16_domainUpDown_10_collection.Add("8");
            //NRG16_domainUpDown_10_collection.Add("9"); NRG16_domainUpDown_10_collection.Add("A"); NRG16_domainUpDown_10_collection.Add("B");
            //NRG16_domainUpDown_10_collection.Add("C"); NRG16_domainUpDown_10_collection.Add("D"); NRG16_domainUpDown_10_collection.Add("E");
            //NRG16_domainUpDown_10_collection.Add("F");

            //NRT40_domainUpDown_1.SelectedIndex = 0;
            //NRT40_domainUpDown_10.SelectedIndex = 0;
            //NRT16_domainUpDown_1.SelectedIndex = 0;
            //NRT16_domainUpDown_10.SelectedIndex = 0;
            //NRG16_domainUpDown_1.SelectedIndex = 0;
            //NRG16_domainUpDown_10.SelectedIndex = 0;

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void domainUpDown2_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void button_Connect_Click(object sender, EventArgs e)
        {
            try
            {
                if (!serialPort1.IsOpen) // 시리얼 포트 연결 확인(연결되지 않았을 때)
                {
                    serialPort1.PortName = Convert.ToString(comboBox_Port_Number.SelectedItem);                                             // PortName은 string이므로 형변환하여 할당
                    serialPort1.BaudRate = Convert.ToInt32(comboBox_Port_BaudRate.SelectedItem);                                            // BaudRate은 string이므로 형변환하여 할당
                    serialPort1.DataBits = Convert.ToInt32(comboBox_Port_DataBits.SelectedItem);                                            // DateBits은 string이므로 형변환하여 할당
                    serialPort1.Parity = (Parity)Enum.Parse(typeof(Parity), comboBox_Port_Parity.SelectedItem.ToString(), true);            // Parity은 Parity 형식의 Enum 이므로 형변환하여 할당
                    serialPort1.StopBits = (StopBits)Enum.Parse(typeof(StopBits), comboBox_Port_StopBits.SelectedItem.ToString(), true);     // StopBits은 Parity 형식의 Enum이므로 형변환하여 할당
                    serialPort1.Handshake = (Handshake)Enum.Parse(typeof(Handshake), comboBox_Port_FlowControl.SelectedItem.ToString(), true); // Handshake은 Parity 형식의 Enum이므로 형변환하여 할당

                    //serialPort1.ReadTimeout = 10;                                                                                             // 딜레이 문제 송신쪽으로 30ms간격밖에 전송하지 못함??.
                    //serialPort1.WriteTimeout = 50;

                    //textBox4.AppendText(serialPort1.PortName.ToString() + Environment.NewLine);    // 테스트용 Environment.NewLine -> "\r\n"으로 대체가능
                    //textBox4.AppendText(serialPort1.BaudRate.ToString() + Environment.NewLine);    // 테스트용 Environment.NewLine -> "\r\n"으로 대체가능 
                    //textBox4.AppendText(serialPort1.DataBits.ToString() + Environment.NewLine);    // 테스트용 Environment.NewLine -> "\r\n"으로 대체가능
                    //textBox4.AppendText(serialPort1.Parity.ToString() + Environment.NewLine);      // 테스트용 Environment.NewLine -> "\r\n"으로 대체가능
                    //textBox4.AppendText(serialPort1.StopBits.ToString() + Environment.NewLine);    // 테스트용 Environment.NewLine -> "\r\n"으로 대체가능
                    //textBox4.AppendText(serialPort1.Handshake.ToString() + Environment.NewLine);   // 테스트용 Environment.NewLine -> "\r\n"으로 대체가능

                    serialPort1.Open();                                                            // 시리얼포트 연결
                    button_Connect.Text = "연결해제";                                              // 버튼 Text 변경
                    MessageBox.Show(this.serialPort1.PortName + "이 연결되었습니다");              // 메세지박스 출력
                    comboBox_Port_Number.Enabled = false;                                          // 콤보박스 비활성화 -> 연결이후, 조작하게되면 혼동 할 수 있으므로 연결성공시 비활성화 상태로 전환
                    comboBox_Port_BaudRate.Enabled = false;                                        // 콤보박스 비활성화 -> 연결이후, 조작하게되면 혼동 할 수 있으므로 연결성공시 비활성화 상태로 전환
                    comboBox_Port_DataBits.Enabled = false;                                        // 콤보박스 비활성화 -> 연결이후, 조작하게되면 혼동 할 수 있으므로 연결성공시 비활성화 상태로 전환
                    comboBox_Port_Parity.Enabled = false;                                          // 콤보박스 비활성화 -> 연결이후, 조작하게되면 혼동 할 수 있으므로 연결성공시 비활성화 상태로 전환
                    comboBox_Port_StopBits.Enabled = false;                                        // 콤보박스 비활성화 -> 연결이후, 조작하게되면 혼동 할 수 있으므로 연결성공시 비활성화 상태로 전환
                    comboBox_Port_FlowControl.Enabled = false;                                     // 콤보박스 비활성화 -> 연결이후, 조작하게되면 혼동 할 수 있으므로 연결성공시 비활성화 상태로 전환
                }
                else                                                                               // 시리얼 포트 연결 확인(연결되었을 때)
                {
                    serialPort1.Close();                                                           // 시리얼포트 해제
                    button_Connect.Text = "연결하기";                                              // 버튼 Text 변경
                    MessageBox.Show(this.serialPort1.PortName + "이 연결 해제되었습니다");         // 메세지박스 출력
                    comboBox_Port_Number.Enabled = true;                                           // 콤보박스 활성화 -> 연결해제 상태시, 조작가능 상태로 전환
                    comboBox_Port_BaudRate.Enabled = true;                                         // 콤보박스 활성화 -> 연결해제 상태시, 조작가능 상태로 전환
                    comboBox_Port_DataBits.Enabled = true;                                         // 콤보박스 활성화 -> 연결해제 상태시, 조작가능 상태로 전환
                    comboBox_Port_Parity.Enabled = true;                                           // 콤보박스 활성화 -> 연결해제 상태시, 조작가능 상태로 전환
                    comboBox_Port_StopBits.Enabled = true;                                         // 콤보박스 활성화 -> 연결해제 상태시, 조작가능 상태로 전환
                    comboBox_Port_FlowControl.Enabled = true;                                      // 콤보박스 활성화 -> 연결해제 상태시, 조작가능 상태로 전환
                }
            }
            catch(System.UnauthorizedAccessException)
            {
                MessageBox.Show(this.serialPort1.PortName + "포트에 대한 액세스가 거부되었습니다.\n" + "                     (포트 사용중)");
            }

        }

        private void button_Reset_Click(object sender, EventArgs e)
        {
            
            //textBox4.AppendText(Parity.None.ToString() + Environment.NewLine);             // 테스트용 Environment.NewLine -> "\r\n"으로 대체가능, Parity열거형 출력 확인
            //textBox4.AppendText(Parity.Odd.ToString() + Environment.NewLine);              // 테스트용 Environment.NewLine -> "\r\n"으로 대체가능
            //textBox4.AppendText(Parity.Even.ToString() + Environment.NewLine);             // 테스트용 Environment.NewLine -> "\r\n"으로 대체가능
            //textBox4.AppendText(Parity.Mark.ToString() + Environment.NewLine);             // 테스트용 Environment.NewLine -> "\r\n"으로 대체가능

            //textBox4.AppendText(Handshake.None.ToString() + Environment.NewLine);          // 테스트용 Environment.NewLine -> "\r\n"으로 대체가능
            //textBox4.AppendText(Handshake.XOnXOff.ToString() + Environment.NewLine);       // 테스트용 Environment.NewLine -> "\r\n"으로 대체가능
            //textBox4.AppendText(Handshake.RequestToSend.ToString() + Environment.NewLine); // 테스트용 Environment.NewLine -> "\r\n"으로 대체가능

            //textBox4.AppendText(StopBits.One.ToString() + Environment.NewLine);            // 테스트용 Environment.NewLine -> "\r\n"으로 대체가능

            //시리얼포트 연결시 초기화 진행 할 수 없음)
            if (comboBox_Port_Number.Enabled == true && comboBox_Port_BaudRate.Enabled == true && comboBox_Port_DataBits.Enabled == true && comboBox_Port_Parity.Enabled == true && comboBox_Port_StopBits.Enabled == true && comboBox_Port_FlowControl.Enabled == true)
            {
                comboBox_Port_Number.TabIndex = comboBox_Port_Number.SelectedIndex = 0;
                comboBox_Port_BaudRate.TabIndex = comboBox_Port_BaudRate.SelectedIndex = 4;
                comboBox_Port_DataBits.Text = "8";
                comboBox_Port_Parity.Text = "None";
                comboBox_Port_StopBits.Text = "1";
                comboBox_Port_FlowControl.Text = "None";
            }
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            //string str = "";
            //int readCnt = serialPort1.BytesToRead;
            //byte[] rebyte = new byte[12];

            ////StringBuilder myStringBuilder = new StringBuilder(str, 12);

            //if (Fire_Data_Received_checkBox.Checked == false)
            //{

            //    string s = serialPort1.ReadLine();
            //    this.BeginInvoke((new Action(delegate { ShowValue(s); })));

            //}
            //else
            //{
            //    if (readCnt > 11)
            //    {
            //        int temp = serialPort1.Read(rebyte, 0, rebyte.Length);
            //    }

            //    foreach (var b in rebyte)
            //    {
            //        if (b != 0x00 && b != 0x0a)
            //        {
            //            str += (b.ToString("X2")) + " ";

            //        }
            //        else
            //        {
            //            str += (b.ToString("X2"));
            //        }
            //    }
            //    if(!str.Contains("00"))
            //    {
            //        Monitoring_listBox.Items.Add(str);

            //    }
            //}

            string str = "";
            int readCnt = serialPort1.BytesToRead;
            byte[] rebyte = new byte[readCnt];

            //StringBuilder myStringBuilder = new StringBuilder(str, 12);

            if (Fire_Data_Received_checkBox.Checked == false)
            {
                string s = serialPort1.ReadLine();
                this.BeginInvoke((new Action(delegate { ShowValue(s); })));
            }
            else
            {
                if (readCnt > 11)
                {
                    int temp = serialPort1.Read(rebyte, 0, rebyte.Length);
                }

                foreach (var b in rebyte)
                {
                    str += (b.ToString("X2")) + " ";
                }


            }

            //if (!(str.Contains("00")) && str.Length == 36)
            if (!(str.Contains("00")) && str.Length == 36)
            {
                //Monitoring_listBox.Items.Remove(str);
                Monitoring_listBox.Items.Add(str + (Rx_Str_Cnt++).ToString());

            }
            //Monitoring_listBox.Items.Add(Rx_Str_Cnt++);
            //else
            //{
            //    Monitoring_listBox.Items.Add(str);
            //}
            //else if (str.EndsWith("03"))
            //{
            //    Monitoring_listBox.Items.Add(str + "\n");
            //}

            //Monitoring_listBox.Items.Add(str + Environment.NewLine);
            //textBox1.AppendText(str);
            //str_1 = textBox1.Text.ToString();
            //str.Replace("\n", "");
            //textBox1.Text += Environment.NewLine;
            //Monitoring_listBox.Items.Add(str);
            //textBox1.Clear();

            //textBox1.Clear();
            //Monitoring_listBox.Items.Add(textBox1.Text.ToString());
            //Monitoring_listBox.Items.Add(myStringBuilder);
        }

        private void ShowValue(string s)
        {
            string str = "";

            byte[] arr_byteStr = Encoding.Default.GetBytes(s);
            
            if (Hex_con_Monitoring_listBox_checkBox2.Checked == true)
            {
                int readCnt = s.Length;
                byte[] rebyte = new byte[readCnt - 1];

                foreach (var b in arr_byteStr)
                {
                    str += string.Format("{0:x2} ", b);
                }

                //string item = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss.ffff") + "    " + str  + "      " +(s.Count() + 1) + "      " + "R" + Rx_Str_Cnt++;
                string item = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss.ffff") + "    " + s + "      " + (s.Count() + 1) + "      " + "R" + Rx_Str_Cnt++;
                Monitoring_listBox.Items.Add(item);
                Monitoring_listBox.Items.Add(str);
                Monitoring_listBox.SelectedIndex = Monitoring_listBox.Items.Count - 1;  // 계속 스크롤이 되도록 처리
            }
            else
            {
                string item = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss.ffff") + "    " + s + "      " + (s.Count() + 1) + "      " + "R" + Rx_Str_Cnt++;
                Monitoring_listBox.Items.Add(item);
                Monitoring_listBox.SelectedIndex = Monitoring_listBox.Items.Count - 1;  // 계속 스크롤이 되도록 처리

            }

        }

        private void Tx_Single_Button_Click(object sender, EventArgs e)
        {
            //텍스트박스의 텍스트를 시리얼통신으로 송신
            //if (System.InvalidOperationException == true)
            //{

            //}
            try
            {
                if (Tx_Single_textBox.TextLength != 0)
                {
                    serialPort1.Write(Tx_Single_textBox.Text + "\r\n");
                    Monitoring_listBox.Items.Add(DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss.ffff") + "    " + Tx_Single_textBox.Text + "      " + (Tx_Single_textBox.Text.Count() + 2) + "      " + "T" + Tx_Str_Cnt++);
                    Monitoring_listBox.SelectedIndex = Monitoring_listBox.Items.Count - 1;  // 계속 스크롤이 되도록 처리
                }
                else
                {
                    MessageBox.Show("전송할 데이터가 없습니다.");
                }

            }
            catch(System.InvalidOperationException)
            {
                MessageBox.Show("포트가 열리지 않았습니다.!!!");
            }

        }

        private void listBox2_Clr_Button_Click(object sender, EventArgs e)
        {
            Monitoring_listBox.Items.Clear(); // 송, 수신 문자열 관련 리스트박스 화면 클리어(지우기)
            Rx_Str_Cnt = 0;
            Tx_Str_Cnt = 0;
        }

        private void Tx_Str_Insert_Button_Click(object sender, EventArgs e)
        {
            if (Tx_Single_textBox.TextLength != 0)
            {
                Tx_Str_listBox.Items.Add(Tx_Single_textBox.Text); //복수의 문자열 송신을 위한 리스트 박스에 아이템 추가
            }
            else
            {
                MessageBox.Show("텍스트박스에 데이터가 없습니다.");
            }
        }

        private void Tx_Str_Delete_Button_Click(object sender, EventArgs e)
        {
            /*문자열 없는데 불구하고 삭제되고 추가되는 버그 발견 추후 검토 할 것*/
            Tx_Single_textBox.Text = Tx_Str_listBox.Text;
            Tx_Str_listBox.Items.Remove(Tx_Str_listBox.Text); //복수의 문자열 송신을 위한 리스트 박스에 아이템 삭제
            Tx_Str_listBox.SelectedIndex = Tx_Str_listBox.Items.Count - 1;
        }

        async private void Tx_One_button_Click(object sender, EventArgs e)
        {
            int msc = Convert.ToInt32(Delay_textBox.Text);
            try
            {
                if (Tx_Str_listBox.Items.Count != 0)
                {
                    foreach (var item in Tx_Str_listBox.Items)
                    {
                        serialPort1.Write(item.ToString() + "\r\n");
                        Monitoring_listBox.Items.Add(DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss.ffff") + "    " + item.ToString() + "      " + (item.ToString().Count() + 2) + "      " + "T" + Tx_Str_Cnt++);
                        await Task.Delay(msc);

                    }
                }
                else
                {
                    MessageBox.Show("데이터가 없습니다!!!");
                }
            }
            catch (System.InvalidOperationException)
            {
                MessageBox.Show("포트가 열리지 않았습니다.!!!");
            }
        }

        async private void Tx_Multi_button_Click(object sender, EventArgs e)
        {
            int msc = Convert.ToInt32(Delay_textBox.Text);
            try
            {
                if (Tx_Str_listBox.Items.Count != 0)
                {
                    Multi_flag = true;
                    while (Multi_flag)
                    {
                        foreach (var item in Tx_Str_listBox.Items)
                        {
                            serialPort1.Write(item.ToString() + "\r\n");
                            Monitoring_listBox.Items.Add(DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss.ffff") + "    " + item.ToString() + "      " + (item.ToString().Count() + 2) + "      " + "T" + Tx_Str_Cnt++);
                            await Task.Delay(msc);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("데이터가 없습니다!!!");
                }
            }
            catch (System.InvalidOperationException)
            {
                MessageBox.Show("포트가 열리지 않았습니다.!!!");
            }

        }

        private void Multi_Stop_button_Click(object sender, EventArgs e)
        {
            Multi_flag = false;
        }

        private void NRG_Ch1_CheckBox_CheckedChanged(object sender, EventArgs e) //NRG16 NOR 1Ch 릴레이 채널 선택 체크박스
        {
            if (NRG_Ch1_CheckBox.Checked == true) // NRG16 NOR 1Ch 릴레이 채널 체크박스 체크유무 판별 
            {
                NRG_Temp_NOR_1_8Ch_data += 0x01;  // NRG16 NOR 1Ch 릴레이 채널 데이터 추가
            }
            else
            {
                NRG_Temp_NOR_1_8Ch_data -= 0x01;  // NRG16 NOR 1Ch 릴레이 채널 데이터 삭제
            }
        }

        private void NRG_Ch2_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (NRG_Ch2_CheckBox.Checked == true) // NRG16 NOR 2Ch 릴레이 채널 체크박스 체크유무 판별 
            {
                NRG_Temp_NOR_1_8Ch_data += 0x02;  // NRG16 NOR 2Ch 릴레이 채널 데이터 추가
            }
            else
            {
                NRG_Temp_NOR_1_8Ch_data -= 0x02;  // NRG16 NOR 2Ch 릴레이 채널 데이터 삭제
            }
        }

        private void NRG_Ch3_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (NRG_Ch3_CheckBox.Checked == true) // NRG16 NOR 3Ch 릴레이 채널 체크박스 체크유무 판별 
            {
                NRG_Temp_NOR_1_8Ch_data += 0x04;  // NRG16 NOR 3Ch 릴레이 채널 데이터 추가
            }
            else
            {
                NRG_Temp_NOR_1_8Ch_data -= 0x04;  // NRG16 NOR 3Ch 릴레이 채널 데이터 삭제
            }
        }

        private void NRG_Ch4_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (NRG_Ch4_CheckBox.Checked == true) // NRG16 NOR 4Ch 릴레이 채널 체크박스 체크유무 판별 
            {
                NRG_Temp_NOR_1_8Ch_data += 0x08;  // NRG16 NOR 4Ch 릴레이 채널 데이터 추가
            }
            else
            {
                NRG_Temp_NOR_1_8Ch_data -= 0x08;  // NRG16 NOR 4Ch 릴레이 채널 데이터 삭제
            }
        }

        private void NRG_Ch5_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (NRG_Ch5_CheckBox.Checked == true) // NRG16 NOR 5Ch 릴레이 채널 체크박스 체크유무 판별 
            {
                NRG_Temp_NOR_1_8Ch_data += 0x10;  // NRG16 NOR 5Ch 릴레이 채널 데이터 추가
            }
            else
            {
                NRG_Temp_NOR_1_8Ch_data -= 0x10;  // NRG16 NOR 5Ch 릴레이 채널 데이터 삭제
            }
        }

        private void NRG_Ch6_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (NRG_Ch6_CheckBox.Checked == true) // NRG16 NOR 6Ch 릴레이 채널 체크박스 체크유무 판별 
            {
                NRG_Temp_NOR_1_8Ch_data += 0x20;  // NRG16 NOR 6Ch 릴레이 채널 데이터 추가
            }
            else
            {
                NRG_Temp_NOR_1_8Ch_data -= 0x20;  // NRG16 NOR 6Ch 릴레이 채널 데이터 삭제
            }
        }

        private void NRG_Ch7_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (NRG_Ch7_CheckBox.Checked == true) // NRG16 NOR 7Ch 릴레이 채널 체크박스 체크유무 판별 
            {
                NRG_Temp_NOR_1_8Ch_data += 0x40;  // NRG16 NOR 7Ch 릴레이 채널 데이터 추가
            }
            else
            {
                NRG_Temp_NOR_1_8Ch_data -= 0x40;  // NRG16 NOR 7Ch 릴레이 채널 데이터 삭제
            }
        }

        private void NRG_Ch8_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (NRG_Ch8_CheckBox.Checked == true) // NRG16 NOR 8Ch 릴레이 채널 체크박스 체크유무 판별 
            {
                NRG_Temp_NOR_1_8Ch_data += 0x80;  // NRG16 NOR 8Ch 릴레이 채널 데이터 추가
            }
            else
            {
                NRG_Temp_NOR_1_8Ch_data -= 0x80;  // NRG16 NOR 8Ch 릴레이 채널 데이터 삭제
            }
        }

        private void NRG_Ch9_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (NRG_Ch9_CheckBox.Checked == true) // NRG16 NOR 9Ch 릴레이 채널 체크박스 체크유무 판별 
            {
                NRG_Temp_NOR_9_16Ch_data += 0x01; // NRG16 NOR 9Ch 릴레이 채널 데이터 추가
            }
            else
            {
                NRG_Temp_NOR_9_16Ch_data -= 0x01; // NRG16 NOR 9Ch 릴레이 채널 데이터 삭제
            }
        }

        private void NRG_Ch10_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (NRG_Ch10_CheckBox.Checked == true) // NRG16 NOR 10Ch 릴레이 채널 체크박스 체크유무 판별 
            {
                NRG_Temp_NOR_9_16Ch_data += 0x02;  // NRG16 NOR 10Ch 릴레이 채널 데이터 추가
            }
            else
            {
                NRG_Temp_NOR_9_16Ch_data -= 0x02;  // NRG16 NOR 10Ch 릴레이 채널 데이터 삭제
            }
        }

        private void NRG_Ch11_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (NRG_Ch11_CheckBox.Checked == true) // NRG16 NOR 11Ch 릴레이 채널 체크박스 체크유무 판별 
            {
                NRG_Temp_NOR_9_16Ch_data += 0x04;  // NRG16 NOR 11Ch 릴레이 채널 데이터 추가
            }
            else
            {
                NRG_Temp_NOR_9_16Ch_data -= 0x04;  // NRG16 NOR 11Ch 릴레이 채널 데이터 삭제
            }
        }

        private void NRG_Ch12_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (NRG_Ch12_CheckBox.Checked == true) // NRG16 NOR 12Ch 릴레이 채널 체크박스 체크유무 판별 
            {
                NRG_Temp_NOR_9_16Ch_data += 0x08;  // NRG16 NOR 12Ch 릴레이 채널 데이터 추가
            }
            else
            {
                NRG_Temp_NOR_9_16Ch_data -= 0x08;  // NRG16 NOR 12Ch 릴레이 채널 데이터 삭제
            }
        }

        private void NRG_Ch13_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (NRG_Ch13_CheckBox.Checked == true) // NRG16 NOR 13Ch 릴레이 채널 체크박스 체크유무 판별 
            {
                NRG_Temp_NOR_9_16Ch_data += 0x10;  // NRG16 NOR 13Ch 릴레이 채널 데이터 추가
            }
            else
            {
                NRG_Temp_NOR_9_16Ch_data -= 0x10;  // NRG16 NOR 13Ch 릴레이 채널 데이터 삭제
            }
        }

        private void NRG_Ch14_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (NRG_Ch14_CheckBox.Checked == true) // NRG16 NOR 14Ch 릴레이 채널 체크박스 체크유무 판별 
            {
                NRG_Temp_NOR_9_16Ch_data += 0x20;  // NRG16 NOR 14Ch 릴레이 채널 데이터 추가
            }
            else
            {
                NRG_Temp_NOR_9_16Ch_data -= 0x20;  // NRG16 NOR 14Ch 릴레이 채널 데이터 삭제
            }
        }

        private void NRG_Ch15_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (NRG_Ch15_CheckBox.Checked == true) // NRG16 NOR 15Ch 릴레이 채널 체크박스 체크유무 판별 
            {
                NRG_Temp_NOR_9_16Ch_data += 0x40;  // NRG16 NOR 15Ch 릴레이 채널 데이터 추가
            }
            else
            {
                NRG_Temp_NOR_9_16Ch_data -= 0x40;  // NRG16 NOR 15Ch 릴레이 채널 데이터 삭제
            }
        }

        private void NRG_Ch16_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (NRG_Ch16_CheckBox.Checked == true) // NRG16 NOR 16Ch 릴레이 채널 체크박스 체크유무 판별 
            {
                NRG_Temp_NOR_9_16Ch_data += 0x80;  // NRG16 NOR 16Ch 릴레이 채널 데이터 추가
            }
            else
            {
                NRG_Temp_NOR_9_16Ch_data -= 0x80;  // NRG16 NOR 16Ch 릴레이 채널 데이터 삭제
            }
        }

        private void NRG_Ch17_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (NRG_Ch17_CheckBox.Checked == true) // NRG16 EM 1Ch 릴레이 채널 체크박스 체크유무 판별 
            {
                NRG_Temp_EMR_1_8Ch_data += 0x01;   // NRG16 EM 1Ch 릴레이 채널 데이터 추가
            }
            else
            {
                NRG_Temp_EMR_1_8Ch_data -= 0x01;   // NRG16 EM 1Ch 릴레이 채널 데이터 삭제
            }
        }

        private void NRG_Ch18_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (NRG_Ch18_CheckBox.Checked == true) // NRG16 EM 2Ch 릴레이 채널 체크박스 체크유무 판별 
            {
                NRG_Temp_EMR_1_8Ch_data += 0x02;   // NRG16 EM 2Ch 릴레이 채널 데이터 추가
            }
            else
            {
                NRG_Temp_EMR_1_8Ch_data -= 0x02;   // NRG16 EM 1Ch 릴레이 채널 데이터 삭제
            }
        }

        private void NRG_Ch19_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (NRG_Ch19_CheckBox.Checked == true) // NRG16 EM 3Ch 릴레이 채널 체크박스 체크유무 판별 
            {
                NRG_Temp_EMR_1_8Ch_data += 0x04;   // NRG16 EM 3Ch 릴레이 채널 데이터 추가
            }
            else
            {
                NRG_Temp_EMR_1_8Ch_data -= 0x04;   // NRG16 EM 3Ch 릴레이 채널 데이터 삭제
            }
        }

        private void NRG_Ch20_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (NRG_Ch20_CheckBox.Checked == true) // NRG16 EM 4Ch 릴레이 채널 체크박스 체크유무 판별 
            {
                NRG_Temp_EMR_1_8Ch_data += 0x08;   // NRG16 EM 4Ch 릴레이 채널 데이터 추가
            }
            else
            {
                NRG_Temp_EMR_1_8Ch_data -= 0x08;   // NRG16 EM 4Ch 릴레이 채널 데이터 삭제
            }
        }

        private void NRG_Ch21_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (NRG_Ch21_CheckBox.Checked == true) // NRG16 EM 5Ch 릴레이 채널 체크박스 체크유무 판별 
            {
                NRG_Temp_EMR_1_8Ch_data += 0x10;   // NRG16 EM 5Ch 릴레이 채널 데이터 추가
            }
            else
            {
                NRG_Temp_EMR_1_8Ch_data -= 0x10;   // NRG16 EM 5Ch 릴레이 채널 데이터 삭제
            }
        }

        private void NRG_Ch22_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (NRG_Ch22_CheckBox.Checked == true) // NRG16 EM 6Ch 릴레이 채널 체크박스 체크유무 판별 
            {
                NRG_Temp_EMR_1_8Ch_data += 0x20;   // NRG16 EM 6Ch 릴레이 채널 데이터 추가
            }
            else
            {
                NRG_Temp_EMR_1_8Ch_data -= 0x20;  // NRG16 EM 6Ch 릴레이 채널 데이터 삭제
            }
        }

        private void NRG_Ch23_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (NRG_Ch23_CheckBox.Checked == true) // NRG16 EM 7Ch 릴레이 채널 체크박스 체크유무 판별 
            {
                NRG_Temp_EMR_1_8Ch_data += 0x40;   // NRG16 EM 7Ch 릴레이 채널 데이터 추가
            }
            else
            {
                NRG_Temp_EMR_1_8Ch_data -= 0x40;   // NRG16 EM 7Ch 릴레이 채널 데이터 삭제
            }
        }

        private void NRG_Ch24_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (NRG_Ch22_CheckBox.Checked == true) // NRG16 EM 8Ch 릴레이 채널 체크박스 체크유무 판별 
            {
                NRG_Temp_EMR_1_8Ch_data += 0x80;   // NRG16 EM 8h 릴레이 채널 데이터 추가
            }
            else
            {
                NRG_Temp_EMR_1_8Ch_data -= 0x80;   // NRG16 EM 8Ch 릴레이 채널 데이터 삭제
            }
        }

        private void NRG_Ch25_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (NRG_Ch25_CheckBox.Checked == true) // NRG16 EM 9Ch 릴레이 채널 체크박스 체크유무 판별 
            {
                NRG_Temp_EMR_9_16Ch_data += 0x01;  // NRG16 EM 9Ch 릴레이 채널 데이터 추가
            }
            else
            {
                NRG_Temp_EMR_9_16Ch_data -= 0x01;  // NRG16 EM 9Ch 릴레이 채널 데이터 삭제
            }
        }

        private void NRG_Ch26_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (NRG_Ch26_CheckBox.Checked == true) // NRG16 EM 10Ch 릴레이 채널 체크박스 체크유무 판별 
            {
                NRG_Temp_EMR_9_16Ch_data += 0x02;  // NRG16 EM 10Ch 릴레이 채널 데이터 추가
            }
            else
            {
                NRG_Temp_EMR_9_16Ch_data -= 0x02;  // NRG16 EM 10Ch 릴레이 채널 데이터 삭제
            }
        }

        private void NRG_Ch27_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (NRG_Ch27_CheckBox.Checked == true) // NRG16 EM 11Ch 릴레이 채널 체크박스 체크유무 판별 
            {
                NRG_Temp_EMR_9_16Ch_data += 0x04;  // NRG16 EM 11Ch 릴레이 채널 데이터 추가
            }
            else
            {
                NRG_Temp_EMR_9_16Ch_data -= 0x04;  // NRG16 EM 11Ch 릴레이 채널 데이터 삭제
            }
        }

        private void NRG_Ch28_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (NRG_Ch28_CheckBox.Checked == true) // NRG16 EM 12Ch 릴레이 채널 체크박스 체크유무 판별 
            {
                NRG_Temp_EMR_9_16Ch_data += 0x08;  // NRG16 EM 12Ch 릴레이 채널 데이터 추가
            }
            else
            {
                NRG_Temp_EMR_9_16Ch_data -= 0x08;  // NRG16 EM 12Ch 릴레이 채널 데이터 삭제
            }
        }

        private void NRG_Ch29_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (NRG_Ch29_CheckBox.Checked == true) // NRG16 EM 13Ch 릴레이 채널 체크박스 체크유무 판별 
            {
                NRG_Temp_EMR_9_16Ch_data += 0x10;  // NRG16 EM 13Ch 릴레이 채널 데이터 추가
            }
            else
            {
                NRG_Temp_EMR_9_16Ch_data -= 0x10;  // NRG16 EM 13Ch 릴레이 채널 데이터 삭제
            }
        }

        private void NRG_Ch30_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (NRG_Ch30_CheckBox.Checked == true) // NRG16 EM 14Ch 릴레이 채널 체크박스 체크유무 판별 
            {
                NRG_Temp_EMR_9_16Ch_data += 0x20;  // NRG16 EM 14Ch 릴레이 채널 데이터 추가
            }
            else
            {
                NRG_Temp_EMR_9_16Ch_data -= 0x20;  // NRG16 EM 14Ch 릴레이 채널 데이터 삭제
            }
        }

        private void NRG_Ch31_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (NRG_Ch31_CheckBox.Checked == true) // NRG16 EM 15Ch 릴레이 채널 체크박스 체크유무 판별 
            {
                NRG_Temp_EMR_9_16Ch_data += 0x40;  // NRG16 EM 15Ch 릴레이 채널 데이터 추가
            }
            else
            {
                NRG_Temp_EMR_9_16Ch_data -= 0x40;  // NRG16 EM 15Ch 릴레이 채널 데이터 삭제
            }
        }

        private void NRG_Ch32_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (NRG_Ch32_CheckBox.Checked == true) // NRG16 EM 16Ch 릴레이 채널 체크박스 체크유무 판별 
            {
                NRG_Temp_EMR_9_16Ch_data += 0x80;  // NRG16 EM 16Ch 릴레이 채널 데이터 추가
            }
            else
            {
                NRG_Temp_EMR_9_16Ch_data -= 0x80;  // NRG16 EM 16Ch 릴레이 채널 데이터 삭제
            }
        }

        private void NDT_Ch1_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (NDT_Ch1_CheckBox.Checked == true) // NRT16 NOR 1Ch 릴레이 채널 체크박스 체크유무 판별 
            {
                NDT_Temp_NOR_1_8Ch_data += 0x01;  // NRT16 NOR 1Ch 릴레이 채널 데이터 추가
            }
            else
            {
                NDT_Temp_NOR_1_8Ch_data -= 0x01;  // NRT16 NOR 1Ch 릴레이 채널 데이터 삭제
            }
        }

        private void NDT_Ch2_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (NDT_Ch2_CheckBox.Checked == true) // NRT16 NOR 2Ch 릴레이 채널 체크박스 체크유무 판별
            {
                NDT_Temp_NOR_1_8Ch_data += 0x02;  // NRT16 NOR 2Ch 릴레이 채널 데이터 추가
            }
            else
            {
                NDT_Temp_NOR_1_8Ch_data -= 0x02;  // NRT16 NOR 2Ch 릴레이 채널 데이터 삭제
            }
        }

        private void NDT_Ch3_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (NDT_Ch3_CheckBox.Checked == true) // NRT16 NOR 3Ch 릴레이 채널 체크박스 체크유무 판별
            {
                NDT_Temp_NOR_1_8Ch_data += 0x04;  // NRT16 NOR 3Ch 릴레이 채널 데이터 추가
            }
            else
            {
                NDT_Temp_NOR_1_8Ch_data -= 0x04;  // NRT16 NOR 3Ch 릴레이 채널 데이터 삭제
            }
        }

        private void NDT_Ch4_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (NDT_Ch4_CheckBox.Checked == true) // NRT16 NOR 4Ch 릴레이 채널 체크박스 체크유무 판별
            {
                NDT_Temp_NOR_1_8Ch_data += 0x08;  // NRT16 NOR 4Ch 릴레이 채널 데이터 추가
            }
            else
            {
                NDT_Temp_NOR_1_8Ch_data -= 0x08;  // NRT16 NOR 4Ch 릴레이 채널 데이터 삭제
            }
        }

        private void NDT_Ch5_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (NDT_Ch5_CheckBox.Checked == true) // NRT16 NOR 5Ch 릴레이 채널 체크박스 체크유무 판별
            {
                NDT_Temp_NOR_1_8Ch_data += 0x10;  // NRT16 NOR 5Ch 릴레이 채널 데이터 추가
            }
            else
            {
                NDT_Temp_NOR_1_8Ch_data -= 0x10;  // NRT16 NOR 5Ch 릴레이 채널 데이터 삭제
            }
        }

        private void NDT_Ch6_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (NDT_Ch6_CheckBox.Checked == true) // NRT16 NOR 6Ch 릴레이 채널 체크박스 체크유무 판별
            {
                NDT_Temp_NOR_1_8Ch_data += 0x20;  // NRT16 NOR 6Ch 릴레이 채널 데이터 추가
            }
            else
            {
                NDT_Temp_NOR_1_8Ch_data -= 0x20;  // NRT16 NOR 6Ch 릴레이 채널 데이터 삭제
            }
        }

        private void NDT_Ch7_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (NDT_Ch7_CheckBox.Checked == true) // NRT16 NOR 7Ch 릴레이 채널 체크박스 체크유무 판별
            {
                NDT_Temp_NOR_1_8Ch_data += 0x40;  // NRT16 NOR 7Ch 릴레이 채널 데이터 추가
            }
            else
            {
                NDT_Temp_NOR_1_8Ch_data -= 0x40;  // NRT16 NOR 7Ch 릴레이 채널 데이터 삭제
            }
        }

        private void NDT_Ch8_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (NDT_Ch8_CheckBox.Checked == true) // NRT16 NOR 8Ch 릴레이 채널 체크박스 체크유무 판별
            {
                NDT_Temp_NOR_1_8Ch_data += 0x80;  // NRT16 NOR 8Ch 릴레이 채널 데이터 추가
            }
            else
            {
                NDT_Temp_NOR_1_8Ch_data -= 0x80;  // NRT16 NOR 8Ch 릴레이 채널 데이터 삭제
            }
        }

        private void NDT_Ch9_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (NDT_Ch9_CheckBox.Checked == true) // NRT16 NOR 9Ch 릴레이 채널 체크박스 체크유무 판별
            {
                NDT_Temp_NOR_9_16Ch_data += 0x01;  // NRT16 NOR 9Ch 릴레이 채널 데이터 추가
            }
            else
            {
                NDT_Temp_NOR_9_16Ch_data -= 0x01;  // NRT16 NOR 9Ch 릴레이 채널 데이터 삭제
            }
        }

        private void NDT_Ch10_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (NDT_Ch10_CheckBox.Checked == true) // NRT16 NOR 10Ch 릴레이 채널 체크박스 체크유무 판별
            {
                NDT_Temp_NOR_9_16Ch_data += 0x02;  // NRT16 NOR 10Ch 릴레이 채널 데이터 추가
            }
            else
            {
                NDT_Temp_NOR_9_16Ch_data -= 0x02;  // NRT16 NOR 10Ch 릴레이 채널 데이터 삭제
            }
        }

        private void NDT_Ch11_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (NDT_Ch11_CheckBox.Checked == true) // NRT16 NOR 11Ch 릴레이 채널 체크박스 체크유무 판별
            {
                NDT_Temp_NOR_9_16Ch_data += 0x04;  // NRT16 NOR 11Ch 릴레이 채널 데이터 추가
            }
            else
            {
                NDT_Temp_NOR_9_16Ch_data -= 0x04;  // NRT16 NOR 11Ch 릴레이 채널 데이터 삭제
            }
        }

        private void NDT_Ch12_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (NDT_Ch12_CheckBox.Checked == true) // NRT16 NOR 12Ch 릴레이 채널 체크박스 체크유무 판별
            {
                NDT_Temp_NOR_9_16Ch_data += 0x08;  // NRT16 NOR 12Ch 릴레이 채널 데이터 추가
            }
            else
            {
                NDT_Temp_NOR_9_16Ch_data -= 0x08;  // NRT16 NOR 12Ch 릴레이 채널 데이터 삭제
            }
        }

        private void NDT_Ch13_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (NDT_Ch13_CheckBox.Checked == true) // NRT16 NOR 13Ch 릴레이 채널 체크박스 체크유무 판별
            {
                NDT_Temp_NOR_9_16Ch_data += 0x10;  // NRT16 NOR 13Ch 릴레이 채널 데이터 추가
            }
            else
            {
                NDT_Temp_NOR_9_16Ch_data -= 0x10;  // NRT16 NOR 13Ch 릴레이 채널 데이터 삭제
            }
        }

        private void NDT_Ch14_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (NDT_Ch14_CheckBox.Checked == true) // NRT16 NOR 14Ch 릴레이 채널 체크박스 체크유무 판별
            {
                NDT_Temp_NOR_9_16Ch_data += 0x20;  // NRT16 NOR 14Ch 릴레이 채널 데이터 추가
            }
            else
            {
                NDT_Temp_NOR_9_16Ch_data -= 0x20;  // NRT16 NOR 14Ch 릴레이 채널 데이터 삭제
            }
        }

        private void NDT_Ch15_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (NDT_Ch15_CheckBox.Checked == true) // NRT16 NOR 15Ch 릴레이 채널 체크박스 체크유무 판별
            {
                NDT_Temp_NOR_9_16Ch_data += 0x40;  // NRT16 NOR 15Ch 릴레이 채널 데이터 추가
            }
            else
            {
                NDT_Temp_NOR_9_16Ch_data -= 0x40;  // NRT16 NOR 15Ch 릴레이 채널 데이터 삭제
            }
        }

        private void NDT_Ch16_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (NDT_Ch16_CheckBox.Checked == true) // NRT16 NOR 16Ch 릴레이 채널 체크박스 체크유무 판별
            {
                NDT_Temp_NOR_9_16Ch_data += 0x80;  // NRT16 NOR 16Ch 릴레이 채널 데이터 추가
            }
            else
            {
                NDT_Temp_NOR_9_16Ch_data -= 0x80;  // NRT16 NOR 16Ch 릴레이 채널 데이터 삭제
            }
        }

        private void NDT_Ch17_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (NDT_Ch17_CheckBox.Checked == true) // NRT16 EM 1Ch 릴레이 채널 체크박스 체크유무 판별
            {
                NDT_Temp_EMR_1_8Ch_data += 0x01;   // NRT16 EM 1Ch 릴레이 채널 데이터 추가
            }
            else
            {
                NDT_Temp_EMR_1_8Ch_data -= 0x01;   // NRT16 EM 1Ch 릴레이 채널 데이터 삭제
            }
        }

        private void NDT_Ch18_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (NDT_Ch18_CheckBox.Checked == true) // NRT16 EM 2Ch 릴레이 채널 체크박스 체크유무 판별
            {
                NDT_Temp_EMR_1_8Ch_data += 0x02;   // NRT16 EM 2Ch 릴레이 채널 데이터 추가
            }
            else
            {
                NDT_Temp_EMR_1_8Ch_data -= 0x02;   // NRT16 EM 2Ch 릴레이 채널 데이터 삭제
            }
        }

        private void NDT_Ch19_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (NDT_Ch19_CheckBox.Checked == true) // NRT16 EM 3Ch 릴레이 채널 체크박스 체크유무 판별
            {
                NDT_Temp_EMR_1_8Ch_data += 0x04;   // NRT16 EM 3Ch 릴레이 채널 데이터 추가
            }
            else
            {
                NDT_Temp_EMR_1_8Ch_data -= 0x04;   // NRT16 EM 3Ch 릴레이 채널 데이터 삭제
            }
        }

        private void NDT_Ch20_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (NDT_Ch20_CheckBox.Checked == true) // NRT16 EM 4Ch 릴레이 채널 체크박스 체크유무 판별
            {
                NDT_Temp_EMR_1_8Ch_data += 0x08;   // NRT16 EM 4Ch 릴레이 채널 데이터 추가
            }
            else
            {
                NDT_Temp_EMR_1_8Ch_data -= 0x08;   // NRT16 EM 4Ch 릴레이 채널 데이터 삭제
            }
        }

        private void NDT_Ch21_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (NDT_Ch21_CheckBox.Checked == true) // NRT16 EM 5Ch 릴레이 채널 체크박스 체크유무 판별
            {
                NDT_Temp_EMR_1_8Ch_data += 0x10;   // NRT16 EM 5Ch 릴레이 채널 데이터 추가
            }
            else
            {
                NDT_Temp_EMR_1_8Ch_data -= 0x10;   // NRT16 EM 5Ch 릴레이 채널 데이터 삭제
            }
        }

        private void NDT_Ch22_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (NDT_Ch22_CheckBox.Checked == true) // NRT16 EM 6Ch 릴레이 채널 체크박스 체크유무 판별
            {
                NDT_Temp_EMR_1_8Ch_data += 0x20;   // NRT16 EM 6Ch 릴레이 채널 데이터 추가
            }
            else
            {
                NDT_Temp_EMR_1_8Ch_data -= 0x20;   // NRT16 EM 6Ch 릴레이 채널 데이터 삭제
            }
        }

        private void NDT_Ch23_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (NDT_Ch23_CheckBox.Checked == true) // NRT16 EM 7Ch 릴레이 채널 체크박스 체크유무 판별
            {
                NDT_Temp_EMR_1_8Ch_data += 0x40;   // NRT16 EM 7Ch 릴레이 채널 데이터 추가
            }
            else
            {
                NDT_Temp_EMR_1_8Ch_data -= 0x40;   // NRT16 EM 7Ch 릴레이 채널 데이터 삭제
            }
        }

        private void NDT_Ch24_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (NDT_Ch24_CheckBox.Checked == true) // NRT16 EM 8Ch 릴레이 채널 체크박스 체크유무 판별
            {
                NDT_Temp_EMR_1_8Ch_data += 0x80;   // NRT16 EM 8Ch 릴레이 채널 데이터 추가
            }
            else
            {
                NDT_Temp_EMR_1_8Ch_data -= 0x80;   // NRT16 EM 8Ch 릴레이 채널 데이터 삭제
            }
        }

        private void NDT_Ch25_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (NDT_Ch25_CheckBox.Checked == true) // NRT16 EM 9Ch 릴레이 채널 체크박스 체크유무 판별
            {
                NDT_Temp_EMR_9_16Ch_data += 0x01;  // NRT16 EM 9Ch 릴레이 채널 데이터 추가
            }
            else
            {
                NDT_Temp_EMR_9_16Ch_data -= 0x01;  // NRT16 EM 9Ch 릴레이 채널 데이터 삭제
            }
        }

        private void NDT_Ch26_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (NDT_Ch26_CheckBox.Checked == true) // NRT16 EM 10Ch 릴레이 채널 체크박스 체크유무 판별
            {
                NDT_Temp_EMR_9_16Ch_data += 0x02;  // NRT16 EM 10Ch 릴레이 채널 데이터 추가
            }
            else
            {
                NDT_Temp_EMR_9_16Ch_data -= 0x02;  // NRT16 EM 10Ch 릴레이 채널 데이터 삭제
            }
        }

        private void NDT_Ch27_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (NDT_Ch27_CheckBox.Checked == true) // NRT16 EM 11Ch 릴레이 채널 체크박스 체크유무 판별
            {
                NDT_Temp_EMR_9_16Ch_data += 0x04;  // NRT16 EM 11Ch 릴레이 채널 데이터 추가
            }
            else
            {
                NDT_Temp_EMR_9_16Ch_data -= 0x04;  // NRT16 EM 11Ch 릴레이 채널 데이터 삭제
            }
        }

        private void NDT_Ch28_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (NDT_Ch28_CheckBox.Checked == true) // NRT16 EM 12Ch 릴레이 채널 체크박스 체크유무 판별
            {
                NDT_Temp_EMR_9_16Ch_data += 0x08;  // NRT16 EM 12Ch 릴레이 채널 데이터 추가
            }
            else
            {
                NDT_Temp_EMR_9_16Ch_data -= 0x08;  // NRT16 EM 12Ch 릴레이 채널 데이터 삭제
            }
        }

        private void NDT_Ch29_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (NDT_Ch29_CheckBox.Checked == true) // NRT16 EM 13Ch 릴레이 채널 체크박스 체크유무 판별
            {
                NDT_Temp_EMR_9_16Ch_data += 0x10;  // NRT16 EM 13Ch 릴레이 채널 데이터 추가
            }
            else
            {
                NDT_Temp_EMR_9_16Ch_data -= 0x10;  // NRT16 EM 13Ch 릴레이 채널 데이터 삭제
            }
        }

        private void NDT_Ch30_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (NDT_Ch30_CheckBox.Checked == true) // NRT16 EM 14Ch 릴레이 채널 체크박스 체크유무 판별
            {
                NDT_Temp_EMR_9_16Ch_data += 0x20;  // NRT16 EM 14Ch 릴레이 채널 데이터 추가
            }
            else
            {
                NDT_Temp_EMR_9_16Ch_data -= 0x20;  // NRT16 EM 14Ch 릴레이 채널 데이터 삭제
            }
        }

        private void NDT_Ch31_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (NDT_Ch31_CheckBox.Checked == true) // NRT16 EM 15Ch 릴레이 채널 체크박스 체크유무 판별
            {
                NDT_Temp_EMR_9_16Ch_data += 0x40;  // NRT16 EM 15Ch 릴레이 채널 데이터 추가
            }
            else
            {
                NDT_Temp_EMR_9_16Ch_data -= 0x40;  // NRT16 EM 15Ch 릴레이 채널 데이터 삭제
            }
        }

        private void NDT_Ch32_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (NDT_Ch32_CheckBox.Checked == true) // NRT16 EM 16Ch 릴레이 채널 체크박스 체크유무 판별
            {
                NDT_Temp_EMR_9_16Ch_data += 0x80;  // NRT16 EM 16Ch 릴레이 채널 데이터 추가
            }
            else
            {
                NDT_Temp_EMR_9_16Ch_data -= 0x80;  // NRT16 EM 16Ch 릴레이 채널 데이터 삭제
            }
        }

        private void NRT_Ch1_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (NRT_Ch1_CheckBox.Checked == true) // NRT40 1Ch 릴레이 채널 체크박스 체크유무 판별
            {
                NRT_Temp_NOR_1_8Ch_data += 0x01;  // NRT40 1Ch 릴레이 채널 데이터 추가
            }
            else
            {
                NRT_Temp_NOR_1_8Ch_data -= 0x01;  // NRT40 1Ch 릴레이 채널 데이터 삭제
            }
        }

        private void NRT_Ch2_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (NRT_Ch2_CheckBox.Checked == true) // NRT40 2Ch 릴레이 채널 체크박스 체크유무 판별
            {
                NRT_Temp_NOR_1_8Ch_data += 0x02;  // NRT40 2Ch 릴레이 채널 데이터 추가
            }
            else
            {
                NRT_Temp_NOR_1_8Ch_data -= 0x02;  // NRT40 2Ch 릴레이 채널 데이터 삭제
            }
        }

        private void NRT_Ch3_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (NRT_Ch3_CheckBox.Checked == true) // NRT40 3Ch 릴레이 채널 체크박스 체크유무 판별
            {
                NRT_Temp_NOR_1_8Ch_data += 0x04;  // NRT40 3Ch 릴레이 채널 데이터 추가
            }
            else
            {
                NRT_Temp_NOR_1_8Ch_data -= 0x04;  // NRT40 3Ch 릴레이 채널 데이터 삭제
            }
        }

        private void NRT_Ch4_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (NRT_Ch4_CheckBox.Checked == true) // NRT40 4Ch 릴레이 채널 체크박스 체크유무 판별
            {
                NRT_Temp_NOR_1_8Ch_data += 0x08;  // NRT40 4Ch 릴레이 채널 데이터 추가
            }
            else
            {
                NRT_Temp_NOR_1_8Ch_data -= 0x08;  // NRT40 4Ch 릴레이 채널 데이터 삭제
            }
        }

        private void NRT_Ch5_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (NRT_Ch5_CheckBox.Checked == true) // NRT40 5Ch 릴레이 채널 체크박스 체크유무 판별
            {
                NRT_Temp_NOR_1_8Ch_data += 0x10;  // NRT40 5Ch 릴레이 채널 데이터 추가
            }
            else
            {
                NRT_Temp_NOR_1_8Ch_data -= 0x10;  // NRT40 5Ch 릴레이 채널 데이터 삭제
            }
        }

        private void NRT_Ch6_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (NRT_Ch6_CheckBox.Checked == true) // NRT40 6Ch 릴레이 채널 체크박스 체크유무 판별
            {
                NRT_Temp_NOR_1_8Ch_data += 0x20;  // NRT40 6Ch 릴레이 채널 데이터 추가
            }
            else
            {
                NRT_Temp_NOR_1_8Ch_data -= 0x20;  // NRT40 6Ch 릴레이 채널 데이터 삭제
            }
        }

        private void NRT_Ch7_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (NRT_Ch7_CheckBox.Checked == true) // NRT40 7Ch 릴레이 채널 체크박스 체크유무 판별
            {
                NRT_Temp_NOR_1_8Ch_data += 0x40;  // NRT40 7Ch 릴레이 채널 데이터 추가
            }
            else
            {
                NRT_Temp_NOR_1_8Ch_data -= 0x40;  // NRT40 7Ch 릴레이 채널 데이터 삭제
            }
        }

        private void NRT_Ch8_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (NRT_Ch8_CheckBox.Checked == true) // NRT40 8Ch 릴레이 채널 체크박스 체크유무 판별
            {
                NRT_Temp_NOR_1_8Ch_data += 0x80;  // NRT40 8Ch 릴레이 채널 데이터 추가
            }
            else
            {
                NRT_Temp_NOR_1_8Ch_data -= 0x80;  // NRT40 8Ch 릴레이 채널 데이터 삭제
            }
        }

        private void NRT_Ch9_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (NRT_Ch9_CheckBox.Checked == true) // NRT40 9Ch 릴레이 채널 체크박스 체크유무 판별
            {
                NRT_Temp_NOR_9_16Ch_data += 0x01; // NRT40 9Ch 릴레이 채널 데이터 추가
            }
            else
            {
                NRT_Temp_NOR_9_16Ch_data -= 0x01;  // NRT40 9Ch 릴레이 채널 데이터 삭제
            }
        }

        private void NRT_Ch10_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (NRT_Ch10_CheckBox.Checked == true) // NRT40 10Ch 릴레이 채널 체크박스 체크유무 판별
            {
                NRT_Temp_NOR_9_16Ch_data += 0x02;  // NRT40 10Ch 릴레이 채널 데이터 추가
            }
            else
            {
                NRT_Temp_NOR_9_16Ch_data -= 0x02;  // NRT40 10Ch 릴레이 채널 데이터 삭제
            }
        }

        private void NRT_Ch11_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (NRT_Ch11_CheckBox.Checked == true) // NRT40 11Ch 릴레이 채널 체크박스 체크유무 판별
            {
                NRT_Temp_NOR_9_16Ch_data += 0x04;  // NRT40 11Ch 릴레이 채널 데이터 추가
            }
            else
            {
                NRT_Temp_NOR_9_16Ch_data -= 0x04;  // NRT40 11Ch 릴레이 채널 데이터 삭제
            }
        }

        private void NRT_Ch12_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (NRT_Ch12_CheckBox.Checked == true) // NRT40 12Ch 릴레이 채널 체크박스 체크유무 판별
            {
                NRT_Temp_NOR_9_16Ch_data += 0x08;  // NRT40 12Ch 릴레이 채널 데이터 추가
            }
            else
            {
                NRT_Temp_NOR_9_16Ch_data -= 0x08;  // NRT40 12Ch 릴레이 채널 데이터 삭제
            }
        }

        private void NRT_Ch13_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (NRT_Ch13_CheckBox.Checked == true) // NRT40 13Ch 릴레이 채널 체크박스 체크유무 판별
            {
                NRT_Temp_NOR_9_16Ch_data += 0x10;  // NRT40 13Ch 릴레이 채널 데이터 추가
            }
            else
            {
                NRT_Temp_NOR_9_16Ch_data -= 0x10;  // NRT40 13Ch 릴레이 채널 데이터 삭제
            }
        }

        private void NRT_Ch14_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (NRT_Ch14_CheckBox.Checked == true) // NRT40 14Ch 릴레이 채널 체크박스 체크유무 판별
            {
                NRT_Temp_NOR_9_16Ch_data += 0x20;  // NRT40 14Ch 릴레이 채널 데이터 추가
            }
            else
            {
                NRT_Temp_NOR_9_16Ch_data -= 0x20;  // NRT40 14Ch 릴레이 채널 데이터 삭제
            }
        }

        private void NRT_Ch15_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (NRT_Ch15_CheckBox.Checked == true) // NRT40 15Ch 릴레이 채널 체크박스 체크유무 판별
            {
                NRT_Temp_NOR_9_16Ch_data += 0x40;  // NRT40 15Ch 릴레이 채널 데이터 추가
            }
            else
            {
                NRT_Temp_NOR_9_16Ch_data -= 0x40;  // NRT40 15Ch 릴레이 채널 데이터 삭제
            }
        }

        private void NRT_Ch16_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (NRT_Ch16_CheckBox.Checked == true) // NRT40 16Ch 릴레이 채널 체크박스 체크유무 판별
            {
                NRT_Temp_NOR_9_16Ch_data += 0x80;  // NRT40 16Ch 릴레이 채널 데이터 추가
            }
            else
            {
                NRT_Temp_NOR_9_16Ch_data -= 0x80;  // NRT40 16Ch 릴레이 채널 데이터 삭제
            }
        }

        private void NRT_Ch17_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (NRT_Ch17_CheckBox.Checked == true) // NRT40 17Ch 릴레이 채널 체크박스 체크유무 판별
            {
                NRT_Temp_NOR_17_24Ch_data += 0x01; // NRT40 17Ch 릴레이 채널 데이터 추가
            }
            else
            {
                NRT_Temp_NOR_17_24Ch_data -= 0x01; // NRT40 17Ch 릴레이 채널 데이터 삭제
            }
        }

        private void NRT_Ch18_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (NRT_Ch18_CheckBox.Checked == true) // NRT40 18Ch 릴레이 채널 체크박스 체크유무 판별
            {
                NRT_Temp_NOR_17_24Ch_data += 0x02; // NRT40 18Ch 릴레이 채널 데이터 추가
            }
            else
            {
                NRT_Temp_NOR_17_24Ch_data -= 0x02; // NRT40 18Ch 릴레이 채널 데이터 삭제
            }
        }

        private void NRT_Ch19_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (NRT_Ch19_CheckBox.Checked == true) // NRT40 19Ch 릴레이 채널 체크박스 체크유무 판별
            {
                NRT_Temp_NOR_17_24Ch_data += 0x04; // NRT40 19Ch 릴레이 채널 데이터 추가
            }
            else
            {
                NRT_Temp_NOR_17_24Ch_data -= 0x04; // NRT40 19Ch 릴레이 채널 데이터 삭제
            }
        }

        private void NRT_Ch20_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (NRT_Ch20_CheckBox.Checked == true) // NRT40 20Ch 릴레이 채널 체크박스 체크유무 판별
            {
                NRT_Temp_NOR_17_24Ch_data += 0x08; // NRT40 20Ch 릴레이 채널 데이터 추가
            }
            else
            {
                NRT_Temp_NOR_17_24Ch_data -= 0x08; // NRT40 20Ch 릴레이 채널 데이터 삭제
            }
        }

        private void NRT_Ch21_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (NRT_Ch21_CheckBox.Checked == true) // NRT40 21Ch 릴레이 채널 체크박스 체크유무 판별
            {
                NRT_Temp_NOR_17_24Ch_data += 0x10; // NRT40 21Ch 릴레이 채널 데이터 추가
            }
            else
            {
                NRT_Temp_NOR_17_24Ch_data -= 0x10; // NRT40 21Ch 릴레이 채널 데이터 삭제
            }
        }

        private void NRT_Ch22_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (NRT_Ch22_CheckBox.Checked == true) // NRT40 22Ch 릴레이 채널 체크박스 체크유무 판별
            {
                NRT_Temp_NOR_17_24Ch_data += 0x20; // NRT40 22Ch 릴레이 채널 데이터 추가
            }
            else
            {
                NRT_Temp_NOR_17_24Ch_data -= 0x20; // NRT40 22Ch 릴레이 채널 데이터 삭제
            }
        }

        private void NRT_Ch23_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (NRT_Ch23_CheckBox.Checked == true) // NRT40 23Ch 릴레이 채널 체크박스 체크유무 판별
            {
                NRT_Temp_NOR_17_24Ch_data += 0x40; // NRT40 23Ch 릴레이 채널 데이터 추가
            }
            else
            {
                NRT_Temp_NOR_17_24Ch_data -= 0x40; // NRT40 23Ch 릴레이 채널 데이터 삭제
            }
        }

        private void NRT_Ch24_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (NRT_Ch24_CheckBox.Checked == true) // NRT40 24Ch 릴레이 채널 체크박스 체크유무 판별
            {
                NRT_Temp_NOR_17_24Ch_data += 0x80; // NRT40 24Ch 릴레이 채널 데이터 추가
            }
            else
            {
                NRT_Temp_NOR_17_24Ch_data -= 0x80; // NRT40 24Ch 릴레이 채널 데이터 삭제
            }
        }

        private void NRT_Ch25_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (NRT_Ch25_CheckBox.Checked == true) // NRT40 25Ch 릴레이 채널 체크박스 체크유무 판별
            {
                NRT_Temp_NOR_25_32Ch_data += 0x01; // NRT40 25Ch 릴레이 채널 데이터 추가
            }
            else
            {
                NRT_Temp_NOR_25_32Ch_data -= 0x01; // NRT40 25Ch 릴레이 채널 데이터 삭제
            }
        }

        private void NRT_Ch26_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (NRT_Ch26_CheckBox.Checked == true) // NRT40 26Ch 릴레이 채널 체크박스 체크유무 판별
            {
                NRT_Temp_NOR_25_32Ch_data += 0x02; // NRT40 26Ch 릴레이 채널 데이터 추가
            }
            else
            {
                NRT_Temp_NOR_25_32Ch_data -= 0x02; // NRT40 26Ch 릴레이 채널 데이터 삭제
            }
        }

        private void NRT_Ch27_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (NRT_Ch27_CheckBox.Checked == true) // NRT40 27Ch 릴레이 채널 체크박스 체크유무 판별
            {
                NRT_Temp_NOR_25_32Ch_data += 0x04; // NRT40 27Ch 릴레이 채널 데이터 추가
            }
            else
            {
                NRT_Temp_NOR_25_32Ch_data -= 0x04; // NRT40 27Ch 릴레이 채널 데이터 삭제
            }
        }

        private void NRT_Ch28_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (NRT_Ch28_CheckBox.Checked == true) // NRT40 28Ch 릴레이 채널 체크박스 체크유무 판별
            {
                NRT_Temp_NOR_25_32Ch_data += 0x08; // NRT40 28Ch 릴레이 채널 데이터 추가
            }
            else
            {
                NRT_Temp_NOR_25_32Ch_data -= 0x08; // NRT40 28Ch 릴레이 채널 데이터 삭제
            }
        }

        private void NRT_Ch29_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (NRT_Ch29_CheckBox.Checked == true) // NRT40 29Ch 릴레이 채널 체크박스 체크유무 판별
            {
                NRT_Temp_NOR_25_32Ch_data += 0x10; // NRT40 29Ch 릴레이 채널 데이터 추가
            }
            else
            {
                NRT_Temp_NOR_25_32Ch_data -= 0x10; // NRT40 29Ch 릴레이 채널 데이터 삭제
            }
        }

        private void NRT_Ch30_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (NRT_Ch30_CheckBox.Checked == true) // NRT40 30Ch 릴레이 채널 체크박스 체크유무 판별
            {
                NRT_Temp_NOR_25_32Ch_data += 0x20; // NRT40 30Ch 릴레이 채널 데이터 추가
            }
            else
            {
                NRT_Temp_NOR_25_32Ch_data -= 0x20; // NRT40 30Ch 릴레이 채널 데이터 삭제
            }
        }

        private void NRT_Ch31_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (NRT_Ch31_CheckBox.Checked == true) // NRT40 31Ch 릴레이 채널 체크박스 체크유무 판별
            {
                NRT_Temp_NOR_25_32Ch_data += 0x40; // NRT40 31Ch 릴레이 채널 데이터 추가
            }
            else
            {
                NRT_Temp_NOR_25_32Ch_data -= 0x40; // NRT40 31Ch 릴레이 채널 데이터 삭제
            }
        }

        private void NRT_Ch32_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (NRT_Ch32_CheckBox.Checked == true) // NRT40 32Ch 릴레이 채널 체크박스 체크유무 판별
            {
                NRT_Temp_NOR_25_32Ch_data += 0x80; // NRT40 32Ch 릴레이 채널 데이터 추가
            }
            else
            {
                NRT_Temp_NOR_25_32Ch_data -= 0x80; // NRT40 32Ch 릴레이 채널 데이터 삭제
            }
        }

        private void NRT_Ch33_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (NRT_Ch33_CheckBox.Checked == true) // NRT40 33Ch 릴레이 채널 체크박스 체크유무 판별
            {
                NRT_Temp_NOR_33_40Ch_data += 0x01; // NRT40 33Ch 릴레이 채널 데이터 추가
            }
            else
            {
                NRT_Temp_NOR_33_40Ch_data -= 0x01; // NRT40 33Ch 릴레이 채널 데이터 삭제
            }
        }

        private void NRT_Ch34_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (NRT_Ch34_CheckBox.Checked == true) // NRT40 34Ch 릴레이 채널 체크박스 체크유무 판별
            {
                NRT_Temp_NOR_33_40Ch_data += 0x02; // NRT40 34Ch 릴레이 채널 데이터 추가
            }
            else
            {
                NRT_Temp_NOR_33_40Ch_data -= 0x02; // NRT40 34Ch 릴레이 채널 데이터 삭제
            }
        }

        private void NRT_Ch35_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (NRT_Ch35_CheckBox.Checked == true) // NRT40 35Ch 릴레이 채널 체크박스 체크유무 판별
            {
                NRT_Temp_NOR_33_40Ch_data += 0x04; // NRT40 35Ch 릴레이 채널 데이터 추가
            }
            else
            {
                NRT_Temp_NOR_33_40Ch_data -= 0x04; // NRT40 35Ch 릴레이 채널 데이터 삭제
            }
        }

        private void NRT_Ch36_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (NRT_Ch36_CheckBox.Checked == true) // NRT40 36Ch 릴레이 채널 체크박스 체크유무 판별
            {
                NRT_Temp_NOR_33_40Ch_data += 0x08; // NRT40 36Ch 릴레이 채널 데이터 추가
            }
            else
            {
                NRT_Temp_NOR_33_40Ch_data -= 0x08; // NRT40 36Ch 릴레이 채널 데이터 삭제
            }
        }

        private void NRT_Ch37_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (NRT_Ch37_CheckBox.Checked == true) // NRT40 37Ch 릴레이 채널 체크박스 체크유무 판별
            {
                NRT_Temp_NOR_33_40Ch_data += 0x10; // NRT40 37Ch 릴레이 채널 데이터 추가
            }
            else
            {
                NRT_Temp_NOR_33_40Ch_data -= 0x10; // NRT40 37Ch 릴레이 채널 데이터 삭제
            }
        }

        private void NRT_Ch38_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (NRT_Ch38_CheckBox.Checked == true) // NRT40 38Ch 릴레이 채널 체크박스 체크유무 판별
            {
                NRT_Temp_NOR_33_40Ch_data += 0x20; // NRT40 38Ch 릴레이 채널 데이터 추가
            }
            else
            {
                NRT_Temp_NOR_33_40Ch_data -= 0x20; // NRT40 38Ch 릴레이 채널 데이터 삭제
            }
        }

        private void NRT_Ch39_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (NRT_Ch39_CheckBox.Checked == true) // NRT40 39Ch 릴레이 채널 체크박스 체크유무 판별
            {
                NRT_Temp_NOR_33_40Ch_data += 0x40; // NRT40 39Ch 릴레이 채널 데이터 추가
            }
            else
            {
                NRT_Temp_NOR_33_40Ch_data -= 0x40; // NRT40 39Ch 릴레이 채널 데이터 삭제
            }
        }

        private void NRT_Ch40_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (NRT_Ch40_CheckBox.Checked == true) // NRT40 40Ch 릴레이 채널 체크박스 체크유무 판별
            {
                NRT_Temp_NOR_33_40Ch_data += 0x80; // NRT40 40Ch 릴레이 채널 데이터 추가
            }
            else
            {
                NRT_Temp_NOR_33_40Ch_data -= 0x80; // NRT40 40Ch 릴레이 채널 데이터 삭제
            }
        }

        private void NRG_Insert_Button_Click(object sender, EventArgs e)
        {
            //if (NRG_Cmd_comboBox.SelectedIndex >= 0)
            // 한 글자만 선택 또는 입력 받는 combobox 구현 시, 속성에서 ComboBox.AutoCompleteMode SuggestAppend 적용해야함. 한 글자 입력시, 문자열(\n, \r)로 키보드 입력 받기 때문에 제대로 입력을 판별하지 못하는 것으로 추정됨.
            // https://fishpoint.tistory.com/622 참조

            if (NRG_Cmd_comboBox.SelectedItem != null && (NRG16_ID_10_comboBox.SelectedItem != null && NRG16_ID_1_comboBox.SelectedItem != null))
            {
                Tx_Str_listBox.Items.Add("&NRG" + NRG16_ID_10_comboBox.SelectedItem.ToString() + NRG16_ID_1_comboBox.SelectedItem.ToString() + "," + NRG_Cmd_comboBox.SelectedItem + "," + NRG_Temp_NOR_1_8Ch_data.ToString("X2").ToLower() + "," + NRG_Temp_NOR_9_16Ch_data.ToString("X2").ToLower() + "," + NRG_Temp_EMR_1_8Ch_data.ToString("X2").ToLower() + "," + NRG_Temp_EMR_9_16Ch_data.ToString("X2").ToLower()); //복수의 문자열 송신을 위한 리스트 박스에 아이템 추가

            }
            else if (NRG_Cmd_comboBox.SelectedItem == null && (NRG16_ID_10_comboBox.SelectedItem != null && NRG16_ID_1_comboBox.SelectedItem != null))
            {
                MessageBox.Show("NRG16 명령어 선택 오류!!!!!", "NRG16 오류");
            }
            else if (NRG_Cmd_comboBox.SelectedItem != null && (NRG16_ID_10_comboBox.SelectedItem == null || NRG16_ID_1_comboBox.SelectedItem == null))
            {
                MessageBox.Show("NRG16 ID 선택 오류!!!!!", "NRG16 오류");
            }
            else if (NRG_Cmd_comboBox.SelectedItem == null && (NRG16_ID_10_comboBox.SelectedItem == null || NRG16_ID_1_comboBox.SelectedItem == null))
            {
                MessageBox.Show("NRG16 명령어, ID 선택 오류!!!!!", "NRG16 오류");
            }

        }

        private void NDT_Insert_Button_Click(object sender, EventArgs e)
        {
            // 한 글자만 선택 또는 입력 받는 combobox 구현 시, 속성에서 ComboBox.AutoCompleteMode SuggestAppend 적용해야함. 한 글자 입력시, 문자열(\n, \r)로 키보드 입력 받기 때문에 제대로 입력을 판별하지 못하는 것으로 추정됨.
            // https://fishpoint.tistory.com/622 참조

            if (NDT_Cmd_comboBox.SelectedItem != null && (NRT16_ID_10_comboBox.SelectedItem != null && NRT16_ID_1_comboBox.SelectedItem != null))
            {
                Tx_Str_listBox.Items.Add("&NDT" + NRT16_ID_10_comboBox.SelectedItem.ToString() + NRT16_ID_1_comboBox.SelectedItem.ToString() + "," + NDT_Cmd_comboBox.SelectedItem + "," + NDT_Temp_NOR_1_8Ch_data.ToString("X2").ToLower() + "," + NDT_Temp_NOR_9_16Ch_data.ToString("X2").ToLower() + "," + NDT_Temp_EMR_1_8Ch_data.ToString("X2").ToLower() + "," + NDT_Temp_EMR_9_16Ch_data.ToString("X2").ToLower()); //복수의 문자열 송신을 위한 리스트 박스에 아이템 추가
            }
            else if (NDT_Cmd_comboBox.SelectedItem == null && (NRT16_ID_10_comboBox.SelectedItem != null && NRT16_ID_1_comboBox.SelectedItem != null))
            {
                MessageBox.Show("NRT16 명령어 선택 오류!!!!!", "NRT16 오류");
            }
            else if (NDT_Cmd_comboBox.SelectedItem != null && (NRT16_ID_10_comboBox.SelectedItem == null || NRT16_ID_1_comboBox.SelectedItem == null))
            {
                MessageBox.Show("NRT16 ID 선택 오류!!!!!", "NRT16 오류");
            }
            else if (NDT_Cmd_comboBox.SelectedItem == null && (NRT16_ID_10_comboBox.SelectedItem == null || NRT16_ID_1_comboBox.SelectedItem == null))
            {
                MessageBox.Show("NRT16 명령어, ID 선택 오류!!!!!", "NRT16 오류");
            }
        }

        private void NRT_Insert_Button_Click(object sender, EventArgs e)
        {
            // 한 글자만 선택 또는 입력 받는 combobox 구현 시, 속성에서 ComboBox.AutoCompleteMode SuggestAppend 적용해야함. 한 글자 입력시, 문자열(\n, \r)로 키보드 입력 받기 때문에 제대로 입력을 판별하지 못하는 것으로 추정됨.
            // https://fishpoint.tistory.com/622 참조

            if (NRT_Cmd_comboBox.SelectedItem != null && (NRT40_ID_10_comboBox.SelectedItem != null && NRT40_ID_1_comboBox.SelectedItem != null))
            {
                Tx_Str_listBox.Items.Add("&NRT" + NRT40_ID_10_comboBox.SelectedItem.ToString() + NRT40_ID_1_comboBox.SelectedItem.ToString() + "," + NRT_Cmd_comboBox.SelectedItem + "," + NRT_Temp_NOR_1_8Ch_data.ToString("X2").ToLower() + "," + NRT_Temp_NOR_9_16Ch_data.ToString("X2").ToLower() + "," + NRT_Temp_NOR_17_24Ch_data.ToString("X2").ToLower() + "," + NRT_Temp_NOR_25_32Ch_data.ToString("X2").ToLower() + "," + NRT_Temp_NOR_33_40Ch_data.ToString("X2").ToLower()); //복수의 문자열 송신을 위한 리스트 박스에 아이템 추가
            }
            else if (NRT_Cmd_comboBox.SelectedItem == null && (NRT40_ID_10_comboBox.SelectedItem != null && NRT40_ID_1_comboBox.SelectedItem != null))
            {
                MessageBox.Show("NRT40 명령어 선택 오류!!!!!", "NRT40 오류");
            }
            else if (NRT_Cmd_comboBox.SelectedItem != null && (NRT40_ID_10_comboBox.SelectedItem == null || NRT40_ID_1_comboBox.SelectedItem == null))
            {
                MessageBox.Show("NRT40 ID 선택 오류!!!!!", "NRT40 오류");
            }
            else if (NRT_Cmd_comboBox.SelectedItem == null && (NRT40_ID_10_comboBox.SelectedItem == null || NRT40_ID_1_comboBox.SelectedItem == null))
            {
                MessageBox.Show("NRT40 명령어, ID 선택 오류!!!!!", "NRT40 오류");
            }
        }

        private void NEI_Insert_Button_Click(object sender, EventArgs e)
        {
            // 한 글자만 선택 또는 입력 받는 combobox 구현 시, 속성에서 ComboBox.AutoCompleteMode SuggestAppend 적용해야함. 한 글자 입력시, 문자열(\n, \r)로 키보드 입력 받기 때문에 제대로 입력을 판별하지 못하는 것으로 추정됨.
            // https://fishpoint.tistory.com/622 참조

            if (NEI42_Cmd_comboBox.SelectedItem != null && (NEI42_ID_10_comboBox.SelectedItem != null && NEI42_ID_1_comboBox.SelectedItem != null))
            {
                Tx_Str_listBox.Items.Add("&NEI" + NEI42_ID_10_comboBox.SelectedItem.ToString() + NEI42_ID_1_comboBox.SelectedItem.ToString() + "," + NEI42_Cmd_comboBox.SelectedItem + "," + NEI_Temp_data_1_7Ch_data.ToString("X2").ToLower() + "," + NEI_Temp_data_8_14Ch_data.ToString("X2").ToLower() + "," + NEI_Temp_data_15_21Ch_data.ToString("X2").ToLower() + "," + NEI_Temp_data_22_28Ch_data.ToString("X2").ToLower() + "," + NEI_Temp_data_29_35Ch_data.ToString("X2").ToLower() + "," + NEI_Temp_data_36_42Ch_data.ToString("X2").ToLower()); //복수의 문자열 송신을 위한 리스트 박스에 아이템 추가
            }
            else if (NEI42_Cmd_comboBox.SelectedItem == null && (NEI42_ID_10_comboBox.SelectedItem != null && NEI42_ID_1_comboBox.SelectedItem != null))
            {
                MessageBox.Show("NEI42 명령어 선택 오류!!!!!", "NEI42 오류");
            }
            else if (NEI42_Cmd_comboBox.SelectedItem != null && (NEI42_ID_10_comboBox.SelectedItem == null || NEI42_ID_1_comboBox.SelectedItem == null))
            {
                MessageBox.Show("NEI42 ID 선택 오류!!!!!", "NEI42 오류");
            }
            else if (NEI42_Cmd_comboBox.SelectedItem == null && (NEI42_ID_10_comboBox.SelectedItem == null || NEI42_ID_1_comboBox.SelectedItem == null))
            {
                MessageBox.Show("NEI42 명령어, ID 선택 오류!!!!!", "NEI42 오류");
            }
        }

        private void Fire10Byte_Select_RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if(Fire10Byte_Select_RadioButton.Checked == true)
            {
                Fire12Byte_Total_GroupBox.Enabled = false;
            }
            else
            {
                Fire12Byte_Total_GroupBox.Enabled = true;
            }
        }

        private void Fire12Byte_Select_RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (Fire12Byte_Select_RadioButton.Checked == true)
            {
                Fire10Byte_Total_GroupBox.Enabled = false;
            }
            else
            {
                Fire10Byte_Total_GroupBox.Enabled = true;
            }
        }

        private void NEI_Ch1_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(NEI_Ch1_CheckBox.Checked == true)
            {
                NEI_Temp_data_1_7Ch_data += 0x01;
            }
            else
            {
                NEI_Temp_data_1_7Ch_data -= 0x01;

            }
        }

        private void NEI_Ch2_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (NEI_Ch2_CheckBox.Checked == true)
            {
                NEI_Temp_data_1_7Ch_data += 0x02;
            }
            else
            {
                NEI_Temp_data_1_7Ch_data -= 0x02;

            }
        }

        private void NEI_Ch3_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (NEI_Ch3_CheckBox.Checked == true)
            {
                NEI_Temp_data_1_7Ch_data += 0x04;
            }
            else
            {
                NEI_Temp_data_1_7Ch_data -= 0x04;

            }
        }

        private void NEI_Ch4_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (NEI_Ch4_CheckBox.Checked == true)
            {
                NEI_Temp_data_1_7Ch_data += 0x08;
            }
            else
            {
                NEI_Temp_data_1_7Ch_data -= 0x08;

            }
        }

        private void NEI_Ch5_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (NEI_Ch5_CheckBox.Checked == true)
            {
                NEI_Temp_data_1_7Ch_data += 0x10;
            }
            else
            {
                NEI_Temp_data_1_7Ch_data -= 0x10;

            }
        }

        private void NEI_Ch6_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (NEI_Ch6_CheckBox.Checked == true)
            {
                NEI_Temp_data_1_7Ch_data += 0x20;
            }
            else
            {
                NEI_Temp_data_1_7Ch_data -= 0x20;

            }
        }

        private void NEI_Ch7_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (NEI_Ch7_CheckBox.Checked == true)
            {
                NEI_Temp_data_1_7Ch_data += 0x40;
            }
            else
            {
                NEI_Temp_data_1_7Ch_data -= 0x40;

            }
        }

        private void NEI_Ch8_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (NEI_Ch8_CheckBox.Checked == true)
            {
                NEI_Temp_data_8_14Ch_data += 0x01;
            }
            else
            {
                NEI_Temp_data_8_14Ch_data -= 0x01;

            }
        }

        private void NEI_Ch9_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (NEI_Ch9_CheckBox.Checked == true)
            {
                NEI_Temp_data_8_14Ch_data += 0x02;
            }
            else
            {
                NEI_Temp_data_8_14Ch_data -= 0x02;
            }
        }

        private void NEI_Ch10_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (NEI_Ch10_CheckBox.Checked == true)
            {
                NEI_Temp_data_8_14Ch_data += 0x04;
            }
            else
            {
                NEI_Temp_data_8_14Ch_data -= 0x04;
            }
        }

        private void NEI_Ch11_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (NEI_Ch11_CheckBox.Checked == true)
            {
                NEI_Temp_data_8_14Ch_data += 0x08;
            }
            else
            {
                NEI_Temp_data_8_14Ch_data -= 0x08;
            }
        }

        private void NEI_Ch12_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (NEI_Ch12_CheckBox.Checked == true)
            {
                NEI_Temp_data_8_14Ch_data += 0x10;
            }
            else
            {
                NEI_Temp_data_8_14Ch_data -= 0x10;
            }
        }

        private void NEI_Ch13_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (NEI_Ch13_CheckBox.Checked == true)
            {
                NEI_Temp_data_8_14Ch_data += 0x20;
            }
            else
            {
                NEI_Temp_data_8_14Ch_data -= 0x20;
            }
        }

        private void NEI_Ch14_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (NEI_Ch14_CheckBox.Checked == true)
            {
                NEI_Temp_data_8_14Ch_data += 0x40;
            }
            else
            {
                NEI_Temp_data_8_14Ch_data -= 0x40;
            }
        }

        private void NEI_Ch15_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (NEI_Ch15_CheckBox.Checked == true)
            {
                NEI_Temp_data_15_21Ch_data += 0x01;
            }
            else
            {
                NEI_Temp_data_15_21Ch_data -= 0x01;
            }
        }

        private void NEI_Ch16_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (NEI_Ch16_CheckBox.Checked == true)
            {
                NEI_Temp_data_15_21Ch_data += 0x02;
            }
            else
            {
                NEI_Temp_data_15_21Ch_data -= 0x02;
            }
        }

        private void NEI_Ch17_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (NEI_Ch17_CheckBox.Checked == true)
            {
                NEI_Temp_data_15_21Ch_data += 0x04;
            }
            else
            {
                NEI_Temp_data_15_21Ch_data -= 0x04;
            }
        }

        private void NEI_Ch18_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (NEI_Ch18_CheckBox.Checked == true)
            {
                NEI_Temp_data_15_21Ch_data += 0x08;
            }
            else
            {
                NEI_Temp_data_15_21Ch_data -= 0x08;
            }
        }

        private void NEI_Ch19_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (NEI_Ch19_CheckBox.Checked == true)
            {
                NEI_Temp_data_15_21Ch_data += 0x10;
            }
            else
            {
                NEI_Temp_data_15_21Ch_data -= 0x10;
            }
        }

        private void NEI_Ch20_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (NEI_Ch20_CheckBox.Checked == true)
            {
                NEI_Temp_data_15_21Ch_data += 0x20;
            }
            else
            {
                NEI_Temp_data_15_21Ch_data -= 0x20;
            }
        }

        private void NEI_Ch21_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (NEI_Ch21_CheckBox.Checked == true)
            {
                NEI_Temp_data_15_21Ch_data += 0x40;
            }
            else
            {
                NEI_Temp_data_15_21Ch_data -= 0x40;
            }
        }

        private void NEI_Ch22_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (NEI_Ch22_CheckBox.Checked == true)
            {
                NEI_Temp_data_22_28Ch_data += 0x01;
            }
            else
            {
                NEI_Temp_data_22_28Ch_data -= 0x01;
            }
        }

        private void NEI_Ch23_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (NEI_Ch23_CheckBox.Checked == true)
            {
                NEI_Temp_data_22_28Ch_data += 0x02;
            }
            else
            {
                NEI_Temp_data_22_28Ch_data -= 0x02;
            }
        }

        private void NEI_Ch24_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (NEI_Ch24_CheckBox.Checked == true)
            {
                NEI_Temp_data_22_28Ch_data += 0x04;
            }
            else
            {
                NEI_Temp_data_22_28Ch_data -= 0x04;
            }
        }

        private void NEI_Ch25_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (NEI_Ch25_CheckBox.Checked == true)
            {
                NEI_Temp_data_22_28Ch_data += 0x08;
            }
            else
            {
                NEI_Temp_data_22_28Ch_data -= 0x08;
            }
        }

        private void NEI_Ch26_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (NEI_Ch26_CheckBox.Checked == true)
            {
                NEI_Temp_data_22_28Ch_data += 0x10;
            }
            else
            {
                NEI_Temp_data_22_28Ch_data -= 0x10;
            }
        }

        private void NEI_Ch27_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (NEI_Ch27_CheckBox.Checked == true)
            {
                NEI_Temp_data_22_28Ch_data += 0x20;
            }
            else
            {
                NEI_Temp_data_22_28Ch_data -= 0x20;
            }
        }

        private void NEI_Ch28_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (NEI_Ch28_CheckBox.Checked == true)
            {
                NEI_Temp_data_22_28Ch_data += 0x40;
            }
            else
            {
                NEI_Temp_data_22_28Ch_data -= 0x40;
            }
        }

        private void NEI_Ch29_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (NEI_Ch29_CheckBox.Checked == true)
            {
                NEI_Temp_data_29_35Ch_data += 0x01;
            }
            else
            {
                NEI_Temp_data_29_35Ch_data -= 0x01;
            }
        }

        private void NEI_Ch30_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (NEI_Ch30_CheckBox.Checked == true)
            {
                NEI_Temp_data_29_35Ch_data += 0x02;
            }
            else
            {
                NEI_Temp_data_29_35Ch_data -= 0x02;
            }
        }

        private void NEI_Ch31_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (NEI_Ch31_CheckBox.Checked == true)
            {
                NEI_Temp_data_29_35Ch_data += 0x04;
            }
            else
            {
                NEI_Temp_data_29_35Ch_data -= 0x04;
            }
        }

        private void NEI_Ch32_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (NEI_Ch32_CheckBox.Checked == true)
            {
                NEI_Temp_data_29_35Ch_data += 0x08;
            }
            else
            {
                NEI_Temp_data_29_35Ch_data -= 0x08;
            }
        }

        private void NEI_Ch33_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (NEI_Ch33_CheckBox.Checked == true)
            {
                NEI_Temp_data_29_35Ch_data += 0x10;
            }
            else
            {
                NEI_Temp_data_29_35Ch_data -= 0x10;
            }
        }

        private void NEI_Ch34_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (NEI_Ch34_CheckBox.Checked == true)
            {
                NEI_Temp_data_29_35Ch_data += 0x20;
            }
            else
            {
                NEI_Temp_data_29_35Ch_data -= 0x20;
            }
        }

        private void NEI_Ch35_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (NEI_Ch35_CheckBox.Checked == true)
            {
                NEI_Temp_data_29_35Ch_data += 0x40;
            }
            else
            {
                NEI_Temp_data_29_35Ch_data -= 0x40;
            }
        }

        private void NEI_Ch36_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (NEI_Ch36_CheckBox.Checked == true)
            {
                NEI_Temp_data_36_42Ch_data += 0x01;
            }
            else
            {
                NEI_Temp_data_36_42Ch_data -= 0x01;
            }
        }

        private void NEI_Ch37_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (NEI_Ch37_CheckBox.Checked == true)
            {
                NEI_Temp_data_36_42Ch_data += 0x02;
            }
            else
            {
                NEI_Temp_data_36_42Ch_data -= 0x02;
            }
        }

        private void NEI_Ch38_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (NEI_Ch38_CheckBox.Checked == true)
            {
                NEI_Temp_data_36_42Ch_data += 0x04;
            }
            else
            {
                NEI_Temp_data_36_42Ch_data -= 0x04;
            }
        }

        private void NEI_Ch39_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (NEI_Ch39_CheckBox.Checked == true)
            {
                NEI_Temp_data_36_42Ch_data += 0x08;
            }
            else
            {
                NEI_Temp_data_36_42Ch_data -= 0x08;
            }
        }

        private void NEI_Ch40_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (NEI_Ch40_CheckBox.Checked == true)
            {
                NEI_Temp_data_36_42Ch_data += 0x10;
            }
            else
            {
                NEI_Temp_data_36_42Ch_data -= 0x10;
            }
        }

        private void NEI_Ch41_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (NEI_Ch41_CheckBox.Checked == true)
            {
                NEI_Temp_data_36_42Ch_data += 0x20;
            }
            else
            {
                NEI_Temp_data_36_42Ch_data -= 0x20;
            }
        }

        private void NEI_Ch42_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (NEI_Ch42_CheckBox.Checked == true)
            {
                NEI_Temp_data_36_42Ch_data += 0x40;
            }
            else
            {
                NEI_Temp_data_36_42Ch_data -= 0x40;
            }
        }

        private void Manual_RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (Manual_RadioButton.Checked == true)
            {
                Fire10Byte_Start_Button.Enabled = true;
                Fire10Byte_Audio_Start_Button.Enabled = true;
                Fire10Byte_Audio_Stop_Button.Enabled = true;
                Fire10Byte_Start_Button.Enabled = true;
                Fire10Byte_Stop_Button.Enabled = true;
                Fire10Byte_Reset_Button.Enabled = true;

                Fire12Byte_Start_Button.Enabled = true;
                Fire12Byte_Audio_Start_Button.Enabled = true;
                Fire12Byte_Audio_Stop_Button.Enabled = true;
                Fire12Byte_Start_Button.Enabled = true;
                Fire12Byte_Stop_Button.Enabled = true;
                Fire12Byte_Reset_Button.Enabled = true;

                FIRE10Byte_Operate_ConboBox.Enabled = false;
                FIRE12Byte_Operate_ConboBox.Enabled = false;
            }
            else
            {
                Fire10Byte_Start_Button.Enabled = false;
                Fire10Byte_Audio_Start_Button.Enabled = false;
                Fire10Byte_Audio_Stop_Button.Enabled = false;
                Fire10Byte_Start_Button.Enabled = false;
                Fire10Byte_Stop_Button.Enabled = false;
                Fire10Byte_Reset_Button.Enabled = false;

                Fire12Byte_Start_Button.Enabled = false;
                Fire12Byte_Audio_Start_Button.Enabled = false;
                Fire12Byte_Audio_Stop_Button.Enabled = false;
                Fire12Byte_Start_Button.Enabled = false;
                Fire12Byte_Stop_Button.Enabled = false;
                Fire12Byte_Reset_Button.Enabled = false;

                FIRE10Byte_Operate_ConboBox.Enabled = true;
                FIRE12Byte_Operate_ConboBox.Enabled = true;
            }
        }

        private void Auto_RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (Auto_RadioButton.Checked == true)
            {
                Fire10Byte_Start_Button.Enabled = false;
                Fire10Byte_Audio_Start_Button.Enabled = false;
                Fire10Byte_Audio_Stop_Button.Enabled = false;
                Fire10Byte_Start_Button.Enabled = false;
                Fire10Byte_Stop_Button.Enabled = false;
                Fire10Byte_Reset_Button.Enabled = false;

                Fire12Byte_Start_Button.Enabled = false;
                Fire12Byte_Audio_Start_Button.Enabled = false;
                Fire12Byte_Audio_Stop_Button.Enabled = false;
                Fire12Byte_Start_Button.Enabled = false;
                Fire12Byte_Stop_Button.Enabled = false;
                Fire12Byte_Reset_Button.Enabled = false;

                FIRE10Byte_Operate_ConboBox.Enabled = true;
                FIRE12Byte_Operate_ConboBox.Enabled = true;
            }
            else
            {
                Fire10Byte_Start_Button.Enabled = true;
                Fire10Byte_Audio_Start_Button.Enabled = true;
                Fire10Byte_Audio_Stop_Button.Enabled = true;
                Fire10Byte_Start_Button.Enabled = true;
                Fire10Byte_Stop_Button.Enabled = true;
                Fire10Byte_Reset_Button.Enabled = true;

                Fire12Byte_Start_Button.Enabled = true;
                Fire12Byte_Audio_Start_Button.Enabled = true;
                Fire12Byte_Audio_Stop_Button.Enabled = true;
                Fire12Byte_Start_Button.Enabled = true;
                Fire12Byte_Stop_Button.Enabled = true;
                Fire12Byte_Reset_Button.Enabled = true;

                FIRE10Byte_Operate_ConboBox.Enabled = false;
                FIRE12Byte_Operate_ConboBox.Enabled = false;
            }
        }

        private void Fire_Insert_Button_Click(object sender, EventArgs e)
        {
            string str = "";
            byte[] byteBuffer_12 = new byte[12];
            byte[] byteBuffer_10 = new byte[10];

            int sum_fire_12byte = 0x00;
            int sum_fire_10byte = 0x00;

            if (Auto_RadioButton.Checked == true && Fire12Byte_Select_RadioButton.Checked == true)
            {
                byteBuffer_12[0] = 0x02;
                byteBuffer_12[1] = Convert.ToByte(Convert.ToByte(FIRE12Byte_Dong_ID_10_ConboBox.SelectedItem) | 0x30);
                byteBuffer_12[2] = Convert.ToByte(Convert.ToByte(FIRE12Byte_Dong_ID_1_ConboBox.SelectedItem) | 0x30);
                byteBuffer_12[3] = 0x2D;
                byteBuffer_12[4] = Convert.ToByte(Convert.ToByte(FIRE12Byte_Gaedan_ID_10_ConboBox.SelectedItem) | 0x30);
                byteBuffer_12[5] = Convert.ToByte(Convert.ToByte(FIRE12Byte_Gaedan_ID_10_ConboBox.SelectedItem) | 0x30);
                byteBuffer_12[6] = 0x2D;
                byteBuffer_12[7] = Convert.ToByte(Convert.ToByte(FIRE12Byte_Floor_ID_10_ConboBox.SelectedItem) | 0x30);
                byteBuffer_12[8] = Convert.ToByte(Convert.ToByte(FIRE12Byte_Floor_ID_1_ConboBox.SelectedItem) | 0x30);
                byteBuffer_12[11] = 0x03;

                sum_fire_12byte = (byteBuffer_12[0] + byteBuffer_12[1] + byteBuffer_12[2] + byteBuffer_12[3] + byteBuffer_12[4] + byteBuffer_12[5] + byteBuffer_12[6] + byteBuffer_12[7] + byteBuffer_12[8] + byteBuffer_12[9] + byteBuffer_12[11]) % 16 + 0x30;

                byteBuffer_12[10] = Convert.ToByte(sum_fire_12byte);

                switch (FIRE12Byte_Operate_ConboBox.SelectedItem)
                {
                    case "화재발생":
                        byteBuffer_12[9] = 0x4E;
                        break;
                    case "화재정지":
                        byteBuffer_12[9] = 0x46;
                        break;
                    case "연동정상":
                        byteBuffer_12[9] = 0x45;
                        break;
                    case "연동정지":
                        byteBuffer_12[9] = 0x65;
                        break;
                    case "전체 복구 신호":
                        break;
                }

                foreach (var b in byteBuffer_12)
                {
                    str += string.Format("{0:x2} ", b);
                }
                Tx_Str_listBox.Items.Add(str);
            }
            else if (Auto_RadioButton.Checked == true && Fire10Byte_Select_RadioButton.Checked == true)
            {
                sum_fire_10byte = (byte)((0x02 + Convert.ToByte(FIRE10Byte_Dong_ID_10_ConboBox.SelectedItem) + Convert.ToByte(FIRE10Byte_Dong_ID_1_ConboBox.SelectedItem) + 0x2D + Convert.ToByte(FIRE10Byte_Gaedan_ID_1_ConboBox.SelectedItem) + 0x2D + Convert.ToByte(FIRE10Byte_Floor_ID_10_ConboBox.SelectedItem) + Convert.ToByte(FIRE10Byte_Floor_ID_1_ConboBox.SelectedItem) + 0x4e + 0x03) % 16 + 0x30);

                byteBuffer_10[0] = 0x02;
                byteBuffer_10[2] = Convert.ToByte(Convert.ToByte(FIRE10Byte_Dong_ID_10_ConboBox.SelectedItem) | 0x30);
                byteBuffer_10[3] = Convert.ToByte(Convert.ToByte(FIRE10Byte_Dong_ID_1_ConboBox.SelectedItem) | 0x30);
                byteBuffer_10[4] = Convert.ToByte(Convert.ToByte(FIRE10Byte_Gaedan_ID_1_ConboBox.SelectedItem) | 0x30);
                byteBuffer_10[6] = Convert.ToByte(Convert.ToByte(FIRE10Byte_Floor_ID_10_ConboBox.SelectedItem) | 0x30);
                byteBuffer_10[7] = Convert.ToByte(Convert.ToByte(FIRE10Byte_Floor_ID_1_ConboBox.SelectedItem) | 0x30);
                byteBuffer_10[8] = 0x03;

                // 이곳부터 수정
                //sum_fire_10byte = (byteBuffer_12[0] + byteBuffer_12[1] + byteBuffer_12[2] + byteBuffer_12[3] + byteBuffer_12[4] + byteBuffer_12[5] + byteBuffer_12[6] + byteBuffer_12[7] + byteBuffer_12[8] + byteBuffer_12[9] + byteBuffer_12[11]) % 16 + 0x30;

                //byteBuffer_10[10] = Convert.ToByte(sum_fire_10byte);

                switch (FIRE10Byte_Operate_ConboBox.SelectedItem)
                {
                    case "화재발생":
                        byteBuffer_10[1] = 0x46;
                        break;
                    case "화재정지":
                        byteBuffer_10[1] = 0x43;
                        break;
                    case "연동정상":
                        byteBuffer_10[1] = 0x44;
                        break;
                    case "연동정지":
                        byteBuffer_10[1] = 0x42;
                        break;
                    case "전체 복구 신호":
                        break;
                    default:
                        MessageBox.Show("잘못된 동작을 입력하셨습니다.!!!");
                        break;
                }

                switch (FIRE10Byte_Seperate_ID_ConboBox.SelectedItem)
                {
                    case "지상층(0x20)":
                        byteBuffer_12[5] = 0x20;
                        break;
                    case "지하층(B)":
                        byteBuffer_12[5] = 0x42;
                        break;
                    case "주차장(P)":
                        byteBuffer_12[5] = 0x50;
                        break;
                    case "옥탑층(K)":
                        byteBuffer_12[5] = 0x4B;
                        break;
                    default:
                        MessageBox.Show("잘못된 구분을 입력하셨습니다.!!!");
                        break;
                }

                foreach (var b in byteBuffer_10)
                {
                    str += string.Format("{0:x2} ", b);
                }
                Tx_Str_listBox.Items.Add(str);
            }
        }

        private void Fire12Byte_Start_Button_Click(object sender, EventArgs e)
        {
            byte[] byteBuffer = new byte[12];
            int sum_fire = 0x00;

            try
            {
                byteBuffer[0] = 0x02;
                byteBuffer[1] = Convert.ToByte(Convert.ToByte(FIRE12Byte_Dong_ID_10_ConboBox.SelectedItem) | 0x30);
                byteBuffer[2] = Convert.ToByte(Convert.ToByte(FIRE12Byte_Dong_ID_1_ConboBox.SelectedItem) | 0x30);
                byteBuffer[3] = 0x2D;
                byteBuffer[4] = Convert.ToByte(Convert.ToByte(FIRE12Byte_Gaedan_ID_10_ConboBox.SelectedItem) | 0x30);
                byteBuffer[5] = Convert.ToByte(Convert.ToByte(FIRE12Byte_Gaedan_ID_1_ConboBox.SelectedItem) | 0x30);
                byteBuffer[6] = 0x2D;
                byteBuffer[7] = Convert.ToByte(Convert.ToByte(FIRE12Byte_Floor_ID_10_ConboBox.SelectedItem) | 0x30);
                byteBuffer[8] = Convert.ToByte(Convert.ToByte(FIRE12Byte_Floor_ID_1_ConboBox.SelectedItem) | 0x30);
                byteBuffer[9] = 0x4E;
                byteBuffer[11] = 0x03;

                sum_fire = (byteBuffer[0] + byteBuffer[1] + byteBuffer[2] + byteBuffer[3] + byteBuffer[4] + byteBuffer[5] + byteBuffer[6] + byteBuffer[7] + byteBuffer[8] + byteBuffer[9] + byteBuffer[11]) % 16 + 0x30;

                byteBuffer[10] = Convert.ToByte(sum_fire);
                serialPort1.Write(byteBuffer, 0, 12);
            }
            catch (System.InvalidOperationException)
            {
                MessageBox.Show("포트가 열리지 않았습니다.!!!");
            }

        }

        private void Fire12Byte_Stop_Button_Click(object sender, EventArgs e)
        {
            byte[] byteBuffer = new byte[12];
            int sum_fire = 0x00;

            try
            {
                byteBuffer[0] = 0x02;
                byteBuffer[1] = Convert.ToByte(Convert.ToByte(FIRE12Byte_Dong_ID_10_ConboBox.SelectedItem) | 0x30);
                byteBuffer[2] = Convert.ToByte(Convert.ToByte(FIRE12Byte_Dong_ID_1_ConboBox.SelectedItem) | 0x30);
                byteBuffer[3] = 0x2D;
                byteBuffer[4] = Convert.ToByte(Convert.ToByte(FIRE12Byte_Gaedan_ID_10_ConboBox.SelectedItem) | 0x30);
                byteBuffer[5] = Convert.ToByte(Convert.ToByte(FIRE12Byte_Gaedan_ID_1_ConboBox.SelectedItem) | 0x30);
                byteBuffer[6] = 0x2D;
                byteBuffer[7] = Convert.ToByte(Convert.ToByte(FIRE12Byte_Floor_ID_10_ConboBox.SelectedItem) | 0x30);
                byteBuffer[8] = Convert.ToByte(Convert.ToByte(FIRE12Byte_Floor_ID_1_ConboBox.SelectedItem) | 0x30);
                byteBuffer[9] = 0x46;
                byteBuffer[11] = 0x03;

                sum_fire = (byteBuffer[0] + byteBuffer[1] + byteBuffer[2] + byteBuffer[3] + byteBuffer[4] + byteBuffer[5] + byteBuffer[6] + byteBuffer[7] + byteBuffer[8] + byteBuffer[9] + byteBuffer[11]) % 16 + 0x30;

                byteBuffer[10] = Convert.ToByte(sum_fire);
                serialPort1.Write(byteBuffer, 0, 12);
            }
            catch (System.InvalidOperationException)
            {
                MessageBox.Show("포트가 열리지 않았습니다.!!!");
            }

        }

        private void Fire12Byte_Audio_Start_Button_Click(object sender, EventArgs e)
        {
            byte[] byteBuffer = new byte[12];
            int sum_fire = 0x00;

            try
            {
                byteBuffer[0] = 0x02;
                byteBuffer[1] = Convert.ToByte(Convert.ToByte(FIRE12Byte_Dong_ID_10_ConboBox.SelectedItem) | 0x30);
                byteBuffer[2] = Convert.ToByte(Convert.ToByte(FIRE12Byte_Dong_ID_1_ConboBox.SelectedItem) | 0x30);
                byteBuffer[3] = 0x2D;
                byteBuffer[4] = Convert.ToByte(Convert.ToByte(FIRE12Byte_Gaedan_ID_10_ConboBox.SelectedItem) | 0x30);
                byteBuffer[5] = Convert.ToByte(Convert.ToByte(FIRE12Byte_Gaedan_ID_1_ConboBox.SelectedItem) | 0x30);
                byteBuffer[6] = 0x2D;
                byteBuffer[7] = Convert.ToByte(Convert.ToByte(FIRE12Byte_Floor_ID_10_ConboBox.SelectedItem) | 0x30);
                byteBuffer[8] = Convert.ToByte(Convert.ToByte(FIRE12Byte_Floor_ID_1_ConboBox.SelectedItem) | 0x30);
                byteBuffer[9] = 0x65;
                byteBuffer[11] = 0x03;

                sum_fire = (byteBuffer[0] + byteBuffer[1] + byteBuffer[2] + byteBuffer[3] + byteBuffer[4] + byteBuffer[5] + byteBuffer[6] + byteBuffer[7] + byteBuffer[8] + byteBuffer[9] + byteBuffer[11]) % 16 + 0x30;

                byteBuffer[10] = Convert.ToByte(sum_fire);
                serialPort1.Write(byteBuffer, 0, 12);
            }
            catch (System.InvalidOperationException)
            {
                MessageBox.Show("포트가 열리지 않았습니다.!!!");
            }

        }

        private void Fire12Byte_Audio_Stop_Button_Click(object sender, EventArgs e)
        {
            byte[] byteBuffer = new byte[12];
            int sum_fire = 0x00;

            try
            {
                byteBuffer[0] = 0x02;
                byteBuffer[1] = Convert.ToByte(Convert.ToByte(FIRE12Byte_Dong_ID_10_ConboBox.SelectedItem) | 0x30);
                byteBuffer[2] = Convert.ToByte(Convert.ToByte(FIRE12Byte_Dong_ID_1_ConboBox.SelectedItem) | 0x30);
                byteBuffer[3] = 0x2D;
                byteBuffer[4] = Convert.ToByte(Convert.ToByte(FIRE12Byte_Gaedan_ID_10_ConboBox.SelectedItem) | 0x30);
                byteBuffer[5] = Convert.ToByte(Convert.ToByte(FIRE12Byte_Gaedan_ID_1_ConboBox.SelectedItem) | 0x30);
                byteBuffer[6] = 0x2D;
                byteBuffer[7] = Convert.ToByte(Convert.ToByte(FIRE12Byte_Floor_ID_10_ConboBox.SelectedItem) | 0x30);
                byteBuffer[8] = Convert.ToByte(Convert.ToByte(FIRE12Byte_Floor_ID_1_ConboBox.SelectedItem) | 0x30);
                byteBuffer[9] = 0x45;
                byteBuffer[11] = 0x03;

                sum_fire = (byteBuffer[0] + byteBuffer[1] + byteBuffer[2] + byteBuffer[3] + byteBuffer[4] + byteBuffer[5] + byteBuffer[6] + byteBuffer[7] + byteBuffer[8] + byteBuffer[9] + byteBuffer[11]) % 16 + 0x30;

                byteBuffer[10] = Convert.ToByte(sum_fire);
                serialPort1.Write(byteBuffer, 0, 12);

            }
            catch (System.InvalidOperationException)
            {
                MessageBox.Show("포트가 열리지 않았습니다.!!!");
            }

        }

        private void Fire12Byte_Reset_Button_Click(object sender, EventArgs e)
        {
            byte[] byteBuffer = new byte[12];
            int sum_fire = 0x00;

            try
            {
                byteBuffer[0] = 0x02; // 2
                byteBuffer[1] = 0x30; // 48
                byteBuffer[2] = 0x30; // 48
                byteBuffer[3] = 0x2D; // 32+13 45
                byteBuffer[4] = 0x30; // 48
                byteBuffer[5] = 0x30; // 48
                byteBuffer[6] = 0x2D; // 45
                byteBuffer[7] = 0x30; // 48
                byteBuffer[8] = 0x30; // 48
                byteBuffer[9] = 0x52; // 82
                byteBuffer[11] = 0x03; // 3

                sum_fire = (byteBuffer[0] + byteBuffer[1] + byteBuffer[2] + byteBuffer[3] + byteBuffer[4] + byteBuffer[5] + byteBuffer[6] + byteBuffer[7] + byteBuffer[8] + byteBuffer[9] + byteBuffer[11])%16 + 0x30;

                byteBuffer[10] = Convert.ToByte(sum_fire);
                serialPort1.Write(byteBuffer, 0, 12);
            }
            catch (System.InvalidOperationException)
            {
                MessageBox.Show("포트가 열리지 않았습니다.!!!");
            }

        }

        private void Fire10Byte_Start_Button_Click(object sender, EventArgs e)
        {

        }

        private void Fire10Byte_Stop_Button_Click(object sender, EventArgs e)
        {

        }

        private void Fire10Byte_Audio_Start_Button_Click(object sender, EventArgs e)
        {

        }

        private void Fire10Byte_Audio_Stop_Button_Click(object sender, EventArgs e)
        {

        }

        private void Fire10Byte_Reset_Button_Click(object sender, EventArgs e)
        {

        }

        private void NMC_Cmd_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(NMC_Cmd_comboBox.SelectedItem)
            {
                case"INIT":
                    NMC44_MUX_Groupbox.Enabled = false;
                    NMC44_VOL_Groupbox.Enabled = false;
                    NMC44_MOT_Groupbox.Enabled = false;
                    NMC44_GPO_Groupbox.Enabled = false;
                    NMC44_TRB_Groupbox.Enabled = false;
                    NMC44_BAS_Groupbox.Enabled = false;
                    NMC44_FIRP_Groupbox.Enabled = false;
                    NMC44_FIRL_Groupbox.Enabled = false;
                    NMC44_EMIC_Groupbox.Enabled = false;
                    NMC44_FIRE12_Groupbox.Enabled = false;
                    NMC44_FIRE10_Groupbox.Enabled = false;
                    break;
                case"DMY":
                    NMC44_MUX_Groupbox.Enabled = false;
                    NMC44_VOL_Groupbox.Enabled = false;
                    NMC44_MOT_Groupbox.Enabled = false;
                    NMC44_GPO_Groupbox.Enabled = false;
                    NMC44_TRB_Groupbox.Enabled = false;
                    NMC44_BAS_Groupbox.Enabled = false;
                    NMC44_FIRP_Groupbox.Enabled = false;
                    NMC44_FIRL_Groupbox.Enabled = false;
                    NMC44_EMIC_Groupbox.Enabled = false;
                    NMC44_FIRE12_Groupbox.Enabled = false;
                    NMC44_FIRE10_Groupbox.Enabled = false;
                    break;
                case"MUX":
                    NMC44_MUX_Groupbox.Enabled = true;
                    NMC44_VOL_Groupbox.Enabled = false;
                    NMC44_MOT_Groupbox.Enabled = false;
                    NMC44_GPO_Groupbox.Enabled = false;
                    NMC44_TRB_Groupbox.Enabled = false;
                    NMC44_BAS_Groupbox.Enabled = false;
                    NMC44_FIRP_Groupbox.Enabled = false;
                    NMC44_FIRL_Groupbox.Enabled = false;
                    NMC44_EMIC_Groupbox.Enabled = false;
                    NMC44_FIRE12_Groupbox.Enabled = false;
                    NMC44_FIRE10_Groupbox.Enabled = false;
                    break;
                case"VOL":
                    NMC44_MUX_Groupbox.Enabled = false;
                    NMC44_VOL_Groupbox.Enabled = true;
                    NMC44_MOT_Groupbox.Enabled = false;
                    NMC44_GPO_Groupbox.Enabled = false;
                    NMC44_TRB_Groupbox.Enabled = false;
                    NMC44_BAS_Groupbox.Enabled = false;
                    NMC44_FIRP_Groupbox.Enabled = false;
                    NMC44_FIRL_Groupbox.Enabled = false;
                    NMC44_EMIC_Groupbox.Enabled = false;
                    NMC44_FIRE12_Groupbox.Enabled = false;
                    NMC44_FIRE10_Groupbox.Enabled = false;
                    break;
                case"MOT":
                    NMC44_MUX_Groupbox.Enabled = false;
                    NMC44_VOL_Groupbox.Enabled = false;
                    NMC44_MOT_Groupbox.Enabled = true;
                    NMC44_GPO_Groupbox.Enabled = false;
                    NMC44_TRB_Groupbox.Enabled = false;
                    NMC44_BAS_Groupbox.Enabled = false;
                    NMC44_FIRP_Groupbox.Enabled = false;
                    NMC44_FIRL_Groupbox.Enabled = false;
                    NMC44_EMIC_Groupbox.Enabled = false;
                    NMC44_FIRE12_Groupbox.Enabled = false;
                    NMC44_FIRE10_Groupbox.Enabled = false;
                    break;
                case"GPO":
                    NMC44_MUX_Groupbox.Enabled = false;
                    NMC44_VOL_Groupbox.Enabled = false;
                    NMC44_MOT_Groupbox.Enabled = false;
                    NMC44_GPO_Groupbox.Enabled = true;
                    NMC44_TRB_Groupbox.Enabled = false;
                    NMC44_BAS_Groupbox.Enabled = false;
                    NMC44_FIRP_Groupbox.Enabled = false;
                    NMC44_FIRL_Groupbox.Enabled = false;
                    NMC44_EMIC_Groupbox.Enabled = false;
                    NMC44_FIRE12_Groupbox.Enabled = false;
                    NMC44_FIRE10_Groupbox.Enabled = false;
                    break;
                case"TRB":
                    NMC44_MUX_Groupbox.Enabled = false;
                    NMC44_VOL_Groupbox.Enabled = false;
                    NMC44_MOT_Groupbox.Enabled = false;
                    NMC44_GPO_Groupbox.Enabled = false;
                    NMC44_TRB_Groupbox.Enabled = true;
                    NMC44_BAS_Groupbox.Enabled = false;
                    NMC44_FIRP_Groupbox.Enabled = false;
                    NMC44_FIRL_Groupbox.Enabled = false;
                    NMC44_EMIC_Groupbox.Enabled = false;
                    NMC44_FIRE12_Groupbox.Enabled = false;
                    NMC44_FIRE10_Groupbox.Enabled = false;
                    break;
                case"BAS":
                    NMC44_MUX_Groupbox.Enabled = false;
                    NMC44_VOL_Groupbox.Enabled = false;
                    NMC44_MOT_Groupbox.Enabled = false;
                    NMC44_GPO_Groupbox.Enabled = false;
                    NMC44_TRB_Groupbox.Enabled = false;
                    NMC44_BAS_Groupbox.Enabled = true;
                    NMC44_FIRP_Groupbox.Enabled = false;
                    NMC44_FIRL_Groupbox.Enabled = false;
                    NMC44_EMIC_Groupbox.Enabled = false;
                    NMC44_FIRE12_Groupbox.Enabled = false;
                    NMC44_FIRE10_Groupbox.Enabled = false;
                    break;
                case"FIRP":
                    NMC44_MUX_Groupbox.Enabled = false;
                    NMC44_VOL_Groupbox.Enabled = false;
                    NMC44_MOT_Groupbox.Enabled = false;
                    NMC44_GPO_Groupbox.Enabled = false;
                    NMC44_TRB_Groupbox.Enabled = false;
                    NMC44_BAS_Groupbox.Enabled = false;
                    NMC44_FIRP_Groupbox.Enabled = true;
                    NMC44_FIRL_Groupbox.Enabled = false;
                    NMC44_EMIC_Groupbox.Enabled = false;
                    NMC44_FIRE12_Groupbox.Enabled = false;
                    NMC44_FIRE10_Groupbox.Enabled = false;
                    break;
                case"FIRL":
                    NMC44_MUX_Groupbox.Enabled = false;
                    NMC44_VOL_Groupbox.Enabled = false;
                    NMC44_MOT_Groupbox.Enabled = false;
                    NMC44_GPO_Groupbox.Enabled = false;
                    NMC44_TRB_Groupbox.Enabled = false;
                    NMC44_BAS_Groupbox.Enabled = false;
                    NMC44_FIRP_Groupbox.Enabled = false;
                    NMC44_FIRL_Groupbox.Enabled = true;
                    NMC44_EMIC_Groupbox.Enabled = false;
                    NMC44_FIRE12_Groupbox.Enabled = false;
                    NMC44_FIRE10_Groupbox.Enabled = false;
                    break;
                case"EMIC":
                    NMC44_MUX_Groupbox.Enabled = false;
                    NMC44_VOL_Groupbox.Enabled = false;
                    NMC44_MOT_Groupbox.Enabled = false;
                    NMC44_GPO_Groupbox.Enabled = false;
                    NMC44_TRB_Groupbox.Enabled = false;
                    NMC44_BAS_Groupbox.Enabled = false;
                    NMC44_FIRP_Groupbox.Enabled = false;
                    NMC44_FIRL_Groupbox.Enabled = false;
                    NMC44_EMIC_Groupbox.Enabled = true;
                    NMC44_FIRE12_Groupbox.Enabled = false;
                    NMC44_FIRE10_Groupbox.Enabled = false;
                    break;
                case"FIRE(12Byte)":
                    NMC44_MUX_Groupbox.Enabled = false;
                    NMC44_VOL_Groupbox.Enabled = false;
                    NMC44_MOT_Groupbox.Enabled = false;
                    NMC44_GPO_Groupbox.Enabled = false;
                    NMC44_TRB_Groupbox.Enabled = false;
                    NMC44_BAS_Groupbox.Enabled = false;
                    NMC44_FIRP_Groupbox.Enabled = false;
                    NMC44_FIRL_Groupbox.Enabled = false;
                    NMC44_EMIC_Groupbox.Enabled = false;
                    NMC44_FIRE12_Groupbox.Enabled = true;
                    NMC44_FIRE10_Groupbox.Enabled = false;
                    break;
                case"FIRE(10Byte)":
                    NMC44_MUX_Groupbox.Enabled = false;
                    NMC44_VOL_Groupbox.Enabled = false;
                    NMC44_MOT_Groupbox.Enabled = false;
                    NMC44_GPO_Groupbox.Enabled = false;
                    NMC44_TRB_Groupbox.Enabled = false;
                    NMC44_BAS_Groupbox.Enabled = false;
                    NMC44_FIRP_Groupbox.Enabled = false;
                    NMC44_FIRL_Groupbox.Enabled = false;
                    NMC44_EMIC_Groupbox.Enabled = false;
                    NMC44_FIRE12_Groupbox.Enabled = false;
                    NMC44_FIRE10_Groupbox.Enabled = true;
                    break;
                case"VER":
                    NMC44_MUX_Groupbox.Enabled = false;
                    NMC44_VOL_Groupbox.Enabled = false;
                    NMC44_MOT_Groupbox.Enabled = false;
                    NMC44_GPO_Groupbox.Enabled = false;
                    NMC44_TRB_Groupbox.Enabled = false;
                    NMC44_BAS_Groupbox.Enabled = false;
                    NMC44_FIRP_Groupbox.Enabled = false;
                    NMC44_FIRL_Groupbox.Enabled = false;
                    NMC44_EMIC_Groupbox.Enabled = false;
                    NMC44_FIRE12_Groupbox.Enabled = false;
                    NMC44_FIRE10_Groupbox.Enabled = false;
                    break;
                default:
                    MessageBox.Show("NMC44 명령어 오류!!!");
                    break;
            }
        }

        private void NMC_Insert_Button_Click(object sender, EventArgs e)
        {
            // 한 글자만 선택 또는 입력 받는 combobox 구현 시, 속성에서 ComboBox.AutoCompleteMode SuggestAppend 적용해야함. 한 글자 입력시, 문자열(\n, \r)로 키보드 입력 받기 때문에 제대로 입력을 판별하지 못하는 것으로 추정됨.
            // https://fishpoint.tistory.com/622 참조

            if(NMC_Cmd_comboBox.SelectedItem != null && (NMC44_ID_10_comboBox.SelectedItem != null && NMC44_ID_1_comboBox.SelectedItem != null))
            {
                switch (NMC_Cmd_comboBox.SelectedItem)
                {
                    case"INIT":
                        Tx_Str_listBox.Items.Add("&NMC" + NMC44_ID_10_comboBox.SelectedItem.ToString() + NMC44_ID_1_comboBox.SelectedItem.ToString() + "," + NMC_Cmd_comboBox.SelectedItem); //복수의 문자열 송신을 위한 리스트 박스에 아이템 추가
                        break;
                    case"DMY":
                        Tx_Str_listBox.Items.Add("&NMC" + NMC44_ID_10_comboBox.SelectedItem.ToString() + NMC44_ID_1_comboBox.SelectedItem.ToString() + "," + NMC_Cmd_comboBox.SelectedItem); //복수의 문자열 송신을 위한 리스트 박스에 아이템 추가
                        break;
                    case"MUX":
                        try
                        {
                            Tx_Str_listBox.Items.Add("&NMC" + NMC44_ID_10_comboBox.SelectedItem.ToString() + NMC44_ID_1_comboBox.SelectedItem.ToString() + "," + NMC_Cmd_comboBox.SelectedItem + "," + MUX_Ouput_Ch_comboBox.SelectedItem.ToString().Substring(0, 2) + "," + MUX_Input_Ch_comboBox.SelectedItem.ToString().Substring(0, 1) + "," + MUX_Vol_Select_comboBox.SelectedItem.ToString().Substring(0, 1) + "," + MUX_Ext_Priority_comboBox.SelectedItem.ToString().Substring(0, 1)); //복수의 문자열 송신을 위한 리스트 박스에 아이템 추가

                        }
                        catch(NullReferenceException)
                        {
                            MessageBox.Show("입력채널, 출력채널, 볼륨, 외부 입력 우선순위 확인!!!!!", "채널 및 볼륨 제어(MUX)");
                        }
                        break;
                    case"VOL":
                        try
                        {
                            Tx_Str_listBox.Items.Add("&NMC" + NMC44_ID_10_comboBox.SelectedItem.ToString() + NMC44_ID_1_comboBox.SelectedItem.ToString() + "," + NMC_Cmd_comboBox.SelectedItem + "," + VOL_Output_Ch_comboBox.SelectedItem.ToString().Substring(0, 2) + "," + VOL_Vol_Select_comboBox.SelectedItem.ToString().Substring(0, 1)); //복수의 문자열 송신을 위한 리스트 박스에 아이템 추가
                        }
                        catch (NullReferenceException)
                        {
                            MessageBox.Show("출력채널, 볼륨 확인!!!!!", "볼륨 제어(VOL)");
                        }
                        break;
                    case "GPO":
                        try
                        {
                            Tx_Str_listBox.Items.Add("&NMC" + NMC44_ID_10_comboBox.SelectedItem.ToString() + NMC44_ID_1_comboBox.SelectedItem.ToString() + "," + NMC_Cmd_comboBox.SelectedItem + "," + GPO_Sel_Ch_comboBox.SelectedItem.ToString().Substring(0, 1) + "," + GPO_ON_OFF_comboBox.SelectedItem.ToString().Substring(0, 1)); //복수의 문자열 송신을 위한 리스트 박스에 아이템 추가
                        }
                        catch (NullReferenceException)
                        {
                            MessageBox.Show("채널, ON/OFF 확인!!!!!", "GPOUT 제어(GPO)");
                        }
                        break;
                    case "MOT":
                        try
                        {
                            Tx_Str_listBox.Items.Add("&NMC" + NMC44_ID_10_comboBox.SelectedItem.ToString() + NMC44_ID_1_comboBox.SelectedItem.ToString() + "," + NMC_Cmd_comboBox.SelectedItem + "," + MOT_Output_Ch_comboBox.SelectedItem.ToString().Substring(0, 1)); //복수의 문자열 송신을 위한 리스트 박스에 아이템 추가
                        }
                        catch (NullReferenceException)
                        {
                            MessageBox.Show("출력채널 확인!!!!!", "채널 모니터링(MOT)");
                        }
                        break;
                    case"TRB":
                        try
                        {
                            Tx_Str_listBox.Items.Add("&NMC" + NMC44_ID_10_comboBox.SelectedItem.ToString() + NMC44_ID_1_comboBox.SelectedItem.ToString() + "," + NMC_Cmd_comboBox.SelectedItem + "," + TRB_Output_Ch_comboBox.SelectedItem.ToString().Substring(0, 2) + "," + TRB_Vol_Select_comboBox.SelectedItem); //복수의 문자열 송신을 위한 리스트 박스에 아이템 추가
                        }
                        catch (NullReferenceException)
                        {
                            MessageBox.Show("채널, ON/OFF 확인!!!!!", "Treble 제어(TRB)");
                        }
                        break;
                    case"BAS":
                        try
                        {
                            Tx_Str_listBox.Items.Add("&NMC" + NMC44_ID_10_comboBox.SelectedItem.ToString() + NMC44_ID_1_comboBox.SelectedItem.ToString() + "," + NMC_Cmd_comboBox.SelectedItem + "," + BAS_Output_Ch_comboBox.SelectedItem.ToString().Substring(0, 2) + "," + BAS_Vol_Select_comboBox.SelectedItem); //복수의 문자열 송신을 위한 리스트 박스에 아이템 추가
                        }
                        catch (NullReferenceException)
                        {
                            MessageBox.Show("출력채널, 볼륨 확인!!!!!", "Base 제어(BAS)");
                        }
                        break;
                    case"FIRP":
                        try
                        {
                            Tx_Str_listBox.Items.Add("&NMC" + NMC44_ID_10_comboBox.SelectedItem.ToString() + NMC44_ID_1_comboBox.SelectedItem.ToString() + "," + NMC_Cmd_comboBox.SelectedItem + "," + FIRP_Protocol_Sel_comboBox.SelectedItem.ToString().Substring(0, 1)); //복수의 문자열 송신을 위한 리스트 박스에 아이템 추가
                        }
                        catch (NullReferenceException)
                        {
                            MessageBox.Show("프로토콜 설정 확인!!!!!", "화재 수신반 제어(FIRP)");
                        }
                        break;
                    case"FIRL":
                        try
                        {
                            Tx_Str_listBox.Items.Add("&NMC" + NMC44_ID_10_comboBox.SelectedItem.ToString() + NMC44_ID_1_comboBox.SelectedItem.ToString() + "," + NMC_Cmd_comboBox.SelectedItem + "," + FIRL_LED_On_Off_comboBox.SelectedItem.ToString().Substring(0, 1)); //복수의 문자열 송신을 위한 리스트 박스에 아이템 추가
                        }
                        catch (NullReferenceException)
                        {
                            MessageBox.Show("ON/OFF 확인!!!!!", "화재 LED 제어(FIRL)");
                        }
                        break;
                    case"EMIC":
                        try
                        {
                            Tx_Str_listBox.Items.Add("&NMC" + NMC44_ID_10_comboBox.SelectedItem.ToString() + NMC44_ID_1_comboBox.SelectedItem.ToString() + "," + NMC_Cmd_comboBox.SelectedItem + "," + EMIC_LED_On_Off_comboBox.SelectedItem.ToString().Substring(0, 1)); //복수의 문자열 송신을 위한 리스트 박스에 아이템 추가
                        }
                        catch (NullReferenceException)
                        {
                            MessageBox.Show("ON/OFF 확인!!!!!", "EM MIC 제어(EMIC)");
                        }
                        break;
                    case"FIRE(12Byte)":
                        try
                        {
                            Tx_Str_listBox.Items.Add("&NMC" + NMC44_ID_10_comboBox.SelectedItem.ToString() + NMC44_ID_1_comboBox.SelectedItem.ToString() + "," + NMC_Cmd_comboBox.SelectedItem.ToString().Substring(0, 4) + "," + FIRE12_Operate_Sel_comboBox.SelectedItem.ToString().Substring(0, 1) + ',' + FIRE12_Dong_ID10_Sel_comboBox.SelectedItem + FIRE12_Dong_ID1_Sel_comboBox.SelectedItem + ',' + FIRE12_Gaedan_ID10_Sel_comboBox.SelectedItem + FIRE12_Gaedan_ID1_Sel_comboBox.SelectedItem + ',' + FIRE12_Floor_ID10_Sel_comboBox.SelectedItem + FIRE12_Floor_ID1_Sel_comboBox.SelectedItem); //복수의 문자열 송신을 위한 리스트 박스에 아이템 추가
                        }
                        catch (NullReferenceException)
                        {
                            MessageBox.Show("동작(기능), 동(십 / 일), 계단(십 / 일), 층(십 / 일) 확인!!!!!", "소방 12Byte 수신 시, 제어(FIRE)");
                        }
                        break;
                    case"FIRE(10Byte)":
                        try
                        {
                            Tx_Str_listBox.Items.Add("&NMC" + NMC44_ID_10_comboBox.SelectedItem.ToString() + NMC44_ID_1_comboBox.SelectedItem.ToString() + "," + NMC_Cmd_comboBox.SelectedItem.ToString().Substring(0, 4) + "," + FIRE10_Operate_Sel_comboBox.SelectedItem.ToString().Substring(0, 1) + "," + FIRE10_Seperate_Sel_comboBox.SelectedItem.ToString().Substring(0, 1) + ',' + FIRE10_Dong_ID10_Sel_comboBox.SelectedItem + FIRE10_Dong_ID1_Sel_comboBox.SelectedItem + ',' + FIRE10_Gaedan_ID10_Sel_comboBox.SelectedItem + FIRE10_Gaedan_ID1_Sel_comboBox.SelectedItem + ',' + FIRE10_Floor_ID10_Sel_comboBox.SelectedItem + FIRE10_Floor_ID1_Sel_comboBox.SelectedItem); //복수의 문자열 송신을 위한 리스트 박스에 아이템 추가
                        }
                        catch (NullReferenceException)
                        {
                            MessageBox.Show("동작(기능), 층(구분), 동(십 / 일), 계단(십 / 일), 층(십 / 일) 확인!!!!!", "소방 10Byte 수신 시, 제어(FIRE)");
                        }
                        break;
                    case"VER":
                        break;
                    default:
                        MessageBox.Show("NMC44 명령어 오류!!!");
                        break;
                }
            }
            else if (NMC_Cmd_comboBox.SelectedItem == null && (NMC44_ID_10_comboBox.SelectedItem != null && NMC44_ID_1_comboBox.SelectedItem != null))
            {
                MessageBox.Show("NMC44 명령어 선택 오류!!!!!");
            }
            else if (NMC_Cmd_comboBox.SelectedItem != null && (NMC44_ID_10_comboBox.SelectedItem == null || NMC44_ID_1_comboBox.SelectedItem == null))
            {
                MessageBox.Show("NMC44 ID 선택 오류!!!!!");
            }
            else if (NMC_Cmd_comboBox.SelectedItem == null && (NMC44_ID_10_comboBox.SelectedItem == null || NMC44_ID_1_comboBox.SelectedItem == null))
            {
                MessageBox.Show("NMC44 명령어, ID 선택 오류!!!!!");
            }
        }

        private void MPR_Manual_RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (MPR_Manual_RadioButton.Checked == true)
            {
                MPR_POWER_ON_OFF_button.Enabled = true;
                MPR_CD_Control_button.Enabled = true;
                MPR_CD_Volume_button.Enabled = true;
                MPR_CD_Track_button.Enabled = true;
                switch (MPR_Cmd_comboBox.SelectedItem)
                {
                    case "Power ON/OFF":
                        break;
                    case "CD Control":
                        break;
                    case "CD Volume":
                        break;
                    case "CD TRACK":
                        break;
                    default:
                        MessageBox.Show("MPR 명령어 오류!!!");
                        break;

                }
            }
        }

        private void MPR_Auto_RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (MPR_Auto_RadioButton.Checked == true)
            {
                MPR_POWER_ON_OFF_button.Enabled = false;
                MPR_CD_Control_button.Enabled = false;
                MPR_CD_Volume_button.Enabled = false;
                MPR_CD_Track_button.Enabled = false;

                switch (MPR_Cmd_comboBox.SelectedItem)
                {
                    case "Power ON/OFF":
                        break;
                    case "CD Control":
                        break;
                    case "CD Volume":
                        break;
                    case "CD TRACK":
                        break;
                    default:
                        MessageBox.Show("MPR 명령어 오류!!!");
                        break;

                }
            }
        }
    }
}
