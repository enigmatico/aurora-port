// Decompiled with JetBrains decompiler
// Type: GClass171
// Assembly: Aurora, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAB8E3AD-3A24-426F-849E-98EC2E2DD9EB
// Assembly location: C:\Users\jinhoon.kim\Desktop\Aurora250Full\Dedot\aurora-deop.exe

using Aurora;
using System;
using System.Windows.Forms;

#nullable disable
public class RuinRaceData
{
    private GClass0 gclass0_0;
    public int RuinRaceID;
    public int Level;
    public string Title;
    public string Name;
    public string RacePic;
    public string FlagPic;

    public RuinRaceData(GClass0 gclass0_1) => this.gclass0_0 = gclass0_1;

    public ShipComponent method_0()
    {
        try
        {
            TechSystem gclass164_1 = this.gclass0_0.method_493(TechType.LaserFocalSize, this.Level);
            TechSystem gclass164_2 = this.gclass0_0.method_493(TechType.LaserWavelength, this.Level);
            TechSystem gclass164_3 = this.gclass0_0.method_493(TechType.CapacitorRechargeRate, this.Level);
            TechSystem gclass164_4 = this.gclass0_0.TechDataDictionary[26596];
            TechSystem gclass164_5_1 = this.gclass0_0.TechDataDictionary[55406];
            if (AuroraUtils.GetRandomInteger(3) < 3)
            {
                ShipComponent gclass230 = this.gclass0_0.method_473(null, gclass164_1, gclass164_2, gclass164_3,
                    gclass164_4, gclass164_5_1, false, null, null, false);
                return this.gclass0_0.method_489(null, AuroraComponentType.Laser, gclass230.decimal_1,
                    gclass230.decimal_3, gclass230.decimal_2) ?? this.gclass0_0.method_473(null, gclass164_1,
                    gclass164_2, gclass164_3, gclass164_4, gclass164_5_1, false, null, null, true);
            }

            TechSystem gclass164_5_2 = this.gclass0_0.method_493(TechType.EnergyWeaponMount, this.Level);
            ShipComponent gclass230_1 = this.gclass0_0.method_473(null, gclass164_1, gclass164_2, gclass164_3, gclass164_4,
                gclass164_5_2, false, null, null, false);
            return this.gclass0_0.method_489(null, AuroraComponentType.Laser, gclass230_1.decimal_1,
                gclass230_1.decimal_3, gclass230_1.decimal_2) ?? this.gclass0_0.method_473(null, gclass164_1,
                gclass164_2, gclass164_3, gclass164_4, gclass164_5_2, false, null, null, true);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2647);
            return null;
        }
    }

    public ShipComponent method_1()
    {
        try
        {
            TechSystem gclass164_1 = this.gclass0_0.method_493(TechType.RailgunType, this.Level);
            TechSystem gclass164_2 = this.gclass0_0.method_493(TechType.RailgunVelocity, this.Level);
            TechSystem gclass164_3 = this.gclass0_0.method_493(TechType.CapacitorRechargeRate, this.Level);
            ShipComponent gclass230 =
                this.gclass0_0.method_471(null, gclass164_1, gclass164_2, gclass164_3, 4, null, null, false);
            return this.gclass0_0.method_489(null, AuroraComponentType.Railgun, gclass230.decimal_1,
                gclass230.decimal_3, gclass230.decimal_2) ?? this.gclass0_0.method_471(null, gclass164_1, gclass164_2,
                gclass164_3, 4, null, null, true);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2648);
            return null;
        }
    }

    public ShipComponent method_2()
    {
        try
        {
            TechSystem gclass164_1 = this.gclass0_0.method_493(TechType.ParticleBeamStrength, this.Level);
            TechSystem gclass164_2 = this.gclass0_0.method_493(TechType.MaximumParticleBeamRange, this.Level);
            TechSystem gclass164_4 = this.gclass0_0.method_493(TechType.ParticleLance, this.Level);
            TechSystem gclass164_3 = this.gclass0_0.method_493(TechType.CapacitorRechargeRate, this.Level);
            TechSystem gclass164_5 = this.gclass0_0.TechDataDictionary[55406];
            ShipComponent gclass230 = this.gclass0_0.method_467(null, gclass164_1, gclass164_2, gclass164_3, gclass164_4,
                gclass164_5, null, null, false);
            return this.gclass0_0.method_489(null, AuroraComponentType.ParticleBeam, gclass230.decimal_1,
                gclass230.decimal_3, gclass230.decimal_2) ?? this.gclass0_0.method_467(null, gclass164_1, gclass164_2,
                gclass164_3, gclass164_4, gclass164_5, null, null, true);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2649);
            return null;
        }
    }

    public ShipComponent method_3()
    {
        try
        {
            TechSystem gclass164_1 = this.gclass0_0.method_493(TechType.MesonFocalSize, this.Level);
            TechSystem gclass164_2 = this.gclass0_0.method_493(TechType.MesonFocusing, this.Level);
            TechSystem gclass164_3 = this.gclass0_0.method_493(TechType.CapacitorRechargeRate, this.Level);
            TechSystem gclass164_4 = this.gclass0_0.method_493(TechType.MesonArmourRetardation, this.Level);
            ShipComponent gclass230 = this.gclass0_0.method_468(null, gclass164_1, gclass164_2, gclass164_3, gclass164_4,
                null, null, false);
            return this.gclass0_0.method_489(null, AuroraComponentType.MesonCannon, gclass230.decimal_1,
                gclass230.decimal_3, gclass230.decimal_2) ?? this.gclass0_0.method_468(null, gclass164_1, gclass164_2,
                gclass164_3, gclass164_4, null, null, true);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2650);
            return null;
        }
    }

    public ShipComponent method_4()
    {
        try
        {
            TechSystem gclass164_1 = this.gclass0_0.method_493(TechType.CarronadeCalibre, this.Level);
            TechSystem gclass164_2 = this.gclass0_0.method_493(TechType.CapacitorRechargeRate, this.Level);
            TechSystem gclass164_3 = this.gclass0_0.TechDataDictionary[55406];
            ShipComponent gclass230 =
                this.gclass0_0.method_470(null, gclass164_1, gclass164_2, gclass164_3, null, null, false);
            return this.gclass0_0.method_489(null, AuroraComponentType.Carronade, gclass230.decimal_1,
                       gclass230.decimal_3, gclass230.decimal_2) ??
                   this.gclass0_0.method_470(null, gclass164_1, gclass164_2, gclass164_3, null, null, true);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2651);
            return null;
        }
    }

    public ShipComponent method_5()
    {
        try
        {
            TechSystem gclass164_1_1 = this.gclass0_0.method_493(TechType.GaussCannonRateofFire, this.Level);
            TechSystem gclass164_2 = this.gclass0_0.method_493(TechType.GaussCannonVelocity, this.Level);
            TechSystem gclass164_1_2 = this.gclass0_0.method_493(TechType.TurretRotationGear, this.Level);
            TechSystem gclass164_1 = this.gclass0_0.method_493(TechType.BeamFireControlDistanceRating, this.Level);
            TechSystem gclass164_3 = this.gclass0_0.TechDataDictionary[26645];
            TechSystem gclass164_4 = this.gclass0_0.TechDataDictionary[24375];
            ShipComponent gclass230_1 =
                this.gclass0_0.method_466(null, gclass164_1_1, gclass164_2, gclass164_3, null, null, false);
            ShipComponent gclass230_2 = this.gclass0_0.method_489(null, AuroraComponentType.GaussCannon,
                gclass230_1.decimal_1, gclass230_1.decimal_3, gclass230_1.decimal_2);
            ShipComponent gclass230_2_1 = gclass230_1;
            if (gclass230_2 != null)
                gclass230_2_1 = gclass230_2;
            ShipComponent gclass230_3 = this.gclass0_0.method_450(null, gclass164_1_2, gclass230_2_1, 2,
                (int)gclass164_1.decimal_0 * 4, 0, null, null, null, null, null, null, null, null, null, null, false);
            return this.gclass0_0.method_489(null, AuroraComponentType.GaussCannon, gclass230_3.decimal_1,
                gclass230_3.decimal_3, gclass230_3.decimal_2) ?? this.gclass0_0.method_450(null, gclass164_1_2,
                gclass230_2_1, 2, (int)gclass164_1.decimal_0 * 4, 0, null, null, null, null, null, null, null, null,
                null, null, true);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2652);
            return null;
        }
    }

    public ShipComponent method_6()
    {
        try
        {
            TechSystem gclass164_1 = this.gclass0_0.method_493(TechType.ShieldType, this.Level);
            TechSystem gclass164_2 = this.gclass0_0.method_493(TechType.ShieldRegenerationRate, this.Level);
            TechSystem gclass164 = this.gclass0_0.method_493(TechType.MaximumShieldGeneratorSize, this.Level);
            ShipComponent gclass230 =
                this.gclass0_0.method_455(null, gclass164_1, gclass164_2, gclass164.decimal_0, null, null, false);
            return this.gclass0_0.method_489(null, AuroraComponentType.Shields, gclass230.decimal_1,
                gclass230.decimal_3, gclass230.decimal_2) ?? this.gclass0_0.method_455(null, gclass164_1, gclass164_2,
                gclass164.decimal_0, null, null, true);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2653);
            return null;
        }
    }

    public ShipComponent method_7()
    {
        try
        {
            TechSystem gclass164_1 = this.gclass0_0.method_493(TechType.EngineTechnology, this.Level);
            TechSystem gclass164_2 = this.gclass0_0.method_493(TechType.FuelConsumption, this.Level);
            TechSystem gclass164_3 = this.gclass0_0.TechDataDictionary[26091];
            int decimal_14 = 5 + this.Level * 5;
            ShipComponent gclass230 = this.gclass0_0.method_457(null, gclass164_1, gclass164_2, gclass164_3, 1M, decimal_14,
                null, null, null, false);
            return this.gclass0_0.method_489(null, AuroraComponentType.Engine, gclass230.decimal_1, gclass230.decimal_3,
                gclass230.decimal_2) ?? this.gclass0_0.method_457(null, gclass164_1, gclass164_2, gclass164_3, 1M,
                decimal_14, null, null, null, true);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2654);
            return null;
        }
    }

    public ShipComponent method_8()
    {
        try
        {
            TechSystem gclass164_1 = this.gclass0_0.method_493(TechType.EngineTechnology, this.Level);
            TechSystem gclass164_2 = this.gclass0_0.method_493(TechType.FuelConsumption, this.Level);
            TechSystem gclass164_3 = this.gclass0_0.method_493(TechType.MinEngineThrustModifier, this.Level);
            TechSystem gclass164_4 = this.gclass0_0.method_493(TechType.MaximumEngineSize, this.Level);
            TechSystem gclass164_3_1 = this.gclass0_0.TechDataDictionary[26091];
            ShipComponent gclass230 = this.gclass0_0.method_457(null, gclass164_1, gclass164_2, gclass164_3_1,
                gclass164_3.decimal_0, gclass164_4.decimal_0, null, null, null, false);
            return this.gclass0_0.method_489(null, AuroraComponentType.Engine, gclass230.decimal_1, gclass230.decimal_3,
                gclass230.decimal_2) ?? this.gclass0_0.method_457(null, gclass164_1, gclass164_2, gclass164_3_1,
                gclass164_3.decimal_0, gclass164_4.decimal_0, null, null, null, true);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2655);
            return null;
        }
    }

    public ShipComponent method_9()
    {
        try
        {
            TechSystem gclass164_1 = this.gclass0_0.method_493(TechType.GaussCannonRateofFire, this.Level);
            TechSystem gclass164_5 = this.gclass0_0.method_493(TechType.TurretRotationGear, this.Level);
            TechSystem gclass164_3 = this.gclass0_0.method_493(TechType.FireControlSpeedRating, this.Level);
            TechSystem gclass164_2 = this.gclass0_0.method_493(TechType.BeamFireControlDistanceRating, this.Level);
            TechSystem gclass164_4 = this.gclass0_0.method_493(TechType.MissileWarheadStrength, this.Level);
            TechSystem gclass164_6 = this.gclass0_0.method_493(TechType.ECCM, this.Level);
            ShipComponent gclass230 = this.gclass0_0.method_460(null, gclass164_1, gclass164_2, gclass164_3, gclass164_4,
                gclass164_5, gclass164_6, null, null, false);
            return this.gclass0_0.method_489(null, AuroraComponentType.CIWS, gclass230.decimal_1, gclass230.decimal_3,
                gclass230.decimal_2) ?? this.gclass0_0.method_460(null, gclass164_1, gclass164_2, gclass164_3,
                gclass164_4, gclass164_5, gclass164_6, null, null, true);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2656);
            return null;
        }
    }

    public ShipComponent method_10()
    {
        try
        {
            TechSystem gclass164_1 = this.gclass0_0.method_493(TechType.JumpDriveEfficiency, this.Level);
            TechSystem gclass164_2 = this.gclass0_0.method_493(TechType.MaxJumpSquadronSize, this.Level);
            TechSystem gclass164_3 = this.gclass0_0.method_493(TechType.MaxSquadronJumpRadius, this.Level);
            TechSystem gclass164_4 = this.gclass0_0.TechDataDictionary[33302];
            Decimal decimal_13 = AuroraUtils.GetRandomInteger(100) + AuroraUtils.GetRandomInteger(100) + 10;
            if (AuroraUtils.GetRandomInteger(3) == 1)
                gclass164_4 = this.gclass0_0.TechDataDictionary[33303];
            ShipComponent gclass230 = this.gclass0_0.method_456(null, decimal_13, gclass164_1, gclass164_2, gclass164_3,
                gclass164_4, null, null, false);
            return this.gclass0_0.method_489(null, AuroraComponentType.JumpDrive, gclass230.decimal_1,
                gclass230.decimal_3, gclass230.decimal_2) ?? this.gclass0_0.method_456(null, decimal_13, gclass164_1,
                gclass164_2, gclass164_3, gclass164_4, null, null, true);
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 2657);
            return null;
        }
    }
}