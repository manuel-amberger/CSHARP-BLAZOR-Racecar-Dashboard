namespace ApexView;

public class FlagHelper {
    public static readonly Dictionary<EFlags, string> Map = new() {
        { EFlags.IN_BOX, "In Box" },
        { EFlags.STANDING_ON_TRACK, "Steht auf Strecke" },
        { EFlags.NO_ENGINE, "Motorschaden" },
        { EFlags.ON_TOWTRUCK, "Wird abgeschleppt ..." },
        { EFlags.DNF, "DNF" },
        { EFlags.DRIVING, "Fährt auf Strecke" },
        { EFlags.SMALL_DAMAGE, "Schaden am Auto" },
        { EFlags.TIRE_EXPLOSION, "Reifen explodiert" }
    };
}