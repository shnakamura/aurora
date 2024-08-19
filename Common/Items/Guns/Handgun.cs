using Aurora.Common.Items.Components;
using Aurora.Common.Items.Effects;
using Aurora.Content.Gores;

namespace Aurora.Common.Items.Guns;

public sealed class Handgun : GlobalItem
{
    public override bool AppliesToEntity(Item entity, bool lateInstantiation) {
        return entity.type == ItemID.Handgun;
    }

    public override void SetDefaults(Item entity) {
        base.SetDefaults(entity);

        entity.TryEnableComponent<ItemBulletCasings>(c => { c.Data.Type = ModContent.GoreType<BulletCasing>(); });
    }
}