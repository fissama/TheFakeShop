import Vue from 'vue';
import Vuex from 'vuex';

Vue.use(Vuex);

export default new Vuex.Store({
  state: {
    SkinCare: [
      {
        name: 'Tinh Chất Giúp Da Trắng Sáng WHITE SEED BRIGHTENING SERUM 50ml',
        price: 819000,
        image: '//hstatic.net/599/1000036599/1/2016/7-4/af004367_01_1_master.jpeg',
        stars: 5,
        totalReviews: 230,
        details: 'Hiện nay việc sử dụng tinh chất (serum) để dưỡng da không còn xa lạ gì. Tuy nhiên không phải sản phẩm nào cũng đảm bảo an toàn cho da. Một số sản phẩm có chứa hoạt chất tẩy trắng mạnh có thể gây thương tổn cho da. Hiểu được điều đó, hãng mỹ phẩm hàng đầu tại Hàn Quốc  - The Face Shop, đã cho ra đời dòng tinh chất trắng da White seed Brightening serum. Chiết xuất hoàn toàn tự nhiên an toàn tuyệt đối cho làn da.',
      },
      {
        name: 'Nước Cân Bằng Da ARSAINTE ECO-THERAPY TONIC WITH ESSENTIAL 225ML',
        price: 599000,
        image: '//product.hstatic.net/1000036599/product/32000254.._8e31afa48ae1420da216f74a67627f91_master.jpeg',
        stars: 3.4,
        totalReviews: 20,
        details: 'Sản phẩm nước cân bằng da giúp bổ sung nước và tạo ra một lớp màng độ ẩm giúp da ẩm mịn trong thời gian dài.',
      },
      {
        name: 'Kem Chống Nắng Dạng Thỏi DR.BELMEUR UV DERMA MINERAL SUN STICK SPF50+ PA+++ 20g',
        price: 699000,
        image: '//product.hstatic.net/1000036599/product/dr.belmeur_uv_derma_mineral_sun_stick_20g_2cdee8b7c5a54d25acbcf53f1f4cfdd7_master.png',
        stars: 1,
        totalReviews: 1,
        details: 'Kem chống nắng Dr.Belmeur Uv Derma Mineral Sun Stick SPF50+ PA+++ với công nghệ chống nắng tiên tiến của Hàn Quốc, sở hữu màng lọc khoáng chất “mineral” giúp chặn đứng những tác hại từ tia UVA, UVB đến làn da. Bảo vệ làn da an toàn, khỏe khoắn trước cái nắng gay gắt của nước ta.Ngoài khả năng chống nắng vượt trội với chỉ số SPF50+ PA+++, kem chống nắng dạng thỏi Dr.Belmeur UV Derma Mineral Sun Stick còn dưỡng da mềm mại, dịu nhẹ với các thành phần tự nhiên được chứng nhận an toàn cho cả làn da nhạy cảm. Giúp ngăn ngừa da hình thành các đốm nâu, nếp nhăn và sự bỏng rát từ tác động của ánh nắng.',
      },
      {
        name: 'Sữa Chống Nắng Hạ Nhiệt Làn Da NATURAL SUN ECO ICE AIR PUFF SUN SPF50+PA+++ 100ml',
        price: 715000,
        image: '//product.hstatic.net/1000036599/product/sun-ice-puff_257bcc99e7a548948e4ca29ac4bbe7aa_master.jpg',
        stars: 4.4,
        totalReviews: 340,
        details: 'Đây là một siêu phẩm chống nắng duy nhất có khả năng hạ nhiệt của da ngay tức thì nhờ công nghệ Ice Air. Làn da đang nóng bức ngay lập tức được giảm xuống 5 độ C khi thoa kem chống nắng sun eco air puff sun. Làm dịu da và mang đến cho bạn cảm giác mát lạnh thoải mái. Khi sử dụng để dặm lại vào giữa ngày, kết cấu mát lạnh của sản phẩm sẽ mang lại cảm giác dễ chịu và thư giãn cho da vừa khi chuẩn bị tiếp xúc với nhiệt độ cao vào buổi trưa.',
      },
      {
        name: 'Kem Chống Nắng Lâu Trôi NATURAL SUN ECO POWER LONG-LASTING SUN CREAM SPF50+ PA+++',
        price: 655000,
        image: '//product.hstatic.net/1000036599/product/0813bd83cd4d10b79a7a7189d3e86a_grande_790855afb10244a2a0b7b5a6ce790748_b898686235d44764b3edf3802443cebc_master.jpg',
        stars: 3,
        totalReviews: 30,
        details: 'Natural sun ECO power long-lasting sun cream SPF50+ PA+++ là kem chống nắng đa năng được yêu thích nhất tại The Face Shop. Sản phẩm vừa chống nắng bảo vệ da tối đa nhờ chỉ số SPF50+, vừa có thể sử dụng làm kem lót trang điểm hoàn hảo.Hơn thế, kem chống nắng natural sun có khả năng chống thấm nước, thách thức mồ hôi, dầu nhờn. Ngăn ngừa được cả 2 tia UVA và UVB, giảm thiểu tình trạng sạm da, chống lão hóa sớm. Kem có kết cấu nhẹ, màu da tự nhiên, thoa lên da thẩm thấu nhanh không gây bết dính. Đồng thời giúp điều chỉnh sắc màu da sáng mịn tự nhiên.',
      },
      {
        name: 'Tinh Chất Cải Thiện Nếp Nhăn DR.BELMEUR RED PRO-RETINOL SERUM 50ml',
        price: 1200000,
        image: '//product.hstatic.net/1000036599/product/dr.belmeur_red_pro-retinol_serum_ec062e586e584a0eb344f259cdc6e246_master.png',
        stars: 2,
        totalReviews: 248,
        details: 'Trong mỹ phẩm dưỡng da, Retinol (một dạng vitamin A) nổi tiếng với khả năng xóa mờ nếp nhăn làm săn chắc cơ da; đồng thời giảm thiểu đốm nâu và vết nám giúp tăng sinh collagen chống oxy hóa tế bào, làm da sáng khỏe. Do đó, Retinol đã trở thành thành phần chủ đạo của Tinh chất chống lão hóa Dr.Belmeur Red Pro-Retinol Serum, mang lại hiệu quả dưỡng sáng da và tập trung cải thiện, ngăn ngừa các vấn đề xoay quanh nếp nhăn.',
      },
    ],

    Cleansers: [
      {
        name: 'Kem Tẩy Trang Làm Sáng Da THEFACESHOP RICE WATER BRIGHT FACIAL CLEANSING CREAM',
        price: 239000,
        image: '//product.hstatic.net/1000036599/product/r_bright_facial_cleansing_cream_200ml_304ee517ea7d4611aca8f753a38017e6_0f7d848a7d8c4c06ba1e70d985c01825_master.png',
        stars: 0,
        totalReviews: 0,
        details: 'Rice Water Bright Facial Cleansing Cream là sản phẩm kem tẩy trang dạng đặc giàu dưỡng chất nhẹ nhàng làm sạch bụi bẩn, bã nhờn, làm tan và lấy đi các lớp trang điểm có độ bám dính cao như kem nền, kem lót, kem che khuyết điểm, phấn nền, BB Cream, phấn mắt… giúp bạn ngăn ngừa những tổn thương đối với da do việc không tẩy trang hoặc tẩy trang không sạch gây ra.',
      },
      {
        name: 'Nước Tẩy Trang DR.BELMEUR AMINO CLEAR CLEANSING WATER 295ml',
        price: 559000,
        image: '//product.hstatic.net/1000036599/product/34420236_dr.belmeur_amino_clear_cleansing_water_f9d461f2598c4c8e9cb35638a90d8a25_master.png',
        stars: 1.5,
        totalReviews: 11,
        details: 'Nước tẩy trang dịu nhẹ Dr.Belmeur Amino Clear Cleansing Water mang công thức làm sạch sâu “Triple Micelle” giúp cuốn trôi mọi lớp trang điểm cứng đầu nằm trên bề mặt da. Đồng thời kết cấu nước dịu nhẹ giúp loại bỏ một phần tế bào chết trên da, làm sạch chất bẩn trong lỗ chân lông. Song song đó, nước tẩy trang Dr.Belmeur sẽ cung cấp độ ẩm cần thiết cho làn da, ngăn ngừa tình trạng da thô ráp kích ứng vì mất ẩm trong quá trình tẩy trang.',
      },
      {
        name: 'Gel Dưỡng Đa Năng JEJU ALOE REFRESHING SOOTHING GEL 300ml',
        price: 155000,
        image: '//product.hstatic.net/1000036599/product/32300384_dc8ef2f08ac1409dbe030b3969b23d35_master.jpg',
        stars: 1,
        totalReviews: 2,
        details: 'Gel đa năng nhẹ nhàng có thể được sử dụng cho nhiều nhu cầu khác nhau như kem dưỡng ẩm làm dịu da, chăm sóc sau khi tiếp xúc với ánh mặt trời, hoặc như mặt nạ. Đặc biệt, JEJU ALOE REFRESHING SOOTHING GEL có thể được sử dụng cho cả khuôn mặt và toàn bộ cơ thể.',
      },
      {
        name: 'Combo Dầu Tẩy Trang Cung Cấp Ẩm REAL BLEND RICH CLEANSING OIL 225ml (6pc)',
        price: 649000,
        image: '//product.hstatic.net/1000036599/product/webtfs0521-sb-12_2af72be22f0441cbb506fc11e4010360_master.jpg',
        stars: 5,
        totalReviews: 310,
        details: 'Dầu tẩy trang real blend rich chứa chiết xuất từ các tinh dầu thiên nhiên từ vùng Marseille – Pháp, là nổi tiếng với các sản phẩm làm sạch da thượng hạng. Sự pha trộn giữa các thành phần độc đáo giúp dễ dàng loại bỏ lớp phấn trang điểm dày cộm. Giữ ẩm, bảo vệ lớp biểu bì, làm dịu và cảm nhận là da tươi mới, nhẹ nhàng hơn sau khi tẩy trang.',
      },
      {
        name: 'Khăn Giấy Tẩy Trang HERB DAY CLEANSING TISSUE (70pcs)',
        price: 209000,
        image: '//product.hstatic.net/1000036599/product/khan_giay_tay_trang_the_face_shop_herb_day_cleansing_tissue__70pcs__2_924f6030639b44f88f79dc50650e968d_master.jpg',
        stars: 2.9,
        totalReviews: 42,
        details: 'Khăn giấy tẩy trang thích hợp sử dụng cho cả nam và nữ. Do không chứa cồn nên không gây kích ứng hoặc cảm giác nóng rát mặt. Làn da của bạn sẽ trở nên sáng sạch và không bị nhờn rít.',
      },
      {
        name: 'Nước Tẩy Trang RICE WATER BRIGHT MILD CLEANSING WATER 500ML',
        price: 449000,
        image: '//product.hstatic.net/1000036599/product/rice-water-bright-mild-cleansing-water-500ml_master.jpg',
        stars: 0.5,
        totalReviews: 1,
        details: 'Nước tẩy trang RICE WATER BRIGHT MILD CLEANSING WATER với công thức dịu nhẹ kết hợp với các tinh dầu tự nhiên giúp hòa tan lớp trang điểm, kem chống nắng và bụi bẩn trên da, làm sach nhẹ nhàng, cho người dùng cảm giác dịu êm.',
      },
    ],

    Makeup: [
      {
        name: '[FMGT] Phấn Nước Lâu Trôi INK LASTING CUSHION SPF30 PA++15g',
        price: 699000,
        image: '//product.hstatic.net/1000036599/product/ink-lasting_f9fa5f826c8c4e0ba4a0e4e49b245f62_83c99cb097ea4c45b8797cd67d248a8c_master.png',
        stars: 0,
        totalReviews: 0,
        details: 'Phấn Nước Ink Lasting Cushion SPF 30 PA++ có ba điểm nổi bật khiến nàng nào cũng thích. Đầu tiên là khả năng che phủ cao, giúp giấu đi mọi khuyết điểm trên mặt da. Đồng thời, Phấn nước cấp ẩm làm đầy các rãnh nhăn, góp phần tạo nên bề mặt da mềm mịn, đàn hồi tốt.',
      },
      {
        name: '[FMGT] Phấn Má Hồng Dạng Nén PASTEL CUSHION BLUSHER 6g',
        price: 259000,
        image: '//product.hstatic.net/1000036599/product/pastel_cushion_blusher_65c5742fa60a4b41b0e5686a1a06ca4e_master.png',
        stars: 1.5,
        totalReviews: 11,
        details: 'Má hồng là sản phẩm trang điểm không thể thiếu để giúp các bạn gái có vẻ đẹp tự nhiên và hoàn hảo hơn khi trang điểm. Pastel Cushion Blusher là sản phẩm phấn má hồng dạng nén, có tính năng kiềm dầu sẽ giúp bạn không những có đôi má ửng hồng đáng yêu mà còn giữ cho khuôn mặt bạn luôn ráo mịn, không bóng nhờn.',
      },
      {
        name: 'Má Hồng Dạng Nước HYDRO CUSHION BLUSH 8g',
        price: 369000,
        image: '//product.hstatic.net/1000036599/product/hydro_cushion_blush_39ade57757e34f26a8fe8b1cfc73dcf7_master.png',
        stars: 1,
        totalReviews: 2,
        details: 'HYDRO CUSHION BLUSH là sản phẩm má hồng được thiết kế theo kiểu cushion.Nắp đậy giúp bảo quản chất kem tốt hơn, cùng với miếng đệm Microfoam siêu mịn cho lớp phấn mỏng nhẹ. Độ bám cao và bền màu. Trong thành phần hoạt động, Hydro cushion có chứa Hyaluronic Acid – phân tử ngậm nước, giúp lớp má hồng trong veo, mềm mịn. Tạo hiệu ứng ửng hồng tự nhiên. Ngoài ra với thiết kế nhỏ gọn, xinh xắn sẽ rất tiện lợi khi dặm lại ở bất cứ nơi nào.',
      },
      {
        name: 'Phấn Nước Che Khuyết Điểm Dành Cho Da Nhạy Cảm DR.BELMEUR ADVANCED CICA CUSHION 15g V203',
        price: 899000,
        image: '//product.hstatic.net/1000036599/product/6558871d5345099b4c88edc1c715a6_grande_3874b05a029f4064816c03dbaea86f84_1b08e3a2cd7644bbbbce3ae987554697_master.png',
        stars: 1.5,
        totalReviews: 11,
        details: 'Phấn nước Dr.Belmeur Advanced Cica Cushion có độ che phủ cao với kết cấu kem mỏng mịn giúp che lấp các khuyết điểm trên bề mặt da như nốt đỏ, nếp nhăn, vùng da xỉn màu và lỗ chân lông to. Nhờ chất kem mỏng, ứng dụng công thức hiệu chỉnh tông màu với 5 màu sắc kết hợp giúp phấn nước Dr.Belmeur có thể làm dịu và hạn chế sắc đỏ trên da, tạo nên lớp nền tự nhiên & sáng mịn mà không gây cảm giác nặng nề cho làn da khi trang điểm nhiều lớp.',
      },
      {
        name: 'Phấn Nước Chống Nắng, Dưỡng Da YEHWADAM HWANSAENGGO BB CUSHION SPF50+ PA+++ (20g x2) NO.23',
        price: 1379000,
        image: '//product.hstatic.net/1000036599/product/yehwadam_hwansaenggo_bb_cushion_no23_360e4aaebdd34b779cfe65ab8202a742_74dae60a0f194381b1ae2d75af965992_master.png',
        stars: 1.5,
        totalReviews: 11,
        details: 'Phấn nước đa năng Yehwadam Hwansaenggo BB Cushion sẽ khiến hàng triệu phái đẹp mê mẩn khi tích hợp 3 tính năng nổi bật trong một sản phẩm trang điểm. Không kể đến khả năng tạo lớp nền make-up bền màu, lâu trôi giúp làn da thêm tươi tắn sáng sủa, phấn nước Yehwadam Hwansaenggo BB Cushion còn mang lại tác dụng nuôi dưỡng và bảo vệ da vượt trội mà rất ít sản phẩm cushion nào làm được.',
      },
      {
        name: '[FMGT] Lõi Phấn Nước Trang Điểm Lâu Trôi THEFACESHOP WATERPROOF CUSHION 15g refill',
        price: 399000,
        image: '//product.hstatic.net/1000036599/product/36000478_4f3a3dc497c64eb3b9694a3552cc4352_master.png',
        stars: 1.5,
        totalReviews: 11,
        details: 'Phấn nước trang điểm THEFACESHOP WATERPROOF CUSHION giúp duy trì lớp nền trang điểm tươi sáng tự nhiên suốt cả ngày. Công thức chống trôi trong nước và bã nhờn giúp kiểm soát tốt tình trạng dầu thừa, chống xỉn màu và duy trì lớp nền tươi sáng lâu dài. Độ che phủ khuyết điểm tối ưu với hiệu ứng mờ nhờ những hạt phấn siêu mịn cho nền da mỏng mịn tự nhiên. Vẻ ngoài khoác lớp màu xanh biển nhấn mạnh khả năng chống thấm nước tuyệt vời của sản phẩm, vừa tạo cảm giác dịu mát khi sử dụng.',
      },
    ],

    BodyCare: [
      {
        name: 'Mặt Nạ Chân SMILE FOOT MASK',
        price: 99000,
        image: '//product.hstatic.net/1000036599/product/30600024_smile_foot_mask_405e4045d2cc4a3fb572d8129c754e00_master.png',
        stars: 0,
        totalReviews: 0,
        details: 'Nâng niu chăm sóc đôi bàn chân của bạn giờ đây sẽ trở nên thật dễ dàng với mặt nạ chân Smile Foot Maks. Cách sử dụng thật đơn giản và không mất nhiều thời gian nhưng đôi chân của bạn sẽ hoàn toàn thay đổi sau khi sử dụng. Chiết xuất bạc hà sẽ nuôi dưỡng làn da, ngăn ngừa tình trạng khô sần, nứt gót chân. Bạn sẽ hoàn toàn thoải mái khi diện những đôi giày hở gót thời trang mà không cần lo lắng về đôi chân của mình.',
      },
      {
        name: 'Bộ Dưỡng Body RYAN BODY CARE TRAVEL KIT',
        price: 549000,
        image: '//product.hstatic.net/1000036599/product/bo-sua-tam-va-duong-body-ryan-body-care-travel-kit-2_82936ee7f5fa4b1684ca5cc0561e1975_master.jpg',
        stars: 1.5,
        totalReviews: 11,
        details: 'Gel tắm với thương thơm ngọt mát sẽ giúp kích thích các giác quan cùng lượng bọt mịn giúp làm sạch sâu nhưng không hề gây khô da sau khi tắm. Bạn sẽ cảm nhận được làn da sạch mịn đến bất ngờ',
      },
      {
        name: 'Tẩy Tế Bào Chết Toàn Thân YEHWADAM BODY PEELING 300ml',
        price: 599000,
        image: '//product.hstatic.net/1000036599/product/tay-te-bao-chet-toan-than-yehwadam-body-peeling_1950cacb64d44b4f903182cf864ae1b5_master.png',
        stars: 1,
        totalReviews: 2,
        details: 'Tẩy tế bào chết toàn thân chiết xuất từ nhân sâm, đậu xanh, đậu đỏ, đậu nành giúp nhẹ nhàng loại bỏ các tế bào chết, những sắc tố da sạm màu thật nhẹ nhàng. Đặc biệt, những vùng da xỉn màu đã tích tụ lâu trên bề mặt da cũng sẽ được loại bỏ đáng kể. Giúp da trắng sáng, mềm mại tức thì sau khi sử dụng. Tăng hiệu quả hấp thụ dưỡng chất cho các liệu trình dưỡng da sau đó cũng sẽ tăng gấp nhiều lần.',
      },
      {
        name: 'Gel Tắm Chống Lão Hóa RASPBERRY BODY WASH',
        price: 289000,
        image: '//product.hstatic.net/1000036599/product/765496250337_master.jpg',
        stars: 1,
        totalReviews: 2,
        details: 'Sản phẩm gel tắm RASPBERRY BODY WASH với thương thơm ngọt mát sẽ giúp kích thích các giác quan cùng lượng bọt mịn giúp làm sạch sâu nhưng không hề gây khô da sau khi tắm. Bạn sẽ cảm nhận được làn da sạch mịn đến bất ngờ.',
      },
      {
        name: 'Nước Hoa SOUL SCRET BLOSSOM',
        price: 499000,
        image: '//product.hstatic.net/1000036599/product/the-face-shop-soul-secret-blossom-30ml-5038-600x600_master.jpg',
        stars: 1,
        totalReviews: 2,
        details: 'Hương thơm cơ thể luôn tạo được một sức quyến rũ kỳ lạ. Nước hoa với hương thơm ngọt ngào sẽ mang đến nét nữ tính, cuốn hút cho bạn. Chỉ cần trong tích tắc thôi cơ thể bạn sẽ toát lên hương thơm cực kỳ tự nhiên và dễ chịu. Với hương thơm tự nhiên như từ trong cơ thể mình, chắc chắn người khác sẽ phải ngoái nhìn mỗi khi bạn lướt qua đấy.',
      },
      {
        name: 'Gel Dưỡng Da Đa Năng JEJU ALOE FRESH SOOTHING GEL',
        price: 155000,
        image: '//hstatic.net/599/1000036599/1/2016/9-9/1444362088_master.jpeg',
        stars: 1,
        totalReviews: 2,
        details: 'Gel dưỡng đa năng JEJU ALOE FRESH SOOTHING GEL chính là câu trả lời. Với kết cấu gel dịu mát sẽ giúp bạn cảm nhận ngay sự thư giãn trên da tức thì cùng với khả năng thẩm thấu nhanh và không gây cảm giác nhờn rít.',
      },
    ],

    Accessories: [
      {
        name: 'Bọt Biển Rửa Mặt THEFACESHOP BEAUTY TOOLS NATURAL CLEANSING SEA SPONGE',
        price: 45000,
        image: '//product.hstatic.net/1000036599/product/8806182565939_beauty-tools-natural-cleansing-sea-sponge_dc73da42ee5f4344ae083622910da8f3_master.jpg',
        stars: 0,
        totalReviews: 0,
        details: 'Bọt rửa mặt Daily Beauty Tools Cleansing Sea Sponge The Face Shop được làm từ Bọt biển tự nhiên, nằm trong bộ dụng cụ làm đẹp The Face Shop với khả năng hấp thụ nước nhanh, hiệu quả vệ sinh da mặt cách an toàn nhất.',
      },
      {
        name: '[FMGT] Bông Phấn Trang Điểm DAILY BEAUTY TOOLS ROUND CARON POWDER PUFF (2pcs)',
        price: 59000,
        image: '//product.hstatic.net/1000036599/product/36000735_round_caron_puff_2p_435f00058b8647508acbf9bc7744a4ac_master.jpg',
        stars: 1.5,
        totalReviews: 11,
        details: 'Phù hợp với phấn nén và phấn bột. Các sợi bông được thiết kế tỉ mỉ, mềm mại giúp lớp phấn được tán đều, mỏng mịn và bám chắc trên da hơn.',
      },
      {
        name: 'Dao tỉa chân mày DAILY BEAUTY TOOLS FOLDING EYEBROW TRIMMER (2pcs)',
        price: 75000,
        image: '//product.hstatic.net/1000036599/product/daily_beauty_tools_folding_eyebrow_trimmer_1_547c314c25af49ea986ba0bbf808433c_master.jpg',
        stars: 1,
        totalReviews: 2,
        details: 'Dao tỉa chân mày Eyebrow Trimmer với chất liệu thép không gỉ và lưỡi dao nhỏ gọn. Giúp bạn dễ dàng tạo dáng cho chân mày sắc sảo và gợi cảm. Thân nhựa cứng ABS rất dễ cầm nắm giúp bạn nhanh chóng tạo ra được đôi lông mày ưng ý.',
      },
      {
        name: 'Băng Đô Cài Tóc THEFACESHOP DAILY BEAUTY TOOLS SCRUNCHIE HAIR BAND',
        price: 79000,
        image: '//product.hstatic.net/1000036599/product/8806182564086daily-beauty-tools-scrunchie-hair-band_09a092b6b8b242e2b7535dac82ec5b70_master.jpg',
        stars: 1.5,
        totalReviews: 11,
        details: 'Băng Đô THEFACESHOP DAILY BEAUTY TOOLS SCRUNCHIE HAIR BAND là sản phẩm chuyên sử dụng khi rửa mặt, thoa kem dưỡng da, để tóc không bị dính vào sản phẩm. Băng đô dạng vải mềm, độ co giãn tốt giúp giữ tóc chặt chẽ, ngay cả phần tóc tơ cũng không lo bị ướt, bết.',
      },
      {
        name: 'Dụng Cụ Massage YEHWADAM MAGNETIC MASSAGER (1ea)',
        price: 399000,
        image: '//product.hstatic.net/1000036599/product/yehwadam_magnetic_massager_1cfe2c465f0f4747a026a450321a82b0_master.png',
        stars: 1.5,
        totalReviews: 11,
        details: 'Dụng cụ massage Yehwadam Magnetic Massager giúp tăng cường tuần hoàn máu, kích thích da hấp thụ kem dưỡng tốt hơn. Đồng thời cải thiện các nếp nhăn làm săn chắc vùng da, định hình khuôn mặt góc cạnh, sắc nét hơn.',
      },
      {
        name: 'Bông Tẩy Trang SILKY&SOFT FACIAL PAD (80pcs)',
        price: 99000,
        image: '//product.hstatic.net/1000036599/product/new_project__78__b33453c2ed4b4ed88bfea6f5b8b1aa76_master.png',
        stars: 1.5,
        totalReviews: 11,
        details: 'Hộp bông tẩy trang chứa đến 80 miếng bông cotton mềm mịn, có khả năng làm sạch nhanh và hiệu quả lớp trang điểm dày đặc trên da. Bề mặt bông mịn không làm da kích ứng, giúp nước tẩy trang thấm tốt vào da và cuốn đi các cặn bẩn sâu trong lỗ chân lông.',
      },
    ],

    cartProducts: [],
    currentProduct: {},
    showModal: false,
    showPopupCart: false,
  },

  getters: {
    getSkinCare: state => state.SkinCare,
    getCleansers: state => state.Cleansers,
    getMakeup: state => state.Makeup,
    getBodyCare: state => state.BodyCare,
    getAccessories: state => state.Accessories,
    getAllProducts: state => [...state.SkinCare, ...state.Cleansers, ...state.Makeup, ...state.BodyCare, ...state.Accessories],
    getProductsInCart: state => state.cartProducts,
    getCurrentProduct: state => state.currentProduct,
    getShowModal: state => state.showModal,
    getPopupCart: state => state.showPopupCart,
  },

  mutations: {
    ADD_PRODUCT: (state, product) => {
      state.cartProducts.push(product);
    },
    REMOVE_PRODUCT: (state, index) => {
      state.cartProducts.splice(index, 1);
    },
    CURRENT_PRODUCT: (state, product) => {
      state.currentProduct = product;
    },
    SHOW_MODAL: (state) => {
      state.showModal = !state.showModal;
    },
    SHOW_POPUP_CART: (state) => {
      state.showPopupCart = !state.showPopupCart;
    },
  },

  actions: {
    addProduct: (context, product) => {
      context.commit('ADD_PRODUCT', product);
    },
    removeProduct: (context, index) => {
      context.commit('REMOVE_PRODUCT', index);
    },
    currentProduct: (context, product) => {
      context.commit('CURRENT_PRODUCT', product);
    },
    showOrHiddenModal: (context) => {
      context.commit('SHOW_MODAL');
    },
    showOrHiddenPopupCart: (context) => {
      context.commit('SHOW_POPUP_CART');
    },
  },
});
