using System.Runtime.InteropServices;
using BrutileArcGIS.Lib;
using BrutileArcGIS.Properties;

namespace BrutileArcGIS.commands
{
    [ProgId("AddMapBoxSatelliteLayerCommand")]
    public sealed class AddMapBoxSatelliteLayerCommand : AddTmsLayerCommandBase
    {
        public AddMapBoxSatelliteLayerCommand()
            : base("BruTile", "&Satellite", "Add Satellite Layer", "MapBox Satellite", Resources.download, "https://raw.githubusercontent.com/ArcBruTile/ArcBruTile/master/configuration/Services/Mapbox/Satellite.xml", EnumBruTileLayer.InvertedTMS)
        {
        }
    }

    [ProgId("AddMapBoxStreetsLayerCommand")]
    public sealed class AddMapBoxStreetsLayerCommand : AddTmsLayerCommandBase
    {
        public AddMapBoxStreetsLayerCommand() : base("BruTile", "&Streets", "Add Streets Layer", "MapBox Streets", Resources.download, "https://raw.githubusercontent.com/ArcBruTile/ArcBruTile/master/configuration/Services/Mapbox/Streets.xml", EnumBruTileLayer.InvertedTMS, "mapbox")
        {
        }
    }

    [ProgId("AddMapBoxLightCommand")]
    public sealed class AddMapBoxLightLayerCommand : AddTmsLayerCommandBase
    {
        public AddMapBoxLightLayerCommand() : base("BruTile", "&Light", "Add Light Layer", "MapBox Light", Resources.download, "https://raw.githubusercontent.com/ArcBruTile/ArcBruTile/master/configuration/Services/Mapbox/Light.xml", EnumBruTileLayer.InvertedTMS, "mapbox")
        {
        }
    }

    [ProgId("AddMapBoxDarkCommand")]
    public sealed class AddMapBoxDarkLayerCommand : AddTmsLayerCommandBase
    {
        public AddMapBoxDarkLayerCommand() : base("BruTile", "&Dark", "Add Dark Layer", "MapBox Dark", Resources.download, "https://raw.githubusercontent.com/ArcBruTile/ArcBruTile/master/configuration/Services/Mapbox/Dark.xml", EnumBruTileLayer.InvertedTMS, "mapbox")
        {
        }
    }

    [ProgId("AddMapBoxStreetsSatelliteCommand")]
    public sealed class AddMapBoxStreetsSatelliteLayerCommand : AddTmsLayerCommandBase
    {
        public AddMapBoxStreetsSatelliteLayerCommand() : base("BruTile", "&StreetsSatellite", "Add StreetsSatellite Layer", "MapBox StreetsSatellite", Resources.download, "https://raw.githubusercontent.com/ArcBruTile/ArcBruTile/master/configuration/Services/Mapbox/Streets-satellite.xml", EnumBruTileLayer.InvertedTMS, "mapbox")
        {
        }
    }

    [ProgId("AddMapBoxWheatpasteCommand")]
    public sealed class AddMapBoxWheatpasteLayerCommand : AddTmsLayerCommandBase
    {
        public AddMapBoxWheatpasteLayerCommand() : base("BruTile", "&Wheatpaste", "Add Wheatpaste Layer", "MapBox Wheatpaste", Resources.download, "https://raw.githubusercontent.com/ArcBruTile/ArcBruTile/master/configuration/Services/Mapbox/wheatpaste.xml", EnumBruTileLayer.InvertedTMS, "mapbox")
        {
        }
    }

    [ProgId("AddMapBoxStreetsBasicCommand")]
    public sealed class AddMapBoxStreetsBasicLayerCommand : AddTmsLayerCommandBase
    {
        public AddMapBoxStreetsBasicLayerCommand() : base("BruTile", "&Streets - basic", "Add Streets - basic Layer", "MapBox Streets - Basic", Resources.download, "https://raw.githubusercontent.com/ArcBruTile/ArcBruTile/master/configuration/Services/Mapbox/streets-basic.xml", EnumBruTileLayer.InvertedTMS, "mapbox")
        {
        }
    }

    [ProgId("AddMapBoxComicCommand")]
    public sealed class AddMapBoxComicLayerCommand : AddTmsLayerCommandBase
    {
        public AddMapBoxComicLayerCommand() : base("BruTile", "&Comic", "Add Comic", "MapBox Comic", Resources.download, "https://raw.githubusercontent.com/ArcBruTile/ArcBruTile/master/configuration/Services/Mapbox/comic.xml", EnumBruTileLayer.InvertedTMS, "mapbox")
        {
        }
    }

    [ProgId("AddMapBoxOutdoorsCommand")]
    public sealed class AddMapBoxOutdoorsLayerCommand : AddTmsLayerCommandBase
    {
        public AddMapBoxOutdoorsLayerCommand() : base("BruTile", "&Outdoors", "Add Outdoors", "MapBox Outdoors", Resources.download, "https://raw.githubusercontent.com/ArcBruTile/ArcBruTile/master/configuration/Services/Mapbox/outdoors.xml", EnumBruTileLayer.InvertedTMS, "mapbox")
        {
        }
    }

    [ProgId("AddMapBoxRunBikeHikeCommand")]
    public sealed class AddMapBoxRunBikeHikeLayerCommand : AddTmsLayerCommandBase
    {
        public AddMapBoxRunBikeHikeLayerCommand() : base("BruTile", "&Run - bike - hike", "Add Run - bike - hike", "MapBox Run - bike - hike", Resources.download, "https://raw.githubusercontent.com/ArcBruTile/ArcBruTile/master/configuration/Services/Mapbox/run-bike-hike.xml", EnumBruTileLayer.InvertedTMS, "mapbox")
        {
        }
    }

    [ProgId("AddMapBoxPencilCommand")]
    public sealed class AddMapBoxPencilLayerCommand : AddTmsLayerCommandBase
    {
        public AddMapBoxPencilLayerCommand() : base("BruTile", "&Pencil", "Add pencil", "MapBox Pencil", Resources.download, "https://raw.githubusercontent.com/ArcBruTile/ArcBruTile/master/configuration/Services/Mapbox/pencil.xml", EnumBruTileLayer.InvertedTMS, "mapbox")
        {
        }
    }

    [ProgId("AddMapBoxPiratesCommand")]
    public sealed class AddMapBoxPiratesLayerCommand : AddTmsLayerCommandBase
    {
        public AddMapBoxPiratesLayerCommand() : base("BruTile", "&Pirates", "Add pirates", "MapBox Pirates", Resources.download, "https://raw.githubusercontent.com/ArcBruTile/ArcBruTile/master/configuration/Services/Mapbox/pirates.xml", EnumBruTileLayer.InvertedTMS, "mapbox")
        {
        }
    }

    [ProgId("AddMapBoxEmeraldCommand")]
    public sealed class AddMapBoxEmeraldLayerCommand : AddTmsLayerCommandBase
    {
        public AddMapBoxEmeraldLayerCommand() : base("BruTile", "&Emerald", "Add emerald", "MapBox Emerald", Resources.download, "https://raw.githubusercontent.com/ArcBruTile/ArcBruTile/master/configuration/Services/Mapbox/emerald.xml", EnumBruTileLayer.InvertedTMS, "mapbox")
        {
        }
    }

    [ProgId("AddMapBoxHighContrastCommand")]
    public sealed class AddMapBoxHighContrastLayerCommand : AddTmsLayerCommandBase
    {
        public AddMapBoxHighContrastLayerCommand() : base("BruTile", "&High-contrast", "Add high-contrast", "MapBox High-Contrast", Resources.download, "https://raw.githubusercontent.com/ArcBruTile/ArcBruTile/master/configuration/Services/Mapbox/high-contrast.xml", EnumBruTileLayer.InvertedTMS, "mapbox")
        {
        }
    }

}
