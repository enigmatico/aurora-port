// Decompiled with JetBrains decompiler
// Type: GClass121
// Assembly: Aurora, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAB8E3AD-3A24-426F-849E-98EC2E2DD9EB
// Assembly location: C:\Users\jinhoon.kim\Desktop\Aurora250Full\Dedot\aurora-deop.exe

using Aurora;
using System;
using System.Collections.Generic;
using System.Linq;

#nullable disable
public class GClass121
{
  private GClass0 gclass0_0;
  public GClass21 gclass21_0;
  public GClass202 gclass202_0;
  public int int_0;
  public Decimal decimal_0;
  public Decimal decimal_1;
  public double double_0;
  public double double_1;
  public List<GClass146> list_0 = new List<GClass146>();
  public List<GClass40> list_1 = new List<GClass40>();
  public List<GClass40> list_2 = new List<GClass40>();
  public List<GClass40> list_3 = new List<GClass40>();

  public GClass121(GClass0 gclass0_1) => this.gclass0_0 = gclass0_1;

  public Decimal method_0(Decimal decimal_2, GClass40 gclass40_0_1)
  {
    try
    {
      int num1 = gclass40_0_1.method_167(AuroraComponentType.CargoShuttleBay);
      Decimal num2 = decimal_2;
      this.list_0 = this.list_0.OrderByDescending<GClass146, Decimal>((Func<GClass146, Decimal>) (gclass146_0 => gclass146_0.decimal_0)).ToList<GClass146>();
      foreach (GClass146 gclass146 in this.list_0)
      {
        if (!(gclass146.decimal_0 >= num2))
        {
          if (gclass146.decimal_0 > 0M)
          {
            num2 -= gclass146.decimal_0;
            gclass146.decimal_0 = 0M;
          }
        }
        else
        {
          gclass146.decimal_0 -= num2;
          return decimal_2;
        }
      }
      this.list_3 = this.list_3.OrderByDescending<GClass40, Decimal>((Func<GClass40, Decimal>) (gclass40_0_2 => gclass40_0_2.decimal_4)).ToList<GClass40>();
      foreach (GClass40 gclass40 in this.list_3)
      {
        if (num1 + gclass40.method_167(AuroraComponentType.CargoShuttleBay) != 0)
        {
          if (!(gclass40.decimal_4 >= num2))
          {
            if (gclass40.decimal_4 > 0M)
            {
              num2 -= gclass40.decimal_4;
              gclass40.decimal_4 = 0M;
            }
          }
          else
          {
            gclass40.decimal_4 -= num2;
            return decimal_2;
          }
        }
      }
      if (gclass40_0_1.decimal_4 >= num2)
      {
        gclass40_0_1.decimal_4 -= num2;
        return decimal_2;
      }
      if (gclass40_0_1.decimal_4 > 0M)
      {
        num2 -= gclass40_0_1.decimal_4;
        gclass40_0_1.decimal_4 = 0M;
      }
      return decimal_2 - num2;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 1969);
      return 0M;
    }
  }
}
