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
