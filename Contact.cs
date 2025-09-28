// Decompiled with JetBrains decompiler
// Type: GClass65
// Assembly: Aurora, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAB8E3AD-3A24-426F-849E-98EC2E2DD9EB
// Assembly location: C:\Users\jinhoon.kim\Desktop\Aurora250Full\Dedot\aurora-deop.exe

using Aurora;
using System;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
public class Contact
{
    public StarSystem System;
    public GameRace ContactRace;
    public GameRace DetectRace;
    public ContactDetectMethod ContactMethod;
    public AuroraContactType ContactType;
    public ShipData TargetShip;
    public MissileSalvo TargetSalvo;
    public PopulationData TargetPopulation;
    private GClass0 gclass0_0;
    public int UniqueID;
    public int ContactID;
    public int ContactNumber;
    public int Resolution;
    public int ContinualContactTime;
    public int Speed;
    public Decimal ContactStrength;
    public Decimal CreationTime;
    public Decimal Reestablished;
    public Decimal LastUpdate;
    public double Xcor;
    public double Ycor;
    public double LastXcor;
    public double LastYcor;
    public double IncrementStartX;
    public double IncrementStartY;
    public string ContactName;
    public bool Msg;
    public AlienRaceIntel gclass110_0;
    public string string_1 = "";

    public Contact(GClass0 gclass0_1) => this.gclass0_0 = gclass0_1;

    public string method_0()
    {
        try
        {
            RacialSystemSurvey gclass202_0 = this.DetectRace.method_128(this.System);
            foreach (PopulationData gclass146 in this.System.method_33(this.DetectRace))
            {
                if (this.gclass0_0.method_520(this.Xcor, gclass146.method_87(), this.Ycor,
                        gclass146.method_88()))
                    return string.Format((string)"Orbiting {0}", (object)gclass146.PopName);
            }

            foreach (JumpPoint gclass120 in this.System.method_27())
            {
                if (gclass120.RacialJumpPointSurveys.ContainsKey(this.DetectRace.RaceID) &&
                    gclass120.RacialJumpPointSurveys[this.DetectRace.RaceID].Charted == 1 &&
                    this.gclass0_0.method_520(this.Xcor, gclass120.XCoord, this.Ycor, gclass120.YCoord))
                    return string.Format((string)"Stationed at {0}", (object)gclass120.method_8(gclass202_0));
            }

            foreach (SurveyLocation gclass213 in this.System.SurveyLocationDictionary.Values)
            {
                if (this.gclass0_0.method_520(this.Xcor, gclass213.XCoord, this.Ycor, gclass213.YCoord))
                    return string.Format((string)"Stationed at Survey Location #{0}", (object)gclass213.LocationNumber);
            }

            foreach (SystemBodyData gclass1 in this.System.method_20())
            {
                if (this.gclass0_0.method_520(this.Xcor, gclass1.XCoordinate, this.Ycor, gclass1.YCoordinate))
                    return string.Format((string)"Orbiting {0}", (object)gclass1.method_78(this.DetectRace));
            }

            return this.System.method_22(this.Xcor, this.Ycor, gclass202_0);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 898);
            return "None";
        }
    }

    public Decimal method_1()
    {
        try
        {
            return this.Reestablished == 0M ? this.CreationTime : this.Reestablished;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 457);
            return this.gclass0_0.GameTime;
        }
    }

    public bool method_2()
    {
        try
        {
            return this.ContactType == AuroraContactType.Population ||
                   this.ContactType == AuroraContactType.Salvo ||
                   this.ContactType == AuroraContactType.GroundUnit ||
                   this.ContactType == AuroraContactType.STOGroundUnit ||
                   this.ContactType == AuroraContactType.Shipyard ||
                   this.ContactType == AuroraContactType.Ship && (this.TargetShip.gclass187_0 == null ||
                                                                          !this.DetectRace.AlienRaceIntels.ContainsKey(
                                                                              this.ContactRace.RaceID) ||
                                                                          !this.DetectRace
                                                                              .AlienRaceIntels[this.ContactRace.RaceID]
                                                                              .bTradeTreaty);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 458);
            return false;
        }
    }

    public int method_3()
    {
        try
        {
            return this.ContactRace == null ? 0 : this.ContactRace.RaceID;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 459);
            return 0;
        }
    }

    public string method_4()
    {
        try
        {
            string str1 = "";
            if (this.ContactRace != null)
                str1 = string.Format((string)"[{0}]  ",
                    (object)this.DetectRace.AlienRaceIntels[this.ContactRace.RaceID].Abbreviation);
            string str2;
            if (this.ContactType == AuroraContactType.Ship)
                str2 = str1 + this.TargetShip.method_226(this.DetectRace, false, 0);
            else if (this.ContactType == AuroraContactType.Salvo)
                str2 = this.TargetSalvo.method_18(this.DetectRace, true);
            else if (this.ContactType == AuroraContactType.Population)
                str2 = str1 + this.TargetPopulation.method_80(this.DetectRace);
            else if (this.ContactType == AuroraContactType.GroundUnit)
            {
                string str3 = this.DetectRace.method_42(this.TargetPopulation);
                str2 = string.Format((string)"{0}{1} - Ground Forces Signature: {2} tons", (object)str1, (object)str3,
                    (object)AuroraUtils.smethod_39(this.ContactStrength * 100M));
            }
            else if (this.ContactType == AuroraContactType.STOGroundUnit)
            {
                string str4 = this.DetectRace.method_42(this.TargetPopulation);
                str2 =
                    string.Format((string)"{0}{1} - STO Ground Forces Signature {2} tons", (object)str1, (object)str4,
                        (object)AuroraUtils.smethod_39(this.ContactStrength * 100M));
            }
            else if (this.ContactType == AuroraContactType.Shipyard)
            {
                string str5 = this.DetectRace.method_42(this.TargetPopulation);
                str2 = string.Format((string)"{0}{1} - Shipyard Complex Signature {2}", (object)str1, (object)str5,
                    (object)this.ContactStrength.ToString());
            }
            else
                str2 = this.ContactType == AuroraContactType.Explosion ||
                       this.ContactType == AuroraContactType.EWImpact
                    ? string.Format((string)"{0}x {1}", (object)AuroraUtils.smethod_37(this.ContactNumber),
                        (object)this.ContactName)
                    : this.ContactName;

            return str2;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 460);
            return "error";
        }
    }

    public AuroraContactStatus method_5()
    {
        try
        {
            return this.ContactRace == null || !this.DetectRace.AlienRaceIntels.ContainsKey(this.ContactRace.RaceID)
                ? AuroraContactStatus.None
                : this.DetectRace.AlienRaceIntels[this.ContactRace.RaceID].ContactStatus;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 461);
            return AuroraContactStatus.None;
        }
    }

    public AuroraCommStatus method_6()
    {
        try
        {
            return this.ContactRace == null || !this.DetectRace.AlienRaceIntels.ContainsKey(this.ContactRace.RaceID)
                ? AuroraCommStatus.CommunicationImpossible
                : this.DetectRace.AlienRaceIntels[this.ContactRace.RaceID].CommStatus;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 462);
            return AuroraCommStatus.CommunicationImpossible;
        }
    }

    public bool method_7(
        Graphics graphics_0,
        Font font_0,
        GClass222 gclass222_0,
        RacialSystemSurvey gclass202_0,
        int int_6)
    {
        try
        {
            if (gclass202_0.Race.chkActiveOnly == CheckState.Checked && this.ContactMethod != ContactDetectMethod.const_0)
                return false;
            AuroraContactStatus auroraContactStatus_0 = AuroraContactStatus.Hostile;
            string str1 = "";
            if (this.ContactRace != null)
            {
                auroraContactStatus_0 = this.DetectRace.AlienRaceIntels[this.ContactRace.RaceID].ContactStatus;
                str1 = string.Format((string)"[{0}]  ",
                    (object)gclass202_0.Race.AlienRaceIntels[this.ContactRace.RaceID].Abbreviation);
            }

            if (!gclass202_0.Race.method_319(auroraContactStatus_0))
                return false;
            SolidBrush solidBrush = new SolidBrush(AuroraUtils.color_6);
            Pen pen = new Pen(AuroraUtils.color_6);
            solidBrush.Color = AuroraUtils.smethod_81(auroraContactStatus_0);
            pen.Color = solidBrush.Color;
            double x = gclass222_0.double_2 - AuroraUtils.int_61 / 2;
            double y = gclass222_0.double_3 - AuroraUtils.int_61 / 2;
            if (this.LastUpdate == this.gclass0_0.GameTime && (this.IncrementStartX != 0.0 || this.IncrementStartY != 0.0))
            {
                GClass221 gclass221_1 = new GClass221();
                GClass221 gclass221_2 = gclass202_0.method_47(this.IncrementStartX, this.IncrementStartY);
                graphics_0.DrawLine(pen, (float)gclass222_0.double_2, (float)gclass222_0.double_3,
                    (float)gclass221_2.double_0, (float)gclass221_2.double_1);
            }

            if (int_6 == 0)
                graphics_0.FillEllipse(solidBrush, (float)x, (float)y, AuroraUtils.int_61, AuroraUtils.int_61);
            string str2 = this.ContactName;
            if (gclass202_0.Race.chkShowDist == CheckState.Checked && (gclass202_0.gclass221_0.double_0 != 0.0 ||
                                                                             gclass202_0.gclass221_0.double_1 != 0.0))
            {
                double num = this.gclass0_0.GetDistanceBetween(gclass202_0.gclass221_0.double_0,
                    gclass202_0.gclass221_0.double_1, gclass222_0.double_0, gclass222_0.double_1);
                str2 = string.Format((string)"{0}  {1}m", (object)str2,
                    (object)AuroraUtils.smethod_50(num / 1000000.0));
            }

            GClass221 gclass221 = new GClass221();
            gclass221.double_0 = x + AuroraUtils.int_61 + 5.0;
            gclass221.double_1 = y - 3.0 - int_6 * 15;
            graphics_0.DrawString(str1 + str2, font_0, solidBrush, (float)gclass221.double_0,
                (float)gclass221.double_1);
            pen.Dispose();
            return true;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 463);
            return false;
        }
    }

    public bool method_8(Graphics graphics_0, Font font_0, GClass222 gclass222_0, int int_6)
    {
        try
        {
            SolidBrush solidBrush = new SolidBrush(AuroraUtils.color_6);
            Pen pen = new Pen(AuroraUtils.color_6, 2f);
            graphics_0.DrawLine(pen, (float)gclass222_0.double_2, (float)gclass222_0.double_3 - 8f,
                (float)gclass222_0.double_2, (float)gclass222_0.double_3 + 8f);
            graphics_0.DrawLine(pen, (float)gclass222_0.double_2 - 8f, (float)gclass222_0.double_3,
                (float)gclass222_0.double_2 + 8f, (float)gclass222_0.double_3);
            graphics_0.DrawLine(pen, (float)gclass222_0.double_2 - 6f, (float)gclass222_0.double_3 - 6f,
                (float)gclass222_0.double_2 + 6f, (float)gclass222_0.double_3 + 6f);
            graphics_0.DrawLine(pen, (float)gclass222_0.double_2 + 6f, (float)gclass222_0.double_3 - 6f,
                (float)gclass222_0.double_2 - 6f, (float)gclass222_0.double_3 + 6f);
            double num1 = gclass222_0.double_2 - AuroraUtils.int_61 / 2;
            double num2 = gclass222_0.double_3 - AuroraUtils.int_61 / 2;
            GClass221 gclass221 = new GClass221();
            gclass221.double_0 = num1 + AuroraUtils.int_61 + 5.0;
            gclass221.double_1 = num2 - 3.0 - int_6 * 15;
            graphics_0.DrawString(
                string.Format((string)"{0}x {1}", (object)AuroraUtils.smethod_37(this.ContactNumber),
                    (object)this.ContactName), font_0, solidBrush,
                (float)gclass221.double_0, (float)gclass221.double_1);
            return true;
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 464);
            return false;
        }
    }
}