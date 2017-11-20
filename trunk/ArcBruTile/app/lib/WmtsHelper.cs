using BruTile.Wmts;
using BrutileArcGIS.Lib;
using ESRI.ArcGIS.Framework;
using System.Linq;
using System.Net.Http;

namespace BrutileArcGIS.lib
{
    public class WmtsHelper
    {
        public static BruTileLayer GetWmtsLayer(IApplication _application, string format, string capabilitiesUrl, string LayerName, string LayerId)
        {
            var httpClient = new HttpClient();
            var stream = httpClient.GetStreamAsync(capabilitiesUrl).Result;
            var tileSources = WmtsParser.Parse(stream);
            var tileSource = (from a in tileSources where ((WmtsTileSchema)a.Schema).Layer == LayerId select a).FirstOrDefault();
            tileSource.Schema.Format = format;

            var brutileLayer = new BruTileLayer(_application, tileSource)
            {
                Name = LayerName,
                Visible = true
            };
            return brutileLayer;
        }
    }
}
