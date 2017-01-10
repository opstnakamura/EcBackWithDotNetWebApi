[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(EcBackWithDotNetWebApi.App_Start.NinjectWebCommon), "Start")]
[assembly: WebActivatorEx.ApplicationShutdownMethodAttribute(typeof(EcBackWithDotNetWebApi.App_Start.NinjectWebCommon), "Stop")]

namespace EcBackWithDotNetWebApi.App_Start
{
    using System;
    using System.Web;

    using Microsoft.Web.Infrastructure.DynamicModuleHelper;

    using Ninject;
    using Ninject.Web.Common;

    using EcBackWithDotNetWebApi.DbContest;
    using EcBackWithDotNetWebApi.Entities;
    using EcBackWithDotNetWebApi.Repositories;

    public static class NinjectWebCommon 
    {
        private static readonly Bootstrapper bootstrapper = new Bootstrapper();

        /// <summary>
        /// Starts the application
        /// </summary>
        public static void Start() 
        {
            DynamicModuleUtility.RegisterModule(typeof(OnePerRequestHttpModule));
            DynamicModuleUtility.RegisterModule(typeof(NinjectHttpModule));
            bootstrapper.Initialize(CreateKernel);
        }
        
        /// <summary>
        /// Stops the application.
        /// </summary>
        public static void Stop()
        {
            bootstrapper.ShutDown();
        }
        
        /// <summary>
        /// Creates the kernel that will manage your application.
        /// </summary>
        /// <returns>The created kernel.</returns>
        private static IKernel CreateKernel()
        {
            var kernel = new StandardKernel();
            try
            {
                kernel.Bind<Func<IKernel>>().ToMethod(ctx => () => new Bootstrapper().Kernel);
                kernel.Bind<IHttpModule>().To<HttpApplicationInitializationHttpModule>();

                RegisterServices(kernel);
                return kernel;
            }
            catch
            {
                kernel.Dispose();
                throw;
            }
        }

        /// <summary>
        /// Load your modules or register your services here!
        /// </summary>
        /// <param name="kernel">The kernel.</param>
        private static void RegisterServices(IKernel kernel)
        {
            kernel.Bind<EbiDB>().To<EbiDB>().InRequestScope();

            // dbo
            kernel.Bind<IEbiRepository<dealer_url_db>>().To<EbiRepository<dealer_url_db>>().InRequestScope();
            kernel.Bind<IEbiRepository<error_email_db>>().To<EbiRepository<error_email_db>>().InRequestScope();
            kernel.Bind<IEbiRepository<mail_dealer_db>>().To<EbiRepository<mail_dealer_db>>().InRequestScope();
            kernel.Bind<IEbiRepository<mail_genre_db>>().To<EbiRepository<mail_genre_db>>().InRequestScope();
            kernel.Bind<IEbiRepository<mail_history_db>>().To<EbiRepository<mail_history_db>>().InRequestScope();
            kernel.Bind<IEbiRepository<mail_magazine_db>>().To<EbiRepository<mail_magazine_db>>().InRequestScope();
            kernel.Bind<IEbiRepository<mail_manager_user_db>>().To<EbiRepository<mail_manager_user_db>>().InRequestScope();
            kernel.Bind<IEbiRepository<mail_status_db>>().To<EbiRepository<mail_status_db>>().InRequestScope();
            kernel.Bind<IEbiRepository<mail_testto_db>>().To<EbiRepository<mail_testto_db>>().InRequestScope();
            kernel.Bind<IEbiRepository<replace_word_db>>().To<EbiRepository<replace_word_db>>().InRequestScope();

            // ebiadmin
            kernel.Bind<IEbiRepository<accountlock_history_tbl>>().To<EbiRepository<accountlock_history_tbl>>().InRequestScope();
            kernel.Bind<IEbiRepository<agent_db>>().To<EbiRepository<agent_db>>().InRequestScope();
            kernel.Bind<IEbiRepository<author_sale_db>>().To<EbiRepository<author_sale_db>>().InRequestScope();
            kernel.Bind<IEbiRepository<basket>>().To<EbiRepository<basket>>().InRequestScope();
            kernel.Bind<IEbiRepository<basket_db>>().To<EbiRepository<basket_db>>().InRequestScope();
            kernel.Bind<IEbiRepository<book_author_db>>().To<EbiRepository<book_author_db>>().InRequestScope();
            kernel.Bind<IEbiRepository<book_back_db>>().To<EbiRepository<book_back_db>>().InRequestScope();
            kernel.Bind<IEbiRepository<book_flag_db>>().To<EbiRepository<book_flag_db>>().InRequestScope();
            kernel.Bind<IEbiRepository<book_front_db>>().To<EbiRepository<book_front_db>>().InRequestScope();
            kernel.Bind<IEbiRepository<book_license_db>>().To<EbiRepository<book_license_db>>().InRequestScope();
            kernel.Bind<IEbiRepository<book_publish_db>>().To<EbiRepository<book_publish_db>>().InRequestScope();
            kernel.Bind<IEbiRepository<book_sale>>().To<EbiRepository<book_sale>>().InRequestScope();
            kernel.Bind<IEbiRepository<book_sale_db>>().To<EbiRepository<book_sale_db>>().InRequestScope();
            kernel.Bind<IEbiRepository<book_tachiyomi_db>>().To<EbiRepository<book_tachiyomi_db>>().InRequestScope();
            kernel.Bind<IEbiRepository<book_title_db>>().To<EbiRepository<book_title_db>>().InRequestScope();
            kernel.Bind<IEbiRepository<branch_db>>().To<EbiRepository<branch_db>>().InRequestScope();
            kernel.Bind<IEbiRepository<browser_reader_session_tbl>>().To<EbiRepository<browser_reader_session_tbl>>().InRequestScope();
            kernel.Bind<IEbiRepository<bulk_item_db>>().To<EbiRepository<bulk_item_db>>().InRequestScope();
            kernel.Bind<IEbiRepository<bulk_sale_db>>().To<EbiRepository<bulk_sale_db>>().InRequestScope();
            kernel.Bind<IEbiRepository<bulk_service_history_db>>().To<EbiRepository<bulk_service_history_db>>().InRequestScope();
            kernel.Bind<IEbiRepository<bulk_service_item_db>>().To<EbiRepository<bulk_service_item_db>>().InRequestScope();
            kernel.Bind<IEbiRepository<campaign_db>>().To<EbiRepository<campaign_db>>().InRequestScope();
            kernel.Bind<IEbiRepository<campaign_enquete_db>>().To<EbiRepository<campaign_enquete_db>>().InRequestScope();
            kernel.Bind<IEbiRepository<campaign_history_db>>().To<EbiRepository<campaign_history_db>>().InRequestScope();
            kernel.Bind<IEbiRepository<card_notice_db>>().To<EbiRepository<card_notice_db>>().InRequestScope();
            kernel.Bind<IEbiRepository<card_regist_db>>().To<EbiRepository<card_regist_db>>().InRequestScope();
            kernel.Bind<IEbiRepository<cid_tbl>>().To<EbiRepository<cid_tbl>>().InRequestScope();
            kernel.Bind<IEbiRepository<contribution_db>>().To<EbiRepository<contribution_db>>().InRequestScope();
            kernel.Bind<IEbiRepository<contribution_make_id_db>>().To<EbiRepository<contribution_make_id_db>>().InRequestScope();
            kernel.Bind<IEbiRepository<contribution_make_resid_db>>().To<EbiRepository<contribution_make_resid_db>>().InRequestScope();
            kernel.Bind<IEbiRepository<contribution_prohibition_db>>().To<EbiRepository<contribution_prohibition_db>>().InRequestScope();
            kernel.Bind<IEbiRepository<coupon_db>>().To<EbiRepository<coupon_db>>().InRequestScope();
            kernel.Bind<IEbiRepository<coupon_detail_db>>().To<EbiRepository<coupon_detail_db>>().InRequestScope();
            kernel.Bind<IEbiRepository<dealer_db>>().To<EbiRepository<dealer_db>>().InRequestScope();
            kernel.Bind<IEbiRepository<download_item_db>>().To<EbiRepository<download_item_db>>().InRequestScope();
            kernel.Bind<IEbiRepository<download_order_db>>().To<EbiRepository<download_order_db>>().InRequestScope();
            kernel.Bind<IEbiRepository<ebi_coupon_count_db>>().To<EbiRepository<ebi_coupon_count_db>>().InRequestScope();
            kernel.Bind<IEbiRepository<ebi_coupon_db>>().To<EbiRepository<ebi_coupon_db>>().InRequestScope();
            kernel.Bind<IEbiRepository<ebi_coupon_purpose_db>>().To<EbiRepository<ebi_coupon_purpose_db>>().InRequestScope();
            kernel.Bind<IEbiRepository<ebija_download>>().To<EbiRepository<ebija_download>>().InRequestScope();
            kernel.Bind<IEbiRepository<ebook_format_tbl>>().To<EbiRepository<ebook_format_tbl>>().InRequestScope();
            kernel.Bind<IEbiRepository<faq_access>>().To<EbiRepository<faq_access>>().InRequestScope();
            kernel.Bind<IEbiRepository<faq_access_summerize>>().To<EbiRepository<faq_access_summerize>>().InRequestScope();
            kernel.Bind<IEbiRepository<faq_list>>().To<EbiRepository<faq_list>>().InRequestScope();
            kernel.Bind<IEbiRepository<faq_result>>().To<EbiRepository<faq_result>>().InRequestScope();
            kernel.Bind<IEbiRepository<genre_db>>().To<EbiRepository<genre_db>>().InRequestScope();
            kernel.Bind<IEbiRepository<gift_db>>().To<EbiRepository<gift_db>>().InRequestScope();
            kernel.Bind<IEbiRepository<giftPic_cate_db>>().To<EbiRepository<giftPic_cate_db>>().InRequestScope();
            kernel.Bind<IEbiRepository<giftPic_db>>().To<EbiRepository<giftPic_db>>().InRequestScope();
            kernel.Bind<IEbiRepository<goods>>().To<EbiRepository<goods>>().InRequestScope();
            kernel.Bind<IEbiRepository<heart_beat>>().To<EbiRepository<heart_beat>>().InRequestScope();
            kernel.Bind<IEbiRepository<id_db>>().To<EbiRepository<id_db>>().InRequestScope();
            kernel.Bind<IEbiRepository<investigate_history_db>>().To<EbiRepository<investigate_history_db>>().InRequestScope();
            kernel.Bind<IEbiRepository<investigate_item_db>>().To<EbiRepository<investigate_item_db>>().InRequestScope();
            kernel.Bind<IEbiRepository<kanrititle_db>>().To<EbiRepository<kanrititle_db>>().InRequestScope();
            kernel.Bind<IEbiRepository<mailmagazine_db>>().To<EbiRepository<mailmagazine_db>>().InRequestScope();
            kernel.Bind<IEbiRepository<marathon_apply_db>>().To<EbiRepository<marathon_apply_db>>().InRequestScope();
            kernel.Bind<IEbiRepository<marathon_book_db>>().To<EbiRepository<marathon_book_db>>().InRequestScope();
            kernel.Bind<IEbiRepository<marathon_db>>().To<EbiRepository<marathon_db>>().InRequestScope();
            kernel.Bind<IEbiRepository<marathon_prize_db>>().To<EbiRepository<marathon_prize_db>>().InRequestScope();
            kernel.Bind<IEbiRepository<members>>().To<EbiRepository<members>>().InRequestScope();
            kernel.Bind<IEbiRepository<members_role>>().To<EbiRepository<members_role>>().InRequestScope();
            kernel.Bind<IEbiRepository<members_ticket>>().To<EbiRepository<members_ticket>>().InRequestScope();
            kernel.Bind<IEbiRepository<middle_genre_master>>().To<EbiRepository<middle_genre_master>>().InRequestScope();
            kernel.Bind<IEbiRepository<mmsendcount>>().To<EbiRepository<mmsendcount>>().InRequestScope();
            kernel.Bind<IEbiRepository<new_book_order_detail>>().To<EbiRepository<new_book_order_detail>>().InRequestScope();
            kernel.Bind<IEbiRepository<newbook_notify_author_tbl>>().To<EbiRepository<newbook_notify_author_tbl>>().InRequestScope();
            kernel.Bind<IEbiRepository<newbook_notify_history_book_tbl>>().To<EbiRepository<newbook_notify_history_book_tbl>>().InRequestScope();
            kernel.Bind<IEbiRepository<newbook_notify_history_tbl>>().To<EbiRepository<newbook_notify_history_tbl>>().InRequestScope();
            kernel.Bind<IEbiRepository<newbook_notify_history_user_author_tbl>>().To<EbiRepository<newbook_notify_history_user_author_tbl>>().InRequestScope();
            kernel.Bind<IEbiRepository<newbook_notify_history_user_tbl>>().To<EbiRepository<newbook_notify_history_user_tbl>>().InRequestScope();
            kernel.Bind<IEbiRepository<newbook_notify_history_user_title_tbl>>().To<EbiRepository<newbook_notify_history_user_title_tbl>>().InRequestScope();
            kernel.Bind<IEbiRepository<newbook_notify_title_tbl>>().To<EbiRepository<newbook_notify_title_tbl>>().InRequestScope();
            kernel.Bind<IEbiRepository<ocn_user_db>>().To<EbiRepository<ocn_user_db>>().InRequestScope();
            kernel.Bind<IEbiRepository<onetime_download>>().To<EbiRepository<onetime_download>>().InRequestScope();
            kernel.Bind<IEbiRepository<onetime_download_detail>>().To<EbiRepository<onetime_download_detail>>().InRequestScope();
            kernel.Bind<IEbiRepository<onetime_entry>>().To<EbiRepository<onetime_entry>>().InRequestScope();
            kernel.Bind<IEbiRepository<package_db>>().To<EbiRepository<package_db>>().InRequestScope();
            kernel.Bind<IEbiRepository<package_detail_db>>().To<EbiRepository<package_detail_db>>().InRequestScope();
            kernel.Bind<IEbiRepository<passwd_reset_db>>().To<EbiRepository<passwd_reset_db>>().InRequestScope();
            kernel.Bind<IEbiRepository<payment>>().To<EbiRepository<payment>>().InRequestScope();
            kernel.Bind<IEbiRepository<payment_onetouch>>().To<EbiRepository<payment_onetouch>>().InRequestScope();
            kernel.Bind<IEbiRepository<payment_store>>().To<EbiRepository<payment_store>>().InRequestScope();
            kernel.Bind<IEbiRepository<point_account_tbl>>().To<EbiRepository<point_account_tbl>>().InRequestScope();
            kernel.Bind<IEbiRepository<point_campaign_basic_point_db>>().To<EbiRepository<point_campaign_basic_point_db>>().InRequestScope();
            kernel.Bind<IEbiRepository<point_campaign_item_db>>().To<EbiRepository<point_campaign_item_db>>().InRequestScope();
            kernel.Bind<IEbiRepository<point_campaign_list_db>>().To<EbiRepository<point_campaign_list_db>>().InRequestScope();
            kernel.Bind<IEbiRepository<point_campaign_order_db>>().To<EbiRepository<point_campaign_order_db>>().InRequestScope();
            kernel.Bind<IEbiRepository<point_campaign_summarize_db>>().To<EbiRepository<point_campaign_summarize_db>>().InRequestScope();
            kernel.Bind<IEbiRepository<point_campaign_user_db>>().To<EbiRepository<point_campaign_user_db>>().InRequestScope();
            kernel.Bind<IEbiRepository<point_history_tbl>>().To<EbiRepository<point_history_tbl>>().InRequestScope();
            kernel.Bind<IEbiRepository<point_lock_tbl>>().To<EbiRepository<point_lock_tbl>>().InRequestScope();
            kernel.Bind<IEbiRepository<point_monthly_summary_tbl>>().To<EbiRepository<point_monthly_summary_tbl>>().InRequestScope();
            kernel.Bind<IEbiRepository<point_operation_tbl>>().To<EbiRepository<point_operation_tbl>>().InRequestScope();
            kernel.Bind<IEbiRepository<point_tmp_history_tbl>>().To<EbiRepository<point_tmp_history_tbl>>().InRequestScope();
            kernel.Bind<IEbiRepository<prefecture>>().To<EbiRepository<prefecture>>().InRequestScope();
            kernel.Bind<IEbiRepository<price_change_item_tbl>>().To<EbiRepository<price_change_item_tbl>>().InRequestScope();
            kernel.Bind<IEbiRepository<price_change_list_tbl>>().To<EbiRepository<price_change_list_tbl>>().InRequestScope();
            kernel.Bind<IEbiRepository<products_link_tbl>>().To<EbiRepository<products_link_tbl>>().InRequestScope();
            kernel.Bind<IEbiRepository<products_order_tbl>>().To<EbiRepository<products_order_tbl>>().InRequestScope();
            kernel.Bind<IEbiRepository<publish_db>>().To<EbiRepository<publish_db>>().InRequestScope();
            kernel.Bind<IEbiRepository<ranking>>().To<EbiRepository<ranking>>().InRequestScope();
            kernel.Bind<IEbiRepository<ranking_db>>().To<EbiRepository<ranking_db>>().InRequestScope();
            kernel.Bind<IEbiRepository<reader_format_tbl>>().To<EbiRepository<reader_format_tbl>>().InRequestScope();
            kernel.Bind<IEbiRepository<receipt_charge_db>>().To<EbiRepository<receipt_charge_db>>().InRequestScope();
            kernel.Bind<IEbiRepository<receipt_history_0_tbl>>().To<EbiRepository<receipt_history_0_tbl>>().InRequestScope();
            kernel.Bind<IEbiRepository<receipt_history_1_tbl>>().To<EbiRepository<receipt_history_1_tbl>>().InRequestScope();
            kernel.Bind<IEbiRepository<receipt_history_2_tbl>>().To<EbiRepository<receipt_history_2_tbl>>().InRequestScope();
            kernel.Bind<IEbiRepository<receipt_history_3_tbl>>().To<EbiRepository<receipt_history_3_tbl>>().InRequestScope();
            kernel.Bind<IEbiRepository<receipt_history_4_tbl>>().To<EbiRepository<receipt_history_4_tbl>>().InRequestScope();
            kernel.Bind<IEbiRepository<receipt_history_5_tbl>>().To<EbiRepository<receipt_history_5_tbl>>().InRequestScope();
            kernel.Bind<IEbiRepository<receipt_history_6_tbl>>().To<EbiRepository<receipt_history_6_tbl>>().InRequestScope();
            kernel.Bind<IEbiRepository<receipt_history_7_tbl>>().To<EbiRepository<receipt_history_7_tbl>>().InRequestScope();
            kernel.Bind<IEbiRepository<receipt_history_8_tbl>>().To<EbiRepository<receipt_history_8_tbl>>().InRequestScope();
            kernel.Bind<IEbiRepository<receipt_history_9_tbl>>().To<EbiRepository<receipt_history_9_tbl>>().InRequestScope();
            kernel.Bind<IEbiRepository<receipt_history_a_tbl>>().To<EbiRepository<receipt_history_a_tbl>>().InRequestScope();
            kernel.Bind<IEbiRepository<receipt_item_db>>().To<EbiRepository<receipt_item_db>>().InRequestScope();
            kernel.Bind<IEbiRepository<receipt_option_db>>().To<EbiRepository<receipt_option_db>>().InRequestScope();
            kernel.Bind<IEbiRepository<receipt_order_db>>().To<EbiRepository<receipt_order_db>>().InRequestScope();
            kernel.Bind<IEbiRepository<review_blacklist_history_tbl>>().To<EbiRepository<review_blacklist_history_tbl>>().InRequestScope();
            kernel.Bind<IEbiRepository<review_data_tbl>>().To<EbiRepository<review_data_tbl>>().InRequestScope();
            kernel.Bind<IEbiRepository<review_favorite_tbl>>().To<EbiRepository<review_favorite_tbl>>().InRequestScope();
            kernel.Bind<IEbiRepository<review_reviewer_tbl>>().To<EbiRepository<review_reviewer_tbl>>().InRequestScope();
            kernel.Bind<IEbiRepository<review_specialist_tbl>>().To<EbiRepository<review_specialist_tbl>>().InRequestScope();
            kernel.Bind<IEbiRepository<review_staff_division_tbl>>().To<EbiRepository<review_staff_division_tbl>>().InRequestScope();
            kernel.Bind<IEbiRepository<review_staff_genre_tbl>>().To<EbiRepository<review_staff_genre_tbl>>().InRequestScope();
            kernel.Bind<IEbiRepository<review_staff_tbl>>().To<EbiRepository<review_staff_tbl>>().InRequestScope();
            kernel.Bind<IEbiRepository<review_title_score_tbl>>().To<EbiRepository<review_title_score_tbl>>().InRequestScope();
            kernel.Bind<IEbiRepository<review_view_judge_history_tbl>>().To<EbiRepository<review_view_judge_history_tbl>>().InRequestScope();
            kernel.Bind<IEbiRepository<review_violation_history_tbl>>().To<EbiRepository<review_violation_history_tbl>>().InRequestScope();
            kernel.Bind<IEbiRepository<review_vote_tbl>>().To<EbiRepository<review_vote_tbl>>().InRequestScope();
            kernel.Bind<IEbiRepository<roles>>().To<EbiRepository<roles>>().InRequestScope();
            kernel.Bind<IEbiRepository<rss_config>>().To<EbiRepository<rss_config>>().InRequestScope();
            kernel.Bind<IEbiRepository<sale_judge_db>>().To<EbiRepository<sale_judge_db>>().InRequestScope();
            kernel.Bind<IEbiRepository<schedule_item>>().To<EbiRepository<schedule_item>>().InRequestScope();
            kernel.Bind<IEbiRepository<schedule_item_master>>().To<EbiRepository<schedule_item_master>>().InRequestScope();
            kernel.Bind<IEbiRepository<serial_db>>().To<EbiRepository<serial_db>>().InRequestScope();
            kernel.Bind<IEbiRepository<serial_detail_db>>().To<EbiRepository<serial_detail_db>>().InRequestScope();
            kernel.Bind<IEbiRepository<session_tbl>>().To<EbiRepository<session_tbl>>().InRequestScope();
            kernel.Bind<IEbiRepository<tachiyomi_download>>().To<EbiRepository<tachiyomi_download>>().InRequestScope();
            kernel.Bind<IEbiRepository<tachiyomi_download_item>>().To<EbiRepository<tachiyomi_download_item>>().InRequestScope();
            kernel.Bind<IEbiRepository<tachiyomi_login>>().To<EbiRepository<tachiyomi_login>>().InRequestScope();
            kernel.Bind<IEbiRepository<tachiyomi_user>>().To<EbiRepository<tachiyomi_user>>().InRequestScope();
            kernel.Bind<IEbiRepository<title_genre_db>>().To<EbiRepository<title_genre_db>>().InRequestScope();
            kernel.Bind<IEbiRepository<title_genre_opt_db>>().To<EbiRepository<title_genre_opt_db>>().InRequestScope();
            kernel.Bind<IEbiRepository<title_sale>>().To<EbiRepository<title_sale>>().InRequestScope();
            kernel.Bind<IEbiRepository<title_sale_db>>().To<EbiRepository<title_sale_db>>().InRequestScope();
            kernel.Bind<IEbiRepository<top_genre_db>>().To<EbiRepository<top_genre_db>>().InRequestScope();
            kernel.Bind<IEbiRepository<toyo_bunko_db>>().To<EbiRepository<toyo_bunko_db>>().InRequestScope();
            kernel.Bind<IEbiRepository<transfer_lock_history_tbl>>().To<EbiRepository<transfer_lock_history_tbl>>().InRequestScope();
            kernel.Bind<IEbiRepository<trunk_basket>>().To<EbiRepository<trunk_basket>>().InRequestScope();
            kernel.Bind<IEbiRepository<trunk_delivery_detail_book_tbl>>().To<EbiRepository<trunk_delivery_detail_book_tbl>>().InRequestScope();
            kernel.Bind<IEbiRepository<trunk_delivery_detail_tbl>>().To<EbiRepository<trunk_delivery_detail_tbl>>().InRequestScope();
            kernel.Bind<IEbiRepository<trunk_delivery_magazine_publish_tbl>>().To<EbiRepository<trunk_delivery_magazine_publish_tbl>>().InRequestScope();
            kernel.Bind<IEbiRepository<trunk_delivery_tbl>>().To<EbiRepository<trunk_delivery_tbl>>().InRequestScope();
            kernel.Bind<IEbiRepository<trunk_delivery_user_item_tbl>>().To<EbiRepository<trunk_delivery_user_item_tbl>>().InRequestScope();
            kernel.Bind<IEbiRepository<trunk_delivery_user_tbl>>().To<EbiRepository<trunk_delivery_user_tbl>>().InRequestScope();
            kernel.Bind<IEbiRepository<trunk_folder>>().To<EbiRepository<trunk_folder>>().InRequestScope();
            kernel.Bind<IEbiRepository<trunk_history>>().To<EbiRepository<trunk_history>>().InRequestScope();
            kernel.Bind<IEbiRepository<trunk_order>>().To<EbiRepository<trunk_order>>().InRequestScope();
            kernel.Bind<IEbiRepository<trunk_price>>().To<EbiRepository<trunk_price>>().InRequestScope();
            kernel.Bind<IEbiRepository<trunk_property>>().To<EbiRepository<trunk_property>>().InRequestScope();
            kernel.Bind<IEbiRepository<trunk_regist_book>>().To<EbiRepository<trunk_regist_book>>().InRequestScope();
            kernel.Bind<IEbiRepository<trunk_regist_pc>>().To<EbiRepository<trunk_regist_pc>>().InRequestScope();
            kernel.Bind<IEbiRepository<trunk_room>>().To<EbiRepository<trunk_room>>().InRequestScope();
            kernel.Bind<IEbiRepository<trunk_service_history_db>>().To<EbiRepository<trunk_service_history_db>>().InRequestScope();
            kernel.Bind<IEbiRepository<trunk_service_item_db>>().To<EbiRepository<trunk_service_item_db>>().InRequestScope();
            kernel.Bind<IEbiRepository<trunk_session>>().To<EbiRepository<trunk_session>>().InRequestScope();
            kernel.Bind<IEbiRepository<trunk_unregist_book>>().To<EbiRepository<trunk_unregist_book>>().InRequestScope();
            kernel.Bind<IEbiRepository<trunk_unregist_envid>>().To<EbiRepository<trunk_unregist_envid>>().InRequestScope();
            kernel.Bind<IEbiRepository<trunk_use>>().To<EbiRepository<trunk_use>>().InRequestScope();
            kernel.Bind<IEbiRepository<ua_device_db>>().To<EbiRepository<ua_device_db>>().InRequestScope();
            kernel.Bind<IEbiRepository<uni_genre_item>>().To<EbiRepository<uni_genre_item>>().InRequestScope();
            kernel.Bind<IEbiRepository<uni_genre_master>>().To<EbiRepository<uni_genre_master>>().InRequestScope();
            kernel.Bind<IEbiRepository<user_db>>().To<EbiRepository<user_db>>().InRequestScope();
            kernel.Bind<IEbiRepository<user_option_db>>().To<EbiRepository<user_option_db>>().InRequestScope();
            kernel.Bind<IEbiRepository<voting_candidate_db>>().To<EbiRepository<voting_candidate_db>>().InRequestScope();
            kernel.Bind<IEbiRepository<voting_data_db>>().To<EbiRepository<voting_data_db>>().InRequestScope();
            kernel.Bind<IEbiRepository<voting_info_db>>().To<EbiRepository<voting_info_db>>().InRequestScope();
            kernel.Bind<IEbiRepository<vouchers>>().To<EbiRepository<vouchers>>().InRequestScope();
            kernel.Bind<IEbiRepository<vouchers_class>>().To<EbiRepository<vouchers_class>>().InRequestScope();
            kernel.Bind<IEbiRepository<vouchers_receipt>>().To<EbiRepository<vouchers_receipt>>().InRequestScope();
            kernel.Bind<IEbiRepository<vouchers_user>>().To<EbiRepository<vouchers_user>>().InRequestScope();
            kernel.Bind<IEbiRepository<wish_list_tbl>>().To<EbiRepository<wish_list_tbl>>().InRequestScope();
            kernel.Bind<IEbiRepository<genre_db_20100316BK>>().To<EbiRepository<genre_db_20100316BK>>().InRequestScope();
            kernel.Bind<IEbiRepository<mail_settings_db>>().To<EbiRepository<mail_settings_db>>().InRequestScope();
            kernel.Bind<IEbiRepository<access_counter_db>>().To<EbiRepository<access_counter_db>>().InRequestScope();
            kernel.Bind<IEbiRepository<book_jump_db>>().To<EbiRepository<book_jump_db>>().InRequestScope();
            kernel.Bind<IEbiRepository<bulk_service_campaign_history_db>>().To<EbiRepository<bulk_service_campaign_history_db>>().InRequestScope();
            kernel.Bind<IEbiRepository<bulk_service_campaign_item_db>>().To<EbiRepository<bulk_service_campaign_item_db>>().InRequestScope();
            kernel.Bind<IEbiRepository<campaign_access_db>>().To<EbiRepository<campaign_access_db>>().InRequestScope();
            kernel.Bind<IEbiRepository<point_expiration_management_tbl>>().To<EbiRepository<point_expiration_management_tbl>>().InRequestScope();
            kernel.Bind<IEbiRepository<ranking_genre_db>>().To<EbiRepository<ranking_genre_db>>().InRequestScope();
            kernel.Bind<IEbiRepository<recommend_counter_db>>().To<EbiRepository<recommend_counter_db>>().InRequestScope();


        }        
    }
}
