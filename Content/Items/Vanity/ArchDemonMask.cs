using Terraria.ModLoader;
using Terraria;
using Terraria.ID;
using Microsoft.Xna.Framework;
using Terraria.GameContent.Creative;

namespace Consolaria.Content.Items.Vanity
{
	[AutoloadEquip(EquipType.Head)]
	public class ArchDemonMask : ModItem
	{
		public override void SetStaticDefaults() {
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults() {
			int width = 36; int height = 24;
			Item.Size = new Vector2(width, height);

			Item.rare = ItemRarityID.Orange;
			Item.sellPrice(gold: 1, silver: 10);

			Item.vanity = true;
		}
	}
}
