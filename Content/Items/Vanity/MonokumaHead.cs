using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Microsoft.Xna.Framework;
using Consolaria.Content.Items.Materials;

namespace Consolaria.Content.Items.Vanity {
    [AutoloadEquip(EquipType.Head)]

	public class MonokumaHead : ModItem {
		public override void SetStaticDefaults () {
			Item.ResearchUnlockCount = 1;
		}

		public override void SetDefaults () {
			int width = 30; int height = 18;
			Item.Size = new Vector2(width, height);

			Item.rare = ItemRarityID.White;
			Item.value = Item.sellPrice(silver: 15);
			Item.vanity = true;
		}

		public override void AddRecipes () {
			CreateRecipe()
				.AddIngredient(ItemID.Silk, 20)
				.AddIngredient<WhiteThread>(3)
				.AddIngredient(ItemID.BlackThread, 3)
				.AddTile(TileID.Loom)
				.Register();
		}
	}
}