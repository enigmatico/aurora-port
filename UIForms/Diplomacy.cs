// Decompiled with JetBrains decompiler
// Type: Diplomacy
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
public class Diplomacy : Form
{
    private sealed class Class894
    {
        public AlienShipClassIntel gclass115_0;

        internal bool method_0(AlienShipIntel gclass117_0)
        {
            return gclass117_0.gclass115_0 == this.gclass115_0 && !gclass117_0.bool_0;
        }
    }

    private sealed class Class895
    {
        public AlienShipClassIntel gclass115_0;

        internal bool method_0(AlienShipIntel gclass117_0)
        {
            return gclass117_0.gclass115_0 == this.gclass115_0;
        }
    }

    private sealed class Class896
    {
        public string string_0;

        internal bool method_0(
            KeyValuePair<AuroraSystemProtectionStatus, string> keyValuePair_0)
        {
            return keyValuePair_0.Value == this.string_0;
        }
    }

    private Dictionary<AuroraSystemProtectionStatus, string> dictionary_0 =
        new Dictionary<AuroraSystemProtectionStatus, string>();

    private GClass0 gclass0_0;
    private GameRace gclass21_0;
    private AlienRaceIntel gclass110_0;
    private TreeNode treeNode_0;
    private bool bool_0;
    
    private PictureBox pbRace;
    private PictureBox pbShip;
    private PictureBox pbFlag;
    private ComboBox cboRaces;
    private ComboBox cboAlienRaces;
    private FlowLayoutPanel flowLayoutPanel2;
    private RadioButton rdoHostile;
    private RadioButton rdoNeutral;
    private RadioButton rdoFriendly;
    private RadioButton rdoAllied;
    private FlowLayoutPanel flowLayoutPanel1;
    private FlowLayoutPanel flowLayoutPanel3;
    private Button cmdCommunicate;
    private ListView lstvStatus;
    private ColumnHeader columnHeader_0;
    private ColumnHeader columnHeader_1;
    private FlowLayoutPanel flowLayoutPanel7;
    private FlowLayoutPanel flowLayoutPanel8;
    private Button cmdRename;
    private CheckBox chkTrade;
    private CheckBox chkGeo;
    private CheckBox chkGrav;
    private CheckBox chkResearch;
    private ComboBox cboTheme;
    private TextBox txtAbbreviation;
    private CheckBox chkReal;
    private Label label28;
    private Label label1;
    private ListView lstvKnownSpecies;
    private ColumnHeader columnHeader_2;
    private ColumnHeader columnHeader_3;
    private ListView lstvAlienShips;
    private ColumnHeader columnHeader_4;
    private ColumnHeader columnHeader_5;
    private ColumnHeader columnHeader_6;
    private FlowLayoutPanel flowLayoutPanel9;
    private Label label5;
    private FlowLayoutPanel flowLayoutPanel11;
    private Label label7;
    private ListView lstvClassDetails;
    private ColumnHeader columnHeader_7;
    private ColumnHeader columnHeader_8;
    private Button cmdHull;
    private Label lblExtras;
    private ListView lstvKnownSensors;
    private ColumnHeader columnHeader_9;
    private TextBox txtSummary;
    private ColumnHeader columnHeader_10;
    private Button cmdChangeDR;
    private FlowLayoutPanel flowLayoutPanel12;
    private Button cmdRenameClass;
    private Button cmdToggleFixed;
    private Button cmdSetComm;
    private Button cmdRenameShip;
    private Button cmdDestroyShip;
    private Button cmdRenumber;
    private Button cmdAutoName;
    private Button cmdSelectName;
    private Button cmdCorrectNames;
    private Button cmdAddSpecies;
    private TabControl tabIntelligence;
    private TabPage tabClass;
    private TabPage tabPopulation;
    private TreeView tvIntelligence;
    private FlowLayoutPanel flowLayoutPanel14;
    private ListView lstvTechnology;
    private ColumnHeader columnHeader_11;
    private ListView lstvWeapons;
    private ColumnHeader columnHeader_12;
    private ColumnHeader columnHeader_13;
    private ColumnHeader columnHeader_14;
    private ColumnHeader columnHeader_15;
    private Label label9;
    private Label label10;
    private ColumnHeader columnHeader_16;
    private ColumnHeader columnHeader_17;
    private TabPage tabSpecies;
    private PictureBox pbSpecies;
    private ListView lstvPopulation;
    private ColumnHeader columnHeader_18;
    private ColumnHeader columnHeader_19;
    private TabPage tabGroundUnits;
    private ListView lstvGroundUnitClassData;
    private ColumnHeader columnHeader_20;
    private ColumnHeader columnHeader_21;
    private ListView lstvGroundUnitWeapons;
    private ColumnHeader columnHeader_22;
    private ColumnHeader columnHeader_23;
    private ColumnHeader columnHeader_24;
    private ColumnHeader columnHeader_25;
    private FlowLayoutPanel flowLayoutPanel4;
    private Button cmdClearClassData;
    private Button cmdDeleteClass;
    private TabPage tabKnownSystems;
    private TreeView tvContacts;
    private ComboBox cboStatus;
    private Button cmdText;
    private Button cmdSpeciesImage;
    private Button cmdRaceFlag;
    private Button cmdChangeHull;
    private Label label2;
    private Label lblRaceIntelligence;
    private Button cmdRenameUnit;
    private Button cmdSMRaceName;
    private CheckBox chkAlienNameRandom;
    private ListView lstvSystemSummary;
    private ColumnHeader columnHeader_26;
    private ColumnHeader columnHeader_27;
    private TabPage tabSensor;
    private ListView lstvMountingClasses;
    private ColumnHeader columnHeader_28;
    private Button cndRenameSensor;

    public Diplomacy(GClass0 gclass0_1)
    {
        this.gclass0_0 = gclass0_1;
        this.InitializeComponent();
    }

    private void method_0()
    {
        ToolTip toolTip = new ToolTip();
        toolTip.AutoPopDelay = 2000;
        toolTip.InitialDelay = 750;
        toolTip.ReshowDelay = 500;
        toolTip.ShowAlways = true;
        toolTip.SetToolTip(this.chkTrade,
            "When an alien race is granted trade access, its civilian shipping can bring alien trade goods to your markets and can transport your own Empire's trade goods to the markets of both Empires. This can open up new markets and boost the amount of shipping available for your own goods but you risk goods from alien populations replacing your own exports");
        toolTip.SetToolTip(this.chkGeo,
            "If you share geological survey data, then the results of any geological surveys you carry out on bodies known to the selected Empire are shared");
        toolTip.SetToolTip(this.chkGrav,
            "If you share gravitational survey data, then the results of any gravitational surveys you carry out on bodies known to the selected Empire are shared");
        toolTip.SetToolTip(this.chkResearch,
            "If you share research data with another Empire, then any background research projects that you complete are given to that Empire.");
        toolTip.SetToolTip(this.rdoHostile,
            "If an alien race is set to hostile, any missiles of that race in flight, regardless of target, will be engaged by automated anti-missile defences.");
        toolTip.SetToolTip(this.rdoFriendly,
            "Your race will allow friendly and allied races to use your jump ships stationed at jump points. ");
        toolTip.SetToolTip(this.rdoAllied,
            "Ships of allied races will display encrypted transponder signals so you will be able to see their location on the system map. Your ships will defend allied ships with point blank missile defence. ");
        toolTip.SetToolTip(this.cmdCommunicate,
            "While communication efforts are active, you will try to decipher the alien language. This effort can only take place if both sides are willing to communicate. In addition, both sides must have ships and/or populations in the same system and both sides must be able to detect the other (Thermal / EM for populations and Active for ships). Note that races may object to the presence of ships in their systems.");
        toolTip.SetToolTip(this.cmdClearClassData,
            "Remove all tacical data for the class, such as weapons, speed, sensor signatures, etc.. ");
    }

    private void method_1()
    {
        try
        {
            this.method_2(false);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 485);
        }
    }

    private void method_2(bool bool_1)
    {
        try
        {
            this.lstvKnownSpecies.Items.Clear();
            this.lstvAlienShips.Items.Clear();
            this.lstvClassDetails.Items.Clear();
            this.lstvKnownSensors.Items.Clear();
            this.txtSummary.Text = "";
            this.lblRaceIntelligence.Text = "0";
            this.gclass21_0.method_31(this, this.gclass110_0, this.lstvStatus, this.cboTheme, this.txtAbbreviation,
                this.chkReal, this.lblRaceIntelligence, this.chkAlienNameRandom);
            this.gclass21_0.method_382(this.tvIntelligence, this.gclass110_0, bool_1);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 486);
        }
    }

    private void method_3(AlienShipClassIntel gclass115_0)
    {
        try
        {
            this.gclass21_0.method_29(this.lstvAlienShips, this.lstvClassDetails, this.lstvKnownSensors,
                this.lstvWeapons, this.lstvTechnology, this.txtSummary, gclass115_0);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 487);
        }
    }

    private void method_4(AlienGroundUnitClassIntel gclass114_0)
    {
        try
        {
            this.gclass21_0.method_30(this.lstvGroundUnitClassData, this.lstvGroundUnitWeapons, gclass114_0);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 488);
        }
    }

    private void Diplomacy_FormClosing(object sender, FormClosingEventArgs e)
    {
        try
        {
            this.gclass0_0.method_512(this.Name, this.Left, this.Top);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 489);
        }
    }

    private void Diplomacy_Load(object sender, EventArgs e)
    {
        try
        {
            WindowPosition207 gclass207 = this.gclass0_0.method_513(this.Name);
            this.Left = gclass207.Left;
            this.Top = gclass207.Top;
            if (this.gclass0_0.bool_8)
            {
                this.cmdChangeDR.Visible = true;
                this.cmdToggleFixed.Visible = true;
                this.cmdSetComm.Visible = true;
                this.cmdAddSpecies.Visible = true;
                this.cmdSpeciesImage.Visible = true;
                this.cmdRaceFlag.Visible = true;
                this.cmdChangeHull.Visible = true;
                this.cmdSMRaceName.Visible = true;
            }
            else
            {
                this.cmdChangeDR.Visible = false;
                this.cmdToggleFixed.Visible = false;
                this.cmdSetComm.Visible = false;
                this.cmdAddSpecies.Visible = false;
                this.cmdSpeciesImage.Visible = false;
                this.cmdRaceFlag.Visible = false;
                this.cmdChangeHull.Visible = false;
                this.cmdSMRaceName.Visible = false;
            }

            this.gclass0_0.bool_9 = true;
            this.method_0();
            this.bool_0 = true;
            foreach (AuroraSystemProtectionStatus protectionStatus in Enum.GetValues(
                         typeof(AuroraSystemProtectionStatus)))
                this.dictionary_0.Add(protectionStatus, AuroraUtils.smethod_82(protectionStatus));
            this.cboStatus.DataSource = this.dictionary_0.Values.ToList<string>();
            this.gclass0_0.method_516(this.cboTheme);
            this.gclass0_0.method_578(this.cboRaces);
            this.gclass0_0.bool_9 = false;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 490);
        }
    }

    public void method_5(GameRace gclass21_1)
    {
        try
        {
            this.bool_0 = true;
            this.cboRaces.SelectedItem = gclass21_1;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 491);
        }
    }

    private void cboRaces_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            this.gclass21_0 = (GameRace)this.cboRaces.SelectedValue;
            this.gclass21_0.method_330(this.cboAlienRaces);
            if (this.cboAlienRaces.Items.Count == 0)
                this.cboAlienRaces.Text = "";
            if (this.cboAlienRaces.Items.Count == 0)
            {
                this.gclass110_0 = null;
                this.method_1();
            }

            if (!this.bool_0)
                this.gclass0_0.method_511(this.gclass21_0, this);
            this.bool_0 = false;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 492);
        }
    }

    private void cboAlienRaces_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            this.gclass110_0 = (AlienRaceIntel)this.cboAlienRaces.SelectedValue;
            this.method_1();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 493);
        }
    }

    public void method_6(Image image_0, Image image_1, Image image_2)
    {
        try
        {
            this.pbFlag.Image = image_1;
            this.pbShip.Image = image_2;
            this.pbRace.Image = image_0;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 494);
        }
    }

    public void method_7()
    {
        try
        {
            this.chkTrade.Visible = false;
            this.chkGeo.Visible = false;
            this.chkGrav.Visible = false;
            this.chkResearch.Visible = false;
            this.rdoHostile.Visible = false;
            this.rdoNeutral.Visible = false;
            this.rdoFriendly.Visible = false;
            this.rdoAllied.Visible = false;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 495);
        }
    }

    public void method_8(
        Decimal decimal_0,
        bool bool_1,
        bool bool_2,
        bool bool_3,
        bool bool_4,
        AuroraContactStatus auroraContactStatus_0)
    {
        try
        {
            this.chkTrade.Visible = true;
            this.chkGeo.Visible = true;
            this.chkGrav.Visible = true;
            this.chkResearch.Visible = true;
            this.rdoFriendly.Visible = true;
            this.rdoAllied.Visible = true;
            if (decimal_0 < AuroraUtils.int_65)
                this.chkTrade.Visible = false;
            if (decimal_0 < AuroraUtils.int_66)
                this.chkGeo.Visible = false;
            if (decimal_0 < AuroraUtils.int_67)
                this.chkGrav.Visible = false;
            if (decimal_0 < AuroraUtils.int_68)
                this.chkResearch.Visible = false;
            if (decimal_0 < AuroraUtils.int_70)
                this.rdoFriendly.Visible = false;
            if (decimal_0 < AuroraUtils.int_71)
                this.rdoAllied.Visible = false;
            this.chkTrade.CheckState = AuroraUtils.smethod_28(bool_1);
            this.chkGeo.CheckState = AuroraUtils.smethod_28(bool_2);
            this.chkGrav.CheckState = AuroraUtils.smethod_28(bool_3);
            this.chkResearch.CheckState = AuroraUtils.smethod_28(bool_4);
            if (auroraContactStatus_0 == AuroraContactStatus.Hostile)
                this.rdoHostile.Checked = true;
            else if (auroraContactStatus_0 == AuroraContactStatus.Neutral)
                this.rdoNeutral.Checked = true;
            if (auroraContactStatus_0 == AuroraContactStatus.Friendly)
                this.rdoFriendly.Checked = true;
            if (auroraContactStatus_0 != AuroraContactStatus.Allied)
                return;
            this.rdoAllied.Checked = true;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 496);
        }
    }

    private void cmdRename_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass110_0 == null)
                return;
            string str = this.gclass0_0.method_562("Enter New Alien Race Name", this.gclass110_0.AlienRaceName);
            if (str != "")
                this.gclass110_0.AlienRaceName = str;
            AlienRaceIntel gclass1100 = this.gclass110_0;
            this.gclass21_0.method_330(this.cboAlienRaces);
            this.cboAlienRaces.SelectedItem = gclass1100;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 497);
        }
    }

    private void cmdCommunicate_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass110_0 == null)
                return;
            if (this.gclass110_0.CommStatus == AuroraCommStatus.None)
                this.gclass110_0.CommStatus = AuroraCommStatus.AttemptingCommunication;
            else if (this.gclass110_0.CommStatus == AuroraCommStatus.AttemptingCommunication)
            {
                int num1 = (int)MessageBox.Show("Communication attempts are already underway", "Action Not Possible");
            }
            else if (this.gclass110_0.CommStatus == AuroraCommStatus.CommunicationImpossible)
            {
                int num2 = (int)MessageBox.Show(
                    "Our xenolinguists have concluded that communication is not possible with this alien race",
                    "Action Not Possible");
            }
            else if (this.gclass110_0.CommStatus == AuroraCommStatus.CommunicationEstablished)
            {
                int num3 = (int)MessageBox.Show("Communication has already been established with this race",
                    "Action Not Possible");
            }

            this.method_1();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 498);
        }
    }

    private void chkReal_CheckedChanged(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass110_0 == null)
                return;
            this.gclass110_0.UseRealClassNames = AuroraUtils.CheckStateToInt(this.chkReal.CheckState);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 499);
        }
    }

    private void cboTheme_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass110_0 == null)
                return;
            NamingTheme selectedItem = (NamingTheme)this.cboTheme.SelectedItem;
            if (selectedItem == null)
                return;
            this.gclass110_0.ClassTheme = selectedItem;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 500);
        }
    }

    private void txtAbbreviation_TextChanged(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass110_0 == null || this.txtAbbreviation.Text == "")
                return;
            this.gclass110_0.Abbreviation = this.txtAbbreviation.Text;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 501);
        }
    }

    private void chkTrade_CheckedChanged(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass110_0 == null)
                return;
            this.gclass110_0.bTradeTreaty = AuroraUtils.smethod_27(this.chkTrade.CheckState);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 502);
        }
    }

    private void chkGeo_CheckedChanged(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass110_0 == null)
                return;
            this.gclass110_0.bGeoTreaty = AuroraUtils.smethod_27(this.chkGeo.CheckState);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 503);
        }
    }

    private void chkGrav_CheckedChanged(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass110_0 == null)
                return;
            this.gclass110_0.bGravTreaty = AuroraUtils.smethod_27(this.chkGrav.CheckState);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 504);
        }
    }

    private void chkResearch_CheckedChanged(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass110_0 == null)
                return;
            this.gclass110_0.bTechTreaty = AuroraUtils.smethod_27(this.chkResearch.CheckState);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 505);
        }
    }

    private void rdoAllied_CheckedChanged(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass110_0 == null)
                return;
            if (this.rdoHostile.Checked)
                this.gclass110_0.ContactStatus = AuroraContactStatus.Hostile;
            else if (this.rdoNeutral.Checked)
                this.gclass110_0.ContactStatus = AuroraContactStatus.Neutral;
            else if (this.rdoFriendly.Checked)
            {
                this.gclass110_0.ContactStatus = AuroraContactStatus.Friendly;
            }
            else
            {
                if (!this.rdoAllied.Checked)
                    return;
                this.gclass110_0.ContactStatus = AuroraContactStatus.Allied;
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 506);
        }
    }

    private void cmdChangeDR_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass110_0 == null)
                return;
            this.gclass0_0.string_3 = "Enter New Diplomacy Rating for this Alien Race";
            this.gclass0_0.string_4 = this.gclass110_0.DiplomaticPoints.ToString();
            int num = (int)new MessageEntry(this.gclass0_0).ShowDialog();
            ParsedDecimal gclass208 = AuroraUtils.ParseDecimalString(this.gclass0_0.string_4);
            if (!gclass208.Succeed)
                return;
            this.gclass110_0.DiplomaticPoints = gclass208.Value;
            this.method_1();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 507);
        }
    }

    private void cmdRenameClass_Click(object sender, EventArgs e)
    {
        try
        {
            // ISSUE: object of a compiler-generated type is created
            // ISSUE: variable of a compiler-generated type
            Diplomacy.Class894 class894 = new Diplomacy.Class894();
            // ISSUE: reference to a compiler-generated field
            class894.gclass115_0 = this.method_9();
            // ISSUE: reference to a compiler-generated field
            if (class894.gclass115_0 == null)
                return;
            // ISSUE: reference to a compiler-generated field
            string str = this.gclass0_0.method_562("Enter New Alien Class Name", class894.gclass115_0.ClassName);
            if (str != "")
            {
                // ISSUE: reference to a compiler-generated field
                class894.gclass115_0.ClassName = str;
            }

            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            this.tvIntelligence.SelectedNode.Text =
                string.Format("{0}x {1} {2}",
                    class894.gclass115_0.gclass21_1.dictionary_12.Values.Count<AlienShipIntel>(class894.method_0).ToString(),
                    class894.gclass115_0.gclass76_0.Abbreviation, class894.gclass115_0.ClassName);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 508);
        }
    }

    private AlienShipClassIntel method_9()
    {
        try
        {
            if (this.gclass21_0 == null)
            {
                int num = (int)MessageBox.Show("Please select a race");
                return null;
            }

            if (this.tvIntelligence.SelectedNode == null)
            {
                int num = (int)MessageBox.Show("Please select an alien class to rename");
                return null;
            }

            if (this.tvIntelligence.SelectedNode.Tag is AlienShipClassIntel)
                return (AlienShipClassIntel)this.tvIntelligence.SelectedNode.Tag;
            int num1 = (int)MessageBox.Show(" Please select an alien class");
            return null;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 509);
            return null;
        }
    }

    private AlienGroundUnitClassIntel method_10()
    {
        try
        {
            if (this.gclass21_0 == null)
            {
                int num = (int)MessageBox.Show("Please select a race");
                return null;
            }

            if (this.tvIntelligence.SelectedNode == null)
            {
                int num = (int)MessageBox.Show("Please select an alien ground unit to rename");
                return null;
            }

            if (this.tvIntelligence.SelectedNode.Tag is AlienGroundUnitClassIntel)
                return (AlienGroundUnitClassIntel)this.tvIntelligence.SelectedNode.Tag;
            int num1 = (int)MessageBox.Show(" Please select an alien ground unit");
            return null;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3432);
            return null;
        }
    }

    private void cmdToggleFixed_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass110_0 == null)
                return;
            this.gclass110_0.FixedRelationShip = this.gclass110_0.FixedRelationShip != 1 ? 1 : 0;
            this.method_1();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 510);
        }
    }

    private void cmdHull_Click(object sender, EventArgs e)
    {
        try
        {
            AlienShipClassIntel gclass115_0 = this.method_9();
            if (gclass115_0 == null)
                return;
            this.gclass0_0.string_3 = "Select Alien Class Hull";
            this.gclass0_0.string_7 = "";
            this.gclass0_0.string_8 = "";
            this.gclass0_0.string_9 = "";
            this.gclass0_0.list_32 = new List<string>();
            foreach (ShipHull gclass76 in this.gclass0_0.ShipHullDictionary.Values
                         .OrderBy<ShipHull, string>(gclass76_0 => gclass76_0.Description).ToList<ShipHull>())
                this.gclass0_0.list_32.Add(gclass76.Description);
            int num = (int)new UserSelection(this.gclass0_0).ShowDialog();
            if (this.gclass0_0.bool_21)
                return;
            gclass115_0.gclass76_0 =
                this.gclass0_0.ShipHullDictionary.Values.FirstOrDefault<ShipHull>(gclass76_0 =>
                    gclass76_0.Description == this.gclass0_0.string_4);
            this.method_3(gclass115_0);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 511 /*0x01FF*/);
        }
    }

    private void cmdSetComm_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass110_0 == null)
                return;
            this.gclass110_0.CommStatus = AuroraCommStatus.CommunicationEstablished;
            this.method_1();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 512 /*0x0200*/);
        }
    }

    private void cmdRenameShip_Click(object sender, EventArgs e)
    {
        try
        {
            AlienShipClassIntel gclass115_0 = this.method_9();
            if (gclass115_0 == null)
                return;
            if (this.lstvAlienShips.SelectedItems.Count > 0)
            {
                AlienShipIntel tag = (AlienShipIntel)this.lstvAlienShips.SelectedItems[0].Tag;
                string str = this.gclass0_0.method_562("Enter New Alien Ship Name", tag.string_0);
                if (str != "")
                    tag.string_0 = str;
                this.method_3(gclass115_0);
            }
            else
            {
                int num = (int)MessageBox.Show(" Please select an alien ship");
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 513);
        }
    }

    private void lstvAlienShips_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass0_0.bool_9)
                return;
            if (this.gclass21_0 == null)
            {
                int num = (int)MessageBox.Show("Please select a Race");
            }
            else
            {
                if (this.lstvAlienShips.SelectedItems.Count == 0 || this.lstvAlienShips.SelectedItems[0].Tag == null ||
                    !(this.lstvAlienShips.SelectedItems[0].Tag is AlienShipIntel))
                    return;
                AlienShipIntel tag = (AlienShipIntel)this.lstvAlienShips.SelectedItems[0].Tag;
                if (tag == null)
                    return;
                this.gclass0_0.method_524(this.gclass21_0, tag.gclass200_0, tag.double_0, tag.double_1);
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 750);
        }
    }

    private void cmdDestroyShip_Click(object sender, EventArgs e)
    {
        try
        {
            AlienShipClassIntel gclass115_0 = this.method_9();
            if (gclass115_0 == null)
                return;
            if (this.lstvAlienShips.SelectedItems.Count > 0)
            {
                ((AlienShipIntel)this.lstvAlienShips.SelectedItems[0].Tag).bool_0 = true;
                this.method_3(gclass115_0);
            }
            else
            {
                int num = (int)MessageBox.Show(" Please select an alien ship");
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 514);
        }
    }

    private void cmdRenumber_Click(object sender, EventArgs e)
    {
        try
        {
            // ISSUE: object of a compiler-generated type is created
            // ISSUE: variable of a compiler-generated type
            Diplomacy.Class895 class895 = new Diplomacy.Class895();
            if (this.gclass21_0 == null || this.gclass110_0 == null)
                return;
            // ISSUE: reference to a compiler-generated field
            class895.gclass115_0 = this.method_9();
            // ISSUE: reference to a compiler-generated field
            if (class895.gclass115_0 == null)
                return;
            int int_72 = 1;
            // ISSUE: reference to a compiler-generated method
            List<AlienShipIntel> list = this.gclass21_0.dictionary_12.Values.Where<AlienShipIntel>(class895.method_0)
                .OrderBy<AlienShipIntel, Decimal>(gclass117_0 => gclass117_0.decimal_1).ToList<AlienShipIntel>();
            // ISSUE: reference to a compiler-generated field
            class895.gclass115_0.int_4 = list.Count;
            foreach (AlienShipIntel gclass117 in list)
            {
                // ISSUE: reference to a compiler-generated field
                gclass117.string_0 = string.Format("{0} {1}", class895.gclass115_0.ClassName,
                    AuroraUtils.smethod_33(int_72));
                ++int_72;
            }

            // ISSUE: reference to a compiler-generated field
            this.method_3(class895.gclass115_0);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 515);
        }
    }

    private void cmdAutoName_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass110_0 == null)
                return;
            AlienShipClassIntel gclass115 = this.method_9();
            if (gclass115 == null)
                return;
            gclass115.ClassName = this.gclass110_0.ClassTheme.method_0(this.gclass21_0, GEnum21.const_3);
            this.method_1();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 516);
        }
    }

    private void cmdSelectName_Click(object sender, EventArgs e)
    {
        try
        {
            AlienShipClassIntel gclass115 = this.method_9();
            if (gclass115 == null)
                return;
            int num = (int)new cmdSelect(this.gclass0_0).ShowDialog();
            if (this.gclass0_0.bool_21 || this.gclass0_0.string_4 == "")
                return;
            if (this.gclass0_0.string_4 != null)
                gclass115.ClassName = this.gclass0_0.string_4;
            this.method_1();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 517);
        }
    }

    private void cmdCorrectNames_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass21_0 == null || this.gclass110_0 == null)
                return;
            foreach (AlienShipClassIntel gclass115 in this.gclass21_0.dictionary_11.Values
                         .Where<AlienShipClassIntel>(gclass115_0 => gclass115_0.gclass110_0 == this.gclass110_0)
                         .ToList<AlienShipClassIntel>())
                gclass115.ClassName = gclass115.gclass22_0.ClassName;
            foreach (AlienShipIntel gclass117 in this.gclass21_0.dictionary_12.Values
                         .Where<AlienShipIntel>(gclass117_0 => gclass117_0.gclass110_0 == this.gclass110_0)
                         .ToList<AlienShipIntel>())
            {
                if (gclass117.int_0 > 0 && gclass117.gclass40_0 == null)
                    gclass117.method_3(gclass117.int_0);
                if (gclass117.gclass40_0 != null)
                    gclass117.string_0 = gclass117.gclass40_0.ShipName;
            }

            this.method_1();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 518);
        }
    }

    private void cmdAddSpecies_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass21_0 == null || this.gclass110_0 == null)
                return;
            this.gclass0_0.string_3 = "Provide Knowledge of Alien Species";
            this.gclass0_0.string_7 = "";
            this.gclass0_0.string_8 = "";
            this.gclass0_0.string_9 = "";
            this.gclass0_0.list_32 = new List<string>();
            foreach (Species gclass194 in this.gclass0_0.Populations.Values
                         .Where<PopulationData>(gclass146_0 => gclass146_0.Race == this.gclass21_0)
                         .Select<PopulationData, Species>(gclass146_0 => gclass146_0.Species).Distinct<Species>()
                         .OrderBy<Species, string>(gclass194_0 => gclass194_0.SpeciesName).ToList<Species>())
                this.gclass0_0.list_32.Add(gclass194.SpeciesName);
            int num = (int)new UserSelection(this.gclass0_0).ShowDialog();
            if (this.gclass0_0.bool_21)
                return;
            this.gclass21_0.method_163(this.gclass110_0,
                this.gclass0_0.SpeciesDictionary.Values.FirstOrDefault<Species>(gclass194_0 =>
                    gclass194_0.SpeciesName == this.gclass0_0.string_4), GEnum25.const_0);
            this.method_1();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 519);
        }
    }

    private void method_11(TreeNode treeNode_1)
    {
        try
        {
            if (this.gclass110_0 == null)
                return;
            if (treeNode_1.Tag is AlienShipClassIntel)
            {
                AlienShipClassIntel tag = (AlienShipClassIntel)treeNode_1.Tag;
                if (tag == null)
                    return;
                this.method_3(tag);
                this.tabIntelligence.SelectTab(this.tabClass);
            }
            else if (treeNode_1.Tag is RacialSystemSurvey)
            {
                RacialSystemSurvey tag = (RacialSystemSurvey)treeNode_1.Tag;
                if (tag == null)
                    return;
                this.gclass21_0.method_317(this.tvContacts, this.lstvSystemSummary, tag, true);
                this.cboStatus.SelectedItem = !tag.dictionary_0.ContainsKey(this.gclass110_0)
                    ? AuroraUtils.smethod_82(AuroraSystemProtectionStatus.NoProtection)
                    : (object)AuroraUtils.smethod_82(tag.dictionary_0[this.gclass110_0].auroraSystemProtectionStatus_0);
                this.tabIntelligence.SelectTab(this.tabKnownSystems);
            }
            else if (treeNode_1.Tag is AlienGroundUnitClassIntel)
            {
                AlienGroundUnitClassIntel tag = (AlienGroundUnitClassIntel)treeNode_1.Tag;
                if (tag == null)
                    return;
                this.method_4(tag);
                this.tabIntelligence.SelectTab(this.tabGroundUnits);
            }
            else if (treeNode_1.Tag is Species)
            {
                Species tag = (Species)treeNode_1.Tag;
                if (tag == null)
                    return;
                this.gclass21_0.method_27(this.lstvKnownSpecies, tag);
                this.tabIntelligence.SelectTab(this.tabSpecies);
            }
            else if (treeNode_1.Tag is AlienPopulationIntel)
            {
                AlienPopulationIntel tag = (AlienPopulationIntel)treeNode_1.Tag;
                if (tag == null)
                    return;
                this.gclass21_0.method_28(this.lstvPopulation, tag);
                this.tabIntelligence.SelectTab(this.tabPopulation);
            }
            else
            {
                if (!(treeNode_1.Tag is AlienSensorIntel))
                    return;
                AlienSensorIntel tag = (AlienSensorIntel)treeNode_1.Tag;
                if (tag == null)
                    return;
                this.gclass21_0.method_20(this.lstvMountingClasses, tag);
                this.tabIntelligence.SelectTab(this.tabSensor);
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 520);
        }
    }

    private void tvIntelligence_AfterSelect(object sender, TreeViewEventArgs e)
    {
        try
        {
            if (this.gclass110_0 == null)
                return;
            this.treeNode_0 = e.Node;
            this.method_11(this.treeNode_0);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 521);
        }
    }

    private void cmdDeleteClass_Click(object sender, EventArgs e)
    {
        try
        {
            AlienShipClassIntel gclass115 = this.method_9();
            if (gclass115 == null || MessageBox.Show(
                    string.Format(" Are you sure you want to delete {0}?", gclass115.ClassName),
                    "Confirmation Required", MessageBoxButtons.YesNo) != DialogResult.Yes)
                return;
            this.gclass21_0.dictionary_11.Remove(gclass115.int_0);
            this.method_2(true);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 522);
        }
    }

    private void cmdClearClassData_Click(object sender, EventArgs e)
    {
        try
        {
            AlienShipClassIntel gclass115 = this.method_9();
            if (gclass115 == null ||
                MessageBox.Show(string.Format(" Are you sure you want to clear all data for {0}?", gclass115.ClassName),
                    "Confirmation Required", MessageBoxButtons.YesNo) != DialogResult.Yes)
                return;
            gclass115.list_0.Clear();
            gclass115.list_1.Clear();
            gclass115.list_2.Clear();
            gclass115.int_1 = 0;
            gclass115.int_2 = 0;
            gclass115.int_3 = 0;
            gclass115.decimal_5 = 0M;
            gclass115.decimal_6 = 0M;
            gclass115.decimal_7 = 0M;
            gclass115.decimal_0 = 0M;
            gclass115.decimal_1 = 0M;
            gclass115.decimal_3 = 0M;
            gclass115.decimal_4 = 0M;
            gclass115.int_5 = 0;
            gclass115.int_6 = 0;
            gclass115.int_7 = 0;
            this.method_11(this.tvIntelligence.SelectedNode);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 523);
        }
    }

    private void cboStatus_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            if (this.treeNode_0 == null || this.gclass110_0 == null || !(this.treeNode_0.Tag is RacialSystemSurvey))
                return;
            // ISSUE: object of a compiler-generated type is created
            // ISSUE: variable of a compiler-generated type
            Diplomacy.Class896 class896 = new Diplomacy.Class896();
            RacialSystemSurvey tag = (RacialSystemSurvey)this.treeNode_0.Tag;
            if (tag == null)
                return;
            // ISSUE: reference to a compiler-generated field
            class896.string_0 = (string)this.cboStatus.SelectedValue;
            // ISSUE: reference to a compiler-generated method
            AuroraSystemProtectionStatus key = this.dictionary_0
                .FirstOrDefault<KeyValuePair<AuroraSystemProtectionStatus, string>>(class896.method_0).Key;
            if (tag.dictionary_0.ContainsKey(this.gclass110_0))
                tag.dictionary_0[this.gclass110_0].auroraSystemProtectionStatus_0 = key;
            else
                tag.dictionary_0.Add(this.gclass110_0, new AlienRaceSystemStatus()
                {
                    auroraSystemProtectionStatus_0 = key,
                    gclass202_0 = tag,
                    gclass110_0 = this.gclass110_0
                });
            this.treeNode_0.Text = tag.Name +
                                   AuroraUtils.SystemProtectionSuffixString(tag.dictionary_0[this.gclass110_0]
                                       .auroraSystemProtectionStatus_0);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 524);
        }
    }

    private void cmdText_Click(object sender, EventArgs e)
    {
        try
        {
            int num = (int)new PopulationText(this.gclass110_0, this.gclass0_0).ShowDialog();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 525);
        }
    }

    private void Diplomacy_KeyDown(object sender, KeyEventArgs e)
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
            AuroraUtils.ShowExceptionPopup(ex, 3273);
        }
    }

    private void cmdSpeciesImage_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass110_0 == null)
                return;
            if (!this.gclass110_0.ActualAlienRace.NPR)
            {
                int num1 = (int)MessageBox.Show("Players can only change images for AI races");
            }
            else
            {
                Species gclass194 = this.gclass110_0.ActualAlienRace.method_164();
                if (gclass194 == null)
                    return;
                string str = AuroraUtils.smethod_18("Races");
                if (str != "")
                {
                    int num2 = str.LastIndexOf("\\");
                    gclass194.RaceImageFileName = str.Substring(num2 + 1);
                }

                this.pbRace.Image = Image.FromFile(string.Format("{0}\\Races\\{1}", Application.StartupPath,
                    gclass194.RaceImageFileName));
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3301);
        }
    }

    private void cmdRaceFlag_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass110_0 == null)
                return;
            if (!this.gclass110_0.ActualAlienRace.NPR)
            {
                int num1 = (int)MessageBox.Show("Players can only change images for AI races");
            }
            else
            {
                string str = AuroraUtils.smethod_18("Flags");
                if (str != "")
                {
                    int num2 = str.LastIndexOf("\\");
                    this.gclass110_0.ActualAlienRace.FlagPic = str.Substring(num2 + 1);
                }

                this.gclass110_0.ActualAlienRace.FlagPicLoadedImg =
                    Image.FromFile(string.Format("{0}\\Flags\\{1}", Application.StartupPath,
                        this.gclass110_0.ActualAlienRace.FlagPic));
                this.pbFlag.Image = this.gclass110_0.ActualAlienRace.FlagPicLoadedImg;
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3302);
        }
    }

    private void cmdChangeHull_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass110_0 == null)
                return;
            if (!this.gclass110_0.ActualAlienRace.NPR)
            {
                int num1 = (int)MessageBox.Show("Players can only change images for AI races");
            }
            else
            {
                string str = AuroraUtils.smethod_18("ShipIcons");
                if (str != "")
                {
                    int num2 = str.LastIndexOf("\\");
                    this.gclass110_0.ActualAlienRace.HullPic = str.Substring(num2 + 1);
                }

                this.gclass110_0.ActualAlienRace.ShipIconLoadedImg =
                    Image.FromFile(string.Format("{0}\\ShipIcons\\{1}", Application.StartupPath,
                        this.gclass110_0.ActualAlienRace.HullPic));
                this.pbShip.Image = this.gclass110_0.ActualAlienRace.ShipIconLoadedImg;
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3303);
        }
    }

    private void cmdRenameUnit_Click(object sender, EventArgs e)
    {
        try
        {
            AlienGroundUnitClassIntel gclass114 = this.method_10();
            if (gclass114 == null)
                return;
            string str = this.gclass0_0.method_562("Enter New Alien Ground Unit Name", gclass114.string_0);
            if (str != "")
                gclass114.string_0 = str;
            this.tvIntelligence.SelectedNode.Text = gclass114.string_0;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3431);
        }
    }

    private void cmdSMRaceName_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass110_0 == null)
                return;
            if (!this.gclass110_0.ActualAlienRace.NPR)
            {
                int num1 = (int)MessageBox.Show("Players can only change names for AI races");
            }
            else
            {
                Species gclass194 = this.gclass110_0.ActualAlienRace.method_164();
                if (gclass194 == null)
                    return;
                this.gclass0_0.string_3 = "Enter New Species Name";
                this.gclass0_0.string_4 = gclass194.SpeciesName;
                int num2 = (int)new MessageEntry(this.gclass0_0).ShowDialog();
                if (this.gclass0_0.bool_21)
                    return;
                gclass194.SpeciesName = this.gclass0_0.string_4;
                this.gclass110_0.ActualAlienRace.RaceName = this.gclass0_0.string_4;
                this.gclass0_0.string_3 = "Enter New Race Title";
                this.gclass0_0.string_4 = this.gclass110_0.ActualAlienRace.RaceTitle;
                int num3 = (int)new MessageEntry(this.gclass0_0).ShowDialog();
                if (this.gclass0_0.bool_21)
                    return;
                this.gclass110_0.ActualAlienRace.RaceTitle = this.gclass0_0.string_4;
                this.gclass110_0.AlienRaceName = this.gclass0_0.string_4;
                this.gclass21_0.method_330(this.cboAlienRaces);
                this.cboAlienRaces.SelectedIndex = this.cboAlienRaces.FindString(this.gclass0_0.string_4);
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3301);
        }
    }

    private void chkAlienNameRandom_CheckedChanged(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass110_0 == null)
                return;
            this.gclass110_0.RandomNameOrder = AuroraUtils.CheckStateToInt(this.chkAlienNameRandom.CheckState);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3765);
        }
    }

    private void cndRenameSensor_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass21_0 == null)
            {
                int num1 = (int)MessageBox.Show("Please select a race");
            }
            else if (this.tvIntelligence.SelectedNode == null)
            {
                int num2 = (int)MessageBox.Show("Please select an alien sensor to rename");
            }
            else if (this.tvIntelligence.SelectedNode.Tag is AlienSensorIntel)
            {
                AlienSensorIntel tag = (AlienSensorIntel)this.tvIntelligence.SelectedNode.Tag;
                string str = this.gclass0_0.method_562("Enter New Alien Sensor Name", tag.Name);
                if (str != "")
                    tag.Name = str;
                this.tvIntelligence.SelectedNode.Text = tag.method_3();
            }
            else
            {
                int num3 = (int)MessageBox.Show(" Please select an alien sensor to rename");
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 508);
        }
    }

    

    private void InitializeComponent()
    {
        pbRace = new PictureBox();
        pbShip = new PictureBox();
        pbFlag = new PictureBox();
        cboRaces = new ComboBox();
        cboAlienRaces = new ComboBox();
        flowLayoutPanel2 = new FlowLayoutPanel();
        rdoHostile = new RadioButton();
        rdoNeutral = new RadioButton();
        rdoFriendly = new RadioButton();
        rdoAllied = new RadioButton();
        flowLayoutPanel1 = new FlowLayoutPanel();
        flowLayoutPanel3 = new FlowLayoutPanel();
        chkTrade = new CheckBox();
        chkGeo = new CheckBox();
        chkGrav = new CheckBox();
        chkResearch = new CheckBox();
        cmdCommunicate = new Button();
        lstvStatus = new ListView();
        columnHeader_0 = new ColumnHeader();
        columnHeader_1 = new ColumnHeader();
        flowLayoutPanel7 = new FlowLayoutPanel();
        label28 = new Label();
        txtAbbreviation = new TextBox();
        label2 = new Label();
        lblRaceIntelligence = new Label();
        label1 = new Label();
        cboTheme = new ComboBox();
        chkReal = new CheckBox();
        chkAlienNameRandom = new CheckBox();
        flowLayoutPanel8 = new FlowLayoutPanel();
        lstvKnownSpecies = new ListView();
        columnHeader_2 = new ColumnHeader();
        columnHeader_3 = new ColumnHeader();
        columnHeader_10 = new ColumnHeader();
        cmdRename = new Button();
        lstvAlienShips = new ListView();
        columnHeader_4 = new ColumnHeader();
        columnHeader_5 = new ColumnHeader();
        columnHeader_6 = new ColumnHeader();
        flowLayoutPanel9 = new FlowLayoutPanel();
        label5 = new Label();
        flowLayoutPanel11 = new FlowLayoutPanel();
        label9 = new Label();
        lstvWeapons = new ListView();
        columnHeader_12 = new ColumnHeader();
        columnHeader_13 = new ColumnHeader();
        columnHeader_14 = new ColumnHeader();
        columnHeader_15 = new ColumnHeader();
        lblExtras = new Label();
        lstvKnownSensors = new ListView();
        columnHeader_9 = new ColumnHeader();
        columnHeader_16 = new ColumnHeader();
        columnHeader_17 = new ColumnHeader();
        label10 = new Label();
        lstvTechnology = new ListView();
        columnHeader_11 = new ColumnHeader();
        label7 = new Label();
        lstvClassDetails = new ListView();
        columnHeader_7 = new ColumnHeader();
        columnHeader_8 = new ColumnHeader();
        cmdHull = new Button();
        txtSummary = new TextBox();
        cmdChangeDR = new Button();
        flowLayoutPanel12 = new FlowLayoutPanel();
        cmdAutoName = new Button();
        cmdSelectName = new Button();
        cmdDestroyShip = new Button();
        cmdCorrectNames = new Button();
        cmdToggleFixed = new Button();
        cmdSetComm = new Button();
        cmdAddSpecies = new Button();
        cmdSMRaceName = new Button();
        cmdSpeciesImage = new Button();
        cmdRaceFlag = new Button();
        cmdChangeHull = new Button();
        cmdRenameShip = new Button();
        cmdRenumber = new Button();
        cmdRenameClass = new Button();
        tabIntelligence = new TabControl();
        tabClass = new TabPage();
        flowLayoutPanel4 = new FlowLayoutPanel();
        cmdText = new Button();
        cmdClearClassData = new Button();
        cmdDeleteClass = new Button();
        flowLayoutPanel14 = new FlowLayoutPanel();
        tabPopulation = new TabPage();
        lstvPopulation = new ListView();
        columnHeader_18 = new ColumnHeader();
        columnHeader_19 = new ColumnHeader();
        tabSpecies = new TabPage();
        pbSpecies = new PictureBox();
        tabGroundUnits = new TabPage();
        cmdRenameUnit = new Button();
        lstvGroundUnitWeapons = new ListView();
        columnHeader_22 = new ColumnHeader();
        columnHeader_23 = new ColumnHeader();
        columnHeader_24 = new ColumnHeader();
        columnHeader_25 = new ColumnHeader();
        lstvGroundUnitClassData = new ListView();
        columnHeader_20 = new ColumnHeader();
        columnHeader_21 = new ColumnHeader();
        tabKnownSystems = new TabPage();
        lstvSystemSummary = new ListView();
        columnHeader_26 = new ColumnHeader();
        columnHeader_27 = new ColumnHeader();
        cboStatus = new ComboBox();
        tvContacts = new TreeView();
        tabSensor = new TabPage();
        cndRenameSensor = new Button();
        lstvMountingClasses = new ListView();
        columnHeader_28 = new ColumnHeader();
        tvIntelligence = new TreeView();
        ((ISupportInitialize)pbRace).BeginInit();
        ((ISupportInitialize)pbShip).BeginInit();
        ((ISupportInitialize)pbFlag).BeginInit();
        flowLayoutPanel2.SuspendLayout();
        flowLayoutPanel1.SuspendLayout();
        flowLayoutPanel3.SuspendLayout();
        flowLayoutPanel7.SuspendLayout();
        flowLayoutPanel8.SuspendLayout();
        flowLayoutPanel9.SuspendLayout();
        flowLayoutPanel11.SuspendLayout();
        flowLayoutPanel12.SuspendLayout();
        tabIntelligence.SuspendLayout();
        tabClass.SuspendLayout();
        flowLayoutPanel4.SuspendLayout();
        flowLayoutPanel14.SuspendLayout();
        tabPopulation.SuspendLayout();
        tabSpecies.SuspendLayout();
        ((ISupportInitialize)pbSpecies).BeginInit();
        tabGroundUnits.SuspendLayout();
        tabKnownSystems.SuspendLayout();
        tabSensor.SuspendLayout();
        SuspendLayout();
        // 
        // pbRace
        // 
        pbRace.Anchor = AnchorStyles.None;
        pbRace.BorderStyle = BorderStyle.FixedSingle;
        pbRace.Location = new Point(579, 3);
        pbRace.Margin = new Padding(4, 3, 4, 3);
        pbRace.Name = "pbRace";
        pbRace.Size = new Size(250, 202);
        pbRace.SizeMode = PictureBoxSizeMode.StretchImage;
        pbRace.TabIndex = 134;
        pbRace.TabStop = false;
        // 
        // pbShip
        // 
        pbShip.Anchor = AnchorStyles.None;
        pbShip.BorderStyle = BorderStyle.FixedSingle;
        pbShip.Location = new Point(837, 3);
        pbShip.Margin = new Padding(4, 3, 4, 3);
        pbShip.Name = "pbShip";
        pbShip.Size = new Size(250, 202);
        pbShip.SizeMode = PictureBoxSizeMode.Zoom;
        pbShip.TabIndex = 141;
        pbShip.TabStop = false;
        // 
        // pbFlag
        // 
        pbFlag.Anchor = AnchorStyles.None;
        pbFlag.BackgroundImageLayout = ImageLayout.None;
        pbFlag.BorderStyle = BorderStyle.FixedSingle;
        pbFlag.Location = new Point(1095, 3);
        pbFlag.Margin = new Padding(4, 3, 4, 3);
        pbFlag.Name = "pbFlag";
        pbFlag.Size = new Size(347, 202);
        pbFlag.SizeMode = PictureBoxSizeMode.StretchImage;
        pbFlag.TabIndex = 142;
        pbFlag.TabStop = false;
        // 
        // cboRaces
        // 
        cboRaces.BackColor = Color.FromArgb(0, 0, 64);
        cboRaces.ForeColor = Color.FromArgb(255, 255, 192);
        cboRaces.FormattingEnabled = true;
        cboRaces.Location = new Point(4, 3);
        cboRaces.Margin = new Padding(4, 3, 4, 0);
        cboRaces.Name = "cboRaces";
        cboRaces.Size = new Size(233, 23);
        cboRaces.TabIndex = 143;
        cboRaces.SelectedIndexChanged += cboRaces_SelectedIndexChanged;
        // 
        // cboAlienRaces
        // 
        cboAlienRaces.BackColor = Color.FromArgb(0, 0, 64);
        cboAlienRaces.ForeColor = Color.FromArgb(255, 255, 192);
        cboAlienRaces.FormattingEnabled = true;
        cboAlienRaces.Location = new Point(245, 3);
        cboAlienRaces.Margin = new Padding(4, 3, 4, 0);
        cboAlienRaces.Name = "cboAlienRaces";
        cboAlienRaces.Size = new Size(233, 23);
        cboAlienRaces.TabIndex = 144;
        cboAlienRaces.SelectedIndexChanged += cboAlienRaces_SelectedIndexChanged;
        // 
        // flowLayoutPanel2
        // 
        flowLayoutPanel2.Controls.Add(rdoHostile);
        flowLayoutPanel2.Controls.Add(rdoNeutral);
        flowLayoutPanel2.Controls.Add(rdoFriendly);
        flowLayoutPanel2.Controls.Add(rdoAllied);
        flowLayoutPanel2.FlowDirection = FlowDirection.TopDown;
        flowLayoutPanel2.Location = new Point(4, 0);
        flowLayoutPanel2.Margin = new Padding(4, 0, 4, 0);
        flowLayoutPanel2.Name = "flowLayoutPanel2";
        flowLayoutPanel2.Size = new Size(160, 99);
        flowLayoutPanel2.TabIndex = 145;
        // 
        // rdoHostile
        // 
        rdoHostile.AutoSize = true;
        rdoHostile.Checked = true;
        rdoHostile.Location = new Point(4, 2);
        rdoHostile.Margin = new Padding(4, 2, 4, 2);
        rdoHostile.Name = "rdoHostile";
        rdoHostile.Size = new Size(62, 19);
        rdoHostile.TabIndex = 0;
        rdoHostile.TabStop = true;
        rdoHostile.Text = "Hostile";
        rdoHostile.UseVisualStyleBackColor = true;
        rdoHostile.CheckedChanged += rdoAllied_CheckedChanged;
        // 
        // rdoNeutral
        // 
        rdoNeutral.AutoSize = true;
        rdoNeutral.Location = new Point(4, 25);
        rdoNeutral.Margin = new Padding(4, 2, 4, 2);
        rdoNeutral.Name = "rdoNeutral";
        rdoNeutral.Size = new Size(64, 19);
        rdoNeutral.TabIndex = 1;
        rdoNeutral.Text = "Neutral";
        rdoNeutral.UseVisualStyleBackColor = true;
        rdoNeutral.CheckedChanged += rdoAllied_CheckedChanged;
        // 
        // rdoFriendly
        // 
        rdoFriendly.AutoSize = true;
        rdoFriendly.Location = new Point(4, 48);
        rdoFriendly.Margin = new Padding(4, 2, 4, 2);
        rdoFriendly.Name = "rdoFriendly";
        rdoFriendly.Size = new Size(66, 19);
        rdoFriendly.TabIndex = 2;
        rdoFriendly.Text = "Friendly";
        rdoFriendly.UseVisualStyleBackColor = true;
        rdoFriendly.CheckedChanged += rdoAllied_CheckedChanged;
        // 
        // rdoAllied
        // 
        rdoAllied.AutoSize = true;
        rdoAllied.Location = new Point(4, 71);
        rdoAllied.Margin = new Padding(4, 2, 4, 2);
        rdoAllied.Name = "rdoAllied";
        rdoAllied.Size = new Size(55, 19);
        rdoAllied.TabIndex = 3;
        rdoAllied.Text = "Allied";
        rdoAllied.UseVisualStyleBackColor = true;
        rdoAllied.CheckedChanged += rdoAllied_CheckedChanged;
        // 
        // flowLayoutPanel1
        // 
        flowLayoutPanel1.BorderStyle = BorderStyle.FixedSingle;
        flowLayoutPanel1.Controls.Add(flowLayoutPanel2);
        flowLayoutPanel1.Controls.Add(flowLayoutPanel3);
        flowLayoutPanel1.Location = new Point(378, 3);
        flowLayoutPanel1.Margin = new Padding(4, 3, 4, 3);
        flowLayoutPanel1.Name = "flowLayoutPanel1";
        flowLayoutPanel1.Size = new Size(193, 202);
        flowLayoutPanel1.TabIndex = 146;
        // 
        // flowLayoutPanel3
        // 
        flowLayoutPanel3.Controls.Add(chkTrade);
        flowLayoutPanel3.Controls.Add(chkGeo);
        flowLayoutPanel3.Controls.Add(chkGrav);
        flowLayoutPanel3.Controls.Add(chkResearch);
        flowLayoutPanel3.FlowDirection = FlowDirection.TopDown;
        flowLayoutPanel3.Location = new Point(4, 99);
        flowLayoutPanel3.Margin = new Padding(4, 0, 4, 0);
        flowLayoutPanel3.Name = "flowLayoutPanel3";
        flowLayoutPanel3.Size = new Size(160, 102);
        flowLayoutPanel3.TabIndex = 146;
        // 
        // chkTrade
        // 
        chkTrade.AutoSize = true;
        chkTrade.Location = new Point(4, 3);
        chkTrade.Margin = new Padding(4, 3, 4, 2);
        chkTrade.Name = "chkTrade";
        chkTrade.Size = new Size(126, 19);
        chkTrade.TabIndex = 149;
        chkTrade.Text = "Allow Trade Access";
        chkTrade.UseVisualStyleBackColor = true;
        chkTrade.CheckedChanged += chkTrade_CheckedChanged;
        // 
        // chkGeo
        // 
        chkGeo.AutoSize = true;
        chkGeo.Location = new Point(4, 26);
        chkGeo.Margin = new Padding(4, 2, 4, 2);
        chkGeo.Name = "chkGeo";
        chkGeo.Size = new Size(141, 19);
        chkGeo.TabIndex = 150;
        chkGeo.Text = "Share Geological Data";
        chkGeo.UseVisualStyleBackColor = true;
        chkGeo.CheckedChanged += chkGeo_CheckedChanged;
        // 
        // chkGrav
        // 
        chkGrav.AutoSize = true;
        chkGrav.Location = new Point(4, 49);
        chkGrav.Margin = new Padding(4, 2, 4, 2);
        chkGrav.Name = "chkGrav";
        chkGrav.Size = new Size(152, 19);
        chkGrav.TabIndex = 151;
        chkGrav.Text = "Share Gravitational Data";
        chkGrav.UseVisualStyleBackColor = true;
        chkGrav.CheckedChanged += chkGrav_CheckedChanged;
        // 
        // chkResearch
        // 
        chkResearch.AutoSize = true;
        chkResearch.Location = new Point(4, 72);
        chkResearch.Margin = new Padding(4, 2, 4, 2);
        chkResearch.Name = "chkResearch";
        chkResearch.Size = new Size(132, 19);
        chkResearch.TabIndex = 152;
        chkResearch.Text = "Share Research Data";
        chkResearch.UseVisualStyleBackColor = true;
        chkResearch.CheckedChanged += chkResearch_CheckedChanged;
        // 
        // cmdCommunicate
        // 
        cmdCommunicate.BackColor = Color.FromArgb(0, 0, 64);
        cmdCommunicate.ForeColor = Color.FromArgb(255, 255, 192);
        cmdCommunicate.Location = new Point(0, 0);
        cmdCommunicate.Margin = new Padding(0);
        cmdCommunicate.Name = "cmdCommunicate";
        cmdCommunicate.Size = new Size(112, 35);
        cmdCommunicate.TabIndex = 149;
        cmdCommunicate.Tag = "1200";
        cmdCommunicate.Text = "Communicate";
        cmdCommunicate.UseVisualStyleBackColor = false;
        cmdCommunicate.Click += cmdCommunicate_Click;
        // 
        // lstvStatus
        // 
        lstvStatus.BackColor = Color.FromArgb(0, 0, 64);
        lstvStatus.BorderStyle = BorderStyle.FixedSingle;
        lstvStatus.Columns.AddRange(new ColumnHeader[] { columnHeader_0, columnHeader_1 });
        lstvStatus.ForeColor = Color.FromArgb(255, 255, 192);
        lstvStatus.HeaderStyle = ColumnHeaderStyle.None;
        lstvStatus.Location = new Point(0, 3);
        lstvStatus.Margin = new Padding(0, 3, 4, 3);
        lstvStatus.Name = "lstvStatus";
        lstvStatus.Size = new Size(370, 202);
        lstvStatus.TabIndex = 150;
        lstvStatus.UseCompatibleStateImageBehavior = false;
        lstvStatus.View = View.Details;
        // 
        // columnHeader_0
        // 
        columnHeader_0.Width = 160;
        // 
        // columnHeader_1
        // 
        columnHeader_1.Width = 140;
        // 
        // flowLayoutPanel7
        // 
        flowLayoutPanel7.BorderStyle = BorderStyle.FixedSingle;
        flowLayoutPanel7.Controls.Add(cboRaces);
        flowLayoutPanel7.Controls.Add(cboAlienRaces);
        flowLayoutPanel7.Controls.Add(label28);
        flowLayoutPanel7.Controls.Add(txtAbbreviation);
        flowLayoutPanel7.Controls.Add(label2);
        flowLayoutPanel7.Controls.Add(lblRaceIntelligence);
        flowLayoutPanel7.Controls.Add(label1);
        flowLayoutPanel7.Controls.Add(cboTheme);
        flowLayoutPanel7.Controls.Add(chkReal);
        flowLayoutPanel7.Controls.Add(chkAlienNameRandom);
        flowLayoutPanel7.Location = new Point(6, 3);
        flowLayoutPanel7.Margin = new Padding(4, 3, 4, 3);
        flowLayoutPanel7.Name = "flowLayoutPanel7";
        flowLayoutPanel7.Size = new Size(1605, 33);
        flowLayoutPanel7.TabIndex = 151;
        // 
        // label28
        // 
        label28.AutoSize = true;
        label28.Location = new Point(511, 7);
        label28.Margin = new Padding(29, 7, 6, 0);
        label28.Name = "label28";
        label28.Size = new Size(45, 15);
        label28.TabIndex = 151;
        label28.Text = "Abbrev";
        label28.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // txtAbbreviation
        // 
        txtAbbreviation.BackColor = Color.FromArgb(0, 0, 64);
        txtAbbreviation.BorderStyle = BorderStyle.None;
        txtAbbreviation.ForeColor = Color.FromArgb(128, 255, 128);
        txtAbbreviation.Location = new Point(562, 8);
        txtAbbreviation.Margin = new Padding(0, 8, 4, 3);
        txtAbbreviation.Multiline = true;
        txtAbbreviation.Name = "txtAbbreviation";
        txtAbbreviation.Size = new Size(47, 21);
        txtAbbreviation.TabIndex = 146;
        txtAbbreviation.Text = "USA";
        txtAbbreviation.TextAlign = HorizontalAlignment.Center;
        txtAbbreviation.TextChanged += txtAbbreviation_TextChanged;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(642, 7);
        label2.Margin = new Padding(29, 7, 6, 0);
        label2.Name = "label2";
        label2.Size = new Size(85, 15);
        label2.TabIndex = 154;
        label2.Text = "Race Int Points";
        label2.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // lblRaceIntelligence
        // 
        lblRaceIntelligence.AutoSize = true;
        lblRaceIntelligence.Location = new Point(733, 7);
        lblRaceIntelligence.Margin = new Padding(0, 7, 6, 0);
        lblRaceIntelligence.Name = "lblRaceIntelligence";
        lblRaceIntelligence.Size = new Size(75, 15);
        lblRaceIntelligence.TabIndex = 155;
        lblRaceIntelligence.Text = "Abbreviation";
        lblRaceIntelligence.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(843, 7);
        label1.Margin = new Padding(29, 7, 6, 0);
        label1.Name = "label1";
        label1.Size = new Size(42, 15);
        label1.TabIndex = 152;
        label1.Text = "Theme";
        label1.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // cboTheme
        // 
        cboTheme.BackColor = Color.FromArgb(0, 0, 64);
        cboTheme.ForeColor = Color.FromArgb(255, 255, 192);
        cboTheme.FormattingEnabled = true;
        cboTheme.Location = new Point(895, 3);
        cboTheme.Margin = new Padding(4, 3, 4, 0);
        cboTheme.Name = "cboTheme";
        cboTheme.Size = new Size(256, 23);
        cboTheme.TabIndex = 145;
        cboTheme.SelectedIndexChanged += cboTheme_SelectedIndexChanged;
        // 
        // chkReal
        // 
        chkReal.AutoSize = true;
        chkReal.Location = new Point(1173, 6);
        chkReal.Margin = new Padding(18, 6, 4, 3);
        chkReal.Name = "chkReal";
        chkReal.Size = new Size(172, 19);
        chkReal.TabIndex = 150;
        chkReal.Text = "Use Real Ship / Class Names";
        chkReal.UseVisualStyleBackColor = true;
        chkReal.CheckedChanged += chkReal_CheckedChanged;
        // 
        // chkAlienNameRandom
        // 
        chkAlienNameRandom.AutoSize = true;
        chkAlienNameRandom.Location = new Point(1367, 6);
        chkAlienNameRandom.Margin = new Padding(18, 6, 4, 3);
        chkAlienNameRandom.Name = "chkAlienNameRandom";
        chkAlienNameRandom.Size = new Size(103, 19);
        chkAlienNameRandom.TabIndex = 156;
        chkAlienNameRandom.Text = "Random Order";
        chkAlienNameRandom.UseVisualStyleBackColor = true;
        chkAlienNameRandom.CheckedChanged += chkAlienNameRandom_CheckedChanged;
        // 
        // flowLayoutPanel8
        // 
        flowLayoutPanel8.Controls.Add(lstvStatus);
        flowLayoutPanel8.Controls.Add(flowLayoutPanel1);
        flowLayoutPanel8.Controls.Add(pbRace);
        flowLayoutPanel8.Controls.Add(pbShip);
        flowLayoutPanel8.Controls.Add(pbFlag);
        flowLayoutPanel8.Location = new Point(6, 37);
        flowLayoutPanel8.Margin = new Padding(4, 3, 4, 3);
        flowLayoutPanel8.Name = "flowLayoutPanel8";
        flowLayoutPanel8.Size = new Size(1605, 205);
        flowLayoutPanel8.TabIndex = 152;
        // 
        // lstvKnownSpecies
        // 
        lstvKnownSpecies.BackColor = Color.FromArgb(0, 0, 64);
        lstvKnownSpecies.BorderStyle = BorderStyle.FixedSingle;
        lstvKnownSpecies.Columns.AddRange(new ColumnHeader[] { columnHeader_2, columnHeader_3, columnHeader_10 });
        lstvKnownSpecies.ForeColor = Color.FromArgb(255, 255, 192);
        lstvKnownSpecies.HeaderStyle = ColumnHeaderStyle.None;
        lstvKnownSpecies.Location = new Point(262, 7);
        lstvKnownSpecies.Margin = new Padding(0, 3, 0, 3);
        lstvKnownSpecies.Name = "lstvKnownSpecies";
        lstvKnownSpecies.Size = new Size(315, 202);
        lstvKnownSpecies.TabIndex = 163;
        lstvKnownSpecies.UseCompatibleStateImageBehavior = false;
        lstvKnownSpecies.View = View.Details;
        // 
        // columnHeader_2
        // 
        columnHeader_2.Width = 100;
        // 
        // columnHeader_3
        // 
        columnHeader_3.TextAlign = HorizontalAlignment.Right;
        columnHeader_3.Width = 80;
        // 
        // columnHeader_10
        // 
        columnHeader_10.TextAlign = HorizontalAlignment.Right;
        columnHeader_10.Width = 80;
        // 
        // cmdRename
        // 
        cmdRename.BackColor = Color.FromArgb(0, 0, 64);
        cmdRename.ForeColor = Color.FromArgb(255, 255, 192);
        cmdRename.Location = new Point(112, 0);
        cmdRename.Margin = new Padding(0);
        cmdRename.Name = "cmdRename";
        cmdRename.Size = new Size(112, 35);
        cmdRename.TabIndex = 153;
        cmdRename.Tag = "1200";
        cmdRename.Text = "Rename Race";
        cmdRename.UseVisualStyleBackColor = false;
        cmdRename.Click += cmdRename_Click;
        // 
        // lstvAlienShips
        // 
        lstvAlienShips.BackColor = Color.FromArgb(0, 0, 64);
        lstvAlienShips.BorderStyle = BorderStyle.None;
        lstvAlienShips.Columns.AddRange(new ColumnHeader[] { columnHeader_4, columnHeader_5, columnHeader_6 });
        lstvAlienShips.ForeColor = Color.FromArgb(255, 255, 192);
        lstvAlienShips.HeaderStyle = ColumnHeaderStyle.None;
        lstvAlienShips.Location = new Point(0, 27);
        lstvAlienShips.Margin = new Padding(0, 7, 0, 3);
        lstvAlienShips.Name = "lstvAlienShips";
        lstvAlienShips.Size = new Size(447, 553);
        lstvAlienShips.TabIndex = 166;
        lstvAlienShips.UseCompatibleStateImageBehavior = false;
        lstvAlienShips.View = View.Details;
        lstvAlienShips.SelectedIndexChanged += lstvAlienShips_SelectedIndexChanged;
        // 
        // columnHeader_4
        // 
        columnHeader_4.Width = 130;
        // 
        // columnHeader_5
        // 
        columnHeader_5.Width = 110;
        // 
        // columnHeader_6
        // 
        columnHeader_6.Width = 120;
        // 
        // flowLayoutPanel9
        // 
        flowLayoutPanel9.BorderStyle = BorderStyle.FixedSingle;
        flowLayoutPanel9.Controls.Add(label5);
        flowLayoutPanel9.Controls.Add(lstvAlienShips);
        flowLayoutPanel9.Location = new Point(769, 7);
        flowLayoutPanel9.Margin = new Padding(4, 3, 4, 3);
        flowLayoutPanel9.Name = "flowLayoutPanel9";
        flowLayoutPanel9.Size = new Size(448, 584);
        flowLayoutPanel9.TabIndex = 171;
        // 
        // label5
        // 
        label5.Location = new Point(0, 0);
        label5.Margin = new Padding(0, 0, 4, 0);
        label5.Name = "label5";
        label5.Size = new Size(491, 20);
        label5.TabIndex = 155;
        label5.Text = "Last Location for Known Ships of Selected Class";
        label5.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // flowLayoutPanel11
        // 
        flowLayoutPanel11.BorderStyle = BorderStyle.FixedSingle;
        flowLayoutPanel11.Controls.Add(label9);
        flowLayoutPanel11.Controls.Add(lstvWeapons);
        flowLayoutPanel11.Controls.Add(lblExtras);
        flowLayoutPanel11.Controls.Add(lstvKnownSensors);
        flowLayoutPanel11.Controls.Add(label10);
        flowLayoutPanel11.Controls.Add(lstvTechnology);
        flowLayoutPanel11.Location = new Point(345, 7);
        flowLayoutPanel11.Margin = new Padding(4, 3, 4, 3);
        flowLayoutPanel11.Name = "flowLayoutPanel11";
        flowLayoutPanel11.Size = new Size(416, 432);
        flowLayoutPanel11.TabIndex = 172;
        // 
        // label9
        // 
        label9.Location = new Point(4, 0);
        label9.Margin = new Padding(4, 0, 4, 0);
        label9.Name = "label9";
        label9.Size = new Size(407, 20);
        label9.TabIndex = 161;
        label9.Text = "Observed Weapons";
        label9.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // lstvWeapons
        // 
        lstvWeapons.BackColor = Color.FromArgb(0, 0, 64);
        lstvWeapons.BorderStyle = BorderStyle.None;
        lstvWeapons.Columns.AddRange(new ColumnHeader[] { columnHeader_12, columnHeader_13, columnHeader_14, columnHeader_15 });
        lstvWeapons.ForeColor = Color.FromArgb(255, 255, 192);
        lstvWeapons.HeaderStyle = ColumnHeaderStyle.None;
        lstvWeapons.Location = new Point(0, 27);
        lstvWeapons.Margin = new Padding(0, 7, 0, 3);
        lstvWeapons.Name = "lstvWeapons";
        lstvWeapons.Size = new Size(415, 114);
        lstvWeapons.TabIndex = 160;
        lstvWeapons.UseCompatibleStateImageBehavior = false;
        lstvWeapons.View = View.Details;
        // 
        // columnHeader_12
        // 
        columnHeader_12.TextAlign = HorizontalAlignment.Center;
        columnHeader_12.Width = 130;
        // 
        // columnHeader_13
        // 
        columnHeader_13.TextAlign = HorizontalAlignment.Center;
        columnHeader_13.Width = 70;
        // 
        // columnHeader_14
        // 
        columnHeader_14.TextAlign = HorizontalAlignment.Center;
        columnHeader_14.Width = 70;
        // 
        // columnHeader_15
        // 
        columnHeader_15.TextAlign = HorizontalAlignment.Center;
        // 
        // lblExtras
        // 
        lblExtras.Location = new Point(4, 144);
        lblExtras.Margin = new Padding(4, 0, 4, 0);
        lblExtras.Name = "lblExtras";
        lblExtras.Size = new Size(407, 20);
        lblExtras.TabIndex = 157;
        lblExtras.Text = "Observed Sensors";
        lblExtras.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // lstvKnownSensors
        // 
        lstvKnownSensors.BackColor = Color.FromArgb(0, 0, 64);
        lstvKnownSensors.BorderStyle = BorderStyle.None;
        lstvKnownSensors.Columns.AddRange(new ColumnHeader[] { columnHeader_9, columnHeader_16, columnHeader_17 });
        lstvKnownSensors.ForeColor = Color.FromArgb(255, 255, 192);
        lstvKnownSensors.HeaderStyle = ColumnHeaderStyle.None;
        lstvKnownSensors.Location = new Point(0, 171);
        lstvKnownSensors.Margin = new Padding(0, 7, 0, 3);
        lstvKnownSensors.Name = "lstvKnownSensors";
        lstvKnownSensors.Size = new Size(415, 90);
        lstvKnownSensors.TabIndex = 158;
        lstvKnownSensors.UseCompatibleStateImageBehavior = false;
        lstvKnownSensors.View = View.Details;
        // 
        // columnHeader_9
        // 
        columnHeader_9.TextAlign = HorizontalAlignment.Center;
        columnHeader_9.Width = 160;
        // 
        // columnHeader_16
        // 
        columnHeader_16.TextAlign = HorizontalAlignment.Center;
        columnHeader_16.Width = 90;
        // 
        // columnHeader_17
        // 
        columnHeader_17.TextAlign = HorizontalAlignment.Center;
        columnHeader_17.Width = 70;
        // 
        // label10
        // 
        label10.Location = new Point(4, 264);
        label10.Margin = new Padding(4, 0, 4, 0);
        label10.Name = "label10";
        label10.Size = new Size(407, 20);
        label10.TabIndex = 162;
        label10.Text = "Observed Technology";
        label10.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // lstvTechnology
        // 
        lstvTechnology.BackColor = Color.FromArgb(0, 0, 64);
        lstvTechnology.BorderStyle = BorderStyle.None;
        lstvTechnology.Columns.AddRange(new ColumnHeader[] { columnHeader_11 });
        lstvTechnology.ForeColor = Color.FromArgb(255, 255, 192);
        lstvTechnology.HeaderStyle = ColumnHeaderStyle.None;
        lstvTechnology.Location = new Point(0, 291);
        lstvTechnology.Margin = new Padding(0, 7, 0, 3);
        lstvTechnology.Name = "lstvTechnology";
        lstvTechnology.Size = new Size(415, 141);
        lstvTechnology.TabIndex = 159;
        lstvTechnology.UseCompatibleStateImageBehavior = false;
        lstvTechnology.View = View.Details;
        // 
        // columnHeader_11
        // 
        columnHeader_11.TextAlign = HorizontalAlignment.Center;
        columnHeader_11.Width = 330;
        // 
        // label7
        // 
        label7.Location = new Point(0, 0);
        label7.Margin = new Padding(0, 0, 4, 0);
        label7.Name = "label7";
        label7.Size = new Size(338, 20);
        label7.TabIndex = 155;
        label7.Text = "Selected Class Observed Attributes";
        label7.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // lstvClassDetails
        // 
        lstvClassDetails.BackColor = Color.FromArgb(0, 0, 64);
        lstvClassDetails.BorderStyle = BorderStyle.None;
        lstvClassDetails.Columns.AddRange(new ColumnHeader[] { columnHeader_7, columnHeader_8 });
        lstvClassDetails.ForeColor = Color.FromArgb(255, 255, 192);
        lstvClassDetails.HeaderStyle = ColumnHeaderStyle.None;
        lstvClassDetails.Location = new Point(0, 27);
        lstvClassDetails.Margin = new Padding(0, 7, 0, 3);
        lstvClassDetails.Name = "lstvClassDetails";
        lstvClassDetails.Size = new Size(338, 405);
        lstvClassDetails.TabIndex = 156;
        lstvClassDetails.UseCompatibleStateImageBehavior = false;
        lstvClassDetails.View = View.Details;
        // 
        // columnHeader_7
        // 
        columnHeader_7.Width = 185;
        // 
        // columnHeader_8
        // 
        columnHeader_8.TextAlign = HorizontalAlignment.Right;
        columnHeader_8.Width = 100;
        // 
        // cmdHull
        // 
        cmdHull.BackColor = Color.FromArgb(0, 0, 64);
        cmdHull.ForeColor = Color.FromArgb(255, 255, 192);
        cmdHull.Location = new Point(112, 0);
        cmdHull.Margin = new Padding(0);
        cmdHull.Name = "cmdHull";
        cmdHull.Size = new Size(112, 35);
        cmdHull.TabIndex = 173;
        cmdHull.Tag = "1200";
        cmdHull.Text = "Set Class Hull";
        cmdHull.UseVisualStyleBackColor = false;
        cmdHull.Click += cmdHull_Click;
        // 
        // txtSummary
        // 
        txtSummary.BackColor = Color.FromArgb(0, 0, 64);
        txtSummary.BorderStyle = BorderStyle.FixedSingle;
        txtSummary.ForeColor = Color.FromArgb(255, 255, 192);
        txtSummary.Location = new Point(5, 447);
        txtSummary.Margin = new Padding(4, 3, 4, 3);
        txtSummary.Multiline = true;
        txtSummary.Name = "txtSummary";
        txtSummary.ReadOnly = true;
        txtSummary.Size = new Size(757, 217);
        txtSummary.TabIndex = 174;
        txtSummary.Text = "No Class Summary Available";
        // 
        // cmdChangeDR
        // 
        cmdChangeDR.BackColor = Color.FromArgb(0, 0, 64);
        cmdChangeDR.ForeColor = Color.FromArgb(255, 255, 192);
        cmdChangeDR.Location = new Point(672, 0);
        cmdChangeDR.Margin = new Padding(0);
        cmdChangeDR.Name = "cmdChangeDR";
        cmdChangeDR.Size = new Size(112, 35);
        cmdChangeDR.TabIndex = 175;
        cmdChangeDR.Tag = "1200";
        cmdChangeDR.Text = "SM Set DR";
        cmdChangeDR.UseVisualStyleBackColor = false;
        cmdChangeDR.Click += cmdChangeDR_Click;
        // 
        // flowLayoutPanel12
        // 
        flowLayoutPanel12.Controls.Add(cmdCommunicate);
        flowLayoutPanel12.Controls.Add(cmdRename);
        flowLayoutPanel12.Controls.Add(cmdAutoName);
        flowLayoutPanel12.Controls.Add(cmdSelectName);
        flowLayoutPanel12.Controls.Add(cmdDestroyShip);
        flowLayoutPanel12.Controls.Add(cmdCorrectNames);
        flowLayoutPanel12.Controls.Add(cmdChangeDR);
        flowLayoutPanel12.Controls.Add(cmdToggleFixed);
        flowLayoutPanel12.Controls.Add(cmdSetComm);
        flowLayoutPanel12.Controls.Add(cmdAddSpecies);
        flowLayoutPanel12.Controls.Add(cmdSMRaceName);
        flowLayoutPanel12.Controls.Add(cmdSpeciesImage);
        flowLayoutPanel12.Controls.Add(cmdRaceFlag);
        flowLayoutPanel12.Controls.Add(cmdChangeHull);
        flowLayoutPanel12.Location = new Point(6, 947);
        flowLayoutPanel12.Margin = new Padding(4, 3, 4, 3);
        flowLayoutPanel12.Name = "flowLayoutPanel12";
        flowLayoutPanel12.Size = new Size(1602, 35);
        flowLayoutPanel12.TabIndex = 176;
        // 
        // cmdAutoName
        // 
        cmdAutoName.BackColor = Color.FromArgb(0, 0, 64);
        cmdAutoName.ForeColor = Color.FromArgb(255, 255, 192);
        cmdAutoName.Location = new Point(224, 0);
        cmdAutoName.Margin = new Padding(0);
        cmdAutoName.Name = "cmdAutoName";
        cmdAutoName.Size = new Size(112, 35);
        cmdAutoName.TabIndex = 182;
        cmdAutoName.Tag = "1200";
        cmdAutoName.Text = "Auto Class Name";
        cmdAutoName.UseVisualStyleBackColor = false;
        cmdAutoName.Click += cmdAutoName_Click;
        // 
        // cmdSelectName
        // 
        cmdSelectName.BackColor = Color.FromArgb(0, 0, 64);
        cmdSelectName.ForeColor = Color.FromArgb(255, 255, 192);
        cmdSelectName.Location = new Point(336, 0);
        cmdSelectName.Margin = new Padding(0);
        cmdSelectName.Name = "cmdSelectName";
        cmdSelectName.Size = new Size(112, 35);
        cmdSelectName.TabIndex = 183;
        cmdSelectName.Tag = "1200";
        cmdSelectName.Text = "Select Name";
        cmdSelectName.UseVisualStyleBackColor = false;
        cmdSelectName.Click += cmdSelectName_Click;
        // 
        // cmdDestroyShip
        // 
        cmdDestroyShip.BackColor = Color.FromArgb(0, 0, 64);
        cmdDestroyShip.ForeColor = Color.FromArgb(255, 255, 192);
        cmdDestroyShip.Location = new Point(448, 0);
        cmdDestroyShip.Margin = new Padding(0);
        cmdDestroyShip.Name = "cmdDestroyShip";
        cmdDestroyShip.Size = new Size(112, 35);
        cmdDestroyShip.TabIndex = 179;
        cmdDestroyShip.Tag = "1200";
        cmdDestroyShip.Text = "Flag Destroyed";
        cmdDestroyShip.UseVisualStyleBackColor = false;
        cmdDestroyShip.Click += cmdDestroyShip_Click;
        // 
        // cmdCorrectNames
        // 
        cmdCorrectNames.BackColor = Color.FromArgb(0, 0, 64);
        cmdCorrectNames.ForeColor = Color.FromArgb(255, 255, 192);
        cmdCorrectNames.Location = new Point(560, 0);
        cmdCorrectNames.Margin = new Padding(0);
        cmdCorrectNames.Name = "cmdCorrectNames";
        cmdCorrectNames.Size = new Size(112, 35);
        cmdCorrectNames.TabIndex = 184;
        cmdCorrectNames.Tag = "1200";
        cmdCorrectNames.Text = "Correct Names";
        cmdCorrectNames.UseVisualStyleBackColor = false;
        cmdCorrectNames.Click += cmdCorrectNames_Click;
        // 
        // cmdToggleFixed
        // 
        cmdToggleFixed.BackColor = Color.FromArgb(0, 0, 64);
        cmdToggleFixed.ForeColor = Color.FromArgb(255, 255, 192);
        cmdToggleFixed.Location = new Point(784, 0);
        cmdToggleFixed.Margin = new Padding(0);
        cmdToggleFixed.Name = "cmdToggleFixed";
        cmdToggleFixed.Size = new Size(112, 35);
        cmdToggleFixed.TabIndex = 177;
        cmdToggleFixed.Tag = "1200";
        cmdToggleFixed.Text = "SM Fixed DR";
        cmdToggleFixed.UseVisualStyleBackColor = false;
        cmdToggleFixed.Click += cmdToggleFixed_Click;
        // 
        // cmdSetComm
        // 
        cmdSetComm.BackColor = Color.FromArgb(0, 0, 64);
        cmdSetComm.ForeColor = Color.FromArgb(255, 255, 192);
        cmdSetComm.Location = new Point(896, 0);
        cmdSetComm.Margin = new Padding(0);
        cmdSetComm.Name = "cmdSetComm";
        cmdSetComm.Size = new Size(112, 35);
        cmdSetComm.TabIndex = 178;
        cmdSetComm.Tag = "1200";
        cmdSetComm.Text = "SM Est. Comm";
        cmdSetComm.UseVisualStyleBackColor = false;
        cmdSetComm.Click += cmdSetComm_Click;
        // 
        // cmdAddSpecies
        // 
        cmdAddSpecies.BackColor = Color.FromArgb(0, 0, 64);
        cmdAddSpecies.ForeColor = Color.FromArgb(255, 255, 192);
        cmdAddSpecies.Location = new Point(1008, 0);
        cmdAddSpecies.Margin = new Padding(0);
        cmdAddSpecies.Name = "cmdAddSpecies";
        cmdAddSpecies.Size = new Size(112, 35);
        cmdAddSpecies.TabIndex = 185;
        cmdAddSpecies.Tag = "1200";
        cmdAddSpecies.Text = "SM Add Species";
        cmdAddSpecies.UseVisualStyleBackColor = false;
        cmdAddSpecies.Click += cmdAddSpecies_Click;
        // 
        // cmdSMRaceName
        // 
        cmdSMRaceName.BackColor = Color.FromArgb(0, 0, 64);
        cmdSMRaceName.ForeColor = Color.FromArgb(255, 255, 192);
        cmdSMRaceName.Location = new Point(1120, 0);
        cmdSMRaceName.Margin = new Padding(0);
        cmdSMRaceName.Name = "cmdSMRaceName";
        cmdSMRaceName.Size = new Size(111, 35);
        cmdSMRaceName.TabIndex = 189;
        cmdSMRaceName.Tag = "1200";
        cmdSMRaceName.Text = "SM Race Title";
        cmdSMRaceName.UseVisualStyleBackColor = false;
        cmdSMRaceName.Click += cmdSMRaceName_Click;
        // 
        // cmdSpeciesImage
        // 
        cmdSpeciesImage.BackColor = Color.FromArgb(0, 0, 64);
        cmdSpeciesImage.ForeColor = Color.FromArgb(255, 255, 192);
        cmdSpeciesImage.Location = new Point(1231, 0);
        cmdSpeciesImage.Margin = new Padding(0);
        cmdSpeciesImage.Name = "cmdSpeciesImage";
        cmdSpeciesImage.Size = new Size(111, 35);
        cmdSpeciesImage.TabIndex = 186;
        cmdSpeciesImage.Tag = "1200";
        cmdSpeciesImage.Text = "SM Image";
        cmdSpeciesImage.UseVisualStyleBackColor = false;
        cmdSpeciesImage.Click += cmdSpeciesImage_Click;
        // 
        // cmdRaceFlag
        // 
        cmdRaceFlag.BackColor = Color.FromArgb(0, 0, 64);
        cmdRaceFlag.ForeColor = Color.FromArgb(255, 255, 192);
        cmdRaceFlag.Location = new Point(1342, 0);
        cmdRaceFlag.Margin = new Padding(0);
        cmdRaceFlag.Name = "cmdRaceFlag";
        cmdRaceFlag.Size = new Size(111, 35);
        cmdRaceFlag.TabIndex = 187;
        cmdRaceFlag.Tag = "1200";
        cmdRaceFlag.Text = "SM Flag";
        cmdRaceFlag.UseVisualStyleBackColor = false;
        cmdRaceFlag.Click += cmdRaceFlag_Click;
        // 
        // cmdChangeHull
        // 
        cmdChangeHull.BackColor = Color.FromArgb(0, 0, 64);
        cmdChangeHull.ForeColor = Color.FromArgb(255, 255, 192);
        cmdChangeHull.Location = new Point(1453, 0);
        cmdChangeHull.Margin = new Padding(0);
        cmdChangeHull.Name = "cmdChangeHull";
        cmdChangeHull.Size = new Size(111, 35);
        cmdChangeHull.TabIndex = 188;
        cmdChangeHull.Tag = "1200";
        cmdChangeHull.Text = "SM Hull";
        cmdChangeHull.UseVisualStyleBackColor = false;
        cmdChangeHull.Click += cmdChangeHull_Click;
        // 
        // cmdRenameShip
        // 
        cmdRenameShip.BackColor = Color.FromArgb(0, 0, 64);
        cmdRenameShip.ForeColor = Color.FromArgb(255, 255, 192);
        cmdRenameShip.Location = new Point(224, 0);
        cmdRenameShip.Margin = new Padding(0);
        cmdRenameShip.Name = "cmdRenameShip";
        cmdRenameShip.Size = new Size(112, 35);
        cmdRenameShip.TabIndex = 180;
        cmdRenameShip.Tag = "1200";
        cmdRenameShip.Text = "Rename Ship";
        cmdRenameShip.UseVisualStyleBackColor = false;
        cmdRenameShip.Click += cmdRenameShip_Click;
        // 
        // cmdRenumber
        // 
        cmdRenumber.BackColor = Color.FromArgb(0, 0, 64);
        cmdRenumber.ForeColor = Color.FromArgb(255, 255, 192);
        cmdRenumber.Location = new Point(336, 0);
        cmdRenumber.Margin = new Padding(0);
        cmdRenumber.Name = "cmdRenumber";
        cmdRenumber.Size = new Size(112, 35);
        cmdRenumber.TabIndex = 181;
        cmdRenumber.Tag = "1200";
        cmdRenumber.Text = "Renumber Ships";
        cmdRenumber.UseVisualStyleBackColor = false;
        cmdRenumber.Click += cmdRenumber_Click;
        // 
        // cmdRenameClass
        // 
        cmdRenameClass.BackColor = Color.FromArgb(0, 0, 64);
        cmdRenameClass.ForeColor = Color.FromArgb(255, 255, 192);
        cmdRenameClass.Location = new Point(0, 0);
        cmdRenameClass.Margin = new Padding(0);
        cmdRenameClass.Name = "cmdRenameClass";
        cmdRenameClass.Size = new Size(112, 35);
        cmdRenameClass.TabIndex = 176;
        cmdRenameClass.Tag = "1200";
        cmdRenameClass.Text = "Rename Class";
        cmdRenameClass.UseVisualStyleBackColor = false;
        cmdRenameClass.Click += cmdRenameClass_Click;
        // 
        // tabIntelligence
        // 
        tabIntelligence.Controls.Add(tabClass);
        tabIntelligence.Controls.Add(tabPopulation);
        tabIntelligence.Controls.Add(tabSpecies);
        tabIntelligence.Controls.Add(tabGroundUnits);
        tabIntelligence.Controls.Add(tabKnownSystems);
        tabIntelligence.Controls.Add(tabSensor);
        tabIntelligence.Location = new Point(382, 246);
        tabIntelligence.Margin = new Padding(4, 3, 4, 3);
        tabIntelligence.Name = "tabIntelligence";
        tabIntelligence.SelectedIndex = 0;
        tabIntelligence.Size = new Size(1230, 698);
        tabIntelligence.TabIndex = 167;
        // 
        // tabClass
        // 
        tabClass.BackColor = Color.FromArgb(0, 0, 64);
        tabClass.Controls.Add(flowLayoutPanel4);
        tabClass.Controls.Add(flowLayoutPanel14);
        tabClass.Controls.Add(flowLayoutPanel11);
        tabClass.Controls.Add(flowLayoutPanel9);
        tabClass.Controls.Add(txtSummary);
        tabClass.Location = new Point(4, 24);
        tabClass.Margin = new Padding(4, 3, 4, 3);
        tabClass.Name = "tabClass";
        tabClass.Padding = new Padding(4, 3, 4, 3);
        tabClass.Size = new Size(1222, 670);
        tabClass.TabIndex = 0;
        tabClass.Text = "Known Class";
        // 
        // flowLayoutPanel4
        // 
        flowLayoutPanel4.Controls.Add(cmdRenameClass);
        flowLayoutPanel4.Controls.Add(cmdHull);
        flowLayoutPanel4.Controls.Add(cmdRenameShip);
        flowLayoutPanel4.Controls.Add(cmdRenumber);
        flowLayoutPanel4.Controls.Add(cmdText);
        flowLayoutPanel4.Controls.Add(cmdClearClassData);
        flowLayoutPanel4.Controls.Add(cmdDeleteClass);
        flowLayoutPanel4.Location = new Point(769, 594);
        flowLayoutPanel4.Margin = new Padding(4, 3, 4, 3);
        flowLayoutPanel4.Name = "flowLayoutPanel4";
        flowLayoutPanel4.Size = new Size(448, 69);
        flowLayoutPanel4.TabIndex = 186;
        // 
        // cmdText
        // 
        cmdText.BackColor = Color.FromArgb(0, 0, 64);
        cmdText.ForeColor = Color.FromArgb(255, 255, 192);
        cmdText.Location = new Point(0, 35);
        cmdText.Margin = new Padding(0);
        cmdText.Name = "cmdText";
        cmdText.Size = new Size(112, 35);
        cmdText.TabIndex = 187;
        cmdText.Tag = "1200";
        cmdText.Text = "All Class Text";
        cmdText.UseVisualStyleBackColor = false;
        cmdText.Click += cmdText_Click;
        // 
        // cmdClearClassData
        // 
        cmdClearClassData.BackColor = Color.FromArgb(0, 0, 64);
        cmdClearClassData.ForeColor = Color.FromArgb(255, 255, 192);
        cmdClearClassData.Location = new Point(112, 35);
        cmdClearClassData.Margin = new Padding(0);
        cmdClearClassData.Name = "cmdClearClassData";
        cmdClearClassData.Size = new Size(112, 35);
        cmdClearClassData.TabIndex = 186;
        cmdClearClassData.Tag = "1200";
        cmdClearClassData.Text = "Clear Data";
        cmdClearClassData.UseVisualStyleBackColor = false;
        cmdClearClassData.Click += cmdClearClassData_Click;
        // 
        // cmdDeleteClass
        // 
        cmdDeleteClass.BackColor = Color.FromArgb(0, 0, 64);
        cmdDeleteClass.ForeColor = Color.FromArgb(255, 255, 192);
        cmdDeleteClass.Location = new Point(224, 35);
        cmdDeleteClass.Margin = new Padding(0);
        cmdDeleteClass.Name = "cmdDeleteClass";
        cmdDeleteClass.Size = new Size(112, 35);
        cmdDeleteClass.TabIndex = 185;
        cmdDeleteClass.Tag = "1200";
        cmdDeleteClass.Text = "Delete Class";
        cmdDeleteClass.UseVisualStyleBackColor = false;
        cmdDeleteClass.Click += cmdDeleteClass_Click;
        // 
        // flowLayoutPanel14
        // 
        flowLayoutPanel14.BorderStyle = BorderStyle.FixedSingle;
        flowLayoutPanel14.Controls.Add(label7);
        flowLayoutPanel14.Controls.Add(lstvClassDetails);
        flowLayoutPanel14.Location = new Point(2, 7);
        flowLayoutPanel14.Margin = new Padding(4, 3, 4, 3);
        flowLayoutPanel14.Name = "flowLayoutPanel14";
        flowLayoutPanel14.Size = new Size(338, 432);
        flowLayoutPanel14.TabIndex = 179;
        // 
        // tabPopulation
        // 
        tabPopulation.BackColor = Color.FromArgb(0, 0, 64);
        tabPopulation.Controls.Add(lstvPopulation);
        tabPopulation.Location = new Point(4, 24);
        tabPopulation.Margin = new Padding(4, 3, 4, 3);
        tabPopulation.Name = "tabPopulation";
        tabPopulation.Padding = new Padding(4, 3, 4, 3);
        tabPopulation.Size = new Size(1222, 670);
        tabPopulation.TabIndex = 1;
        tabPopulation.Text = "Known Population";
        // 
        // lstvPopulation
        // 
        lstvPopulation.BackColor = Color.FromArgb(0, 0, 64);
        lstvPopulation.BorderStyle = BorderStyle.None;
        lstvPopulation.Columns.AddRange(new ColumnHeader[] { columnHeader_18, columnHeader_19 });
        lstvPopulation.ForeColor = Color.FromArgb(255, 255, 192);
        lstvPopulation.HeaderStyle = ColumnHeaderStyle.None;
        lstvPopulation.Location = new Point(4, 7);
        lstvPopulation.Margin = new Padding(0, 7, 0, 3);
        lstvPopulation.Name = "lstvPopulation";
        lstvPopulation.Size = new Size(514, 654);
        lstvPopulation.TabIndex = 167;
        lstvPopulation.UseCompatibleStateImageBehavior = false;
        lstvPopulation.View = View.Details;
        // 
        // columnHeader_18
        // 
        columnHeader_18.Width = 200;
        // 
        // columnHeader_19
        // 
        columnHeader_19.TextAlign = HorizontalAlignment.Right;
        columnHeader_19.Width = 120;
        // 
        // tabSpecies
        // 
        tabSpecies.BackColor = Color.FromArgb(0, 0, 64);
        tabSpecies.Controls.Add(pbSpecies);
        tabSpecies.Controls.Add(lstvKnownSpecies);
        tabSpecies.Location = new Point(4, 24);
        tabSpecies.Margin = new Padding(4, 3, 4, 3);
        tabSpecies.Name = "tabSpecies";
        tabSpecies.Padding = new Padding(4, 3, 4, 3);
        tabSpecies.Size = new Size(1222, 670);
        tabSpecies.TabIndex = 2;
        tabSpecies.Text = "Known Species";
        // 
        // pbSpecies
        // 
        pbSpecies.Anchor = AnchorStyles.None;
        pbSpecies.BorderStyle = BorderStyle.FixedSingle;
        pbSpecies.Location = new Point(8, 7);
        pbSpecies.Margin = new Padding(4, 3, 4, 3);
        pbSpecies.Name = "pbSpecies";
        pbSpecies.Size = new Size(250, 202);
        pbSpecies.SizeMode = PictureBoxSizeMode.StretchImage;
        pbSpecies.TabIndex = 164;
        pbSpecies.TabStop = false;
        // 
        // tabGroundUnits
        // 
        tabGroundUnits.BackColor = Color.FromArgb(0, 0, 64);
        tabGroundUnits.Controls.Add(cmdRenameUnit);
        tabGroundUnits.Controls.Add(lstvGroundUnitWeapons);
        tabGroundUnits.Controls.Add(lstvGroundUnitClassData);
        tabGroundUnits.Location = new Point(4, 24);
        tabGroundUnits.Margin = new Padding(4, 3, 4, 3);
        tabGroundUnits.Name = "tabGroundUnits";
        tabGroundUnits.Padding = new Padding(4, 3, 4, 3);
        tabGroundUnits.Size = new Size(1222, 670);
        tabGroundUnits.TabIndex = 3;
        tabGroundUnits.Text = "Ground Unit Classes";
        // 
        // cmdRenameUnit
        // 
        cmdRenameUnit.BackColor = Color.FromArgb(0, 0, 64);
        cmdRenameUnit.ForeColor = Color.FromArgb(255, 255, 192);
        cmdRenameUnit.Location = new Point(4, 270);
        cmdRenameUnit.Margin = new Padding(0);
        cmdRenameUnit.Name = "cmdRenameUnit";
        cmdRenameUnit.Size = new Size(112, 35);
        cmdRenameUnit.TabIndex = 177;
        cmdRenameUnit.Tag = "1200";
        cmdRenameUnit.Text = "Rename Unit";
        cmdRenameUnit.UseVisualStyleBackColor = false;
        cmdRenameUnit.Click += cmdRenameUnit_Click;
        // 
        // lstvGroundUnitWeapons
        // 
        lstvGroundUnitWeapons.BackColor = Color.FromArgb(0, 0, 64);
        lstvGroundUnitWeapons.BorderStyle = BorderStyle.FixedSingle;
        lstvGroundUnitWeapons.Columns.AddRange(new ColumnHeader[] { columnHeader_22, columnHeader_23, columnHeader_24, columnHeader_25 });
        lstvGroundUnitWeapons.ForeColor = Color.FromArgb(255, 255, 192);
        lstvGroundUnitWeapons.HeaderStyle = ColumnHeaderStyle.None;
        lstvGroundUnitWeapons.Location = new Point(412, 3);
        lstvGroundUnitWeapons.Margin = new Padding(0, 3, 0, 3);
        lstvGroundUnitWeapons.Name = "lstvGroundUnitWeapons";
        lstvGroundUnitWeapons.Size = new Size(403, 263);
        lstvGroundUnitWeapons.TabIndex = 165;
        lstvGroundUnitWeapons.UseCompatibleStateImageBehavior = false;
        lstvGroundUnitWeapons.View = View.Details;
        // 
        // columnHeader_22
        // 
        columnHeader_22.Width = 160;
        // 
        // columnHeader_23
        // 
        columnHeader_23.TextAlign = HorizontalAlignment.Center;
        // 
        // columnHeader_24
        // 
        columnHeader_24.TextAlign = HorizontalAlignment.Center;
        // 
        // columnHeader_25
        // 
        columnHeader_25.TextAlign = HorizontalAlignment.Center;
        // 
        // lstvGroundUnitClassData
        // 
        lstvGroundUnitClassData.BackColor = Color.FromArgb(0, 0, 64);
        lstvGroundUnitClassData.BorderStyle = BorderStyle.FixedSingle;
        lstvGroundUnitClassData.Columns.AddRange(new ColumnHeader[] { columnHeader_20, columnHeader_21 });
        lstvGroundUnitClassData.ForeColor = Color.FromArgb(255, 255, 192);
        lstvGroundUnitClassData.HeaderStyle = ColumnHeaderStyle.None;
        lstvGroundUnitClassData.Location = new Point(4, 3);
        lstvGroundUnitClassData.Margin = new Padding(0, 3, 0, 3);
        lstvGroundUnitClassData.Name = "lstvGroundUnitClassData";
        lstvGroundUnitClassData.Size = new Size(403, 263);
        lstvGroundUnitClassData.TabIndex = 164;
        lstvGroundUnitClassData.UseCompatibleStateImageBehavior = false;
        lstvGroundUnitClassData.View = View.Details;
        // 
        // columnHeader_20
        // 
        columnHeader_20.Width = 240;
        // 
        // columnHeader_21
        // 
        columnHeader_21.TextAlign = HorizontalAlignment.Right;
        columnHeader_21.Width = 100;
        // 
        // tabKnownSystems
        // 
        tabKnownSystems.BackColor = Color.FromArgb(0, 0, 64);
        tabKnownSystems.Controls.Add(lstvSystemSummary);
        tabKnownSystems.Controls.Add(cboStatus);
        tabKnownSystems.Controls.Add(tvContacts);
        tabKnownSystems.Location = new Point(4, 24);
        tabKnownSystems.Margin = new Padding(4, 3, 4, 3);
        tabKnownSystems.Name = "tabKnownSystems";
        tabKnownSystems.Padding = new Padding(4, 3, 4, 3);
        tabKnownSystems.Size = new Size(1222, 670);
        tabKnownSystems.TabIndex = 4;
        tabKnownSystems.Text = "Known System";
        // 
        // lstvSystemSummary
        // 
        lstvSystemSummary.BackColor = Color.FromArgb(0, 0, 64);
        lstvSystemSummary.BorderStyle = BorderStyle.FixedSingle;
        lstvSystemSummary.Columns.AddRange(new ColumnHeader[] { columnHeader_26, columnHeader_27 });
        lstvSystemSummary.ForeColor = Color.FromArgb(255, 255, 192);
        lstvSystemSummary.HeaderStyle = ColumnHeaderStyle.None;
        lstvSystemSummary.Location = new Point(411, 38);
        lstvSystemSummary.Margin = new Padding(0, 7, 0, 3);
        lstvSystemSummary.Name = "lstvSystemSummary";
        lstvSystemSummary.Size = new Size(278, 623);
        lstvSystemSummary.TabIndex = 157;
        lstvSystemSummary.UseCompatibleStateImageBehavior = false;
        lstvSystemSummary.View = View.Details;
        // 
        // columnHeader_26
        // 
        columnHeader_26.Width = 120;
        // 
        // columnHeader_27
        // 
        columnHeader_27.TextAlign = HorizontalAlignment.Right;
        columnHeader_27.Width = 110;
        // 
        // cboStatus
        // 
        cboStatus.BackColor = Color.FromArgb(0, 0, 64);
        cboStatus.ForeColor = Color.FromArgb(255, 255, 192);
        cboStatus.FormattingEnabled = true;
        cboStatus.Location = new Point(411, 7);
        cboStatus.Margin = new Padding(4, 3, 4, 0);
        cboStatus.Name = "cboStatus";
        cboStatus.Size = new Size(278, 23);
        cboStatus.TabIndex = 145;
        cboStatus.SelectedIndexChanged += cboStatus_SelectedIndexChanged;
        // 
        // tvContacts
        // 
        tvContacts.BackColor = Color.FromArgb(0, 0, 64);
        tvContacts.BorderStyle = BorderStyle.FixedSingle;
        tvContacts.ForeColor = Color.FromArgb(255, 255, 192);
        tvContacts.Location = new Point(7, 7);
        tvContacts.Margin = new Padding(4, 3, 4, 3);
        tvContacts.Name = "tvContacts";
        tvContacts.Size = new Size(396, 654);
        tvContacts.TabIndex = 29;
        // 
        // tabSensor
        // 
        tabSensor.BackColor = Color.FromArgb(0, 0, 64);
        tabSensor.Controls.Add(cndRenameSensor);
        tabSensor.Controls.Add(lstvMountingClasses);
        tabSensor.Location = new Point(4, 24);
        tabSensor.Margin = new Padding(4, 3, 4, 3);
        tabSensor.Name = "tabSensor";
        tabSensor.Padding = new Padding(4, 3, 4, 3);
        tabSensor.Size = new Size(1222, 670);
        tabSensor.TabIndex = 5;
        tabSensor.Text = "Known Sensor";
        // 
        // cndRenameSensor
        // 
        cndRenameSensor.BackColor = Color.FromArgb(0, 0, 64);
        cndRenameSensor.ForeColor = Color.FromArgb(255, 255, 192);
        cndRenameSensor.Location = new Point(5, 273);
        cndRenameSensor.Margin = new Padding(0);
        cndRenameSensor.Name = "cndRenameSensor";
        cndRenameSensor.Size = new Size(112, 35);
        cndRenameSensor.TabIndex = 177;
        cndRenameSensor.Tag = "1200";
        cndRenameSensor.Text = "Rename Sensor";
        cndRenameSensor.UseVisualStyleBackColor = false;
        cndRenameSensor.Click += cndRenameSensor_Click;
        // 
        // lstvMountingClasses
        // 
        lstvMountingClasses.BackColor = Color.FromArgb(0, 0, 64);
        lstvMountingClasses.BorderStyle = BorderStyle.FixedSingle;
        lstvMountingClasses.Columns.AddRange(new ColumnHeader[] { columnHeader_28 });
        lstvMountingClasses.ForeColor = Color.FromArgb(255, 255, 192);
        lstvMountingClasses.HeaderStyle = ColumnHeaderStyle.None;
        lstvMountingClasses.Location = new Point(4, 7);
        lstvMountingClasses.Margin = new Padding(0, 3, 0, 3);
        lstvMountingClasses.Name = "lstvMountingClasses";
        lstvMountingClasses.Size = new Size(403, 263);
        lstvMountingClasses.TabIndex = 165;
        lstvMountingClasses.UseCompatibleStateImageBehavior = false;
        lstvMountingClasses.View = View.Details;
        // 
        // columnHeader_28
        // 
        columnHeader_28.Width = 300;
        // 
        // tvIntelligence
        // 
        tvIntelligence.BackColor = Color.FromArgb(0, 0, 64);
        tvIntelligence.BorderStyle = BorderStyle.FixedSingle;
        tvIntelligence.ForeColor = Color.FromArgb(255, 255, 192);
        tvIntelligence.Location = new Point(6, 246);
        tvIntelligence.Margin = new Padding(0, 2, 0, 0);
        tvIntelligence.Name = "tvIntelligence";
        tvIntelligence.Size = new Size(370, 698);
        tvIntelligence.TabIndex = 178;
        tvIntelligence.AfterSelect += tvIntelligence_AfterSelect;
        // 
        // Diplomacy
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(0, 0, 64);
        ClientSize = new Size(1615, 985);
        Controls.Add(tvIntelligence);
        Controls.Add(tabIntelligence);
        Controls.Add(flowLayoutPanel12);
        Controls.Add(flowLayoutPanel8);
        Controls.Add(flowLayoutPanel7);
        ForeColor = Color.FromArgb(255, 255, 192);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        KeyPreview = true;
        Margin = new Padding(4, 3, 4, 3);
        Name = "Diplomacy";
        Text = "Intelligence and Foreign Relations";
        FormClosing += Diplomacy_FormClosing;
        Load += Diplomacy_Load;
        KeyDown += Diplomacy_KeyDown;
        ((ISupportInitialize)pbRace).EndInit();
        ((ISupportInitialize)pbShip).EndInit();
        ((ISupportInitialize)pbFlag).EndInit();
        flowLayoutPanel2.ResumeLayout(false);
        flowLayoutPanel2.PerformLayout();
        flowLayoutPanel1.ResumeLayout(false);
        flowLayoutPanel3.ResumeLayout(false);
        flowLayoutPanel3.PerformLayout();
        flowLayoutPanel7.ResumeLayout(false);
        flowLayoutPanel7.PerformLayout();
        flowLayoutPanel8.ResumeLayout(false);
        flowLayoutPanel9.ResumeLayout(false);
        flowLayoutPanel11.ResumeLayout(false);
        flowLayoutPanel12.ResumeLayout(false);
        tabIntelligence.ResumeLayout(false);
        tabClass.ResumeLayout(false);
        tabClass.PerformLayout();
        flowLayoutPanel4.ResumeLayout(false);
        flowLayoutPanel14.ResumeLayout(false);
        tabPopulation.ResumeLayout(false);
        tabSpecies.ResumeLayout(false);
        ((ISupportInitialize)pbSpecies).EndInit();
        tabGroundUnits.ResumeLayout(false);
        tabKnownSystems.ResumeLayout(false);
        tabSensor.ResumeLayout(false);
        ResumeLayout(false);
    }
}