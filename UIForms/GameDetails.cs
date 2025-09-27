// Decompiled with JetBrains decompiler
// Type: GameDetails
// Assembly: Aurora, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAB8E3AD-3A24-426F-849E-98EC2E2DD9EB
// Assembly location: C:\Users\jinhoon.kim\Desktop\Aurora250Full\Dedot\aurora-deop.exe

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

#nullable disable
public class GameDetails : Form
{
    private List<GClass170> list_0 = new List<GClass170>();
    private TacticalMap tacticalMap_0;
    private bool bool_0;
    private IContainer icontainer_0;
    private FlowLayoutPanel flowLayoutPanel1;
    private CheckBox chkOrb;
    private CheckBox chkOrbAst;
    private CheckBox chkUseKnownStars;
    private CheckBox chkGenerateNPRs;
    private CheckBox chkGenerateNonTNOnly;
    private CheckBox chkPrecursors;
    private CheckBox chkInvaders;
    private CheckBox chkStarSwarm;
    private CheckBox chkNPRsGeneratePrecursors;
    private CheckBox chkRealisticPromotions;
    private CheckBox chkPoliticalAdmirals;
    private CheckBox chkInexpFleets;
    private CheckBox chkAutoJumpGates;
    private CheckBox chkNoOverhauls;
    private CheckBox chkCivilianShippingLinesActive;
    private FlowLayoutPanel flowLayoutPanel2;
    private Panel panel15;
    private TextBox txtYear;
    private Label label16;
    private Panel panel2;
    private TextBox txtNumSystems;
    private Label label3;
    private Panel panel3;
    private TextBox txtChance;
    private Label label5;
    private Panel panel4;
    private TextBox txtSpread;
    private Label label6;
    private Panel panel1;
    private TextBox txtDifficultyModifier;
    private Label label1;
    private Panel panel6;
    private TextBox txtProdTime;
    private Label label8;
    private Panel panel7;
    private TextBox txtRaceChance;
    private Label label9;
    private Panel panel8;
    private TextBox txtRaceChanceNPR;
    private Label label10;
    private Panel panel9;
    private TextBox txtNewRuinCreationChance;
    private Label label11;
    private Panel panel10;
    private TextBox txtMinComets;
    private Label label12;
    private Panel panel11;
    private TextBox txtTruceCountdown;
    private Label label13;
    private Panel panel13;
    private TextBox txtPassword;
    private Label label14;
    private Panel panel14;
    private TextBox txtConfirm;
    private Label label15;
    private Panel panel12;
    private ComboBox cboDetection;
    private Label label17;
    private Panel panel19;
    private ComboBox cboDisaster;
    private Label label18;
    private Label label7;
    private ComboBox cboGame;
    private Button cmdDelete;
    private Button cmdSave;
    private Button cmdNew;
    private Button cmdSelect;
    private TextBox txtOptionDescription;
    private FlowLayoutPanel flpNewGame;
    private Panel panel5;
    private TextBox txtPlayers;
    private Label label19;
    private Panel panel17;
    private TextBox txtNPRs;
    private Label label20;
    private Panel panel16;
    private TextBox txtJumpPoints;
    private Label label2;
    private TextBox textBox4;
    private TextBox txtStartOnly;
    private Button cmdCreate;
    private Button cmdCancel;
    private FlowLayoutPanel flowLayoutPanel4;
    private TextBox txtNewGameName;
    private Panel panel18;
    private TextBox txtEarthDeposits;
    private Label label4;
    private CheckBox chkConquerTech;
    private Panel panel20;
    private TextBox txtResearchSpeed;
    private Label label21;
    private Panel panel21;
    private TextBox txtTerraformingSpeed;
    private Label label22;
    private Panel panel22;
    private TextBox txtMaxNPRDistance;
    private Label lblMaxNPRDistance;
    private FlowLayoutPanel flowLayoutPanel3;
    private CheckBox chkPlanetX;
    private Panel panel23;
    private TextBox txtMinNPRDistance;
    private Label lblMinNPRDistance;
    private CheckBox chkAllowCivilianHarvesters;
    private CheckBox chkRakhas;
    private CheckBox chkHumanNPRs;
    private Panel panel24;
    private TextBox txtSurveySpeed;
    private Label label25;
    private Button cmdRename;
    private CheckBox chkConstellationNames;
    private CheckBox chkNPRsGenerateSwarm;
    private CheckBox chkNPRsGenerateRifts;
    private CheckBox chkEldar;
    private CheckBox chkNPRsEncounterRaiders;
    private Panel panel25;
    private TextBox txtSwarmSystems;
    private Label label26;
    private Panel panel26;
    private TextBox txtRaiderSystems;
    private Label label27;
    private Panel panel27;
    private TextBox txtInvaderSystems;
    private Label label28;
    private CheckBox chkStarEccentricity;
    private FlowLayoutPanel flowLayoutPanel5;
    private CheckBox chkGasGiantEffects;
    private CheckBox chkLimitedLabs;
    private CheckBox chkOneSecondSubPulse;
    private Panel panel28;
    private TextBox txtHostilityModifier;
    private Label lblHostilityModifier;
    private CheckBox chkNPRSetup;
    private Panel panel29;
    private TextBox txtMinorRaces;
    private Label label23;
    private CheckBox chkLimitPlanetaryDistance;
    private CheckBox chkParallelUniverse;
    private CheckBox chkUseThemeInKnownStars;
    private Panel panel30;
    private TextBox txtNPRBaseTransits;
    private Label label24;
    private Panel panel31;
    private TextBox txtNPRRandomTransits;
    private Label label29;
    private Panel panel32;
    private TextBox txtNPRMaxStartingSystems;
    private Label label30;
    private FlowLayoutPanel flowLayoutPanel6;
    private CheckBox chkEnhancedPrecursors;
    private CheckBox chkEnhancedInvaders;
    private CheckBox chkEnhancedSwarm;
    private Panel panel33;
    private TextBox txtPrecursorRP;
    private Label label31;
    private Panel panel34;
    private TextBox txtSwarmRP;
    private Label label32;
    private Panel panel35;
    private TextBox txtRaiderRP;
    private Label label33;
    private Panel panel36;
    private TextBox txtInvaderRP;
    private Label label34;
    private Panel panel37;
    private TextBox txtPreIndustrialRaces;
    private Label label35;
    private Panel panel38;
    private TextBox txtConventionalRaces;
    private Label label36;

    public GameDetails(TacticalMap tacticalMap_1)
    {
        this.tacticalMap_0 = tacticalMap_1;
        this.InitializeComponent();
    }

    private void cmdCreate_Click(object sender, EventArgs e)
    {
        try
        {
            this.ControlBox = true;
            this.method_6(true);
            int int32_1 = Convert.ToInt32(this.txtPlayers.Text);
            int int32_2 = Convert.ToInt32(this.txtNPRs.Text);
            double double_8 = Convert.ToDouble(this.txtMinNPRDistance.Text);
            double double_9 = Convert.ToDouble(this.txtMaxNPRDistance.Text);
            int int32_3 = Convert.ToInt32(this.txtJumpPoints.Text);
            Decimal decimal_13 = Convert.ToInt32(this.txtEarthDeposits.Text) / 100M;
            CheckState checkState = this.chkPlanetX.CheckState;
            int int32_4 = Convert.ToInt32(this.txtSwarmSystems.Text);
            int int32_5 = Convert.ToInt32(this.txtRaiderSystems.Text);
            int int32_6 = Convert.ToInt32(this.txtInvaderSystems.Text);
            int int32_7 = Convert.ToInt32(this.txtPrecursorRP.Text);
            int int32_8 = Convert.ToInt32(this.txtInvaderRP.Text);
            int int32_9 = Convert.ToInt32(this.txtRaiderRP.Text);
            int int32_10 = Convert.ToInt32(this.txtSwarmRP.Text);
            this.tacticalMap_0.gclass0_1.method_54(int32_1, int32_2, int32_3, decimal_13, double_8, double_9,
                checkState, int32_5, int32_4, int32_6, this.chkNPRSetup.CheckState, int32_7, int32_8, int32_9,
                int32_10);
            this.tacticalMap_0.gclass0_1.method_526(GEnum38.const_0);
            this.tacticalMap_0.gclass0_1.method_526(GEnum38.const_1);
            this.Close();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1697);
        }
    }

    private void cmdSelect_Click(object sender, EventArgs e)
    {
        try
        {
            this.Close();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1698);
        }
    }

    private void method_0()
    {
        try
        {
            DataTable dataTable =
                new SQLiteDatabaseC1181().ExecuteQuery("select * from FCT_Game order by LastViewed desc");
            this.list_0.Clear();
            foreach (DataRow row in (InternalDataCollectionBase)dataTable.Rows)
            {
                int int32 = Convert.ToInt32(row["GameID"]);
                string string_1 = row["GameName"].ToString();
                double double_1 = Convert.ToDouble(row["LastViewed"]);
                this.list_0.Add(new GClass170(string_1, int32, double_1));
            }

            if (this.list_0.Count == 0)
            {
                this.bool_0 = false;
                this.method_3();
            }
            else
            {
                if (this.list_0.Count == 1)
                    this.cmdDelete.Enabled = false;
                else
                    this.cmdDelete.Enabled = true;
                GClass170 gclass170_1 = null;
                if (this.tacticalMap_0.gclass0_1 != null)
                {
                    foreach (GClass170 gclass170_2 in this.list_0)
                    {
                        if (gclass170_2.decimal_0 == this.tacticalMap_0.gclass0_1.GameID)
                        {
                            gclass170_1 = gclass170_2;
                            break;
                        }
                    }
                }
                else
                    this.list_0 = this.list_0.OrderByDescending<GClass170, double>(gclass170_0 => gclass170_0.double_0)
                        .ToList<GClass170>();

                this.cboGame.DataSource = null;
                this.cboGame.DisplayMember = "DisplayText";
                this.cboGame.DataSource = this.list_0;
                if (gclass170_1 != null)
                    this.cboGame.SelectedItem = gclass170_1;
                else
                    this.cboGame.SelectedItem = this.list_0[0];
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1699);
        }
    }

    private void cboGame_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            if (this.bool_0)
                return;
            this.method_1();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1700);
        }
    }

    private void GameDetails_Load(object sender, EventArgs e)
    {
        try
        {
            this.bool_0 = true;
            this.method_0();
            this.bool_0 = false;
            this.method_1();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1701);
        }
    }

    private void method_1()
    {
        try
        {
            if (this.cboGame.SelectedIndex <= -1)
                return;
            this.tacticalMap_0.gclass0_1 =
                this.tacticalMap_0.method_3((int)((GClass170)this.cboGame.SelectedValue).decimal_0);
            this.method_2();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1702);
        }
    }

    private void method_2()
    {
        try
        {
            this.txtNumSystems.Text = this.tacticalMap_0.gclass0_1.NumberOfSystems.ToString();
            this.txtChance.Text = this.tacticalMap_0.gclass0_1.LocalSystemChance.ToString();
            this.txtSpread.Text = this.tacticalMap_0.gclass0_1.LocalSystemSpread.ToString();
            this.txtProdTime.Text = this.tacticalMap_0.gclass0_1.MinConstructionPeriod.ToString();
            this.txtRaceChance.Text = this.tacticalMap_0.gclass0_1.RaceChance.ToString();
            this.txtNewRuinCreationChance.Text = this.tacticalMap_0.gclass0_1.NewRuinCreationChance.ToString();
            this.txtRaceChanceNPR.Text = this.tacticalMap_0.gclass0_1.RaceChanceNPR.ToString();
            this.txtMinorRaces.Text = this.tacticalMap_0.gclass0_1.MinorRaceChance.ToString();
            this.txtPreIndustrialRaces.Text = this.tacticalMap_0.gclass0_1.PreIndustrialChance.ToString();
            this.txtConventionalRaces.Text = this.tacticalMap_0.gclass0_1.ConventionalChance.ToString();
            this.txtDifficultyModifier.Text = this.tacticalMap_0.gclass0_1.DifficultyModifier.ToString();
            this.txtResearchSpeed.Text = this.tacticalMap_0.gclass0_1.ResearchSpeed.ToString();
            this.txtHostilityModifier.Text = this.tacticalMap_0.gclass0_1.HostilityModifier.ToString();
            this.txtTerraformingSpeed.Text = this.tacticalMap_0.gclass0_1.TerraformingSpeed.ToString();
            this.txtSurveySpeed.Text = this.tacticalMap_0.gclass0_1.SurveySpeed.ToString();
            this.txtMinComets.Text = this.tacticalMap_0.gclass0_1.MinComets.ToString();
            this.txtPassword.Text = this.tacticalMap_0.gclass0_1.SMPassword;
            this.txtConfirm.Text = this.tacticalMap_0.gclass0_1.SMPassword;
            this.txtYear.Text = this.tacticalMap_0.gclass0_1.StartYear.ToString();
            this.txtTruceCountdown.Text =
                AuroraUtils.FormatNumberToDigits(this.tacticalMap_0.gclass0_1.TruceCountdown / AuroraUtils.decimal_29, 2);
            this.txtNPRBaseTransits.Text = this.tacticalMap_0.gclass0_1.NPRBaseTransits.ToString();
            this.txtNPRRandomTransits.Text = this.tacticalMap_0.gclass0_1.NPRRandomTransits.ToString();
            this.txtNPRMaxStartingSystems.Text = this.tacticalMap_0.gclass0_1.NPRMaxSystems.ToString();
            this.chkConquerTech.Checked = AuroraUtils.smethod_68(this.tacticalMap_0.gclass0_1.TechFromConquest);
            this.chkCivilianShippingLinesActive.Checked = AuroraUtils.smethod_68(this.tacticalMap_0.gclass0_1.CivilianShippingLinesActive);
            this.chkAllowCivilianHarvesters.Checked = AuroraUtils.smethod_68(this.tacticalMap_0.gclass0_1.AllowCivilianHarvesters);
            this.chkOrb.Checked = AuroraUtils.smethod_68(this.tacticalMap_0.gclass0_1.OrbitalMotion);
            this.chkOrbAst.Checked = AuroraUtils.smethod_68(this.tacticalMap_0.gclass0_1.OrbitalMotionAst);
            this.chkPoliticalAdmirals.Checked = AuroraUtils.smethod_68(this.tacticalMap_0.gclass0_1.PoliticalAdmirals);
            this.chkInexpFleets.Checked = AuroraUtils.smethod_68(this.tacticalMap_0.gclass0_1.InexpFleets);
            this.chkAutoJumpGates.Checked = AuroraUtils.smethod_68(this.tacticalMap_0.gclass0_1.AutoJumpGates);
            this.chkPrecursors.Checked = AuroraUtils.smethod_68(this.tacticalMap_0.gclass0_1.Precursors);
            this.chkRakhas.Checked = AuroraUtils.smethod_68(this.tacticalMap_0.gclass0_1.Rakhas);
            this.chkStarSwarm.Checked = AuroraUtils.smethod_68(this.tacticalMap_0.gclass0_1.StarSwarm);
            this.chkInvaders.Checked = AuroraUtils.smethod_68(this.tacticalMap_0.gclass0_1.Invaders);
            this.chkEldar.Checked = AuroraUtils.smethod_68(this.tacticalMap_0.gclass0_1.Eldar);
            this.chkUseKnownStars.Checked = AuroraUtils.smethod_68(this.tacticalMap_0.gclass0_1.UseKnownStars);
            this.chkConstellationNames.Checked = AuroraUtils.smethod_68(this.tacticalMap_0.gclass0_1.ConstellationNames);
            this.chkGenerateNPRs.Checked = AuroraUtils.smethod_68(this.tacticalMap_0.gclass0_1.GenerateNPRs);
            this.chkHumanNPRs.Checked = AuroraUtils.smethod_68(this.tacticalMap_0.gclass0_1.HumanNPRs);
            this.chkGenerateNonTNOnly.Checked = AuroraUtils.smethod_68(this.tacticalMap_0.gclass0_1.GenerateNonTNOnly);
            this.chkNoOverhauls.Checked = AuroraUtils.smethod_68(this.tacticalMap_0.gclass0_1.NoOverhauls);
            this.chkRealisticPromotions.Checked = AuroraUtils.smethod_68(this.tacticalMap_0.gclass0_1.RealisticPromotions);
            this.chkNPRsGeneratePrecursors.Checked = AuroraUtils.smethod_68(this.tacticalMap_0.gclass0_1.NPRsGeneratePrecursors);
            this.chkNPRsGenerateSwarm.Checked = AuroraUtils.smethod_68(this.tacticalMap_0.gclass0_1.NPRsGenerateSwarm);
            this.chkNPRsGenerateRifts.Checked = AuroraUtils.smethod_68(this.tacticalMap_0.gclass0_1.NPRsGenerateRifts);
            this.chkNPRsEncounterRaiders.Checked = AuroraUtils.smethod_68(this.tacticalMap_0.gclass0_1.NPRsEncounterRaiders);
            this.chkStarEccentricity.Checked = AuroraUtils.smethod_68(this.tacticalMap_0.gclass0_1.StarEccentricity);
            this.chkGasGiantEffects.Checked = AuroraUtils.smethod_68(this.tacticalMap_0.gclass0_1.GasGiantEffects);
            this.chkLimitedLabs.Checked = AuroraUtils.smethod_68(this.tacticalMap_0.gclass0_1.LimitedLabs);
            this.chkOneSecondSubPulse.Checked = AuroraUtils.smethod_68(this.tacticalMap_0.gclass0_1.OneSecondSubPulse);
            this.chkLimitPlanetaryDistance.Checked = AuroraUtils.smethod_68(this.tacticalMap_0.gclass0_1.LimitPlanetaryDistance);
            this.chkParallelUniverse.Checked = AuroraUtils.smethod_68(this.tacticalMap_0.gclass0_1.ParallelUniverse);
            this.chkUseThemeInKnownStars.Checked = AuroraUtils.smethod_68(this.tacticalMap_0.gclass0_1.UseThemeInKnownStars);
            this.chkEnhancedInvaders.Checked = AuroraUtils.smethod_68(this.tacticalMap_0.gclass0_1.EnhancedInvaders);
            this.chkEnhancedPrecursors.Checked = AuroraUtils.smethod_68(this.tacticalMap_0.gclass0_1.EnhancedPrecursors);
            this.chkEnhancedSwarm.Checked = AuroraUtils.smethod_68(this.tacticalMap_0.gclass0_1.EnhancedSwarm);
            this.cboDetection.SelectedIndex = this.tacticalMap_0.gclass0_1.NonPlayerSystemDetection;
            this.cboDisaster.SelectedIndex = (int)this.tacticalMap_0.gclass0_1.SolDisaster;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1703);
        }
    }

    private void cmdNew_Click(object sender, EventArgs e)
    {
        try
        {
            this.method_3();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1704);
        }
    }

    public void method_3()
    {
        try
        {
            this.ControlBox = false;
            this.cmdSelect.Visible = false;
            this.cmdSave.Visible = false;
            this.cmdDelete.Visible = false;
            this.cmdNew.Visible = false;
            this.cmdRename.Visible = false;
            this.cmdCreate.Visible = true;
            this.cmdCancel.Visible = true;
            this.cboGame.Visible = false;
            this.txtNewGameName.Visible = true;
            this.txtYear.ReadOnly = false;
            this.txtJumpPoints.ReadOnly = false;
            this.txtPlayers.ReadOnly = false;
            this.txtNPRs.ReadOnly = false;
            this.flpNewGame.Visible = true;
            this.txtStartOnly.Visible = true;
            this.Width = 1324;
            this.tacticalMap_0.gclass0_1 = this.method_4();
            this.method_2();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1705);
        }
    }

    private GClass0 method_4()
    {
        try
        {
            return new GClass0(this.tacticalMap_0)
            {
                GameID = this.tacticalMap_0.gclass0_0.method_26(GEnum0.const_0),
                bool_2 = true,
                NumberOfSystems = 1000,
                LocalSystemChance = 50,
                LocalSystemSpread = 15,
                MinConstructionPeriod = 430000,
                RaceChance = 30,
                NewRuinCreationChance = 20,
                RaceChanceNPR = 10,
                DifficultyModifier = 100,
                ResearchSpeed = 100,
                TerraformingSpeed = 100,
                SurveySpeed = 100,
                MinComets = 0,
                SMPassword = "",
                StartYear = 2050,
                TruceCountdown = 10M,
                HostilityModifier = 0,
                NPRBaseTransits = 0,
                NPRRandomTransits = 0,
                NPRMaxSystems = 0,
                TechFromConquest = 1,
                CivilianShippingLinesActive = 1,
                AllowCivilianHarvesters = 1,
                OrbitalMotion = 1,
                OrbitalMotionAst = 1,
                PoliticalAdmirals = 0,
                InexpFleets = 1,
                AutoJumpGates = 0,
                Precursors = 1,
                Eldar = 1,
                Rakhas = 1,
                StarSwarm = 1,
                Invaders = 0,
                UseKnownStars = 1,
                GenerateNPRs = 1,
                HumanNPRs = 0,
                GenerateNonTNOnly = 0,
                NoOverhauls = 0,
                RealisticPromotions = 1,
                NPRsGeneratePrecursors = 0,
                NPRsGenerateSwarm = 0,
                NPRsGenerateRifts = 0,
                NPRsEncounterRaiders = 0,
                LimitedLabs = 0,
                OneSecondSubPulse = 1,
                EnhancedSwarm = 0,
                EnhancedPrecursors = 0,
                EnhancedInvaders = 0
            };
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1706);
            return null;
        }
    }

    private void cmdCancel_Click(object sender, EventArgs e)
    {
        try
        {
            this.method_5();
            this.method_1();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1707);
        }
    }

    private void method_5()
    {
        try
        {
            this.ControlBox = true;
            this.cmdSelect.Visible = true;
            this.cmdSave.Visible = true;
            this.cmdDelete.Visible = true;
            this.cmdNew.Visible = true;
            this.cmdRename.Visible = true;
            this.cmdCreate.Visible = false;
            this.cmdCancel.Visible = false;
            this.cboGame.Visible = true;
            this.txtNewGameName.Visible = false;
            this.txtYear.ReadOnly = true;
            this.txtJumpPoints.ReadOnly = true;
            this.txtPlayers.ReadOnly = true;
            this.txtNPRs.ReadOnly = true;
            this.flpNewGame.Visible = false;
            this.txtStartOnly.Visible = false;
            this.Width = 1024 /*0x0400*/;
            this.bool_0 = true;
            this.method_0();
            this.bool_0 = false;
            this.method_1();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1708);
        }
    }

    private void method_6(bool bool_1)
    {
        try
        {
            if (this.txtPassword.Text != this.txtConfirm.Text)
            {
                int num = (int)MessageBox.Show("Password and Confirm do not match. Please correct and re-save");
            }
            else
            {
                if (bool_1)
                    this.tacticalMap_0.gclass0_1.GameName = this.txtNewGameName.Text;
                this.method_7(this.tacticalMap_0.gclass0_1);
                if (this.tacticalMap_0.gclass0_0.GameID == this.tacticalMap_0.gclass0_1.GameID)
                    this.method_7(this.tacticalMap_0.gclass0_0);
                using (SQLiteConnection sqliteConnection_0 = new SQLiteConnection(AuroraUtils.string_1))
                {
                    sqliteConnection_0.Open();
                    using (SQLiteTransaction sqLiteTransaction = sqliteConnection_0.BeginTransaction())
                    {
                        this.tacticalMap_0.gclass0_1.UpsertGClass0(sqliteConnection_0);
                        sqLiteTransaction.Commit();
                    }

                    sqliteConnection_0.Close();
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1709);
        }
    }

    private void method_7(GClass0 gclass0_0)
    {
        try
        {
            gclass0_0.NumberOfSystems = Convert.ToInt32(this.txtNumSystems.Text);
            gclass0_0.LocalSystemChance = Convert.ToInt32(this.txtChance.Text);
            gclass0_0.LocalSystemSpread = Convert.ToInt32(this.txtSpread.Text);
            gclass0_0.MinConstructionPeriod = Convert.ToInt32(this.txtProdTime.Text);
            gclass0_0.RaceChance = Convert.ToInt32(this.txtRaceChance.Text);
            gclass0_0.NewRuinCreationChance = Convert.ToInt32(this.txtNewRuinCreationChance.Text);
            gclass0_0.RaceChanceNPR = Convert.ToInt32(this.txtRaceChanceNPR.Text);
            gclass0_0.MinorRaceChance = Convert.ToInt32(this.txtMinorRaces.Text);
            gclass0_0.PreIndustrialChance = Convert.ToInt32(this.txtPreIndustrialRaces.Text);
            gclass0_0.ConventionalChance = Convert.ToInt32(this.txtConventionalRaces.Text);
            gclass0_0.DifficultyModifier = Convert.ToInt32(this.txtDifficultyModifier.Text);
            gclass0_0.ResearchSpeed = Convert.ToInt32(this.txtResearchSpeed.Text);
            gclass0_0.HostilityModifier = Convert.ToInt32(this.txtHostilityModifier.Text);
            gclass0_0.TerraformingSpeed = Convert.ToInt32(this.txtTerraformingSpeed.Text);
            gclass0_0.SurveySpeed = Convert.ToInt32(this.txtSurveySpeed.Text);
            gclass0_0.MinComets = Convert.ToInt32(this.txtMinComets.Text);
            gclass0_0.SMPassword = this.txtPassword.Text;
            gclass0_0.StartYear = Convert.ToInt32(this.txtYear.Text);
            gclass0_0.NPRBaseTransits = Convert.ToInt32(this.txtNPRBaseTransits.Text);
            gclass0_0.NPRRandomTransits = Convert.ToInt32(this.txtNPRRandomTransits.Text);
            gclass0_0.NPRMaxSystems = Convert.ToInt32(this.txtNPRMaxStartingSystems.Text);
            if (gclass0_0.RaceChance > 100)
                gclass0_0.RaceChance = 100;
            if (gclass0_0.NewRuinCreationChance > 100)
                gclass0_0.NewRuinCreationChance = 100;
            if (gclass0_0.RaceChanceNPR > 100)
                gclass0_0.RaceChanceNPR = 100;
            if (gclass0_0.PreIndustrialChance < 0)
                gclass0_0.PreIndustrialChance = 0;
            if (gclass0_0.ConventionalChance < 0)
                gclass0_0.ConventionalChance = 0;
            if (gclass0_0.PreIndustrialChance > 100)
                gclass0_0.PreIndustrialChance = 100;
            if (gclass0_0.ConventionalChance > 100 - gclass0_0.PreIndustrialChance)
                gclass0_0.ConventionalChance = 100 - gclass0_0.PreIndustrialChance;
            if (gclass0_0.MinorRaceChance > 100 - gclass0_0.PreIndustrialChance - gclass0_0.ConventionalChance)
                gclass0_0.MinorRaceChance = 100 - gclass0_0.PreIndustrialChance - gclass0_0.ConventionalChance;
            if (gclass0_0.MinorRaceChance < 0)
                gclass0_0.MinorRaceChance = 0;
            if (gclass0_0.RaceChance < 0)
                gclass0_0.RaceChance = 0;
            if (gclass0_0.NewRuinCreationChance < 0)
                gclass0_0.NewRuinCreationChance = 0;
            if (gclass0_0.RaceChanceNPR < 0)
                gclass0_0.RaceChanceNPR = 0;
            if (gclass0_0.TerraformingSpeed < 0)
                gclass0_0.TerraformingSpeed = 0;
            if (gclass0_0.SurveySpeed < 0)
                gclass0_0.SurveySpeed = 0;
            if (gclass0_0.NPRBaseTransits < 0)
                gclass0_0.NPRBaseTransits = 0;
            if (gclass0_0.NPRRandomTransits < 0)
                gclass0_0.NPRRandomTransits = 0;
            if (gclass0_0.NPRMaxSystems < 0)
                gclass0_0.NPRMaxSystems = 0;
            ParsedDecimal gclass208 = AuroraUtils.ParseDecimalString(this.txtTruceCountdown.Text);
            if (gclass208.Succeed)
                gclass0_0.TruceCountdown = gclass208.Value;
            gclass0_0.TechFromConquest = AuroraUtils.smethod_69(this.chkConquerTech.Checked);
            gclass0_0.CivilianShippingLinesActive = AuroraUtils.smethod_69(this.chkCivilianShippingLinesActive.Checked);
            gclass0_0.AllowCivilianHarvesters = AuroraUtils.smethod_69(this.chkAllowCivilianHarvesters.Checked);
            gclass0_0.OrbitalMotion = AuroraUtils.smethod_69(this.chkOrb.Checked);
            gclass0_0.OrbitalMotionAst = AuroraUtils.smethod_69(this.chkOrbAst.Checked);
            gclass0_0.PoliticalAdmirals = AuroraUtils.smethod_69(this.chkPoliticalAdmirals.Checked);
            gclass0_0.InexpFleets = AuroraUtils.smethod_69(this.chkInexpFleets.Checked);
            gclass0_0.AutoJumpGates = AuroraUtils.smethod_69(this.chkAutoJumpGates.Checked);
            gclass0_0.Precursors = AuroraUtils.smethod_69(this.chkPrecursors.Checked);
            gclass0_0.Rakhas = AuroraUtils.smethod_69(this.chkRakhas.Checked);
            gclass0_0.StarSwarm = AuroraUtils.smethod_69(this.chkStarSwarm.Checked);
            gclass0_0.Invaders = AuroraUtils.smethod_69(this.chkInvaders.Checked);
            gclass0_0.Eldar = AuroraUtils.smethod_69(this.chkEldar.Checked);
            gclass0_0.UseKnownStars = AuroraUtils.smethod_69(this.chkUseKnownStars.Checked);
            gclass0_0.GenerateNPRs = AuroraUtils.smethod_69(this.chkGenerateNPRs.Checked);
            gclass0_0.HumanNPRs = AuroraUtils.smethod_69(this.chkHumanNPRs.Checked);
            gclass0_0.GenerateNonTNOnly = AuroraUtils.smethod_69(this.chkGenerateNonTNOnly.Checked);
            gclass0_0.NoOverhauls = AuroraUtils.smethod_69(this.chkNoOverhauls.Checked);
            gclass0_0.RealisticPromotions = AuroraUtils.smethod_69(this.chkRealisticPromotions.Checked);
            gclass0_0.NPRsGeneratePrecursors = AuroraUtils.smethod_69(this.chkNPRsGeneratePrecursors.Checked);
            gclass0_0.NPRsGenerateSwarm = AuroraUtils.smethod_69(this.chkNPRsGenerateSwarm.Checked);
            gclass0_0.NPRsGenerateRifts = AuroraUtils.smethod_69(this.chkNPRsGenerateRifts.Checked);
            gclass0_0.NPRsEncounterRaiders = AuroraUtils.smethod_69(this.chkNPRsEncounterRaiders.Checked);
            gclass0_0.ConstellationNames = AuroraUtils.smethod_69(this.chkConstellationNames.Checked);
            gclass0_0.StarEccentricity = AuroraUtils.smethod_69(this.chkStarEccentricity.Checked);
            gclass0_0.GasGiantEffects = AuroraUtils.smethod_69(this.chkGasGiantEffects.Checked);
            gclass0_0.LimitedLabs = AuroraUtils.smethod_69(this.chkLimitedLabs.Checked);
            gclass0_0.OneSecondSubPulse = AuroraUtils.smethod_69(this.chkOneSecondSubPulse.Checked);
            gclass0_0.LimitPlanetaryDistance = AuroraUtils.smethod_69(this.chkLimitPlanetaryDistance.Checked);
            gclass0_0.ParallelUniverse = AuroraUtils.smethod_69(this.chkParallelUniverse.Checked);
            gclass0_0.UseThemeInKnownStars = AuroraUtils.smethod_69(this.chkUseThemeInKnownStars.Checked);
            gclass0_0.EnhancedInvaders = AuroraUtils.smethod_69(this.chkEnhancedInvaders.Checked);
            gclass0_0.EnhancedPrecursors = AuroraUtils.smethod_69(this.chkEnhancedPrecursors.Checked);
            gclass0_0.EnhancedSwarm = AuroraUtils.smethod_69(this.chkEnhancedSwarm.Checked);
            if (gclass0_0.ParallelUniverse == 1)
                gclass0_0.UseKnownStars = 0;
            gclass0_0.NonPlayerSystemDetection = this.cboDetection.SelectedIndex;
            gclass0_0.SolDisaster = (GEnum30)this.cboDisaster.SelectedIndex;
            Star197 gclass197 =
                gclass0_0.StarDictionary.Values.FirstOrDefault<Star197>(gclass197_0 =>
                    gclass197_0.SystemData.IsSolSystem);
            if (gclass197 == null)
                return;
            if (gclass0_0.SolDisaster != GEnum30.const_4 && gclass0_0.SolDisaster != GEnum30.const_5 &&
                gclass0_0.SolDisaster != GEnum30.const_6 && gclass0_0.SolDisaster != GEnum30.const_1 &&
                gclass0_0.SolDisaster != GEnum30.const_2 && gclass0_0.SolDisaster != GEnum30.const_7 &&
                gclass0_0.SolDisaster != GEnum30.const_8 && gclass0_0.SolDisaster != GEnum30.const_9 &&
                gclass0_0.SolDisaster != GEnum30.const_3)
                gclass197.genum30_0 = GEnum30.const_0;
            else
                gclass197.genum30_0 = gclass0_0.SolDisaster;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1710);
        }
    }

    private void chkParallelUniverse_MouseEnter(object sender, EventArgs e)
    {
        try
        {
            string name = ((Control)sender).Name;
            if (name == null)
                return;
            switch (name.Length)
            {
                case 6:
                    if (!(name == "chkOrb"))
                        break;
                    this.txtOptionDescription.Text =
                        "While this option is active, planets and moons will orbit their parent bodies";
                    break;
                case 7:
                    switch (name[3])
                    {
                        case 'N':
                            if (!(name == "txtNPRs"))
                                return;
                            this.txtOptionDescription.Text =
                                "The number of computer-controlled opponents (non-player races) created at the start of the game. NPRs will start in systems generated by Aurora and  are hidden from the Spacemaster. NPRs are similar in function to player races.";
                            return;
                        case 'Y':
                            if (!(name == "txtYear"))
                                return;
                            this.txtOptionDescription.Text =
                                "The starting year of the campaign. Campaign dates will begin on January 1st of this year. It has no impact beyond the starting point for dates and is otherwise cosmetic.";
                            return;
                        default:
                            return;
                    }
                case 8:
                    if (!(name == "chkEldar"))
                        break;
                    this.txtOptionDescription.Text =
                        "Aether Raiders are one of the lower technology non-NPR threats, but have a couple of technologies that allow them to launch effective raiding operations on unprotected ships and colonies.";
                    break;
                case 9:
                    switch (name[3])
                    {
                        case 'C':
                            if (!(name == "txtChance"))
                                return;
                            this.txtOptionDescription.Text =
                                "The chance of a newly discovered system linking to a 'Local System'. A Local System is definied as having a system number close to that of the system from which it was entered. This setting does not apply to Known Stars games";
                            return;
                        case 'O':
                            if (!(name == "chkOrbAst"))
                                return;
                            this.txtOptionDescription.Text =
                                "While this option is active, asteroids will orbit their parent stars";
                            return;
                        case 'P':
                            return;
                        case 'Q':
                            return;
                        case 'R':
                            if (!(name == "chkRakhas"))
                                return;
                            this.txtOptionDescription.Text =
                                "Rakhas are hulking, belligerent grey-to-green-skinned humanoids that do not build space craft. Small tribes are often found on worlds rich with trans-newtonian elements and will attack any alien presence. There are no civilian or non-combatant Rakhas";
                            return;
                        case 'S':
                            if (!(name == "txtSpread"))
                                return;
                            this.txtOptionDescription.Text =
                                "The maximum difference in system numbers between a newly discovered 'Local System' and the system from which it was entered. This setting does not apply to Known Stars games";
                            return;
                        default:
                            return;
                    }
                case 10:
                    switch (name[0])
                    {
                        case 'c':
                            if (!(name == "chkPlanetX"))
                                return;
                            this.txtOptionDescription.Text =
                                "Add a ninth major planet to the Sol system. This may be a gas giant, superjovian or terrestrial world and it may have moons.";
                            return;
                        case 't':
                            if (!(name == "txtPlayers"))
                                return;
                            this.txtOptionDescription.Text =
                                "The number of player races created at the start of the game. When 'Create Game' is clicked, this number of Create Race windows will sequentially appear during the game setup process. You can edit each race as required before accepting it.";
                            return;
                        default:
                            return;
                    }
                case 11:
                    switch (name[4])
                    {
                        case 'P':
                            if (!(name == "chkNPRSetup"))
                                return;
                            this.txtOptionDescription.Text =
                                "If this option is chosen, a window will popup for each NPR allowing you to choose themes, pictures, starting system (for known stars), terrain type, etc.";
                            return;
                        case 'a':
                            if (!(name == "txtPassword"))
                                return;
                            this.txtOptionDescription.Text =
                                "The password required to enter Spacemaster Mode. This can be set to blank if desired";
                            return;
                        case 'i':
                            if (!(name == "cboDisaster"))
                                return;
                            this.txtOptionDescription.Text =
                                "Start the game with a disaster occurring in the Sol system.";
                            return;
                        case 'n':
                            if (!(name == "chkInvaders"))
                                return;
                            this.txtOptionDescription.Text =
                                "Extra-Galactic Invaders. The Invaders periodically attempt to sweep the Milky Way galaxy clean of competitor races. They destroyed the original Precursor civilization during their last incursion. Extremely Dangerous. Invaders are one of the Ancient Races, which do not behave in the same way as a normal non-player race (NPR)s";
                            return;
                        case 'r':
                            if (!(name == "txtProdTime"))
                                return;
                            this.txtOptionDescription.Text =
                                "The minimum interval in seconds between construction phases";
                            return;
                        default:
                            return;
                    }
                case 12:
                    switch (name[3])
                    {
                        case 'D':
                            if (!(name == "cboDetection"))
                                return;
                            this.txtOptionDescription.Text =
                                "Sensor checks normally take place in systems in which two or more races are present. This dropdown allows you to switch off detection, or make it automatic, in systems where none of those races is a player race";
                            return;
                        case 'H':
                            if (!(name == "chkHumanNPRs"))
                                return;
                            this.txtOptionDescription.Text =
                                "Non-player races may be generated as human if environmental conditions allow. This is to simulate lost human colonies in a post-collapse scenario. 'Human' in this context is the species of the oldest population of the oldest player race.";
                            return;
                        case 'M':
                            if (!(name == "txtMinComets"))
                                return;
                            this.txtOptionDescription.Text =
                                "During normal system generation, not all systems will have comets. By setting this value to greater than zero you can override normal generation to ensure a minimum number of comets per system.";
                            return;
                        case 'S':
                            if (!(name == "chkStarSwarm"))
                                return;
                            this.txtOptionDescription.Text =
                                "Star Swarm. An alien species of living ships that reproduce in space. Individually weak but troublesome in numbers. The Star Swarm is one of the Ancient Races, which do not behave in the same way as a normal non-player race (NPR)";
                            return;
                        default:
                            return;
                    }
                case 13:
                    switch (name[3])
                    {
                        case 'J':
                            if (!(name == "txtJumpPoints"))
                                return;
                            this.txtOptionDescription.Text =
                                "The number of jump points created in the Sol system. Setting to zero will result in a random number of jump points";
                            return;
                        case 'K':
                            return;
                        case 'L':
                            return;
                        case 'M':
                            if (!(name == "txtMinorRaces"))
                                return;
                            this.txtOptionDescription.Text =
                                "The % of new NPRs that are generated as minor races. Minor races will be approximately 25% of the size of normal NPRs. They will be Trans-Newtonian, but not jump capable.";
                            return;
                        case 'N':
                            if (!(name == "txtNumSystems"))
                                return;
                            this.txtOptionDescription.Text =
                                "The maximum number of systems in the game. This setting does not affect Known Stars games.";
                            return;
                        case 'O':
                            return;
                        case 'P':
                            if (!(name == "chkPrecursors"))
                                return;
                            this.txtOptionDescription.Text =
                                "Precursors are ancient robot controlled ships, usually found guarding alien ruins. Dangerous. Precursors are one of the Ancient Races, which do not behave in the same way as a normal non-player race (NPR)";
                            return;
                        case 'Q':
                            return;
                        case 'R':
                            if (!(name == "txtRaceChance"))
                                return;
                            this.txtOptionDescription.Text =
                                "The chance of a new race appearing on a suitable system body in a system discovered by a player race. Suitable means no ruins, oxy atm > 0.07  and < 0.4, oxy pressure <= 30% total pressure, temp > -40C and < +60C, Grav > 0.4 and < 2.5, no dangerous gases, hydro extent at least 10%.";
                            return;
                        default:
                            return;
                    }
                case 14:
                    switch (name[3])
                    {
                        case 'C':
                            if (!(name == "chkConquerTech"))
                                return;
                            this.txtOptionDescription.Text =
                                "If this option is checked, when a population is conquered, the conquering race gains technology from the conquered race, proportionate to the percentage of total race population represented by that conquered population";
                            return;
                        case 'I':
                            if (!(name == "chkInexpFleets"))
                                return;
                            this.txtOptionDescription.Text =
                                " When this option is in effect, fleets will respond to orders more slowly if they are inexperienced. This can be particularly troublesome in close combat. Ships will slowly gain experience over time. This process can be accelerated using Fleet Training exercises.";
                            return;
                        case 'L':
                            if (!(name == "chkLimitedLabs"))
                                return;
                            this.txtOptionDescription.Text =
                                "Scientists will start with 20% of their normal research administration capacity and admin increases via experience will be for one or two facilities only";
                            return;
                        case 'N':
                            if (!(name == "chkNoOverhauls"))
                                return;
                            this.txtOptionDescription.Text =
                                "Check this option if you wish to disable maintenance. Ships will not suffer maintenance failures and will not require overhauls";
                            return;
                        case 'S':
                            if (!(name == "txtSurveySpeed"))
                                return;
                            this.txtOptionDescription.Text =
                                "The Survey Speed affects the speed of geological and gravitational surveys. 100% is for normal settings. 90% = slower surveys. 110% = faster surveys. This applies to all races in the game, including NPRs.";
                            return;
                        default:
                            return;
                    }
                case 15:
                    if (!(name == "chkGenerateNPRs"))
                        break;
                    this.txtOptionDescription.Text =
                        "Any non-starting races created during system generation will be computer-controlled (non-player races). If this option is not checked, any new races will require manual control (player races).";
                    break;
                case 16 /*0x10*/:
                    switch (name[4])
                    {
                        case 'a':
                            if (!(name == "txtRaceChanceNPR"))
                                return;
                            this.txtOptionDescription.Text =
                                "The chance of a new race appearing on a suitable system body in a system discovered by a non-player race. Suitable means no ruins, oxy atm > 0.07  and < 0.4, oxy pressure <= 30% total pressure, temp > -40C and < +60C, Grav > 0.4 and < 2.5, no dangerous gases, hydro extent at least 10%.";
                            return;
                        case 'e':
                            if (!(name == "txtResearchSpeed"))
                                return;
                            this.txtOptionDescription.Text =
                                "The Research Speed affects the production of research points by scientists. 100% is for normal settings. 90% = less RP. 110% = more RP. This applies to all races in the game, including NPRs.";
                            return;
                        case 's':
                            if (!(name == "chkUseKnownStars"))
                                return;
                            this.txtOptionDescription.Text =
                                "Real-world star systems will be used in Aurora, along with the commonly used name, actual star types and the orbital distances for binaries / multiple star systems. All planets and other system bodies will be randomly generated. Jump points will link to nearby systems in real space based on celestial coordinates.";
                            return;
                        case 'u':
                            if (!(name == "chkAutoJumpGates"))
                                return;
                            this.txtOptionDescription.Text =
                                "All jump points are stable, which means that jump ships are unnecessary and all ships will be able to transit all jump points.";
                            return;
                        default:
                            return;
                    }
                case 17:
                    switch (name[4])
                    {
                        case 'a':
                            if (!(name == "lblMaxNPRDistance"))
                                return;
                            this.txtOptionDescription.Text =
                                "Applies only to known stars games. This is the maximum distance from Sol at which an NPR home system will be generated.";
                            return;
                        case 'r':
                            if (!(name == "txtTruceCountdown"))
                                return;
                            this.txtOptionDescription.Text =
                                "The minimum time in years for which NPRs will maintain a truce against races who share the same system as their capital. This can be used for multi-player games with multiple NPRs on Earth.";
                            return;
                        case 'u':
                            if (!(name == "lblMubNPRDistance"))
                                return;
                            this.txtOptionDescription.Text =
                                "Applies only to known stars games. This is the minimum distance from Sol at which an NPR home system will be generated.";
                            return;
                        default:
                            return;
                    }
                case 18:
                    if (!(name == "chkGasGiantEffects"))
                        break;
                    this.txtOptionDescription.Text =
                        "Gas giants and Superjovians with a mass of 50 or more will have an effect on nearby planets. This can cause more eccentrics orbits, capturing as a moon, ejection from the system or replacement by asteroid belt.";
                    break;
                case 19:
                    switch (name[3])
                    {
                        case 'E':
                            if (!(name == "chkEnhancedInvaders"))
                                return;
                            this.txtOptionDescription.Text =
                                "Enhanced Invaders function in exactly the samw way as basic invaders, except that new rifts may be larger, in some cases much larger, than the standard 10m kilometres";
                            return;
                        case 'P':
                            if (!(name == "chkParallelUniverse"))
                                return;
                            this.txtOptionDescription.Text =
                                "All new systems discovered will be parallel universe versions of the Sol system";
                            return;
                        case 'S':
                            if (!(name == "chkStarEccentricity"))
                                return;
                            this.txtOptionDescription.Text =
                                "Stars and planets will be generated with an eccentricity in their orbit.";
                            return;
                        default:
                            return;
                    }
                case 20:
                    switch (name[6])
                    {
                        case 'I':
                            if (!(name == "txtPreIndustralRaces"))
                                return;
                            this.txtOptionDescription.Text =
                                "The % of new NPRs that are generated as pre-industrial races. Pre-industrial races will be approximately 12.5% of the size of normal NPRs. They will not have any industry or ships.";
                            return;
                        case 'S':
                            if (!(name == "chkOneSecondSubPulse"))
                                return;
                            this.txtOptionDescription.Text =
                                "Increments of 5 seconds will have five 1 second sub-pulses for movement purposes";
                            return;
                        case 'a':
                            if (!(name == "chkEnhancedStarSwarm"))
                                return;
                            this.txtOptionDescription.Text =
                                "Enhanced Star Swarm are similar to the basic version in terms of capability. However, once the first star swarm appears, new swarms will randomly appear at the edge of existing systems that are close to the original contact system in real space";
                            return;
                        case 'e':
                            if (!(name == "chkGenerateNonTNOnly"))
                                return;
                            this.txtOptionDescription.Text =
                                "If this option is checked, any newly generated races will be pre-industrial. This applies to NPRs and player races (the latter applies if the 'Generate New Races as NPRs' option is not checked)";
                            return;
                        case 'i':
                            if (!(name == "chkPoliticalAdmirals"))
                                return;
                            this.txtOptionDescription.Text =
                                "When using realistic promotions, officers are promoted based on their skills. If this option is in use, those skills include a political bonus which has no other use. This simulates the rise of those officers who rely on political connections rather than ability.";
                            return;
                        case 'r':
                            if (!(name == "txtTerraformingSpeed"))
                                return;
                            this.txtOptionDescription.Text =
                                "The Terraforming Speed affects the atm production of terraforming installations and modules. 100% is for normal settings. 90% = less atm. 110% = more atm. This applies to all races in the game, including NPRs.";
                            return;
                        case 's':
                            switch (name)
                            {
                                case "chkNPRsGenerateSwarm":
                                    this.txtOptionDescription.Text =
                                        "If this option is checked, NPRs may generate Star Swarm during system generation";
                                    return;
                                case "chkNPRsGenerateRifts":
                                    this.txtOptionDescription.Text =
                                        "If this option is checked, NPRs may generate aether rifts during system generation";
                                    return;
                                default:
                                    return;
                            }
                        case 't':
                            if (!(name == "txtHostilityModifier") && !(name == "lblHostilityModifier"))
                                return;
                            this.txtOptionDescription.Text =
                                "This amount is added to the Xenophobia and Militarism attributes of newly generated NPRs and deducted from their Diplomacy and Trade attributes";
                            return;
                        default:
                            return;
                    }
                case 21:
                    switch (name[3])
                    {
                        case 'C':
                            if (!(name == "chkConstellationNames"))
                                return;
                            this.txtOptionDescription.Text =
                                "Where a known system has a generic name such as Gliese 101, a new name will be generated based on unused Bayer and Flamsteed nomenclature for the star's constellation. This is set for the closest 1000 stars to Earth.";
                            return;
                        case 'D':
                            if (!(name == "txtDifficultyModifier"))
                                return;
                            this.txtOptionDescription.Text =
                                "The Difficulty Modifier is applied to starting size for NPR populations, NPR Research rates and NPR growth rates. 100% is for normal settings. 90% = easier. 110% = harder.";
                            return;
                        case 'E':
                            if (!(name == "chkEnhancedPrecursors"))
                                return;
                            this.txtOptionDescription.Text =
                                "Enhanced Precursors have existed for millenia in ancient tombs. They will not be visible until they awaken, sending forces on to the surface and launching ships from deep beneath the surface. Not all their forces may emerge at once";
                            return;
                        default:
                            return;
                    }
                case 22:
                    if (!(name == "chkRealisticPromotions"))
                        break;
                    this.txtOptionDescription.Text =
                        "This option will allow Aurora to look after the promotions within your officer corps, basing them on skills, medals and time in grade.";
                    break;
                case 23:
                    switch (name[3])
                    {
                        case 'N':
                            if (!(name == "chkNPRsEncounterRaiders"))
                                return;
                            this.txtOptionDescription.Text =
                                "If this option is checked, NPRs may suffer from raider attacks";
                            return;
                        case 'U':
                            if (!(name == "chkUseThemeInKnownStars"))
                                return;
                            this.txtOptionDescription.Text =
                                "The race system naming theme will be used instead of the real system name in known stars games";
                            return;
                        default:
                            return;
                    }
                case 24:
                    if (!(name == "txtNewRuinCreationChance"))
                        break;
                    this.txtOptionDescription.Text =
                        "The chance of an ancient ruin appearing on a suitable system body during system generation. Suitable means surface temperature between -73C and +87C with Gravity greater than 0.4G.";
                    break;
                case 25:
                    switch (name[3])
                    {
                        case 'L':
                            if (!(name == "chkLimitPlanetaryDistance"))
                                return;
                            this.txtOptionDescription.Text =
                                "Planets and other bodies will not be created beyond twice the distance of the outer survey location ring. Stars without LG points will not be created more than 24b km from the primary";
                            return;
                        case 'N':
                            if (!(name == "chkNPRsGeneratePrecursors"))
                                return;
                            this.txtOptionDescription.Text =
                                "If this option is checked, NPRs may generate Precursors during system generation";
                            return;
                        default:
                            return;
                    }
                case 26:
                    if (!(name == "chkAllowCivilianHarvesters"))
                        break;
                    this.txtOptionDescription.Text =
                        "If this is checked, civilian shipping lines will include fuel harvesters in the list of ship types they will build";
                    break;
                case 30:
                    if (!(name == "chkCivilianShippingLinesActive"))
                        break;
                    this.txtOptionDescription.Text =
                        "If this is checked, civilian shipping line will build ships as their finances allow. With this option off, no civilian ships will be built.";
                    break;
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1711);
        }
    }

    private void cmdSave_Click(object sender, EventArgs e)
    {
        try
        {
            this.method_6(false);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1712);
        }
    }

    private void cmdDelete_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.tacticalMap_0.gclass0_1 == null)
            {
                int num = (int)MessageBox.Show("Please select a game to delete");
            }
            else
            {
                int int66 = this.tacticalMap_0.gclass0_1.GameID;
                if (MessageBox.Show(
                        $" Are you sure you want to delete the game {this.tacticalMap_0.gclass0_1.GameName}?",
                        "Confirmation Required", MessageBoxButtons.YesNo) != DialogResult.Yes ||
                    MessageBox.Show(" Are you really, really sure?", "Confirmation Required",
                        MessageBoxButtons.YesNo) != DialogResult.Yes)
                    return;
                Cursor.Current = Cursors.WaitCursor;
                List<string> stringList = new List<string>();
                foreach (DataRow row in (InternalDataCollectionBase)new SQLiteDatabaseC1181()
                             .ExecuteQuery("SELECT name FROM sqlite_master WHERE type = 'table'").Rows)
                {
                    string string_2 = row["Name"].ToString();
                    if (AuroraUtils.smethod_25(string_2, 3) == "FCT" && string_2 != "FCT_HullDescription" &&
                        string_2 != "FCT_ClassComponentTemplate" && string_2 != "FCT_ShipClassTemplate" &&
                        string_2 != "FCT_ShipComponentTemplate")
                        stringList.Add(string_2);
                }

                stringList.Add("DIM_KnownSystems");
                SQLiteConnection connection = new SQLiteConnection(AuroraUtils.string_1);
                connection.Open();
                foreach (string str in stringList)
                    new SQLiteCommand($"DELETE FROM {str} WHERE GameID = {int66.ToString()}", connection)
                        .ExecuteNonQuery();
                this.cboGame.DataSource = null;
                this.method_0();
                Cursor.Current = Cursors.Default;
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1713);
        }
    }

    private void txtNewGameName_TextChanged(object sender, EventArgs e)
    {
    }

    private void flowLayoutPanel4_Paint(object sender, PaintEventArgs e)
    {
    }

    private void cboDisaster_SelectedIndexChanged(object sender, EventArgs e)
    {
    }

    private void txtYear_Leave(object sender, EventArgs e)
    {
        try
        {
            if (Convert.ToInt32(this.txtYear.Text) < 1)
            {
                this.txtYear.Text = "1";
                int num = (int)MessageBox.Show("Starting Year must be between 1 and 9000");
            }

            if (Convert.ToInt32(this.txtYear.Text) <= 9000)
                return;
            this.txtYear.Text = "9000";
            int num1 = (int)MessageBox.Show("Starting Year must be between 1 and 9000");
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3189);
        }
    }

    private void txtPlayers_Leave(object sender, EventArgs e)
    {
        try
        {
            ParsedDecimal gclass208 = AuroraUtils.ParseDecimalString(this.txtPlayers.Text);
            if (gclass208.Succeed && !(gclass208.Value <= 0M))
                return;
            this.txtPlayers.Text = "1";
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3219);
        }
    }

    private void cmdRename_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.tacticalMap_0.gclass0_1 == null)
                return;
            this.tacticalMap_0.gclass0_1.string_3 = "Enter New Game Name";
            this.tacticalMap_0.gclass0_1.string_4 = this.tacticalMap_0.gclass0_1.GameName;
            int num = (int)new MessageEntry(this.tacticalMap_0.gclass0_1).ShowDialog();
            if (!(this.tacticalMap_0.gclass0_1.string_4 != this.tacticalMap_0.gclass0_1.GameName) ||
                this.tacticalMap_0.gclass0_1.bool_21)
                return;
            this.tacticalMap_0.gclass0_1.GameName = this.tacticalMap_0.gclass0_1.string_4;
            this.tacticalMap_0.gclass0_1.method_157(this.tacticalMap_0.gclass0_1.GameID,
                this.tacticalMap_0.gclass0_1.string_4);
            this.bool_0 = true;
            this.method_0();
            this.bool_0 = false;
            this.method_1();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3252);
        }
    }

    private void cboDetection_SelectedIndexChanged(object sender, EventArgs e)
    {
    }

    private void txtOptionDescription_TextChanged(object sender, EventArgs e)
    {
    }

    private void chkParallelUniverse_CheckedChanged(object sender, EventArgs e)
    {
        try
        {
            if (!this.chkParallelUniverse.Checked)
                return;
            this.chkUseKnownStars.Checked = false;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3772);
        }
    }

    private void txtMinorRaces_TextChanged(object sender, EventArgs e)
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
        this.flowLayoutPanel2 = new FlowLayoutPanel();
        this.panel2 = new Panel();
        this.txtNumSystems = new TextBox();
        this.label3 = new Label();
        this.panel3 = new Panel();
        this.txtChance = new TextBox();
        this.label5 = new Label();
        this.panel4 = new Panel();
        this.txtSpread = new TextBox();
        this.label6 = new Label();
        this.panel6 = new Panel();
        this.txtProdTime = new TextBox();
        this.label8 = new Label();
        this.panel1 = new Panel();
        this.txtDifficultyModifier = new TextBox();
        this.label1 = new Label();
        this.panel20 = new Panel();
        this.txtResearchSpeed = new TextBox();
        this.label21 = new Label();
        this.panel21 = new Panel();
        this.txtTerraformingSpeed = new TextBox();
        this.label22 = new Label();
        this.panel24 = new Panel();
        this.txtSurveySpeed = new TextBox();
        this.label25 = new Label();
        this.panel9 = new Panel();
        this.txtNewRuinCreationChance = new TextBox();
        this.label11 = new Label();
        this.panel10 = new Panel();
        this.txtMinComets = new TextBox();
        this.label12 = new Label();
        this.panel11 = new Panel();
        this.txtTruceCountdown = new TextBox();
        this.label13 = new Label();
        this.panel13 = new Panel();
        this.txtPassword = new TextBox();
        this.label14 = new Label();
        this.panel14 = new Panel();
        this.txtConfirm = new TextBox();
        this.label15 = new Label();
        this.panel12 = new Panel();
        this.cboDetection = new ComboBox();
        this.label17 = new Label();
        this.panel19 = new Panel();
        this.cboDisaster = new ComboBox();
        this.label18 = new Label();
        this.panel7 = new Panel();
        this.txtRaceChance = new TextBox();
        this.label9 = new Label();
        this.panel8 = new Panel();
        this.txtRaceChanceNPR = new TextBox();
        this.label10 = new Label();
        this.panel29 = new Panel();
        this.txtMinorRaces = new TextBox();
        this.label23 = new Label();
        this.panel28 = new Panel();
        this.txtHostilityModifier = new TextBox();
        this.lblHostilityModifier = new Label();
        this.panel15 = new Panel();
        this.txtYear = new TextBox();
        this.label16 = new Label();
        this.flowLayoutPanel1 = new FlowLayoutPanel();
        this.chkUseKnownStars = new CheckBox();
        this.chkConstellationNames = new CheckBox();
        this.chkOrb = new CheckBox();
        this.chkOrbAst = new CheckBox();
        this.chkGenerateNPRs = new CheckBox();
        this.chkHumanNPRs = new CheckBox();
        this.chkGenerateNonTNOnly = new CheckBox();
        this.chkPrecursors = new CheckBox();
        this.chkStarSwarm = new CheckBox();
        this.chkInvaders = new CheckBox();
        this.chkEnhancedPrecursors = new CheckBox();
        this.chkEnhancedSwarm = new CheckBox();
        this.chkEnhancedInvaders = new CheckBox();
        this.chkRakhas = new CheckBox();
        this.chkEldar = new CheckBox();
        this.chkNPRsGeneratePrecursors = new CheckBox();
        this.chkNPRsGenerateSwarm = new CheckBox();
        this.chkNPRsGenerateRifts = new CheckBox();
        this.chkNPRsEncounterRaiders = new CheckBox();
        this.chkRealisticPromotions = new CheckBox();
        this.chkLimitedLabs = new CheckBox();
        this.chkInexpFleets = new CheckBox();
        this.chkPoliticalAdmirals = new CheckBox();
        this.chkAutoJumpGates = new CheckBox();
        this.chkNoOverhauls = new CheckBox();
        this.chkCivilianShippingLinesActive = new CheckBox();
        this.chkAllowCivilianHarvesters = new CheckBox();
        this.chkConquerTech = new CheckBox();
        this.chkStarEccentricity = new CheckBox();
        this.chkGasGiantEffects = new CheckBox();
        this.chkOneSecondSubPulse = new CheckBox();
        this.chkLimitPlanetaryDistance = new CheckBox();
        this.chkUseThemeInKnownStars = new CheckBox();
        this.label7 = new Label();
        this.cboGame = new ComboBox();
        this.cmdDelete = new Button();
        this.cmdSave = new Button();
        this.cmdNew = new Button();
        this.cmdSelect = new Button();
        this.txtOptionDescription = new TextBox();
        this.flpNewGame = new FlowLayoutPanel();
        this.panel5 = new Panel();
        this.txtPlayers = new TextBox();
        this.label19 = new Label();
        this.panel17 = new Panel();
        this.txtNPRs = new TextBox();
        this.label20 = new Label();
        this.panel16 = new Panel();
        this.txtJumpPoints = new TextBox();
        this.label2 = new Label();
        this.panel18 = new Panel();
        this.txtEarthDeposits = new TextBox();
        this.label4 = new Label();
        this.panel23 = new Panel();
        this.txtMinNPRDistance = new TextBox();
        this.lblMinNPRDistance = new Label();
        this.panel22 = new Panel();
        this.txtMaxNPRDistance = new TextBox();
        this.lblMaxNPRDistance = new Label();
        this.panel25 = new Panel();
        this.txtSwarmSystems = new TextBox();
        this.label26 = new Label();
        this.panel26 = new Panel();
        this.txtRaiderSystems = new TextBox();
        this.label27 = new Label();
        this.panel27 = new Panel();
        this.txtInvaderSystems = new TextBox();
        this.label28 = new Label();
        this.panel33 = new Panel();
        this.txtPrecursorRP = new TextBox();
        this.label31 = new Label();
        this.panel34 = new Panel();
        this.txtSwarmRP = new TextBox();
        this.label32 = new Label();
        this.panel35 = new Panel();
        this.txtRaiderRP = new TextBox();
        this.label33 = new Label();
        this.panel36 = new Panel();
        this.txtInvaderRP = new TextBox();
        this.label34 = new Label();
        this.flowLayoutPanel3 = new FlowLayoutPanel();
        this.chkNPRSetup = new CheckBox();
        this.chkPlanetX = new CheckBox();
        this.chkParallelUniverse = new CheckBox();
        this.panel30 = new Panel();
        this.txtNPRBaseTransits = new TextBox();
        this.label24 = new Label();
        this.panel31 = new Panel();
        this.txtNPRRandomTransits = new TextBox();
        this.label29 = new Label();
        this.panel32 = new Panel();
        this.txtNPRMaxStartingSystems = new TextBox();
        this.label30 = new Label();
        this.textBox4 = new TextBox();
        this.txtStartOnly = new TextBox();
        this.cmdCreate = new Button();
        this.cmdCancel = new Button();
        this.flowLayoutPanel4 = new FlowLayoutPanel();
        this.cmdRename = new Button();
        this.txtNewGameName = new TextBox();
        this.flowLayoutPanel5 = new FlowLayoutPanel();
        this.flowLayoutPanel6 = new FlowLayoutPanel();
        this.panel37 = new Panel();
        this.txtPreIndustrialRaces = new TextBox();
        this.label35 = new Label();
        this.panel38 = new Panel();
        this.txtConventionalRaces = new TextBox();
        this.label36 = new Label();
        this.flowLayoutPanel2.SuspendLayout();
        this.panel2.SuspendLayout();
        this.panel3.SuspendLayout();
        this.panel4.SuspendLayout();
        this.panel6.SuspendLayout();
        this.panel1.SuspendLayout();
        this.panel20.SuspendLayout();
        this.panel21.SuspendLayout();
        this.panel24.SuspendLayout();
        this.panel9.SuspendLayout();
        this.panel10.SuspendLayout();
        this.panel11.SuspendLayout();
        this.panel13.SuspendLayout();
        this.panel14.SuspendLayout();
        this.panel12.SuspendLayout();
        this.panel19.SuspendLayout();
        this.panel7.SuspendLayout();
        this.panel8.SuspendLayout();
        this.panel29.SuspendLayout();
        this.panel28.SuspendLayout();
        this.panel15.SuspendLayout();
        this.flowLayoutPanel1.SuspendLayout();
        this.flpNewGame.SuspendLayout();
        this.panel5.SuspendLayout();
        this.panel17.SuspendLayout();
        this.panel16.SuspendLayout();
        this.panel18.SuspendLayout();
        this.panel23.SuspendLayout();
        this.panel22.SuspendLayout();
        this.panel25.SuspendLayout();
        this.panel26.SuspendLayout();
        this.panel27.SuspendLayout();
        this.panel33.SuspendLayout();
        this.panel34.SuspendLayout();
        this.panel35.SuspendLayout();
        this.panel36.SuspendLayout();
        this.flowLayoutPanel3.SuspendLayout();
        this.panel30.SuspendLayout();
        this.panel31.SuspendLayout();
        this.panel32.SuspendLayout();
        this.flowLayoutPanel4.SuspendLayout();
        this.flowLayoutPanel5.SuspendLayout();
        this.flowLayoutPanel6.SuspendLayout();
        this.panel37.SuspendLayout();
        this.panel38.SuspendLayout();
        this.SuspendLayout();
        this.flowLayoutPanel2.BorderStyle = BorderStyle.FixedSingle;
        this.flowLayoutPanel2.Controls.Add(this.panel2);
        this.flowLayoutPanel2.Controls.Add(this.panel3);
        this.flowLayoutPanel2.Controls.Add(this.panel4);
        this.flowLayoutPanel2.Controls.Add(this.panel6);
        this.flowLayoutPanel2.Controls.Add(this.panel1);
        this.flowLayoutPanel2.Controls.Add(this.panel20);
        this.flowLayoutPanel2.Controls.Add(this.panel21);
        this.flowLayoutPanel2.Controls.Add(this.panel24);
        this.flowLayoutPanel2.Controls.Add(this.panel9);
        this.flowLayoutPanel2.Controls.Add(this.panel10);
        this.flowLayoutPanel2.Controls.Add(this.panel11);
        this.flowLayoutPanel2.Controls.Add(this.panel13);
        this.flowLayoutPanel2.Controls.Add(this.panel14);
        this.flowLayoutPanel2.Controls.Add(this.panel12);
        this.flowLayoutPanel2.Controls.Add(this.panel19);
        this.flowLayoutPanel2.FlowDirection = FlowDirection.TopDown;
        this.flowLayoutPanel2.Location = new Point(0, 3);
        this.flowLayoutPanel2.Margin = new Padding(0, 3, 3, 3);
        this.flowLayoutPanel2.Name = "flowLayoutPanel2";
        this.flowLayoutPanel2.Size = new Size(295, 470);
        this.flowLayoutPanel2.TabIndex = 12;
        this.panel2.Controls.Add(this.txtNumSystems);
        this.panel2.Controls.Add(this.label3);
        this.panel2.Location = new Point(3, 3);
        this.panel2.Margin = new Padding(3, 3, 3, 1);
        this.panel2.Name = "panel2";
        this.panel2.Size = new Size(281, 22);
        this.panel2.TabIndex = 8;
        this.txtNumSystems.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtNumSystems.BorderStyle = BorderStyle.None;
        this.txtNumSystems.ForeColor = Color.FromArgb(128 /*0x80*/, 255, 128 /*0x80*/);
        this.txtNumSystems.Location = new Point(197, 5);
        this.txtNumSystems.Name = "txtNumSystems";
        this.txtNumSystems.Size = new Size(84, 13);
        this.txtNumSystems.TabIndex = 9;
        this.txtNumSystems.Text = "1000";
        this.txtNumSystems.TextAlign = HorizontalAlignment.Center;
        this.txtNumSystems.Enter += this.chkParallelUniverse_MouseEnter;
        this.txtNumSystems.MouseEnter += this.chkParallelUniverse_MouseEnter;
        this.label3.AutoSize = true;
        this.label3.Dock = DockStyle.Left;
        this.label3.Location = new Point(0, 0);
        this.label3.Name = "label3";
        this.label3.Padding = new Padding(0, 5, 5, 0);
        this.label3.Size = new Size(150, 18);
        this.label3.TabIndex = 3;
        this.label3.Text = "Maximum Number of Systems";
        this.panel3.Controls.Add(this.txtChance);
        this.panel3.Controls.Add(this.label5);
        this.panel3.Location = new Point(3, 29);
        this.panel3.Margin = new Padding(3, 3, 3, 1);
        this.panel3.Name = "panel3";
        this.panel3.Size = new Size(281, 22);
        this.panel3.TabIndex = 9;
        this.txtChance.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtChance.BorderStyle = BorderStyle.None;
        this.txtChance.ForeColor = Color.FromArgb(128 /*0x80*/, 255, 128 /*0x80*/);
        this.txtChance.Location = new Point(197, 5);
        this.txtChance.Name = "txtChance";
        this.txtChance.Size = new Size(84, 13);
        this.txtChance.TabIndex = 9;
        this.txtChance.Text = "50";
        this.txtChance.TextAlign = HorizontalAlignment.Center;
        this.txtChance.Enter += this.chkParallelUniverse_MouseEnter;
        this.txtChance.MouseEnter += this.chkParallelUniverse_MouseEnter;
        this.label5.AutoSize = true;
        this.label5.Dock = DockStyle.Left;
        this.label5.Location = new Point(0, 0);
        this.label5.Name = "label5";
        this.label5.Padding = new Padding(0, 5, 5, 0);
        this.label5.Size = new Size(181, 18);
        this.label5.TabIndex = 3;
        this.label5.Text = "Local System Generation Chance %";
        this.label5.MouseEnter += this.chkParallelUniverse_MouseEnter;
        this.panel4.Controls.Add(this.txtSpread);
        this.panel4.Controls.Add(this.label6);
        this.panel4.Location = new Point(3, 55);
        this.panel4.Margin = new Padding(3, 3, 3, 1);
        this.panel4.Name = "panel4";
        this.panel4.Size = new Size(281, 22);
        this.panel4.TabIndex = 10;
        this.txtSpread.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtSpread.BorderStyle = BorderStyle.None;
        this.txtSpread.ForeColor = Color.FromArgb(128 /*0x80*/, 255, 128 /*0x80*/);
        this.txtSpread.Location = new Point(197, 5);
        this.txtSpread.Name = "txtSpread";
        this.txtSpread.Size = new Size(84, 13);
        this.txtSpread.TabIndex = 9;
        this.txtSpread.Text = "15";
        this.txtSpread.TextAlign = HorizontalAlignment.Center;
        this.txtSpread.Enter += this.chkParallelUniverse_MouseEnter;
        this.txtSpread.MouseEnter += this.chkParallelUniverse_MouseEnter;
        this.label6.AutoSize = true;
        this.label6.Dock = DockStyle.Left;
        this.label6.Location = new Point(0, 0);
        this.label6.Name = "label6";
        this.label6.Padding = new Padding(0, 5, 5, 0);
        this.label6.Size = new Size(167, 18);
        this.label6.TabIndex = 3;
        this.label6.Text = "Local System Generation Spread";
        this.label6.MouseEnter += this.chkParallelUniverse_MouseEnter;
        this.panel6.Controls.Add(this.txtProdTime);
        this.panel6.Controls.Add(this.label8);
        this.panel6.Location = new Point(3, 81);
        this.panel6.Margin = new Padding(3, 3, 3, 1);
        this.panel6.Name = "panel6";
        this.panel6.Size = new Size(281, 22);
        this.panel6.TabIndex = 13;
        this.txtProdTime.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtProdTime.BorderStyle = BorderStyle.None;
        this.txtProdTime.ForeColor = Color.FromArgb(128 /*0x80*/, 255, 128 /*0x80*/);
        this.txtProdTime.Location = new Point(197, 5);
        this.txtProdTime.Name = "txtProdTime";
        this.txtProdTime.Size = new Size(84, 13);
        this.txtProdTime.TabIndex = 9;
        this.txtProdTime.Text = "430000";
        this.txtProdTime.TextAlign = HorizontalAlignment.Center;
        this.txtProdTime.Enter += this.chkParallelUniverse_MouseEnter;
        this.txtProdTime.MouseEnter += this.chkParallelUniverse_MouseEnter;
        this.label8.AutoSize = true;
        this.label8.Dock = DockStyle.Left;
        this.label8.Location = new Point(0, 0);
        this.label8.Name = "label8";
        this.label8.Padding = new Padding(0, 5, 5, 0);
        this.label8.Size = new Size(126, 18);
        this.label8.TabIndex = 3;
        this.label8.Text = "Construction Cycle Time";
        this.label8.MouseEnter += this.chkParallelUniverse_MouseEnter;
        this.panel1.Controls.Add(this.txtDifficultyModifier);
        this.panel1.Controls.Add(this.label1);
        this.panel1.Location = new Point(3, 107);
        this.panel1.Margin = new Padding(3, 3, 3, 1);
        this.panel1.Name = "panel1";
        this.panel1.Size = new Size(281, 22);
        this.panel1.TabIndex = 12;
        this.panel1.Enter += this.chkParallelUniverse_MouseEnter;
        this.panel1.MouseEnter += this.chkParallelUniverse_MouseEnter;
        this.txtDifficultyModifier.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtDifficultyModifier.BorderStyle = BorderStyle.None;
        this.txtDifficultyModifier.ForeColor = Color.FromArgb(128 /*0x80*/, 255, 128 /*0x80*/);
        this.txtDifficultyModifier.Location = new Point(197, 5);
        this.txtDifficultyModifier.Name = "txtDifficultyModifier";
        this.txtDifficultyModifier.Size = new Size(84, 13);
        this.txtDifficultyModifier.TabIndex = 9;
        this.txtDifficultyModifier.Text = "100";
        this.txtDifficultyModifier.TextAlign = HorizontalAlignment.Center;
        this.txtDifficultyModifier.Enter += this.chkParallelUniverse_MouseEnter;
        this.txtDifficultyModifier.MouseEnter += this.chkParallelUniverse_MouseEnter;
        this.label1.AutoSize = true;
        this.label1.Dock = DockStyle.Left;
        this.label1.Location = new Point(0, 0);
        this.label1.Name = "label1";
        this.label1.Padding = new Padding(0, 5, 5, 0);
        this.label1.Size = new Size(167, 18);
        this.label1.TabIndex = 3;
        this.label1.Text = "Difficulty Modifier  (100 = Normal)";
        this.label1.MouseEnter += this.chkParallelUniverse_MouseEnter;
        this.panel20.Controls.Add(this.txtResearchSpeed);
        this.panel20.Controls.Add(this.label21);
        this.panel20.Location = new Point(3, 133);
        this.panel20.Margin = new Padding(3, 3, 3, 1);
        this.panel20.Name = "panel20";
        this.panel20.Size = new Size(281, 22);
        this.panel20.TabIndex = 31 /*0x1F*/;
        this.txtResearchSpeed.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtResearchSpeed.BorderStyle = BorderStyle.None;
        this.txtResearchSpeed.ForeColor = Color.FromArgb(128 /*0x80*/, 255, 128 /*0x80*/);
        this.txtResearchSpeed.Location = new Point(197, 5);
        this.txtResearchSpeed.Name = "txtResearchSpeed";
        this.txtResearchSpeed.Size = new Size(84, 13);
        this.txtResearchSpeed.TabIndex = 9;
        this.txtResearchSpeed.Text = "100";
        this.txtResearchSpeed.TextAlign = HorizontalAlignment.Center;
        this.txtResearchSpeed.Enter += this.chkParallelUniverse_MouseEnter;
        this.txtResearchSpeed.MouseEnter += this.chkParallelUniverse_MouseEnter;
        this.label21.AutoSize = true;
        this.label21.Dock = DockStyle.Left;
        this.label21.Location = new Point(0, 0);
        this.label21.Name = "label21";
        this.label21.Padding = new Padding(0, 5, 5, 0);
        this.label21.Size = new Size(167, 18);
        this.label21.TabIndex = 3;
        this.label21.Text = "Research Speed  (100 = Normal)";
        this.label21.MouseEnter += this.chkParallelUniverse_MouseEnter;
        this.panel21.Controls.Add(this.txtTerraformingSpeed);
        this.panel21.Controls.Add(this.label22);
        this.panel21.Location = new Point(3, 159);
        this.panel21.Margin = new Padding(3, 3, 3, 1);
        this.panel21.Name = "panel21";
        this.panel21.Size = new Size(281, 22);
        this.panel21.TabIndex = 137;
        this.txtTerraformingSpeed.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtTerraformingSpeed.BorderStyle = BorderStyle.None;
        this.txtTerraformingSpeed.ForeColor = Color.FromArgb(128 /*0x80*/, 255, 128 /*0x80*/);
        this.txtTerraformingSpeed.Location = new Point(197, 5);
        this.txtTerraformingSpeed.Name = "txtTerraformingSpeed";
        this.txtTerraformingSpeed.Size = new Size(84, 13);
        this.txtTerraformingSpeed.TabIndex = 9;
        this.txtTerraformingSpeed.Text = "100";
        this.txtTerraformingSpeed.TextAlign = HorizontalAlignment.Center;
        this.txtTerraformingSpeed.Enter += this.chkParallelUniverse_MouseEnter;
        this.txtTerraformingSpeed.MouseEnter += this.chkParallelUniverse_MouseEnter;
        this.label22.AutoSize = true;
        this.label22.Dock = DockStyle.Left;
        this.label22.Location = new Point(0, 0);
        this.label22.Name = "label22";
        this.label22.Padding = new Padding(0, 5, 5, 0);
        this.label22.Size = new Size(180, 18);
        this.label22.TabIndex = 3;
        this.label22.Text = "Terraforming Speed  (100 = Normal)";
        this.label22.MouseEnter += this.chkParallelUniverse_MouseEnter;
        this.panel24.Controls.Add(this.txtSurveySpeed);
        this.panel24.Controls.Add(this.label25);
        this.panel24.Location = new Point(3, 185);
        this.panel24.Margin = new Padding(3, 3, 3, 1);
        this.panel24.Name = "panel24";
        this.panel24.Size = new Size(281, 22);
        this.panel24.TabIndex = 138;
        this.txtSurveySpeed.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtSurveySpeed.BorderStyle = BorderStyle.None;
        this.txtSurveySpeed.ForeColor = Color.FromArgb(128 /*0x80*/, 255, 128 /*0x80*/);
        this.txtSurveySpeed.Location = new Point(197, 5);
        this.txtSurveySpeed.Name = "txtSurveySpeed";
        this.txtSurveySpeed.Size = new Size(84, 13);
        this.txtSurveySpeed.TabIndex = 9;
        this.txtSurveySpeed.Text = "100";
        this.txtSurveySpeed.TextAlign = HorizontalAlignment.Center;
        this.txtSurveySpeed.Enter += this.chkParallelUniverse_MouseEnter;
        this.txtSurveySpeed.MouseEnter += this.chkParallelUniverse_MouseEnter;
        this.label25.AutoSize = true;
        this.label25.Dock = DockStyle.Left;
        this.label25.Location = new Point(0, 0);
        this.label25.Name = "label25";
        this.label25.Padding = new Padding(0, 5, 5, 0);
        this.label25.Size = new Size(154, 18);
        this.label25.TabIndex = 3;
        this.label25.Text = "Survey Speed  (100 = Normal)";
        this.label25.MouseEnter += this.chkParallelUniverse_MouseEnter;
        this.panel9.Controls.Add(this.txtNewRuinCreationChance);
        this.panel9.Controls.Add(this.label11);
        this.panel9.Location = new Point(3, 211);
        this.panel9.Margin = new Padding(3, 3, 3, 1);
        this.panel9.Name = "panel9";
        this.panel9.Size = new Size(281, 22);
        this.panel9.TabIndex = 16 /*0x10*/;
        this.txtNewRuinCreationChance.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtNewRuinCreationChance.BorderStyle = BorderStyle.None;
        this.txtNewRuinCreationChance.ForeColor = Color.FromArgb(128 /*0x80*/, 255, 128 /*0x80*/);
        this.txtNewRuinCreationChance.Location = new Point(197, 5);
        this.txtNewRuinCreationChance.Name = "txtNewRuinCreationChance";
        this.txtNewRuinCreationChance.Size = new Size(84, 13);
        this.txtNewRuinCreationChance.TabIndex = 9;
        this.txtNewRuinCreationChance.Text = "20";
        this.txtNewRuinCreationChance.TextAlign = HorizontalAlignment.Center;
        this.txtNewRuinCreationChance.Enter += this.chkParallelUniverse_MouseEnter;
        this.txtNewRuinCreationChance.MouseEnter += this.chkParallelUniverse_MouseEnter;
        this.label11.AutoSize = true;
        this.label11.Dock = DockStyle.Left;
        this.label11.Location = new Point(0, 0);
        this.label11.Name = "label11";
        this.label11.Padding = new Padding(0, 5, 5, 0);
        this.label11.Size = new Size(129, 18);
        this.label11.TabIndex = 3;
        this.label11.Text = "Ruin Generation Chance";
        this.label11.MouseEnter += this.chkParallelUniverse_MouseEnter;
        this.panel10.Controls.Add(this.txtMinComets);
        this.panel10.Controls.Add(this.label12);
        this.panel10.Location = new Point(3, 237);
        this.panel10.Margin = new Padding(3, 3, 3, 1);
        this.panel10.Name = "panel10";
        this.panel10.Size = new Size(281, 22);
        this.panel10.TabIndex = 17;
        this.txtMinComets.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtMinComets.BorderStyle = BorderStyle.None;
        this.txtMinComets.ForeColor = Color.FromArgb(128 /*0x80*/, 255, 128 /*0x80*/);
        this.txtMinComets.Location = new Point(197, 5);
        this.txtMinComets.Name = "txtMinComets";
        this.txtMinComets.Size = new Size(84, 13);
        this.txtMinComets.TabIndex = 9;
        this.txtMinComets.Text = "0";
        this.txtMinComets.TextAlign = HorizontalAlignment.Center;
        this.txtMinComets.Enter += this.chkParallelUniverse_MouseEnter;
        this.txtMinComets.MouseEnter += this.chkParallelUniverse_MouseEnter;
        this.label12.AutoSize = true;
        this.label12.Dock = DockStyle.Left;
        this.label12.Location = new Point(0, 0);
        this.label12.Name = "label12";
        this.label12.Padding = new Padding(0, 5, 5, 0);
        this.label12.Size = new Size(146, 18);
        this.label12.TabIndex = 3;
        this.label12.Text = "Minimum Comets per System";
        this.label12.MouseEnter += this.chkParallelUniverse_MouseEnter;
        this.panel11.Controls.Add(this.txtTruceCountdown);
        this.panel11.Controls.Add(this.label13);
        this.panel11.Location = new Point(3, 263);
        this.panel11.Margin = new Padding(3, 3, 3, 1);
        this.panel11.Name = "panel11";
        this.panel11.Size = new Size(281, 22);
        this.panel11.TabIndex = 18;
        this.panel11.MouseEnter += this.chkParallelUniverse_MouseEnter;
        this.txtTruceCountdown.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtTruceCountdown.BorderStyle = BorderStyle.None;
        this.txtTruceCountdown.ForeColor = Color.FromArgb(128 /*0x80*/, 255, 128 /*0x80*/);
        this.txtTruceCountdown.Location = new Point(197, 5);
        this.txtTruceCountdown.Name = "txtTruceCountdown";
        this.txtTruceCountdown.Size = new Size(84, 13);
        this.txtTruceCountdown.TabIndex = 9;
        this.txtTruceCountdown.Text = "10";
        this.txtTruceCountdown.TextAlign = HorizontalAlignment.Center;
        this.txtTruceCountdown.Enter += this.chkParallelUniverse_MouseEnter;
        this.txtTruceCountdown.MouseEnter += this.chkParallelUniverse_MouseEnter;
        this.label13.AutoSize = true;
        this.label13.Dock = DockStyle.Left;
        this.label13.Location = new Point(0, 0);
        this.label13.Name = "label13";
        this.label13.Padding = new Padding(0, 5, 5, 0);
        this.label13.Size = new Size(97, 18);
        this.label13.TabIndex = 3;
        this.label13.Text = "Truce Countdown";
        this.panel13.Controls.Add(this.txtPassword);
        this.panel13.Controls.Add(this.label14);
        this.panel13.Location = new Point(3, 289);
        this.panel13.Margin = new Padding(3, 3, 3, 1);
        this.panel13.Name = "panel13";
        this.panel13.Size = new Size(281, 22);
        this.panel13.TabIndex = 25;
        this.txtPassword.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtPassword.BorderStyle = BorderStyle.None;
        this.txtPassword.ForeColor = Color.FromArgb(128 /*0x80*/, 255, 128 /*0x80*/);
        this.txtPassword.Location = new Point(197, 5);
        this.txtPassword.Name = "txtPassword";
        this.txtPassword.Size = new Size(84, 13);
        this.txtPassword.TabIndex = 9;
        this.txtPassword.TextAlign = HorizontalAlignment.Center;
        this.txtPassword.Enter += this.chkParallelUniverse_MouseEnter;
        this.txtPassword.MouseEnter += this.chkParallelUniverse_MouseEnter;
        this.label14.AutoSize = true;
        this.label14.Dock = DockStyle.Left;
        this.label14.Location = new Point(0, 0);
        this.label14.Name = "label14";
        this.label14.Padding = new Padding(0, 5, 5, 0);
        this.label14.Size = new Size(123, 18);
        this.label14.TabIndex = 3;
        this.label14.Text = "Spacemaster Password";
        this.label14.MouseEnter += this.chkParallelUniverse_MouseEnter;
        this.panel14.Controls.Add(this.txtConfirm);
        this.panel14.Controls.Add(this.label15);
        this.panel14.Location = new Point(3, 315);
        this.panel14.Margin = new Padding(3, 3, 3, 1);
        this.panel14.Name = "panel14";
        this.panel14.Size = new Size(281, 22);
        this.panel14.TabIndex = 26;
        this.txtConfirm.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtConfirm.BorderStyle = BorderStyle.None;
        this.txtConfirm.ForeColor = Color.FromArgb(128 /*0x80*/, 255, 128 /*0x80*/);
        this.txtConfirm.Location = new Point(197, 5);
        this.txtConfirm.Name = "txtConfirm";
        this.txtConfirm.Size = new Size(84, 13);
        this.txtConfirm.TabIndex = 9;
        this.txtConfirm.TextAlign = HorizontalAlignment.Center;
        this.label15.AutoSize = true;
        this.label15.Dock = DockStyle.Left;
        this.label15.Location = new Point(0, 0);
        this.label15.Name = "label15";
        this.label15.Padding = new Padding(0, 5, 5, 0);
        this.label15.Size = new Size(96 /*0x60*/, 18);
        this.label15.TabIndex = 3;
        this.label15.Text = "Confirm Password";
        this.panel12.Controls.Add(this.cboDetection);
        this.panel12.Controls.Add(this.label17);
        this.panel12.Location = new Point(3, 341);
        this.panel12.Name = "panel12";
        this.panel12.Size = new Size(281, 22);
        this.panel12.TabIndex = 28;
        this.cboDetection.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cboDetection.Dock = DockStyle.Right;
        this.cboDetection.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cboDetection.FormattingEnabled = true;
        this.cboDetection.Items.AddRange(new object[3]
        {
            "Normal in all systems",
            "None without player presence",
            "Automatic without player presence"
        });
        this.cboDetection.Location = new Point(74, 0);
        this.cboDetection.Name = "cboDetection";
        this.cboDetection.Size = new Size(207, 21);
        this.cboDetection.TabIndex = 15;
        this.cboDetection.SelectedIndexChanged += this.cboDetection_SelectedIndexChanged;
        this.cboDetection.Enter += this.chkParallelUniverse_MouseEnter;
        this.label17.AutoSize = true;
        this.label17.Dock = DockStyle.Left;
        this.label17.Location = new Point(0, 0);
        this.label17.Name = "label17";
        this.label17.Padding = new Padding(0, 5, 5, 0);
        this.label17.Size = new Size(58, 18);
        this.label17.TabIndex = 3;
        this.label17.Text = "Detection";
        this.panel19.Controls.Add(this.cboDisaster);
        this.panel19.Controls.Add(this.label18);
        this.panel19.Location = new Point(3, 369);
        this.panel19.Name = "panel19";
        this.panel19.Size = new Size(281, 22);
        this.panel19.TabIndex = 30;
        this.cboDisaster.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cboDisaster.Dock = DockStyle.Right;
        this.cboDisaster.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cboDisaster.FormattingEnabled = true;
        this.cboDisaster.Items.AddRange(new object[10]
        {
            "No Disaster",
            "Sol Warming 1% Year",
            "Sol Warming 2% Year",
            "Sol Warming 3% Year",
            "Sol Cooling 1% Year",
            "Sol Cooling 2% Year",
            "Sol Cooling 3% Year",
            "Earth Death Spiral 0.01 AU",
            "Earth Death Spiral 0.02 AU",
            "Earth Death Spiral 0.03 AU"
        });
        this.cboDisaster.Location = new Point(74, 0);
        this.cboDisaster.Name = "cboDisaster";
        this.cboDisaster.Size = new Size(207, 21);
        this.cboDisaster.TabIndex = 15;
        this.cboDisaster.SelectedIndexChanged += this.cboDisaster_SelectedIndexChanged;
        this.cboDisaster.Enter += this.chkParallelUniverse_MouseEnter;
        this.label18.AutoSize = true;
        this.label18.Dock = DockStyle.Left;
        this.label18.Location = new Point(0, 0);
        this.label18.Name = "label18";
        this.label18.Padding = new Padding(0, 5, 5, 0);
        this.label18.Size = new Size(68, 18);
        this.label18.TabIndex = 3;
        this.label18.Text = "Sol Disaster";
        this.panel7.Controls.Add(this.txtRaceChance);
        this.panel7.Controls.Add(this.label9);
        this.panel7.Location = new Point(3, 3);
        this.panel7.Margin = new Padding(3, 3, 3, 1);
        this.panel7.Name = "panel7";
        this.panel7.Size = new Size(281, 22);
        this.panel7.TabIndex = 14;
        this.txtRaceChance.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtRaceChance.BorderStyle = BorderStyle.None;
        this.txtRaceChance.ForeColor = Color.FromArgb(128 /*0x80*/, 255, 128 /*0x80*/);
        this.txtRaceChance.Location = new Point(197, 5);
        this.txtRaceChance.Name = "txtRaceChance";
        this.txtRaceChance.Size = new Size(84, 13);
        this.txtRaceChance.TabIndex = 9;
        this.txtRaceChance.Text = "30";
        this.txtRaceChance.TextAlign = HorizontalAlignment.Center;
        this.txtRaceChance.Enter += this.chkParallelUniverse_MouseEnter;
        this.txtRaceChance.MouseEnter += this.chkParallelUniverse_MouseEnter;
        this.label9.AutoSize = true;
        this.label9.Dock = DockStyle.Left;
        this.label9.Location = new Point(0, 0);
        this.label9.Name = "label9";
        this.label9.Padding = new Padding(0, 5, 5, 0);
        this.label9.Size = new Size(182, 18);
        this.label9.TabIndex = 3;
        this.label9.Text = "NPR Generation Chance (by Player)";
        this.label9.MouseEnter += this.chkParallelUniverse_MouseEnter;
        this.panel8.Controls.Add(this.txtRaceChanceNPR);
        this.panel8.Controls.Add(this.label10);
        this.panel8.Location = new Point(3, 29);
        this.panel8.Margin = new Padding(3, 3, 3, 1);
        this.panel8.Name = "panel8";
        this.panel8.Size = new Size(281, 22);
        this.panel8.TabIndex = 15;
        this.txtRaceChanceNPR.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtRaceChanceNPR.BorderStyle = BorderStyle.None;
        this.txtRaceChanceNPR.ForeColor = Color.FromArgb(128 /*0x80*/, 255, 128 /*0x80*/);
        this.txtRaceChanceNPR.Location = new Point(197, 5);
        this.txtRaceChanceNPR.Name = "txtRaceChanceNPR";
        this.txtRaceChanceNPR.Size = new Size(84, 13);
        this.txtRaceChanceNPR.TabIndex = 9;
        this.txtRaceChanceNPR.Text = "10";
        this.txtRaceChanceNPR.TextAlign = HorizontalAlignment.Center;
        this.txtRaceChanceNPR.Enter += this.chkParallelUniverse_MouseEnter;
        this.txtRaceChanceNPR.MouseEnter += this.chkParallelUniverse_MouseEnter;
        this.label10.AutoSize = true;
        this.label10.Dock = DockStyle.Left;
        this.label10.Location = new Point(0, 0);
        this.label10.Name = "label10";
        this.label10.Padding = new Padding(0, 5, 5, 0);
        this.label10.Size = new Size(176 /*0xB0*/, 18);
        this.label10.TabIndex = 3;
        this.label10.Text = "NPR Generation Chance (by NPR)";
        this.label10.MouseEnter += this.chkParallelUniverse_MouseEnter;
        this.panel29.Controls.Add(this.txtMinorRaces);
        this.panel29.Controls.Add(this.label23);
        this.panel29.Location = new Point(3, 191);
        this.panel29.Margin = new Padding(3, 3, 3, 1);
        this.panel29.Name = "panel29";
        this.panel29.Size = new Size(281, 22);
        this.panel29.TabIndex = 140;
        this.txtMinorRaces.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtMinorRaces.BorderStyle = BorderStyle.None;
        this.txtMinorRaces.ForeColor = Color.FromArgb(128 /*0x80*/, 255, 128 /*0x80*/);
        this.txtMinorRaces.Location = new Point(197, 5);
        this.txtMinorRaces.Name = "txtMinorRaces";
        this.txtMinorRaces.Size = new Size(84, 13);
        this.txtMinorRaces.TabIndex = 9;
        this.txtMinorRaces.Text = "20";
        this.txtMinorRaces.TextAlign = HorizontalAlignment.Center;
        this.txtMinorRaces.EnabledChanged += this.chkParallelUniverse_MouseEnter;
        this.txtMinorRaces.TextChanged += this.txtMinorRaces_TextChanged;
        this.txtMinorRaces.MouseEnter += this.chkParallelUniverse_MouseEnter;
        this.label23.AutoSize = true;
        this.label23.Dock = DockStyle.Left;
        this.label23.Location = new Point(0, 0);
        this.label23.Name = "label23";
        this.label23.Padding = new Padding(0, 5, 5, 0);
        this.label23.Size = new Size(159, 18);
        this.label23.TabIndex = 3;
        this.label23.Text = "Minor Trans-Newtonian NPR %";
        this.label23.MouseEnter += this.chkParallelUniverse_MouseEnter;
        this.panel28.Controls.Add(this.txtHostilityModifier);
        this.panel28.Controls.Add(this.lblHostilityModifier);
        this.panel28.Location = new Point(3, 217);
        this.panel28.Margin = new Padding(3, 3, 3, 1);
        this.panel28.Name = "panel28";
        this.panel28.Size = new Size(281, 22);
        this.panel28.TabIndex = 139;
        this.txtHostilityModifier.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtHostilityModifier.BorderStyle = BorderStyle.None;
        this.txtHostilityModifier.ForeColor = Color.FromArgb(128 /*0x80*/, 255, 128 /*0x80*/);
        this.txtHostilityModifier.Location = new Point(197, 5);
        this.txtHostilityModifier.Name = "txtHostilityModifier";
        this.txtHostilityModifier.Size = new Size(84, 13);
        this.txtHostilityModifier.TabIndex = 9;
        this.txtHostilityModifier.Text = "0";
        this.txtHostilityModifier.TextAlign = HorizontalAlignment.Center;
        this.txtHostilityModifier.MouseEnter += this.chkParallelUniverse_MouseEnter;
        this.lblHostilityModifier.AutoSize = true;
        this.lblHostilityModifier.Dock = DockStyle.Left;
        this.lblHostilityModifier.Location = new Point(0, 0);
        this.lblHostilityModifier.Name = "lblHostilityModifier";
        this.lblHostilityModifier.Padding = new Padding(0, 5, 5, 0);
        this.lblHostilityModifier.Size = new Size(88, 18);
        this.lblHostilityModifier.TabIndex = 3;
        this.lblHostilityModifier.Text = "Hostility Modifier";
        this.lblHostilityModifier.MouseEnter += this.chkParallelUniverse_MouseEnter;
        this.panel15.Controls.Add(this.txtYear);
        this.panel15.Controls.Add(this.label16);
        this.panel15.Location = new Point(3, 3);
        this.panel15.Name = "panel15";
        this.panel15.Size = new Size(281, 22);
        this.panel15.TabIndex = 22;
        this.txtYear.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtYear.BorderStyle = BorderStyle.None;
        this.txtYear.ForeColor = Color.FromArgb(128 /*0x80*/, 255, 128 /*0x80*/);
        this.txtYear.Location = new Point(197, 5);
        this.txtYear.Name = "txtYear";
        this.txtYear.ReadOnly = true;
        this.txtYear.Size = new Size(84, 13);
        this.txtYear.TabIndex = 9;
        this.txtYear.Text = "2050";
        this.txtYear.TextAlign = HorizontalAlignment.Center;
        this.txtYear.Enter += this.chkParallelUniverse_MouseEnter;
        this.txtYear.Leave += this.txtYear_Leave;
        this.txtYear.MouseEnter += this.chkParallelUniverse_MouseEnter;
        this.label16.AutoSize = true;
        this.label16.Dock = DockStyle.Left;
        this.label16.Location = new Point(0, 0);
        this.label16.Name = "label16";
        this.label16.Padding = new Padding(0, 5, 5, 0);
        this.label16.Size = new Size(73, 18);
        this.label16.TabIndex = 3;
        this.label16.Text = "Starting Year";
        this.flowLayoutPanel1.BorderStyle = BorderStyle.FixedSingle;
        this.flowLayoutPanel1.Controls.Add(this.chkUseKnownStars);
        this.flowLayoutPanel1.Controls.Add(this.chkConstellationNames);
        this.flowLayoutPanel1.Controls.Add(this.chkOrb);
        this.flowLayoutPanel1.Controls.Add(this.chkOrbAst);
        this.flowLayoutPanel1.Controls.Add(this.chkGenerateNPRs);
        this.flowLayoutPanel1.Controls.Add(this.chkHumanNPRs);
        this.flowLayoutPanel1.Controls.Add(this.chkGenerateNonTNOnly);
        this.flowLayoutPanel1.Controls.Add(this.chkPrecursors);
        this.flowLayoutPanel1.Controls.Add(this.chkStarSwarm);
        this.flowLayoutPanel1.Controls.Add(this.chkInvaders);
        this.flowLayoutPanel1.Controls.Add(this.chkEnhancedPrecursors);
        this.flowLayoutPanel1.Controls.Add(this.chkEnhancedSwarm);
        this.flowLayoutPanel1.Controls.Add(this.chkEnhancedInvaders);
        this.flowLayoutPanel1.Controls.Add(this.chkRakhas);
        this.flowLayoutPanel1.Controls.Add(this.chkEldar);
        this.flowLayoutPanel1.Controls.Add(this.chkNPRsGeneratePrecursors);
        this.flowLayoutPanel1.Controls.Add(this.chkNPRsGenerateSwarm);
        this.flowLayoutPanel1.Controls.Add(this.chkNPRsGenerateRifts);
        this.flowLayoutPanel1.Controls.Add(this.chkNPRsEncounterRaiders);
        this.flowLayoutPanel1.Controls.Add(this.chkRealisticPromotions);
        this.flowLayoutPanel1.Controls.Add(this.chkLimitedLabs);
        this.flowLayoutPanel1.Controls.Add(this.chkInexpFleets);
        this.flowLayoutPanel1.Controls.Add(this.chkPoliticalAdmirals);
        this.flowLayoutPanel1.Controls.Add(this.chkAutoJumpGates);
        this.flowLayoutPanel1.Controls.Add(this.chkNoOverhauls);
        this.flowLayoutPanel1.Controls.Add(this.chkCivilianShippingLinesActive);
        this.flowLayoutPanel1.Controls.Add(this.chkAllowCivilianHarvesters);
        this.flowLayoutPanel1.Controls.Add(this.chkConquerTech);
        this.flowLayoutPanel1.Controls.Add(this.chkStarEccentricity);
        this.flowLayoutPanel1.Controls.Add(this.chkGasGiantEffects);
        this.flowLayoutPanel1.Controls.Add(this.chkOneSecondSubPulse);
        this.flowLayoutPanel1.Controls.Add(this.chkLimitPlanetaryDistance);
        this.flowLayoutPanel1.Controls.Add(this.chkUseThemeInKnownStars);
        this.flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
        this.flowLayoutPanel1.Location = new Point(602, 3);
        this.flowLayoutPanel1.Name = "flowLayoutPanel1";
        this.flowLayoutPanel1.Size = new Size(393, 470);
        this.flowLayoutPanel1.TabIndex = 12;
        this.chkUseKnownStars.AutoSize = true;
        this.chkUseKnownStars.Location = new Point(3, 3);
        this.chkUseKnownStars.Name = "chkUseKnownStars";
        this.chkUseKnownStars.Padding = new Padding(5, 0, 0, 0);
        this.chkUseKnownStars.Size = new Size(128 /*0x80*/, 17);
        this.chkUseKnownStars.TabIndex = 0;
        this.chkUseKnownStars.Text = "Known Star Systems";
        this.chkUseKnownStars.TextAlign = ContentAlignment.MiddleRight;
        this.chkUseKnownStars.UseVisualStyleBackColor = true;
        this.chkUseKnownStars.CheckedChanged += this.chkParallelUniverse_MouseEnter;
        this.chkUseKnownStars.MouseEnter += this.chkParallelUniverse_MouseEnter;
        this.chkConstellationNames.AutoSize = true;
        this.chkConstellationNames.Location = new Point(3, 26);
        this.chkConstellationNames.Name = "chkConstellationNames";
        this.chkConstellationNames.Padding = new Padding(5, 0, 0, 0);
        this.chkConstellationNames.Size = new Size(149, 17);
        this.chkConstellationNames.TabIndex = 25;
        this.chkConstellationNames.Text = "Use Constellation Names";
        this.chkConstellationNames.TextAlign = ContentAlignment.MiddleRight;
        this.chkConstellationNames.UseVisualStyleBackColor = true;
        this.chkConstellationNames.CheckedChanged += this.chkParallelUniverse_MouseEnter;
        this.chkConstellationNames.MouseEnter += this.chkParallelUniverse_MouseEnter;
        this.chkOrb.AutoSize = true;
        this.chkOrb.Location = new Point(3, 49);
        this.chkOrb.Name = "chkOrb";
        this.chkOrb.Padding = new Padding(5, 0, 0, 0);
        this.chkOrb.Size = new Size(192 /*0xC0*/, 17);
        this.chkOrb.TabIndex = 1;
        this.chkOrb.Text = "Orbital Motion for Planets / Moons";
        this.chkOrb.TextAlign = ContentAlignment.MiddleRight;
        this.chkOrb.UseVisualStyleBackColor = true;
        this.chkOrb.CheckedChanged += this.chkParallelUniverse_MouseEnter;
        this.chkOrb.MouseEnter += this.chkParallelUniverse_MouseEnter;
        this.chkOrbAst.AutoSize = true;
        this.chkOrbAst.Location = new Point(3, 72);
        this.chkOrbAst.Name = "chkOrbAst";
        this.chkOrbAst.Padding = new Padding(5, 0, 0, 0);
        this.chkOrbAst.Size = new Size(157, 17);
        this.chkOrbAst.TabIndex = 2;
        this.chkOrbAst.Text = "Orbital Motion for Asteroids";
        this.chkOrbAst.TextAlign = ContentAlignment.MiddleRight;
        this.chkOrbAst.UseVisualStyleBackColor = true;
        this.chkOrbAst.CheckedChanged += this.chkParallelUniverse_MouseEnter;
        this.chkOrbAst.MouseEnter += this.chkParallelUniverse_MouseEnter;
        this.chkGenerateNPRs.AutoSize = true;
        this.chkGenerateNPRs.Location = new Point(3, 95);
        this.chkGenerateNPRs.Name = "chkGenerateNPRs";
        this.chkGenerateNPRs.Padding = new Padding(5, 0, 0, 0);
        this.chkGenerateNPRs.Size = new Size(179, 17);
        this.chkGenerateNPRs.TabIndex = 5;
        this.chkGenerateNPRs.Text = "Generate New Races as NPRs";
        this.chkGenerateNPRs.TextAlign = ContentAlignment.MiddleRight;
        this.chkGenerateNPRs.UseVisualStyleBackColor = true;
        this.chkGenerateNPRs.CheckedChanged += this.chkParallelUniverse_MouseEnter;
        this.chkGenerateNPRs.MouseEnter += this.chkParallelUniverse_MouseEnter;
        this.chkHumanNPRs.AutoSize = true;
        this.chkHumanNPRs.Location = new Point(3, 118);
        this.chkHumanNPRs.Name = "chkHumanNPRs";
        this.chkHumanNPRs.Padding = new Padding(5, 0, 0, 0);
        this.chkHumanNPRs.Size = new Size(124, 17);
        this.chkHumanNPRs.TabIndex = 24;
        this.chkHumanNPRs.Text = "Allow Human NPRs";
        this.chkHumanNPRs.TextAlign = ContentAlignment.MiddleRight;
        this.chkHumanNPRs.UseVisualStyleBackColor = true;
        this.chkHumanNPRs.CheckedChanged += this.chkParallelUniverse_MouseEnter;
        this.chkHumanNPRs.MouseEnter += this.chkParallelUniverse_MouseEnter;
        this.chkGenerateNonTNOnly.AutoSize = true;
        this.chkGenerateNonTNOnly.Location = new Point(3, 141);
        this.chkGenerateNonTNOnly.Name = "chkGenerateNonTNOnly";
        this.chkGenerateNonTNOnly.Padding = new Padding(5, 0, 0, 0);
        this.chkGenerateNonTNOnly.Size = new Size(189, 17);
        this.chkGenerateNonTNOnly.TabIndex = 19;
        this.chkGenerateNonTNOnly.Text = "Generate Pre-industrial races only";
        this.chkGenerateNonTNOnly.TextAlign = ContentAlignment.MiddleRight;
        this.chkGenerateNonTNOnly.UseVisualStyleBackColor = true;
        this.chkGenerateNonTNOnly.CheckedChanged += this.chkParallelUniverse_MouseEnter;
        this.chkGenerateNonTNOnly.MouseEnter += this.chkParallelUniverse_MouseEnter;
        this.chkPrecursors.AutoSize = true;
        this.chkPrecursors.Location = new Point(3, 164);
        this.chkPrecursors.Name = "chkPrecursors";
        this.chkPrecursors.Padding = new Padding(5, 0, 0, 0);
        this.chkPrecursors.Size = new Size(128 /*0x80*/, 17);
        this.chkPrecursors.TabIndex = 6;
        this.chkPrecursors.Text = "Generate Precursors";
        this.chkPrecursors.TextAlign = ContentAlignment.MiddleRight;
        this.chkPrecursors.UseVisualStyleBackColor = true;
        this.chkPrecursors.CheckedChanged += this.chkParallelUniverse_MouseEnter;
        this.chkPrecursors.MouseEnter += this.chkParallelUniverse_MouseEnter;
        this.chkStarSwarm.AutoSize = true;
        this.chkStarSwarm.Location = new Point(3, 187);
        this.chkStarSwarm.Name = "chkStarSwarm";
        this.chkStarSwarm.Padding = new Padding(5, 0, 0, 0);
        this.chkStarSwarm.Size = new Size(132, 17);
        this.chkStarSwarm.TabIndex = 14;
        this.chkStarSwarm.Text = "Generate Star Swarm";
        this.chkStarSwarm.TextAlign = ContentAlignment.MiddleRight;
        this.chkStarSwarm.UseVisualStyleBackColor = true;
        this.chkStarSwarm.CheckedChanged += this.chkParallelUniverse_MouseEnter;
        this.chkStarSwarm.MouseEnter += this.chkParallelUniverse_MouseEnter;
        this.chkInvaders.AutoSize = true;
        this.chkInvaders.Location = new Point(3, 210);
        this.chkInvaders.Name = "chkInvaders";
        this.chkInvaders.Padding = new Padding(5, 0, 0, 0);
        this.chkInvaders.Size = new Size(119, 17);
        this.chkInvaders.TabIndex = 7;
        this.chkInvaders.Text = "Generate Invaders";
        this.chkInvaders.TextAlign = ContentAlignment.MiddleRight;
        this.chkInvaders.UseVisualStyleBackColor = true;
        this.chkInvaders.CheckedChanged += this.chkParallelUniverse_MouseEnter;
        this.chkInvaders.MouseEnter += this.chkParallelUniverse_MouseEnter;
        this.chkEnhancedPrecursors.AutoSize = true;
        this.chkEnhancedPrecursors.Location = new Point(3, 233);
        this.chkEnhancedPrecursors.Name = "chkEnhancedPrecursors";
        this.chkEnhancedPrecursors.Padding = new Padding(5, 0, 0, 0);
        this.chkEnhancedPrecursors.Size = new Size(133, 17);
        this.chkEnhancedPrecursors.TabIndex = 36;
        this.chkEnhancedPrecursors.Text = "Enhanced Precursors";
        this.chkEnhancedPrecursors.TextAlign = ContentAlignment.MiddleRight;
        this.chkEnhancedPrecursors.UseVisualStyleBackColor = true;
        this.chkEnhancedSwarm.AutoSize = true;
        this.chkEnhancedSwarm.Location = new Point(3, 256 /*0x0100*/);
        this.chkEnhancedSwarm.Name = "chkEnhancedSwarm";
        this.chkEnhancedSwarm.Padding = new Padding(5, 0, 0, 0);
        this.chkEnhancedSwarm.Size = new Size(115, 17);
        this.chkEnhancedSwarm.TabIndex = 38;
        this.chkEnhancedSwarm.Text = "Enhanced Swarm";
        this.chkEnhancedSwarm.TextAlign = ContentAlignment.MiddleRight;
        this.chkEnhancedSwarm.UseVisualStyleBackColor = true;
        this.chkEnhancedInvaders.AutoSize = true;
        this.chkEnhancedInvaders.Location = new Point(3, 279);
        this.chkEnhancedInvaders.Name = "chkEnhancedInvaders";
        this.chkEnhancedInvaders.Padding = new Padding(5, 0, 0, 0);
        this.chkEnhancedInvaders.Size = new Size(124, 17);
        this.chkEnhancedInvaders.TabIndex = 37;
        this.chkEnhancedInvaders.Text = "Enhanced Invaders";
        this.chkEnhancedInvaders.TextAlign = ContentAlignment.MiddleRight;
        this.chkEnhancedInvaders.UseVisualStyleBackColor = true;
        this.chkRakhas.AutoSize = true;
        this.chkRakhas.Location = new Point(3, 302);
        this.chkRakhas.Name = "chkRakhas";
        this.chkRakhas.Padding = new Padding(5, 0, 0, 0);
        this.chkRakhas.Size = new Size(115, 17);
        this.chkRakhas.TabIndex = 23;
        this.chkRakhas.Text = "Generate Rakhas";
        this.chkRakhas.TextAlign = ContentAlignment.MiddleRight;
        this.chkRakhas.UseVisualStyleBackColor = true;
        this.chkRakhas.CheckedChanged += this.chkParallelUniverse_MouseEnter;
        this.chkRakhas.MouseEnter += this.chkParallelUniverse_MouseEnter;
        this.chkEldar.AutoSize = true;
        this.chkEldar.Location = new Point(3, 325);
        this.chkEldar.Name = "chkEldar";
        this.chkEldar.Padding = new Padding(5, 0, 0, 0);
        this.chkEldar.Size = new Size(148, 17);
        this.chkEldar.TabIndex = 28;
        this.chkEldar.Text = "Generate Aether Raiders";
        this.chkEldar.TextAlign = ContentAlignment.MiddleRight;
        this.chkEldar.UseVisualStyleBackColor = true;
        this.chkEldar.MouseEnter += this.chkParallelUniverse_MouseEnter;
        this.chkNPRsGeneratePrecursors.AutoSize = true;
        this.chkNPRsGeneratePrecursors.Location = new Point(3, 348);
        this.chkNPRsGeneratePrecursors.Name = "chkNPRsGeneratePrecursors";
        this.chkNPRsGeneratePrecursors.Padding = new Padding(5, 0, 0, 0);
        this.chkNPRsGeneratePrecursors.Size = new Size(159, 17);
        this.chkNPRsGeneratePrecursors.TabIndex = 18;
        this.chkNPRsGeneratePrecursors.Text = "NPRs Generate Precursors";
        this.chkNPRsGeneratePrecursors.TextAlign = ContentAlignment.MiddleRight;
        this.chkNPRsGeneratePrecursors.UseVisualStyleBackColor = true;
        this.chkNPRsGeneratePrecursors.CheckedChanged += this.chkParallelUniverse_MouseEnter;
        this.chkNPRsGeneratePrecursors.MouseEnter += this.chkParallelUniverse_MouseEnter;
        this.chkNPRsGenerateSwarm.AutoSize = true;
        this.chkNPRsGenerateSwarm.Location = new Point(3, 371);
        this.chkNPRsGenerateSwarm.Name = "chkNPRsGenerateSwarm";
        this.chkNPRsGenerateSwarm.Padding = new Padding(5, 0, 0, 0);
        this.chkNPRsGenerateSwarm.Size = new Size(163, 17);
        this.chkNPRsGenerateSwarm.TabIndex = 26;
        this.chkNPRsGenerateSwarm.Text = "NPRs Generate Star Swarm";
        this.chkNPRsGenerateSwarm.TextAlign = ContentAlignment.MiddleRight;
        this.chkNPRsGenerateSwarm.UseVisualStyleBackColor = true;
        this.chkNPRsGenerateSwarm.CheckedChanged += this.chkParallelUniverse_MouseEnter;
        this.chkNPRsGenerateSwarm.MouseEnter += this.chkParallelUniverse_MouseEnter;
        this.chkNPRsGenerateRifts.AutoSize = true;
        this.chkNPRsGenerateRifts.Location = new Point(3, 394);
        this.chkNPRsGenerateRifts.Name = "chkNPRsGenerateRifts";
        this.chkNPRsGenerateRifts.Padding = new Padding(5, 0, 0, 0);
        this.chkNPRsGenerateRifts.Size = new Size(164, 17);
        this.chkNPRsGenerateRifts.TabIndex = 27;
        this.chkNPRsGenerateRifts.Text = "NPRs Generate Aether Rifts";
        this.chkNPRsGenerateRifts.TextAlign = ContentAlignment.MiddleRight;
        this.chkNPRsGenerateRifts.UseVisualStyleBackColor = true;
        this.chkNPRsGenerateRifts.CheckedChanged += this.chkParallelUniverse_MouseEnter;
        this.chkNPRsGenerateRifts.MouseEnter += this.chkParallelUniverse_MouseEnter;
        this.chkNPRsEncounterRaiders.AutoSize = true;
        this.chkNPRsEncounterRaiders.Location = new Point(3, 417);
        this.chkNPRsEncounterRaiders.Name = "chkNPRsEncounterRaiders";
        this.chkNPRsEncounterRaiders.Padding = new Padding(5, 0, 0, 0);
        this.chkNPRsEncounterRaiders.Size = new Size(150, 17);
        this.chkNPRsEncounterRaiders.TabIndex = 29;
        this.chkNPRsEncounterRaiders.Text = "NPRs Encounter Raiders";
        this.chkNPRsEncounterRaiders.TextAlign = ContentAlignment.MiddleRight;
        this.chkNPRsEncounterRaiders.UseVisualStyleBackColor = true;
        this.chkNPRsEncounterRaiders.MouseEnter += this.chkParallelUniverse_MouseEnter;
        this.chkRealisticPromotions.AutoSize = true;
        this.chkRealisticPromotions.Location = new Point(3, 440);
        this.chkRealisticPromotions.Name = "chkRealisticPromotions";
        this.chkRealisticPromotions.Padding = new Padding(5, 0, 0, 0);
        this.chkRealisticPromotions.Size = new Size(185, 17);
        this.chkRealisticPromotions.TabIndex = 3;
        this.chkRealisticPromotions.Text = "Realistic Commander Promotions";
        this.chkRealisticPromotions.TextAlign = ContentAlignment.MiddleRight;
        this.chkRealisticPromotions.UseVisualStyleBackColor = true;
        this.chkRealisticPromotions.CheckedChanged += this.chkParallelUniverse_MouseEnter;
        this.chkRealisticPromotions.MouseEnter += this.chkParallelUniverse_MouseEnter;
        this.chkLimitedLabs.AutoSize = true;
        this.chkLimitedLabs.Location = new Point(201, 3);
        this.chkLimitedLabs.Name = "chkLimitedLabs";
        this.chkLimitedLabs.Padding = new Padding(5, 0, 0, 0);
        this.chkLimitedLabs.Size = new Size(181, 17);
        this.chkLimitedLabs.TabIndex = 32 /*0x20*/;
        this.chkLimitedLabs.Text = "Limited Research Administration";
        this.chkLimitedLabs.TextAlign = ContentAlignment.MiddleRight;
        this.chkLimitedLabs.UseVisualStyleBackColor = true;
        this.chkLimitedLabs.CheckedChanged += this.chkParallelUniverse_MouseEnter;
        this.chkLimitedLabs.MouseEnter += this.chkParallelUniverse_MouseEnter;
        this.chkInexpFleets.AutoSize = true;
        this.chkInexpFleets.Location = new Point(201, 26);
        this.chkInexpFleets.Name = "chkInexpFleets";
        this.chkInexpFleets.Padding = new Padding(5, 0, 0, 0);
        this.chkInexpFleets.Size = new Size(170, 17);
        this.chkInexpFleets.TabIndex = 16 /*0x10*/;
        this.chkInexpFleets.Text = "Inexperienced Fleet Penalties";
        this.chkInexpFleets.TextAlign = ContentAlignment.MiddleRight;
        this.chkInexpFleets.UseVisualStyleBackColor = true;
        this.chkInexpFleets.CheckedChanged += this.chkParallelUniverse_MouseEnter;
        this.chkInexpFleets.MouseEnter += this.chkParallelUniverse_MouseEnter;
        this.chkPoliticalAdmirals.AutoSize = true;
        this.chkPoliticalAdmirals.Location = new Point(201, 49);
        this.chkPoliticalAdmirals.Name = "chkPoliticalAdmirals";
        this.chkPoliticalAdmirals.Padding = new Padding(5, 0, 0, 0);
        this.chkPoliticalAdmirals.Size = new Size(170, 17);
        this.chkPoliticalAdmirals.TabIndex = 15;
        this.chkPoliticalAdmirals.Text = "Commander Political Bonuses";
        this.chkPoliticalAdmirals.TextAlign = ContentAlignment.MiddleRight;
        this.chkPoliticalAdmirals.UseVisualStyleBackColor = true;
        this.chkPoliticalAdmirals.CheckedChanged += this.chkParallelUniverse_MouseEnter;
        this.chkPoliticalAdmirals.MouseEnter += this.chkParallelUniverse_MouseEnter;
        this.chkAutoJumpGates.AutoSize = true;
        this.chkAutoJumpGates.Location = new Point(201, 72);
        this.chkAutoJumpGates.Name = "chkAutoJumpGates";
        this.chkAutoJumpGates.Padding = new Padding(5, 0, 0, 0);
        this.chkAutoJumpGates.Size = new Size(153, 17);
        this.chkAutoJumpGates.TabIndex = 13;
        this.chkAutoJumpGates.Text = "All Jump Points are Stable";
        this.chkAutoJumpGates.TextAlign = ContentAlignment.MiddleRight;
        this.chkAutoJumpGates.UseVisualStyleBackColor = true;
        this.chkAutoJumpGates.CheckedChanged += this.chkParallelUniverse_MouseEnter;
        this.chkAutoJumpGates.MouseEnter += this.chkParallelUniverse_MouseEnter;
        this.chkNoOverhauls.AutoSize = true;
        this.chkNoOverhauls.Location = new Point(201, 95);
        this.chkNoOverhauls.Name = "chkNoOverhauls";
        this.chkNoOverhauls.Padding = new Padding(5, 0, 0, 0);
        this.chkNoOverhauls.Size = new Size(156, 17);
        this.chkNoOverhauls.TabIndex = 17;
        this.chkNoOverhauls.Text = "No Maintenance Required";
        this.chkNoOverhauls.TextAlign = ContentAlignment.MiddleRight;
        this.chkNoOverhauls.UseVisualStyleBackColor = true;
        this.chkNoOverhauls.CheckedChanged += this.chkParallelUniverse_MouseEnter;
        this.chkNoOverhauls.MouseEnter += this.chkParallelUniverse_MouseEnter;
        this.chkCivilianShippingLinesActive.AutoSize = true;
        this.chkCivilianShippingLinesActive.Location = new Point(201, 118);
        this.chkCivilianShippingLinesActive.Name = "chkCivilianShippingLinesActive";
        this.chkCivilianShippingLinesActive.Padding = new Padding(5, 0, 0, 0);
        this.chkCivilianShippingLinesActive.Size = new Size(169, 17);
        this.chkCivilianShippingLinesActive.TabIndex = 20;
        this.chkCivilianShippingLinesActive.Text = "Civilian Shipping Lines Active";
        this.chkCivilianShippingLinesActive.TextAlign = ContentAlignment.MiddleRight;
        this.chkCivilianShippingLinesActive.UseVisualStyleBackColor = true;
        this.chkCivilianShippingLinesActive.CheckedChanged += this.chkParallelUniverse_MouseEnter;
        this.chkCivilianShippingLinesActive.MouseEnter += this.chkParallelUniverse_MouseEnter;
        this.chkAllowCivilianHarvesters.AutoSize = true;
        this.chkAllowCivilianHarvesters.Location = new Point(201, 141);
        this.chkAllowCivilianHarvesters.Name = "chkAllowCivilianHarvesters";
        this.chkAllowCivilianHarvesters.Padding = new Padding(5, 0, 0, 0);
        this.chkAllowCivilianHarvesters.Size = new Size(146, 17);
        this.chkAllowCivilianHarvesters.TabIndex = 22;
        this.chkAllowCivilianHarvesters.Text = "Allow Civilian Harvesters";
        this.chkAllowCivilianHarvesters.TextAlign = ContentAlignment.MiddleRight;
        this.chkAllowCivilianHarvesters.UseVisualStyleBackColor = true;
        this.chkAllowCivilianHarvesters.CheckedChanged += this.chkParallelUniverse_MouseEnter;
        this.chkAllowCivilianHarvesters.MouseEnter += this.chkParallelUniverse_MouseEnter;
        this.chkConquerTech.AutoSize = true;
        this.chkConquerTech.Location = new Point(201, 164);
        this.chkConquerTech.Name = "chkConquerTech";
        this.chkConquerTech.Padding = new Padding(5, 0, 0, 0);
        this.chkConquerTech.Size = new Size(152, 17);
        this.chkConquerTech.TabIndex = 21;
        this.chkConquerTech.Text = "New Tech from Conquest";
        this.chkConquerTech.TextAlign = ContentAlignment.MiddleRight;
        this.chkConquerTech.UseVisualStyleBackColor = true;
        this.chkConquerTech.CheckedChanged += this.chkParallelUniverse_MouseEnter;
        this.chkConquerTech.MouseEnter += this.chkParallelUniverse_MouseEnter;
        this.chkStarEccentricity.AutoSize = true;
        this.chkStarEccentricity.Location = new Point(201, 187);
        this.chkStarEccentricity.Name = "chkStarEccentricity";
        this.chkStarEccentricity.Padding = new Padding(5, 0, 0, 0);
        this.chkStarEccentricity.Size = new Size(106, 17);
        this.chkStarEccentricity.TabIndex = 30;
        this.chkStarEccentricity.Text = "Eccentric Orbits";
        this.chkStarEccentricity.TextAlign = ContentAlignment.MiddleRight;
        this.chkStarEccentricity.UseVisualStyleBackColor = true;
        this.chkStarEccentricity.CheckedChanged += this.chkParallelUniverse_MouseEnter;
        this.chkStarEccentricity.MouseEnter += this.chkParallelUniverse_MouseEnter;
        this.chkGasGiantEffects.AutoSize = true;
        this.chkGasGiantEffects.Location = new Point(201, 210);
        this.chkGasGiantEffects.Name = "chkGasGiantEffects";
        this.chkGasGiantEffects.Padding = new Padding(5, 0, 0, 0);
        this.chkGasGiantEffects.Size = new Size(114, 17);
        this.chkGasGiantEffects.TabIndex = 31 /*0x1F*/;
        this.chkGasGiantEffects.Text = "Gas Giant Effects";
        this.chkGasGiantEffects.TextAlign = ContentAlignment.MiddleRight;
        this.chkGasGiantEffects.UseVisualStyleBackColor = true;
        this.chkGasGiantEffects.CheckedChanged += this.chkParallelUniverse_MouseEnter;
        this.chkGasGiantEffects.MouseEnter += this.chkParallelUniverse_MouseEnter;
        this.chkOneSecondSubPulse.AutoSize = true;
        this.chkOneSecondSubPulse.Location = new Point(201, 233);
        this.chkOneSecondSubPulse.Name = "chkOneSecondSubPulse";
        this.chkOneSecondSubPulse.Padding = new Padding(5, 0, 0, 0);
        this.chkOneSecondSubPulse.Size = new Size(142, 17);
        this.chkOneSecondSubPulse.TabIndex = 33;
        this.chkOneSecondSubPulse.Text = "One Second Sub Pulse";
        this.chkOneSecondSubPulse.TextAlign = ContentAlignment.MiddleRight;
        this.chkOneSecondSubPulse.UseVisualStyleBackColor = true;
        this.chkOneSecondSubPulse.MouseEnter += this.chkParallelUniverse_MouseEnter;
        this.chkLimitPlanetaryDistance.AutoSize = true;
        this.chkLimitPlanetaryDistance.Location = new Point(201, 256 /*0x0100*/);
        this.chkLimitPlanetaryDistance.Name = "chkLimitPlanetaryDistance";
        this.chkLimitPlanetaryDistance.Padding = new Padding(5, 0, 0, 0);
        this.chkLimitPlanetaryDistance.Size = new Size(142, 17);
        this.chkLimitPlanetaryDistance.TabIndex = 34;
        this.chkLimitPlanetaryDistance.Text = "Limited Planet Distance";
        this.chkLimitPlanetaryDistance.TextAlign = ContentAlignment.MiddleRight;
        this.chkLimitPlanetaryDistance.UseVisualStyleBackColor = true;
        this.chkLimitPlanetaryDistance.MouseEnter += this.chkParallelUniverse_MouseEnter;
        this.chkUseThemeInKnownStars.AutoSize = true;
        this.chkUseThemeInKnownStars.Location = new Point(201, 279);
        this.chkUseThemeInKnownStars.Name = "chkUseThemeInKnownStars";
        this.chkUseThemeInKnownStars.Padding = new Padding(5, 0, 0, 0);
        this.chkUseThemeInKnownStars.Size = new Size(160 /*0xA0*/, 17);
        this.chkUseThemeInKnownStars.TabIndex = 35;
        this.chkUseThemeInKnownStars.Text = "Use Theme in Known Stars";
        this.chkUseThemeInKnownStars.TextAlign = ContentAlignment.MiddleRight;
        this.chkUseThemeInKnownStars.UseVisualStyleBackColor = true;
        this.chkUseThemeInKnownStars.MouseEnter += this.chkParallelUniverse_MouseEnter;
        this.label7.AutoSize = true;
        this.label7.Location = new Point(2, 10);
        this.label7.Name = "label7";
        this.label7.Padding = new Padding(10, 5, 5, 0);
        this.label7.Size = new Size(81, 18);
        this.label7.TabIndex = 3;
        this.label7.Text = "Game Name";
        this.label7.TextAlign = ContentAlignment.MiddleLeft;
        this.cboGame.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cboGame.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cboGame.FormattingEnabled = true;
        this.cboGame.Items.AddRange(new object[2]
        {
            "Test Text One",
            "Text Test Two"
        });
        this.cboGame.Location = new Point(89, 10);
        this.cboGame.Name = "cboGame";
        this.cboGame.Size = new Size(204, 21);
        this.cboGame.TabIndex = 1;
        this.cboGame.SelectedIndexChanged += this.cboGame_SelectedIndexChanged;
        this.cmdDelete.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdDelete.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdDelete.Location = new Point(380, 0);
        this.cmdDelete.Margin = new Padding(0);
        this.cmdDelete.Name = "cmdDelete";
        this.cmdDelete.Size = new Size(95, 30);
        this.cmdDelete.TabIndex = 3;
        this.cmdDelete.Text = "Delete Game";
        this.cmdDelete.UseVisualStyleBackColor = false;
        this.cmdDelete.Click += this.cmdDelete_Click;
        this.cmdSave.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdSave.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdSave.Location = new Point(190, 0);
        this.cmdSave.Margin = new Padding(0);
        this.cmdSave.Name = "cmdSave";
        this.cmdSave.Size = new Size(95, 30);
        this.cmdSave.TabIndex = 2;
        this.cmdSave.Text = "Save Settings";
        this.cmdSave.UseVisualStyleBackColor = false;
        this.cmdSave.Click += this.cmdSave_Click;
        this.cmdNew.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdNew.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdNew.Location = new Point(285, 0);
        this.cmdNew.Margin = new Padding(0);
        this.cmdNew.Name = "cmdNew";
        this.cmdNew.Size = new Size(95, 30);
        this.cmdNew.TabIndex = 1;
        this.cmdNew.Text = "New Game";
        this.cmdNew.UseVisualStyleBackColor = false;
        this.cmdNew.Click += this.cmdNew_Click;
        this.cmdSelect.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdSelect.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdSelect.Location = new Point(0, 0);
        this.cmdSelect.Margin = new Padding(0);
        this.cmdSelect.Name = "cmdSelect";
        this.cmdSelect.Size = new Size(95, 30);
        this.cmdSelect.TabIndex = 0;
        this.cmdSelect.Text = "Play Game";
        this.cmdSelect.UseVisualStyleBackColor = false;
        this.cmdSelect.Click += this.cmdSelect_Click;
        this.txtOptionDescription.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtOptionDescription.BorderStyle = BorderStyle.FixedSingle;
        this.txtOptionDescription.ForeColor = Color.FromArgb(128 /*0x80*/, 255, 128 /*0x80*/);
        this.txtOptionDescription.Location = new Point(8, 544);
        this.txtOptionDescription.Margin = new Padding(0, 3, 3, 3);
        this.txtOptionDescription.Multiline = true;
        this.txtOptionDescription.Name = "txtOptionDescription";
        this.txtOptionDescription.ReadOnly = true;
        this.txtOptionDescription.Size = new Size(995, 69);
        this.txtOptionDescription.TabIndex = 129;
        this.txtOptionDescription.Text = "Option Description";
        this.txtOptionDescription.TextChanged += this.txtOptionDescription_TextChanged;
        this.flpNewGame.BorderStyle = BorderStyle.FixedSingle;
        this.flpNewGame.Controls.Add(this.panel15);
        this.flpNewGame.Controls.Add(this.panel5);
        this.flpNewGame.Controls.Add(this.panel17);
        this.flpNewGame.Controls.Add(this.panel16);
        this.flpNewGame.Controls.Add(this.panel18);
        this.flpNewGame.Controls.Add(this.panel23);
        this.flpNewGame.Controls.Add(this.panel22);
        this.flpNewGame.Controls.Add(this.panel25);
        this.flpNewGame.Controls.Add(this.panel26);
        this.flpNewGame.Controls.Add(this.panel27);
        this.flpNewGame.Controls.Add(this.panel33);
        this.flpNewGame.Controls.Add(this.panel34);
        this.flpNewGame.Controls.Add(this.panel35);
        this.flpNewGame.Controls.Add(this.panel36);
        this.flpNewGame.Controls.Add(this.flowLayoutPanel3);
        this.flpNewGame.Location = new Point(1001, 3);
        this.flpNewGame.Name = "flpNewGame";
        this.flpNewGame.Size = new Size(295, 470);
        this.flpNewGame.TabIndex = 130;
        this.flpNewGame.Visible = false;
        this.panel5.Controls.Add(this.txtPlayers);
        this.panel5.Controls.Add(this.label19);
        this.panel5.Location = new Point(3, 31 /*0x1F*/);
        this.panel5.Name = "panel5";
        this.panel5.Size = new Size(281, 22);
        this.panel5.TabIndex = 23;
        this.txtPlayers.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtPlayers.BorderStyle = BorderStyle.None;
        this.txtPlayers.ForeColor = Color.FromArgb(128 /*0x80*/, 255, 128 /*0x80*/);
        this.txtPlayers.Location = new Point(197, 5);
        this.txtPlayers.Name = "txtPlayers";
        this.txtPlayers.ReadOnly = true;
        this.txtPlayers.Size = new Size(84, 13);
        this.txtPlayers.TabIndex = 9;
        this.txtPlayers.Text = "1";
        this.txtPlayers.TextAlign = HorizontalAlignment.Center;
        this.txtPlayers.Enter += this.chkParallelUniverse_MouseEnter;
        this.txtPlayers.Leave += this.txtPlayers_Leave;
        this.txtPlayers.MouseEnter += this.chkParallelUniverse_MouseEnter;
        this.label19.AutoSize = true;
        this.label19.Dock = DockStyle.Left;
        this.label19.Location = new Point(0, 0);
        this.label19.Name = "label19";
        this.label19.Padding = new Padding(0, 5, 5, 0);
        this.label19.Size = new Size(127, 18);
        this.label19.TabIndex = 3;
        this.label19.Text = "Number of Player Races";
        this.panel17.Controls.Add(this.txtNPRs);
        this.panel17.Controls.Add(this.label20);
        this.panel17.Location = new Point(3, 59);
        this.panel17.Name = "panel17";
        this.panel17.Size = new Size(281, 22);
        this.panel17.TabIndex = 24;
        this.txtNPRs.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtNPRs.BorderStyle = BorderStyle.None;
        this.txtNPRs.ForeColor = Color.FromArgb(128 /*0x80*/, 255, 128 /*0x80*/);
        this.txtNPRs.Location = new Point(197, 5);
        this.txtNPRs.Name = "txtNPRs";
        this.txtNPRs.ReadOnly = true;
        this.txtNPRs.Size = new Size(84, 13);
        this.txtNPRs.TabIndex = 9;
        this.txtNPRs.Text = "1";
        this.txtNPRs.TextAlign = HorizontalAlignment.Center;
        this.txtNPRs.Enter += this.chkParallelUniverse_MouseEnter;
        this.txtNPRs.MouseEnter += this.chkParallelUniverse_MouseEnter;
        this.label20.AutoSize = true;
        this.label20.Dock = DockStyle.Left;
        this.label20.Location = new Point(0, 0);
        this.label20.Name = "label20";
        this.label20.Padding = new Padding(0, 5, 5, 0);
        this.label20.Size = new Size(150, 18);
        this.label20.TabIndex = 3;
        this.label20.Text = "Number of Non-Player Races";
        this.panel16.Controls.Add(this.txtJumpPoints);
        this.panel16.Controls.Add(this.label2);
        this.panel16.Location = new Point(3, 87);
        this.panel16.Name = "panel16";
        this.panel16.Size = new Size(281, 22);
        this.panel16.TabIndex = 25;
        this.txtJumpPoints.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtJumpPoints.BorderStyle = BorderStyle.None;
        this.txtJumpPoints.ForeColor = Color.FromArgb(128 /*0x80*/, 255, 128 /*0x80*/);
        this.txtJumpPoints.Location = new Point(197, 5);
        this.txtJumpPoints.Name = "txtJumpPoints";
        this.txtJumpPoints.ReadOnly = true;
        this.txtJumpPoints.Size = new Size(84, 13);
        this.txtJumpPoints.TabIndex = 9;
        this.txtJumpPoints.Text = "0";
        this.txtJumpPoints.TextAlign = HorizontalAlignment.Center;
        this.txtJumpPoints.Enter += this.chkParallelUniverse_MouseEnter;
        this.txtJumpPoints.MouseEnter += this.chkParallelUniverse_MouseEnter;
        this.label2.AutoSize = true;
        this.label2.Dock = DockStyle.Left;
        this.label2.Location = new Point(0, 0);
        this.label2.Name = "label2";
        this.label2.Padding = new Padding(0, 5, 5, 0);
        this.label2.Size = new Size(198, 18);
        this.label2.TabIndex = 3;
        this.label2.Text = "Minimum Sol Jump Points (0 = Random)";
        this.panel18.Controls.Add(this.txtEarthDeposits);
        this.panel18.Controls.Add(this.label4);
        this.panel18.Location = new Point(3, 115);
        this.panel18.Name = "panel18";
        this.panel18.Size = new Size(281, 22);
        this.panel18.TabIndex = 26;
        this.txtEarthDeposits.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtEarthDeposits.BorderStyle = BorderStyle.None;
        this.txtEarthDeposits.ForeColor = Color.FromArgb(128 /*0x80*/, 255, 128 /*0x80*/);
        this.txtEarthDeposits.Location = new Point(197, 5);
        this.txtEarthDeposits.Name = "txtEarthDeposits";
        this.txtEarthDeposits.Size = new Size(84, 13);
        this.txtEarthDeposits.TabIndex = 9;
        this.txtEarthDeposits.Text = "100";
        this.txtEarthDeposits.TextAlign = HorizontalAlignment.Center;
        this.txtEarthDeposits.MouseEnter += this.chkParallelUniverse_MouseEnter;
        this.label4.AutoSize = true;
        this.label4.Dock = DockStyle.Left;
        this.label4.Location = new Point(0, 0);
        this.label4.Name = "label4";
        this.label4.Padding = new Padding(0, 5, 5, 0);
        this.label4.Size = new Size(191, 18);
        this.label4.TabIndex = 3;
        this.label4.Text = "Earth Mineral Deposits  (100 = normal)";
        this.panel23.Controls.Add(this.txtMinNPRDistance);
        this.panel23.Controls.Add(this.lblMinNPRDistance);
        this.panel23.Location = new Point(3, 143);
        this.panel23.Name = "panel23";
        this.panel23.Size = new Size(281, 22);
        this.panel23.TabIndex = 138;
        this.txtMinNPRDistance.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtMinNPRDistance.BorderStyle = BorderStyle.None;
        this.txtMinNPRDistance.ForeColor = Color.FromArgb(128 /*0x80*/, 255, 128 /*0x80*/);
        this.txtMinNPRDistance.Location = new Point(197, 5);
        this.txtMinNPRDistance.Name = "txtMinNPRDistance";
        this.txtMinNPRDistance.Size = new Size(84, 13);
        this.txtMinNPRDistance.TabIndex = 9;
        this.txtMinNPRDistance.Text = "25";
        this.txtMinNPRDistance.TextAlign = HorizontalAlignment.Center;
        this.lblMinNPRDistance.AutoSize = true;
        this.lblMinNPRDistance.Dock = DockStyle.Left;
        this.lblMinNPRDistance.Location = new Point(0, 0);
        this.lblMinNPRDistance.Name = "lblMinNPRDistance";
        this.lblMinNPRDistance.Padding = new Padding(0, 5, 5, 0);
        this.lblMinNPRDistance.Size = new Size(146, 18);
        this.lblMinNPRDistance.TabIndex = 3;
        this.lblMinNPRDistance.Text = "Minimum NPR Distance (LY)";
        this.lblMinNPRDistance.MouseEnter += this.chkParallelUniverse_MouseEnter;
        this.panel22.Controls.Add(this.txtMaxNPRDistance);
        this.panel22.Controls.Add(this.lblMaxNPRDistance);
        this.panel22.Location = new Point(3, 171);
        this.panel22.Name = "panel22";
        this.panel22.Size = new Size(281, 22);
        this.panel22.TabIndex = 27;
        this.txtMaxNPRDistance.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtMaxNPRDistance.BorderStyle = BorderStyle.None;
        this.txtMaxNPRDistance.ForeColor = Color.FromArgb(128 /*0x80*/, 255, 128 /*0x80*/);
        this.txtMaxNPRDistance.Location = new Point(197, 5);
        this.txtMaxNPRDistance.Name = "txtMaxNPRDistance";
        this.txtMaxNPRDistance.Size = new Size(84, 13);
        this.txtMaxNPRDistance.TabIndex = 9;
        this.txtMaxNPRDistance.Text = "50";
        this.txtMaxNPRDistance.TextAlign = HorizontalAlignment.Center;
        this.lblMaxNPRDistance.AutoSize = true;
        this.lblMaxNPRDistance.Dock = DockStyle.Left;
        this.lblMaxNPRDistance.Location = new Point(0, 0);
        this.lblMaxNPRDistance.Name = "lblMaxNPRDistance";
        this.lblMaxNPRDistance.Padding = new Padding(0, 5, 5, 0);
        this.lblMaxNPRDistance.Size = new Size(149, 18);
        this.lblMaxNPRDistance.TabIndex = 3;
        this.lblMaxNPRDistance.Text = "Maximum NPR Distance (LY)";
        this.lblMaxNPRDistance.MouseEnter += this.chkParallelUniverse_MouseEnter;
        this.panel25.Controls.Add(this.txtSwarmSystems);
        this.panel25.Controls.Add(this.label26);
        this.panel25.Location = new Point(3, 199);
        this.panel25.Name = "panel25";
        this.panel25.Size = new Size(281, 22);
        this.panel25.TabIndex = 139;
        this.txtSwarmSystems.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtSwarmSystems.BorderStyle = BorderStyle.None;
        this.txtSwarmSystems.ForeColor = Color.FromArgb(128 /*0x80*/, 255, 128 /*0x80*/);
        this.txtSwarmSystems.Location = new Point(197, 5);
        this.txtSwarmSystems.Name = "txtSwarmSystems";
        this.txtSwarmSystems.Size = new Size(84, 13);
        this.txtSwarmSystems.TabIndex = 9;
        this.txtSwarmSystems.Text = "30";
        this.txtSwarmSystems.TextAlign = HorizontalAlignment.Center;
        this.label26.AutoSize = true;
        this.label26.Dock = DockStyle.Left;
        this.label26.Location = new Point(0, 0);
        this.label26.Name = "label26";
        this.label26.Padding = new Padding(0, 5, 5, 0);
        this.label26.Size = new Size(191, 18);
        this.label26.TabIndex = 3;
        this.label26.Text = "Player Known Systems for Star Swarm";
        this.panel26.Controls.Add(this.txtRaiderSystems);
        this.panel26.Controls.Add(this.label27);
        this.panel26.Location = new Point(3, 227);
        this.panel26.Name = "panel26";
        this.panel26.Size = new Size(281, 22);
        this.panel26.TabIndex = 140;
        this.txtRaiderSystems.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtRaiderSystems.BorderStyle = BorderStyle.None;
        this.txtRaiderSystems.ForeColor = Color.FromArgb(128 /*0x80*/, 255, 128 /*0x80*/);
        this.txtRaiderSystems.Location = new Point(197, 5);
        this.txtRaiderSystems.Name = "txtRaiderSystems";
        this.txtRaiderSystems.Size = new Size(84, 13);
        this.txtRaiderSystems.TabIndex = 9;
        this.txtRaiderSystems.Text = "10";
        this.txtRaiderSystems.TextAlign = HorizontalAlignment.Center;
        this.label27.AutoSize = true;
        this.label27.Dock = DockStyle.Left;
        this.label27.Location = new Point(0, 0);
        this.label27.Name = "label27";
        this.label27.Padding = new Padding(0, 5, 5, 0);
        this.label27.Size = new Size(173, 18);
        this.label27.TabIndex = 3;
        this.label27.Text = "Player Known Systems for Raiders";
        this.panel27.Controls.Add(this.txtInvaderSystems);
        this.panel27.Controls.Add(this.label28);
        this.panel27.Location = new Point(3, 255);
        this.panel27.Name = "panel27";
        this.panel27.Size = new Size(281, 22);
        this.panel27.TabIndex = 141;
        this.txtInvaderSystems.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtInvaderSystems.BorderStyle = BorderStyle.None;
        this.txtInvaderSystems.ForeColor = Color.FromArgb(128 /*0x80*/, 255, 128 /*0x80*/);
        this.txtInvaderSystems.Location = new Point(197, 5);
        this.txtInvaderSystems.Name = "txtInvaderSystems";
        this.txtInvaderSystems.Size = new Size(84, 13);
        this.txtInvaderSystems.TabIndex = 9;
        this.txtInvaderSystems.Text = "50";
        this.txtInvaderSystems.TextAlign = HorizontalAlignment.Center;
        this.label28.AutoSize = true;
        this.label28.Dock = DockStyle.Left;
        this.label28.Location = new Point(0, 0);
        this.label28.Name = "label28";
        this.label28.Padding = new Padding(0, 5, 5, 0);
        this.label28.Size = new Size(178, 18);
        this.label28.TabIndex = 3;
        this.label28.Text = "Player Known Systems for Invaders";
        this.panel33.Controls.Add(this.txtPrecursorRP);
        this.panel33.Controls.Add(this.label31);
        this.panel33.Location = new Point(3, 283);
        this.panel33.Name = "panel33";
        this.panel33.Size = new Size(281, 22);
        this.panel33.TabIndex = 142;
        this.txtPrecursorRP.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtPrecursorRP.BorderStyle = BorderStyle.None;
        this.txtPrecursorRP.ForeColor = Color.FromArgb(128 /*0x80*/, 255, 128 /*0x80*/);
        this.txtPrecursorRP.Location = new Point(197, 5);
        this.txtPrecursorRP.Name = "txtPrecursorRP";
        this.txtPrecursorRP.Size = new Size(84, 13);
        this.txtPrecursorRP.TabIndex = 9;
        this.txtPrecursorRP.Text = "600000";
        this.txtPrecursorRP.TextAlign = HorizontalAlignment.Center;
        this.label31.AutoSize = true;
        this.label31.Dock = DockStyle.Left;
        this.label31.Location = new Point(0, 0);
        this.label31.Name = "label31";
        this.label31.Padding = new Padding(0, 5, 5, 0);
        this.label31.Size = new Size(190, 18);
        this.label31.TabIndex = 3;
        this.label31.Text = "Minimum Research Points: Precursors";
        this.panel34.Controls.Add(this.txtSwarmRP);
        this.panel34.Controls.Add(this.label32);
        this.panel34.Location = new Point(3, 311);
        this.panel34.Name = "panel34";
        this.panel34.Size = new Size(281, 22);
        this.panel34.TabIndex = 143;
        this.txtSwarmRP.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtSwarmRP.BorderStyle = BorderStyle.None;
        this.txtSwarmRP.ForeColor = Color.FromArgb(128 /*0x80*/, 255, 128 /*0x80*/);
        this.txtSwarmRP.Location = new Point(197, 5);
        this.txtSwarmRP.Name = "txtSwarmRP";
        this.txtSwarmRP.Size = new Size(84, 13);
        this.txtSwarmRP.TabIndex = 9;
        this.txtSwarmRP.Text = "600000";
        this.txtSwarmRP.TextAlign = HorizontalAlignment.Center;
        this.label32.AutoSize = true;
        this.label32.Dock = DockStyle.Left;
        this.label32.Location = new Point(0, 0);
        this.label32.Name = "label32";
        this.label32.Padding = new Padding(0, 5, 5, 0);
        this.label32.Size = new Size(194, 18);
        this.label32.TabIndex = 3;
        this.label32.Text = "Minimum Research Points: Star Swarm";
        this.panel35.Controls.Add(this.txtRaiderRP);
        this.panel35.Controls.Add(this.label33);
        this.panel35.Location = new Point(3, 339);
        this.panel35.Name = "panel35";
        this.panel35.Size = new Size(281, 22);
        this.panel35.TabIndex = 144 /*0x90*/;
        this.txtRaiderRP.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtRaiderRP.BorderStyle = BorderStyle.None;
        this.txtRaiderRP.ForeColor = Color.FromArgb(128 /*0x80*/, 255, 128 /*0x80*/);
        this.txtRaiderRP.Location = new Point(197, 5);
        this.txtRaiderRP.Name = "txtRaiderRP";
        this.txtRaiderRP.Size = new Size(84, 13);
        this.txtRaiderRP.TabIndex = 9;
        this.txtRaiderRP.Text = "400000";
        this.txtRaiderRP.TextAlign = HorizontalAlignment.Center;
        this.label33.AutoSize = true;
        this.label33.Dock = DockStyle.Left;
        this.label33.Location = new Point(0, 0);
        this.label33.Name = "label33";
        this.label33.Padding = new Padding(0, 5, 5, 0);
        this.label33.Size = new Size(176 /*0xB0*/, 18);
        this.label33.TabIndex = 3;
        this.label33.Text = "Minimum Research Points: Raiders";
        this.panel36.Controls.Add(this.txtInvaderRP);
        this.panel36.Controls.Add(this.label34);
        this.panel36.Location = new Point(3, 367);
        this.panel36.Name = "panel36";
        this.panel36.Size = new Size(281, 22);
        this.panel36.TabIndex = 145;
        this.txtInvaderRP.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtInvaderRP.BorderStyle = BorderStyle.None;
        this.txtInvaderRP.ForeColor = Color.FromArgb(128 /*0x80*/, 255, 128 /*0x80*/);
        this.txtInvaderRP.Location = new Point(197, 5);
        this.txtInvaderRP.Name = "txtInvaderRP";
        this.txtInvaderRP.Size = new Size(84, 13);
        this.txtInvaderRP.TabIndex = 9;
        this.txtInvaderRP.Text = "1500000";
        this.txtInvaderRP.TextAlign = HorizontalAlignment.Center;
        this.label34.AutoSize = true;
        this.label34.Dock = DockStyle.Left;
        this.label34.Location = new Point(0, 0);
        this.label34.Name = "label34";
        this.label34.Padding = new Padding(0, 5, 5, 0);
        this.label34.Size = new Size(181, 18);
        this.label34.TabIndex = 3;
        this.label34.Text = "Minimum Research Points: Invaders";
        this.flowLayoutPanel3.Controls.Add(this.chkNPRSetup);
        this.flowLayoutPanel3.Controls.Add(this.chkPlanetX);
        this.flowLayoutPanel3.Controls.Add(this.chkParallelUniverse);
        this.flowLayoutPanel3.Location = new Point(0, 398);
        this.flowLayoutPanel3.Margin = new Padding(0, 6, 3, 3);
        this.flowLayoutPanel3.Name = "flowLayoutPanel3";
        this.flowLayoutPanel3.Size = new Size(284, 43);
        this.flowLayoutPanel3.TabIndex = 137;
        this.chkNPRSetup.AutoSize = true;
        this.chkNPRSetup.Location = new Point(1, 3);
        this.chkNPRSetup.Margin = new Padding(1, 3, 3, 3);
        this.chkNPRSetup.Name = "chkNPRSetup";
        this.chkNPRSetup.Padding = new Padding(5, 0, 0, 0);
        this.chkNPRSetup.Size = new Size(116, 17);
        this.chkNPRSetup.TabIndex = 29;
        this.chkNPRSetup.Text = "Customised NPRs";
        this.chkNPRSetup.TextAlign = ContentAlignment.MiddleRight;
        this.chkNPRSetup.UseVisualStyleBackColor = true;
        this.chkNPRSetup.MouseEnter += this.chkParallelUniverse_MouseEnter;
        this.chkPlanetX.AutoSize = true;
        this.chkPlanetX.Location = new Point(121, 3);
        this.chkPlanetX.Margin = new Padding(1, 3, 3, 3);
        this.chkPlanetX.Name = "chkPlanetX";
        this.chkPlanetX.Padding = new Padding(5, 0, 0, 0);
        this.chkPlanetX.Size = new Size(93, 17);
        this.chkPlanetX.TabIndex = 28;
        this.chkPlanetX.Text = "Add Planet X";
        this.chkPlanetX.TextAlign = ContentAlignment.MiddleRight;
        this.chkPlanetX.UseVisualStyleBackColor = true;
        this.chkPlanetX.MouseEnter += this.chkParallelUniverse_MouseEnter;
        this.chkParallelUniverse.AutoSize = true;
        this.chkParallelUniverse.Location = new Point(1, 26);
        this.chkParallelUniverse.Margin = new Padding(1, 3, 3, 3);
        this.chkParallelUniverse.Name = "chkParallelUniverse";
        this.chkParallelUniverse.Padding = new Padding(5, 0, 0, 0);
        this.chkParallelUniverse.Size = new Size(115, 17);
        this.chkParallelUniverse.TabIndex = 30;
        this.chkParallelUniverse.Text = "Parallel Universes";
        this.chkParallelUniverse.TextAlign = ContentAlignment.MiddleRight;
        this.chkParallelUniverse.UseVisualStyleBackColor = true;
        this.chkParallelUniverse.Visible = false;
        this.chkParallelUniverse.CheckedChanged += this.chkParallelUniverse_CheckedChanged;
        this.chkParallelUniverse.MouseEnter += this.chkParallelUniverse_MouseEnter;
        this.panel30.Controls.Add(this.txtNPRBaseTransits);
        this.panel30.Controls.Add(this.label24);
        this.panel30.Location = new Point(3, 55);
        this.panel30.Name = "panel30";
        this.panel30.Size = new Size(281, 22);
        this.panel30.TabIndex = 142;
        this.txtNPRBaseTransits.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtNPRBaseTransits.BorderStyle = BorderStyle.None;
        this.txtNPRBaseTransits.ForeColor = Color.FromArgb(128 /*0x80*/, 255, 128 /*0x80*/);
        this.txtNPRBaseTransits.Location = new Point(197, 5);
        this.txtNPRBaseTransits.Name = "txtNPRBaseTransits";
        this.txtNPRBaseTransits.Size = new Size(84, 13);
        this.txtNPRBaseTransits.TabIndex = 9;
        this.txtNPRBaseTransits.Text = "0";
        this.txtNPRBaseTransits.TextAlign = HorizontalAlignment.Center;
        this.label24.AutoSize = true;
        this.label24.Dock = DockStyle.Left;
        this.label24.Location = new Point(0, 0);
        this.label24.Name = "label24";
        this.label24.Padding = new Padding(0, 5, 5, 0);
        this.label24.Size = new Size(146, 18);
        this.label24.TabIndex = 3;
        this.label24.Text = "NPR Base Explored Transits";
        this.panel31.Controls.Add(this.txtNPRRandomTransits);
        this.panel31.Controls.Add(this.label29);
        this.panel31.Location = new Point(3, 83);
        this.panel31.Name = "panel31";
        this.panel31.Size = new Size(281, 22);
        this.panel31.TabIndex = 143;
        this.txtNPRRandomTransits.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtNPRRandomTransits.BorderStyle = BorderStyle.None;
        this.txtNPRRandomTransits.ForeColor = Color.FromArgb(128 /*0x80*/, 255, 128 /*0x80*/);
        this.txtNPRRandomTransits.Location = new Point(197, 5);
        this.txtNPRRandomTransits.Name = "txtNPRRandomTransits";
        this.txtNPRRandomTransits.Size = new Size(84, 13);
        this.txtNPRRandomTransits.TabIndex = 9;
        this.txtNPRRandomTransits.Text = "0";
        this.txtNPRRandomTransits.TextAlign = HorizontalAlignment.Center;
        this.label29.AutoSize = true;
        this.label29.Dock = DockStyle.Left;
        this.label29.Location = new Point(0, 0);
        this.label29.Name = "label29";
        this.label29.Padding = new Padding(0, 5, 5, 0);
        this.label29.Size = new Size(162, 18);
        this.label29.TabIndex = 3;
        this.label29.Text = "NPR Random Explored Transits";
        this.panel32.Controls.Add(this.txtNPRMaxStartingSystems);
        this.panel32.Controls.Add(this.label30);
        this.panel32.Location = new Point(3, 111);
        this.panel32.Name = "panel32";
        this.panel32.Size = new Size(281, 22);
        this.panel32.TabIndex = 144 /*0x90*/;
        this.txtNPRMaxStartingSystems.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtNPRMaxStartingSystems.BorderStyle = BorderStyle.None;
        this.txtNPRMaxStartingSystems.ForeColor = Color.FromArgb(128 /*0x80*/, 255, 128 /*0x80*/);
        this.txtNPRMaxStartingSystems.Location = new Point(197, 5);
        this.txtNPRMaxStartingSystems.Name = "txtNPRMaxStartingSystems";
        this.txtNPRMaxStartingSystems.Size = new Size(84, 13);
        this.txtNPRMaxStartingSystems.TabIndex = 9;
        this.txtNPRMaxStartingSystems.Text = "0";
        this.txtNPRMaxStartingSystems.TextAlign = HorizontalAlignment.Center;
        this.label30.AutoSize = true;
        this.label30.Dock = DockStyle.Left;
        this.label30.Location = new Point(0, 0);
        this.label30.Name = "label30";
        this.label30.Padding = new Padding(0, 5, 5, 0);
        this.label30.Size = new Size(198, 18);
        this.label30.TabIndex = 3;
        this.label30.Text = "NPR Max Start Systems  (0 = Unlimited)";
        this.textBox4.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.textBox4.BorderStyle = BorderStyle.FixedSingle;
        this.textBox4.ForeColor = Color.FromArgb(128 /*0x80*/, 255, 128 /*0x80*/);
        this.textBox4.Location = new Point(8, 39);
        this.textBox4.Name = "textBox4";
        this.textBox4.ReadOnly = true;
        this.textBox4.Size = new Size(995, 20);
        this.textBox4.TabIndex = 131;
        this.textBox4.Text = "These game options can be modified at any time";
        this.textBox4.TextAlign = HorizontalAlignment.Center;
        this.txtStartOnly.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtStartOnly.BorderStyle = BorderStyle.FixedSingle;
        this.txtStartOnly.ForeColor = Color.FromArgb(128 /*0x80*/, 255, 128 /*0x80*/);
        this.txtStartOnly.Location = new Point(1009, 39);
        this.txtStartOnly.Name = "txtStartOnly";
        this.txtStartOnly.ReadOnly = true;
        this.txtStartOnly.Size = new Size(283, 20);
        this.txtStartOnly.TabIndex = 132;
        this.txtStartOnly.Text = "These game options can be modified at start only";
        this.txtStartOnly.TextAlign = HorizontalAlignment.Center;
        this.txtStartOnly.Visible = false;
        this.cmdCreate.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdCreate.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdCreate.Location = new Point(475, 0);
        this.cmdCreate.Margin = new Padding(0);
        this.cmdCreate.Name = "cmdCreate";
        this.cmdCreate.Size = new Size(95, 30);
        this.cmdCreate.TabIndex = 133;
        this.cmdCreate.Text = "Create Game";
        this.cmdCreate.UseVisualStyleBackColor = false;
        this.cmdCreate.Visible = false;
        this.cmdCreate.Click += this.cmdCreate_Click;
        this.cmdCancel.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdCancel.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdCancel.Location = new Point(570, 0);
        this.cmdCancel.Margin = new Padding(0);
        this.cmdCancel.Name = "cmdCancel";
        this.cmdCancel.Size = new Size(95, 30);
        this.cmdCancel.TabIndex = 134;
        this.cmdCancel.Text = "Cancel";
        this.cmdCancel.UseVisualStyleBackColor = false;
        this.cmdCancel.Visible = false;
        this.cmdCancel.Click += this.cmdCancel_Click;
        this.flowLayoutPanel4.Controls.Add(this.cmdSelect);
        this.flowLayoutPanel4.Controls.Add(this.cmdRename);
        this.flowLayoutPanel4.Controls.Add(this.cmdSave);
        this.flowLayoutPanel4.Controls.Add(this.cmdNew);
        this.flowLayoutPanel4.Controls.Add(this.cmdDelete);
        this.flowLayoutPanel4.Controls.Add(this.cmdCreate);
        this.flowLayoutPanel4.Controls.Add(this.cmdCancel);
        this.flowLayoutPanel4.Location = new Point(8, 619);
        this.flowLayoutPanel4.Name = "flowLayoutPanel4";
        this.flowLayoutPanel4.Size = new Size(721, 30);
        this.flowLayoutPanel4.TabIndex = 135;
        this.flowLayoutPanel4.Paint += this.flowLayoutPanel4_Paint;
        this.cmdRename.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdRename.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdRename.Location = new Point(95, 0);
        this.cmdRename.Margin = new Padding(0);
        this.cmdRename.Name = "cmdRename";
        this.cmdRename.Size = new Size(95, 30);
        this.cmdRename.TabIndex = 135;
        this.cmdRename.Text = "Rename Game";
        this.cmdRename.UseVisualStyleBackColor = false;
        this.cmdRename.Click += this.cmdRename_Click;
        this.txtNewGameName.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtNewGameName.BorderStyle = BorderStyle.FixedSingle;
        this.txtNewGameName.ForeColor = Color.FromArgb(128 /*0x80*/, 255, 128 /*0x80*/);
        this.txtNewGameName.Location = new Point(89, 11);
        this.txtNewGameName.Name = "txtNewGameName";
        this.txtNewGameName.Size = new Size(204, 20);
        this.txtNewGameName.TabIndex = 136;
        this.txtNewGameName.Text = "New Game Name";
        this.txtNewGameName.TextAlign = HorizontalAlignment.Center;
        this.txtNewGameName.Visible = false;
        this.txtNewGameName.TextChanged += this.txtNewGameName_TextChanged;
        this.flowLayoutPanel5.Controls.Add(this.flowLayoutPanel2);
        this.flowLayoutPanel5.Controls.Add(this.flowLayoutPanel6);
        this.flowLayoutPanel5.Controls.Add(this.flowLayoutPanel1);
        this.flowLayoutPanel5.Controls.Add(this.flpNewGame);
        this.flowLayoutPanel5.Location = new Point(8, 65);
        this.flowLayoutPanel5.Name = "flowLayoutPanel5";
        this.flowLayoutPanel5.Size = new Size(1301, 473);
        this.flowLayoutPanel5.TabIndex = 137;
        this.flowLayoutPanel6.BorderStyle = BorderStyle.FixedSingle;
        this.flowLayoutPanel6.Controls.Add(this.panel7);
        this.flowLayoutPanel6.Controls.Add(this.panel8);
        this.flowLayoutPanel6.Controls.Add(this.panel30);
        this.flowLayoutPanel6.Controls.Add(this.panel31);
        this.flowLayoutPanel6.Controls.Add(this.panel32);
        this.flowLayoutPanel6.Controls.Add(this.panel37);
        this.flowLayoutPanel6.Controls.Add(this.panel38);
        this.flowLayoutPanel6.Controls.Add(this.panel29);
        this.flowLayoutPanel6.Controls.Add(this.panel28);
        this.flowLayoutPanel6.Location = new Point(301, 3);
        this.flowLayoutPanel6.Name = "flowLayoutPanel6";
        this.flowLayoutPanel6.Size = new Size(295, 470);
        this.flowLayoutPanel6.TabIndex = 131;
        this.panel37.Controls.Add(this.txtPreIndustrialRaces);
        this.panel37.Controls.Add(this.label35);
        this.panel37.Location = new Point(3, 139);
        this.panel37.Margin = new Padding(3, 3, 3, 1);
        this.panel37.Name = "panel37";
        this.panel37.Size = new Size(281, 22);
        this.panel37.TabIndex = 145;
        this.txtPreIndustrialRaces.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtPreIndustrialRaces.BorderStyle = BorderStyle.None;
        this.txtPreIndustrialRaces.ForeColor = Color.FromArgb(128 /*0x80*/, 255, 128 /*0x80*/);
        this.txtPreIndustrialRaces.Location = new Point(197, 5);
        this.txtPreIndustrialRaces.Name = "txtPreIndustrialRaces";
        this.txtPreIndustrialRaces.Size = new Size(84, 13);
        this.txtPreIndustrialRaces.TabIndex = 9;
        this.txtPreIndustrialRaces.Text = "10";
        this.txtPreIndustrialRaces.TextAlign = HorizontalAlignment.Center;
        this.label35.AutoSize = true;
        this.label35.Dock = DockStyle.Left;
        this.label35.Location = new Point(0, 0);
        this.label35.Name = "label35";
        this.label35.Padding = new Padding(0, 5, 5, 0);
        this.label35.Size = new Size(108, 18);
        this.label35.TabIndex = 3;
        this.label35.Text = "Pre-Industral NPR %";
        this.panel38.Controls.Add(this.txtConventionalRaces);
        this.panel38.Controls.Add(this.label36);
        this.panel38.Location = new Point(3, 165);
        this.panel38.Margin = new Padding(3, 3, 3, 1);
        this.panel38.Name = "panel38";
        this.panel38.Size = new Size(281, 22);
        this.panel38.TabIndex = 146;
        this.txtConventionalRaces.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtConventionalRaces.BorderStyle = BorderStyle.None;
        this.txtConventionalRaces.ForeColor = Color.FromArgb(128 /*0x80*/, 255, 128 /*0x80*/);
        this.txtConventionalRaces.Location = new Point(197, 5);
        this.txtConventionalRaces.Name = "txtConventionalRaces";
        this.txtConventionalRaces.Size = new Size(84, 13);
        this.txtConventionalRaces.TabIndex = 9;
        this.txtConventionalRaces.Text = "10";
        this.txtConventionalRaces.TextAlign = HorizontalAlignment.Center;
        this.label36.AutoSize = true;
        this.label36.Dock = DockStyle.Left;
        this.label36.Location = new Point(0, 0);
        this.label36.Name = "label36";
        this.label36.Padding = new Padding(0, 5, 5, 0);
        this.label36.Size = new Size(91, 18);
        this.label36.TabIndex = 3;
        this.label36.Text = "Industrial NPR %";
        this.AutoScaleDimensions = new SizeF(6f, 13f);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.ClientSize = new Size(1008, 656);
        this.Controls.Add(this.flowLayoutPanel5);
        this.Controls.Add(this.txtNewGameName);
        this.Controls.Add(this.flowLayoutPanel4);
        this.Controls.Add(this.txtOptionDescription);
        this.Controls.Add(this.txtStartOnly);
        this.Controls.Add(this.textBox4);
        this.Controls.Add(this.cboGame);
        this.Controls.Add(this.label7);
        this.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.FormBorderStyle = FormBorderStyle.FixedSingle;
        this.Name = "GameDetails";
        this.Text = "Game Information";
        this.Load += this.GameDetails_Load;
        this.flowLayoutPanel2.ResumeLayout(false);
        this.panel2.ResumeLayout(false);
        this.panel2.PerformLayout();
        this.panel3.ResumeLayout(false);
        this.panel3.PerformLayout();
        this.panel4.ResumeLayout(false);
        this.panel4.PerformLayout();
        this.panel6.ResumeLayout(false);
        this.panel6.PerformLayout();
        this.panel1.ResumeLayout(false);
        this.panel1.PerformLayout();
        this.panel20.ResumeLayout(false);
        this.panel20.PerformLayout();
        this.panel21.ResumeLayout(false);
        this.panel21.PerformLayout();
        this.panel24.ResumeLayout(false);
        this.panel24.PerformLayout();
        this.panel9.ResumeLayout(false);
        this.panel9.PerformLayout();
        this.panel10.ResumeLayout(false);
        this.panel10.PerformLayout();
        this.panel11.ResumeLayout(false);
        this.panel11.PerformLayout();
        this.panel13.ResumeLayout(false);
        this.panel13.PerformLayout();
        this.panel14.ResumeLayout(false);
        this.panel14.PerformLayout();
        this.panel12.ResumeLayout(false);
        this.panel12.PerformLayout();
        this.panel19.ResumeLayout(false);
        this.panel19.PerformLayout();
        this.panel7.ResumeLayout(false);
        this.panel7.PerformLayout();
        this.panel8.ResumeLayout(false);
        this.panel8.PerformLayout();
        this.panel29.ResumeLayout(false);
        this.panel29.PerformLayout();
        this.panel28.ResumeLayout(false);
        this.panel28.PerformLayout();
        this.panel15.ResumeLayout(false);
        this.panel15.PerformLayout();
        this.flowLayoutPanel1.ResumeLayout(false);
        this.flowLayoutPanel1.PerformLayout();
        this.flpNewGame.ResumeLayout(false);
        this.panel5.ResumeLayout(false);
        this.panel5.PerformLayout();
        this.panel17.ResumeLayout(false);
        this.panel17.PerformLayout();
        this.panel16.ResumeLayout(false);
        this.panel16.PerformLayout();
        this.panel18.ResumeLayout(false);
        this.panel18.PerformLayout();
        this.panel23.ResumeLayout(false);
        this.panel23.PerformLayout();
        this.panel22.ResumeLayout(false);
        this.panel22.PerformLayout();
        this.panel25.ResumeLayout(false);
        this.panel25.PerformLayout();
        this.panel26.ResumeLayout(false);
        this.panel26.PerformLayout();
        this.panel27.ResumeLayout(false);
        this.panel27.PerformLayout();
        this.panel33.ResumeLayout(false);
        this.panel33.PerformLayout();
        this.panel34.ResumeLayout(false);
        this.panel34.PerformLayout();
        this.panel35.ResumeLayout(false);
        this.panel35.PerformLayout();
        this.panel36.ResumeLayout(false);
        this.panel36.PerformLayout();
        this.flowLayoutPanel3.ResumeLayout(false);
        this.flowLayoutPanel3.PerformLayout();
        this.panel30.ResumeLayout(false);
        this.panel30.PerformLayout();
        this.panel31.ResumeLayout(false);
        this.panel31.PerformLayout();
        this.panel32.ResumeLayout(false);
        this.panel32.PerformLayout();
        this.flowLayoutPanel4.ResumeLayout(false);
        this.flowLayoutPanel5.ResumeLayout(false);
        this.flowLayoutPanel6.ResumeLayout(false);
        this.panel37.ResumeLayout(false);
        this.panel37.PerformLayout();
        this.panel38.ResumeLayout(false);
        this.panel38.PerformLayout();
        this.ResumeLayout(false);
        this.PerformLayout();
    }
}