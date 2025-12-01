using System;
using System.Collections.Generic;
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
using Turbo.Primitives.Messages.Outgoing.Preferences;
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
using Turbo.Primitives.Networking.Revisions;
using Turbo.Primitives.Packets;
using TurboSamplePlugin.Revision.Revision20240709.Parsers.Advertisement;
using TurboSamplePlugin.Revision.Revision20240709.Parsers.Avatar;
using TurboSamplePlugin.Revision.Revision20240709.Parsers.Camera;
using TurboSamplePlugin.Revision.Revision20240709.Parsers.Campaign;
using TurboSamplePlugin.Revision.Revision20240709.Parsers.Catalog;
using TurboSamplePlugin.Revision.Revision20240709.Parsers.Collectibles;
using TurboSamplePlugin.Revision.Revision20240709.Parsers.Competition;
using TurboSamplePlugin.Revision.Revision20240709.Parsers.Crafting;
using TurboSamplePlugin.Revision.Revision20240709.Parsers.Friendfurni;
using TurboSamplePlugin.Revision.Revision20240709.Parsers.FriendList;
using TurboSamplePlugin.Revision.Revision20240709.Parsers.Game.Arena;
using TurboSamplePlugin.Revision.Revision20240709.Parsers.Game.Directory;
using TurboSamplePlugin.Revision.Revision20240709.Parsers.Game.Ingame;
using TurboSamplePlugin.Revision.Revision20240709.Parsers.Game.Lobby;
using TurboSamplePlugin.Revision.Revision20240709.Parsers.Game.Score;
using TurboSamplePlugin.Revision.Revision20240709.Parsers.Gifts;
using TurboSamplePlugin.Revision.Revision20240709.Parsers.Groupforums;
using TurboSamplePlugin.Revision.Revision20240709.Parsers.Handshake;
using TurboSamplePlugin.Revision.Revision20240709.Parsers.Help;
using TurboSamplePlugin.Revision.Revision20240709.Parsers.Hotlooks;
using TurboSamplePlugin.Revision.Revision20240709.Parsers.Inventory.Achievements;
using TurboSamplePlugin.Revision.Revision20240709.Parsers.Inventory.Avatareffect;
using TurboSamplePlugin.Revision.Revision20240709.Parsers.Inventory.Badges;
using TurboSamplePlugin.Revision.Revision20240709.Parsers.Inventory.Bots;
using TurboSamplePlugin.Revision.Revision20240709.Parsers.Inventory.Furni;
using TurboSamplePlugin.Revision.Revision20240709.Parsers.Inventory.Pets;
using TurboSamplePlugin.Revision.Revision20240709.Parsers.Inventory.Purse;
using TurboSamplePlugin.Revision.Revision20240709.Parsers.Inventory.Trading;
using TurboSamplePlugin.Revision.Revision20240709.Parsers.Landingview;
using TurboSamplePlugin.Revision.Revision20240709.Parsers.Landingview.Votes;
using TurboSamplePlugin.Revision.Revision20240709.Parsers.Marketplace;
using TurboSamplePlugin.Revision.Revision20240709.Parsers.Moderator;
using TurboSamplePlugin.Revision.Revision20240709.Parsers.Mysterybox;
using TurboSamplePlugin.Revision.Revision20240709.Parsers.Navigator;
using TurboSamplePlugin.Revision.Revision20240709.Parsers.NewNavigator;
using TurboSamplePlugin.Revision.Revision20240709.Parsers.Nft;
using TurboSamplePlugin.Revision.Revision20240709.Parsers.Notifications;
using TurboSamplePlugin.Revision.Revision20240709.Parsers.Nux;
using TurboSamplePlugin.Revision.Revision20240709.Parsers.Poll;
using TurboSamplePlugin.Revision.Revision20240709.Parsers.Preferences;
using TurboSamplePlugin.Revision.Revision20240709.Parsers.Quest;
using TurboSamplePlugin.Revision.Revision20240709.Parsers.Register;
using TurboSamplePlugin.Revision.Revision20240709.Parsers.Room.Action;
using TurboSamplePlugin.Revision.Revision20240709.Parsers.Room.Avatar;
using TurboSamplePlugin.Revision.Revision20240709.Parsers.Room.Bots;
using TurboSamplePlugin.Revision.Revision20240709.Parsers.Room.Chat;
using TurboSamplePlugin.Revision.Revision20240709.Parsers.Room.Engine;
using TurboSamplePlugin.Revision.Revision20240709.Parsers.Room.Furniture;
using TurboSamplePlugin.Revision.Revision20240709.Parsers.Room.Layout;
using TurboSamplePlugin.Revision.Revision20240709.Parsers.Room.Pets;
using TurboSamplePlugin.Revision.Revision20240709.Parsers.Room.Session;
using TurboSamplePlugin.Revision.Revision20240709.Parsers.Roomdirectory;
using TurboSamplePlugin.Revision.Revision20240709.Parsers.RoomSettings;
using TurboSamplePlugin.Revision.Revision20240709.Parsers.Sound;
using TurboSamplePlugin.Revision.Revision20240709.Parsers.Talent;
using TurboSamplePlugin.Revision.Revision20240709.Parsers.Tracking;
using TurboSamplePlugin.Revision.Revision20240709.Parsers.Userclassification;
using TurboSamplePlugin.Revision.Revision20240709.Parsers.Userdefinedroomevents;
using TurboSamplePlugin.Revision.Revision20240709.Parsers.Userdefinedroomevents.Wiredmenu;
using TurboSamplePlugin.Revision.Revision20240709.Parsers.Users;
using TurboSamplePlugin.Revision.Revision20240709.Parsers.Vault;
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
using TurboSamplePlugin.Revision.Revision20240709.Serializers.Preferences;
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
            #region Advertisement
            { MessageEvent.GetInterstitialMessageEvent, new GetInterstitialMessageParser() },
            { MessageEvent.InterstitialShownMessageEvent, new InterstitialShownMessageParser() },
            #endregion

            #region Avatar
            {
                MessageEvent.ChangeUserNameInRoomMessageEvent,
                new ChangeUserNameInRoomMessageParser()
            },
            { MessageEvent.ChangeUserNameMessageEvent, new ChangeUserNameMessageParser() },
            { MessageEvent.CheckUserNameMessageEvent, new CheckUserNameMessageParser() },
            { MessageEvent.GetWardrobeMessageEvent, new GetWardrobeMessageParser() },
            { MessageEvent.SaveWardrobeOutfitMessageEvent, new SaveWardrobeOutfitMessageParser() },
            #endregion

            #region Camera
            { MessageEvent.PhotoCompetitionMessageEvent, new PhotoCompetitionMessageParser() },
            { MessageEvent.PublishPhotoMessageEvent, new PublishPhotoMessageParser() },
            { MessageEvent.PurchasePhotoMessageEvent, new PurchasePhotoMessageParser() },
            { MessageEvent.RenderRoomMessageEvent, new RenderRoomMessageParser() },
            {
                MessageEvent.RequestCameraConfigurationMessageEvent,
                new RequestCameraConfigurationMessageParser()
            },
            #endregion

            #region Campaign
            {
                MessageEvent.OpenCampaignCalendarDoorAsStaffEvent,
                new OpenCampaignCalendarDoorAsStaffMessageParser()
            },
            {
                MessageEvent.OpenCampaignCalendarDoorEvent,
                new OpenCampaignCalendarDoorMessageParser()
            },
            #endregion

            #region Catalog
            {
                MessageEvent.BuildersClubPlaceRoomItemMessageEvent,
                new BuildersClubPlaceRoomItemMessageParser()
            },
            {
                MessageEvent.BuildersClubPlaceWallItemMessageEvent,
                new BuildersClubPlaceWallItemMessageParser()
            },
            {
                MessageEvent.BuildersClubQueryFurniCountMessageEvent,
                new BuildersClubQueryFurniCountMessageParser()
            },
            // charge firework?
            { MessageEvent.GetBonusRareInfoMessageEvent, new GetBonusRareInfoMessageParser() },
            {
                MessageEvent.GetBundleDiscountRulesetEvent,
                new GetBundleDiscountRulesetMessageParser()
            },
            { MessageEvent.GetCatalogIndexEvent, new GetCatalogIndexMessageParser() },
            { MessageEvent.GetCatalogPageEvent, new GetCatalogPageMessageParser() },
            {
                MessageEvent.GetCatalogPageWithEarliestExpiryEvent,
                new GetCatalogPageWithEarliestExpiryMessageParser()
            },
            { MessageEvent.GetClubGiftMessageEvent, new GetClubGiftInfoMessageParser() },
            { MessageEvent.GetClubOffersMessageEvent, new GetClubOffersMessageParser() },
            {
                MessageEvent.GetGiftWrappingConfigurationEvent,
                new GetGiftWrappingConfigurationMessageParser()
            },
            {
                MessageEvent.GetHabboClubExtendOfferMessageEvent,
                new GetHabboClubExtendOfferMessageParser()
            },
            { MessageEvent.GetIsOfferGiftableEvent, new GetIsOfferGiftableMessageParser() },
            {
                MessageEvent.GetLimitedOfferAppearingNextEvent,
                new GetLimitedOfferAppearingNextMessageParser()
            },
            { MessageEvent.GetNextTargetedOfferEvent, new GetNextTargetedOfferMessageParser() },
            { MessageEvent.GetProductOfferEvent, new GetProductOfferMessageParser() },
            { MessageEvent.GetRoomAdPurchaseInfoEvent, new GetRoomAdPurchaseInfoMessageParser() },
            {
                MessageEvent.GetSeasonalCalendarDailyEvent,
                new GetSeasonalCalendarDailyOfferMessageParser()
            },
            { MessageEvent.GetSellablePetPalettesEvent, new GetSellablePetPalettesMessageParser() },
            {
                MessageEvent.MarkCatalogNewAdditionsPageOpenedEvent,
                new MarkCatalogNewAdditionsPageOpenedMessageParser()
            },
            {
                MessageEvent.PurchaseBasicMembershipExtensionEvent,
                new PurchaseBasicMembershipExtensionMessageParser()
            },
            {
                MessageEvent.PurchaseFromCatalogAsGiftEvent,
                new PurchaseFromCatalogAsGiftMessageParser()
            },
            { MessageEvent.PurchaseFromCatalogEvent, new PurchaseFromCatalogMessageParser() },
            { MessageEvent.PurchaseRoomAdMessageEvent, new PurchaseRoomAdMessageParser() },
            { MessageEvent.PurchaseTargetedOfferEvent, new PurchaseTargetedOfferMessageParser() },
            {
                MessageEvent.PurchaseVipMembershipExtensionEvent,
                new PurchaseVipMembershipExtensionMessageParser()
            },
            { MessageEvent.RedeemVoucherMessageEvent, new RedeemVoucherMessageParser() },
            {
                MessageEvent.RoomAdPurchaseInitiatedEvent,
                new RoomAdPurchaseInitiatedMessageParser()
            },
            { MessageEvent.SelectClubGiftEvent, new SelectClubGiftMessageParser() },
            { MessageEvent.SetTargetedOfferStateEvent, new SetTargetedOfferStateMessageParser() },
            {
                MessageEvent.ShopTargetedOfferViewedEvent,
                new ShopTargetedOfferViewedMessageParser()
            },
            #endregion

            #region Collectibles
            {
                MessageEvent.GetCollectibleMintableItemTypesMessageEvent,
                new GetCollectibleMintableItemTypesMessageParser()
            },
            {
                MessageEvent.GetCollectibleMintingEnabledMessageEvent,
                new GetCollectibleMintingEnabledMessageParser()
            },
            {
                MessageEvent.GetCollectibleMintTokensMessageEvent,
                new GetCollectibleMintTokensMessageParser()
            },
            {
                MessageEvent.GetCollectibleWalletAddressesMessageEvent,
                new GetCollectibleWalletAddressesMessageParser()
            },
            { MessageEvent.GetCollectorScoreMessageEvent, new GetCollectorScoreMessageParser() },
            { MessageEvent.GetMintTokenOffersMessageEvent, new GetMintTokenOffersMessageParser() },
            { MessageEvent.GetNftCollectionsMessageEvent, new GetNftCollectionsMessageParser() },
            { MessageEvent.GetNftTransferFeeMessageEvent, new GetNftTransferFeeMessageParser() },
            { MessageEvent.MintItemMessageEvent, new MintItemMessageParser() },
            {
                MessageEvent.NftCollectiblesClaimBonusItemMessageEvent,
                new NftCollectiblesClaimBonusItemMessageParser()
            },
            {
                MessageEvent.NftCollectiblesClaimRewardItemMessageEvent,
                new NftCollectiblesClaimRewardItemMessageParser()
            },
            { MessageEvent.NftTransferAssetsMessageEvent, new NftTransferAssetsMessageParser() },
            { MessageEvent.PurchaseMintTokenMessageEvent, new PurchaseMintTokenMessageParser() },
            #endregion

            #region Competition
            {
                MessageEvent.ForwardToACompetitionRoomMessageEvent,
                new ForwardToACompetitionRoomMessageParser()
            },
            {
                MessageEvent.ForwardToASubmittableRoomMessageEvent,
                new ForwardToASubmittableRoomMessageParser()
            },
            {
                MessageEvent.ForwardToRandomCompetitionRoomMessageEvent,
                new ForwardToRandomCompetitionRoomMessageParser()
            },
            {
                MessageEvent.GetCurrentTimingCodeMessageEvent,
                new GetCurrentTimingCodeMessageParser()
            },
            {
                MessageEvent.GetIsUserPartOfCompetitionMessageEvent,
                new GetIsUserPartOfCompetitionMessageParser()
            },
            { MessageEvent.GetSecondsUntilMessageEvent, new GetSecondsUntilMessageParser() },
            {
                MessageEvent.RoomCompetitionInitMessageEvent,
                new RoomCompetitionInitMessageParser()
            },
            {
                MessageEvent.SubmitRoomToCompetitionMessageEvent,
                new SubmitRoomToCompetitionMessageParser()
            },
            { MessageEvent.VoteForRoomMessageEvent, new VoteForRoomMessageParser() },
            #endregion

            #region Crafting
            { MessageEvent.CraftEvent, new CraftMessageParser() },
            { MessageEvent.CraftSecretEvent, new CraftSecretMessageParser() },
            { MessageEvent.GetCraftableProductsEvent, new GetCraftableProductsMessageParser() },
            { MessageEvent.GetCraftingRecipeEvent, new GetCraftingRecipeMessageParser() },
            {
                MessageEvent.GetCraftingRecipesAvailableEvent,
                new GetCraftingRecipesAvailableMessageParser()
            },
            #endregion

            #region Friendfurni
            {
                MessageEvent.FriendFurniConfirmLockMessageEvent,
                new FriendFurniConfirmLockMessageParser()
            },
            #endregion

            #region FriendList
            { MessageEvent.AcceptFriendMessageEvent, new AcceptFriendMessageParser() },
            { MessageEvent.DeclineFriendMessageEvent, new DeclineFriendMessageParser() },
            { MessageEvent.FindNewFriendsMessageEvent, new FindNewFriendsMessageParser() },
            { MessageEvent.FollowFriendMessageEvent, new FollowFriendMessageParser() },
            { MessageEvent.FriendListUpdateMessageEvent, new FriendListUpdateMessageParser() },
            { MessageEvent.GetFriendRequestsMessageEvent, new GetFriendRequestsMessageParser() },
            { MessageEvent.GetMessengerHistoryEvent, new GetMessengerHistoryMessageParser() },
            { MessageEvent.HabboSearchMessageEvent, new HabboSearchMessageParser() },
            { MessageEvent.MessengerInitMessageEvent, new MessengerInitMessageParser() },
            { MessageEvent.RemoveFriendMessageEvent, new RemoveFriendMessageParser() },
            { MessageEvent.RequestFriendMessageEvent, new RequestFriendMessageParser() },
            { MessageEvent.SendMsgMessageEvent, new SendMsgMessageParser() },
            { MessageEvent.SendRoomInviteMessageEvent, new SendRoomInviteMessageParser() },
            { MessageEvent.VisitUserMessageEvent, new VisitUserMessageParser() },
            #endregion

            #region Game
            {
                MessageEvent.Game2CheckGameDirectoryStatusMessageEvent,
                new Game2CheckGameDirectoryStatusMessageParser()
            },
            { MessageEvent.Game2ExitGameMessageEvent, new Game2ExitGameMessageParser() },
            { MessageEvent.Game2GameChatMessageEvent, new Game2GameChatMessageParser() },
            {
                MessageEvent.Game2GetAccountGameStatusMessageEvent,
                new Game2GetAccountGameStatusMessageParser()
            },
            {
                MessageEvent.Game2GetFriendsLeaderboardEvent,
                new Game2GetFriendsLeaderboardMessageParser()
            },
            {
                MessageEvent.Game2GetTotalGroupLeaderboardEvent,
                new Game2GetTotalGroupLeaderboardMessageParser()
            },
            {
                MessageEvent.Game2GetTotalLeaderboardEvent,
                new Game2GetTotalLeaderboardMessageParser()
            },
            {
                MessageEvent.Game2GetWeeklyFriendsLeaderboardEvent,
                new Game2GetWeeklyFriendsLeaderboardMessageParser()
            },
            {
                MessageEvent.Game2GetWeeklyGroupLeaderboardEvent,
                new Game2GetWeeklyGroupLeaderboardMessageParser()
            },
            {
                MessageEvent.Game2GetWeeklyLeaderboardEvent,
                new Game2GetWeeklyLeaderboardMessageParser()
            },
            { MessageEvent.Game2LeaveGameMessageEvent, new Game2LeaveGameMessageParser() },
            {
                MessageEvent.Game2LoadStageReadyMessageEvent,
                new Game2LoadStageReadyMessageParser()
            },
            { MessageEvent.Game2MakeSnowballMessageEvent, new Game2MakeSnowballMessageParser() },
            { MessageEvent.Game2PlayAgainMessageEvent, new Game2PlayAgainMessageParser() },
            { MessageEvent.Game2QuickJoinGameMessageEvent, new Game2QuickJoinGameMessageParser() },
            {
                MessageEvent.Game2RequestFullStatusUpdateMessageEvent,
                new Game2RequestFullStatusUpdateMessageParser()
            },
            {
                MessageEvent.Game2SetUserMoveTargetMessageEvent,
                new Game2SetUserMoveTargetMessageParser()
            },
            { MessageEvent.Game2StartSnowWarMessageEvent, new Game2StartSnowWarMessageParser() },
            {
                MessageEvent.Game2ThrowSnowballAtHumanMessageEvent,
                new Game2ThrowSnowballAtHumanMessageParser()
            },
            {
                MessageEvent.Game2ThrowSnowballAtPositionMessageEvent,
                new Game2ThrowSnowballAtPositionMessageParser()
            },
            /* {
                MessageEvent.GetFriendsWeeklyCompetitiveLeaderboardMessageEvent,
                new GetFriendsWeeklyCompetitiveLeaderboardMessageParser()
            }, */
            {
                MessageEvent.GetResolutionAchievementsMessageEvent,
                new GetResolutionAchievementsMessageParser()
            },
            /* {
                MessageEvent.GetUserGameAchievementsMessageEvent,
                new GetUserGameAchievementsMessageParser()
            },
            {
                MessageEvent.GetWeeklyCompetitiveLeaderboardMessageEvent,
                new GetWeeklyCompetitiveLeaderboardMessageParser()
            },
            {
                MessageEvent.GetWeeklyGameRewardMessageEvent,
                new GetWeeklyGameRewardMessageParser()
            },
            {
                MessageEvent.GetWeeklyGameRewardWinnersMessageEvent,
                new GetWeeklyGameRewardWinnersMessageParser()
            }, */
            #endregion

            #region Gifts
            {
                MessageEvent.ResetPhoneNumberStateMessageEvent,
                new ResetPhoneNumberStateMessageParser()
            },
            {
                MessageEvent.SetPhoneNumberVerificationStatusMessageEvent,
                new SetPhoneNumberVerificationStatusMessageParser()
            },
            { MessageEvent.TryPhoneNumberMessageEvent, new TryPhoneNumberMessageParser() },
            { MessageEvent.VerifyCodeMessageEvent, new VerifyCodeMessageParser() },
            #endregion

            #region GroupForums
            { MessageEvent.GetForumsListMessageEvent, new GetForumsListMessageParser() },
            { MessageEvent.GetForumStatsMessageEvent, new GetForumStatsMessageParser() },
            { MessageEvent.GetMessagesMessageEvent, new GetMessagesMessageParser() },
            { MessageEvent.GetThreadMessageEvent, new GetThreadMessageParser() },
            { MessageEvent.GetThreadsMessageEvent, new GetThreadsMessageParser() },
            {
                MessageEvent.GetUnreadForumsCountMessageEvent,
                new GetUnreadForumsCountMessageParser()
            },
            { MessageEvent.ModerateMessageMessageEvent, new ModerateMessageMessageParser() },
            { MessageEvent.ModerateThreadMessageEvent, new ModerateThreadMessageParser() },
            { MessageEvent.PostMessageMessageEvent, new PostMessageMessageParser() },
            {
                MessageEvent.UpdateForumReadMarkerMessageEvent,
                new UpdateForumReadMarkerMessageParser()
            },
            {
                MessageEvent.UpdateForumSettingsMessageEvent,
                new UpdateForumSettingsMessageParser()
            },
            { MessageEvent.UpdateThreadMessageEvent, new UpdateThreadMessageParser() },
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
            {
                MessageEvent.CallForHelpFromForumMessageMessageEvent,
                new CallForHelpFromForumMessageMessageParser()
            },
            {
                MessageEvent.CallForHelpFromForumThreadMessageEvent,
                new CallForHelpFromForumThreadMessageParser()
            },
            { MessageEvent.CallForHelpFromIMMessageEvent, new CallForHelpFromIMMessageParser() },
            {
                MessageEvent.CallForHelpFromPhotoMessageEvent,
                new CallForHelpFromPhotoMessageParser()
            },
            {
                MessageEvent.CallForHelpFromSelfieMessageEvent,
                new CallForHelpFromSelfieMessageParser()
            },
            { MessageEvent.CallForHelpMessageEvent, new CallForHelpMessageParser() },
            {
                MessageEvent.ChatReviewGuideDecidesOnOfferMessageEvent,
                new ChatReviewGuideDecidesOnOfferMessageParser()
            },
            {
                MessageEvent.ChatReviewGuideDetachedMessageEvent,
                new ChatReviewGuideDetachedMessageParser()
            },
            {
                MessageEvent.ChatReviewGuideVoteMessageEvent,
                new ChatReviewGuideVoteMessageParser()
            },
            {
                MessageEvent.ChatReviewSessionCreateMessageEvent,
                new ChatReviewSessionCreateMessageParser()
            },
            {
                MessageEvent.DeletePendingCallsForHelpMessageEvent,
                new DeletePendingCallsForHelpMessageParser()
            },
            { MessageEvent.GetCfhStatusMessageEvent, new GetCfhStatusMessageParser() },
            {
                MessageEvent.GetGuideReportingStatusMessageEvent,
                new GetGuideReportingStatusMessageParser()
            },
            {
                MessageEvent.GetPendingCallsForHelpMessageEvent,
                new GetPendingCallsForHelpMessageParser()
            },
            { MessageEvent.GetQuizQuestionsEvent, new GetQuizQuestionsMessageParser() },
            { MessageEvent.GuideSessionCreateMessageEvent, new GuideSessionCreateMessageParser() },
            {
                MessageEvent.GuideSessionFeedbackMessageEvent,
                new GuideSessionFeedbackMessageParser()
            },
            {
                MessageEvent.GuideSessionGetRequesterRoomMessageEvent,
                new GuideSessionGetRequesterRoomMessageParser()
            },
            {
                MessageEvent.GuideSessionGuideDecidesMessageEvent,
                new GuideSessionGuideDecidesMessageParser()
            },
            {
                MessageEvent.GuideSessionInviteRequesterMessageEvent,
                new GuideSessionInviteRequesterMessageParser()
            },
            {
                MessageEvent.GuideSessionIsTypingMessageEvent,
                new GuideSessionIsTypingMessageParser()
            },
            {
                MessageEvent.GuideSessionMessageMessageEvent,
                new GuideSessionMessageMessageParser()
            },
            {
                MessageEvent.GuideSessionOnDutyUpdateMessageEvent,
                new GuideSessionOnDutyUpdateMessageParser()
            },
            { MessageEvent.GuideSessionReportMessageEvent, new GuideSessionReportMessageParser() },
            {
                MessageEvent.GuideSessionRequesterCancelsMessageEvent,
                new GuideSessionRequesterCancelsMessageParser()
            },
            {
                MessageEvent.GuideSessionResolvedMessageEvent,
                new GuideSessionResolvedMessageParser()
            },
            { MessageEvent.PostQuizAnswersEvent, new PostQuizAnswersMessageParser() },
            #endregion

            #region Hotlooks
            { MessageEvent.GetHotLooksMessageEvent, new GetHotLooksMessageParser() },
            #endregion

            #region Inventory
            { MessageEvent.AcceptTradingEvent, new AcceptTradingMessageParser() },
            { MessageEvent.AddItemsToTradeEvent, new AddItemsToTradeMessageParser() },
            { MessageEvent.AddItemToTradeEvent, new AddItemToTradeMessageParser() },
            { MessageEvent.AvatarEffectActivatedEvent, new AvatarEffectActivatedMessageParser() },
            { MessageEvent.AvatarEffectSelectedEvent, new AvatarEffectSelectedMessageParser() },
            { MessageEvent.CancelPetBreedingEvent, new CancelPetBreedingMessageParser() },
            { MessageEvent.CloseTradingEvent, new CloseTradingMessageParser() },
            { MessageEvent.ConfirmAcceptTradingEvent, new ConfirmAcceptTradingMessageParser() },
            { MessageEvent.ConfirmDeclineTradingEvent, new ConfirmDeclineTradingMessageParser() },
            { MessageEvent.ConfirmPetBreedingEvent, new ConfirmPetBreedingMessageParser() },
            { MessageEvent.GetAchievementsEvent, new GetAchievementsMessageParser() },
            { MessageEvent.GetBadgePointLimitsEvent, new GetBadgePointLimitsMessageParser() },
            { MessageEvent.GetBadgesEvent, new GetBadgesMessageParser() },
            { MessageEvent.GetBotInventoryEvent, new GetBotInventoryMessageParser() },
            { MessageEvent.GetCreditsInfoEvent, new GetCreditsInfoMessageParser() },
            {
                MessageEvent.GetIsBadgeRequestFulfilledEvent,
                new GetIsBadgeRequestFulfilledMessageParser()
            },
            { MessageEvent.GetPetInventoryEvent, new GetPetInventoryMessageParser() },
            { MessageEvent.OpenTradingEvent, new OpenTradingMessageParser() },
            { MessageEvent.RemoveItemFromTradeEvent, new RemoveItemFromTradeMessageParser() },
            { MessageEvent.RequestABadgeEvent, new RequestABadgeMessageParser() },
            { MessageEvent.RequestFurniInventoryEvent, new RequestFurniInventoryMessageParser() },
            {
                MessageEvent.RequestFurniInventoryWhenNotInRoomEvent,
                new RequestFurniInventoryWhenNotInRoomMessageParser()
            },
            { MessageEvent.RequestRoomPropertySet, new RequestRoomPropertySetMessageParser() },
            { MessageEvent.SetActivatedBadgesEvent, new SetActivatedBadgesMessageParser() },
            { MessageEvent.SilverFeeMessageEvent, new SilverFeeMessageParser() },
            { MessageEvent.UnacceptTradingEvent, new UnacceptTradingMessageParser() },
            #endregion

            #region Landingview
            { MessageEvent.CommunityGoalVoteMessageEvent, new CommunityGoalVoteMessageParser() },
            { MessageEvent.GetPromoArticlesMessageEvent, new GetPromoArticlesMessageParser() },
            #endregion

            #region Marketplace
            {
                MessageEvent.BuyMarketplaceOfferMessageEvent,
                new BuyMarketplaceOfferMessageParser()
            },
            {
                MessageEvent.BuyMarketplaceTokensMessageEvent,
                new BuyMarketplaceTokensMessageParser()
            },
            {
                MessageEvent.CancelMarketplaceOfferMessageEvent,
                new CancelMarketplaceOfferMessageParser()
            },
            {
                MessageEvent.GetMarketplaceCanMakeOfferMessageEvent,
                new GetMarketplaceCanMakeOfferMessageParser()
            },
            {
                MessageEvent.GetMarketplaceConfigurationMessageEvent,
                new GetMarketplaceConfigurationMessageParser()
            },
            {
                MessageEvent.GetMarketplaceItemStatsEvent,
                new GetMarketplaceItemStatsMessageParser()
            },
            {
                MessageEvent.GetMarketplaceOffersMessageEvent,
                new GetMarketplaceOffersMessageParser()
            },
            {
                MessageEvent.GetMarketplaceOwnOffersMessageEvent,
                new GetMarketplaceOwnOffersMessageParser()
            },
            { MessageEvent.MakeOfferMessageEvent, new MakeOfferMessageParser() },
            {
                MessageEvent.RedeemMarketplaceOfferCreditsMessageEvent,
                new RedeemMarketplaceOfferCreditsMessageParser()
            },
            #endregion

            #region Moderator
            {
                MessageEvent.CloseIssueDefaultActionMessageEvent,
                new CloseIssueDefaultActionMessageParser()
            },
            { MessageEvent.CloseIssuesMessageEvent, new CloseIssuesMessageParser() },
            { MessageEvent.DefaultSanctionMessageEvent, new DefaultSanctionMessageParser() },
            { MessageEvent.GetCfhChatlogMessageEvent, new GetCfhChatlogMessageParser() },
            {
                MessageEvent.GetModeratorRoomInfoMessageEvent,
                new GetModeratorRoomInfoMessageParser()
            },
            {
                MessageEvent.GetModeratorUserInfoMessageEvent,
                new GetModeratorUserInfoMessageParser()
            },
            { MessageEvent.GetRoomChatlogMessageEvent, new GetRoomChatlogMessageParser() },
            { MessageEvent.GetRoomVisitsMessageEvent, new GetRoomVisitsMessageParser() },
            { MessageEvent.GetUserChatlogMessageEvent, new GetUserChatlogMessageParser() },
            { MessageEvent.ModAlertMessageEvent, new ModAlertMessageParser() },
            { MessageEvent.ModBanMessageEvent, new ModBanMessageParser() },
            { MessageEvent.ModerateRoomMessageEvent, new ModerateRoomMessageParser() },
            { MessageEvent.ModeratorActionMessageEvent, new ModeratorActionMessageParser() },
            { MessageEvent.ModKickMessageEvent, new ModKickMessageParser() },
            { MessageEvent.ModMessageMessageEvent, new ModMessageMessageParser() },
            { MessageEvent.ModMuteMessageEvent, new ModMuteMessageParser() },
            { MessageEvent.ModToolPreferencesEvent, new ModToolPreferencesMessageParser() },
            { MessageEvent.ModToolSanctionEvent, new ModToolSanctionMessageParser() },
            { MessageEvent.ModTradingLockMessageEvent, new ModTradingLockMessageParser() },
            { MessageEvent.PickIssuesMessageEvent, new PickIssuesMessageParser() },
            { MessageEvent.ReleaseIssuesMessageEvent, new ReleaseIssuesMessageParser() },
            #endregion

            #region Mysterybox
            {
                MessageEvent.MysteryBoxWaitingCanceledMessageEvent,
                new MysteryBoxWaitingCanceledMessageParser()
            },
            #endregion

            #region Navigator
            { MessageEvent.AddFavouriteRoomMessageEvent, new AddFavouriteRoomMessageParser() },
            { MessageEvent.CancelEventMessageEvent, new CancelEventMessageParser() },
            { MessageEvent.CanCreateRoomMessageEvent, new CanCreateRoomMessageParser() },
            {
                MessageEvent.CompetitionRoomsSearchMessageEvent,
                new CompetitionRoomsSearchMessageParser()
            },
            {
                MessageEvent.ConvertGlobalRoomIdMessageEvent,
                new ConvertGlobalRoomIdMessageParser()
            },
            { MessageEvent.CreateFlatMessageEvent, new CreateFlatMessageParser() },
            {
                MessageEvent.DeleteFavouriteRoomMessageEvent,
                new DeleteFavouriteRoomMessageParser()
            },
            { MessageEvent.EditEventMessageEvent, new EditEventMessageParser() },
            {
                MessageEvent.ForwardToARandomPromotedRoomMessageEvent,
                new ForwardToARandomPromotedRoomMessageParser()
            },
            { MessageEvent.ForwardToSomeRoomMessageEvent, new ForwardToSomeRoomMessageParser() },
            { MessageEvent.GetGuestRoomMessageEvent, new GetGuestRoomMessageParser() },
            { MessageEvent.GetOfficialRoomsMessageEvent, new GetOfficialRoomsMessageParser() },
            { MessageEvent.GetPopularRoomTagsMessageEvent, new GetPopularRoomTagsMessageParser() },
            { MessageEvent.GetUserEventCatsMessageEvent, new GetUserEventCatsMessageParser() },
            { MessageEvent.GetUserFlatCatsMessageEvent, new GetUserFlatCatsMessageParser() },
            { MessageEvent.GuildBaseSearchMessageEvent, new GuildBaseSearchMessageParser() },
            {
                MessageEvent.MyFavouriteRoomsSearchMessageEvent,
                new MyFavouriteRoomsSearchMessageParser()
            },
            {
                MessageEvent.MyFrequentRoomHistorySearchMessageEvent,
                new MyFrequentRoomHistorySearchMessageParser()
            },
            {
                MessageEvent.MyFriendsRoomsSearchMessageEvent,
                new MyFriendsRoomsSearchMessageParser()
            },
            { MessageEvent.MyGuildBasesSearchMessageEvent, new MyGuildBasesSearchMessageParser() },
            { MessageEvent.MyRecommendedRoomsMessageEvent, new MyRecommendedRoomsMessageParser() },
            {
                MessageEvent.MyRoomHistorySearchMessageEvent,
                new MyRoomHistorySearchMessageParser()
            },
            { MessageEvent.MyRoomRightsSearchMessageEvent, new MyRoomRightsSearchMessageParser() },
            { MessageEvent.MyRoomsSearchMessageEvent, new MyRoomsSearchMessageParser() },
            { MessageEvent.PopularRoomsSearchMessageEvent, new PopularRoomsSearchMessageParser() },
            { MessageEvent.RateFlatMessageEvent, new RateFlatMessageParser() },
            {
                MessageEvent.RemoveOwnRoomRightsRoomMessageEvent,
                new RemoveOwnRoomRightsRoomMessageParser()
            },
            {
                MessageEvent.RoomAdEventTabAdClickedEvent,
                new RoomAdEventTabAdClickedMessageParser()
            },
            { MessageEvent.RoomAdEventTabViewedEvent, new RoomAdEventTabViewedMessageParser() },
            { MessageEvent.RoomAdSearchMessageEvent, new RoomAdSearchMessageParser() },
            {
                MessageEvent.RoomsWhereMyFriendsAreSearchMessageEvent,
                new RoomsWhereMyFriendsAreSearchMessageParser()
            },
            {
                MessageEvent.RoomsWithHighestScoreSearchMessageEvent,
                new RoomsWithHighestScoreSearchMessageParser()
            },
            { MessageEvent.RoomTextSearchMessageEvent, new RoomTextSearchMessageParser() },
            { MessageEvent.SetRoomSessionTagsMessageEvent, new SetRoomSessionTagsMessageParser() },
            { MessageEvent.ToggleStaffPickMessageEvent, new ToggleStaffPickMessageParser() },
            { MessageEvent.UpdateHomeRoomMessageEvent, new UpdateHomeRoomMessageParser() },
            #endregion

            #region NewNavigator
            {
                MessageEvent.NavigatorAddCollapsedCategoryMessageEvent,
                new NavigatorAddCollapsedCategoryMessageParser()
            },
            {
                MessageEvent.NavigatorAddSavedSearchEvent,
                new NavigatorAddSavedSearchMessageParser()
            },
            {
                MessageEvent.NavigatorDeleteSavedSearchEvent,
                new NavigatorDeleteSavedSearchMessageParser()
            },
            {
                MessageEvent.NavigatorRemoveCollapsedCategoryMessageEvent,
                new NavigatorRemoveCollapsedCategoryMessageParser()
            },
            {
                MessageEvent.NavigatorSetSearchCodeViewModeMessageEvent,
                new NavigatorSetSearchCodeViewModeMessageParser()
            },
            { MessageEvent.NewNavigatorInitEvent, new NewNavigatorInitMessageParser() },
            { MessageEvent.NewNavigatorSearchEvent, new NewNavigatorSearchMessageParser() },
            #endregion

            #region Nft
            { MessageEvent.GetNftCreditsMessageEvent, new GetNftCreditsMessageParser() },
            {
                MessageEvent.GetSelectedNftWardrobeOutfitMessageEvent,
                new GetSelectedNftWardrobeOutfitMessageParser()
            },
            { MessageEvent.GetSilverMessageEvent, new GetSilverMessageParser() },
            { MessageEvent.GetUserNftWardrobeMessageEvent, new GetUserNftWardrobeMessageParser() },
            {
                MessageEvent.SaveUserNftWardrobeMessageEvent,
                new SaveUserNftWardrobeMessageParser()
            },
            #endregion

            #region Notifications
            { MessageEvent.ResetUnseenItemIdsEvent, new ResetUnseenItemIdsMessageParser() },
            { MessageEvent.ResetUnseenItemsEvent, new ResetUnseenItemsMessageParser() },
            #endregion

            #region Nux
            {
                MessageEvent.NewUserExperienceGetGiftsMessageEvent,
                new NewUserExperienceGetGiftsMessageParser()
            },
            {
                MessageEvent.NewUserExperienceScriptProceedEvent,
                new NewUserExperienceScriptProceedMessageParser()
            },
            { MessageEvent.SelectInitialRoomEvent, new SelectInitialRoomMessageParser() },
            #endregion

            #region Poll
            { MessageEvent.PollAnswerEvent, new PollAnswerMessageParser() },
            { MessageEvent.PollRejectEvent, new PollRejectMessageParser() },
            { MessageEvent.PollStartEvent, new PollStartMessageParser() },
            #endregion

            #region Preferences
            { MessageEvent.SetChatPreferencesMessageEvent, new SetChatPreferencesMessageParser() },
            { MessageEvent.SetChatStylePreferenceEvent, new SetChatStylePreferenceMessageParser() },
            {
                MessageEvent.SetIgnoreRoomInvitesMessageEvent,
                new SetIgnoreRoomInvitesMessageParser()
            },
            {
                MessageEvent.SetNewNavigatorWindowPreferencesMessageEvent,
                new SetNewNavigatorWindowPreferencesMessageParser()
            },
            {
                MessageEvent.SetRoomCameraPreferencesMessageEvent,
                new SetRoomCameraPreferencesMessageParser()
            },
            { MessageEvent.SetSoundSettingsEvent, new SetSoundSettingsMessageParser() },
            { MessageEvent.SetUIFlagsMessageEvent, new SetUIFlagsMessageParser() },
            #endregion

            #region Quest
            { MessageEvent.AcceptQuestMessageEvent, new AcceptQuestMessageParser() },
            { MessageEvent.ActivateQuestMessageEvent, new ActivateQuestMessageParser() },
            { MessageEvent.CancelQuestMessageEvent, new CancelQuestMessageParser() },
            {
                MessageEvent.FriendRequestQuestCompleteMessageEvent,
                new FriendRequestQuestCompleteMessageParser()
            },
            {
                MessageEvent.GetCommunityGoalHallOfFameMessageEvent,
                new GetCommunityGoalHallOfFameMessageParser()
            },
            {
                MessageEvent.GetCommunityGoalProgressMessageEvent,
                new GetCommunityGoalProgressMessageParser()
            },
            {
                MessageEvent.GetConcurrentUsersGoalProgressMessageEvent,
                new GetConcurrentUsersGoalProgressMessageParser()
            },
            {
                MessageEvent.GetConcurrentUsersRewardMessageEvent,
                new GetConcurrentUsersRewardMessageParser()
            },
            { MessageEvent.GetDailyQuestMessageEvent, new GetDailyQuestMessageParser() },
            { MessageEvent.GetQuestsMessageEvent, new GetQuestsMessageParser() },
            {
                MessageEvent.GetSeasonalQuestsOnlyMessageEvent,
                new GetSeasonalQuestsOnlyMessageParser()
            },
            { MessageEvent.OpenQuestTrackerMessageEvent, new OpenQuestTrackerMessageParser() },
            { MessageEvent.RejectQuestMessageEvent, new RejectQuestMessageParser() },
            { MessageEvent.StartCampaignMessageEvent, new StartCampaignMessageParser() },
            #endregion

            #region Register
            { MessageEvent.UpdateFigureDataMessageEvent, new UpdateFigureDataMessageParser() },
            #endregion

            #region Room
            { MessageEvent.AddSpamWallPostItMessageEvent, new AddSpamWallPostItMessageParser() },
            { MessageEvent.AmbassadorAlertMessageEvent, new AmbassadorAlertMessageParser() },
            { MessageEvent.AssignRightsMessageEvent, new AssignRightsMessageParser() },
            { MessageEvent.AvatarExpressionMessageEvent, new AvatarExpressionMessageParser() },
            {
                MessageEvent.BanUserWithDurationMessageEvent,
                new BanUserWithDurationMessageParser()
            },
            { MessageEvent.BreedPetsMessageEvent, new BreedPetsMessageParser() },
            { MessageEvent.CancelTypingMessageEvent, new CancelTypingMessageParser() },
            { MessageEvent.ChangeMottoMessageEvent, new ChangeMottoMessageParser() },
            { MessageEvent.ChangePostureMessageEvent, new ChangePostureMessageParser() },
            { MessageEvent.ChangeQueueMessageEvent, new ChangeQueueMessageParser() },
            { MessageEvent.ChatMessageEvent, new ChatMessageParser() },
            { MessageEvent.ClickFurniMessageEvent, new ClickFurniMessageParser() },
            { MessageEvent.CommandBotEvent, new CommandBotMessageParser() },
            {
                MessageEvent.ControlYoutubeDisplayPlaybackMessageEvent,
                new ControlYoutubeDisplayPlaybackMessageParser()
            },
            { MessageEvent.CreditFurniRedeemMessageEvent, new CreditFurniRedeemMessageParser() },
            {
                MessageEvent.CustomizeAvatarWithFurniMessageEvent,
                new CustomizeAvatarWithFurniMessageParser()
            },
            { MessageEvent.CustomizePetWithFurniEvent, new CustomizePetWithFurniMessageParser() },
            { MessageEvent.DanceMessageEvent, new DanceMessageParser() },
            { MessageEvent.DiceOffMessageEvent, new DiceOffMessageParser() },
            { MessageEvent.DropCarryItemMessageEvent, new DropCarryItemMessageParser() },
            { MessageEvent.EnterOneWayDoorMessageEvent, new EnterOneWayDoorMessageParser() },
            {
                MessageEvent.ExtendRentOrBuyoutFurniMessageEvent,
                new ExtendRentOrBuyoutFurniMessageParser()
            },
            {
                MessageEvent.ExtendRentOrBuyoutStripItemMessageEvent,
                new ExtendRentOrBuyoutStripItemMessageParser()
            },
            {
                MessageEvent.GetBotCommandConfigurationDataEvent,
                new GetBotCommandConfigurationDataMessageParser()
            },
            {
                MessageEvent.GetFurnitureAliasesMessageEvent,
                new GetFurnitureAliasesMessageParser()
            },
            {
                MessageEvent.GetGuildFurniContextMenuInfoMessageEvent,
                new GetGuildFurniContextMenuInfoMessageParser()
            },
            { MessageEvent.GetHeightMapMessageEvent, new GetHeightMapMessageParser() },
            { MessageEvent.GetItemDataMessageEvent, new GetItemDataMessageParser() },
            { MessageEvent.GetOccupiedTilesMessageEvent, new GetOccupiedTilesMessageParser() },
            { MessageEvent.GetPetCommandsMessageEvent, new GetPetCommandsMessageParser() },
            { MessageEvent.GetPetInfoMessageEvent, new GetPetInfoMessageParser() },
            {
                MessageEvent.GetRentOrBuyoutOfferMessageEvent,
                new GetRentOrBuyoutOfferMessageParser()
            },
            { MessageEvent.GetRoomEntryTileMessageEvent, new GetRoomEntryTileMessageParser() },
            {
                MessageEvent.GetYoutubeDisplayStatusMessageEvent,
                new GetYoutubeDisplayStatusMessageParser()
            },
            {
                MessageEvent.GiveSupplementToPetMessageEvent,
                new GiveSupplementToPetMessageParser()
            },
            { MessageEvent.KickUserMessageEvent, new KickUserMessageParser() },
            { MessageEvent.LetUserInMessageEvent, new LetUserInMessageParser() },
            { MessageEvent.LookToMessageEvent, new LookToMessageParser() },
            { MessageEvent.MountPetMessageEvent, new MountPetMessageParser() },
            { MessageEvent.MoveAvatarMessageEvent, new MoveAvatarMessageParser() },
            { MessageEvent.MoveObjectMessageEvent, new MoveObjectMessageParser() },
            { MessageEvent.MovePetMessageEvent, new MovePetMessageParser() },
            { MessageEvent.MoveWallItemMessageEvent, new MoveWallItemMessageParser() },
            { MessageEvent.MuteAllInRoomEvent, new MuteAllInRoomMessageParser() },
            { MessageEvent.MuteUserMessageEvent, new MuteUserMessageParser() },
            { MessageEvent.OpenFlatConnectionMessageEvent, new OpenFlatConnectionMessageParser() },
            { MessageEvent.OpenMysteryTrophyMessageEvent, new OpenMysteryTrophyMessageParser() },
            { MessageEvent.OpenPetPackageMessageEvent, new OpenPetPackageMessageParser() },
            { MessageEvent.PassCarryItemMessageEvent, new PassCarryItemMessageParser() },
            { MessageEvent.PassCarryItemToPetMessageEvent, new PassCarryItemToPetMessageParser() },
            { MessageEvent.PetSelectedMessageEvent, new PetSelectedMessageParser() },
            { MessageEvent.PickupObjectMessageEvent, new PickupObjectMessageParser() },
            { MessageEvent.PlaceBotMessageEvent, new PlaceBotMessageParser() },
            { MessageEvent.PlaceObjectMessageEvent, new PlaceObjectMessageParser() },
            { MessageEvent.PlacePetMessageEvent, new PlacePetMessageParser() },
            { MessageEvent.PlacePostItMessageEvent, new PlacePostItMessageParser() },
            { MessageEvent.PresentOpenMessageEvent, new PresentOpenMessageParser() },
            { MessageEvent.QuitMessageEvent, new QuitMessageParser() },
            { MessageEvent.RemoveAllRightsMessageEvent, new RemoveAllRightsMessageParser() },
            { MessageEvent.RemoveBotFromFlatMessageEvent, new RemoveBotFromFlatMessageParser() },
            { MessageEvent.RemoveItemMessageEvent, new RemoveItemMessageParser() },
            { MessageEvent.RemovePetFromFlatMessageEvent, new RemovePetFromFlatMessageParser() },
            { MessageEvent.RemoveRightsMessageEvent, new RemoveRightsMessageParser() },
            {
                MessageEvent.RemoveSaddleFromPetMessageEvent,
                new RemoveSaddleFromPetMessageParser()
            },
            {
                MessageEvent.RentableSpaceCancelRentMessageEvent,
                new RentableSpaceCancelRentMessageParser()
            },
            { MessageEvent.RentableSpaceRentMessageEvent, new RentableSpaceRentMessageParser() },
            {
                MessageEvent.RentableSpaceStatusMessageEvent,
                new RentableSpaceStatusMessageParser()
            },
            { MessageEvent.RespectPetMessageEvent, new RespectPetMessageParser() },
            {
                MessageEvent.RoomDimmerChangeStateMessageEvent,
                new RoomDimmerChangeStateMessageParser()
            },
            {
                MessageEvent.RoomDimmerGetPresetsMessageEvent,
                new RoomDimmerGetPresetsMessageParser()
            },
            {
                MessageEvent.RoomDimmerSavePresetMessageEvent,
                new RoomDimmerSavePresetMessageParser()
            },
            { MessageEvent.SetAreaHideDataEvent, new SetAreaHideDataMessageParser() },
            {
                MessageEvent.SetClothingChangeDataMessageEvent,
                new SetClothingChangeDataMessageParser()
            },
            {
                MessageEvent.SetCustomStackingHeightEvent,
                new SetCustomStackingHeightMessageParser()
            },
            { MessageEvent.SetItemDataMessageEvent, new SetItemDataMessageParser() },
            { MessageEvent.SetMannequinFigureEvent, new SetMannequinFigureMessageParser() },
            { MessageEvent.SetMannequinNameEvent, new SetMannequinNameMessageParser() },
            { MessageEvent.SetObjectDataMessageEvent, new SetObjectDataMessageParser() },
            { MessageEvent.SetRandomStateMessageEvent, new SetRandomStateMessageParser() },
            {
                MessageEvent.SetRoomBackgroundColorDataEvent,
                new SetRoomBackgroundColorDataMessageParser()
            },
            {
                MessageEvent.SetYoutubeDisplayPlaylistMessageEvent,
                new SetYoutubeDisplayPlaylistMessageParser()
            },
            { MessageEvent.ShoutMessageEvent, new ShoutMessageParser() },
            { MessageEvent.SignMessageEvent, new SignMessageParser() },
            { MessageEvent.SpinWheelOfFortuneMessageEvent, new SpinWheelOfFortuneMessageParser() },
            { MessageEvent.StartTypingMessageEvent, new StartTypingMessageParser() },
            { MessageEvent.ThrowDiceMessageEvent, new ThrowDiceMessageParser() },
            {
                MessageEvent.TogglePetBreedingPermissionMessageEvent,
                new TogglePetBreedingPermissionMessageParser()
            },
            {
                MessageEvent.TogglePetRidingPermissionMessageEvent,
                new TogglePetRidingPermissionMessageParser()
            },
            { MessageEvent.UnbanUserFromRoomMessageEvent, new UnbanUserFromRoomMessageParser() },
            { MessageEvent.UnmuteUserMessageEvent, new UnmuteUserMessageParser() },
            {
                MessageEvent.UpdateFloorPropertiesMessageEvent,
                new UpdateFloorPropertiesMessageParser()
            },
            { MessageEvent.UseFurnitureMessageEvent, new UseFurnitureMessageParser() },
            { MessageEvent.UseWallItemMessageEvent, new UseWallItemMessageParser() },
            { MessageEvent.WhisperMessageEvent, new WhisperMessageParser() },
            #endregion

            #region Roomdirectory
            {
                MessageEvent.RoomNetworkOpenConnectionMessageEvent,
                new RoomNetworkOpenConnectionMessageParser()
            },
            #endregion

            #region RoomSettings
            { MessageEvent.DeleteRoomMessageEvent, new DeleteRoomMessageParser() },
            {
                MessageEvent.GetBannedUsersFromRoomMessageEvent,
                new GetBannedUsersFromRoomMessageParser()
            },
            {
                MessageEvent.GetCustomRoomFilterMessageEvent,
                new GetCustomRoomFilterMessageParser()
            },
            { MessageEvent.GetFlatControllersMessageEvent, new GetFlatControllersMessageParser() },
            { MessageEvent.GetRoomSettingsMessageEvent, new GetRoomSettingsMessageParser() },
            { MessageEvent.SaveRoomSettingsMessageEvent, new SaveRoomSettingsMessageParser() },
            {
                MessageEvent.UpdateRoomCategoryAndTradeSettingsEvent,
                new UpdateRoomCategoryAndTradeSettingsMessageParser()
            },
            { MessageEvent.UpdateRoomFilterMessageEvent, new UpdateRoomFilterMessageParser() },
            #endregion

            #region Sound
            { MessageEvent.AddJukeboxDiskEvent, new AddJukeboxDiskMessageParser() },
            { MessageEvent.GetJukeboxPlayListMessageEvent, new GetJukeboxPlayListMessageParser() },
            { MessageEvent.GetNowPlayingMessageEvent, new GetNowPlayingMessageParser() },
            { MessageEvent.GetOfficialSongIdMessageEvent, new GetOfficialSongIdMessageParser() },
            { MessageEvent.GetSongInfoMessageEvent, new GetSongInfoMessageParser() },
            {
                MessageEvent.GetSoundMachinePlayListMessageEvent,
                new GetSoundMachinePlayListMessageParser()
            },
            { MessageEvent.GetSoundSettingsEvent, new GetSoundSettingsMessageParser() },
            { MessageEvent.GetUserSongDisksMessageEvent, new GetUserSongDisksMessageParser() },
            { MessageEvent.RemoveJukeboxDiskEvent, new RemoveJukeboxDiskMessageParser() },
            #endregion

            #region Talent
            {
                MessageEvent.GetTalentTrackLevelMessageEvent,
                new GetTalentTrackLevelMessageParser()
            },
            { MessageEvent.GetTalentTrackMessageEvent, new GetTalentTrackMessageParser() },
            {
                MessageEvent.GuideAdvertisementReadMessageEvent,
                new GuideAdvertisementReadMessageParser()
            },
            #endregion

            #region Tracking
            { MessageEvent.EventLogMessageEvent, new EventLogMessageParser() },
            { MessageEvent.LagWarningReportMessageEvent, new LagWarningReportMessageParser() },
            { MessageEvent.LatencyPingReportMessageEvent, new LatencyPingReportMessageParser() },
            { MessageEvent.LatencyPingRequestMessageEvent, new LatencyPingRequestMessageParser() },
            { MessageEvent.PerformanceLogMessageEvent, new PerformanceLogMessageParser() },
            #endregion

            #region Userclassification
            {
                MessageEvent.PeerUsersClassificationMessageEvent,
                new PeerUsersClassificationMessageParser()
            },
            {
                MessageEvent.RoomUsersClassificationMessageEvent,
                new RoomUsersClassificationMessageParser()
            },
            #endregion

            #region Userdefinedroomevents
            { MessageEvent.ApplySnapshotMessageEvent, new ApplySnapshotMessageParser() },
            { MessageEvent.OpenMessageEvent, new OpenMessageParser() },
            { MessageEvent.UpdateActionMessageEvent, new UpdateActionMessageParser() },
            { MessageEvent.UpdateAddonMessageEvent, new UpdateAddonMessageParser() },
            { MessageEvent.UpdateConditionMessageEvent, new UpdateConditionMessageParser() },
            { MessageEvent.UpdateSelectorMessageEvent, new UpdateSelectorMessageParser() },
            { MessageEvent.UpdateTriggerMessageEvent, new UpdateTriggerMessageParser() },
            { MessageEvent.UpdateVariableMessageEvent, new UpdateVariableMessageParser() },
            {
                MessageEvent.WiredClearErrorLogsMessageEvent,
                new WiredClearErrorLogsMessageParser()
            },
            {
                MessageEvent.WiredGetAllVariableHoldersMessageEvent,
                new WiredGetAllVariableHoldersMessageParser()
            },
            {
                MessageEvent.WiredGetAllVariablesDiffsMessageEvent,
                new WiredGetAllVariablesDiffsMessageParser()
            },
            {
                MessageEvent.WiredGetAllVariablesHashMessageEvent,
                new WiredGetAllVariablesHashMessageParser()
            },
            { MessageEvent.WiredGetErrorLogsMessageEvent, new WiredGetErrorLogsMessageParser() },
            {
                MessageEvent.WiredGetRoomSettingsMessageEvent,
                new WiredGetRoomSettingsMessageParser()
            },
            { MessageEvent.WiredGetRoomStatsMessageEvent, new WiredGetRoomStatsMessageParser() },
            {
                MessageEvent.WiredGetVariablesForObjectMessageEvent,
                new WiredGetVariablesForObjectMessageParser()
            },
            {
                MessageEvent.WiredSetObjectVariableValueMessageEvent,
                new WiredSetObjectVariableValueMessageParser()
            },
            {
                MessageEvent.WiredSetPreferencesMessageEvent,
                new WiredSetPreferencesMessageParser()
            },
            {
                MessageEvent.WiredSetRoomSettingsMessageEvent,
                new WiredSetRoomSettingsMessageParser()
            },
            #endregion

            #region Users
            {
                MessageEvent.AddAdminRightsToMemberMessageEvent,
                new AddAdminRightsToMemberMessageParser()
            },
            {
                MessageEvent.ApproveAllMembershipRequestsMessageEvent,
                new ApproveAllMembershipRequestsMessageParser()
            },
            {
                MessageEvent.ApproveMembershipRequestMessageEvent,
                new ApproveMembershipRequestMessageParser()
            },
            { MessageEvent.ApproveNameMessageEvent, new ApproveNameMessageParser() },
            { MessageEvent.ChangeEmailEvent, new ChangeEmailMessageParser() },
            { MessageEvent.CreateGuildMessageEvent, new CreateGuildMessageParser() },
            { MessageEvent.DeactivateGuildMessageEvent, new DeactivateGuildMessageParser() },
            {
                MessageEvent.DeselectFavouriteHabboGroupMessageEvent,
                new DeselectFavouriteHabboGroupMessageParser()
            },
            { MessageEvent.GetEmailStatusEvent, new GetEmailStatusMessageParser() },
            {
                MessageEvent.GetExtendedProfileByNameMessageEvent,
                new GetExtendedProfileByNameMessageParser()
            },
            { MessageEvent.GetExtendedProfileMessageEvent, new GetExtendedProfileMessageParser() },
            {
                MessageEvent.GetGuildCreationInfoMessageEvent,
                new GetGuildCreationInfoMessageParser()
            },
            { MessageEvent.GetGuildEditInfoMessageEvent, new GetGuildEditInfoMessageParser() },
            { MessageEvent.GetGuildEditorDataMessageEvent, new GetGuildEditorDataMessageParser() },
            {
                MessageEvent.GetGuildMembershipsMessageEvent,
                new GetGuildMembershipsMessageParser()
            },
            { MessageEvent.GetGuildMembersMessageEvent, new GetGuildMembersMessageParser() },
            {
                MessageEvent.GetHabboGroupBadgesMessageEvent,
                new GetHabboGroupBadgesMessageParser()
            },
            {
                MessageEvent.GetHabboGroupDetailsMessageEvent,
                new GetHabboGroupDetailsMessageParser()
            },
            { MessageEvent.GetIgnoredUsersMessageEvent, new GetIgnoredUsersMessageParser() },
            {
                MessageEvent.GetMemberGuildItemCountMessageEvent,
                new GetMemberGuildItemCountMessageParser()
            },
            { MessageEvent.GetMOTDMessageEvent, new GetMOTDMessageParser() },
            {
                MessageEvent.GetRelationshipStatusInfoMessageEvent,
                new GetRelationshipStatusInfoMessageParser()
            },
            { MessageEvent.GetSelectedBadgesMessageEvent, new GetSelectedBadgesMessageParser() },
            {
                MessageEvent.GetUserNftChatStylesMessageEvent,
                new GetUserNftChatStylesMessageParser()
            },
            { MessageEvent.GiveStarGemToUserMessageEvent, new GiveStarGemToUserMessageParser() },
            { MessageEvent.IgnoreUserMessageEvent, new IgnoreUserMessageParser() },
            { MessageEvent.JoinHabboGroupMessageEvent, new JoinHabboGroupMessageParser() },
            { MessageEvent.KickMemberMessageEvent, new KickMemberMessageParser() },
            {
                MessageEvent.RejectMembershipRequestMessageEvent,
                new RejectMembershipRequestMessageParser()
            },
            {
                MessageEvent.RemoveAdminRightsFromMemberMessageEvent,
                new RemoveAdminRightsFromMemberMessageParser()
            },
            { MessageEvent.ScrGetKickbackInfoMessageEvent, new ScrGetKickbackInfoMessageParser() },
            { MessageEvent.ScrGetUserInfoMessageEvent, new ScrGetUserInfoMessageParser() },
            {
                MessageEvent.SelectFavouriteHabboGroupMessageEvent,
                new SelectFavouriteHabboGroupMessageParser()
            },
            { MessageEvent.UnblockGroupMemberMessageEvent, new UnblockGroupMemberMessageParser() },
            { MessageEvent.UnignoreUserMessageEvent, new UnignoreUserMessageParser() },
            { MessageEvent.UpdateGuildBadgeMessageEvent, new UpdateGuildBadgeMessageParser() },
            { MessageEvent.UpdateGuildColorsMessageEvent, new UpdateGuildColorsMessageParser() },
            {
                MessageEvent.UpdateGuildIdentityMessageEvent,
                new UpdateGuildIdentityMessageParser()
            },
            {
                MessageEvent.UpdateGuildSettingsMessageEvent,
                new UpdateGuildSettingsMessageParser()
            },
            #endregion

            #region Vault
            { MessageEvent.CreditVaultStatusMessageEvent, new CreditVaultStatusMessageParser() },
            { MessageEvent.IncomeRewardClaimMessageEvent, new IncomeRewardClaimMessageParser() },
            { MessageEvent.IncomeRewardStatusMessageEvent, new IncomeRewardStatusMessageParser() },
            {
                MessageEvent.WithdrawCreditVaultMessageEvent,
                new WithdrawCreditVaultMessageParser()
            },
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
                typeof(FriendListUpdateMessageComposer),
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
                typeof(NavigatorSearchResultBlocksMessageComposer),
                new NavigatorSearchResultBlocksMessageSerializer(
                    MessageComposer.NavigatorSearchResultBlocksComposer
                )
            },
            {
                typeof(NewNavigatorPreferencesMessageComposer),
                new NewNavigatorPreferencesMessageSerializer(
                    MessageComposer.NewNavigatorPreferencesComposer
                )
            },
            #endregion

            #region Preferences
            {
                typeof(AccountPreferencesEventMessageComposer),
                new AccountPreferencesEventMessageComposerSerializer(
                    MessageComposer.AccountPreferencesComposer
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
                typeof(ScrSendUserInfoMessageComposer),
                new ScrSendUserInfoMessageSerializer(MessageComposer.ScrSendUserInfoComposer)
            },
            #endregion
        };
    #endregion
}
