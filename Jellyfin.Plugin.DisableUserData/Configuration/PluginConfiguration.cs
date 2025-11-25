using MediaBrowser.Model.Plugins;

namespace Jellyfin.Plugin.DisableUserData.Configuration;

public class PluginConfiguration : BasePluginConfiguration
{
    public PluginConfiguration()
    {
        DisableOnCollections = false;
        DisableOnNextUp = false;
        DisableOnContinueWatching = false;
        DisableOnRecentlyAdded = false;
    }

    /// <summary>
    /// Disable User Data for collections on Items endpoints.
    /// (GetItems + GetItemsByUserIdLegacy).
    /// </summary>
    public bool DisableOnCollections { get; set; }

    /// <summary>
    /// Disable User Data on Continue Watching endpoint
    /// (GetResumeItemsLegacy).
    /// </summary>
    public bool DisableOnContinueWatching { get; set; }

    /// <summary>
    /// Disable User Data on NextUp endpoint
    /// (GetNextUp).
    /// </summary>
    public bool DisableOnNextUp { get; set; }

    /// <summary>
    /// Disable User Data on Recently Added endpoints
    /// (GetResumeItemsLegacy + GetResumeItems).
    /// </summary>
    public bool DisableOnRecentlyAdded { get; set; }
}
