// Decompiled with JetBrains decompiler
// Type: GClass1
// Assembly: Aurora, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAB8E3AD-3A24-426F-849E-98EC2E2DD9EB
// Assembly location: C:\Users\jinhoon.kim\Desktop\Aurora250Full\Dedot\aurora-deop.exe

using Aurora;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;
using aurora;

#nullable disable
public partial class SystemBodyData
{
    public Dictionary<AuroraElement, MineralDeposit> MineralDeposits = new Dictionary<AuroraElement, MineralDeposit>();
    public Dictionary<int, RaceSystemBodyName> dictionary_1 = new Dictionary<int, RaceSystemBodyName>();
    public List<SystemBodyAtmosphericGas> AtmosphericGasList = new List<SystemBodyAtmosphericGas>();
    public Dictionary<AuroraElement, Decimal> dictionary_2 = new Dictionary<AuroraElement, Decimal>();
    private GClass0 gclass0_0;
    public SystemBodyData ParentBodyData;
    public SystemBodyData FixedBodyParentData;
    public Star197 StarData;
    public StarSystem SystemData;
    public RuinRaceData RuinRaceData;
    public RuinDefinition RuinData;
    public AncientConstruct AncientConstruct;
    public Species gclass194_0;
    public PlanetBodyClass BodyClass;
    public AuroraSystemBodyType BodyTypeId;
    public ParentBodyType ParentBodyType;
    public AuroraHydrosphereType HydrosphereTypeId;
    public AuroraTectonics TectonicActivity;
    public PlanetaryTerrainDefinition DominantTerrain;
    public Unknown_SystemBodyDataUpdateLevel UnknownEnumDBUpdateNeedState = Unknown_SystemBodyDataUpdateLevel.FullUpdate; // 
    public AuroraGroundMineralSurvey GroundMineralSurveyState;
    public int SystemBodyID;
    public int SystemID;
    public int StarID;
    public int PlanetNumber;
    public int OrbitNumber;
    public int ParentBodyID;
    public int AsteroidBeltID;
    public int Tilt;
    public int RuinID;
    public int RuinRaceID;
    public int AbandonedFactories;
    public int FixedBodyParentID;
    public Decimal ColonyCost = -2M;
    public Decimal MaxColonyCost = -2M;
    public Decimal decimal_2;
    public Decimal RadiationLevel;
    public Decimal DustLevel;
    public Decimal PopulationCapacity_Probably;
    public double XCoordinate;
    public double YCoordinate;
    public double OrbitalDistance;
    public double BaseTemp;
    public double SurfaceTemp;
    public double Bearing;
    public double Density;
    public double Gravity;
    public double Mass;
    public double Escape;
    public double Year;
    public double TidalForce;
    public double Day;
    public double Roche;
    public double MagneticField;
    public double AtmospherePressure;
    public double Albedo = 1.0;
    public double GreenhouseFactor = 1.0;
    public double AntiGreenhouseFactor = 1.0;
    public double HydroExtent;
    public double Radius;
    public double TrojanOffset;
    public double CurrentOrbitalSpeed;
    public double MeanOrbitalSpeed;
    public double Eccentricity;
    public double EccentricityDirection;
    public double OrbitalSemiMinorAxis;
    public double double_27;
    public double double_28;
    public double double_29;
    public double double_30;
    public double double_31;
    public double double_32;
    public double double_33;
    public double double_34 = -2.0;
    public double double_35 = -2.0;
    public double DistanceToOrbitCentre;
    public double DistanceToParent;
    public bool TidalLock;
    public bool Ring;
    public bool IsFixedBody;
    public string Name;
    public string PlanetIcon;
    public List<AuroraSystemBodyType> list_1 = new List<AuroraSystemBodyType>();
    public GEnum4 genum4_0;
    public int int_12;
    public double double_38;
    public double double_39;
    public double double_40;
    public double double_41;
    public bool bool_3;
    public bool bool_4;
    public bool bool_5;
    public bool bool_6;
    public bool bool_7;
    public bool bool_8;
    public Decimal decimal_6;
    public Decimal decimal_7;
    public string string_2 = "";
    public double double_42;
    public double double_43;
    public double double_44;
    public Decimal decimal_8 = 1M;
    public bool bool_9;
    public Decimal decimal_9;

    public SystemBodyData(GClass0 gclass0_1) => this.gclass0_0 = gclass0_1;

    public void method_0(
        ListView listView_0,
        GameRace gclass21_0,
        Species gclass194_1,
        int int_13)
    {
        try
        {
            listView_0.Items.Clear();
            if (this.Eccentricity == 0.0)
                return;
            var periodTxt = UITextHelper.GetLocalizedStringFor(LocalizedText.SystemBodyPeriod);
            this.gclass0_0.method_624(listView_0, periodTxt, "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11",
                "12", null);
            switch (int_13)
            {
                case 7:
                    listView_0.Columns[8].Width = 0;
                    listView_0.Columns[9].Width = 0;
                    listView_0.Columns[10].Width = 0;
                    listView_0.Columns[11].Width = 0;
                    listView_0.Columns[12].Width = 0;
                    break;
                case 8:
                    listView_0.Columns[8].Width = 50;
                    listView_0.Columns[9].Width = 0;
                    listView_0.Columns[10].Width = 0;
                    listView_0.Columns[11].Width = 0;
                    listView_0.Columns[12].Width = 0;
                    break;
                case 12:
                    listView_0.Columns[8].Width = 50;
                    listView_0.Columns[9].Width = 50;
                    listView_0.Columns[10].Width = 50;
                    listView_0.Columns[11].Width = 50;
                    listView_0.Columns[12].Width = 50;
                    break;
            }

            double num1 = this.Year * 3600.0;
            double double_45_1 = 604800.0;
            var timeSpan = LocalizedText.TimeSpanWeek;
            string text = UITextHelper.GetLocalizedStringFor(timeSpan);
            if (this.BodyClass == PlanetBodyClass.Moon)
                num1 = this.ParentBodyData.Year * 3600.0;
            do
            {
                List<double> doubleList1 = new List<double>();
                List<double> doubleList2 = new List<double>();
                double num2 = 0.0;
                foreach (double double_45_2 in this.BodyClass != PlanetBodyClass.Moon
                             ? this.method_1(gclass21_0, gclass194_1, double_45_1, int_13)
                             : this.ParentBodyData.method_1(gclass21_0, gclass194_1, double_45_1, int_13))
                {
                    double num3 = this.method_52(gclass21_0, gclass194_1, double_45_2, GEnum81.const_0);
                    doubleList2.Add(num3);
                }

                ListViewItem listViewItem = new ListViewItem(text);
                foreach (double double_32 in doubleList2)
                {
                    listViewItem.SubItems.Add(AuroraUtils.smethod_46(double_32, 2));
                    num2 += double_45_1;
                    if (num2 > num1)
                        break;
                }

                listView_0.Items.Add(listViewItem);
                switch (timeSpan)
                {
                    case LocalizedText.TimeSpanWeek:
                        timeSpan = LocalizedText.TimeSpanMonth;
                        text = UITextHelper.GetLocalizedStringFor(timeSpan);
                        double_45_1 = (double)AuroraUtils.decimal_29 / 12.0;
                        break;
                    case LocalizedText.TimeSpanMonth:
                        timeSpan = LocalizedText.TimeSpanQuarter;
                        text = UITextHelper.GetLocalizedStringFor(timeSpan);
                        double_45_1 = (double)AuroraUtils.decimal_29 / 4.0;
                        break;
                    case LocalizedText.TimeSpanQuarter:
                        timeSpan = LocalizedText.TimeSpanYear;
                        text = UITextHelper.GetLocalizedStringFor(timeSpan);
                        double_45_1 = (double)AuroraUtils.decimal_29;
                        break;
                    case LocalizedText.TimeSpanYear:
                        timeSpan = LocalizedText.TimeSpan5Y;
                        text = UITextHelper.GetLocalizedStringFor(timeSpan);
                        double_45_1 = (double)AuroraUtils.decimal_29 * 5.0;
                        break;
                    case LocalizedText.TimeSpan5Y:
                        timeSpan = LocalizedText.TimeSpan25Y;
                        text = UITextHelper.GetLocalizedStringFor(timeSpan);
                        double_45_1 = (double)AuroraUtils.decimal_29 * 25.0;
                        break;
                    case LocalizedText.TimeSpan25Y:
                        timeSpan = LocalizedText.TimeSpan100Y;
                        text = UITextHelper.GetLocalizedStringFor(timeSpan);
                        double_45_1 = (double)AuroraUtils.decimal_29 * 100.0;
                        break;
                    default:
                        goto label_25;
                }
            } while (double_45_1 <= num1);

            goto label_15;
            label_25:
            return;
            label_15: ;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3461);
        }
    }

    public List<double> method_1(
        GameRace gclass21_0,
        Species gclass194_1,
        double double_45,
        int int_13)
    {
        try
        {
            List<double> doubleList = new List<double>();
            double num1 = this.Year * 3600.0;
            double double5 = this.Bearing;
            double double37 = this.DistanceToParent;
            double double36 = this.DistanceToOrbitCentre;
            double num2 = this.CurrentOrbitalSpeed;
            for (int index = 0; index < int_13; ++index)
            {
                if (this.MeanOrbitalSpeed == 0.0)
                    this.MeanOrbitalSpeed = num2;
                double num3 = num2 / this.MeanOrbitalSpeed;
                double num4 = double_45 / num1 * num3;
                double5 -= num4 * 360.0;
                while (double5 < 0.0)
                    double5 += 360.0;
                double num5;
                if (double5 != 0.0 && double5 != 180.0)
                {
                    if (double5 != 90.0 && double5 != 270.0)
                    {
                        double num6 = 360.0 - this.Bearing + 90.0;
                        if (num6 < 0.0)
                            num6 += 360.0;
                        if (num6 == 360.0)
                            num6 = 0.0;
                        if (num6 > 360.0)
                            num6 -= 360.0;
                        num5 = this.OrbitalDistance * this.OrbitalSemiMinorAxis / Math.Sqrt(
                            Math.Pow(this.OrbitalSemiMinorAxis * Math.Cos(num6 * Math.PI / 180.0), 2.0) +
                            Math.Pow(this.OrbitalDistance * Math.Sin(num6 * Math.PI / 180.0), 2.0));
                    }
                    else
                        num5 = this.OrbitalDistance;
                }
                else
                    num5 = this.OrbitalSemiMinorAxis;

                double num7 = double5 - 90.0;
                if (num7 < 0.0)
                    num7 += 360.0;
                double double25 = this.EccentricityDirection;
                if (double25 < 0.0)
                    double25 += 360.0;
                double num8 = double25 * (Math.PI / 180.0);
                double num9 = (this.double_28 - this.double_27) / 2.0;
                double num10 = this.StarData.XCoord + num9 * AuroraUtils.double_14 * Math.Cos(num8);
                double num11 = this.StarData.YCoord + num9 * AuroraUtils.double_14 * Math.Sin(num8);
                double num12 = num7 + this.EccentricityDirection;
                if (num12 >= 360.0)
                    num12 -= 360.0;
                double num13 = num12 * (Math.PI / 180.0);
                double double_8 = num10 + num5 * AuroraUtils.double_14 * Math.Cos(num13);
                double num14 = num5 * AuroraUtils.double_14 * Math.Sin(num13);
                double double_9 = num11 + num14;
                double num15 =
                    this.gclass0_0.GetDistanceBetween(double_8, double_9, this.StarData.XCoord, this.StarData.YCoord) /
                    AuroraUtils.double_14;
                num2 = Math.Sqrt(2.0 / num15 - 1.0 / this.OrbitalDistance);
                doubleList.Add(num15);
            }

            return doubleList;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3459);
            return null;
        }
    }

    public void method_2(SystemBodyData gclass1_2)
    {
        try
        {
            if (gclass1_2.Radius < 1000.0)
                this.list_1.Add(AuroraSystemBodyType.Moon);
            else if (gclass1_2.Radius < 2000.0)
                this.list_1.Add(AuroraSystemBodyType.LargeMoon);
            else if (gclass1_2.Radius < 3000.0)
                this.list_1.Add(AuroraSystemBodyType.SmallTerrestrial);
            else
                this.list_1.Add(AuroraSystemBodyType.TerrestrialMoon);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3448);
        }
    }

    public void method_3(PlanetBodyClass genum12_1)
    {
        try
        {
            this.double_27 = this.OrbitalDistance;
            this.double_28 = this.OrbitalDistance;
            this.OrbitalSemiMinorAxis = this.OrbitalDistance;
            if (this.gclass0_0.StarEccentricity == 0)
            {
                this.Eccentricity = 0.0;
                this.EccentricityDirection = 0.0;
            }
            else
            {
                double double6 = this.StarData.double_6;
                if (this.StarData.Component == 1)
                    double6 *= 1.5;
                double num1 = 0.999;
                if (double6 < this.OrbitalDistance * 2.0)
                    num1 = double6 / this.OrbitalDistance - 1.0;
                this.EccentricityDirection = AuroraUtils.GetRandomInteger(3600) / 10;
                int num2 = 0;
                do
                {
                    int num3 = AuroraUtils.GetRandomInteger(10);
                    switch (genum12_1)
                    {
                        case PlanetBodyClass.Planet:
                            this.Eccentricity = num3 >= 6
                                ? (num3 >= 8
                                    ? (num3 >= 10
                                        ? 0.25 + AuroraUtils.GetRandomInteger(10) * 0.04
                                        : 0.15 + AuroraUtils.GetRandomInteger(10) * 0.01)
                                    : 0.05 + AuroraUtils.GetRandomInteger(10) * 0.01)
                                : AuroraUtils.GetRandomInteger(10) * 0.005;
                            break;
                        case PlanetBodyClass.Asteroid:
                            this.Eccentricity = num3 >= 6
                                ? (num3 >= 8
                                    ? (num3 >= 10
                                        ? 0.4 + AuroraUtils.GetRandomInteger(40) * 0.01
                                        : 0.3 + AuroraUtils.GetRandomInteger(10) * 0.01)
                                    : 0.2 + AuroraUtils.GetRandomInteger(10) * 0.01)
                                : AuroraUtils.GetRandomInteger(20) * 0.01;
                            break;
                        case PlanetBodyClass.Comet:
                            switch (num3)
                            {
                                case 1:
                                    this.Eccentricity = 0.5 + AuroraUtils.GetRandomInteger(10) * 0.01;
                                    break;
                                case 2:
                                    this.Eccentricity = 0.6 + AuroraUtils.GetRandomInteger(10) * 0.01;
                                    break;
                                case 3:
                                    this.Eccentricity = 0.7 + AuroraUtils.GetRandomInteger(10) * 0.01;
                                    break;
                                default:
                                    this.Eccentricity = num3 >= 6
                                        ? (num3 >= 9
                                            ? 0.99 + AuroraUtils.GetRandomInteger(9) * 0.001
                                            : 0.9 + AuroraUtils.GetRandomInteger(9) * 0.01)
                                        : 0.8 + AuroraUtils.GetRandomInteger(10) * 0.01;
                                    break;
                            }

                            break;
                    }

                    this.double_27 = this.OrbitalDistance * (1.0 - this.Eccentricity);
                    this.double_28 = this.OrbitalDistance * (1.0 + this.Eccentricity);
                    if (genum12_1 != PlanetBodyClass.Comet &&
                        (this.double_27 <= this.StarData.StellarType.Radius * AuroraUtils.double_7 ||
                         this.double_28 >= double6 && double6 != 0.0))
                        ++num2;
                    else
                        goto label_18;
                } while (num2 != 10);

                this.Eccentricity = num1;
                this.double_27 = this.OrbitalDistance * (1.0 - this.Eccentricity);
                this.double_28 = this.OrbitalDistance * (1.0 + this.Eccentricity);
                label_18:
                this.OrbitalSemiMinorAxis = this.OrbitalDistance * Math.Sqrt(1.0 - this.Eccentricity * this.Eccentricity);
                this.method_5();
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3446);
        }
    }

    public void method_4()
    {
        try
        {
            int num = 0;
            if (this.Eccentricity > 0.95)
                this.Eccentricity = 0.95;
            double double6 = this.StarData.double_6;
            if (this.StarData.Component == 1)
                double6 *= 1.5;
            do
            {
                this.double_27 = this.OrbitalDistance * (1.0 - this.Eccentricity);
                this.double_28 = this.OrbitalDistance * (1.0 + this.Eccentricity);
                if (this.double_27 <= this.StarData.StellarType.Radius * AuroraUtils.double_7 ||
                    this.double_28 >= double6 && double6 != 0.0)
                {
                    this.Eccentricity -= 0.01;
                    ++num;
                }
                else
                    goto label_7;
            } while (num != 100);

            this.Eccentricity = 0.0;
            label_7:
            this.OrbitalSemiMinorAxis = this.OrbitalDistance * Math.Sqrt(1.0 - this.Eccentricity * this.Eccentricity);
            this.method_5();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3446);
        }
    }

    public void method_5()
    {
        try
        {
            this.MeanOrbitalSpeed = Math.Sqrt(2.0 / this.OrbitalDistance - 1.0 / this.OrbitalDistance);
            this.CurrentOrbitalSpeed = this.MeanOrbitalSpeed;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3443);
        }
    }

    public void method_6()
    {
        try
        {
            this.CurrentOrbitalSpeed = Math.Sqrt(2.0 / this.DistanceToParent - 1.0 / this.OrbitalDistance);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3444);
        }
    }

    public void RecalculateDistanceToOrbitCentreFromBearing()
    {
        try
        {
            if (this.Bearing != 0.0 && this.Bearing != 180.0)
            {
                if (this.Bearing != 90.0 && this.Bearing != 270.0)
                {
                    double num = 360.0 - this.Bearing + 90.0;
                    if (num < 0.0)
                        num += 360.0;
                    if (num >= 360.0)
                        num -= 360.0;
                    this.DistanceToOrbitCentre = this.OrbitalDistance * this.OrbitalSemiMinorAxis / Math.Sqrt(
                        Math.Pow(this.OrbitalSemiMinorAxis * Math.Cos(num * Math.PI / 180.0), 2.0) +
                        Math.Pow(this.OrbitalDistance * Math.Sin(num * Math.PI / 180.0), 2.0));
                }
                else
                    this.DistanceToOrbitCentre = this.OrbitalDistance;
            }
            else
                this.DistanceToOrbitCentre = this.OrbitalSemiMinorAxis;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3450);
        }
    }

    public void method_8(bool bool_10)
    {
        try
        {
            if (this.UnknownEnumDBUpdateNeedState != Unknown_SystemBodyDataUpdateLevel.FullUpdate)
                this.UnknownEnumDBUpdateNeedState = Unknown_SystemBodyDataUpdateLevel.ExtendedUpdate;
            if (bool_10)
            {
                this.Mass = Math.Pow(this.Radius / 6380.0, 3.0) * this.Density;
                this.Gravity = this.Mass / Math.Pow(this.Radius / 6380.0, 2.0);
                if (this.Gravity < 0.0001)
                    this.Gravity = 0.0001;
                this.Escape = Math.Pow(19600.0 * this.Gravity * this.Radius, 0.5) / 11200.0;
            }

            this.TidalLock = false;
            if (this.BodyClass != PlanetBodyClass.Moon)
            {
                this.Year = Math.Pow(Math.Pow(this.OrbitalDistance, 3.0) / this.StarData.StellarType.Mass, 0.5) *
                            8760.0;
                this.TidalForce = this.StarData.StellarType.Mass * 26640000.0 /
                                  Math.Pow(this.OrbitalDistance * 400.0, 3.0);
                if (this.Year == 0.0)
                    this.Year = 1.0;
                if ((0.83 + AuroraUtils.GetRandomInteger(10) * 0.03) * this.TidalForce * this.SystemData.Age / 6.6 >
                    1.0)
                    this.TidalLock = true;
                this.BaseTemp = byte.MaxValue /
                                Math.Pow(this.DistanceToParent / Math.Pow(this.StarData.Luminosity, 0.5), 0.5);
                if (this.BaseTemp < 4.0)
                    this.BaseTemp = 4.0;
            }
            else
            {
                this.Year = Math.Pow(
                                Math.Pow(this.OrbitalDistance / 398600.0, 3.0) *
                                (837.0 / (this.Mass + this.ParentBodyData.Mass)), 0.5) *
                            24.0;
                if (this.Year == 0.0)
                    this.Year = 1.0;
                this.TidalForce = this.ParentBodyData.Mass * 80.0 / Math.Pow(this.OrbitalDistance / 375000.0, 3.0);
                if (this.TidalForce > 7.0)
                    this.TidalLock = true;
                this.BaseTemp = this.ParentBodyData.BaseTemp;
            }

            if (this.TidalLock)
                this.Tilt = 0;
            this.method_36(null);
            this.method_35();
            this.method_32();
            this.method_41(this.Bearing);
            LagrangePoint gclass212 =
                this.gclass0_0.LagrangePoints.Values.FirstOrDefault<LagrangePoint>(gclass212_0 =>
                    gclass212_0.Planet == this);
            gclass212?.method_1(gclass212.Planet.Bearing + 60.0);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3004);
        }
    }

    public void method_9(AtmosphericGasDefinition gclass223_0, double double_45, PopulationData gclass146_0)
    {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        SystemBodyData.Class308 class308 = new SystemBodyData.Class308();
        // ISSUE: reference to a compiler-generated field
        class308.gclass223_0 = gclass223_0;
        try
        {
            GameRace gclass21_0 = null;
            // ISSUE: reference to a compiler-generated method
            SystemBodyAtmosphericGas gclass224 = this.AtmosphericGasList.Where<SystemBodyAtmosphericGas>(class308.method_0).FirstOrDefault<SystemBodyAtmosphericGas>();
            if (double_45 == 0.0)
            {
                if (gclass224 == null)
                    return;
                this.AtmosphericGasList.Remove(gclass224);
            }
            else if (gclass224 == null)
            {
                // ISSUE: reference to a compiler-generated field
                this.AtmosphericGasList.Add(new SystemBodyAtmosphericGas()
                {
                    Gas = class308.gclass223_0,
                    SystemBodyID = this.SystemBodyID,
                    GasAtm = double_45,
                    AtmoGasAmount = 0.0,
                    FrozenOut = false
                });
            }
            else
                gclass224.GasAtm = double_45;

            this.method_46();
            if (gclass146_0 != null)
            {
                this.method_58(gclass146_0.Race, gclass146_0.Species, false);
                gclass146_0.ColonyCost = this.ColonyCost;
                gclass146_0.MaxColonyCost = this.MaxColonyCost;
                gclass146_0.method_184();
                gclass21_0 = gclass146_0.Race;
            }

            this.method_36(gclass21_0);
            this.method_35();
            this.method_32();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3005);
        }
    }

    public void method_10()
    {
        try
        {
            double num1 = this.HydroExtent / AuroraUtils.double_27;
            SystemBodyAtmosphericGas gclass224 = this.AtmosphericGasList.FirstOrDefault<SystemBodyAtmosphericGas>(gclass224_0 =>
                gclass224_0.Gas.Type == GasType.WaterVapor);
            if (gclass224 == null)
            {
                this.AtmosphericGasList.Add(new SystemBodyAtmosphericGas()
                {
                    Gas = this.gclass0_0.AtmosphericGasDictionary[GasType.WaterVapor],
                    SystemBodyID = this.SystemBodyID,
                    GasAtm = num1,
                    AtmoGasAmount = 0.0,
                    FrozenOut = false
                });
                this.AtmospherePressure += num1;
            }
            else if (gclass224.GasAtm < num1)
            {
                double num2 = num1 - gclass224.GasAtm;
                gclass224.GasAtm += num2;
                this.AtmospherePressure += num2;
                if (this.AtmospherePressure < 0.0)
                    this.AtmospherePressure = 0.0;
            }

            this.HydroExtent = 0.0;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3006);
        }
    }

    public void method_11()
    {
        try
        {
            SystemBodyAtmosphericGas gclass224 = this.AtmosphericGasList.FirstOrDefault<SystemBodyAtmosphericGas>(gclass224_0 =>
                gclass224_0.Gas.Type == GasType.WaterVapor);
            if (gclass224 == null)
                return;
            double num1 = this.AtmospherePressure * (this.HydroExtent / 100.0) * AuroraUtils.double_26;
            if (gclass224.GasAtm <= num1)
                return;
            double num2 = gclass224.GasAtm - num1;
            gclass224.GasAtm -= num2;
            this.HydroExtent += num2 * AuroraUtils.double_27;
            this.AtmospherePressure -= num2;
            if (this.AtmospherePressure < 0.0)
                this.AtmospherePressure = 0.0;
            if (gclass224.GasAtm > 0.0)
                return;
            this.AtmosphericGasList.Remove(gclass224);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3007);
        }
    }

    public void method_12(GEnum59 genum59_0, GEnum59 genum59_1, GameRace gclass21_0)
    {
        try
        {
            this.decimal_6 = 0M;
            this.decimal_7 = 0M;
            switch (genum59_0)
            {
                case GEnum59.const_1:
                    this.decimal_6 = (Decimal)this.OrbitalDistance;
                    break;
                case GEnum59.const_2:
                    this.decimal_6 = this.ColonyCost;
                    break;
                case GEnum59.const_3:
                    this.decimal_6 = (Decimal)this.HydroExtent;
                    break;
                case GEnum59.const_4:
                    if (this.method_77(gclass21_0))
                    {
                        this.decimal_6 = this.MineralDeposits.Values.Sum<MineralDeposit>(gclass124_0 => gclass124_0.Amount);
                        break;
                    }

                    break;
            }

            switch (genum59_1)
            {
                case GEnum59.const_1:
                    this.decimal_7 = (Decimal)this.OrbitalDistance;
                    break;
                case GEnum59.const_2:
                    this.decimal_7 = this.ColonyCost;
                    break;
                case GEnum59.const_3:
                    this.decimal_7 = (Decimal)this.HydroExtent;
                    break;
                case GEnum59.const_4:
                    if (this.method_77(gclass21_0))
                    {
                        this.decimal_7 = this.MineralDeposits.Values.Sum<MineralDeposit>(gclass124_0 => gclass124_0.Amount);
                        break;
                    }

                    break;
            }

            this.string_2 = gclass21_0.method_277(this.SystemData.SystemID);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3008);
        }
    }

    public bool method_13()
    {
        try
        {
            foreach (SystemBodyAtmosphericGas gclass224 in this.AtmosphericGasList)
            {
                if (gclass224.Gas.Type == GasType.Oxygen)
                    return true;
            }

            return false;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3009);
            return false;
        }
    }

    public bool method_14(Species gclass194_1)
    {
        try
        {
            foreach (SystemBodyAtmosphericGas gclass224 in this.AtmosphericGasList)
            {
                if (gclass224.Gas.Dangerous > 0 && gclass224.Gas != gclass194_1.gclass223_0)
                    return true;
            }

            return false;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3835);
            return false;
        }
    }

    public int method_15(double double_45)
    {
        try
        {
            this.OrbitalDistance -= double_45;
            LagrangePoint gclass212 =
                this.gclass0_0.LagrangePoints.Values.FirstOrDefault<LagrangePoint>(gclass212_0 =>
                    gclass212_0.Planet == this);
            if (gclass212 != null)
                gclass212.Distance = this.OrbitalDistance;
            if (this.OrbitalDistance * AuroraUtils.double_14 < 1000000.0)
            {
                foreach (PopulationData gclass146_1 in this.gclass0_0.Populations.Values
                             .Where<PopulationData>(gclass146_0 =>
                                 gclass146_0.SystemBodyData == this || gclass146_0.SystemBodyData.ParentBodyData == this)
                             .ToList<PopulationData>())
                {
                    this.gclass0_0.gclass92_0.method_2(EventType.const_192,
                        $"{gclass146_1.PopName} has been destroyed due to the destruction of the body on which it is based",
                        gclass146_1.Race, this.SystemData, this.XCoordinate, this.YCoordinate,
                        AuroraEventCategory.PopSummary);
                    gclass146_1.Race.method_132(gclass146_1);
                }

                if (gclass212 != null)
                    this.gclass0_0.LagrangePoints.Remove(gclass212.LaGrangePointID);
                return -1;
            }

            this.Year = Math.Pow(Math.Pow(this.OrbitalDistance, 3.0) / this.StarData.StellarType.Mass, 0.5) *
                        8760.0;
            this.gclass0_0.method_414(10.0, null, this, true);
            foreach (SystemBodyData gclass1 in this.gclass0_0.SystemBodyRecordDic.Values
                         .Where<SystemBodyData>(gclass1_2 => gclass1_2.ParentBodyData == this)
                         .ToList<SystemBodyData>())
            {
                gclass1.BaseTemp = this.BaseTemp;
                gclass1.method_27();
            }

            return 0;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3010);
            return 0;
        }
    }

    public bool method_16(int int_13, bool bool_10)
    {
        try
        {
            if (!this.StarData.method_6(int_13))
                return false;
            return this.BodyClass != PlanetBodyClass.Asteroid && this.BodyClass != PlanetBodyClass.Comet
                ? (this.BodyClass == PlanetBodyClass.Planet
                    ? bool_10 && this.double_28 < int_13 || this.double_28 < int_13 &&
                    this.BodyTypeId != AuroraSystemBodyType.GasGiant &&
                    this.BodyTypeId != AuroraSystemBodyType.Superjovian
                    : (this.BodyClass == PlanetBodyClass.Moon
                        ? this.ParentBodyData.OrbitalDistance < int_13
                        : this.BodyClass == PlanetBodyClass.Comet && this.double_28 < int_13))
                : this.double_28 < int_13;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3011);
            return false;
        }
    }

    public double method_17()
    {
        try
        {
            if (this.MineralDeposits.Count == 0 || this.BodyTypeId == AuroraSystemBodyType.GasGiant ||
                this.BodyTypeId == AuroraSystemBodyType.Superjovian)
                return 0.0;
            double num = 0.0;
            foreach (MineralDeposit gclass124 in this.MineralDeposits.Values)
            {
                if (!(gclass124.Amount < 1000M))
                {
                    double decimal1 = (double)gclass124.Accessibility;
                    if (gclass124.Amount > 1000000M)
                        decimal1 *= 2.0;
                    else if (gclass124.Amount > 100000M)
                        decimal1 *= 1.5;
                    else if (gclass124.Amount > 10000M)
                        decimal1 *= 1.25;
                    num += decimal1;
                }
            }

            return num;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3012);
            return 0.0;
        }
    }

    public Decimal method_18()
    {
        try
        {
            return this.MineralDeposits.Values.Sum<MineralDeposit>(gclass124_0 => gclass124_0.Accessibility);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3013);
            return 0M;
        }
    }

    public MineralDeposit method_19(AuroraElement auroraElement_0)
    {
        try
        {
            return !this.MineralDeposits.ContainsKey(auroraElement_0) ? null : this.MineralDeposits[auroraElement_0];
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3014);
            return null;
        }
    }

    public Decimal method_20(AuroraElement auroraElement_0)
    {
        try
        {
            return !this.MineralDeposits.ContainsKey(auroraElement_0) ? 0M : this.MineralDeposits[auroraElement_0].Amount;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3015);
            return 0M;
        }
    }

    public Decimal method_21(AuroraElement auroraElement_0)
    {
        try
        {
            return !this.MineralDeposits.ContainsKey(auroraElement_0) ? 0M : this.MineralDeposits[auroraElement_0].Accessibility;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3016);
            return 0M;
        }
    }

    public Species method_22(
        bool bool_10,
        GameRace gclass21_0,
        SpecialNPRIDs genum6_0,
        GClass143 gclass143_0)
    {
        try
        {
            double num1;
            double num2;
            if (this.BodyClass == PlanetBodyClass.Moon)
            {
                num1 = this.method_53(this.ParentBodyData.double_28);
                num2 = this.method_53(this.ParentBodyData.double_27);
            }
            else
            {
                num1 = this.method_53(this.double_28);
                num2 = this.method_53(this.double_27);
            }

            double num3 = (num1 + num2) / 2.0;
            double num4 = num2 - num3 + 1.0;
            Species species = new Species(this.gclass0_0)
            {
                int_0 = this.gclass0_0.method_26(GEnum0.const_12),
                gclass223_0 = this.gclass0_0.AtmosphericGasDictionary[GasType.Oxygen]
            };
            species.double_0 = this.method_45(species.gclass223_0);
            species.double_3 = num3;
            species.double_5 = this.Gravity;
            species.gclass1_0 = this;
            species.genum6_0 = genum6_0;
            if (gclass143_0 != null)
            {
                species.int_7 = gclass143_0.int_5;
                species.int_3 = gclass143_0.int_1;
                species.int_5 = gclass143_0.int_3;
                species.int_6 = gclass143_0.int_4;
                species.int_2 = gclass143_0.int_0;
                species.int_8 = gclass143_0.int_6;
                species.int_4 = gclass143_0.int_2;
            }
            else
            {
                species.int_7 = AuroraUtils.GetRandomInteger(25) + AuroraUtils.GetRandomInteger(25) +
                                  AuroraUtils.GetRandomInteger(25) + AuroraUtils.GetRandomInteger(25);
                species.int_3 = AuroraUtils.GetRandomInteger(25) + AuroraUtils.GetRandomInteger(25) +
                                  AuroraUtils.GetRandomInteger(25) + AuroraUtils.GetRandomInteger(25);
                species.int_5 = AuroraUtils.GetRandomInteger(25) + AuroraUtils.GetRandomInteger(25) +
                                  AuroraUtils.GetRandomInteger(25) + AuroraUtils.GetRandomInteger(25);
                species.int_6 = AuroraUtils.GetRandomInteger(25) + AuroraUtils.GetRandomInteger(25) +
                                  AuroraUtils.GetRandomInteger(25) + AuroraUtils.GetRandomInteger(25);
                species.int_2 = AuroraUtils.GetRandomInteger(25) + AuroraUtils.GetRandomInteger(25) +
                                  AuroraUtils.GetRandomInteger(25) + AuroraUtils.GetRandomInteger(25);
                species.int_8 = AuroraUtils.GetRandomInteger(25) + AuroraUtils.GetRandomInteger(25) +
                                  AuroraUtils.GetRandomInteger(25) + AuroraUtils.GetRandomInteger(25);
                species.int_4 = AuroraUtils.smethod_21(5) + AuroraUtils.GetRandomInteger(6) - 31 /*0x1F*/;
            }

            if (gclass21_0.NPR && genum6_0 == SpecialNPRIDs.const_0)
            {
                species.int_2 += this.gclass0_0.HostilityModifier;
                species.int_5 += this.gclass0_0.HostilityModifier;
                species.int_8 -= this.gclass0_0.HostilityModifier;
                species.int_3 -= this.gclass0_0.HostilityModifier;
                if (species.int_2 > 100)
                    species.int_2 = 100;
                if (species.int_5 > 100)
                    species.int_5 = 100;
                if (species.int_8 < 1)
                    species.int_8 = 1;
                if (species.int_3 < 1)
                    species.int_3 = 1;
            }

            if (bool_10)
            {
                species.double_1 = species.double_0 * 0.5;
                species.double_4 = 24.0;
                species.double_6 = species.double_5 * 0.9;
                species.double_2 = 4.0;
                species.SpeciesName = UITextHelper.GetLocalizedStringFor(LocalizedText.SpeciesNameHuman);
                species.RaceImageFileName = "Race327.bmp";
            }
            else
            {
                switch (genum6_0)
                {
                    case SpecialNPRIDs.Precursor:
                        species.double_0 = 0.3;
                        species.double_1 = species.double_0 * 0.9;
                        species.double_3 = 280.0;
                        species.double_4 = 50.0;
                        species.double_5 = 1.5;
                        species.double_6 = species.double_5 * 0.95;
                        species.double_2 = 10.0;
                        species.SpeciesName = UITextHelper.GetLocalizedStringFor(LocalizedText.SpeciesNamePrecursor);
                        species.RaceImageFileName = "Race087.bmp";
                        species.int_7 = 100;
                        species.int_3 = 20;
                        species.int_5 = 100;
                        species.int_6 = 50;
                        species.int_2 = 100;
                        species.int_8 = 20;
                        species.int_4 = 0;
                        break;
                    case SpecialNPRIDs.StarSwarm:
                        species.double_0 = 0.3;
                        species.double_1 = species.double_0 * 0.9;
                        species.double_3 = 280.0;
                        species.double_4 = 100.0;
                        species.double_5 = 2.0;
                        species.double_6 = species.double_5 * 0.95;
                        species.double_2 = 20.0;
                        species.SpeciesName = UITextHelper.GetLocalizedStringFor(LocalizedText.SpeciesNameStarSwarm); //;"Star Swarm";
                        species.RaceImageFileName = "Race356.bmp";
                        species.int_7 = 100;
                        species.int_3 = 1;
                        species.int_5 = 100;
                        species.int_6 = 100;
                        species.int_2 = 100;
                        species.int_8 = 1;
                        species.int_4 = 0;
                        break;
                    case SpecialNPRIDs.Rakhas:
                        species.double_0 = 0.15;
                        species.double_1 = species.double_0 * 0.9;
                        species.double_3 = 280.0;
                        species.double_4 = 60.0;
                        species.double_5 = 1.5;
                        species.double_6 = species.double_5 * 0.95;
                        species.double_2 = 10.0;
                        species.SpeciesName = string.Format(UITextHelper.GetLocalizedStringFor(LocalizedText.SpeciesNameRakhas), this.SystemBodyID);
                        species.RaceImageFileName = "Race028.bmp";
                        species.int_7 = 100;
                        species.int_3 = 0;
                        species.int_5 = 100;
                        species.int_6 = 50;
                        species.int_2 = 100;
                        species.int_8 = 0;
                        species.int_4 = 0;
                        break;
                    case SpecialNPRIDs.Eldar:
                        species.double_0 = 0.2;
                        species.double_1 = species.double_0 * 0.8;
                        species.double_3 = 280.0;
                        species.double_4 = 50.0;
                        species.double_5 = 1.5;
                        species.double_6 = species.double_5 * 0.95;
                        species.double_2 = 10.0;
                        species.SpeciesName = UITextHelper.GetLocalizedStringFor(LocalizedText.SpeciesNameEldar);
                        species.RaceImageFileName = "Race156.bmp";
                        species.int_7 = 100;
                        species.int_3 = 10;
                        species.int_5 = 80 /*0x50*/;
                        species.int_6 = 20;
                        species.int_2 = 100;
                        species.int_8 = 10;
                        species.int_4 = 0;
                        break;
                    default:
                        species.double_1 = species.double_0 * (AuroraUtils.GetRandomInteger(6) * 0.05 + 0.3);
                        species.double_4 = 14 + AuroraUtils.GetRandomInteger(16 /*0x10*/);
                        if (num4 > species.double_4)
                            species.double_4 = num4 + 1.0;
                        species.double_6 = species.double_5 * (AuroraUtils.GetRandomInteger(9) * 0.05 + 0.45);
                        species.double_2 = this.AtmospherePressure * (AuroraUtils.GetRandomInteger(21) * 0.1 + 1.9);
                        species.SpeciesName = gclass21_0.RaceName;
                        species.RaceImageFileName =
                            gclass143_0 == null ? AuroraUtils.GetRandomImageFileNameFromFolder("Races") : gclass143_0.string_3;
                        break;
                }
            }

            species.gclass194_0 = null;
            species.double_7 = species.double_5 - species.double_6;
            species.double_8 = species.double_5 + species.double_6;
            species.double_9 = species.double_0 - species.double_1;
            species.double_10 = species.double_0 + species.double_1;
            species.double_12 = species.double_3 - species.double_4;
            species.double_11 = species.double_3 + species.double_4;
            species.decimal_0 = 1M;
            species.decimal_1 = 1M;
            species.decimal_2 = 1M;
            species.decimal_3 = 1M;
            if (gclass143_0 != null)
            {
                species.decimal_1 = gclass143_0.decimal_0;
                species.decimal_2 = gclass143_0.decimal_1;
                species.decimal_3 = gclass143_0.decimal_2;
            }
            else if (!bool_10)
            {
                if (AuroraUtils.GetRandomInteger(25) == 1)
                    species.decimal_0 = 2M + AuroraUtils.GetRandomInteger(30) * 0.1M;
                else if (AuroraUtils.GetRandomInteger(10) == 1)
                    species.decimal_0 = 1M + AuroraUtils.GetRandomInteger(10) * 0.1M;
                else if (AuroraUtils.GetRandomInteger(10) == 1)
                    species.decimal_0 = 1M - AuroraUtils.GetRandomInteger(5) * 0.1M;
                if (AuroraUtils.GetRandomInteger(25) == 1)
                    species.decimal_1 = 2M + AuroraUtils.GetRandomInteger(10) * 0.1M;
                else if (AuroraUtils.GetRandomInteger(10) == 1)
                    species.decimal_1 = 1M + AuroraUtils.GetRandomInteger(10) * 0.1M;
                else if (AuroraUtils.GetRandomInteger(10) == 1)
                    species.decimal_1 = 1M - AuroraUtils.GetRandomInteger(5) * 0.1M;
                if (AuroraUtils.GetRandomInteger(10) == 1)
                    species.decimal_2 = 1M + AuroraUtils.GetRandomInteger(10) * 0.1M;
                else if (AuroraUtils.GetRandomInteger(20) == 1)
                    species.decimal_2 = 1M - AuroraUtils.GetRandomInteger(5) * 0.1M;
                if (AuroraUtils.GetRandomInteger(10) == 1)
                    species.decimal_3 = 1M + AuroraUtils.GetRandomInteger(10) * 0.1M;
                else if (AuroraUtils.GetRandomInteger(20) == 1)
                    species.decimal_3 = 1M - AuroraUtils.GetRandomInteger(5) * 0.1M;
            }

            species.dictionary_0 = new Dictionary<int, GClass195>();
            this.gclass194_0 = species;
            return species;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3017);
            return null;
        }
    }

    public bool method_23(bool bool_10)
    {
        try
        {
            if (bool_10)
            {
                if (this.Gravity < 0.4 || this.Gravity > 2.5 || this.SurfaceTemp < 220.0 || this.SurfaceTemp > 340.0 ||
                    this.HydroExtent < 20.0 || this.HydroExtent > 90.0)
                    return false;
                double num = 0.0;
                foreach (SystemBodyAtmosphericGas gclass224 in this.AtmosphericGasList)
                {
                    if (gclass224.Gas.Type == GasType.Oxygen)
                        num = gclass224.GasAtm;
                    else if (gclass224.Gas.Dangerous > 0)
                        return false;
                }

                return num >= 0.07 && num <= this.AtmospherePressure * 0.3;
            }

            if (this.Gravity < 0.1)
            {
                
                int num = (int)MessageBox.Show(UITextHelper.GetLocalizedStringFor(LocalizedText.GravityTooLowForHomeworld));
                return false;
            }

            if (this.SurfaceTemp < 203.0)
            {
                int num = (int)MessageBox.Show(
                    UITextHelper.GetLocalizedStringFor(LocalizedText.SurfaceTemperatureTooLowForHomeworld));
                return false;
            }

            if (this.SurfaceTemp > 343.0)
            {
                
                int num = (int)MessageBox.Show(
                    UITextHelper.GetLocalizedStringFor(LocalizedText.SurfaceTemperatureTooHighForHomeworld));
                return false;
            }

            if (this.SurfaceTemp > 350.0)
            {
                int num = (int)MessageBox.Show(UITextHelper.GetLocalizedStringFor(LocalizedText.InsufficientWaterForHomeworld));
                return false;
            }

            double oxygenAtm = 0.0;
            foreach (SystemBodyAtmosphericGas gclass224 in this.AtmosphericGasList)
            {
                if (gclass224.Gas.Type == GasType.Oxygen)
                    oxygenAtm = gclass224.GasAtm;
                else if (gclass224.Gas.Dangerous > 0 && gclass224.AtmoGasAmount >= gclass224.Gas.DangerousLevel / 10000)
                {
                    int num2 = (int)MessageBox.Show(UITextHelper.GetLocalizedStringFor(LocalizedText.DangerousAtmosphereForHomeworld));
                    return false;
                }
            }

            if (oxygenAtm < 0.05)
            {
                int num3 = (int)MessageBox.Show(
                    UITextHelper.GetLocalizedStringFor(LocalizedText.InsufficientOxygenForHomeworld));
                return false;
            }

            if (oxygenAtm <= this.AtmospherePressure * 0.3)
                return true;
            int num4 = (int)MessageBox.Show(UITextHelper.GetLocalizedStringFor(LocalizedText.TooMuchOxygenForHomeworld));
            return false;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3018);
            return false;
        }
    }

    public void method_24(AuroraElement auroraElement_0, TextBox textBox_0, TextBox textBox_1)
    {
        try
        {
            if (this.MineralDeposits.ContainsKey(auroraElement_0))
            {
                textBox_0.Text = Math.Round(this.MineralDeposits[auroraElement_0].Amount).ToString();
                textBox_1.Text = AuroraUtils.smethod_45(this.MineralDeposits[auroraElement_0].Accessibility, 2);
            }
            else
            {
                textBox_0.Text = "0";
                textBox_1.Text = "0";
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3019);
        }
    }

    public void method_25(AuroraElement auroraElement_0, TextBox textBox_0, TextBox textBox_1)
    {
        try
        {
            Decimal num1 = 0M;
            Decimal num2 = 0.1M;
            ParsedDecimal gclass208_1 = AuroraUtils.ParseDecimalString(textBox_0.Text);
            if (gclass208_1.Succeed)
                num1 = gclass208_1.Value;
            ParsedDecimal gclass208_2 = AuroraUtils.ParseDecimalString(textBox_1.Text);
            if (gclass208_2.Succeed)
                num2 = gclass208_2.Value;
            if (this.MineralDeposits.ContainsKey(auroraElement_0))
            {
                if (num1 == 0M)
                {
                    this.MineralDeposits.Remove(auroraElement_0);
                }
                else
                {
                    this.MineralDeposits[auroraElement_0].Amount = num1;
                    this.MineralDeposits[auroraElement_0].Accessibility = num2;
                    if (this.MineralDeposits[auroraElement_0].Accessibility > 1M)
                        this.MineralDeposits[auroraElement_0].Accessibility = 1M;
                    this.MineralDeposits[auroraElement_0].HalfOriginalAmount = this.MineralDeposits[auroraElement_0].Amount / 2M;
                    this.MineralDeposits[auroraElement_0].OriginalAcc = this.MineralDeposits[auroraElement_0].Accessibility;
                }
            }
            else
            {
                if (num1 == 0M)
                    return;
                MineralDeposit gclass124 = new MineralDeposit();
                gclass124.SystemBodyID = this.SystemBodyID;
                gclass124.MaterialID = auroraElement_0;
                gclass124.Amount = num1;
                gclass124.Accessibility = num2;
                if (gclass124.Accessibility > 1M)
                    gclass124.Accessibility = 1M;
                gclass124.HalfOriginalAmount = gclass124.Amount / 2M;
                gclass124.OriginalAcc = gclass124.Accessibility;
                this.MineralDeposits.Add(gclass124.MaterialID, gclass124);
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3020);
        }
    }

    public string method_26()
    {
        try
        {
            string str = "";
            foreach (MineralDeposit gclass124 in this.MineralDeposits.Values)
                str = string.Format("{0}{1}: {2}     ", str, AuroraUtils.smethod_82(gclass124.MaterialID),
                    gclass124.method_0());
            return str;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3021);
            return "None";
        }
    }

    public void method_27()
    {
        try
        {
            if (this.BodyTypeId != AuroraSystemBodyType.GasGiant && this.BodyTypeId != AuroraSystemBodyType.Superjovian)
            {
                double double_45 = 0.0;
                double double_46 = 0.0;
                foreach (SystemBodyAtmosphericGas gclass224 in this.AtmosphericGasList)
                {
                    if (!gclass224.FrozenOut)
                    {
                        if (gclass224.Gas.GHGas)
                            double_45 += gclass224.GasAtm;
                        if (gclass224.Gas.AntiGHGas)
                            double_46 += gclass224.GasAtm;
                    }
                }

                this.method_28(double_45, double_46);
            }
            else
                this.SurfaceTemp = this.BaseTemp;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3022);
        }
    }

    public void method_28(double double_45, double double_46)
    {
        try
        {
            this.GreenhouseFactor = 1.0 + this.AtmospherePressure / 10.0 + double_45;
            if (this.GreenhouseFactor > 3.0)
                this.GreenhouseFactor = 3.0;
            this.AntiGreenhouseFactor = 1.0 + (double)this.DustLevel / 20000.0 + double_46;
            if (this.AntiGreenhouseFactor > 3.0)
                this.AntiGreenhouseFactor = 3.0;
            this.SurfaceTemp = this.BaseTemp * this.GreenhouseFactor * this.Albedo / this.AntiGreenhouseFactor;
            if (this.SurfaceTemp >= 1.0)
                return;
            this.SurfaceTemp = 1.0;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3299);
        }
    }

    public void method_29()
    {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        SystemBodyData.Class309 class309 = new SystemBodyData.Class309();
        // ISSUE: reference to a compiler-generated field
        class309.gclass1_0 = this;
        try
        {
            this.DominantTerrain = this.gclass0_0.DominantTerrainTypeDictionary[PlanetDominantTerrain.const_0];
            if (this.BodyTypeId == AuroraSystemBodyType.GasGiant || this.BodyTypeId == AuroraSystemBodyType.Superjovian)
                return;
            // ISSUE: reference to a compiler-generated field
            class309.double_0 = 0.0;
            double num = 0.0;
            foreach (SystemBodyAtmosphericGas gclass224 in this.AtmosphericGasList)
            {
                num += gclass224.GasAtm;
                if (gclass224.Gas.Type == GasType.Oxygen)
                {
                    // ISSUE: reference to a compiler-generated field
                    class309.double_0 = gclass224.GasAtm;
                }
            }

            // ISSUE: reference to a compiler-generated field
            class309.double_1 = this.SurfaceTemp - AuroraUtils.int_17;
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            if ((class309.double_1 < -150.0 || class309.double_1 > 200.0 || this.Gravity < 0.1 || num == 0.0 ||
                 num > 10.0) && this.TectonicActivity < AuroraTectonics.PlateTectonic)
            {
                this.DominantTerrain = this.gclass0_0.DominantTerrainTypeDictionary[PlanetDominantTerrain.const_0];
            }
            else
            {
                // ISSUE: reference to a compiler-generated method
                List<PlanetaryTerrainDefinition> list = this.gclass0_0.DominantTerrainTypeDictionary.Values.Where<PlanetaryTerrainDefinition>(class309.method_0)
                    .ToList<PlanetaryTerrainDefinition>();
                if (list.Count == 0)
                {
                    // ISSUE: reference to a compiler-generated method
                    list = this.gclass0_0.DominantTerrainTypeDictionary.Values.Where<PlanetaryTerrainDefinition>(class309.method_1).ToList<PlanetaryTerrainDefinition>();
                }

                if (list.Count <= 0)
                    return;
                this.DominantTerrain = list.ElementAt<PlanetaryTerrainDefinition>(AuroraUtils.GetRandomInteger(list.Count) - 1);
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3023);
        }
    }

    public List<PlanetaryTerrainDefinition> method_30()
    {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        SystemBodyData.Class310 class310 = new SystemBodyData.Class310();
        // ISSUE: reference to a compiler-generated field
        class310.gclass1_0 = this;
        try
        {
            // ISSUE: reference to a compiler-generated field
            class310.double_0 = 0.0;
            double num = 0.0;
            foreach (SystemBodyAtmosphericGas gclass224 in this.AtmosphericGasList)
            {
                num += gclass224.GasAtm;
                if (gclass224.Gas.Type == GasType.Oxygen)
                {
                    // ISSUE: reference to a compiler-generated field
                    class310.double_0 = gclass224.GasAtm;
                }
            }

            // ISSUE: reference to a compiler-generated field
            class310.double_1 = this.SurfaceTemp - AuroraUtils.int_17;
            // ISSUE: reference to a compiler-generated method
            return this.gclass0_0.DominantTerrainTypeDictionary.Values.Where<PlanetaryTerrainDefinition>(class310.method_0).ToList<PlanetaryTerrainDefinition>();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3024);
            return null;
        }
    }

    public bool method_31(GClass143 gclass143_0)
    {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        SystemBodyData.Class311 class311 = new SystemBodyData.Class311();
        // ISSUE: reference to a compiler-generated field
        class311.gclass1_0 = this;
        try
        {
            // ISSUE: reference to a compiler-generated field
            class311.double_0 = 0.0;
            double num1 = 0.0;
            foreach (SystemBodyAtmosphericGas gclass224 in this.AtmosphericGasList)
            {
                num1 += gclass224.GasAtm;
                if (gclass224.Gas.Type == GasType.Oxygen)
                {
                    // ISSUE: reference to a compiler-generated field
                    class311.double_0 = gclass224.GasAtm;
                }
            }

            double num2 = this.SurfaceTemp - AuroraUtils.int_17;
            // ISSUE: reference to a compiler-generated field
            class311.double_2 = num2;
            // ISSUE: reference to a compiler-generated field
            class311.double_1 = num2;
            // ISSUE: reference to a compiler-generated field
            class311.double_3 = 0.0;
            if (this.BodyClass == PlanetBodyClass.Moon)
            {
                // ISSUE: reference to a compiler-generated field
                class311.double_1 = this.method_53(this.ParentBodyData.double_28);
                // ISSUE: reference to a compiler-generated field
                class311.double_2 = this.method_53(this.ParentBodyData.double_27);
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                class311.double_3 = class311.double_2 - class311.double_1;
                // ISSUE: reference to a compiler-generated field
                class311.double_1 -= AuroraUtils.int_17;
                // ISSUE: reference to a compiler-generated field
                class311.double_2 -= AuroraUtils.int_17;
            }
            else
            {
                // ISSUE: reference to a compiler-generated field
                class311.double_1 = this.method_53(this.double_28);
                // ISSUE: reference to a compiler-generated field
                class311.double_2 = this.method_53(this.double_27);
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                class311.double_3 = class311.double_2 - class311.double_1;
                // ISSUE: reference to a compiler-generated field
                class311.double_1 -= AuroraUtils.int_17;
                // ISSUE: reference to a compiler-generated field
                class311.double_2 -= AuroraUtils.int_17;
            }

            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            if (class311.double_1 < -150.0 || class311.double_2 > 200.0)
                return false;
            // ISSUE: reference to a compiler-generated method
            List<PlanetaryTerrainDefinition> list = gclass143_0.list_0.Where<PlanetaryTerrainDefinition>(class311.method_0).ToList<PlanetaryTerrainDefinition>();
            if (list.Count == 0)
                return false;
            int index = AuroraUtils.GetRandomInteger(list.Count) - 1;
            this.DominantTerrain = this.gclass0_0.DominantTerrainTypeDictionary[list[index].DominantTerrainType];
            return true;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3757);
            return false;
        }
    }

    public void method_32()
    {
        try
        {
            var climateChangeFormatText = UITextHelper.GetLocalizedStringFor(LocalizedText.ClimateChangeEventMsg);
            
            // ISSUE: object of a compiler-generated type is created
            // ISSUE: variable of a compiler-generated type
            SystemBodyData.Class312 class312 = new SystemBodyData.Class312();
            // ISSUE: reference to a compiler-generated field
            class312.gclass1_0 = this;
            if (this.BodyTypeId != AuroraSystemBodyType.GasGiant && this.BodyTypeId != AuroraSystemBodyType.Superjovian)
            {
                PlanetaryTerrainDefinition gclass990 = this.DominantTerrain;
                // ISSUE: reference to a compiler-generated field
                class312.double_0 = 0.0;
                double num1 = 0.0;
                foreach (SystemBodyAtmosphericGas gclass224 in this.AtmosphericGasList)
                {
                    num1 += gclass224.GasAtm;
                    if (gclass224.Gas.Type == GasType.Oxygen)
                    {
                        // ISSUE: reference to a compiler-generated field
                        class312.double_0 = gclass224.GasAtm;
                    }
                }

                if (this.Gravity >= 0.1 && num1 != 0.0 && num1 <= 10.0)
                {
                    double num2 = this.SurfaceTemp - AuroraUtils.int_17;
                    // ISSUE: reference to a compiler-generated field
                    class312.double_2 = num2;
                    // ISSUE: reference to a compiler-generated field
                    class312.double_1 = num2;
                    // ISSUE: reference to a compiler-generated field
                    class312.double_3 = 0.0;
                    if (this.BodyClass == PlanetBodyClass.Moon)
                    {
                        if (this.ParentBodyData.Year < 4380.0)
                        {
                            // ISSUE: reference to a compiler-generated field
                            class312.double_1 = this.method_53(this.ParentBodyData.double_28);
                            // ISSUE: reference to a compiler-generated field
                            class312.double_2 = this.method_53(this.ParentBodyData.double_27);
                            // ISSUE: reference to a compiler-generated field
                            // ISSUE: reference to a compiler-generated field
                            // ISSUE: reference to a compiler-generated field
                            class312.double_3 = class312.double_2 - class312.double_1;
                            // ISSUE: reference to a compiler-generated field
                            class312.double_1 -= AuroraUtils.int_17;
                            // ISSUE: reference to a compiler-generated field
                            class312.double_2 -= AuroraUtils.int_17;
                        }
                    }
                    else if (this.Year < 4380.0)
                    {
                        // ISSUE: reference to a compiler-generated field
                        class312.double_1 = this.method_53(this.double_28);
                        // ISSUE: reference to a compiler-generated field
                        class312.double_2 = this.method_53(this.double_27);
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        // ISSUE: reference to a compiler-generated field
                        class312.double_3 = class312.double_2 - class312.double_1;
                        // ISSUE: reference to a compiler-generated field
                        class312.double_1 -= AuroraUtils.int_17;
                        // ISSUE: reference to a compiler-generated field
                        class312.double_2 -= AuroraUtils.int_17;
                    }

                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    if (class312.double_1 >= -150.0 && class312.double_2 <= 200.0)
                    {
                        if (this.DominantTerrain.DominantTerrainType != PlanetDominantTerrain.const_2 &&
                            this.DominantTerrain.DominantTerrainType != PlanetDominantTerrain.const_12 &&
                            this.DominantTerrain.DominantTerrainType != PlanetDominantTerrain.const_0)
                        {
                            // ISSUE: reference to a compiler-generated method
                            List<PlanetaryTerrainDefinition> list = this.gclass0_0.DominantTerrainTypeDictionary.Values.Where<PlanetaryTerrainDefinition>(class312.method_1)
                                .ToList<PlanetaryTerrainDefinition>();
                            if (list.Contains(this.DominantTerrain) || list.Count <= 0)
                                return;
                            if (list.Count > 1)
                                list = list.Where<PlanetaryTerrainDefinition>(gclass99_1 =>
                                    gclass99_1.DominantTerrainType != this.DominantTerrain.BaseTerrainType).ToList<PlanetaryTerrainDefinition>();
                            int index = AuroraUtils.GetRandomInteger(list.Count) - 1;
                            this.DominantTerrain = this.gclass0_0.DominantTerrainTypeDictionary[list[index].DominantTerrainType];
                            foreach (GameRace gclass21_0 in this.gclass0_0.Populations.Values
                                         .Where<PopulationData>(gclass146_0 => gclass146_0.SystemBodyData == this)
                                         .Select<PopulationData, GameRace>(gclass146_0 => gclass146_0.Race)
                                         .Distinct<GameRace>().ToList<GameRace>())
                                
                                this.gclass0_0.gclass92_0.method_2(EventType.const_152,
                                    string.Format(
                                        climateChangeFormatText,
                                        this.method_78(gclass21_0), gclass990.Name, this.DominantTerrain.Name),
                                    gclass21_0, this.SystemData, this.XCoordinate, this.YCoordinate,
                                    AuroraEventCategory.PopEnvironment);
                        }
                        else
                        {
                            // ISSUE: reference to a compiler-generated method
                            List<PlanetaryTerrainDefinition> list = this.gclass0_0.DominantTerrainTypeDictionary.Values.Where<PlanetaryTerrainDefinition>(class312.method_0)
                                .ToList<PlanetaryTerrainDefinition>();
                            if (list.Count <= 0)
                                return;
                            int index = AuroraUtils.GetRandomInteger(list.Count) - 1;
                            this.DominantTerrain = this.gclass0_0.DominantTerrainTypeDictionary[list[index].DominantTerrainType];
                            foreach (GameRace gclass21_0 in this.gclass0_0.Populations.Values
                                         .Where<PopulationData>(gclass146_0 => gclass146_0.SystemBodyData == this)
                                         .Select<PopulationData, GameRace>(gclass146_0 => gclass146_0.Race)
                                         .Distinct<GameRace>().ToList<GameRace>())
                                this.gclass0_0.gclass92_0.method_2(EventType.const_152,
                                    string.Format(
                                        climateChangeFormatText,
                                        this.method_78(gclass21_0), gclass990.Name, this.DominantTerrain.Name),
                                    gclass21_0, this.SystemData, this.XCoordinate, this.YCoordinate,
                                    AuroraEventCategory.PopEnvironment);
                        }
                    }
                    else
                    {
                        if (this.DominantTerrain == this.gclass0_0.DominantTerrainTypeDictionary[this.DominantTerrain.BaseTerrainType])
                            return;
                        this.DominantTerrain = this.gclass0_0.DominantTerrainTypeDictionary[this.DominantTerrain.BaseTerrainType];
                        foreach (GameRace gclass21_0 in this.gclass0_0.Populations.Values
                                     .Where<PopulationData>(gclass146_0 => gclass146_0.SystemBodyData == this)
                                     .Select<PopulationData, GameRace>(gclass146_0 => gclass146_0.Race)
                                     .Distinct<GameRace>().ToList<GameRace>())
                            this.gclass0_0.gclass92_0.method_2(EventType.const_152,
                                string.Format(
                                    climateChangeFormatText,
                                    this.method_78(gclass21_0), gclass990.Name, this.DominantTerrain.Name),
                                gclass21_0, this.SystemData, this.XCoordinate, this.YCoordinate,
                                AuroraEventCategory.PopEnvironment);
                    }
                }
                else
                {
                    if (this.DominantTerrain == this.gclass0_0.DominantTerrainTypeDictionary[this.DominantTerrain.BaseTerrainType])
                        return;
                    this.DominantTerrain = this.gclass0_0.DominantTerrainTypeDictionary[this.DominantTerrain.BaseTerrainType];
                    foreach (GameRace gclass21_0 in this.gclass0_0.Populations.Values
                                 .Where<PopulationData>(gclass146_0 => gclass146_0.SystemBodyData == this)
                                 .Select<PopulationData, GameRace>(gclass146_0 => gclass146_0.Race)
                                 .Distinct<GameRace>().ToList<GameRace>())
                        this.gclass0_0.gclass92_0.method_2(EventType.const_152,
                            string.Format(
                                climateChangeFormatText,
                                this.method_78(gclass21_0), gclass990.Name, this.DominantTerrain.Name),
                            gclass21_0, this.SystemData, this.XCoordinate, this.YCoordinate,
                            AuroraEventCategory.PopEnvironment);
                }
            }
            else
                this.DominantTerrain = this.gclass0_0.DominantTerrainTypeDictionary[PlanetDominantTerrain.const_0];
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3025);
        }
    }

    public AuroraHydrosphereType method_33(bool bool_10, bool bool_11)
    {
        try
        {
            double num = this.BaseTemp;
            if (bool_10)
                num = this.SurfaceTemp;
            this.HydrosphereTypeId = this.AtmospherePressure != 0.0 || !bool_11
                ? (this.AtmospherePressure >= 0.006 || num <= 245.0 || !bool_11
                    ? (num <= 369.0 || !bool_11
                        ? (num <= 369.0
                            ? (num <= 245.0 ? AuroraHydrosphereType.IceSheet : AuroraHydrosphereType.Liquid)
                            : AuroraHydrosphereType.Vapour)
                        : AuroraHydrosphereType.None)
                    : AuroraHydrosphereType.None)
                : AuroraHydrosphereType.None;
            return this.HydrosphereTypeId;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3026);
            return AuroraHydrosphereType.None;
        }
    }

    public AuroraHydrosphereType method_34(double double_45)
    {
        try
        {
            if (double_45 > 369.0)
                return AuroraHydrosphereType.Vapour;
            return double_45 > 245.0 ? AuroraHydrosphereType.Liquid : AuroraHydrosphereType.IceSheet;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3477);
            return AuroraHydrosphereType.None;
        }
    }

    public void method_35()
    {
        try
        {
            if (this.AtmosphericGasList.Count == 0)
                return;
            double double15 = this.AtmospherePressure;
            foreach (SystemBodyAtmosphericGas gclass224 in this.AtmosphericGasList)
                gclass224.FrozenOut = this.SurfaceTemp < gclass224.Gas.BoilingPoint;
            this.AtmospherePressure = this.AtmosphericGasList.Where<SystemBodyAtmosphericGas>(gclass224_0 => !gclass224_0.FrozenOut)
                .Sum<SystemBodyAtmosphericGas>(gclass224_0 => gclass224_0.GasAtm);
            if (this.AtmospherePressure == 0.0)
                this.AtmospherePressure = double15 / 20.0;
            if (this.AtmospherePressure < 0.0)
                this.AtmospherePressure = 0.0;
            if (this.AtmospherePressure == double15)
                return;
            this.method_27();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3027);
        }
    }

    public void method_36(GameRace gclass21_0)
    {
        try
        {
            this.method_27();
            AuroraHydrosphereType hydrosphereType0 = this.HydrosphereTypeId;
            AuroraHydrosphereType auroraHydrosphereType = this.method_33(true, false);
            if (hydrosphereType0 == AuroraHydrosphereType.IceSheet &&
                auroraHydrosphereType == AuroraHydrosphereType.Liquid)
            {
                if (this.HydroExtent > 0.0 && this.HydrosphereTypeId == AuroraHydrosphereType.Liquid)
                    this.gclass0_0.method_412(this, 0.0);
                double double4 = this.SurfaceTemp;
                double double16 = this.Albedo;
                this.Albedo += 0.0015 * this.HydroExtent;
                this.method_27();
                if (gclass21_0 == null || this.Albedo == double16)
                    return;
                this.gclass0_0.gclass92_0.method_2(EventType.const_50,
                    string.Format(
                        UITextHelper.GetLocalizedStringFor(LocalizedText.IceSheetMeltEventMsg),
                        this.method_78(gclass21_0), AuroraUtils.FormatDoubleToPrecision(double16, 3),
                        AuroraUtils.FormatDoubleToPrecision(this.Albedo, 3), AuroraUtils.FormatDoubleToPrecision(double4 - AuroraUtils.int_17, 1),
                        AuroraUtils.FormatDoubleToPrecision(this.SurfaceTemp - AuroraUtils.int_17, 1)),
                    gclass21_0, this.SystemData, this.XCoordinate, this.YCoordinate,
                    AuroraEventCategory.PopEnvironment);
            }
            else if (hydrosphereType0 == AuroraHydrosphereType.Liquid &&
                     auroraHydrosphereType == AuroraHydrosphereType.IceSheet)
            {
                double double4 = this.SurfaceTemp;
                double double16 = this.Albedo;
                this.Albedo -= 0.0015 * this.HydroExtent;
                this.method_27();
                if (gclass21_0 == null)
                    return;
                this.gclass0_0.gclass92_0.method_2(EventType.const_184,
                    string.Format(
                        UITextHelper.GetLocalizedStringFor(LocalizedText.IceSheetFrozenEventMsg),
                        this.Name, AuroraUtils.FormatDoubleToPrecision(double16, 3), AuroraUtils.FormatDoubleToPrecision(this.Albedo, 3),
                        AuroraUtils.FormatDoubleToPrecision(double4 - AuroraUtils.int_17, 1),
                        AuroraUtils.FormatDoubleToPrecision(this.SurfaceTemp - AuroraUtils.int_17, 1)),
                    gclass21_0, this.SystemData, this.XCoordinate, this.YCoordinate,
                    AuroraEventCategory.PopEnvironment);
            }
            else if (hydrosphereType0 != AuroraHydrosphereType.None && this.HydroExtent > 0.0 &&
                     auroraHydrosphereType == AuroraHydrosphereType.Vapour)
            {
                if (hydrosphereType0 == AuroraHydrosphereType.IceSheet)
                    this.Albedo += 0.0015 * this.HydroExtent;
                this.method_27();
            }
            else if (hydrosphereType0 == AuroraHydrosphereType.Vapour &&
                     (auroraHydrosphereType == AuroraHydrosphereType.IceSheet ||
                      auroraHydrosphereType == AuroraHydrosphereType.Liquid))
            {
                if (auroraHydrosphereType == AuroraHydrosphereType.IceSheet)
                    this.Albedo -= 0.0015 * this.HydroExtent;
                if (this.HydroExtent > 0.0 && auroraHydrosphereType == AuroraHydrosphereType.Liquid)
                    this.gclass0_0.method_412(this, 0.0);
                this.method_27();
            }
            else
            {
                if (auroraHydrosphereType != AuroraHydrosphereType.None)
                    return;
                this.HydroExtent = 0.0;
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3028);
        }
    }

    public void method_37(GameRace gclass21_0)
    {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        SystemBodyData.Class313 class313 = new SystemBodyData.Class313();
        // ISSUE: reference to a compiler-generated field
        class313.gclass21_0 = gclass21_0;
        // ISSUE: reference to a compiler-generated field
        class313.gclass1_0 = this;
        try
        {
            // ISSUE: reference to a compiler-generated method
            if (this.gclass0_0.SystemBodySurveys.Where<RacialSystemBodySurvey>(class313.method_0).FirstOrDefault<RacialSystemBodySurvey>() != null)
                return;
            // ISSUE: reference to a compiler-generated field
            this.gclass0_0.SystemBodySurveys.Add(new RacialSystemBodySurvey()
            {
                Race = class313.gclass21_0,
                SystemBody = this,
                UnknownEnumFlag = Unknown_SystemBodyDataUpdateLevel.FullUpdate
            });
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3029);
        }
    }

    public void method_38(GameRace gclass21_0)
    {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        SystemBodyData.Class314 class314 = new SystemBodyData.Class314();
        // ISSUE: reference to a compiler-generated field
        class314.gclass21_0 = gclass21_0;
        // ISSUE: reference to a compiler-generated field
        class314.gclass1_0 = this;
        try
        {
            // ISSUE: reference to a compiler-generated method
            RacialSystemBodySurvey gclass215 = this.gclass0_0.SystemBodySurveys.Where<RacialSystemBodySurvey>(class314.method_0).FirstOrDefault<RacialSystemBodySurvey>();
            if (gclass215 == null)
                return;
            this.gclass0_0.SystemBodySurveys.Remove(gclass215);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3030);
        }
    }

    public Decimal method_39()
    {
        try
        {
            Decimal num =
                this.BodyTypeId == AuroraSystemBodyType.GasGiant || this.BodyTypeId == AuroraSystemBodyType.Superjovian
                    ? (Decimal)this.Radius / 100M
                    : (Decimal)this.Radius / 10M;
            if (num < 1M)
                num = 1M;
            return num;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3031);
            return 0M;
        }
    }

    public void method_40()
    {
        try
        {
            this.double_27 = this.OrbitalDistance * (1.0 - this.Eccentricity);
            this.double_28 = this.OrbitalDistance * (1.0 + this.Eccentricity);
            this.OrbitalSemiMinorAxis = this.OrbitalDistance * Math.Sqrt(1.0 - this.Eccentricity * this.Eccentricity);
            this.method_41(this.Bearing);
            this.DistanceToParent =
                this.gclass0_0.GetDistanceBetween(this.XCoordinate, this.YCoordinate, this.StarData.XCoord,
                    this.StarData.YCoord) / AuroraUtils.double_14;
            this.method_6();
            if (this.Eccentricity == 0.0)
                return;
            this.BaseTemp = byte.MaxValue / Math.Pow(this.DistanceToParent / Math.Pow(this.StarData.Luminosity, 0.5), 0.5);
            if (this.BaseTemp < 4.0)
                this.BaseTemp = 4.0;
            this.method_36(null);
            this.method_35();
            this.method_32();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3581);
        }
    }

    public void method_41(double double_45)
    {
        try
        {
            this.RecalculateDistanceToOrbitCentreFromBearing();
            double_45 -= 90.0;
            if (double_45 < 0.0)
                double_45 += 360.0;
            if (this.ParentBodyData != null && this.TrojanOffset == 0.0)
            {
                double num = double_45 * (Math.PI / 180.0);
                this.XCoordinate = this.ParentBodyData.XCoordinate + this.OrbitalDistance * Math.Cos(num);
                this.YCoordinate = this.ParentBodyData.YCoordinate + this.OrbitalDistance * Math.Sin(num);
            }
            else if (this.Eccentricity == 0.0)
            {
                double num = double_45 * (Math.PI / 180.0);
                this.XCoordinate = this.StarData.XCoord +
                                   this.OrbitalDistance * AuroraUtils.double_14 * Math.Cos(num);
                this.YCoordinate = this.StarData.YCoord +
                                   this.OrbitalDistance * AuroraUtils.double_14 * Math.Sin(num);
            }
            else if (this.EccentricityDirection == 0.0)
            {
                double num1 = double_45 * (Math.PI / 180.0);
                double num2 = this.StarData.XCoord + (this.OrbitalDistance - this.double_27) * AuroraUtils.double_14;
                double double1 = this.StarData.YCoord;
                this.XCoordinate = num2 + this.DistanceToOrbitCentre * AuroraUtils.double_14 * Math.Cos(num1);
                this.YCoordinate = double1 + this.DistanceToOrbitCentre * AuroraUtils.double_14 * Math.Sin(num1);
            }
            else
            {
                this.method_42();
                double_45 += this.EccentricityDirection;
                if (double_45 >= 360.0)
                    double_45 -= 360.0;
                double num = double_45 * (Math.PI / 180.0);
                this.XCoordinate = this.double_29 + this.DistanceToOrbitCentre * AuroraUtils.double_14 * Math.Cos(num);
                this.YCoordinate = this.double_30 + this.DistanceToOrbitCentre * AuroraUtils.double_14 * Math.Sin(num);
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3032);
        }
    }

    public void method_42()
    {
        try
        {
            double double25 = this.EccentricityDirection;
            if (double25 < 0.0)
                double25 += 360.0;
            double num1 = double25 * (Math.PI / 180.0);
            double num2 = (this.double_28 - this.double_27) / 2.0;
            this.double_29 = this.StarData.XCoord + num2 * AuroraUtils.double_14 * Math.Cos(num1);
            this.double_30 = this.StarData.YCoord + num2 * AuroraUtils.double_14 * Math.Sin(num1);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3447);
        }
    }

    public int method_43(Species gclass194_1)
    {
        try
        {
            int num1 = 0;
            foreach (SystemBodyAtmosphericGas gclass224 in this.AtmosphericGasList)
            {
                if (gclass224.Gas.Dangerous > num1 && gclass224.Gas != gclass194_1.gclass223_0 &&
                    !gclass224.FrozenOut)
                {
                    double num2 = gclass224.Gas.DangerousLevel / 10000.0;
                    if (gclass224.AtmoGasAmount > num2)
                        num1 = gclass224.Gas.Dangerous;
                }
            }

            return num1;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3033);
            return 0;
        }
    }

    public double method_44(AtmosphericGasDefinition gclass223_0)
    {
        try
        {
            foreach (SystemBodyAtmosphericGas gclass224 in this.AtmosphericGasList)
            {
                if (gclass224.Gas == gclass223_0)
                    return gclass224.AtmoGasAmount;
            }

            return 0.0;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3034);
            return 0.0;
        }
    }

    public double method_45(AtmosphericGasDefinition gclass223_0)
    {
        try
        {
            foreach (SystemBodyAtmosphericGas gclass224 in this.AtmosphericGasList)
            {
                if (gclass224.Gas == gclass223_0)
                    return gclass224.GasAtm;
            }

            return 0.0;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3035);
            return 0.0;
        }
    }

    public double method_46()
    {
        try
        {
            this.AtmospherePressure = 0.0;
            foreach (SystemBodyAtmosphericGas gclass224 in this.AtmosphericGasList)
                this.AtmospherePressure += gclass224.GasAtm;
            if (this.AtmospherePressure < 0.0)
                this.AtmospherePressure = 0.0;
            return this.AtmospherePressure;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3036);
            return 0.0;
        }
    }

    public string method_47(Species gclass194_1, GEnum80 genum80_0)
    {
        try
        {
            return this.method_48(gclass194_1, 2, genum80_0);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3037);
            return "error";
        }
    }

    public string method_48(Species gclass194_1, int int_13, GEnum80 genum80_0)
    {
        try
        {
            switch (genum80_0)
            {
                case GEnum80.const_0:
                    if (this.ColonyCost == -1M)
                        return "N/A";
                    return this.Gravity < gclass194_1.double_7
                        ? $"{AuroraUtils.smethod_45(this.ColonyCost, int_13)} LG"
                        : AuroraUtils.smethod_45(this.ColonyCost, int_13).ToString();
                case GEnum80.const_1:
                    if (this.MaxColonyCost == -1M)
                        return "N/A";
                    return this.Gravity < gclass194_1.double_7
                        ? $"{AuroraUtils.smethod_45(this.MaxColonyCost, int_13)} LG"
                        : AuroraUtils.smethod_45(this.MaxColonyCost, int_13).ToString();
                case GEnum80.const_2:
                    if (this.double_34 == -1.0)
                        return "N/A";
                    return this.Gravity < gclass194_1.double_7
                        ? $"{AuroraUtils.smethod_46(this.double_34, int_13)} LG"
                        : AuroraUtils.smethod_46(this.double_34, int_13).ToString();
                case GEnum80.const_3:
                    if (this.double_35 == -1.0)
                        return "N/A";
                    return this.Gravity < gclass194_1.double_7
                        ? $"{AuroraUtils.smethod_46(this.double_35, int_13)} LG"
                        : AuroraUtils.smethod_46(this.double_35, int_13).ToString();
                default:
                    return "error";
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3038);
            return "error";
        }
    }

    public bool method_49(Species gclass194_1)
    {
        try
        {
            double num = this.method_45(gclass194_1.gclass223_0);
            return num >= gclass194_1.double_9 && num <= gclass194_1.double_10 &&
                   this.method_44(gclass194_1.gclass223_0) <= AuroraUtils.int_22;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3039);
            return false;
        }
    }

    public bool method_50(Species gclass194_1)
    {
        try
        {
            double num = this.method_45(gclass194_1.gclass223_0);
            return num >= gclass194_1.double_9 && num <= gclass194_1.double_10 &&
                   this.method_44(gclass194_1.gclass223_0) <= AuroraUtils.int_22;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3254);
            return false;
        }
    }

    public double method_51(double double_45)
    {
        try
        {
            double num = byte.MaxValue / Math.Pow(double_45 / Math.Pow(this.StarData.Luminosity, 0.5), 0.5);
            if (num < 4.0)
                num = 4.0;
            return num;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3456);
            return 0.0;
        }
    }

    public double method_52(
        GameRace gclass21_0,
        Species gclass194_1,
        double double_45,
        GEnum81 genum81_0)
    {
        try
        {
            if (this.IsFixedBody || this.BodyTypeId == AuroraSystemBodyType.GasGiant ||
                this.BodyTypeId == AuroraSystemBodyType.Superjovian)
                return -1.0;
            if (gclass194_1 == null)
                gclass194_1 = gclass21_0.method_164();
            double num1 = this.method_53(double_45);
            switch (genum81_0)
            {
                case GEnum81.const_1:
                    this.double_31 = num1;
                    break;
                case GEnum81.const_2:
                    this.double_32 = num1;
                    break;
            }

            double num2 = 0.0;
            if (num1 < gclass194_1.double_12)
                num2 = Math.Abs(gclass194_1.double_12 - num1) / gclass194_1.double_4;
            else if (num1 > gclass194_1.double_11)
                num2 = Math.Abs(gclass194_1.double_11 - num1) / gclass194_1.double_4;
            if (this.TidalLock && this.BodyClass != PlanetBodyClass.Moon)
                num2 /= 5.0;
            double num3 = 0.0;
            if (this.AtmospherePressure > gclass194_1.double_2)
            {
                num3 = this.AtmospherePressure / gclass194_1.double_2;
                if (num3 < 2.0)
                    num3 = 2.0;
            }

            if (num2 < num3)
                num2 = num3;
            double num4 = this.method_43(gclass194_1);
            if (num2 < num4)
                num2 = num4;
            if (Math.Round(num2, 4) < 2.0)
            {
                double num5 = this.method_45(gclass194_1.gclass223_0);
                if (num5 >= gclass194_1.double_9 && num5 <= gclass194_1.double_10)
                {
                    if (this.method_44(gclass194_1.gclass223_0) > AuroraUtils.int_22)
                        num2 = 2.0;
                }
                else
                    num2 = 2.0;
            }

            if (this.HydroExtent < 20.0)
            {
                double num6 = (20.0 - this.HydroExtent) / 10.0;
                if (num2 < num6)
                    num2 = num6;
            }

            if (this.Gravity < gclass194_1.double_7 && num2 < 1.0)
                num2 = 1.0;
            return Math.Round(num2, 4) * (double)gclass21_0.ColonizationSkill;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3455);
            return -2.0;
        }
    }

    public double method_53(double double_45)
    {
        try
        {
            double num1 = byte.MaxValue / Math.Pow(double_45 / Math.Pow(this.StarData.Luminosity, 0.5), 0.5);
            if (num1 < 4.0)
                num1 = 4.0;
            double num2 = this.SurfaceTemp / (this.BaseTemp * this.Albedo);
            double num3 = num1 * this.Albedo * num2;
            double num4 = 1.0;
            double num5 = 1.0;
            if (this.AtmosphericGasList.Count > 0)
            {
                double num6 = 0.0;
                double num7 = 0.0;
                foreach (SystemBodyAtmosphericGas gclass224 in this.AtmosphericGasList)
                {
                    if (num3 >= gclass224.Gas.BoilingPoint)
                    {
                        if (gclass224.Gas.GHGas)
                            num6 += gclass224.GasAtm;
                        if (gclass224.Gas.AntiGHGas)
                            num7 += gclass224.GasAtm;
                    }
                }

                num4 = 1.0 + this.AtmospherePressure / 10.0 + num6;
                if (num4 > 3.0)
                    num4 = 3.0;
                num5 = 1.0 + (double)this.DustLevel / 20000.0 + num7;
                if (num5 > 3.0)
                    num5 = 3.0;
            }

            double double_45_1 = num1 * num4 * this.Albedo / num5;
            if (double_45_1 < 1.0)
                double_45_1 = 1.0;
            if (this.HydroExtent > 0.0)
            {
                AuroraHydrosphereType hydrosphereType0 = this.HydrosphereTypeId;
                AuroraHydrosphereType auroraHydrosphereType = this.method_34(double_45_1);
                if (hydrosphereType0 != auroraHydrosphereType)
                {
                    double num8 = this.Albedo;
                    if (hydrosphereType0 == AuroraHydrosphereType.IceSheet)
                        num8 = this.Albedo + 0.0015 * this.HydroExtent;
                    else if (auroraHydrosphereType == AuroraHydrosphereType.IceSheet)
                        num8 = this.Albedo - 0.0015 * this.HydroExtent;
                    double_45_1 = num1 * num4 * num8 / num5;
                    if (double_45_1 < 1.0)
                        double_45_1 = 1.0;
                }
            }

            return double_45_1;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3478);
            return -2.0;
        }
    }

    public double method_54(
        GameRace gclass21_0,
        Species gclass194_1,
        double double_45,
        double double_46)
    {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        SystemBodyData.Class315 class315 = new SystemBodyData.Class315();
        // ISSUE: reference to a compiler-generated field
        class315.gclass194_0 = gclass194_1;
        try
        {
            double num = 0.0;
            // ISSUE: reference to a compiler-generated method
            foreach (SystemBodyAtmosphericGas gclass224 in this.AtmosphericGasList.Where<SystemBodyAtmosphericGas>(class315.method_0)
                         .OrderByDescending<SystemBodyAtmosphericGas, double>(gclass224_0 => gclass224_0.GasAtm).ToList<SystemBodyAtmosphericGas>())
            {
                if (gclass224.GasAtm <= double_45)
                {
                    num += gclass224.GasAtm;
                    this.AtmosphericGasList.Remove(gclass224);
                }
                else
                    break;
            }

            // ISSUE: reference to a compiler-generated field
            this.method_57(gclass21_0, class315.gclass194_0);
            return num / double_46;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3836);
            return -2.0;
        }
    }

    public double method_55(GameRace gclass21_0, Species gclass194_1, double double_45)
    {
        try
        {
            double num1 = 0.0;
            SystemBodyAtmosphericGas gclass224_1 = this.AtmosphericGasList.FirstOrDefault<SystemBodyAtmosphericGas>(gclass224_0 =>
                gclass224_0.Gas == this.gclass0_0.AtmosphericGasDictionary[GasType.Oxygen]);
            if (gclass224_1 == null)
            {
                gclass224_1 = new SystemBodyAtmosphericGas();
                gclass224_1.Gas = this.gclass0_0.AtmosphericGasDictionary[GasType.Oxygen];
                gclass224_1.SystemBodyID = this.SystemBodyID;
                gclass224_1.GasAtm = 0.0;
                gclass224_1.AtmoGasAmount = 0.0;
                gclass224_1.FrozenOut = false;
                this.AtmosphericGasList.Add(gclass224_1);
            }

            if (gclass224_1.GasAtm < gclass194_1.double_9)
            {
                num1 = gclass194_1.double_9 - gclass224_1.GasAtm + 0.01;
                gclass224_1.GasAtm = gclass194_1.double_9 + 0.01;
            }
            else if (gclass224_1.GasAtm > gclass194_1.double_10)
            {
                num1 = gclass224_1.GasAtm - gclass194_1.double_10 + 0.01;
                gclass224_1.GasAtm = gclass194_1.double_10 - 0.01;
            }

            this.method_57(gclass21_0, gclass194_1);
            if (gclass224_1.GasAtm > this.AtmospherePressure * 0.3)
            {
                SystemBodyAtmosphericGas gclass224_2 = this.AtmosphericGasList.FirstOrDefault<SystemBodyAtmosphericGas>(gclass224_0 =>
                    gclass224_0.Gas == this.gclass0_0.AtmosphericGasDictionary[GasType.Nitrogen]);
                if (gclass224_2 == null)
                {
                    gclass224_2 = new SystemBodyAtmosphericGas();
                    gclass224_2.Gas = this.gclass0_0.AtmosphericGasDictionary[GasType.Nitrogen];
                    gclass224_2.SystemBodyID = this.SystemBodyID;
                    gclass224_2.GasAtm = 0.0;
                    gclass224_2.AtmoGasAmount = 0.0;
                    gclass224_2.FrozenOut = false;
                    this.AtmosphericGasList.Add(gclass224_1);
                }

                double num2 = gclass224_1.GasAtm / 0.3 + 0.01;
                double num3 = num2 - this.AtmospherePressure;
                if (num3 + this.AtmospherePressure < gclass194_1.double_2)
                {
                    gclass224_2.GasAtm = num2;
                    num1 += num3;
                    this.method_57(gclass21_0, gclass194_1);
                }
            }

            return num1 / double_45;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3834);
            return 0.0;
        }
    }

    public double method_56(GameRace gclass21_0, Species gclass194_1, double double_45)
    {
        try
        {
            // ISSUE: object of a compiler-generated type is created
            // ISSUE: variable of a compiler-generated type
            SystemBodyData.Class316 class316 = new SystemBodyData.Class316();
            if (this.double_31 < gclass194_1.double_11 && this.double_32 > gclass194_1.double_12)
                return 0.0;
            double num1 = 0.0;
            double num2 = 0.0;
            double num3 = 0.0;
            if (this.double_31 > gclass194_1.double_11)
                num2 = this.double_31 - gclass194_1.double_11;
            if (this.double_32 < gclass194_1.double_12)
                num3 = gclass194_1.double_12 - this.double_32;
            // ISSUE: reference to a compiler-generated field
            class316.gclass223_0 = new AtmosphericGasDefinition();
            if (num2 > 0.0 && num2 > num3)
            {
                // ISSUE: reference to a compiler-generated field
                class316.gclass223_0 = this.gclass0_0.AtmosphericGasDictionary[GasType.Frigusium];
            }
            else
            {
                if (num3 <= 0.0 || num3 <= num2)
                    return 0.0;
                // ISSUE: reference to a compiler-generated field
                class316.gclass223_0 = this.gclass0_0.AtmosphericGasDictionary[GasType.Aestusium];
            }

            // ISSUE: reference to a compiler-generated method
            SystemBodyAtmosphericGas gclass224 = this.AtmosphericGasList.Where<SystemBodyAtmosphericGas>(class316.method_0).FirstOrDefault<SystemBodyAtmosphericGas>();
            if (gclass224 == null)
            {
                gclass224 = new SystemBodyAtmosphericGas();
                // ISSUE: reference to a compiler-generated field
                gclass224.Gas = class316.gclass223_0;
                gclass224.SystemBodyID = this.SystemBodyID;
                gclass224.GasAtm = 0.0;
                gclass224.AtmoGasAmount = 0.0;
                gclass224.FrozenOut = false;
                this.AtmosphericGasList.Add(gclass224);
            }

            Decimal decimal1 = this.MaxColonyCost;
            while (true)
            {
                gclass224.GasAtm += 0.001;
                num1 += 0.001;
                this.method_57(gclass21_0, gclass194_1);
                if (!(this.MaxColonyCost == 0M))
                {
                    if (!(this.MaxColonyCost > decimal1))
                        decimal1 = this.MaxColonyCost;
                    else
                        break;
                }
                else
                    goto label_19;
            }

            gclass224.GasAtm -= 0.001;
            num1 -= 0.001;
            if (gclass224.GasAtm == 0.0)
                this.AtmosphericGasList.Remove(gclass224);
            this.method_57(gclass21_0, gclass194_1);
            label_19:
            return num1 / double_45;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3832);
            return 0.0;
        }
    }

    public void method_57(GameRace gclass21_0, Species gclass194_1)
    {
        try
        {
            this.method_46();
            this.method_36(gclass21_0);
            this.method_35();
            this.method_32();
            this.method_58(gclass21_0, gclass194_1, true);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3833);
        }
    }

    public Decimal method_58(GameRace gclass21_0, Species gclass194_1, bool bool_10)
    {
        try
        {
            this.ColonyCost = 0M;
            this.MaxColonyCost = 0M;
            double num1 = 0.0;
            if (this.double_27 <= 0.0)
            {
                this.DistanceToParent = this.OrbitalDistance;
                this.double_27 = this.OrbitalDistance * (1.0 - this.Eccentricity);
                this.double_28 = this.OrbitalDistance * (1.0 + this.Eccentricity);
            }

            if (gclass194_1 == null)
                gclass194_1 = gclass21_0.method_164();
            if (this.BodyTypeId != AuroraSystemBodyType.GasGiant &&
                this.BodyTypeId != AuroraSystemBodyType.Superjovian && this.Gravity <= gclass194_1.double_8 &&
                !this.IsFixedBody)
            {
                double num2 = this.method_43(gclass194_1);
                if (this.SurfaceTemp < gclass194_1.double_12)
                    num1 = Math.Abs(gclass194_1.double_12 - this.SurfaceTemp) / gclass194_1.double_4;
                else if (this.SurfaceTemp > gclass194_1.double_11)
                    num1 = Math.Abs(gclass194_1.double_11 - this.SurfaceTemp) / gclass194_1.double_4;
                if (this.TidalLock && this.BodyClass != PlanetBodyClass.Moon)
                    num1 /= 5.0;
                if (num1 > num2)
                    num2 = num1;
                double num3 = 0.0;
                if (this.AtmospherePressure > gclass194_1.double_2)
                {
                    num3 = this.AtmospherePressure / gclass194_1.double_2;
                    if (num3 < 2.0)
                        num3 = 2.0;
                }

                if (num2 < num3)
                    num2 = num3;
                if (Math.Round(num2, 4) < 2.0)
                {
                    double num4 = this.method_45(gclass194_1.gclass223_0);
                    if (num4 >= gclass194_1.double_9 && num4 <= gclass194_1.double_10)
                    {
                        if (this.method_44(gclass194_1.gclass223_0) > AuroraUtils.int_22)
                            num2 = 2.0;
                    }
                    else
                        num2 = 2.0;
                }

                if (this.HydroExtent < 20.0)
                {
                    double num5 = (20.0 - this.HydroExtent) / 10.0;
                    if (num2 < num5)
                        num2 = num5;
                }

                if (this.Gravity < gclass194_1.double_7 && num2 < 1.0)
                    num2 = 1.0;
                this.ColonyCost = (Decimal)Math.Round(num2, 4) * gclass21_0.ColonizationSkill;
            }
            else
            {
                this.ColonyCost = -1M;
                this.MaxColonyCost = -1M;
                this.double_31 = this.method_51(this.double_27);
                this.double_32 = this.method_51(this.double_28);
                this.double_33 = this.double_31 <= this.double_32 ? this.double_32 : this.double_31;
            }

            if (bool_10 && this.ColonyCost > -1M &&
                (this.Eccentricity > 0.0 || this.BodyClass == PlanetBodyClass.Moon))
            {
                if (this.BodyClass == PlanetBodyClass.Moon)
                {
                    if (this.ParentBodyData.double_27 <= 0.0)
                    {
                        this.ParentBodyData.double_27 = this.ParentBodyData.OrbitalDistance * (1.0 - this.ParentBodyData.Eccentricity);
                        this.ParentBodyData.double_28 = this.ParentBodyData.OrbitalDistance * (1.0 + this.ParentBodyData.Eccentricity);
                    }

                    this.double_34 = this.method_52(gclass21_0, gclass194_1, this.ParentBodyData.double_27, GEnum81.const_1);
                    this.double_35 = this.method_52(gclass21_0, gclass194_1, this.ParentBodyData.double_28, GEnum81.const_2);
                }
                else
                {
                    this.double_34 = this.method_52(gclass21_0, gclass194_1, this.double_27, GEnum81.const_1);
                    this.double_35 = this.method_52(gclass21_0, gclass194_1, this.double_28, GEnum81.const_2);
                }

                double num6;
                if (this.double_34 > this.double_35)
                {
                    this.double_33 = this.double_31;
                    num6 = this.double_34;
                }
                else
                {
                    this.double_33 = this.double_32;
                    num6 = this.double_35;
                }

                this.MaxColonyCost = !((Decimal)num6 > this.ColonyCost) ? this.ColonyCost : (Decimal)num6;
            }
            else
            {
                this.MaxColonyCost = this.ColonyCost;
                this.double_34 = (double)this.ColonyCost;
                this.double_35 = (double)this.ColonyCost;
                this.double_31 = this.SurfaceTemp;
                this.double_32 = this.SurfaceTemp;
                this.double_33 = this.SurfaceTemp;
            }

            return this.ColonyCost;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3040);
            return -2M;
        }
    }

    public string GetAtmosphericRepresetationString()
    {
        //TODO: stringbuilder would be better...
        try
        {
            if (this.AtmospherePressure > 20.0 && this.SurfaceTemp > 500.0)
            {
                return UITextHelper.GetLocalizedStringFor(LocalizedText.VenusianAtmosphere);
            }

            if (!AtmosphericGasList.Any())
            {
                return "-";
            }

            var majorGas = AtmosphericGasList[0];
            var secondGas = AtmosphericGasList.Count > 1 ? AtmosphericGasList[1] : null;
            
            string basePart = majorGas.Gas.Type switch
            {
                GasType.CarbonDioxide => "CO2",
                GasType.WaterVapor => UITextHelper.GetLocalizedStringFor(LocalizedText.VaporFormWater),
                _ => majorGas.Gas.Type.ToLocalizedString()
            };

            string formPart = string.Empty;

            
            var oxygenComponent = AtmosphericGasList
                .FirstOrDefault(gas => gas.Gas.Type == GasType.Oxygen);
            // If Oxygen exists and it's NOT the major gas, it takes priority for the second slot
            if (oxygenComponent != null && majorGas.Gas.Type != GasType.Oxygen)
            {
                formPart = $" - {GasType.Oxygen.ToLocalizedString()} ({AuroraUtils.FormatDoubleToPrecision(oxygenComponent.AtmoGasAmount, 2)})"; 
            }
            else if (secondGas != null)
            {
                formPart =
                    $" - {(secondGas.Gas.Type switch { GasType.CarbonDioxide => "CO2", GasType.WaterVapor => UITextHelper.GetLocalizedStringFor(LocalizedText.VaporFormWater), _ => secondGas.Gas.Type.ToLocalizedString() })}";
            }

            return basePart + formPart;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3041);
            return "-";
        }
    }

    public void method_60(
        ListView listView_0,
        CheckState checkState_0,
        CheckState checkState_1,
        CheckState checkState_2,
        CheckState checkState_3,
        CheckState checkState_4,
        GameRace gclass21_0,
        Species gclass194_1,
        bool bool_10)
    {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        SystemBodyData.Class317 class317 = new SystemBodyData.Class317();
        // ISSUE: reference to a compiler-generated field
        class317.gclass21_0 = gclass21_0;
        // ISSUE: reference to a compiler-generated field
        class317.gclass1_0 = this;
        try
        {
            Color color_0 = AuroraUtils.color_16;
            string str1 = "-";
            string string_17 = "-";
            string str2 = "";
            string string_18 = "-";
            string string_16 = "-";
            string string_31 = "-";
            string string_30 = "-";
            string string_23 = "-";
            string string_24 = "-";
            List<string> stringList = new List<string>();
            // ISSUE: reference to a compiler-generated field
            string str3 = this.method_78(class317.gclass21_0);
            this.AtmosphericGasList = this.AtmosphericGasList.OrderByDescending<SystemBodyAtmosphericGas, double>(gclass224_0 => gclass224_0.GasAtm)
                .ToList<SystemBodyAtmosphericGas>();
            if (this.AtmosphericGasList.Count > 0)
            {
                string_18 = AuroraUtils.smethod_50(this.AtmospherePressure);
                if (this.AtmosphericGasList.Count<SystemBodyAtmosphericGas>(gclass224_0 => gclass224_0.FrozenOut) > 0)
                    string_18 += "F";
                string_17 = this.GetAtmosphericRepresetationString();
            }

            // ISSUE: reference to a compiler-generated method
            foreach (PopulationData gclass146 in this.gclass0_0.Populations.Values.Where<PopulationData>(class317.method_0)
                         .OrderByDescending<PopulationData, Decimal>(gclass146_0 => gclass146_0.decimal_30)
                         .ToList<PopulationData>())
            {
                // ISSUE: reference to a compiler-generated field
                str1 = !(gclass146.PopName == str3)
                    ? string.Format("{0} {1}", gclass146.PopName, AuroraUtils.smethod_61(gclass146.decimal_30, "m"))
                    : string.Format("{0} {1}", class317.gclass21_0.RaceName,
                        AuroraUtils.smethod_61(gclass146.decimal_30, "m"));
                stringList.Add(str1);
            }

            // ISSUE: reference to a compiler-generated field
            bool flag = this.method_77(class317.gclass21_0);
            if (this.RuinData != null && flag)
                stringList.Add(this.RuinData.Description);
            if (this.AncientConstruct != null && flag)
                stringList.Add(this.AncientConstruct.method_0());
            if (stringList.Count == 0)
                stringList.Add(str1);
            if (this.HydroExtent > 0.0)
                string_16 =
                    string.Format("{0} {1}%", AuroraUtils.smethod_82(this.HydrosphereTypeId),
                        AuroraUtils.FormatDoubleToPrecision(this.HydroExtent, 1));
            if (this.TectonicActivity != AuroraTectonics.Dead)
                string_30 = AuroraUtils.smethod_82(this.TectonicActivity);
            if (this.MagneticField > 0.0)
                string_31 = AuroraUtils.smethod_52(this.MagneticField);
            if (this.TidalLock)
                string_23 = this.BodyClass != PlanetBodyClass.Moon ? UITextHelper.GetLocalizedStringFor(LocalizedText.TidalLockYes) : UITextHelper.GetLocalizedStringFor(LocalizedText.TidalLockYesMoon);
            // ISSUE: reference to a compiler-generated field
            Decimal num1 = this.method_58(class317.gclass21_0, gclass194_1, true);
            if (checkState_3 == CheckState.Checked && this.MaxColonyCost > 0M)
                num1 = this.MaxColonyCost;
            Decimal num2 = 1M;
            // ISSUE: reference to a compiler-generated field
            TechSystem gclass164 =
                class317.gclass21_0.method_388(this.gclass0_0.TechTypeDataDictionary[TechType.ColonizationCostReduction]);
            if (gclass164 != null)
                num2 = Math.Round(gclass164.decimal_0, 2);
            if (num1 >= 0M)
            {
                if (num1 < 2M * num2)
                    color_0 = Color.DodgerBlue;
                else if (num1 < 3M * num2)
                    color_0 = Color.Cyan;
                else if (num1 < 6M * num2 && this.Gravity > gclass194_1.double_7)
                    color_0 = Color.Chocolate;
            }

            this.method_62(gclass194_1);
            if (this.PopulationCapacity_Probably > 0M)
                string_24 = AuroraUtils.smethod_53(this.PopulationCapacity_Probably);
            string string_11 = "";
            if (checkState_0 == CheckState.Checked && this.MineralDeposits.Count > 0 && flag)
                string_11 = "M";
            if (checkState_1 == CheckState.Checked && !flag)
                string_11 = "U";
            // ISSUE: reference to a compiler-generated field
            if (checkState_4 == CheckState.Checked &&
                this.Radius * 2.0 <= class317.gclass21_0.MaximumOrbitalMiningDiameter &&
                (this.MineralDeposits.Count > 0 || !flag))
                string_11 += "E";
            if (checkState_2 == CheckState.Checked &&
                this.GroundMineralSurveyState != AuroraGroundMineralSurvey.Completed && flag)
                string_11 += ((int)this.GroundMineralSurveyState).ToString();
            string string_15 = "-";
            if (this.DominantTerrain.DominantTerrainType != PlanetDominantTerrain.const_0)
                string_15 = this.DominantTerrain.Name;
            string string_12 = AuroraUtils.smethod_82(this.BodyTypeId);
            if (bool_10)
            {
                // ISSUE: reference to a compiler-generated field
                string_12 = class317.gclass21_0.method_277(this.SystemData.SystemID);
            }

            // ISSUE: reference to a compiler-generated field
            string string_10 = str2 + this.method_78(class317.gclass21_0);
            if (this.BodyClass == PlanetBodyClass.Moon && !bool_10)
            {
                // ISSUE: reference to a compiler-generated field
                string_10 = $"    {this.method_79(class317.gclass21_0, true, false)}";
            }

            // ISSUE: reference to a compiler-generated field
            if (class317.gclass21_0.BannedSystemBodies.Contains(this))
                string_10 += " (B)";
            string string_43 = this.method_61(false, false);
            string string_19 = AuroraUtils.smethod_50(this.SurfaceTemp - AuroraUtils.int_17);
            if (checkState_3 == CheckState.Checked)
                string_19 = AuroraUtils.smethod_50(this.double_33 - AuroraUtils.int_17);
            GEnum80 genum80_0 = GEnum80.const_0;
            if (checkState_3 == CheckState.Checked)
                genum80_0 = GEnum80.const_1;
            string string_27 = "-";
            string string_28 = "-";
            string string_25 = "-";
            string string_26 = "-";
            if (this.Eccentricity > 0.0)
            {
                string_27 = AuroraUtils.FormatDoubleToPrecision(this.Eccentricity, 3);
                double double_32 = this.EccentricityDirection + 90.0;
                if (double_32 >= 360.0)
                    double_32 -= 360.0;
                string_28 = AuroraUtils.FormatDoubleToPrecision(double_32, 1);
                string_25 = this.method_65();
                string_26 = this.method_66();
            }

            this.gclass0_0.method_631(listView_0, string_10, string_11, string_12,
                this.method_47(gclass194_1, genum80_0), stringList[0], string_15, string_16, string_17, string_18,
                string_19, AuroraUtils.smethod_52(this.Gravity), this.method_64(),
                AuroraUtils.smethod_50(this.Radius * 2.0), string_23, string_24, string_25, string_26, string_27,
                string_28, AuroraUtils.smethod_57(this.Year), string_30, string_31,
                AuroraUtils.smethod_52(this.GreenhouseFactor), AuroraUtils.smethod_52(this.AntiGreenhouseFactor),
                AuroraUtils.smethod_52(this.Albedo), AuroraUtils.smethod_57(this.Day),
                AuroraUtils.smethod_52(this.Mass), AuroraUtils.smethod_52(this.Density),
                AuroraUtils.smethod_52(this.Escape * 11.18), AuroraUtils.smethod_51(this.Tilt),
                AuroraUtils.smethod_50(this.BaseTemp - AuroraUtils.int_17), AuroraUtils.FormatNumberToDigits(this.RadiationLevel, 0),
                AuroraUtils.FormatNumberToDigits(this.DustLevel, 0), string_43, color_0, this);
            for (int index = 1; stringList.Count > index; ++index)
            {
                string string_14 = stringList[index];
                this.gclass0_0.method_606(listView_0, "", "", "", "", string_14, color_0, this);
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3042);
        }
    }

    public string method_61(bool bool_10, bool bool_11)
    {
        try
        {
            if (this.Mass < 0.25 || this.BodyTypeId == AuroraSystemBodyType.Comet)
                return "-";
            if (this.gclass0_0.LagrangePoints.Values.Count<LagrangePoint>(gclass212_0 => gclass212_0.Planet == this) >
                0 && bool_10)
                return "Existing LP";
            string str = AuroraUtils.FormatDoubleToPrecision(60.0 / Math.Sqrt(this.Mass) / 12.0, 2);
            return bool_11 ? $"{str} years" : str;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3043);
            return "-";
        }
    }

    public Decimal method_62(Species gclass194_1)
    {
        try
        {
            if (this.ColonyCost == -1M)
            {
                this.PopulationCapacity_Probably = 0M;
                return 0M;
            }

            this.PopulationCapacity_Probably = (Decimal)(4.0 * AuroraUtils.PI_Apprx * Math.Pow(this.Radius, 2.0)) /
                AuroraUtils.decimal_15 * AuroraUtils.int_16;
            if (gclass194_1 != null)
                this.PopulationCapacity_Probably *= gclass194_1.decimal_0;
            if (this.HydroExtent > 75.0)
            {
                double num = (100.0 - this.HydroExtent) / 25.0;
                if (num < 0.01)
                    num = 0.01;
                this.PopulationCapacity_Probably *= (Decimal)num;
            }

            if (this.TidalLock && this.BodyClass != PlanetBodyClass.Moon)
                this.PopulationCapacity_Probably /= 5M;
            if (this.PopulationCapacity_Probably < 0.05M)
                this.PopulationCapacity_Probably = 0.05M;
            return this.PopulationCapacity_Probably;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3044);
            return 0M;
        }
    }

    public string method_63(AuroraSystemBodyType auroraSystemBodyType_1)
    {
        try
        {
            return AuroraUtils.smethod_82((AuroraSystemBodyTypeAbbrev)auroraSystemBodyType_1);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3045);
            return "error";
        }
    }

    public string method_64()
    {
        try
        {
            if (this.BodyClass != PlanetBodyClass.Moon)
                return AuroraUtils.smethod_1(this.DistanceToParent);
            return this.OrbitalDistance > 1000000.0
                ? $"{AuroraUtils.smethod_50(this.OrbitalDistance / 1000000.0)}m"
                : $"{AuroraUtils.smethod_43(this.OrbitalDistance / 1000.0)}k";
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3046);
            return "error";
        }
    }

    public string method_65()
    {
        try
        {
            if (this.BodyClass != PlanetBodyClass.Moon)
                return AuroraUtils.smethod_1(this.double_27);
            return this.OrbitalDistance > 1000000.0
                ? $"{AuroraUtils.smethod_50(this.OrbitalDistance / 1000000.0)}m"
                : $"{AuroraUtils.smethod_43(this.OrbitalDistance / 1000.0)}k";
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3452);
            return "error";
        }
    }

    public string method_66()
    {
        try
        {
            if (this.BodyClass != PlanetBodyClass.Moon)
                return AuroraUtils.smethod_1(this.double_28);
            return this.OrbitalDistance > 1000000.0
                ? $"{AuroraUtils.smethod_50(this.OrbitalDistance / 1000000.0)}m"
                : $"{AuroraUtils.smethod_43(this.OrbitalDistance / 1000.0)}k";
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3451);
            return "error";
        }
    }

    public void method_67(ListView listView_0, ListView listView_1, GameRace gclass21_0)
    {
        try
        {
            listView_0.Items.Clear();
            listView_1.Items.Clear();
            Species gclass194_1 = gclass21_0.method_164();
            this.method_27();
            this.method_58(gclass21_0, gclass194_1, true);
            this.gclass0_0.method_597(listView_0, LocalizedText.NameLiteral.GetText(), this.method_78(gclass21_0));
            this.gclass0_0.method_597(listView_0, LocalizedText.ColonyCost.GetText(),
                this.method_47(gclass21_0.method_164(), GEnum80.const_0));
            if (this.IsFixedBody)
            {
                this.gclass0_0.method_597(listView_0, LocalizedText.OrbitalDistance.GetText(),
                    string.Format("{0}  ({1})",
                        AuroraUtils.smethod_59(this.OrbitalDistance * AuroraUtils.double_14, "km"),
                        AuroraUtils.smethod_59(this.OrbitalDistance, "AU")));
                this.gclass0_0.method_597(listView_0, "Temperature",
                    AuroraUtils.smethod_59(this.BaseTemp - AuroraUtils.int_17, "C"));
            }
            else
            {
                if (this.MaxColonyCost > this.ColonyCost && this.MaxColonyCost > 0M)
                    this.gclass0_0.method_597(listView_0, LocalizedText.MaxColonyCost.GetText(),
                        this.method_47(gclass21_0.method_164(), GEnum80.const_1));
                this.gclass0_0.method_597(listView_0, LocalizedText.BodyType.GetText(), AuroraUtils.smethod_82(this.BodyTypeId));
                this.gclass0_0.method_597(listView_0, LocalizedText.Diameter.GetText(), AuroraUtils.smethod_59(this.Radius * 2.0, "km"));
                if (this.BodyClass == PlanetBodyClass.Moon)
                    this.gclass0_0.method_597(listView_0, LocalizedText.OrbitalDistance.GetText(),
                        AuroraUtils.smethod_59(this.OrbitalDistance, "km"));
                else if (this.Eccentricity > 0.0)
                {
                    this.gclass0_0.method_597(listView_0, LocalizedText.CurrentDistance.GetText(),
                        string.Format("{0}  ({1})",
                            AuroraUtils.smethod_59(this.OrbitalDistance * AuroraUtils.double_14, "km"),
                            AuroraUtils.smethod_59(this.OrbitalDistance, "AU")));
                    this.gclass0_0.method_597(listView_0, LocalizedText.Perihelion.GetText(),
                        string.Format("{0}  ({1})",
                            AuroraUtils.smethod_59(this.double_27 * AuroraUtils.double_14, "km"),
                            AuroraUtils.smethod_59(this.double_27, "AU")));
                    this.gclass0_0.method_597(listView_0, LocalizedText.Aphelion.GetText(),
                        string.Format("{0}  ({1})",
                            AuroraUtils.smethod_59(this.double_28 * AuroraUtils.double_14, "km"),
                            AuroraUtils.smethod_59(this.double_28, "AU")));
                    this.gclass0_0.method_597(listView_0, LocalizedText.Eccentricity.GetText(), AuroraUtils.FormatDoubleToPrecision(this.Eccentricity, 4));
                    double double_32 = this.EccentricityDirection + 90.0;
                    if (double_32 >= 360.0)
                        double_32 -= 360.0;
                    this.gclass0_0.method_597(listView_0, LocalizedText.Inclination.GetText(),
                        AuroraUtils.FormatDoubleToPrecision(double_32, 4) + char.ConvertFromUtf32(176 /*0xB0*/));
                }
                else
                    this.gclass0_0.method_597(listView_0, LocalizedText.OrbitalDistance.GetText(),
                        string.Format("{0}  ({1})",
                            AuroraUtils.smethod_59(this.OrbitalDistance * AuroraUtils.double_14, "km"),
                            AuroraUtils.smethod_59(this.OrbitalDistance, "AU")));

                this.gclass0_0.method_597(listView_0, LocalizedText.Gravity.GetText(), AuroraUtils.smethod_59(this.Gravity, "G"));
                if (this.AtmosphericGasList.Count == 0)
                {
                    this.gclass0_0.method_597(listView_0, LocalizedText.Atmosphere.GetText(), LocalizedText.None.GetText());
                }
                else
                {
                    this.gclass0_0.method_597(listView_0, LocalizedText.Atmosphere.GetText(),
                        LocalizedText.AtmosphericPressure.GetText() + AuroraUtils.smethod_59(this.AtmospherePressure, " atm"));
                    this.AtmosphericGasList = this.AtmosphericGasList.OrderByDescending<SystemBodyAtmosphericGas, double>(gclass224_0 => gclass224_0.GasAtm)
                        .ToList<SystemBodyAtmosphericGas>();
                    foreach (SystemBodyAtmosphericGas gclass224 in this.AtmosphericGasList)
                        this.gclass0_0.method_597(listView_0, "",
                            string.Format("{0} {1}", gclass224.Gas.Name,
                                AuroraUtils.smethod_59(gclass224.AtmoGasAmount, "%")));
                }

                this.gclass0_0.method_597(listView_0, LocalizedText.Hydrosphere.GetText(), AuroraUtils.smethod_82(this.HydrosphereTypeId));
                this.gclass0_0.method_597(listView_0, LocalizedText.HydroExtent.GetText(), AuroraUtils.smethod_59(this.HydroExtent, "%"));
                this.gclass0_0.method_597(listView_0, LocalizedText.Year.GetText(), AuroraUtils.smethod_31(this.Year));
                this.gclass0_0.method_597(listView_0, "Day", AuroraUtils.smethod_31(this.Day));
                this.gclass0_0.method_597(listView_0, LocalizedText.SurfaceTemperature.GetText(),
                    AuroraUtils.smethod_59(this.SurfaceTemp - AuroraUtils.int_17, "C"));
                this.gclass0_0.method_597(listView_0, LocalizedText.Tectonics.GetText(), AuroraUtils.smethod_82(this.TectonicActivity));
                this.gclass0_0.method_597(listView_0, LocalizedText.Mass.GetText(), AuroraUtils.smethod_48(this.Mass));
                this.gclass0_0.method_597(listView_0, LocalizedText.Density.GetText(), AuroraUtils.smethod_48(this.Density));
                ListViewItem listViewItem = new ListViewItem("");
                if (this.TidalLock)
                    this.gclass0_0.method_597(listView_0, LocalizedText.TidalLockLiteral.GetText(), "Yes");
                else
                    this.gclass0_0.method_597(listView_0, LocalizedText.TidalLockLiteral.GetText(), "No");
                this.gclass0_0.method_597(listView_0, LocalizedText.BaseTemperature.GetText(),
                    AuroraUtils.smethod_59(this.BaseTemp - AuroraUtils.int_17, "C"));
                this.gclass0_0.method_597(listView_0, LocalizedText.Albedo.GetText(), AuroraUtils.FormatDoubleToPrecision(this.Albedo, 2));
                this.gclass0_0.method_597(listView_0, LocalizedText.GreenhouseFactor.GetText(),
                    AuroraUtils.FormatDoubleToPrecision(this.GreenhouseFactor, 2));
                this.gclass0_0.method_597(listView_0, "Anti-GH Factor", AuroraUtils.FormatDoubleToPrecision(this.AntiGreenhouseFactor, 2));
                if (this.method_77(gclass21_0))
                {
                    if (this.MineralDeposits.Count > 0)
                    {
                        foreach (MineralDeposit gclass124 in this.MineralDeposits.Values)
                            this.gclass0_0.method_601(listView_1, gclass124.MaterialID.ToString(),
                                $"{string.Format("{0:0,0}", gclass124.Amount)}  tons",
                                $"Acc  {gclass124.Accessibility}");
                    }
                }
                else
                    this.gclass0_0.method_594(listView_1, "No Survey");
            }

            listView_0.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listView_1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listView_1.Columns[0].Width = listView_0.Columns[0].Width;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3047);
        }
    }

    public void method_68(ListView listView_0, GameRace gclass21_0)
    {
        try
        {
            listView_0.Items.Clear();
            if (this.method_77(gclass21_0))
            {
                if (this.MineralDeposits.Count <= 0)
                    return;
                this.MineralDeposits = this.MineralDeposits
                    .OrderBy<KeyValuePair<AuroraElement, MineralDeposit>,
                        AuroraElement>(keyValuePair_0 => keyValuePair_0.Value.MaterialID)
                    .ToDictionary<KeyValuePair<AuroraElement, MineralDeposit>, AuroraElement, MineralDeposit>(
                        keyValuePair_0 => keyValuePair_0.Key, keyValuePair_0 => keyValuePair_0.Value);
                foreach (MineralDeposit gclass124 in this.MineralDeposits.Values)
                    this.gclass0_0.method_601(listView_0, gclass124.MaterialID.ToString(),
                        string.Format("{0:0,0}", gclass124.Amount), AuroraUtils.smethod_45(gclass124.Accessibility, 2));
            }
            else
                this.gclass0_0.method_594(listView_0, "No Survey");
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3048);
        }
    }

    public void method_69(TextBox textBox_0, GameRace gclass21_0)
    {
        try
        {
            string str = string.Format("{0} Survey Report{1}", this.method_78(gclass21_0), Environment.NewLine);
            if (this.method_77(gclass21_0))
            {
                if (this.MineralDeposits.Count > 0)
                {
                    foreach (MineralDeposit gclass124 in this.MineralDeposits.Values)
                        str =
                            string.Format("{0}{1}:   {2}   {3}{4}", str, gclass124.MaterialID.ToString(),
                                string.Format("{0:0,0}", gclass124.Amount),
                                AuroraUtils.smethod_45(gclass124.Accessibility, 2), Environment.NewLine);
                }
            }
            else
                str = "No Survey";

            textBox_0.Text = str;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3049);
        }
    }

    public void method_70(ListView listView_0, PopulationData gclass146_0, bool bool_10)
    {
        try
        {
            listView_0.Items.Clear();
            if (this.BodyTypeId == AuroraSystemBodyType.GasGiant || this.BodyTypeId == AuroraSystemBodyType.Superjovian)
                return;
            int int_72 = 3;
            if (bool_10)
                int_72 = 4;
            double num1 = 0.0;
            double double_45 = 0.0;
            double double_46 = 0.0;
            double double_32_1 = 0.0;
            double double_32_2 = 0.0;
            this.AtmosphericGasList = this.AtmosphericGasList.OrderByDescending<SystemBodyAtmosphericGas, double>(gclass224_0 => gclass224_0.GasAtm)
                .ToList<SystemBodyAtmosphericGas>();
            if (this.AtmosphericGasList.Count > 0)
            {
                this.gclass0_0.method_601(listView_0, "Gas", "%", "atm");
                if (this.AtmosphericGasList.Count > 0)
                {
                    foreach (SystemBodyAtmosphericGas gclass224 in this.AtmosphericGasList)
                        num1 += gclass224.GasAtm;
                    foreach (SystemBodyAtmosphericGas object_1 in this.AtmosphericGasList)
                    {
                        string name = object_1.Gas.Name;
                        if (object_1.FrozenOut)
                            name += " (F)";
                        else if (object_1.Gas.GHGas)
                        {
                            double_45 += object_1.GasAtm;
                            double_32_1 += object_1.GasAtm;
                        }
                        else if (object_1.Gas.AntiGHGas)
                        {
                            double_46 += object_1.GasAtm;
                            double_32_2 += object_1.GasAtm;
                        }

                        object_1.AtmoGasAmount = object_1.GasAtm / num1 * 100.0;
                        this.gclass0_0.method_602(listView_0, name, AuroraUtils.smethod_46(object_1.AtmoGasAmount, 3),
                            AuroraUtils.smethod_46(object_1.GasAtm, int_72), object_1);
                    }
                }

                this.gclass0_0.method_594(listView_0, "");
            }

            this.method_28(double_45, double_46);
            if (bool_10)
            {
                this.gclass0_0.method_601(listView_0, "Atmospheric Pressure",
                    AuroraUtils.smethod_46(this.AtmospherePressure, 3), null);
                this.gclass0_0.method_601(listView_0, "Greenhouse Gas Pressure", AuroraUtils.smethod_46(double_32_1, 3),
                    null);
                this.gclass0_0.method_601(listView_0, "Anti-Greenhouse Gas Pressure",
                    AuroraUtils.smethod_46(double_32_2, 3), null);
                this.gclass0_0.method_601(listView_0, "Greenhouse Factor",
                    AuroraUtils.smethod_46(this.GreenhouseFactor, 3), null);
                this.gclass0_0.method_601(listView_0, "Anti-Greenhouse Factor",
                    AuroraUtils.smethod_46(this.AntiGreenhouseFactor, 3), null);
                if (this.DustLevel > 0M)
                    this.gclass0_0.method_601(listView_0, "Dust Effective Atm",
                        AuroraUtils.smethod_45(this.DustLevel / 20000M, 3), null);
                this.gclass0_0.method_601(listView_0, "Albedo Factor", AuroraUtils.smethod_46(this.Albedo, 3), null);
                this.gclass0_0.method_594(listView_0, "");
                double double_32_3 = 0.0;
                double double_32_4 = 0.0;
                double double_32_5 = 0.0;
                if (gclass146_0.Species.double_12 > this.SurfaceTemp)
                    double_32_3 = this.SurfaceTemp - gclass146_0.Species.double_12;
                else if (this.SurfaceTemp > gclass146_0.Species.double_11)
                    double_32_3 = this.SurfaceTemp - gclass146_0.Species.double_11;
                if (gclass146_0.Species.double_12 > this.double_32)
                    double_32_4 = this.double_32 - gclass146_0.Species.double_12;
                else if (this.double_32 > gclass146_0.Species.double_11)
                    double_32_4 = this.double_32 - gclass146_0.Species.double_11;
                if (gclass146_0.Species.double_12 > this.double_31)
                    double_32_5 = this.double_31 - gclass146_0.Species.double_12;
                else if (this.double_31 > gclass146_0.Species.double_11)
                    double_32_5 = this.double_31 - gclass146_0.Species.double_11;
                this.gclass0_0.method_601(listView_0, "Base Temperature (Celsius)",
                    AuroraUtils.smethod_46(this.BaseTemp - AuroraUtils.int_17, 3), null);
                this.gclass0_0.method_601(listView_0, "Surface Temperature (Celsius)",
                    AuroraUtils.smethod_46(this.SurfaceTemp - AuroraUtils.int_17, 3), null);
                this.gclass0_0.method_594(listView_0, "");
                this.gclass0_0.method_601(listView_0, "Minimum Temperature (Celsius)",
                    AuroraUtils.smethod_46(this.double_32 - AuroraUtils.int_17, 3), null);
                this.gclass0_0.method_601(listView_0, "Maximum Temperature (Celsius)",
                    AuroraUtils.smethod_46(this.double_31 - AuroraUtils.int_17, 3), null);
                this.gclass0_0.method_594(listView_0, "");
                this.gclass0_0.method_601(listView_0, "Current Temp vs Species", AuroraUtils.smethod_46(double_32_3, 3),
                    null);
                this.gclass0_0.method_601(listView_0, "Min Temp vs Species", AuroraUtils.smethod_46(double_32_4, 3),
                    null);
                this.gclass0_0.method_601(listView_0, "Max Temp vs Species", AuroraUtils.smethod_46(double_32_5, 3),
                    null);
                this.gclass0_0.method_594(listView_0, "");
                this.gclass0_0.method_601(listView_0, "Base Temperature (Kelvin)",
                    AuroraUtils.smethod_46(this.BaseTemp, 3), null);
                this.gclass0_0.method_601(listView_0, "Surface Temperature (Kelvin)",
                    AuroraUtils.smethod_46(this.SurfaceTemp, 3), null);
                this.gclass0_0.method_594(listView_0, "");
                this.gclass0_0.method_601(listView_0, "Hydrographic Extent",
                    AuroraUtils.smethod_46(this.HydroExtent, 2), null);
                this.gclass0_0.method_594(listView_0, "");
                this.gclass0_0.method_601(listView_0, "Radiation Level", AuroraUtils.smethod_45(this.RadiationLevel, 2),
                    null);
                this.gclass0_0.method_601(listView_0, "Atmospheric Dust Level",
                    AuroraUtils.smethod_45(this.DustLevel, 2), null);
                if (this.RadiationLevel > 0M)
                {
                    this.gclass0_0.method_601(listView_0, "Radiation Production Impact",
                        $"{AuroraUtils.smethod_45(this.RadiationLevel / 10000M, 2)}%", null);
                    this.gclass0_0.method_601(listView_0, "Radiation Growth Rate Impact",
                        $"{AuroraUtils.smethod_45(this.RadiationLevel * 0.0025M, 2)}%", null);
                }

                double num2 = 4.0 * AuroraUtils.PI_Apprx * Math.Pow(this.Radius, 2.0);
                double double_32_6 = (double)AuroraUtils.decimal_15 / num2;
                this.gclass0_0.method_594(listView_0, "");
                this.gclass0_0.method_601(listView_0, "Body Diameter", AuroraUtils.smethod_43(this.Radius * 2.0), null);
                this.gclass0_0.method_601(listView_0, "Terraform Rate vs Earth (1.00)",
                    AuroraUtils.smethod_46(double_32_6, 2), null);
                gclass146_0.method_100();
                if (!(gclass146_0.decimal_24 > 0M))
                    return;
                int num3 = (int)gclass146_0.method_62(AuroraProductionCategory.Terraforming);
                int num4 = gclass146_0.method_202(AuroraComponentType.TerraformingModule);
                if (num3 > 0 && num4 == 0)
                    this.gclass0_0.method_601(listView_0, "Terraforming Installations", num3.ToString(), null);
                else if (num3 == 0 && num4 > 0)
                    this.gclass0_0.method_601(listView_0, "Orbital Terraforming Modules", num4.ToString(), null);
                else
                    this.gclass0_0.method_601(listView_0, "Terraforming Modules (S/O)",
                        string.Format("{0} / {1}", num3.ToString(), num4.ToString()), null);
                double double_32_7 = (double)gclass146_0.decimal_24 * double_32_6;
                this.gclass0_0.method_601(listView_0, "Annual Terraform Capacity (atm)",
                    AuroraUtils.smethod_46(double_32_7, 4), null);
            }
            else
            {
                this.gclass0_0.method_603(listView_0, "GH Factor / Albedo",
                    AuroraUtils.smethod_46(this.GreenhouseFactor, 2), AuroraUtils.smethod_46(this.Albedo, 2), null);
                this.gclass0_0.method_603(listView_0, "AGH Factor / Dust", AuroraUtils.smethod_46(this.AntiGreenhouseFactor, 2),
                    AuroraUtils.smethod_45(this.DustLevel, 0), null);
                this.gclass0_0.method_601(listView_0, "Base/Surface Temp",
                    AuroraUtils.smethod_46(this.BaseTemp - AuroraUtils.int_17, 2),
                    AuroraUtils.smethod_46(this.SurfaceTemp - AuroraUtils.int_17, 2));
                this.gclass0_0.method_601(listView_0, "Min/Max Surface Temp",
                    AuroraUtils.smethod_46(this.double_32 - AuroraUtils.int_17, 2),
                    AuroraUtils.smethod_46(this.double_31 - AuroraUtils.int_17, 2));
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3050);
        }
    }

    public void method_71(
        GameRace gclass21_0,
        Species gclass194_1,
        CheckState checkState_0,
        Label label_0,
        Label label_1,
        Label label_2,
        Label label_3,
        Label label_4,
        Label label_5,
        Label label_6,
        Label label_7,
        Label label_8,
        Label label_9,
        int int_13)
    {
        try
        {
            string str1 = "2.00";
            string str2 = "0.00";
            string str3 = "1.00 LG";
            if (int_13 == 3)
            {
                str1 = "2.000";
                str2 = "0.000";
                str3 = "1.000 LG";
            }

            label_7.Text = this.method_48(gclass194_1, int_13, GEnum80.const_0);
            label_8.Text = this.method_48(gclass194_1, int_13, GEnum80.const_2);
            label_9.Text = this.method_48(gclass194_1, int_13, GEnum80.const_3);
            if (this.BodyTypeId != AuroraSystemBodyType.GasGiant && this.BodyTypeId != AuroraSystemBodyType.Superjovian)
            {
                if (this.Gravity < 0.1)
                    label_0.Text = UITextHelper.GetLocalizedStringFor(LocalizedText.CanRetainAtmoSphereNo);
                else
                    label_0.Text = UITextHelper.GetLocalizedStringFor(LocalizedText.CanRetainAtmoSphereYes);
                if (this.Gravity < gclass194_1.double_7)
                    label_1.Text = str3;
                else if (this.Gravity > gclass194_1.double_8)
                    label_1.Text = UITextHelper.GetLocalizedStringFor(LocalizedText.CanRetainAtmoSphereNo);
                else
                    label_1.Text = UITextHelper.GetLocalizedStringFor(LocalizedText.CanRetainAtmoSphereYes);
                double double_32_1 = 0.0;
                if (this.SurfaceTemp >= gclass194_1.double_12 && this.SurfaceTemp <= gclass194_1.double_11)
                {
                    label_2.Text = str2;
                }
                else
                {
                    if (this.SurfaceTemp < gclass194_1.double_12)
                        double_32_1 = Math.Abs(gclass194_1.double_12 - this.SurfaceTemp) / gclass194_1.double_4;
                    else if (this.SurfaceTemp > gclass194_1.double_11)
                        double_32_1 = Math.Abs(gclass194_1.double_11 - this.SurfaceTemp) / gclass194_1.double_4;
                    if (this.TidalLock && this.BodyClass != PlanetBodyClass.Moon)
                        double_32_1 /= 5.0;
                    label_2.Text = AuroraUtils.smethod_46(double_32_1, int_13);
                }

                if (this.AtmospherePressure > gclass194_1.double_2)
                {
                    double double_32_2 = this.AtmospherePressure / gclass194_1.double_2;
                    if (double_32_2 < 2.0)
                        double_32_2 = 2.0;
                    label_4.Text = AuroraUtils.smethod_46(double_32_2, int_13);
                }
                else
                    label_4.Text = str2;

                double num = this.method_45(gclass194_1.gclass223_0);
                if (num >= gclass194_1.double_9 && num <= gclass194_1.double_10)
                {
                    if (this.method_44(gclass194_1.gclass223_0) > AuroraUtils.int_22)
                        label_3.Text = str1;
                    else
                        label_3.Text = str2;
                }
                else
                    label_3.Text = str1;

                Decimal decimal_73 = this.method_43(gclass194_1);
                label_5.Text = AuroraUtils.smethod_45(decimal_73, int_13);
                double double_32_3 = 0.0;
                if (this.HydroExtent < 20.0)
                    double_32_3 = (20.0 - this.HydroExtent) / 10.0;
                label_6.Text = AuroraUtils.smethod_46(double_32_3, int_13);
            }
            else
            {
                label_1.Text = "-";
                label_0.Text = "-";
                label_4.Text = "-";
                label_3.Text = "-";
                label_2.Text = "-";
                label_4.Text = "-";
                label_5.Text = "-";
                label_6.Text = "-";
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3051);
        }
    }

    public void method_72(
        GameRace gclass21_0,
        Species gclass194_1,
        ListView listView_0,
        int int_13)
    {
        try
        {
            string string_11_1 = "2.00";
            string string_11_2 = "0.00";
            string string_11_3 = "1.00 LG";
            if (int_13 == 3)
            {
                string_11_1 = "2.000";
                string_11_2 = "0.000";
                string_11_3 = "1.000 LG";
            }

            this.gclass0_0.method_601(listView_0, "Colony Cost", this.method_48(gclass194_1, int_13, GEnum80.const_0),
                null);
            if (this.Gravity < gclass194_1.double_7)
                this.gclass0_0.method_601(listView_0, "CC - Gravity", string_11_3, null);
            else
                this.gclass0_0.method_601(listView_0, "CC - Gravity", string_11_2, null);
            double double_32_1 = 0.0;
            if (this.SurfaceTemp >= gclass194_1.double_12 && this.SurfaceTemp <= gclass194_1.double_11)
            {
                this.gclass0_0.method_601(listView_0, "CC - Temperature", string_11_2, null);
            }
            else
            {
                if (this.SurfaceTemp < gclass194_1.double_12)
                    double_32_1 = Math.Abs(gclass194_1.double_12 - this.SurfaceTemp) / gclass194_1.double_4;
                else if (this.SurfaceTemp > gclass194_1.double_11)
                    double_32_1 = Math.Abs(gclass194_1.double_11 - this.SurfaceTemp) / gclass194_1.double_4;
                if (this.TidalLock && this.BodyClass != PlanetBodyClass.Moon)
                    double_32_1 /= 5.0;
                this.gclass0_0.method_601(listView_0, "CC - Temperature", AuroraUtils.smethod_46(double_32_1, int_13),
                    null);
            }

            double num = this.method_45(gclass194_1.gclass223_0);
            if (num >= gclass194_1.double_9 && num <= gclass194_1.double_10)
            {
                if (this.method_44(gclass194_1.gclass223_0) > AuroraUtils.int_22)
                    this.gclass0_0.method_601(listView_0, "CC - Breathable", string_11_1, null);
                else
                    this.gclass0_0.method_601(listView_0, "CC - Breathable", string_11_2, null);
            }
            else
                this.gclass0_0.method_601(listView_0, "CC - Breathable", string_11_1, null);

            Decimal decimal_73 = this.method_43(gclass194_1);
            this.gclass0_0.method_601(listView_0, "CC - Dangerous Gas", AuroraUtils.smethod_45(decimal_73, int_13),
                null);
            if (this.AtmospherePressure > gclass194_1.double_2)
            {
                double double_32_2 = this.AtmospherePressure / gclass194_1.double_2;
                if (double_32_2 < 2.0)
                    double_32_2 = 2.0;
                this.gclass0_0.method_601(listView_0, "CC - Pressure", AuroraUtils.smethod_46(double_32_2, int_13),
                    null);
            }
            else
                this.gclass0_0.method_601(listView_0, "CC - Pressure", string_11_2, null);

            double double_32_3 = 0.0;
            if (this.HydroExtent < 20.0)
                double_32_3 = (20.0 - this.HydroExtent) / 10.0;
            this.gclass0_0.method_601(listView_0, "CC - Water", AuroraUtils.smethod_46(double_32_3, int_13), null);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3052);
        }
    }

    public double method_73()
    {
        try
        {
            return 0.02783 * this.BaseTemp / Math.Pow(this.Escape, 2.0);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3053);
            return -1.0;
        }
    }

    public GClass221 method_74(RacialSystemSurvey gclass202_0)
    {
        try
        {
            return new GClass221()
            {
                double_0 = (this.XCoordinate + gclass202_0.double_3) / gclass202_0.KmPerPixel + this.gclass0_0.double_4,
                double_1 = (this.YCoordinate + gclass202_0.double_4) / gclass202_0.KmPerPixel + this.gclass0_0.double_5
            };
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3054);
            return new GClass221(0.0, 0.0);
        }
    }

    public void method_75(
        Graphics graphics_0,
        Font font_0,
        GClass222 gclass222_0,
        RacialSystemSurvey gclass202_0)
    {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        SystemBodyData.Class318 class318 = new SystemBodyData.Class318();
        // ISSUE: reference to a compiler-generated field
        class318.gclass202_0 = gclass202_0;
        // ISSUE: reference to a compiler-generated field
        class318.gclass1_0 = this;
        try
        {
            // ISSUE: reference to a compiler-generated field
            bool flag = this.method_77(class318.gclass202_0.Race);
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            if (class318.gclass202_0.Race.chkAst == CheckState.Unchecked &&
                this.BodyTypeId == AuroraSystemBodyType.Asteroid && !this.IsFixedBody ||
                class318.gclass202_0.Race.chkMoons == CheckState.Unchecked &&
                this.BodyClass == PlanetBodyClass.Moon ||
                class318.gclass202_0.Race.chkDwarf == CheckState.Unchecked &&
                this.BodyTypeId == AuroraSystemBodyType.DwarfPlanet ||
                class318.gclass202_0.Race.chkPlanets == CheckState.Unchecked &&
                this.BodyClass == PlanetBodyClass.Planet && this.BodyTypeId != AuroraSystemBodyType.DwarfPlanet ||
                class318.gclass202_0.Race.chkAstMinOnly == CheckState.Checked &&
                this.BodyTypeId == AuroraSystemBodyType.Asteroid && !this.IsFixedBody &&
                (!flag || this.MineralDeposits.Count == 0) ||
                class318.gclass202_0.Race.chkAstColOnly == CheckState.Checked &&
                this.BodyTypeId == AuroraSystemBodyType.Asteroid && !this.IsFixedBody &&
                !class318.gclass202_0.list_4.Contains(this) || this.BodyClass == PlanetBodyClass.Moon &&
                this.OrbitalDistance / class318.gclass202_0.KmPerPixel < AuroraUtils.int_61)
                return;
            int num1 = 0;
            // ISSUE: reference to a compiler-generated field
            if (class318.gclass202_0.Race.chkSBSurvey == CheckState.Checked && !this.IsFixedBody && flag)
            {
                Pen pen = new Pen(Color.White);
                double x = gclass222_0.double_2 - AuroraUtils.int_61;
                double y = gclass222_0.double_3 - AuroraUtils.int_61;
                graphics_0.DrawEllipse(pen, (float)x, (float)y, AuroraUtils.int_61 * 2, AuroraUtils.int_61 * 2);
                ++num1;
            }

            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            if (class318.gclass202_0.Race.chkMinerals == CheckState.Checked && this.MineralDeposits.Count > 0 &&
                this.method_77(class318.gclass202_0.Race))
            {
                Pen pen = new Pen(Color.Yellow);
                double num2 = 1.0 + 0.4 * num1;
                double x = gclass222_0.double_2 - AuroraUtils.int_61 * num2;
                double y = gclass222_0.double_3 - AuroraUtils.int_61 * num2;
                graphics_0.DrawEllipse(pen, (float)x, (float)y, AuroraUtils.int_61 * (float)(num2 * 2.0),
                    AuroraUtils.int_61 * (float)(num2 * 2.0));
                ++num1;
            }

            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            if (class318.gclass202_0.Race.chkColonies == CheckState.Checked && !this.IsFixedBody &&
                class318.gclass202_0.list_4.Contains(this))
            {
                Pen pen = new Pen(Color.LimeGreen);
                double num3 = 1.0 + 0.4 * num1;
                double x = gclass222_0.double_2 - AuroraUtils.int_61 * num3;
                double y = gclass222_0.double_3 - AuroraUtils.int_61 * num3;
                graphics_0.DrawEllipse(pen, (float)x, (float)y, AuroraUtils.int_61 * (float)(num3 * 2.0),
                    AuroraUtils.int_61 * (float)(num3 * 2.0));
                int num4 = num1 + 1;
            }

            SolidBrush solidBrush = new SolidBrush(Color.Blue);
            GClass221 gclass221_1 = new GClass221();
            // ISSUE: reference to a compiler-generated field
            string text = this.method_78(class318.gclass202_0.Race);
            double x1 = gclass222_0.double_2 - AuroraUtils.int_61 / 2.0;
            double y1 = gclass222_0.double_3 - AuroraUtils.int_61 / 2.0;
            if (this.BodyClass == PlanetBodyClass.Comet)
            {
                Pen pen = new Pen(Color.Cyan);
                double double_11 = this.gclass0_0.method_591(this.XCoordinate, this.YCoordinate, 0.0, 0.0);
                GClass221 gclass221_2 =
                    this.gclass0_0.method_593(gclass222_0.double_2, gclass222_0.double_3, 25.0, double_11);
                graphics_0.DrawLine(pen, (float)gclass222_0.double_2, (float)gclass222_0.double_3,
                    (float)gclass221_2.double_0, (float)gclass221_2.double_1);
                graphics_0.FillEllipse(solidBrush, (float)x1, (float)y1, AuroraUtils.int_61, AuroraUtils.int_61);
                graphics_0.DrawEllipse(pen, (float)x1, (float)y1, AuroraUtils.int_61, AuroraUtils.int_61);
            }
            else if (!this.IsFixedBody)
            {
                graphics_0.FillEllipse(solidBrush, (float)x1, (float)y1, AuroraUtils.int_61, AuroraUtils.int_61);
            }
            else
            {
                solidBrush.Color = Color.Yellow;
                graphics_0.FillEllipse(solidBrush, (float)x1, (float)y1, AuroraUtils.int_61, AuroraUtils.int_61);
                // ISSUE: reference to a compiler-generated field
                if (class318.gclass202_0.list_4.Contains(this))
                {
                    // ISSUE: reference to a compiler-generated method
                    PopulationData gclass146 =
                        this.gclass0_0.Populations.Values.FirstOrDefault<PopulationData>(class318.method_0);
                    if (gclass146 != null)
                        text = gclass146.PopName;
                }
            }

            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            if (class318.gclass202_0.Race.chkAstNames == CheckState.Unchecked &&
                this.BodyTypeId == AuroraSystemBodyType.Asteroid && !this.IsFixedBody ||
                class318.gclass202_0.Race.chkMoonNames == CheckState.Unchecked &&
                this.BodyClass == PlanetBodyClass.Moon ||
                class318.gclass202_0.Race.chkDwarfNames == CheckState.Unchecked &&
                this.BodyTypeId == AuroraSystemBodyType.DwarfPlanet ||
                class318.gclass202_0.Race.chkPlanetNames == CheckState.Unchecked &&
                this.BodyClass == PlanetBodyClass.Planet && this.BodyTypeId != AuroraSystemBodyType.DwarfPlanet)
                return;
            string str = "";
            // ISSUE: reference to a compiler-generated field
            if (class318.gclass202_0.Race.chkGeoPoints == CheckState.Checked)
            {
                double num5 =
                    this.BodyTypeId == AuroraSystemBodyType.GasGiant ||
                    this.BodyTypeId == AuroraSystemBodyType.Superjovian
                        ? this.Radius / 100.0
                        : this.Radius / 10.0;
                if (num5 < 1.0)
                    num5 = 1.0;
                str = string.Format(" ({0})", Math.Round(num5, 0).ToString());
            }

            solidBrush.Color = Color.LimeGreen;
            double num6 = graphics_0.MeasureString(text, font_0).Width / 2.0;
            gclass221_1.double_0 = gclass222_0.double_2 - num6;
            gclass221_1.double_1 = gclass222_0.double_3 + AuroraUtils.int_61;
            // ISSUE: reference to a compiler-generated field
            if (class318.gclass202_0.Race.chkSBSurvey == CheckState.Checked)
                gclass221_1.double_1 += 5.0;
            graphics_0.DrawString(text + str, font_0, solidBrush, (float)gclass221_1.double_0,
                (float)gclass221_1.double_1);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3055);
        }
    }

    public void method_76(Graphics graphics_0, GClass222 gclass222_0, RacialSystemSurvey gclass202_0)
    {
        try
        {
            if (this.IsFixedBody || this != this.gclass0_0.gclass1_0 && (this.TrojanOffset != 0.0 ||
                                                                    gclass202_0.Race.chkAsteroidOrbits ==
                                                                    CheckState.Unchecked &&
                                                                    this.BodyTypeId == AuroraSystemBodyType.Asteroid ||
                                                                    gclass202_0.Race.chkMoonOrbits ==
                                                                    CheckState.Unchecked &&
                                                                    this.BodyClass == PlanetBodyClass.Moon ||
                                                                    gclass202_0.Race.chkDwarfOrbits ==
                                                                    CheckState.Unchecked &&
                                                                    this.BodyTypeId ==
                                                                    AuroraSystemBodyType.DwarfPlanet ||
                                                                    gclass202_0.Race.chkCometPath ==
                                                                    CheckState.Unchecked &&
                                                                    this.BodyTypeId == AuroraSystemBodyType.Comet ||
                                                                    gclass202_0.Race.chkPlanetOrbits ==
                                                                    CheckState.Unchecked &&
                                                                    this.BodyClass == PlanetBodyClass.Planet &&
                                                                    this.BodyTypeId !=
                                                                    AuroraSystemBodyType.DwarfPlanet))
                return;
            if (this.Eccentricity != 0.0 && this.BodyClass != PlanetBodyClass.Moon && this.gclass0_0.StarEccentricity != 0)
            {
                GClass221 gclass221 = this.StarData.method_20(gclass202_0);
                if (gclass221.double_0 < 0.0 || gclass221.double_0 > this.gclass0_0.double_0 ||
                    gclass221.double_1 < 0.0 || gclass221.double_1 > this.gclass0_0.double_1)
                    return;
                float width = (float)(this.OrbitalDistance * AuroraUtils.double_14 * 2.0 / gclass202_0.KmPerPixel);
                if (width < (double)AuroraUtils.int_61)
                    return;
                float height = (float)(this.OrbitalSemiMinorAxis * AuroraUtils.double_14 * 2.0 / gclass202_0.KmPerPixel);
                float num = (float)(this.double_27 * AuroraUtils.double_14 / gclass202_0.KmPerPixel);
                float x = (float)gclass221.double_0 - num;
                float y = (float)(gclass221.double_1 - height / 2.0);
                Matrix matrix = new Matrix();
                matrix.RotateAt((float)this.EccentricityDirection,
                    new PointF((float)gclass221.double_0, (float)gclass221.double_1));
                graphics_0.Transform = matrix;
                RectangleF rect = new RectangleF(x, y, width, height);
                Pen pen = new Pen(AuroraUtils.color_5);
                graphics_0.DrawEllipse(pen, rect);
                graphics_0.ResetTransform();
                pen.Dispose();
            }
            else
            {
                GClass221 gclass221_1 = new GClass221();
                double num = this.BodyClass != PlanetBodyClass.Moon
                    ? this.OrbitalDistance * AuroraUtils.double_14 / gclass202_0.KmPerPixel
                    : this.OrbitalDistance / gclass202_0.KmPerPixel;
                if (num < AuroraUtils.int_61)
                    return;
                GClass221 gclass221_2 =
                    this.ParentBodyType != ParentBodyType.EnumVal1 || this.BodyClass != PlanetBodyClass.Moon
                        ? this.StarData.method_20(gclass202_0)
                        : this.ParentBodyData.method_74(gclass202_0);
                if (gclass221_2.double_0 < 0.0 || gclass221_2.double_0 > this.gclass0_0.double_0 ||
                    gclass221_2.double_1 < 0.0 || gclass221_2.double_1 > this.gclass0_0.double_1)
                    return;
                double x = gclass221_2.double_0 - num;
                double y = gclass221_2.double_1 - num;
                Pen pen = new Pen(AuroraUtils.color_5);
                graphics_0.DrawEllipse(pen, (float)x, (float)y, (float)(num * 2.0), (float)(num * 2.0));
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3056);
        }
    }

    public bool method_77(GameRace gclass21_0)
    {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: reference to a compiler-generated method
        return this.gclass0_0.SystemBodySurveys.Where<RacialSystemBodySurvey>(new SystemBodyData.Class319()
        {
            gclass21_0 = gclass21_0,
            gclass1_0 = this
        }.method_0).FirstOrDefault<RacialSystemBodySurvey>() != null;
    }

    public string method_78(GameRace gclass21_0)
    {
        try
        {
            return this.method_79(gclass21_0, false, false);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3057);
            return "error";
        }
    }

    public string method_79(GameRace gclass21_0, bool bool_10, bool bool_11)
    {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        SystemBodyData.Class320 class320 = new SystemBodyData.Class320();
        // ISSUE: reference to a compiler-generated field
        class320.gclass21_0 = gclass21_0;
        try
        {
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated field
            return this.dictionary_1.Values.Where<RaceSystemBodyName>(class320.method_0)
                       .Select<RaceSystemBodyName, string>(gclass218_0 => gclass218_0.Name).FirstOrDefault<string>() ??
                   this.method_81(class320.gclass21_0, bool_10, bool_11);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3058);
            return "error";
        }
    }

    public void method_80(GameRace gclass21_0, string string_3)
    {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        SystemBodyData.Class321 class321 = new SystemBodyData.Class321();
        // ISSUE: reference to a compiler-generated field
        class321.gclass21_0 = gclass21_0;
        try
        {
            // ISSUE: reference to a compiler-generated method
            RaceSystemBodyName gclass218 = this.dictionary_1.Values.Where<RaceSystemBodyName>(class321.method_0)
                .FirstOrDefault<RaceSystemBodyName>();
            if (gclass218 != null)
            {
                gclass218.Name = string_3;
            }
            else
            {
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                this.dictionary_1.Add(class321.gclass21_0.RaceID, new RaceSystemBodyName()
                {
                    Name = string_3,
                    SystemBodyID = this.SystemBodyID,
                    Race = class321.gclass21_0
                });
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3059);
        }
    }

    public string method_81(GameRace gclass21_0, bool bool_10, bool bool_11)
    {
        try
        {
            string str = "";
            if (!bool_11)
                str = $"{this.StarData.method_18(gclass21_0)} ";
            switch (this.BodyClass)
            {
                case PlanetBodyClass.Planet:
                    return str + AuroraUtils.smethod_79(this.PlanetNumber);
                case PlanetBodyClass.Moon:
                    if (!bool_10)
                        return string.Format("{0} - Moon {1}", this.ParentBodyData.method_78(gclass21_0),
                            this.OrbitNumber.ToString());
                    if (this.SystemData.Stars == 1)
                        return string.Format("Moon {0} {1}", AuroraUtils.smethod_79(this.PlanetNumber),
                            this.OrbitNumber.ToString());
                    return
                        string.Format("Moon {0}-{1} {2}", this.StarData.method_19(),
                            AuroraUtils.smethod_79(this.PlanetNumber), this.OrbitNumber.ToString());
                case PlanetBodyClass.Asteroid:
                    return $"Asteroid #{this.OrbitNumber}";
                case PlanetBodyClass.Comet:
                    return $"Comet #{this.OrbitNumber}";
                default:
                    return "No Name";
            }
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3060);
            return "No Name";
        }
    }

    public List<SystemBodyData> method_82()
    {
        try
        {
            return this.gclass0_0.SystemBodyRecordDic.Values
                .Where<SystemBodyData>(gclass1_2 => gclass1_2.ParentBodyData == this)
                .OrderBy<SystemBodyData, int>(gclass1_0 => gclass1_0.OrbitNumber)
                .ToList<SystemBodyData>();
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3061);
            return new List<SystemBodyData>();
        }
    }
}