// Decompiled with JetBrains decompiler
// Type: GClass80
// Assembly: Aurora, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAB8E3AD-3A24-426F-849E-98EC2E2DD9EB
// Assembly location: C:\Users\jinhoon.kim\Desktop\Aurora250Full\Dedot\aurora-deop.exe

using System;
using System.Collections.Generic;
using System.Linq;

#nullable disable
public class GClass80
{
    public List<GClass235> list_0 = new List<GClass235>();
    public AllMineralsValue gclass123_0;

    public void method_0(ShipComponent gclass230_0, int int_0)
    {
        GClass235 gclass235 = this.list_0.FirstOrDefault(v => v.gclass230_0 == gclass230_0);
        if (gclass235 == null)
        {
            // ISSUE: reference to a compiler-generated field
            this.list_0.Add(new GClass235()
            {
                gclass230_0 = gclass230_0,
                int_0 = int_0
            });
        }
        else
            gclass235.int_0 += int_0;
    }
}