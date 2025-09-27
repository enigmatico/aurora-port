// Decompiled with JetBrains decompiler
// Type: GClass49
// Assembly: Aurora, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAB8E3AD-3A24-426F-849E-98EC2E2DD9EB
// Assembly location: C:\Users\jinhoon.kim\Desktop\Aurora250Full\Dedot\aurora-deop.exe

using Aurora;

#nullable disable
public class AssignmentTypeFilter
{
    public AuroraCommanderType LeaderType = AuroraCommanderType.All;
    public AuroraCommandType ShipboardPosition;
    public int AssignmentTypeID;
    public int DisplayOrder;
    public int RankPriorityModifier;
    public bool IsForShip;
    public bool IsForTeam;
    public bool IsForPopulation;
    public bool IsForSector;
    public bool IsForGround;
    public bool IsForFighter;
    public bool IsForArmedShip;
    public bool IsForFreighters;
    public bool IsForNavalAdmin;
    public bool IsForSurvey;
    public bool IsForAcademy;

    public string Description { get; set; }
}