// Decompiled with JetBrains decompiler
// Type: GClass62
// Assembly: Aurora, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAB8E3AD-3A24-426F-849E-98EC2E2DD9EB
// Assembly location: C:\Users\jinhoon.kim\Desktop\Aurora250Full\Dedot\aurora-deop.exe

using Aurora;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

#nullable disable
public class GClass62
{
  public Dictionary<int, GClass202> dictionary_0 = new Dictionary<int, GClass202>();
  private GClass0 gclass0_0;
  public GClass21 gclass21_0;
  public GClass146 gclass146_0;
  public GClass55 gclass55_0;
  public Color color_0;
  public int int_0;
  public int int_1;
  public bool bool_0;

  public string SectorName { get; set; }

  public GClass62(GClass0 gclass0_1) => this.gclass0_0 = gclass0_1;

  public void method_0(ListView listView_0)
  {
    try
    {
      listView_0.Items.Clear();
      int num = this.gclass21_0.dictionary_0.Values.Count<GClass202>((Func<GClass202, bool>) (gclass202_0 => gclass202_0.gclass62_0 == this));
      this.method_1();
      this.method_3();
      this.gclass0_0.method_601(listView_0, "Sector Headquarters", this.gclass146_0.PopName, (string) null);
      this.gclass0_0.method_601(listView_0, "Command Range", this.method_2().ToString(), (string) null);
      this.gclass0_0.method_601(listView_0, "Admin Rank Required", this.int_1.ToString(), (string) null);
      this.gclass0_0.method_594(listView_0, "");
      this.gclass0_0.method_601(listView_0, "Systems in Sector", num.ToString(), (string) null);
      this.gclass0_0.method_601(listView_0, "Systems in Range", this.dictionary_0.Count.ToString(), (string) null);
      this.gclass0_0.method_594(listView_0, "");
      if (this.gclass55_0 == null)
      {
        this.gclass0_0.method_594(listView_0, "No Governor Assigned");
      }
      else
      {
        this.gclass0_0.method_601(listView_0, "Sector Governor", this.gclass55_0.string_0, (string) null);
        this.gclass55_0.method_30(listView_0, false);
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 415);
    }
  }

  public void method_1()
  {
    try
    {
      if (this.gclass146_0 == null)
        this.dictionary_0.Clear();
      else
        this.dictionary_0 = this.gclass0_0.method_32(this.gclass21_0, this.gclass146_0.gclass202_0, this.method_2());
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 416);
    }
  }

  public int method_2()
  {
    try
    {
      return this.gclass146_0 == null ? 0 : this.gclass0_0.method_589((Decimal) (int) this.gclass146_0.method_62(AuroraProductionCategory.SectorCommand));
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 417);
      return 0;
    }
  }

  public void method_3()
  {
    try
    {
      List<GClass146> list = this.gclass0_0.dictionary_22.Values.Where<GClass146>((Func<GClass146, bool>) (gclass146_1 => gclass146_1.gclass202_0.gclass62_0 == this)).ToList<GClass146>();
      int num = 1;
      foreach (GClass146 gclass146 in list)
      {
        gclass146.method_152();
        if (gclass146.int_17 > num)
          num = gclass146.int_17;
      }
      this.int_1 = num + 1;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 418);
    }
  }
}
