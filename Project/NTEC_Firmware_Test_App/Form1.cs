using System;
using System.IO.Ports;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NTEC_Firmware_Test_App
{

    public partial class NTEC_Form : Form
    {
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


        public NTEC_Form()
        {
            InitializeComponent();
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox_Port_Number.DataSource = SerialPort.GetPortNames(); //연결 가능한 시리얼포트 이름을 콤보박스에 가져오기 

            comboBox_Port_Number.TabIndex = comboBox_Port_Number.SelectedIndex = 0;
            comboBox_Port_BaudRate.TabIndex = comboBox_Port_BaudRate.SelectedIndex = 4;
            comboBox_Port_DataBits.Text = "8";
            comboBox_Port_Parity.Text = "None";
            comboBox_Port_StopBits.Text = "1";
            comboBox_Port_FlowControl.Text = "None";
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
            if (!serialPort1.IsOpen) // 시리얼 포트 연결 확인(연결되지 않았을 때)
            {
                serialPort1.PortName = Convert.ToString(comboBox_Port_Number.SelectedItem);                                             // PortName은 string이므로 형변환하여 할당
                serialPort1.BaudRate = Convert.ToInt32(comboBox_Port_BaudRate.SelectedItem);                                            // BaudRate은 string이므로 형변환하여 할당
                serialPort1.DataBits = Convert.ToInt32(comboBox_Port_DataBits.SelectedItem);                                            // DateBits은 string이므로 형변환하여 할당
                serialPort1.Parity = (Parity)Enum.Parse(typeof(Parity), comboBox_Port_Parity.SelectedItem.ToString(), true);            // Parity은 Parity 형식의 Enum 이므로 형변환하여 할당
                serialPort1.StopBits= (StopBits)Enum.Parse(typeof(StopBits), comboBox_Port_StopBits.SelectedItem.ToString(), true);     // StopBits은 Parity 형식의 Enum이므로 형변환하여 할당
                serialPort1.Handshake = (Handshake)Enum.Parse(typeof(Handshake), comboBox_Port_FlowControl.SelectedItem.ToString(), true); // Handshake은 Parity 형식의 Enum이므로 형변환하여 할당
                /* C# 전송시 1ms로 세팅해도 송신시 약 30ms 딜레이 주지 못함 시리얼 부분 작성 후 검토 할 것*/

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
            string s = serialPort1.ReadLine();
            this.BeginInvoke((new Action(delegate { ShowValue(s); })));
        }

        private void ShowValue(string s)
        {
            string item = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss.ffff") +"    "+s+"      "+(s.Count()+1)+"      "+"R"+Rx_Str_Cnt++;
            Serial_TRX_listBox.Items.Add(item);
            Serial_TRX_listBox.SelectedIndex = Serial_TRX_listBox.Items.Count - 1;  // 계속 스크롤이 되도록 처리
        }

        private void Tx_Single_Button_Click(object sender, EventArgs e)
        {
            //텍스트박스의 텍스트를 시리얼통신으로 송신
            serialPort1.Write(Tx_Single_textBox.Text+"\r\n");
            Serial_TRX_listBox.Items.Add(DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss.ffff") + "    " +Tx_Single_textBox.Text + "      " +(Tx_Single_textBox.Text.Count()+2)+ "      " +"T"+Tx_Str_Cnt++);
            Serial_TRX_listBox.SelectedIndex = Serial_TRX_listBox.Items.Count - 1;  // 계속 스크롤이 되도록 처리
        }

        private void listBox2_Clr_Button_Click(object sender, EventArgs e)
        {
            Serial_TRX_listBox.Items.Clear(); // 송, 수신 문자열 관련 리스트박스 화면 클리어(지우기)
            Rx_Str_Cnt = 0;
            Tx_Str_Cnt = 0;
        }

        private void Tx_Str_Insert_Button_Click(object sender, EventArgs e)
        {
            Tx_Str_listBox.Items.Add(Tx_Single_textBox.Text); //복수의 문자열 송신을 위한 리스트 박스에 아이템 추가
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

            foreach ( var item in Tx_Str_listBox.Items)
            {
                serialPort1.Write(item.ToString() + "\r\n");
                Serial_TRX_listBox.Items.Add(DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss.ffff") + "    " + item.ToString() + "      " + (item.ToString().Count() + 2) + "      " + "T" + Tx_Str_Cnt++);
                await Task.Delay(msc);

            }
        }

        async private void Tx_Multi_button_Click(object sender, EventArgs e)
        {
            int msc = Convert.ToInt32(Delay_textBox.Text);

            Multi_flag = true;
            while(Multi_flag)
            {
                foreach (var item in Tx_Str_listBox.Items)
                {
                    serialPort1.Write(item.ToString() + "\r\n");
                    Serial_TRX_listBox.Items.Add(DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss.ffff") + "    " + item.ToString() + "      " + (item.ToString().Count() + 2) + "      " + "T" + Tx_Str_Cnt++);
                    await Task.Delay(msc);
                }
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
            //if(NRG_Cmd_comboBox.SelectedIndex >= 0)
            if (NRG_Cmd_comboBox.SelectedItem != null)
            {
                Tx_Str_listBox.Items.Add("&NRGFF" + "," + NRG_Cmd_comboBox.SelectedItem + "," + NRG_Temp_NOR_1_8Ch_data.ToString("X2").ToLower() + "," + NRG_Temp_NOR_9_16Ch_data.ToString("X2").ToLower() + "," + NRG_Temp_EMR_1_8Ch_data.ToString("X2").ToLower() + "," + NRG_Temp_EMR_9_16Ch_data.ToString("X2").ToLower()); //복수의 문자열 송신을 위한 리스트 박스에 아이템 추가

            }
            else
            {
                MessageBox.Show("NRG16 명령어 선택 오류!!!!!");
            }
        }

        private void NDT_Insert_Button_Click(object sender, EventArgs e)
        {
            if (NDT_Cmd_comboBox.SelectedItem != null)
            {
                Tx_Str_listBox.Items.Add("&NDTFF" + "," + NDT_Cmd_comboBox.SelectedItem + "," + NDT_Temp_NOR_1_8Ch_data.ToString("X2").ToLower() + "," + NDT_Temp_NOR_9_16Ch_data.ToString("X2").ToLower() + "," + NDT_Temp_EMR_1_8Ch_data.ToString("X2").ToLower() + "," + NDT_Temp_EMR_9_16Ch_data.ToString("X2").ToLower()); //복수의 문자열 송신을 위한 리스트 박스에 아이템 추가
            }
            else
            {
                MessageBox.Show("NRT16 명령어 선택 오류!!!!!");
            }
        }

        private void NRT_Insert_Button_Click(object sender, EventArgs e)
        {
            if (NRT_Cmd_comboBox.SelectedItem != null)
            {
                Tx_Str_listBox.Items.Add("&NRTFF" + "," + NRT_Cmd_comboBox.SelectedItem + "," + NRT_Temp_NOR_1_8Ch_data.ToString("X2").ToLower() + "," + NRT_Temp_NOR_9_16Ch_data.ToString("X2").ToLower() + "," + NRT_Temp_NOR_17_24Ch_data.ToString("X2").ToLower() + "," + NRT_Temp_NOR_25_32Ch_data.ToString("X2").ToLower() + "," + NRT_Temp_NOR_33_40Ch_data.ToString("X2").ToLower()); //복수의 문자열 송신을 위한 리스트 박스에 아이템 추가
            }
            else
            {
                MessageBox.Show("NRT40 명령어 선택 오류!!!!!");
            }
        }
    }
}
