// Decompiled with JetBrains decompiler
// Type: RaceCreation
// Assembly: Aurora, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAB8E3AD-3A24-426F-849E-98EC2E2DD9EB
// Assembly location: C:\Users\jinhoon.kim\Desktop\Aurora250Full\Dedot\aurora-deop.exe

using Aurora;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

#nullable disable
public class RaceCreation : Form
{
  private GClass0 gclass0_0;
  private GClass1 gclass1_0;
  private GClass21 gclass21_0;
  private GClass146 gclass146_0;
  private bool bool_0;
  private bool bool_1;
  private IContainer icontainer_0;
  private FlowLayoutPanel flowLayoutPanel10;
  private FlowLayoutPanel flowLayoutPanel4;
  private Panel panel2;
  private ComboBox cboSpecies;
  private Label label17;
  private Panel panel1;
  private ComboBox cboSystemTheme;
  private Label label18;
  private Panel panel3;
  private ComboBox cboClassTheme;
  private Label label19;
  private Panel panel4;
  private ComboBox cboRankTheme;
  private Label label20;
  private Panel panel5;
  private ComboBox cboCommanderTheme;
  private Label label21;
  private CheckBox chkNPR;
  private FlowLayoutPanel flowLayoutPanel6;
  private Panel panel14;
  private TextBox txtSpeciesName;
  private Label label32;
  private Panel panel7;
  private TextBox txtGravity;
  private Label label23;
  private Panel panel8;
  private TextBox txtTemp;
  private Label label26;
  private Panel panel9;
  private TextBox txtOxygen;
  private Label label27;
  private Panel panel10;
  private TextBox txtPressure;
  private Label label28;
  private Panel panel11;
  private TextBox txtGravityDev;
  private Label label29;
  private Panel panel12;
  private TextBox txtTempDev;
  private Label label30;
  private Panel panel13;
  private TextBox txtOxygenDev;
  private Label label31;
  private Panel panel6;
  private TextBox txtTitle;
  private Label label22;
  private Panel panel15;
  private TextBox txtShortName;
  private Label label24;
  private Panel panel16;
  private TextBox txtHomeworld;
  private Label label25;
  private CheckBox chkConv;
  private CheckBox chkNeutral;
  private FlowLayoutPanel flowLayoutPanel1;
  private Panel panel18;
  private TextBox txtPopulation;
  private Label label2;
  private Panel panel22;
  private TextBox txtSY;
  private Label label6;
  private Panel panel23;
  private TextBox txtRL;
  private Label label7;
  private Panel panel24;
  private TextBox txtCF;
  private Label label8;
  private Panel panel17;
  private TextBox txtDensity;
  private Label label1;
  private Panel panel25;
  private TextBox txtMines;
  private Label label9;
  private Button cmdCreate;
  private Button cmdCancel;
  private Panel panel26;
  private TextBox txtGrowth;
  private Label label10;
  private Panel panel27;
  private TextBox txtResearch;
  private Label label11;
  private Panel panel28;
  private TextBox txtProduction;
  private Label label12;
  private PictureBox pbRace;
  private Panel panel29;
  private TextBox txtConst;
  private Label label13;
  private Panel panel30;
  private TextBox txtOF;
  private Label label14;
  private Panel panel31;
  private TextBox txtFF;
  private Label label15;
  private Panel panel32;
  private TextBox txtAM;
  private Label label16;
  private Panel panel33;
  private TextBox txtFR;
  private Label label33;
  private Panel panel34;
  private TextBox txtMF;
  private Label label34;
  private Panel panel35;
  private TextBox txtGF;
  private Label label35;
  private FlowLayoutPanel flowLayoutPanel2;
  private CheckBox chkSurveyGeo;
  private CheckBox chkAutoAssign;
  private CheckBox chkAutoCreate;
  private FlowLayoutPanel flowLayoutPanel3;
  private PictureBox pbFlag;
  private Button cmdSpeciesImage;
  private Panel panel36;
  private TextBox txtDet;
  private Label label36;
  private Panel panel37;
  private TextBox txtDip;
  private Label label37;
  private Panel panel38;
  private TextBox txtExp;
  private Label label38;
  private Panel panel39;
  private TextBox txtMil;
  private Label label39;
  private Panel panel40;
  private TextBox txtTrade;
  private Label label40;
  private Panel panel41;
  private TextBox txtTrans;
  private Label label41;
  private Panel panel42;
  private TextBox txtXen;
  private Label label42;
  private Button cmdRaceFlag;
  private Panel panel43;
  private TextBox txtFuel;
  private Label label43;
  private Panel panel44;
  private TextBox txtMSP;
  private Label label44;
  private Panel panel45;
  private TextBox txtDSTS;
  private Label label45;
  private Panel panel46;
  private TextBox txtMA;
  private Label label46;
  private Panel panel19;
  private TextBox txtTP;
  private Label label3;
  private Button cmdRandomName;
  private FlowLayoutPanel flowLayoutPanel5;
  private FlowLayoutPanel flowLayoutPanel7;
  private PictureBox pbShip;
  private PictureBox pbStation;
  private PictureBox pictureBox1;
  private Button cmdHull;
  private Button cmdStation;
  private CheckBox chkSurveyGrav;
  private CheckBox chkAutoDesignGround;
  private Panel panel47;
  private TextBox txtSBP;
  private Label label47;
  private Panel panel20;
  private TextBox txtFC;
  private Label label4;
  private Panel panel21;
  private TextBox txtGraduationAge;
  private Label label5;

  public RaceCreation(
    GClass0 gclass0_1,
    GClass1 gclass1_1,
    GClass21 gclass21_1,
    GClass146 gclass146_1,
    bool bool_2)
  {
    this.InitializeComponent();
    this.gclass0_0 = gclass0_1;
    this.gclass1_0 = gclass1_1;
    this.gclass21_0 = gclass21_1;
    this.gclass146_0 = gclass146_1;
    this.bool_0 = bool_2;
  }

  private void RaceCreation_FormClosing(object sender, FormClosingEventArgs e)
  {
    try
    {
      if (!this.bool_1)
        e.Cancel = true;
      this.gclass0_0.method_512(this.Name, this.Left, this.Top);
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2571);
    }
  }

  private void RaceCreation_Load(object sender, EventArgs e)
  {
    try
    {
      GClass207 gclass207 = this.gclass0_0.method_513(this.Name);
      this.Left = gclass207.int_0;
      this.Top = gclass207.int_1;
      this.cmdCancel.Visible = this.bool_0;
      this.gclass21_0.bool_14 = false;
      this.txtTitle.Text = this.gclass21_0.RaceTitle;
      this.txtShortName.Text = this.gclass21_0.string_0;
      this.txtHomeworld.Text = this.gclass21_0.string_6;
      this.pbFlag.Image = this.gclass21_0.image_0;
      this.pbShip.Image = this.gclass21_0.image_1;
      this.pbStation.Image = this.gclass21_0.image_2;
      this.method_1(this.cboSpecies);
      this.gclass0_0.method_552(this.cboClassTheme);
      this.gclass0_0.method_552(this.cboSystemTheme);
      this.gclass0_0.method_553(this.cboCommanderTheme);
      this.gclass0_0.method_554(this.cboRankTheme);
      this.cboClassTheme.SelectedItem = (object) this.gclass21_0.gclass140_0;
      this.cboSystemTheme.SelectedItem = (object) this.gclass21_0.gclass140_1;
      this.cboCommanderTheme.SelectedItem = (object) this.gclass21_0.list_1[0].gclass58_0;
      this.cboRankTheme.SelectedItem = (object) this.gclass21_0.gclass60_0;
      this.txtPopulation.Text = GClass226.smethod_42(this.gclass146_0.decimal_30, 1);
      this.method_0();
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2572);
    }
  }

  private void method_0()
  {
    try
    {
      this.txtRL.Text = GClass226.smethod_37(this.gclass146_0.method_73(AuroraInstallationType.ResearchLab));
      this.txtCF.Text = GClass226.smethod_37(this.gclass146_0.method_73(AuroraInstallationType.ConventionalIndustry));
      this.txtSY.Text = GClass226.smethod_37(this.gclass21_0.int_41);
      this.txtTP.Text = GClass226.smethod_37(this.gclass21_0.int_32);
      this.txtSBP.Text = GClass226.smethod_38(this.gclass21_0.decimal_25);
      this.txtConst.Text = GClass226.smethod_37(this.gclass146_0.method_73(AuroraInstallationType.ConstructionFactory));
      this.txtOF.Text = GClass226.smethod_37(this.gclass146_0.method_73(AuroraInstallationType.OrdnanceFactory));
      this.txtFF.Text = GClass226.smethod_37(this.gclass146_0.method_73(AuroraInstallationType.FighterFactory));
      this.txtFC.Text = GClass226.smethod_37(this.gclass146_0.method_73(AuroraInstallationType.FinancialCentre));
      this.txtFR.Text = GClass226.smethod_37(this.gclass146_0.method_73(AuroraInstallationType.FuelRefinery));
      this.txtAM.Text = GClass226.smethod_37(this.gclass146_0.method_73(AuroraInstallationType.AutomatedMine));
      this.txtMines.Text = GClass226.smethod_37(this.gclass146_0.method_73(AuroraInstallationType.Mine));
      this.txtMF.Text = GClass226.smethod_37(this.gclass146_0.method_73(AuroraInstallationType.MaintenanceFacility));
      this.txtGF.Text = GClass226.smethod_37(this.gclass146_0.method_73(AuroraInstallationType.GFCC));
      this.txtDSTS.Text = GClass226.smethod_37(this.gclass146_0.method_73(AuroraInstallationType.TrackingStation));
      this.txtMA.Text = GClass226.smethod_37(this.gclass146_0.method_73(AuroraInstallationType.MilitaryAcademy));
      this.txtFuel.Text = GClass226.smethod_39(this.gclass146_0.decimal_3);
      this.txtMSP.Text = GClass226.smethod_38(this.gclass146_0.decimal_0);
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2573);
    }
  }

  private void cmdCreate_Click(object sender, EventArgs e)
  {
    try
    {
      this.gclass21_0.RaceTitle = this.txtTitle.Text;
      this.gclass21_0.string_0 = this.txtShortName.Text;
      this.gclass21_0.string_6 = this.txtHomeworld.Text;
      this.gclass21_0.genum82_0 = GEnum82.const_0;
      if (this.chkConv.Checked && !this.chkNPR.Checked)
        this.gclass21_0.genum82_0 = GEnum82.const_1;
      else if (this.chkConv.Checked && this.chkNPR.Checked)
        this.gclass21_0.genum82_0 = GEnum82.const_2;
      this.gclass21_0.gclass140_0 = (GClass140) this.cboClassTheme.SelectedValue;
      this.gclass21_0.gclass140_1 = (GClass140) this.cboSystemTheme.SelectedValue;
      this.gclass21_0.gclass60_0 = (GClass60) this.cboRankTheme.SelectedValue;
      GClass58 selectedValue = (GClass58) this.cboCommanderTheme.SelectedValue;
      if (this.gclass21_0.list_1[0].gclass58_0 != selectedValue)
      {
        this.gclass21_0.list_1.Clear();
        this.gclass21_0.method_111(selectedValue, 100);
      }
      this.gclass21_0.bool_0 = GClass226.smethod_27(this.chkNPR.CheckState);
      this.gclass21_0.bool_15 = GClass226.smethod_27(this.chkSurveyGrav.CheckState);
      this.gclass21_0.bool_16 = GClass226.smethod_27(this.chkSurveyGeo.CheckState);
      this.gclass21_0.bool_17 = GClass226.smethod_27(this.chkAutoAssign.CheckState);
      this.gclass21_0.bool_18 = GClass226.smethod_27(this.chkAutoCreate.CheckState);
      this.gclass21_0.bool_19 = GClass226.smethod_27(this.chkAutoDesignGround.CheckState);
      this.gclass21_0.int_41 = Convert.ToInt32(this.txtSY.Text);
      this.gclass21_0.bool_1 = GClass226.smethod_27(this.chkNeutral.CheckState);
      if (this.gclass21_0.genum82_0 == GEnum82.const_0)
      {
        GClass208 gclass208 = GClass226.smethod_4(this.txtTP.Text);
        if (gclass208.bool_0)
          this.gclass21_0.int_32 = (int) gclass208.decimal_0;
        if (!this.gclass21_0.bool_0 && this.gclass21_0.int_32 > this.gclass0_0.int_134)
          this.gclass0_0.int_134 = this.gclass21_0.int_32;
      }
      GClass208 gclass208_1 = GClass226.smethod_4(this.txtSBP.Text);
      if (gclass208_1.bool_0)
        this.gclass21_0.decimal_25 = (Decimal) (int) gclass208_1.decimal_0;
      if (this.gclass21_0.bool_0)
      {
        this.gclass21_0.gclass2_0 = new GClass2(this.gclass0_0, this.gclass21_0);
        this.gclass21_0.decimal_26 = this.gclass21_0.decimal_25 / 2M;
        this.gclass146_0.gclass6_0 = new GClass6(this.gclass0_0, this.gclass146_0);
        this.gclass146_0.gclass202_0.gclass3_0 = new GClass3(this.gclass0_0, this.gclass146_0.gclass202_0);
      }
      GClass208 gclass208_2 = GClass226.smethod_4(this.txtPopulation.Text);
      if (gclass208_2.bool_0)
        this.gclass146_0.method_25(gclass208_2.decimal_0);
      GClass208 gclass208_3 = GClass226.smethod_4(this.txtFuel.Text);
      if (gclass208_3.bool_0)
        this.gclass146_0.decimal_3 = gclass208_3.decimal_0;
      GClass208 gclass208_4 = GClass226.smethod_4(this.txtMSP.Text);
      if (gclass208_4.bool_0)
        this.gclass146_0.decimal_0 = gclass208_4.decimal_0;
      this.gclass146_0.int_2 = GClass226.smethod_29(this.chkNeutral.CheckState);
      GClass208 gclass208_5 = GClass226.smethod_4(this.txtRL.Text);
      if (gclass208_5.bool_0)
        this.gclass146_0.method_64(AuroraInstallationType.ResearchLab, gclass208_5.decimal_0);
      GClass208 gclass208_6 = GClass226.smethod_4(this.txtConst.Text);
      if (gclass208_6.bool_0)
        this.gclass146_0.method_64(AuroraInstallationType.ConstructionFactory, gclass208_6.decimal_0);
      GClass208 gclass208_7 = GClass226.smethod_4(this.txtOF.Text);
      if (gclass208_7.bool_0)
        this.gclass146_0.method_64(AuroraInstallationType.OrdnanceFactory, gclass208_7.decimal_0);
      GClass208 gclass208_8 = GClass226.smethod_4(this.txtFF.Text);
      if (gclass208_8.bool_0)
        this.gclass146_0.method_64(AuroraInstallationType.FighterFactory, gclass208_8.decimal_0);
      GClass208 gclass208_9 = GClass226.smethod_4(this.txtCF.Text);
      if (gclass208_9.bool_0)
        this.gclass146_0.method_64(AuroraInstallationType.ConventionalIndustry, gclass208_9.decimal_0);
      GClass208 gclass208_10 = GClass226.smethod_4(this.txtFR.Text);
      if (gclass208_10.bool_0)
        this.gclass146_0.method_64(AuroraInstallationType.FuelRefinery, gclass208_10.decimal_0);
      GClass208 gclass208_11 = GClass226.smethod_4(this.txtAM.Text);
      if (gclass208_11.bool_0)
        this.gclass146_0.method_64(AuroraInstallationType.AutomatedMine, gclass208_11.decimal_0);
      GClass208 gclass208_12 = GClass226.smethod_4(this.txtMines.Text);
      if (gclass208_12.bool_0)
        this.gclass146_0.method_64(AuroraInstallationType.Mine, gclass208_12.decimal_0);
      GClass208 gclass208_13 = GClass226.smethod_4(this.txtMF.Text);
      if (gclass208_13.bool_0)
        this.gclass146_0.method_64(AuroraInstallationType.MaintenanceFacility, gclass208_13.decimal_0);
      GClass208 gclass208_14 = GClass226.smethod_4(this.txtGF.Text);
      if (gclass208_14.bool_0)
        this.gclass146_0.method_64(AuroraInstallationType.GFCC, gclass208_14.decimal_0);
      GClass208 gclass208_15 = GClass226.smethod_4(this.txtDSTS.Text);
      if (gclass208_15.bool_0)
        this.gclass146_0.method_64(AuroraInstallationType.TrackingStation, gclass208_15.decimal_0);
      GClass208 gclass208_16 = GClass226.smethod_4(this.txtMA.Text);
      if (gclass208_16.bool_0)
        this.gclass146_0.method_64(AuroraInstallationType.MilitaryAcademy, gclass208_16.decimal_0);
      GClass208 gclass208_17 = GClass226.smethod_4(this.txtFC.Text);
      if (gclass208_17.bool_0)
        this.gclass146_0.method_64(AuroraInstallationType.FinancialCentre, gclass208_17.decimal_0);
      this.gclass146_0.gclass194_0.SpeciesName = this.txtSpeciesName.Text;
      this.gclass146_0.gclass194_0.int_7 = Convert.ToInt32(this.txtDet.Text);
      this.gclass146_0.gclass194_0.int_3 = Convert.ToInt32(this.txtDip.Text);
      this.gclass146_0.gclass194_0.int_6 = Convert.ToInt32(this.txtExp.Text);
      this.gclass146_0.gclass194_0.int_5 = Convert.ToInt32(this.txtMil.Text);
      this.gclass146_0.gclass194_0.int_8 = Convert.ToInt32(this.txtTrade.Text);
      this.gclass146_0.gclass194_0.int_4 = Convert.ToInt32(this.txtTrans.Text);
      this.gclass146_0.gclass194_0.int_2 = Convert.ToInt32(this.txtXen.Text);
      GClass208 gclass208_18 = GClass226.smethod_4(this.txtDensity.Text);
      if (gclass208_18.bool_0)
        this.gclass146_0.gclass194_0.decimal_0 = gclass208_18.decimal_0;
      GClass208 gclass208_19 = GClass226.smethod_4(this.txtGrowth.Text);
      if (gclass208_19.bool_0)
        this.gclass146_0.gclass194_0.decimal_1 = gclass208_19.decimal_0;
      GClass208 gclass208_20 = GClass226.smethod_4(this.txtProduction.Text);
      if (gclass208_20.bool_0)
        this.gclass146_0.gclass194_0.decimal_3 = gclass208_20.decimal_0;
      GClass208 gclass208_21 = GClass226.smethod_4(this.txtResearch.Text);
      if (gclass208_21.bool_0)
        this.gclass146_0.gclass194_0.decimal_2 = gclass208_21.decimal_0;
      this.gclass146_0.gclass194_0.double_5 = Convert.ToDouble(this.txtGravity.Text);
      this.gclass146_0.gclass194_0.double_6 = Convert.ToDouble(this.txtGravityDev.Text);
      this.gclass146_0.gclass194_0.double_3 = Convert.ToDouble(this.txtTemp.Text) + (double) GClass226.int_17;
      this.gclass146_0.gclass194_0.double_4 = Convert.ToDouble(this.txtTempDev.Text);
      this.gclass146_0.gclass194_0.double_0 = Convert.ToDouble(this.txtOxygen.Text);
      this.gclass146_0.gclass194_0.double_1 = Convert.ToDouble(this.txtOxygenDev.Text);
      this.gclass146_0.gclass194_0.double_2 = Convert.ToDouble(this.txtPressure.Text);
      this.gclass146_0.gclass194_0.int_11 = Convert.ToInt32(this.txtGraduationAge.Text);
      this.gclass146_0.gclass194_0.double_7 = this.gclass146_0.gclass194_0.double_5 - this.gclass146_0.gclass194_0.double_6;
      this.gclass146_0.gclass194_0.double_8 = this.gclass146_0.gclass194_0.double_5 + this.gclass146_0.gclass194_0.double_6;
      this.gclass146_0.gclass194_0.double_9 = this.gclass146_0.gclass194_0.double_0 - this.gclass146_0.gclass194_0.double_1;
      this.gclass146_0.gclass194_0.double_10 = this.gclass146_0.gclass194_0.double_0 + this.gclass146_0.gclass194_0.double_1;
      this.gclass146_0.gclass194_0.double_12 = this.gclass146_0.gclass194_0.double_3 - this.gclass146_0.gclass194_0.double_4;
      this.gclass146_0.gclass194_0.double_11 = this.gclass146_0.gclass194_0.double_3 + this.gclass146_0.gclass194_0.double_4;
      this.gclass21_0.bool_14 = true;
      this.bool_1 = true;
      this.Close();
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2574);
    }
  }

  private void method_1(ComboBox comboBox_0)
  {
    try
    {
      List<GClass194> list1 = this.gclass0_0.dictionary_37.Values.ToList<GClass194>();
      foreach (GClass194 gclass194 in list1)
        gclass194.int_10 = 1;
      list1.Add(this.gclass1_0.gclass194_0);
      List<GClass194> list2 = list1.OrderBy<GClass194, int>((Func<GClass194, int>) (gclass194_0 => gclass194_0.int_10)).ThenBy<GClass194, string>((Func<GClass194, string>) (gclass194_0 => gclass194_0.SpeciesName)).ToList<GClass194>();
      comboBox_0.DisplayMember = "SpeciesName";
      comboBox_0.DataSource = (object) list2;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2575);
    }
  }

  private void cboSpecies_SelectedIndexChanged(object sender, EventArgs e)
  {
    try
    {
      if (this.cboSpecies.SelectedValue == null)
        return;
      this.gclass146_0.gclass194_0 = (GClass194) this.cboSpecies.SelectedValue;
      this.txtSpeciesName.Text = this.gclass146_0.gclass194_0.SpeciesName;
      this.pbRace.Image = Image.FromFile($"{Application.StartupPath}\\Races\\{this.gclass146_0.gclass194_0.string_0}");
      this.txtGravity.Text = GClass226.smethod_46(this.gclass146_0.gclass194_0.double_5, 2);
      this.txtGravityDev.Text = GClass226.smethod_46(this.gclass146_0.gclass194_0.double_6, 2);
      this.txtTemp.Text = GClass226.smethod_46(this.gclass146_0.gclass194_0.double_3 - (double) GClass226.int_17, 2);
      this.txtTempDev.Text = GClass226.smethod_46(this.gclass146_0.gclass194_0.double_4, 2);
      this.txtOxygen.Text = GClass226.smethod_46(this.gclass146_0.gclass194_0.double_0, 2);
      this.txtOxygenDev.Text = GClass226.smethod_46(this.gclass146_0.gclass194_0.double_1, 2);
      this.txtPressure.Text = GClass226.smethod_46(this.gclass146_0.gclass194_0.double_2, 2);
      this.txtDensity.Text = GClass226.smethod_45(this.gclass146_0.gclass194_0.decimal_0, 2);
      this.txtGrowth.Text = GClass226.smethod_45(this.gclass146_0.gclass194_0.decimal_1, 2);
      this.txtResearch.Text = GClass226.smethod_45(this.gclass146_0.gclass194_0.decimal_2, 2);
      this.txtProduction.Text = GClass226.smethod_45(this.gclass146_0.gclass194_0.decimal_3, 2);
      this.txtDet.Text = GClass226.smethod_37(this.gclass146_0.gclass194_0.int_7);
      this.txtDip.Text = GClass226.smethod_37(this.gclass146_0.gclass194_0.int_3);
      this.txtExp.Text = GClass226.smethod_37(this.gclass146_0.gclass194_0.int_6);
      this.txtMil.Text = GClass226.smethod_37(this.gclass146_0.gclass194_0.int_5);
      this.txtTrade.Text = GClass226.smethod_37(this.gclass146_0.gclass194_0.int_8);
      this.txtTrans.Text = GClass226.smethod_37(this.gclass146_0.gclass194_0.int_4);
      this.txtXen.Text = GClass226.smethod_37(this.gclass146_0.gclass194_0.int_2);
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2576);
    }
  }

  private void cmdSpeciesImage_Click(object sender, EventArgs e)
  {
    try
    {
      string str = GClass226.smethod_18("Races");
      if (str != "")
      {
        int num = str.LastIndexOf("\\");
        this.gclass146_0.gclass194_0.string_0 = str.Substring(num + 1);
      }
      this.pbRace.Image = Image.FromFile($"{Application.StartupPath}\\Races\\{this.gclass146_0.gclass194_0.string_0}");
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2577);
    }
  }

  private void cmdRaceFlag_Click(object sender, EventArgs e)
  {
    try
    {
      string str = GClass226.smethod_18("Flags");
      if (str != "")
      {
        int num = str.LastIndexOf("\\");
        this.gclass21_0.string_1 = str.Substring(num + 1);
      }
      this.gclass21_0.image_0 = Image.FromFile($"{Application.StartupPath}\\Flags\\{this.gclass21_0.string_1}");
      this.pbFlag.Image = this.gclass21_0.image_0;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2578);
    }
  }

  private void cmdCancel_Click(object sender, EventArgs e)
  {
    this.gclass0_0.bool_21 = true;
    this.bool_1 = true;
    this.Close();
  }

  private void cmdRandomName_Click(object sender, EventArgs e)
  {
    try
    {
      string string_10 = this.gclass0_0.method_551();
      this.txtShortName.Text = string_10;
      this.txtTitle.Text = this.gclass0_0.method_555(string_10);
      this.txtHomeworld.Text = string_10 + " Prime";
      if (this.gclass146_0.gclass194_0.int_10 != 0)
        return;
      this.txtSpeciesName.Text = string_10;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2579);
    }
  }

  private void chkNeutral_CheckedChanged(object sender, EventArgs e)
  {
    try
    {
      this.gclass21_0.genum82_0 = !this.chkConv.Checked || this.chkNPR.Checked ? (!this.chkConv.Checked || !this.chkNPR.Checked ? GEnum82.const_0 : GEnum82.const_2) : GEnum82.const_1;
      this.gclass146_0.method_59(this.chkNeutral.CheckState, (GClass143) null, 0);
      if (this.chkConv.CheckState == CheckState.Checked)
      {
        this.gclass21_0.decimal_25 = 0M;
        this.chkAutoAssign.CheckState = CheckState.Unchecked;
        this.chkAutoDesignGround.CheckState = CheckState.Unchecked;
        this.chkAutoCreate.CheckState = CheckState.Unchecked;
        this.chkAutoAssign.Enabled = false;
        this.chkAutoDesignGround.Enabled = false;
        this.chkAutoCreate.Enabled = false;
      }
      else
      {
        this.chkAutoAssign.Enabled = true;
        this.chkAutoDesignGround.Enabled = true;
        this.chkAutoCreate.Enabled = true;
        this.gclass21_0.decimal_25 = 3M * this.gclass146_0.method_181();
      }
      this.method_0();
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2580);
    }
  }

  private void txtPopulation_TextChanged(object sender, EventArgs e)
  {
    try
    {
      if (this.txtPopulation.Text == "")
        return;
      GClass208 gclass208 = GClass226.smethod_4(this.txtPopulation.Text);
      if (!gclass208.bool_0 || gclass208.decimal_0 <= 0M)
        return;
      this.gclass146_0.method_25(gclass208.decimal_0);
      this.gclass146_0.method_59(this.chkNeutral.CheckState, (GClass143) null, 0);
      this.method_0();
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2581);
    }
  }

  private void cmdHull_Click(object sender, EventArgs e)
  {
    try
    {
      string str = GClass226.smethod_18("ShipIcons");
      if (str != "")
      {
        int num = str.LastIndexOf("\\");
        this.gclass21_0.string_3 = str.Substring(num + 1);
      }
      this.gclass21_0.image_1 = Image.FromFile($"{Application.StartupPath}\\ShipIcons\\{this.gclass21_0.string_3}");
      this.pbShip.Image = this.gclass21_0.image_1;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2582);
    }
  }

  private void cmdStation_Click(object sender, EventArgs e)
  {
    try
    {
      string str = GClass226.smethod_18("StationIcons");
      if (str != "")
      {
        int num = str.LastIndexOf("\\");
        this.gclass21_0.string_4 = str.Substring(num + 1);
      }
      this.gclass21_0.image_2 = Image.FromFile($"{Application.StartupPath}\\StationIcons\\{this.gclass21_0.string_4}");
      this.pbStation.Image = this.gclass21_0.image_2;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2583);
    }
  }

  private void chkNPR_CheckedChanged(object sender, EventArgs e)
  {
    try
    {
      if (this.chkNPR.CheckState == CheckState.Checked)
      {
        this.chkAutoAssign.CheckState = CheckState.Checked;
        this.chkAutoDesignGround.CheckState = CheckState.Checked;
        this.chkAutoCreate.CheckState = CheckState.Checked;
        this.chkNeutral.CheckState = CheckState.Unchecked;
        this.chkAutoAssign.Enabled = false;
        this.chkAutoDesignGround.Enabled = false;
        this.chkAutoCreate.Enabled = false;
        this.chkNeutral.Enabled = false;
      }
      else
      {
        this.chkAutoAssign.Enabled = true;
        this.chkAutoDesignGround.Enabled = true;
        this.chkAutoCreate.Enabled = true;
        this.chkNeutral.Enabled = true;
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2584);
    }
  }

  private void chkSurveyGeo_CheckedChanged(object sender, EventArgs e)
  {
  }

  private void method_2(object sender, EventArgs e)
  {
  }

  private void txtTP_Leave(object sender, EventArgs e)
  {
    try
    {
      if (this.chkNPR.CheckState != CheckState.Checked)
        return;
      GClass208 gclass208 = GClass226.smethod_4(this.txtTP.Text);
      if (!gclass208.bool_0 || !(gclass208.decimal_0 < 100000M))
        return;
      this.txtTP.Text = "100000";
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3190);
    }
  }

  private void chkAutoDesignGround_CheckedChanged(object sender, EventArgs e)
  {
    try
    {
      if (this.chkAutoDesignGround.CheckState != CheckState.Checked)
        return;
      this.chkAutoAssign.CheckState = CheckState.Checked;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3226);
    }
  }

  private void chkAutoAssign_CheckedChanged(object sender, EventArgs e)
  {
    try
    {
      if (this.chkAutoAssign.CheckState != CheckState.Unchecked)
        return;
      this.chkAutoDesignGround.CheckState = CheckState.Unchecked;
      this.chkAutoCreate.CheckState = CheckState.Unchecked;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3227);
    }
  }

  private void chkAutoCreate_CheckedChanged(object sender, EventArgs e)
  {
    try
    {
      if (this.chkAutoCreate.CheckState != CheckState.Checked)
        return;
      this.chkAutoCreate.CheckState = CheckState.Checked;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3228);
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
    this.flowLayoutPanel10 = new FlowLayoutPanel();
    this.panel6 = new Panel();
    this.txtTitle = new TextBox();
    this.label22 = new Label();
    this.panel15 = new Panel();
    this.txtShortName = new TextBox();
    this.label24 = new Label();
    this.panel16 = new Panel();
    this.txtHomeworld = new TextBox();
    this.label25 = new Label();
    this.chkNPR = new CheckBox();
    this.chkConv = new CheckBox();
    this.chkNeutral = new CheckBox();
    this.flowLayoutPanel4 = new FlowLayoutPanel();
    this.panel2 = new Panel();
    this.cboSpecies = new ComboBox();
    this.label17 = new Label();
    this.panel1 = new Panel();
    this.cboSystemTheme = new ComboBox();
    this.label18 = new Label();
    this.panel3 = new Panel();
    this.cboClassTheme = new ComboBox();
    this.label19 = new Label();
    this.panel4 = new Panel();
    this.cboRankTheme = new ComboBox();
    this.label20 = new Label();
    this.panel5 = new Panel();
    this.cboCommanderTheme = new ComboBox();
    this.label21 = new Label();
    this.flowLayoutPanel6 = new FlowLayoutPanel();
    this.panel14 = new Panel();
    this.txtSpeciesName = new TextBox();
    this.label32 = new Label();
    this.panel7 = new Panel();
    this.txtGravity = new TextBox();
    this.label23 = new Label();
    this.panel8 = new Panel();
    this.txtTemp = new TextBox();
    this.label26 = new Label();
    this.panel9 = new Panel();
    this.txtOxygen = new TextBox();
    this.label27 = new Label();
    this.panel10 = new Panel();
    this.txtPressure = new TextBox();
    this.label28 = new Label();
    this.panel11 = new Panel();
    this.txtGravityDev = new TextBox();
    this.label29 = new Label();
    this.panel12 = new Panel();
    this.txtTempDev = new TextBox();
    this.label30 = new Label();
    this.panel13 = new Panel();
    this.txtOxygenDev = new TextBox();
    this.label31 = new Label();
    this.panel17 = new Panel();
    this.txtDensity = new TextBox();
    this.label1 = new Label();
    this.panel26 = new Panel();
    this.txtGrowth = new TextBox();
    this.label10 = new Label();
    this.panel27 = new Panel();
    this.txtResearch = new TextBox();
    this.label11 = new Label();
    this.panel28 = new Panel();
    this.txtProduction = new TextBox();
    this.label12 = new Label();
    this.panel36 = new Panel();
    this.txtDet = new TextBox();
    this.label36 = new Label();
    this.panel37 = new Panel();
    this.txtDip = new TextBox();
    this.label37 = new Label();
    this.panel38 = new Panel();
    this.txtExp = new TextBox();
    this.label38 = new Label();
    this.panel39 = new Panel();
    this.txtMil = new TextBox();
    this.label39 = new Label();
    this.panel40 = new Panel();
    this.txtTrade = new TextBox();
    this.label40 = new Label();
    this.panel41 = new Panel();
    this.txtTrans = new TextBox();
    this.label41 = new Label();
    this.panel42 = new Panel();
    this.txtXen = new TextBox();
    this.label42 = new Label();
    this.flowLayoutPanel1 = new FlowLayoutPanel();
    this.panel18 = new Panel();
    this.txtPopulation = new TextBox();
    this.label2 = new Label();
    this.panel22 = new Panel();
    this.txtSY = new TextBox();
    this.label6 = new Label();
    this.panel23 = new Panel();
    this.txtRL = new TextBox();
    this.label7 = new Label();
    this.panel24 = new Panel();
    this.txtCF = new TextBox();
    this.label8 = new Label();
    this.panel29 = new Panel();
    this.txtConst = new TextBox();
    this.label13 = new Label();
    this.panel30 = new Panel();
    this.txtOF = new TextBox();
    this.label14 = new Label();
    this.panel31 = new Panel();
    this.txtFF = new TextBox();
    this.label15 = new Label();
    this.panel25 = new Panel();
    this.txtMines = new TextBox();
    this.label9 = new Label();
    this.panel32 = new Panel();
    this.txtAM = new TextBox();
    this.label16 = new Label();
    this.panel33 = new Panel();
    this.txtFR = new TextBox();
    this.label33 = new Label();
    this.panel20 = new Panel();
    this.txtFC = new TextBox();
    this.label4 = new Label();
    this.panel34 = new Panel();
    this.txtMF = new TextBox();
    this.label34 = new Label();
    this.panel35 = new Panel();
    this.txtGF = new TextBox();
    this.label35 = new Label();
    this.panel45 = new Panel();
    this.txtDSTS = new TextBox();
    this.label45 = new Label();
    this.panel46 = new Panel();
    this.txtMA = new TextBox();
    this.label46 = new Label();
    this.panel43 = new Panel();
    this.txtFuel = new TextBox();
    this.label43 = new Label();
    this.panel44 = new Panel();
    this.txtMSP = new TextBox();
    this.label44 = new Label();
    this.panel19 = new Panel();
    this.txtTP = new TextBox();
    this.label3 = new Label();
    this.panel47 = new Panel();
    this.txtSBP = new TextBox();
    this.label47 = new Label();
    this.cmdCreate = new Button();
    this.cmdCancel = new Button();
    this.pbRace = new PictureBox();
    this.flowLayoutPanel2 = new FlowLayoutPanel();
    this.chkAutoAssign = new CheckBox();
    this.chkAutoDesignGround = new CheckBox();
    this.chkAutoCreate = new CheckBox();
    this.chkSurveyGeo = new CheckBox();
    this.chkSurveyGrav = new CheckBox();
    this.flowLayoutPanel3 = new FlowLayoutPanel();
    this.flowLayoutPanel5 = new FlowLayoutPanel();
    this.flowLayoutPanel7 = new FlowLayoutPanel();
    this.pbShip = new PictureBox();
    this.pbStation = new PictureBox();
    this.pbFlag = new PictureBox();
    this.pictureBox1 = new PictureBox();
    this.cmdSpeciesImage = new Button();
    this.cmdRaceFlag = new Button();
    this.cmdRandomName = new Button();
    this.cmdHull = new Button();
    this.cmdStation = new Button();
    this.panel21 = new Panel();
    this.txtGraduationAge = new TextBox();
    this.label5 = new Label();
    this.flowLayoutPanel10.SuspendLayout();
    this.panel6.SuspendLayout();
    this.panel15.SuspendLayout();
    this.panel16.SuspendLayout();
    this.flowLayoutPanel4.SuspendLayout();
    this.panel2.SuspendLayout();
    this.panel1.SuspendLayout();
    this.panel3.SuspendLayout();
    this.panel4.SuspendLayout();
    this.panel5.SuspendLayout();
    this.flowLayoutPanel6.SuspendLayout();
    this.panel14.SuspendLayout();
    this.panel7.SuspendLayout();
    this.panel8.SuspendLayout();
    this.panel9.SuspendLayout();
    this.panel10.SuspendLayout();
    this.panel11.SuspendLayout();
    this.panel12.SuspendLayout();
    this.panel13.SuspendLayout();
    this.panel17.SuspendLayout();
    this.panel26.SuspendLayout();
    this.panel27.SuspendLayout();
    this.panel28.SuspendLayout();
    this.panel36.SuspendLayout();
    this.panel37.SuspendLayout();
    this.panel38.SuspendLayout();
    this.panel39.SuspendLayout();
    this.panel40.SuspendLayout();
    this.panel41.SuspendLayout();
    this.panel42.SuspendLayout();
    this.flowLayoutPanel1.SuspendLayout();
    this.panel18.SuspendLayout();
    this.panel22.SuspendLayout();
    this.panel23.SuspendLayout();
    this.panel24.SuspendLayout();
    this.panel29.SuspendLayout();
    this.panel30.SuspendLayout();
    this.panel31.SuspendLayout();
    this.panel25.SuspendLayout();
    this.panel32.SuspendLayout();
    this.panel33.SuspendLayout();
    this.panel20.SuspendLayout();
    this.panel34.SuspendLayout();
    this.panel35.SuspendLayout();
    this.panel45.SuspendLayout();
    this.panel46.SuspendLayout();
    this.panel43.SuspendLayout();
    this.panel44.SuspendLayout();
    this.panel19.SuspendLayout();
    this.panel47.SuspendLayout();
    ((ISupportInitialize) this.pbRace).BeginInit();
    this.flowLayoutPanel2.SuspendLayout();
    this.flowLayoutPanel3.SuspendLayout();
    this.flowLayoutPanel5.SuspendLayout();
    this.flowLayoutPanel7.SuspendLayout();
    ((ISupportInitialize) this.pbShip).BeginInit();
    ((ISupportInitialize) this.pbStation).BeginInit();
    ((ISupportInitialize) this.pbFlag).BeginInit();
    ((ISupportInitialize) this.pictureBox1).BeginInit();
    this.panel21.SuspendLayout();
    this.SuspendLayout();
    this.flowLayoutPanel10.BorderStyle = BorderStyle.FixedSingle;
    this.flowLayoutPanel10.Controls.Add((Control) this.panel6);
    this.flowLayoutPanel10.Controls.Add((Control) this.panel15);
    this.flowLayoutPanel10.Controls.Add((Control) this.panel16);
    this.flowLayoutPanel10.FlowDirection = FlowDirection.TopDown;
    this.flowLayoutPanel10.Location = new Point(3, 3);
    this.flowLayoutPanel10.Name = "flowLayoutPanel10";
    this.flowLayoutPanel10.Size = new Size(330, 68);
    this.flowLayoutPanel10.TabIndex = 108;
    this.flowLayoutPanel10.WrapContents = false;
    this.panel6.Controls.Add((Control) this.txtTitle);
    this.panel6.Controls.Add((Control) this.label22);
    this.panel6.Location = new Point(3, 3);
    this.panel6.Name = "panel6";
    this.panel6.Size = new Size(320, 15);
    this.panel6.TabIndex = 119;
    this.txtTitle.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.txtTitle.BorderStyle = BorderStyle.None;
    this.txtTitle.Dock = DockStyle.Right;
    this.txtTitle.ForeColor = Color.FromArgb(128 /*0x80*/, (int) byte.MaxValue, 128 /*0x80*/);
    this.txtTitle.Location = new Point(100, 0);
    this.txtTitle.Name = "txtTitle";
    this.txtTitle.Size = new Size(220, 13);
    this.txtTitle.TabIndex = 105;
    this.txtTitle.Text = "Text";
    this.txtTitle.TextAlign = HorizontalAlignment.Center;
    this.label22.AutoSize = true;
    this.label22.Dock = DockStyle.Left;
    this.label22.Location = new Point(0, 0);
    this.label22.Margin = new Padding(3);
    this.label22.Name = "label22";
    this.label22.Size = new Size(56, 13);
    this.label22.TabIndex = 104;
    this.label22.Text = "Race Title";
    this.panel15.Controls.Add((Control) this.txtShortName);
    this.panel15.Controls.Add((Control) this.label24);
    this.panel15.Location = new Point(3, 24);
    this.panel15.Name = "panel15";
    this.panel15.Size = new Size(320, 15);
    this.panel15.TabIndex = 120;
    this.txtShortName.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.txtShortName.BorderStyle = BorderStyle.None;
    this.txtShortName.Dock = DockStyle.Right;
    this.txtShortName.ForeColor = Color.FromArgb(128 /*0x80*/, (int) byte.MaxValue, 128 /*0x80*/);
    this.txtShortName.Location = new Point(100, 0);
    this.txtShortName.Name = "txtShortName";
    this.txtShortName.Size = new Size(220, 13);
    this.txtShortName.TabIndex = 105;
    this.txtShortName.Text = "Text";
    this.txtShortName.TextAlign = HorizontalAlignment.Center;
    this.label24.AutoSize = true;
    this.label24.Dock = DockStyle.Left;
    this.label24.Location = new Point(0, 0);
    this.label24.Margin = new Padding(3);
    this.label24.Name = "label24";
    this.label24.Size = new Size(92, 13);
    this.label24.TabIndex = 104;
    this.label24.Text = "Race Short Name";
    this.panel16.Controls.Add((Control) this.txtHomeworld);
    this.panel16.Controls.Add((Control) this.label25);
    this.panel16.Location = new Point(3, 45);
    this.panel16.Name = "panel16";
    this.panel16.Size = new Size(320, 15);
    this.panel16.TabIndex = 121;
    this.txtHomeworld.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.txtHomeworld.BorderStyle = BorderStyle.None;
    this.txtHomeworld.Dock = DockStyle.Right;
    this.txtHomeworld.ForeColor = Color.FromArgb(128 /*0x80*/, (int) byte.MaxValue, 128 /*0x80*/);
    this.txtHomeworld.Location = new Point(100, 0);
    this.txtHomeworld.Name = "txtHomeworld";
    this.txtHomeworld.Size = new Size(220, 13);
    this.txtHomeworld.TabIndex = 105;
    this.txtHomeworld.Text = "Text";
    this.txtHomeworld.TextAlign = HorizontalAlignment.Center;
    this.label25.AutoSize = true;
    this.label25.Dock = DockStyle.Left;
    this.label25.Location = new Point(0, 0);
    this.label25.Margin = new Padding(3);
    this.label25.Name = "label25";
    this.label25.Size = new Size(91, 13);
    this.label25.TabIndex = 104;
    this.label25.Text = "Homeworld Name";
    this.chkNPR.AutoSize = true;
    this.chkNPR.Location = new Point(3, 2);
    this.chkNPR.Margin = new Padding(3, 2, 3, 2);
    this.chkNPR.Name = "chkNPR";
    this.chkNPR.Size = new Size(107, 17);
    this.chkNPR.TabIndex = 114;
    this.chkNPR.Text = "Non-Player Race";
    this.chkNPR.UseVisualStyleBackColor = true;
    this.chkNPR.CheckedChanged += new EventHandler(this.chkNPR_CheckedChanged);
    this.chkConv.AutoSize = true;
    this.chkConv.Location = new Point(3, 23);
    this.chkConv.Margin = new Padding(3, 2, 3, 2);
    this.chkConv.Name = "chkConv";
    this.chkConv.Size = new Size(125, 17);
    this.chkConv.TabIndex = 119;
    this.chkConv.Text = "Industrial (Low Tech)";
    this.chkConv.UseVisualStyleBackColor = true;
    this.chkConv.CheckedChanged += new EventHandler(this.chkNeutral_CheckedChanged);
    this.chkNeutral.AutoSize = true;
    this.chkNeutral.Location = new Point(3, 44);
    this.chkNeutral.Margin = new Padding(3, 2, 3, 2);
    this.chkNeutral.Name = "chkNeutral";
    this.chkNeutral.Size = new Size(89, 17);
    this.chkNeutral.TabIndex = 120;
    this.chkNeutral.Text = "Neutral Race";
    this.chkNeutral.UseVisualStyleBackColor = true;
    this.chkNeutral.CheckedChanged += new EventHandler(this.chkNeutral_CheckedChanged);
    this.flowLayoutPanel4.BorderStyle = BorderStyle.FixedSingle;
    this.flowLayoutPanel4.Controls.Add((Control) this.panel2);
    this.flowLayoutPanel4.Controls.Add((Control) this.panel1);
    this.flowLayoutPanel4.Controls.Add((Control) this.panel3);
    this.flowLayoutPanel4.Controls.Add((Control) this.panel4);
    this.flowLayoutPanel4.Controls.Add((Control) this.panel5);
    this.flowLayoutPanel4.FlowDirection = FlowDirection.TopDown;
    this.flowLayoutPanel4.Location = new Point(339, 3);
    this.flowLayoutPanel4.Name = "flowLayoutPanel4";
    this.flowLayoutPanel4.Size = new Size(330, 163);
    this.flowLayoutPanel4.TabIndex = 112 /*0x70*/;
    this.flowLayoutPanel4.WrapContents = false;
    this.panel2.Controls.Add((Control) this.cboSpecies);
    this.panel2.Controls.Add((Control) this.label17);
    this.panel2.Location = new Point(3, 3);
    this.panel2.Name = "panel2";
    this.panel2.Size = new Size(320, 22);
    this.panel2.TabIndex = 114;
    this.cboSpecies.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.cboSpecies.Dock = DockStyle.Right;
    this.cboSpecies.ForeColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192 /*0xC0*/);
    this.cboSpecies.FormattingEnabled = true;
    this.cboSpecies.Location = new Point(98, 0);
    this.cboSpecies.Margin = new Padding(3, 3, 3, 0);
    this.cboSpecies.Name = "cboSpecies";
    this.cboSpecies.Size = new Size(222, 21);
    this.cboSpecies.TabIndex = 112 /*0x70*/;
    this.cboSpecies.SelectedIndexChanged += new EventHandler(this.cboSpecies_SelectedIndexChanged);
    this.label17.AutoSize = true;
    this.label17.Location = new Point(6, 3);
    this.label17.Margin = new Padding(3);
    this.label17.Name = "label17";
    this.label17.Padding = new Padding(0, 3, 0, 0);
    this.label17.Size = new Size(45, 16 /*0x10*/);
    this.label17.TabIndex = 104;
    this.label17.Text = "Species";
    this.panel1.Controls.Add((Control) this.cboSystemTheme);
    this.panel1.Controls.Add((Control) this.label18);
    this.panel1.Location = new Point(3, 31 /*0x1F*/);
    this.panel1.Name = "panel1";
    this.panel1.Size = new Size(320, 22);
    this.panel1.TabIndex = 115;
    this.cboSystemTheme.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.cboSystemTheme.Dock = DockStyle.Right;
    this.cboSystemTheme.ForeColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192 /*0xC0*/);
    this.cboSystemTheme.FormattingEnabled = true;
    this.cboSystemTheme.Location = new Point(98, 0);
    this.cboSystemTheme.Margin = new Padding(3, 3, 3, 0);
    this.cboSystemTheme.Name = "cboSystemTheme";
    this.cboSystemTheme.Size = new Size(222, 21);
    this.cboSystemTheme.TabIndex = 112 /*0x70*/;
    this.label18.AutoSize = true;
    this.label18.Location = new Point(6, 3);
    this.label18.Margin = new Padding(3);
    this.label18.Name = "label18";
    this.label18.Padding = new Padding(0, 3, 0, 0);
    this.label18.Size = new Size(77, 16 /*0x10*/);
    this.label18.TabIndex = 104;
    this.label18.Text = "System Theme";
    this.panel3.Controls.Add((Control) this.cboClassTheme);
    this.panel3.Controls.Add((Control) this.label19);
    this.panel3.Location = new Point(3, 59);
    this.panel3.Name = "panel3";
    this.panel3.Size = new Size(320, 22);
    this.panel3.TabIndex = 116;
    this.cboClassTheme.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.cboClassTheme.Dock = DockStyle.Right;
    this.cboClassTheme.ForeColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192 /*0xC0*/);
    this.cboClassTheme.FormattingEnabled = true;
    this.cboClassTheme.Location = new Point(98, 0);
    this.cboClassTheme.Margin = new Padding(3, 3, 3, 0);
    this.cboClassTheme.Name = "cboClassTheme";
    this.cboClassTheme.Size = new Size(222, 21);
    this.cboClassTheme.TabIndex = 112 /*0x70*/;
    this.label19.AutoSize = true;
    this.label19.Location = new Point(6, 3);
    this.label19.Margin = new Padding(3);
    this.label19.Name = "label19";
    this.label19.Padding = new Padding(0, 3, 0, 0);
    this.label19.Size = new Size(68, 16 /*0x10*/);
    this.label19.TabIndex = 104;
    this.label19.Text = "Class Theme";
    this.panel4.Controls.Add((Control) this.cboRankTheme);
    this.panel4.Controls.Add((Control) this.label20);
    this.panel4.Location = new Point(3, 87);
    this.panel4.Name = "panel4";
    this.panel4.Size = new Size(320, 22);
    this.panel4.TabIndex = 117;
    this.cboRankTheme.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.cboRankTheme.Dock = DockStyle.Right;
    this.cboRankTheme.ForeColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192 /*0xC0*/);
    this.cboRankTheme.FormattingEnabled = true;
    this.cboRankTheme.Location = new Point(98, 0);
    this.cboRankTheme.Margin = new Padding(3, 3, 3, 0);
    this.cboRankTheme.Name = "cboRankTheme";
    this.cboRankTheme.Size = new Size(222, 21);
    this.cboRankTheme.TabIndex = 112 /*0x70*/;
    this.label20.AutoSize = true;
    this.label20.Location = new Point(6, 3);
    this.label20.Margin = new Padding(3);
    this.label20.Name = "label20";
    this.label20.Padding = new Padding(0, 3, 0, 0);
    this.label20.Size = new Size(69, 16 /*0x10*/);
    this.label20.TabIndex = 104;
    this.label20.Text = "Rank Theme";
    this.panel5.Controls.Add((Control) this.cboCommanderTheme);
    this.panel5.Controls.Add((Control) this.label21);
    this.panel5.Location = new Point(3, 115);
    this.panel5.Name = "panel5";
    this.panel5.Size = new Size(320, 22);
    this.panel5.TabIndex = 118;
    this.cboCommanderTheme.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.cboCommanderTheme.Dock = DockStyle.Right;
    this.cboCommanderTheme.ForeColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192 /*0xC0*/);
    this.cboCommanderTheme.FormattingEnabled = true;
    this.cboCommanderTheme.Location = new Point(98, 0);
    this.cboCommanderTheme.Margin = new Padding(3, 3, 3, 0);
    this.cboCommanderTheme.Name = "cboCommanderTheme";
    this.cboCommanderTheme.Size = new Size(222, 21);
    this.cboCommanderTheme.TabIndex = 112 /*0x70*/;
    this.label21.AutoSize = true;
    this.label21.Location = new Point(6, 3);
    this.label21.Margin = new Padding(3);
    this.label21.Name = "label21";
    this.label21.Padding = new Padding(0, 3, 0, 0);
    this.label21.Size = new Size(71, 16 /*0x10*/);
    this.label21.TabIndex = 104;
    this.label21.Text = "Name Theme";
    this.flowLayoutPanel6.BorderStyle = BorderStyle.FixedSingle;
    this.flowLayoutPanel6.Controls.Add((Control) this.panel14);
    this.flowLayoutPanel6.Controls.Add((Control) this.panel7);
    this.flowLayoutPanel6.Controls.Add((Control) this.panel8);
    this.flowLayoutPanel6.Controls.Add((Control) this.panel9);
    this.flowLayoutPanel6.Controls.Add((Control) this.panel10);
    this.flowLayoutPanel6.Controls.Add((Control) this.panel11);
    this.flowLayoutPanel6.Controls.Add((Control) this.panel12);
    this.flowLayoutPanel6.Controls.Add((Control) this.panel13);
    this.flowLayoutPanel6.Controls.Add((Control) this.panel17);
    this.flowLayoutPanel6.Controls.Add((Control) this.panel26);
    this.flowLayoutPanel6.Controls.Add((Control) this.panel27);
    this.flowLayoutPanel6.Controls.Add((Control) this.panel28);
    this.flowLayoutPanel6.Controls.Add((Control) this.panel36);
    this.flowLayoutPanel6.Controls.Add((Control) this.panel37);
    this.flowLayoutPanel6.Controls.Add((Control) this.panel38);
    this.flowLayoutPanel6.Controls.Add((Control) this.panel39);
    this.flowLayoutPanel6.Controls.Add((Control) this.panel40);
    this.flowLayoutPanel6.Controls.Add((Control) this.panel41);
    this.flowLayoutPanel6.Controls.Add((Control) this.panel42);
    this.flowLayoutPanel6.Controls.Add((Control) this.panel21);
    this.flowLayoutPanel6.Location = new Point(3, 372);
    this.flowLayoutPanel6.Name = "flowLayoutPanel6";
    this.flowLayoutPanel6.Size = new Size(330, 423);
    this.flowLayoutPanel6.TabIndex = 118;
    this.panel14.Controls.Add((Control) this.txtSpeciesName);
    this.panel14.Controls.Add((Control) this.label32);
    this.panel14.Location = new Point(3, 3);
    this.panel14.Name = "panel14";
    this.panel14.Size = new Size(320, 15);
    this.panel14.TabIndex = 125;
    this.txtSpeciesName.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.txtSpeciesName.BorderStyle = BorderStyle.None;
    this.txtSpeciesName.Dock = DockStyle.Right;
    this.txtSpeciesName.ForeColor = Color.FromArgb(128 /*0x80*/, (int) byte.MaxValue, 128 /*0x80*/);
    this.txtSpeciesName.Location = new Point(100, 0);
    this.txtSpeciesName.Name = "txtSpeciesName";
    this.txtSpeciesName.Size = new Size(220, 13);
    this.txtSpeciesName.TabIndex = 105;
    this.txtSpeciesName.Text = "Text";
    this.txtSpeciesName.TextAlign = HorizontalAlignment.Center;
    this.label32.AutoSize = true;
    this.label32.Dock = DockStyle.Left;
    this.label32.Location = new Point(0, 0);
    this.label32.Margin = new Padding(3);
    this.label32.Name = "label32";
    this.label32.Size = new Size(76, 13);
    this.label32.TabIndex = 104;
    this.label32.Text = "Species Name";
    this.panel7.Controls.Add((Control) this.txtGravity);
    this.panel7.Controls.Add((Control) this.label23);
    this.panel7.Location = new Point(3, 24);
    this.panel7.Name = "panel7";
    this.panel7.Size = new Size(320, 15);
    this.panel7.TabIndex = 118;
    this.txtGravity.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.txtGravity.BorderStyle = BorderStyle.None;
    this.txtGravity.Dock = DockStyle.Right;
    this.txtGravity.ForeColor = Color.FromArgb(128 /*0x80*/, (int) byte.MaxValue, 128 /*0x80*/);
    this.txtGravity.Location = new Point(240 /*0xF0*/, 0);
    this.txtGravity.Name = "txtGravity";
    this.txtGravity.Size = new Size(80 /*0x50*/, 13);
    this.txtGravity.TabIndex = 105;
    this.txtGravity.Text = "0";
    this.txtGravity.TextAlign = HorizontalAlignment.Center;
    this.label23.AutoSize = true;
    this.label23.Dock = DockStyle.Left;
    this.label23.Location = new Point(0, 0);
    this.label23.Margin = new Padding(3);
    this.label23.Name = "label23";
    this.label23.Size = new Size(83, 13);
    this.label23.TabIndex = 104;
    this.label23.Text = "Ideal Gravity (G)";
    this.panel8.Controls.Add((Control) this.txtTemp);
    this.panel8.Controls.Add((Control) this.label26);
    this.panel8.Location = new Point(3, 45);
    this.panel8.Name = "panel8";
    this.panel8.Size = new Size(320, 15);
    this.panel8.TabIndex = 119;
    this.txtTemp.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.txtTemp.BorderStyle = BorderStyle.None;
    this.txtTemp.Dock = DockStyle.Right;
    this.txtTemp.ForeColor = Color.FromArgb(128 /*0x80*/, (int) byte.MaxValue, 128 /*0x80*/);
    this.txtTemp.Location = new Point(240 /*0xF0*/, 0);
    this.txtTemp.Name = "txtTemp";
    this.txtTemp.Size = new Size(80 /*0x50*/, 13);
    this.txtTemp.TabIndex = 105;
    this.txtTemp.Text = "0";
    this.txtTemp.TextAlign = HorizontalAlignment.Center;
    this.label26.AutoSize = true;
    this.label26.Dock = DockStyle.Left;
    this.label26.Location = new Point(0, 0);
    this.label26.Margin = new Padding(3);
    this.label26.Name = "label26";
    this.label26.Size = new Size(109, 13);
    this.label26.TabIndex = 104;
    this.label26.Text = "Ideal Temperature (C)";
    this.panel9.Controls.Add((Control) this.txtOxygen);
    this.panel9.Controls.Add((Control) this.label27);
    this.panel9.Location = new Point(3, 66);
    this.panel9.Name = "panel9";
    this.panel9.Size = new Size(320, 15);
    this.panel9.TabIndex = 120;
    this.txtOxygen.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.txtOxygen.BorderStyle = BorderStyle.None;
    this.txtOxygen.Dock = DockStyle.Right;
    this.txtOxygen.ForeColor = Color.FromArgb(128 /*0x80*/, (int) byte.MaxValue, 128 /*0x80*/);
    this.txtOxygen.Location = new Point(240 /*0xF0*/, 0);
    this.txtOxygen.Name = "txtOxygen";
    this.txtOxygen.Size = new Size(80 /*0x50*/, 13);
    this.txtOxygen.TabIndex = 105;
    this.txtOxygen.Text = "0";
    this.txtOxygen.TextAlign = HorizontalAlignment.Center;
    this.label27.AutoSize = true;
    this.label27.Dock = DockStyle.Left;
    this.label27.Location = new Point(0, 0);
    this.label27.Margin = new Padding(3);
    this.label27.Name = "label27";
    this.label27.Size = new Size(139, 13);
    this.label27.TabIndex = 104;
    this.label27.Text = "Ideal Oxygen Pressure (atm)";
    this.panel10.Controls.Add((Control) this.txtPressure);
    this.panel10.Controls.Add((Control) this.label28);
    this.panel10.Location = new Point(3, 87);
    this.panel10.Name = "panel10";
    this.panel10.Size = new Size(320, 15);
    this.panel10.TabIndex = 121;
    this.txtPressure.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.txtPressure.BorderStyle = BorderStyle.None;
    this.txtPressure.Dock = DockStyle.Right;
    this.txtPressure.ForeColor = Color.FromArgb(128 /*0x80*/, (int) byte.MaxValue, 128 /*0x80*/);
    this.txtPressure.Location = new Point(240 /*0xF0*/, 0);
    this.txtPressure.Name = "txtPressure";
    this.txtPressure.Size = new Size(80 /*0x50*/, 13);
    this.txtPressure.TabIndex = 105;
    this.txtPressure.Text = "0";
    this.txtPressure.TextAlign = HorizontalAlignment.Center;
    this.label28.AutoSize = true;
    this.label28.Dock = DockStyle.Left;
    this.label28.Location = new Point(0, 0);
    this.label28.Margin = new Padding(3);
    this.label28.Name = "label28";
    this.label28.Size = new Size(182, 13);
    this.label28.TabIndex = 104;
    this.label28.Text = "Maximum Atmospheric Pressure (atm)";
    this.panel11.Controls.Add((Control) this.txtGravityDev);
    this.panel11.Controls.Add((Control) this.label29);
    this.panel11.Location = new Point(3, 108);
    this.panel11.Name = "panel11";
    this.panel11.Size = new Size(320, 15);
    this.panel11.TabIndex = 122;
    this.txtGravityDev.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.txtGravityDev.BorderStyle = BorderStyle.None;
    this.txtGravityDev.Dock = DockStyle.Right;
    this.txtGravityDev.ForeColor = Color.FromArgb(128 /*0x80*/, (int) byte.MaxValue, 128 /*0x80*/);
    this.txtGravityDev.Location = new Point(240 /*0xF0*/, 0);
    this.txtGravityDev.Name = "txtGravityDev";
    this.txtGravityDev.Size = new Size(80 /*0x50*/, 13);
    this.txtGravityDev.TabIndex = 105;
    this.txtGravityDev.Text = "0";
    this.txtGravityDev.TextAlign = HorizontalAlignment.Center;
    this.label29.AutoSize = true;
    this.label29.Dock = DockStyle.Left;
    this.label29.Location = new Point(0, 0);
    this.label29.Margin = new Padding(3);
    this.label29.Name = "label29";
    this.label29.Size = new Size(152, 13);
    this.label29.TabIndex = 104;
    this.label29.Text = "Maximum Gravity Deviation (G)";
    this.panel12.Controls.Add((Control) this.txtTempDev);
    this.panel12.Controls.Add((Control) this.label30);
    this.panel12.Location = new Point(3, 129);
    this.panel12.Name = "panel12";
    this.panel12.Size = new Size(320, 15);
    this.panel12.TabIndex = 123;
    this.txtTempDev.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.txtTempDev.BorderStyle = BorderStyle.None;
    this.txtTempDev.Dock = DockStyle.Right;
    this.txtTempDev.ForeColor = Color.FromArgb(128 /*0x80*/, (int) byte.MaxValue, 128 /*0x80*/);
    this.txtTempDev.Location = new Point(240 /*0xF0*/, 0);
    this.txtTempDev.Name = "txtTempDev";
    this.txtTempDev.Size = new Size(80 /*0x50*/, 13);
    this.txtTempDev.TabIndex = 105;
    this.txtTempDev.Text = "0";
    this.txtTempDev.TextAlign = HorizontalAlignment.Center;
    this.label30.AutoSize = true;
    this.label30.Dock = DockStyle.Left;
    this.label30.Location = new Point(0, 0);
    this.label30.Margin = new Padding(3);
    this.label30.Name = "label30";
    this.label30.Size = new Size(178, 13);
    this.label30.TabIndex = 104;
    this.label30.Text = "Maximum Temperature Deviation (C)";
    this.panel13.Controls.Add((Control) this.txtOxygenDev);
    this.panel13.Controls.Add((Control) this.label31);
    this.panel13.Location = new Point(3, 150);
    this.panel13.Name = "panel13";
    this.panel13.Size = new Size(320, 15);
    this.panel13.TabIndex = 124;
    this.txtOxygenDev.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.txtOxygenDev.BorderStyle = BorderStyle.None;
    this.txtOxygenDev.Dock = DockStyle.Right;
    this.txtOxygenDev.ForeColor = Color.FromArgb(128 /*0x80*/, (int) byte.MaxValue, 128 /*0x80*/);
    this.txtOxygenDev.Location = new Point(240 /*0xF0*/, 0);
    this.txtOxygenDev.Name = "txtOxygenDev";
    this.txtOxygenDev.Size = new Size(80 /*0x50*/, 13);
    this.txtOxygenDev.TabIndex = 105;
    this.txtOxygenDev.Text = "0";
    this.txtOxygenDev.TextAlign = HorizontalAlignment.Center;
    this.label31.AutoSize = true;
    this.label31.Dock = DockStyle.Left;
    this.label31.Location = new Point(0, 0);
    this.label31.Margin = new Padding(3);
    this.label31.Name = "label31";
    this.label31.Size = new Size(164, 13);
    this.label31.TabIndex = 104;
    this.label31.Text = "Maximum Oxygen Deviation (atm)";
    this.panel17.Controls.Add((Control) this.txtDensity);
    this.panel17.Controls.Add((Control) this.label1);
    this.panel17.Location = new Point(3, 171);
    this.panel17.Name = "panel17";
    this.panel17.Size = new Size(320, 15);
    this.panel17.TabIndex = 126;
    this.txtDensity.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.txtDensity.BorderStyle = BorderStyle.None;
    this.txtDensity.Dock = DockStyle.Right;
    this.txtDensity.ForeColor = Color.FromArgb(128 /*0x80*/, (int) byte.MaxValue, 128 /*0x80*/);
    this.txtDensity.Location = new Point(240 /*0xF0*/, 0);
    this.txtDensity.Name = "txtDensity";
    this.txtDensity.Size = new Size(80 /*0x50*/, 13);
    this.txtDensity.TabIndex = 105;
    this.txtDensity.Text = "0";
    this.txtDensity.TextAlign = HorizontalAlignment.Center;
    this.label1.AutoSize = true;
    this.label1.Dock = DockStyle.Left;
    this.label1.Location = new Point(0, 0);
    this.label1.Margin = new Padding(3);
    this.label1.Name = "label1";
    this.label1.Size = new Size(135, 13);
    this.label1.TabIndex = 104;
    this.label1.Text = "Population Density Modifier";
    this.panel26.Controls.Add((Control) this.txtGrowth);
    this.panel26.Controls.Add((Control) this.label10);
    this.panel26.Location = new Point(3, 192 /*0xC0*/);
    this.panel26.Name = "panel26";
    this.panel26.Size = new Size(320, 15);
    this.panel26.TabIndex = (int) sbyte.MaxValue;
    this.txtGrowth.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.txtGrowth.BorderStyle = BorderStyle.None;
    this.txtGrowth.Dock = DockStyle.Right;
    this.txtGrowth.ForeColor = Color.FromArgb(128 /*0x80*/, (int) byte.MaxValue, 128 /*0x80*/);
    this.txtGrowth.Location = new Point(240 /*0xF0*/, 0);
    this.txtGrowth.Name = "txtGrowth";
    this.txtGrowth.Size = new Size(80 /*0x50*/, 13);
    this.txtGrowth.TabIndex = 105;
    this.txtGrowth.Text = "0";
    this.txtGrowth.TextAlign = HorizontalAlignment.Center;
    this.label10.AutoSize = true;
    this.label10.Dock = DockStyle.Left;
    this.label10.Location = new Point(0, 0);
    this.label10.Margin = new Padding(3);
    this.label10.Name = "label10";
    this.label10.Size = new Size(134, 13);
    this.label10.TabIndex = 104;
    this.label10.Text = "Population Growth Modifier";
    this.panel27.Controls.Add((Control) this.txtResearch);
    this.panel27.Controls.Add((Control) this.label11);
    this.panel27.Location = new Point(3, 213);
    this.panel27.Name = "panel27";
    this.panel27.Size = new Size(320, 15);
    this.panel27.TabIndex = 128 /*0x80*/;
    this.txtResearch.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.txtResearch.BorderStyle = BorderStyle.None;
    this.txtResearch.Dock = DockStyle.Right;
    this.txtResearch.ForeColor = Color.FromArgb(128 /*0x80*/, (int) byte.MaxValue, 128 /*0x80*/);
    this.txtResearch.Location = new Point(240 /*0xF0*/, 0);
    this.txtResearch.Name = "txtResearch";
    this.txtResearch.Size = new Size(80 /*0x50*/, 13);
    this.txtResearch.TabIndex = 105;
    this.txtResearch.Text = "0";
    this.txtResearch.TextAlign = HorizontalAlignment.Center;
    this.label11.AutoSize = true;
    this.label11.Dock = DockStyle.Left;
    this.label11.Location = new Point(0, 0);
    this.label11.Margin = new Padding(3);
    this.label11.Name = "label11";
    this.label11.Size = new Size(119, 13);
    this.label11.TabIndex = 104;
    this.label11.Text = "Research Rate Modifier";
    this.panel28.Controls.Add((Control) this.txtProduction);
    this.panel28.Controls.Add((Control) this.label12);
    this.panel28.Location = new Point(3, 234);
    this.panel28.Name = "panel28";
    this.panel28.Size = new Size(320, 15);
    this.panel28.TabIndex = 129;
    this.txtProduction.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.txtProduction.BorderStyle = BorderStyle.None;
    this.txtProduction.Dock = DockStyle.Right;
    this.txtProduction.ForeColor = Color.FromArgb(128 /*0x80*/, (int) byte.MaxValue, 128 /*0x80*/);
    this.txtProduction.Location = new Point(240 /*0xF0*/, 0);
    this.txtProduction.Name = "txtProduction";
    this.txtProduction.Size = new Size(80 /*0x50*/, 13);
    this.txtProduction.TabIndex = 105;
    this.txtProduction.Text = "0";
    this.txtProduction.TextAlign = HorizontalAlignment.Center;
    this.label12.AutoSize = true;
    this.label12.Dock = DockStyle.Left;
    this.label12.Location = new Point(0, 0);
    this.label12.Margin = new Padding(3);
    this.label12.Name = "label12";
    this.label12.Size = new Size(136, 13);
    this.label12.TabIndex = 104;
    this.label12.Text = "Factory Production Modifier";
    this.panel36.Controls.Add((Control) this.txtDet);
    this.panel36.Controls.Add((Control) this.label36);
    this.panel36.Location = new Point(3, (int) byte.MaxValue);
    this.panel36.Name = "panel36";
    this.panel36.Size = new Size(320, 15);
    this.panel36.TabIndex = 130;
    this.txtDet.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.txtDet.BorderStyle = BorderStyle.None;
    this.txtDet.Dock = DockStyle.Right;
    this.txtDet.ForeColor = Color.FromArgb(128 /*0x80*/, (int) byte.MaxValue, 128 /*0x80*/);
    this.txtDet.Location = new Point(240 /*0xF0*/, 0);
    this.txtDet.Name = "txtDet";
    this.txtDet.Size = new Size(80 /*0x50*/, 13);
    this.txtDet.TabIndex = 105;
    this.txtDet.Text = "0";
    this.txtDet.TextAlign = HorizontalAlignment.Center;
    this.label36.AutoSize = true;
    this.label36.Dock = DockStyle.Left;
    this.label36.Location = new Point(0, 0);
    this.label36.Margin = new Padding(3);
    this.label36.Name = "label36";
    this.label36.Size = new Size(114, 13);
    this.label36.TabIndex = 104;
    this.label36.Text = "Determination (1 - 100)";
    this.panel37.Controls.Add((Control) this.txtDip);
    this.panel37.Controls.Add((Control) this.label37);
    this.panel37.Location = new Point(3, 276);
    this.panel37.Name = "panel37";
    this.panel37.Size = new Size(320, 15);
    this.panel37.TabIndex = 131;
    this.txtDip.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.txtDip.BorderStyle = BorderStyle.None;
    this.txtDip.Dock = DockStyle.Right;
    this.txtDip.ForeColor = Color.FromArgb(128 /*0x80*/, (int) byte.MaxValue, 128 /*0x80*/);
    this.txtDip.Location = new Point(240 /*0xF0*/, 0);
    this.txtDip.Name = "txtDip";
    this.txtDip.Size = new Size(80 /*0x50*/, 13);
    this.txtDip.TabIndex = 105;
    this.txtDip.Text = "0";
    this.txtDip.TextAlign = HorizontalAlignment.Center;
    this.label37.AutoSize = true;
    this.label37.Dock = DockStyle.Left;
    this.label37.Location = new Point(0, 0);
    this.label37.Margin = new Padding(3);
    this.label37.Name = "label37";
    this.label37.Size = new Size(98, 13);
    this.label37.TabIndex = 104;
    this.label37.Text = "Diplomacy (1 - 100)";
    this.panel38.Controls.Add((Control) this.txtExp);
    this.panel38.Controls.Add((Control) this.label38);
    this.panel38.Location = new Point(3, 297);
    this.panel38.Name = "panel38";
    this.panel38.Size = new Size(320, 15);
    this.panel38.TabIndex = 132;
    this.txtExp.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.txtExp.BorderStyle = BorderStyle.None;
    this.txtExp.Dock = DockStyle.Right;
    this.txtExp.ForeColor = Color.FromArgb(128 /*0x80*/, (int) byte.MaxValue, 128 /*0x80*/);
    this.txtExp.Location = new Point(240 /*0xF0*/, 0);
    this.txtExp.Name = "txtExp";
    this.txtExp.Size = new Size(80 /*0x50*/, 13);
    this.txtExp.TabIndex = 105;
    this.txtExp.Text = "0";
    this.txtExp.TextAlign = HorizontalAlignment.Center;
    this.label38.AutoSize = true;
    this.label38.Dock = DockStyle.Left;
    this.label38.Location = new Point(0, 0);
    this.label38.Margin = new Padding(3);
    this.label38.Name = "label38";
    this.label38.Size = new Size(98, 13);
    this.label38.TabIndex = 104;
    this.label38.Text = "Expansion (1 - 100)";
    this.panel39.Controls.Add((Control) this.txtMil);
    this.panel39.Controls.Add((Control) this.label39);
    this.panel39.Location = new Point(3, 318);
    this.panel39.Name = "panel39";
    this.panel39.Size = new Size(320, 15);
    this.panel39.TabIndex = 133;
    this.txtMil.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.txtMil.BorderStyle = BorderStyle.None;
    this.txtMil.Dock = DockStyle.Right;
    this.txtMil.ForeColor = Color.FromArgb(128 /*0x80*/, (int) byte.MaxValue, 128 /*0x80*/);
    this.txtMil.Location = new Point(240 /*0xF0*/, 0);
    this.txtMil.Name = "txtMil";
    this.txtMil.Size = new Size(80 /*0x50*/, 13);
    this.txtMil.TabIndex = 105;
    this.txtMil.Text = "0";
    this.txtMil.TextAlign = HorizontalAlignment.Center;
    this.label39.AutoSize = true;
    this.label39.Dock = DockStyle.Left;
    this.label39.Location = new Point(0, 0);
    this.label39.Margin = new Padding(3);
    this.label39.Name = "label39";
    this.label39.Size = new Size(90, 13);
    this.label39.TabIndex = 104;
    this.label39.Text = "Militancy (1 - 100)";
    this.panel40.Controls.Add((Control) this.txtTrade);
    this.panel40.Controls.Add((Control) this.label40);
    this.panel40.Location = new Point(3, 339);
    this.panel40.Name = "panel40";
    this.panel40.Size = new Size(320, 15);
    this.panel40.TabIndex = 134;
    this.txtTrade.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.txtTrade.BorderStyle = BorderStyle.None;
    this.txtTrade.Dock = DockStyle.Right;
    this.txtTrade.ForeColor = Color.FromArgb(128 /*0x80*/, (int) byte.MaxValue, 128 /*0x80*/);
    this.txtTrade.Location = new Point(240 /*0xF0*/, 0);
    this.txtTrade.Name = "txtTrade";
    this.txtTrade.Size = new Size(80 /*0x50*/, 13);
    this.txtTrade.TabIndex = 105;
    this.txtTrade.Text = "0";
    this.txtTrade.TextAlign = HorizontalAlignment.Center;
    this.label40.AutoSize = true;
    this.label40.Dock = DockStyle.Left;
    this.label40.Location = new Point(0, 0);
    this.label40.Margin = new Padding(3);
    this.label40.Name = "label40";
    this.label40.Size = new Size(77, 13);
    this.label40.TabIndex = 104;
    this.label40.Text = "Trade (1 - 100)";
    this.panel41.Controls.Add((Control) this.txtTrans);
    this.panel41.Controls.Add((Control) this.label41);
    this.panel41.Location = new Point(3, 360);
    this.panel41.Name = "panel41";
    this.panel41.Size = new Size(320, 15);
    this.panel41.TabIndex = 135;
    this.txtTrans.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.txtTrans.BorderStyle = BorderStyle.None;
    this.txtTrans.Dock = DockStyle.Right;
    this.txtTrans.ForeColor = Color.FromArgb(128 /*0x80*/, (int) byte.MaxValue, 128 /*0x80*/);
    this.txtTrans.Location = new Point(240 /*0xF0*/, 0);
    this.txtTrans.Name = "txtTrans";
    this.txtTrans.Size = new Size(80 /*0x50*/, 13);
    this.txtTrans.TabIndex = 105;
    this.txtTrans.Text = "0";
    this.txtTrans.TextAlign = HorizontalAlignment.Center;
    this.label41.AutoSize = true;
    this.label41.Dock = DockStyle.Left;
    this.label41.Location = new Point(0, 0);
    this.label41.Margin = new Padding(3);
    this.label41.Name = "label41";
    this.label41.Size = new Size(110, 13);
    this.label41.TabIndex = 104;
    this.label41.Text = "Translation (-25 to 25)";
    this.panel42.Controls.Add((Control) this.txtXen);
    this.panel42.Controls.Add((Control) this.label42);
    this.panel42.Location = new Point(3, 381);
    this.panel42.Name = "panel42";
    this.panel42.Size = new Size(320, 15);
    this.panel42.TabIndex = 136;
    this.txtXen.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.txtXen.BorderStyle = BorderStyle.None;
    this.txtXen.Dock = DockStyle.Right;
    this.txtXen.ForeColor = Color.FromArgb(128 /*0x80*/, (int) byte.MaxValue, 128 /*0x80*/);
    this.txtXen.Location = new Point(240 /*0xF0*/, 0);
    this.txtXen.Name = "txtXen";
    this.txtXen.Size = new Size(80 /*0x50*/, 13);
    this.txtXen.TabIndex = 105;
    this.txtXen.Text = "0";
    this.txtXen.TextAlign = HorizontalAlignment.Center;
    this.label42.AutoSize = true;
    this.label42.Dock = DockStyle.Left;
    this.label42.Location = new Point(0, 0);
    this.label42.Margin = new Padding(3);
    this.label42.Name = "label42";
    this.label42.Size = new Size(106, 13);
    this.label42.TabIndex = 104;
    this.label42.Text = "Xenophobia (1 - 100)";
    this.flowLayoutPanel1.BorderStyle = BorderStyle.FixedSingle;
    this.flowLayoutPanel1.Controls.Add((Control) this.panel18);
    this.flowLayoutPanel1.Controls.Add((Control) this.panel22);
    this.flowLayoutPanel1.Controls.Add((Control) this.panel23);
    this.flowLayoutPanel1.Controls.Add((Control) this.panel24);
    this.flowLayoutPanel1.Controls.Add((Control) this.panel29);
    this.flowLayoutPanel1.Controls.Add((Control) this.panel30);
    this.flowLayoutPanel1.Controls.Add((Control) this.panel31);
    this.flowLayoutPanel1.Controls.Add((Control) this.panel25);
    this.flowLayoutPanel1.Controls.Add((Control) this.panel32);
    this.flowLayoutPanel1.Controls.Add((Control) this.panel33);
    this.flowLayoutPanel1.Controls.Add((Control) this.panel20);
    this.flowLayoutPanel1.Controls.Add((Control) this.panel34);
    this.flowLayoutPanel1.Controls.Add((Control) this.panel35);
    this.flowLayoutPanel1.Controls.Add((Control) this.panel45);
    this.flowLayoutPanel1.Controls.Add((Control) this.panel46);
    this.flowLayoutPanel1.Controls.Add((Control) this.panel43);
    this.flowLayoutPanel1.Controls.Add((Control) this.panel44);
    this.flowLayoutPanel1.Controls.Add((Control) this.panel19);
    this.flowLayoutPanel1.Controls.Add((Control) this.panel47);
    this.flowLayoutPanel1.Location = new Point(339, 372);
    this.flowLayoutPanel1.Name = "flowLayoutPanel1";
    this.flowLayoutPanel1.Size = new Size(330, 423);
    this.flowLayoutPanel1.TabIndex = 119;
    this.panel18.Controls.Add((Control) this.txtPopulation);
    this.panel18.Controls.Add((Control) this.label2);
    this.panel18.Location = new Point(3, 3);
    this.panel18.Name = "panel18";
    this.panel18.Size = new Size(320, 15);
    this.panel18.TabIndex = 118;
    this.txtPopulation.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.txtPopulation.BorderStyle = BorderStyle.None;
    this.txtPopulation.Dock = DockStyle.Right;
    this.txtPopulation.ForeColor = Color.FromArgb(128 /*0x80*/, (int) byte.MaxValue, 128 /*0x80*/);
    this.txtPopulation.Location = new Point(240 /*0xF0*/, 0);
    this.txtPopulation.Name = "txtPopulation";
    this.txtPopulation.Size = new Size(80 /*0x50*/, 13);
    this.txtPopulation.TabIndex = 105;
    this.txtPopulation.Text = "0";
    this.txtPopulation.TextAlign = HorizontalAlignment.Center;
    this.txtPopulation.TextChanged += new EventHandler(this.txtPopulation_TextChanged);
    this.label2.AutoSize = true;
    this.label2.Dock = DockStyle.Left;
    this.label2.Location = new Point(0, 0);
    this.label2.Margin = new Padding(3);
    this.label2.Name = "label2";
    this.label2.Size = new Size(74, 13);
    this.label2.TabIndex = 104;
    this.label2.Text = "Population (m)";
    this.panel22.Controls.Add((Control) this.txtSY);
    this.panel22.Controls.Add((Control) this.label6);
    this.panel22.Location = new Point(3, 24);
    this.panel22.Name = "panel22";
    this.panel22.Size = new Size(320, 15);
    this.panel22.TabIndex = 122;
    this.txtSY.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.txtSY.BorderStyle = BorderStyle.None;
    this.txtSY.Dock = DockStyle.Right;
    this.txtSY.ForeColor = Color.FromArgb(128 /*0x80*/, (int) byte.MaxValue, 128 /*0x80*/);
    this.txtSY.Location = new Point(240 /*0xF0*/, 0);
    this.txtSY.Name = "txtSY";
    this.txtSY.Size = new Size(80 /*0x50*/, 13);
    this.txtSY.TabIndex = 105;
    this.txtSY.Text = "1";
    this.txtSY.TextAlign = HorizontalAlignment.Center;
    this.label6.AutoSize = true;
    this.label6.Dock = DockStyle.Left;
    this.label6.Location = new Point(0, 0);
    this.label6.Margin = new Padding(3);
    this.label6.Name = "label6";
    this.label6.Size = new Size(53, 13);
    this.label6.TabIndex = 104;
    this.label6.Text = "Shipyards";
    this.panel23.Controls.Add((Control) this.txtRL);
    this.panel23.Controls.Add((Control) this.label7);
    this.panel23.Location = new Point(3, 45);
    this.panel23.Name = "panel23";
    this.panel23.Size = new Size(320, 15);
    this.panel23.TabIndex = 123;
    this.txtRL.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.txtRL.BorderStyle = BorderStyle.None;
    this.txtRL.Dock = DockStyle.Right;
    this.txtRL.ForeColor = Color.FromArgb(128 /*0x80*/, (int) byte.MaxValue, 128 /*0x80*/);
    this.txtRL.Location = new Point(240 /*0xF0*/, 0);
    this.txtRL.Name = "txtRL";
    this.txtRL.Size = new Size(80 /*0x50*/, 13);
    this.txtRL.TabIndex = 105;
    this.txtRL.Text = "0";
    this.txtRL.TextAlign = HorizontalAlignment.Center;
    this.label7.AutoSize = true;
    this.label7.Dock = DockStyle.Left;
    this.label7.Location = new Point(0, 0);
    this.label7.Margin = new Padding(3);
    this.label7.Name = "label7";
    this.label7.Size = new Size(96 /*0x60*/, 13);
    this.label7.TabIndex = 104;
    this.label7.Text = "Research Facilities";
    this.panel24.Controls.Add((Control) this.txtCF);
    this.panel24.Controls.Add((Control) this.label8);
    this.panel24.Location = new Point(3, 66);
    this.panel24.Name = "panel24";
    this.panel24.Size = new Size(320, 15);
    this.panel24.TabIndex = 124;
    this.txtCF.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.txtCF.BorderStyle = BorderStyle.None;
    this.txtCF.Dock = DockStyle.Right;
    this.txtCF.ForeColor = Color.FromArgb(128 /*0x80*/, (int) byte.MaxValue, 128 /*0x80*/);
    this.txtCF.Location = new Point(240 /*0xF0*/, 0);
    this.txtCF.Name = "txtCF";
    this.txtCF.Size = new Size(80 /*0x50*/, 13);
    this.txtCF.TabIndex = 105;
    this.txtCF.Text = "0";
    this.txtCF.TextAlign = HorizontalAlignment.Center;
    this.label8.AutoSize = true;
    this.label8.Dock = DockStyle.Left;
    this.label8.Location = new Point(0, 0);
    this.label8.Margin = new Padding(3);
    this.label8.Name = "label8";
    this.label8.Size = new Size(109, 13);
    this.label8.TabIndex = 104;
    this.label8.Text = "Conventional Industry";
    this.panel29.Controls.Add((Control) this.txtConst);
    this.panel29.Controls.Add((Control) this.label13);
    this.panel29.Location = new Point(3, 87);
    this.panel29.Name = "panel29";
    this.panel29.Size = new Size(320, 15);
    this.panel29.TabIndex = 126;
    this.txtConst.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.txtConst.BorderStyle = BorderStyle.None;
    this.txtConst.Dock = DockStyle.Right;
    this.txtConst.ForeColor = Color.FromArgb(128 /*0x80*/, (int) byte.MaxValue, 128 /*0x80*/);
    this.txtConst.Location = new Point(240 /*0xF0*/, 0);
    this.txtConst.Name = "txtConst";
    this.txtConst.Size = new Size(80 /*0x50*/, 13);
    this.txtConst.TabIndex = 105;
    this.txtConst.Text = "0";
    this.txtConst.TextAlign = HorizontalAlignment.Center;
    this.label13.AutoSize = true;
    this.label13.Dock = DockStyle.Left;
    this.label13.Location = new Point(0, 0);
    this.label13.Margin = new Padding(3);
    this.label13.Name = "label13";
    this.label13.Size = new Size(112 /*0x70*/, 13);
    this.label13.TabIndex = 104;
    this.label13.Text = "Construction Factories";
    this.panel30.Controls.Add((Control) this.txtOF);
    this.panel30.Controls.Add((Control) this.label14);
    this.panel30.Location = new Point(3, 108);
    this.panel30.Name = "panel30";
    this.panel30.Size = new Size(320, 15);
    this.panel30.TabIndex = (int) sbyte.MaxValue;
    this.txtOF.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.txtOF.BorderStyle = BorderStyle.None;
    this.txtOF.Dock = DockStyle.Right;
    this.txtOF.ForeColor = Color.FromArgb(128 /*0x80*/, (int) byte.MaxValue, 128 /*0x80*/);
    this.txtOF.Location = new Point(240 /*0xF0*/, 0);
    this.txtOF.Name = "txtOF";
    this.txtOF.Size = new Size(80 /*0x50*/, 13);
    this.txtOF.TabIndex = 105;
    this.txtOF.Text = "0";
    this.txtOF.TextAlign = HorizontalAlignment.Center;
    this.label14.AutoSize = true;
    this.label14.Dock = DockStyle.Left;
    this.label14.Location = new Point(0, 0);
    this.label14.Margin = new Padding(3);
    this.label14.Name = "label14";
    this.label14.Size = new Size(100, 13);
    this.label14.TabIndex = 104;
    this.label14.Text = "Ordnance Factories";
    this.panel31.Controls.Add((Control) this.txtFF);
    this.panel31.Controls.Add((Control) this.label15);
    this.panel31.Location = new Point(3, 129);
    this.panel31.Name = "panel31";
    this.panel31.Size = new Size(320, 15);
    this.panel31.TabIndex = 128 /*0x80*/;
    this.txtFF.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.txtFF.BorderStyle = BorderStyle.None;
    this.txtFF.Dock = DockStyle.Right;
    this.txtFF.ForeColor = Color.FromArgb(128 /*0x80*/, (int) byte.MaxValue, 128 /*0x80*/);
    this.txtFF.Location = new Point(240 /*0xF0*/, 0);
    this.txtFF.Name = "txtFF";
    this.txtFF.Size = new Size(80 /*0x50*/, 13);
    this.txtFF.TabIndex = 105;
    this.txtFF.Text = "0";
    this.txtFF.TextAlign = HorizontalAlignment.Center;
    this.label15.AutoSize = true;
    this.label15.Dock = DockStyle.Left;
    this.label15.Location = new Point(0, 0);
    this.label15.Margin = new Padding(3);
    this.label15.Name = "label15";
    this.label15.Size = new Size(85, 13);
    this.label15.TabIndex = 104;
    this.label15.Text = "Fighter Factories";
    this.panel25.Controls.Add((Control) this.txtMines);
    this.panel25.Controls.Add((Control) this.label9);
    this.panel25.Location = new Point(3, 150);
    this.panel25.Name = "panel25";
    this.panel25.Size = new Size(320, 15);
    this.panel25.TabIndex = 125;
    this.txtMines.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.txtMines.BorderStyle = BorderStyle.None;
    this.txtMines.Dock = DockStyle.Right;
    this.txtMines.ForeColor = Color.FromArgb(128 /*0x80*/, (int) byte.MaxValue, 128 /*0x80*/);
    this.txtMines.Location = new Point(240 /*0xF0*/, 0);
    this.txtMines.Name = "txtMines";
    this.txtMines.Size = new Size(80 /*0x50*/, 13);
    this.txtMines.TabIndex = 105;
    this.txtMines.Text = "0";
    this.txtMines.TextAlign = HorizontalAlignment.Center;
    this.label9.AutoSize = true;
    this.label9.Dock = DockStyle.Left;
    this.label9.Location = new Point(0, 0);
    this.label9.Margin = new Padding(3);
    this.label9.Name = "label9";
    this.label9.Size = new Size(35, 13);
    this.label9.TabIndex = 104;
    this.label9.Text = "Mines";
    this.panel32.Controls.Add((Control) this.txtAM);
    this.panel32.Controls.Add((Control) this.label16);
    this.panel32.Location = new Point(3, 171);
    this.panel32.Name = "panel32";
    this.panel32.Size = new Size(320, 15);
    this.panel32.TabIndex = 129;
    this.txtAM.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.txtAM.BorderStyle = BorderStyle.None;
    this.txtAM.Dock = DockStyle.Right;
    this.txtAM.ForeColor = Color.FromArgb(128 /*0x80*/, (int) byte.MaxValue, 128 /*0x80*/);
    this.txtAM.Location = new Point(240 /*0xF0*/, 0);
    this.txtAM.Name = "txtAM";
    this.txtAM.Size = new Size(80 /*0x50*/, 13);
    this.txtAM.TabIndex = 105;
    this.txtAM.Text = "0";
    this.txtAM.TextAlign = HorizontalAlignment.Center;
    this.label16.AutoSize = true;
    this.label16.Dock = DockStyle.Left;
    this.label16.Location = new Point(0, 0);
    this.label16.Margin = new Padding(3);
    this.label16.Name = "label16";
    this.label16.Size = new Size(89, 13);
    this.label16.TabIndex = 104;
    this.label16.Text = "Automated Mines";
    this.panel33.Controls.Add((Control) this.txtFR);
    this.panel33.Controls.Add((Control) this.label33);
    this.panel33.Location = new Point(3, 192 /*0xC0*/);
    this.panel33.Name = "panel33";
    this.panel33.Size = new Size(320, 15);
    this.panel33.TabIndex = 130;
    this.txtFR.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.txtFR.BorderStyle = BorderStyle.None;
    this.txtFR.Dock = DockStyle.Right;
    this.txtFR.ForeColor = Color.FromArgb(128 /*0x80*/, (int) byte.MaxValue, 128 /*0x80*/);
    this.txtFR.Location = new Point(240 /*0xF0*/, 0);
    this.txtFR.Name = "txtFR";
    this.txtFR.Size = new Size(80 /*0x50*/, 13);
    this.txtFR.TabIndex = 105;
    this.txtFR.Text = "0";
    this.txtFR.TextAlign = HorizontalAlignment.Center;
    this.label33.AutoSize = true;
    this.label33.Dock = DockStyle.Left;
    this.label33.Location = new Point(0, 0);
    this.label33.Margin = new Padding(3);
    this.label33.Name = "label33";
    this.label33.Size = new Size(77, 13);
    this.label33.TabIndex = 104;
    this.label33.Text = "Fuel Refineries";
    this.panel20.Controls.Add((Control) this.txtFC);
    this.panel20.Controls.Add((Control) this.label4);
    this.panel20.Location = new Point(3, 213);
    this.panel20.Name = "panel20";
    this.panel20.Size = new Size(320, 15);
    this.panel20.TabIndex = 139;
    this.txtFC.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.txtFC.BorderStyle = BorderStyle.None;
    this.txtFC.Dock = DockStyle.Right;
    this.txtFC.ForeColor = Color.FromArgb(128 /*0x80*/, (int) byte.MaxValue, 128 /*0x80*/);
    this.txtFC.Location = new Point(240 /*0xF0*/, 0);
    this.txtFC.Name = "txtFC";
    this.txtFC.Size = new Size(80 /*0x50*/, 13);
    this.txtFC.TabIndex = 105;
    this.txtFC.Text = "0";
    this.txtFC.TextAlign = HorizontalAlignment.Center;
    this.label4.AutoSize = true;
    this.label4.Dock = DockStyle.Left;
    this.label4.Location = new Point(0, 0);
    this.label4.Margin = new Padding(3);
    this.label4.Name = "label4";
    this.label4.Size = new Size(88, 13);
    this.label4.TabIndex = 104;
    this.label4.Text = "Financial Centres";
    this.panel34.Controls.Add((Control) this.txtMF);
    this.panel34.Controls.Add((Control) this.label34);
    this.panel34.Location = new Point(3, 234);
    this.panel34.Name = "panel34";
    this.panel34.Size = new Size(320, 15);
    this.panel34.TabIndex = 131;
    this.txtMF.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.txtMF.BorderStyle = BorderStyle.None;
    this.txtMF.Dock = DockStyle.Right;
    this.txtMF.ForeColor = Color.FromArgb(128 /*0x80*/, (int) byte.MaxValue, 128 /*0x80*/);
    this.txtMF.Location = new Point(240 /*0xF0*/, 0);
    this.txtMF.Name = "txtMF";
    this.txtMF.Size = new Size(80 /*0x50*/, 13);
    this.txtMF.TabIndex = 105;
    this.txtMF.Text = "0";
    this.txtMF.TextAlign = HorizontalAlignment.Center;
    this.label34.AutoSize = true;
    this.label34.Dock = DockStyle.Left;
    this.label34.Location = new Point(0, 0);
    this.label34.Margin = new Padding(3);
    this.label34.Name = "label34";
    this.label34.Size = new Size(112 /*0x70*/, 13);
    this.label34.TabIndex = 104;
    this.label34.Text = "Maintenance Facilities";
    this.panel35.Controls.Add((Control) this.txtGF);
    this.panel35.Controls.Add((Control) this.label35);
    this.panel35.Location = new Point(3, (int) byte.MaxValue);
    this.panel35.Name = "panel35";
    this.panel35.Size = new Size(320, 15);
    this.panel35.TabIndex = 132;
    this.txtGF.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.txtGF.BorderStyle = BorderStyle.None;
    this.txtGF.Dock = DockStyle.Right;
    this.txtGF.ForeColor = Color.FromArgb(128 /*0x80*/, (int) byte.MaxValue, 128 /*0x80*/);
    this.txtGF.Location = new Point(240 /*0xF0*/, 0);
    this.txtGF.Name = "txtGF";
    this.txtGF.Size = new Size(80 /*0x50*/, 13);
    this.txtGF.TabIndex = 105;
    this.txtGF.Text = "0";
    this.txtGF.TextAlign = HorizontalAlignment.Center;
    this.label35.AutoSize = true;
    this.label35.Dock = DockStyle.Left;
    this.label35.Location = new Point(0, 0);
    this.label35.Margin = new Padding(3);
    this.label35.Name = "label35";
    this.label35.Size = new Size(188, 13);
    this.label35.TabIndex = 104;
    this.label35.Text = "Ground Force Construction Complexes";
    this.panel45.Controls.Add((Control) this.txtDSTS);
    this.panel45.Controls.Add((Control) this.label45);
    this.panel45.Location = new Point(3, 276);
    this.panel45.Name = "panel45";
    this.panel45.Size = new Size(320, 15);
    this.panel45.TabIndex = 135;
    this.txtDSTS.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.txtDSTS.BorderStyle = BorderStyle.None;
    this.txtDSTS.Dock = DockStyle.Right;
    this.txtDSTS.ForeColor = Color.FromArgb(128 /*0x80*/, (int) byte.MaxValue, 128 /*0x80*/);
    this.txtDSTS.Location = new Point(240 /*0xF0*/, 0);
    this.txtDSTS.Name = "txtDSTS";
    this.txtDSTS.Size = new Size(80 /*0x50*/, 13);
    this.txtDSTS.TabIndex = 105;
    this.txtDSTS.Text = "0";
    this.txtDSTS.TextAlign = HorizontalAlignment.Center;
    this.label45.AutoSize = true;
    this.label45.Dock = DockStyle.Left;
    this.label45.Location = new Point(0, 0);
    this.label45.Margin = new Padding(3);
    this.label45.Name = "label45";
    this.label45.Size = new Size(153, 13);
    this.label45.TabIndex = 104;
    this.label45.Text = "Deep Space Tracking Stations";
    this.panel46.Controls.Add((Control) this.txtMA);
    this.panel46.Controls.Add((Control) this.label46);
    this.panel46.Location = new Point(3, 297);
    this.panel46.Name = "panel46";
    this.panel46.Size = new Size(320, 15);
    this.panel46.TabIndex = 136;
    this.txtMA.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.txtMA.BorderStyle = BorderStyle.None;
    this.txtMA.Dock = DockStyle.Right;
    this.txtMA.ForeColor = Color.FromArgb(128 /*0x80*/, (int) byte.MaxValue, 128 /*0x80*/);
    this.txtMA.Location = new Point(240 /*0xF0*/, 0);
    this.txtMA.Name = "txtMA";
    this.txtMA.Size = new Size(80 /*0x50*/, 13);
    this.txtMA.TabIndex = 105;
    this.txtMA.Text = "0";
    this.txtMA.TextAlign = HorizontalAlignment.Center;
    this.label46.AutoSize = true;
    this.label46.Dock = DockStyle.Left;
    this.label46.Location = new Point(0, 0);
    this.label46.Margin = new Padding(3);
    this.label46.Name = "label46";
    this.label46.Size = new Size(94, 13);
    this.label46.TabIndex = 104;
    this.label46.Text = "Military Academies";
    this.panel43.Controls.Add((Control) this.txtFuel);
    this.panel43.Controls.Add((Control) this.label43);
    this.panel43.Location = new Point(3, 318);
    this.panel43.Name = "panel43";
    this.panel43.Size = new Size(320, 15);
    this.panel43.TabIndex = 133;
    this.txtFuel.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.txtFuel.BorderStyle = BorderStyle.None;
    this.txtFuel.Dock = DockStyle.Right;
    this.txtFuel.ForeColor = Color.FromArgb(128 /*0x80*/, (int) byte.MaxValue, 128 /*0x80*/);
    this.txtFuel.Location = new Point(240 /*0xF0*/, 0);
    this.txtFuel.Name = "txtFuel";
    this.txtFuel.Size = new Size(80 /*0x50*/, 13);
    this.txtFuel.TabIndex = 105;
    this.txtFuel.Text = "0";
    this.txtFuel.TextAlign = HorizontalAlignment.Center;
    this.label43.AutoSize = true;
    this.label43.Dock = DockStyle.Left;
    this.label43.Location = new Point(0, 0);
    this.label43.Margin = new Padding(3);
    this.label43.Name = "label43";
    this.label43.Size = new Size(104, 13);
    this.label43.TabIndex = 104;
    this.label43.Text = "Fuel Stockpile (litres)";
    this.panel44.Controls.Add((Control) this.txtMSP);
    this.panel44.Controls.Add((Control) this.label44);
    this.panel44.Location = new Point(3, 339);
    this.panel44.Name = "panel44";
    this.panel44.Size = new Size(320, 15);
    this.panel44.TabIndex = 134;
    this.txtMSP.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.txtMSP.BorderStyle = BorderStyle.None;
    this.txtMSP.Dock = DockStyle.Right;
    this.txtMSP.ForeColor = Color.FromArgb(128 /*0x80*/, (int) byte.MaxValue, 128 /*0x80*/);
    this.txtMSP.Location = new Point(240 /*0xF0*/, 0);
    this.txtMSP.Name = "txtMSP";
    this.txtMSP.Size = new Size(80 /*0x50*/, 13);
    this.txtMSP.TabIndex = 105;
    this.txtMSP.Text = "0";
    this.txtMSP.TextAlign = HorizontalAlignment.Center;
    this.label44.AutoSize = true;
    this.label44.Dock = DockStyle.Left;
    this.label44.Location = new Point(0, 0);
    this.label44.Margin = new Padding(3);
    this.label44.Name = "label44";
    this.label44.Size = new Size(148, 13);
    this.label44.TabIndex = 104;
    this.label44.Text = "Maintenance Stockpile (MSP)";
    this.panel19.Controls.Add((Control) this.txtTP);
    this.panel19.Controls.Add((Control) this.label3);
    this.panel19.Location = new Point(3, 360);
    this.panel19.Name = "panel19";
    this.panel19.Size = new Size(320, 15);
    this.panel19.TabIndex = 137;
    this.txtTP.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.txtTP.BorderStyle = BorderStyle.None;
    this.txtTP.Dock = DockStyle.Right;
    this.txtTP.ForeColor = Color.FromArgb(128 /*0x80*/, (int) byte.MaxValue, 128 /*0x80*/);
    this.txtTP.Location = new Point(240 /*0xF0*/, 0);
    this.txtTP.Name = "txtTP";
    this.txtTP.Size = new Size(80 /*0x50*/, 13);
    this.txtTP.TabIndex = 105;
    this.txtTP.Text = "0";
    this.txtTP.TextAlign = HorizontalAlignment.Center;
    this.txtTP.Leave += new EventHandler(this.txtTP_Leave);
    this.label3.AutoSize = true;
    this.label3.Dock = DockStyle.Left;
    this.label3.Location = new Point(0, 0);
    this.label3.Margin = new Padding(3);
    this.label3.Name = "label3";
    this.label3.Size = new Size(103, 13);
    this.label3.TabIndex = 104;
    this.label3.Text = "Starting Tech Points";
    this.panel47.Controls.Add((Control) this.txtSBP);
    this.panel47.Controls.Add((Control) this.label47);
    this.panel47.Location = new Point(3, 381);
    this.panel47.Name = "panel47";
    this.panel47.Size = new Size(320, 15);
    this.panel47.TabIndex = 138;
    this.txtSBP.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.txtSBP.BorderStyle = BorderStyle.None;
    this.txtSBP.Dock = DockStyle.Right;
    this.txtSBP.ForeColor = Color.FromArgb(128 /*0x80*/, (int) byte.MaxValue, 128 /*0x80*/);
    this.txtSBP.Location = new Point(240 /*0xF0*/, 0);
    this.txtSBP.Name = "txtSBP";
    this.txtSBP.Size = new Size(80 /*0x50*/, 13);
    this.txtSBP.TabIndex = 105;
    this.txtSBP.Text = "0";
    this.txtSBP.TextAlign = HorizontalAlignment.Center;
    this.label47.AutoSize = true;
    this.label47.Dock = DockStyle.Left;
    this.label47.Location = new Point(0, 0);
    this.label47.Margin = new Padding(3);
    this.label47.Name = "label47";
    this.label47.Size = new Size(125, 13);
    this.label47.TabIndex = 104;
    this.label47.Text = "Starting Ship Build Points";
    this.cmdCreate.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.cmdCreate.ForeColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192 /*0xC0*/);
    this.cmdCreate.Location = new Point(9, 806);
    this.cmdCreate.Margin = new Padding(0);
    this.cmdCreate.Name = "cmdCreate";
    this.cmdCreate.Size = new Size(95, 30);
    this.cmdCreate.TabIndex = 132;
    this.cmdCreate.Tag = (object) "1200";
    this.cmdCreate.Text = "Create Race";
    this.cmdCreate.UseVisualStyleBackColor = false;
    this.cmdCreate.Click += new EventHandler(this.cmdCreate_Click);
    this.cmdCancel.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.cmdCancel.ForeColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192 /*0xC0*/);
    this.cmdCancel.Location = new Point(580, 806);
    this.cmdCancel.Margin = new Padding(0);
    this.cmdCancel.Name = "cmdCancel";
    this.cmdCancel.Size = new Size(96 /*0x60*/, 30);
    this.cmdCancel.TabIndex = 133;
    this.cmdCancel.Tag = (object) "1200";
    this.cmdCancel.Text = "Cancel";
    this.cmdCancel.UseVisualStyleBackColor = false;
    this.cmdCancel.Click += new EventHandler(this.cmdCancel_Click);
    this.pbRace.Anchor = AnchorStyles.None;
    this.pbRace.BorderStyle = BorderStyle.FixedSingle;
    this.pbRace.Location = new Point(0, 0);
    this.pbRace.Margin = new Padding(0);
    this.pbRace.Name = "pbRace";
    this.pbRace.Size = new Size(240 /*0xF0*/, 194);
    this.pbRace.SizeMode = PictureBoxSizeMode.StretchImage;
    this.pbRace.TabIndex = 134;
    this.pbRace.TabStop = false;
    this.flowLayoutPanel2.BorderStyle = BorderStyle.FixedSingle;
    this.flowLayoutPanel2.Controls.Add((Control) this.chkNPR);
    this.flowLayoutPanel2.Controls.Add((Control) this.chkConv);
    this.flowLayoutPanel2.Controls.Add((Control) this.chkNeutral);
    this.flowLayoutPanel2.Controls.Add((Control) this.chkAutoAssign);
    this.flowLayoutPanel2.Controls.Add((Control) this.chkAutoDesignGround);
    this.flowLayoutPanel2.Controls.Add((Control) this.chkAutoCreate);
    this.flowLayoutPanel2.Controls.Add((Control) this.chkSurveyGeo);
    this.flowLayoutPanel2.Controls.Add((Control) this.chkSurveyGrav);
    this.flowLayoutPanel2.FlowDirection = FlowDirection.TopDown;
    this.flowLayoutPanel2.Location = new Point(3, 77);
    this.flowLayoutPanel2.Name = "flowLayoutPanel2";
    this.flowLayoutPanel2.Size = new Size(330, 89);
    this.flowLayoutPanel2.TabIndex = 135;
    this.chkAutoAssign.AutoSize = true;
    this.chkAutoAssign.Location = new Point(3, 65);
    this.chkAutoAssign.Margin = new Padding(3, 2, 3, 2);
    this.chkAutoAssign.Name = "chkAutoAssign";
    this.chkAutoAssign.Size = new Size(142, 17);
    this.chkAutoAssign.TabIndex = 122;
    this.chkAutoAssign.Text = "Auto-Assign Tech Points";
    this.chkAutoAssign.UseVisualStyleBackColor = true;
    this.chkAutoAssign.CheckedChanged += new EventHandler(this.chkAutoAssign_CheckedChanged);
    this.chkAutoDesignGround.AutoSize = true;
    this.chkAutoDesignGround.Location = new Point(151, 2);
    this.chkAutoDesignGround.Margin = new Padding(3, 2, 3, 2);
    this.chkAutoDesignGround.Name = "chkAutoDesignGround";
    this.chkAutoDesignGround.Size = new Size(157, 17);
    this.chkAutoDesignGround.TabIndex = 125;
    this.chkAutoDesignGround.Text = "Auto-Design Ground Forces";
    this.chkAutoDesignGround.UseVisualStyleBackColor = true;
    this.chkAutoDesignGround.CheckedChanged += new EventHandler(this.chkAutoDesignGround_CheckedChanged);
    this.chkAutoCreate.AutoSize = true;
    this.chkAutoCreate.Location = new Point(151, 23);
    this.chkAutoCreate.Margin = new Padding(3, 2, 3, 2);
    this.chkAutoCreate.Name = "chkAutoCreate";
    this.chkAutoCreate.Size = new Size(147, 17);
    this.chkAutoCreate.TabIndex = 123;
    this.chkAutoCreate.Text = "Auto-Design Ship Classes";
    this.chkAutoCreate.UseVisualStyleBackColor = true;
    this.chkAutoCreate.CheckedChanged += new EventHandler(this.chkAutoCreate_CheckedChanged);
    this.chkSurveyGeo.AutoSize = true;
    this.chkSurveyGeo.Location = new Point(151, 44);
    this.chkSurveyGeo.Margin = new Padding(3, 2, 3, 2);
    this.chkSurveyGeo.Name = "chkSurveyGeo";
    this.chkSurveyGeo.Size = new Size(162, 17);
    this.chkSurveyGeo.TabIndex = 121;
    this.chkSurveyGeo.Text = "Home System Geo Surveyed";
    this.chkSurveyGeo.UseVisualStyleBackColor = true;
    this.chkSurveyGeo.CheckedChanged += new EventHandler(this.chkSurveyGeo_CheckedChanged);
    this.chkSurveyGrav.AutoSize = true;
    this.chkSurveyGrav.Location = new Point(151, 65);
    this.chkSurveyGrav.Margin = new Padding(3, 2, 3, 2);
    this.chkSurveyGrav.Name = "chkSurveyGrav";
    this.chkSurveyGrav.Size = new Size(165, 17);
    this.chkSurveyGrav.TabIndex = 124;
    this.chkSurveyGrav.Text = "Home System Grav Surveyed";
    this.chkSurveyGrav.UseVisualStyleBackColor = true;
    this.flowLayoutPanel3.Controls.Add((Control) this.flowLayoutPanel10);
    this.flowLayoutPanel3.Controls.Add((Control) this.flowLayoutPanel2);
    this.flowLayoutPanel3.Controls.Add((Control) this.flowLayoutPanel5);
    this.flowLayoutPanel3.Controls.Add((Control) this.flowLayoutPanel6);
    this.flowLayoutPanel3.Controls.Add((Control) this.flowLayoutPanel4);
    this.flowLayoutPanel3.Controls.Add((Control) this.pbFlag);
    this.flowLayoutPanel3.Controls.Add((Control) this.flowLayoutPanel1);
    this.flowLayoutPanel3.Controls.Add((Control) this.pictureBox1);
    this.flowLayoutPanel3.FlowDirection = FlowDirection.TopDown;
    this.flowLayoutPanel3.Location = new Point(6, 6);
    this.flowLayoutPanel3.Margin = new Padding(0);
    this.flowLayoutPanel3.Name = "flowLayoutPanel3";
    this.flowLayoutPanel3.Size = new Size(674, 800);
    this.flowLayoutPanel3.TabIndex = 136;
    this.flowLayoutPanel5.Controls.Add((Control) this.pbRace);
    this.flowLayoutPanel5.Controls.Add((Control) this.flowLayoutPanel7);
    this.flowLayoutPanel5.Location = new Point(3, 172);
    this.flowLayoutPanel5.Name = "flowLayoutPanel5";
    this.flowLayoutPanel5.Size = new Size(330, 194);
    this.flowLayoutPanel5.TabIndex = 140;
    this.flowLayoutPanel7.Controls.Add((Control) this.pbShip);
    this.flowLayoutPanel7.Controls.Add((Control) this.pbStation);
    this.flowLayoutPanel7.Location = new Point(243, 3);
    this.flowLayoutPanel7.Name = "flowLayoutPanel7";
    this.flowLayoutPanel7.Size = new Size(84, 179);
    this.flowLayoutPanel7.TabIndex = 142;
    this.pbShip.Anchor = AnchorStyles.None;
    this.pbShip.BorderStyle = BorderStyle.FixedSingle;
    this.pbShip.Location = new Point(3, 6);
    this.pbShip.Margin = new Padding(3, 6, 0, 6);
    this.pbShip.Name = "pbShip";
    this.pbShip.Size = new Size(80 /*0x50*/, 80 /*0x50*/);
    this.pbShip.SizeMode = PictureBoxSizeMode.Zoom;
    this.pbShip.TabIndex = 141;
    this.pbShip.TabStop = false;
    this.pbStation.Anchor = AnchorStyles.None;
    this.pbStation.BorderStyle = BorderStyle.FixedSingle;
    this.pbStation.Location = new Point(3, 98);
    this.pbStation.Margin = new Padding(3, 6, 0, 0);
    this.pbStation.Name = "pbStation";
    this.pbStation.Size = new Size(80 /*0x50*/, 80 /*0x50*/);
    this.pbStation.SizeMode = PictureBoxSizeMode.Zoom;
    this.pbStation.TabIndex = 140;
    this.pbStation.TabStop = false;
    this.pbFlag.Anchor = AnchorStyles.None;
    this.pbFlag.BackgroundImageLayout = ImageLayout.None;
    this.pbFlag.BorderStyle = BorderStyle.FixedSingle;
    this.pbFlag.Location = new Point(339, 172);
    this.pbFlag.Name = "pbFlag";
    this.pbFlag.Size = new Size(330, 194);
    this.pbFlag.SizeMode = PictureBoxSizeMode.StretchImage;
    this.pbFlag.TabIndex = 136;
    this.pbFlag.TabStop = false;
    this.pictureBox1.Anchor = AnchorStyles.None;
    this.pictureBox1.BorderStyle = BorderStyle.FixedSingle;
    this.pictureBox1.Location = new Point(675, 3);
    this.pictureBox1.Name = "pictureBox1";
    this.pictureBox1.Size = new Size(58, 76);
    this.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
    this.pictureBox1.TabIndex = 137;
    this.pictureBox1.TabStop = false;
    this.cmdSpeciesImage.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.cmdSpeciesImage.ForeColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192 /*0xC0*/);
    this.cmdSpeciesImage.Location = new Point(199, 806);
    this.cmdSpeciesImage.Margin = new Padding(0);
    this.cmdSpeciesImage.Name = "cmdSpeciesImage";
    this.cmdSpeciesImage.Size = new Size(95, 30);
    this.cmdSpeciesImage.TabIndex = 137;
    this.cmdSpeciesImage.Tag = (object) "1200";
    this.cmdSpeciesImage.Text = "Change Image";
    this.cmdSpeciesImage.UseVisualStyleBackColor = false;
    this.cmdSpeciesImage.Click += new EventHandler(this.cmdSpeciesImage_Click);
    this.cmdRaceFlag.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.cmdRaceFlag.ForeColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192 /*0xC0*/);
    this.cmdRaceFlag.Location = new Point(104, 806);
    this.cmdRaceFlag.Margin = new Padding(0);
    this.cmdRaceFlag.Name = "cmdRaceFlag";
    this.cmdRaceFlag.Size = new Size(95, 30);
    this.cmdRaceFlag.TabIndex = 138;
    this.cmdRaceFlag.Tag = (object) "1200";
    this.cmdRaceFlag.Text = "Change Flag";
    this.cmdRaceFlag.UseVisualStyleBackColor = false;
    this.cmdRaceFlag.Click += new EventHandler(this.cmdRaceFlag_Click);
    this.cmdRandomName.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.cmdRandomName.ForeColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192 /*0xC0*/);
    this.cmdRandomName.Location = new Point(484, 806);
    this.cmdRandomName.Margin = new Padding(0);
    this.cmdRandomName.Name = "cmdRandomName";
    this.cmdRandomName.Size = new Size(96 /*0x60*/, 30);
    this.cmdRandomName.TabIndex = 139;
    this.cmdRandomName.Tag = (object) "1200";
    this.cmdRandomName.Text = "Random Name";
    this.cmdRandomName.UseVisualStyleBackColor = false;
    this.cmdRandomName.Click += new EventHandler(this.cmdRandomName_Click);
    this.cmdHull.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.cmdHull.ForeColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192 /*0xC0*/);
    this.cmdHull.Location = new Point(294, 806);
    this.cmdHull.Margin = new Padding(0);
    this.cmdHull.Name = "cmdHull";
    this.cmdHull.Size = new Size(95, 30);
    this.cmdHull.TabIndex = 140;
    this.cmdHull.Tag = (object) "1200";
    this.cmdHull.Text = "Change Hull";
    this.cmdHull.UseVisualStyleBackColor = false;
    this.cmdHull.Click += new EventHandler(this.cmdHull_Click);
    this.cmdStation.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.cmdStation.ForeColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192 /*0xC0*/);
    this.cmdStation.Location = new Point(389, 806);
    this.cmdStation.Margin = new Padding(0);
    this.cmdStation.Name = "cmdStation";
    this.cmdStation.Size = new Size(95, 30);
    this.cmdStation.TabIndex = 141;
    this.cmdStation.Tag = (object) "1200";
    this.cmdStation.Text = "Change Station";
    this.cmdStation.UseVisualStyleBackColor = false;
    this.cmdStation.Click += new EventHandler(this.cmdStation_Click);
    this.panel21.Controls.Add((Control) this.txtGraduationAge);
    this.panel21.Controls.Add((Control) this.label5);
    this.panel21.Location = new Point(3, 402);
    this.panel21.Name = "panel21";
    this.panel21.Size = new Size(320, 15);
    this.panel21.TabIndex = 137;
    this.txtGraduationAge.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.txtGraduationAge.BorderStyle = BorderStyle.None;
    this.txtGraduationAge.Dock = DockStyle.Right;
    this.txtGraduationAge.ForeColor = Color.FromArgb(128 /*0x80*/, (int) byte.MaxValue, 128 /*0x80*/);
    this.txtGraduationAge.Location = new Point(240 /*0xF0*/, 0);
    this.txtGraduationAge.Name = "txtGraduationAge";
    this.txtGraduationAge.Size = new Size(80 /*0x50*/, 13);
    this.txtGraduationAge.TabIndex = 105;
    this.txtGraduationAge.Text = "21";
    this.txtGraduationAge.TextAlign = HorizontalAlignment.Center;
    this.label5.AutoSize = true;
    this.label5.Dock = DockStyle.Left;
    this.label5.Location = new Point(0, 0);
    this.label5.Margin = new Padding(3);
    this.label5.Name = "label5";
    this.label5.Size = new Size(115, 13);
    this.label5.TabIndex = 104;
    this.label5.Text = "Officer Graduation Age";
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.ClientSize = new Size(685, 840);
    this.Controls.Add((Control) this.cmdStation);
    this.Controls.Add((Control) this.cmdHull);
    this.Controls.Add((Control) this.cmdRandomName);
    this.Controls.Add((Control) this.cmdRaceFlag);
    this.Controls.Add((Control) this.cmdSpeciesImage);
    this.Controls.Add((Control) this.flowLayoutPanel3);
    this.Controls.Add((Control) this.cmdCancel);
    this.Controls.Add((Control) this.cmdCreate);
    this.ForeColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192 /*0xC0*/);
    this.FormBorderStyle = FormBorderStyle.FixedSingle;
    this.Name = nameof (RaceCreation);
    this.Text = "Create New Race";
    this.FormClosing += new FormClosingEventHandler(this.RaceCreation_FormClosing);
    this.Load += new EventHandler(this.RaceCreation_Load);
    this.flowLayoutPanel10.ResumeLayout(false);
    this.panel6.ResumeLayout(false);
    this.panel6.PerformLayout();
    this.panel15.ResumeLayout(false);
    this.panel15.PerformLayout();
    this.panel16.ResumeLayout(false);
    this.panel16.PerformLayout();
    this.flowLayoutPanel4.ResumeLayout(false);
    this.panel2.ResumeLayout(false);
    this.panel2.PerformLayout();
    this.panel1.ResumeLayout(false);
    this.panel1.PerformLayout();
    this.panel3.ResumeLayout(false);
    this.panel3.PerformLayout();
    this.panel4.ResumeLayout(false);
    this.panel4.PerformLayout();
    this.panel5.ResumeLayout(false);
    this.panel5.PerformLayout();
    this.flowLayoutPanel6.ResumeLayout(false);
    this.panel14.ResumeLayout(false);
    this.panel14.PerformLayout();
    this.panel7.ResumeLayout(false);
    this.panel7.PerformLayout();
    this.panel8.ResumeLayout(false);
    this.panel8.PerformLayout();
    this.panel9.ResumeLayout(false);
    this.panel9.PerformLayout();
    this.panel10.ResumeLayout(false);
    this.panel10.PerformLayout();
    this.panel11.ResumeLayout(false);
    this.panel11.PerformLayout();
    this.panel12.ResumeLayout(false);
    this.panel12.PerformLayout();
    this.panel13.ResumeLayout(false);
    this.panel13.PerformLayout();
    this.panel17.ResumeLayout(false);
    this.panel17.PerformLayout();
    this.panel26.ResumeLayout(false);
    this.panel26.PerformLayout();
    this.panel27.ResumeLayout(false);
    this.panel27.PerformLayout();
    this.panel28.ResumeLayout(false);
    this.panel28.PerformLayout();
    this.panel36.ResumeLayout(false);
    this.panel36.PerformLayout();
    this.panel37.ResumeLayout(false);
    this.panel37.PerformLayout();
    this.panel38.ResumeLayout(false);
    this.panel38.PerformLayout();
    this.panel39.ResumeLayout(false);
    this.panel39.PerformLayout();
    this.panel40.ResumeLayout(false);
    this.panel40.PerformLayout();
    this.panel41.ResumeLayout(false);
    this.panel41.PerformLayout();
    this.panel42.ResumeLayout(false);
    this.panel42.PerformLayout();
    this.flowLayoutPanel1.ResumeLayout(false);
    this.panel18.ResumeLayout(false);
    this.panel18.PerformLayout();
    this.panel22.ResumeLayout(false);
    this.panel22.PerformLayout();
    this.panel23.ResumeLayout(false);
    this.panel23.PerformLayout();
    this.panel24.ResumeLayout(false);
    this.panel24.PerformLayout();
    this.panel29.ResumeLayout(false);
    this.panel29.PerformLayout();
    this.panel30.ResumeLayout(false);
    this.panel30.PerformLayout();
    this.panel31.ResumeLayout(false);
    this.panel31.PerformLayout();
    this.panel25.ResumeLayout(false);
    this.panel25.PerformLayout();
    this.panel32.ResumeLayout(false);
    this.panel32.PerformLayout();
    this.panel33.ResumeLayout(false);
    this.panel33.PerformLayout();
    this.panel20.ResumeLayout(false);
    this.panel20.PerformLayout();
    this.panel34.ResumeLayout(false);
    this.panel34.PerformLayout();
    this.panel35.ResumeLayout(false);
    this.panel35.PerformLayout();
    this.panel45.ResumeLayout(false);
    this.panel45.PerformLayout();
    this.panel46.ResumeLayout(false);
    this.panel46.PerformLayout();
    this.panel43.ResumeLayout(false);
    this.panel43.PerformLayout();
    this.panel44.ResumeLayout(false);
    this.panel44.PerformLayout();
    this.panel19.ResumeLayout(false);
    this.panel19.PerformLayout();
    this.panel47.ResumeLayout(false);
    this.panel47.PerformLayout();
    ((ISupportInitialize) this.pbRace).EndInit();
    this.flowLayoutPanel2.ResumeLayout(false);
    this.flowLayoutPanel2.PerformLayout();
    this.flowLayoutPanel3.ResumeLayout(false);
    this.flowLayoutPanel5.ResumeLayout(false);
    this.flowLayoutPanel7.ResumeLayout(false);
    ((ISupportInitialize) this.pbShip).EndInit();
    ((ISupportInitialize) this.pbStation).EndInit();
    ((ISupportInitialize) this.pbFlag).EndInit();
    ((ISupportInitialize) this.pictureBox1).EndInit();
    this.panel21.ResumeLayout(false);
    this.panel21.PerformLayout();
    this.ResumeLayout(false);
  }
}
