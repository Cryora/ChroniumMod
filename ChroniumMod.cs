using Terraria.ModLoader;

namespace ChroniumMod
{
	class ChroniumMod : Mod
	{
		public ChroniumMod()
		{
			Properties = new ModProperties()
			{
				Autoload = true,
				AutoloadGores = true,
				AutoloadSounds = true
			};
		}
	}
}
