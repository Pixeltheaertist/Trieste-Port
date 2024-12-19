﻿namespace Content.Server.Plankton;

[RegisterComponent]
public sealed partial class PlanktonScannerComponent : Component
{

    [DataField("planktonReportEntityId", customTypeSerializer: typeof(PrototypeIdSerializer<EntityPrototype>))]
    public string PlanktonReportEntityId = "Paper";

}