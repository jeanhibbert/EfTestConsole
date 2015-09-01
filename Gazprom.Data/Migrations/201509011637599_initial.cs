namespace Gazprom.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            //CreateTable(
            //    "dbo.AccountablePOS",
            //    c => new
            //        {
            //            AccountablePOSId = c.Int(nullable: false, identity: true),
            //            GasNetworkId = c.Int(nullable: false),
            //            EnergyVolume = c.Decimal(nullable: false, precision: 18, scale: 2),
            //            EnergyUnit = c.Int(nullable: false),
            //            PosDateTimeInCET = c.DateTime(nullable: false),
            //            DownloadTime = c.DateTime(nullable: false),
            //            PortfolioGasId = c.String(nullable: false, maxLength: 50),
            //        })
            //    .PrimaryKey(t => t.AccountablePOSId)
            //    .ForeignKey("dbo.GasNetwork", t => t.GasNetworkId, cascadeDelete: true)
            //    .ForeignKey("dbo.Unit", t => t.EnergyUnit, cascadeDelete: true)
            //    .Index(t => t.GasNetworkId)
            //    .Index(t => t.EnergyUnit);
            
            //CreateTable(
            //    "dbo.GasNetwork",
            //    c => new
            //        {
            //            GasNetworkId = c.Int(nullable: false, identity: true),
            //            Name = c.String(nullable: false, maxLength: 32),
            //            BalancingTypeId = c.Int(nullable: false),
            //            BalancingUnitId = c.Int(nullable: false),
            //            PositionNetting = c.Boolean(nullable: false),
            //            NetworkTypeId = c.Int(nullable: false),
            //            ParentNetworkId = c.Int(),
            //            ParentNominates = c.Boolean(),
            //            CodeSwitch = c.Boolean(nullable: false),
            //            EntryExitNetwork = c.Boolean(nullable: false),
            //            TransitNetwork = c.Boolean(nullable: false),
            //            IncludeFutures = c.Boolean(nullable: false),
            //            ProgramBalance = c.Boolean(nullable: false),
            //            PreventSiblingNomination = c.Boolean(nullable: false),
            //            PointX = c.Double(nullable: false),
            //            PointY = c.Double(nullable: false),
            //            IsNetworkLevelBalancing = c.Boolean(nullable: false),
            //            Hide = c.Boolean(nullable: false),
            //            CounterpartyMatches = c.Boolean(nullable: false),
            //            OneFilePerContractRef = c.Boolean(nullable: false),
            //            HourlyCapacityCheck = c.Boolean(nullable: false),
            //            ExcludeFromParentTotal = c.Boolean(nullable: false),
            //            EICCode = c.String(maxLength: 20),
            //            UseBasicNominationAggregation = c.Boolean(nullable: false),
            //        })
            //    .PrimaryKey(t => t.GasNetworkId)
            //    .ForeignKey("dbo.BalancingType", t => t.BalancingTypeId, cascadeDelete: true)
            //    .ForeignKey("dbo.GasNetwork", t => t.ParentNetworkId)
            //    .ForeignKey("dbo.NetworkType", t => t.NetworkTypeId, cascadeDelete: true)
            //    .ForeignKey("dbo.Unit", t => t.BalancingUnitId, cascadeDelete: true)
            //    .Index(t => t.BalancingTypeId)
            //    .Index(t => t.BalancingUnitId)
            //    .Index(t => t.NetworkTypeId)
            //    .Index(t => t.ParentNetworkId);
            
            //CreateTable(
            //    "dbo.BalancingType",
            //    c => new
            //        {
            //            BalancingTypeId = c.Int(nullable: false, identity: true),
            //            Name = c.String(nullable: false, maxLength: 100),
            //        })
            //    .PrimaryKey(t => t.BalancingTypeId);
            
            //CreateTable(
            //    "dbo.CapacityDayCheck",
            //    c => new
            //        {
            //            CapacityDayCheckId = c.Int(nullable: false, identity: true),
            //            GasNetworkId = c.Int(nullable: false),
            //            DayDescription = c.String(nullable: false, maxLength: 32),
            //            Offset = c.Int(nullable: false),
            //        })
            //    .PrimaryKey(t => t.CapacityDayCheckId)
            //    .ForeignKey("dbo.GasNetwork", t => t.GasNetworkId, cascadeDelete: true)
            //    .Index(t => t.GasNetworkId);
            
            //CreateTable(
            //    "dbo.ConfirmationAnomoly",
            //    c => new
            //        {
            //            ConfirmationAnomolyId = c.Int(nullable: false, identity: true),
            //            GasNetworkId = c.Int(nullable: false),
            //            GasLocationId = c.Int(nullable: false),
            //            Filename = c.String(maxLength: 1000),
            //            ReceivedDate = c.DateTime(nullable: false),
            //            DeliveryDate = c.DateTime(nullable: false),
            //            Status = c.Int(nullable: false),
            //            LocationCode = c.String(nullable: false, maxLength: 64),
            //            Counterparty = c.String(maxLength: 128),
            //            ShipperCode = c.String(nullable: false, maxLength: 64),
            //            InternalShipperCode = c.String(maxLength: 64),
            //            StartDateUtc = c.DateTime(nullable: false),
            //            EndDateUtc = c.DateTime(nullable: false),
            //            Volume = c.Decimal(nullable: false, precision: 18, scale: 2),
            //            UnitId = c.Int(nullable: false),
            //            UpdatedBy = c.String(nullable: false, maxLength: 64),
            //            UpdatedOn = c.DateTime(nullable: false),
            //            Nominated = c.Boolean(nullable: false),
            //        })
            //    .PrimaryKey(t => t.ConfirmationAnomolyId)
            //    .ForeignKey("dbo.GasLocation", t => t.GasLocationId, cascadeDelete: true)
            //    .ForeignKey("dbo.GasNetwork", t => t.GasNetworkId, cascadeDelete: true)
            //    .ForeignKey("dbo.Status", t => t.Status, cascadeDelete: true)
            //    .ForeignKey("dbo.Unit", t => t.UnitId, cascadeDelete: true)
            //    .Index(t => t.GasNetworkId)
            //    .Index(t => t.GasLocationId)
            //    .Index(t => t.Status)
            //    .Index(t => t.UnitId);
            
            //CreateTable(
            //    "dbo.GasLocation",
            //    c => new
            //        {
            //            GasLocationId = c.Int(nullable: false, identity: true),
            //            GasNetworkId = c.Int(nullable: false),
            //            Name = c.String(nullable: false, maxLength: 64),
            //            DisplayName = c.String(nullable: false, maxLength: 24),
            //            LocationTypeId = c.Int(nullable: false),
            //            GazpromTransitCode = c.String(maxLength: 50),
            //            LocationCode = c.String(maxLength: 50),
            //            IsNominated = c.Boolean(nullable: false),
            //            IsBalancing = c.Boolean(nullable: false),
            //            ZeroNominated = c.Boolean(nullable: false),
            //            PointX = c.Double(nullable: false),
            //            PointY = c.Double(nullable: false),
            //            GazpromReference = c.String(maxLength: 64),
            //            MatchingTolerance = c.Decimal(nullable: false, precision: 18, scale: 2),
            //            ByHour = c.Boolean(nullable: false),
            //            Hide = c.Boolean(nullable: false),
            //            GeminiNetworkId = c.String(nullable: false, maxLength: 4),
            //            IsLocationLevelBalancing = c.Boolean(nullable: false),
            //            ConfirmationBeforeNomination = c.Boolean(nullable: false),
            //            CapacityNetting = c.Boolean(nullable: false),
            //            DisplayPendingOnZeroPosition = c.Boolean(nullable: false),
            //            GeminiExitNetwork = c.String(nullable: false, maxLength: 50),
            //            DoNotNominateHistoric = c.Boolean(nullable: false),
            //            DailyMeteredShipper = c.Int(),
            //            NonDailyMeteredShipper = c.Int(),
            //            TimezoneName = c.String(nullable: false, maxLength: 50),
            //            CapacityTimezoneName = c.String(nullable: false, maxLength: 50),
            //            TimezoneCode = c.String(maxLength: 50),
            //            CapacityTimezoneCode = c.String(nullable: false, maxLength: 50),
            //        })
            //    .PrimaryKey(t => t.GasLocationId)
            //    .ForeignKey("dbo.GasNetwork", t => t.GasNetworkId, cascadeDelete: true)
            //    .ForeignKey("dbo.GasShipper", t => t.DailyMeteredShipper)
            //    .ForeignKey("dbo.GasShipper", t => t.NonDailyMeteredShipper)
            //    .ForeignKey("dbo.LocationType", t => t.LocationTypeId, cascadeDelete: true)
            //    .Index(t => t.GasNetworkId)
            //    .Index(t => t.LocationTypeId)
            //    .Index(t => t.DailyMeteredShipper)
            //    .Index(t => t.NonDailyMeteredShipper);
            
            //CreateTable(
            //    "dbo.CapacityRouteLegs",
            //    c => new
            //        {
            //            CapacityRouteLegId = c.Int(nullable: false, identity: true),
            //            RouteId = c.Int(nullable: false),
            //            LegNumber = c.Int(nullable: false),
            //            InstrumentTypeId = c.Int(nullable: false),
            //            GasLocationId = c.Int(nullable: false),
            //            GasPipelineId = c.Int(nullable: false),
            //        })
            //    .PrimaryKey(t => t.CapacityRouteLegId)
            //    .ForeignKey("dbo.CapacityTradeMultiLegRoute", t => t.RouteId, cascadeDelete: true)
            //    .ForeignKey("dbo.EndurInstrumentType", t => t.InstrumentTypeId, cascadeDelete: true)
            //    .ForeignKey("dbo.GasLocation", t => t.GasLocationId, cascadeDelete: true)
            //    .ForeignKey("dbo.GasPipeline", t => t.GasPipelineId, cascadeDelete: true)
            //    .Index(t => t.RouteId)
            //    .Index(t => t.InstrumentTypeId)
            //    .Index(t => t.GasLocationId)
            //    .Index(t => t.GasPipelineId);
            
            //CreateTable(
            //    "dbo.CapacityTradeMultiLegRoute",
            //    c => new
            //        {
            //            CapacityTradeMultiLegRouteId = c.Int(nullable: false, identity: true),
            //            Name = c.String(nullable: false, maxLength: 100),
            //            ParentEndurLineName = c.String(nullable: false, maxLength: 64),
            //            ParentEndurCapacityType = c.String(nullable: false, maxLength: 64),
            //        })
            //    .PrimaryKey(t => t.CapacityTradeMultiLegRouteId);
            
            //CreateTable(
            //    "dbo.EndurInstrumentType",
            //    c => new
            //        {
            //            EndurInstrumentTypeId = c.Int(nullable: false, identity: true),
            //            InstrumentName = c.String(nullable: false, maxLength: 32),
            //            CommodityType = c.Int(),
            //        })
            //    .PrimaryKey(t => t.EndurInstrumentTypeId)
            //    .ForeignKey("dbo.CommodityType", t => t.CommodityType)
            //    .Index(t => t.CommodityType);
            
            //CreateTable(
            //    "dbo.CommodityType",
            //    c => new
            //        {
            //            CommodityTypeId = c.Int(nullable: false, identity: true),
            //            CommodityName = c.String(nullable: false, maxLength: 32),
            //        })
            //    .PrimaryKey(t => t.CommodityTypeId);
            
            //CreateTable(
            //    "dbo.GasLocationInstrumentMapping",
            //    c => new
            //        {
            //            GasLocationInstrumentMappingId = c.Int(nullable: false, identity: true),
            //            GasLocationId = c.Int(nullable: false),
            //            EndurInstrumentTypeId = c.Int(nullable: false),
            //        })
            //    .PrimaryKey(t => t.GasLocationInstrumentMappingId)
            //    .ForeignKey("dbo.EndurInstrumentType", t => t.EndurInstrumentTypeId, cascadeDelete: true)
            //    .ForeignKey("dbo.GasLocation", t => t.GasLocationId, cascadeDelete: true)
            //    .Index(t => t.GasLocationId)
            //    .Index(t => t.EndurInstrumentTypeId);
            
            //CreateTable(
            //    "dbo.GasTradePositionEndurExclusion",
            //    c => new
            //        {
            //            GasTradePositionEndurExclusionId = c.Int(nullable: false, identity: true),
            //            EndurInstrumentTypeId = c.Int(nullable: false),
            //            EndurVolumeTypeId = c.Int(nullable: false),
            //        })
            //    .PrimaryKey(t => t.GasTradePositionEndurExclusionId)
            //    .ForeignKey("dbo.EndurInstrumentType", t => t.EndurInstrumentTypeId, cascadeDelete: true)
            //    .ForeignKey("dbo.EndurVolumeType", t => t.EndurVolumeTypeId, cascadeDelete: true)
            //    .Index(t => t.EndurInstrumentTypeId)
            //    .Index(t => t.EndurVolumeTypeId);
            
            //CreateTable(
            //    "dbo.EndurVolumeType",
            //    c => new
            //        {
            //            EndurVolumeTypeId = c.Int(nullable: false, identity: true),
            //            EndurVolumeTypeName = c.String(nullable: false, maxLength: 32),
            //        })
            //    .PrimaryKey(t => t.EndurVolumeTypeId);
            
            //CreateTable(
            //    "dbo.GasPipeline",
            //    c => new
            //        {
            //            GasPipelineId = c.Int(nullable: false, identity: true),
            //            Name = c.String(nullable: false, maxLength: 64),
            //            FromLocationId = c.Int(nullable: false),
            //            ToLocationId = c.Int(nullable: false),
            //            IsVirtual = c.Boolean(nullable: false),
            //            UpliftFactor = c.Decimal(nullable: false, precision: 18, scale: 2),
            //            FuelGas = c.Decimal(nullable: false, precision: 18, scale: 2),
            //            FromLocationExitLineName = c.String(maxLength: 100),
            //            ToLocationEntryLineName = c.String(maxLength: 100),
            //            CheckExit = c.Boolean(nullable: false),
            //            CheckEntry = c.Boolean(nullable: false),
            //            FromLocationShipperCode = c.String(maxLength: 32),
            //            ToLocationShipperCode = c.String(maxLength: 32),
            //            ApplyPipelineCapacity = c.Boolean(nullable: false),
            //            IsExternal = c.Boolean(nullable: false),
            //            RedeliveryTransitItem = c.Boolean(nullable: false),
            //            FromInternalShippingId = c.Int(),
            //            ToInternalShippingId = c.Int(),
            //            Hide = c.Boolean(),
            //        })
            //    .PrimaryKey(t => t.GasPipelineId)
            //    .ForeignKey("dbo.GasLocation", t => t.FromLocationId, cascadeDelete: true)
            //    .ForeignKey("dbo.GasLocation", t => t.ToLocationId, cascadeDelete: true)
            //    .ForeignKey("dbo.InternalShipping", t => t.FromInternalShippingId)
            //    .ForeignKey("dbo.InternalShipping", t => t.ToInternalShippingId)
            //    .Index(t => t.FromLocationId)
            //    .Index(t => t.ToLocationId)
            //    .Index(t => t.FromInternalShippingId)
            //    .Index(t => t.ToInternalShippingId);
            
            //CreateTable(
            //    "dbo.AutoFlow",
            //    c => new
            //        {
            //            AutoFlowId = c.Int(nullable: false, identity: true),
            //            GasPipelineId = c.Int(nullable: false),
            //            Disable = c.Boolean(nullable: false),
            //        })
            //    .PrimaryKey(t => t.AutoFlowId)
            //    .ForeignKey("dbo.GasPipeline", t => t.GasPipelineId, cascadeDelete: true)
            //    .Index(t => t.GasPipelineId);
            
            //CreateTable(
            //    "dbo.GasTransit",
            //    c => new
            //        {
            //            GasTransitId = c.Int(nullable: false, identity: true),
            //            GasPipelineId = c.Int(nullable: false),
            //            UnitId = c.Int(nullable: false),
            //            StartDateUTC = c.DateTime(nullable: false),
            //            EndDateUTC = c.DateTime(nullable: false),
            //            FromInternalShippingId = c.Int(),
            //            Volume = c.Decimal(nullable: false, precision: 18, scale: 2),
            //            UpdatedBy = c.String(nullable: false, maxLength: 64),
            //            UpdatedOn = c.DateTime(nullable: false),
            //            ToInternalShippingId = c.Int(),
            //            TransitRouteId = c.Int(),
            //            TransitRouteLegId = c.Int(),
            //        })
            //    .PrimaryKey(t => t.GasTransitId)
            //    .ForeignKey("dbo.GasPipeline", t => t.GasPipelineId, cascadeDelete: true)
            //    .ForeignKey("dbo.InternalShipping", t => t.FromInternalShippingId)
            //    .ForeignKey("dbo.InternalShipping", t => t.ToInternalShippingId)
            //    .ForeignKey("dbo.Unit", t => t.UnitId, cascadeDelete: true)
            //    .Index(t => t.GasPipelineId)
            //    .Index(t => t.UnitId)
            //    .Index(t => t.FromInternalShippingId)
            //    .Index(t => t.ToInternalShippingId);
            
            //CreateTable(
            //    "dbo.InternalShipping",
            //    c => new
            //        {
            //            InternalShippingId = c.Int(nullable: false, identity: true),
            //            GasLocationId = c.Int(nullable: false),
            //            GazpromTransitCode = c.String(nullable: false, maxLength: 50),
            //            InternalShippingCode = c.String(maxLength: 50),
            //            ContractReference = c.String(maxLength: 50),
            //            EndurContractRef = c.String(maxLength: 50),
            //            NadAccountId = c.Int(),
            //            EndurCapacityProductId = c.Int(),
            //            OverrideEnomAdjacentTransitCode = c.Boolean(nullable: false),
            //            OverrideEnomAdjacentLocation = c.String(maxLength: 50),
            //            LineContractReference = c.String(maxLength: 50),
            //        })
            //    .PrimaryKey(t => t.InternalShippingId)
            //    .ForeignKey("dbo.EndurCapacityProduct", t => t.EndurCapacityProductId)
            //    .ForeignKey("dbo.GasLocation", t => t.GasLocationId, cascadeDelete: true)
            //    .ForeignKey("dbo.NadAccount", t => t.NadAccountId)
            //    .Index(t => t.GasLocationId)
            //    .Index(t => t.NadAccountId)
            //    .Index(t => t.EndurCapacityProductId);
            
            //CreateTable(
            //    "dbo.EndurCapacityProduct",
            //    c => new
            //        {
            //            EndurCapacityProductId = c.Int(nullable: false, identity: true),
            //            Name = c.String(nullable: false, maxLength: 32),
            //        })
            //    .PrimaryKey(t => t.EndurCapacityProductId);
            
            //CreateTable(
            //    "dbo.GasNetworkDisplayCapacityProduct",
            //    c => new
            //        {
            //            GasNetworkDisplayCapacityProductId = c.Int(nullable: false, identity: true),
            //            GasNetworkId = c.Int(nullable: false),
            //            EndurCapacityProductId = c.Int(nullable: false),
            //            OverviewAbbreviation = c.String(nullable: false, maxLength: 32),
            //        })
            //    .PrimaryKey(t => t.GasNetworkDisplayCapacityProductId)
            //    .ForeignKey("dbo.EndurCapacityProduct", t => t.EndurCapacityProductId, cascadeDelete: true)
            //    .ForeignKey("dbo.GasNetwork", t => t.GasNetworkId, cascadeDelete: true)
            //    .Index(t => t.GasNetworkId)
            //    .Index(t => t.EndurCapacityProductId);
            
            //CreateTable(
            //    "dbo.GasTradePositionAdjust",
            //    c => new
            //        {
            //            GasTradePositionAdjustId = c.Int(nullable: false, identity: true),
            //            Counterparty = c.String(nullable: false, maxLength: 100),
            //            InternalShippingId = c.Int(),
            //            GasLocationId = c.Int(nullable: false),
            //            StartDateUTC = c.DateTime(nullable: false),
            //            EndDateUTC = c.DateTime(nullable: false),
            //            TradeDate = c.DateTime(nullable: false),
            //            UnitId = c.Int(nullable: false),
            //            Volume = c.Decimal(nullable: false, precision: 18, scale: 2),
            //            Cancel = c.Boolean(nullable: false),
            //            UpdatedBy = c.String(nullable: false, maxLength: 64),
            //            UpdatedOn = c.DateTime(nullable: false),
            //        })
            //    .PrimaryKey(t => t.GasTradePositionAdjustId)
            //    .ForeignKey("dbo.GasLocation", t => t.GasLocationId, cascadeDelete: true)
            //    .ForeignKey("dbo.InternalShipping", t => t.InternalShippingId)
            //    .ForeignKey("dbo.Unit", t => t.UnitId, cascadeDelete: true)
            //    .Index(t => t.InternalShippingId)
            //    .Index(t => t.GasLocationId)
            //    .Index(t => t.UnitId);
            
            //CreateTable(
            //    "dbo.GasTradeAdjustProfile",
            //    c => new
            //        {
            //            GasTradeAdjustProfileId = c.Int(nullable: false, identity: true),
            //            GasTradePositionAdjustId = c.Int(nullable: false),
            //            StartDateUTC = c.DateTime(nullable: false),
            //            EndDateUTC = c.DateTime(nullable: false),
            //            Volume = c.Decimal(nullable: false, precision: 18, scale: 2),
            //            UpdatedBy = c.String(nullable: false, maxLength: 64),
            //            UpdatedOn = c.DateTime(nullable: false),
            //        })
            //    .PrimaryKey(t => t.GasTradeAdjustProfileId)
            //    .ForeignKey("dbo.GasTradePositionAdjust", t => t.GasTradePositionAdjustId, cascadeDelete: true)
            //    .Index(t => t.GasTradePositionAdjustId);
            
            //CreateTable(
            //    "dbo.Unit",
            //    c => new
            //        {
            //            UnitId = c.Int(nullable: false, identity: true),
            //            Name = c.String(nullable: false, maxLength: 100),
            //            Code = c.String(nullable: false, maxLength: 32),
            //            IsRate = c.Boolean(nullable: false),
            //            RoundDecimalPlaces = c.Int(nullable: false),
            //            ApplyHourlyBalancing = c.Boolean(nullable: false),
            //            Deleted = c.Boolean(nullable: false),
            //        })
            //    .PrimaryKey(t => t.UnitId);
            
            //CreateTable(
            //    "dbo.AccountableSBS",
            //    c => new
            //        {
            //            AccountableSBSId = c.Int(nullable: false, identity: true),
            //            EnergyData = c.Decimal(nullable: false, precision: 18, scale: 2),
            //            EnergyUnit = c.Int(nullable: false),
            //            SBSDateTime = c.DateTime(nullable: false),
            //            SumHelpersEnergyAmount = c.Decimal(nullable: false, precision: 18, scale: 2),
            //            SumCausersEnergyAmount = c.Decimal(nullable: false, precision: 18, scale: 2),
            //        })
            //    .PrimaryKey(t => t.AccountableSBSId)
            //    .ForeignKey("dbo.Unit", t => t.EnergyUnit, cascadeDelete: true)
            //    .Index(t => t.EnergyUnit);
            
            //CreateTable(
            //    "dbo.SBSBufferZones",
            //    c => new
            //        {
            //            SBSBufferZonesId = c.Int(nullable: false, identity: true),
            //            ZoneName = c.String(nullable: false, maxLength: 50),
            //            ValidFrom = c.DateTime(nullable: false),
            //            ValidTo = c.DateTime(nullable: false),
            //            BorderMaxEnergyAmount = c.Decimal(nullable: false, precision: 18, scale: 2),
            //            BorderMinEnergyAmount = c.Decimal(nullable: false, precision: 18, scale: 2),
            //            AccountableSBSId = c.Int(nullable: false),
            //        })
            //    .PrimaryKey(t => t.SBSBufferZonesId)
            //    .ForeignKey("dbo.AccountableSBS", t => t.AccountableSBSId, cascadeDelete: true)
            //    .Index(t => t.AccountableSBSId);
            
            //CreateTable(
            //    "dbo.NearRealtimeAllocations",
            //    c => new
            //        {
            //            NearRealtimeAllocationsId = c.Int(nullable: false, identity: true),
            //            NetworkPointName = c.String(nullable: false, maxLength: 50),
            //            AllocationDateTime = c.DateTime(nullable: false),
            //            EnergyVolume = c.Decimal(nullable: false, precision: 18, scale: 2),
            //            EnergyUnit = c.Int(nullable: false),
            //            ConfirmedEnergyVolume = c.Decimal(nullable: false, precision: 18, scale: 2),
            //            ConfirmedEnergyUnit = c.Int(nullable: false),
            //            CalorificMeasure = c.Decimal(nullable: false, precision: 18, scale: 2),
            //            CalorificMeasureUnit = c.Int(nullable: false),
            //            DownloadDateTime = c.DateTime(nullable: false),
            //            GasLocation = c.String(maxLength: 50),
            //        })
            //    .PrimaryKey(t => t.NearRealtimeAllocationsId)
            //    .ForeignKey("dbo.Unit", t => t.CalorificMeasureUnit, cascadeDelete: true)
            //    .ForeignKey("dbo.Unit", t => t.ConfirmedEnergyUnit, cascadeDelete: true)
            //    .ForeignKey("dbo.Unit", t => t.EnergyUnit, cascadeDelete: true)
            //    .Index(t => t.EnergyUnit)
            //    .Index(t => t.ConfirmedEnergyUnit)
            //    .Index(t => t.CalorificMeasureUnit);
            
            //CreateTable(
            //    "dbo.Nomination",
            //    c => new
            //        {
            //            NominationId = c.Int(nullable: false, identity: true),
            //            GasNetworkId = c.Int(nullable: false),
            //            Version = c.Int(nullable: false),
            //            Filename = c.String(maxLength: 1000),
            //            SubmissionDateTime = c.DateTime(nullable: false),
            //            DeliveryDate = c.DateTime(nullable: false),
            //            Status = c.Int(nullable: false),
            //            AcknowledgementFile = c.String(maxLength: 1000),
            //            ConfirmationFile = c.String(maxLength: 1000),
            //            AnomalyFile = c.String(maxLength: 1000),
            //            Deleted = c.Boolean(nullable: false),
            //            UpdatedBy = c.String(nullable: false, maxLength: 500),
            //            UpdatedOn = c.DateTime(nullable: false),
            //            Unit = c.Int(nullable: false),
            //        })
            //    .PrimaryKey(t => t.NominationId)
            //    .ForeignKey("dbo.GasNetwork", t => t.GasNetworkId, cascadeDelete: true)
            //    .ForeignKey("dbo.Status", t => t.Status, cascadeDelete: true)
            //    .ForeignKey("dbo.Unit", t => t.Unit, cascadeDelete: true)
            //    .Index(t => t.GasNetworkId)
            //    .Index(t => t.Status)
            //    .Index(t => t.Unit);
            
            //CreateTable(
            //    "dbo.NominationShipper",
            //    c => new
            //        {
            //            NomiantionShipperId = c.Int(nullable: false, identity: true),
            //            CounterpartyName = c.String(maxLength: 200),
            //            ShipperId = c.Int(),
            //            ShipperCode = c.String(nullable: false, maxLength: 100),
            //            InternalShippingId = c.Int(),
            //            DeliveryDate = c.DateTime(nullable: false),
            //            Status = c.Int(nullable: false),
            //            GasLocationId = c.Int(nullable: false),
            //            LocationCode = c.String(nullable: false, maxLength: 100),
            //            NominationId = c.Int(nullable: false),
            //            version = c.Int(nullable: false),
            //            IsLatest = c.Boolean(nullable: false),
            //            IsBuy = c.Boolean(nullable: false),
            //            ConfirmCreatedDate = c.DateTime(),
            //            EffectiveHour = c.Int(),
            //        })
            //    .PrimaryKey(t => t.NomiantionShipperId)
            //    .ForeignKey("dbo.GasLocation", t => t.GasLocationId, cascadeDelete: true)
            //    .ForeignKey("dbo.Nomination", t => t.NominationId, cascadeDelete: true)
            //    .ForeignKey("dbo.Status", t => t.Status, cascadeDelete: true)
            //    .Index(t => t.Status)
            //    .Index(t => t.GasLocationId)
            //    .Index(t => t.NominationId);
            
            //CreateTable(
            //    "dbo.NominationVolumes",
            //    c => new
            //        {
            //            NominationVolumesId = c.Int(nullable: false, identity: true),
            //            NominationShipperId = c.Int(nullable: false),
            //            Hour = c.Int(nullable: false),
            //            StartTime = c.DateTime(nullable: false),
            //            EndTime = c.DateTime(nullable: false),
            //            VolumeNominated = c.Decimal(nullable: false, precision: 18, scale: 2),
            //            CounterpartyNominated = c.Decimal(nullable: false, precision: 18, scale: 2),
            //            AllocatedVolume = c.Decimal(precision: 18, scale: 2),
            //            IsExitFlow = c.Boolean(nullable: false),
            //            IsEntryFlow = c.Boolean(nullable: false),
            //            UpdatedBy = c.String(nullable: false, maxLength: 64),
            //            UpdatedOn = c.DateTime(nullable: false),
            //        })
            //    .PrimaryKey(t => t.NominationVolumesId)
            //    .ForeignKey("dbo.NominationShipper", t => t.NominationShipperId, cascadeDelete: true)
            //    .Index(t => t.NominationShipperId);
            
            //CreateTable(
            //    "dbo.Status",
            //    c => new
            //        {
            //            StatusId = c.Int(nullable: false, identity: true),
            //            Name = c.String(nullable: false, maxLength: 50),
            //            Description = c.String(maxLength: 500),
            //        })
            //    .PrimaryKey(t => t.StatusId);
            
            //CreateTable(
            //    "dbo.PositionCheck",
            //    c => new
            //        {
            //            PositionCheckId = c.Int(nullable: false, identity: true),
            //            GasNetworkId = c.Int(),
            //            GasLocationId = c.Int(),
            //            UnitId = c.Int(nullable: false),
            //            Abbreviation = c.String(),
            //            Rounding = c.Int(),
            //            TimezoneName = c.String(nullable: false, maxLength: 50),
            //            TimezoneCode = c.String(nullable: false, maxLength: 50),
            //        })
            //    .PrimaryKey(t => t.PositionCheckId)
            //    .ForeignKey("dbo.GasNetwork", t => t.GasNetworkId)
            //    .ForeignKey("dbo.Unit", t => t.UnitId, cascadeDelete: true)
            //    .Index(t => t.GasNetworkId)
            //    .Index(t => t.UnitId);
            
            //CreateTable(
            //    "dbo.NadAccount",
            //    c => new
            //        {
            //            NadAccountId = c.Int(nullable: false, identity: true),
            //            NominationsParametersId = c.Int(nullable: false),
            //            Name = c.String(nullable: false, maxLength: 32),
            //        })
            //    .PrimaryKey(t => t.NadAccountId)
            //    .ForeignKey("dbo.NominationParameters", t => t.NominationsParametersId, cascadeDelete: true)
            //    .Index(t => t.NominationsParametersId);
            
            //CreateTable(
            //    "dbo.NominationParameters",
            //    c => new
            //        {
            //            NominationsParametersId = c.Int(nullable: false, identity: true),
            //            GasNetworkId = c.Int(nullable: false),
            //            NominationSystemTypeId = c.Int(nullable: false),
            //            EnomXML = c.Boolean(),
            //            EnomEDI = c.Boolean(),
            //            EnomFrom = c.String(maxLength: 100),
            //            EnomFromNad = c.String(maxLength: 100),
            //            EnomTo = c.String(maxLength: 100),
            //            EnomToNad = c.String(maxLength: 100),
            //            EnomUnit = c.String(maxLength: 100),
            //            EnomContractRef = c.String(maxLength: 100),
            //            EnomGCVUnit = c.String(maxLength: 100),
            //            EnomGCV = c.Decimal(precision: 18, scale: 2),
            //            EnomUseQualifiedValues = c.Boolean(nullable: false),
            //            EnomAlwaysInputOutput = c.Boolean(nullable: false),
            //            IsHourlyNominated = c.Boolean(nullable: false),
            //            Enom1MessagePerPoint = c.Boolean(nullable: false),
            //            EnomVersion = c.Int(),
            //            EnomShrinkageFactor = c.Decimal(nullable: false, precision: 18, scale: 2),
            //            ZeroNominationsPoint = c.String(maxLength: 200),
            //            EnomIsHubNotice = c.Boolean(),
            //            IsStorageNotice = c.Boolean(),
            //            InternalShipperCode = c.String(maxLength: 100),
            //            EnomVersionType = c.String(maxLength: 8),
            //            RemoveEnomTags = c.Boolean(),
            //            EnomBDRMessage = c.Boolean(nullable: false),
            //            CapacityNomination = c.Boolean(nullable: false),
            //            UseEICCodeForConnectedNetwork = c.Boolean(nullable: false),
            //            ContractRefAndInternalShipperPair = c.Boolean(),
            //            EnomOverrideGasDayStartHour = c.Short(),
            //        })
            //    .PrimaryKey(t => t.NominationsParametersId)
            //    .ForeignKey("dbo.GasNetwork", t => t.GasNetworkId, cascadeDelete: true)
            //    .ForeignKey("dbo.NominationSystemType", t => t.NominationSystemTypeId, cascadeDelete: true)
            //    .Index(t => t.GasNetworkId)
            //    .Index(t => t.NominationSystemTypeId);
            
            //CreateTable(
            //    "dbo.NominationSystemType",
            //    c => new
            //        {
            //            NominationSystemTypeId = c.Int(nullable: false, identity: true),
            //            Name = c.String(nullable: false, maxLength: 50),
            //            Description = c.String(maxLength: 50),
            //        })
            //    .PrimaryKey(t => t.NominationSystemTypeId);
            
            //CreateTable(
            //    "dbo.SendInformation",
            //    c => new
            //        {
            //            SendInformationId = c.Int(nullable: false, identity: true),
            //            NominationsSystemTypeId = c.Int(),
            //            SendTypeId = c.Int(nullable: false),
            //            LiveFileShare = c.String(),
            //            GeminiRoot = c.String(),
            //            GeminiLogin = c.String(maxLength: 500),
            //            GeminiPassword = c.String(maxLength: 500),
            //            LiveEmailAddress = c.String(maxLength: 2500),
            //            FromEmailAddress = c.String(maxLength: 2500),
            //            LastPasswordResetUtc = c.DateTime(),
            //            CopyFileShare = c.String(),
            //            SendInformationName = c.String(nullable: false),
            //            GeminiServiceIdBuy = c.String(),
            //            GeminiServiceIdSell = c.String(),
            //        })
            //    .PrimaryKey(t => t.SendInformationId)
            //    .ForeignKey("dbo.NominationSystemType", t => t.NominationsSystemTypeId)
            //    .ForeignKey("dbo.SendType", t => t.SendTypeId, cascadeDelete: true)
            //    .Index(t => t.NominationsSystemTypeId)
            //    .Index(t => t.SendTypeId);
            
            //CreateTable(
            //    "dbo.SendType",
            //    c => new
            //        {
            //            SendTypeId = c.Int(nullable: false, identity: true),
            //            Name = c.String(nullable: false, maxLength: 50),
            //        })
            //    .PrimaryKey(t => t.SendTypeId);
            
            //CreateTable(
            //    "dbo.ShipperPreliminaryBalance",
            //    c => new
            //        {
            //            ShipperPreliminaryBalanceId = c.Int(nullable: false, identity: true),
            //            DeliveryDay = c.DateTime(nullable: false),
            //            SumRequestedDailyMetered = c.Decimal(nullable: false, precision: 18, scale: 2),
            //            SumRequestedNonDailyMetered = c.Decimal(nullable: false, precision: 18, scale: 2),
            //            UpdatedOn = c.DateTime(nullable: false),
            //            NominationsSystemTypeId = c.Int(nullable: false),
            //        })
            //    .PrimaryKey(t => t.ShipperPreliminaryBalanceId)
            //    .ForeignKey("dbo.NominationSystemType", t => t.NominationsSystemTypeId, cascadeDelete: true)
            //    .Index(t => t.NominationsSystemTypeId);
            
            //CreateTable(
            //    "dbo.TransitRouteLeg",
            //    c => new
            //        {
            //            TransitRouteLegId = c.Int(nullable: false, identity: true),
            //            TransitRouteId = c.Int(nullable: false),
            //            LegNumber = c.Int(nullable: false),
            //            FromShipperId = c.Int(),
            //            ToShipperId = c.Int(),
            //            FromCapacityInstrumentType = c.String(maxLength: 64),
            //            ToCapacityInstrumentType = c.String(maxLength: 64),
            //            FromLineName = c.String(maxLength: 64),
            //            ToLineName = c.String(maxLength: 64),
            //            PipelineId = c.Int(),
            //        })
            //    .PrimaryKey(t => t.TransitRouteLegId)
            //    .ForeignKey("dbo.GasPipeline", t => t.PipelineId)
            //    .ForeignKey("dbo.InternalShipping", t => t.FromShipperId)
            //    .ForeignKey("dbo.InternalShipping", t => t.ToShipperId)
            //    .ForeignKey("dbo.TransitRoute", t => t.TransitRouteId, cascadeDelete: true)
            //    .Index(t => t.TransitRouteId)
            //    .Index(t => t.FromShipperId)
            //    .Index(t => t.ToShipperId)
            //    .Index(t => t.PipelineId);
            
            //CreateTable(
            //    "dbo.TransitRoute",
            //    c => new
            //        {
            //            TransitRouteId = c.Int(nullable: false, identity: true),
            //            Name = c.String(nullable: false, maxLength: 64),
            //            IsDisabled = c.Boolean(nullable: false),
            //            EditedOn = c.DateTime(nullable: false),
            //            EditedBy = c.String(maxLength: 100),
            //        })
            //    .PrimaryKey(t => t.TransitRouteId);
            
            //CreateTable(
            //    "dbo.ExternalCapacityLocationMapping",
            //    c => new
            //        {
            //            ExternalCapacityLocationMappingId = c.Int(nullable: false, identity: true),
            //            ParentLocationId = c.Int(nullable: false),
            //            LocationName = c.String(nullable: false, maxLength: 100),
            //            EndurContractRef = c.String(maxLength: 50),
            //            ExitCode = c.String(maxLength: 50),
            //            EntryCode = c.String(maxLength: 50),
            //            PipelineName = c.String(maxLength: 100),
            //            QueryGeminiForExitCapacity = c.Boolean(nullable: false),
            //            ExternalSource = c.String(nullable: false, maxLength: 25),
            //            EditedOn = c.DateTime(nullable: false),
            //            EditedBy = c.String(maxLength: 100),
            //        })
            //    .PrimaryKey(t => t.ExternalCapacityLocationMappingId)
            //    .ForeignKey("dbo.GasLocation", t => t.ParentLocationId, cascadeDelete: true)
            //    .Index(t => t.ParentLocationId);
            
            //CreateTable(
            //    "dbo.FlowLineNameMapping",
            //    c => new
            //        {
            //            FlowLineNameMappingId = c.Int(nullable: false, identity: true),
            //            GasLocationId = c.Int(nullable: false),
            //            ShipperCode = c.String(nullable: false, maxLength: 50),
            //            LineName = c.String(nullable: false, maxLength: 100),
            //            IsEntry = c.Boolean(nullable: false),
            //            PublishToEndur = c.Boolean(nullable: false),
            //            InternalShippingCode = c.String(maxLength: 50),
            //            CreateTransitPair = c.Boolean(nullable: false),
            //        })
            //    .PrimaryKey(t => t.FlowLineNameMappingId)
            //    .ForeignKey("dbo.GasLocation", t => t.GasLocationId, cascadeDelete: true)
            //    .Index(t => t.GasLocationId);
            
            //CreateTable(
            //    "dbo.GasLocationGCV",
            //    c => new
            //        {
            //            GasLocationGCVId = c.Int(nullable: false, identity: true),
            //            ValidFrom = c.DateTime(nullable: false),
            //            GasLocationId = c.Int(nullable: false),
            //            ValidTo = c.DateTime(nullable: false),
            //            CalorificValue = c.Decimal(nullable: false, precision: 18, scale: 2),
            //        })
            //    .PrimaryKey(t => new { t.GasLocationGCVId, t.ValidFrom })
            //    .ForeignKey("dbo.GasLocation", t => t.GasLocationId, cascadeDelete: true)
            //    .Index(t => t.GasLocationId);
            
            //CreateTable(
            //    "dbo.GasLocationMapping",
            //    c => new
            //        {
            //            GasLocationMappingId = c.Int(nullable: false, identity: true),
            //            GasLocationId = c.Int(nullable: false),
            //            Name = c.String(nullable: false, maxLength: 64),
            //        })
            //    .PrimaryKey(t => t.GasLocationMappingId)
            //    .ForeignKey("dbo.GasLocation", t => t.GasLocationId, cascadeDelete: true)
            //    .Index(t => t.GasLocationId);
            
            //CreateTable(
            //    "dbo.GasShipper",
            //    c => new
            //        {
            //            GasShipperId = c.Int(nullable: false, identity: true),
            //            GasLocationId = c.Int(nullable: false),
            //            Counterparty = c.String(nullable: false, maxLength: 100),
            //            ShipperCode = c.String(nullable: false, maxLength: 50),
            //            Notify = c.Boolean(nullable: false),
            //            IncludeInPosition = c.Boolean(nullable: false),
            //            ValidFrom = c.DateTime(nullable: false),
            //            ValidTo = c.DateTime(nullable: false),
            //            Deleted = c.Boolean(nullable: false),
            //            DuplicateTrades = c.Int(),
            //            InvertDuplicateTrades = c.Boolean(nullable: false),
            //        })
            //    .PrimaryKey(t => t.GasShipperId)
            //    .ForeignKey("dbo.GasLocation", t => t.GasLocationId, cascadeDelete: true)
            //    .ForeignKey("dbo.GasShipper", t => t.DuplicateTrades)
            //    .Index(t => t.GasLocationId)
            //    .Index(t => t.DuplicateTrades);
            
            //CreateTable(
            //    "dbo.GxpMappings",
            //    c => new
            //        {
            //            GxpMappingsId = c.Int(nullable: false, identity: true),
            //            GasLocationId = c.Int(nullable: false),
            //            OurLocationCode = c.String(nullable: false, maxLength: 200),
            //            GxpLocationCode = c.String(nullable: false, maxLength: 200),
            //            OurShipperCode = c.String(nullable: false, maxLength: 200),
            //            GxpShipperCode = c.String(nullable: false, maxLength: 200),
            //            OurInternalShippingCode = c.String(nullable: false, maxLength: 200),
            //            GxpInternalShippingCode = c.String(nullable: false, maxLength: 200),
            //        })
            //    .PrimaryKey(t => t.GxpMappingsId)
            //    .ForeignKey("dbo.GasLocation", t => t.GasLocationId, cascadeDelete: true)
            //    .Index(t => t.GasLocationId);
            
            //CreateTable(
            //    "dbo.LocationType",
            //    c => new
            //        {
            //            LocationTypeId = c.Int(nullable: false, identity: true),
            //            Name = c.String(nullable: false, maxLength: 100),
            //        })
            //    .PrimaryKey(t => t.LocationTypeId);
            
            //CreateTable(
            //    "dbo.NetworkType",
            //    c => new
            //        {
            //            NetworkTypeId = c.Int(nullable: false, identity: true),
            //            Name = c.String(nullable: false, maxLength: 100),
            //        })
            //    .PrimaryKey(t => t.NetworkTypeId);
            
            //CreateTable(
            //    "dbo.CapacityInstrumentType",
            //    c => new
            //        {
            //            CapacityInstrumentTypeId = c.Int(nullable: false, identity: true),
            //            Name = c.String(nullable: false, maxLength: 50),
            //        })
            //    .PrimaryKey(t => t.CapacityInstrumentTypeId);
            
            //CreateTable(
            //    "caprpt.CapacityTradeView",
            //    c => new
            //        {
            //            CapacityProduct = c.String(nullable: false, maxLength: 64),
            //            StartDateUTC = c.DateTime(nullable: false),
            //            EndDateUTC = c.DateTime(nullable: false),
            //            Volume = c.Decimal(nullable: false, precision: 18, scale: 2),
            //            Unit = c.String(nullable: false, maxLength: 100),
            //            Counterparty = c.String(nullable: false, maxLength: 100),
            //            BuySell = c.String(nullable: false, maxLength: 4),
            //            TradeId = c.String(maxLength: 20),
            //            ContractReference = c.String(maxLength: 100),
            //            LineName = c.String(maxLength: 64),
            //            CapacityInstrumentType = c.String(maxLength: 64),
            //        })
            //    .PrimaryKey(t => new { t.CapacityProduct, t.StartDateUTC, t.EndDateUTC, t.Volume, t.Unit, t.Counterparty, t.BuySell });
            
            //CreateTable(
            //    "dbo.EnomMessageField",
            //    c => new
            //        {
            //            Id = c.Int(nullable: false, identity: true),
            //            Name = c.String(nullable: false, maxLength: 50),
            //            FieldNameValue = c.String(nullable: false, maxLength: 50),
            //        })
            //    .PrimaryKey(t => t.Id);
            
            //CreateTable(
            //    "dbo.Entitlements",
            //    c => new
            //        {
            //            CapacityDay = c.DateTime(nullable: false),
            //            Location = c.String(nullable: false, maxLength: 250),
            //            IsEntry = c.Boolean(nullable: false),
            //            NetCapacity = c.Int(),
            //            NetFirmCapacity = c.Int(),
            //            NetInterruptibleCapacity = c.Int(),
            //            NetScaledInterruptibleCapacity = c.Int(),
            //            RecordNumber = c.Int(nullable: false),
            //            UpdatedOn = c.DateTime(),
            //        })
            //    .PrimaryKey(t => new { t.CapacityDay, t.Location, t.IsEntry });
            
            //CreateTable(
            //    "dbo.ExternalCapacityLocationMappingAudit",
            //    c => new
            //        {
            //            ExternalCapacityLocationMappingId = c.Int(nullable: false),
            //            ParentLocationId = c.Int(nullable: false),
            //            LocationName = c.String(nullable: false, maxLength: 100),
            //            QueryGeminiForExitCapacity = c.Boolean(nullable: false),
            //            ExternalSource = c.String(nullable: false, maxLength: 25),
            //            EditedOn = c.DateTime(nullable: false),
            //            AuditDate = c.DateTime(nullable: false),
            //            EndurContractRef = c.String(maxLength: 50),
            //            ExitCode = c.String(maxLength: 50),
            //            EntryCode = c.String(maxLength: 50),
            //            PipelineName = c.String(maxLength: 100),
            //            EditedBy = c.String(maxLength: 100),
            //        })
            //    .PrimaryKey(t => new { t.ExternalCapacityLocationMappingId, t.ParentLocationId, t.LocationName, t.QueryGeminiForExitCapacity, t.ExternalSource, t.EditedOn, t.AuditDate });
            
            //CreateTable(
            //    "caprpt.GasLocationGCVView",
            //    c => new
            //        {
            //            GasLocationGCVId = c.Int(nullable: false, identity: true),
            //            GasLocationId = c.Int(nullable: false),
            //            ValidFrom = c.DateTime(nullable: false),
            //            ValidTo = c.DateTime(nullable: false),
            //            CalorificValue = c.Decimal(nullable: false, precision: 18, scale: 2),
            //        })
            //    .PrimaryKey(t => new { t.GasLocationGCVId, t.GasLocationId, t.ValidFrom, t.ValidTo, t.CalorificValue });
            
            //CreateTable(
            //    "dbo.GasTradeDetailEndur",
            //    c => new
            //        {
            //            TradeId = c.Int(nullable: false),
            //            Location = c.String(nullable: false, maxLength: 100),
            //            InstrumentType = c.String(nullable: false, maxLength: 64),
            //            TranNum = c.Int(nullable: false),
            //            InstrumentNum = c.Int(nullable: false),
            //            VersionNumber = c.Int(nullable: false),
            //            TranStatus = c.String(nullable: false, maxLength: 32),
            //            Trader = c.String(nullable: false, maxLength: 32),
            //            TradeDate = c.DateTime(nullable: false),
            //            Counterparty = c.String(nullable: false, maxLength: 100),
            //            BuySell = c.String(nullable: false, maxLength: 4),
            //            StartDateUTC = c.DateTime(nullable: false),
            //            EndDateUTC = c.DateTime(nullable: false),
            //            Volume = c.Decimal(nullable: false, precision: 18, scale: 2),
            //            Unit = c.String(nullable: false, maxLength: 100),
            //            VolumeType = c.String(nullable: false, maxLength: 32),
            //            Price = c.Decimal(nullable: false, precision: 18, scale: 2),
            //            Spread = c.Decimal(nullable: false, precision: 18, scale: 2),
            //            Currency = c.String(nullable: false, maxLength: 16),
            //            DenominationPriceUnitName = c.String(nullable: false, maxLength: 16),
            //            PriceType = c.String(nullable: false, maxLength: 16),
            //            ServiceType = c.String(maxLength: 64),
            //            LineName = c.String(maxLength: 64),
            //            WthInj = c.String(maxLength: 1),
            //            UpdatedByEngine = c.String(nullable: false, maxLength: 64),
            //            UpdatedBy = c.String(nullable: false, maxLength: 64),
            //            UpdatedOn = c.DateTime(nullable: false),
            //            ContractRef = c.String(maxLength: 100),
            //        })
            //    .PrimaryKey(t => new { t.TradeId, t.Location });
            
            //CreateTable(
            //    "dbo.GasTradePositionEndur",
            //    c => new
            //        {
            //            TradeId = c.Int(nullable: false),
            //            Location = c.String(nullable: false, maxLength: 100),
            //            BuySell = c.String(nullable: false, maxLength: 4),
            //            StartDateUTC = c.DateTime(nullable: false),
            //            InstrumentType = c.String(nullable: false, maxLength: 64),
            //            TranNum = c.Int(nullable: false),
            //            InstrumentNum = c.Int(nullable: false),
            //            VersionNumber = c.Int(nullable: false),
            //            TranStatus = c.String(nullable: false, maxLength: 32),
            //            Trader = c.String(nullable: false, maxLength: 32),
            //            TradeDate = c.DateTime(nullable: false),
            //            Counterparty = c.String(nullable: false, maxLength: 100),
            //            EndDateUTC = c.DateTime(nullable: false),
            //            Volume = c.Decimal(nullable: false, precision: 18, scale: 2),
            //            Unit = c.String(nullable: false, maxLength: 100),
            //            VolumeType = c.String(nullable: false, maxLength: 32),
            //            Price = c.Decimal(nullable: false, precision: 18, scale: 2),
            //            Spread = c.Decimal(nullable: false, precision: 18, scale: 2),
            //            Currency = c.String(nullable: false, maxLength: 16),
            //            DenominationPriceUnitName = c.String(nullable: false, maxLength: 16),
            //            PriceType = c.String(nullable: false, maxLength: 16),
            //            ServiceType = c.String(maxLength: 64),
            //            LineName = c.String(maxLength: 64),
            //            WthInj = c.String(maxLength: 1),
            //            UpdatedByEngine = c.String(nullable: false, maxLength: 64),
            //            UpdatedBy = c.String(nullable: false, maxLength: 64),
            //            UpdatedOn = c.DateTime(nullable: false),
            //            ContractRef = c.String(maxLength: 100),
            //        })
            //    .PrimaryKey(t => new { t.TradeId, t.Location, t.BuySell, t.StartDateUTC });
            
            //CreateTable(
            //    "caprpt.GasTransitView",
            //    c => new
            //        {
            //            GasTransitId = c.Int(nullable: false),
            //            StartDateUtc = c.DateTime(nullable: false),
            //            EndDateUtc = c.DateTime(nullable: false),
            //            Volume = c.Decimal(nullable: false, precision: 18, scale: 2),
            //            CheckExit = c.Boolean(nullable: false),
            //            GasPipelineId = c.Int(nullable: false),
            //            GasPipelineName = c.String(nullable: false, maxLength: 64),
            //            GasLocationIdFrom = c.Int(nullable: false),
            //            CheckEntry = c.Boolean(nullable: false),
            //            GasLocationIdTo = c.Int(nullable: false),
            //            FromInternalShippingId = c.Int(nullable: false),
            //            ToInternalShippingId = c.Int(nullable: false),
            //            ContractReferenceFrom = c.String(maxLength: 50),
            //            ContractReferenceTo = c.String(maxLength: 50),
            //            CapacityInstrumentTypeTo = c.String(maxLength: 32),
            //            CapacityInstrumentTypeFrom = c.String(maxLength: 32),
            //            TransitRouteId = c.Int(),
            //            TransitRouteLegId = c.Int(),
            //            TransitRouteLegFromLineName = c.String(maxLength: 64),
            //            TransitRouteLegToLineName = c.String(maxLength: 64),
            //            TransitRouteLegFromCapacityInstrumentType = c.String(maxLength: 64),
            //            TransitRouteLegToCapacityInstrumentType = c.String(maxLength: 64),
            //        })
            //    .PrimaryKey(t => new { t.GasTransitId, t.StartDateUtc, t.EndDateUtc, t.Volume, t.CheckExit, t.GasPipelineId, t.GasPipelineName, t.GasLocationIdFrom, t.CheckEntry, t.GasLocationIdTo, t.FromInternalShippingId, t.ToInternalShippingId });
            
            //CreateTable(
            //    "caprpt.GeminiCapacityTradeView",
            //    c => new
            //        {
            //            CapacityDay = c.DateTime(nullable: false),
            //            IsEntry = c.Boolean(nullable: false),
            //            GasLocationId = c.Int(nullable: false),
            //            ExternalSource = c.String(nullable: false, maxLength: 25),
            //            UpdatedOn = c.DateTime(),
            //            NetFirmCapacity = c.Decimal(precision: 18, scale: 2),
            //            NetInterruptibleCapacity = c.Decimal(precision: 18, scale: 2),
            //            ContractReference = c.String(maxLength: 50),
            //            PipelineName = c.String(maxLength: 100),
            //        })
            //    .PrimaryKey(t => new { t.CapacityDay, t.IsEntry, t.GasLocationId, t.ExternalSource });
            
            //CreateTable(
            //    "caprpt.GeminiDataUpdatedView",
            //    c => new
            //        {
            //            CapacityDay = c.DateTime(nullable: false),
            //            IsEntry = c.Boolean(nullable: false),
            //            UpdatedOn = c.DateTime(),
            //        })
            //    .PrimaryKey(t => new { t.CapacityDay, t.IsEntry });
            
            //CreateTable(
            //    "dbo.GTSDataSendInformation",
            //    c => new
            //        {
            //            GTSDataSendInformationId = c.Int(nullable: false, identity: true),
            //            POSEmailers = c.String(),
            //            SBAEmailers = c.String(),
            //            POSEmailSent = c.DateTime(nullable: false),
            //            SBSEmailSent = c.DateTime(nullable: false),
            //        })
            //    .PrimaryKey(t => t.GTSDataSendInformationId);
            
            //CreateTable(
            //    "caprpt.ISISCapacityTradeView",
            //    c => new
            //        {
            //            CapacityDay = c.DateTime(nullable: false),
            //            IsEntry = c.Boolean(nullable: false),
            //            GasLocationId = c.Int(nullable: false),
            //            ExternalSource = c.String(nullable: false, maxLength: 25),
            //            UpdatedOn = c.DateTime(),
            //            NetFirmCapacity = c.Decimal(precision: 18, scale: 2),
            //            NetInterruptibleCapacity = c.Decimal(precision: 18, scale: 2),
            //            ContractReference = c.String(maxLength: 50),
            //            PipelineName = c.String(maxLength: 100),
            //        })
            //    .PrimaryKey(t => new { t.CapacityDay, t.IsEntry, t.GasLocationId, t.ExternalSource });
            
            //CreateTable(
            //    "dbo.KeyPerformanceIndicators",
            //    c => new
            //        {
            //            KPI_ID = c.Int(nullable: false, identity: true),
            //            KeyPerformanceIndicator = c.String(nullable: false, maxLength: 250),
            //            StartTime = c.DateTime(nullable: false),
            //            EndTime = c.DateTime(nullable: false),
            //            User = c.String(nullable: false, maxLength: 250),
            //            Machine = c.String(nullable: false, maxLength: 250),
            //            ElapsedMilliseconds = c.Int(nullable: false),
            //            ElapsedTicks = c.Int(nullable: false),
            //        })
            //    .PrimaryKey(t => t.KPI_ID);
            
            //CreateTable(
            //    "caprpt.LocationMappingView",
            //    c => new
            //        {
            //            GasLocationId = c.Int(nullable: false),
            //            EndurLocationName = c.String(nullable: false, maxLength: 64),
            //            EndurInstrumentName = c.String(nullable: false, maxLength: 32),
            //        })
            //    .PrimaryKey(t => new { t.GasLocationId, t.EndurLocationName, t.EndurInstrumentName });
            
            //CreateTable(
            //    "caprpt.LocationView",
            //    c => new
            //        {
            //            GasLocationId = c.Int(nullable: false, identity: true),
            //            DisplayName = c.String(nullable: false, maxLength: 24),
            //            TimezoneName = c.String(nullable: false, maxLength: 50),
            //            CapacityNetting = c.Boolean(nullable: false),
            //            GasNetworkId = c.Int(nullable: false),
            //            CapacityTimeZoneCode = c.String(nullable: false, maxLength: 50),
            //            CapacityTimeZoneName = c.String(nullable: false, maxLength: 50),
            //            IsNominated = c.Boolean(nullable: false),
            //            LocationTypeId = c.Int(nullable: false),
            //            TimeZoneCode = c.String(maxLength: 50),
            //            GazpromTransitCode = c.String(maxLength: 50),
            //        })
            //    .PrimaryKey(t => new { t.GasLocationId, t.DisplayName, t.TimezoneName, t.CapacityNetting, t.GasNetworkId, t.CapacityTimeZoneCode, t.CapacityTimeZoneName, t.IsNominated, t.LocationTypeId });
            
            //CreateTable(
            //    "caprpt.MultiLegCapacityTradeMapping",
            //    c => new
            //        {
            //            MultiLegCapacityTradeMappingId = c.Int(nullable: false),
            //            ParentEndurLineName = c.String(nullable: false, maxLength: 64),
            //            ParentEndurCapacityType = c.String(nullable: false, maxLength: 64),
            //            LegNumber = c.Int(nullable: false),
            //            GasLocationId = c.Int(nullable: false),
            //            InstrumentTypeId = c.Int(nullable: false),
            //            GasPipelineId = c.Int(nullable: false),
            //            GasLocationDisplayName = c.String(nullable: false, maxLength: 24),
            //            CapacityProduct = c.String(nullable: false, maxLength: 32),
            //            LineName = c.String(maxLength: 100),
            //        })
            //    .PrimaryKey(t => new { t.MultiLegCapacityTradeMappingId, t.ParentEndurLineName, t.ParentEndurCapacityType, t.LegNumber, t.GasLocationId, t.InstrumentTypeId, t.GasPipelineId, t.GasLocationDisplayName, t.CapacityProduct });
            
            //CreateTable(
            //    "caprpt.NetworkView",
            //    c => new
            //        {
            //            GasNetworkId = c.Int(nullable: false),
            //            Name = c.String(nullable: false, maxLength: 32),
            //            HourlyCapacityCheck = c.Boolean(nullable: false),
            //            BalancingTypeId = c.Int(nullable: false),
            //            BalancingTypeName = c.String(nullable: false, maxLength: 100),
            //            PreventSiblingNomination = c.Boolean(nullable: false),
            //            PositionNetting = c.Boolean(nullable: false),
            //            CodeSwitch = c.Boolean(nullable: false),
            //            ParentNetworkId = c.Int(),
            //        })
            //    .PrimaryKey(t => new { t.GasNetworkId, t.Name, t.HourlyCapacityCheck, t.BalancingTypeId, t.BalancingTypeName, t.PreventSiblingNomination, t.PositionNetting, t.CodeSwitch });
            
            //CreateTable(
            //    "dbo.Nomination_Archive",
            //    c => new
            //        {
            //            NominationId = c.Int(nullable: false),
            //            GasNetworkId = c.Int(nullable: false),
            //            Version = c.Int(nullable: false),
            //            Filename = c.String(maxLength: 1000),
            //            SubmissionDateTime = c.DateTime(nullable: false),
            //            DeliveryDate = c.DateTime(nullable: false),
            //            Status = c.Int(nullable: false),
            //            AcknowledgementFile = c.String(maxLength: 1000),
            //            ConfirmationFile = c.String(maxLength: 1000),
            //            AnomalyFile = c.String(maxLength: 1000),
            //            Deleted = c.Boolean(nullable: false),
            //            UpdatedBy = c.String(nullable: false, maxLength: 500),
            //            UpdatedOn = c.DateTime(nullable: false),
            //            Unit = c.Int(nullable: false),
            //        })
            //    .PrimaryKey(t => t.NominationId);
            
            //CreateTable(
            //    "caprpt.NominationMessagesView",
            //    c => new
            //        {
            //            NominationId = c.Int(nullable: false),
            //            NomiantionShipperId = c.Int(nullable: false),
            //            GasNetworkId = c.Int(nullable: false),
            //            LocationCode = c.String(nullable: false, maxLength: 100),
            //            ShipperCode = c.String(nullable: false, maxLength: 100),
            //            EnomToNad = c.String(maxLength: 100),
            //            EnomContractRef = c.String(maxLength: 100),
            //        })
            //    .PrimaryKey(t => new { t.NominationId, t.NomiantionShipperId, t.GasNetworkId, t.LocationCode, t.ShipperCode });
            
            //CreateTable(
            //    "dbo.NominationShipper_Archive",
            //    c => new
            //        {
            //            NomiantionShipperId = c.Int(nullable: false),
            //            CounterpartyName = c.String(maxLength: 200),
            //            ShipperId = c.Int(),
            //            ShipperCode = c.String(nullable: false, maxLength: 100),
            //            InternalShippingId = c.Int(),
            //            DeliveryDate = c.DateTime(nullable: false),
            //            Status = c.Int(nullable: false),
            //            GasLocationId = c.Int(nullable: false),
            //            LocationCode = c.String(nullable: false, maxLength: 100),
            //            NominationId = c.Int(nullable: false),
            //            version = c.Int(nullable: false),
            //            IsLatest = c.Boolean(nullable: false),
            //            IsBuy = c.Boolean(nullable: false),
            //            ConfirmCreatedDate = c.DateTime(),
            //            EffectiveHour = c.Int(),
            //        })
            //    .PrimaryKey(t => t.NomiantionShipperId);
            
            //CreateTable(
            //    "dbo.NominationValidation",
            //    c => new
            //        {
            //            NominationValidationId = c.Int(nullable: false, identity: true),
            //            ContractRef = c.String(nullable: false, maxLength: 100),
            //            ValidationTypeId = c.Int(nullable: false),
            //        })
            //    .PrimaryKey(t => t.NominationValidationId)
            //    .ForeignKey("dbo.ValidationType", t => t.ValidationTypeId, cascadeDelete: true)
            //    .Index(t => t.ValidationTypeId);
            
            //CreateTable(
            //    "dbo.ValidationType",
            //    c => new
            //        {
            //            ValidationTypeId = c.Int(nullable: false, identity: true),
            //            Name = c.String(nullable: false, maxLength: 100),
            //        })
            //    .PrimaryKey(t => t.ValidationTypeId);
            
            //CreateTable(
            //    "dbo.NominationVolumes_Archive",
            //    c => new
            //        {
            //            NominationVolumesId = c.Int(nullable: false),
            //            NominationShipperId = c.Int(nullable: false),
            //            Hour = c.Int(nullable: false),
            //            StartTime = c.DateTime(nullable: false),
            //            EndTime = c.DateTime(nullable: false),
            //            VolumeNominated = c.Decimal(nullable: false, precision: 18, scale: 2),
            //            CounterpartyNominated = c.Decimal(nullable: false, precision: 18, scale: 2),
            //            AllocatedVolume = c.Decimal(precision: 18, scale: 2),
            //            IsExitFlow = c.Boolean(nullable: false),
            //            IsEntryFlow = c.Boolean(nullable: false),
            //            UpdatedBy = c.String(nullable: false, maxLength: 64),
            //            UpdatedOn = c.DateTime(nullable: false),
            //        })
            //    .PrimaryKey(t => t.NominationVolumesId);
            
            //CreateTable(
            //    "dbo.NomRenomWindows",
            //    c => new
            //        {
            //            Window = c.String(nullable: false, maxLength: 256),
            //            Entry = c.String(nullable: false, maxLength: 256),
            //            Exit = c.String(nullable: false, maxLength: 256),
            //        })
            //    .PrimaryKey(t => t.Window);
            
            //CreateTable(
            //    "caprpt.PhysicalTradeView",
            //    c => new
            //        {
            //            TradeId = c.Int(nullable: false),
            //            StartDateUtc = c.DateTime(nullable: false),
            //            EndDateUtc = c.DateTime(nullable: false),
            //            Volume = c.Decimal(nullable: false, precision: 18, scale: 2),
            //            Unit = c.String(nullable: false, maxLength: 100),
            //            BuySell = c.String(nullable: false, maxLength: 4),
            //            Counterparty = c.String(nullable: false, maxLength: 100),
            //            EndurLocation = c.String(nullable: false, maxLength: 100),
            //            ContractReference = c.String(maxLength: 100),
            //            CapacityInstrumentType = c.String(maxLength: 32),
            //        })
            //    .PrimaryKey(t => new { t.TradeId, t.StartDateUtc, t.EndDateUtc, t.Volume, t.Unit, t.BuySell, t.Counterparty, t.EndurLocation });
            
            //CreateTable(
            //    "caprpt.PipelineView",
            //    c => new
            //        {
            //            GasPipelineId = c.Int(nullable: false),
            //            FromLocationId = c.Int(nullable: false),
            //            ToLocationId = c.Int(nullable: false),
            //            CheckExit = c.Boolean(nullable: false),
            //            CheckEntry = c.Boolean(nullable: false),
            //            IsExternal = c.Boolean(nullable: false),
            //            FuelGas = c.Decimal(nullable: false, precision: 18, scale: 2),
            //            UpliftFactor = c.Decimal(nullable: false, precision: 18, scale: 2),
            //            RedeliveryTransitItem = c.Boolean(nullable: false),
            //            IsVirtual = c.Boolean(nullable: false),
            //            Name = c.String(maxLength: 64),
            //            FromLocationExitLineName = c.String(maxLength: 100),
            //            ToLocationEntryLineName = c.String(maxLength: 100),
            //            FromLocationDisplayName = c.String(maxLength: 24),
            //            ToLocationDisplayName = c.String(maxLength: 24),
            //            FromInternalShippingId = c.Int(),
            //            ToInternalShippingId = c.Int(),
            //            FromInternalShipperCode = c.String(maxLength: 50),
            //            ToInternalShipperCode = c.String(maxLength: 50),
            //            Hide = c.Boolean(),
            //        })
            //    .PrimaryKey(t => new { t.GasPipelineId, t.FromLocationId, t.ToLocationId, t.CheckExit, t.CheckEntry, t.IsExternal, t.FuelGas, t.UpliftFactor, t.RedeliveryTransitItem, t.IsVirtual });
            
            //CreateTable(
            //    "caprpt.PositionAdjustView",
            //    c => new
            //        {
            //            GasTradePositionAdjustId = c.Int(nullable: false),
            //            StartDateUtc = c.DateTime(nullable: false),
            //            EndDateUtc = c.DateTime(nullable: false),
            //            Volume = c.Decimal(nullable: false, precision: 18, scale: 2),
            //            Counterparty = c.String(nullable: false, maxLength: 100),
            //            Unit = c.String(nullable: false, maxLength: 32),
            //            GasLocationId = c.Int(nullable: false),
            //            ProfileStartDateUtc = c.DateTime(),
            //            ProfileEndDateUtc = c.DateTime(),
            //            ProfileVolume = c.Decimal(precision: 18, scale: 2),
            //            ContractReference = c.String(maxLength: 50),
            //            CapacityInstrumentType = c.String(maxLength: 32),
            //            InternalShippingId = c.Int(),
            //            InternalShippingCode = c.String(maxLength: 50),
            //        })
            //    .PrimaryKey(t => new { t.GasTradePositionAdjustId, t.StartDateUtc, t.EndDateUtc, t.Volume, t.Counterparty, t.Unit, t.GasLocationId });
            
            //CreateTable(
            //    "dbo.RawISISCapacityMessage",
            //    c => new
            //        {
            //            RawISISCapacityMessageId = c.Int(nullable: false, identity: true),
            //            MessageReceivedAt = c.DateTime(nullable: false),
            //            MessageContents = c.String(nullable: false),
            //        })
            //    .PrimaryKey(t => t.RawISISCapacityMessageId);
            
            //CreateTable(
            //    "dbo.Roles",
            //    c => new
            //        {
            //            Roles = c.Int(nullable: false, identity: true),
            //            Name = c.String(nullable: false, maxLength: 50),
            //            Description = c.String(maxLength: 50),
            //            SecurityRoleId = c.Int(nullable: false),
            //        })
            //    .PrimaryKey(t => t.Roles)
            //    .ForeignKey("dbo.SecurityRoles", t => t.SecurityRoleId, cascadeDelete: true)
            //    .Index(t => t.SecurityRoleId);
            
            //CreateTable(
            //    "dbo.SecurityRoles",
            //    c => new
            //        {
            //            SecurityRolesId = c.Int(nullable: false, identity: true),
            //            Name = c.String(nullable: false, maxLength: 50),
            //            Description = c.String(maxLength: 50),
            //        })
            //    .PrimaryKey(t => t.SecurityRolesId);
            
            //CreateTable(
            //    "dbo.UserRoles",
            //    c => new
            //        {
            //            UserRolesId = c.Int(nullable: false, identity: true),
            //            User = c.Int(nullable: false),
            //            Role = c.Int(nullable: false),
            //            Comment = c.String(maxLength: 500),
            //        })
            //    .PrimaryKey(t => t.UserRolesId)
            //    .ForeignKey("dbo.Roles", t => t.Role, cascadeDelete: true)
            //    .ForeignKey("dbo.User", t => t.User, cascadeDelete: true)
            //    .Index(t => t.User)
            //    .Index(t => t.Role);
            
            //CreateTable(
            //    "dbo.User",
            //    c => new
            //        {
            //            UserId = c.Int(nullable: false, identity: true),
            //            NTLogin = c.String(nullable: false, maxLength: 500),
            //            Username = c.String(nullable: false, maxLength: 1000),
            //            Disabled = c.Boolean(nullable: false),
            //            EmailAddress = c.String(maxLength: 64),
            //            MobileNumber = c.String(maxLength: 32),
            //            WindowTitleCustomisation = c.String(maxLength: 256),
            //        })
            //    .PrimaryKey(t => t.UserId);
            
            //CreateTable(
            //    "dbo.ServiceHeartbeat",
            //    c => new
            //        {
            //            ServiceName = c.String(nullable: false, maxLength: 100),
            //            Heartbeat = c.DateTime(nullable: false),
            //            LastRun = c.DateTime(),
            //        })
            //    .PrimaryKey(t => t.ServiceName);
            
            //CreateTable(
            //    "dbo.SystemConfiguration",
            //    c => new
            //        {
            //            Name = c.String(nullable: false, maxLength: 256),
            //            Value = c.String(nullable: false, maxLength: 1024),
            //        })
            //    .PrimaryKey(t => t.Name);
            
            //CreateTable(
            //    "refdata.Timezone",
            //    c => new
            //        {
            //            TimezoneId = c.Int(nullable: false, identity: true),
            //            Name = c.String(nullable: false, maxLength: 100),
            //            Code = c.String(nullable: false, maxLength: 8),
            //            GasDayLocalStartHour = c.Short(nullable: false),
            //            StartUtc = c.DateTime(nullable: false),
            //            EndUtc = c.DateTime(nullable: false),
            //        })
            //    .PrimaryKey(t => t.TimezoneId);
            
            //CreateTable(
            //    "caprpt.TimezoneView",
            //    c => new
            //        {
            //            TimezoneId = c.Int(nullable: false, identity: true),
            //            Name = c.String(nullable: false, maxLength: 100),
            //            Code = c.String(nullable: false, maxLength: 8),
            //        })
            //    .PrimaryKey(t => new { t.TimezoneId, t.Name, t.Code });
            
            //CreateTable(
            //    "caprpt.TradeCancellationView",
            //    c => new
            //        {
            //            TradeCancellationId = c.Int(nullable: false, identity: true),
            //            StartDateUtc = c.DateTime(nullable: false),
            //            EndDateUtc = c.DateTime(nullable: false),
            //            ActionIndicator = c.Decimal(nullable: false, precision: 18, scale: 2),
            //            Counterparty = c.String(nullable: false, maxLength: 100),
            //            GasLocationId = c.Int(nullable: false),
            //        })
            //    .PrimaryKey(t => new { t.TradeCancellationId, t.StartDateUtc, t.EndDateUtc, t.ActionIndicator, t.Counterparty, t.GasLocationId });
            
            //CreateTable(
            //    "dbo.TransitFlowMapper",
            //    c => new
            //        {
            //            TransitFlowMapperId = c.Int(nullable: false, identity: true),
            //            Name = c.String(nullable: false, maxLength: 64),
            //            Route = c.String(nullable: false, maxLength: 1000),
            //        })
            //    .PrimaryKey(t => t.TransitFlowMapperId);
            
            //CreateTable(
            //    "dbo.TransitRouteAudit",
            //    c => new
            //        {
            //            TransitRouteId = c.Int(nullable: false),
            //            Name = c.String(nullable: false, maxLength: 64),
            //            IsDisabled = c.Boolean(nullable: false),
            //            EditedOn = c.DateTime(nullable: false),
            //            AuditDate = c.DateTime(nullable: false),
            //            EditedBy = c.String(maxLength: 100),
            //        })
            //    .PrimaryKey(t => new { t.TransitRouteId, t.Name, t.IsDisabled, t.EditedOn, t.AuditDate });
            
            //CreateTable(
            //    "dbo.TransitRouteLegAudit",
            //    c => new
            //        {
            //            TransitRouteLegId = c.Int(nullable: false),
            //            TransitRouteId = c.Int(nullable: false),
            //            LegNumber = c.Int(nullable: false),
            //            AuditDate = c.DateTime(nullable: false),
            //            FromShipperId = c.Int(),
            //            ToShipperId = c.Int(),
            //            FromCapacityInstrumentType = c.String(maxLength: 64),
            //            ToCapacityInstrumentType = c.String(maxLength: 64),
            //            FromLineName = c.String(maxLength: 64),
            //            ToLineName = c.String(maxLength: 64),
            //            PipelineId = c.Int(),
            //        })
            //    .PrimaryKey(t => new { t.TransitRouteLegId, t.TransitRouteId, t.LegNumber, t.AuditDate });
            
            //CreateTable(
            //    "caprpt.UkLocationMappingView",
            //    c => new
            //        {
            //            ParentLocationId = c.Int(nullable: false),
            //            LocationName = c.String(nullable: false, maxLength: 100),
            //            EndurContractRef = c.String(maxLength: 50),
            //            PipelineName = c.String(maxLength: 100),
            //        })
            //    .PrimaryKey(t => new { t.ParentLocationId, t.LocationName });
            
            //CreateTable(
            //    "dbo.UnitConversion",
            //    c => new
            //        {
            //            UnitConversionId = c.Int(nullable: false, identity: true),
            //            Unit = c.String(nullable: false, maxLength: 32),
            //            IsRate = c.Boolean(nullable: false),
            //            IsGcvFactor = c.Boolean(nullable: false),
            //            ToKwhFactor = c.Decimal(nullable: false, precision: 18, scale: 2),
            //        })
            //    .PrimaryKey(t => t.UnitConversionId);
            
            //CreateTable(
            //    "caprpt.UnitConversionView",
            //    c => new
            //        {
            //            UnitConversionId = c.Int(nullable: false, identity: true),
            //            Unit = c.String(nullable: false, maxLength: 32),
            //            IsRate = c.Boolean(nullable: false),
            //            IsGcvFactor = c.Boolean(nullable: false),
            //            ToKwhFactor = c.Decimal(nullable: false, precision: 18, scale: 2),
            //        })
            //    .PrimaryKey(t => new { t.UnitConversionId, t.Unit, t.IsRate, t.IsGcvFactor, t.ToKwhFactor });
            
            //CreateTable(
            //    "caprpt.UserRolesView",
            //    c => new
            //        {
            //            Rolename = c.String(nullable: false, maxLength: 50),
            //            UserLogin = c.String(nullable: false, maxLength: 500),
            //            UserRoleId = c.Int(nullable: false),
            //            Disabled = c.Boolean(nullable: false),
            //        })
            //    .PrimaryKey(t => new { t.Rolename, t.UserLogin, t.UserRoleId, t.Disabled });
            
            //CreateTable(
            //    "dbo.vw_Nomination_All",
            //    c => new
            //        {
            //            NominationId = c.Int(nullable: false),
            //            GasNetworkId = c.Int(nullable: false),
            //            Version = c.Int(nullable: false),
            //            SubmissionDateTime = c.DateTime(nullable: false),
            //            DeliveryDate = c.DateTime(nullable: false),
            //            Status = c.Int(nullable: false),
            //            Deleted = c.Boolean(nullable: false),
            //            UpdatedBy = c.String(nullable: false, maxLength: 500),
            //            UpdatedOn = c.DateTime(nullable: false),
            //            Unit = c.Int(nullable: false),
            //            Filename = c.String(maxLength: 1000),
            //            AcknowledgementFile = c.String(maxLength: 1000),
            //            ConfirmationFile = c.String(maxLength: 1000),
            //            AnomalyFile = c.String(maxLength: 1000),
            //        })
            //    .PrimaryKey(t => new { t.NominationId, t.GasNetworkId, t.Version, t.SubmissionDateTime, t.DeliveryDate, t.Status, t.Deleted, t.UpdatedBy, t.UpdatedOn, t.Unit });
            
            //CreateTable(
            //    "dbo.vw_NominationShipper_All",
            //    c => new
            //        {
            //            NomiantionShipperId = c.Int(nullable: false),
            //            ShipperCode = c.String(nullable: false, maxLength: 100),
            //            DeliveryDate = c.DateTime(nullable: false),
            //            Status = c.Int(nullable: false),
            //            GasLocationId = c.Int(nullable: false),
            //            LocationCode = c.String(nullable: false, maxLength: 100),
            //            NominationId = c.Int(nullable: false),
            //            version = c.Int(nullable: false),
            //            IsLatest = c.Boolean(nullable: false),
            //            IsBuy = c.Boolean(nullable: false),
            //            CounterpartyName = c.String(maxLength: 200),
            //            ShipperId = c.Int(),
            //            InternalShippingId = c.Int(),
            //            ConfirmCreatedDate = c.DateTime(),
            //            EffectiveHour = c.Int(),
            //        })
            //    .PrimaryKey(t => new { t.NomiantionShipperId, t.ShipperCode, t.DeliveryDate, t.Status, t.GasLocationId, t.LocationCode, t.NominationId, t.version, t.IsLatest, t.IsBuy });
            
            //CreateTable(
            //    "dbo.vw_NominationVolumes_All",
            //    c => new
            //        {
            //            NominationVolumesId = c.Int(nullable: false),
            //            NominationShipperId = c.Int(nullable: false),
            //            Hour = c.Int(nullable: false),
            //            StartTime = c.DateTime(nullable: false),
            //            EndTime = c.DateTime(nullable: false),
            //            VolumeNominated = c.Decimal(nullable: false, precision: 18, scale: 2),
            //            CounterpartyNominated = c.Decimal(nullable: false, precision: 18, scale: 2),
            //            IsExitFlow = c.Boolean(nullable: false),
            //            IsEntryFlow = c.Boolean(nullable: false),
            //            UpdatedBy = c.String(nullable: false, maxLength: 64),
            //            UpdatedOn = c.DateTime(nullable: false),
            //            AllocatedVolume = c.Decimal(precision: 18, scale: 2),
            //        })
            //    .PrimaryKey(t => new { t.NominationVolumesId, t.NominationShipperId, t.Hour, t.StartTime, t.EndTime, t.VolumeNominated, t.CounterpartyNominated, t.IsExitFlow, t.IsEntryFlow, t.UpdatedBy, t.UpdatedOn });
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserRoles", "User", "dbo.User");
            DropForeignKey("dbo.UserRoles", "Role", "dbo.Roles");
            DropForeignKey("dbo.Roles", "SecurityRoleId", "dbo.SecurityRoles");
            DropForeignKey("dbo.NominationValidation", "ValidationTypeId", "dbo.ValidationType");
            DropForeignKey("dbo.AccountablePOS", "EnergyUnit", "dbo.Unit");
            DropForeignKey("dbo.AccountablePOS", "GasNetworkId", "dbo.GasNetwork");
            DropForeignKey("dbo.GasNetwork", "BalancingUnitId", "dbo.Unit");
            DropForeignKey("dbo.GasNetwork", "NetworkTypeId", "dbo.NetworkType");
            DropForeignKey("dbo.GasNetwork", "ParentNetworkId", "dbo.GasNetwork");
            DropForeignKey("dbo.ConfirmationAnomoly", "UnitId", "dbo.Unit");
            DropForeignKey("dbo.ConfirmationAnomoly", "Status", "dbo.Status");
            DropForeignKey("dbo.ConfirmationAnomoly", "GasNetworkId", "dbo.GasNetwork");
            DropForeignKey("dbo.ConfirmationAnomoly", "GasLocationId", "dbo.GasLocation");
            DropForeignKey("dbo.GasLocation", "LocationTypeId", "dbo.LocationType");
            DropForeignKey("dbo.GxpMappings", "GasLocationId", "dbo.GasLocation");
            DropForeignKey("dbo.GasLocation", "NonDailyMeteredShipper", "dbo.GasShipper");
            DropForeignKey("dbo.GasLocation", "DailyMeteredShipper", "dbo.GasShipper");
            DropForeignKey("dbo.GasShipper", "DuplicateTrades", "dbo.GasShipper");
            DropForeignKey("dbo.GasShipper", "GasLocationId", "dbo.GasLocation");
            DropForeignKey("dbo.GasLocation", "GasNetworkId", "dbo.GasNetwork");
            DropForeignKey("dbo.GasLocationMapping", "GasLocationId", "dbo.GasLocation");
            DropForeignKey("dbo.GasLocationGCV", "GasLocationId", "dbo.GasLocation");
            DropForeignKey("dbo.FlowLineNameMapping", "GasLocationId", "dbo.GasLocation");
            DropForeignKey("dbo.ExternalCapacityLocationMapping", "ParentLocationId", "dbo.GasLocation");
            DropForeignKey("dbo.CapacityRouteLegs", "GasPipelineId", "dbo.GasPipeline");
            DropForeignKey("dbo.GasPipeline", "ToInternalShippingId", "dbo.InternalShipping");
            DropForeignKey("dbo.GasPipeline", "FromInternalShippingId", "dbo.InternalShipping");
            DropForeignKey("dbo.GasTransit", "UnitId", "dbo.Unit");
            DropForeignKey("dbo.GasTransit", "ToInternalShippingId", "dbo.InternalShipping");
            DropForeignKey("dbo.GasTransit", "FromInternalShippingId", "dbo.InternalShipping");
            DropForeignKey("dbo.TransitRouteLeg", "TransitRouteId", "dbo.TransitRoute");
            DropForeignKey("dbo.TransitRouteLeg", "ToShipperId", "dbo.InternalShipping");
            DropForeignKey("dbo.TransitRouteLeg", "FromShipperId", "dbo.InternalShipping");
            DropForeignKey("dbo.TransitRouteLeg", "PipelineId", "dbo.GasPipeline");
            DropForeignKey("dbo.InternalShipping", "NadAccountId", "dbo.NadAccount");
            DropForeignKey("dbo.NadAccount", "NominationsParametersId", "dbo.NominationParameters");
            DropForeignKey("dbo.NominationParameters", "NominationSystemTypeId", "dbo.NominationSystemType");
            DropForeignKey("dbo.ShipperPreliminaryBalance", "NominationsSystemTypeId", "dbo.NominationSystemType");
            DropForeignKey("dbo.SendInformation", "SendTypeId", "dbo.SendType");
            DropForeignKey("dbo.SendInformation", "NominationsSystemTypeId", "dbo.NominationSystemType");
            DropForeignKey("dbo.NominationParameters", "GasNetworkId", "dbo.GasNetwork");
            DropForeignKey("dbo.GasTradePositionAdjust", "UnitId", "dbo.Unit");
            DropForeignKey("dbo.PositionCheck", "UnitId", "dbo.Unit");
            DropForeignKey("dbo.PositionCheck", "GasNetworkId", "dbo.GasNetwork");
            DropForeignKey("dbo.Nomination", "Unit", "dbo.Unit");
            DropForeignKey("dbo.Nomination", "Status", "dbo.Status");
            DropForeignKey("dbo.NominationShipper", "Status", "dbo.Status");
            DropForeignKey("dbo.NominationVolumes", "NominationShipperId", "dbo.NominationShipper");
            DropForeignKey("dbo.NominationShipper", "NominationId", "dbo.Nomination");
            DropForeignKey("dbo.NominationShipper", "GasLocationId", "dbo.GasLocation");
            DropForeignKey("dbo.Nomination", "GasNetworkId", "dbo.GasNetwork");
            DropForeignKey("dbo.NearRealtimeAllocations", "EnergyUnit", "dbo.Unit");
            DropForeignKey("dbo.NearRealtimeAllocations", "ConfirmedEnergyUnit", "dbo.Unit");
            DropForeignKey("dbo.NearRealtimeAllocations", "CalorificMeasureUnit", "dbo.Unit");
            DropForeignKey("dbo.AccountableSBS", "EnergyUnit", "dbo.Unit");
            DropForeignKey("dbo.SBSBufferZones", "AccountableSBSId", "dbo.AccountableSBS");
            DropForeignKey("dbo.GasTradePositionAdjust", "InternalShippingId", "dbo.InternalShipping");
            DropForeignKey("dbo.GasTradeAdjustProfile", "GasTradePositionAdjustId", "dbo.GasTradePositionAdjust");
            DropForeignKey("dbo.GasTradePositionAdjust", "GasLocationId", "dbo.GasLocation");
            DropForeignKey("dbo.InternalShipping", "GasLocationId", "dbo.GasLocation");
            DropForeignKey("dbo.InternalShipping", "EndurCapacityProductId", "dbo.EndurCapacityProduct");
            DropForeignKey("dbo.GasNetworkDisplayCapacityProduct", "GasNetworkId", "dbo.GasNetwork");
            DropForeignKey("dbo.GasNetworkDisplayCapacityProduct", "EndurCapacityProductId", "dbo.EndurCapacityProduct");
            DropForeignKey("dbo.GasTransit", "GasPipelineId", "dbo.GasPipeline");
            DropForeignKey("dbo.GasPipeline", "ToLocationId", "dbo.GasLocation");
            DropForeignKey("dbo.GasPipeline", "FromLocationId", "dbo.GasLocation");
            DropForeignKey("dbo.AutoFlow", "GasPipelineId", "dbo.GasPipeline");
            DropForeignKey("dbo.CapacityRouteLegs", "GasLocationId", "dbo.GasLocation");
            DropForeignKey("dbo.CapacityRouteLegs", "InstrumentTypeId", "dbo.EndurInstrumentType");
            DropForeignKey("dbo.GasTradePositionEndurExclusion", "EndurVolumeTypeId", "dbo.EndurVolumeType");
            DropForeignKey("dbo.GasTradePositionEndurExclusion", "EndurInstrumentTypeId", "dbo.EndurInstrumentType");
            DropForeignKey("dbo.GasLocationInstrumentMapping", "GasLocationId", "dbo.GasLocation");
            DropForeignKey("dbo.GasLocationInstrumentMapping", "EndurInstrumentTypeId", "dbo.EndurInstrumentType");
            DropForeignKey("dbo.EndurInstrumentType", "CommodityType", "dbo.CommodityType");
            DropForeignKey("dbo.CapacityRouteLegs", "RouteId", "dbo.CapacityTradeMultiLegRoute");
            DropForeignKey("dbo.CapacityDayCheck", "GasNetworkId", "dbo.GasNetwork");
            DropForeignKey("dbo.GasNetwork", "BalancingTypeId", "dbo.BalancingType");
            DropIndex("dbo.UserRoles", new[] { "Role" });
            DropIndex("dbo.UserRoles", new[] { "User" });
            DropIndex("dbo.Roles", new[] { "SecurityRoleId" });
            DropIndex("dbo.NominationValidation", new[] { "ValidationTypeId" });
            DropIndex("dbo.GxpMappings", new[] { "GasLocationId" });
            DropIndex("dbo.GasShipper", new[] { "DuplicateTrades" });
            DropIndex("dbo.GasShipper", new[] { "GasLocationId" });
            DropIndex("dbo.GasLocationMapping", new[] { "GasLocationId" });
            DropIndex("dbo.GasLocationGCV", new[] { "GasLocationId" });
            DropIndex("dbo.FlowLineNameMapping", new[] { "GasLocationId" });
            DropIndex("dbo.ExternalCapacityLocationMapping", new[] { "ParentLocationId" });
            DropIndex("dbo.TransitRouteLeg", new[] { "PipelineId" });
            DropIndex("dbo.TransitRouteLeg", new[] { "ToShipperId" });
            DropIndex("dbo.TransitRouteLeg", new[] { "FromShipperId" });
            DropIndex("dbo.TransitRouteLeg", new[] { "TransitRouteId" });
            DropIndex("dbo.ShipperPreliminaryBalance", new[] { "NominationsSystemTypeId" });
            DropIndex("dbo.SendInformation", new[] { "SendTypeId" });
            DropIndex("dbo.SendInformation", new[] { "NominationsSystemTypeId" });
            DropIndex("dbo.NominationParameters", new[] { "NominationSystemTypeId" });
            DropIndex("dbo.NominationParameters", new[] { "GasNetworkId" });
            DropIndex("dbo.NadAccount", new[] { "NominationsParametersId" });
            DropIndex("dbo.PositionCheck", new[] { "UnitId" });
            DropIndex("dbo.PositionCheck", new[] { "GasNetworkId" });
            DropIndex("dbo.NominationVolumes", new[] { "NominationShipperId" });
            DropIndex("dbo.NominationShipper", new[] { "NominationId" });
            DropIndex("dbo.NominationShipper", new[] { "GasLocationId" });
            DropIndex("dbo.NominationShipper", new[] { "Status" });
            DropIndex("dbo.Nomination", new[] { "Unit" });
            DropIndex("dbo.Nomination", new[] { "Status" });
            DropIndex("dbo.Nomination", new[] { "GasNetworkId" });
            DropIndex("dbo.NearRealtimeAllocations", new[] { "CalorificMeasureUnit" });
            DropIndex("dbo.NearRealtimeAllocations", new[] { "ConfirmedEnergyUnit" });
            DropIndex("dbo.NearRealtimeAllocations", new[] { "EnergyUnit" });
            DropIndex("dbo.SBSBufferZones", new[] { "AccountableSBSId" });
            DropIndex("dbo.AccountableSBS", new[] { "EnergyUnit" });
            DropIndex("dbo.GasTradeAdjustProfile", new[] { "GasTradePositionAdjustId" });
            DropIndex("dbo.GasTradePositionAdjust", new[] { "UnitId" });
            DropIndex("dbo.GasTradePositionAdjust", new[] { "GasLocationId" });
            DropIndex("dbo.GasTradePositionAdjust", new[] { "InternalShippingId" });
            DropIndex("dbo.GasNetworkDisplayCapacityProduct", new[] { "EndurCapacityProductId" });
            DropIndex("dbo.GasNetworkDisplayCapacityProduct", new[] { "GasNetworkId" });
            DropIndex("dbo.InternalShipping", new[] { "EndurCapacityProductId" });
            DropIndex("dbo.InternalShipping", new[] { "NadAccountId" });
            DropIndex("dbo.InternalShipping", new[] { "GasLocationId" });
            DropIndex("dbo.GasTransit", new[] { "ToInternalShippingId" });
            DropIndex("dbo.GasTransit", new[] { "FromInternalShippingId" });
            DropIndex("dbo.GasTransit", new[] { "UnitId" });
            DropIndex("dbo.GasTransit", new[] { "GasPipelineId" });
            DropIndex("dbo.AutoFlow", new[] { "GasPipelineId" });
            DropIndex("dbo.GasPipeline", new[] { "ToInternalShippingId" });
            DropIndex("dbo.GasPipeline", new[] { "FromInternalShippingId" });
            DropIndex("dbo.GasPipeline", new[] { "ToLocationId" });
            DropIndex("dbo.GasPipeline", new[] { "FromLocationId" });
            DropIndex("dbo.GasTradePositionEndurExclusion", new[] { "EndurVolumeTypeId" });
            DropIndex("dbo.GasTradePositionEndurExclusion", new[] { "EndurInstrumentTypeId" });
            DropIndex("dbo.GasLocationInstrumentMapping", new[] { "EndurInstrumentTypeId" });
            DropIndex("dbo.GasLocationInstrumentMapping", new[] { "GasLocationId" });
            DropIndex("dbo.EndurInstrumentType", new[] { "CommodityType" });
            DropIndex("dbo.CapacityRouteLegs", new[] { "GasPipelineId" });
            DropIndex("dbo.CapacityRouteLegs", new[] { "GasLocationId" });
            DropIndex("dbo.CapacityRouteLegs", new[] { "InstrumentTypeId" });
            DropIndex("dbo.CapacityRouteLegs", new[] { "RouteId" });
            DropIndex("dbo.GasLocation", new[] { "NonDailyMeteredShipper" });
            DropIndex("dbo.GasLocation", new[] { "DailyMeteredShipper" });
            DropIndex("dbo.GasLocation", new[] { "LocationTypeId" });
            DropIndex("dbo.GasLocation", new[] { "GasNetworkId" });
            DropIndex("dbo.ConfirmationAnomoly", new[] { "UnitId" });
            DropIndex("dbo.ConfirmationAnomoly", new[] { "Status" });
            DropIndex("dbo.ConfirmationAnomoly", new[] { "GasLocationId" });
            DropIndex("dbo.ConfirmationAnomoly", new[] { "GasNetworkId" });
            DropIndex("dbo.CapacityDayCheck", new[] { "GasNetworkId" });
            DropIndex("dbo.GasNetwork", new[] { "ParentNetworkId" });
            DropIndex("dbo.GasNetwork", new[] { "NetworkTypeId" });
            DropIndex("dbo.GasNetwork", new[] { "BalancingUnitId" });
            DropIndex("dbo.GasNetwork", new[] { "BalancingTypeId" });
            DropIndex("dbo.AccountablePOS", new[] { "EnergyUnit" });
            DropIndex("dbo.AccountablePOS", new[] { "GasNetworkId" });
            DropTable("dbo.vw_NominationVolumes_All");
            DropTable("dbo.vw_NominationShipper_All");
            DropTable("dbo.vw_Nomination_All");
            DropTable("caprpt.UserRolesView");
            DropTable("caprpt.UnitConversionView");
            DropTable("dbo.UnitConversion");
            DropTable("caprpt.UkLocationMappingView");
            DropTable("dbo.TransitRouteLegAudit");
            DropTable("dbo.TransitRouteAudit");
            DropTable("dbo.TransitFlowMapper");
            DropTable("caprpt.TradeCancellationView");
            DropTable("caprpt.TimezoneView");
            DropTable("refdata.Timezone");
            DropTable("dbo.SystemConfiguration");
            DropTable("dbo.ServiceHeartbeat");
            DropTable("dbo.User");
            DropTable("dbo.UserRoles");
            DropTable("dbo.SecurityRoles");
            DropTable("dbo.Roles");
            DropTable("dbo.RawISISCapacityMessage");
            DropTable("caprpt.PositionAdjustView");
            DropTable("caprpt.PipelineView");
            DropTable("caprpt.PhysicalTradeView");
            DropTable("dbo.NomRenomWindows");
            DropTable("dbo.NominationVolumes_Archive");
            DropTable("dbo.ValidationType");
            DropTable("dbo.NominationValidation");
            DropTable("dbo.NominationShipper_Archive");
            DropTable("caprpt.NominationMessagesView");
            DropTable("dbo.Nomination_Archive");
            DropTable("caprpt.NetworkView");
            DropTable("caprpt.MultiLegCapacityTradeMapping");
            DropTable("caprpt.LocationView");
            DropTable("caprpt.LocationMappingView");
            DropTable("dbo.KeyPerformanceIndicators");
            DropTable("caprpt.ISISCapacityTradeView");
            DropTable("dbo.GTSDataSendInformation");
            DropTable("caprpt.GeminiDataUpdatedView");
            DropTable("caprpt.GeminiCapacityTradeView");
            DropTable("caprpt.GasTransitView");
            DropTable("dbo.GasTradePositionEndur");
            DropTable("dbo.GasTradeDetailEndur");
            DropTable("caprpt.GasLocationGCVView");
            DropTable("dbo.ExternalCapacityLocationMappingAudit");
            DropTable("dbo.Entitlements");
            DropTable("dbo.EnomMessageField");
            DropTable("caprpt.CapacityTradeView");
            DropTable("dbo.CapacityInstrumentType");
            DropTable("dbo.NetworkType");
            DropTable("dbo.LocationType");
            DropTable("dbo.GxpMappings");
            DropTable("dbo.GasShipper");
            DropTable("dbo.GasLocationMapping");
            DropTable("dbo.GasLocationGCV");
            DropTable("dbo.FlowLineNameMapping");
            DropTable("dbo.ExternalCapacityLocationMapping");
            DropTable("dbo.TransitRoute");
            DropTable("dbo.TransitRouteLeg");
            DropTable("dbo.ShipperPreliminaryBalance");
            DropTable("dbo.SendType");
            DropTable("dbo.SendInformation");
            DropTable("dbo.NominationSystemType");
            DropTable("dbo.NominationParameters");
            DropTable("dbo.NadAccount");
            DropTable("dbo.PositionCheck");
            DropTable("dbo.Status");
            DropTable("dbo.NominationVolumes");
            DropTable("dbo.NominationShipper");
            DropTable("dbo.Nomination");
            DropTable("dbo.NearRealtimeAllocations");
            DropTable("dbo.SBSBufferZones");
            DropTable("dbo.AccountableSBS");
            DropTable("dbo.Unit");
            DropTable("dbo.GasTradeAdjustProfile");
            DropTable("dbo.GasTradePositionAdjust");
            DropTable("dbo.GasNetworkDisplayCapacityProduct");
            DropTable("dbo.EndurCapacityProduct");
            DropTable("dbo.InternalShipping");
            DropTable("dbo.GasTransit");
            DropTable("dbo.AutoFlow");
            DropTable("dbo.GasPipeline");
            DropTable("dbo.EndurVolumeType");
            DropTable("dbo.GasTradePositionEndurExclusion");
            DropTable("dbo.GasLocationInstrumentMapping");
            DropTable("dbo.CommodityType");
            DropTable("dbo.EndurInstrumentType");
            DropTable("dbo.CapacityTradeMultiLegRoute");
            DropTable("dbo.CapacityRouteLegs");
            DropTable("dbo.GasLocation");
            DropTable("dbo.ConfirmationAnomoly");
            DropTable("dbo.CapacityDayCheck");
            DropTable("dbo.BalancingType");
            DropTable("dbo.GasNetwork");
            DropTable("dbo.AccountablePOS");
        }
    }
}
