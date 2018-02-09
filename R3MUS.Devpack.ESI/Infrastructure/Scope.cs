using System;
using System.ComponentModel.DataAnnotations;

namespace R3MUS.Devpack.ESI.Infrastructure
{
    [Obsolete("Please use enums associated with specific paths", true)]
    public enum Scope
    {
        #region Skills

            [Display(Name = "esi-skills.read_skills.v1")]
            ReadSkills,
            [Display(Name = "esi-skills.read_skillqueue.v1")]
            ReadSkillQueue,

        #endregion

        #region Wallet

            [Display(Name = "esi-wallet.read_character_wallet.v1")]
            ReadCharacterWallet,

        #endregion
            
        [Display(Name = "esi-search.search_structures.v1")]
        SearchStructures,
        [Display(Name = "esi-clones.read_clones.v1")]
        ReadClones,
        [Display(Name = "esi-bookmarks.read_character_bookmarks.v1")]
        ReadCharacterBookmarks,
        [Display(Name = "esi-killmails.read_killmails.v1")]
        ReadKillmails,
        [Display(Name = "esi-assets.read_assets.v1")]
        ReadAssets,
        [Display(Name = "esi-planets.manage_planets.v1")]
        ManagePlanets,
        [Display(Name = "esi-fleets.read_fleet.v1")]
        ReadFleet,
        [Display(Name = "esi-fleets.write_fleet.v1")]
        WriteFleet,
        [Display(Name = "esi-ui.open_window.v1")]
        OpenWindow,
        [Display(Name = "esi-ui.write_waypoint.v1")]
        WriteWaypoint,
        [Display(Name = "esi-fittings.read_fittings.v1")]
        ReadFittings,
        [Display(Name = "esi-fittings.write_fittings.v1")]
        WriteFittings,
        [Display(Name = "esi-markets.structure_markets.v1")]
        StructureMarkets,
        [Display(Name = "esi-industry.read_character_jobs.v1")]
        ReadCharacterJobs,
        [Display(Name = "esi-markets.read_character_orders.v1")]
        ReadCharacterOrders,
        [Display(Name = "esi-location.read_online.v1")]
        ReadOnline,
        [Display(Name = "esi-clones.read_implants.v1")]
        ReadImplants
    }
}