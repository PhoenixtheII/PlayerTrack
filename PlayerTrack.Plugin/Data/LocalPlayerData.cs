using System;
using Dalamud.Utility;

namespace PlayerTrack.Data;

/// <summary>
/// Subset of key properties from local player for eventing.
/// </summary>
public class LocalPlayerData
{
    /// <summary>
    /// The content ID of the local character.
    /// </summary>
    public ulong ContentId;

    /// <summary>
    /// Player Name.
    /// </summary>
    public string Name = string.Empty;

    /// <summary>
    /// Player HomeWorld ID.
    /// </summary>
    public uint HomeWorld;

    public byte[]? Customize;

    /// <summary>
    /// Player Customize Array.
    /// </summary>
    //public Span<byte> Customize { get; init; } = Span<byte>.Empty;

    /// <summary>
    /// Validate if local player is valid.
    /// </summary>
    /// <returns>Indicator if local player is valid.</returns>
    public bool IsValid() => ContentId != 0 && Name.IsValidCharacterName() && HomeWorld != 0;
}
