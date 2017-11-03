using ESRI.ArcGIS.SystemUI;

namespace BrutileArcGIS.MenuDefs
{
    public class OsmMenuDef : IMenuDef
    {
        public string Caption
        {
            get { return "&OpenStreetMap"; }
        }

        public void GetItemInfo(int pos, IItemDef itemDef)
        {
            switch (pos)
            {
                case 0:
                    itemDef.ID = "AddOsmLayerCommand1";
                    itemDef.Group = false;
                    break;
                case 1:
                    itemDef.ID = "AddOsmBlackWhiteCommand";
                    itemDef.Group = false;
                    break;
                case 2:
                    itemDef.ID = "AddOsmDECommand";
                    itemDef.Group = false;
                    break;
                case 3:
                    itemDef.ID = "AddOsmFRCommand";
                    itemDef.Group = false;
                    break;
                case 4:
                    itemDef.ID = "AddOsmOpenTopoMapCommand";
                    itemDef.Group = false;
                    break;

            }
        }

        public int ItemCount
        {
            get { return 5; }
        }

        public string Name
        {
            get { return "BruTile"; }
        }
    }
}
