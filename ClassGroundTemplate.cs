// Decompiled with JetBrains decompiler
// Type: GClass75
// Assembly: Aurora, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAB8E3AD-3A24-426F-849E-98EC2E2DD9EB
// Assembly location: C:\Users\jinhoon.kim\Desktop\Aurora250Full\Dedot\aurora-deop.exe

using System;

#nullable disable
public class ClassGroundTemplate
{
    public int Number;
    public GroundUnitFormationTemplateData GroundUnitTemplate;

    public string Combined { get; set; }

    public string method_0()
    {
        return
            string.Format("{0}x {1}   Size: {2}{3}", this.Number.ToString(), this.GroundUnitTemplate.Name,
                this.GroundUnitTemplate.method_9().ToString(), Environment.NewLine);
    }
}