// Decompiled with JetBrains decompiler
// Type: GClass140
// Assembly: Aurora, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAB8E3AD-3A24-426F-849E-98EC2E2DD9EB
// Assembly location: C:\Users\jinhoon.kim\Desktop\Aurora250Full\Dedot\aurora-deop.exe

using System;
using System.Collections.Generic;
using System.Linq;

#nullable disable
public class GClass140
{
  private sealed class Class1087
  {
    public Random random_0;

    internal int method_0(string string_0)
    {
      return this.random_0.Next();
    }
  }
  
  public List<string> list_0 = new List<string>();
  public int int_0;
  public bool bool_0;

  public string Description { get; set; }

  public string method_0(GClass21 gclass21_0, GEnum21 genum21_0)
  {
    try
    {
      return this.method_2(gclass21_0, genum21_0, 0, "", "");
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2072);
      return "";
    }
  }

  public string method_1(GClass21 gclass21_0, GEnum21 genum21_0, int int_1)
  {
    try
    {
      return this.method_2(gclass21_0, genum21_0, int_1, "", "");
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2072);
      return "";
    }
  }

  public string method_2(
    GClass21 gclass21_0,
    GEnum21 genum21_0,
    int int_1,
    string string_1,
    string string_2)
  {
    try
    {
      bool flag = false;
      List<string> list = this.list_0.ToList<string>();
      if (int_1 == 1)
      {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: reference to a compiler-generated method
        list = list.OrderBy<string, int>(new Func<string, int>(new GClass140.Class1087()
        {
          random_0 = new Random()
        }.method_0)).Select<string, string>((Func<string, string>) (string_0 => string_0)).ToList<string>();
      }
      foreach (string str in list)
      {
        string string_10 = str;
        string_10.Trim();
        if (string_1 != "")
          string_10 = $"{string_1} {string_10}";
        if (string_2 != "")
          string_10 = $"{string_10} {string_2}";
        switch (genum21_0)
        {
          case GEnum21.const_0:
            flag = gclass21_0.method_53(string_10);
            break;
          case GEnum21.const_1:
            flag = gclass21_0.method_54(string_10);
            break;
          case GEnum21.const_2:
            flag = gclass21_0.method_57(string_10);
            break;
          case GEnum21.const_3:
            flag = gclass21_0.method_58(string_10);
            break;
          case GEnum21.const_4:
            flag = gclass21_0.method_56(string_10);
            break;
          case GEnum21.const_5:
            flag = gclass21_0.method_55(string_10);
            break;
        }
        if (!flag)
          return string_10.Trim();
      }
      return "";
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 2073);
      return "";
    }
  }
}
