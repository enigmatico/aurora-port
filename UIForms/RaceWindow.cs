// Decompiled with JetBrains decompiler
// Type: RaceWindow
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
public class RaceWindow : Form
{
    public GClass0 gclass0_0;
    public GameRace gclass21_0;
    private bool bool_0;
    private IContainer icontainer_0;
    private PictureBox pbShipImage;
    private PictureBox pbFlagImage;
    private PictureBox pbRaceImage;
    private PictureBox pbStationImage;
    private FlowLayoutPanel flowLayoutPanel1;
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
    private Panel panel5;
    private Label label21;
    private Panel panel6;
    private TextBox txtTitle;
    private Label label22;
    private Panel panel15;
    private TextBox txtShortName;
    private Label label24;
    private FlowLayoutPanel flowLayoutPanel6;
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
    private Panel panel17;
    private TextBox txtDensity;
    private Label label1;
    private Panel panel26;
    private TextBox txtGrowth;
    private Label label10;
    private Panel panel27;
    private TextBox txtResearch;
    private Label label11;
    private Panel panel28;
    private TextBox txtProduction;
    private Label label12;
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
    private Panel panel4;
    private ComboBox cboRaces;
    private Label label20;
    private PictureBox pbSpecies;
    private Panel panel14;
    private Panel panel16;
    private TextBox txtSpeciesTotalPop;
    private Label label25;
    private Panel panel48;
    private TextBox txtPercentPop;
    private Label label32;
    private Button cmdSaveSpecies;
    private FlowLayoutPanel flowLayoutPanel3;
    private Panel panel49;
    private TextBox txtSpeciesName;
    private Label label48;
    private Button cmdStation;
    private Button cmdHull;
    private Button cmdRaceFlag;
    private Button cmdSpeciesImage;
    private ListView lstvPopSummary;
    private ColumnHeader columnHeader_0;
    private ColumnHeader columnHeader_1;
    private ListView lstvTechnology;
    private ColumnHeader columnHeader_2;
    private ListView lstvSupplies;
    private ColumnHeader columnHeader_3;
    private ColumnHeader columnHeader_4;
    private TabControl tabControl1;
    private TabPage tabPage1;
    private TabPage tabPage2;
    private FlowLayoutPanel flowLayoutPanel2;
    private FlowLayoutPanel flowLayoutPanel5;
    private FlowLayoutPanel flowLayoutPanel7;
    private Button cmdAddTheme;
    private Button cmdEditTheme;
    private Button cmdDeleteNameTheme;
    private Panel panel19;
    private TextBox txtChance;
    private Label label3;
    private Panel panel18;
    private ComboBox cboSelectNamingTheme;
    private Label label2;
    private TextBox txtPrimaryNameTheme;
    private ListView lstvNameThemes;
    private ColumnHeader columnHeader_5;
    private ColumnHeader columnHeader_6;
    private ColumnHeader columnHeader_7;
    private TabPage tabPage3;
    private ListView lstvAcademies;
    private ColumnHeader columnHeader_8;
    private ColumnHeader columnHeader_9;
    private Button cmdDeleteRace;
    private Label label4;
    private ComboBox cboTrainingLevel;
    private Button cmdTotalForceText;
    private Panel panel20;
    private TextBox txtGraduationAge;
    private Label label5;

    public RaceWindow(GClass0 gclass0_1)
    {
        this.InitializeComponent();
        this.DoubleBuffered = true;
        this.gclass0_0 = gclass0_1;
    }

    private void RaceWindow_FormClosing(object sender, FormClosingEventArgs e)
    {
        try
        {
            this.gclass0_0.method_512(this.Name, this.Left, this.Top);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2585);
        }
    }

    private void RaceWindow_Load(object sender, EventArgs e)
    {
        try
        {
            WindowPosition207 gclass207 = this.gclass0_0.method_513(this.Name);
            this.Left = gclass207.Left;
            this.Top = gclass207.Top;
            this.gclass0_0.bool_9 = true;
            this.bool_0 = true;
            this.gclass0_0.method_577(this.cboRaces);
            this.gclass0_0.method_553(this.cboSelectNamingTheme);
            this.gclass0_0.bool_9 = false;
            if (this.gclass0_0.bool_8)
                this.cmdSaveSpecies.Visible = true;
            else
                this.cmdSaveSpecies.Visible = false;
            this.gclass21_0 = (GameRace)this.cboRaces.SelectedValue;
            this.method_0();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2586);
        }
    }

    public void method_0()
    {
        try
        {
            Species gclass194 = this.gclass21_0.method_164();
            this.gclass21_0.method_298();
            try
            {
                this.pbRaceImage.Image = Image.FromFile($"{Application.StartupPath}\\Races\\{gclass194.RaceImageFileName}");
            }
            catch
            {
                int num = (int)MessageBox.Show("No Image found for Race");
            }

            this.pbFlagImage.Image = this.gclass21_0.FlagPicLoadedImg;
            this.pbShipImage.Image = this.gclass21_0.ShipIconLoadedImg;
            this.pbStationImage.Image = this.gclass21_0.SpaceStationPicLoadedImg;
            this.txtTitle.Text = this.gclass21_0.RaceTitle;
            this.txtShortName.Text = this.gclass21_0.RaceName;
            this.gclass0_0.bool_9 = true;
            this.gclass0_0.method_552(this.cboClassTheme);
            this.gclass0_0.method_552(this.cboSystemTheme);
            this.cboClassTheme.SelectedItem = this.gclass21_0.ClassTheme;
            this.cboSystemTheme.SelectedItem = this.gclass21_0.SystemTheme;
            this.gclass0_0.bool_9 = false;
            this.gclass21_0.method_260(this.cboSpecies);
            this.cboSpecies.SelectedItem = gclass194;
            this.gclass21_0.method_119(this.lstvNameThemes, this.txtPrimaryNameTheme);
            List<PopulationData> list = this.gclass0_0.Populations.Values
                .Where<PopulationData>(gclass146_0 => gclass146_0.Race == this.gclass21_0).ToList<PopulationData>();
            this.gclass21_0.method_121(this.lstvPopSummary, list);
            this.gclass21_0.method_123(this.lstvTechnology);
            this.gclass21_0.method_122(this.lstvSupplies, list);
            this.gclass21_0.method_120(this.lstvAcademies, list, this.cboTrainingLevel);
            if (!this.bool_0)
                this.gclass0_0.method_511(this.gclass21_0, this);
            this.bool_0 = false;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2587);
        }
    }

    public void method_1(GameRace gclass21_1)
    {
        try
        {
            this.bool_0 = true;
            this.cboRaces.SelectedItem = gclass21_1;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2588);
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
            this.method_0();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2589);
        }
    }

    private void cboSpecies_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            var capturedthis = this;
            if (this.gclass0_0.bool_9 || this.cboSpecies.SelectedValue == null)
                return;
            var capturedSboSpeciesSelectedValue = (Species)this.cboSpecies.SelectedValue;

            Decimal num1 = this.gclass0_0.Populations.Values
                .Where<PopulationData>(gclass146_0 => gclass146_0.Race == this.gclass21_0)
                .Sum<PopulationData>(gclass146_0 => gclass146_0.Population);
            Decimal num2 = this.gclass0_0.Populations.Values.Where<PopulationData>(v =>
                v.Race == capturedthis.gclass21_0 && v.Species == capturedSboSpeciesSelectedValue
            ).Sum<PopulationData>(gclass146_0 => gclass146_0.Population);
            Decimal num3 = num1 + this.gclass0_0.Ships.Values
                .Where<ShipData>(gclass40_0 => gclass40_0.gclass21_0 == this.gclass21_0)
                .SelectMany<ShipData, TransportedColonist>(gclass40_0 => gclass40_0.TransportedColonists)
                .Sum<TransportedColonist>(gclass181_0 => gclass181_0.Amount) / 1000000M;
            Decimal decimal_73 = num2 + this.gclass0_0.Ships.Values
                .Where<ShipData>(gclass40_0 => gclass40_0.gclass21_0 == this.gclass21_0)
                .SelectMany<ShipData, TransportedColonist>(gclass40_0 => gclass40_0.TransportedColonists)
                .Where<TransportedColonist>(v181 => v181.Species == capturedSboSpeciesSelectedValue)
                .Sum<TransportedColonist>(gclass181_0 => gclass181_0.Amount) / 1000000M;
            this.txtSpeciesTotalPop.Text = AuroraUtils.smethod_39(decimal_73);
            if (num3 > 0M)
                this.txtPercentPop.Text = AuroraUtils.FormatNumberToDigits(decimal_73 / num3 * 100M, 1) + "%";
            else
                this.txtPercentPop.Text = "N/A";
            this.pbSpecies.Image =
                Image.FromFile($"{Application.StartupPath}\\Races\\{capturedSboSpeciesSelectedValue.RaceImageFileName}");
            this.txtSpeciesName.Text = capturedSboSpeciesSelectedValue.SpeciesName;
            this.txtGravity.Text = AuroraUtils.smethod_46(capturedSboSpeciesSelectedValue.double_5, 2);
            this.txtGravityDev.Text = AuroraUtils.smethod_46(capturedSboSpeciesSelectedValue.double_6, 2);
            this.txtTemp.Text =
                AuroraUtils.smethod_46(capturedSboSpeciesSelectedValue.double_3 - AuroraUtils.int_17, 2);
            this.txtTempDev.Text = AuroraUtils.smethod_46(capturedSboSpeciesSelectedValue.double_4, 2);
            this.txtOxygen.Text = AuroraUtils.smethod_46(capturedSboSpeciesSelectedValue.double_0, 2);
            this.txtOxygenDev.Text = AuroraUtils.smethod_46(capturedSboSpeciesSelectedValue.double_1, 2);
            this.txtPressure.Text = AuroraUtils.smethod_46(capturedSboSpeciesSelectedValue.double_2, 2);
            this.txtDensity.Text = AuroraUtils.smethod_45(capturedSboSpeciesSelectedValue.decimal_0, 2);
            this.txtGrowth.Text = AuroraUtils.smethod_45(capturedSboSpeciesSelectedValue.decimal_1, 2);
            this.txtResearch.Text = AuroraUtils.smethod_45(capturedSboSpeciesSelectedValue.decimal_2, 2);
            this.txtProduction.Text = AuroraUtils.smethod_45(capturedSboSpeciesSelectedValue.decimal_3, 2);
            this.txtDet.Text = AuroraUtils.smethod_37(capturedSboSpeciesSelectedValue.int_7);
            this.txtDip.Text = AuroraUtils.smethod_37(capturedSboSpeciesSelectedValue.int_3);
            this.txtExp.Text = AuroraUtils.smethod_37(capturedSboSpeciesSelectedValue.int_6);
            this.txtMil.Text = AuroraUtils.smethod_37(capturedSboSpeciesSelectedValue.int_5);
            this.txtTrade.Text = AuroraUtils.smethod_37(capturedSboSpeciesSelectedValue.int_8);
            this.txtTrans.Text = AuroraUtils.smethod_37(capturedSboSpeciesSelectedValue.int_4);
            this.txtXen.Text = AuroraUtils.smethod_37(capturedSboSpeciesSelectedValue.int_2);
            this.txtGraduationAge.Text = AuroraUtils.smethod_37(capturedSboSpeciesSelectedValue.int_11);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2590);
        }
    }

    private void cmdSaveSpecies_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.cboSpecies.SelectedValue == null)
                return;
            Species selectedValue = (Species)this.cboSpecies.SelectedValue;
            selectedValue.SpeciesName = this.txtSpeciesName.Text;
            selectedValue.int_7 = Convert.ToInt32(this.txtDet.Text);
            selectedValue.int_3 = Convert.ToInt32(this.txtDip.Text);
            selectedValue.int_6 = Convert.ToInt32(this.txtExp.Text);
            selectedValue.int_5 = Convert.ToInt32(this.txtMil.Text);
            selectedValue.int_8 = Convert.ToInt32(this.txtTrade.Text);
            selectedValue.int_4 = Convert.ToInt32(this.txtTrans.Text);
            selectedValue.int_2 = Convert.ToInt32(this.txtXen.Text);
            selectedValue.int_11 = Convert.ToInt32(this.txtGraduationAge.Text);
            ParsedDecimal gclass208_1 = AuroraUtils.ParseDecimalString(this.txtDensity.Text);
            if (gclass208_1.Succeed)
                selectedValue.decimal_0 = gclass208_1.Value;
            ParsedDecimal gclass208_2 = AuroraUtils.ParseDecimalString(this.txtGrowth.Text);
            if (gclass208_2.Succeed)
                selectedValue.decimal_1 = gclass208_2.Value;
            ParsedDecimal gclass208_3 = AuroraUtils.ParseDecimalString(this.txtProduction.Text);
            if (gclass208_3.Succeed)
                selectedValue.decimal_3 = gclass208_3.Value;
            ParsedDecimal gclass208_4 = AuroraUtils.ParseDecimalString(this.txtResearch.Text);
            if (gclass208_4.Succeed)
                selectedValue.decimal_2 = gclass208_4.Value;
            selectedValue.double_5 = Convert.ToDouble(this.txtGravity.Text);
            selectedValue.double_6 = Convert.ToDouble(this.txtGravityDev.Text);
            selectedValue.double_3 = Convert.ToDouble(this.txtTemp.Text) + AuroraUtils.int_17;
            selectedValue.double_4 = Convert.ToDouble(this.txtTempDev.Text);
            selectedValue.double_0 = Convert.ToDouble(this.txtOxygen.Text);
            selectedValue.double_1 = Convert.ToDouble(this.txtOxygenDev.Text);
            selectedValue.double_2 = Convert.ToDouble(this.txtPressure.Text);
            selectedValue.double_7 = selectedValue.double_5 - selectedValue.double_6;
            selectedValue.double_8 = selectedValue.double_5 + selectedValue.double_6;
            selectedValue.double_9 = selectedValue.double_0 - selectedValue.double_1;
            selectedValue.double_10 = selectedValue.double_0 + selectedValue.double_1;
            selectedValue.double_12 = selectedValue.double_3 - selectedValue.double_4;
            selectedValue.double_11 = selectedValue.double_3 + selectedValue.double_4;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2591);
        }
    }

    private void cboSystemTheme_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass0_0.bool_9 || this.gclass21_0 == null)
                return;
            this.gclass21_0.SystemTheme = (NamingTheme)this.cboSystemTheme.SelectedValue;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2592);
        }
    }

    private void cboClassTheme_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass0_0.bool_9 || this.gclass21_0 == null)
                return;
            this.gclass21_0.ClassTheme = (NamingTheme)this.cboClassTheme.SelectedValue;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2593);
        }
    }

    private void txtTitle_TextChanged(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass0_0.bool_9 || this.gclass21_0 == null)
                return;
            this.gclass21_0.RaceTitle = this.txtTitle.Text;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2594);
        }
    }

    private void txtShortName_TextChanged(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass0_0.bool_9 || this.gclass21_0 == null)
                return;
            this.gclass21_0.RaceName = this.txtShortName.Text;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2595);
        }
    }

    private void cmdRaceFlag_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass21_0 == null)
                return;
            string str = AuroraUtils.smethod_18("Flags");
            if (str != "")
            {
                int num = str.LastIndexOf("\\");
                this.gclass21_0.FlagPic = str.Substring(num + 1);
            }

            this.gclass21_0.FlagPicLoadedImg =
                Image.FromFile($"{Application.StartupPath}\\Flags\\{this.gclass21_0.FlagPic}");
            this.pbFlagImage.Image = this.gclass21_0.FlagPicLoadedImg;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2596);
        }
    }

    private void cmdSpeciesImage_Click(object sender, EventArgs e)
    {
        try
        {
            Species selectedValue = (Species)this.cboSpecies.SelectedValue;
            if (selectedValue == null)
                return;
            string str = AuroraUtils.smethod_18("Races");
            if (str != "")
            {
                int num = str.LastIndexOf("\\");
                selectedValue.RaceImageFileName = str.Substring(num + 1);
            }

            this.pbRaceImage.Image = Image.FromFile($"{Application.StartupPath}\\Races\\{selectedValue.RaceImageFileName}");
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2597);
        }
    }

    private void cmdHull_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass21_0 == null)
                return;
            string str = AuroraUtils.smethod_18("ShipIcons");
            if (str != "")
            {
                int num = str.LastIndexOf("\\");
                this.gclass21_0.HullPic = str.Substring(num + 1);
            }

            this.gclass21_0.ShipIconLoadedImg =
                Image.FromFile($"{Application.StartupPath}\\ShipIcons\\{this.gclass21_0.HullPic}");
            this.pbShipImage.Image = this.gclass21_0.ShipIconLoadedImg;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2598);
        }
    }

    private void cmdStation_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass21_0 == null)
                return;
            string str = AuroraUtils.smethod_18("StationIcons");
            if (str != "")
            {
                int num = str.LastIndexOf("\\");
                this.gclass21_0.SpaceStationPic = str.Substring(num + 1);
            }

            this.gclass21_0.SpaceStationPicLoadedImg =
                Image.FromFile($"{Application.StartupPath}\\StationIcons\\{this.gclass21_0.SpaceStationPic}");
            this.pbStationImage.Image = this.gclass21_0.SpaceStationPicLoadedImg;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2599);
        }
    }

    private void cmdAddTheme_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass0_0.bool_9 || this.gclass21_0 == null)
                return;
            this.gclass21_0.method_111((CommanderNameThemeData)this.cboSelectNamingTheme.SelectedValue,
                Convert.ToInt32(this.txtChance.Text));
            this.gclass21_0.method_119(this.lstvNameThemes, this.txtPrimaryNameTheme);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2600);
        }
    }

    private void cmdDeleteNameTheme_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass0_0.bool_9 || this.gclass21_0 == null)
                return;
            if (this.lstvNameThemes.SelectedItems.Count == 0)
            {
                int num = (int)MessageBox.Show("Please select a name theme to delete");
            }
            else
            {
                this.gclass21_0.method_112((RaceNameTheme)this.lstvNameThemes.SelectedItems[0].Tag);
                this.gclass21_0.method_119(this.lstvNameThemes, this.txtPrimaryNameTheme);
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2601);
        }
    }

    private void cmdEditTheme_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass0_0.bool_9 || this.gclass21_0 == null)
                return;
            if (this.lstvNameThemes.SelectedItems.Count == 0)
            {
                int num1 = (int)MessageBox.Show("Please select a name theme to edit");
            }
            else
            {
                RaceNameTheme tag = (RaceNameTheme)this.lstvNameThemes.SelectedItems[0].Tag;
                this.gclass0_0.string_3 = "Enter Theme Weight";
                this.gclass0_0.string_4 = tag.Chance.ToString();
                int num2 = (int)new MessageEntry(this.gclass0_0).ShowDialog();
                if (this.gclass0_0.bool_21)
                    return;
                tag.Chance = Convert.ToInt32(this.gclass0_0.string_4);
                this.gclass21_0.method_119(this.lstvNameThemes, this.txtPrimaryNameTheme);
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2602);
        }
    }

    private void cmdDeleteRace_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass0_0.bool_9 || this.gclass21_0 == null ||
                MessageBox.Show(" Are you sure you want to delete this race?", "Confirmation Required",
                    MessageBoxButtons.YesNo) != DialogResult.Yes || MessageBox.Show(" Are you really sure?",
                    "Confirmation Required", MessageBoxButtons.YesNo) != DialogResult.Yes)
                return;
            this.gclass0_0.method_502(this.gclass21_0);
            this.Close();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2603);
        }
    }

    private void cboTrainingLevel_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass0_0.bool_9)
                return;
            this.gclass21_0 = (GameRace)this.cboRaces.SelectedValue;
            if (this.gclass21_0 == null)
                return;
            Decimal num = this.gclass21_0.AcademyCrewmen * this.gclass21_0.TrainingLevel;
            this.gclass21_0.TrainingLevel = Convert.ToInt32((string)this.cboTrainingLevel.SelectedItem);
            this.gclass21_0.AcademyCrewmen = num / this.gclass21_0.TrainingLevel;
            this.gclass21_0.method_120(this.lstvAcademies,
                this.gclass0_0.Populations.Values
                    .Where<PopulationData>(gclass146_0 => gclass146_0.Race == this.gclass21_0).ToList<PopulationData>(),
                null);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3199);
        }
    }

    private void cboSelectNamingTheme_SelectedIndexChanged(object sender, EventArgs e)
    {
    }

    private void RaceWindow_KeyDown(object sender, KeyEventArgs e)
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
            AuroraUtils.ShowExceptionPopup(ex, 3284);
        }
    }

    private void cmdTotalForceText_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass21_0 == null)
            {
                int num1 = (int)MessageBox.Show("Please select a race");
            }
            else
            {
                int num2 = (int)new PopulationText(this.gclass21_0, GEnum127.const_2, this.gclass0_0).ShowDialog();
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3362);
        }
    }

    private void txtXen_TextChanged(object sender, EventArgs e)
    {
    }

    protected override void Dispose(bool disposing)
    {
        if (disposing && this.icontainer_0 != null)
            this.icontainer_0.Dispose();
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        this.pbFlagImage = new PictureBox();
        this.pbShipImage = new PictureBox();
        this.pbRaceImage = new PictureBox();
        this.pbStationImage = new PictureBox();
        this.flowLayoutPanel1 = new FlowLayoutPanel();
        this.flowLayoutPanel2 = new FlowLayoutPanel();
        this.flowLayoutPanel5 = new FlowLayoutPanel();
        this.flowLayoutPanel4 = new FlowLayoutPanel();
        this.panel4 = new Panel();
        this.cboRaces = new ComboBox();
        this.label20 = new Label();
        this.panel6 = new Panel();
        this.txtTitle = new TextBox();
        this.label22 = new Label();
        this.panel15 = new Panel();
        this.txtShortName = new TextBox();
        this.label24 = new Label();
        this.panel1 = new Panel();
        this.cboSystemTheme = new ComboBox();
        this.label18 = new Label();
        this.panel3 = new Panel();
        this.cboClassTheme = new ComboBox();
        this.label19 = new Label();
        this.panel5 = new Panel();
        this.txtPrimaryNameTheme = new TextBox();
        this.label21 = new Label();
        this.panel2 = new Panel();
        this.cboSpecies = new ComboBox();
        this.label17 = new Label();
        this.flowLayoutPanel6 = new FlowLayoutPanel();
        this.panel14 = new Panel();
        this.pbSpecies = new PictureBox();
        this.panel49 = new Panel();
        this.txtSpeciesName = new TextBox();
        this.label48 = new Label();
        this.panel16 = new Panel();
        this.txtSpeciesTotalPop = new TextBox();
        this.label25 = new Label();
        this.panel48 = new Panel();
        this.txtPercentPop = new TextBox();
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
        this.cmdSaveSpecies = new Button();
        this.flowLayoutPanel3 = new FlowLayoutPanel();
        this.cmdTotalForceText = new Button();
        this.cmdSpeciesImage = new Button();
        this.cmdStation = new Button();
        this.cmdHull = new Button();
        this.cmdRaceFlag = new Button();
        this.cmdDeleteRace = new Button();
        this.lstvPopSummary = new ListView();
        this.columnHeader_0 = new ColumnHeader();
        this.columnHeader_1 = new ColumnHeader();
        this.lstvTechnology = new ListView();
        this.columnHeader_2 = new ColumnHeader();
        this.lstvSupplies = new ListView();
        this.columnHeader_3 = new ColumnHeader();
        this.columnHeader_4 = new ColumnHeader();
        this.tabControl1 = new TabControl();
        this.tabPage1 = new TabPage();
        this.tabPage2 = new TabPage();
        this.lstvNameThemes = new ListView();
        this.columnHeader_5 = new ColumnHeader();
        this.columnHeader_6 = new ColumnHeader();
        this.columnHeader_7 = new ColumnHeader();
        this.flowLayoutPanel7 = new FlowLayoutPanel();
        this.cmdAddTheme = new Button();
        this.cmdEditTheme = new Button();
        this.cmdDeleteNameTheme = new Button();
        this.panel19 = new Panel();
        this.txtChance = new TextBox();
        this.label3 = new Label();
        this.panel18 = new Panel();
        this.cboSelectNamingTheme = new ComboBox();
        this.label2 = new Label();
        this.tabPage3 = new TabPage();
        this.label4 = new Label();
        this.cboTrainingLevel = new ComboBox();
        this.lstvAcademies = new ListView();
        this.columnHeader_8 = new ColumnHeader();
        this.columnHeader_9 = new ColumnHeader();
        this.panel20 = new Panel();
        this.txtGraduationAge = new TextBox();
        this.label5 = new Label();
        ((ISupportInitialize)this.pbFlagImage).BeginInit();
        ((ISupportInitialize)this.pbShipImage).BeginInit();
        ((ISupportInitialize)this.pbRaceImage).BeginInit();
        ((ISupportInitialize)this.pbStationImage).BeginInit();
        this.flowLayoutPanel1.SuspendLayout();
        this.flowLayoutPanel2.SuspendLayout();
        this.flowLayoutPanel5.SuspendLayout();
        this.flowLayoutPanel4.SuspendLayout();
        this.panel4.SuspendLayout();
        this.panel6.SuspendLayout();
        this.panel15.SuspendLayout();
        this.panel1.SuspendLayout();
        this.panel3.SuspendLayout();
        this.panel5.SuspendLayout();
        this.panel2.SuspendLayout();
        this.flowLayoutPanel6.SuspendLayout();
        this.panel14.SuspendLayout();
        ((ISupportInitialize)this.pbSpecies).BeginInit();
        this.panel49.SuspendLayout();
        this.panel16.SuspendLayout();
        this.panel48.SuspendLayout();
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
        this.flowLayoutPanel3.SuspendLayout();
        this.tabControl1.SuspendLayout();
        this.tabPage1.SuspendLayout();
        this.tabPage2.SuspendLayout();
        this.flowLayoutPanel7.SuspendLayout();
        this.panel19.SuspendLayout();
        this.panel18.SuspendLayout();
        this.tabPage3.SuspendLayout();
        this.panel20.SuspendLayout();
        this.SuspendLayout();
        this.pbFlagImage.BackgroundImageLayout = ImageLayout.None;
        this.pbFlagImage.BorderStyle = BorderStyle.FixedSingle;
        this.pbFlagImage.Location = new Point(670, 0);
        this.pbFlagImage.Margin = new Padding(3, 0, 3, 3);
        this.pbFlagImage.Name = "pbFlagImage";
        this.pbFlagImage.Size = new Size(298, 175);
        this.pbFlagImage.SizeMode = PictureBoxSizeMode.StretchImage;
        this.pbFlagImage.TabIndex = 142;
        this.pbFlagImage.TabStop = false;
        this.pbShipImage.Location = new Point(0, 0);
        this.pbShipImage.Margin = new Padding(0, 0, 3, 3);
        this.pbShipImage.Name = "pbShipImage";
        this.pbShipImage.Size = new Size(216, 175);
        this.pbShipImage.SizeMode = PictureBoxSizeMode.Zoom;
        this.pbShipImage.TabIndex = 134;
        this.pbShipImage.TabStop = false;
        this.pbRaceImage.Anchor = AnchorStyles.None;
        this.pbRaceImage.BorderStyle = BorderStyle.FixedSingle;
        this.pbRaceImage.Location = new Point(3, 0);
        this.pbRaceImage.Margin = new Padding(3, 0, 3, 3);
        this.pbRaceImage.Name = "pbRaceImage";
        this.pbRaceImage.Size = new Size(215, 175);
        this.pbRaceImage.SizeMode = PictureBoxSizeMode.StretchImage;
        this.pbRaceImage.TabIndex = 143;
        this.pbRaceImage.TabStop = false;
        this.pbStationImage.Anchor = AnchorStyles.None;
        this.pbStationImage.Location = new Point(0, 0);
        this.pbStationImage.Margin = new Padding(0, 0, 3, 3);
        this.pbStationImage.Name = "pbStationImage";
        this.pbStationImage.Size = new Size(216, 175);
        this.pbStationImage.SizeMode = PictureBoxSizeMode.Zoom;
        this.pbStationImage.TabIndex = 144 /*0x90*/;
        this.pbStationImage.TabStop = false;
        this.flowLayoutPanel1.Controls.Add(this.pbRaceImage);
        this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel2);
        this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel5);
        this.flowLayoutPanel1.Controls.Add(this.pbFlagImage);
        this.flowLayoutPanel1.Location = new Point(336, 3);
        this.flowLayoutPanel1.Margin = new Padding(0);
        this.flowLayoutPanel1.Name = "flowLayoutPanel1";
        this.flowLayoutPanel1.Size = new Size(984, 175);
        this.flowLayoutPanel1.TabIndex = 145;
        this.flowLayoutPanel2.BorderStyle = BorderStyle.FixedSingle;
        this.flowLayoutPanel2.Controls.Add(this.pbShipImage);
        this.flowLayoutPanel2.Location = new Point(224 /*0xE0*/, 0);
        this.flowLayoutPanel2.Margin = new Padding(3, 0, 3, 0);
        this.flowLayoutPanel2.Name = "flowLayoutPanel2";
        this.flowLayoutPanel2.Size = new Size(217, 175);
        this.flowLayoutPanel2.TabIndex = 145;
        this.flowLayoutPanel5.BorderStyle = BorderStyle.FixedSingle;
        this.flowLayoutPanel5.Controls.Add(this.pbStationImage);
        this.flowLayoutPanel5.Location = new Point(447, 0);
        this.flowLayoutPanel5.Margin = new Padding(3, 0, 3, 0);
        this.flowLayoutPanel5.Name = "flowLayoutPanel5";
        this.flowLayoutPanel5.Size = new Size(217, 175);
        this.flowLayoutPanel5.TabIndex = 146;
        this.flowLayoutPanel4.BorderStyle = BorderStyle.FixedSingle;
        this.flowLayoutPanel4.Controls.Add(this.panel4);
        this.flowLayoutPanel4.Controls.Add(this.panel6);
        this.flowLayoutPanel4.Controls.Add(this.panel15);
        this.flowLayoutPanel4.Controls.Add(this.panel1);
        this.flowLayoutPanel4.Controls.Add(this.panel3);
        this.flowLayoutPanel4.Controls.Add(this.panel5);
        this.flowLayoutPanel4.FlowDirection = FlowDirection.TopDown;
        this.flowLayoutPanel4.Location = new Point(3, 3);
        this.flowLayoutPanel4.Name = "flowLayoutPanel4";
        this.flowLayoutPanel4.Size = new Size(330, 175);
        this.flowLayoutPanel4.TabIndex = 146;
        this.flowLayoutPanel4.WrapContents = false;
        this.panel4.Controls.Add(this.cboRaces);
        this.panel4.Controls.Add(this.label20);
        this.panel4.Location = new Point(3, 3);
        this.panel4.Name = "panel4";
        this.panel4.Size = new Size(320, 22);
        this.panel4.TabIndex = 119;
        this.cboRaces.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cboRaces.Dock = DockStyle.Right;
        this.cboRaces.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cboRaces.FormattingEnabled = true;
        this.cboRaces.Location = new Point(98, 0);
        this.cboRaces.Margin = new Padding(3, 3, 3, 0);
        this.cboRaces.Name = "cboRaces";
        this.cboRaces.Size = new Size(222, 21);
        this.cboRaces.TabIndex = 112 /*0x70*/;
        this.cboRaces.SelectedIndexChanged += this.cboRaces_SelectedIndexChanged;
        this.label20.AutoSize = true;
        this.label20.Location = new Point(0, 3);
        this.label20.Margin = new Padding(3);
        this.label20.Name = "label20";
        this.label20.Padding = new Padding(0, 3, 0, 0);
        this.label20.Size = new Size(33, 16 /*0x10*/);
        this.label20.TabIndex = 104;
        this.label20.Text = "Race";
        this.panel6.Controls.Add(this.txtTitle);
        this.panel6.Controls.Add(this.label22);
        this.panel6.Location = new Point(3, 31 /*0x1F*/);
        this.panel6.Name = "panel6";
        this.panel6.Padding = new Padding(0, 3, 0, 0);
        this.panel6.Size = new Size(320, 22);
        this.panel6.TabIndex = 119;
        this.txtTitle.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtTitle.BorderStyle = BorderStyle.None;
        this.txtTitle.Dock = DockStyle.Right;
        this.txtTitle.ForeColor = Color.FromArgb(128 /*0x80*/, 255, 128 /*0x80*/);
        this.txtTitle.Location = new Point(100, 3);
        this.txtTitle.Name = "txtTitle";
        this.txtTitle.Size = new Size(220, 13);
        this.txtTitle.TabIndex = 105;
        this.txtTitle.Text = "Text";
        this.txtTitle.TextAlign = HorizontalAlignment.Center;
        this.txtTitle.TextChanged += this.txtTitle_TextChanged;
        this.label22.AutoSize = true;
        this.label22.Dock = DockStyle.Left;
        this.label22.Location = new Point(0, 3);
        this.label22.Margin = new Padding(6, 3, 3, 3);
        this.label22.Name = "label22";
        this.label22.Size = new Size(56, 13);
        this.label22.TabIndex = 104;
        this.label22.Text = "Race Title";
        this.panel15.Controls.Add(this.txtShortName);
        this.panel15.Controls.Add(this.label24);
        this.panel15.Location = new Point(3, 59);
        this.panel15.Name = "panel15";
        this.panel15.Padding = new Padding(0, 3, 0, 0);
        this.panel15.Size = new Size(320, 22);
        this.panel15.TabIndex = 120;
        this.txtShortName.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtShortName.BorderStyle = BorderStyle.None;
        this.txtShortName.Dock = DockStyle.Right;
        this.txtShortName.ForeColor = Color.FromArgb(128 /*0x80*/, 255, 128 /*0x80*/);
        this.txtShortName.Location = new Point(100, 3);
        this.txtShortName.Name = "txtShortName";
        this.txtShortName.Size = new Size(220, 13);
        this.txtShortName.TabIndex = 105;
        this.txtShortName.Text = "Text";
        this.txtShortName.TextAlign = HorizontalAlignment.Center;
        this.txtShortName.TextChanged += this.txtShortName_TextChanged;
        this.label24.AutoSize = true;
        this.label24.Dock = DockStyle.Left;
        this.label24.Location = new Point(0, 3);
        this.label24.Margin = new Padding(3);
        this.label24.Name = "label24";
        this.label24.Size = new Size(92, 13);
        this.label24.TabIndex = 104;
        this.label24.Text = "Race Short Name";
        this.panel1.Controls.Add(this.cboSystemTheme);
        this.panel1.Controls.Add(this.label18);
        this.panel1.Location = new Point(3, 87);
        this.panel1.Name = "panel1";
        this.panel1.Size = new Size(320, 22);
        this.panel1.TabIndex = 115;
        this.cboSystemTheme.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cboSystemTheme.Dock = DockStyle.Right;
        this.cboSystemTheme.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cboSystemTheme.FormattingEnabled = true;
        this.cboSystemTheme.Location = new Point(98, 0);
        this.cboSystemTheme.Margin = new Padding(3, 3, 3, 0);
        this.cboSystemTheme.Name = "cboSystemTheme";
        this.cboSystemTheme.Size = new Size(222, 21);
        this.cboSystemTheme.TabIndex = 112 /*0x70*/;
        this.cboSystemTheme.SelectedIndexChanged += this.cboSystemTheme_SelectedIndexChanged;
        this.label18.AutoSize = true;
        this.label18.Location = new Point(0, 3);
        this.label18.Margin = new Padding(3);
        this.label18.Name = "label18";
        this.label18.Padding = new Padding(0, 3, 0, 0);
        this.label18.Size = new Size(77, 16 /*0x10*/);
        this.label18.TabIndex = 104;
        this.label18.Text = "System Theme";
        this.panel3.Controls.Add(this.cboClassTheme);
        this.panel3.Controls.Add(this.label19);
        this.panel3.Location = new Point(3, 115);
        this.panel3.Name = "panel3";
        this.panel3.Size = new Size(320, 22);
        this.panel3.TabIndex = 116;
        this.cboClassTheme.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cboClassTheme.Dock = DockStyle.Right;
        this.cboClassTheme.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cboClassTheme.FormattingEnabled = true;
        this.cboClassTheme.Location = new Point(98, 0);
        this.cboClassTheme.Margin = new Padding(3, 3, 3, 0);
        this.cboClassTheme.Name = "cboClassTheme";
        this.cboClassTheme.Size = new Size(222, 21);
        this.cboClassTheme.TabIndex = 112 /*0x70*/;
        this.cboClassTheme.SelectedIndexChanged += this.cboClassTheme_SelectedIndexChanged;
        this.label19.AutoSize = true;
        this.label19.Location = new Point(0, 3);
        this.label19.Margin = new Padding(3);
        this.label19.Name = "label19";
        this.label19.Padding = new Padding(0, 3, 0, 0);
        this.label19.Size = new Size(68, 16 /*0x10*/);
        this.label19.TabIndex = 104;
        this.label19.Text = "Class Theme";
        this.panel5.Controls.Add(this.txtPrimaryNameTheme);
        this.panel5.Controls.Add(this.label21);
        this.panel5.Location = new Point(3, 146);
        this.panel5.Margin = new Padding(3, 6, 3, 3);
        this.panel5.Name = "panel5";
        this.panel5.Padding = new Padding(0, 3, 0, 0);
        this.panel5.Size = new Size(320, 22);
        this.panel5.TabIndex = 118;
        this.txtPrimaryNameTheme.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtPrimaryNameTheme.BorderStyle = BorderStyle.None;
        this.txtPrimaryNameTheme.Dock = DockStyle.Right;
        this.txtPrimaryNameTheme.ForeColor = Color.FromArgb(128 /*0x80*/, 255, 128 /*0x80*/);
        this.txtPrimaryNameTheme.Location = new Point(100, 3);
        this.txtPrimaryNameTheme.Name = "txtPrimaryNameTheme";
        this.txtPrimaryNameTheme.Size = new Size(220, 13);
        this.txtPrimaryNameTheme.TabIndex = 106;
        this.txtPrimaryNameTheme.Text = "Text";
        this.txtPrimaryNameTheme.TextAlign = HorizontalAlignment.Center;
        this.label21.AutoSize = true;
        this.label21.Location = new Point(0, 3);
        this.label21.Margin = new Padding(3);
        this.label21.Name = "label21";
        this.label21.Size = new Size(71, 13);
        this.label21.TabIndex = 104;
        this.label21.Text = "Name Theme";
        this.panel2.Controls.Add(this.cboSpecies);
        this.panel2.Controls.Add(this.label17);
        this.panel2.Location = new Point(3, 3);
        this.panel2.Name = "panel2";
        this.panel2.Size = new Size(320, 22);
        this.panel2.TabIndex = 114;
        this.cboSpecies.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cboSpecies.Dock = DockStyle.Right;
        this.cboSpecies.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cboSpecies.FormattingEnabled = true;
        this.cboSpecies.Location = new Point(98, 0);
        this.cboSpecies.Margin = new Padding(3, 3, 3, 0);
        this.cboSpecies.Name = "cboSpecies";
        this.cboSpecies.Size = new Size(222, 21);
        this.cboSpecies.TabIndex = 112 /*0x70*/;
        this.cboSpecies.SelectedIndexChanged += this.cboSpecies_SelectedIndexChanged;
        this.label17.AutoSize = true;
        this.label17.Location = new Point(0, 3);
        this.label17.Margin = new Padding(3);
        this.label17.Name = "label17";
        this.label17.Padding = new Padding(0, 3, 0, 0);
        this.label17.Size = new Size(45, 16 /*0x10*/);
        this.label17.TabIndex = 104;
        this.label17.Text = "Species";
        this.flowLayoutPanel6.BorderStyle = BorderStyle.FixedSingle;
        this.flowLayoutPanel6.Controls.Add(this.panel2);
        this.flowLayoutPanel6.Controls.Add(this.panel14);
        this.flowLayoutPanel6.Controls.Add(this.panel49);
        this.flowLayoutPanel6.Controls.Add(this.panel16);
        this.flowLayoutPanel6.Controls.Add(this.panel48);
        this.flowLayoutPanel6.Controls.Add(this.panel7);
        this.flowLayoutPanel6.Controls.Add(this.panel8);
        this.flowLayoutPanel6.Controls.Add(this.panel9);
        this.flowLayoutPanel6.Controls.Add(this.panel10);
        this.flowLayoutPanel6.Controls.Add(this.panel11);
        this.flowLayoutPanel6.Controls.Add(this.panel12);
        this.flowLayoutPanel6.Controls.Add(this.panel13);
        this.flowLayoutPanel6.Controls.Add(this.panel17);
        this.flowLayoutPanel6.Controls.Add(this.panel26);
        this.flowLayoutPanel6.Controls.Add(this.panel27);
        this.flowLayoutPanel6.Controls.Add(this.panel28);
        this.flowLayoutPanel6.Controls.Add(this.panel36);
        this.flowLayoutPanel6.Controls.Add(this.panel37);
        this.flowLayoutPanel6.Controls.Add(this.panel38);
        this.flowLayoutPanel6.Controls.Add(this.panel39);
        this.flowLayoutPanel6.Controls.Add(this.panel40);
        this.flowLayoutPanel6.Controls.Add(this.panel41);
        this.flowLayoutPanel6.Controls.Add(this.panel42);
        this.flowLayoutPanel6.Controls.Add(this.panel20);
        this.flowLayoutPanel6.Location = new Point(0, 0);
        this.flowLayoutPanel6.Margin = new Padding(3, 3, 3, 2);
        this.flowLayoutPanel6.Name = "flowLayoutPanel6";
        this.flowLayoutPanel6.Size = new Size(330, 602);
        this.flowLayoutPanel6.TabIndex = 148;
        this.panel14.Controls.Add(this.pbSpecies);
        this.panel14.Location = new Point(3, 31 /*0x1F*/);
        this.panel14.Name = "panel14";
        this.panel14.Size = new Size(320, 124);
        this.panel14.TabIndex = 150;
        this.pbSpecies.BorderStyle = BorderStyle.FixedSingle;
        this.pbSpecies.Location = new Point(79, 0);
        this.pbSpecies.Margin = new Padding(0);
        this.pbSpecies.Name = "pbSpecies";
        this.pbSpecies.Size = new Size(147, 120);
        this.pbSpecies.SizeMode = PictureBoxSizeMode.StretchImage;
        this.pbSpecies.TabIndex = 144 /*0x90*/;
        this.pbSpecies.TabStop = false;
        this.panel49.Controls.Add(this.txtSpeciesName);
        this.panel49.Controls.Add(this.label48);
        this.panel49.Location = new Point(3, 161);
        this.panel49.Margin = new Padding(3, 3, 3, 2);
        this.panel49.Name = "panel49";
        this.panel49.Size = new Size(313, 15);
        this.panel49.TabIndex = 153;
        this.txtSpeciesName.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtSpeciesName.BorderStyle = BorderStyle.None;
        this.txtSpeciesName.Dock = DockStyle.Right;
        this.txtSpeciesName.ForeColor = Color.FromArgb(128 /*0x80*/, 255, 128 /*0x80*/);
        this.txtSpeciesName.Location = new Point(93, 0);
        this.txtSpeciesName.Name = "txtSpeciesName";
        this.txtSpeciesName.Size = new Size(220, 13);
        this.txtSpeciesName.TabIndex = 105;
        this.txtSpeciesName.Text = "Text";
        this.txtSpeciesName.TextAlign = HorizontalAlignment.Center;
        this.label48.AutoSize = true;
        this.label48.Dock = DockStyle.Left;
        this.label48.Location = new Point(0, 0);
        this.label48.Margin = new Padding(3);
        this.label48.Name = "label48";
        this.label48.Size = new Size(76, 13);
        this.label48.TabIndex = 104;
        this.label48.Text = "Species Name";
        this.panel16.Controls.Add(this.txtSpeciesTotalPop);
        this.panel16.Controls.Add(this.label25);
        this.panel16.Location = new Point(3, 181);
        this.panel16.Margin = new Padding(3, 3, 3, 2);
        this.panel16.Name = "panel16";
        this.panel16.Size = new Size(313, 15);
        this.panel16.TabIndex = 151;
        this.txtSpeciesTotalPop.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtSpeciesTotalPop.BorderStyle = BorderStyle.None;
        this.txtSpeciesTotalPop.Dock = DockStyle.Right;
        this.txtSpeciesTotalPop.ForeColor = Color.FromArgb(128 /*0x80*/, 255, 128 /*0x80*/);
        this.txtSpeciesTotalPop.Location = new Point(233, 0);
        this.txtSpeciesTotalPop.Name = "txtSpeciesTotalPop";
        this.txtSpeciesTotalPop.Size = new Size(80 /*0x50*/, 13);
        this.txtSpeciesTotalPop.TabIndex = 105;
        this.txtSpeciesTotalPop.Text = "0";
        this.txtSpeciesTotalPop.TextAlign = HorizontalAlignment.Center;
        this.label25.AutoSize = true;
        this.label25.Dock = DockStyle.Left;
        this.label25.Location = new Point(0, 0);
        this.label25.Margin = new Padding(3);
        this.label25.Name = "label25";
        this.label25.Size = new Size(84, 13);
        this.label25.TabIndex = 104;
        this.label25.Text = "Total Population";
        this.panel48.Controls.Add(this.txtPercentPop);
        this.panel48.Controls.Add(this.label32);
        this.panel48.Location = new Point(3, 201);
        this.panel48.Margin = new Padding(3, 3, 3, 2);
        this.panel48.Name = "panel48";
        this.panel48.Size = new Size(313, 15);
        this.panel48.TabIndex = 152;
        this.txtPercentPop.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtPercentPop.BorderStyle = BorderStyle.None;
        this.txtPercentPop.Dock = DockStyle.Right;
        this.txtPercentPop.ForeColor = Color.FromArgb(128 /*0x80*/, 255, 128 /*0x80*/);
        this.txtPercentPop.Location = new Point(233, 0);
        this.txtPercentPop.Name = "txtPercentPop";
        this.txtPercentPop.Size = new Size(80 /*0x50*/, 13);
        this.txtPercentPop.TabIndex = 105;
        this.txtPercentPop.Text = "0";
        this.txtPercentPop.TextAlign = HorizontalAlignment.Center;
        this.label32.AutoSize = true;
        this.label32.Dock = DockStyle.Left;
        this.label32.Location = new Point(0, 0);
        this.label32.Margin = new Padding(3);
        this.label32.Name = "label32";
        this.label32.Size = new Size(156, 13);
        this.label32.TabIndex = 104;
        this.label32.Text = "Percentage of Race Population";
        this.panel7.Controls.Add(this.txtGravity);
        this.panel7.Controls.Add(this.label23);
        this.panel7.Location = new Point(3, 221);
        this.panel7.Margin = new Padding(3, 3, 3, 2);
        this.panel7.Name = "panel7";
        this.panel7.Size = new Size(313, 15);
        this.panel7.TabIndex = 118;
        this.txtGravity.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtGravity.BorderStyle = BorderStyle.None;
        this.txtGravity.Dock = DockStyle.Right;
        this.txtGravity.ForeColor = Color.FromArgb(128 /*0x80*/, 255, 128 /*0x80*/);
        this.txtGravity.Location = new Point(233, 0);
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
        this.panel8.Controls.Add(this.txtTemp);
        this.panel8.Controls.Add(this.label26);
        this.panel8.Location = new Point(3, 241);
        this.panel8.Margin = new Padding(3, 3, 3, 2);
        this.panel8.Name = "panel8";
        this.panel8.Size = new Size(313, 15);
        this.panel8.TabIndex = 119;
        this.txtTemp.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtTemp.BorderStyle = BorderStyle.None;
        this.txtTemp.Dock = DockStyle.Right;
        this.txtTemp.ForeColor = Color.FromArgb(128 /*0x80*/, 255, 128 /*0x80*/);
        this.txtTemp.Location = new Point(233, 0);
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
        this.panel9.Controls.Add(this.txtOxygen);
        this.panel9.Controls.Add(this.label27);
        this.panel9.Location = new Point(3, 261);
        this.panel9.Margin = new Padding(3, 3, 3, 2);
        this.panel9.Name = "panel9";
        this.panel9.Size = new Size(313, 15);
        this.panel9.TabIndex = 120;
        this.txtOxygen.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtOxygen.BorderStyle = BorderStyle.None;
        this.txtOxygen.Dock = DockStyle.Right;
        this.txtOxygen.ForeColor = Color.FromArgb(128 /*0x80*/, 255, 128 /*0x80*/);
        this.txtOxygen.Location = new Point(233, 0);
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
        this.panel10.Controls.Add(this.txtPressure);
        this.panel10.Controls.Add(this.label28);
        this.panel10.Location = new Point(3, 281);
        this.panel10.Margin = new Padding(3, 3, 3, 2);
        this.panel10.Name = "panel10";
        this.panel10.Size = new Size(313, 15);
        this.panel10.TabIndex = 121;
        this.txtPressure.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtPressure.BorderStyle = BorderStyle.None;
        this.txtPressure.Dock = DockStyle.Right;
        this.txtPressure.ForeColor = Color.FromArgb(128 /*0x80*/, 255, 128 /*0x80*/);
        this.txtPressure.Location = new Point(233, 0);
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
        this.panel11.Controls.Add(this.txtGravityDev);
        this.panel11.Controls.Add(this.label29);
        this.panel11.Location = new Point(3, 301);
        this.panel11.Margin = new Padding(3, 3, 3, 2);
        this.panel11.Name = "panel11";
        this.panel11.Size = new Size(313, 15);
        this.panel11.TabIndex = 122;
        this.txtGravityDev.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtGravityDev.BorderStyle = BorderStyle.None;
        this.txtGravityDev.Dock = DockStyle.Right;
        this.txtGravityDev.ForeColor = Color.FromArgb(128 /*0x80*/, 255, 128 /*0x80*/);
        this.txtGravityDev.Location = new Point(233, 0);
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
        this.panel12.Controls.Add(this.txtTempDev);
        this.panel12.Controls.Add(this.label30);
        this.panel12.Location = new Point(3, 321);
        this.panel12.Margin = new Padding(3, 3, 3, 2);
        this.panel12.Name = "panel12";
        this.panel12.Size = new Size(313, 15);
        this.panel12.TabIndex = 123;
        this.txtTempDev.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtTempDev.BorderStyle = BorderStyle.None;
        this.txtTempDev.Dock = DockStyle.Right;
        this.txtTempDev.ForeColor = Color.FromArgb(128 /*0x80*/, 255, 128 /*0x80*/);
        this.txtTempDev.Location = new Point(233, 0);
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
        this.panel13.Controls.Add(this.txtOxygenDev);
        this.panel13.Controls.Add(this.label31);
        this.panel13.Location = new Point(3, 341);
        this.panel13.Margin = new Padding(3, 3, 3, 2);
        this.panel13.Name = "panel13";
        this.panel13.Size = new Size(313, 15);
        this.panel13.TabIndex = 124;
        this.txtOxygenDev.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtOxygenDev.BorderStyle = BorderStyle.None;
        this.txtOxygenDev.Dock = DockStyle.Right;
        this.txtOxygenDev.ForeColor = Color.FromArgb(128 /*0x80*/, 255, 128 /*0x80*/);
        this.txtOxygenDev.Location = new Point(233, 0);
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
        this.panel17.Controls.Add(this.txtDensity);
        this.panel17.Controls.Add(this.label1);
        this.panel17.Location = new Point(3, 361);
        this.panel17.Margin = new Padding(3, 3, 3, 2);
        this.panel17.Name = "panel17";
        this.panel17.Size = new Size(313, 15);
        this.panel17.TabIndex = 126;
        this.txtDensity.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtDensity.BorderStyle = BorderStyle.None;
        this.txtDensity.Dock = DockStyle.Right;
        this.txtDensity.ForeColor = Color.FromArgb(128 /*0x80*/, 255, 128 /*0x80*/);
        this.txtDensity.Location = new Point(233, 0);
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
        this.panel26.Controls.Add(this.txtGrowth);
        this.panel26.Controls.Add(this.label10);
        this.panel26.Location = new Point(3, 381);
        this.panel26.Margin = new Padding(3, 3, 3, 2);
        this.panel26.Name = "panel26";
        this.panel26.Size = new Size(313, 15);
        this.panel26.TabIndex = sbyte.MaxValue;
        this.txtGrowth.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtGrowth.BorderStyle = BorderStyle.None;
        this.txtGrowth.Dock = DockStyle.Right;
        this.txtGrowth.ForeColor = Color.FromArgb(128 /*0x80*/, 255, 128 /*0x80*/);
        this.txtGrowth.Location = new Point(233, 0);
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
        this.panel27.Controls.Add(this.txtResearch);
        this.panel27.Controls.Add(this.label11);
        this.panel27.Location = new Point(3, 401);
        this.panel27.Margin = new Padding(3, 3, 3, 2);
        this.panel27.Name = "panel27";
        this.panel27.Size = new Size(313, 15);
        this.panel27.TabIndex = 128 /*0x80*/;
        this.txtResearch.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtResearch.BorderStyle = BorderStyle.None;
        this.txtResearch.Dock = DockStyle.Right;
        this.txtResearch.ForeColor = Color.FromArgb(128 /*0x80*/, 255, 128 /*0x80*/);
        this.txtResearch.Location = new Point(233, 0);
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
        this.panel28.Controls.Add(this.txtProduction);
        this.panel28.Controls.Add(this.label12);
        this.panel28.Location = new Point(3, 421);
        this.panel28.Margin = new Padding(3, 3, 3, 2);
        this.panel28.Name = "panel28";
        this.panel28.Size = new Size(313, 15);
        this.panel28.TabIndex = 129;
        this.txtProduction.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtProduction.BorderStyle = BorderStyle.None;
        this.txtProduction.Dock = DockStyle.Right;
        this.txtProduction.ForeColor = Color.FromArgb(128 /*0x80*/, 255, 128 /*0x80*/);
        this.txtProduction.Location = new Point(233, 0);
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
        this.panel36.Controls.Add(this.txtDet);
        this.panel36.Controls.Add(this.label36);
        this.panel36.Location = new Point(3, 441);
        this.panel36.Margin = new Padding(3, 3, 3, 2);
        this.panel36.Name = "panel36";
        this.panel36.Size = new Size(313, 15);
        this.panel36.TabIndex = 130;
        this.txtDet.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtDet.BorderStyle = BorderStyle.None;
        this.txtDet.Dock = DockStyle.Right;
        this.txtDet.ForeColor = Color.FromArgb(128 /*0x80*/, 255, 128 /*0x80*/);
        this.txtDet.Location = new Point(233, 0);
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
        this.panel37.Controls.Add(this.txtDip);
        this.panel37.Controls.Add(this.label37);
        this.panel37.Location = new Point(3, 461);
        this.panel37.Margin = new Padding(3, 3, 3, 2);
        this.panel37.Name = "panel37";
        this.panel37.Size = new Size(313, 15);
        this.panel37.TabIndex = 131;
        this.txtDip.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtDip.BorderStyle = BorderStyle.None;
        this.txtDip.Dock = DockStyle.Right;
        this.txtDip.ForeColor = Color.FromArgb(128 /*0x80*/, 255, 128 /*0x80*/);
        this.txtDip.Location = new Point(233, 0);
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
        this.panel38.Controls.Add(this.txtExp);
        this.panel38.Controls.Add(this.label38);
        this.panel38.Location = new Point(3, 481);
        this.panel38.Margin = new Padding(3, 3, 3, 2);
        this.panel38.Name = "panel38";
        this.panel38.Size = new Size(313, 15);
        this.panel38.TabIndex = 132;
        this.txtExp.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtExp.BorderStyle = BorderStyle.None;
        this.txtExp.Dock = DockStyle.Right;
        this.txtExp.ForeColor = Color.FromArgb(128 /*0x80*/, 255, 128 /*0x80*/);
        this.txtExp.Location = new Point(233, 0);
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
        this.panel39.Controls.Add(this.txtMil);
        this.panel39.Controls.Add(this.label39);
        this.panel39.Location = new Point(3, 501);
        this.panel39.Margin = new Padding(3, 3, 3, 2);
        this.panel39.Name = "panel39";
        this.panel39.Size = new Size(313, 15);
        this.panel39.TabIndex = 133;
        this.txtMil.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtMil.BorderStyle = BorderStyle.None;
        this.txtMil.Dock = DockStyle.Right;
        this.txtMil.ForeColor = Color.FromArgb(128 /*0x80*/, 255, 128 /*0x80*/);
        this.txtMil.Location = new Point(233, 0);
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
        this.panel40.Controls.Add(this.txtTrade);
        this.panel40.Controls.Add(this.label40);
        this.panel40.Location = new Point(3, 521);
        this.panel40.Margin = new Padding(3, 3, 3, 2);
        this.panel40.Name = "panel40";
        this.panel40.Size = new Size(313, 15);
        this.panel40.TabIndex = 134;
        this.txtTrade.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtTrade.BorderStyle = BorderStyle.None;
        this.txtTrade.Dock = DockStyle.Right;
        this.txtTrade.ForeColor = Color.FromArgb(128 /*0x80*/, 255, 128 /*0x80*/);
        this.txtTrade.Location = new Point(233, 0);
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
        this.panel41.Controls.Add(this.txtTrans);
        this.panel41.Controls.Add(this.label41);
        this.panel41.Location = new Point(3, 541);
        this.panel41.Margin = new Padding(3, 3, 3, 2);
        this.panel41.Name = "panel41";
        this.panel41.Size = new Size(313, 15);
        this.panel41.TabIndex = 135;
        this.txtTrans.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtTrans.BorderStyle = BorderStyle.None;
        this.txtTrans.Dock = DockStyle.Right;
        this.txtTrans.ForeColor = Color.FromArgb(128 /*0x80*/, 255, 128 /*0x80*/);
        this.txtTrans.Location = new Point(233, 0);
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
        this.panel42.Controls.Add(this.txtXen);
        this.panel42.Controls.Add(this.label42);
        this.panel42.Location = new Point(3, 561);
        this.panel42.Margin = new Padding(3, 3, 3, 2);
        this.panel42.Name = "panel42";
        this.panel42.Size = new Size(313, 15);
        this.panel42.TabIndex = 136;
        this.txtXen.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtXen.BorderStyle = BorderStyle.None;
        this.txtXen.Dock = DockStyle.Right;
        this.txtXen.ForeColor = Color.FromArgb(128 /*0x80*/, 255, 128 /*0x80*/);
        this.txtXen.Location = new Point(233, 0);
        this.txtXen.Name = "txtXen";
        this.txtXen.Size = new Size(80 /*0x50*/, 13);
        this.txtXen.TabIndex = 105;
        this.txtXen.Text = "0";
        this.txtXen.TextAlign = HorizontalAlignment.Center;
        this.txtXen.TextChanged += this.txtXen_TextChanged;
        this.label42.AutoSize = true;
        this.label42.Dock = DockStyle.Left;
        this.label42.Location = new Point(0, 0);
        this.label42.Margin = new Padding(3);
        this.label42.Name = "label42";
        this.label42.Size = new Size(106, 13);
        this.label42.TabIndex = 104;
        this.label42.Text = "Xenophobia (1 - 100)";
        this.cmdSaveSpecies.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdSaveSpecies.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdSaveSpecies.Location = new Point(0, 0);
        this.cmdSaveSpecies.Margin = new Padding(0);
        this.cmdSaveSpecies.Name = "cmdSaveSpecies";
        this.cmdSaveSpecies.Size = new Size(96 /*0x60*/, 30);
        this.cmdSaveSpecies.TabIndex = 150;
        this.cmdSaveSpecies.Tag = "1200";
        this.cmdSaveSpecies.Text = "Save Species";
        this.cmdSaveSpecies.UseVisualStyleBackColor = false;
        this.cmdSaveSpecies.Click += this.cmdSaveSpecies_Click;
        this.flowLayoutPanel3.Controls.Add(this.cmdSaveSpecies);
        this.flowLayoutPanel3.Controls.Add(this.cmdTotalForceText);
        this.flowLayoutPanel3.Controls.Add(this.cmdSpeciesImage);
        this.flowLayoutPanel3.Controls.Add(this.cmdStation);
        this.flowLayoutPanel3.Controls.Add(this.cmdHull);
        this.flowLayoutPanel3.Controls.Add(this.cmdRaceFlag);
        this.flowLayoutPanel3.Controls.Add(this.cmdDeleteRace);
        this.flowLayoutPanel3.Location = new Point(3, 818);
        this.flowLayoutPanel3.Name = "flowLayoutPanel3";
        this.flowLayoutPanel3.Size = new Size(1356, 32 /*0x20*/);
        this.flowLayoutPanel3.TabIndex = 151;
        this.cmdTotalForceText.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdTotalForceText.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdTotalForceText.Location = new Point(96 /*0x60*/, 0);
        this.cmdTotalForceText.Margin = new Padding(0);
        this.cmdTotalForceText.Name = "cmdTotalForceText";
        this.cmdTotalForceText.Size = new Size(96 /*0x60*/, 30);
        this.cmdTotalForceText.TabIndex = 198;
        this.cmdTotalForceText.Tag = "1200";
        this.cmdTotalForceText.Text = "All Ships Text";
        this.cmdTotalForceText.UseVisualStyleBackColor = false;
        this.cmdTotalForceText.Click += this.cmdTotalForceText_Click;
        this.cmdSpeciesImage.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdSpeciesImage.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdSpeciesImage.Location = new Point(192 /*0xC0*/, 0);
        this.cmdSpeciesImage.Margin = new Padding(0);
        this.cmdSpeciesImage.Name = "cmdSpeciesImage";
        this.cmdSpeciesImage.Size = new Size(95, 30);
        this.cmdSpeciesImage.TabIndex = 151;
        this.cmdSpeciesImage.Tag = "1200";
        this.cmdSpeciesImage.Text = "Change Image";
        this.cmdSpeciesImage.UseVisualStyleBackColor = false;
        this.cmdSpeciesImage.Click += this.cmdSpeciesImage_Click;
        this.cmdStation.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdStation.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdStation.Location = new Point(287, 0);
        this.cmdStation.Margin = new Padding(0);
        this.cmdStation.Name = "cmdStation";
        this.cmdStation.Size = new Size(95, 30);
        this.cmdStation.TabIndex = 154;
        this.cmdStation.Tag = "1200";
        this.cmdStation.Text = "Change Station";
        this.cmdStation.UseVisualStyleBackColor = false;
        this.cmdStation.Click += this.cmdStation_Click;
        this.cmdHull.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdHull.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdHull.Location = new Point(382, 0);
        this.cmdHull.Margin = new Padding(0);
        this.cmdHull.Name = "cmdHull";
        this.cmdHull.Size = new Size(95, 30);
        this.cmdHull.TabIndex = 153;
        this.cmdHull.Tag = "1200";
        this.cmdHull.Text = "Change Hull";
        this.cmdHull.UseVisualStyleBackColor = false;
        this.cmdHull.Click += this.cmdHull_Click;
        this.cmdRaceFlag.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdRaceFlag.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdRaceFlag.Location = new Point(477, 0);
        this.cmdRaceFlag.Margin = new Padding(0);
        this.cmdRaceFlag.Name = "cmdRaceFlag";
        this.cmdRaceFlag.Size = new Size(95, 30);
        this.cmdRaceFlag.TabIndex = 152;
        this.cmdRaceFlag.Tag = "1200";
        this.cmdRaceFlag.Text = "Change Flag";
        this.cmdRaceFlag.UseVisualStyleBackColor = false;
        this.cmdRaceFlag.Click += this.cmdRaceFlag_Click;
        this.cmdDeleteRace.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdDeleteRace.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdDeleteRace.Location = new Point(572, 0);
        this.cmdDeleteRace.Margin = new Padding(0);
        this.cmdDeleteRace.Name = "cmdDeleteRace";
        this.cmdDeleteRace.Size = new Size(95, 30);
        this.cmdDeleteRace.TabIndex = 155;
        this.cmdDeleteRace.Text = "Delete Race";
        this.cmdDeleteRace.UseVisualStyleBackColor = false;
        this.cmdDeleteRace.Click += this.cmdDeleteRace_Click;
        this.lstvPopSummary.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.lstvPopSummary.BorderStyle = BorderStyle.FixedSingle;
        this.lstvPopSummary.Columns.AddRange(new ColumnHeader[2]
        {
            this.columnHeader_0,
            this.columnHeader_1
        });
        this.lstvPopSummary.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.lstvPopSummary.FullRowSelect = true;
        this.lstvPopSummary.HeaderStyle = ColumnHeaderStyle.None;
        this.lstvPopSummary.HideSelection = false;
        this.lstvPopSummary.Location = new Point(339, 184);
        this.lstvPopSummary.Margin = new Padding(4, 3, 3, 3);
        this.lstvPopSummary.Name = "lstvPopSummary";
        this.lstvPopSummary.Size = new Size(300, 630);
        this.lstvPopSummary.TabIndex = 152;
        this.lstvPopSummary.UseCompatibleStateImageBehavior = false;
        this.lstvPopSummary.View = View.Details;
        this.columnHeader_0.Width = 175;
        this.columnHeader_1.TextAlign = HorizontalAlignment.Right;
        this.columnHeader_1.Width = 105;
        this.lstvTechnology.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.lstvTechnology.BorderStyle = BorderStyle.FixedSingle;
        this.lstvTechnology.Columns.AddRange(new ColumnHeader[1]
        {
            this.columnHeader_2
        });
        this.lstvTechnology.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.lstvTechnology.FullRowSelect = true;
        this.lstvTechnology.HeaderStyle = ColumnHeaderStyle.None;
        this.lstvTechnology.HideSelection = false;
        this.lstvTechnology.Location = new Point(953, 184);
        this.lstvTechnology.Margin = new Padding(4, 3, 3, 3);
        this.lstvTechnology.Name = "lstvTechnology";
        this.lstvTechnology.Size = new Size(351, 630);
        this.lstvTechnology.TabIndex = 153;
        this.lstvTechnology.UseCompatibleStateImageBehavior = false;
        this.lstvTechnology.View = View.Details;
        this.columnHeader_2.Width = 330;
        this.lstvSupplies.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.lstvSupplies.BorderStyle = BorderStyle.FixedSingle;
        this.lstvSupplies.Columns.AddRange(new ColumnHeader[2]
        {
            this.columnHeader_3,
            this.columnHeader_4
        });
        this.lstvSupplies.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.lstvSupplies.FullRowSelect = true;
        this.lstvSupplies.HeaderStyle = ColumnHeaderStyle.None;
        this.lstvSupplies.HideSelection = false;
        this.lstvSupplies.Location = new Point(646, 184);
        this.lstvSupplies.Margin = new Padding(4, 3, 3, 3);
        this.lstvSupplies.Name = "lstvSupplies";
        this.lstvSupplies.Size = new Size(300, 630);
        this.lstvSupplies.TabIndex = 154;
        this.lstvSupplies.UseCompatibleStateImageBehavior = false;
        this.lstvSupplies.View = View.Details;
        this.columnHeader_3.Width = 175;
        this.columnHeader_4.TextAlign = HorizontalAlignment.Right;
        this.columnHeader_4.Width = 105;
        this.tabControl1.Controls.Add(this.tabPage1);
        this.tabControl1.Controls.Add(this.tabPage2);
        this.tabControl1.Controls.Add(this.tabPage3);
        this.tabControl1.Location = new Point(3, 185);
        this.tabControl1.Name = "tabControl1";
        this.tabControl1.SelectedIndex = 0;
        this.tabControl1.Size = new Size(330, 630);
        this.tabControl1.TabIndex = 155;
        this.tabPage1.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.tabPage1.Controls.Add(this.flowLayoutPanel6);
        this.tabPage1.Location = new Point(4, 22);
        this.tabPage1.Name = "tabPage1";
        this.tabPage1.Padding = new Padding(3);
        this.tabPage1.Size = new Size(322, 604);
        this.tabPage1.TabIndex = 0;
        this.tabPage1.Text = "Species";
        this.tabPage2.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.tabPage2.Controls.Add(this.lstvNameThemes);
        this.tabPage2.Controls.Add(this.flowLayoutPanel7);
        this.tabPage2.Controls.Add(this.panel19);
        this.tabPage2.Controls.Add(this.panel18);
        this.tabPage2.Location = new Point(4, 22);
        this.tabPage2.Name = "tabPage2";
        this.tabPage2.Padding = new Padding(3);
        this.tabPage2.Size = new Size(322, 604);
        this.tabPage2.TabIndex = 1;
        this.tabPage2.Text = "Race Name Themes";
        this.lstvNameThemes.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.lstvNameThemes.BorderStyle = BorderStyle.FixedSingle;
        this.lstvNameThemes.Columns.AddRange(new ColumnHeader[3]
        {
            this.columnHeader_5,
            this.columnHeader_6,
            this.columnHeader_7
        });
        this.lstvNameThemes.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.lstvNameThemes.FullRowSelect = true;
        this.lstvNameThemes.HeaderStyle = ColumnHeaderStyle.None;
        this.lstvNameThemes.HideSelection = false;
        this.lstvNameThemes.Location = new Point(3, 62);
        this.lstvNameThemes.Margin = new Padding(4, 3, 3, 3);
        this.lstvNameThemes.Name = "lstvNameThemes";
        this.lstvNameThemes.Size = new Size(316, 498);
        this.lstvNameThemes.TabIndex = 153;
        this.lstvNameThemes.UseCompatibleStateImageBehavior = false;
        this.lstvNameThemes.View = View.Details;
        this.columnHeader_5.Width = 140;
        this.columnHeader_6.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_6.Width = 80 /*0x50*/;
        this.columnHeader_7.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_7.Width = 80 /*0x50*/;
        this.flowLayoutPanel7.Controls.Add(this.cmdAddTheme);
        this.flowLayoutPanel7.Controls.Add(this.cmdEditTheme);
        this.flowLayoutPanel7.Controls.Add(this.cmdDeleteNameTheme);
        this.flowLayoutPanel7.Location = new Point(15, 566);
        this.flowLayoutPanel7.Name = "flowLayoutPanel7";
        this.flowLayoutPanel7.Size = new Size(290, 32 /*0x20*/);
        this.flowLayoutPanel7.TabIndex = 152;
        this.cmdAddTheme.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdAddTheme.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdAddTheme.Location = new Point(0, 0);
        this.cmdAddTheme.Margin = new Padding(0);
        this.cmdAddTheme.Name = "cmdAddTheme";
        this.cmdAddTheme.Size = new Size(96 /*0x60*/, 30);
        this.cmdAddTheme.TabIndex = 151;
        this.cmdAddTheme.Tag = "1200";
        this.cmdAddTheme.Text = "Add Theme";
        this.cmdAddTheme.UseVisualStyleBackColor = false;
        this.cmdAddTheme.Click += this.cmdAddTheme_Click;
        this.cmdEditTheme.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdEditTheme.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdEditTheme.Location = new Point(96 /*0x60*/, 0);
        this.cmdEditTheme.Margin = new Padding(0);
        this.cmdEditTheme.Name = "cmdEditTheme";
        this.cmdEditTheme.Size = new Size(96 /*0x60*/, 30);
        this.cmdEditTheme.TabIndex = 152;
        this.cmdEditTheme.Tag = "1200";
        this.cmdEditTheme.Text = "Edit Weight";
        this.cmdEditTheme.UseVisualStyleBackColor = false;
        this.cmdEditTheme.Click += this.cmdEditTheme_Click;
        this.cmdDeleteNameTheme.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdDeleteNameTheme.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdDeleteNameTheme.Location = new Point(192 /*0xC0*/, 0);
        this.cmdDeleteNameTheme.Margin = new Padding(0);
        this.cmdDeleteNameTheme.Name = "cmdDeleteNameTheme";
        this.cmdDeleteNameTheme.Size = new Size(96 /*0x60*/, 30);
        this.cmdDeleteNameTheme.TabIndex = 153;
        this.cmdDeleteNameTheme.Tag = "1200";
        this.cmdDeleteNameTheme.Text = "Delete Theme";
        this.cmdDeleteNameTheme.UseVisualStyleBackColor = false;
        this.cmdDeleteNameTheme.Click += this.cmdDeleteNameTheme_Click;
        this.panel19.Controls.Add(this.txtChance);
        this.panel19.Controls.Add(this.label3);
        this.panel19.Location = new Point(3, 34);
        this.panel19.Name = "panel19";
        this.panel19.Padding = new Padding(0, 3, 0, 0);
        this.panel19.Size = new Size(313, 22);
        this.panel19.TabIndex = 120;
        this.txtChance.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtChance.BorderStyle = BorderStyle.None;
        this.txtChance.Dock = DockStyle.Right;
        this.txtChance.ForeColor = Color.FromArgb(128 /*0x80*/, 255, 128 /*0x80*/);
        this.txtChance.Location = new Point(213, 3);
        this.txtChance.Name = "txtChance";
        this.txtChance.Size = new Size(100, 13);
        this.txtChance.TabIndex = 105;
        this.txtChance.Text = "100";
        this.txtChance.TextAlign = HorizontalAlignment.Center;
        this.label3.AutoSize = true;
        this.label3.Dock = DockStyle.Left;
        this.label3.Location = new Point(0, 3);
        this.label3.Margin = new Padding(6, 3, 3, 3);
        this.label3.Name = "label3";
        this.label3.Size = new Size(122, 13);
        this.label3.TabIndex = 104;
        this.label3.Text = "Select Weight of Theme";
        this.panel18.Controls.Add(this.cboSelectNamingTheme);
        this.panel18.Controls.Add(this.label2);
        this.panel18.Location = new Point(3, 6);
        this.panel18.Name = "panel18";
        this.panel18.Size = new Size(316, 22);
        this.panel18.TabIndex = 119;
        this.cboSelectNamingTheme.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cboSelectNamingTheme.Dock = DockStyle.Right;
        this.cboSelectNamingTheme.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cboSelectNamingTheme.FormattingEnabled = true;
        this.cboSelectNamingTheme.Location = new Point(94, 0);
        this.cboSelectNamingTheme.Margin = new Padding(3, 3, 3, 0);
        this.cboSelectNamingTheme.Name = "cboSelectNamingTheme";
        this.cboSelectNamingTheme.Size = new Size(222, 21);
        this.cboSelectNamingTheme.TabIndex = 112 /*0x70*/;
        this.cboSelectNamingTheme.SelectedIndexChanged += this.cboSelectNamingTheme_SelectedIndexChanged;
        this.label2.AutoSize = true;
        this.label2.Location = new Point(0, 3);
        this.label2.Margin = new Padding(3);
        this.label2.Name = "label2";
        this.label2.Padding = new Padding(0, 3, 0, 0);
        this.label2.Size = new Size(73, 16 /*0x10*/);
        this.label2.TabIndex = 104;
        this.label2.Text = "Select Theme";
        this.tabPage3.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.tabPage3.Controls.Add(this.label4);
        this.tabPage3.Controls.Add(this.cboTrainingLevel);
        this.tabPage3.Controls.Add(this.lstvAcademies);
        this.tabPage3.Location = new Point(4, 22);
        this.tabPage3.Name = "tabPage3";
        this.tabPage3.Padding = new Padding(3);
        this.tabPage3.Size = new Size(322, 604);
        this.tabPage3.TabIndex = 2;
        this.tabPage3.Text = "Academies";
        this.label4.AutoSize = true;
        this.label4.Location = new Point(97, 578);
        this.label4.Margin = new Padding(3);
        this.label4.Name = "label4";
        this.label4.Size = new Size(171, 13);
        this.label4.TabIndex = 156;
        this.label4.Text = "Training Level (Quality vs Quantity)";
        this.cboTrainingLevel.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cboTrainingLevel.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cboTrainingLevel.FormattingEnabled = true;
        this.cboTrainingLevel.Items.AddRange(new object[5]
        {
            "1",
            "2",
            "3",
            "4",
            "5"
        });
        this.cboTrainingLevel.Location = new Point(274, 575);
        this.cboTrainingLevel.Margin = new Padding(3, 3, 3, 0);
        this.cboTrainingLevel.Name = "cboTrainingLevel";
        this.cboTrainingLevel.Size = new Size(46, 21);
        this.cboTrainingLevel.TabIndex = 155;
        this.cboTrainingLevel.SelectedIndexChanged += this.cboTrainingLevel_SelectedIndexChanged;
        this.lstvAcademies.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.lstvAcademies.BorderStyle = BorderStyle.FixedSingle;
        this.lstvAcademies.Columns.AddRange(new ColumnHeader[2]
        {
            this.columnHeader_8,
            this.columnHeader_9
        });
        this.lstvAcademies.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.lstvAcademies.FullRowSelect = true;
        this.lstvAcademies.HeaderStyle = ColumnHeaderStyle.None;
        this.lstvAcademies.HideSelection = false;
        this.lstvAcademies.Location = new Point(3, 3);
        this.lstvAcademies.Margin = new Padding(4, 3, 3, 3);
        this.lstvAcademies.Name = "lstvAcademies";
        this.lstvAcademies.Size = new Size(317, 566);
        this.lstvAcademies.TabIndex = 153;
        this.lstvAcademies.UseCompatibleStateImageBehavior = false;
        this.lstvAcademies.View = View.Details;
        this.columnHeader_8.Width = 220;
        this.columnHeader_9.TextAlign = HorizontalAlignment.Right;
        this.columnHeader_9.Width = 80 /*0x50*/;
        this.panel20.Controls.Add(this.txtGraduationAge);
        this.panel20.Controls.Add(this.label5);
        this.panel20.Location = new Point(3, 581);
        this.panel20.Margin = new Padding(3, 3, 3, 2);
        this.panel20.Name = "panel20";
        this.panel20.Size = new Size(313, 15);
        this.panel20.TabIndex = 154;
        this.txtGraduationAge.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtGraduationAge.BorderStyle = BorderStyle.None;
        this.txtGraduationAge.Dock = DockStyle.Right;
        this.txtGraduationAge.ForeColor = Color.FromArgb(128 /*0x80*/, 255, 128 /*0x80*/);
        this.txtGraduationAge.Location = new Point(233, 0);
        this.txtGraduationAge.Name = "txtGraduationAge";
        this.txtGraduationAge.Size = new Size(80 /*0x50*/, 13);
        this.txtGraduationAge.TabIndex = 105;
        this.txtGraduationAge.Text = "0";
        this.txtGraduationAge.TextAlign = HorizontalAlignment.Center;
        this.label5.AutoSize = true;
        this.label5.Dock = DockStyle.Left;
        this.label5.Location = new Point(0, 0);
        this.label5.Margin = new Padding(3);
        this.label5.Name = "label5";
        this.label5.Size = new Size(81, 13);
        this.label5.TabIndex = 104;
        this.label5.Text = "Graduation Age";
        this.AutoScaleDimensions = new SizeF(6f, 13f);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.ClientSize = new Size(1307, 851);
        this.Controls.Add(this.tabControl1);
        this.Controls.Add(this.lstvSupplies);
        this.Controls.Add(this.lstvTechnology);
        this.Controls.Add(this.lstvPopSummary);
        this.Controls.Add(this.flowLayoutPanel4);
        this.Controls.Add(this.flowLayoutPanel1);
        this.Controls.Add(this.flowLayoutPanel3);
        this.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.FormBorderStyle = FormBorderStyle.FixedSingle;
        this.KeyPreview = true;
        this.Name = "RaceWindow";
        this.Text = "Race Information";
        this.FormClosing += this.RaceWindow_FormClosing;
        this.Load += this.RaceWindow_Load;
        this.KeyDown += this.RaceWindow_KeyDown;
        ((ISupportInitialize)this.pbFlagImage).EndInit();
        ((ISupportInitialize)this.pbShipImage).EndInit();
        ((ISupportInitialize)this.pbRaceImage).EndInit();
        ((ISupportInitialize)this.pbStationImage).EndInit();
        this.flowLayoutPanel1.ResumeLayout(false);
        this.flowLayoutPanel2.ResumeLayout(false);
        this.flowLayoutPanel5.ResumeLayout(false);
        this.flowLayoutPanel4.ResumeLayout(false);
        this.panel4.ResumeLayout(false);
        this.panel4.PerformLayout();
        this.panel6.ResumeLayout(false);
        this.panel6.PerformLayout();
        this.panel15.ResumeLayout(false);
        this.panel15.PerformLayout();
        this.panel1.ResumeLayout(false);
        this.panel1.PerformLayout();
        this.panel3.ResumeLayout(false);
        this.panel3.PerformLayout();
        this.panel5.ResumeLayout(false);
        this.panel5.PerformLayout();
        this.panel2.ResumeLayout(false);
        this.panel2.PerformLayout();
        this.flowLayoutPanel6.ResumeLayout(false);
        this.panel14.ResumeLayout(false);
        ((ISupportInitialize)this.pbSpecies).EndInit();
        this.panel49.ResumeLayout(false);
        this.panel49.PerformLayout();
        this.panel16.ResumeLayout(false);
        this.panel16.PerformLayout();
        this.panel48.ResumeLayout(false);
        this.panel48.PerformLayout();
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
        this.flowLayoutPanel3.ResumeLayout(false);
        this.tabControl1.ResumeLayout(false);
        this.tabPage1.ResumeLayout(false);
        this.tabPage2.ResumeLayout(false);
        this.flowLayoutPanel7.ResumeLayout(false);
        this.panel19.ResumeLayout(false);
        this.panel19.PerformLayout();
        this.panel18.ResumeLayout(false);
        this.panel18.PerformLayout();
        this.tabPage3.ResumeLayout(false);
        this.tabPage3.PerformLayout();
        this.panel20.ResumeLayout(false);
        this.panel20.PerformLayout();
        this.ResumeLayout(false);
    }
}