using BrutileArcGIS.Lib;
using BrutileArcGIS.Properties;
using System.Runtime.InteropServices;

namespace BrutileArcGIS.commands
{
    [ProgId("AddStravaCyclingLayerCommand")]
    public sealed class AddStravaCyclingLayerCommand : AddTmsLayerCommandBase
    {
        public AddStravaCyclingLayerCommand()
            : base("BruTile", "&Cycling", "Add Strava Cycling Layer", "Strava cycle heatmap", Resources.download, "https://raw.githubusercontent.com/ArcBruTile/ArcBruTile/master/configuration/Services/Strava/strava-cycle.xml", EnumBruTileLayer.InvertedTMS)
        {
        }
    }

    [ProgId("AddStravaRunningLayerCommand")]
    public sealed class AddStravaRunningLayerCommand : AddTmsLayerCommandBase
    {
        public AddStravaRunningLayerCommand()
            : base("BruTile", "&Running", "Add Strava Running Layer", "Strava running heatmap", Resources.download, "https://raw.githubusercontent.com/ArcBruTile/ArcBruTile/master/configuration/Services/Strava/strava-running.xml", EnumBruTileLayer.InvertedTMS)
        {
        }
    }

    [ProgId("AddStravaBothLayerCommand")]
    public sealed class AddStravaBothLayerCommand : AddTmsLayerCommandBase
    {
        public AddStravaBothLayerCommand()
            : base("BruTile", "&Running and cycling", "Add Strava Running and cycling Layer", "Strava running and cycling heatmap", Resources.download, "https://raw.githubusercontent.com/ArcBruTile/ArcBruTile/master/configuration/Services/Strava/strava-both.xml", EnumBruTileLayer.InvertedTMS)
        {
        }
    }

}
