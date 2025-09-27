// Decompiled with JetBrains decompiler
// Type: Events
// Assembly: Aurora, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAB8E3AD-3A24-426F-849E-98EC2E2DD9EB
// Assembly location: C:\Users\jinhoon.kim\Desktop\Aurora250Full\Dedot\aurora-deop.exe

using Aurora;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

#nullable disable
public class Events : Form
{
    private GClass0 gclass0_0;
    private FCTRaceRecordC21 gclass21_0;
    private GClass87 gclass87_0 = new GClass87();
    private GClass86 gclass86_0 = new GClass86();
    private bool bool_0;
    private IContainer icontainer_0;
    private ListView lstvEvents;
    private ColumnHeader columnHeader_0;
    private ColumnHeader columnHeader_1;
    private ColumnHeader columnHeader_2;
    private ColumnHeader columnHeader_3;
    private ComboBox cboRaces;
    private Label label6;
    private TextBox txtDays;
    private Button cmdBackColour;
    private Button cmdTextColour;
    private CheckBox chkShowAll;
    private Button cmdHideEvent;
    private Button cmdTextFile;
    private ComboBox cboCategory;
    private Button cmdRefresh;
    private CheckBox chkShowAllRaces;
    private FlowLayoutPanel flpButtons;
    private Button cmdHeight;
    private Button cmdCopyColour;
    private TextBox txtNumEvents;
    private Label label1;
    private Button cmdImportColours;
    private Button cmdExportColours;

    public Events(GClass0 gclass0_1)
    {
        this.gclass0_0 = gclass0_1;
        this.InitializeComponent();
    }

    private void Events_FormClosing(object sender, FormClosingEventArgs e)
    {
        try
        {
            this.gclass0_0.method_512(this.Name, this.Left, this.Top);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 645);
        }
    }

    private void Events_Load(object sender, EventArgs e)
    {
        try
        {
            WindowPosition207 gclass207 = this.gclass0_0.method_513(this.Name);
            this.Left = gclass207.Left;
            this.Top = gclass207.Top;
            this.gclass0_0.bool_9 = true;
            this.method_2();
            this.bool_0 = true;
            this.txtDays.Text = this.gclass0_0.int_109.ToString();
            this.txtNumEvents.Text = this.gclass0_0.int_110.ToString();
            this.gclass0_0.method_577(this.cboRaces);
            this.method_1();
            if (this.gclass0_0.bool_8)
                this.chkShowAllRaces.Visible = true;
            else
                this.chkShowAllRaces.Visible = false;
            this.gclass0_0.bool_9 = false;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 646);
        }
    }

    public void method_0()
    {
        try
        {
            this.gclass0_0.method_565(this.lstvEvents, this.gclass21_0,
                (int)Math.Ceiling(Convert.ToDecimal(this.txtDays.Text)),
                (int)Math.Ceiling(Convert.ToDecimal(this.txtNumEvents.Text)), this.chkShowAll.CheckState,
                this.chkShowAllRaces.CheckState, this.gclass86_0.auroraEventCategory_0);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 647);
        }
    }

    private void method_1()
    {
        ToolTip toolTip = new ToolTip();
        toolTip.AutoPopDelay = 2000;
        toolTip.InitialDelay = 750;
        toolTip.ReshowDelay = 500;
        toolTip.ShowAlways = true;
        toolTip.SetToolTip(this.cmdBackColour, "Set background colour for the selected event type");
        toolTip.SetToolTip(this.cmdTextColour, "Set text colour for the selected event type");
        toolTip.SetToolTip(this.chkShowAll, "Show all events, including those specified as hidden");
        toolTip.SetToolTip(this.cmdHideEvent, "Hide/unhide this type of event");
        toolTip.SetToolTip(this.cmdHeight, "Set or Unset the height of this window to the height of the screen");
    }

    private void method_2()
    {
        try
        {
            List<GClass86> gclass86List = new List<GClass86>();
            foreach (AuroraEventCategory enum_0 in Enum.GetValues(typeof(AuroraEventCategory)))
                gclass86List.Add(new GClass86()
                {
                    Description = AuroraUtils.smethod_82(enum_0),
                    auroraEventCategory_0 = enum_0
                });
            this.cboCategory.DisplayMember = "Description";
            this.cboCategory.DataSource = gclass86List;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 648);
        }
    }

    public void method_3(FCTRaceRecordC21 gclass21_1)
    {
        try
        {
            this.bool_0 = true;
            this.cboRaces.SelectedItem = gclass21_1;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 649);
        }
    }

    private void cboRaces_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            this.gclass21_0 = (FCTRaceRecordC21)this.cboRaces.SelectedValue;
            this.method_0();
            if (!this.bool_0)
                this.gclass0_0.method_511(this.gclass21_0, this);
            this.bool_0 = false;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 650);
        }
    }

    private void cmdBackColour_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.lstvEvents.SelectedItems.Count == 0)
            {
                int num1 = (int)MessageBox.Show("Please select an event to change the background colour");
            }
            else if (this.lstvEvents.SelectedItems[0].Tag == null)
            {
                int num2 = (int)MessageBox.Show("Please select an event to change the background colour");
            }
            else
            {
                GClass87 tag = (GClass87)this.lstvEvents.SelectedItems[0].Tag;
                ColorDialog colorDialog = this.gclass0_0.method_563(new ColorDialog()
                {
                    FullOpen = true
                });
                if (colorDialog.ShowDialog() != DialogResult.OK)
                    return;
                if (tag.gclass21_0.EventColourSettings.ContainsKey(tag.gclass88_0.EventTypeId))
                    tag.gclass21_0.EventColourSettings[tag.gclass88_0.EventTypeId].TextColour = colorDialog.Color;
                else
                    tag.gclass21_0.EventColourSettings.Add(tag.gclass88_0.EventTypeId, new EventColourSetting()
                    {
                        TextColour = colorDialog.Color,
                        AlertColour = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/),
                        EventType = tag.gclass88_0,
                        RaceID = tag.gclass21_0.RaceID
                    });
                this.method_0();
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 651);
        }
    }

    private void cmdTextColour_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.lstvEvents.SelectedItems.Count == 0)
            {
                int num1 = (int)MessageBox.Show("Please select an event to change the background colour");
            }
            else if (this.lstvEvents.SelectedItems[0].Tag == null)
            {
                int num2 = (int)MessageBox.Show("Please select an event to change the background colour");
            }
            else
            {
                GClass87 tag = (GClass87)this.lstvEvents.SelectedItems[0].Tag;
                ColorDialog colorDialog = this.gclass0_0.method_563(new ColorDialog()
                {
                    FullOpen = true
                });
                if (colorDialog.ShowDialog() != DialogResult.OK)
                    return;
                if (tag.gclass21_0.EventColourSettings.ContainsKey(tag.gclass88_0.EventTypeId))
                    tag.gclass21_0.EventColourSettings[tag.gclass88_0.EventTypeId].AlertColour = colorDialog.Color;
                else
                    tag.gclass21_0.EventColourSettings.Add(tag.gclass88_0.EventTypeId, new EventColourSetting()
                    {
                        TextColour = Color.FromArgb(0, 0, 64 /*0x40*/),
                        AlertColour = colorDialog.Color,
                        EventType = tag.gclass88_0,
                        RaceID = tag.gclass21_0.RaceID
                    });
                this.method_0();
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 652);
        }
    }

    private void cmdHideEvent_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.lstvEvents.SelectedItems.Count == 0)
            {
                int num1 = (int)MessageBox.Show("Please select an event to hide or unhide");
            }
            else if (this.lstvEvents.SelectedItems[0].Tag == null)
            {
                int num2 = (int)MessageBox.Show("Please select an event to hide or unhide");
            }
            else
            {
                GClass87 tag = (GClass87)this.lstvEvents.SelectedItems[0].Tag;
                tag?.gclass21_0.method_266(tag.gclass88_0.EventTypeId);
                this.method_0();
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 653);
        }
    }

    private void chkShowAllRaces_CheckedChanged(object sender, EventArgs e)
    {
        try
        {
            this.method_0();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 654);
        }
    }

    private void cmdRefresh_Click(object sender, EventArgs e)
    {
        try
        {
            this.method_0();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 655);
        }
    }

    private void cboCategory_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass0_0.bool_9)
                return;
            this.gclass86_0 = (GClass86)this.cboCategory.SelectedItem;
            this.method_0();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 656);
        }
    }

    private void cmdHeight_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.cmdHeight.Text == "Full Height")
            {
                this.Height = Screen.GetWorkingArea(this).Height - 10;
                this.flpButtons.Top = 819 + (this.Height - 890);
                this.lstvEvents.Height = 788 + (this.Height - 890);
                this.cmdHeight.Text = "Normal Height";
            }
            else
            {
                this.Height = 890;
                this.flpButtons.Top = 819;
                this.lstvEvents.Height = 788;
                this.cmdHeight.Text = "Full Height";
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 657);
        }
    }

    private void cmdCopyColour_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.lstvEvents.SelectedItems.Count == 0)
            {
                int num1 = (int)MessageBox.Show("Please select an event to copy the colours");
            }
            else if (this.lstvEvents.SelectedItems[0].Tag == null)
            {
                int num2 = (int)MessageBox.Show("Please select an event to copy the colours");
            }
            else
            {
                GClass87 tag = (GClass87)this.lstvEvents.SelectedItems[0].Tag;
                if (!tag.gclass21_0.EventColourSettings.ContainsKey(tag.gclass88_0.EventTypeId))
                {
                    int num3 = (int)MessageBox.Show("The current race has no colours set for this event");
                }
                else
                {
                    EventColourSetting gclass90 = tag.gclass21_0.EventColourSettings[tag.gclass88_0.EventTypeId];
                    foreach (FCTRaceRecordC21 gclass21 in this.gclass0_0.FCTRaceRecordDic.Values)
                    {
                        if (gclass21 != tag.gclass21_0)
                        {
                            if (gclass21.EventColourSettings.ContainsKey(tag.gclass88_0.EventTypeId))
                            {
                                gclass21.EventColourSettings[tag.gclass88_0.EventTypeId].AlertColour = gclass90.AlertColour;
                                gclass21.EventColourSettings[tag.gclass88_0.EventTypeId].TextColour = gclass90.TextColour;
                            }
                            else
                                gclass21.EventColourSettings.Add(tag.gclass88_0.EventTypeId, new EventColourSetting()
                                {
                                    AlertColour = gclass90.AlertColour,
                                    TextColour = gclass90.TextColour,
                                    EventType = tag.gclass88_0,
                                    RaceID = gclass21.RaceID
                                });
                        }
                    }

                    this.method_0();
                }
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 658);
        }
    }

    private void txtDays_Leave(object sender, EventArgs e)
    {
        try
        {
            this.gclass0_0.int_109 = (int)Math.Ceiling(Convert.ToDecimal(this.txtDays.Text));
            this.txtDays.Text = this.gclass0_0.int_109.ToString();
            this.method_0();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3197);
        }
    }

    private void txtNumEvents_Leave(object sender, EventArgs e)
    {
        try
        {
            this.gclass0_0.int_110 = (int)Math.Ceiling(Convert.ToDecimal(this.txtNumEvents.Text));
            this.txtNumEvents.Text = this.gclass0_0.int_110.ToString();
            this.method_0();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3198);
        }
    }

    private void lstvEvents_DoubleClick(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass0_0.bool_9 || this.lstvEvents.SelectedItems.Count == 0)
                return;
            this.gclass87_0 = (GClass87)this.lstvEvents.SelectedItems[0].Tag;
            if (this.gclass87_0 == null)
                return;
            this.gclass0_0.method_567(this.gclass87_0);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 659);
        }
    }

    private void Events_KeyDown(object sender, KeyEventArgs e)
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
            AuroraUtils.ShowExceptionPopup(ex, 3275);
        }
    }

    private void cmdImportColours_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.gclass21_0 == null)
            {
                int num1 = (int)MessageBox.Show("Please select a Race");
            }
            else
            {
                int num2 = (int)MessageBox.Show(
                    "Select the Event Colours CSV File. Please ensure you have the correct format");
                string path = AuroraUtils.smethod_18("");
                if (path == "")
                    return;
                using (StreamReader streamReader = new StreamReader(path))
                {
                    while (!streamReader.EndOfStream)
                    {
                        string[] source = streamReader.ReadLine().Split(',');
                        if (!(source[0] == "") && source.Count<string>() >= 3)
                        {
                            EventColourSetting gclass90 = new EventColourSetting();
                            gclass90.RaceID = this.gclass21_0.RaceID;
                            EventType int32_1 = (EventType)Convert.ToInt32(source[0]);
                            if (this.gclass0_0.DIMEventTypeDictionary.ContainsKey(int32_1))
                            {
                                gclass90.EventType = this.gclass0_0.DIMEventTypeDictionary[int32_1];
                                int int32_2 = Convert.ToInt32(source[1]);
                                int int32_3 = Convert.ToInt32(source[2]);
                                gclass90.TextColour = Color.FromArgb(byte.MaxValue, Color.FromArgb(int32_2));
                                gclass90.AlertColour = Color.FromArgb(byte.MaxValue, Color.FromArgb(int32_3));
                                if (this.gclass21_0.EventColourSettings.ContainsKey(int32_1))
                                    this.gclass21_0.EventColourSettings.Remove(int32_1);
                                this.gclass21_0.EventColourSettings.Add(int32_1, gclass90);
                            }
                        }
                    }
                }

                this.method_0();
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3381);
        }
    }

    private void cmdExportColours_Click(object sender, EventArgs e)
    {
        try
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            string str = "CSV file (*.csv)|*.csv| All Files (*.*)|*.*";
            saveFileDialog.Filter = str;
            if (saveFileDialog.ShowDialog() != DialogResult.OK)
                return;
            StreamWriter streamWriter = new StreamWriter(saveFileDialog.FileName);
            foreach (EventColourSetting gclass90 in this.gclass21_0.EventColourSettings.Values)
            {
                int argb1 = gclass90.TextColour.ToArgb();
                int argb2 = gclass90.AlertColour.ToArgb();
                streamWriter.Write((int)gclass90.EventType.EventTypeId);
                streamWriter.Write(",");
                streamWriter.Write(argb1);
                streamWriter.Write(",");
                streamWriter.Write(argb2);
                streamWriter.Write(streamWriter.NewLine);
            }

            streamWriter.Close();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3382);
        }
    }

    private void lstvEvents_SelectedIndexChanged(object sender, EventArgs e)
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
        this.lstvEvents = new ListView();
        this.columnHeader_0 = new ColumnHeader();
        this.columnHeader_1 = new ColumnHeader();
        this.columnHeader_2 = new ColumnHeader();
        this.columnHeader_3 = new ColumnHeader();
        this.cboRaces = new ComboBox();
        this.label6 = new Label();
        this.txtDays = new TextBox();
        this.cmdBackColour = new Button();
        this.cmdTextColour = new Button();
        this.chkShowAll = new CheckBox();
        this.cmdHideEvent = new Button();
        this.cmdTextFile = new Button();
        this.cboCategory = new ComboBox();
        this.cmdRefresh = new Button();
        this.chkShowAllRaces = new CheckBox();
        this.flpButtons = new FlowLayoutPanel();
        this.cmdCopyColour = new Button();
        this.cmdHeight = new Button();
        this.cmdImportColours = new Button();
        this.cmdExportColours = new Button();
        this.txtNumEvents = new TextBox();
        this.label1 = new Label();
        this.flpButtons.SuspendLayout();
        this.SuspendLayout();
        this.lstvEvents.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.lstvEvents.Columns.AddRange(new ColumnHeader[4]
        {
            this.columnHeader_0,
            this.columnHeader_1,
            this.columnHeader_2,
            this.columnHeader_3
        });
        this.lstvEvents.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.lstvEvents.FullRowSelect = true;
        this.lstvEvents.HeaderStyle = ColumnHeaderStyle.None;
        this.lstvEvents.HideSelection = false;
        this.lstvEvents.Location = new Point(2, 27);
        this.lstvEvents.Name = "lstvEvents";
        this.lstvEvents.Size = new Size(1240, 788);
        this.lstvEvents.TabIndex = 106;
        this.lstvEvents.UseCompatibleStateImageBehavior = false;
        this.lstvEvents.View = View.Details;
        this.lstvEvents.SelectedIndexChanged += this.lstvEvents_SelectedIndexChanged;
        this.lstvEvents.DoubleClick += this.lstvEvents_DoubleClick;
        this.columnHeader_0.Text = "";
        this.columnHeader_0.Width = 150;
        this.columnHeader_1.Text = "";
        this.columnHeader_1.Width = 150;
        this.columnHeader_2.Width = 120;
        this.columnHeader_3.Width = 780;
        this.cboRaces.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cboRaces.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.cboRaces.FormattingEnabled = true;
        this.cboRaces.Location = new Point(2, 3);
        this.cboRaces.Margin = new Padding(3, 3, 3, 0);
        this.cboRaces.Name = "cboRaces";
        this.cboRaces.Size = new Size(380, 21);
        this.cboRaces.TabIndex = 107;
        this.cboRaces.SelectedIndexChanged += this.cboRaces_SelectedIndexChanged;
        this.label6.AutoSize = true;
        this.label6.Location = new Point(595, 2);
        this.label6.Name = "label6";
        this.label6.Padding = new Padding(0, 5, 5, 0);
        this.label6.Size = new Size(67, 18);
        this.label6.TabIndex = 108;
        this.label6.Text = "Event Days";
        this.txtDays.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtDays.BorderStyle = BorderStyle.None;
        this.txtDays.ForeColor = Color.FromArgb(128 /*0x80*/, byte.MaxValue, 128 /*0x80*/);
        this.txtDays.Location = new Point(657, 7);
        this.txtDays.Name = "txtDays";
        this.txtDays.Size = new Size(36, 13);
        this.txtDays.TabIndex = 109;
        this.txtDays.Text = "30";
        this.txtDays.TextAlign = HorizontalAlignment.Center;
        this.txtDays.Leave += this.txtDays_Leave;
        this.cmdBackColour.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdBackColour.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.cmdBackColour.Location = new Point(384, 0);
        this.cmdBackColour.Margin = new Padding(0);
        this.cmdBackColour.Name = "cmdBackColour";
        this.cmdBackColour.Size = new Size(96 /*0x60*/, 30);
        this.cmdBackColour.TabIndex = 138;
        this.cmdBackColour.Tag = "1200";
        this.cmdBackColour.Text = "Back Colour";
        this.cmdBackColour.UseVisualStyleBackColor = false;
        this.cmdBackColour.Click += this.cmdBackColour_Click;
        this.cmdTextColour.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdTextColour.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.cmdTextColour.Location = new Point(288, 0);
        this.cmdTextColour.Margin = new Padding(0);
        this.cmdTextColour.Name = "cmdTextColour";
        this.cmdTextColour.Size = new Size(96 /*0x60*/, 30);
        this.cmdTextColour.TabIndex = 139;
        this.cmdTextColour.Tag = "1200";
        this.cmdTextColour.Text = "Text Colour";
        this.cmdTextColour.UseVisualStyleBackColor = false;
        this.cmdTextColour.Click += this.cmdTextColour_Click;
        this.chkShowAll.AutoSize = true;
        this.chkShowAll.Location = new Point(1139, 6);
        this.chkShowAll.Name = "chkShowAll";
        this.chkShowAll.Size = new Size(103, 17);
        this.chkShowAll.TabIndex = 140;
        this.chkShowAll.Text = "Show All Events";
        this.chkShowAll.TextAlign = ContentAlignment.MiddleRight;
        this.chkShowAll.UseVisualStyleBackColor = true;
        this.chkShowAll.CheckedChanged += this.chkShowAllRaces_CheckedChanged;
        this.cmdHideEvent.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdHideEvent.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.cmdHideEvent.Location = new Point(192 /*0xC0*/, 0);
        this.cmdHideEvent.Margin = new Padding(0);
        this.cmdHideEvent.Name = "cmdHideEvent";
        this.cmdHideEvent.Size = new Size(96 /*0x60*/, 30);
        this.cmdHideEvent.TabIndex = 141;
        this.cmdHideEvent.Tag = "1200";
        this.cmdHideEvent.Text = "Hide Event";
        this.cmdHideEvent.UseVisualStyleBackColor = false;
        this.cmdHideEvent.Click += this.cmdHideEvent_Click;
        this.cmdTextFile.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdTextFile.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.cmdTextFile.Location = new Point(96 /*0x60*/, 0);
        this.cmdTextFile.Margin = new Padding(0);
        this.cmdTextFile.Name = "cmdTextFile";
        this.cmdTextFile.Size = new Size(96 /*0x60*/, 30);
        this.cmdTextFile.TabIndex = 142;
        this.cmdTextFile.Tag = "1200";
        this.cmdTextFile.Text = "Text File";
        this.cmdTextFile.UseVisualStyleBackColor = false;
        this.cmdTextFile.Visible = false;
        this.cboCategory.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cboCategory.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.cboCategory.FormattingEnabled = true;
        this.cboCategory.Location = new Point(388, 3);
        this.cboCategory.Margin = new Padding(3, 3, 3, 0);
        this.cboCategory.Name = "cboCategory";
        this.cboCategory.Size = new Size(190, 21);
        this.cboCategory.TabIndex = 143;
        this.cboCategory.SelectedIndexChanged += this.cboCategory_SelectedIndexChanged;
        this.cmdRefresh.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdRefresh.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.cmdRefresh.Location = new Point(0, 0);
        this.cmdRefresh.Margin = new Padding(0);
        this.cmdRefresh.Name = "cmdRefresh";
        this.cmdRefresh.Size = new Size(96 /*0x60*/, 30);
        this.cmdRefresh.TabIndex = 144 /*0x90*/;
        this.cmdRefresh.Tag = "1200";
        this.cmdRefresh.Text = "Refresh";
        this.cmdRefresh.UseVisualStyleBackColor = false;
        this.cmdRefresh.Click += this.cmdRefresh_Click;
        this.chkShowAllRaces.AutoSize = true;
        this.chkShowAllRaces.Location = new Point(1025, 6);
        this.chkShowAllRaces.Name = "chkShowAllRaces";
        this.chkShowAllRaces.Size = new Size(101, 17);
        this.chkShowAllRaces.TabIndex = 145;
        this.chkShowAllRaces.Text = "Show All Races";
        this.chkShowAllRaces.TextAlign = ContentAlignment.MiddleRight;
        this.chkShowAllRaces.UseVisualStyleBackColor = true;
        this.chkShowAllRaces.CheckedChanged += this.chkShowAllRaces_CheckedChanged;
        this.flpButtons.Controls.Add(this.cmdRefresh);
        this.flpButtons.Controls.Add(this.cmdTextFile);
        this.flpButtons.Controls.Add(this.cmdHideEvent);
        this.flpButtons.Controls.Add(this.cmdTextColour);
        this.flpButtons.Controls.Add(this.cmdBackColour);
        this.flpButtons.Controls.Add(this.cmdCopyColour);
        this.flpButtons.Controls.Add(this.cmdHeight);
        this.flpButtons.Controls.Add(this.cmdImportColours);
        this.flpButtons.Controls.Add(this.cmdExportColours);
        this.flpButtons.Location = new Point(2, 819);
        this.flpButtons.Name = "flpButtons";
        this.flpButtons.Size = new Size(1170, 30);
        this.flpButtons.TabIndex = 146;
        this.cmdCopyColour.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdCopyColour.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.cmdCopyColour.Location = new Point(480, 0);
        this.cmdCopyColour.Margin = new Padding(0);
        this.cmdCopyColour.Name = "cmdCopyColour";
        this.cmdCopyColour.Size = new Size(96 /*0x60*/, 30);
        this.cmdCopyColour.TabIndex = 146;
        this.cmdCopyColour.Tag = "1200";
        this.cmdCopyColour.Text = "Copy Colour";
        this.cmdCopyColour.UseVisualStyleBackColor = false;
        this.cmdCopyColour.Click += this.cmdCopyColour_Click;
        this.cmdHeight.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdHeight.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.cmdHeight.Location = new Point(576, 0);
        this.cmdHeight.Margin = new Padding(0);
        this.cmdHeight.Name = "cmdHeight";
        this.cmdHeight.Size = new Size(96 /*0x60*/, 30);
        this.cmdHeight.TabIndex = 145;
        this.cmdHeight.Tag = "1200";
        this.cmdHeight.Text = "Full Height";
        this.cmdHeight.UseVisualStyleBackColor = false;
        this.cmdHeight.Click += this.cmdHeight_Click;
        this.cmdImportColours.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdImportColours.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.cmdImportColours.Location = new Point(672, 0);
        this.cmdImportColours.Margin = new Padding(0);
        this.cmdImportColours.Name = "cmdImportColours";
        this.cmdImportColours.Size = new Size(96 /*0x60*/, 30);
        this.cmdImportColours.TabIndex = 147;
        this.cmdImportColours.Tag = "1200";
        this.cmdImportColours.Text = "Import Colours";
        this.cmdImportColours.UseVisualStyleBackColor = false;
        this.cmdImportColours.Click += this.cmdImportColours_Click;
        this.cmdExportColours.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.cmdExportColours.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.cmdExportColours.Location = new Point(768 /*0x0300*/, 0);
        this.cmdExportColours.Margin = new Padding(0);
        this.cmdExportColours.Name = "cmdExportColours";
        this.cmdExportColours.Size = new Size(96 /*0x60*/, 30);
        this.cmdExportColours.TabIndex = 148;
        this.cmdExportColours.Tag = "1200";
        this.cmdExportColours.Text = "Export Colours";
        this.cmdExportColours.UseVisualStyleBackColor = false;
        this.cmdExportColours.Click += this.cmdExportColours_Click;
        this.txtNumEvents.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.txtNumEvents.BorderStyle = BorderStyle.None;
        this.txtNumEvents.ForeColor = Color.FromArgb(128 /*0x80*/, byte.MaxValue, 128 /*0x80*/);
        this.txtNumEvents.Location = new Point(802, 7);
        this.txtNumEvents.Name = "txtNumEvents";
        this.txtNumEvents.Size = new Size(36, 13);
        this.txtNumEvents.TabIndex = 148;
        this.txtNumEvents.Text = "300";
        this.txtNumEvents.TextAlign = HorizontalAlignment.Center;
        this.txtNumEvents.Leave += this.txtNumEvents_Leave;
        this.label1.AutoSize = true;
        this.label1.Location = new Point(736, 2);
        this.label1.Name = "label1";
        this.label1.Padding = new Padding(0, 5, 5, 0);
        this.label1.Size = new Size(68, 18);
        this.label1.TabIndex = 147;
        this.label1.Text = "Max Events";
        this.AutoScaleDimensions = new SizeF(6f, 13f);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
        this.ClientSize = new Size(1246, 851);
        this.Controls.Add(this.txtNumEvents);
        this.Controls.Add(this.label1);
        this.Controls.Add(this.flpButtons);
        this.Controls.Add(this.chkShowAllRaces);
        this.Controls.Add(this.cboCategory);
        this.Controls.Add(this.chkShowAll);
        this.Controls.Add(this.txtDays);
        this.Controls.Add(this.label6);
        this.Controls.Add(this.cboRaces);
        this.Controls.Add(this.lstvEvents);
        this.ForeColor = Color.FromArgb(byte.MaxValue, byte.MaxValue, 192 /*0xC0*/);
        this.FormBorderStyle = FormBorderStyle.FixedSingle;
        this.KeyPreview = true;
        this.Name = nameof(Events);
        this.Text = nameof(Events);
        this.FormClosing += this.Events_FormClosing;
        this.Load += this.Events_Load;
        this.KeyDown += this.Events_KeyDown;
        this.flpButtons.ResumeLayout(false);
        this.ResumeLayout(false);
        this.PerformLayout();
    }
}