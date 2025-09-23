// Decompiled with JetBrains decompiler
// Type: GClass41
// Assembly: Aurora, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAB8E3AD-3A24-426F-849E-98EC2E2DD9EB
// Assembly location: C:\Users\jinhoon.kim\Desktop\Aurora250Full\Dedot\aurora-deop.exe

using System;
using System.Collections.Generic;
using System.Linq;

#nullable disable
public static class GClass41
{
  public static double smethod_0<T>(this IEnumerable<T> ienumerable_0, Func<T, double> func_0)
  {
    try
    {
      double num1 = 0.0;
      double num2 = 0.0;
      double num3 = 0.0;
      int num4 = 0;
      foreach (double num5 in ienumerable_0.Select<T, double>(func_0))
      {
        ++num4;
        double num6 = num5 - num1;
        num1 += num6 / (double) num4;
        num2 += num6 * (num5 - num1);
      }
      if (1 < num4)
        num3 = Math.Sqrt(num2 / (double) num4);
      return num3;
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 660);
      return 0.0;
    }
  }
}
