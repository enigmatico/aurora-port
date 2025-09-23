// Decompiled with JetBrains decompiler
// Type: Aurora.AuroraTectonics
// Assembly: Aurora, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAB8E3AD-3A24-426F-849E-98EC2E2DD9EB
// Assembly location: C:\Users\jinhoon.kim\Desktop\Aurora250Full\Dedot\aurora-deop.exe

using System.ComponentModel;

#nullable disable
namespace Aurora;

public enum AuroraTectonics
{
  Dead = 1,
  [Description("Hot Spot")] HotSpot = 2,
  Plastic = 3,
  [Description("Plate Tectonics")] PlateTectonic = 4,
  [Description("Platelet Tectonics")] PlateletTectonic = 5,
  Extreme = 6,
}
