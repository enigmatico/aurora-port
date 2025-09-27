// Decompiled with JetBrains decompiler
// Type: GClass145
// Assembly: Aurora, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAB8E3AD-3A24-426F-849E-98EC2E2DD9EB
// Assembly location: C:\Users\jinhoon.kim\Desktop\Aurora250Full\Dedot\aurora-deop.exe

using System;

#nullable disable
public class TMoveOrder
{
    private GClass0 gclass0_0;
    public OrderTemplateData OrderTemplate;
    public RacialSystemSurvey StartSystem;
    public RacialSystemSurvey NewSystem;
    public PopulationData Population;
    public MoveActionDefinition MoveAction;
    public JumpPoint120 NewJumpPoint;
    public DestinationType DestinationType = DestinationType.const_1;
    public DestinationItemType DestinationItemType;
    public int MoveIndex;
    public int DestinationItemID;
    public int OrderDelay;
    public int DestinationID;
    public int OrbDistance;
    public double MinDistance;
    public Decimal MinQuantity;
    public Decimal MaxItems;
    public Decimal SurveyPointsRequired;
    public bool bLoadSubUnits;
    public string Description;
    public string MessageText = "";

    public TMoveOrder(GClass0 gclass0_1) => this.gclass0_0 = gclass0_1;

    public void method_0(FleetData gclass85_0)
    {
        try
        {
            MoveOrder gclass139 = new MoveOrder()
            {
                MoveOrderID = this.gclass0_0.method_26(GEnum0.const_37),
                OrderValue = this.MoveIndex,
                Fleet = gclass85_0,
                Race = this.StartSystem.Race,
                StartSystem = this.StartSystem,
                DestinationType = this.DestinationType,
                DestinationItemType = this.DestinationItemType,
                DestinationID = this.DestinationID,
                Population = this.Population,
                MoveActionType = this.MoveAction,
                NewSystem = this.NewSystem,
                NewJumpPoint = this.NewJumpPoint,
                MaxItems = this.MaxItems,
                MinDistance = this.MinDistance,
                MinQuantity = this.MinQuantity,
                Delay = this.OrderDelay
            };
            gclass139.DelayRemaining = gclass139.Delay;
            gclass139.OrbDistance = this.OrbDistance;
            gclass139.bLoadSubUnits = this.bLoadSubUnits;
            gclass139.SurveyPointsRequired = this.SurveyPointsRequired;
            gclass139.DestinationItemID = this.DestinationItemID;
            gclass139.MessageText = this.MessageText;
            gclass139.Description = this.Description;
            gclass85_0.MoveOrderDictionary.Add(gclass139.MoveOrderID, gclass139);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2082);
        }
    }
}