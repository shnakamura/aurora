using Newtonsoft.Json;

namespace Aurora.Common.Ambience;

public struct AmbienceTrackSoundData
{
    [JsonRequired]
    public string SoundPath { get; set; }
}
