// Decompiled with JetBrains decompiler
// Type: GClass99
// Assembly: Aurora, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAB8E3AD-3A24-426F-849E-98EC2E2DD9EB
// Assembly location: C:\Users\jinhoon.kim\Desktop\Aurora250Full\Dedot\aurora-deop.exe

using Aurora;
using System;

#nullable disable
//TODO: Planet Terrain runtime data probably
public class PlanetaryTerrainDefinition
{
    public PlanetDominantTerrain DominantTerrainType;
    public PlanetDominantTerrain BaseTerrainType;
    public AuroraTectonics MinTectonics;
    public AuroraTectonics MaximumTectonics;
    public int MinTempRange;
    public Decimal ToHitModifier;
    public Decimal FortificationModifier;
    public double MinimumHydro;
    public double MaximumHydro;
    public double MinTemperature;
    public double MaxTemperature;
    public double MinOxygen;
    public bool IsDesertTerrain;
    public bool IsJungleTerrain;
    public string Abbreviation;

    public string Name { get; set; }
}