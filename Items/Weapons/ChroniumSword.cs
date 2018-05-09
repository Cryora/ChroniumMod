using Terraria.ID;
using Terraria.ModLoader;

namespace ChroniumMod.Items.Weapons
{
	public class ChroniumSword : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Durandal Of Time");
			Tooltip.SetDefault("Holy Man! Get rect -MrSadly");
		}
		public override void SetDefaults()
		{
			item.damage = 120;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 10;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 3;
			item.value = 10000;
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.DirtBlock, 10);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
