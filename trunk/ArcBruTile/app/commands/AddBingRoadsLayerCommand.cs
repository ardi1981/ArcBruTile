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
    [ProgId("AddBingRoadsLayerCommand")]
    public sealed class AddBingRoadsLayerCommand : BaseCommand
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

        public AddBingRoadsLayerCommand()
        {
            m_category = "BruTile";
            m_caption = "&Roads";
            m_message = "AddBingRoadsmap";
            m_toolTip = m_caption;
            m_name = "AddBingRoadsLayerCommand";
            m_bitmap = Resources.download;

        }

        public override void OnClick()
        {
            var mxdoc = (IMxDocument)_application.Document;
            var tileSource= KnownTileSources.Create(KnownTileSource.BingRoads);
            var wmtsLayer = WmtsHelper.GetWmtsLayer(_application, tileSource, "Bing Roads");
            var map = mxdoc.FocusMap;
            ((IMapLayers)map).InsertLayer(wmtsLayer, true, 0);
        }
    }
}
