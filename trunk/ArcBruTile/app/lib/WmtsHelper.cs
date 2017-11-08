using BruTile.Wmts;
using BrutileArcGIS.Lib;
using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.esriSystem;
using ESRI.ArcGIS.Framework;
using ESRI.ArcGIS.GISClient;
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
            // todo: take other layers as well
            var tileSources = WmtsParser.Parse(stream);

            var tileSource = (from a in tileSources where ((WmtsTileSchema)a.Schema).Layer == LayerId select a).FirstOrDefault();
            // todo: make dynamic
            tileSource.Schema.Format = format;

            var brutileLayer = new BruTileLayer(_application, tileSource)
            {
                Name = LayerName,
                Visible = true
            };
            return brutileLayer;
        }

        /**
        public static WMTSLayerClass GetWmtsLayerArcGIS(string Url, string LayerName, string LayerId)
        {
            var propSet = new PropertySetClass();
            propSet.SetProperty("URL", Url);
            var wmtsConnFactory = new WMTSConnectionFactoryClass();
            var wmtsConnection = wmtsConnFactory.Open(propSet, 0, null);

            var wmtsServiceDescription = (IWMTSServiceDescription)wmtsConnection;
            for (int i = 0; i < wmtsServiceDescription.LayerDescriptionCount; i++)
            {
                var layerDescription = wmtsServiceDescription.LayerDescription[i];
                if (layerDescription.Identifier == LayerId)
                {
                    var wmtsLayer = new WMTSLayerClass();
                    IPropertySet propSet_1 = new PropertySetClass();
                    propSet_1.SetProperty("URL", Url);
                    propSet_1.SetProperty("LayerName", layerDescription.Identifier);

                    var connectionName = new WMTSConnectionNameClass();
                    connectionName.ConnectionProperties = propSet_1;
                    wmtsLayer.Connect((IName)connectionName);
                    wmtsLayer.Name = LayerName;
                    return wmtsLayer;
                }
            }
            return null;
        }
    */


    }
}
