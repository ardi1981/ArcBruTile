using System.Runtime.InteropServices;
using BrutileArcGIS.Properties;
using ESRI.ArcGIS.ADF.BaseClasses;
using BrutileArcGIS.lib;
using ESRI.ArcGIS.Framework;
using ESRI.ArcGIS.ArcMapUI;
using ESRI.ArcGIS.Carto;

namespace BrutileArcGIS.commands
{
    [ProgId("AddAppleLayerCommand")]
    public sealed class AddAppleLayerCommand : BaseCommand
    {
        private IApplication _application;

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

        public AddAppleLayerCommand()
        {
            m_category = "BruTile";
            m_caption = "&Apple";
            m_message = "AddApple map";
            m_toolTip = m_caption;
            m_name = "AddAppleLayerCommand";
            m_bitmap = Resources.download;

        }

        public override void OnClick()
        {
            const string url = "https://bertt.github.io/wmts/capabilities/apple.xml";
            var wmtsLayer = WmtsHelper.GetWmtsLayer(_application, "png", url, "Apple", "apple-streets");
            var mxdoc = (IMxDocument)_application.Document;
            var map = mxdoc.FocusMap;
            ((IMapLayers)map).InsertLayer(wmtsLayer, true, 0);
        }
    }
}
