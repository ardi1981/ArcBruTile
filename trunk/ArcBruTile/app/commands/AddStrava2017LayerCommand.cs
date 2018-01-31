using System.Runtime.InteropServices;
using BrutileArcGIS.Properties;
using ESRI.ArcGIS.ADF.BaseClasses;
using BrutileArcGIS.lib;
using ESRI.ArcGIS.Framework;
using ESRI.ArcGIS.ArcMapUI;
using ESRI.ArcGIS.Carto;
using BruTile.Web;
using BruTile.Wmts;
using BrutileArcGIS.forms;
using BrutileArcGIS.Lib;
using System.Windows.Forms;
using System;

namespace BrutileArcGIS.commands
{
    [ProgId("AddStrava2017LayerCommand")]
    public sealed class AddStrava2017LayerCommand : BaseCommand
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

        public AddStrava2017LayerCommand()
        {
            m_category = "BruTile";
            m_caption = "&Strava 2017...";
            m_message = "AddStrava2017 map";
            m_toolTip = m_caption;
            m_name = "AddStrava2017LayerCommand";
            m_bitmap = Resources.download;
        }

        public override void OnClick()
        {

            var addStravaForm = new AddStravaForm();
            var dr = addStravaForm.ShowDialog(new ArcMapWindow(_application));
            if (dr == DialogResult.OK)
            {
                var stravaColor = addStravaForm.StravaColor;
                var stravaActivityType = addStravaForm.StravaActivityType;
                AddStravaLayer(stravaColor, stravaActivityType);
            }
        }

        private void AddStravaLayer(StravaColor stravaColor, StravaActivityType stravaActivityType)
        {
            const string url = "http://bertt.github.io/wmts/capabilities/strava2017.xml";
            var wmtsLayer = WmtsHelper.GetWmtsLayer(_application, "png", url, $"Strava 2017 - {stravaActivityType.ToString()}", "strava-riding");
            var prov = (HttpTileProvider)wmtsLayer.TileSource.Provider;

            foreach(var resourceUrl in ((WmtsRequest)prov.Request)._resourceUrls)
            {
                var template = resourceUrl.Template;
                template = template.Replace("{color}", stravaColor.ToString());
                template = template.Replace("{activity_type}", stravaActivityType.ToString());
                resourceUrl.Template = template;
            }
            var schema = (WmtsTileSchema)wmtsLayer.TileSource.Schema;
            schema.Layer = $"strava-{stravaColor.ToString()}-{stravaActivityType.ToString()}";
            wmtsLayer.TileSource.Schema = schema;

            var mxdoc = (IMxDocument)_application.Document;
            var map = mxdoc.FocusMap;
            ((IMapLayers)map).InsertLayer(wmtsLayer, true, 0);
        }
    }
}
