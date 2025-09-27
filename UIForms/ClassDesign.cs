// Decompiled with JetBrains decompiler
// Type: ClassDesign
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
public class ClassDesign : Form
{
    private sealed class Class905
    {
        public ClassComponentTemplate186 gclass186_0;

        internal bool method_0(ShipComponent gclass230_0)
        {
            return gclass230_0.int_0 == this.gclass186_0.StandardComponentID;
        }

        internal bool method_1(GClass185 gclass185_0)
        {
            return gclass185_0.int_0 == this.gclass186_0.ShipComponentTemplateID;
        }
    }

    private sealed class Class906
    {
        public ClassComponentTemplate186 gclass186_0;

        internal bool method_0(ShipComponent gclass230_0)
        {
            return gclass230_0.int_0 == this.gclass186_0.StandardComponentID;
        }

        internal bool method_1(GClass185 gclass185_0)
        {
            return gclass185_0.int_0 == this.gclass186_0.ShipComponentTemplateID;
        }
    }

    private sealed class Class907
    {
        public GClass22 gclass22_0;

        internal bool method_0(FCTShipData40 gclass40_0)
        {
            return gclass40_0.gclass22_0 == this.gclass22_0;
        }
    }

    public GClass0 gclass0_0;
    private GameRace gclass21_0;
    private GClass22 gclass22_0;
    private GClass22 gclass22_1;
    private ShipClassTemplate184 gclass184_0;
    private GroundUnitFormationTemplateData gclass102_0;
    private TreeNode treeNode_0;
    private TreeNode treeNode_1;
    private TreeNode treeNode_2;
    private ShipComponent gclass230_0;
    private RaceMissile gclass129_0;
    private GEnum18 genum18_0 = GEnum18.const_1;
    private GEnum18 genum18_1 = GEnum18.const_8;
    private bool bool_0;
    private bool bool_1 = true;
    private bool bool_2;
    private IContainer icontainer_0;
    private TabControl tabDesign;
    private TabPage ClassDesignTab;
    private CheckBox chkShowCivilian;
    private TabPage OrdnanceFightres;
    private TreeView tvClassList;
    private ComboBox cboRaces;
    private TabPage tabPage2;
    private TextBox textBox1;
    private CheckBox chkShowObsolete;
    private FlowLayoutPanel flpMultiples;
    private RadioButton rdo1;
    private RadioButton rdo5;
    private RadioButton rdo20;
    private RadioButton rdo100;
    private TreeView tvComponents;
    private FlowLayoutPanel flpRaceOrClass;
    private RadioButton rdoRace;
    private RadioButton rdoClass;
    private TreeView tvInClass;
    private CheckBox chkShowObsoleteClasses;
    private ListView lstvOrdnance;
    private ColumnHeader columnHeader_0;
    private ColumnHeader columnHeader_1;
    private ColumnHeader columnHeader_2;
    private ColumnHeader columnHeader_3;
    private ColumnHeader columnHeader_4;
    private ColumnHeader columnHeader_5;
    private ColumnHeader columnHeader_6;
    private ColumnHeader columnHeader_7;
    private ColumnHeader columnHeader_8;
    private ColumnHeader columnHeader_9;
    private ColumnHeader columnHeader_10;
    private ListView lstvFighters;
    private ColumnHeader columnHeader_11;
    private ColumnHeader columnHeader_12;
    private ColumnHeader columnHeader_13;
    private ColumnHeader columnHeader_14;
    private ColumnHeader columnHeader_15;
    private ColumnHeader columnHeader_16;
    private CheckBox chkObsoleteMissiles;
    private Panel panel4;
    private Button cmdObsoleteMissile;
    private FlowLayoutPanel flowLayoutPanel7;
    private RadioButton rdoLoadout1;
    private RadioButton rdoLoadout10;
    private RadioButton rdoLoadout100;
    private RadioButton rdoLoadout1000;
    private CheckBox chkObsoleteFighters;
    private ListBox lstClassFighters;
    private ListBox lstClassOrdnance;
    private CheckBox checkBox1;
    private Button cmdObsoleteFighter;
    private TabPage ShipsInClass;
    private TabPage tabPage4;
    private ListView lstvShips;
    private ColumnHeader columnHeader_17;
    private ColumnHeader columnHeader_18;
    private ColumnHeader columnHeader_19;
    private ColumnHeader columnHeader_20;
    private ColumnHeader columnHeader_21;
    private ColumnHeader columnHeader_22;
    private ColumnHeader columnHeader_23;
    private ColumnHeader columnHeader_24;
    private ColumnHeader columnHeader_25;
    private FlowLayoutPanel flowLayoutPanel8;
    private Button cmdSortLaunch;
    private Button cmdSortShipName;
    private Button cmdSortSystemName;
    private Button cmdSortFleetName;
    private Button cmdSortMainClock;
    private TextBox txtDetails;
    private Button cmdSortShoreLeave;
    private Button cndSortFuel;
    private FlowLayoutPanel flowLayoutPanel9;
    private Panel panel12;
    private TextBox txtPriority;
    private Label label16;
    private Panel panel11;
    private TextBox txtFuelPriority;
    private Label label15;
    private Panel panel13;
    private TextBox txtMinFuel;
    private Label label17;
    private ListView lstvCrew;
    private ColumnHeader columnHeader_26;
    private ColumnHeader columnHeader_27;
    private Panel panel3;
    private TextBox txtMaintPriority;
    private Label label1;
    private ComboBox cboFleets;
    private Panel panel5;
    private TextBox txtNumInstantBuild;
    private Label label3;
    private Panel panel7;
    private TextBox txtInstantBuild;
    private Label label2;
    private Button cmdInstantBuild;
    private FlowLayoutPanel pnlInstantBuild;
    private TabPage ComponentsTab;
    private FlowLayoutPanel flowLayoutPanel6;
    private Button cmdSortAmount;
    private Button cmdSortSize;
    private Button cmdSortCost;
    private Button cmdSortCrew;
    private Button cmdSortHTK;
    private ListView lstvComponents;
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
    private Button cmdDAC;
    private Button cmdEDAC;
    private ColumnHeader columnHeader_40;
    private Panel panel6;
    private TextBox txtMinSupplies;
    private Label label7;
    private Panel panel8;
    private TextBox txtSupplyPriority;
    private Label label8;
    private ComboBox cboNamingTheme;
    private Button cmdRenameMissile;
    private FlowLayoutPanel flowLayoutPanel10;
    private Panel panel1;
    private Label label11;
    private FlowLayoutPanel flowLayoutPanel11;
    private Label lblPrefix;
    private TextBox txtPrefix;
    private Label label12;
    private TextBox txtSuffix;
    private CheckBox chkRandomName;
    private CheckBox chkUseAlienTech;
    private FlowLayoutPanel flowLayoutPanel12;
    private Button cmdRenameAll;
    private Button cmdRenumberAll;
    private CheckBox chkPrototypes;
    private CheckBox chkMothership;
    private ComboBox cboMothership;
    private ComboBox cboMothershipClass;
    private Button cmdRenumberHull;
    private TextBox txtSummary;
    private FlowLayoutPanel flowLayoutPanel5;
    private Button cmdRenameComp;
    private Button cndObsoComp;
    private Button cmdDesignTech;
    private Button cmdViewTech;
    private Button cmdRefreshTech;
    private Button cmdArmour;
    private Button cmdNewHull;
    private Button cmdSuperWide;
    private Button cmdDelete;
    private FlowLayoutPanel flowLayoutPanel1;
    private ComboBox cboHullDescription;
    private Label label4;
    private TextBox txtArmourRequired;
    private Label label6;
    private TextBox txtMonths;
    private Label label25;
    private Label txtBuildTime;
    private Label label26;
    private Label txtLoadTime;
    private Label label5;
    private Label txtSize;
    private FlowLayoutPanel flowLayoutPanel2;
    private Button cmdNew;
    private Button cmdRename;
    private Button cmdSelectName;
    private Button cmdLock;
    private Button cmdCopy;
    private Button cmdResearch;
    private FlowLayoutPanel flpToggles;
    private CheckBox chkCollier;
    private CheckBox chkSupplyShip;
    private CheckBox chkTanker;
    private Label label9;
    private CheckBox chkSeniorCO;
    private CheckBox chkConscript;
    private CheckBox chkNoArmour;
    private CheckBox chkHullNumbers;
    private Label label10;
    private CheckBox chkObsolete;
    private CheckBox chkNoOfficers;
    private FlowLayoutPanel flpBands;
    private Label label27;
    private TextBox txtRangeBand;
    private Label label28;
    private TextBox txtTargetSpeed;
    private CheckBox chkShowBands;
    private FlowLayoutPanel flowLayoutPanelMembers;
    private ListBox lstMembers;
    private TextBox txtComponentDetail;
    private TextBox txtDesignErrors;
    private CheckBox chkObsoleteComp;
    private FlowLayoutPanel flowLayoutPanel3;
    private CheckBox chkAssignSquadron;
    private ComboBox cboSquadron;
    private CheckBox chkIncludeParasites;
    private CheckBox chkEnterNames;
    private ListBox lstClassGround;
    private ListView lstvTemplate;
    private ColumnHeader columnHeader_41;
    private ColumnHeader columnHeader_42;
    private ColumnHeader columnHeader_43;
    private ColumnHeader columnHeader_44;
    private ColumnHeader columnHeader_45;
    private ColumnHeader columnHeader_46;
    private ColumnHeader columnHeader_47;
    private ColumnHeader columnHeader_48;
    private ColumnHeader columnHeader_49;
    private FlowLayoutPanel flowLayoutPanel14;
    private FlowLayoutPanel flowLayoutPanel13;
    private FlowLayoutPanel flowLayoutPanel4;
    private CheckBox chkIncludeGround;
    private ListView lstvRefit;
    private ColumnHeader columnHeader_50;
    private ColumnHeader columnHeader_51;
    private ColumnHeader columnHeader_52;
    private Panel panel2;
    private TextBox txtPDProtectionPriority;
    private Label label13;
    private Label label14;
    private ColumnHeader columnHeader_53;
    private Button cmdExportClass;
    private TabPage tabPage1;
    private TreeView tvTemplateList;
    private ListView lstvTemplateComponents;
    private ColumnHeader columnHeader_54;
    private ColumnHeader columnHeader_55;
    private ColumnHeader columnHeader_56;
    private ListView lstvTemplateTech;
    private ColumnHeader columnHeader_57;
    private ColumnHeader columnHeader_58;
    private ColumnHeader columnHeader_59;
    private TextBox txtClassTemplate;
    private FlowLayoutPanel flowLayoutPanel15;
    private Button cmdCreateClass;
    private RadioButton rdoAvailableTech;
    private RadioButton rdoResearchRequired;
    private Label lblInstant;
    private Label lblStartingTechPoints;
    private ListView lstvComponentTechRequired;
    private ColumnHeader columnHeader_60;
    private ColumnHeader columnHeader_61;
    private Button cmdInstantComp;
    private Button cmdInstantTech;
    private Button cmdRenameTemplate;
    private Button cmdDeleteTemplate;
    private ColumnHeader columnHeader_62;
    private Label label19;
    private ColumnHeader columnHeader_63;
    private ComboBox cboAdminCommands;
    private RadioButton rdoFleetIB;
    private RadioButton rdoIBAdmin;
    private FlowLayoutPanel flowLayoutPanel16;
    private Label label18;
    private RadioButton rdoShip;
    private RadioButton rdoFleet;
    private FlowLayoutPanel flowLayoutPanel17;
    private CheckBox chkLargerParasites;
    private Label lblHangarCapacity;
    private Label lblOrdnanceCapacity;
    private Label lblTroopCapacity;
    private CheckBox chkComponentSummary;
    private Button cmdCrewDesign;
    private Button cmdAutoDesign;
    private Button cmdDesignPhilosopy;
    private CheckBox chkHullCategory;
    private Button button1;

    public ClassDesign(GClass0 gclass0_1)
    {
        this.InitializeComponent();
        this.DoubleBuffered = true;
        this.gclass0_0 = gclass0_1;
    }

    private void ClassDesign_FormClosing(object sender, FormClosingEventArgs e)
    {
        try
        {
            this.gclass0_0.method_512(this.Name, this.Left, this.Top);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 229);
        }
    }

    private void ClassDesign_Load(object sender, EventArgs e)
    {
        try
        {
            WindowPosition207 gclass207 = this.gclass0_0.method_513(this.Name);
            this.Left = gclass207.Left;
            this.Top = gclass207.Top;
            this.gclass0_0.bool_9 = true;
            this.method_13(true);
            this.bool_0 = true;
            this.gclass0_0.method_577(this.cboRaces);
            this.gclass0_0.method_570(this.cboHullDescription);
            this.gclass0_0.method_552(this.cboNamingTheme);
            this.gclass0_0.method_500(this.tvTemplateList);
            this.gclass0_0.bool_9 = false;
            if (!this.gclass0_0.bool_8 && !(this.gclass21_0.StartBuildPoints > 0M))
                this.cmdInstantBuild.Visible = false;
            else
                this.cmdInstantBuild.Visible = true;
            if (this.gclass0_0.bool_17)
                this.method_14();
            if (!this.gclass0_0.bool_10)
                return;
            this.cmdAutoDesign.Visible = true;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 230);
        }
    }

    public void method_0(GameRace gclass21_1)
    {
        try
        {
            this.bool_0 = true;
            this.cboRaces.SelectedItem = gclass21_1;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 231);
        }
    }

    private void cboRaces_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            this.gclass21_0 = (GameRace)this.cboRaces.SelectedValue;
            this.gclass21_0.method_378(this.tvClassList, this.chkShowCivilian.CheckState,
                this.chkShowObsoleteClasses.CheckState, this.chkObsoleteComp.CheckState,
                this.chkHullCategory.CheckState);
            this.gclass21_0.method_384(this.tvComponents, this.chkShowObsolete.CheckState,
                this.chkUseAlienTech.CheckState, this.chkPrototypes.CheckState);
            this.gclass21_0.method_315(this.lstvFighters, null, this.chkObsoleteFighters.CheckState,
                this.chkLargerParasites.CheckState);
            this.gclass21_0.method_316(this.lstvOrdnance, this.chkObsoleteMissiles.CheckState, false);
            this.gclass21_0.method_214(this.lstvTemplate, null, this.chkShowCivilian.CheckState, null,
                CheckState.Unchecked);
            this.gclass21_0.method_180(this.cboFleets);
            this.gclass21_0.method_181(this.cboAdminCommands);
            this.chkHullCategory.CheckState = this.gclass21_0.chkHullCategory;
            this.pnlInstantBuild.Visible = false;
            this.lblStartingTechPoints.Visible = false;
            this.lblInstant.Visible = false;
            this.cmdInstantComp.Visible = false;
            this.cmdInstantTech.Visible = false;
            if (this.gclass0_0.bool_8 || this.gclass21_0.StartBuildPoints > 0M)
            {
                this.txtInstantBuild.Text = AuroraUtils.smethod_38(this.gclass21_0.StartBuildPoints);
                this.pnlInstantBuild.Visible = true;
            }

            if (this.gclass0_0.bool_8 || this.gclass21_0.StartTechPoints > 0)
            {
                this.lblStartingTechPoints.Text = AuroraUtils.smethod_37(this.gclass21_0.StartTechPoints);
                this.lblInstant.Visible = true;
                this.lblStartingTechPoints.Visible = true;
                this.cmdInstantComp.Visible = true;
                this.cmdInstantTech.Visible = true;
            }

            if (!this.bool_0)
                this.gclass0_0.method_511(this.gclass21_0, this);
            this.bool_0 = false;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 232);
        }
    }

    private void chkObsoleteComp_Click(object sender, EventArgs e)
    {
        try
        {
            this.gclass21_0.method_378(this.tvClassList, this.chkShowCivilian.CheckState,
                this.chkShowObsoleteClasses.CheckState, this.chkObsoleteComp.CheckState,
                this.chkHullCategory.CheckState);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 233);
        }
    }

    private void chkPrototypes_CheckedChanged(object sender, EventArgs e)
    {
        try
        {
            this.gclass21_0.method_384(this.tvComponents, this.chkShowObsolete.CheckState,
                this.chkUseAlienTech.CheckState, this.chkPrototypes.CheckState);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 234);
        }
    }

    private void cboHullDescription_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass0_0.bool_9 || this.gclass22_0 == null)
                return;
            this.gclass22_0.gclass76_0 = (ShipHull)this.cboHullDescription.SelectedItem;
            TreeNode treeNode = this.method_3(this.gclass22_0.gclass76_0);
            if (treeNode != null)
            {
                this.bool_2 = true;
                this.treeNode_0.Remove();
                this.bool_2 = false;
                treeNode.Nodes.Add(this.treeNode_0);
                this.tvClassList.SelectedNode = this.treeNode_0;
            }
            else
            {
                this.gclass21_0.method_378(this.tvClassList, this.chkShowCivilian.CheckState,
                    this.chkShowObsoleteClasses.CheckState, this.chkObsoleteComp.CheckState,
                    this.chkHullCategory.CheckState);
                this.method_2(this.gclass22_0);
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 235);
        }
    }

    private void tvClassList_AfterSelect(object sender, TreeViewEventArgs e)
    {
        try
        {
            if (this.bool_2 || !(e.Node.Tag is GClass22))
                return;
            this.treeNode_0 = e.Node;
            this.gclass22_0 = (GClass22)e.Node.Tag;
            if (this.gclass22_0 == null)
                return;
            if (this.gclass22_0.bool_3)
                this.cmdLock.Text = "Unlock Design";
            else
                this.cmdLock.Text = "Lock Design";
            this.method_1();
            this.tvComponents.SelectedNode = null;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 236);
        }
    }

    public void method_1()
    {
        try
        {
            if (this.gclass22_0 == null)
                return;
            int int_69 = 0;
            int int_70 = 0;
            if (this.chkShowBands.CheckState == CheckState.Checked)
            {
                int_69 = AuroraUtils.smethod_67(this.txtTargetSpeed.Text);
                int_70 = AuroraUtils.smethod_67(this.txtRangeBand.Text);
            }

            this.gclass22_0.method_86(int_69, int_70, "", this.treeNode_0);
            this.txtSummary.Text = this.gclass22_0.string_0;
            this.txtDesignErrors.Text = this.gclass22_0.string_2;
            this.gclass22_0.method_71(this.tvInClass);
            this.gclass22_0.method_66(this.lstMembers);
            this.gclass22_0.method_69(this.lstvShips, this.genum18_1);
            this.gclass22_0.method_64(this.lstvComponents, this.genum18_0, this.chkComponentSummary.CheckState);
            this.gclass22_0.method_67(this.cboMothershipClass);
            this.gclass22_0.method_68(this.cboSquadron);
            this.gclass22_0.method_26(this.lstvRefit);
            this.gclass21_0.method_315(this.lstvFighters, this.gclass22_0, this.chkObsoleteFighters.CheckState,
                this.chkLargerParasites.CheckState);
            this.gclass0_0.bool_9 = true;
            this.chkTanker.CheckState = AuroraUtils.smethod_26(this.gclass22_0.int_23);
            this.chkSupplyShip.CheckState = AuroraUtils.smethod_26(this.gclass22_0.int_52);
            this.chkCollier.CheckState = AuroraUtils.smethod_26(this.gclass22_0.int_5);
            this.chkSeniorCO.CheckState = AuroraUtils.smethod_26(this.gclass22_0.int_6);
            this.chkConscript.CheckState = AuroraUtils.smethod_26(this.gclass22_0.int_10);
            this.chkNoOfficers.CheckState = AuroraUtils.smethod_26(this.gclass22_0.int_15);
            this.chkObsolete.CheckState = AuroraUtils.smethod_26(this.gclass22_0.int_38);
            this.chkNoArmour.CheckState = AuroraUtils.smethod_26(this.gclass22_0.int_37);
            this.chkShowBands.CheckState = AuroraUtils.smethod_26(this.gclass22_0.int_49);
            this.chkRandomName.CheckState = AuroraUtils.smethod_26(this.gclass22_0.int_35);
            this.chkHullNumbers.CheckState = AuroraUtils.smethod_26(this.gclass22_0.int_65);
            this.txtMonths.Text = this.gclass22_0.decimal_9.ToString();
            this.txtArmourRequired.Text = this.gclass22_0.int_2.ToString();
            this.txtSize.Text = AuroraUtils.FormatNumberToDigits(this.gclass22_0.decimal_14, 4).ToString();
            this.txtLoadTime.Text = AuroraUtils.smethod_71(this.gclass22_0.method_93()).ToString();
            this.txtBuildTime.Text = AuroraUtils.FormatNumberToDigits(this.gclass22_0.method_92(), 2).ToString();
            this.txtDetails.Text = this.gclass22_0.string_1;
            this.txtPriority.Text = this.gclass22_0.int_8.ToString();
            this.txtMinFuel.Text = this.gclass22_0.int_46.ToString();
            this.txtMinSupplies.Text = this.gclass22_0.int_47.ToString();
            this.txtMaintPriority.Text = this.gclass22_0.int_34.ToString();
            this.txtFuelPriority.Text = this.gclass22_0.int_44.ToString();
            this.txtSupplyPriority.Text = this.gclass22_0.int_45.ToString();
            this.txtPDProtectionPriority.Text = this.gclass22_0.int_16.ToString();
            if (this.gclass22_0.string_3 == "")
                this.txtPrefix.Text = "None";
            else
                this.txtPrefix.Text = this.gclass22_0.string_3;
            if (this.gclass22_0.string_4 == "")
                this.txtSuffix.Text = "None";
            else
                this.txtSuffix.Text = this.gclass22_0.string_4;
            this.cboHullDescription.SelectedItem = this.gclass22_0.gclass76_0;
            this.gclass22_0.method_62(this.lstClassOrdnance, this.lblOrdnanceCapacity);
            this.gclass22_0.method_60(this.lstClassFighters, this.lblHangarCapacity);
            this.gclass22_0.method_61(this.lstClassGround, this.lblTroopCapacity);
            if (this.gclass22_0.gclass21_0.SpecialNPRID != SpecialNPRIDs.StarSwarm)
                this.gclass22_0.method_79(this.lstvCrew);
            this.cboNamingTheme.SelectedItem = this.gclass22_0.gclass140_0;
            this.gclass0_0.bool_9 = false;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 237);
        }
    }

    private void cmdNew_Click(object sender, EventArgs e)
    {
        try
        {
            this.gclass22_0 = this.gclass21_0.method_306((ShipHull)this.cboHullDescription.SelectedItem);
            this.gclass21_0.method_378(this.tvClassList, this.chkShowCivilian.CheckState,
                this.chkShowObsoleteClasses.CheckState, this.chkObsoleteComp.CheckState,
                this.chkHullCategory.CheckState);
            this.method_2(this.gclass22_0);
            this.method_1();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 238);
        }
    }

    private void cmdCopy_Click(object sender, EventArgs e)
    {
        try
        {
            this.gclass22_0 = this.gclass21_0.method_310(this.gclass22_0, null, false);
            if (this.gclass22_0.int_38 == 1 && this.chkShowObsoleteClasses.CheckState == CheckState.Unchecked)
                this.chkShowObsoleteClasses.CheckState = CheckState.Checked;
            this.gclass21_0.method_378(this.tvClassList, this.chkShowCivilian.CheckState,
                this.chkShowObsoleteClasses.CheckState, this.chkObsoleteComp.CheckState,
                this.chkHullCategory.CheckState);
            this.method_2(this.gclass22_0);
            this.method_1();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 239);
        }
    }

    private void cmdDelete_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass22_0 == null ||
                MessageBox.Show($" Are you sure you want to delete {this.gclass22_0.ClassName}?",
                    "Confirmation Required", MessageBoxButtons.YesNo) != DialogResult.Yes ||
                !this.gclass21_0.method_309(this.gclass22_0))
                return;
            this.gclass21_0.method_378(this.tvClassList, this.chkShowCivilian.CheckState,
                this.chkShowObsoleteClasses.CheckState, this.chkObsoleteComp.CheckState,
                this.chkHullCategory.CheckState);
            if (this.tvClassList.Nodes.Count <= 0)
                return;
            this.tvClassList.Nodes[0].Expand();
            this.tvClassList.SelectedNode = this.tvClassList.Nodes[0].Nodes[0];
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 240 /*0xF0*/);
        }
    }

    private void method_2(GClass22 gclass22_2)
    {
        try
        {
            foreach (TreeNode node1 in this.tvClassList.Nodes)
            {
                foreach (TreeNode node2 in node1.Nodes)
                {
                    if (node2.Tag is GClass22 && node2.Tag == gclass22_2)
                    {
                        node2.Parent.Expand();
                        this.tvClassList.SelectedNode = node2;
                        return;
                    }
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 241);
        }
    }

    private TreeNode method_3(ShipHull gclass76_0)
    {
        try
        {
            foreach (TreeNode node in this.tvClassList.Nodes)
            {
                if (node.Tag is ShipHull && node.Tag == gclass76_0)
                {
                    node.Expand();
                    return node;
                }
            }

            return null;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3206);
            return null;
        }
    }

    private void tvComponents_DoubleClick(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass22_0 == null)
                return;
            if (this.gclass22_0.bool_3)
            {
                int num = (int)MessageBox.Show("Class cannot be modified while locked");
            }
            else
                this.method_4();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 242);
        }
    }

    private void method_4()
    {
        try
        {
            if (this.gclass22_0 == null || this.tvComponents.SelectedNode == null ||
                this.tvComponents.SelectedNode.Tag == null || !(this.tvComponents.SelectedNode.Tag is ShipComponent))
                return;
            this.gclass230_0 = (ShipComponent)this.tvComponents.SelectedNode.Tag;
            this.txtComponentDetail.Text = this.gclass230_0.method_14();
            if (this.gclass230_0 == null || this.gclass22_0 == null)
                return;
            if (this.gclass22_0.bool_3)
            {
                int num = (int)MessageBox.Show("Class cannot be modified while locked");
            }
            else
            {
                this.gclass22_0.method_51(this.gclass230_0, this.method_7());
                this.method_1();
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3505);
        }
    }

    private void tvInClass_DoubleClick(object sender, EventArgs e)
    {
        try
        {
            this.method_5();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 243);
        }
    }

    private void method_5()
    {
        try
        {
            if (this.gclass22_0 == null || this.tvInClass.SelectedNode == null)
                return;
            if (!(this.tvInClass.SelectedNode.Tag is GClass228))
                return;
            GClass228 tag = (GClass228)this.tvInClass.SelectedNode.Tag;
            this.gclass230_0 = tag.gclass230_0;
            this.txtComponentDetail.Text = this.gclass230_0.method_14();
            TreeNode selectedNode = this.tvInClass.SelectedNode;
            if (this.gclass230_0 == null || this.gclass22_0 == null)
                return;
            if (this.gclass22_0.bool_3)
            {
                int num = (int)MessageBox.Show("Class cannot be modified while locked");
            }
            else
            {
                this.gclass22_0.method_52(this.gclass230_0, this.method_7());
                this.method_1();
                this.method_6(tag);
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3507);
        }
    }

    private void method_6(GClass228 gclass228_0)
    {
        try
        {
            foreach (TreeNode node1 in this.tvInClass.Nodes)
            {
                foreach (TreeNode node2 in node1.Nodes)
                {
                    if (node2.Tag is GClass228 && node2.Tag == gclass228_0)
                    {
                        node2.Parent.Expand();
                        this.tvInClass.SelectedNode = node2;
                        return;
                    }
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 241);
        }
    }

    private void cmdArmour_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass22_0 == null)
                return;
            if (this.gclass22_0.bool_3)
            {
                int num = (int)MessageBox.Show("Class cannot be modified while locked");
            }
            else
            {
                this.gclass22_0.method_53();
                this.method_1();
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3192);
        }
    }

    public int method_7()
    {
        if (this.rdo1.Checked)
            return 1;
        if (this.rdo5.Checked)
            return 5;
        if (this.rdo20.Checked)
            return 20;
        return this.rdo100.Checked ? 100 : 0;
    }

    public int method_8()
    {
        if (this.rdoLoadout1.Checked)
            return 1;
        if (this.rdoLoadout10.Checked)
            return 10;
        if (this.rdoLoadout100.Checked)
            return 100;
        return this.rdoLoadout1000.Checked ? 1000 : 0;
    }

    private void tvComponents_AfterSelect(object sender, TreeViewEventArgs e)
    {
        try
        {
            if (!(e.Node.Tag is ShipComponent))
                return;
            this.treeNode_1 = e.Node;
            this.bool_1 = true;
            this.gclass230_0 = (ShipComponent)e.Node.Tag;
            this.txtComponentDetail.Text = this.gclass230_0.method_14();
            if (this.gclass230_0.genum86_0 == GEnum86.const_1)
                this.cmdResearch.Visible = true;
            else
                this.cmdResearch.Visible = false;
            this.cndObsoComp.Visible = this.gclass230_0.gclass231_0.bObsoleteAllowed;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 244);
        }
    }

    private void tvComponents_AfterExpand(object sender, TreeViewEventArgs e)
    {
        try
        {
            if (!(e.Node.Tag is ComponentTypeData))
                return;
            ((ComponentTypeData)e.Node.Tag).bool_3 = e.Node.IsExpanded;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 245);
        }
    }

    private void tvInClass_AfterSelect(object sender, TreeViewEventArgs e)
    {
        try
        {
            if (this.gclass22_0 == null || !(e.Node.Tag is GClass228))
                return;
            GClass228 tag = (GClass228)e.Node.Tag;
            this.gclass230_0 = tag.gclass230_0;
            this.bool_1 = false;
            this.txtComponentDetail.Text = this.gclass230_0.method_14();
            if (this.gclass230_0.genum86_0 == GEnum86.const_1)
                this.cmdResearch.Visible = true;
            else
                this.cmdResearch.Visible = false;
            if (tag.gclass230_0.gclass164_0.gclass21_0 == null)
                this.cndObsoComp.Visible = false;
            else
                this.cndObsoComp.Visible = true;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 246);
        }
    }

    private void tvClassList_AfterExpand(object sender, TreeViewEventArgs e)
    {
        try
        {
            if (!(e.Node.Tag is ShipHull))
                return;
            ((ShipHull)e.Node.Tag).bool_0 = e.Node.IsExpanded;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 247);
        }
    }

    private void chkRandomName_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass22_0 == null || this.gclass0_0.bool_9)
                return;
            CheckBox checkBox = (CheckBox)sender;
            string name = checkBox.Name;
            if (name != null)
            {
                switch (name.Length)
                {
                    case 9:
                        if (name == "chkTanker")
                        {
                            this.gclass22_0.int_23 = AuroraUtils.CheckStateToInt(checkBox.CheckState);
                            if (this.gclass22_0.int_46 == 0 && this.gclass22_0.int_23 == 1)
                            {
                                this.gclass22_0.int_46 = (int)Math.Ceiling(this.gclass22_0.int_63 * 0.1);
                                this.txtMinFuel.Text = this.gclass22_0.int_46.ToString();
                                int num = (int)MessageBox.Show(
                                    $"Minimum fuel capacity set to {AuroraUtils.smethod_37(this.gclass22_0.int_46)}. This can be adjusted on the Miscellaneous tab");
                                break;
                            }

                            break;
                        }

                        break;
                    case 10:
                        if (name == "chkCollier")
                        {
                            this.gclass22_0.int_5 = AuroraUtils.CheckStateToInt(checkBox.CheckState);
                            break;
                        }

                        break;
                    case 11:
                        switch (name[3])
                        {
                            case 'N':
                                if (name == "chkNoArmour")
                                {
                                    if (this.gclass22_0.bool_3)
                                    {
                                        int num = (int)MessageBox.Show("Class cannot be modified while locked");
                                        return;
                                    }

                                    this.gclass22_0.int_37 = AuroraUtils.CheckStateToInt(checkBox.CheckState);
                                    if (this.gclass22_0.int_37 == 1)
                                    {
                                        this.gclass22_0.method_83();
                                        break;
                                    }

                                    break;
                                }

                                break;
                            case 'O':
                                if (name == "chkObsolete")
                                {
                                    this.gclass22_0.int_38 = AuroraUtils.CheckStateToInt(checkBox.CheckState);
                                    break;
                                }

                                break;
                            case 'S':
                                if (name == "chkSeniorCO")
                                {
                                    this.gclass22_0.int_6 = AuroraUtils.CheckStateToInt(checkBox.CheckState);
                                    break;
                                }

                                break;
                        }

                        break;
                    case 12:
                        switch (name[3])
                        {
                            case 'C':
                                if (name == "chkConscript")
                                {
                                    this.gclass22_0.int_10 = AuroraUtils.CheckStateToInt(checkBox.CheckState);
                                    break;
                                }

                                break;
                            case 'S':
                                if (name == "chkShowBands")
                                {
                                    this.gclass22_0.int_49 = AuroraUtils.CheckStateToInt(checkBox.CheckState);
                                    break;
                                }

                                break;
                        }

                        break;
                    case 13:
                        switch (name[3])
                        {
                            case 'N':
                                if (name == "chkNoOfficers")
                                {
                                    this.gclass22_0.int_15 = AuroraUtils.CheckStateToInt(checkBox.CheckState);
                                    break;
                                }

                                break;
                            case 'R':
                                if (name == "chkRandomName")
                                {
                                    this.gclass22_0.int_35 = AuroraUtils.CheckStateToInt(checkBox.CheckState);
                                    break;
                                }

                                break;
                            case 'S':
                                if (name == "chkSupplyShip")
                                {
                                    this.gclass22_0.int_52 = AuroraUtils.CheckStateToInt(checkBox.CheckState);
                                    break;
                                }

                                break;
                        }

                        break;
                    case 14:
                        if (name == "chkHullNumbers")
                        {
                            this.gclass22_0.int_65 = AuroraUtils.CheckStateToInt(checkBox.CheckState);
                            this.method_1();
                            break;
                        }

                        break;
                }
            }

            this.method_1();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3201);
        }
    }

    private void rdoClass_CheckedChanged(object sender, EventArgs e)
    {
        try
        {
            if (this.rdoRace.Checked)
            {
                this.tvComponents.Visible = true;
                this.tvInClass.Visible = false;
            }
            else
            {
                this.tvComponents.Visible = false;
                this.tvInClass.Visible = true;
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3761);
        }
    }

    private void method_9(object sender, EventArgs e) => this.Close();

    private void cmdRename_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass22_0 == null)
            {
                int num1 = (int)MessageBox.Show("Please select a class");
            }
            else
            {
                this.gclass0_0.string_3 = "Enter New Class Name";
                this.gclass0_0.string_4 = this.gclass22_0.ClassName;
                int num2 = (int)new MessageEntry(this.gclass0_0).ShowDialog();
                if (!(this.gclass0_0.string_4 != this.gclass22_0.ClassName) || this.gclass0_0.bool_21)
                    return;
                this.gclass22_0.ClassName = this.gclass0_0.string_4;
                this.gclass22_0.genum16_0 = this.gclass0_0.method_590(this.gclass22_0.genum16_0, GEnum17.const_0);
                this.tvClassList.SelectedNode.Text = this.gclass22_0.ClassName;
                this.method_1();
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 248);
        }
    }

    private void cmdNewHull_Click(object sender, EventArgs e)
    {
        try
        {
            this.gclass0_0.string_3 = "Enter New Hull Name";
            this.gclass0_0.string_4 = "Hull Name";
            Form form = new MessageEntry(this.gclass0_0);
            int num1 = (int)form.ShowDialog();
            if (!(this.gclass0_0.string_4 != "Hull Name") || !(this.gclass0_0.string_4 != "") || this.gclass0_0.bool_21)
                return;
            ShipHull gclass76 = new ShipHull();
            gclass76.ShipHullDescriptionID = this.gclass0_0.method_26(GEnum0.const_20);
            gclass76.Description = this.gclass0_0.string_4;
            gclass76.genum16_0 = GEnum16.const_2;
            this.gclass0_0.string_3 = "Enter New Hull Abbreviation";
            this.gclass0_0.string_4 = AuroraUtils.smethod_25(this.gclass0_0.string_4, 3);
            int num2 = (int)form.ShowDialog();
            if (!(this.gclass0_0.string_4 != ""))
                return;
            gclass76.Abbreviation = this.gclass0_0.string_4;
            gclass76.Combined = $"{gclass76.Description}  {gclass76.Abbreviation}";
            if (this.gclass22_0 != null)
                this.gclass22_0.gclass76_0 = gclass76;
            this.gclass0_0.ShipHullDictionary.Add(gclass76.ShipHullDescriptionID, gclass76);
            this.gclass0_0.bool_9 = true;
            this.gclass0_0.method_570(this.cboHullDescription);
            this.gclass0_0.bool_9 = false;
            this.method_1();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 249);
        }
    }

    private void cmdRefreshTech_Click(object sender, EventArgs e)
    {
        try
        {
            this.gclass21_0.method_384(this.tvComponents, this.chkShowObsolete.CheckState,
                this.chkUseAlienTech.CheckState, this.chkPrototypes.CheckState);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 250);
        }
    }

    private void method_10(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass230_0.gclass164_0.dictionary_0[this.gclass21_0.RaceID].bool_0)
                this.gclass230_0.gclass164_0.dictionary_0[this.gclass21_0.RaceID].bool_0 = false;
            else
                this.gclass230_0.gclass164_0.dictionary_0[this.gclass21_0.RaceID].bool_0 = true;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 251);
        }
    }

    private void chkObsoleteMissiles_CheckedChanged(object sender, EventArgs e)
    {
        try
        {
            this.gclass21_0.method_316(this.lstvOrdnance, this.chkObsoleteMissiles.CheckState, false);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 252);
        }
    }

    private void chkObsoleteFighters_CheckedChanged(object sender, EventArgs e)
    {
        try
        {
            this.gclass21_0.method_315(this.lstvFighters, this.gclass22_0, this.chkObsoleteMissiles.CheckState,
                this.chkLargerParasites.CheckState);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 253);
        }
    }

    private void cmdObsoleteMissile_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass129_0 == null)
            {
                int num = (int)MessageBox.Show("Please select a missile");
            }
            else
            {
                this.gclass129_0.gclass164_0.dictionary_0[this.gclass21_0.RaceID].bool_0 =
                    !this.gclass129_0.gclass164_0.dictionary_0[this.gclass21_0.RaceID].bool_0;
                this.gclass21_0.method_316(this.lstvOrdnance, this.chkObsoleteMissiles.CheckState, false);
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 254);
        }
    }

    private void cmdObsoleteFighter_Click(object sender, EventArgs e)
    {
        try
        {
            this.gclass22_1.int_38 = this.gclass22_1.int_38 != 1 ? 1 : 0;
            this.gclass21_0.method_315(this.lstvFighters, this.gclass22_0, this.chkObsoleteMissiles.CheckState,
                this.chkLargerParasites.CheckState);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 255);
        }
    }

    private void lstvOrdnance_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            if (this.lstvOrdnance.SelectedItems.Count <= 0)
                return;
            this.gclass129_0 = (RaceMissile)this.lstvOrdnance.SelectedItems[0].Tag;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 256 /*0x0100*/);
        }
    }

    private void lstvFighters_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            if (this.lstvFighters.SelectedItems.Count <= 0)
                return;
            this.gclass22_1 = (GClass22)this.lstvFighters.SelectedItems[0].Tag;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 257);
        }
    }

    private void lstvOrdnance_DoubleClick(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass129_0 == null || this.gclass22_0 == null)
                return;
            this.gclass22_0.method_54(this.gclass129_0, this.method_8());
            this.method_1();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 258);
        }
    }

    private void lstvFighters_DoubleClick(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass22_1 == null || this.gclass22_0 == null)
                return;
            this.gclass22_0.method_56(this.gclass22_1, this.method_8());
            this.method_1();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 259);
        }
    }

    private void lstClassOrdnance_DoubleClick(object sender, EventArgs e)
    {
        try
        {
            if (this.lstClassOrdnance.SelectedItems.Count <= 0 || this.gclass22_0 == null)
                return;
            this.gclass22_0.method_55((GClass130)this.lstClassOrdnance.SelectedItem, this.method_8());
            this.method_1();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 260);
        }
    }

    private void lstClassFighters_DoubleClick(object sender, EventArgs e)
    {
        try
        {
            if (this.lstClassFighters.SelectedItems.Count <= 0 || this.gclass22_0 == null)
                return;
            this.gclass22_0.method_58((GClass74)this.lstClassFighters.SelectedItem, this.method_8());
            this.method_1();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 261);
        }
    }

    private void cmdEDAC_Click(object sender, EventArgs e)
    {
        try
        {
            string name = ((Control)sender).Name;
            if (name != null)
            {
                switch (name.Length)
                {
                    case 6:
                        if (name == "cmdDAC")
                        {
                            this.genum18_0 = GEnum18.const_12;
                            break;
                        }

                        break;
                    case 7:
                        if (name == "cmdEDAC")
                        {
                            this.genum18_0 = GEnum18.const_13;
                            break;
                        }

                        break;
                    case 10:
                        if (name == "cmdSortHTK")
                        {
                            this.genum18_0 = GEnum18.const_4;
                            break;
                        }

                        break;
                    case 11:
                        switch (name[8])
                        {
                            case 'i':
                                if (name == "cmdSortSize")
                                {
                                    this.genum18_0 = GEnum18.const_2;
                                    break;
                                }

                                break;
                            case 'o':
                                if (name == "cmdSortCost")
                                {
                                    this.genum18_0 = GEnum18.const_1;
                                    break;
                                }

                                break;
                            case 'r':
                                if (name == "cmdSortCrew")
                                {
                                    this.genum18_0 = GEnum18.const_3;
                                    break;
                                }

                                break;
                        }

                        break;
                    case 13:
                        if (name == "cmdSortAmount")
                        {
                            this.genum18_0 = GEnum18.const_0;
                            break;
                        }

                        break;
                }
            }

            if (this.gclass22_0 == null)
                return;
            this.gclass22_0.method_64(this.lstvComponents, this.genum18_0, this.chkComponentSummary.CheckState);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 262);
        }
    }

    private void txtArmourRequired_TextChanged(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass0_0.bool_9 || this.gclass22_0 == null || !(this.txtArmourRequired.Text != ""))
                return;
            if (this.gclass22_0.bool_3 && !this.gclass0_0.bool_9)
            {
                int num = (int)MessageBox.Show("Class cannot be modified while locked");
            }
            else
            {
                int result = 1;
                if (!int.TryParse(this.txtArmourRequired.Text, out result))
                    return;
                if (result < 1 && this.gclass22_0.int_37 == 0)
                {
                    result = 1;
                    this.txtArmourRequired.Text = "1";
                }

                this.gclass22_0.int_2 = result;
                this.method_1();
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 263);
        }
    }

    private void txtPriority_TextChanged(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass22_0 == null || !(this.txtPriority.Text != ""))
                return;
            this.gclass22_0.int_8 = Convert.ToInt32(this.txtPriority.Text);
            if (this.gclass22_0.int_8 < 1)
                this.gclass22_0.int_8 = 1;
            this.method_1();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 264);
        }
    }

    private void txtMinFuel_TextChanged(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass22_0 == null || !(this.txtMinFuel.Text != ""))
                return;
            this.gclass22_0.int_46 = Convert.ToInt32(this.txtMinFuel.Text);
            this.method_1();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 265);
        }
    }

    private void txtFuelPriority_TextChanged(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass22_0 == null || !(this.txtFuelPriority.Text != ""))
                return;
            this.gclass22_0.int_44 = Convert.ToInt32(this.txtFuelPriority.Text);
            if (this.gclass22_0.int_44 < 1)
                this.gclass22_0.int_44 = 1;
            this.method_1();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 266);
        }
    }

    private void method_11(object sender, EventArgs e)
    {
        try
        {
            this.gclass22_0 = this.gclass21_0.method_11(this.gclass0_0.AutomatedClassDesignDictionary[AutomatedClassDesignType.BeamArmedScout], null, "");
            this.gclass21_0.method_378(this.tvClassList, this.chkShowCivilian.CheckState,
                this.chkShowObsoleteClasses.CheckState, this.chkShowObsolete.CheckState,
                this.chkHullCategory.CheckState);
            this.method_2(this.gclass22_0);
            this.method_1();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 267);
        }
    }

    private void method_12(object sender, EventArgs e)
    {
        try
        {
            this.gclass21_0.method_9(false, null);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 268);
        }
    }

    private void txtMonths_TextChanged(object sender, EventArgs e)
    {
        if (this.gclass22_0 == null || !(this.txtMonths.Text != ""))
            return;
        if (this.gclass22_0.bool_3 && !this.gclass0_0.bool_9)
        {
            int num = (int)MessageBox.Show("Class cannot be modified while locked");
        }
        else
        {
            ParsedDecimal gclass208 = AuroraUtils.ParseDecimalString(this.txtMonths.Text);
            if (!gclass208.Succeed || gclass208.Value <= 0M || gclass208.Value == this.gclass22_0.decimal_9)
                return;
            this.gclass22_0.decimal_9 = gclass208.Value;
            this.method_1();
        }
    }

    private void txtMaintPriority_TextChanged(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass22_0 == null || !(this.txtMaintPriority.Text != ""))
                return;
            this.gclass22_0.int_34 = Convert.ToInt32(this.txtMaintPriority.Text);
            if (this.gclass22_0.int_34 < 1)
                this.gclass22_0.int_34 = 1;
            this.method_1();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 269);
        }
    }

    private void cmdInstantBuild_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass22_0 == null)
                return;
            if (this.gclass22_0.method_28())
            {
                int num1 = (int)MessageBox.Show("You cannot create ships with prototype components");
            }
            else
            {
                FleetData gclass85_0 = null;
                NavalAdminCommand gclass83_1 = null;
                if (this.cboFleets.Visible)
                    gclass85_0 = (FleetData)this.cboFleets.SelectedItem;
                else
                    gclass83_1 = (NavalAdminCommand)this.cboAdminCommands.SelectedItem;
                GClass194 gclass194_1 = this.gclass21_0.method_164();
                int int32 = Convert.ToInt32(this.txtNumInstantBuild.Text);
                if (int32 == 0)
                    return;
                for (int index1 = 1; index1 <= int32; ++index1)
                {
                    FCTShipData40 gclass40_2_1 = null;
                    FCTSquadronData70 gclass70_1 = null;
                    if (this.chkMothership.CheckState == CheckState.Checked)
                    {
                        gclass40_2_1 = (FCTShipData40)this.cboMothership.SelectedValue;
                        if (gclass40_2_1.method_125() < this.gclass22_0.decimal_14)
                            gclass40_2_1 = null;
                    }

                    if (this.chkAssignSquadron.CheckState == CheckState.Checked)
                    {
                        gclass70_1 = (FCTSquadronData70)this.cboSquadron.SelectedValue;
                        if (gclass70_1 != null)
                        {
                            gclass40_2_1 = gclass70_1.ParentShipData;
                            if (gclass40_2_1.method_125() < this.gclass22_0.decimal_14)
                            {
                                gclass40_2_1 = null;
                                gclass70_1 = null;
                            }
                        }
                    }

                    string string_10_1 = this.gclass22_0.method_39();
                    if (this.chkEnterNames.CheckState == CheckState.Checked)
                    {
                        this.gclass0_0.string_3 = "Enter Ship Name";
                        this.gclass0_0.string_4 = string_10_1;
                        int num2 = (int)new MessageEntry(this.gclass0_0).ShowDialog();
                        if (this.gclass0_0.string_4 != string_10_1 && !this.gclass0_0.bool_21)
                            string_10_1 = this.gclass0_0.string_4;
                    }

                    FCTShipData40 gclass40_2_2 = this.gclass21_0.method_304(null, null, null, this.gclass22_0,
                        gclass85_0, gclass83_1, gclass194_1, gclass40_2_1, null, string_10_1, AuroraUtils.int_26, true,
                        true, GEnum20.const_2);
                    gclass40_2_2.SquadronData = gclass70_1;
                    this.gclass21_0.StartBuildPoints -= (int)this.gclass22_0.decimal_4;
                    if (this.chkIncludeGround.CheckState == CheckState.Checked && this.gclass22_0.list_2.Count > 0)
                        gclass40_2_2.method_50();
                    if (this.chkIncludeParasites.CheckState == CheckState.Checked &&
                        gclass40_2_2.gclass22_0.list_1.Count > 0 && gclass40_2_2.gclass22_0.decimal_8 > 0M)
                    {
                        FCTSquadronData70 gclass70_2 = gclass40_2_2.method_186(gclass40_2_2.ShipName + " Strikegroup");
                        foreach (GClass74 gclass74 in this.gclass22_0.list_1)
                        {
                            for (int index2 = 1; index2 <= gclass74.int_0; ++index2)
                            {
                                if (gclass40_2_2.method_125() >= gclass74.gclass22_0.decimal_14)
                                {
                                    string string_10_2 = gclass74.gclass22_0.method_39();
                                    FCTShipData40 gclass40 = this.gclass21_0.method_304(null, null, null,
                                        gclass74.gclass22_0, gclass40_2_2.gclass85_0, null, gclass194_1, gclass40_2_2,
                                        null, string_10_2, AuroraUtils.int_26, true, true, GEnum20.const_2);
                                    gclass40.SquadronData = gclass70_2;
                                    gclass40.LinkedSquadronID = gclass70_2.SquadronID;
                                    this.gclass21_0.StartBuildPoints -= gclass40.gclass22_0.decimal_4;
                                    if (this.chkIncludeGround.CheckState == CheckState.Checked &&
                                        gclass74.gclass22_0.list_2.Count > 0)
                                        gclass40.method_50();
                                }
                            }
                        }
                    }
                }

                this.txtInstantBuild.Text = AuroraUtils.smethod_38(this.gclass21_0.StartBuildPoints);
                if (!this.gclass0_0.bool_8 && !(this.gclass21_0.StartBuildPoints > 0M))
                    this.cmdInstantBuild.Visible = false;
                else
                    this.cmdInstantBuild.Visible = true;
                this.gclass22_0.bool_3 = true;
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 270);
        }
    }

    private void cmdSelectName_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass22_0 == null)
                return;
            int num = (int)new cmdSelect(this.gclass0_0).ShowDialog();
            if (this.gclass0_0.bool_21 || this.gclass0_0.string_4 == "" || this.gclass0_0.string_4 == null)
                return;
            this.gclass22_0.ClassName = this.gclass0_0.string_4;
            this.tvClassList.SelectedNode.Text = this.gclass22_0.ClassName;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 271);
        }
    }

    private void lstvComponents_SelectedIndexChanged(object sender, EventArgs e)
    {
    }

    private void txtMinSupplies_TextChanged(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass22_0 == null || !(this.txtMinSupplies.Text != ""))
                return;
            this.gclass22_0.int_47 = Convert.ToInt32(this.txtMinSupplies.Text);
            this.method_1();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 272);
        }
    }

    private void txtSupplyPriority_TextChanged(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass22_0 == null || !(this.txtSupplyPriority.Text != ""))
                return;
            this.gclass22_0.int_45 = Convert.ToInt32(this.txtSupplyPriority.Text);
            if (this.gclass22_0.int_45 < 1)
                this.gclass22_0.int_45 = 1;
            this.method_1();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 273);
        }
    }

    private void cboNamingTheme_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass0_0.bool_9 || this.gclass22_0 == null)
                return;
            this.gclass22_0.gclass140_0 = (NamingTheme)this.cboNamingTheme.SelectedValue;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 274);
        }
    }

    private void cmdLock_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass22_0 == null)
                return;
            if (this.gclass22_0.bool_3)
            {
                if (this.gclass0_0.bool_8)
                {
                    this.gclass22_0.bool_3 = false;
                    this.cmdLock.Text = "Lock Class";
                }
                else
                {
                    int num = (int)MessageBox.Show("Classes can only be unlocked in Spacemaster Mode");
                }
            }
            else
            {
                this.gclass22_0.bool_3 = true;
                this.cmdLock.Text = "Unlock Class";
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 275);
        }
    }

    private void method_13(bool bool_3)
    {
        try
        {
            if (bool_3)
            {
                this.tabDesign.Width = 1220;
                this.tvComponents.Width = 308;
                this.tvInClass.Width = 308;
                this.tvInClass.Left = 3;
                this.flpRaceOrClass.Visible = true;
                this.Width = 1440;
                this.tvComponents.Top = 35;
                this.tvInClass.Top = 35;
                this.tvComponents.Height = 766;
                this.tvInClass.Height = 766;
                this.flpRaceOrClass.Left = 6;
                this.flpMultiples.Left = 3;
                this.rdoRace.Checked = true;
                this.flowLayoutPanel1.Left = 316;
                this.txtSummary.Left = 316;
                this.txtComponentDetail.Left = 316;
                this.flowLayoutPanel2.Left = 316;
                this.flowLayoutPanel5.Left = 316;
                this.txtDesignErrors.Left = 847;
                this.flpToggles.Left = 1105;
                this.flpBands.Left = 1105;
                this.flowLayoutPanelMembers.Left = 1105;
            }
            else
            {
                this.Width = 1853;
                this.tabDesign.Width = 1632;
                this.tvComponents.Width = 360;
                this.tvInClass.Width = 360;
                this.tvInClass.Left = 367;
                this.tvComponents.Top = 7;
                this.tvInClass.Top = 7;
                this.tvComponents.Height = 794;
                this.tvInClass.Height = 794;
                this.flpRaceOrClass.Visible = false;
                this.tvComponents.Visible = true;
                this.tvInClass.Visible = true;
                this.flowLayoutPanel1.Left = 731;
                this.txtSummary.Left = 731;
                this.txtComponentDetail.Left = 731;
                this.flowLayoutPanel2.Left = 731;
                this.flowLayoutPanel5.Left = 731;
                this.txtDesignErrors.Left = 1262;
                this.flpToggles.Left = 1520;
                this.flpBands.Left = 1520;
                this.flowLayoutPanelMembers.Left = 1520;
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 276);
        }
    }

    public void method_14()
    {
        try
        {
            if (this.cmdSuperWide.Text == "Normal View")
            {
                this.method_13(true);
                this.cmdSuperWide.Text = "Wide View";
                this.gclass0_0.bool_17 = false;
            }
            else
            {
                this.method_13(false);
                this.cmdSuperWide.Text = "Normal View";
                this.gclass0_0.bool_17 = true;
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3204);
        }
    }

    private void cmdSuperWide_Click(object sender, EventArgs e)
    {
        try
        {
            this.method_14();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 277);
        }
    }

    private void cmdRenameComp_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass230_0 == null)
                return;
            this.gclass0_0.string_3 = "Enter New Component Name";
            this.gclass0_0.string_4 = this.gclass230_0.Name;
            int num = (int)new MessageEntry(this.gclass0_0).ShowDialog();
            if (!(this.gclass0_0.string_4 != this.gclass230_0.Name) || this.gclass0_0.bool_21)
                return;
            this.gclass230_0.Name = this.gclass0_0.string_4;
            this.method_15();
            this.method_16();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 278);
        }
    }

    private void method_15()
    {
        try
        {
            foreach (TreeNode node1 in this.tvComponents.Nodes)
            {
                foreach (TreeNode node2 in node1.Nodes)
                {
                    if (node2.Tag is ShipComponent)
                    {
                        ShipComponent tag = (ShipComponent)node2.Tag;
                        if (tag == this.gclass230_0)
                        {
                            node2.Text = tag.method_0();
                            return;
                        }
                    }
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3246);
        }
    }

    private void method_16()
    {
        try
        {
            foreach (TreeNode node1 in this.tvInClass.Nodes)
            {
                foreach (TreeNode node2 in node1.Nodes)
                {
                    if (node2.Tag is GClass228)
                    {
                        GClass228 tag = (GClass228)node2.Tag;
                        if (tag.gclass230_0 == this.gclass230_0)
                        {
                            tag.Description =
                                $"{Math.Round(tag.decimal_0, 1).ToString()}x {tag.gclass230_0.method_0()}";
                            node2.Text = tag.Description;
                            return;
                        }
                    }
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3246);
        }
    }

    private void cndObsoComp_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass21_0 == null || this.gclass230_0 == null ||
                !this.gclass230_0.gclass164_0.dictionary_0.ContainsKey(this.gclass21_0.RaceID))
                return;
            this.gclass230_0.gclass164_0.dictionary_0[this.gclass21_0.RaceID].bool_0 =
                !this.gclass230_0.gclass164_0.dictionary_0[this.gclass21_0.RaceID].bool_0;
            this.gclass21_0.method_384(this.tvComponents, this.chkShowObsolete.CheckState,
                this.chkUseAlienTech.CheckState, this.chkPrototypes.CheckState);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 279);
        }
    }

    private void cmdRenameMissile_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass129_0 == null)
            {
                int num1 = (int)MessageBox.Show("Please select a missile");
            }
            else
            {
                this.gclass0_0.string_3 = "Enter New Missile Name";
                this.gclass0_0.string_4 = this.gclass129_0.Name;
                int num2 = (int)new MessageEntry(this.gclass0_0).ShowDialog();
                if (!(this.gclass0_0.string_4 != this.gclass129_0.Name) || this.gclass0_0.bool_21)
                    return;
                this.gclass129_0.Name = this.gclass0_0.string_4;
                this.gclass21_0.method_316(this.lstvOrdnance, this.chkObsoleteMissiles.CheckState, false);
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 280);
        }
    }

    private void txtPrefix_TextChanged(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass22_0 == null)
                return;
            if (this.txtPrefix.Text == "None")
                this.gclass22_0.string_3 = "";
            else
                this.gclass22_0.string_3 = this.txtPrefix.Text;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 281);
        }
    }

    private void txtSuffix_TextChanged(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass22_0 == null)
                return;
            if (this.txtSuffix.Text == "None")
                this.gclass22_0.string_4 = "";
            else
                this.gclass22_0.string_4 = this.txtSuffix.Text;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 282);
        }
    }

    private void cmdRenameAll_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass22_0 == null)
                return;
            List<FCTShipData40> list = this.gclass0_0.FCTShipDataDictionary.Values
                .Where<FCTShipData40>(gclass40_0 => gclass40_0.gclass22_0 == this.gclass22_0)
                .OrderBy<FCTShipData40, int>(gclass40_0 => gclass40_0.int_8).ToList<FCTShipData40>();
            foreach (FCTShipData40 gclass40 in list)
                gclass40.ShipName = "";
            foreach (FCTShipData40 gclass40 in list)
                gclass40.ShipName = this.gclass22_0.method_39();
            this.method_1();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 283);
        }
    }

    private void cmdDesignTech_Click(object sender, EventArgs e)
    {
        try
        {
            new CreateProject(this.gclass0_0).Show();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3193);
        }
    }

    private void cmdViewTech_Click(object sender, EventArgs e)
    {
        try
        {
            new TechnologyView(this.gclass0_0).Show();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3194);
        }
    }

    private void tvComponents_AfterCollapse(object sender, TreeViewEventArgs e)
    {
        try
        {
            if (!(e.Node.Tag is ComponentTypeData))
                return;
            ((ComponentTypeData)e.Node.Tag).bool_3 = e.Node.IsExpanded;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 245);
        }
    }

    private void chkNoArmour_CheckedChanged(object sender, EventArgs e)
    {
    }

    private void cboMothershipClass_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            // ISSUE: object of a compiler-generated type is created
            // ISSUE: reference to a compiler-generated method
            this.cboMothership.DataSource = this.gclass0_0.FCTShipDataDictionary.Values.Where<FCTShipData40>(
                    new ClassDesign.Class907()
                    {
                        gclass22_0 = (GClass22)this.cboMothershipClass.SelectedValue
                    }.method_0).Where<FCTShipData40>(gclass40_0 => gclass40_0.method_125() > this.gclass22_0.decimal_14)
                .OrderBy<FCTShipData40, string>(gclass40_0 => gclass40_0.ShipName).ToList<FCTShipData40>();
            this.cboMothership.DisplayMember = "ShipName";
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3365);
        }
    }

    private void cboMothership_SelectedIndexChanged(object sender, EventArgs e)
    {
    }

    private void tvClassList_AfterCollapse(object sender, TreeViewEventArgs e)
    {
        try
        {
            if (!(e.Node.Tag is ShipHull))
                return;
            ((ShipHull)e.Node.Tag).bool_0 = e.Node.IsExpanded;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3427);
        }
    }

    private void cmdRenumberHull_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass22_0 == null)
                return;
            List<FCTShipData40> list = this.gclass0_0.FCTShipDataDictionary.Values
                .Where<FCTShipData40>(gclass40_0 =>
                    gclass40_0.gclass22_0.gclass76_0 == this.gclass22_0.gclass76_0 &&
                    gclass40_0.gclass21_0 == this.gclass21_0 && gclass40_0.gclass187_0 == null)
                .OrderBy<FCTShipData40, int>(gclass40_0 => gclass40_0.int_8).ToList<FCTShipData40>();
            if (list.Count == 0)
                return;
            int num1 = 0;
            foreach (FCTShipData40 gclass40 in list)
            {
                ++num1;
                int num2 = num1;
                gclass40.int_20 = num2;
            }

            if (!this.gclass21_0.ShipHullCountDictionary.ContainsKey(this.gclass22_0.gclass76_0))
                this.gclass21_0.ShipHullCountDictionary.Add(this.gclass22_0.gclass76_0, num1);
            else
                this.gclass21_0.ShipHullCountDictionary[this.gclass22_0.gclass76_0] = num1;
            this.method_1();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3498);
        }
    }

    private void chkHullNumbers_CheckedChanged(object sender, EventArgs e)
    {
    }

    private void tvComponents_KeyDown(object sender, KeyEventArgs e)
    {
        try
        {
            if (e.KeyCode == Keys.Space)
            {
                this.method_4();
            }
            else
            {
                if (e.KeyCode != Keys.Next)
                    return;
                this.tvInClass.Focus();
                if (this.tvInClass.Nodes.Count <= 0)
                    return;
                this.tvInClass.SelectedNode = this.tvInClass.Nodes[0];
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3606);
        }
    }

    private void tvInClass_KeyDown(object sender, KeyEventArgs e)
    {
        try
        {
            if (e.KeyCode == Keys.Space)
            {
                this.method_5();
            }
            else
            {
                if (e.KeyCode != Keys.Next)
                    return;
                this.txtSummary.Focus();
                this.txtSummary.SelectionStart = 0;
                this.txtSummary.SelectionLength = 0;
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3608);
        }
    }

    private void txtSummary_KeyDown(object sender, KeyEventArgs e)
    {
        try
        {
            if (e.KeyCode != Keys.Next)
                return;
            this.txtSummary.Enabled = false;
            this.tvComponents.Focus();
            if (this.tvComponents.Nodes.Count > 0)
                this.tvComponents.SelectedNode = this.tvComponents.Nodes[0];
            this.txtSummary.Enabled = true;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3509);
        }
    }

    private void cboFleets_SelectedIndexChanged(object sender, EventArgs e)
    {
    }

    private void tabPage4_Click(object sender, EventArgs e)
    {
    }

    private void chkAssignSquadron_CheckedChanged(object sender, EventArgs e)
    {
        try
        {
            if (this.chkAssignSquadron.CheckState == CheckState.Checked)
                this.chkMothership.CheckState = CheckState.Unchecked;
            if (this.chkMothership.CheckState != CheckState.Checked)
                return;
            this.chkAssignSquadron.CheckState = CheckState.Unchecked;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3575);
        }
    }

    private void lstvTemplate_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            if (this.lstvTemplate.SelectedItems.Count <= 0)
                return;
            this.gclass102_0 = (GroundUnitFormationTemplateData)this.lstvTemplate.SelectedItems[0].Tag;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3626);
        }
    }

    private void lstvTemplate_DoubleClick(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass102_0 == null || this.gclass22_0 == null)
                return;
            this.gclass22_0.method_57(this.gclass102_0, this.method_8());
            this.method_1();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3627);
        }
    }

    private void lstClassGround_DoubleClick(object sender, EventArgs e)
    {
        try
        {
            if (this.lstClassGround.SelectedItems.Count <= 0 || this.gclass22_0 == null)
                return;
            this.gclass22_0.method_59((GClass75)this.lstClassGround.SelectedItem, this.method_8());
            this.method_1();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3633);
        }
    }

    private void txtPDProtectionPriority_TextChanged(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass22_0 == null || !(this.txtPDProtectionPriority.Text != ""))
                return;
            this.gclass22_0.int_16 = Convert.ToInt32(this.txtPDProtectionPriority.Text);
            if (this.gclass22_0.int_16 < 1)
                this.gclass22_0.int_16 = 1;
            this.method_1();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3653);
        }
    }

    private void cmdExportClass_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass22_0 == null)
                return;
            this.gclass22_0.method_24();
            this.gclass0_0.method_500(this.tvTemplateList);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3714);
        }
    }

    private void tvTemplateList_AfterExpand(object sender, TreeViewEventArgs e)
    {
        try
        {
            if (!(e.Node.Tag is ShipHull))
                return;
            ((ShipHull)e.Node.Tag).bool_1 = e.Node.IsExpanded;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3725);
        }
    }

    private void tvTemplateList_AfterCollapse(object sender, TreeViewEventArgs e)
    {
        try
        {
            if (!(e.Node.Tag is ShipHull))
                return;
            ((ShipHull)e.Node.Tag).bool_1 = e.Node.IsExpanded;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3726);
        }
    }

    private void lstvTemplateComponents_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            // ISSUE: object of a compiler-generated type is created
            // ISSUE: variable of a compiler-generated type
            ClassDesign.Class905 class905 = new ClassDesign.Class905();
            if (this.gclass21_0 == null || this.lstvTemplateComponents.SelectedItems.Count == 0)
                return;
            this.lstvComponentTechRequired.Items.Clear();
            // ISSUE: reference to a compiler-generated field
            class905.gclass186_0 = (ClassComponentTemplate186)this.lstvTemplateComponents.SelectedItems[0].Tag;
            ShipComponent gclass230_0 = new ShipComponent();
            // ISSUE: reference to a compiler-generated field
            if (class905.gclass186_0 != null)
            {
                // ISSUE: reference to a compiler-generated field
                if (class905.gclass186_0.StandardComponentID > 0)
                {
                    // ISSUE: reference to a compiler-generated method
                    gclass230_0 =
                        this.gclass0_0.ComponentDataDictionary.Values.FirstOrDefault<ShipComponent>(class905.method_0);
                    if (gclass230_0 != null)
                        this.gclass21_0.method_74(gclass230_0.gclass164_0.TechSystemID, true, false, gclass230_0);
                }
                else
                {
                    // ISSUE: reference to a compiler-generated method
                    GClass185 gclass185_0 =
                        this.gclass0_0.dictionary_76.Values.FirstOrDefault<GClass185>(class905.method_1);
                    if (gclass185_0 != null)
                        gclass230_0 = this.gclass21_0.method_73(gclass185_0, true, false, false);
                }
            }

            this.gclass0_0.method_601(this.lstvComponentTechRequired, "Component Research Required", "RP", null);
            this.gclass0_0.method_597(this.lstvComponentTechRequired, "", null);
            gclass230_0.list_1 = gclass230_0.list_1
                .OrderBy<TechSystem, string>(gclass164_0 => gclass164_0.gclass163_0.Description)
                .ThenBy<TechSystem, int>(gclass164_0 => gclass164_0.int_4).ToList<TechSystem>();
            foreach (TechSystem gclass164 in gclass230_0.list_1)
                this.gclass0_0.method_601(this.lstvComponentTechRequired, gclass164.Name,
                    AuroraUtils.smethod_37(gclass164.int_4), null);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3734);
        }
    }

    private void cmdCreateClass_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass21_0 == null || this.gclass184_0 == null)
                return;
            this.gclass21_0.method_72(this.gclass184_0, this.rdoResearchRequired.Checked);
            this.method_17();
            Application.OpenForms.OfType<Economics>().FirstOrDefault<Economics>()?.method_22();
            this.gclass21_0.method_378(this.tvClassList, this.chkShowCivilian.CheckState,
                this.chkShowObsoleteClasses.CheckState, this.chkObsoleteComp.CheckState,
                this.chkHullCategory.CheckState);
            this.gclass21_0.method_384(this.tvComponents, this.chkShowObsolete.CheckState,
                this.chkUseAlienTech.CheckState, this.chkPrototypes.CheckState);
            this.lblStartingTechPoints.Text = AuroraUtils.smethod_37(this.gclass21_0.StartTechPoints);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3731);
        }
    }

    public void method_17()
    {
        try
        {
            if (this.gclass21_0.StartTechPoints <= 0 && !this.gclass0_0.bool_8)
            {
                this.lblStartingTechPoints.Visible = false;
            }
            else
            {
                this.lblStartingTechPoints.Text = AuroraUtils.smethod_37(this.gclass21_0.StartTechPoints);
                this.lblStartingTechPoints.Visible = true;
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3733);
        }
    }

    private void cmdInstantComp_Click(object sender, EventArgs e)
    {
        try
        {
            // ISSUE: object of a compiler-generated type is created
            // ISSUE: variable of a compiler-generated type
            ClassDesign.Class906 class906 = new ClassDesign.Class906();
            if (this.gclass21_0 == null || this.lstvTemplateComponents.SelectedItems.Count == 0)
                return;
            // ISSUE: reference to a compiler-generated field
            class906.gclass186_0 = (ClassComponentTemplate186)this.lstvTemplateComponents.SelectedItems[0].Tag;
            ShipComponent gclass230 = new ShipComponent();
            // ISSUE: reference to a compiler-generated field
            if (class906.gclass186_0 != null)
            {
                // ISSUE: reference to a compiler-generated field
                if (class906.gclass186_0.StandardComponentID > 0)
                {
                    // ISSUE: reference to a compiler-generated method
                    ShipComponent gclass230_0 =
                        this.gclass0_0.ComponentDataDictionary.Values.FirstOrDefault<ShipComponent>(class906.method_0);
                    if (gclass230_0 != null)
                        this.gclass21_0.method_74(gclass230_0.gclass164_0.TechSystemID, true, true, gclass230_0);
                }
                else
                {
                    // ISSUE: reference to a compiler-generated method
                    GClass185 gclass185_0 =
                        this.gclass0_0.dictionary_76.Values.FirstOrDefault<GClass185>(class906.method_1);
                    if (gclass185_0 != null)
                        gclass230 = this.gclass21_0.method_73(gclass185_0, true, true, true);
                }
            }

            if (this.gclass184_0 != null)
                this.gclass0_0.method_499(this.gclass21_0, this.txtClassTemplate, this.lstvTemplateComponents,
                    this.lstvTemplateTech, this.gclass184_0);
            this.lblStartingTechPoints.Text = AuroraUtils.smethod_37(this.gclass21_0.StartTechPoints);
            this.gclass21_0.method_384(this.tvComponents, this.chkShowObsolete.CheckState,
                this.chkUseAlienTech.CheckState, this.chkPrototypes.CheckState);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3735);
        }
    }

    private void cmdRenameTemplate_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass21_0 == null || this.gclass184_0 == null)
                return;
            this.gclass0_0.string_3 = "Enter New Template Name";
            this.gclass0_0.string_4 = this.gclass184_0.ShipClassTemplateName;
            int num = (int)new MessageEntry(this.gclass0_0).ShowDialog();
            if (!(this.gclass0_0.string_4 != this.gclass184_0.ShipClassTemplateName) || this.gclass0_0.bool_21)
                return;
            this.gclass184_0.ShipClassTemplateName = this.gclass0_0.string_4;
            this.tvTemplateList.SelectedNode.Text = this.gclass184_0.ShipClassTemplateName;
            this.gclass0_0.method_499(this.gclass21_0, this.txtClassTemplate, this.lstvTemplateComponents,
                this.lstvTemplateTech, this.gclass184_0);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3737);
        }
    }

    private void cmdDeleteTemplate_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass21_0 == null || this.gclass184_0 == null ||
                MessageBox.Show($" Are you sure you want to delete {this.gclass184_0.ShipClassTemplateName}?",
                    "Confirmation Required", MessageBoxButtons.YesNo) != DialogResult.Yes)
                return;
            this.lstvTemplateComponents.Items.Clear();
            this.lstvTemplateTech.Items.Clear();
            this.lstvComponentTechRequired.Items.Clear();
            this.gclass0_0.ShipClassTemplateDictionary.Remove(this.gclass184_0.ShipClassTemplateID);
            this.gclass0_0.method_500(this.tvTemplateList);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3738);
        }
    }

    private void lstvTemplateTech_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass21_0 == null || this.lstvTemplateTech.SelectedItems.Count == 0)
                return;
            this.lstvComponentTechRequired.Items.Clear();
            TechSystem tag = (TechSystem)this.lstvTemplateTech.SelectedItems[0].Tag;
            if (tag == null)
                return;
            this.gclass0_0.method_601(this.lstvComponentTechRequired, "Component Research Required", "RP", null);
            this.gclass0_0.method_597(this.lstvComponentTechRequired, "", null);
            if (tag.dictionary_0.ContainsKey(this.gclass21_0.RaceID))
                return;
            List<TechSystem> source = this.gclass21_0.method_75(tag);
            if (source.Count <= 0)
                return;
            foreach (TechSystem gclass164 in source
                         .OrderBy<TechSystem, string>(gclass164_0 => gclass164_0.gclass163_0.Description)
                         .ThenBy<TechSystem, int>(gclass164_0 => gclass164_0.int_4).ToList<TechSystem>())
                this.gclass0_0.method_601(this.lstvComponentTechRequired, gclass164.Name,
                    AuroraUtils.smethod_37(gclass164.int_4), null);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3739);
        }
    }

    private void cmdInstantTech_Click(object sender, EventArgs e)
    {
    }

    private void rdoFleetIB_CheckedChanged(object sender, EventArgs e)
    {
        try
        {
            if (this.rdoFleetIB.Checked)
            {
                this.cboFleets.Visible = true;
                this.cboAdminCommands.Visible = false;
            }
            else
            {
                this.cboFleets.Visible = false;
                this.cboAdminCommands.Visible = true;
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3793);
        }
    }

    private void lstvShips_DoubleClick(object sender, EventArgs e)
    {
        try
        {
            if (this.lstvShips.SelectedItems.Count == 0)
                return;
            FCTShipData40 tag = (FCTShipData40)this.lstvShips.SelectedItems[0].Tag;
            if (tag == null)
                return;
            if (this.rdoShip.Checked)
            {
                this.gclass21_0.genum42_0 = GEnum42.const_4;
                this.gclass21_0.int_43 = tag.int_8;
            }
            else
            {
                this.gclass21_0.genum42_0 = GEnum42.const_2;
                this.gclass21_0.int_43 = tag.gclass85_0.FleetID;
            }

            new FleetWindow(this.gclass0_0).Show();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3804);
        }
    }

    private void lstvShips_SelectedIndexChanged(object sender, EventArgs e)
    {
    }

    private void chkLargerParasites_CheckedChanged(object sender, EventArgs e)
    {
        try
        {
            this.gclass21_0.method_315(this.lstvFighters, this.gclass22_0, this.chkObsoleteMissiles.CheckState,
                this.chkLargerParasites.CheckState);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3868);
        }
    }

    private void chkComponentSummary_CheckedChanged(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass22_0 == null)
                return;
            this.gclass22_0.method_64(this.lstvComponents, this.genum18_0, this.chkComponentSummary.CheckState);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3894);
        }
    }

    private void cmdCrewDesign_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass22_0 == null)
                return;
            if (this.gclass22_0.bool_3)
            {
                int num = (int)MessageBox.Show("Class cannot be modified while locked");
            }
            else
            {
                this.gclass22_0.decimal_21 = this.gclass21_0.CrewDesignEfficiency;
                this.method_1();
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3192);
        }
    }

    private void tvInClass_AfterExpand(object sender, TreeViewEventArgs e)
    {
        try
        {
            if (!(e.Node.Tag is ClassSummaryType))
                return;
            ((ClassSummaryType)e.Node.Tag).bool_1 = e.Node.IsExpanded;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3897);
        }
    }

    private void chkHullCategory_Click(object sender, EventArgs e)
    {
        try
        {
            this.gclass21_0.method_378(this.tvClassList, this.chkShowCivilian.CheckState,
                this.chkShowObsoleteClasses.CheckState, this.chkObsoleteComp.CheckState,
                this.chkHullCategory.CheckState);
            this.gclass21_0.chkHullCategory = this.chkHullCategory.CheckState;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3932);
        }
    }

    private void button1_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass21_0 == null)
            {
                int num1 = (int)MessageBox.Show("Please select a race");
            }
            else if (this.gclass22_0 == null)
            {
                int num2 = (int)MessageBox.Show("Please select a class");
            }
            else
            {
                int num3 = (int)new PopulationText(this.gclass22_0, this.gclass0_0).ShowDialog();
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3957);
        }
    }

    private void tvTemplateList_AfterSelect(object sender, TreeViewEventArgs e)
    {
        try
        {
            if (this.bool_2)
                return;
            this.lstvComponentTechRequired.Items.Clear();
            if (e.Node.Tag is ShipClassTemplate184)
            {
                this.treeNode_2 = e.Node;
                this.gclass184_0 = (ShipClassTemplate184)e.Node.Tag;
                if (this.gclass184_0 == null)
                    return;
                this.gclass0_0.method_499(this.gclass21_0, this.txtClassTemplate, this.lstvTemplateComponents,
                    this.lstvTemplateTech, this.gclass184_0);
            }

            this.lblStartingTechPoints.Text = AuroraUtils.smethod_37(this.gclass21_0.StartTechPoints);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3727);
        }
    }

    private void ClassDesign_KeyDown(object sender, KeyEventArgs e)
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
            AuroraUtils.ShowExceptionPopup(ex, 3270);
        }
    }

    private void cmdRenumberAll_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass22_0 == null)
                return;
            List<FCTShipData40> list = this.gclass0_0.FCTShipDataDictionary.Values
                .Where<FCTShipData40>(gclass40_0 => gclass40_0.gclass22_0 == this.gclass22_0)
                .OrderBy<FCTShipData40, int>(gclass40_0 => gclass40_0.int_8).ToList<FCTShipData40>();
            int int_72 = 1;
            foreach (FCTShipData40 gclass40 in list)
            {
                gclass40.ShipName = $"{this.gclass22_0.ClassName} {AuroraUtils.smethod_33(int_72)}";
                ++int_72;
            }

            this.method_1();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 284);
        }
    }

    private void cmdResearch_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass230_0 == null || this.gclass230_0.genum86_0 != GEnum86.const_1)
                return;
            if (this.gclass230_0.int_14 > 0 &&
                this.gclass0_0.ComponentDataDictionary.ContainsKey(this.gclass230_0.int_14) &&
                this.gclass0_0.ComponentDataDictionary[this.gclass230_0.int_14].genum86_0 != GEnum86.const_0)
            {
                int num = (int)MessageBox.Show(
                    "You cannot create a research project for a turret that includes a prototype weapon");
            }
            else
            {
                this.gclass230_0.genum86_0 = GEnum86.const_3;
                if (this.bool_1)
                    this.treeNode_1.Text = this.gclass230_0.method_0();
                else
                    this.gclass22_0.method_71(this.tvInClass);
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 285);
        }
    }

    private void cndSortFuel_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass22_0 == null)
                return;
            string name = ((Control)sender).Name;
            if (name != null)
            {
                switch (name.Length)
                {
                    case 11:
                        if (name == "cmdSortFuel")
                        {
                            this.genum18_1 = GEnum18.const_11;
                            break;
                        }

                        break;
                    case 13:
                        if (name == "cmdSortLaunch")
                        {
                            this.genum18_1 = GEnum18.const_8;
                            break;
                        }

                        break;
                    case 15:
                        if (name == "cmdSortShipName")
                        {
                            this.genum18_1 = GEnum18.const_5;
                            break;
                        }

                        break;
                    case 16 /*0x10*/:
                        switch (name[7])
                        {
                            case 'F':
                                if (name == "cmdSortFleetName")
                                {
                                    this.genum18_1 = GEnum18.const_6;
                                    break;
                                }

                                break;
                            case 'M':
                                if (name == "cmdSortMainClock")
                                {
                                    this.genum18_1 = GEnum18.const_9;
                                    break;
                                }

                                break;
                        }

                        break;
                    case 17:
                        switch (name[8])
                        {
                            case 'h':
                                if (name == "cmdSortShoreLeave")
                                {
                                    this.genum18_1 = GEnum18.const_10;
                                    break;
                                }

                                break;
                            case 'y':
                                if (name == "cmdSortSystemName")
                                {
                                    this.genum18_1 = GEnum18.const_7;
                                    break;
                                }

                                break;
                        }

                        break;
                }
            }

            if (this.gclass22_0 == null)
                return;
            this.gclass22_0.method_69(this.lstvShips, this.genum18_1);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 286);
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
        ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(ClassDesign));
        this.tabDesign = new TabControl();
        this.ClassDesignTab = new TabPage();
        this.txtSummary = new TextBox();
        this.flpRaceOrClass = new FlowLayoutPanel();
        this.rdoRace = new RadioButton();
        this.rdoClass = new RadioButton();
        this.flpToggles = new FlowLayoutPanel();
        this.chkCollier = new CheckBox();
        this.chkSupplyShip = new CheckBox();
        this.chkTanker = new CheckBox();
        this.label9 = new Label();
        this.chkSeniorCO = new CheckBox();
        this.chkConscript = new CheckBox();
        this.chkNoArmour = new CheckBox();
        this.chkHullNumbers = new CheckBox();
        this.label10 = new Label();
        this.chkObsolete = new CheckBox();
        this.chkNoOfficers = new CheckBox();
        this.flpBands = new FlowLayoutPanel();
        this.label27 = new Label();
        this.txtRangeBand = new TextBox();
        this.label28 = new Label();
        this.txtTargetSpeed = new TextBox();
        this.chkShowBands = new CheckBox();
        this.flowLayoutPanelMembers = new FlowLayoutPanel();
        this.lstMembers = new ListBox();
        this.flowLayoutPanel5 = new FlowLayoutPanel();
        this.cmdRenameComp = new Button();
        this.cndObsoComp = new Button();
        this.cmdDesignTech = new Button();
        this.cmdViewTech = new Button();
        this.cmdRefreshTech = new Button();
        this.cmdArmour = new Button();
        this.cmdCrewDesign = new Button();
        this.cmdSuperWide = new Button();
        this.cmdDelete = new Button();
        this.txtDesignErrors = new TextBox();
        this.flpMultiples = new FlowLayoutPanel();
        this.chkShowObsolete = new CheckBox();
        this.chkPrototypes = new CheckBox();
        this.rdo1 = new RadioButton();
        this.rdo5 = new RadioButton();
        this.rdo20 = new RadioButton();
        this.rdo100 = new RadioButton();
        this.txtComponentDetail = new TextBox();
        this.tvComponents = new TreeView();
        this.tvInClass = new TreeView();
        this.flowLayoutPanel1 = new FlowLayoutPanel();
        this.cboHullDescription = new ComboBox();
        this.label4 = new Label();
        this.txtArmourRequired = new TextBox();
        this.label6 = new Label();
        this.txtMonths = new TextBox();
        this.label25 = new Label();
        this.txtBuildTime = new Label();
        this.label26 = new Label();
        this.txtLoadTime = new Label();
        this.label5 = new Label();
        this.txtSize = new Label();
        this.flowLayoutPanel2 = new FlowLayoutPanel();
        this.cmdNew = new Button();
        this.cmdRename = new Button();
        this.cmdSelectName = new Button();
        this.cmdLock = new Button();
        this.cmdCopy = new Button();
        this.cmdResearch = new Button();
        this.cmdExportClass = new Button();
        this.cmdNewHull = new Button();
        this.ShipsInClass = new TabPage();
        this.flowLayoutPanel16 = new FlowLayoutPanel();
        this.label18 = new Label();
        this.rdoShip = new RadioButton();
        this.rdoFleet = new RadioButton();
        this.flowLayoutPanel12 = new FlowLayoutPanel();
        this.cmdRenameAll = new Button();
        this.cmdRenumberAll = new Button();
        this.cmdRenumberHull = new Button();
        this.flowLayoutPanel8 = new FlowLayoutPanel();
        this.cmdSortLaunch = new Button();
        this.cmdSortShipName = new Button();
        this.cmdSortSystemName = new Button();
        this.cmdSortFleetName = new Button();
        this.cmdSortMainClock = new Button();
        this.cmdSortShoreLeave = new Button();
        this.cndSortFuel = new Button();
        this.lstvShips = new ListView();
        this.columnHeader_17 = new ColumnHeader();
        this.columnHeader_18 = new ColumnHeader();
        this.columnHeader_19 = new ColumnHeader();
        this.columnHeader_20 = new ColumnHeader();
        this.columnHeader_21 = new ColumnHeader();
        this.columnHeader_22 = new ColumnHeader();
        this.columnHeader_23 = new ColumnHeader();
        this.columnHeader_24 = new ColumnHeader();
        this.columnHeader_25 = new ColumnHeader();
        this.ComponentsTab = new TabPage();
        this.flowLayoutPanel6 = new FlowLayoutPanel();
        this.cmdSortAmount = new Button();
        this.cmdSortSize = new Button();
        this.cmdSortCost = new Button();
        this.cmdSortCrew = new Button();
        this.cmdSortHTK = new Button();
        this.cmdDAC = new Button();
        this.cmdEDAC = new Button();
        this.chkComponentSummary = new CheckBox();
        this.lstvComponents = new ListView();
        this.columnHeader_28 = new ColumnHeader();
        this.columnHeader_29 = new ColumnHeader();
        this.columnHeader_30 = new ColumnHeader();
        this.columnHeader_32 = new ColumnHeader();
        this.columnHeader_34 = new ColumnHeader();
        this.columnHeader_36 = new ColumnHeader();
        this.columnHeader_31 = new ColumnHeader();
        this.columnHeader_33 = new ColumnHeader();
        this.columnHeader_35 = new ColumnHeader();
        this.columnHeader_37 = new ColumnHeader();
        this.columnHeader_38 = new ColumnHeader();
        this.columnHeader_39 = new ColumnHeader();
        this.OrdnanceFightres = new TabPage();
        this.flowLayoutPanel14 = new FlowLayoutPanel();
        this.lstClassGround = new ListBox();
        this.lblTroopCapacity = new Label();
        this.flowLayoutPanel13 = new FlowLayoutPanel();
        this.lstClassOrdnance = new ListBox();
        this.lblOrdnanceCapacity = new Label();
        this.flowLayoutPanel4 = new FlowLayoutPanel();
        this.lstClassFighters = new ListBox();
        this.lblHangarCapacity = new Label();
        this.lstvTemplate = new ListView();
        this.columnHeader_41 = new ColumnHeader();
        this.columnHeader_42 = new ColumnHeader();
        this.columnHeader_43 = new ColumnHeader();
        this.columnHeader_44 = new ColumnHeader();
        this.columnHeader_45 = new ColumnHeader();
        this.columnHeader_46 = new ColumnHeader();
        this.columnHeader_47 = new ColumnHeader();
        this.columnHeader_48 = new ColumnHeader();
        this.columnHeader_49 = new ColumnHeader();
        this.panel4 = new Panel();
        this.flowLayoutPanel17 = new FlowLayoutPanel();
        this.chkObsoleteMissiles = new CheckBox();
        this.chkObsoleteFighters = new CheckBox();
        this.checkBox1 = new CheckBox();
        this.chkLargerParasites = new CheckBox();
        this.cmdRenameMissile = new Button();
        this.cmdObsoleteFighter = new Button();
        this.cmdObsoleteMissile = new Button();
        this.flowLayoutPanel7 = new FlowLayoutPanel();
        this.rdoLoadout1 = new RadioButton();
        this.rdoLoadout10 = new RadioButton();
        this.rdoLoadout100 = new RadioButton();
        this.rdoLoadout1000 = new RadioButton();
        this.lstvOrdnance = new ListView();
        this.columnHeader_0 = new ColumnHeader();
        this.columnHeader_1 = new ColumnHeader();
        this.columnHeader_2 = new ColumnHeader();
        this.columnHeader_3 = new ColumnHeader();
        this.columnHeader_40 = new ColumnHeader();
        this.columnHeader_4 = new ColumnHeader();
        this.columnHeader_53 = new ColumnHeader();
        this.columnHeader_5 = new ColumnHeader();
        this.columnHeader_6 = new ColumnHeader();
        this.columnHeader_7 = new ColumnHeader();
        this.columnHeader_8 = new ColumnHeader();
        this.columnHeader_9 = new ColumnHeader();
        this.columnHeader_10 = new ColumnHeader();
        this.lstvFighters = new ListView();
        this.columnHeader_11 = new ColumnHeader();
        this.columnHeader_12 = new ColumnHeader();
        this.columnHeader_13 = new ColumnHeader();
        this.columnHeader_14 = new ColumnHeader();
        this.columnHeader_15 = new ColumnHeader();
        this.columnHeader_16 = new ColumnHeader();
        this.tabPage4 = new TabPage();
        this.cmdAutoDesign = new Button();
        this.cmdDesignPhilosopy = new Button();
        this.label19 = new Label();
        this.lstvRefit = new ListView();
        this.columnHeader_50 = new ColumnHeader();
        this.columnHeader_51 = new ColumnHeader();
        this.columnHeader_52 = new ColumnHeader();
        this.columnHeader_62 = new ColumnHeader();
        this.columnHeader_63 = new ColumnHeader();
        this.flowLayoutPanel10 = new FlowLayoutPanel();
        this.panel1 = new Panel();
        this.label11 = new Label();
        this.cboNamingTheme = new ComboBox();
        this.flowLayoutPanel11 = new FlowLayoutPanel();
        this.lblPrefix = new Label();
        this.txtPrefix = new TextBox();
        this.label12 = new Label();
        this.txtSuffix = new TextBox();
        this.chkRandomName = new CheckBox();
        this.pnlInstantBuild = new FlowLayoutPanel();
        this.panel7 = new Panel();
        this.txtInstantBuild = new TextBox();
        this.label2 = new Label();
        this.panel5 = new Panel();
        this.txtNumInstantBuild = new TextBox();
        this.label3 = new Label();
        this.chkIncludeParasites = new CheckBox();
        this.chkIncludeGround = new CheckBox();
        this.chkEnterNames = new CheckBox();
        this.rdoFleetIB = new RadioButton();
        this.rdoIBAdmin = new RadioButton();
        this.cboAdminCommands = new ComboBox();
        this.cboFleets = new ComboBox();
        this.chkMothership = new CheckBox();
        this.cboMothershipClass = new ComboBox();
        this.cboMothership = new ComboBox();
        this.chkAssignSquadron = new CheckBox();
        this.cboSquadron = new ComboBox();
        this.cmdInstantBuild = new Button();
        this.lstvCrew = new ListView();
        this.columnHeader_26 = new ColumnHeader();
        this.columnHeader_27 = new ColumnHeader();
        this.chkUseAlienTech = new CheckBox();
        this.flowLayoutPanel9 = new FlowLayoutPanel();
        this.panel12 = new Panel();
        this.txtPriority = new TextBox();
        this.label16 = new Label();
        this.panel2 = new Panel();
        this.txtPDProtectionPriority = new TextBox();
        this.label13 = new Label();
        this.panel3 = new Panel();
        this.txtMaintPriority = new TextBox();
        this.label1 = new Label();
        this.panel11 = new Panel();
        this.txtFuelPriority = new TextBox();
        this.label15 = new Label();
        this.panel8 = new Panel();
        this.txtSupplyPriority = new TextBox();
        this.label8 = new Label();
        this.panel13 = new Panel();
        this.txtMinFuel = new TextBox();
        this.label17 = new Label();
        this.panel6 = new Panel();
        this.txtMinSupplies = new TextBox();
        this.label7 = new Label();
        this.label14 = new Label();
        this.txtDetails = new TextBox();
        this.tabPage1 = new TabPage();
        this.lstvComponentTechRequired = new ListView();
        this.columnHeader_60 = new ColumnHeader();
        this.columnHeader_61 = new ColumnHeader();
        this.flowLayoutPanel15 = new FlowLayoutPanel();
        this.cmdCreateClass = new Button();
        this.rdoAvailableTech = new RadioButton();
        this.rdoResearchRequired = new RadioButton();
        this.cmdInstantComp = new Button();
        this.cmdInstantTech = new Button();
        this.lblInstant = new Label();
        this.lblStartingTechPoints = new Label();
        this.cmdRenameTemplate = new Button();
        this.cmdDeleteTemplate = new Button();
        this.txtClassTemplate = new TextBox();
        this.lstvTemplateTech = new ListView();
        this.columnHeader_57 = new ColumnHeader();
        this.columnHeader_58 = new ColumnHeader();
        this.lstvTemplateComponents = new ListView();
        this.columnHeader_59 = new ColumnHeader();
        this.columnHeader_54 = new ColumnHeader();
        this.columnHeader_55 = new ColumnHeader();
        this.columnHeader_56 = new ColumnHeader();
        this.tvTemplateList = new TreeView();
        this.tabPage2 = new TabPage();
        this.textBox1 = new TextBox();
        this.chkShowCivilian = new CheckBox();
        this.tvClassList = new TreeView();
        this.cboRaces = new ComboBox();
        this.chkShowObsoleteClasses = new CheckBox();
        this.chkObsoleteComp = new CheckBox();
        this.flowLayoutPanel3 = new FlowLayoutPanel();
        this.chkHullCategory = new CheckBox();
        this.button1 = new Button();
        this.tabDesign.SuspendLayout();
        this.ClassDesignTab.SuspendLayout();
        this.flpRaceOrClass.SuspendLayout();
        this.flpToggles.SuspendLayout();
        this.flpBands.SuspendLayout();
        this.flowLayoutPanelMembers.SuspendLayout();
        this.flowLayoutPanel5.SuspendLayout();
        this.flpMultiples.SuspendLayout();
        this.flowLayoutPanel1.SuspendLayout();
        this.flowLayoutPanel2.SuspendLayout();
        this.ShipsInClass.SuspendLayout();
        this.flowLayoutPanel16.SuspendLayout();
        this.flowLayoutPanel12.SuspendLayout();
        this.flowLayoutPanel8.SuspendLayout();
        this.ComponentsTab.SuspendLayout();
        this.flowLayoutPanel6.SuspendLayout();
        this.OrdnanceFightres.SuspendLayout();
        this.flowLayoutPanel14.SuspendLayout();
        this.flowLayoutPanel13.SuspendLayout();
        this.flowLayoutPanel4.SuspendLayout();
        this.panel4.SuspendLayout();
        this.flowLayoutPanel17.SuspendLayout();
        this.flowLayoutPanel7.SuspendLayout();
        this.tabPage4.SuspendLayout();
        this.flowLayoutPanel10.SuspendLayout();
        this.panel1.SuspendLayout();
        this.flowLayoutPanel11.SuspendLayout();
        this.pnlInstantBuild.SuspendLayout();
        this.panel7.SuspendLayout();
        this.panel5.SuspendLayout();
        this.flowLayoutPanel9.SuspendLayout();
        this.panel12.SuspendLayout();
        this.panel2.SuspendLayout();
        this.panel3.SuspendLayout();
        this.panel11.SuspendLayout();
        this.panel8.SuspendLayout();
        this.panel13.SuspendLayout();
        this.panel6.SuspendLayout();
        this.tabPage1.SuspendLayout();
        this.flowLayoutPanel15.SuspendLayout();
        this.tabPage2.SuspendLayout();
        this.flowLayoutPanel3.SuspendLayout();
        this.SuspendLayout();
        this.tabDesign.Controls.Add(this.ClassDesignTab);
        this.tabDesign.Controls.Add(this.ShipsInClass);
        this.tabDesign.Controls.Add(this.ComponentsTab);
        this.tabDesign.Controls.Add(this.OrdnanceFightres);
        this.tabDesign.Controls.Add(this.tabPage4);
        this.tabDesign.Controls.Add(this.tabPage1);
        this.tabDesign.Controls.Add(this.tabPage2);
        this.tabDesign.Location = new Point(204, 0);
        this.tabDesign.Margin = new Padding(0);
        this.tabDesign.Name = "tabDesign";
        this.tabDesign.SelectedIndex = 0;
        this.tabDesign.Size = new Size(1632, 862);
        this.tabDesign.TabIndex = 4;
        this.ClassDesignTab.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.ClassDesignTab.BorderStyle = BorderStyle.FixedSingle;
        this.ClassDesignTab.Controls.Add(this.txtSummary);
        this.ClassDesignTab.Controls.Add(this.flpRaceOrClass);
        this.ClassDesignTab.Controls.Add(this.flpToggles);
        this.ClassDesignTab.Controls.Add(this.flpBands);
        this.ClassDesignTab.Controls.Add(this.flowLayoutPanelMembers);
        this.ClassDesignTab.Controls.Add(this.flowLayoutPanel5);
        this.ClassDesignTab.Controls.Add(this.txtDesignErrors);
        this.ClassDesignTab.Controls.Add(this.flpMultiples);
        this.ClassDesignTab.Controls.Add(this.txtComponentDetail);
        this.ClassDesignTab.Controls.Add(this.tvComponents);
        this.ClassDesignTab.Controls.Add(this.tvInClass);
        this.ClassDesignTab.Controls.Add(this.flowLayoutPanel1);
        this.ClassDesignTab.Controls.Add(this.flowLayoutPanel2);
        this.ClassDesignTab.Location = new Point(4, 22);
        this.ClassDesignTab.Name = "ClassDesignTab";
        this.ClassDesignTab.Padding = new Padding(3);
        this.ClassDesignTab.Size = new Size(1624, 836);
        this.ClassDesignTab.TabIndex = 1;
        this.ClassDesignTab.Text = "Class Design";
        this.txtSummary.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtSummary.BorderStyle = BorderStyle.FixedSingle;
        this.txtSummary.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
        this.txtSummary.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.txtSummary.Location = new Point(731, 35);
        this.txtSummary.Multiline = true;
        this.txtSummary.Name = "txtSummary";
        this.txtSummary.Size = new Size(785, 602);
        this.txtSummary.TabIndex = 9;
        this.txtSummary.KeyDown += this.txtSummary_KeyDown;
        this.flpRaceOrClass.Anchor = AnchorStyles.None;
        this.flpRaceOrClass.AutoSize = true;
        this.flpRaceOrClass.Controls.Add(this.rdoRace);
        this.flpRaceOrClass.Controls.Add(this.rdoClass);
        this.flpRaceOrClass.Location = new Point(-19, 7);
        this.flpRaceOrClass.Name = "flpRaceOrClass";
        this.flpRaceOrClass.Size = new Size(237, 23);
        this.flpRaceOrClass.TabIndex = 63 /*0x3F*/;
        this.rdoRace.AutoSize = true;
        this.rdoRace.Checked = true;
        this.rdoRace.Location = new Point(3, 3);
        this.rdoRace.Name = "rdoRace";
        this.rdoRace.Size = new Size(113, 17);
        this.rdoRace.TabIndex = 5;
        this.rdoRace.TabStop = true;
        this.rdoRace.Text = "Race Components";
        this.rdoRace.UseVisualStyleBackColor = true;
        this.rdoRace.CheckedChanged += this.rdoClass_CheckedChanged;
        this.rdoClass.AutoSize = true;
        this.rdoClass.Location = new Point(122, 3);
        this.rdoClass.Name = "rdoClass";
        this.rdoClass.Size = new Size(112 /*0x70*/, 17);
        this.rdoClass.TabIndex = 6;
        this.rdoClass.Text = "Class Components";
        this.rdoClass.UseVisualStyleBackColor = true;
        this.rdoClass.CheckedChanged += this.rdoClass_CheckedChanged;
        this.flpToggles.BorderStyle = BorderStyle.FixedSingle;
        this.flpToggles.Controls.Add(this.chkCollier);
        this.flpToggles.Controls.Add(this.chkSupplyShip);
        this.flpToggles.Controls.Add(this.chkTanker);
        this.flpToggles.Controls.Add(this.label9);
        this.flpToggles.Controls.Add(this.chkSeniorCO);
        this.flpToggles.Controls.Add(this.chkConscript);
        this.flpToggles.Controls.Add(this.chkNoArmour);
        this.flpToggles.Controls.Add(this.chkHullNumbers);
        this.flpToggles.Controls.Add(this.label10);
        this.flpToggles.Controls.Add(this.chkObsolete);
        this.flpToggles.Controls.Add(this.chkNoOfficers);
        this.flpToggles.FlowDirection = FlowDirection.TopDown;
        this.flpToggles.Location = new Point(1520, 35);
        this.flpToggles.Name = "flpToggles";
        this.flpToggles.Size = new Size(100, 242);
        this.flpToggles.TabIndex = 22;
        this.chkCollier.AutoSize = true;
        this.chkCollier.Location = new Point(3, 6);
        this.chkCollier.Margin = new Padding(3, 6, 3, 3);
        this.chkCollier.Name = "chkCollier";
        this.chkCollier.Padding = new Padding(5, 0, 0, 0);
        this.chkCollier.Size = new Size(59, 17);
        this.chkCollier.TabIndex = 22;
        this.chkCollier.Text = "Collier";
        this.chkCollier.TextAlign = ContentAlignment.MiddleRight;
        this.chkCollier.UseVisualStyleBackColor = true;
        this.chkCollier.Click += this.chkRandomName_Click;
        this.chkSupplyShip.AutoSize = true;
        this.chkSupplyShip.Location = new Point(3, 29);
        this.chkSupplyShip.Name = "chkSupplyShip";
        this.chkSupplyShip.Padding = new Padding(5, 0, 0, 0);
        this.chkSupplyShip.Size = new Size(87, 17);
        this.chkSupplyShip.TabIndex = 23;
        this.chkSupplyShip.Text = "Supply Ship";
        this.chkSupplyShip.TextAlign = ContentAlignment.MiddleRight;
        this.chkSupplyShip.UseVisualStyleBackColor = true;
        this.chkSupplyShip.Click += this.chkRandomName_Click;
        this.chkTanker.AutoSize = true;
        this.chkTanker.Location = new Point(3, 52);
        this.chkTanker.Name = "chkTanker";
        this.chkTanker.Padding = new Padding(5, 0, 0, 0);
        this.chkTanker.Size = new Size(65, 17);
        this.chkTanker.TabIndex = 24;
        this.chkTanker.Text = "Tanker";
        this.chkTanker.TextAlign = ContentAlignment.MiddleRight;
        this.chkTanker.UseVisualStyleBackColor = true;
        this.chkTanker.Click += this.chkRandomName_Click;
        this.label9.AutoSize = true;
        this.label9.Location = new Point(3, 72);
        this.label9.Name = "label9";
        this.label9.Size = new Size(0, 13);
        this.label9.TabIndex = 64 /*0x40*/;
        this.chkSeniorCO.AutoSize = true;
        this.chkSeniorCO.Location = new Point(3, 88);
        this.chkSeniorCO.Name = "chkSeniorCO";
        this.chkSeniorCO.Padding = new Padding(5, 0, 0, 0);
        this.chkSeniorCO.Size = new Size(85, 17);
        this.chkSeniorCO.TabIndex = 25;
        this.chkSeniorCO.Text = "Senior C.O.";
        this.chkSeniorCO.TextAlign = ContentAlignment.MiddleRight;
        this.chkSeniorCO.UseVisualStyleBackColor = true;
        this.chkSeniorCO.Click += this.chkRandomName_Click;
        this.chkConscript.AutoSize = true;
        this.chkConscript.Location = new Point(3, 111);
        this.chkConscript.Name = "chkConscript";
        this.chkConscript.Padding = new Padding(5, 0, 0, 0);
        this.chkConscript.Size = new Size(75, 17);
        this.chkConscript.TabIndex = 26;
        this.chkConscript.Text = "Conscript";
        this.chkConscript.TextAlign = ContentAlignment.MiddleRight;
        this.chkConscript.UseVisualStyleBackColor = true;
        this.chkConscript.Click += this.chkRandomName_Click;
        this.chkNoArmour.AutoSize = true;
        this.chkNoArmour.Location = new Point(3, 134);
        this.chkNoArmour.Name = "chkNoArmour";
        this.chkNoArmour.Padding = new Padding(5, 0, 0, 0);
        this.chkNoArmour.Size = new Size(81, 17);
        this.chkNoArmour.TabIndex = 27;
        this.chkNoArmour.Text = "No Armour";
        this.chkNoArmour.TextAlign = ContentAlignment.MiddleRight;
        this.chkNoArmour.UseVisualStyleBackColor = true;
        this.chkNoArmour.CheckedChanged += this.chkNoArmour_CheckedChanged;
        this.chkNoArmour.Click += this.chkRandomName_Click;
        this.chkHullNumbers.AutoSize = true;
        this.chkHullNumbers.Location = new Point(3, 157);
        this.chkHullNumbers.Name = "chkHullNumbers";
        this.chkHullNumbers.Padding = new Padding(5, 0, 0, 0);
        this.chkHullNumbers.Size = new Size(94, 17);
        this.chkHullNumbers.TabIndex = 28;
        this.chkHullNumbers.Text = "Hull Numbers";
        this.chkHullNumbers.TextAlign = ContentAlignment.MiddleRight;
        this.chkHullNumbers.UseVisualStyleBackColor = true;
        this.chkHullNumbers.CheckedChanged += this.chkHullNumbers_CheckedChanged;
        this.chkHullNumbers.Click += this.chkRandomName_Click;
        this.label10.AutoSize = true;
        this.label10.Location = new Point(3, 177);
        this.label10.Name = "label10";
        this.label10.Size = new Size(0, 13);
        this.label10.TabIndex = 65;
        this.chkObsolete.AutoSize = true;
        this.chkObsolete.Location = new Point(3, 193);
        this.chkObsolete.Name = "chkObsolete";
        this.chkObsolete.Padding = new Padding(5, 0, 0, 0);
        this.chkObsolete.Size = new Size(73, 17);
        this.chkObsolete.TabIndex = 29;
        this.chkObsolete.Text = "Obsolete";
        this.chkObsolete.TextAlign = ContentAlignment.MiddleRight;
        this.chkObsolete.UseVisualStyleBackColor = true;
        this.chkObsolete.Click += this.chkRandomName_Click;
        this.chkNoOfficers.AutoSize = true;
        this.chkNoOfficers.Location = new Point(3, 216);
        this.chkNoOfficers.Name = "chkNoOfficers";
        this.chkNoOfficers.Padding = new Padding(5, 0, 0, 0);
        this.chkNoOfficers.Size = new Size(84, 17);
        this.chkNoOfficers.TabIndex = 30;
        this.chkNoOfficers.Text = "No Officers";
        this.chkNoOfficers.TextAlign = ContentAlignment.MiddleRight;
        this.chkNoOfficers.UseVisualStyleBackColor = true;
        this.chkNoOfficers.Click += this.chkRandomName_Click;
        this.flpBands.BorderStyle = BorderStyle.FixedSingle;
        this.flpBands.Controls.Add(this.label27);
        this.flpBands.Controls.Add(this.txtRangeBand);
        this.flpBands.Controls.Add(this.label28);
        this.flpBands.Controls.Add(this.txtTargetSpeed);
        this.flpBands.Controls.Add(this.chkShowBands);
        this.flpBands.Location = new Point(1520, 281);
        this.flpBands.Name = "flpBands";
        this.flpBands.Size = new Size(100, 127);
        this.flpBands.TabIndex = 31 /*0x1F*/;
        this.label27.Location = new Point(5, 0);
        this.label27.Margin = new Padding(5, 0, 5, 0);
        this.label27.Name = "label27";
        this.label27.Size = new Size(90, 18);
        this.label27.TabIndex = 3;
        this.label27.Text = "Range Bands";
        this.label27.TextAlign = ContentAlignment.MiddleCenter;
        this.txtRangeBand.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtRangeBand.BorderStyle = BorderStyle.None;
        this.txtRangeBand.ForeColor = Color.FromArgb(128 /*0x80*/, 255, 128 /*0x80*/);
        this.txtRangeBand.Location = new Point(5, 27);
        this.txtRangeBand.Margin = new Padding(5, 9, 5, 6);
        this.txtRangeBand.Name = "txtRangeBand";
        this.txtRangeBand.Size = new Size(90, 13);
        this.txtRangeBand.TabIndex = 31 /*0x1F*/;
        this.txtRangeBand.Text = "10000";
        this.txtRangeBand.TextAlign = HorizontalAlignment.Center;
        this.label28.Location = new Point(5, 46);
        this.label28.Margin = new Padding(5, 0, 5, 0);
        this.label28.Name = "label28";
        this.label28.Size = new Size(90, 13);
        this.label28.TabIndex = 3;
        this.label28.Text = "Target Speed";
        this.label28.TextAlign = ContentAlignment.MiddleCenter;
        this.txtTargetSpeed.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtTargetSpeed.BorderStyle = BorderStyle.None;
        this.txtTargetSpeed.ForeColor = Color.FromArgb(128 /*0x80*/, 255, 128 /*0x80*/);
        this.txtTargetSpeed.Location = new Point(5, 68);
        this.txtTargetSpeed.Margin = new Padding(5, 9, 5, 3);
        this.txtTargetSpeed.Name = "txtTargetSpeed";
        this.txtTargetSpeed.Size = new Size(90, 13);
        this.txtTargetSpeed.TabIndex = 32 /*0x20*/;
        this.txtTargetSpeed.Text = "4000";
        this.txtTargetSpeed.TextAlign = HorizontalAlignment.Center;
        this.chkShowBands.AutoSize = true;
        this.chkShowBands.Location = new Point(3, 87);
        this.chkShowBands.Name = "chkShowBands";
        this.chkShowBands.Padding = new Padding(5, 0, 0, 0);
        this.chkShowBands.Size = new Size(91, 17);
        this.chkShowBands.TabIndex = 33;
        this.chkShowBands.Text = "Show Bands";
        this.chkShowBands.TextAlign = ContentAlignment.MiddleRight;
        this.chkShowBands.UseVisualStyleBackColor = true;
        this.chkShowBands.Click += this.chkRandomName_Click;
        this.flowLayoutPanelMembers.BorderStyle = BorderStyle.FixedSingle;
        this.flowLayoutPanelMembers.Controls.Add(this.lstMembers);
        this.flowLayoutPanelMembers.Location = new Point(1520, 412);
        this.flowLayoutPanelMembers.Name = "flowLayoutPanelMembers";
        this.flowLayoutPanelMembers.Size = new Size(100, 357);
        this.flowLayoutPanelMembers.TabIndex = 68;
        this.lstMembers.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.lstMembers.BorderStyle = BorderStyle.None;
        this.lstMembers.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.lstMembers.FormattingEnabled = true;
        this.lstMembers.Location = new Point(0, 0);
        this.lstMembers.Margin = new Padding(0);
        this.lstMembers.Name = "lstMembers";
        this.lstMembers.SelectionMode = SelectionMode.None;
        this.lstMembers.Size = new Size(100, 351);
        this.lstMembers.TabIndex = 53;
        this.flowLayoutPanel5.Controls.Add(this.cmdRenameComp);
        this.flowLayoutPanel5.Controls.Add(this.cndObsoComp);
        this.flowLayoutPanel5.Controls.Add(this.cmdDesignTech);
        this.flowLayoutPanel5.Controls.Add(this.cmdViewTech);
        this.flowLayoutPanel5.Controls.Add(this.cmdRefreshTech);
        this.flowLayoutPanel5.Controls.Add(this.cmdArmour);
        this.flowLayoutPanel5.Controls.Add(this.cmdCrewDesign);
        this.flowLayoutPanel5.Controls.Add(this.cmdSuperWide);
        this.flowLayoutPanel5.Controls.Add(this.cmdDelete);
        this.flowLayoutPanel5.Location = new Point(731, 802);
        this.flowLayoutPanel5.Name = "flowLayoutPanel5";
        this.flowLayoutPanel5.Size = new Size(889, 30);
        this.flowLayoutPanel5.TabIndex = 42;
        this.cmdRenameComp.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdRenameComp.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdRenameComp.Location = new Point(0, 0);
        this.cmdRenameComp.Margin = new Padding(0);
        this.cmdRenameComp.Name = "cmdRenameComp";
        this.cmdRenameComp.Size = new Size(96 /*0x60*/, 30);
        this.cmdRenameComp.TabIndex = 42;
        this.cmdRenameComp.Tag = "1200";
        this.cmdRenameComp.Text = "Rename Comp";
        this.cmdRenameComp.UseVisualStyleBackColor = false;
        this.cmdRenameComp.Click += this.cmdRenameComp_Click;
        this.cndObsoComp.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cndObsoComp.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cndObsoComp.Location = new Point(96 /*0x60*/, 0);
        this.cndObsoComp.Margin = new Padding(0);
        this.cndObsoComp.Name = "cndObsoComp";
        this.cndObsoComp.Size = new Size(96 /*0x60*/, 30);
        this.cndObsoComp.TabIndex = 43;
        this.cndObsoComp.Tag = "1200";
        this.cndObsoComp.Text = "Obso Comp";
        this.cndObsoComp.UseVisualStyleBackColor = false;
        this.cndObsoComp.Click += this.cndObsoComp_Click;
        this.cmdDesignTech.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdDesignTech.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdDesignTech.Location = new Point(192 /*0xC0*/, 0);
        this.cmdDesignTech.Margin = new Padding(0);
        this.cmdDesignTech.Name = "cmdDesignTech";
        this.cmdDesignTech.Size = new Size(96 /*0x60*/, 30);
        this.cmdDesignTech.TabIndex = 44;
        this.cmdDesignTech.Tag = "1200";
        this.cmdDesignTech.Text = "Design Tech";
        this.cmdDesignTech.UseVisualStyleBackColor = false;
        this.cmdDesignTech.Click += this.cmdDesignTech_Click;
        this.cmdViewTech.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdViewTech.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdViewTech.Location = new Point(288, 0);
        this.cmdViewTech.Margin = new Padding(0);
        this.cmdViewTech.Name = "cmdViewTech";
        this.cmdViewTech.Size = new Size(96 /*0x60*/, 30);
        this.cmdViewTech.TabIndex = 45;
        this.cmdViewTech.Tag = "1200";
        this.cmdViewTech.Text = "View Tech";
        this.cmdViewTech.UseVisualStyleBackColor = false;
        this.cmdViewTech.Click += this.cmdViewTech_Click;
        this.cmdRefreshTech.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdRefreshTech.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdRefreshTech.Location = new Point(384, 0);
        this.cmdRefreshTech.Margin = new Padding(0);
        this.cmdRefreshTech.Name = "cmdRefreshTech";
        this.cmdRefreshTech.Size = new Size(96 /*0x60*/, 30);
        this.cmdRefreshTech.TabIndex = 46;
        this.cmdRefreshTech.Tag = "1200";
        this.cmdRefreshTech.Text = "Refresh Tech";
        this.cmdRefreshTech.UseVisualStyleBackColor = false;
        this.cmdRefreshTech.Click += this.cmdRefreshTech_Click;
        this.cmdArmour.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdArmour.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdArmour.Location = new Point(480, 0);
        this.cmdArmour.Margin = new Padding(0);
        this.cmdArmour.Name = "cmdArmour";
        this.cmdArmour.Size = new Size(96 /*0x60*/, 30);
        this.cmdArmour.TabIndex = 47;
        this.cmdArmour.Tag = "1200";
        this.cmdArmour.Text = "Update Armour";
        this.cmdArmour.UseVisualStyleBackColor = false;
        this.cmdArmour.Click += this.cmdArmour_Click;
        this.cmdCrewDesign.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdCrewDesign.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdCrewDesign.Location = new Point(576, 0);
        this.cmdCrewDesign.Margin = new Padding(0);
        this.cmdCrewDesign.Name = "cmdCrewDesign";
        this.cmdCrewDesign.Size = new Size(96 /*0x60*/, 30);
        this.cmdCrewDesign.TabIndex = 51;
        this.cmdCrewDesign.Tag = "1200";
        this.cmdCrewDesign.Text = "Update CDE";
        this.cmdCrewDesign.UseVisualStyleBackColor = false;
        this.cmdCrewDesign.Click += this.cmdCrewDesign_Click;
        this.cmdSuperWide.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdSuperWide.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdSuperWide.Location = new Point(672, 0);
        this.cmdSuperWide.Margin = new Padding(0);
        this.cmdSuperWide.Name = "cmdSuperWide";
        this.cmdSuperWide.Size = new Size(96 /*0x60*/, 30);
        this.cmdSuperWide.TabIndex = 49;
        this.cmdSuperWide.Tag = "1200";
        this.cmdSuperWide.Text = "Wide View";
        this.cmdSuperWide.UseVisualStyleBackColor = false;
        this.cmdSuperWide.Click += this.cmdSuperWide_Click;
        this.cmdDelete.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdDelete.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdDelete.Location = new Point(768 /*0x0300*/, 0);
        this.cmdDelete.Margin = new Padding(0);
        this.cmdDelete.Name = "cmdDelete";
        this.cmdDelete.Size = new Size(96 /*0x60*/, 30);
        this.cmdDelete.TabIndex = 50;
        this.cmdDelete.Tag = "1200";
        this.cmdDelete.Text = "Delete Class";
        this.cmdDelete.UseVisualStyleBackColor = false;
        this.cmdDelete.Click += this.cmdDelete_Click;
        this.txtDesignErrors.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtDesignErrors.BorderStyle = BorderStyle.FixedSingle;
        this.txtDesignErrors.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
        this.txtDesignErrors.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.txtDesignErrors.Location = new Point(1262, 641);
        this.txtDesignErrors.Margin = new Padding(0, 0, 3, 3);
        this.txtDesignErrors.Multiline = true;
        this.txtDesignErrors.Name = "txtDesignErrors";
        this.txtDesignErrors.Size = new Size(254, 128 /*0x80*/);
        this.txtDesignErrors.TabIndex = 52;
        this.flpMultiples.Anchor = AnchorStyles.None;
        this.flpMultiples.AutoSize = true;
        this.flpMultiples.Controls.Add(this.chkShowObsolete);
        this.flpMultiples.Controls.Add(this.chkPrototypes);
        this.flpMultiples.Controls.Add(this.rdo1);
        this.flpMultiples.Controls.Add(this.rdo5);
        this.flpMultiples.Controls.Add(this.rdo20);
        this.flpMultiples.Controls.Add(this.rdo100);
        this.flpMultiples.Location = new Point(-22, 805);
        this.flpMultiples.Margin = new Padding(0, 3, 3, 3);
        this.flpMultiples.Name = "flpMultiples";
        this.flpMultiples.Size = new Size(336, 27);
        this.flpMultiples.TabIndex = 10;
        this.chkShowObsolete.AutoSize = true;
        this.chkShowObsolete.Location = new Point(0, 3);
        this.chkShowObsolete.Margin = new Padding(0, 3, 2, 3);
        this.chkShowObsolete.Name = "chkShowObsolete";
        this.chkShowObsolete.Padding = new Padding(5, 0, 0, 0);
        this.chkShowObsolete.Size = new Size(73, 17);
        this.chkShowObsolete.TabIndex = 14;
        this.chkShowObsolete.Text = "Obsolete";
        this.chkShowObsolete.TextAlign = ContentAlignment.MiddleRight;
        this.chkShowObsolete.UseVisualStyleBackColor = true;
        this.chkShowObsolete.CheckedChanged += this.chkPrototypes_CheckedChanged;
        this.chkPrototypes.AutoSize = true;
        this.chkPrototypes.Location = new Point(75, 3);
        this.chkPrototypes.Margin = new Padding(0, 3, 2, 3);
        this.chkPrototypes.Name = "chkPrototypes";
        this.chkPrototypes.Padding = new Padding(5, 0, 0, 0);
        this.chkPrototypes.Size = new Size(81, 17);
        this.chkPrototypes.TabIndex = 15;
        this.chkPrototypes.Text = "Prototypes";
        this.chkPrototypes.TextAlign = ContentAlignment.MiddleRight;
        this.chkPrototypes.UseVisualStyleBackColor = true;
        this.chkPrototypes.CheckedChanged += this.chkPrototypes_CheckedChanged;
        this.rdo1.AutoSize = true;
        this.rdo1.Checked = true;
        this.rdo1.Location = new Point(160 /*0xA0*/, 3);
        this.rdo1.Margin = new Padding(2, 3, 3, 3);
        this.rdo1.Name = "rdo1";
        this.rdo1.Size = new Size(31 /*0x1F*/, 17);
        this.rdo1.TabIndex = 10;
        this.rdo1.TabStop = true;
        this.rdo1.Tag = "1";
        this.rdo1.Text = "1";
        this.rdo1.UseVisualStyleBackColor = true;
        this.rdo5.AutoSize = true;
        this.rdo5.Location = new Point(194, 3);
        this.rdo5.Margin = new Padding(0, 3, 3, 3);
        this.rdo5.Name = "rdo5";
        this.rdo5.Size = new Size(31 /*0x1F*/, 17);
        this.rdo5.TabIndex = 11;
        this.rdo5.TabStop = true;
        this.rdo5.Text = "5";
        this.rdo5.UseVisualStyleBackColor = true;
        this.rdo20.AutoSize = true;
        this.rdo20.Location = new Point(228, 3);
        this.rdo20.Margin = new Padding(0, 3, 3, 3);
        this.rdo20.Name = "rdo20";
        this.rdo20.Size = new Size(37, 17);
        this.rdo20.TabIndex = 12;
        this.rdo20.TabStop = true;
        this.rdo20.Text = "20";
        this.rdo20.UseVisualStyleBackColor = true;
        this.rdo100.AutoSize = true;
        this.rdo100.Location = new Point(268, 3);
        this.rdo100.Margin = new Padding(0, 3, 3, 3);
        this.rdo100.Name = "rdo100";
        this.rdo100.Size = new Size(43, 17);
        this.rdo100.TabIndex = 13;
        this.rdo100.TabStop = true;
        this.rdo100.Text = "100";
        this.rdo100.UseVisualStyleBackColor = true;
        this.txtComponentDetail.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtComponentDetail.BorderStyle = BorderStyle.FixedSingle;
        this.txtComponentDetail.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
        this.txtComponentDetail.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.txtComponentDetail.Location = new Point(731, 641);
        this.txtComponentDetail.Margin = new Padding(0, 0, 3, 3);
        this.txtComponentDetail.Multiline = true;
        this.txtComponentDetail.Name = "txtComponentDetail";
        this.txtComponentDetail.Size = new Size(528, 128 /*0x80*/);
        this.txtComponentDetail.TabIndex = 51;
        this.tvComponents.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.tvComponents.BorderStyle = BorderStyle.FixedSingle;
        this.tvComponents.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.tvComponents.Location = new Point(3, 35);
        this.tvComponents.Margin = new Padding(0, 2, 0, 0);
        this.tvComponents.Name = "tvComponents";
        this.tvComponents.Size = new Size(360, 766);
        this.tvComponents.TabIndex = 7;
        this.tvComponents.AfterCollapse += this.tvComponents_AfterCollapse;
        this.tvComponents.AfterExpand += this.tvComponents_AfterExpand;
        this.tvComponents.AfterSelect += this.tvComponents_AfterSelect;
        this.tvComponents.DoubleClick += this.tvComponents_DoubleClick;
        this.tvComponents.KeyDown += this.tvComponents_KeyDown;
        this.tvInClass.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.tvInClass.BorderStyle = BorderStyle.FixedSingle;
        this.tvInClass.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.tvInClass.Location = new Point(367, 6);
        this.tvInClass.Margin = new Padding(0, 2, 0, 0);
        this.tvInClass.Name = "tvInClass";
        this.tvInClass.Size = new Size(360, 795);
        this.tvInClass.TabIndex = 8;
        this.tvInClass.Visible = false;
        this.tvInClass.AfterCollapse += this.tvInClass_AfterExpand;
        this.tvInClass.AfterExpand += this.tvInClass_AfterExpand;
        this.tvInClass.AfterSelect += this.tvInClass_AfterSelect;
        this.tvInClass.DoubleClick += this.tvInClass_DoubleClick;
        this.tvInClass.KeyDown += this.tvInClass_KeyDown;
        this.flowLayoutPanel1.Controls.Add(this.cboHullDescription);
        this.flowLayoutPanel1.Controls.Add(this.label4);
        this.flowLayoutPanel1.Controls.Add(this.txtArmourRequired);
        this.flowLayoutPanel1.Controls.Add(this.label6);
        this.flowLayoutPanel1.Controls.Add(this.txtMonths);
        this.flowLayoutPanel1.Controls.Add(this.label25);
        this.flowLayoutPanel1.Controls.Add(this.txtBuildTime);
        this.flowLayoutPanel1.Controls.Add(this.label26);
        this.flowLayoutPanel1.Controls.Add(this.txtLoadTime);
        this.flowLayoutPanel1.Controls.Add(this.label5);
        this.flowLayoutPanel1.Controls.Add(this.txtSize);
        this.flowLayoutPanel1.Location = new Point(731, 7);
        this.flowLayoutPanel1.Name = "flowLayoutPanel1";
        this.flowLayoutPanel1.Size = new Size(889, 26);
        this.flowLayoutPanel1.TabIndex = 16 /*0x10*/;
        this.cboHullDescription.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cboHullDescription.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cboHullDescription.FormattingEnabled = true;
        this.cboHullDescription.Location = new Point(0, 3);
        this.cboHullDescription.Margin = new Padding(0, 3, 3, 3);
        this.cboHullDescription.Name = "cboHullDescription";
        this.cboHullDescription.Size = new Size(184, 21);
        this.cboHullDescription.TabIndex = 16 /*0x10*/;
        this.cboHullDescription.SelectedIndexChanged += this.cboHullDescription_SelectedIndexChanged;
        this.label4.AutoSize = true;
        this.label4.Location = new Point(193, 3);
        this.label4.Margin = new Padding(6, 3, 0, 3);
        this.label4.Name = "label4";
        this.label4.Padding = new Padding(0, 5, 5, 0);
        this.label4.Size = new Size(79, 18);
        this.label4.TabIndex = 3;
        this.label4.Text = "Armour Rating";
        this.txtArmourRequired.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtArmourRequired.BorderStyle = BorderStyle.None;
        this.txtArmourRequired.ForeColor = Color.FromArgb(128 /*0x80*/, 255, 128 /*0x80*/);
        this.txtArmourRequired.Location = new Point(272, 8);
        this.txtArmourRequired.Margin = new Padding(0, 8, 3, 3);
        this.txtArmourRequired.Name = "txtArmourRequired";
        this.txtArmourRequired.Size = new Size(24, 13);
        this.txtArmourRequired.TabIndex = 17;
        this.txtArmourRequired.Text = "1";
        this.txtArmourRequired.TextAlign = HorizontalAlignment.Center;
        this.txtArmourRequired.TextChanged += this.txtArmourRequired_TextChanged;
        this.label6.AutoSize = true;
        this.label6.Location = new Point(305, 3);
        this.label6.Margin = new Padding(6, 3, 0, 3);
        this.label6.Name = "label6";
        this.label6.Padding = new Padding(0, 5, 5, 0);
        this.label6.Size = new Size(94, 18);
        this.label6.TabIndex = 3;
        this.label6.Text = "Deployment Time";
        this.txtMonths.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtMonths.BorderStyle = BorderStyle.None;
        this.txtMonths.ForeColor = Color.FromArgb(128 /*0x80*/, 255, 128 /*0x80*/);
        this.txtMonths.Location = new Point(399, 8);
        this.txtMonths.Margin = new Padding(0, 8, 3, 3);
        this.txtMonths.Name = "txtMonths";
        this.txtMonths.Size = new Size(24, 13);
        this.txtMonths.TabIndex = 18;
        this.txtMonths.Text = "3";
        this.txtMonths.TextAlign = HorizontalAlignment.Center;
        this.txtMonths.TextChanged += this.txtMonths_TextChanged;
        this.label25.AutoSize = true;
        this.label25.Dock = DockStyle.Left;
        this.label25.Location = new Point(432, 3);
        this.label25.Margin = new Padding(6, 3, 0, 3);
        this.label25.Name = "label25";
        this.label25.Padding = new Padding(0, 5, 5, 0);
        this.label25.Size = new Size(83, 21);
        this.label25.TabIndex = 65;
        this.label25.Text = "Build Time (yrs)";
        this.txtBuildTime.Location = new Point(515, 8);
        this.txtBuildTime.Margin = new Padding(0, 8, 3, 3);
        this.txtBuildTime.Name = "txtBuildTime";
        this.txtBuildTime.Size = new Size(45, 13);
        this.txtBuildTime.TabIndex = 19;
        this.txtBuildTime.Text = "0";
        this.txtBuildTime.TextAlign = ContentAlignment.MiddleCenter;
        this.label26.Anchor = AnchorStyles.None;
        this.label26.AutoSize = true;
        this.label26.Location = new Point(569, 4);
        this.label26.Margin = new Padding(6, 3, 0, 3);
        this.label26.Name = "label26";
        this.label26.Padding = new Padding(0, 5, 5, 0);
        this.label26.Size = new Size(62, 18);
        this.label26.TabIndex = 67;
        this.label26.Text = "Load Time";
        this.txtLoadTime.Anchor = AnchorStyles.None;
        this.txtLoadTime.Location = new Point(631, 9);
        this.txtLoadTime.Margin = new Padding(0, 8, 3, 3);
        this.txtLoadTime.Name = "txtLoadTime";
        this.txtLoadTime.Size = new Size(68, 13);
        this.txtLoadTime.TabIndex = 20;
        this.txtLoadTime.Text = "0";
        this.txtLoadTime.TextAlign = ContentAlignment.MiddleCenter;
        this.label5.Anchor = AnchorStyles.None;
        this.label5.AutoSize = true;
        this.label5.Location = new Point(708, 4);
        this.label5.Margin = new Padding(6, 3, 0, 3);
        this.label5.Name = "label5";
        this.label5.Padding = new Padding(0, 5, 5, 0);
        this.label5.Size = new Size(62, 18);
        this.label5.TabIndex = 69;
        this.label5.Text = "Exact Size";
        this.txtSize.Anchor = AnchorStyles.None;
        this.txtSize.Location = new Point(770, 9);
        this.txtSize.Margin = new Padding(0, 8, 3, 3);
        this.txtSize.Name = "txtSize";
        this.txtSize.Size = new Size(55, 13);
        this.txtSize.TabIndex = 21;
        this.txtSize.Text = "0";
        this.txtSize.TextAlign = ContentAlignment.MiddleCenter;
        this.flowLayoutPanel2.Controls.Add(this.cmdNew);
        this.flowLayoutPanel2.Controls.Add(this.cmdRename);
        this.flowLayoutPanel2.Controls.Add(this.cmdSelectName);
        this.flowLayoutPanel2.Controls.Add(this.cmdLock);
        this.flowLayoutPanel2.Controls.Add(this.cmdCopy);
        this.flowLayoutPanel2.Controls.Add(this.cmdResearch);
        this.flowLayoutPanel2.Controls.Add(this.cmdExportClass);
        this.flowLayoutPanel2.Controls.Add(this.cmdNewHull);
        this.flowLayoutPanel2.Location = new Point(731, 772);
        this.flowLayoutPanel2.Name = "flowLayoutPanel2";
        this.flowLayoutPanel2.Size = new Size(889, 30);
        this.flowLayoutPanel2.TabIndex = 34;
        this.cmdNew.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdNew.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdNew.Location = new Point(0, 0);
        this.cmdNew.Margin = new Padding(0);
        this.cmdNew.Name = "cmdNew";
        this.cmdNew.Size = new Size(96 /*0x60*/, 30);
        this.cmdNew.TabIndex = 34;
        this.cmdNew.Tag = "1200";
        this.cmdNew.Text = "New Ship Class";
        this.cmdNew.UseVisualStyleBackColor = false;
        this.cmdNew.Click += this.cmdNew_Click;
        this.cmdRename.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdRename.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdRename.Location = new Point(96 /*0x60*/, 0);
        this.cmdRename.Margin = new Padding(0);
        this.cmdRename.Name = "cmdRename";
        this.cmdRename.Size = new Size(96 /*0x60*/, 30);
        this.cmdRename.TabIndex = 35;
        this.cmdRename.Tag = "1200";
        this.cmdRename.Text = "Rename Class";
        this.cmdRename.UseVisualStyleBackColor = false;
        this.cmdRename.Click += this.cmdRename_Click;
        this.cmdSelectName.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdSelectName.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdSelectName.Location = new Point(192 /*0xC0*/, 0);
        this.cmdSelectName.Margin = new Padding(0);
        this.cmdSelectName.Name = "cmdSelectName";
        this.cmdSelectName.Size = new Size(96 /*0x60*/, 30);
        this.cmdSelectName.TabIndex = 36;
        this.cmdSelectName.Tag = "1200";
        this.cmdSelectName.Text = "Select Name";
        this.cmdSelectName.UseVisualStyleBackColor = false;
        this.cmdSelectName.Click += this.cmdSelectName_Click;
        this.cmdLock.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdLock.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdLock.Location = new Point(288, 0);
        this.cmdLock.Margin = new Padding(0);
        this.cmdLock.Name = "cmdLock";
        this.cmdLock.Size = new Size(96 /*0x60*/, 30);
        this.cmdLock.TabIndex = 37;
        this.cmdLock.Tag = "1200";
        this.cmdLock.Text = "Lock Class";
        this.cmdLock.UseVisualStyleBackColor = false;
        this.cmdLock.Click += this.cmdLock_Click;
        this.cmdCopy.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdCopy.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdCopy.Location = new Point(384, 0);
        this.cmdCopy.Margin = new Padding(0);
        this.cmdCopy.Name = "cmdCopy";
        this.cmdCopy.Size = new Size(96 /*0x60*/, 30);
        this.cmdCopy.TabIndex = 38;
        this.cmdCopy.Tag = "1200";
        this.cmdCopy.Text = "Copy Class";
        this.cmdCopy.UseVisualStyleBackColor = false;
        this.cmdCopy.Click += this.cmdCopy_Click;
        this.cmdResearch.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdResearch.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdResearch.Location = new Point(480, 0);
        this.cmdResearch.Margin = new Padding(0);
        this.cmdResearch.Name = "cmdResearch";
        this.cmdResearch.Size = new Size(96 /*0x60*/, 30);
        this.cmdResearch.TabIndex = 39;
        this.cmdResearch.Tag = "1200";
        this.cmdResearch.Text = "Research Proto";
        this.cmdResearch.UseVisualStyleBackColor = false;
        this.cmdResearch.Visible = false;
        this.cmdResearch.Click += this.cmdResearch_Click;
        this.cmdExportClass.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdExportClass.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdExportClass.Location = new Point(576, 0);
        this.cmdExportClass.Margin = new Padding(0);
        this.cmdExportClass.Name = "cmdExportClass";
        this.cmdExportClass.Size = new Size(96 /*0x60*/, 30);
        this.cmdExportClass.TabIndex = 42;
        this.cmdExportClass.Tag = "1200";
        this.cmdExportClass.Text = "Create Template";
        this.cmdExportClass.UseVisualStyleBackColor = false;
        this.cmdExportClass.Click += this.cmdExportClass_Click;
        this.cmdNewHull.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdNewHull.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdNewHull.Location = new Point(672, 0);
        this.cmdNewHull.Margin = new Padding(0);
        this.cmdNewHull.Name = "cmdNewHull";
        this.cmdNewHull.Size = new Size(96 /*0x60*/, 30);
        this.cmdNewHull.TabIndex = 48 /*0x30*/;
        this.cmdNewHull.Tag = "1200";
        this.cmdNewHull.Text = "New Hull";
        this.cmdNewHull.UseVisualStyleBackColor = false;
        this.cmdNewHull.Click += this.cmdNewHull_Click;
        this.ShipsInClass.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.ShipsInClass.Controls.Add(this.flowLayoutPanel16);
        this.ShipsInClass.Controls.Add(this.flowLayoutPanel12);
        this.ShipsInClass.Controls.Add(this.flowLayoutPanel8);
        this.ShipsInClass.Controls.Add(this.lstvShips);
        this.ShipsInClass.Location = new Point(4, 22);
        this.ShipsInClass.Name = "ShipsInClass";
        this.ShipsInClass.Padding = new Padding(3);
        this.ShipsInClass.Size = new Size(1624, 836);
        this.ShipsInClass.TabIndex = 3;
        this.ShipsInClass.Text = "Ships in Class";
        this.flowLayoutPanel16.BorderStyle = BorderStyle.FixedSingle;
        this.flowLayoutPanel16.Controls.Add(this.label18);
        this.flowLayoutPanel16.Controls.Add(this.rdoShip);
        this.flowLayoutPanel16.Controls.Add(this.rdoFleet);
        this.flowLayoutPanel16.Location = new Point(1102, 473);
        this.flowLayoutPanel16.Name = "flowLayoutPanel16";
        this.flowLayoutPanel16.Size = new Size(106, 83);
        this.flowLayoutPanel16.TabIndex = 83;
        this.label18.AutoSize = true;
        this.label18.Location = new Point(3, 6);
        this.label18.Margin = new Padding(3, 6, 3, 6);
        this.label18.Name = "label18";
        this.label18.Size = new Size(86, 13);
        this.label18.TabIndex = 65;
        this.label18.Text = "Double-Click List";
        this.rdoShip.AutoSize = true;
        this.rdoShip.Checked = true;
        this.rdoShip.Location = new Point(3, 28);
        this.rdoShip.Name = "rdoShip";
        this.rdoShip.Size = new Size(79, 17);
        this.rdoShip.TabIndex = 63 /*0x3F*/;
        this.rdoShip.TabStop = true;
        this.rdoShip.Text = "Select Ship";
        this.rdoShip.UseVisualStyleBackColor = true;
        this.rdoFleet.AutoSize = true;
        this.rdoFleet.Location = new Point(3, 51);
        this.rdoFleet.Name = "rdoFleet";
        this.rdoFleet.Size = new Size(81, 17);
        this.rdoFleet.TabIndex = 64 /*0x40*/;
        this.rdoFleet.Text = "Select Fleet";
        this.rdoFleet.UseVisualStyleBackColor = true;
        this.flowLayoutPanel12.BorderStyle = BorderStyle.FixedSingle;
        this.flowLayoutPanel12.Controls.Add(this.cmdRenameAll);
        this.flowLayoutPanel12.Controls.Add(this.cmdRenumberAll);
        this.flowLayoutPanel12.Controls.Add(this.cmdRenumberHull);
        this.flowLayoutPanel12.Controls.Add(this.button1);
        this.flowLayoutPanel12.FlowDirection = FlowDirection.TopDown;
        this.flowLayoutPanel12.Location = new Point(1102, 292);
        this.flowLayoutPanel12.Name = "flowLayoutPanel12";
        this.flowLayoutPanel12.Size = new Size(104, 160 /*0xA0*/);
        this.flowLayoutPanel12.TabIndex = 81;
        this.cmdRenameAll.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdRenameAll.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdRenameAll.Location = new Point(3, 6);
        this.cmdRenameAll.Margin = new Padding(3, 6, 3, 3);
        this.cmdRenameAll.Name = "cmdRenameAll";
        this.cmdRenameAll.Size = new Size(96 /*0x60*/, 30);
        this.cmdRenameAll.TabIndex = 51;
        this.cmdRenameAll.Tag = "1200";
        this.cmdRenameAll.Text = "Rename All";
        this.cmdRenameAll.UseVisualStyleBackColor = false;
        this.cmdRenameAll.Click += this.cmdRenameAll_Click;
        this.cmdRenumberAll.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdRenumberAll.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdRenumberAll.Location = new Point(3, 45);
        this.cmdRenumberAll.Margin = new Padding(3, 6, 3, 3);
        this.cmdRenumberAll.Name = "cmdRenumberAll";
        this.cmdRenumberAll.Size = new Size(96 /*0x60*/, 30);
        this.cmdRenumberAll.TabIndex = 52;
        this.cmdRenumberAll.Tag = "1200";
        this.cmdRenumberAll.Text = "Renumber All";
        this.cmdRenumberAll.UseVisualStyleBackColor = false;
        this.cmdRenumberAll.Click += this.cmdRenumberAll_Click;
        this.cmdRenumberHull.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdRenumberHull.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdRenumberHull.Location = new Point(3, 84);
        this.cmdRenumberHull.Margin = new Padding(3, 6, 3, 3);
        this.cmdRenumberHull.Name = "cmdRenumberHull";
        this.cmdRenumberHull.Size = new Size(96 /*0x60*/, 30);
        this.cmdRenumberHull.TabIndex = 53;
        this.cmdRenumberHull.Tag = "1200";
        this.cmdRenumberHull.Text = "Renumber Hull";
        this.cmdRenumberHull.UseVisualStyleBackColor = false;
        this.cmdRenumberHull.Click += this.cmdRenumberHull_Click;
        this.flowLayoutPanel8.BorderStyle = BorderStyle.FixedSingle;
        this.flowLayoutPanel8.Controls.Add(this.cmdSortLaunch);
        this.flowLayoutPanel8.Controls.Add(this.cmdSortShipName);
        this.flowLayoutPanel8.Controls.Add(this.cmdSortSystemName);
        this.flowLayoutPanel8.Controls.Add(this.cmdSortFleetName);
        this.flowLayoutPanel8.Controls.Add(this.cmdSortMainClock);
        this.flowLayoutPanel8.Controls.Add(this.cmdSortShoreLeave);
        this.flowLayoutPanel8.Controls.Add(this.cndSortFuel);
        this.flowLayoutPanel8.FlowDirection = FlowDirection.TopDown;
        this.flowLayoutPanel8.Location = new Point(1102, 8);
        this.flowLayoutPanel8.Name = "flowLayoutPanel8";
        this.flowLayoutPanel8.Size = new Size(104, 278);
        this.flowLayoutPanel8.TabIndex = 79;
        this.cmdSortLaunch.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdSortLaunch.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdSortLaunch.Location = new Point(3, 3);
        this.cmdSortLaunch.Name = "cmdSortLaunch";
        this.cmdSortLaunch.Size = new Size(96 /*0x60*/, 30);
        this.cmdSortLaunch.TabIndex = 44;
        this.cmdSortLaunch.Tag = "1200";
        this.cmdSortLaunch.Text = "Launch Date";
        this.cmdSortLaunch.UseVisualStyleBackColor = false;
        this.cmdSortLaunch.Click += this.cndSortFuel_Click;
        this.cmdSortShipName.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdSortShipName.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdSortShipName.Location = new Point(3, 42);
        this.cmdSortShipName.Margin = new Padding(3, 6, 3, 3);
        this.cmdSortShipName.Name = "cmdSortShipName";
        this.cmdSortShipName.Size = new Size(96 /*0x60*/, 30);
        this.cmdSortShipName.TabIndex = 45;
        this.cmdSortShipName.Tag = "1200";
        this.cmdSortShipName.Text = "Ship Name";
        this.cmdSortShipName.UseVisualStyleBackColor = false;
        this.cmdSortShipName.Click += this.cndSortFuel_Click;
        this.cmdSortSystemName.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdSortSystemName.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdSortSystemName.Location = new Point(3, 81);
        this.cmdSortSystemName.Margin = new Padding(3, 6, 3, 3);
        this.cmdSortSystemName.Name = "cmdSortSystemName";
        this.cmdSortSystemName.Size = new Size(96 /*0x60*/, 30);
        this.cmdSortSystemName.TabIndex = 46;
        this.cmdSortSystemName.Tag = "1200";
        this.cmdSortSystemName.Text = "System Name";
        this.cmdSortSystemName.UseVisualStyleBackColor = false;
        this.cmdSortSystemName.Click += this.cndSortFuel_Click;
        this.cmdSortFleetName.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdSortFleetName.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdSortFleetName.Location = new Point(3, 120);
        this.cmdSortFleetName.Margin = new Padding(3, 6, 3, 3);
        this.cmdSortFleetName.Name = "cmdSortFleetName";
        this.cmdSortFleetName.Size = new Size(96 /*0x60*/, 30);
        this.cmdSortFleetName.TabIndex = 47;
        this.cmdSortFleetName.Tag = "1200";
        this.cmdSortFleetName.Text = "Fleet Name";
        this.cmdSortFleetName.UseVisualStyleBackColor = false;
        this.cmdSortFleetName.Click += this.cndSortFuel_Click;
        this.cmdSortMainClock.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdSortMainClock.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdSortMainClock.Location = new Point(3, 159);
        this.cmdSortMainClock.Margin = new Padding(3, 6, 3, 3);
        this.cmdSortMainClock.Name = "cmdSortMainClock";
        this.cmdSortMainClock.Size = new Size(96 /*0x60*/, 30);
        this.cmdSortMainClock.TabIndex = 48 /*0x30*/;
        this.cmdSortMainClock.Tag = "1200";
        this.cmdSortMainClock.Text = "Maint Clock";
        this.cmdSortMainClock.UseVisualStyleBackColor = false;
        this.cmdSortMainClock.Click += this.cndSortFuel_Click;
        this.cmdSortShoreLeave.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdSortShoreLeave.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdSortShoreLeave.Location = new Point(3, 198);
        this.cmdSortShoreLeave.Margin = new Padding(3, 6, 3, 3);
        this.cmdSortShoreLeave.Name = "cmdSortShoreLeave";
        this.cmdSortShoreLeave.Size = new Size(96 /*0x60*/, 30);
        this.cmdSortShoreLeave.TabIndex = 49;
        this.cmdSortShoreLeave.Tag = "1200";
        this.cmdSortShoreLeave.Text = "Shore Leave";
        this.cmdSortShoreLeave.UseVisualStyleBackColor = false;
        this.cmdSortShoreLeave.Click += this.cndSortFuel_Click;
        this.cndSortFuel.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cndSortFuel.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cndSortFuel.Location = new Point(3, 237);
        this.cndSortFuel.Margin = new Padding(3, 6, 3, 3);
        this.cndSortFuel.Name = "cndSortFuel";
        this.cndSortFuel.Size = new Size(96 /*0x60*/, 30);
        this.cndSortFuel.TabIndex = 50;
        this.cndSortFuel.Tag = "1200";
        this.cndSortFuel.Text = "Fuel";
        this.cndSortFuel.UseVisualStyleBackColor = false;
        this.cndSortFuel.Click += this.cndSortFuel_Click;
        this.lstvShips.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.lstvShips.BorderStyle = BorderStyle.FixedSingle;
        this.lstvShips.Columns.AddRange(new ColumnHeader[9]
        {
            this.columnHeader_17,
            this.columnHeader_18,
            this.columnHeader_19,
            this.columnHeader_20,
            this.columnHeader_21,
            this.columnHeader_22,
            this.columnHeader_23,
            this.columnHeader_24,
            this.columnHeader_25
        });
        this.lstvShips.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.lstvShips.FullRowSelect = true;
        this.lstvShips.HeaderStyle = ColumnHeaderStyle.None;
        this.lstvShips.HideSelection = false;
        this.lstvShips.Location = new Point(8, 8);
        this.lstvShips.Name = "lstvShips";
        this.lstvShips.Size = new Size(1088, 820);
        this.lstvShips.TabIndex = 77;
        this.lstvShips.UseCompatibleStateImageBehavior = false;
        this.lstvShips.View = View.Details;
        this.lstvShips.SelectedIndexChanged += this.lstvShips_SelectedIndexChanged;
        this.lstvShips.DoubleClick += this.lstvShips_DoubleClick;
        this.columnHeader_17.Width = 160 /*0xA0*/;
        this.columnHeader_18.Width = 200;
        this.columnHeader_19.Width = 140;
        this.columnHeader_20.Width = 120;
        this.columnHeader_21.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_21.Width = 80 /*0x50*/;
        this.columnHeader_22.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_22.Width = 80 /*0x50*/;
        this.columnHeader_23.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_23.Width = 80 /*0x50*/;
        this.columnHeader_24.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_24.Width = 80 /*0x50*/;
        this.columnHeader_25.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_25.Width = 80 /*0x50*/;
        this.ComponentsTab.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.ComponentsTab.Controls.Add(this.flowLayoutPanel6);
        this.ComponentsTab.Controls.Add(this.lstvComponents);
        this.ComponentsTab.Location = new Point(4, 22);
        this.ComponentsTab.Name = "ComponentsTab";
        this.ComponentsTab.Padding = new Padding(3);
        this.ComponentsTab.Size = new Size(1624, 836);
        this.ComponentsTab.TabIndex = 5;
        this.ComponentsTab.Text = "Components";
        this.flowLayoutPanel6.Controls.Add(this.cmdSortAmount);
        this.flowLayoutPanel6.Controls.Add(this.cmdSortSize);
        this.flowLayoutPanel6.Controls.Add(this.cmdSortCost);
        this.flowLayoutPanel6.Controls.Add(this.cmdSortCrew);
        this.flowLayoutPanel6.Controls.Add(this.cmdSortHTK);
        this.flowLayoutPanel6.Controls.Add(this.cmdDAC);
        this.flowLayoutPanel6.Controls.Add(this.cmdEDAC);
        this.flowLayoutPanel6.Controls.Add(this.chkComponentSummary);
        this.flowLayoutPanel6.Location = new Point(4, 804);
        this.flowLayoutPanel6.Name = "flowLayoutPanel6";
        this.flowLayoutPanel6.Size = new Size(1202, 32 /*0x20*/);
        this.flowLayoutPanel6.TabIndex = 81;
        this.cmdSortAmount.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdSortAmount.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdSortAmount.Location = new Point(0, 0);
        this.cmdSortAmount.Margin = new Padding(0);
        this.cmdSortAmount.Name = "cmdSortAmount";
        this.cmdSortAmount.Size = new Size(96 /*0x60*/, 30);
        this.cmdSortAmount.TabIndex = 53;
        this.cmdSortAmount.Tag = "1200";
        this.cmdSortAmount.Text = "Sort Amount";
        this.cmdSortAmount.UseVisualStyleBackColor = false;
        this.cmdSortAmount.Click += this.cmdEDAC_Click;
        this.cmdSortSize.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdSortSize.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdSortSize.Location = new Point(96 /*0x60*/, 0);
        this.cmdSortSize.Margin = new Padding(0);
        this.cmdSortSize.Name = "cmdSortSize";
        this.cmdSortSize.Size = new Size(96 /*0x60*/, 30);
        this.cmdSortSize.TabIndex = 54;
        this.cmdSortSize.Tag = "1200";
        this.cmdSortSize.Text = "Sort Size";
        this.cmdSortSize.UseVisualStyleBackColor = false;
        this.cmdSortSize.Click += this.cmdEDAC_Click;
        this.cmdSortCost.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdSortCost.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdSortCost.Location = new Point(192 /*0xC0*/, 0);
        this.cmdSortCost.Margin = new Padding(0);
        this.cmdSortCost.Name = "cmdSortCost";
        this.cmdSortCost.Size = new Size(96 /*0x60*/, 30);
        this.cmdSortCost.TabIndex = 55;
        this.cmdSortCost.Tag = "1200";
        this.cmdSortCost.Text = "Sort Cost";
        this.cmdSortCost.UseVisualStyleBackColor = false;
        this.cmdSortCost.Click += this.cmdEDAC_Click;
        this.cmdSortCrew.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdSortCrew.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdSortCrew.Location = new Point(288, 0);
        this.cmdSortCrew.Margin = new Padding(0);
        this.cmdSortCrew.Name = "cmdSortCrew";
        this.cmdSortCrew.Size = new Size(96 /*0x60*/, 30);
        this.cmdSortCrew.TabIndex = 56;
        this.cmdSortCrew.Tag = "1200";
        this.cmdSortCrew.Text = "Sort Crew";
        this.cmdSortCrew.UseVisualStyleBackColor = false;
        this.cmdSortCrew.Click += this.cmdEDAC_Click;
        this.cmdSortHTK.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdSortHTK.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdSortHTK.Location = new Point(384, 0);
        this.cmdSortHTK.Margin = new Padding(0);
        this.cmdSortHTK.Name = "cmdSortHTK";
        this.cmdSortHTK.Size = new Size(96 /*0x60*/, 30);
        this.cmdSortHTK.TabIndex = 57;
        this.cmdSortHTK.Tag = "1200";
        this.cmdSortHTK.Text = "Sort HTK";
        this.cmdSortHTK.UseVisualStyleBackColor = false;
        this.cmdSortHTK.Click += this.cmdEDAC_Click;
        this.cmdDAC.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdDAC.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdDAC.Location = new Point(480, 0);
        this.cmdDAC.Margin = new Padding(0);
        this.cmdDAC.Name = "cmdDAC";
        this.cmdDAC.Size = new Size(96 /*0x60*/, 30);
        this.cmdDAC.TabIndex = 58;
        this.cmdDAC.Tag = "1200";
        this.cmdDAC.Text = "Sort DAC";
        this.cmdDAC.UseVisualStyleBackColor = false;
        this.cmdDAC.Click += this.cmdEDAC_Click;
        this.cmdEDAC.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdEDAC.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdEDAC.Location = new Point(576, 0);
        this.cmdEDAC.Margin = new Padding(0);
        this.cmdEDAC.Name = "cmdEDAC";
        this.cmdEDAC.Size = new Size(96 /*0x60*/, 30);
        this.cmdEDAC.TabIndex = 59;
        this.cmdEDAC.Tag = "1200";
        this.cmdEDAC.Text = "Sort E-DAC";
        this.cmdEDAC.UseVisualStyleBackColor = false;
        this.cmdEDAC.Click += this.cmdEDAC_Click;
        this.chkComponentSummary.AutoSize = true;
        this.chkComponentSummary.Location = new Point(684, 8);
        this.chkComponentSummary.Margin = new Padding(12, 8, 3, 3);
        this.chkComponentSummary.Name = "chkComponentSummary";
        this.chkComponentSummary.Padding = new Padding(5, 0, 0, 0);
        this.chkComponentSummary.Size = new Size(104, 17);
        this.chkComponentSummary.TabIndex = 60;
        this.chkComponentSummary.Text = "Show Summary";
        this.chkComponentSummary.TextAlign = ContentAlignment.MiddleRight;
        this.chkComponentSummary.UseVisualStyleBackColor = true;
        this.chkComponentSummary.CheckedChanged += this.chkComponentSummary_CheckedChanged;
        this.lstvComponents.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.lstvComponents.BorderStyle = BorderStyle.FixedSingle;
        this.lstvComponents.Columns.AddRange(new ColumnHeader[12]
        {
            this.columnHeader_28,
            this.columnHeader_29,
            this.columnHeader_30,
            this.columnHeader_32,
            this.columnHeader_34,
            this.columnHeader_36,
            this.columnHeader_31,
            this.columnHeader_33,
            this.columnHeader_35,
            this.columnHeader_37,
            this.columnHeader_38,
            this.columnHeader_39
        });
        this.lstvComponents.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.lstvComponents.FullRowSelect = true;
        this.lstvComponents.HeaderStyle = ColumnHeaderStyle.None;
        this.lstvComponents.HideSelection = false;
        this.lstvComponents.Location = new Point(4, 5);
        this.lstvComponents.Name = "lstvComponents";
        this.lstvComponents.Size = new Size(1205, 797);
        this.lstvComponents.TabIndex = 79;
        this.lstvComponents.UseCompatibleStateImageBehavior = false;
        this.lstvComponents.View = View.Details;
        this.lstvComponents.SelectedIndexChanged += this.lstvComponents_SelectedIndexChanged;
        this.columnHeader_28.Width = 340;
        this.columnHeader_29.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_29.Width = 70;
        this.columnHeader_30.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_30.Width = 70;
        this.columnHeader_32.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_32.Width = 70;
        this.columnHeader_34.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_34.Width = 70;
        this.columnHeader_36.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_36.Width = 70;
        this.columnHeader_31.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_31.Width = 70;
        this.columnHeader_33.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_33.Width = 70;
        this.columnHeader_35.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_35.Width = 70;
        this.columnHeader_37.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_37.Width = 70;
        this.columnHeader_38.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_38.Width = 70;
        this.columnHeader_39.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_39.Width = 70;
        this.OrdnanceFightres.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.OrdnanceFightres.Controls.Add(this.flowLayoutPanel14);
        this.OrdnanceFightres.Controls.Add(this.flowLayoutPanel13);
        this.OrdnanceFightres.Controls.Add(this.flowLayoutPanel4);
        this.OrdnanceFightres.Controls.Add(this.lstvTemplate);
        this.OrdnanceFightres.Controls.Add(this.panel4);
        this.OrdnanceFightres.Controls.Add(this.lstvOrdnance);
        this.OrdnanceFightres.Controls.Add(this.lstvFighters);
        this.OrdnanceFightres.Location = new Point(4, 22);
        this.OrdnanceFightres.Margin = new Padding(0);
        this.OrdnanceFightres.Name = "OrdnanceFightres";
        this.OrdnanceFightres.Padding = new Padding(3);
        this.OrdnanceFightres.Size = new Size(1624, 836);
        this.OrdnanceFightres.TabIndex = 0;
        this.OrdnanceFightres.Text = "Ordnance & Fighters";
        this.flowLayoutPanel14.BorderStyle = BorderStyle.FixedSingle;
        this.flowLayoutPanel14.Controls.Add(this.lstClassGround);
        this.flowLayoutPanel14.Controls.Add(this.lblTroopCapacity);
        this.flowLayoutPanel14.Location = new Point(795, 524);
        this.flowLayoutPanel14.Name = "flowLayoutPanel14";
        this.flowLayoutPanel14.Size = new Size(200, 257);
        this.flowLayoutPanel14.TabIndex = 160 /*0xA0*/;
        this.lstClassGround.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.lstClassGround.BorderStyle = BorderStyle.None;
        this.lstClassGround.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.lstClassGround.FormattingEnabled = true;
        this.lstClassGround.Location = new Point(0, 0);
        this.lstClassGround.Margin = new Padding(0);
        this.lstClassGround.Name = "lstClassGround";
        this.lstClassGround.Size = new Size(200, 234);
        this.lstClassGround.TabIndex = 77;
        this.lstClassGround.DoubleClick += this.lstClassGround_DoubleClick;
        this.lblTroopCapacity.AutoSize = true;
        this.lblTroopCapacity.Location = new Point(3, 234);
        this.lblTroopCapacity.Name = "lblTroopCapacity";
        this.lblTroopCapacity.Size = new Size(17, 13);
        this.lblTroopCapacity.TabIndex = 162;
        this.lblTroopCapacity.Text = "xx";
        this.flowLayoutPanel13.BorderStyle = BorderStyle.FixedSingle;
        this.flowLayoutPanel13.Controls.Add(this.lstClassOrdnance);
        this.flowLayoutPanel13.Controls.Add(this.lblOrdnanceCapacity);
        this.flowLayoutPanel13.Location = new Point(998, 298);
        this.flowLayoutPanel13.Name = "flowLayoutPanel13";
        this.flowLayoutPanel13.Size = new Size(206, 222);
        this.flowLayoutPanel13.TabIndex = 159;
        this.lstClassOrdnance.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.lstClassOrdnance.BorderStyle = BorderStyle.None;
        this.lstClassOrdnance.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.lstClassOrdnance.FormattingEnabled = true;
        this.lstClassOrdnance.Location = new Point(0, 0);
        this.lstClassOrdnance.Margin = new Padding(0);
        this.lstClassOrdnance.Name = "lstClassOrdnance";
        this.lstClassOrdnance.Size = new Size(206, 195);
        this.lstClassOrdnance.TabIndex = 65;
        this.lstClassOrdnance.DoubleClick += this.lstClassOrdnance_DoubleClick;
        this.lblOrdnanceCapacity.AutoSize = true;
        this.lblOrdnanceCapacity.Location = new Point(3, 195);
        this.lblOrdnanceCapacity.Name = "lblOrdnanceCapacity";
        this.lblOrdnanceCapacity.Size = new Size(17, 13);
        this.lblOrdnanceCapacity.TabIndex = 162;
        this.lblOrdnanceCapacity.Text = "xx";
        this.flowLayoutPanel4.BorderStyle = BorderStyle.FixedSingle;
        this.flowLayoutPanel4.Controls.Add(this.lstClassFighters);
        this.flowLayoutPanel4.Controls.Add(this.lblHangarCapacity);
        this.flowLayoutPanel4.Location = new Point(795, 298);
        this.flowLayoutPanel4.Name = "flowLayoutPanel4";
        this.flowLayoutPanel4.Size = new Size(200, 222);
        this.flowLayoutPanel4.TabIndex = 158;
        this.lstClassFighters.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.lstClassFighters.BorderStyle = BorderStyle.None;
        this.lstClassFighters.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.lstClassFighters.FormattingEnabled = true;
        this.lstClassFighters.Location = new Point(0, 0);
        this.lstClassFighters.Margin = new Padding(0);
        this.lstClassFighters.Name = "lstClassFighters";
        this.lstClassFighters.Size = new Size(200, 195);
        this.lstClassFighters.TabIndex = 65;
        this.lstClassFighters.DoubleClick += this.lstClassFighters_DoubleClick;
        this.lblHangarCapacity.AutoSize = true;
        this.lblHangarCapacity.Location = new Point(3, 195);
        this.lblHangarCapacity.Name = "lblHangarCapacity";
        this.lblHangarCapacity.Size = new Size(17, 13);
        this.lblHangarCapacity.TabIndex = 161;
        this.lblHangarCapacity.Text = "xx";
        this.lstvTemplate.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.lstvTemplate.BorderStyle = BorderStyle.FixedSingle;
        this.lstvTemplate.Columns.AddRange(new ColumnHeader[9]
        {
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
        this.lstvTemplate.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.lstvTemplate.FullRowSelect = true;
        this.lstvTemplate.HeaderStyle = ColumnHeaderStyle.None;
        this.lstvTemplate.HideSelection = false;
        this.lstvTemplate.Location = new Point(6, 524);
        this.lstvTemplate.MultiSelect = false;
        this.lstvTemplate.Name = "lstvTemplate";
        this.lstvTemplate.Size = new Size(786, 257);
        this.lstvTemplate.TabIndex = 157;
        this.lstvTemplate.UseCompatibleStateImageBehavior = false;
        this.lstvTemplate.View = View.Details;
        this.lstvTemplate.SelectedIndexChanged += this.lstvTemplate_SelectedIndexChanged;
        this.lstvTemplate.DoubleClick += this.lstvTemplate_DoubleClick;
        this.columnHeader_41.Width = 50;
        this.columnHeader_42.Width = 200;
        this.columnHeader_43.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_43.Width = 50;
        this.columnHeader_44.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_44.Width = 55;
        this.columnHeader_45.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_45.Width = 55;
        this.columnHeader_46.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_46.Width = 55;
        this.columnHeader_47.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_47.Width = 55;
        this.columnHeader_48.Width = 170;
        this.columnHeader_49.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_49.Width = 40;
        this.panel4.BorderStyle = BorderStyle.FixedSingle;
        this.panel4.Controls.Add(this.flowLayoutPanel17);
        this.panel4.Controls.Add(this.cmdRenameMissile);
        this.panel4.Controls.Add(this.cmdObsoleteFighter);
        this.panel4.Controls.Add(this.cmdObsoleteMissile);
        this.panel4.Controls.Add(this.flowLayoutPanel7);
        this.panel4.Location = new Point(6, 785);
        this.panel4.Name = "panel4";
        this.panel4.Size = new Size(1200, 45);
        this.panel4.TabIndex = 73;
        this.flowLayoutPanel17.Controls.Add(this.chkObsoleteMissiles);
        this.flowLayoutPanel17.Controls.Add(this.chkObsoleteFighters);
        this.flowLayoutPanel17.Controls.Add(this.checkBox1);
        this.flowLayoutPanel17.Controls.Add(this.chkLargerParasites);
        this.flowLayoutPanel17.Location = new Point(211, 7);
        this.flowLayoutPanel17.Name = "flowLayoutPanel17";
        this.flowLayoutPanel17.Size = new Size(647, 24);
        this.flowLayoutPanel17.TabIndex = 161;
        this.chkObsoleteMissiles.AutoSize = true;
        this.chkObsoleteMissiles.Location = new Point(3, 7);
        this.chkObsoleteMissiles.Margin = new Padding(3, 7, 3, 3);
        this.chkObsoleteMissiles.Name = "chkObsoleteMissiles";
        this.chkObsoleteMissiles.Padding = new Padding(5, 0, 0, 0);
        this.chkObsoleteMissiles.Size = new Size(142, 17);
        this.chkObsoleteMissiles.TabIndex = 64 /*0x40*/;
        this.chkObsoleteMissiles.Text = "Show Obsolete Missiles";
        this.chkObsoleteMissiles.TextAlign = ContentAlignment.MiddleRight;
        this.chkObsoleteMissiles.UseVisualStyleBackColor = true;
        this.chkObsoleteMissiles.CheckedChanged += this.chkObsoleteMissiles_CheckedChanged;
        this.chkObsoleteFighters.AutoSize = true;
        this.chkObsoleteFighters.Location = new Point(151, 7);
        this.chkObsoleteFighters.Margin = new Padding(3, 7, 3, 3);
        this.chkObsoleteFighters.Name = "chkObsoleteFighters";
        this.chkObsoleteFighters.Padding = new Padding(5, 0, 0, 0);
        this.chkObsoleteFighters.Size = new Size(143, 17);
        this.chkObsoleteFighters.TabIndex = 65;
        this.chkObsoleteFighters.Text = "Show Obsolete Fighters";
        this.chkObsoleteFighters.TextAlign = ContentAlignment.MiddleRight;
        this.chkObsoleteFighters.UseVisualStyleBackColor = true;
        this.chkObsoleteFighters.CheckedChanged += this.chkObsoleteFighters_CheckedChanged;
        this.checkBox1.AutoSize = true;
        this.checkBox1.Location = new Point(300, 7);
        this.checkBox1.Margin = new Padding(3, 7, 3, 3);
        this.checkBox1.Name = "checkBox1";
        this.checkBox1.Padding = new Padding(5, 0, 0, 0);
        this.checkBox1.Size = new Size(155, 17);
        this.checkBox1.TabIndex = 66;
        this.checkBox1.Text = "No Missile Size Restriction";
        this.checkBox1.TextAlign = ContentAlignment.MiddleRight;
        this.checkBox1.UseVisualStyleBackColor = true;
        this.chkLargerParasites.AutoSize = true;
        this.chkLargerParasites.Location = new Point(461, 7);
        this.chkLargerParasites.Margin = new Padding(3, 7, 3, 3);
        this.chkLargerParasites.Name = "chkLargerParasites";
        this.chkLargerParasites.Padding = new Padding(5, 0, 0, 0);
        this.chkLargerParasites.Size = new Size(147, 17);
        this.chkLargerParasites.TabIndex = 72;
        this.chkLargerParasites.Text = "Larger Parasites Allowed";
        this.chkLargerParasites.TextAlign = ContentAlignment.MiddleRight;
        this.chkLargerParasites.UseVisualStyleBackColor = true;
        this.chkLargerParasites.CheckedChanged += this.chkLargerParasites_CheckedChanged;
        this.cmdRenameMissile.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdRenameMissile.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdRenameMissile.Location = new Point(907, 6);
        this.cmdRenameMissile.Margin = new Padding(0);
        this.cmdRenameMissile.Name = "cmdRenameMissile";
        this.cmdRenameMissile.Size = new Size(96 /*0x60*/, 30);
        this.cmdRenameMissile.TabIndex = 67;
        this.cmdRenameMissile.Tag = "1200";
        this.cmdRenameMissile.Text = "Rename Missile";
        this.cmdRenameMissile.UseVisualStyleBackColor = false;
        this.cmdRenameMissile.Click += this.cmdRenameMissile_Click;
        this.cmdObsoleteFighter.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdObsoleteFighter.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdObsoleteFighter.Location = new Point(1099, 6);
        this.cmdObsoleteFighter.Margin = new Padding(0);
        this.cmdObsoleteFighter.Name = "cmdObsoleteFighter";
        this.cmdObsoleteFighter.Size = new Size(96 /*0x60*/, 30);
        this.cmdObsoleteFighter.TabIndex = 69;
        this.cmdObsoleteFighter.Tag = "1200";
        this.cmdObsoleteFighter.Text = "Obsolete Fighter";
        this.cmdObsoleteFighter.UseVisualStyleBackColor = false;
        this.cmdObsoleteFighter.Click += this.cmdObsoleteFighter_Click;
        this.cmdObsoleteMissile.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdObsoleteMissile.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdObsoleteMissile.Location = new Point(1003, 6);
        this.cmdObsoleteMissile.Margin = new Padding(0);
        this.cmdObsoleteMissile.Name = "cmdObsoleteMissile";
        this.cmdObsoleteMissile.Size = new Size(96 /*0x60*/, 30);
        this.cmdObsoleteMissile.TabIndex = 68;
        this.cmdObsoleteMissile.Tag = "1200";
        this.cmdObsoleteMissile.Text = "Obsolete Missile";
        this.cmdObsoleteMissile.UseVisualStyleBackColor = false;
        this.cmdObsoleteMissile.Click += this.cmdObsoleteMissile_Click;
        this.flowLayoutPanel7.Anchor = AnchorStyles.None;
        this.flowLayoutPanel7.AutoSize = true;
        this.flowLayoutPanel7.Controls.Add(this.rdoLoadout1);
        this.flowLayoutPanel7.Controls.Add(this.rdoLoadout10);
        this.flowLayoutPanel7.Controls.Add(this.rdoLoadout100);
        this.flowLayoutPanel7.Controls.Add(this.rdoLoadout1000);
        this.flowLayoutPanel7.Location = new Point(21, 10);
        this.flowLayoutPanel7.Name = "flowLayoutPanel7";
        this.flowLayoutPanel7.Size = new Size(184, 23);
        this.flowLayoutPanel7.TabIndex = 71;
        this.rdoLoadout1.AutoSize = true;
        this.rdoLoadout1.Checked = true;
        this.rdoLoadout1.Location = new Point(3, 3);
        this.rdoLoadout1.Name = "rdoLoadout1";
        this.rdoLoadout1.Size = new Size(31 /*0x1F*/, 17);
        this.rdoLoadout1.TabIndex = 60;
        this.rdoLoadout1.TabStop = true;
        this.rdoLoadout1.Tag = "1";
        this.rdoLoadout1.Text = "1";
        this.rdoLoadout1.UseVisualStyleBackColor = true;
        this.rdoLoadout10.AutoSize = true;
        this.rdoLoadout10.Location = new Point(40, 3);
        this.rdoLoadout10.Name = "rdoLoadout10";
        this.rdoLoadout10.Size = new Size(37, 17);
        this.rdoLoadout10.TabIndex = 61;
        this.rdoLoadout10.Text = "10";
        this.rdoLoadout10.UseVisualStyleBackColor = true;
        this.rdoLoadout100.AutoSize = true;
        this.rdoLoadout100.Location = new Point(83, 3);
        this.rdoLoadout100.Name = "rdoLoadout100";
        this.rdoLoadout100.Size = new Size(43, 17);
        this.rdoLoadout100.TabIndex = 62;
        this.rdoLoadout100.Text = "100";
        this.rdoLoadout100.UseVisualStyleBackColor = true;
        this.rdoLoadout1000.AutoSize = true;
        this.rdoLoadout1000.Location = new Point(132, 3);
        this.rdoLoadout1000.Name = "rdoLoadout1000";
        this.rdoLoadout1000.Size = new Size(49, 17);
        this.rdoLoadout1000.TabIndex = 63 /*0x3F*/;
        this.rdoLoadout1000.Text = "1000";
        this.rdoLoadout1000.UseVisualStyleBackColor = true;
        this.lstvOrdnance.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.lstvOrdnance.BorderStyle = BorderStyle.FixedSingle;
        this.lstvOrdnance.Columns.AddRange(new ColumnHeader[13]
        {
            this.columnHeader_0,
            this.columnHeader_1,
            this.columnHeader_2,
            this.columnHeader_3,
            this.columnHeader_40,
            this.columnHeader_4,
            this.columnHeader_53,
            this.columnHeader_5,
            this.columnHeader_6,
            this.columnHeader_7,
            this.columnHeader_8,
            this.columnHeader_9,
            this.columnHeader_10
        });
        this.lstvOrdnance.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.lstvOrdnance.FullRowSelect = true;
        this.lstvOrdnance.HeaderStyle = ColumnHeaderStyle.None;
        this.lstvOrdnance.HideSelection = false;
        this.lstvOrdnance.Location = new Point(6, 4);
        this.lstvOrdnance.Name = "lstvOrdnance";
        this.lstvOrdnance.Size = new Size(1198, 290);
        this.lstvOrdnance.TabIndex = 69;
        this.lstvOrdnance.UseCompatibleStateImageBehavior = false;
        this.lstvOrdnance.View = View.Details;
        this.lstvOrdnance.SelectedIndexChanged += this.lstvOrdnance_SelectedIndexChanged;
        this.lstvOrdnance.DoubleClick += this.lstvOrdnance_DoubleClick;
        this.columnHeader_0.Width = 160 /*0xA0*/;
        this.columnHeader_1.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_1.Width = 55;
        this.columnHeader_2.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_2.Width = 55;
        this.columnHeader_3.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_3.Width = 70;
        this.columnHeader_40.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_40.Width = 55;
        this.columnHeader_4.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_53.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_53.Width = 55;
        this.columnHeader_5.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_5.Width = 70;
        this.columnHeader_6.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_6.Width = 90;
        this.columnHeader_7.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_8.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_9.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_9.Width = 180;
        this.columnHeader_10.Width = 150;
        this.lstvFighters.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.lstvFighters.BorderStyle = BorderStyle.FixedSingle;
        this.lstvFighters.Columns.AddRange(new ColumnHeader[6]
        {
            this.columnHeader_11,
            this.columnHeader_12,
            this.columnHeader_13,
            this.columnHeader_14,
            this.columnHeader_15,
            this.columnHeader_16
        });
        this.lstvFighters.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.lstvFighters.FullRowSelect = true;
        this.lstvFighters.HeaderStyle = ColumnHeaderStyle.None;
        this.lstvFighters.HideSelection = false;
        this.lstvFighters.Location = new Point(6, 298);
        this.lstvFighters.Name = "lstvFighters";
        this.lstvFighters.Size = new Size(786, 222);
        this.lstvFighters.TabIndex = 70;
        this.lstvFighters.UseCompatibleStateImageBehavior = false;
        this.lstvFighters.View = View.Details;
        this.lstvFighters.SelectedIndexChanged += this.lstvFighters_SelectedIndexChanged;
        this.lstvFighters.DoubleClick += this.lstvFighters_DoubleClick;
        this.columnHeader_11.Text = "Name";
        this.columnHeader_11.Width = 160 /*0xA0*/;
        this.columnHeader_12.Text = "Size";
        this.columnHeader_12.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_12.Width = 80 /*0x50*/;
        this.columnHeader_13.Text = "Cost (BP)";
        this.columnHeader_13.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_13.Width = 80 /*0x50*/;
        this.columnHeader_14.Text = "Speed";
        this.columnHeader_14.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_14.Width = 80 /*0x50*/;
        this.columnHeader_15.Text = "Range";
        this.columnHeader_15.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_15.Width = 80 /*0x50*/;
        this.columnHeader_16.Text = "Armament";
        this.columnHeader_16.Width = 280;
        this.tabPage4.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.tabPage4.Controls.Add(this.cmdAutoDesign);
        this.tabPage4.Controls.Add(this.cmdDesignPhilosopy);
        this.tabPage4.Controls.Add(this.label19);
        this.tabPage4.Controls.Add(this.lstvRefit);
        this.tabPage4.Controls.Add(this.flowLayoutPanel10);
        this.tabPage4.Controls.Add(this.pnlInstantBuild);
        this.tabPage4.Controls.Add(this.lstvCrew);
        this.tabPage4.Controls.Add(this.chkUseAlienTech);
        this.tabPage4.Controls.Add(this.flowLayoutPanel9);
        this.tabPage4.Controls.Add(this.txtDetails);
        this.tabPage4.Location = new Point(4, 22);
        this.tabPage4.Name = "tabPage4";
        this.tabPage4.Padding = new Padding(3);
        this.tabPage4.Size = new Size(1624, 836);
        this.tabPage4.TabIndex = 4;
        this.tabPage4.Text = "Priorities / Misc";
        this.tabPage4.Click += this.tabPage4_Click;
        this.cmdAutoDesign.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdAutoDesign.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdAutoDesign.Location = new Point(1524, 5);
        this.cmdAutoDesign.Margin = new Padding(0);
        this.cmdAutoDesign.Name = "cmdAutoDesign";
        this.cmdAutoDesign.Size = new Size(96 /*0x60*/, 30);
        this.cmdAutoDesign.TabIndex = 132;
        this.cmdAutoDesign.Tag = "1200";
        this.cmdAutoDesign.Text = "Auto Design";
        this.cmdAutoDesign.UseVisualStyleBackColor = false;
        this.cmdDesignPhilosopy.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdDesignPhilosopy.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdDesignPhilosopy.Location = new Point(1524, 36);
        this.cmdDesignPhilosopy.Margin = new Padding(0);
        this.cmdDesignPhilosopy.Name = "cmdDesignPhilosopy";
        this.cmdDesignPhilosopy.Size = new Size(96 /*0x60*/, 30);
        this.cmdDesignPhilosopy.TabIndex = 133;
        this.cmdDesignPhilosopy.Tag = "1200";
        this.cmdDesignPhilosopy.Text = "Design Philosopy";
        this.cmdDesignPhilosopy.UseVisualStyleBackColor = false;
        this.cmdDesignPhilosopy.Visible = false;
        this.label19.Location = new Point(222, 654);
        this.label19.Name = "label19";
        this.label19.Size = new Size(527, 57);
        this.label19.TabIndex = 131;
        this.label19.Text = componentResourceManager.GetString("label19.Text");
        this.lstvRefit.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.lstvRefit.BorderStyle = BorderStyle.FixedSingle;
        this.lstvRefit.Columns.AddRange(new ColumnHeader[5]
        {
            this.columnHeader_50,
            this.columnHeader_51,
            this.columnHeader_52,
            this.columnHeader_62,
            this.columnHeader_63
        });
        this.lstvRefit.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.lstvRefit.FullRowSelect = true;
        this.lstvRefit.HeaderStyle = ColumnHeaderStyle.None;
        this.lstvRefit.HideSelection = false;
        this.lstvRefit.Location = new Point(225, 8);
        this.lstvRefit.Margin = new Padding(4, 3, 3, 3);
        this.lstvRefit.Name = "lstvRefit";
        this.lstvRefit.Size = new Size(524, 631);
        this.lstvRefit.TabIndex = 129;
        this.lstvRefit.UseCompatibleStateImageBehavior = false;
        this.lstvRefit.View = View.Details;
        this.columnHeader_50.Width = 200;
        this.columnHeader_51.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_51.Width = 80 /*0x50*/;
        this.columnHeader_52.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_52.Width = 80 /*0x50*/;
        this.columnHeader_62.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_62.Width = 80 /*0x50*/;
        this.columnHeader_63.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_63.Width = 80 /*0x50*/;
        this.flowLayoutPanel10.BorderStyle = BorderStyle.FixedSingle;
        this.flowLayoutPanel10.Controls.Add(this.panel1);
        this.flowLayoutPanel10.Controls.Add(this.flowLayoutPanel11);
        this.flowLayoutPanel10.Controls.Add(this.chkRandomName);
        this.flowLayoutPanel10.FlowDirection = FlowDirection.TopDown;
        this.flowLayoutPanel10.Location = new Point(755, 8);
        this.flowLayoutPanel10.Name = "flowLayoutPanel10";
        this.flowLayoutPanel10.Size = new Size(350, 86);
        this.flowLayoutPanel10.TabIndex = 128 /*0x80*/;
        this.panel1.Controls.Add(this.label11);
        this.panel1.Controls.Add(this.cboNamingTheme);
        this.panel1.Location = new Point(3, 3);
        this.panel1.Name = "panel1";
        this.panel1.Size = new Size(336, 24);
        this.panel1.TabIndex = 127;
        this.label11.Anchor = AnchorStyles.None;
        this.label11.AutoSize = true;
        this.label11.Location = new Point(0, 6);
        this.label11.Margin = new Padding(3);
        this.label11.Name = "label11";
        this.label11.Size = new Size(79, 13);
        this.label11.TabIndex = 127;
        this.label11.Text = "Naming Theme";
        this.cboNamingTheme.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cboNamingTheme.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cboNamingTheme.FormattingEnabled = true;
        this.cboNamingTheme.Location = new Point(85, 2);
        this.cboNamingTheme.Margin = new Padding(3, 10, 3, 0);
        this.cboNamingTheme.Name = "cboNamingTheme";
        this.cboNamingTheme.Size = new Size(250, 21);
        this.cboNamingTheme.TabIndex = 81;
        this.cboNamingTheme.SelectedIndexChanged += this.cboNamingTheme_SelectedIndexChanged;
        this.flowLayoutPanel11.Controls.Add(this.lblPrefix);
        this.flowLayoutPanel11.Controls.Add(this.txtPrefix);
        this.flowLayoutPanel11.Controls.Add(this.label12);
        this.flowLayoutPanel11.Controls.Add(this.txtSuffix);
        this.flowLayoutPanel11.Location = new Point(3, 33);
        this.flowLayoutPanel11.Name = "flowLayoutPanel11";
        this.flowLayoutPanel11.Size = new Size(336, 20);
        this.flowLayoutPanel11.TabIndex = 129;
        this.lblPrefix.AutoSize = true;
        this.lblPrefix.Location = new Point(3, 3);
        this.lblPrefix.Margin = new Padding(3, 3, 3, 0);
        this.lblPrefix.Name = "lblPrefix";
        this.lblPrefix.Size = new Size(33, 13);
        this.lblPrefix.TabIndex = 0;
        this.lblPrefix.Text = "Prefix";
        this.txtPrefix.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtPrefix.BorderStyle = BorderStyle.None;
        this.txtPrefix.Dock = DockStyle.Right;
        this.txtPrefix.ForeColor = Color.FromArgb(128 /*0x80*/, 255, 128 /*0x80*/);
        this.txtPrefix.Location = new Point(42, 3);
        this.txtPrefix.Name = "txtPrefix";
        this.txtPrefix.Size = new Size(120, 13);
        this.txtPrefix.TabIndex = 82;
        this.txtPrefix.Text = "None";
        this.txtPrefix.TextAlign = HorizontalAlignment.Center;
        this.txtPrefix.TextChanged += this.txtPrefix_TextChanged;
        this.label12.AutoSize = true;
        this.label12.Location = new Point(168, 3);
        this.label12.Margin = new Padding(3, 3, 3, 0);
        this.label12.Name = "label12";
        this.label12.Size = new Size(33, 13);
        this.label12.TabIndex = 107;
        this.label12.Text = "Suffix";
        this.txtSuffix.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtSuffix.BorderStyle = BorderStyle.None;
        this.txtSuffix.Dock = DockStyle.Right;
        this.txtSuffix.ForeColor = Color.FromArgb(128 /*0x80*/, 255, 128 /*0x80*/);
        this.txtSuffix.Location = new Point(207, 3);
        this.txtSuffix.Name = "txtSuffix";
        this.txtSuffix.Size = new Size(120, 13);
        this.txtSuffix.TabIndex = 83;
        this.txtSuffix.Text = "None";
        this.txtSuffix.TextAlign = HorizontalAlignment.Center;
        this.txtSuffix.TextChanged += this.txtSuffix_TextChanged;
        this.chkRandomName.AutoSize = true;
        this.chkRandomName.Location = new Point(3, 59);
        this.chkRandomName.Name = "chkRandomName";
        this.chkRandomName.Padding = new Padding(5, 0, 0, 0);
        this.chkRandomName.Size = new Size(194, 17);
        this.chkRandomName.TabIndex = 84;
        this.chkRandomName.Text = "Select Random Name from Theme";
        this.chkRandomName.TextAlign = ContentAlignment.MiddleRight;
        this.chkRandomName.UseVisualStyleBackColor = true;
        this.chkRandomName.Click += this.chkRandomName_Click;
        this.pnlInstantBuild.BorderStyle = BorderStyle.FixedSingle;
        this.pnlInstantBuild.Controls.Add(this.panel7);
        this.pnlInstantBuild.Controls.Add(this.panel5);
        this.pnlInstantBuild.Controls.Add(this.chkIncludeParasites);
        this.pnlInstantBuild.Controls.Add(this.chkIncludeGround);
        this.pnlInstantBuild.Controls.Add(this.chkEnterNames);
        this.pnlInstantBuild.Controls.Add(this.rdoFleetIB);
        this.pnlInstantBuild.Controls.Add(this.rdoIBAdmin);
        this.pnlInstantBuild.Controls.Add(this.cboAdminCommands);
        this.pnlInstantBuild.Controls.Add(this.cboFleets);
        this.pnlInstantBuild.Controls.Add(this.chkMothership);
        this.pnlInstantBuild.Controls.Add(this.cboMothershipClass);
        this.pnlInstantBuild.Controls.Add(this.cboMothership);
        this.pnlInstantBuild.Controls.Add(this.chkAssignSquadron);
        this.pnlInstantBuild.Controls.Add(this.cboSquadron);
        this.pnlInstantBuild.Controls.Add(this.cmdInstantBuild);
        this.pnlInstantBuild.Location = new Point(6, 233);
        this.pnlInstantBuild.Name = "pnlInstantBuild";
        this.pnlInstantBuild.Size = new Size(212, 406);
        this.pnlInstantBuild.TabIndex = 125;
        this.panel7.Controls.Add(this.txtInstantBuild);
        this.panel7.Controls.Add(this.label2);
        this.panel7.Location = new Point(3, 10);
        this.panel7.Margin = new Padding(3, 10, 3, 3);
        this.panel7.Name = "panel7";
        this.panel7.Size = new Size(200, 15);
        this.panel7.TabIndex = 124;
        this.txtInstantBuild.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtInstantBuild.BorderStyle = BorderStyle.None;
        this.txtInstantBuild.Dock = DockStyle.Right;
        this.txtInstantBuild.ForeColor = Color.FromArgb(128 /*0x80*/, 255, 128 /*0x80*/);
        this.txtInstantBuild.Location = new Point(140, 0);
        this.txtInstantBuild.Name = "txtInstantBuild";
        this.txtInstantBuild.Size = new Size(60, 13);
        this.txtInstantBuild.TabIndex = 76;
        this.txtInstantBuild.Text = "0";
        this.txtInstantBuild.TextAlign = HorizontalAlignment.Center;
        this.label2.AutoSize = true;
        this.label2.Dock = DockStyle.Left;
        this.label2.Location = new Point(0, 0);
        this.label2.Margin = new Padding(3);
        this.label2.Name = "label2";
        this.label2.Size = new Size(97, 13);
        this.label2.TabIndex = 104;
        this.label2.Text = "Instant Build Points";
        this.panel5.Controls.Add(this.txtNumInstantBuild);
        this.panel5.Controls.Add(this.label3);
        this.panel5.Location = new Point(3, 38);
        this.panel5.Margin = new Padding(3, 10, 3, 3);
        this.panel5.Name = "panel5";
        this.panel5.Size = new Size(200, 15);
        this.panel5.TabIndex = 122;
        this.txtNumInstantBuild.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtNumInstantBuild.BorderStyle = BorderStyle.None;
        this.txtNumInstantBuild.Dock = DockStyle.Right;
        this.txtNumInstantBuild.ForeColor = Color.FromArgb(128 /*0x80*/, 255, 128 /*0x80*/);
        this.txtNumInstantBuild.Location = new Point(140, 0);
        this.txtNumInstantBuild.Name = "txtNumInstantBuild";
        this.txtNumInstantBuild.Size = new Size(60, 13);
        this.txtNumInstantBuild.TabIndex = 77;
        this.txtNumInstantBuild.Text = "1";
        this.txtNumInstantBuild.TextAlign = HorizontalAlignment.Center;
        this.label3.AutoSize = true;
        this.label3.Dock = DockStyle.Left;
        this.label3.Location = new Point(0, 0);
        this.label3.Margin = new Padding(3);
        this.label3.Name = "label3";
        this.label3.Size = new Size(123, 13);
        this.label3.TabIndex = 104;
        this.label3.Text = "Number of Ships to Build";
        this.chkIncludeParasites.AutoSize = true;
        this.chkIncludeParasites.Location = new Point(6, 62);
        this.chkIncludeParasites.Margin = new Padding(6, 6, 3, 3);
        this.chkIncludeParasites.Name = "chkIncludeParasites";
        this.chkIncludeParasites.Size = new Size(153, 17);
        this.chkIncludeParasites.TabIndex = 135;
        this.chkIncludeParasites.Text = "Include Assigned Parasites";
        this.chkIncludeParasites.UseVisualStyleBackColor = true;
        this.chkIncludeGround.AutoSize = true;
        this.chkIncludeGround.Location = new Point(6, 88);
        this.chkIncludeGround.Margin = new Padding(6, 6, 3, 3);
        this.chkIncludeGround.Name = "chkIncludeGround";
        this.chkIncludeGround.Size = new Size(159, 17);
        this.chkIncludeGround.TabIndex = 137;
        this.chkIncludeGround.Text = "Include Assigned Templates";
        this.chkIncludeGround.UseVisualStyleBackColor = true;
        this.chkEnterNames.AutoSize = true;
        this.chkEnterNames.Location = new Point(6, 114);
        this.chkEnterNames.Margin = new Padding(6, 6, 3, 3);
        this.chkEnterNames.Name = "chkEnterNames";
        this.chkEnterNames.Size = new Size(159, 17);
        this.chkEnterNames.TabIndex = 136;
        this.chkEnterNames.Text = "Enter Ship Names                ";
        this.chkEnterNames.UseVisualStyleBackColor = true;
        this.rdoFleetIB.AutoSize = true;
        this.rdoFleetIB.Checked = true;
        this.rdoFleetIB.Location = new Point(6, 137);
        this.rdoFleetIB.Margin = new Padding(6, 3, 3, 3);
        this.rdoFleetIB.Name = "rdoFleetIB";
        this.rdoFleetIB.Size = new Size(48 /*0x30*/, 17);
        this.rdoFleetIB.TabIndex = 133;
        this.rdoFleetIB.TabStop = true;
        this.rdoFleetIB.Text = "Fleet";
        this.rdoFleetIB.UseVisualStyleBackColor = true;
        this.rdoFleetIB.CheckedChanged += this.rdoFleetIB_CheckedChanged;
        this.rdoIBAdmin.AutoSize = true;
        this.rdoIBAdmin.Location = new Point(60, 137);
        this.rdoIBAdmin.Name = "rdoIBAdmin";
        this.rdoIBAdmin.Size = new Size(104, 17);
        this.rdoIBAdmin.TabIndex = 132;
        this.rdoIBAdmin.Text = "Admin Command";
        this.rdoIBAdmin.UseVisualStyleBackColor = true;
        this.cboAdminCommands.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cboAdminCommands.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cboAdminCommands.FormattingEnabled = true;
        this.cboAdminCommands.Location = new Point(3, 163);
        this.cboAdminCommands.Margin = new Padding(3, 6, 3, 0);
        this.cboAdminCommands.Name = "cboAdminCommands";
        this.cboAdminCommands.Size = new Size(203, 21);
        this.cboAdminCommands.TabIndex = 138;
        this.cboAdminCommands.Visible = false;
        this.cboFleets.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cboFleets.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cboFleets.FormattingEnabled = true;
        this.cboFleets.Location = new Point(3, 190);
        this.cboFleets.Margin = new Padding(3, 6, 3, 0);
        this.cboFleets.Name = "cboFleets";
        this.cboFleets.Size = new Size(203, 21);
        this.cboFleets.TabIndex = 78;
        this.cboFleets.SelectedIndexChanged += this.cboFleets_SelectedIndexChanged;
        this.chkMothership.AutoSize = true;
        this.chkMothership.Location = new Point(6, 231);
        this.chkMothership.Margin = new Padding(6, 20, 3, 3);
        this.chkMothership.Name = "chkMothership";
        this.chkMothership.Size = new Size(124, 17);
        this.chkMothership.TabIndex = 130;
        this.chkMothership.Text = "Assign to Mothership";
        this.chkMothership.UseVisualStyleBackColor = true;
        this.chkMothership.CheckedChanged += this.chkAssignSquadron_CheckedChanged;
        this.cboMothershipClass.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cboMothershipClass.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cboMothershipClass.FormattingEnabled = true;
        this.cboMothershipClass.Location = new Point(3, 254);
        this.cboMothershipClass.Margin = new Padding(3, 3, 3, 0);
        this.cboMothershipClass.Name = "cboMothershipClass";
        this.cboMothershipClass.Size = new Size(203, 21);
        this.cboMothershipClass.TabIndex = 132;
        this.cboMothershipClass.SelectedIndexChanged += this.cboMothershipClass_SelectedIndexChanged;
        this.cboMothership.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cboMothership.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cboMothership.FormattingEnabled = true;
        this.cboMothership.Location = new Point(3, 278);
        this.cboMothership.Margin = new Padding(3, 3, 3, 0);
        this.cboMothership.Name = "cboMothership";
        this.cboMothership.Size = new Size(203, 21);
        this.cboMothership.TabIndex = 131;
        this.cboMothership.SelectedIndexChanged += this.cboMothership_SelectedIndexChanged;
        this.chkAssignSquadron.AutoSize = true;
        this.chkAssignSquadron.Location = new Point(6, 319);
        this.chkAssignSquadron.Margin = new Padding(6, 20, 3, 3);
        this.chkAssignSquadron.Name = "chkAssignSquadron";
        this.chkAssignSquadron.Size = new Size(118, 17);
        this.chkAssignSquadron.TabIndex = 133;
        this.chkAssignSquadron.Text = "Assign to Squadron";
        this.chkAssignSquadron.UseVisualStyleBackColor = true;
        this.chkAssignSquadron.CheckedChanged += this.chkAssignSquadron_CheckedChanged;
        this.cboSquadron.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cboSquadron.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cboSquadron.FormattingEnabled = true;
        this.cboSquadron.Location = new Point(3, 342);
        this.cboSquadron.Margin = new Padding(3, 3, 3, 0);
        this.cboSquadron.Name = "cboSquadron";
        this.cboSquadron.Size = new Size(203, 21);
        this.cboSquadron.TabIndex = 134;
        this.cmdInstantBuild.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdInstantBuild.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdInstantBuild.Location = new Point(59, 379);
        this.cmdInstantBuild.Margin = new Padding(59, 16 /*0x10*/, 0, 0);
        this.cmdInstantBuild.Name = "cmdInstantBuild";
        this.cmdInstantBuild.Size = new Size(96 /*0x60*/, 30);
        this.cmdInstantBuild.TabIndex = 79;
        this.cmdInstantBuild.Tag = "1200";
        this.cmdInstantBuild.Text = "Instant Build";
        this.cmdInstantBuild.UseVisualStyleBackColor = false;
        this.cmdInstantBuild.Click += this.cmdInstantBuild_Click;
        this.lstvCrew.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.lstvCrew.BorderStyle = BorderStyle.FixedSingle;
        this.lstvCrew.Columns.AddRange(new ColumnHeader[2]
        {
            this.columnHeader_26,
            this.columnHeader_27
        });
        this.lstvCrew.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.lstvCrew.FullRowSelect = true;
        this.lstvCrew.HeaderStyle = ColumnHeaderStyle.None;
        this.lstvCrew.HideSelection = false;
        this.lstvCrew.Location = new Point(755, 100);
        this.lstvCrew.Margin = new Padding(4, 3, 3, 3);
        this.lstvCrew.Name = "lstvCrew";
        this.lstvCrew.Size = new Size(350, 203);
        this.lstvCrew.TabIndex = 119;
        this.lstvCrew.UseCompatibleStateImageBehavior = false;
        this.lstvCrew.View = View.Details;
        this.columnHeader_26.Width = 250;
        this.columnHeader_27.TextAlign = HorizontalAlignment.Center;
        this.chkUseAlienTech.AutoSize = true;
        this.chkUseAlienTech.Location = new Point(13, 724);
        this.chkUseAlienTech.Name = "chkUseAlienTech";
        this.chkUseAlienTech.Padding = new Padding(5, 0, 0, 0);
        this.chkUseAlienTech.Size = new Size(104, 17);
        this.chkUseAlienTech.TabIndex = 80 /*0x50*/;
        this.chkUseAlienTech.Text = "Use Alien Tech";
        this.chkUseAlienTech.TextAlign = ContentAlignment.MiddleRight;
        this.chkUseAlienTech.UseVisualStyleBackColor = true;
        this.flowLayoutPanel9.BorderStyle = BorderStyle.FixedSingle;
        this.flowLayoutPanel9.Controls.Add(this.panel12);
        this.flowLayoutPanel9.Controls.Add(this.panel2);
        this.flowLayoutPanel9.Controls.Add(this.panel3);
        this.flowLayoutPanel9.Controls.Add(this.panel11);
        this.flowLayoutPanel9.Controls.Add(this.panel8);
        this.flowLayoutPanel9.Controls.Add(this.panel13);
        this.flowLayoutPanel9.Controls.Add(this.panel6);
        this.flowLayoutPanel9.Controls.Add(this.label14);
        this.flowLayoutPanel9.Location = new Point(6, 8);
        this.flowLayoutPanel9.Name = "flowLayoutPanel9";
        this.flowLayoutPanel9.Size = new Size(212, 219);
        this.flowLayoutPanel9.TabIndex = 87;
        this.panel12.Controls.Add(this.txtPriority);
        this.panel12.Controls.Add(this.label16);
        this.panel12.Location = new Point(3, 3);
        this.panel12.Name = "panel12";
        this.panel12.Size = new Size(200, 15);
        this.panel12.TabIndex = 121;
        this.txtPriority.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtPriority.BorderStyle = BorderStyle.None;
        this.txtPriority.Dock = DockStyle.Right;
        this.txtPriority.ForeColor = Color.FromArgb(128 /*0x80*/, 255, 128 /*0x80*/);
        this.txtPriority.Location = new Point(140, 0);
        this.txtPriority.Name = "txtPriority";
        this.txtPriority.Size = new Size(60, 13);
        this.txtPriority.TabIndex = 70;
        this.txtPriority.Text = "1";
        this.txtPriority.TextAlign = HorizontalAlignment.Center;
        this.txtPriority.TextChanged += this.txtPriority_TextChanged;
        this.label16.AutoSize = true;
        this.label16.Dock = DockStyle.Left;
        this.label16.Location = new Point(0, 0);
        this.label16.Margin = new Padding(3);
        this.label16.Name = "label16";
        this.label16.Size = new Size(97, 13);
        this.label16.TabIndex = 104;
        this.label16.Text = "Commander Priority";
        this.panel2.Controls.Add(this.txtPDProtectionPriority);
        this.panel2.Controls.Add(this.label13);
        this.panel2.Location = new Point(3, 24);
        this.panel2.Name = "panel2";
        this.panel2.Size = new Size(200, 15);
        this.panel2.TabIndex = 126;
        this.txtPDProtectionPriority.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtPDProtectionPriority.BorderStyle = BorderStyle.None;
        this.txtPDProtectionPriority.Dock = DockStyle.Right;
        this.txtPDProtectionPriority.ForeColor = Color.FromArgb(128 /*0x80*/, 255, 128 /*0x80*/);
        this.txtPDProtectionPriority.Location = new Point(140, 0);
        this.txtPDProtectionPriority.Name = "txtPDProtectionPriority";
        this.txtPDProtectionPriority.Size = new Size(60, 13);
        this.txtPDProtectionPriority.TabIndex = 75;
        this.txtPDProtectionPriority.Text = "1";
        this.txtPDProtectionPriority.TextAlign = HorizontalAlignment.Center;
        this.txtPDProtectionPriority.TextChanged += this.txtPDProtectionPriority_TextChanged;
        this.label13.AutoSize = true;
        this.label13.Dock = DockStyle.Left;
        this.label13.Location = new Point(0, 0);
        this.label13.Margin = new Padding(3);
        this.label13.Name = "label13";
        this.label13.Size = new Size(107, 13);
        this.label13.TabIndex = 104;
        this.label13.Text = "PD Protection Priority";
        this.panel3.Controls.Add(this.txtMaintPriority);
        this.panel3.Controls.Add(this.label1);
        this.panel3.Location = new Point(3, 45);
        this.panel3.Name = "panel3";
        this.panel3.Size = new Size(200, 15);
        this.panel3.TabIndex = 123;
        this.txtMaintPriority.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtMaintPriority.BorderStyle = BorderStyle.None;
        this.txtMaintPriority.Dock = DockStyle.Right;
        this.txtMaintPriority.ForeColor = Color.FromArgb(128 /*0x80*/, 255, 128 /*0x80*/);
        this.txtMaintPriority.Location = new Point(140, 0);
        this.txtMaintPriority.Name = "txtMaintPriority";
        this.txtMaintPriority.Size = new Size(60, 13);
        this.txtMaintPriority.TabIndex = 71;
        this.txtMaintPriority.Text = "1";
        this.txtMaintPriority.TextAlign = HorizontalAlignment.Center;
        this.txtMaintPriority.TextChanged += this.txtMaintPriority_TextChanged;
        this.label1.AutoSize = true;
        this.label1.Dock = DockStyle.Left;
        this.label1.Location = new Point(0, 0);
        this.label1.Margin = new Padding(3);
        this.label1.Name = "label1";
        this.label1.Size = new Size(103, 13);
        this.label1.TabIndex = 104;
        this.label1.Text = "Maintenance Priority";
        this.panel11.Controls.Add(this.txtFuelPriority);
        this.panel11.Controls.Add(this.label15);
        this.panel11.Location = new Point(3, 66);
        this.panel11.Name = "panel11";
        this.panel11.Size = new Size(200, 15);
        this.panel11.TabIndex = 120;
        this.txtFuelPriority.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtFuelPriority.BorderStyle = BorderStyle.None;
        this.txtFuelPriority.Dock = DockStyle.Right;
        this.txtFuelPriority.ForeColor = Color.FromArgb(128 /*0x80*/, 255, 128 /*0x80*/);
        this.txtFuelPriority.Location = new Point(140, 0);
        this.txtFuelPriority.Name = "txtFuelPriority";
        this.txtFuelPriority.Size = new Size(60, 13);
        this.txtFuelPriority.TabIndex = 74;
        this.txtFuelPriority.Text = "1";
        this.txtFuelPriority.TextAlign = HorizontalAlignment.Center;
        this.txtFuelPriority.TextChanged += this.txtFuelPriority_TextChanged;
        this.label15.AutoSize = true;
        this.label15.Dock = DockStyle.Left;
        this.label15.Location = new Point(0, 0);
        this.label15.Margin = new Padding(3);
        this.label15.Name = "label15";
        this.label15.Size = new Size(72, 13);
        this.label15.TabIndex = 104;
        this.label15.Text = "Refuel Priority";
        this.panel8.Controls.Add(this.txtSupplyPriority);
        this.panel8.Controls.Add(this.label8);
        this.panel8.Location = new Point(3, 87);
        this.panel8.Name = "panel8";
        this.panel8.Size = new Size(200, 15);
        this.panel8.TabIndex = 125;
        this.txtSupplyPriority.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtSupplyPriority.BorderStyle = BorderStyle.None;
        this.txtSupplyPriority.Dock = DockStyle.Right;
        this.txtSupplyPriority.ForeColor = Color.FromArgb(128 /*0x80*/, 255, 128 /*0x80*/);
        this.txtSupplyPriority.Location = new Point(140, 0);
        this.txtSupplyPriority.Name = "txtSupplyPriority";
        this.txtSupplyPriority.Size = new Size(60, 13);
        this.txtSupplyPriority.TabIndex = 75;
        this.txtSupplyPriority.Text = "1";
        this.txtSupplyPriority.TextAlign = HorizontalAlignment.Center;
        this.txtSupplyPriority.TextChanged += this.txtSupplyPriority_TextChanged;
        this.label8.AutoSize = true;
        this.label8.Dock = DockStyle.Left;
        this.label8.Location = new Point(0, 0);
        this.label8.Margin = new Padding(3);
        this.label8.Name = "label8";
        this.label8.Size = new Size(85, 13);
        this.label8.TabIndex = 104;
        this.label8.Text = "Resupply Priority";
        this.panel13.Controls.Add(this.txtMinFuel);
        this.panel13.Controls.Add(this.label17);
        this.panel13.Location = new Point(3, 108);
        this.panel13.Name = "panel13";
        this.panel13.Size = new Size(200, 15);
        this.panel13.TabIndex = 122;
        this.txtMinFuel.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtMinFuel.BorderStyle = BorderStyle.None;
        this.txtMinFuel.Dock = DockStyle.Right;
        this.txtMinFuel.ForeColor = Color.FromArgb(128 /*0x80*/, 255, 128 /*0x80*/);
        this.txtMinFuel.Location = new Point(140, 0);
        this.txtMinFuel.Name = "txtMinFuel";
        this.txtMinFuel.Size = new Size(60, 13);
        this.txtMinFuel.TabIndex = 72;
        this.txtMinFuel.Text = "0";
        this.txtMinFuel.TextAlign = HorizontalAlignment.Center;
        this.txtMinFuel.TextChanged += this.txtMinFuel_TextChanged;
        this.label17.AutoSize = true;
        this.label17.Dock = DockStyle.Left;
        this.label17.Location = new Point(0, 0);
        this.label17.Margin = new Padding(3);
        this.label17.Name = "label17";
        this.label17.Size = new Size(71, 13);
        this.label17.TabIndex = 104;
        this.label17.Text = "Minimum Fuel";
        this.panel6.Controls.Add(this.txtMinSupplies);
        this.panel6.Controls.Add(this.label7);
        this.panel6.Location = new Point(3, 129);
        this.panel6.Name = "panel6";
        this.panel6.Size = new Size(200, 15);
        this.panel6.TabIndex = 124;
        this.txtMinSupplies.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtMinSupplies.BorderStyle = BorderStyle.None;
        this.txtMinSupplies.Dock = DockStyle.Right;
        this.txtMinSupplies.ForeColor = Color.FromArgb(128 /*0x80*/, 255, 128 /*0x80*/);
        this.txtMinSupplies.Location = new Point(140, 0);
        this.txtMinSupplies.Name = "txtMinSupplies";
        this.txtMinSupplies.Size = new Size(60, 13);
        this.txtMinSupplies.TabIndex = 73;
        this.txtMinSupplies.Text = "0";
        this.txtMinSupplies.TextAlign = HorizontalAlignment.Center;
        this.txtMinSupplies.TextChanged += this.txtMinSupplies_TextChanged;
        this.label7.AutoSize = true;
        this.label7.Dock = DockStyle.Left;
        this.label7.Location = new Point(0, 0);
        this.label7.Margin = new Padding(3);
        this.label7.Name = "label7";
        this.label7.Size = new Size(91, 13);
        this.label7.TabIndex = 104;
        this.label7.Text = "Minimum Supplies";
        this.label14.AutoSize = true;
        this.label14.Dock = DockStyle.Left;
        this.label14.Location = new Point(3, 159);
        this.label14.Margin = new Padding(3, 12, 3, 3);
        this.label14.Name = "label14";
        this.label14.Size = new Size(118, 13);
        this.label14.TabIndex = 127;
        this.label14.Text = "The Highest Priority is 1";
        this.txtDetails.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtDetails.BorderStyle = BorderStyle.FixedSingle;
        this.txtDetails.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
        this.txtDetails.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.txtDetails.Location = new Point(755, 309);
        this.txtDetails.Margin = new Padding(0, 0, 3, 3);
        this.txtDetails.Multiline = true;
        this.txtDetails.Name = "txtDetails";
        this.txtDetails.Size = new Size(350, 330);
        this.txtDetails.TabIndex = 78;
        this.txtDetails.Text = "Class Notes";
        this.tabPage1.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.tabPage1.Controls.Add(this.lstvComponentTechRequired);
        this.tabPage1.Controls.Add(this.flowLayoutPanel15);
        this.tabPage1.Controls.Add(this.txtClassTemplate);
        this.tabPage1.Controls.Add(this.lstvTemplateTech);
        this.tabPage1.Controls.Add(this.lstvTemplateComponents);
        this.tabPage1.Controls.Add(this.tvTemplateList);
        this.tabPage1.Location = new Point(4, 22);
        this.tabPage1.Name = "tabPage1";
        this.tabPage1.Padding = new Padding(3);
        this.tabPage1.Size = new Size(1624, 836);
        this.tabPage1.TabIndex = 6;
        this.tabPage1.Text = "Class Templates";
        this.lstvComponentTechRequired.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.lstvComponentTechRequired.BorderStyle = BorderStyle.FixedSingle;
        this.lstvComponentTechRequired.Columns.AddRange(new ColumnHeader[2]
        {
            this.columnHeader_60,
            this.columnHeader_61
        });
        this.lstvComponentTechRequired.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.lstvComponentTechRequired.FullRowSelect = true;
        this.lstvComponentTechRequired.HeaderStyle = ColumnHeaderStyle.None;
        this.lstvComponentTechRequired.HideSelection = false;
        this.lstvComponentTechRequired.Location = new Point(751, 567);
        this.lstvComponentTechRequired.Name = "lstvComponentTechRequired";
        this.lstvComponentTechRequired.Size = new Size(393, 235);
        this.lstvComponentTechRequired.TabIndex = 83;
        this.lstvComponentTechRequired.UseCompatibleStateImageBehavior = false;
        this.lstvComponentTechRequired.View = View.Details;
        this.columnHeader_60.Width = 300;
        this.columnHeader_61.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_61.Width = 70;
        this.flowLayoutPanel15.Controls.Add(this.cmdCreateClass);
        this.flowLayoutPanel15.Controls.Add(this.rdoAvailableTech);
        this.flowLayoutPanel15.Controls.Add(this.rdoResearchRequired);
        this.flowLayoutPanel15.Controls.Add(this.cmdInstantComp);
        this.flowLayoutPanel15.Controls.Add(this.cmdInstantTech);
        this.flowLayoutPanel15.Controls.Add(this.lblInstant);
        this.flowLayoutPanel15.Controls.Add(this.lblStartingTechPoints);
        this.flowLayoutPanel15.Controls.Add(this.cmdRenameTemplate);
        this.flowLayoutPanel15.Controls.Add(this.cmdDeleteTemplate);
        this.flowLayoutPanel15.Location = new Point(6, 804);
        this.flowLayoutPanel15.Name = "flowLayoutPanel15";
        this.flowLayoutPanel15.Size = new Size(1138, 29);
        this.flowLayoutPanel15.TabIndex = 82;
        this.cmdCreateClass.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdCreateClass.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdCreateClass.Location = new Point(0, 0);
        this.cmdCreateClass.Margin = new Padding(0);
        this.cmdCreateClass.Name = "cmdCreateClass";
        this.cmdCreateClass.Size = new Size(96 /*0x60*/, 30);
        this.cmdCreateClass.TabIndex = 81;
        this.cmdCreateClass.Tag = "1200";
        this.cmdCreateClass.Text = "Create Class";
        this.cmdCreateClass.UseVisualStyleBackColor = false;
        this.cmdCreateClass.Click += this.cmdCreateClass_Click;
        this.rdoAvailableTech.AutoSize = true;
        this.rdoAvailableTech.Location = new Point(99, 3);
        this.rdoAvailableTech.Name = "rdoAvailableTech";
        this.rdoAvailableTech.Padding = new Padding(12, 3, 0, 0);
        this.rdoAvailableTech.Size = new Size(130, 20);
        this.rdoAvailableTech.TabIndex = 83;
        this.rdoAvailableTech.Text = "Use Available Tech";
        this.rdoAvailableTech.UseVisualStyleBackColor = true;
        this.rdoResearchRequired.AutoSize = true;
        this.rdoResearchRequired.Checked = true;
        this.rdoResearchRequired.Location = new Point(235, 3);
        this.rdoResearchRequired.Margin = new Padding(3, 3, 15, 3);
        this.rdoResearchRequired.Name = "rdoResearchRequired";
        this.rdoResearchRequired.Padding = new Padding(6, 3, 0, 0);
        this.rdoResearchRequired.Size = new Size(151, 20);
        this.rdoResearchRequired.TabIndex = 84;
        this.rdoResearchRequired.TabStop = true;
        this.rdoResearchRequired.Text = "Research Required Tech";
        this.rdoResearchRequired.UseVisualStyleBackColor = true;
        this.cmdInstantComp.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdInstantComp.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdInstantComp.Location = new Point(401, 0);
        this.cmdInstantComp.Margin = new Padding(0);
        this.cmdInstantComp.Name = "cmdInstantComp";
        this.cmdInstantComp.Size = new Size(96 /*0x60*/, 30);
        this.cmdInstantComp.TabIndex = 84;
        this.cmdInstantComp.Tag = "1200";
        this.cmdInstantComp.Text = "Instant Comp";
        this.cmdInstantComp.UseVisualStyleBackColor = false;
        this.cmdInstantComp.Click += this.cmdInstantComp_Click;
        this.cmdInstantTech.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdInstantTech.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdInstantTech.Location = new Point(497, 0);
        this.cmdInstantTech.Margin = new Padding(0);
        this.cmdInstantTech.Name = "cmdInstantTech";
        this.cmdInstantTech.Size = new Size(96 /*0x60*/, 30);
        this.cmdInstantTech.TabIndex = 85;
        this.cmdInstantTech.Tag = "1200";
        this.cmdInstantTech.Text = "Instant Path";
        this.cmdInstantTech.UseVisualStyleBackColor = false;
        this.cmdInstantTech.Click += this.cmdInstantTech_Click;
        this.lblInstant.AutoSize = true;
        this.lblInstant.Location = new Point(605, 8);
        this.lblInstant.Margin = new Padding(12, 8, 3, 0);
        this.lblInstant.Name = "lblInstant";
        this.lblInstant.Size = new Size(120, 13);
        this.lblInstant.TabIndex = 142;
        this.lblInstant.Text = "Instant Research Points";
        this.lblStartingTechPoints.AutoSize = true;
        this.lblStartingTechPoints.ForeColor = Color.FromArgb(128 /*0x80*/, 255, 128 /*0x80*/);
        this.lblStartingTechPoints.Location = new Point(728, 8);
        this.lblStartingTechPoints.Margin = new Padding(0, 8, 12, 0);
        this.lblStartingTechPoints.Name = "lblStartingTechPoints";
        this.lblStartingTechPoints.Size = new Size(43, 13);
        this.lblStartingTechPoints.TabIndex = 143;
        this.lblStartingTechPoints.Text = "500000";
        this.lblStartingTechPoints.TextAlign = ContentAlignment.MiddleLeft;
        this.cmdRenameTemplate.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdRenameTemplate.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdRenameTemplate.Location = new Point(783, 0);
        this.cmdRenameTemplate.Margin = new Padding(0);
        this.cmdRenameTemplate.Name = "cmdRenameTemplate";
        this.cmdRenameTemplate.Size = new Size(96 /*0x60*/, 30);
        this.cmdRenameTemplate.TabIndex = 84;
        this.cmdRenameTemplate.Tag = "1200";
        this.cmdRenameTemplate.Text = "Rename Temp";
        this.cmdRenameTemplate.UseVisualStyleBackColor = false;
        this.cmdRenameTemplate.Click += this.cmdRenameTemplate_Click;
        this.cmdDeleteTemplate.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdDeleteTemplate.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdDeleteTemplate.Location = new Point(879, 0);
        this.cmdDeleteTemplate.Margin = new Padding(0);
        this.cmdDeleteTemplate.Name = "cmdDeleteTemplate";
        this.cmdDeleteTemplate.Size = new Size(96 /*0x60*/, 30);
        this.cmdDeleteTemplate.TabIndex = 144 /*0x90*/;
        this.cmdDeleteTemplate.Tag = "1200";
        this.cmdDeleteTemplate.Text = "Delete Template";
        this.cmdDeleteTemplate.UseVisualStyleBackColor = false;
        this.cmdDeleteTemplate.Click += this.cmdDeleteTemplate_Click;
        this.txtClassTemplate.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtClassTemplate.BorderStyle = BorderStyle.FixedSingle;
        this.txtClassTemplate.Font = new Font("Microsoft Sans Serif", 9f);
        this.txtClassTemplate.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.txtClassTemplate.Location = new Point(207, 8);
        this.txtClassTemplate.Margin = new Padding(0, 0, 3, 3);
        this.txtClassTemplate.Multiline = true;
        this.txtClassTemplate.Name = "txtClassTemplate";
        this.txtClassTemplate.Size = new Size(937, 57);
        this.txtClassTemplate.TabIndex = 80 /*0x50*/;
        this.lstvTemplateTech.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.lstvTemplateTech.BorderStyle = BorderStyle.FixedSingle;
        this.lstvTemplateTech.Columns.AddRange(new ColumnHeader[2]
        {
            this.columnHeader_57,
            this.columnHeader_58
        });
        this.lstvTemplateTech.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.lstvTemplateTech.FullRowSelect = true;
        this.lstvTemplateTech.HeaderStyle = ColumnHeaderStyle.None;
        this.lstvTemplateTech.HideSelection = false;
        this.lstvTemplateTech.Location = new Point(751, 71);
        this.lstvTemplateTech.Name = "lstvTemplateTech";
        this.lstvTemplateTech.Size = new Size(393, 493);
        this.lstvTemplateTech.TabIndex = 79;
        this.lstvTemplateTech.UseCompatibleStateImageBehavior = false;
        this.lstvTemplateTech.View = View.Details;
        this.lstvTemplateTech.SelectedIndexChanged += this.lstvTemplateTech_SelectedIndexChanged;
        this.columnHeader_57.Width = 300;
        this.columnHeader_58.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_58.Width = 70;
        this.lstvTemplateComponents.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.lstvTemplateComponents.BorderStyle = BorderStyle.FixedSingle;
        this.lstvTemplateComponents.Columns.AddRange(new ColumnHeader[4]
        {
            this.columnHeader_59,
            this.columnHeader_54,
            this.columnHeader_55,
            this.columnHeader_56
        });
        this.lstvTemplateComponents.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.lstvTemplateComponents.FullRowSelect = true;
        this.lstvTemplateComponents.HeaderStyle = ColumnHeaderStyle.None;
        this.lstvTemplateComponents.HideSelection = false;
        this.lstvTemplateComponents.Location = new Point(207, 71);
        this.lstvTemplateComponents.Name = "lstvTemplateComponents";
        this.lstvTemplateComponents.Size = new Size(538, 731);
        this.lstvTemplateComponents.TabIndex = 78;
        this.lstvTemplateComponents.UseCompatibleStateImageBehavior = false;
        this.lstvTemplateComponents.View = View.Details;
        this.lstvTemplateComponents.SelectedIndexChanged += this.lstvTemplateComponents_SelectedIndexChanged;
        this.columnHeader_59.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_54.Width = 300;
        this.columnHeader_55.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_55.Width = 70;
        this.columnHeader_56.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_56.Width = 70;
        this.tvTemplateList.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.tvTemplateList.BorderStyle = BorderStyle.FixedSingle;
        this.tvTemplateList.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.tvTemplateList.HideSelection = false;
        this.tvTemplateList.Location = new Point(6, 8);
        this.tvTemplateList.Margin = new Padding(3, 0, 0, 3);
        this.tvTemplateList.Name = "tvTemplateList";
        this.tvTemplateList.Size = new Size(198, 794);
        this.tvTemplateList.TabIndex = 38;
        this.tvTemplateList.AfterCollapse += this.tvTemplateList_AfterCollapse;
        this.tvTemplateList.AfterExpand += this.tvTemplateList_AfterExpand;
        this.tvTemplateList.AfterSelect += this.tvTemplateList_AfterSelect;
        this.tabPage2.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.tabPage2.Controls.Add(this.textBox1);
        this.tabPage2.Location = new Point(4, 22);
        this.tabPage2.Name = "tabPage2";
        this.tabPage2.Padding = new Padding(3);
        this.tabPage2.Size = new Size(1624, 836);
        this.tabPage2.TabIndex = 2;
        this.tabPage2.Text = "Glossary";
        this.textBox1.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.textBox1.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
        this.textBox1.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.textBox1.Location = new Point(6, 8);
        this.textBox1.Multiline = true;
        this.textBox1.Name = "textBox1";
        this.textBox1.Size = new Size(890, 675);
        this.textBox1.TabIndex = 0;
        this.textBox1.Text = componentResourceManager.GetString("textBox1.Text");
        this.chkShowCivilian.AutoSize = true;
        this.chkShowCivilian.Location = new Point(106, 0);
        this.chkShowCivilian.Margin = new Padding(0, 0, 3, 0);
        this.chkShowCivilian.Name = "chkShowCivilian";
        this.chkShowCivilian.Padding = new Padding(5, 0, 0, 0);
        this.chkShowCivilian.Size = new Size(64 /*0x40*/, 17);
        this.chkShowCivilian.TabIndex = 2;
        this.chkShowCivilian.Text = "Civilian";
        this.chkShowCivilian.TextAlign = ContentAlignment.MiddleRight;
        this.chkShowCivilian.UseVisualStyleBackColor = true;
        this.chkShowCivilian.Click += this.chkObsoleteComp_Click;
        this.tvClassList.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.tvClassList.BorderStyle = BorderStyle.FixedSingle;
        this.tvClassList.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.tvClassList.HideSelection = false;
        this.tvClassList.Location = new Point(3, 30);
        this.tvClassList.Margin = new Padding(3, 0, 0, 3);
        this.tvClassList.Name = "tvClassList";
        this.tvClassList.Size = new Size(198, 794);
        this.tvClassList.TabIndex = 37;
        this.tvClassList.AfterCollapse += this.tvClassList_AfterCollapse;
        this.tvClassList.AfterExpand += this.tvClassList_AfterExpand;
        this.tvClassList.AfterSelect += this.tvClassList_AfterSelect;
        this.cboRaces.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cboRaces.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cboRaces.FormattingEnabled = true;
        this.cboRaces.Location = new Point(3, 3);
        this.cboRaces.Margin = new Padding(3, 3, 3, 0);
        this.cboRaces.Name = "cboRaces";
        this.cboRaces.Size = new Size(198, 21);
        this.cboRaces.TabIndex = 1;
        this.cboRaces.SelectedIndexChanged += this.cboRaces_SelectedIndexChanged;
        this.chkShowObsoleteClasses.AutoSize = true;
        this.chkShowObsoleteClasses.Location = new Point(0, 0);
        this.chkShowObsoleteClasses.Margin = new Padding(0, 0, 3, 0);
        this.chkShowObsoleteClasses.Name = "chkShowObsoleteClasses";
        this.chkShowObsoleteClasses.Padding = new Padding(5, 0, 0, 0);
        this.chkShowObsoleteClasses.Size = new Size(101, 17);
        this.chkShowObsoleteClasses.TabIndex = 3;
        this.chkShowObsoleteClasses.Text = "Obsolete Class";
        this.chkShowObsoleteClasses.TextAlign = ContentAlignment.MiddleRight;
        this.chkShowObsoleteClasses.UseVisualStyleBackColor = true;
        this.chkShowObsoleteClasses.Click += this.chkObsoleteComp_Click;
        this.chkObsoleteComp.AutoSize = true;
        this.chkObsoleteComp.Location = new Point(0, 17);
        this.chkObsoleteComp.Margin = new Padding(0, 0, 3, 0);
        this.chkObsoleteComp.Name = "chkObsoleteComp";
        this.chkObsoleteComp.Padding = new Padding(5, 0, 0, 0);
        this.chkObsoleteComp.Size = new Size(103, 17);
        this.chkObsoleteComp.TabIndex = 38;
        this.chkObsoleteComp.Text = "Obsolete Comp";
        this.chkObsoleteComp.TextAlign = ContentAlignment.MiddleRight;
        this.chkObsoleteComp.UseVisualStyleBackColor = true;
        this.chkObsoleteComp.Click += this.chkObsoleteComp_Click;
        this.flowLayoutPanel3.Controls.Add(this.chkShowObsoleteClasses);
        this.flowLayoutPanel3.Controls.Add(this.chkObsoleteComp);
        this.flowLayoutPanel3.Controls.Add(this.chkShowCivilian);
        this.flowLayoutPanel3.Controls.Add(this.chkHullCategory);
        this.flowLayoutPanel3.FlowDirection = FlowDirection.TopDown;
        this.flowLayoutPanel3.Location = new Point(3, 825);
        this.flowLayoutPanel3.Name = "flowLayoutPanel3";
        this.flowLayoutPanel3.Size = new Size(198, 37);
        this.flowLayoutPanel3.TabIndex = 39;
        this.chkHullCategory.AutoSize = true;
        this.chkHullCategory.Checked = true;
        this.chkHullCategory.CheckState = CheckState.Checked;
        this.chkHullCategory.Location = new Point(106, 17);
        this.chkHullCategory.Margin = new Padding(0, 0, 3, 0);
        this.chkHullCategory.Name = "chkHullCategory";
        this.chkHullCategory.Padding = new Padding(5, 0, 0, 0);
        this.chkHullCategory.Size = new Size(94, 17);
        this.chkHullCategory.TabIndex = 39;
        this.chkHullCategory.Text = "Hull Category";
        this.chkHullCategory.TextAlign = ContentAlignment.MiddleRight;
        this.chkHullCategory.UseVisualStyleBackColor = true;
        this.chkHullCategory.Click += this.chkHullCategory_Click;
        this.button1.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.button1.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.button1.Location = new Point(3, 123);
        this.button1.Margin = new Padding(3, 6, 3, 3);
        this.button1.Name = "button1";
        this.button1.Size = new Size(96 /*0x60*/, 30);
        this.button1.TabIndex = 54;
        this.button1.Tag = "1200";
        this.button1.Text = "Names Text";
        this.button1.UseVisualStyleBackColor = false;
        this.button1.Click += this.button1_Click;
        this.AutoScaleDimensions = new SizeF(6f, 13f);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.ClientSize = new Size(1837, 861);
        this.Controls.Add(this.flowLayoutPanel3);
        this.Controls.Add(this.cboRaces);
        this.Controls.Add(this.tvClassList);
        this.Controls.Add(this.tabDesign);
        this.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.FormBorderStyle = FormBorderStyle.FixedSingle;
        this.KeyPreview = true;
        this.Name = "ClassDesign";
        this.Text = "Class Design";
        this.FormClosing += this.ClassDesign_FormClosing;
        this.Load += this.ClassDesign_Load;
        this.KeyDown += this.ClassDesign_KeyDown;
        this.tabDesign.ResumeLayout(false);
        this.ClassDesignTab.ResumeLayout(false);
        this.ClassDesignTab.PerformLayout();
        this.flpRaceOrClass.ResumeLayout(false);
        this.flpRaceOrClass.PerformLayout();
        this.flpToggles.ResumeLayout(false);
        this.flpToggles.PerformLayout();
        this.flpBands.ResumeLayout(false);
        this.flpBands.PerformLayout();
        this.flowLayoutPanelMembers.ResumeLayout(false);
        this.flowLayoutPanel5.ResumeLayout(false);
        this.flpMultiples.ResumeLayout(false);
        this.flpMultiples.PerformLayout();
        this.flowLayoutPanel1.ResumeLayout(false);
        this.flowLayoutPanel1.PerformLayout();
        this.flowLayoutPanel2.ResumeLayout(false);
        this.ShipsInClass.ResumeLayout(false);
        this.flowLayoutPanel16.ResumeLayout(false);
        this.flowLayoutPanel16.PerformLayout();
        this.flowLayoutPanel12.ResumeLayout(false);
        this.flowLayoutPanel8.ResumeLayout(false);
        this.ComponentsTab.ResumeLayout(false);
        this.flowLayoutPanel6.ResumeLayout(false);
        this.flowLayoutPanel6.PerformLayout();
        this.OrdnanceFightres.ResumeLayout(false);
        this.flowLayoutPanel14.ResumeLayout(false);
        this.flowLayoutPanel14.PerformLayout();
        this.flowLayoutPanel13.ResumeLayout(false);
        this.flowLayoutPanel13.PerformLayout();
        this.flowLayoutPanel4.ResumeLayout(false);
        this.flowLayoutPanel4.PerformLayout();
        this.panel4.ResumeLayout(false);
        this.panel4.PerformLayout();
        this.flowLayoutPanel17.ResumeLayout(false);
        this.flowLayoutPanel17.PerformLayout();
        this.flowLayoutPanel7.ResumeLayout(false);
        this.flowLayoutPanel7.PerformLayout();
        this.tabPage4.ResumeLayout(false);
        this.tabPage4.PerformLayout();
        this.flowLayoutPanel10.ResumeLayout(false);
        this.flowLayoutPanel10.PerformLayout();
        this.panel1.ResumeLayout(false);
        this.panel1.PerformLayout();
        this.flowLayoutPanel11.ResumeLayout(false);
        this.flowLayoutPanel11.PerformLayout();
        this.pnlInstantBuild.ResumeLayout(false);
        this.pnlInstantBuild.PerformLayout();
        this.panel7.ResumeLayout(false);
        this.panel7.PerformLayout();
        this.panel5.ResumeLayout(false);
        this.panel5.PerformLayout();
        this.flowLayoutPanel9.ResumeLayout(false);
        this.flowLayoutPanel9.PerformLayout();
        this.panel12.ResumeLayout(false);
        this.panel12.PerformLayout();
        this.panel2.ResumeLayout(false);
        this.panel2.PerformLayout();
        this.panel3.ResumeLayout(false);
        this.panel3.PerformLayout();
        this.panel11.ResumeLayout(false);
        this.panel11.PerformLayout();
        this.panel8.ResumeLayout(false);
        this.panel8.PerformLayout();
        this.panel13.ResumeLayout(false);
        this.panel13.PerformLayout();
        this.panel6.ResumeLayout(false);
        this.panel6.PerformLayout();
        this.tabPage1.ResumeLayout(false);
        this.tabPage1.PerformLayout();
        this.flowLayoutPanel15.ResumeLayout(false);
        this.flowLayoutPanel15.PerformLayout();
        this.tabPage2.ResumeLayout(false);
        this.tabPage2.PerformLayout();
        this.flowLayoutPanel3.ResumeLayout(false);
        this.flowLayoutPanel3.PerformLayout();
        this.ResumeLayout(false);
    }
}