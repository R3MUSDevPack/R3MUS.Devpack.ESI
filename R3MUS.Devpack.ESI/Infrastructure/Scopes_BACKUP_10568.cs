using System.ComponentModel.DataAnnotations;

namespace R3MUS.Devpack.ESI.Infrastructure
{
<<<<<<< HEAD
    public enum Scope
    {
        [Display(Name = "corporationContactsRead")]
        CorporationContactsRead,
        [Display(Name = "publicData")]
        PublicData,
        [Display(Name = "characterStatsRead")]
        CharacterStatsRead,
        [Display(Name = "characterFittingsRead")]
        CharacterFittingsRead,
        [Display(Name = "characterFittingsWrite")]
        CharacterFittingsWrite,
        [Display(Name = "characterContactsRead")]
        CharacterContactsRead,
        [Display(Name = "characterContactsWrite")]
        CharacterContactsWrite,
        [Display(Name = "characterLocationRead")]
        CharacterLocationRead,
        [Display(Name = "characterNavigationWrite")]
        CharacterNavigationWrite,
        [Display(Name = "characterWalletRead")]
        CharacterWalletRead,
        [Display(Name = "characterAssetsRead")]
        CharacterAssetsRead,
        [Display(Name = "characterCalendarRead")]
        CharacterCalendarRead,
        [Display(Name = "characterFactionalWarfareRead")]
        CharacterFactionalWarfareRead,
        [Display(Name = "characterIndustryJobsRead")]
        CharacterIndustryJobsRead,
        [Display(Name = "characterKillsRead")]
        CharacterKillsRead,
        [Display(Name = "characterMailRead")]
        CharacterMailRead,
        [Display(Name = "characterMarketOrdersRead")]
        CharacterMarketOrdersRead,
        [Display(Name = "characterMedalsRead")]
        CharacterMedalsRead,
        [Display(Name = "characterNotificationsRead")]
        CharacterNotificationsRead,
        [Display(Name = "characterResearchRead")]
        CharacterResearchRead,
        [Display(Name = "characterSkillsRead")]
        CharacterSkillsRead,
        [Display(Name = "characterAccountRead")]
        CharacterAccountRead,
        [Display(Name = "characterContractsRead")]
        CharacterContractsRead,
        [Display(Name = "characterBookmarksRead")]
        CharacterBookmarksRead,
        [Display(Name = "characterChatChannelsRead")]
        CharacterChatChannelsRead,
        [Display(Name = "characterClonesRead")]
        CharacterClonesRead,
        [Display(Name = "characterOpportunitiesRead")]
        CharacterOpportunitiesRead,
        [Display(Name = "characterLoyaltyPointsRead")]
        CharacterLoyaltyPointsRead,
        [Display(Name = "corporationWalletRead")]
        CorporationWalletRead,
        [Display(Name = "corporationAssetsRead")]
        CorporationAssetsRead,
        [Display(Name = "corporationMedalsRead")]
        CorporationMedalsRead,
        [Display(Name = "corporationFactionalWarfareRead")]
        CorporationFactionalWarfareRead,
        [Display(Name = "corporationIndustryJobsRead")]
        CorporationIndustryJobsRead,
        [Display(Name = "corporationKillsRead")]
        CorporationKillsRead,
        [Display(Name = "corporationMembersRead")]
        CorporationMembersRead,
        [Display(Name = "corporationMarketOrdersRead")]
        CorporationMarketOrdersRead,
        [Display(Name = "corporationStructuresRead")]
        CorporationStructuresRead,
        [Display(Name = "corporationShareholdersRead")]
        CorporationShareholdersRead,
        [Display(Name = "corporationContractsRead")]
        CorporationContractsRead,
        [Display(Name = "corporationBookmarksRead")]
        CorporationBookmarksRead,
        [Display(Name = "fleetRead")]
        FleetRead,
        [Display(Name = "fleetWrite")]
        FleetWrite,
        [Display(Name = "structureVulnUpdate")]
        StructureVulnUpdate,
        [Display(Name = "remoteClientUI")]
        RemoteClientUI,
        [Display(Name = "esi-calendar.respond_calendar_events.v1")]
        RespondCalendarEvents,
        [Display(Name = "esi-calendar.read_calendar_events.v1")]
        ReadCalendarEvents,
        [Display(Name = "esi-location.read_location.v1")]
        rReadLocation,
        [Display(Name = "esi-location.read_ship_type.v1")]
        ReadShipType,
        [Display(Name = "esi-mail.organize_mail.v1")]
        OrganizeMail,
        [Display(Name = "esi-mail.read_mail.v1")]
        ReadMail,
        [Display(Name = "esi-mail.send_mail.v1")]
        SendMail,
        [Display(Name = "esi-skills.read_skills.v1")]
        ReadSkills,
        [Display(Name = "esi-skills.read_skillqueue.v1")]
        ReadSkillqueue,
        [Display(Name = "esi-wallet.read_character_wallet.v1")]
        ReadCharacterWallet,
        [Display(Name = "esi-search.search_structures.v1")]
        SearchStructures,
        [Display(Name = "esi-clones.read_clones.v1")]
        ReadClones,
        [Display(Name = "esi-characters.read_contacts.v1")]
        ReadContacts,
        [Display(Name = "esi-universe.read_structures.v1")]
        ReadUniverseStructures,
        [Display(Name = "esi-bookmarks.read_character_bookmarks.v1")]
        ReadCharacterBookmarks,
        [Display(Name = "esi-killmails.read_killmails.v1")]
        ReadKillmails,
        [Display(Name = "esi-corporations.read_corporation_membership.v1")]
        ReadCorporationMembership,
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
        [Display(Name = "esi-characters.write_contacts.v1")]
        WriteContacts,
        [Display(Name = "esi-fittings.read_fittings.v1")]
        ReadFittings,
        [Display(Name = "esi-fittings.write_fittings.v1")]
        WriteFittings,
        [Display(Name = "esi-markets.structure_markets.v1")]
        StructureMarkets,
        [Display(Name = "esi-corporations.read_structures.v1")]
        ReadCorporationStructures,
        [Display(Name = "esi-corporations.write_structures.v1")]
        WriteCorporationStructures,
        [Display(Name = "esi-characters.read_loyalty.v1")]
        ReadLoyalty,
        [Display(Name = "esi-characters.read_opportunities.v1")]
        ReadOpportunities,
        [Display(Name = "esi-characters.read_chat_channels.v1")]
        ReadChatChannels,
        [Display(Name = "esi-characters.read_medals.v1")]
        ReadMedals,
        [Display(Name = "esi-characters.read_standings.v1")]
        ReadStanding,
        [Display(Name = "esi-characters.read_agents_research.v1")]
        ReadAgentsResearch,
        [Display(Name = "esi-industry.read_character_jobs.v1")]
        ReadCharacterJobs,
        [Display(Name = "esi-markets.read_character_orders.v1")]
        ReadCharacterOrders,
        [Display(Name = "esi-characters.read_blueprints.v1")]
        ReadBlueprints,
        [Display(Name = "esi-characters.read_corporation_roles.v1")]
        ReadCorporationRoles,
        [Display(Name = "esi-location.read_online.v1")]
        ReadOnline,
        [Display(Name = "esi-contracts.read_character_contracts.v1")]
        ReadCharacterContracts,
        [Display(Name = "esi-clones.read_implants.v1")]
        ReadImplants,
        [Display(Name = "esi-characters.read_fatigue.v1")]
        ReadFatigue
    }
=======
	public enum Scopes
	{
		 [Display(Name = "corporationContactsRead")] corporationContactsRead,
		 [Display(Name = "publicData")] publicData,
		 [Display(Name = "characterStatsRead")] characterStatsRead,
		 [Display(Name = "characterFittingsRead")] characterFittingsRead,
		 [Display(Name = "characterFittingsWrite")] characterFittingsWrite,
		 [Display(Name = "characterContactsRead")] characterContactsRead,
		 [Display(Name = "characterContactsWrite")] characterContactsWrite,
		 [Display(Name = "characterLocationRead")] characterLocationRead,
		 [Display(Name = "characterNavigationWrite")] characterNavigationWrite,
		 [Display(Name = "characterWalletRead")] characterWalletRead,
		 [Display(Name = "characterAssetsRead")] characterAssetsRead,
		 [Display(Name = "characterCalendarRead")] characterCalendarRead,
		 [Display(Name = "characterFactionalWarfareRead")] characterFactionalWarfareRead,
		 [Display(Name = "characterIndustryJobsRead")] characterIndustryJobsRead,
		 [Display(Name = "characterKillsRead")] characterKillsRead,
		 [Display(Name = "characterMailRead")] characterMailRead,
		 [Display(Name = "characterMarketOrdersRead")] characterMarketOrdersRead,
		 [Display(Name = "characterMedalsRead")] characterMedalsRead,
		 [Display(Name = "characterNotificationsRead")] characterNotificationsRead,
		 [Display(Name = "characterResearchRead")] characterResearchRead,
		 [Display(Name = "characterSkillsRead")] characterSkillsRead,
		 [Display(Name = "characterAccountRead")] characterAccountRead,
		 [Display(Name = "characterContractsRead")] characterContractsRead,
		 [Display(Name = "characterBookmarksRead")] characterBookmarksRead,
		 [Display(Name = "characterChatChannelsRead")] characterChatChannelsRead,
		 [Display(Name = "characterClonesRead")] characterClonesRead,
		 [Display(Name = "characterOpportunitiesRead")] characterOpportunitiesRead,
		 [Display(Name = "characterLoyaltyPointsRead")] characterLoyaltyPointsRead,
		 [Display(Name = "corporationWalletRead")] corporationWalletRead,
		 [Display(Name = "corporationAssetsRead")] corporationAssetsRead,
		 [Display(Name = "corporationMedalsRead")] corporationMedalsRead,
		 [Display(Name = "corporationFactionalWarfareRead")] corporationFactionalWarfareRead,
		 [Display(Name = "corporationIndustryJobsRead")] corporationIndustryJobsRead,
		 [Display(Name = "corporationKillsRead")] corporationKillsRead,
		 [Display(Name = "corporationMembersRead")] corporationMembersRead,
		 [Display(Name = "corporationMarketOrdersRead")] corporationMarketOrdersRead,
		 [Display(Name = "corporationStructuresRead")] corporationStructuresRead,
		 [Display(Name = "corporationShareholdersRead")] corporationShareholdersRead,
		 [Display(Name = "corporationContractsRead")] corporationContractsRead,
		 [Display(Name = "corporationBookmarksRead")] corporationBookmarksRead,
		 [Display(Name = "fleetRead")] fleetRead,
		 [Display(Name = "fleetWrite")] fleetWrite,
		 [Display(Name = "structureVulnUpdate")] structureVulnUpdate,
		 [Display(Name = "remoteClientUI")] remoteClientUI,
		 [Display(Name = "esi-calendar.respond_calendar_events.v1")] respondCalendarEvents,
		 [Display(Name = "esi-calendar.read_calendar_events.v1")] readCalendarEvents,
		 [Display(Name = "esi-location.read_location.v1")] readLocation,
		 [Display(Name = "esi-location.read_ship_type.v1")] readShipType,
		 [Display(Name = "esi-mail.organize_mail.v1")] organizeMail,
		 [Display(Name = "esi-mail.read_mail.v1")] readMail,
		 [Display(Name = "esi-mail.send_mail.v1")] sendMail,
		 [Display(Name = "esi-skills.read_skills.v1")] readSkills,
		 [Display(Name = "esi-skills.read_skillqueue.v1")] readSkillqueue,
		 [Display(Name = "esi-wallet.read_character_wallet.v1")] readCharacterWallet,
		 [Display(Name = "esi-search.search_structures.v1")] searchStructures,
		 [Display(Name = "esi-clones.read_clones.v1")] readClones,
		 [Display(Name = "esi-characters.read_contacts.v1")] readContacts,
		 [Display(Name = "esi-universe.read_structures.v1")] readUniverseStructures,
		 [Display(Name = "esi-bookmarks.read_character_bookmarks.v1")] readCharacterBookmarks,
		 [Display(Name = "esi-killmails.read_killmails.v1")] readKillmails,
		 [Display(Name = "esi-corporations.read_corporation_membership.v1")] readCorporationMembership,
		 [Display(Name = "esi-assets.read_assets.v1")] readAssets,
		 [Display(Name = "esi-planets.manage_planets.v1")] managePlanets,
		 [Display(Name = "esi-fleets.read_fleet.v1")] readFleet,
		 [Display(Name = "esi-fleets.write_fleet.v1")] writeFleet,
		 [Display(Name = "esi-ui.open_window.v1")] openWindow,
		 [Display(Name = "esi-ui.write_waypoint.v1")] writeWaypoint,
		 [Display(Name = "esi-characters.write_contacts.v1")] writeContacts,
		 [Display(Name = "esi-fittings.read_fittings.v1")] readFittings,
		 [Display(Name = "esi-fittings.write_fittings.v1")] writeFittings,
		 [Display(Name = "esi-markets.structure_markets.v1")] structureMarkets,
		 [Display(Name = "esi-corporations.read_structures.v1")] readCorporationStructures,
		 [Display(Name = "esi-corporations.write_structures.v1")] writeCorporationStructures,
		 [Display(Name = "esi-characters.read_loyalty.v1")] readLoyalty,
		 [Display(Name = "esi-characters.read_opportunities.v1")] readOpportunities,
		 [Display(Name = "esi-characters.read_chat_channels.v1")] readChatChannels,
		 [Display(Name = "esi-characters.read_medals.v1")] readMedals,
		 [Display(Name = "esi-characters.read_standings.v1")] readStanding,
		 [Display(Name = "esi-characters.read_agents_research.v1")] readAgentsResearch,
		 [Display(Name = "esi-industry.read_character_jobs.v1")] readCharacterJobs,
		 [Display(Name = "esi-markets.read_character_orders.v1")] readCharacterOrders,
		 [Display(Name = "esi-characters.read_blueprints.v1")] readBlueprints,
		 [Display(Name = "esi-characters.read_corporation_roles.v1")] readCorporationRoles,
		 [Display(Name = "esi-location.read_online.v1")] readOnline,
		 [Display(Name = "esi-contracts.read_character_contracts.v1")] readCharacterContracts,
		 [Display(Name = "esi-clones.read_implants.v1")] readImplants,
		 [Display(Name = "esi-characters.read_fatigue.v1")] readFatigue
	}
>>>>>>> 3997ceb8d65ddb7b21443f3e73c65bb7504b7ff3
}
