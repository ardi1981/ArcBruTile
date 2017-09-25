using System.Runtime.InteropServices;
using BrutileArcGIS.Lib;
using BrutileArcGIS.Properties;

namespace BrutileArcGIS.commands
{
    [ProgId("AddStamenWaterColorLayerCommand")]
    public sealed class AddStamenWaterColorLayerCommand : AddTmsLayerCommandBase
    {
        public AddStamenWaterColorLayerCommand()
            : base("BruTile", "&Watercolor", "Add Watercolor Layer", "Stamen WaterColor", Resources.download, "https://raw.githubusercontent.com/ArcBruTile/ArcBruTile/master/configuration/Services/stamen/watercolor.xml",EnumBruTileLayer.InvertedTMS)
        {
        }
    }

    [ProgId("AddStamenTonerLayerCommand")]
    public sealed class AddStamenTonerLayerCommand : AddTmsLayerCommandBase
    {
        public AddStamenTonerLayerCommand()
            : base("BruTile", "&Toner", "Add Toner Layer", "Stamen Toner", Resources.download, "https://raw.githubusercontent.com/ArcBruTile/ArcBruTile/master/configuration/Services/stamen/toner.xml", EnumBruTileLayer.InvertedTMS)
        {
        }
    }

    [ProgId("AddStamenTerrainLayerCommand")]
    public sealed class AddStamenTerrainLayerCommand : AddTmsLayerCommandBase
    {
        public AddStamenTerrainLayerCommand()
            : base("BruTile", "&Terrain", "Add Terrain Layer", "Stamen Terrain (USA)", Resources.download, "https://raw.githubusercontent.com/ArcBruTile/ArcBruTile/master/configuration/Services/stamen/terrain.xml", EnumBruTileLayer.InvertedTMS)
        {
        }
    }

}
