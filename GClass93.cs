// Decompiled with JetBrains decompiler
// Type: GClass93
// Assembly: Aurora, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAB8E3AD-3A24-426F-849E-98EC2E2DD9EB
// Assembly location: C:\Users\jinhoon.kim\Desktop\Aurora250Full\Dedot\aurora-deop.exe

using Aurora;
using System;

#nullable disable
public class GClass93
{
  public GClass93 gclass93_0;
  public GClass102 gclass102_0;
  public GClass21 gclass21_0;
  public AuroraGroundFormationFieldPosition auroraGroundFormationFieldPosition_0;
  public int int_0;
  public int int_1;
  public string string_0 = "";
  public bool bool_0;

  public string method_0()
  {
    try
    {
      string string0 = this.string_0;
      return this.gclass102_0 == null ? string0 : (this.auroraGroundFormationFieldPosition_0 != AuroraGroundFormationFieldPosition.FrontlineDefence ? (this.auroraGroundFormationFieldPosition_0 != AuroraGroundFormationFieldPosition.FrontlineAttack ? (this.auroraGroundFormationFieldPosition_0 != AuroraGroundFormationFieldPosition.Support ? (this.auroraGroundFormationFieldPosition_0 != AuroraGroundFormationFieldPosition.RearEchelon ? $"{this.gclass102_0.string_1} {this.gclass102_0.Name}" : $"{this.gclass102_0.string_1} {this.gclass102_0.Name}  (RE)") : $"{this.gclass102_0.string_1} {this.gclass102_0.Name}  (SP)") : $"{this.gclass102_0.string_1} {this.gclass102_0.Name}  (FA)") : $"{this.gclass102_0.string_1} {this.gclass102_0.Name}");
    }
    catch (Exception ex)
    {
      GClass226.smethod_74(ex, 3622);
      return "error";
    }
  }
}
