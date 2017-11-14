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
    [ProgId("AddThunderforestOutdoorsLayerCommand")]
    public class AddThunderforestOutdoorsLayerCommand : BaseCommand
    {
        private IApplication _application;

        public AddThunderforestOutdoorsLayerCommand()
        {
            m_category = "BruTile";
            m_caption = "&Outdoors";
            m_message = "Add Thunderforest.Outdoors layer";
            m_toolTip = m_caption;
            m_name = "AddThunderforestOutdoorsMapLayerCommand";
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
                const string url = "https://bertt.github.io/wmts/capabilities/thunderforest.xml";
                var wmtsLayer = WmtsHelper.GetWmtsLayer(_application, "png", url, "Outdoors", "thunderforest-outdoors");

                var mxdoc = (IMxDocument)_application.Document;
                var map = mxdoc.FocusMap;
                ((IMapLayers)map).InsertLayer(wmtsLayer, true, 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}