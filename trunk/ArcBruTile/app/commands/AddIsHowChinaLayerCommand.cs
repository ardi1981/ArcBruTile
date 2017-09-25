using System.Runtime.InteropServices;
using BrutileArcGIS.Lib;
using BrutileArcGIS.Properties;

namespace BrutileArcGIS.commands
{
    [ProgId("AddIsHowChinaLayerCommand")]

    public sealed class AddIsHowChinaLayerCommand : AddTmsLayerCommandBase
    {
        public AddIsHowChinaLayerCommand()
            : base("BruTile", "&IsHowChina", "Add IsHowChina", "IsHowChina Streets", Resources.download, "https://raw.githubusercontent.com/ArcBruTile/ArcBruTile/master/configuration/Services/ishowchina/streets.xml", EnumBruTileLayer.InvertedTMS)
        {
        }
    }
}
