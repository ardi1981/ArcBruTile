using BrutileArcGIS.Lib;
using ESRI.ArcGIS.ADF.BaseClasses;
using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.DataSourcesRaster;
using ESRI.ArcGIS.Display;
using ESRI.ArcGIS.esriSystem;
using ESRI.ArcGIS.Framework;
using ESRI.ArcGIS.Geodatabase;
using ESRI.ArcGIS.Geometry;
using System;
using System.Drawing;
using System.Drawing.Imaging;

namespace BrutileArcGIS.commands
{
    public class DemoCustomLayer:BaseCustomLayer,ILayerPosition 
    {
        private IApplication application;
        private ISpatialReference sp;

        public DemoCustomLayer(IApplication application, ISpatialReference  sp){
            this.application=application;
            this.LayerWeight = 110;
            Name = "testlayertje";
            this.sp = sp;
        }

        public double LayerWeight
        {
            get;set;
        }

        public override void Draw(esriDrawPhase drawPhase, IDisplay display, ESRI.ArcGIS.esriSystem.ITrackCancel trackCancel)
        {
            var file = @"D:\aaa\strava_issue\2016_1350.png";

            var rl = new RasterLayerClass();
            rl.CreateFromFilePath(file);
            var props = (IRasterProps)rl.Raster;
            props.SpatialReference = new SpatialReferences().GetSpatialReference("urn: ogc:def: crs:EPSG: 6.18.3:3857");
            IRasterGeometryProc3 rasterGeometryProc = new RasterGeometryProcClass();
            var missing = Type.Missing;
            var layerSpatialReference = sp;
            rasterGeometryProc.ProjectFast(layerSpatialReference, rstResamplingTypes.RSP_NearestNeighbor, ref missing, rl.Raster);

            // fix 9/10/2015: with projected tiles color changes and transparency is ignored.
            var image = new Bitmap(file, true);
           // image.MakeTransparent(Color.White);
            //image.Save(@"D:\aaa\strava_issue\2018_1350.png");
            var format = image.PixelFormat;
            if (format == PixelFormat.Format24bppRgb | format == PixelFormat.Format32bppArgb)
            {
                var rasterRgbRenderer = new RasterRGBRendererClass();
               ((IRasterStretch2)rasterRgbRenderer).StretchType = esriRasterStretchTypesEnum.esriRasterStretch_NONE;
                // ((IRasterStretch3)rasterRgbRenderer).UseGamma = true;
                ((IRasterStretch2)rasterRgbRenderer).Background = true;
                ((IRasterStretch3)rasterRgbRenderer).UseGamma = true;
                var r = new RgbColorClass();
                r.Red = 49;
                r.Green = 0;
                r.Blue = 38;
                ((IRasterStretch2)rasterRgbRenderer).BackgroundColor = r;
                //((IRasterStretch2)rasterRgbRenderer).BackgroundColor = r;

                 rl.Renderer = rasterRgbRenderer;
            }
            // end fix 9/10/2015: with projected tiles color changes and transparency is ignored.

            rl.Draw(esriDrawPhase.esriDPGeography, display, null);
        }
    }
}


//var png = @"D:\\aaa\\0.png";
//var ul = new PointClass { X = -20037508.342789, Y = 20037508.342789 };
//var lr = new PointClass { X = 20037508.342789, Y = -20037508.342789 };
//ImageDrawer.Draw(display, png,ul,lr);

