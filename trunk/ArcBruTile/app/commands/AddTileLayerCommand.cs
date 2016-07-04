using System.Runtime.InteropServices;
using System.Windows.Forms;
using ESRI.ArcGIS.ADF.BaseClasses;
using ESRI.ArcGIS.ArcMapUI;
using ESRI.ArcGIS.Framework;
using BrutileArcGIS.Properties;
using BrutileArcGIS.lib;
using BrutileArcGIS.Lib;
using ESRI.ArcGIS.Carto;
using BrutileArcGIS.forms;
using System.Linq;

namespace BrutileArcGIS.commands
{
    [ProgId("AddTileLayerCommand")]
    public class AddTileLayerCommand : BaseCommand
    {
        private IApplication _application;

        public AddTileLayerCommand()
        {
            m_category = "BruTile";
            m_caption = "&Add Tile Layer...";
            m_message = "Add Tile Layer...";
            m_toolTip = m_caption;
            m_name = "AddTileLayerCommand";
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

            var addTileServiceForm = new AddTileServiceForm();
            var dr = addTileServiceForm.ShowDialog(new ArcMapWindow(_application));
            if (dr == DialogResult.OK)
            {
                // todo add subdomains, auth
                // sample url: "https://tiles.shipmap.org/tiles/5/28/17.png";
                //var url = "http://tiles.shipmap.org/tiles/{z}/{x}/{y}.png";
                // var url = "https://2.aerial.maps.api.here.com/maptile/2.1/maptile/newest/hybrid.day.transit/{z}/{x}/{y}/512/png8?app_id=xWVIueSv6JL0aJ5xqTxb&app_code=djPZyynKsbTjIUDOBcHZ2g";
                // var url = "https://c.tile.thunderforest.com/cycle/{z}/{x}/{y}.png";
                // var name = "shipmap";

                var url = addTileServiceForm.Url;
                var servers = addTileServiceForm.Domains;
                var name = addTileServiceForm.Name;

                var layerType = EnumBruTileLayer.InvertedTMS;
                var mxdoc = (IMxDocument)_application.Document;
                var map = mxdoc.FocusMap;

                var tileLayerConfig = new TileLayerConfig(name, url);
                if (url.Contains("{s}"))
                {
                    var serverList = servers.Split(',').ToList();
                    tileLayerConfig.Domains = serverList;
                }

                var brutileLayer = new BruTileLayer(_application, tileLayerConfig, layerType)
                {
                    Name = name,
                    Visible = true
                };
                ((IMapLayers)map).InsertLayer(brutileLayer, true, 0);
            }
        }
    }
}
