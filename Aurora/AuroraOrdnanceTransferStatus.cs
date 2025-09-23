// Decompiled with JetBrains decompiler
// Type: Aurora.AuroraOrdnanceTransferStatus
// Assembly: Aurora, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAB8E3AD-3A24-426F-849E-98EC2E2DD9EB
// Assembly location: C:\Users\jinhoon.kim\Desktop\Aurora250Full\Dedot\aurora-deop.exe

using System.ComponentModel;

#nullable disable
namespace Aurora;

public enum AuroraOrdnanceTransferStatus
{
  None,
  [Description("Load Fleet Ordnance")] LoadFleet,
  [Description("Replace Fleet Ordnance")] ReplaceFleet,
  [Description("Remove Fleet Ordnance")] RemoveFleet,
  [Description("Load Sub Fleet Ordnance")] LoadSubFleet,
  [Description("Replace Sub Fleet Ordnance")] ReplaceSubFleet,
  [Description("Remove Sub Fleet Ordnance")] RemoveSubFleet,
}
