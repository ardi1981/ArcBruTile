using System.Runtime.InteropServices;
using BrutileArcGIS.Properties;
using ESRI.ArcGIS.ADF.BaseClasses;
using BrutileArcGIS.lib;
using ESRI.ArcGIS.Framework;
using ESRI.ArcGIS.ArcMapUI;
using ESRI.ArcGIS.Carto;
using BruTile.Predefined;

namespace BrutileArcGIS.commands
{
    [ProgId("AddBingHyrbidLayerCommand")]
    public sealed class AddBingHybridLayerCommand : BaseCommand
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

        public AddBingHybridLayerCommand()
        {
            m_category = "BruTile";
            m_caption = "&Hybrid";
            m_message = "AddBingHybridmap";
            m_toolTip = m_caption;
            m_name = "AddBingHybridLayerCommand";
            m_bitmap = Resources.download;

        }

        public override void OnClick()
        {
            var mxdoc = (IMxDocument)_application.Document;
            var tileSource= KnownTileSources.Create(KnownTileSource.BingHybrid);
            var wmtsLayer = WmtsHelper.GetWmtsLayer(_application, tileSource, "Bing Hybrid");
            var map = mxdoc.FocusMap;
            ((IMapLayers)map).InsertLayer(wmtsLayer, true, 0);
        }
    }
}
