// Decompiled with JetBrains decompiler
// Type: MissileDesign
// Assembly: Aurora, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAB8E3AD-3A24-426F-849E-98EC2E2DD9EB
// Assembly location: C:\Users\jinhoon.kim\Desktop\Aurora250Full\Dedot\aurora-deop.exe

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

#nullable disable
public class MissileDesign : Form
{
    private GClass0 gclass0_0;
    private GameRace gclass21_0;
    private TechSystem gclass164_0;
    private TechSystem gclass164_1;
    private ShipComponent gclass230_0;
    private RaceMissile gclass129_0;
    private bool bool_0;
    private bool bool_1;
    private IContainer icontainer_0;
    private ComboBox cboRaces;
    private FlowLayoutPanel flowLayoutPanel1;
    private TextBox txtWHSize;
    private FlowLayoutPanel flowLayoutPanel2;
    private Label lblWHStrength;
    private Label lblFuelCapacity;
    private Label lblReactorValue;
    private FlowLayoutPanel flowLayoutPanel3;
    private Label lblWarheadStrength;
    private Label label6;
    private Label label8;
    private FlowLayoutPanel flowLayoutPanel4;
    private TextBox txtSensorSize;
    private TextBox txtThermalSize;
    private TextBox txtEMSize;
    private TextBox txtGeoSize;
    private Label lblSensorValue;
    private Label lblThermalValue;
    private Label lblEMValue;
    private Label lblGeoValue;
    private Label label9;
    private Label label10;
    private Label label11;
    private Label lblGeo;
    private TextBox txtResolution;
    private Label label1;
    private CheckBox chkECCM;
    private Label label2;
    private Label lblECCMValue;
    private Label label18;
    private CheckBox chkERW;
    private Label lblRadiationValue;
    private Label label21;
    private Label label23;
    private Label label24;
    private Label label25;
    private FlowLayoutPanel flowLayoutPanel5;
    private ComboBox cboEnginePower;
    private FlowLayoutPanel flowLayoutPanel6;
    private FlowLayoutPanel flowLayoutPanel7;
    private Label label28;
    private Label lblTotalEnginePower;
    private Label label31;
    private Label lblTotalEngineCost;
    private FlowLayoutPanel flowLayoutPanel9;
    private FlowLayoutPanel flowLayoutPanel10;
    private Label label34;
    private FlowLayoutPanel flowLayoutPanel11;
    private Label label35;
    private TextBox txtNumSS;
    private Label label36;
    private TextBox txtSeparationRange;
    private FlowLayoutPanel flowLayoutPanel12;
    private Label label38;
    private Label lblSecondStageMissileSize;
    private Label label40;
    private Label lblSecondStageMissileCost;
    private FlowLayoutPanel flowLayoutPanel13;
    private Label label37;
    private Label lblSecondStageTotalSize;
    private Label label43;
    private Label lblSecondStageTotalCost;
    private ListView lstvMissileTech;
    private ColumnHeader columnHeader_0;
    private ColumnHeader columnHeader_1;
    private TextBox txtReactorSize;
    private TextBox txtMissileSummary;
    private TextBox txtMissileName;
    private TextBox txtCompanyName;
    private Button cmdCompanyName;
    private CheckBox chkFreezeName;
    private Button cmdInstant;
    private Button cmdCreate;
    private ComboBox cboPreviousDesigns;
    private Label label3;
    private TextBox txtFCSize;
    private CheckBox chkBombardmentPod;
    private CheckBox chkAutocannonoPod;
    private Label lblBombardmentPodValue;
    private Label lblAutocannonPodValue;
    private Label lblBP;
    private Label lblAuto;
    private CheckBox chkATAPod;
    private Label lblATAValue;
    private Label lblATA;
    private FlowLayoutPanel flowLayoutPanel14;
    private ComboBox cboEngineSize;
    private FlowLayoutPanel flowLayoutPanel8;
    private Label label4;
    private Label lblFuelEfficiency;
    private Label label13;
    private Label lblFuelEPH;
    private CheckBox chkNoEngine;
    private Label label5;
    private ComboBox cboSecond;
    private CheckBox chkATG;
    private CheckBox chkRetarget;
    private CheckBox chkLaserWarhead;
    private TextBox txtMinDetonationRange;
    private Label label7;
    private Label label12;
    private Label label14;
    private Label label15;
    private Label lblATGValue;
    private Label lblLaserWarheadValue;
    private Label label16;
    private Label label19;
    private TextBox txtNumDecoys;
    private Label label20;
    private Label label17;
    private TextBox txtMultipleWarheads;
    private Label label22;
    private CheckBox chkShipDecoy;
    private Label lblShipDecoy;
    private Label label27;
    private Label lblShipDecoyBlank;
    private TextBox txtMaxDetonationRange;
    private Label label26;
    private Label label29;

    public MissileDesign(GClass0 gclass0_1)
    {
        this.InitializeComponent();
        this.gclass0_0 = gclass0_1;
    }

    public void method_0(bool bool_2)
    {
        try
        {
            this.lblBP.Visible = bool_2;
            this.chkBombardmentPod.Visible = bool_2;
            this.lblBombardmentPodValue.Visible = bool_2;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2034);
        }
    }

    public void method_1(bool bool_2)
    {
        try
        {
            this.lblShipDecoy.Visible = bool_2;
            this.chkShipDecoy.Visible = bool_2;
            this.lblShipDecoyBlank.Visible = bool_2;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2034);
        }
    }

    public void method_2(bool bool_2)
    {
        try
        {
            this.lblAuto.Visible = bool_2;
            this.chkAutocannonoPod.Visible = bool_2;
            this.lblAutocannonPodValue.Visible = bool_2;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2035);
        }
    }

    public void method_3(bool bool_2)
    {
        try
        {
            this.lblATA.Visible = bool_2;
            this.chkATAPod.Visible = bool_2;
            this.lblATAValue.Visible = bool_2;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2036);
        }
    }

    public void method_4(bool bool_2)
    {
        try
        {
            this.lblGeo.Visible = bool_2;
            this.txtGeoSize.Visible = bool_2;
            this.lblGeoValue.Visible = bool_2;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2036);
        }
    }

    private void MissileDesign_FormClosing(object sender, FormClosingEventArgs e)
    {
        try
        {
            this.gclass0_0.method_512(this.Name, this.Left, this.Top);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2037);
        }
    }

    private void MissileDesign_Load(object sender, EventArgs e)
    {
        try
        {
            WindowPosition207 gclass207 = this.gclass0_0.method_513(this.Name);
            this.Left = gclass207.Left;
            this.Top = gclass207.Top;
            this.gclass0_0.bool_9 = true;
            this.bool_1 = false;
            this.gclass0_0.method_577(this.cboRaces);
            this.gclass21_0 = (GameRace)this.cboRaces.SelectedValue;
            if (this.gclass21_0 == null)
            {
                this.gclass0_0.bool_9 = false;
            }
            else
            {
                this.gclass0_0.bool_9 = false;
                if (this.gclass0_0.bool_8)
                    this.cmdInstant.Visible = true;
                else
                    this.cmdInstant.Visible = false;
                this.method_6();
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2038);
        }
    }

    public void method_5(GameRace gclass21_1)
    {
        try
        {
            this.bool_1 = true;
            this.cboRaces.SelectedItem = gclass21_1;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2039);
        }
    }

    private void cboRaces_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass0_0.bool_9)
                return;
            this.gclass21_0 = (GameRace)this.cboRaces.SelectedValue;
            if (this.gclass21_0 == null)
                return;
            this.method_6();
            if (!this.bool_1)
                this.gclass0_0.method_511(this.gclass21_0, this);
            this.bool_1 = false;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2040);
        }
    }

    private void method_6()
    {
        try
        {
            this.gclass164_0 = this.gclass21_0.method_387(TechType.EngineTechnology);
            this.gclass164_1 = this.gclass21_0.method_387(TechType.FuelConsumption);
            this.gclass0_0.bool_9 = true;
            this.gclass0_0.method_478(this.gclass21_0, this.cboEnginePower, TechType.MissileEngineDisplayPowerModifier,
                0, CheckState.Unchecked, 0);
            this.gclass0_0.method_478(this.gclass21_0, this.cboEngineSize, TechType.MissileEngineDisplaySize, 0,
                CheckState.Unchecked, 0);
            this.gclass21_0.method_218(this.cboSecond, this.cboPreviousDesigns);
            this.gclass21_0.method_194(this.lstvMissileTech, this);
            this.gclass0_0.bool_9 = false;
            this.method_7();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2041);
        }
    }

    private void txtMaxDetonationRange_TextChanged(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass21_0 == null || this.txtWHSize.Text == "" || this.bool_0)
                return;
            if (this.chkShipDecoy.CheckState == CheckState.Checked)
                this.lblWarheadStrength.Text = "Decoy Strength";
            else
                this.lblWarheadStrength.Text = "Warhead Strength";
            this.method_7();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2042);
        }
    }

    private void method_7()
    {
        try
        {
            if (this.gclass0_0.bool_9)
                return;
            Decimal num = AuroraUtils.ParseDecimalOrDefault(this.txtWHSize.Text, 0M);
            if (this.chkShipDecoy.CheckState == CheckState.Checked)
            {
                this.gclass0_0.method_449(this.gclass21_0, num, 1, true, this.lblWHStrength, 0M, this.lblFuelCapacity,
                    this.txtReactorSize, this.lblReactorValue, 0M, 100, this.lblSensorValue, 0M, this.lblThermalValue,
                    0M, this.lblEMValue, 0M, this.lblGeoValue, 0, false, this.lblECCMValue, false,
                    this.lblRadiationValue, false, this.lblATGValue, false, false, this.lblLaserWarheadValue, 0M, 0M,
                    this.gclass230_0, 0, null, 0, 0M, this.lblSecondStageMissileSize, this.lblSecondStageMissileCost,
                    this.lblSecondStageTotalSize, this.lblSecondStageTotalCost, CheckState.Unchecked,
                    CheckState.Unchecked, CheckState.Unchecked, this.lblBombardmentPodValue, this.lblAutocannonPodValue,
                    this.lblATAValue, this.txtMissileName, this.txtMissileSummary, this.chkFreezeName.CheckState, num,
                    false);
            }
            else
            {
                Decimal decimal_14 = AuroraUtils.ParseDecimalOrDefault(this.txtFCSize.Text, 0M);
                Decimal decimal_15 = AuroraUtils.ParseDecimalOrDefault(this.txtSensorSize.Text, 0M);
                Decimal decimal_16 = AuroraUtils.ParseDecimalOrDefault(this.txtThermalSize.Text, 0M);
                Decimal decimal_17 = AuroraUtils.ParseDecimalOrDefault(this.txtEMSize.Text, 0M);
                Decimal decimal_18 = AuroraUtils.ParseDecimalOrDefault(this.txtGeoSize.Text, 0M);
                Decimal decimal_21 = AuroraUtils.ParseDecimalOrDefault(this.txtSeparationRange.Text, 0M);
                int int_138 = (int)AuroraUtils.ParseDecimalOrDefault(this.txtNumDecoys.Text, 0M);
                int int_136 = (int)AuroraUtils.ParseDecimalOrDefault(this.txtMultipleWarheads.Text, 0M);
                TechSystem gclass164 =
                    this.gclass21_0.method_388(this.gclass0_0.TechTypeDataDictionary[TechType.MultipleWarheads]);
                if (gclass164 != null)
                {
                    if (gclass164.decimal_0 == 0M)
                    {
                        this.txtMultipleWarheads.Text = "1";
                        int_136 = 1;
                    }
                }
                else
                {
                    this.txtMultipleWarheads.Text = "1";
                    int_136 = 1;
                }

                if (this.txtMultipleWarheads.Text == "0")
                {
                    this.txtMultipleWarheads.Text = "1";
                    int_136 = 1;
                }

                if (num < 0M)
                {
                    num = 0M;
                    this.txtWHSize.Text = "0";
                }

                if (decimal_14 < 0M)
                {
                    decimal_14 = 0M;
                    this.txtFCSize.Text = "0";
                }

                if (decimal_15 < 0M)
                {
                    decimal_15 = 0M;
                    this.txtSensorSize.Text = "0";
                }

                if (decimal_16 < 0M)
                {
                    decimal_16 = 0M;
                    this.txtThermalSize.Text = "0";
                }

                if (decimal_17 < 0M)
                {
                    decimal_17 = 0M;
                    this.txtEMSize.Text = "0";
                }

                if (decimal_18 < 0M)
                {
                    decimal_18 = 0M;
                    this.txtGeoSize.Text = "0";
                }

                int int_137 = 1;
                int int_140 = 0;
                int decimal_19 = 0;
                int decimal_20 = 0;
                if (this.txtResolution.Text != "")
                    int_137 = Convert.ToInt32(this.txtResolution.Text);
                if (this.txtNumSS.Text != "")
                    int_140 = Convert.ToInt32(this.txtNumSS.Text);
                if (this.txtMinDetonationRange.Text != "")
                    decimal_19 = Convert.ToInt32(this.txtMinDetonationRange.Text);
                if (this.txtMaxDetonationRange.Text != "")
                    decimal_20 = Convert.ToInt32(this.txtMaxDetonationRange.Text);
                bool bool_25 = false;
                if (this.chkShipDecoy.CheckState == CheckState.Checked)
                    bool_25 = true;
                bool bool_26 = false;
                if (this.chkECCM.CheckState == CheckState.Checked)
                    bool_26 = true;
                bool bool_27 = false;
                if (this.chkERW.CheckState == CheckState.Checked)
                    bool_27 = true;
                bool bool_28 = false;
                if (this.chkATG.CheckState == CheckState.Checked)
                    bool_28 = true;
                bool bool_29 = false;
                if (this.chkRetarget.CheckState == CheckState.Checked)
                    bool_29 = true;
                bool bool_30 = false;
                if (this.chkLaserWarhead.CheckState == CheckState.Checked)
                {
                    bool_30 = true;
                    int_136 = 1;
                }
                else
                {
                    decimal_19 = 0;
                    decimal_20 = 0;
                }

                int int_139 = 0;
                if (this.chkNoEngine.CheckState == CheckState.Unchecked &&
                    this.chkBombardmentPod.CheckState == CheckState.Unchecked &&
                    this.chkAutocannonoPod.CheckState == CheckState.Unchecked &&
                    this.chkATAPod.CheckState == CheckState.Unchecked)
                {
                    int_139 = 1;
                    this.gclass230_0 = this.method_8();
                    this.lblTotalEnginePower.Text = AuroraUtils.FormatNumberToDigits(this.gclass230_0.decimal_3, 2);
                    this.lblTotalEngineCost.Text = AuroraUtils.FormatNumberToDigits(this.gclass230_0.decimal_2, 2);
                    this.lblFuelEfficiency.Text = AuroraUtils.FormatNumberToDigits(this.gclass230_0.decimal_8, 2);
                    this.lblFuelEPH.Text =
                        AuroraUtils.FormatNumberToDigits(this.gclass230_0.decimal_8 * this.gclass230_0.decimal_3, 2);
                }
                else
                {
                    this.gclass230_0 = null;
                    this.lblTotalEnginePower.Text = "N/A";
                    this.lblTotalEngineCost.Text = "N/A";
                    this.lblFuelEfficiency.Text = "N/A";
                    this.lblFuelEPH.Text = "N/A";
                }

                RaceMissile selectedValue = (RaceMissile)this.cboSecond.SelectedValue;
                this.gclass0_0.method_449(this.gclass21_0, num, int_136, bool_25, this.lblWHStrength, decimal_14,
                    this.lblFuelCapacity, this.txtReactorSize, this.lblReactorValue, decimal_15, int_137,
                    this.lblSensorValue, decimal_16, this.lblThermalValue, decimal_17, this.lblEMValue, decimal_18,
                    this.lblGeoValue, int_138, bool_26, this.lblECCMValue, bool_27, this.lblRadiationValue, bool_28,
                    this.lblATGValue, bool_29, bool_30, this.lblLaserWarheadValue, decimal_19, decimal_20,
                    this.gclass230_0, int_139, selectedValue, int_140, decimal_21, this.lblSecondStageMissileSize,
                    this.lblSecondStageMissileCost, this.lblSecondStageTotalSize, this.lblSecondStageTotalCost,
                    this.chkBombardmentPod.CheckState, this.chkAutocannonoPod.CheckState, this.chkATAPod.CheckState,
                    this.lblBombardmentPodValue, this.lblAutocannonPodValue, this.lblATAValue, this.txtMissileName,
                    this.txtMissileSummary, this.chkFreezeName.CheckState, 0M, false);
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2043);
        }
    }

    private ShipComponent method_8()
    {
        try
        {
            GClass170 selectedItem1 = (GClass170)this.cboEnginePower.SelectedItem;
            GClass170 selectedItem2 = (GClass170)this.cboEngineSize.SelectedItem;
            return selectedItem2 == null
                ? null
                : this.gclass0_0.method_454(this.gclass21_0, this.gclass164_0, this.gclass164_1,
                    selectedItem1.decimal_0, selectedItem2.decimal_0, null, null, false);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2044);
            return null;
        }
    }

    private void cmdCompanyName_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass21_0 == null)
                return;
            this.txtCompanyName.Text =
                this.gclass0_0.method_479(this.gclass21_0, this.gclass0_0.ResearchCategoryDictionary[ResearchCategoryType.Missiles].CompanyNameType);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2046);
        }
    }

    private void method_9(string string_0)
    {
        try
        {
            int num = this.gclass0_0.TechDataDictionary.Values.Max<TechSystem>(gclass164_0 => gclass164_0.TechSystemID) + 1;
            if (num > this.gclass230_0.gclass164_0.TechSystemID)
            {
                this.gclass230_0.gclass164_0.TechSystemID = num;
                this.gclass230_0.int_0 = num;
            }

            this.gclass0_0.TechDataDictionary.Add(this.gclass230_0.gclass164_0.TechSystemID, this.gclass230_0.gclass164_0);
            this.gclass0_0.ComponentDataDictionary.Add(this.gclass230_0.int_0, this.gclass230_0);
            if (this.gclass21_0 == null)
                return;
            this.gclass21_0.method_282(this.gclass230_0.gclass164_0, null, null, null, false, false);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2047 /*0x07FF*/);
        }
    }

    private void cmdInstant_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass21_0 == null)
            {
                int num1 = (int)MessageBox.Show("Please select a race");
            }
            else
            {
                this.gclass0_0.gclass164_0.Name = !(this.txtCompanyName.Text == "")
                    ? $"{this.txtCompanyName.Text} {this.txtMissileName.Text}"
                    : this.txtMissileName.Text;
                if (this.chkNoEngine.CheckState == CheckState.Unchecked)
                    this.method_9(this.gclass0_0.gclass164_0.Name + " Engine");
                int num2 = this.gclass0_0.TechDataDictionary.Values.Max<TechSystem>(gclass164_0 => gclass164_0.TechSystemID) +
                           1;
                this.gclass0_0.gclass164_0.TechSystemID = num2;
                this.gclass0_0.gclass129_0.int_0 = num2;
                this.gclass0_0.TechDataDictionary.Add(this.gclass0_0.gclass164_0.TechSystemID, this.gclass0_0.gclass164_0);
                this.gclass0_0.gclass129_0.Name = this.gclass0_0.gclass164_0.Name;
                this.gclass0_0.RaceMissileDictionary.Add(this.gclass0_0.gclass129_0.int_0, this.gclass0_0.gclass129_0);
                this.gclass21_0.method_282(this.gclass0_0.gclass164_0, null, null, null, false, false);
                int num3 = (int)MessageBox.Show("Missile has been created and automatically researched");
                this.gclass21_0.method_218(this.cboSecond, this.cboPreviousDesigns);
                this.method_7();
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2048 /*0x0800*/);
        }
    }

    private void cmdCreate_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass0_0.gclass164_0.genum119_0 != ResearchCategoryType.Missiles)
            {
                this.gclass0_0.gclass164_0.int_4 = this.gclass0_0.method_445(this.gclass0_0.gclass129_0.decimal_3 * 5M);
                this.gclass0_0.gclass164_0.Name = this.gclass0_0.gclass129_0.Name;
                this.gclass0_0.gclass164_0.genum119_0 = ResearchCategoryType.Missiles;
                this.gclass0_0.gclass164_0.gclass163_0 = this.gclass0_0.TechTypeDataDictionary[TechType.RDMissile];
                this.gclass0_0.gclass164_0.string_1 = "Race-designed Missile";
            }

            this.gclass0_0.gclass164_0.Name = !(this.txtCompanyName.Text == "")
                ? $"{this.txtCompanyName.Text} {this.txtMissileName.Text}"
                : this.txtMissileName.Text;
            if (this.chkNoEngine.CheckState == CheckState.Unchecked)
                this.method_9(this.gclass0_0.gclass164_0.Name + " Engine");
            int num1 = this.gclass0_0.TechDataDictionary.Values.Max<TechSystem>(gclass164_0 => gclass164_0.TechSystemID) + 1;
            if (num1 > this.gclass0_0.gclass164_0.TechSystemID)
            {
                this.gclass0_0.gclass164_0.TechSystemID = num1;
                this.gclass0_0.gclass129_0.int_0 = num1;
            }

            this.gclass0_0.TechDataDictionary.Add(this.gclass0_0.gclass164_0.TechSystemID, this.gclass0_0.gclass164_0);
            this.gclass0_0.gclass129_0.Name = this.gclass0_0.gclass164_0.Name;
            this.gclass0_0.RaceMissileDictionary.Add(this.gclass0_0.gclass129_0.int_0, this.gclass0_0.gclass129_0);
            int num2 = (int)MessageBox.Show(
                "Missile Design Created. Research the new missile on the Research tab of the economics window");
            this.method_7();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2049);
        }
    }

    private void cboEngineSize_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass0_0.bool_9)
                return;
            this.method_7();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2050);
        }
    }

    private void txtMissileSummary_TextChanged(object sender, EventArgs e)
    {
    }

    private void chkNoEngine_CheckedChanged(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass21_0 == null || this.txtWHSize.Text == "" || this.bool_0)
                return;
            this.method_7();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3207);
        }
    }

    private void chkATAPod_CheckedChanged(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass21_0 == null || this.txtWHSize.Text == "" || this.bool_0)
                return;
            CheckBox checkBox = (CheckBox)sender;
            this.bool_0 = true;
            if (checkBox.CheckState == CheckState.Checked)
                this.lblWarheadStrength.Text = "Pod Size";
            else
                this.lblWarheadStrength.Text = "Warhead Strength";
            if (checkBox == this.chkBombardmentPod)
            {
                if (this.chkBombardmentPod.CheckState == CheckState.Checked)
                {
                    this.chkAutocannonoPod.CheckState = CheckState.Unchecked;
                    this.chkATAPod.CheckState = CheckState.Unchecked;
                }
            }
            else if (checkBox == this.chkAutocannonoPod)
            {
                if (this.chkAutocannonoPod.CheckState == CheckState.Checked)
                {
                    this.chkBombardmentPod.CheckState = CheckState.Unchecked;
                    this.chkATAPod.CheckState = CheckState.Unchecked;
                }
            }
            else if (checkBox == this.chkATAPod && this.chkATAPod.CheckState == CheckState.Checked)
            {
                this.chkAutocannonoPod.CheckState = CheckState.Unchecked;
                this.chkBombardmentPod.CheckState = CheckState.Unchecked;
            }

            if (this.chkBombardmentPod.CheckState == CheckState.Checked ||
                this.chkAutocannonoPod.CheckState == CheckState.Checked ||
                this.chkATAPod.CheckState == CheckState.Checked)
            {
                this.txtFCSize.Text = "0";
                this.txtReactorSize.Text = "0";
                this.txtSensorSize.Text = "0";
                this.txtThermalSize.Text = "0";
                this.txtEMSize.Text = "0";
                this.txtGeoSize.Text = "0";
                this.txtNumSS.Text = "0";
                this.txtNumDecoys.Text = "0";
                this.chkECCM.CheckState = CheckState.Unchecked;
            }

            this.bool_0 = false;
            this.method_7();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2051);
        }
    }

    private void cboSecond_SelectedIndexChanged(object sender, EventArgs e)
    {
    }

    private void MissileDesign_KeyDown(object sender, KeyEventArgs e)
    {
        try
        {
            if (e.Modifiers == Keys.Alt && e.KeyCode == Keys.F4)
            {
                this.Close();
            }
            else
            {
                if (this.gclass21_0 == null)
                    return;
                this.gclass21_0.method_174(e, this.gclass0_0.tacticalMap_0.gclass202_0);
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3282);
        }
    }

    private void txtMultipleWarheads_TextChanged(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass21_0 == null || this.txtMultipleWarheads.Text == "" || this.bool_0)
                return;
            this.method_7();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3674);
        }
    }

    private void txtNumDecoys_TextChanged(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass21_0 == null || this.txtNumDecoys.Text == "" || this.bool_0)
                return;
            this.method_7();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3660);
        }
    }

    private void cboPreviousDesigns_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass0_0.bool_9 || this.gclass21_0 == null)
                return;
            this.gclass129_0 = (RaceMissile)this.cboPreviousDesigns.SelectedValue;
            if (this.gclass129_0 == null)
                return;
            this.gclass0_0.bool_9 = true;
            this.txtWHSize.Text = this.gclass129_0.decimal_7.ToString();
            this.txtFCSize.Text = this.gclass129_0.decimal_9.ToString();
            this.txtSensorSize.Text = this.gclass129_0.decimal_10.ToString();
            this.txtThermalSize.Text = this.gclass129_0.decimal_11.ToString();
            this.txtEMSize.Text = this.gclass129_0.decimal_12.ToString();
            this.txtGeoSize.Text = this.gclass129_0.decimal_13.ToString();
            this.txtResolution.Text = this.gclass129_0.int_5.ToString();
            this.txtNumSS.Text = this.gclass129_0.int_16.ToString();
            this.txtMultipleWarheads.Text = this.gclass129_0.int_13.ToString();
            this.txtMinDetonationRange.Text = this.gclass129_0.decimal_24.ToString();
            this.txtMaxDetonationRange.Text = this.gclass129_0.decimal_25.ToString();
            this.cboEngineSize.SelectedItem =
                ((IEnumerable<GClass170>)this.cboEngineSize.DataSource).FirstOrDefault<GClass170>(gclass170_0 =>
                    gclass170_0.decimal_0 == this.gclass129_0.decimal_8);
            this.cboEnginePower.SelectedItem =
                ((IEnumerable<GClass170>)this.cboEnginePower.DataSource).FirstOrDefault<GClass170>(gclass170_0 =>
                    gclass170_0.decimal_0 == this.gclass129_0.decimal_23);
            this.cboSecond.SelectedItem =
                ((IEnumerable<RaceMissile>)this.cboSecond.DataSource).FirstOrDefault<RaceMissile>(gclass129_1 =>
                    gclass129_1 == this.gclass129_0.gclass129_0);
            this.txtSeparationRange.Text = this.gclass129_0.int_17.ToString();
            if (this.gclass129_0.int_7 > 0)
                this.txtNumDecoys.Text = this.gclass129_0.int_7.ToString();
            else
                this.txtNumDecoys.Text = "0";
            this.chkECCM.CheckState = this.gclass129_0.int_8 <= 0 ? CheckState.Unchecked : CheckState.Checked;
            this.chkERW.CheckState = !(this.gclass129_0.decimal_2 > this.gclass129_0.decimal_0)
                ? CheckState.Unchecked
                : CheckState.Checked;
            this.chkNoEngine.CheckState =
                this.gclass129_0.gclass230_0 != null ? CheckState.Unchecked : CheckState.Checked;
            this.chkRetarget.CheckState = this.gclass129_0.int_10 != 1 ? CheckState.Unchecked : CheckState.Checked;
            this.chkATG.CheckState = !(this.gclass129_0.decimal_26 > 1M) ? CheckState.Unchecked : CheckState.Checked;
            this.chkLaserWarhead.CheckState =
                !(this.gclass129_0.decimal_1 > 0M) ? CheckState.Unchecked : CheckState.Checked;
            this.gclass0_0.bool_9 = false;
            this.method_7();
            this.txtMissileName.Text = this.gclass129_0.Name;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2052);
        }
    }

    protected override void Dispose(bool disposing)
    {
        if (disposing && this.icontainer_0 != null)
            this.icontainer_0.Dispose();
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        this.cboRaces = new ComboBox();
        this.flowLayoutPanel1 = new FlowLayoutPanel();
        this.label23 = new Label();
        this.txtWHSize = new TextBox();
        this.txtFCSize = new TextBox();
        this.txtReactorSize = new TextBox();
        this.txtSensorSize = new TextBox();
        this.txtThermalSize = new TextBox();
        this.txtEMSize = new TextBox();
        this.txtGeoSize = new TextBox();
        this.txtNumDecoys = new TextBox();
        this.txtMultipleWarheads = new TextBox();
        this.txtResolution = new TextBox();
        this.chkECCM = new CheckBox();
        this.chkATG = new CheckBox();
        this.chkRetarget = new CheckBox();
        this.chkLaserWarhead = new CheckBox();
        this.txtMinDetonationRange = new TextBox();
        this.chkShipDecoy = new CheckBox();
        this.chkERW = new CheckBox();
        this.chkBombardmentPod = new CheckBox();
        this.chkAutocannonoPod = new CheckBox();
        this.chkATAPod = new CheckBox();
        this.chkNoEngine = new CheckBox();
        this.flowLayoutPanel2 = new FlowLayoutPanel();
        this.label24 = new Label();
        this.lblWHStrength = new Label();
        this.lblFuelCapacity = new Label();
        this.lblReactorValue = new Label();
        this.lblSensorValue = new Label();
        this.lblThermalValue = new Label();
        this.lblEMValue = new Label();
        this.lblGeoValue = new Label();
        this.label20 = new Label();
        this.label2 = new Label();
        this.label27 = new Label();
        this.lblECCMValue = new Label();
        this.lblATGValue = new Label();
        this.label16 = new Label();
        this.lblLaserWarheadValue = new Label();
        this.label19 = new Label();
        this.lblShipDecoyBlank = new Label();
        this.lblRadiationValue = new Label();
        this.lblBombardmentPodValue = new Label();
        this.lblAutocannonPodValue = new Label();
        this.lblATAValue = new Label();
        this.flowLayoutPanel3 = new FlowLayoutPanel();
        this.label25 = new Label();
        this.lblWarheadStrength = new Label();
        this.label6 = new Label();
        this.label8 = new Label();
        this.label9 = new Label();
        this.label10 = new Label();
        this.label11 = new Label();
        this.lblGeo = new Label();
        this.label17 = new Label();
        this.label22 = new Label();
        this.label1 = new Label();
        this.label18 = new Label();
        this.label7 = new Label();
        this.label12 = new Label();
        this.label14 = new Label();
        this.label15 = new Label();
        this.lblShipDecoy = new Label();
        this.label21 = new Label();
        this.lblBP = new Label();
        this.lblAuto = new Label();
        this.lblATA = new Label();
        this.label5 = new Label();
        this.flowLayoutPanel4 = new FlowLayoutPanel();
        this.flowLayoutPanel5 = new FlowLayoutPanel();
        this.cboEnginePower = new ComboBox();
        this.flowLayoutPanel6 = new FlowLayoutPanel();
        this.flowLayoutPanel14 = new FlowLayoutPanel();
        this.cboEngineSize = new ComboBox();
        this.flowLayoutPanel7 = new FlowLayoutPanel();
        this.label28 = new Label();
        this.lblTotalEnginePower = new Label();
        this.label31 = new Label();
        this.lblTotalEngineCost = new Label();
        this.flowLayoutPanel8 = new FlowLayoutPanel();
        this.label4 = new Label();
        this.lblFuelEfficiency = new Label();
        this.label13 = new Label();
        this.lblFuelEPH = new Label();
        this.flowLayoutPanel9 = new FlowLayoutPanel();
        this.flowLayoutPanel10 = new FlowLayoutPanel();
        this.label34 = new Label();
        this.cboSecond = new ComboBox();
        this.flowLayoutPanel11 = new FlowLayoutPanel();
        this.label35 = new Label();
        this.txtNumSS = new TextBox();
        this.label36 = new Label();
        this.txtSeparationRange = new TextBox();
        this.flowLayoutPanel12 = new FlowLayoutPanel();
        this.label38 = new Label();
        this.lblSecondStageMissileSize = new Label();
        this.label40 = new Label();
        this.lblSecondStageMissileCost = new Label();
        this.flowLayoutPanel13 = new FlowLayoutPanel();
        this.label37 = new Label();
        this.lblSecondStageTotalSize = new Label();
        this.label43 = new Label();
        this.lblSecondStageTotalCost = new Label();
        this.lstvMissileTech = new ListView();
        this.columnHeader_0 = new ColumnHeader();
        this.columnHeader_1 = new ColumnHeader();
        this.txtMissileSummary = new TextBox();
        this.txtMissileName = new TextBox();
        this.txtCompanyName = new TextBox();
        this.cmdCompanyName = new Button();
        this.chkFreezeName = new CheckBox();
        this.cmdInstant = new Button();
        this.cmdCreate = new Button();
        this.cboPreviousDesigns = new ComboBox();
        this.label3 = new Label();
        this.label26 = new Label();
        this.txtMaxDetonationRange = new TextBox();
        this.label29 = new Label();
        this.flowLayoutPanel1.SuspendLayout();
        this.flowLayoutPanel2.SuspendLayout();
        this.flowLayoutPanel3.SuspendLayout();
        this.flowLayoutPanel4.SuspendLayout();
        this.flowLayoutPanel5.SuspendLayout();
        this.flowLayoutPanel6.SuspendLayout();
        this.flowLayoutPanel14.SuspendLayout();
        this.flowLayoutPanel7.SuspendLayout();
        this.flowLayoutPanel8.SuspendLayout();
        this.flowLayoutPanel9.SuspendLayout();
        this.flowLayoutPanel10.SuspendLayout();
        this.flowLayoutPanel11.SuspendLayout();
        this.flowLayoutPanel12.SuspendLayout();
        this.flowLayoutPanel13.SuspendLayout();
        this.SuspendLayout();
        this.cboRaces.AccessibleName = "Race Dropdown";
        this.cboRaces.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cboRaces.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.cboRaces.FormattingEnabled = true;
        this.cboRaces.Location = new Point(3, 3);
        this.cboRaces.Margin = new Padding(3, 3, 3, 0);
        this.cboRaces.Name = "cboRaces";
        this.cboRaces.Size = new Size(292, 21);
        this.cboRaces.TabIndex = 1;
        this.cboRaces.SelectedIndexChanged += this.cboRaces_SelectedIndexChanged;
        this.flowLayoutPanel1.Controls.Add(this.label23);
        this.flowLayoutPanel1.Controls.Add(this.txtWHSize);
        this.flowLayoutPanel1.Controls.Add(this.txtFCSize);
        this.flowLayoutPanel1.Controls.Add(this.txtReactorSize);
        this.flowLayoutPanel1.Controls.Add(this.txtSensorSize);
        this.flowLayoutPanel1.Controls.Add(this.txtThermalSize);
        this.flowLayoutPanel1.Controls.Add(this.txtEMSize);
        this.flowLayoutPanel1.Controls.Add(this.txtGeoSize);
        this.flowLayoutPanel1.Controls.Add(this.txtNumDecoys);
        this.flowLayoutPanel1.Controls.Add(this.txtMultipleWarheads);
        this.flowLayoutPanel1.Controls.Add(this.txtResolution);
        this.flowLayoutPanel1.Controls.Add(this.chkECCM);
        this.flowLayoutPanel1.Controls.Add(this.chkATG);
        this.flowLayoutPanel1.Controls.Add(this.chkRetarget);
        this.flowLayoutPanel1.Controls.Add(this.chkLaserWarhead);
        this.flowLayoutPanel1.Controls.Add(this.txtMinDetonationRange);
        this.flowLayoutPanel1.Controls.Add(this.txtMaxDetonationRange);
        this.flowLayoutPanel1.Controls.Add(this.chkShipDecoy);
        this.flowLayoutPanel1.Controls.Add(this.chkERW);
        this.flowLayoutPanel1.Controls.Add(this.chkBombardmentPod);
        this.flowLayoutPanel1.Controls.Add(this.chkAutocannonoPod);
        this.flowLayoutPanel1.Controls.Add(this.chkATAPod);
        this.flowLayoutPanel1.Controls.Add(this.chkNoEngine);
        this.flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
        this.flowLayoutPanel1.Location = new Point(126, 3);
        this.flowLayoutPanel1.Name = "flowLayoutPanel1";
        this.flowLayoutPanel1.Size = new Size(73, 619);
        this.flowLayoutPanel1.TabIndex = 32 /*0x20*/;
        this.label23.Location = new Point(6, 6);
        this.label23.Margin = new Padding(6, 6, 3, 0);
        this.label23.Name = "label23";
        this.label23.Padding = new Padding(0, 5, 5, 0);
        this.label23.Size = new Size(65, 18);
        this.label23.TabIndex = 131;
        this.label23.Text = "MSP";
        this.label23.TextAlign = ContentAlignment.MiddleCenter;
        this.txtWHSize.AccessibleName = "Warhead Size";
        this.txtWHSize.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtWHSize.BorderStyle = BorderStyle.None;
        this.txtWHSize.ForeColor = Color.FromArgb(128 /*0x80*/, byte.MaxValue, 128 /*0x80*/);
        this.txtWHSize.Location = new Point(3, 35);
        this.txtWHSize.Margin = new Padding(3, 11, 3, 0);
        this.txtWHSize.Name = "txtWHSize";
        this.txtWHSize.Size = new Size(65, 13);
        this.txtWHSize.TabIndex = 5;
        this.txtWHSize.Text = "1";
        this.txtWHSize.TextAlign = HorizontalAlignment.Center;
        this.txtWHSize.TextChanged += this.txtMaxDetonationRange_TextChanged;
        this.txtFCSize.AccessibleName = "Fuel Capacity Size";
        this.txtFCSize.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtFCSize.BorderStyle = BorderStyle.None;
        this.txtFCSize.ForeColor = Color.FromArgb(128 /*0x80*/, byte.MaxValue, 128 /*0x80*/);
        this.txtFCSize.Location = new Point(3, 59);
        this.txtFCSize.Margin = new Padding(3, 11, 3, 0);
        this.txtFCSize.Name = "txtFCSize";
        this.txtFCSize.Size = new Size(65, 13);
        this.txtFCSize.TabIndex = 8;
        this.txtFCSize.Text = "0.5";
        this.txtFCSize.TextAlign = HorizontalAlignment.Center;
        this.txtFCSize.TextChanged += this.txtMaxDetonationRange_TextChanged;
        this.txtReactorSize.AccessibleName = "Reactor Size";
        this.txtReactorSize.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtReactorSize.BorderStyle = BorderStyle.None;
        this.txtReactorSize.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.txtReactorSize.Location = new Point(3, 83);
        this.txtReactorSize.Margin = new Padding(3, 11, 3, 0);
        this.txtReactorSize.Name = "txtReactorSize";
        this.txtReactorSize.ReadOnly = true;
        this.txtReactorSize.Size = new Size(65, 13);
        this.txtReactorSize.TabIndex = 14;
        this.txtReactorSize.Text = "0";
        this.txtReactorSize.TextAlign = HorizontalAlignment.Center;
        this.txtSensorSize.AccessibleName = "Active Sensor Size";
        this.txtSensorSize.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtSensorSize.BorderStyle = BorderStyle.None;
        this.txtSensorSize.ForeColor = Color.FromArgb(128 /*0x80*/, byte.MaxValue, 128 /*0x80*/);
        this.txtSensorSize.Location = new Point(3, 107);
        this.txtSensorSize.Margin = new Padding(3, 11, 3, 0);
        this.txtSensorSize.Name = "txtSensorSize";
        this.txtSensorSize.Size = new Size(65, 13);
        this.txtSensorSize.TabIndex = 17;
        this.txtSensorSize.Text = "0";
        this.txtSensorSize.TextAlign = HorizontalAlignment.Center;
        this.txtSensorSize.TextChanged += this.txtMaxDetonationRange_TextChanged;
        this.txtThermalSize.AccessibleName = "Thermal Sensor Size";
        this.txtThermalSize.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtThermalSize.BorderStyle = BorderStyle.None;
        this.txtThermalSize.ForeColor = Color.FromArgb(128 /*0x80*/, byte.MaxValue, 128 /*0x80*/);
        this.txtThermalSize.Location = new Point(3, 131);
        this.txtThermalSize.Margin = new Padding(3, 11, 3, 0);
        this.txtThermalSize.Name = "txtThermalSize";
        this.txtThermalSize.Size = new Size(65, 13);
        this.txtThermalSize.TabIndex = 21;
        this.txtThermalSize.Text = "0";
        this.txtThermalSize.TextAlign = HorizontalAlignment.Center;
        this.txtThermalSize.TextChanged += this.txtMaxDetonationRange_TextChanged;
        this.txtEMSize.AccessibleName = "EM Sensor Size";
        this.txtEMSize.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtEMSize.BorderStyle = BorderStyle.None;
        this.txtEMSize.ForeColor = Color.FromArgb(128 /*0x80*/, byte.MaxValue, 128 /*0x80*/);
        this.txtEMSize.Location = new Point(3, 155);
        this.txtEMSize.Margin = new Padding(3, 11, 3, 0);
        this.txtEMSize.Name = "txtEMSize";
        this.txtEMSize.Size = new Size(65, 13);
        this.txtEMSize.TabIndex = 24;
        this.txtEMSize.Text = "0";
        this.txtEMSize.TextAlign = HorizontalAlignment.Center;
        this.txtEMSize.TextChanged += this.txtMaxDetonationRange_TextChanged;
        this.txtGeoSize.AccessibleName = "Geo Sensor Size";
        this.txtGeoSize.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtGeoSize.BorderStyle = BorderStyle.None;
        this.txtGeoSize.ForeColor = Color.FromArgb(128 /*0x80*/, byte.MaxValue, 128 /*0x80*/);
        this.txtGeoSize.Location = new Point(3, 179);
        this.txtGeoSize.Margin = new Padding(3, 11, 3, 0);
        this.txtGeoSize.Name = "txtGeoSize";
        this.txtGeoSize.Size = new Size(65, 13);
        this.txtGeoSize.TabIndex = 27;
        this.txtGeoSize.Text = "0";
        this.txtGeoSize.TextAlign = HorizontalAlignment.Center;
        this.txtGeoSize.TextChanged += this.txtMaxDetonationRange_TextChanged;
        this.txtNumDecoys.AccessibleName = "Geo Sensor Size";
        this.txtNumDecoys.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtNumDecoys.BorderStyle = BorderStyle.None;
        this.txtNumDecoys.ForeColor = Color.FromArgb(128 /*0x80*/, byte.MaxValue, 128 /*0x80*/);
        this.txtNumDecoys.Location = new Point(3, 203);
        this.txtNumDecoys.Margin = new Padding(3, 11, 3, 0);
        this.txtNumDecoys.Name = "txtNumDecoys";
        this.txtNumDecoys.Size = new Size(65, 13);
        this.txtNumDecoys.TabIndex = 136;
        this.txtNumDecoys.Text = "0";
        this.txtNumDecoys.TextAlign = HorizontalAlignment.Center;
        this.txtNumDecoys.TextChanged += this.txtNumDecoys_TextChanged;
        this.txtMultipleWarheads.AccessibleName = "Geo Sensor Size";
        this.txtMultipleWarheads.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtMultipleWarheads.BorderStyle = BorderStyle.None;
        this.txtMultipleWarheads.ForeColor = Color.FromArgb(128 /*0x80*/, byte.MaxValue, 128 /*0x80*/);
        this.txtMultipleWarheads.Location = new Point(3, 227);
        this.txtMultipleWarheads.Margin = new Padding(3, 11, 3, 0);
        this.txtMultipleWarheads.Name = "txtMultipleWarheads";
        this.txtMultipleWarheads.Size = new Size(65, 13);
        this.txtMultipleWarheads.TabIndex = 137;
        this.txtMultipleWarheads.Text = "1";
        this.txtMultipleWarheads.TextAlign = HorizontalAlignment.Center;
        this.txtMultipleWarheads.TextChanged += this.txtMultipleWarheads_TextChanged;
        this.txtResolution.AccessibleName = "Active Resolution";
        this.txtResolution.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtResolution.BorderStyle = BorderStyle.None;
        this.txtResolution.ForeColor = Color.FromArgb(128 /*0x80*/, byte.MaxValue, 128 /*0x80*/);
        this.txtResolution.Location = new Point(3, 251);
        this.txtResolution.Margin = new Padding(3, 11, 3, 0);
        this.txtResolution.Name = "txtResolution";
        this.txtResolution.Size = new Size(65, 13);
        this.txtResolution.TabIndex = 30;
        this.txtResolution.Text = "100";
        this.txtResolution.TextAlign = HorizontalAlignment.Center;
        this.txtResolution.TextChanged += this.txtMaxDetonationRange_TextChanged;
        this.chkECCM.AccessibleName = "ECCM";
        this.chkECCM.CheckAlign = ContentAlignment.MiddleRight;
        this.chkECCM.Location = new Point(6, 271);
        this.chkECCM.Margin = new Padding(6, 7, 3, 0);
        this.chkECCM.Name = "chkECCM";
        this.chkECCM.Padding = new Padding(0, 5, 5, 0);
        this.chkECCM.Size = new Size(41, 17);
        this.chkECCM.TabIndex = 35;
        this.chkECCM.UseVisualStyleBackColor = true;
        this.chkECCM.CheckedChanged += this.txtMaxDetonationRange_TextChanged;
        this.chkATG.AccessibleName = "No Engine";
        this.chkATG.CheckAlign = ContentAlignment.MiddleRight;
        this.chkATG.Location = new Point(6, 295);
        this.chkATG.Margin = new Padding(6, 7, 3, 0);
        this.chkATG.Name = "chkATG";
        this.chkATG.Padding = new Padding(0, 5, 5, 0);
        this.chkATG.Size = new Size(41, 17);
        this.chkATG.TabIndex = 132;
        this.chkATG.UseVisualStyleBackColor = true;
        this.chkATG.CheckedChanged += this.txtMaxDetonationRange_TextChanged;
        this.chkRetarget.AccessibleName = "No Engine";
        this.chkRetarget.CheckAlign = ContentAlignment.MiddleRight;
        this.chkRetarget.Location = new Point(6, 319);
        this.chkRetarget.Margin = new Padding(6, 7, 3, 0);
        this.chkRetarget.Name = "chkRetarget";
        this.chkRetarget.Padding = new Padding(0, 5, 5, 0);
        this.chkRetarget.Size = new Size(41, 17);
        this.chkRetarget.TabIndex = 133;
        this.chkRetarget.UseVisualStyleBackColor = true;
        this.chkRetarget.CheckedChanged += this.txtMaxDetonationRange_TextChanged;
        this.chkLaserWarhead.AccessibleName = "No Engine";
        this.chkLaserWarhead.CheckAlign = ContentAlignment.MiddleRight;
        this.chkLaserWarhead.Location = new Point(6, 343);
        this.chkLaserWarhead.Margin = new Padding(6, 7, 3, 0);
        this.chkLaserWarhead.Name = "chkLaserWarhead";
        this.chkLaserWarhead.Padding = new Padding(0, 5, 5, 0);
        this.chkLaserWarhead.Size = new Size(41, 17);
        this.chkLaserWarhead.TabIndex = 134;
        this.chkLaserWarhead.UseVisualStyleBackColor = true;
        this.chkLaserWarhead.CheckedChanged += this.txtMaxDetonationRange_TextChanged;
        this.txtMinDetonationRange.AccessibleName = "Active Resolution";
        this.txtMinDetonationRange.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtMinDetonationRange.BorderStyle = BorderStyle.None;
        this.txtMinDetonationRange.ForeColor = Color.FromArgb(128 /*0x80*/, byte.MaxValue, 128 /*0x80*/);
        this.txtMinDetonationRange.Location = new Point(3, 371);
        this.txtMinDetonationRange.Margin = new Padding(3, 11, 3, 0);
        this.txtMinDetonationRange.Name = "txtMinDetonationRange";
        this.txtMinDetonationRange.Size = new Size(65, 13);
        this.txtMinDetonationRange.TabIndex = 135;
        this.txtMinDetonationRange.Text = "0";
        this.txtMinDetonationRange.TextAlign = HorizontalAlignment.Center;
        this.txtMinDetonationRange.TextChanged += this.txtMaxDetonationRange_TextChanged;
        this.chkShipDecoy.AccessibleName = "No Engine";
        this.chkShipDecoy.CheckAlign = ContentAlignment.MiddleRight;
        this.chkShipDecoy.Location = new Point(6, 415);
        this.chkShipDecoy.Margin = new Padding(6, 7, 3, 0);
        this.chkShipDecoy.Name = "chkShipDecoy";
        this.chkShipDecoy.Padding = new Padding(0, 5, 5, 0);
        this.chkShipDecoy.Size = new Size(41, 17);
        this.chkShipDecoy.TabIndex = 138;
        this.chkShipDecoy.UseVisualStyleBackColor = true;
        this.chkShipDecoy.CheckedChanged += this.txtMaxDetonationRange_TextChanged;
        this.chkERW.AccessibleName = "Enhanced Radiation";
        this.chkERW.CheckAlign = ContentAlignment.MiddleRight;
        this.chkERW.Location = new Point(6, 439);
        this.chkERW.Margin = new Padding(6, 7, 3, 0);
        this.chkERW.Name = "chkERW";
        this.chkERW.Padding = new Padding(0, 5, 5, 0);
        this.chkERW.Size = new Size(41, 17);
        this.chkERW.TabIndex = 38;
        this.chkERW.UseVisualStyleBackColor = true;
        this.chkERW.CheckedChanged += this.txtMaxDetonationRange_TextChanged;
        this.chkBombardmentPod.AccessibleName = "Bombardment Pod";
        this.chkBombardmentPod.CheckAlign = ContentAlignment.MiddleRight;
        this.chkBombardmentPod.Location = new Point(6, 463);
        this.chkBombardmentPod.Margin = new Padding(6, 7, 3, 0);
        this.chkBombardmentPod.Name = "chkBombardmentPod";
        this.chkBombardmentPod.Padding = new Padding(0, 5, 5, 0);
        this.chkBombardmentPod.Size = new Size(41, 17);
        this.chkBombardmentPod.TabIndex = 41;
        this.chkBombardmentPod.UseVisualStyleBackColor = true;
        this.chkBombardmentPod.CheckedChanged += this.chkATAPod_CheckedChanged;
        this.chkAutocannonoPod.AccessibleName = "Autocannon Pod";
        this.chkAutocannonoPod.CheckAlign = ContentAlignment.MiddleRight;
        this.chkAutocannonoPod.Location = new Point(6, 487);
        this.chkAutocannonoPod.Margin = new Padding(6, 7, 3, 0);
        this.chkAutocannonoPod.Name = "chkAutocannonoPod";
        this.chkAutocannonoPod.Padding = new Padding(0, 5, 5, 0);
        this.chkAutocannonoPod.Size = new Size(41, 17);
        this.chkAutocannonoPod.TabIndex = 44;
        this.chkAutocannonoPod.UseVisualStyleBackColor = true;
        this.chkAutocannonoPod.CheckedChanged += this.chkATAPod_CheckedChanged;
        this.chkATAPod.AccessibleName = "Air-toAir Pod";
        this.chkATAPod.CheckAlign = ContentAlignment.MiddleRight;
        this.chkATAPod.Location = new Point(6, 511 /*0x01FF*/);
        this.chkATAPod.Margin = new Padding(6, 7, 3, 0);
        this.chkATAPod.Name = "chkATAPod";
        this.chkATAPod.Padding = new Padding(0, 5, 5, 0);
        this.chkATAPod.Size = new Size(41, 17);
        this.chkATAPod.TabIndex = 47;
        this.chkATAPod.UseVisualStyleBackColor = true;
        this.chkATAPod.CheckedChanged += this.chkATAPod_CheckedChanged;
        this.chkNoEngine.AccessibleName = "No Engine";
        this.chkNoEngine.CheckAlign = ContentAlignment.MiddleRight;
        this.chkNoEngine.Location = new Point(6, 535);
        this.chkNoEngine.Margin = new Padding(6, 7, 3, 0);
        this.chkNoEngine.Name = "chkNoEngine";
        this.chkNoEngine.Padding = new Padding(0, 5, 5, 0);
        this.chkNoEngine.Size = new Size(41, 17);
        this.chkNoEngine.TabIndex = 50;
        this.chkNoEngine.UseVisualStyleBackColor = true;
        this.chkNoEngine.CheckedChanged += this.chkNoEngine_CheckedChanged;
        this.flowLayoutPanel2.Controls.Add(this.label24);
        this.flowLayoutPanel2.Controls.Add(this.lblWHStrength);
        this.flowLayoutPanel2.Controls.Add(this.lblFuelCapacity);
        this.flowLayoutPanel2.Controls.Add(this.lblReactorValue);
        this.flowLayoutPanel2.Controls.Add(this.lblSensorValue);
        this.flowLayoutPanel2.Controls.Add(this.lblThermalValue);
        this.flowLayoutPanel2.Controls.Add(this.lblEMValue);
        this.flowLayoutPanel2.Controls.Add(this.lblGeoValue);
        this.flowLayoutPanel2.Controls.Add(this.label20);
        this.flowLayoutPanel2.Controls.Add(this.label2);
        this.flowLayoutPanel2.Controls.Add(this.label27);
        this.flowLayoutPanel2.Controls.Add(this.lblECCMValue);
        this.flowLayoutPanel2.Controls.Add(this.lblATGValue);
        this.flowLayoutPanel2.Controls.Add(this.label16);
        this.flowLayoutPanel2.Controls.Add(this.lblLaserWarheadValue);
        this.flowLayoutPanel2.Controls.Add(this.label19);
        this.flowLayoutPanel2.Controls.Add(this.label29);
        this.flowLayoutPanel2.Controls.Add(this.lblShipDecoyBlank);
        this.flowLayoutPanel2.Controls.Add(this.lblRadiationValue);
        this.flowLayoutPanel2.Controls.Add(this.lblBombardmentPodValue);
        this.flowLayoutPanel2.Controls.Add(this.lblAutocannonPodValue);
        this.flowLayoutPanel2.Controls.Add(this.lblATAValue);
        this.flowLayoutPanel2.FlowDirection = FlowDirection.TopDown;
        this.flowLayoutPanel2.Location = new Point(205, 3);
        this.flowLayoutPanel2.Name = "flowLayoutPanel2";
        this.flowLayoutPanel2.Size = new Size(74, 619);
        this.flowLayoutPanel2.TabIndex = 118;
        this.label24.Location = new Point(3, 6);
        this.label24.Margin = new Padding(3, 6, 3, 0);
        this.label24.Name = "label24";
        this.label24.Padding = new Padding(0, 5, 5, 0);
        this.label24.Size = new Size(65, 18);
        this.label24.TabIndex = 132;
        this.label24.Text = "Value";
        this.label24.TextAlign = ContentAlignment.MiddleCenter;
        this.lblWHStrength.AccessibleName = "Warhead Strength";
        this.lblWHStrength.Location = new Point(3, 30);
        this.lblWHStrength.Margin = new Padding(3, 6, 3, 0);
        this.lblWHStrength.Name = "lblWHStrength";
        this.lblWHStrength.Padding = new Padding(0, 5, 5, 0);
        this.lblWHStrength.Size = new Size(65, 18);
        this.lblWHStrength.TabIndex = 6;
        this.lblWHStrength.Text = "0";
        this.lblWHStrength.TextAlign = ContentAlignment.MiddleCenter;
        this.lblFuelCapacity.AccessibleName = "Fuel Capacity Value";
        this.lblFuelCapacity.Location = new Point(3, 54);
        this.lblFuelCapacity.Margin = new Padding(3, 6, 3, 0);
        this.lblFuelCapacity.Name = "lblFuelCapacity";
        this.lblFuelCapacity.Padding = new Padding(0, 5, 5, 0);
        this.lblFuelCapacity.Size = new Size(65, 18);
        this.lblFuelCapacity.TabIndex = 9;
        this.lblFuelCapacity.Text = "0";
        this.lblFuelCapacity.TextAlign = ContentAlignment.MiddleCenter;
        this.lblReactorValue.AccessibleName = "Reactor Value";
        this.lblReactorValue.Location = new Point(3, 78);
        this.lblReactorValue.Margin = new Padding(3, 6, 3, 0);
        this.lblReactorValue.Name = "lblReactorValue";
        this.lblReactorValue.Padding = new Padding(0, 5, 5, 0);
        this.lblReactorValue.Size = new Size(65, 18);
        this.lblReactorValue.TabIndex = 15;
        this.lblReactorValue.Text = "0";
        this.lblReactorValue.TextAlign = ContentAlignment.MiddleCenter;
        this.lblSensorValue.AccessibleName = "Active Sensor Value";
        this.lblSensorValue.Location = new Point(3, 102);
        this.lblSensorValue.Margin = new Padding(3, 6, 3, 0);
        this.lblSensorValue.Name = "lblSensorValue";
        this.lblSensorValue.Padding = new Padding(0, 5, 5, 0);
        this.lblSensorValue.Size = new Size(65, 18);
        this.lblSensorValue.TabIndex = 18;
        this.lblSensorValue.Text = "0";
        this.lblSensorValue.TextAlign = ContentAlignment.MiddleCenter;
        this.lblThermalValue.AccessibleName = "Thermal Sensor Value";
        this.lblThermalValue.Location = new Point(3, 126);
        this.lblThermalValue.Margin = new Padding(3, 6, 3, 0);
        this.lblThermalValue.Name = "lblThermalValue";
        this.lblThermalValue.Padding = new Padding(0, 5, 5, 0);
        this.lblThermalValue.Size = new Size(65, 18);
        this.lblThermalValue.TabIndex = 22;
        this.lblThermalValue.Text = "0";
        this.lblThermalValue.TextAlign = ContentAlignment.MiddleCenter;
        this.lblEMValue.AccessibleName = "EM Sensor Value";
        this.lblEMValue.Location = new Point(3, 150);
        this.lblEMValue.Margin = new Padding(3, 6, 3, 0);
        this.lblEMValue.Name = "lblEMValue";
        this.lblEMValue.Padding = new Padding(0, 5, 5, 0);
        this.lblEMValue.Size = new Size(65, 18);
        this.lblEMValue.TabIndex = 25;
        this.lblEMValue.Text = "0";
        this.lblEMValue.TextAlign = ContentAlignment.MiddleCenter;
        this.lblGeoValue.AccessibleName = "Geo Sensor Value";
        this.lblGeoValue.Location = new Point(3, 174);
        this.lblGeoValue.Margin = new Padding(3, 6, 3, 0);
        this.lblGeoValue.Name = "lblGeoValue";
        this.lblGeoValue.Padding = new Padding(0, 5, 5, 0);
        this.lblGeoValue.Size = new Size(65, 18);
        this.lblGeoValue.TabIndex = 28;
        this.lblGeoValue.Text = "0";
        this.lblGeoValue.TextAlign = ContentAlignment.MiddleCenter;
        this.label20.Location = new Point(3, 198);
        this.label20.Margin = new Padding(3, 6, 3, 0);
        this.label20.Name = "label20";
        this.label20.Padding = new Padding(0, 5, 5, 0);
        this.label20.Size = new Size(65, 18);
        this.label20.TabIndex = 137;
        this.label20.TextAlign = ContentAlignment.MiddleCenter;
        this.label2.Location = new Point(3, 222);
        this.label2.Margin = new Padding(3, 6, 3, 0);
        this.label2.Name = "label2";
        this.label2.Padding = new Padding(0, 5, 5, 0);
        this.label2.Size = new Size(65, 18);
        this.label2.TabIndex = sbyte.MaxValue;
        this.label2.TextAlign = ContentAlignment.MiddleCenter;
        this.label27.Location = new Point(3, 246);
        this.label27.Margin = new Padding(3, 6, 3, 0);
        this.label27.Name = "label27";
        this.label27.Padding = new Padding(0, 5, 5, 0);
        this.label27.Size = new Size(65, 18);
        this.label27.TabIndex = 138;
        this.label27.TextAlign = ContentAlignment.MiddleCenter;
        this.lblECCMValue.AccessibleName = "ECCM Value";
        this.lblECCMValue.Location = new Point(3, 270);
        this.lblECCMValue.Margin = new Padding(3, 6, 3, 0);
        this.lblECCMValue.Name = "lblECCMValue";
        this.lblECCMValue.Padding = new Padding(0, 5, 5, 0);
        this.lblECCMValue.Size = new Size(65, 18);
        this.lblECCMValue.TabIndex = 36;
        this.lblECCMValue.Text = "0";
        this.lblECCMValue.TextAlign = ContentAlignment.MiddleCenter;
        this.lblATGValue.AccessibleName = "Enhanced Radiation Value";
        this.lblATGValue.Location = new Point(3, 294);
        this.lblATGValue.Margin = new Padding(3, 6, 3, 0);
        this.lblATGValue.Name = "lblATGValue";
        this.lblATGValue.Padding = new Padding(0, 5, 5, 0);
        this.lblATGValue.Size = new Size(65, 18);
        this.lblATGValue.TabIndex = 133;
        this.lblATGValue.Text = "0";
        this.lblATGValue.TextAlign = ContentAlignment.MiddleCenter;
        this.label16.Location = new Point(3, 318);
        this.label16.Margin = new Padding(3, 6, 3, 0);
        this.label16.Name = "label16";
        this.label16.Padding = new Padding(0, 5, 5, 0);
        this.label16.Size = new Size(65, 18);
        this.label16.TabIndex = 135;
        this.label16.TextAlign = ContentAlignment.MiddleCenter;
        this.lblLaserWarheadValue.AccessibleName = "Air to air value";
        this.lblLaserWarheadValue.Location = new Point(3, 342);
        this.lblLaserWarheadValue.Margin = new Padding(3, 6, 3, 0);
        this.lblLaserWarheadValue.Name = "lblLaserWarheadValue";
        this.lblLaserWarheadValue.Padding = new Padding(0, 5, 5, 0);
        this.lblLaserWarheadValue.Size = new Size(65, 18);
        this.lblLaserWarheadValue.TabIndex = 134;
        this.lblLaserWarheadValue.Text = "0";
        this.lblLaserWarheadValue.TextAlign = ContentAlignment.MiddleCenter;
        this.label19.Location = new Point(3, 366);
        this.label19.Margin = new Padding(3, 6, 3, 0);
        this.label19.Name = "label19";
        this.label19.Padding = new Padding(0, 5, 5, 0);
        this.label19.Size = new Size(65, 18);
        this.label19.TabIndex = 136;
        this.label19.TextAlign = ContentAlignment.MiddleCenter;
        this.lblShipDecoyBlank.Location = new Point(3, 414);
        this.lblShipDecoyBlank.Margin = new Padding(3, 6, 3, 0);
        this.lblShipDecoyBlank.Name = "lblShipDecoyBlank";
        this.lblShipDecoyBlank.Padding = new Padding(0, 5, 5, 0);
        this.lblShipDecoyBlank.Size = new Size(65, 18);
        this.lblShipDecoyBlank.TabIndex = 139;
        this.lblShipDecoyBlank.TextAlign = ContentAlignment.MiddleCenter;
        this.lblRadiationValue.AccessibleName = "Enhanced Radiation Value";
        this.lblRadiationValue.Location = new Point(3, 438);
        this.lblRadiationValue.Margin = new Padding(3, 6, 3, 0);
        this.lblRadiationValue.Name = "lblRadiationValue";
        this.lblRadiationValue.Padding = new Padding(0, 5, 5, 0);
        this.lblRadiationValue.Size = new Size(65, 18);
        this.lblRadiationValue.TabIndex = 39;
        this.lblRadiationValue.Text = "0";
        this.lblRadiationValue.TextAlign = ContentAlignment.MiddleCenter;
        this.lblBombardmentPodValue.AccessibleName = "Bombardment Value";
        this.lblBombardmentPodValue.Location = new Point(3, 462);
        this.lblBombardmentPodValue.Margin = new Padding(3, 6, 3, 0);
        this.lblBombardmentPodValue.Name = "lblBombardmentPodValue";
        this.lblBombardmentPodValue.Padding = new Padding(0, 5, 5, 0);
        this.lblBombardmentPodValue.Size = new Size(65, 18);
        this.lblBombardmentPodValue.TabIndex = 42;
        this.lblBombardmentPodValue.Text = "0";
        this.lblBombardmentPodValue.TextAlign = ContentAlignment.MiddleCenter;
        this.lblAutocannonPodValue.AccessibleName = "Autocannon Value";
        this.lblAutocannonPodValue.Location = new Point(3, 486);
        this.lblAutocannonPodValue.Margin = new Padding(3, 6, 3, 0);
        this.lblAutocannonPodValue.Name = "lblAutocannonPodValue";
        this.lblAutocannonPodValue.Padding = new Padding(0, 5, 5, 0);
        this.lblAutocannonPodValue.Size = new Size(65, 18);
        this.lblAutocannonPodValue.TabIndex = 45;
        this.lblAutocannonPodValue.Text = "0";
        this.lblAutocannonPodValue.TextAlign = ContentAlignment.MiddleCenter;
        this.lblATAValue.AccessibleName = "Air to air value";
        this.lblATAValue.Location = new Point(3, 510);
        this.lblATAValue.Margin = new Padding(3, 6, 3, 0);
        this.lblATAValue.Name = "lblATAValue";
        this.lblATAValue.Padding = new Padding(0, 5, 5, 0);
        this.lblATAValue.Size = new Size(65, 18);
        this.lblATAValue.TabIndex = 48 /*0x30*/;
        this.lblATAValue.Text = "0";
        this.lblATAValue.TextAlign = ContentAlignment.MiddleCenter;
        this.flowLayoutPanel3.Controls.Add(this.label25);
        this.flowLayoutPanel3.Controls.Add(this.lblWarheadStrength);
        this.flowLayoutPanel3.Controls.Add(this.label6);
        this.flowLayoutPanel3.Controls.Add(this.label8);
        this.flowLayoutPanel3.Controls.Add(this.label9);
        this.flowLayoutPanel3.Controls.Add(this.label10);
        this.flowLayoutPanel3.Controls.Add(this.label11);
        this.flowLayoutPanel3.Controls.Add(this.lblGeo);
        this.flowLayoutPanel3.Controls.Add(this.label17);
        this.flowLayoutPanel3.Controls.Add(this.label22);
        this.flowLayoutPanel3.Controls.Add(this.label1);
        this.flowLayoutPanel3.Controls.Add(this.label18);
        this.flowLayoutPanel3.Controls.Add(this.label7);
        this.flowLayoutPanel3.Controls.Add(this.label12);
        this.flowLayoutPanel3.Controls.Add(this.label14);
        this.flowLayoutPanel3.Controls.Add(this.label15);
        this.flowLayoutPanel3.Controls.Add(this.label26);
        this.flowLayoutPanel3.Controls.Add(this.lblShipDecoy);
        this.flowLayoutPanel3.Controls.Add(this.label21);
        this.flowLayoutPanel3.Controls.Add(this.lblBP);
        this.flowLayoutPanel3.Controls.Add(this.lblAuto);
        this.flowLayoutPanel3.Controls.Add(this.lblATA);
        this.flowLayoutPanel3.Controls.Add(this.label5);
        this.flowLayoutPanel3.FlowDirection = FlowDirection.TopDown;
        this.flowLayoutPanel3.Location = new Point(3, 3);
        this.flowLayoutPanel3.Name = "flowLayoutPanel3";
        this.flowLayoutPanel3.Size = new Size(117, 619);
        this.flowLayoutPanel3.TabIndex = 119;
        this.label25.Location = new Point(3, 6);
        this.label25.Margin = new Padding(3, 6, 3, 0);
        this.label25.Name = "label25";
        this.label25.Padding = new Padding(0, 5, 5, 0);
        this.label25.Size = new Size(65, 18);
        this.label25.TabIndex = 133;
        this.label25.TextAlign = ContentAlignment.MiddleCenter;
        this.lblWarheadStrength.AutoSize = true;
        this.lblWarheadStrength.Location = new Point(3, 30);
        this.lblWarheadStrength.Margin = new Padding(3, 6, 3, 0);
        this.lblWarheadStrength.Name = "lblWarheadStrength";
        this.lblWarheadStrength.Padding = new Padding(0, 5, 5, 0);
        this.lblWarheadStrength.Size = new Size(99, 18);
        this.lblWarheadStrength.TabIndex = 4;
        this.lblWarheadStrength.Text = "Warhead Strength";
        this.lblWarheadStrength.TextAlign = ContentAlignment.MiddleLeft;
        this.label6.AutoSize = true;
        this.label6.Location = new Point(3, 54);
        this.label6.Margin = new Padding(3, 6, 3, 0);
        this.label6.Name = "label6";
        this.label6.Padding = new Padding(0, 5, 5, 0);
        this.label6.Size = new Size(76, 18);
        this.label6.TabIndex = 7;
        this.label6.Text = "Fuel Capacity";
        this.label6.TextAlign = ContentAlignment.MiddleLeft;
        this.label8.AutoSize = true;
        this.label8.Location = new Point(3, 78);
        this.label8.Margin = new Padding(3, 6, 3, 0);
        this.label8.Name = "label8";
        this.label8.Padding = new Padding(0, 5, 5, 0);
        this.label8.Size = new Size(50, 18);
        this.label8.TabIndex = 13;
        this.label8.Text = "Reactor";
        this.label8.TextAlign = ContentAlignment.MiddleLeft;
        this.label9.AutoSize = true;
        this.label9.Location = new Point(3, 102);
        this.label9.Margin = new Padding(3, 6, 3, 0);
        this.label9.Name = "label9";
        this.label9.Padding = new Padding(0, 5, 5, 0);
        this.label9.Size = new Size(78, 18);
        this.label9.TabIndex = 16 /*0x10*/;
        this.label9.Text = "Active Sensor";
        this.label9.TextAlign = ContentAlignment.MiddleLeft;
        this.label10.AutoSize = true;
        this.label10.Location = new Point(3, 126);
        this.label10.Margin = new Padding(3, 6, 3, 0);
        this.label10.Name = "label10";
        this.label10.Padding = new Padding(0, 5, 5, 0);
        this.label10.Size = new Size(86, 18);
        this.label10.TabIndex = 20;
        this.label10.Text = "Thermal Sensor";
        this.label10.TextAlign = ContentAlignment.MiddleLeft;
        this.label11.AutoSize = true;
        this.label11.Location = new Point(3, 150);
        this.label11.Margin = new Padding(3, 6, 3, 0);
        this.label11.Name = "label11";
        this.label11.Padding = new Padding(0, 5, 5, 0);
        this.label11.Size = new Size(64 /*0x40*/, 18);
        this.label11.TabIndex = 23;
        this.label11.Text = "EM Sensor";
        this.label11.TextAlign = ContentAlignment.MiddleLeft;
        this.lblGeo.AutoSize = true;
        this.lblGeo.Location = new Point(3, 174);
        this.lblGeo.Margin = new Padding(3, 6, 3, 0);
        this.lblGeo.Name = "lblGeo";
        this.lblGeo.Padding = new Padding(0, 5, 5, 0);
        this.lblGeo.Size = new Size(68, 18);
        this.lblGeo.TabIndex = 26;
        this.lblGeo.Text = "Geo Sensor";
        this.lblGeo.TextAlign = ContentAlignment.MiddleLeft;
        this.label17.AutoSize = true;
        this.label17.Location = new Point(3, 198);
        this.label17.Margin = new Padding(3, 6, 3, 0);
        this.label17.Name = "label17";
        this.label17.Padding = new Padding(0, 5, 5, 0);
        this.label17.Size = new Size(82, 18);
        this.label17.TabIndex = 138;
        this.label17.Text = "Missile Decoys";
        this.label17.TextAlign = ContentAlignment.MiddleLeft;
        this.label22.AutoSize = true;
        this.label22.Location = new Point(3, 222);
        this.label22.Margin = new Padding(3, 6, 3, 0);
        this.label22.Name = "label22";
        this.label22.Padding = new Padding(0, 5, 5, 0);
        this.label22.Size = new Size(100, 18);
        this.label22.TabIndex = 139;
        this.label22.Text = "Multiple Warheads";
        this.label22.TextAlign = ContentAlignment.MiddleLeft;
        this.label1.AutoSize = true;
        this.label1.Location = new Point(3, 246);
        this.label1.Margin = new Padding(3, 6, 3, 0);
        this.label1.Name = "label1";
        this.label1.Padding = new Padding(0, 5, 5, 0);
        this.label1.Size = new Size(95, 18);
        this.label1.TabIndex = 29;
        this.label1.Text = "Active Resolution";
        this.label1.TextAlign = ContentAlignment.MiddleLeft;
        this.label18.AutoSize = true;
        this.label18.Location = new Point(3, 270);
        this.label18.Margin = new Padding(3, 6, 3, 0);
        this.label18.Name = "label18";
        this.label18.Padding = new Padding(0, 5, 5, 0);
        this.label18.Size = new Size(42, 18);
        this.label18.TabIndex = 34;
        this.label18.Text = "ECCM";
        this.label18.TextAlign = ContentAlignment.MiddleLeft;
        this.label7.AutoSize = true;
        this.label7.Location = new Point(3, 294);
        this.label7.Margin = new Padding(3, 6, 3, 0);
        this.label7.Name = "label7";
        this.label7.Padding = new Padding(0, 5, 5, 0);
        this.label7.Size = new Size(101, 18);
        this.label7.TabIndex = 134;
        this.label7.Text = "Terminal Guidance";
        this.label7.TextAlign = ContentAlignment.MiddleLeft;
        this.label12.AutoSize = true;
        this.label12.Location = new Point(3, 318);
        this.label12.Margin = new Padding(3, 6, 3, 0);
        this.label12.Name = "label12";
        this.label12.Padding = new Padding(0, 5, 5, 0);
        this.label12.Size = new Size(101, 18);
        this.label12.TabIndex = 135;
        this.label12.Text = "Retarget Capability";
        this.label12.TextAlign = ContentAlignment.MiddleLeft;
        this.label14.AutoSize = true;
        this.label14.Location = new Point(3, 342);
        this.label14.Margin = new Padding(3, 6, 3, 0);
        this.label14.Name = "label14";
        this.label14.Padding = new Padding(0, 5, 5, 0);
        this.label14.Size = new Size(85, 18);
        this.label14.TabIndex = 136;
        this.label14.Text = "Laser Warhead";
        this.label14.TextAlign = ContentAlignment.MiddleLeft;
        this.label15.AutoSize = true;
        this.label15.Location = new Point(3, 366);
        this.label15.Margin = new Padding(3, 6, 3, 0);
        this.label15.Name = "label15";
        this.label15.Padding = new Padding(0, 5, 5, 0);
        this.label15.Size = new Size(99, 18);
        this.label15.TabIndex = 137;
        this.label15.Text = "Min Deton. Range";
        this.label15.TextAlign = ContentAlignment.MiddleLeft;
        this.lblShipDecoy.AutoSize = true;
        this.lblShipDecoy.Location = new Point(3, 414);
        this.lblShipDecoy.Margin = new Padding(3, 6, 3, 0);
        this.lblShipDecoy.Name = "lblShipDecoy";
        this.lblShipDecoy.Padding = new Padding(0, 5, 5, 0);
        this.lblShipDecoy.Size = new Size(77, 18);
        this.lblShipDecoy.TabIndex = 140;
        this.lblShipDecoy.Text = "Decoy Missile";
        this.lblShipDecoy.TextAlign = ContentAlignment.MiddleLeft;
        this.label21.AutoSize = true;
        this.label21.Location = new Point(3, 438);
        this.label21.Margin = new Padding(3, 6, 3, 0);
        this.label21.Name = "label21";
        this.label21.Padding = new Padding(0, 5, 5, 0);
        this.label21.Size = new Size(109, 18);
        this.label21.TabIndex = 37;
        this.label21.Text = "Enhanced Radiation";
        this.label21.TextAlign = ContentAlignment.MiddleLeft;
        this.lblBP.AutoSize = true;
        this.lblBP.Location = new Point(3, 462);
        this.lblBP.Margin = new Padding(3, 6, 3, 0);
        this.lblBP.Name = "lblBP";
        this.lblBP.Padding = new Padding(0, 5, 5, 0);
        this.lblBP.Size = new Size(99, 18);
        this.lblBP.TabIndex = 40;
        this.lblBP.Text = "Bombardment Pod";
        this.lblBP.TextAlign = ContentAlignment.MiddleLeft;
        this.lblAuto.AutoSize = true;
        this.lblAuto.Location = new Point(3, 486);
        this.lblAuto.Margin = new Padding(3, 6, 3, 0);
        this.lblAuto.Name = "lblAuto";
        this.lblAuto.Padding = new Padding(0, 5, 5, 0);
        this.lblAuto.Size = new Size(92, 18);
        this.lblAuto.TabIndex = 43;
        this.lblAuto.Text = "Autocannon Pod";
        this.lblAuto.TextAlign = ContentAlignment.MiddleLeft;
        this.lblATA.AutoSize = true;
        this.lblATA.Location = new Point(3, 510);
        this.lblATA.Margin = new Padding(3, 6, 3, 0);
        this.lblATA.Name = "lblATA";
        this.lblATA.Padding = new Padding(0, 5, 5, 0);
        this.lblATA.Size = new Size(77, 18);
        this.lblATA.TabIndex = 46;
        this.lblATA.Text = "Air-To-Air Pod";
        this.lblATA.TextAlign = ContentAlignment.MiddleLeft;
        this.label5.AutoSize = true;
        this.label5.Location = new Point(3, 534);
        this.label5.Margin = new Padding(3, 6, 3, 0);
        this.label5.Name = "label5";
        this.label5.Padding = new Padding(0, 5, 5, 0);
        this.label5.Size = new Size(62, 18);
        this.label5.TabIndex = 49;
        this.label5.Text = "No Engine";
        this.label5.TextAlign = ContentAlignment.MiddleLeft;
        this.flowLayoutPanel4.BorderStyle = BorderStyle.FixedSingle;
        this.flowLayoutPanel4.Controls.Add(this.flowLayoutPanel3);
        this.flowLayoutPanel4.Controls.Add(this.flowLayoutPanel1);
        this.flowLayoutPanel4.Controls.Add(this.flowLayoutPanel2);
        this.flowLayoutPanel4.Location = new Point(3, 30);
        this.flowLayoutPanel4.Name = "flowLayoutPanel4";
        this.flowLayoutPanel4.Size = new Size(292, 638);
        this.flowLayoutPanel4.TabIndex = 120;
        this.flowLayoutPanel5.Controls.Add(this.cboEnginePower);
        this.flowLayoutPanel5.Location = new Point(3, 3);
        this.flowLayoutPanel5.Margin = new Padding(3, 3, 3, 0);
        this.flowLayoutPanel5.Name = "flowLayoutPanel5";
        this.flowLayoutPanel5.Size = new Size(350, 29);
        this.flowLayoutPanel5.TabIndex = 121;
        this.cboEnginePower.AccessibleDescription = "Select engine power / fuel consumption tradeoff";
        this.cboEnginePower.AccessibleName = "Engine Power";
        this.cboEnginePower.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cboEnginePower.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.cboEnginePower.FormattingEnabled = true;
        this.cboEnginePower.Location = new Point(3, 3);
        this.cboEnginePower.Margin = new Padding(3, 3, 3, 0);
        this.cboEnginePower.Name = "cboEnginePower";
        this.cboEnginePower.Size = new Size(335, 21);
        this.cboEnginePower.TabIndex = 51;
        this.cboEnginePower.SelectedIndexChanged += this.cboEngineSize_SelectedIndexChanged;
        this.flowLayoutPanel6.BorderStyle = BorderStyle.FixedSingle;
        this.flowLayoutPanel6.Controls.Add(this.flowLayoutPanel5);
        this.flowLayoutPanel6.Controls.Add(this.flowLayoutPanel14);
        this.flowLayoutPanel6.Controls.Add(this.flowLayoutPanel7);
        this.flowLayoutPanel6.Controls.Add(this.flowLayoutPanel8);
        this.flowLayoutPanel6.Location = new Point(301, 30);
        this.flowLayoutPanel6.Name = "flowLayoutPanel6";
        this.flowLayoutPanel6.Size = new Size(354, 128 /*0x80*/);
        this.flowLayoutPanel6.TabIndex = 122;
        this.flowLayoutPanel14.Controls.Add(this.cboEngineSize);
        this.flowLayoutPanel14.Location = new Point(3, 35);
        this.flowLayoutPanel14.Margin = new Padding(3, 3, 3, 0);
        this.flowLayoutPanel14.Name = "flowLayoutPanel14";
        this.flowLayoutPanel14.Size = new Size(350, 29);
        this.flowLayoutPanel14.TabIndex = 125;
        this.cboEngineSize.AccessibleName = "Engine Size";
        this.cboEngineSize.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cboEngineSize.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.cboEngineSize.FormattingEnabled = true;
        this.cboEngineSize.Location = new Point(3, 3);
        this.cboEngineSize.Margin = new Padding(3, 3, 3, 0);
        this.cboEngineSize.Name = "cboEngineSize";
        this.cboEngineSize.Size = new Size(335, 21);
        this.cboEngineSize.TabIndex = 52;
        this.cboEngineSize.SelectedIndexChanged += this.cboEngineSize_SelectedIndexChanged;
        this.flowLayoutPanel7.Controls.Add(this.label28);
        this.flowLayoutPanel7.Controls.Add(this.lblTotalEnginePower);
        this.flowLayoutPanel7.Controls.Add(this.label31);
        this.flowLayoutPanel7.Controls.Add(this.lblTotalEngineCost);
        this.flowLayoutPanel7.Location = new Point(3, 67);
        this.flowLayoutPanel7.Margin = new Padding(3, 3, 3, 0);
        this.flowLayoutPanel7.Name = "flowLayoutPanel7";
        this.flowLayoutPanel7.Size = new Size(350, 28);
        this.flowLayoutPanel7.TabIndex = 123;
        this.label28.Location = new Point(3, 3);
        this.label28.Margin = new Padding(3, 3, 3, 0);
        this.label28.Name = "label28";
        this.label28.Padding = new Padding(0, 5, 5, 0);
        this.label28.Size = new Size(85, 18);
        this.label28.TabIndex = 53;
        this.label28.Text = "Engine Power";
        this.label28.TextAlign = ContentAlignment.MiddleLeft;
        this.lblTotalEnginePower.AccessibleName = "Engine Power";
        this.lblTotalEnginePower.Location = new Point(94, 3);
        this.lblTotalEnginePower.Margin = new Padding(3, 3, 3, 0);
        this.lblTotalEnginePower.Name = "lblTotalEnginePower";
        this.lblTotalEnginePower.Padding = new Padding(0, 5, 5, 0);
        this.lblTotalEnginePower.Size = new Size(47, 18);
        this.lblTotalEnginePower.TabIndex = 54;
        this.lblTotalEnginePower.Text = "100";
        this.lblTotalEnginePower.TextAlign = ContentAlignment.MiddleCenter;
        this.label31.Location = new Point(153, 3);
        this.label31.Margin = new Padding(9, 3, 3, 0);
        this.label31.Name = "label31";
        this.label31.Padding = new Padding(0, 5, 5, 0);
        this.label31.Size = new Size(115, 18);
        this.label31.TabIndex = 55;
        this.label31.Text = "Total Engine Cost";
        this.label31.TextAlign = ContentAlignment.MiddleLeft;
        this.lblTotalEngineCost.AccessibleName = "Engine Cost";
        this.lblTotalEngineCost.Location = new Point(274, 3);
        this.lblTotalEngineCost.Margin = new Padding(3, 3, 3, 0);
        this.lblTotalEngineCost.Name = "lblTotalEngineCost";
        this.lblTotalEngineCost.Padding = new Padding(0, 5, 5, 0);
        this.lblTotalEngineCost.Size = new Size(70, 18);
        this.lblTotalEngineCost.TabIndex = 56;
        this.lblTotalEngineCost.Text = "100";
        this.lblTotalEngineCost.TextAlign = ContentAlignment.MiddleCenter;
        this.flowLayoutPanel8.Controls.Add(this.label4);
        this.flowLayoutPanel8.Controls.Add(this.lblFuelEfficiency);
        this.flowLayoutPanel8.Controls.Add(this.label13);
        this.flowLayoutPanel8.Controls.Add(this.lblFuelEPH);
        this.flowLayoutPanel8.Location = new Point(3, 98);
        this.flowLayoutPanel8.Margin = new Padding(3, 3, 3, 0);
        this.flowLayoutPanel8.Name = "flowLayoutPanel8";
        this.flowLayoutPanel8.Size = new Size(350, 28);
        this.flowLayoutPanel8.TabIndex = 126;
        this.label4.Location = new Point(3, 3);
        this.label4.Margin = new Padding(3, 3, 3, 0);
        this.label4.Name = "label4";
        this.label4.Padding = new Padding(0, 5, 5, 0);
        this.label4.Size = new Size(85, 18);
        this.label4.TabIndex = 57;
        this.label4.Text = "Fuel Efficiency";
        this.label4.TextAlign = ContentAlignment.MiddleLeft;
        this.lblFuelEfficiency.AccessibleName = "Fuel Efficiency";
        this.lblFuelEfficiency.Location = new Point(94, 3);
        this.lblFuelEfficiency.Margin = new Padding(3, 3, 3, 0);
        this.lblFuelEfficiency.Name = "lblFuelEfficiency";
        this.lblFuelEfficiency.Padding = new Padding(0, 5, 5, 0);
        this.lblFuelEfficiency.Size = new Size(47, 18);
        this.lblFuelEfficiency.TabIndex = 58;
        this.lblFuelEfficiency.Text = "100";
        this.lblFuelEfficiency.TextAlign = ContentAlignment.MiddleCenter;
        this.label13.Location = new Point(153, 3);
        this.label13.Margin = new Padding(9, 3, 3, 0);
        this.label13.Name = "label13";
        this.label13.Padding = new Padding(0, 5, 5, 0);
        this.label13.Size = new Size(115, 18);
        this.label13.TabIndex = 59;
        this.label13.Text = "Fuel per EPH";
        this.label13.TextAlign = ContentAlignment.MiddleLeft;
        this.lblFuelEPH.AccessibleName = "Fuel per EPH";
        this.lblFuelEPH.Location = new Point(274, 3);
        this.lblFuelEPH.Margin = new Padding(3, 3, 3, 0);
        this.lblFuelEPH.Name = "lblFuelEPH";
        this.lblFuelEPH.Padding = new Padding(0, 5, 5, 0);
        this.lblFuelEPH.Size = new Size(70, 18);
        this.lblFuelEPH.TabIndex = 60;
        this.lblFuelEPH.Text = "100";
        this.lblFuelEPH.TextAlign = ContentAlignment.MiddleCenter;
        this.flowLayoutPanel9.BorderStyle = BorderStyle.FixedSingle;
        this.flowLayoutPanel9.Controls.Add(this.flowLayoutPanel10);
        this.flowLayoutPanel9.Controls.Add(this.flowLayoutPanel11);
        this.flowLayoutPanel9.Controls.Add(this.flowLayoutPanel12);
        this.flowLayoutPanel9.Controls.Add(this.flowLayoutPanel13);
        this.flowLayoutPanel9.Location = new Point(301, 163);
        this.flowLayoutPanel9.Name = "flowLayoutPanel9";
        this.flowLayoutPanel9.Size = new Size(354, sbyte.MaxValue);
        this.flowLayoutPanel9.TabIndex = 123;
        this.flowLayoutPanel10.Controls.Add(this.label34);
        this.flowLayoutPanel10.Controls.Add(this.cboSecond);
        this.flowLayoutPanel10.Location = new Point(3, 3);
        this.flowLayoutPanel10.Margin = new Padding(3, 3, 3, 0);
        this.flowLayoutPanel10.Name = "flowLayoutPanel10";
        this.flowLayoutPanel10.Size = new Size(350, 29);
        this.flowLayoutPanel10.TabIndex = 121;
        this.label34.Location = new Point(3, 3);
        this.label34.Margin = new Padding(3, 3, 3, 0);
        this.label34.Name = "label34";
        this.label34.Padding = new Padding(0, 5, 5, 0);
        this.label34.Size = new Size(80 /*0x50*/, 18);
        this.label34.TabIndex = 118;
        this.label34.Text = "Second Stage";
        this.label34.TextAlign = ContentAlignment.MiddleLeft;
        this.cboSecond.AccessibleName = "Second Stage Missile";
        this.cboSecond.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cboSecond.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.cboSecond.FormattingEnabled = true;
        this.cboSecond.Location = new Point(89, 3);
        this.cboSecond.Margin = new Padding(3, 3, 3, 0);
        this.cboSecond.Name = "cboSecond";
        this.cboSecond.Size = new Size(249, 21);
        this.cboSecond.TabIndex = 61;
        this.cboSecond.SelectedIndexChanged += this.cboSecond_SelectedIndexChanged;
        this.flowLayoutPanel11.Controls.Add(this.label35);
        this.flowLayoutPanel11.Controls.Add(this.txtNumSS);
        this.flowLayoutPanel11.Controls.Add(this.label36);
        this.flowLayoutPanel11.Controls.Add(this.txtSeparationRange);
        this.flowLayoutPanel11.Location = new Point(3, 35);
        this.flowLayoutPanel11.Margin = new Padding(3, 3, 3, 0);
        this.flowLayoutPanel11.Name = "flowLayoutPanel11";
        this.flowLayoutPanel11.Size = new Size(350, 28);
        this.flowLayoutPanel11.TabIndex = 123;
        this.label35.Location = new Point(3, 3);
        this.label35.Margin = new Padding(3, 3, 3, 0);
        this.label35.Name = "label35";
        this.label35.Padding = new Padding(0, 5, 5, 0);
        this.label35.Size = new Size(75, 18);
        this.label35.TabIndex = 62;
        this.label35.Text = "Number";
        this.label35.TextAlign = ContentAlignment.MiddleLeft;
        this.txtNumSS.AccessibleName = "Number of Second Stage missiles";
        this.txtNumSS.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtNumSS.BorderStyle = BorderStyle.None;
        this.txtNumSS.ForeColor = Color.FromArgb(128 /*0x80*/, byte.MaxValue, 128 /*0x80*/);
        this.txtNumSS.Location = new Point(84, 7);
        this.txtNumSS.Margin = new Padding(3, 7, 3, 0);
        this.txtNumSS.Name = "txtNumSS";
        this.txtNumSS.Size = new Size(53, 13);
        this.txtNumSS.TabIndex = 63 /*0x3F*/;
        this.txtNumSS.Text = "0";
        this.txtNumSS.TextAlign = HorizontalAlignment.Center;
        this.txtNumSS.TextChanged += this.txtMaxDetonationRange_TextChanged;
        this.label36.Location = new Point(152, 3);
        this.label36.Margin = new Padding(12, 3, 3, 0);
        this.label36.Name = "label36";
        this.label36.Padding = new Padding(0, 5, 5, 0);
        this.label36.Size = new Size(115, 18);
        this.label36.TabIndex = 64 /*0x40*/;
        this.label36.Text = "Separation Range (k)";
        this.label36.TextAlign = ContentAlignment.MiddleLeft;
        this.txtSeparationRange.AccessibleName = "Separation Range";
        this.txtSeparationRange.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtSeparationRange.BorderStyle = BorderStyle.None;
        this.txtSeparationRange.ForeColor = Color.FromArgb(128 /*0x80*/, byte.MaxValue, 128 /*0x80*/);
        this.txtSeparationRange.Location = new Point(273, 7);
        this.txtSeparationRange.Margin = new Padding(3, 7, 3, 0);
        this.txtSeparationRange.Name = "txtSeparationRange";
        this.txtSeparationRange.Size = new Size(65, 13);
        this.txtSeparationRange.TabIndex = 65;
        this.txtSeparationRange.Text = "150";
        this.txtSeparationRange.TextAlign = HorizontalAlignment.Center;
        this.txtSeparationRange.TextChanged += this.txtMaxDetonationRange_TextChanged;
        this.flowLayoutPanel12.Controls.Add(this.label38);
        this.flowLayoutPanel12.Controls.Add(this.lblSecondStageMissileSize);
        this.flowLayoutPanel12.Controls.Add(this.label40);
        this.flowLayoutPanel12.Controls.Add(this.lblSecondStageMissileCost);
        this.flowLayoutPanel12.Location = new Point(3, 66);
        this.flowLayoutPanel12.Margin = new Padding(3, 3, 3, 0);
        this.flowLayoutPanel12.Name = "flowLayoutPanel12";
        this.flowLayoutPanel12.Size = new Size(350, 28);
        this.flowLayoutPanel12.TabIndex = 124;
        this.label38.Location = new Point(3, 3);
        this.label38.Margin = new Padding(3, 3, 3, 0);
        this.label38.Name = "label38";
        this.label38.Padding = new Padding(0, 5, 5, 0);
        this.label38.Size = new Size(80 /*0x50*/, 18);
        this.label38.TabIndex = 66;
        this.label38.Text = "Missile Size";
        this.label38.TextAlign = ContentAlignment.MiddleLeft;
        this.lblSecondStageMissileSize.AccessibleName = "Second Stage Missile Size";
        this.lblSecondStageMissileSize.Location = new Point(89, 3);
        this.lblSecondStageMissileSize.Margin = new Padding(3, 3, 3, 0);
        this.lblSecondStageMissileSize.Name = "lblSecondStageMissileSize";
        this.lblSecondStageMissileSize.Padding = new Padding(0, 5, 5, 0);
        this.lblSecondStageMissileSize.Size = new Size(48 /*0x30*/, 18);
        this.lblSecondStageMissileSize.TabIndex = 67;
        this.lblSecondStageMissileSize.Text = "0";
        this.lblSecondStageMissileSize.TextAlign = ContentAlignment.MiddleCenter;
        this.label40.Location = new Point(152, 3);
        this.label40.Margin = new Padding(12, 3, 3, 0);
        this.label40.Name = "label40";
        this.label40.Padding = new Padding(0, 5, 5, 0);
        this.label40.Size = new Size(115, 18);
        this.label40.TabIndex = 68;
        this.label40.Text = "Missile Cost";
        this.label40.TextAlign = ContentAlignment.MiddleLeft;
        this.lblSecondStageMissileCost.AccessibleName = "Second Stage Missile Cost";
        this.lblSecondStageMissileCost.Location = new Point(273, 3);
        this.lblSecondStageMissileCost.Margin = new Padding(3, 3, 3, 0);
        this.lblSecondStageMissileCost.Name = "lblSecondStageMissileCost";
        this.lblSecondStageMissileCost.Padding = new Padding(0, 5, 5, 0);
        this.lblSecondStageMissileCost.Size = new Size(70, 18);
        this.lblSecondStageMissileCost.TabIndex = 69;
        this.lblSecondStageMissileCost.Text = "0";
        this.lblSecondStageMissileCost.TextAlign = ContentAlignment.MiddleCenter;
        this.flowLayoutPanel13.Controls.Add(this.label37);
        this.flowLayoutPanel13.Controls.Add(this.lblSecondStageTotalSize);
        this.flowLayoutPanel13.Controls.Add(this.label43);
        this.flowLayoutPanel13.Controls.Add(this.lblSecondStageTotalCost);
        this.flowLayoutPanel13.Location = new Point(3, 97);
        this.flowLayoutPanel13.Margin = new Padding(3, 3, 3, 0);
        this.flowLayoutPanel13.Name = "flowLayoutPanel13";
        this.flowLayoutPanel13.Size = new Size(350, 28);
        this.flowLayoutPanel13.TabIndex = 125;
        this.label37.Location = new Point(3, 3);
        this.label37.Margin = new Padding(3, 3, 3, 0);
        this.label37.Name = "label37";
        this.label37.Padding = new Padding(0, 5, 5, 0);
        this.label37.Size = new Size(80 /*0x50*/, 18);
        this.label37.TabIndex = 70;
        this.label37.Text = "Total Size";
        this.label37.TextAlign = ContentAlignment.MiddleLeft;
        this.lblSecondStageTotalSize.AccessibleName = "Total Second Stage Size";
        this.lblSecondStageTotalSize.Location = new Point(89, 3);
        this.lblSecondStageTotalSize.Margin = new Padding(3, 3, 3, 0);
        this.lblSecondStageTotalSize.Name = "lblSecondStageTotalSize";
        this.lblSecondStageTotalSize.Padding = new Padding(0, 5, 5, 0);
        this.lblSecondStageTotalSize.Size = new Size(48 /*0x30*/, 18);
        this.lblSecondStageTotalSize.TabIndex = 71;
        this.lblSecondStageTotalSize.Text = "0";
        this.lblSecondStageTotalSize.TextAlign = ContentAlignment.MiddleCenter;
        this.label43.Location = new Point(152, 3);
        this.label43.Margin = new Padding(12, 3, 3, 0);
        this.label43.Name = "label43";
        this.label43.Padding = new Padding(0, 5, 5, 0);
        this.label43.Size = new Size(115, 18);
        this.label43.TabIndex = 72;
        this.label43.Text = "Total Cost";
        this.label43.TextAlign = ContentAlignment.MiddleLeft;
        this.lblSecondStageTotalCost.AccessibleName = "Total Second Stage Cost";
        this.lblSecondStageTotalCost.Location = new Point(273, 3);
        this.lblSecondStageTotalCost.Margin = new Padding(3, 3, 3, 0);
        this.lblSecondStageTotalCost.Name = "lblSecondStageTotalCost";
        this.lblSecondStageTotalCost.Padding = new Padding(0, 5, 5, 0);
        this.lblSecondStageTotalCost.Size = new Size(70, 18);
        this.lblSecondStageTotalCost.TabIndex = 73;
        this.lblSecondStageTotalCost.Text = "0";
        this.lblSecondStageTotalCost.TextAlign = ContentAlignment.MiddleCenter;
        this.lstvMissileTech.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.lstvMissileTech.BorderStyle = BorderStyle.FixedSingle;
        this.lstvMissileTech.Columns.AddRange(new ColumnHeader[2]
        {
            this.columnHeader_0,
            this.columnHeader_1
        });
        this.lstvMissileTech.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.lstvMissileTech.FullRowSelect = true;
        this.lstvMissileTech.HeaderStyle = ColumnHeaderStyle.None;
        this.lstvMissileTech.HideSelection = false;
        this.lstvMissileTech.Location = new Point(661, 30);
        this.lstvMissileTech.Name = "lstvMissileTech";
        this.lstvMissileTech.Size = new Size(348, 382);
        this.lstvMissileTech.TabIndex = 125;
        this.lstvMissileTech.UseCompatibleStateImageBehavior = false;
        this.lstvMissileTech.View = View.Details;
        this.columnHeader_0.Width = 200;
        this.columnHeader_1.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_1.Width = 125;
        this.txtMissileSummary.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtMissileSummary.BorderStyle = BorderStyle.FixedSingle;
        this.txtMissileSummary.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.txtMissileSummary.Location = new Point(301, 444);
        this.txtMissileSummary.Multiline = true;
        this.txtMissileSummary.Name = "txtMissileSummary";
        this.txtMissileSummary.Size = new Size(708, 224 /*0xE0*/);
        this.txtMissileSummary.TabIndex = 126;
        this.txtMissileSummary.TextChanged += this.txtMissileSummary_TextChanged;
        this.txtMissileName.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtMissileName.BorderStyle = BorderStyle.FixedSingle;
        this.txtMissileName.ForeColor = Color.FromArgb(128 /*0x80*/, byte.MaxValue, 128 /*0x80*/);
        this.txtMissileName.Location = new Point(301, 418);
        this.txtMissileName.Name = "txtMissileName";
        this.txtMissileName.Size = new Size(354, 20);
        this.txtMissileName.TabIndex = 128 /*0x80*/;
        this.txtCompanyName.AccessibleName = "Company Name";
        this.txtCompanyName.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtCompanyName.BorderStyle = BorderStyle.FixedSingle;
        this.txtCompanyName.ForeColor = Color.FromArgb(128 /*0x80*/, byte.MaxValue, 128 /*0x80*/);
        this.txtCompanyName.Location = new Point(661, 418);
        this.txtCompanyName.Name = "txtCompanyName";
        this.txtCompanyName.Size = new Size(348, 20);
        this.txtCompanyName.TabIndex = sbyte.MaxValue;
        this.cmdCompanyName.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdCompanyName.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.cmdCompanyName.Location = new Point(199, 671);
        this.cmdCompanyName.Margin = new Padding(0);
        this.cmdCompanyName.Name = "cmdCompanyName";
        this.cmdCompanyName.Size = new Size(96 /*0x60*/, 30);
        this.cmdCompanyName.TabIndex = 76;
        this.cmdCompanyName.Tag = "1200";
        this.cmdCompanyName.Text = "Company Name";
        this.cmdCompanyName.UseVisualStyleBackColor = false;
        this.cmdCompanyName.Click += this.cmdCompanyName_Click;
        this.chkFreezeName.AccessibleName = "Freeze Name";
        this.chkFreezeName.CheckAlign = ContentAlignment.MiddleRight;
        this.chkFreezeName.Location = new Point(916, 3);
        this.chkFreezeName.Margin = new Padding(6, 7, 3, 0);
        this.chkFreezeName.Name = "chkFreezeName";
        this.chkFreezeName.Padding = new Padding(0, 5, 5, 0);
        this.chkFreezeName.Size = new Size(94, 21);
        this.chkFreezeName.TabIndex = 3;
        this.chkFreezeName.Text = "Freeze Name";
        this.chkFreezeName.UseVisualStyleBackColor = true;
        this.cmdInstant.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdInstant.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.cmdInstant.Location = new Point(103, 671);
        this.cmdInstant.Margin = new Padding(0);
        this.cmdInstant.Name = "cmdInstant";
        this.cmdInstant.Size = new Size(96 /*0x60*/, 30);
        this.cmdInstant.TabIndex = 75;
        this.cmdInstant.Tag = "1200";
        this.cmdInstant.Text = "Instant";
        this.cmdInstant.UseVisualStyleBackColor = false;
        this.cmdInstant.Click += this.cmdInstant_Click;
        this.cmdCreate.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdCreate.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.cmdCreate.Location = new Point(7, 671);
        this.cmdCreate.Margin = new Padding(0);
        this.cmdCreate.Name = "cmdCreate";
        this.cmdCreate.Size = new Size(96 /*0x60*/, 30);
        this.cmdCreate.TabIndex = 74;
        this.cmdCreate.Tag = "1200";
        this.cmdCreate.Text = "Create";
        this.cmdCreate.UseVisualStyleBackColor = false;
        this.cmdCreate.Click += this.cmdCreate_Click;
        this.cboPreviousDesigns.AccessibleDescription =
            "Used to populate all the fields using a previously designed missile";
        this.cboPreviousDesigns.AccessibleName = "Select Previous Design";
        this.cboPreviousDesigns.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cboPreviousDesigns.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.cboPreviousDesigns.FormattingEnabled = true;
        this.cboPreviousDesigns.Location = new Point(394, 3);
        this.cboPreviousDesigns.Margin = new Padding(3, 3, 3, 0);
        this.cboPreviousDesigns.Name = "cboPreviousDesigns";
        this.cboPreviousDesigns.Size = new Size(249, 21);
        this.cboPreviousDesigns.TabIndex = 2;
        this.cboPreviousDesigns.SelectedIndexChanged += this.cboPreviousDesigns_SelectedIndexChanged;
        this.label3.Location = new Point(308, 3);
        this.label3.Margin = new Padding(3, 3, 3, 0);
        this.label3.Name = "label3";
        this.label3.Padding = new Padding(0, 5, 5, 0);
        this.label3.Size = new Size(80 /*0x50*/, 18);
        this.label3.TabIndex = 135;
        this.label3.Text = "Load Previous";
        this.label3.TextAlign = ContentAlignment.MiddleLeft;
        this.label26.AutoSize = true;
        this.label26.Location = new Point(3, 390);
        this.label26.Margin = new Padding(3, 6, 3, 0);
        this.label26.Name = "label26";
        this.label26.Padding = new Padding(0, 5, 5, 0);
        this.label26.Size = new Size(102, 18);
        this.label26.TabIndex = 141;
        this.label26.Text = "Max Deton. Range";
        this.label26.TextAlign = ContentAlignment.MiddleLeft;
        this.txtMaxDetonationRange.AccessibleName = "Active Resolution";
        this.txtMaxDetonationRange.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtMaxDetonationRange.BorderStyle = BorderStyle.None;
        this.txtMaxDetonationRange.ForeColor = Color.FromArgb(128 /*0x80*/, byte.MaxValue, 128 /*0x80*/);
        this.txtMaxDetonationRange.Location = new Point(3, 395);
        this.txtMaxDetonationRange.Margin = new Padding(3, 11, 3, 0);
        this.txtMaxDetonationRange.Name = "txtMaxDetonationRange";
        this.txtMaxDetonationRange.Size = new Size(65, 13);
        this.txtMaxDetonationRange.TabIndex = 142;
        this.txtMaxDetonationRange.Text = "0";
        this.txtMaxDetonationRange.TextAlign = HorizontalAlignment.Center;
        this.txtMaxDetonationRange.TextChanged += this.txtMaxDetonationRange_TextChanged;
        this.label29.Location = new Point(3, 390);
        this.label29.Margin = new Padding(3, 6, 3, 0);
        this.label29.Name = "label29";
        this.label29.Padding = new Padding(0, 5, 5, 0);
        this.label29.Size = new Size(65, 18);
        this.label29.TabIndex = 142;
        this.label29.TextAlign = ContentAlignment.MiddleCenter;
        this.AutoScaleDimensions = new SizeF(6f, 13f);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.ClientSize = new Size(1016, 710);
        this.Controls.Add(this.label3);
        this.Controls.Add(this.cboPreviousDesigns);
        this.Controls.Add(this.cmdInstant);
        this.Controls.Add(this.cmdCreate);
        this.Controls.Add(this.chkFreezeName);
        this.Controls.Add(this.cmdCompanyName);
        this.Controls.Add(this.txtMissileName);
        this.Controls.Add(this.txtCompanyName);
        this.Controls.Add(this.txtMissileSummary);
        this.Controls.Add(this.lstvMissileTech);
        this.Controls.Add(this.flowLayoutPanel9);
        this.Controls.Add(this.flowLayoutPanel6);
        this.Controls.Add(this.flowLayoutPanel4);
        this.Controls.Add(this.cboRaces);
        this.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.FormBorderStyle = FormBorderStyle.FixedSingle;
        this.KeyPreview = true;
        this.Name = nameof(MissileDesign);
        this.Text = "Missile Design";
        this.FormClosing += this.MissileDesign_FormClosing;
        this.Load += this.MissileDesign_Load;
        this.KeyDown += this.MissileDesign_KeyDown;
        this.flowLayoutPanel1.ResumeLayout(false);
        this.flowLayoutPanel1.PerformLayout();
        this.flowLayoutPanel2.ResumeLayout(false);
        this.flowLayoutPanel3.ResumeLayout(false);
        this.flowLayoutPanel3.PerformLayout();
        this.flowLayoutPanel4.ResumeLayout(false);
        this.flowLayoutPanel5.ResumeLayout(false);
        this.flowLayoutPanel6.ResumeLayout(false);
        this.flowLayoutPanel14.ResumeLayout(false);
        this.flowLayoutPanel7.ResumeLayout(false);
        this.flowLayoutPanel8.ResumeLayout(false);
        this.flowLayoutPanel9.ResumeLayout(false);
        this.flowLayoutPanel10.ResumeLayout(false);
        this.flowLayoutPanel11.ResumeLayout(false);
        this.flowLayoutPanel11.PerformLayout();
        this.flowLayoutPanel12.ResumeLayout(false);
        this.flowLayoutPanel13.ResumeLayout(false);
        this.ResumeLayout(false);
        this.PerformLayout();
    }
}