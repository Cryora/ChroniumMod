using Terraria.ModLoader;
using Terraria.ID;

namespace ChroniumMod.Items.Placeable
{
	public class ChroniumOre : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Chronium Ore");
			Tooltip.SetDefault("Glows in harmony with time");
		}
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.useTime = 10;
			item.useAnimation = 15;
			item.useStyle = 1;
			item.value = 50;
			item.rare = 2;
			item.useTurn = true;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.consumable = true;
			item.createTile = mod.TileType("ChroniumOreTile");
			item.maxStack = 99;
		}
	}
}