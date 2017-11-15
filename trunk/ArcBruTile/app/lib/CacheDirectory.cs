using System;
using BruTile.Cache;
using BrutileArcGIS.Lib;
using System.IO;
using BruTile;
using BruTile.Wmts;

namespace BrutileArcGIS.lib
{
    public class CacheDirectory
    {
        // used by wmts
        public static FileCache GetFileCache(string baseCacheDir, ITileSource tileSource, EnumBruTileLayer enumBruTileLayer)
        {
            var schema = tileSource.Schema;

            var cacheDirType = GetCacheDirectory(tileSource, enumBruTileLayer, baseCacheDir);

            // todo: support other image formats as well...
            var fileCache = new FileCache(cacheDirType,tileSource.Schema.Format);

            return fileCache;
        }



        public static FileCache GetFileCache(string baseCacheDir, IConfig config, EnumBruTileLayer enumBruTileLayer)
        {
            var schema = config.CreateTileSource().Schema;

            var cacheDirType = GetCacheDirectory(config, enumBruTileLayer, baseCacheDir);

            var format = schema.Format;

            if (format.Contains(@"image/"))
            {
                format = format.Substring(6, schema.Format.Length - 6);
            }
            if (format.Contains("png8"))
            {
                format = format.Replace("png8", "png");
            }
            var fileCache = new FileCache(cacheDirType, format);

            return fileCache;

        }

        // for wmts
        private static string GetCacheDirectory(ITileSource tileSource, EnumBruTileLayer layerType, string baseCacheDir)
        {
            string cacheDirectory = string.Format("{0}{1}{2}{3}{4}", baseCacheDir, Path.DirectorySeparatorChar, layerType, Path.DirectorySeparatorChar, ((WmtsTileSchema)tileSource.Schema).Layer);
            return cacheDirectory;
        }

        private static string GetCacheDirectory(IConfig config, EnumBruTileLayer layerType, string baseCacheDir)
        {
            string cacheDirectory = String.Format("{0}{1}{2}", baseCacheDir, Path.DirectorySeparatorChar, layerType);

            if (layerType == EnumBruTileLayer.TMS || layerType == EnumBruTileLayer.InvertedTMS)
            {
                string url = null;
                if (layerType == EnumBruTileLayer.TMS)
                {
                    url = ((ConfigTms)config).Url;
                }
                else if (layerType == EnumBruTileLayer.InvertedTMS)
                {
                    if (config is ConfigInvertedTMS)
                    {
                        url = ((ConfigInvertedTMS)config).Url;
                    }
                    else if (config is NaverConfig)
                    {
                        url = ((NaverConfig)config).Url;
                    }
                    else if (config is DaumConfig)
                    {
                        url = ((DaumConfig)config).Url;
                        var idx = url.LastIndexOf('.');
                        url = url.Substring(0, idx);
                    }
                    else if (config is BaiduConfig)
                    {
                        url = ((BaiduConfig)config).Url;
                        url = url.Replace("?", "");
                    }
                    else if (config is TileLayerConfig)
                    {
                        url = ((TileLayerConfig)config).Url;
                        url = url.Replace("?", "");
                    }

                }

                string service = url.Substring(7, url.Length - 7);
                service = service.Replace(@"/", "-");
                service = service.Replace(":", "-");

                if (service.EndsWith("-"))
                {
                    service = service.Substring(0, service.Length - 1);
                }
                cacheDirectory = string.Format("{0}{1}{2}{3}{4}", baseCacheDir, Path.DirectorySeparatorChar, layerType, Path.DirectorySeparatorChar, service);
            }
            else if (layerType == EnumBruTileLayer.Giscloud)
            {
                var layerId = ((ConfigGisCloud)config).LayerId;
                cacheDirectory = string.Format("{0}{1}{2}{3}{4}", baseCacheDir, Path.DirectorySeparatorChar, "giscloud", Path.DirectorySeparatorChar, layerId);
            }

            return cacheDirectory;
        }

    }
}
