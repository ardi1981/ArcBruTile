using System;
using System.Windows.Forms;
using ESRI.ArcGIS.ADF.BaseClasses;
using ESRI.ArcGIS.ArcMapUI;
using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.Framework;
using BrutileArcGIS.Properties;
using System.Runtime.InteropServices;
using BrutileArcGIS.lib;

namespace BrutileArcGIS.commands
{
    [ProgId("AddOsmDECommand")]
    public class AddOsmDELayerCommand : BaseCommand
    {
        private IApplication _application;

        public AddOsmDELayerCommand()
        {
            m_category = "BruTile";
            m_caption = "&OpenStreetMap.DE";
            m_message = "Add OpenStreetMap.DE layer";
            m_toolTip = m_caption;
            m_name = "AddOsmDELayerCommand";
            m_bitmap = Resources.download;
        }

        public override bool Enabled
        {
            get
            {
                return true;
            }
        }

        public override void OnCreate(object hook)
        {
            if (hook == null)
                return;

            _application = hook as IApplication;

            //Disable if it is not ArcMap
            if (hook is IMxApplication)
                m_enabled = true;
            else
                m_enabled = false;
        }

        public override void OnClick()
        {
            try
            {
                const string url = "https://bertt.github.io/wmts/capabilities/osm.xml";
                //var wmtsLayer = WmtsHelper.GetWmtsLayerArcGIS(url, "OpenStreetMap.DE", "osm-openstreetmap.de");
                var wmtsLayer = WmtsHelper.GetWmtsLayer(_application, "png", url, "OpenStreetMap.DE", "osm-openstreetmap.de");
                if (wmtsLayer != null)
                {
                    var mxdoc = (IMxDocument)_application.Document;
                    var map = mxdoc.FocusMap;
                    ((IMapLayers)map).InsertLayer(wmtsLayer, true, 0);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}