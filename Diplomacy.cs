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
        public GClass115 gclass115_0;

        internal bool method_0(GClass117 gclass117_0)
        {
            return gclass117_0.gclass115_0 == this.gclass115_0 && !gclass117_0.bool_0;
        }
    }

    private sealed class Class895
    {
        public GClass115 gclass115_0;

        internal bool method_0(GClass117 gclass117_0)
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
    private FCTRaceRecordC21 gclass21_0;
    private AlienRaceInfo gclass110_0;
    private TreeNode treeNode_0;
    private bool bool_0;
    private IContainer icontainer_0;
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

    private void method_3(GClass115 gclass115_0)
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

    private void method_4(GClass114 gclass114_0)
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

    public void method_5(FCTRaceRecordC21 gclass21_1)
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
            this.gclass21_0 = (FCTRaceRecordC21)this.cboRaces.SelectedValue;
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
            this.gclass110_0 = (AlienRaceInfo)this.cboAlienRaces.SelectedValue;
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
            AlienRaceInfo gclass1100 = this.gclass110_0;
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
            this.gclass110_0.UseRealClassNames = AuroraUtils.smethod_29(this.chkReal.CheckState);
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
                $"{class894.gclass115_0.gclass21_1.dictionary_12.Values.Count<GClass117>(class894.method_0).ToString()}x {class894.gclass115_0.gclass76_0.Abbreviation} {class894.gclass115_0.ClassName}";
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 508);
        }
    }

    private GClass115 method_9()
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

            if (this.tvIntelligence.SelectedNode.Tag is GClass115)
                return (GClass115)this.tvIntelligence.SelectedNode.Tag;
            int num1 = (int)MessageBox.Show(" Please select an alien class");
            return null;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 509);
            return null;
        }
    }

    private GClass114 method_10()
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

            if (this.tvIntelligence.SelectedNode.Tag is GClass114)
                return (GClass114)this.tvIntelligence.SelectedNode.Tag;
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
            GClass115 gclass115_0 = this.method_9();
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
            GClass115 gclass115_0 = this.method_9();
            if (gclass115_0 == null)
                return;
            if (this.lstvAlienShips.SelectedItems.Count > 0)
            {
                GClass117 tag = (GClass117)this.lstvAlienShips.SelectedItems[0].Tag;
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
                    !(this.lstvAlienShips.SelectedItems[0].Tag is GClass117))
                    return;
                GClass117 tag = (GClass117)this.lstvAlienShips.SelectedItems[0].Tag;
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
            GClass115 gclass115_0 = this.method_9();
            if (gclass115_0 == null)
                return;
            if (this.lstvAlienShips.SelectedItems.Count > 0)
            {
                ((GClass117)this.lstvAlienShips.SelectedItems[0].Tag).bool_0 = true;
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
            List<GClass117> list = this.gclass21_0.dictionary_12.Values.Where<GClass117>(class895.method_0)
                .OrderBy<GClass117, Decimal>(gclass117_0 => gclass117_0.decimal_1).ToList<GClass117>();
            // ISSUE: reference to a compiler-generated field
            class895.gclass115_0.int_4 = list.Count;
            foreach (GClass117 gclass117 in list)
            {
                // ISSUE: reference to a compiler-generated field
                gclass117.string_0 = $"{class895.gclass115_0.ClassName} {AuroraUtils.smethod_33(int_72)}";
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
            GClass115 gclass115 = this.method_9();
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
            GClass115 gclass115 = this.method_9();
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
            foreach (GClass115 gclass115 in this.gclass21_0.dictionary_11.Values
                         .Where<GClass115>(gclass115_0 => gclass115_0.gclass110_0 == this.gclass110_0)
                         .ToList<GClass115>())
                gclass115.ClassName = gclass115.gclass22_0.ClassName;
            foreach (GClass117 gclass117 in this.gclass21_0.dictionary_12.Values
                         .Where<GClass117>(gclass117_0 => gclass117_0.gclass110_0 == this.gclass110_0)
                         .ToList<GClass117>())
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
            foreach (GClass194 gclass194 in this.gclass0_0.PopulationDataDictionary.Values
                         .Where<PopulationData>(gclass146_0 => gclass146_0.RaceData == this.gclass21_0)
                         .Select<PopulationData, GClass194>(gclass146_0 => gclass146_0.SpeciesData).Distinct<GClass194>()
                         .OrderBy<GClass194, string>(gclass194_0 => gclass194_0.SpeciesName).ToList<GClass194>())
                this.gclass0_0.list_32.Add(gclass194.SpeciesName);
            int num = (int)new UserSelection(this.gclass0_0).ShowDialog();
            if (this.gclass0_0.bool_21)
                return;
            this.gclass21_0.method_163(this.gclass110_0,
                this.gclass0_0.SpeciesDictionary.Values.FirstOrDefault<GClass194>(gclass194_0 =>
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
            if (treeNode_1.Tag is GClass115)
            {
                GClass115 tag = (GClass115)treeNode_1.Tag;
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
            else if (treeNode_1.Tag is GClass114)
            {
                GClass114 tag = (GClass114)treeNode_1.Tag;
                if (tag == null)
                    return;
                this.method_4(tag);
                this.tabIntelligence.SelectTab(this.tabGroundUnits);
            }
            else if (treeNode_1.Tag is GClass194)
            {
                GClass194 tag = (GClass194)treeNode_1.Tag;
                if (tag == null)
                    return;
                this.gclass21_0.method_27(this.lstvKnownSpecies, tag);
                this.tabIntelligence.SelectTab(this.tabSpecies);
            }
            else if (treeNode_1.Tag is GClass113)
            {
                GClass113 tag = (GClass113)treeNode_1.Tag;
                if (tag == null)
                    return;
                this.gclass21_0.method_28(this.lstvPopulation, tag);
                this.tabIntelligence.SelectTab(this.tabPopulation);
            }
            else
            {
                if (!(treeNode_1.Tag is GClass118))
                    return;
                GClass118 tag = (GClass118)treeNode_1.Tag;
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
            GClass115 gclass115 = this.method_9();
            if (gclass115 == null || MessageBox.Show($" Are you sure you want to delete {gclass115.ClassName}?",
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
            GClass115 gclass115 = this.method_9();
            if (gclass115 == null ||
                MessageBox.Show($" Are you sure you want to clear all data for {gclass115.ClassName}?",
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
            if (!this.gclass110_0.ActualAlienRace.IsNPR)
            {
                int num1 = (int)MessageBox.Show("Players can only change images for AI races");
            }
            else
            {
                GClass194 gclass194 = this.gclass110_0.ActualAlienRace.method_164();
                if (gclass194 == null)
                    return;
                string str = AuroraUtils.smethod_18("Races");
                if (str != "")
                {
                    int num2 = str.LastIndexOf("\\");
                    gclass194.string_0 = str.Substring(num2 + 1);
                }

                this.pbRace.Image = Image.FromFile($"{Application.StartupPath}\\Races\\{gclass194.string_0}");
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
            if (!this.gclass110_0.ActualAlienRace.IsNPR)
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
                    Image.FromFile($"{Application.StartupPath}\\Flags\\{this.gclass110_0.ActualAlienRace.FlagPic}");
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
            if (!this.gclass110_0.ActualAlienRace.IsNPR)
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
                    Image.FromFile($"{Application.StartupPath}\\ShipIcons\\{this.gclass110_0.ActualAlienRace.HullPic}");
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
            GClass114 gclass114 = this.method_10();
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
            if (!this.gclass110_0.ActualAlienRace.IsNPR)
            {
                int num1 = (int)MessageBox.Show("Players can only change names for AI races");
            }
            else
            {
                GClass194 gclass194 = this.gclass110_0.ActualAlienRace.method_164();
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
            this.gclass110_0.RandomNameOrder = AuroraUtils.smethod_29(this.chkAlienNameRandom.CheckState);
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
            else if (this.tvIntelligence.SelectedNode.Tag is GClass118)
            {
                GClass118 tag = (GClass118)this.tvIntelligence.SelectedNode.Tag;
                string str = this.gclass0_0.method_562("Enter New Alien Sensor Name", tag.string_0);
                if (str != "")
                    tag.string_0 = str;
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

    protected override void Dispose(bool disposing)
    {
        if (disposing && this.icontainer_0 != null)
            this.icontainer_0.Dispose();
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        this.pbRace = new PictureBox();
        this.pbShip = new PictureBox();
        this.pbFlag = new PictureBox();
        this.cboRaces = new ComboBox();
        this.cboAlienRaces = new ComboBox();
        this.flowLayoutPanel2 = new FlowLayoutPanel();
        this.rdoHostile = new RadioButton();
        this.rdoNeutral = new RadioButton();
        this.rdoFriendly = new RadioButton();
        this.rdoAllied = new RadioButton();
        this.flowLayoutPanel1 = new FlowLayoutPanel();
        this.flowLayoutPanel3 = new FlowLayoutPanel();
        this.chkTrade = new CheckBox();
        this.chkGeo = new CheckBox();
        this.chkGrav = new CheckBox();
        this.chkResearch = new CheckBox();
        this.cmdCommunicate = new Button();
        this.lstvStatus = new ListView();
        this.columnHeader_0 = new ColumnHeader();
        this.columnHeader_1 = new ColumnHeader();
        this.flowLayoutPanel7 = new FlowLayoutPanel();
        this.label28 = new Label();
        this.txtAbbreviation = new TextBox();
        this.label2 = new Label();
        this.lblRaceIntelligence = new Label();
        this.label1 = new Label();
        this.cboTheme = new ComboBox();
        this.chkReal = new CheckBox();
        this.chkAlienNameRandom = new CheckBox();
        this.flowLayoutPanel8 = new FlowLayoutPanel();
        this.lstvKnownSpecies = new ListView();
        this.columnHeader_2 = new ColumnHeader();
        this.columnHeader_3 = new ColumnHeader();
        this.columnHeader_10 = new ColumnHeader();
        this.cmdRename = new Button();
        this.lstvAlienShips = new ListView();
        this.columnHeader_4 = new ColumnHeader();
        this.columnHeader_5 = new ColumnHeader();
        this.columnHeader_6 = new ColumnHeader();
        this.flowLayoutPanel9 = new FlowLayoutPanel();
        this.label5 = new Label();
        this.flowLayoutPanel11 = new FlowLayoutPanel();
        this.label9 = new Label();
        this.lstvWeapons = new ListView();
        this.columnHeader_12 = new ColumnHeader();
        this.columnHeader_13 = new ColumnHeader();
        this.columnHeader_14 = new ColumnHeader();
        this.columnHeader_15 = new ColumnHeader();
        this.lblExtras = new Label();
        this.lstvKnownSensors = new ListView();
        this.columnHeader_9 = new ColumnHeader();
        this.columnHeader_16 = new ColumnHeader();
        this.columnHeader_17 = new ColumnHeader();
        this.label10 = new Label();
        this.lstvTechnology = new ListView();
        this.columnHeader_11 = new ColumnHeader();
        this.label7 = new Label();
        this.lstvClassDetails = new ListView();
        this.columnHeader_7 = new ColumnHeader();
        this.columnHeader_8 = new ColumnHeader();
        this.cmdHull = new Button();
        this.txtSummary = new TextBox();
        this.cmdChangeDR = new Button();
        this.flowLayoutPanel12 = new FlowLayoutPanel();
        this.cmdAutoName = new Button();
        this.cmdSelectName = new Button();
        this.cmdDestroyShip = new Button();
        this.cmdCorrectNames = new Button();
        this.cmdToggleFixed = new Button();
        this.cmdSetComm = new Button();
        this.cmdAddSpecies = new Button();
        this.cmdSMRaceName = new Button();
        this.cmdSpeciesImage = new Button();
        this.cmdRaceFlag = new Button();
        this.cmdChangeHull = new Button();
        this.cmdRenameShip = new Button();
        this.cmdRenumber = new Button();
        this.cmdRenameClass = new Button();
        this.tabIntelligence = new TabControl();
        this.tabClass = new TabPage();
        this.flowLayoutPanel4 = new FlowLayoutPanel();
        this.cmdText = new Button();
        this.cmdClearClassData = new Button();
        this.cmdDeleteClass = new Button();
        this.flowLayoutPanel14 = new FlowLayoutPanel();
        this.tabPopulation = new TabPage();
        this.lstvPopulation = new ListView();
        this.columnHeader_18 = new ColumnHeader();
        this.columnHeader_19 = new ColumnHeader();
        this.tabSpecies = new TabPage();
        this.pbSpecies = new PictureBox();
        this.tabGroundUnits = new TabPage();
        this.cmdRenameUnit = new Button();
        this.lstvGroundUnitWeapons = new ListView();
        this.columnHeader_22 = new ColumnHeader();
        this.columnHeader_23 = new ColumnHeader();
        this.columnHeader_24 = new ColumnHeader();
        this.columnHeader_25 = new ColumnHeader();
        this.lstvGroundUnitClassData = new ListView();
        this.columnHeader_20 = new ColumnHeader();
        this.columnHeader_21 = new ColumnHeader();
        this.tabKnownSystems = new TabPage();
        this.lstvSystemSummary = new ListView();
        this.columnHeader_26 = new ColumnHeader();
        this.columnHeader_27 = new ColumnHeader();
        this.cboStatus = new ComboBox();
        this.tvContacts = new TreeView();
        this.tabSensor = new TabPage();
        this.cndRenameSensor = new Button();
        this.lstvMountingClasses = new ListView();
        this.columnHeader_28 = new ColumnHeader();
        this.tvIntelligence = new TreeView();
        ((ISupportInitialize)this.pbRace).BeginInit();
        ((ISupportInitialize)this.pbShip).BeginInit();
        ((ISupportInitialize)this.pbFlag).BeginInit();
        this.flowLayoutPanel2.SuspendLayout();
        this.flowLayoutPanel1.SuspendLayout();
        this.flowLayoutPanel3.SuspendLayout();
        this.flowLayoutPanel7.SuspendLayout();
        this.flowLayoutPanel8.SuspendLayout();
        this.flowLayoutPanel9.SuspendLayout();
        this.flowLayoutPanel11.SuspendLayout();
        this.flowLayoutPanel12.SuspendLayout();
        this.tabIntelligence.SuspendLayout();
        this.tabClass.SuspendLayout();
        this.flowLayoutPanel4.SuspendLayout();
        this.flowLayoutPanel14.SuspendLayout();
        this.tabPopulation.SuspendLayout();
        this.tabSpecies.SuspendLayout();
        ((ISupportInitialize)this.pbSpecies).BeginInit();
        this.tabGroundUnits.SuspendLayout();
        this.tabKnownSystems.SuspendLayout();
        this.tabSensor.SuspendLayout();
        this.SuspendLayout();
        this.pbRace.Anchor = AnchorStyles.None;
        this.pbRace.BorderStyle = BorderStyle.FixedSingle;
        this.pbRace.Location = new Point(495, 3);
        this.pbRace.Name = "pbRace";
        this.pbRace.Size = new Size(215, 175);
        this.pbRace.SizeMode = PictureBoxSizeMode.StretchImage;
        this.pbRace.TabIndex = 134;
        this.pbRace.TabStop = false;
        this.pbShip.Anchor = AnchorStyles.None;
        this.pbShip.BorderStyle = BorderStyle.FixedSingle;
        this.pbShip.Location = new Point(716, 3);
        this.pbShip.Name = "pbShip";
        this.pbShip.Size = new Size(215, 175);
        this.pbShip.SizeMode = PictureBoxSizeMode.Zoom;
        this.pbShip.TabIndex = 141;
        this.pbShip.TabStop = false;
        this.pbFlag.Anchor = AnchorStyles.None;
        this.pbFlag.BackgroundImageLayout = ImageLayout.None;
        this.pbFlag.BorderStyle = BorderStyle.FixedSingle;
        this.pbFlag.Location = new Point(937, 3);
        this.pbFlag.Name = "pbFlag";
        this.pbFlag.Size = new Size(298, 175);
        this.pbFlag.SizeMode = PictureBoxSizeMode.StretchImage;
        this.pbFlag.TabIndex = 142;
        this.pbFlag.TabStop = false;
        this.cboRaces.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cboRaces.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.cboRaces.FormattingEnabled = true;
        this.cboRaces.Location = new Point(3, 3);
        this.cboRaces.Margin = new Padding(3, 3, 3, 0);
        this.cboRaces.Name = "cboRaces";
        this.cboRaces.Size = new Size(200, 21);
        this.cboRaces.TabIndex = 143;
        this.cboRaces.SelectedIndexChanged += this.cboRaces_SelectedIndexChanged;
        this.cboAlienRaces.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cboAlienRaces.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.cboAlienRaces.FormattingEnabled = true;
        this.cboAlienRaces.Location = new Point(209, 3);
        this.cboAlienRaces.Margin = new Padding(3, 3, 3, 0);
        this.cboAlienRaces.Name = "cboAlienRaces";
        this.cboAlienRaces.Size = new Size(200, 21);
        this.cboAlienRaces.TabIndex = 144 /*0x90*/;
        this.cboAlienRaces.SelectedIndexChanged += this.cboAlienRaces_SelectedIndexChanged;
        this.flowLayoutPanel2.Controls.Add(this.rdoHostile);
        this.flowLayoutPanel2.Controls.Add(this.rdoNeutral);
        this.flowLayoutPanel2.Controls.Add(this.rdoFriendly);
        this.flowLayoutPanel2.Controls.Add(this.rdoAllied);
        this.flowLayoutPanel2.FlowDirection = FlowDirection.TopDown;
        this.flowLayoutPanel2.Location = new Point(3, 0);
        this.flowLayoutPanel2.Margin = new Padding(3, 0, 3, 0);
        this.flowLayoutPanel2.Name = "flowLayoutPanel2";
        this.flowLayoutPanel2.Size = new Size(137, 86);
        this.flowLayoutPanel2.TabIndex = 145;
        this.rdoHostile.AutoSize = true;
        this.rdoHostile.Checked = true;
        this.rdoHostile.Location = new Point(3, 2);
        this.rdoHostile.Margin = new Padding(3, 2, 3, 2);
        this.rdoHostile.Name = "rdoHostile";
        this.rdoHostile.Size = new Size(57, 17);
        this.rdoHostile.TabIndex = 0;
        this.rdoHostile.TabStop = true;
        this.rdoHostile.Text = "Hostile";
        this.rdoHostile.UseVisualStyleBackColor = true;
        this.rdoHostile.CheckedChanged += this.rdoAllied_CheckedChanged;
        this.rdoNeutral.AutoSize = true;
        this.rdoNeutral.Location = new Point(3, 23);
        this.rdoNeutral.Margin = new Padding(3, 2, 3, 2);
        this.rdoNeutral.Name = "rdoNeutral";
        this.rdoNeutral.Size = new Size(59, 17);
        this.rdoNeutral.TabIndex = 1;
        this.rdoNeutral.Text = "Neutral";
        this.rdoNeutral.UseVisualStyleBackColor = true;
        this.rdoNeutral.CheckedChanged += this.rdoAllied_CheckedChanged;
        this.rdoFriendly.AutoSize = true;
        this.rdoFriendly.Location = new Point(3, 44);
        this.rdoFriendly.Margin = new Padding(3, 2, 3, 2);
        this.rdoFriendly.Name = "rdoFriendly";
        this.rdoFriendly.Size = new Size(61, 17);
        this.rdoFriendly.TabIndex = 2;
        this.rdoFriendly.Text = "Friendly";
        this.rdoFriendly.UseVisualStyleBackColor = true;
        this.rdoFriendly.CheckedChanged += this.rdoAllied_CheckedChanged;
        this.rdoAllied.AutoSize = true;
        this.rdoAllied.Location = new Point(3, 65);
        this.rdoAllied.Margin = new Padding(3, 2, 3, 2);
        this.rdoAllied.Name = "rdoAllied";
        this.rdoAllied.Size = new Size(50, 17);
        this.rdoAllied.TabIndex = 3;
        this.rdoAllied.Text = "Allied";
        this.rdoAllied.UseVisualStyleBackColor = true;
        this.rdoAllied.CheckedChanged += this.rdoAllied_CheckedChanged;
        this.flowLayoutPanel1.BorderStyle = BorderStyle.FixedSingle;
        this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel2);
        this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel3);
        this.flowLayoutPanel1.Location = new Point(323, 3);
        this.flowLayoutPanel1.Name = "flowLayoutPanel1";
        this.flowLayoutPanel1.Size = new Size(166, 175);
        this.flowLayoutPanel1.TabIndex = 146;
        this.flowLayoutPanel3.Controls.Add(this.chkTrade);
        this.flowLayoutPanel3.Controls.Add(this.chkGeo);
        this.flowLayoutPanel3.Controls.Add(this.chkGrav);
        this.flowLayoutPanel3.Controls.Add(this.chkResearch);
        this.flowLayoutPanel3.FlowDirection = FlowDirection.TopDown;
        this.flowLayoutPanel3.Location = new Point(3, 86);
        this.flowLayoutPanel3.Margin = new Padding(3, 0, 3, 0);
        this.flowLayoutPanel3.Name = "flowLayoutPanel3";
        this.flowLayoutPanel3.Size = new Size(137, 88);
        this.flowLayoutPanel3.TabIndex = 146;
        this.chkTrade.AutoSize = true;
        this.chkTrade.Location = new Point(3, 3);
        this.chkTrade.Margin = new Padding(3, 3, 3, 2);
        this.chkTrade.Name = "chkTrade";
        this.chkTrade.Size = new Size(120, 17);
        this.chkTrade.TabIndex = 149;
        this.chkTrade.Text = "Allow Trade Access";
        this.chkTrade.UseVisualStyleBackColor = true;
        this.chkTrade.CheckedChanged += this.chkTrade_CheckedChanged;
        this.chkGeo.AutoSize = true;
        this.chkGeo.Location = new Point(3, 24);
        this.chkGeo.Margin = new Padding(3, 2, 3, 2);
        this.chkGeo.Name = "chkGeo";
        this.chkGeo.Size = new Size(133, 17);
        this.chkGeo.TabIndex = 150;
        this.chkGeo.Text = "Share Geological Data";
        this.chkGeo.UseVisualStyleBackColor = true;
        this.chkGeo.CheckedChanged += this.chkGeo_CheckedChanged;
        this.chkGrav.AutoSize = true;
        this.chkGrav.Location = new Point(3, 45);
        this.chkGrav.Margin = new Padding(3, 2, 3, 2);
        this.chkGrav.Name = "chkGrav";
        this.chkGrav.Size = new Size(142, 17);
        this.chkGrav.TabIndex = 151;
        this.chkGrav.Text = "Share Gravitational Data";
        this.chkGrav.UseVisualStyleBackColor = true;
        this.chkGrav.CheckedChanged += this.chkGrav_CheckedChanged;
        this.chkResearch.AutoSize = true;
        this.chkResearch.Location = new Point(3, 66);
        this.chkResearch.Margin = new Padding(3, 2, 3, 2);
        this.chkResearch.Name = "chkResearch";
        this.chkResearch.Size = new Size(129, 17);
        this.chkResearch.TabIndex = 152;
        this.chkResearch.Text = "Share Research Data";
        this.chkResearch.UseVisualStyleBackColor = true;
        this.chkResearch.CheckedChanged += this.chkResearch_CheckedChanged;
        this.cmdCommunicate.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdCommunicate.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.cmdCommunicate.Location = new Point(0, 0);
        this.cmdCommunicate.Margin = new Padding(0);
        this.cmdCommunicate.Name = "cmdCommunicate";
        this.cmdCommunicate.Size = new Size(96 /*0x60*/, 30);
        this.cmdCommunicate.TabIndex = 149;
        this.cmdCommunicate.Tag = "1200";
        this.cmdCommunicate.Text = "Communicate";
        this.cmdCommunicate.UseVisualStyleBackColor = false;
        this.cmdCommunicate.Click += this.cmdCommunicate_Click;
        this.lstvStatus.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.lstvStatus.BorderStyle = BorderStyle.FixedSingle;
        this.lstvStatus.Columns.AddRange(new ColumnHeader[2]
        {
            this.columnHeader_0,
            this.columnHeader_1
        });
        this.lstvStatus.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.lstvStatus.HeaderStyle = ColumnHeaderStyle.None;
        this.lstvStatus.HideSelection = false;
        this.lstvStatus.Location = new Point(0, 3);
        this.lstvStatus.Margin = new Padding(0, 3, 3, 3);
        this.lstvStatus.Name = "lstvStatus";
        this.lstvStatus.Size = new Size(317, 175);
        this.lstvStatus.TabIndex = 150;
        this.lstvStatus.UseCompatibleStateImageBehavior = false;
        this.lstvStatus.View = View.Details;
        this.columnHeader_0.Width = 160 /*0xA0*/;
        this.columnHeader_1.Width = 140;
        this.flowLayoutPanel7.BorderStyle = BorderStyle.FixedSingle;
        this.flowLayoutPanel7.Controls.Add(this.cboRaces);
        this.flowLayoutPanel7.Controls.Add(this.cboAlienRaces);
        this.flowLayoutPanel7.Controls.Add(this.label28);
        this.flowLayoutPanel7.Controls.Add(this.txtAbbreviation);
        this.flowLayoutPanel7.Controls.Add(this.label2);
        this.flowLayoutPanel7.Controls.Add(this.lblRaceIntelligence);
        this.flowLayoutPanel7.Controls.Add(this.label1);
        this.flowLayoutPanel7.Controls.Add(this.cboTheme);
        this.flowLayoutPanel7.Controls.Add(this.chkReal);
        this.flowLayoutPanel7.Controls.Add(this.chkAlienNameRandom);
        this.flowLayoutPanel7.Location = new Point(5, 3);
        this.flowLayoutPanel7.Name = "flowLayoutPanel7";
        this.flowLayoutPanel7.Size = new Size(1376, 29);
        this.flowLayoutPanel7.TabIndex = 151;
        this.label28.AutoSize = true;
        this.label28.Location = new Point(437, 6);
        this.label28.Margin = new Padding(25, 6, 5, 0);
        this.label28.Name = "label28";
        this.label28.Size = new Size(41, 13);
        this.label28.TabIndex = 151;
        this.label28.Text = "Abbrev";
        this.label28.TextAlign = ContentAlignment.MiddleCenter;
        this.txtAbbreviation.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtAbbreviation.BorderStyle = BorderStyle.None;
        this.txtAbbreviation.ForeColor = Color.FromArgb(128 /*0x80*/, byte.MaxValue, 128 /*0x80*/);
        this.txtAbbreviation.Location = new Point(483, 7);
        this.txtAbbreviation.Margin = new Padding(0, 7, 3, 3);
        this.txtAbbreviation.Multiline = true;
        this.txtAbbreviation.Name = "txtAbbreviation";
        this.txtAbbreviation.Size = new Size(40, 18);
        this.txtAbbreviation.TabIndex = 146;
        this.txtAbbreviation.Text = "USA";
        this.txtAbbreviation.TextAlign = HorizontalAlignment.Center;
        this.txtAbbreviation.TextChanged += this.txtAbbreviation_TextChanged;
        this.label2.AutoSize = true;
        this.label2.Location = new Point(551, 6);
        this.label2.Margin = new Padding(25, 6, 5, 0);
        this.label2.Name = "label2";
        this.label2.Size = new Size(80 /*0x50*/, 13);
        this.label2.TabIndex = 154;
        this.label2.Text = "Race Int Points";
        this.label2.TextAlign = ContentAlignment.MiddleCenter;
        this.lblRaceIntelligence.AutoSize = true;
        this.lblRaceIntelligence.Location = new Point(636, 6);
        this.lblRaceIntelligence.Margin = new Padding(0, 6, 5, 0);
        this.lblRaceIntelligence.Name = "lblRaceIntelligence";
        this.lblRaceIntelligence.Size = new Size(66, 13);
        this.lblRaceIntelligence.TabIndex = 155;
        this.lblRaceIntelligence.Text = "Abbreviation";
        this.lblRaceIntelligence.TextAlign = ContentAlignment.MiddleCenter;
        this.label1.AutoSize = true;
        this.label1.Location = new Point(732, 6);
        this.label1.Margin = new Padding(25, 6, 5, 0);
        this.label1.Name = "label1";
        this.label1.Size = new Size(40, 13);
        this.label1.TabIndex = 152;
        this.label1.Text = "Theme";
        this.label1.TextAlign = ContentAlignment.MiddleCenter;
        this.cboTheme.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cboTheme.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.cboTheme.FormattingEnabled = true;
        this.cboTheme.Location = new Point(780, 3);
        this.cboTheme.Margin = new Padding(3, 3, 3, 0);
        this.cboTheme.Name = "cboTheme";
        this.cboTheme.Size = new Size(220, 21);
        this.cboTheme.TabIndex = 145;
        this.cboTheme.SelectedIndexChanged += this.cboTheme_SelectedIndexChanged;
        this.chkReal.AutoSize = true;
        this.chkReal.Location = new Point(1018, 5);
        this.chkReal.Margin = new Padding(15, 5, 3, 3);
        this.chkReal.Name = "chkReal";
        this.chkReal.Size = new Size(166, 17);
        this.chkReal.TabIndex = 150;
        this.chkReal.Text = "Use Real Ship / Class Names";
        this.chkReal.UseVisualStyleBackColor = true;
        this.chkReal.CheckedChanged += this.chkReal_CheckedChanged;
        this.chkAlienNameRandom.AutoSize = true;
        this.chkAlienNameRandom.Location = new Point(1202, 5);
        this.chkAlienNameRandom.Margin = new Padding(15, 5, 3, 3);
        this.chkAlienNameRandom.Name = "chkAlienNameRandom";
        this.chkAlienNameRandom.Size = new Size(95, 17);
        this.chkAlienNameRandom.TabIndex = 156;
        this.chkAlienNameRandom.Text = "Random Order";
        this.chkAlienNameRandom.UseVisualStyleBackColor = true;
        this.chkAlienNameRandom.CheckedChanged += this.chkAlienNameRandom_CheckedChanged;
        this.flowLayoutPanel8.Controls.Add(this.lstvStatus);
        this.flowLayoutPanel8.Controls.Add(this.flowLayoutPanel1);
        this.flowLayoutPanel8.Controls.Add(this.pbRace);
        this.flowLayoutPanel8.Controls.Add(this.pbShip);
        this.flowLayoutPanel8.Controls.Add(this.pbFlag);
        this.flowLayoutPanel8.Location = new Point(5, 32 /*0x20*/);
        this.flowLayoutPanel8.Name = "flowLayoutPanel8";
        this.flowLayoutPanel8.Size = new Size(1376, 178);
        this.flowLayoutPanel8.TabIndex = 152;
        this.lstvKnownSpecies.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.lstvKnownSpecies.BorderStyle = BorderStyle.FixedSingle;
        this.lstvKnownSpecies.Columns.AddRange(new ColumnHeader[3]
        {
            this.columnHeader_2,
            this.columnHeader_3,
            this.columnHeader_10
        });
        this.lstvKnownSpecies.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.lstvKnownSpecies.HeaderStyle = ColumnHeaderStyle.None;
        this.lstvKnownSpecies.HideSelection = false;
        this.lstvKnownSpecies.Location = new Point(225, 6);
        this.lstvKnownSpecies.Margin = new Padding(0, 3, 0, 3);
        this.lstvKnownSpecies.Name = "lstvKnownSpecies";
        this.lstvKnownSpecies.Size = new Size(270, 175);
        this.lstvKnownSpecies.TabIndex = 163;
        this.lstvKnownSpecies.UseCompatibleStateImageBehavior = false;
        this.lstvKnownSpecies.View = View.Details;
        this.columnHeader_2.Width = 100;
        this.columnHeader_3.TextAlign = HorizontalAlignment.Right;
        this.columnHeader_3.Width = 80 /*0x50*/;
        this.columnHeader_10.TextAlign = HorizontalAlignment.Right;
        this.columnHeader_10.Width = 80 /*0x50*/;
        this.cmdRename.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdRename.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.cmdRename.Location = new Point(96 /*0x60*/, 0);
        this.cmdRename.Margin = new Padding(0);
        this.cmdRename.Name = "cmdRename";
        this.cmdRename.Size = new Size(96 /*0x60*/, 30);
        this.cmdRename.TabIndex = 153;
        this.cmdRename.Tag = "1200";
        this.cmdRename.Text = "Rename Race";
        this.cmdRename.UseVisualStyleBackColor = false;
        this.cmdRename.Click += this.cmdRename_Click;
        this.lstvAlienShips.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.lstvAlienShips.BorderStyle = BorderStyle.None;
        this.lstvAlienShips.Columns.AddRange(new ColumnHeader[3]
        {
            this.columnHeader_4,
            this.columnHeader_5,
            this.columnHeader_6
        });
        this.lstvAlienShips.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.lstvAlienShips.HeaderStyle = ColumnHeaderStyle.None;
        this.lstvAlienShips.HideSelection = false;
        this.lstvAlienShips.Location = new Point(0, 23);
        this.lstvAlienShips.Margin = new Padding(0, 6, 0, 3);
        this.lstvAlienShips.Name = "lstvAlienShips";
        this.lstvAlienShips.Size = new Size(383, 479);
        this.lstvAlienShips.TabIndex = 166;
        this.lstvAlienShips.UseCompatibleStateImageBehavior = false;
        this.lstvAlienShips.View = View.Details;
        this.lstvAlienShips.SelectedIndexChanged += this.lstvAlienShips_SelectedIndexChanged;
        this.columnHeader_4.Width = 130;
        this.columnHeader_5.Width = 110;
        this.columnHeader_6.Width = 120;
        this.flowLayoutPanel9.BorderStyle = BorderStyle.FixedSingle;
        this.flowLayoutPanel9.Controls.Add(this.label5);
        this.flowLayoutPanel9.Controls.Add(this.lstvAlienShips);
        this.flowLayoutPanel9.Location = new Point(659, 6);
        this.flowLayoutPanel9.Name = "flowLayoutPanel9";
        this.flowLayoutPanel9.Size = new Size(384, 506);
        this.flowLayoutPanel9.TabIndex = 171;
        this.label5.Location = new Point(0, 0);
        this.label5.Margin = new Padding(0, 0, 3, 0);
        this.label5.Name = "label5";
        this.label5.Size = new Size(421, 17);
        this.label5.TabIndex = 155;
        this.label5.Text = "Last Location for Known Ships of Selected Class";
        this.label5.TextAlign = ContentAlignment.MiddleCenter;
        this.flowLayoutPanel11.BorderStyle = BorderStyle.FixedSingle;
        this.flowLayoutPanel11.Controls.Add(this.label9);
        this.flowLayoutPanel11.Controls.Add(this.lstvWeapons);
        this.flowLayoutPanel11.Controls.Add(this.lblExtras);
        this.flowLayoutPanel11.Controls.Add(this.lstvKnownSensors);
        this.flowLayoutPanel11.Controls.Add(this.label10);
        this.flowLayoutPanel11.Controls.Add(this.lstvTechnology);
        this.flowLayoutPanel11.Location = new Point(296, 6);
        this.flowLayoutPanel11.Name = "flowLayoutPanel11";
        this.flowLayoutPanel11.Size = new Size(357, 375);
        this.flowLayoutPanel11.TabIndex = 172;
        this.label9.Location = new Point(3, 0);
        this.label9.Name = "label9";
        this.label9.Size = new Size(349, 17);
        this.label9.TabIndex = 161;
        this.label9.Text = "Observed Weapons";
        this.label9.TextAlign = ContentAlignment.MiddleCenter;
        this.lstvWeapons.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.lstvWeapons.BorderStyle = BorderStyle.None;
        this.lstvWeapons.Columns.AddRange(new ColumnHeader[4]
        {
            this.columnHeader_12,
            this.columnHeader_13,
            this.columnHeader_14,
            this.columnHeader_15
        });
        this.lstvWeapons.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.lstvWeapons.HeaderStyle = ColumnHeaderStyle.None;
        this.lstvWeapons.HideSelection = false;
        this.lstvWeapons.Location = new Point(0, 23);
        this.lstvWeapons.Margin = new Padding(0, 6, 0, 3);
        this.lstvWeapons.Name = "lstvWeapons";
        this.lstvWeapons.Size = new Size(356, 99);
        this.lstvWeapons.TabIndex = 160 /*0xA0*/;
        this.lstvWeapons.UseCompatibleStateImageBehavior = false;
        this.lstvWeapons.View = View.Details;
        this.columnHeader_12.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_12.Width = 130;
        this.columnHeader_13.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_13.Width = 70;
        this.columnHeader_14.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_14.Width = 70;
        this.columnHeader_15.TextAlign = HorizontalAlignment.Center;
        this.lblExtras.Location = new Point(3, 125);
        this.lblExtras.Name = "lblExtras";
        this.lblExtras.Size = new Size(349, 17);
        this.lblExtras.TabIndex = 157;
        this.lblExtras.Text = "Observed Sensors";
        this.lblExtras.TextAlign = ContentAlignment.MiddleCenter;
        this.lstvKnownSensors.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.lstvKnownSensors.BorderStyle = BorderStyle.None;
        this.lstvKnownSensors.Columns.AddRange(new ColumnHeader[3]
        {
            this.columnHeader_9,
            this.columnHeader_16,
            this.columnHeader_17
        });
        this.lstvKnownSensors.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.lstvKnownSensors.HeaderStyle = ColumnHeaderStyle.None;
        this.lstvKnownSensors.HideSelection = false;
        this.lstvKnownSensors.Location = new Point(0, 148);
        this.lstvKnownSensors.Margin = new Padding(0, 6, 0, 3);
        this.lstvKnownSensors.Name = "lstvKnownSensors";
        this.lstvKnownSensors.Size = new Size(356, 78);
        this.lstvKnownSensors.TabIndex = 158;
        this.lstvKnownSensors.UseCompatibleStateImageBehavior = false;
        this.lstvKnownSensors.View = View.Details;
        this.columnHeader_9.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_9.Width = 160 /*0xA0*/;
        this.columnHeader_16.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_16.Width = 90;
        this.columnHeader_17.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_17.Width = 70;
        this.label10.Location = new Point(3, 229);
        this.label10.Name = "label10";
        this.label10.Size = new Size(349, 17);
        this.label10.TabIndex = 162;
        this.label10.Text = "Observed Technology";
        this.label10.TextAlign = ContentAlignment.MiddleCenter;
        this.lstvTechnology.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.lstvTechnology.BorderStyle = BorderStyle.None;
        this.lstvTechnology.Columns.AddRange(new ColumnHeader[1]
        {
            this.columnHeader_11
        });
        this.lstvTechnology.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.lstvTechnology.HeaderStyle = ColumnHeaderStyle.None;
        this.lstvTechnology.HideSelection = false;
        this.lstvTechnology.Location = new Point(0, 252);
        this.lstvTechnology.Margin = new Padding(0, 6, 0, 3);
        this.lstvTechnology.Name = "lstvTechnology";
        this.lstvTechnology.Size = new Size(356, 122);
        this.lstvTechnology.TabIndex = 159;
        this.lstvTechnology.UseCompatibleStateImageBehavior = false;
        this.lstvTechnology.View = View.Details;
        this.columnHeader_11.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_11.Width = 330;
        this.label7.Location = new Point(0, 0);
        this.label7.Margin = new Padding(0, 0, 3, 0);
        this.label7.Name = "label7";
        this.label7.Size = new Size(290, 17);
        this.label7.TabIndex = 155;
        this.label7.Text = "Selected Class Observed Attributes";
        this.label7.TextAlign = ContentAlignment.MiddleCenter;
        this.lstvClassDetails.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.lstvClassDetails.BorderStyle = BorderStyle.None;
        this.lstvClassDetails.Columns.AddRange(new ColumnHeader[2]
        {
            this.columnHeader_7,
            this.columnHeader_8
        });
        this.lstvClassDetails.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.lstvClassDetails.HeaderStyle = ColumnHeaderStyle.None;
        this.lstvClassDetails.HideSelection = false;
        this.lstvClassDetails.Location = new Point(0, 23);
        this.lstvClassDetails.Margin = new Padding(0, 6, 0, 3);
        this.lstvClassDetails.Name = "lstvClassDetails";
        this.lstvClassDetails.Size = new Size(290, 351);
        this.lstvClassDetails.TabIndex = 156;
        this.lstvClassDetails.UseCompatibleStateImageBehavior = false;
        this.lstvClassDetails.View = View.Details;
        this.columnHeader_7.Width = 185;
        this.columnHeader_8.TextAlign = HorizontalAlignment.Right;
        this.columnHeader_8.Width = 100;
        this.cmdHull.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdHull.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.cmdHull.Location = new Point(96 /*0x60*/, 0);
        this.cmdHull.Margin = new Padding(0);
        this.cmdHull.Name = "cmdHull";
        this.cmdHull.Size = new Size(96 /*0x60*/, 30);
        this.cmdHull.TabIndex = 173;
        this.cmdHull.Tag = "1200";
        this.cmdHull.Text = "Set Class Hull";
        this.cmdHull.UseVisualStyleBackColor = false;
        this.cmdHull.Click += this.cmdHull_Click;
        this.txtSummary.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtSummary.BorderStyle = BorderStyle.FixedSingle;
        this.txtSummary.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.txtSummary.Location = new Point(4, 387);
        this.txtSummary.Multiline = true;
        this.txtSummary.Name = "txtSummary";
        this.txtSummary.ReadOnly = true;
        this.txtSummary.Size = new Size(649, 188);
        this.txtSummary.TabIndex = 174;
        this.txtSummary.Text = "No Class Summary Available";
        this.cmdChangeDR.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdChangeDR.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.cmdChangeDR.Location = new Point(576, 0);
        this.cmdChangeDR.Margin = new Padding(0);
        this.cmdChangeDR.Name = "cmdChangeDR";
        this.cmdChangeDR.Size = new Size(96 /*0x60*/, 30);
        this.cmdChangeDR.TabIndex = 175;
        this.cmdChangeDR.Tag = "1200";
        this.cmdChangeDR.Text = "SM Set DR";
        this.cmdChangeDR.UseVisualStyleBackColor = false;
        this.cmdChangeDR.Click += this.cmdChangeDR_Click;
        this.flowLayoutPanel12.Controls.Add(this.cmdCommunicate);
        this.flowLayoutPanel12.Controls.Add(this.cmdRename);
        this.flowLayoutPanel12.Controls.Add(this.cmdAutoName);
        this.flowLayoutPanel12.Controls.Add(this.cmdSelectName);
        this.flowLayoutPanel12.Controls.Add(this.cmdDestroyShip);
        this.flowLayoutPanel12.Controls.Add(this.cmdCorrectNames);
        this.flowLayoutPanel12.Controls.Add(this.cmdChangeDR);
        this.flowLayoutPanel12.Controls.Add(this.cmdToggleFixed);
        this.flowLayoutPanel12.Controls.Add(this.cmdSetComm);
        this.flowLayoutPanel12.Controls.Add(this.cmdAddSpecies);
        this.flowLayoutPanel12.Controls.Add(this.cmdSMRaceName);
        this.flowLayoutPanel12.Controls.Add(this.cmdSpeciesImage);
        this.flowLayoutPanel12.Controls.Add(this.cmdRaceFlag);
        this.flowLayoutPanel12.Controls.Add(this.cmdChangeHull);
        this.flowLayoutPanel12.Location = new Point(5, 821);
        this.flowLayoutPanel12.Name = "flowLayoutPanel12";
        this.flowLayoutPanel12.Size = new Size(1373, 30);
        this.flowLayoutPanel12.TabIndex = 176 /*0xB0*/;
        this.cmdAutoName.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdAutoName.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.cmdAutoName.Location = new Point(192 /*0xC0*/, 0);
        this.cmdAutoName.Margin = new Padding(0);
        this.cmdAutoName.Name = "cmdAutoName";
        this.cmdAutoName.Size = new Size(96 /*0x60*/, 30);
        this.cmdAutoName.TabIndex = 182;
        this.cmdAutoName.Tag = "1200";
        this.cmdAutoName.Text = "Auto Class Name";
        this.cmdAutoName.UseVisualStyleBackColor = false;
        this.cmdAutoName.Click += this.cmdAutoName_Click;
        this.cmdSelectName.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdSelectName.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.cmdSelectName.Location = new Point(288, 0);
        this.cmdSelectName.Margin = new Padding(0);
        this.cmdSelectName.Name = "cmdSelectName";
        this.cmdSelectName.Size = new Size(96 /*0x60*/, 30);
        this.cmdSelectName.TabIndex = 183;
        this.cmdSelectName.Tag = "1200";
        this.cmdSelectName.Text = "Select Name";
        this.cmdSelectName.UseVisualStyleBackColor = false;
        this.cmdSelectName.Click += this.cmdSelectName_Click;
        this.cmdDestroyShip.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdDestroyShip.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.cmdDestroyShip.Location = new Point(384, 0);
        this.cmdDestroyShip.Margin = new Padding(0);
        this.cmdDestroyShip.Name = "cmdDestroyShip";
        this.cmdDestroyShip.Size = new Size(96 /*0x60*/, 30);
        this.cmdDestroyShip.TabIndex = 179;
        this.cmdDestroyShip.Tag = "1200";
        this.cmdDestroyShip.Text = "Flag Destroyed";
        this.cmdDestroyShip.UseVisualStyleBackColor = false;
        this.cmdDestroyShip.Click += this.cmdDestroyShip_Click;
        this.cmdCorrectNames.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdCorrectNames.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.cmdCorrectNames.Location = new Point(480, 0);
        this.cmdCorrectNames.Margin = new Padding(0);
        this.cmdCorrectNames.Name = "cmdCorrectNames";
        this.cmdCorrectNames.Size = new Size(96 /*0x60*/, 30);
        this.cmdCorrectNames.TabIndex = 184;
        this.cmdCorrectNames.Tag = "1200";
        this.cmdCorrectNames.Text = "Correct Names";
        this.cmdCorrectNames.UseVisualStyleBackColor = false;
        this.cmdCorrectNames.Click += this.cmdCorrectNames_Click;
        this.cmdToggleFixed.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdToggleFixed.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.cmdToggleFixed.Location = new Point(672, 0);
        this.cmdToggleFixed.Margin = new Padding(0);
        this.cmdToggleFixed.Name = "cmdToggleFixed";
        this.cmdToggleFixed.Size = new Size(96 /*0x60*/, 30);
        this.cmdToggleFixed.TabIndex = 177;
        this.cmdToggleFixed.Tag = "1200";
        this.cmdToggleFixed.Text = "SM Fixed DR";
        this.cmdToggleFixed.UseVisualStyleBackColor = false;
        this.cmdToggleFixed.Click += this.cmdToggleFixed_Click;
        this.cmdSetComm.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdSetComm.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.cmdSetComm.Location = new Point(768 /*0x0300*/, 0);
        this.cmdSetComm.Margin = new Padding(0);
        this.cmdSetComm.Name = "cmdSetComm";
        this.cmdSetComm.Size = new Size(96 /*0x60*/, 30);
        this.cmdSetComm.TabIndex = 178;
        this.cmdSetComm.Tag = "1200";
        this.cmdSetComm.Text = "SM Est. Comm";
        this.cmdSetComm.UseVisualStyleBackColor = false;
        this.cmdSetComm.Click += this.cmdSetComm_Click;
        this.cmdAddSpecies.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdAddSpecies.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.cmdAddSpecies.Location = new Point(864, 0);
        this.cmdAddSpecies.Margin = new Padding(0);
        this.cmdAddSpecies.Name = "cmdAddSpecies";
        this.cmdAddSpecies.Size = new Size(96 /*0x60*/, 30);
        this.cmdAddSpecies.TabIndex = 185;
        this.cmdAddSpecies.Tag = "1200";
        this.cmdAddSpecies.Text = "SM Add Species";
        this.cmdAddSpecies.UseVisualStyleBackColor = false;
        this.cmdAddSpecies.Click += this.cmdAddSpecies_Click;
        this.cmdSMRaceName.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdSMRaceName.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.cmdSMRaceName.Location = new Point(960, 0);
        this.cmdSMRaceName.Margin = new Padding(0);
        this.cmdSMRaceName.Name = "cmdSMRaceName";
        this.cmdSMRaceName.Size = new Size(95, 30);
        this.cmdSMRaceName.TabIndex = 189;
        this.cmdSMRaceName.Tag = "1200";
        this.cmdSMRaceName.Text = "SM Race Title";
        this.cmdSMRaceName.UseVisualStyleBackColor = false;
        this.cmdSMRaceName.Click += this.cmdSMRaceName_Click;
        this.cmdSpeciesImage.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdSpeciesImage.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.cmdSpeciesImage.Location = new Point(1055, 0);
        this.cmdSpeciesImage.Margin = new Padding(0);
        this.cmdSpeciesImage.Name = "cmdSpeciesImage";
        this.cmdSpeciesImage.Size = new Size(95, 30);
        this.cmdSpeciesImage.TabIndex = 186;
        this.cmdSpeciesImage.Tag = "1200";
        this.cmdSpeciesImage.Text = "SM Image";
        this.cmdSpeciesImage.UseVisualStyleBackColor = false;
        this.cmdSpeciesImage.Click += this.cmdSpeciesImage_Click;
        this.cmdRaceFlag.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdRaceFlag.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.cmdRaceFlag.Location = new Point(1150, 0);
        this.cmdRaceFlag.Margin = new Padding(0);
        this.cmdRaceFlag.Name = "cmdRaceFlag";
        this.cmdRaceFlag.Size = new Size(95, 30);
        this.cmdRaceFlag.TabIndex = 187;
        this.cmdRaceFlag.Tag = "1200";
        this.cmdRaceFlag.Text = "SM Flag";
        this.cmdRaceFlag.UseVisualStyleBackColor = false;
        this.cmdRaceFlag.Click += this.cmdRaceFlag_Click;
        this.cmdChangeHull.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdChangeHull.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.cmdChangeHull.Location = new Point(1245, 0);
        this.cmdChangeHull.Margin = new Padding(0);
        this.cmdChangeHull.Name = "cmdChangeHull";
        this.cmdChangeHull.Size = new Size(95, 30);
        this.cmdChangeHull.TabIndex = 188;
        this.cmdChangeHull.Tag = "1200";
        this.cmdChangeHull.Text = "SM Hull";
        this.cmdChangeHull.UseVisualStyleBackColor = false;
        this.cmdChangeHull.Click += this.cmdChangeHull_Click;
        this.cmdRenameShip.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdRenameShip.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.cmdRenameShip.Location = new Point(192 /*0xC0*/, 0);
        this.cmdRenameShip.Margin = new Padding(0);
        this.cmdRenameShip.Name = "cmdRenameShip";
        this.cmdRenameShip.Size = new Size(96 /*0x60*/, 30);
        this.cmdRenameShip.TabIndex = 180;
        this.cmdRenameShip.Tag = "1200";
        this.cmdRenameShip.Text = "Rename Ship";
        this.cmdRenameShip.UseVisualStyleBackColor = false;
        this.cmdRenameShip.Click += this.cmdRenameShip_Click;
        this.cmdRenumber.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdRenumber.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.cmdRenumber.Location = new Point(288, 0);
        this.cmdRenumber.Margin = new Padding(0);
        this.cmdRenumber.Name = "cmdRenumber";
        this.cmdRenumber.Size = new Size(96 /*0x60*/, 30);
        this.cmdRenumber.TabIndex = 181;
        this.cmdRenumber.Tag = "1200";
        this.cmdRenumber.Text = "Renumber Ships";
        this.cmdRenumber.UseVisualStyleBackColor = false;
        this.cmdRenumber.Click += this.cmdRenumber_Click;
        this.cmdRenameClass.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdRenameClass.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.cmdRenameClass.Location = new Point(0, 0);
        this.cmdRenameClass.Margin = new Padding(0);
        this.cmdRenameClass.Name = "cmdRenameClass";
        this.cmdRenameClass.Size = new Size(96 /*0x60*/, 30);
        this.cmdRenameClass.TabIndex = 176 /*0xB0*/;
        this.cmdRenameClass.Tag = "1200";
        this.cmdRenameClass.Text = "Rename Class";
        this.cmdRenameClass.UseVisualStyleBackColor = false;
        this.cmdRenameClass.Click += this.cmdRenameClass_Click;
        this.tabIntelligence.Controls.Add(this.tabClass);
        this.tabIntelligence.Controls.Add(this.tabPopulation);
        this.tabIntelligence.Controls.Add(this.tabSpecies);
        this.tabIntelligence.Controls.Add(this.tabGroundUnits);
        this.tabIntelligence.Controls.Add(this.tabKnownSystems);
        this.tabIntelligence.Controls.Add(this.tabSensor);
        this.tabIntelligence.Location = new Point(327, 213);
        this.tabIntelligence.Name = "tabIntelligence";
        this.tabIntelligence.SelectedIndex = 0;
        this.tabIntelligence.Size = new Size(1054, 605);
        this.tabIntelligence.TabIndex = 167;
        this.tabClass.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.tabClass.Controls.Add(this.flowLayoutPanel4);
        this.tabClass.Controls.Add(this.flowLayoutPanel14);
        this.tabClass.Controls.Add(this.flowLayoutPanel11);
        this.tabClass.Controls.Add(this.flowLayoutPanel9);
        this.tabClass.Controls.Add(this.txtSummary);
        this.tabClass.Location = new Point(4, 22);
        this.tabClass.Name = "tabClass";
        this.tabClass.Padding = new Padding(3);
        this.tabClass.Size = new Size(1046, 579);
        this.tabClass.TabIndex = 0;
        this.tabClass.Text = "Known Class";
        this.flowLayoutPanel4.Controls.Add(this.cmdRenameClass);
        this.flowLayoutPanel4.Controls.Add(this.cmdHull);
        this.flowLayoutPanel4.Controls.Add(this.cmdRenameShip);
        this.flowLayoutPanel4.Controls.Add(this.cmdRenumber);
        this.flowLayoutPanel4.Controls.Add(this.cmdText);
        this.flowLayoutPanel4.Controls.Add(this.cmdClearClassData);
        this.flowLayoutPanel4.Controls.Add(this.cmdDeleteClass);
        this.flowLayoutPanel4.Location = new Point(659, 515);
        this.flowLayoutPanel4.Name = "flowLayoutPanel4";
        this.flowLayoutPanel4.Size = new Size(384, 60);
        this.flowLayoutPanel4.TabIndex = 186;
        this.cmdText.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdText.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.cmdText.Location = new Point(0, 30);
        this.cmdText.Margin = new Padding(0);
        this.cmdText.Name = "cmdText";
        this.cmdText.Size = new Size(96 /*0x60*/, 30);
        this.cmdText.TabIndex = 187;
        this.cmdText.Tag = "1200";
        this.cmdText.Text = "All Class Text";
        this.cmdText.UseVisualStyleBackColor = false;
        this.cmdText.Click += this.cmdText_Click;
        this.cmdClearClassData.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdClearClassData.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.cmdClearClassData.Location = new Point(96 /*0x60*/, 30);
        this.cmdClearClassData.Margin = new Padding(0);
        this.cmdClearClassData.Name = "cmdClearClassData";
        this.cmdClearClassData.Size = new Size(96 /*0x60*/, 30);
        this.cmdClearClassData.TabIndex = 186;
        this.cmdClearClassData.Tag = "1200";
        this.cmdClearClassData.Text = "Clear Data";
        this.cmdClearClassData.UseVisualStyleBackColor = false;
        this.cmdClearClassData.Click += this.cmdClearClassData_Click;
        this.cmdDeleteClass.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdDeleteClass.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.cmdDeleteClass.Location = new Point(192 /*0xC0*/, 30);
        this.cmdDeleteClass.Margin = new Padding(0);
        this.cmdDeleteClass.Name = "cmdDeleteClass";
        this.cmdDeleteClass.Size = new Size(96 /*0x60*/, 30);
        this.cmdDeleteClass.TabIndex = 185;
        this.cmdDeleteClass.Tag = "1200";
        this.cmdDeleteClass.Text = "Delete Class";
        this.cmdDeleteClass.UseVisualStyleBackColor = false;
        this.cmdDeleteClass.Click += this.cmdDeleteClass_Click;
        this.flowLayoutPanel14.BorderStyle = BorderStyle.FixedSingle;
        this.flowLayoutPanel14.Controls.Add(this.label7);
        this.flowLayoutPanel14.Controls.Add(this.lstvClassDetails);
        this.flowLayoutPanel14.Location = new Point(2, 6);
        this.flowLayoutPanel14.Name = "flowLayoutPanel14";
        this.flowLayoutPanel14.Size = new Size(290, 375);
        this.flowLayoutPanel14.TabIndex = 179;
        this.tabPopulation.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.tabPopulation.Controls.Add(this.lstvPopulation);
        this.tabPopulation.Location = new Point(4, 22);
        this.tabPopulation.Name = "tabPopulation";
        this.tabPopulation.Padding = new Padding(3);
        this.tabPopulation.Size = new Size(1046, 579);
        this.tabPopulation.TabIndex = 1;
        this.tabPopulation.Text = "Known Population";
        this.lstvPopulation.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.lstvPopulation.BorderStyle = BorderStyle.None;
        this.lstvPopulation.Columns.AddRange(new ColumnHeader[2]
        {
            this.columnHeader_18,
            this.columnHeader_19
        });
        this.lstvPopulation.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.lstvPopulation.HeaderStyle = ColumnHeaderStyle.None;
        this.lstvPopulation.HideSelection = false;
        this.lstvPopulation.Location = new Point(3, 6);
        this.lstvPopulation.Margin = new Padding(0, 6, 0, 3);
        this.lstvPopulation.Name = "lstvPopulation";
        this.lstvPopulation.Size = new Size(441, 567);
        this.lstvPopulation.TabIndex = 167;
        this.lstvPopulation.UseCompatibleStateImageBehavior = false;
        this.lstvPopulation.View = View.Details;
        this.columnHeader_18.Width = 200;
        this.columnHeader_19.TextAlign = HorizontalAlignment.Right;
        this.columnHeader_19.Width = 120;
        this.tabSpecies.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.tabSpecies.Controls.Add(this.pbSpecies);
        this.tabSpecies.Controls.Add(this.lstvKnownSpecies);
        this.tabSpecies.Location = new Point(4, 22);
        this.tabSpecies.Name = "tabSpecies";
        this.tabSpecies.Padding = new Padding(3);
        this.tabSpecies.Size = new Size(1046, 579);
        this.tabSpecies.TabIndex = 2;
        this.tabSpecies.Text = "Known Species";
        this.pbSpecies.Anchor = AnchorStyles.None;
        this.pbSpecies.BorderStyle = BorderStyle.FixedSingle;
        this.pbSpecies.Location = new Point(7, 6);
        this.pbSpecies.Name = "pbSpecies";
        this.pbSpecies.Size = new Size(215, 175);
        this.pbSpecies.SizeMode = PictureBoxSizeMode.StretchImage;
        this.pbSpecies.TabIndex = 164;
        this.pbSpecies.TabStop = false;
        this.tabGroundUnits.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.tabGroundUnits.Controls.Add(this.cmdRenameUnit);
        this.tabGroundUnits.Controls.Add(this.lstvGroundUnitWeapons);
        this.tabGroundUnits.Controls.Add(this.lstvGroundUnitClassData);
        this.tabGroundUnits.Location = new Point(4, 22);
        this.tabGroundUnits.Name = "tabGroundUnits";
        this.tabGroundUnits.Padding = new Padding(3);
        this.tabGroundUnits.Size = new Size(1046, 579);
        this.tabGroundUnits.TabIndex = 3;
        this.tabGroundUnits.Text = "Ground Unit Classes";
        this.cmdRenameUnit.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdRenameUnit.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.cmdRenameUnit.Location = new Point(3, 234);
        this.cmdRenameUnit.Margin = new Padding(0);
        this.cmdRenameUnit.Name = "cmdRenameUnit";
        this.cmdRenameUnit.Size = new Size(96 /*0x60*/, 30);
        this.cmdRenameUnit.TabIndex = 177;
        this.cmdRenameUnit.Tag = "1200";
        this.cmdRenameUnit.Text = "Rename Unit";
        this.cmdRenameUnit.UseVisualStyleBackColor = false;
        this.cmdRenameUnit.Click += this.cmdRenameUnit_Click;
        this.lstvGroundUnitWeapons.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.lstvGroundUnitWeapons.BorderStyle = BorderStyle.FixedSingle;
        this.lstvGroundUnitWeapons.Columns.AddRange(new ColumnHeader[4]
        {
            this.columnHeader_22,
            this.columnHeader_23,
            this.columnHeader_24,
            this.columnHeader_25
        });
        this.lstvGroundUnitWeapons.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.lstvGroundUnitWeapons.HeaderStyle = ColumnHeaderStyle.None;
        this.lstvGroundUnitWeapons.HideSelection = false;
        this.lstvGroundUnitWeapons.Location = new Point(353, 3);
        this.lstvGroundUnitWeapons.Margin = new Padding(0, 3, 0, 3);
        this.lstvGroundUnitWeapons.Name = "lstvGroundUnitWeapons";
        this.lstvGroundUnitWeapons.Size = new Size(346, 228);
        this.lstvGroundUnitWeapons.TabIndex = 165;
        this.lstvGroundUnitWeapons.UseCompatibleStateImageBehavior = false;
        this.lstvGroundUnitWeapons.View = View.Details;
        this.columnHeader_22.Width = 160 /*0xA0*/;
        this.columnHeader_23.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_24.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_25.TextAlign = HorizontalAlignment.Center;
        this.lstvGroundUnitClassData.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.lstvGroundUnitClassData.BorderStyle = BorderStyle.FixedSingle;
        this.lstvGroundUnitClassData.Columns.AddRange(new ColumnHeader[2]
        {
            this.columnHeader_20,
            this.columnHeader_21
        });
        this.lstvGroundUnitClassData.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.lstvGroundUnitClassData.HeaderStyle = ColumnHeaderStyle.None;
        this.lstvGroundUnitClassData.HideSelection = false;
        this.lstvGroundUnitClassData.Location = new Point(3, 3);
        this.lstvGroundUnitClassData.Margin = new Padding(0, 3, 0, 3);
        this.lstvGroundUnitClassData.Name = "lstvGroundUnitClassData";
        this.lstvGroundUnitClassData.Size = new Size(346, 228);
        this.lstvGroundUnitClassData.TabIndex = 164;
        this.lstvGroundUnitClassData.UseCompatibleStateImageBehavior = false;
        this.lstvGroundUnitClassData.View = View.Details;
        this.columnHeader_20.Width = 240 /*0xF0*/;
        this.columnHeader_21.TextAlign = HorizontalAlignment.Right;
        this.columnHeader_21.Width = 100;
        this.tabKnownSystems.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.tabKnownSystems.Controls.Add(this.lstvSystemSummary);
        this.tabKnownSystems.Controls.Add(this.cboStatus);
        this.tabKnownSystems.Controls.Add(this.tvContacts);
        this.tabKnownSystems.Location = new Point(4, 22);
        this.tabKnownSystems.Name = "tabKnownSystems";
        this.tabKnownSystems.Padding = new Padding(3);
        this.tabKnownSystems.Size = new Size(1046, 579);
        this.tabKnownSystems.TabIndex = 4;
        this.tabKnownSystems.Text = "Known System";
        this.lstvSystemSummary.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.lstvSystemSummary.BorderStyle = BorderStyle.FixedSingle;
        this.lstvSystemSummary.Columns.AddRange(new ColumnHeader[2]
        {
            this.columnHeader_26,
            this.columnHeader_27
        });
        this.lstvSystemSummary.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.lstvSystemSummary.HeaderStyle = ColumnHeaderStyle.None;
        this.lstvSystemSummary.HideSelection = false;
        this.lstvSystemSummary.Location = new Point(352, 33);
        this.lstvSystemSummary.Margin = new Padding(0, 6, 0, 3);
        this.lstvSystemSummary.Name = "lstvSystemSummary";
        this.lstvSystemSummary.Size = new Size(239, 540);
        this.lstvSystemSummary.TabIndex = 157;
        this.lstvSystemSummary.UseCompatibleStateImageBehavior = false;
        this.lstvSystemSummary.View = View.Details;
        this.columnHeader_26.Width = 120;
        this.columnHeader_27.TextAlign = HorizontalAlignment.Right;
        this.columnHeader_27.Width = 110;
        this.cboStatus.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cboStatus.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.cboStatus.FormattingEnabled = true;
        this.cboStatus.Location = new Point(352, 6);
        this.cboStatus.Margin = new Padding(3, 3, 3, 0);
        this.cboStatus.Name = "cboStatus";
        this.cboStatus.Size = new Size(239, 21);
        this.cboStatus.TabIndex = 145;
        this.cboStatus.SelectedIndexChanged += this.cboStatus_SelectedIndexChanged;
        this.tvContacts.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.tvContacts.BorderStyle = BorderStyle.FixedSingle;
        this.tvContacts.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.tvContacts.Location = new Point(6, 6);
        this.tvContacts.Name = "tvContacts";
        this.tvContacts.Size = new Size(340, 567);
        this.tvContacts.TabIndex = 29;
        this.tabSensor.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.tabSensor.Controls.Add(this.cndRenameSensor);
        this.tabSensor.Controls.Add(this.lstvMountingClasses);
        this.tabSensor.Location = new Point(4, 22);
        this.tabSensor.Name = "tabSensor";
        this.tabSensor.Padding = new Padding(3);
        this.tabSensor.Size = new Size(1046, 579);
        this.tabSensor.TabIndex = 5;
        this.tabSensor.Text = "Known Sensor";
        this.cndRenameSensor.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cndRenameSensor.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.cndRenameSensor.Location = new Point(4, 237);
        this.cndRenameSensor.Margin = new Padding(0);
        this.cndRenameSensor.Name = "cndRenameSensor";
        this.cndRenameSensor.Size = new Size(96 /*0x60*/, 30);
        this.cndRenameSensor.TabIndex = 177;
        this.cndRenameSensor.Tag = "1200";
        this.cndRenameSensor.Text = "Rename Sensor";
        this.cndRenameSensor.UseVisualStyleBackColor = false;
        this.cndRenameSensor.Click += this.cndRenameSensor_Click;
        this.lstvMountingClasses.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.lstvMountingClasses.BorderStyle = BorderStyle.FixedSingle;
        this.lstvMountingClasses.Columns.AddRange(new ColumnHeader[1]
        {
            this.columnHeader_28
        });
        this.lstvMountingClasses.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.lstvMountingClasses.HeaderStyle = ColumnHeaderStyle.None;
        this.lstvMountingClasses.HideSelection = false;
        this.lstvMountingClasses.Location = new Point(3, 6);
        this.lstvMountingClasses.Margin = new Padding(0, 3, 0, 3);
        this.lstvMountingClasses.Name = "lstvMountingClasses";
        this.lstvMountingClasses.Size = new Size(346, 228);
        this.lstvMountingClasses.TabIndex = 165;
        this.lstvMountingClasses.UseCompatibleStateImageBehavior = false;
        this.lstvMountingClasses.View = View.Details;
        this.columnHeader_28.Width = 300;
        this.tvIntelligence.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.tvIntelligence.BorderStyle = BorderStyle.FixedSingle;
        this.tvIntelligence.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.tvIntelligence.Location = new Point(5, 213);
        this.tvIntelligence.Margin = new Padding(0, 2, 0, 0);
        this.tvIntelligence.Name = "tvIntelligence";
        this.tvIntelligence.Size = new Size(317, 605);
        this.tvIntelligence.TabIndex = 178;
        this.tvIntelligence.AfterSelect += this.tvIntelligence_AfterSelect;
        this.AutoScaleDimensions = new SizeF(6f, 13f);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.ClientSize = new Size(1384, 854);
        this.Controls.Add(this.tvIntelligence);
        this.Controls.Add(this.tabIntelligence);
        this.Controls.Add(this.flowLayoutPanel12);
        this.Controls.Add(this.flowLayoutPanel8);
        this.Controls.Add(this.flowLayoutPanel7);
        this.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.FormBorderStyle = FormBorderStyle.FixedSingle;
        this.KeyPreview = true;
        this.Name = nameof(Diplomacy);
        this.Text = "Intelligence and Foreign Relations";
        this.FormClosing += this.Diplomacy_FormClosing;
        this.Load += this.Diplomacy_Load;
        this.KeyDown += this.Diplomacy_KeyDown;
        ((ISupportInitialize)this.pbRace).EndInit();
        ((ISupportInitialize)this.pbShip).EndInit();
        ((ISupportInitialize)this.pbFlag).EndInit();
        this.flowLayoutPanel2.ResumeLayout(false);
        this.flowLayoutPanel2.PerformLayout();
        this.flowLayoutPanel1.ResumeLayout(false);
        this.flowLayoutPanel3.ResumeLayout(false);
        this.flowLayoutPanel3.PerformLayout();
        this.flowLayoutPanel7.ResumeLayout(false);
        this.flowLayoutPanel7.PerformLayout();
        this.flowLayoutPanel8.ResumeLayout(false);
        this.flowLayoutPanel9.ResumeLayout(false);
        this.flowLayoutPanel11.ResumeLayout(false);
        this.flowLayoutPanel12.ResumeLayout(false);
        this.tabIntelligence.ResumeLayout(false);
        this.tabClass.ResumeLayout(false);
        this.tabClass.PerformLayout();
        this.flowLayoutPanel4.ResumeLayout(false);
        this.flowLayoutPanel14.ResumeLayout(false);
        this.tabPopulation.ResumeLayout(false);
        this.tabSpecies.ResumeLayout(false);
        ((ISupportInitialize)this.pbSpecies).EndInit();
        this.tabGroundUnits.ResumeLayout(false);
        this.tabKnownSystems.ResumeLayout(false);
        this.tabSensor.ResumeLayout(false);
        this.ResumeLayout(false);
    }
}