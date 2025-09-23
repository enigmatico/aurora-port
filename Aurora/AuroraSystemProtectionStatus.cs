// Decompiled with JetBrains decompiler
// Type: Aurora.AuroraSystemProtectionStatus
// Assembly: Aurora, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAB8E3AD-3A24-426F-849E-98EC2E2DD9EB
// Assembly location: C:\Users\jinhoon.kim\Desktop\Aurora250Full\Dedot\aurora-deop.exe

using System.ComponentModel;

#nullable disable
namespace Aurora;

public enum AuroraSystemProtectionStatus
{
  [Description("No Protection")] NoProtection,
  [Description("Suggest Leave")] SuggestLeave,
  [Description("Request Leave")] RequestLeave,
  [Description("Request Leave Urgently")] RequestLeaveUrgently,
  [Description("Demand Leave")] DemandLeave,
  [Description("Demand Leave With Threat")] DemandLeaveWithThreat,
}
