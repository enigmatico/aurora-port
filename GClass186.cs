// Decompiled with JetBrains decompiler
// Type: GClass186
// Assembly: Aurora, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAB8E3AD-3A24-426F-849E-98EC2E2DD9EB
// Assembly location: C:\Users\jinhoon.kim\Desktop\Aurora250Full\Dedot\aurora-deop.exe

using System;
using System.Linq;

#nullable disable
public class GClass186
{
  private sealed class Class1155
  {
    public GClass186 gclass186_0;
    public GClass21 gclass21_0;

    internal bool method_0(GClass185 gclass185_0)
    {
      return gclass185_0.int_0 == this.gclass186_0.int_1;
    }

    internal bool method_1(GClass230 gclass230_0)
    {
      return gclass230_0.gclass164_0.int_0 == this.gclass186_0.int_2;
    }

    internal bool method_2(GClass230 gclass230_0)
    {
      return gclass230_0.gclass185_0 == this.gclass186_0.gclass185_0 && gclass230_0.gclass164_0.gclass21_0 == this.gclass21_0;
    }
  }
  
  private GClass0 gclass0_0;
  public GClass185 gclass185_0;
  public GClass230 gclass230_0;
  public GClass230 gclass230_1;
  public int int_0;
  public int int_1;
  public int int_2;
  public int int_3;
  public int int_4;
  public int int_5;
  public string string_0 = "";

  public GClass186(GClass0 gclass0_1) => this.gclass0_0 = gclass0_1;

  public void method_0(GClass21 gclass21_0)
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    GClass186.Class1155 class1155 = new GClass186.Class1155();
    // ISSUE: reference to a compiler-generated field
    class1155.gclass186_0 = this;
    // ISSUE: reference to a compiler-generated field
    class1155.gclass21_0 = gclass21_0;
    try
    {
      this.int_5 = 0;
      this.int_4 = 0;
      this.string_0 = "Component Not Known";
      // ISSUE: reference to a compiler-generated method
      this.gclass185_0 = this.gclass0_0.dictionary_76.Values.FirstOrDefault<GClass185>(new Func<GClass185, bool>(class1155.method_0));
      // ISSUE: reference to a compiler-generated method
      this.gclass230_0 = this.gclass0_0.dictionary_54.Values.FirstOrDefault<GClass230>(new Func<GClass230, bool>(class1155.method_1));
      if (this.gclass185_0 != null)
      {
        // ISSUE: reference to a compiler-generated method
        GClass230 gclass230_0 = this.gclass0_0.dictionary_54.Values.FirstOrDefault<GClass230>(new Func<GClass230, bool>(class1155.method_2));
        if (gclass230_0 != null)
        {
          // ISSUE: reference to a compiler-generated field
          if (!gclass230_0.gclass164_0.dictionary_0.ContainsKey(class1155.gclass21_0.RaceID))
          {
            // ISSUE: reference to a compiler-generated field
            class1155.gclass21_0.method_74(gclass230_0.gclass164_0.int_0, true, false, gclass230_0);
            this.int_4 = gclass230_0.int_23;
            this.int_5 = gclass230_0.gclass164_0.int_4;
          }
        }
        else
        {
          // ISSUE: reference to a compiler-generated field
          this.gclass230_1 = class1155.gclass21_0.method_73(this.gclass185_0, true, false, false);
          this.int_4 = this.gclass230_1.int_23;
          this.int_5 = this.gclass230_1.gclass164_0.int_4;
        }
        this.string_0 = this.gclass185_0.string_0;
      }
      else
      {
        if (this.gclass230_0 == null)
          return;
        this.string_0 = this.gclass230_0.Name;
        // ISSUE: reference to a compiler-generated field
        if (this.gclass230_0.gclass164_0.dictionary_0.ContainsKey(class1155.gclass21_0.RaceID))
          return;
        // ISSUE: reference to a compiler-generated field
        class1155.gclass21_0.method_74(this.gclass230_0.gclass164_0.int_0, true, false, this.gclass230_0);
        this.int_4 = this.gclass230_0.int_23;
      }
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3729);
    }
  }
}
