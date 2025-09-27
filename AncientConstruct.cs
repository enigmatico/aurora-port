// Decompiled with JetBrains decompiler
// Type: GClass220
// Assembly: Aurora, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAB8E3AD-3A24-426F-849E-98EC2E2DD9EB
// Assembly location: C:\Users\jinhoon.kim\Desktop\Aurora250Full\Dedot\aurora-deop.exe

using System;

#nullable disable
public class AncientConstruct
{
    public GClass0 gclass0_0;
    public SystemBodyData SystemBody;
    public ResearchFieldData ResearchField;
    public int AncientConstructID;
    public int AncientConstructTypeID;
    public Decimal ResearchBonus;
    public bool Active;

    public string ViewingName { get; set; }

    public AncientConstruct(GClass0 gclass0_1) => this.gclass0_0 = gclass0_1;

    public string method_0()
    {
        return this.Active
            ? $"{this.ResearchField.ShortName} {AuroraUtils.smethod_39((this.ResearchBonus - 1M) * 100M)}%"
            : "Dormant Construct";
    }
}