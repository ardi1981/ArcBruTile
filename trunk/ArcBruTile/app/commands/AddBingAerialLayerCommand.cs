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
    [ProgId("AddBingAerialLayerCommand")]
    public sealed class AddBingAerialLayerCommand : BaseCommand
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

        public AddBingAerialLayerCommand()
        {
            m_category = "BruTile";
            m_caption = "&Aerial";
            m_message = "AddBingAerialmap";
            m_toolTip = m_caption;
            m_name = "AddBingAerialLayerCommand";
            m_bitmap = Resources.download;

        }

        public override void OnClick()
        {
            var mxdoc = (IMxDocument)_application.Document;
            var tileSource= KnownTileSources.Create(KnownTileSource.BingAerial);
            var wmtsLayer = WmtsHelper.GetWmtsLayer(_application, tileSource, "Bing Aerial");
            var map = mxdoc.FocusMap;
            ((IMapLayers)map).InsertLayer(wmtsLayer, true, 0);
        }
    }
}
