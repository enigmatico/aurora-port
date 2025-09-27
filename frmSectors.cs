// Decompiled with JetBrains decompiler
// Type: frmSectors
// Assembly: Aurora, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAB8E3AD-3A24-426F-849E-98EC2E2DD9EB
// Assembly location: C:\Users\jinhoon.kim\Desktop\Aurora250Full\Dedot\aurora-deop.exe

using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

#nullable disable
public class frmSectors : Form
{
    private GClass0 gclass0_0;
    private FCTRaceRecordC21 gclass21_0;
    private bool bool_0;
    private IContainer icontainer_0;
    private TreeView tvSectors;
    private ComboBox cboRaces;
    private ListBox lstAvailable;
    private FlowLayoutPanel flowLayoutPanel1;
    private Button cmdRename;
    private ListView lstvSectorDetail;
    private ColumnHeader columnHeader_0;
    private ColumnHeader columnHeader_1;

    public frmSectors(GClass0 gclass0_1)
    {
        this.InitializeComponent();
        this.gclass0_0 = gclass0_1;
    }

    private void frmSectors_FormClosing(object sender, FormClosingEventArgs e)
    {
        try
        {
            this.gclass0_0.method_512(this.Name, this.Left, this.Top);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1074);
        }
    }

    private void frmSectors_Load(object sender, EventArgs e)
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
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1075);
        }
    }

    private void cboRaces_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            this.method_0();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1076);
        }
    }

    public void method_0()
    {
        try
        {
            this.gclass21_0 = (FCTRaceRecordC21)this.cboRaces.SelectedValue;
            this.gclass21_0.method_380(this.tvSectors);
            if (!this.bool_0)
                this.gclass0_0.method_511(this.gclass21_0, this);
            this.bool_0 = false;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1077);
        }
    }

    public void method_1(FCTRaceRecordC21 gclass21_1)
    {
        try
        {
            this.bool_0 = true;
            this.cboRaces.SelectedItem = gclass21_1;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1078);
        }
    }

    private void tvSectors_AfterSelect(object sender, TreeViewEventArgs e)
    {
        try
        {
            if (!(e.Node.Tag is GClass62))
                return;
            GClass62 tag = (GClass62)e.Node.Tag;
            this.gclass21_0.method_381(this.lstAvailable, tag);
            tag.method_0(this.lstvSectorDetail);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1079);
        }
    }

    private void tvSectors_AfterExpand(object sender, TreeViewEventArgs e)
    {
        try
        {
            if (!(e.Node.Tag is GClass62))
                return;
            ((GClass62)e.Node.Tag).bool_0 = e.Node.IsExpanded;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1080);
        }
    }

    private void lstAvailable_DoubleClick(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass21_0 == null)
            {
                int num1 = (int)MessageBox.Show("Please select a race");
            }
            else if (this.tvSectors.SelectedNode == null)
            {
                int num2 = (int)MessageBox.Show("Please select a sector");
            }
            else if (this.tvSectors.SelectedNode.Tag is GClass62)
            {
                GClass62 tag = (GClass62)this.tvSectors.SelectedNode.Tag;
                RacialSystemSurvey selectedValue = (RacialSystemSurvey)this.lstAvailable.SelectedValue;
                if (selectedValue == null)
                {
                    int num3 = (int)MessageBox.Show("Please select a system to assign to the sector");
                }
                else
                {
                    tag.bool_0 = true;
                    selectedValue.gclass62_0 = tag;
                    selectedValue.SectorID = tag.int_0;
                    this.gclass21_0.method_380(this.tvSectors);
                    foreach (TreeNode node in this.tvSectors.Nodes)
                    {
                        if ((GClass62)node.Tag == tag)
                        {
                            this.tvSectors.SelectedNode = node;
                            break;
                        }
                    }
                }
            }
            else
            {
                int num4 = (int)MessageBox.Show("Please select a sector");
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1081);
        }
    }

    private void lstAvailable_SelectedIndexChanged(object sender, EventArgs e)
    {
    }

    private void tvSectors_DoubleClick(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass21_0 == null)
            {
                int num1 = (int)MessageBox.Show("Please select a race");
            }
            else if (this.tvSectors.SelectedNode == null)
            {
                int num2 = (int)MessageBox.Show("Please select a system to unassign");
            }
            else if (this.tvSectors.SelectedNode.Tag is RacialSystemSurvey)
            {
                RacialSystemSurvey tag = (RacialSystemSurvey)this.tvSectors.SelectedNode.Tag;
                if (tag == null)
                {
                    int num3 = (int)MessageBox.Show("Please select a system to unassign");
                }
                else
                {
                    var cgc62 = tag.gclass62_0;
                    tag.gclass62_0 = null;
                    tag.SectorID = 0;
                    TreeNode treeNode = new TreeNode();
                    foreach (TreeNode node in this.tvSectors.Nodes)
                    {
                        if ((GClass62)node.Tag == cgc62)
                        {
                            treeNode = node;
                            break;
                        }
                    }

                    treeNode.Nodes.Clear();
                    foreach (RacialSystemSurvey gclass202 in this.gclass21_0.RacialSystemDictionary.Values.Where<RacialSystemSurvey>(
                                 gc202 => gc202.gclass62_0 == cgc62).ToList<RacialSystemSurvey>())
                        treeNode.Nodes.Add(new TreeNode()
                        {
                            Text = gclass202.Name,
                            Tag = gclass202
                        });
                    this.gclass21_0.method_381(this.lstAvailable, cgc62);
                    cgc62.method_0(this.lstvSectorDetail);
                }
            }
            else
            {
                int num4 = (int)MessageBox.Show("Please select a system to unassign");
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1082);
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
            else if (this.tvSectors.SelectedNode == null)
            {
                int num2 = (int)MessageBox.Show("Please select an item to rename");
            }
            else if (this.tvSectors.SelectedNode.Tag is GClass62)
            {
                GClass62 tag = (GClass62)this.tvSectors.SelectedNode.Tag;
                string str = this.gclass0_0.method_562("Enter New Sector Name", tag.SectorName);
                if (str != "")
                    tag.SectorName = str;
                this.tvSectors.SelectedNode.Text = tag.SectorName;
            }
            else
            {
                if (!(this.tvSectors.SelectedNode.Tag is RacialSystemSurvey))
                    return;
                RacialSystemSurvey tag = (RacialSystemSurvey)this.tvSectors.SelectedNode.Tag;
                string str = this.gclass0_0.method_562("Enter New System Name", tag.Name);
                if (str != "")
                    tag.Name = str;
                this.tvSectors.SelectedNode.Text = tag.Name;
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1083);
        }
    }

    private void tvSectors_DragEnter(object sender, DragEventArgs e)
    {
        try
        {
            e.Effect = DragDropEffects.Move;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1086);
        }
    }

    private void tvSectors_DragDrop(object sender, DragEventArgs e)
    {
        try
        {
            TreeNode nodeAt = this.tvSectors.GetNodeAt(this.tvSectors.PointToClient(new Point(e.X, e.Y)));
            TreeNode data = (TreeNode)e.Data.GetData(typeof(TreeNode));
            if (data.Equals(nodeAt) || nodeAt == null)
                return;
            if (data.Tag is RacialSystemSurvey)
            {
                if (nodeAt.Tag is GClass62)
                {
                    RacialSystemSurvey tag1 = (RacialSystemSurvey)data.Tag;
                    GClass62 tag2 = (GClass62)nodeAt.Tag;
                    tag2.method_1();
                    if (tag2.dictionary_0.Values.Contains<RacialSystemSurvey>(tag1))
                    {
                        tag1.gclass62_0 = tag2;
                        tag2.bool_0 = true;
                        data.Remove();
                        nodeAt.Nodes.Add(data);
                    }
                    else
                    {
                        int num = (int)MessageBox.Show(
                            "Systems may only be assigned to a sector, if the system is within the target sector's command radius");
                    }
                }
                else
                {
                    int num1 = (int)MessageBox.Show("Systems may only be assigned to a sector");
                }
            }
            else
            {
                int num2 = (int)MessageBox.Show("Only systems may be dragged to a new location");
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1084);
        }
    }

    private void tvSectors_ItemDrag(object sender, ItemDragEventArgs e)
    {
        try
        {
            int num = (int)this.DoDragDrop(e.Item, DragDropEffects.Move);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1085);
        }
    }

    private void frmSectors_KeyDown(object sender, KeyEventArgs e)
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
            AuroraUtils.ShowExceptionPopup(ex, 3278);
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
        this.tvSectors = new TreeView();
        this.cboRaces = new ComboBox();
        this.lstAvailable = new ListBox();
        this.flowLayoutPanel1 = new FlowLayoutPanel();
        this.cmdRename = new Button();
        this.lstvSectorDetail = new ListView();
        this.columnHeader_0 = new ColumnHeader();
        this.columnHeader_1 = new ColumnHeader();
        this.flowLayoutPanel1.SuspendLayout();
        this.SuspendLayout();
        this.tvSectors.AllowDrop = true;
        this.tvSectors.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.tvSectors.BorderStyle = BorderStyle.FixedSingle;
        this.tvSectors.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.tvSectors.HideSelection = false;
        this.tvSectors.Location = new Point(3, 30);
        this.tvSectors.Margin = new Padding(3, 0, 0, 3);
        this.tvSectors.Name = "tvSectors";
        this.tvSectors.Size = new Size(350, 743);
        this.tvSectors.TabIndex = 42;
        this.tvSectors.AfterExpand += this.tvSectors_AfterExpand;
        this.tvSectors.ItemDrag += this.tvSectors_ItemDrag;
        this.tvSectors.AfterSelect += this.tvSectors_AfterSelect;
        this.tvSectors.DragDrop += this.tvSectors_DragDrop;
        this.tvSectors.DragEnter += this.tvSectors_DragEnter;
        this.tvSectors.DoubleClick += this.tvSectors_DoubleClick;
        this.cboRaces.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cboRaces.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.cboRaces.FormattingEnabled = true;
        this.cboRaces.Location = new Point(3, 3);
        this.cboRaces.Margin = new Padding(3, 3, 3, 0);
        this.cboRaces.Name = "cboRaces";
        this.cboRaces.Size = new Size(350, 21);
        this.cboRaces.TabIndex = 41;
        this.cboRaces.SelectedIndexChanged += this.cboRaces_SelectedIndexChanged;
        this.lstAvailable.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.lstAvailable.BorderStyle = BorderStyle.FixedSingle;
        this.lstAvailable.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.lstAvailable.FormattingEnabled = true;
        this.lstAvailable.Location = new Point(357, 393);
        this.lstAvailable.Name = "lstAvailable";
        this.lstAvailable.Size = new Size(350, 379);
        this.lstAvailable.TabIndex = 136;
        this.lstAvailable.SelectedIndexChanged += this.lstAvailable_SelectedIndexChanged;
        this.lstAvailable.DoubleClick += this.lstAvailable_DoubleClick;
        this.flowLayoutPanel1.Controls.Add(this.cmdRename);
        this.flowLayoutPanel1.Location = new Point(7, 778);
        this.flowLayoutPanel1.Name = "flowLayoutPanel1";
        this.flowLayoutPanel1.Size = new Size(616, 30);
        this.flowLayoutPanel1.TabIndex = 137;
        this.cmdRename.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdRename.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.cmdRename.Location = new Point(0, 0);
        this.cmdRename.Margin = new Padding(0);
        this.cmdRename.Name = "cmdRename";
        this.cmdRename.Size = new Size(96 /*0x60*/, 30);
        this.cmdRename.TabIndex = 131;
        this.cmdRename.Tag = "1200";
        this.cmdRename.Text = "Rename";
        this.cmdRename.UseVisualStyleBackColor = false;
        this.cmdRename.Click += this.cmdRename_Click;
        this.lstvSectorDetail.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.lstvSectorDetail.BorderStyle = BorderStyle.FixedSingle;
        this.lstvSectorDetail.Columns.AddRange(new ColumnHeader[2]
        {
            this.columnHeader_0,
            this.columnHeader_1
        });
        this.lstvSectorDetail.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.lstvSectorDetail.FullRowSelect = true;
        this.lstvSectorDetail.HeaderStyle = ColumnHeaderStyle.None;
        this.lstvSectorDetail.Location = new Point(357, 30);
        this.lstvSectorDetail.Margin = new Padding(4, 3, 3, 3);
        this.lstvSectorDetail.Name = "lstvSectorDetail";
        this.lstvSectorDetail.Size = new Size(350, 357);
        this.lstvSectorDetail.TabIndex = 138;
        this.lstvSectorDetail.UseCompatibleStateImageBehavior = false;
        this.lstvSectorDetail.View = View.Details;
        this.columnHeader_0.Width = 125;
        this.columnHeader_1.TextAlign = HorizontalAlignment.Center;
        this.columnHeader_1.Width = 225;
        this.AutoScaleDimensions = new SizeF(6f, 13f);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.ClientSize = new Size(712, 811);
        this.Controls.Add(this.lstvSectorDetail);
        this.Controls.Add(this.flowLayoutPanel1);
        this.Controls.Add(this.lstAvailable);
        this.Controls.Add(this.tvSectors);
        this.Controls.Add(this.cboRaces);
        this.FormBorderStyle = FormBorderStyle.FixedSingle;
        this.KeyPreview = true;
        this.Name = nameof(frmSectors);
        this.Text = "Sector Management";
        this.FormClosing += this.frmSectors_FormClosing;
        this.Load += this.frmSectors_Load;
        this.KeyDown += this.frmSectors_KeyDown;
        this.flowLayoutPanel1.ResumeLayout(false);
        this.ResumeLayout(false);
    }
}