using System;
using System.Collections.Generic;
using Turbo.Networking.Abstractions.Revisions;
using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Availability;
using Turbo.Primitives.Messages.Outgoing.Catalog;
using Turbo.Primitives.Messages.Outgoing.Handshake;
using Turbo.Primitives.Messages.Outgoing.Navigator;
using Turbo.Primitives.Messages.Outgoing.Tracking;
using Turbo.Primitives.Messages.Outgoing.Users;
using TurboSamplePlugin.Revision.Revision20240709.Parsers.Catalog;
using TurboSamplePlugin.Revision.Revision20240709.Parsers.Collectibles;
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
using TurboSamplePlugin.Revision.Revision20240709.Serializer.Availability;
using TurboSamplePlugin.Revision.Revision20240709.Serializer.Catalog;
using TurboSamplePlugin.Revision.Revision20240709.Serializers.Handshake;
using TurboSamplePlugin.Revision.Revision20240709.Serializers.Navigator;
using TurboSamplePlugin.Revision.Revision20240709.Serializers.Tracking;
using TurboSamplePlugin.Revision.Revision20240709.Serializers.Users;

namespace TurboSamplePlugin.Revision.Revision20240709;

public class Revision20240709 : IRevision
{
    public string Revision => "WIN63-202407091256-704579380";

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

    public IDictionary<Type, ISerializer> Serializers { get; } =
        new Dictionary<Type, ISerializer>
        {
            #region Availability
            {
                typeof(AvailabilityStatusMessage),
                new AvailabilityStatusMessageSerializer(
                    MessageComposer.AvailabilityStatusMessageComposer
                )
            },
            #endregion

            #region Catalog
            {
                typeof(FigureSetIdsMessage),
                new FigureSetIdsSerializer(MessageComposer.FigureSetIdsComposer)
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
                typeof(CompleteDiffieHandshakeMessage),
                new CompleteDiffieHandshakeSerializer(
                    MessageComposer.CompleteDiffieHandshakeComposer
                )
            },
            {
                typeof(InitDiffieHandshakeMessage),
                new InitDiffieHandshakeSerializer(MessageComposer.InitDiffieHandshakeComposer)
            },
            {
                typeof(IsFirstLoginOfDayMessage),
                new IsFirstLoginOfDaySerializer(MessageComposer.IsFirstLoginOfDayComposer)
            },
            {
                typeof(NoobnessLevelMessage),
                new NoobnessLevelSerializer(MessageComposer.NoobnessLevelMessageComposer)
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
                typeof(NavigatorSettingsMessage),
                new NavigatorSettingsSerializer(MessageComposer.NavigatorSettingsComposer)
            },
            #endregion

            #region Tracking
            {
                typeof(LatencyPingResponseMessage),
                new LatencyPingResponseSerializer(
                    MessageComposer.LatencyPingResponseMessageComposer
                )
            },
            #endregion

            #region Users
            {
                typeof(ScrSendUserInfoMessage),
                new ScrSendUserInfoSerializer(MessageComposer.ScrSendUserInfoComposer)
            },
            #endregion
        };
}
