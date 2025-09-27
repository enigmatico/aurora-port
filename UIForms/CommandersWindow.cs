// Decompiled with JetBrains decompiler
// Type: CommandersWindow
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
public class CommandersWindow : Form
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

    private sealed class Class892
    {
        public GClass55 gclass55_0;

        internal bool method_0(ResearchFieldData gclass162_0)
        {
            return !gclass162_0.bDoNotDisplay && gclass162_0 != this.gclass55_0.gclass162_0;
        }
    }

    private sealed class Class893
    {
        public GClass55 gclass55_0;

        internal bool method_0(GClass55 gclass55_1)
        {
            return gclass55_1.gclass61_0 == this.gclass55_0.gclass61_0;
        }
    }

    private GClass0 gclass0_0;
    private GameRace gclass21_0;
    private GClass55 gclass55_0;
    private GClass55 gclass55_1;
    private RankThemeEntry gclass61_0;
    private bool bool_0;
    private IContainer icontainer_0;
    private TreeView tvCommanderList;
    private ComboBox cboRaces;
    private Button cmdRename;
    private Button cmdPromote;
    private FlowLayoutPanel flowLayoutPanel1;
    private Button cmdDemote;
    private ListView lstvCmdrSummary;
    private ColumnHeader columnHeader_0;
    private ColumnHeader columnHeader_1;
    private ListView lstvBonus;
    private ColumnHeader columnHeader_2;
    private ColumnHeader columnHeader_3;
    private FlowLayoutPanel flowLayoutPanel2;
    private Label lblName;
    private Label lblAssignment;
    private ListView lstvHistory;
    private ColumnHeader columnHeader_4;
    private ColumnHeader columnHeader_5;
    private FlowLayoutPanel flpMedals;
    private FlowLayoutPanel flpAssignments;
    private ComboBox cboAssign;
    private ListView lstvAssign;
    private ColumnHeader columnHeader_6;
    private ColumnHeader columnHeader_7;
    private ColumnHeader columnHeader_8;
    private Button cmdUnassign;
    private Button cmdAssign;
    private CheckBox chkEligible;
    private CheckBox chkAvailable;
    private ColumnHeader columnHeader_9;
    private FlowLayoutPanel flpSearch;
    private ComboBox cboSort1;
    private ComboBox cboSort2;
    private ComboBox cboSort3;
    private ComboBox cboSort4;
    private ListView lstvSearch;
    private ColumnHeader columnHeader_10;
    private ColumnHeader columnHeader_11;
    private ColumnHeader columnHeader_12;
    private ColumnHeader columnHeader_13;
    private ColumnHeader columnHeader_14;
    private ComboBox cboType;
    private ColumnHeader columnHeader_15;
    private Button cmdAutoRename;
    private Button cmdReplaceAll;
    private Button cmdAwardMedal;
    private Button cmdRetire;
    private Button cmdReassignNaval;
    private Button cmdRenameAll;
    private CheckBox chkAutoAssign;
    private Button cmdCreateMedal;
    private Button cmdHideMedals;
    private Button cmdAddNavalRank;
    private Button cmdDeleteNavalRank;
    private Panel panel1;
    private CheckBox chkDoNotPromote;
    private CheckBox chkStory;
    private ComboBox cboMinRank;
    private Label label1;
    private Label label2;
    private ComboBox cboMaxRank;
    private Button cmdChangeField;
    private Button cmdAddExtra;
    private Button cmdRestore;
    private Button cmdRetain;

    public CommandersWindow(GClass0 gclass0_1)
    {
        this.InitializeComponent();
        this.DoubleBuffered = true;
        this.gclass0_0 = gclass0_1;
    }

    private void CommandersWindow_FormClosing(object sender, FormClosingEventArgs e)
    {
        try
        {
            this.gclass0_0.method_512(this.Name, this.Left, this.Top);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 419);
        }
    }

    private void CommandersWindow_Load(object sender, EventArgs e)
    {
        try
        {
            WindowPosition207 gclass207 = this.gclass0_0.method_513(this.Name);
            this.Left = gclass207.Left;
            this.Top = gclass207.Top;
            if (this.gclass0_0.bool_8)
            {
                this.cmdAddExtra.Visible = true;
                this.cmdReplaceAll.Visible = true;
            }
            else
            {
                this.cmdAddExtra.Visible = false;
                this.cmdReplaceAll.Visible = false;
            }

            this.gclass0_0.bool_9 = true;
            this.gclass0_0.method_579(this.cboType);
            this.bool_0 = true;
            this.gclass0_0.method_577(this.cboRaces);
            this.gclass0_0.bool_9 = false;
            this.method_2();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 420);
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
            AuroraUtils.ShowExceptionPopup(ex, 421);
        }
    }

    private void cboRaces_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            this.lstvCmdrSummary.Items.Clear();
            this.lstvBonus.Items.Clear();
            this.lstvHistory.Items.Clear();
            this.lstvAssign.Items.Clear();
            this.lblName.Text = "";
            this.lblAssignment.Text = "";
            this.gclass21_0 = (GameRace)this.cboRaces.SelectedValue;
            this.chkAutoAssign.CheckState =
                this.gclass21_0.chkAutoAssign != 1 ? CheckState.Unchecked : CheckState.Checked;
            this.gclass21_0.method_234(this.tvCommanderList);
            this.method_2();
            if (!this.bool_0)
                this.gclass0_0.method_511(this.gclass21_0, this);
            this.bool_0 = false;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 422);
        }
    }

    private void tvCommanderList_AfterSelect(object sender, TreeViewEventArgs e)
    {
        try
        {
            this.cmdPromote.Visible = false;
            this.cmdDemote.Visible = false;
            this.cmdRename.Visible = false;
            this.cmdRestore.Visible = false;
            this.cmdRetain.Visible = false;
            this.cmdDeleteNavalRank.Visible = false;
            this.cmdAddNavalRank.Visible = false;
            this.cmdChangeField.Visible = false;
            this.cmdRetire.Visible = true;
            this.cmdAssign.Visible = true;
            if (e.Node.Tag is GClass55)
            {
                this.gclass55_1 = this.gclass55_0;
                this.gclass55_0 = (GClass55)e.Node.Tag;
                this.cmdRename.Visible = true;
                if (this.gclass55_0.auroraRetirementStatus_0 != AuroraRetirementStatus.Active)
                {
                    this.cmdRetire.Visible = false;
                    this.cmdAssign.Visible = false;
                    this.cmdRetain.Visible = true;
                    if (this.gclass0_0.bool_8)
                        this.cmdRestore.Visible = true;
                }
                else if (this.gclass55_0.auroraCommanderType_0 != AuroraCommanderType.Naval &&
                         this.gclass55_0.auroraCommanderType_0 != AuroraCommanderType.GroundForce)
                {
                    if (this.gclass55_0.auroraCommanderType_0 == AuroraCommanderType.Scientist)
                        this.cmdChangeField.Visible = true;
                }
                else
                {
                    if (this.gclass55_0.gclass61_0.method_1() != null)
                        this.cmdPromote.Visible = true;
                    if (this.gclass55_0.gclass61_0.method_3() != null)
                        this.cmdDemote.Visible = true;
                }

                this.gclass55_0.method_19(this.lstvCmdrSummary, this.lstvBonus, this.lstvHistory, this.lstvAssign,
                    this.cboAssign, this.chkEligible, this.chkAvailable, this.lblName, this.lblAssignment,
                    this.gclass55_1, this.flpMedals, this.chkDoNotPromote, this.chkStory);
            }
            else
            {
                if (!(e.Node.Tag is RankThemeEntry))
                    return;
                this.gclass61_0 = (RankThemeEntry)e.Node.Tag;
                this.cmdRename.Visible = true;
                if (this.gclass61_0.CommanderType == AuroraCommanderType.Naval ||
                    this.gclass61_0.CommanderType == AuroraCommanderType.GroundForce)
                {
                    this.cmdAddNavalRank.Visible = true;
                    this.cmdDeleteNavalRank.Visible = true;
                }

                this.gclass0_0.method_510(this.cboAssign, this.gclass61_0.CommanderType);
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 423);
        }
    }

    private void cmdRename_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass21_0 == null)
            {
                int num1 = (int)MessageBox.Show("Please select a race");
            }
            else if (this.tvCommanderList.SelectedNode == null)
            {
                int num2 = (int)MessageBox.Show("Please select an item to rename");
            }
            else if (this.tvCommanderList.SelectedNode.Tag is GClass55)
            {
                GClass55 tag = (GClass55)this.tvCommanderList.SelectedNode.Tag;
                string str = this.gclass0_0.method_562("Enter New Commander Name", tag.string_0);
                if (!(str != ""))
                    return;
                tag.string_0 = str;
                this.tvCommanderList.SelectedNode.Text = tag.method_26();
            }
            else
            {
                if (!(this.tvCommanderList.SelectedNode.Tag is RankThemeEntry))
                    return;
                RankThemeEntry tag = (RankThemeEntry)this.tvCommanderList.SelectedNode.Tag;
                string str1 = this.gclass0_0.method_562("Enter New Rank Name", tag.RankName);
                if (!(str1 != ""))
                    return;
                string str2 = this.gclass0_0.method_562("Enter New Rank Abbreviation", tag.RankAbbreviation);
                if (!(str2 != ""))
                    return;
                tag.RankName = str1;
                tag.RankAbbreviation = str2;
                this.tvCommanderList.SelectedNode.Text = $"{tag.RankAbbreviation} {tag.RankName}";
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 424);
        }
    }

    private void cmdPromote_Click(object sender, EventArgs e)
    {
        try
        {
            if (!this.method_1())
                return;
            if (this.tvCommanderList.SelectedNode.Tag is GClass55)
            {
                GClass55 tag = (GClass55)this.tvCommanderList.SelectedNode.Tag;
                if (tag.auroraCommanderType_0 != AuroraCommanderType.Scientist &&
                    tag.auroraCommanderType_0 != AuroraCommanderType.Administrator)
                {
                    if (tag.gclass61_0.method_1() == null)
                    {
                        int num = (int)MessageBox.Show("No higher rank available");
                        return;
                    }

                    this.gclass21_0.method_250(tag, true);
                    TreeNode selectedNode = this.tvCommanderList.SelectedNode;
                    selectedNode.Remove();
                    foreach (TreeNode node1 in this.tvCommanderList.Nodes)
                    {
                        foreach (TreeNode node2 in node1.Nodes)
                        {
                            if (node2.Tag is RankThemeEntry && (RankThemeEntry)node2.Tag == tag.gclass61_0)
                            {
                                node2.Nodes.Add(selectedNode);
                                this.tvCommanderList.SelectedNode = selectedNode;
                                break;
                            }
                        }
                    }
                }
                else
                {
                    int num = (int)MessageBox.Show("Only naval or ground commanders can be promoted");
                    return;
                }
            }

            this.method_4();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 425);
        }
    }

    private void cmdDemote_Click(object sender, EventArgs e)
    {
        try
        {
            if (!this.method_1())
                return;
            if (this.tvCommanderList.SelectedNode.Tag is GClass55)
            {
                GClass55 tag = (GClass55)this.tvCommanderList.SelectedNode.Tag;
                if (tag.auroraCommanderType_0 != AuroraCommanderType.Scientist &&
                    tag.auroraCommanderType_0 != AuroraCommanderType.Administrator)
                {
                    if (tag.gclass61_0.method_3() == null)
                    {
                        int num = (int)MessageBox.Show("No lower rank available");
                        return;
                    }

                    this.gclass21_0.method_251(tag, true);
                    TreeNode selectedNode = this.tvCommanderList.SelectedNode;
                    this.tvCommanderList.SelectedNode.Remove();
                    foreach (TreeNode node1 in this.tvCommanderList.Nodes)
                    {
                        foreach (TreeNode node2 in node1.Nodes)
                        {
                            if (node2.Tag is RankThemeEntry && (RankThemeEntry)node2.Tag == tag.gclass61_0)
                            {
                                node2.Nodes.Add(selectedNode);
                                this.tvCommanderList.SelectedNode = selectedNode;
                                break;
                            }
                        }
                    }
                }
                else
                {
                    int num = (int)MessageBox.Show("Only naval or ground commanders can be demoted");
                    return;
                }
            }

            this.method_4();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 426);
        }
    }

    private bool method_1()
    {
        try
        {
            if (this.gclass21_0 == null)
            {
                int num = (int)MessageBox.Show("Please select a race");
                return false;
            }

            if (this.tvCommanderList.SelectedNode != null)
                return true;
            int num1 = (int)MessageBox.Show("Please select a commander");
            return false;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 427);
            return false;
        }
    }

    private void cmdAssign_Click(object sender, EventArgs e)
    {
        try
        {
            if (!this.method_1())
                return;
            if (this.lstvAssign.SelectedItems.Count == 0)
            {
                int num1 = (int)MessageBox.Show("Please select an assignment");
            }
            else
            {
                if (!(this.tvCommanderList.SelectedNode.Tag is GClass55))
                    return;
                GClass55 tag = (GClass55)this.tvCommanderList.SelectedNode.Tag;
                if (tag.gclass59_0 != null)
                {
                    int num2 = (int)MessageBox.Show("This commander is currently in a lifepod");
                }
                else if (tag.bool_4)
                {
                    int num3 = (int)MessageBox.Show("This commander is currently a prisoner of another race");
                }
                else
                {
                    AssignmentTypeFilter selectedValue = (AssignmentTypeFilter)this.cboAssign.SelectedValue;
                    tag.method_24(selectedValue, this.lstvAssign);
                    tag.method_19(this.lstvCmdrSummary, this.lstvBonus, this.lstvHistory, this.lstvAssign,
                        this.cboAssign, this.chkEligible, this.chkAvailable, this.lblName, this.lblAssignment,
                        this.gclass55_1, this.flpMedals, this.chkDoNotPromote, this.chkStory);
                    if (tag.auroraCommanderType_0 == AuroraCommanderType.Naval)
                        this.gclass21_0.method_255(false);
                    this.method_4();
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 428);
        }
    }

    private void cmdUnassign_Click(object sender, EventArgs e)
    {
        try
        {
            if (!this.method_1() || !(this.tvCommanderList.SelectedNode.Tag is GClass55))
                return;
            GClass55 tag = (GClass55)this.tvCommanderList.SelectedNode.Tag;
            tag.method_40(true);
            tag.method_19(this.lstvCmdrSummary, this.lstvBonus, this.lstvHistory, this.lstvAssign, this.cboAssign,
                this.chkEligible, this.chkAvailable, this.lblName, this.lblAssignment, this.gclass55_1, this.flpMedals,
                this.chkDoNotPromote, this.chkStory);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 429);
        }
    }

    private void cboType_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass0_0.bool_9)
                return;
            this.method_2();
            this.method_4();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 430);
        }
    }

    private void method_2()
    {
        try
        {
            AuroraCommanderType auroraCommanderType_0 = this.method_3((string)this.cboType.SelectedItem);
            this.gclass0_0.bool_9 = true;
            if (auroraCommanderType_0 == AuroraCommanderType.Scientist)
            {
                this.cboMinRank.Enabled = false;
                this.cboMaxRank.Enabled = false;
            }
            else
            {
                this.cboMinRank.Enabled = true;
                this.cboMaxRank.Enabled = true;
                this.gclass21_0.method_233(this.cboMinRank, auroraCommanderType_0);
                this.gclass21_0.method_233(this.cboMaxRank, auroraCommanderType_0);
            }

            this.cboMaxRank.SelectedIndex = this.cboMaxRank.Items.Count - 1;
            this.gclass0_0.method_580(this.cboSort1, auroraCommanderType_0);
            this.gclass0_0.method_580(this.cboSort2, auroraCommanderType_0);
            this.gclass0_0.method_580(this.cboSort3, auroraCommanderType_0);
            this.gclass0_0.method_580(this.cboSort4, auroraCommanderType_0);
            this.gclass0_0.bool_9 = false;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 431);
        }
    }

    private void cboSort4_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass0_0.bool_9)
                return;
            if (this.gclass21_0 == null)
            {
                int num = (int)MessageBox.Show("Please select a race");
            }
            else
                this.method_4();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 432);
        }
    }

    private AuroraCommanderType method_3(string string_0)
    {
        try
        {
            switch (string_0)
            {
                case "Naval Officer":
                    return AuroraCommanderType.Naval;
                case "Ground Force Commander":
                    return AuroraCommanderType.GroundForce;
                case "Civilian Administrator":
                    return AuroraCommanderType.Administrator;
                case "Scientist":
                    return AuroraCommanderType.Scientist;
                default:
                    return AuroraCommanderType.All;
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 433);
            return AuroraCommanderType.Naval;
        }
    }

    private void method_4()
    {
        try
        {
            RankThemeEntry gclass61_2 = null;
            RankThemeEntry gclass61_3 = null;
            int int_56 = 1;
            int int_57 = 8;
            AuroraCommanderType auroraCommanderType_0 = this.method_3((string)this.cboType.SelectedItem);
            CommanderBonus selectedItem1 = (CommanderBonus)this.cboSort1.SelectedItem;
            CommanderBonus selectedItem2 = (CommanderBonus)this.cboSort2.SelectedItem;
            CommanderBonus selectedItem3 = (CommanderBonus)this.cboSort3.SelectedItem;
            CommanderBonus selectedItem4 = (CommanderBonus)this.cboSort4.SelectedItem;
            switch (auroraCommanderType_0)
            {
                case AuroraCommanderType.Naval:
                case AuroraCommanderType.GroundForce:
                    gclass61_2 = (RankThemeEntry)this.cboMinRank.SelectedItem;
                    gclass61_3 = (RankThemeEntry)this.cboMaxRank.SelectedItem;
                    break;
                case AuroraCommanderType.Administrator:
                    int_56 = this.cboMinRank.SelectedIndex + 1;
                    int_57 = this.cboMaxRank.SelectedIndex + 1;
                    break;
            }

            this.gclass21_0.method_231(this.lstvSearch, auroraCommanderType_0, selectedItem1, selectedItem2,
                selectedItem3, selectedItem4, gclass61_2, gclass61_3, int_56, int_57);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 434);
        }
    }

    private void lstvSearch_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            if (this.lstvSearch.SelectedItems.Count == 0)
                return;
            this.method_5((GClass55)this.lstvSearch.SelectedItems[0].Tag);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 435);
        }
    }

    public void method_5(GClass55 gclass55_2)
    {
        try
        {
            foreach (TreeNode node1 in this.tvCommanderList.Nodes)
            {
                foreach (TreeNode node2 in node1.Nodes)
                {
                    foreach (TreeNode node3 in node2.Nodes)
                    {
                        if (node3.Tag is GClass55 && (GClass55)node3.Tag == gclass55_2)
                        {
                            this.tvCommanderList.SelectedNode = node3;
                            break;
                        }
                    }
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 436);
        }
    }

    public void method_6(GClass55 gclass55_2)
    {
        try
        {
            foreach (TreeNode node1 in this.tvCommanderList.Nodes)
            {
                foreach (TreeNode node2 in node1.Nodes)
                {
                    foreach (TreeNode node3 in node2.Nodes)
                    {
                        foreach (TreeNode node4 in node3.Nodes)
                        {
                            if (node4.Tag is GClass55 && (GClass55)node4.Tag == gclass55_2)
                            {
                                this.tvCommanderList.SelectedNode = node4;
                                break;
                            }
                        }
                    }
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 436);
        }
    }

    private void lstvAssign_SelectedIndexChanged(object sender, EventArgs e)
    {
    }

    private void cmdAutoRename_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass21_0 == null)
            {
                int num1 = (int)MessageBox.Show("Please select a race");
            }
            else if (this.tvCommanderList.SelectedNode == null)
            {
                int num2 = (int)MessageBox.Show("Please select an item to rename");
            }
            else if (this.tvCommanderList.SelectedNode.Tag is GClass55)
            {
                GClass55 tag = (GClass55)this.tvCommanderList.SelectedNode.Tag;
                tag.string_0 = tag.gclass21_0.method_114();
                this.tvCommanderList.SelectedNode.Text = tag.method_26();
            }
            else
            {
                if (!(this.tvCommanderList.SelectedNode.Tag is RankThemeEntry))
                    return;
                int num3 = (int)MessageBox.Show("Please select a commander to rename");
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 437);
        }
    }

    private void cmdRetire_Click(object sender, EventArgs e)
    {
        try
        {
            if (!this.method_1() || !(this.tvCommanderList.SelectedNode.Tag is GClass55))
                return;
            GClass55 tag = (GClass55)this.tvCommanderList.SelectedNode.Tag;
            tag.method_46("Retired by order of High Command", GEnum28.const_0);
            tag.method_42(AuroraRetirementStatus.RetiredByOrder);
            this.tvCommanderList.Nodes.Remove(this.tvCommanderList.SelectedNode);
            this.gclass21_0.method_234(this.tvCommanderList);
            this.method_6(tag);
            this.method_4();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 438);
        }
    }

    private void cmdAwardMedal_Click(object sender, EventArgs e)
    {
        try
        {
            if (!this.method_1())
                return;
            this.gclass0_0.gclass42_0 = null;
            int num1 = (int)new frmMedalAward(this.gclass0_0, this.gclass21_0).ShowDialog();
            if (this.gclass0_0.gclass42_0 == null)
                return;
            string string_4 = "";
            this.gclass0_0.string_3 = "Enter Optional Citation";
            this.gclass0_0.string_4 = "";
            int num2 = (int)new MessageEntry(this.gclass0_0).ShowDialog();
            if (!this.gclass0_0.bool_21)
                string_4 = this.gclass0_0.string_4;
            this.gclass55_0.method_2(this.gclass0_0.gclass42_0, null, string_4);
            this.gclass55_0.method_19(this.lstvCmdrSummary, this.lstvBonus, this.lstvHistory, this.lstvAssign,
                this.cboAssign, this.chkEligible, this.chkAvailable, this.lblName, this.lblAssignment, this.gclass55_1,
                this.flpMedals, this.chkDoNotPromote, this.chkStory);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 439);
        }
    }

    private void cmdReassignNaval_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass21_0 == null)
            {
                int num = (int)MessageBox.Show("Please select a race");
            }
            else
            {
                if (MessageBox.Show(
                        "Are you sure you wish to unassign all naval commanders and run automated assignment?",
                        "Confirmation Required", MessageBoxButtons.YesNo) != DialogResult.Yes)
                    return;
                this.gclass21_0.method_221();
                this.gclass21_0.method_226(null, false);
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 440);
        }
    }

    private void cmdReplaceAll_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass21_0 == null)
            {
                int num1 = (int)MessageBox.Show("Please select a race");
            }
            else
            {
                this.gclass0_0.string_3 = "Enter Number of Commanders";
                this.gclass0_0.string_4 = "100";
                int num2 = (int)new MessageEntry(this.gclass0_0).ShowDialog();
                if (this.gclass0_0.bool_21)
                    return;
                int int32 = Convert.ToInt32(this.gclass0_0.string_4);
                if (int32 == 0)
                    return;
                PopulationData gclass146_1 = this.gclass21_0.method_191();
                foreach (GClass55 gclass55 in this.gclass0_0.dictionary_42.Values
                             .Where<GClass55>(gclass55_2 => gclass55_2.gclass21_0 == this.gclass21_0)
                             .ToList<GClass55>())
                {
                    gclass55.method_40(false);
                    this.gclass0_0.dictionary_42.Remove(gclass55.int_0);
                }

                for (int index = 1; index <= int32; ++index)
                    this.gclass21_0.method_256(gclass146_1, false, null);
                this.gclass21_0.method_222(true);
                this.gclass21_0.method_234(this.tvCommanderList);
                this.method_4();
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 441);
        }
    }

    private void cmdRenameAll_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass21_0 == null)
            {
                int num = (int)MessageBox.Show("Please select a race");
            }
            else
            {
                if (MessageBox.Show("Are you sure you wish to rename all commanders to the current name theme?",
                        "Confirmation Required", MessageBoxButtons.YesNo) != DialogResult.Yes)
                    return;
                foreach (GClass55 gclass55 in this.gclass0_0.dictionary_42.Values
                             .Where<GClass55>(gclass55_2 => gclass55_2.gclass21_0 == this.gclass21_0)
                             .ToList<GClass55>())
                    gclass55.string_0 = gclass55.gclass21_0.method_114();
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 442);
        }
    }

    private void chkAutoAssign_CheckedChanged(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass21_0 == null)
            {
                int num = (int)MessageBox.Show("Please select a race");
            }
            else if (this.chkAutoAssign.CheckState == CheckState.Checked)
                this.gclass21_0.chkAutoAssign = 1;
            else
                this.gclass21_0.chkAutoAssign = 0;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 443);
        }
    }

    private void cmdCreateMedal_Click(object sender, EventArgs e)
    {
        try
        {
            new frmMedals(this.gclass0_0).Show();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 444);
        }
    }

    private void cmdHideMedals_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.cmdHideMedals.Text == "Hide Medal Row")
            {
                this.flpMedals.Visible = false;
                this.lstvAssign.Height = 490;
                this.lstvSearch.Height = 490;
                this.flpAssignments.Top = 303;
                this.flpSearch.Top = 303;
                this.flpAssignments.Height = 518;
                this.flpSearch.Height = 518;
                this.cmdHideMedals.Text = "Show Medals";
            }
            else
            {
                this.flpMedals.Visible = true;
                this.lstvAssign.Height = 358;
                this.lstvSearch.Height = 358;
                this.flpAssignments.Top = 435;
                this.flpSearch.Top = 435;
                this.flpAssignments.Height = 386;
                this.flpSearch.Height = 386;
                this.cmdHideMedals.Text = "Hide Medal Row";
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 445);
        }
    }

    private void cmdAddNavalRank_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass21_0 == null)
            {
                int num1 = (int)MessageBox.Show("Please select a race");
            }
            else if (this.gclass61_0 == null)
            {
                int num2 = (int)MessageBox.Show("Please select a an existing rank to set the rank type");
            }
            else
            {
                string str1 = "";
                this.gclass0_0.string_3 = "Enter Rank Name";
                this.gclass0_0.string_4 = "";
                int num3 = (int)new MessageEntry(this.gclass0_0).ShowDialog();
                if (!this.gclass0_0.bool_21)
                    str1 = this.gclass0_0.string_4;
                if (str1 == "")
                    return;
                string str2 = "";
                this.gclass0_0.string_3 = "Enter Rank Abbreviation";
                this.gclass0_0.string_4 = "";
                int num4 = (int)new MessageEntry(this.gclass0_0).ShowDialog();
                if (!this.gclass0_0.bool_21)
                    str2 = this.gclass0_0.string_4;
                if (str2 == "")
                    return;
                foreach (RankThemeEntry gclass61 in this.gclass21_0.RacialRankDictionary.Values
                             .Where<RankThemeEntry>(gclass61_1 =>
                                 gclass61_1.CommanderType == this.gclass61_0.CommanderType)
                             .OrderBy<RankThemeEntry, int>(gclass61_0 => gclass61_0.RankNum).ToList<RankThemeEntry>())
                    ++gclass61.RankNum;
                RankThemeEntry gclass61_2 = new RankThemeEntry();
                gclass61_2.int_0 = this.gclass0_0.method_26(GEnum0.const_14);
                gclass61_2.gclass21_0 = this.gclass21_0;
                gclass61_2.CommanderType = this.gclass61_0.CommanderType;
                gclass61_2.RankNum = 1;
                gclass61_2.RankName = str1;
                gclass61_2.RankAbbreviation = str2;
                this.gclass21_0.RacialRankDictionary.Add(gclass61_2.int_0, gclass61_2);
                this.gclass21_0.method_234(this.tvCommanderList);
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 446);
        }
    }

    private void cmdDeleteNavalRank_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass21_0 == null)
            {
                int num1 = (int)MessageBox.Show("Please select a race");
            }
            else if (this.gclass61_0 == null)
            {
                int num2 = (int)MessageBox.Show("Please select a naval rank to delete");
            }
            else
            {
                if (MessageBox.Show(
                        $"Are you sure you wish to delete the rank '{this.gclass61_0.RankName}'? All commanders with this rank will be lost.",
                        "Confirmation Required", MessageBoxButtons.YesNo) != DialogResult.Yes)
                    return;
                foreach (GClass55 gclass55 in this.gclass0_0.dictionary_42.Values
                             .Where<GClass55>(gclass55_2 => gclass55_2.gclass61_0 == this.gclass61_0)
                             .ToList<GClass55>())
                {
                    gclass55.method_40(false);
                    this.gclass0_0.dictionary_42.Remove(gclass55.int_0);
                }

                this.gclass21_0.RacialRankDictionary.Remove(this.gclass61_0.int_0);
                List<RankThemeEntry> list = this.gclass21_0.RacialRankDictionary.Values
                    .Where<RankThemeEntry>(gclass61_1 =>
                        gclass61_1.CommanderType == this.gclass61_0.CommanderType)
                    .OrderBy<RankThemeEntry, int>(gclass61_0 => gclass61_0.RankNum).ToList<RankThemeEntry>();
                int num3 = 1;
                foreach (RankThemeEntry gclass61 in list)
                {
                    gclass61.RankNum = num3;
                    ++num3;
                }

                this.gclass21_0.method_234(this.tvCommanderList);
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 447);
        }
    }

    private void chkStory_CheckedChanged(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass21_0 == null)
            {
                int num1 = (int)MessageBox.Show("Please select a race");
            }
            else if (this.tvCommanderList.SelectedNode == null)
            {
                int num2 = (int)MessageBox.Show("Please select a commander");
            }
            else
            {
                if (!(this.tvCommanderList.SelectedNode.Tag is GClass55))
                    return;
                GClass55 tag = (GClass55)this.tvCommanderList.SelectedNode.Tag;
                if (this.chkStory.CheckState == CheckState.Checked)
                    tag.bool_2 = true;
                else
                    tag.bool_2 = false;
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 448);
        }
    }

    private void chkDoNotPromote_CheckedChanged(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass21_0 == null)
            {
                int num1 = (int)MessageBox.Show("Please select a race");
            }
            else if (this.tvCommanderList.SelectedNode == null)
            {
                int num2 = (int)MessageBox.Show("Please select a commander");
            }
            else
            {
                if (!(this.tvCommanderList.SelectedNode.Tag is GClass55))
                    return;
                GClass55 tag = (GClass55)this.tvCommanderList.SelectedNode.Tag;
                if (this.chkDoNotPromote.CheckState == CheckState.Checked)
                    tag.bool_0 = true;
                else
                    tag.bool_0 = false;
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 449);
        }
    }

    private void cmdChangeField_Click(object sender, EventArgs e)
    {
        try
        {
            // ISSUE: object of a compiler-generated type is created
            // ISSUE: variable of a compiler-generated type
            CommandersWindow.Class892 class892 = new CommandersWindow.Class892();
            if (this.gclass21_0 == null)
            {
                int num1 = (int)MessageBox.Show("Please select a race");
            }
            else if (this.tvCommanderList.SelectedNode == null)
            {
                int num2 = (int)MessageBox.Show("Please select a commander");
            }
            else
            {
                if (MessageBox.Show(
                        "Are you sure you wish to change the research field of this commander? His research bonus will be reduced by 75%.",
                        "Confirmation Required", MessageBoxButtons.YesNo) != DialogResult.Yes)
                    return;
                // ISSUE: reference to a compiler-generated field
                class892.gclass55_0 = (GClass55)this.tvCommanderList.SelectedNode.Tag;
                this.gclass0_0.string_3 = "Select New Research Field";
                this.gclass0_0.string_7 = "";
                this.gclass0_0.string_8 = "";
                this.gclass0_0.string_9 = "";
                this.gclass0_0.list_32 = new List<string>();
                // ISSUE: reference to a compiler-generated method
                foreach (ResearchFieldData gclass162 in this.gclass0_0.ResearchFieldDictionary.Values.Where<ResearchFieldData>(class892.method_0)
                             .ToList<ResearchFieldData>())
                    this.gclass0_0.list_32.Add(gclass162.FieldName);
                int num3 = (int)new UserSelection(this.gclass0_0).ShowDialog();
                if (this.gclass0_0.bool_21)
                    return;
                // ISSUE: reference to a compiler-generated field
                class892.gclass55_0.gclass162_0 =
                    this.gclass0_0.ResearchFieldDictionary.Values.FirstOrDefault<ResearchFieldData>(gclass162_0 =>
                        gclass162_0.FieldName == this.gclass0_0.string_4);
                // ISSUE: reference to a compiler-generated field
                if (class892.gclass55_0.dictionary_0.ContainsKey(CommanderBonusType.Research))
                {
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    class892.gclass55_0.dictionary_0[CommanderBonusType.Research].decimal_0 = Math.Round(
                        (class892.gclass55_0.dictionary_0[CommanderBonusType.Research].decimal_0 - 1M) * 0.25M + 1M, 2,
                        MidpointRounding.AwayFromZero);
                }

                // ISSUE: reference to a compiler-generated field
                TreeNode treeNode = this.method_7(class892.gclass55_0.gclass162_0.FieldName);
                TreeNode selectedNode = this.tvCommanderList.SelectedNode;
                this.tvCommanderList.SelectedNode.Remove();
                treeNode.Nodes.Add(selectedNode);
                this.tvCommanderList.SelectedNode = selectedNode;
                // ISSUE: reference to a compiler-generated field
                selectedNode.Text = class892.gclass55_0.method_26();
                foreach (Economics economics in Application.OpenForms.OfType<Economics>())
                    economics.method_14();
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 450);
        }
    }

    public TreeNode method_7(string string_0)
    {
        try
        {
            foreach (TreeNode node in this.tvCommanderList.Nodes)
            {
                if (node.Tag != null && node.Text == string_0)
                    return node;
                TreeNode treeNode = this.method_8(string_0, node);
                if (treeNode != null)
                    return treeNode;
            }

            return null;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 451);
            return null;
        }
    }

    public TreeNode method_8(string string_0, TreeNode treeNode_0)
    {
        try
        {
            foreach (TreeNode node in treeNode_0.Nodes)
            {
                if (node.Tag != null && node.Text == string_0)
                    return node;
                TreeNode treeNode = this.method_8(string_0, node);
                if (treeNode != null)
                    return treeNode;
            }

            return null;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 452);
            return null;
        }
    }

    private void cmdAddExtra_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass21_0 == null)
            {
                int num1 = (int)MessageBox.Show("Please select a race");
            }
            else
            {
                PopulationData gclass146_1 = this.gclass21_0.method_191();
                this.gclass0_0.string_3 = "Enter Number of New Commanders";
                this.gclass0_0.string_4 = "1";
                int num2 = (int)new MessageEntry(this.gclass0_0).ShowDialog();
                int int32 = Convert.ToInt32(this.gclass0_0.string_4);
                for (int index = 1; index <= int32; ++index)
                    this.gclass21_0.method_256(gclass146_1, false, null);
                this.gclass21_0.method_234(this.tvCommanderList);
                this.method_4();
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3257);
        }
    }

    private void CommandersWindow_KeyDown(object sender, KeyEventArgs e)
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
            AuroraUtils.ShowExceptionPopup(ex, 3271);
        }
    }

    private void cmdRetain_Click(object sender, EventArgs e)
    {
        try
        {
            if (!this.method_1() || !(this.tvCommanderList.SelectedNode.Tag is GClass55))
                return;
            GClass55 tag = (GClass55)this.tvCommanderList.SelectedNode.Tag;
            if (tag == null)
                return;
            tag.bool_3 = !tag.bool_3;
            this.tvCommanderList.SelectedNode.Text = tag.method_26();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3395);
        }
    }

    private void cmdRestore_Click(object sender, EventArgs e)
    {
        try
        {
            if (!this.method_1())
                return;
            if (this.tvCommanderList.SelectedNode.Tag is GClass55)
            {
                // ISSUE: object of a compiler-generated type is created
                // ISSUE: variable of a compiler-generated type
                CommandersWindow.Class893 class893 = new CommandersWindow.Class893()
                {
                    gclass55_0 = (GClass55)this.tvCommanderList.SelectedNode.Tag
                };
                // ISSUE: reference to a compiler-generated field
                class893.gclass55_0.int_6 = 1;
                // ISSUE: reference to a compiler-generated field
                class893.gclass55_0.auroraRetirementStatus_0 = AuroraRetirementStatus.Active;
                // ISSUE: reference to a compiler-generated field
                this.gclass0_0.dictionary_43.Remove(class893.gclass55_0.int_0);
                TreeNode selectedNode = this.tvCommanderList.SelectedNode;
                selectedNode.Remove();
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                if (class893.gclass55_0.auroraCommanderType_0 != AuroraCommanderType.Naval &&
                    class893.gclass55_0.auroraCommanderType_0 != AuroraCommanderType.GroundForce)
                {
                    // ISSUE: reference to a compiler-generated field
                    class893.gclass55_0.int_4 = 0;
                    // ISSUE: reference to a compiler-generated field
                    class893.gclass55_0.method_46("Restored to active service", GEnum28.const_0);
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    this.gclass0_0.gclass92_0.method_2(EventType.const_193,
                        class893.gclass55_0.string_0 + " restored to active service", class893.gclass55_0.gclass21_0,
                        null, 0.0, 0.0, AuroraEventCategory.Commander);
                    // ISSUE: reference to a compiler-generated field
                    if (class893.gclass55_0.auroraCommanderType_0 == AuroraCommanderType.Scientist)
                    {
                        foreach (TreeNode node1 in this.tvCommanderList.Nodes)
                        {
                            foreach (TreeNode node2 in node1.Nodes)
                            {
                                // ISSUE: reference to a compiler-generated field
                                if (node2.Tag is ResearchFieldData && (ResearchFieldData)node2.Tag == class893.gclass55_0.gclass162_0)
                                {
                                    node2.Nodes.Add(selectedNode);
                                    // ISSUE: reference to a compiler-generated field
                                    selectedNode.Text = class893.gclass55_0.method_26();
                                    this.tvCommanderList.SelectedNode = selectedNode;
                                    break;
                                }
                            }
                        }
                    }
                    else
                    {
                        // ISSUE: reference to a compiler-generated field
                        if (class893.gclass55_0.auroraCommanderType_0 == AuroraCommanderType.Administrator)
                        {
                            foreach (TreeNode node3 in this.tvCommanderList.Nodes)
                            {
                                foreach (TreeNode node4 in node3.Nodes)
                                {
                                    // ISSUE: reference to a compiler-generated field
                                    if (node4.Tag is int &&
                                        (int)node4.Tag == class893.gclass55_0.method_5(CommanderBonusType.ColonyAdmnistration))
                                    {
                                        node4.Nodes.Add(selectedNode);
                                        // ISSUE: reference to a compiler-generated field
                                        selectedNode.Text = class893.gclass55_0.method_26();
                                        this.tvCommanderList.SelectedNode = selectedNode;
                                        break;
                                    }
                                }
                            }
                        }
                    }
                }
                else
                {
                    // ISSUE: reference to a compiler-generated method
                    int num = this.gclass0_0.dictionary_42.Values.Count<GClass55>(class893.method_0);
                    // ISSUE: reference to a compiler-generated field
                    class893.gclass55_0.int_4 = num + 1;
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    class893.gclass55_0.method_46("Restored to " + class893.gclass55_0.gclass61_0.RankName,
                        GEnum28.const_0);
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    this.gclass0_0.gclass92_0.method_2(EventType.const_193,
                        $"{class893.gclass55_0.string_0} restored to {class893.gclass55_0.gclass61_0.RankName}",
                        class893.gclass55_0.gclass21_0, null, 0.0, 0.0, AuroraEventCategory.Commander);
                    foreach (TreeNode node5 in this.tvCommanderList.Nodes)
                    {
                        foreach (TreeNode node6 in node5.Nodes)
                        {
                            // ISSUE: reference to a compiler-generated field
                            if (node6.Tag is RankThemeEntry && (RankThemeEntry)node6.Tag == class893.gclass55_0.gclass61_0)
                            {
                                node6.Nodes.Add(selectedNode);
                                // ISSUE: reference to a compiler-generated field
                                selectedNode.Text = class893.gclass55_0.method_26();
                                this.tvCommanderList.SelectedNode = selectedNode;
                                break;
                            }
                        }
                    }
                }
            }

            this.method_4();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3583 /*0x0DFF*/);
        }
    }

    private void chkAvailable_CheckedChanged(object sender, EventArgs e)
    {
        try
        {
            if (!this.method_1() || !(this.tvCommanderList.SelectedNode.Tag is GClass55))
                return;
            GClass55 tag = (GClass55)this.tvCommanderList.SelectedNode.Tag;
            AssignmentTypeFilter selectedValue = (AssignmentTypeFilter)this.cboAssign.SelectedValue;
            if (selectedValue.ShipboardPosition > AuroraCommandType.Ship)
                this.chkEligible.Visible = false;
            else
                this.chkEligible.Visible = true;
            AssignmentTypeFilter gclass49_0 = selectedValue;
            ListView lstvAssign = this.lstvAssign;
            CheckBox chkEligible = this.chkEligible;
            CheckBox chkAvailable = this.chkAvailable;
            tag.method_25(gclass49_0, lstvAssign, chkEligible, chkAvailable);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 453);
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
        this.tvCommanderList = new TreeView();
        this.cboRaces = new ComboBox();
        this.cmdRename = new Button();
        this.cmdPromote = new Button();
        this.flowLayoutPanel1 = new FlowLayoutPanel();
        this.cmdAutoRename = new Button();
        this.cmdDemote = new Button();
        this.cmdAssign = new Button();
        this.cmdUnassign = new Button();
        this.cmdRetire = new Button();
        this.cmdChangeField = new Button();
        this.cmdReplaceAll = new Button();
        this.cmdAddExtra = new Button();
        this.cmdReassignNaval = new Button();
        this.cmdRenameAll = new Button();
        this.cmdHideMedals = new Button();
        this.cmdCreateMedal = new Button();
        this.cmdAwardMedal = new Button();
        this.cmdAddNavalRank = new Button();
        this.cmdDeleteNavalRank = new Button();
        this.cmdRestore = new Button();
        this.cmdRetain = new Button();
        this.lstvCmdrSummary = new ListView();
        this.columnHeader_0 = new ColumnHeader();
        this.columnHeader_1 = new ColumnHeader();
        this.lstvBonus = new ListView();
        this.columnHeader_2 = new ColumnHeader();
        this.columnHeader_3 = new ColumnHeader();
        this.flowLayoutPanel2 = new FlowLayoutPanel();
        this.lblName = new Label();
        this.lblAssignment = new Label();
        this.lstvHistory = new ListView();
        this.columnHeader_4 = new ColumnHeader();
        this.columnHeader_5 = new ColumnHeader();
        this.flpMedals = new FlowLayoutPanel();
        this.flpAssignments = new FlowLayoutPanel();
        this.cboAssign = new ComboBox();
        this.chkEligible = new CheckBox();
        this.chkAvailable = new CheckBox();
        this.lstvAssign = new ListView();
        this.columnHeader_6 = new ColumnHeader();
        this.columnHeader_7 = new ColumnHeader();
        this.columnHeader_8 = new ColumnHeader();
        this.columnHeader_9 = new ColumnHeader();
        this.flpSearch = new FlowLayoutPanel();
        this.cboType = new ComboBox();
        this.label1 = new Label();
        this.cboMinRank = new ComboBox();
        this.label2 = new Label();
        this.cboMaxRank = new ComboBox();
        this.cboSort1 = new ComboBox();
        this.cboSort2 = new ComboBox();
        this.cboSort3 = new ComboBox();
        this.cboSort4 = new ComboBox();
        this.lstvSearch = new ListView();
        this.columnHeader_10 = new ColumnHeader();
        this.columnHeader_15 = new ColumnHeader();
        this.columnHeader_11 = new ColumnHeader();
        this.columnHeader_12 = new ColumnHeader();
        this.columnHeader_13 = new ColumnHeader();
        this.columnHeader_14 = new ColumnHeader();
        this.chkAutoAssign = new CheckBox();
        this.panel1 = new Panel();
        this.chkDoNotPromote = new CheckBox();
        this.chkStory = new CheckBox();
        this.flowLayoutPanel1.SuspendLayout();
        this.flowLayoutPanel2.SuspendLayout();
        this.flpAssignments.SuspendLayout();
        this.flpSearch.SuspendLayout();
        this.panel1.SuspendLayout();
        this.SuspendLayout();
        this.tvCommanderList.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.tvCommanderList.BorderStyle = BorderStyle.FixedSingle;
        this.tvCommanderList.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.tvCommanderList.HideSelection = false;
        this.tvCommanderList.Location = new Point(3, 30);
        this.tvCommanderList.Margin = new Padding(3, 0, 0, 3);
        this.tvCommanderList.Name = "tvCommanderList";
        this.tvCommanderList.Size = new Size(288, 791);
        this.tvCommanderList.TabIndex = 42;
        this.tvCommanderList.AfterSelect += this.tvCommanderList_AfterSelect;
        this.cboRaces.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cboRaces.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cboRaces.FormattingEnabled = true;
        this.cboRaces.Location = new Point(3, 3);
        this.cboRaces.Margin = new Padding(3, 3, 3, 0);
        this.cboRaces.Name = "cboRaces";
        this.cboRaces.Size = new Size(288, 21);
        this.cboRaces.TabIndex = 1;
        this.cboRaces.SelectedIndexChanged += this.cboRaces_SelectedIndexChanged;
        this.cmdRename.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdRename.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdRename.Location = new Point(0, 0);
        this.cmdRename.Margin = new Padding(0);
        this.cmdRename.Name = "cmdRename";
        this.cmdRename.Size = new Size(96 /*0x60*/, 30);
        this.cmdRename.TabIndex = 13;
        this.cmdRename.Tag = "1200";
        this.cmdRename.Text = "Rename";
        this.cmdRename.UseVisualStyleBackColor = false;
        this.cmdRename.Visible = false;
        this.cmdRename.Click += this.cmdRename_Click;
        this.cmdPromote.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdPromote.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdPromote.Location = new Point(192 /*0xC0*/, 0);
        this.cmdPromote.Margin = new Padding(0);
        this.cmdPromote.Name = "cmdPromote";
        this.cmdPromote.Size = new Size(96 /*0x60*/, 30);
        this.cmdPromote.TabIndex = 15;
        this.cmdPromote.Tag = "1200";
        this.cmdPromote.Text = "Promote";
        this.cmdPromote.UseVisualStyleBackColor = false;
        this.cmdPromote.Visible = false;
        this.cmdPromote.Click += this.cmdPromote_Click;
        this.flowLayoutPanel1.Controls.Add(this.cmdRename);
        this.flowLayoutPanel1.Controls.Add(this.cmdAutoRename);
        this.flowLayoutPanel1.Controls.Add(this.cmdPromote);
        this.flowLayoutPanel1.Controls.Add(this.cmdDemote);
        this.flowLayoutPanel1.Controls.Add(this.cmdAssign);
        this.flowLayoutPanel1.Controls.Add(this.cmdUnassign);
        this.flowLayoutPanel1.Controls.Add(this.cmdRetire);
        this.flowLayoutPanel1.Controls.Add(this.cmdChangeField);
        this.flowLayoutPanel1.Controls.Add(this.cmdReplaceAll);
        this.flowLayoutPanel1.Controls.Add(this.cmdAddExtra);
        this.flowLayoutPanel1.Controls.Add(this.cmdReassignNaval);
        this.flowLayoutPanel1.Controls.Add(this.cmdRenameAll);
        this.flowLayoutPanel1.Controls.Add(this.cmdHideMedals);
        this.flowLayoutPanel1.Controls.Add(this.cmdCreateMedal);
        this.flowLayoutPanel1.Controls.Add(this.cmdAwardMedal);
        this.flowLayoutPanel1.Controls.Add(this.cmdAddNavalRank);
        this.flowLayoutPanel1.Controls.Add(this.cmdDeleteNavalRank);
        this.flowLayoutPanel1.Controls.Add(this.cmdRestore);
        this.flowLayoutPanel1.Controls.Add(this.cmdRetain);
        this.flowLayoutPanel1.Location = new Point(3, 827);
        this.flowLayoutPanel1.Name = "flowLayoutPanel1";
        this.flowLayoutPanel1.Size = new Size(1851, 29);
        this.flowLayoutPanel1.TabIndex = 115;
        this.cmdAutoRename.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdAutoRename.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdAutoRename.Location = new Point(96 /*0x60*/, 0);
        this.cmdAutoRename.Margin = new Padding(0);
        this.cmdAutoRename.Name = "cmdAutoRename";
        this.cmdAutoRename.Size = new Size(96 /*0x60*/, 30);
        this.cmdAutoRename.TabIndex = 14;
        this.cmdAutoRename.Tag = "1200";
        this.cmdAutoRename.Text = "Auto Rename";
        this.cmdAutoRename.UseVisualStyleBackColor = false;
        this.cmdAutoRename.Click += this.cmdAutoRename_Click;
        this.cmdDemote.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdDemote.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdDemote.Location = new Point(288, 0);
        this.cmdDemote.Margin = new Padding(0);
        this.cmdDemote.Name = "cmdDemote";
        this.cmdDemote.Size = new Size(96 /*0x60*/, 30);
        this.cmdDemote.TabIndex = 16 /*0x10*/;
        this.cmdDemote.Tag = "1200";
        this.cmdDemote.Text = "Demote";
        this.cmdDemote.UseVisualStyleBackColor = false;
        this.cmdDemote.Visible = false;
        this.cmdDemote.Click += this.cmdDemote_Click;
        this.cmdAssign.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdAssign.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdAssign.Location = new Point(384, 0);
        this.cmdAssign.Margin = new Padding(0);
        this.cmdAssign.Name = "cmdAssign";
        this.cmdAssign.Size = new Size(96 /*0x60*/, 30);
        this.cmdAssign.TabIndex = 17;
        this.cmdAssign.Tag = "1200";
        this.cmdAssign.Text = "Assign";
        this.cmdAssign.UseVisualStyleBackColor = false;
        this.cmdAssign.Click += this.cmdAssign_Click;
        this.cmdUnassign.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdUnassign.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdUnassign.Location = new Point(480, 0);
        this.cmdUnassign.Margin = new Padding(0);
        this.cmdUnassign.Name = "cmdUnassign";
        this.cmdUnassign.Size = new Size(96 /*0x60*/, 30);
        this.cmdUnassign.TabIndex = 18;
        this.cmdUnassign.Tag = "1200";
        this.cmdUnassign.Text = "Unassign";
        this.cmdUnassign.UseVisualStyleBackColor = false;
        this.cmdUnassign.Click += this.cmdUnassign_Click;
        this.cmdRetire.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdRetire.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdRetire.Location = new Point(576, 0);
        this.cmdRetire.Margin = new Padding(0);
        this.cmdRetire.Name = "cmdRetire";
        this.cmdRetire.Size = new Size(96 /*0x60*/, 30);
        this.cmdRetire.TabIndex = 19;
        this.cmdRetire.Tag = "1200";
        this.cmdRetire.Text = "Retire";
        this.cmdRetire.UseVisualStyleBackColor = false;
        this.cmdRetire.Click += this.cmdRetire_Click;
        this.cmdChangeField.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdChangeField.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdChangeField.Location = new Point(672, 0);
        this.cmdChangeField.Margin = new Padding(0);
        this.cmdChangeField.Name = "cmdChangeField";
        this.cmdChangeField.Size = new Size(96 /*0x60*/, 30);
        this.cmdChangeField.TabIndex = 28;
        this.cmdChangeField.Tag = "1200";
        this.cmdChangeField.Text = "Change Field";
        this.cmdChangeField.UseVisualStyleBackColor = false;
        this.cmdChangeField.Visible = false;
        this.cmdChangeField.Click += this.cmdChangeField_Click;
        this.cmdReplaceAll.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdReplaceAll.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdReplaceAll.Location = new Point(768 /*0x0300*/, 0);
        this.cmdReplaceAll.Margin = new Padding(0);
        this.cmdReplaceAll.Name = "cmdReplaceAll";
        this.cmdReplaceAll.Size = new Size(96 /*0x60*/, 30);
        this.cmdReplaceAll.TabIndex = 20;
        this.cmdReplaceAll.Tag = "1200";
        this.cmdReplaceAll.Text = "SM: Replace All";
        this.cmdReplaceAll.UseVisualStyleBackColor = false;
        this.cmdReplaceAll.Click += this.cmdReplaceAll_Click;
        this.cmdAddExtra.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdAddExtra.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdAddExtra.Location = new Point(864, 0);
        this.cmdAddExtra.Margin = new Padding(0);
        this.cmdAddExtra.Name = "cmdAddExtra";
        this.cmdAddExtra.Size = new Size(96 /*0x60*/, 30);
        this.cmdAddExtra.TabIndex = 29;
        this.cmdAddExtra.Tag = "1200";
        this.cmdAddExtra.Text = "SM: Add Extra";
        this.cmdAddExtra.UseVisualStyleBackColor = false;
        this.cmdAddExtra.Click += this.cmdAddExtra_Click;
        this.cmdReassignNaval.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdReassignNaval.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdReassignNaval.Location = new Point(960, 0);
        this.cmdReassignNaval.Margin = new Padding(0);
        this.cmdReassignNaval.Name = "cmdReassignNaval";
        this.cmdReassignNaval.Size = new Size(96 /*0x60*/, 30);
        this.cmdReassignNaval.TabIndex = 21;
        this.cmdReassignNaval.Tag = "1200";
        this.cmdReassignNaval.Text = "Reassign Naval";
        this.cmdReassignNaval.UseVisualStyleBackColor = false;
        this.cmdReassignNaval.Click += this.cmdReassignNaval_Click;
        this.cmdRenameAll.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdRenameAll.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdRenameAll.Location = new Point(1056, 0);
        this.cmdRenameAll.Margin = new Padding(0);
        this.cmdRenameAll.Name = "cmdRenameAll";
        this.cmdRenameAll.Size = new Size(96 /*0x60*/, 30);
        this.cmdRenameAll.TabIndex = 22;
        this.cmdRenameAll.Tag = "1200";
        this.cmdRenameAll.Text = "Auto Rename All";
        this.cmdRenameAll.UseVisualStyleBackColor = false;
        this.cmdRenameAll.Click += this.cmdRenameAll_Click;
        this.cmdHideMedals.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdHideMedals.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdHideMedals.Location = new Point(1152, 0);
        this.cmdHideMedals.Margin = new Padding(0);
        this.cmdHideMedals.Name = "cmdHideMedals";
        this.cmdHideMedals.Size = new Size(96 /*0x60*/, 30);
        this.cmdHideMedals.TabIndex = 23;
        this.cmdHideMedals.Tag = "1200";
        this.cmdHideMedals.Text = "Hide Medal Row";
        this.cmdHideMedals.UseVisualStyleBackColor = false;
        this.cmdHideMedals.Click += this.cmdHideMedals_Click;
        this.cmdCreateMedal.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdCreateMedal.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdCreateMedal.Location = new Point(1248, 0);
        this.cmdCreateMedal.Margin = new Padding(0);
        this.cmdCreateMedal.Name = "cmdCreateMedal";
        this.cmdCreateMedal.Size = new Size(96 /*0x60*/, 30);
        this.cmdCreateMedal.TabIndex = 24;
        this.cmdCreateMedal.Tag = "1200";
        this.cmdCreateMedal.Text = "Manage Medals";
        this.cmdCreateMedal.UseVisualStyleBackColor = false;
        this.cmdCreateMedal.Click += this.cmdCreateMedal_Click;
        this.cmdAwardMedal.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdAwardMedal.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdAwardMedal.Location = new Point(1344, 0);
        this.cmdAwardMedal.Margin = new Padding(0);
        this.cmdAwardMedal.Name = "cmdAwardMedal";
        this.cmdAwardMedal.Size = new Size(96 /*0x60*/, 30);
        this.cmdAwardMedal.TabIndex = 25;
        this.cmdAwardMedal.Tag = "1200";
        this.cmdAwardMedal.Text = "Award Medal";
        this.cmdAwardMedal.UseVisualStyleBackColor = false;
        this.cmdAwardMedal.Click += this.cmdAwardMedal_Click;
        this.cmdAddNavalRank.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdAddNavalRank.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdAddNavalRank.Location = new Point(1440, 0);
        this.cmdAddNavalRank.Margin = new Padding(0);
        this.cmdAddNavalRank.Name = "cmdAddNavalRank";
        this.cmdAddNavalRank.Size = new Size(96 /*0x60*/, 30);
        this.cmdAddNavalRank.TabIndex = 26;
        this.cmdAddNavalRank.Tag = "1200";
        this.cmdAddNavalRank.Text = "Add Rank";
        this.cmdAddNavalRank.UseVisualStyleBackColor = false;
        this.cmdAddNavalRank.Click += this.cmdAddNavalRank_Click;
        this.cmdDeleteNavalRank.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdDeleteNavalRank.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdDeleteNavalRank.Location = new Point(1536 /*0x0600*/, 0);
        this.cmdDeleteNavalRank.Margin = new Padding(0);
        this.cmdDeleteNavalRank.Name = "cmdDeleteNavalRank";
        this.cmdDeleteNavalRank.Size = new Size(96 /*0x60*/, 30);
        this.cmdDeleteNavalRank.TabIndex = 27;
        this.cmdDeleteNavalRank.Tag = "1200";
        this.cmdDeleteNavalRank.Text = "Delete Rank";
        this.cmdDeleteNavalRank.UseVisualStyleBackColor = false;
        this.cmdDeleteNavalRank.Visible = false;
        this.cmdDeleteNavalRank.Click += this.cmdDeleteNavalRank_Click;
        this.cmdRestore.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdRestore.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdRestore.Location = new Point(1632, 0);
        this.cmdRestore.Margin = new Padding(0);
        this.cmdRestore.Name = "cmdRestore";
        this.cmdRestore.Size = new Size(96 /*0x60*/, 30);
        this.cmdRestore.TabIndex = 30;
        this.cmdRestore.Tag = "1200";
        this.cmdRestore.Text = "Restore";
        this.cmdRestore.UseVisualStyleBackColor = false;
        this.cmdRestore.Visible = false;
        this.cmdRestore.Click += this.cmdRestore_Click;
        this.cmdRetain.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdRetain.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cmdRetain.Location = new Point(1728, 0);
        this.cmdRetain.Margin = new Padding(0);
        this.cmdRetain.Name = "cmdRetain";
        this.cmdRetain.Size = new Size(96 /*0x60*/, 30);
        this.cmdRetain.TabIndex = 31 /*0x1F*/;
        this.cmdRetain.Tag = "1200";
        this.cmdRetain.Text = "Retain";
        this.cmdRetain.UseVisualStyleBackColor = false;
        this.cmdRetain.Visible = false;
        this.cmdRetain.Click += this.cmdRetain_Click;
        this.lstvCmdrSummary.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.lstvCmdrSummary.BorderStyle = BorderStyle.None;
        this.lstvCmdrSummary.Columns.AddRange(new ColumnHeader[2]
        {
            this.columnHeader_0,
            this.columnHeader_1
        });
        this.lstvCmdrSummary.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.lstvCmdrSummary.FullRowSelect = true;
        this.lstvCmdrSummary.HeaderStyle = ColumnHeaderStyle.None;
        this.lstvCmdrSummary.Location = new Point(0, 0);
        this.lstvCmdrSummary.Margin = new Padding(0);
        this.lstvCmdrSummary.Name = "lstvCmdrSummary";
        this.lstvCmdrSummary.Size = new Size(360, 245);
        this.lstvCmdrSummary.TabIndex = 117;
        this.lstvCmdrSummary.UseCompatibleStateImageBehavior = false;
        this.lstvCmdrSummary.View = View.Details;
        this.columnHeader_0.Width = 230;
        this.columnHeader_1.Width = 110;
        this.lstvBonus.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.lstvBonus.BorderStyle = BorderStyle.FixedSingle;
        this.lstvBonus.Columns.AddRange(new ColumnHeader[2]
        {
            this.columnHeader_2,
            this.columnHeader_3
        });
        this.lstvBonus.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.lstvBonus.FullRowSelect = true;
        this.lstvBonus.HeaderStyle = ColumnHeaderStyle.None;
        this.lstvBonus.Location = new Point(662, 30);
        this.lstvBonus.Margin = new Padding(4, 3, 3, 3);
        this.lstvBonus.Name = "lstvBonus";
        this.lstvBonus.Size = new Size(260, 268);
        this.lstvBonus.TabIndex = 118;
        this.lstvBonus.UseCompatibleStateImageBehavior = false;
        this.lstvBonus.View = View.Details;
        this.columnHeader_2.Width = 175;
        this.columnHeader_3.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_3.Width = 70;
        this.flowLayoutPanel2.BorderStyle = BorderStyle.FixedSingle;
        this.flowLayoutPanel2.Controls.Add(this.lblName);
        this.flowLayoutPanel2.Controls.Add(this.lblAssignment);
        this.flowLayoutPanel2.Location = new Point(295, 4);
        this.flowLayoutPanel2.Name = "flowLayoutPanel2";
        this.flowLayoutPanel2.Size = new Size(960, 20);
        this.flowLayoutPanel2.TabIndex = 120;
        this.lblName.AutoSize = true;
        this.lblName.Location = new Point(3, 3);
        this.lblName.Margin = new Padding(3);
        this.lblName.Name = "lblName";
        this.lblName.Size = new Size(94, 13);
        this.lblName.TabIndex = 52;
        this.lblName.Text = "Commander Name";
        this.lblAssignment.AutoSize = true;
        this.lblAssignment.Location = new Point(103, 3);
        this.lblAssignment.Margin = new Padding(3);
        this.lblAssignment.Name = "lblAssignment";
        this.lblAssignment.Size = new Size(120, 13);
        this.lblAssignment.TabIndex = 53;
        this.lblAssignment.Text = "Commander Assignment";
        this.lstvHistory.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.lstvHistory.BorderStyle = BorderStyle.FixedSingle;
        this.lstvHistory.Columns.AddRange(new ColumnHeader[2]
        {
            this.columnHeader_4,
            this.columnHeader_5
        });
        this.lstvHistory.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.lstvHistory.FullRowSelect = true;
        this.lstvHistory.HeaderStyle = ColumnHeaderStyle.None;
        this.lstvHistory.Location = new Point(929, 30);
        this.lstvHistory.Margin = new Padding(4, 3, 3, 3);
        this.lstvHistory.Name = "lstvHistory";
        this.lstvHistory.Size = new Size(492, 268);
        this.lstvHistory.TabIndex = 121;
        this.lstvHistory.UseCompatibleStateImageBehavior = false;
        this.lstvHistory.View = View.Details;
        this.columnHeader_4.Width = 125;
        this.columnHeader_5.Width = 350;
        this.flpMedals.BorderStyle = BorderStyle.FixedSingle;
        this.flpMedals.Location = new Point(295, 304);
        this.flpMedals.Margin = new Padding(0);
        this.flpMedals.Name = "flpMedals";
        this.flpMedals.Size = new Size(1126, 126);
        this.flpMedals.TabIndex = 122;
        this.flpAssignments.BorderStyle = BorderStyle.FixedSingle;
        this.flpAssignments.Controls.Add(this.cboAssign);
        this.flpAssignments.Controls.Add(this.chkEligible);
        this.flpAssignments.Controls.Add(this.chkAvailable);
        this.flpAssignments.Controls.Add(this.lstvAssign);
        this.flpAssignments.Location = new Point(295, 435);
        this.flpAssignments.Name = "flpAssignments";
        this.flpAssignments.Size = new Size(442, 386);
        this.flpAssignments.TabIndex = 123;
        this.cboAssign.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cboAssign.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cboAssign.FormattingEnabled = true;
        this.cboAssign.Location = new Point(0, 0);
        this.cboAssign.Margin = new Padding(0, 0, 3, 0);
        this.cboAssign.Name = "cboAssign";
        this.cboAssign.Size = new Size(239, 21);
        this.cboAssign.TabIndex = 5;
        this.cboAssign.SelectedIndexChanged += this.chkAvailable_CheckedChanged;
        this.chkEligible.AutoSize = true;
        this.chkEligible.Location = new Point(245, 3);
        this.chkEligible.Name = "chkEligible";
        this.chkEligible.Size = new Size(83, 17);
        this.chkEligible.TabIndex = 6;
        this.chkEligible.Text = "Eligible Only";
        this.chkEligible.UseVisualStyleBackColor = true;
        this.chkEligible.CheckedChanged += this.chkAvailable_CheckedChanged;
        this.chkAvailable.AutoSize = true;
        this.chkAvailable.Location = new Point(334, 3);
        this.chkAvailable.Name = "chkAvailable";
        this.chkAvailable.Size = new Size(93, 17);
        this.chkAvailable.TabIndex = 7;
        this.chkAvailable.Text = "Available Only";
        this.chkAvailable.UseVisualStyleBackColor = true;
        this.chkAvailable.CheckedChanged += this.chkAvailable_CheckedChanged;
        this.lstvAssign.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.lstvAssign.BorderStyle = BorderStyle.None;
        this.lstvAssign.Columns.AddRange(new ColumnHeader[4]
        {
            this.columnHeader_6,
            this.columnHeader_7,
            this.columnHeader_8,
            this.columnHeader_9
        });
        this.lstvAssign.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.lstvAssign.FullRowSelect = true;
        this.lstvAssign.HeaderStyle = ColumnHeaderStyle.None;
        this.lstvAssign.Location = new Point(0, 26);
        this.lstvAssign.Margin = new Padding(0, 3, 0, 0);
        this.lstvAssign.Name = "lstvAssign";
        this.lstvAssign.Size = new Size(440, 359);
        this.lstvAssign.TabIndex = 124;
        this.lstvAssign.UseCompatibleStateImageBehavior = false;
        this.lstvAssign.View = View.Details;
        this.lstvAssign.SelectedIndexChanged += this.lstvAssign_SelectedIndexChanged;
        this.columnHeader_6.Width = 40;
        this.columnHeader_7.Width = 220;
        this.columnHeader_8.Width = 50;
        this.columnHeader_9.Width = 0;
        this.flpSearch.BorderStyle = BorderStyle.FixedSingle;
        this.flpSearch.Controls.Add(this.cboType);
        this.flpSearch.Controls.Add(this.label1);
        this.flpSearch.Controls.Add(this.cboMinRank);
        this.flpSearch.Controls.Add(this.label2);
        this.flpSearch.Controls.Add(this.cboMaxRank);
        this.flpSearch.Controls.Add(this.cboSort1);
        this.flpSearch.Controls.Add(this.cboSort2);
        this.flpSearch.Controls.Add(this.cboSort3);
        this.flpSearch.Controls.Add(this.cboSort4);
        this.flpSearch.Controls.Add(this.lstvSearch);
        this.flpSearch.Location = new Point(743, 435);
        this.flpSearch.Name = "flpSearch";
        this.flpSearch.Size = new Size(678, 386);
        this.flpSearch.TabIndex = 126;
        this.cboType.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cboType.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cboType.FormattingEnabled = true;
        this.cboType.Location = new Point(0, 0);
        this.cboType.Margin = new Padding(0, 0, 3, 0);
        this.cboType.Name = "cboType";
        this.cboType.Size = new Size(166, 21);
        this.cboType.TabIndex = 8;
        this.cboType.SelectedIndexChanged += this.cboType_SelectedIndexChanged;
        this.label1.AutoSize = true;
        this.label1.Location = new Point(172, 3);
        this.label1.Margin = new Padding(3);
        this.label1.Name = "label1";
        this.label1.Size = new Size(77, 13);
        this.label1.TabIndex = 132;
        this.label1.Text = "Minimum Rank";
        this.cboMinRank.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cboMinRank.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cboMinRank.FormattingEnabled = true;
        this.cboMinRank.Location = new Point(252, 0);
        this.cboMinRank.Margin = new Padding(0, 0, 3, 0);
        this.cboMinRank.Name = "cboMinRank";
        this.cboMinRank.Size = new Size(166, 21);
        this.cboMinRank.TabIndex = 130;
        this.cboMinRank.SelectedIndexChanged += this.cboSort4_SelectedIndexChanged;
        this.label2.AutoSize = true;
        this.label2.Location = new Point(424, 3);
        this.label2.Margin = new Padding(3);
        this.label2.Name = "label2";
        this.label2.Size = new Size(80 /*0x50*/, 13);
        this.label2.TabIndex = 133;
        this.label2.Text = "Maximum Rank";
        this.cboMaxRank.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cboMaxRank.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cboMaxRank.FormattingEnabled = true;
        this.cboMaxRank.Location = new Point(507, 0);
        this.cboMaxRank.Margin = new Padding(0, 0, 3, 0);
        this.cboMaxRank.Name = "cboMaxRank";
        this.cboMaxRank.Size = new Size(166, 21);
        this.cboMaxRank.TabIndex = 131;
        this.cboMaxRank.SelectedIndexChanged += this.cboSort4_SelectedIndexChanged;
        this.cboSort1.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cboSort1.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cboSort1.FormattingEnabled = true;
        this.cboSort1.Location = new Point(0, 21);
        this.cboSort1.Margin = new Padding(0, 0, 3, 0);
        this.cboSort1.Name = "cboSort1";
        this.cboSort1.Size = new Size(166, 21);
        this.cboSort1.TabIndex = 9;
        this.cboSort1.SelectedIndexChanged += this.cboSort4_SelectedIndexChanged;
        this.cboSort2.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cboSort2.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cboSort2.FormattingEnabled = true;
        this.cboSort2.Location = new Point(169, 21);
        this.cboSort2.Margin = new Padding(0, 0, 3, 0);
        this.cboSort2.Name = "cboSort2";
        this.cboSort2.Size = new Size(166, 21);
        this.cboSort2.TabIndex = 10;
        this.cboSort2.SelectedIndexChanged += this.cboSort4_SelectedIndexChanged;
        this.cboSort3.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cboSort3.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cboSort3.FormattingEnabled = true;
        this.cboSort3.Location = new Point(338, 21);
        this.cboSort3.Margin = new Padding(0, 0, 3, 0);
        this.cboSort3.Name = "cboSort3";
        this.cboSort3.Size = new Size(166, 21);
        this.cboSort3.TabIndex = 11;
        this.cboSort3.SelectedIndexChanged += this.cboSort4_SelectedIndexChanged;
        this.cboSort4.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cboSort4.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.cboSort4.FormattingEnabled = true;
        this.cboSort4.Location = new Point(507, 21);
        this.cboSort4.Margin = new Padding(0, 0, 3, 0);
        this.cboSort4.Name = "cboSort4";
        this.cboSort4.Size = new Size(166, 21);
        this.cboSort4.TabIndex = 12;
        this.cboSort4.SelectedIndexChanged += this.cboSort4_SelectedIndexChanged;
        this.lstvSearch.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.lstvSearch.BorderStyle = BorderStyle.None;
        this.lstvSearch.Columns.AddRange(new ColumnHeader[6]
        {
            this.columnHeader_10,
            this.columnHeader_15,
            this.columnHeader_11,
            this.columnHeader_12,
            this.columnHeader_13,
            this.columnHeader_14
        });
        this.lstvSearch.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.lstvSearch.FullRowSelect = true;
        this.lstvSearch.HeaderStyle = ColumnHeaderStyle.None;
        this.lstvSearch.Location = new Point(0, 48 /*0x30*/);
        this.lstvSearch.Margin = new Padding(0, 6, 0, 0);
        this.lstvSearch.Name = "lstvSearch";
        this.lstvSearch.Size = new Size(677, 331);
        this.lstvSearch.TabIndex = 129;
        this.lstvSearch.UseCompatibleStateImageBehavior = false;
        this.lstvSearch.View = View.Details;
        this.lstvSearch.SelectedIndexChanged += this.lstvSearch_SelectedIndexChanged;
        this.columnHeader_10.Width = 200;
        this.columnHeader_15.Width = 220;
        this.columnHeader_11.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_12.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_13.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_14.TextAlign = HorizontalAlignment.Center;
        this.chkAutoAssign.AutoSize = true;
        this.chkAutoAssign.Location = new Point(1275, 7);
        this.chkAutoAssign.Margin = new Padding(3, 2, 3, 2);
        this.chkAutoAssign.Name = "chkAutoAssign";
        this.chkAutoAssign.Size = new Size(139, 17);
        this.chkAutoAssign.TabIndex = 2;
        this.chkAutoAssign.Text = "Automated Assignments";
        this.chkAutoAssign.UseVisualStyleBackColor = true;
        this.chkAutoAssign.CheckedChanged += this.chkAutoAssign_CheckedChanged;
        this.panel1.BorderStyle = BorderStyle.FixedSingle;
        this.panel1.Controls.Add(this.chkDoNotPromote);
        this.panel1.Controls.Add(this.chkStory);
        this.panel1.Controls.Add(this.lstvCmdrSummary);
        this.panel1.Location = new Point(294, 30);
        this.panel1.Name = "panel1";
        this.panel1.Size = new Size(360, 268);
        this.panel1.TabIndex = 127;
        this.chkDoNotPromote.AutoSize = true;
        this.chkDoNotPromote.Location = new Point(110, 248);
        this.chkDoNotPromote.Margin = new Padding(3, 2, 3, 2);
        this.chkDoNotPromote.Name = "chkDoNotPromote";
        this.chkDoNotPromote.Size = new Size(102, 17);
        this.chkDoNotPromote.TabIndex = 4;
        this.chkDoNotPromote.Text = "Do Not Promote";
        this.chkDoNotPromote.UseVisualStyleBackColor = true;
        this.chkDoNotPromote.CheckedChanged += this.chkDoNotPromote_CheckedChanged;
        this.chkStory.AutoSize = true;
        this.chkStory.Location = new Point(5, 248);
        this.chkStory.Margin = new Padding(3, 2, 3, 2);
        this.chkStory.Name = "chkStory";
        this.chkStory.Size = new Size(99, 17);
        this.chkStory.TabIndex = 3;
        this.chkStory.Text = "Story Character";
        this.chkStory.UseVisualStyleBackColor = true;
        this.chkStory.CheckedChanged += this.chkStory_CheckedChanged;
        this.AutoScaleDimensions = new SizeF(6f, 13f);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.ClientSize = new Size(1424, 861);
        this.Controls.Add(this.chkAutoAssign);
        this.Controls.Add(this.flpSearch);
        this.Controls.Add(this.flpAssignments);
        this.Controls.Add(this.flpMedals);
        this.Controls.Add(this.panel1);
        this.Controls.Add(this.lstvHistory);
        this.Controls.Add(this.flowLayoutPanel2);
        this.Controls.Add(this.lstvBonus);
        this.Controls.Add(this.flowLayoutPanel1);
        this.Controls.Add(this.tvCommanderList);
        this.Controls.Add(this.cboRaces);
        this.ForeColor = Color.FromArgb(255, 255, 192 /*0xC0*/);
        this.FormBorderStyle = FormBorderStyle.FixedSingle;
        this.KeyPreview = true;
        this.Name = "CommandersWindow";
        this.Text = "Commanders";
        this.FormClosing += this.CommandersWindow_FormClosing;
        this.Load += this.CommandersWindow_Load;
        this.KeyDown += this.CommandersWindow_KeyDown;
        this.flowLayoutPanel1.ResumeLayout(false);
        this.flowLayoutPanel2.ResumeLayout(false);
        this.flowLayoutPanel2.PerformLayout();
        this.flpAssignments.ResumeLayout(false);
        this.flpAssignments.PerformLayout();
        this.flpSearch.ResumeLayout(false);
        this.flpSearch.PerformLayout();
        this.panel1.ResumeLayout(false);
        this.panel1.PerformLayout();
        this.ResumeLayout(false);
        this.PerformLayout();
    }
}