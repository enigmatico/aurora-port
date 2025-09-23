// Decompiled with JetBrains decompiler
// Type: GClass120
// Assembly: Aurora, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAB8E3AD-3A24-426F-849E-98EC2E2DD9EB
// Assembly location: C:\Users\jinhoon.kim\Desktop\Aurora250Full\Dedot\aurora-deop.exe

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

#nullable disable
public class GClass120
{
  private sealed class Class1072
  {
    public GClass21 gclass21_0;
    public GClass120 gclass120_0;
    internal bool method_0(GClass85 gclass85_0)
    {
      return gclass85_0.gclass21_0 == this.gclass21_0;
    }

    internal bool method_1(GClass139 gclass139_0)
    {
      return gclass139_0.gclass133_0.genum123_0 == GEnum123.const_18 && gclass139_0.int_2 == this.gclass120_0.int_0;
    }
  }
  
  private sealed class Class1073
  {
    public GClass202 gclass202_0;

    internal bool method_0(GClass120 gclass120_0)
    {
      return gclass120_0.gclass200_0 == this.gclass202_0.gclass200_0 && gclass120_0.dictionary_0.ContainsKey(this.gclass202_0.gclass21_0.RaceID);
    }

    internal bool method_1(GClass120 gclass120_0)
    {
      return gclass120_0.dictionary_0[this.gclass202_0.gclass21_0.RaceID].int_2 == 1;
    }
  }
  
  public Dictionary<int, GClass203> dictionary_0 = new Dictionary<int, GClass203>();
  public GClass200 gclass200_0;
  public GClass120 gclass120_0;
  public int int_0;
  public int int_1;
  public int int_2;
  public int int_3;
  public int int_4;
  public int int_5;
  public double double_0;
  public double double_1;
  public double double_2;
  public double double_3;
  public bool bool_0;
  private GClass0 gclass0_0;

  public GClass120(GClass0 gclass0_1) => this.gclass0_0 = gclass0_1;

  public bool method_0(GClass21 gclass21_0)
  {
    try
    {
      return this.dictionary_0.ContainsKey(gclass21_0.RaceID) && this.dictionary_0[gclass21_0.RaceID].int_1 == 1;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 1958);
      return false;
    }
  }

  public bool method_1(GClass21 gclass21_0)
  {
    try
    {
      return this.dictionary_0.ContainsKey(gclass21_0.RaceID) && this.dictionary_0[gclass21_0.RaceID].int_2 == 1;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 1959);
      return false;
    }
  }

  public bool method_2(GClass21 gclass21_0)
  {
    try
    {
      return this.dictionary_0.ContainsKey(gclass21_0.RaceID) && this.dictionary_0[gclass21_0.RaceID].int_2 == 1 && this.dictionary_0[gclass21_0.RaceID].int_1 == 0;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 1960);
      return false;
    }
  }

  public bool method_3(GClass21 gclass21_0)
  {
    try
    {
      return this.dictionary_0.ContainsKey(gclass21_0.RaceID) && this.dictionary_0[gclass21_0.RaceID].int_2 == 1 && this.int_2 == 0 && !this.method_5(gclass21_0);
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 1961);
      return false;
    }
  }

  public bool method_4(GClass21 gclass21_0)
  {
    try
    {
      return this.dictionary_0.ContainsKey(gclass21_0.RaceID) && this.dictionary_0[gclass21_0.RaceID].int_1 == 1 && this.int_2 == 0 && !this.method_5(gclass21_0);
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 1962);
      return false;
    }
  }

  public bool method_5(GClass21 gclass21_0)
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    GClass120.Class1072 class1072 = new GClass120.Class1072();
    // ISSUE: reference to a compiler-generated field
    class1072.gclass21_0 = gclass21_0;
    // ISSUE: reference to a compiler-generated field
    class1072.gclass120_0 = this;
    try
    {
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      return this.gclass0_0.dictionary_1.Values.Where<GClass85>(new Func<GClass85, bool>(class1072.method_0)).SelectMany<GClass85, GClass139>((Func<GClass85, IEnumerable<GClass139>>) (gclass85_0 => (IEnumerable<GClass139>) gclass85_0.dictionary_0.Values)).FirstOrDefault<GClass139>(new Func<GClass139, bool>(class1072.method_1)) != null;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 1963);
      return false;
    }
  }

  public void method_6(
    Graphics graphics_0,
    Font font_0,
    GClass222 gclass222_0,
    GClass202 gclass202_0)
  {
    try
    {
      if (gclass202_0.gclass21_0.chkWP == CheckState.Unchecked)
        return;
      SolidBrush solidBrush = new SolidBrush(Color.Orange);
      string str = this.method_7(gclass202_0);
      double x1 = gclass222_0.double_2 - (double) (GClass226.int_61 / 2);
      double y1 = gclass222_0.double_3 - (double) (GClass226.int_61 / 2);
      graphics_0.FillEllipse((Brush) solidBrush, (float) x1, (float) y1, (float) GClass226.int_61, (float) GClass226.int_61);
      if (this.int_2 > 0)
      {
        double x2 = gclass222_0.double_2 - (double) (GClass226.int_64 / 2);
        double y2 = gclass222_0.double_3 - (double) (GClass226.int_64 / 2);
        if (this.int_3 == gclass202_0.gclass21_0.RaceID)
        {
          Pen pen = new Pen(Color.Orange);
          graphics_0.DrawRectangle(pen, (float) x2, (float) y2, (float) GClass226.int_64, (float) GClass226.int_64);
        }
        else
        {
          Pen pen = new Pen(Color.Red);
          graphics_0.DrawRectangle(pen, (float) x2, (float) y2, (float) GClass226.int_64, (float) GClass226.int_64);
        }
      }
      GClass221 gclass221 = new GClass221();
      double num = (double) graphics_0.MeasureString(str, font_0).Width / 2.0;
      gclass221.double_0 = gclass222_0.double_2 - num;
      gclass221.double_1 = gclass222_0.double_3 + (double) (GClass226.int_61 + 2);
      graphics_0.DrawString(str, font_0, (Brush) solidBrush, (float) gclass221.double_0, (float) gclass221.double_1);
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 1964);
    }
  }

  public string method_7(GClass202 gclass202_0)
  {
    try
    {
      string str1 = $"JP{this.method_9(gclass202_0).ToString()}: ";
      string str2 = "Unex";
      return this.dictionary_0[gclass202_0.gclass21_0.RaceID].int_1 == 1 && gclass202_0.gclass21_0.dictionary_0.ContainsKey(this.gclass120_0.gclass200_0.int_0) ? str1 + gclass202_0.gclass21_0.dictionary_0[this.gclass120_0.gclass200_0.int_0].Name : str1 + str2;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 1965);
      return "";
    }
  }

  public string method_8(GClass202 gclass202_0)
  {
    try
    {
      string str1 = $"JP{this.method_9(gclass202_0).ToString()} (";
      string str2 = "Unex)";
      return this.dictionary_0[gclass202_0.gclass21_0.RaceID].int_1 == 1 && gclass202_0.gclass21_0.dictionary_0.ContainsKey(this.gclass120_0.gclass200_0.int_0) ? $"{str1}{gclass202_0.gclass21_0.dictionary_0[this.gclass120_0.gclass200_0.int_0].Name})" : str1 + str2;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 1966);
      return "";
    }
  }

  public int method_9(GClass202 gclass202_0)
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    GClass120.Class1073 class1073 = new GClass120.Class1073();
    // ISSUE: reference to a compiler-generated field
    class1073.gclass202_0 = gclass202_0;
    try
    {
      int num = 1;
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      foreach (GClass120 gclass120 in this.gclass0_0.dictionary_12.Values.Where<GClass120>(new Func<GClass120, bool>(class1073.method_0)).Where<GClass120>(new Func<GClass120, bool>(class1073.method_1)).OrderBy<GClass120, double>((Func<GClass120, double>) (gclass120_0 => gclass120_0.double_0)).ToList<GClass120>())
      {
        if (gclass120 == this)
          return num;
        ++num;
      }
      return 0;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 1967);
      return 0;
    }
  }

  public GClass221 method_10(GClass21 gclass21_0)
  {
    try
    {
      return this.gclass120_0 != null && this.dictionary_0.ContainsKey(gclass21_0.RaceID) && this.dictionary_0[gclass21_0.RaceID].int_1 == 1 ? new GClass221(this.gclass120_0.double_1, this.gclass120_0.double_2) : (GClass221) null;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 1968);
      return (GClass221) null;
    }
  }
}
