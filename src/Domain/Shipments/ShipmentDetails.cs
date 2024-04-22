﻿using Domain.Attachments;
using Domain.Comments;
using Domain.Installations;
using Domain.LogEntries;
using Domain.ShipmentChemicals;
using Domain.ShipmentParts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Shipments;

public sealed class ShipmentDetails
{   
    public string Code { get; set; }
    public string Title { get; init; }
    public Guid SenderId { get; set; }
    public Guid ReceiverId { get; set; }
    public string Type { get; set; }
    public string Status { get; set; }
    public double RinsingOffshorePercent { get; set; }
    public DateTime PlannedExecutionFrom { get; set; }
    public DateTime PlannedExecutionTo { get; set; }
    public double WaterAmount { get; init; }
    public double WaterAmountPerHour { get; set; }
    public bool VolumePersentageOffspec { get; set; }
    public string Well { get; set; }
    public bool ContainsChemicals { get; set; }
    public bool ContainsStableOilEmulsion { get; set; }
    public bool ContainsHighParticleAmount { get; set; }
    public bool ContainsBiocides { get; set; }
    public bool VolumeHasBeenMinimized { get; set; }
    public string VolumeHasBeenMinimizedComment { get; set; }
    public bool? NormalProcedure { get; set; }
    public bool? OnlyWayToGetRidOf { get; set; }
    public string OnlyWayToGetRidOfComment { get; set; }
    public bool? AvailableForDailyContact { get; set; }
    public bool HeightenedLra { get; set; }
    public double? Pb210 { get; set; }
    public double? Ra226 { get; set; }
    public double? Ra228 { get; set; }
    public bool TakePrecaution { get; set; }
    public string Precautions { get; set; }
    public bool WaterHasBeenAnalyzed { get; set; }
    public DateTime Updated { get; set; }
    public string UpdatedBy { get; set; }
    public string UpdatedByName { get; set; }
    public bool HasBeenOpened { get; set; }
}