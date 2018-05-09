using Terraria.ModLoader;
using Terraria.ID;

namespace ChroniumMod.Items.Placeable
{
	public class ChroniumBar : ModItem
	{
		public override void SetDefaults()
		{
			DisplayName.SetDefault("Chronium Bar");
			Tooltip.SetDefault("Wow look it's glowing more");
			item.width = 24;
			item.height = 24;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.value = 50;
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.consumable = true;
			item.createTile = mod.TileType("ChroniumBarTile");
			item.maxStack = 99;
		}

		public override void AddRecipes()
		{
			ModRecipe r = new ModRecipe(mod);
			r.AddIngredient(null, "ChroniumOre", 4);
			r.AddTile(TileID.Furnaces);
			r.SetResult(this);
			r.AddRecipe();
		}
	}
}
