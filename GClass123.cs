// Decompiled with JetBrains decompiler
// Type: GClass123
// Assembly: Aurora, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAB8E3AD-3A24-426F-849E-98EC2E2DD9EB
// Assembly location: C:\Users\jinhoon.kim\Desktop\Aurora250Full\Dedot\aurora-deop.exe

using Aurora;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

#nullable disable
public class GClass123
{
  public Decimal decimal_0;
  public Decimal decimal_1;
  public Decimal decimal_2;
  public Decimal decimal_3;
  public Decimal decimal_4;
  public Decimal decimal_5;
  public Decimal decimal_6;
  public Decimal decimal_7;
  public Decimal decimal_8;
  public Decimal decimal_9;
  public Decimal decimal_10;
  private GClass0 gclass0_0;

  public GClass123(GClass0 gclass0_1) => this.gclass0_0 = gclass0_1;

  public int method_0(GClass123 gclass123_0)
  {
    try
    {
      Decimal d = 1000000M;
      if (gclass123_0.decimal_0 > 0M)
      {
        Decimal num = this.decimal_0 / gclass123_0.decimal_0;
        if (num < d)
          d = num;
      }
      if (gclass123_0.decimal_1 > 0M)
      {
        Decimal num = this.decimal_1 / gclass123_0.decimal_1;
        if (num < d)
          d = num;
      }
      if (gclass123_0.decimal_2 > 0M)
      {
        Decimal num = this.decimal_2 / gclass123_0.decimal_2;
        if (num < d)
          d = num;
      }
      if (gclass123_0.decimal_3 > 0M)
      {
        Decimal num = this.decimal_3 / gclass123_0.decimal_3;
        if (num < d)
          d = num;
      }
      if (gclass123_0.decimal_4 > 0M)
      {
        Decimal num = this.decimal_4 / gclass123_0.decimal_4;
        if (num < d)
          d = num;
      }
      if (gclass123_0.decimal_5 > 0M)
      {
        Decimal num = this.decimal_5 / gclass123_0.decimal_5;
        if (num < d)
          d = num;
      }
      if (gclass123_0.decimal_6 > 0M)
      {
        Decimal num = this.decimal_6 / gclass123_0.decimal_6;
        if (num < d)
          d = num;
      }
      if (gclass123_0.decimal_7 > 0M)
      {
        Decimal num = this.decimal_7 / gclass123_0.decimal_7;
        if (num < d)
          d = num;
      }
      if (gclass123_0.decimal_8 > 0M)
      {
        Decimal num = this.decimal_8 / gclass123_0.decimal_8;
        if (num < d)
          d = num;
      }
      if (gclass123_0.decimal_9 > 0M)
      {
        Decimal num = this.decimal_9 / gclass123_0.decimal_9;
        if (num < d)
          d = num;
      }
      if (gclass123_0.decimal_10 > 0M)
      {
        Decimal num = this.decimal_10 / gclass123_0.decimal_10;
        if (num < d)
          d = num;
      }
      return (int) Math.Floor(d);
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 1981);
      return 0;
    }
  }

  public bool method_1()
  {
    try
    {
      return this.decimal_0 > 0M || this.decimal_1 > 0M || this.decimal_2 > 0M || this.decimal_3 > 0M || this.decimal_4 > 0M || this.decimal_5 > 0M || this.decimal_6 > 0M || this.decimal_7 > 0M || this.decimal_8 > 0M || this.decimal_9 > 0M || this.decimal_10 > 0M;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 1982);
      return false;
    }
  }

  public bool method_2()
  {
    try
    {
      return this.decimal_0 > 0M || this.decimal_0 < 0M || this.decimal_1 > 0M || this.decimal_1 < 0M || this.decimal_2 > 0M || this.decimal_2 < 0M || this.decimal_3 > 0M || this.decimal_3 < 0M || this.decimal_4 > 0M || this.decimal_4 < 0M || this.decimal_5 > 0M || this.decimal_5 < 0M || this.decimal_6 > 0M || this.decimal_6 < 0M || this.decimal_7 > 0M || this.decimal_7 < 0M || this.decimal_8 > 0M || this.decimal_8 < 0M || this.decimal_9 > 0M || this.decimal_9 < 0M || this.decimal_10 > 0M || this.decimal_10 < 0M;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 1983);
      return false;
    }
  }

  public void method_3(int int_0)
  {
    try
    {
      this.decimal_0 = (Decimal) int_0 * GClass226.decimal_9;
      this.decimal_8 = (Decimal) int_0 * GClass226.decimal_10;
      this.decimal_10 = (Decimal) int_0 * GClass226.decimal_11;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 1984);
    }
  }

  public List<GClass125> method_4()
  {
    try
    {
      List<GClass125> gclass125List = new List<GClass125>();
      if (this.decimal_0 > 0M)
        gclass125List.Add(new GClass125()
        {
          decimal_0 = this.decimal_0,
          auroraElement_0 = AuroraElement.Duranium
        });
      if (this.decimal_1 > 0M)
        gclass125List.Add(new GClass125()
        {
          decimal_0 = this.decimal_1,
          auroraElement_0 = AuroraElement.Neutronium
        });
      if (this.decimal_2 > 0M)
        gclass125List.Add(new GClass125()
        {
          decimal_0 = this.decimal_2,
          auroraElement_0 = AuroraElement.Corbomite
        });
      if (this.decimal_3 > 0M)
        gclass125List.Add(new GClass125()
        {
          decimal_0 = this.decimal_3,
          auroraElement_0 = AuroraElement.Tritanium
        });
      if (this.decimal_4 > 0M)
        gclass125List.Add(new GClass125()
        {
          decimal_0 = this.decimal_4,
          auroraElement_0 = AuroraElement.Boronide
        });
      if (this.decimal_5 > 0M)
        gclass125List.Add(new GClass125()
        {
          decimal_0 = this.decimal_5,
          auroraElement_0 = AuroraElement.Mercassium
        });
      if (this.decimal_6 > 0M)
        gclass125List.Add(new GClass125()
        {
          decimal_0 = this.decimal_6,
          auroraElement_0 = AuroraElement.Vendarite
        });
      if (this.decimal_7 > 0M)
        gclass125List.Add(new GClass125()
        {
          decimal_0 = this.decimal_7,
          auroraElement_0 = AuroraElement.Sorium
        });
      if (this.decimal_8 > 0M)
        gclass125List.Add(new GClass125()
        {
          decimal_0 = this.decimal_8,
          auroraElement_0 = AuroraElement.Uridium
        });
      if (this.decimal_9 > 0M)
        gclass125List.Add(new GClass125()
        {
          decimal_0 = this.decimal_9,
          auroraElement_0 = AuroraElement.Corundium
        });
      if (this.decimal_10 > 0M)
        gclass125List.Add(new GClass125()
        {
          decimal_0 = this.decimal_10,
          auroraElement_0 = AuroraElement.Gallicite
        });
      return gclass125List;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 1985);
      return (List<GClass125>) null;
    }
  }

  public List<AuroraElement> method_5()
  {
    List<AuroraElement> auroraElementList = new List<AuroraElement>();
    if (this.decimal_0 > 0M)
      auroraElementList.Add(AuroraElement.Duranium);
    if (this.decimal_1 > 0M)
      auroraElementList.Add(AuroraElement.Neutronium);
    if (this.decimal_2 > 0M)
      auroraElementList.Add(AuroraElement.Corbomite);
    if (this.decimal_3 > 0M)
      auroraElementList.Add(AuroraElement.Tritanium);
    if (this.decimal_4 > 0M)
      auroraElementList.Add(AuroraElement.Boronide);
    if (this.decimal_5 > 0M)
      auroraElementList.Add(AuroraElement.Mercassium);
    if (this.decimal_6 > 0M)
      auroraElementList.Add(AuroraElement.Vendarite);
    if (this.decimal_7 > 0M)
      auroraElementList.Add(AuroraElement.Sorium);
    if (this.decimal_8 > 0M)
      auroraElementList.Add(AuroraElement.Uridium);
    if (this.decimal_9 > 0M)
      auroraElementList.Add(AuroraElement.Corundium);
    if (this.decimal_10 > 0M)
      auroraElementList.Add(AuroraElement.Gallicite);
    return auroraElementList;
  }

  public void method_6()
  {
    this.decimal_0 = 0M;
    this.decimal_1 = 0M;
    this.decimal_2 = 0M;
    this.decimal_3 = 0M;
    this.decimal_4 = 0M;
    this.decimal_5 = 0M;
    this.decimal_6 = 0M;
    this.decimal_7 = 0M;
    this.decimal_8 = 0M;
    this.decimal_9 = 0M;
    this.decimal_10 = 0M;
  }

  public Decimal method_7()
  {
    return this.decimal_0 + this.decimal_1 + this.decimal_2 + this.decimal_3 + this.decimal_4 + this.decimal_5 + this.decimal_6 + this.decimal_7 + this.decimal_8 + this.decimal_9 + this.decimal_10;
  }

  public void method_8(GClass156 gclass156_0)
  {
    this.decimal_0 += gclass156_0.gclass123_0.decimal_0 * gclass156_0.decimal_0;
    this.decimal_1 += gclass156_0.gclass123_0.decimal_1 * gclass156_0.decimal_0;
    this.decimal_2 += gclass156_0.gclass123_0.decimal_2 * gclass156_0.decimal_0;
    this.decimal_3 += gclass156_0.gclass123_0.decimal_3 * gclass156_0.decimal_0;
    this.decimal_4 += gclass156_0.gclass123_0.decimal_4 * gclass156_0.decimal_0;
    this.decimal_5 += gclass156_0.gclass123_0.decimal_5 * gclass156_0.decimal_0;
    this.decimal_6 += gclass156_0.gclass123_0.decimal_6 * gclass156_0.decimal_0;
    this.decimal_7 += gclass156_0.gclass123_0.decimal_7 * gclass156_0.decimal_0;
    this.decimal_8 += gclass156_0.gclass123_0.decimal_8 * gclass156_0.decimal_0;
    this.decimal_9 += gclass156_0.gclass123_0.decimal_9 * gclass156_0.decimal_0;
    this.decimal_10 += gclass156_0.gclass123_0.decimal_10 * gclass156_0.decimal_0;
  }

  public void method_9(GClass192 gclass192_0)
  {
    try
    {
      if (gclass192_0 == null || gclass192_0.gclass123_0 == null)
        return;
      this.decimal_0 += gclass192_0.gclass123_0.decimal_0 * (1M - gclass192_0.decimal_1 / gclass192_0.decimal_0);
      this.decimal_1 += gclass192_0.gclass123_0.decimal_1 * (1M - gclass192_0.decimal_1 / gclass192_0.decimal_0);
      this.decimal_2 += gclass192_0.gclass123_0.decimal_2 * (1M - gclass192_0.decimal_1 / gclass192_0.decimal_0);
      this.decimal_3 += gclass192_0.gclass123_0.decimal_3 * (1M - gclass192_0.decimal_1 / gclass192_0.decimal_0);
      this.decimal_4 += gclass192_0.gclass123_0.decimal_4 * (1M - gclass192_0.decimal_1 / gclass192_0.decimal_0);
      this.decimal_5 += gclass192_0.gclass123_0.decimal_5 * (1M - gclass192_0.decimal_1 / gclass192_0.decimal_0);
      this.decimal_6 += gclass192_0.gclass123_0.decimal_6 * (1M - gclass192_0.decimal_1 / gclass192_0.decimal_0);
      this.decimal_7 += gclass192_0.gclass123_0.decimal_7 * (1M - gclass192_0.decimal_1 / gclass192_0.decimal_0);
      this.decimal_8 += gclass192_0.gclass123_0.decimal_8 * (1M - gclass192_0.decimal_1 / gclass192_0.decimal_0);
      this.decimal_9 += gclass192_0.gclass123_0.decimal_9 * (1M - gclass192_0.decimal_1 / gclass192_0.decimal_0);
      this.decimal_10 += gclass192_0.gclass123_0.decimal_10 * (1M - gclass192_0.decimal_1 / gclass192_0.decimal_0);
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 1986);
    }
  }

  public void method_10(GClass123 gclass123_0)
  {
    try
    {
      this.decimal_0 += gclass123_0.decimal_0;
      this.decimal_1 += gclass123_0.decimal_1;
      this.decimal_2 += gclass123_0.decimal_2;
      this.decimal_3 += gclass123_0.decimal_3;
      this.decimal_4 += gclass123_0.decimal_4;
      this.decimal_5 += gclass123_0.decimal_5;
      this.decimal_6 += gclass123_0.decimal_6;
      this.decimal_7 += gclass123_0.decimal_7;
      this.decimal_8 += gclass123_0.decimal_8;
      this.decimal_9 += gclass123_0.decimal_9;
      this.decimal_10 += gclass123_0.decimal_10;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 1987);
    }
  }

  public void method_11(GClass123 gclass123_0, Decimal decimal_11)
  {
    try
    {
      this.decimal_0 += gclass123_0.decimal_0 * decimal_11;
      this.decimal_1 += gclass123_0.decimal_1 * decimal_11;
      this.decimal_2 += gclass123_0.decimal_2 * decimal_11;
      this.decimal_3 += gclass123_0.decimal_3 * decimal_11;
      this.decimal_4 += gclass123_0.decimal_4 * decimal_11;
      this.decimal_5 += gclass123_0.decimal_5 * decimal_11;
      this.decimal_6 += gclass123_0.decimal_6 * decimal_11;
      this.decimal_7 += gclass123_0.decimal_7 * decimal_11;
      this.decimal_8 += gclass123_0.decimal_8 * decimal_11;
      this.decimal_9 += gclass123_0.decimal_9 * decimal_11;
      this.decimal_10 += gclass123_0.decimal_10 * decimal_11;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 1988);
    }
  }

  public void method_12(Decimal decimal_11)
  {
    try
    {
      this.decimal_0 *= decimal_11;
      this.decimal_1 *= decimal_11;
      this.decimal_2 *= decimal_11;
      this.decimal_3 *= decimal_11;
      this.decimal_4 *= decimal_11;
      this.decimal_5 *= decimal_11;
      this.decimal_6 *= decimal_11;
      this.decimal_7 *= decimal_11;
      this.decimal_8 *= decimal_11;
      this.decimal_9 *= decimal_11;
      this.decimal_10 *= decimal_11;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 1989);
    }
  }

  public void method_13(GClass22 gclass22_0)
  {
    try
    {
      this.decimal_0 = gclass22_0.gclass123_0.decimal_0 * (Decimal) GClass226.smethod_13(5) / 10M;
      this.decimal_1 = gclass22_0.gclass123_0.decimal_1 * (Decimal) GClass226.smethod_13(5) / 10M;
      this.decimal_2 = gclass22_0.gclass123_0.decimal_2 * (Decimal) GClass226.smethod_13(5) / 10M;
      this.decimal_3 = gclass22_0.gclass123_0.decimal_3 * (Decimal) GClass226.smethod_13(5) / 10M;
      this.decimal_4 = gclass22_0.gclass123_0.decimal_4 * (Decimal) GClass226.smethod_13(5) / 10M;
      this.decimal_5 = gclass22_0.gclass123_0.decimal_5 * (Decimal) GClass226.smethod_13(5) / 10M;
      this.decimal_6 = gclass22_0.gclass123_0.decimal_6 * (Decimal) GClass226.smethod_13(5) / 10M;
      this.decimal_7 = gclass22_0.gclass123_0.decimal_7 * (Decimal) GClass226.smethod_13(5) / 10M;
      this.decimal_8 = gclass22_0.gclass123_0.decimal_8 * (Decimal) GClass226.smethod_13(5) / 10M;
      this.decimal_9 = gclass22_0.gclass123_0.decimal_9 * (Decimal) GClass226.smethod_13(5) / 10M;
      this.decimal_10 = gclass22_0.gclass123_0.decimal_10 * (Decimal) GClass226.smethod_13(5) / 10M;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 1990);
    }
  }

  public Decimal method_14(AuroraElement auroraElement_0)
  {
    try
    {
      switch (auroraElement_0)
      {
        case AuroraElement.Duranium:
          return this.decimal_0;
        case AuroraElement.Neutronium:
          return this.decimal_1;
        case AuroraElement.Corbomite:
          return this.decimal_2;
        case AuroraElement.Tritanium:
          return this.decimal_3;
        case AuroraElement.Boronide:
          return this.decimal_4;
        case AuroraElement.Mercassium:
          return this.decimal_5;
        case AuroraElement.Vendarite:
          return this.decimal_6;
        case AuroraElement.Sorium:
          return this.decimal_7;
        case AuroraElement.Uridium:
          return this.decimal_8;
        case AuroraElement.Corundium:
          return this.decimal_9;
        case AuroraElement.Gallicite:
          return this.decimal_10;
        default:
          return 0M;
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 1991);
      return 0M;
    }
  }

  public Decimal method_15(AuroraElement auroraElement_0, Decimal decimal_11)
  {
    try
    {
      switch (auroraElement_0)
      {
        case AuroraElement.Duranium:
          this.decimal_0 = decimal_11;
          break;
        case AuroraElement.Neutronium:
          this.decimal_1 = decimal_11;
          break;
        case AuroraElement.Corbomite:
          this.decimal_2 = decimal_11;
          break;
        case AuroraElement.Tritanium:
          this.decimal_3 = decimal_11;
          break;
        case AuroraElement.Boronide:
          this.decimal_4 = decimal_11;
          break;
        case AuroraElement.Mercassium:
          this.decimal_5 = decimal_11;
          break;
        case AuroraElement.Vendarite:
          this.decimal_6 = decimal_11;
          break;
        case AuroraElement.Sorium:
          this.decimal_7 = decimal_11;
          break;
        case AuroraElement.Uridium:
          this.decimal_8 = decimal_11;
          break;
        case AuroraElement.Corundium:
          this.decimal_9 = decimal_11;
          break;
        case AuroraElement.Gallicite:
          this.decimal_10 = decimal_11;
          break;
      }
      return 0M;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 1992);
      return 0M;
    }
  }

  public string method_16(AuroraElement auroraElement_0, int int_0)
  {
    try
    {
      switch (auroraElement_0)
      {
        case AuroraElement.Duranium:
          return this.decimal_0 == 0M ? "-" : GClass226.smethod_42(this.decimal_0, int_0);
        case AuroraElement.Neutronium:
          return this.decimal_1 == 0M ? "-" : GClass226.smethod_42(this.decimal_1, int_0);
        case AuroraElement.Corbomite:
          return this.decimal_2 == 0M ? "-" : GClass226.smethod_42(this.decimal_2, int_0);
        case AuroraElement.Tritanium:
          return this.decimal_3 == 0M ? "-" : GClass226.smethod_42(this.decimal_3, int_0);
        case AuroraElement.Boronide:
          return this.decimal_4 == 0M ? "-" : GClass226.smethod_42(this.decimal_4, int_0);
        case AuroraElement.Mercassium:
          return this.decimal_5 == 0M ? "-" : GClass226.smethod_42(this.decimal_5, int_0);
        case AuroraElement.Vendarite:
          return this.decimal_6 == 0M ? "-" : GClass226.smethod_42(this.decimal_6, int_0);
        case AuroraElement.Sorium:
          return this.decimal_7 == 0M ? "-" : GClass226.smethod_42(this.decimal_7, int_0);
        case AuroraElement.Uridium:
          return this.decimal_8 == 0M ? "-" : GClass226.smethod_42(this.decimal_8, int_0);
        case AuroraElement.Corundium:
          return this.decimal_9 == 0M ? "-" : GClass226.smethod_42(this.decimal_9, int_0);
        case AuroraElement.Gallicite:
          return this.decimal_10 == 0M ? "-" : GClass226.smethod_42(this.decimal_10, int_0);
        default:
          return "-";
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 1993);
      return "-";
    }
  }

  public Decimal method_17(GClass156 gclass156_0, Decimal decimal_11)
  {
    try
    {
      string str = "";
      if (gclass156_0.gclass123_0.decimal_0 > 0M && this.decimal_0 < gclass156_0.gclass123_0.decimal_0 * decimal_11)
      {
        decimal_11 = this.decimal_0 / gclass156_0.gclass123_0.decimal_0;
        str = "Duranium";
      }
      if (gclass156_0.gclass123_0.decimal_1 > 0M && this.decimal_1 < gclass156_0.gclass123_0.decimal_1 * decimal_11)
      {
        decimal_11 = this.decimal_1 / gclass156_0.gclass123_0.decimal_1;
        str = "Neutronium";
      }
      if (gclass156_0.gclass123_0.decimal_2 > 0M && this.decimal_2 < gclass156_0.gclass123_0.decimal_2 * decimal_11)
      {
        decimal_11 = this.decimal_2 / gclass156_0.gclass123_0.decimal_2;
        str = "Corbomite";
      }
      if (gclass156_0.gclass123_0.decimal_3 > 0M && this.decimal_3 < gclass156_0.gclass123_0.decimal_3 * decimal_11)
      {
        decimal_11 = this.decimal_3 / gclass156_0.gclass123_0.decimal_3;
        str = "Tritanium";
      }
      if (gclass156_0.gclass123_0.decimal_4 > 0M && this.decimal_4 < gclass156_0.gclass123_0.decimal_4 * decimal_11)
      {
        decimal_11 = this.decimal_4 / gclass156_0.gclass123_0.decimal_4;
        str = "Boronide";
      }
      if (gclass156_0.gclass123_0.decimal_5 > 0M && this.decimal_5 < gclass156_0.gclass123_0.decimal_5 * decimal_11)
      {
        decimal_11 = this.decimal_5 / gclass156_0.gclass123_0.decimal_5;
        str = "Mercassium";
      }
      if (gclass156_0.gclass123_0.decimal_6 > 0M && this.decimal_6 < gclass156_0.gclass123_0.decimal_6 * decimal_11)
      {
        decimal_11 = this.decimal_6 / gclass156_0.gclass123_0.decimal_6;
        str = "Vendarite";
      }
      if (gclass156_0.gclass123_0.decimal_7 > 0M && this.decimal_7 < gclass156_0.gclass123_0.decimal_7 * decimal_11)
      {
        decimal_11 = this.decimal_7 / gclass156_0.gclass123_0.decimal_7;
        str = "Sorium";
      }
      if (gclass156_0.gclass123_0.decimal_8 > 0M && this.decimal_8 < gclass156_0.gclass123_0.decimal_8 * decimal_11)
      {
        decimal_11 = this.decimal_8 / gclass156_0.gclass123_0.decimal_8;
        str = "Uridium";
      }
      if (gclass156_0.gclass123_0.decimal_9 > 0M && this.decimal_9 < gclass156_0.gclass123_0.decimal_9 * decimal_11)
      {
        decimal_11 = this.decimal_9 / gclass156_0.gclass123_0.decimal_9;
        str = "Corundium";
      }
      if (gclass156_0.gclass123_0.decimal_10 > 0M && this.decimal_10 < gclass156_0.gclass123_0.decimal_10 * decimal_11)
      {
        decimal_11 = this.decimal_10 / gclass156_0.gclass123_0.decimal_10;
        str = "Gallicite";
      }
      if (str != "")
        this.gclass0_0.gclass92_0.method_3(GEnum126.const_41, $"Shortage of {str} in Production of {gclass156_0.string_0} at {gclass156_0.gclass146_0.PopName}", gclass156_0.gclass21_0, gclass156_0.gclass146_0.gclass1_0.gclass200_0, gclass156_0.gclass146_0, gclass156_0.gclass146_0.method_87(), gclass156_0.gclass146_0.method_88(), AuroraEventCategory.PopProduction);
      return Math.Round(decimal_11, 4);
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 1994);
      return 0M;
    }
  }

  public Decimal method_18(GClass192 gclass192_0, Decimal decimal_11)
  {
    try
    {
      if (gclass192_0 == null)
        return 0M;
      string str = "";
      if (gclass192_0.gclass123_0.decimal_0 > 0M && this.decimal_0 < gclass192_0.gclass123_0.decimal_0 * decimal_11)
      {
        decimal_11 = this.decimal_0 / gclass192_0.gclass123_0.decimal_0;
        str = "Duranium";
      }
      if (gclass192_0.gclass123_0.decimal_1 > 0M && this.decimal_1 < gclass192_0.gclass123_0.decimal_1 * decimal_11)
      {
        decimal_11 = this.decimal_1 / gclass192_0.gclass123_0.decimal_1;
        str = "Neutronium";
      }
      if (gclass192_0.gclass123_0.decimal_2 > 0M && this.decimal_2 < gclass192_0.gclass123_0.decimal_2 * decimal_11)
      {
        decimal_11 = this.decimal_2 / gclass192_0.gclass123_0.decimal_2;
        str = "Corbomite";
      }
      if (gclass192_0.gclass123_0.decimal_3 > 0M && this.decimal_3 < gclass192_0.gclass123_0.decimal_3 * decimal_11)
      {
        decimal_11 = this.decimal_3 / gclass192_0.gclass123_0.decimal_3;
        str = "Tritanium";
      }
      if (gclass192_0.gclass123_0.decimal_4 > 0M && this.decimal_4 < gclass192_0.gclass123_0.decimal_4 * decimal_11)
      {
        decimal_11 = this.decimal_4 / gclass192_0.gclass123_0.decimal_4;
        str = "Boronide";
      }
      if (gclass192_0.gclass123_0.decimal_5 > 0M && this.decimal_5 < gclass192_0.gclass123_0.decimal_5 * decimal_11)
      {
        decimal_11 = this.decimal_5 / gclass192_0.gclass123_0.decimal_5;
        str = "Mercassium";
      }
      if (gclass192_0.gclass123_0.decimal_6 > 0M && this.decimal_6 < gclass192_0.gclass123_0.decimal_6 * decimal_11)
      {
        decimal_11 = this.decimal_6 / gclass192_0.gclass123_0.decimal_6;
        str = "Vendarite";
      }
      if (gclass192_0.gclass123_0.decimal_7 > 0M && this.decimal_7 < gclass192_0.gclass123_0.decimal_7 * decimal_11)
      {
        decimal_11 = this.decimal_7 / gclass192_0.gclass123_0.decimal_7;
        str = "Sorium";
      }
      if (gclass192_0.gclass123_0.decimal_8 > 0M && this.decimal_8 < gclass192_0.gclass123_0.decimal_8 * decimal_11)
      {
        decimal_11 = this.decimal_8 / gclass192_0.gclass123_0.decimal_8;
        str = "Uridium";
      }
      if (gclass192_0.gclass123_0.decimal_9 > 0M && this.decimal_9 < gclass192_0.gclass123_0.decimal_9 * decimal_11)
      {
        decimal_11 = this.decimal_9 / gclass192_0.gclass123_0.decimal_9;
        str = "Corundium";
      }
      if (gclass192_0.gclass123_0.decimal_10 > 0M && this.decimal_10 < gclass192_0.gclass123_0.decimal_10 * decimal_11)
      {
        decimal_11 = this.decimal_10 / gclass192_0.gclass123_0.decimal_10;
        str = "Gallicite";
      }
      if (str != "")
        this.gclass0_0.gclass92_0.method_3(GEnum126.const_41, $"Shortage of {str} in shipyard task: {gclass192_0.method_0()} at {gclass192_0.gclass146_0.PopName}", gclass192_0.gclass21_0, gclass192_0.gclass146_0.gclass1_0.gclass200_0, gclass192_0.gclass146_0, gclass192_0.gclass146_0.method_87(), gclass192_0.gclass146_0.method_88(), AuroraEventCategory.PopShipbuiding);
      return decimal_11;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 1995);
      return 0M;
    }
  }

  public Decimal method_19(GClass106 gclass106_0, GClass123 gclass123_0, Decimal decimal_11)
  {
    try
    {
      string str = "";
      if (gclass123_0.decimal_0 > 0M && this.decimal_0 < gclass123_0.decimal_0 * decimal_11)
      {
        decimal_11 = this.decimal_0 / gclass123_0.decimal_0;
        str = "Duranium";
      }
      if (gclass123_0.decimal_1 > 0M && this.decimal_1 < gclass123_0.decimal_1 * decimal_11)
      {
        decimal_11 = this.decimal_1 / gclass123_0.decimal_1;
        str = "Neutronium";
      }
      if (gclass123_0.decimal_2 > 0M && this.decimal_2 < gclass123_0.decimal_2 * decimal_11)
      {
        decimal_11 = this.decimal_2 / gclass123_0.decimal_2;
        str = "Corbomite";
      }
      if (gclass123_0.decimal_3 > 0M && this.decimal_3 < gclass123_0.decimal_3 * decimal_11)
      {
        decimal_11 = this.decimal_3 / gclass123_0.decimal_3;
        str = "Tritanium";
      }
      if (gclass123_0.decimal_4 > 0M && this.decimal_4 < gclass123_0.decimal_4 * decimal_11)
      {
        decimal_11 = this.decimal_4 / gclass123_0.decimal_4;
        str = "Boronide";
      }
      if (gclass123_0.decimal_5 > 0M && this.decimal_5 < gclass123_0.decimal_5 * decimal_11)
      {
        decimal_11 = this.decimal_5 / gclass123_0.decimal_5;
        str = "Mercassium";
      }
      if (gclass123_0.decimal_6 > 0M && this.decimal_6 < gclass123_0.decimal_6 * decimal_11)
      {
        decimal_11 = this.decimal_6 / gclass123_0.decimal_6;
        str = "Vendarite";
      }
      if (gclass123_0.decimal_7 > 0M && this.decimal_7 < gclass123_0.decimal_7 * decimal_11)
      {
        decimal_11 = this.decimal_7 / gclass123_0.decimal_7;
        str = "Sorium";
      }
      if (gclass123_0.decimal_8 > 0M && this.decimal_8 < gclass123_0.decimal_8 * decimal_11)
      {
        decimal_11 = this.decimal_8 / gclass123_0.decimal_8;
        str = "Uridium";
      }
      if (gclass123_0.decimal_9 > 0M && this.decimal_9 < gclass123_0.decimal_9 * decimal_11)
      {
        decimal_11 = this.decimal_9 / gclass123_0.decimal_9;
        str = "Corundium";
      }
      if (gclass123_0.decimal_10 > 0M && this.decimal_10 < gclass123_0.decimal_10 * decimal_11)
      {
        decimal_11 = this.decimal_10 / gclass123_0.decimal_10;
        str = "Gallicite";
      }
      if (str != "")
        this.gclass0_0.gclass92_0.method_3(GEnum126.const_41, $"Shortage of {str} in ground formation training task for {gclass106_0.string_0} at {gclass106_0.gclass146_0.PopName}", gclass106_0.gclass21_0, gclass106_0.gclass146_0.gclass1_0.gclass200_0, gclass106_0.gclass146_0, gclass106_0.gclass146_0.method_87(), gclass106_0.gclass146_0.method_88(), AuroraEventCategory.PopGroundUnits);
      return decimal_11;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 1996);
      return 0M;
    }
  }

  public void method_20(GClass156 gclass156_0, Decimal decimal_11)
  {
    try
    {
      this.decimal_0 -= gclass156_0.gclass123_0.decimal_0 * decimal_11;
      this.decimal_1 -= gclass156_0.gclass123_0.decimal_1 * decimal_11;
      this.decimal_2 -= gclass156_0.gclass123_0.decimal_2 * decimal_11;
      this.decimal_3 -= gclass156_0.gclass123_0.decimal_3 * decimal_11;
      this.decimal_4 -= gclass156_0.gclass123_0.decimal_4 * decimal_11;
      this.decimal_5 -= gclass156_0.gclass123_0.decimal_5 * decimal_11;
      this.decimal_6 -= gclass156_0.gclass123_0.decimal_6 * decimal_11;
      this.decimal_7 -= gclass156_0.gclass123_0.decimal_7 * decimal_11;
      this.decimal_8 -= gclass156_0.gclass123_0.decimal_8 * decimal_11;
      this.decimal_9 -= gclass156_0.gclass123_0.decimal_9 * decimal_11;
      this.decimal_10 -= gclass156_0.gclass123_0.decimal_10 * decimal_11;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 1997);
    }
  }

  public void method_21(GClass192 gclass192_0, Decimal decimal_11)
  {
    try
    {
      if (gclass192_0 == null)
        return;
      this.decimal_0 -= gclass192_0.gclass123_0.decimal_0 * decimal_11;
      this.decimal_1 -= gclass192_0.gclass123_0.decimal_1 * decimal_11;
      this.decimal_2 -= gclass192_0.gclass123_0.decimal_2 * decimal_11;
      this.decimal_3 -= gclass192_0.gclass123_0.decimal_3 * decimal_11;
      this.decimal_4 -= gclass192_0.gclass123_0.decimal_4 * decimal_11;
      this.decimal_5 -= gclass192_0.gclass123_0.decimal_5 * decimal_11;
      this.decimal_6 -= gclass192_0.gclass123_0.decimal_6 * decimal_11;
      this.decimal_7 -= gclass192_0.gclass123_0.decimal_7 * decimal_11;
      this.decimal_8 -= gclass192_0.gclass123_0.decimal_8 * decimal_11;
      this.decimal_9 -= gclass192_0.gclass123_0.decimal_9 * decimal_11;
      this.decimal_10 -= gclass192_0.gclass123_0.decimal_10 * decimal_11;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 1998);
    }
  }

  public void method_22(GClass123 gclass123_0, Decimal decimal_11)
  {
    try
    {
      this.decimal_0 -= gclass123_0.decimal_0 * decimal_11;
      this.decimal_1 -= gclass123_0.decimal_1 * decimal_11;
      this.decimal_2 -= gclass123_0.decimal_2 * decimal_11;
      this.decimal_3 -= gclass123_0.decimal_3 * decimal_11;
      this.decimal_4 -= gclass123_0.decimal_4 * decimal_11;
      this.decimal_5 -= gclass123_0.decimal_5 * decimal_11;
      this.decimal_6 -= gclass123_0.decimal_6 * decimal_11;
      this.decimal_7 -= gclass123_0.decimal_7 * decimal_11;
      this.decimal_8 -= gclass123_0.decimal_8 * decimal_11;
      this.decimal_9 -= gclass123_0.decimal_9 * decimal_11;
      this.decimal_10 -= gclass123_0.decimal_10 * decimal_11;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 1999);
    }
  }

  public void method_23(GClass146 gclass146_0, GEnum85 genum85_0, Decimal decimal_11)
  {
    try
    {
      gclass146_0.method_21(genum85_0, AuroraElement.Duranium, this.decimal_0 * decimal_11);
      gclass146_0.method_21(genum85_0, AuroraElement.Neutronium, this.decimal_1 * decimal_11);
      gclass146_0.method_21(genum85_0, AuroraElement.Corbomite, this.decimal_2 * decimal_11);
      gclass146_0.method_21(genum85_0, AuroraElement.Tritanium, this.decimal_3 * decimal_11);
      gclass146_0.method_21(genum85_0, AuroraElement.Boronide, this.decimal_4 * decimal_11);
      gclass146_0.method_21(genum85_0, AuroraElement.Mercassium, this.decimal_5 * decimal_11);
      gclass146_0.method_21(genum85_0, AuroraElement.Vendarite, this.decimal_6 * decimal_11);
      gclass146_0.method_21(genum85_0, AuroraElement.Sorium, this.decimal_7 * decimal_11);
      gclass146_0.method_21(genum85_0, AuroraElement.Uridium, this.decimal_8 * decimal_11);
      gclass146_0.method_21(genum85_0, AuroraElement.Corundium, this.decimal_9 * decimal_11);
      gclass146_0.method_21(genum85_0, AuroraElement.Gallicite, this.decimal_10 * decimal_11);
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3936);
    }
  }

  public void method_24(GClass146 gclass146_0, GEnum85 genum85_0)
  {
    try
    {
      gclass146_0.method_21(genum85_0, AuroraElement.Duranium, this.decimal_0);
      gclass146_0.method_21(genum85_0, AuroraElement.Neutronium, this.decimal_1);
      gclass146_0.method_21(genum85_0, AuroraElement.Corbomite, this.decimal_2);
      gclass146_0.method_21(genum85_0, AuroraElement.Tritanium, this.decimal_3);
      gclass146_0.method_21(genum85_0, AuroraElement.Boronide, this.decimal_4);
      gclass146_0.method_21(genum85_0, AuroraElement.Mercassium, this.decimal_5);
      gclass146_0.method_21(genum85_0, AuroraElement.Vendarite, this.decimal_6);
      gclass146_0.method_21(genum85_0, AuroraElement.Sorium, this.decimal_7);
      gclass146_0.method_21(genum85_0, AuroraElement.Uridium, this.decimal_8);
      gclass146_0.method_21(genum85_0, AuroraElement.Corundium, this.decimal_9);
      gclass146_0.method_21(genum85_0, AuroraElement.Gallicite, this.decimal_10);
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3936);
    }
  }

  public GClass123 method_25()
  {
    try
    {
      GClass123 gclass123 = new GClass123(this.gclass0_0);
      return (GClass123) this.MemberwiseClone();
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2000);
      return (GClass123) null;
    }
  }

  public GClass123 method_26(Decimal decimal_11)
  {
    try
    {
      return new GClass123(this.gclass0_0)
      {
        decimal_0 = this.decimal_0 * decimal_11,
        decimal_1 = this.decimal_1 * decimal_11,
        decimal_2 = this.decimal_2 * decimal_11,
        decimal_3 = this.decimal_3 * decimal_11,
        decimal_4 = this.decimal_4 * decimal_11,
        decimal_5 = this.decimal_5 * decimal_11,
        decimal_6 = this.decimal_6 * decimal_11,
        decimal_7 = this.decimal_7 * decimal_11,
        decimal_8 = this.decimal_8 * decimal_11,
        decimal_9 = this.decimal_9 * decimal_11,
        decimal_10 = this.decimal_10 * decimal_11
      };
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2001);
      return (GClass123) null;
    }
  }

  public void method_27(ListBox listBox_0)
  {
    try
    {
      List<string> stringList1 = new List<string>();
      Decimal num;
      if (this.decimal_0 > 0M)
      {
        List<string> stringList2 = stringList1;
        num = Math.Round(this.decimal_0, 1);
        string str = num.ToString() + "x Duranium";
        stringList2.Add(str);
      }
      if (this.decimal_1 > 0M)
      {
        List<string> stringList3 = stringList1;
        num = Math.Round(this.decimal_1, 1);
        string str = num.ToString() + "x Neutronium";
        stringList3.Add(str);
      }
      if (this.decimal_2 > 0M)
      {
        List<string> stringList4 = stringList1;
        num = Math.Round(this.decimal_2, 1);
        string str = num.ToString() + "x Corbomite";
        stringList4.Add(str);
      }
      if (this.decimal_3 > 0M)
      {
        List<string> stringList5 = stringList1;
        num = Math.Round(this.decimal_3, 1);
        string str = num.ToString() + "x Tritanium";
        stringList5.Add(str);
      }
      if (this.decimal_4 > 0M)
      {
        List<string> stringList6 = stringList1;
        num = Math.Round(this.decimal_4, 1);
        string str = num.ToString() + "x Boronide";
        stringList6.Add(str);
      }
      if (this.decimal_5 > 0M)
      {
        List<string> stringList7 = stringList1;
        num = Math.Round(this.decimal_5, 1);
        string str = num.ToString() + "x Mercassium";
        stringList7.Add(str);
      }
      if (this.decimal_6 > 0M)
      {
        List<string> stringList8 = stringList1;
        num = Math.Round(this.decimal_6, 1);
        string str = num.ToString() + "x Vendarite";
        stringList8.Add(str);
      }
      if (this.decimal_7 > 0M)
      {
        List<string> stringList9 = stringList1;
        num = Math.Round(this.decimal_7, 1);
        string str = num.ToString() + "x Sorium";
        stringList9.Add(str);
      }
      if (this.decimal_8 > 0M)
      {
        List<string> stringList10 = stringList1;
        num = Math.Round(this.decimal_8, 1);
        string str = num.ToString() + "x Uridium";
        stringList10.Add(str);
      }
      if (this.decimal_9 > 0M)
      {
        List<string> stringList11 = stringList1;
        num = Math.Round(this.decimal_9, 1);
        string str = num.ToString() + "x Corundium";
        stringList11.Add(str);
      }
      if (this.decimal_10 > 0M)
      {
        List<string> stringList12 = stringList1;
        num = Math.Round(this.decimal_10, 1);
        string str = num.ToString() + "x Gallicite";
        stringList12.Add(str);
      }
      listBox_0.DataSource = (object) stringList1;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2002);
    }
  }

  public void method_28(ListView listView_0) => this.method_29(listView_0, 0);

  public void method_29(ListView listView_0, int int_0)
  {
    try
    {
      this.gclass0_0.method_598(listView_0, "Duranium", GClass226.smethod_42(this.decimal_0, int_0), (object) AuroraElement.Duranium);
      this.gclass0_0.method_598(listView_0, "Neutronium", GClass226.smethod_42(this.decimal_1, int_0), (object) AuroraElement.Neutronium);
      this.gclass0_0.method_598(listView_0, "Corbomite", GClass226.smethod_42(this.decimal_2, int_0), (object) AuroraElement.Corbomite);
      this.gclass0_0.method_598(listView_0, "Tritanium", GClass226.smethod_42(this.decimal_3, int_0), (object) AuroraElement.Tritanium);
      this.gclass0_0.method_598(listView_0, "Boronide", GClass226.smethod_42(this.decimal_4, int_0), (object) AuroraElement.Boronide);
      this.gclass0_0.method_598(listView_0, "Mercassium", GClass226.smethod_42(this.decimal_5, int_0), (object) AuroraElement.Mercassium);
      this.gclass0_0.method_598(listView_0, "Vendarite", GClass226.smethod_42(this.decimal_6, int_0), (object) AuroraElement.Vendarite);
      this.gclass0_0.method_598(listView_0, "Sorium", GClass226.smethod_42(this.decimal_7, int_0), (object) AuroraElement.Sorium);
      this.gclass0_0.method_598(listView_0, "Uridium", GClass226.smethod_42(this.decimal_8, int_0), (object) AuroraElement.Uridium);
      this.gclass0_0.method_598(listView_0, "Corundium", GClass226.smethod_42(this.decimal_9, int_0), (object) AuroraElement.Corundium);
      this.gclass0_0.method_598(listView_0, "Gallicite", GClass226.smethod_42(this.decimal_10, int_0), (object) AuroraElement.Gallicite);
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2003);
    }
  }

  public void method_30(ListView listView_0)
  {
    try
    {
      if (this.decimal_0 > 0M)
        this.gclass0_0.method_598(listView_0, "Duranium", GClass226.smethod_39(this.decimal_0), (object) AuroraElement.Duranium);
      if (this.decimal_1 > 0M)
        this.gclass0_0.method_598(listView_0, "Neutronium", GClass226.smethod_39(this.decimal_1), (object) AuroraElement.Neutronium);
      if (this.decimal_2 > 0M)
        this.gclass0_0.method_598(listView_0, "Corbomite", GClass226.smethod_39(this.decimal_2), (object) AuroraElement.Corbomite);
      if (this.decimal_3 > 0M)
        this.gclass0_0.method_598(listView_0, "Tritanium", GClass226.smethod_39(this.decimal_3), (object) AuroraElement.Tritanium);
      if (this.decimal_4 > 0M)
        this.gclass0_0.method_598(listView_0, "Boronide", GClass226.smethod_39(this.decimal_4), (object) AuroraElement.Boronide);
      if (this.decimal_5 > 0M)
        this.gclass0_0.method_598(listView_0, "Mercassium", GClass226.smethod_39(this.decimal_5), (object) AuroraElement.Mercassium);
      if (this.decimal_6 > 0M)
        this.gclass0_0.method_598(listView_0, "Vendarite", GClass226.smethod_39(this.decimal_6), (object) AuroraElement.Vendarite);
      if (this.decimal_7 > 0M)
        this.gclass0_0.method_598(listView_0, "Sorium", GClass226.smethod_39(this.decimal_7), (object) AuroraElement.Sorium);
      if (this.decimal_8 > 0M)
        this.gclass0_0.method_598(listView_0, "Uridium", GClass226.smethod_39(this.decimal_8), (object) AuroraElement.Uridium);
      if (this.decimal_9 > 0M)
        this.gclass0_0.method_598(listView_0, "Corundium", GClass226.smethod_39(this.decimal_9), (object) AuroraElement.Corundium);
      if (!(this.decimal_10 > 0M))
        return;
      this.gclass0_0.method_598(listView_0, "Gallicite", GClass226.smethod_39(this.decimal_10), (object) AuroraElement.Gallicite);
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2004);
    }
  }

  public void method_31(ListView listView_0, GClass123 gclass123_0)
  {
    this.method_32(listView_0, gclass123_0, 1M);
  }

  public void method_32(ListView listView_0, GClass123 gclass123_0, Decimal decimal_11)
  {
    try
    {
      listView_0.Items.Clear();
      this.gclass0_0.method_601(listView_0, "Resource", "Required", "Available");
      if (this.decimal_0 > 0M)
        this.gclass0_0.method_601(listView_0, "Duranium", GClass226.smethod_39(this.decimal_0 * decimal_11), GClass226.smethod_39(gclass123_0.decimal_0));
      if (this.decimal_1 > 0M)
        this.gclass0_0.method_601(listView_0, "Neutronium", GClass226.smethod_39(this.decimal_1 * decimal_11), GClass226.smethod_39(gclass123_0.decimal_1));
      if (this.decimal_2 > 0M)
        this.gclass0_0.method_601(listView_0, "Corbomite", GClass226.smethod_39(this.decimal_2 * decimal_11), GClass226.smethod_39(gclass123_0.decimal_2));
      if (this.decimal_3 > 0M)
        this.gclass0_0.method_601(listView_0, "Tritanium", GClass226.smethod_39(this.decimal_3 * decimal_11), GClass226.smethod_39(gclass123_0.decimal_3));
      if (this.decimal_4 > 0M)
        this.gclass0_0.method_601(listView_0, "Boronide", GClass226.smethod_39(this.decimal_4 * decimal_11), GClass226.smethod_39(gclass123_0.decimal_4));
      if (this.decimal_5 > 0M)
        this.gclass0_0.method_601(listView_0, "Mercassium", GClass226.smethod_39(this.decimal_5 * decimal_11), GClass226.smethod_39(gclass123_0.decimal_5));
      if (this.decimal_6 > 0M)
        this.gclass0_0.method_601(listView_0, "Vendarite", GClass226.smethod_39(this.decimal_6 * decimal_11), GClass226.smethod_39(gclass123_0.decimal_6));
      if (this.decimal_7 > 0M)
        this.gclass0_0.method_601(listView_0, "Sorium", GClass226.smethod_39(this.decimal_7 * decimal_11), GClass226.smethod_39(gclass123_0.decimal_7));
      if (this.decimal_8 > 0M)
        this.gclass0_0.method_601(listView_0, "Uridium", GClass226.smethod_39(this.decimal_8 * decimal_11), GClass226.smethod_39(gclass123_0.decimal_8));
      if (this.decimal_9 > 0M)
        this.gclass0_0.method_601(listView_0, "Corundium", GClass226.smethod_39(this.decimal_9 * decimal_11), GClass226.smethod_39(gclass123_0.decimal_9));
      if (!(this.decimal_10 > 0M))
        return;
      this.gclass0_0.method_601(listView_0, "Gallicite", GClass226.smethod_39(this.decimal_10 * decimal_11), GClass226.smethod_39(gclass123_0.decimal_10));
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2005);
    }
  }

  public void method_33(AuroraElement auroraElement_0, Decimal decimal_11)
  {
    try
    {
      switch (auroraElement_0)
      {
        case AuroraElement.Duranium:
          this.decimal_0 += decimal_11;
          break;
        case AuroraElement.Neutronium:
          this.decimal_1 += decimal_11;
          break;
        case AuroraElement.Corbomite:
          this.decimal_2 += decimal_11;
          break;
        case AuroraElement.Tritanium:
          this.decimal_3 += decimal_11;
          break;
        case AuroraElement.Boronide:
          this.decimal_4 += decimal_11;
          break;
        case AuroraElement.Mercassium:
          this.decimal_5 += decimal_11;
          break;
        case AuroraElement.Vendarite:
          this.decimal_6 += decimal_11;
          break;
        case AuroraElement.Sorium:
          this.decimal_7 += decimal_11;
          break;
        case AuroraElement.Uridium:
          this.decimal_8 += decimal_11;
          break;
        case AuroraElement.Corundium:
          this.decimal_9 += decimal_11;
          break;
        case AuroraElement.Gallicite:
          this.decimal_10 += decimal_11;
          break;
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2006);
    }
  }

  public void method_34(GClass230 gclass230_0)
  {
    try
    {
      this.decimal_0 += gclass230_0.gclass123_0.decimal_0;
      this.decimal_1 += gclass230_0.gclass123_0.decimal_1;
      this.decimal_2 += gclass230_0.gclass123_0.decimal_2;
      this.decimal_3 += gclass230_0.gclass123_0.decimal_3;
      this.decimal_4 += gclass230_0.gclass123_0.decimal_4;
      this.decimal_5 += gclass230_0.gclass123_0.decimal_5;
      this.decimal_6 += gclass230_0.gclass123_0.decimal_6;
      this.decimal_7 += gclass230_0.gclass123_0.decimal_7;
      this.decimal_8 += gclass230_0.gclass123_0.decimal_8;
      this.decimal_9 += gclass230_0.gclass123_0.decimal_9;
      this.decimal_10 += gclass230_0.gclass123_0.decimal_10;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2007);
    }
  }

  public void method_35(GClass230 gclass230_0, Decimal decimal_11)
  {
    try
    {
      this.decimal_0 += gclass230_0.gclass123_0.decimal_0 * decimal_11;
      this.decimal_1 += gclass230_0.gclass123_0.decimal_1 * decimal_11;
      this.decimal_2 += gclass230_0.gclass123_0.decimal_2 * decimal_11;
      this.decimal_3 += gclass230_0.gclass123_0.decimal_3 * decimal_11;
      this.decimal_4 += gclass230_0.gclass123_0.decimal_4 * decimal_11;
      this.decimal_5 += gclass230_0.gclass123_0.decimal_5 * decimal_11;
      this.decimal_6 += gclass230_0.gclass123_0.decimal_6 * decimal_11;
      this.decimal_7 += gclass230_0.gclass123_0.decimal_7 * decimal_11;
      this.decimal_8 += gclass230_0.gclass123_0.decimal_8 * decimal_11;
      this.decimal_9 += gclass230_0.gclass123_0.decimal_9 * decimal_11;
      this.decimal_10 += gclass230_0.gclass123_0.decimal_10 * decimal_11;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2008);
    }
  }

  public string method_36()
  {
    try
    {
      string str = "";
      if (this.decimal_0 > 0M)
        str = $"{str}Duranium  {GClass226.smethod_42(this.decimal_0, 2)}    ";
      if (this.decimal_1 > 0M)
        str = $"{str}Neutronium  {GClass226.smethod_42(this.decimal_1, 2)}    ";
      if (this.decimal_2 > 0M)
        str = $"{str}Corbomite  {GClass226.smethod_42(this.decimal_2, 2)}    ";
      if (this.decimal_3 > 0M)
        str = $"{str}Tritanium  {GClass226.smethod_42(this.decimal_3, 2)}    ";
      if (this.decimal_4 > 0M)
        str = $"{str}Boronide  {GClass226.smethod_42(this.decimal_4, 2)}    ";
      if (this.decimal_5 > 0M)
        str = $"{str}Mercassium  {GClass226.smethod_42(this.decimal_5, 2)}    ";
      if (this.decimal_6 > 0M)
        str = $"{str}Vendarite  {GClass226.smethod_42(this.decimal_6, 2)}    ";
      if (this.decimal_7 > 0M)
        str = $"{str}Sorium  {GClass226.smethod_42(this.decimal_7, 2)}    ";
      if (this.decimal_8 > 0M)
        str = $"{str}Uridium  {GClass226.smethod_42(this.decimal_8, 2)}    ";
      if (this.decimal_9 > 0M)
        str = $"{str}Corundium  {GClass226.smethod_42(this.decimal_9, 2)}    ";
      if (this.decimal_10 > 0M)
        str = $"{str}Gallicite  {GClass226.smethod_42(this.decimal_10, 2)}    ";
      return str;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2009);
      return "error";
    }
  }

  public string method_37(int int_0)
  {
    try
    {
      string str = "";
      if (this.decimal_0 > 0M)
        str = $"{str}Duranium  {GClass226.smethod_42(this.decimal_0, int_0)}   ";
      if (this.decimal_1 > 0M)
        str = $"{str}Neutronium  {GClass226.smethod_42(this.decimal_1, int_0)}   ";
      if (this.decimal_2 > 0M)
        str = $"{str}Corbomite  {GClass226.smethod_42(this.decimal_2, int_0)}   ";
      if (this.decimal_3 > 0M)
        str = $"{str}Tritanium  {GClass226.smethod_42(this.decimal_3, int_0)}   ";
      if (this.decimal_4 > 0M)
        str = $"{str}Boronide  {GClass226.smethod_42(this.decimal_4, int_0)}   ";
      if (this.decimal_5 > 0M)
        str = $"{str}Mercassium  {GClass226.smethod_42(this.decimal_5, int_0)}   ";
      if (this.decimal_6 > 0M)
        str = $"{str}Vendarite  {GClass226.smethod_42(this.decimal_6, int_0)}   ";
      if (this.decimal_7 > 0M)
        str = $"{str}Sorium  {GClass226.smethod_42(this.decimal_7, int_0)}   ";
      if (this.decimal_8 > 0M)
        str = $"{str}Uridium  {GClass226.smethod_42(this.decimal_8, int_0)}   ";
      if (this.decimal_9 > 0M)
        str = $"{str}Corundium  {GClass226.smethod_42(this.decimal_9, int_0)}   ";
      if (this.decimal_10 > 0M)
        str = $"{str}Gallicite  {GClass226.smethod_42(this.decimal_10, int_0)}   ";
      return str;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2010);
      return "error";
    }
  }

  public string method_38()
  {
    try
    {
      string str = "";
      if (this.decimal_0 > 0M)
        str = $"{str}D{GClass226.smethod_42(this.decimal_0, 0)}  ";
      if (this.decimal_1 > 0M)
        str = $"{str}N{GClass226.smethod_42(this.decimal_1, 0)}  ";
      if (this.decimal_2 > 0M)
        str = $"{str}CB{GClass226.smethod_42(this.decimal_2, 0)}  ";
      if (this.decimal_3 > 0M)
        str = $"{str}T{GClass226.smethod_42(this.decimal_3, 0)}  ";
      if (this.decimal_4 > 0M)
        str = $"{str}B{GClass226.smethod_42(this.decimal_4, 0)}  ";
      if (this.decimal_5 > 0M)
        str = $"{str}M{GClass226.smethod_42(this.decimal_5, 0)}  ";
      if (this.decimal_6 > 0M)
        str = $"{str}V{GClass226.smethod_42(this.decimal_6, 0)}  ";
      if (this.decimal_7 > 0M)
        str = $"{str}S{GClass226.smethod_42(this.decimal_7, 0)}  ";
      if (this.decimal_8 > 0M)
        str = $"{str}U{GClass226.smethod_42(this.decimal_8, 0)}  ";
      if (this.decimal_9 > 0M)
        str = $"{str}CR{GClass226.smethod_42(this.decimal_9, 0)}  ";
      if (this.decimal_10 > 0M)
        str = $"{str}G{GClass226.smethod_42(this.decimal_10, 0)}  ";
      return str;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2011);
      return "error";
    }
  }

  public bool method_39(GClass123 gclass123_0)
  {
    try
    {
      return !(this.decimal_0 < gclass123_0.decimal_0) && !(this.decimal_1 < gclass123_0.decimal_1) && !(this.decimal_2 < gclass123_0.decimal_2) && !(this.decimal_3 < gclass123_0.decimal_3) && !(this.decimal_4 < gclass123_0.decimal_4) && !(this.decimal_5 < gclass123_0.decimal_5) && !(this.decimal_6 < gclass123_0.decimal_6) && !(this.decimal_7 < gclass123_0.decimal_7) && !(this.decimal_8 < gclass123_0.decimal_8) && !(this.decimal_9 < gclass123_0.decimal_9) && !(this.decimal_10 < gclass123_0.decimal_10);
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3855);
      return false;
    }
  }
}
