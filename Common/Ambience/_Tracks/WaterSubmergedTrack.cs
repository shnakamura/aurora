using Aurora.Utilities.Extensions;
using Terraria.Audio;

namespace Aurora.Common.Ambience;

public sealed class WaterSubmergedTrack : ModAmbience
{
    public override SoundStyle Sound { get; } = new SoundStyle($"{nameof(Aurora)}/Assets/Sounds/Ambience/WaterSubmergedLoop", SoundType.Ambient) {
        IsLooped = true,
        Volume = 0.7f
    };

    public override bool IsActive(Player player, SceneMetrics metrics) {
        return player.IsDrowning();
    }
}
