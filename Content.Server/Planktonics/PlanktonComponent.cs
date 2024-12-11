namespace Content.Server.Planktonics;

namespace Content.Server.Planktonics;

[RegisterComponent]
public sealed partial class PlanktonComponent : Component
{
    [DataField("currentSize"), ViewVariables(VVAccess.ReadWrite)]
    public float CurrentSize { get; set; } = 2.0f; // Starting size of cultures

    [DataField("isAlive"), ViewVariables(VVAccess.ReadWrite)]
    public bool IsAlive = true; // is the plankton alive?

    // Define a Diet Type Enum
    public enum PlanktonDiet
    {
        Carnivore,
        Photosynthetic,
        Radiophage,
        Saguinophage,
        Electrophage,
        Symbiotroph,
        Chemophage,
        Decomposer,
        Cryophilic,
        Pyrophilic,
        Scavenger
    }

    // Define Behaviors Type Enum
    [Flags]
    public enum PlanktonBehaviors
    {
        Aggressive = 1 << 0, //1
        Bioluminescent = 1 << 1, //2
        Parasitic = 1 << 2, //4
        Radioactive = 1 << 3, //8
        Charged = 1 << 4, //16
        Pyrotechnic = 1 << 5, //32
        Mimicry = 1 << 6, //64
        ChemicalProduction = 1 << 7, //128
        MagneticField = 1 << 8, //256
        Hallucinogenic = 1 << 9, //512
        PheromoneGlands = 1 << 10, //1024
        PolypColony = 1 << 11, //2048
        AerosolSpores = 1 << 12, //4096
        HyperExoticSpecies = 1 << 13, //8192
        Sentience = 1 << 14 //16384
    }

    // Define Attributes Type Enum
    public enum PlanktonAttributes
    {
        Bioluminescent,
        Radioactive,
        Magnetic,
        Hallucinogenic,
        ChemicalByproduct,
        Symbiosis,
        Carnivorous,
        Parasite,
        Photosynthetic,
        Pyrophilic,
        Cryophilic
    }

    // These hold the random generated values for the plankton's diet, behaviors, and attributes
    [DataField("diet"), ViewVariables(VVAccess.ReadWrite)]
    public PlanktonDiet Diet { get; set; }

    [DataField("behaviors"), ViewVariables(VVAccess.ReadWrite)]
    public PlanktonBehaviors Behaviors { get; set; }

    [DataField("attributes"), ViewVariables(VVAccess.ReadWrite)]
    public List<PlanktonAttributes> Attributes { get; set; } = new List<PlanktonAttributes>();

    // Additional properties
    [DataField("temperatureToleranceLow"), ViewVariables(VVAccess.ReadWrite)]
    public float TemperatureToleranceLow { get; set; } = 0.0f; // Min temperature tolerance

    [DataField("temperatureToleranceHigh"), ViewVariables(VVAccess.ReadWrite)]
    public float TemperatureToleranceHigh { get; set; } = 40.0f; // Max temperature tolerance
}

