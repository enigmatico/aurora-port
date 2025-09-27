// Decompiled with JetBrains decompiler
// Type: GClass42
// Assembly: Aurora, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAB8E3AD-3A24-426F-849E-98EC2E2DD9EB
// Assembly location: C:\Users\jinhoon.kim\Desktop\Aurora250Full\Dedot\aurora-deop.exe

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

#nullable disable
public class FCTRaceMedalRecord
{
    private GClass0 gclass0_0;
    public GameRace Race;
    public Image MedalImageLoaded;
    public int MedalPoints;
    public int MedalID;
    public bool AllowMultipleAward;
    public string MedalName;
    public string MedalDescription;
    public string MedalFileName;
    public string Abbreviation;

    public FCTRaceMedalRecord(GClass0 gclass0_1) => this.gclass0_0 = gclass0_1;

    public void method_0(ListBox listBox_0)
    {
        try
        {
            List<MedalCondition> list = this.gclass0_0.list_1.Where<GClass44>(gclass44_0 => gclass44_0.gclass42_0 == this)
                .Select<GClass44, MedalCondition>(gclass44_0 => gclass44_0.gclass43_0).ToList<MedalCondition>();
            listBox_0.DisplayMember = "Description";
            listBox_0.DataSource = list;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 366);
        }
    }
}