// Decompiled with JetBrains decompiler
// Type: GClass197
// Assembly: Aurora, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAB8E3AD-3A24-426F-849E-98EC2E2DD9EB
// Assembly location: C:\Users\jinhoon.kim\Desktop\Aurora250Full\Dedot\aurora-deop.exe

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;

#nullable disable
public class GClass197
{
   
  private sealed class Class1163
  {
    public GClass1 gclass1_0;

    public Class1163()
    {
      
    }

    internal bool method_0(GClass1 gclass1_1)
    {
      return gclass1_1.gclass1_0 == this.gclass1_0 && gclass1_1.genum12_0 == GEnum12.const_2;
    }
  }

  
  private sealed class Class1164
  {
    public GClass197 gclass197_0;
    public int int_0;

    public Class1164()
    {
      
    }

    internal bool method_0(GClass212 gclass212_0)
    {
      return gclass212_0.gclass200_0 == this.gclass197_0.gclass200_0 && gclass212_0.gclass197_0.int_4 == 0 && gclass212_0.gclass1_0.double_28 < (double) this.int_0;
    }

    internal bool method_1(GClass212 gclass212_0)
    {
      return gclass212_0.gclass197_0 == this.gclass197_0 && gclass212_0.gclass1_0.double_28 < (double) this.int_0;
    }

    internal bool method_2(GClass212 gclass212_0)
    {
      return (gclass212_0.gclass197_0 == this.gclass197_0 || gclass212_0.gclass197_0 == this.gclass197_0.gclass197_0) && gclass212_0.gclass1_0.double_28 < (double) this.int_0;
    }
  }

  
  private sealed class Class1165
  {
    public int int_0;

    public Class1165()
    {
      
    }

    internal bool method_0(GClass199 gclass199_0)
    {
      return gclass199_0.int_1 >= this.int_0;
    }
  }

  
  private sealed class Class1166
  {
    public GClass197 gclass197_0;
    public GClass21 gclass21_0;

    public Class1166()
    {
      
    }

    internal bool method_0(GClass1 gclass1_0)
    {
      return gclass1_0.genum12_0 == GEnum12.const_3 && gclass1_0.gclass197_0 == this.gclass197_0 && !gclass1_0.bool_2;
    }

    internal string method_1(GClass1 gclass1_0)
    {
      return gclass1_0.method_78(this.gclass21_0);
    }
  }

  
  private sealed class Class1167
  {
    public GClass197 gclass197_0;
    public GClass21 gclass21_0;

    public Class1167()
    {
      
    }

    internal bool method_0(GClass1 gclass1_0)
    {
      return gclass1_0.genum12_0 == GEnum12.const_5 && gclass1_0.gclass197_0 == this.gclass197_0;
    }

    internal string method_1(GClass1 gclass1_0)
    {
      return gclass1_0.method_78(this.gclass21_0);
    }
  }
  
  public GClass200 gclass200_0;
  public GClass197 gclass197_0;
  public GClass217 gclass217_0;
  public GClass0 gclass0_0;
  public GEnum30 genum30_0;
  public int int_0;
  public int int_1;
  public int int_2;
  public int int_3;
  public int int_4;
  public string string_0;
  public double double_0;
  public double double_1;
  public double double_2;
  public double double_3;
  public double double_4;
  public double double_5;
  public double double_6;
  public double double_7;
  public double double_8;
  public double double_9;
  public double double_10;
  public double double_11;
  public double double_12;
  public double double_13;
  public double double_14;
  public double double_15;
  public double double_16;
  public double double_17;
  public bool bool_0;
  public bool bool_1;
  public int int_5;
  public int int_6;
  public Decimal decimal_0;
  public Decimal decimal_1;
  public Decimal decimal_2;
  public Decimal decimal_3;

  public GClass197(GClass0 gclass0_1) => this.gclass0_0 = gclass0_1;

  public void method_0()
  {
    try
    {
      this.double_13 = Math.Sqrt(2.0 / this.double_2 - 1.0 / this.double_2);
      this.double_12 = this.double_13;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3441);
    }
  }

  public void method_1()
  {
    try
    {
      if (this.double_3 != 0.0 && this.double_3 != 180.0)
      {
        if (this.double_3 != 90.0 && this.double_3 != 270.0)
        {
          double num = 360.0 - this.double_3 + 90.0;
          if (num < 0.0)
            num += 360.0;
          if (num >= 360.0)
            num -= 360.0;
          this.double_16 = this.double_2 * this.double_9 / Math.Sqrt(Math.Pow(this.double_9 * Math.Cos(num * Math.PI / 180.0), 2.0) + Math.Pow(this.double_2 * Math.Sin(num * Math.PI / 180.0), 2.0));
        }
        else
          this.double_16 = this.double_2;
      }
      else
        this.double_16 = this.double_9;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3439);
    }
  }

  public void method_2()
  {
    try
    {
      this.double_12 = Math.Sqrt(2.0 / this.double_17 - 1.0 / this.double_2);
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3438);
    }
  }

  public void method_3(
    GClass217 gclass217_1,
    double double_18,
    double double_19,
    int int_7,
    double double_20,
    double double_21)
  {
    try
    {
      this.gclass217_0 = gclass217_1;
      this.int_4 = int_7;
      this.double_2 = double_18;
      this.double_7 = double_20;
      this.double_8 = double_21;
      this.double_4 = this.gclass217_0.double_0;
      this.double_10 = this.double_2 * (1.0 - this.double_7);
      this.double_11 = this.double_2 * (1.0 + this.double_7);
      this.double_9 = this.double_2 * Math.Sqrt(1.0 - this.double_7 * this.double_7);
      this.method_0();
      if (double_19 < 0.0 || double_19 > 360.0)
        double_19 = 0.0;
      this.double_3 = double_19;
      if (this.int_4 > 0)
      {
        this.gclass197_0 = this.gclass0_0.dictionary_10.Values.FirstOrDefault<GClass197>((Func<GClass197, bool>) (gclass197_1 => gclass197_1.gclass200_0 == this.gclass200_0 && gclass197_1.int_3 == this.int_4));
        this.double_5 = Math.Pow(Math.Pow(this.double_2, 3.0) / (this.gclass217_0.double_1 + this.gclass197_0.gclass217_0.double_1), 0.5);
      }
      foreach (GClass1 gclass1 in this.gclass0_0.dictionary_11.Values.Where<GClass1>((Func<GClass1, bool>) (gclass1_0 => gclass1_0.gclass197_0 == this)).ToList<GClass1>())
        gclass1.method_8(false);
      this.gclass0_0.method_414(60.0, this.gclass200_0, (GClass1) null, true);
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2933);
    }
  }

  public void method_4()
  {
    try
    {
      int num1 = 1;
      foreach (GClass1 gclass1_1 in this.gclass0_0.dictionary_11.Values.Where<GClass1>((Func<GClass1, bool>) (gclass1_0 => gclass1_0.gclass197_0 == this && gclass1_0.genum12_0 == GEnum12.const_1)).OrderBy<GClass1, double>((Func<GClass1, double>) (gclass1_0 => gclass1_0.double_2)).ToList<GClass1>())
      {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        GClass197.Class1163 class1163 = new GClass197.Class1163()
        {
          gclass1_0 = gclass1_1
        };
        // ISSUE: reference to a compiler-generated field
        class1163.gclass1_0.int_3 = num1;
        int num2 = 1;
        // ISSUE: reference to a compiler-generated method
        foreach (GClass1 gclass1_2 in this.gclass0_0.dictionary_11.Values.Where<GClass1>(new Func<GClass1, bool>(class1163.method_0)).OrderBy<GClass1, double>((Func<GClass1, double>) (gclass1_0 => gclass1_0.double_2)).ToList<GClass1>())
        {
          // ISSUE: reference to a compiler-generated field
          gclass1_2.int_3 = class1163.gclass1_0.int_3;
          gclass1_2.int_4 = num2;
          ++num2;
        }
        ++num1;
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2934);
    }
  }

  public void method_5(Graphics graphics_0, GClass222 gclass222_0, GClass202 gclass202_0)
  {
    try
    {
      if (gclass202_0.gclass21_0.chkStarOrbits == CheckState.Unchecked || this.int_4 == 0)
        return;
      if (this.gclass0_0.int_85 == 0)
      {
        GClass221 gclass221_1 = new GClass221();
        double num = this.double_2 * GClass226.double_14 / gclass202_0.double_2;
        if (num < (double) GClass226.int_61)
          return;
        GClass221 gclass221_2 = this.gclass197_0.method_20(gclass202_0);
        if (gclass221_2.double_0 < 0.0 || gclass221_2.double_0 > this.gclass0_0.double_0 || gclass221_2.double_1 < 0.0 || gclass221_2.double_1 > this.gclass0_0.double_1)
          return;
        double x = gclass221_2.double_0 - num;
        double y = gclass221_2.double_1 - num;
        Pen pen = new Pen(GClass226.color_5);
        graphics_0.DrawEllipse(pen, (int) x, (int) y, (int) (num * 2.0), (int) (num * 2.0));
        pen.Dispose();
      }
      else
      {
        GClass221 gclass221 = this.gclass197_0.method_20(gclass202_0);
        if (gclass221.double_0 < 0.0 || gclass221.double_0 > this.gclass0_0.double_0 || gclass221.double_1 < 0.0 || gclass221.double_1 > this.gclass0_0.double_1)
          return;
        float width = (float) (this.double_2 * GClass226.double_14 * 2.0 / gclass202_0.double_2);
        if ((double) width < (double) GClass226.int_61)
          return;
        float height = (float) (this.double_9 * GClass226.double_14 * 2.0 / gclass202_0.double_2);
        float num = (float) (this.double_10 * GClass226.double_14 / gclass202_0.double_2);
        float x = (float) gclass221.double_0 - num;
        float y = (float) (gclass221.double_1 - (double) height / 2.0);
        Matrix matrix = new Matrix();
        matrix.RotateAt((float) this.double_8, new PointF((float) gclass221.double_0, (float) gclass221.double_1));
        graphics_0.Transform = matrix;
        RectangleF rect = new RectangleF(x, y, width, height);
        Pen pen = new Pen(GClass226.color_5);
        graphics_0.DrawEllipse(pen, rect);
        graphics_0.ResetTransform();
        pen.Dispose();
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2935);
    }
  }

  public bool method_6(int int_7)
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    GClass197.Class1164 class1164 = new GClass197.Class1164();
    // ISSUE: reference to a compiler-generated field
    class1164.gclass197_0 = this;
    // ISSUE: reference to a compiler-generated field
    class1164.int_0 = int_7;
    try
    {
      if (this.int_3 == 1)
        return true;
      // ISSUE: reference to a compiler-generated method
      int num = this.gclass0_0.dictionary_14.Values.Where<GClass212>(new Func<GClass212, bool>(class1164.method_0)).Count<GClass212>();
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated method
      return this.int_4 == 1 ? this.double_11 < (double) class1164.int_0 || num > 0 && this.gclass0_0.dictionary_14.Values.Where<GClass212>(new Func<GClass212, bool>(class1164.method_1)).Count<GClass212>() > 0 : this.gclass197_0.double_11 < (double) class1164.int_0 || num > 0 && this.gclass0_0.dictionary_14.Values.Where<GClass212>(new Func<GClass212, bool>(class1164.method_2)).Count<GClass212>() > 0;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2936);
      return false;
    }
  }

  public void method_7(double double_18)
  {
    try
    {
      if (this.genum30_0 == GEnum30.const_0)
        return;
      double num = this.double_4 / 100.0 * double_18;
      if (this.genum30_0 == GEnum30.const_1)
        this.double_4 += num;
      else if (this.genum30_0 == GEnum30.const_2)
        this.double_4 += num * 2.0;
      else if (this.genum30_0 == GEnum30.const_3)
        this.double_4 += num * 3.0;
      if (this.genum30_0 == GEnum30.const_4)
        this.double_4 -= num;
      else if (this.genum30_0 == GEnum30.const_5)
        this.double_4 -= num * 2.0;
      else if (this.genum30_0 == GEnum30.const_6)
        this.double_4 -= num * 3.0;
      this.method_8();
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2937);
    }
  }

  public void method_8()
  {
    try
    {
      foreach (GClass1 gclass1 in this.gclass0_0.dictionary_11.Values.Where<GClass1>((Func<GClass1, bool>) (gclass1_0 => gclass1_0.gclass197_0 == this && gclass1_0.genum12_0 != GEnum12.const_2)).ToList<GClass1>())
      {
        gclass1.double_3 = (double) byte.MaxValue / Math.Pow(gclass1.double_37 / Math.Pow(gclass1.gclass197_0.double_4, 0.5), 0.5);
        if (gclass1.double_3 < 4.0)
          gclass1.double_3 = 4.0;
        gclass1.method_27();
        gclass1.method_35();
        gclass1.method_32();
      }
      foreach (GClass1 gclass1 in this.gclass0_0.dictionary_11.Values.Where<GClass1>((Func<GClass1, bool>) (gclass1_0 => gclass1_0.gclass197_0 == this && gclass1_0.genum12_0 == GEnum12.const_2)).ToList<GClass1>())
      {
        gclass1.double_3 = gclass1.gclass1_0.double_3;
        gclass1.method_27();
        gclass1.method_35();
        gclass1.method_32();
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2938);
    }
  }

  public void method_9()
  {
    try
    {
      if (this.double_2 == 0.0)
        this.double_2 = 0.1;
      this.double_5 = Math.Pow(Math.Pow(this.double_2, 3.0) / (this.gclass217_0.double_1 + this.gclass197_0.gclass217_0.double_1), 0.5);
      this.double_3 = (double) GClass226.smethod_13(360);
      GClass221 gclass221 = this.gclass0_0.method_592(this.gclass197_0.double_0, this.gclass197_0.double_1, this.double_2 * GClass226.double_14, this.double_3);
      this.double_0 = gclass221.double_0;
      this.double_1 = gclass221.double_1;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2939);
    }
  }

  public void method_10(double double_18)
  {
    try
    {
      this.double_5 = Math.Pow(Math.Pow(this.double_2, 3.0) / (this.gclass217_0.double_1 + this.gclass197_0.gclass217_0.double_1), 0.5);
      GClass221 gclass221 = this.gclass0_0.method_592(this.gclass197_0.double_0, this.gclass197_0.double_1, this.double_2 * GClass226.double_14, double_18);
      this.double_0 = gclass221.double_0;
      this.double_1 = gclass221.double_1;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2940);
    }
  }

  public void method_11()
  {
    try
    {
      if (this.gclass217_0.genum3_0 > GEnum3.const_11)
        return;
      if (!this.gclass0_0.dictionary_57.ContainsKey(this.gclass217_0.genum3_0))
      {
        int num1 = (int) MessageBox.Show($"Error: Star Type Age Range ID {GClass226.smethod_82((Enum) this.gclass217_0.genum3_0)} not found");
      }
      else
      {
        int key = 1;
        foreach (double num2 in this.gclass0_0.dictionary_57[this.gclass217_0.genum3_0].dictionary_1.OrderBy<KeyValuePair<int, double>, int>((Func<KeyValuePair<int, double>, int>) (keyValuePair_0 => keyValuePair_0.Key)).ToDictionary<KeyValuePair<int, double>, int, double>((Func<KeyValuePair<int, double>, int>) (keyValuePair_0 => keyValuePair_0.Key), (Func<KeyValuePair<int, double>, double>) (keyValuePair_0 => keyValuePair_0.Value)).Values)
        {
          if (num2 < this.gclass200_0.double_0)
            ++key;
          else
            break;
        }
        if (key > 10)
        {
          int num3 = (int) MessageBox.Show("Error: Luminosity Key Count is " + key.ToString());
          key = 10;
        }
        this.double_4 *= this.gclass0_0.dictionary_57[this.gclass217_0.genum3_0].dictionary_0[key];
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2941);
    }
  }

  public void method_12()
  {
    try
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      GClass197.Class1165 class1165 = new GClass197.Class1165();
      // ISSUE: reference to a compiler-generated field
      class1165.int_0 = 0;
      switch (this.gclass217_0.genum3_0)
      {
        case GEnum3.const_0:
          this.gclass200_0.double_0 = 0.1;
          break;
        case GEnum3.const_12:
          this.gclass200_0.double_0 = this.gclass0_0.dictionary_57[this.gclass0_0.dictionary_25.Values.Where<GClass217>((Func<GClass217, bool>) (gclass217_1 => gclass217_1.int_4 == 5 && gclass217_1.double_1 <= this.gclass217_0.double_1)).OrderByDescending<GClass217, double>((Func<GClass217, double>) (gclass217_0 => gclass217_0.double_1)).FirstOrDefault<GClass217>().genum3_0].double_0 * 1.1;
          break;
        case GEnum3.const_13:
          this.gclass200_0.double_0 = this.gclass0_0.dictionary_57[this.gclass0_0.dictionary_25.Values.Where<GClass217>((Func<GClass217, bool>) (gclass217_1 => gclass217_1.int_4 == 5 && gclass217_1.double_1 <= this.gclass217_0.double_1)).OrderByDescending<GClass217, double>((Func<GClass217, double>) (gclass217_0 => gclass217_0.double_1)).FirstOrDefault<GClass217>().genum3_0].double_0 * 1.2;
          break;
        case GEnum3.const_14:
          this.gclass200_0.double_0 = 0.05;
          break;
        default:
          // ISSUE: reference to a compiler-generated field
          class1165.int_0 = GClass226.smethod_13(10);
          // ISSUE: reference to a compiler-generated field
          this.gclass200_0.double_0 = this.gclass0_0.dictionary_57[this.gclass217_0.genum3_0].dictionary_1[class1165.int_0];
          // ISSUE: reference to a compiler-generated field
          this.double_4 *= this.gclass0_0.dictionary_57[this.gclass217_0.genum3_0].dictionary_0[class1165.int_0];
          break;
      }
      // ISSUE: reference to a compiler-generated field
      class1165.int_0 = GClass226.smethod_13(10) + GClass226.smethod_13(10) + (int) Math.Round(this.gclass200_0.double_0);
      // ISSUE: reference to a compiler-generated method
      this.gclass200_0.int_2 = this.gclass0_0.dictionary_58.Values.Where<GClass199>(new Func<GClass199, bool>(class1165.method_0)).OrderBy<GClass199, int>((Func<GClass199, int>) (gclass199_0 => gclass199_0.int_1)).FirstOrDefault<GClass199>().int_2;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2942);
    }
  }

  public void method_13(double double_18)
  {
    try
    {
      this.method_1();
      double_18 -= 90.0;
      if (double_18 < 0.0)
        double_18 += 360.0;
      if (this.double_7 == 0.0)
      {
        double num = double_18 * (Math.PI / 180.0);
        this.double_0 = this.gclass197_0.double_0 + this.double_2 * GClass226.double_14 * Math.Cos(num);
        this.double_1 = this.gclass197_0.double_1 + this.double_2 * GClass226.double_14 * Math.Sin(num);
      }
      else if (this.double_8 == 0.0)
      {
        double num1 = double_18 * (Math.PI / 180.0);
        double num2 = this.gclass197_0.double_0 + (this.double_2 - this.double_10) * GClass226.double_14;
        double double1 = this.gclass197_0.double_1;
        this.double_0 = num2 + this.double_16 * GClass226.double_14 * Math.Cos(num1);
        this.double_1 = double1 + this.double_16 * GClass226.double_14 * Math.Sin(num1);
      }
      else
      {
        this.method_14();
        double_18 += this.double_8;
        if (double_18 >= 360.0)
          double_18 -= 360.0;
        double num = double_18 * (Math.PI / 180.0);
        this.double_0 = this.double_14 + this.double_16 * GClass226.double_14 * Math.Cos(num);
        this.double_1 = this.double_15 + this.double_16 * GClass226.double_14 * Math.Sin(num);
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2943);
    }
  }

  public void method_14()
  {
    try
    {
      double double8 = this.double_8;
      if (double8 < 0.0)
        double8 += 360.0;
      double num1 = double8 * (Math.PI / 180.0);
      double num2 = (this.double_11 - this.double_10) / 2.0;
      this.double_14 = this.gclass197_0.double_0 + num2 * GClass226.double_14 * Math.Cos(num1);
      this.double_15 = this.gclass197_0.double_1 + num2 * GClass226.double_14 * Math.Sin(num1);
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2943);
    }
  }

  public List<GClass1> method_15()
  {
    try
    {
      return this.gclass0_0.dictionary_11.Values.Where<GClass1>((Func<GClass1, bool>) (gclass1_0 => gclass1_0.genum12_0 == GEnum12.const_1 && gclass1_0.gclass197_0 == this && !gclass1_0.bool_2)).ToList<GClass1>().OrderBy<GClass1, int>((Func<GClass1, int>) (gclass1_0 => gclass1_0.int_3)).ToList<GClass1>();
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2944);
      return new List<GClass1>();
    }
  }

  public List<GClass1> method_16(GClass21 gclass21_0)
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    GClass197.Class1166 class1166 = new GClass197.Class1166();
    // ISSUE: reference to a compiler-generated field
    class1166.gclass197_0 = this;
    // ISSUE: reference to a compiler-generated field
    class1166.gclass21_0 = gclass21_0;
    try
    {
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      return this.gclass0_0.dictionary_11.Values.Where<GClass1>(new Func<GClass1, bool>(class1166.method_0)).ToList<GClass1>().OrderBy<GClass1, string>(new Func<GClass1, string>(class1166.method_1)).ToList<GClass1>();
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2945);
      return new List<GClass1>();
    }
  }

  public List<GClass1> method_17(GClass21 gclass21_0)
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    GClass197.Class1167 class1167 = new GClass197.Class1167();
    // ISSUE: reference to a compiler-generated field
    class1167.gclass197_0 = this;
    // ISSUE: reference to a compiler-generated field
    class1167.gclass21_0 = gclass21_0;
    try
    {
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      return this.gclass0_0.dictionary_11.Values.Where<GClass1>(new Func<GClass1, bool>(class1167.method_0)).ToList<GClass1>().OrderBy<GClass1, string>(new Func<GClass1, string>(class1167.method_1)).ToList<GClass1>();
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2946);
      return new List<GClass1>();
    }
  }

  public string method_18(GClass21 gclass21_0)
  {
    try
    {
      if (!gclass21_0.dictionary_0.ContainsKey(this.int_1))
        return "System Not Found";
      return this.gclass200_0.int_3 == 1 ? gclass21_0.dictionary_0[this.int_1].Name : $"{gclass21_0.dictionary_0[this.int_1].Name}-{this.method_19()}";
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2947);
      return "";
    }
  }

  public string method_19()
  {
    try
    {
      return ((char) (this.int_3 + 64 /*0x40*/)).ToString();
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2948);
      return "";
    }
  }

  public GClass221 method_20(GClass202 gclass202_0)
  {
    try
    {
      return new GClass221()
      {
        double_0 = (this.double_0 + gclass202_0.double_3) / gclass202_0.double_2 + this.gclass0_0.double_4,
        double_1 = (this.double_1 + gclass202_0.double_4) / gclass202_0.double_2 + this.gclass0_0.double_5
      };
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2949);
      return new GClass221(0.0, 0.0);
    }
  }

  public void method_21(
    Graphics graphics_0,
    Font font_0,
    GClass222 gclass222_0,
    GClass202 gclass202_0)
  {
    try
    {
      int int6 = this.gclass217_0.int_6;
      int int7 = this.gclass217_0.int_7;
      int int8 = this.gclass217_0.int_8;
      int green = int7;
      int blue = int8;
      SolidBrush solidBrush = new SolidBrush(Color.FromArgb(int6, green, blue));
      GClass221 gclass221 = new GClass221();
      string str = $"{this.method_18(gclass202_0.gclass21_0)} {this.gclass217_0.StellarDescription}";
      int num1 = GClass226.int_61;
      int num2 = (int) (GClass226.double_31 * this.gclass217_0.double_2 / gclass202_0.double_2);
      if (num2 > num1)
        num1 = num2;
      double x = gclass222_0.double_2 - (double) num1 / 2.0;
      double y = gclass222_0.double_3 - (double) num1 / 2.0;
      graphics_0.FillEllipse((Brush) solidBrush, (float) x, (float) y, (float) num1, (float) num1);
      if (gclass202_0.gclass21_0.chkStarNames == CheckState.Unchecked)
        return;
      solidBrush.Color = Color.LimeGreen;
      double num3 = (double) graphics_0.MeasureString(str, font_0).Width / 2.0;
      gclass221.double_0 = gclass222_0.double_2 - num3;
      gclass221.double_1 = gclass222_0.double_3 + (double) GClass226.int_61;
      graphics_0.DrawString(str, font_0, (Brush) solidBrush, (float) gclass221.double_0, (float) gclass221.double_1);
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2950);
    }
  }
}
