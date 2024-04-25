﻿using Application.Chemicals.Commands.Create;
using Application.Common;
using Domain.Chemicals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Chemicals.Commands.Update;

public sealed record UpdateChemicalCommand : ICommand
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public double TocWeight { get; set; }
    public double NitrogenWeight { get; set; }
    public double BiocideWeight { get; set; }
    public double Density { get; set; }
    public string HazardClass { get; set; } //green,yellow,red,black
    public string MeasureUnitDefault { get; set; } //kg,l,tonn,m3
    public bool FollowOilPhaseDefault { get; set; }
    public bool FollowWaterPhaseDefault { get; set; }
    public bool Tentative { get; set; }
    public DateTime Proposed { get; set; }
    public string ProposedBy { get; set; }
    public string ProposedByName { get; set; }
    public string ProposedByEmail { get; set; }
    public bool Disabled { get; set; }
    public Guid? ProposedByInstallationId { get; set; }
    public string UpdatedBy { get; set; }
    public string UpdatedByName { get; set; }

    public static Chemical Map(UpdateChemicalCommand command, Chemical chemical)
    {
        chemical.Name = command.Name;
        chemical.Description = command.Description;
        chemical.TocWeight = command.TocWeight;
        chemical.NitrogenWeight = command.NitrogenWeight;
        chemical.BiocideWeight = command.BiocideWeight;
        chemical.Density = command.Density;
        chemical.HazardClass = command.HazardClass;
        chemical.MeasureUnitDefault = command.MeasureUnitDefault;
        chemical.FollowOilPhaseDefault = command.FollowOilPhaseDefault;
        chemical.FollowWaterPhaseDefault = command.FollowWaterPhaseDefault;
        chemical.Tentative = command.Tentative;
        chemical.Proposed = command.Proposed;
        chemical.ProposedBy = command.ProposedBy;
        chemical.ProposedByName = command.ProposedByName;
        chemical.ProposedByEmail = command.ProposedByEmail;
        chemical.Disabled = command.Disabled;
        chemical.ProposedByInstallationId = command.ProposedByInstallationId;
        chemical.Updated = DateTime.Now;
        chemical.UpdatedBy = command.UpdatedBy;
        chemical.UpdatedByName = command.UpdatedByName;

        return chemical;
        //return new Chemical
        //{
        //    Name = command.Name,
        //    Description = command.Description,
        //    TocWeight = command.TocWeight,
        //    NitrogenWeight = command.NitrogenWeight,
        //    BiocideWeight = command.BiocideWeight,
        //    Density = command.Density,
        //    HazardClass = command.HazardClass,
        //    MeasureUnitDefault = command.MeasureUnitDefault,
        //    FollowOilPhaseDefault = command.FollowOilPhaseDefault,
        //    FollowWaterPhaseDefault = command.FollowWaterPhaseDefault,
        //    Tentative = command.Tentative,
        //    Proposed = DateTime.Now,
        //    ProposedBy = command.ProposedBy,
        //    ProposedByName = command.ProposedByName,
        //    ProposedByEmail = command.ProposedByEmail,
        //    Disabled = command.Disabled,
        //    ProposedByInstallationId = command.ProposedByInstallationId,
        //    Updated = DateTime.Now,
        //    UpdatedBy = command.UpdatedBy,
        //    UpdatedByName = command.UpdatedByName
        //};
    }
}
