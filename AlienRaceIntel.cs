// Decompiled with JetBrains decompiler
// Type: GClass110
// Assembly: Aurora, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAB8E3AD-3A24-426F-849E-98EC2E2DD9EB
// Assembly location: C:\Users\jinhoon.kim\Desktop\Aurora250Full\Dedot\aurora-deop.exe

using Aurora;
using System;
using System.Collections.Generic;

#nullable disable
public class AlienRaceIntel
{
    private GClass0 gclass0_0;
    public Dictionary<int, Species> SpeciesIntels = new Dictionary<int, Species>();
    public Dictionary<int, StarSystem> SystemIntels = new Dictionary<int, StarSystem>();
    public Dictionary<int, AlienSensorIntel> dictionary_2 = new Dictionary<int, AlienSensorIntel>();
    public GameRace ActualAlienRace;
    public GameRace ViewingRace;
    public AuroraContactStatus ContactStatus;
    public AuroraCommStatus CommStatus;
    public NamingTheme ClassTheme;
    public int ActualAlienRaceID;
    public int FixedRelationShip;
    public int UseRealClassNames;
    public int RandomNameOrder = 1;
    public Decimal FirstDetected;
    public Decimal CommEstablished;
    public Decimal DiplomaticPoints;
    public Decimal CommModifier;
    public Decimal DamageCausedByAlienRace;
    public bool bTradeTreaty;
    public bool bTechTreaty;
    public bool bGeoTreaty;
    public bool bGravTreaty;
    public bool bPortraitShown;
    public bool bool_5;
    public string Abbreviation;
    public double AlienRaceIntelPoints;
    public bool bool_6 = true;

    public string AlienRaceName { get; set; }

    public AlienRaceIntel(GClass0 gclass0_1) => this.gclass0_0 = gclass0_1;

    public AlienRaceIntel method_0(GameRace gclass21_2)
    {
        try
        {
            AlienRaceIntel gclass110_1 = new AlienRaceIntel(this.gclass0_0);
            AlienRaceIntel gclass110_2 = (AlienRaceIntel)this.MemberwiseClone();
            gclass110_2.ViewingRace = gclass21_2;
            gclass110_2.SpeciesIntels = new Dictionary<int, Species>();
            gclass110_2.SystemIntels = new Dictionary<int, StarSystem>();
            gclass110_2.dictionary_2 = new Dictionary<int, AlienSensorIntel>();
            foreach (KeyValuePair<int, Species> keyValuePair in this.SpeciesIntels)
                gclass110_2.SpeciesIntels.Add(keyValuePair.Key, keyValuePair.Value);
            foreach (KeyValuePair<int, StarSystem> keyValuePair in this.SystemIntels)
                gclass110_2.SystemIntels.Add(keyValuePair.Key, keyValuePair.Value);
            foreach (AlienSensorIntel gclass118_1 in this.dictionary_2.Values)
            {
                AlienSensorIntel gclass118_2 = gclass118_1.method_2(gclass21_2);
                gclass118_2.AlienSensorID = this.gclass0_0.method_26(GEnum0.const_43);
                gclass110_2.dictionary_2.Add(gclass118_2.AlienSensorID, gclass118_2);
            }

            return gclass110_2;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 1893);
            return null;
        }
    }
}