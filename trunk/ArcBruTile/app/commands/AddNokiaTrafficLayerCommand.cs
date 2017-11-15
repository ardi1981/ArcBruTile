using System.Runtime.InteropServices;
using BrutileArcGIS.lib;
using BrutileArcGIS.Lib;
using BrutileArcGIS.Properties;
using ESRI.ArcGIS.ADF.BaseClasses;
using ESRI.ArcGIS.ArcMapUI;
using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.Framework;

namespace BrutileArcGIS.commands
{
    [ProgId("AddNokiaTerrainLayerCommand")]
    public class AddNokiaTrafficLayerCommand : BaseCommand
    {
        private IApplication _application;

        public AddNokiaTrafficLayerCommand()
        {
            m_category = "BruTile";
            m_caption = "&Traffic";
            m_message = "Add Nokia Here Traffic";
            m_toolTip = m_caption;
            m_name = "AddNokiaTrafficLayerCommand";
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
            const string url = "https://bertt.github.io/wmts/capabilities/nokia.xml";
            var wmtsLayer = WmtsHelper.GetWmtsLayer(_application, "png", url, "Nokia traffic", "nokia-traffic");
            var mxdoc = (IMxDocument)_application.Document;
            var map = mxdoc.FocusMap;
            ((IMapLayers)map).InsertLayer(wmtsLayer, true, 0);
        }
    }
}
