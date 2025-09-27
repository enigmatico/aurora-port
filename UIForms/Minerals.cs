// Decompiled with JetBrains decompiler
// Type: Minerals
// Assembly: Aurora, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAB8E3AD-3A24-426F-849E-98EC2E2DD9EB
// Assembly location: C:\Users\jinhoon.kim\Desktop\Aurora250Full\Dedot\aurora-deop.exe

using Aurora;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
public class Minerals : Form
{
    #region CompilerGenerated

    [CompilerGenerated]
    private sealed class Class1080
    {
        public GClass194 gclass194_0;
        public ParsedDecimal gclass208_0;
        public ParsedDecimal gclass208_1;
        public AuroraElement auroraElement_0;
        public Minerals minerals_0;

        internal bool method_0(SystemBodyData gclass1_0)
        {
            return gclass1_0.Gravity <= this.gclass194_0.double_8;
        }

        internal bool method_1(SystemBodyData gclass1_0)
        {
            return gclass1_0.Radius * 2.0 <= (double)this.gclass208_0.Value;
        }

        internal bool method_2(SystemBodyData gclass1_0)
        {
            return gclass1_0.Gravity >= (double)this.gclass208_1.Value;
        }

        internal Decimal method_3(SystemBodyData gclass1_0)
        {
            return gclass1_0.dictionary_2[this.auroraElement_0];
        }
    }

    [CompilerGenerated]
    private sealed class Class1081
    {
        public List<SystemData200> list_0;

        internal bool method_0(SystemBodyData gclass1_0)
        {
            return !this.list_0.Contains(gclass1_0.SystemData);
        }
    }

    [CompilerGenerated]
    private sealed class Class1082
    {
        public List<SystemData200> list_0;

        internal bool method_0(SystemBodyData gclass1_0)
        {
            return !this.list_0.Contains(gclass1_0.SystemData);
        }
    }

    [CompilerGenerated]
    private sealed class Class1083
    {
        public Decimal decimal_0;

        internal bool method_0(SystemBodyData gclass1_0)
        {
            return gclass1_0.MaxColonyCost <= this.decimal_0;
        }

        internal bool method_1(SystemBodyData gclass1_0)
        {
            return gclass1_0.ColonyCost <= this.decimal_0;
        }
    }

    [CompilerGenerated]
    private sealed class Class1084
    {
        public SystemBodyData gclass1_0;
        public Minerals.Class1080 class1080_0;

        internal bool method_0(PopulationData gclass146_0)
        {
            return gclass146_0.RaceData == this.class1080_0.minerals_0.gclass21_0 &&
                   gclass146_0.SystemBodyData == this.gclass1_0;
        }
    }

    #endregion

    private GClass0 gclass0_0;
    private GameRace gclass21_0;
    private RacialSystemSurvey gclass202_0;
    private TacticalMap tacticalMap_0;
    private bool bool_0;
    private IContainer icontainer_0;
    private ListView lstvMinerals;
    private ColumnHeader columnHeader_0;
    private ColumnHeader columnHeader_1;
    private ColumnHeader columnHeader_2;
    private ColumnHeader columnHeader_3;
    private ColumnHeader columnHeader_4;
    private ColumnHeader columnHeader_5;
    private ComboBox cboRaces;
    private FlowLayoutPanel flowLayoutPanel1;
    private TextBox txtDuranium;
    private ColumnHeader columnHeader_6;
    private ComboBox cboSpecies;
    private TextBox txtDuraniumAcc;
    private TextBox txtNeutronium;
    private TextBox txtNeutroniumAcc;
    private TextBox txtCorbomite;
    private TextBox txtCorbomiteAcc;
    private TextBox txtTritanium;
    private TextBox txtTritaniumAcc;
    private TextBox txtBoronide;
    private TextBox txtBoronideAcc;
    private TextBox txtMercassium;
    private TextBox txtMercassiumAcc;
    private TextBox txtVendarite;
    private TextBox txtVendariteAcc;
    private TextBox txtSorium;
    private TextBox txtSoriumAcc;
    private TextBox txtUridium;
    private TextBox txtUridiumAcc;
    private TextBox txtCorundium;
    private TextBox txtCorundiumAcc;
    private TextBox txtGallicite;
    private TextBox txtGalliciteAcc;
    private FlowLayoutPanel flowLayoutPanel2;
    private TextBox textBox1;
    private TextBox textBox2;
    private TextBox textBox3;
    private TextBox textBox4;
    private TextBox textBox5;
    private TextBox textBox6;
    private TextBox textBox7;
    private TextBox textBox8;
    private TextBox textBox9;
    private TextBox textBox10;
    private TextBox textBox11;
    private TextBox textBox12;
    private TextBox textBox13;
    private TextBox textBox14;
    private TextBox textBox15;
    private TextBox textBox16;
    private TextBox textBox17;
    private TextBox textBox18;
    private TextBox textBox19;
    private TextBox textBox20;
    private TextBox textBox21;
    private TextBox textBox22;
    private ColumnHeader columnHeader_7;
    private ColumnHeader columnHeader_8;
    private ColumnHeader columnHeader_9;
    private ColumnHeader columnHeader_10;
    private ColumnHeader columnHeader_11;
    private ColumnHeader columnHeader_12;
    private ColumnHeader columnHeader_13;
    private ColumnHeader columnHeader_14;
    private ColumnHeader columnHeader_15;
    private ColumnHeader columnHeader_16;
    private ColumnHeader columnHeader_17;
    private ColumnHeader columnHeader_18;
    private ColumnHeader columnHeader_19;
    private ColumnHeader columnHeader_20;
    private ColumnHeader columnHeader_21;
    private ColumnHeader columnHeader_22;
    private ColumnHeader columnHeader_23;
    private ColumnHeader columnHeader_24;
    private Button cmdSearch;
    private CheckBox chkExcludeHighG;
    private FlowLayoutPanel flowLayoutPanel3;
    private TextBox txtColonyCost;
    private TextBox textBox23;
    private FlowLayoutPanel flowLayoutPanel4;
    private RadioButton rdoIncludeGG;
    private RadioButton rdoExcludeGG;
    private RadioButton rdoGGOnly;
    private FlowLayoutPanel flowLayoutPanel5;
    private RadioButton rdoIncludeAst;
    private RadioButton rdoExcludeAst;
    private RadioButton rdoAstOnly;
    private CheckBox chkExcludeAlien;
    private FlowLayoutPanel flpMineralSearch;
    private Button cmdCreate;
    private Button cmdClear;
    private FlowLayoutPanel flowLayoutPanel7;
    private ComboBox cboSystems;
    private CheckBox chkColonyCost;
    private CheckBox chkCentreOnBody;
    private CheckBox chkOMEligible;
    private CheckBox chkSearchFlag;
    private CheckBox chkUseMaxCC;
    private Button cmdSuperWide;
    private ListView lstvMineralsWide;
    private ColumnHeader columnHeader_25;
    private ColumnHeader columnHeader_26;
    private ColumnHeader columnHeader_27;
    private ColumnHeader columnHeader_28;
    private ColumnHeader columnHeader_29;
    private ColumnHeader columnHeader_30;
    private ColumnHeader columnHeader_31;
    private ColumnHeader columnHeader_32;
    private ColumnHeader columnHeader_33;
    private ColumnHeader columnHeader_34;
    private ColumnHeader columnHeader_35;
    private ColumnHeader columnHeader_36;
    private ColumnHeader columnHeader_37;
    private ColumnHeader columnHeader_38;
    private ColumnHeader columnHeader_39;
    private ColumnHeader columnHeader_40;
    private ColumnHeader columnHeader_41;
    private ColumnHeader columnHeader_42;
    private ColumnHeader columnHeader_43;
    private ColumnHeader columnHeader_44;
    private ColumnHeader columnHeader_45;
    private ColumnHeader columnHeader_46;
    private ColumnHeader columnHeader_47;
    private ColumnHeader columnHeader_48;
    private ColumnHeader columnHeader_49;
    private ColumnHeader columnHeader_50;
    private ColumnHeader columnHeader_51;
    private ColumnHeader columnHeader_52;
    private ColumnHeader columnHeader_53;
    private CheckBox chkHabColour;
    private ColumnHeader columnHeader_54;
    private FlowLayoutPanel flpWideStats;
    private TextBox textBox24;
    private TextBox textBox25;
    private TextBox textBox26;
    private TextBox textBox27;
    private TextBox textBox28;
    private FlowLayoutPanel flpTopLevel;
    private FlowLayoutPanel flowLayoutPanel6;
    private TextBox textBox29;
    private TextBox textBox30;
    private TextBox txtMaxDiameter;
    private TextBox txtMinGravity;
    private CheckBox chkCentreOnSystem;

    public Minerals(GClass0 gclass0_1, TacticalMap tacticalMap_1)
    {
        this.gclass0_0 = gclass0_1;
        this.tacticalMap_0 = tacticalMap_1;
        this.InitializeComponent();
    }

    private void Minerals_FormClosing(object sender, FormClosingEventArgs e)
    {
        try
        {
            this.gclass0_0.method_512(this.Name, this.Left, this.Top);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2021);
        }
    }

    public void method_0()
    {
        try
        {
            if (this.cmdSuperWide.Text == "Normal View")
            {
                this.method_1(true);
                this.cmdSuperWide.Text = "Wide View";
                this.gclass0_0.bool_19 = false;
            }
            else
            {
                this.method_1(false);
                this.cmdSuperWide.Text = "Normal View";
                this.gclass0_0.bool_19 = true;
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3766);
        }
    }

    private void method_1(bool bool_1)
    {
        try
        {
            if (bool_1)
            {
                this.Width = 1440;
                this.flpWideStats.Width = 0;
                this.flpMineralSearch.BorderStyle = BorderStyle.FixedSingle;
                this.flpTopLevel.BorderStyle = BorderStyle.None;
                this.lstvMinerals.Visible = true;
                this.lstvMineralsWide.Visible = false;
            }
            else
            {
                this.Width = 1856;
                this.flpWideStats.Width = 420;
                this.flpMineralSearch.BorderStyle = BorderStyle.None;
                this.flpTopLevel.BorderStyle = BorderStyle.FixedSingle;
                this.lstvMinerals.Visible = false;
                this.lstvMineralsWide.Visible = true;
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3767);
        }
    }

    private void Minerals_Load(object sender, EventArgs e)
    {
        try
        {
            WindowPosition207 gclass207 = this.gclass0_0.method_513(this.Name);
            this.Left = gclass207.Left;
            this.Top = gclass207.Top;
            this.gclass0_0.bool_9 = true;
            this.bool_0 = true;
            this.gclass0_0.method_577(this.cboRaces);
            this.gclass0_0.bool_9 = false;
            if (this.gclass0_0.bool_19)
            {
                this.method_0();
            }
            else
            {
                this.method_1(true);
                this.cmdSuperWide.Text = "Wide View";
                this.gclass0_0.bool_19 = false;
            }

            this.method_3();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2022);
        }
    }

    public void method_2(GameRace gclass21_1)
    {
        try
        {
            this.bool_0 = true;
            this.cboRaces.SelectedItem = gclass21_1;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2023);
        }
    }

    private void cboRaces_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            this.gclass21_0 = (GameRace)this.cboRaces.SelectedValue;
            GClass194 gclass194 = this.gclass21_0.method_164();
            this.gclass21_0.method_260(this.cboSpecies);
            this.cboSpecies.SelectedItem = gclass194;
            this.method_3();
            if (!this.bool_0)
                this.gclass0_0.method_511(this.gclass21_0, this);
            this.bool_0 = false;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2024);
        }
    }

    private void method_3()
    {
        try
        {
            if (this.gclass0_0.bool_9)
                return;
            this.gclass0_0.bool_9 = true;
            List<RacialSystemSurvey> source = this.gclass21_0.method_321();
            source.Add(new RacialSystemSurvey(this.gclass0_0)
            {
                Name = "All",
                int_36 = -1
            });
            List<RacialSystemSurvey> list = source.OrderBy<RacialSystemSurvey, int>(gclass202_0 => gclass202_0.int_36)
                .ThenBy<RacialSystemSurvey, string>(gclass202_0 => gclass202_0.Name).ToList<RacialSystemSurvey>();
            this.cboSystems.DisplayMember = "Name";
            this.cboSystems.DataSource = list;
            this.gclass0_0.bool_9 = false;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2025);
        }
    }

    private void method_4()
    {
        try
        {
            // ISSUE: object of a compiler-generated type is created
            // ISSUE: variable of a compiler-generated type
            Minerals.Class1080 class1080 = new Minerals.Class1080();
            // ISSUE: reference to a compiler-generated field
            class1080.minerals_0 = this;
            ListView listView = this.lstvMinerals;
            if (this.lstvMineralsWide.Visible)
                listView = this.lstvMineralsWide;
            listView.Items.Clear();
            if (this.gclass21_0 == null || this.cboSpecies.SelectedValue == null)
                return;
            this.gclass202_0 = (RacialSystemSurvey)this.cboSystems.SelectedValue;
            // ISSUE: reference to a compiler-generated field
            class1080.gclass194_0 = (GClass194)this.cboSpecies.SelectedValue;
            Decimal decimal_1_1 = 0M;
            Decimal decimal_1_2 = 0M;
            Decimal decimal_1_3 = 0M;
            Decimal decimal_1_4 = 0M;
            Decimal decimal_1_5 = 0M;
            Decimal decimal_1_6 = 0M;
            Decimal decimal_1_7 = 0M;
            Decimal decimal_1_8 = 0M;
            Decimal decimal_1_9 = 0M;
            Decimal decimal_1_10 = 0M;
            Decimal decimal_1_11 = 0M;
            Decimal num1 = 0.1M;
            Decimal num2 = 0.1M;
            Decimal num3 = 0.1M;
            Decimal num4 = 0.1M;
            Decimal num5 = 0.1M;
            Decimal num6 = 0.1M;
            Decimal num7 = 0.1M;
            Decimal num8 = 0.1M;
            Decimal num9 = 0.1M;
            Decimal num10 = 0.1M;
            Decimal num11 = 0.1M;
            ParsedDecimal gclass208_1 = AuroraUtils.ParseDecimalString(this.txtDuranium.Text);
            ParsedDecimal gclass208_2 = AuroraUtils.ParseDecimalString(this.txtNeutronium.Text);
            ParsedDecimal gclass208_3 = AuroraUtils.ParseDecimalString(this.txtCorbomite.Text);
            ParsedDecimal gclass208_4 = AuroraUtils.ParseDecimalString(this.txtTritanium.Text);
            ParsedDecimal gclass208_5 = AuroraUtils.ParseDecimalString(this.txtBoronide.Text);
            ParsedDecimal gclass208_6 = AuroraUtils.ParseDecimalString(this.txtMercassium.Text);
            ParsedDecimal gclass208_7 = AuroraUtils.ParseDecimalString(this.txtVendarite.Text);
            ParsedDecimal gclass208_8 = AuroraUtils.ParseDecimalString(this.txtSorium.Text);
            ParsedDecimal gclass208_9 = AuroraUtils.ParseDecimalString(this.txtUridium.Text);
            ParsedDecimal gclass208_10 = AuroraUtils.ParseDecimalString(this.txtCorundium.Text);
            ParsedDecimal gclass208_11 = AuroraUtils.ParseDecimalString(this.txtGallicite.Text);
            if (gclass208_1.Succeed)
                decimal_1_1 = gclass208_1.Value;
            if (gclass208_2.Succeed)
                decimal_1_2 = gclass208_2.Value;
            if (gclass208_3.Succeed)
                decimal_1_3 = gclass208_3.Value;
            if (gclass208_4.Succeed)
                decimal_1_4 = gclass208_4.Value;
            if (gclass208_5.Succeed)
                decimal_1_5 = gclass208_5.Value;
            if (gclass208_6.Succeed)
                decimal_1_6 = gclass208_6.Value;
            if (gclass208_7.Succeed)
                decimal_1_7 = gclass208_7.Value;
            if (gclass208_8.Succeed)
                decimal_1_8 = gclass208_8.Value;
            if (gclass208_9.Succeed)
                decimal_1_9 = gclass208_9.Value;
            if (gclass208_10.Succeed)
                decimal_1_10 = gclass208_10.Value;
            if (gclass208_11.Succeed)
                decimal_1_11 = gclass208_11.Value;
            ParsedDecimal gclass208_12 = AuroraUtils.ParseDecimalString(this.txtDuraniumAcc.Text);
            ParsedDecimal gclass208_13 = AuroraUtils.ParseDecimalString(this.txtNeutroniumAcc.Text);
            ParsedDecimal gclass208_14 = AuroraUtils.ParseDecimalString(this.txtCorbomiteAcc.Text);
            ParsedDecimal gclass208_15 = AuroraUtils.ParseDecimalString(this.txtTritaniumAcc.Text);
            ParsedDecimal gclass208_16 = AuroraUtils.ParseDecimalString(this.txtBoronideAcc.Text);
            ParsedDecimal gclass208_17 = AuroraUtils.ParseDecimalString(this.txtMercassiumAcc.Text);
            ParsedDecimal gclass208_18 = AuroraUtils.ParseDecimalString(this.txtVendariteAcc.Text);
            ParsedDecimal gclass208_19 = AuroraUtils.ParseDecimalString(this.txtSoriumAcc.Text);
            ParsedDecimal gclass208_20 = AuroraUtils.ParseDecimalString(this.txtUridiumAcc.Text);
            ParsedDecimal gclass208_21 = AuroraUtils.ParseDecimalString(this.txtCorundiumAcc.Text);
            ParsedDecimal gclass208_22 = AuroraUtils.ParseDecimalString(this.txtGalliciteAcc.Text);
            if (gclass208_12.Succeed)
                num1 = gclass208_12.Value;
            if (gclass208_13.Succeed)
                num2 = gclass208_13.Value;
            if (gclass208_14.Succeed)
                num3 = gclass208_14.Value;
            if (gclass208_15.Succeed)
                num4 = gclass208_15.Value;
            if (gclass208_16.Succeed)
                num5 = gclass208_16.Value;
            if (gclass208_17.Succeed)
                num6 = gclass208_17.Value;
            if (gclass208_18.Succeed)
                num7 = gclass208_18.Value;
            if (gclass208_19.Succeed)
                num8 = gclass208_19.Value;
            if (gclass208_20.Succeed)
                num9 = gclass208_20.Value;
            if (gclass208_21.Succeed)
                num10 = gclass208_21.Value;
            if (gclass208_22.Succeed)
                num11 = gclass208_22.Value;
            // ISSUE: reference to a compiler-generated field
            class1080.auroraElement_0 = new List<SingleMineralValue>()
                {
                    new SingleMineralValue(AuroraElement.Duranium, decimal_1_1),
                    new SingleMineralValue(AuroraElement.Neutronium, decimal_1_2),
                    new SingleMineralValue(AuroraElement.Corbomite, decimal_1_3),
                    new SingleMineralValue(AuroraElement.Tritanium, decimal_1_4),
                    new SingleMineralValue(AuroraElement.Boronide, decimal_1_5),
                    new SingleMineralValue(AuroraElement.Mercassium, decimal_1_6),
                    new SingleMineralValue(AuroraElement.Vendarite, decimal_1_7),
                    new SingleMineralValue(AuroraElement.Sorium, decimal_1_8),
                    new SingleMineralValue(AuroraElement.Uridium, decimal_1_9),
                    new SingleMineralValue(AuroraElement.Corundium, decimal_1_10),
                    new SingleMineralValue(AuroraElement.Gallicite, decimal_1_11)
                }.OrderByDescending<SingleMineralValue, Decimal>(gclass125_0 => gclass125_0.decimal_0)
                .Select<SingleMineralValue, AuroraElement>(gclass125_0 => gclass125_0.auroraElement_0)
                .FirstOrDefault<AuroraElement>();
            // ISSUE: reference to a compiler-generated field
            class1080.gclass208_0 = AuroraUtils.ParseDecimalString(this.txtMaxDiameter.Text);
            // ISSUE: reference to a compiler-generated field
            class1080.gclass208_1 = AuroraUtils.ParseDecimalString(this.txtMinGravity.Text);
            List<SystemBodyData> source1 = this.gclass0_0.list_9
                .Where<GClass215>(gclass215_0 => gclass215_0.gclass21_0 == this.gclass21_0)
                .Select<GClass215, SystemBodyData>(gclass215_0 => gclass215_0.gclass1_0)
                .Where<SystemBodyData>(gclass1_0 => gclass1_0.dictionary_0.Count > 0)
                .ToList<SystemBodyData>();
            if (this.gclass202_0 != null && this.gclass202_0.int_36 == 0)
                source1 = source1
                    .Where<SystemBodyData>(gclass1_0 => gclass1_0.SystemData == this.gclass202_0.ActualSystemData)
                    .ToList<SystemBodyData>();
            if (this.chkExcludeAlien.CheckState == CheckState.Checked)
            {
                // ISSUE: object of a compiler-generated type is created
                // ISSUE: reference to a compiler-generated method
                source1 = source1.Where<SystemBodyData>(new Minerals.Class1081()
                {
                    list_0 = this.gclass21_0.RacialSystemDictionary.Values
                        .Where<RacialSystemSurvey>(gclass202_0 => gclass202_0.gclass110_0 != null)
                        .Where<RacialSystemSurvey>(gclass202_1 => gclass202_1.gclass110_0.ActualAlienRace != this.gclass21_0)
                        .Select<RacialSystemSurvey, SystemData200>(gclass202_0 => gclass202_0.ActualSystemData)
                        .ToList<SystemData200>()
                }.method_0).ToList<SystemBodyData>();
            }

            if (this.chkSearchFlag.CheckState == CheckState.Checked)
            {
                // ISSUE: object of a compiler-generated type is created
                // ISSUE: reference to a compiler-generated method
                source1 = source1.Where<SystemBodyData>(new Minerals.Class1082()
                {
                    list_0 = this.gclass21_0.RacialSystemDictionary.Values.Where<RacialSystemSurvey>(gclass202_0 => !gclass202_0.bMineralSearchFlag)
                        .Select<RacialSystemSurvey, SystemData200>(gclass202_0 => gclass202_0.ActualSystemData)
                        .ToList<SystemData200>()
                }.method_0).ToList<SystemBodyData>();
            }

            if (this.chkOMEligible.CheckState == CheckState.Checked)
                source1 = source1
                    .Where<SystemBodyData>(gclass1_0 =>
                        gclass1_0.Radius * 2.0 <= this.gclass21_0.MaximumOrbitalMiningDiameter)
                    .ToList<SystemBodyData>();
            if (this.chkExcludeHighG.CheckState == CheckState.Checked)
            {
                // ISSUE: reference to a compiler-generated method
                source1 = source1.Where<SystemBodyData>(class1080.method_0).ToList<SystemBodyData>();
            }

            if (this.rdoExcludeGG.Checked)
                source1 = source1.Where<SystemBodyData>(gclass1_0 =>
                    gclass1_0.BodyTypeId != AuroraSystemBodyType.GasGiant &&
                    gclass1_0.BodyTypeId != AuroraSystemBodyType.Superjovian).ToList<SystemBodyData>();
            if (this.rdoGGOnly.Checked)
                source1 = source1.Where<SystemBodyData>(gclass1_0 =>
                    gclass1_0.BodyTypeId == AuroraSystemBodyType.GasGiant ||
                    gclass1_0.BodyTypeId == AuroraSystemBodyType.Superjovian).ToList<SystemBodyData>();
            if (this.rdoExcludeAst.Checked)
                source1 = source1
                    .Where<SystemBodyData>(gclass1_0 => gclass1_0.BodyClass != PlanetBodyClass.Asteroid)
                    .ToList<SystemBodyData>();
            if (this.rdoAstOnly.Checked)
                source1 = source1
                    .Where<SystemBodyData>(gclass1_0 => gclass1_0.BodyClass == PlanetBodyClass.Asteroid)
                    .ToList<SystemBodyData>();
            // ISSUE: reference to a compiler-generated field
            if (class1080.gclass208_0.Value > 0M)
            {
                // ISSUE: reference to a compiler-generated method
                source1 = source1.Where<SystemBodyData>(class1080.method_1).ToList<SystemBodyData>();
            }

            // ISSUE: reference to a compiler-generated field
            if (class1080.gclass208_1.Value > 0M)
            {
                // ISSUE: reference to a compiler-generated method
                source1 = source1.Where<SystemBodyData>(class1080.method_2).ToList<SystemBodyData>();
            }

            foreach (SystemBodyData gclass1 in source1)
            {
                // ISSUE: reference to a compiler-generated field
                gclass1.method_58(this.gclass21_0, class1080.gclass194_0, true);
            }

            if (this.chkColonyCost.Checked)
            {
                // ISSUE: object of a compiler-generated type is created
                // ISSUE: variable of a compiler-generated type
                Minerals.Class1083 class1083 = new Minerals.Class1083();
                // ISSUE: reference to a compiler-generated field
                class1083.decimal_0 = 10M;
                ParsedDecimal gclass208_23 = AuroraUtils.ParseDecimalString(this.txtColonyCost.Text);
                if (gclass208_23.Succeed)
                {
                    // ISSUE: reference to a compiler-generated field
                    class1083.decimal_0 = gclass208_23.Value;
                }

                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                source1 = this.chkUseMaxCC.CheckState != CheckState.Checked
                    ? source1.Where<SystemBodyData>(class1083.method_1).ToList<SystemBodyData>()
                    : source1.Where<SystemBodyData>(class1083.method_0).ToList<SystemBodyData>();
            }

            List<SystemBodyData> source2 = new List<SystemBodyData>();
            foreach (SystemBodyData gclass1 in source1)
            {
                if
                (
                    (!(decimal_1_1 > 0M) || gclass1.dictionary_0.ContainsKey(AuroraElement.Duranium) &&
                        !(gclass1.dictionary_0[AuroraElement.Duranium].decimal_0 < decimal_1_1) &&
                        !(gclass1.dictionary_0[AuroraElement.Duranium].decimal_1 < num1)) &&
                    (!(decimal_1_2 > 0M) || gclass1.dictionary_0.ContainsKey(AuroraElement.Neutronium) &&
                        !(gclass1.dictionary_0[AuroraElement.Neutronium].decimal_0 < decimal_1_2) &&
                        !(gclass1.dictionary_0[AuroraElement.Neutronium].decimal_1 < num2)) &&
                    (!(decimal_1_3 > 0M) || gclass1.dictionary_0.ContainsKey(AuroraElement.Corbomite) &&
                        !(gclass1.dictionary_0[AuroraElement.Corbomite].decimal_0 < decimal_1_3) &&
                        !(gclass1.dictionary_0[AuroraElement.Corbomite].decimal_1 < num3)) &&
                    (!(decimal_1_4 > 0M) || gclass1.dictionary_0.ContainsKey(AuroraElement.Tritanium) &&
                        !(gclass1.dictionary_0[AuroraElement.Tritanium].decimal_0 < decimal_1_4) &&
                        !(gclass1.dictionary_0[AuroraElement.Tritanium].decimal_1 < num4)) &&
                    (!(decimal_1_5 > 0M) || gclass1.dictionary_0.ContainsKey(AuroraElement.Boronide) &&
                        !(gclass1.dictionary_0[AuroraElement.Boronide].decimal_0 < decimal_1_5) &&
                        !(gclass1.dictionary_0[AuroraElement.Boronide].decimal_1 < num5)) &&
                    (!(decimal_1_6 > 0M) || gclass1.dictionary_0.ContainsKey(AuroraElement.Mercassium) &&
                        !(gclass1.dictionary_0[AuroraElement.Mercassium].decimal_0 < decimal_1_6) &&
                        !(gclass1.dictionary_0[AuroraElement.Mercassium].decimal_1 < num6)) &&
                    (!(decimal_1_7 > 0M) || gclass1.dictionary_0.ContainsKey(AuroraElement.Vendarite) &&
                        !(gclass1.dictionary_0[AuroraElement.Vendarite].decimal_0 < decimal_1_7) &&
                        !(gclass1.dictionary_0[AuroraElement.Vendarite].decimal_1 < num7)) &&
                    (!(decimal_1_8 > 0M) || gclass1.dictionary_0.ContainsKey(AuroraElement.Sorium) &&
                        !(gclass1.dictionary_0[AuroraElement.Sorium].decimal_0 < decimal_1_8) &&
                        !(gclass1.dictionary_0[AuroraElement.Sorium].decimal_1 < num8)) &&
                    (!(decimal_1_9 > 0M) || gclass1.dictionary_0.ContainsKey(AuroraElement.Uridium) &&
                        !(gclass1.dictionary_0[AuroraElement.Uridium].decimal_0 < decimal_1_9) &&
                        !(gclass1.dictionary_0[AuroraElement.Uridium].decimal_1 < num9)) &&
                    (!(decimal_1_10 > 0M) || gclass1.dictionary_0.ContainsKey(AuroraElement.Corundium) &&
                        !(gclass1.dictionary_0[AuroraElement.Corundium].decimal_0 < decimal_1_10) &&
                        !(gclass1.dictionary_0[AuroraElement.Corundium].decimal_1 < num10)) && (!(decimal_1_11 > 0M) ||
                        gclass1.dictionary_0.ContainsKey(AuroraElement.Gallicite) &&
                        !(gclass1.dictionary_0[AuroraElement.Gallicite].decimal_0 < decimal_1_11) &&
                        !(gclass1.dictionary_0[AuroraElement.Gallicite].decimal_1 < num11)))
                    source2.Add(gclass1);
            }

            foreach (SystemBodyData gclass1 in source2)
            {
                foreach (AuroraElement key in Enum.GetValues(typeof(AuroraElement)))
                {
                    if (gclass1.dictionary_0.ContainsKey(key))
                        gclass1.dictionary_2.Add(key, gclass1.dictionary_0[key].decimal_0);
                    else
                        gclass1.dictionary_2.Add(key, 0M);
                }
            }

            // ISSUE: reference to a compiler-generated method
            foreach (SystemBodyData gclass1 in source2
                         .OrderByDescending<SystemBodyData, Decimal>(class1080.method_3)
                         .ToList<SystemBodyData>())
            {
                // ISSUE: object of a compiler-generated type is created
                // ISSUE: variable of a compiler-generated type
                Minerals.Class1084 class1084 = new Minerals.Class1084();
                // ISSUE: reference to a compiler-generated field
                class1084.class1080_0 = class1080;
                // ISSUE: reference to a compiler-generated field
                class1084.gclass1_0 = gclass1;
                // ISSUE: reference to a compiler-generated field
                class1084.gclass1_0.dictionary_2.Clear();
                // ISSUE: reference to a compiler-generated field
                ListViewItem listViewItem_0 =
                    new ListViewItem(class1084.gclass1_0.StarData.method_18(this.gclass21_0));
                // ISSUE: reference to a compiler-generated field
                string text1 = class1084.gclass1_0.method_79(this.gclass21_0, true, true);
                // ISSUE: reference to a compiler-generated method
                PopulationData gclass146 = this.gclass0_0.PopulationDataDictionary.Values.FirstOrDefault<PopulationData>(class1084.method_0);
                if (gclass146 != null)
                    text1 = gclass146.PopName + " (C)";
                listViewItem_0.SubItems.Add(text1);
                if (this.lstvMineralsWide.Visible)
                {
                    string text2 = "-";
                    // ISSUE: reference to a compiler-generated field
                    if (class1084.gclass1_0.list_0.Count > 0)
                    {
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        class1084.gclass1_0.list_0 = class1084.gclass1_0.list_0
                            .OrderByDescending<GClass224, double>(gclass224_0 => gclass224_0.double_1)
                            .ToList<GClass224>();
                        // ISSUE: reference to a compiler-generated field
                        text2 = AuroraUtils.smethod_50(class1084.gclass1_0.AtmospherePressure);
                        // ISSUE: reference to a compiler-generated field
                        if (class1084.gclass1_0.list_0.Count<GClass224>(gclass224_0 => gclass224_0.bool_0) > 0)
                            text2 += "F";
                        // ISSUE: reference to a compiler-generated field
                        string text3 = class1084.gclass1_0.method_59();
                        listViewItem_0.SubItems.Add(text3);
                    }
                    else
                        listViewItem_0.SubItems.Add("-");

                    listViewItem_0.SubItems.Add(text2);
                    // ISSUE: reference to a compiler-generated field
                    listViewItem_0.SubItems.Add(AuroraUtils.smethod_43(class1084.gclass1_0.Radius * 2.0));
                    // ISSUE: reference to a compiler-generated field
                    listViewItem_0.SubItems.Add(AuroraUtils.smethod_44(class1084.gclass1_0.Gravity, 3));
                    // ISSUE: reference to a compiler-generated field
                    if (class1084.gclass1_0.Gravity >= 0.1)
                    {
                        // ISSUE: reference to a compiler-generated field
                        double num12 = 4.0 * AuroraUtils.PI_Apprx * Math.Pow(class1084.gclass1_0.Radius, 2.0);
                        double double_32 = (double)AuroraUtils.decimal_15 / num12;
                        listViewItem_0.SubItems.Add(AuroraUtils.smethod_44(double_32, 2));
                    }
                    else
                        listViewItem_0.SubItems.Add("-");
                }

                Color color = AuroraUtils.color_3;
                if (this.chkHabColour.CheckState == CheckState.Checked)
                {
                    Decimal num13 = 1M;
                    TechSystem gclass164 =
                        this.gclass21_0.method_388(this.gclass0_0.TechTypeDataDictionary[TechType.ColonizationCostReduction]);
                    if (gclass164 != null)
                        num13 = Math.Round(gclass164.decimal_0, 2);
                    // ISSUE: reference to a compiler-generated field
                    if (class1084.gclass1_0.ColonyCost >= 0M)
                    {
                        // ISSUE: reference to a compiler-generated field
                        if (class1084.gclass1_0.ColonyCost < 2M * num13)
                        {
                            color = Color.DodgerBlue;
                        }
                        else
                        {
                            // ISSUE: reference to a compiler-generated field
                            if (class1084.gclass1_0.ColonyCost < 3M * num13)
                            {
                                color = Color.Cyan;
                            }
                            else
                            {
                                // ISSUE: reference to a compiler-generated field
                                // ISSUE: reference to a compiler-generated field
                                // ISSUE: reference to a compiler-generated field
                                // ISSUE: reference to a compiler-generated field
                                if (class1084.gclass1_0.ColonyCost < 6M * num13 && class1084.gclass1_0.Gravity >
                                    class1084.class1080_0.gclass194_0.double_7)
                                    color = Color.Chocolate;
                            }
                        }
                    }
                }

                // ISSUE: reference to a compiler-generated field
                string text4 = AuroraUtils.FormatNumberToDigits(class1084.gclass1_0.ColonyCost, 2);
                if (this.chkUseMaxCC.CheckState == CheckState.Checked)
                {
                    // ISSUE: reference to a compiler-generated field
                    text4 = AuroraUtils.FormatNumberToDigits(class1084.gclass1_0.MaxColonyCost, 2);
                }

                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                if (class1084.gclass1_0.Gravity < class1084.class1080_0.gclass194_0.double_7)
                    text4 += " LG";
                listViewItem_0.SubItems.Add(text4);
                foreach (AuroraElement auroraElement_0 in Enum.GetValues(typeof(AuroraElement)))
                {
                    if (auroraElement_0 != AuroraElement.None)
                    {
                        // ISSUE: reference to a compiler-generated field
                        this.method_5(auroraElement_0, class1084.gclass1_0, listViewItem_0);
                    }
                }

                // ISSUE: reference to a compiler-generated field
                listViewItem_0.Tag = class1084.gclass1_0;
                foreach (ListViewItem.ListViewSubItem subItem in listViewItem_0.SubItems)
                    subItem.ForeColor = color;
                listView.Items.Add(listViewItem_0);
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2026);
        }
    }

    private void cboSpecies_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass0_0.bool_9)
                return;
            this.method_4();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2027);
        }
    }

    private void method_5(
        AuroraElement auroraElement_0,
        SystemBodyData gclass1_0,
        ListViewItem listViewItem_0)
    {
        try
        {
            if (gclass1_0.dictionary_0.ContainsKey(auroraElement_0))
            {
                listViewItem_0.SubItems.Add(AuroraUtils.smethod_39(gclass1_0.dictionary_0[auroraElement_0].decimal_0));
                listViewItem_0.SubItems.Add(
                    AuroraUtils.smethod_45(gclass1_0.dictionary_0[auroraElement_0].decimal_1, 1));
            }
            else
            {
                listViewItem_0.SubItems.Add("-");
                listViewItem_0.SubItems.Add("");
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2028);
        }
    }

    private void cmdSearch_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass0_0.bool_9)
                return;
            this.method_4();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2029);
        }
    }

    private void cmdClear_Click(object sender, EventArgs e)
    {
        try
        {
            this.txtDuranium.Text = "0";
            this.txtNeutronium.Text = "0";
            this.txtCorbomite.Text = "0";
            this.txtTritanium.Text = "0";
            this.txtBoronide.Text = "0";
            this.txtMercassium.Text = "0";
            this.txtVendarite.Text = "0";
            this.txtSorium.Text = "0";
            this.txtUridium.Text = "0";
            this.txtCorundium.Text = "0";
            this.txtGallicite.Text = "0";
            this.txtDuraniumAcc.Text = "0.1";
            this.txtNeutroniumAcc.Text = "0.1";
            this.txtCorbomiteAcc.Text = "0.1";
            this.txtTritaniumAcc.Text = "0.1";
            this.txtBoronideAcc.Text = "0.1";
            this.txtMercassiumAcc.Text = "0.1";
            this.txtVendariteAcc.Text = "0.1";
            this.txtSoriumAcc.Text = "0.1";
            this.txtUridiumAcc.Text = "0.1";
            this.txtCorundiumAcc.Text = "0.1";
            this.txtGalliciteAcc.Text = "0.1";
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2030);
        }
    }

    private void cboSystems_SelectedIndexChanged(object sender, EventArgs e)
    {
    }

    private void lstvMinerals_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass0_0.bool_9 || this.lstvMinerals.SelectedItems.Count == 0 ||
                this.lstvMinerals.SelectedItems[0].Tag == null ||
                !(this.lstvMinerals.SelectedItems[0].Tag is SystemBodyData))
                return;
            if (this.chkCentreOnBody.CheckState == CheckState.Checked)
            {
                SystemBodyData tag = (SystemBodyData)this.lstvMinerals.SelectedItems[0].Tag;
                RacialSystemSurvey gclass202 = this.gclass21_0.method_128(tag.SystemData);
                this.tacticalMap_0.method_9(gclass202);
                this.gclass0_0.method_712(tag.XCoordinate, tag.YCoordinate, gclass202);
                this.tacticalMap_0.Refresh();
            }

            if (this.chkCentreOnSystem.CheckState != CheckState.Checked)
                return;
            RacialSystemSurvey gclass202_2 =
                this.gclass21_0.method_128(((SystemBodyData)this.lstvMinerals.SelectedItems[0].Tag)
                    .SystemData);
            foreach (GalacticMap galacticMap in Application.OpenForms.OfType<GalacticMap>())
                galacticMap.method_13(gclass202_2);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2032);
        }
    }

    private void cmdCreate_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass21_0 == null)
            {
                int num1 = (int)MessageBox.Show("Please select a race");
            }
            else if (this.cboSpecies.SelectedValue == null)
            {
                int num2 = (int)MessageBox.Show("Please select a species");
            }
            else
            {
                SystemBodyData tag;
                if (!this.gclass0_0.bool_19)
                {
                    if (this.lstvMinerals.SelectedItems.Count == 0 || this.lstvMinerals.SelectedItems[0].Tag == null ||
                        !(this.lstvMinerals.SelectedItems[0].Tag is SystemBodyData))
                        return;
                    tag = (SystemBodyData)this.lstvMinerals.SelectedItems[0].Tag;
                }
                else
                {
                    if (this.lstvMineralsWide.SelectedItems.Count == 0 ||
                        this.lstvMineralsWide.SelectedItems[0].Tag == null ||
                        !(this.lstvMineralsWide.SelectedItems[0].Tag is SystemBodyData))
                        return;
                    tag = (SystemBodyData)this.lstvMineralsWide.SelectedItems[0].Tag;
                }

                GClass194 selectedValue = (GClass194)this.cboSpecies.SelectedValue;
                if (tag.BodyTypeId == AuroraSystemBodyType.GasGiant ||
                    tag.BodyTypeId == AuroraSystemBodyType.Superjovian)
                    return;
                this.gclass21_0.method_275(tag, selectedValue);
                this.method_4();
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2033);
        }
    }

    private void chkExcludeHighG_CheckedChanged(object sender, EventArgs e)
    {
    }

    private void txtColonyCost_TextChanged(object sender, EventArgs e)
    {
    }

    private void Minerals_KeyDown(object sender, KeyEventArgs e)
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
            AuroraUtils.ShowExceptionPopup(ex, 3281);
        }
    }

    private void cmdSuperWide_Click(object sender, EventArgs e)
    {
        this.method_0();
        this.method_4();
    }

    private void chkHabColour_CheckedChanged(object sender, EventArgs e) => this.method_4();

    private void lstvMineralsWide_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass0_0.bool_9 || this.lstvMineralsWide.SelectedItems.Count == 0 ||
                this.lstvMineralsWide.SelectedItems[0].Tag == null ||
                !(this.lstvMineralsWide.SelectedItems[0].Tag is SystemBodyData))
                return;
            if (this.chkCentreOnBody.CheckState == CheckState.Checked)
            {
                SystemBodyData tag = (SystemBodyData)this.lstvMineralsWide.SelectedItems[0].Tag;
                RacialSystemSurvey gclass202 = this.gclass21_0.method_128(tag.SystemData);
                this.tacticalMap_0.method_9(gclass202);
                this.gclass0_0.method_712(tag.XCoordinate, tag.YCoordinate, gclass202);
                this.tacticalMap_0.Refresh();
            }

            if (this.chkCentreOnSystem.CheckState != CheckState.Checked)
                return;
            RacialSystemSurvey gclass202_2 =
                this.gclass21_0.method_128(((SystemBodyData)this.lstvMineralsWide.SelectedItems[0].Tag)
                    .SystemData);
            foreach (GalacticMap galacticMap in Application.OpenForms.OfType<GalacticMap>())
                galacticMap.method_13(gclass202_2);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3771);
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
        this.lstvMinerals = new ListView();
        this.columnHeader_0 = new ColumnHeader();
        this.columnHeader_1 = new ColumnHeader();
        this.columnHeader_2 = new ColumnHeader();
        this.columnHeader_3 = new ColumnHeader();
        this.columnHeader_4 = new ColumnHeader();
        this.columnHeader_5 = new ColumnHeader();
        this.columnHeader_6 = new ColumnHeader();
        this.columnHeader_7 = new ColumnHeader();
        this.columnHeader_8 = new ColumnHeader();
        this.columnHeader_9 = new ColumnHeader();
        this.columnHeader_10 = new ColumnHeader();
        this.columnHeader_11 = new ColumnHeader();
        this.columnHeader_12 = new ColumnHeader();
        this.columnHeader_13 = new ColumnHeader();
        this.columnHeader_14 = new ColumnHeader();
        this.columnHeader_15 = new ColumnHeader();
        this.columnHeader_16 = new ColumnHeader();
        this.columnHeader_17 = new ColumnHeader();
        this.columnHeader_18 = new ColumnHeader();
        this.columnHeader_19 = new ColumnHeader();
        this.columnHeader_20 = new ColumnHeader();
        this.columnHeader_21 = new ColumnHeader();
        this.columnHeader_22 = new ColumnHeader();
        this.columnHeader_23 = new ColumnHeader();
        this.columnHeader_24 = new ColumnHeader();
        this.cboRaces = new ComboBox();
        this.flowLayoutPanel1 = new FlowLayoutPanel();
        this.txtColonyCost = new TextBox();
        this.txtDuranium = new TextBox();
        this.txtDuraniumAcc = new TextBox();
        this.txtNeutronium = new TextBox();
        this.txtNeutroniumAcc = new TextBox();
        this.txtCorbomite = new TextBox();
        this.txtCorbomiteAcc = new TextBox();
        this.txtTritanium = new TextBox();
        this.txtTritaniumAcc = new TextBox();
        this.txtBoronide = new TextBox();
        this.txtBoronideAcc = new TextBox();
        this.txtMercassium = new TextBox();
        this.txtMercassiumAcc = new TextBox();
        this.txtVendarite = new TextBox();
        this.txtVendariteAcc = new TextBox();
        this.txtSorium = new TextBox();
        this.txtSoriumAcc = new TextBox();
        this.txtUridium = new TextBox();
        this.txtUridiumAcc = new TextBox();
        this.txtCorundium = new TextBox();
        this.txtCorundiumAcc = new TextBox();
        this.txtGallicite = new TextBox();
        this.txtGalliciteAcc = new TextBox();
        this.cboSpecies = new ComboBox();
        this.flowLayoutPanel2 = new FlowLayoutPanel();
        this.textBox23 = new TextBox();
        this.textBox1 = new TextBox();
        this.textBox2 = new TextBox();
        this.textBox3 = new TextBox();
        this.textBox4 = new TextBox();
        this.textBox5 = new TextBox();
        this.textBox6 = new TextBox();
        this.textBox7 = new TextBox();
        this.textBox8 = new TextBox();
        this.textBox9 = new TextBox();
        this.textBox10 = new TextBox();
        this.textBox11 = new TextBox();
        this.textBox12 = new TextBox();
        this.textBox13 = new TextBox();
        this.textBox14 = new TextBox();
        this.textBox15 = new TextBox();
        this.textBox16 = new TextBox();
        this.textBox17 = new TextBox();
        this.textBox18 = new TextBox();
        this.textBox19 = new TextBox();
        this.textBox20 = new TextBox();
        this.textBox21 = new TextBox();
        this.textBox22 = new TextBox();
        this.cmdSearch = new Button();
        this.chkExcludeHighG = new CheckBox();
        this.flowLayoutPanel3 = new FlowLayoutPanel();
        this.chkExcludeAlien = new CheckBox();
        this.chkColonyCost = new CheckBox();
        this.chkUseMaxCC = new CheckBox();
        this.chkHabColour = new CheckBox();
        this.chkOMEligible = new CheckBox();
        this.chkSearchFlag = new CheckBox();
        this.flowLayoutPanel4 = new FlowLayoutPanel();
        this.rdoIncludeGG = new RadioButton();
        this.rdoExcludeGG = new RadioButton();
        this.rdoGGOnly = new RadioButton();
        this.flowLayoutPanel5 = new FlowLayoutPanel();
        this.rdoIncludeAst = new RadioButton();
        this.rdoExcludeAst = new RadioButton();
        this.rdoAstOnly = new RadioButton();
        this.flpMineralSearch = new FlowLayoutPanel();
        this.cmdCreate = new Button();
        this.cmdClear = new Button();
        this.flowLayoutPanel7 = new FlowLayoutPanel();
        this.cmdSuperWide = new Button();
        this.chkCentreOnBody = new CheckBox();
        this.cboSystems = new ComboBox();
        this.lstvMineralsWide = new ListView();
        this.columnHeader_25 = new ColumnHeader();
        this.columnHeader_26 = new ColumnHeader();
        this.columnHeader_53 = new ColumnHeader();
        this.columnHeader_54 = new ColumnHeader();
        this.columnHeader_50 = new ColumnHeader();
        this.columnHeader_51 = new ColumnHeader();
        this.columnHeader_52 = new ColumnHeader();
        this.columnHeader_27 = new ColumnHeader();
        this.columnHeader_28 = new ColumnHeader();
        this.columnHeader_29 = new ColumnHeader();
        this.columnHeader_30 = new ColumnHeader();
        this.columnHeader_31 = new ColumnHeader();
        this.columnHeader_32 = new ColumnHeader();
        this.columnHeader_33 = new ColumnHeader();
        this.columnHeader_34 = new ColumnHeader();
        this.columnHeader_35 = new ColumnHeader();
        this.columnHeader_36 = new ColumnHeader();
        this.columnHeader_37 = new ColumnHeader();
        this.columnHeader_38 = new ColumnHeader();
        this.columnHeader_39 = new ColumnHeader();
        this.columnHeader_40 = new ColumnHeader();
        this.columnHeader_41 = new ColumnHeader();
        this.columnHeader_42 = new ColumnHeader();
        this.columnHeader_43 = new ColumnHeader();
        this.columnHeader_44 = new ColumnHeader();
        this.columnHeader_45 = new ColumnHeader();
        this.columnHeader_46 = new ColumnHeader();
        this.columnHeader_47 = new ColumnHeader();
        this.columnHeader_48 = new ColumnHeader();
        this.columnHeader_49 = new ColumnHeader();
        this.flpWideStats = new FlowLayoutPanel();
        this.textBox24 = new TextBox();
        this.textBox25 = new TextBox();
        this.textBox26 = new TextBox();
        this.textBox27 = new TextBox();
        this.textBox28 = new TextBox();
        this.flowLayoutPanel6 = new FlowLayoutPanel();
        this.textBox29 = new TextBox();
        this.textBox30 = new TextBox();
        this.txtMaxDiameter = new TextBox();
        this.txtMinGravity = new TextBox();
        this.flpTopLevel = new FlowLayoutPanel();
        this.chkCentreOnSystem = new CheckBox();
        this.flowLayoutPanel1.SuspendLayout();
        this.flowLayoutPanel2.SuspendLayout();
        this.flowLayoutPanel3.SuspendLayout();
        this.flowLayoutPanel4.SuspendLayout();
        this.flowLayoutPanel5.SuspendLayout();
        this.flpMineralSearch.SuspendLayout();
        this.flowLayoutPanel7.SuspendLayout();
        this.flpWideStats.SuspendLayout();
        this.flowLayoutPanel6.SuspendLayout();
        this.flpTopLevel.SuspendLayout();
        this.SuspendLayout();
        this.lstvMinerals.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.lstvMinerals.BorderStyle = BorderStyle.FixedSingle;
        this.lstvMinerals.Columns.AddRange(new ColumnHeader[25]
        {
            this.columnHeader_0,
            this.columnHeader_1,
            this.columnHeader_2,
            this.columnHeader_3,
            this.columnHeader_4,
            this.columnHeader_5,
            this.columnHeader_6,
            this.columnHeader_7,
            this.columnHeader_8,
            this.columnHeader_9,
            this.columnHeader_10,
            this.columnHeader_11,
            this.columnHeader_12,
            this.columnHeader_13,
            this.columnHeader_14,
            this.columnHeader_15,
            this.columnHeader_16,
            this.columnHeader_17,
            this.columnHeader_18,
            this.columnHeader_19,
            this.columnHeader_20,
            this.columnHeader_21,
            this.columnHeader_22,
            this.columnHeader_23,
            this.columnHeader_24
        });
        this.lstvMinerals.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.lstvMinerals.FullRowSelect = true;
        this.lstvMinerals.HeaderStyle = ColumnHeaderStyle.None;
        this.lstvMinerals.HideSelection = false;
        this.lstvMinerals.Location = new Point(3, 92);
        this.lstvMinerals.Name = "lstvMinerals";
        this.lstvMinerals.Size = new Size(1418, 717);
        this.lstvMinerals.TabIndex = 61;
        this.lstvMinerals.UseCompatibleStateImageBehavior = false;
        this.lstvMinerals.View = View.Details;
        this.lstvMinerals.SelectedIndexChanged += this.lstvMinerals_SelectedIndexChanged;
        this.columnHeader_0.Width = 100;
        this.columnHeader_1.Width = 120;
        this.columnHeader_2.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_3.TextAlign = HorizontalAlignment.Right;
        this.columnHeader_3.Width = 70;
        this.columnHeader_4.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_4.Width = 30;
        this.columnHeader_5.TextAlign = HorizontalAlignment.Right;
        this.columnHeader_5.Width = 70;
        this.columnHeader_6.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_6.Width = 30;
        this.columnHeader_7.TextAlign = HorizontalAlignment.Right;
        this.columnHeader_7.Width = 70;
        this.columnHeader_8.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_8.Width = 30;
        this.columnHeader_9.TextAlign = HorizontalAlignment.Right;
        this.columnHeader_9.Width = 70;
        this.columnHeader_10.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_10.Width = 30;
        this.columnHeader_11.TextAlign = HorizontalAlignment.Right;
        this.columnHeader_11.Width = 70;
        this.columnHeader_12.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_12.Width = 30;
        this.columnHeader_13.TextAlign = HorizontalAlignment.Right;
        this.columnHeader_13.Width = 70;
        this.columnHeader_14.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_14.Width = 30;
        this.columnHeader_15.TextAlign = HorizontalAlignment.Right;
        this.columnHeader_15.Width = 70;
        this.columnHeader_16.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_16.Width = 30;
        this.columnHeader_17.TextAlign = HorizontalAlignment.Right;
        this.columnHeader_17.Width = 70;
        this.columnHeader_18.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_18.Width = 30;
        this.columnHeader_19.TextAlign = HorizontalAlignment.Right;
        this.columnHeader_19.Width = 70;
        this.columnHeader_20.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_20.Width = 30;
        this.columnHeader_21.TextAlign = HorizontalAlignment.Right;
        this.columnHeader_21.Width = 70;
        this.columnHeader_22.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_22.Width = 30;
        this.columnHeader_23.TextAlign = HorizontalAlignment.Right;
        this.columnHeader_23.Width = 70;
        this.columnHeader_24.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_24.Width = 30;
        this.cboRaces.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cboRaces.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cboRaces.FormattingEnabled = true;
        this.cboRaces.Location = new Point(0, 5);
        this.cboRaces.Margin = new Padding(0, 5, 3, 0);
        this.cboRaces.Name = "cboRaces";
        this.cboRaces.Size = new Size(213, 21);
        this.cboRaces.TabIndex = 62;
        this.cboRaces.SelectedIndexChanged += this.cboRaces_SelectedIndexChanged;
        this.flowLayoutPanel1.Controls.Add(this.txtColonyCost);
        this.flowLayoutPanel1.Controls.Add(this.txtDuranium);
        this.flowLayoutPanel1.Controls.Add(this.txtDuraniumAcc);
        this.flowLayoutPanel1.Controls.Add(this.txtNeutronium);
        this.flowLayoutPanel1.Controls.Add(this.txtNeutroniumAcc);
        this.flowLayoutPanel1.Controls.Add(this.txtCorbomite);
        this.flowLayoutPanel1.Controls.Add(this.txtCorbomiteAcc);
        this.flowLayoutPanel1.Controls.Add(this.txtTritanium);
        this.flowLayoutPanel1.Controls.Add(this.txtTritaniumAcc);
        this.flowLayoutPanel1.Controls.Add(this.txtBoronide);
        this.flowLayoutPanel1.Controls.Add(this.txtBoronideAcc);
        this.flowLayoutPanel1.Controls.Add(this.txtMercassium);
        this.flowLayoutPanel1.Controls.Add(this.txtMercassiumAcc);
        this.flowLayoutPanel1.Controls.Add(this.txtVendarite);
        this.flowLayoutPanel1.Controls.Add(this.txtVendariteAcc);
        this.flowLayoutPanel1.Controls.Add(this.txtSorium);
        this.flowLayoutPanel1.Controls.Add(this.txtSoriumAcc);
        this.flowLayoutPanel1.Controls.Add(this.txtUridium);
        this.flowLayoutPanel1.Controls.Add(this.txtUridiumAcc);
        this.flowLayoutPanel1.Controls.Add(this.txtCorundium);
        this.flowLayoutPanel1.Controls.Add(this.txtCorundiumAcc);
        this.flowLayoutPanel1.Controls.Add(this.txtGallicite);
        this.flowLayoutPanel1.Controls.Add(this.txtGalliciteAcc);
        this.flowLayoutPanel1.Location = new Point(0, 24);
        this.flowLayoutPanel1.Margin = new Padding(0, 3, 3, 3);
        this.flowLayoutPanel1.Name = "flowLayoutPanel1";
        this.flowLayoutPanel1.Size = new Size(1185, 21);
        this.flowLayoutPanel1.TabIndex = 63 /*0x3F*/;
        this.txtColonyCost.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtColonyCost.BorderStyle = BorderStyle.None;
        this.txtColonyCost.ForeColor = Color.FromArgb(128 /*0x80*/, 255, 128 /*0x80*/);
        this.txtColonyCost.Location = new Point(0, 3);
        this.txtColonyCost.Margin = new Padding(0, 3, 0, 0);
        this.txtColonyCost.Name = "txtColonyCost";
        this.txtColonyCost.Size = new Size(60, 13);
        this.txtColonyCost.TabIndex = 143;
        this.txtColonyCost.Text = "10";
        this.txtColonyCost.TextAlign = HorizontalAlignment.Center;
        this.txtColonyCost.TextChanged += this.txtColonyCost_TextChanged;
        this.txtDuranium.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtDuranium.BorderStyle = BorderStyle.None;
        this.txtDuranium.ForeColor = Color.FromArgb(128 /*0x80*/, 255, 128 /*0x80*/);
        this.txtDuranium.Location = new Point(60, 3);
        this.txtDuranium.Margin = new Padding(0, 3, 0, 0);
        this.txtDuranium.Name = "txtDuranium";
        this.txtDuranium.Size = new Size(70, 13);
        this.txtDuranium.TabIndex = 142;
        this.txtDuranium.Text = "0";
        this.txtDuranium.TextAlign = HorizontalAlignment.Right;
        this.txtDuraniumAcc.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtDuraniumAcc.BorderStyle = BorderStyle.None;
        this.txtDuraniumAcc.ForeColor = Color.FromArgb(128 /*0x80*/, 255, 128 /*0x80*/);
        this.txtDuraniumAcc.Location = new Point(130, 3);
        this.txtDuraniumAcc.Margin = new Padding(0, 3, 0, 0);
        this.txtDuraniumAcc.Name = "txtDuraniumAcc";
        this.txtDuraniumAcc.Size = new Size(30, 13);
        this.txtDuraniumAcc.TabIndex = 143;
        this.txtDuraniumAcc.Text = "0.1";
        this.txtDuraniumAcc.TextAlign = HorizontalAlignment.Center;
        this.txtNeutronium.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtNeutronium.BorderStyle = BorderStyle.None;
        this.txtNeutronium.ForeColor = Color.FromArgb(128 /*0x80*/, 255, 128 /*0x80*/);
        this.txtNeutronium.Location = new Point(160 /*0xA0*/, 3);
        this.txtNeutronium.Margin = new Padding(0, 3, 0, 0);
        this.txtNeutronium.Name = "txtNeutronium";
        this.txtNeutronium.Size = new Size(70, 13);
        this.txtNeutronium.TabIndex = 144 /*0x90*/;
        this.txtNeutronium.Text = "0";
        this.txtNeutronium.TextAlign = HorizontalAlignment.Right;
        this.txtNeutroniumAcc.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtNeutroniumAcc.BorderStyle = BorderStyle.None;
        this.txtNeutroniumAcc.ForeColor = Color.FromArgb(128 /*0x80*/, 255, 128 /*0x80*/);
        this.txtNeutroniumAcc.Location = new Point(230, 3);
        this.txtNeutroniumAcc.Margin = new Padding(0, 3, 0, 0);
        this.txtNeutroniumAcc.Name = "txtNeutroniumAcc";
        this.txtNeutroniumAcc.Size = new Size(30, 13);
        this.txtNeutroniumAcc.TabIndex = 145;
        this.txtNeutroniumAcc.Text = "0.1";
        this.txtNeutroniumAcc.TextAlign = HorizontalAlignment.Center;
        this.txtCorbomite.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtCorbomite.BorderStyle = BorderStyle.None;
        this.txtCorbomite.ForeColor = Color.FromArgb(128 /*0x80*/, 255, 128 /*0x80*/);
        this.txtCorbomite.Location = new Point(260, 3);
        this.txtCorbomite.Margin = new Padding(0, 3, 0, 0);
        this.txtCorbomite.Name = "txtCorbomite";
        this.txtCorbomite.Size = new Size(70, 13);
        this.txtCorbomite.TabIndex = 146;
        this.txtCorbomite.Text = "0";
        this.txtCorbomite.TextAlign = HorizontalAlignment.Right;
        this.txtCorbomiteAcc.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtCorbomiteAcc.BorderStyle = BorderStyle.None;
        this.txtCorbomiteAcc.ForeColor = Color.FromArgb(128 /*0x80*/, 255, 128 /*0x80*/);
        this.txtCorbomiteAcc.Location = new Point(330, 3);
        this.txtCorbomiteAcc.Margin = new Padding(0, 3, 0, 0);
        this.txtCorbomiteAcc.Name = "txtCorbomiteAcc";
        this.txtCorbomiteAcc.Size = new Size(30, 13);
        this.txtCorbomiteAcc.TabIndex = 147;
        this.txtCorbomiteAcc.Text = "0.1";
        this.txtCorbomiteAcc.TextAlign = HorizontalAlignment.Center;
        this.txtTritanium.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtTritanium.BorderStyle = BorderStyle.None;
        this.txtTritanium.ForeColor = Color.FromArgb(128 /*0x80*/, 255, 128 /*0x80*/);
        this.txtTritanium.Location = new Point(360, 3);
        this.txtTritanium.Margin = new Padding(0, 3, 0, 0);
        this.txtTritanium.Name = "txtTritanium";
        this.txtTritanium.Size = new Size(70, 13);
        this.txtTritanium.TabIndex = 148;
        this.txtTritanium.Text = "0";
        this.txtTritanium.TextAlign = HorizontalAlignment.Right;
        this.txtTritaniumAcc.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtTritaniumAcc.BorderStyle = BorderStyle.None;
        this.txtTritaniumAcc.ForeColor = Color.FromArgb(128 /*0x80*/, 255, 128 /*0x80*/);
        this.txtTritaniumAcc.Location = new Point(430, 3);
        this.txtTritaniumAcc.Margin = new Padding(0, 3, 0, 0);
        this.txtTritaniumAcc.Name = "txtTritaniumAcc";
        this.txtTritaniumAcc.Size = new Size(30, 13);
        this.txtTritaniumAcc.TabIndex = 149;
        this.txtTritaniumAcc.Text = "0.1";
        this.txtTritaniumAcc.TextAlign = HorizontalAlignment.Center;
        this.txtBoronide.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtBoronide.BorderStyle = BorderStyle.None;
        this.txtBoronide.ForeColor = Color.FromArgb(128 /*0x80*/, 255, 128 /*0x80*/);
        this.txtBoronide.Location = new Point(460, 3);
        this.txtBoronide.Margin = new Padding(0, 3, 0, 0);
        this.txtBoronide.Name = "txtBoronide";
        this.txtBoronide.Size = new Size(70, 13);
        this.txtBoronide.TabIndex = 150;
        this.txtBoronide.Text = "0";
        this.txtBoronide.TextAlign = HorizontalAlignment.Right;
        this.txtBoronideAcc.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtBoronideAcc.BorderStyle = BorderStyle.None;
        this.txtBoronideAcc.ForeColor = Color.FromArgb(128 /*0x80*/, 255, 128 /*0x80*/);
        this.txtBoronideAcc.Location = new Point(530, 3);
        this.txtBoronideAcc.Margin = new Padding(0, 3, 0, 0);
        this.txtBoronideAcc.Name = "txtBoronideAcc";
        this.txtBoronideAcc.Size = new Size(30, 13);
        this.txtBoronideAcc.TabIndex = 151;
        this.txtBoronideAcc.Text = "0.1";
        this.txtBoronideAcc.TextAlign = HorizontalAlignment.Center;
        this.txtMercassium.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtMercassium.BorderStyle = BorderStyle.None;
        this.txtMercassium.ForeColor = Color.FromArgb(128 /*0x80*/, 255, 128 /*0x80*/);
        this.txtMercassium.Location = new Point(560, 3);
        this.txtMercassium.Margin = new Padding(0, 3, 0, 0);
        this.txtMercassium.Name = "txtMercassium";
        this.txtMercassium.Size = new Size(70, 13);
        this.txtMercassium.TabIndex = 152;
        this.txtMercassium.Text = "0";
        this.txtMercassium.TextAlign = HorizontalAlignment.Right;
        this.txtMercassiumAcc.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtMercassiumAcc.BorderStyle = BorderStyle.None;
        this.txtMercassiumAcc.ForeColor = Color.FromArgb(128 /*0x80*/, 255, 128 /*0x80*/);
        this.txtMercassiumAcc.Location = new Point(630, 3);
        this.txtMercassiumAcc.Margin = new Padding(0, 3, 0, 0);
        this.txtMercassiumAcc.Name = "txtMercassiumAcc";
        this.txtMercassiumAcc.Size = new Size(30, 13);
        this.txtMercassiumAcc.TabIndex = 153;
        this.txtMercassiumAcc.Text = "0.1";
        this.txtMercassiumAcc.TextAlign = HorizontalAlignment.Center;
        this.txtVendarite.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtVendarite.BorderStyle = BorderStyle.None;
        this.txtVendarite.ForeColor = Color.FromArgb(128 /*0x80*/, 255, 128 /*0x80*/);
        this.txtVendarite.Location = new Point(660, 3);
        this.txtVendarite.Margin = new Padding(0, 3, 0, 0);
        this.txtVendarite.Name = "txtVendarite";
        this.txtVendarite.Size = new Size(70, 13);
        this.txtVendarite.TabIndex = 154;
        this.txtVendarite.Text = "0";
        this.txtVendarite.TextAlign = HorizontalAlignment.Right;
        this.txtVendariteAcc.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtVendariteAcc.BorderStyle = BorderStyle.None;
        this.txtVendariteAcc.ForeColor = Color.FromArgb(128 /*0x80*/, 255, 128 /*0x80*/);
        this.txtVendariteAcc.Location = new Point(730, 3);
        this.txtVendariteAcc.Margin = new Padding(0, 3, 0, 0);
        this.txtVendariteAcc.Name = "txtVendariteAcc";
        this.txtVendariteAcc.Size = new Size(30, 13);
        this.txtVendariteAcc.TabIndex = 155;
        this.txtVendariteAcc.Text = "0.1";
        this.txtVendariteAcc.TextAlign = HorizontalAlignment.Center;
        this.txtSorium.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtSorium.BorderStyle = BorderStyle.None;
        this.txtSorium.ForeColor = Color.FromArgb(128 /*0x80*/, 255, 128 /*0x80*/);
        this.txtSorium.Location = new Point(760, 3);
        this.txtSorium.Margin = new Padding(0, 3, 0, 0);
        this.txtSorium.Name = "txtSorium";
        this.txtSorium.Size = new Size(70, 13);
        this.txtSorium.TabIndex = 156;
        this.txtSorium.Text = "0";
        this.txtSorium.TextAlign = HorizontalAlignment.Right;
        this.txtSoriumAcc.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtSoriumAcc.BorderStyle = BorderStyle.None;
        this.txtSoriumAcc.ForeColor = Color.FromArgb(128 /*0x80*/, 255, 128 /*0x80*/);
        this.txtSoriumAcc.Location = new Point(830, 3);
        this.txtSoriumAcc.Margin = new Padding(0, 3, 0, 0);
        this.txtSoriumAcc.Name = "txtSoriumAcc";
        this.txtSoriumAcc.Size = new Size(30, 13);
        this.txtSoriumAcc.TabIndex = 157;
        this.txtSoriumAcc.Text = "0.1";
        this.txtSoriumAcc.TextAlign = HorizontalAlignment.Center;
        this.txtUridium.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtUridium.BorderStyle = BorderStyle.None;
        this.txtUridium.ForeColor = Color.FromArgb(128 /*0x80*/, 255, 128 /*0x80*/);
        this.txtUridium.Location = new Point(860, 3);
        this.txtUridium.Margin = new Padding(0, 3, 0, 0);
        this.txtUridium.Name = "txtUridium";
        this.txtUridium.Size = new Size(70, 13);
        this.txtUridium.TabIndex = 158;
        this.txtUridium.Text = "0";
        this.txtUridium.TextAlign = HorizontalAlignment.Right;
        this.txtUridiumAcc.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtUridiumAcc.BorderStyle = BorderStyle.None;
        this.txtUridiumAcc.ForeColor = Color.FromArgb(128 /*0x80*/, 255, 128 /*0x80*/);
        this.txtUridiumAcc.Location = new Point(930, 3);
        this.txtUridiumAcc.Margin = new Padding(0, 3, 0, 0);
        this.txtUridiumAcc.Name = "txtUridiumAcc";
        this.txtUridiumAcc.Size = new Size(30, 13);
        this.txtUridiumAcc.TabIndex = 159;
        this.txtUridiumAcc.Text = "0.1";
        this.txtUridiumAcc.TextAlign = HorizontalAlignment.Center;
        this.txtCorundium.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtCorundium.BorderStyle = BorderStyle.None;
        this.txtCorundium.ForeColor = Color.FromArgb(128 /*0x80*/, 255, 128 /*0x80*/);
        this.txtCorundium.Location = new Point(960, 3);
        this.txtCorundium.Margin = new Padding(0, 3, 0, 0);
        this.txtCorundium.Name = "txtCorundium";
        this.txtCorundium.Size = new Size(70, 13);
        this.txtCorundium.TabIndex = 160 /*0xA0*/;
        this.txtCorundium.Text = "0";
        this.txtCorundium.TextAlign = HorizontalAlignment.Right;
        this.txtCorundiumAcc.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtCorundiumAcc.BorderStyle = BorderStyle.None;
        this.txtCorundiumAcc.ForeColor = Color.FromArgb(128 /*0x80*/, 255, 128 /*0x80*/);
        this.txtCorundiumAcc.Location = new Point(1030, 3);
        this.txtCorundiumAcc.Margin = new Padding(0, 3, 0, 0);
        this.txtCorundiumAcc.Name = "txtCorundiumAcc";
        this.txtCorundiumAcc.Size = new Size(30, 13);
        this.txtCorundiumAcc.TabIndex = 161;
        this.txtCorundiumAcc.Text = "0.1";
        this.txtCorundiumAcc.TextAlign = HorizontalAlignment.Center;
        this.txtGallicite.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtGallicite.BorderStyle = BorderStyle.None;
        this.txtGallicite.ForeColor = Color.FromArgb(128 /*0x80*/, 255, 128 /*0x80*/);
        this.txtGallicite.Location = new Point(1060, 3);
        this.txtGallicite.Margin = new Padding(0, 3, 0, 0);
        this.txtGallicite.Name = "txtGallicite";
        this.txtGallicite.Size = new Size(70, 13);
        this.txtGallicite.TabIndex = 162;
        this.txtGallicite.Text = "0";
        this.txtGallicite.TextAlign = HorizontalAlignment.Right;
        this.txtGalliciteAcc.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtGalliciteAcc.BorderStyle = BorderStyle.None;
        this.txtGalliciteAcc.ForeColor = Color.FromArgb(128 /*0x80*/, 255, 128 /*0x80*/);
        this.txtGalliciteAcc.Location = new Point(1130, 3);
        this.txtGalliciteAcc.Margin = new Padding(0, 3, 0, 0);
        this.txtGalliciteAcc.Name = "txtGalliciteAcc";
        this.txtGalliciteAcc.Size = new Size(30, 13);
        this.txtGalliciteAcc.TabIndex = 163;
        this.txtGalliciteAcc.Text = "0.1";
        this.txtGalliciteAcc.TextAlign = HorizontalAlignment.Center;
        this.cboSpecies.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cboSpecies.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cboSpecies.FormattingEnabled = true;
        this.cboSpecies.Location = new Point(3, 36);
        this.cboSpecies.Margin = new Padding(3, 5, 3, 3);
        this.cboSpecies.Name = "cboSpecies";
        this.cboSpecies.Size = new Size(213, 21);
        this.cboSpecies.TabIndex = 113;
        this.cboSpecies.SelectedIndexChanged += this.cboSpecies_SelectedIndexChanged;
        this.flowLayoutPanel2.Controls.Add(this.textBox23);
        this.flowLayoutPanel2.Controls.Add(this.textBox1);
        this.flowLayoutPanel2.Controls.Add(this.textBox2);
        this.flowLayoutPanel2.Controls.Add(this.textBox3);
        this.flowLayoutPanel2.Controls.Add(this.textBox4);
        this.flowLayoutPanel2.Controls.Add(this.textBox5);
        this.flowLayoutPanel2.Controls.Add(this.textBox6);
        this.flowLayoutPanel2.Controls.Add(this.textBox7);
        this.flowLayoutPanel2.Controls.Add(this.textBox8);
        this.flowLayoutPanel2.Controls.Add(this.textBox9);
        this.flowLayoutPanel2.Controls.Add(this.textBox10);
        this.flowLayoutPanel2.Controls.Add(this.textBox11);
        this.flowLayoutPanel2.Controls.Add(this.textBox12);
        this.flowLayoutPanel2.Controls.Add(this.textBox13);
        this.flowLayoutPanel2.Controls.Add(this.textBox14);
        this.flowLayoutPanel2.Controls.Add(this.textBox15);
        this.flowLayoutPanel2.Controls.Add(this.textBox16);
        this.flowLayoutPanel2.Controls.Add(this.textBox17);
        this.flowLayoutPanel2.Controls.Add(this.textBox18);
        this.flowLayoutPanel2.Controls.Add(this.textBox19);
        this.flowLayoutPanel2.Controls.Add(this.textBox20);
        this.flowLayoutPanel2.Controls.Add(this.textBox21);
        this.flowLayoutPanel2.Controls.Add(this.textBox22);
        this.flowLayoutPanel2.Location = new Point(0, 0);
        this.flowLayoutPanel2.Margin = new Padding(0);
        this.flowLayoutPanel2.Name = "flowLayoutPanel2";
        this.flowLayoutPanel2.Size = new Size(1185, 21);
        this.flowLayoutPanel2.TabIndex = 114;
        this.textBox23.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.textBox23.BorderStyle = BorderStyle.None;
        this.textBox23.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.textBox23.Location = new Point(0, 3);
        this.textBox23.Margin = new Padding(0, 3, 0, 0);
        this.textBox23.Name = "textBox23";
        this.textBox23.ReadOnly = true;
        this.textBox23.Size = new Size(60, 13);
        this.textBox23.TabIndex = 143;
        this.textBox23.Text = "Max CC";
        this.textBox23.TextAlign = HorizontalAlignment.Center;
        this.textBox1.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.textBox1.BorderStyle = BorderStyle.None;
        this.textBox1.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.textBox1.Location = new Point(60, 3);
        this.textBox1.Margin = new Padding(0, 3, 0, 0);
        this.textBox1.Name = "textBox1";
        this.textBox1.ReadOnly = true;
        this.textBox1.Size = new Size(70, 13);
        this.textBox1.TabIndex = 142;
        this.textBox1.Text = "Duranium";
        this.textBox1.TextAlign = HorizontalAlignment.Right;
        this.textBox2.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.textBox2.BorderStyle = BorderStyle.None;
        this.textBox2.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.textBox2.Location = new Point(130, 3);
        this.textBox2.Margin = new Padding(0, 3, 0, 0);
        this.textBox2.Name = "textBox2";
        this.textBox2.ReadOnly = true;
        this.textBox2.Size = new Size(30, 13);
        this.textBox2.TabIndex = 143;
        this.textBox2.TextAlign = HorizontalAlignment.Center;
        this.textBox3.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.textBox3.BorderStyle = BorderStyle.None;
        this.textBox3.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.textBox3.Location = new Point(160 /*0xA0*/, 3);
        this.textBox3.Margin = new Padding(0, 3, 0, 0);
        this.textBox3.Name = "textBox3";
        this.textBox3.ReadOnly = true;
        this.textBox3.Size = new Size(70, 13);
        this.textBox3.TabIndex = 144 /*0x90*/;
        this.textBox3.Text = "Neutronium";
        this.textBox3.TextAlign = HorizontalAlignment.Right;
        this.textBox4.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.textBox4.BorderStyle = BorderStyle.None;
        this.textBox4.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.textBox4.Location = new Point(230, 3);
        this.textBox4.Margin = new Padding(0, 3, 0, 0);
        this.textBox4.Name = "textBox4";
        this.textBox4.ReadOnly = true;
        this.textBox4.Size = new Size(30, 13);
        this.textBox4.TabIndex = 145;
        this.textBox4.TextAlign = HorizontalAlignment.Center;
        this.textBox5.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.textBox5.BorderStyle = BorderStyle.None;
        this.textBox5.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.textBox5.Location = new Point(260, 3);
        this.textBox5.Margin = new Padding(0, 3, 0, 0);
        this.textBox5.Name = "textBox5";
        this.textBox5.ReadOnly = true;
        this.textBox5.Size = new Size(70, 13);
        this.textBox5.TabIndex = 146;
        this.textBox5.Text = "Corbomite";
        this.textBox5.TextAlign = HorizontalAlignment.Right;
        this.textBox6.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.textBox6.BorderStyle = BorderStyle.None;
        this.textBox6.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.textBox6.Location = new Point(330, 3);
        this.textBox6.Margin = new Padding(0, 3, 0, 0);
        this.textBox6.Name = "textBox6";
        this.textBox6.ReadOnly = true;
        this.textBox6.Size = new Size(30, 13);
        this.textBox6.TabIndex = 147;
        this.textBox6.TextAlign = HorizontalAlignment.Center;
        this.textBox7.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.textBox7.BorderStyle = BorderStyle.None;
        this.textBox7.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.textBox7.Location = new Point(360, 3);
        this.textBox7.Margin = new Padding(0, 3, 0, 0);
        this.textBox7.Name = "textBox7";
        this.textBox7.ReadOnly = true;
        this.textBox7.Size = new Size(70, 13);
        this.textBox7.TabIndex = 148;
        this.textBox7.Text = "Tritanium";
        this.textBox7.TextAlign = HorizontalAlignment.Right;
        this.textBox8.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.textBox8.BorderStyle = BorderStyle.None;
        this.textBox8.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.textBox8.Location = new Point(430, 3);
        this.textBox8.Margin = new Padding(0, 3, 0, 0);
        this.textBox8.Name = "textBox8";
        this.textBox8.ReadOnly = true;
        this.textBox8.Size = new Size(30, 13);
        this.textBox8.TabIndex = 149;
        this.textBox8.TextAlign = HorizontalAlignment.Center;
        this.textBox9.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.textBox9.BorderStyle = BorderStyle.None;
        this.textBox9.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.textBox9.Location = new Point(460, 3);
        this.textBox9.Margin = new Padding(0, 3, 0, 0);
        this.textBox9.Name = "textBox9";
        this.textBox9.ReadOnly = true;
        this.textBox9.Size = new Size(70, 13);
        this.textBox9.TabIndex = 150;
        this.textBox9.Text = "Boronide";
        this.textBox9.TextAlign = HorizontalAlignment.Right;
        this.textBox10.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.textBox10.BorderStyle = BorderStyle.None;
        this.textBox10.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.textBox10.Location = new Point(530, 3);
        this.textBox10.Margin = new Padding(0, 3, 0, 0);
        this.textBox10.Name = "textBox10";
        this.textBox10.ReadOnly = true;
        this.textBox10.Size = new Size(30, 13);
        this.textBox10.TabIndex = 151;
        this.textBox10.TextAlign = HorizontalAlignment.Center;
        this.textBox11.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.textBox11.BorderStyle = BorderStyle.None;
        this.textBox11.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.textBox11.Location = new Point(560, 3);
        this.textBox11.Margin = new Padding(0, 3, 0, 0);
        this.textBox11.Name = "textBox11";
        this.textBox11.ReadOnly = true;
        this.textBox11.Size = new Size(70, 13);
        this.textBox11.TabIndex = 152;
        this.textBox11.Text = "Mercassium";
        this.textBox11.TextAlign = HorizontalAlignment.Right;
        this.textBox12.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.textBox12.BorderStyle = BorderStyle.None;
        this.textBox12.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.textBox12.Location = new Point(630, 3);
        this.textBox12.Margin = new Padding(0, 3, 0, 0);
        this.textBox12.Name = "textBox12";
        this.textBox12.ReadOnly = true;
        this.textBox12.Size = new Size(30, 13);
        this.textBox12.TabIndex = 153;
        this.textBox12.TextAlign = HorizontalAlignment.Center;
        this.textBox13.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.textBox13.BorderStyle = BorderStyle.None;
        this.textBox13.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.textBox13.Location = new Point(660, 3);
        this.textBox13.Margin = new Padding(0, 3, 0, 0);
        this.textBox13.Name = "textBox13";
        this.textBox13.ReadOnly = true;
        this.textBox13.Size = new Size(70, 13);
        this.textBox13.TabIndex = 154;
        this.textBox13.Text = "Vendarite";
        this.textBox13.TextAlign = HorizontalAlignment.Right;
        this.textBox14.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.textBox14.BorderStyle = BorderStyle.None;
        this.textBox14.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.textBox14.Location = new Point(730, 3);
        this.textBox14.Margin = new Padding(0, 3, 0, 0);
        this.textBox14.Name = "textBox14";
        this.textBox14.ReadOnly = true;
        this.textBox14.Size = new Size(30, 13);
        this.textBox14.TabIndex = 155;
        this.textBox14.TextAlign = HorizontalAlignment.Center;
        this.textBox15.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.textBox15.BorderStyle = BorderStyle.None;
        this.textBox15.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.textBox15.Location = new Point(760, 3);
        this.textBox15.Margin = new Padding(0, 3, 0, 0);
        this.textBox15.Name = "textBox15";
        this.textBox15.ReadOnly = true;
        this.textBox15.Size = new Size(70, 13);
        this.textBox15.TabIndex = 156;
        this.textBox15.Text = "Sorium";
        this.textBox15.TextAlign = HorizontalAlignment.Right;
        this.textBox16.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.textBox16.BorderStyle = BorderStyle.None;
        this.textBox16.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.textBox16.Location = new Point(830, 3);
        this.textBox16.Margin = new Padding(0, 3, 0, 0);
        this.textBox16.Name = "textBox16";
        this.textBox16.ReadOnly = true;
        this.textBox16.Size = new Size(30, 13);
        this.textBox16.TabIndex = 157;
        this.textBox16.TextAlign = HorizontalAlignment.Center;
        this.textBox17.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.textBox17.BorderStyle = BorderStyle.None;
        this.textBox17.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.textBox17.Location = new Point(860, 3);
        this.textBox17.Margin = new Padding(0, 3, 0, 0);
        this.textBox17.Name = "textBox17";
        this.textBox17.ReadOnly = true;
        this.textBox17.Size = new Size(70, 13);
        this.textBox17.TabIndex = 158;
        this.textBox17.Text = "Uridium";
        this.textBox17.TextAlign = HorizontalAlignment.Right;
        this.textBox18.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.textBox18.BorderStyle = BorderStyle.None;
        this.textBox18.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.textBox18.Location = new Point(930, 3);
        this.textBox18.Margin = new Padding(0, 3, 0, 0);
        this.textBox18.Name = "textBox18";
        this.textBox18.ReadOnly = true;
        this.textBox18.Size = new Size(30, 13);
        this.textBox18.TabIndex = 159;
        this.textBox18.TextAlign = HorizontalAlignment.Center;
        this.textBox19.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.textBox19.BorderStyle = BorderStyle.None;
        this.textBox19.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.textBox19.Location = new Point(960, 3);
        this.textBox19.Margin = new Padding(0, 3, 0, 0);
        this.textBox19.Name = "textBox19";
        this.textBox19.ReadOnly = true;
        this.textBox19.Size = new Size(70, 13);
        this.textBox19.TabIndex = 160 /*0xA0*/;
        this.textBox19.Text = "Corundium";
        this.textBox19.TextAlign = HorizontalAlignment.Right;
        this.textBox20.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.textBox20.BorderStyle = BorderStyle.None;
        this.textBox20.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.textBox20.Location = new Point(1030, 3);
        this.textBox20.Margin = new Padding(0, 3, 0, 0);
        this.textBox20.Name = "textBox20";
        this.textBox20.ReadOnly = true;
        this.textBox20.Size = new Size(30, 13);
        this.textBox20.TabIndex = 161;
        this.textBox20.TextAlign = HorizontalAlignment.Center;
        this.textBox21.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.textBox21.BorderStyle = BorderStyle.None;
        this.textBox21.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.textBox21.Location = new Point(1060, 3);
        this.textBox21.Margin = new Padding(0, 3, 0, 0);
        this.textBox21.Name = "textBox21";
        this.textBox21.ReadOnly = true;
        this.textBox21.Size = new Size(70, 13);
        this.textBox21.TabIndex = 162;
        this.textBox21.Text = "Gallicite";
        this.textBox21.TextAlign = HorizontalAlignment.Right;
        this.textBox22.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.textBox22.BorderStyle = BorderStyle.None;
        this.textBox22.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.textBox22.Location = new Point(1130, 3);
        this.textBox22.Margin = new Padding(0, 3, 0, 0);
        this.textBox22.Name = "textBox22";
        this.textBox22.ReadOnly = true;
        this.textBox22.Size = new Size(30, 13);
        this.textBox22.TabIndex = 163;
        this.textBox22.TextAlign = HorizontalAlignment.Center;
        this.cmdSearch.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdSearch.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdSearch.Location = new Point(0, 0);
        this.cmdSearch.Margin = new Padding(0);
        this.cmdSearch.Name = "cmdSearch";
        this.cmdSearch.Size = new Size(96 /*0x60*/, 30);
        this.cmdSearch.TabIndex = 132;
        this.cmdSearch.Tag = "1200";
        this.cmdSearch.Text = "Search";
        this.cmdSearch.UseVisualStyleBackColor = false;
        this.cmdSearch.Click += this.cmdSearch_Click;
        this.chkExcludeHighG.AutoSize = true;
        this.chkExcludeHighG.Location = new Point(635, 8);
        this.chkExcludeHighG.Margin = new Padding(3, 8, 3, 3);
        this.chkExcludeHighG.Name = "chkExcludeHighG";
        this.chkExcludeHighG.Padding = new Padding(5, 0, 0, 0);
        this.chkExcludeHighG.Size = new Size(88, 17);
        this.chkExcludeHighG.TabIndex = 133;
        this.chkExcludeHighG.Text = "Exc. High-G";
        this.chkExcludeHighG.TextAlign = ContentAlignment.MiddleRight;
        this.chkExcludeHighG.UseVisualStyleBackColor = true;
        this.chkExcludeHighG.CheckedChanged += this.chkExcludeHighG_CheckedChanged;
        this.flowLayoutPanel3.Controls.Add(this.cboRaces);
        this.flowLayoutPanel3.Controls.Add(this.chkExcludeAlien);
        this.flowLayoutPanel3.Controls.Add(this.chkColonyCost);
        this.flowLayoutPanel3.Controls.Add(this.chkUseMaxCC);
        this.flowLayoutPanel3.Controls.Add(this.chkHabColour);
        this.flowLayoutPanel3.Controls.Add(this.chkOMEligible);
        this.flowLayoutPanel3.Controls.Add(this.chkExcludeHighG);
        this.flowLayoutPanel3.Controls.Add(this.chkSearchFlag);
        this.flowLayoutPanel3.Controls.Add(this.flowLayoutPanel4);
        this.flowLayoutPanel3.Controls.Add(this.flowLayoutPanel5);
        this.flowLayoutPanel3.Location = new Point(3, 3);
        this.flowLayoutPanel3.Name = "flowLayoutPanel3";
        this.flowLayoutPanel3.Size = new Size(1418, 31 /*0x1F*/);
        this.flowLayoutPanel3.TabIndex = 134;
        this.chkExcludeAlien.AutoSize = true;
        this.chkExcludeAlien.Location = new Point(219, 8);
        this.chkExcludeAlien.Margin = new Padding(3, 8, 3, 3);
        this.chkExcludeAlien.Name = "chkExcludeAlien";
        this.chkExcludeAlien.Padding = new Padding(5, 0, 0, 0);
        this.chkExcludeAlien.Size = new Size(71, 17);
        this.chkExcludeAlien.TabIndex = 137;
        this.chkExcludeAlien.Text = "No Alien";
        this.chkExcludeAlien.TextAlign = ContentAlignment.MiddleRight;
        this.chkExcludeAlien.UseVisualStyleBackColor = true;
        this.chkColonyCost.AutoSize = true;
        this.chkColonyCost.Location = new Point(296, 8);
        this.chkColonyCost.Margin = new Padding(3, 8, 3, 3);
        this.chkColonyCost.Name = "chkColonyCost";
        this.chkColonyCost.Padding = new Padding(5, 0, 0, 0);
        this.chkColonyCost.Size = new Size(79, 17);
        this.chkColonyCost.TabIndex = 138;
        this.chkColonyCost.Text = "Check CC";
        this.chkColonyCost.TextAlign = ContentAlignment.MiddleRight;
        this.chkColonyCost.UseVisualStyleBackColor = true;
        this.chkUseMaxCC.AutoSize = true;
        this.chkUseMaxCC.Location = new Point(381, 8);
        this.chkUseMaxCC.Margin = new Padding(3, 8, 3, 3);
        this.chkUseMaxCC.Name = "chkUseMaxCC";
        this.chkUseMaxCC.Padding = new Padding(5, 0, 0, 0);
        this.chkUseMaxCC.Size = new Size(68, 17);
        this.chkUseMaxCC.TabIndex = 140;
        this.chkUseMaxCC.Text = "Max CC";
        this.chkUseMaxCC.TextAlign = ContentAlignment.MiddleRight;
        this.chkUseMaxCC.UseVisualStyleBackColor = true;
        this.chkHabColour.AutoSize = true;
        this.chkHabColour.Checked = true;
        this.chkHabColour.CheckState = CheckState.Checked;
        this.chkHabColour.Location = new Point(455, 8);
        this.chkHabColour.Margin = new Padding(3, 8, 3, 3);
        this.chkHabColour.Name = "chkHabColour";
        this.chkHabColour.Padding = new Padding(5, 0, 0, 0);
        this.chkHabColour.Size = new Size(84, 17);
        this.chkHabColour.TabIndex = 141;
        this.chkHabColour.Text = "Hab Colour";
        this.chkHabColour.TextAlign = ContentAlignment.MiddleRight;
        this.chkHabColour.UseVisualStyleBackColor = true;
        this.chkHabColour.CheckedChanged += this.chkHabColour_CheckedChanged;
        this.chkOMEligible.AutoSize = true;
        this.chkOMEligible.Location = new Point(545, 8);
        this.chkOMEligible.Margin = new Padding(3, 8, 3, 3);
        this.chkOMEligible.Name = "chkOMEligible";
        this.chkOMEligible.Padding = new Padding(5, 0, 0, 0);
        this.chkOMEligible.Size = new Size(84, 17);
        this.chkOMEligible.TabIndex = 140;
        this.chkOMEligible.Text = "OM Eligible";
        this.chkOMEligible.TextAlign = ContentAlignment.MiddleRight;
        this.chkOMEligible.UseVisualStyleBackColor = true;
        this.chkSearchFlag.AutoSize = true;
        this.chkSearchFlag.Location = new Point(729, 8);
        this.chkSearchFlag.Margin = new Padding(3, 8, 3, 3);
        this.chkSearchFlag.Name = "chkSearchFlag";
        this.chkSearchFlag.Padding = new Padding(5, 0, 0, 0);
        this.chkSearchFlag.Size = new Size(88, 17);
        this.chkSearchFlag.TabIndex = 141;
        this.chkSearchFlag.Text = "Search Flag";
        this.chkSearchFlag.TextAlign = ContentAlignment.MiddleRight;
        this.chkSearchFlag.UseVisualStyleBackColor = true;
        this.flowLayoutPanel4.Controls.Add(this.rdoIncludeGG);
        this.flowLayoutPanel4.Controls.Add(this.rdoExcludeGG);
        this.flowLayoutPanel4.Controls.Add(this.rdoGGOnly);
        this.flowLayoutPanel4.Location = new Point(826, 4);
        this.flowLayoutPanel4.Margin = new Padding(6, 4, 0, 0);
        this.flowLayoutPanel4.Name = "flowLayoutPanel4";
        this.flowLayoutPanel4.Size = new Size(318, 24);
        this.flowLayoutPanel4.TabIndex = 135;
        this.rdoIncludeGG.AutoSize = true;
        this.rdoIncludeGG.Checked = true;
        this.rdoIncludeGG.Location = new Point(3, 3);
        this.rdoIncludeGG.Name = "rdoIncludeGG";
        this.rdoIncludeGG.Size = new Size(98, 17);
        this.rdoIncludeGG.TabIndex = 0;
        this.rdoIncludeGG.TabStop = true;
        this.rdoIncludeGG.Text = "Inc. Gas Giants";
        this.rdoIncludeGG.UseVisualStyleBackColor = true;
        this.rdoExcludeGG.AutoSize = true;
        this.rdoExcludeGG.Location = new Point(107, 3);
        this.rdoExcludeGG.Name = "rdoExcludeGG";
        this.rdoExcludeGG.Size = new Size(101, 17);
        this.rdoExcludeGG.TabIndex = 1;
        this.rdoExcludeGG.Text = "Exc. Gas Giants";
        this.rdoExcludeGG.UseVisualStyleBackColor = true;
        this.rdoGGOnly.AutoSize = true;
        this.rdoGGOnly.Location = new Point(214, 3);
        this.rdoGGOnly.Name = "rdoGGOnly";
        this.rdoGGOnly.Size = new Size(101, 17);
        this.rdoGGOnly.TabIndex = 2;
        this.rdoGGOnly.Text = "Gas Giants Only";
        this.rdoGGOnly.UseVisualStyleBackColor = true;
        this.flowLayoutPanel5.Controls.Add(this.rdoIncludeAst);
        this.flowLayoutPanel5.Controls.Add(this.rdoExcludeAst);
        this.flowLayoutPanel5.Controls.Add(this.rdoAstOnly);
        this.flowLayoutPanel5.Location = new Point(1150, 4);
        this.flowLayoutPanel5.Margin = new Padding(6, 4, 0, 0);
        this.flowLayoutPanel5.Name = "flowLayoutPanel5";
        this.flowLayoutPanel5.Size = new Size(221, 24);
        this.flowLayoutPanel5.TabIndex = 136;
        this.rdoIncludeAst.AutoSize = true;
        this.rdoIncludeAst.Checked = true;
        this.rdoIncludeAst.Location = new Point(3, 3);
        this.rdoIncludeAst.Name = "rdoIncludeAst";
        this.rdoIncludeAst.Size = new Size(64 /*0x40*/, 17);
        this.rdoIncludeAst.TabIndex = 0;
        this.rdoIncludeAst.TabStop = true;
        this.rdoIncludeAst.Text = "Inc. Ast.";
        this.rdoIncludeAst.UseVisualStyleBackColor = true;
        this.rdoExcludeAst.AutoSize = true;
        this.rdoExcludeAst.Location = new Point(73, 3);
        this.rdoExcludeAst.Name = "rdoExcludeAst";
        this.rdoExcludeAst.Size = new Size(67, 17);
        this.rdoExcludeAst.TabIndex = 1;
        this.rdoExcludeAst.Text = "Exc. Ast.";
        this.rdoExcludeAst.UseVisualStyleBackColor = true;
        this.rdoAstOnly.AutoSize = true;
        this.rdoAstOnly.Location = new Point(146, 3);
        this.rdoAstOnly.Name = "rdoAstOnly";
        this.rdoAstOnly.Size = new Size(67, 17);
        this.rdoAstOnly.TabIndex = 2;
        this.rdoAstOnly.Text = "Ast. Only";
        this.rdoAstOnly.UseVisualStyleBackColor = true;
        this.flpMineralSearch.BorderStyle = BorderStyle.FixedSingle;
        this.flpMineralSearch.Controls.Add(this.flowLayoutPanel2);
        this.flpMineralSearch.Controls.Add(this.flowLayoutPanel1);
        this.flpMineralSearch.Location = new Point(440, 0);
        this.flpMineralSearch.Margin = new Padding(0);
        this.flpMineralSearch.Name = "flpMineralSearch";
        this.flpMineralSearch.Size = new Size(1180, 45);
        this.flpMineralSearch.TabIndex = 135;
        this.cmdCreate.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdCreate.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdCreate.Location = new Point(96 /*0x60*/, 0);
        this.cmdCreate.Margin = new Padding(0);
        this.cmdCreate.Name = "cmdCreate";
        this.cmdCreate.Size = new Size(96 /*0x60*/, 30);
        this.cmdCreate.TabIndex = 136;
        this.cmdCreate.Tag = "1200";
        this.cmdCreate.Text = "Create Colony";
        this.cmdCreate.UseVisualStyleBackColor = false;
        this.cmdCreate.Click += this.cmdCreate_Click;
        this.cmdClear.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdClear.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdClear.Location = new Point(192 /*0xC0*/, 0);
        this.cmdClear.Margin = new Padding(0);
        this.cmdClear.Name = "cmdClear";
        this.cmdClear.Size = new Size(96 /*0x60*/, 30);
        this.cmdClear.TabIndex = 137;
        this.cmdClear.Tag = "1200";
        this.cmdClear.Text = "Clear Search";
        this.cmdClear.UseVisualStyleBackColor = false;
        this.cmdClear.Click += this.cmdClear_Click;
        this.flowLayoutPanel7.Controls.Add(this.cmdSearch);
        this.flowLayoutPanel7.Controls.Add(this.cmdCreate);
        this.flowLayoutPanel7.Controls.Add(this.cmdClear);
        this.flowLayoutPanel7.Controls.Add(this.cmdSuperWide);
        this.flowLayoutPanel7.Controls.Add(this.chkCentreOnBody);
        this.flowLayoutPanel7.Controls.Add(this.chkCentreOnSystem);
        this.flowLayoutPanel7.Location = new Point(6, 813);
        this.flowLayoutPanel7.Name = "flowLayoutPanel7";
        this.flowLayoutPanel7.Size = new Size(1415, 30);
        this.flowLayoutPanel7.TabIndex = 138;
        this.cmdSuperWide.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdSuperWide.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdSuperWide.Location = new Point(288, 0);
        this.cmdSuperWide.Margin = new Padding(0);
        this.cmdSuperWide.Name = "cmdSuperWide";
        this.cmdSuperWide.Size = new Size(96 /*0x60*/, 30);
        this.cmdSuperWide.TabIndex = 139;
        this.cmdSuperWide.Tag = "1200";
        this.cmdSuperWide.Text = "Wide View";
        this.cmdSuperWide.UseVisualStyleBackColor = false;
        this.cmdSuperWide.Click += this.cmdSuperWide_Click;
        this.chkCentreOnBody.AutoSize = true;
        this.chkCentreOnBody.Location = new Point(390, 8);
        this.chkCentreOnBody.Margin = new Padding(6, 8, 3, 3);
        this.chkCentreOnBody.Name = "chkCentreOnBody";
        this.chkCentreOnBody.Padding = new Padding(5, 0, 0, 0);
        this.chkCentreOnBody.Size = new Size(149, 17);
        this.chkCentreOnBody.TabIndex = 138;
        this.chkCentreOnBody.Text = "Centre on Selected Body";
        this.chkCentreOnBody.TextAlign = ContentAlignment.MiddleRight;
        this.chkCentreOnBody.UseVisualStyleBackColor = true;
        this.cboSystems.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cboSystems.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cboSystems.FormattingEnabled = true;
        this.cboSystems.Location = new Point(3, 64 /*0x40*/);
        this.cboSystems.Margin = new Padding(3, 5, 3, 3);
        this.cboSystems.Name = "cboSystems";
        this.cboSystems.Size = new Size(213, 21);
        this.cboSystems.TabIndex = 139;
        this.cboSystems.SelectedIndexChanged += this.cboSystems_SelectedIndexChanged;
        this.lstvMineralsWide.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.lstvMineralsWide.BorderStyle = BorderStyle.FixedSingle;
        this.lstvMineralsWide.Columns.AddRange(new ColumnHeader[30]
        {
            this.columnHeader_25,
            this.columnHeader_26,
            this.columnHeader_53,
            this.columnHeader_54,
            this.columnHeader_50,
            this.columnHeader_51,
            this.columnHeader_52,
            this.columnHeader_27,
            this.columnHeader_28,
            this.columnHeader_29,
            this.columnHeader_30,
            this.columnHeader_31,
            this.columnHeader_32,
            this.columnHeader_33,
            this.columnHeader_34,
            this.columnHeader_35,
            this.columnHeader_36,
            this.columnHeader_37,
            this.columnHeader_38,
            this.columnHeader_39,
            this.columnHeader_40,
            this.columnHeader_41,
            this.columnHeader_42,
            this.columnHeader_43,
            this.columnHeader_44,
            this.columnHeader_45,
            this.columnHeader_46,
            this.columnHeader_47,
            this.columnHeader_48,
            this.columnHeader_49
        });
        this.lstvMineralsWide.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.lstvMineralsWide.FullRowSelect = true;
        this.lstvMineralsWide.HeaderStyle = ColumnHeaderStyle.None;
        this.lstvMineralsWide.HideSelection = false;
        this.lstvMineralsWide.Location = new Point(3, 92);
        this.lstvMineralsWide.Name = "lstvMineralsWide";
        this.lstvMineralsWide.Size = new Size(1834, 717);
        this.lstvMineralsWide.TabIndex = 140;
        this.lstvMineralsWide.UseCompatibleStateImageBehavior = false;
        this.lstvMineralsWide.View = View.Details;
        this.lstvMineralsWide.Visible = false;
        this.lstvMineralsWide.SelectedIndexChanged += this.lstvMineralsWide_SelectedIndexChanged;
        this.columnHeader_25.Width = 100;
        this.columnHeader_26.Width = 120;
        this.columnHeader_53.Width = 140;
        this.columnHeader_54.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_50.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_50.Width = 80 /*0x50*/;
        this.columnHeader_51.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_51.Width = 80 /*0x50*/;
        this.columnHeader_52.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_27.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_28.TextAlign = HorizontalAlignment.Right;
        this.columnHeader_28.Width = 70;
        this.columnHeader_29.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_29.Width = 30;
        this.columnHeader_30.TextAlign = HorizontalAlignment.Right;
        this.columnHeader_30.Width = 70;
        this.columnHeader_31.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_31.Width = 30;
        this.columnHeader_32.TextAlign = HorizontalAlignment.Right;
        this.columnHeader_32.Width = 70;
        this.columnHeader_33.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_33.Width = 30;
        this.columnHeader_34.TextAlign = HorizontalAlignment.Right;
        this.columnHeader_34.Width = 70;
        this.columnHeader_35.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_35.Width = 30;
        this.columnHeader_36.TextAlign = HorizontalAlignment.Right;
        this.columnHeader_36.Width = 70;
        this.columnHeader_37.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_37.Width = 30;
        this.columnHeader_38.TextAlign = HorizontalAlignment.Right;
        this.columnHeader_38.Width = 70;
        this.columnHeader_39.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_39.Width = 30;
        this.columnHeader_40.TextAlign = HorizontalAlignment.Right;
        this.columnHeader_40.Width = 70;
        this.columnHeader_41.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_41.Width = 30;
        this.columnHeader_42.TextAlign = HorizontalAlignment.Right;
        this.columnHeader_42.Width = 70;
        this.columnHeader_43.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_43.Width = 30;
        this.columnHeader_44.TextAlign = HorizontalAlignment.Right;
        this.columnHeader_44.Width = 70;
        this.columnHeader_45.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_45.Width = 30;
        this.columnHeader_46.TextAlign = HorizontalAlignment.Right;
        this.columnHeader_46.Width = 70;
        this.columnHeader_47.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_47.Width = 30;
        this.columnHeader_48.TextAlign = HorizontalAlignment.Right;
        this.columnHeader_48.Width = 70;
        this.columnHeader_49.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_49.Width = 30;
        this.flpWideStats.Controls.Add(this.textBox24);
        this.flpWideStats.Controls.Add(this.textBox25);
        this.flpWideStats.Controls.Add(this.textBox26);
        this.flpWideStats.Controls.Add(this.textBox27);
        this.flpWideStats.Controls.Add(this.textBox28);
        this.flpWideStats.Controls.Add(this.flowLayoutPanel6);
        this.flpWideStats.Location = new Point(0, 0);
        this.flpWideStats.Margin = new Padding(0);
        this.flpWideStats.Name = "flpWideStats";
        this.flpWideStats.Size = new Size(440, 45);
        this.flpWideStats.TabIndex = 141;
        this.textBox24.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.textBox24.BorderStyle = BorderStyle.None;
        this.textBox24.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.textBox24.Location = new Point(3, 3);
        this.textBox24.Margin = new Padding(3, 3, 0, 0);
        this.textBox24.Name = "textBox24";
        this.textBox24.ReadOnly = true;
        this.textBox24.Size = new Size(137, 13);
        this.textBox24.TabIndex = 144 /*0x90*/;
        this.textBox24.Text = "Atmosphere";
        this.textBox25.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.textBox25.BorderStyle = BorderStyle.None;
        this.textBox25.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.textBox25.Location = new Point(140, 3);
        this.textBox25.Margin = new Padding(0, 3, 0, 0);
        this.textBox25.Name = "textBox25";
        this.textBox25.ReadOnly = true;
        this.textBox25.Size = new Size(60, 13);
        this.textBox25.TabIndex = 145;
        this.textBox25.Text = "Pressure";
        this.textBox25.TextAlign = HorizontalAlignment.Center;
        this.textBox26.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.textBox26.BorderStyle = BorderStyle.None;
        this.textBox26.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.textBox26.Location = new Point(200, 3);
        this.textBox26.Margin = new Padding(0, 3, 0, 0);
        this.textBox26.Name = "textBox26";
        this.textBox26.ReadOnly = true;
        this.textBox26.Size = new Size(80 /*0x50*/, 13);
        this.textBox26.TabIndex = 146;
        this.textBox26.Text = "Diameter";
        this.textBox26.TextAlign = HorizontalAlignment.Center;
        this.textBox27.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.textBox27.BorderStyle = BorderStyle.None;
        this.textBox27.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.textBox27.Location = new Point(280, 3);
        this.textBox27.Margin = new Padding(0, 3, 0, 0);
        this.textBox27.Name = "textBox27";
        this.textBox27.ReadOnly = true;
        this.textBox27.Size = new Size(80 /*0x50*/, 13);
        this.textBox27.TabIndex = 147;
        this.textBox27.Text = "Gravity";
        this.textBox27.TextAlign = HorizontalAlignment.Center;
        this.textBox28.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.textBox28.BorderStyle = BorderStyle.None;
        this.textBox28.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.textBox28.Location = new Point(360, 3);
        this.textBox28.Margin = new Padding(0, 3, 0, 0);
        this.textBox28.Name = "textBox28";
        this.textBox28.ReadOnly = true;
        this.textBox28.Size = new Size(60, 13);
        this.textBox28.TabIndex = 148;
        this.textBox28.Text = "Terra Rate";
        this.textBox28.TextAlign = HorizontalAlignment.Center;
        this.flowLayoutPanel6.Controls.Add(this.textBox29);
        this.flowLayoutPanel6.Controls.Add(this.textBox30);
        this.flowLayoutPanel6.Controls.Add(this.txtMaxDiameter);
        this.flowLayoutPanel6.Controls.Add(this.txtMinGravity);
        this.flowLayoutPanel6.Location = new Point(0, 24);
        this.flowLayoutPanel6.Margin = new Padding(0, 8, 3, 3);
        this.flowLayoutPanel6.Name = "flowLayoutPanel6";
        this.flowLayoutPanel6.Size = new Size(391, 21);
        this.flowLayoutPanel6.TabIndex = 143;
        this.textBox29.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.textBox29.BorderStyle = BorderStyle.None;
        this.textBox29.Enabled = false;
        this.textBox29.ForeColor = Color.FromArgb(128 /*0x80*/, 255, 128 /*0x80*/);
        this.textBox29.Location = new Point(0, 3);
        this.textBox29.Margin = new Padding(0, 3, 0, 0);
        this.textBox29.Name = "textBox29";
        this.textBox29.Size = new Size(140, 13);
        this.textBox29.TabIndex = 143;
        this.textBox29.TextAlign = HorizontalAlignment.Center;
        this.textBox30.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.textBox30.BorderStyle = BorderStyle.None;
        this.textBox30.Enabled = false;
        this.textBox30.ForeColor = Color.FromArgb(128 /*0x80*/, 255, 128 /*0x80*/);
        this.textBox30.Location = new Point(140, 3);
        this.textBox30.Margin = new Padding(0, 3, 0, 0);
        this.textBox30.Name = "textBox30";
        this.textBox30.Size = new Size(60, 13);
        this.textBox30.TabIndex = 142;
        this.textBox30.TextAlign = HorizontalAlignment.Right;
        this.txtMaxDiameter.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtMaxDiameter.BorderStyle = BorderStyle.None;
        this.txtMaxDiameter.ForeColor = Color.FromArgb(128 /*0x80*/, 255, 128 /*0x80*/);
        this.txtMaxDiameter.Location = new Point(200, 3);
        this.txtMaxDiameter.Margin = new Padding(0, 3, 0, 0);
        this.txtMaxDiameter.Name = "txtMaxDiameter";
        this.txtMaxDiameter.Size = new Size(80 /*0x50*/, 13);
        this.txtMaxDiameter.TabIndex = 144 /*0x90*/;
        this.txtMaxDiameter.Text = "0";
        this.txtMaxDiameter.TextAlign = HorizontalAlignment.Center;
        this.txtMinGravity.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtMinGravity.BorderStyle = BorderStyle.None;
        this.txtMinGravity.ForeColor = Color.FromArgb(128 /*0x80*/, 255, 128 /*0x80*/);
        this.txtMinGravity.Location = new Point(280, 3);
        this.txtMinGravity.Margin = new Padding(0, 3, 0, 0);
        this.txtMinGravity.Name = "txtMinGravity";
        this.txtMinGravity.Size = new Size(80 /*0x50*/, 13);
        this.txtMinGravity.TabIndex = 146;
        this.txtMinGravity.Text = "0";
        this.txtMinGravity.TextAlign = HorizontalAlignment.Center;
        this.flpTopLevel.Controls.Add(this.flpWideStats);
        this.flpTopLevel.Controls.Add(this.flpMineralSearch);
        this.flpTopLevel.Location = new Point(223, 40);
        this.flpTopLevel.Name = "flpTopLevel";
        this.flpTopLevel.Size = new Size(1658, 45);
        this.flpTopLevel.TabIndex = 142;
        this.chkCentreOnSystem.AutoSize = true;
        this.chkCentreOnSystem.Location = new Point(548, 8);
        this.chkCentreOnSystem.Margin = new Padding(6, 8, 3, 3);
        this.chkCentreOnSystem.Name = "chkCentreOnSystem";
        this.chkCentreOnSystem.Padding = new Padding(5, 0, 0, 0);
        this.chkCentreOnSystem.Size = new Size(159, 17);
        this.chkCentreOnSystem.TabIndex = 140;
        this.chkCentreOnSystem.Text = "Centre on Selected System";
        this.chkCentreOnSystem.TextAlign = ContentAlignment.MiddleRight;
        this.chkCentreOnSystem.UseVisualStyleBackColor = true;
        this.AutoScaleDimensions = new SizeF(6f, 13f);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.ClientSize = new Size(1424, 846);
        this.Controls.Add(this.flpTopLevel);
        this.Controls.Add(this.lstvMineralsWide);
        this.Controls.Add(this.cboSystems);
        this.Controls.Add(this.flowLayoutPanel7);
        this.Controls.Add(this.cboSpecies);
        this.Controls.Add(this.flowLayoutPanel3);
        this.Controls.Add(this.lstvMinerals);
        this.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.FormBorderStyle = FormBorderStyle.FixedSingle;
        this.KeyPreview = true;
        this.Name = "Minerals";
        this.Text = "Minerals";
        this.FormClosing += this.Minerals_FormClosing;
        this.Load += this.Minerals_Load;
        this.KeyDown += this.Minerals_KeyDown;
        this.flowLayoutPanel1.ResumeLayout(false);
        this.flowLayoutPanel1.PerformLayout();
        this.flowLayoutPanel2.ResumeLayout(false);
        this.flowLayoutPanel2.PerformLayout();
        this.flowLayoutPanel3.ResumeLayout(false);
        this.flowLayoutPanel3.PerformLayout();
        this.flowLayoutPanel4.ResumeLayout(false);
        this.flowLayoutPanel4.PerformLayout();
        this.flowLayoutPanel5.ResumeLayout(false);
        this.flowLayoutPanel5.PerformLayout();
        this.flpMineralSearch.ResumeLayout(false);
        this.flowLayoutPanel7.ResumeLayout(false);
        this.flowLayoutPanel7.PerformLayout();
        this.flpWideStats.ResumeLayout(false);
        this.flpWideStats.PerformLayout();
        this.flowLayoutPanel6.ResumeLayout(false);
        this.flowLayoutPanel6.PerformLayout();
        this.flpTopLevel.ResumeLayout(false);
        this.ResumeLayout(false);
    }
}