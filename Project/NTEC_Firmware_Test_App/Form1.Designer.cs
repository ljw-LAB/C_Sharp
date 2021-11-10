﻿namespace NTEC_Firmware_Test_App
{
    partial class NTEC_Form
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
            this.button_Connect = new System.Windows.Forms.Button();
            this.comboBox_Port_Number = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_Port_BaudRate = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_Port_DataBits = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox_Port_Parity = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox_Port_FlowControl = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox_Port_StopBits = new System.Windows.Forms.ComboBox();
            this.button_Reset = new System.Windows.Forms.Button();
            this.button_DbSave = new System.Windows.Forms.Button();
            this.button_DbLoad = new System.Windows.Forms.Button();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.NTEC_TabControl = new System.Windows.Forms.TabControl();
            this.NMC44_TabPage = new System.Windows.Forms.TabPage();
            this.NMC44_FIRE10_Groupbox = new System.Windows.Forms.GroupBox();
            this.FIRE10_Floor_ID_Sel_label = new System.Windows.Forms.Label();
            this.FIRE10_Seperate_Sel_comboBox = new System.Windows.Forms.ComboBox();
            this.FIRE10_Seperate_Sel_label = new System.Windows.Forms.Label();
            this.FIRE10_Gaedan_ID_Sel_label = new System.Windows.Forms.Label();
            this.FIRE10_Operate_Sel_comboBox = new System.Windows.Forms.ComboBox();
            this.FIRE10_Operate_Sel_label = new System.Windows.Forms.Label();
            this.FIRE10_Floor_ID1_Sel_comboBox = new System.Windows.Forms.ComboBox();
            this.FIRE10_Dong_ID10_Sel_comboBox = new System.Windows.Forms.ComboBox();
            this.FIRE10_Dong_ID_Sel_label = new System.Windows.Forms.Label();
            this.FIRE10_Floor_ID10_Sel_comboBox = new System.Windows.Forms.ComboBox();
            this.FIRE10_Dong_ID1_Sel_comboBox = new System.Windows.Forms.ComboBox();
            this.FIRE10_Gaedan_ID10_Sel_comboBox = new System.Windows.Forms.ComboBox();
            this.FIRE10_Gaedan_ID1_Sel_comboBox = new System.Windows.Forms.ComboBox();
            this.NMC44_FIRE12_Groupbox = new System.Windows.Forms.GroupBox();
            this.FIRE12_Floor_ID_Sel_label = new System.Windows.Forms.Label();
            this.FIRE12_Gaedan_ID_Sel_label = new System.Windows.Forms.Label();
            this.FIRE12_Floor_ID1_Sel_comboBox = new System.Windows.Forms.ComboBox();
            this.FIRE12_Floor_ID10_Sel_comboBox = new System.Windows.Forms.ComboBox();
            this.FIRE12_Gaedan_ID1_Sel_comboBox = new System.Windows.Forms.ComboBox();
            this.FIRE12_Gaedan_ID10_Sel_comboBox = new System.Windows.Forms.ComboBox();
            this.FIRE12_Dong_ID1_Sel_comboBox = new System.Windows.Forms.ComboBox();
            this.FIRE12_Dong_ID10_Sel_comboBox = new System.Windows.Forms.ComboBox();
            this.FIRE12_Dong_ID_Sel_label = new System.Windows.Forms.Label();
            this.FIRE12_Operate_Sel_comboBox = new System.Windows.Forms.ComboBox();
            this.FIRE12_Operate_Sel_label = new System.Windows.Forms.Label();
            this.NMC44_FIRP_Groupbox = new System.Windows.Forms.GroupBox();
            this.FIRP_Protocol_Sel_comboBox = new System.Windows.Forms.ComboBox();
            this.label33 = new System.Windows.Forms.Label();
            this.NMC44_EMIC_Groupbox = new System.Windows.Forms.GroupBox();
            this.EMIC_LED_On_Off_comboBox = new System.Windows.Forms.ComboBox();
            this.label40 = new System.Windows.Forms.Label();
            this.NMC44_FIRL_Groupbox = new System.Windows.Forms.GroupBox();
            this.FIRL_LED_On_Off_comboBox = new System.Windows.Forms.ComboBox();
            this.label28 = new System.Windows.Forms.Label();
            this.NMC44_MOT_Groupbox = new System.Windows.Forms.GroupBox();
            this.MOT_Output_Ch_comboBox = new System.Windows.Forms.ComboBox();
            this.MOT_Output_Ch_labellabel = new System.Windows.Forms.Label();
            this.NMC44_GPO_Groupbox = new System.Windows.Forms.GroupBox();
            this.GPO_ON_OFF_comboBox = new System.Windows.Forms.ComboBox();
            this.GPO_ON_OFF_label = new System.Windows.Forms.Label();
            this.GPO_Sel_Ch_comboBox = new System.Windows.Forms.ComboBox();
            this.GPO_Sel_Ch_label = new System.Windows.Forms.Label();
            this.NMC44_BAS_Groupbox = new System.Windows.Forms.GroupBox();
            this.BAS_Vol_Select_comboBox = new System.Windows.Forms.ComboBox();
            this.BAS_Output_Ch_label = new System.Windows.Forms.Label();
            this.BAS_Vol_Select_label = new System.Windows.Forms.Label();
            this.BAS_Output_Ch_comboBox = new System.Windows.Forms.ComboBox();
            this.NMC44_TRB_Groupbox = new System.Windows.Forms.GroupBox();
            this.TRB_Vol_Select_comboBox = new System.Windows.Forms.ComboBox();
            this.TRB_Output_Ch_label = new System.Windows.Forms.Label();
            this.TRB_Vol_Select_label = new System.Windows.Forms.Label();
            this.TRB_Output_Ch_comboBox = new System.Windows.Forms.ComboBox();
            this.NMC44_VOL_Groupbox = new System.Windows.Forms.GroupBox();
            this.VOL_Vol_Select_comboBox = new System.Windows.Forms.ComboBox();
            this.VOL_Output_Ch_label = new System.Windows.Forms.Label();
            this.VOL_Vol_Select_label = new System.Windows.Forms.Label();
            this.VOL_Output_Ch_comboBox = new System.Windows.Forms.ComboBox();
            this.NMC44_MUX_Groupbox = new System.Windows.Forms.GroupBox();
            this.MUX_Ext_Priority_comboBox = new System.Windows.Forms.ComboBox();
            this.MUX_Ext_Priority_label = new System.Windows.Forms.Label();
            this.MUX_Vol_Select_comboBox = new System.Windows.Forms.ComboBox();
            this.MUX_Vol_Select_label = new System.Windows.Forms.Label();
            this.MUX_Ouput_Ch_comboBox = new System.Windows.Forms.ComboBox();
            this.MUX_Input_Ch_comboBox = new System.Windows.Forms.ComboBox();
            this.MUX_Ouput_Ch_label = new System.Windows.Forms.Label();
            this.MUX_Input_Ch_label = new System.Windows.Forms.Label();
            this.NMC44_CMD_Label = new System.Windows.Forms.Label();
            this.NMC44_ID_1_comboBox = new System.Windows.Forms.ComboBox();
            this.NMC44_ID_10_comboBox = new System.Windows.Forms.ComboBox();
            this.NMC_Cmd_comboBox = new System.Windows.Forms.ComboBox();
            this.NMC44_ID_Label = new System.Windows.Forms.Label();
            this.NMC_Insert_Button = new System.Windows.Forms.Button();
            this.NRG16_TabPage = new System.Windows.Forms.TabPage();
            this.NRG16_CMD_Label = new System.Windows.Forms.Label();
            this.NRG16_ID_1_comboBox = new System.Windows.Forms.ComboBox();
            this.NRG16_ID_10_comboBox = new System.Windows.Forms.ComboBox();
            this.NRG_Cmd_comboBox = new System.Windows.Forms.ComboBox();
            this.NRG16_EM_Groupbox = new System.Windows.Forms.GroupBox();
            this.NRG_Ch31_CheckBox = new System.Windows.Forms.CheckBox();
            this.NRG_Ch32_CheckBox = new System.Windows.Forms.CheckBox();
            this.NRG_Ch29_CheckBox = new System.Windows.Forms.CheckBox();
            this.NRG_Ch30_CheckBox = new System.Windows.Forms.CheckBox();
            this.NRG_Ch25_CheckBox = new System.Windows.Forms.CheckBox();
            this.NRG_Ch26_CheckBox = new System.Windows.Forms.CheckBox();
            this.NRG_Ch27_CheckBox = new System.Windows.Forms.CheckBox();
            this.NRG_Ch28_CheckBox = new System.Windows.Forms.CheckBox();
            this.NRG_Ch23_CheckBox = new System.Windows.Forms.CheckBox();
            this.NRG_Ch24_CheckBox = new System.Windows.Forms.CheckBox();
            this.NRG_Ch21_CheckBox = new System.Windows.Forms.CheckBox();
            this.NRG_Ch22_CheckBox = new System.Windows.Forms.CheckBox();
            this.NRG_Ch17_CheckBox = new System.Windows.Forms.CheckBox();
            this.NRG_Ch18_CheckBox = new System.Windows.Forms.CheckBox();
            this.NRG_Ch19_CheckBox = new System.Windows.Forms.CheckBox();
            this.NRG_Ch20_CheckBox = new System.Windows.Forms.CheckBox();
            this.NRG16_Normal_Groupbox = new System.Windows.Forms.GroupBox();
            this.NRG_Ch15_CheckBox = new System.Windows.Forms.CheckBox();
            this.NRG_Ch16_CheckBox = new System.Windows.Forms.CheckBox();
            this.NRG_Ch13_CheckBox = new System.Windows.Forms.CheckBox();
            this.NRG_Ch14_CheckBox = new System.Windows.Forms.CheckBox();
            this.NRG_Ch9_CheckBox = new System.Windows.Forms.CheckBox();
            this.NRG_Ch10_CheckBox = new System.Windows.Forms.CheckBox();
            this.NRG_Ch11_CheckBox = new System.Windows.Forms.CheckBox();
            this.NRG_Ch12_CheckBox = new System.Windows.Forms.CheckBox();
            this.NRG_Ch7_CheckBox = new System.Windows.Forms.CheckBox();
            this.NRG_Ch8_CheckBox = new System.Windows.Forms.CheckBox();
            this.NRG_Ch5_CheckBox = new System.Windows.Forms.CheckBox();
            this.NRG_Ch6_CheckBox = new System.Windows.Forms.CheckBox();
            this.NRG_Ch1_CheckBox = new System.Windows.Forms.CheckBox();
            this.NRG_Ch2_CheckBox = new System.Windows.Forms.CheckBox();
            this.NRG_Ch3_CheckBox = new System.Windows.Forms.CheckBox();
            this.NRG_Ch4_CheckBox = new System.Windows.Forms.CheckBox();
            this.NRG16_ID_Label = new System.Windows.Forms.Label();
            this.NRG_Insert_Button = new System.Windows.Forms.Button();
            this.NRT16_TabPage = new System.Windows.Forms.TabPage();
            this.NRT16_CMD_Label = new System.Windows.Forms.Label();
            this.NRT16_ID_1_comboBox = new System.Windows.Forms.ComboBox();
            this.NRT16_ID_10_comboBox = new System.Windows.Forms.ComboBox();
            this.NDT_Cmd_comboBox = new System.Windows.Forms.ComboBox();
            this.NDT_Insert_Button = new System.Windows.Forms.Button();
            this.NRT16_ID_Label = new System.Windows.Forms.Label();
            this.NRT16_EM_Groupbox = new System.Windows.Forms.GroupBox();
            this.NDT_Ch31_CheckBox = new System.Windows.Forms.CheckBox();
            this.NDT_Ch32_CheckBox = new System.Windows.Forms.CheckBox();
            this.NDT_Ch29_CheckBox = new System.Windows.Forms.CheckBox();
            this.NDT_Ch30_CheckBox = new System.Windows.Forms.CheckBox();
            this.NDT_Ch25_CheckBox = new System.Windows.Forms.CheckBox();
            this.NDT_Ch26_CheckBox = new System.Windows.Forms.CheckBox();
            this.NDT_Ch27_CheckBox = new System.Windows.Forms.CheckBox();
            this.NDT_Ch28_CheckBox = new System.Windows.Forms.CheckBox();
            this.NDT_Ch23_CheckBox = new System.Windows.Forms.CheckBox();
            this.NDT_Ch24_CheckBox = new System.Windows.Forms.CheckBox();
            this.NDT_Ch21_CheckBox = new System.Windows.Forms.CheckBox();
            this.NDT_Ch22_CheckBox = new System.Windows.Forms.CheckBox();
            this.NDT_Ch17_CheckBox = new System.Windows.Forms.CheckBox();
            this.NDT_Ch18_CheckBox = new System.Windows.Forms.CheckBox();
            this.NDT_Ch19_CheckBox = new System.Windows.Forms.CheckBox();
            this.NDT_Ch20_CheckBox = new System.Windows.Forms.CheckBox();
            this.NRT16_Normal_Groupbox = new System.Windows.Forms.GroupBox();
            this.NDT_Ch15_CheckBox = new System.Windows.Forms.CheckBox();
            this.NDT_Ch16_CheckBox = new System.Windows.Forms.CheckBox();
            this.NDT_Ch13_CheckBox = new System.Windows.Forms.CheckBox();
            this.NDT_Ch14_CheckBox = new System.Windows.Forms.CheckBox();
            this.NDT_Ch9_CheckBox = new System.Windows.Forms.CheckBox();
            this.NDT_Ch10_CheckBox = new System.Windows.Forms.CheckBox();
            this.NDT_Ch11_CheckBox = new System.Windows.Forms.CheckBox();
            this.NDT_Ch12_CheckBox = new System.Windows.Forms.CheckBox();
            this.NDT_Ch7_CheckBox = new System.Windows.Forms.CheckBox();
            this.NDT_Ch8_CheckBox = new System.Windows.Forms.CheckBox();
            this.NDT_Ch5_CheckBox = new System.Windows.Forms.CheckBox();
            this.NDT_Ch6_CheckBox = new System.Windows.Forms.CheckBox();
            this.NDT_Ch1_CheckBox = new System.Windows.Forms.CheckBox();
            this.NDT_Ch2_CheckBox = new System.Windows.Forms.CheckBox();
            this.NDT_Ch3_CheckBox = new System.Windows.Forms.CheckBox();
            this.NDT_Ch4_CheckBox = new System.Windows.Forms.CheckBox();
            this.NRT40_TabPage = new System.Windows.Forms.TabPage();
            this.NRT40_CMD_Label = new System.Windows.Forms.Label();
            this.NRT40_ID_1_comboBox = new System.Windows.Forms.ComboBox();
            this.NRT_Cmd_comboBox = new System.Windows.Forms.ComboBox();
            this.NRT40_ID_10_comboBox = new System.Windows.Forms.ComboBox();
            this.NRT_Insert_Button = new System.Windows.Forms.Button();
            this.NRT40_ID_Label = new System.Windows.Forms.Label();
            this.NRT40_Normal_Groupbox = new System.Windows.Forms.GroupBox();
            this.NRT_Ch39_CheckBox = new System.Windows.Forms.CheckBox();
            this.NRT_Ch40_CheckBox = new System.Windows.Forms.CheckBox();
            this.NRT_Ch37_CheckBox = new System.Windows.Forms.CheckBox();
            this.NRT_Ch38_CheckBox = new System.Windows.Forms.CheckBox();
            this.NRT_Ch33_CheckBox = new System.Windows.Forms.CheckBox();
            this.NRT_Ch34_CheckBox = new System.Windows.Forms.CheckBox();
            this.NRT_Ch35_CheckBox = new System.Windows.Forms.CheckBox();
            this.NRT_Ch36_CheckBox = new System.Windows.Forms.CheckBox();
            this.NRT_Ch31_CheckBox = new System.Windows.Forms.CheckBox();
            this.NRT_Ch32_CheckBox = new System.Windows.Forms.CheckBox();
            this.NRT_Ch29_CheckBox = new System.Windows.Forms.CheckBox();
            this.NRT_Ch30_CheckBox = new System.Windows.Forms.CheckBox();
            this.NRT_Ch25_CheckBox = new System.Windows.Forms.CheckBox();
            this.NRT_Ch26_CheckBox = new System.Windows.Forms.CheckBox();
            this.NRT_Ch27_CheckBox = new System.Windows.Forms.CheckBox();
            this.NRT_Ch28_CheckBox = new System.Windows.Forms.CheckBox();
            this.NRT_Ch23_CheckBox = new System.Windows.Forms.CheckBox();
            this.NRT_Ch24_CheckBox = new System.Windows.Forms.CheckBox();
            this.NRT_Ch21_CheckBox = new System.Windows.Forms.CheckBox();
            this.NRT_Ch22_CheckBox = new System.Windows.Forms.CheckBox();
            this.NRT_Ch17_CheckBox = new System.Windows.Forms.CheckBox();
            this.NRT_Ch18_CheckBox = new System.Windows.Forms.CheckBox();
            this.NRT_Ch19_CheckBox = new System.Windows.Forms.CheckBox();
            this.NRT_Ch20_CheckBox = new System.Windows.Forms.CheckBox();
            this.NRT_Ch15_CheckBox = new System.Windows.Forms.CheckBox();
            this.NRT_Ch16_CheckBox = new System.Windows.Forms.CheckBox();
            this.NRT_Ch13_CheckBox = new System.Windows.Forms.CheckBox();
            this.NRT_Ch14_CheckBox = new System.Windows.Forms.CheckBox();
            this.NRT_Ch9_CheckBox = new System.Windows.Forms.CheckBox();
            this.NRT_Ch10_CheckBox = new System.Windows.Forms.CheckBox();
            this.NRT_Ch11_CheckBox = new System.Windows.Forms.CheckBox();
            this.NRT_Ch12_CheckBox = new System.Windows.Forms.CheckBox();
            this.NRT_Ch7_CheckBox = new System.Windows.Forms.CheckBox();
            this.NRT_Ch8_CheckBox = new System.Windows.Forms.CheckBox();
            this.NRT_Ch5_CheckBox = new System.Windows.Forms.CheckBox();
            this.NRT_Ch6_CheckBox = new System.Windows.Forms.CheckBox();
            this.NRT_Ch1_CheckBox = new System.Windows.Forms.CheckBox();
            this.NRT_Ch2_CheckBox = new System.Windows.Forms.CheckBox();
            this.NRT_Ch3_CheckBox = new System.Windows.Forms.CheckBox();
            this.NRT_Ch4_CheckBox = new System.Windows.Forms.CheckBox();
            this.MPR_TabPage = new System.Windows.Forms.TabPage();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.MPR_Insert_Button = new System.Windows.Forms.Button();
            this.MPR_Auto_Manual_Groupbox = new System.Windows.Forms.GroupBox();
            this.MPR_Auto_RadioButton = new System.Windows.Forms.RadioButton();
            this.MPR_Manual_RadioButton = new System.Windows.Forms.RadioButton();
            this.MPR_POWER_ON_OFF_Groupbox = new System.Windows.Forms.GroupBox();
            this.MPR_POWER_ON_OFF_button = new System.Windows.Forms.Button();
            this.radioButton16 = new System.Windows.Forms.RadioButton();
            this.radioButton17 = new System.Windows.Forms.RadioButton();
            this.radioButton18 = new System.Windows.Forms.RadioButton();
            this.MPR_CD_Track_Groupbox = new System.Windows.Forms.GroupBox();
            this.MPR_CD_Track_button = new System.Windows.Forms.Button();
            this.radioButton14 = new System.Windows.Forms.RadioButton();
            this.radioButton11 = new System.Windows.Forms.RadioButton();
            this.radioButton12 = new System.Windows.Forms.RadioButton();
            this.radioButton13 = new System.Windows.Forms.RadioButton();
            this.MPR_CD_Volume_Groupbox = new System.Windows.Forms.GroupBox();
            this.MPR_CD_Volume_button = new System.Windows.Forms.Button();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.MPR_CD_Control_Groupbox = new System.Windows.Forms.GroupBox();
            this.MPR_CD_Control_button = new System.Windows.Forms.Button();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton9 = new System.Windows.Forms.RadioButton();
            this.radioButton10 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.MPR_Cmd_comboBox = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.NCS01_TabPage = new System.Windows.Forms.TabPage();
            this.NCS_Insert_Button = new System.Windows.Forms.Button();
            this.NCS01_CMD_Label = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.checkBox145 = new System.Windows.Forms.CheckBox();
            this.checkBox146 = new System.Windows.Forms.CheckBox();
            this.checkBox147 = new System.Windows.Forms.CheckBox();
            this.checkBox148 = new System.Windows.Forms.CheckBox();
            this.checkBox149 = new System.Windows.Forms.CheckBox();
            this.checkBox150 = new System.Windows.Forms.CheckBox();
            this.checkBox151 = new System.Windows.Forms.CheckBox();
            this.checkBox152 = new System.Windows.Forms.CheckBox();
            this.checkBox153 = new System.Windows.Forms.CheckBox();
            this.checkBox154 = new System.Windows.Forms.CheckBox();
            this.checkBox155 = new System.Windows.Forms.CheckBox();
            this.checkBox156 = new System.Windows.Forms.CheckBox();
            this.checkBox157 = new System.Windows.Forms.CheckBox();
            this.checkBox158 = new System.Windows.Forms.CheckBox();
            this.checkBox159 = new System.Windows.Forms.CheckBox();
            this.checkBox160 = new System.Windows.Forms.CheckBox();
            this.checkBox161 = new System.Windows.Forms.CheckBox();
            this.checkBox162 = new System.Windows.Forms.CheckBox();
            this.checkBox163 = new System.Windows.Forms.CheckBox();
            this.checkBox164 = new System.Windows.Forms.CheckBox();
            this.checkBox165 = new System.Windows.Forms.CheckBox();
            this.checkBox166 = new System.Windows.Forms.CheckBox();
            this.checkBox167 = new System.Windows.Forms.CheckBox();
            this.checkBox168 = new System.Windows.Forms.CheckBox();
            this.checkBox169 = new System.Windows.Forms.CheckBox();
            this.checkBox170 = new System.Windows.Forms.CheckBox();
            this.checkBox171 = new System.Windows.Forms.CheckBox();
            this.checkBox172 = new System.Windows.Forms.CheckBox();
            this.checkBox173 = new System.Windows.Forms.CheckBox();
            this.checkBox174 = new System.Windows.Forms.CheckBox();
            this.checkBox175 = new System.Windows.Forms.CheckBox();
            this.checkBox176 = new System.Windows.Forms.CheckBox();
            this.checkBox177 = new System.Windows.Forms.CheckBox();
            this.checkBox178 = new System.Windows.Forms.CheckBox();
            this.checkBox179 = new System.Windows.Forms.CheckBox();
            this.checkBox180 = new System.Windows.Forms.CheckBox();
            this.checkBox181 = new System.Windows.Forms.CheckBox();
            this.checkBox182 = new System.Windows.Forms.CheckBox();
            this.checkBox183 = new System.Windows.Forms.CheckBox();
            this.checkBox184 = new System.Windows.Forms.CheckBox();
            this.NCS01_ID_1_comboBox = new System.Windows.Forms.ComboBox();
            this.NCS01_ID_10_comboBox = new System.Windows.Forms.ComboBox();
            this.NCS01_ID_Label = new System.Windows.Forms.Label();
            this.NCS_Cmd_comboBox = new System.Windows.Forms.ComboBox();
            this.NEI42_TabPage = new System.Windows.Forms.TabPage();
            this.NEI42_CMD_Label = new System.Windows.Forms.Label();
            this.NEI42_ID_1_comboBox = new System.Windows.Forms.ComboBox();
            this.NEI42_ID_Label = new System.Windows.Forms.Label();
            this.NEI42_ID_10_comboBox = new System.Windows.Forms.ComboBox();
            this.NEI42_Cmd_comboBox = new System.Windows.Forms.ComboBox();
            this.NEI_Insert_Button = new System.Windows.Forms.Button();
            this.NEI42_GPIN_Total_GroupBox = new System.Windows.Forms.GroupBox();
            this.NEI42_GPIN3_GroupBox = new System.Windows.Forms.GroupBox();
            this.NEI_Ch41_CheckBox = new System.Windows.Forms.CheckBox();
            this.NEI_Ch29_CheckBox = new System.Windows.Forms.CheckBox();
            this.NEI_Ch42_CheckBox = new System.Windows.Forms.CheckBox();
            this.NEI_Ch33_CheckBox = new System.Windows.Forms.CheckBox();
            this.NEI_Ch37_CheckBox = new System.Windows.Forms.CheckBox();
            this.NEI_Ch34_CheckBox = new System.Windows.Forms.CheckBox();
            this.NEI_Ch38_CheckBox = new System.Windows.Forms.CheckBox();
            this.NEI_Ch36_CheckBox = new System.Windows.Forms.CheckBox();
            this.NEI_Ch30_CheckBox = new System.Windows.Forms.CheckBox();
            this.NEI_Ch39_CheckBox = new System.Windows.Forms.CheckBox();
            this.NEI_Ch35_CheckBox = new System.Windows.Forms.CheckBox();
            this.NEI_Ch32_CheckBox = new System.Windows.Forms.CheckBox();
            this.NEI_Ch31_CheckBox = new System.Windows.Forms.CheckBox();
            this.NEI_Ch40_CheckBox = new System.Windows.Forms.CheckBox();
            this.NEI42_GPIN2_GroupBox = new System.Windows.Forms.GroupBox();
            this.NEI_Ch27_CheckBox = new System.Windows.Forms.CheckBox();
            this.NEI_Ch15_CheckBox = new System.Windows.Forms.CheckBox();
            this.NEI_Ch28_CheckBox = new System.Windows.Forms.CheckBox();
            this.NEI_Ch19_CheckBox = new System.Windows.Forms.CheckBox();
            this.NEI_Ch23_CheckBox = new System.Windows.Forms.CheckBox();
            this.NEI_Ch20_CheckBox = new System.Windows.Forms.CheckBox();
            this.NEI_Ch24_CheckBox = new System.Windows.Forms.CheckBox();
            this.NEI_Ch22_CheckBox = new System.Windows.Forms.CheckBox();
            this.NEI_Ch16_CheckBox = new System.Windows.Forms.CheckBox();
            this.NEI_Ch25_CheckBox = new System.Windows.Forms.CheckBox();
            this.NEI_Ch21_CheckBox = new System.Windows.Forms.CheckBox();
            this.NEI_Ch18_CheckBox = new System.Windows.Forms.CheckBox();
            this.NEI_Ch17_CheckBox = new System.Windows.Forms.CheckBox();
            this.NEI_Ch26_CheckBox = new System.Windows.Forms.CheckBox();
            this.NEI42_GPIN1_GroupBox = new System.Windows.Forms.GroupBox();
            this.NEI_Ch13_CheckBox = new System.Windows.Forms.CheckBox();
            this.NEI_Ch1_CheckBox = new System.Windows.Forms.CheckBox();
            this.NEI_Ch14_CheckBox = new System.Windows.Forms.CheckBox();
            this.NEI_Ch5_CheckBox = new System.Windows.Forms.CheckBox();
            this.NEI_Ch9_CheckBox = new System.Windows.Forms.CheckBox();
            this.NEI_Ch6_CheckBox = new System.Windows.Forms.CheckBox();
            this.NEI_Ch10_CheckBox = new System.Windows.Forms.CheckBox();
            this.NEI_Ch8_CheckBox = new System.Windows.Forms.CheckBox();
            this.NEI_Ch2_CheckBox = new System.Windows.Forms.CheckBox();
            this.NEI_Ch11_CheckBox = new System.Windows.Forms.CheckBox();
            this.NEI_Ch7_CheckBox = new System.Windows.Forms.CheckBox();
            this.NEI_Ch4_CheckBox = new System.Windows.Forms.CheckBox();
            this.NEI_Ch3_CheckBox = new System.Windows.Forms.CheckBox();
            this.NEI_Ch12_CheckBox = new System.Windows.Forms.CheckBox();
            this.Fire_TabPage = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.Auto_RadioButton = new System.Windows.Forms.RadioButton();
            this.Manual_RadioButton = new System.Windows.Forms.RadioButton();
            this.Fire_Insert_Button = new System.Windows.Forms.Button();
            this.Fire12Byte_Total_GroupBox = new System.Windows.Forms.GroupBox();
            this.FIRE12Byte_Operate_Label = new System.Windows.Forms.Label();
            this.Fire12Byte_Reset_Button = new System.Windows.Forms.Button();
            this.FIRE12Byte_Operate_ConboBox = new System.Windows.Forms.ComboBox();
            this.label22 = new System.Windows.Forms.Label();
            this.Fire12Byte_Audio_Stop_Button = new System.Windows.Forms.Button();
            this.FIRE12Byte_Floor_ID_Label = new System.Windows.Forms.Label();
            this.Fire12Byte_Audio_Start_Button = new System.Windows.Forms.Button();
            this.FIRE12Byte_Dong_ID_10_ConboBox = new System.Windows.Forms.ComboBox();
            this.Fire12Byte_Stop_Button = new System.Windows.Forms.Button();
            this.FIRE12Byte_Gaedan_ID_Label = new System.Windows.Forms.Label();
            this.Fire12Byte_Start_Button = new System.Windows.Forms.Button();
            this.FIRE12Byte_Dong_ID_1_ConboBox = new System.Windows.Forms.ComboBox();
            this.FIRE12Byte_Dong_ID_Label = new System.Windows.Forms.Label();
            this.FIRE12Byte_Floor_ID_10_ConboBox = new System.Windows.Forms.ComboBox();
            this.label21 = new System.Windows.Forms.Label();
            this.FIRE12Byte_Floor_ID_1_ConboBox = new System.Windows.Forms.ComboBox();
            this.FIRE12Byte_Gaedan_ID_1_ConboBox = new System.Windows.Forms.ComboBox();
            this.FIRE12Byte_Gaedan_ID_10_ConboBox = new System.Windows.Forms.ComboBox();
            this.Fire10Byte_Total_GroupBox = new System.Windows.Forms.GroupBox();
            this.FIRE10Byte_Operate_Label = new System.Windows.Forms.Label();
            this.FIRE10Byte_Operate_ConboBox = new System.Windows.Forms.ComboBox();
            this.Fire10Byte_Reset_Button = new System.Windows.Forms.Button();
            this.Fire10Byte_Audio_Stop_Button = new System.Windows.Forms.Button();
            this.Fire10Byte_Audio_Start_Button = new System.Windows.Forms.Button();
            this.Fire10Byte_Stop_Button = new System.Windows.Forms.Button();
            this.FIRE10Byte_Seperate_ID_Label = new System.Windows.Forms.Label();
            this.Fire10Byte_Start_Button = new System.Windows.Forms.Button();
            this.FIRE10Byte_Floor_ID_Label = new System.Windows.Forms.Label();
            this.FIRE10Byte_Gaedan_ID_Label = new System.Windows.Forms.Label();
            this.FIRE10Byte_Dong_ID_Label = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.FIRE10Byte_Gaedan_ID_1_ConboBox = new System.Windows.Forms.ComboBox();
            this.FIRE10Byte_Seperate_ID_ConboBox = new System.Windows.Forms.ComboBox();
            this.FIRE10Byte_Floor_ID_1_ConboBox = new System.Windows.Forms.ComboBox();
            this.FIRE10Byte_Floor_ID_10_ConboBox = new System.Windows.Forms.ComboBox();
            this.FIRE10Byte_Dong_ID_1_ConboBox = new System.Windows.Forms.ComboBox();
            this.FIRE10Byte_Dong_ID_10_ConboBox = new System.Windows.Forms.ComboBox();
            this.Fire_Select_GroupBox = new System.Windows.Forms.GroupBox();
            this.Fire12Byte_Select_RadioButton = new System.Windows.Forms.RadioButton();
            this.Fire10Byte_Select_RadioButton = new System.Windows.Forms.RadioButton();
            this.Tx_Str_listBox = new System.Windows.Forms.ListBox();
            this.Tx_Single_textBox = new System.Windows.Forms.TextBox();
            this.Tx_One_button = new System.Windows.Forms.Button();
            this.Delay_textBox = new System.Windows.Forms.TextBox();
            this.Tx_Multi_button = new System.Windows.Forms.Button();
            this.Tx_Single_Button = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.Tx_Str_Insert_Button = new System.Windows.Forms.Button();
            this.Tx_Str_Delete_Button = new System.Windows.Forms.Button();
            this.Monitoring_listBox = new System.Windows.Forms.ListBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.Monitoring_listBox_Clr_Button = new System.Windows.Forms.Button();
            this.Serial_Time_label = new System.Windows.Forms.Label();
            this.Data_Str_label = new System.Windows.Forms.Label();
            this.Length_label = new System.Windows.Forms.Label();
            this.TRx_label = new System.Windows.Forms.Label();
            this.Multi_Stop_button = new System.Windows.Forms.Button();
            this.Hex_con_Monitoring_listBox_checkBox2 = new System.Windows.Forms.CheckBox();
            this.Fire_Data_Received_checkBox = new System.Windows.Forms.CheckBox();
            this.TxTSave_Button = new System.Windows.Forms.Button();
            this.TxTLoad_Cmd_Button = new System.Windows.Forms.Button();
            this.TxTSave_Cmd_Button = new System.Windows.Forms.Button();
            this.Tx_Str_listBox_Clr_Button = new System.Windows.Forms.Button();
            this.NRG16_Clr_Button = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.NTEC_TabControl.SuspendLayout();
            this.NMC44_TabPage.SuspendLayout();
            this.NMC44_FIRE10_Groupbox.SuspendLayout();
            this.NMC44_FIRE12_Groupbox.SuspendLayout();
            this.NMC44_FIRP_Groupbox.SuspendLayout();
            this.NMC44_EMIC_Groupbox.SuspendLayout();
            this.NMC44_FIRL_Groupbox.SuspendLayout();
            this.NMC44_MOT_Groupbox.SuspendLayout();
            this.NMC44_GPO_Groupbox.SuspendLayout();
            this.NMC44_BAS_Groupbox.SuspendLayout();
            this.NMC44_TRB_Groupbox.SuspendLayout();
            this.NMC44_VOL_Groupbox.SuspendLayout();
            this.NMC44_MUX_Groupbox.SuspendLayout();
            this.NRG16_TabPage.SuspendLayout();
            this.NRG16_EM_Groupbox.SuspendLayout();
            this.NRG16_Normal_Groupbox.SuspendLayout();
            this.NRT16_TabPage.SuspendLayout();
            this.NRT16_EM_Groupbox.SuspendLayout();
            this.NRT16_Normal_Groupbox.SuspendLayout();
            this.NRT40_TabPage.SuspendLayout();
            this.NRT40_Normal_Groupbox.SuspendLayout();
            this.MPR_TabPage.SuspendLayout();
            this.MPR_Auto_Manual_Groupbox.SuspendLayout();
            this.MPR_POWER_ON_OFF_Groupbox.SuspendLayout();
            this.MPR_CD_Track_Groupbox.SuspendLayout();
            this.MPR_CD_Volume_Groupbox.SuspendLayout();
            this.MPR_CD_Control_Groupbox.SuspendLayout();
            this.NCS01_TabPage.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.NEI42_TabPage.SuspendLayout();
            this.NEI42_GPIN_Total_GroupBox.SuspendLayout();
            this.NEI42_GPIN3_GroupBox.SuspendLayout();
            this.NEI42_GPIN2_GroupBox.SuspendLayout();
            this.NEI42_GPIN1_GroupBox.SuspendLayout();
            this.Fire_TabPage.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.Fire12Byte_Total_GroupBox.SuspendLayout();
            this.Fire10Byte_Total_GroupBox.SuspendLayout();
            this.Fire_Select_GroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_Connect
            // 
            this.button_Connect.Location = new System.Drawing.Point(12, 194);
            this.button_Connect.Name = "button_Connect";
            this.button_Connect.Size = new System.Drawing.Size(213, 46);
            this.button_Connect.TabIndex = 0;
            this.button_Connect.Text = "연결하기";
            this.button_Connect.UseVisualStyleBackColor = true;
            this.button_Connect.Click += new System.EventHandler(this.button_Connect_Click);
            // 
            // comboBox_Port_Number
            // 
            this.comboBox_Port_Number.FormattingEnabled = true;
            this.comboBox_Port_Number.Location = new System.Drawing.Point(104, 20);
            this.comboBox_Port_Number.Name = "comboBox_Port_Number";
            this.comboBox_Port_Number.Size = new System.Drawing.Size(121, 20);
            this.comboBox_Port_Number.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(10, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "Com Port";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(10, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "Baud Rate";
            // 
            // comboBox_Port_BaudRate
            // 
            this.comboBox_Port_BaudRate.FormattingEnabled = true;
            this.comboBox_Port_BaudRate.Items.AddRange(new object[] {
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "38400",
            "56000",
            "57600",
            "115200"});
            this.comboBox_Port_BaudRate.Location = new System.Drawing.Point(104, 46);
            this.comboBox_Port_BaudRate.Name = "comboBox_Port_BaudRate";
            this.comboBox_Port_BaudRate.Size = new System.Drawing.Size(121, 20);
            this.comboBox_Port_BaudRate.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(10, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "Data Bits";
            // 
            // comboBox_Port_DataBits
            // 
            this.comboBox_Port_DataBits.FormattingEnabled = true;
            this.comboBox_Port_DataBits.Items.AddRange(new object[] {
            "8"});
            this.comboBox_Port_DataBits.Location = new System.Drawing.Point(104, 72);
            this.comboBox_Port_DataBits.Name = "comboBox_Port_DataBits";
            this.comboBox_Port_DataBits.Size = new System.Drawing.Size(121, 20);
            this.comboBox_Port_DataBits.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(10, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "Parity";
            // 
            // comboBox_Port_Parity
            // 
            this.comboBox_Port_Parity.FormattingEnabled = true;
            this.comboBox_Port_Parity.Items.AddRange(new object[] {
            "None",
            "Even",
            "Odd",
            "Mark"});
            this.comboBox_Port_Parity.Location = new System.Drawing.Point(104, 98);
            this.comboBox_Port_Parity.Name = "comboBox_Port_Parity";
            this.comboBox_Port_Parity.Size = new System.Drawing.Size(121, 20);
            this.comboBox_Port_Parity.TabIndex = 7;
            this.comboBox_Port_Parity.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(10, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 12);
            this.label5.TabIndex = 12;
            this.label5.Text = "Flow Control";
            // 
            // comboBox_Port_FlowControl
            // 
            this.comboBox_Port_FlowControl.FormattingEnabled = true;
            this.comboBox_Port_FlowControl.Items.AddRange(new object[] {
            "None",
            "XOnXOff",
            "RequestToSend"});
            this.comboBox_Port_FlowControl.Location = new System.Drawing.Point(104, 150);
            this.comboBox_Port_FlowControl.Name = "comboBox_Port_FlowControl";
            this.comboBox_Port_FlowControl.Size = new System.Drawing.Size(121, 20);
            this.comboBox_Port_FlowControl.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(10, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 12);
            this.label6.TabIndex = 10;
            this.label6.Text = "Stop Bits";
            // 
            // comboBox_Port_StopBits
            // 
            this.comboBox_Port_StopBits.FormattingEnabled = true;
            this.comboBox_Port_StopBits.Items.AddRange(new object[] {
            "1"});
            this.comboBox_Port_StopBits.Location = new System.Drawing.Point(104, 124);
            this.comboBox_Port_StopBits.Name = "comboBox_Port_StopBits";
            this.comboBox_Port_StopBits.Size = new System.Drawing.Size(121, 20);
            this.comboBox_Port_StopBits.TabIndex = 9;
            // 
            // button_Reset
            // 
            this.button_Reset.Location = new System.Drawing.Point(12, 246);
            this.button_Reset.Name = "button_Reset";
            this.button_Reset.Size = new System.Drawing.Size(213, 46);
            this.button_Reset.TabIndex = 13;
            this.button_Reset.Text = "초기화";
            this.button_Reset.UseVisualStyleBackColor = true;
            this.button_Reset.Click += new System.EventHandler(this.button_Reset_Click);
            // 
            // button_DbSave
            // 
            this.button_DbSave.Location = new System.Drawing.Point(12, 298);
            this.button_DbSave.Name = "button_DbSave";
            this.button_DbSave.Size = new System.Drawing.Size(213, 46);
            this.button_DbSave.TabIndex = 14;
            this.button_DbSave.Text = "DB 저장하기";
            this.button_DbSave.UseVisualStyleBackColor = true;
            // 
            // button_DbLoad
            // 
            this.button_DbLoad.Location = new System.Drawing.Point(12, 350);
            this.button_DbLoad.Name = "button_DbLoad";
            this.button_DbLoad.Size = new System.Drawing.Size(213, 46);
            this.button_DbLoad.TabIndex = 15;
            this.button_DbLoad.Text = "DB 불러오기";
            this.button_DbLoad.UseVisualStyleBackColor = true;
            // 
            // NTEC_TabControl
            // 
            this.NTEC_TabControl.Controls.Add(this.NMC44_TabPage);
            this.NTEC_TabControl.Controls.Add(this.NRG16_TabPage);
            this.NTEC_TabControl.Controls.Add(this.NRT16_TabPage);
            this.NTEC_TabControl.Controls.Add(this.NRT40_TabPage);
            this.NTEC_TabControl.Controls.Add(this.MPR_TabPage);
            this.NTEC_TabControl.Controls.Add(this.NCS01_TabPage);
            this.NTEC_TabControl.Controls.Add(this.NEI42_TabPage);
            this.NTEC_TabControl.Controls.Add(this.Fire_TabPage);
            this.NTEC_TabControl.Location = new System.Drawing.Point(231, 20);
            this.NTEC_TabControl.Name = "NTEC_TabControl";
            this.NTEC_TabControl.SelectedIndex = 0;
            this.NTEC_TabControl.Size = new System.Drawing.Size(492, 651);
            this.NTEC_TabControl.TabIndex = 16;
            // 
            // NMC44_TabPage
            // 
            this.NMC44_TabPage.Controls.Add(this.NMC44_FIRE10_Groupbox);
            this.NMC44_TabPage.Controls.Add(this.NMC44_FIRE12_Groupbox);
            this.NMC44_TabPage.Controls.Add(this.NMC44_FIRP_Groupbox);
            this.NMC44_TabPage.Controls.Add(this.NMC44_EMIC_Groupbox);
            this.NMC44_TabPage.Controls.Add(this.NMC44_FIRL_Groupbox);
            this.NMC44_TabPage.Controls.Add(this.NMC44_MOT_Groupbox);
            this.NMC44_TabPage.Controls.Add(this.NMC44_GPO_Groupbox);
            this.NMC44_TabPage.Controls.Add(this.NMC44_BAS_Groupbox);
            this.NMC44_TabPage.Controls.Add(this.NMC44_TRB_Groupbox);
            this.NMC44_TabPage.Controls.Add(this.NMC44_VOL_Groupbox);
            this.NMC44_TabPage.Controls.Add(this.NMC44_MUX_Groupbox);
            this.NMC44_TabPage.Controls.Add(this.NMC44_CMD_Label);
            this.NMC44_TabPage.Controls.Add(this.NMC44_ID_1_comboBox);
            this.NMC44_TabPage.Controls.Add(this.NMC44_ID_10_comboBox);
            this.NMC44_TabPage.Controls.Add(this.NMC_Cmd_comboBox);
            this.NMC44_TabPage.Controls.Add(this.NMC44_ID_Label);
            this.NMC44_TabPage.Controls.Add(this.NMC_Insert_Button);
            this.NMC44_TabPage.Location = new System.Drawing.Point(4, 22);
            this.NMC44_TabPage.Name = "NMC44_TabPage";
            this.NMC44_TabPage.Padding = new System.Windows.Forms.Padding(3);
            this.NMC44_TabPage.Size = new System.Drawing.Size(484, 625);
            this.NMC44_TabPage.TabIndex = 10;
            this.NMC44_TabPage.Text = "NMC44";
            this.NMC44_TabPage.UseVisualStyleBackColor = true;
            // 
            // NMC44_FIRE10_Groupbox
            // 
            this.NMC44_FIRE10_Groupbox.Controls.Add(this.FIRE10_Floor_ID_Sel_label);
            this.NMC44_FIRE10_Groupbox.Controls.Add(this.FIRE10_Seperate_Sel_comboBox);
            this.NMC44_FIRE10_Groupbox.Controls.Add(this.FIRE10_Seperate_Sel_label);
            this.NMC44_FIRE10_Groupbox.Controls.Add(this.FIRE10_Gaedan_ID_Sel_label);
            this.NMC44_FIRE10_Groupbox.Controls.Add(this.FIRE10_Operate_Sel_comboBox);
            this.NMC44_FIRE10_Groupbox.Controls.Add(this.FIRE10_Operate_Sel_label);
            this.NMC44_FIRE10_Groupbox.Controls.Add(this.FIRE10_Floor_ID1_Sel_comboBox);
            this.NMC44_FIRE10_Groupbox.Controls.Add(this.FIRE10_Dong_ID10_Sel_comboBox);
            this.NMC44_FIRE10_Groupbox.Controls.Add(this.FIRE10_Dong_ID_Sel_label);
            this.NMC44_FIRE10_Groupbox.Controls.Add(this.FIRE10_Floor_ID10_Sel_comboBox);
            this.NMC44_FIRE10_Groupbox.Controls.Add(this.FIRE10_Dong_ID1_Sel_comboBox);
            this.NMC44_FIRE10_Groupbox.Controls.Add(this.FIRE10_Gaedan_ID10_Sel_comboBox);
            this.NMC44_FIRE10_Groupbox.Controls.Add(this.FIRE10_Gaedan_ID1_Sel_comboBox);
            this.NMC44_FIRE10_Groupbox.Location = new System.Drawing.Point(7, 474);
            this.NMC44_FIRE10_Groupbox.Name = "NMC44_FIRE10_Groupbox";
            this.NMC44_FIRE10_Groupbox.Size = new System.Drawing.Size(471, 83);
            this.NMC44_FIRE10_Groupbox.TabIndex = 67;
            this.NMC44_FIRE10_Groupbox.TabStop = false;
            this.NMC44_FIRE10_Groupbox.Text = "소방 10Byte 수신 시, 제어(FIRE)";
            // 
            // FIRE10_Floor_ID_Sel_label
            // 
            this.FIRE10_Floor_ID_Sel_label.AutoSize = true;
            this.FIRE10_Floor_ID_Sel_label.Location = new System.Drawing.Point(390, 24);
            this.FIRE10_Floor_ID_Sel_label.Name = "FIRE10_Floor_ID_Sel_label";
            this.FIRE10_Floor_ID_Sel_label.Size = new System.Drawing.Size(65, 12);
            this.FIRE10_Floor_ID_Sel_label.TabIndex = 66;
            this.FIRE10_Floor_ID_Sel_label.Text = "층(십 / 일)";
            // 
            // FIRE10_Seperate_Sel_comboBox
            // 
            this.FIRE10_Seperate_Sel_comboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.FIRE10_Seperate_Sel_comboBox.FormattingEnabled = true;
            this.FIRE10_Seperate_Sel_comboBox.Items.AddRange(new object[] {
            "F(지상층)",
            "B(지하층)",
            "P(옥탑층)",
            "K(주차장)"});
            this.FIRE10_Seperate_Sel_comboBox.Location = new System.Drawing.Point(102, 39);
            this.FIRE10_Seperate_Sel_comboBox.Name = "FIRE10_Seperate_Sel_comboBox";
            this.FIRE10_Seperate_Sel_comboBox.Size = new System.Drawing.Size(80, 20);
            this.FIRE10_Seperate_Sel_comboBox.TabIndex = 57;
            // 
            // FIRE10_Seperate_Sel_label
            // 
            this.FIRE10_Seperate_Sel_label.AutoSize = true;
            this.FIRE10_Seperate_Sel_label.Location = new System.Drawing.Point(116, 24);
            this.FIRE10_Seperate_Sel_label.Name = "FIRE10_Seperate_Sel_label";
            this.FIRE10_Seperate_Sel_label.Size = new System.Drawing.Size(51, 12);
            this.FIRE10_Seperate_Sel_label.TabIndex = 56;
            this.FIRE10_Seperate_Sel_label.Text = "층(구분)";
            // 
            // FIRE10_Gaedan_ID_Sel_label
            // 
            this.FIRE10_Gaedan_ID_Sel_label.AutoSize = true;
            this.FIRE10_Gaedan_ID_Sel_label.Location = new System.Drawing.Point(296, 24);
            this.FIRE10_Gaedan_ID_Sel_label.Name = "FIRE10_Gaedan_ID_Sel_label";
            this.FIRE10_Gaedan_ID_Sel_label.Size = new System.Drawing.Size(77, 12);
            this.FIRE10_Gaedan_ID_Sel_label.TabIndex = 65;
            this.FIRE10_Gaedan_ID_Sel_label.Text = "계단(십 / 일)";
            // 
            // FIRE10_Operate_Sel_comboBox
            // 
            this.FIRE10_Operate_Sel_comboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.FIRE10_Operate_Sel_comboBox.FormattingEnabled = true;
            this.FIRE10_Operate_Sel_comboBox.Items.AddRange(new object[] {
            "F(화재발생)",
            "C(화재정지)",
            "D(연동정상)",
            "B(연동정지)",
            "A(전체복구)"});
            this.FIRE10_Operate_Sel_comboBox.Location = new System.Drawing.Point(6, 39);
            this.FIRE10_Operate_Sel_comboBox.Name = "FIRE10_Operate_Sel_comboBox";
            this.FIRE10_Operate_Sel_comboBox.Size = new System.Drawing.Size(90, 20);
            this.FIRE10_Operate_Sel_comboBox.TabIndex = 55;
            // 
            // FIRE10_Operate_Sel_label
            // 
            this.FIRE10_Operate_Sel_label.AutoSize = true;
            this.FIRE10_Operate_Sel_label.Location = new System.Drawing.Point(21, 23);
            this.FIRE10_Operate_Sel_label.Name = "FIRE10_Operate_Sel_label";
            this.FIRE10_Operate_Sel_label.Size = new System.Drawing.Size(63, 12);
            this.FIRE10_Operate_Sel_label.TabIndex = 54;
            this.FIRE10_Operate_Sel_label.Text = "동작(기능)";
            // 
            // FIRE10_Floor_ID1_Sel_comboBox
            // 
            this.FIRE10_Floor_ID1_Sel_comboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.FIRE10_Floor_ID1_Sel_comboBox.FormattingEnabled = true;
            this.FIRE10_Floor_ID1_Sel_comboBox.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.FIRE10_Floor_ID1_Sel_comboBox.Location = new System.Drawing.Point(427, 39);
            this.FIRE10_Floor_ID1_Sel_comboBox.Name = "FIRE10_Floor_ID1_Sel_comboBox";
            this.FIRE10_Floor_ID1_Sel_comboBox.Size = new System.Drawing.Size(34, 20);
            this.FIRE10_Floor_ID1_Sel_comboBox.TabIndex = 64;
            // 
            // FIRE10_Dong_ID10_Sel_comboBox
            // 
            this.FIRE10_Dong_ID10_Sel_comboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.FIRE10_Dong_ID10_Sel_comboBox.FormattingEnabled = true;
            this.FIRE10_Dong_ID10_Sel_comboBox.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.FIRE10_Dong_ID10_Sel_comboBox.Location = new System.Drawing.Point(199, 39);
            this.FIRE10_Dong_ID10_Sel_comboBox.Name = "FIRE10_Dong_ID10_Sel_comboBox";
            this.FIRE10_Dong_ID10_Sel_comboBox.Size = new System.Drawing.Size(34, 20);
            this.FIRE10_Dong_ID10_Sel_comboBox.TabIndex = 59;
            // 
            // FIRE10_Dong_ID_Sel_label
            // 
            this.FIRE10_Dong_ID_Sel_label.AutoSize = true;
            this.FIRE10_Dong_ID_Sel_label.Location = new System.Drawing.Point(204, 24);
            this.FIRE10_Dong_ID_Sel_label.Name = "FIRE10_Dong_ID_Sel_label";
            this.FIRE10_Dong_ID_Sel_label.Size = new System.Drawing.Size(65, 12);
            this.FIRE10_Dong_ID_Sel_label.TabIndex = 58;
            this.FIRE10_Dong_ID_Sel_label.Text = "동(십 / 일)";
            // 
            // FIRE10_Floor_ID10_Sel_comboBox
            // 
            this.FIRE10_Floor_ID10_Sel_comboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.FIRE10_Floor_ID10_Sel_comboBox.FormattingEnabled = true;
            this.FIRE10_Floor_ID10_Sel_comboBox.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.FIRE10_Floor_ID10_Sel_comboBox.Location = new System.Drawing.Point(387, 39);
            this.FIRE10_Floor_ID10_Sel_comboBox.Name = "FIRE10_Floor_ID10_Sel_comboBox";
            this.FIRE10_Floor_ID10_Sel_comboBox.Size = new System.Drawing.Size(34, 20);
            this.FIRE10_Floor_ID10_Sel_comboBox.TabIndex = 63;
            // 
            // FIRE10_Dong_ID1_Sel_comboBox
            // 
            this.FIRE10_Dong_ID1_Sel_comboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.FIRE10_Dong_ID1_Sel_comboBox.FormattingEnabled = true;
            this.FIRE10_Dong_ID1_Sel_comboBox.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.FIRE10_Dong_ID1_Sel_comboBox.Location = new System.Drawing.Point(239, 39);
            this.FIRE10_Dong_ID1_Sel_comboBox.Name = "FIRE10_Dong_ID1_Sel_comboBox";
            this.FIRE10_Dong_ID1_Sel_comboBox.Size = new System.Drawing.Size(34, 20);
            this.FIRE10_Dong_ID1_Sel_comboBox.TabIndex = 60;
            // 
            // FIRE10_Gaedan_ID10_Sel_comboBox
            // 
            this.FIRE10_Gaedan_ID10_Sel_comboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.FIRE10_Gaedan_ID10_Sel_comboBox.FormattingEnabled = true;
            this.FIRE10_Gaedan_ID10_Sel_comboBox.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.FIRE10_Gaedan_ID10_Sel_comboBox.Location = new System.Drawing.Point(295, 39);
            this.FIRE10_Gaedan_ID10_Sel_comboBox.Name = "FIRE10_Gaedan_ID10_Sel_comboBox";
            this.FIRE10_Gaedan_ID10_Sel_comboBox.Size = new System.Drawing.Size(34, 20);
            this.FIRE10_Gaedan_ID10_Sel_comboBox.TabIndex = 61;
            // 
            // FIRE10_Gaedan_ID1_Sel_comboBox
            // 
            this.FIRE10_Gaedan_ID1_Sel_comboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.FIRE10_Gaedan_ID1_Sel_comboBox.FormattingEnabled = true;
            this.FIRE10_Gaedan_ID1_Sel_comboBox.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.FIRE10_Gaedan_ID1_Sel_comboBox.Location = new System.Drawing.Point(335, 39);
            this.FIRE10_Gaedan_ID1_Sel_comboBox.Name = "FIRE10_Gaedan_ID1_Sel_comboBox";
            this.FIRE10_Gaedan_ID1_Sel_comboBox.Size = new System.Drawing.Size(34, 20);
            this.FIRE10_Gaedan_ID1_Sel_comboBox.TabIndex = 62;
            // 
            // NMC44_FIRE12_Groupbox
            // 
            this.NMC44_FIRE12_Groupbox.Controls.Add(this.FIRE12_Floor_ID_Sel_label);
            this.NMC44_FIRE12_Groupbox.Controls.Add(this.FIRE12_Gaedan_ID_Sel_label);
            this.NMC44_FIRE12_Groupbox.Controls.Add(this.FIRE12_Floor_ID1_Sel_comboBox);
            this.NMC44_FIRE12_Groupbox.Controls.Add(this.FIRE12_Floor_ID10_Sel_comboBox);
            this.NMC44_FIRE12_Groupbox.Controls.Add(this.FIRE12_Gaedan_ID1_Sel_comboBox);
            this.NMC44_FIRE12_Groupbox.Controls.Add(this.FIRE12_Gaedan_ID10_Sel_comboBox);
            this.NMC44_FIRE12_Groupbox.Controls.Add(this.FIRE12_Dong_ID1_Sel_comboBox);
            this.NMC44_FIRE12_Groupbox.Controls.Add(this.FIRE12_Dong_ID10_Sel_comboBox);
            this.NMC44_FIRE12_Groupbox.Controls.Add(this.FIRE12_Dong_ID_Sel_label);
            this.NMC44_FIRE12_Groupbox.Controls.Add(this.FIRE12_Operate_Sel_comboBox);
            this.NMC44_FIRE12_Groupbox.Controls.Add(this.FIRE12_Operate_Sel_label);
            this.NMC44_FIRE12_Groupbox.Location = new System.Drawing.Point(7, 385);
            this.NMC44_FIRE12_Groupbox.Name = "NMC44_FIRE12_Groupbox";
            this.NMC44_FIRE12_Groupbox.Size = new System.Drawing.Size(471, 83);
            this.NMC44_FIRE12_Groupbox.TabIndex = 66;
            this.NMC44_FIRE12_Groupbox.TabStop = false;
            this.NMC44_FIRE12_Groupbox.Text = "소방 12Byte 수신 시, 제어(FIRE)";
            // 
            // FIRE12_Floor_ID_Sel_label
            // 
            this.FIRE12_Floor_ID_Sel_label.AutoSize = true;
            this.FIRE12_Floor_ID_Sel_label.Location = new System.Drawing.Point(390, 24);
            this.FIRE12_Floor_ID_Sel_label.Name = "FIRE12_Floor_ID_Sel_label";
            this.FIRE12_Floor_ID_Sel_label.Size = new System.Drawing.Size(65, 12);
            this.FIRE12_Floor_ID_Sel_label.TabIndex = 66;
            this.FIRE12_Floor_ID_Sel_label.Text = "층(십 / 일)";
            // 
            // FIRE12_Gaedan_ID_Sel_label
            // 
            this.FIRE12_Gaedan_ID_Sel_label.AutoSize = true;
            this.FIRE12_Gaedan_ID_Sel_label.Location = new System.Drawing.Point(296, 24);
            this.FIRE12_Gaedan_ID_Sel_label.Name = "FIRE12_Gaedan_ID_Sel_label";
            this.FIRE12_Gaedan_ID_Sel_label.Size = new System.Drawing.Size(77, 12);
            this.FIRE12_Gaedan_ID_Sel_label.TabIndex = 65;
            this.FIRE12_Gaedan_ID_Sel_label.Text = "계단(십 / 일)";
            // 
            // FIRE12_Floor_ID1_Sel_comboBox
            // 
            this.FIRE12_Floor_ID1_Sel_comboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.FIRE12_Floor_ID1_Sel_comboBox.FormattingEnabled = true;
            this.FIRE12_Floor_ID1_Sel_comboBox.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.FIRE12_Floor_ID1_Sel_comboBox.Location = new System.Drawing.Point(427, 39);
            this.FIRE12_Floor_ID1_Sel_comboBox.Name = "FIRE12_Floor_ID1_Sel_comboBox";
            this.FIRE12_Floor_ID1_Sel_comboBox.Size = new System.Drawing.Size(34, 20);
            this.FIRE12_Floor_ID1_Sel_comboBox.TabIndex = 64;
            // 
            // FIRE12_Floor_ID10_Sel_comboBox
            // 
            this.FIRE12_Floor_ID10_Sel_comboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.FIRE12_Floor_ID10_Sel_comboBox.FormattingEnabled = true;
            this.FIRE12_Floor_ID10_Sel_comboBox.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.FIRE12_Floor_ID10_Sel_comboBox.Location = new System.Drawing.Point(387, 39);
            this.FIRE12_Floor_ID10_Sel_comboBox.Name = "FIRE12_Floor_ID10_Sel_comboBox";
            this.FIRE12_Floor_ID10_Sel_comboBox.Size = new System.Drawing.Size(34, 20);
            this.FIRE12_Floor_ID10_Sel_comboBox.TabIndex = 63;
            // 
            // FIRE12_Gaedan_ID1_Sel_comboBox
            // 
            this.FIRE12_Gaedan_ID1_Sel_comboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.FIRE12_Gaedan_ID1_Sel_comboBox.FormattingEnabled = true;
            this.FIRE12_Gaedan_ID1_Sel_comboBox.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.FIRE12_Gaedan_ID1_Sel_comboBox.Location = new System.Drawing.Point(335, 39);
            this.FIRE12_Gaedan_ID1_Sel_comboBox.Name = "FIRE12_Gaedan_ID1_Sel_comboBox";
            this.FIRE12_Gaedan_ID1_Sel_comboBox.Size = new System.Drawing.Size(34, 20);
            this.FIRE12_Gaedan_ID1_Sel_comboBox.TabIndex = 62;
            // 
            // FIRE12_Gaedan_ID10_Sel_comboBox
            // 
            this.FIRE12_Gaedan_ID10_Sel_comboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.FIRE12_Gaedan_ID10_Sel_comboBox.FormattingEnabled = true;
            this.FIRE12_Gaedan_ID10_Sel_comboBox.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.FIRE12_Gaedan_ID10_Sel_comboBox.Location = new System.Drawing.Point(296, 39);
            this.FIRE12_Gaedan_ID10_Sel_comboBox.Name = "FIRE12_Gaedan_ID10_Sel_comboBox";
            this.FIRE12_Gaedan_ID10_Sel_comboBox.Size = new System.Drawing.Size(34, 20);
            this.FIRE12_Gaedan_ID10_Sel_comboBox.TabIndex = 61;
            // 
            // FIRE12_Dong_ID1_Sel_comboBox
            // 
            this.FIRE12_Dong_ID1_Sel_comboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.FIRE12_Dong_ID1_Sel_comboBox.FormattingEnabled = true;
            this.FIRE12_Dong_ID1_Sel_comboBox.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.FIRE12_Dong_ID1_Sel_comboBox.Location = new System.Drawing.Point(239, 39);
            this.FIRE12_Dong_ID1_Sel_comboBox.Name = "FIRE12_Dong_ID1_Sel_comboBox";
            this.FIRE12_Dong_ID1_Sel_comboBox.Size = new System.Drawing.Size(34, 20);
            this.FIRE12_Dong_ID1_Sel_comboBox.TabIndex = 60;
            // 
            // FIRE12_Dong_ID10_Sel_comboBox
            // 
            this.FIRE12_Dong_ID10_Sel_comboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.FIRE12_Dong_ID10_Sel_comboBox.FormattingEnabled = true;
            this.FIRE12_Dong_ID10_Sel_comboBox.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.FIRE12_Dong_ID10_Sel_comboBox.Location = new System.Drawing.Point(199, 39);
            this.FIRE12_Dong_ID10_Sel_comboBox.Name = "FIRE12_Dong_ID10_Sel_comboBox";
            this.FIRE12_Dong_ID10_Sel_comboBox.Size = new System.Drawing.Size(34, 20);
            this.FIRE12_Dong_ID10_Sel_comboBox.TabIndex = 59;
            // 
            // FIRE12_Dong_ID_Sel_label
            // 
            this.FIRE12_Dong_ID_Sel_label.AutoSize = true;
            this.FIRE12_Dong_ID_Sel_label.Location = new System.Drawing.Point(203, 24);
            this.FIRE12_Dong_ID_Sel_label.Name = "FIRE12_Dong_ID_Sel_label";
            this.FIRE12_Dong_ID_Sel_label.Size = new System.Drawing.Size(65, 12);
            this.FIRE12_Dong_ID_Sel_label.TabIndex = 58;
            this.FIRE12_Dong_ID_Sel_label.Text = "동(십 / 일)";
            // 
            // FIRE12_Operate_Sel_comboBox
            // 
            this.FIRE12_Operate_Sel_comboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.FIRE12_Operate_Sel_comboBox.FormattingEnabled = true;
            this.FIRE12_Operate_Sel_comboBox.Items.AddRange(new object[] {
            "N(화재발생)",
            "F(화재정지)",
            "e(연동정상)",
            "E(연동정지)",
            "R(전체복구)"});
            this.FIRE12_Operate_Sel_comboBox.Location = new System.Drawing.Point(6, 39);
            this.FIRE12_Operate_Sel_comboBox.Name = "FIRE12_Operate_Sel_comboBox";
            this.FIRE12_Operate_Sel_comboBox.Size = new System.Drawing.Size(90, 20);
            this.FIRE12_Operate_Sel_comboBox.TabIndex = 55;
            // 
            // FIRE12_Operate_Sel_label
            // 
            this.FIRE12_Operate_Sel_label.AutoSize = true;
            this.FIRE12_Operate_Sel_label.Location = new System.Drawing.Point(21, 24);
            this.FIRE12_Operate_Sel_label.Name = "FIRE12_Operate_Sel_label";
            this.FIRE12_Operate_Sel_label.Size = new System.Drawing.Size(63, 12);
            this.FIRE12_Operate_Sel_label.TabIndex = 54;
            this.FIRE12_Operate_Sel_label.Text = "동작(기능)";
            // 
            // NMC44_FIRP_Groupbox
            // 
            this.NMC44_FIRP_Groupbox.Controls.Add(this.FIRP_Protocol_Sel_comboBox);
            this.NMC44_FIRP_Groupbox.Controls.Add(this.label33);
            this.NMC44_FIRP_Groupbox.Location = new System.Drawing.Point(7, 309);
            this.NMC44_FIRP_Groupbox.Name = "NMC44_FIRP_Groupbox";
            this.NMC44_FIRP_Groupbox.Size = new System.Drawing.Size(175, 70);
            this.NMC44_FIRP_Groupbox.TabIndex = 65;
            this.NMC44_FIRP_Groupbox.TabStop = false;
            this.NMC44_FIRP_Groupbox.Text = "화재 수신반 제어(FIRP)";
            // 
            // FIRP_Protocol_Sel_comboBox
            // 
            this.FIRP_Protocol_Sel_comboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.FIRP_Protocol_Sel_comboBox.FormattingEnabled = true;
            this.FIRP_Protocol_Sel_comboBox.Items.AddRange(new object[] {
            "0(NEI42)",
            "1(10Byte)",
            "2(12Byte)",
            "3(현재 프로토콜 값 요청)"});
            this.FIRP_Protocol_Sel_comboBox.Location = new System.Drawing.Point(6, 44);
            this.FIRP_Protocol_Sel_comboBox.Name = "FIRP_Protocol_Sel_comboBox";
            this.FIRP_Protocol_Sel_comboBox.Size = new System.Drawing.Size(160, 20);
            this.FIRP_Protocol_Sel_comboBox.TabIndex = 55;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(36, 29);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(81, 12);
            this.label33.TabIndex = 54;
            this.label33.Text = "프로토콜 설정";
            // 
            // NMC44_EMIC_Groupbox
            // 
            this.NMC44_EMIC_Groupbox.Controls.Add(this.EMIC_LED_On_Off_comboBox);
            this.NMC44_EMIC_Groupbox.Controls.Add(this.label40);
            this.NMC44_EMIC_Groupbox.Location = new System.Drawing.Point(300, 309);
            this.NMC44_EMIC_Groupbox.Name = "NMC44_EMIC_Groupbox";
            this.NMC44_EMIC_Groupbox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.NMC44_EMIC_Groupbox.Size = new System.Drawing.Size(130, 70);
            this.NMC44_EMIC_Groupbox.TabIndex = 66;
            this.NMC44_EMIC_Groupbox.TabStop = false;
            this.NMC44_EMIC_Groupbox.Text = "EM MIC 제어(EMIC)";
            // 
            // EMIC_LED_On_Off_comboBox
            // 
            this.EMIC_LED_On_Off_comboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.EMIC_LED_On_Off_comboBox.FormattingEnabled = true;
            this.EMIC_LED_On_Off_comboBox.Items.AddRange(new object[] {
            "0(EM MIC 해제)",
            "1(EM MIC 발생)"});
            this.EMIC_LED_On_Off_comboBox.Location = new System.Drawing.Point(6, 44);
            this.EMIC_LED_On_Off_comboBox.Name = "EMIC_LED_On_Off_comboBox";
            this.EMIC_LED_On_Off_comboBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.EMIC_LED_On_Off_comboBox.Size = new System.Drawing.Size(117, 20);
            this.EMIC_LED_On_Off_comboBox.TabIndex = 55;
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(30, 29);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(52, 12);
            this.label40.TabIndex = 54;
            this.label40.Text = "ON/OFF";
            // 
            // NMC44_FIRL_Groupbox
            // 
            this.NMC44_FIRL_Groupbox.Controls.Add(this.FIRL_LED_On_Off_comboBox);
            this.NMC44_FIRL_Groupbox.Controls.Add(this.label28);
            this.NMC44_FIRL_Groupbox.Location = new System.Drawing.Point(191, 309);
            this.NMC44_FIRL_Groupbox.Name = "NMC44_FIRL_Groupbox";
            this.NMC44_FIRL_Groupbox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.NMC44_FIRL_Groupbox.Size = new System.Drawing.Size(103, 70);
            this.NMC44_FIRL_Groupbox.TabIndex = 65;
            this.NMC44_FIRL_Groupbox.TabStop = false;
            this.NMC44_FIRL_Groupbox.Text = "화재 LED 제어(FIRL)";
            // 
            // FIRL_LED_On_Off_comboBox
            // 
            this.FIRL_LED_On_Off_comboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.FIRL_LED_On_Off_comboBox.FormattingEnabled = true;
            this.FIRL_LED_On_Off_comboBox.Items.AddRange(new object[] {
            "0(화재 해제)",
            "1(화재 발생)"});
            this.FIRL_LED_On_Off_comboBox.Location = new System.Drawing.Point(6, 44);
            this.FIRL_LED_On_Off_comboBox.Name = "FIRL_LED_On_Off_comboBox";
            this.FIRL_LED_On_Off_comboBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.FIRL_LED_On_Off_comboBox.Size = new System.Drawing.Size(91, 20);
            this.FIRL_LED_On_Off_comboBox.TabIndex = 55;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(25, 29);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(52, 12);
            this.label28.TabIndex = 54;
            this.label28.Text = "ON/OFF";
            // 
            // NMC44_MOT_Groupbox
            // 
            this.NMC44_MOT_Groupbox.Controls.Add(this.MOT_Output_Ch_comboBox);
            this.NMC44_MOT_Groupbox.Controls.Add(this.MOT_Output_Ch_labellabel);
            this.NMC44_MOT_Groupbox.Location = new System.Drawing.Point(7, 231);
            this.NMC44_MOT_Groupbox.Name = "NMC44_MOT_Groupbox";
            this.NMC44_MOT_Groupbox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.NMC44_MOT_Groupbox.Size = new System.Drawing.Size(127, 72);
            this.NMC44_MOT_Groupbox.TabIndex = 64;
            this.NMC44_MOT_Groupbox.TabStop = false;
            this.NMC44_MOT_Groupbox.Text = "  채널 모니터링 \n      (MOT)";
            // 
            // MOT_Output_Ch_comboBox
            // 
            this.MOT_Output_Ch_comboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.MOT_Output_Ch_comboBox.FormattingEnabled = true;
            this.MOT_Output_Ch_comboBox.Items.AddRange(new object[] {
            "1(Output Ch1)",
            "2(Output Ch2)",
            "3(Output Ch3)",
            "4(Output Ch4)"});
            this.MOT_Output_Ch_comboBox.Location = new System.Drawing.Point(6, 45);
            this.MOT_Output_Ch_comboBox.Name = "MOT_Output_Ch_comboBox";
            this.MOT_Output_Ch_comboBox.Size = new System.Drawing.Size(115, 20);
            this.MOT_Output_Ch_comboBox.TabIndex = 55;
            // 
            // MOT_Output_Ch_labellabel
            // 
            this.MOT_Output_Ch_labellabel.AutoSize = true;
            this.MOT_Output_Ch_labellabel.Location = new System.Drawing.Point(36, 30);
            this.MOT_Output_Ch_labellabel.Name = "MOT_Output_Ch_labellabel";
            this.MOT_Output_Ch_labellabel.Size = new System.Drawing.Size(53, 12);
            this.MOT_Output_Ch_labellabel.TabIndex = 54;
            this.MOT_Output_Ch_labellabel.Text = "출력채널";
            // 
            // NMC44_GPO_Groupbox
            // 
            this.NMC44_GPO_Groupbox.Controls.Add(this.GPO_ON_OFF_comboBox);
            this.NMC44_GPO_Groupbox.Controls.Add(this.GPO_ON_OFF_label);
            this.NMC44_GPO_Groupbox.Controls.Add(this.GPO_Sel_Ch_comboBox);
            this.NMC44_GPO_Groupbox.Controls.Add(this.GPO_Sel_Ch_label);
            this.NMC44_GPO_Groupbox.Location = new System.Drawing.Point(217, 153);
            this.NMC44_GPO_Groupbox.Name = "NMC44_GPO_Groupbox";
            this.NMC44_GPO_Groupbox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.NMC44_GPO_Groupbox.Size = new System.Drawing.Size(204, 72);
            this.NMC44_GPO_Groupbox.TabIndex = 65;
            this.NMC44_GPO_Groupbox.TabStop = false;
            this.NMC44_GPO_Groupbox.Text = "GPOUT 제어(GPO)";
            // 
            // GPO_ON_OFF_comboBox
            // 
            this.GPO_ON_OFF_comboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.GPO_ON_OFF_comboBox.FormattingEnabled = true;
            this.GPO_ON_OFF_comboBox.Items.AddRange(new object[] {
            "0(OFF)",
            "1(ON)"});
            this.GPO_ON_OFF_comboBox.Location = new System.Drawing.Point(124, 45);
            this.GPO_ON_OFF_comboBox.Name = "GPO_ON_OFF_comboBox";
            this.GPO_ON_OFF_comboBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.GPO_ON_OFF_comboBox.Size = new System.Drawing.Size(74, 20);
            this.GPO_ON_OFF_comboBox.TabIndex = 67;
            // 
            // GPO_ON_OFF_label
            // 
            this.GPO_ON_OFF_label.AutoSize = true;
            this.GPO_ON_OFF_label.Location = new System.Drawing.Point(132, 30);
            this.GPO_ON_OFF_label.Name = "GPO_ON_OFF_label";
            this.GPO_ON_OFF_label.Size = new System.Drawing.Size(52, 12);
            this.GPO_ON_OFF_label.TabIndex = 66;
            this.GPO_ON_OFF_label.Text = "ON/OFF";
            // 
            // GPO_Sel_Ch_comboBox
            // 
            this.GPO_Sel_Ch_comboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.GPO_Sel_Ch_comboBox.FormattingEnabled = true;
            this.GPO_Sel_Ch_comboBox.Items.AddRange(new object[] {
            "1(GPOUT 1Ch)",
            "2(GPOUT 2Ch)",
            "3(GPOUT 3Ch)",
            "4(GPOUT 4Ch)"});
            this.GPO_Sel_Ch_comboBox.Location = new System.Drawing.Point(5, 45);
            this.GPO_Sel_Ch_comboBox.Name = "GPO_Sel_Ch_comboBox";
            this.GPO_Sel_Ch_comboBox.Size = new System.Drawing.Size(111, 20);
            this.GPO_Sel_Ch_comboBox.TabIndex = 65;
            // 
            // GPO_Sel_Ch_label
            // 
            this.GPO_Sel_Ch_label.AutoSize = true;
            this.GPO_Sel_Ch_label.Location = new System.Drawing.Point(41, 30);
            this.GPO_Sel_Ch_label.Name = "GPO_Sel_Ch_label";
            this.GPO_Sel_Ch_label.Size = new System.Drawing.Size(29, 12);
            this.GPO_Sel_Ch_label.TabIndex = 64;
            this.GPO_Sel_Ch_label.Text = "채널";
            // 
            // NMC44_BAS_Groupbox
            // 
            this.NMC44_BAS_Groupbox.Controls.Add(this.BAS_Vol_Select_comboBox);
            this.NMC44_BAS_Groupbox.Controls.Add(this.BAS_Output_Ch_label);
            this.NMC44_BAS_Groupbox.Controls.Add(this.BAS_Vol_Select_label);
            this.NMC44_BAS_Groupbox.Controls.Add(this.BAS_Output_Ch_comboBox);
            this.NMC44_BAS_Groupbox.Location = new System.Drawing.Point(312, 231);
            this.NMC44_BAS_Groupbox.Name = "NMC44_BAS_Groupbox";
            this.NMC44_BAS_Groupbox.Size = new System.Drawing.Size(166, 72);
            this.NMC44_BAS_Groupbox.TabIndex = 64;
            this.NMC44_BAS_Groupbox.TabStop = false;
            this.NMC44_BAS_Groupbox.Text = "Base 제어(BAS)";
            // 
            // BAS_Vol_Select_comboBox
            // 
            this.BAS_Vol_Select_comboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.BAS_Vol_Select_comboBox.FormattingEnabled = true;
            this.BAS_Vol_Select_comboBox.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.BAS_Vol_Select_comboBox.Location = new System.Drawing.Point(123, 45);
            this.BAS_Vol_Select_comboBox.Name = "BAS_Vol_Select_comboBox";
            this.BAS_Vol_Select_comboBox.Size = new System.Drawing.Size(34, 20);
            this.BAS_Vol_Select_comboBox.TabIndex = 63;
            // 
            // BAS_Output_Ch_label
            // 
            this.BAS_Output_Ch_label.AutoSize = true;
            this.BAS_Output_Ch_label.Location = new System.Drawing.Point(33, 30);
            this.BAS_Output_Ch_label.Name = "BAS_Output_Ch_label";
            this.BAS_Output_Ch_label.Size = new System.Drawing.Size(53, 12);
            this.BAS_Output_Ch_label.TabIndex = 60;
            this.BAS_Output_Ch_label.Text = "출력채널";
            // 
            // BAS_Vol_Select_label
            // 
            this.BAS_Vol_Select_label.AutoSize = true;
            this.BAS_Vol_Select_label.Location = new System.Drawing.Point(126, 30);
            this.BAS_Vol_Select_label.Name = "BAS_Vol_Select_label";
            this.BAS_Vol_Select_label.Size = new System.Drawing.Size(29, 12);
            this.BAS_Vol_Select_label.TabIndex = 62;
            this.BAS_Vol_Select_label.Text = "볼륨";
            // 
            // BAS_Output_Ch_comboBox
            // 
            this.BAS_Output_Ch_comboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.BAS_Output_Ch_comboBox.FormattingEnabled = true;
            this.BAS_Output_Ch_comboBox.Items.AddRange(new object[] {
            "A1(Output Ch1)",
            "A2(Output Ch2)",
            "A3(Output Ch3)",
            "A4(Output Ch4)"});
            this.BAS_Output_Ch_comboBox.Location = new System.Drawing.Point(6, 45);
            this.BAS_Output_Ch_comboBox.Name = "BAS_Output_Ch_comboBox";
            this.BAS_Output_Ch_comboBox.Size = new System.Drawing.Size(111, 20);
            this.BAS_Output_Ch_comboBox.TabIndex = 61;
            // 
            // NMC44_TRB_Groupbox
            // 
            this.NMC44_TRB_Groupbox.Controls.Add(this.TRB_Vol_Select_comboBox);
            this.NMC44_TRB_Groupbox.Controls.Add(this.TRB_Output_Ch_label);
            this.NMC44_TRB_Groupbox.Controls.Add(this.TRB_Vol_Select_label);
            this.NMC44_TRB_Groupbox.Controls.Add(this.TRB_Output_Ch_comboBox);
            this.NMC44_TRB_Groupbox.Location = new System.Drawing.Point(140, 230);
            this.NMC44_TRB_Groupbox.Name = "NMC44_TRB_Groupbox";
            this.NMC44_TRB_Groupbox.Size = new System.Drawing.Size(166, 72);
            this.NMC44_TRB_Groupbox.TabIndex = 64;
            this.NMC44_TRB_Groupbox.TabStop = false;
            this.NMC44_TRB_Groupbox.Text = "Treble 제어(TRB)";
            // 
            // TRB_Vol_Select_comboBox
            // 
            this.TRB_Vol_Select_comboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.TRB_Vol_Select_comboBox.FormattingEnabled = true;
            this.TRB_Vol_Select_comboBox.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.TRB_Vol_Select_comboBox.Location = new System.Drawing.Point(124, 46);
            this.TRB_Vol_Select_comboBox.Name = "TRB_Vol_Select_comboBox";
            this.TRB_Vol_Select_comboBox.Size = new System.Drawing.Size(34, 20);
            this.TRB_Vol_Select_comboBox.TabIndex = 63;
            // 
            // TRB_Output_Ch_label
            // 
            this.TRB_Output_Ch_label.AutoSize = true;
            this.TRB_Output_Ch_label.Location = new System.Drawing.Point(39, 31);
            this.TRB_Output_Ch_label.Name = "TRB_Output_Ch_label";
            this.TRB_Output_Ch_label.Size = new System.Drawing.Size(53, 12);
            this.TRB_Output_Ch_label.TabIndex = 60;
            this.TRB_Output_Ch_label.Text = "출력채널";
            // 
            // TRB_Vol_Select_label
            // 
            this.TRB_Vol_Select_label.AutoSize = true;
            this.TRB_Vol_Select_label.Location = new System.Drawing.Point(127, 31);
            this.TRB_Vol_Select_label.Name = "TRB_Vol_Select_label";
            this.TRB_Vol_Select_label.Size = new System.Drawing.Size(29, 12);
            this.TRB_Vol_Select_label.TabIndex = 62;
            this.TRB_Vol_Select_label.Text = "볼륨";
            // 
            // TRB_Output_Ch_comboBox
            // 
            this.TRB_Output_Ch_comboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.TRB_Output_Ch_comboBox.FormattingEnabled = true;
            this.TRB_Output_Ch_comboBox.Items.AddRange(new object[] {
            "A1(Output Ch1)",
            "A2(Output Ch2)",
            "A3(Output Ch3)",
            "A4(Output Ch4)"});
            this.TRB_Output_Ch_comboBox.Location = new System.Drawing.Point(7, 46);
            this.TRB_Output_Ch_comboBox.Name = "TRB_Output_Ch_comboBox";
            this.TRB_Output_Ch_comboBox.Size = new System.Drawing.Size(111, 20);
            this.TRB_Output_Ch_comboBox.TabIndex = 61;
            // 
            // NMC44_VOL_Groupbox
            // 
            this.NMC44_VOL_Groupbox.Controls.Add(this.VOL_Vol_Select_comboBox);
            this.NMC44_VOL_Groupbox.Controls.Add(this.VOL_Output_Ch_label);
            this.NMC44_VOL_Groupbox.Controls.Add(this.VOL_Vol_Select_label);
            this.NMC44_VOL_Groupbox.Controls.Add(this.VOL_Output_Ch_comboBox);
            this.NMC44_VOL_Groupbox.Location = new System.Drawing.Point(7, 153);
            this.NMC44_VOL_Groupbox.Name = "NMC44_VOL_Groupbox";
            this.NMC44_VOL_Groupbox.Size = new System.Drawing.Size(204, 72);
            this.NMC44_VOL_Groupbox.TabIndex = 60;
            this.NMC44_VOL_Groupbox.TabStop = false;
            this.NMC44_VOL_Groupbox.Text = "볼륨 제어(VOL)";
            // 
            // VOL_Vol_Select_comboBox
            // 
            this.VOL_Vol_Select_comboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.VOL_Vol_Select_comboBox.FormattingEnabled = true;
            this.VOL_Vol_Select_comboBox.Items.AddRange(new object[] {
            "0(MUTE)",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "a(MAX)"});
            this.VOL_Vol_Select_comboBox.Location = new System.Drawing.Point(122, 46);
            this.VOL_Vol_Select_comboBox.Name = "VOL_Vol_Select_comboBox";
            this.VOL_Vol_Select_comboBox.Size = new System.Drawing.Size(76, 20);
            this.VOL_Vol_Select_comboBox.TabIndex = 63;
            // 
            // VOL_Output_Ch_label
            // 
            this.VOL_Output_Ch_label.AutoSize = true;
            this.VOL_Output_Ch_label.Location = new System.Drawing.Point(36, 31);
            this.VOL_Output_Ch_label.Name = "VOL_Output_Ch_label";
            this.VOL_Output_Ch_label.Size = new System.Drawing.Size(53, 12);
            this.VOL_Output_Ch_label.TabIndex = 60;
            this.VOL_Output_Ch_label.Text = "출력채널";
            // 
            // VOL_Vol_Select_label
            // 
            this.VOL_Vol_Select_label.AutoSize = true;
            this.VOL_Vol_Select_label.Location = new System.Drawing.Point(146, 31);
            this.VOL_Vol_Select_label.Name = "VOL_Vol_Select_label";
            this.VOL_Vol_Select_label.Size = new System.Drawing.Size(29, 12);
            this.VOL_Vol_Select_label.TabIndex = 62;
            this.VOL_Vol_Select_label.Text = "볼륨";
            // 
            // VOL_Output_Ch_comboBox
            // 
            this.VOL_Output_Ch_comboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.VOL_Output_Ch_comboBox.FormattingEnabled = true;
            this.VOL_Output_Ch_comboBox.Items.AddRange(new object[] {
            "A1(Output Ch1)",
            "A2(Output Ch2)",
            "A3(Output Ch3)",
            "A4(Output Ch4)"});
            this.VOL_Output_Ch_comboBox.Location = new System.Drawing.Point(6, 46);
            this.VOL_Output_Ch_comboBox.Name = "VOL_Output_Ch_comboBox";
            this.VOL_Output_Ch_comboBox.Size = new System.Drawing.Size(110, 20);
            this.VOL_Output_Ch_comboBox.TabIndex = 61;
            // 
            // NMC44_MUX_Groupbox
            // 
            this.NMC44_MUX_Groupbox.Controls.Add(this.MUX_Ext_Priority_comboBox);
            this.NMC44_MUX_Groupbox.Controls.Add(this.MUX_Ext_Priority_label);
            this.NMC44_MUX_Groupbox.Controls.Add(this.MUX_Vol_Select_comboBox);
            this.NMC44_MUX_Groupbox.Controls.Add(this.MUX_Vol_Select_label);
            this.NMC44_MUX_Groupbox.Controls.Add(this.MUX_Ouput_Ch_comboBox);
            this.NMC44_MUX_Groupbox.Controls.Add(this.MUX_Input_Ch_comboBox);
            this.NMC44_MUX_Groupbox.Controls.Add(this.MUX_Ouput_Ch_label);
            this.NMC44_MUX_Groupbox.Controls.Add(this.MUX_Input_Ch_label);
            this.NMC44_MUX_Groupbox.Location = new System.Drawing.Point(7, 64);
            this.NMC44_MUX_Groupbox.Name = "NMC44_MUX_Groupbox";
            this.NMC44_MUX_Groupbox.Size = new System.Drawing.Size(471, 83);
            this.NMC44_MUX_Groupbox.TabIndex = 51;
            this.NMC44_MUX_Groupbox.TabStop = false;
            this.NMC44_MUX_Groupbox.Text = "채널 및 볼륨 제어(MUX)";
            // 
            // MUX_Ext_Priority_comboBox
            // 
            this.MUX_Ext_Priority_comboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.MUX_Ext_Priority_comboBox.FormattingEnabled = true;
            this.MUX_Ext_Priority_comboBox.Items.AddRange(new object[] {
            "0(Fire(RPI))",
            "1(EM MIC)",
            "2(PC)",
            "3(NCS)",
            "4(AUX1)",
            "5(AUX2)",
            "6(AUX3)",
            "7(MPR5000)"});
            this.MUX_Ext_Priority_comboBox.Location = new System.Drawing.Point(364, 41);
            this.MUX_Ext_Priority_comboBox.Name = "MUX_Ext_Priority_comboBox";
            this.MUX_Ext_Priority_comboBox.Size = new System.Drawing.Size(101, 20);
            this.MUX_Ext_Priority_comboBox.TabIndex = 59;
            // 
            // MUX_Ext_Priority_label
            // 
            this.MUX_Ext_Priority_label.AutoSize = true;
            this.MUX_Ext_Priority_label.Location = new System.Drawing.Point(385, 14);
            this.MUX_Ext_Priority_label.Name = "MUX_Ext_Priority_label";
            this.MUX_Ext_Priority_label.Size = new System.Drawing.Size(53, 24);
            this.MUX_Ext_Priority_label.TabIndex = 58;
            this.MUX_Ext_Priority_label.Text = "외부입력\r\n우선순위";
            // 
            // MUX_Vol_Select_comboBox
            // 
            this.MUX_Vol_Select_comboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.MUX_Vol_Select_comboBox.FormattingEnabled = true;
            this.MUX_Vol_Select_comboBox.Items.AddRange(new object[] {
            "0(MUTE)",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "a(MAX)"});
            this.MUX_Vol_Select_comboBox.Location = new System.Drawing.Point(279, 41);
            this.MUX_Vol_Select_comboBox.Name = "MUX_Vol_Select_comboBox";
            this.MUX_Vol_Select_comboBox.Size = new System.Drawing.Size(79, 20);
            this.MUX_Vol_Select_comboBox.TabIndex = 57;
            // 
            // MUX_Vol_Select_label
            // 
            this.MUX_Vol_Select_label.AutoSize = true;
            this.MUX_Vol_Select_label.Location = new System.Drawing.Point(300, 26);
            this.MUX_Vol_Select_label.Name = "MUX_Vol_Select_label";
            this.MUX_Vol_Select_label.Size = new System.Drawing.Size(29, 12);
            this.MUX_Vol_Select_label.TabIndex = 56;
            this.MUX_Vol_Select_label.Text = "볼륨";
            // 
            // MUX_Ouput_Ch_comboBox
            // 
            this.MUX_Ouput_Ch_comboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.MUX_Ouput_Ch_comboBox.FormattingEnabled = true;
            this.MUX_Ouput_Ch_comboBox.Items.AddRange(new object[] {
            "A1(Output Ch1)",
            "A2(Output Ch2)",
            "A3(Output Ch3)",
            "A4(Output Ch4)"});
            this.MUX_Ouput_Ch_comboBox.Location = new System.Drawing.Point(5, 41);
            this.MUX_Ouput_Ch_comboBox.Name = "MUX_Ouput_Ch_comboBox";
            this.MUX_Ouput_Ch_comboBox.Size = new System.Drawing.Size(111, 20);
            this.MUX_Ouput_Ch_comboBox.TabIndex = 55;
            // 
            // MUX_Input_Ch_comboBox
            // 
            this.MUX_Input_Ch_comboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.MUX_Input_Ch_comboBox.FormattingEnabled = true;
            this.MUX_Input_Ch_comboBox.Items.AddRange(new object[] {
            "0(OFF)",
            "1(마이크/차임)",
            "2(Input Ch1)",
            "3(Input Ch2)",
            "4(Input Ch3)",
            "5(Input Ch4)",
            "6(우선순위 외부 입력)"});
            this.MUX_Input_Ch_comboBox.Location = new System.Drawing.Point(122, 41);
            this.MUX_Input_Ch_comboBox.Name = "MUX_Input_Ch_comboBox";
            this.MUX_Input_Ch_comboBox.Size = new System.Drawing.Size(150, 20);
            this.MUX_Input_Ch_comboBox.TabIndex = 53;
            // 
            // MUX_Ouput_Ch_label
            // 
            this.MUX_Ouput_Ch_label.AutoSize = true;
            this.MUX_Ouput_Ch_label.Location = new System.Drawing.Point(31, 26);
            this.MUX_Ouput_Ch_label.Name = "MUX_Ouput_Ch_label";
            this.MUX_Ouput_Ch_label.Size = new System.Drawing.Size(53, 12);
            this.MUX_Ouput_Ch_label.TabIndex = 54;
            this.MUX_Ouput_Ch_label.Text = "출력채널";
            // 
            // MUX_Input_Ch_label
            // 
            this.MUX_Input_Ch_label.AutoSize = true;
            this.MUX_Input_Ch_label.Location = new System.Drawing.Point(160, 26);
            this.MUX_Input_Ch_label.Name = "MUX_Input_Ch_label";
            this.MUX_Input_Ch_label.Size = new System.Drawing.Size(53, 12);
            this.MUX_Input_Ch_label.TabIndex = 52;
            this.MUX_Input_Ch_label.Text = "입력채널";
            // 
            // NMC44_CMD_Label
            // 
            this.NMC44_CMD_Label.AutoSize = true;
            this.NMC44_CMD_Label.Location = new System.Drawing.Point(132, 15);
            this.NMC44_CMD_Label.Name = "NMC44_CMD_Label";
            this.NMC44_CMD_Label.Size = new System.Drawing.Size(41, 12);
            this.NMC44_CMD_Label.TabIndex = 50;
            this.NMC44_CMD_Label.Text = "명령어";
            // 
            // NMC44_ID_1_comboBox
            // 
            this.NMC44_ID_1_comboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.NMC44_ID_1_comboBox.FormattingEnabled = true;
            this.NMC44_ID_1_comboBox.Items.AddRange(new object[] {
            "1"});
            this.NMC44_ID_1_comboBox.Location = new System.Drawing.Point(71, 30);
            this.NMC44_ID_1_comboBox.Name = "NMC44_ID_1_comboBox";
            this.NMC44_ID_1_comboBox.Size = new System.Drawing.Size(57, 20);
            this.NMC44_ID_1_comboBox.TabIndex = 49;
            // 
            // NMC44_ID_10_comboBox
            // 
            this.NMC44_ID_10_comboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.NMC44_ID_10_comboBox.FormattingEnabled = true;
            this.NMC44_ID_10_comboBox.Items.AddRange(new object[] {
            "0"});
            this.NMC44_ID_10_comboBox.Location = new System.Drawing.Point(7, 30);
            this.NMC44_ID_10_comboBox.Name = "NMC44_ID_10_comboBox";
            this.NMC44_ID_10_comboBox.Size = new System.Drawing.Size(57, 20);
            this.NMC44_ID_10_comboBox.TabIndex = 48;
            // 
            // NMC_Cmd_comboBox
            // 
            this.NMC_Cmd_comboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.NMC_Cmd_comboBox.FormattingEnabled = true;
            this.NMC_Cmd_comboBox.Items.AddRange(new object[] {
            "INIT",
            "DMY",
            "MUX",
            "VOL",
            "GPO",
            "MOT",
            "TRB",
            "BAS",
            "FIRP",
            "FIRL",
            "EMIC",
            "FIRE(12Byte)",
            "FIRE(10Byte)",
            "VER"});
            this.NMC_Cmd_comboBox.Location = new System.Drawing.Point(134, 30);
            this.NMC_Cmd_comboBox.Name = "NMC_Cmd_comboBox";
            this.NMC_Cmd_comboBox.Size = new System.Drawing.Size(121, 20);
            this.NMC_Cmd_comboBox.TabIndex = 47;
            this.NMC_Cmd_comboBox.SelectedIndexChanged += new System.EventHandler(this.NMC_Cmd_comboBox_SelectedIndexChanged);
            // 
            // NMC44_ID_Label
            // 
            this.NMC44_ID_Label.AutoSize = true;
            this.NMC44_ID_Label.Location = new System.Drawing.Point(5, 15);
            this.NMC44_ID_Label.Name = "NMC44_ID_Label";
            this.NMC44_ID_Label.Size = new System.Drawing.Size(16, 12);
            this.NMC44_ID_Label.TabIndex = 44;
            this.NMC44_ID_Label.Text = "ID";
            // 
            // NMC_Insert_Button
            // 
            this.NMC_Insert_Button.Location = new System.Drawing.Point(434, 24);
            this.NMC_Insert_Button.Name = "NMC_Insert_Button";
            this.NMC_Insert_Button.Size = new System.Drawing.Size(44, 41);
            this.NMC_Insert_Button.TabIndex = 19;
            this.NMC_Insert_Button.Text = ">>";
            this.NMC_Insert_Button.UseVisualStyleBackColor = true;
            this.NMC_Insert_Button.Click += new System.EventHandler(this.NMC_Insert_Button_Click);
            // 
            // NRG16_TabPage
            // 
            this.NRG16_TabPage.Controls.Add(this.NRG16_Clr_Button);
            this.NRG16_TabPage.Controls.Add(this.NRG16_CMD_Label);
            this.NRG16_TabPage.Controls.Add(this.NRG16_ID_1_comboBox);
            this.NRG16_TabPage.Controls.Add(this.NRG16_ID_10_comboBox);
            this.NRG16_TabPage.Controls.Add(this.NRG_Cmd_comboBox);
            this.NRG16_TabPage.Controls.Add(this.NRG16_EM_Groupbox);
            this.NRG16_TabPage.Controls.Add(this.NRG16_Normal_Groupbox);
            this.NRG16_TabPage.Controls.Add(this.NRG16_ID_Label);
            this.NRG16_TabPage.Controls.Add(this.NRG_Insert_Button);
            this.NRG16_TabPage.Location = new System.Drawing.Point(4, 22);
            this.NRG16_TabPage.Name = "NRG16_TabPage";
            this.NRG16_TabPage.Padding = new System.Windows.Forms.Padding(3);
            this.NRG16_TabPage.Size = new System.Drawing.Size(484, 625);
            this.NRG16_TabPage.TabIndex = 2;
            this.NRG16_TabPage.Text = "NRG16";
            this.NRG16_TabPage.UseVisualStyleBackColor = true;
            // 
            // NRG16_CMD_Label
            // 
            this.NRG16_CMD_Label.AutoSize = true;
            this.NRG16_CMD_Label.Location = new System.Drawing.Point(132, 15);
            this.NRG16_CMD_Label.Name = "NRG16_CMD_Label";
            this.NRG16_CMD_Label.Size = new System.Drawing.Size(41, 12);
            this.NRG16_CMD_Label.TabIndex = 50;
            this.NRG16_CMD_Label.Text = "명령어";
            // 
            // NRG16_ID_1_comboBox
            // 
            this.NRG16_ID_1_comboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.NRG16_ID_1_comboBox.FormattingEnabled = true;
            this.NRG16_ID_1_comboBox.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "A",
            "B",
            "C",
            "D",
            "E",
            "F"});
            this.NRG16_ID_1_comboBox.Location = new System.Drawing.Point(71, 30);
            this.NRG16_ID_1_comboBox.Name = "NRG16_ID_1_comboBox";
            this.NRG16_ID_1_comboBox.Size = new System.Drawing.Size(57, 20);
            this.NRG16_ID_1_comboBox.TabIndex = 49;
            // 
            // NRG16_ID_10_comboBox
            // 
            this.NRG16_ID_10_comboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.NRG16_ID_10_comboBox.FormattingEnabled = true;
            this.NRG16_ID_10_comboBox.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "A",
            "B",
            "C",
            "D",
            "E",
            "F"});
            this.NRG16_ID_10_comboBox.Location = new System.Drawing.Point(7, 30);
            this.NRG16_ID_10_comboBox.Name = "NRG16_ID_10_comboBox";
            this.NRG16_ID_10_comboBox.Size = new System.Drawing.Size(57, 20);
            this.NRG16_ID_10_comboBox.TabIndex = 48;
            // 
            // NRG_Cmd_comboBox
            // 
            this.NRG_Cmd_comboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.NRG_Cmd_comboBox.FormattingEnabled = true;
            this.NRG_Cmd_comboBox.Items.AddRange(new object[] {
            "NOR",
            "DMY",
            "VER",
            "INIT"});
            this.NRG_Cmd_comboBox.Location = new System.Drawing.Point(134, 30);
            this.NRG_Cmd_comboBox.Name = "NRG_Cmd_comboBox";
            this.NRG_Cmd_comboBox.Size = new System.Drawing.Size(121, 20);
            this.NRG_Cmd_comboBox.TabIndex = 47;
            // 
            // NRG16_EM_Groupbox
            // 
            this.NRG16_EM_Groupbox.Controls.Add(this.NRG_Ch31_CheckBox);
            this.NRG16_EM_Groupbox.Controls.Add(this.NRG_Ch32_CheckBox);
            this.NRG16_EM_Groupbox.Controls.Add(this.NRG_Ch29_CheckBox);
            this.NRG16_EM_Groupbox.Controls.Add(this.NRG_Ch30_CheckBox);
            this.NRG16_EM_Groupbox.Controls.Add(this.NRG_Ch25_CheckBox);
            this.NRG16_EM_Groupbox.Controls.Add(this.NRG_Ch26_CheckBox);
            this.NRG16_EM_Groupbox.Controls.Add(this.NRG_Ch27_CheckBox);
            this.NRG16_EM_Groupbox.Controls.Add(this.NRG_Ch28_CheckBox);
            this.NRG16_EM_Groupbox.Controls.Add(this.NRG_Ch23_CheckBox);
            this.NRG16_EM_Groupbox.Controls.Add(this.NRG_Ch24_CheckBox);
            this.NRG16_EM_Groupbox.Controls.Add(this.NRG_Ch21_CheckBox);
            this.NRG16_EM_Groupbox.Controls.Add(this.NRG_Ch22_CheckBox);
            this.NRG16_EM_Groupbox.Controls.Add(this.NRG_Ch17_CheckBox);
            this.NRG16_EM_Groupbox.Controls.Add(this.NRG_Ch18_CheckBox);
            this.NRG16_EM_Groupbox.Controls.Add(this.NRG_Ch19_CheckBox);
            this.NRG16_EM_Groupbox.Controls.Add(this.NRG_Ch20_CheckBox);
            this.NRG16_EM_Groupbox.Location = new System.Drawing.Point(7, 178);
            this.NRG16_EM_Groupbox.Name = "NRG16_EM_Groupbox";
            this.NRG16_EM_Groupbox.Size = new System.Drawing.Size(467, 101);
            this.NRG16_EM_Groupbox.TabIndex = 39;
            this.NRG16_EM_Groupbox.TabStop = false;
            this.NRG16_EM_Groupbox.Text = "EM";
            // 
            // NRG_Ch31_CheckBox
            // 
            this.NRG_Ch31_CheckBox.AutoSize = true;
            this.NRG_Ch31_CheckBox.Location = new System.Drawing.Point(350, 60);
            this.NRG_Ch31_CheckBox.Name = "NRG_Ch31_CheckBox";
            this.NRG_Ch31_CheckBox.Size = new System.Drawing.Size(52, 16);
            this.NRG_Ch31_CheckBox.TabIndex = 32;
            this.NRG_Ch31_CheckBox.Text = "Ch15";
            this.NRG_Ch31_CheckBox.UseVisualStyleBackColor = true;
            this.NRG_Ch31_CheckBox.CheckedChanged += new System.EventHandler(this.NRG_Ch31_CheckBox_CheckedChanged);
            // 
            // NRG_Ch32_CheckBox
            // 
            this.NRG_Ch32_CheckBox.AutoSize = true;
            this.NRG_Ch32_CheckBox.Location = new System.Drawing.Point(408, 60);
            this.NRG_Ch32_CheckBox.Name = "NRG_Ch32_CheckBox";
            this.NRG_Ch32_CheckBox.Size = new System.Drawing.Size(52, 16);
            this.NRG_Ch32_CheckBox.TabIndex = 33;
            this.NRG_Ch32_CheckBox.Text = "Ch16";
            this.NRG_Ch32_CheckBox.UseVisualStyleBackColor = true;
            this.NRG_Ch32_CheckBox.CheckedChanged += new System.EventHandler(this.NRG_Ch32_CheckBox_CheckedChanged);
            // 
            // NRG_Ch29_CheckBox
            // 
            this.NRG_Ch29_CheckBox.AutoSize = true;
            this.NRG_Ch29_CheckBox.Location = new System.Drawing.Point(234, 60);
            this.NRG_Ch29_CheckBox.Name = "NRG_Ch29_CheckBox";
            this.NRG_Ch29_CheckBox.Size = new System.Drawing.Size(52, 16);
            this.NRG_Ch29_CheckBox.TabIndex = 30;
            this.NRG_Ch29_CheckBox.Text = "Ch13";
            this.NRG_Ch29_CheckBox.UseVisualStyleBackColor = true;
            this.NRG_Ch29_CheckBox.CheckedChanged += new System.EventHandler(this.NRG_Ch29_CheckBox_CheckedChanged);
            // 
            // NRG_Ch30_CheckBox
            // 
            this.NRG_Ch30_CheckBox.AutoSize = true;
            this.NRG_Ch30_CheckBox.Location = new System.Drawing.Point(292, 60);
            this.NRG_Ch30_CheckBox.Name = "NRG_Ch30_CheckBox";
            this.NRG_Ch30_CheckBox.Size = new System.Drawing.Size(52, 16);
            this.NRG_Ch30_CheckBox.TabIndex = 31;
            this.NRG_Ch30_CheckBox.Text = "Ch14";
            this.NRG_Ch30_CheckBox.UseVisualStyleBackColor = true;
            this.NRG_Ch30_CheckBox.CheckedChanged += new System.EventHandler(this.NRG_Ch30_CheckBox_CheckedChanged);
            // 
            // NRG_Ch25_CheckBox
            // 
            this.NRG_Ch25_CheckBox.AutoSize = true;
            this.NRG_Ch25_CheckBox.Location = new System.Drawing.Point(8, 60);
            this.NRG_Ch25_CheckBox.Name = "NRG_Ch25_CheckBox";
            this.NRG_Ch25_CheckBox.Size = new System.Drawing.Size(46, 16);
            this.NRG_Ch25_CheckBox.TabIndex = 26;
            this.NRG_Ch25_CheckBox.Text = "Ch9";
            this.NRG_Ch25_CheckBox.UseVisualStyleBackColor = true;
            this.NRG_Ch25_CheckBox.CheckedChanged += new System.EventHandler(this.NRG_Ch25_CheckBox_CheckedChanged);
            // 
            // NRG_Ch26_CheckBox
            // 
            this.NRG_Ch26_CheckBox.AutoSize = true;
            this.NRG_Ch26_CheckBox.Location = new System.Drawing.Point(60, 60);
            this.NRG_Ch26_CheckBox.Name = "NRG_Ch26_CheckBox";
            this.NRG_Ch26_CheckBox.Size = new System.Drawing.Size(52, 16);
            this.NRG_Ch26_CheckBox.TabIndex = 27;
            this.NRG_Ch26_CheckBox.Text = "Ch10";
            this.NRG_Ch26_CheckBox.UseVisualStyleBackColor = true;
            this.NRG_Ch26_CheckBox.CheckedChanged += new System.EventHandler(this.NRG_Ch26_CheckBox_CheckedChanged);
            // 
            // NRG_Ch27_CheckBox
            // 
            this.NRG_Ch27_CheckBox.AutoSize = true;
            this.NRG_Ch27_CheckBox.Location = new System.Drawing.Point(118, 60);
            this.NRG_Ch27_CheckBox.Name = "NRG_Ch27_CheckBox";
            this.NRG_Ch27_CheckBox.Size = new System.Drawing.Size(52, 16);
            this.NRG_Ch27_CheckBox.TabIndex = 28;
            this.NRG_Ch27_CheckBox.Text = "Ch11";
            this.NRG_Ch27_CheckBox.UseVisualStyleBackColor = true;
            this.NRG_Ch27_CheckBox.CheckedChanged += new System.EventHandler(this.NRG_Ch27_CheckBox_CheckedChanged);
            // 
            // NRG_Ch28_CheckBox
            // 
            this.NRG_Ch28_CheckBox.AutoSize = true;
            this.NRG_Ch28_CheckBox.Location = new System.Drawing.Point(176, 60);
            this.NRG_Ch28_CheckBox.Name = "NRG_Ch28_CheckBox";
            this.NRG_Ch28_CheckBox.Size = new System.Drawing.Size(52, 16);
            this.NRG_Ch28_CheckBox.TabIndex = 29;
            this.NRG_Ch28_CheckBox.Text = "Ch12";
            this.NRG_Ch28_CheckBox.UseVisualStyleBackColor = true;
            this.NRG_Ch28_CheckBox.CheckedChanged += new System.EventHandler(this.NRG_Ch28_CheckBox_CheckedChanged);
            // 
            // NRG_Ch23_CheckBox
            // 
            this.NRG_Ch23_CheckBox.AutoSize = true;
            this.NRG_Ch23_CheckBox.Location = new System.Drawing.Point(350, 25);
            this.NRG_Ch23_CheckBox.Name = "NRG_Ch23_CheckBox";
            this.NRG_Ch23_CheckBox.Size = new System.Drawing.Size(46, 16);
            this.NRG_Ch23_CheckBox.TabIndex = 24;
            this.NRG_Ch23_CheckBox.Text = "Ch7";
            this.NRG_Ch23_CheckBox.UseVisualStyleBackColor = true;
            this.NRG_Ch23_CheckBox.CheckedChanged += new System.EventHandler(this.NRG_Ch23_CheckBox_CheckedChanged);
            // 
            // NRG_Ch24_CheckBox
            // 
            this.NRG_Ch24_CheckBox.AutoSize = true;
            this.NRG_Ch24_CheckBox.Location = new System.Drawing.Point(408, 25);
            this.NRG_Ch24_CheckBox.Name = "NRG_Ch24_CheckBox";
            this.NRG_Ch24_CheckBox.Size = new System.Drawing.Size(46, 16);
            this.NRG_Ch24_CheckBox.TabIndex = 25;
            this.NRG_Ch24_CheckBox.Text = "Ch8";
            this.NRG_Ch24_CheckBox.UseVisualStyleBackColor = true;
            this.NRG_Ch24_CheckBox.CheckedChanged += new System.EventHandler(this.NRG_Ch24_CheckBox_CheckedChanged);
            // 
            // NRG_Ch21_CheckBox
            // 
            this.NRG_Ch21_CheckBox.AutoSize = true;
            this.NRG_Ch21_CheckBox.Location = new System.Drawing.Point(234, 25);
            this.NRG_Ch21_CheckBox.Name = "NRG_Ch21_CheckBox";
            this.NRG_Ch21_CheckBox.Size = new System.Drawing.Size(46, 16);
            this.NRG_Ch21_CheckBox.TabIndex = 22;
            this.NRG_Ch21_CheckBox.Text = "Ch5";
            this.NRG_Ch21_CheckBox.UseVisualStyleBackColor = true;
            this.NRG_Ch21_CheckBox.CheckedChanged += new System.EventHandler(this.NRG_Ch21_CheckBox_CheckedChanged);
            // 
            // NRG_Ch22_CheckBox
            // 
            this.NRG_Ch22_CheckBox.AutoSize = true;
            this.NRG_Ch22_CheckBox.Location = new System.Drawing.Point(292, 25);
            this.NRG_Ch22_CheckBox.Name = "NRG_Ch22_CheckBox";
            this.NRG_Ch22_CheckBox.Size = new System.Drawing.Size(46, 16);
            this.NRG_Ch22_CheckBox.TabIndex = 23;
            this.NRG_Ch22_CheckBox.Text = "Ch6";
            this.NRG_Ch22_CheckBox.UseVisualStyleBackColor = true;
            this.NRG_Ch22_CheckBox.CheckedChanged += new System.EventHandler(this.NRG_Ch22_CheckBox_CheckedChanged);
            // 
            // NRG_Ch17_CheckBox
            // 
            this.NRG_Ch17_CheckBox.AutoSize = true;
            this.NRG_Ch17_CheckBox.Location = new System.Drawing.Point(8, 25);
            this.NRG_Ch17_CheckBox.Name = "NRG_Ch17_CheckBox";
            this.NRG_Ch17_CheckBox.Size = new System.Drawing.Size(46, 16);
            this.NRG_Ch17_CheckBox.TabIndex = 18;
            this.NRG_Ch17_CheckBox.Text = "Ch1";
            this.NRG_Ch17_CheckBox.UseVisualStyleBackColor = true;
            this.NRG_Ch17_CheckBox.CheckedChanged += new System.EventHandler(this.NRG_Ch17_CheckBox_CheckedChanged);
            // 
            // NRG_Ch18_CheckBox
            // 
            this.NRG_Ch18_CheckBox.AutoSize = true;
            this.NRG_Ch18_CheckBox.Location = new System.Drawing.Point(60, 25);
            this.NRG_Ch18_CheckBox.Name = "NRG_Ch18_CheckBox";
            this.NRG_Ch18_CheckBox.Size = new System.Drawing.Size(46, 16);
            this.NRG_Ch18_CheckBox.TabIndex = 19;
            this.NRG_Ch18_CheckBox.Text = "Ch2";
            this.NRG_Ch18_CheckBox.UseVisualStyleBackColor = true;
            this.NRG_Ch18_CheckBox.CheckedChanged += new System.EventHandler(this.NRG_Ch18_CheckBox_CheckedChanged);
            // 
            // NRG_Ch19_CheckBox
            // 
            this.NRG_Ch19_CheckBox.AutoSize = true;
            this.NRG_Ch19_CheckBox.Location = new System.Drawing.Point(118, 25);
            this.NRG_Ch19_CheckBox.Name = "NRG_Ch19_CheckBox";
            this.NRG_Ch19_CheckBox.Size = new System.Drawing.Size(46, 16);
            this.NRG_Ch19_CheckBox.TabIndex = 20;
            this.NRG_Ch19_CheckBox.Text = "Ch3";
            this.NRG_Ch19_CheckBox.UseVisualStyleBackColor = true;
            this.NRG_Ch19_CheckBox.CheckedChanged += new System.EventHandler(this.NRG_Ch19_CheckBox_CheckedChanged);
            // 
            // NRG_Ch20_CheckBox
            // 
            this.NRG_Ch20_CheckBox.AutoSize = true;
            this.NRG_Ch20_CheckBox.Location = new System.Drawing.Point(176, 25);
            this.NRG_Ch20_CheckBox.Name = "NRG_Ch20_CheckBox";
            this.NRG_Ch20_CheckBox.Size = new System.Drawing.Size(46, 16);
            this.NRG_Ch20_CheckBox.TabIndex = 21;
            this.NRG_Ch20_CheckBox.Text = "Ch4";
            this.NRG_Ch20_CheckBox.UseVisualStyleBackColor = true;
            this.NRG_Ch20_CheckBox.CheckedChanged += new System.EventHandler(this.NRG_Ch20_CheckBox_CheckedChanged);
            // 
            // NRG16_Normal_Groupbox
            // 
            this.NRG16_Normal_Groupbox.Controls.Add(this.NRG_Ch15_CheckBox);
            this.NRG16_Normal_Groupbox.Controls.Add(this.NRG_Ch16_CheckBox);
            this.NRG16_Normal_Groupbox.Controls.Add(this.NRG_Ch13_CheckBox);
            this.NRG16_Normal_Groupbox.Controls.Add(this.NRG_Ch14_CheckBox);
            this.NRG16_Normal_Groupbox.Controls.Add(this.NRG_Ch9_CheckBox);
            this.NRG16_Normal_Groupbox.Controls.Add(this.NRG_Ch10_CheckBox);
            this.NRG16_Normal_Groupbox.Controls.Add(this.NRG_Ch11_CheckBox);
            this.NRG16_Normal_Groupbox.Controls.Add(this.NRG_Ch12_CheckBox);
            this.NRG16_Normal_Groupbox.Controls.Add(this.NRG_Ch7_CheckBox);
            this.NRG16_Normal_Groupbox.Controls.Add(this.NRG_Ch8_CheckBox);
            this.NRG16_Normal_Groupbox.Controls.Add(this.NRG_Ch5_CheckBox);
            this.NRG16_Normal_Groupbox.Controls.Add(this.NRG_Ch6_CheckBox);
            this.NRG16_Normal_Groupbox.Controls.Add(this.NRG_Ch1_CheckBox);
            this.NRG16_Normal_Groupbox.Controls.Add(this.NRG_Ch2_CheckBox);
            this.NRG16_Normal_Groupbox.Controls.Add(this.NRG_Ch3_CheckBox);
            this.NRG16_Normal_Groupbox.Controls.Add(this.NRG_Ch4_CheckBox);
            this.NRG16_Normal_Groupbox.Location = new System.Drawing.Point(7, 64);
            this.NRG16_Normal_Groupbox.Name = "NRG16_Normal_Groupbox";
            this.NRG16_Normal_Groupbox.Size = new System.Drawing.Size(467, 101);
            this.NRG16_Normal_Groupbox.TabIndex = 38;
            this.NRG16_Normal_Groupbox.TabStop = false;
            this.NRG16_Normal_Groupbox.Text = "Normal";
            // 
            // NRG_Ch15_CheckBox
            // 
            this.NRG_Ch15_CheckBox.AutoSize = true;
            this.NRG_Ch15_CheckBox.Location = new System.Drawing.Point(350, 60);
            this.NRG_Ch15_CheckBox.Name = "NRG_Ch15_CheckBox";
            this.NRG_Ch15_CheckBox.Size = new System.Drawing.Size(52, 16);
            this.NRG_Ch15_CheckBox.TabIndex = 32;
            this.NRG_Ch15_CheckBox.Text = "Ch15";
            this.NRG_Ch15_CheckBox.UseVisualStyleBackColor = true;
            this.NRG_Ch15_CheckBox.CheckedChanged += new System.EventHandler(this.NRG_Ch15_CheckBox_CheckedChanged);
            // 
            // NRG_Ch16_CheckBox
            // 
            this.NRG_Ch16_CheckBox.AutoSize = true;
            this.NRG_Ch16_CheckBox.Location = new System.Drawing.Point(408, 60);
            this.NRG_Ch16_CheckBox.Name = "NRG_Ch16_CheckBox";
            this.NRG_Ch16_CheckBox.Size = new System.Drawing.Size(52, 16);
            this.NRG_Ch16_CheckBox.TabIndex = 33;
            this.NRG_Ch16_CheckBox.Text = "Ch16";
            this.NRG_Ch16_CheckBox.UseVisualStyleBackColor = true;
            this.NRG_Ch16_CheckBox.CheckedChanged += new System.EventHandler(this.NRG_Ch16_CheckBox_CheckedChanged);
            // 
            // NRG_Ch13_CheckBox
            // 
            this.NRG_Ch13_CheckBox.AutoSize = true;
            this.NRG_Ch13_CheckBox.Location = new System.Drawing.Point(234, 60);
            this.NRG_Ch13_CheckBox.Name = "NRG_Ch13_CheckBox";
            this.NRG_Ch13_CheckBox.Size = new System.Drawing.Size(52, 16);
            this.NRG_Ch13_CheckBox.TabIndex = 30;
            this.NRG_Ch13_CheckBox.Text = "Ch13";
            this.NRG_Ch13_CheckBox.UseVisualStyleBackColor = true;
            this.NRG_Ch13_CheckBox.CheckedChanged += new System.EventHandler(this.NRG_Ch13_CheckBox_CheckedChanged);
            // 
            // NRG_Ch14_CheckBox
            // 
            this.NRG_Ch14_CheckBox.AutoSize = true;
            this.NRG_Ch14_CheckBox.Location = new System.Drawing.Point(292, 60);
            this.NRG_Ch14_CheckBox.Name = "NRG_Ch14_CheckBox";
            this.NRG_Ch14_CheckBox.Size = new System.Drawing.Size(52, 16);
            this.NRG_Ch14_CheckBox.TabIndex = 31;
            this.NRG_Ch14_CheckBox.Text = "Ch14";
            this.NRG_Ch14_CheckBox.UseVisualStyleBackColor = true;
            this.NRG_Ch14_CheckBox.CheckedChanged += new System.EventHandler(this.NRG_Ch14_CheckBox_CheckedChanged);
            // 
            // NRG_Ch9_CheckBox
            // 
            this.NRG_Ch9_CheckBox.AutoSize = true;
            this.NRG_Ch9_CheckBox.Location = new System.Drawing.Point(8, 60);
            this.NRG_Ch9_CheckBox.Name = "NRG_Ch9_CheckBox";
            this.NRG_Ch9_CheckBox.Size = new System.Drawing.Size(46, 16);
            this.NRG_Ch9_CheckBox.TabIndex = 26;
            this.NRG_Ch9_CheckBox.Text = "Ch9";
            this.NRG_Ch9_CheckBox.UseVisualStyleBackColor = true;
            this.NRG_Ch9_CheckBox.CheckedChanged += new System.EventHandler(this.NRG_Ch9_CheckBox_CheckedChanged);
            // 
            // NRG_Ch10_CheckBox
            // 
            this.NRG_Ch10_CheckBox.AutoSize = true;
            this.NRG_Ch10_CheckBox.Location = new System.Drawing.Point(60, 60);
            this.NRG_Ch10_CheckBox.Name = "NRG_Ch10_CheckBox";
            this.NRG_Ch10_CheckBox.Size = new System.Drawing.Size(52, 16);
            this.NRG_Ch10_CheckBox.TabIndex = 27;
            this.NRG_Ch10_CheckBox.Text = "Ch10";
            this.NRG_Ch10_CheckBox.UseVisualStyleBackColor = true;
            this.NRG_Ch10_CheckBox.CheckedChanged += new System.EventHandler(this.NRG_Ch10_CheckBox_CheckedChanged);
            // 
            // NRG_Ch11_CheckBox
            // 
            this.NRG_Ch11_CheckBox.AutoSize = true;
            this.NRG_Ch11_CheckBox.Location = new System.Drawing.Point(118, 60);
            this.NRG_Ch11_CheckBox.Name = "NRG_Ch11_CheckBox";
            this.NRG_Ch11_CheckBox.Size = new System.Drawing.Size(52, 16);
            this.NRG_Ch11_CheckBox.TabIndex = 28;
            this.NRG_Ch11_CheckBox.Text = "Ch11";
            this.NRG_Ch11_CheckBox.UseVisualStyleBackColor = true;
            this.NRG_Ch11_CheckBox.CheckedChanged += new System.EventHandler(this.NRG_Ch11_CheckBox_CheckedChanged);
            // 
            // NRG_Ch12_CheckBox
            // 
            this.NRG_Ch12_CheckBox.AutoSize = true;
            this.NRG_Ch12_CheckBox.Location = new System.Drawing.Point(176, 60);
            this.NRG_Ch12_CheckBox.Name = "NRG_Ch12_CheckBox";
            this.NRG_Ch12_CheckBox.Size = new System.Drawing.Size(52, 16);
            this.NRG_Ch12_CheckBox.TabIndex = 29;
            this.NRG_Ch12_CheckBox.Text = "Ch12";
            this.NRG_Ch12_CheckBox.UseVisualStyleBackColor = true;
            this.NRG_Ch12_CheckBox.CheckedChanged += new System.EventHandler(this.NRG_Ch12_CheckBox_CheckedChanged);
            // 
            // NRG_Ch7_CheckBox
            // 
            this.NRG_Ch7_CheckBox.AutoSize = true;
            this.NRG_Ch7_CheckBox.Location = new System.Drawing.Point(350, 25);
            this.NRG_Ch7_CheckBox.Name = "NRG_Ch7_CheckBox";
            this.NRG_Ch7_CheckBox.Size = new System.Drawing.Size(46, 16);
            this.NRG_Ch7_CheckBox.TabIndex = 24;
            this.NRG_Ch7_CheckBox.Text = "Ch7";
            this.NRG_Ch7_CheckBox.UseVisualStyleBackColor = true;
            this.NRG_Ch7_CheckBox.CheckedChanged += new System.EventHandler(this.NRG_Ch7_CheckBox_CheckedChanged);
            // 
            // NRG_Ch8_CheckBox
            // 
            this.NRG_Ch8_CheckBox.AutoSize = true;
            this.NRG_Ch8_CheckBox.Location = new System.Drawing.Point(408, 25);
            this.NRG_Ch8_CheckBox.Name = "NRG_Ch8_CheckBox";
            this.NRG_Ch8_CheckBox.Size = new System.Drawing.Size(46, 16);
            this.NRG_Ch8_CheckBox.TabIndex = 25;
            this.NRG_Ch8_CheckBox.Text = "Ch8";
            this.NRG_Ch8_CheckBox.UseVisualStyleBackColor = true;
            this.NRG_Ch8_CheckBox.CheckedChanged += new System.EventHandler(this.NRG_Ch8_CheckBox_CheckedChanged);
            // 
            // NRG_Ch5_CheckBox
            // 
            this.NRG_Ch5_CheckBox.AutoSize = true;
            this.NRG_Ch5_CheckBox.Location = new System.Drawing.Point(234, 25);
            this.NRG_Ch5_CheckBox.Name = "NRG_Ch5_CheckBox";
            this.NRG_Ch5_CheckBox.Size = new System.Drawing.Size(46, 16);
            this.NRG_Ch5_CheckBox.TabIndex = 22;
            this.NRG_Ch5_CheckBox.Text = "Ch5";
            this.NRG_Ch5_CheckBox.UseVisualStyleBackColor = true;
            this.NRG_Ch5_CheckBox.CheckedChanged += new System.EventHandler(this.NRG_Ch5_CheckBox_CheckedChanged);
            // 
            // NRG_Ch6_CheckBox
            // 
            this.NRG_Ch6_CheckBox.AutoSize = true;
            this.NRG_Ch6_CheckBox.Location = new System.Drawing.Point(292, 25);
            this.NRG_Ch6_CheckBox.Name = "NRG_Ch6_CheckBox";
            this.NRG_Ch6_CheckBox.Size = new System.Drawing.Size(46, 16);
            this.NRG_Ch6_CheckBox.TabIndex = 23;
            this.NRG_Ch6_CheckBox.Text = "Ch6";
            this.NRG_Ch6_CheckBox.UseVisualStyleBackColor = true;
            this.NRG_Ch6_CheckBox.CheckedChanged += new System.EventHandler(this.NRG_Ch6_CheckBox_CheckedChanged);
            // 
            // NRG_Ch1_CheckBox
            // 
            this.NRG_Ch1_CheckBox.AutoSize = true;
            this.NRG_Ch1_CheckBox.Location = new System.Drawing.Point(8, 25);
            this.NRG_Ch1_CheckBox.Name = "NRG_Ch1_CheckBox";
            this.NRG_Ch1_CheckBox.Size = new System.Drawing.Size(46, 16);
            this.NRG_Ch1_CheckBox.TabIndex = 18;
            this.NRG_Ch1_CheckBox.Text = "Ch1";
            this.NRG_Ch1_CheckBox.UseVisualStyleBackColor = true;
            this.NRG_Ch1_CheckBox.CheckedChanged += new System.EventHandler(this.NRG_Ch1_CheckBox_CheckedChanged);
            // 
            // NRG_Ch2_CheckBox
            // 
            this.NRG_Ch2_CheckBox.AutoSize = true;
            this.NRG_Ch2_CheckBox.Location = new System.Drawing.Point(60, 25);
            this.NRG_Ch2_CheckBox.Name = "NRG_Ch2_CheckBox";
            this.NRG_Ch2_CheckBox.Size = new System.Drawing.Size(46, 16);
            this.NRG_Ch2_CheckBox.TabIndex = 19;
            this.NRG_Ch2_CheckBox.Text = "Ch2";
            this.NRG_Ch2_CheckBox.UseVisualStyleBackColor = true;
            this.NRG_Ch2_CheckBox.CheckedChanged += new System.EventHandler(this.NRG_Ch2_CheckBox_CheckedChanged);
            // 
            // NRG_Ch3_CheckBox
            // 
            this.NRG_Ch3_CheckBox.AutoSize = true;
            this.NRG_Ch3_CheckBox.Location = new System.Drawing.Point(118, 25);
            this.NRG_Ch3_CheckBox.Name = "NRG_Ch3_CheckBox";
            this.NRG_Ch3_CheckBox.Size = new System.Drawing.Size(46, 16);
            this.NRG_Ch3_CheckBox.TabIndex = 20;
            this.NRG_Ch3_CheckBox.Text = "Ch3";
            this.NRG_Ch3_CheckBox.UseVisualStyleBackColor = true;
            this.NRG_Ch3_CheckBox.CheckedChanged += new System.EventHandler(this.NRG_Ch3_CheckBox_CheckedChanged);
            // 
            // NRG_Ch4_CheckBox
            // 
            this.NRG_Ch4_CheckBox.AutoSize = true;
            this.NRG_Ch4_CheckBox.Location = new System.Drawing.Point(176, 25);
            this.NRG_Ch4_CheckBox.Name = "NRG_Ch4_CheckBox";
            this.NRG_Ch4_CheckBox.Size = new System.Drawing.Size(46, 16);
            this.NRG_Ch4_CheckBox.TabIndex = 21;
            this.NRG_Ch4_CheckBox.Text = "Ch4";
            this.NRG_Ch4_CheckBox.UseVisualStyleBackColor = true;
            this.NRG_Ch4_CheckBox.CheckedChanged += new System.EventHandler(this.NRG_Ch4_CheckBox_CheckedChanged);
            // 
            // NRG16_ID_Label
            // 
            this.NRG16_ID_Label.AutoSize = true;
            this.NRG16_ID_Label.Location = new System.Drawing.Point(5, 15);
            this.NRG16_ID_Label.Name = "NRG16_ID_Label";
            this.NRG16_ID_Label.Size = new System.Drawing.Size(16, 12);
            this.NRG16_ID_Label.TabIndex = 44;
            this.NRG16_ID_Label.Text = "ID";
            // 
            // NRG_Insert_Button
            // 
            this.NRG_Insert_Button.Location = new System.Drawing.Point(434, 24);
            this.NRG_Insert_Button.Name = "NRG_Insert_Button";
            this.NRG_Insert_Button.Size = new System.Drawing.Size(44, 41);
            this.NRG_Insert_Button.TabIndex = 19;
            this.NRG_Insert_Button.Text = ">>";
            this.NRG_Insert_Button.UseVisualStyleBackColor = true;
            this.NRG_Insert_Button.Click += new System.EventHandler(this.NRG_Insert_Button_Click);
            // 
            // NRT16_TabPage
            // 
            this.NRT16_TabPage.Controls.Add(this.button5);
            this.NRT16_TabPage.Controls.Add(this.NRT16_CMD_Label);
            this.NRT16_TabPage.Controls.Add(this.NRT16_ID_1_comboBox);
            this.NRT16_TabPage.Controls.Add(this.NRT16_ID_10_comboBox);
            this.NRT16_TabPage.Controls.Add(this.NDT_Cmd_comboBox);
            this.NRT16_TabPage.Controls.Add(this.NDT_Insert_Button);
            this.NRT16_TabPage.Controls.Add(this.NRT16_ID_Label);
            this.NRT16_TabPage.Controls.Add(this.NRT16_EM_Groupbox);
            this.NRT16_TabPage.Controls.Add(this.NRT16_Normal_Groupbox);
            this.NRT16_TabPage.Location = new System.Drawing.Point(4, 22);
            this.NRT16_TabPage.Name = "NRT16_TabPage";
            this.NRT16_TabPage.Padding = new System.Windows.Forms.Padding(3);
            this.NRT16_TabPage.Size = new System.Drawing.Size(484, 625);
            this.NRT16_TabPage.TabIndex = 3;
            this.NRT16_TabPage.Text = "NRT16";
            this.NRT16_TabPage.UseVisualStyleBackColor = true;
            this.NRT16_TabPage.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // NRT16_CMD_Label
            // 
            this.NRT16_CMD_Label.AutoSize = true;
            this.NRT16_CMD_Label.Location = new System.Drawing.Point(132, 15);
            this.NRT16_CMD_Label.Name = "NRT16_CMD_Label";
            this.NRT16_CMD_Label.Size = new System.Drawing.Size(41, 12);
            this.NRT16_CMD_Label.TabIndex = 53;
            this.NRT16_CMD_Label.Text = "명령어";
            // 
            // NRT16_ID_1_comboBox
            // 
            this.NRT16_ID_1_comboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.NRT16_ID_1_comboBox.FormattingEnabled = true;
            this.NRT16_ID_1_comboBox.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "A",
            "B",
            "C",
            "D",
            "E",
            "F"});
            this.NRT16_ID_1_comboBox.Location = new System.Drawing.Point(71, 30);
            this.NRT16_ID_1_comboBox.Name = "NRT16_ID_1_comboBox";
            this.NRT16_ID_1_comboBox.Size = new System.Drawing.Size(57, 20);
            this.NRT16_ID_1_comboBox.TabIndex = 51;
            // 
            // NRT16_ID_10_comboBox
            // 
            this.NRT16_ID_10_comboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.NRT16_ID_10_comboBox.FormattingEnabled = true;
            this.NRT16_ID_10_comboBox.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "A",
            "B",
            "C",
            "D",
            "E",
            "F"});
            this.NRT16_ID_10_comboBox.Location = new System.Drawing.Point(7, 30);
            this.NRT16_ID_10_comboBox.Name = "NRT16_ID_10_comboBox";
            this.NRT16_ID_10_comboBox.Size = new System.Drawing.Size(57, 20);
            this.NRT16_ID_10_comboBox.TabIndex = 50;
            // 
            // NDT_Cmd_comboBox
            // 
            this.NDT_Cmd_comboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.NDT_Cmd_comboBox.FormattingEnabled = true;
            this.NDT_Cmd_comboBox.Items.AddRange(new object[] {
            "NOR",
            "DMY",
            "VER",
            "INIT"});
            this.NDT_Cmd_comboBox.Location = new System.Drawing.Point(134, 30);
            this.NDT_Cmd_comboBox.Name = "NDT_Cmd_comboBox";
            this.NDT_Cmd_comboBox.Size = new System.Drawing.Size(121, 20);
            this.NDT_Cmd_comboBox.TabIndex = 48;
            // 
            // NDT_Insert_Button
            // 
            this.NDT_Insert_Button.Location = new System.Drawing.Point(434, 24);
            this.NDT_Insert_Button.Name = "NDT_Insert_Button";
            this.NDT_Insert_Button.Size = new System.Drawing.Size(44, 41);
            this.NDT_Insert_Button.TabIndex = 48;
            this.NDT_Insert_Button.Text = ">>";
            this.NDT_Insert_Button.UseVisualStyleBackColor = true;
            this.NDT_Insert_Button.Click += new System.EventHandler(this.NDT_Insert_Button_Click);
            // 
            // NRT16_ID_Label
            // 
            this.NRT16_ID_Label.AutoSize = true;
            this.NRT16_ID_Label.Location = new System.Drawing.Point(5, 15);
            this.NRT16_ID_Label.Name = "NRT16_ID_Label";
            this.NRT16_ID_Label.Size = new System.Drawing.Size(16, 12);
            this.NRT16_ID_Label.TabIndex = 40;
            this.NRT16_ID_Label.Text = "ID";
            // 
            // NRT16_EM_Groupbox
            // 
            this.NRT16_EM_Groupbox.Controls.Add(this.NDT_Ch31_CheckBox);
            this.NRT16_EM_Groupbox.Controls.Add(this.NDT_Ch32_CheckBox);
            this.NRT16_EM_Groupbox.Controls.Add(this.NDT_Ch29_CheckBox);
            this.NRT16_EM_Groupbox.Controls.Add(this.NDT_Ch30_CheckBox);
            this.NRT16_EM_Groupbox.Controls.Add(this.NDT_Ch25_CheckBox);
            this.NRT16_EM_Groupbox.Controls.Add(this.NDT_Ch26_CheckBox);
            this.NRT16_EM_Groupbox.Controls.Add(this.NDT_Ch27_CheckBox);
            this.NRT16_EM_Groupbox.Controls.Add(this.NDT_Ch28_CheckBox);
            this.NRT16_EM_Groupbox.Controls.Add(this.NDT_Ch23_CheckBox);
            this.NRT16_EM_Groupbox.Controls.Add(this.NDT_Ch24_CheckBox);
            this.NRT16_EM_Groupbox.Controls.Add(this.NDT_Ch21_CheckBox);
            this.NRT16_EM_Groupbox.Controls.Add(this.NDT_Ch22_CheckBox);
            this.NRT16_EM_Groupbox.Controls.Add(this.NDT_Ch17_CheckBox);
            this.NRT16_EM_Groupbox.Controls.Add(this.NDT_Ch18_CheckBox);
            this.NRT16_EM_Groupbox.Controls.Add(this.NDT_Ch19_CheckBox);
            this.NRT16_EM_Groupbox.Controls.Add(this.NDT_Ch20_CheckBox);
            this.NRT16_EM_Groupbox.Location = new System.Drawing.Point(7, 178);
            this.NRT16_EM_Groupbox.Name = "NRT16_EM_Groupbox";
            this.NRT16_EM_Groupbox.Size = new System.Drawing.Size(467, 101);
            this.NRT16_EM_Groupbox.TabIndex = 39;
            this.NRT16_EM_Groupbox.TabStop = false;
            this.NRT16_EM_Groupbox.Text = "EM";
            // 
            // NDT_Ch31_CheckBox
            // 
            this.NDT_Ch31_CheckBox.AutoSize = true;
            this.NDT_Ch31_CheckBox.Location = new System.Drawing.Point(350, 60);
            this.NDT_Ch31_CheckBox.Name = "NDT_Ch31_CheckBox";
            this.NDT_Ch31_CheckBox.Size = new System.Drawing.Size(52, 16);
            this.NDT_Ch31_CheckBox.TabIndex = 32;
            this.NDT_Ch31_CheckBox.Text = "Ch15";
            this.NDT_Ch31_CheckBox.UseVisualStyleBackColor = true;
            this.NDT_Ch31_CheckBox.CheckedChanged += new System.EventHandler(this.NDT_Ch31_CheckBox_CheckedChanged);
            // 
            // NDT_Ch32_CheckBox
            // 
            this.NDT_Ch32_CheckBox.AutoSize = true;
            this.NDT_Ch32_CheckBox.Location = new System.Drawing.Point(408, 60);
            this.NDT_Ch32_CheckBox.Name = "NDT_Ch32_CheckBox";
            this.NDT_Ch32_CheckBox.Size = new System.Drawing.Size(52, 16);
            this.NDT_Ch32_CheckBox.TabIndex = 33;
            this.NDT_Ch32_CheckBox.Text = "Ch16";
            this.NDT_Ch32_CheckBox.UseVisualStyleBackColor = true;
            this.NDT_Ch32_CheckBox.CheckedChanged += new System.EventHandler(this.NDT_Ch32_CheckBox_CheckedChanged);
            // 
            // NDT_Ch29_CheckBox
            // 
            this.NDT_Ch29_CheckBox.AutoSize = true;
            this.NDT_Ch29_CheckBox.Location = new System.Drawing.Point(234, 60);
            this.NDT_Ch29_CheckBox.Name = "NDT_Ch29_CheckBox";
            this.NDT_Ch29_CheckBox.Size = new System.Drawing.Size(52, 16);
            this.NDT_Ch29_CheckBox.TabIndex = 30;
            this.NDT_Ch29_CheckBox.Text = "Ch13";
            this.NDT_Ch29_CheckBox.UseVisualStyleBackColor = true;
            this.NDT_Ch29_CheckBox.CheckedChanged += new System.EventHandler(this.NDT_Ch29_CheckBox_CheckedChanged);
            // 
            // NDT_Ch30_CheckBox
            // 
            this.NDT_Ch30_CheckBox.AutoSize = true;
            this.NDT_Ch30_CheckBox.Location = new System.Drawing.Point(292, 60);
            this.NDT_Ch30_CheckBox.Name = "NDT_Ch30_CheckBox";
            this.NDT_Ch30_CheckBox.Size = new System.Drawing.Size(52, 16);
            this.NDT_Ch30_CheckBox.TabIndex = 31;
            this.NDT_Ch30_CheckBox.Text = "Ch14";
            this.NDT_Ch30_CheckBox.UseVisualStyleBackColor = true;
            this.NDT_Ch30_CheckBox.CheckedChanged += new System.EventHandler(this.NDT_Ch30_CheckBox_CheckedChanged);
            // 
            // NDT_Ch25_CheckBox
            // 
            this.NDT_Ch25_CheckBox.AutoSize = true;
            this.NDT_Ch25_CheckBox.Location = new System.Drawing.Point(8, 60);
            this.NDT_Ch25_CheckBox.Name = "NDT_Ch25_CheckBox";
            this.NDT_Ch25_CheckBox.Size = new System.Drawing.Size(46, 16);
            this.NDT_Ch25_CheckBox.TabIndex = 26;
            this.NDT_Ch25_CheckBox.Text = "Ch9";
            this.NDT_Ch25_CheckBox.UseVisualStyleBackColor = true;
            this.NDT_Ch25_CheckBox.CheckedChanged += new System.EventHandler(this.NDT_Ch25_CheckBox_CheckedChanged);
            // 
            // NDT_Ch26_CheckBox
            // 
            this.NDT_Ch26_CheckBox.AutoSize = true;
            this.NDT_Ch26_CheckBox.Location = new System.Drawing.Point(60, 60);
            this.NDT_Ch26_CheckBox.Name = "NDT_Ch26_CheckBox";
            this.NDT_Ch26_CheckBox.Size = new System.Drawing.Size(52, 16);
            this.NDT_Ch26_CheckBox.TabIndex = 27;
            this.NDT_Ch26_CheckBox.Text = "Ch10";
            this.NDT_Ch26_CheckBox.UseVisualStyleBackColor = true;
            this.NDT_Ch26_CheckBox.CheckedChanged += new System.EventHandler(this.NDT_Ch26_CheckBox_CheckedChanged);
            // 
            // NDT_Ch27_CheckBox
            // 
            this.NDT_Ch27_CheckBox.AutoSize = true;
            this.NDT_Ch27_CheckBox.Location = new System.Drawing.Point(118, 60);
            this.NDT_Ch27_CheckBox.Name = "NDT_Ch27_CheckBox";
            this.NDT_Ch27_CheckBox.Size = new System.Drawing.Size(52, 16);
            this.NDT_Ch27_CheckBox.TabIndex = 28;
            this.NDT_Ch27_CheckBox.Text = "Ch11";
            this.NDT_Ch27_CheckBox.UseVisualStyleBackColor = true;
            this.NDT_Ch27_CheckBox.CheckedChanged += new System.EventHandler(this.NDT_Ch27_CheckBox_CheckedChanged);
            // 
            // NDT_Ch28_CheckBox
            // 
            this.NDT_Ch28_CheckBox.AutoSize = true;
            this.NDT_Ch28_CheckBox.Location = new System.Drawing.Point(176, 60);
            this.NDT_Ch28_CheckBox.Name = "NDT_Ch28_CheckBox";
            this.NDT_Ch28_CheckBox.Size = new System.Drawing.Size(52, 16);
            this.NDT_Ch28_CheckBox.TabIndex = 29;
            this.NDT_Ch28_CheckBox.Text = "Ch12";
            this.NDT_Ch28_CheckBox.UseVisualStyleBackColor = true;
            this.NDT_Ch28_CheckBox.CheckedChanged += new System.EventHandler(this.NDT_Ch28_CheckBox_CheckedChanged);
            // 
            // NDT_Ch23_CheckBox
            // 
            this.NDT_Ch23_CheckBox.AutoSize = true;
            this.NDT_Ch23_CheckBox.Location = new System.Drawing.Point(350, 25);
            this.NDT_Ch23_CheckBox.Name = "NDT_Ch23_CheckBox";
            this.NDT_Ch23_CheckBox.Size = new System.Drawing.Size(46, 16);
            this.NDT_Ch23_CheckBox.TabIndex = 24;
            this.NDT_Ch23_CheckBox.Text = "Ch7";
            this.NDT_Ch23_CheckBox.UseVisualStyleBackColor = true;
            this.NDT_Ch23_CheckBox.CheckedChanged += new System.EventHandler(this.NDT_Ch23_CheckBox_CheckedChanged);
            // 
            // NDT_Ch24_CheckBox
            // 
            this.NDT_Ch24_CheckBox.AutoSize = true;
            this.NDT_Ch24_CheckBox.Location = new System.Drawing.Point(408, 25);
            this.NDT_Ch24_CheckBox.Name = "NDT_Ch24_CheckBox";
            this.NDT_Ch24_CheckBox.Size = new System.Drawing.Size(46, 16);
            this.NDT_Ch24_CheckBox.TabIndex = 25;
            this.NDT_Ch24_CheckBox.Text = "Ch8";
            this.NDT_Ch24_CheckBox.UseVisualStyleBackColor = true;
            this.NDT_Ch24_CheckBox.CheckedChanged += new System.EventHandler(this.NDT_Ch24_CheckBox_CheckedChanged);
            // 
            // NDT_Ch21_CheckBox
            // 
            this.NDT_Ch21_CheckBox.AutoSize = true;
            this.NDT_Ch21_CheckBox.Location = new System.Drawing.Point(234, 25);
            this.NDT_Ch21_CheckBox.Name = "NDT_Ch21_CheckBox";
            this.NDT_Ch21_CheckBox.Size = new System.Drawing.Size(46, 16);
            this.NDT_Ch21_CheckBox.TabIndex = 22;
            this.NDT_Ch21_CheckBox.Text = "Ch5";
            this.NDT_Ch21_CheckBox.UseVisualStyleBackColor = true;
            this.NDT_Ch21_CheckBox.CheckedChanged += new System.EventHandler(this.NDT_Ch21_CheckBox_CheckedChanged);
            // 
            // NDT_Ch22_CheckBox
            // 
            this.NDT_Ch22_CheckBox.AutoSize = true;
            this.NDT_Ch22_CheckBox.Location = new System.Drawing.Point(292, 25);
            this.NDT_Ch22_CheckBox.Name = "NDT_Ch22_CheckBox";
            this.NDT_Ch22_CheckBox.Size = new System.Drawing.Size(46, 16);
            this.NDT_Ch22_CheckBox.TabIndex = 23;
            this.NDT_Ch22_CheckBox.Text = "Ch6";
            this.NDT_Ch22_CheckBox.UseVisualStyleBackColor = true;
            this.NDT_Ch22_CheckBox.CheckedChanged += new System.EventHandler(this.NDT_Ch22_CheckBox_CheckedChanged);
            // 
            // NDT_Ch17_CheckBox
            // 
            this.NDT_Ch17_CheckBox.AutoSize = true;
            this.NDT_Ch17_CheckBox.Location = new System.Drawing.Point(8, 25);
            this.NDT_Ch17_CheckBox.Name = "NDT_Ch17_CheckBox";
            this.NDT_Ch17_CheckBox.Size = new System.Drawing.Size(46, 16);
            this.NDT_Ch17_CheckBox.TabIndex = 18;
            this.NDT_Ch17_CheckBox.Text = "Ch1";
            this.NDT_Ch17_CheckBox.UseVisualStyleBackColor = true;
            this.NDT_Ch17_CheckBox.CheckedChanged += new System.EventHandler(this.NDT_Ch17_CheckBox_CheckedChanged);
            // 
            // NDT_Ch18_CheckBox
            // 
            this.NDT_Ch18_CheckBox.AutoSize = true;
            this.NDT_Ch18_CheckBox.Location = new System.Drawing.Point(60, 25);
            this.NDT_Ch18_CheckBox.Name = "NDT_Ch18_CheckBox";
            this.NDT_Ch18_CheckBox.Size = new System.Drawing.Size(46, 16);
            this.NDT_Ch18_CheckBox.TabIndex = 19;
            this.NDT_Ch18_CheckBox.Text = "Ch2";
            this.NDT_Ch18_CheckBox.UseVisualStyleBackColor = true;
            this.NDT_Ch18_CheckBox.CheckedChanged += new System.EventHandler(this.NDT_Ch18_CheckBox_CheckedChanged);
            // 
            // NDT_Ch19_CheckBox
            // 
            this.NDT_Ch19_CheckBox.AutoSize = true;
            this.NDT_Ch19_CheckBox.Location = new System.Drawing.Point(118, 25);
            this.NDT_Ch19_CheckBox.Name = "NDT_Ch19_CheckBox";
            this.NDT_Ch19_CheckBox.Size = new System.Drawing.Size(46, 16);
            this.NDT_Ch19_CheckBox.TabIndex = 20;
            this.NDT_Ch19_CheckBox.Text = "Ch3";
            this.NDT_Ch19_CheckBox.UseVisualStyleBackColor = true;
            this.NDT_Ch19_CheckBox.CheckedChanged += new System.EventHandler(this.NDT_Ch19_CheckBox_CheckedChanged);
            // 
            // NDT_Ch20_CheckBox
            // 
            this.NDT_Ch20_CheckBox.AutoSize = true;
            this.NDT_Ch20_CheckBox.Location = new System.Drawing.Point(176, 25);
            this.NDT_Ch20_CheckBox.Name = "NDT_Ch20_CheckBox";
            this.NDT_Ch20_CheckBox.Size = new System.Drawing.Size(46, 16);
            this.NDT_Ch20_CheckBox.TabIndex = 21;
            this.NDT_Ch20_CheckBox.Text = "Ch4";
            this.NDT_Ch20_CheckBox.UseVisualStyleBackColor = true;
            this.NDT_Ch20_CheckBox.CheckedChanged += new System.EventHandler(this.NDT_Ch20_CheckBox_CheckedChanged);
            // 
            // NRT16_Normal_Groupbox
            // 
            this.NRT16_Normal_Groupbox.Controls.Add(this.NDT_Ch15_CheckBox);
            this.NRT16_Normal_Groupbox.Controls.Add(this.NDT_Ch16_CheckBox);
            this.NRT16_Normal_Groupbox.Controls.Add(this.NDT_Ch13_CheckBox);
            this.NRT16_Normal_Groupbox.Controls.Add(this.NDT_Ch14_CheckBox);
            this.NRT16_Normal_Groupbox.Controls.Add(this.NDT_Ch9_CheckBox);
            this.NRT16_Normal_Groupbox.Controls.Add(this.NDT_Ch10_CheckBox);
            this.NRT16_Normal_Groupbox.Controls.Add(this.NDT_Ch11_CheckBox);
            this.NRT16_Normal_Groupbox.Controls.Add(this.NDT_Ch12_CheckBox);
            this.NRT16_Normal_Groupbox.Controls.Add(this.NDT_Ch7_CheckBox);
            this.NRT16_Normal_Groupbox.Controls.Add(this.NDT_Ch8_CheckBox);
            this.NRT16_Normal_Groupbox.Controls.Add(this.NDT_Ch5_CheckBox);
            this.NRT16_Normal_Groupbox.Controls.Add(this.NDT_Ch6_CheckBox);
            this.NRT16_Normal_Groupbox.Controls.Add(this.NDT_Ch1_CheckBox);
            this.NRT16_Normal_Groupbox.Controls.Add(this.NDT_Ch2_CheckBox);
            this.NRT16_Normal_Groupbox.Controls.Add(this.NDT_Ch3_CheckBox);
            this.NRT16_Normal_Groupbox.Controls.Add(this.NDT_Ch4_CheckBox);
            this.NRT16_Normal_Groupbox.Location = new System.Drawing.Point(7, 64);
            this.NRT16_Normal_Groupbox.Name = "NRT16_Normal_Groupbox";
            this.NRT16_Normal_Groupbox.Size = new System.Drawing.Size(467, 101);
            this.NRT16_Normal_Groupbox.TabIndex = 38;
            this.NRT16_Normal_Groupbox.TabStop = false;
            this.NRT16_Normal_Groupbox.Text = "Normal";
            // 
            // NDT_Ch15_CheckBox
            // 
            this.NDT_Ch15_CheckBox.AutoSize = true;
            this.NDT_Ch15_CheckBox.Location = new System.Drawing.Point(350, 60);
            this.NDT_Ch15_CheckBox.Name = "NDT_Ch15_CheckBox";
            this.NDT_Ch15_CheckBox.Size = new System.Drawing.Size(52, 16);
            this.NDT_Ch15_CheckBox.TabIndex = 32;
            this.NDT_Ch15_CheckBox.Text = "Ch15";
            this.NDT_Ch15_CheckBox.UseVisualStyleBackColor = true;
            this.NDT_Ch15_CheckBox.CheckedChanged += new System.EventHandler(this.NDT_Ch15_CheckBox_CheckedChanged);
            // 
            // NDT_Ch16_CheckBox
            // 
            this.NDT_Ch16_CheckBox.AutoSize = true;
            this.NDT_Ch16_CheckBox.Location = new System.Drawing.Point(408, 60);
            this.NDT_Ch16_CheckBox.Name = "NDT_Ch16_CheckBox";
            this.NDT_Ch16_CheckBox.Size = new System.Drawing.Size(52, 16);
            this.NDT_Ch16_CheckBox.TabIndex = 33;
            this.NDT_Ch16_CheckBox.Text = "Ch16";
            this.NDT_Ch16_CheckBox.UseVisualStyleBackColor = true;
            this.NDT_Ch16_CheckBox.CheckedChanged += new System.EventHandler(this.NDT_Ch16_CheckBox_CheckedChanged);
            // 
            // NDT_Ch13_CheckBox
            // 
            this.NDT_Ch13_CheckBox.AutoSize = true;
            this.NDT_Ch13_CheckBox.Location = new System.Drawing.Point(234, 60);
            this.NDT_Ch13_CheckBox.Name = "NDT_Ch13_CheckBox";
            this.NDT_Ch13_CheckBox.Size = new System.Drawing.Size(52, 16);
            this.NDT_Ch13_CheckBox.TabIndex = 30;
            this.NDT_Ch13_CheckBox.Text = "Ch13";
            this.NDT_Ch13_CheckBox.UseVisualStyleBackColor = true;
            this.NDT_Ch13_CheckBox.CheckedChanged += new System.EventHandler(this.NDT_Ch13_CheckBox_CheckedChanged);
            // 
            // NDT_Ch14_CheckBox
            // 
            this.NDT_Ch14_CheckBox.AutoSize = true;
            this.NDT_Ch14_CheckBox.Location = new System.Drawing.Point(292, 60);
            this.NDT_Ch14_CheckBox.Name = "NDT_Ch14_CheckBox";
            this.NDT_Ch14_CheckBox.Size = new System.Drawing.Size(52, 16);
            this.NDT_Ch14_CheckBox.TabIndex = 31;
            this.NDT_Ch14_CheckBox.Text = "Ch14";
            this.NDT_Ch14_CheckBox.UseVisualStyleBackColor = true;
            this.NDT_Ch14_CheckBox.CheckedChanged += new System.EventHandler(this.NDT_Ch14_CheckBox_CheckedChanged);
            // 
            // NDT_Ch9_CheckBox
            // 
            this.NDT_Ch9_CheckBox.AutoSize = true;
            this.NDT_Ch9_CheckBox.Location = new System.Drawing.Point(8, 60);
            this.NDT_Ch9_CheckBox.Name = "NDT_Ch9_CheckBox";
            this.NDT_Ch9_CheckBox.Size = new System.Drawing.Size(46, 16);
            this.NDT_Ch9_CheckBox.TabIndex = 26;
            this.NDT_Ch9_CheckBox.Text = "Ch9";
            this.NDT_Ch9_CheckBox.UseVisualStyleBackColor = true;
            this.NDT_Ch9_CheckBox.CheckedChanged += new System.EventHandler(this.NDT_Ch9_CheckBox_CheckedChanged);
            // 
            // NDT_Ch10_CheckBox
            // 
            this.NDT_Ch10_CheckBox.AutoSize = true;
            this.NDT_Ch10_CheckBox.Location = new System.Drawing.Point(60, 60);
            this.NDT_Ch10_CheckBox.Name = "NDT_Ch10_CheckBox";
            this.NDT_Ch10_CheckBox.Size = new System.Drawing.Size(52, 16);
            this.NDT_Ch10_CheckBox.TabIndex = 27;
            this.NDT_Ch10_CheckBox.Text = "Ch10";
            this.NDT_Ch10_CheckBox.UseVisualStyleBackColor = true;
            this.NDT_Ch10_CheckBox.CheckedChanged += new System.EventHandler(this.NDT_Ch10_CheckBox_CheckedChanged);
            // 
            // NDT_Ch11_CheckBox
            // 
            this.NDT_Ch11_CheckBox.AutoSize = true;
            this.NDT_Ch11_CheckBox.Location = new System.Drawing.Point(118, 60);
            this.NDT_Ch11_CheckBox.Name = "NDT_Ch11_CheckBox";
            this.NDT_Ch11_CheckBox.Size = new System.Drawing.Size(52, 16);
            this.NDT_Ch11_CheckBox.TabIndex = 28;
            this.NDT_Ch11_CheckBox.Text = "Ch11";
            this.NDT_Ch11_CheckBox.UseVisualStyleBackColor = true;
            this.NDT_Ch11_CheckBox.CheckedChanged += new System.EventHandler(this.NDT_Ch11_CheckBox_CheckedChanged);
            // 
            // NDT_Ch12_CheckBox
            // 
            this.NDT_Ch12_CheckBox.AutoSize = true;
            this.NDT_Ch12_CheckBox.Location = new System.Drawing.Point(176, 60);
            this.NDT_Ch12_CheckBox.Name = "NDT_Ch12_CheckBox";
            this.NDT_Ch12_CheckBox.Size = new System.Drawing.Size(52, 16);
            this.NDT_Ch12_CheckBox.TabIndex = 29;
            this.NDT_Ch12_CheckBox.Text = "Ch12";
            this.NDT_Ch12_CheckBox.UseVisualStyleBackColor = true;
            this.NDT_Ch12_CheckBox.CheckedChanged += new System.EventHandler(this.NDT_Ch12_CheckBox_CheckedChanged);
            // 
            // NDT_Ch7_CheckBox
            // 
            this.NDT_Ch7_CheckBox.AutoSize = true;
            this.NDT_Ch7_CheckBox.Location = new System.Drawing.Point(350, 25);
            this.NDT_Ch7_CheckBox.Name = "NDT_Ch7_CheckBox";
            this.NDT_Ch7_CheckBox.Size = new System.Drawing.Size(46, 16);
            this.NDT_Ch7_CheckBox.TabIndex = 24;
            this.NDT_Ch7_CheckBox.Text = "Ch7";
            this.NDT_Ch7_CheckBox.UseVisualStyleBackColor = true;
            this.NDT_Ch7_CheckBox.CheckedChanged += new System.EventHandler(this.NDT_Ch7_CheckBox_CheckedChanged);
            // 
            // NDT_Ch8_CheckBox
            // 
            this.NDT_Ch8_CheckBox.AutoSize = true;
            this.NDT_Ch8_CheckBox.Location = new System.Drawing.Point(408, 25);
            this.NDT_Ch8_CheckBox.Name = "NDT_Ch8_CheckBox";
            this.NDT_Ch8_CheckBox.Size = new System.Drawing.Size(46, 16);
            this.NDT_Ch8_CheckBox.TabIndex = 25;
            this.NDT_Ch8_CheckBox.Text = "Ch8";
            this.NDT_Ch8_CheckBox.UseVisualStyleBackColor = true;
            this.NDT_Ch8_CheckBox.CheckedChanged += new System.EventHandler(this.NDT_Ch8_CheckBox_CheckedChanged);
            // 
            // NDT_Ch5_CheckBox
            // 
            this.NDT_Ch5_CheckBox.AutoSize = true;
            this.NDT_Ch5_CheckBox.Location = new System.Drawing.Point(234, 25);
            this.NDT_Ch5_CheckBox.Name = "NDT_Ch5_CheckBox";
            this.NDT_Ch5_CheckBox.Size = new System.Drawing.Size(46, 16);
            this.NDT_Ch5_CheckBox.TabIndex = 22;
            this.NDT_Ch5_CheckBox.Text = "Ch5";
            this.NDT_Ch5_CheckBox.UseVisualStyleBackColor = true;
            this.NDT_Ch5_CheckBox.CheckedChanged += new System.EventHandler(this.NDT_Ch5_CheckBox_CheckedChanged);
            // 
            // NDT_Ch6_CheckBox
            // 
            this.NDT_Ch6_CheckBox.AutoSize = true;
            this.NDT_Ch6_CheckBox.Location = new System.Drawing.Point(292, 25);
            this.NDT_Ch6_CheckBox.Name = "NDT_Ch6_CheckBox";
            this.NDT_Ch6_CheckBox.Size = new System.Drawing.Size(46, 16);
            this.NDT_Ch6_CheckBox.TabIndex = 23;
            this.NDT_Ch6_CheckBox.Text = "Ch6";
            this.NDT_Ch6_CheckBox.UseVisualStyleBackColor = true;
            this.NDT_Ch6_CheckBox.CheckedChanged += new System.EventHandler(this.NDT_Ch6_CheckBox_CheckedChanged);
            // 
            // NDT_Ch1_CheckBox
            // 
            this.NDT_Ch1_CheckBox.AutoSize = true;
            this.NDT_Ch1_CheckBox.Location = new System.Drawing.Point(8, 25);
            this.NDT_Ch1_CheckBox.Name = "NDT_Ch1_CheckBox";
            this.NDT_Ch1_CheckBox.Size = new System.Drawing.Size(46, 16);
            this.NDT_Ch1_CheckBox.TabIndex = 18;
            this.NDT_Ch1_CheckBox.Text = "Ch1";
            this.NDT_Ch1_CheckBox.UseVisualStyleBackColor = true;
            this.NDT_Ch1_CheckBox.CheckedChanged += new System.EventHandler(this.NDT_Ch1_CheckBox_CheckedChanged);
            // 
            // NDT_Ch2_CheckBox
            // 
            this.NDT_Ch2_CheckBox.AutoSize = true;
            this.NDT_Ch2_CheckBox.Location = new System.Drawing.Point(60, 25);
            this.NDT_Ch2_CheckBox.Name = "NDT_Ch2_CheckBox";
            this.NDT_Ch2_CheckBox.Size = new System.Drawing.Size(46, 16);
            this.NDT_Ch2_CheckBox.TabIndex = 19;
            this.NDT_Ch2_CheckBox.Text = "Ch2";
            this.NDT_Ch2_CheckBox.UseVisualStyleBackColor = true;
            this.NDT_Ch2_CheckBox.CheckedChanged += new System.EventHandler(this.NDT_Ch2_CheckBox_CheckedChanged);
            // 
            // NDT_Ch3_CheckBox
            // 
            this.NDT_Ch3_CheckBox.AutoSize = true;
            this.NDT_Ch3_CheckBox.Location = new System.Drawing.Point(118, 25);
            this.NDT_Ch3_CheckBox.Name = "NDT_Ch3_CheckBox";
            this.NDT_Ch3_CheckBox.Size = new System.Drawing.Size(46, 16);
            this.NDT_Ch3_CheckBox.TabIndex = 20;
            this.NDT_Ch3_CheckBox.Text = "Ch3";
            this.NDT_Ch3_CheckBox.UseVisualStyleBackColor = true;
            this.NDT_Ch3_CheckBox.CheckedChanged += new System.EventHandler(this.NDT_Ch3_CheckBox_CheckedChanged);
            // 
            // NDT_Ch4_CheckBox
            // 
            this.NDT_Ch4_CheckBox.AutoSize = true;
            this.NDT_Ch4_CheckBox.Location = new System.Drawing.Point(176, 25);
            this.NDT_Ch4_CheckBox.Name = "NDT_Ch4_CheckBox";
            this.NDT_Ch4_CheckBox.Size = new System.Drawing.Size(46, 16);
            this.NDT_Ch4_CheckBox.TabIndex = 21;
            this.NDT_Ch4_CheckBox.Text = "Ch4";
            this.NDT_Ch4_CheckBox.UseVisualStyleBackColor = true;
            this.NDT_Ch4_CheckBox.CheckedChanged += new System.EventHandler(this.NDT_Ch4_CheckBox_CheckedChanged);
            // 
            // NRT40_TabPage
            // 
            this.NRT40_TabPage.Controls.Add(this.button6);
            this.NRT40_TabPage.Controls.Add(this.NRT40_CMD_Label);
            this.NRT40_TabPage.Controls.Add(this.NRT40_ID_1_comboBox);
            this.NRT40_TabPage.Controls.Add(this.NRT_Cmd_comboBox);
            this.NRT40_TabPage.Controls.Add(this.NRT40_ID_10_comboBox);
            this.NRT40_TabPage.Controls.Add(this.NRT_Insert_Button);
            this.NRT40_TabPage.Controls.Add(this.NRT40_ID_Label);
            this.NRT40_TabPage.Controls.Add(this.NRT40_Normal_Groupbox);
            this.NRT40_TabPage.Location = new System.Drawing.Point(4, 22);
            this.NRT40_TabPage.Name = "NRT40_TabPage";
            this.NRT40_TabPage.Padding = new System.Windows.Forms.Padding(3);
            this.NRT40_TabPage.Size = new System.Drawing.Size(484, 625);
            this.NRT40_TabPage.TabIndex = 4;
            this.NRT40_TabPage.Text = "NRT40";
            this.NRT40_TabPage.UseVisualStyleBackColor = true;
            // 
            // NRT40_CMD_Label
            // 
            this.NRT40_CMD_Label.AutoSize = true;
            this.NRT40_CMD_Label.Location = new System.Drawing.Point(132, 15);
            this.NRT40_CMD_Label.Name = "NRT40_CMD_Label";
            this.NRT40_CMD_Label.Size = new System.Drawing.Size(41, 12);
            this.NRT40_CMD_Label.TabIndex = 56;
            this.NRT40_CMD_Label.Text = "명령어";
            // 
            // NRT40_ID_1_comboBox
            // 
            this.NRT40_ID_1_comboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.NRT40_ID_1_comboBox.FormattingEnabled = true;
            this.NRT40_ID_1_comboBox.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "A",
            "B",
            "C",
            "D",
            "E",
            "F"});
            this.NRT40_ID_1_comboBox.Location = new System.Drawing.Point(71, 30);
            this.NRT40_ID_1_comboBox.Name = "NRT40_ID_1_comboBox";
            this.NRT40_ID_1_comboBox.Size = new System.Drawing.Size(57, 20);
            this.NRT40_ID_1_comboBox.TabIndex = 55;
            // 
            // NRT_Cmd_comboBox
            // 
            this.NRT_Cmd_comboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.NRT_Cmd_comboBox.FormattingEnabled = true;
            this.NRT_Cmd_comboBox.Items.AddRange(new object[] {
            "NOR",
            "DMY",
            "VER",
            "INIT"});
            this.NRT_Cmd_comboBox.Location = new System.Drawing.Point(134, 30);
            this.NRT_Cmd_comboBox.Name = "NRT_Cmd_comboBox";
            this.NRT_Cmd_comboBox.Size = new System.Drawing.Size(121, 20);
            this.NRT_Cmd_comboBox.TabIndex = 50;
            // 
            // NRT40_ID_10_comboBox
            // 
            this.NRT40_ID_10_comboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.NRT40_ID_10_comboBox.FormattingEnabled = true;
            this.NRT40_ID_10_comboBox.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "A",
            "B",
            "C",
            "D",
            "E",
            "F"});
            this.NRT40_ID_10_comboBox.Location = new System.Drawing.Point(7, 30);
            this.NRT40_ID_10_comboBox.Name = "NRT40_ID_10_comboBox";
            this.NRT40_ID_10_comboBox.Size = new System.Drawing.Size(57, 20);
            this.NRT40_ID_10_comboBox.TabIndex = 54;
            // 
            // NRT_Insert_Button
            // 
            this.NRT_Insert_Button.Location = new System.Drawing.Point(434, 24);
            this.NRT_Insert_Button.Name = "NRT_Insert_Button";
            this.NRT_Insert_Button.Size = new System.Drawing.Size(44, 41);
            this.NRT_Insert_Button.TabIndex = 51;
            this.NRT_Insert_Button.Text = ">>";
            this.NRT_Insert_Button.UseVisualStyleBackColor = true;
            this.NRT_Insert_Button.Click += new System.EventHandler(this.NRT_Insert_Button_Click);
            // 
            // NRT40_ID_Label
            // 
            this.NRT40_ID_Label.AutoSize = true;
            this.NRT40_ID_Label.Location = new System.Drawing.Point(5, 15);
            this.NRT40_ID_Label.Name = "NRT40_ID_Label";
            this.NRT40_ID_Label.Size = new System.Drawing.Size(16, 12);
            this.NRT40_ID_Label.TabIndex = 40;
            this.NRT40_ID_Label.Text = "ID";
            // 
            // NRT40_Normal_Groupbox
            // 
            this.NRT40_Normal_Groupbox.Controls.Add(this.NRT_Ch39_CheckBox);
            this.NRT40_Normal_Groupbox.Controls.Add(this.NRT_Ch40_CheckBox);
            this.NRT40_Normal_Groupbox.Controls.Add(this.NRT_Ch37_CheckBox);
            this.NRT40_Normal_Groupbox.Controls.Add(this.NRT_Ch38_CheckBox);
            this.NRT40_Normal_Groupbox.Controls.Add(this.NRT_Ch33_CheckBox);
            this.NRT40_Normal_Groupbox.Controls.Add(this.NRT_Ch34_CheckBox);
            this.NRT40_Normal_Groupbox.Controls.Add(this.NRT_Ch35_CheckBox);
            this.NRT40_Normal_Groupbox.Controls.Add(this.NRT_Ch36_CheckBox);
            this.NRT40_Normal_Groupbox.Controls.Add(this.NRT_Ch31_CheckBox);
            this.NRT40_Normal_Groupbox.Controls.Add(this.NRT_Ch32_CheckBox);
            this.NRT40_Normal_Groupbox.Controls.Add(this.NRT_Ch29_CheckBox);
            this.NRT40_Normal_Groupbox.Controls.Add(this.NRT_Ch30_CheckBox);
            this.NRT40_Normal_Groupbox.Controls.Add(this.NRT_Ch25_CheckBox);
            this.NRT40_Normal_Groupbox.Controls.Add(this.NRT_Ch26_CheckBox);
            this.NRT40_Normal_Groupbox.Controls.Add(this.NRT_Ch27_CheckBox);
            this.NRT40_Normal_Groupbox.Controls.Add(this.NRT_Ch28_CheckBox);
            this.NRT40_Normal_Groupbox.Controls.Add(this.NRT_Ch23_CheckBox);
            this.NRT40_Normal_Groupbox.Controls.Add(this.NRT_Ch24_CheckBox);
            this.NRT40_Normal_Groupbox.Controls.Add(this.NRT_Ch21_CheckBox);
            this.NRT40_Normal_Groupbox.Controls.Add(this.NRT_Ch22_CheckBox);
            this.NRT40_Normal_Groupbox.Controls.Add(this.NRT_Ch17_CheckBox);
            this.NRT40_Normal_Groupbox.Controls.Add(this.NRT_Ch18_CheckBox);
            this.NRT40_Normal_Groupbox.Controls.Add(this.NRT_Ch19_CheckBox);
            this.NRT40_Normal_Groupbox.Controls.Add(this.NRT_Ch20_CheckBox);
            this.NRT40_Normal_Groupbox.Controls.Add(this.NRT_Ch15_CheckBox);
            this.NRT40_Normal_Groupbox.Controls.Add(this.NRT_Ch16_CheckBox);
            this.NRT40_Normal_Groupbox.Controls.Add(this.NRT_Ch13_CheckBox);
            this.NRT40_Normal_Groupbox.Controls.Add(this.NRT_Ch14_CheckBox);
            this.NRT40_Normal_Groupbox.Controls.Add(this.NRT_Ch9_CheckBox);
            this.NRT40_Normal_Groupbox.Controls.Add(this.NRT_Ch10_CheckBox);
            this.NRT40_Normal_Groupbox.Controls.Add(this.NRT_Ch11_CheckBox);
            this.NRT40_Normal_Groupbox.Controls.Add(this.NRT_Ch12_CheckBox);
            this.NRT40_Normal_Groupbox.Controls.Add(this.NRT_Ch7_CheckBox);
            this.NRT40_Normal_Groupbox.Controls.Add(this.NRT_Ch8_CheckBox);
            this.NRT40_Normal_Groupbox.Controls.Add(this.NRT_Ch5_CheckBox);
            this.NRT40_Normal_Groupbox.Controls.Add(this.NRT_Ch6_CheckBox);
            this.NRT40_Normal_Groupbox.Controls.Add(this.NRT_Ch1_CheckBox);
            this.NRT40_Normal_Groupbox.Controls.Add(this.NRT_Ch2_CheckBox);
            this.NRT40_Normal_Groupbox.Controls.Add(this.NRT_Ch3_CheckBox);
            this.NRT40_Normal_Groupbox.Controls.Add(this.NRT_Ch4_CheckBox);
            this.NRT40_Normal_Groupbox.Location = new System.Drawing.Point(7, 64);
            this.NRT40_Normal_Groupbox.Name = "NRT40_Normal_Groupbox";
            this.NRT40_Normal_Groupbox.Size = new System.Drawing.Size(467, 262);
            this.NRT40_Normal_Groupbox.TabIndex = 38;
            this.NRT40_Normal_Groupbox.TabStop = false;
            this.NRT40_Normal_Groupbox.Text = "Normal";
            // 
            // NRT_Ch39_CheckBox
            // 
            this.NRT_Ch39_CheckBox.AutoSize = true;
            this.NRT_Ch39_CheckBox.Location = new System.Drawing.Point(349, 222);
            this.NRT_Ch39_CheckBox.Name = "NRT_Ch39_CheckBox";
            this.NRT_Ch39_CheckBox.Size = new System.Drawing.Size(52, 16);
            this.NRT_Ch39_CheckBox.TabIndex = 56;
            this.NRT_Ch39_CheckBox.Text = "Ch39";
            this.NRT_Ch39_CheckBox.UseVisualStyleBackColor = true;
            this.NRT_Ch39_CheckBox.CheckedChanged += new System.EventHandler(this.NRT_Ch39_CheckBox_CheckedChanged);
            // 
            // NRT_Ch40_CheckBox
            // 
            this.NRT_Ch40_CheckBox.AutoSize = true;
            this.NRT_Ch40_CheckBox.Location = new System.Drawing.Point(407, 222);
            this.NRT_Ch40_CheckBox.Name = "NRT_Ch40_CheckBox";
            this.NRT_Ch40_CheckBox.Size = new System.Drawing.Size(52, 16);
            this.NRT_Ch40_CheckBox.TabIndex = 57;
            this.NRT_Ch40_CheckBox.Text = "Ch40";
            this.NRT_Ch40_CheckBox.UseVisualStyleBackColor = true;
            this.NRT_Ch40_CheckBox.CheckedChanged += new System.EventHandler(this.NRT_Ch40_CheckBox_CheckedChanged);
            // 
            // NRT_Ch37_CheckBox
            // 
            this.NRT_Ch37_CheckBox.AutoSize = true;
            this.NRT_Ch37_CheckBox.Location = new System.Drawing.Point(233, 222);
            this.NRT_Ch37_CheckBox.Name = "NRT_Ch37_CheckBox";
            this.NRT_Ch37_CheckBox.Size = new System.Drawing.Size(52, 16);
            this.NRT_Ch37_CheckBox.TabIndex = 54;
            this.NRT_Ch37_CheckBox.Text = "Ch37";
            this.NRT_Ch37_CheckBox.UseVisualStyleBackColor = true;
            this.NRT_Ch37_CheckBox.CheckedChanged += new System.EventHandler(this.NRT_Ch37_CheckBox_CheckedChanged);
            // 
            // NRT_Ch38_CheckBox
            // 
            this.NRT_Ch38_CheckBox.AutoSize = true;
            this.NRT_Ch38_CheckBox.Location = new System.Drawing.Point(291, 222);
            this.NRT_Ch38_CheckBox.Name = "NRT_Ch38_CheckBox";
            this.NRT_Ch38_CheckBox.Size = new System.Drawing.Size(52, 16);
            this.NRT_Ch38_CheckBox.TabIndex = 55;
            this.NRT_Ch38_CheckBox.Text = "Ch38";
            this.NRT_Ch38_CheckBox.UseVisualStyleBackColor = true;
            this.NRT_Ch38_CheckBox.CheckedChanged += new System.EventHandler(this.NRT_Ch38_CheckBox_CheckedChanged);
            // 
            // NRT_Ch33_CheckBox
            // 
            this.NRT_Ch33_CheckBox.AutoSize = true;
            this.NRT_Ch33_CheckBox.Location = new System.Drawing.Point(7, 222);
            this.NRT_Ch33_CheckBox.Name = "NRT_Ch33_CheckBox";
            this.NRT_Ch33_CheckBox.Size = new System.Drawing.Size(52, 16);
            this.NRT_Ch33_CheckBox.TabIndex = 50;
            this.NRT_Ch33_CheckBox.Text = "Ch33";
            this.NRT_Ch33_CheckBox.UseVisualStyleBackColor = true;
            this.NRT_Ch33_CheckBox.CheckedChanged += new System.EventHandler(this.NRT_Ch33_CheckBox_CheckedChanged);
            // 
            // NRT_Ch34_CheckBox
            // 
            this.NRT_Ch34_CheckBox.AutoSize = true;
            this.NRT_Ch34_CheckBox.Location = new System.Drawing.Point(59, 222);
            this.NRT_Ch34_CheckBox.Name = "NRT_Ch34_CheckBox";
            this.NRT_Ch34_CheckBox.Size = new System.Drawing.Size(52, 16);
            this.NRT_Ch34_CheckBox.TabIndex = 51;
            this.NRT_Ch34_CheckBox.Text = "Ch34";
            this.NRT_Ch34_CheckBox.UseVisualStyleBackColor = true;
            this.NRT_Ch34_CheckBox.CheckedChanged += new System.EventHandler(this.NRT_Ch34_CheckBox_CheckedChanged);
            // 
            // NRT_Ch35_CheckBox
            // 
            this.NRT_Ch35_CheckBox.AutoSize = true;
            this.NRT_Ch35_CheckBox.Location = new System.Drawing.Point(117, 222);
            this.NRT_Ch35_CheckBox.Name = "NRT_Ch35_CheckBox";
            this.NRT_Ch35_CheckBox.Size = new System.Drawing.Size(52, 16);
            this.NRT_Ch35_CheckBox.TabIndex = 52;
            this.NRT_Ch35_CheckBox.Text = "Ch35";
            this.NRT_Ch35_CheckBox.UseVisualStyleBackColor = true;
            this.NRT_Ch35_CheckBox.CheckedChanged += new System.EventHandler(this.NRT_Ch35_CheckBox_CheckedChanged);
            // 
            // NRT_Ch36_CheckBox
            // 
            this.NRT_Ch36_CheckBox.AutoSize = true;
            this.NRT_Ch36_CheckBox.Location = new System.Drawing.Point(175, 222);
            this.NRT_Ch36_CheckBox.Name = "NRT_Ch36_CheckBox";
            this.NRT_Ch36_CheckBox.Size = new System.Drawing.Size(52, 16);
            this.NRT_Ch36_CheckBox.TabIndex = 53;
            this.NRT_Ch36_CheckBox.Text = "Ch36";
            this.NRT_Ch36_CheckBox.UseVisualStyleBackColor = true;
            this.NRT_Ch36_CheckBox.CheckedChanged += new System.EventHandler(this.NRT_Ch36_CheckBox_CheckedChanged);
            // 
            // NRT_Ch31_CheckBox
            // 
            this.NRT_Ch31_CheckBox.AutoSize = true;
            this.NRT_Ch31_CheckBox.Location = new System.Drawing.Point(349, 164);
            this.NRT_Ch31_CheckBox.Name = "NRT_Ch31_CheckBox";
            this.NRT_Ch31_CheckBox.Size = new System.Drawing.Size(52, 16);
            this.NRT_Ch31_CheckBox.TabIndex = 48;
            this.NRT_Ch31_CheckBox.Text = "Ch31";
            this.NRT_Ch31_CheckBox.UseVisualStyleBackColor = true;
            this.NRT_Ch31_CheckBox.CheckedChanged += new System.EventHandler(this.NRT_Ch31_CheckBox_CheckedChanged);
            // 
            // NRT_Ch32_CheckBox
            // 
            this.NRT_Ch32_CheckBox.AutoSize = true;
            this.NRT_Ch32_CheckBox.Location = new System.Drawing.Point(407, 164);
            this.NRT_Ch32_CheckBox.Name = "NRT_Ch32_CheckBox";
            this.NRT_Ch32_CheckBox.Size = new System.Drawing.Size(52, 16);
            this.NRT_Ch32_CheckBox.TabIndex = 49;
            this.NRT_Ch32_CheckBox.Text = "Ch32";
            this.NRT_Ch32_CheckBox.UseVisualStyleBackColor = true;
            this.NRT_Ch32_CheckBox.CheckedChanged += new System.EventHandler(this.NRT_Ch32_CheckBox_CheckedChanged);
            // 
            // NRT_Ch29_CheckBox
            // 
            this.NRT_Ch29_CheckBox.AutoSize = true;
            this.NRT_Ch29_CheckBox.Location = new System.Drawing.Point(233, 164);
            this.NRT_Ch29_CheckBox.Name = "NRT_Ch29_CheckBox";
            this.NRT_Ch29_CheckBox.Size = new System.Drawing.Size(52, 16);
            this.NRT_Ch29_CheckBox.TabIndex = 46;
            this.NRT_Ch29_CheckBox.Text = "Ch29";
            this.NRT_Ch29_CheckBox.UseVisualStyleBackColor = true;
            this.NRT_Ch29_CheckBox.CheckedChanged += new System.EventHandler(this.NRT_Ch29_CheckBox_CheckedChanged);
            // 
            // NRT_Ch30_CheckBox
            // 
            this.NRT_Ch30_CheckBox.AutoSize = true;
            this.NRT_Ch30_CheckBox.Location = new System.Drawing.Point(291, 164);
            this.NRT_Ch30_CheckBox.Name = "NRT_Ch30_CheckBox";
            this.NRT_Ch30_CheckBox.Size = new System.Drawing.Size(52, 16);
            this.NRT_Ch30_CheckBox.TabIndex = 47;
            this.NRT_Ch30_CheckBox.Text = "Ch30";
            this.NRT_Ch30_CheckBox.UseVisualStyleBackColor = true;
            this.NRT_Ch30_CheckBox.CheckedChanged += new System.EventHandler(this.NRT_Ch30_CheckBox_CheckedChanged);
            // 
            // NRT_Ch25_CheckBox
            // 
            this.NRT_Ch25_CheckBox.AutoSize = true;
            this.NRT_Ch25_CheckBox.Location = new System.Drawing.Point(7, 164);
            this.NRT_Ch25_CheckBox.Name = "NRT_Ch25_CheckBox";
            this.NRT_Ch25_CheckBox.Size = new System.Drawing.Size(52, 16);
            this.NRT_Ch25_CheckBox.TabIndex = 42;
            this.NRT_Ch25_CheckBox.Text = "Ch25";
            this.NRT_Ch25_CheckBox.UseVisualStyleBackColor = true;
            this.NRT_Ch25_CheckBox.CheckedChanged += new System.EventHandler(this.NRT_Ch25_CheckBox_CheckedChanged);
            // 
            // NRT_Ch26_CheckBox
            // 
            this.NRT_Ch26_CheckBox.AutoSize = true;
            this.NRT_Ch26_CheckBox.Location = new System.Drawing.Point(59, 164);
            this.NRT_Ch26_CheckBox.Name = "NRT_Ch26_CheckBox";
            this.NRT_Ch26_CheckBox.Size = new System.Drawing.Size(52, 16);
            this.NRT_Ch26_CheckBox.TabIndex = 43;
            this.NRT_Ch26_CheckBox.Text = "Ch26";
            this.NRT_Ch26_CheckBox.UseVisualStyleBackColor = true;
            this.NRT_Ch26_CheckBox.CheckedChanged += new System.EventHandler(this.NRT_Ch26_CheckBox_CheckedChanged);
            // 
            // NRT_Ch27_CheckBox
            // 
            this.NRT_Ch27_CheckBox.AutoSize = true;
            this.NRT_Ch27_CheckBox.Location = new System.Drawing.Point(117, 164);
            this.NRT_Ch27_CheckBox.Name = "NRT_Ch27_CheckBox";
            this.NRT_Ch27_CheckBox.Size = new System.Drawing.Size(52, 16);
            this.NRT_Ch27_CheckBox.TabIndex = 44;
            this.NRT_Ch27_CheckBox.Text = "Ch27";
            this.NRT_Ch27_CheckBox.UseVisualStyleBackColor = true;
            this.NRT_Ch27_CheckBox.CheckedChanged += new System.EventHandler(this.NRT_Ch27_CheckBox_CheckedChanged);
            // 
            // NRT_Ch28_CheckBox
            // 
            this.NRT_Ch28_CheckBox.AutoSize = true;
            this.NRT_Ch28_CheckBox.Location = new System.Drawing.Point(175, 164);
            this.NRT_Ch28_CheckBox.Name = "NRT_Ch28_CheckBox";
            this.NRT_Ch28_CheckBox.Size = new System.Drawing.Size(52, 16);
            this.NRT_Ch28_CheckBox.TabIndex = 45;
            this.NRT_Ch28_CheckBox.Text = "Ch28";
            this.NRT_Ch28_CheckBox.UseVisualStyleBackColor = true;
            this.NRT_Ch28_CheckBox.CheckedChanged += new System.EventHandler(this.NRT_Ch28_CheckBox_CheckedChanged);
            // 
            // NRT_Ch23_CheckBox
            // 
            this.NRT_Ch23_CheckBox.AutoSize = true;
            this.NRT_Ch23_CheckBox.Location = new System.Drawing.Point(349, 129);
            this.NRT_Ch23_CheckBox.Name = "NRT_Ch23_CheckBox";
            this.NRT_Ch23_CheckBox.Size = new System.Drawing.Size(52, 16);
            this.NRT_Ch23_CheckBox.TabIndex = 40;
            this.NRT_Ch23_CheckBox.Text = "Ch23";
            this.NRT_Ch23_CheckBox.UseVisualStyleBackColor = true;
            this.NRT_Ch23_CheckBox.CheckedChanged += new System.EventHandler(this.NRT_Ch23_CheckBox_CheckedChanged);
            // 
            // NRT_Ch24_CheckBox
            // 
            this.NRT_Ch24_CheckBox.AutoSize = true;
            this.NRT_Ch24_CheckBox.Location = new System.Drawing.Point(407, 129);
            this.NRT_Ch24_CheckBox.Name = "NRT_Ch24_CheckBox";
            this.NRT_Ch24_CheckBox.Size = new System.Drawing.Size(52, 16);
            this.NRT_Ch24_CheckBox.TabIndex = 41;
            this.NRT_Ch24_CheckBox.Text = "Ch24";
            this.NRT_Ch24_CheckBox.UseVisualStyleBackColor = true;
            this.NRT_Ch24_CheckBox.CheckedChanged += new System.EventHandler(this.NRT_Ch24_CheckBox_CheckedChanged);
            // 
            // NRT_Ch21_CheckBox
            // 
            this.NRT_Ch21_CheckBox.AutoSize = true;
            this.NRT_Ch21_CheckBox.Location = new System.Drawing.Point(233, 129);
            this.NRT_Ch21_CheckBox.Name = "NRT_Ch21_CheckBox";
            this.NRT_Ch21_CheckBox.Size = new System.Drawing.Size(52, 16);
            this.NRT_Ch21_CheckBox.TabIndex = 38;
            this.NRT_Ch21_CheckBox.Text = "Ch21";
            this.NRT_Ch21_CheckBox.UseVisualStyleBackColor = true;
            this.NRT_Ch21_CheckBox.CheckedChanged += new System.EventHandler(this.NRT_Ch21_CheckBox_CheckedChanged);
            // 
            // NRT_Ch22_CheckBox
            // 
            this.NRT_Ch22_CheckBox.AutoSize = true;
            this.NRT_Ch22_CheckBox.Location = new System.Drawing.Point(291, 129);
            this.NRT_Ch22_CheckBox.Name = "NRT_Ch22_CheckBox";
            this.NRT_Ch22_CheckBox.Size = new System.Drawing.Size(52, 16);
            this.NRT_Ch22_CheckBox.TabIndex = 39;
            this.NRT_Ch22_CheckBox.Text = "Ch22";
            this.NRT_Ch22_CheckBox.UseVisualStyleBackColor = true;
            this.NRT_Ch22_CheckBox.CheckedChanged += new System.EventHandler(this.NRT_Ch22_CheckBox_CheckedChanged);
            // 
            // NRT_Ch17_CheckBox
            // 
            this.NRT_Ch17_CheckBox.AutoSize = true;
            this.NRT_Ch17_CheckBox.Location = new System.Drawing.Point(7, 129);
            this.NRT_Ch17_CheckBox.Name = "NRT_Ch17_CheckBox";
            this.NRT_Ch17_CheckBox.Size = new System.Drawing.Size(52, 16);
            this.NRT_Ch17_CheckBox.TabIndex = 34;
            this.NRT_Ch17_CheckBox.Text = "Ch17";
            this.NRT_Ch17_CheckBox.UseVisualStyleBackColor = true;
            this.NRT_Ch17_CheckBox.CheckedChanged += new System.EventHandler(this.NRT_Ch17_CheckBox_CheckedChanged);
            // 
            // NRT_Ch18_CheckBox
            // 
            this.NRT_Ch18_CheckBox.AutoSize = true;
            this.NRT_Ch18_CheckBox.Location = new System.Drawing.Point(59, 129);
            this.NRT_Ch18_CheckBox.Name = "NRT_Ch18_CheckBox";
            this.NRT_Ch18_CheckBox.Size = new System.Drawing.Size(52, 16);
            this.NRT_Ch18_CheckBox.TabIndex = 35;
            this.NRT_Ch18_CheckBox.Text = "Ch18";
            this.NRT_Ch18_CheckBox.UseVisualStyleBackColor = true;
            this.NRT_Ch18_CheckBox.CheckedChanged += new System.EventHandler(this.NRT_Ch18_CheckBox_CheckedChanged);
            // 
            // NRT_Ch19_CheckBox
            // 
            this.NRT_Ch19_CheckBox.AutoSize = true;
            this.NRT_Ch19_CheckBox.Location = new System.Drawing.Point(117, 129);
            this.NRT_Ch19_CheckBox.Name = "NRT_Ch19_CheckBox";
            this.NRT_Ch19_CheckBox.Size = new System.Drawing.Size(52, 16);
            this.NRT_Ch19_CheckBox.TabIndex = 36;
            this.NRT_Ch19_CheckBox.Text = "Ch19";
            this.NRT_Ch19_CheckBox.UseVisualStyleBackColor = true;
            this.NRT_Ch19_CheckBox.CheckedChanged += new System.EventHandler(this.NRT_Ch19_CheckBox_CheckedChanged);
            // 
            // NRT_Ch20_CheckBox
            // 
            this.NRT_Ch20_CheckBox.AutoSize = true;
            this.NRT_Ch20_CheckBox.Location = new System.Drawing.Point(175, 129);
            this.NRT_Ch20_CheckBox.Name = "NRT_Ch20_CheckBox";
            this.NRT_Ch20_CheckBox.Size = new System.Drawing.Size(52, 16);
            this.NRT_Ch20_CheckBox.TabIndex = 37;
            this.NRT_Ch20_CheckBox.Text = "Ch20";
            this.NRT_Ch20_CheckBox.UseVisualStyleBackColor = true;
            this.NRT_Ch20_CheckBox.CheckedChanged += new System.EventHandler(this.NRT_Ch20_CheckBox_CheckedChanged);
            // 
            // NRT_Ch15_CheckBox
            // 
            this.NRT_Ch15_CheckBox.AutoSize = true;
            this.NRT_Ch15_CheckBox.Location = new System.Drawing.Point(350, 60);
            this.NRT_Ch15_CheckBox.Name = "NRT_Ch15_CheckBox";
            this.NRT_Ch15_CheckBox.Size = new System.Drawing.Size(52, 16);
            this.NRT_Ch15_CheckBox.TabIndex = 32;
            this.NRT_Ch15_CheckBox.Text = "Ch15";
            this.NRT_Ch15_CheckBox.UseVisualStyleBackColor = true;
            this.NRT_Ch15_CheckBox.CheckedChanged += new System.EventHandler(this.NRT_Ch15_CheckBox_CheckedChanged);
            // 
            // NRT_Ch16_CheckBox
            // 
            this.NRT_Ch16_CheckBox.AutoSize = true;
            this.NRT_Ch16_CheckBox.Location = new System.Drawing.Point(408, 60);
            this.NRT_Ch16_CheckBox.Name = "NRT_Ch16_CheckBox";
            this.NRT_Ch16_CheckBox.Size = new System.Drawing.Size(52, 16);
            this.NRT_Ch16_CheckBox.TabIndex = 33;
            this.NRT_Ch16_CheckBox.Text = "Ch16";
            this.NRT_Ch16_CheckBox.UseVisualStyleBackColor = true;
            this.NRT_Ch16_CheckBox.CheckedChanged += new System.EventHandler(this.NRT_Ch16_CheckBox_CheckedChanged);
            // 
            // NRT_Ch13_CheckBox
            // 
            this.NRT_Ch13_CheckBox.AutoSize = true;
            this.NRT_Ch13_CheckBox.Location = new System.Drawing.Point(234, 60);
            this.NRT_Ch13_CheckBox.Name = "NRT_Ch13_CheckBox";
            this.NRT_Ch13_CheckBox.Size = new System.Drawing.Size(52, 16);
            this.NRT_Ch13_CheckBox.TabIndex = 30;
            this.NRT_Ch13_CheckBox.Text = "Ch13";
            this.NRT_Ch13_CheckBox.UseVisualStyleBackColor = true;
            this.NRT_Ch13_CheckBox.CheckedChanged += new System.EventHandler(this.NRT_Ch13_CheckBox_CheckedChanged);
            // 
            // NRT_Ch14_CheckBox
            // 
            this.NRT_Ch14_CheckBox.AutoSize = true;
            this.NRT_Ch14_CheckBox.Location = new System.Drawing.Point(292, 60);
            this.NRT_Ch14_CheckBox.Name = "NRT_Ch14_CheckBox";
            this.NRT_Ch14_CheckBox.Size = new System.Drawing.Size(52, 16);
            this.NRT_Ch14_CheckBox.TabIndex = 31;
            this.NRT_Ch14_CheckBox.Text = "Ch14";
            this.NRT_Ch14_CheckBox.UseVisualStyleBackColor = true;
            this.NRT_Ch14_CheckBox.CheckedChanged += new System.EventHandler(this.NRT_Ch14_CheckBox_CheckedChanged);
            // 
            // NRT_Ch9_CheckBox
            // 
            this.NRT_Ch9_CheckBox.AutoSize = true;
            this.NRT_Ch9_CheckBox.Location = new System.Drawing.Point(8, 60);
            this.NRT_Ch9_CheckBox.Name = "NRT_Ch9_CheckBox";
            this.NRT_Ch9_CheckBox.Size = new System.Drawing.Size(46, 16);
            this.NRT_Ch9_CheckBox.TabIndex = 26;
            this.NRT_Ch9_CheckBox.Text = "Ch9";
            this.NRT_Ch9_CheckBox.UseVisualStyleBackColor = true;
            this.NRT_Ch9_CheckBox.CheckedChanged += new System.EventHandler(this.NRT_Ch9_CheckBox_CheckedChanged);
            // 
            // NRT_Ch10_CheckBox
            // 
            this.NRT_Ch10_CheckBox.AutoSize = true;
            this.NRT_Ch10_CheckBox.Location = new System.Drawing.Point(60, 60);
            this.NRT_Ch10_CheckBox.Name = "NRT_Ch10_CheckBox";
            this.NRT_Ch10_CheckBox.Size = new System.Drawing.Size(52, 16);
            this.NRT_Ch10_CheckBox.TabIndex = 27;
            this.NRT_Ch10_CheckBox.Text = "Ch10";
            this.NRT_Ch10_CheckBox.UseVisualStyleBackColor = true;
            this.NRT_Ch10_CheckBox.CheckedChanged += new System.EventHandler(this.NRT_Ch10_CheckBox_CheckedChanged);
            // 
            // NRT_Ch11_CheckBox
            // 
            this.NRT_Ch11_CheckBox.AutoSize = true;
            this.NRT_Ch11_CheckBox.Location = new System.Drawing.Point(118, 60);
            this.NRT_Ch11_CheckBox.Name = "NRT_Ch11_CheckBox";
            this.NRT_Ch11_CheckBox.Size = new System.Drawing.Size(52, 16);
            this.NRT_Ch11_CheckBox.TabIndex = 28;
            this.NRT_Ch11_CheckBox.Text = "Ch11";
            this.NRT_Ch11_CheckBox.UseVisualStyleBackColor = true;
            this.NRT_Ch11_CheckBox.CheckedChanged += new System.EventHandler(this.NRT_Ch11_CheckBox_CheckedChanged);
            // 
            // NRT_Ch12_CheckBox
            // 
            this.NRT_Ch12_CheckBox.AutoSize = true;
            this.NRT_Ch12_CheckBox.Location = new System.Drawing.Point(176, 60);
            this.NRT_Ch12_CheckBox.Name = "NRT_Ch12_CheckBox";
            this.NRT_Ch12_CheckBox.Size = new System.Drawing.Size(52, 16);
            this.NRT_Ch12_CheckBox.TabIndex = 29;
            this.NRT_Ch12_CheckBox.Text = "Ch12";
            this.NRT_Ch12_CheckBox.UseVisualStyleBackColor = true;
            this.NRT_Ch12_CheckBox.CheckedChanged += new System.EventHandler(this.NRT_Ch12_CheckBox_CheckedChanged);
            // 
            // NRT_Ch7_CheckBox
            // 
            this.NRT_Ch7_CheckBox.AutoSize = true;
            this.NRT_Ch7_CheckBox.Location = new System.Drawing.Point(350, 25);
            this.NRT_Ch7_CheckBox.Name = "NRT_Ch7_CheckBox";
            this.NRT_Ch7_CheckBox.Size = new System.Drawing.Size(46, 16);
            this.NRT_Ch7_CheckBox.TabIndex = 24;
            this.NRT_Ch7_CheckBox.Text = "Ch7";
            this.NRT_Ch7_CheckBox.UseVisualStyleBackColor = true;
            this.NRT_Ch7_CheckBox.CheckedChanged += new System.EventHandler(this.NRT_Ch7_CheckBox_CheckedChanged);
            // 
            // NRT_Ch8_CheckBox
            // 
            this.NRT_Ch8_CheckBox.AutoSize = true;
            this.NRT_Ch8_CheckBox.Location = new System.Drawing.Point(408, 25);
            this.NRT_Ch8_CheckBox.Name = "NRT_Ch8_CheckBox";
            this.NRT_Ch8_CheckBox.Size = new System.Drawing.Size(46, 16);
            this.NRT_Ch8_CheckBox.TabIndex = 25;
            this.NRT_Ch8_CheckBox.Text = "Ch8";
            this.NRT_Ch8_CheckBox.UseVisualStyleBackColor = true;
            this.NRT_Ch8_CheckBox.CheckedChanged += new System.EventHandler(this.NRT_Ch8_CheckBox_CheckedChanged);
            // 
            // NRT_Ch5_CheckBox
            // 
            this.NRT_Ch5_CheckBox.AutoSize = true;
            this.NRT_Ch5_CheckBox.Location = new System.Drawing.Point(234, 25);
            this.NRT_Ch5_CheckBox.Name = "NRT_Ch5_CheckBox";
            this.NRT_Ch5_CheckBox.Size = new System.Drawing.Size(46, 16);
            this.NRT_Ch5_CheckBox.TabIndex = 22;
            this.NRT_Ch5_CheckBox.Text = "Ch5";
            this.NRT_Ch5_CheckBox.UseVisualStyleBackColor = true;
            this.NRT_Ch5_CheckBox.CheckedChanged += new System.EventHandler(this.NRT_Ch5_CheckBox_CheckedChanged);
            // 
            // NRT_Ch6_CheckBox
            // 
            this.NRT_Ch6_CheckBox.AutoSize = true;
            this.NRT_Ch6_CheckBox.Location = new System.Drawing.Point(292, 25);
            this.NRT_Ch6_CheckBox.Name = "NRT_Ch6_CheckBox";
            this.NRT_Ch6_CheckBox.Size = new System.Drawing.Size(46, 16);
            this.NRT_Ch6_CheckBox.TabIndex = 23;
            this.NRT_Ch6_CheckBox.Text = "Ch6";
            this.NRT_Ch6_CheckBox.UseVisualStyleBackColor = true;
            this.NRT_Ch6_CheckBox.CheckedChanged += new System.EventHandler(this.NRT_Ch6_CheckBox_CheckedChanged);
            // 
            // NRT_Ch1_CheckBox
            // 
            this.NRT_Ch1_CheckBox.AutoSize = true;
            this.NRT_Ch1_CheckBox.Location = new System.Drawing.Point(8, 25);
            this.NRT_Ch1_CheckBox.Name = "NRT_Ch1_CheckBox";
            this.NRT_Ch1_CheckBox.Size = new System.Drawing.Size(46, 16);
            this.NRT_Ch1_CheckBox.TabIndex = 18;
            this.NRT_Ch1_CheckBox.Text = "Ch1";
            this.NRT_Ch1_CheckBox.UseVisualStyleBackColor = true;
            this.NRT_Ch1_CheckBox.CheckedChanged += new System.EventHandler(this.NRT_Ch1_CheckBox_CheckedChanged);
            // 
            // NRT_Ch2_CheckBox
            // 
            this.NRT_Ch2_CheckBox.AutoSize = true;
            this.NRT_Ch2_CheckBox.Location = new System.Drawing.Point(60, 25);
            this.NRT_Ch2_CheckBox.Name = "NRT_Ch2_CheckBox";
            this.NRT_Ch2_CheckBox.Size = new System.Drawing.Size(46, 16);
            this.NRT_Ch2_CheckBox.TabIndex = 19;
            this.NRT_Ch2_CheckBox.Text = "Ch2";
            this.NRT_Ch2_CheckBox.UseVisualStyleBackColor = true;
            this.NRT_Ch2_CheckBox.CheckedChanged += new System.EventHandler(this.NRT_Ch2_CheckBox_CheckedChanged);
            // 
            // NRT_Ch3_CheckBox
            // 
            this.NRT_Ch3_CheckBox.AutoSize = true;
            this.NRT_Ch3_CheckBox.Location = new System.Drawing.Point(118, 25);
            this.NRT_Ch3_CheckBox.Name = "NRT_Ch3_CheckBox";
            this.NRT_Ch3_CheckBox.Size = new System.Drawing.Size(46, 16);
            this.NRT_Ch3_CheckBox.TabIndex = 20;
            this.NRT_Ch3_CheckBox.Text = "Ch3";
            this.NRT_Ch3_CheckBox.UseVisualStyleBackColor = true;
            this.NRT_Ch3_CheckBox.CheckedChanged += new System.EventHandler(this.NRT_Ch3_CheckBox_CheckedChanged);
            // 
            // NRT_Ch4_CheckBox
            // 
            this.NRT_Ch4_CheckBox.AutoSize = true;
            this.NRT_Ch4_CheckBox.Location = new System.Drawing.Point(176, 25);
            this.NRT_Ch4_CheckBox.Name = "NRT_Ch4_CheckBox";
            this.NRT_Ch4_CheckBox.Size = new System.Drawing.Size(46, 16);
            this.NRT_Ch4_CheckBox.TabIndex = 21;
            this.NRT_Ch4_CheckBox.Text = "Ch4";
            this.NRT_Ch4_CheckBox.UseVisualStyleBackColor = true;
            this.NRT_Ch4_CheckBox.CheckedChanged += new System.EventHandler(this.NRT_Ch4_CheckBox_CheckedChanged);
            // 
            // MPR_TabPage
            // 
            this.MPR_TabPage.Controls.Add(this.listBox3);
            this.MPR_TabPage.Controls.Add(this.listBox2);
            this.MPR_TabPage.Controls.Add(this.MPR_Insert_Button);
            this.MPR_TabPage.Controls.Add(this.MPR_Auto_Manual_Groupbox);
            this.MPR_TabPage.Controls.Add(this.MPR_POWER_ON_OFF_Groupbox);
            this.MPR_TabPage.Controls.Add(this.MPR_CD_Track_Groupbox);
            this.MPR_TabPage.Controls.Add(this.MPR_CD_Volume_Groupbox);
            this.MPR_TabPage.Controls.Add(this.MPR_CD_Control_Groupbox);
            this.MPR_TabPage.Controls.Add(this.label8);
            this.MPR_TabPage.Controls.Add(this.comboBox1);
            this.MPR_TabPage.Controls.Add(this.MPR_Cmd_comboBox);
            this.MPR_TabPage.Controls.Add(this.comboBox3);
            this.MPR_TabPage.Controls.Add(this.label11);
            this.MPR_TabPage.Location = new System.Drawing.Point(4, 22);
            this.MPR_TabPage.Name = "MPR_TabPage";
            this.MPR_TabPage.Padding = new System.Windows.Forms.Padding(3);
            this.MPR_TabPage.Size = new System.Drawing.Size(484, 625);
            this.MPR_TabPage.TabIndex = 5;
            this.MPR_TabPage.Text = "MPR4000";
            this.MPR_TabPage.UseVisualStyleBackColor = true;
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 12;
            this.listBox3.Location = new System.Drawing.Point(267, 375);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(200, 244);
            this.listBox3.TabIndex = 68;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 12;
            this.listBox2.Location = new System.Drawing.Point(7, 375);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(200, 244);
            this.listBox2.TabIndex = 56;
            // 
            // MPR_Insert_Button
            // 
            this.MPR_Insert_Button.Location = new System.Drawing.Point(434, 24);
            this.MPR_Insert_Button.Name = "MPR_Insert_Button";
            this.MPR_Insert_Button.Size = new System.Drawing.Size(44, 41);
            this.MPR_Insert_Button.TabIndex = 67;
            this.MPR_Insert_Button.Text = ">>";
            this.MPR_Insert_Button.UseVisualStyleBackColor = true;
            this.MPR_Insert_Button.Click += new System.EventHandler(this.MPR_Insert_Button_Click);
            // 
            // MPR_Auto_Manual_Groupbox
            // 
            this.MPR_Auto_Manual_Groupbox.Controls.Add(this.MPR_Auto_RadioButton);
            this.MPR_Auto_Manual_Groupbox.Controls.Add(this.MPR_Manual_RadioButton);
            this.MPR_Auto_Manual_Groupbox.Location = new System.Drawing.Point(267, 15);
            this.MPR_Auto_Manual_Groupbox.Name = "MPR_Auto_Manual_Groupbox";
            this.MPR_Auto_Manual_Groupbox.Size = new System.Drawing.Size(125, 35);
            this.MPR_Auto_Manual_Groupbox.TabIndex = 66;
            this.MPR_Auto_Manual_Groupbox.TabStop = false;
            this.MPR_Auto_Manual_Groupbox.Text = "수동/자동";
            // 
            // MPR_Auto_RadioButton
            // 
            this.MPR_Auto_RadioButton.AutoSize = true;
            this.MPR_Auto_RadioButton.Location = new System.Drawing.Point(72, 15);
            this.MPR_Auto_RadioButton.Name = "MPR_Auto_RadioButton";
            this.MPR_Auto_RadioButton.Size = new System.Drawing.Size(47, 16);
            this.MPR_Auto_RadioButton.TabIndex = 2;
            this.MPR_Auto_RadioButton.TabStop = true;
            this.MPR_Auto_RadioButton.Text = "자동";
            this.MPR_Auto_RadioButton.UseVisualStyleBackColor = true;
            this.MPR_Auto_RadioButton.CheckedChanged += new System.EventHandler(this.MPR_Auto_RadioButton_CheckedChanged);
            // 
            // MPR_Manual_RadioButton
            // 
            this.MPR_Manual_RadioButton.AutoSize = true;
            this.MPR_Manual_RadioButton.Location = new System.Drawing.Point(6, 15);
            this.MPR_Manual_RadioButton.Name = "MPR_Manual_RadioButton";
            this.MPR_Manual_RadioButton.Size = new System.Drawing.Size(47, 16);
            this.MPR_Manual_RadioButton.TabIndex = 1;
            this.MPR_Manual_RadioButton.TabStop = true;
            this.MPR_Manual_RadioButton.Text = "수동";
            this.MPR_Manual_RadioButton.UseVisualStyleBackColor = true;
            this.MPR_Manual_RadioButton.CheckedChanged += new System.EventHandler(this.MPR_Manual_RadioButton_CheckedChanged);
            // 
            // MPR_POWER_ON_OFF_Groupbox
            // 
            this.MPR_POWER_ON_OFF_Groupbox.Controls.Add(this.MPR_POWER_ON_OFF_button);
            this.MPR_POWER_ON_OFF_Groupbox.Controls.Add(this.radioButton16);
            this.MPR_POWER_ON_OFF_Groupbox.Controls.Add(this.radioButton17);
            this.MPR_POWER_ON_OFF_Groupbox.Controls.Add(this.radioButton18);
            this.MPR_POWER_ON_OFF_Groupbox.Location = new System.Drawing.Point(7, 64);
            this.MPR_POWER_ON_OFF_Groupbox.Name = "MPR_POWER_ON_OFF_Groupbox";
            this.MPR_POWER_ON_OFF_Groupbox.Size = new System.Drawing.Size(431, 48);
            this.MPR_POWER_ON_OFF_Groupbox.TabIndex = 65;
            this.MPR_POWER_ON_OFF_Groupbox.TabStop = false;
            this.MPR_POWER_ON_OFF_Groupbox.Text = "Power ON/OFF";
            // 
            // MPR_POWER_ON_OFF_button
            // 
            this.MPR_POWER_ON_OFF_button.Location = new System.Drawing.Point(382, 15);
            this.MPR_POWER_ON_OFF_button.Name = "MPR_POWER_ON_OFF_button";
            this.MPR_POWER_ON_OFF_button.Size = new System.Drawing.Size(43, 27);
            this.MPR_POWER_ON_OFF_button.TabIndex = 68;
            this.MPR_POWER_ON_OFF_button.Text = "실행";
            this.MPR_POWER_ON_OFF_button.UseVisualStyleBackColor = true;
            // 
            // radioButton16
            // 
            this.radioButton16.AutoSize = true;
            this.radioButton16.Location = new System.Drawing.Point(203, 20);
            this.radioButton16.Name = "radioButton16";
            this.radioButton16.Size = new System.Drawing.Size(162, 16);
            this.radioButton16.TabIndex = 2;
            this.radioButton16.TabStop = true;
            this.radioButton16.Text = "MODE(CD/USB/SD/FM)";
            this.radioButton16.UseVisualStyleBackColor = true;
            // 
            // radioButton17
            // 
            this.radioButton17.AutoSize = true;
            this.radioButton17.Location = new System.Drawing.Point(105, 20);
            this.radioButton17.Name = "radioButton17";
            this.radioButton17.Size = new System.Drawing.Size(86, 16);
            this.radioButton17.TabIndex = 1;
            this.radioButton17.TabStop = true;
            this.radioButton17.Text = "Power OFF";
            this.radioButton17.UseVisualStyleBackColor = true;
            // 
            // radioButton18
            // 
            this.radioButton18.AutoSize = true;
            this.radioButton18.Location = new System.Drawing.Point(7, 21);
            this.radioButton18.Name = "radioButton18";
            this.radioButton18.Size = new System.Drawing.Size(81, 16);
            this.radioButton18.TabIndex = 0;
            this.radioButton18.TabStop = true;
            this.radioButton18.Text = "Power ON";
            this.radioButton18.UseVisualStyleBackColor = true;
            // 
            // MPR_CD_Track_Groupbox
            // 
            this.MPR_CD_Track_Groupbox.Controls.Add(this.MPR_CD_Track_button);
            this.MPR_CD_Track_Groupbox.Controls.Add(this.radioButton14);
            this.MPR_CD_Track_Groupbox.Controls.Add(this.radioButton11);
            this.MPR_CD_Track_Groupbox.Controls.Add(this.radioButton12);
            this.MPR_CD_Track_Groupbox.Controls.Add(this.radioButton13);
            this.MPR_CD_Track_Groupbox.Location = new System.Drawing.Point(7, 245);
            this.MPR_CD_Track_Groupbox.Name = "MPR_CD_Track_Groupbox";
            this.MPR_CD_Track_Groupbox.Size = new System.Drawing.Size(471, 48);
            this.MPR_CD_Track_Groupbox.TabIndex = 65;
            this.MPR_CD_Track_Groupbox.TabStop = false;
            this.MPR_CD_Track_Groupbox.Text = "CD Track";
            // 
            // MPR_CD_Track_button
            // 
            this.MPR_CD_Track_button.Location = new System.Drawing.Point(422, 15);
            this.MPR_CD_Track_button.Name = "MPR_CD_Track_button";
            this.MPR_CD_Track_button.Size = new System.Drawing.Size(43, 27);
            this.MPR_CD_Track_button.TabIndex = 71;
            this.MPR_CD_Track_button.Text = "실행";
            this.MPR_CD_Track_button.UseVisualStyleBackColor = true;
            // 
            // radioButton14
            // 
            this.radioButton14.AutoSize = true;
            this.radioButton14.Location = new System.Drawing.Point(7, 20);
            this.radioButton14.Name = "radioButton14";
            this.radioButton14.Size = new System.Drawing.Size(74, 16);
            this.radioButton14.TabIndex = 4;
            this.radioButton14.TabStop = true;
            this.radioButton14.Text = "Track Up";
            this.radioButton14.UseVisualStyleBackColor = true;
            // 
            // radioButton11
            // 
            this.radioButton11.AutoSize = true;
            this.radioButton11.Location = new System.Drawing.Point(274, 20);
            this.radioButton11.Name = "radioButton11";
            this.radioButton11.Size = new System.Drawing.Size(104, 16);
            this.radioButton11.TabIndex = 3;
            this.radioButton11.TabStop = true;
            this.radioButton11.Text = "TRACK DOWN";
            this.radioButton11.UseVisualStyleBackColor = true;
            // 
            // radioButton12
            // 
            this.radioButton12.AutoSize = true;
            this.radioButton12.Location = new System.Drawing.Point(184, 20);
            this.radioButton12.Name = "radioButton12";
            this.radioButton12.Size = new System.Drawing.Size(84, 16);
            this.radioButton12.TabIndex = 2;
            this.radioButton12.TabStop = true;
            this.radioButton12.Text = "TRACK UP";
            this.radioButton12.UseVisualStyleBackColor = true;
            // 
            // radioButton13
            // 
            this.radioButton13.AutoSize = true;
            this.radioButton13.Location = new System.Drawing.Point(87, 20);
            this.radioButton13.Name = "radioButton13";
            this.radioButton13.Size = new System.Drawing.Size(91, 16);
            this.radioButton13.TabIndex = 1;
            this.radioButton13.TabStop = true;
            this.radioButton13.Text = "Track Down";
            this.radioButton13.UseVisualStyleBackColor = true;
            // 
            // MPR_CD_Volume_Groupbox
            // 
            this.MPR_CD_Volume_Groupbox.Controls.Add(this.MPR_CD_Volume_button);
            this.MPR_CD_Volume_Groupbox.Controls.Add(this.radioButton8);
            this.MPR_CD_Volume_Groupbox.Controls.Add(this.radioButton5);
            this.MPR_CD_Volume_Groupbox.Controls.Add(this.radioButton6);
            this.MPR_CD_Volume_Groupbox.Controls.Add(this.radioButton7);
            this.MPR_CD_Volume_Groupbox.Location = new System.Drawing.Point(7, 191);
            this.MPR_CD_Volume_Groupbox.Name = "MPR_CD_Volume_Groupbox";
            this.MPR_CD_Volume_Groupbox.Size = new System.Drawing.Size(471, 48);
            this.MPR_CD_Volume_Groupbox.TabIndex = 64;
            this.MPR_CD_Volume_Groupbox.TabStop = false;
            this.MPR_CD_Volume_Groupbox.Text = "CD Volume";
            // 
            // MPR_CD_Volume_button
            // 
            this.MPR_CD_Volume_button.Location = new System.Drawing.Point(422, 13);
            this.MPR_CD_Volume_button.Name = "MPR_CD_Volume_button";
            this.MPR_CD_Volume_button.Size = new System.Drawing.Size(43, 27);
            this.MPR_CD_Volume_button.TabIndex = 70;
            this.MPR_CD_Volume_button.Text = "실행";
            this.MPR_CD_Volume_button.UseVisualStyleBackColor = true;
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.Location = new System.Drawing.Point(7, 18);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(85, 16);
            this.radioButton8.TabIndex = 4;
            this.radioButton8.TabStop = true;
            this.radioButton8.Text = "Volume Up";
            this.radioButton8.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(292, 18);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(85, 16);
            this.radioButton5.TabIndex = 3;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "MUTE OFF";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(206, 18);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(80, 16);
            this.radioButton6.TabIndex = 2;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "MUTE ON";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Location = new System.Drawing.Point(98, 18);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(102, 16);
            this.radioButton7.TabIndex = 1;
            this.radioButton7.TabStop = true;
            this.radioButton7.Text = "Volume Down";
            this.radioButton7.UseVisualStyleBackColor = true;
            // 
            // MPR_CD_Control_Groupbox
            // 
            this.MPR_CD_Control_Groupbox.Controls.Add(this.MPR_CD_Control_button);
            this.MPR_CD_Control_Groupbox.Controls.Add(this.radioButton4);
            this.MPR_CD_Control_Groupbox.Controls.Add(this.radioButton9);
            this.MPR_CD_Control_Groupbox.Controls.Add(this.radioButton10);
            this.MPR_CD_Control_Groupbox.Controls.Add(this.radioButton3);
            this.MPR_CD_Control_Groupbox.Controls.Add(this.radioButton2);
            this.MPR_CD_Control_Groupbox.Controls.Add(this.radioButton1);
            this.MPR_CD_Control_Groupbox.Location = new System.Drawing.Point(7, 118);
            this.MPR_CD_Control_Groupbox.Name = "MPR_CD_Control_Groupbox";
            this.MPR_CD_Control_Groupbox.Size = new System.Drawing.Size(337, 67);
            this.MPR_CD_Control_Groupbox.TabIndex = 63;
            this.MPR_CD_Control_Groupbox.TabStop = false;
            this.MPR_CD_Control_Groupbox.Text = "CD Control";
            // 
            // MPR_CD_Control_button
            // 
            this.MPR_CD_Control_button.Location = new System.Drawing.Point(288, 21);
            this.MPR_CD_Control_button.Name = "MPR_CD_Control_button";
            this.MPR_CD_Control_button.Size = new System.Drawing.Size(43, 27);
            this.MPR_CD_Control_button.TabIndex = 69;
            this.MPR_CD_Control_button.Text = "실행";
            this.MPR_CD_Control_button.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(203, 41);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(51, 16);
            this.radioButton4.TabIndex = 5;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Eject";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton9
            // 
            this.radioButton9.AutoSize = true;
            this.radioButton9.Location = new System.Drawing.Point(105, 41);
            this.radioButton9.Name = "radioButton9";
            this.radioButton9.Size = new System.Drawing.Size(76, 16);
            this.radioButton9.TabIndex = 4;
            this.radioButton9.TabStop = true;
            this.radioButton9.Text = "RANDOM";
            this.radioButton9.UseVisualStyleBackColor = true;
            // 
            // radioButton10
            // 
            this.radioButton10.AutoSize = true;
            this.radioButton10.Location = new System.Drawing.Point(7, 42);
            this.radioButton10.Name = "radioButton10";
            this.radioButton10.Size = new System.Drawing.Size(71, 16);
            this.radioButton10.TabIndex = 3;
            this.radioButton10.TabStop = true;
            this.radioButton10.Text = "REPEAT";
            this.radioButton10.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(203, 20);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(56, 16);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "STOP";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(105, 20);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(63, 16);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "PAUSE";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(7, 21);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(54, 16);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "PLAY";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(132, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 12);
            this.label8.TabIndex = 61;
            this.label8.Text = "명령어";
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1"});
            this.comboBox1.Location = new System.Drawing.Point(71, 30);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(57, 20);
            this.comboBox1.TabIndex = 60;
            // 
            // MPR_Cmd_comboBox
            // 
            this.MPR_Cmd_comboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.MPR_Cmd_comboBox.FormattingEnabled = true;
            this.MPR_Cmd_comboBox.Items.AddRange(new object[] {
            "Power ON/OFF",
            "CD Control",
            "CD Volume",
            "CD TRACK"});
            this.MPR_Cmd_comboBox.Location = new System.Drawing.Point(134, 30);
            this.MPR_Cmd_comboBox.Name = "MPR_Cmd_comboBox";
            this.MPR_Cmd_comboBox.Size = new System.Drawing.Size(121, 20);
            this.MPR_Cmd_comboBox.TabIndex = 58;
            // 
            // comboBox3
            // 
            this.comboBox3.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "0"});
            this.comboBox3.Location = new System.Drawing.Point(7, 30);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(57, 20);
            this.comboBox3.TabIndex = 59;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(5, 15);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(16, 12);
            this.label11.TabIndex = 57;
            this.label11.Text = "ID";
            // 
            // NCS01_TabPage
            // 
            this.NCS01_TabPage.Controls.Add(this.button7);
            this.NCS01_TabPage.Controls.Add(this.NCS_Insert_Button);
            this.NCS01_TabPage.Controls.Add(this.NCS01_CMD_Label);
            this.NCS01_TabPage.Controls.Add(this.groupBox7);
            this.NCS01_TabPage.Controls.Add(this.NCS01_ID_1_comboBox);
            this.NCS01_TabPage.Controls.Add(this.NCS01_ID_10_comboBox);
            this.NCS01_TabPage.Controls.Add(this.NCS01_ID_Label);
            this.NCS01_TabPage.Controls.Add(this.NCS_Cmd_comboBox);
            this.NCS01_TabPage.Location = new System.Drawing.Point(4, 22);
            this.NCS01_TabPage.Name = "NCS01_TabPage";
            this.NCS01_TabPage.Padding = new System.Windows.Forms.Padding(3);
            this.NCS01_TabPage.Size = new System.Drawing.Size(484, 625);
            this.NCS01_TabPage.TabIndex = 6;
            this.NCS01_TabPage.Text = "NCS01";
            this.NCS01_TabPage.UseVisualStyleBackColor = true;
            // 
            // NCS_Insert_Button
            // 
            this.NCS_Insert_Button.Location = new System.Drawing.Point(434, 24);
            this.NCS_Insert_Button.Name = "NCS_Insert_Button";
            this.NCS_Insert_Button.Size = new System.Drawing.Size(44, 41);
            this.NCS_Insert_Button.TabIndex = 53;
            this.NCS_Insert_Button.Text = ">>";
            this.NCS_Insert_Button.UseVisualStyleBackColor = true;
            // 
            // NCS01_CMD_Label
            // 
            this.NCS01_CMD_Label.AutoSize = true;
            this.NCS01_CMD_Label.Location = new System.Drawing.Point(132, 15);
            this.NCS01_CMD_Label.Name = "NCS01_CMD_Label";
            this.NCS01_CMD_Label.Size = new System.Drawing.Size(41, 12);
            this.NCS01_CMD_Label.TabIndex = 62;
            this.NCS01_CMD_Label.Text = "명령어";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.checkBox145);
            this.groupBox7.Controls.Add(this.checkBox146);
            this.groupBox7.Controls.Add(this.checkBox147);
            this.groupBox7.Controls.Add(this.checkBox148);
            this.groupBox7.Controls.Add(this.checkBox149);
            this.groupBox7.Controls.Add(this.checkBox150);
            this.groupBox7.Controls.Add(this.checkBox151);
            this.groupBox7.Controls.Add(this.checkBox152);
            this.groupBox7.Controls.Add(this.checkBox153);
            this.groupBox7.Controls.Add(this.checkBox154);
            this.groupBox7.Controls.Add(this.checkBox155);
            this.groupBox7.Controls.Add(this.checkBox156);
            this.groupBox7.Controls.Add(this.checkBox157);
            this.groupBox7.Controls.Add(this.checkBox158);
            this.groupBox7.Controls.Add(this.checkBox159);
            this.groupBox7.Controls.Add(this.checkBox160);
            this.groupBox7.Controls.Add(this.checkBox161);
            this.groupBox7.Controls.Add(this.checkBox162);
            this.groupBox7.Controls.Add(this.checkBox163);
            this.groupBox7.Controls.Add(this.checkBox164);
            this.groupBox7.Controls.Add(this.checkBox165);
            this.groupBox7.Controls.Add(this.checkBox166);
            this.groupBox7.Controls.Add(this.checkBox167);
            this.groupBox7.Controls.Add(this.checkBox168);
            this.groupBox7.Controls.Add(this.checkBox169);
            this.groupBox7.Controls.Add(this.checkBox170);
            this.groupBox7.Controls.Add(this.checkBox171);
            this.groupBox7.Controls.Add(this.checkBox172);
            this.groupBox7.Controls.Add(this.checkBox173);
            this.groupBox7.Controls.Add(this.checkBox174);
            this.groupBox7.Controls.Add(this.checkBox175);
            this.groupBox7.Controls.Add(this.checkBox176);
            this.groupBox7.Controls.Add(this.checkBox177);
            this.groupBox7.Controls.Add(this.checkBox178);
            this.groupBox7.Controls.Add(this.checkBox179);
            this.groupBox7.Controls.Add(this.checkBox180);
            this.groupBox7.Controls.Add(this.checkBox181);
            this.groupBox7.Controls.Add(this.checkBox182);
            this.groupBox7.Controls.Add(this.checkBox183);
            this.groupBox7.Controls.Add(this.checkBox184);
            this.groupBox7.Location = new System.Drawing.Point(7, 64);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(467, 262);
            this.groupBox7.TabIndex = 38;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Normal";
            // 
            // checkBox145
            // 
            this.checkBox145.AutoSize = true;
            this.checkBox145.Location = new System.Drawing.Point(349, 222);
            this.checkBox145.Name = "checkBox145";
            this.checkBox145.Size = new System.Drawing.Size(52, 16);
            this.checkBox145.TabIndex = 56;
            this.checkBox145.Text = "Ch39";
            this.checkBox145.UseVisualStyleBackColor = true;
            // 
            // checkBox146
            // 
            this.checkBox146.AutoSize = true;
            this.checkBox146.Location = new System.Drawing.Point(407, 222);
            this.checkBox146.Name = "checkBox146";
            this.checkBox146.Size = new System.Drawing.Size(52, 16);
            this.checkBox146.TabIndex = 57;
            this.checkBox146.Text = "Ch40";
            this.checkBox146.UseVisualStyleBackColor = true;
            // 
            // checkBox147
            // 
            this.checkBox147.AutoSize = true;
            this.checkBox147.Location = new System.Drawing.Point(233, 222);
            this.checkBox147.Name = "checkBox147";
            this.checkBox147.Size = new System.Drawing.Size(52, 16);
            this.checkBox147.TabIndex = 54;
            this.checkBox147.Text = "Ch37";
            this.checkBox147.UseVisualStyleBackColor = true;
            // 
            // checkBox148
            // 
            this.checkBox148.AutoSize = true;
            this.checkBox148.Location = new System.Drawing.Point(291, 222);
            this.checkBox148.Name = "checkBox148";
            this.checkBox148.Size = new System.Drawing.Size(52, 16);
            this.checkBox148.TabIndex = 55;
            this.checkBox148.Text = "Ch38";
            this.checkBox148.UseVisualStyleBackColor = true;
            // 
            // checkBox149
            // 
            this.checkBox149.AutoSize = true;
            this.checkBox149.Location = new System.Drawing.Point(7, 222);
            this.checkBox149.Name = "checkBox149";
            this.checkBox149.Size = new System.Drawing.Size(52, 16);
            this.checkBox149.TabIndex = 50;
            this.checkBox149.Text = "Ch33";
            this.checkBox149.UseVisualStyleBackColor = true;
            // 
            // checkBox150
            // 
            this.checkBox150.AutoSize = true;
            this.checkBox150.Location = new System.Drawing.Point(59, 222);
            this.checkBox150.Name = "checkBox150";
            this.checkBox150.Size = new System.Drawing.Size(52, 16);
            this.checkBox150.TabIndex = 51;
            this.checkBox150.Text = "Ch34";
            this.checkBox150.UseVisualStyleBackColor = true;
            // 
            // checkBox151
            // 
            this.checkBox151.AutoSize = true;
            this.checkBox151.Location = new System.Drawing.Point(117, 222);
            this.checkBox151.Name = "checkBox151";
            this.checkBox151.Size = new System.Drawing.Size(52, 16);
            this.checkBox151.TabIndex = 52;
            this.checkBox151.Text = "Ch35";
            this.checkBox151.UseVisualStyleBackColor = true;
            // 
            // checkBox152
            // 
            this.checkBox152.AutoSize = true;
            this.checkBox152.Location = new System.Drawing.Point(175, 222);
            this.checkBox152.Name = "checkBox152";
            this.checkBox152.Size = new System.Drawing.Size(52, 16);
            this.checkBox152.TabIndex = 53;
            this.checkBox152.Text = "Ch36";
            this.checkBox152.UseVisualStyleBackColor = true;
            // 
            // checkBox153
            // 
            this.checkBox153.AutoSize = true;
            this.checkBox153.Location = new System.Drawing.Point(349, 164);
            this.checkBox153.Name = "checkBox153";
            this.checkBox153.Size = new System.Drawing.Size(52, 16);
            this.checkBox153.TabIndex = 48;
            this.checkBox153.Text = "Ch31";
            this.checkBox153.UseVisualStyleBackColor = true;
            // 
            // checkBox154
            // 
            this.checkBox154.AutoSize = true;
            this.checkBox154.Location = new System.Drawing.Point(407, 164);
            this.checkBox154.Name = "checkBox154";
            this.checkBox154.Size = new System.Drawing.Size(52, 16);
            this.checkBox154.TabIndex = 49;
            this.checkBox154.Text = "Ch32";
            this.checkBox154.UseVisualStyleBackColor = true;
            // 
            // checkBox155
            // 
            this.checkBox155.AutoSize = true;
            this.checkBox155.Location = new System.Drawing.Point(233, 164);
            this.checkBox155.Name = "checkBox155";
            this.checkBox155.Size = new System.Drawing.Size(52, 16);
            this.checkBox155.TabIndex = 46;
            this.checkBox155.Text = "Ch29";
            this.checkBox155.UseVisualStyleBackColor = true;
            // 
            // checkBox156
            // 
            this.checkBox156.AutoSize = true;
            this.checkBox156.Location = new System.Drawing.Point(291, 164);
            this.checkBox156.Name = "checkBox156";
            this.checkBox156.Size = new System.Drawing.Size(52, 16);
            this.checkBox156.TabIndex = 47;
            this.checkBox156.Text = "Ch30";
            this.checkBox156.UseVisualStyleBackColor = true;
            // 
            // checkBox157
            // 
            this.checkBox157.AutoSize = true;
            this.checkBox157.Location = new System.Drawing.Point(7, 164);
            this.checkBox157.Name = "checkBox157";
            this.checkBox157.Size = new System.Drawing.Size(52, 16);
            this.checkBox157.TabIndex = 42;
            this.checkBox157.Text = "Ch25";
            this.checkBox157.UseVisualStyleBackColor = true;
            // 
            // checkBox158
            // 
            this.checkBox158.AutoSize = true;
            this.checkBox158.Location = new System.Drawing.Point(59, 164);
            this.checkBox158.Name = "checkBox158";
            this.checkBox158.Size = new System.Drawing.Size(52, 16);
            this.checkBox158.TabIndex = 43;
            this.checkBox158.Text = "Ch26";
            this.checkBox158.UseVisualStyleBackColor = true;
            // 
            // checkBox159
            // 
            this.checkBox159.AutoSize = true;
            this.checkBox159.Location = new System.Drawing.Point(117, 164);
            this.checkBox159.Name = "checkBox159";
            this.checkBox159.Size = new System.Drawing.Size(52, 16);
            this.checkBox159.TabIndex = 44;
            this.checkBox159.Text = "Ch27";
            this.checkBox159.UseVisualStyleBackColor = true;
            // 
            // checkBox160
            // 
            this.checkBox160.AutoSize = true;
            this.checkBox160.Location = new System.Drawing.Point(175, 164);
            this.checkBox160.Name = "checkBox160";
            this.checkBox160.Size = new System.Drawing.Size(52, 16);
            this.checkBox160.TabIndex = 45;
            this.checkBox160.Text = "Ch28";
            this.checkBox160.UseVisualStyleBackColor = true;
            // 
            // checkBox161
            // 
            this.checkBox161.AutoSize = true;
            this.checkBox161.Location = new System.Drawing.Point(349, 129);
            this.checkBox161.Name = "checkBox161";
            this.checkBox161.Size = new System.Drawing.Size(52, 16);
            this.checkBox161.TabIndex = 40;
            this.checkBox161.Text = "Ch23";
            this.checkBox161.UseVisualStyleBackColor = true;
            // 
            // checkBox162
            // 
            this.checkBox162.AutoSize = true;
            this.checkBox162.Location = new System.Drawing.Point(407, 129);
            this.checkBox162.Name = "checkBox162";
            this.checkBox162.Size = new System.Drawing.Size(52, 16);
            this.checkBox162.TabIndex = 41;
            this.checkBox162.Text = "Ch24";
            this.checkBox162.UseVisualStyleBackColor = true;
            // 
            // checkBox163
            // 
            this.checkBox163.AutoSize = true;
            this.checkBox163.Location = new System.Drawing.Point(233, 129);
            this.checkBox163.Name = "checkBox163";
            this.checkBox163.Size = new System.Drawing.Size(52, 16);
            this.checkBox163.TabIndex = 38;
            this.checkBox163.Text = "Ch21";
            this.checkBox163.UseVisualStyleBackColor = true;
            // 
            // checkBox164
            // 
            this.checkBox164.AutoSize = true;
            this.checkBox164.Location = new System.Drawing.Point(291, 129);
            this.checkBox164.Name = "checkBox164";
            this.checkBox164.Size = new System.Drawing.Size(52, 16);
            this.checkBox164.TabIndex = 39;
            this.checkBox164.Text = "Ch22";
            this.checkBox164.UseVisualStyleBackColor = true;
            // 
            // checkBox165
            // 
            this.checkBox165.AutoSize = true;
            this.checkBox165.Location = new System.Drawing.Point(7, 129);
            this.checkBox165.Name = "checkBox165";
            this.checkBox165.Size = new System.Drawing.Size(52, 16);
            this.checkBox165.TabIndex = 34;
            this.checkBox165.Text = "Ch17";
            this.checkBox165.UseVisualStyleBackColor = true;
            // 
            // checkBox166
            // 
            this.checkBox166.AutoSize = true;
            this.checkBox166.Location = new System.Drawing.Point(59, 129);
            this.checkBox166.Name = "checkBox166";
            this.checkBox166.Size = new System.Drawing.Size(52, 16);
            this.checkBox166.TabIndex = 35;
            this.checkBox166.Text = "Ch18";
            this.checkBox166.UseVisualStyleBackColor = true;
            // 
            // checkBox167
            // 
            this.checkBox167.AutoSize = true;
            this.checkBox167.Location = new System.Drawing.Point(117, 129);
            this.checkBox167.Name = "checkBox167";
            this.checkBox167.Size = new System.Drawing.Size(52, 16);
            this.checkBox167.TabIndex = 36;
            this.checkBox167.Text = "Ch19";
            this.checkBox167.UseVisualStyleBackColor = true;
            // 
            // checkBox168
            // 
            this.checkBox168.AutoSize = true;
            this.checkBox168.Location = new System.Drawing.Point(175, 129);
            this.checkBox168.Name = "checkBox168";
            this.checkBox168.Size = new System.Drawing.Size(52, 16);
            this.checkBox168.TabIndex = 37;
            this.checkBox168.Text = "Ch20";
            this.checkBox168.UseVisualStyleBackColor = true;
            // 
            // checkBox169
            // 
            this.checkBox169.AutoSize = true;
            this.checkBox169.Location = new System.Drawing.Point(350, 60);
            this.checkBox169.Name = "checkBox169";
            this.checkBox169.Size = new System.Drawing.Size(52, 16);
            this.checkBox169.TabIndex = 32;
            this.checkBox169.Text = "Ch15";
            this.checkBox169.UseVisualStyleBackColor = true;
            // 
            // checkBox170
            // 
            this.checkBox170.AutoSize = true;
            this.checkBox170.Location = new System.Drawing.Point(408, 60);
            this.checkBox170.Name = "checkBox170";
            this.checkBox170.Size = new System.Drawing.Size(52, 16);
            this.checkBox170.TabIndex = 33;
            this.checkBox170.Text = "Ch16";
            this.checkBox170.UseVisualStyleBackColor = true;
            // 
            // checkBox171
            // 
            this.checkBox171.AutoSize = true;
            this.checkBox171.Location = new System.Drawing.Point(234, 60);
            this.checkBox171.Name = "checkBox171";
            this.checkBox171.Size = new System.Drawing.Size(52, 16);
            this.checkBox171.TabIndex = 30;
            this.checkBox171.Text = "Ch13";
            this.checkBox171.UseVisualStyleBackColor = true;
            // 
            // checkBox172
            // 
            this.checkBox172.AutoSize = true;
            this.checkBox172.Location = new System.Drawing.Point(292, 60);
            this.checkBox172.Name = "checkBox172";
            this.checkBox172.Size = new System.Drawing.Size(52, 16);
            this.checkBox172.TabIndex = 31;
            this.checkBox172.Text = "Ch14";
            this.checkBox172.UseVisualStyleBackColor = true;
            // 
            // checkBox173
            // 
            this.checkBox173.AutoSize = true;
            this.checkBox173.Location = new System.Drawing.Point(8, 60);
            this.checkBox173.Name = "checkBox173";
            this.checkBox173.Size = new System.Drawing.Size(46, 16);
            this.checkBox173.TabIndex = 26;
            this.checkBox173.Text = "Ch9";
            this.checkBox173.UseVisualStyleBackColor = true;
            // 
            // checkBox174
            // 
            this.checkBox174.AutoSize = true;
            this.checkBox174.Location = new System.Drawing.Point(60, 60);
            this.checkBox174.Name = "checkBox174";
            this.checkBox174.Size = new System.Drawing.Size(52, 16);
            this.checkBox174.TabIndex = 27;
            this.checkBox174.Text = "Ch10";
            this.checkBox174.UseVisualStyleBackColor = true;
            // 
            // checkBox175
            // 
            this.checkBox175.AutoSize = true;
            this.checkBox175.Location = new System.Drawing.Point(118, 60);
            this.checkBox175.Name = "checkBox175";
            this.checkBox175.Size = new System.Drawing.Size(52, 16);
            this.checkBox175.TabIndex = 28;
            this.checkBox175.Text = "Ch11";
            this.checkBox175.UseVisualStyleBackColor = true;
            // 
            // checkBox176
            // 
            this.checkBox176.AutoSize = true;
            this.checkBox176.Location = new System.Drawing.Point(176, 60);
            this.checkBox176.Name = "checkBox176";
            this.checkBox176.Size = new System.Drawing.Size(52, 16);
            this.checkBox176.TabIndex = 29;
            this.checkBox176.Text = "Ch12";
            this.checkBox176.UseVisualStyleBackColor = true;
            // 
            // checkBox177
            // 
            this.checkBox177.AutoSize = true;
            this.checkBox177.Location = new System.Drawing.Point(350, 25);
            this.checkBox177.Name = "checkBox177";
            this.checkBox177.Size = new System.Drawing.Size(46, 16);
            this.checkBox177.TabIndex = 24;
            this.checkBox177.Text = "Ch7";
            this.checkBox177.UseVisualStyleBackColor = true;
            // 
            // checkBox178
            // 
            this.checkBox178.AutoSize = true;
            this.checkBox178.Location = new System.Drawing.Point(408, 25);
            this.checkBox178.Name = "checkBox178";
            this.checkBox178.Size = new System.Drawing.Size(46, 16);
            this.checkBox178.TabIndex = 25;
            this.checkBox178.Text = "Ch8";
            this.checkBox178.UseVisualStyleBackColor = true;
            // 
            // checkBox179
            // 
            this.checkBox179.AutoSize = true;
            this.checkBox179.Location = new System.Drawing.Point(234, 25);
            this.checkBox179.Name = "checkBox179";
            this.checkBox179.Size = new System.Drawing.Size(46, 16);
            this.checkBox179.TabIndex = 22;
            this.checkBox179.Text = "Ch5";
            this.checkBox179.UseVisualStyleBackColor = true;
            // 
            // checkBox180
            // 
            this.checkBox180.AutoSize = true;
            this.checkBox180.Location = new System.Drawing.Point(292, 25);
            this.checkBox180.Name = "checkBox180";
            this.checkBox180.Size = new System.Drawing.Size(46, 16);
            this.checkBox180.TabIndex = 23;
            this.checkBox180.Text = "Ch6";
            this.checkBox180.UseVisualStyleBackColor = true;
            // 
            // checkBox181
            // 
            this.checkBox181.AutoSize = true;
            this.checkBox181.Location = new System.Drawing.Point(8, 25);
            this.checkBox181.Name = "checkBox181";
            this.checkBox181.Size = new System.Drawing.Size(46, 16);
            this.checkBox181.TabIndex = 18;
            this.checkBox181.Text = "Ch1";
            this.checkBox181.UseVisualStyleBackColor = true;
            // 
            // checkBox182
            // 
            this.checkBox182.AutoSize = true;
            this.checkBox182.Location = new System.Drawing.Point(60, 25);
            this.checkBox182.Name = "checkBox182";
            this.checkBox182.Size = new System.Drawing.Size(46, 16);
            this.checkBox182.TabIndex = 19;
            this.checkBox182.Text = "Ch2";
            this.checkBox182.UseVisualStyleBackColor = true;
            // 
            // checkBox183
            // 
            this.checkBox183.AutoSize = true;
            this.checkBox183.Location = new System.Drawing.Point(118, 25);
            this.checkBox183.Name = "checkBox183";
            this.checkBox183.Size = new System.Drawing.Size(46, 16);
            this.checkBox183.TabIndex = 20;
            this.checkBox183.Text = "Ch3";
            this.checkBox183.UseVisualStyleBackColor = true;
            // 
            // checkBox184
            // 
            this.checkBox184.AutoSize = true;
            this.checkBox184.Location = new System.Drawing.Point(176, 25);
            this.checkBox184.Name = "checkBox184";
            this.checkBox184.Size = new System.Drawing.Size(46, 16);
            this.checkBox184.TabIndex = 21;
            this.checkBox184.Text = "Ch4";
            this.checkBox184.UseVisualStyleBackColor = true;
            // 
            // NCS01_ID_1_comboBox
            // 
            this.NCS01_ID_1_comboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.NCS01_ID_1_comboBox.FormattingEnabled = true;
            this.NCS01_ID_1_comboBox.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "A",
            "B",
            "C",
            "D",
            "E",
            "F"});
            this.NCS01_ID_1_comboBox.Location = new System.Drawing.Point(71, 30);
            this.NCS01_ID_1_comboBox.Name = "NCS01_ID_1_comboBox";
            this.NCS01_ID_1_comboBox.Size = new System.Drawing.Size(57, 20);
            this.NCS01_ID_1_comboBox.TabIndex = 61;
            // 
            // NCS01_ID_10_comboBox
            // 
            this.NCS01_ID_10_comboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.NCS01_ID_10_comboBox.FormattingEnabled = true;
            this.NCS01_ID_10_comboBox.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "A",
            "B",
            "C",
            "D",
            "E",
            "F"});
            this.NCS01_ID_10_comboBox.Location = new System.Drawing.Point(7, 30);
            this.NCS01_ID_10_comboBox.Name = "NCS01_ID_10_comboBox";
            this.NCS01_ID_10_comboBox.Size = new System.Drawing.Size(57, 20);
            this.NCS01_ID_10_comboBox.TabIndex = 60;
            // 
            // NCS01_ID_Label
            // 
            this.NCS01_ID_Label.AutoSize = true;
            this.NCS01_ID_Label.Location = new System.Drawing.Point(5, 15);
            this.NCS01_ID_Label.Name = "NCS01_ID_Label";
            this.NCS01_ID_Label.Size = new System.Drawing.Size(16, 12);
            this.NCS01_ID_Label.TabIndex = 58;
            this.NCS01_ID_Label.Text = "ID";
            // 
            // NCS_Cmd_comboBox
            // 
            this.NCS_Cmd_comboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.NCS_Cmd_comboBox.FormattingEnabled = true;
            this.NCS_Cmd_comboBox.Items.AddRange(new object[] {
            "NOR",
            "DMY",
            "VER",
            "INIT"});
            this.NCS_Cmd_comboBox.Location = new System.Drawing.Point(134, 30);
            this.NCS_Cmd_comboBox.Name = "NCS_Cmd_comboBox";
            this.NCS_Cmd_comboBox.Size = new System.Drawing.Size(121, 20);
            this.NCS_Cmd_comboBox.TabIndex = 59;
            // 
            // NEI42_TabPage
            // 
            this.NEI42_TabPage.Controls.Add(this.NEI42_CMD_Label);
            this.NEI42_TabPage.Controls.Add(this.NEI42_ID_1_comboBox);
            this.NEI42_TabPage.Controls.Add(this.NEI42_ID_Label);
            this.NEI42_TabPage.Controls.Add(this.NEI42_ID_10_comboBox);
            this.NEI42_TabPage.Controls.Add(this.NEI42_Cmd_comboBox);
            this.NEI42_TabPage.Controls.Add(this.NEI_Insert_Button);
            this.NEI42_TabPage.Controls.Add(this.NEI42_GPIN_Total_GroupBox);
            this.NEI42_TabPage.Location = new System.Drawing.Point(4, 22);
            this.NEI42_TabPage.Name = "NEI42_TabPage";
            this.NEI42_TabPage.Padding = new System.Windows.Forms.Padding(3);
            this.NEI42_TabPage.Size = new System.Drawing.Size(484, 625);
            this.NEI42_TabPage.TabIndex = 7;
            this.NEI42_TabPage.Text = "NEI42";
            this.NEI42_TabPage.UseVisualStyleBackColor = true;
            // 
            // NEI42_CMD_Label
            // 
            this.NEI42_CMD_Label.AutoSize = true;
            this.NEI42_CMD_Label.Location = new System.Drawing.Point(132, 15);
            this.NEI42_CMD_Label.Name = "NEI42_CMD_Label";
            this.NEI42_CMD_Label.Size = new System.Drawing.Size(41, 12);
            this.NEI42_CMD_Label.TabIndex = 67;
            this.NEI42_CMD_Label.Text = "명령어";
            // 
            // NEI42_ID_1_comboBox
            // 
            this.NEI42_ID_1_comboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.NEI42_ID_1_comboBox.FormattingEnabled = true;
            this.NEI42_ID_1_comboBox.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "A",
            "B",
            "C",
            "D",
            "E",
            "F"});
            this.NEI42_ID_1_comboBox.Location = new System.Drawing.Point(71, 30);
            this.NEI42_ID_1_comboBox.Name = "NEI42_ID_1_comboBox";
            this.NEI42_ID_1_comboBox.Size = new System.Drawing.Size(57, 20);
            this.NEI42_ID_1_comboBox.TabIndex = 66;
            // 
            // NEI42_ID_Label
            // 
            this.NEI42_ID_Label.AutoSize = true;
            this.NEI42_ID_Label.Location = new System.Drawing.Point(5, 15);
            this.NEI42_ID_Label.Name = "NEI42_ID_Label";
            this.NEI42_ID_Label.Size = new System.Drawing.Size(16, 12);
            this.NEI42_ID_Label.TabIndex = 63;
            this.NEI42_ID_Label.Text = "ID";
            // 
            // NEI42_ID_10_comboBox
            // 
            this.NEI42_ID_10_comboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.NEI42_ID_10_comboBox.FormattingEnabled = true;
            this.NEI42_ID_10_comboBox.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "A",
            "B",
            "C",
            "D",
            "E",
            "F"});
            this.NEI42_ID_10_comboBox.Location = new System.Drawing.Point(7, 30);
            this.NEI42_ID_10_comboBox.Name = "NEI42_ID_10_comboBox";
            this.NEI42_ID_10_comboBox.Size = new System.Drawing.Size(57, 20);
            this.NEI42_ID_10_comboBox.TabIndex = 65;
            // 
            // NEI42_Cmd_comboBox
            // 
            this.NEI42_Cmd_comboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.NEI42_Cmd_comboBox.FormattingEnabled = true;
            this.NEI42_Cmd_comboBox.Items.AddRange(new object[] {
            "DMY",
            "VER",
            "INIT"});
            this.NEI42_Cmd_comboBox.Location = new System.Drawing.Point(134, 30);
            this.NEI42_Cmd_comboBox.Name = "NEI42_Cmd_comboBox";
            this.NEI42_Cmd_comboBox.Size = new System.Drawing.Size(121, 20);
            this.NEI42_Cmd_comboBox.TabIndex = 64;
            // 
            // NEI_Insert_Button
            // 
            this.NEI_Insert_Button.Location = new System.Drawing.Point(434, 24);
            this.NEI_Insert_Button.Name = "NEI_Insert_Button";
            this.NEI_Insert_Button.Size = new System.Drawing.Size(44, 41);
            this.NEI_Insert_Button.TabIndex = 53;
            this.NEI_Insert_Button.Text = ">>";
            this.NEI_Insert_Button.UseVisualStyleBackColor = true;
            this.NEI_Insert_Button.Click += new System.EventHandler(this.NEI_Insert_Button_Click);
            // 
            // NEI42_GPIN_Total_GroupBox
            // 
            this.NEI42_GPIN_Total_GroupBox.Controls.Add(this.NEI42_GPIN3_GroupBox);
            this.NEI42_GPIN_Total_GroupBox.Controls.Add(this.NEI42_GPIN2_GroupBox);
            this.NEI42_GPIN_Total_GroupBox.Controls.Add(this.NEI42_GPIN1_GroupBox);
            this.NEI42_GPIN_Total_GroupBox.Location = new System.Drawing.Point(6, 71);
            this.NEI42_GPIN_Total_GroupBox.Name = "NEI42_GPIN_Total_GroupBox";
            this.NEI42_GPIN_Total_GroupBox.Size = new System.Drawing.Size(471, 247);
            this.NEI42_GPIN_Total_GroupBox.TabIndex = 4;
            this.NEI42_GPIN_Total_GroupBox.TabStop = false;
            this.NEI42_GPIN_Total_GroupBox.Text = "NEI42";
            // 
            // NEI42_GPIN3_GroupBox
            // 
            this.NEI42_GPIN3_GroupBox.Controls.Add(this.NEI_Ch41_CheckBox);
            this.NEI42_GPIN3_GroupBox.Controls.Add(this.NEI_Ch29_CheckBox);
            this.NEI42_GPIN3_GroupBox.Controls.Add(this.NEI_Ch42_CheckBox);
            this.NEI42_GPIN3_GroupBox.Controls.Add(this.NEI_Ch33_CheckBox);
            this.NEI42_GPIN3_GroupBox.Controls.Add(this.NEI_Ch37_CheckBox);
            this.NEI42_GPIN3_GroupBox.Controls.Add(this.NEI_Ch34_CheckBox);
            this.NEI42_GPIN3_GroupBox.Controls.Add(this.NEI_Ch38_CheckBox);
            this.NEI42_GPIN3_GroupBox.Controls.Add(this.NEI_Ch36_CheckBox);
            this.NEI42_GPIN3_GroupBox.Controls.Add(this.NEI_Ch30_CheckBox);
            this.NEI42_GPIN3_GroupBox.Controls.Add(this.NEI_Ch39_CheckBox);
            this.NEI42_GPIN3_GroupBox.Controls.Add(this.NEI_Ch35_CheckBox);
            this.NEI42_GPIN3_GroupBox.Controls.Add(this.NEI_Ch32_CheckBox);
            this.NEI42_GPIN3_GroupBox.Controls.Add(this.NEI_Ch31_CheckBox);
            this.NEI42_GPIN3_GroupBox.Controls.Add(this.NEI_Ch40_CheckBox);
            this.NEI42_GPIN3_GroupBox.Location = new System.Drawing.Point(6, 164);
            this.NEI42_GPIN3_GroupBox.Name = "NEI42_GPIN3_GroupBox";
            this.NEI42_GPIN3_GroupBox.Size = new System.Drawing.Size(459, 67);
            this.NEI42_GPIN3_GroupBox.TabIndex = 98;
            this.NEI42_GPIN3_GroupBox.TabStop = false;
            this.NEI42_GPIN3_GroupBox.Text = "GPIN3";
            // 
            // NEI_Ch41_CheckBox
            // 
            this.NEI_Ch41_CheckBox.AutoSize = true;
            this.NEI_Ch41_CheckBox.Location = new System.Drawing.Point(290, 42);
            this.NEI_Ch41_CheckBox.Name = "NEI_Ch41_CheckBox";
            this.NEI_Ch41_CheckBox.Size = new System.Drawing.Size(52, 16);
            this.NEI_Ch41_CheckBox.TabIndex = 95;
            this.NEI_Ch41_CheckBox.Text = "Ch41";
            this.NEI_Ch41_CheckBox.UseVisualStyleBackColor = true;
            this.NEI_Ch41_CheckBox.CheckedChanged += new System.EventHandler(this.NEI_Ch41_CheckBox_CheckedChanged);
            // 
            // NEI_Ch29_CheckBox
            // 
            this.NEI_Ch29_CheckBox.AutoSize = true;
            this.NEI_Ch29_CheckBox.Location = new System.Drawing.Point(6, 20);
            this.NEI_Ch29_CheckBox.Name = "NEI_Ch29_CheckBox";
            this.NEI_Ch29_CheckBox.Size = new System.Drawing.Size(52, 16);
            this.NEI_Ch29_CheckBox.TabIndex = 83;
            this.NEI_Ch29_CheckBox.Text = "Ch29";
            this.NEI_Ch29_CheckBox.UseVisualStyleBackColor = true;
            this.NEI_Ch29_CheckBox.CheckedChanged += new System.EventHandler(this.NEI_Ch29_CheckBox_CheckedChanged);
            // 
            // NEI_Ch42_CheckBox
            // 
            this.NEI_Ch42_CheckBox.AutoSize = true;
            this.NEI_Ch42_CheckBox.Location = new System.Drawing.Point(348, 42);
            this.NEI_Ch42_CheckBox.Name = "NEI_Ch42_CheckBox";
            this.NEI_Ch42_CheckBox.Size = new System.Drawing.Size(52, 16);
            this.NEI_Ch42_CheckBox.TabIndex = 96;
            this.NEI_Ch42_CheckBox.Text = "Ch42";
            this.NEI_Ch42_CheckBox.UseVisualStyleBackColor = true;
            this.NEI_Ch42_CheckBox.CheckedChanged += new System.EventHandler(this.NEI_Ch42_CheckBox_CheckedChanged);
            // 
            // NEI_Ch33_CheckBox
            // 
            this.NEI_Ch33_CheckBox.AutoSize = true;
            this.NEI_Ch33_CheckBox.Location = new System.Drawing.Point(232, 20);
            this.NEI_Ch33_CheckBox.Name = "NEI_Ch33_CheckBox";
            this.NEI_Ch33_CheckBox.Size = new System.Drawing.Size(52, 16);
            this.NEI_Ch33_CheckBox.TabIndex = 87;
            this.NEI_Ch33_CheckBox.Text = "Ch33";
            this.NEI_Ch33_CheckBox.UseVisualStyleBackColor = true;
            this.NEI_Ch33_CheckBox.CheckedChanged += new System.EventHandler(this.NEI_Ch33_CheckBox_CheckedChanged);
            // 
            // NEI_Ch37_CheckBox
            // 
            this.NEI_Ch37_CheckBox.AutoSize = true;
            this.NEI_Ch37_CheckBox.Location = new System.Drawing.Point(58, 42);
            this.NEI_Ch37_CheckBox.Name = "NEI_Ch37_CheckBox";
            this.NEI_Ch37_CheckBox.Size = new System.Drawing.Size(52, 16);
            this.NEI_Ch37_CheckBox.TabIndex = 91;
            this.NEI_Ch37_CheckBox.Text = "Ch37";
            this.NEI_Ch37_CheckBox.UseVisualStyleBackColor = true;
            this.NEI_Ch37_CheckBox.CheckedChanged += new System.EventHandler(this.NEI_Ch37_CheckBox_CheckedChanged);
            // 
            // NEI_Ch34_CheckBox
            // 
            this.NEI_Ch34_CheckBox.AutoSize = true;
            this.NEI_Ch34_CheckBox.Location = new System.Drawing.Point(290, 20);
            this.NEI_Ch34_CheckBox.Name = "NEI_Ch34_CheckBox";
            this.NEI_Ch34_CheckBox.Size = new System.Drawing.Size(52, 16);
            this.NEI_Ch34_CheckBox.TabIndex = 88;
            this.NEI_Ch34_CheckBox.Text = "Ch34";
            this.NEI_Ch34_CheckBox.UseVisualStyleBackColor = true;
            this.NEI_Ch34_CheckBox.CheckedChanged += new System.EventHandler(this.NEI_Ch34_CheckBox_CheckedChanged);
            // 
            // NEI_Ch38_CheckBox
            // 
            this.NEI_Ch38_CheckBox.AutoSize = true;
            this.NEI_Ch38_CheckBox.Location = new System.Drawing.Point(116, 42);
            this.NEI_Ch38_CheckBox.Name = "NEI_Ch38_CheckBox";
            this.NEI_Ch38_CheckBox.Size = new System.Drawing.Size(52, 16);
            this.NEI_Ch38_CheckBox.TabIndex = 92;
            this.NEI_Ch38_CheckBox.Text = "Ch38";
            this.NEI_Ch38_CheckBox.UseVisualStyleBackColor = true;
            this.NEI_Ch38_CheckBox.CheckedChanged += new System.EventHandler(this.NEI_Ch38_CheckBox_CheckedChanged);
            // 
            // NEI_Ch36_CheckBox
            // 
            this.NEI_Ch36_CheckBox.AutoSize = true;
            this.NEI_Ch36_CheckBox.Location = new System.Drawing.Point(6, 42);
            this.NEI_Ch36_CheckBox.Name = "NEI_Ch36_CheckBox";
            this.NEI_Ch36_CheckBox.Size = new System.Drawing.Size(52, 16);
            this.NEI_Ch36_CheckBox.TabIndex = 90;
            this.NEI_Ch36_CheckBox.Text = "Ch36";
            this.NEI_Ch36_CheckBox.UseVisualStyleBackColor = true;
            this.NEI_Ch36_CheckBox.CheckedChanged += new System.EventHandler(this.NEI_Ch36_CheckBox_CheckedChanged);
            // 
            // NEI_Ch30_CheckBox
            // 
            this.NEI_Ch30_CheckBox.AutoSize = true;
            this.NEI_Ch30_CheckBox.Location = new System.Drawing.Point(58, 20);
            this.NEI_Ch30_CheckBox.Name = "NEI_Ch30_CheckBox";
            this.NEI_Ch30_CheckBox.Size = new System.Drawing.Size(52, 16);
            this.NEI_Ch30_CheckBox.TabIndex = 84;
            this.NEI_Ch30_CheckBox.Text = "Ch30";
            this.NEI_Ch30_CheckBox.UseVisualStyleBackColor = true;
            this.NEI_Ch30_CheckBox.CheckedChanged += new System.EventHandler(this.NEI_Ch30_CheckBox_CheckedChanged);
            // 
            // NEI_Ch39_CheckBox
            // 
            this.NEI_Ch39_CheckBox.AutoSize = true;
            this.NEI_Ch39_CheckBox.Location = new System.Drawing.Point(174, 42);
            this.NEI_Ch39_CheckBox.Name = "NEI_Ch39_CheckBox";
            this.NEI_Ch39_CheckBox.Size = new System.Drawing.Size(52, 16);
            this.NEI_Ch39_CheckBox.TabIndex = 93;
            this.NEI_Ch39_CheckBox.Text = "Ch39";
            this.NEI_Ch39_CheckBox.UseVisualStyleBackColor = true;
            this.NEI_Ch39_CheckBox.CheckedChanged += new System.EventHandler(this.NEI_Ch39_CheckBox_CheckedChanged);
            // 
            // NEI_Ch35_CheckBox
            // 
            this.NEI_Ch35_CheckBox.AutoSize = true;
            this.NEI_Ch35_CheckBox.Location = new System.Drawing.Point(348, 20);
            this.NEI_Ch35_CheckBox.Name = "NEI_Ch35_CheckBox";
            this.NEI_Ch35_CheckBox.Size = new System.Drawing.Size(52, 16);
            this.NEI_Ch35_CheckBox.TabIndex = 89;
            this.NEI_Ch35_CheckBox.Text = "Ch35";
            this.NEI_Ch35_CheckBox.UseVisualStyleBackColor = true;
            this.NEI_Ch35_CheckBox.CheckedChanged += new System.EventHandler(this.NEI_Ch35_CheckBox_CheckedChanged);
            // 
            // NEI_Ch32_CheckBox
            // 
            this.NEI_Ch32_CheckBox.AutoSize = true;
            this.NEI_Ch32_CheckBox.Location = new System.Drawing.Point(174, 20);
            this.NEI_Ch32_CheckBox.Name = "NEI_Ch32_CheckBox";
            this.NEI_Ch32_CheckBox.Size = new System.Drawing.Size(52, 16);
            this.NEI_Ch32_CheckBox.TabIndex = 86;
            this.NEI_Ch32_CheckBox.Text = "Ch32";
            this.NEI_Ch32_CheckBox.UseVisualStyleBackColor = true;
            this.NEI_Ch32_CheckBox.CheckedChanged += new System.EventHandler(this.NEI_Ch32_CheckBox_CheckedChanged);
            // 
            // NEI_Ch31_CheckBox
            // 
            this.NEI_Ch31_CheckBox.AutoSize = true;
            this.NEI_Ch31_CheckBox.Location = new System.Drawing.Point(116, 20);
            this.NEI_Ch31_CheckBox.Name = "NEI_Ch31_CheckBox";
            this.NEI_Ch31_CheckBox.Size = new System.Drawing.Size(52, 16);
            this.NEI_Ch31_CheckBox.TabIndex = 85;
            this.NEI_Ch31_CheckBox.Text = "Ch31";
            this.NEI_Ch31_CheckBox.UseVisualStyleBackColor = true;
            this.NEI_Ch31_CheckBox.CheckedChanged += new System.EventHandler(this.NEI_Ch31_CheckBox_CheckedChanged);
            // 
            // NEI_Ch40_CheckBox
            // 
            this.NEI_Ch40_CheckBox.AutoSize = true;
            this.NEI_Ch40_CheckBox.Location = new System.Drawing.Point(232, 42);
            this.NEI_Ch40_CheckBox.Name = "NEI_Ch40_CheckBox";
            this.NEI_Ch40_CheckBox.Size = new System.Drawing.Size(52, 16);
            this.NEI_Ch40_CheckBox.TabIndex = 94;
            this.NEI_Ch40_CheckBox.Text = "Ch40";
            this.NEI_Ch40_CheckBox.UseVisualStyleBackColor = true;
            this.NEI_Ch40_CheckBox.CheckedChanged += new System.EventHandler(this.NEI_Ch40_CheckBox_CheckedChanged);
            // 
            // NEI42_GPIN2_GroupBox
            // 
            this.NEI42_GPIN2_GroupBox.Controls.Add(this.NEI_Ch27_CheckBox);
            this.NEI42_GPIN2_GroupBox.Controls.Add(this.NEI_Ch15_CheckBox);
            this.NEI42_GPIN2_GroupBox.Controls.Add(this.NEI_Ch28_CheckBox);
            this.NEI42_GPIN2_GroupBox.Controls.Add(this.NEI_Ch19_CheckBox);
            this.NEI42_GPIN2_GroupBox.Controls.Add(this.NEI_Ch23_CheckBox);
            this.NEI42_GPIN2_GroupBox.Controls.Add(this.NEI_Ch20_CheckBox);
            this.NEI42_GPIN2_GroupBox.Controls.Add(this.NEI_Ch24_CheckBox);
            this.NEI42_GPIN2_GroupBox.Controls.Add(this.NEI_Ch22_CheckBox);
            this.NEI42_GPIN2_GroupBox.Controls.Add(this.NEI_Ch16_CheckBox);
            this.NEI42_GPIN2_GroupBox.Controls.Add(this.NEI_Ch25_CheckBox);
            this.NEI42_GPIN2_GroupBox.Controls.Add(this.NEI_Ch21_CheckBox);
            this.NEI42_GPIN2_GroupBox.Controls.Add(this.NEI_Ch18_CheckBox);
            this.NEI42_GPIN2_GroupBox.Controls.Add(this.NEI_Ch17_CheckBox);
            this.NEI42_GPIN2_GroupBox.Controls.Add(this.NEI_Ch26_CheckBox);
            this.NEI42_GPIN2_GroupBox.Location = new System.Drawing.Point(6, 91);
            this.NEI42_GPIN2_GroupBox.Name = "NEI42_GPIN2_GroupBox";
            this.NEI42_GPIN2_GroupBox.Size = new System.Drawing.Size(459, 67);
            this.NEI42_GPIN2_GroupBox.TabIndex = 97;
            this.NEI42_GPIN2_GroupBox.TabStop = false;
            this.NEI42_GPIN2_GroupBox.Text = "GPIN2";
            // 
            // NEI_Ch27_CheckBox
            // 
            this.NEI_Ch27_CheckBox.AutoSize = true;
            this.NEI_Ch27_CheckBox.Location = new System.Drawing.Point(290, 42);
            this.NEI_Ch27_CheckBox.Name = "NEI_Ch27_CheckBox";
            this.NEI_Ch27_CheckBox.Size = new System.Drawing.Size(52, 16);
            this.NEI_Ch27_CheckBox.TabIndex = 95;
            this.NEI_Ch27_CheckBox.Text = "Ch27";
            this.NEI_Ch27_CheckBox.UseVisualStyleBackColor = true;
            this.NEI_Ch27_CheckBox.CheckedChanged += new System.EventHandler(this.NEI_Ch27_CheckBox_CheckedChanged);
            // 
            // NEI_Ch15_CheckBox
            // 
            this.NEI_Ch15_CheckBox.AutoSize = true;
            this.NEI_Ch15_CheckBox.Location = new System.Drawing.Point(6, 20);
            this.NEI_Ch15_CheckBox.Name = "NEI_Ch15_CheckBox";
            this.NEI_Ch15_CheckBox.Size = new System.Drawing.Size(52, 16);
            this.NEI_Ch15_CheckBox.TabIndex = 83;
            this.NEI_Ch15_CheckBox.Text = "Ch15";
            this.NEI_Ch15_CheckBox.UseVisualStyleBackColor = true;
            this.NEI_Ch15_CheckBox.CheckedChanged += new System.EventHandler(this.NEI_Ch15_CheckBox_CheckedChanged);
            // 
            // NEI_Ch28_CheckBox
            // 
            this.NEI_Ch28_CheckBox.AutoSize = true;
            this.NEI_Ch28_CheckBox.Location = new System.Drawing.Point(348, 42);
            this.NEI_Ch28_CheckBox.Name = "NEI_Ch28_CheckBox";
            this.NEI_Ch28_CheckBox.Size = new System.Drawing.Size(52, 16);
            this.NEI_Ch28_CheckBox.TabIndex = 96;
            this.NEI_Ch28_CheckBox.Text = "Ch28";
            this.NEI_Ch28_CheckBox.UseVisualStyleBackColor = true;
            this.NEI_Ch28_CheckBox.CheckedChanged += new System.EventHandler(this.NEI_Ch28_CheckBox_CheckedChanged);
            // 
            // NEI_Ch19_CheckBox
            // 
            this.NEI_Ch19_CheckBox.AutoSize = true;
            this.NEI_Ch19_CheckBox.Location = new System.Drawing.Point(232, 20);
            this.NEI_Ch19_CheckBox.Name = "NEI_Ch19_CheckBox";
            this.NEI_Ch19_CheckBox.Size = new System.Drawing.Size(52, 16);
            this.NEI_Ch19_CheckBox.TabIndex = 87;
            this.NEI_Ch19_CheckBox.Text = "Ch19";
            this.NEI_Ch19_CheckBox.UseVisualStyleBackColor = true;
            this.NEI_Ch19_CheckBox.CheckedChanged += new System.EventHandler(this.NEI_Ch19_CheckBox_CheckedChanged);
            // 
            // NEI_Ch23_CheckBox
            // 
            this.NEI_Ch23_CheckBox.AutoSize = true;
            this.NEI_Ch23_CheckBox.Location = new System.Drawing.Point(58, 42);
            this.NEI_Ch23_CheckBox.Name = "NEI_Ch23_CheckBox";
            this.NEI_Ch23_CheckBox.Size = new System.Drawing.Size(52, 16);
            this.NEI_Ch23_CheckBox.TabIndex = 91;
            this.NEI_Ch23_CheckBox.Text = "Ch23";
            this.NEI_Ch23_CheckBox.UseVisualStyleBackColor = true;
            this.NEI_Ch23_CheckBox.CheckedChanged += new System.EventHandler(this.NEI_Ch23_CheckBox_CheckedChanged);
            // 
            // NEI_Ch20_CheckBox
            // 
            this.NEI_Ch20_CheckBox.AutoSize = true;
            this.NEI_Ch20_CheckBox.Location = new System.Drawing.Point(290, 20);
            this.NEI_Ch20_CheckBox.Name = "NEI_Ch20_CheckBox";
            this.NEI_Ch20_CheckBox.Size = new System.Drawing.Size(52, 16);
            this.NEI_Ch20_CheckBox.TabIndex = 88;
            this.NEI_Ch20_CheckBox.Text = "Ch20";
            this.NEI_Ch20_CheckBox.UseVisualStyleBackColor = true;
            this.NEI_Ch20_CheckBox.CheckedChanged += new System.EventHandler(this.NEI_Ch20_CheckBox_CheckedChanged);
            // 
            // NEI_Ch24_CheckBox
            // 
            this.NEI_Ch24_CheckBox.AutoSize = true;
            this.NEI_Ch24_CheckBox.Location = new System.Drawing.Point(116, 42);
            this.NEI_Ch24_CheckBox.Name = "NEI_Ch24_CheckBox";
            this.NEI_Ch24_CheckBox.Size = new System.Drawing.Size(52, 16);
            this.NEI_Ch24_CheckBox.TabIndex = 92;
            this.NEI_Ch24_CheckBox.Text = "Ch24";
            this.NEI_Ch24_CheckBox.UseVisualStyleBackColor = true;
            this.NEI_Ch24_CheckBox.CheckedChanged += new System.EventHandler(this.NEI_Ch24_CheckBox_CheckedChanged);
            // 
            // NEI_Ch22_CheckBox
            // 
            this.NEI_Ch22_CheckBox.AutoSize = true;
            this.NEI_Ch22_CheckBox.Location = new System.Drawing.Point(6, 42);
            this.NEI_Ch22_CheckBox.Name = "NEI_Ch22_CheckBox";
            this.NEI_Ch22_CheckBox.Size = new System.Drawing.Size(52, 16);
            this.NEI_Ch22_CheckBox.TabIndex = 90;
            this.NEI_Ch22_CheckBox.Text = "Ch22";
            this.NEI_Ch22_CheckBox.UseVisualStyleBackColor = true;
            this.NEI_Ch22_CheckBox.CheckedChanged += new System.EventHandler(this.NEI_Ch22_CheckBox_CheckedChanged);
            // 
            // NEI_Ch16_CheckBox
            // 
            this.NEI_Ch16_CheckBox.AutoSize = true;
            this.NEI_Ch16_CheckBox.Location = new System.Drawing.Point(58, 20);
            this.NEI_Ch16_CheckBox.Name = "NEI_Ch16_CheckBox";
            this.NEI_Ch16_CheckBox.Size = new System.Drawing.Size(52, 16);
            this.NEI_Ch16_CheckBox.TabIndex = 84;
            this.NEI_Ch16_CheckBox.Text = "Ch16";
            this.NEI_Ch16_CheckBox.UseVisualStyleBackColor = true;
            this.NEI_Ch16_CheckBox.CheckedChanged += new System.EventHandler(this.NEI_Ch16_CheckBox_CheckedChanged);
            // 
            // NEI_Ch25_CheckBox
            // 
            this.NEI_Ch25_CheckBox.AutoSize = true;
            this.NEI_Ch25_CheckBox.Location = new System.Drawing.Point(174, 42);
            this.NEI_Ch25_CheckBox.Name = "NEI_Ch25_CheckBox";
            this.NEI_Ch25_CheckBox.Size = new System.Drawing.Size(52, 16);
            this.NEI_Ch25_CheckBox.TabIndex = 93;
            this.NEI_Ch25_CheckBox.Text = "Ch25";
            this.NEI_Ch25_CheckBox.UseVisualStyleBackColor = true;
            this.NEI_Ch25_CheckBox.CheckedChanged += new System.EventHandler(this.NEI_Ch25_CheckBox_CheckedChanged);
            // 
            // NEI_Ch21_CheckBox
            // 
            this.NEI_Ch21_CheckBox.AutoSize = true;
            this.NEI_Ch21_CheckBox.Location = new System.Drawing.Point(348, 20);
            this.NEI_Ch21_CheckBox.Name = "NEI_Ch21_CheckBox";
            this.NEI_Ch21_CheckBox.Size = new System.Drawing.Size(52, 16);
            this.NEI_Ch21_CheckBox.TabIndex = 89;
            this.NEI_Ch21_CheckBox.Text = "Ch21";
            this.NEI_Ch21_CheckBox.UseVisualStyleBackColor = true;
            this.NEI_Ch21_CheckBox.CheckedChanged += new System.EventHandler(this.NEI_Ch21_CheckBox_CheckedChanged);
            // 
            // NEI_Ch18_CheckBox
            // 
            this.NEI_Ch18_CheckBox.AutoSize = true;
            this.NEI_Ch18_CheckBox.Location = new System.Drawing.Point(174, 20);
            this.NEI_Ch18_CheckBox.Name = "NEI_Ch18_CheckBox";
            this.NEI_Ch18_CheckBox.Size = new System.Drawing.Size(52, 16);
            this.NEI_Ch18_CheckBox.TabIndex = 86;
            this.NEI_Ch18_CheckBox.Text = "Ch18";
            this.NEI_Ch18_CheckBox.UseVisualStyleBackColor = true;
            this.NEI_Ch18_CheckBox.CheckedChanged += new System.EventHandler(this.NEI_Ch18_CheckBox_CheckedChanged);
            // 
            // NEI_Ch17_CheckBox
            // 
            this.NEI_Ch17_CheckBox.AutoSize = true;
            this.NEI_Ch17_CheckBox.Location = new System.Drawing.Point(116, 20);
            this.NEI_Ch17_CheckBox.Name = "NEI_Ch17_CheckBox";
            this.NEI_Ch17_CheckBox.Size = new System.Drawing.Size(52, 16);
            this.NEI_Ch17_CheckBox.TabIndex = 85;
            this.NEI_Ch17_CheckBox.Text = "Ch17";
            this.NEI_Ch17_CheckBox.UseVisualStyleBackColor = true;
            this.NEI_Ch17_CheckBox.CheckedChanged += new System.EventHandler(this.NEI_Ch17_CheckBox_CheckedChanged);
            // 
            // NEI_Ch26_CheckBox
            // 
            this.NEI_Ch26_CheckBox.AutoSize = true;
            this.NEI_Ch26_CheckBox.Location = new System.Drawing.Point(232, 42);
            this.NEI_Ch26_CheckBox.Name = "NEI_Ch26_CheckBox";
            this.NEI_Ch26_CheckBox.Size = new System.Drawing.Size(52, 16);
            this.NEI_Ch26_CheckBox.TabIndex = 94;
            this.NEI_Ch26_CheckBox.Text = "Ch26";
            this.NEI_Ch26_CheckBox.UseVisualStyleBackColor = true;
            this.NEI_Ch26_CheckBox.CheckedChanged += new System.EventHandler(this.NEI_Ch26_CheckBox_CheckedChanged);
            // 
            // NEI42_GPIN1_GroupBox
            // 
            this.NEI42_GPIN1_GroupBox.Controls.Add(this.NEI_Ch13_CheckBox);
            this.NEI42_GPIN1_GroupBox.Controls.Add(this.NEI_Ch1_CheckBox);
            this.NEI42_GPIN1_GroupBox.Controls.Add(this.NEI_Ch14_CheckBox);
            this.NEI42_GPIN1_GroupBox.Controls.Add(this.NEI_Ch5_CheckBox);
            this.NEI42_GPIN1_GroupBox.Controls.Add(this.NEI_Ch9_CheckBox);
            this.NEI42_GPIN1_GroupBox.Controls.Add(this.NEI_Ch6_CheckBox);
            this.NEI42_GPIN1_GroupBox.Controls.Add(this.NEI_Ch10_CheckBox);
            this.NEI42_GPIN1_GroupBox.Controls.Add(this.NEI_Ch8_CheckBox);
            this.NEI42_GPIN1_GroupBox.Controls.Add(this.NEI_Ch2_CheckBox);
            this.NEI42_GPIN1_GroupBox.Controls.Add(this.NEI_Ch11_CheckBox);
            this.NEI42_GPIN1_GroupBox.Controls.Add(this.NEI_Ch7_CheckBox);
            this.NEI42_GPIN1_GroupBox.Controls.Add(this.NEI_Ch4_CheckBox);
            this.NEI42_GPIN1_GroupBox.Controls.Add(this.NEI_Ch3_CheckBox);
            this.NEI42_GPIN1_GroupBox.Controls.Add(this.NEI_Ch12_CheckBox);
            this.NEI42_GPIN1_GroupBox.Location = new System.Drawing.Point(6, 18);
            this.NEI42_GPIN1_GroupBox.Name = "NEI42_GPIN1_GroupBox";
            this.NEI42_GPIN1_GroupBox.Size = new System.Drawing.Size(459, 67);
            this.NEI42_GPIN1_GroupBox.TabIndex = 58;
            this.NEI42_GPIN1_GroupBox.TabStop = false;
            this.NEI42_GPIN1_GroupBox.Text = "GPIN1";
            // 
            // NEI_Ch13_CheckBox
            // 
            this.NEI_Ch13_CheckBox.AutoSize = true;
            this.NEI_Ch13_CheckBox.Location = new System.Drawing.Point(290, 42);
            this.NEI_Ch13_CheckBox.Name = "NEI_Ch13_CheckBox";
            this.NEI_Ch13_CheckBox.Size = new System.Drawing.Size(52, 16);
            this.NEI_Ch13_CheckBox.TabIndex = 95;
            this.NEI_Ch13_CheckBox.Text = "Ch13";
            this.NEI_Ch13_CheckBox.UseVisualStyleBackColor = true;
            this.NEI_Ch13_CheckBox.CheckedChanged += new System.EventHandler(this.NEI_Ch13_CheckBox_CheckedChanged);
            // 
            // NEI_Ch1_CheckBox
            // 
            this.NEI_Ch1_CheckBox.AutoSize = true;
            this.NEI_Ch1_CheckBox.Location = new System.Drawing.Point(6, 20);
            this.NEI_Ch1_CheckBox.Name = "NEI_Ch1_CheckBox";
            this.NEI_Ch1_CheckBox.Size = new System.Drawing.Size(46, 16);
            this.NEI_Ch1_CheckBox.TabIndex = 83;
            this.NEI_Ch1_CheckBox.Text = "Ch1";
            this.NEI_Ch1_CheckBox.UseVisualStyleBackColor = true;
            this.NEI_Ch1_CheckBox.CheckedChanged += new System.EventHandler(this.NEI_Ch1_CheckBox_CheckedChanged);
            // 
            // NEI_Ch14_CheckBox
            // 
            this.NEI_Ch14_CheckBox.AutoSize = true;
            this.NEI_Ch14_CheckBox.Location = new System.Drawing.Point(348, 42);
            this.NEI_Ch14_CheckBox.Name = "NEI_Ch14_CheckBox";
            this.NEI_Ch14_CheckBox.Size = new System.Drawing.Size(52, 16);
            this.NEI_Ch14_CheckBox.TabIndex = 96;
            this.NEI_Ch14_CheckBox.Text = "Ch14";
            this.NEI_Ch14_CheckBox.UseVisualStyleBackColor = true;
            this.NEI_Ch14_CheckBox.CheckedChanged += new System.EventHandler(this.NEI_Ch14_CheckBox_CheckedChanged);
            // 
            // NEI_Ch5_CheckBox
            // 
            this.NEI_Ch5_CheckBox.AutoSize = true;
            this.NEI_Ch5_CheckBox.Location = new System.Drawing.Point(232, 20);
            this.NEI_Ch5_CheckBox.Name = "NEI_Ch5_CheckBox";
            this.NEI_Ch5_CheckBox.Size = new System.Drawing.Size(46, 16);
            this.NEI_Ch5_CheckBox.TabIndex = 87;
            this.NEI_Ch5_CheckBox.Text = "Ch5";
            this.NEI_Ch5_CheckBox.UseVisualStyleBackColor = true;
            this.NEI_Ch5_CheckBox.CheckedChanged += new System.EventHandler(this.NEI_Ch5_CheckBox_CheckedChanged);
            // 
            // NEI_Ch9_CheckBox
            // 
            this.NEI_Ch9_CheckBox.AutoSize = true;
            this.NEI_Ch9_CheckBox.Location = new System.Drawing.Point(58, 42);
            this.NEI_Ch9_CheckBox.Name = "NEI_Ch9_CheckBox";
            this.NEI_Ch9_CheckBox.Size = new System.Drawing.Size(46, 16);
            this.NEI_Ch9_CheckBox.TabIndex = 91;
            this.NEI_Ch9_CheckBox.Text = "Ch9";
            this.NEI_Ch9_CheckBox.UseVisualStyleBackColor = true;
            this.NEI_Ch9_CheckBox.CheckedChanged += new System.EventHandler(this.NEI_Ch9_CheckBox_CheckedChanged);
            // 
            // NEI_Ch6_CheckBox
            // 
            this.NEI_Ch6_CheckBox.AutoSize = true;
            this.NEI_Ch6_CheckBox.Location = new System.Drawing.Point(290, 20);
            this.NEI_Ch6_CheckBox.Name = "NEI_Ch6_CheckBox";
            this.NEI_Ch6_CheckBox.Size = new System.Drawing.Size(46, 16);
            this.NEI_Ch6_CheckBox.TabIndex = 88;
            this.NEI_Ch6_CheckBox.Text = "Ch6";
            this.NEI_Ch6_CheckBox.UseVisualStyleBackColor = true;
            this.NEI_Ch6_CheckBox.CheckedChanged += new System.EventHandler(this.NEI_Ch6_CheckBox_CheckedChanged);
            // 
            // NEI_Ch10_CheckBox
            // 
            this.NEI_Ch10_CheckBox.AutoSize = true;
            this.NEI_Ch10_CheckBox.Location = new System.Drawing.Point(116, 42);
            this.NEI_Ch10_CheckBox.Name = "NEI_Ch10_CheckBox";
            this.NEI_Ch10_CheckBox.Size = new System.Drawing.Size(52, 16);
            this.NEI_Ch10_CheckBox.TabIndex = 92;
            this.NEI_Ch10_CheckBox.Text = "Ch10";
            this.NEI_Ch10_CheckBox.UseVisualStyleBackColor = true;
            this.NEI_Ch10_CheckBox.CheckedChanged += new System.EventHandler(this.NEI_Ch10_CheckBox_CheckedChanged);
            // 
            // NEI_Ch8_CheckBox
            // 
            this.NEI_Ch8_CheckBox.AutoSize = true;
            this.NEI_Ch8_CheckBox.Location = new System.Drawing.Point(6, 42);
            this.NEI_Ch8_CheckBox.Name = "NEI_Ch8_CheckBox";
            this.NEI_Ch8_CheckBox.Size = new System.Drawing.Size(46, 16);
            this.NEI_Ch8_CheckBox.TabIndex = 90;
            this.NEI_Ch8_CheckBox.Text = "Ch8";
            this.NEI_Ch8_CheckBox.UseVisualStyleBackColor = true;
            this.NEI_Ch8_CheckBox.CheckedChanged += new System.EventHandler(this.NEI_Ch8_CheckBox_CheckedChanged);
            // 
            // NEI_Ch2_CheckBox
            // 
            this.NEI_Ch2_CheckBox.AutoSize = true;
            this.NEI_Ch2_CheckBox.Location = new System.Drawing.Point(58, 20);
            this.NEI_Ch2_CheckBox.Name = "NEI_Ch2_CheckBox";
            this.NEI_Ch2_CheckBox.Size = new System.Drawing.Size(46, 16);
            this.NEI_Ch2_CheckBox.TabIndex = 84;
            this.NEI_Ch2_CheckBox.Text = "Ch2";
            this.NEI_Ch2_CheckBox.UseVisualStyleBackColor = true;
            this.NEI_Ch2_CheckBox.CheckedChanged += new System.EventHandler(this.NEI_Ch2_CheckBox_CheckedChanged);
            // 
            // NEI_Ch11_CheckBox
            // 
            this.NEI_Ch11_CheckBox.AutoSize = true;
            this.NEI_Ch11_CheckBox.Location = new System.Drawing.Point(174, 42);
            this.NEI_Ch11_CheckBox.Name = "NEI_Ch11_CheckBox";
            this.NEI_Ch11_CheckBox.Size = new System.Drawing.Size(52, 16);
            this.NEI_Ch11_CheckBox.TabIndex = 93;
            this.NEI_Ch11_CheckBox.Text = "Ch11";
            this.NEI_Ch11_CheckBox.UseVisualStyleBackColor = true;
            this.NEI_Ch11_CheckBox.CheckedChanged += new System.EventHandler(this.NEI_Ch11_CheckBox_CheckedChanged);
            // 
            // NEI_Ch7_CheckBox
            // 
            this.NEI_Ch7_CheckBox.AutoSize = true;
            this.NEI_Ch7_CheckBox.Location = new System.Drawing.Point(348, 20);
            this.NEI_Ch7_CheckBox.Name = "NEI_Ch7_CheckBox";
            this.NEI_Ch7_CheckBox.Size = new System.Drawing.Size(46, 16);
            this.NEI_Ch7_CheckBox.TabIndex = 89;
            this.NEI_Ch7_CheckBox.Text = "Ch7";
            this.NEI_Ch7_CheckBox.UseVisualStyleBackColor = true;
            this.NEI_Ch7_CheckBox.CheckedChanged += new System.EventHandler(this.NEI_Ch7_CheckBox_CheckedChanged);
            // 
            // NEI_Ch4_CheckBox
            // 
            this.NEI_Ch4_CheckBox.AutoSize = true;
            this.NEI_Ch4_CheckBox.Location = new System.Drawing.Point(174, 20);
            this.NEI_Ch4_CheckBox.Name = "NEI_Ch4_CheckBox";
            this.NEI_Ch4_CheckBox.Size = new System.Drawing.Size(46, 16);
            this.NEI_Ch4_CheckBox.TabIndex = 86;
            this.NEI_Ch4_CheckBox.Text = "Ch4";
            this.NEI_Ch4_CheckBox.UseVisualStyleBackColor = true;
            this.NEI_Ch4_CheckBox.CheckedChanged += new System.EventHandler(this.NEI_Ch4_CheckBox_CheckedChanged);
            // 
            // NEI_Ch3_CheckBox
            // 
            this.NEI_Ch3_CheckBox.AutoSize = true;
            this.NEI_Ch3_CheckBox.Location = new System.Drawing.Point(116, 20);
            this.NEI_Ch3_CheckBox.Name = "NEI_Ch3_CheckBox";
            this.NEI_Ch3_CheckBox.Size = new System.Drawing.Size(46, 16);
            this.NEI_Ch3_CheckBox.TabIndex = 85;
            this.NEI_Ch3_CheckBox.Text = "Ch3";
            this.NEI_Ch3_CheckBox.UseVisualStyleBackColor = true;
            this.NEI_Ch3_CheckBox.CheckedChanged += new System.EventHandler(this.NEI_Ch3_CheckBox_CheckedChanged);
            // 
            // NEI_Ch12_CheckBox
            // 
            this.NEI_Ch12_CheckBox.AutoSize = true;
            this.NEI_Ch12_CheckBox.Location = new System.Drawing.Point(232, 42);
            this.NEI_Ch12_CheckBox.Name = "NEI_Ch12_CheckBox";
            this.NEI_Ch12_CheckBox.Size = new System.Drawing.Size(52, 16);
            this.NEI_Ch12_CheckBox.TabIndex = 94;
            this.NEI_Ch12_CheckBox.Text = "Ch12";
            this.NEI_Ch12_CheckBox.UseVisualStyleBackColor = true;
            this.NEI_Ch12_CheckBox.CheckedChanged += new System.EventHandler(this.NEI_Ch12_CheckBox_CheckedChanged);
            // 
            // Fire_TabPage
            // 
            this.Fire_TabPage.Controls.Add(this.button3);
            this.Fire_TabPage.Controls.Add(this.button4);
            this.Fire_TabPage.Controls.Add(this.label7);
            this.Fire_TabPage.Controls.Add(this.button1);
            this.Fire_TabPage.Controls.Add(this.textBox2);
            this.Fire_TabPage.Controls.Add(this.listBox1);
            this.Fire_TabPage.Controls.Add(this.button2);
            this.Fire_TabPage.Controls.Add(this.groupBox8);
            this.Fire_TabPage.Controls.Add(this.Fire_Insert_Button);
            this.Fire_TabPage.Controls.Add(this.Fire12Byte_Total_GroupBox);
            this.Fire_TabPage.Controls.Add(this.Fire10Byte_Total_GroupBox);
            this.Fire_TabPage.Controls.Add(this.Fire_Select_GroupBox);
            this.Fire_TabPage.Location = new System.Drawing.Point(4, 22);
            this.Fire_TabPage.Name = "Fire_TabPage";
            this.Fire_TabPage.Padding = new System.Windows.Forms.Padding(3);
            this.Fire_TabPage.Size = new System.Drawing.Size(484, 625);
            this.Fire_TabPage.TabIndex = 8;
            this.Fire_TabPage.Text = "Fire(10, 12Byte)";
            this.Fire_TabPage.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(376, 414);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(84, 30);
            this.button3.TabIndex = 60;
            this.button3.Text = "연속 전송";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(286, 414);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(84, 30);
            this.button4.TabIndex = 59;
            this.button4.Text = "한번 전송";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(305, 493);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 58;
            this.label7.Text = "Delay(ms)";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(376, 452);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 30);
            this.button1.TabIndex = 58;
            this.button1.Text = "연속 전송";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(376, 488);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(67, 21);
            this.textBox2.TabIndex = 57;
            this.textBox2.Text = "500";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(6, 415);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(274, 208);
            this.listBox1.TabIndex = 57;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(286, 452);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 30);
            this.button2.TabIndex = 57;
            this.button2.Text = "한번 전송";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.Auto_RadioButton);
            this.groupBox8.Controls.Add(this.Manual_RadioButton);
            this.groupBox8.Location = new System.Drawing.Point(159, 6);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(147, 70);
            this.groupBox8.TabIndex = 8;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "수동/자동";
            // 
            // Auto_RadioButton
            // 
            this.Auto_RadioButton.AutoSize = true;
            this.Auto_RadioButton.Location = new System.Drawing.Point(74, 32);
            this.Auto_RadioButton.Name = "Auto_RadioButton";
            this.Auto_RadioButton.Size = new System.Drawing.Size(47, 16);
            this.Auto_RadioButton.TabIndex = 2;
            this.Auto_RadioButton.TabStop = true;
            this.Auto_RadioButton.Text = "자동";
            this.Auto_RadioButton.UseVisualStyleBackColor = true;
            this.Auto_RadioButton.CheckedChanged += new System.EventHandler(this.Auto_RadioButton_CheckedChanged);
            // 
            // Manual_RadioButton
            // 
            this.Manual_RadioButton.AutoSize = true;
            this.Manual_RadioButton.Location = new System.Drawing.Point(8, 32);
            this.Manual_RadioButton.Name = "Manual_RadioButton";
            this.Manual_RadioButton.Size = new System.Drawing.Size(47, 16);
            this.Manual_RadioButton.TabIndex = 1;
            this.Manual_RadioButton.TabStop = true;
            this.Manual_RadioButton.Text = "수동";
            this.Manual_RadioButton.UseVisualStyleBackColor = true;
            this.Manual_RadioButton.CheckedChanged += new System.EventHandler(this.Manual_RadioButton_CheckedChanged);
            // 
            // Fire_Insert_Button
            // 
            this.Fire_Insert_Button.Location = new System.Drawing.Point(434, 24);
            this.Fire_Insert_Button.Name = "Fire_Insert_Button";
            this.Fire_Insert_Button.Size = new System.Drawing.Size(44, 41);
            this.Fire_Insert_Button.TabIndex = 54;
            this.Fire_Insert_Button.Text = ">>";
            this.Fire_Insert_Button.UseVisualStyleBackColor = true;
            this.Fire_Insert_Button.Click += new System.EventHandler(this.Fire_Insert_Button_Click);
            // 
            // Fire12Byte_Total_GroupBox
            // 
            this.Fire12Byte_Total_GroupBox.Controls.Add(this.FIRE12Byte_Operate_Label);
            this.Fire12Byte_Total_GroupBox.Controls.Add(this.Fire12Byte_Reset_Button);
            this.Fire12Byte_Total_GroupBox.Controls.Add(this.FIRE12Byte_Operate_ConboBox);
            this.Fire12Byte_Total_GroupBox.Controls.Add(this.label22);
            this.Fire12Byte_Total_GroupBox.Controls.Add(this.Fire12Byte_Audio_Stop_Button);
            this.Fire12Byte_Total_GroupBox.Controls.Add(this.FIRE12Byte_Floor_ID_Label);
            this.Fire12Byte_Total_GroupBox.Controls.Add(this.Fire12Byte_Audio_Start_Button);
            this.Fire12Byte_Total_GroupBox.Controls.Add(this.FIRE12Byte_Dong_ID_10_ConboBox);
            this.Fire12Byte_Total_GroupBox.Controls.Add(this.Fire12Byte_Stop_Button);
            this.Fire12Byte_Total_GroupBox.Controls.Add(this.FIRE12Byte_Gaedan_ID_Label);
            this.Fire12Byte_Total_GroupBox.Controls.Add(this.Fire12Byte_Start_Button);
            this.Fire12Byte_Total_GroupBox.Controls.Add(this.FIRE12Byte_Dong_ID_1_ConboBox);
            this.Fire12Byte_Total_GroupBox.Controls.Add(this.FIRE12Byte_Dong_ID_Label);
            this.Fire12Byte_Total_GroupBox.Controls.Add(this.FIRE12Byte_Floor_ID_10_ConboBox);
            this.Fire12Byte_Total_GroupBox.Controls.Add(this.label21);
            this.Fire12Byte_Total_GroupBox.Controls.Add(this.FIRE12Byte_Floor_ID_1_ConboBox);
            this.Fire12Byte_Total_GroupBox.Controls.Add(this.FIRE12Byte_Gaedan_ID_1_ConboBox);
            this.Fire12Byte_Total_GroupBox.Controls.Add(this.FIRE12Byte_Gaedan_ID_10_ConboBox);
            this.Fire12Byte_Total_GroupBox.Location = new System.Drawing.Point(6, 248);
            this.Fire12Byte_Total_GroupBox.Name = "Fire12Byte_Total_GroupBox";
            this.Fire12Byte_Total_GroupBox.Size = new System.Drawing.Size(469, 161);
            this.Fire12Byte_Total_GroupBox.TabIndex = 9;
            this.Fire12Byte_Total_GroupBox.TabStop = false;
            this.Fire12Byte_Total_GroupBox.Text = "12Byte";
            // 
            // FIRE12Byte_Operate_Label
            // 
            this.FIRE12Byte_Operate_Label.AutoSize = true;
            this.FIRE12Byte_Operate_Label.Location = new System.Drawing.Point(24, 110);
            this.FIRE12Byte_Operate_Label.Name = "FIRE12Byte_Operate_Label";
            this.FIRE12Byte_Operate_Label.Size = new System.Drawing.Size(49, 12);
            this.FIRE12Byte_Operate_Label.TabIndex = 82;
            this.FIRE12Byte_Operate_Label.Text = "동     작";
            // 
            // Fire12Byte_Reset_Button
            // 
            this.Fire12Byte_Reset_Button.Location = new System.Drawing.Point(234, 99);
            this.Fire12Byte_Reset_Button.Name = "Fire12Byte_Reset_Button";
            this.Fire12Byte_Reset_Button.Size = new System.Drawing.Size(229, 35);
            this.Fire12Byte_Reset_Button.TabIndex = 83;
            this.Fire12Byte_Reset_Button.Text = "전체 복구 신호";
            this.Fire12Byte_Reset_Button.UseVisualStyleBackColor = true;
            this.Fire12Byte_Reset_Button.Click += new System.EventHandler(this.Fire12Byte_Reset_Button_Click);
            // 
            // FIRE12Byte_Operate_ConboBox
            // 
            this.FIRE12Byte_Operate_ConboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.FIRE12Byte_Operate_ConboBox.FormattingEnabled = true;
            this.FIRE12Byte_Operate_ConboBox.Items.AddRange(new object[] {
            "화재발생",
            "화재정지",
            "연동정상",
            "연동정지",
            "전체 복구 신호"});
            this.FIRE12Byte_Operate_ConboBox.Location = new System.Drawing.Point(102, 107);
            this.FIRE12Byte_Operate_ConboBox.Name = "FIRE12Byte_Operate_ConboBox";
            this.FIRE12Byte_Operate_ConboBox.Size = new System.Drawing.Size(121, 20);
            this.FIRE12Byte_Operate_ConboBox.TabIndex = 81;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(114, 14);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(41, 12);
            this.label22.TabIndex = 75;
            this.label22.Text = "십자리";
            // 
            // Fire12Byte_Audio_Stop_Button
            // 
            this.Fire12Byte_Audio_Stop_Button.Location = new System.Drawing.Point(356, 64);
            this.Fire12Byte_Audio_Stop_Button.Name = "Fire12Byte_Audio_Stop_Button";
            this.Fire12Byte_Audio_Stop_Button.Size = new System.Drawing.Size(109, 29);
            this.Fire12Byte_Audio_Stop_Button.TabIndex = 82;
            this.Fire12Byte_Audio_Stop_Button.Text = "연동정지";
            this.Fire12Byte_Audio_Stop_Button.UseVisualStyleBackColor = true;
            this.Fire12Byte_Audio_Stop_Button.Click += new System.EventHandler(this.Fire12Byte_Audio_Stop_Button_Click);
            // 
            // FIRE12Byte_Floor_ID_Label
            // 
            this.FIRE12Byte_Floor_ID_Label.AutoSize = true;
            this.FIRE12Byte_Floor_ID_Label.Location = new System.Drawing.Point(0, 84);
            this.FIRE12Byte_Floor_ID_Label.Name = "FIRE12Byte_Floor_ID_Label";
            this.FIRE12Byte_Floor_ID_Label.Size = new System.Drawing.Size(97, 12);
            this.FIRE12Byte_Floor_ID_Label.TabIndex = 86;
            this.FIRE12Byte_Floor_ID_Label.Text = "장소3 (    층     )";
            // 
            // Fire12Byte_Audio_Start_Button
            // 
            this.Fire12Byte_Audio_Start_Button.Location = new System.Drawing.Point(236, 64);
            this.Fire12Byte_Audio_Start_Button.Name = "Fire12Byte_Audio_Start_Button";
            this.Fire12Byte_Audio_Start_Button.Size = new System.Drawing.Size(114, 29);
            this.Fire12Byte_Audio_Start_Button.TabIndex = 81;
            this.Fire12Byte_Audio_Start_Button.Text = "연동정상";
            this.Fire12Byte_Audio_Start_Button.UseVisualStyleBackColor = true;
            this.Fire12Byte_Audio_Start_Button.Click += new System.EventHandler(this.Fire12Byte_Audio_Start_Button_Click);
            // 
            // FIRE12Byte_Dong_ID_10_ConboBox
            // 
            this.FIRE12Byte_Dong_ID_10_ConboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.FIRE12Byte_Dong_ID_10_ConboBox.FormattingEnabled = true;
            this.FIRE12Byte_Dong_ID_10_ConboBox.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.FIRE12Byte_Dong_ID_10_ConboBox.Location = new System.Drawing.Point(102, 29);
            this.FIRE12Byte_Dong_ID_10_ConboBox.Name = "FIRE12Byte_Dong_ID_10_ConboBox";
            this.FIRE12Byte_Dong_ID_10_ConboBox.Size = new System.Drawing.Size(57, 20);
            this.FIRE12Byte_Dong_ID_10_ConboBox.TabIndex = 76;
            // 
            // Fire12Byte_Stop_Button
            // 
            this.Fire12Byte_Stop_Button.Location = new System.Drawing.Point(356, 29);
            this.Fire12Byte_Stop_Button.Name = "Fire12Byte_Stop_Button";
            this.Fire12Byte_Stop_Button.Size = new System.Drawing.Size(109, 29);
            this.Fire12Byte_Stop_Button.TabIndex = 80;
            this.Fire12Byte_Stop_Button.Text = "화재정지";
            this.Fire12Byte_Stop_Button.UseVisualStyleBackColor = true;
            this.Fire12Byte_Stop_Button.Click += new System.EventHandler(this.Fire12Byte_Stop_Button_Click);
            // 
            // FIRE12Byte_Gaedan_ID_Label
            // 
            this.FIRE12Byte_Gaedan_ID_Label.AutoSize = true;
            this.FIRE12Byte_Gaedan_ID_Label.Location = new System.Drawing.Point(0, 58);
            this.FIRE12Byte_Gaedan_ID_Label.Name = "FIRE12Byte_Gaedan_ID_Label";
            this.FIRE12Byte_Gaedan_ID_Label.Size = new System.Drawing.Size(97, 12);
            this.FIRE12Byte_Gaedan_ID_Label.TabIndex = 85;
            this.FIRE12Byte_Gaedan_ID_Label.Text = "장소2 (계      단)";
            // 
            // Fire12Byte_Start_Button
            // 
            this.Fire12Byte_Start_Button.Location = new System.Drawing.Point(236, 29);
            this.Fire12Byte_Start_Button.Name = "Fire12Byte_Start_Button";
            this.Fire12Byte_Start_Button.Size = new System.Drawing.Size(114, 29);
            this.Fire12Byte_Start_Button.TabIndex = 79;
            this.Fire12Byte_Start_Button.Text = "화재발생";
            this.Fire12Byte_Start_Button.UseVisualStyleBackColor = true;
            this.Fire12Byte_Start_Button.Click += new System.EventHandler(this.Fire12Byte_Start_Button_Click);
            // 
            // FIRE12Byte_Dong_ID_1_ConboBox
            // 
            this.FIRE12Byte_Dong_ID_1_ConboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.FIRE12Byte_Dong_ID_1_ConboBox.FormattingEnabled = true;
            this.FIRE12Byte_Dong_ID_1_ConboBox.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.FIRE12Byte_Dong_ID_1_ConboBox.Location = new System.Drawing.Point(165, 29);
            this.FIRE12Byte_Dong_ID_1_ConboBox.Name = "FIRE12Byte_Dong_ID_1_ConboBox";
            this.FIRE12Byte_Dong_ID_1_ConboBox.Size = new System.Drawing.Size(57, 20);
            this.FIRE12Byte_Dong_ID_1_ConboBox.TabIndex = 77;
            // 
            // FIRE12Byte_Dong_ID_Label
            // 
            this.FIRE12Byte_Dong_ID_Label.AutoSize = true;
            this.FIRE12Byte_Dong_ID_Label.Location = new System.Drawing.Point(0, 32);
            this.FIRE12Byte_Dong_ID_Label.Name = "FIRE12Byte_Dong_ID_Label";
            this.FIRE12Byte_Dong_ID_Label.Size = new System.Drawing.Size(99, 12);
            this.FIRE12Byte_Dong_ID_Label.TabIndex = 84;
            this.FIRE12Byte_Dong_ID_Label.Text = "장소1 (동 / 빌딩)";
            // 
            // FIRE12Byte_Floor_ID_10_ConboBox
            // 
            this.FIRE12Byte_Floor_ID_10_ConboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.FIRE12Byte_Floor_ID_10_ConboBox.FormattingEnabled = true;
            this.FIRE12Byte_Floor_ID_10_ConboBox.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.FIRE12Byte_Floor_ID_10_ConboBox.Location = new System.Drawing.Point(102, 81);
            this.FIRE12Byte_Floor_ID_10_ConboBox.Name = "FIRE12Byte_Floor_ID_10_ConboBox";
            this.FIRE12Byte_Floor_ID_10_ConboBox.Size = new System.Drawing.Size(57, 20);
            this.FIRE12Byte_Floor_ID_10_ConboBox.TabIndex = 78;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(178, 14);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(41, 12);
            this.label21.TabIndex = 83;
            this.label21.Text = "일자리";
            // 
            // FIRE12Byte_Floor_ID_1_ConboBox
            // 
            this.FIRE12Byte_Floor_ID_1_ConboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.FIRE12Byte_Floor_ID_1_ConboBox.FormattingEnabled = true;
            this.FIRE12Byte_Floor_ID_1_ConboBox.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.FIRE12Byte_Floor_ID_1_ConboBox.Location = new System.Drawing.Point(166, 81);
            this.FIRE12Byte_Floor_ID_1_ConboBox.Name = "FIRE12Byte_Floor_ID_1_ConboBox";
            this.FIRE12Byte_Floor_ID_1_ConboBox.Size = new System.Drawing.Size(57, 20);
            this.FIRE12Byte_Floor_ID_1_ConboBox.TabIndex = 79;
            // 
            // FIRE12Byte_Gaedan_ID_1_ConboBox
            // 
            this.FIRE12Byte_Gaedan_ID_1_ConboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.FIRE12Byte_Gaedan_ID_1_ConboBox.FormattingEnabled = true;
            this.FIRE12Byte_Gaedan_ID_1_ConboBox.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.FIRE12Byte_Gaedan_ID_1_ConboBox.Location = new System.Drawing.Point(166, 55);
            this.FIRE12Byte_Gaedan_ID_1_ConboBox.Name = "FIRE12Byte_Gaedan_ID_1_ConboBox";
            this.FIRE12Byte_Gaedan_ID_1_ConboBox.Size = new System.Drawing.Size(57, 20);
            this.FIRE12Byte_Gaedan_ID_1_ConboBox.TabIndex = 82;
            // 
            // FIRE12Byte_Gaedan_ID_10_ConboBox
            // 
            this.FIRE12Byte_Gaedan_ID_10_ConboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.FIRE12Byte_Gaedan_ID_10_ConboBox.FormattingEnabled = true;
            this.FIRE12Byte_Gaedan_ID_10_ConboBox.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.FIRE12Byte_Gaedan_ID_10_ConboBox.Location = new System.Drawing.Point(102, 55);
            this.FIRE12Byte_Gaedan_ID_10_ConboBox.Name = "FIRE12Byte_Gaedan_ID_10_ConboBox";
            this.FIRE12Byte_Gaedan_ID_10_ConboBox.Size = new System.Drawing.Size(57, 20);
            this.FIRE12Byte_Gaedan_ID_10_ConboBox.TabIndex = 81;
            // 
            // Fire10Byte_Total_GroupBox
            // 
            this.Fire10Byte_Total_GroupBox.Controls.Add(this.FIRE10Byte_Operate_Label);
            this.Fire10Byte_Total_GroupBox.Controls.Add(this.FIRE10Byte_Operate_ConboBox);
            this.Fire10Byte_Total_GroupBox.Controls.Add(this.Fire10Byte_Reset_Button);
            this.Fire10Byte_Total_GroupBox.Controls.Add(this.Fire10Byte_Audio_Stop_Button);
            this.Fire10Byte_Total_GroupBox.Controls.Add(this.Fire10Byte_Audio_Start_Button);
            this.Fire10Byte_Total_GroupBox.Controls.Add(this.Fire10Byte_Stop_Button);
            this.Fire10Byte_Total_GroupBox.Controls.Add(this.FIRE10Byte_Seperate_ID_Label);
            this.Fire10Byte_Total_GroupBox.Controls.Add(this.Fire10Byte_Start_Button);
            this.Fire10Byte_Total_GroupBox.Controls.Add(this.FIRE10Byte_Floor_ID_Label);
            this.Fire10Byte_Total_GroupBox.Controls.Add(this.FIRE10Byte_Gaedan_ID_Label);
            this.Fire10Byte_Total_GroupBox.Controls.Add(this.FIRE10Byte_Dong_ID_Label);
            this.Fire10Byte_Total_GroupBox.Controls.Add(this.label12);
            this.Fire10Byte_Total_GroupBox.Controls.Add(this.label9);
            this.Fire10Byte_Total_GroupBox.Controls.Add(this.FIRE10Byte_Gaedan_ID_1_ConboBox);
            this.Fire10Byte_Total_GroupBox.Controls.Add(this.FIRE10Byte_Seperate_ID_ConboBox);
            this.Fire10Byte_Total_GroupBox.Controls.Add(this.FIRE10Byte_Floor_ID_1_ConboBox);
            this.Fire10Byte_Total_GroupBox.Controls.Add(this.FIRE10Byte_Floor_ID_10_ConboBox);
            this.Fire10Byte_Total_GroupBox.Controls.Add(this.FIRE10Byte_Dong_ID_1_ConboBox);
            this.Fire10Byte_Total_GroupBox.Controls.Add(this.FIRE10Byte_Dong_ID_10_ConboBox);
            this.Fire10Byte_Total_GroupBox.Location = new System.Drawing.Point(6, 82);
            this.Fire10Byte_Total_GroupBox.Name = "Fire10Byte_Total_GroupBox";
            this.Fire10Byte_Total_GroupBox.Size = new System.Drawing.Size(469, 160);
            this.Fire10Byte_Total_GroupBox.TabIndex = 8;
            this.Fire10Byte_Total_GroupBox.TabStop = false;
            this.Fire10Byte_Total_GroupBox.Text = "10Byte";
            // 
            // FIRE10Byte_Operate_Label
            // 
            this.FIRE10Byte_Operate_Label.AutoSize = true;
            this.FIRE10Byte_Operate_Label.Location = new System.Drawing.Point(24, 137);
            this.FIRE10Byte_Operate_Label.Name = "FIRE10Byte_Operate_Label";
            this.FIRE10Byte_Operate_Label.Size = new System.Drawing.Size(49, 12);
            this.FIRE10Byte_Operate_Label.TabIndex = 80;
            this.FIRE10Byte_Operate_Label.Text = "동     작";
            // 
            // FIRE10Byte_Operate_ConboBox
            // 
            this.FIRE10Byte_Operate_ConboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.FIRE10Byte_Operate_ConboBox.FormattingEnabled = true;
            this.FIRE10Byte_Operate_ConboBox.Items.AddRange(new object[] {
            "화재발생",
            "화재정지",
            "연동정상",
            "연동정지",
            "전체 복구 신호"});
            this.FIRE10Byte_Operate_ConboBox.Location = new System.Drawing.Point(102, 134);
            this.FIRE10Byte_Operate_ConboBox.Name = "FIRE10Byte_Operate_ConboBox";
            this.FIRE10Byte_Operate_ConboBox.Size = new System.Drawing.Size(121, 20);
            this.FIRE10Byte_Operate_ConboBox.TabIndex = 79;
            // 
            // Fire10Byte_Reset_Button
            // 
            this.Fire10Byte_Reset_Button.Location = new System.Drawing.Point(236, 99);
            this.Fire10Byte_Reset_Button.Name = "Fire10Byte_Reset_Button";
            this.Fire10Byte_Reset_Button.Size = new System.Drawing.Size(227, 35);
            this.Fire10Byte_Reset_Button.TabIndex = 78;
            this.Fire10Byte_Reset_Button.Text = "전체 복구 신호";
            this.Fire10Byte_Reset_Button.UseVisualStyleBackColor = true;
            this.Fire10Byte_Reset_Button.Click += new System.EventHandler(this.Fire10Byte_Reset_Button_Click);
            // 
            // Fire10Byte_Audio_Stop_Button
            // 
            this.Fire10Byte_Audio_Stop_Button.Location = new System.Drawing.Point(356, 64);
            this.Fire10Byte_Audio_Stop_Button.Name = "Fire10Byte_Audio_Stop_Button";
            this.Fire10Byte_Audio_Stop_Button.Size = new System.Drawing.Size(109, 29);
            this.Fire10Byte_Audio_Stop_Button.TabIndex = 77;
            this.Fire10Byte_Audio_Stop_Button.Text = "연동정지";
            this.Fire10Byte_Audio_Stop_Button.UseVisualStyleBackColor = true;
            this.Fire10Byte_Audio_Stop_Button.Click += new System.EventHandler(this.Fire10Byte_Audio_Stop_Button_Click);
            // 
            // Fire10Byte_Audio_Start_Button
            // 
            this.Fire10Byte_Audio_Start_Button.Location = new System.Drawing.Point(236, 64);
            this.Fire10Byte_Audio_Start_Button.Name = "Fire10Byte_Audio_Start_Button";
            this.Fire10Byte_Audio_Start_Button.Size = new System.Drawing.Size(114, 29);
            this.Fire10Byte_Audio_Start_Button.TabIndex = 76;
            this.Fire10Byte_Audio_Start_Button.Text = "연동정상";
            this.Fire10Byte_Audio_Start_Button.UseVisualStyleBackColor = true;
            this.Fire10Byte_Audio_Start_Button.Click += new System.EventHandler(this.Fire10Byte_Audio_Start_Button_Click);
            // 
            // Fire10Byte_Stop_Button
            // 
            this.Fire10Byte_Stop_Button.Location = new System.Drawing.Point(356, 29);
            this.Fire10Byte_Stop_Button.Name = "Fire10Byte_Stop_Button";
            this.Fire10Byte_Stop_Button.Size = new System.Drawing.Size(109, 29);
            this.Fire10Byte_Stop_Button.TabIndex = 75;
            this.Fire10Byte_Stop_Button.Text = "화재정지";
            this.Fire10Byte_Stop_Button.UseVisualStyleBackColor = true;
            this.Fire10Byte_Stop_Button.Click += new System.EventHandler(this.Fire10Byte_Stop_Button_Click);
            // 
            // FIRE10Byte_Seperate_ID_Label
            // 
            this.FIRE10Byte_Seperate_ID_Label.AutoSize = true;
            this.FIRE10Byte_Seperate_ID_Label.Location = new System.Drawing.Point(24, 110);
            this.FIRE10Byte_Seperate_ID_Label.Name = "FIRE10Byte_Seperate_ID_Label";
            this.FIRE10Byte_Seperate_ID_Label.Size = new System.Drawing.Size(49, 12);
            this.FIRE10Byte_Seperate_ID_Label.TabIndex = 74;
            this.FIRE10Byte_Seperate_ID_Label.Text = "구     분";
            // 
            // Fire10Byte_Start_Button
            // 
            this.Fire10Byte_Start_Button.Location = new System.Drawing.Point(236, 29);
            this.Fire10Byte_Start_Button.Name = "Fire10Byte_Start_Button";
            this.Fire10Byte_Start_Button.Size = new System.Drawing.Size(114, 29);
            this.Fire10Byte_Start_Button.TabIndex = 53;
            this.Fire10Byte_Start_Button.Text = "화재발생";
            this.Fire10Byte_Start_Button.UseVisualStyleBackColor = true;
            this.Fire10Byte_Start_Button.Click += new System.EventHandler(this.Fire10Byte_Start_Button_Click);
            // 
            // FIRE10Byte_Floor_ID_Label
            // 
            this.FIRE10Byte_Floor_ID_Label.AutoSize = true;
            this.FIRE10Byte_Floor_ID_Label.Location = new System.Drawing.Point(2, 84);
            this.FIRE10Byte_Floor_ID_Label.Name = "FIRE10Byte_Floor_ID_Label";
            this.FIRE10Byte_Floor_ID_Label.Size = new System.Drawing.Size(97, 12);
            this.FIRE10Byte_Floor_ID_Label.TabIndex = 73;
            this.FIRE10Byte_Floor_ID_Label.Text = "장소3 (    층     )";
            // 
            // FIRE10Byte_Gaedan_ID_Label
            // 
            this.FIRE10Byte_Gaedan_ID_Label.AutoSize = true;
            this.FIRE10Byte_Gaedan_ID_Label.Location = new System.Drawing.Point(2, 58);
            this.FIRE10Byte_Gaedan_ID_Label.Name = "FIRE10Byte_Gaedan_ID_Label";
            this.FIRE10Byte_Gaedan_ID_Label.Size = new System.Drawing.Size(97, 12);
            this.FIRE10Byte_Gaedan_ID_Label.TabIndex = 72;
            this.FIRE10Byte_Gaedan_ID_Label.Text = "장소2 (계      단)";
            // 
            // FIRE10Byte_Dong_ID_Label
            // 
            this.FIRE10Byte_Dong_ID_Label.AutoSize = true;
            this.FIRE10Byte_Dong_ID_Label.Location = new System.Drawing.Point(2, 32);
            this.FIRE10Byte_Dong_ID_Label.Name = "FIRE10Byte_Dong_ID_Label";
            this.FIRE10Byte_Dong_ID_Label.Size = new System.Drawing.Size(99, 12);
            this.FIRE10Byte_Dong_ID_Label.TabIndex = 71;
            this.FIRE10Byte_Dong_ID_Label.Text = "장소1 (동 / 빌딩)";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(170, 14);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 12);
            this.label12.TabIndex = 70;
            this.label12.Text = "일자리";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(106, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 12);
            this.label9.TabIndex = 53;
            this.label9.Text = "십자리";
            // 
            // FIRE10Byte_Gaedan_ID_1_ConboBox
            // 
            this.FIRE10Byte_Gaedan_ID_1_ConboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.FIRE10Byte_Gaedan_ID_1_ConboBox.FormattingEnabled = true;
            this.FIRE10Byte_Gaedan_ID_1_ConboBox.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.FIRE10Byte_Gaedan_ID_1_ConboBox.Location = new System.Drawing.Point(102, 55);
            this.FIRE10Byte_Gaedan_ID_1_ConboBox.Name = "FIRE10Byte_Gaedan_ID_1_ConboBox";
            this.FIRE10Byte_Gaedan_ID_1_ConboBox.Size = new System.Drawing.Size(121, 20);
            this.FIRE10Byte_Gaedan_ID_1_ConboBox.TabIndex = 69;
            // 
            // FIRE10Byte_Seperate_ID_ConboBox
            // 
            this.FIRE10Byte_Seperate_ID_ConboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.FIRE10Byte_Seperate_ID_ConboBox.FormattingEnabled = true;
            this.FIRE10Byte_Seperate_ID_ConboBox.Items.AddRange(new object[] {
            "지상층(0x20)",
            "지하층(B)",
            "주차장(P)",
            "옥탑층(K)"});
            this.FIRE10Byte_Seperate_ID_ConboBox.Location = new System.Drawing.Point(102, 107);
            this.FIRE10Byte_Seperate_ID_ConboBox.Name = "FIRE10Byte_Seperate_ID_ConboBox";
            this.FIRE10Byte_Seperate_ID_ConboBox.Size = new System.Drawing.Size(121, 20);
            this.FIRE10Byte_Seperate_ID_ConboBox.TabIndex = 67;
            // 
            // FIRE10Byte_Floor_ID_1_ConboBox
            // 
            this.FIRE10Byte_Floor_ID_1_ConboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.FIRE10Byte_Floor_ID_1_ConboBox.FormattingEnabled = true;
            this.FIRE10Byte_Floor_ID_1_ConboBox.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.FIRE10Byte_Floor_ID_1_ConboBox.Location = new System.Drawing.Point(166, 81);
            this.FIRE10Byte_Floor_ID_1_ConboBox.Name = "FIRE10Byte_Floor_ID_1_ConboBox";
            this.FIRE10Byte_Floor_ID_1_ConboBox.Size = new System.Drawing.Size(57, 20);
            this.FIRE10Byte_Floor_ID_1_ConboBox.TabIndex = 66;
            // 
            // FIRE10Byte_Floor_ID_10_ConboBox
            // 
            this.FIRE10Byte_Floor_ID_10_ConboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.FIRE10Byte_Floor_ID_10_ConboBox.FormattingEnabled = true;
            this.FIRE10Byte_Floor_ID_10_ConboBox.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.FIRE10Byte_Floor_ID_10_ConboBox.Location = new System.Drawing.Point(102, 81);
            this.FIRE10Byte_Floor_ID_10_ConboBox.Name = "FIRE10Byte_Floor_ID_10_ConboBox";
            this.FIRE10Byte_Floor_ID_10_ConboBox.Size = new System.Drawing.Size(57, 20);
            this.FIRE10Byte_Floor_ID_10_ConboBox.TabIndex = 65;
            // 
            // FIRE10Byte_Dong_ID_1_ConboBox
            // 
            this.FIRE10Byte_Dong_ID_1_ConboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.FIRE10Byte_Dong_ID_1_ConboBox.FormattingEnabled = true;
            this.FIRE10Byte_Dong_ID_1_ConboBox.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.FIRE10Byte_Dong_ID_1_ConboBox.Location = new System.Drawing.Point(166, 29);
            this.FIRE10Byte_Dong_ID_1_ConboBox.Name = "FIRE10Byte_Dong_ID_1_ConboBox";
            this.FIRE10Byte_Dong_ID_1_ConboBox.Size = new System.Drawing.Size(57, 20);
            this.FIRE10Byte_Dong_ID_1_ConboBox.TabIndex = 64;
            // 
            // FIRE10Byte_Dong_ID_10_ConboBox
            // 
            this.FIRE10Byte_Dong_ID_10_ConboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.FIRE10Byte_Dong_ID_10_ConboBox.FormattingEnabled = true;
            this.FIRE10Byte_Dong_ID_10_ConboBox.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.FIRE10Byte_Dong_ID_10_ConboBox.Location = new System.Drawing.Point(102, 29);
            this.FIRE10Byte_Dong_ID_10_ConboBox.Name = "FIRE10Byte_Dong_ID_10_ConboBox";
            this.FIRE10Byte_Dong_ID_10_ConboBox.Size = new System.Drawing.Size(57, 20);
            this.FIRE10Byte_Dong_ID_10_ConboBox.TabIndex = 63;
            // 
            // Fire_Select_GroupBox
            // 
            this.Fire_Select_GroupBox.Controls.Add(this.Fire12Byte_Select_RadioButton);
            this.Fire_Select_GroupBox.Controls.Add(this.Fire10Byte_Select_RadioButton);
            this.Fire_Select_GroupBox.Location = new System.Drawing.Point(6, 6);
            this.Fire_Select_GroupBox.Name = "Fire_Select_GroupBox";
            this.Fire_Select_GroupBox.Size = new System.Drawing.Size(147, 70);
            this.Fire_Select_GroupBox.TabIndex = 7;
            this.Fire_Select_GroupBox.TabStop = false;
            this.Fire_Select_GroupBox.Text = "소방프로토콜";
            // 
            // Fire12Byte_Select_RadioButton
            // 
            this.Fire12Byte_Select_RadioButton.AutoSize = true;
            this.Fire12Byte_Select_RadioButton.Location = new System.Drawing.Point(74, 32);
            this.Fire12Byte_Select_RadioButton.Name = "Fire12Byte_Select_RadioButton";
            this.Fire12Byte_Select_RadioButton.Size = new System.Drawing.Size(60, 16);
            this.Fire12Byte_Select_RadioButton.TabIndex = 2;
            this.Fire12Byte_Select_RadioButton.TabStop = true;
            this.Fire12Byte_Select_RadioButton.Text = "12Byte";
            this.Fire12Byte_Select_RadioButton.UseVisualStyleBackColor = true;
            this.Fire12Byte_Select_RadioButton.CheckedChanged += new System.EventHandler(this.Fire12Byte_Select_RadioButton_CheckedChanged);
            // 
            // Fire10Byte_Select_RadioButton
            // 
            this.Fire10Byte_Select_RadioButton.AutoSize = true;
            this.Fire10Byte_Select_RadioButton.Location = new System.Drawing.Point(8, 32);
            this.Fire10Byte_Select_RadioButton.Name = "Fire10Byte_Select_RadioButton";
            this.Fire10Byte_Select_RadioButton.Size = new System.Drawing.Size(60, 16);
            this.Fire10Byte_Select_RadioButton.TabIndex = 1;
            this.Fire10Byte_Select_RadioButton.TabStop = true;
            this.Fire10Byte_Select_RadioButton.Text = "10Byte";
            this.Fire10Byte_Select_RadioButton.UseVisualStyleBackColor = true;
            this.Fire10Byte_Select_RadioButton.CheckedChanged += new System.EventHandler(this.Fire10Byte_Select_RadioButton_CheckedChanged);
            // 
            // Tx_Str_listBox
            // 
            this.Tx_Str_listBox.FormattingEnabled = true;
            this.Tx_Str_listBox.ItemHeight = 12;
            this.Tx_Str_listBox.Location = new System.Drawing.Point(749, 38);
            this.Tx_Str_listBox.Name = "Tx_Str_listBox";
            this.Tx_Str_listBox.Size = new System.Drawing.Size(312, 448);
            this.Tx_Str_listBox.TabIndex = 17;
            // 
            // Tx_Single_textBox
            // 
            this.Tx_Single_textBox.Location = new System.Drawing.Point(866, 549);
            this.Tx_Single_textBox.Name = "Tx_Single_textBox";
            this.Tx_Single_textBox.Size = new System.Drawing.Size(297, 21);
            this.Tx_Single_textBox.TabIndex = 18;
            // 
            // Tx_One_button
            // 
            this.Tx_One_button.Location = new System.Drawing.Point(1154, 492);
            this.Tx_One_button.Name = "Tx_One_button";
            this.Tx_One_button.Size = new System.Drawing.Size(71, 31);
            this.Tx_One_button.TabIndex = 21;
            this.Tx_One_button.Text = "한번 전송";
            this.Tx_One_button.UseVisualStyleBackColor = true;
            this.Tx_One_button.Click += new System.EventHandler(this.Tx_One_button_Click);
            // 
            // Delay_textBox
            // 
            this.Delay_textBox.Location = new System.Drawing.Point(1081, 497);
            this.Delay_textBox.Name = "Delay_textBox";
            this.Delay_textBox.Size = new System.Drawing.Size(67, 21);
            this.Delay_textBox.TabIndex = 24;
            this.Delay_textBox.Text = "500";
            // 
            // Tx_Multi_button
            // 
            this.Tx_Multi_button.Location = new System.Drawing.Point(1230, 492);
            this.Tx_Multi_button.Name = "Tx_Multi_button";
            this.Tx_Multi_button.Size = new System.Drawing.Size(71, 31);
            this.Tx_Multi_button.TabIndex = 25;
            this.Tx_Multi_button.Text = "연속 전송";
            this.Tx_Multi_button.UseVisualStyleBackColor = true;
            this.Tx_Multi_button.Click += new System.EventHandler(this.Tx_Multi_button_Click);
            // 
            // Tx_Single_Button
            // 
            this.Tx_Single_Button.Location = new System.Drawing.Point(1169, 543);
            this.Tx_Single_Button.Name = "Tx_Single_Button";
            this.Tx_Single_Button.Size = new System.Drawing.Size(84, 30);
            this.Tx_Single_Button.TabIndex = 26;
            this.Tx_Single_Button.Text = "전송";
            this.Tx_Single_Button.UseVisualStyleBackColor = true;
            this.Tx_Single_Button.Click += new System.EventHandler(this.Tx_Single_Button_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1010, 502);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 12);
            this.label10.TabIndex = 41;
            this.label10.Text = "Delay(ms)";
            // 
            // Tx_Str_Insert_Button
            // 
            this.Tx_Str_Insert_Button.Location = new System.Drawing.Point(749, 539);
            this.Tx_Str_Insert_Button.Name = "Tx_Str_Insert_Button";
            this.Tx_Str_Insert_Button.Size = new System.Drawing.Size(49, 31);
            this.Tx_Str_Insert_Button.TabIndex = 42;
            this.Tx_Str_Insert_Button.Text = "↑";
            this.Tx_Str_Insert_Button.UseVisualStyleBackColor = true;
            this.Tx_Str_Insert_Button.Click += new System.EventHandler(this.Tx_Str_Insert_Button_Click);
            // 
            // Tx_Str_Delete_Button
            // 
            this.Tx_Str_Delete_Button.Location = new System.Drawing.Point(804, 539);
            this.Tx_Str_Delete_Button.Name = "Tx_Str_Delete_Button";
            this.Tx_Str_Delete_Button.Size = new System.Drawing.Size(52, 31);
            this.Tx_Str_Delete_Button.TabIndex = 43;
            this.Tx_Str_Delete_Button.Text = "↓";
            this.Tx_Str_Delete_Button.UseVisualStyleBackColor = true;
            this.Tx_Str_Delete_Button.Click += new System.EventHandler(this.Tx_Str_Delete_Button_Click);
            // 
            // Monitoring_listBox
            // 
            this.Monitoring_listBox.FormattingEnabled = true;
            this.Monitoring_listBox.ItemHeight = 12;
            this.Monitoring_listBox.Location = new System.Drawing.Point(1067, 38);
            this.Monitoring_listBox.Name = "Monitoring_listBox";
            this.Monitoring_listBox.Size = new System.Drawing.Size(446, 448);
            this.Monitoring_listBox.TabIndex = 44;
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // Monitoring_listBox_Clr_Button
            // 
            this.Monitoring_listBox_Clr_Button.Location = new System.Drawing.Point(1461, 491);
            this.Monitoring_listBox_Clr_Button.Name = "Monitoring_listBox_Clr_Button";
            this.Monitoring_listBox_Clr_Button.Size = new System.Drawing.Size(52, 31);
            this.Monitoring_listBox_Clr_Button.TabIndex = 47;
            this.Monitoring_listBox_Clr_Button.Text = "Clear";
            this.Monitoring_listBox_Clr_Button.UseVisualStyleBackColor = true;
            this.Monitoring_listBox_Clr_Button.Click += new System.EventHandler(this.Monitoring_listBox_Clr_Button_Click);
            // 
            // Serial_Time_label
            // 
            this.Serial_Time_label.AutoSize = true;
            this.Serial_Time_label.Location = new System.Drawing.Point(1067, 24);
            this.Serial_Time_label.Name = "Serial_Time_label";
            this.Serial_Time_label.Size = new System.Drawing.Size(34, 12);
            this.Serial_Time_label.TabIndex = 48;
            this.Serial_Time_label.Text = "Time";
            // 
            // Data_Str_label
            // 
            this.Data_Str_label.AutoSize = true;
            this.Data_Str_label.Location = new System.Drawing.Point(1225, 24);
            this.Data_Str_label.Name = "Data_Str_label";
            this.Data_Str_label.Size = new System.Drawing.Size(66, 12);
            this.Data_Str_label.TabIndex = 49;
            this.Data_Str_label.Text = "Data Bytes";
            // 
            // Length_label
            // 
            this.Length_label.AutoSize = true;
            this.Length_label.Location = new System.Drawing.Point(1357, 23);
            this.Length_label.Name = "Length_label";
            this.Length_label.Size = new System.Drawing.Size(43, 12);
            this.Length_label.TabIndex = 50;
            this.Length_label.Text = "Length";
            // 
            // TRx_label
            // 
            this.TRx_label.AutoSize = true;
            this.TRx_label.Location = new System.Drawing.Point(1435, 24);
            this.TRx_label.Name = "TRx_label";
            this.TRx_label.Size = new System.Drawing.Size(78, 12);
            this.TRx_label.TabIndex = 51;
            this.TRx_label.Text = "Tx/Rx Count";
            // 
            // Multi_Stop_button
            // 
            this.Multi_Stop_button.Location = new System.Drawing.Point(1307, 492);
            this.Multi_Stop_button.Name = "Multi_Stop_button";
            this.Multi_Stop_button.Size = new System.Drawing.Size(71, 31);
            this.Multi_Stop_button.TabIndex = 52;
            this.Multi_Stop_button.Text = "연속 정지";
            this.Multi_Stop_button.UseVisualStyleBackColor = true;
            this.Multi_Stop_button.Click += new System.EventHandler(this.Multi_Stop_button_Click);
            // 
            // Hex_con_Monitoring_listBox_checkBox2
            // 
            this.Hex_con_Monitoring_listBox_checkBox2.AutoSize = true;
            this.Hex_con_Monitoring_listBox_checkBox2.Location = new System.Drawing.Point(1067, 5);
            this.Hex_con_Monitoring_listBox_checkBox2.Name = "Hex_con_Monitoring_listBox_checkBox2";
            this.Hex_con_Monitoring_listBox_checkBox2.Size = new System.Drawing.Size(74, 16);
            this.Hex_con_Monitoring_listBox_checkBox2.TabIndex = 54;
            this.Hex_con_Monitoring_listBox_checkBox2.Text = "Hex 변환";
            this.Hex_con_Monitoring_listBox_checkBox2.UseVisualStyleBackColor = true;
            // 
            // Fire_Data_Received_checkBox
            // 
            this.Fire_Data_Received_checkBox.AutoSize = true;
            this.Fire_Data_Received_checkBox.Location = new System.Drawing.Point(749, 5);
            this.Fire_Data_Received_checkBox.Name = "Fire_Data_Received_checkBox";
            this.Fire_Data_Received_checkBox.Size = new System.Drawing.Size(74, 16);
            this.Fire_Data_Received_checkBox.TabIndex = 55;
            this.Fire_Data_Received_checkBox.Text = "Hex 변환";
            this.Fire_Data_Received_checkBox.UseVisualStyleBackColor = true;
            // 
            // TxTSave_Button
            // 
            this.TxTSave_Button.Location = new System.Drawing.Point(1384, 492);
            this.TxTSave_Button.Name = "TxTSave_Button";
            this.TxTSave_Button.Size = new System.Drawing.Size(71, 31);
            this.TxTSave_Button.TabIndex = 56;
            this.TxTSave_Button.Text = "Text 저장";
            this.TxTSave_Button.UseVisualStyleBackColor = true;
            this.TxTSave_Button.Click += new System.EventHandler(this.TxTSave_Button_Click);
            // 
            // TxTLoad_Cmd_Button
            // 
            this.TxTLoad_Cmd_Button.Location = new System.Drawing.Point(826, 491);
            this.TxTLoad_Cmd_Button.Name = "TxTLoad_Cmd_Button";
            this.TxTLoad_Cmd_Button.Size = new System.Drawing.Size(96, 31);
            this.TxTLoad_Cmd_Button.TabIndex = 57;
            this.TxTLoad_Cmd_Button.Text = "Text 불러오기";
            this.TxTLoad_Cmd_Button.UseVisualStyleBackColor = true;
            this.TxTLoad_Cmd_Button.Click += new System.EventHandler(this.TxTLoad_Cmd_Button_Click);
            // 
            // TxTSave_Cmd_Button
            // 
            this.TxTSave_Cmd_Button.Location = new System.Drawing.Point(749, 491);
            this.TxTSave_Cmd_Button.Name = "TxTSave_Cmd_Button";
            this.TxTSave_Cmd_Button.Size = new System.Drawing.Size(71, 31);
            this.TxTSave_Cmd_Button.TabIndex = 58;
            this.TxTSave_Cmd_Button.Text = "Text 저장";
            this.TxTSave_Cmd_Button.UseVisualStyleBackColor = true;
            this.TxTSave_Cmd_Button.Click += new System.EventHandler(this.TxTSave_Cmd_Button_Click);
            // 
            // Tx_Str_listBox_Clr_Button
            // 
            this.Tx_Str_listBox_Clr_Button.Location = new System.Drawing.Point(928, 492);
            this.Tx_Str_listBox_Clr_Button.Name = "Tx_Str_listBox_Clr_Button";
            this.Tx_Str_listBox_Clr_Button.Size = new System.Drawing.Size(52, 31);
            this.Tx_Str_listBox_Clr_Button.TabIndex = 59;
            this.Tx_Str_listBox_Clr_Button.Text = "Clear";
            this.Tx_Str_listBox_Clr_Button.UseVisualStyleBackColor = true;
            this.Tx_Str_listBox_Clr_Button.Click += new System.EventHandler(this.Tx_Str_listBox_Clr_Button_Click);
            // 
            // NRG16_Clr_Button
            // 
            this.NRG16_Clr_Button.Location = new System.Drawing.Point(261, 24);
            this.NRG16_Clr_Button.Name = "NRG16_Clr_Button";
            this.NRG16_Clr_Button.Size = new System.Drawing.Size(44, 41);
            this.NRG16_Clr_Button.TabIndex = 60;
            this.NRG16_Clr_Button.Text = "Clear";
            this.NRG16_Clr_Button.UseVisualStyleBackColor = true;
            this.NRG16_Clr_Button.Click += new System.EventHandler(this.NRG16_Clr_Button_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(261, 24);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(44, 41);
            this.button5.TabIndex = 61;
            this.button5.Text = "Clear";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(261, 24);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(44, 41);
            this.button6.TabIndex = 61;
            this.button6.Text = "Clear";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(261, 24);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(44, 41);
            this.button7.TabIndex = 63;
            this.button7.Text = "Clear";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // NTEC_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1525, 683);
            this.Controls.Add(this.Tx_Str_listBox_Clr_Button);
            this.Controls.Add(this.TxTSave_Cmd_Button);
            this.Controls.Add(this.TxTLoad_Cmd_Button);
            this.Controls.Add(this.TxTSave_Button);
            this.Controls.Add(this.NTEC_TabControl);
            this.Controls.Add(this.Fire_Data_Received_checkBox);
            this.Controls.Add(this.Hex_con_Monitoring_listBox_checkBox2);
            this.Controls.Add(this.Multi_Stop_button);
            this.Controls.Add(this.TRx_label);
            this.Controls.Add(this.Length_label);
            this.Controls.Add(this.Data_Str_label);
            this.Controls.Add(this.Serial_Time_label);
            this.Controls.Add(this.Tx_Multi_button);
            this.Controls.Add(this.Monitoring_listBox_Clr_Button);
            this.Controls.Add(this.Tx_One_button);
            this.Controls.Add(this.Monitoring_listBox);
            this.Controls.Add(this.Tx_Str_Delete_Button);
            this.Controls.Add(this.Tx_Str_Insert_Button);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Tx_Single_Button);
            this.Controls.Add(this.Delay_textBox);
            this.Controls.Add(this.Tx_Single_textBox);
            this.Controls.Add(this.Tx_Str_listBox);
            this.Controls.Add(this.button_DbLoad);
            this.Controls.Add(this.button_DbSave);
            this.Controls.Add(this.button_Reset);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox_Port_FlowControl);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBox_Port_StopBits);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox_Port_Parity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox_Port_DataBits);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox_Port_BaudRate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_Port_Number);
            this.Controls.Add(this.button_Connect);
            this.Name = "NTEC_Form";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "NTEC_Firmware_Test_App";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.NTEC_TabControl.ResumeLayout(false);
            this.NMC44_TabPage.ResumeLayout(false);
            this.NMC44_TabPage.PerformLayout();
            this.NMC44_FIRE10_Groupbox.ResumeLayout(false);
            this.NMC44_FIRE10_Groupbox.PerformLayout();
            this.NMC44_FIRE12_Groupbox.ResumeLayout(false);
            this.NMC44_FIRE12_Groupbox.PerformLayout();
            this.NMC44_FIRP_Groupbox.ResumeLayout(false);
            this.NMC44_FIRP_Groupbox.PerformLayout();
            this.NMC44_EMIC_Groupbox.ResumeLayout(false);
            this.NMC44_EMIC_Groupbox.PerformLayout();
            this.NMC44_FIRL_Groupbox.ResumeLayout(false);
            this.NMC44_FIRL_Groupbox.PerformLayout();
            this.NMC44_MOT_Groupbox.ResumeLayout(false);
            this.NMC44_MOT_Groupbox.PerformLayout();
            this.NMC44_GPO_Groupbox.ResumeLayout(false);
            this.NMC44_GPO_Groupbox.PerformLayout();
            this.NMC44_BAS_Groupbox.ResumeLayout(false);
            this.NMC44_BAS_Groupbox.PerformLayout();
            this.NMC44_TRB_Groupbox.ResumeLayout(false);
            this.NMC44_TRB_Groupbox.PerformLayout();
            this.NMC44_VOL_Groupbox.ResumeLayout(false);
            this.NMC44_VOL_Groupbox.PerformLayout();
            this.NMC44_MUX_Groupbox.ResumeLayout(false);
            this.NMC44_MUX_Groupbox.PerformLayout();
            this.NRG16_TabPage.ResumeLayout(false);
            this.NRG16_TabPage.PerformLayout();
            this.NRG16_EM_Groupbox.ResumeLayout(false);
            this.NRG16_EM_Groupbox.PerformLayout();
            this.NRG16_Normal_Groupbox.ResumeLayout(false);
            this.NRG16_Normal_Groupbox.PerformLayout();
            this.NRT16_TabPage.ResumeLayout(false);
            this.NRT16_TabPage.PerformLayout();
            this.NRT16_EM_Groupbox.ResumeLayout(false);
            this.NRT16_EM_Groupbox.PerformLayout();
            this.NRT16_Normal_Groupbox.ResumeLayout(false);
            this.NRT16_Normal_Groupbox.PerformLayout();
            this.NRT40_TabPage.ResumeLayout(false);
            this.NRT40_TabPage.PerformLayout();
            this.NRT40_Normal_Groupbox.ResumeLayout(false);
            this.NRT40_Normal_Groupbox.PerformLayout();
            this.MPR_TabPage.ResumeLayout(false);
            this.MPR_TabPage.PerformLayout();
            this.MPR_Auto_Manual_Groupbox.ResumeLayout(false);
            this.MPR_Auto_Manual_Groupbox.PerformLayout();
            this.MPR_POWER_ON_OFF_Groupbox.ResumeLayout(false);
            this.MPR_POWER_ON_OFF_Groupbox.PerformLayout();
            this.MPR_CD_Track_Groupbox.ResumeLayout(false);
            this.MPR_CD_Track_Groupbox.PerformLayout();
            this.MPR_CD_Volume_Groupbox.ResumeLayout(false);
            this.MPR_CD_Volume_Groupbox.PerformLayout();
            this.MPR_CD_Control_Groupbox.ResumeLayout(false);
            this.MPR_CD_Control_Groupbox.PerformLayout();
            this.NCS01_TabPage.ResumeLayout(false);
            this.NCS01_TabPage.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.NEI42_TabPage.ResumeLayout(false);
            this.NEI42_TabPage.PerformLayout();
            this.NEI42_GPIN_Total_GroupBox.ResumeLayout(false);
            this.NEI42_GPIN3_GroupBox.ResumeLayout(false);
            this.NEI42_GPIN3_GroupBox.PerformLayout();
            this.NEI42_GPIN2_GroupBox.ResumeLayout(false);
            this.NEI42_GPIN2_GroupBox.PerformLayout();
            this.NEI42_GPIN1_GroupBox.ResumeLayout(false);
            this.NEI42_GPIN1_GroupBox.PerformLayout();
            this.Fire_TabPage.ResumeLayout(false);
            this.Fire_TabPage.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.Fire12Byte_Total_GroupBox.ResumeLayout(false);
            this.Fire12Byte_Total_GroupBox.PerformLayout();
            this.Fire10Byte_Total_GroupBox.ResumeLayout(false);
            this.Fire10Byte_Total_GroupBox.PerformLayout();
            this.Fire_Select_GroupBox.ResumeLayout(false);
            this.Fire_Select_GroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Connect;
        private System.Windows.Forms.ComboBox comboBox_Port_Number;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_Port_BaudRate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_Port_DataBits;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox_Port_Parity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox_Port_FlowControl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox_Port_StopBits;
        private System.Windows.Forms.Button button_Reset;
        private System.Windows.Forms.Button button_DbSave;
        private System.Windows.Forms.Button button_DbLoad;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.TabControl NTEC_TabControl;
        private System.Windows.Forms.ListBox Tx_Str_listBox;
        private System.Windows.Forms.TextBox Tx_Single_textBox;
        private System.Windows.Forms.Button Tx_One_button;
        private System.Windows.Forms.TextBox Delay_textBox;
        private System.Windows.Forms.Button Tx_Multi_button;
        private System.Windows.Forms.Button Tx_Single_Button;
        private System.Windows.Forms.TabPage NRG16_TabPage;
        private System.Windows.Forms.GroupBox NRG16_EM_Groupbox;
        private System.Windows.Forms.CheckBox NRG_Ch31_CheckBox;
        private System.Windows.Forms.CheckBox NRG_Ch32_CheckBox;
        private System.Windows.Forms.CheckBox NRG_Ch29_CheckBox;
        private System.Windows.Forms.CheckBox NRG_Ch30_CheckBox;
        private System.Windows.Forms.CheckBox NRG_Ch25_CheckBox;
        private System.Windows.Forms.CheckBox NRG_Ch26_CheckBox;
        private System.Windows.Forms.CheckBox NRG_Ch27_CheckBox;
        private System.Windows.Forms.CheckBox NRG_Ch28_CheckBox;
        private System.Windows.Forms.CheckBox NRG_Ch23_CheckBox;
        private System.Windows.Forms.CheckBox NRG_Ch24_CheckBox;
        private System.Windows.Forms.CheckBox NRG_Ch21_CheckBox;
        private System.Windows.Forms.CheckBox NRG_Ch22_CheckBox;
        private System.Windows.Forms.CheckBox NRG_Ch17_CheckBox;
        private System.Windows.Forms.CheckBox NRG_Ch18_CheckBox;
        private System.Windows.Forms.CheckBox NRG_Ch19_CheckBox;
        private System.Windows.Forms.CheckBox NRG_Ch20_CheckBox;
        private System.Windows.Forms.GroupBox NRG16_Normal_Groupbox;
        private System.Windows.Forms.CheckBox NRG_Ch15_CheckBox;
        private System.Windows.Forms.CheckBox NRG_Ch16_CheckBox;
        private System.Windows.Forms.CheckBox NRG_Ch13_CheckBox;
        private System.Windows.Forms.CheckBox NRG_Ch14_CheckBox;
        private System.Windows.Forms.CheckBox NRG_Ch9_CheckBox;
        private System.Windows.Forms.CheckBox NRG_Ch10_CheckBox;
        private System.Windows.Forms.CheckBox NRG_Ch11_CheckBox;
        private System.Windows.Forms.CheckBox NRG_Ch12_CheckBox;
        private System.Windows.Forms.CheckBox NRG_Ch7_CheckBox;
        private System.Windows.Forms.CheckBox NRG_Ch8_CheckBox;
        private System.Windows.Forms.CheckBox NRG_Ch5_CheckBox;
        private System.Windows.Forms.CheckBox NRG_Ch6_CheckBox;
        private System.Windows.Forms.CheckBox NRG_Ch1_CheckBox;
        private System.Windows.Forms.CheckBox NRG_Ch2_CheckBox;
        private System.Windows.Forms.CheckBox NRG_Ch3_CheckBox;
        private System.Windows.Forms.CheckBox NRG_Ch4_CheckBox;
        private System.Windows.Forms.TabPage NRT16_TabPage;
        private System.Windows.Forms.Label NRT16_ID_Label;
        private System.Windows.Forms.GroupBox NRT16_EM_Groupbox;
        private System.Windows.Forms.CheckBox NDT_Ch31_CheckBox;
        private System.Windows.Forms.CheckBox NDT_Ch32_CheckBox;
        private System.Windows.Forms.CheckBox NDT_Ch29_CheckBox;
        private System.Windows.Forms.CheckBox NDT_Ch30_CheckBox;
        private System.Windows.Forms.CheckBox NDT_Ch25_CheckBox;
        private System.Windows.Forms.CheckBox NDT_Ch26_CheckBox;
        private System.Windows.Forms.CheckBox NDT_Ch27_CheckBox;
        private System.Windows.Forms.CheckBox NDT_Ch28_CheckBox;
        private System.Windows.Forms.CheckBox NDT_Ch23_CheckBox;
        private System.Windows.Forms.CheckBox NDT_Ch24_CheckBox;
        private System.Windows.Forms.CheckBox NDT_Ch21_CheckBox;
        private System.Windows.Forms.CheckBox NDT_Ch22_CheckBox;
        private System.Windows.Forms.CheckBox NDT_Ch17_CheckBox;
        private System.Windows.Forms.CheckBox NDT_Ch18_CheckBox;
        private System.Windows.Forms.CheckBox NDT_Ch19_CheckBox;
        private System.Windows.Forms.CheckBox NDT_Ch20_CheckBox;
        private System.Windows.Forms.GroupBox NRT16_Normal_Groupbox;
        private System.Windows.Forms.CheckBox NDT_Ch15_CheckBox;
        private System.Windows.Forms.CheckBox NDT_Ch16_CheckBox;
        private System.Windows.Forms.CheckBox NDT_Ch13_CheckBox;
        private System.Windows.Forms.CheckBox NDT_Ch14_CheckBox;
        private System.Windows.Forms.CheckBox NDT_Ch9_CheckBox;
        private System.Windows.Forms.CheckBox NDT_Ch10_CheckBox;
        private System.Windows.Forms.CheckBox NDT_Ch11_CheckBox;
        private System.Windows.Forms.CheckBox NDT_Ch12_CheckBox;
        private System.Windows.Forms.CheckBox NDT_Ch7_CheckBox;
        private System.Windows.Forms.CheckBox NDT_Ch8_CheckBox;
        private System.Windows.Forms.CheckBox NDT_Ch5_CheckBox;
        private System.Windows.Forms.CheckBox NDT_Ch6_CheckBox;
        private System.Windows.Forms.CheckBox NDT_Ch1_CheckBox;
        private System.Windows.Forms.CheckBox NDT_Ch2_CheckBox;
        private System.Windows.Forms.CheckBox NDT_Ch3_CheckBox;
        private System.Windows.Forms.CheckBox NDT_Ch4_CheckBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button Tx_Str_Insert_Button;
        private System.Windows.Forms.Button Tx_Str_Delete_Button;
        private System.Windows.Forms.Label NRG16_ID_Label;
        private System.Windows.Forms.TabPage NRT40_TabPage;
        private System.Windows.Forms.Label NRT40_ID_Label;
        private System.Windows.Forms.GroupBox NRT40_Normal_Groupbox;
        private System.Windows.Forms.CheckBox NRT_Ch15_CheckBox;
        private System.Windows.Forms.CheckBox NRT_Ch16_CheckBox;
        private System.Windows.Forms.CheckBox NRT_Ch13_CheckBox;
        private System.Windows.Forms.CheckBox NRT_Ch14_CheckBox;
        private System.Windows.Forms.CheckBox NRT_Ch9_CheckBox;
        private System.Windows.Forms.CheckBox NRT_Ch10_CheckBox;
        private System.Windows.Forms.CheckBox NRT_Ch11_CheckBox;
        private System.Windows.Forms.CheckBox NRT_Ch12_CheckBox;
        private System.Windows.Forms.CheckBox NRT_Ch7_CheckBox;
        private System.Windows.Forms.CheckBox NRT_Ch8_CheckBox;
        private System.Windows.Forms.CheckBox NRT_Ch5_CheckBox;
        private System.Windows.Forms.CheckBox NRT_Ch6_CheckBox;
        private System.Windows.Forms.CheckBox NRT_Ch1_CheckBox;
        private System.Windows.Forms.CheckBox NRT_Ch2_CheckBox;
        private System.Windows.Forms.CheckBox NRT_Ch3_CheckBox;
        private System.Windows.Forms.CheckBox NRT_Ch4_CheckBox;
        private System.Windows.Forms.CheckBox NRT_Ch39_CheckBox;
        private System.Windows.Forms.CheckBox NRT_Ch40_CheckBox;
        private System.Windows.Forms.CheckBox NRT_Ch37_CheckBox;
        private System.Windows.Forms.CheckBox NRT_Ch38_CheckBox;
        private System.Windows.Forms.CheckBox NRT_Ch33_CheckBox;
        private System.Windows.Forms.CheckBox NRT_Ch34_CheckBox;
        private System.Windows.Forms.CheckBox NRT_Ch35_CheckBox;
        private System.Windows.Forms.CheckBox NRT_Ch36_CheckBox;
        private System.Windows.Forms.CheckBox NRT_Ch31_CheckBox;
        private System.Windows.Forms.CheckBox NRT_Ch32_CheckBox;
        private System.Windows.Forms.CheckBox NRT_Ch29_CheckBox;
        private System.Windows.Forms.CheckBox NRT_Ch30_CheckBox;
        private System.Windows.Forms.CheckBox NRT_Ch25_CheckBox;
        private System.Windows.Forms.CheckBox NRT_Ch26_CheckBox;
        private System.Windows.Forms.CheckBox NRT_Ch27_CheckBox;
        private System.Windows.Forms.CheckBox NRT_Ch28_CheckBox;
        private System.Windows.Forms.CheckBox NRT_Ch23_CheckBox;
        private System.Windows.Forms.CheckBox NRT_Ch24_CheckBox;
        private System.Windows.Forms.CheckBox NRT_Ch21_CheckBox;
        private System.Windows.Forms.CheckBox NRT_Ch22_CheckBox;
        private System.Windows.Forms.CheckBox NRT_Ch17_CheckBox;
        private System.Windows.Forms.CheckBox NRT_Ch18_CheckBox;
        private System.Windows.Forms.CheckBox NRT_Ch19_CheckBox;
        private System.Windows.Forms.CheckBox NRT_Ch20_CheckBox;
        private System.Windows.Forms.TabPage MPR_TabPage;
        private System.Windows.Forms.TabPage NCS01_TabPage;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.CheckBox checkBox145;
        private System.Windows.Forms.CheckBox checkBox146;
        private System.Windows.Forms.CheckBox checkBox147;
        private System.Windows.Forms.CheckBox checkBox148;
        private System.Windows.Forms.CheckBox checkBox149;
        private System.Windows.Forms.CheckBox checkBox150;
        private System.Windows.Forms.CheckBox checkBox151;
        private System.Windows.Forms.CheckBox checkBox152;
        private System.Windows.Forms.CheckBox checkBox153;
        private System.Windows.Forms.CheckBox checkBox154;
        private System.Windows.Forms.CheckBox checkBox155;
        private System.Windows.Forms.CheckBox checkBox156;
        private System.Windows.Forms.CheckBox checkBox157;
        private System.Windows.Forms.CheckBox checkBox158;
        private System.Windows.Forms.CheckBox checkBox159;
        private System.Windows.Forms.CheckBox checkBox160;
        private System.Windows.Forms.CheckBox checkBox161;
        private System.Windows.Forms.CheckBox checkBox162;
        private System.Windows.Forms.CheckBox checkBox163;
        private System.Windows.Forms.CheckBox checkBox164;
        private System.Windows.Forms.CheckBox checkBox165;
        private System.Windows.Forms.CheckBox checkBox166;
        private System.Windows.Forms.CheckBox checkBox167;
        private System.Windows.Forms.CheckBox checkBox168;
        private System.Windows.Forms.CheckBox checkBox169;
        private System.Windows.Forms.CheckBox checkBox170;
        private System.Windows.Forms.CheckBox checkBox171;
        private System.Windows.Forms.CheckBox checkBox172;
        private System.Windows.Forms.CheckBox checkBox173;
        private System.Windows.Forms.CheckBox checkBox174;
        private System.Windows.Forms.CheckBox checkBox175;
        private System.Windows.Forms.CheckBox checkBox176;
        private System.Windows.Forms.CheckBox checkBox177;
        private System.Windows.Forms.CheckBox checkBox178;
        private System.Windows.Forms.CheckBox checkBox179;
        private System.Windows.Forms.CheckBox checkBox180;
        private System.Windows.Forms.CheckBox checkBox181;
        private System.Windows.Forms.CheckBox checkBox182;
        private System.Windows.Forms.CheckBox checkBox183;
        private System.Windows.Forms.CheckBox checkBox184;
        private System.Windows.Forms.TabPage NEI42_TabPage;
        private System.Windows.Forms.ListBox Monitoring_listBox;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button Monitoring_listBox_Clr_Button;
        private System.Windows.Forms.Label Serial_Time_label;
        private System.Windows.Forms.Label Data_Str_label;
        private System.Windows.Forms.Label Length_label;
        private System.Windows.Forms.Label TRx_label;
        private System.Windows.Forms.ComboBox NRG_Cmd_comboBox;
        private System.Windows.Forms.ComboBox NDT_Cmd_comboBox;
        private System.Windows.Forms.Button NDT_Insert_Button;
        private System.Windows.Forms.ComboBox NRT_Cmd_comboBox;
        private System.Windows.Forms.Button NRT_Insert_Button;
        private System.Windows.Forms.ComboBox NRG16_ID_1_comboBox;
        private System.Windows.Forms.ComboBox NRG16_ID_10_comboBox;
        private System.Windows.Forms.ComboBox NRT16_ID_1_comboBox;
        private System.Windows.Forms.ComboBox NRT16_ID_10_comboBox;
        private System.Windows.Forms.ComboBox NRT40_ID_1_comboBox;
        private System.Windows.Forms.ComboBox NRT40_ID_10_comboBox;
        private System.Windows.Forms.Label NRG16_CMD_Label;
        private System.Windows.Forms.Label NRT16_CMD_Label;
        private System.Windows.Forms.Label NRT40_CMD_Label;
        private System.Windows.Forms.Button NCS_Insert_Button;
        private System.Windows.Forms.Label NCS01_CMD_Label;
        private System.Windows.Forms.ComboBox NCS01_ID_1_comboBox;
        private System.Windows.Forms.ComboBox NCS01_ID_10_comboBox;
        private System.Windows.Forms.Label NCS01_ID_Label;
        private System.Windows.Forms.ComboBox NCS_Cmd_comboBox;
        private System.Windows.Forms.GroupBox NEI42_GPIN_Total_GroupBox;
        private System.Windows.Forms.GroupBox NEI42_GPIN3_GroupBox;
        private System.Windows.Forms.CheckBox NEI_Ch41_CheckBox;
        private System.Windows.Forms.CheckBox NEI_Ch29_CheckBox;
        private System.Windows.Forms.CheckBox NEI_Ch42_CheckBox;
        private System.Windows.Forms.CheckBox NEI_Ch33_CheckBox;
        private System.Windows.Forms.CheckBox NEI_Ch37_CheckBox;
        private System.Windows.Forms.CheckBox NEI_Ch34_CheckBox;
        private System.Windows.Forms.CheckBox NEI_Ch38_CheckBox;
        private System.Windows.Forms.CheckBox NEI_Ch36_CheckBox;
        private System.Windows.Forms.CheckBox NEI_Ch30_CheckBox;
        private System.Windows.Forms.CheckBox NEI_Ch39_CheckBox;
        private System.Windows.Forms.CheckBox NEI_Ch35_CheckBox;
        private System.Windows.Forms.CheckBox NEI_Ch32_CheckBox;
        private System.Windows.Forms.CheckBox NEI_Ch31_CheckBox;
        private System.Windows.Forms.CheckBox NEI_Ch40_CheckBox;
        private System.Windows.Forms.GroupBox NEI42_GPIN2_GroupBox;
        private System.Windows.Forms.CheckBox NEI_Ch27_CheckBox;
        private System.Windows.Forms.CheckBox NEI_Ch15_CheckBox;
        private System.Windows.Forms.CheckBox NEI_Ch28_CheckBox;
        private System.Windows.Forms.CheckBox NEI_Ch19_CheckBox;
        private System.Windows.Forms.CheckBox NEI_Ch23_CheckBox;
        private System.Windows.Forms.CheckBox NEI_Ch20_CheckBox;
        private System.Windows.Forms.CheckBox NEI_Ch24_CheckBox;
        private System.Windows.Forms.CheckBox NEI_Ch22_CheckBox;
        private System.Windows.Forms.CheckBox NEI_Ch16_CheckBox;
        private System.Windows.Forms.CheckBox NEI_Ch25_CheckBox;
        private System.Windows.Forms.CheckBox NEI_Ch21_CheckBox;
        private System.Windows.Forms.CheckBox NEI_Ch18_CheckBox;
        private System.Windows.Forms.CheckBox NEI_Ch17_CheckBox;
        private System.Windows.Forms.CheckBox NEI_Ch26_CheckBox;
        private System.Windows.Forms.GroupBox NEI42_GPIN1_GroupBox;
        private System.Windows.Forms.CheckBox NEI_Ch13_CheckBox;
        private System.Windows.Forms.CheckBox NEI_Ch1_CheckBox;
        private System.Windows.Forms.CheckBox NEI_Ch14_CheckBox;
        private System.Windows.Forms.CheckBox NEI_Ch5_CheckBox;
        private System.Windows.Forms.CheckBox NEI_Ch9_CheckBox;
        private System.Windows.Forms.CheckBox NEI_Ch6_CheckBox;
        private System.Windows.Forms.CheckBox NEI_Ch10_CheckBox;
        private System.Windows.Forms.CheckBox NEI_Ch8_CheckBox;
        private System.Windows.Forms.CheckBox NEI_Ch2_CheckBox;
        private System.Windows.Forms.CheckBox NEI_Ch11_CheckBox;
        private System.Windows.Forms.CheckBox NEI_Ch7_CheckBox;
        private System.Windows.Forms.CheckBox NEI_Ch4_CheckBox;
        private System.Windows.Forms.CheckBox NEI_Ch3_CheckBox;
        private System.Windows.Forms.CheckBox NEI_Ch12_CheckBox;
        private System.Windows.Forms.Button NEI_Insert_Button;
        private System.Windows.Forms.Button Multi_Stop_button;
        private System.Windows.Forms.TabPage Fire_TabPage;
        private System.Windows.Forms.GroupBox Fire12Byte_Total_GroupBox;
        private System.Windows.Forms.Button Fire12Byte_Reset_Button;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button Fire12Byte_Audio_Stop_Button;
        private System.Windows.Forms.Label FIRE12Byte_Floor_ID_Label;
        private System.Windows.Forms.Button Fire12Byte_Audio_Start_Button;
        private System.Windows.Forms.ComboBox FIRE12Byte_Dong_ID_10_ConboBox;
        private System.Windows.Forms.Button Fire12Byte_Stop_Button;
        private System.Windows.Forms.Label FIRE12Byte_Gaedan_ID_Label;
        private System.Windows.Forms.Button Fire12Byte_Start_Button;
        private System.Windows.Forms.ComboBox FIRE12Byte_Dong_ID_1_ConboBox;
        private System.Windows.Forms.Label FIRE12Byte_Dong_ID_Label;
        private System.Windows.Forms.ComboBox FIRE12Byte_Floor_ID_10_ConboBox;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ComboBox FIRE12Byte_Floor_ID_1_ConboBox;
        private System.Windows.Forms.ComboBox FIRE12Byte_Gaedan_ID_1_ConboBox;
        private System.Windows.Forms.ComboBox FIRE12Byte_Gaedan_ID_10_ConboBox;
        private System.Windows.Forms.GroupBox Fire10Byte_Total_GroupBox;
        private System.Windows.Forms.Button Fire10Byte_Reset_Button;
        private System.Windows.Forms.Button Fire10Byte_Audio_Stop_Button;
        private System.Windows.Forms.Button Fire10Byte_Audio_Start_Button;
        private System.Windows.Forms.Button Fire10Byte_Stop_Button;
        private System.Windows.Forms.Label FIRE10Byte_Seperate_ID_Label;
        private System.Windows.Forms.Button Fire10Byte_Start_Button;
        private System.Windows.Forms.Label FIRE10Byte_Floor_ID_Label;
        private System.Windows.Forms.Label FIRE10Byte_Gaedan_ID_Label;
        private System.Windows.Forms.Label FIRE10Byte_Dong_ID_Label;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox FIRE10Byte_Gaedan_ID_1_ConboBox;
        private System.Windows.Forms.ComboBox FIRE10Byte_Seperate_ID_ConboBox;
        private System.Windows.Forms.ComboBox FIRE10Byte_Floor_ID_1_ConboBox;
        private System.Windows.Forms.ComboBox FIRE10Byte_Floor_ID_10_ConboBox;
        private System.Windows.Forms.ComboBox FIRE10Byte_Dong_ID_1_ConboBox;
        private System.Windows.Forms.ComboBox FIRE10Byte_Dong_ID_10_ConboBox;
        private System.Windows.Forms.GroupBox Fire_Select_GroupBox;
        private System.Windows.Forms.RadioButton Fire12Byte_Select_RadioButton;
        private System.Windows.Forms.RadioButton Fire10Byte_Select_RadioButton;
        private System.Windows.Forms.Label NEI42_CMD_Label;
        private System.Windows.Forms.ComboBox NEI42_ID_1_comboBox;
        private System.Windows.Forms.Label NEI42_ID_Label;
        private System.Windows.Forms.ComboBox NEI42_ID_10_comboBox;
        private System.Windows.Forms.ComboBox NEI42_Cmd_comboBox;
        private System.Windows.Forms.Button Fire_Insert_Button;
        private System.Windows.Forms.Label FIRE10Byte_Operate_Label;
        private System.Windows.Forms.ComboBox FIRE10Byte_Operate_ConboBox;
        private System.Windows.Forms.Label FIRE12Byte_Operate_Label;
        private System.Windows.Forms.ComboBox FIRE12Byte_Operate_ConboBox;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.RadioButton Auto_RadioButton;
        private System.Windows.Forms.RadioButton Manual_RadioButton;
        private System.Windows.Forms.CheckBox Hex_con_Monitoring_listBox_checkBox2;
        private System.Windows.Forms.CheckBox Fire_Data_Received_checkBox;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TabPage NMC44_TabPage;
        private System.Windows.Forms.Label NMC44_CMD_Label;
        private System.Windows.Forms.ComboBox NMC44_ID_1_comboBox;
        private System.Windows.Forms.ComboBox NMC44_ID_10_comboBox;
        private System.Windows.Forms.ComboBox NMC_Cmd_comboBox;
        private System.Windows.Forms.Label NMC44_ID_Label;
        private System.Windows.Forms.Button NMC_Insert_Button;
        private System.Windows.Forms.GroupBox NMC44_MUX_Groupbox;
        private System.Windows.Forms.ComboBox MUX_Ext_Priority_comboBox;
        private System.Windows.Forms.Label MUX_Ext_Priority_label;
        private System.Windows.Forms.ComboBox MUX_Vol_Select_comboBox;
        private System.Windows.Forms.Label MUX_Vol_Select_label;
        private System.Windows.Forms.ComboBox MUX_Ouput_Ch_comboBox;
        private System.Windows.Forms.Label MUX_Ouput_Ch_label;
        private System.Windows.Forms.ComboBox MUX_Input_Ch_comboBox;
        private System.Windows.Forms.Label MUX_Input_Ch_label;
        private System.Windows.Forms.GroupBox NMC44_VOL_Groupbox;
        private System.Windows.Forms.ComboBox VOL_Vol_Select_comboBox;
        private System.Windows.Forms.Label VOL_Output_Ch_label;
        private System.Windows.Forms.Label VOL_Vol_Select_label;
        private System.Windows.Forms.ComboBox VOL_Output_Ch_comboBox;
        private System.Windows.Forms.GroupBox NMC44_BAS_Groupbox;
        private System.Windows.Forms.ComboBox BAS_Vol_Select_comboBox;
        private System.Windows.Forms.Label BAS_Output_Ch_label;
        private System.Windows.Forms.Label BAS_Vol_Select_label;
        private System.Windows.Forms.ComboBox BAS_Output_Ch_comboBox;
        private System.Windows.Forms.GroupBox NMC44_TRB_Groupbox;
        private System.Windows.Forms.ComboBox TRB_Vol_Select_comboBox;
        private System.Windows.Forms.Label TRB_Output_Ch_label;
        private System.Windows.Forms.Label TRB_Vol_Select_label;
        private System.Windows.Forms.ComboBox TRB_Output_Ch_comboBox;
        private System.Windows.Forms.GroupBox NMC44_GPO_Groupbox;
        private System.Windows.Forms.GroupBox NMC44_MOT_Groupbox;
        private System.Windows.Forms.ComboBox MOT_Output_Ch_comboBox;
        private System.Windows.Forms.Label MOT_Output_Ch_labellabel;
        private System.Windows.Forms.GroupBox NMC44_FIRL_Groupbox;
        private System.Windows.Forms.ComboBox FIRL_LED_On_Off_comboBox;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.GroupBox NMC44_EMIC_Groupbox;
        private System.Windows.Forms.ComboBox EMIC_LED_On_Off_comboBox;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.GroupBox NMC44_FIRE12_Groupbox;
        private System.Windows.Forms.ComboBox FIRE12_Dong_ID10_Sel_comboBox;
        private System.Windows.Forms.Label FIRE12_Dong_ID_Sel_label;
        private System.Windows.Forms.ComboBox FIRE12_Operate_Sel_comboBox;
        private System.Windows.Forms.Label FIRE12_Operate_Sel_label;
        private System.Windows.Forms.GroupBox NMC44_FIRP_Groupbox;
        private System.Windows.Forms.ComboBox FIRP_Protocol_Sel_comboBox;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.ComboBox FIRE12_Dong_ID1_Sel_comboBox;
        private System.Windows.Forms.ComboBox FIRE12_Floor_ID1_Sel_comboBox;
        private System.Windows.Forms.ComboBox FIRE12_Floor_ID10_Sel_comboBox;
        private System.Windows.Forms.ComboBox FIRE12_Gaedan_ID1_Sel_comboBox;
        private System.Windows.Forms.ComboBox FIRE12_Gaedan_ID10_Sel_comboBox;
        private System.Windows.Forms.Label FIRE12_Floor_ID_Sel_label;
        private System.Windows.Forms.Label FIRE12_Gaedan_ID_Sel_label;
        private System.Windows.Forms.GroupBox NMC44_FIRE10_Groupbox;
        private System.Windows.Forms.Label FIRE10_Floor_ID_Sel_label;
        private System.Windows.Forms.ComboBox FIRE10_Seperate_Sel_comboBox;
        private System.Windows.Forms.Label FIRE10_Seperate_Sel_label;
        private System.Windows.Forms.Label FIRE10_Gaedan_ID_Sel_label;
        private System.Windows.Forms.ComboBox FIRE10_Operate_Sel_comboBox;
        private System.Windows.Forms.Label FIRE10_Operate_Sel_label;
        private System.Windows.Forms.ComboBox FIRE10_Floor_ID1_Sel_comboBox;
        private System.Windows.Forms.ComboBox FIRE10_Dong_ID10_Sel_comboBox;
        private System.Windows.Forms.Label FIRE10_Dong_ID_Sel_label;
        private System.Windows.Forms.ComboBox FIRE10_Floor_ID10_Sel_comboBox;
        private System.Windows.Forms.ComboBox FIRE10_Dong_ID1_Sel_comboBox;
        private System.Windows.Forms.ComboBox FIRE10_Gaedan_ID10_Sel_comboBox;
        private System.Windows.Forms.ComboBox FIRE10_Gaedan_ID1_Sel_comboBox;
        private System.Windows.Forms.ComboBox GPO_Sel_Ch_comboBox;
        private System.Windows.Forms.Label GPO_Sel_Ch_label;
        private System.Windows.Forms.ComboBox GPO_ON_OFF_comboBox;
        private System.Windows.Forms.Label GPO_ON_OFF_label;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox MPR_Cmd_comboBox;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox MPR_CD_Control_Groupbox;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox MPR_CD_Volume_Groupbox;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton9;
        private System.Windows.Forms.RadioButton radioButton10;
        private System.Windows.Forms.GroupBox MPR_POWER_ON_OFF_Groupbox;
        private System.Windows.Forms.RadioButton radioButton16;
        private System.Windows.Forms.RadioButton radioButton17;
        private System.Windows.Forms.RadioButton radioButton18;
        private System.Windows.Forms.GroupBox MPR_CD_Track_Groupbox;
        private System.Windows.Forms.RadioButton radioButton11;
        private System.Windows.Forms.RadioButton radioButton12;
        private System.Windows.Forms.RadioButton radioButton13;
        private System.Windows.Forms.GroupBox MPR_Auto_Manual_Groupbox;
        private System.Windows.Forms.RadioButton MPR_Auto_RadioButton;
        private System.Windows.Forms.RadioButton MPR_Manual_RadioButton;
        private System.Windows.Forms.RadioButton radioButton14;
        private System.Windows.Forms.RadioButton radioButton8;
        private System.Windows.Forms.Button MPR_Insert_Button;
        private System.Windows.Forms.Button NRG_Insert_Button;
        private System.Windows.Forms.Button MPR_POWER_ON_OFF_button;
        private System.Windows.Forms.Button MPR_CD_Track_button;
        private System.Windows.Forms.Button MPR_CD_Volume_button;
        private System.Windows.Forms.Button MPR_CD_Control_button;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button TxTSave_Button;
        private System.Windows.Forms.Button TxTLoad_Cmd_Button;
        private System.Windows.Forms.Button TxTSave_Cmd_Button;
        private System.Windows.Forms.Button Tx_Str_listBox_Clr_Button;
        private System.Windows.Forms.Button NRG16_Clr_Button;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
    }
}

