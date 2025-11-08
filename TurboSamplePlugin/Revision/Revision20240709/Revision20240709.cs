using System;
using System.Collections.Generic;
using Turbo.Networking.Abstractions.Revisions;
using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Advertisement;
using Turbo.Primitives.Messages.Outgoing.Availability;
using Turbo.Primitives.Messages.Outgoing.Avatar;
using Turbo.Primitives.Messages.Outgoing.Callforhelp;
using Turbo.Primitives.Messages.Outgoing.Camera;
using Turbo.Primitives.Messages.Outgoing.Campaign;
using Turbo.Primitives.Messages.Outgoing.Catalog;
using Turbo.Primitives.Messages.Outgoing.FriendList;
using Turbo.Primitives.Messages.Outgoing.Handshake;
using Turbo.Primitives.Messages.Outgoing.Navigator;
using Turbo.Primitives.Messages.Outgoing.NewNavigator;
using Turbo.Primitives.Messages.Outgoing.Room.Action;
using Turbo.Primitives.Messages.Outgoing.Room.Bots;
using Turbo.Primitives.Messages.Outgoing.Room.Chat;
using Turbo.Primitives.Messages.Outgoing.Room.Engine;
using Turbo.Primitives.Messages.Outgoing.Room.Furniture;
using Turbo.Primitives.Messages.Outgoing.Room.Layout;
using Turbo.Primitives.Messages.Outgoing.Room.Permissions;
using Turbo.Primitives.Messages.Outgoing.Room.Pets;
using Turbo.Primitives.Messages.Outgoing.Room.Session;
using Turbo.Primitives.Messages.Outgoing.Tracking;
using Turbo.Primitives.Messages.Outgoing.Users;
using TurboSamplePlugin.Revision.Revision20240709.Parsers.Catalog;
using TurboSamplePlugin.Revision.Revision20240709.Parsers.Collectibles;
using TurboSamplePlugin.Revision.Revision20240709.Parsers.Competition;
using TurboSamplePlugin.Revision.Revision20240709.Parsers.FriendList;
using TurboSamplePlugin.Revision.Revision20240709.Parsers.GroupForums;
using TurboSamplePlugin.Revision.Revision20240709.Parsers.Handshake;
using TurboSamplePlugin.Revision.Revision20240709.Parsers.Help;
using TurboSamplePlugin.Revision.Revision20240709.Parsers.Inventory;
using TurboSamplePlugin.Revision.Revision20240709.Parsers.Inventory.Badges;
using TurboSamplePlugin.Revision.Revision20240709.Parsers.Navigator;
using TurboSamplePlugin.Revision.Revision20240709.Parsers.NewNavigator;
using TurboSamplePlugin.Revision.Revision20240709.Parsers.Nft;
using TurboSamplePlugin.Revision.Revision20240709.Parsers.Preferences;
using TurboSamplePlugin.Revision.Revision20240709.Parsers.Room.Engine;
using TurboSamplePlugin.Revision.Revision20240709.Parsers.Room.Session;
using TurboSamplePlugin.Revision.Revision20240709.Parsers.RoomSettings;
using TurboSamplePlugin.Revision.Revision20240709.Parsers.Sound;
using TurboSamplePlugin.Revision.Revision20240709.Parsers.Tracking;
using TurboSamplePlugin.Revision.Revision20240709.Parsers.Users;
using TurboSamplePlugin.Revision.Revision20240709.Serializers.Advertisement;
using TurboSamplePlugin.Revision.Revision20240709.Serializers.Availability;
using TurboSamplePlugin.Revision.Revision20240709.Serializers.Avatar;
using TurboSamplePlugin.Revision.Revision20240709.Serializers.Callforhelp;
using TurboSamplePlugin.Revision.Revision20240709.Serializers.Camera;
using TurboSamplePlugin.Revision.Revision20240709.Serializers.Campaign;
using TurboSamplePlugin.Revision.Revision20240709.Serializers.Catalog;
using TurboSamplePlugin.Revision.Revision20240709.Serializers.FriendList;
using TurboSamplePlugin.Revision.Revision20240709.Serializers.Handshake;
using TurboSamplePlugin.Revision.Revision20240709.Serializers.Navigator;
using TurboSamplePlugin.Revision.Revision20240709.Serializers.NewNavigator;
using TurboSamplePlugin.Revision.Revision20240709.Serializers.Room.Action;
using TurboSamplePlugin.Revision.Revision20240709.Serializers.Room.Bots;
using TurboSamplePlugin.Revision.Revision20240709.Serializers.Room.Chat;
using TurboSamplePlugin.Revision.Revision20240709.Serializers.Room.Engine;
using TurboSamplePlugin.Revision.Revision20240709.Serializers.Room.Furniture;
using TurboSamplePlugin.Revision.Revision20240709.Serializers.Room.Layout;
using TurboSamplePlugin.Revision.Revision20240709.Serializers.Room.Permissions;
using TurboSamplePlugin.Revision.Revision20240709.Serializers.Room.Pets;
using TurboSamplePlugin.Revision.Revision20240709.Serializers.Room.Session;
using TurboSamplePlugin.Revision.Revision20240709.Serializers.Tracking;
using TurboSamplePlugin.Revision.Revision20240709.Serializers.Users;

namespace TurboSamplePlugin.Revision.Revision20240709;

public class Revision20240709 : IRevision
{
    public string Revision => "WIN63-202407091256-704579380";

    #region Incoming
    public IDictionary<int, IParser> Parsers { get; } =
        new Dictionary<int, IParser>
        {
            #region Catalog
            {
                MessageEvent.BuildersClubPlaceRoomItemMessageEvent,
                new BuildersClubPlaceRoomItemParser()
            },
            {
                MessageEvent.BuildersClubPlaceWallItemMessageEvent,
                new BuildersClubPlaceWallItemParser()
            },
            {
                MessageEvent.BuildersClubQueryFurniCountMessageEvent,
                new BuildersClubQueryFurniCountParser()
            },
            // charge firework?
            { MessageEvent.GetBonusRareInfoMessageEvent, new GetBonusRareInfoParser() },
            { MessageEvent.GetBundleDiscountRulesetEvent, new GetBundleDiscountRulesetParser() },
            { MessageEvent.GetCatalogIndexEvent, new GetCatalogIndexParser() },
            { MessageEvent.GetCatalogPageEvent, new GetCatalogPageParser() },
            {
                MessageEvent.GetCatalogPageWithEarliestExpiryEvent,
                new GetCatalogPageWithEarliestExpiryParser()
            },
            { MessageEvent.GetClubGiftMessageEvent, new GetClubGiftParser() },
            { MessageEvent.GetClubOffersMessageEvent, new GetClubOffersParser() },
            {
                MessageEvent.GetGiftWrappingConfigurationEvent,
                new GetGiftWrappingConfigurationParser()
            },
            {
                MessageEvent.GetHabboClubExtendOfferMessageEvent,
                new GetHabboClubExtendOfferParser()
            },
            { MessageEvent.GetIsOfferGiftableEvent, new GetIsOfferGiftableParser() },
            {
                MessageEvent.GetLimitedOfferAppearingNextEvent,
                new GetLimitedOfferAppearingNextParser()
            },
            { MessageEvent.GetNextTargetedOfferEvent, new GetNextTargetedOfferParser() },
            { MessageEvent.GetProductOfferEvent, new GetProductOfferParser() },
            { MessageEvent.GetRoomAdPurchaseInfoEvent, new GetRoomAdPurchaseInfoParser() },
            {
                MessageEvent.GetSeasonalCalendarDailyEvent,
                new GetSeasonalCalendarDailyOfferParser()
            },
            { MessageEvent.GetSellablePetPalettesEvent, new GetSellablePetPalettesParser() },
            {
                MessageEvent.MarkCatalogNewAdditionsPageOpenedEvent,
                new MarkCatalogNewAdditionsPageOpenedParser()
            },
            {
                MessageEvent.PurchaseBasicMembershipExtensionEvent,
                new PurchaseBasicMembershipExtensionParser()
            },
            { MessageEvent.PurchaseFromCatalogAsGiftEvent, new PurchaseFromCatalogAsGiftParser() },
            { MessageEvent.PurchaseFromCatalogEvent, new PurchaseFromCatalogParser() },
            { MessageEvent.PurchaseRoomAdMessageEvent, new PurchaseRoomAdParser() },
            { MessageEvent.PurchaseTargetedOfferEvent, new PurchaseTargetedOfferParser() },
            {
                MessageEvent.PurchaseVipMembershipExtensionEvent,
                new PurchaseVipMembershipExtensionParser()
            },
            { MessageEvent.RedeemVoucherMessageEvent, new RedeemVoucherParser() },
            { MessageEvent.RoomAdPurchaseInitiatedEvent, new RoomAdPurchaseInitiatedParser() },
            { MessageEvent.SelectClubGiftEvent, new SelectClubGiftParser() },
            { MessageEvent.SetTargetedOfferStateEvent, new SetTargetedOfferStateParser() },
            { MessageEvent.ShopTargetedOfferViewedEvent, new ShopTargetedOfferViewedParser() },
            #endregion

            #region Collectibles
            { MessageEvent.GetNftTransferFeeMessageEvent, new GetNftTransferFeeMessageParser() },
            #endregion

            #region Competition
            {
                MessageEvent.GetCurrentTimingCodeMessageEvent,
                new GetCurrentTimingCodeMessageParser()
            },
            #endregion

            #region FriendList
            { MessageEvent.AcceptFriendMessageEvent, new AcceptFriendMessageParser() },
            { MessageEvent.DeclineFriendMessageEvent, new DeclineFriendMessageParser() },
            { MessageEvent.FindNewFriendsMessageEvent, new FindNewFriendsMessageParser() },
            { MessageEvent.FollowFriendMessageEvent, new FollowFriendMessageParser() },
            { MessageEvent.FriendListUpdateMessageEvent, new FriendListUpdateMessageParser() },
            { MessageEvent.GetFriendRequestsMessageEvent, new GetFriendRequestsMessageParser() },
            { MessageEvent.GetMessengerHistoryEvent, new GetMessengerHistoryParser() },
            { MessageEvent.HabboSearchMessageEvent, new HabboSearchMessageParser() },
            { MessageEvent.MessengerInitMessageEvent, new MessengerInitMessageParser() },
            { MessageEvent.RemoveFriendMessageEvent, new RemoveFriendMessageParser() },
            { MessageEvent.RequestFriendMessageEvent, new RequestFriendMessageParser() },
            { MessageEvent.SendMsgMessageEvent, new SendMsgMessageParser() },
            { MessageEvent.SendRoomInviteMessageEvent, new SendRoomInviteMessageParser() },
            { MessageEvent.VisitUserMessageEvent, new VisitUserMessageParser() },
            #endregion

            #region GroupForums
            {
                MessageEvent.GetUnreadForumsCountMessageEvent,
                new GetUnreadForumsCountMessageParser()
            },
            #endregion

            #region Handshake
            {
                MessageEvent.CompleteDiffieHandshakeMessageEvent,
                new CompleteDiffieHandshakeMessageParser()
            },
            { MessageEvent.DisconnectMessageEvent, new DisconnectMessageParser() },
            { MessageEvent.InfoRetrieveMessageEvent, new InfoRetrieveMessageParser() },
            {
                MessageEvent.InitDiffieHandshakeMessageEvent,
                new InitDiffieHandshakeMessageParser()
            },
            { MessageEvent.SSOTicketMessageEvent, new SSOTicketMessageParser() },
            { MessageEvent.UniqueIDMessageEvent, new UniqueIdMessageParser() },
            { MessageEvent.VersionCheckMessageEvent, new VersionCheckMessageParser() },
            #endregion

            #region Help
            { MessageEvent.GetCfhStatusMessageEvent, new GetCfhStatusParser() },
            #endregion

            #region Inventory
            { MessageEvent.GetCreditsInfoEvent, new GetCreditsInfoParser() },
            #region Badges
            { MessageEvent.GetBadgePointLimitsEvent, new GetBadgePointLimitsMessageParser() },
            { MessageEvent.GetBadgesEvent, new GetBadgesMessageParser() },
            #endregion

            #endregion

            #region Navigator
            { MessageEvent.AddFavouriteRoomMessageEvent, new AddFavouriteRoomParser() },
            { MessageEvent.CancelEventMessageEvent, new CancelEventParser() },
            { MessageEvent.CanCreateRoomMessageEvent, new CanCreateRoomParser() },
            { MessageEvent.CompetitionRoomsSearchMessageEvent, new CompetitionRoomsSearchParser() },
            { MessageEvent.ConvertGlobalRoomIdMessageEvent, new ConvertGlobalRoomIdParser() },
            { MessageEvent.CreateFlatMessageEvent, new CreateFlatParser() },
            { MessageEvent.DeleteFavouriteRoomMessageEvent, new DeleteFavouriteRoomParser() },
            { MessageEvent.EditEventMessageEvent, new EditEventParser() },
            {
                MessageEvent.ForwardToARandomPromotedRoomMessageEvent,
                new ForwardToARandomPromotedRoomParser()
            },
            { MessageEvent.ForwardToSomeRoomMessageEvent, new ForwardToSomeRoomParser() },
            { MessageEvent.GetGuestRoomMessageEvent, new GetGuestRoomParser() },
            { MessageEvent.GetOfficialRoomsMessageEvent, new GetOfficialRoomsParser() },
            { MessageEvent.GetPopularRoomTagsMessageEvent, new GetPopularRoomTagsParser() },
            { MessageEvent.GetUserEventCatsMessageEvent, new GetUserEventCatsParser() },
            { MessageEvent.GetUserFlatCatsMessageEvent, new GetUserFlatCatsParser() },
            { MessageEvent.GuildBaseSearchMessageEvent, new GuildBaseSearchParser() },
            { MessageEvent.MyFavouriteRoomsSearchMessageEvent, new MyFavouriteRoomsSearchParser() },
            {
                MessageEvent.MyFrequentRoomHistorySearchMessageEvent,
                new MyFrequentRoomHistorySearchParser()
            },
            { MessageEvent.MyFriendsRoomsSearchMessageEvent, new MyFriendsRoomsSearchParser() },
            { MessageEvent.MyGuildBasesSearchMessageEvent, new MyGuildBasesSearchParser() },
            { MessageEvent.MyRecommendedRoomsMessageEvent, new MyRecommendedRoomsParser() },
            { MessageEvent.MyRoomHistorySearchMessageEvent, new MyRoomHistorySearchParser() },
            { MessageEvent.MyRoomRightsSearchMessageEvent, new MyRoomRightsSearchParser() },
            { MessageEvent.MyRoomsSearchMessageEvent, new MyRoomsSearchParser() },
            { MessageEvent.PopularRoomsSearchMessageEvent, new PopularRoomsSearchParser() },
            { MessageEvent.RateFlatMessageEvent, new RateFlatParser() },
            {
                MessageEvent.RemoveOwnRoomRightsRoomMessageEvent,
                new RemoveOwnRoomRightsRoomParser()
            },
            { MessageEvent.RoomAdEventTabAdClickedEvent, new RoomAdEventTabAdClickedParser() },
            { MessageEvent.RoomAdEventTabViewedEvent, new RoomAdEventTabViewedParser() },
            { MessageEvent.RoomAdSearchMessageEvent, new RoomAdSearchParser() },
            {
                MessageEvent.RoomsWhereMyFriendsAreSearchMessageEvent,
                new RoomsWhereMyFriendsAreSearchParser()
            },
            {
                MessageEvent.RoomsWithHighestScoreSearchMessageEvent,
                new RoomsWithHighestScoreSearchParser()
            },
            { MessageEvent.RoomTextSearchMessageEvent, new RoomTextSearchParser() },
            { MessageEvent.SetRoomSessionTagsMessageEvent, new SetRoomSessionTagsParser() },
            { MessageEvent.ToggleStaffPickMessageEvent, new ToggleStaffPickParser() },
            { MessageEvent.UpdateHomeRoomMessageEvent, new UpdateHomeRoomParser() },
            #endregion

            #region NewNavigator
            {
                MessageEvent.NavigatorAddCollapsedCategoryMessageEvent,
                new NavigatorAddCollapsedCategoryParser()
            },
            { MessageEvent.NavigatorAddSavedSearchEvent, new NavigatorAddSavedSearchParser() },
            {
                MessageEvent.NavigatorDeleteSavedSearchEvent,
                new NavigatorDeleteSavedSearchParser()
            },
            {
                MessageEvent.NavigatorRemoveCollapsedCategoryMessageEvent,
                new NavigatorRemoveCollapsedCategoryParser()
            },
            {
                MessageEvent.NavigatorSetSearchCodeViewModeMessageEvent,
                new NavigatorSetSearchCodeViewModeParser()
            },
            { MessageEvent.NewNavigatorInitEvent, new NewNavigatorInitParser() },
            { MessageEvent.NewNavigatorSearchEvent, new NewNavigatorSearchParser() },
            #endregion

            #region Nft
            { MessageEvent.GetNftCreditsMessageEvent, new GetNftCreditsMessageParser() },
            { MessageEvent.GetSilverMessageEvent, new GetSilverMessageParser() },
            #endregion

            #region Preferences
            {
                MessageEvent.SetNewNavigatorWindowPreferencesMessageEvent,
                new SetNewNavigatorWindowPreferencesParser()
            },
            #endregion

            #region Room
            { MessageEvent.GetFurnitureAliasesMessageEvent, new GetFurnitureAliasesParser() },
            { MessageEvent.GetHeightMapMessageEvent, new GetHeightMapParser() },
            { MessageEvent.OpenFlatConnectionMessageEvent, new OpenFlatConnectionParser() },
            #endregion

            #region RoomSettings
            { MessageEvent.DeleteRoomMessageEvent, new DeleteRoomParser() },
            { MessageEvent.GetBannedUsersFromRoomMessageEvent, new GetBannedUsersFromRoomParser() },
            { MessageEvent.GetCustomRoomFilterMessageEvent, new GetCustomRoomFilterParser() },
            { MessageEvent.GetFlatControllersMessageEvent, new GetFlatControllersParser() },
            { MessageEvent.GetRoomSettingsMessageEvent, new GetRoomSettingsParser() },
            { MessageEvent.SaveRoomSettingsMessageEvent, new SaveRoomSettingsParser() },
            {
                MessageEvent.UpdateRoomCategoryAndTradeSettingsEvent,
                new UpdateRoomCategoryAndTradeSettingsParser()
            },
            { MessageEvent.UpdateRoomFilterMessageEvent, new UpdateRoomFilterParser() },
            #endregion

            #region Sound
            { MessageEvent.GetSoundSettingsEvent, new GetSoundSettingsMessageParser() },
            #endregion

            #region Tracking
            { MessageEvent.EventLogMessageEvent, new EventLogParser() },
            { MessageEvent.LagWarningReportMessageEvent, new LagWarningReportParser() },
            { MessageEvent.LatencyPingReportMessageEvent, new LatencyPingReportParser() },
            { MessageEvent.LatencyPingRequestMessageEvent, new LatencyPingRequestParser() },
            { MessageEvent.PerformanceLogMessageEvent, new PerformanceLogParser() },
            #endregion

            #region Users
            { MessageEvent.GetIgnoredUsersMessageEvent, new GetIgnoredUsersParser() },
            { MessageEvent.GetMOTDMessageEvent, new GetMOTDParser() },
            { MessageEvent.GetUserNftChatStylesMessageEvent, new GetUserNftChatStylesParser() },
            { MessageEvent.ScrGetUserInfoMessageEvent, new ScrGetUserInfoMessageParser() },
            #endregion
        };
    #endregion

    #region Outgoing
    public IDictionary<Type, ISerializer> Serializers { get; } =
        new Dictionary<Type, ISerializer>
        {
            #region Advertisement
            {
                typeof(InterstitialMessageComposer),
                new InterstitialMessageComposerSerializer(
                    MessageComposer.InterstitialMessageComposer
                )
            },
            {
                typeof(RoomAdErrorEventMessageComposer),
                new RoomAdErrorEventMessageComposerSerializer(MessageComposer.RoomAdErrorComposer)
            },
            #endregion

            #region Availability
            {
                typeof(AvailabilityStatusMessageComposer),
                new AvailabilityStatusMessageComposerSerializer(
                    MessageComposer.AvailabilityStatusMessageComposer
                )
            },
            {
                typeof(InfoHotelClosedMessageComposer),
                new InfoHotelClosedMessageComposerSerializer(
                    MessageComposer.InfoHotelClosedMessageComposer
                )
            },
            {
                typeof(InfoHotelClosingMessageComposer),
                new InfoHotelClosingMessageComposerSerializer(
                    MessageComposer.InfoHotelClosingMessageComposer
                )
            },
            {
                typeof(LoginFailedHotelClosedMessageComposer),
                new LoginFailedHotelClosedMessageComposerSerializer(
                    MessageComposer.LoginFailedHotelClosedMessageComposer
                )
            },
            {
                typeof(MaintenanceStatusMessageComposer),
                new MaintenanceStatusMessageComposerSerializer(
                    MessageComposer.MaintenanceStatusMessageComposer
                )
            },
            #endregion

            #region Avatar
            {
                typeof(ChangeUserNameResultMessageComposer),
                new ChangeUserNameResultMessageComposerSerializer(
                    MessageComposer.ChangeUserNameResultMessageComposer
                )
            },
            {
                typeof(CheckUserNameResultMessageComposer),
                new CheckUserNameResultMessageComposerSerializer(
                    MessageComposer.CheckUserNameResultMessageComposer
                )
            },
            {
                typeof(FigureUpdateEventMessageComposer),
                new FigureUpdateEventMessageComposerSerializer(MessageComposer.FigureUpdateComposer)
            },
            {
                typeof(WardrobeMessageComposer),
                new WardrobeMessageComposerSerializer(MessageComposer.WardrobeMessageComposer)
            },
            #endregion

            #region Callforhelp
            {
                typeof(CfhSanctionMessageComposer),
                new CfhSanctionMessageComposerSerializer(MessageComposer.CfhSanctionMessageComposer)
            },
            {
                typeof(CfhTopicsInitMessageComposer),
                new CfhTopicsInitMessageComposerSerializer(
                    MessageComposer.CfhTopicsInitMessageComposer
                )
            },
            {
                typeof(SanctionStatusEventMessageComposer),
                new SanctionStatusEventMessageComposerSerializer(
                    MessageComposer.SanctionStatusComposer
                )
            },
            #endregion

            #region Camera
            {
                typeof(CameraPublishStatusMessageComposer),
                new CameraPublishStatusMessageComposerSerializer(
                    MessageComposer.CameraPublishStatusMessageComposer
                )
            },
            {
                typeof(CameraPurchaseOKMessageComposer),
                new CameraPurchaseOKMessageComposerSerializer(
                    MessageComposer.CameraPurchaseOKMessageComposer
                )
            },
            {
                typeof(CameraStorageUrlMessageComposer),
                new CameraStorageUrlMessageComposerSerializer(
                    MessageComposer.CameraStorageUrlMessageComposer
                )
            },
            {
                typeof(CompetitionStatusMessageComposer),
                new CompetitionStatusMessageComposerSerializer(
                    MessageComposer.CompetitionStatusMessageComposer
                )
            },
            {
                typeof(InitCameraMessageComposer),
                new InitCameraMessageComposerSerializer(MessageComposer.InitCameraMessageComposer)
            },
            {
                typeof(ThumbnailStatusMessageComposer),
                new ThumbnailStatusMessageComposerSerializer(
                    MessageComposer.ThumbnailStatusMessageComposer
                )
            },
            #endregion

            #region Campaign
            {
                typeof(CampaignCalendarDataMessageComposer),
                new CampaignCalendarDataMessageComposerSerializer(
                    MessageComposer.CampaignCalendarDataMessageComposer
                )
            },
            {
                typeof(CampaignCalendarDoorOpenedMessageComposer),
                new CampaignCalendarDataMessageComposerSerializer(
                    MessageComposer.CampaignCalendarDoorOpenedMessageComposer
                )
            },
            #endregion

            #region Catalog
            {
                typeof(BonusRareInfoMessageComposer),
                new BonusRareInfoMessageComposerSerializer(
                    MessageComposer.BonusRareInfoMessageComposer
                )
            },
            {
                typeof(BuildersClubSubscriptionStatusMessageComposer),
                new BuildersClubSubscriptionStatusMessageComposerSerializer(
                    MessageComposer.BuildersClubSubscriptionStatusMessageComposer
                )
            },
            {
                typeof(BundleDiscountRulesetMessageComposer),
                new BundleDiscountRulesetMessageComposerSerializer(
                    MessageComposer.BundleDiscountRulesetMessageComposer
                )
            },
            {
                typeof(CatalogIndexMessageComposer),
                new CatalogIndexMessageComposerSerializer(
                    MessageComposer.CatalogIndexMessageComposer
                )
            },
            {
                typeof(CatalogPageMessageComposer),
                new CatalogPageMessageComposerSerializer(MessageComposer.CatalogPageMessageComposer)
            },
            {
                typeof(CatalogPageWithEarliestExpiryMessageComposer),
                new CatalogPageWithEarliestExpiryMessageComposerSerializer(
                    MessageComposer.CatalogPageWithEarliestExpiryMessageComposer
                )
            },
            {
                typeof(CatalogPublishedMessageComposer),
                new CatalogPublishedMessageComposerSerializer(
                    MessageComposer.CatalogPublishedMessageComposer
                )
            },
            {
                typeof(ClubGiftInfoEventMessageComposer),
                new ClubGiftInfoEventMessageComposerSerializer(MessageComposer.ClubGiftInfoComposer)
            },
            {
                typeof(ClubGiftSelectedEventMessageComposer),
                new ClubGiftSelectedEventMessageComposerSerializer(
                    MessageComposer.ClubGiftSelectedComposer
                )
            },
            {
                typeof(GiftReceiverNotFoundEventMessageComposer),
                new GiftReceiverNotFoundEventMessageComposerSerializer(
                    MessageComposer.GiftReceiverNotFoundComposer
                )
            },
            {
                typeof(GiftWrappingConfigurationEventMessageComposer),
                new GiftWrappingConfigurationEventMessageComposerSerializer(
                    MessageComposer.GiftWrappingConfigurationComposer
                )
            },
            {
                typeof(HabboClubExtendOfferMessageComposer),
                new HabboClubExtendOfferMessageComposerSerializer(
                    MessageComposer.HabboClubExtendOfferMessageComposer
                )
            },
            {
                typeof(HabboClubOffersMessageComposer),
                new HabboClubOffersMessageComposerSerializer(
                    MessageComposer.HabboClubOffersMessageComposer
                )
            },
            {
                typeof(LimitedEditionSoldOutEventMessageComposer),
                new LimitedEditionSoldOutEventMessageComposerSerializer(
                    MessageComposer.LimitedEditionSoldOutComposer
                )
            },
            {
                typeof(LimitedOfferAppearingNextMessageComposer),
                new LimitedOfferAppearingNextMessageComposerSerializer(
                    MessageComposer.LimitedOfferAppearingNextMessageComposer
                )
            },
            {
                typeof(NotEnoughBalanceMessageComposer),
                new NotEnoughBalanceMessageComposerSerializer(
                    MessageComposer.NotEnoughBalanceMessageComposer
                )
            },
            {
                typeof(ProductOfferEventMessageComposer),
                new ProductOfferEventMessageComposerSerializer(MessageComposer.ProductOfferComposer)
            },
            {
                typeof(PurchaseErrorMessageComposer),
                new PurchaseErrorMessageComposerSerializer(
                    MessageComposer.PurchaseErrorMessageComposer
                )
            },
            {
                typeof(PurchaseNotAllowedMessageComposer),
                new PurchaseNotAllowedMessageComposerSerializer(
                    MessageComposer.PurchaseNotAllowedMessageComposer
                )
            },
            {
                typeof(PurchaseOKMessageComposer),
                new PurchaseOKMessageComposerSerializer(MessageComposer.PurchaseOKMessageComposer)
            },
            {
                typeof(RoomAdPurchaseInfoEventMessageComposer),
                new RoomAdPurchaseInfoEventMessageComposerSerializer(
                    MessageComposer.RoomAdPurchaseInfoComposer
                )
            },
            {
                typeof(SeasonalCalendarDailyOfferMessageComposer),
                new SeasonalCalendarDailyOfferMessageComposerSerializer(
                    MessageComposer.SeasonalCalendarDailyOfferMessageComposer
                )
            },
            {
                typeof(SellablePetPalettesMessageComposer),
                new SellablePetPalettesMessageComposerSerializer(
                    MessageComposer.SellablePetPalettesMessageComposer
                )
            },
            {
                typeof(SnowWarGameTokensMessageMessageComposer),
                new SnowWarGameTokensMessageMessageComposerSerializer(
                    MessageComposer.SnowWarGameTokensMessageComposer
                )
            },
            {
                typeof(TargetedOfferEventMessageComposer),
                new TargetedOfferEventMessageComposerSerializer(
                    MessageComposer.TargetedOfferComposer
                )
            },
            {
                typeof(TargetedOfferNotFoundEventMessageComposer),
                new TargetedOfferNotFoundEventMessageComposerSerializer(
                    MessageComposer.TargetedOfferNotFoundComposer
                )
            },
            {
                typeof(VoucherRedeemErrorMessageComposer),
                new VoucherRedeemErrorMessageComposerSerializer(
                    MessageComposer.VoucherRedeemErrorMessageComposer
                )
            },
            {
                typeof(VoucherRedeemOkMessageComposer),
                new VoucherRedeemOkMessageComposerSerializer(
                    MessageComposer.VoucherRedeemOkMessageComposer
                )
            },
            #endregion

            #region FriendList
            {
                typeof(AcceptFriendResultMessage),
                new AcceptFriendResultMessageSerializer(MessageComposer.AcceptFriendResultComposer)
            },
            {
                typeof(ConsoleMessageHistoryMessage),
                new ConsoleMessageHistoryMessageSerializer(
                    MessageComposer.ConsoleMessageHistoryComposer
                )
            },
            {
                typeof(FollowFriendFailedMessage),
                new FollowFriendFailedMessageSerializer(MessageComposer.FollowFriendFailedComposer)
            },
            {
                typeof(FriendListFragmentMessage),
                new FriendListFragmentMessageSerializer(
                    MessageComposer.FriendListFragmentMessageComposer
                )
            },
            {
                typeof(FriendListUpdateMessage),
                new FriendListUpdateMessageSerializer(MessageComposer.FriendListUpdateComposer)
            },
            {
                typeof(FriendNotificationMessage),
                new FriendNotificationMessageSerializer(MessageComposer.FriendNotificationComposer)
            },
            {
                typeof(FriendRequestsMessage),
                new FriendRequestsMessageSerializer(MessageComposer.FriendRequestsComposer)
            },
            {
                typeof(HabboSearchResultMessage),
                new HabboSearchResultMessageSerializer(MessageComposer.HabboSearchResultComposer)
            },
            {
                typeof(InstantMessageErrorMessage),
                new InstantMessageErrorMessageSerializer(
                    MessageComposer.InstantMessageErrorComposer
                )
            },
            {
                typeof(MessengerErrorMessage),
                new MessengerErrorMessageSerializer(MessageComposer.MessengerErrorComposer)
            },
            {
                typeof(MessengerInitMessageComposer),
                new MessengerInitMessageSerializer(MessageComposer.MessengerInitComposer)
            },
            {
                typeof(MiniMailNewMessage),
                new MiniMailNewMessageSerializer(MessageComposer.MiniMailNewMessageComposer)
            },
            {
                typeof(MiniMailUnreadCountMessage),
                new MiniMailUnreadCountMessageSerializer(
                    MessageComposer.MiniMailUnreadCountComposer
                )
            },
            {
                typeof(NewConsoleMessageMessage),
                new NewConsoleMessageMessageSerializer(MessageComposer.NewConsoleMessageComposer)
            },
            {
                typeof(NewFriendRequestMessage),
                new NewFriendRequestMessageSerializer(MessageComposer.NewFriendRequestComposer)
            },
            {
                typeof(RoomInviteErrorMessage),
                new RoomInviteErrorMessageSerializer(MessageComposer.RoomInviteErrorComposer)
            },
            {
                typeof(RoomInviteMessage),
                new RoomInviteMessageSerializer(MessageComposer.RoomInviteComposer)
            },
            #endregion

            #region Handshake
            {
                typeof(AuthenticationOKMessage),
                new AuthenticationOKMessageSerializer(
                    MessageComposer.AuthenticationOKMessageComposer
                )
            },
            {
                typeof(CompleteDiffieHandshakeMessageComposer),
                new CompleteDiffieHandshakeMessageSerializer(
                    MessageComposer.CompleteDiffieHandshakeComposer
                )
            },
            {
                typeof(GenericErrorMessage),
                new GenericErrorMessageSerializer(MessageComposer.GenericErrorComposer)
            },
            {
                typeof(InitDiffieHandshakeMessageComposer),
                new InitDiffieHandshakeMessageSerializer(
                    MessageComposer.InitDiffieHandshakeComposer
                )
            },
            {
                typeof(IsFirstLoginOfDayMessage),
                new IsFirstLoginOfDayMessageSerializer(MessageComposer.IsFirstLoginOfDayComposer)
            },
            {
                typeof(NoobnessLevelMessage),
                new NoobnessLevelMessageSerializer(MessageComposer.NoobnessLevelMessageComposer)
            },
            { typeof(PingMessage), new PingMessageSerializer(MessageComposer.PingMessageComposer) },
            {
                typeof(UniqueMachineIdMessage),
                new UniqueMachineIdMessageSerializer(MessageComposer.UniqueMachineIDComposer)
            },
            {
                typeof(UserObjectMessage),
                new UserObjectMessageSerializer(MessageComposer.UserObjectComposer)
            },
            {
                typeof(UserRightsMessage),
                new UserRightsMessageSerializer(MessageComposer.UserRightsMessageComposer)
            },
            #endregion

            #region Navigator
            {
                typeof(CanCreateRoomEventMessageComposer),
                new CanCreateRoomEventMessageComposerSerializer(
                    MessageComposer.CanCreateRoomEventComposer
                )
            },
            {
                typeof(CanCreateRoomMessageComposer),
                new CanCreateRoomMessageComposerSerializer(MessageComposer.CanCreateRoomComposer)
            },
            {
                typeof(CategoriesWithVisitorCountMessageComposer),
                new CategoriesWithVisitorCountMessageComposerSerializer(
                    MessageComposer.CategoriesWithVisitorCountComposer
                )
            },
            {
                typeof(CompetitionRoomsDataMessageComposer),
                new CompetitionRoomsDataMessageComposerSerializer(
                    MessageComposer.CompetitionRoomsDataMessageComposer
                )
            },
            {
                typeof(ConvertedRoomIdMessageComposer),
                new ConvertedRoomIdMessageComposerSerializer(
                    MessageComposer.ConvertedRoomIdComposer
                )
            },
            {
                typeof(DoorbellMessageComposer),
                new DoorbellMessageComposerSerializer(MessageComposer.DoorbellMessageComposer)
            },
            {
                typeof(FavouriteChangedMessageComposer),
                new FavouriteChangedMessageComposerSerializer(
                    MessageComposer.FavouriteChangedComposer
                )
            },
            {
                typeof(FavouritesMessage),
                new FavouritesMessageSerializer(MessageComposer.FavouritesComposer)
            },
            {
                typeof(FlatAccessDeniedMessageComposer),
                new FlatAccessDeniedMessageComposerSerializer(
                    MessageComposer.FlatAccessDeniedMessageComposer
                )
            },
            {
                typeof(FlatCreatedMessageComposer),
                new FlatCreatedMessageComposerSerializer(MessageComposer.FlatCreatedComposer)
            },
            {
                typeof(GetGuestRoomResultMessageComposer),
                new GetGuestRoomResultMessageComposerSerializer(
                    MessageComposer.GetGuestRoomResultComposer
                )
            },
            {
                typeof(GuestRoomSearchResultMessageComposer),
                new GuestRoomSearchResultMessageComposerSerializer(
                    MessageComposer.GuestRoomSearchResultComposer
                )
            },
            {
                typeof(NavigatorSettingsMessageComposer),
                new NavigatorSettingsMessageComposerSerializer(
                    MessageComposer.NavigatorSettingsComposer
                )
            },
            {
                typeof(OfficialRoomsMessageComposer),
                new OfficialRoomsMessageComposerSerializer(MessageComposer.OfficialRoomsComposer)
            },
            {
                typeof(PopularRoomTagsResultMessageComposer),
                new PopularRoomTagsResultMessageComposerSerializer(
                    MessageComposer.PopularRoomTagsResultComposer
                )
            },
            {
                typeof(RoomEventCancelMessageComposer),
                new RoomEventCancelMessageComposerSerializer(
                    MessageComposer.RoomEventCancelComposer
                )
            },
            {
                typeof(RoomEventMessageComposer),
                new RoomEventMessageComposerSerializer(MessageComposer.RoomEventComposer)
            },
            {
                typeof(RoomInfoUpdatedMessageComposer),
                new RoomInfoUpdatedMessageComposerSerializer(
                    MessageComposer.RoomInfoUpdatedComposer
                )
            },
            {
                typeof(RoomRatingMessageComposer),
                new RoomRatingMessageComposerSerializer(MessageComposer.RoomRatingComposer)
            },
            {
                typeof(UserEventCatsMessageComposer),
                new UserEventCatsMessageComposerSerializer(MessageComposer.UserEventCatsComposer)
            },
            {
                typeof(UserFlatCatsMessageComposer),
                new UserFlatCatsMessageComposerSerializer(MessageComposer.UserFlatCatsComposer)
            },
            #endregion

            #region NewNavigator
            {
                typeof(NavigatorCollapsedCategoriesMessage),
                new NavigatorCollapsedCategoriesMessageSerializer(
                    MessageComposer.NavigatorCollapsedCategoriesMessageComposer
                )
            },
            {
                typeof(NavigatorLiftedRoomsMessage),
                new NavigatorLiftedRoomsMessageSerializer(
                    MessageComposer.NavigatorLiftedRoomsComposer
                )
            },
            {
                typeof(NavigatorMetaDataMessage),
                new NavigatorMetaDataMessageSerializer(MessageComposer.NavigatorMetaDataComposer)
            },
            {
                typeof(NavigatorSavedSearchesMessage),
                new NavigatorSavedSearchesMessageSerializer(
                    MessageComposer.NavigatorSavedSearchesComposer
                )
            },
            {
                typeof(NavigatorSearchResultBlocksMessage),
                new NavigatorSearchResultBlocksMessageSerializer(
                    MessageComposer.NavigatorSearchResultBlocksComposer
                )
            },
            {
                typeof(NewNavigatorPreferencesMessage),
                new NewNavigatorPreferencesMessageSerializer(
                    MessageComposer.NewNavigatorPreferencesComposer
                )
            },
            #endregion

            #region Room

            #region Room Action
            {
                typeof(AvatarEffectMessageComposer),
                new AvatarEffectMessageComposerSerializer(
                    MessageComposer.AvatarEffectMessageComposer
                )
            },
            {
                typeof(CarryObjectMessageComposer),
                new CarryObjectMessageComposerSerializer(MessageComposer.CarryObjectMessageComposer)
            },
            {
                typeof(DanceMessageComposer),
                new DanceMessageComposerSerializer(MessageComposer.DanceMessageComposer)
            },
            {
                typeof(ExpressionMessageComposer),
                new ExpressionMessageComposerSerializer(MessageComposer.ExpressionMessageComposer)
            },
            {
                typeof(SleepMessageComposer),
                new SleepMessageComposerSerializer(MessageComposer.SleepMessageComposer)
            },
            {
                typeof(UseObjectMessageComposer),
                new UseObjectMessageComposerSerializer(MessageComposer.UseObjectMessageComposer)
            },
            #endregion

            #region Room Bots
            {
                typeof(BotCommandConfigurationMessageComposer),
                new BotCommandConfigurationMessageComposerSerializer(
                    MessageComposer.BotCommandConfigurationComposer
                )
            },
            {
                typeof(BotErrorMessageComposer),
                new BotErrorMessageComposerSerializer(MessageComposer.BotErrorComposer)
            },
            {
                typeof(BotForceOpenContextMenuMessageComposerSerializer),
                new BotForceOpenContextMenuMessageComposerSerializer(
                    MessageComposer.BotForceOpenContextMenuComposer
                )
            },
            {
                typeof(BotSkillListUpdateMessageComposer),
                new BotSkillListUpdateMessageComposerSerializer(
                    MessageComposer.BotSkillListUpdateComposer
                )
            },
            #endregion

            #region Room Chat
            {
                typeof(ChatMessageComposer),
                new ChatMessageComposerSerializer(MessageComposer.ChatMessageComposer)
            },
            {
                typeof(FloodControlMessageComposer),
                new FloodControlMessageComposerSerializer(
                    MessageComposer.FloodControlMessageComposer
                )
            },
            {
                typeof(RemainingMutePeriodMessageComposer),
                new RemainingMutePeriodMessageComposerSerializer(
                    MessageComposer.RemainingMutePeriodComposer
                )
            },
            {
                typeof(RoomChatSettingsMessageComposer),
                new RoomChatSettingsMessageComposerSerializer(
                    MessageComposer.RoomChatSettingsMessageComposer
                )
            },
            {
                typeof(RoomFilterSettingsMessageComposer),
                new RoomFilterSettingsMessageComposerSerializer(
                    MessageComposer.RoomFilterSettingsMessageComposer
                )
            },
            {
                typeof(UserTypingMessageComposer),
                new UserTypingMessageComposerSerializer(MessageComposer.UserTypingMessageComposer)
            },
            #endregion

            #region Room Engine
            {
                typeof(BuildersClubPlacementWarningMessageComposer),
                new BuildersClubPlacementWarningMessageComposerSerializer(
                    MessageComposer.BuildersClubPlacementWarningMessageComposer
                )
            },
            {
                typeof(FavoriteMembershipUpdateMessageComposer),
                new FavoriteMembershipUpdateMessageComposerSerializer(
                    MessageComposer.FavoriteMembershipUpdateMessageComposer
                )
            },
            {
                typeof(FloorHeightMapMessageComposer),
                new FloorHeightMapMessageComposerSerializer(
                    MessageComposer.FloorHeightMapMessageComposer
                )
            },
            {
                typeof(FurnitureAliasesMessageComposer),
                new FurnitureAliasesMessageComposerSerializer(
                    MessageComposer.FurnitureAliasesMessageComposer
                )
            },
            {
                typeof(HeightMapMessageComposer),
                new HeightMapMessageComposerSerializer(MessageComposer.HeightMapMessageComposer)
            },
            {
                typeof(HeightMapUpdateMessageComposer),
                new HeightMapUpdateMessageComposerSerializer(
                    MessageComposer.HeightMapUpdateMessageComposer
                )
            },
            {
                typeof(ItemAddMessageComposer),
                new ItemAddMessageComposerSerializer(MessageComposer.ItemAddMessageComposer)
            },
            {
                typeof(ItemDataUpdateMessageComposer),
                new ItemDataUpdateMessageComposerSerializer(
                    MessageComposer.ItemDataUpdateMessageComposer
                )
            },
            {
                typeof(ItemRemoveMessageComposer),
                new ItemRemoveMessageComposerSerializer(MessageComposer.ItemRemoveMessageComposer)
            },
            {
                typeof(ItemsMessageComposer),
                new ItemsMessageComposerSerializer(MessageComposer.ItemsMessageComposer)
            },
            {
                typeof(ItemsStateUpdateMessageComposer),
                new ItemsStateUpdateMessageComposerSerializer(
                    MessageComposer.ItemsStateUpdateMessageComposer
                )
            },
            {
                typeof(ItemStateUpdateMessageComposer),
                new ItemStateUpdateMessageComposerSerializer(
                    MessageComposer.ItemStateUpdateMessageComposer
                )
            },
            {
                typeof(ItemUpdateMessageComposer),
                new ItemUpdateMessageComposerSerializer(MessageComposer.ItemUpdateMessageComposer)
            },
            {
                typeof(ObjectAddMessageComposer),
                new ObjectAddMessageComposerSerializer(MessageComposer.ObjectAddMessageComposer)
            },
            {
                typeof(ObjectDataUpdateMessageComposer),
                new ObjectDataUpdateMessageComposerSerializer(
                    MessageComposer.ObjectDataUpdateMessageComposer
                )
            },
            {
                typeof(ObjectRemoveConfirmMessageComposer),
                new ObjectRemoveConfirmMessageComposerSerializer(
                    MessageComposer.ObjectRemoveConfirmMessageComposer
                )
            },
            {
                typeof(ObjectRemoveMessageComposer),
                new ObjectRemoveMessageComposerSerializer(
                    MessageComposer.ObjectRemoveMessageComposer
                )
            },
            {
                typeof(ObjectRemoveMultipleMessageComposer),
                new ObjectRemoveMultipleMessageComposerSerializer(
                    MessageComposer.ObjectRemoveMultipleMessageComposer
                )
            },
            {
                typeof(ObjectsDataUpdateMessageComposer),
                new ObjectsDataUpdateMessageComposerSerializer(
                    MessageComposer.ObjectsDataUpdateMessageComposer
                )
            },
            {
                typeof(ObjectsMessageComposer),
                new ObjectsMessageComposerSerializer(MessageComposer.ObjectsMessageComposer)
            },
            {
                typeof(ObjectUpdateMessageComposer),
                new ObjectUpdateMessageComposerSerializer(
                    MessageComposer.ObjectUpdateMessageComposer
                )
            },
            {
                typeof(RoomEntryInfoMessageComposer),
                new RoomEntryInfoMessageComposerSerializer(
                    MessageComposer.RoomEntryInfoMessageComposer
                )
            },
            {
                typeof(RoomPropertyMessageComposer),
                new RoomPropertyMessageComposerSerializer(
                    MessageComposer.RoomPropertyMessageComposer
                )
            },
            {
                typeof(RoomVisualizationSettingsMessageComposer),
                new RoomVisualizationSettingsMessageComposerSerializer(
                    MessageComposer.RoomVisualizationSettingsComposer
                )
            },
            {
                typeof(SlideObjectBundleMessageComposer),
                new SlideObjectBundleMessageComposerSerializer(
                    MessageComposer.SlideObjectBundleMessageComposer
                )
            },
            {
                typeof(SpecialRoomEffectMessageComposer),
                new SpecialRoomEffectMessageComposerSerializer(
                    MessageComposer.SpecialRoomEffectMessageComposer
                )
            },
            {
                typeof(UserChangeMessageComposer),
                new UserChangeMessageComposerSerializer(MessageComposer.UserChangeMessageComposer)
            },
            {
                typeof(UserRemoveMessageComposer),
                new UserRemoveMessageComposerSerializer(MessageComposer.UserRemoveMessageComposer)
            },
            {
                typeof(UsersMessageComposer),
                new UsersMessageComposerSerializer(MessageComposer.UsersMessageComposer)
            },
            {
                typeof(UserUpdateMessageComposer),
                new UserUpdateMessageComposerSerializer(MessageComposer.UserUpdateMessageComposer)
            },
            {
                typeof(WiredMovementsMessageComposer),
                new WiredMovementsMessageComposerSerializer(
                    MessageComposer.WiredMovementsMessageComposer
                )
            },
            #endregion

            #region Room Furniture
            {
                typeof(AreaHideMessageComposer),
                new AreaHideMessageComposerSerializer(MessageComposer.AreaHideMessageComposer)
            },
            {
                typeof(CustomStackingHeightUpdateMessageComposer),
                new CustomStackingHeightUpdateMessageComposerSerializer(
                    MessageComposer.CustomStackingHeightUpdateMessageComposer
                )
            },
            {
                typeof(CustomUserNotificationMessageComposer),
                new CustomUserNotificationMessageComposerSerializer(
                    MessageComposer.CustomUserNotificationMessageComposer
                )
            },
            {
                typeof(DiceValueMessageComposer),
                new DiceValueMessageComposerSerializer(MessageComposer.DiceValueMessageComposer)
            },
            {
                typeof(FurniRentOrBuyoutOfferMessageComposer),
                new FurniRentOrBuyoutOfferMessageComposerSerializer(
                    MessageComposer.FurniRentOrBuyoutOfferMessageComposer
                )
            },
            {
                typeof(GuildFurniContextMenuInfoMessageComposer),
                new GuildFurniContextMenuInfoMessageComposerSerializer(
                    MessageComposer.GuildFurniContextMenuInfoMessageComposer
                )
            },
            {
                typeof(OneWayDoorStatusMessageComposer),
                new OneWayDoorStatusMessageComposerSerializer(
                    MessageComposer.OneWayDoorStatusMessageComposer
                )
            },
            {
                typeof(OpenPetPackageRequestedMessageComposer),
                new OpenPetPackageRequestedMessageComposerSerializer(
                    MessageComposer.OpenPetPackageRequestedMessageComposer
                )
            },
            {
                typeof(OpenPetPackageResultMessageComposer),
                new OpenPetPackageResultMessageComposerSerializer(
                    MessageComposer.OpenPetPackageResultMessageComposer
                )
            },
            {
                typeof(PresentOpenedMessageComposer),
                new PresentOpenedMessageComposerSerializer(
                    MessageComposer.PresentOpenedMessageComposer
                )
            },
            {
                typeof(RentableSpaceRentFailedMessageComposer),
                new RentableSpaceRentFailedMessageComposerSerializer(
                    MessageComposer.RentableSpaceRentFailedMessageComposer
                )
            },
            {
                typeof(RentableSpaceRentOkMessageComposer),
                new RentableSpaceRentOkMessageComposerSerializer(
                    MessageComposer.RentableSpaceRentOkMessageComposer
                )
            },
            {
                typeof(RentableSpaceStatusMessageComposer),
                new RentableSpaceStatusMessageComposerSerializer(
                    MessageComposer.RentableSpaceStatusMessageComposer
                )
            },
            {
                typeof(RequestSpamWallPostItMessageComposer),
                new RequestSpamWallPostItMessageComposerSerializer(
                    MessageComposer.RequestSpamWallPostItMessageComposer
                )
            },
            {
                typeof(RoomDimmerPresetsMessageComposer),
                new RoomDimmerPresetsMessageComposerSerializer(
                    MessageComposer.RoomDimmerPresetsMessageComposer
                )
            },
            {
                typeof(RoomMessageNotificationMessageComposer),
                new RoomMessageNotificationMessageComposerSerializer(
                    MessageComposer.RoomMessageNotificationMessageComposer
                )
            },
            {
                typeof(YoutubeControlVideoMessageComposer),
                new YoutubeControlVideoMessageComposerSerializer(
                    MessageComposer.YoutubeControlVideoMessageComposer
                )
            },
            {
                typeof(YoutubeDisplayPlaylistsMessageComposer),
                new YoutubeDisplayPlaylistsMessageComposerSerializer(
                    MessageComposer.YoutubeDisplayPlaylistsMessageComposer
                )
            },
            {
                typeof(YoutubeDisplayVideoMessageComposer),
                new YoutubeDisplayVideoMessageComposerSerializer(
                    MessageComposer.YoutubeDisplayVideoMessageComposer
                )
            },
            #endregion

            #region Room Layout
            {
                typeof(RoomEntryTileMessageComposer),
                new RoomEntryTileMessageComposerSerializer(
                    MessageComposer.RoomEntryTileMessageComposer
                )
            },
            {
                typeof(RoomOccupiedTilesMessageComposer),
                new RoomOccupiedTilesMessageComposerSerializer(
                    MessageComposer.RoomOccupiedTilesMessageComposer
                )
            },
            #endregion

            #region Room Permissions
            {
                typeof(YouAreControllerMessageComposer),
                new YouAreControllerMessageComposerSerializer(
                    MessageComposer.YouAreControllerMessageComposer
                )
            },
            {
                typeof(YouAreNotControllerMessageComposer),
                new YouAreNotControllerMessageComposerSerializer(
                    MessageComposer.YouAreNotControllerMessageComposer
                )
            },
            {
                typeof(YouAreOwnerMessageComposer),
                new YouAreOwnerMessageComposerSerializer(MessageComposer.YouAreOwnerMessageComposer)
            },
            #endregion

            #region Room Pets
            {
                typeof(PetBreedingResultEventMessageComposer),
                new PetBreedingResultEventMessageComposerSerializer(
                    MessageComposer.PetBreedingResultComposer
                )
            },
            {
                typeof(PetCommandsMessageComposer),
                new PetCommandsMessageComposerSerializer(MessageComposer.PetCommandsMessageComposer)
            },
            {
                typeof(PetExperienceMessageComposer),
                new PetExperienceMessageComposerSerializer(MessageComposer.PetExperienceComposer)
            },
            {
                typeof(PetFigureUpdateMessageComposer),
                new PetFigureUpdateMessageComposerSerializer(
                    MessageComposer.PetFigureUpdateComposer
                )
            },
            {
                typeof(PetInfoMessageComposer),
                new PetInfoMessageComposerSerializer(MessageComposer.PetInfoMessageComposer)
            },
            {
                typeof(PetLevelUpdateMessageComposer),
                new PetLevelUpdateMessageComposerSerializer(MessageComposer.PetLevelUpdateComposer)
            },
            {
                typeof(PetPlacingErrorMessageComposer),
                new PetPlacingErrorMessageComposerSerializer(
                    MessageComposer.PetPlacingErrorComposer
                )
            },
            {
                typeof(PetRespectFailedMessageComposer),
                new PetRespectFailedMessageComposerSerializer(
                    MessageComposer.PetRespectFailedComposer
                )
            },
            {
                typeof(PetStatusUpdateMessageComposer),
                new PetStatusUpdateMessageComposerSerializer(
                    MessageComposer.PetStatusUpdateComposer
                )
            },
            #endregion

            #region Room Session
            {
                typeof(CantConnectMessageComposer),
                new CantConnectMessageComposerSerializer(MessageComposer.CantConnectMessageComposer)
            },
            {
                typeof(CloseConnectionMessageComposer),
                new CloseConnectionMessageComposerSerializer(
                    MessageComposer.CloseConnectionMessageComposer
                )
            },
            {
                typeof(FlatAccessibleMessageComposer),
                new FlatAccessibleMessageComposerSerializer(
                    MessageComposer.FlatAccessibleMessageComposer
                )
            },
            {
                typeof(GamePlayerValueMessageComposer),
                new GamePlayerValueMessageComposerSerializer(
                    MessageComposer.GamePlayerValueMessageComposer
                )
            },
            {
                typeof(HanditemConfigurationMessageComposer),
                new HanditemConfigurationMessageComposerSerializer(
                    MessageComposer.HanditemConfigurationMessageComposer
                )
            },
            {
                typeof(OpenConnectionMessageComposer),
                new OpenConnectionMessageComposerSerializer(
                    MessageComposer.OpenConnectionMessageComposer
                )
            },
            {
                typeof(RoomForwardMessageComposer),
                new RoomForwardMessageComposerSerializer(MessageComposer.RoomForwardMessageComposer)
            },
            {
                typeof(RoomQueueStatusMessageComposer),
                new RoomQueueStatusMessageComposerSerializer(
                    MessageComposer.RoomQueueStatusMessageComposer
                )
            },
            {
                typeof(RoomReadyMessageComposer),
                new RoomReadyMessageComposerSerializer(MessageComposer.RoomReadyMessageComposer)
            },
            {
                typeof(YouAreNotSpectatorMessageComposer),
                new YouAreNotSpectatorMessageComposerSerializer(
                    MessageComposer.YouAreNotSpectatorMessageComposer
                )
            },
            {
                typeof(YouArePlayingGameMessageComposer),
                new YouArePlayingGameMessageComposerSerializer(
                    MessageComposer.YouArePlayingGameMessageComposer
                )
            },
            {
                typeof(YouAreSpectatorMessageComposer),
                new YouAreSpectatorMessageComposerSerializer(
                    MessageComposer.YouAreSpectatorMessageComposer
                )
            },
            #endregion

            #endregion

            #region Tracking
            {
                typeof(LatencyPingResponseMessage),
                new LatencyPingResponseMessageSerializer(
                    MessageComposer.LatencyPingResponseMessageComposer
                )
            },
            #endregion

            #region Users
            {
                typeof(ScrSendUserInfoMessage),
                new ScrSendUserInfoMessageSerializer(MessageComposer.ScrSendUserInfoComposer)
            },
            #endregion
        };
    #endregion
}
