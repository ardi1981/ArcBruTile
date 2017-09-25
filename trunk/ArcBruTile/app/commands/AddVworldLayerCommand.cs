using System.Runtime.InteropServices;
using BrutileArcGIS.Lib;
using BrutileArcGIS.Properties;

namespace BrutileArcGIS.commands
{
    public class AddVworldLayerCommand
    {
        [ProgId("AddVWorldStreetLayerCommand")]
        public sealed class AddVWorldStreetLayerCommand  : AddTmsLayerCommandBase
        {
            public AddVWorldStreetLayerCommand()
                : base("BruTile", "&Streets", "Add Street Layer", "VWorld Street", Resources.download, "https://raw.githubusercontent.com/ArcBruTile/ArcBruTile/master/configuration/Services/vworld/vworldstreet.xml", EnumBruTileLayer.InvertedTMS)
            {
            }
        }

        [ProgId("AddVWorldSatelliteLayerCommand")]
        public sealed class AddVWorldSatelliteLayerCommand : AddTmsLayerCommandBase
        {
            public AddVWorldSatelliteLayerCommand()
                : base("BruTile", "&Satellite", "Add Satellite Layer", "VWorld Satelite", Resources.download, "https://raw.githubusercontent.com/ArcBruTile/ArcBruTile/master/configuration/Services/vworld/vworldsatellite.xml", EnumBruTileLayer.InvertedTMS)
            {
            }
        }

        [ProgId("AddVWorldHybridLayerCommand")]
        public sealed class AddVWorldHybridLayerCommand : AddTmsLayerCommandBase
        {
            public AddVWorldHybridLayerCommand()
                : base("BruTile", "&Hybrid", "Add Hybrid Layer", "VWorld Hybrid", Resources.download, "https://raw.githubusercontent.com/ArcBruTile/ArcBruTile/master/configuration/Services/vworld/hybrid.xml", EnumBruTileLayer.InvertedTMS)
            {
            }
        }
    }
}
