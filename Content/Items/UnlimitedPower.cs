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
            player.GetDamage(DamageClass.Generic) += 99.99f;

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

            //No Knockback
            player.noKnockback = true;

            //No fall damage
            player.noFallDmg = true;

            // Infinite health
            player.statLife = player.statLifeMax2;

            // Infinite mana
            player.statMana = player.statManaMax2;

            // Extremely fast movement
            player.moveSpeed += 2f;

            // Night vision
            player.nightVision = true;

            // Character emits light
            player.AddBuff(BuffID.Shine, 2);
        }

        public override void ModifyTooltips(List<TooltipLine> tooltips)
        {
            tooltips.Add(new TooltipLine(Mod, "DamageBonus", "+9999% damage"));
            tooltips.Add(new TooltipLine(Mod, "FishingBonus", "9999 fishing power"));
            tooltips.Add(new TooltipLine(Mod, "MiningBonus", "Extremely fast mining"));
            tooltips.Add(new TooltipLine(Mod, "BreathBonus", "Infinite breath"));
            tooltips.Add(new TooltipLine(Mod, "FireWalk", "Immune to fire blocks"));
            tooltips.Add(new TooltipLine(Mod, "LavaImmune", "Immune to lava"));
            tooltips.Add(new TooltipLine(Mod, "LuckBonus", "Maximum luck"));
            tooltips.Add(new TooltipLine(Mod, "FlightBonus", "Infinite flight"));
            tooltips.Add(new TooltipLine(Mod, "KnockbackBonus", "Immune to knockback"));
            tooltips.Add(new TooltipLine(Mod, "FallDamage", "Immune to fall damage"));
            tooltips.Add(new TooltipLine(Mod, "HealthBonus", "Infinite health regeneration"));
            tooltips.Add(new TooltipLine(Mod, "ManaBonus", "Infinite mana regeneration"));
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