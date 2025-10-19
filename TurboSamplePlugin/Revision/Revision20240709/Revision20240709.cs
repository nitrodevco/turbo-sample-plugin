using System;
using System.Collections.Generic;
using Turbo.Networking.Abstractions.Revisions;
using Turbo.Packets.Abstractions;
using Turbo.Primitives.Messages.Outgoing.Availability;
using Turbo.Primitives.Messages.Outgoing.Catalog;
using Turbo.Primitives.Messages.Outgoing.Handshake;
using Turbo.Primitives.Messages.Outgoing.Navigator;
using Turbo.Primitives.Messages.Outgoing.Users;
using TurboSamplePlugin.Revision.Revision20240709.Parsers.Catalog;
using TurboSamplePlugin.Revision.Revision20240709.Parsers.Handshake;
using TurboSamplePlugin.Revision.Revision20240709.Parsers.Navigator;
using TurboSamplePlugin.Revision.Revision20240709.Serializer.Availability;
using TurboSamplePlugin.Revision.Revision20240709.Serializer.Catalog;
using TurboSamplePlugin.Revision.Revision20240709.Serializers.Handshake;
using TurboSamplePlugin.Revision.Revision20240709.Serializers.Navigator;
using TurboSamplePlugin.Revision.Revision20240709.Serializers.Users;

namespace TurboSamplePlugin.Revision.Revision20240709;

public class Revision20240709 : IRevision
{
    public string Revision => "WIN63-202407091256-704579380";

    public IDictionary<int, IParser> Parsers { get; } =
        new Dictionary<int, IParser>
        {
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
            // Catalog
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
            // Navigator
            { MessageEvent.AddFavouriteRoomMessageEvent, new AddFavouriteRoomParser() },
            { MessageEvent.CancelEventMessageEvent, new CancelEventParser() },
            { MessageEvent.CanCreateRoomMessageEvent, new CanCreateRoomParser() },
            { MessageEvent.CompetitionRoomsSearchMessageEvent, new CompetitionRoomsSearchParser() },
            { MessageEvent.ConvertGlobalRoomIdMessageEvent, new ConvertGlobalRoomIdParser() },
            { MessageEvent.CreateFlatMessageEvent, new CreateFlatParser() },
            { MessageEvent.DeleteFavouriteRoomMessageEvent, new DeleteFavouriteRoomParser() },
            { MessageEvent.DeleteRoomMessageEvent, new DeleteRoomParser() },
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
        };

    public IDictionary<Type, ISerializer> Serializers { get; } =
        new Dictionary<Type, ISerializer>
        {
            {
                typeof(AvailabilityStatusMessage),
                new AvailabilityStatusMessageSerializer(
                    MessageComposer.AvailabilityStatusMessageComposer
                )
            },
            {
                typeof(FigureSetIdsMessage),
                new FigureSetIdsSerializer(MessageComposer.FigureSetIdsComposer)
            },
            {
                typeof(AuthenticationOKMessage),
                new AuthenticationOKMessageSerializer(
                    MessageComposer.AuthenticationOKMessageComposer
                )
            },
            {
                typeof(CompleteDiffieHandshakeComposer),
                new CompleteDiffieHandshakeSerializer(
                    MessageComposer.CompleteDiffieHandshakeComposer
                )
            },
            {
                typeof(InitDiffieHandshakeComposer),
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
            {
                typeof(NavigatorSettingsMessage),
                new NavigatorSettingsSerializer(MessageComposer.NavigatorSettingsComposer)
            },
            {
                typeof(ScrSendUserInfoMessage),
                new ScrSendUserInfoSerializer(MessageComposer.ScrSendUserInfoComposer)
            },
        };
}
