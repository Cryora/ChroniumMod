using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using Microsoft.Xna.Framework.Graphics;

namespace ChroniumMod.Tiles
{
	public class ChroniumOreTile : ModTile
	{
		public override void SetDefaults()
		{
			Main.tileSolid[Type] = true;
			Main.tileMergeDirt[Type] = true;
			Main.tileLighted[Type] = true;
			Main.tileBlockLight[Type] = true;
			drop = mod.ItemType("ChroniumOre");
			ModTranslation name = CreateMapEntryName();
			name.SetDefault("Chronium Ore");
			AddMapEntry(new Color(148, 0, 224), name);
			minPick = 150;
		}
		public override void ModifyLight(int i, int j, ref float r, ref float g, ref float b)
		{
			r = 0.5f;
			g = 0.10f;
			b = 0.75f;
		}


	}
}

		