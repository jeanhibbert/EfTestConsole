using System.Data.Entity;
using System.Data.Entity.Infrastructure;

using Gazprom.BigBoy.Model.Models;
using Gazprom.BigBoy.Model.Models.Mapping;

namespace Gazprom.Data
{
    public partial class GasNominations_Endur_prodContext : DbContext
    {
        static GasNominations_Endur_prodContext()
        {
            Database.SetInitializer<GasNominations_Endur_prodContext>(null);
        }

        public GasNominations_Endur_prodContext()
            : base("Name=GasNominations_Endur_prodContext")
        {
        }

        public DbSet<AccountablePOS> AccountablePOS { get; set; }
        public DbSet<AccountableSB> AccountableSBS { get; set; }
        public DbSet<AutoFlow> AutoFlows { get; set; }
        public DbSet<BalancingType> BalancingTypes { get; set; }
        public DbSet<CapacityDayCheck> CapacityDayChecks { get; set; }
        public DbSet<CapacityInstrumentType> CapacityInstrumentTypes { get; set; }
        public DbSet<CapacityRouteLeg> CapacityRouteLegs { get; set; }
        public DbSet<CapacityTradeMultiLegRoute> CapacityTradeMultiLegRoutes { get; set; }
        public DbSet<CommodityType> CommodityTypes { get; set; }
        public DbSet<ConfirmationAnomoly> ConfirmationAnomolies { get; set; }
        public DbSet<EndurCapacityProduct> EndurCapacityProducts { get; set; }
        public DbSet<EndurInstrumentType> EndurInstrumentTypes { get; set; }
        public DbSet<EndurVolumeType> EndurVolumeTypes { get; set; }
        public DbSet<EnomMessageField> EnomMessageFields { get; set; }
        public DbSet<Entitlement> Entitlements { get; set; }
        public DbSet<ExternalCapacityLocationMapping> ExternalCapacityLocationMappings { get; set; }
        public DbSet<ExternalCapacityLocationMappingAudit> ExternalCapacityLocationMappingAudits { get; set; }
        public DbSet<FlowLineNameMapping> FlowLineNameMappings { get; set; }
        public DbSet<GasLocation> GasLocations { get; set; }
        public DbSet<GasLocationGCV> GasLocationGCVs { get; set; }
        public DbSet<GasLocationInstrumentMapping> GasLocationInstrumentMappings { get; set; }
        public DbSet<GasLocationMapping> GasLocationMappings { get; set; }
        public DbSet<GasNetwork> GasNetworks { get; set; }
        public DbSet<GasNetworkDisplayCapacityProduct> GasNetworkDisplayCapacityProducts { get; set; }
        public DbSet<GasPipeline> GasPipelines { get; set; }
        public DbSet<GasShipper> GasShippers { get; set; }
        public DbSet<GasTradeAdjustProfile> GasTradeAdjustProfiles { get; set; }
        public DbSet<GasTradeDetailEndur> GasTradeDetailEndurs { get; set; }
        public DbSet<GasTradePositionAdjust> GasTradePositionAdjusts { get; set; }
        public DbSet<GasTradePositionEndur> GasTradePositionEndurs { get; set; }
        public DbSet<GasTradePositionEndurExclusion> GasTradePositionEndurExclusions { get; set; }
        public DbSet<GasTransit> GasTransits { get; set; }
        public DbSet<GTSDataSendInformation> GTSDataSendInformations { get; set; }
        public DbSet<GxpMapping> GxpMappings { get; set; }
        public DbSet<InternalShipping> InternalShippings { get; set; }
        public DbSet<KeyPerformanceIndicator> KeyPerformanceIndicators { get; set; }
        public DbSet<LocationType> LocationTypes { get; set; }
        public DbSet<NadAccount> NadAccounts { get; set; }
        public DbSet<NearRealtimeAllocation> NearRealtimeAllocations { get; set; }
        public DbSet<NetworkType> NetworkTypes { get; set; }
        public DbSet<Nomination> Nominations { get; set; }
        public DbSet<Nomination_Archive> Nomination_Archive { get; set; }
        public DbSet<NominationParameter> NominationParameters { get; set; }
        public DbSet<NominationShipper> NominationShippers { get; set; }
        public DbSet<NominationShipper_Archive> NominationShipper_Archive { get; set; }
        public DbSet<NominationSystemType> NominationSystemTypes { get; set; }
        public DbSet<NominationValidation> NominationValidations { get; set; }
        public DbSet<NominationVolume> NominationVolumes { get; set; }
        public DbSet<NominationVolumes_Archive> NominationVolumes_Archive { get; set; }
        public DbSet<NomRenomWindow> NomRenomWindows { get; set; }

        // New Permissions table
        public DbSet<Permission> Permissions { get; set; }

        public DbSet<PositionCheck> PositionChecks { get; set; }
        public DbSet<RawISISCapacityMessage> RawISISCapacityMessages { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<SBSBufferZone> SBSBufferZones { get; set; }
        public DbSet<SecurityRole> SecurityRoles { get; set; }
        public DbSet<SendInformation> SendInformations { get; set; }
        public DbSet<SendType> SendTypes { get; set; }
        public DbSet<ServiceHeartbeat> ServiceHeartbeats { get; set; }
        public DbSet<ShipperPreliminaryBalance> ShipperPreliminaryBalances { get; set; }
        public DbSet<Status> Status { get; set; }
        public DbSet<SystemConfiguration> SystemConfigurations { get; set; }
        public DbSet<TransitFlowMapper> TransitFlowMappers { get; set; }
        public DbSet<TransitRoute> TransitRoutes { get; set; }
        public DbSet<TransitRouteAudit> TransitRouteAudits { get; set; }
        public DbSet<TransitRouteLeg> TransitRouteLegs { get; set; }
        public DbSet<TransitRouteLegAudit> TransitRouteLegAudits { get; set; }
        public DbSet<Unit> Units { get; set; }
        public DbSet<UnitConversion> UnitConversions { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<ValidationType> ValidationTypes { get; set; }
        public DbSet<Timezone> Timezones { get; set; }
        public DbSet<CapacityTradeView> CapacityTradeViews { get; set; }
        public DbSet<GasLocationGCVView> GasLocationGCVViews { get; set; }
        public DbSet<GasTransitView> GasTransitViews { get; set; }
        public DbSet<GeminiCapacityTradeView> GeminiCapacityTradeViews { get; set; }
        public DbSet<GeminiDataUpdatedView> GeminiDataUpdatedViews { get; set; }
        public DbSet<ISISCapacityTradeView> ISISCapacityTradeViews { get; set; }
        public DbSet<LocationMappingView> LocationMappingViews { get; set; }
        public DbSet<LocationView> LocationViews { get; set; }
        public DbSet<MultiLegCapacityTradeMapping> MultiLegCapacityTradeMappings { get; set; }
        public DbSet<NetworkView> NetworkViews { get; set; }
        public DbSet<NominationMessagesView> NominationMessagesViews { get; set; }
        public DbSet<PhysicalTradeView> PhysicalTradeViews { get; set; }
        public DbSet<PipelineView> PipelineViews { get; set; }
        public DbSet<PositionAdjustView> PositionAdjustViews { get; set; }
        public DbSet<TimezoneView> TimezoneViews { get; set; }
        public DbSet<TradeCancellationView> TradeCancellationViews { get; set; }
        public DbSet<UkLocationMappingView> UkLocationMappingViews { get; set; }
        public DbSet<UnitConversionView> UnitConversionViews { get; set; }
        public DbSet<UserRolesView> UserRolesViews { get; set; }
        public DbSet<vw_Nomination_All> vw_Nomination_All { get; set; }
        public DbSet<vw_NominationShipper_All> vw_NominationShipper_All { get; set; }
        public DbSet<vw_NominationVolumes_All> vw_NominationVolumes_All { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AccountablePOSMap());
            modelBuilder.Configurations.Add(new AccountableSBMap());
            modelBuilder.Configurations.Add(new AutoFlowMap());
            modelBuilder.Configurations.Add(new BalancingTypeMap());
            modelBuilder.Configurations.Add(new CapacityDayCheckMap());
            modelBuilder.Configurations.Add(new CapacityInstrumentTypeMap());
            modelBuilder.Configurations.Add(new CapacityRouteLegMap());
            modelBuilder.Configurations.Add(new CapacityTradeMultiLegRouteMap());
            modelBuilder.Configurations.Add(new CommodityTypeMap());
            modelBuilder.Configurations.Add(new ConfirmationAnomolyMap());
            modelBuilder.Configurations.Add(new EndurCapacityProductMap());
            modelBuilder.Configurations.Add(new EndurInstrumentTypeMap());
            modelBuilder.Configurations.Add(new EndurVolumeTypeMap());
            modelBuilder.Configurations.Add(new EnomMessageFieldMap());
            modelBuilder.Configurations.Add(new EntitlementMap());
            modelBuilder.Configurations.Add(new ExternalCapacityLocationMappingMap());
            modelBuilder.Configurations.Add(new ExternalCapacityLocationMappingAuditMap());
            modelBuilder.Configurations.Add(new FlowLineNameMappingMap());
            modelBuilder.Configurations.Add(new GasLocationMap());
            modelBuilder.Configurations.Add(new GasLocationGCVMap());
            modelBuilder.Configurations.Add(new GasLocationInstrumentMappingMap());
            modelBuilder.Configurations.Add(new GasLocationMappingMap());
            modelBuilder.Configurations.Add(new GasNetworkMap());
            modelBuilder.Configurations.Add(new GasNetworkDisplayCapacityProductMap());
            modelBuilder.Configurations.Add(new GasPipelineMap());
            modelBuilder.Configurations.Add(new GasShipperMap());
            modelBuilder.Configurations.Add(new GasTradeAdjustProfileMap());
            modelBuilder.Configurations.Add(new GasTradeDetailEndurMap());
            modelBuilder.Configurations.Add(new GasTradePositionAdjustMap());
            modelBuilder.Configurations.Add(new GasTradePositionEndurMap());
            modelBuilder.Configurations.Add(new GasTradePositionEndurExclusionMap());
            modelBuilder.Configurations.Add(new GasTransitMap());
            modelBuilder.Configurations.Add(new GTSDataSendInformationMap());
            modelBuilder.Configurations.Add(new GxpMappingMap());
            modelBuilder.Configurations.Add(new InternalShippingMap());
            modelBuilder.Configurations.Add(new KeyPerformanceIndicatorMap());
            modelBuilder.Configurations.Add(new LocationTypeMap());
            modelBuilder.Configurations.Add(new NadAccountMap());
            modelBuilder.Configurations.Add(new NearRealtimeAllocationMap());
            modelBuilder.Configurations.Add(new NetworkTypeMap());
            modelBuilder.Configurations.Add(new NominationMap());
            modelBuilder.Configurations.Add(new Nomination_ArchiveMap());
            modelBuilder.Configurations.Add(new NominationParameterMap());
            modelBuilder.Configurations.Add(new NominationShipperMap());
            modelBuilder.Configurations.Add(new NominationShipper_ArchiveMap());
            modelBuilder.Configurations.Add(new NominationSystemTypeMap());
            modelBuilder.Configurations.Add(new NominationValidationMap());
            modelBuilder.Configurations.Add(new NominationVolumeMap());
            modelBuilder.Configurations.Add(new NominationVolumes_ArchiveMap());
            modelBuilder.Configurations.Add(new NomRenomWindowMap());
            modelBuilder.Configurations.Add(new PositionCheckMap());
            modelBuilder.Configurations.Add(new RawISISCapacityMessageMap());
            modelBuilder.Configurations.Add(new RoleMap());
            modelBuilder.Configurations.Add(new SBSBufferZoneMap());
            modelBuilder.Configurations.Add(new SecurityRoleMap());
            modelBuilder.Configurations.Add(new SendInformationMap());
            modelBuilder.Configurations.Add(new SendTypeMap());
            modelBuilder.Configurations.Add(new ServiceHeartbeatMap());
            modelBuilder.Configurations.Add(new ShipperPreliminaryBalanceMap());
            modelBuilder.Configurations.Add(new StatusMap());
            modelBuilder.Configurations.Add(new SystemConfigurationMap());
            modelBuilder.Configurations.Add(new TransitFlowMapperMap());
            modelBuilder.Configurations.Add(new TransitRouteMap());
            modelBuilder.Configurations.Add(new TransitRouteAuditMap());
            modelBuilder.Configurations.Add(new TransitRouteLegMap());
            modelBuilder.Configurations.Add(new TransitRouteLegAuditMap());
            modelBuilder.Configurations.Add(new UnitMap());
            modelBuilder.Configurations.Add(new UnitConversionMap());
            modelBuilder.Configurations.Add(new UserMap());
            modelBuilder.Configurations.Add(new UserRoleMap());
            modelBuilder.Configurations.Add(new ValidationTypeMap());
            modelBuilder.Configurations.Add(new TimezoneMap());
            modelBuilder.Configurations.Add(new CapacityTradeViewMap());
            modelBuilder.Configurations.Add(new GasLocationGCVViewMap());
            modelBuilder.Configurations.Add(new GasTransitViewMap());
            modelBuilder.Configurations.Add(new GeminiCapacityTradeViewMap());
            modelBuilder.Configurations.Add(new GeminiDataUpdatedViewMap());
            modelBuilder.Configurations.Add(new ISISCapacityTradeViewMap());
            modelBuilder.Configurations.Add(new LocationMappingViewMap());
            modelBuilder.Configurations.Add(new LocationViewMap());
            modelBuilder.Configurations.Add(new MultiLegCapacityTradeMappingMap());
            modelBuilder.Configurations.Add(new NetworkViewMap());
            modelBuilder.Configurations.Add(new NominationMessagesViewMap());
            modelBuilder.Configurations.Add(new PhysicalTradeViewMap());
            modelBuilder.Configurations.Add(new PipelineViewMap());
            modelBuilder.Configurations.Add(new PositionAdjustViewMap());
            modelBuilder.Configurations.Add(new TimezoneViewMap());
            modelBuilder.Configurations.Add(new TradeCancellationViewMap());
            modelBuilder.Configurations.Add(new UkLocationMappingViewMap());
            modelBuilder.Configurations.Add(new UnitConversionViewMap());
            modelBuilder.Configurations.Add(new UserRolesViewMap());
            modelBuilder.Configurations.Add(new vw_Nomination_AllMap());
            modelBuilder.Configurations.Add(new vw_NominationShipper_AllMap());
            modelBuilder.Configurations.Add(new vw_NominationVolumes_AllMap());
        }
    }
}
