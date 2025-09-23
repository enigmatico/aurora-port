// Decompiled with JetBrains decompiler
// Type: frmMedals
// Assembly: Aurora, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAB8E3AD-3A24-426F-849E-98EC2E2DD9EB
// Assembly location: C:\Users\jinhoon.kim\Desktop\Aurora250Full\Dedot\aurora-deop.exe

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

#nullable disable
public class frmMedals : Form
{
  private GClass0 gclass0_0;
  private GClass21 gclass21_0;
  private GClass42 gclass42_0;
  private string string_0 = "";
  private bool bool_0;
  private IContainer icontainer_0;
  private ListView lstvMedals;
  private ColumnHeader columnHeader_0;
  private ColumnHeader columnHeader_1;
  private ColumnHeader columnHeader_2;
  private ComboBox cboRaces;
  private ColumnHeader columnHeader_3;
  private ColumnHeader columnHeader_4;
  private ColumnHeader columnHeader_5;
  private ListView lstvConditions;
  private ColumnHeader columnHeader_6;
  private ColumnHeader columnHeader_7;
  private TabControl tabMedals;
  private TabPage tabCurrent;
  private TabPage tabPage2;
  private ColumnHeader columnHeader_8;
  private ColumnHeader columnHeader_9;
  private Button cmdSelectMedalImage;
  private Button cmdSaveMedal;
  private Button cmdSaveAsNew;
  private Button cmdDelete;
  private PictureBox pbMedalImage;
  private Panel panel1;
  private Label label1;
  private TextBox txtPoints;
  private CheckBox chkMultipleAwards;
  private TextBox txtMedalName;
  private TextBox txtDescription;
  private FlowLayoutPanel flowLayoutPanel1;
  private ComboBox cboConditions;
  private Button cmdDeleteCondition;
  private Button cmdAddCondition;
  private ListBox lstAssignedConditions;
  private ColumnHeader columnHeader_10;
  private TextBox txtAbbreviation;
  private Label label2;
  private Button cmdImportMedals;
  private Button cmdExportMedals;

  public frmMedals(GClass0 gclass0_1)
  {
    this.InitializeComponent();
    this.gclass0_0 = gclass0_1;
  }

  private void cmdSelectMedalImage_Click(object sender, EventArgs e)
  {
    try
    {
      if (this.gclass21_0 == null)
      {
        int num1 = (int) MessageBox.Show("Please select a race");
      }
      else
      {
        string filename = GClass226.smethod_18("Medals");
        if (!(filename != ""))
          return;
        int num2 = filename.LastIndexOf("\\");
        this.string_0 = filename.Substring(num2 + 1);
        this.pbMedalImage.Image = Image.FromFile(filename);
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 1063);
    }
  }

  public void method_0(GClass21 gclass21_1)
  {
    try
    {
      this.bool_0 = true;
      this.cboRaces.SelectedItem = (object) gclass21_1;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 1064);
    }
  }

  private void frmMedals_FormClosing(object sender, FormClosingEventArgs e)
  {
    try
    {
      this.gclass0_0.method_512(this.Name, this.Left, this.Top);
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 1065);
    }
  }

  private void frmMedals_Load(object sender, EventArgs e)
  {
    try
    {
      GClass207 gclass207 = this.gclass0_0.method_513(this.Name);
      this.Left = gclass207.int_0;
      this.Top = gclass207.int_1;
      this.gclass0_0.bool_9 = true;
      this.bool_0 = true;
      this.gclass0_0.method_577(this.cboRaces);
      this.gclass0_0.bool_9 = false;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 1066);
    }
  }

  private void cmdSaveMedal_Click(object sender, EventArgs e)
  {
    try
    {
      if (this.gclass42_0 == null)
      {
        int num1 = (int) MessageBox.Show("Please select a Medal");
      }
      else if (this.string_0 == "")
      {
        int num2 = (int) MessageBox.Show("Please select an image");
      }
      else
      {
        this.gclass42_0.string_0 = this.txtMedalName.Text;
        this.gclass42_0.string_1 = this.txtDescription.Text;
        this.gclass42_0.string_3 = this.txtAbbreviation.Text;
        this.gclass42_0.int_0 = Convert.ToInt32(this.txtPoints.Text);
        this.gclass42_0.string_2 = this.string_0;
        this.gclass42_0.image_0 = this.pbMedalImage.Image;
        this.gclass42_0.bool_0 = GClass226.smethod_27(this.chkMultipleAwards.CheckState);
        this.gclass21_0.method_312(this.lstvMedals);
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 1067);
    }
  }

  private void cmdSaveAsNew_Click(object sender, EventArgs e)
  {
    try
    {
      if (this.gclass21_0 == null)
      {
        int num1 = (int) MessageBox.Show("Please select a Race");
      }
      else if (this.string_0 == "")
      {
        int num2 = (int) MessageBox.Show("Please select an image");
      }
      else
      {
        this.gclass42_0 = new GClass42(this.gclass0_0);
        this.gclass42_0.int_1 = this.gclass0_0.method_26(GEnum0.const_46);
        this.gclass42_0.gclass21_0 = this.gclass21_0;
        this.gclass42_0.string_0 = this.txtMedalName.Text;
        this.gclass42_0.string_1 = this.txtDescription.Text;
        this.gclass42_0.int_0 = Convert.ToInt32(this.txtPoints.Text);
        this.gclass42_0.string_2 = this.string_0;
        this.gclass42_0.string_3 = this.txtAbbreviation.Text;
        this.gclass42_0.image_0 = this.pbMedalImage.Image;
        this.gclass42_0.bool_0 = GClass226.smethod_27(this.chkMultipleAwards.CheckState);
        this.gclass0_0.dictionary_34.Add(this.gclass42_0.int_1, this.gclass42_0);
        this.gclass21_0.method_312(this.lstvMedals);
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 1068);
    }
  }

  private void cboRaces_SelectedIndexChanged(object sender, EventArgs e)
  {
    try
    {
      this.gclass21_0 = (GClass21) this.cboRaces.SelectedValue;
      this.gclass21_0.method_312(this.lstvMedals);
      this.gclass21_0.method_314(this.lstvConditions, this.cboConditions);
      if (!this.bool_0)
        this.gclass0_0.method_511(this.gclass21_0, (object) this);
      this.bool_0 = false;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 1069);
    }
  }

  private void lstvMedals_SelectedIndexChanged(object sender, EventArgs e)
  {
    try
    {
      if (this.lstvMedals.SelectedItems.Count > 0)
        this.gclass42_0 = (GClass42) this.lstvMedals.SelectedItems[0].Tag;
      if (this.gclass42_0 == null)
        return;
      this.txtMedalName.Text = this.gclass42_0.string_0;
      this.txtDescription.Text = this.gclass42_0.string_1;
      this.txtAbbreviation.Text = this.gclass42_0.string_3;
      this.txtPoints.Text = this.gclass42_0.int_0.ToString();
      this.chkMultipleAwards.CheckState = !this.gclass42_0.bool_0 ? CheckState.Unchecked : CheckState.Checked;
      this.string_0 = this.gclass42_0.string_2;
      this.pbMedalImage.Image = Image.FromFile($"{Application.StartupPath}\\Medals\\{this.string_0}");
      this.gclass42_0.method_0(this.lstAssignedConditions);
      this.lstAssignedConditions.ClearSelected();
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 1070);
    }
  }

  private void cmdAddCondition_Click(object sender, EventArgs e)
  {
    try
    {
      if (this.gclass42_0 == null)
      {
        int num = (int) MessageBox.Show("Please select a Medal");
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        var cgc43 = (GClass43) this.cboConditions.SelectedValue;
        // ISSUE: reference to a compiler-generated method
        if (this.gclass0_0.list_1.FirstOrDefault<GClass44>(gc44=>gc44.gclass42_0 == this.gclass42_0 && gc44.gclass43_0 == cgc43) == null)
        {
          // ISSUE: reference to a compiler-generated field
          this.gclass0_0.list_1.Add(new GClass44()
          {
            gclass43_0 = cgc43,
            gclass42_0 = this.gclass42_0
          });
        }
        this.gclass42_0.method_0(this.lstAssignedConditions);
        this.gclass21_0.method_314(this.lstvConditions, this.cboConditions);
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 1071);
    }
  }

  private void cmdDeleteCondition_Click(object sender, EventArgs e)
  {
    try
    {
      if (this.gclass42_0 == null)
      {
        int num1 = (int) MessageBox.Show("Please select a Medal");
      }
      else
      {
        var cgc43 = (GClass43) this.lstAssignedConditions.SelectedValue;
        if (cgc43 == null)
        {
          int num2 = (int) MessageBox.Show("Please select a condition assigned to this medal");
        }
        else
        {
          GClass44 gclass44 = this.gclass0_0.list_1.FirstOrDefault<GClass44>(cgc44=>cgc44.gclass42_0 == this.gclass42_0 && cgc44.gclass43_0 == cgc43);;
          if (gclass44 != null)
            this.gclass0_0.list_1.Remove(gclass44);
          this.gclass42_0.method_0(this.lstAssignedConditions);
          this.gclass21_0.method_314(this.lstvConditions, this.cboConditions);
        }
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 1072);
    }
  }

  private void cmdDelete_Click(object sender, EventArgs e)
  {
    try
    {
      if (this.gclass42_0 == null)
      {
        int num = (int) MessageBox.Show("Please select a Medal");
      }
      else
      {
        if (MessageBox.Show($" Are you sure you want to delete {this.gclass42_0.string_0}?", "Confirmation Required", MessageBoxButtons.YesNo) != DialogResult.Yes)
          return;
        foreach (GClass44 gclass44 in this.gclass0_0.list_1.Where<GClass44>((Func<GClass44, bool>) (gclass44_0 => gclass44_0.gclass42_0 == this.gclass42_0)).ToList<GClass44>())
          this.gclass0_0.list_1.Remove(gclass44);
        this.gclass0_0.dictionary_34.Remove(this.gclass42_0.int_1);
        this.gclass21_0.method_312(this.lstvMedals);
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 1073);
    }
  }

  private void frmMedals_KeyDown(object sender, KeyEventArgs e)
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
      GClass226.smethod_74(ex, 3277);
    }
  }

  private void cmdImportMedals_Click(object sender, EventArgs e)
  {
    try
    {
      if (this.gclass21_0 == null)
      {
        int num1 = (int) MessageBox.Show("Please select a Race");
      }
      else
      {
        int num2 = (int) MessageBox.Show("Select the Medal CSV File. Please ensure you have the correct format");
        using (StreamReader streamReader = new StreamReader(GClass226.smethod_18("")))
        {
          while (!streamReader.EndOfStream)
          {
            string[] source = streamReader.ReadLine().Split(',');
            if (!(source[0] == "") && ((IEnumerable<string>) source).Count<string>() >= 6)
            {
              GClass42 gclass42 = new GClass42(this.gclass0_0)
              {
                int_1 = this.gclass0_0.method_26(GEnum0.const_46),
                gclass21_0 = this.gclass21_0,
                string_0 = source[0].Trim(),
                string_1 = source[1].Trim(),
                string_3 = source[2].Trim(),
                int_0 = Convert.ToInt32(source[3]),
                bool_0 = source[4] == "Y",
                string_2 = source[5]
              };
              gclass42.image_0 = Image.FromFile($"{Application.StartupPath}\\Medals\\{gclass42.string_2}");
              int index = 6;
              while (true)
              {
                int int32;
                do
                {
                  if (source.Length > index && !(source[index] == ""))
                    int32 = Convert.ToInt32(source[index]);
                  else
                    goto label_11;
                }
                while (!this.gclass0_0.dictionary_35.ContainsKey(int32));
                var cgc43 = this.gclass0_0.dictionary_35[int32];
                if (this.gclass0_0.list_1.FirstOrDefault<GClass44>(gc44=>gc44.gclass42_0==this.gclass42_0 && gc44.gclass43_0==cgc43) == null)
                {
                  this.gclass0_0.list_1.Add(new GClass44()
                  {
                    gclass43_0 = cgc43,
                    gclass42_0 = gclass42
                  });
                }
                ++index;
              }
label_11:
              this.gclass0_0.dictionary_34.Add(gclass42.int_1, gclass42);
              this.gclass21_0.method_312(this.lstvMedals);
            }
          }
        }
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 175);
    }
  }

  private void cmdExportMedals_Click(object sender, EventArgs e)
  {
    try
    {
      if (this.gclass21_0 == null)
      {
        int num = (int) MessageBox.Show("Please select a Race");
      }
      else
      {
        SaveFileDialog saveFileDialog = new SaveFileDialog();
        string str = "CSV file (*.csv)|*.csv| All Files (*.*)|*.*";
        saveFileDialog.Filter = str;
        if (saveFileDialog.ShowDialog() != DialogResult.OK)
          return;
        StreamWriter streamWriter = new StreamWriter(saveFileDialog.FileName);
        foreach (GClass42 gclass42 in this.gclass0_0.dictionary_34.Values.Where<GClass42>((Func<GClass42, bool>) (gclass42_1 => gclass42_1.gclass21_0 == this.gclass21_0)).OrderByDescending<GClass42, int>((Func<GClass42, int>) (gclass42_0 => gclass42_0.int_0)).ToList<GClass42>())
        {
          var cgc42 = gclass42;
          streamWriter.Write(cgc42.string_0 + ",");
          streamWriter.Write(cgc42.string_1 + ",");
          streamWriter.Write(cgc42.string_3 + ",");
          streamWriter.Write(cgc42.int_0.ToString() + ",");
          if (cgc42.bool_0)
            streamWriter.Write("Y,");
          else
            streamWriter.Write("N,");
          streamWriter.Write(cgc42.string_2);
          foreach (GClass44 gclass44 in this.gclass0_0.list_1.Where<GClass44>(gc44=>gc44.gclass42_0==cgc42).ToList<GClass44>())
            streamWriter.Write("," + gclass44.gclass43_0.int_0.ToString());
          streamWriter.Write(streamWriter.NewLine);
        }
        streamWriter.Close();
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3383);
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
    this.lstvMedals = new ListView();
    this.columnHeader_0 = new ColumnHeader();
    this.columnHeader_5 = new ColumnHeader();
    this.columnHeader_1 = new ColumnHeader();
    this.columnHeader_3 = new ColumnHeader();
    this.columnHeader_4 = new ColumnHeader();
    this.columnHeader_2 = new ColumnHeader();
    this.cboRaces = new ComboBox();
    this.lstvConditions = new ListView();
    this.columnHeader_6 = new ColumnHeader();
    this.columnHeader_8 = new ColumnHeader();
    this.columnHeader_9 = new ColumnHeader();
    this.columnHeader_7 = new ColumnHeader();
    this.columnHeader_10 = new ColumnHeader();
    this.tabMedals = new TabControl();
    this.tabCurrent = new TabPage();
    this.cmdDeleteCondition = new Button();
    this.cmdAddCondition = new Button();
    this.lstAssignedConditions = new ListBox();
    this.cmdDelete = new Button();
    this.flowLayoutPanel1 = new FlowLayoutPanel();
    this.cmdSelectMedalImage = new Button();
    this.cmdSaveAsNew = new Button();
    this.cmdSaveMedal = new Button();
    this.cmdImportMedals = new Button();
    this.cboConditions = new ComboBox();
    this.pbMedalImage = new PictureBox();
    this.panel1 = new Panel();
    this.txtAbbreviation = new TextBox();
    this.label2 = new Label();
    this.label1 = new Label();
    this.txtPoints = new TextBox();
    this.chkMultipleAwards = new CheckBox();
    this.txtMedalName = new TextBox();
    this.txtDescription = new TextBox();
    this.tabPage2 = new TabPage();
    this.cmdExportMedals = new Button();
    this.tabMedals.SuspendLayout();
    this.tabCurrent.SuspendLayout();
    this.flowLayoutPanel1.SuspendLayout();
    ((ISupportInitialize) this.pbMedalImage).BeginInit();
    this.panel1.SuspendLayout();
    this.tabPage2.SuspendLayout();
    this.SuspendLayout();
    this.lstvMedals.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.lstvMedals.BorderStyle = BorderStyle.FixedSingle;
    this.lstvMedals.Columns.AddRange(new ColumnHeader[6]
    {
      this.columnHeader_0,
      this.columnHeader_5,
      this.columnHeader_1,
      this.columnHeader_3,
      this.columnHeader_4,
      this.columnHeader_2
    });
    this.lstvMedals.Dock = DockStyle.Top;
    this.lstvMedals.ForeColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192 /*0xC0*/);
    this.lstvMedals.FullRowSelect = true;
    this.lstvMedals.HeaderStyle = ColumnHeaderStyle.None;
    this.lstvMedals.HideSelection = false;
    this.lstvMedals.Location = new Point(3, 3);
    this.lstvMedals.Margin = new Padding(3, 0, 3, 0);
    this.lstvMedals.Name = "lstvMedals";
    this.lstvMedals.Size = new Size(1165, 553);
    this.lstvMedals.TabIndex = 147;
    this.lstvMedals.UseCompatibleStateImageBehavior = false;
    this.lstvMedals.View = View.Details;
    this.lstvMedals.SelectedIndexChanged += new EventHandler(this.lstvMedals_SelectedIndexChanged);
    this.columnHeader_0.Width = 230;
    this.columnHeader_5.TextAlign = HorizontalAlignment.Center;
    this.columnHeader_1.TextAlign = HorizontalAlignment.Center;
    this.columnHeader_3.TextAlign = HorizontalAlignment.Center;
    this.columnHeader_4.TextAlign = HorizontalAlignment.Center;
    this.columnHeader_4.Width = 80 /*0x50*/;
    this.columnHeader_2.Width = 650;
    this.cboRaces.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.cboRaces.ForeColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192 /*0xC0*/);
    this.cboRaces.FormattingEnabled = true;
    this.cboRaces.Location = new Point(3, 3);
    this.cboRaces.Margin = new Padding(3, 3, 3, 0);
    this.cboRaces.Name = "cboRaces";
    this.cboRaces.Size = new Size(288, 21);
    this.cboRaces.TabIndex = 130;
    this.cboRaces.SelectedIndexChanged += new EventHandler(this.cboRaces_SelectedIndexChanged);
    this.lstvConditions.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.lstvConditions.BorderStyle = BorderStyle.FixedSingle;
    this.lstvConditions.Columns.AddRange(new ColumnHeader[5]
    {
      this.columnHeader_6,
      this.columnHeader_8,
      this.columnHeader_9,
      this.columnHeader_7,
      this.columnHeader_10
    });
    this.lstvConditions.ForeColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192 /*0xC0*/);
    this.lstvConditions.FullRowSelect = true;
    this.lstvConditions.HeaderStyle = ColumnHeaderStyle.None;
    this.lstvConditions.HideSelection = false;
    this.lstvConditions.Location = new Point(3, 3);
    this.lstvConditions.Margin = new Padding(3, 0, 3, 0);
    this.lstvConditions.Name = "lstvConditions";
    this.lstvConditions.Size = new Size(1165, 751);
    this.lstvConditions.TabIndex = 157;
    this.lstvConditions.UseCompatibleStateImageBehavior = false;
    this.lstvConditions.View = View.Details;
    this.columnHeader_6.Width = 480;
    this.columnHeader_8.Width = 250;
    this.columnHeader_9.Width = 170;
    this.columnHeader_7.Width = 180;
    this.tabMedals.Controls.Add((Control) this.tabCurrent);
    this.tabMedals.Controls.Add((Control) this.tabPage2);
    this.tabMedals.Location = new Point(3, 26);
    this.tabMedals.Name = "tabMedals";
    this.tabMedals.SelectedIndex = 0;
    this.tabMedals.Size = new Size(1179, 783);
    this.tabMedals.TabIndex = 158;
    this.tabCurrent.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.tabCurrent.Controls.Add((Control) this.cmdDeleteCondition);
    this.tabCurrent.Controls.Add((Control) this.cmdAddCondition);
    this.tabCurrent.Controls.Add((Control) this.lstAssignedConditions);
    this.tabCurrent.Controls.Add((Control) this.cmdDelete);
    this.tabCurrent.Controls.Add((Control) this.flowLayoutPanel1);
    this.tabCurrent.Controls.Add((Control) this.cboConditions);
    this.tabCurrent.Controls.Add((Control) this.pbMedalImage);
    this.tabCurrent.Controls.Add((Control) this.panel1);
    this.tabCurrent.Controls.Add((Control) this.txtMedalName);
    this.tabCurrent.Controls.Add((Control) this.txtDescription);
    this.tabCurrent.Controls.Add((Control) this.lstvMedals);
    this.tabCurrent.Location = new Point(4, 22);
    this.tabCurrent.Name = "tabCurrent";
    this.tabCurrent.Padding = new Padding(3);
    this.tabCurrent.Size = new Size(1171, 757);
    this.tabCurrent.TabIndex = 0;
    this.tabCurrent.Text = "Current Medals";
    this.cmdDeleteCondition.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.cmdDeleteCondition.ForeColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192 /*0xC0*/);
    this.cmdDeleteCondition.Location = new Point(728, 724);
    this.cmdDeleteCondition.Margin = new Padding(0);
    this.cmdDeleteCondition.Name = "cmdDeleteCondition";
    this.cmdDeleteCondition.Size = new Size(96 /*0x60*/, 30);
    this.cmdDeleteCondition.TabIndex = 173;
    this.cmdDeleteCondition.Tag = (object) "1200";
    this.cmdDeleteCondition.Text = "Delete Condition";
    this.cmdDeleteCondition.UseVisualStyleBackColor = false;
    this.cmdDeleteCondition.Click += new EventHandler(this.cmdDeleteCondition_Click);
    this.cmdAddCondition.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.cmdAddCondition.ForeColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192 /*0xC0*/);
    this.cmdAddCondition.Location = new Point(632, 724);
    this.cmdAddCondition.Margin = new Padding(0);
    this.cmdAddCondition.Name = "cmdAddCondition";
    this.cmdAddCondition.Size = new Size(96 /*0x60*/, 30);
    this.cmdAddCondition.TabIndex = 172;
    this.cmdAddCondition.Tag = (object) "1200";
    this.cmdAddCondition.Text = "Add Condition";
    this.cmdAddCondition.UseVisualStyleBackColor = false;
    this.cmdAddCondition.Click += new EventHandler(this.cmdAddCondition_Click);
    this.lstAssignedConditions.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.lstAssignedConditions.BorderStyle = BorderStyle.FixedSingle;
    this.lstAssignedConditions.ForeColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192 /*0xC0*/);
    this.lstAssignedConditions.FormattingEnabled = true;
    this.lstAssignedConditions.Location = new Point(632, 563);
    this.lstAssignedConditions.Name = "lstAssignedConditions";
    this.lstAssignedConditions.Size = new Size(532, 132);
    this.lstAssignedConditions.TabIndex = 171;
    this.cmdDelete.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.cmdDelete.ForeColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192 /*0xC0*/);
    this.cmdDelete.Location = new Point(1069, 724);
    this.cmdDelete.Margin = new Padding(0);
    this.cmdDelete.Name = "cmdDelete";
    this.cmdDelete.Size = new Size(96 /*0x60*/, 30);
    this.cmdDelete.TabIndex = 162;
    this.cmdDelete.Tag = (object) "1200";
    this.cmdDelete.Text = "Delete Medal";
    this.cmdDelete.UseVisualStyleBackColor = false;
    this.cmdDelete.Click += new EventHandler(this.cmdDelete_Click);
    this.flowLayoutPanel1.Controls.Add((Control) this.cmdSelectMedalImage);
    this.flowLayoutPanel1.Controls.Add((Control) this.cmdSaveAsNew);
    this.flowLayoutPanel1.Controls.Add((Control) this.cmdSaveMedal);
    this.flowLayoutPanel1.Controls.Add((Control) this.cmdImportMedals);
    this.flowLayoutPanel1.Controls.Add((Control) this.cmdExportMedals);
    this.flowLayoutPanel1.Location = new Point(3, 724);
    this.flowLayoutPanel1.Name = "flowLayoutPanel1";
    this.flowLayoutPanel1.Size = new Size(577, 30);
    this.flowLayoutPanel1.TabIndex = 169;
    this.cmdSelectMedalImage.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.cmdSelectMedalImage.ForeColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192 /*0xC0*/);
    this.cmdSelectMedalImage.Location = new Point(0, 0);
    this.cmdSelectMedalImage.Margin = new Padding(0);
    this.cmdSelectMedalImage.Name = "cmdSelectMedalImage";
    this.cmdSelectMedalImage.Size = new Size(96 /*0x60*/, 30);
    this.cmdSelectMedalImage.TabIndex = 159;
    this.cmdSelectMedalImage.Tag = (object) "1200";
    this.cmdSelectMedalImage.Text = "Select Image";
    this.cmdSelectMedalImage.UseVisualStyleBackColor = false;
    this.cmdSelectMedalImage.Click += new EventHandler(this.cmdSelectMedalImage_Click);
    this.cmdSaveAsNew.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.cmdSaveAsNew.ForeColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192 /*0xC0*/);
    this.cmdSaveAsNew.Location = new Point(96 /*0x60*/, 0);
    this.cmdSaveAsNew.Margin = new Padding(0);
    this.cmdSaveAsNew.Name = "cmdSaveAsNew";
    this.cmdSaveAsNew.Size = new Size(96 /*0x60*/, 30);
    this.cmdSaveAsNew.TabIndex = 160 /*0xA0*/;
    this.cmdSaveAsNew.Tag = (object) "1200";
    this.cmdSaveAsNew.Text = "Save As New";
    this.cmdSaveAsNew.UseVisualStyleBackColor = false;
    this.cmdSaveAsNew.Click += new EventHandler(this.cmdSaveAsNew_Click);
    this.cmdSaveMedal.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.cmdSaveMedal.ForeColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192 /*0xC0*/);
    this.cmdSaveMedal.Location = new Point(192 /*0xC0*/, 0);
    this.cmdSaveMedal.Margin = new Padding(0);
    this.cmdSaveMedal.Name = "cmdSaveMedal";
    this.cmdSaveMedal.Size = new Size(96 /*0x60*/, 30);
    this.cmdSaveMedal.TabIndex = 161;
    this.cmdSaveMedal.Tag = (object) "1200";
    this.cmdSaveMedal.Text = "Save Current";
    this.cmdSaveMedal.UseVisualStyleBackColor = false;
    this.cmdSaveMedal.Click += new EventHandler(this.cmdSaveMedal_Click);
    this.cmdImportMedals.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.cmdImportMedals.ForeColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192 /*0xC0*/);
    this.cmdImportMedals.Location = new Point(288, 0);
    this.cmdImportMedals.Margin = new Padding(0);
    this.cmdImportMedals.Name = "cmdImportMedals";
    this.cmdImportMedals.Size = new Size(96 /*0x60*/, 30);
    this.cmdImportMedals.TabIndex = 162;
    this.cmdImportMedals.Tag = (object) "1200";
    this.cmdImportMedals.Text = "Import Medals";
    this.cmdImportMedals.UseVisualStyleBackColor = false;
    this.cmdImportMedals.Click += new EventHandler(this.cmdImportMedals_Click);
    this.cboConditions.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.cboConditions.ForeColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192 /*0xC0*/);
    this.cboConditions.FormattingEnabled = true;
    this.cboConditions.Location = new Point(631, 699);
    this.cboConditions.Margin = new Padding(3, 3, 3, 0);
    this.cboConditions.Name = "cboConditions";
    this.cboConditions.Size = new Size(533, 21);
    this.cboConditions.TabIndex = 167;
    this.pbMedalImage.BackgroundImageLayout = ImageLayout.Stretch;
    this.pbMedalImage.BorderStyle = BorderStyle.FixedSingle;
    this.pbMedalImage.Location = new Point(3, 562);
    this.pbMedalImage.Name = "pbMedalImage";
    this.pbMedalImage.Size = new Size(100, 30);
    this.pbMedalImage.SizeMode = PictureBoxSizeMode.StretchImage;
    this.pbMedalImage.TabIndex = 166;
    this.pbMedalImage.TabStop = false;
    this.panel1.BorderStyle = BorderStyle.FixedSingle;
    this.panel1.Controls.Add((Control) this.txtAbbreviation);
    this.panel1.Controls.Add((Control) this.label2);
    this.panel1.Controls.Add((Control) this.label1);
    this.panel1.Controls.Add((Control) this.txtPoints);
    this.panel1.Controls.Add((Control) this.chkMultipleAwards);
    this.panel1.Location = new Point(420, 562);
    this.panel1.Name = "panel1";
    this.panel1.Size = new Size(207, 159);
    this.panel1.TabIndex = 165;
    this.txtAbbreviation.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.txtAbbreviation.BorderStyle = BorderStyle.None;
    this.txtAbbreviation.ForeColor = Color.FromArgb(128 /*0x80*/, (int) byte.MaxValue, 128 /*0x80*/);
    this.txtAbbreviation.Location = new Point(143, 29);
    this.txtAbbreviation.Margin = new Padding(0, 8, 3, 3);
    this.txtAbbreviation.Name = "txtAbbreviation";
    this.txtAbbreviation.Size = new Size(49, 13);
    this.txtAbbreviation.TabIndex = 153;
    this.txtAbbreviation.Text = "VC";
    this.txtAbbreviation.TextAlign = HorizontalAlignment.Center;
    this.label2.AutoSize = true;
    this.label2.Location = new Point(3, 29);
    this.label2.Name = "label2";
    this.label2.Size = new Size(98, 13);
    this.label2.TabIndex = 152;
    this.label2.Text = "Medal Abbreviation";
    this.label1.AutoSize = true;
    this.label1.Location = new Point(3, 3);
    this.label1.Name = "label1";
    this.label1.Size = new Size(125, 13);
    this.label1.TabIndex = 151;
    this.label1.Text = "Promotion Score Modifier";
    this.txtPoints.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.txtPoints.BorderStyle = BorderStyle.None;
    this.txtPoints.ForeColor = Color.FromArgb(128 /*0x80*/, (int) byte.MaxValue, 128 /*0x80*/);
    this.txtPoints.Location = new Point(143, 3);
    this.txtPoints.Margin = new Padding(0, 8, 3, 3);
    this.txtPoints.Name = "txtPoints";
    this.txtPoints.Size = new Size(49, 13);
    this.txtPoints.TabIndex = 149;
    this.txtPoints.Text = "100";
    this.txtPoints.TextAlign = HorizontalAlignment.Center;
    this.chkMultipleAwards.CheckAlign = ContentAlignment.MiddleRight;
    this.chkMultipleAwards.Location = new Point(3, 53);
    this.chkMultipleAwards.Name = "chkMultipleAwards";
    this.chkMultipleAwards.Size = new Size(172, 20);
    this.chkMultipleAwards.TabIndex = 150;
    this.chkMultipleAwards.Text = "Allow Multiple Awards";
    this.chkMultipleAwards.UseVisualStyleBackColor = true;
    this.txtMedalName.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.txtMedalName.BorderStyle = BorderStyle.FixedSingle;
    this.txtMedalName.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.txtMedalName.ForeColor = Color.FromArgb(128 /*0x80*/, (int) byte.MaxValue, 128 /*0x80*/);
    this.txtMedalName.Location = new Point(106, 562);
    this.txtMedalName.Margin = new Padding(0, 8, 3, 3);
    this.txtMedalName.Multiline = true;
    this.txtMedalName.Name = "txtMedalName";
    this.txtMedalName.Size = new Size(309, 30);
    this.txtMedalName.TabIndex = 163;
    this.txtMedalName.Text = "Enter Medal Name Here";
    this.txtMedalName.TextAlign = HorizontalAlignment.Center;
    this.txtDescription.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.txtDescription.BorderStyle = BorderStyle.FixedSingle;
    this.txtDescription.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.txtDescription.ForeColor = Color.FromArgb(128 /*0x80*/, (int) byte.MaxValue, 128 /*0x80*/);
    this.txtDescription.Location = new Point(3, 597);
    this.txtDescription.Margin = new Padding(0, 8, 3, 3);
    this.txtDescription.Multiline = true;
    this.txtDescription.Name = "txtDescription";
    this.txtDescription.Size = new Size(412, 124);
    this.txtDescription.TabIndex = 164;
    this.txtDescription.Text = "Enter Medal Description Here";
    this.tabPage2.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.tabPage2.Controls.Add((Control) this.lstvConditions);
    this.tabPage2.Location = new Point(4, 22);
    this.tabPage2.Name = "tabPage2";
    this.tabPage2.Padding = new Padding(3);
    this.tabPage2.Size = new Size(1171, 757);
    this.tabPage2.TabIndex = 1;
    this.tabPage2.Text = "Medal Conditions";
    this.cmdExportMedals.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.cmdExportMedals.ForeColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192 /*0xC0*/);
    this.cmdExportMedals.Location = new Point(384, 0);
    this.cmdExportMedals.Margin = new Padding(0);
    this.cmdExportMedals.Name = "cmdExportMedals";
    this.cmdExportMedals.Size = new Size(96 /*0x60*/, 30);
    this.cmdExportMedals.TabIndex = 163;
    this.cmdExportMedals.Tag = (object) "1200";
    this.cmdExportMedals.Text = "Export Medals";
    this.cmdExportMedals.UseVisualStyleBackColor = false;
    this.cmdExportMedals.Click += new EventHandler(this.cmdExportMedals_Click);
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.FromArgb(0, 0, 64 /*0x40*/);
    this.ClientSize = new Size(1184, 811);
    this.Controls.Add((Control) this.tabMedals);
    this.Controls.Add((Control) this.cboRaces);
    this.ForeColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192 /*0xC0*/);
    this.FormBorderStyle = FormBorderStyle.FixedSingle;
    this.KeyPreview = true;
    this.Name = nameof (frmMedals);
    this.Text = "Medal Management";
    this.FormClosing += new FormClosingEventHandler(this.frmMedals_FormClosing);
    this.Load += new EventHandler(this.frmMedals_Load);
    this.KeyDown += new KeyEventHandler(this.frmMedals_KeyDown);
    this.tabMedals.ResumeLayout(false);
    this.tabCurrent.ResumeLayout(false);
    this.tabCurrent.PerformLayout();
    this.flowLayoutPanel1.ResumeLayout(false);
    ((ISupportInitialize) this.pbMedalImage).EndInit();
    this.panel1.ResumeLayout(false);
    this.panel1.PerformLayout();
    this.tabPage2.ResumeLayout(false);
    this.ResumeLayout(false);
  }
}
