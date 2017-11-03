using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.esriSystem;
using ESRI.ArcGIS.GISClient;

namespace BrutileArcGIS.lib
{
    public class WmtsLayerHelper
    {
        public static WMTSLayerClass GetWmtsLayer(string Url, string LayerName, string LayerId)
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
    }
}