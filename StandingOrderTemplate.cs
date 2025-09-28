// Decompiled with JetBrains decompiler
// Type: GClass135
// Assembly: Aurora, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAB8E3AD-3A24-426F-849E-98EC2E2DD9EB
// Assembly location: C:\Users\jinhoon.kim\Desktop\Aurora250Full\Dedot\aurora-deop.exe

using System.Collections.Generic;

#nullable disable
public class StandingOrderTemplate
{
    public int TemplateID;
    public string TemplateName;
    public Dictionary<int, StandingOrderDefinition> StandingOrders = new Dictionary<int, StandingOrderDefinition>();
    public Dictionary<int, FleetConditionalOrder> ConditionalOrders = new Dictionary<int, FleetConditionalOrder>();
}