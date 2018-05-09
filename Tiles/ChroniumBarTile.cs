using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using Microsoft.Xna.Framework.Graphics;
using Terraria.ObjectData;

namespace ChroniumMod.Tiles
{
	public class ChroniumBarTile : ModTile
	{
		public override void SetDefaults()
		{
			Main.tileSolid[Type] = true;
			Main.tileFrameImportant[Type] = true;
			TileObjectData.newTile.CopyFrom(TileObjectData.Style1x1);
			TileObjectData.addTile(Type);
			drop = mod.ItemType("ChroniumBar");
			ModTranslation name = CreateMapEntryName();
			name.SetDefault("Chronium Bar");
			AddMapEntry(new Color(148, 0, 224), name);
			minPick = 150;
		}
		


	}
}

