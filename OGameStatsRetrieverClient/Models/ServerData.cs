using System.Xml.Serialization;

namespace OGameStatsRetrieverClient.Models
{
    [XmlRoot(ElementName = "serverData")]
    public class ServerData
    {
        [XmlElement(ElementName = "acs")]
        public string Acs { get; set; }

        [XmlElement(ElementName = "bashlimit")]
        public string Bashlimit { get; set; }

        [XmlElement(ElementName = "bonusFields")]
        public string BonusFields { get; set; }

        [XmlElement(ElementName = "cargoHyperspaceTechMultiplier")]
        public string CargoHyperspaceTechMultiplier { get; set; }

        [XmlElement(ElementName = "characterClassesEnabled")]
        public string CharacterClassesEnabled { get; set; }

        [XmlElement(ElementName = "combatDebrisFieldLimit")]
        public string CombatDebrisFieldLimit { get; set; }

        [XmlElement(ElementName = "darkMatterNewAcount")]
        public string DarkMatterNewAcount { get; set; }

        [XmlElement(ElementName = "debrisFactor")]
        public string DebrisFactor { get; set; }

        [XmlElement(ElementName = "debrisFactorDef")]
        public string DebrisFactorDef { get; set; }

        [XmlElement(ElementName = "defToTF")]
        public string DefToTF { get; set; }

        [XmlElement(ElementName = "domain")]
        public string Domain { get; set; }

        [XmlElement(ElementName = "donutGalaxy")]
        public string DonutGalaxy { get; set; }

        [XmlElement(ElementName = "donutSystem")]
        public string DonutSystem { get; set; }

        [XmlElement(ElementName = "explorerBonusIncreasedExpeditionOutcome")]
        public string ExplorerBonusIncreasedExpeditionOutcome { get; set; }

        [XmlElement(ElementName = "explorerBonusIncreasedResearchSpeed")]
        public string ExplorerBonusIncreasedResearchSpeed { get; set; }

        [XmlElement(ElementName = "explorerBonusLargerPlanets")]
        public string ExplorerBonusLargerPlanets { get; set; }

        [XmlElement(ElementName = "explorerUnitItemsPerDay")]
        public string ExplorerUnitItemsPerDay { get; set; }

        [XmlElement(ElementName = "galaxies")]
        public string Galaxies { get; set; }

        [XmlElement(ElementName = "globalDeuteriumSaveFactor")]
        public string GlobalDeuteriumSaveFactor { get; set; }

        [XmlElement(ElementName = "language")]
        public string Language { get; set; }

        [XmlElement(ElementName = "marketplaceBasicTradeRatioCrystal")]
        public string MarketplaceBasicTradeRatioCrystal { get; set; }

        [XmlElement(ElementName = "marketplaceBasicTradeRatioDeuterium")]
        public string MarketplaceBasicTradeRatioDeuterium { get; set; }

        [XmlElement(ElementName = "marketplaceBasicTradeRatioMetal")]
        public string MarketplaceBasicTradeRatioMetal { get; set; }

        [XmlElement(ElementName = "marketplaceEnabled")]
        public string MarketplaceEnabled { get; set; }

        [XmlElement(ElementName = "marketplaceOfferTimeout")]
        public string MarketplaceOfferTimeout { get; set; }

        [XmlElement(ElementName = "marketplacePriceRangeLower")]
        public string MarketplacePriceRangeLower { get; set; }

        [XmlElement(ElementName = "marketplacePriceRangeUpper")]

        public string MarketplacePriceRangeUpper { get; set; }
        [XmlElement(ElementName = "marketplaceTaxAdmiral")]

        public string MarketplaceTaxAdmiral { get; set; }
        [XmlElement(ElementName = "marketplaceTaxCancelOffer")]

        public string MarketplaceTaxCancelOffer { get; set; }

        [XmlElement(ElementName = "marketplaceTaxNormalUser")]
        public string MarketplaceTaxNormalUser { get; set; }

        [XmlElement(ElementName = "marketplaceTaxNotSold")]
        public string MarketplaceTaxNotSold { get; set; }

        [XmlElement(ElementName = "minerBonusAdditionalFleetSlots")]
        public string MinerBonusAdditionalFleetSlots { get; set; }

        [XmlElement(ElementName = "minerBonusFasterTradingShips")]
        public string MinerBonusFasterTradingShips { get; set; }

        [XmlElement(ElementName = "minerBonusIncreasedCargoCapacityForTradingShips")]
        public string MinerBonusIncreasedCargoCapacityForTradingShips { get; set; }

        [XmlElement(ElementName = "minerBonusResourceProduction")]
        public string MinerBonusResourceProduction { get; set; }

        [XmlElement(ElementName = "name")]
        public string Name { get; set; }

        [XmlElement(ElementName = "newbieProtectionHigh")]
        public string NewbieProtectionHigh { get; set; }

        [XmlElement(ElementName = "newbieProtectionLimit")]
        public string NewbieProtectionLimit { get; set; }

        [XmlAttribute(AttributeName = "noNamespaceSchemaLocation", Namespace = "http://www.w3.org/2001/XMLSchema-instance")]
        public string NoNamespaceSchemaLocation { get; set; }

        [XmlElement(ElementName = "number")]
        public string Number { get; set; }

        [XmlElement(ElementName = "probeCargo")]
        public string ProbeCargo { get; set; }

        [XmlElement(ElementName = "rapidFire")]
        public string RapidFire { get; set; }

        [XmlElement(ElementName = "repairFactor")]
        public string RepairFactor { get; set; }

        [XmlElement(ElementName = "researchDurationDivisor")]
        public string ResearchDurationDivisor { get; set; }

        [XmlElement(ElementName = "resourceBuggyEnergyConsumptionPerUnit")]
        public string ResourceBuggyEnergyConsumptionPerUnit { get; set; }

        [XmlElement(ElementName = "resourceBuggyMaxProductionBoost")]
        public string ResourceBuggyMaxProductionBoost { get; set; }

        [XmlElement(ElementName = "resourceBuggyProductionBoost")]
        public string ResourceBuggyProductionBoost { get; set; }

        [XmlElement(ElementName = "resourceProductionIncreaseCrystalDefault")]
        public string ResourceProductionIncreaseCrystalDefault { get; set; }

        [XmlElement(ElementName = "resourceProductionIncreaseCrystalPos1")]
        public string ResourceProductionIncreaseCrystalPos1 { get; set; }

        [XmlElement(ElementName = "resourceProductionIncreaseCrystalPos2")]
        public string ResourceProductionIncreaseCrystalPos2 { get; set; }

        [XmlElement(ElementName = "resourceProductionIncreaseCrystalPos3")]
        public string ResourceProductionIncreaseCrystalPos3 { get; set; }

        [XmlAttribute(AttributeName = "serverId")]
        public string ServerId { get; set; }

        [XmlElement(ElementName = "speed")]
        public string Speed { get; set; }

        [XmlElement(ElementName = "speedFleet")]
        public string SpeedFleet { get; set; }

        [XmlElement(ElementName = "systems")]
        public string Systems { get; set; }

        [XmlAttribute(AttributeName = "timestamp")]
        public string Timestamp { get; set; }

        [XmlElement(ElementName = "timezone")]
        public string Timezone { get; set; }

        [XmlElement(ElementName = "timezoneOffset")]
        public string TimezoneOffset { get; set; }

        [XmlElement(ElementName = "topScore")]
        public string TopScore { get; set; }

        [XmlElement(ElementName = "version")]
        public string Version { get; set; }

        [XmlElement(ElementName = "warriorBonusFasterCombatShips")]
        public string WarriorBonusFasterCombatShips { get; set; }

        [XmlElement(ElementName = "warriorBonusFasterRecyclers")]
        public string WarriorBonusFasterRecyclers { get; set; }

        [XmlElement(ElementName = "warriorBonusRecyclerFuelConsumption")]
        public string WarriorBonusRecyclerFuelConsumption { get; set; }

        [XmlElement(ElementName = "wfBasicPercentageRepairable")]
        public string WfBasicPercentageRepairable { get; set; }

        [XmlElement(ElementName = "wfEnabled")]
        public string WfEnabled { get; set; }

        [XmlElement(ElementName = "wfMinimumLossPercentage")]
        public string WfMinimumLossPercentage { get; set; }

        [XmlElement(ElementName = "wfMinimumRessLost")]
        public string WfMinimumRessLost { get; set; }

        [XmlAttribute(AttributeName = "xsi", Namespace = "http://www.w3.org/2000/xmlns/")]
        public string Xsi { get; set; }
    }
}
