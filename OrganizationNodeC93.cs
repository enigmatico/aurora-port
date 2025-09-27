// Decompiled with JetBrains decompiler
// Type: GClass93
// Assembly: Aurora, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAB8E3AD-3A24-426F-849E-98EC2E2DD9EB
// Assembly location: C:\Users\jinhoon.kim\Desktop\Aurora250Full\Dedot\aurora-deop.exe

using Aurora;
using System;

#nullable disable
public class OrganizationNodeC93
{
    public OrganizationNodeC93 ParentOrganizationNode;
    public GroundUnitFormationTemplateData FormationTemplate;
    public GameRace Race;
    public AuroraGroundFormationFieldPosition FieldPosition;
    public int OrganizationID;
    public int ParentOrganizationID;
    public string OrganizationName = "";
    public bool NodeExpanded;

    public string method_0()
    {
        try
        {
            string string0 = this.OrganizationName;
            return this.FormationTemplate == null
                ? string0
                : (this.FieldPosition != AuroraGroundFormationFieldPosition.FrontlineDefence
                    ? (this.FieldPosition != AuroraGroundFormationFieldPosition.FrontlineAttack
                        ? (this.FieldPosition != AuroraGroundFormationFieldPosition.Support
                            ? (this.FieldPosition != AuroraGroundFormationFieldPosition.RearEchelon
                                ? $"{this.FormationTemplate.Abbreviation} {this.FormationTemplate.Name}"
                                : $"{this.FormationTemplate.Abbreviation} {this.FormationTemplate.Name}  (RE)")
                            : $"{this.FormationTemplate.Abbreviation} {this.FormationTemplate.Name}  (SP)")
                        : $"{this.FormationTemplate.Abbreviation} {this.FormationTemplate.Name}  (FA)")
                    : $"{this.FormationTemplate.Abbreviation} {this.FormationTemplate.Name}");
        }
        catch (Exception ex)
        {
            AuroraUtils.ShowExceptionPopup(ex, 3622);
            return "error";
        }
    }
}