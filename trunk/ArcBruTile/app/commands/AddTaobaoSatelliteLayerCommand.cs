using System.Runtime.InteropServices;
using BrutileArcGIS.lib;
using BrutileArcGIS.Properties;
using ESRI.ArcGIS.ADF.BaseClasses;
using ESRI.ArcGIS.ArcMapUI;
using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.Framework;

namespace BrutileArcGIS.commands
{
    [ProgId("AddTaobaoSatelliteLayerCommand")]
    public class AddTaobaoSatelliteLayerCommand : BaseCommand
    {

        private IApplication _application;

        public AddTaobaoSatelliteLayerCommand()
        {
            m_category = "BruTile";
            m_caption = "&Taobao Satellite";
            m_message = "AddTaobaoSatellite map";
            m_toolTip = m_caption;
            m_name = "AddTaobaoSatelliteLayerCommand";
            m_bitmap = Resources.download;
        }

        public override void OnCreate(object hook)
        {
            if (hook == null)
                return;

            _application = hook as IApplication;

            if (hook is IMxApplication)
                m_enabled = true;
            else
                m_enabled = false;
        }

        public override void OnClick()
        {
            const string url = "https://bertt.github.io/wmts/capabilities/taobao.xml";
            var wmtsLayer = WmtsHelper.GetWmtsLayer(_application, "png", url, "Taobao satellite", "taobao-satellite");
            var mxdoc = (IMxDocument)_application.Document;
            var map = mxdoc.FocusMap;
            ((IMapLayers)map).InsertLayer(wmtsLayer, true, 0);
        }
    }
}
