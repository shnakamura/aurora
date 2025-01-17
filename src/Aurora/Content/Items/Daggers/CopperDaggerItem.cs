using Aurora.Content.Projectiles.Daggers;

namespace Aurora.Content.Items.Daggers;

public class CopperDaggerItem : ModItem
{
    public override void SetDefaults() {
        base.SetDefaults();

        Item.maxStack = Item.CommonMaxStack;

        Item.noUseGraphic = true;
        Item.consumable = true;
        Item.autoReuse = false;
        Item.noMelee = true;

        Item.DamageType = DamageClass.Melee;
        Item.knockBack = 1f;
        Item.damage = 5;

        Item.width = 24;
        Item.height = 24;

        Item.useTime = 12;
        Item.useAnimation = 12;
        Item.UseSound = SoundID.Item1;
        Item.useStyle = ItemUseStyleID.Rapier;

        Item.rare = ItemRarityID.White;

        Item.shootSpeed = 2f;
        Item.shoot = ModContent.ProjectileType<CopperDaggerProjectile>();
                
        Item.rare = ItemRarityID.Blue;
    }

    public override void AddRecipes() {
        base.AddRecipes();

        CreateRecipe(25)
            .AddIngredient(ItemID.CopperBar)
            .AddTile(TileID.Anvils)
            .Register();
    }
}
