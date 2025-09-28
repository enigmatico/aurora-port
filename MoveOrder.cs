// Decompiled with JetBrains decompiler
// Type: GClass139
// Assembly: Aurora, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAB8E3AD-3A24-426F-849E-98EC2E2DD9EB
// Assembly location: C:\Users\jinhoon.kim\Desktop\Aurora250Full\Dedot\aurora-deop.exe

using System;

#nullable disable
public class MoveOrder
{
    public FleetData Fleet;
    public GameRace Race;
    public RacialSystemSurvey StartSystem;
    public RacialSystemSurvey NewSystem;
    public JumpPoint NewJumpPoint;
    public DestinationType DestinationType;
    public PopulationData Population;
    public MoveActionDefinition MoveActionType;
    public DestinationItemType DestinationItemType;
    public int MoveOrderID;
    public int OrderValue;
    public int DestinationID;
    public int Delay;
    public int DelayRemaining;
    public int OrbDistance;
    public int TimeRequired;
    public int DestinationItemID;
    public double MinDistance;
    public Decimal SurveyPointsRequired;
    public Decimal MaxItems;
    public Decimal MinQuantity;
    public string Description;
    public string MessageText = "";
    public bool bArrived;
    public bool bLoadSubUnits;
    public bool bool_2;

    public int method_0(int int_8)
    {
        try
        {
            if (this.TimeRequired > int_8)
            {
                this.TimeRequired -= int_8;
                return 0;
            }

            int num = int_8 - this.TimeRequired;
            this.TimeRequired = 0;
            return num;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 661);
            return int_8;
        }
    }
}