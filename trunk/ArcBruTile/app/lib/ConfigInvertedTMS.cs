using System;
using System.Net;
using BruTile;
using BruTile.Predefined;
using BruTile.Tms;
using System.Collections.Generic;

namespace BrutileArcGIS.Lib
{
    public class ConfigInvertedTMS : IConfig
    {
        private string _url;

        public ConfigInvertedTMS(string url)
        {
            _url = url ?? throw new ArgumentNullException("url");
        }

        public ITileSource CreateTileSource()
        {
            var request = (HttpWebRequest)WebRequest.Create(_url);
            request.UserAgent = "Mozilla/5.0 (Windows; U; Windows NT 5.1; en-US; rv:1.8.1.14) Gecko/20080404 Firefox/2.0.0.14";
            var response = (HttpWebResponse)request.GetResponse();
            var stream = response.GetResponseStream();
            var tileSource = TileMapParser.CreateTileSource(stream);
            var s = new SphericalMercatorInvertedWorldSchema();

            // now remove all resolutions that are not in the Tilesource.
            // For example Strava level 18 we must not draw.
            var l = new List<String>();
            foreach(var res in s.Resolutions)
            {
                var r = tileSource.Schema.Resolutions.ContainsKey(res.Key);
                if (!r){
                    l.Add(res.Key);
                }
            }
            foreach(var p in l)
            {
                s.Resolutions.Remove(p);
            }

            return new TileSource(tileSource.Provider, s);
        }


        public string Url
        {
            get { return _url; }
            set { _url = value; }
        }
    }
}
