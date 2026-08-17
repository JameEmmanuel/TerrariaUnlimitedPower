using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace UnlimitedPower.Content.Items
{
    public class UnlimitedPower : ModItem
    {
        public override void SetDefaults()
        {
            Item.width = 32;
            Item.height = 32;

            Item.accessory = true;

            Item.value = Item.buyPrice(gold: 1);
            Item.rare = ItemRarityID.Red;

            Item.defense = 9999;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            // +9999% damage
            player.GetDamage(DamageClass.Generic) += 999.99f;

            // +9999 fishing power
            player.fishingSkill += 9999;

            // Much faster mining
            player.pickSpeed -= 0.99f;

            // Infinite breath
            player.breath = player.breathMax;

            // Fire block immunity
            player.fireWalk = true;

            // Lava immunity
            player.lavaImmune = true;

            // Maximum luck
            player.luck = 10f;

            // Infinite flight
            player.wingTimeMax = 999999;
            player.wingTime = player.wingTimeMax;
        }

        public override void ModifyTooltips(List<TooltipLine> tooltips)
        {
            tooltips.Add(new TooltipLine(Mod, "DamageBonus", "+99999% damage"));
            tooltips.Add(new TooltipLine(Mod, "FishingBonus", "9999 fishing power"));
        }

        public override void AddRecipes()
        {
            // Wood + Dirt
            Recipe recipe = CreateRecipe();

            recipe.AddIngredient(ItemID.Wood, 10);
            recipe.AddIngredient(ItemID.DirtBlock, 10);

            recipe.Register();

            // Ash Wood + Ash Block
            Recipe ashRecipe = CreateRecipe();

            ashRecipe.AddIngredient(ItemID.AshWood, 10);
            ashRecipe.AddIngredient(ItemID.AshBlock, 10);

            ashRecipe.Register();
        }
    }
}