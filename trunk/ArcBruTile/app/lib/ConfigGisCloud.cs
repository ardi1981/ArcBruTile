using System;
using BrutileArcGIS.Lib;
using BruTile;
using BruTile.Predefined;
using BruTile.Web;

namespace BrutileArcGIS.lib
{
    public class ConfigGisCloud : IConfig
    {
        public ConfigGisCloud(string url, int layerId, string format)
        {
            Url = url ?? throw new ArgumentNullException("url");
            LayerId =layerId;
            Format = format;
        }

        public ITileSource CreateTileSource()
        {
            var tilesource = new TileSource(
                new WebTileProvider(new BasicRequest(Url)),
                new GlobalSphericalMercator(Format, true, 1, 19,"giscloud"));
            return tilesource;
        }

        public string Format { get; set; }

        public string Url { get; set; }

        public int LayerId { get; set; }
    }
}
