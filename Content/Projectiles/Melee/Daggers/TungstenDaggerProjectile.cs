using Aurora.Common.Projectiles;
using Aurora.Core.Projectiles;

namespace Aurora.Content.Projectiles.Melee.Daggers;

public class TungstenDaggerProjectile : ModProjectile
{
	public override void SetDefaults() {
		base.SetDefaults();

		Projectile.width = 22;
		Projectile.height = 22;

		Projectile.TryEnableComponent<ProjectileDagger>();
	}
}
