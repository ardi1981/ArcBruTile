using System.Runtime.InteropServices;
using BrutileArcGIS.Properties;
using ESRI.ArcGIS.ADF.BaseClasses;
using BrutileArcGIS.lib;
using ESRI.ArcGIS.Framework;
using ESRI.ArcGIS.ArcMapUI;
using ESRI.ArcGIS.Carto;

namespace BrutileArcGIS.commands
{
    [ProgId("AddMichelinLayerCommand")]
    public sealed class AddMichelinLayerCommand : BaseCommand
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

        public AddMichelinLayerCommand()
        {
            m_category = "BruTile";
            m_caption = "&Michelin";
            m_message = "AddMichelin map";
            m_toolTip = m_caption;
            m_name = "AddMichelinLayerCommand";
            m_bitmap = Resources.download;

        }

        public override void OnClick()
        {
            const string url = "https://bertt.github.io/wmts/capabilities/michelin.xml";
            var wmtsLayer = WmtsHelper.GetWmtsLayer(_application, "png", url, "Michelin", "michelin-streets");
            var mxdoc = (IMxDocument)_application.Document;
            var map = mxdoc.FocusMap;
            ((IMapLayers)map).InsertLayer(wmtsLayer, true, 0);
        }
    }
}
