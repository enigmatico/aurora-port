// Decompiled with JetBrains decompiler
// Type: GroundUnitDesign
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
public partial class GroundUnitDesign : Form
{
    private Dictionary<GroundUnitCapability, GroundUnitCapabilityDefinition> dictionary_0 = new Dictionary<GroundUnitCapability, GroundUnitCapabilityDefinition>();
    private Dictionary<AuroraTargetSelection, string> dictionary_1 = new Dictionary<AuroraTargetSelection, string>();
    private GClass0 gclass0_0;
    private GameRace gclass21_0;
    private GroundUnitBaseTypeData gclass96_0;
    private ArmourTypeData gclass97_0;
    private GroundComponentTypeDefinition gclass100_0;
    private GroundComponentTypeDefinition gclass100_1;
    private GroundComponentTypeDefinition gclass100_2;
    private GroundComponentTypeDefinition gclass100_3;
    private GroundUnitFormationTemplateData gclass102_0;
    private ShipComponent gclass230_0;
    private PopulationData gclass146_0;
    private bool bool_0;
    private IContainer icontainer_0;
    private ComboBox cboRaces;
    private Label label8;
    private TextBox txtBaseArmour;
    private TextBox txtBaseWeapon;
    private Label label9;
    private TextBox txtBeamTracking;
    private Label label4;
    private TextBox txtFCRange;
    private Label label1;
    private TabPage tabUnitSeries;
    private TextBox txtClassDisplay;
    private FlowLayoutPanel flowLayoutPanel4;
    private Button cmdCreateSeries;
    private Button cmdRenameSeries;
    private Button cmdDeleteSeries;
    private TreeView tvUnassigned;
    private TreeView tvUnitSeries;
    private TabPage tabPage1;
    private TextBox txtDistribution;
    private Label label2;
    private ComboBox cboTargetType;
    private ListView lstvSTOTargeting;
    private ColumnHeader columnHeader_0;
    private ColumnHeader columnHeader_1;
    private ColumnHeader columnHeader_2;
    private ColumnHeader columnHeader_3;
    private ColumnHeader columnHeader_4;
    private ColumnHeader columnHeader_5;
    private ColumnHeader columnHeader_6;
    private ColumnHeader columnHeader_7;
    private ColumnHeader columnHeader_8;
    private TabPage tabUnitClassDesign;
    private CheckBox chkNonCombatUnit;
    private Panel pnlBlank;
    private FlowLayoutPanel flowLayoutPanel6;
    private CheckBox chkPointDefence;
    private CheckBox chkECCM;
    private Label lblHQ;
    private TextBox txtHQCapacity;
    private ListView lstvSTO;
    private ColumnHeader columnHeader_9;
    private ColumnHeader columnHeader_10;
    private ColumnHeader columnHeader_11;
    private ColumnHeader columnHeader_12;
    private ColumnHeader columnHeader_13;
    private ColumnHeader columnHeader_14;
    private ColumnHeader columnHeader_15;
    private ColumnHeader columnHeader_16;
    private ComboBox cboQuaternary;
    private ComboBox cboTertiary;
    private ComboBox cboSecondary;
    private Label lblSecondary;
    private TextBox txtUnitName;
    private ListView lstvCapability;
    private ColumnHeader columnHeader_17;
    private ColumnHeader columnHeader_18;
    private ColumnHeader columnHeader_19;
    private ListView lstvPrimary;
    private ColumnHeader columnHeader_20;
    private ColumnHeader columnHeader_21;
    private ColumnHeader columnHeader_22;
    private ColumnHeader columnHeader_23;
    private ColumnHeader columnHeader_24;
    private ColumnHeader columnHeader_25;
    private ColumnHeader columnHeader_26;
    private ColumnHeader columnHeader_27;
    private ListView lstvArmourType;
    private ColumnHeader columnHeader_28;
    private ColumnHeader columnHeader_29;
    private ColumnHeader columnHeader_30;
    private ListView lstvBaseType;
    private ColumnHeader columnHeader_31;
    private ColumnHeader columnHeader_32;
    private ColumnHeader columnHeader_33;
    private ColumnHeader columnHeader_34;
    private ColumnHeader columnHeader_35;
    private ColumnHeader columnHeader_36;
    private ColumnHeader columnHeader_37;
    private TextBox txtUnitClass;
    private Button cmdCreate;
    private Button cmdInstant;
    private TabPage tabTemplates;
    private CheckBox chkShowCivilian;
    private FlowLayoutPanel flowLayoutPanel7;
    private Button cmdNewFormation;
    private Button cmdEditAmount;
    private Button cmdDeleteElement;
    private Button cmdRename;
    private Button cmdChangeRank;
    private Button cmdTemplateAsText;
    private Button cmdDeleteFormation;
    private CheckBox chkShowObsolete;
    private Button cmdObsolete;
    private ListView lstvTemplateUnitList;
    private ColumnHeader columnHeader_38;
    private ColumnHeader columnHeader_39;
    private ColumnHeader columnHeader_40;
    private ColumnHeader columnHeader_41;
    private ColumnHeader columnHeader_42;
    private ColumnHeader columnHeader_43;
    private ColumnHeader columnHeader_44;
    private TextBox txtSelectedClass;
    private Button cmdRenameUnit;
    private ListView lstvUnitClass;
    private ColumnHeader columnHeader_45;
    private ColumnHeader columnHeader_46;
    private ColumnHeader columnHeader_47;
    private ColumnHeader columnHeader_48;
    private ColumnHeader columnHeader_49;
    private ColumnHeader columnHeader_50;
    private ColumnHeader columnHeader_51;
    private ColumnHeader columnHeader_52;
    private ListView lstvTemplate;
    private ColumnHeader columnHeader_53;
    private ColumnHeader columnHeader_54;
    private ColumnHeader columnHeader_55;
    private ColumnHeader columnHeader_56;
    private ColumnHeader columnHeader_57;
    private ColumnHeader columnHeader_58;
    private ColumnHeader columnHeader_59;
    private ColumnHeader columnHeader_60;
    private ColumnHeader columnHeader_61;
    private FlowLayoutPanel flowLayoutPanel3;
    private Button cmdAdd;
    private TextBox txtNumUnit;
    private TabPage tabFormations;
    private FlowLayoutPanel flowLayoutPanel8;
    private TextBox txtFormationLocation;
    private Label label3;
    private TextBox txtReplacementTemplate;
    private Label label5;
    private TextBox txtPriority;
    private CheckBox chkUseForReplacements;
    private FlowLayoutPanel flpAssign;
    private Button cmdAssignSupport;
    private ComboBox cboAssign;
    private FlowLayoutPanel flowLayoutPanel5;
    private CheckBox chkLocation;
    private CheckBox chkPosition;
    private CheckBox chkElements;
    private CheckBox chkCivilian;
    private CheckBox chkShowSupport;
    private CheckBox chkPartial;
    private FlowLayoutPanel flowLayoutPanel2;
    private Button cmdRenameFormation;
    private Button cmdFieldPosition;
    private Button cmdRemoveParent;
    private Button cmdClearSupport;
    private Button cmdReplacementTemplate;
    private Button cmdDelete;
    private Button cmdTransferAlien;
    private Button cmdActive;
    private Button cmdAwardMedal;
    private Button cmdHierarchyMedal;
    private Button cmdChangeFormationRank;
    private Button cmdTotalForceText;
    private FlowLayoutPanel flowLayoutPanel1;
    private Button cmdSortCost;
    private Button cmdSortSize;
    private Button cmdSortUnits;
    private Button cmdSortName;
    private Button cmdSortTypeSize;
    private Button cmdSortTypeCost;
    private TextBox txtElementClass;
    private TextBox txtCmdr;
    private ListView lstvFormationUnitList;
    private ColumnHeader columnHeader_62;
    private ColumnHeader columnHeader_63;
    private ColumnHeader columnHeader_64;
    private ColumnHeader columnHeader_65;
    private ColumnHeader columnHeader_66;
    private ColumnHeader columnHeader_67;
    private ColumnHeader columnHeader_68;
    private ColumnHeader columnHeader_69;
    private ColumnHeader columnHeader_70;
    private ColumnHeader columnHeader_71;
    private ColumnHeader columnHeader_72;
    private ColumnHeader columnHeader_73;
    private ColumnHeader columnHeader_74;
    private TreeView tvFormations;
    private TabControl tabGround;
    private CheckBox chkCreationDate;
    private CheckBox chkShips;
    private Button cmdScrapFormation;
    private FlowLayoutPanel flowLayoutPanel9;
    private Button cmdUpdateTemp;
    private TabPage tabPage2;
    private FlowLayoutPanel flowLayoutPanel10;
    private Button cmdCreateOrg;
    private TreeView tvOrganization;
    private TreeView tvTemplateNodes;
    private Button cmdDeleteNode;
    private Label label6;
    private Button cmdConstructOrganization;
    private ComboBox cboPopulations;
    private Button cmdNodeFieldPosition;
    private Button cmdInstantOrg;
    private ListView lstvOrgSummary;
    private ColumnHeader columnHeader_75;
    private ColumnHeader columnHeader_76;
    private Button cmdCopyTemp;
    private CheckBox chkShowObsoleteTemplates;
    private FlowLayoutPanel flowLayoutPanel11;
    private Button cmdNonCombat;
    private Button button1;
    private Button cmdDNR;
    private CheckBox chkEnterNames;

    public GroundUnitDesign(GClass0 gclass0_1)
    {
        this.gclass0_0 = gclass0_1;
        this.InitializeComponent();
    }

    private void GroundUnitDesign_FormClosing(object sender, FormClosingEventArgs e)
    {
        try
        {
            this.gclass0_0.method_512(this.Name, this.Left, this.Top);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1828);
        }
    }

    private void GroundUnitDesign_Load(object sender, EventArgs e)
    {
        try
        {
            WindowPosition207 gclass207 = this.gclass0_0.method_513(this.Name);
            this.Left = gclass207.Left;
            this.Top = gclass207.Top;
            this.gclass0_0.bool_9 = true;
            this.bool_0 = true;
            if (this.gclass0_0.bool_8)
                this.cmdInstant.Visible = true;
            else
                this.cmdInstant.Visible = false;
            this.gclass0_0.method_577(this.cboRaces);
            this.method_16();
            this.gclass0_0.bool_9 = false;
            this.method_4();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1829);
        }
    }

    public TreeNode method_0(object object_0, TreeNode treeNode_0)
    {
        try
        {
            foreach (TreeNode node in treeNode_0.Nodes)
            {
                if (node.Tag != null && node.Tag.Equals(object_0))
                    return node;
                TreeNode treeNode = this.method_0(object_0, node);
                if (treeNode != null)
                    return treeNode;
            }

            return null;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1830);
            return null;
        }
    }

    public TreeNode method_1(object object_0)
    {
        try
        {
            TreeNode treeNode = null;
            foreach (TreeNode node in this.tvFormations.Nodes)
            {
                if (node.Tag != null && node.Tag.Equals(object_0))
                    return node;
                treeNode = this.method_0(object_0, node);
                if (treeNode != null)
                    break;
            }

            return treeNode;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1831);
            return null;
        }
    }

    private void method_2()
    {
        try
        {
            foreach (TreeNode node in this.tvFormations.Nodes)
                this.method_3(node);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1832);
        }
    }

    private void method_3(TreeNode treeNode_0)
    {
        try
        {
            treeNode_0.ForeColor = AuroraUtils.color_3;
            foreach (TreeNode node in treeNode_0.Nodes)
                this.method_3(node);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1833);
        }
    }

    private void method_4()
    {
        try
        {
            this.lstvFormationUnitList.Items.Clear();
            this.lstvUnitClass.Items.Clear();
            this.lstvTemplate.Items.Clear();
            this.lstvTemplateUnitList.Items.Clear();
            this.lstvPrimary.Items.Clear();
            this.lstvSTO.Items.Clear();
            this.lstvSTOTargeting.Items.Clear();
            this.txtUnitName.Text = "New Unit Class Name";
            this.txtUnitClass.Text = "";
            this.txtElementClass.Text = "";
            this.txtSelectedClass.Text = "";
            this.gclass21_0 = (GameRace)this.cboRaces.SelectedValue;
            this.gclass21_0.method_195(this.txtBaseArmour, this.txtBaseWeapon, this.txtBeamTracking, this.txtFCRange);
            this.gclass0_0.bool_9 = true;
            this.gclass21_0.method_196(this.lstvBaseType);
            this.gclass21_0.method_201(this.lstvSTO);
            this.gclass21_0.method_197(this.lstvCapability);
            this.gclass21_0.method_212(this.lstvUnitClass, this.chkShowObsolete.CheckState,
                this.chkShowCivilian.CheckState);
            this.gclass21_0.method_214(this.lstvTemplate, null, this.chkShowCivilian.CheckState, null,
                this.chkShowObsoleteTemplates.CheckState);
            this.gclass21_0.method_358(this.tvUnitSeries, this.tvUnassigned);
            this.gclass21_0.method_359(this.tvOrganization, this.tvTemplateNodes);
            this.gclass21_0.method_364(this.cboPopulations);
            this.gclass21_0.method_365(this.tvFormations, this.chkLocation.CheckState, this.chkPosition.CheckState,
                this.chkElements.CheckState, this.chkShowSupport.CheckState, this.chkCivilian.CheckState,
                this.chkCreationDate.CheckState, this.chkShips.CheckState);
            this.gclass21_0.method_357(this.lstvSTOTargeting);
            this.gclass0_0.bool_9 = false;
            this.method_15();
            this.method_7();
            if (!this.bool_0)
                this.gclass0_0.method_511(this.gclass21_0, this);
            this.bool_0 = false;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1834);
        }
    }

    private void method_5()
    {
        try
        {
            if (this.gclass0_0.bool_9 || this.tvFormations.SelectedNode == null ||
                this.tvFormations.SelectedNode.Tag == null)
                return;
            this.cmdActive.Visible = false;
            if (this.tvFormations.SelectedNode.Tag is GroundUnitFormationData)
            {
                // ISSUE: object of a compiler-generated type is created
                // ISSUE: variable of a compiler-generated type
                GroundUnitDesign.Class1053 class1053 = new GroundUnitDesign.Class1053();
                // ISSUE: reference to a compiler-generated field
                class1053.gclass103_0 = (GroundUnitFormationData)this.tvFormations.SelectedNode.Tag;
                // ISSUE: reference to a compiler-generated field
                if (class1053.gclass103_0 == null)
                    return;
                foreach (GroundUnitFormationData gclass103 in this.gclass0_0.FormationDictionary.Values)
                    gclass103.bool_1 = false;
                bool bool_7 = false;
                if (this.chkLocation.CheckState == CheckState.Checked)
                    bool_7 = true;
                // ISSUE: reference to a compiler-generated field
                class1053.gclass103_0.bool_1 = true;
                // ISSUE: reference to a compiler-generated field
                class1053.gclass103_0.method_30(this.lstvFormationUnitList, this.txtCmdr, this.txtFormationLocation,
                    this.txtReplacementTemplate, this.txtPriority, this.chkUseForReplacements, bool_7);
                this.cmdActive.Visible = true;
                // ISSUE: reference to a compiler-generated field
                if (class1053.gclass103_0.bActiveSensorsOn)
                    this.cmdActive.Text = "Active Off";
                else
                    this.cmdActive.Text = "Active On";
                // ISSUE: reference to a compiler-generated field
                if (this.chkLocation.CheckState != CheckState.Checked || class1053.gclass103_0.PopulationData == null)
                    return;
                // ISSUE: reference to a compiler-generated field
                if (class1053.gclass103_0.ElementList.Sum<GroundUnitFormationElement>(gclass39_0 =>
                        gclass39_0.UnitCount *
                        gclass39_0.GroundUnitClass.GroundUnitComponentList.Sum<GroundComponentTypeDefinition>(gclass100_0 => gclass100_0.FireDirection)) == 0)
                {
                    this.tvFormations.Height = 710;
                    this.flpAssign.Visible = false;
                    this.cboAssign.DataSource = null;
                    this.gclass146_0 = null;
                }
                else
                {
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    List<FCTShipData40> list1 = this.gclass0_0.FleetDictionary.Values
                        .SelectMany<FleetData, MoveOrder>(gclass85_0 => gclass85_0.MoveOrderDictionary.Values)
                        .Where<MoveOrder>(class1053.method_0)
                        .Select<MoveOrder, FleetData>(gclass139_0 => gclass139_0.Fleet)
                        .Where<FleetData>(class1053.method_1)
                        .SelectMany<FleetData, FCTShipData40>(gclass85_0 => gclass85_0.method_176())
                        .Where<FCTShipData40>(gclass40_0 => gclass40_0.gclass40_0 == null)
                        .OrderByDescending<FCTShipData40, Decimal>(gclass40_0 => gclass40_0.gclass22_0.decimal_14)
                        .ThenBy<FCTShipData40, string>(gclass40_0 => gclass40_0.gclass22_0.ClassName)
                        .ThenBy<FCTShipData40, string>(gclass40_0 => gclass40_0.ShipName).ToList<FCTShipData40>();
                    // ISSUE: reference to a compiler-generated method
                    List<GroundUnitFormationData> list2 = this.gclass0_0.FormationDictionary.Values.Where<GroundUnitFormationData>(class1053.method_2)
                        .ToList<GroundUnitFormationData>();
                    // ISSUE: reference to a compiler-generated method
                    List<FCTShipData40> list3 = list1.Where<FCTShipData40>(class1053.method_3).ToList<FCTShipData40>();
                    if (list3.Count > 0 || list2.Count > 0)
                    {
                        this.gclass0_0.method_594(this.lstvFormationUnitList, "");
                        foreach (GroundUnitFormationData gclass103 in list2)
                            this.gclass0_0.method_597(this.lstvFormationUnitList, "SUP", gclass103.method_45());
                        foreach (FCTShipData40 gclass40 in list3)
                            this.gclass0_0.method_597(this.lstvFormationUnitList, "SUP", gclass40.method_187());
                    }

                    if (list1.Count == 0)
                    {
                        this.tvFormations.Height = 710;
                        this.flpAssign.Visible = false;
                        this.cboAssign.DataSource = null;
                        this.gclass146_0 = null;
                    }
                    else
                    {
                        // ISSUE: reference to a compiler-generated field
                        if (this.flpAssign.Visible && this.gclass146_0 == class1053.gclass103_0.PopulationData)
                            return;
                        foreach (FCTShipData40 gclass40 in list1)
                            gclass40.ShipNameWithHullAndClass =
                                $"{gclass40.method_187()}  ({gclass40.gclass22_0.ClassName})";
                        this.tvFormations.Height = 675;
                        this.flpAssign.Visible = true;
                        // ISSUE: reference to a compiler-generated field
                        this.gclass146_0 = class1053.gclass103_0.PopulationData;
                        this.cboAssign.DisplayMember = "ShipNameWithHullAndClass";
                        this.cboAssign.DataSource = list1;
                    }
                }
            }
            else if (this.tvFormations.SelectedNode.Tag is PopulationData)
            {
                this.tvFormations.Height = 710;
                this.flpAssign.Visible = false;
                this.cboAssign.DataSource = null;
                this.gclass146_0 = null;
                ((PopulationData)this.tvFormations.SelectedNode.Tag)?.method_57(this.lstvFormationUnitList);
            }
            else
            {
                this.tvFormations.Height = 710;
                this.flpAssign.Visible = false;
                this.cboAssign.DataSource = null;
                this.gclass146_0 = null;
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1835);
        }
    }

    public void method_6(GameRace gclass21_1)
    {
        try
        {
            this.bool_0 = true;
            this.cboRaces.SelectedItem = gclass21_1;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1836);
        }
    }

    private void cboRaces_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass0_0.bool_9)
                return;
            this.method_4();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1837);
        }
    }

    private void method_7()
    {
        try
        {
            if (this.lstvArmourType.SelectedItems.Count == 0 || this.lstvPrimary.SelectedItems.Count == 0)
                return;
            int int_136 = 0;
            this.gclass97_0 = (ArmourTypeData)this.lstvArmourType.SelectedItems[0].Tag;
            this.gclass100_0 = (GroundComponentTypeDefinition)this.lstvPrimary.SelectedItems[0].Tag;
            if (this.gclass97_0 == null || this.gclass100_0 == null)
                return;
            if (this.lstvSTO.SelectedItems.Count > 0)
                this.gclass230_0 = (ShipComponent)this.lstvSTO.SelectedItems[0].Tag;
            if (this.gclass100_0.HQMaxSize > 0)
                int_136 = Convert.ToInt32(this.txtHQCapacity.Text);
            this.gclass100_1 = null;
            this.gclass100_2 = null;
            this.gclass100_3 = null;
            if (this.cboSecondary.Visible)
                this.gclass100_1 = (GroundComponentTypeDefinition)this.cboSecondary.SelectedItem;
            if (this.cboTertiary.Visible)
                this.gclass100_2 = (GroundComponentTypeDefinition)this.cboTertiary.SelectedItem;
            if (this.cboQuaternary.Visible)
                this.gclass100_3 = (GroundComponentTypeDefinition)this.cboQuaternary.SelectedItem;
            this.dictionary_0.Clear();
            foreach (ListViewItem selectedItem in this.lstvCapability.SelectedItems)
            {
                if (selectedItem.Tag != null)
                {
                    GroundUnitCapabilityDefinition tag = (GroundUnitCapabilityDefinition)selectedItem.Tag;
                    if (tag.CostMultiplier != 1M)
                        this.dictionary_0.Add(tag.GroundUnitCapability, tag);
                }
            }

            this.gclass0_0.method_448(this.gclass21_0, this.gclass96_0, this.gclass97_0, this.gclass100_0,
                this.gclass100_1, this.gclass100_2, this.gclass100_3, this.gclass230_0, this.dictionary_0,
                this.txtUnitName.Text, false, this.chkPointDefence.CheckState, this.chkECCM.CheckState,
                this.chkNonCombatUnit.CheckState, int_136).method_9(this.txtUnitClass, false, true);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1838);
        }
    }

    private void cmdInstant_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.txtUnitName.Text != "")
            {
                this.gclass0_0.gclass164_0.Name = this.txtUnitName.Text;
                this.gclass0_0.gclass101_0.ClassName = this.txtUnitName.Text;
            }

            this.gclass21_0.StartTechPoints -= this.gclass0_0.gclass164_0.int_4;
            if (this.gclass21_0 != null && this.gclass0_0.gclass101_0 != null)
                this.gclass0_0.method_476(this.gclass21_0);
            int num = (int)MessageBox.Show("Ground Unit Class has been created and automatically researched");
            this.method_8();
            this.gclass21_0.method_212(this.lstvUnitClass, this.chkShowObsolete.CheckState,
                this.chkShowCivilian.CheckState);
            this.method_7();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1839);
        }
    }

    private void method_8()
    {
        try
        {
            Dictionary<GroundUnitCapability, GroundUnitCapabilityDefinition> dictionary = new Dictionary<GroundUnitCapability, GroundUnitCapabilityDefinition>();
            foreach (KeyValuePair<GroundUnitCapability, GroundUnitCapabilityDefinition> keyValuePair in this.dictionary_0)
                dictionary.Add(keyValuePair.Key, keyValuePair.Value);
            this.dictionary_0 = dictionary;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3011);
        }
    }

    private void cmdCreate_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.txtUnitName.Text != "")
            {
                this.gclass0_0.gclass164_0.Name = this.txtUnitName.Text;
                this.gclass0_0.gclass101_0.ClassName = this.txtUnitName.Text;
            }

            this.gclass0_0.TechDataDictionary.Add(this.gclass0_0.gclass164_0.TechSystemID, this.gclass0_0.gclass164_0);
            this.gclass0_0.GroundUnitClassDictionary.Add(this.gclass0_0.gclass101_0.ClassID, this.gclass0_0.gclass101_0);
            int num = (int)MessageBox.Show(
                "Ground Unit Class Created. Research the new class on the Research tab of the economics window");
            this.method_8();
            this.method_7();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1840);
        }
    }

    private void cmdAdd_Click(object sender, EventArgs e)
    {
        try
        {
            // ISSUE: object of a compiler-generated type is created
            // ISSUE: variable of a compiler-generated type
            GroundUnitDesign.Class1054 class1054 = new GroundUnitDesign.Class1054();
            if (this.gclass21_0 == null || this.gclass102_0 == null || this.lstvUnitClass.SelectedItems.Count == 0)
                return;
            if (this.gclass102_0.method_2())
            {
                int num1 = (int)MessageBox.Show(
                    "Templates with associated ground construction tasks cannot be modified");
            }
            else
            {
                // ISSUE: reference to a compiler-generated field
                class1054.gclass101_0 = (GroundUnitClass101)this.lstvUnitClass.SelectedItems[0].Tag;
                // ISSUE: reference to a compiler-generated field
                if (class1054.gclass101_0 == null)
                {
                    int num2 = (int)MessageBox.Show("Please select a unit class");
                }
                else
                {
                    // ISSUE: reference to a compiler-generated method
                    GroundUnitFormationElement gclass39 = this.gclass102_0.FormationElementList.FirstOrDefault<GroundUnitFormationElement>(class1054.method_0);
                    if (gclass39 != null)
                    {
                        gclass39.UnitCount += Convert.ToInt32(this.txtNumUnit.Text);
                    }
                    else
                    {
                        // ISSUE: reference to a compiler-generated field
                        this.gclass102_0.method_12(class1054.gclass101_0, Convert.ToInt32(this.txtNumUnit.Text));
                    }

                    this.gclass21_0.method_214(this.lstvTemplate, null, this.chkShowCivilian.CheckState,
                        this.gclass102_0, this.chkShowObsoleteTemplates.CheckState);
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1841);
        }
    }

    private void cmdNewFormation_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass21_0 == null)
                return;
            GroundUnitFormationTemplateData gclass102_0 = this.gclass21_0.method_204();
            if (gclass102_0 == null)
                return;
            this.gclass21_0.method_214(this.lstvTemplate, null, this.chkShowCivilian.CheckState, gclass102_0,
                this.chkShowObsoleteTemplates.CheckState);
            this.gclass21_0.method_359(this.tvOrganization, this.tvTemplateNodes);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1842);
        }
    }

    private void lstvUnitClass_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            if (this.lstvUnitClass.SelectedItems.Count == 0)
                return;
            ((GroundUnitClass101)this.lstvUnitClass.SelectedItems[0].Tag)?.method_9(this.txtSelectedClass, true, true);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1843);
        }
    }

    private void lstvArmourType_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass0_0.bool_9 || this.lstvArmourType.SelectedItems.Count == 0)
                return;
            this.method_7();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1844);
        }
    }

    private void lstvPrimary_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass0_0.bool_9 || this.lstvPrimary.SelectedItems.Count == 0 ||
                !(this.lstvPrimary.SelectedItems[0].Tag is GroundComponentTypeDefinition))
                return;
            this.gclass100_0 = (GroundComponentTypeDefinition)this.lstvPrimary.SelectedItems[0].Tag;
            if (this.gclass100_0.STO > 0)
            {
                this.lstvSTO.Visible = true;
                this.chkPointDefence.Visible = true;
                this.chkECCM.Visible = true;
                this.lblHQ.Visible = false;
                this.txtHQCapacity.Visible = false;
            }
            else if (this.gclass100_0.HQMaxSize > 0)
            {
                this.lstvSTO.Visible = false;
                this.chkPointDefence.Visible = false;
                this.chkECCM.Visible = false;
                this.lblHQ.Visible = true;
                this.txtHQCapacity.Visible = true;
            }
            else
            {
                this.lstvSTO.Visible = false;
                this.chkPointDefence.Visible = false;
                this.chkECCM.Visible = false;
                this.lblHQ.Visible = false;
                this.txtHQCapacity.Visible = false;
            }

            this.method_7();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1845);
        }
    }

    private void cboSecondary_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass0_0.bool_9)
                return;
            this.method_7();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1846);
        }
    }

    private void cboTertiary_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass0_0.bool_9)
                return;
            this.method_7();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1847);
        }
    }

    private void cboQuaternary_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass0_0.bool_9)
                return;
            this.method_7();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1848);
        }
    }

    private void lstvCapability_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass0_0.bool_9)
                return;
            this.method_7();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1849);
        }
    }

    private void cmdRenameUnit_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.lstvUnitClass.SelectedItems.Count == 0)
                return;
            ListViewItem selectedItem = this.lstvUnitClass.SelectedItems[0];
            GroundUnitClass101 tag = (GroundUnitClass101)this.lstvUnitClass.SelectedItems[0].Tag;
            if (tag == null)
                return;
            this.gclass0_0.string_3 = "Enter New Unit Class Name";
            this.gclass0_0.string_4 = tag.ClassName;
            int num = (int)new MessageEntry(this.gclass0_0).ShowDialog();
            tag.ClassName = this.gclass0_0.string_4;
            selectedItem.SubItems[1].Text = tag.ClassName;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1850);
        }
    }

    private void lstvTemplate_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass0_0.bool_9 || this.lstvTemplate.SelectedItems.Count == 0)
                return;
            this.gclass102_0 = (GroundUnitFormationTemplateData)this.lstvTemplate.SelectedItems[0].Tag;
            if (this.gclass102_0 == null)
                return;
            this.gclass102_0.method_10(this.lstvTemplateUnitList);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1851);
        }
    }

    private void cmdRename_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.lstvTemplate.SelectedItems.Count == 0)
                return;
            ListViewItem selectedItem = this.lstvTemplate.SelectedItems[0];
            this.gclass102_0 = (GroundUnitFormationTemplateData)this.lstvTemplate.SelectedItems[0].Tag;
            if (this.gclass102_0 == null)
                return;
            this.gclass0_0.string_3 = "Enter Template Name";
            this.gclass0_0.string_4 = this.gclass102_0.Name;
            int num1 = (int)new MessageEntry(this.gclass0_0).ShowDialog();
            this.gclass102_0.Name = this.gclass0_0.string_4;
            selectedItem.SubItems[1].Text = this.gclass102_0.Name;
            this.gclass0_0.string_3 = "Enter Template Abbreviation";
            this.gclass0_0.string_4 = this.gclass102_0.Abbreviation;
            int num2 = (int)new MessageEntry(this.gclass0_0).ShowDialog();
            this.gclass102_0.Abbreviation = this.gclass0_0.string_4;
            selectedItem.SubItems[0].Text = this.gclass102_0.Abbreviation;
            foreach (OrganizationNodeC93 gclass93 in this.gclass21_0.OrganizationNodeDictionary.Values
                         .Where<OrganizationNodeC93>(gclass93_0 => gclass93_0.FormationTemplate == this.gclass102_0)
                         .ToList<OrganizationNodeC93>())
                gclass93.OrganizationName = this.gclass102_0.Name;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1852);
        }
    }

    private void cmdEditAmount_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.lstvTemplateUnitList.SelectedItems.Count == 0)
                return;
            ListViewItem selectedItem = this.lstvTemplateUnitList.SelectedItems[0];
            GroundUnitFormationElement tag = (GroundUnitFormationElement)this.lstvTemplateUnitList.SelectedItems[0].Tag;
            if (tag == null)
                return;
            if (tag.FormationTemplate.method_2())
            {
                int num1 = (int)MessageBox.Show(
                    "Templates with associated ground construction tasks cannot be modified");
            }
            else
            {
                this.gclass0_0.string_3 = "Enter Formation Element Unit Amount";
                this.gclass0_0.string_4 = tag.UnitCount.ToString();
                int num2 = (int)new MessageEntry(this.gclass0_0).ShowDialog();
                tag.UnitCount = Convert.ToInt32(this.gclass0_0.string_4);
                this.gclass21_0.method_214(this.lstvTemplate, null, this.chkShowCivilian.CheckState, tag.FormationTemplate,
                    this.chkShowObsoleteTemplates.CheckState);
                tag.FormationTemplate.method_10(this.lstvTemplateUnitList);
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1853);
        }
    }

    private void lstvTemplateUnitList_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            if (this.lstvTemplateUnitList.SelectedItems.Count == 0)
                return;
            GroundUnitFormationElement tag = (GroundUnitFormationElement)this.lstvTemplateUnitList.SelectedItems[0].Tag;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1854);
        }
    }

    private void cmdDeleteFormation_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.lstvTemplate.SelectedItems.Count == 0)
                return;
            ListViewItem selectedItem = this.lstvTemplate.SelectedItems[0];
            this.gclass102_0 = (GroundUnitFormationTemplateData)this.lstvTemplate.SelectedItems[0].Tag;
            if (this.gclass102_0 == null)
                return;
            this.gclass102_0.Obsolete = this.gclass102_0.Obsolete != 1 ? 1 : 0;
            this.gclass21_0.method_214(this.lstvTemplate, null, this.chkShowCivilian.CheckState, this.gclass102_0,
                this.chkShowObsoleteTemplates.CheckState);
            this.lstvTemplateUnitList.Items.Clear();
            if (this.gclass102_0.Obsolete == 0)
                return;
            foreach (OrganizationNodeC93 gclass93 in this.gclass21_0.OrganizationNodeDictionary.Values
                         .Where<OrganizationNodeC93>(gclass93_0 => gclass93_0.FormationTemplate == this.gclass102_0)
                         .ToList<OrganizationNodeC93>())
                this.gclass21_0.OrganizationNodeDictionary.Remove(gclass93.OrganizationID);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1855);
        }
    }

    private void cmdDeleteElement_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.lstvTemplateUnitList.SelectedItems.Count == 0)
                return;
            ListViewItem selectedItem = this.lstvTemplateUnitList.SelectedItems[0];
            GroundUnitFormationElement tag = (GroundUnitFormationElement)this.lstvTemplateUnitList.SelectedItems[0].Tag;
            if (tag == null)
                return;
            if (tag.FormationTemplate.method_2())
            {
                int num = (int)MessageBox.Show(
                    "Templates with associated ground construction tasks cannot be modified");
            }
            else
            {
                if (MessageBox.Show(
                        $"Are you sure you want to delete the template element '{tag.UnitCount.ToString()}x {tag.GroundUnitClass.ClassName}'?",
                        "Confirm Delete", MessageBoxButtons.YesNo) != DialogResult.Yes)
                    return;
                tag.FormationTemplate.FormationElementList.Remove(tag);
                this.gclass21_0.method_214(this.lstvTemplate, null, this.chkShowCivilian.CheckState, tag.FormationTemplate,
                    this.chkShowObsoleteTemplates.CheckState);
                tag.FormationTemplate.method_10(this.lstvTemplateUnitList);
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1856);
        }
    }

    private void tvFormations_AfterSelect(object sender, TreeViewEventArgs e)
    {
        try
        {
            if (this.gclass0_0.bool_9)
                return;
            this.method_5();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1857);
        }
    }

    private void lstvFormationUnitList_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            if (this.lstvFormationUnitList.SelectedItems.Count == 0)
                return;
            if (this.lstvFormationUnitList.SelectedItems[0].Tag == null)
                this.txtElementClass.Text = "No Element Selected";
            else if (this.lstvFormationUnitList.SelectedItems[0].Tag.GetType() != typeof(GroundUnitFormationElement))
                this.txtElementClass.Text = "No Element Selected";
            else
                ((GroundUnitFormationElement)this.lstvFormationUnitList.SelectedItems[0].Tag)?.GroundUnitClass.method_9(this.txtElementClass,
                    true, false);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1858);
        }
    }

    private void tvFormations_DragDrop(object sender, DragEventArgs e)
    {
        try
        {
            TreeNode nodeAt = this.tvFormations.GetNodeAt(this.tvFormations.PointToClient(new Point(e.X, e.Y)));
            TreeNode data = (TreeNode)e.Data.GetData(typeof(TreeNode));
            if (nodeAt == null && data.Tag is GroundUnitFormationData)
            {
                ((GroundUnitFormationData)data.Tag).ParentFormationData = null;
                this.gclass21_0.method_365(this.tvFormations, this.chkLocation.CheckState, this.chkPosition.CheckState,
                    this.chkElements.CheckState, this.chkShowSupport.CheckState, this.chkCivilian.CheckState,
                    this.chkCreationDate.CheckState, this.chkShips.CheckState);
            }
            else
            {
                if (data.Equals(nodeAt) || nodeAt == null)
                    return;
                if (data.Tag is GroundUnitFormationData && nodeAt.Tag is GroundUnitFormationData)
                {
                    GroundUnitFormationData tag1 = (GroundUnitFormationData)data.Tag;
                    GroundUnitFormationData tag2 = (GroundUnitFormationData)nodeAt.Tag;
                    if (!tag1.method_2(tag2))
                    {
                        int num = (int)MessageBox.Show(
                            "A formation can only be transferred to a parent formation located in a population on the same system body or on the same ship",
                            "Move Not Possible");
                        return;
                    }

                    int num1 = tag2.method_33();
                    int num2 = tag1.method_33();
                    if (num1 != 0 && num1 > num2)
                    {
                        tag1.ParentFormationData = tag2;
                        data.Remove();
                        nodeAt.Nodes.Add(data);
                    }
                    else
                    {
                        if (!tag1.method_18(tag2))
                        {
                            int num3 = (int)MessageBox.Show(
                                "A formation cannot be attached unless the target formation has an HQ component with a higher rating than any component in the attaching formation",
                                "Attachment Not Possible");
                            return;
                        }

                        GroundUnitFormationData gclass1031 = tag1.AssignedFormationData;
                        tag1.AssignedFormationData = tag2;
                        if (gclass1031 != null && this.chkShowSupport.CheckState == CheckState.Checked &&
                            !gclass1031.method_12())
                        {
                            TreeNode treeNode = this.method_1(gclass1031);
                            if (treeNode != null)
                                treeNode.ForeColor = AuroraUtils.color_16;
                        }

                        data.Text = tag1.method_25(this.chkPosition.CheckState, this.chkShowSupport.CheckState);
                        if (this.chkShowSupport.CheckState != CheckState.Checked)
                            return;
                        data.ForeColor = AuroraUtils.color_0;
                        nodeAt.ForeColor = AuroraUtils.color_1;
                        return;
                    }
                }
                else if (data.Tag is FCTShipData40 && nodeAt.Tag is GroundUnitFormationData)
                {
                    // ISSUE: object of a compiler-generated type is created
                    // ISSUE: variable of a compiler-generated type
                    GroundUnitDesign.Class1055 class1055 = new GroundUnitDesign.Class1055();
                    FCTShipData40 tag = (FCTShipData40)data.Tag;
                    // ISSUE: reference to a compiler-generated field
                    class1055.gclass103_0 = (GroundUnitFormationData)nodeAt.Tag;
                    // ISSUE: reference to a compiler-generated field
                    if (tag.gclass85_0.OrbitingBody != class1055.gclass103_0.PopulationData.SystemBodyData)
                    {
                        int num = (int)MessageBox.Show(
                            "Ground support aircraft or orbital bombardment ships can only be assigned to a ground unit formation on the same system body",
                            "Attachment Not Possible");
                        return;
                    }

                    // ISSUE: reference to a compiler-generated field
                    int num4 = class1055.gclass103_0.ElementList.Sum<GroundUnitFormationElement>(gclass39_0 =>
                        gclass39_0.UnitCount *
                        gclass39_0.GroundUnitClass.GroundUnitComponentList.Sum<GroundComponentTypeDefinition>(gclass100_0 => gclass100_0.FireDirection));
                    if (num4 == 0)
                    {
                        int num5 = (int)MessageBox.Show(
                            "Ground support aircraft or orbital bombardment ships can only be assigned to a ground unit formation that has one or more forward fire direction units",
                            "Attachment Not Possible");
                        return;
                    }

                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    int num6 = this.gclass0_0.FCTShipDataDictionary.Values.Where<FCTShipData40>(class1055.method_0)
                        .Count<FCTShipData40>(class1055.method_1);
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    int num7 = 6 * this.gclass0_0.FCTShipDataDictionary.Values.Where<FCTShipData40>(class1055.method_2)
                        .Count<FCTShipData40>(class1055.method_3);
                    int num8 = 1;
                    if (tag.gclass85_0.method_42(MoveActionType.ProvideOrbitalBombardmentSupport))
                        num8 = 6;
                    if (num4 * 6 - num6 - num7 < num8)
                    {
                        int num9 = (int)MessageBox.Show(
                            "Ground support aircraft or orbital bombardment ships can only be assigned to a ground unit formation that has sufficient forward fire direction units. One FFD is required for six ground support fighters or one ship providing orbital bombardment support",
                            "Attachment Not Possible");
                        return;
                    }

                    GroundUnitFormationData gclass1030 = tag.gclass103_0;
                    // ISSUE: reference to a compiler-generated field
                    tag.gclass103_0 = class1055.gclass103_0;
                    if (gclass1030 != null && this.chkShowSupport.CheckState == CheckState.Checked &&
                        !gclass1030.method_12())
                    {
                        TreeNode treeNode = this.method_1(gclass1030);
                        if (treeNode != null)
                            treeNode.ForeColor = AuroraUtils.color_16;
                    }

                    data.Text = tag.method_60(this.chkShowSupport.CheckState);
                    if (this.chkShowSupport.CheckState == CheckState.Checked)
                    {
                        data.ForeColor = AuroraUtils.color_0;
                        nodeAt.ForeColor = AuroraUtils.color_1;
                    }
                }
                else if (data.Tag is GroundUnitFormationData && nodeAt.Tag is PopulationData)
                {
                    GroundUnitFormationData tag3 = (GroundUnitFormationData)data.Tag;
                    PopulationData tag4 = (PopulationData)nodeAt.Tag;
                    if (tag3.PopulationData == null && !this.gclass0_0.bool_8)
                    {
                        int num = (int)MessageBox.Show(
                            "A formation cannot be moved to a population unless it originates at a population on the same system body or SM Mode is active",
                            "Move Not Possible");
                        return;
                    }

                    if (tag4.SystemBodyData != tag3.PopulationData.SystemBodyData && !this.gclass0_0.bool_8)
                    {
                        int num = (int)MessageBox.Show(
                            "A formation cannot be moved to a population unless it originates at a population on the same system body or SM Mode is active",
                            "Move Not Possible");
                        return;
                    }

                    tag3.RaceData.method_369(tag3, tag4);
                    data.Remove();
                    nodeAt.Nodes.Add(data);
                }
                else if (data.Tag is GroundUnitFormationElement && nodeAt.Tag is PopulationData)
                {
                    GroundUnitFormationElement tag5 = (GroundUnitFormationElement)data.Tag;
                    PopulationData tag6 = (PopulationData)nodeAt.Tag;
                    if (tag5.Formation.PopulationData == null && !this.gclass0_0.bool_8)
                    {
                        int num = (int)MessageBox.Show(
                            "A formation element cannot be moved to a population to create a new formation unless it originates at a population on the same system body or SM Mode is active",
                            "Move Not Possible");
                        return;
                    }

                    if (tag6.SystemBodyData != tag5.Formation.PopulationData.SystemBodyData && !this.gclass0_0.bool_8)
                    {
                        int num = (int)MessageBox.Show(
                            "A formation element cannot be moved to a population to create a new formation unless it originates at a population on the same system body or SM Mode is active",
                            "Move Not Possible");
                        return;
                    }

                    this.gclass0_0.string_3 = "Enter Name for New Formation";
                    this.gclass0_0.string_4 = "";
                    int num10 = (int)new MessageEntry(this.gclass0_0).ShowDialog();
                    if (this.gclass0_0.bool_21)
                        return;
                    string string4_1 = this.gclass0_0.string_4;
                    this.gclass0_0.string_3 = "Enter Abbreviation for New Formation";
                    this.gclass0_0.string_4 = "";
                    int num11 = (int)new MessageEntry(this.gclass0_0).ShowDialog();
                    if (this.gclass0_0.bool_21)
                        return;
                    string string4_2 = this.gclass0_0.string_4;
                    GroundUnitFormationData gclass103 =
                        tag5.Formation.RaceData.method_159(string4_1, string4_2, tag6, null, tag6.SpeciesData);
                    int num12 = tag5.UnitCount;
                    if (this.chkPartial.CheckState == CheckState.Checked)
                    {
                        this.gclass0_0.string_3 = "Enter Number of Ground Units to Transfer";
                        this.gclass0_0.string_4 = num12.ToString();
                        int num13 = (int)new MessageEntry(this.gclass0_0).ShowDialog();
                        if (this.gclass0_0.bool_21)
                            return;
                        int int32 = Convert.ToInt32(this.gclass0_0.string_4);
                        if (int32 < num12)
                            num12 = int32;
                        if (num12 <= 0)
                            return;
                    }

                    GroundUnitFormationElement gclass39 = new GroundUnitFormationElement(this.gclass0_0);
                    gclass39.ElementID = this.gclass0_0.method_26(GEnum0.const_44);
                    gclass39.GroundUnitClass = tag5.GroundUnitClass;
                    gclass39.Formation = gclass103;
                    gclass39.RaceData = tag5.RaceData;
                    gclass39.UnitCount = num12;
                    gclass39.CurrentSupply = tag5.CurrentSupply;
                    gclass39.Morale = tag5.Morale;
                    gclass39.FortificationLevel = tag5.FortificationLevel;
                    gclass103.ElementList.Add(gclass39);
                    TreeNode node = new TreeNode();
                    node.Text = gclass103.Name;
                    node.Tag = gclass103;
                    nodeAt.Nodes.Add(node);
                    node.Nodes.Add(new TreeNode()
                    {
                        Text = $"{gclass39.UnitCount.ToString()}x {gclass39.GroundUnitClass.ClassName}",
                        Tag = gclass39
                    });
                    if (num12 == tag5.UnitCount)
                    {
                        tag5.Formation.ElementList.Remove(tag5);
                        data.Remove();
                    }
                    else
                    {
                        tag5.UnitCount -= num12;
                        data.Text = $"{tag5.UnitCount.ToString()}x {tag5.GroundUnitClass.ClassName}";
                    }
                }

                if (data.Tag is GroundUnitFormationElement && nodeAt.Tag is GroundUnitFormationData)
                {
                    // ISSUE: object of a compiler-generated type is created
                    // ISSUE: variable of a compiler-generated type
                    GroundUnitDesign.Class1056 class1056 = new GroundUnitDesign.Class1056();
                    // ISSUE: reference to a compiler-generated field
                    class1056.gclass39_0 = (GroundUnitFormationElement)data.Tag;
                    GroundUnitFormationData tag = (GroundUnitFormationData)nodeAt.Tag;
                    // ISSUE: reference to a compiler-generated field
                    if (tag.PopulationData.SystemBodyData != class1056.gclass39_0.Formation.PopulationData.SystemBodyData)
                    {
                        int num = (int)MessageBox.Show(
                            "A formation element cannot be moved to a different formation unless they are both located on the same system body",
                            "Move Not Possible");
                        return;
                    }

                    // ISSUE: reference to a compiler-generated field
                    int num14 = class1056.gclass39_0.UnitCount;
                    if (this.chkPartial.CheckState == CheckState.Checked)
                    {
                        this.gclass0_0.string_3 = "Enter Number of Ground Units to Transfer";
                        this.gclass0_0.string_4 = num14.ToString();
                        int num15 = (int)new MessageEntry(this.gclass0_0).ShowDialog();
                        if (this.gclass0_0.bool_21)
                            return;
                        int int32 = Convert.ToInt32(this.gclass0_0.string_4);
                        if (int32 < num14)
                            num14 = int32;
                        if (num14 <= 0)
                            return;
                    }

                    // ISSUE: reference to a compiler-generated method
                    GroundUnitFormationElement gclass39_1 = tag.ElementList.FirstOrDefault<GroundUnitFormationElement>(class1056.method_0);
                    if (gclass39_1 != null)
                    {
                        // ISSUE: reference to a compiler-generated field
                        gclass39_1.Morale =
                            Math.Floor(
                                (gclass39_1.Morale * gclass39_1.UnitCount + class1056.gclass39_0.Morale * num14) /
                                (gclass39_1.UnitCount + num14));
                        // ISSUE: reference to a compiler-generated field
                        double d = (gclass39_1.CurrentSupply * gclass39_1.UnitCount + class1056.gclass39_0.CurrentSupply * num14) /
                                   (double)(gclass39_1.UnitCount + num14);
                        gclass39_1.CurrentSupply = (int)Math.Floor(d);
                        gclass39_1.UnitCount += num14;
                        foreach (TreeNode node in nodeAt.Nodes)
                        {
                            if (node.Tag == gclass39_1)
                            {
                                node.Text = $"{gclass39_1.UnitCount.ToString()}x {gclass39_1.GroundUnitClass.ClassName}";
                                break;
                            }
                        }
                    }
                    else
                    {
                        GroundUnitFormationElement gclass39_2 = new GroundUnitFormationElement(this.gclass0_0);
                        gclass39_2.ElementID = this.gclass0_0.method_26(GEnum0.const_44);
                        // ISSUE: reference to a compiler-generated field
                        gclass39_2.GroundUnitClass = class1056.gclass39_0.GroundUnitClass;
                        gclass39_2.Formation = tag;
                        // ISSUE: reference to a compiler-generated field
                        gclass39_2.RaceData = class1056.gclass39_0.RaceData;
                        gclass39_2.UnitCount = num14;
                        // ISSUE: reference to a compiler-generated field
                        gclass39_2.CurrentSupply = class1056.gclass39_0.CurrentSupply;
                        // ISSUE: reference to a compiler-generated field
                        gclass39_2.Morale = class1056.gclass39_0.Morale;
                        // ISSUE: reference to a compiler-generated field
                        gclass39_2.FortificationLevel = class1056.gclass39_0.FortificationLevel;
                        tag.ElementList.Add(gclass39_2);
                        nodeAt.Nodes.Add(new TreeNode()
                        {
                            Text = $"{gclass39_2.UnitCount.ToString()}x {gclass39_2.GroundUnitClass.ClassName}",
                            Tag = gclass39_2
                        });
                    }

                    // ISSUE: reference to a compiler-generated field
                    if (num14 == class1056.gclass39_0.UnitCount)
                    {
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        class1056.gclass39_0.Formation.ElementList.Remove(class1056.gclass39_0);
                        data.Remove();
                    }
                    else
                    {
                        // ISSUE: reference to a compiler-generated field
                        class1056.gclass39_0.UnitCount -= num14;
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        data.Text =
                            $"{class1056.gclass39_0.UnitCount.ToString()}x {class1056.gclass39_0.GroundUnitClass.ClassName}";
                    }

                    foreach (GroundUnitFormationData gclass103 in this.gclass0_0.FormationDictionary.Values)
                        gclass103.bool_1 = false;
                    tag.bool_1 = true;
                }

                nodeAt.Expand();
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1859);
        }
    }

    private void tvFormations_DragEnter(object sender, DragEventArgs e)
    {
        try
        {
            e.Effect = DragDropEffects.Move;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1860);
        }
    }

    private void tvFormations_ItemDrag(object sender, ItemDragEventArgs e)
    {
        try
        {
            int num = (int)this.DoDragDrop(e.Item, DragDropEffects.Move);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1861);
        }
    }

    private void tvFormations_AfterCollapse(object sender, TreeViewEventArgs e)
    {
        try
        {
            if (this.gclass0_0.bool_9 || !(e.Node.Tag is GroundUnitFormationData))
                return;
            ((GroundUnitFormationData)e.Node.Tag).bool_0 = false;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1862);
        }
    }

    private void tvFormations_AfterExpand(object sender, TreeViewEventArgs e)
    {
        try
        {
            if (this.gclass0_0.bool_9 || !(e.Node.Tag is GroundUnitFormationData))
                return;
            ((GroundUnitFormationData)e.Node.Tag).bool_0 = true;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1863);
        }
    }

    private void cmdSortTypeCost_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass0_0.bool_9 || this.gclass21_0 == null)
                return;
            Button button = (Button)sender;
            if (button.Name == "cmdSortCost")
                this.gclass21_0.genum46_0 = GEnum46.const_0;
            if (button.Name == "cmdSortSize")
                this.gclass21_0.genum46_0 = GEnum46.const_1;
            if (button.Name == "cmdSortUnits")
                this.gclass21_0.genum46_0 = GEnum46.const_2;
            if (button.Name == "cmdSortName")
                this.gclass21_0.genum46_0 = GEnum46.const_3;
            if (button.Name == "cmdSortTypeSize")
                this.gclass21_0.genum46_0 = GEnum46.const_4;
            if (button.Name == "cmdSortTypeCost")
                this.gclass21_0.genum46_0 = GEnum46.const_5;
            this.method_5();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1864);
        }
    }

    private void cmdRenameFormation_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass0_0.bool_9)
                return;
            GroundUnitFormationData tag = (GroundUnitFormationData)this.tvFormations.SelectedNode.Tag;
            if (tag == null)
                return;
            this.gclass0_0.string_3 = "Enter Formation Name";
            this.gclass0_0.string_4 = tag.Name;
            int num1 = (int)new MessageEntry(this.gclass0_0).ShowDialog();
            if (this.gclass0_0.string_4 != "")
                tag.Name = this.gclass0_0.string_4;
            this.gclass0_0.string_3 = "Enter Formation Abbreviation";
            this.gclass0_0.string_4 = tag.Abbreviation;
            int num2 = (int)new MessageEntry(this.gclass0_0).ShowDialog();
            if (this.gclass0_0.string_4 != "")
                tag.Abbreviation = this.gclass0_0.string_4;
            this.tvFormations.SelectedNode.Text =
                tag.method_25(this.chkPosition.CheckState, this.chkShowSupport.CheckState);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1865);
        }
    }

    private void chkCreationDate_CheckedChanged(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass21_0 == null)
                return;
            this.gclass21_0.method_365(this.tvFormations, this.chkLocation.CheckState, this.chkPosition.CheckState,
                this.chkElements.CheckState, this.chkShowSupport.CheckState, this.chkCivilian.CheckState,
                this.chkCreationDate.CheckState, this.chkShips.CheckState);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1866);
        }
    }

    private void tabTemplates_Click(object sender, EventArgs e)
    {
    }

    private void cmdChangeRank_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.lstvTemplate.SelectedItems.Count == 0)
                return;
            ListViewItem selectedItem = this.lstvTemplate.SelectedItems[0];
            this.gclass102_0 = (GroundUnitFormationTemplateData)this.lstvTemplate.SelectedItems[0].Tag;
            if (this.gclass102_0 == null)
                return;
            this.gclass0_0.string_3 = "Select Default Rank";
            this.gclass0_0.string_7 = "";
            this.gclass0_0.string_8 = "";
            this.gclass0_0.string_9 = "";
            this.gclass0_0.list_32 = new List<string>();
            List<RankThemeEntry> list = this.gclass21_0.RacialRankDictionary.Values
                .Where<RankThemeEntry>(gclass61_0 => gclass61_0.CommanderType == AuroraCommanderType.GroundForce)
                .OrderBy<RankThemeEntry, int>(gclass61_0 => gclass61_0.RankNum).ToList<RankThemeEntry>();
            foreach (RankThemeEntry gclass61 in list)
                this.gclass0_0.list_32.Add(gclass61.RankName);
            int num = (int)new UserSelection(this.gclass0_0).ShowDialog();
            if (this.gclass0_0.bool_21)
                return;
            this.gclass102_0.RequiredRankData =
                list.FirstOrDefault<RankThemeEntry>(gclass61_0 => gclass61_0.RankName == this.gclass0_0.string_4);
            selectedItem.SubItems[8].Text = this.gclass102_0.RequiredRankData.method_0();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1867);
        }
    }

    private void cmdChangeFormationRank_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.tvFormations.SelectedNode.Tag == null || !(this.tvFormations.SelectedNode.Tag is GroundUnitFormationData))
                return;
            GroundUnitFormationData tag = (GroundUnitFormationData)this.tvFormations.SelectedNode.Tag;
            if (tag == null)
                return;
            this.gclass0_0.string_3 = "Select Default Rank";
            this.gclass0_0.string_7 = "";
            this.gclass0_0.string_8 = "";
            this.gclass0_0.string_9 = "";
            this.gclass0_0.list_32 = new List<string>();
            List<RankThemeEntry> list = this.gclass21_0.RacialRankDictionary.Values
                .Where<RankThemeEntry>(gclass61_0 => gclass61_0.CommanderType == AuroraCommanderType.GroundForce)
                .OrderBy<RankThemeEntry, int>(gclass61_0 => gclass61_0.RankNum).ToList<RankThemeEntry>();
            foreach (RankThemeEntry gclass61 in list)
                this.gclass0_0.list_32.Add(gclass61.RankName);
            int num = (int)new UserSelection(this.gclass0_0).ShowDialog();
            if (this.gclass0_0.bool_21)
                return;
            tag.RequiredRankData =
                list.FirstOrDefault<RankThemeEntry>(gclass61_0 => gclass61_0.RankName == this.gclass0_0.string_4);
            bool bool_7 = false;
            if (this.chkLocation.CheckState == CheckState.Checked)
                bool_7 = true;
            tag.method_30(this.lstvFormationUnitList, this.txtCmdr, this.txtFormationLocation,
                this.txtReplacementTemplate, this.txtPriority, this.chkUseForReplacements, bool_7);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1868);
        }
    }

    private void cmdTransferAlien_Click(object sender, EventArgs e)
    {
        try
        {
            // ISSUE: object of a compiler-generated type is created
            // ISSUE: variable of a compiler-generated type
            GroundUnitDesign.Class1057 class1057 = new GroundUnitDesign.Class1057();
            if (this.gclass0_0.bool_9)
                return;
            if (this.tvFormations.SelectedNode.Tag == null)
            {
                int num1 = (int)MessageBox.Show("Please select a formation to transfer");
            }
            else
            {
                GroundUnitFormationData tag = (GroundUnitFormationData)this.tvFormations.SelectedNode.Tag;
                if (tag == null)
                    return;
                this.gclass0_0.string_3 = "Select Alien Population";
                this.gclass0_0.string_7 = "Transfer All Subordinate Formations";
                this.gclass0_0.string_8 = "";
                this.gclass0_0.string_9 = "";
                this.gclass0_0.list_32 = new List<string>();
                if (tag.PopulationData == null)
                {
                    int num2 = (int)MessageBox.Show(
                        "A formation cannot be moved to an alien population unless it originates at a population on the same system body",
                        "Move Not Possible");
                }
                else
                {
                    List<PopulationData> source = tag.PopulationData.method_198();
                    if (source.Count == 0)
                    {
                        int num3 = (int)MessageBox.Show(
                            "A formation can only be moved to an alien population if one exists on the same system body",
                            "Move Not Possible");
                    }
                    else
                    {
                        foreach (PopulationData gclass146 in source)
                            this.gclass0_0.list_32.Add(gclass146.ContactDropdownName);
                        int num4 = (int)new UserSelection(this.gclass0_0).ShowDialog();
                        if (this.gclass0_0.bool_21)
                            return;
                        // ISSUE: reference to a compiler-generated field
                        class1057.gclass146_0 = source.FirstOrDefault<PopulationData>(gclass146_1 =>
                            gclass146_1.ContactDropdownName == this.gclass0_0.string_4);
                        List<RankThemeEntry> list1 = tag.RaceData.RacialRankDictionary.Values.ToList<RankThemeEntry>();
                        bool bool_7 = AuroraUtils.smethod_27(this.gclass0_0.checkState_0);
                        // ISSUE: reference to a compiler-generated field
                        tag.method_4(class1057.gclass146_0, list1, bool_7);
                        // ISSUE: reference to a compiler-generated field
                        if (class1057.gclass146_0.RaceData.NPR)
                        {
                            // ISSUE: reference to a compiler-generated method
                            List<GroundUnitFormationData> list2 = this.gclass0_0.FormationDictionary.Values
                                .Where<GroundUnitFormationData>(class1057.method_0).ToList<GroundUnitFormationData>();
                            // ISSUE: reference to a compiler-generated method
                            List<GroundUnitFormationTemplateData> list3 = this.gclass0_0.FormationTemplateRecordDic.Values
                                .Where<GroundUnitFormationTemplateData>(class1057.method_1).ToList<GroundUnitFormationTemplateData>();
                            foreach (GroundUnitFormationData gclass103_0 in list2)
                                gclass103_0.OriginalTemplateData = this.method_9(gclass103_0, list3);
                        }

                        this.gclass21_0.method_365(this.tvFormations, this.chkLocation.CheckState,
                            this.chkPosition.CheckState, this.chkElements.CheckState, this.chkShowSupport.CheckState,
                            this.chkCivilian.CheckState, this.chkCreationDate.CheckState, this.chkShips.CheckState);
                    }
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1869);
        }
    }

    private GroundUnitFormationTemplateData method_9(GroundUnitFormationData gclass103_0, List<GroundUnitFormationTemplateData> list_0)
    {
        try
        {
            Decimal num1 = gclass103_0.method_44();
            Decimal num2 = 0M;
            Decimal num3 = 0M;
            Decimal num4 = 0M;
            Decimal num5 = 0M;
            Decimal num6 = 0M;
            Decimal num7 = 0M;
            Decimal num8 = 0M;
            Decimal num9 = 0M;
            GroundUnitFormationTemplateData gclass102_1 = null;
            foreach (GroundUnitFormationElement gclass39 in gclass103_0.ElementList)
            {
                if (gclass39.GroundUnitClass.GroundUnitComponentList.Sum<GroundComponentTypeDefinition>(gclass100_0 => gclass100_0.GeoSurvey) > 0M)
                    num2 += gclass39.GroundUnitClass.decimal_3 * gclass39.UnitCount;
                if (gclass39.GroundUnitClass.GroundUnitComponentList.Sum<GroundComponentTypeDefinition>(gclass100_0 => gclass100_0.Xenoarchaeology) > 0M)
                    num3 += gclass39.GroundUnitClass.decimal_3 * gclass39.UnitCount;
                if (gclass39.GroundUnitClass.GroundUnitComponentList.Sum<GroundComponentTypeDefinition>(gclass100_0 => gclass100_0.Construction) > 0M)
                    num4 += gclass39.GroundUnitClass.decimal_3 * gclass39.UnitCount;
                if (gclass39.GroundUnitClass.GroundUnitComponentList.Sum<GroundComponentTypeDefinition>(gclass100_0 => gclass100_0.Decontamination) > 0M)
                    num5 += gclass39.GroundUnitClass.decimal_3 * gclass39.UnitCount;
                if (gclass39.GroundUnitClass.GroundUnitComponentList.Sum<GroundComponentTypeDefinition>(gclass100_0 => gclass100_0.LogisticsPoint) > 0M)
                    num7 += gclass39.GroundUnitClass.decimal_3 * gclass39.UnitCount;
                if (gclass39.GroundUnitClass.gclass230_0 != null)
                    num6 += gclass39.GroundUnitClass.decimal_3 * gclass39.UnitCount;
                if (gclass39.GroundUnitClass.GroundUnitBaseTypeData.genum112_0 == GroundUnitBaseType.const_1 ||
                    gclass39.GroundUnitClass.GroundUnitBaseTypeData.genum112_0 == GroundUnitBaseType.const_2 ||
                    gclass39.GroundUnitClass.GroundUnitBaseTypeData.genum112_0 == GroundUnitBaseType.const_3 ||
                    gclass39.GroundUnitClass.GroundUnitBaseTypeData.genum112_0 == GroundUnitBaseType.const_4)
                    num8 += gclass39.GroundUnitClass.decimal_3 * gclass39.UnitCount;
                if (gclass39.GroundUnitClass.GroundUnitComponentList.Count<GroundComponentTypeDefinition>(gclass100_0 =>
                        gclass100_0.BombardmentWeaponClass == BombardmentWeaponClass.const_3 || gclass100_0.BombardmentWeaponClass == BombardmentWeaponClass.const_2) > 0)
                    num9 += gclass39.GroundUnitClass.decimal_3 * gclass39.UnitCount;
            }

            if (num6 > num1 / 2M)
            {
                GroundUnitFormationTemplateData gclass102_2 =
                    list_0.FirstOrDefault<GroundUnitFormationTemplateData>(gclass102_0 => gclass102_0.AutomatedTemplateType == AutomatedGroundTemplateDesignType.PlanetaryDefenceRegiment);
                if (gclass102_2 != null)
                    return gclass102_2;
            }
            else if (num2 > num1 / 2M)
            {
                GroundUnitFormationTemplateData gclass102_3 =
                    list_0.FirstOrDefault<GroundUnitFormationTemplateData>(gclass102_0 => gclass102_0.AutomatedTemplateType == AutomatedGroundTemplateDesignType.SurveyExpedition);
                if (gclass102_3 != null)
                    return gclass102_3;
            }
            else if (num3 > num1 / 2M)
            {
                GroundUnitFormationTemplateData gclass102_4 =
                    list_0.FirstOrDefault<GroundUnitFormationTemplateData>(gclass102_0 => gclass102_0.AutomatedTemplateType == AutomatedGroundTemplateDesignType.XenoarchaeologyExpedition);
                if (gclass102_4 != null)
                    return gclass102_4;
            }
            else if (num4 > num1 / 2M)
            {
                GroundUnitFormationTemplateData gclass102_5 =
                    list_0.FirstOrDefault<GroundUnitFormationTemplateData>(gclass102_0 => gclass102_0.AutomatedTemplateType == AutomatedGroundTemplateDesignType.ConstructionRegiment);
                if (gclass102_5 != null)
                    return gclass102_5;
            }
            else if (num5 > num1 / 2M)
            {
                GroundUnitFormationTemplateData gclass102_6 =
                    list_0.FirstOrDefault<GroundUnitFormationTemplateData>(gclass102_0 => gclass102_0.AutomatedTemplateType == AutomatedGroundTemplateDesignType.DecontaminationExpedition);
                if (gclass102_6 != null)
                    return gclass102_6;
            }
            else if (num7 + num9 > num1 / 2M)
            {
                GroundUnitFormationTemplateData gclass102_7 =
                    list_0.FirstOrDefault<GroundUnitFormationTemplateData>(gclass102_0 => gclass102_0.AutomatedTemplateType == AutomatedGroundTemplateDesignType.InfantryBrigadeHQ);
                if (gclass102_7 != null)
                    return gclass102_7;
            }
            else if (num8 > num1 / 2M)
            {
                GroundUnitFormationTemplateData gclass102_8 =
                    list_0.FirstOrDefault<GroundUnitFormationTemplateData>(gclass102_0 => gclass102_0.AutomatedTemplateType == AutomatedGroundTemplateDesignType.ArmourRegiment);
                if (gclass102_8 != null)
                    return gclass102_8;
            }

            List<GroundUnitFormationTemplateData> source = list_0;
            return gclass102_1 =
                source.FirstOrDefault<GroundUnitFormationTemplateData>(gclass102_0 => gclass102_0.AutomatedTemplateType == AutomatedGroundTemplateDesignType.InfantryRegiment);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3844);
            return null;
        }
    }

    private void cmdFieldPosition_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.tvFormations.SelectedNode.Tag == null)
                return;
            if (!(this.tvFormations.SelectedNode.Tag is GroundUnitFormationData))
            {
                int num1 = (int)MessageBox.Show("Field Position can only be set for formations");
            }
            else
            {
                GroundUnitFormationData tag = (GroundUnitFormationData)this.tvFormations.SelectedNode.Tag;
                if (tag == null)
                    return;
                this.gclass0_0.string_3 = "Select Field Position";
                this.gclass0_0.string_7 = "Set Field Position ALSO all Subordinate Formations";
                this.gclass0_0.string_8 = "Set Field Position ONLY for Subordinate Formations";
                this.gclass0_0.string_9 = "Set all Formations with Same Template at Same Population";
                this.gclass0_0.list_32 = new List<string>();
                Dictionary<AuroraGroundFormationFieldPosition, string> source =
                    new Dictionary<AuroraGroundFormationFieldPosition, string>();
                foreach (AuroraGroundFormationFieldPosition formationFieldPosition in Enum.GetValues(
                             typeof(AuroraGroundFormationFieldPosition)))
                {
                    source.Add(formationFieldPosition, AuroraUtils.smethod_82(formationFieldPosition));
                    this.gclass0_0.list_32.Add(AuroraUtils.smethod_82(formationFieldPosition));
                }

                int num2 = (int)new UserSelection(this.gclass0_0).ShowDialog();
                if (this.gclass0_0.bool_21)
                    return;
                AuroraGroundFormationFieldPosition key = source
                    .FirstOrDefault<KeyValuePair<AuroraGroundFormationFieldPosition, string>>(keyValuePair_0 =>
                        keyValuePair_0.Value == this.gclass0_0.string_4).Key;
                if (key == AuroraGroundFormationFieldPosition.FrontlineAttack && MessageBox.Show(
                        "Setting front line attack will remove any fortification bonus. Are you sure you wish to change to that field position?",
                        "Confirm Front Line Attack", MessageBoxButtons.YesNo) != DialogResult.Yes)
                    return;
                bool bool_7 = AuroraUtils.smethod_27(this.gclass0_0.checkState_0);
                bool bool_8 = AuroraUtils.smethod_27(this.gclass0_0.checkState_1);
                if (AuroraUtils.smethod_27(this.gclass0_0.checkState_2))
                    tag.method_24(key, bool_7, bool_8, tag);
                else
                    tag.method_24(key, bool_7, bool_8, null);
                this.gclass21_0.method_365(this.tvFormations, this.chkLocation.CheckState, this.chkPosition.CheckState,
                    this.chkElements.CheckState, this.chkShowSupport.CheckState, this.chkCivilian.CheckState,
                    this.chkCreationDate.CheckState, this.chkShips.CheckState);
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1870);
        }
    }

    private void lstvSTO_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass0_0.bool_9 || this.lstvArmourType.SelectedItems.Count == 0)
                return;
            this.chkPointDefence.Visible = false;
            if (this.lstvSTO.SelectedItems.Count > 0 && this.lstvSTO.SelectedItems[0].Tag is ShipComponent)
            {
                this.gclass230_0 = (ShipComponent)this.lstvSTO.SelectedItems[0].Tag;
                if (this.gclass230_0.gclass231_0.ComponentTypeID != AuroraComponentType.Laser &&
                    this.gclass230_0.gclass231_0.ComponentTypeID != AuroraComponentType.MesonCannon &&
                    this.gclass230_0.gclass231_0.ComponentTypeID != AuroraComponentType.GaussCannon)
                    this.chkPointDefence.CheckState = CheckState.Unchecked;
                else
                    this.chkPointDefence.Visible = true;
            }

            this.method_7();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1871);
        }
    }

    private void cmdActive_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass0_0.bool_9 || !(this.tvFormations.SelectedNode.Tag is GroundUnitFormationData))
                return;
            GroundUnitFormationData tag = (GroundUnitFormationData)this.tvFormations.SelectedNode.Tag;
            if (tag == null)
                return;
            if (this.cmdActive.Text == "Active On")
            {
                tag.bActiveSensorsOn = true;
                this.cmdActive.Text = "Active Off";
            }
            else
            {
                tag.bActiveSensorsOn = false;
                this.cmdActive.Text = "Active On";
            }

            TreeNode treeNode = this.method_1(tag);
            if (treeNode == null)
                return;
            treeNode.Text = tag.method_25(this.chkPosition.CheckState, this.chkShowSupport.CheckState);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1872);
        }
    }

    private void method_10(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass0_0.bool_9 || this.lstvPrimary.SelectedItems.Count == 0)
                return;
            this.method_7();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1873);
        }
    }

    private void lstvSTOTargeting_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            if (this.lstvSTOTargeting.SelectedItems.Count == 0)
                return;
            GroundUnitFormationElement tag = (GroundUnitFormationElement)this.lstvSTOTargeting.SelectedItems[0].Tag;
            if (tag == null)
                return;
            this.cboTargetType.SelectedItem = tag.TargetSelectionType;
            this.txtDistribution.Text = tag.FiringDistribution.ToString();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1874);
        }
    }

    private void cboTargetType_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            // ISSUE: object of a compiler-generated type is created
            // ISSUE: variable of a compiler-generated type
            GroundUnitDesign.Class1058 class1058 = new GroundUnitDesign.Class1058();
            if (this.lstvSTOTargeting.SelectedItems.Count == 0)
                return;
            GroundUnitFormationElement tag = (GroundUnitFormationElement)this.lstvSTOTargeting.SelectedItems[0].Tag;
            if (tag == null)
                return;
            // ISSUE: reference to a compiler-generated field
            class1058.string_0 = (string)this.cboTargetType.SelectedItem;
            // ISSUE: reference to a compiler-generated method
            tag.TargetSelectionType = this.dictionary_1
                .FirstOrDefault<KeyValuePair<AuroraTargetSelection, string>>(class1058.method_0).Key;
            this.gclass21_0.method_357(this.lstvSTOTargeting);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1875);
        }
    }

    private void txtDistribution_TextChanged(object sender, EventArgs e)
    {
        try
        {
            if (this.lstvSTOTargeting.SelectedItems.Count == 0)
                return;
            GroundUnitFormationElement tag = (GroundUnitFormationElement)this.lstvSTOTargeting.SelectedItems[0].Tag;
            if (tag == null)
                return;
            tag.FiringDistribution = Convert.ToInt32(this.txtDistribution.Text);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1876);
        }
    }

    private void lstvSTO_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
    {
        try
        {
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1877);
        }
    }

    private void chkPointDefence_CheckedChanged(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass0_0.bool_9 || this.lstvArmourType.SelectedItems.Count == 0)
                return;
            this.method_7();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1878);
        }
    }

    private void chkECCM_CheckedChanged(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass0_0.bool_9 || this.lstvArmourType.SelectedItems.Count == 0)
                return;
            this.method_7();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1879);
        }
    }

    private void cmdDelete_Click(object sender, EventArgs e)
    {
        try
        {
            // ISSUE: object of a compiler-generated type is created
            // ISSUE: variable of a compiler-generated type
            GroundUnitDesign.Class1059 class1059 = new GroundUnitDesign.Class1059();
            if (this.gclass0_0.bool_9 || this.tvFormations.SelectedNode == null)
                return;
            if (!(this.tvFormations.SelectedNode.Tag is GroundUnitFormationData))
            {
                int num = (int)MessageBox.Show("Please select a formation to delete");
            }
            else
            {
                // ISSUE: reference to a compiler-generated field
                class1059.gclass103_0 = (GroundUnitFormationData)this.tvFormations.SelectedNode.Tag;
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                if (class1059.gclass103_0 == null ||
                    MessageBox.Show($"Are you sure you want to delete the formation '{class1059.gclass103_0.Name}'?",
                        "Confirm Delete", MessageBoxButtons.YesNo) != DialogResult.Yes)
                    return;
                // ISSUE: reference to a compiler-generated field
                if (class1059.gclass103_0.gclass55_0 != null)
                {
                    // ISSUE: reference to a compiler-generated field
                    class1059.gclass103_0.gclass55_0.method_40(true);
                }

                // ISSUE: reference to a compiler-generated method
                foreach (GroundUnitFormationData gclass103 in this.gclass0_0.FormationDictionary.Values.Where<GroundUnitFormationData>(class1059.method_0)
                             .ToList<GroundUnitFormationData>())
                    gclass103.ParentFormationData = null;
                // ISSUE: reference to a compiler-generated field
                this.gclass0_0.FormationDictionary.Remove(class1059.gclass103_0.FormationID);
                this.gclass21_0.method_365(this.tvFormations, this.chkLocation.CheckState, this.chkPosition.CheckState,
                    this.chkElements.CheckState, this.chkShowSupport.CheckState, this.chkCivilian.CheckState,
                    this.chkCreationDate.CheckState, this.chkShips.CheckState);
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1880);
        }
    }

    private void txtHQCapacity_TextChanged(object sender, EventArgs e)
    {
        try
        {
            if (this.txtHQCapacity.Text == "" || Convert.ToInt32(this.txtHQCapacity.Text) <= 0)
                return;
            this.method_7();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1881);
        }
    }

    private void method_11(object sender, EventArgs e)
    {
        this.gclass0_0.method_538(this.gclass21_0, this.gclass21_0.method_164(),
            this.gclass0_0.PopulationDataDictionary.Values.FirstOrDefault<PopulationData>(gclass146_1 =>
                gclass146_1.RaceData == this.gclass21_0));
    }

    private void cmdObsolete_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass21_0 == null)
                return;
            if (this.lstvUnitClass.SelectedItems.Count == 0)
            {
                int num = (int)MessageBox.Show("Please select a unit to make obsolete");
            }
            else
            {
                GroundUnitClass101 tag = (GroundUnitClass101)this.lstvUnitClass.SelectedItems[0].Tag;
                if (tag == null)
                    return;
                if (tag.TechData.dictionary_0.ContainsKey(this.gclass21_0.RaceID))
                    tag.TechData.dictionary_0[this.gclass21_0.RaceID].bool_0 =
                        !tag.TechData.dictionary_0[this.gclass21_0.RaceID].bool_0;
                this.gclass21_0.method_212(this.lstvUnitClass, this.chkShowObsolete.CheckState,
                    this.chkShowCivilian.CheckState);
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1882);
        }
    }

    private void chkShowObsolete_CheckedChanged(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass21_0 == null)
                return;
            this.gclass21_0.method_212(this.lstvUnitClass, this.chkShowObsolete.CheckState,
                this.chkShowCivilian.CheckState);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1883);
        }
    }

    private void cmdAwardMedal_Click(object sender, EventArgs e)
    {
        try
        {
            // ISSUE: object of a compiler-generated type is created
            // ISSUE: variable of a compiler-generated type
            GroundUnitDesign.Class1060 class1060 = new GroundUnitDesign.Class1060();
            if (this.gclass21_0 == null)
            {
                int num1 = (int)MessageBox.Show("Please select a race");
            }
            else
            {
                // ISSUE: reference to a compiler-generated field
                class1060.gclass103_0 = (GroundUnitFormationData)this.tvFormations.SelectedNode.Tag;
                // ISSUE: reference to a compiler-generated field
                if (class1060.gclass103_0 == null)
                {
                    int num2 = (int)MessageBox.Show("Please select a formation");
                }
                else
                {
                    this.gclass0_0.gclass42_0 = null;
                    int num3 = (int)new frmMedalAward(this.gclass0_0, this.gclass21_0).ShowDialog();
                    if (this.gclass0_0.gclass42_0 == null)
                        return;
                    string string_4 = "";
                    this.gclass0_0.string_3 = "Enter Optional Citation";
                    this.gclass0_0.string_4 = "";
                    int num4 = (int)new MessageEntry(this.gclass0_0).ShowDialog();
                    if (!this.gclass0_0.bool_21)
                        string_4 = this.gclass0_0.string_4;
                    // ISSUE: reference to a compiler-generated method
                    this.gclass0_0.dictionary_42.Values.FirstOrDefault<GClass55>(class1060.method_0)
                        ?.method_2(this.gclass0_0.gclass42_0, null, string_4);
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1884);
        }
    }

    private void cmdHierarchyMedal_Click(object sender, EventArgs e)
    {
        try
        {
            // ISSUE: object of a compiler-generated type is created
            // ISSUE: variable of a compiler-generated type
            GroundUnitDesign.Class1061 class1061 = new GroundUnitDesign.Class1061();
            // ISSUE: reference to a compiler-generated field
            class1061.list_0 = new List<GroundUnitFormationData>();
            string str = "";
            if (this.gclass21_0 == null)
            {
                int num1 = (int)MessageBox.Show("Please select a race");
            }
            else
            {
                if (this.tvFormations.SelectedNode.Tag is GroundUnitFormationData)
                {
                    GroundUnitFormationData tag = (GroundUnitFormationData)this.tvFormations.SelectedNode.Tag;
                    if (tag == null)
                    {
                        int num2 = (int)MessageBox.Show("Please select a formation");
                        return;
                    }

                    // ISSUE: reference to a compiler-generated field
                    class1061.list_0 = tag.method_22(null, null);
                    str = " to all officers in the hierarchy of " + tag.Name;
                }
                else if (this.tvFormations.SelectedNode.Tag is PopulationData)
                {
                    // ISSUE: object of a compiler-generated type is created
                    // ISSUE: variable of a compiler-generated type
                    GroundUnitDesign.Class1062 class1062 = new GroundUnitDesign.Class1062();
                    // ISSUE: reference to a compiler-generated field
                    class1062.gclass146_0 = (PopulationData)this.tvFormations.SelectedNode.Tag;
                    // ISSUE: reference to a compiler-generated field
                    if (class1062.gclass146_0 == null)
                    {
                        int num3 = (int)MessageBox.Show("Please select a Population");
                        return;
                    }

                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated method
                    class1061.list_0 = this.gclass0_0.FormationDictionary.Values.Where<GroundUnitFormationData>(class1062.method_0)
                        .ToList<GroundUnitFormationData>();
                    // ISSUE: reference to a compiler-generated field
                    str = " to all officers in formations based on " + class1062.gclass146_0.PopName;
                }

                this.gclass0_0.gclass42_0 = null;
                int num4 = (int)new frmMedalAward(this.gclass0_0, this.gclass21_0).ShowDialog();
                if (this.gclass0_0.gclass42_0 == null ||
                    MessageBox.Show($" Are you sure you want to award the {this.gclass0_0.gclass42_0.MedalName}{str}?",
                        "Confirmation Required", MessageBoxButtons.YesNo) != DialogResult.Yes)
                    return;
                // ISSUE: reference to a compiler-generated method
                this.gclass21_0.method_109(
                    this.gclass0_0.dictionary_42.Values.Where<GClass55>(gclass55_0 => gclass55_0.gclass103_0 != null)
                        .Where<GClass55>(class1061.method_0).ToList<GClass55>(), this.gclass0_0.gclass42_0);
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1885);
        }
    }

    private void cmdRemoveParent_Click(object sender, EventArgs e)
    {
        try
        {
            if (!(this.tvFormations.SelectedNode.Tag is GroundUnitFormationData))
                return;
            GroundUnitFormationData tag = (GroundUnitFormationData)this.tvFormations.SelectedNode.Tag;
            if (tag == null)
                return;
            tag.ParentFormationData = null;
            this.gclass21_0.method_365(this.tvFormations, this.chkLocation.CheckState, this.chkPosition.CheckState,
                this.chkElements.CheckState, this.chkShowSupport.CheckState, this.chkCivilian.CheckState,
                this.chkCreationDate.CheckState, this.chkShips.CheckState);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1886);
        }
    }

    private void cmdAssignSupport_Click(object sender, EventArgs e)
    {
        try
        {
            if (!(this.tvFormations.SelectedNode.Tag is GroundUnitFormationData))
                return;
            // ISSUE: object of a compiler-generated type is created
            // ISSUE: variable of a compiler-generated type
            GroundUnitDesign.Class1063 class1063 = new GroundUnitDesign.Class1063();
            // ISSUE: reference to a compiler-generated field
            class1063.gclass103_0 = (GroundUnitFormationData)this.tvFormations.SelectedNode.Tag;
            // ISSUE: reference to a compiler-generated field
            if (class1063.gclass103_0 == null)
                return;
            FCTShipData40 selectedValue = (FCTShipData40)this.cboAssign.SelectedValue;
            if (selectedValue == null)
                return;
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            int num1 = this.gclass0_0.FCTShipDataDictionary.Values.Where<FCTShipData40>(class1063.method_0)
                .Count<FCTShipData40>(class1063.method_1);
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            int num2 = 6 * this.gclass0_0.FCTShipDataDictionary.Values.Where<FCTShipData40>(class1063.method_2)
                .Count<FCTShipData40>(class1063.method_3);
            int num3 = 1;
            if (selectedValue.gclass85_0.method_42(MoveActionType.ProvideOrbitalBombardmentSupport))
                num3 = 6;
            // ISSUE: reference to a compiler-generated field
            int num4 = class1063.gclass103_0.ElementList.Sum<GroundUnitFormationElement>(gclass39_0 =>
                gclass39_0.UnitCount * gclass39_0.GroundUnitClass.GroundUnitComponentList.Sum<GroundComponentTypeDefinition>(gclass100_0 => gclass100_0.FireDirection));
            if (num4 == 0)
                return;
            if (num4 * 6 - num1 - num2 < num3)
            {
                int num5 = (int)MessageBox.Show(
                    "Ground support aircraft or orbital bombardment ships can only be assigned to a ground unit formation that has sufficient forward fire direction units. One FFD is required for six ground support fighters or one ship providing orbital bombardment support",
                    "Attachment Not Possible");
            }
            else
            {
                GroundUnitFormationData gclass1030 = selectedValue.gclass103_0;
                // ISSUE: reference to a compiler-generated field
                selectedValue.gclass103_0 = class1063.gclass103_0;
                if (gclass1030 != null && this.chkShowSupport.CheckState == CheckState.Checked &&
                    !gclass1030.method_12())
                {
                    TreeNode treeNode = this.method_1(gclass1030);
                    if (treeNode != null)
                        treeNode.ForeColor = AuroraUtils.color_16;
                }

                this.tvFormations.SelectedNode.ForeColor = AuroraUtils.color_1;
                TreeNode treeNode1 = this.method_1(selectedValue);
                if (treeNode1 == null)
                    return;
                treeNode1.Text = selectedValue.method_60(this.chkShowSupport.CheckState);
                if (this.chkShowSupport.CheckState != CheckState.Checked)
                    return;
                treeNode1.ForeColor = AuroraUtils.color_0;
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1887);
        }
    }

    private void cmdTemplateAsText_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.lstvTemplate.SelectedItems.Count == 0)
            {
                int num1 = (int)MessageBox.Show("Please select a template");
            }
            else
            {
                ListViewItem selectedItem = this.lstvTemplate.SelectedItems[0];
                this.gclass102_0 = (GroundUnitFormationTemplateData)this.lstvTemplate.SelectedItems[0].Tag;
                if (this.gclass102_0 == null)
                    return;
                int num2 = (int)new PopulationText(this.gclass102_0, this.gclass0_0).ShowDialog();
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1888);
        }
    }

    private void cmdTotalForceText_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass21_0 == null)
                return;
            int num = (int)new PopulationText(this.gclass21_0, GEnum127.const_1, this.gclass0_0).ShowDialog();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1889);
        }
    }

    private void chkNonCombatUnit_CheckedChanged(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass0_0.bool_9)
                return;
            this.method_7();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1890);
        }
    }

    private void method_12(object sender, EventArgs e)
    {
    }

    private void cmdClearSupport_Click(object sender, EventArgs e)
    {
        try
        {
            if (!(this.tvFormations.SelectedNode.Tag is GroundUnitFormationData))
                return;
            GroundUnitFormationData tag = (GroundUnitFormationData)this.tvFormations.SelectedNode.Tag;
            if (tag == null)
                return;
            tag.AssignedFormationData = null;
            this.gclass21_0.method_365(this.tvFormations, this.chkLocation.CheckState, this.chkPosition.CheckState,
                this.chkElements.CheckState, this.chkShowSupport.CheckState, this.chkCivilian.CheckState,
                this.chkCreationDate.CheckState, this.chkShips.CheckState);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1886);
        }
    }

    private void txtNumUnit_Leave(object sender, EventArgs e)
    {
        try
        {
            ParsedDecimal gclass208 = AuroraUtils.ParseDecimalString(this.txtNumUnit.Text);
            if (!gclass208.Succeed || !(gclass208.Value <= 0M))
                return;
            this.txtNumUnit.Text = "1";
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3211);
        }
    }

    private void txtHQCapacity_Leave(object sender, EventArgs e)
    {
        try
        {
            ParsedDecimal gclass208 = AuroraUtils.ParseDecimalString(this.txtHQCapacity.Text);
            if (!gclass208.Succeed || !(gclass208.Value <= 0M))
                return;
            this.txtHQCapacity.Text = "1";
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3212);
        }
    }

    private void chkShowCivilian_CheckedChanged(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass21_0 == null)
                return;
            this.gclass21_0.method_212(this.lstvUnitClass, this.chkShowObsolete.CheckState,
                this.chkShowCivilian.CheckState);
            this.gclass21_0.method_214(this.lstvTemplate, null, this.chkShowCivilian.CheckState, null,
                this.chkShowObsoleteTemplates.CheckState);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1883);
        }
    }

    private void GroundUnitDesign_KeyDown(object sender, KeyEventArgs e)
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
            AuroraUtils.ShowExceptionPopup(ex, 3280);
        }
    }

    private void tvUnitSeries_DragEnter(object sender, DragEventArgs e)
    {
        try
        {
            e.Effect = DragDropEffects.Move;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3341);
        }
    }

    private void tvUnitSeries_ItemDrag(object sender, ItemDragEventArgs e)
    {
        try
        {
            int num = (int)this.DoDragDrop(e.Item, DragDropEffects.Move);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3342);
        }
    }

    private void method_13(GroundUnitSeriesData gclass94_0)
    {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        GroundUnitDesign.Class1064 class1064 = new GroundUnitDesign.Class1064();
        // ISSUE: reference to a compiler-generated field
        class1064.gclass94_0 = gclass94_0;
        try
        {
            // ISSUE: reference to a compiler-generated method
            List<GroundUnitSeriesClassData> list = this.gclass21_0.GroundUnitSeriesClassList.Where<GroundUnitSeriesClassData>(class1064.method_0)
                .OrderBy<GroundUnitSeriesClassData, int>(gclass95_0 => gclass95_0.Priority).ToList<GroundUnitSeriesClassData>();
            int num = 1;
            foreach (GroundUnitSeriesClassData gclass95 in list)
            {
                gclass95.Priority = num;
                ++num;
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3344);
        }
    }

    private void method_14(GroundUnitSeriesData gclass94_0, int int_0)
    {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        GroundUnitDesign.Class1065 class1065 = new GroundUnitDesign.Class1065();
        // ISSUE: reference to a compiler-generated field
        class1065.gclass94_0 = gclass94_0;
        // ISSUE: reference to a compiler-generated field
        class1065.int_0 = int_0;
        try
        {
            // ISSUE: reference to a compiler-generated method
            foreach (GroundUnitSeriesClassData gclass95 in this.gclass21_0.GroundUnitSeriesClassList.Where<GroundUnitSeriesClassData>(class1065.method_0)
                         .ToList<GroundUnitSeriesClassData>())
                ++gclass95.Priority;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3344);
        }
    }

    private void tvUnitSeries_DragDrop(object sender, DragEventArgs e)
    {
        try
        {
            TreeNode nodeAt = this.tvUnitSeries.GetNodeAt(this.tvUnitSeries.PointToClient(new Point(e.X, e.Y)));
            TreeNode data = (TreeNode)e.Data.GetData(typeof(TreeNode));
            if (nodeAt == null && data.Tag is GroundUnitSeriesClassData)
            {
                GroundUnitSeriesClassData tag = (GroundUnitSeriesClassData)data.Tag;
                this.gclass21_0.GroundUnitSeriesClassList.Remove(tag);
                this.method_13(tag.UnitSeriesData);
                this.gclass21_0.method_358(this.tvUnitSeries, this.tvUnassigned);
            }
            else
            {
                if (data.Equals(nodeAt) || nodeAt == null)
                    return;
                if (data.Tag is GroundUnitClass101 && nodeAt.Tag is GroundUnitSeriesData)
                {
                    // ISSUE: object of a compiler-generated type is created
                    // ISSUE: variable of a compiler-generated type
                    GroundUnitDesign.Class1066 class1066 = new GroundUnitDesign.Class1066();
                    GroundUnitClass101 tag = (GroundUnitClass101)data.Tag;
                    // ISSUE: reference to a compiler-generated field
                    class1066.gclass94_0 = (GroundUnitSeriesData)nodeAt.Tag;
                    int int_1 = 1;
                    // ISSUE: reference to a compiler-generated method
                    List<GroundUnitSeriesClassData> list = this.gclass21_0.GroundUnitSeriesClassList.Where<GroundUnitSeriesClassData>(class1066.method_0)
                        .ToList<GroundUnitSeriesClassData>();
                    if (list.Count > 0)
                        int_1 = list.Max<GroundUnitSeriesClassData>(gclass95_0 => gclass95_0.Priority) + 1;
                    // ISSUE: reference to a compiler-generated field
                    this.gclass21_0.GroundUnitSeriesClassList.Add(new GroundUnitSeriesClassData(class1066.gclass94_0, tag, int_1));
                }
                else if (data.Tag is GroundUnitClass101 && nodeAt.Tag is GroundUnitSeriesClassData)
                {
                    GroundUnitClass101 tag1 = (GroundUnitClass101)data.Tag;
                    GroundUnitSeriesClassData tag2 = (GroundUnitSeriesClassData)nodeAt.Tag;
                    int int0 = tag2.Priority;
                    this.method_14(tag2.UnitSeriesData, tag2.Priority);
                    this.gclass21_0.GroundUnitSeriesClassList.Add(new GroundUnitSeriesClassData(tag2.UnitSeriesData, tag1, int0));
                }
                else if (data.Tag is GroundUnitSeriesClassData && nodeAt.Tag is GroundUnitSeriesData)
                {
                    // ISSUE: object of a compiler-generated type is created
                    // ISSUE: variable of a compiler-generated type
                    GroundUnitDesign.Class1067 class1067 = new GroundUnitDesign.Class1067();
                    GroundUnitSeriesClassData tag = (GroundUnitSeriesClassData)data.Tag;
                    // ISSUE: reference to a compiler-generated field
                    class1067.gclass94_0 = (GroundUnitSeriesData)nodeAt.Tag;
                    this.gclass21_0.GroundUnitSeriesClassList.Remove(tag);
                    this.method_13(tag.UnitSeriesData);
                    int num = 1;
                    // ISSUE: reference to a compiler-generated method
                    List<GroundUnitSeriesClassData> list = this.gclass21_0.GroundUnitSeriesClassList.Where<GroundUnitSeriesClassData>(class1067.method_0)
                        .ToList<GroundUnitSeriesClassData>();
                    if (list.Count > 0)
                        num = list.Max<GroundUnitSeriesClassData>(gclass95_0 => gclass95_0.Priority) + 1;
                    tag.Priority = num;
                    // ISSUE: reference to a compiler-generated field
                    tag.UnitSeriesData = class1067.gclass94_0;
                    this.gclass21_0.GroundUnitSeriesClassList.Add(tag);
                }
                else if (data.Tag is GroundUnitSeriesClassData && nodeAt.Tag is GroundUnitSeriesClassData)
                {
                    GroundUnitSeriesClassData tag3 = (GroundUnitSeriesClassData)data.Tag;
                    GroundUnitSeriesClassData tag4 = (GroundUnitSeriesClassData)nodeAt.Tag;
                    this.gclass21_0.GroundUnitSeriesClassList.Remove(tag3);
                    this.method_13(tag3.UnitSeriesData);
                    int int0 = tag4.Priority;
                    this.method_14(tag4.UnitSeriesData, tag4.Priority);
                    tag3.Priority = int0;
                    tag3.UnitSeriesData = tag4.UnitSeriesData;
                    this.gclass21_0.GroundUnitSeriesClassList.Add(tag3);
                }

                this.gclass21_0.method_358(this.tvUnitSeries, this.tvUnassigned);
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3343);
        }
    }

    private void tvUnitSeries_AfterExpand(object sender, TreeViewEventArgs e)
    {
        try
        {
            if (this.gclass0_0.bool_9 || !(e.Node.Tag is GroundUnitSeriesData))
                return;
            ((GroundUnitSeriesData)e.Node.Tag).bool_0 = true;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3345);
        }
    }

    private void tvUnitSeries_AfterCollapse(object sender, TreeViewEventArgs e)
    {
        try
        {
            if (this.gclass0_0.bool_9 || !(e.Node.Tag is GroundUnitSeriesData))
                return;
            ((GroundUnitSeriesData)e.Node.Tag).bool_0 = false;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3346);
        }
    }

    private void tvUnassigned_AfterCollapse(object sender, TreeViewEventArgs e)
    {
        try
        {
            if (this.gclass0_0.bool_9 || !(e.Node.Tag is GroundUnitBaseTypeData))
                return;
            ((GroundUnitBaseTypeData)e.Node.Tag).bool_0 = false;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3347);
        }
    }

    private void tvUnassigned_AfterExpand(object sender, TreeViewEventArgs e)
    {
        try
        {
            if (this.gclass0_0.bool_9 || !(e.Node.Tag is GroundUnitBaseTypeData))
                return;
            ((GroundUnitBaseTypeData)e.Node.Tag).bool_0 = true;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3348);
        }
    }

    private void tvUnassigned_ItemDrag(object sender, ItemDragEventArgs e)
    {
        try
        {
            int num = (int)this.DoDragDrop(e.Item, DragDropEffects.Move);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3349);
        }
    }

    private void tvUnassigned_DragEnter(object sender, DragEventArgs e)
    {
        try
        {
            e.Effect = DragDropEffects.Move;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3350);
        }
    }

    private void tvUnassigned_AfterSelect(object sender, TreeViewEventArgs e)
    {
        try
        {
            if (this.gclass0_0.bool_9 || this.tvUnassigned.SelectedNode == null ||
                this.tvUnassigned.SelectedNode.Tag == null || !(this.tvUnassigned.SelectedNode.Tag is GroundUnitClass101))
                return;
            ((GroundUnitClass101)this.tvUnassigned.SelectedNode.Tag)?.method_9(this.txtClassDisplay, true, true);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3352);
        }
    }

    private void cmdCreateSeries_Click(object sender, EventArgs e)
    {
        try
        {
            this.gclass0_0.string_3 = "Enter New Ground Unit Series Name";
            this.gclass0_0.string_4 = "New Series";
            int num = (int)new MessageEntry(this.gclass0_0).ShowDialog();
            if (this.gclass0_0.bool_21)
                return;
            GroundUnitSeriesData gclass94 = new GroundUnitSeriesData();
            gclass94.GroundUnitSeriesID = this.gclass0_0.method_26(GEnum0.const_50);
            gclass94.Description = this.gclass0_0.string_4;
            this.gclass21_0.GroundUnitSeriesDictionary.Add(gclass94.GroundUnitSeriesID, gclass94);
            this.gclass21_0.method_358(this.tvUnitSeries, this.tvUnassigned);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3353);
        }
    }

    private void cmdRenameSeries_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass0_0.bool_9)
                return;
            if (!(this.tvUnitSeries.SelectedNode.Tag is GroundUnitSeriesData))
            {
                int num1 = (int)MessageBox.Show("Please select a ground unit series to delete");
            }
            else
            {
                GroundUnitSeriesData tag = (GroundUnitSeriesData)this.tvUnitSeries.SelectedNode.Tag;
                if (tag == null)
                    return;
                this.gclass0_0.string_3 = "Enter Formation Name";
                this.gclass0_0.string_4 = tag.Description;
                int num2 = (int)new MessageEntry(this.gclass0_0).ShowDialog();
                if (this.gclass0_0.string_4 != "")
                    tag.Description = this.gclass0_0.string_4;
                this.tvUnitSeries.SelectedNode.Text = tag.Description;
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3355);
        }
    }

    private void cmdDeleteSeries_Click(object sender, EventArgs e)
    {
        try
        {
            // ISSUE: object of a compiler-generated type is created
            // ISSUE: variable of a compiler-generated type
            GroundUnitDesign.Class1049 class1049 = new GroundUnitDesign.Class1049();
            if (this.gclass0_0.bool_9 || this.tvUnitSeries.SelectedNode == null)
                return;
            if (!(this.tvUnitSeries.SelectedNode.Tag is GroundUnitSeriesData))
            {
                int num = (int)MessageBox.Show("Please select a ground unit series to delete");
            }
            else
            {
                // ISSUE: reference to a compiler-generated field
                class1049.gclass94_0 = (GroundUnitSeriesData)this.tvUnitSeries.SelectedNode.Tag;
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                if (class1049.gclass94_0 == null ||
                    MessageBox.Show(
                        $"Are you sure you want to delete the ground unit series '{class1049.gclass94_0.Description}'?",
                        "Confirm Delete", MessageBoxButtons.YesNo) != DialogResult.Yes)
                    return;
                // ISSUE: reference to a compiler-generated method
                List<GroundUnitSeriesClassData> list = this.gclass21_0.GroundUnitSeriesClassList.Where<GroundUnitSeriesClassData>(class1049.method_0).ToList<GroundUnitSeriesClassData>();
                // ISSUE: reference to a compiler-generated field
                this.gclass21_0.GroundUnitSeriesDictionary.Remove(class1049.gclass94_0.GroundUnitSeriesID);
                foreach (GroundUnitSeriesClassData gclass95 in list)
                    this.gclass21_0.GroundUnitSeriesClassList.Remove(gclass95);
                this.gclass21_0.method_358(this.tvUnitSeries, this.tvUnassigned);
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3356);
        }
    }

    private void cmdReplacementTemplate_Click(object sender, EventArgs e)
    {
        try
        {
            // ISSUE: object of a compiler-generated type is created
            // ISSUE: variable of a compiler-generated type
            GroundUnitDesign.Class1050 class1050 = new GroundUnitDesign.Class1050();
            if (this.tvFormations.SelectedNode.Tag == null)
                return;
            if (!(this.tvFormations.SelectedNode.Tag is GroundUnitFormationData))
            {
                int num1 = (int)MessageBox.Show("Replacement Template can only be set for formations");
            }
            else
            {
                // ISSUE: reference to a compiler-generated field
                class1050.gclass103_0 = (GroundUnitFormationData)this.tvFormations.SelectedNode.Tag;
                // ISSUE: reference to a compiler-generated field
                if (class1050.gclass103_0 == null)
                    return;
                this.gclass0_0.string_3 = "Select Replacement Template";
                this.gclass0_0.string_7 = "Update all formations with same replacement template";
                this.gclass0_0.string_8 = "";
                this.gclass0_0.string_9 = "";
                this.gclass0_0.list_32 = new List<string>();
                foreach (GroundUnitFormationTemplateData gclass102 in this.gclass0_0.FormationTemplateRecordDic.Values
                             .Where<GroundUnitFormationTemplateData>(gclass102_1 =>
                                 gclass102_1.RaceData == this.gclass21_0 &&
                                 gclass102_1.AutomatedTemplateType != AutomatedGroundTemplateDesignType.CivilianGarrison)
                             .OrderBy<GroundUnitFormationTemplateData, string>(gclass102_0 => gclass102_0.Name).ToList<GroundUnitFormationTemplateData>())
                    this.gclass0_0.list_32.Add(gclass102.Name);
                int num2 = (int)new UserSelection(this.gclass0_0).ShowDialog();
                if (this.gclass0_0.bool_21)
                    return;
                int num3 = AuroraUtils.smethod_27(this.gclass0_0.checkState_0) ? 1 : 0;
                GroundUnitFormationTemplateData gclass102_2 =
                    this.gclass0_0.FormationTemplateRecordDic.Values.FirstOrDefault<GroundUnitFormationTemplateData>(gclass102_1 =>
                        gclass102_1.Name == this.gclass0_0.string_4);
                if (num3 != 0)
                {
                    // ISSUE: reference to a compiler-generated method
                    foreach (GroundUnitFormationData gclass103 in this.gclass0_0.FormationDictionary.Values
                                 .Where<GroundUnitFormationData>(gclass103_0 =>
                                     gclass103_0.RaceData == this.gclass21_0 && gclass103_0.ReplacementTemplateData != null)
                                 .Where<GroundUnitFormationData>(class1050.method_0).ToList<GroundUnitFormationData>())
                        gclass103.ReplacementTemplateData = gclass102_2;
                }
                else
                {
                    // ISSUE: reference to a compiler-generated field
                    class1050.gclass103_0.ReplacementTemplateData = gclass102_2;
                }

                // ISSUE: reference to a compiler-generated field
                this.txtReplacementTemplate.Text = class1050.gclass103_0.ReplacementTemplateData.Name;
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1870);
        }
    }

    private void chkUseForReplacements_CheckedChanged(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass0_0.bool_9)
                return;
            GroundUnitFormationData tag = (GroundUnitFormationData)this.tvFormations.SelectedNode.Tag;
            if (tag == null)
                return;
            CheckBox checkBox = (CheckBox)sender;
            tag.bUseForReplacements = AuroraUtils.smethod_27(checkBox.CheckState);
            if (!tag.bUseForReplacements)
                return;
            tag.ReplacementTemplateData = null;
            this.txtReplacementTemplate.Text = "None";
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3357);
        }
    }

    private void txtPriority_TextChanged(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass0_0.bool_9)
                return;
            GroundUnitFormationData tag = (GroundUnitFormationData)this.tvFormations.SelectedNode.Tag;
            if (tag == null)
                return;
            int result = 10;
            if (!int.TryParse(this.txtPriority.Text, out result))
                return;
            tag.ReplacementPriority = result;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3359);
        }
    }

    private void cmdScrapFormation_Click(object sender, EventArgs e)
    {
        try
        {
            // ISSUE: object of a compiler-generated type is created
            // ISSUE: variable of a compiler-generated type
            GroundUnitDesign.Class1051 class1051 = new GroundUnitDesign.Class1051();
            if (this.gclass0_0.bool_9 || this.tvFormations.SelectedNode == null)
                return;
            if (!(this.tvFormations.SelectedNode.Tag is GroundUnitFormationData))
            {
                int num1 = (int)MessageBox.Show("Please select a formation to scrap");
            }
            else
            {
                // ISSUE: reference to a compiler-generated field
                class1051.gclass103_0 = (GroundUnitFormationData)this.tvFormations.SelectedNode.Tag;
                // ISSUE: reference to a compiler-generated field
                if (class1051.gclass103_0 == null)
                    return;
                // ISSUE: reference to a compiler-generated field
                if (class1051.gclass103_0.PopulationData == null)
                {
                    int num2 = (int)MessageBox.Show("Only formations based at a population can be scrapped");
                }
                else
                {
                    // ISSUE: reference to a compiler-generated field
                    if (MessageBox.Show($"Are you sure you want to scrap the formation '{class1051.gclass103_0.Name}'?",
                            "Confirm Delete", MessageBoxButtons.YesNo) != DialogResult.Yes)
                        return;
                    // ISSUE: reference to a compiler-generated field
                    foreach (GroundUnitFormationElement gclass39_0 in class1051.gclass103_0.ElementList)
                    {
                        // ISSUE: reference to a compiler-generated field
                        class1051.gclass103_0.PopulationData.method_52(gclass39_0);
                    }

                    // ISSUE: reference to a compiler-generated field
                    if (class1051.gclass103_0.gclass55_0 != null)
                    {
                        // ISSUE: reference to a compiler-generated field
                        class1051.gclass103_0.gclass55_0.method_40(true);
                    }

                    // ISSUE: reference to a compiler-generated method
                    foreach (GroundUnitFormationData gclass103 in this.gclass0_0.FormationDictionary.Values
                                 .Where<GroundUnitFormationData>(class1051.method_0).ToList<GroundUnitFormationData>())
                        gclass103.ParentFormationData = null;
                    // ISSUE: reference to a compiler-generated field
                    this.gclass0_0.FormationDictionary.Remove(class1051.gclass103_0.FormationID);
                    this.gclass21_0.method_365(this.tvFormations, this.chkLocation.CheckState,
                        this.chkPosition.CheckState, this.chkElements.CheckState, this.chkShowSupport.CheckState,
                        this.chkCivilian.CheckState, this.chkCreationDate.CheckState, this.chkShips.CheckState);
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1880);
        }
    }

    private void tvUnitSeries_AfterSelect(object sender, TreeViewEventArgs e)
    {
        try
        {
            if (this.gclass0_0.bool_9 || this.tvUnitSeries.SelectedNode == null ||
                this.tvUnitSeries.SelectedNode.Tag == null || !(this.tvUnitSeries.SelectedNode.Tag is GroundUnitSeriesClassData))
                return;
            ((GroundUnitSeriesClassData)this.tvUnitSeries.SelectedNode.Tag)?.UnitClass.method_9(this.txtClassDisplay, true, true);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3584 /*0x0E00*/);
        }
    }

    private void flowLayoutPanel9_Paint(object sender, PaintEventArgs e)
    {
    }

    private void cmdUpdateTemp_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.lstvTemplate.SelectedItems.Count == 0)
                return;
            ListViewItem selectedItem = this.lstvTemplate.SelectedItems[0];
            this.gclass102_0 = (GroundUnitFormationTemplateData)this.lstvTemplate.SelectedItems[0].Tag;
            if (this.gclass102_0 == null)
            {
                int num = (int)MessageBox.Show("Please select an existing template");
            }
            else
            {
                if (this.gclass21_0 == null)
                    return;
                GroundUnitFormationTemplateData gclass102_0 = this.gclass21_0.method_211(this.gclass102_0);
                if (gclass102_0 == null)
                    return;
                this.gclass21_0.method_214(this.lstvTemplate, null, this.chkShowCivilian.CheckState, gclass102_0,
                    this.chkShowObsoleteTemplates.CheckState);
                this.gclass21_0.method_212(this.lstvUnitClass, this.chkShowObsolete.CheckState,
                    this.chkShowCivilian.CheckState);
                this.gclass21_0.method_358(this.tvUnitSeries, this.tvUnassigned);
                this.gclass21_0.method_359(this.tvOrganization, this.tvTemplateNodes);
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3591);
        }
    }

    private void cmdCreateOrg_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass21_0 == null)
                return;
            this.gclass0_0.string_3 = "Enter Organization Name";
            this.gclass0_0.string_4 = "New Organization";
            int num = (int)new MessageEntry(this.gclass0_0).ShowDialog();
            if (this.gclass0_0.bool_21)
                return;
            this.gclass21_0.method_205(null, null, this.gclass0_0.string_4);
            this.gclass21_0.method_359(this.tvOrganization, this.tvTemplateNodes);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3600);
        }
    }

    private void tvOrganization_ItemDrag(object sender, ItemDragEventArgs e)
    {
        try
        {
            int num = (int)this.DoDragDrop(e.Item, DragDropEffects.Move);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3601);
        }
    }

    private void tvTemplateNodes_ItemDrag(object sender, ItemDragEventArgs e)
    {
        try
        {
            int num = (int)this.DoDragDrop(e.Item, DragDropEffects.Move);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3602);
        }
    }

    private void tvOrganization_DragEnter(object sender, DragEventArgs e)
    {
        try
        {
            e.Effect = DragDropEffects.Move;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3603);
        }
    }

    private void tvTemplateNodes_AfterSelect(object sender, TreeViewEventArgs e)
    {
    }

    private void tvTemplateNodes_DragEnter(object sender, DragEventArgs e)
    {
        try
        {
            e.Effect = DragDropEffects.Move;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3604);
        }
    }

    private void tvOrganization_AfterSelect(object sender, TreeViewEventArgs e)
    {
        try
        {
            if (this.gclass0_0.bool_9 || this.tvOrganization.SelectedNode == null ||
                this.tvOrganization.SelectedNode.Tag == null ||
                !(this.tvOrganization.SelectedNode.Tag is OrganizationNodeC93))
                return;
            OrganizationNodeC93 tag = (OrganizationNodeC93)this.tvOrganization.SelectedNode.Tag;
            if (tag == null)
                return;
            this.gclass21_0.method_208(this.lstvOrgSummary, tag);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3584 /*0x0E00*/);
        }
    }

    private void tvOrganization_AfterExpand(object sender, TreeViewEventArgs e)
    {
        try
        {
            if (this.gclass0_0.bool_9 || !(e.Node.Tag is OrganizationNodeC93))
                return;
            ((OrganizationNodeC93)e.Node.Tag).NodeExpanded = true;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3605);
        }
    }

    private void tvOrganization_AfterCollapse(object sender, TreeViewEventArgs e)
    {
        try
        {
            if (this.gclass0_0.bool_9 || !(e.Node.Tag is OrganizationNodeC93))
                return;
            ((OrganizationNodeC93)e.Node.Tag).NodeExpanded = false;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3605);
        }
    }

    private void tvTemplateNodes_AfterCollapse(object sender, TreeViewEventArgs e)
    {
        try
        {
            if (this.gclass0_0.bool_9 || !(e.Node.Tag is OrganizationNodeC93))
                return;
            ((OrganizationNodeC93)e.Node.Tag).NodeExpanded = false;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3608);
        }
    }

    private void tvTemplateNodes_AfterExpand(object sender, TreeViewEventArgs e)
    {
        try
        {
            if (this.gclass0_0.bool_9 || !(e.Node.Tag is OrganizationNodeC93))
                return;
            ((OrganizationNodeC93)e.Node.Tag).NodeExpanded = true;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3609);
        }
    }

    private void tvOrganization_DragDrop(object sender, DragEventArgs e)
    {
        try
        {
            if (this.gclass21_0 == null)
                return;
            TreeNode nodeAt = this.tvOrganization.GetNodeAt(this.tvOrganization.PointToClient(new Point(e.X, e.Y)));
            TreeNode data = (TreeNode)e.Data.GetData(typeof(TreeNode));
            if (nodeAt == null || data.Equals(nodeAt) || nodeAt == null)
                return;
            if (data.Tag is GroundUnitFormationElement)
            {
                int num1 = (int)MessageBox.Show(
                    "Elements are for display purposes only and cannot be used to build organizations");
            }
            else
            {
                if (!(data.Tag is OrganizationNodeC93) || !(nodeAt.Tag is OrganizationNodeC93))
                    return;
                OrganizationNodeC93 tag1 = (OrganizationNodeC93)data.Tag;
                OrganizationNodeC93 tag2 = (OrganizationNodeC93)nodeAt.Tag;
                for (OrganizationNodeC93 gclass93 = tag2;
                     gclass93.ParentOrganizationNode != null;
                     gclass93 = gclass93.ParentOrganizationNode)
                {
                    if (gclass93.ParentOrganizationNode == tag1)
                    {
                        int num2 = (int)MessageBox.Show(
                            "You cannot drag a node to a lower level of its own organization. This would create an endless hierarchy");
                        return;
                    }
                }

                if (tag1.ParentOrganizationNode == null)
                    this.gclass21_0.method_207(tag1, tag2);
                else
                    tag1.ParentOrganizationNode = tag2;
                this.gclass21_0.method_359(this.tvOrganization, this.tvTemplateNodes);
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3343);
        }
    }

    private void cmdConstructOrganization_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass0_0.bool_9 || this.tvOrganization.SelectedNode == null ||
                this.tvOrganization.SelectedNode.Tag == null ||
                !(this.tvOrganization.SelectedNode.Tag is OrganizationNodeC93))
                return;
            OrganizationNodeC93 tag = (OrganizationNodeC93)this.tvOrganization.SelectedNode.Tag;
            if (tag == null)
                return;
            if (tag.ParentOrganizationNode != null)
            {
                int num1 = (int)MessageBox.Show(
                    "Only Organization Nodes with no parent can be used as the basis for construction tasks");
            }
            else
            {
                PopulationData selectedValue = (PopulationData)this.cboPopulations.SelectedValue;
                if (selectedValue == null)
                {
                    int num2 = (int)MessageBox.Show(
                        "Construction tasks require a population with at least one ground force construction complex");
                }
                else
                {
                    this.gclass21_0.method_362(tag, selectedValue, 0, this.chkEnterNames.CheckState);
                    selectedValue.method_14();
                    foreach (Economics economics in Application.OpenForms.OfType<Economics>())
                        economics.method_9();
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3612);
        }
    }

    private void cmdDeleteNode_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass0_0.bool_9 || this.tvOrganization.SelectedNode == null ||
                this.tvOrganization.SelectedNode.Tag == null ||
                !(this.tvOrganization.SelectedNode.Tag is OrganizationNodeC93))
                return;
            OrganizationNodeC93 tag = (OrganizationNodeC93)this.tvOrganization.SelectedNode.Tag;
            if (tag == null)
                return;
            this.gclass21_0.method_206(tag);
            this.gclass21_0.method_359(this.tvOrganization, this.tvTemplateNodes);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3612);
        }
    }

    private void cmdNodeFieldPosition_Click(object sender, EventArgs e)
    {
        try
        {
            // ISSUE: object of a compiler-generated type is created
            // ISSUE: variable of a compiler-generated type
            GroundUnitDesign.Class1052 class1052 = new GroundUnitDesign.Class1052();
            if (this.tvOrganization.SelectedNode.Tag == null ||
                !(this.tvOrganization.SelectedNode.Tag is OrganizationNodeC93))
                return;
            // ISSUE: reference to a compiler-generated field
            class1052.gclass93_0 = (OrganizationNodeC93)this.tvOrganization.SelectedNode.Tag;
            // ISSUE: reference to a compiler-generated field
            if (class1052.gclass93_0 == null)
                return;
            this.gclass0_0.string_3 = "Select Field Position for Node";
            this.gclass0_0.string_7 = "Set Field Position for all Subordinate Nodes";
            this.gclass0_0.string_8 = "Set Field Position ONLY for Subordinate Nodes";
            this.gclass0_0.string_9 = "Set all Templates of this type in any org structuren";
            this.gclass0_0.list_32 = new List<string>();
            Dictionary<AuroraGroundFormationFieldPosition, string> source =
                new Dictionary<AuroraGroundFormationFieldPosition, string>();
            foreach (AuroraGroundFormationFieldPosition formationFieldPosition in Enum.GetValues(
                         typeof(AuroraGroundFormationFieldPosition)))
            {
                source.Add(formationFieldPosition, AuroraUtils.smethod_82(formationFieldPosition));
                this.gclass0_0.list_32.Add(AuroraUtils.smethod_82(formationFieldPosition));
            }

            int num1 = (int)new UserSelection(this.gclass0_0).ShowDialog();
            if (this.gclass0_0.bool_21)
                return;
            AuroraGroundFormationFieldPosition key = source
                .FirstOrDefault<KeyValuePair<AuroraGroundFormationFieldPosition, string>>(keyValuePair_0 =>
                    keyValuePair_0.Value == this.gclass0_0.string_4).Key;
            int num2 = AuroraUtils.smethod_27(this.gclass0_0.checkState_0) ? 1 : 0;
            bool flag1 = AuroraUtils.smethod_27(this.gclass0_0.checkState_1);
            bool flag2 = AuroraUtils.smethod_27(this.gclass0_0.checkState_2);
            if (!flag1)
            {
                // ISSUE: reference to a compiler-generated field
                class1052.gclass93_0.FieldPosition = key;
            }

            if (num2 != 0 || flag1)
            {
                // ISSUE: reference to a compiler-generated field
                this.gclass21_0.method_361(class1052.gclass93_0, key);
            }

            // ISSUE: reference to a compiler-generated field
            if (flag2 && class1052.gclass93_0.FormationTemplate != null)
            {
                // ISSUE: reference to a compiler-generated method
                foreach (OrganizationNodeC93 gclass93 in this.gclass21_0.OrganizationNodeDictionary.Values
                             .Where<OrganizationNodeC93>(class1052.method_0).ToList<OrganizationNodeC93>())
                    gclass93.FieldPosition = key;
            }

            this.gclass21_0.method_359(this.tvOrganization, this.tvTemplateNodes);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3620);
        }
    }

    private void cmdInstantOrg_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass0_0.bool_9 || this.tvOrganization.SelectedNode == null ||
                this.tvOrganization.SelectedNode.Tag == null ||
                !(this.tvOrganization.SelectedNode.Tag is OrganizationNodeC93))
                return;
            OrganizationNodeC93 tag = (OrganizationNodeC93)this.tvOrganization.SelectedNode.Tag;
            if (tag == null)
                return;
            if (tag.ParentOrganizationNode != null)
            {
                int num1 = (int)MessageBox.Show(
                    "Only Organization Nodes with no parent can be used as the basis for construction tasks");
            }
            else
            {
                PopulationData selectedValue = (PopulationData)this.cboPopulations.SelectedValue;
                if (selectedValue == null)
                {
                    int num2 = (int)MessageBox.Show(
                        "Construction tasks require a population with at least one ground force construction complex");
                }
                else
                {
                    if (MessageBox.Show($"Are you sure you want to instantly create a {tag.OrganizationName}'?",
                            "Confirm Creation", MessageBoxButtons.YesNo) != DialogResult.Yes)
                        return;
                    this.gclass21_0.method_363(tag, selectedValue, null, this.chkEnterNames.CheckState);
                    this.gclass21_0.method_365(this.tvFormations, this.chkLocation.CheckState,
                        this.chkPosition.CheckState, this.chkElements.CheckState, this.chkShowSupport.CheckState,
                        this.chkCivilian.CheckState, this.chkCreationDate.CheckState, this.chkShips.CheckState);
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3623);
        }
    }

    private void tabPage2_Click(object sender, EventArgs e)
    {
    }

    private void cmdCopyTemp_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.lstvTemplate.SelectedItems.Count == 0)
                return;
            ListViewItem selectedItem = this.lstvTemplate.SelectedItems[0];
            this.gclass102_0 = (GroundUnitFormationTemplateData)this.lstvTemplate.SelectedItems[0].Tag;
            if (this.gclass102_0 == null)
            {
                int num = (int)MessageBox.Show("Please select an existing template");
            }
            else
            {
                if (this.gclass21_0 == null)
                    return;
                GroundUnitFormationTemplateData gclass102_0 = this.gclass21_0.method_204();
                if (gclass102_0 == null)
                    return;
                gclass102_0.RequiredRankData = this.gclass102_0.RequiredRankData;
                foreach (GroundUnitFormationElement gclass39 in this.gclass102_0.FormationElementList)
                    gclass102_0.method_12(gclass39.GroundUnitClass, gclass39.UnitCount);
                this.gclass21_0.method_214(this.lstvTemplate, null, this.chkShowCivilian.CheckState, gclass102_0,
                    this.chkShowObsoleteTemplates.CheckState);
                this.gclass21_0.method_212(this.lstvUnitClass, this.chkShowObsolete.CheckState,
                    this.chkShowCivilian.CheckState);
                this.gclass21_0.method_358(this.tvUnitSeries, this.tvUnassigned);
                this.gclass21_0.method_359(this.tvOrganization, this.tvTemplateNodes);
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3743);
        }
    }

    private void chkShowObsoleteTemplates_CheckedChanged(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass21_0 == null)
                return;
            this.gclass21_0.method_214(this.lstvTemplate, null, this.chkShowCivilian.CheckState, null,
                this.chkShowObsoleteTemplates.CheckState);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3782);
        }
    }

    private void cmdNonCombat_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass21_0 == null)
                return;
            if (this.lstvUnitClass.SelectedItems.Count == 0)
            {
                int num = (int)MessageBox.Show("Please select a unit to toggle non-combat status");
            }
            else
            {
                GroundUnitClass101 tag = (GroundUnitClass101)this.lstvUnitClass.SelectedItems[0].Tag;
                if (tag == null)
                    return;
                tag.bool_0 = !tag.bool_0;
                this.gclass21_0.method_212(this.lstvUnitClass, this.chkShowObsolete.CheckState,
                    this.chkShowCivilian.CheckState);
                AuroraUtils.smethod_0(this.lstvUnitClass, tag);
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3869);
        }
    }

    private void cmdDNR_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass0_0.bool_9)
                return;
            GroundUnitFormationData tag = (GroundUnitFormationData)this.tvFormations.SelectedNode.Tag;
            if (tag == null)
                return;
            tag.bDoNotRecover = tag.bDoNotRecover != 0 ? 0 : 1;
            this.tvFormations.SelectedNode.Text =
                tag.method_25(this.chkPosition.CheckState, this.chkShowSupport.CheckState);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3886);
        }
    }

    private void lstvBaseType_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass0_0.bool_9 || this.lstvBaseType.SelectedItems.Count == 0)
                return;
            this.method_15();
            this.method_7();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1890);
        }
    }

    private void method_15()
    {
        try
        {
            if (this.lstvBaseType.SelectedItems.Count == 0 || !(this.lstvBaseType.SelectedItems[0].Tag is GroundUnitBaseTypeData))
                return;
            this.gclass96_0 = (GroundUnitBaseTypeData)this.lstvBaseType.SelectedItems[0].Tag;
            if (this.gclass96_0 == null)
                return;
            this.gclass0_0.bool_9 = true;
            this.gclass21_0.method_198(this.lstvArmourType, this.gclass96_0.genum112_0);
            this.gclass21_0.method_199(this.lstvPrimary, this.gclass96_0.genum112_0);
            this.cboSecondary.DataSource = null;
            this.cboTertiary.DataSource = null;
            this.cboSecondary.Visible = false;
            this.cboTertiary.Visible = false;
            this.cboQuaternary.Visible = false;
            this.lblSecondary.Visible = false;
            if (this.gclass96_0.genum112_0 == GroundUnitBaseType.const_1 || this.gclass96_0.genum112_0 == GroundUnitBaseType.const_2)
            {
                this.cboSecondary.Visible = true;
                this.lblSecondary.Visible = true;
                this.gclass21_0.method_200(this.cboSecondary, this.gclass96_0.genum112_0);
            }

            if (this.gclass96_0.genum112_0 == GroundUnitBaseType.const_3)
            {
                this.cboSecondary.Visible = true;
                this.cboTertiary.Visible = true;
                this.lblSecondary.Visible = true;
                this.gclass21_0.method_200(this.cboSecondary, this.gclass96_0.genum112_0);
                this.gclass21_0.method_200(this.cboTertiary, this.gclass96_0.genum112_0);
            }

            if (this.gclass96_0.genum112_0 == GroundUnitBaseType.const_4)
            {
                this.cboSecondary.Visible = true;
                this.cboTertiary.Visible = true;
                this.cboQuaternary.Visible = true;
                this.lblSecondary.Visible = true;
                this.gclass21_0.method_200(this.cboSecondary, this.gclass96_0.genum112_0);
                this.gclass21_0.method_200(this.cboTertiary, this.gclass96_0.genum112_0);
                this.gclass21_0.method_200(this.cboQuaternary, this.gclass96_0.genum112_0);
            }

            this.gclass0_0.bool_9 = false;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1891);
        }
    }

    private void method_16()
    {
        try
        {
            this.gclass0_0.list_32.Clear();
            this.dictionary_1.Clear();
            foreach (AuroraTargetSelection auroraTargetSelection in Enum.GetValues(typeof(AuroraTargetSelection)))
            {
                this.dictionary_1.Add(auroraTargetSelection, AuroraUtils.smethod_82(auroraTargetSelection));
                this.gclass0_0.list_32.Add(AuroraUtils.smethod_82(auroraTargetSelection));
            }

            this.cboTargetType.DataSource = this.gclass0_0.list_32;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1892);
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
        this.label8 = new Label();
        this.txtBaseArmour = new TextBox();
        this.txtBaseWeapon = new TextBox();
        this.label9 = new Label();
        this.txtBeamTracking = new TextBox();
        this.label4 = new Label();
        this.txtFCRange = new TextBox();
        this.label1 = new Label();
        this.tabUnitSeries = new TabPage();
        this.txtClassDisplay = new TextBox();
        this.flowLayoutPanel4 = new FlowLayoutPanel();
        this.cmdCreateSeries = new Button();
        this.cmdRenameSeries = new Button();
        this.cmdDeleteSeries = new Button();
        this.tvUnassigned = new TreeView();
        this.tvUnitSeries = new TreeView();
        this.tabPage1 = new TabPage();
        this.txtDistribution = new TextBox();
        this.label2 = new Label();
        this.cboTargetType = new ComboBox();
        this.lstvSTOTargeting = new ListView();
        this.columnHeader_0 = new ColumnHeader();
        this.columnHeader_1 = new ColumnHeader();
        this.columnHeader_2 = new ColumnHeader();
        this.columnHeader_3 = new ColumnHeader();
        this.columnHeader_4 = new ColumnHeader();
        this.columnHeader_5 = new ColumnHeader();
        this.columnHeader_6 = new ColumnHeader();
        this.columnHeader_7 = new ColumnHeader();
        this.columnHeader_8 = new ColumnHeader();
        this.tabUnitClassDesign = new TabPage();
        this.chkNonCombatUnit = new CheckBox();
        this.pnlBlank = new Panel();
        this.flowLayoutPanel6 = new FlowLayoutPanel();
        this.chkPointDefence = new CheckBox();
        this.chkECCM = new CheckBox();
        this.lblHQ = new Label();
        this.txtHQCapacity = new TextBox();
        this.lstvSTO = new ListView();
        this.columnHeader_9 = new ColumnHeader();
        this.columnHeader_10 = new ColumnHeader();
        this.columnHeader_11 = new ColumnHeader();
        this.columnHeader_12 = new ColumnHeader();
        this.columnHeader_13 = new ColumnHeader();
        this.columnHeader_14 = new ColumnHeader();
        this.columnHeader_15 = new ColumnHeader();
        this.columnHeader_16 = new ColumnHeader();
        this.cboQuaternary = new ComboBox();
        this.cboTertiary = new ComboBox();
        this.cboSecondary = new ComboBox();
        this.lblSecondary = new Label();
        this.txtUnitName = new TextBox();
        this.lstvCapability = new ListView();
        this.columnHeader_17 = new ColumnHeader();
        this.columnHeader_18 = new ColumnHeader();
        this.columnHeader_19 = new ColumnHeader();
        this.lstvPrimary = new ListView();
        this.columnHeader_20 = new ColumnHeader();
        this.columnHeader_21 = new ColumnHeader();
        this.columnHeader_22 = new ColumnHeader();
        this.columnHeader_23 = new ColumnHeader();
        this.columnHeader_24 = new ColumnHeader();
        this.columnHeader_25 = new ColumnHeader();
        this.columnHeader_26 = new ColumnHeader();
        this.columnHeader_27 = new ColumnHeader();
        this.lstvArmourType = new ListView();
        this.columnHeader_28 = new ColumnHeader();
        this.columnHeader_29 = new ColumnHeader();
        this.columnHeader_30 = new ColumnHeader();
        this.lstvBaseType = new ListView();
        this.columnHeader_31 = new ColumnHeader();
        this.columnHeader_32 = new ColumnHeader();
        this.columnHeader_33 = new ColumnHeader();
        this.columnHeader_34 = new ColumnHeader();
        this.columnHeader_35 = new ColumnHeader();
        this.columnHeader_36 = new ColumnHeader();
        this.columnHeader_37 = new ColumnHeader();
        this.txtUnitClass = new TextBox();
        this.cmdCreate = new Button();
        this.cmdInstant = new Button();
        this.tabTemplates = new TabPage();
        this.flowLayoutPanel11 = new FlowLayoutPanel();
        this.cmdRenameUnit = new Button();
        this.cmdObsolete = new Button();
        this.cmdNonCombat = new Button();
        this.chkShowCivilian = new CheckBox();
        this.chkShowObsolete = new CheckBox();
        this.cmdAdd = new Button();
        this.txtNumUnit = new TextBox();
        this.flowLayoutPanel9 = new FlowLayoutPanel();
        this.cmdNewFormation = new Button();
        this.cmdRename = new Button();
        this.cmdCopyTemp = new Button();
        this.cmdUpdateTemp = new Button();
        this.cmdTemplateAsText = new Button();
        this.cmdDeleteFormation = new Button();
        this.cmdChangeRank = new Button();
        this.flowLayoutPanel7 = new FlowLayoutPanel();
        this.cmdEditAmount = new Button();
        this.cmdDeleteElement = new Button();
        this.chkShowObsoleteTemplates = new CheckBox();
        this.button1 = new Button();
        this.lstvTemplateUnitList = new ListView();
        this.columnHeader_38 = new ColumnHeader();
        this.columnHeader_39 = new ColumnHeader();
        this.columnHeader_40 = new ColumnHeader();
        this.columnHeader_41 = new ColumnHeader();
        this.columnHeader_42 = new ColumnHeader();
        this.columnHeader_43 = new ColumnHeader();
        this.columnHeader_44 = new ColumnHeader();
        this.txtSelectedClass = new TextBox();
        this.lstvUnitClass = new ListView();
        this.columnHeader_45 = new ColumnHeader();
        this.columnHeader_46 = new ColumnHeader();
        this.columnHeader_47 = new ColumnHeader();
        this.columnHeader_48 = new ColumnHeader();
        this.columnHeader_49 = new ColumnHeader();
        this.columnHeader_50 = new ColumnHeader();
        this.columnHeader_51 = new ColumnHeader();
        this.columnHeader_52 = new ColumnHeader();
        this.lstvTemplate = new ListView();
        this.columnHeader_53 = new ColumnHeader();
        this.columnHeader_54 = new ColumnHeader();
        this.columnHeader_55 = new ColumnHeader();
        this.columnHeader_56 = new ColumnHeader();
        this.columnHeader_57 = new ColumnHeader();
        this.columnHeader_58 = new ColumnHeader();
        this.columnHeader_59 = new ColumnHeader();
        this.columnHeader_60 = new ColumnHeader();
        this.columnHeader_61 = new ColumnHeader();
        this.flowLayoutPanel3 = new FlowLayoutPanel();
        this.tabFormations = new TabPage();
        this.flowLayoutPanel8 = new FlowLayoutPanel();
        this.txtFormationLocation = new TextBox();
        this.label3 = new Label();
        this.txtReplacementTemplate = new TextBox();
        this.label5 = new Label();
        this.txtPriority = new TextBox();
        this.chkUseForReplacements = new CheckBox();
        this.flpAssign = new FlowLayoutPanel();
        this.cmdAssignSupport = new Button();
        this.cboAssign = new ComboBox();
        this.flowLayoutPanel5 = new FlowLayoutPanel();
        this.chkLocation = new CheckBox();
        this.chkShips = new CheckBox();
        this.chkPosition = new CheckBox();
        this.chkElements = new CheckBox();
        this.chkCivilian = new CheckBox();
        this.chkShowSupport = new CheckBox();
        this.chkPartial = new CheckBox();
        this.chkCreationDate = new CheckBox();
        this.flowLayoutPanel2 = new FlowLayoutPanel();
        this.cmdRenameFormation = new Button();
        this.cmdFieldPosition = new Button();
        this.cmdRemoveParent = new Button();
        this.cmdClearSupport = new Button();
        this.cmdReplacementTemplate = new Button();
        this.cmdDNR = new Button();
        this.cmdDelete = new Button();
        this.cmdScrapFormation = new Button();
        this.cmdTransferAlien = new Button();
        this.cmdActive = new Button();
        this.cmdAwardMedal = new Button();
        this.cmdHierarchyMedal = new Button();
        this.cmdChangeFormationRank = new Button();
        this.cmdTotalForceText = new Button();
        this.flowLayoutPanel1 = new FlowLayoutPanel();
        this.cmdSortCost = new Button();
        this.cmdSortSize = new Button();
        this.cmdSortUnits = new Button();
        this.cmdSortName = new Button();
        this.cmdSortTypeSize = new Button();
        this.cmdSortTypeCost = new Button();
        this.txtElementClass = new TextBox();
        this.txtCmdr = new TextBox();
        this.lstvFormationUnitList = new ListView();
        this.columnHeader_62 = new ColumnHeader();
        this.columnHeader_63 = new ColumnHeader();
        this.columnHeader_64 = new ColumnHeader();
        this.columnHeader_65 = new ColumnHeader();
        this.columnHeader_66 = new ColumnHeader();
        this.columnHeader_67 = new ColumnHeader();
        this.columnHeader_68 = new ColumnHeader();
        this.columnHeader_69 = new ColumnHeader();
        this.columnHeader_70 = new ColumnHeader();
        this.columnHeader_71 = new ColumnHeader();
        this.columnHeader_72 = new ColumnHeader();
        this.columnHeader_73 = new ColumnHeader();
        this.columnHeader_74 = new ColumnHeader();
        this.tvFormations = new TreeView();
        this.tabGround = new TabControl();
        this.tabPage2 = new TabPage();
        this.lstvOrgSummary = new ListView();
        this.columnHeader_75 = new ColumnHeader();
        this.columnHeader_76 = new ColumnHeader();
        this.tvTemplateNodes = new TreeView();
        this.flowLayoutPanel10 = new FlowLayoutPanel();
        this.cmdCreateOrg = new Button();
        this.cmdNodeFieldPosition = new Button();
        this.cmdDeleteNode = new Button();
        this.cmdConstructOrganization = new Button();
        this.cmdInstantOrg = new Button();
        this.cboPopulations = new ComboBox();
        this.label6 = new Label();
        this.tvOrganization = new TreeView();
        this.chkEnterNames = new CheckBox();
        this.tabUnitSeries.SuspendLayout();
        this.flowLayoutPanel4.SuspendLayout();
        this.tabPage1.SuspendLayout();
        this.tabUnitClassDesign.SuspendLayout();
        this.pnlBlank.SuspendLayout();
        this.flowLayoutPanel6.SuspendLayout();
        this.tabTemplates.SuspendLayout();
        this.flowLayoutPanel11.SuspendLayout();
        this.flowLayoutPanel9.SuspendLayout();
        this.flowLayoutPanel7.SuspendLayout();
        this.tabFormations.SuspendLayout();
        this.flowLayoutPanel8.SuspendLayout();
        this.flpAssign.SuspendLayout();
        this.flowLayoutPanel5.SuspendLayout();
        this.flowLayoutPanel2.SuspendLayout();
        this.flowLayoutPanel1.SuspendLayout();
        this.tabGround.SuspendLayout();
        this.tabPage2.SuspendLayout();
        this.flowLayoutPanel10.SuspendLayout();
        this.SuspendLayout();
        this.cboRaces.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cboRaces.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cboRaces.FormattingEnabled = true;
        this.cboRaces.Location = new Point(3, 3);
        this.cboRaces.Margin = new Padding(3, 3, 3, 0);
        this.cboRaces.Name = "cboRaces";
        this.cboRaces.Size = new Size(330, 21);
        this.cboRaces.TabIndex = 42;
        this.cboRaces.SelectedIndexChanged += this.cboRaces_SelectedIndexChanged;
        this.label8.AutoSize = true;
        this.label8.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.label8.Location = new Point(383, 9);
        this.label8.Margin = new Padding(3);
        this.label8.Name = "label8";
        this.label8.Size = new Size(116, 13);
        this.label8.TabIndex = 152;
        this.label8.Text = "Racial Armour Strength";
        this.txtBaseArmour.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtBaseArmour.BorderStyle = BorderStyle.None;
        this.txtBaseArmour.ForeColor = Color.FromArgb(128 /*0x80*/, 255, 128 /*0x80*/);
        this.txtBaseArmour.Location = new Point(502, 10);
        this.txtBaseArmour.Name = "txtBaseArmour";
        this.txtBaseArmour.ReadOnly = true;
        this.txtBaseArmour.Size = new Size(51, 13);
        this.txtBaseArmour.TabIndex = 153;
        this.txtBaseArmour.Text = "10";
        this.txtBaseArmour.TextAlign = HorizontalAlignment.Center;
        this.txtBaseWeapon.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtBaseWeapon.BorderStyle = BorderStyle.None;
        this.txtBaseWeapon.ForeColor = Color.FromArgb(128 /*0x80*/, 255, 128 /*0x80*/);
        this.txtBaseWeapon.Location = new Point(720, 10);
        this.txtBaseWeapon.Name = "txtBaseWeapon";
        this.txtBaseWeapon.ReadOnly = true;
        this.txtBaseWeapon.Size = new Size(51, 13);
        this.txtBaseWeapon.TabIndex = 155;
        this.txtBaseWeapon.Text = "10";
        this.txtBaseWeapon.TextAlign = HorizontalAlignment.Center;
        this.label9.AutoSize = true;
        this.label9.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.label9.Location = new Point(591, 9);
        this.label9.Margin = new Padding(3);
        this.label9.Name = "label9";
        this.label9.Size = new Size(124, 13);
        this.label9.TabIndex = 154;
        this.label9.Text = "Racial Weapon Strength";
        this.txtBeamTracking.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtBeamTracking.BorderStyle = BorderStyle.None;
        this.txtBeamTracking.ForeColor = Color.FromArgb(128 /*0x80*/, 255, 128 /*0x80*/);
        this.txtBeamTracking.Location = new Point(926, 10);
        this.txtBeamTracking.Name = "txtBeamTracking";
        this.txtBeamTracking.ReadOnly = true;
        this.txtBeamTracking.Size = new Size(79, 13);
        this.txtBeamTracking.TabIndex = 100;
        this.txtBeamTracking.Text = "1000 km/s";
        this.txtBeamTracking.TextAlign = HorizontalAlignment.Center;
        this.label4.AutoSize = true;
        this.label4.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.label4.Location = new Point(803, 9);
        this.label4.Margin = new Padding(3);
        this.label4.Name = "label4";
        this.label4.Size = new Size(116, 13);
        this.label4.TabIndex = 159;
        this.label4.Text = "Racial Tracking Speed";
        this.txtFCRange.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtFCRange.BorderStyle = BorderStyle.None;
        this.txtFCRange.ForeColor = Color.FromArgb(128 /*0x80*/, 255, 128 /*0x80*/);
        this.txtFCRange.Location = new Point(1180, 10);
        this.txtFCRange.Name = "txtFCRange";
        this.txtFCRange.ReadOnly = true;
        this.txtFCRange.Size = new Size(79, 13);
        this.txtFCRange.TabIndex = 160 /*0xA0*/;
        this.txtFCRange.Text = "1000 km";
        this.txtFCRange.TextAlign = HorizontalAlignment.Center;
        this.label1.AutoSize = true;
        this.label1.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.label1.Location = new Point(1042, 9);
        this.label1.Margin = new Padding(3);
        this.label1.Name = "label1";
        this.label1.Size = new Size(128 /*0x80*/, 13);
        this.label1.TabIndex = 161;
        this.label1.Text = "Racial Fire Control Range";
        this.tabUnitSeries.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.tabUnitSeries.Controls.Add(this.txtClassDisplay);
        this.tabUnitSeries.Controls.Add(this.flowLayoutPanel4);
        this.tabUnitSeries.Controls.Add(this.tvUnassigned);
        this.tabUnitSeries.Controls.Add(this.tvUnitSeries);
        this.tabUnitSeries.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.tabUnitSeries.Location = new Point(4, 22);
        this.tabUnitSeries.Name = "tabUnitSeries";
        this.tabUnitSeries.Padding = new Padding(3);
        this.tabUnitSeries.Size = new Size(1371, 804);
        this.tabUnitSeries.TabIndex = 4;
        this.tabUnitSeries.Text = "Unit Series";
        this.txtClassDisplay.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtClassDisplay.BorderStyle = BorderStyle.FixedSingle;
        this.txtClassDisplay.ForeColor = Color.FromArgb(128 /*0x80*/, 255, 128 /*0x80*/);
        this.txtClassDisplay.Location = new Point(859, 3);
        this.txtClassDisplay.Margin = new Padding(3, 7, 3, 0);
        this.txtClassDisplay.Multiline = true;
        this.txtClassDisplay.Name = "txtClassDisplay";
        this.txtClassDisplay.Size = new Size(509, 187);
        this.txtClassDisplay.TabIndex = 158;
        this.txtClassDisplay.Text = "Unit Description";
        this.flowLayoutPanel4.Controls.Add(this.cmdCreateSeries);
        this.flowLayoutPanel4.Controls.Add(this.cmdRenameSeries);
        this.flowLayoutPanel4.Controls.Add(this.cmdDeleteSeries);
        this.flowLayoutPanel4.Location = new Point(859, 769);
        this.flowLayoutPanel4.Name = "flowLayoutPanel4";
        this.flowLayoutPanel4.Size = new Size(509, 32 /*0x20*/);
        this.flowLayoutPanel4.TabIndex = 146;
        this.cmdCreateSeries.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdCreateSeries.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdCreateSeries.Location = new Point(0, 0);
        this.cmdCreateSeries.Margin = new Padding(0);
        this.cmdCreateSeries.Name = "cmdCreateSeries";
        this.cmdCreateSeries.Size = new Size(96 /*0x60*/, 30);
        this.cmdCreateSeries.TabIndex = 145;
        this.cmdCreateSeries.Tag = "1200";
        this.cmdCreateSeries.Text = "Create Series";
        this.cmdCreateSeries.UseVisualStyleBackColor = false;
        this.cmdCreateSeries.Click += this.cmdCreateSeries_Click;
        this.cmdRenameSeries.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdRenameSeries.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdRenameSeries.Location = new Point(96 /*0x60*/, 0);
        this.cmdRenameSeries.Margin = new Padding(0);
        this.cmdRenameSeries.Name = "cmdRenameSeries";
        this.cmdRenameSeries.Size = new Size(96 /*0x60*/, 30);
        this.cmdRenameSeries.TabIndex = 146;
        this.cmdRenameSeries.Tag = "1200";
        this.cmdRenameSeries.Text = "Rename Series";
        this.cmdRenameSeries.UseVisualStyleBackColor = false;
        this.cmdRenameSeries.Click += this.cmdRenameSeries_Click;
        this.cmdDeleteSeries.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdDeleteSeries.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdDeleteSeries.Location = new Point(192 /*0xC0*/, 0);
        this.cmdDeleteSeries.Margin = new Padding(0);
        this.cmdDeleteSeries.Name = "cmdDeleteSeries";
        this.cmdDeleteSeries.Size = new Size(96 /*0x60*/, 30);
        this.cmdDeleteSeries.TabIndex = 147;
        this.cmdDeleteSeries.Tag = "1200";
        this.cmdDeleteSeries.Text = "Delete Series";
        this.cmdDeleteSeries.UseVisualStyleBackColor = false;
        this.cmdDeleteSeries.Click += this.cmdDeleteSeries_Click;
        this.tvUnassigned.AllowDrop = true;
        this.tvUnassigned.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.tvUnassigned.BorderStyle = BorderStyle.FixedSingle;
        this.tvUnassigned.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.tvUnassigned.HideSelection = false;
        this.tvUnassigned.Location = new Point(431, 3);
        this.tvUnassigned.Margin = new Padding(3, 0, 0, 3);
        this.tvUnassigned.Name = "tvUnassigned";
        this.tvUnassigned.Size = new Size(425, 798);
        this.tvUnassigned.TabIndex = 40;
        this.tvUnassigned.AfterCollapse += this.tvUnassigned_AfterCollapse;
        this.tvUnassigned.AfterExpand += this.tvUnassigned_AfterExpand;
        this.tvUnassigned.ItemDrag += this.tvUnassigned_ItemDrag;
        this.tvUnassigned.AfterSelect += this.tvUnassigned_AfterSelect;
        this.tvUnassigned.DragEnter += this.tvUnassigned_DragEnter;
        this.tvUnitSeries.AllowDrop = true;
        this.tvUnitSeries.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.tvUnitSeries.BorderStyle = BorderStyle.FixedSingle;
        this.tvUnitSeries.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.tvUnitSeries.HideSelection = false;
        this.tvUnitSeries.Location = new Point(3, 3);
        this.tvUnitSeries.Margin = new Padding(3, 0, 0, 3);
        this.tvUnitSeries.Name = "tvUnitSeries";
        this.tvUnitSeries.Size = new Size(425, 798);
        this.tvUnitSeries.TabIndex = 39;
        this.tvUnitSeries.AfterCollapse += this.tvUnitSeries_AfterCollapse;
        this.tvUnitSeries.AfterExpand += this.tvUnitSeries_AfterExpand;
        this.tvUnitSeries.ItemDrag += this.tvUnitSeries_ItemDrag;
        this.tvUnitSeries.AfterSelect += this.tvUnitSeries_AfterSelect;
        this.tvUnitSeries.DragDrop += this.tvUnitSeries_DragDrop;
        this.tvUnitSeries.DragEnter += this.tvUnitSeries_DragEnter;
        this.tabPage1.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.tabPage1.Controls.Add(this.txtDistribution);
        this.tabPage1.Controls.Add(this.label2);
        this.tabPage1.Controls.Add(this.cboTargetType);
        this.tabPage1.Controls.Add(this.lstvSTOTargeting);
        this.tabPage1.Location = new Point(4, 22);
        this.tabPage1.Name = "tabPage1";
        this.tabPage1.Padding = new Padding(3);
        this.tabPage1.Size = new Size(1371, 804);
        this.tabPage1.TabIndex = 3;
        this.tabPage1.Text = "STO Targeting";
        this.txtDistribution.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtDistribution.BorderStyle = BorderStyle.None;
        this.txtDistribution.ForeColor = Color.FromArgb(128 /*0x80*/, 255, 128 /*0x80*/);
        this.txtDistribution.Location = new Point(357, 9);
        this.txtDistribution.Name = "txtDistribution";
        this.txtDistribution.Size = new Size(30, 13);
        this.txtDistribution.TabIndex = 166;
        this.txtDistribution.Text = "0";
        this.txtDistribution.TextAlign = HorizontalAlignment.Center;
        this.txtDistribution.TextChanged += this.txtDistribution_TextChanged;
        this.label2.AutoSize = true;
        this.label2.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.label2.Location = new Point(210, 8);
        this.label2.Margin = new Padding(3);
        this.label2.Name = "label2";
        this.label2.Size = new Size(144 /*0x90*/, 13);
        this.label2.TabIndex = 165;
        this.label2.Text = "Weapons Per Target (0 = All)";
        this.cboTargetType.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cboTargetType.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cboTargetType.FormattingEnabled = true;
        this.cboTargetType.Location = new Point(6, 3);
        this.cboTargetType.Margin = new Padding(3, 3, 3, 0);
        this.cboTargetType.Name = "cboTargetType";
        this.cboTargetType.Size = new Size(188, 21);
        this.cboTargetType.TabIndex = 164;
        this.cboTargetType.SelectedIndexChanged += this.cboTargetType_SelectedIndexChanged;
        this.lstvSTOTargeting.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.lstvSTOTargeting.BorderStyle = BorderStyle.FixedSingle;
        this.lstvSTOTargeting.Columns.AddRange(new ColumnHeader[9]
        {
            this.columnHeader_0,
            this.columnHeader_1,
            this.columnHeader_2,
            this.columnHeader_3,
            this.columnHeader_4,
            this.columnHeader_5,
            this.columnHeader_6,
            this.columnHeader_7,
            this.columnHeader_8
        });
        this.lstvSTOTargeting.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.lstvSTOTargeting.HeaderStyle = ColumnHeaderStyle.None;
        this.lstvSTOTargeting.HideSelection = false;
        this.lstvSTOTargeting.Location = new Point(3, 31 /*0x1F*/);
        this.lstvSTOTargeting.MultiSelect = false;
        this.lstvSTOTargeting.Name = "lstvSTOTargeting";
        this.lstvSTOTargeting.Size = new Size(1300, 770);
        this.lstvSTOTargeting.TabIndex = 161;
        this.lstvSTOTargeting.UseCompatibleStateImageBehavior = false;
        this.lstvSTOTargeting.View = View.Details;
        this.lstvSTOTargeting.SelectedIndexChanged += this.lstvSTOTargeting_SelectedIndexChanged;
        this.columnHeader_0.Width = 250;
        this.columnHeader_1.Width = 200;
        this.columnHeader_2.Width = 200;
        this.columnHeader_3.Width = 150;
        this.columnHeader_4.Width = 100;
        this.columnHeader_5.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_6.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_6.Width = 80 /*0x50*/;
        this.columnHeader_7.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_8.TextAlign = HorizontalAlignment.Center;
        this.tabUnitClassDesign.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.tabUnitClassDesign.Controls.Add(this.chkNonCombatUnit);
        this.tabUnitClassDesign.Controls.Add(this.pnlBlank);
        this.tabUnitClassDesign.Controls.Add(this.cboQuaternary);
        this.tabUnitClassDesign.Controls.Add(this.cboTertiary);
        this.tabUnitClassDesign.Controls.Add(this.cboSecondary);
        this.tabUnitClassDesign.Controls.Add(this.lblSecondary);
        this.tabUnitClassDesign.Controls.Add(this.txtUnitName);
        this.tabUnitClassDesign.Controls.Add(this.lstvCapability);
        this.tabUnitClassDesign.Controls.Add(this.lstvPrimary);
        this.tabUnitClassDesign.Controls.Add(this.lstvArmourType);
        this.tabUnitClassDesign.Controls.Add(this.lstvBaseType);
        this.tabUnitClassDesign.Controls.Add(this.txtUnitClass);
        this.tabUnitClassDesign.Controls.Add(this.cmdCreate);
        this.tabUnitClassDesign.Controls.Add(this.cmdInstant);
        this.tabUnitClassDesign.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.tabUnitClassDesign.Location = new Point(4, 22);
        this.tabUnitClassDesign.Name = "tabUnitClassDesign";
        this.tabUnitClassDesign.Padding = new Padding(3);
        this.tabUnitClassDesign.Size = new Size(1371, 804);
        this.tabUnitClassDesign.TabIndex = 0;
        this.tabUnitClassDesign.Text = "Unit Class Design";
        this.chkNonCombatUnit.AutoSize = true;
        this.chkNonCombatUnit.Location = new Point(1269, 523);
        this.chkNonCombatUnit.Name = "chkNonCombatUnit";
        this.chkNonCombatUnit.Size = new Size(92, 17);
        this.chkNonCombatUnit.TabIndex = 174;
        this.chkNonCombatUnit.Text = "Avoid Combat";
        this.chkNonCombatUnit.UseVisualStyleBackColor = true;
        this.chkNonCombatUnit.CheckedChanged += this.chkNonCombatUnit_CheckedChanged;
        this.pnlBlank.BorderStyle = BorderStyle.FixedSingle;
        this.pnlBlank.Controls.Add(this.flowLayoutPanel6);
        this.pnlBlank.Controls.Add(this.lstvSTO);
        this.pnlBlank.Location = new Point(713, 210);
        this.pnlBlank.Name = "pnlBlank";
        this.pnlBlank.Size = new Size(652, 306);
        this.pnlBlank.TabIndex = 173;
        this.flowLayoutPanel6.Controls.Add(this.chkPointDefence);
        this.flowLayoutPanel6.Controls.Add(this.chkECCM);
        this.flowLayoutPanel6.Controls.Add(this.lblHQ);
        this.flowLayoutPanel6.Controls.Add(this.txtHQCapacity);
        this.flowLayoutPanel6.Location = new Point(3, 1);
        this.flowLayoutPanel6.Name = "flowLayoutPanel6";
        this.flowLayoutPanel6.Size = new Size(644, 23);
        this.flowLayoutPanel6.TabIndex = 175;
        this.chkPointDefence.AutoSize = true;
        this.chkPointDefence.Location = new Point(3, 3);
        this.chkPointDefence.Name = "chkPointDefence";
        this.chkPointDefence.Size = new Size(138, 17);
        this.chkPointDefence.TabIndex = 0;
        this.chkPointDefence.Text = "Point Defence Weapon";
        this.chkPointDefence.UseVisualStyleBackColor = true;
        this.chkPointDefence.Visible = false;
        this.chkPointDefence.CheckedChanged += this.chkPointDefence_CheckedChanged;
        this.chkECCM.AutoSize = true;
        this.chkECCM.Location = new Point(147, 3);
        this.chkECCM.Name = "chkECCM";
        this.chkECCM.Size = new Size(94, 17);
        this.chkECCM.TabIndex = 1;
        this.chkECCM.Text = "Include ECCM";
        this.chkECCM.UseVisualStyleBackColor = true;
        this.chkECCM.Visible = false;
        this.chkECCM.CheckedChanged += this.chkECCM_CheckedChanged;
        this.lblHQ.AutoSize = true;
        this.lblHQ.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.lblHQ.Location = new Point(247, 3);
        this.lblHQ.Margin = new Padding(3);
        this.lblHQ.Name = "lblHQ";
        this.lblHQ.Size = new Size(110, 13);
        this.lblHQ.TabIndex = 154;
        this.lblHQ.Text = "Headquarter Capacity";
        this.lblHQ.Visible = false;
        this.txtHQCapacity.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtHQCapacity.BorderStyle = BorderStyle.None;
        this.txtHQCapacity.ForeColor = Color.FromArgb(128 /*0x80*/, 255, 128 /*0x80*/);
        this.txtHQCapacity.Location = new Point(363, 3);
        this.txtHQCapacity.Name = "txtHQCapacity";
        this.txtHQCapacity.Size = new Size(70, 13);
        this.txtHQCapacity.TabIndex = 155;
        this.txtHQCapacity.Text = "1000";
        this.txtHQCapacity.TextAlign = HorizontalAlignment.Center;
        this.txtHQCapacity.Visible = false;
        this.txtHQCapacity.TextChanged += this.txtHQCapacity_TextChanged;
        this.txtHQCapacity.Leave += this.txtHQCapacity_Leave;
        this.lstvSTO.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.lstvSTO.BorderStyle = BorderStyle.FixedSingle;
        this.lstvSTO.Columns.AddRange(new ColumnHeader[8]
        {
            this.columnHeader_9,
            this.columnHeader_10,
            this.columnHeader_11,
            this.columnHeader_12,
            this.columnHeader_13,
            this.columnHeader_14,
            this.columnHeader_15,
            this.columnHeader_16
        });
        this.lstvSTO.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.lstvSTO.HeaderStyle = ColumnHeaderStyle.None;
        this.lstvSTO.HideSelection = false;
        this.lstvSTO.Location = new Point(-1, 26);
        this.lstvSTO.MultiSelect = false;
        this.lstvSTO.Name = "lstvSTO";
        this.lstvSTO.Size = new Size(652, 279);
        this.lstvSTO.TabIndex = 174;
        this.lstvSTO.UseCompatibleStateImageBehavior = false;
        this.lstvSTO.View = View.Details;
        this.lstvSTO.Visible = false;
        this.lstvSTO.ItemSelectionChanged += this.lstvSTO_ItemSelectionChanged;
        this.lstvSTO.SelectedIndexChanged += this.lstvSTO_SelectedIndexChanged;
        this.columnHeader_9.Width = 200;
        this.columnHeader_10.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_11.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_12.Text = "";
        this.columnHeader_12.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_13.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_14.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_15.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_16.TextAlign = HorizontalAlignment.Center;
        this.cboQuaternary.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cboQuaternary.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cboQuaternary.FormattingEnabled = true;
        this.cboQuaternary.Location = new Point(519, 766);
        this.cboQuaternary.Margin = new Padding(3, 3, 3, 0);
        this.cboQuaternary.Name = "cboQuaternary";
        this.cboQuaternary.Size = new Size(188, 21);
        this.cboQuaternary.TabIndex = 171;
        this.cboQuaternary.SelectedIndexChanged += this.cboQuaternary_SelectedIndexChanged;
        this.cboTertiary.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cboTertiary.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cboTertiary.FormattingEnabled = true;
        this.cboTertiary.Location = new Point(325, 766);
        this.cboTertiary.Margin = new Padding(3, 3, 3, 0);
        this.cboTertiary.Name = "cboTertiary";
        this.cboTertiary.Size = new Size(188, 21);
        this.cboTertiary.TabIndex = 165;
        this.cboTertiary.SelectedIndexChanged += this.cboTertiary_SelectedIndexChanged;
        this.cboSecondary.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cboSecondary.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cboSecondary.FormattingEnabled = true;
        this.cboSecondary.Location = new Point(131, 766);
        this.cboSecondary.Margin = new Padding(3, 3, 3, 0);
        this.cboSecondary.Name = "cboSecondary";
        this.cboSecondary.Size = new Size(188, 21);
        this.cboSecondary.TabIndex = 163;
        this.cboSecondary.SelectedIndexChanged += this.cboSecondary_SelectedIndexChanged;
        this.lblSecondary.AutoSize = true;
        this.lblSecondary.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.lblSecondary.Location = new Point(5, 769);
        this.lblSecondary.Name = "lblSecondary";
        this.lblSecondary.Size = new Size(115, 13);
        this.lblSecondary.TabIndex = 164;
        this.lblSecondary.Text = "Additional Components";
        this.txtUnitName.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtUnitName.BorderStyle = BorderStyle.FixedSingle;
        this.txtUnitName.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
        this.txtUnitName.ForeColor = Color.FromArgb(128 /*0x80*/, 255, 128 /*0x80*/);
        this.txtUnitName.Location = new Point(713, 520);
        this.txtUnitName.Margin = new Padding(3, 7, 3, 0);
        this.txtUnitName.Name = "txtUnitName";
        this.txtUnitName.Size = new Size(539, 22);
        this.txtUnitName.TabIndex = 132;
        this.txtUnitName.Text = "New Unit Class Name";
        this.lstvCapability.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.lstvCapability.BorderStyle = BorderStyle.FixedSingle;
        this.lstvCapability.Columns.AddRange(new ColumnHeader[3]
        {
            this.columnHeader_17,
            this.columnHeader_18,
            this.columnHeader_19
        });
        this.lstvCapability.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.lstvCapability.HeaderStyle = ColumnHeaderStyle.None;
        this.lstvCapability.HideSelection = false;
        this.lstvCapability.Location = new Point(820, 6);
        this.lstvCapability.Name = "lstvCapability";
        this.lstvCapability.Size = new Size(343, 198);
        this.lstvCapability.TabIndex = 172;
        this.lstvCapability.UseCompatibleStateImageBehavior = false;
        this.lstvCapability.View = View.Details;
        this.lstvCapability.SelectedIndexChanged += this.lstvCapability_SelectedIndexChanged;
        this.columnHeader_17.Width = 180;
        this.columnHeader_18.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_18.Width = 70;
        this.columnHeader_19.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_19.Width = 70;
        this.lstvPrimary.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.lstvPrimary.BorderStyle = BorderStyle.FixedSingle;
        this.lstvPrimary.Columns.AddRange(new ColumnHeader[8]
        {
            this.columnHeader_20,
            this.columnHeader_21,
            this.columnHeader_22,
            this.columnHeader_23,
            this.columnHeader_24,
            this.columnHeader_25,
            this.columnHeader_26,
            this.columnHeader_27
        });
        this.lstvPrimary.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.lstvPrimary.HeaderStyle = ColumnHeaderStyle.None;
        this.lstvPrimary.HideSelection = false;
        this.lstvPrimary.Location = new Point(3, 210);
        this.lstvPrimary.MultiSelect = false;
        this.lstvPrimary.Name = "lstvPrimary";
        this.lstvPrimary.Size = new Size(704, 550);
        this.lstvPrimary.TabIndex = 161;
        this.lstvPrimary.UseCompatibleStateImageBehavior = false;
        this.lstvPrimary.View = View.Details;
        this.lstvPrimary.SelectedIndexChanged += this.lstvPrimary_SelectedIndexChanged;
        this.columnHeader_20.Width = 180;
        this.columnHeader_21.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_22.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_22.Width = 50;
        this.columnHeader_23.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_23.Width = 50;
        this.columnHeader_24.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_24.Width = 55;
        this.columnHeader_25.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_25.Width = 50;
        this.columnHeader_26.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_26.Width = 50;
        this.columnHeader_27.Width = 200;
        this.lstvArmourType.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.lstvArmourType.BorderStyle = BorderStyle.FixedSingle;
        this.lstvArmourType.Columns.AddRange(new ColumnHeader[3]
        {
            this.columnHeader_28,
            this.columnHeader_29,
            this.columnHeader_30
        });
        this.lstvArmourType.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.lstvArmourType.HeaderStyle = ColumnHeaderStyle.None;
        this.lstvArmourType.HideSelection = false;
        this.lstvArmourType.Location = new Point(499, 6);
        this.lstvArmourType.MultiSelect = false;
        this.lstvArmourType.Name = "lstvArmourType";
        this.lstvArmourType.Size = new Size(315, 198);
        this.lstvArmourType.TabIndex = 160 /*0xA0*/;
        this.lstvArmourType.UseCompatibleStateImageBehavior = false;
        this.lstvArmourType.View = View.Details;
        this.lstvArmourType.SelectedIndexChanged += this.lstvArmourType_SelectedIndexChanged;
        this.columnHeader_28.Width = 170;
        this.columnHeader_29.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_29.Width = 65;
        this.columnHeader_30.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_30.Width = 65;
        this.lstvBaseType.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.lstvBaseType.BorderStyle = BorderStyle.FixedSingle;
        this.lstvBaseType.Columns.AddRange(new ColumnHeader[7]
        {
            this.columnHeader_31,
            this.columnHeader_32,
            this.columnHeader_33,
            this.columnHeader_34,
            this.columnHeader_35,
            this.columnHeader_36,
            this.columnHeader_37
        });
        this.lstvBaseType.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.lstvBaseType.HeaderStyle = ColumnHeaderStyle.None;
        this.lstvBaseType.HideSelection = false;
        this.lstvBaseType.Location = new Point(3, 6);
        this.lstvBaseType.MultiSelect = false;
        this.lstvBaseType.Name = "lstvBaseType";
        this.lstvBaseType.Size = new Size(490, 198);
        this.lstvBaseType.TabIndex = 159;
        this.lstvBaseType.UseCompatibleStateImageBehavior = false;
        this.lstvBaseType.View = View.Details;
        this.lstvBaseType.SelectedIndexChanged += this.lstvBaseType_SelectedIndexChanged;
        this.columnHeader_31.Width = 120;
        this.columnHeader_32.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_33.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_34.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_35.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_36.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_37.TextAlign = HorizontalAlignment.Center;
        this.txtUnitClass.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtUnitClass.BorderStyle = BorderStyle.FixedSingle;
        this.txtUnitClass.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
        this.txtUnitClass.ForeColor = Color.FromArgb(128 /*0x80*/, 255, 128 /*0x80*/);
        this.txtUnitClass.Location = new Point(713, 546);
        this.txtUnitClass.Margin = new Padding(3, 7, 3, 0);
        this.txtUnitClass.Multiline = true;
        this.txtUnitClass.Name = "txtUnitClass";
        this.txtUnitClass.Size = new Size(652, 214);
        this.txtUnitClass.TabIndex = 142;
        this.txtUnitClass.Text = "Unit Description";
        this.cmdCreate.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdCreate.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdCreate.Location = new Point(1269, 766);
        this.cmdCreate.Margin = new Padding(0);
        this.cmdCreate.Name = "cmdCreate";
        this.cmdCreate.Size = new Size(96 /*0x60*/, 30);
        this.cmdCreate.TabIndex = 144 /*0x90*/;
        this.cmdCreate.Tag = "1200";
        this.cmdCreate.Text = "Create";
        this.cmdCreate.UseVisualStyleBackColor = false;
        this.cmdCreate.Click += this.cmdCreate_Click;
        this.cmdInstant.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdInstant.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdInstant.Location = new Point(1173, 766);
        this.cmdInstant.Margin = new Padding(0);
        this.cmdInstant.Name = "cmdInstant";
        this.cmdInstant.Size = new Size(96 /*0x60*/, 30);
        this.cmdInstant.TabIndex = 146;
        this.cmdInstant.Tag = "1200";
        this.cmdInstant.Text = "Instant";
        this.cmdInstant.UseVisualStyleBackColor = false;
        this.cmdInstant.Click += this.cmdInstant_Click;
        this.tabTemplates.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.tabTemplates.Controls.Add(this.flowLayoutPanel11);
        this.tabTemplates.Controls.Add(this.flowLayoutPanel9);
        this.tabTemplates.Controls.Add(this.flowLayoutPanel7);
        this.tabTemplates.Controls.Add(this.lstvTemplateUnitList);
        this.tabTemplates.Controls.Add(this.txtSelectedClass);
        this.tabTemplates.Controls.Add(this.lstvUnitClass);
        this.tabTemplates.Controls.Add(this.lstvTemplate);
        this.tabTemplates.Controls.Add(this.flowLayoutPanel3);
        this.tabTemplates.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.tabTemplates.Location = new Point(4, 22);
        this.tabTemplates.Name = "tabTemplates";
        this.tabTemplates.Padding = new Padding(3);
        this.tabTemplates.Size = new Size(1371, 804);
        this.tabTemplates.TabIndex = 1;
        this.tabTemplates.Text = "Formation Templates";
        this.tabTemplates.Click += this.tabTemplates_Click;
        this.flowLayoutPanel11.Controls.Add(this.cmdRenameUnit);
        this.flowLayoutPanel11.Controls.Add(this.cmdObsolete);
        this.flowLayoutPanel11.Controls.Add(this.cmdNonCombat);
        this.flowLayoutPanel11.Controls.Add(this.chkShowCivilian);
        this.flowLayoutPanel11.Controls.Add(this.chkShowObsolete);
        this.flowLayoutPanel11.Controls.Add(this.cmdAdd);
        this.flowLayoutPanel11.Controls.Add(this.txtNumUnit);
        this.flowLayoutPanel11.Location = new Point(3, 771);
        this.flowLayoutPanel11.Name = "flowLayoutPanel11";
        this.flowLayoutPanel11.Size = new Size(650, 31 /*0x1F*/);
        this.flowLayoutPanel11.TabIndex = 182;
        this.cmdRenameUnit.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdRenameUnit.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdRenameUnit.Location = new Point(0, 0);
        this.cmdRenameUnit.Margin = new Padding(0);
        this.cmdRenameUnit.Name = "cmdRenameUnit";
        this.cmdRenameUnit.Size = new Size(96 /*0x60*/, 30);
        this.cmdRenameUnit.TabIndex = 151;
        this.cmdRenameUnit.Tag = "1200";
        this.cmdRenameUnit.Text = "Rename Unit";
        this.cmdRenameUnit.UseVisualStyleBackColor = false;
        this.cmdRenameUnit.Click += this.cmdRenameUnit_Click;
        this.cmdObsolete.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdObsolete.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdObsolete.Location = new Point(96 /*0x60*/, 0);
        this.cmdObsolete.Margin = new Padding(0);
        this.cmdObsolete.Name = "cmdObsolete";
        this.cmdObsolete.Size = new Size(96 /*0x60*/, 30);
        this.cmdObsolete.TabIndex = 177;
        this.cmdObsolete.Tag = "1200";
        this.cmdObsolete.Text = "Obsolete";
        this.cmdObsolete.UseVisualStyleBackColor = false;
        this.cmdObsolete.Click += this.cmdObsolete_Click;
        this.cmdNonCombat.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdNonCombat.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdNonCombat.Location = new Point(192 /*0xC0*/, 0);
        this.cmdNonCombat.Margin = new Padding(0);
        this.cmdNonCombat.Name = "cmdNonCombat";
        this.cmdNonCombat.Size = new Size(96 /*0x60*/, 30);
        this.cmdNonCombat.TabIndex = 181;
        this.cmdNonCombat.Tag = "1200";
        this.cmdNonCombat.Text = "Non-Combat";
        this.cmdNonCombat.UseVisualStyleBackColor = false;
        this.cmdNonCombat.Click += this.cmdNonCombat_Click;
        this.chkShowCivilian.AutoSize = true;
        this.chkShowCivilian.Location = new Point(300, 6);
        this.chkShowCivilian.Margin = new Padding(12, 6, 3, 3);
        this.chkShowCivilian.Name = "chkShowCivilian";
        this.chkShowCivilian.Padding = new Padding(5, 0, 0, 0);
        this.chkShowCivilian.Size = new Size(64 /*0x40*/, 17);
        this.chkShowCivilian.TabIndex = 180;
        this.chkShowCivilian.Text = "Civilian";
        this.chkShowCivilian.TextAlign = ContentAlignment.MiddleRight;
        this.chkShowCivilian.UseVisualStyleBackColor = true;
        this.chkShowCivilian.CheckedChanged += this.chkShowCivilian_CheckedChanged;
        this.chkShowObsolete.AutoSize = true;
        this.chkShowObsolete.Location = new Point(370, 6);
        this.chkShowObsolete.Margin = new Padding(3, 6, 3, 3);
        this.chkShowObsolete.Name = "chkShowObsolete";
        this.chkShowObsolete.Padding = new Padding(5, 0, 0, 0);
        this.chkShowObsolete.Size = new Size(73, 17);
        this.chkShowObsolete.TabIndex = 178;
        this.chkShowObsolete.Text = "Obsolete";
        this.chkShowObsolete.TextAlign = ContentAlignment.MiddleRight;
        this.chkShowObsolete.UseVisualStyleBackColor = true;
        this.chkShowObsolete.CheckedChanged += this.chkShowObsolete_CheckedChanged;
        this.cmdAdd.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdAdd.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdAdd.Location = new Point(482, 0);
        this.cmdAdd.Margin = new Padding(36, 0, 0, 0);
        this.cmdAdd.Name = "cmdAdd";
        this.cmdAdd.Size = new Size(96 /*0x60*/, 30);
        this.cmdAdd.TabIndex = 145;
        this.cmdAdd.Tag = "1200";
        this.cmdAdd.Text = "Add Units";
        this.cmdAdd.UseVisualStyleBackColor = false;
        this.cmdAdd.Click += this.cmdAdd_Click;
        this.txtNumUnit.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtNumUnit.BorderStyle = BorderStyle.None;
        this.txtNumUnit.ForeColor = Color.FromArgb(128 /*0x80*/, 255, 128 /*0x80*/);
        this.txtNumUnit.Location = new Point(584, 9);
        this.txtNumUnit.Margin = new Padding(6, 9, 3, 0);
        this.txtNumUnit.Name = "txtNumUnit";
        this.txtNumUnit.Size = new Size(51, 13);
        this.txtNumUnit.TabIndex = 144 /*0x90*/;
        this.txtNumUnit.Text = "10";
        this.txtNumUnit.TextAlign = HorizontalAlignment.Center;
        this.txtNumUnit.Leave += this.txtNumUnit_Leave;
        this.flowLayoutPanel9.Controls.Add(this.cmdNewFormation);
        this.flowLayoutPanel9.Controls.Add(this.cmdRename);
        this.flowLayoutPanel9.Controls.Add(this.cmdCopyTemp);
        this.flowLayoutPanel9.Controls.Add(this.cmdUpdateTemp);
        this.flowLayoutPanel9.Controls.Add(this.cmdTemplateAsText);
        this.flowLayoutPanel9.Controls.Add(this.cmdDeleteFormation);
        this.flowLayoutPanel9.Controls.Add(this.cmdChangeRank);
        this.flowLayoutPanel9.Location = new Point(659, 546);
        this.flowLayoutPanel9.Name = "flowLayoutPanel9";
        this.flowLayoutPanel9.Size = new Size(706, 30);
        this.flowLayoutPanel9.TabIndex = 181;
        this.flowLayoutPanel9.Paint += this.flowLayoutPanel9_Paint;
        this.cmdNewFormation.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdNewFormation.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdNewFormation.Location = new Point(0, 0);
        this.cmdNewFormation.Margin = new Padding(0);
        this.cmdNewFormation.Name = "cmdNewFormation";
        this.cmdNewFormation.Size = new Size(96 /*0x60*/, 30);
        this.cmdNewFormation.TabIndex = 147;
        this.cmdNewFormation.Tag = "1200";
        this.cmdNewFormation.Text = "New";
        this.cmdNewFormation.UseVisualStyleBackColor = false;
        this.cmdNewFormation.Click += this.cmdNewFormation_Click;
        this.cmdRename.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdRename.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdRename.Location = new Point(96 /*0x60*/, 0);
        this.cmdRename.Margin = new Padding(0);
        this.cmdRename.Name = "cmdRename";
        this.cmdRename.Size = new Size(96 /*0x60*/, 30);
        this.cmdRename.TabIndex = 149;
        this.cmdRename.Tag = "1200";
        this.cmdRename.Text = "Rename Temp";
        this.cmdRename.UseVisualStyleBackColor = false;
        this.cmdRename.Click += this.cmdRename_Click;
        this.cmdCopyTemp.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdCopyTemp.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdCopyTemp.Location = new Point(192 /*0xC0*/, 0);
        this.cmdCopyTemp.Margin = new Padding(0);
        this.cmdCopyTemp.Name = "cmdCopyTemp";
        this.cmdCopyTemp.Size = new Size(96 /*0x60*/, 30);
        this.cmdCopyTemp.TabIndex = 182;
        this.cmdCopyTemp.Tag = "1200";
        this.cmdCopyTemp.Text = "Copy Temp";
        this.cmdCopyTemp.UseVisualStyleBackColor = false;
        this.cmdCopyTemp.Click += this.cmdCopyTemp_Click;
        this.cmdUpdateTemp.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdUpdateTemp.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdUpdateTemp.Location = new Point(288, 0);
        this.cmdUpdateTemp.Margin = new Padding(0);
        this.cmdUpdateTemp.Name = "cmdUpdateTemp";
        this.cmdUpdateTemp.Size = new Size(96 /*0x60*/, 30);
        this.cmdUpdateTemp.TabIndex = 181;
        this.cmdUpdateTemp.Tag = "1200";
        this.cmdUpdateTemp.Text = "Copy + Upgrade";
        this.cmdUpdateTemp.UseVisualStyleBackColor = false;
        this.cmdUpdateTemp.Click += this.cmdUpdateTemp_Click;
        this.cmdTemplateAsText.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdTemplateAsText.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdTemplateAsText.Location = new Point(384, 0);
        this.cmdTemplateAsText.Margin = new Padding(0);
        this.cmdTemplateAsText.Name = "cmdTemplateAsText";
        this.cmdTemplateAsText.Size = new Size(96 /*0x60*/, 30);
        this.cmdTemplateAsText.TabIndex = 180;
        this.cmdTemplateAsText.Tag = "1200";
        this.cmdTemplateAsText.Text = "Temp As Text";
        this.cmdTemplateAsText.UseVisualStyleBackColor = false;
        this.cmdTemplateAsText.Click += this.cmdTemplateAsText_Click;
        this.cmdDeleteFormation.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdDeleteFormation.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdDeleteFormation.Location = new Point(480, 0);
        this.cmdDeleteFormation.Margin = new Padding(0);
        this.cmdDeleteFormation.Name = "cmdDeleteFormation";
        this.cmdDeleteFormation.Size = new Size(96 /*0x60*/, 30);
        this.cmdDeleteFormation.TabIndex = 148;
        this.cmdDeleteFormation.Tag = "1200";
        this.cmdDeleteFormation.Text = "Obsolete Temp";
        this.cmdDeleteFormation.UseVisualStyleBackColor = false;
        this.cmdDeleteFormation.Click += this.cmdDeleteFormation_Click;
        this.cmdChangeRank.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdChangeRank.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdChangeRank.Location = new Point(576, 0);
        this.cmdChangeRank.Margin = new Padding(0);
        this.cmdChangeRank.Name = "cmdChangeRank";
        this.cmdChangeRank.Size = new Size(96 /*0x60*/, 30);
        this.cmdChangeRank.TabIndex = 176 /*0xB0*/;
        this.cmdChangeRank.Tag = "1200";
        this.cmdChangeRank.Text = "Change Rank";
        this.cmdChangeRank.UseVisualStyleBackColor = false;
        this.cmdChangeRank.Click += this.cmdChangeRank_Click;
        this.flowLayoutPanel7.Controls.Add(this.cmdEditAmount);
        this.flowLayoutPanel7.Controls.Add(this.cmdDeleteElement);
        this.flowLayoutPanel7.Controls.Add(this.chkShowObsoleteTemplates);
        this.flowLayoutPanel7.Controls.Add(this.button1);
        this.flowLayoutPanel7.Location = new Point(659, 772);
        this.flowLayoutPanel7.Name = "flowLayoutPanel7";
        this.flowLayoutPanel7.Size = new Size(706, 31 /*0x1F*/);
        this.flowLayoutPanel7.TabIndex = 179;
        this.cmdEditAmount.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdEditAmount.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdEditAmount.Location = new Point(0, 0);
        this.cmdEditAmount.Margin = new Padding(0);
        this.cmdEditAmount.Name = "cmdEditAmount";
        this.cmdEditAmount.Size = new Size(96 /*0x60*/, 30);
        this.cmdEditAmount.TabIndex = 174;
        this.cmdEditAmount.Tag = "1200";
        this.cmdEditAmount.Text = "Edit Amount";
        this.cmdEditAmount.UseVisualStyleBackColor = false;
        this.cmdEditAmount.Click += this.cmdEditAmount_Click;
        this.cmdDeleteElement.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdDeleteElement.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdDeleteElement.Location = new Point(96 /*0x60*/, 0);
        this.cmdDeleteElement.Margin = new Padding(0);
        this.cmdDeleteElement.Name = "cmdDeleteElement";
        this.cmdDeleteElement.Size = new Size(96 /*0x60*/, 30);
        this.cmdDeleteElement.TabIndex = 175;
        this.cmdDeleteElement.Tag = "1200";
        this.cmdDeleteElement.Text = "Delete Element";
        this.cmdDeleteElement.UseVisualStyleBackColor = false;
        this.cmdDeleteElement.Click += this.cmdDeleteElement_Click;
        this.chkShowObsoleteTemplates.AutoSize = true;
        this.chkShowObsoleteTemplates.Location = new Point(216, 3);
        this.chkShowObsoleteTemplates.Margin = new Padding(24, 3, 3, 3);
        this.chkShowObsoleteTemplates.Name = "chkShowObsoleteTemplates";
        this.chkShowObsoleteTemplates.Padding = new Padding(5, 0, 0, 0);
        this.chkShowObsoleteTemplates.Size = new Size(155, 17);
        this.chkShowObsoleteTemplates.TabIndex = 179;
        this.chkShowObsoleteTemplates.Text = "Show Obsolete Templates";
        this.chkShowObsoleteTemplates.TextAlign = ContentAlignment.MiddleRight;
        this.chkShowObsoleteTemplates.UseVisualStyleBackColor = true;
        this.chkShowObsoleteTemplates.CheckedChanged += this.chkShowObsoleteTemplates_CheckedChanged;
        this.button1.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.button1.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.button1.Location = new Point(374, 0);
        this.button1.Margin = new Padding(0);
        this.button1.Name = "button1";
        this.button1.Size = new Size(96 /*0x60*/, 30);
        this.button1.TabIndex = 182;
        this.button1.Tag = "1200";
        this.button1.Text = "Obsolete";
        this.button1.UseVisualStyleBackColor = false;
        this.lstvTemplateUnitList.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.lstvTemplateUnitList.BorderStyle = BorderStyle.FixedSingle;
        this.lstvTemplateUnitList.Columns.AddRange(new ColumnHeader[7]
        {
            this.columnHeader_38,
            this.columnHeader_39,
            this.columnHeader_40,
            this.columnHeader_41,
            this.columnHeader_42,
            this.columnHeader_43,
            this.columnHeader_44
        });
        this.lstvTemplateUnitList.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.lstvTemplateUnitList.HeaderStyle = ColumnHeaderStyle.None;
        this.lstvTemplateUnitList.HideSelection = false;
        this.lstvTemplateUnitList.Location = new Point(659, 581);
        this.lstvTemplateUnitList.Name = "lstvTemplateUnitList";
        this.lstvTemplateUnitList.Size = new Size(709, 187);
        this.lstvTemplateUnitList.TabIndex = 173;
        this.lstvTemplateUnitList.UseCompatibleStateImageBehavior = false;
        this.lstvTemplateUnitList.View = View.Details;
        this.lstvTemplateUnitList.SelectedIndexChanged += this.lstvTemplateUnitList_SelectedIndexChanged;
        this.columnHeader_38.Width = 210;
        this.columnHeader_39.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_39.Width = 55;
        this.columnHeader_40.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_40.Width = 55;
        this.columnHeader_41.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_41.Width = 55;
        this.columnHeader_42.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_42.Width = 55;
        this.columnHeader_43.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_43.Width = 55;
        this.columnHeader_44.Width = 200;
        this.txtSelectedClass.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtSelectedClass.BorderStyle = BorderStyle.FixedSingle;
        this.txtSelectedClass.ForeColor = Color.FromArgb(128 /*0x80*/, 255, 128 /*0x80*/);
        this.txtSelectedClass.Location = new Point(3, 581);
        this.txtSelectedClass.Margin = new Padding(3, 7, 3, 0);
        this.txtSelectedClass.Multiline = true;
        this.txtSelectedClass.Name = "txtSelectedClass";
        this.txtSelectedClass.Size = new Size(650, 187);
        this.txtSelectedClass.TabIndex = 157;
        this.txtSelectedClass.Text = "Unit Description";
        this.lstvUnitClass.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.lstvUnitClass.BorderStyle = BorderStyle.FixedSingle;
        this.lstvUnitClass.Columns.AddRange(new ColumnHeader[8]
        {
            this.columnHeader_45,
            this.columnHeader_46,
            this.columnHeader_47,
            this.columnHeader_48,
            this.columnHeader_49,
            this.columnHeader_50,
            this.columnHeader_51,
            this.columnHeader_52
        });
        this.lstvUnitClass.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.lstvUnitClass.FullRowSelect = true;
        this.lstvUnitClass.HeaderStyle = ColumnHeaderStyle.None;
        this.lstvUnitClass.HideSelection = false;
        this.lstvUnitClass.Location = new Point(3, 6);
        this.lstvUnitClass.MultiSelect = false;
        this.lstvUnitClass.Name = "lstvUnitClass";
        this.lstvUnitClass.Size = new Size(650, 569);
        this.lstvUnitClass.TabIndex = 150;
        this.lstvUnitClass.UseCompatibleStateImageBehavior = false;
        this.lstvUnitClass.View = View.Details;
        this.lstvUnitClass.SelectedIndexChanged += this.lstvUnitClass_SelectedIndexChanged;
        this.columnHeader_45.Width = 40;
        this.columnHeader_46.Width = 210;
        this.columnHeader_47.Width = 140;
        this.columnHeader_48.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_48.Width = 45;
        this.columnHeader_49.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_49.Width = 45;
        this.columnHeader_50.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_50.Width = 45;
        this.columnHeader_51.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_51.Width = 45;
        this.columnHeader_52.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_52.Width = 45;
        this.lstvTemplate.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.lstvTemplate.BorderStyle = BorderStyle.FixedSingle;
        this.lstvTemplate.Columns.AddRange(new ColumnHeader[9]
        {
            this.columnHeader_53,
            this.columnHeader_54,
            this.columnHeader_55,
            this.columnHeader_56,
            this.columnHeader_57,
            this.columnHeader_58,
            this.columnHeader_59,
            this.columnHeader_60,
            this.columnHeader_61
        });
        this.lstvTemplate.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.lstvTemplate.FullRowSelect = true;
        this.lstvTemplate.HeaderStyle = ColumnHeaderStyle.None;
        this.lstvTemplate.HideSelection = false;
        this.lstvTemplate.Location = new Point(659, 6);
        this.lstvTemplate.MultiSelect = false;
        this.lstvTemplate.Name = "lstvTemplate";
        this.lstvTemplate.Size = new Size(709, 536);
        this.lstvTemplate.TabIndex = 156;
        this.lstvTemplate.UseCompatibleStateImageBehavior = false;
        this.lstvTemplate.View = View.Details;
        this.lstvTemplate.SelectedIndexChanged += this.lstvTemplate_SelectedIndexChanged;
        this.columnHeader_53.Width = 40;
        this.columnHeader_54.Width = 160 /*0xA0*/;
        this.columnHeader_55.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_55.Width = 50;
        this.columnHeader_56.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_56.Width = 55;
        this.columnHeader_57.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_57.Width = 55;
        this.columnHeader_58.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_58.Width = 55;
        this.columnHeader_59.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_59.Width = 55;
        this.columnHeader_60.Width = 170;
        this.columnHeader_61.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_61.Width = 40;
        this.flowLayoutPanel3.Location = new Point(488, 772);
        this.flowLayoutPanel3.Name = "flowLayoutPanel3";
        this.flowLayoutPanel3.Size = new Size(165, 31 /*0x1F*/);
        this.flowLayoutPanel3.TabIndex = 148;
        this.tabFormations.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.tabFormations.Controls.Add(this.flowLayoutPanel8);
        this.tabFormations.Controls.Add(this.flpAssign);
        this.tabFormations.Controls.Add(this.flowLayoutPanel5);
        this.tabFormations.Controls.Add(this.flowLayoutPanel2);
        this.tabFormations.Controls.Add(this.flowLayoutPanel1);
        this.tabFormations.Controls.Add(this.txtElementClass);
        this.tabFormations.Controls.Add(this.txtCmdr);
        this.tabFormations.Controls.Add(this.lstvFormationUnitList);
        this.tabFormations.Controls.Add(this.tvFormations);
        this.tabFormations.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.tabFormations.Location = new Point(4, 22);
        this.tabFormations.Name = "tabFormations";
        this.tabFormations.Padding = new Padding(3);
        this.tabFormations.Size = new Size(1371, 804);
        this.tabFormations.TabIndex = 2;
        this.tabFormations.Text = "Order of Battle";
        this.flowLayoutPanel8.Controls.Add(this.txtFormationLocation);
        this.flowLayoutPanel8.Controls.Add(this.label3);
        this.flowLayoutPanel8.Controls.Add(this.txtReplacementTemplate);
        this.flowLayoutPanel8.Controls.Add(this.label5);
        this.flowLayoutPanel8.Controls.Add(this.txtPriority);
        this.flowLayoutPanel8.Controls.Add(this.chkUseForReplacements);
        this.flowLayoutPanel8.Location = new Point(426, 4);
        this.flowLayoutPanel8.Name = "flowLayoutPanel8";
        this.flowLayoutPanel8.Size = new Size(942, 25);
        this.flowLayoutPanel8.TabIndex = 203;
        this.txtFormationLocation.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtFormationLocation.BorderStyle = BorderStyle.FixedSingle;
        this.txtFormationLocation.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.txtFormationLocation.Location = new Point(0, 3);
        this.txtFormationLocation.Margin = new Padding(0, 3, 3, 3);
        this.txtFormationLocation.Name = "txtFormationLocation";
        this.txtFormationLocation.Size = new Size(218, 20);
        this.txtFormationLocation.TabIndex = 182;
        this.label3.AutoSize = true;
        this.label3.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.label3.Location = new Point(245, 6);
        this.label3.Margin = new Padding(24, 6, 3, 3);
        this.label3.Name = "label3";
        this.label3.Size = new Size(117, 13);
        this.label3.TabIndex = 199;
        this.label3.Text = "Replacement Template";
        this.txtReplacementTemplate.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtReplacementTemplate.BorderStyle = BorderStyle.FixedSingle;
        this.txtReplacementTemplate.ForeColor = Color.FromArgb(128 /*0x80*/, 255, 128 /*0x80*/);
        this.txtReplacementTemplate.Location = new Point(368, 3);
        this.txtReplacementTemplate.Name = "txtReplacementTemplate";
        this.txtReplacementTemplate.Size = new Size(266, 20);
        this.txtReplacementTemplate.TabIndex = 198;
        this.txtReplacementTemplate.TextAlign = HorizontalAlignment.Center;
        this.label5.AutoSize = true;
        this.label5.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.label5.Location = new Point(661, 6);
        this.label5.Margin = new Padding(24, 6, 3, 3);
        this.label5.Name = "label5";
        this.label5.Size = new Size(38, 13);
        this.label5.TabIndex = 202;
        this.label5.Text = "Priority";
        this.txtPriority.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtPriority.BorderStyle = BorderStyle.FixedSingle;
        this.txtPriority.ForeColor = Color.FromArgb(128 /*0x80*/, 255, 128 /*0x80*/);
        this.txtPriority.Location = new Point(705, 3);
        this.txtPriority.Name = "txtPriority";
        this.txtPriority.Size = new Size(30, 20);
        this.txtPriority.TabIndex = 201;
        this.txtPriority.Text = "10";
        this.txtPriority.TextAlign = HorizontalAlignment.Center;
        this.txtPriority.TextChanged += this.txtPriority_TextChanged;
        this.chkUseForReplacements.AutoSize = true;
        this.chkUseForReplacements.Checked = true;
        this.chkUseForReplacements.CheckState = CheckState.Checked;
        this.chkUseForReplacements.Location = new Point(762, 5);
        this.chkUseForReplacements.Margin = new Padding(24, 5, 3, 3);
        this.chkUseForReplacements.Name = "chkUseForReplacements";
        this.chkUseForReplacements.Size = new Size(134, 17);
        this.chkUseForReplacements.TabIndex = 200;
        this.chkUseForReplacements.Text = "Use For Replacements";
        this.chkUseForReplacements.UseVisualStyleBackColor = true;
        this.chkUseForReplacements.CheckedChanged += this.chkUseForReplacements_CheckedChanged;
        this.flpAssign.BorderStyle = BorderStyle.FixedSingle;
        this.flpAssign.Controls.Add(this.cmdAssignSupport);
        this.flpAssign.Controls.Add(this.cboAssign);
        this.flpAssign.Location = new Point(3, 734);
        this.flpAssign.Name = "flpAssign";
        this.flpAssign.Size = new Size(420, 33);
        this.flpAssign.TabIndex = 197;
        this.flpAssign.Visible = false;
        this.cmdAssignSupport.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdAssignSupport.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdAssignSupport.Location = new Point(0, 0);
        this.cmdAssignSupport.Margin = new Padding(0);
        this.cmdAssignSupport.Name = "cmdAssignSupport";
        this.cmdAssignSupport.Size = new Size(96 /*0x60*/, 30);
        this.cmdAssignSupport.TabIndex = 196;
        this.cmdAssignSupport.Tag = "1200";
        this.cmdAssignSupport.Text = "Assign OBS";
        this.cmdAssignSupport.UseVisualStyleBackColor = false;
        this.cmdAssignSupport.Click += this.cmdAssignSupport_Click;
        this.cboAssign.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cboAssign.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cboAssign.FormattingEnabled = true;
        this.cboAssign.Location = new Point(101, 5);
        this.cboAssign.Margin = new Padding(5, 5, 0, 0);
        this.cboAssign.Name = "cboAssign";
        this.cboAssign.Size = new Size(311, 21);
        this.cboAssign.TabIndex = 196;
        this.flowLayoutPanel5.Controls.Add(this.chkLocation);
        this.flowLayoutPanel5.Controls.Add(this.chkShips);
        this.flowLayoutPanel5.Controls.Add(this.chkPosition);
        this.flowLayoutPanel5.Controls.Add(this.chkElements);
        this.flowLayoutPanel5.Controls.Add(this.chkCivilian);
        this.flowLayoutPanel5.Controls.Add(this.chkShowSupport);
        this.flowLayoutPanel5.Controls.Add(this.chkPartial);
        this.flowLayoutPanel5.Controls.Add(this.chkCreationDate);
        this.flowLayoutPanel5.FlowDirection = FlowDirection.TopDown;
        this.flowLayoutPanel5.Location = new Point(3, 4);
        this.flowLayoutPanel5.Name = "flowLayoutPanel5";
        this.flowLayoutPanel5.Size = new Size(417, 50);
        this.flowLayoutPanel5.TabIndex = 195;
        this.chkLocation.AutoSize = true;
        this.chkLocation.Checked = true;
        this.chkLocation.CheckState = CheckState.Checked;
        this.chkLocation.Location = new Point(3, 3);
        this.chkLocation.Name = "chkLocation";
        this.chkLocation.Size = new Size(67, 17);
        this.chkLocation.TabIndex = 183;
        this.chkLocation.Text = "Location";
        this.chkLocation.UseVisualStyleBackColor = true;
        this.chkLocation.CheckedChanged += this.chkCreationDate_CheckedChanged;
        this.chkShips.AutoSize = true;
        this.chkShips.Location = new Point(3, 26);
        this.chkShips.Name = "chkShips";
        this.chkShips.Size = new Size(82, 17);
        this.chkShips.TabIndex = 199;
        this.chkShips.Text = "Show Ships";
        this.chkShips.UseVisualStyleBackColor = true;
        this.chkShips.CheckedChanged += this.chkCreationDate_CheckedChanged;
        this.chkPosition.AutoSize = true;
        this.chkPosition.Checked = true;
        this.chkPosition.CheckState = CheckState.Checked;
        this.chkPosition.Location = new Point(91, 3);
        this.chkPosition.Name = "chkPosition";
        this.chkPosition.Size = new Size(88, 17);
        this.chkPosition.TabIndex = 184;
        this.chkPosition.Text = "Field Position";
        this.chkPosition.UseVisualStyleBackColor = true;
        this.chkPosition.CheckedChanged += this.chkCreationDate_CheckedChanged;
        this.chkElements.AutoSize = true;
        this.chkElements.Location = new Point(91, 26);
        this.chkElements.Name = "chkElements";
        this.chkElements.Size = new Size(99, 17);
        this.chkElements.TabIndex = 194;
        this.chkElements.Text = "Show Elements";
        this.chkElements.UseVisualStyleBackColor = true;
        this.chkElements.CheckedChanged += this.chkCreationDate_CheckedChanged;
        this.chkCivilian.AutoSize = true;
        this.chkCivilian.Location = new Point(196, 3);
        this.chkCivilian.Name = "chkCivilian";
        this.chkCivilian.Size = new Size(89, 17);
        this.chkCivilian.TabIndex = 197;
        this.chkCivilian.Text = "Show Civilian";
        this.chkCivilian.UseVisualStyleBackColor = true;
        this.chkCivilian.CheckedChanged += this.chkCreationDate_CheckedChanged;
        this.chkShowSupport.AutoSize = true;
        this.chkShowSupport.Checked = true;
        this.chkShowSupport.CheckState = CheckState.Checked;
        this.chkShowSupport.Location = new Point(196, 26);
        this.chkShowSupport.Name = "chkShowSupport";
        this.chkShowSupport.Size = new Size(93, 17);
        this.chkShowSupport.TabIndex = 196;
        this.chkShowSupport.Text = "Show Support";
        this.chkShowSupport.UseVisualStyleBackColor = true;
        this.chkShowSupport.CheckedChanged += this.chkCreationDate_CheckedChanged;
        this.chkPartial.AutoSize = true;
        this.chkPartial.Location = new Point(295, 3);
        this.chkPartial.Name = "chkPartial";
        this.chkPartial.Size = new Size(96 /*0x60*/, 17);
        this.chkPartial.TabIndex = 195;
        this.chkPartial.Text = "Amount Popup";
        this.chkPartial.UseVisualStyleBackColor = true;
        this.chkCreationDate.AutoSize = true;
        this.chkCreationDate.Checked = true;
        this.chkCreationDate.CheckState = CheckState.Checked;
        this.chkCreationDate.Location = new Point(295, 26);
        this.chkCreationDate.Name = "chkCreationDate";
        this.chkCreationDate.Size = new Size(113, 17);
        this.chkCreationDate.TabIndex = 198;
        this.chkCreationDate.Text = "Sort Creation Date";
        this.chkCreationDate.UseVisualStyleBackColor = true;
        this.chkCreationDate.CheckedChanged += this.chkCreationDate_CheckedChanged;
        this.flowLayoutPanel2.Controls.Add(this.cmdRenameFormation);
        this.flowLayoutPanel2.Controls.Add(this.cmdFieldPosition);
        this.flowLayoutPanel2.Controls.Add(this.cmdRemoveParent);
        this.flowLayoutPanel2.Controls.Add(this.cmdClearSupport);
        this.flowLayoutPanel2.Controls.Add(this.cmdReplacementTemplate);
        this.flowLayoutPanel2.Controls.Add(this.cmdDNR);
        this.flowLayoutPanel2.Controls.Add(this.cmdDelete);
        this.flowLayoutPanel2.Controls.Add(this.cmdScrapFormation);
        this.flowLayoutPanel2.Controls.Add(this.cmdTransferAlien);
        this.flowLayoutPanel2.Controls.Add(this.cmdActive);
        this.flowLayoutPanel2.Controls.Add(this.cmdAwardMedal);
        this.flowLayoutPanel2.Controls.Add(this.cmdHierarchyMedal);
        this.flowLayoutPanel2.Controls.Add(this.cmdChangeFormationRank);
        this.flowLayoutPanel2.Controls.Add(this.cmdTotalForceText);
        this.flowLayoutPanel2.Location = new Point(3, 771);
        this.flowLayoutPanel2.Name = "flowLayoutPanel2";
        this.flowLayoutPanel2.Size = new Size(1362, 30);
        this.flowLayoutPanel2.TabIndex = 191;
        this.cmdRenameFormation.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdRenameFormation.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdRenameFormation.Location = new Point(0, 0);
        this.cmdRenameFormation.Margin = new Padding(0);
        this.cmdRenameFormation.Name = "cmdRenameFormation";
        this.cmdRenameFormation.Size = new Size(96 /*0x60*/, 30);
        this.cmdRenameFormation.TabIndex = 181;
        this.cmdRenameFormation.Tag = "1200";
        this.cmdRenameFormation.Text = "Rename";
        this.cmdRenameFormation.UseVisualStyleBackColor = false;
        this.cmdRenameFormation.Click += this.cmdRenameFormation_Click;
        this.cmdFieldPosition.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdFieldPosition.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdFieldPosition.Location = new Point(96 /*0x60*/, 0);
        this.cmdFieldPosition.Margin = new Padding(0);
        this.cmdFieldPosition.Name = "cmdFieldPosition";
        this.cmdFieldPosition.Size = new Size(96 /*0x60*/, 30);
        this.cmdFieldPosition.TabIndex = 190;
        this.cmdFieldPosition.Tag = "1200";
        this.cmdFieldPosition.Text = "Field Position";
        this.cmdFieldPosition.UseVisualStyleBackColor = false;
        this.cmdFieldPosition.Click += this.cmdFieldPosition_Click;
        this.cmdRemoveParent.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdRemoveParent.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdRemoveParent.Location = new Point(192 /*0xC0*/, 0);
        this.cmdRemoveParent.Margin = new Padding(0);
        this.cmdRemoveParent.Name = "cmdRemoveParent";
        this.cmdRemoveParent.Size = new Size(96 /*0x60*/, 30);
        this.cmdRemoveParent.TabIndex = 195;
        this.cmdRemoveParent.Tag = "1200";
        this.cmdRemoveParent.Text = "Clear Hierarchy";
        this.cmdRemoveParent.UseVisualStyleBackColor = false;
        this.cmdRemoveParent.Click += this.cmdRemoveParent_Click;
        this.cmdClearSupport.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdClearSupport.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdClearSupport.Location = new Point(288, 0);
        this.cmdClearSupport.Margin = new Padding(0);
        this.cmdClearSupport.Name = "cmdClearSupport";
        this.cmdClearSupport.Size = new Size(96 /*0x60*/, 30);
        this.cmdClearSupport.TabIndex = 197;
        this.cmdClearSupport.Tag = "1200";
        this.cmdClearSupport.Text = "Clear Support";
        this.cmdClearSupport.UseVisualStyleBackColor = false;
        this.cmdClearSupport.Click += this.cmdClearSupport_Click;
        this.cmdReplacementTemplate.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdReplacementTemplate.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdReplacementTemplate.Location = new Point(384, 0);
        this.cmdReplacementTemplate.Margin = new Padding(0);
        this.cmdReplacementTemplate.Name = "cmdReplacementTemplate";
        this.cmdReplacementTemplate.Size = new Size(96 /*0x60*/, 30);
        this.cmdReplacementTemplate.TabIndex = 198;
        this.cmdReplacementTemplate.Tag = "1200";
        this.cmdReplacementTemplate.Text = "Change Temp";
        this.cmdReplacementTemplate.UseVisualStyleBackColor = false;
        this.cmdReplacementTemplate.Click += this.cmdReplacementTemplate_Click;
        this.cmdDNR.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdDNR.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdDNR.Location = new Point(480, 0);
        this.cmdDNR.Margin = new Padding(0);
        this.cmdDNR.Name = "cmdDNR";
        this.cmdDNR.Size = new Size(96 /*0x60*/, 30);
        this.cmdDNR.TabIndex = 200;
        this.cmdDNR.Tag = "1200";
        this.cmdDNR.Text = "Do Not Recover";
        this.cmdDNR.UseVisualStyleBackColor = false;
        this.cmdDNR.Click += this.cmdDNR_Click;
        this.cmdDelete.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdDelete.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdDelete.Location = new Point(576, 0);
        this.cmdDelete.Margin = new Padding(0);
        this.cmdDelete.Name = "cmdDelete";
        this.cmdDelete.Size = new Size(96 /*0x60*/, 30);
        this.cmdDelete.TabIndex = 192 /*0xC0*/;
        this.cmdDelete.Tag = "1200";
        this.cmdDelete.Text = "Delete Formation";
        this.cmdDelete.UseVisualStyleBackColor = false;
        this.cmdDelete.Click += this.cmdDelete_Click;
        this.cmdScrapFormation.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdScrapFormation.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdScrapFormation.Location = new Point(672, 0);
        this.cmdScrapFormation.Margin = new Padding(0);
        this.cmdScrapFormation.Name = "cmdScrapFormation";
        this.cmdScrapFormation.Size = new Size(96 /*0x60*/, 30);
        this.cmdScrapFormation.TabIndex = 199;
        this.cmdScrapFormation.Tag = "1200";
        this.cmdScrapFormation.Text = "Scrap Formation";
        this.cmdScrapFormation.UseVisualStyleBackColor = false;
        this.cmdScrapFormation.Click += this.cmdScrapFormation_Click;
        this.cmdTransferAlien.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdTransferAlien.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdTransferAlien.Location = new Point(768 /*0x0300*/, 0);
        this.cmdTransferAlien.Margin = new Padding(0);
        this.cmdTransferAlien.Name = "cmdTransferAlien";
        this.cmdTransferAlien.Size = new Size(96 /*0x60*/, 30);
        this.cmdTransferAlien.TabIndex = 188;
        this.cmdTransferAlien.Tag = "1200";
        this.cmdTransferAlien.Text = "Transfer Alien";
        this.cmdTransferAlien.UseVisualStyleBackColor = false;
        this.cmdTransferAlien.Click += this.cmdTransferAlien_Click;
        this.cmdActive.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdActive.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdActive.Location = new Point(864, 0);
        this.cmdActive.Margin = new Padding(0);
        this.cmdActive.Name = "cmdActive";
        this.cmdActive.Size = new Size(96 /*0x60*/, 30);
        this.cmdActive.TabIndex = 191;
        this.cmdActive.Tag = "1200";
        this.cmdActive.Text = "Active On";
        this.cmdActive.UseVisualStyleBackColor = false;
        this.cmdActive.Click += this.cmdActive_Click;
        this.cmdAwardMedal.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdAwardMedal.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdAwardMedal.Location = new Point(960, 0);
        this.cmdAwardMedal.Margin = new Padding(0);
        this.cmdAwardMedal.Name = "cmdAwardMedal";
        this.cmdAwardMedal.Size = new Size(96 /*0x60*/, 30);
        this.cmdAwardMedal.TabIndex = 193;
        this.cmdAwardMedal.Tag = "1200";
        this.cmdAwardMedal.Text = "Formation Medal";
        this.cmdAwardMedal.UseVisualStyleBackColor = false;
        this.cmdAwardMedal.Click += this.cmdAwardMedal_Click;
        this.cmdHierarchyMedal.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdHierarchyMedal.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdHierarchyMedal.Location = new Point(1056, 0);
        this.cmdHierarchyMedal.Margin = new Padding(0);
        this.cmdHierarchyMedal.Name = "cmdHierarchyMedal";
        this.cmdHierarchyMedal.Size = new Size(96 /*0x60*/, 30);
        this.cmdHierarchyMedal.TabIndex = 194;
        this.cmdHierarchyMedal.Tag = "1200";
        this.cmdHierarchyMedal.Text = "Hierarchy Medal";
        this.cmdHierarchyMedal.UseVisualStyleBackColor = false;
        this.cmdHierarchyMedal.Click += this.cmdHierarchyMedal_Click;
        this.cmdChangeFormationRank.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdChangeFormationRank.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdChangeFormationRank.Location = new Point(1152, 0);
        this.cmdChangeFormationRank.Margin = new Padding(0);
        this.cmdChangeFormationRank.Name = "cmdChangeFormationRank";
        this.cmdChangeFormationRank.Size = new Size(96 /*0x60*/, 30);
        this.cmdChangeFormationRank.TabIndex = 187;
        this.cmdChangeFormationRank.Tag = "1200";
        this.cmdChangeFormationRank.Text = "Change Rank";
        this.cmdChangeFormationRank.UseVisualStyleBackColor = false;
        this.cmdChangeFormationRank.Click += this.cmdChangeFormationRank_Click;
        this.cmdTotalForceText.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdTotalForceText.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdTotalForceText.Location = new Point(1248, 0);
        this.cmdTotalForceText.Margin = new Padding(0);
        this.cmdTotalForceText.Name = "cmdTotalForceText";
        this.cmdTotalForceText.Size = new Size(96 /*0x60*/, 30);
        this.cmdTotalForceText.TabIndex = 196;
        this.cmdTotalForceText.Tag = "1200";
        this.cmdTotalForceText.Text = "Total Force Text";
        this.cmdTotalForceText.UseVisualStyleBackColor = false;
        this.cmdTotalForceText.Click += this.cmdTotalForceText_Click;
        this.flowLayoutPanel1.BorderStyle = BorderStyle.FixedSingle;
        this.flowLayoutPanel1.Controls.Add(this.cmdSortCost);
        this.flowLayoutPanel1.Controls.Add(this.cmdSortSize);
        this.flowLayoutPanel1.Controls.Add(this.cmdSortUnits);
        this.flowLayoutPanel1.Controls.Add(this.cmdSortName);
        this.flowLayoutPanel1.Controls.Add(this.cmdSortTypeSize);
        this.flowLayoutPanel1.Controls.Add(this.cmdSortTypeCost);
        this.flowLayoutPanel1.Location = new Point(1270, 579);
        this.flowLayoutPanel1.Name = "flowLayoutPanel1";
        this.flowLayoutPanel1.Size = new Size(98, 188);
        this.flowLayoutPanel1.TabIndex = 186;
        this.cmdSortCost.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdSortCost.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdSortCost.Location = new Point(0, 0);
        this.cmdSortCost.Margin = new Padding(0);
        this.cmdSortCost.Name = "cmdSortCost";
        this.cmdSortCost.Size = new Size(96 /*0x60*/, 30);
        this.cmdSortCost.TabIndex = 177;
        this.cmdSortCost.Tag = "1200";
        this.cmdSortCost.Text = "Cost";
        this.cmdSortCost.UseVisualStyleBackColor = false;
        this.cmdSortCost.Click += this.cmdSortTypeCost_Click;
        this.cmdSortSize.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdSortSize.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdSortSize.Location = new Point(0, 31 /*0x1F*/);
        this.cmdSortSize.Margin = new Padding(0, 1, 0, 0);
        this.cmdSortSize.Name = "cmdSortSize";
        this.cmdSortSize.Size = new Size(96 /*0x60*/, 30);
        this.cmdSortSize.TabIndex = 178;
        this.cmdSortSize.Tag = "1200";
        this.cmdSortSize.Text = "Size";
        this.cmdSortSize.UseVisualStyleBackColor = false;
        this.cmdSortSize.Click += this.cmdSortTypeCost_Click;
        this.cmdSortUnits.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdSortUnits.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdSortUnits.Location = new Point(0, 62);
        this.cmdSortUnits.Margin = new Padding(0, 1, 0, 0);
        this.cmdSortUnits.Name = "cmdSortUnits";
        this.cmdSortUnits.Size = new Size(96 /*0x60*/, 30);
        this.cmdSortUnits.TabIndex = 179;
        this.cmdSortUnits.Tag = "1200";
        this.cmdSortUnits.Text = "Units";
        this.cmdSortUnits.UseVisualStyleBackColor = false;
        this.cmdSortUnits.Click += this.cmdSortTypeCost_Click;
        this.cmdSortName.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdSortName.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdSortName.Location = new Point(0, 93);
        this.cmdSortName.Margin = new Padding(0, 1, 0, 0);
        this.cmdSortName.Name = "cmdSortName";
        this.cmdSortName.Size = new Size(96 /*0x60*/, 30);
        this.cmdSortName.TabIndex = 180;
        this.cmdSortName.Tag = "1200";
        this.cmdSortName.Text = "Name";
        this.cmdSortName.UseVisualStyleBackColor = false;
        this.cmdSortName.Click += this.cmdSortTypeCost_Click;
        this.cmdSortTypeSize.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdSortTypeSize.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdSortTypeSize.Location = new Point(0, 124);
        this.cmdSortTypeSize.Margin = new Padding(0, 1, 0, 0);
        this.cmdSortTypeSize.Name = "cmdSortTypeSize";
        this.cmdSortTypeSize.Size = new Size(96 /*0x60*/, 30);
        this.cmdSortTypeSize.TabIndex = 185;
        this.cmdSortTypeSize.Tag = "1200";
        this.cmdSortTypeSize.Text = "Type / Size";
        this.cmdSortTypeSize.UseVisualStyleBackColor = false;
        this.cmdSortTypeSize.Click += this.cmdSortTypeCost_Click;
        this.cmdSortTypeCost.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdSortTypeCost.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdSortTypeCost.Location = new Point(0, 155);
        this.cmdSortTypeCost.Margin = new Padding(0, 1, 0, 0);
        this.cmdSortTypeCost.Name = "cmdSortTypeCost";
        this.cmdSortTypeCost.Size = new Size(96 /*0x60*/, 30);
        this.cmdSortTypeCost.TabIndex = 186;
        this.cmdSortTypeCost.Tag = "1200";
        this.cmdSortTypeCost.Text = "Type / Cost";
        this.cmdSortTypeCost.UseVisualStyleBackColor = false;
        this.cmdSortTypeCost.Click += this.cmdSortTypeCost_Click;
        this.txtElementClass.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtElementClass.BorderStyle = BorderStyle.FixedSingle;
        this.txtElementClass.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
        this.txtElementClass.ForeColor = Color.FromArgb(128 /*0x80*/, 255, 128 /*0x80*/);
        this.txtElementClass.Location = new Point(426, 579);
        this.txtElementClass.Margin = new Padding(3, 3, 3, 0);
        this.txtElementClass.Multiline = true;
        this.txtElementClass.Name = "txtElementClass";
        this.txtElementClass.ReadOnly = true;
        this.txtElementClass.Size = new Size(838, 188);
        this.txtElementClass.TabIndex = 176 /*0xB0*/;
        this.txtElementClass.Text = "No Element Selected";
        this.txtCmdr.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtCmdr.BorderStyle = BorderStyle.FixedSingle;
        this.txtCmdr.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.txtCmdr.Location = new Point(426, 32 /*0x20*/);
        this.txtCmdr.Name = "txtCmdr";
        this.txtCmdr.Size = new Size(942, 20);
        this.txtCmdr.TabIndex = 175;
        this.lstvFormationUnitList.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.lstvFormationUnitList.BorderStyle = BorderStyle.FixedSingle;
        this.lstvFormationUnitList.Columns.AddRange(new ColumnHeader[13]
        {
            this.columnHeader_62,
            this.columnHeader_63,
            this.columnHeader_64,
            this.columnHeader_65,
            this.columnHeader_66,
            this.columnHeader_67,
            this.columnHeader_68,
            this.columnHeader_69,
            this.columnHeader_70,
            this.columnHeader_71,
            this.columnHeader_72,
            this.columnHeader_73,
            this.columnHeader_74
        });
        this.lstvFormationUnitList.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.lstvFormationUnitList.FullRowSelect = true;
        this.lstvFormationUnitList.HeaderStyle = ColumnHeaderStyle.None;
        this.lstvFormationUnitList.HideSelection = false;
        this.lstvFormationUnitList.Location = new Point(426, 57);
        this.lstvFormationUnitList.Name = "lstvFormationUnitList";
        this.lstvFormationUnitList.Size = new Size(942, 519);
        this.lstvFormationUnitList.TabIndex = 174;
        this.lstvFormationUnitList.UseCompatibleStateImageBehavior = false;
        this.lstvFormationUnitList.View = View.Details;
        this.lstvFormationUnitList.SelectedIndexChanged += this.lstvFormationUnitList_SelectedIndexChanged;
        this.columnHeader_62.Width = 40;
        this.columnHeader_63.Width = 217;
        this.columnHeader_64.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_64.Width = 50;
        this.columnHeader_65.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_65.Width = 50;
        this.columnHeader_66.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_66.Width = 45;
        this.columnHeader_67.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_67.Width = 45;
        this.columnHeader_68.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_68.Width = 55;
        this.columnHeader_69.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_69.Width = 50;
        this.columnHeader_70.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_70.Width = 55;
        this.columnHeader_71.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_71.Width = 55;
        this.columnHeader_72.Width = 180;
        this.columnHeader_73.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_73.Width = 40;
        this.columnHeader_74.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_74.Width = 40;
        this.tvFormations.AllowDrop = true;
        this.tvFormations.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.tvFormations.BorderStyle = BorderStyle.FixedSingle;
        this.tvFormations.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.tvFormations.HideSelection = false;
        this.tvFormations.Location = new Point(3, 57);
        this.tvFormations.Margin = new Padding(3, 0, 0, 3);
        this.tvFormations.Name = "tvFormations";
        this.tvFormations.Size = new Size(420, 710);
        this.tvFormations.TabIndex = 38;
        this.tvFormations.AfterCollapse += this.tvFormations_AfterCollapse;
        this.tvFormations.AfterExpand += this.tvFormations_AfterExpand;
        this.tvFormations.ItemDrag += this.tvFormations_ItemDrag;
        this.tvFormations.AfterSelect += this.tvFormations_AfterSelect;
        this.tvFormations.DragDrop += this.tvFormations_DragDrop;
        this.tvFormations.DragEnter += this.tvFormations_DragEnter;
        this.tabGround.Controls.Add(this.tabFormations);
        this.tabGround.Controls.Add(this.tabTemplates);
        this.tabGround.Controls.Add(this.tabUnitClassDesign);
        this.tabGround.Controls.Add(this.tabPage1);
        this.tabGround.Controls.Add(this.tabUnitSeries);
        this.tabGround.Controls.Add(this.tabPage2);
        this.tabGround.Location = new Point(3, 29);
        this.tabGround.Name = "tabGround";
        this.tabGround.SelectedIndex = 0;
        this.tabGround.Size = new Size(1379, 830);
        this.tabGround.TabIndex = 158;
        this.tabPage2.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.tabPage2.Controls.Add(this.lstvOrgSummary);
        this.tabPage2.Controls.Add(this.tvTemplateNodes);
        this.tabPage2.Controls.Add(this.flowLayoutPanel10);
        this.tabPage2.Controls.Add(this.tvOrganization);
        this.tabPage2.Location = new Point(4, 22);
        this.tabPage2.Name = "tabPage2";
        this.tabPage2.Padding = new Padding(3);
        this.tabPage2.Size = new Size(1371, 804);
        this.tabPage2.TabIndex = 5;
        this.tabPage2.Text = "Organizations";
        this.tabPage2.Click += this.tabPage2_Click;
        this.lstvOrgSummary.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.lstvOrgSummary.BorderStyle = BorderStyle.FixedSingle;
        this.lstvOrgSummary.Columns.AddRange(new ColumnHeader[2]
        {
            this.columnHeader_75,
            this.columnHeader_76
        });
        this.lstvOrgSummary.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.lstvOrgSummary.FullRowSelect = true;
        this.lstvOrgSummary.HeaderStyle = ColumnHeaderStyle.None;
        this.lstvOrgSummary.HideSelection = false;
        this.lstvOrgSummary.Location = new Point(1037, 3);
        this.lstvOrgSummary.Margin = new Padding(3, 0, 3, 0);
        this.lstvOrgSummary.Name = "lstvOrgSummary";
        this.lstvOrgSummary.Size = new Size(331, 766);
        this.lstvOrgSummary.TabIndex = 150;
        this.lstvOrgSummary.UseCompatibleStateImageBehavior = false;
        this.lstvOrgSummary.View = View.Details;
        this.columnHeader_75.Width = 100;
        this.columnHeader_76.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_76.Width = 200;
        this.tvTemplateNodes.AllowDrop = true;
        this.tvTemplateNodes.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.tvTemplateNodes.BorderStyle = BorderStyle.FixedSingle;
        this.tvTemplateNodes.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.tvTemplateNodes.HideSelection = false;
        this.tvTemplateNodes.Location = new Point(520, 3);
        this.tvTemplateNodes.Margin = new Padding(3, 0, 0, 3);
        this.tvTemplateNodes.Name = "tvTemplateNodes";
        this.tvTemplateNodes.Size = new Size(514, 766);
        this.tvTemplateNodes.TabIndex = 149;
        this.tvTemplateNodes.AfterCollapse += this.tvTemplateNodes_AfterCollapse;
        this.tvTemplateNodes.AfterExpand += this.tvTemplateNodes_AfterExpand;
        this.tvTemplateNodes.ItemDrag += this.tvTemplateNodes_ItemDrag;
        this.tvTemplateNodes.AfterSelect += this.tvTemplateNodes_AfterSelect;
        this.tvTemplateNodes.DragEnter += this.tvTemplateNodes_DragEnter;
        this.flowLayoutPanel10.Controls.Add(this.cmdCreateOrg);
        this.flowLayoutPanel10.Controls.Add(this.cmdNodeFieldPosition);
        this.flowLayoutPanel10.Controls.Add(this.cmdDeleteNode);
        this.flowLayoutPanel10.Controls.Add(this.cmdConstructOrganization);
        this.flowLayoutPanel10.Controls.Add(this.cmdInstantOrg);
        this.flowLayoutPanel10.Controls.Add(this.cboPopulations);
        this.flowLayoutPanel10.Controls.Add(this.chkEnterNames);
        this.flowLayoutPanel10.Controls.Add(this.label6);
        this.flowLayoutPanel10.Location = new Point(3, 772);
        this.flowLayoutPanel10.Name = "flowLayoutPanel10";
        this.flowLayoutPanel10.Size = new Size(1362, 32 /*0x20*/);
        this.flowLayoutPanel10.TabIndex = 148;
        this.cmdCreateOrg.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdCreateOrg.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdCreateOrg.Location = new Point(0, 0);
        this.cmdCreateOrg.Margin = new Padding(0);
        this.cmdCreateOrg.Name = "cmdCreateOrg";
        this.cmdCreateOrg.Size = new Size(96 /*0x60*/, 30);
        this.cmdCreateOrg.TabIndex = 146;
        this.cmdCreateOrg.Tag = "1200";
        this.cmdCreateOrg.Text = "Create Org";
        this.cmdCreateOrg.UseVisualStyleBackColor = false;
        this.cmdCreateOrg.Click += this.cmdCreateOrg_Click;
        this.cmdNodeFieldPosition.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdNodeFieldPosition.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdNodeFieldPosition.Location = new Point(96 /*0x60*/, 0);
        this.cmdNodeFieldPosition.Margin = new Padding(0);
        this.cmdNodeFieldPosition.Name = "cmdNodeFieldPosition";
        this.cmdNodeFieldPosition.Size = new Size(96 /*0x60*/, 30);
        this.cmdNodeFieldPosition.TabIndex = 191;
        this.cmdNodeFieldPosition.Tag = "1200";
        this.cmdNodeFieldPosition.Text = "Field Position";
        this.cmdNodeFieldPosition.UseVisualStyleBackColor = false;
        this.cmdNodeFieldPosition.Click += this.cmdNodeFieldPosition_Click;
        this.cmdDeleteNode.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdDeleteNode.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdDeleteNode.Location = new Point(192 /*0xC0*/, 0);
        this.cmdDeleteNode.Margin = new Padding(0);
        this.cmdDeleteNode.Name = "cmdDeleteNode";
        this.cmdDeleteNode.Size = new Size(96 /*0x60*/, 30);
        this.cmdDeleteNode.TabIndex = 147;
        this.cmdDeleteNode.Tag = "1200";
        this.cmdDeleteNode.Text = "Delete Node";
        this.cmdDeleteNode.UseVisualStyleBackColor = false;
        this.cmdDeleteNode.Click += this.cmdDeleteNode_Click;
        this.cmdConstructOrganization.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdConstructOrganization.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdConstructOrganization.Location = new Point(288, 0);
        this.cmdConstructOrganization.Margin = new Padding(0);
        this.cmdConstructOrganization.Name = "cmdConstructOrganization";
        this.cmdConstructOrganization.Size = new Size(96 /*0x60*/, 30);
        this.cmdConstructOrganization.TabIndex = 150;
        this.cmdConstructOrganization.Tag = "1200";
        this.cmdConstructOrganization.Text = "Construct Org";
        this.cmdConstructOrganization.UseVisualStyleBackColor = false;
        this.cmdConstructOrganization.Click += this.cmdConstructOrganization_Click;
        this.cmdInstantOrg.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdInstantOrg.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdInstantOrg.Location = new Point(384, 0);
        this.cmdInstantOrg.Margin = new Padding(0);
        this.cmdInstantOrg.Name = "cmdInstantOrg";
        this.cmdInstantOrg.Size = new Size(96 /*0x60*/, 30);
        this.cmdInstantOrg.TabIndex = 192 /*0xC0*/;
        this.cmdInstantOrg.Tag = "1200";
        this.cmdInstantOrg.Text = "Instant Org";
        this.cmdInstantOrg.UseVisualStyleBackColor = false;
        this.cmdInstantOrg.Click += this.cmdInstantOrg_Click;
        this.cboPopulations.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cboPopulations.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cboPopulations.FormattingEnabled = true;
        this.cboPopulations.Location = new Point(483, 3);
        this.cboPopulations.Margin = new Padding(3, 3, 3, 0);
        this.cboPopulations.Name = "cboPopulations";
        this.cboPopulations.Size = new Size(223, 21);
        this.cboPopulations.TabIndex = 154;
        this.label6.AutoSize = true;
        this.label6.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.label6.Location = new Point(832, 8);
        this.label6.Margin = new Padding(24, 8, 3, 3);
        this.label6.Name = "label6";
        this.label6.Size = new Size(487, 13);
        this.label6.TabIndex = 153;
        this.label6.Text =
            "Dragging a node with no parent will copy the node. Dragging a node with a parent will move the node.";
        this.tvOrganization.AllowDrop = true;
        this.tvOrganization.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.tvOrganization.BorderStyle = BorderStyle.FixedSingle;
        this.tvOrganization.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.tvOrganization.HideSelection = false;
        this.tvOrganization.Location = new Point(3, 3);
        this.tvOrganization.Margin = new Padding(3, 0, 0, 3);
        this.tvOrganization.Name = "tvOrganization";
        this.tvOrganization.Size = new Size(514, 766);
        this.tvOrganization.TabIndex = 147;
        this.tvOrganization.AfterCollapse += this.tvOrganization_AfterCollapse;
        this.tvOrganization.AfterExpand += this.tvOrganization_AfterExpand;
        this.tvOrganization.ItemDrag += this.tvOrganization_ItemDrag;
        this.tvOrganization.AfterSelect += this.tvOrganization_AfterSelect;
        this.tvOrganization.DragDrop += this.tvOrganization_DragDrop;
        this.tvOrganization.DragEnter += this.tvOrganization_DragEnter;
        this.chkEnterNames.AutoSize = true;
        this.chkEnterNames.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.chkEnterNames.Location = new Point(718, 6);
        this.chkEnterNames.Margin = new Padding(9, 6, 3, 3);
        this.chkEnterNames.Name = "chkEnterNames";
        this.chkEnterNames.Size = new Size(87, 17);
        this.chkEnterNames.TabIndex = 175;
        this.chkEnterNames.Text = "Enter Names";
        this.chkEnterNames.UseVisualStyleBackColor = true;
        this.AutoScaleDimensions = new SizeF(6f, 13f);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.ClientSize = new Size(1384, 861);
        this.Controls.Add(this.txtFCRange);
        this.Controls.Add(this.label1);
        this.Controls.Add(this.txtBeamTracking);
        this.Controls.Add(this.label4);
        this.Controls.Add(this.tabGround);
        this.Controls.Add(this.txtBaseWeapon);
        this.Controls.Add(this.label9);
        this.Controls.Add(this.txtBaseArmour);
        this.Controls.Add(this.label8);
        this.Controls.Add(this.cboRaces);
        this.FormBorderStyle = FormBorderStyle.FixedSingle;
        this.KeyPreview = true;
        this.Name = "GroundUnitDesign";
        this.Text = "Ground Forces";
        this.FormClosing += this.GroundUnitDesign_FormClosing;
        this.Load += this.GroundUnitDesign_Load;
        this.KeyDown += this.GroundUnitDesign_KeyDown;
        this.tabUnitSeries.ResumeLayout(false);
        this.tabUnitSeries.PerformLayout();
        this.flowLayoutPanel4.ResumeLayout(false);
        this.tabPage1.ResumeLayout(false);
        this.tabPage1.PerformLayout();
        this.tabUnitClassDesign.ResumeLayout(false);
        this.tabUnitClassDesign.PerformLayout();
        this.pnlBlank.ResumeLayout(false);
        this.flowLayoutPanel6.ResumeLayout(false);
        this.flowLayoutPanel6.PerformLayout();
        this.tabTemplates.ResumeLayout(false);
        this.tabTemplates.PerformLayout();
        this.flowLayoutPanel11.ResumeLayout(false);
        this.flowLayoutPanel11.PerformLayout();
        this.flowLayoutPanel9.ResumeLayout(false);
        this.flowLayoutPanel7.ResumeLayout(false);
        this.flowLayoutPanel7.PerformLayout();
        this.tabFormations.ResumeLayout(false);
        this.tabFormations.PerformLayout();
        this.flowLayoutPanel8.ResumeLayout(false);
        this.flowLayoutPanel8.PerformLayout();
        this.flpAssign.ResumeLayout(false);
        this.flowLayoutPanel5.ResumeLayout(false);
        this.flowLayoutPanel5.PerformLayout();
        this.flowLayoutPanel2.ResumeLayout(false);
        this.flowLayoutPanel1.ResumeLayout(false);
        this.tabGround.ResumeLayout(false);
        this.tabPage2.ResumeLayout(false);
        this.flowLayoutPanel10.ResumeLayout(false);
        this.flowLayoutPanel10.PerformLayout();
        this.ResumeLayout(false);
        this.PerformLayout();
    }
}