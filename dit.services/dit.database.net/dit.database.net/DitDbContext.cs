using System;
using System.Collections.Generic;
using dit.database.net.Entitities;
using dit.database.net.Configurations;
using Microsoft.EntityFrameworkCore;

namespace dit.database.net;

public partial class DitDbContext : DbContext
{
    public DitDbContext()
    {
    }

    public DitDbContext(DbContextOptions<DitDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Accounting> Accountings { get; set; } = null!;

    public virtual DbSet<Country> Countries { get; set; } = null!;

    public virtual DbSet<DitcmsInfo> DitcmsInfos { get; set; } = null!;
    public virtual DbSet<Event> Events { get; set; } = null!;

    public virtual DbSet<Favorite> Favorites { get; set; } = null!;

    public virtual DbSet<FormCcontact> FormCcontacts { get; set; } = null!;

    public virtual DbSet<FormContact> FormContacts { get; set; } = null!;

    public virtual DbSet<FormInfoTekstNieuwsflash> FormInfoTekstNieuwsflashes { get; set; } = null!;

    public virtual DbSet<FormTestForm> FormTestForms { get; set; } = null!;

    public virtual DbSet<Groupright> Grouprights { get; set; } = null!;

    public virtual DbSet<Groupright1> Grouprights1 { get; set; } = null!;

    public virtual DbSet<Iva> Ivas { get; set; } = null!;

    public virtual DbSet<IvaItem> IvaItems { get; set; } = null!;    

    public virtual DbSet<Language> Languages { get; set; } = null!;

    public virtual DbSet<LanguageSite> LanguageSites { get; set; } = null!;

    public virtual DbSet<Mailtemplate> Mailtemplates { get; set; } = null!;

    public virtual DbSet<MailtemplateTemplate> MailtemplateTemplates { get; set; } = null!;

    public virtual DbSet<ManualBarcode> ManualBarcodes { get; set; } = null!;

    public virtual DbSet<Manufacturer> Manufacturers { get; set; } = null!;

    public virtual DbSet<ModArticle> ModArticles { get; set; } = null!;

    public virtual DbSet<ModArticlesArticle> ModArticlesArticles { get; set; } = null!;

    public virtual DbSet<ModArticlesArticleRelated> ModArticlesArticleRelateds { get; set; } = null!;

    public virtual DbSet<ModArticlesArticleRevision> ModArticlesArticleRevisions { get; set; } = null!;

    public virtual DbSet<ModArticlesArticleToCategory> ModArticlesArticleToCategories { get; set; } = null!;

    public virtual DbSet<ModArticlesArticleToTag> ModArticlesArticleToTags { get; set; } = null!;

    public virtual DbSet<ModArticlesCategory> ModArticlesCategories { get; set; } = null!;

    public virtual DbSet<ModArticlesChangelog> ModArticlesChangelogs { get; set; } = null!;

    public virtual DbSet<ModArticlesComment> ModArticlesComments { get; set; } = null!;

    public virtual DbSet<ModArticlesTag> ModArticlesTags { get; set; } = null!;

    public virtual DbSet<ModArticlesVote> ModArticlesVotes { get; set; } = null!;

    public virtual DbSet<ModBanner> ModBanners { get; set; } = null!;    

    public virtual DbSet<ModBannerImage> ModBannerImages { get; set; } = null!;

    public virtual DbSet<ModBannerStat> ModBannerStats { get; set; } = null!;

    public virtual DbSet<ModClubAgegroup> ModClubAgegroups { get; set; } = null!;

    public virtual DbSet<ModClubConfig> ModClubConfigs { get; set; } = null!;

    public virtual DbSet<ModClubEvent> ModClubEvents { get; set; } = null!;

    public virtual DbSet<ModClubEventComment> ModClubEventComments { get; set; } = null!;

    public virtual DbSet<ModClubEventDate> ModClubEventDates { get; set; } = null!;

    public virtual DbSet<ModClubEventImage> ModClubEventImages { get; set; } = null!;

    public virtual DbSet<ModClubEventMembertype> ModClubEventMembertypes { get; set; } = null!;

    public virtual DbSet<ModClubEventOrganisator> ModClubEventOrganisators { get; set; } = null!;

    public virtual DbSet<ModClubNotification> ModClubNotifications { get; set; } = null!;

    public virtual DbSet<ModClubTag> ModClubTags { get; set; } = null!;

    public virtual DbSet<ModClubTransaction> ModClubTransactions { get; set; } = null!;

    public virtual DbSet<ModClubUser> ModClubUsers { get; set; } = null!;

    public virtual DbSet<ModClubUserAuth> ModClubUserAuths { get; set; } = null!;

    public virtual DbSet<ModClubUserBlacklist> ModClubUserBlacklists { get; set; } = null!;

    public virtual DbSet<ModClubUserEvent> ModClubUserEvents { get; set; } = null!;

    public virtual DbSet<ModClubUserOld> ModClubUserOlds { get; set; } = null!;

    public virtual DbSet<ModClubUserSubscription> ModClubUserSubscriptions { get; set; } = null!;

    public virtual DbSet<ModClubWallpost> ModClubWallposts { get; set; } = null!;

    public virtual DbSet<ModClubWallpostComment> ModClubWallpostComments { get; set; } = null!;

    public virtual DbSet<ModClubWallpostImage> ModClubWallpostImages { get; set; } = null!;

    public virtual DbSet<ModCommunityAddress> ModCommunityAddresses { get; set; } = null!;

    public virtual DbSet<ModCommunityGroup> ModCommunityGroups { get; set; } = null!;

    public virtual DbSet<ModCommunityMailtemplate> ModCommunityMailtemplates { get; set; } = null!;

    public virtual DbSet<ModCommunityModule> ModCommunityModules { get; set; } = null!;

    public virtual DbSet<ModCommunityModuleInstance> ModCommunityModuleInstances { get; set; } = null!;

    public virtual DbSet<ModCommunityRegister> ModCommunityRegisters { get; set; } = null!;

    public virtual DbSet<ModCommunitySignup> ModCommunitySignups { get; set; } = null!; 

    public virtual DbSet<ModCommunityTemplateModuleinstance> ModCommunityTemplateModuleinstances { get; set; } = null!;

    public virtual DbSet<ModCommunityUser> ModCommunityUsers { get; set; } = null!;

    public virtual DbSet<ModCommunityView> ModCommunityViews { get; set; } = null!;

    public virtual DbSet<ModForm> ModForms { get; set; } = null!;

    public virtual DbSet<ModFormChoice> ModFormChoices { get; set; } = null!;

    public virtual DbSet<ModFormField> ModFormFields { get; set; } = null!;

    public virtual DbSet<ModForum> ModForums { get; set; } = null!;

    public virtual DbSet<ModForumCategory> ModForumCategories { get; set; } = null!;

    public virtual DbSet<ModForumForum> ModForumForums { get; set; } = null!;

    public virtual DbSet<ModForumPost> ModForumPosts { get; set; } = null!;

    public virtual DbSet<ModForumUser> ModForumUsers { get; set; } = null!;

    public virtual DbSet<ModLink> ModLinks { get; set; } = null!;

    public virtual DbSet<ModLinksLink> ModLinksLinks { get; set; } = null!;

    public virtual DbSet<ModMailinglist> ModMailinglists { get; set; } = null!;

    public virtual DbSet<ModMailinglistArchive> ModMailinglistArchives { get; set; } = null!;

    public virtual DbSet<ModMailinglistBlockType> ModMailinglistBlockTypes { get; set; } = null!;

    public virtual DbSet<ModMailinglistEasyblock> ModMailinglistEasyblocks { get; set; } = null!;

    public virtual DbSet<ModMailinglistEasyimg> ModMailinglistEasyimgs { get; set; } = null!;

    public virtual DbSet<ModMailinglistEasymail> ModMailinglistEasymails { get; set; } = null!;

    public virtual DbSet<ModMailinglistMailOption> ModMailinglistMailOptions { get; set; } = null!;

    public virtual DbSet<ModMailinglistProfile> ModMailinglistProfiles { get; set; } = null!;

    public virtual DbSet<ModMailinglistProfilesSubscription> ModMailinglistProfilesSubscriptions { get; set; } = null!;

    public virtual DbSet<ModMailinglistProfilingSubscription> ModMailinglistProfilingSubscriptions { get; set; } = null!;

    public virtual DbSet<ModMailinglistSaved> ModMailinglistSaveds { get; set; } = null!;

    public virtual DbSet<ModMailinglistServer> ModMailinglistServers { get; set; } = null!;

    public virtual DbSet<ModMailinglistSubscription> ModMailinglistSubscriptions { get; set; } = null!;

    public virtual DbSet<ModMailinglistSubscription2> ModMailinglistSubscription2s { get; set; } = null!;

    public virtual DbSet<ModMailinglistTemplate> ModMailinglistTemplates { get; set; } = null!;

    public virtual DbSet<ModPoll> ModPolls { get; set; } = null!;

    public virtual DbSet<ModPollClubVoter> ModPollClubVoters { get; set; } = null!;

    public virtual DbSet<ModPollOption> ModPollOptions { get; set; } = null!;

    public virtual DbSet<ModPollTranslation> ModPollTranslations { get; set; } = null!;

    public virtual DbSet<ModPollVoter> ModPollVoters { get; set; } = null!;

    public virtual DbSet<ModSimpleimage> ModSimpleimages { get; set; } = null!;

    public virtual DbSet<ModSimpleimageImage> ModSimpleimageImages { get; set; } = null!;

    public virtual DbSet<ModSocialModuleinstance> ModSocialModuleinstances { get; set; } = null!;

    public virtual DbSet<ModTweet> ModTweets { get; set; } = null!;

    public virtual DbSet<Module> Modules { get; set; } = null!;

    public virtual DbSet<Moduleinstance> Moduleinstances { get; set; } = null!;

    public virtual DbSet<Moduleright> Modulerights { get; set; } = null!;

    public virtual DbSet<Owner> Owners { get; set; } = null!;

    public virtual DbSet<Page> Pages { get; set; } = null!;

    public virtual DbSet<PageLanguage> PageLanguages { get; set; } = null!;

    public virtual DbSet<PageModuleinstance> PageModuleinstances { get; set; } = null!;

    public virtual DbSet<Pageview> Pageviews { get; set; } = null!;

    public virtual DbSet<Searchtable> Searchtables { get; set; } = null!;

    public virtual DbSet<Security> Securities { get; set; } = null!;

    public virtual DbSet<SecurityIp> SecurityIps { get; set; } = null!;

    public virtual DbSet<Sitemapobject> Sitemapobjects { get; set; } = null!;

    public virtual DbSet<SitemapobjectLanguage> SitemapobjectLanguages { get; set; } = null!;

    public virtual DbSet<SitemapobjectPage> SitemapobjectPages { get; set; } = null!;

    public virtual DbSet<SitemapobjectRight> SitemapobjectRights { get; set; } = null!;

    public virtual DbSet<Social> Socials { get; set; } = null!;

    public virtual DbSet<SocialCache> SocialCaches { get; set; } = null!;

    public virtual DbSet<SocialResponse> SocialResponses { get; set; } = null!;

    public virtual DbSet<Special> Specials { get; set; } = null!;

    public virtual DbSet<Statistic> Statistics { get; set; } = null!;

    public virtual DbSet<User> Users { get; set; } = null!;

    public virtual DbSet<UserOep> UserOeps { get; set; } = null!;

    public virtual DbSet<Usergroup> Usergroups { get; set; } = null!;

    public virtual DbSet<UsergroupUser> UsergroupUsers { get; set; } = null!;

    public virtual DbSet<Website> Websites { get; set; } = null!;

    public virtual DbSet<WebsiteLanguage> WebsiteLanguages { get; set; } = null!;

    public virtual DbSet<WebsiteRight> WebsiteRights { get; set; } = null!;

    public virtual DbSet<WebsiteStylesheet> WebsiteStylesheets { get; set; } = null!;
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new AccountingConfiguration());
        modelBuilder.ApplyConfiguration(new CountryConfiguration());
        modelBuilder.ApplyConfiguration(new DitcmsInfoConfiguration());
        modelBuilder.ApplyConfiguration(new EventConfiguration());
        modelBuilder.ApplyConfiguration(new FavoriteConfiguration());
        modelBuilder.ApplyConfiguration(new FormCcontactConfiguration());
        modelBuilder.ApplyConfiguration(new FormContactConfiguration());
        modelBuilder.ApplyConfiguration(new FormInfoTextNieuwsflashConfiguration());
        modelBuilder.ApplyConfiguration(new FormTestFormConfiguration());
        modelBuilder.ApplyConfiguration(new GrouprightConfiguration());
        modelBuilder.ApplyConfiguration(new Groupright1Configuration());
        modelBuilder.ApplyConfiguration(new IvaConfiguration());
        modelBuilder.ApplyConfiguration(new IvaItemConfiguration());
        modelBuilder.ApplyConfiguration(new LanguageConfiguration());
        modelBuilder.ApplyConfiguration(new LanguageSiteConfiguration());
        modelBuilder.ApplyConfiguration(new MailtemplateConfiguration());
        modelBuilder.ApplyConfiguration(new MailtemplateTemplateConfiguration());
        modelBuilder.ApplyConfiguration(new ManualBarcodeConfiguration());
        modelBuilder.ApplyConfiguration(new ManufacturerConfiguration());
        modelBuilder.ApplyConfiguration(new ModArticleConfiguration());
        modelBuilder.ApplyConfiguration(new ModArticlesArticleConfiguration());
        modelBuilder.ApplyConfiguration(new ModArticlesArticleConfiguration());
        modelBuilder.ApplyConfiguration(new ModArticlesArticleRelatedConfiguration());
        modelBuilder.ApplyConfiguration(new ModArticlesArticleRevisionConfiguration());
        modelBuilder.ApplyConfiguration(new ModArticlesArticleToCategoryConfiguration());
        modelBuilder.ApplyConfiguration(new ModArticlesArticleToTagConfiguration());
        modelBuilder.ApplyConfiguration(new ModArticlesCategoryConfiguration());
        modelBuilder.ApplyConfiguration(new ModArticlesChangelogConfiguration());
        modelBuilder.ApplyConfiguration(new ModArticlesCommentConfiguration());
        modelBuilder.ApplyConfiguration(new ModArticlesTagConfiguration());
        modelBuilder.ApplyConfiguration(new ModArticlesVoteConfiguration());
        modelBuilder.ApplyConfiguration(new ModBannerConfiguration());
        modelBuilder.ApplyConfiguration(new ModBannerImageConfiguration());
        modelBuilder.ApplyConfiguration(new ModBannerStatConfiguration());
        modelBuilder.ApplyConfiguration(new ModClubAgegroupConfiguration());
        modelBuilder.ApplyConfiguration(new ModClubConfigConfiguration());
        modelBuilder.ApplyConfiguration(new ModClubEventConfiguration());
        modelBuilder.ApplyConfiguration(new ModClubEventCommentConfiguration());
        modelBuilder.ApplyConfiguration(new ModClubEventDateConfiguration());
        modelBuilder.ApplyConfiguration(new ModClubEventImageConfiguration());
        modelBuilder.ApplyConfiguration(new ModClubEventMembertypeConfiguration());
        modelBuilder.ApplyConfiguration(new ModClubEventOrganisatorConfiguration());
        modelBuilder.ApplyConfiguration(new ModClubNotificationConfiguration());
        modelBuilder.ApplyConfiguration(new ModClubTagConfiguration());
        modelBuilder.ApplyConfiguration(new ModClubTransactionConfiguration());
        modelBuilder.ApplyConfiguration(new ModClubUserConfiguration());
        modelBuilder.ApplyConfiguration(new ModClubUserAuthConfiguration());
        modelBuilder.ApplyConfiguration(new ModClubUserBlacklistConfiguration());
        modelBuilder.ApplyConfiguration(new ModClubUserEventConfiguration());
        modelBuilder.ApplyConfiguration(new ModClubUserOldConfiguration());
        modelBuilder.ApplyConfiguration(new ModClubUserSubscriptionConfiguration());
        modelBuilder.ApplyConfiguration(new ModClubWallPostConfiguration());
        modelBuilder.ApplyConfiguration(new ModClubWallpostCommentConfiguration());
        modelBuilder.ApplyConfiguration(new ModClubWallpostImageConfiguration());
        modelBuilder.ApplyConfiguration(new ModCommunityAddressConfiguration());
        modelBuilder.ApplyConfiguration(new ModCommunityGroupConfiguration());
        modelBuilder.ApplyConfiguration(new ModCommunityMailtemplateConfiguration());
        modelBuilder.ApplyConfiguration(new ModCommunityModuleConfiguration());
        modelBuilder.ApplyConfiguration(new ModCommunityModuleInstanceConfiguration());
        modelBuilder.ApplyConfiguration(new ModCommunityRegisterConfiguration());
        modelBuilder.ApplyConfiguration(new ModCommunitySignupConfiguration());
        modelBuilder.ApplyConfiguration(new ModCommunityTemplateModuleinstanceConfiguration());
        modelBuilder.ApplyConfiguration(new ModCommunityUserConfiguration());
        modelBuilder.ApplyConfiguration(new ModCommunityViewConfiguration());
        modelBuilder.ApplyConfiguration(new ModFormConfiguration());
        modelBuilder.ApplyConfiguration(new ModFormChoiceConfiguration());
        modelBuilder.ApplyConfiguration(new ModFormFieldConfiguration());
        modelBuilder.ApplyConfiguration(new ModForumConfiguration());
        modelBuilder.ApplyConfiguration(new ModForumCategoryConfiguration());
        modelBuilder.ApplyConfiguration(new ModForumForumConfiguration());
        modelBuilder.ApplyConfiguration(new ModForumPostConfiguration());
        modelBuilder.ApplyConfiguration(new ModForumUserConfiguration());
        modelBuilder.ApplyConfiguration(new ModLinkConfiguration());
        modelBuilder.ApplyConfiguration(new ModLinksLinkConfiguration());
        modelBuilder.ApplyConfiguration(new ModMailinglistConfiguration());
        modelBuilder.ApplyConfiguration(new ModMailinglistArchiveConfiguration());
        modelBuilder.ApplyConfiguration(new ModMailinglistBlockTypeConfiguration());
        modelBuilder.ApplyConfiguration(new ModMailinglistEasyblockConfiguration());
        modelBuilder.ApplyConfiguration(new ModMailinglistEasyimgConfiguration());
        modelBuilder.ApplyConfiguration(new ModMailinglistEasymailConfiguration());
        modelBuilder.ApplyConfiguration(new ModMailinglistMailOptionConfiguration());
        modelBuilder.ApplyConfiguration(new ModMailinglistProfileConfiguration());
        modelBuilder.ApplyConfiguration(new ModMailinglistProfilesSubscriptionConfiguration());
        modelBuilder.ApplyConfiguration(new ModMailinglistProfilesSubscriptionConfiguration());
        modelBuilder.ApplyConfiguration(new ModMailinglistSavedConfiguration());
        modelBuilder.ApplyConfiguration(new ModMailinglistServerConfiguration());
        modelBuilder.ApplyConfiguration(new ModMailinglistSubscriptionConfiguration());
        modelBuilder.ApplyConfiguration(new ModMailinglistSubscription2Configuration());
        modelBuilder.ApplyConfiguration(new ModMailinglistTemplateConfiguration());
        modelBuilder.ApplyConfiguration(new ModPollConfiguration());
        modelBuilder.ApplyConfiguration(new ModPollClubVoterConfiguration());
        modelBuilder.ApplyConfiguration(new ModPollOptionConfiguration());
        modelBuilder.ApplyConfiguration(new ModPollTranslationConfiguration());
        modelBuilder.ApplyConfiguration(new ModPollVoterConfiguration());
        modelBuilder.ApplyConfiguration(new ModSimpleimageConfiguration());
        modelBuilder.ApplyConfiguration(new ModSimpleimageImageConfiguration());
        modelBuilder.ApplyConfiguration(new ModSocialModuleinstanceConfiguration());
        modelBuilder.ApplyConfiguration(new ModTweetConfiguration());
        modelBuilder.ApplyConfiguration(new ModuleConfiguration());
        modelBuilder.ApplyConfiguration(new ModuleinstanceConfiguration());
        modelBuilder.ApplyConfiguration(new ModulerightConfiguration());
        modelBuilder.ApplyConfiguration(new OwnerConfiguration());
        modelBuilder.ApplyConfiguration(new PageConfiguration());
        modelBuilder.ApplyConfiguration(new PageLanguageConfiguration());
        modelBuilder.ApplyConfiguration(new PageModuleinstanceConfiguration());
        modelBuilder.ApplyConfiguration(new PageviewConfiguration());
        modelBuilder.ApplyConfiguration(new SearchtableConfiguration());
        modelBuilder.ApplyConfiguration(new SecurityConfiguration());
        modelBuilder.ApplyConfiguration(new SecurityIpConfiguration());
        modelBuilder.ApplyConfiguration(new SitemapobjectConfiguration());
        modelBuilder.ApplyConfiguration(new SitemapobjectLanguageConfiguration());
        modelBuilder.ApplyConfiguration(new SitemapobjectPageConfiguration());
        modelBuilder.ApplyConfiguration(new SitemapobjectRightConfiguration());
        modelBuilder.ApplyConfiguration(new SocialConfiguration());
        modelBuilder.ApplyConfiguration(new SocialCacheConfiguration());
        modelBuilder.ApplyConfiguration(new SocialResponseConfiguration());
        modelBuilder.ApplyConfiguration(new SpecialConfiguration());
        modelBuilder.ApplyConfiguration(new StatisticConfiguration());
        modelBuilder.ApplyConfiguration(new UserConfiguration());
        modelBuilder.ApplyConfiguration(new UserOepConfiguration());
        modelBuilder.ApplyConfiguration(new UsergroupConfiguration());
        modelBuilder.ApplyConfiguration(new UsergroupUserConfiguration());
        modelBuilder.ApplyConfiguration(new WebsiteConfiguration());
        modelBuilder.ApplyConfiguration(new WebsiteLanguageConfiguration());
        modelBuilder.ApplyConfiguration(new WebsiteRightConfiguration());
        modelBuilder.ApplyConfiguration(new WebsiteStylesheetConfiguration());
        
        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
