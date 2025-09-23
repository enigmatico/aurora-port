// Decompiled with JetBrains decompiler
// Type: GClass75
// Assembly: Aurora, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAB8E3AD-3A24-426F-849E-98EC2E2DD9EB
// Assembly location: C:\Users\jinhoon.kim\Desktop\Aurora250Full\Dedot\aurora-deop.exe

using System;

#nullable disable
public class GClass75
{
  public int int_0;
  public GClass102 gclass102_0;

  public string Combined { get; set; }

  public string method_0()
  {
    return $"{this.int_0.ToString()}x {this.gclass102_0.Name}   Size: {this.gclass102_0.method_9().ToString()}{Environment.NewLine}";
  }
}
