using System.Runtime.InteropServices;
using BrutileArcGIS.Lib;
using BrutileArcGIS.Properties;

namespace BrutileArcGIS.commands
{
    [ProgId("AddCartoDBDarkmatterLayerCommand")]
    public sealed class AddCartoDBDarkmatterLayerCommand : AddTmsLayerCommandBase
    {
        public AddCartoDBDarkmatterLayerCommand()
            : base("BruTile", "&Darkmatter", "Add CartoDB Darkmatter Layer", "CartoDB Darkmatter", Resources.download, "https://raw.githubusercontent.com/ArcBruTile/ArcBruTile/master/config/Services/cartodb/darkmatter.xml", EnumBruTileLayer.InvertedTMS)
        {
        }
    }

    [ProgId("AddCartoDBPositronLayerCommand")]
    public sealed class AddCartoDBPositronLayerCommand : AddTmsLayerCommandBase
    {
        public AddCartoDBPositronLayerCommand()
            : base("BruTile", "&Positron", "Add CartoDB Positron Layer", "Positron", Resources.download, "https://raw.githubusercontent.com/ArcBruTile/ArcBruTile/master/config/Services/cartodb/positron.xml", EnumBruTileLayer.InvertedTMS)
        {
        }
    }
}