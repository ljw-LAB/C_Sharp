using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace NTEC_Firmware_Test_App
{

    public partial class NTEC_Form : Form
    {
        int test_data = 0;
        static int Rx_Str_Cnt;
        static int Tx_Str_Cnt;

        public NTEC_Form()
        {
            InitializeComponent();
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
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

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox29_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox61_CheckedChanged(object sender, EventArgs e)
        {
            if(test_data >= 0 && test_data <= 15)
            { 
                if (checkBox61.Checked)
                {
                    test_data += 1;

                }
                else
                {
                    test_data -= 1;
                }
            }
            textBox3.Text = test_data.ToString("X").ToLower();

        }

        private void checkBox62_CheckedChanged(object sender, EventArgs e)
        {
            if (test_data >= 0 && test_data <= 15)
            {
                if (checkBox62.Checked)
                {
                    test_data += 2;

                }
                else
                {
                    test_data -= 2;
                }
            }
            textBox3.Text = test_data.ToString("X").ToLower();
        }

        private void checkBox63_CheckedChanged(object sender, EventArgs e)
        {
            if (test_data >= 0 && test_data <= 15)
            {
                if (checkBox63.Checked)
                {
                    test_data += 4;

                }
                else
                {
                    test_data -= 4;
                }
            }
            textBox3.Text = test_data.ToString("X").ToLower();
        }

        private void checkBox64_CheckedChanged(object sender, EventArgs e)
        {
            if (test_data >= 0 && test_data <= 15)
            {
                if (checkBox64.Checked)
                {
                    test_data += 8;

                }
                else
                {
                    test_data -= 8;
                }
            }
            textBox3.Text = test_data.ToString("X").ToLower();
        }

        private void checkBox59_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox60_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox57_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox58_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox53_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox54_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox55_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox56_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox51_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox52_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox49_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox50_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox45_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox46_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox47_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox48_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox43_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox44_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox41_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox42_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox37_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox38_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox39_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox40_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox35_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox36_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox33_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox34_CheckedChanged(object sender, EventArgs e)
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
            string item = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss.ffff") +"    "+s+"   "+(s.Count()+1)+"   "+"R"+Rx_Str_Cnt++;
            Serial_TRX_listBox.Items.Add(item);
            Serial_TRX_listBox.SelectedIndex = Serial_TRX_listBox.Items.Count - 1;  // 계속 스크롤이 되도록 처리
        }

        private void Tx_Single_Button_Click(object sender, EventArgs e)
        {
            //텍스트박스의 텍스트를 시리얼통신으로 송신
            serialPort1.Write(Tx_Single_textBox.Text+"\r\n");
            Serial_TRX_listBox.Items.Add(DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss.ffff") + "    " +Tx_Single_textBox.Text + "   " +(Tx_Single_textBox.Text.Count()+2)+ "   " +"T"+Tx_Str_Cnt++);
            Serial_TRX_listBox.SelectedIndex = Serial_TRX_listBox.Items.Count - 1;  // 계속 스크롤이 되도록 처리
        }

        private void listBox2_Clr_Button_Click(object sender, EventArgs e)
        {
            Serial_TRX_listBox.Items.Clear(); // 송, 수신 문자열 관련 리스트박스 화면 클리어(지우기)
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
        }
    }
}
