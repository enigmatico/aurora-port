// Decompiled with JetBrains decompiler
// Type: GClass144
// Assembly: Aurora, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAB8E3AD-3A24-426F-849E-98EC2E2DD9EB
// Assembly location: C:\Users\jinhoon.kim\Desktop\Aurora250Full\Dedot\aurora-deop.exe

using System;
using System.Collections.Generic;
using System.Linq;

#nullable disable
public class OrderTemplateData
{
    public List<TMoveOrder> TMoveOrderList = new List<TMoveOrder>();
    private GClass0 gclass0_0;
    public FCTRaceRecordC21 RaceData;
    public RacialSystemSurvey RaceSystem;
    public int OrderTemplateID;
    public string TemplateName;

    public OrderTemplateData(GClass0 gclass0_1) => this.gclass0_0 = gclass0_1;

    public void method_0(FleetData gclass85_0)
    {
        try
        {
            gclass85_0.MoveOrderDictionary.Clear();
            this.TMoveOrderList = this.TMoveOrderList.OrderBy<TMoveOrder, int>(gclass145_0 => gclass145_0.MoveIndex).ToList<TMoveOrder>();
            foreach (TMoveOrder gclass145 in this.TMoveOrderList)
                gclass145.method_0(gclass85_0);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2080);
        }
    }

    public void method_1(FleetData gclass85_0)
    {
        try
        {
            foreach (MoveOrder gclass139 in gclass85_0.MoveOrderDictionary.Values)
                this.TMoveOrderList.Add(new TMoveOrder(this.gclass0_0)
                {
                    OrderTemplate = this,
                    MoveIndex = gclass139.OrderValue,
                    StartSystem = gclass139.StartSystem,
                    DestinationType = gclass139.DestinationType,
                    DestinationItemType = gclass139.DestinationItemType,
                    DestinationID = gclass139.DestinationID,
                    Population = gclass139.Population,
                    MoveAction = gclass139.MoveActionType,
                    NewSystem = gclass139.NewSystem,
                    NewJumpPoint = gclass139.NewJumpPoint,
                    MaxItems = gclass139.MaxItems,
                    MinDistance = gclass139.MinDistance,
                    MinQuantity = gclass139.MinQuantity,
                    OrderDelay = gclass139.Delay,
                    OrbDistance = gclass139.OrbDistance,
                    bLoadSubUnits = gclass139.bLoadSubUnits,
                    SurveyPointsRequired = gclass139.SurveyPointsRequired,
                    DestinationItemID = gclass139.DestinationItemID,
                    MessageText = gclass139.MessageText,
                    Description = gclass139.Description
                });
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2081);
        }
    }
}