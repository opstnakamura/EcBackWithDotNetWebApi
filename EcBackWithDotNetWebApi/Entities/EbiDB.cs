namespace EcBackWithDotNetWebApi.Entities
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class EbiDB : DbContext
    {
        public EbiDB()
            : base("name=EbiDB")
        {
        }

        public virtual DbSet<dealer_url_db> dealer_url_db { get; set; }
        public virtual DbSet<error_email_db> error_email_db { get; set; }
        public virtual DbSet<mail_dealer_db> mail_dealer_db { get; set; }
        public virtual DbSet<mail_genre_db> mail_genre_db { get; set; }
        public virtual DbSet<mail_history_db> mail_history_db { get; set; }
        public virtual DbSet<mail_magazine_db> mail_magazine_db { get; set; }
        public virtual DbSet<mail_manager_user_db> mail_manager_user_db { get; set; }
        public virtual DbSet<mail_status_db> mail_status_db { get; set; }
        public virtual DbSet<mail_testto_db> mail_testto_db { get; set; }
        public virtual DbSet<replace_word_db> replace_word_db { get; set; }
        public virtual DbSet<accountlock_history_tbl> accountlock_history_tbl { get; set; }
        public virtual DbSet<agent_db> agent_db { get; set; }
        public virtual DbSet<author_sale_db> author_sale_db { get; set; }
        public virtual DbSet<basket> basket { get; set; }
        public virtual DbSet<basket_db> basket_db { get; set; }
        public virtual DbSet<book_author_db> book_author_db { get; set; }
        public virtual DbSet<book_back_db> book_back_db { get; set; }
        public virtual DbSet<book_flag_db> book_flag_db { get; set; }
        public virtual DbSet<book_front_db> book_front_db { get; set; }
        public virtual DbSet<book_license_db> book_license_db { get; set; }
        public virtual DbSet<book_publish_db> book_publish_db { get; set; }
        public virtual DbSet<book_sale> book_sale { get; set; }
        public virtual DbSet<book_sale_db> book_sale_db { get; set; }
        public virtual DbSet<book_tachiyomi_db> book_tachiyomi_db { get; set; }
        public virtual DbSet<book_title_db> book_title_db { get; set; }
        public virtual DbSet<branch_db> branch_db { get; set; }
        public virtual DbSet<browser_reader_session_tbl> browser_reader_session_tbl { get; set; }
        public virtual DbSet<bulk_item_db> bulk_item_db { get; set; }
        public virtual DbSet<bulk_sale_db> bulk_sale_db { get; set; }
        public virtual DbSet<bulk_service_history_db> bulk_service_history_db { get; set; }
        public virtual DbSet<bulk_service_item_db> bulk_service_item_db { get; set; }
        public virtual DbSet<campaign_db> campaign_db { get; set; }
        public virtual DbSet<campaign_enquete_db> campaign_enquete_db { get; set; }
        public virtual DbSet<campaign_history_db> campaign_history_db { get; set; }
        public virtual DbSet<card_notice_db> card_notice_db { get; set; }
        public virtual DbSet<card_regist_db> card_regist_db { get; set; }
        public virtual DbSet<cid_tbl> cid_tbl { get; set; }
        public virtual DbSet<contribution_db> contribution_db { get; set; }
        public virtual DbSet<contribution_make_id_db> contribution_make_id_db { get; set; }
        public virtual DbSet<contribution_make_resid_db> contribution_make_resid_db { get; set; }
        public virtual DbSet<contribution_prohibition_db> contribution_prohibition_db { get; set; }
        public virtual DbSet<coupon_db> coupon_db { get; set; }
        public virtual DbSet<coupon_detail_db> coupon_detail_db { get; set; }
        public virtual DbSet<dealer_db> dealer_db { get; set; }
        public virtual DbSet<download_item_db> download_item_db { get; set; }
        public virtual DbSet<download_order_db> download_order_db { get; set; }
        public virtual DbSet<ebi_coupon_count_db> ebi_coupon_count_db { get; set; }
        public virtual DbSet<ebi_coupon_db> ebi_coupon_db { get; set; }
        public virtual DbSet<ebi_coupon_purpose_db> ebi_coupon_purpose_db { get; set; }
        public virtual DbSet<ebija_download> ebija_download { get; set; }
        public virtual DbSet<ebook_format_tbl> ebook_format_tbl { get; set; }
        public virtual DbSet<faq_access> faq_access { get; set; }
        public virtual DbSet<faq_access_summerize> faq_access_summerize { get; set; }
        public virtual DbSet<faq_list> faq_list { get; set; }
        public virtual DbSet<faq_result> faq_result { get; set; }
        public virtual DbSet<genre_db> genre_db { get; set; }
        public virtual DbSet<gift_db> gift_db { get; set; }
        public virtual DbSet<giftPic_cate_db> giftPic_cate_db { get; set; }
        public virtual DbSet<giftPic_db> giftPic_db { get; set; }
        public virtual DbSet<goods> goods { get; set; }
        public virtual DbSet<heart_beat> heart_beat { get; set; }
        public virtual DbSet<id_db> id_db { get; set; }
        public virtual DbSet<investigate_history_db> investigate_history_db { get; set; }
        public virtual DbSet<investigate_item_db> investigate_item_db { get; set; }
        public virtual DbSet<kanrititle_db> kanrititle_db { get; set; }
        public virtual DbSet<mailmagazine_db> mailmagazine_db { get; set; }
        public virtual DbSet<marathon_apply_db> marathon_apply_db { get; set; }
        public virtual DbSet<marathon_book_db> marathon_book_db { get; set; }
        public virtual DbSet<marathon_db> marathon_db { get; set; }
        public virtual DbSet<marathon_prize_db> marathon_prize_db { get; set; }
        public virtual DbSet<members> members { get; set; }
        public virtual DbSet<members_role> members_role { get; set; }
        public virtual DbSet<members_ticket> members_ticket { get; set; }
        public virtual DbSet<middle_genre_master> middle_genre_master { get; set; }
        public virtual DbSet<mmsendcount> mmsendcount { get; set; }
        public virtual DbSet<new_book_order_detail> new_book_order_detail { get; set; }
        public virtual DbSet<newbook_notify_author_tbl> newbook_notify_author_tbl { get; set; }
        public virtual DbSet<newbook_notify_history_book_tbl> newbook_notify_history_book_tbl { get; set; }
        public virtual DbSet<newbook_notify_history_tbl> newbook_notify_history_tbl { get; set; }
        public virtual DbSet<newbook_notify_history_user_author_tbl> newbook_notify_history_user_author_tbl { get; set; }
        public virtual DbSet<newbook_notify_history_user_tbl> newbook_notify_history_user_tbl { get; set; }
        public virtual DbSet<newbook_notify_history_user_title_tbl> newbook_notify_history_user_title_tbl { get; set; }
        public virtual DbSet<newbook_notify_title_tbl> newbook_notify_title_tbl { get; set; }
        public virtual DbSet<ocn_user_db> ocn_user_db { get; set; }
        public virtual DbSet<onetime_download> onetime_download { get; set; }
        public virtual DbSet<onetime_download_detail> onetime_download_detail { get; set; }
        public virtual DbSet<onetime_entry> onetime_entry { get; set; }
        public virtual DbSet<package_db> package_db { get; set; }
        public virtual DbSet<package_detail_db> package_detail_db { get; set; }
        public virtual DbSet<passwd_reset_db> passwd_reset_db { get; set; }
        public virtual DbSet<payment> payment { get; set; }
        public virtual DbSet<payment_onetouch> payment_onetouch { get; set; }
        public virtual DbSet<payment_store> payment_store { get; set; }
        public virtual DbSet<point_account_tbl> point_account_tbl { get; set; }
        public virtual DbSet<point_campaign_basic_point_db> point_campaign_basic_point_db { get; set; }
        public virtual DbSet<point_campaign_item_db> point_campaign_item_db { get; set; }
        public virtual DbSet<point_campaign_list_db> point_campaign_list_db { get; set; }
        public virtual DbSet<point_campaign_order_db> point_campaign_order_db { get; set; }
        public virtual DbSet<point_campaign_summarize_db> point_campaign_summarize_db { get; set; }
        public virtual DbSet<point_campaign_user_db> point_campaign_user_db { get; set; }
        public virtual DbSet<point_history_tbl> point_history_tbl { get; set; }
        public virtual DbSet<point_lock_tbl> point_lock_tbl { get; set; }
        public virtual DbSet<point_monthly_summary_tbl> point_monthly_summary_tbl { get; set; }
        public virtual DbSet<point_operation_tbl> point_operation_tbl { get; set; }
        public virtual DbSet<point_tmp_history_tbl> point_tmp_history_tbl { get; set; }
        public virtual DbSet<prefecture> prefecture { get; set; }
        public virtual DbSet<price_change_item_tbl> price_change_item_tbl { get; set; }
        public virtual DbSet<price_change_list_tbl> price_change_list_tbl { get; set; }
        public virtual DbSet<products_link_tbl> products_link_tbl { get; set; }
        public virtual DbSet<products_order_tbl> products_order_tbl { get; set; }
        public virtual DbSet<publish_db> publish_db { get; set; }
        public virtual DbSet<ranking> ranking { get; set; }
        public virtual DbSet<ranking_db> ranking_db { get; set; }
        public virtual DbSet<reader_format_tbl> reader_format_tbl { get; set; }
        public virtual DbSet<receipt_charge_db> receipt_charge_db { get; set; }
        public virtual DbSet<receipt_history_0_tbl> receipt_history_0_tbl { get; set; }
        public virtual DbSet<receipt_history_1_tbl> receipt_history_1_tbl { get; set; }
        public virtual DbSet<receipt_history_2_tbl> receipt_history_2_tbl { get; set; }
        public virtual DbSet<receipt_history_3_tbl> receipt_history_3_tbl { get; set; }
        public virtual DbSet<receipt_history_4_tbl> receipt_history_4_tbl { get; set; }
        public virtual DbSet<receipt_history_5_tbl> receipt_history_5_tbl { get; set; }
        public virtual DbSet<receipt_history_6_tbl> receipt_history_6_tbl { get; set; }
        public virtual DbSet<receipt_history_7_tbl> receipt_history_7_tbl { get; set; }
        public virtual DbSet<receipt_history_8_tbl> receipt_history_8_tbl { get; set; }
        public virtual DbSet<receipt_history_9_tbl> receipt_history_9_tbl { get; set; }
        public virtual DbSet<receipt_history_a_tbl> receipt_history_a_tbl { get; set; }
        public virtual DbSet<receipt_item_db> receipt_item_db { get; set; }
        public virtual DbSet<receipt_option_db> receipt_option_db { get; set; }
        public virtual DbSet<receipt_order_db> receipt_order_db { get; set; }
        public virtual DbSet<review_blacklist_history_tbl> review_blacklist_history_tbl { get; set; }
        public virtual DbSet<review_data_tbl> review_data_tbl { get; set; }
        public virtual DbSet<review_favorite_tbl> review_favorite_tbl { get; set; }
        public virtual DbSet<review_reviewer_tbl> review_reviewer_tbl { get; set; }
        public virtual DbSet<review_specialist_tbl> review_specialist_tbl { get; set; }
        public virtual DbSet<review_staff_division_tbl> review_staff_division_tbl { get; set; }
        public virtual DbSet<review_staff_genre_tbl> review_staff_genre_tbl { get; set; }
        public virtual DbSet<review_staff_tbl> review_staff_tbl { get; set; }
        public virtual DbSet<review_title_score_tbl> review_title_score_tbl { get; set; }
        public virtual DbSet<review_view_judge_history_tbl> review_view_judge_history_tbl { get; set; }
        public virtual DbSet<review_violation_history_tbl> review_violation_history_tbl { get; set; }
        public virtual DbSet<review_vote_tbl> review_vote_tbl { get; set; }
        public virtual DbSet<roles> roles { get; set; }
        public virtual DbSet<rss_config> rss_config { get; set; }
        public virtual DbSet<sale_judge_db> sale_judge_db { get; set; }
        public virtual DbSet<schedule_item> schedule_item { get; set; }
        public virtual DbSet<schedule_item_master> schedule_item_master { get; set; }
        public virtual DbSet<serial_db> serial_db { get; set; }
        public virtual DbSet<serial_detail_db> serial_detail_db { get; set; }
        public virtual DbSet<session_tbl> session_tbl { get; set; }
        public virtual DbSet<tachiyomi_download> tachiyomi_download { get; set; }
        public virtual DbSet<tachiyomi_download_item> tachiyomi_download_item { get; set; }
        public virtual DbSet<tachiyomi_login> tachiyomi_login { get; set; }
        public virtual DbSet<tachiyomi_user> tachiyomi_user { get; set; }
        public virtual DbSet<title_genre_db> title_genre_db { get; set; }
        public virtual DbSet<title_genre_opt_db> title_genre_opt_db { get; set; }
        public virtual DbSet<title_sale> title_sale { get; set; }
        public virtual DbSet<title_sale_db> title_sale_db { get; set; }
        public virtual DbSet<top_genre_db> top_genre_db { get; set; }
        public virtual DbSet<toyo_bunko_db> toyo_bunko_db { get; set; }
        public virtual DbSet<transfer_lock_history_tbl> transfer_lock_history_tbl { get; set; }
        public virtual DbSet<trunk_basket> trunk_basket { get; set; }
        public virtual DbSet<trunk_delivery_detail_book_tbl> trunk_delivery_detail_book_tbl { get; set; }
        public virtual DbSet<trunk_delivery_detail_tbl> trunk_delivery_detail_tbl { get; set; }
        public virtual DbSet<trunk_delivery_magazine_publish_tbl> trunk_delivery_magazine_publish_tbl { get; set; }
        public virtual DbSet<trunk_delivery_tbl> trunk_delivery_tbl { get; set; }
        public virtual DbSet<trunk_delivery_user_item_tbl> trunk_delivery_user_item_tbl { get; set; }
        public virtual DbSet<trunk_delivery_user_tbl> trunk_delivery_user_tbl { get; set; }
        public virtual DbSet<trunk_folder> trunk_folder { get; set; }
        public virtual DbSet<trunk_history> trunk_history { get; set; }
        public virtual DbSet<trunk_order> trunk_order { get; set; }
        public virtual DbSet<trunk_price> trunk_price { get; set; }
        public virtual DbSet<trunk_property> trunk_property { get; set; }
        public virtual DbSet<trunk_regist_book> trunk_regist_book { get; set; }
        public virtual DbSet<trunk_regist_pc> trunk_regist_pc { get; set; }
        public virtual DbSet<trunk_room> trunk_room { get; set; }
        public virtual DbSet<trunk_service_history_db> trunk_service_history_db { get; set; }
        public virtual DbSet<trunk_service_item_db> trunk_service_item_db { get; set; }
        public virtual DbSet<trunk_session> trunk_session { get; set; }
        public virtual DbSet<trunk_unregist_book> trunk_unregist_book { get; set; }
        public virtual DbSet<trunk_unregist_envid> trunk_unregist_envid { get; set; }
        public virtual DbSet<trunk_use> trunk_use { get; set; }
        public virtual DbSet<ua_device_db> ua_device_db { get; set; }
        public virtual DbSet<uni_genre_item> uni_genre_item { get; set; }
        public virtual DbSet<uni_genre_master> uni_genre_master { get; set; }
        public virtual DbSet<user_db> user_db { get; set; }
        public virtual DbSet<user_option_db> user_option_db { get; set; }
        public virtual DbSet<voting_candidate_db> voting_candidate_db { get; set; }
        public virtual DbSet<voting_data_db> voting_data_db { get; set; }
        public virtual DbSet<voting_info_db> voting_info_db { get; set; }
        public virtual DbSet<vouchers> vouchers { get; set; }
        public virtual DbSet<vouchers_class> vouchers_class { get; set; }
        public virtual DbSet<vouchers_receipt> vouchers_receipt { get; set; }
        public virtual DbSet<vouchers_user> vouchers_user { get; set; }
        public virtual DbSet<wish_list_tbl> wish_list_tbl { get; set; }
        public virtual DbSet<genre_db_20100316BK> genre_db_20100316BK { get; set; }
        public virtual DbSet<mail_settings_db> mail_settings_db { get; set; }
        public virtual DbSet<access_counter_db> access_counter_db { get; set; }
        public virtual DbSet<book_jump_db> book_jump_db { get; set; }
        public virtual DbSet<bulk_service_campaign_history_db> bulk_service_campaign_history_db { get; set; }
        public virtual DbSet<bulk_service_campaign_item_db> bulk_service_campaign_item_db { get; set; }
        public virtual DbSet<campaign_access_db> campaign_access_db { get; set; }
        public virtual DbSet<point_expiration_management_tbl> point_expiration_management_tbl { get; set; }
        public virtual DbSet<ranking_genre_db> ranking_genre_db { get; set; }
        public virtual DbSet<recommend_counter_db> recommend_counter_db { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<dealer_url_db>()
                .Property(e => e.replace_key)
                .IsUnicode(false);

            modelBuilder.Entity<dealer_url_db>()
                .Property(e => e.url)
                .IsUnicode(false);

            modelBuilder.Entity<dealer_url_db>()
                .Property(e => e.key1)
                .IsUnicode(false);

            modelBuilder.Entity<dealer_url_db>()
                .Property(e => e.url1)
                .IsUnicode(false);

            modelBuilder.Entity<dealer_url_db>()
                .Property(e => e.key2)
                .IsUnicode(false);

            modelBuilder.Entity<dealer_url_db>()
                .Property(e => e.url2)
                .IsUnicode(false);

            modelBuilder.Entity<dealer_url_db>()
                .Property(e => e.key3)
                .IsUnicode(false);

            modelBuilder.Entity<dealer_url_db>()
                .Property(e => e.url3)
                .IsUnicode(false);

            modelBuilder.Entity<dealer_url_db>()
                .Property(e => e.key4)
                .IsUnicode(false);

            modelBuilder.Entity<dealer_url_db>()
                .Property(e => e.url4)
                .IsUnicode(false);

            modelBuilder.Entity<dealer_url_db>()
                .Property(e => e.key5)
                .IsUnicode(false);

            modelBuilder.Entity<dealer_url_db>()
                .Property(e => e.url5)
                .IsUnicode(false);

            modelBuilder.Entity<dealer_url_db>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<error_email_db>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<mail_dealer_db>()
                .Property(e => e.mailmagazineid)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<mail_genre_db>()
                .Property(e => e.mailgenre_name)
                .IsUnicode(false);

            modelBuilder.Entity<mail_history_db>()
                .Property(e => e.mailmagazineid)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<mail_history_db>()
                .Property(e => e.unsent_email)
                .IsUnicode(false);

            modelBuilder.Entity<mail_magazine_db>()
                .Property(e => e.mailmagazineid)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<mail_magazine_db>()
                .Property(e => e.mailtitle)
                .IsUnicode(false);

            modelBuilder.Entity<mail_magazine_db>()
                .Property(e => e.html_content)
                .IsUnicode(false);

            modelBuilder.Entity<mail_magazine_db>()
                .Property(e => e.text_content)
                .IsUnicode(false);

            modelBuilder.Entity<mail_magazine_db>()
                .Property(e => e.html_content_rep)
                .IsUnicode(false);

            modelBuilder.Entity<mail_magazine_db>()
                .Property(e => e.text_content_rep)
                .IsUnicode(false);

            modelBuilder.Entity<mail_magazine_db>()
                .Property(e => e.notes)
                .IsUnicode(false);

            modelBuilder.Entity<mail_magazine_db>()
                .Property(e => e.test_email)
                .IsUnicode(false);

            modelBuilder.Entity<mail_manager_user_db>()
                .Property(e => e.userid)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<mail_manager_user_db>()
                .Property(e => e.loginid)
                .IsUnicode(false);

            modelBuilder.Entity<mail_manager_user_db>()
                .Property(e => e.loginpwd)
                .IsUnicode(false);

            modelBuilder.Entity<mail_manager_user_db>()
                .Property(e => e.username)
                .IsUnicode(false);

            modelBuilder.Entity<mail_manager_user_db>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<mail_manager_user_db>()
                .Property(e => e.dept)
                .IsUnicode(false);

            modelBuilder.Entity<mail_status_db>()
                .Property(e => e.mail_status_name)
                .IsUnicode(false);

            modelBuilder.Entity<mail_testto_db>()
                .Property(e => e.testto_name)
                .IsUnicode(false);

            modelBuilder.Entity<mail_testto_db>()
                .Property(e => e.testto_email)
                .IsUnicode(false);

            modelBuilder.Entity<replace_word_db>()
                .Property(e => e.replace_word)
                .IsUnicode(false);

            modelBuilder.Entity<replace_word_db>()
                .Property(e => e.replace_value)
                .IsUnicode(false);

            modelBuilder.Entity<accountlock_history_tbl>()
                .Property(e => e.userid)
                .IsUnicode(false);

            modelBuilder.Entity<accountlock_history_tbl>()
                .Property(e => e.ipaddress)
                .IsUnicode(false);

            modelBuilder.Entity<agent_db>()
                .Property(e => e.agentid)
                .IsUnicode(false);

            modelBuilder.Entity<agent_db>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<agent_db>()
                .Property(e => e.kana)
                .IsUnicode(false);

            modelBuilder.Entity<basket_db>()
                .Property(e => e.userid)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<basket_db>()
                .Property(e => e.item)
                .IsUnicode(false);

            modelBuilder.Entity<book_author_db>()
                .Property(e => e.authorid)
                .IsUnicode(false);

            modelBuilder.Entity<book_author_db>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<book_author_db>()
                .Property(e => e.kana)
                .IsUnicode(false);

            modelBuilder.Entity<book_author_db>()
                .Property(e => e.incfile)
                .IsUnicode(false);

            modelBuilder.Entity<book_author_db>()
                .Property(e => e.author_cd)
                .IsUnicode(false);

            modelBuilder.Entity<book_back_db>()
                .Property(e => e.title_kana)
                .IsUnicode(false);

            modelBuilder.Entity<book_back_db>()
                .Property(e => e.author_kana)
                .IsUnicode(false);

            modelBuilder.Entity<book_back_db>()
                .Property(e => e.publisher_kana)
                .IsUnicode(false);

            modelBuilder.Entity<book_back_db>()
                .Property(e => e.isbn)
                .IsUnicode(false);

            modelBuilder.Entity<book_back_db>()
                .Property(e => e.c_code)
                .IsUnicode(false);

            modelBuilder.Entity<book_back_db>()
                .Property(e => e.book_type_original)
                .IsUnicode(false);

            modelBuilder.Entity<book_flag_db>()
                .Property(e => e.titleid)
                .IsUnicode(false);

            modelBuilder.Entity<book_flag_db>()
                .Property(e => e.authorid_1)
                .IsUnicode(false);

            modelBuilder.Entity<book_flag_db>()
                .Property(e => e.authorid_2)
                .IsUnicode(false);

            modelBuilder.Entity<book_front_db>()
                .Property(e => e.bookid)
                .IsUnicode(false);

            modelBuilder.Entity<book_front_db>()
                .Property(e => e.contentkey)
                .IsUnicode(false);

            modelBuilder.Entity<book_front_db>()
                .Property(e => e.title)
                .IsUnicode(false);

            modelBuilder.Entity<book_front_db>()
                .Property(e => e.author)
                .IsUnicode(false);

            modelBuilder.Entity<book_front_db>()
                .Property(e => e.publisher)
                .IsUnicode(false);

            modelBuilder.Entity<book_front_db>()
                .Property(e => e.img_url)
                .IsUnicode(false);

            modelBuilder.Entity<book_front_db>()
                .Property(e => e.data_url)
                .IsUnicode(false);

            modelBuilder.Entity<book_front_db>()
                .Property(e => e.folder_url)
                .IsUnicode(false);

            modelBuilder.Entity<book_front_db>()
                .Property(e => e.datasize)
                .HasPrecision(19, 4);

            modelBuilder.Entity<book_front_db>()
                .Property(e => e.content)
                .IsUnicode(false);

            modelBuilder.Entity<book_front_db>()
                .Property(e => e.summary)
                .IsUnicode(false);

            modelBuilder.Entity<book_front_db>()
                .Property(e => e.keyword)
                .IsUnicode(false);

            modelBuilder.Entity<book_front_db>()
                .Property(e => e.volumename)
                .IsUnicode(false);

            modelBuilder.Entity<book_front_db>()
                .Property(e => e.initial_price)
                .HasPrecision(16, 4);

            modelBuilder.Entity<book_front_db>()
                .Property(e => e.paper_book_price)
                .HasPrecision(16, 4);

            modelBuilder.Entity<book_front_db>()
                .Property(e => e.isbn)
                .IsUnicode(false);

            modelBuilder.Entity<book_front_db>()
                .Property(e => e.authorid_1)
                .IsUnicode(false);

            modelBuilder.Entity<book_front_db>()
                .Property(e => e.authorid_2)
                .IsUnicode(false);

            modelBuilder.Entity<book_front_db>()
                .Property(e => e.titleid)
                .IsUnicode(false);

            modelBuilder.Entity<book_front_db>()
                .Property(e => e.publishid)
                .IsUnicode(false);

            modelBuilder.Entity<book_license_db>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<book_license_db>()
                .Property(e => e.kana)
                .IsUnicode(false);

            modelBuilder.Entity<book_license_db>()
                .Property(e => e.loginid)
                .IsUnicode(false);

            modelBuilder.Entity<book_license_db>()
                .Property(e => e.loginpasswd)
                .IsUnicode(false);

            modelBuilder.Entity<book_sale>()
                .Property(e => e.dealer_id)
                .IsUnicode(false);

            modelBuilder.Entity<book_tachiyomi_db>()
                .Property(e => e.dealer_id)
                .IsUnicode(false);

            modelBuilder.Entity<book_title_db>()
                .Property(e => e.titleid)
                .IsUnicode(false);

            modelBuilder.Entity<book_title_db>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<book_title_db>()
                .Property(e => e.kana)
                .IsUnicode(false);

            modelBuilder.Entity<book_title_db>()
                .Property(e => e.incfile)
                .IsUnicode(false);

            modelBuilder.Entity<book_title_db>()
                .Property(e => e.title_cd)
                .IsUnicode(false);

            modelBuilder.Entity<book_title_db>()
                .Property(e => e.datasize)
                .HasPrecision(19, 4);

            modelBuilder.Entity<book_title_db>()
                .Property(e => e.content)
                .IsUnicode(false);

            modelBuilder.Entity<book_title_db>()
                .Property(e => e.summary)
                .IsUnicode(false);

            modelBuilder.Entity<book_title_db>()
                .Property(e => e.publishid)
                .IsUnicode(false);

            modelBuilder.Entity<branch_db>()
                .Property(e => e.branchid)
                .IsUnicode(false);

            modelBuilder.Entity<branch_db>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<branch_db>()
                .Property(e => e.kana)
                .IsUnicode(false);

            modelBuilder.Entity<browser_reader_session_tbl>()
                .Property(e => e.sessionid)
                .IsUnicode(false);

            modelBuilder.Entity<browser_reader_session_tbl>()
                .Property(e => e.ebix)
                .IsUnicode(false);

            modelBuilder.Entity<browser_reader_session_tbl>()
                .Property(e => e.keydata)
                .IsUnicode(false);

            modelBuilder.Entity<browser_reader_session_tbl>()
                .Property(e => e.ipaddr)
                .IsUnicode(false);

            modelBuilder.Entity<browser_reader_session_tbl>()
                .Property(e => e.remarks)
                .IsUnicode(false);

            modelBuilder.Entity<browser_reader_session_tbl>()
                .Property(e => e.envid)
                .IsUnicode(false);

            modelBuilder.Entity<bulk_item_db>()
                .Property(e => e.titleid)
                .IsUnicode(false);

            modelBuilder.Entity<bulk_sale_db>()
                .Property(e => e.dealerid)
                .IsUnicode(false);

            modelBuilder.Entity<bulk_service_item_db>()
                .Property(e => e.orderid)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<bulk_service_item_db>()
                .Property(e => e.userid)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<bulk_service_item_db>()
                .Property(e => e.coupon_purpose)
                .IsUnicode(false);

            modelBuilder.Entity<bulk_service_item_db>()
                .Property(e => e.coupon_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<campaign_db>()
                .Property(e => e.campaign_code)
                .IsUnicode(false);

            modelBuilder.Entity<campaign_db>()
                .Property(e => e.campaign_name)
                .IsUnicode(false);

            modelBuilder.Entity<campaign_db>()
                .Property(e => e.user_regist_dealerid)
                .IsUnicode(false);

            modelBuilder.Entity<campaign_db>()
                .Property(e => e.order_dealerid)
                .IsUnicode(false);

            modelBuilder.Entity<campaign_db>()
                .Property(e => e.enquete_title)
                .IsUnicode(false);

            modelBuilder.Entity<campaign_db>()
                .Property(e => e.enquete_question)
                .IsUnicode(false);

            modelBuilder.Entity<campaign_db>()
                .Property(e => e.campaign_rule)
                .IsUnicode(false);

            modelBuilder.Entity<campaign_db>()
                .Property(e => e.book_select_file)
                .IsUnicode(false);

            modelBuilder.Entity<campaign_db>()
                .Property(e => e.url_issue_mail_file)
                .IsUnicode(false);

            modelBuilder.Entity<campaign_db>()
                .Property(e => e.thankyou_mail_file)
                .IsUnicode(false);

            modelBuilder.Entity<campaign_enquete_db>()
                .Property(e => e.area)
                .IsUnicode(false);

            modelBuilder.Entity<campaign_enquete_db>()
                .Property(e => e.title1)
                .IsUnicode(false);

            modelBuilder.Entity<campaign_enquete_db>()
                .Property(e => e.title2)
                .IsUnicode(false);

            modelBuilder.Entity<campaign_enquete_db>()
                .Property(e => e.title3)
                .IsUnicode(false);

            modelBuilder.Entity<campaign_enquete_db>()
                .Property(e => e.author1)
                .IsUnicode(false);

            modelBuilder.Entity<campaign_enquete_db>()
                .Property(e => e.author2)
                .IsUnicode(false);

            modelBuilder.Entity<campaign_enquete_db>()
                .Property(e => e.author3)
                .IsUnicode(false);

            modelBuilder.Entity<campaign_enquete_db>()
                .Property(e => e.campaign_question)
                .IsUnicode(false);

            modelBuilder.Entity<campaign_history_db>()
                .Property(e => e.userid)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<campaign_history_db>()
                .Property(e => e.sample_orderid)
                .IsUnicode(false);

            modelBuilder.Entity<campaign_history_db>()
                .Property(e => e.orderid)
                .IsUnicode(false);

            modelBuilder.Entity<campaign_history_db>()
                .Property(e => e.access_code)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<campaign_history_db>()
                .Property(e => e.mail_err_info)
                .IsUnicode(false);

            modelBuilder.Entity<campaign_history_db>()
                .Property(e => e.user_agent)
                .IsUnicode(false);

            modelBuilder.Entity<card_notice_db>()
                .Property(e => e.userid)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<card_notice_db>()
                .Property(e => e.noticestate)
                .IsUnicode(false);

            modelBuilder.Entity<card_regist_db>()
                .Property(e => e.userid)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<card_regist_db>()
                .Property(e => e.custid)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<card_regist_db>()
                .Property(e => e.branch_code)
                .IsUnicode(false);

            modelBuilder.Entity<card_regist_db>()
                .Property(e => e.account_number)
                .IsUnicode(false);

            modelBuilder.Entity<card_regist_db>()
                .Property(e => e.kana_name)
                .IsUnicode(false);

            modelBuilder.Entity<cid_tbl>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<contribution_db>()
                .Property(e => e.ip_address)
                .IsUnicode(false);

            modelBuilder.Entity<contribution_db>()
                .Property(e => e.msg1)
                .IsUnicode(false);

            modelBuilder.Entity<contribution_db>()
                .Property(e => e.msg2)
                .IsUnicode(false);

            modelBuilder.Entity<contribution_db>()
                .Property(e => e.msg3)
                .IsUnicode(false);

            modelBuilder.Entity<contribution_db>()
                .Property(e => e.msg4)
                .IsUnicode(false);

            modelBuilder.Entity<contribution_db>()
                .Property(e => e.msg5)
                .IsUnicode(false);

            modelBuilder.Entity<contribution_prohibition_db>()
                .Property(e => e.ip_address)
                .IsUnicode(false);

            modelBuilder.Entity<coupon_db>()
                .Property(e => e.couponid)
                .IsUnicode(false);

            modelBuilder.Entity<coupon_detail_db>()
                .Property(e => e.couponid)
                .IsUnicode(false);

            modelBuilder.Entity<coupon_detail_db>()
                .Property(e => e.userid)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<coupon_detail_db>()
                .Property(e => e.fast_orderid)
                .IsUnicode(false);

            modelBuilder.Entity<coupon_detail_db>()
                .Property(e => e.last_orderid)
                .IsUnicode(false);

            modelBuilder.Entity<dealer_db>()
                .Property(e => e.dealerid)
                .IsUnicode(false);

            modelBuilder.Entity<dealer_db>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<dealer_db>()
                .Property(e => e.kana)
                .IsUnicode(false);

            modelBuilder.Entity<dealer_db>()
                .Property(e => e.cid)
                .IsUnicode(false);

            modelBuilder.Entity<dealer_db>()
                .Property(e => e.agentid)
                .IsUnicode(false);

            modelBuilder.Entity<dealer_db>()
                .Property(e => e.branchid)
                .IsUnicode(false);

            modelBuilder.Entity<dealer_db>()
                .Property(e => e.passwd)
                .IsUnicode(false);

            modelBuilder.Entity<dealer_db>()
                .Property(e => e.passwd2)
                .IsUnicode(false);

            modelBuilder.Entity<dealer_db>()
                .Property(e => e.dirname)
                .IsUnicode(false);

            modelBuilder.Entity<download_item_db>()
                .Property(e => e.id)
                .IsUnicode(false);

            modelBuilder.Entity<download_order_db>()
                .Property(e => e.id)
                .IsUnicode(false);

            modelBuilder.Entity<download_order_db>()
                .Property(e => e.orderid)
                .IsUnicode(false);

            modelBuilder.Entity<download_order_db>()
                .Property(e => e.userid)
                .IsUnicode(false);

            modelBuilder.Entity<download_order_db>()
                .Property(e => e.envid)
                .IsUnicode(false);

            modelBuilder.Entity<ebi_coupon_count_db>()
                .Property(e => e.purpose)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ebi_coupon_count_db>()
                .Property(e => e.used_num)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ebi_coupon_count_db>()
                .Property(e => e.cancel_num)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ebi_coupon_count_db>()
                .Property(e => e.invalid_num)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ebi_coupon_db>()
                .Property(e => e.id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ebi_coupon_db>()
                .Property(e => e.create_user)
                .IsUnicode(false);

            modelBuilder.Entity<ebi_coupon_db>()
                .Property(e => e.purpose)
                .IsUnicode(false);

            modelBuilder.Entity<ebi_coupon_db>()
                .Property(e => e.customer)
                .IsUnicode(false);

            modelBuilder.Entity<ebi_coupon_db>()
                .Property(e => e.orderid)
                .IsUnicode(false);

            modelBuilder.Entity<ebi_coupon_db>()
                .Property(e => e.userid)
                .IsUnicode(false);

            modelBuilder.Entity<ebi_coupon_db>()
                .Property(e => e.goods)
                .IsUnicode(false);

            modelBuilder.Entity<ebi_coupon_db>()
                .Property(e => e.available_shop)
                .IsUnicode(false);

            modelBuilder.Entity<ebi_coupon_db>()
                .Property(e => e.purpose_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ebi_coupon_db>()
                .Property(e => e.discount_rate)
                .HasPrecision(4, 3);

            modelBuilder.Entity<ebi_coupon_purpose_db>()
                .Property(e => e.purpose_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ebi_coupon_purpose_db>()
                .Property(e => e.purpose)
                .IsUnicode(false);

            modelBuilder.Entity<ebi_coupon_purpose_db>()
                .Property(e => e.create_user)
                .IsUnicode(false);

            modelBuilder.Entity<ebi_coupon_purpose_db>()
                .Property(e => e.discount_rate)
                .HasPrecision(4, 3);

            modelBuilder.Entity<ebi_coupon_purpose_db>()
                .Property(e => e.customer)
                .IsUnicode(false);

            modelBuilder.Entity<ebija_download>()
                .Property(e => e.sessionid)
                .IsUnicode(false);

            modelBuilder.Entity<ebija_download>()
                .Property(e => e.ebi)
                .IsUnicode(false);

            modelBuilder.Entity<ebija_download>()
                .Property(e => e.envid)
                .IsUnicode(false);

            modelBuilder.Entity<ebija_download>()
                .Property(e => e.contentkey)
                .IsUnicode(false);

            modelBuilder.Entity<ebook_format_tbl>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<faq_access>()
                .Property(e => e.userid)
                .IsUnicode(false);

            modelBuilder.Entity<faq_list>()
                .Property(e => e.genre)
                .IsUnicode(false);

            modelBuilder.Entity<faq_list>()
                .Property(e => e.device)
                .IsUnicode(false);

            modelBuilder.Entity<faq_list>()
                .Property(e => e.keyword)
                .IsUnicode(false);

            modelBuilder.Entity<faq_list>()
                .Property(e => e.title)
                .IsUnicode(false);

            modelBuilder.Entity<faq_list>()
                .Property(e => e.detail)
                .IsUnicode(false);

            modelBuilder.Entity<faq_result>()
                .Property(e => e.userid)
                .IsUnicode(false);

            modelBuilder.Entity<genre_db>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<genre_db>()
                .Property(e => e.kana)
                .IsUnicode(false);

            modelBuilder.Entity<gift_db>()
                .Property(e => e.giftId)
                .IsUnicode(false);

            modelBuilder.Entity<gift_db>()
                .Property(e => e.fk_gift_SendUserId)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<gift_db>()
                .Property(e => e.senderName)
                .IsUnicode(false);

            modelBuilder.Entity<gift_db>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<gift_db>()
                .Property(e => e.gift_text)
                .IsUnicode(false);

            modelBuilder.Entity<gift_db>()
                .Property(e => e.receiveUserId)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<gift_db>()
                .Property(e => e.receiverName)
                .IsUnicode(false);

            modelBuilder.Entity<gift_db>()
                .Property(e => e.fk_orderId)
                .IsUnicode(false);

            modelBuilder.Entity<giftPic_cate_db>()
                .Property(e => e.giftPic_cateName)
                .IsUnicode(false);

            modelBuilder.Entity<giftPic_db>()
                .Property(e => e.giftPic_fileName)
                .IsUnicode(false);

            modelBuilder.Entity<giftPic_db>()
                .Property(e => e.giftPic_name)
                .IsUnicode(false);

            modelBuilder.Entity<goods>()
                .Property(e => e.goods_cd)
                .IsUnicode(false);

            modelBuilder.Entity<goods>()
                .Property(e => e.dealer_id)
                .IsUnicode(false);

            modelBuilder.Entity<goods>()
                .Property(e => e.price)
                .HasPrecision(16, 4);

            modelBuilder.Entity<heart_beat>()
                .Property(e => e.TARGET)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<investigate_item_db>()
                .Property(e => e.userid)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<kanrititle_db>()
                .Property(e => e.titleid)
                .IsUnicode(false);

            modelBuilder.Entity<kanrititle_db>()
                .Property(e => e.publishid)
                .IsUnicode(false);

            modelBuilder.Entity<mailmagazine_db>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<marathon_apply_db>()
                .Property(e => e.userid)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<marathon_apply_db>()
                .Property(e => e.trunkid)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<marathon_apply_db>()
                .Property(e => e.campaign_cd)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<marathon_apply_db>()
                .Property(e => e.prize_cd)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<marathon_book_db>()
                .Property(e => e.campaign_cd)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<marathon_db>()
                .Property(e => e.campaign_cd)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<marathon_db>()
                .Property(e => e.campaign_name)
                .IsUnicode(false);

            modelBuilder.Entity<marathon_prize_db>()
                .Property(e => e.campaign_cd)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<marathon_prize_db>()
                .Property(e => e.prize_cd)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<marathon_prize_db>()
                .Property(e => e.prize_name)
                .IsUnicode(false);

            modelBuilder.Entity<members>()
                .Property(e => e.member_id)
                .IsUnicode(false);

            modelBuilder.Entity<members>()
                .Property(e => e.login_id)
                .IsUnicode(false);

            modelBuilder.Entity<members>()
                .Property(e => e.password)
                .IsUnicode(false);

            modelBuilder.Entity<members>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<members>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<members_role>()
                .Property(e => e.member_id)
                .IsUnicode(false);

            modelBuilder.Entity<members_role>()
                .Property(e => e.role_id)
                .IsUnicode(false);

            modelBuilder.Entity<members_ticket>()
                .Property(e => e.ticket_id)
                .IsUnicode(false);

            modelBuilder.Entity<members_ticket>()
                .Property(e => e.member_id)
                .IsUnicode(false);

            modelBuilder.Entity<middle_genre_master>()
                .Property(e => e.middle_genre_cd)
                .IsUnicode(false);

            modelBuilder.Entity<mmsendcount>()
                .Property(e => e.dealerid)
                .IsUnicode(false);

            modelBuilder.Entity<mmsendcount>()
                .Property(e => e.dealername)
                .IsUnicode(false);

            modelBuilder.Entity<new_book_order_detail>()
                .Property(e => e.last_modified_user_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<newbook_notify_author_tbl>()
                .Property(e => e.userid)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<newbook_notify_author_tbl>()
                .Property(e => e.authorid)
                .IsUnicode(false);

            modelBuilder.Entity<newbook_notify_history_book_tbl>()
                .Property(e => e.titleid)
                .IsUnicode(false);

            modelBuilder.Entity<newbook_notify_history_book_tbl>()
                .Property(e => e.authorid_1)
                .IsUnicode(false);

            modelBuilder.Entity<newbook_notify_history_book_tbl>()
                .Property(e => e.authorid_2)
                .IsUnicode(false);

            modelBuilder.Entity<newbook_notify_history_user_author_tbl>()
                .Property(e => e.userid)
                .IsUnicode(false);

            modelBuilder.Entity<newbook_notify_history_user_author_tbl>()
                .Property(e => e.authorid)
                .IsUnicode(false);

            modelBuilder.Entity<newbook_notify_history_user_tbl>()
                .Property(e => e.userid)
                .IsUnicode(false);

            modelBuilder.Entity<newbook_notify_history_user_tbl>()
                .Property(e => e.nickname)
                .IsUnicode(false);

            modelBuilder.Entity<newbook_notify_history_user_tbl>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<newbook_notify_history_user_title_tbl>()
                .Property(e => e.userid)
                .IsUnicode(false);

            modelBuilder.Entity<newbook_notify_history_user_title_tbl>()
                .Property(e => e.titleid)
                .IsUnicode(false);

            modelBuilder.Entity<newbook_notify_title_tbl>()
                .Property(e => e.userid)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<newbook_notify_title_tbl>()
                .Property(e => e.titleid)
                .IsUnicode(false);

            modelBuilder.Entity<ocn_user_db>()
                .Property(e => e.aspuserid)
                .IsUnicode(false);

            modelBuilder.Entity<ocn_user_db>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<ocn_user_db>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<ocn_user_db>()
                .Property(e => e.note)
                .IsUnicode(false);

            modelBuilder.Entity<onetime_download>()
                .Property(e => e.download_id)
                .IsUnicode(false);

            modelBuilder.Entity<onetime_download>()
                .Property(e => e.entry_id)
                .IsUnicode(false);

            modelBuilder.Entity<onetime_download>()
                .Property(e => e.user_id)
                .IsUnicode(false);

            modelBuilder.Entity<onetime_download_detail>()
                .Property(e => e.download_id)
                .IsUnicode(false);

            modelBuilder.Entity<onetime_entry>()
                .Property(e => e.entry_id)
                .IsUnicode(false);

            modelBuilder.Entity<onetime_entry>()
                .Property(e => e.member_id)
                .IsUnicode(false);

            modelBuilder.Entity<onetime_entry>()
                .Property(e => e.purpose_detail)
                .IsUnicode(false);

            modelBuilder.Entity<onetime_entry>()
                .Property(e => e.ad_name)
                .IsFixedLength();

            modelBuilder.Entity<package_db>()
                .Property(e => e.packageid)
                .IsUnicode(false);

            modelBuilder.Entity<package_db>()
                .Property(e => e.packagename)
                .IsUnicode(false);

            modelBuilder.Entity<package_db>()
                .Property(e => e.salesname)
                .IsUnicode(false);

            modelBuilder.Entity<package_detail_db>()
                .Property(e => e.packageid)
                .IsUnicode(false);

            modelBuilder.Entity<passwd_reset_db>()
                .Property(e => e.userid)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<passwd_reset_db>()
                .Property(e => e.resetkey)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<payment>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<payment>()
                .Property(e => e.abbreviation)
                .IsUnicode(false);

            modelBuilder.Entity<payment>()
                .Property(e => e.maintenance)
                .IsUnicode(false);

            modelBuilder.Entity<payment>()
                .Property(e => e.paytype)
                .IsUnicode(false);

            modelBuilder.Entity<payment>()
                .Property(e => e.dispname1)
                .IsUnicode(false);

            modelBuilder.Entity<payment>()
                .Property(e => e.dispname2)
                .IsUnicode(false);

            modelBuilder.Entity<payment_onetouch>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<payment_store>()
                .Property(e => e.dealerid)
                .IsUnicode(false);

            modelBuilder.Entity<payment_store>()
                .Property(e => e.dispitem1)
                .IsUnicode(false);

            modelBuilder.Entity<payment_store>()
                .Property(e => e.dispname1)
                .IsUnicode(false);

            modelBuilder.Entity<payment_store>()
                .Property(e => e.dispname2)
                .IsUnicode(false);

            modelBuilder.Entity<point_account_tbl>()
                .Property(e => e.userid)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<point_account_tbl>()
                .Property(e => e.lockid)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<point_campaign_basic_point_db>()
                .Property(e => e.last_modified_user_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<point_campaign_item_db>()
                .Property(e => e.last_modified_user_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<point_campaign_list_db>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<point_campaign_list_db>()
                .Property(e => e.owner)
                .IsUnicode(false);

            modelBuilder.Entity<point_campaign_list_db>()
                .Property(e => e.buffer)
                .IsUnicode(false);

            modelBuilder.Entity<point_campaign_list_db>()
                .Property(e => e.approver)
                .IsUnicode(false);

            modelBuilder.Entity<point_campaign_list_db>()
                .Property(e => e.last_modified_user_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<point_campaign_list_db>()
                .Property(e => e.display_name)
                .IsUnicode(false);

            modelBuilder.Entity<point_campaign_order_db>()
                .Property(e => e.orderid)
                .IsUnicode(false);

            modelBuilder.Entity<point_campaign_order_db>()
                .Property(e => e.userid)
                .IsUnicode(false);

            modelBuilder.Entity<point_campaign_user_db>()
                .Property(e => e.userid)
                .IsUnicode(false);

            modelBuilder.Entity<point_history_tbl>()
                .Property(e => e.userid)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<point_history_tbl>()
                .Property(e => e.orderid)
                .IsUnicode(false);

            modelBuilder.Entity<point_lock_tbl>()
                .Property(e => e.lockid)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<point_lock_tbl>()
                .Property(e => e.userid)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<point_lock_tbl>()
                .Property(e => e.orderid)
                .IsUnicode(false);

            modelBuilder.Entity<point_monthly_summary_tbl>()
                .Property(e => e.year_month)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<point_tmp_history_tbl>()
                .Property(e => e.userid)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<point_tmp_history_tbl>()
                .Property(e => e.orderid)
                .IsUnicode(false);

            modelBuilder.Entity<prefecture>()
                .Property(e => e.prefecturecd)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<prefecture>()
                .Property(e => e.prefecture1)
                .IsUnicode(false);

            modelBuilder.Entity<prefecture>()
                .Property(e => e.prefecturekana)
                .IsUnicode(false);

            modelBuilder.Entity<price_change_list_tbl>()
                .Property(e => e.purpose)
                .IsUnicode(false);

            modelBuilder.Entity<products_order_tbl>()
                .Property(e => e.products_orderid)
                .IsUnicode(false);

            modelBuilder.Entity<products_order_tbl>()
                .Property(e => e.userid)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<products_order_tbl>()
                .Property(e => e.user_name1)
                .IsUnicode(false);

            modelBuilder.Entity<products_order_tbl>()
                .Property(e => e.user_name2)
                .IsUnicode(false);

            modelBuilder.Entity<products_order_tbl>()
                .Property(e => e.user_name_kana1)
                .IsUnicode(false);

            modelBuilder.Entity<products_order_tbl>()
                .Property(e => e.user_name_kana2)
                .IsUnicode(false);

            modelBuilder.Entity<products_order_tbl>()
                .Property(e => e.zipcode)
                .IsUnicode(false);

            modelBuilder.Entity<products_order_tbl>()
                .Property(e => e.prefecturecd)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<products_order_tbl>()
                .Property(e => e.city)
                .IsUnicode(false);

            modelBuilder.Entity<products_order_tbl>()
                .Property(e => e.street)
                .IsUnicode(false);

            modelBuilder.Entity<products_order_tbl>()
                .Property(e => e.building)
                .IsUnicode(false);

            modelBuilder.Entity<products_order_tbl>()
                .Property(e => e.tel)
                .IsUnicode(false);

            modelBuilder.Entity<products_order_tbl>()
                .Property(e => e.tel_daytime)
                .IsUnicode(false);

            modelBuilder.Entity<products_order_tbl>()
                .Property(e => e.receipt_orderid)
                .IsUnicode(false);

            modelBuilder.Entity<products_order_tbl>()
                .Property(e => e.receipt_link_orderid)
                .IsUnicode(false);

            modelBuilder.Entity<publish_db>()
                .Property(e => e.publishid)
                .IsUnicode(false);

            modelBuilder.Entity<publish_db>()
                .Property(e => e.publisher)
                .IsUnicode(false);

            modelBuilder.Entity<publish_db>()
                .Property(e => e.kana)
                .IsUnicode(false);

            modelBuilder.Entity<ranking>()
                .Property(e => e.titleid)
                .IsUnicode(false);

            modelBuilder.Entity<ranking>()
                .Property(e => e.dealerid)
                .IsUnicode(false);

            modelBuilder.Entity<receipt_charge_db>()
                .Property(e => e.userid)
                .IsUnicode(false);

            modelBuilder.Entity<receipt_charge_db>()
                .Property(e => e.orderid)
                .IsUnicode(false);

            modelBuilder.Entity<receipt_charge_db>()
                .Property(e => e.dealerid)
                .IsUnicode(false);

            modelBuilder.Entity<receipt_charge_db>()
                .Property(e => e.buffer)
                .IsUnicode(false);

            modelBuilder.Entity<receipt_charge_db>()
                .Property(e => e.item)
                .IsUnicode(false);

            modelBuilder.Entity<receipt_charge_db>()
                .Property(e => e.item_status)
                .IsUnicode(false);

            modelBuilder.Entity<receipt_charge_db>()
                .Property(e => e.remote_addr)
                .IsUnicode(false);

            modelBuilder.Entity<receipt_charge_db>()
                .Property(e => e.http_host)
                .IsUnicode(false);

            modelBuilder.Entity<receipt_charge_db>()
                .Property(e => e.optionid)
                .IsUnicode(false);

            modelBuilder.Entity<receipt_history_0_tbl>()
                .Property(e => e.userid)
                .IsUnicode(false);

            modelBuilder.Entity<receipt_history_0_tbl>()
                .Property(e => e.orderid)
                .IsUnicode(false);

            modelBuilder.Entity<receipt_history_0_tbl>()
                .Property(e => e.dealerid)
                .IsUnicode(false);

            modelBuilder.Entity<receipt_history_1_tbl>()
                .Property(e => e.userid)
                .IsUnicode(false);

            modelBuilder.Entity<receipt_history_1_tbl>()
                .Property(e => e.orderid)
                .IsUnicode(false);

            modelBuilder.Entity<receipt_history_1_tbl>()
                .Property(e => e.dealerid)
                .IsUnicode(false);

            modelBuilder.Entity<receipt_history_2_tbl>()
                .Property(e => e.userid)
                .IsUnicode(false);

            modelBuilder.Entity<receipt_history_2_tbl>()
                .Property(e => e.orderid)
                .IsUnicode(false);

            modelBuilder.Entity<receipt_history_2_tbl>()
                .Property(e => e.dealerid)
                .IsUnicode(false);

            modelBuilder.Entity<receipt_history_3_tbl>()
                .Property(e => e.userid)
                .IsUnicode(false);

            modelBuilder.Entity<receipt_history_3_tbl>()
                .Property(e => e.orderid)
                .IsUnicode(false);

            modelBuilder.Entity<receipt_history_3_tbl>()
                .Property(e => e.dealerid)
                .IsUnicode(false);

            modelBuilder.Entity<receipt_history_4_tbl>()
                .Property(e => e.userid)
                .IsUnicode(false);

            modelBuilder.Entity<receipt_history_4_tbl>()
                .Property(e => e.orderid)
                .IsUnicode(false);

            modelBuilder.Entity<receipt_history_4_tbl>()
                .Property(e => e.dealerid)
                .IsUnicode(false);

            modelBuilder.Entity<receipt_history_5_tbl>()
                .Property(e => e.userid)
                .IsUnicode(false);

            modelBuilder.Entity<receipt_history_5_tbl>()
                .Property(e => e.orderid)
                .IsUnicode(false);

            modelBuilder.Entity<receipt_history_5_tbl>()
                .Property(e => e.dealerid)
                .IsUnicode(false);

            modelBuilder.Entity<receipt_history_6_tbl>()
                .Property(e => e.userid)
                .IsUnicode(false);

            modelBuilder.Entity<receipt_history_6_tbl>()
                .Property(e => e.orderid)
                .IsUnicode(false);

            modelBuilder.Entity<receipt_history_6_tbl>()
                .Property(e => e.dealerid)
                .IsUnicode(false);

            modelBuilder.Entity<receipt_history_7_tbl>()
                .Property(e => e.userid)
                .IsUnicode(false);

            modelBuilder.Entity<receipt_history_7_tbl>()
                .Property(e => e.orderid)
                .IsUnicode(false);

            modelBuilder.Entity<receipt_history_7_tbl>()
                .Property(e => e.dealerid)
                .IsUnicode(false);

            modelBuilder.Entity<receipt_history_8_tbl>()
                .Property(e => e.userid)
                .IsUnicode(false);

            modelBuilder.Entity<receipt_history_8_tbl>()
                .Property(e => e.orderid)
                .IsUnicode(false);

            modelBuilder.Entity<receipt_history_8_tbl>()
                .Property(e => e.dealerid)
                .IsUnicode(false);

            modelBuilder.Entity<receipt_history_9_tbl>()
                .Property(e => e.userid)
                .IsUnicode(false);

            modelBuilder.Entity<receipt_history_9_tbl>()
                .Property(e => e.orderid)
                .IsUnicode(false);

            modelBuilder.Entity<receipt_history_9_tbl>()
                .Property(e => e.dealerid)
                .IsUnicode(false);

            modelBuilder.Entity<receipt_history_a_tbl>()
                .Property(e => e.userid)
                .IsUnicode(false);

            modelBuilder.Entity<receipt_history_a_tbl>()
                .Property(e => e.orderid)
                .IsUnicode(false);

            modelBuilder.Entity<receipt_item_db>()
                .Property(e => e.orderid)
                .IsUnicode(false);

            modelBuilder.Entity<receipt_option_db>()
                .Property(e => e.orderid)
                .IsUnicode(false);

            modelBuilder.Entity<receipt_option_db>()
                .Property(e => e.memo)
                .IsUnicode(false);

            modelBuilder.Entity<receipt_order_db>()
                .Property(e => e.orderid)
                .IsUnicode(false);

            modelBuilder.Entity<receipt_order_db>()
                .Property(e => e.userid)
                .IsUnicode(false);

            modelBuilder.Entity<receipt_order_db>()
                .Property(e => e.dealerid)
                .IsUnicode(false);

            modelBuilder.Entity<receipt_order_db>()
                .Property(e => e.envid)
                .IsUnicode(false);

            modelBuilder.Entity<receipt_order_db>()
                .Property(e => e.agentid)
                .IsUnicode(false);

            modelBuilder.Entity<receipt_order_db>()
                .Property(e => e.branchid)
                .IsUnicode(false);

            modelBuilder.Entity<review_blacklist_history_tbl>()
                .Property(e => e.judge_kekka_reason)
                .IsUnicode(false);

            modelBuilder.Entity<review_data_tbl>()
                .Property(e => e.titleid)
                .IsUnicode(false);

            modelBuilder.Entity<review_data_tbl>()
                .Property(e => e.bookid)
                .IsUnicode(false);

            modelBuilder.Entity<review_data_tbl>()
                .Property(e => e.review_title)
                .IsUnicode(false);

            modelBuilder.Entity<review_data_tbl>()
                .Property(e => e.review_text)
                .IsUnicode(false);

            modelBuilder.Entity<review_reviewer_tbl>()
                .Property(e => e.userid)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<review_specialist_tbl>()
                .Property(e => e.reviewer_name_sei)
                .IsUnicode(false);

            modelBuilder.Entity<review_specialist_tbl>()
                .Property(e => e.reviewer_name_mei)
                .IsUnicode(false);

            modelBuilder.Entity<review_specialist_tbl>()
                .Property(e => e.nickname)
                .IsUnicode(false);

            modelBuilder.Entity<review_specialist_tbl>()
                .Property(e => e.katagaki)
                .IsUnicode(false);

            modelBuilder.Entity<review_specialist_tbl>()
                .Property(e => e.photo_url)
                .IsUnicode(false);

            modelBuilder.Entity<review_specialist_tbl>()
                .Property(e => e.profile)
                .IsUnicode(false);

            modelBuilder.Entity<review_specialist_tbl>()
                .Property(e => e.profile_note)
                .IsUnicode(false);

            modelBuilder.Entity<review_staff_division_tbl>()
                .Property(e => e.division_name)
                .IsUnicode(false);

            modelBuilder.Entity<review_staff_division_tbl>()
                .Property(e => e.tantou_name)
                .IsUnicode(false);

            modelBuilder.Entity<review_staff_genre_tbl>()
                .Property(e => e.tantou_genre_name)
                .IsUnicode(false);

            modelBuilder.Entity<review_staff_genre_tbl>()
                .Property(e => e.tantou_genre_url)
                .IsUnicode(false);

            modelBuilder.Entity<review_staff_tbl>()
                .Property(e => e.reviewer_name_sei)
                .IsUnicode(false);

            modelBuilder.Entity<review_staff_tbl>()
                .Property(e => e.reviewer_name_mei)
                .IsUnicode(false);

            modelBuilder.Entity<review_staff_tbl>()
                .Property(e => e.nickname)
                .IsUnicode(false);

            modelBuilder.Entity<review_staff_tbl>()
                .Property(e => e.editor_id)
                .IsUnicode(false);

            modelBuilder.Entity<review_staff_tbl>()
                .Property(e => e.photo_url)
                .IsUnicode(false);

            modelBuilder.Entity<review_staff_tbl>()
                .Property(e => e.profile)
                .IsUnicode(false);

            modelBuilder.Entity<review_title_score_tbl>()
                .Property(e => e.titleid)
                .IsUnicode(false);

            modelBuilder.Entity<review_title_score_tbl>()
                .Property(e => e.average_review_score)
                .HasPrecision(2, 1);

            modelBuilder.Entity<review_view_judge_history_tbl>()
                .Property(e => e.judge_reason)
                .IsUnicode(false);

            modelBuilder.Entity<review_view_judge_history_tbl>()
                .Property(e => e.judge_kekka_reason)
                .IsUnicode(false);

            modelBuilder.Entity<review_violation_history_tbl>()
                .Property(e => e.judge_staff_name)
                .IsUnicode(false);

            modelBuilder.Entity<review_violation_history_tbl>()
                .Property(e => e.judge_kekka_reason)
                .IsUnicode(false);

            modelBuilder.Entity<roles>()
                .Property(e => e.role_id)
                .IsUnicode(false);

            modelBuilder.Entity<roles>()
                .Property(e => e.role_name)
                .IsUnicode(false);

            modelBuilder.Entity<rss_config>()
                .Property(e => e.title)
                .IsUnicode(false);

            modelBuilder.Entity<rss_config>()
                .Property(e => e.filepath)
                .IsUnicode(false);

            modelBuilder.Entity<rss_config>()
                .Property(e => e.toplink)
                .IsUnicode(false);

            modelBuilder.Entity<rss_config>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<rss_config>()
                .Property(e => e.genrecode)
                .IsUnicode(false);

            modelBuilder.Entity<schedule_item>()
                .Property(e => e.schedule_description)
                .IsUnicode(false);

            modelBuilder.Entity<schedule_item>()
                .Property(e => e.url)
                .IsUnicode(false);

            modelBuilder.Entity<schedule_item>()
                .Property(e => e.last_modified_user_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<schedule_item_master>()
                .Property(e => e.last_modified_user_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<serial_db>()
                .Property(e => e.serialid)
                .IsUnicode(false);

            modelBuilder.Entity<serial_db>()
                .Property(e => e.packageid)
                .IsUnicode(false);

            modelBuilder.Entity<serial_db>()
                .Property(e => e.userid)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<serial_db>()
                .Property(e => e.envid)
                .IsUnicode(false);

            modelBuilder.Entity<serial_detail_db>()
                .Property(e => e.serialid)
                .IsUnicode(false);

            modelBuilder.Entity<serial_detail_db>()
                .Property(e => e.packageid)
                .IsUnicode(false);

            modelBuilder.Entity<serial_detail_db>()
                .Property(e => e.frst_orderid)
                .IsUnicode(false);

            modelBuilder.Entity<serial_detail_db>()
                .Property(e => e.last_orderid)
                .IsUnicode(false);

            modelBuilder.Entity<session_tbl>()
                .Property(e => e.sessionid)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<session_tbl>()
                .Property(e => e.id)
                .IsUnicode(false);

            modelBuilder.Entity<session_tbl>()
                .Property(e => e.request)
                .IsUnicode(false);

            modelBuilder.Entity<tachiyomi_download>()
                .Property(e => e.download_id)
                .IsUnicode(false);

            modelBuilder.Entity<tachiyomi_download>()
                .Property(e => e.user_id)
                .IsUnicode(false);

            modelBuilder.Entity<tachiyomi_download>()
                .Property(e => e.dealer_id)
                .IsUnicode(false);

            modelBuilder.Entity<tachiyomi_download>()
                .Property(e => e.env_id1)
                .IsUnicode(false);

            modelBuilder.Entity<tachiyomi_download>()
                .Property(e => e.env_id2)
                .IsUnicode(false);

            modelBuilder.Entity<tachiyomi_download>()
                .Property(e => e.env_id3)
                .IsUnicode(false);

            modelBuilder.Entity<tachiyomi_download>()
                .Property(e => e.env_id4)
                .IsUnicode(false);

            modelBuilder.Entity<tachiyomi_download>()
                .Property(e => e.remote_addr)
                .IsUnicode(false);

            modelBuilder.Entity<tachiyomi_download>()
                .Property(e => e.remote_host)
                .IsUnicode(false);

            modelBuilder.Entity<tachiyomi_download_item>()
                .Property(e => e.download_id)
                .IsUnicode(false);

            modelBuilder.Entity<tachiyomi_login>()
                .Property(e => e.user_id)
                .IsUnicode(false);

            modelBuilder.Entity<tachiyomi_login>()
                .Property(e => e.login_id)
                .IsUnicode(false);

            modelBuilder.Entity<tachiyomi_user>()
                .Property(e => e.user_id)
                .IsUnicode(false);

            modelBuilder.Entity<tachiyomi_user>()
                .Property(e => e.dealer_id)
                .IsUnicode(false);

            modelBuilder.Entity<title_genre_opt_db>()
                .Property(e => e.titleid)
                .IsUnicode(false);

            modelBuilder.Entity<title_sale>()
                .Property(e => e.title_id)
                .IsUnicode(false);

            modelBuilder.Entity<title_sale>()
                .Property(e => e.dealer_id)
                .IsUnicode(false);

            modelBuilder.Entity<top_genre_db>()
                .Property(e => e.genrecode)
                .IsUnicode(false);

            modelBuilder.Entity<top_genre_db>()
                .Property(e => e.url)
                .IsUnicode(false);

            modelBuilder.Entity<transfer_lock_history_tbl>()
                .Property(e => e.userid)
                .IsUnicode(false);

            modelBuilder.Entity<transfer_lock_history_tbl>()
                .Property(e => e.ipaddress)
                .IsUnicode(false);

            modelBuilder.Entity<trunk_basket>()
                .Property(e => e.userid)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<trunk_delivery_magazine_publish_tbl>()
                .Property(e => e.publishid)
                .IsUnicode(false);

            modelBuilder.Entity<trunk_delivery_magazine_publish_tbl>()
                .Property(e => e.trunkid)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<trunk_delivery_tbl>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<trunk_delivery_tbl>()
                .Property(e => e.detail)
                .IsUnicode(false);

            modelBuilder.Entity<trunk_delivery_tbl>()
                .Property(e => e.titleid)
                .IsUnicode(false);

            modelBuilder.Entity<trunk_delivery_user_item_tbl>()
                .Property(e => e.userid)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<trunk_delivery_user_item_tbl>()
                .Property(e => e.procid)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<trunk_delivery_user_item_tbl>()
                .Property(e => e.orderid)
                .IsUnicode(false);

            modelBuilder.Entity<trunk_delivery_user_tbl>()
                .Property(e => e.userid)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<trunk_folder>()
                .Property(e => e.trunkid)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<trunk_history>()
                .Property(e => e.procid)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<trunk_history>()
                .Property(e => e.registid)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<trunk_history>()
                .Property(e => e.origin_pcid)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<trunk_history>()
                .Property(e => e.bookid)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<trunk_history>()
                .Property(e => e.langid)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<trunk_history>()
                .Property(e => e.condition)
                .IsUnicode(false);

            modelBuilder.Entity<trunk_history>()
                .Property(e => e.errcode)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<trunk_history>()
                .Property(e => e.trunkid)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<trunk_history>()
                .Property(e => e.pcid)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<trunk_history>()
                .Property(e => e.download_id)
                .IsUnicode(false);

            modelBuilder.Entity<trunk_order>()
                .Property(e => e.orderid)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<trunk_order>()
                .Property(e => e.trunkid)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<trunk_order>()
                .Property(e => e.receipt_orderid)
                .IsUnicode(false);

            modelBuilder.Entity<trunk_order>()
                .Property(e => e.envid)
                .IsUnicode(false);

            modelBuilder.Entity<trunk_price>()
                .Property(e => e.pricename)
                .IsUnicode(false);

            modelBuilder.Entity<trunk_property>()
                .Property(e => e.trunkid)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<trunk_property>()
                .Property(e => e.buffer1)
                .IsUnicode(false);

            modelBuilder.Entity<trunk_property>()
                .Property(e => e.buffer2)
                .IsUnicode(false);

            modelBuilder.Entity<trunk_regist_book>()
                .Property(e => e.registid)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<trunk_regist_book>()
                .Property(e => e.trunkid)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<trunk_regist_book>()
                .Property(e => e.origin_pcid)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<trunk_regist_book>()
                .Property(e => e.bookid)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<trunk_regist_book>()
                .Property(e => e.langid)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<trunk_regist_book>()
                .Property(e => e.condition)
                .IsUnicode(false);

            modelBuilder.Entity<trunk_regist_book>()
                .Property(e => e.ulpcid)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<trunk_regist_book>()
                .Property(e => e.dlpcid)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<trunk_regist_pc>()
                .Property(e => e.pcid)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<trunk_regist_pc>()
                .Property(e => e.trunkid)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<trunk_regist_pc>()
                .Property(e => e.envid)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<trunk_room>()
                .Property(e => e.trunkid)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<trunk_room>()
                .Property(e => e.userid)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<trunk_room>()
                .Property(e => e.user_name)
                .IsUnicode(false);

            modelBuilder.Entity<trunk_room>()
                .Property(e => e.zipcode)
                .IsUnicode(false);

            modelBuilder.Entity<trunk_room>()
                .Property(e => e.prefecturecd)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<trunk_room>()
                .Property(e => e.city)
                .IsUnicode(false);

            modelBuilder.Entity<trunk_room>()
                .Property(e => e.street)
                .IsUnicode(false);

            modelBuilder.Entity<trunk_room>()
                .Property(e => e.building)
                .IsUnicode(false);

            modelBuilder.Entity<trunk_room>()
                .Property(e => e.tel)
                .IsUnicode(false);

            modelBuilder.Entity<trunk_service_item_db>()
                .Property(e => e.trunkid)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<trunk_service_item_db>()
                .Property(e => e.userid)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<trunk_session>()
                .Property(e => e.sessionid)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<trunk_session>()
                .Property(e => e.cid)
                .IsUnicode(false);

            modelBuilder.Entity<trunk_session>()
                .Property(e => e.trunkid)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<trunk_session>()
                .Property(e => e.envid)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<trunk_session>()
                .Property(e => e.reader_version)
                .IsUnicode(false);

            modelBuilder.Entity<trunk_unregist_book>()
                .Property(e => e.trunkid)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<trunk_unregist_book>()
                .Property(e => e.bookid)
                .IsUnicode(false);

            modelBuilder.Entity<trunk_unregist_book>()
                .Property(e => e.langid)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<trunk_unregist_book>()
                .Property(e => e.data_url)
                .IsUnicode(false);

            modelBuilder.Entity<trunk_unregist_book>()
                .Property(e => e.title)
                .IsUnicode(false);

            modelBuilder.Entity<trunk_unregist_envid>()
                .Property(e => e.trunkid)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<trunk_unregist_envid>()
                .Property(e => e.envid)
                .IsUnicode(false);

            modelBuilder.Entity<trunk_unregist_envid>()
                .Property(e => e.conflict_trunkid)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<trunk_unregist_envid>()
                .Property(e => e.conflict_envid)
                .IsUnicode(false);

            modelBuilder.Entity<trunk_use>()
                .Property(e => e.trunkid)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<trunk_use>()
                .Property(e => e.pcid)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ua_device_db>()
                .Property(e => e.pattern)
                .IsUnicode(false);

            modelBuilder.Entity<ua_device_db>()
                .Property(e => e.type_name)
                .IsUnicode(false);

            modelBuilder.Entity<ua_device_db>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<uni_genre_item>()
                .Property(e => e.last_modified_user_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<uni_genre_master>()
                .Property(e => e.last_modified_user_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<user_db>()
                .Property(e => e.userid)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<user_db>()
                .Property(e => e.nickname)
                .IsUnicode(false);

            modelBuilder.Entity<user_db>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<user_db>()
                .Property(e => e.passwd)
                .IsUnicode(false);

            modelBuilder.Entity<user_db>()
                .Property(e => e.dealerid)
                .IsUnicode(false);

            modelBuilder.Entity<user_db>()
                .Property(e => e.association)
                .IsUnicode(false);

            modelBuilder.Entity<user_db>()
                .Property(e => e.answer)
                .IsUnicode(false);

            modelBuilder.Entity<user_option_db>()
                .Property(e => e.userid)
                .IsUnicode(false);

            modelBuilder.Entity<user_option_db>()
                .Property(e => e.dealerid)
                .IsUnicode(false);

            modelBuilder.Entity<user_option_db>()
                .Property(e => e.agentid)
                .IsUnicode(false);

            modelBuilder.Entity<user_option_db>()
                .Property(e => e.branchid)
                .IsUnicode(false);

            modelBuilder.Entity<voting_candidate_db>()
                .Property(e => e.contents)
                .IsUnicode(false);

            modelBuilder.Entity<voting_info_db>()
                .Property(e => e.title)
                .IsUnicode(false);

            modelBuilder.Entity<vouchers>()
                .Property(e => e.voucher_id)
                .IsUnicode(false);

            modelBuilder.Entity<vouchers>()
                .Property(e => e.verification_key)
                .IsUnicode(false);

            modelBuilder.Entity<vouchers>()
                .Property(e => e.voucher_class)
                .IsUnicode(false);

            modelBuilder.Entity<vouchers_class>()
                .Property(e => e.voucher_class)
                .IsUnicode(false);

            modelBuilder.Entity<vouchers_class>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<vouchers_receipt>()
                .Property(e => e.voucher_id)
                .IsUnicode(false);

            modelBuilder.Entity<vouchers_receipt>()
                .Property(e => e.order_id)
                .IsUnicode(false);

            modelBuilder.Entity<vouchers_user>()
                .Property(e => e.voucher_id)
                .IsUnicode(false);

            modelBuilder.Entity<vouchers_user>()
                .Property(e => e.user_id)
                .IsUnicode(false);

            modelBuilder.Entity<wish_list_tbl>()
                .Property(e => e.userid)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<genre_db_20100316BK>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<genre_db_20100316BK>()
                .Property(e => e.kana)
                .IsUnicode(false);

            modelBuilder.Entity<mail_settings_db>()
                .Property(e => e.smtphost)
                .IsUnicode(false);

            modelBuilder.Entity<mail_settings_db>()
                .Property(e => e.mailfrom)
                .IsUnicode(false);

            modelBuilder.Entity<mail_settings_db>()
                .Property(e => e.mailbcc)
                .IsUnicode(false);

            modelBuilder.Entity<mail_settings_db>()
                .Property(e => e.notifyto)
                .IsUnicode(false);

            modelBuilder.Entity<mail_settings_db>()
                .Property(e => e.replyto)
                .IsUnicode(false);

            modelBuilder.Entity<access_counter_db>()
                .Property(e => e.pageid)
                .IsUnicode(false);

            modelBuilder.Entity<access_counter_db>()
                .Property(e => e.url)
                .IsUnicode(false);

            modelBuilder.Entity<book_jump_db>()
                .Property(e => e.bookid)
                .IsUnicode(false);

            modelBuilder.Entity<book_jump_db>()
                .Property(e => e.pageid)
                .IsUnicode(false);

            modelBuilder.Entity<book_jump_db>()
                .Property(e => e.url)
                .IsUnicode(false);

            modelBuilder.Entity<bulk_service_campaign_item_db>()
                .Property(e => e.orderid)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<bulk_service_campaign_item_db>()
                .Property(e => e.userid)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<bulk_service_campaign_item_db>()
                .Property(e => e.coupon_purpose)
                .IsUnicode(false);

            modelBuilder.Entity<bulk_service_campaign_item_db>()
                .Property(e => e.coupon_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<point_expiration_management_tbl>()
                .Property(e => e.expiration_complete_flg)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<recommend_counter_db>()
                .Property(e => e.kind)
                .IsUnicode(false);

            modelBuilder.Entity<recommend_counter_db>()
                .Property(e => e.tag)
                .IsUnicode(false);
        }
    }
}
