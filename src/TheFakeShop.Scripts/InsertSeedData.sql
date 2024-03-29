﻿USE TheFakeShop;
--INSERT CATEGORIES
BEGIN TRANSACTION
INSERT INTO Categories(CategoryName,ParentID) VALUES (N'Dưỡng Da',null);
INSERT INTO Categories(CategoryName,ParentID) VALUES (N'Làm Sạch',null);
INSERT INTO Categories(CategoryName,ParentID) VALUES (N'Trang Điểm Nền',null);
INSERT INTO Categories(CategoryName,ParentID) VALUES (N'Trang Điểm',null);
INSERT INTO Categories(CategoryName,ParentID) VALUES (N'Chăm Sóc Cơ Thể',null);
INSERT INTO Categories(CategoryName,ParentID) VALUES (N'Phụ Kiện',null);
INSERT INTO Categories(CategoryName,ParentID) VALUES (N'Mặt Nạ',1);
INSERT INTO Categories(CategoryName,ParentID) VALUES (N'Nước Cân Bằng',1);
INSERT INTO Categories(CategoryName,ParentID) VALUES (N'Xịt Khoáng',1);
INSERT INTO Categories(CategoryName,ParentID) VALUES (N'Tinh Chất Dưỡng',1);
INSERT INTO Categories(CategoryName,ParentID) VALUES (N'Kem Dưỡng Da Mặt',1);
INSERT INTO Categories(CategoryName,ParentID) VALUES (N'Kem Chống Nắng',1);
INSERT INTO Categories(CategoryName,ParentID) VALUES (N'Sữa Rửa Mặt',2);
INSERT INTO Categories(CategoryName,ParentID) VALUES (N'Sản Phẩm Tẩy Trang',2);
INSERT INTO Categories(CategoryName,ParentID) VALUES (N'Tẩy Trang Mắt Và Môi',2);
INSERT INTO Categories(CategoryName,ParentID) VALUES (N'Sản Phẩm Làm Sạch Tế Bào Chết',2);
INSERT INTO Categories(CategoryName,ParentID) VALUES (N'Phấn Nước Cushion',3);
INSERT INTO Categories(CategoryName,ParentID) VALUES (N'Kem Nền Foundation',3);
INSERT INTO Categories(CategoryName,ParentID) VALUES (N'Kem Lót',3);
INSERT INTO Categories(CategoryName,ParentID) VALUES (N'Tạo Khối/ Tạo Sáng',3);
INSERT INTO Categories(CategoryName,ParentID) VALUES (N'Kem Che Khuyết Điểm',3);
INSERT INTO Categories(CategoryName,ParentID) VALUES (N'Kem Nền Đa Năng BB/ CC Cream',3);
INSERT INTO Categories(CategoryName,ParentID) VALUES (N'Son',4);
INSERT INTO Categories(CategoryName,ParentID) VALUES (N'Trang Điểm Mắt',4);
INSERT INTO Categories(CategoryName,ParentID) VALUES (N'Má Hồng',4);
INSERT INTO Categories(CategoryName,ParentID) VALUES (N'Màu Mắt',4);
INSERT INTO Categories(CategoryName,ParentID) VALUES (N'Chân Mày',4);
INSERT INTO Categories(CategoryName,ParentID) VALUES (N'Mascara',4);
INSERT INTO Categories(CategoryName,ParentID) VALUES (N'Sữa Tắm',5);
INSERT INTO Categories(CategoryName,ParentID) VALUES (N'Sản Phẩm Dưỡng Thể',5);
INSERT INTO Categories(CategoryName,ParentID) VALUES (N'Làm Sạch Tế Bào Chết Cơ Thể',5);
INSERT INTO Categories(CategoryName,ParentID) VALUES (N'Chăm Sóc Tóc',5);
INSERT INTO Categories(CategoryName,ParentID) VALUES (N'Kem Dưỡng Tay/ Chân',5);
INSERT INTO Categories(CategoryName,ParentID) VALUES (N'Nước Hoa',5);
INSERT INTO Categories(CategoryName,ParentID) VALUES (N'Cọ Trang Điểm',6);
INSERT INTO Categories(CategoryName,ParentID) VALUES (N'Bông Mút Trang Điểm',6);
INSERT INTO Categories(CategoryName,ParentID) VALUES (N'Dụng Cụ Trang Điểm',6);
INSERT INTO Categories(CategoryName,ParentID) VALUES (N'Phụ Kiện Làm Sạch',6);
INSERT INTO Categories(CategoryName,ParentID) VALUES (N'Dụng Cụ Massage',6);
COMMIT TRANSACTION
--Please change CategoryID & ProductID before insert.
BEGIN TRANSACTION
	INSERT INTO Products(ProductName,Price,InStock,Description,CategoryID) VALUES (N'Mặt Nạ Cấp Nước DEEPLY HYDRATING MASCREAM LIFTING SHEET MASK 40ml',95000,200,N'Mặt nạ siêu dưỡng chất được chứa đựng trong chất liệu giấy Microfiber siêu mềm tựa làn mây, mang đến cảm giác mềm mại, dễ chịu cho làn da.
là dòng mặt nạ chăm sóc da cải tiến, thay đổi hoàn toàn khái niệm về mặt nạ giấy, cho bạn trải nghiệm hoàn toàn khác biệt so với các loại mặt nạ hiện có trên thị trường
ĐIỂM NỔI BẬT CỦA DÒNG MẶT NẠ MASCREAM LIFTING SHEET MASK
- Tối ưu hóa khả năng dưỡng da nhờ dưỡng chất dạng kem (thay cho dạng tinh chất thông thường) nhưng có kết cấu vô cùng nhẹ và mát, tạo cảm giác mát dịu cho làn da, hoàn toàn không gây cảm giác bít tắc, nhờn rít
- Sở hữu chất liệu giấy tiên tiến Microfiber, với bề mặt gồm các sợi cực kỳ mềm mại và mịn cho cảm giác như chạm vào làn mây khi tiếp xúc với da, đồng thời mặt nạ tối đa hóa việc đưa dưỡng chất vào sâu trong da.',7);
	INSERT INTO Products(ProductName,Price,InStock,Description,CategoryID) VALUES (N'Xịt Khoáng Dưỡng Ẩm CHIA SEED ADVANCED HYDRO HYDRATING MIST 170ml',569000,102,N'Xịt khoáng là công cụ cần thiết giúp bảo vệ da tức thì, tránh da khô ráp đồng thời làm dịu nhanh cảm giác châm chích, ngứa rát ở da do thiếu ẩm. Vì thế, Xịt khoáng dưỡng ẩm Chia Seed Hydrating Mist là sản phẩm cấp cứu cho da bất cứ khi nào gặp phải tình trạng mất ẩm, mang lại cảm giác dịu mát mềm mại cho da sau lớp màng khoáng sương sương tinh khiết.
Chia Seed Hydrating Mist đặc biệt phù hợp cho mọi làn da, nhất là da khô và nhạy cảm. Giúp cung cấp độ ẩm cần thiết cho lớp biểu bì, bù nước ở vùng da khô ráp với khả năng cấp nước gấp 15 lần của hạt chia. Đồng thời xịt khoáng dưỡng ẩm Chia Seed đưa da về trạng thái cân bằng, duy trì sự mềm mại và tươi tắn cho da.

Sản phẩm nằm trong dòng dưỡng da CHIA SEED Advanced của THEFACESHOP, sở hữu thành phần chính là hạt chia Mexico cùng vitamin B12 có tính năng cấp nước gấp 15 lần, dưỡng ẩm chuyên sâu và nuôi dưỡng da mềm mịn mỗi ngày.',9);
	INSERT INTO Products(ProductName,Price,InStock,Description,CategoryID) VALUES (N'Sữa Rửa Mặt Phục Hồi Sinh Khí Làm Sáng Da HERB DAY 365 MASTER BLENDING LIQUID FOAM ACEROLA & BLUEBERRY (215ml)',369000,105,N'Sữa rửa mặt HERB DAY 365 Master Blending Liquid Foam với phức hợp thảo mộc thiên nhiên giúp dễ dàng làm sạch bụi bẩn, bã nhờn và làm sạch sâu lỗ chân lông, mang lại hiệu quả làm sạch mạnh mẽ nhưng vô cùng an toàn và dịu nhẹ.

Vitamin C chiết xuất từ trái anh đào & việt quất có công dụng chống oxy hóa & làm sáng đều màu da. Công thức làm sạch dịu nhẹ hơn nhưng vẫn đảm bảo hiệu quả làm sạch so với Herb Day 365 Foaming Cleanser. 

THEFACESHOP xin giới thiệu thêm một ưu điểm của dòng sản phẩm này chính là thiết kế dạng bơm. Giảm hơn 30% các hoạt chất làm sạch so với dạng tuýp, bổ sung các thành phần axit amin giúp lưu giữ độ ẩm cho làn da. Giúp giảm khả năng kích ứng da.',13);
	INSERT INTO Products(ProductName,Price,InStock,Description,CategoryID) VALUES (N'Sữa Rửa Mặt Làm Mềm Mịn Da JEJU ALOE FRESH SOOTHING FOAM CLEANSER 150ml',169000,100,N'- Công dụng chính: Sữa rửa mặt Jeju Aloe cho khả năng làm sạch dịu nhẹ, đồng thời cấp ẩm mang lại cảm giác mát lạnh và êm dịu cho làn da.

- Thành phần chính: Nha đam
Sữa rửa mặt trở thành bước chăm sóc quen thuộc cho làn da mỗi ngày, giúp loại bỏ những tác hại từ bên ngoài đang đeo bám trên da, làm cho lỗ chân lông thông thoáng, duy trì bề mặt da sạch khỏe. Với Sữa rửa mặt Jeju Aloe Fresh Soothing Foam Cleanser, nằm trong dòng sản phẩm được chiết xuất từ nha đam (của đảo Jeju, Hàn Quốc) mang lại hiệu quả làm sạch dịu nhẹ, đồng thời cấp ẩm cải thiện bề mặt da thô sần. Cho cảm giác da sạch mịn, mát mẻ sau khi được làm sạch.

Jeju Aloe Fresh Soothing Foam Cleanser là sữa rửa mặt có kết cấu dạng gel mát, êm dịu trên da vừa làm sạch nhẹ nhàng lỗ chân lông, loại bỏ bụi bẩn đồng thời cấp ẩm làm mát da nhờ chiết xuất nha đam nổi tiếng tại đảo Jeju trong lành. Làn da được cấp ẩm, cải thiện bề mặt thô sần tránh cảm giác châm chích.',13);
	INSERT INTO Products(ProductName,Price,InStock,Description,CategoryID) VALUES (N'Combo Mascara Làm Cong Mi THEFACESHOP 2 IN 1 CURLING MASCARA 02 BROWN (3pc)',495000,152,N'**Combo gồm 03 sản phẩm:

01 [FMGT] Mascara Làm Cong Mi THEFACESHOP 2 IN 1 CURLING MASCARA 02 BROWN

01 Bộ Làm Sạch Và Dưỡng Da DR. BELMEUR CLARIFYING 3-STEP KIT

01 Chì Kẻ Chân Mày Đa Năng BROWLASTING WATERPROOF EYEBROW PENCIL 03 DARK GROWN



**Công dụng chi tiết:

[FMGT] MASCARA LÀM CONG MI THEFACESHOP 2 IN 1 CURLING MASCARA 02 BROWN
Mascara The Face Shop 2 trong 1 Curling Mascara với thiết kế 2 đầu cọ: cọ to chải thông thường tạo độ cong cho mi và đầu cọ nhỏ siêu mảnh 3.5mm tiện lợi cho những vùng khó chải như đầu và cuối chân mi, làn mi dưới. Chất gel nhẹ, không gây nặng mi, giúp sợi mi được uốn cong và giữ nếp lâu dài. Mascara làm cong mi tối ưu',28);

	INSERT INTO ProductImages(ImageLink,ProductID) VALUES ('https://res.cloudinary.com/fissama/image/upload/v1617808933/TheFakeShop/mascream_lifting_sheet_mask_hydrat_df0b1163ffc64a3e99c79cb9ec4befca_master_orr2pf.webp',1);
	INSERT INTO ProductImages(ImageLink,ProductID) VALUES ('https://res.cloudinary.com/fissama/image/upload/v1617808933/TheFakeShop/mascream_lifting_sheet_mask_5ac91a246c3c4ab99c27304a9da577a0_master_nnfl1o.webp',1);
	INSERT INTO ProductImages(ImageLink,ProductID) VALUES ('https://res.cloudinary.com/fissama/image/upload/v1617808933/TheFakeShop/mascream_lifting_sheet_mask__3fc2d560c5854895b160f2c5818b30a4_master_nflyt6.webp',1);
	INSERT INTO ProductImages(ImageLink,ProductID) VALUES ('https://res.cloudinary.com/fissama/image/upload/v1617808932/TheFakeShop/mascream_lifting_sheet_mask_1_4fc59a909eb640028309d54e6258b9c1_master_o4uekq.webp',1);
	INSERT INTO ProductImages(ImageLink,ProductID) VALUES ('https://res.cloudinary.com/fissama/image/upload/v1617938426/TheFakeShop/chia_seed_hydrating_mist_165ml_af9d3efc0e6d454e83f531a07b5730ee_master_bwzizm.webp',2);
	INSERT INTO ProductImages(ImageLink,ProductID) VALUES ('https://res.cloudinary.com/fissama/image/upload/v1617938427/TheFakeShop/acrola_89bbbda421a14b2495e2baf35c31a00b_master_s8kdm4.webp',3);
	INSERT INTO ProductImages(ImageLink,ProductID) VALUES ('https://res.cloudinary.com/fissama/image/upload/v1617938425/TheFakeShop/acrola-2_5b19d3830b894a5db4660a464f9c0166_master_axhrp8.webp',3);
	INSERT INTO ProductImages(ImageLink,ProductID) VALUES ('https://res.cloudinary.com/fissama/image/upload/v1617938426/TheFakeShop/jeju_aloe_fresh_soothing_foam_cleanser_150ml_57b8576cf0244b29b590452d3cb4c449_master_pj8jj4.webp',4);
	INSERT INTO ProductImages(ImageLink,ProductID) VALUES ('https://res.cloudinary.com/fissama/image/upload/v1617938426/TheFakeShop/jeju_aloe_fresh_soothing_foam_cleanser_3_248d1c15b7cd4189b9907de7f248f4bc_master_agijgj.webp',4);
	INSERT INTO ProductImages(ImageLink,ProductID) VALUES ('https://res.cloudinary.com/fissama/image/upload/v1617938426/TheFakeShop/webtfs0121-mw-fls26-42_2c9f80de56e94485b5938df888058883_67e63c1c381f47ae8cef6bf5b12a88c6_master_neblua.webp',5);

	INSERT INTO ProductRatings(CustomerName,CustomerEmail,Rating,Title,Content,ProductID) VALUES (N'Trần Đức Bo','3conmeo@gmail.com',4,N'Sản phẩm hơi phake',N'Mèo méo meo mèo meo',1);
	INSERT INTO ProductRatings(CustomerName,CustomerEmail,Rating,Title,Content,ProductID) VALUES (N'Zeros','3ros@gmail.com',5,N'Sản phẩm rất tốt',N'Mặt nạ ZEROtovcS',1);
COMMIT TRANSACTION