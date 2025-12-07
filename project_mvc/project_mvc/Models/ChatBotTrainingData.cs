using System.Collections.Generic;

namespace project_mvc.Models
{
    public class ChatBotTrainingItem
    {
        public List<string> Keywords { get; set; }
        public string Answer { get; set; }
    }

    public static class ChatBotTrainingData
    {
        public const string DefaultAnswer = "Mình đã ghi nhận câu hỏi và sẽ hỗ trợ nhanh nhất. Bạn có thể mô tả rõ hơn về da, nhu cầu hoặc mã đơn để mình tư vấn chi tiết.";

        public static readonly IReadOnlyList<ChatBotTrainingItem> Library = new List<ChatBotTrainingItem>
        {
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "yehwadam revitalizing", "nước cân bằng yehwadam revitalizing", "toner yehwadam revitalizing", "nước cân bằng yehwadam", "yehwadam revitalizing toner", "nước hoa hồng yehwadam", "nước cân bằng yehwadam phục hồi", "yehwadam toner đỏ" },
                Answer = "Nước cân bằng Yehwadam Revitalizing là toner giúp làm sạch sâu sau rửa mặt, cân bằng pH, làm dịu và cải thiện độ đàn hồi cho da mệt mỏi, khô ráp; dùng ngay sau SRM để da hấp thu dưỡng tốt hơn."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "dr.belmuer clean face mild lotion", "sữa dưỡng dr belmeur clean face", "clean face mild lotion", "lotion dr belmeur da dầu", "sữa dưỡng da dầu nhạy cảm", "emulsion dr belmeur", "dưỡng dr belmeur cho da mụn" },
                Answer = "Sữa dưỡng Dr.Belmeur Clean Face Mild Lotion là lotion nhẹ cho da dầu và nhạy cảm, giúp cân bằng ẩm – giảm bóng dầu nhưng không bí tắc lỗ chân lông, phù hợp dùng hằng ngày."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "the therapy first serum", "serum the therapy", "first serum", "tinh chất mở đầu", "tinh chất the therapy", "serum phục hồi da khô", "serum lên men thảo mộc" },
                Answer = "The Therapy First Serum là tinh chất mở đầu giúp da ẩm sâu, mềm và căng bóng, hỗ trợ phục hồi da khô ráp, thiếu ẩm và chuẩn bị da cho các bước serum/kem dưỡng phía sau."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "yehwadam eye cream", "kem dưỡng mắt yehwadam", "eye cream yehwadam", "kem mắt chống nhăn yehwadam", "kem mắt dưỡng ẩm yehwadam" },
                Answer = "Kem dưỡng mắt Yehwadam giúp cấp ẩm, cải thiện nếp nhăn và độ đàn hồi vùng da quanh mắt, phù hợp cho da bắt đầu lão hóa hoặc phải thức khuya nhiều."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "yehwadam deep moisturizing cleanser", "sữa rửa mặt yehwadam dưỡng ẩm", "srm yehwadam sâu ẩm", "srm yehwadam deep moisturizing" },
                Answer = "Sữa rửa mặt Yehwadam Deep Moisturizing làm sạch dịu nhẹ, giữ ẩm tốt, phù hợp da khô – da thường – da thiếu nước, giúp da ẩm mượt và không khô căng sau khi rửa."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "yehwadam plum flower toner", "nước cân bằng hoa mận", "nước hoa hồng yehwadam plum", "yehwadam plum flower", "nước cân bằng phục hồi sinh khí" },
                Answer = "Yehwadam Plum Flower là toner phục hồi sinh khí cho da xỉn màu, thiếu sức sống; giúp cân bằng pH, cấp ẩm và làm da tươi sáng, căng mọng hơn khi dùng đều."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "tinh chất thuần chay đều màu da", "serum thuần chay làm đều màu", "tinh chất the face shop thuần chay", "serum niacinamide thuần chay" },
                Answer = "Tinh chất thuần chay The Face Shop làm đều màu da với Niacinamide và chiết xuất thực vật giúp giảm thâm, hỗ trợ sáng da nhẹ nhàng, phù hợp cả da nhạy cảm."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "calendula emulsion", "sữa dưỡng calendula", "sữa dưỡng làm dịu calendula", "emulsion hoa cúc", "calendula the face shop" },
                Answer = "Sữa dưỡng Calendula Emulsion làm dịu nhanh da mẩn đỏ, căng rát; cấp ẩm vừa đủ và cực hợp cho da yếu – da nhạy cảm – da dễ kích ứng."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "dr.belmuer advanced eye cream", "kem dưỡng mắt dr belmeur", "eye cream dr belmeur", "kem mắt chống nhăn dr belmeur" },
                Answer = "Kem dưỡng mắt Dr.Belmeur Advanced Eye Cream tập trung cải thiện nếp nhăn, quầng thâm và độ đàn hồi vùng da mắt với peptide + ceramide, rất hợp da lão hóa sớm."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "heaven grade yehwadam", "bộ dưỡng heaven grade", "bộ dưỡng yehwadam cải thiện nếp nhăn", "set yehwadam heaven", "bộ chống lão hóa cao cấp yehwadam" },
                Answer = "Bộ dưỡng Yehwadam Heaven Grade là bộ chống lão hóa cao cấp với thảo mộc truyền thống Hàn Quốc, tập trung cải thiện nếp nhăn sâu, săn chắc và trẻ hóa da từ 25+."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "total youth biome cream", "kem dưỡng total youth biome", "kem dưỡng dr belmeur biome", "kem dưỡng mịn da dr belmeur" },
                Answer = "Kem dưỡng Dr.Belmeur Total Youth Biome Cream cân bằng hệ vi sinh da, dưỡng ẩm sâu, giúp da mịn và căng hơn, phù hợp da khô – da yếu – da có dấu hiệu lão hóa."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "amino clear cleanser", "dr belmeur amino clear", "sữa rửa mặt amino clear", "srm dr belmeur amino", "srm dịu nhẹ dr belmeur" },
                Answer = "Sữa rửa mặt Dr.Belmeur Amino Clear làm sạch sâu nhưng dịu, không khô căng, phù hợp da dầu – hỗn hợp – nhạy cảm, hỗ trợ giảm mụn và bảo vệ hàng rào da."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "vita serum dr belmeur", "vita serum xỉn màu", "tinh chất vita dr belmeur", "tinh chất cải thiện xỉn màu" },
                Answer = "Vita Serum Dr.Belmeur giúp cải thiện da xỉn màu, thiếu sức sống nhờ vitamin phức hợp; dùng sáng – tối giúp da đều màu, tươi và khỏe hơn."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "total youth biome emulsion", "sữa dưỡng total youth", "emulsion dr belmeur biome" },
                Answer = "Sữa dưỡng Dr.Belmeur Total Youth Biome Emulsion cấp ẩm nhẹ, dễ thấm, giúp da căng và mịn hơn, hợp với da bắt đầu lão hóa hoặc cần dưỡng ẩm chống khô."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "herb day aloe", "sữa rửa mặt herb day lô hội", "srm herb day aloe", "sữa rửa mặt lô hội", "herbday aloe" },
                Answer = "Sữa rửa mặt Herb Day 365 Aloe làm sạch bụi bẩn, dầu thừa nhưng vẫn giữ da ẩm mịn; phù hợp da khô, da nhạy cảm hoặc da muốn cảm giác dịu nhẹ mỗi lần rửa."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "rice water bright oil", "dầu tẩy trang rice water", "tẩy trang dạng dầu nước gạo", "rice oil tẩy trang" },
                Answer = "Dầu tẩy trang Rice Water Bright giúp cuốn sạch kem chống nắng, makeup dày và mascara chống trôi, nhũ hóa nhanh – không nhờn rít, dùng được cho mọi loại da."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "white jewel peeling", "smart peeling white jewel", "tẩy tế bào chết white jewel", "tẩy da chết smart peeling" },
                Answer = "Tẩy tế bào chết Smart Peeling White Jewel gom tế bào chết nhẹ nhàng, giúp da sáng và mịn hơn mà không rát, phù hợp da xỉn màu – sần sùi."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "smart peeling body", "tẩy tế bào chết cơ thể", "tẩy da chết body smart peeling" },
                Answer = "Smart Peeling Body loại bỏ da chết toàn thân, làm mịn vùng khuỷu tay, đầu gối, gót chân; nên dùng 1–2 lần/tuần để da luôn mướt và sáng."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "tẩy trang dạng sáp", "cleansing balm the face shop", "sáp tẩy trang", "cleanser balm", "tẩy trang sáp" },
                Answer = "Sáp tẩy trang The Face Shop tan thành dầu khi massage, làm sạch sâu kem chống nắng và makeup dày mà vẫn ẩm mịn, cực tiện khi đi du lịch."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "nước tẩy trang mắt môi", "eye & lip remover", "tẩy trang mắt môi the face shop", "tẩy son lì", "tẩy mascara chống nước" },
                Answer = "Nước tẩy trang mắt & môi The Face Shop làm sạch son lì, mascara chống nước nhanh gọn, không cay mắt, không khô môi – nên dùng trước bước rửa mặt."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "tẩy tế bào chết ngọc trai", "peeling ngọc trai", "tẩy da chết ngọc trai the face shop" },
                Answer = "Tẩy da chết ngọc trai giúp da mịn, sáng dần nhờ bột ngọc trai; hạt scrub nhỏ, êm – dùng 1–2 lần/tuần để giảm sần và hỗ trợ đều màu da."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "yehwadam body peeling", "tẩy tế bào chết body yehwadam", "tẩy da chết toàn thân yehwadam" },
                Answer = "Yehwadam Body Peeling tẩy tế bào chết cơ thể với thảo mộc đông y, giúp da body sáng, mịn và đều màu hơn, rất hợp da sần – khô – xỉn."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "real nature aloe mask", "mặt nạ real nature aloe", "mask lô hội real nature", "mặt nạ lô hội", "mask dưỡng ẩm aloe" },
                Answer = "Mặt nạ Real Nature Aloe cấp ẩm, làm dịu nhanh da khô, da cháy nắng hoặc da đỏ rát; rất hợp da nhạy cảm cần hạ nhiệt tức thì."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "yehwadam nutrition mask", "mặt nạ yehwadam nutrition", "mask yehwadam phục hồi", "mặt nạ dưỡng yehwadam" },
                Answer = "Mặt nạ Yehwadam Nutrition Mask cung cấp dưỡng chất dồi dào, giúp da khô – thiếu ẩm trở nên căng mướt, đàn hồi và sáng mịn hơn."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "real nature mask", "mặt nạ real nature", "mask giấy the face shop", "tfs 47", "mặt nạ giấy tfs" },
                Answer = "Dòng Real Nature Mask có nhiều phiên bản (lô hội, gạo, trà xanh...) tập trung cấp ẩm, làm sáng hoặc làm dịu; dùng 2–3 lần/tuần da sẽ khỏe và tươi hơn rõ."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "mask mắt gạo", "mặt nạ mắt real nature rice", "mask mắt the face shop", "mặt nạ mắt gạo" },
                Answer = "Mặt nạ mắt Real Nature Rice hỗ trợ làm sáng vùng quầng thâm, cấp ẩm và làm mịn rãnh nhăn li ti dưới mắt, rất hợp cho người hay thức khuya."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "smile foot peeling", "mặt nạ chân smile foot", "tẩy da chết chân", "mask chân tẩy tế bào chết" },
                Answer = "Smile Foot Peeling Mask là mặt nạ tẩy da chết chân, giúp bong lớp da chai sần ở gót/chân sau vài ngày, trả lại da chân mềm và sáng hơn như spa."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "rich hand mask", "mặt nạ tay rich hand", "mask tay the face shop" },
                Answer = "Mặt nạ tay Rich Hand cấp ẩm sâu, phục hồi da tay khô nứt – rất hợp với ai hay dùng nước rửa tay, hóa chất hoặc thời tiết lạnh."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "dr belmeur youth biome mask", "total youth biome mask", "mặt nạ dr belmeur săn chắc", "mask dr belmeur" },
                Answer = "Mặt nạ Dr.Belmuer Total Youth Biome Mask là mask biocellulose ôm sát da, tập trung làm săn chắc – đàn hồi, phù hợp da lão hóa hoặc mệt mỏi."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "ink lasting cushion", "phấn nước ink lasting", "cushion ink lasting foundation", "phấn nước che phủ the face shop" },
                Answer = "Phấn nước Ink Lasting Cushion cho lớp nền mịn, che phủ tốt, lâu trôi và ráo mịn; hợp da dầu – hỗn hợp cần nền bền màu cả ngày."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "fmgt ink lasting glow", "kem nền ink lasting glow", "nền glow fmgt", "kem nền căng bóng fmgt" },
                Answer = "Kem nền FMGT Ink Lasting Glow cho lớp nền căng bóng nhẹ, mỏng mịn – phù hợp da thường đến khô, da muốn hiệu ứng glow Hàn Quốc."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "pastel cushion blusher", "má hồng pastel cushion", "phấn má pastel cushion", "cushion blusher" },
                Answer = "Pastel Cushion Blusher là má hồng dạng cushion dễ tán, tự nhiên như má ửng hồng thật, bám tốt và không bị dày phấn."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "rouge satin moisture", "son rouge satin", "son satin dưỡng ẩm", "son thỏi rouge satin moisture" },
                Answer = "Rouge Satin Moisture là son thỏi satin dưỡng cao, môi mềm – căng, che rãnh môi tốt, hợp cho môi khô hoặc thích son bóng nhẹ."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "water fit lip tint", "son tint water fit", "tint water fit", "son tint nước the face shop" },
                Answer = "Water Fit Lip Tint là tint nước trong trẻo, lâu trôi nhưng không khô môi, phù hợp makeup tự nhiên hằng ngày cho học sinh – sinh viên."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "lipcare cream", "son dưỡng lipcare", "lipcare cream the face shop", "son dưỡng phục hồi môi" },
                Answer = "Lipcare Cream là son dưỡng chuyên sâu, phục hồi môi khô nứt, dùng trước son màu hoặc buổi tối như mặt nạ môi."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "ink lasting foundation cushion vegan", "cushion vegan", "phấn nước thuần chay", "glow fit vegan cushion" },
                Answer = "Glow Fit Vegan Cushion là phấn nước thuần chay, nền mỏng – căng bóng, che phủ linh hoạt và an toàn cho da nhạy cảm."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "freshian foundation", "kem nền freshian da dầu", "kem nền cho da dầu freshian" },
                Answer = "Kem nền Freshian kiểm soát dầu tốt, che phủ khá, hợp da dầu – hỗn hợp trong khí hậu nóng ẩm, giúp nền ít tách và ít bóng."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "kem lót gold correcting base", "gold cover primer", "kem lót fmgt vàng", "kem lót che lỗ chân lông" },
                Answer = "Gold Correcting/Gold Cover Primer giúp làm mịn lỗ chân lông, nền bám lâu và đều màu hơn, thích hợp dùng trước kem nền/cushion."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "dual veil concealer", "fmgt concealer dual veil", "che khuyết điểm dual veil", "thanh che khuyết điểm dual" },
                Answer = "Fmgt Concealer Dual Veil có 2 đầu (kem & thỏi) giúp che thâm mụn, quầng thâm và đốm nâu linh hoạt, dễ dùng cho cả người mới bắt đầu."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "veil glow blusher", "má hồng veil glow", "phấn má glow veil" },
                Answer = "Veil Glow Blusher tạo má hồng trong veo, bắt sáng nhẹ – hợp makeup trong suốt, bám màu ổn nhiều giờ."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "ink lasting powder", "phấn phủ ink lasting", "phấn phủ chống nắng", "phấn phủ kiềm dầu the face shop" },
                Answer = "Ink Lasting Powder là phấn phủ siêu mịn, kiềm dầu tốt, giúp làm mờ lỗ chân lông và còn hỗ trợ chống nắng nhẹ."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "veil glow highlighter", "phấn highlight veil glow", "highlight bắt sáng" },
                Answer = "Veil Glow Highlighter cho hiệu ứng glow tinh tế, bắt sáng vùng gò má, sống mũi… mà không bị lộ phấn hay mảng nhũ thô."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "power perfection bb", "kem nền power perfection", "bb cream the face shop power perfection" },
                Answer = "Kem nền/BB Power Perfection che phủ tốt, làm đều màu da và cho hiệu ứng nền mịn – phù hợp da cần che khuyết điểm rõ rệt."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "kem nền thuần chay căng bóng", "kem nền vegan glow", "foundation vegan the face shop" },
                Answer = "Kem nền thuần chay hiệu ứng căng bóng cho lớp nền mịn, tươi tắn nhưng vẫn ẩm mịn, thích hợp da thường – khô và da nhạy cảm."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "fmgt long lash mascara", "mascara designing long lash", "mascara làm dài mi", "mascara long lash" },
                Answer = "Mascara Designing Long Lash giúp mi dài, tơi, không vón – chống lem nhẹ và dễ tẩy trang, hợp style mi tự nhiên kiểu Hàn."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "ink graffi liner", "ink graffi brush pen liner", "kẻ mắt ink graffi", "bút kẻ mắt đầu cọ mảnh" },
                Answer = "Ink Graffi Brush Pen Liner là kẻ mắt đầu cọ siêu mảnh, nét sắc – lâu trôi nhưng dễ dùng, phù hợp cả người mới tập kẻ."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "mascara mimmax eye", "mascara mim max", "mascara làm dày mi" },
                Answer = "Mascara Mimmax Eye tập trung làm dày & cong mi, không vón cục, giữ mi cong lâu mà vẫn nhẹ."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "bold semi matte", "new bold semi matte", "son thỏi semi matte the face shop", "son bold sheer" },
                Answer = "Son thỏi New Bold Semi Matte/Bold Sheer cho chất son bán lì, mịn môi, lên màu chuẩn mà vẫn êm – không khô môi."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "tint bóng mượt", "water glow tint", "son tint bóng mướt", "tint bóng the face shop" },
                Answer = "Son tint bóng mượt cho môi căng mọng, màu trong trẻo lâu trôi; rất hợp makeup Hàn Quốc, môi nhìn tươi và đầy hơn."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "vitamin ampoule lip", "son dưỡng vita ampoule", "freshian son dưỡng thuần chay", "son dưỡng vegan" },
                Answer = "Son dưỡng Vita Ampoule thuần chay giúp dưỡng ẩm – phục hồi môi khô, tạo độ bóng nhẹ và an toàn cho môi nhạy cảm."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "chì chân mày designing eyebrow", "designing eyebrow pencil", "chì mày the face shop" },
                Answer = "Designing Eyebrow Pencil có đầu tam giác dễ vẽ khung & tô mày, đầu chải giúp tán đều, cho dáng mày tự nhiên rất dễ dùng mỗi ngày."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "eye moment palette", "bảng phấn mắt eye moment", "bảng phấn mắt 4 ô" },
                Answer = "Eye Moment Palette gồm 4 màu mắt phối sẵn, có nhũ – lì đủ dùng từ makeup ngày nhẹ tới tiệc, phấn mịn và bám tốt."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "ink proof marker pen liner", "bút dạ kẻ mắt ink proof", "kẻ mắt lâu trôi ink proof" },
                Answer = "Ink Proof Marker Pen Liner là bút dạ kẻ mắt lâu trôi, nét rõ – tối, chống lem nước/mồ hôi, hợp cho ngày cần ở ngoài lâu."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "foundation brush fmgt", "cọ nền the face shop", "foundation brush" },
                Answer = "Cọ nền Foundation Brush lông mềm – dày, tán nền mịn và đều, hạn chế vệt cọ – rất tiện cho kem nền hoặc cushion."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "makeup sponge 20 piece", "bông trang điểm the face shop", "bông mút trang điểm" },
                Answer = "Bông mút trang điểm giúp tán nền/bb/cushion nhanh, cho lớp nền mỏng mịn; nên vỗ nhẹ thay vì kéo để nền đẹp hơn."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "perfume seed body wash", "sữa tắm perfume seed", "body wash perfume seed", "sữa tắm hương nước hoa" },
                Answer = "Perfume Seed Body Wash là sữa tắm hương nước hoa sang, bọt mịn – sạch da nhưng không khô, lưu hương dịu trên da sau tắm."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "perfume seed lotion", "dưỡng thể perfume seed velvet", "body lotion perfume", "lotion hương nước hoa" },
                Answer = "Perfume Seed Velvet Lotion dưỡng ẩm body mỏng nhẹ, thơm kiểu nước hoa – phù hợp da khô, da xỉn màu cần mềm và thơm lâu."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "avocado body lotion", "dưỡng thể bơ", "lotion avocado", "dưỡng thể bơ avocado" },
                Answer = "Lotion Avocado cấp ẩm sâu cho da body khô, giúp da mịn – đàn hồi hơn nhờ chiết xuất bơ giàu vitamin A, E."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "dr belmeur derma repair shampoo", "shampoo derma repair", "dầu gội dr belmeur nhạy cảm" },
                Answer = "Dr.Belmuer Derma Repair Shampoo là dầu gội dịu nhẹ cho da đầu nhạy cảm, giúp sạch nhưng không khô, giảm ngứa – đỏ da đầu."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "essential hair serum", "serum dưỡng tóc essential", "tinh dầu dưỡng tóc essential" },
                Answer = "Essential Hair Serum phục hồi tóc khô xơ, chẻ ngọn; dùng sau gội hoặc trước sấy giúp tóc mềm, bóng và ít rối."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "essential hair mist", "xịt dưỡng tóc essential", "hair mist bồng bềnh", "hair mist phục hồi" },
                Answer = "Xịt dưỡng tóc Essential giúp tóc bồng nhẹ tự nhiên, giảm xơ rối; rất hợp tóc mỏng, dễ xẹp cần tăng độ phồng & mềm."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "cherry blossom hair mist", "xịt tóc cherry blossom", "hair mist hoa anh đào" },
                Answer = "Hair Mist Cherry Blossom cho tóc thơm mùi hoa anh đào nhẹ nhàng, đồng thời dưỡng tóc mềm và bớt rối khi chải."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "derma repair treatment", "dầu xả dr belmeur derma repair", "dầu xả phục hồi da đầu nhạy cảm" },
                Answer = "Derma Repair Treatment là dầu xả phục hồi tóc yếu, giảm xơ rối, hỗ trợ da đầu nhạy cảm nhờ công thức dịu và nhiều dưỡng."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "she butter hand cream", "kem dưỡng tay shea", "hand cream shea butter" },
                Answer = "Shea Butter Hand Cream dưỡng tay khô/nứt nẻ với bơ hạt mỡ, dùng rất thích mùa lạnh hoặc người hay rửa tay nhiều."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "daily beauty wash cloth", "lưới tắm the face shop", "khăn tắm tạo bọt" },
                Answer = "Lưới tắm/khăn tắm tạo bọt giúp tạo nhiều bọt hơn, làm sạch cơ thể kỹ nhưng vẫn êm da, giúp tiết kiệm sữa tắm."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "shower ball", "bóng tắm shower ball", "bông tắm tròn" },
                Answer = "Shower Ball/Bóng tắm tròn tạo bọt dày, massage nhẹ nhàng, hỗ trợ làm sạch và làm mịn da body tốt hơn so với dùng tay không."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "perfume body mist", "neroli perfume mist", "xit duong the perfume body mist", "xịt thơm body" },
                Answer = "Perfume Body Mist (Neroli, v.v.) là xịt dưỡng thể thơm nhẹ kiểu nước hoa, có dưỡng ẩm nhẹ – phù hợp xịt lại trong ngày cho thơm lâu."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "vegan hand cream", "kem tay thuần chay", "daily vegan hand cream" },
                Answer = "Kem tay thuần chay Daily Hand Cream cấp ẩm tay khô, thấm nhanh – không bết, an toàn cho da nhạy cảm và người thích sản phẩm vegan."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "rich hand foot mask", "mặt nạ tay chân rich", "mask tay chân the face shop" },
                Answer = "Rich Hand & Foot Mask là mask chuyên sâu cho tay/chân, phục hồi da chai – khô, dùng như spa tại nhà 1–2 lần/tuần."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "oil blotting film", "giấy thấm dầu", "blotting film the face shop", "giấy thấm dầu kiềm dầu" },
                Answer = "Giấy thấm dầu The Face Shop hút dầu thừa nhanh mà không làm trôi nền, rất tiện cho da dầu/hỗn hợp khi cần chỉnh lại makeup."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "silky soft facial pad", "bông tẩy trang silky soft", "bông tẩy trang the face shop" },
                Answer = "Bông tẩy trang Silky & Soft dày – êm, không xơ bông, dùng tốt với toner hoặc nước tẩy trang mà không gây xước da."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "giá nước cân bằng yehwadam revitalizing", "nước cân bằng yehwadam revitalizing bao nhiêu", "yehwadam revitalizing toner giá", "nước cân bằng yehwadam giá", "toner yehwadam revitalizing giá bao nhiêu" },
                Answer = "Nước Cân Bằng Yehwadam Revitalizing đang được bán khoảng 3.115.000đ/chai, là dòng toner cao cấp giúp làm sạch sâu, cân bằng pH và cải thiện độ đàn hồi cho da mệt mỏi, khô ráp."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "giá sữa dưỡng dr belmuer clean face mild lotion", "dr belmuer clean face mild lotion bao nhiêu tiền", "sữa dưỡng da dr belmuer giá", "clean face mild lotion giá bao nhiêu", "dr belmuer lotion giá" },
                Answer = "Sữa Dưỡng Da Dr.Belmuer Clean Face Mild Lotion đang có giá khoảng 4.490.000đ, kết cấu lotion nhẹ phù hợp cho da dầu và da nhạy cảm, giúp cân bằng ẩm mà không gây bí tắc lỗ chân lông."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "giá the therapy first serum", "the therapy first serum bao nhiêu", "tinh chất the therapy first serum giá bao nhiêu", "first serum the therapy giá", "serum the therapy giá" },
                Answer = "Tinh Chất Dưỡng The Therapy First Serum có giá khoảng 950.000đ/chai, là bước tinh chất mở đầu giúp dưỡng ẩm sâu và phục hồi da khô ráp, hỗ trợ da hấp thu tốt hơn các sản phẩm sau."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "giá kem dưỡng mắt yehwadam eye cream", "yehwadam eye cream bao nhiêu tiền", "kem mắt yehwadam giá", "yehwadam eye cream giá bao nhiêu", "kem dưỡng mắt yehwadam giá" },
                Answer = "Kem Dưỡng Mắt Yehwadam Eye Cream được bán khoảng 890.000đ, hỗ trợ dưỡng ẩm vùng da mắt, cải thiện độ đàn hồi và giảm tình trạng khô mệt quanh mắt."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "giá sữa rửa mặt herb day 365 aloe", "sữa rửa mặt herb day 365 lô hội giá", "herb day 365 cleansing foam aloe bao nhiêu", "sr m herb day aloe giá bao nhiêu", "herb day aloe giá" },
                Answer = "Sữa Rửa Mặt Herb Day 365 Cleansing Foam Aloe có giá khoảng 230.000đ/tuýp, giúp làm sạch da dịu nhẹ, phù hợp cho nhiều loại da, đặc biệt da khô hoặc nhạy cảm."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "giá tẩy trang rice water bright dạng dầu", "rice water bright cleansing oil giá", "dầu tẩy trang rice water bright bao nhiêu", "rice oil tẩy trang giá bao nhiêu", "giá dầu tẩy trang nước gạo" },
                Answer = "Tẩy Trang Dạng Dầu Rice Water Bright có giá khoảng 450.000đ/chai, làm sạch sâu kem chống nắng và lớp trang điểm mà vẫn giữ độ ẩm tự nhiên cho da."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "giá tẩy tế bào chết smart peeling white jewel", "smart peeling white jewel bao nhiêu", "tẩy tế bào chết white jewel giá", "smart peeling the face shop giá bao nhiêu", "tẩy tế bào chết mặt white jewel giá" },
                Answer = "Tẩy Tế Bào Chết Smart Peeling White Jewel đang được bán khoảng 350.000đ/tuýp, phù hợp cho da xỉn màu, giúp bề mặt da sáng và mịn hơn sau khi sử dụng."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "giá mặt nạ giấy real nature aloe", "real nature aloe mask bao nhiêu", "mặt nạ giấy lô hội the face shop giá", "real nature aloe giá bao nhiêu", "mặt nạ aloe real nature giá" },
                Answer = "Mặt Nạ Giấy Real Nature Aloe có giá khoảng 390.000đ/bộ (tùy số miếng), nổi bật với khả năng cấp ẩm và làm dịu tức thì cho da khô, da nhạy cảm hoặc da cháy nắng."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "giá mặt nạ yehwadam nutrition mask", "yehwadam nutrition mask bao nhiêu", "mặt nạ dưỡng yehwadam giá", "yehwadam mask dưỡng ẩm giá bao nhiêu", "giá mặt nạ yehwadam" },
                Answer = "Mặt Nạ Dưỡng Yehwadam Nutrition Mask được bán khoảng 450.000đ, cung cấp dưỡng chất dồi dào giúp da khỏe, đàn hồi và sáng mịn hơn, phù hợp cho da khô hoặc thiếu ẩm."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "giá phấn nước ink lasting foundation cushion", "ink lasting cushion bao nhiêu tiền", "cushion ink lasting giá", "phấn nước ink lasting giá bao nhiêu", "ink lasting foundation cushion giá" },
                Answer = "Phấn Nước Ink Lasting Foundation Cushion có giá khoảng 780.000đ, cho lớp nền mịn tự nhiên, che phủ tốt và lâu trôi, phù hợp nhiều loại da."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "giá kem nền fmgt ink lasting glow", "fmgt ink lasting glow bao nhiêu", "kem nền ink lasting glow giá", "ink lasting glow foundation giá bao nhiêu", "giá kem nền fmgt glow" },
                Answer = "Kem Nền FMGT Ink Lasting Glow đang có giá khoảng 720.000đ, mang đến lớp nền rạng rỡ, căng bóng nhẹ nhàng, phù hợp da thường đến da khô."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "giá phấn má pastel cushion blusher", "pastel cushion blusher bao nhiêu", "phấn má cushion pastel giá", "cushion blusher the face shop giá bao nhiêu", "giá phấn má pastel" },
                Answer = "Phấn Má Hồng Pastel Cushion Blusher có giá khoảng 350.000đ, cho lớp má hồng mỏng nhẹ, tự nhiên, dễ tán và bám màu tốt suốt nhiều giờ."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "giá son thỏi rouge satin moisture", "rouge satin moisture bao nhiêu tiền", "giá son rouge satin", "son dưỡng ẩm rouge satin moisture giá bao nhiêu", "son thỏi rouge satin the face shop giá" },
                Answer = "Son Thỏi Rouge Satin Moisture có giá khoảng 420.000đ, chất son satin mềm mịn, dưỡng ẩm tốt, lên màu chuẩn và không làm khô môi."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "giá son tint water fit lip tint", "water fit lip tint bao nhiêu", "son tint water fit giá", "water fit tint giá bao nhiêu", "giá son tint water fit" },
                Answer = "Son Tint Water Fit Lip Tint đang được bán khoảng 390.000đ, chất tint lỏng nhẹ, bám màu tốt, mang lại hiệu ứng trong trẻo, tự nhiên phù hợp makeup hằng ngày."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "giá son dưỡng lipcare cream", "lipcare cream bao nhiêu tiền", "son dưỡng môi lipcare giá", "giá son dưỡng lipcare", "lipcare cream the face shop giá bao nhiêu" },
                Answer = "Son dưỡng môi Lipcare Cream có giá khoảng 250.000đ, giúp phục hồi môi khô, nứt nẻ và tạo lớp bảo vệ khóa ẩm hiệu quả."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "giá mascara fmgt designing long lash", "mascara designing long lash bao nhiêu", "mascara long lash the face shop giá", "giá mascara fmgt long lash", "mascara làm dài mi fmgt bao nhiêu" },
                Answer = "Mascara FMGT Designing Long Lash được bán khoảng 420.000đ, giúp làm dài mi, tạo hiệu ứng mi cong tự nhiên, không vón cục và chống lem nhẹ."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "giá kẻ viền mắt ink graffi brush pen liner", "ink graffi brush pen liner bao nhiêu tiền", "bút kẻ mắt ink graffi giá", "giá ink graffi liner", "kẻ mắt ink graffi giá bao nhiêu" },
                Answer = "Kẻ Viền Mắt Ink Graffi Brush Pen Liner có giá khoảng 390.000đ, đầu cọ siêu mảnh, mực đậm, lâu trôi, dễ kẻ nét mỏng tự nhiên hoặc sắc nét cá tính."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "giá sữa tắm perfume seed rich body wash", "perfume seed rich body wash bao nhiêu", "sữa tắm perfume seed giá", "giá sữa tắm perfume seed", "perfume seed body wash giá bao nhiêu" },
                Answer = "Sữa Tắm Perfume Seed Rich Body Wash đang có giá khoảng 390.000đ, tạo bọt mịn, làm sạch mà không khô da, lưu hương thơm sang trọng trên da."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "giá dưỡng thể perfume seed velvet lotion", "perfume seed velvet lotion bao nhiêu", "lotion dưỡng thể perfume seed giá", "giá lotion perfume seed", "dưỡng thể perfume seed giá bao nhiêu" },
                Answer = "Dưỡng Thể Perfume Seed Velvet Lotion có giá khoảng 420.000đ, cấp ẩm cho da cơ thể, giúp da mềm mại và thơm nhẹ nhàng suốt ngày."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "giá tẩy tế bào chết cơ thể smart peeling body", "smart peeling body giá bao nhiêu", "tẩy tế bào chết body the face shop giá", "smart body peeling bao nhiêu tiền", "giá tẩy da chết cơ thể smart peeling" },
                Answer = "Tẩy Tế Bào Chết Cơ Thể Smart Peeling Body được bán khoảng 360.000đ, giúp loại bỏ lớp da chết, làm mịn da và cải thiện vùng da thô ráp."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "giá dầu gội dr belmuer derma repair shampoo", "derma repair shampoo bao nhiêu", "dầu gội dr belmuer giá", "giá dầu gội dr belmuer derma", "shampoo dr belmuer derma repair giá bao nhiêu" },
                Answer = "Dầu Gội Dr.Belmuer Derma Repair Shampoo có giá khoảng 490.000đ, làm sạch dịu nhẹ, phù hợp da đầu nhạy cảm, giúp tóc mềm mại và dễ chải."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "giá dưỡng tóc essential hair serum", "essential hair serum bao nhiêu tiền", "serum dưỡng tóc essential giá", "giá serum tóc essential", "tinh dầu dưỡng tóc essential giá bao nhiêu" },
                Answer = "Dưỡng Tóc Essential Hair Serum đang được bán khoảng 420.000đ/chai, giúp phục hồi tóc khô xơ, hư tổn và tạo lớp màng bảo vệ tóc khỏi tác động nhiệt."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "giá kem dưỡng tay shea butter hand cream", "shea butter hand cream bao nhiêu", "kem dưỡng tay shea butter giá", "giá hand cream shea butter", "kem tay shea butter the face shop giá" },
                Answer = "Kem Dưỡng Tay Shea Butter Hand Cream có giá khoảng 250.000đ/tuýp, cấp ẩm sâu cho da tay khô, nứt nẻ, giúp tay mềm mại hơn."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "giá mặt nạ tay chân rich hand foot mask", "rich hand foot mask bao nhiêu", "mặt nạ tay chân the face shop giá", "mask tay chân rich hand giá bao nhiêu", "giá mặt nạ tay chân dưỡng ẩm" },
                Answer = "Mặt Nạ Tay/Chân Rich Hand & Foot Mask được bán khoảng 390.000đ/bộ, giúp cấp ẩm sâu cho vùng da tay chân thô ráp, chai sần."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "giá sữa rửa mặt yehwadam deep moisturizing", "sữa rửa mặt yehwadam dưỡng ẩm giá bao nhiêu", "yehwadam deep moisturizing cleanser giá", "giá srm yehwadam dưỡng ẩm", "yehwadam sữa rửa mặt giá" },
                Answer = "Sữa Rửa Mặt Yehwadam Dưỡng Ẩm Deep Moisturizing có giá khoảng 699.000đ, làm sạch dịu nhẹ, cấp ẩm sâu và phù hợp cho da khô, da thường hoặc da thiếu nước."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "giá xịt dưỡng tóc essential bồng bềnh phục hồi", "xịt dưỡng tóc essential hair mist giá", "hair mist essential giá bao nhiêu", "xit duong toc essential gia", "giá xịt tóc essential phục hồi" },
                Answer = "Xịt Dưỡng Tóc Essential Làm Bồng Bềnh, Phục Hồi Tóc có giá khoảng 550.000đ, giúp tăng độ phồng, giảm xơ rối và phục hồi tóc hư tổn."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "giá son thỏi new bold semi matte", "new bold semi matte bao nhiêu", "son the face shop new bold giá", "giá son thỏi new bold", "son lì new bold semi matte giá bao nhiêu" },
                Answer = "Son Thỏi THE FACE SHOP New Bold Semi Matte có giá khoảng 459.000đ, chất son lì nhẹ nhưng vẫn mềm môi, bám màu tốt và không gây khô môi."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "giá nước cân bằng yehwadam plum flower", "yehwadam plum flower toner giá", "nước cân bằng yehwadam phục hồi sinh khí giá bao nhiêu", "giá toner yehwadam plum flower", "yehwadam plum flower bao nhiêu" },
                Answer = "Nước Cân Bằng Yehwadam Plum Flower có giá khoảng 999.000đ, giúp phục hồi sinh khí cho da xỉn màu, cải thiện độ đàn hồi và mang lại làn da tươi tắn."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "giá xịt khoáng dr belmuer clarifying soothing mist", "xit khoang dr belmuer mun gia bao nhieu", "clarifying soothing mist giá", "giá xịt khoáng dr belmuer cho da mụn", "xit khoang dr belmuer gia" },
                Answer = "Xịt khoáng Dr.Belmuer Khỏe Da Mụn Clarifying Soothing Mist có giá khoảng 4.690.000đ/chai, cấp ẩm tức thì, làm dịu da dầu mụn và giảm kích ứng, đỏ rát."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "giá tinh chất thuần chay làm đều màu da", "tinh chất thuần chay the face shop giá bao nhiêu", "serum thuần chay làm đều màu da giá", "giá serum vegan brightening the face shop", "tinh chất thuần chay 600000 giá đúng không" },
                Answer = "Tinh Chất Thuần Chay THE FACE SHOP Làm Đều Màu Da có giá khoảng 600.000đ, chứa Niacinamide và chiết xuất thực vật giúp làm dịu, phục hồi hàng rào da và cải thiện tone da đều màu hơn."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "giá sữa dưỡng calendula emulsion", "calendula emulsion the face shop bao nhiêu", "sữa dưỡng calendula giá", "giá sữa dưỡng calendula làm dịu da", "suaduong calendula 4690000" },
                Answer = "Sữa Dưỡng Làm Dịu Da THE FACE SHOP Calendula Emulsion có giá khoảng 4.690.000đ, chuyên làm dịu da nhạy cảm, giảm mẩn đỏ và cấp ẩm bền vững."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "giá kem dưỡng mắt dr belmuer advanced eye cream", "dr belmuer advanced eye cream bao nhiêu", "kem mắt dr belmuer giá", "giá eye cream dr belmuer", "kem dưỡng mắt chống nhăn dr belmuer giá bao nhiêu" },
                Answer = "Kem Dưỡng Mắt Chống Nhăn Dr.Belmuer Advanced Eye Cream đang được bán khoảng 899.000đ, tập trung cải thiện nếp nhăn, quầng thâm và tăng đàn hồi vùng da mắt."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "giá bộ dưỡng yehwadam heaven grade", "yehwadam heaven grade set bao nhiêu", "bộ dưỡng cải thiện nếp nhăn yehwadam giá", "giá set heaven grade yehwadam", "bo duong heaven grade 2099000" },
                Answer = "Bộ Dưỡng Yehwadam Cải Thiện Nếp Nhăn Da Heaven Grade có giá khoảng 2.099.000đ, tập trung cải thiện nếp nhăn sâu, tăng độ săn chắc và phục hồi cấu trúc da."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "giá kem dưỡng dr belmuer total youth biome cream", "total youth biome cream bao nhiêu", "kem dưỡng total youth biome giá", "giá kem dưỡng dr belmuer làm mịn da", "dr belmuer total youth biome cream giá" },
                Answer = "Kem Dưỡng Dr.Belmuer Total Youth Biome Cream được bán khoảng 899.000đ, ứng dụng công nghệ microbiome giúp cân bằng hệ vi sinh da, cải thiện nếp nhăn và tăng đàn hồi."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "giá tẩy trang dạng sáp the face shop", "sap tay trang the face shop gia bao nhieu", "tẩy trang dạng sáp giá", "giá cleansing balm the face shop", "dạng sáp tẩy trang 649000" },
                Answer = "Tẩy Trang Dạng Sáp THE FACE SHOP Làm Sạch Da có giá khoảng 649.000đ, tan chảy thành dầu khi massage, giúp lấy sạch lớp makeup dày nhưng vẫn giữ ẩm cho da."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "giá nước tẩy trang mắt môi the face shop", "nước tẩy trang mắt môi giá bao nhiêu", "eye lip remover the face shop giá", "giá nước tẩy trang mắt & môi", "tay trang mat moi 299000" },
                Answer = "Nước Tẩy Trang Mắt & Môi THE FACE SHOP có giá khoảng 299.000đ, giúp làm sạch son lì và mascara chống nước mà không gây khô hay cay mắt."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "giá tẩy tế bào chết ngọc trai the face shop", "tẩy tế bào chết ngọc trai giá bao nhiêu", "pearl peeling the face shop giá", "giá tẩy tế bào chết ngọc trai 349000", "tẩy tế bào chết mặt ngọc trai giá" },
                Answer = "Tẩy Tế Bào Chết Ngọc Trai THE FACE SHOP có giá khoảng 349.000đ, giúp loại bỏ lớp sừng già, làm sáng da và cải thiện độ mịn khi dùng đều đặn."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "giá lưới tắm daily beauty tools wash cloth", "luoi tam the face shop bao nhieu", "daily beauty tools wash cloth gia", "giá lưới tắm 99000", "phụ kiện lưới tắm the face shop giá" },
                Answer = "Lưới Tắm Daily Beauty Tools Wash Cloth được bán khoảng 99.000đ, giúp tạo bọt nhiều, làm sạch da toàn thân hiệu quả và tiết kiệm sữa tắm."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "giá mặt nạ làm săn chắc da deeply firming mascream", "deeply firming mascream bao nhiêu", "mặt nạ mascream săn chắc giá", "giá mask deeply firming", "mat na lam san chac da 490000" },
                Answer = "Mặt Nạ Làm Săn Chắc Da Deeply Firming Mascream có giá khoảng 490.000đ, dạng kem cô đặc giúp tăng đàn hồi, dưỡng sâu cho làn da chảy xệ hoặc thiếu săn chắc."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "giá mặt nạ mắt real nature rice", "mat na mat gao the face shop gia bao nhieu", "real nature rice eye mask giá", "giá mặt nạ mắt chiết xuất gạo", "mask mat rice 690000" },
                Answer = "Mặt Nạ Mắt THE FACE SHOP Chiết Xuất Gạo Real Nature có giá khoảng 690.000đ (tùy set), hỗ trợ làm sáng vùng quầng thâm, cấp ẩm và làm mịn vùng da dưới mắt."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "giá mặt nạ chân smile foot peeling mask", "smile foot peeling mask bao nhiêu", "mặt nạ tẩy da chết chân giá", "giá smile foot peeling", "mat na chan 199000" },
                Answer = "Mặt Nạ THE FACE SHOP Tẩy Da Chết Chân Smile Foot có giá khoảng 199.000đ, giúp loại bỏ da chết, chai cứng ở bàn chân, trả lại da chân mềm mại hơn."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "giá kem chống nắng chống bụi mịn ánh sáng xanh", "kem chống nắng the face shop chống ánh sáng xanh giá bao nhiêu", "sunscreen chống bụi mịn the face shop giá", "giá kem chống nắng 359000", "kem chống nắng ánh sáng xanh bao nhiêu tiền" },
                Answer = "Kem Chống Nắng Chống Bụi Mịn Ánh Sáng Xanh THE FACE SHOP có giá khoảng 359.000đ, bảo vệ da trước UVA/UVB, ánh sáng xanh và ô nhiễm môi trường, kết cấu mỏng nhẹ không để lại vệt trắng."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "giá sáp chống nắng power long lasting sun stick", "sun stick the face shop giá bao nhiêu", "sáp chống nắng power long lasting giá", "giá sun stick 799000", "sap chong nang the face shop bao nhieu" },
                Answer = "Sáp Chống Nắng THE FACE SHOP Power Long-Lasting Sun Stick được bán khoảng 799.000đ, rất tiện để thoa lại trong ngày, chống nắng mạnh và kiểm soát dầu tốt."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "giá sữa chống nắng the face shop", "sữa chống nắng bảo vệ da khỏe giá bao nhiêu", "sun milk the face shop giá", "giá sữa chống nắng 699000", "sua chong nang the face shop bao nhieu" },
                Answer = "Sữa Chống Nắng THE FACE SHOP Bảo Vệ Da Khỏe có giá khoảng 699.000đ, kết cấu lỏng nhẹ, bảo vệ da khỏi tia UV và hỗ trợ giữ lớp nền lâu trôi."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "giá giấy thấm dầu the face shop oil blotting films", "giay tham dau the face shop bao nhieu", "oil blotting films giá", "giá giấy thấm dầu 129000", "giay tham dau 50 to gia" },
                Answer = "Giấy Thấm Dầu THE FACE SHOP Oil Blotting Films (50 tờ) có giá khoảng 129.000đ, giúp hút dầu thừa nhanh chóng mà không làm ảnh hưởng lớp trang điểm."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "duoi 100k", "dưới 100k", "<100k", "ít tiền quá", "ngân sách ít hơn 100k" },
                Answer = "Với ngân sách dưới 100k, bạn chủ yếu chọn được bông tẩy trang, lưới tắm, giấy thấm dầu hoặc các phụ kiện nhỏ. Mỹ phẩm fullsize thường sẽ cao hơn tầm giá này."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "tầm 50k", "khoảng 50k", "50k thôi", "em chỉ có 50k", "mua gì 50k" },
                Answer = "Khoảng 50k bạn có thể chọn một số phụ kiện nhỏ như lưới tắm, mẫu thử hoặc canh khuyến mãi để mua mặt nạ lẻ. Đa số sản phẩm chăm da sẽ từ 100k trở lên."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "70k mua được gì", "tầm 70k", "70k thoi", "khoảng 70k thôi", "70 ngàn" },
                Answer = "Với ~70k, bạn có thể chọn vài mask lẻ khi có khuyến mãi hoặc phụ kiện nhỏ. Nếu muốn skincare bài bản hơn nên tăng ngân sách lên khoảng từ 150–200k."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "90k", "90.000", "90000", "mua đồ khoảng 90k", "tầm 9 chục" },
                Answer = "Ngân sách khoảng 90k phù hợp để bạn lấy phụ kiện, bông tẩy trang, giấy thấm dầu hoặc mặt nạ giấy khi có ưu đãi. Sản phẩm dưỡng da fullsize thường cao hơn."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "ít hơn 100k", "khoảng dưới 100k", "em chỉ có dưới 100k", "dưới một trăm nghìn", "đồ dưới 100k" },
                Answer = "Dưới 100k bạn nên tập trung vào phụ kiện (bông tẩy trang, giấy thấm dầu, lưới tắm...) hoặc chờ các combo khuyến mãi mask lẻ để tối ưu chi phí."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "100k", "100.000", "100000", "tầm 100k", "khoảng 100k mua gì" },
                Answer = "Khoảng 100k bạn có thể mua được một số mask lẻ, phụ kiện chăm sóc da hoặc sản phẩm travel size. Các dòng sữa rửa mặt, toner thường từ 200k trở lên."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "hơn 100k một chút", "tầm 120k", "khoảng 120k", "120.000", "em có 120k" },
                Answer = "Với ~120k, bạn vẫn chủ yếu chọn phụ kiện, mask, hoặc sản phẩm mini size. Để mua sữa rửa mặt/toner chính hãng nên chuẩn bị từ khoảng 200k trở lên."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "130k", "130.000", "tầm 130k mua gì", "130000", "khoảng 130k" },
                Answer = "Khoảng 130k bạn có thể gom được 1–2 món nhỏ như mask + phụ kiện, hoặc một số sản phẩm mini size. Đồ skincare fullsize thường ở phân khúc cao hơn."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "150k đổ lại", "đến 150k", "tầm 100–150k", "khoảng 150k trở xuống", "150k trở lại" },
                Answer = "Từ 100–150k có thể mua vài mặt nạ, bông tẩy trang và phụ kiện. Muốn mua sữa rửa mặt hoặc tẩy trang chính hãng nên dự trù trên 200k để dễ lựa chọn hơn."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "giới hạn 100k", "giới hạn ngân sách 100k", "budget 100k", "ngân sách tầm 100k thôi", "chỉ có 100k" },
                Answer = "Budget 100k là phân khúc phụ kiện, mask lẻ, mini size. Để skincare đầy đủ hơn (sữa rửa mặt, toner, dưỡng ẩm) bạn nên nâng ngân sách thêm một chút."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "150k", "150.000", "150000", "tầm 150k", "khoảng 150k" },
                Answer = "Với khoảng 150k, bạn có thể chọn combo vài mask giấy + phụ kiện hoặc sản phẩm làm sạch mini size. Sữa rửa mặt fullsize thường khoảng từ 200–300k."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "em có 150k", "150k mua được gì", "mua đồ khoảng 150k", "150k skincare", "đồ dưới 150k" },
                Answer = "150k cho skincare cơ bản hơi hạn chế, bạn có thể ưu tiên mask, phụ kiện và chờ khuyến mãi. Để mua sữa rửa mặt/toner xịn nên chuẩn bị từ 200k trở lên."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "từ 100k đến 150k", "100–150k", "range 100 150k", "khoảng 100 150k", "giá 100k 150k" },
                Answer = "Khoảng 100–150k là tầm giá tốt để lấy mask giấy, phụ kiện chăm da và một số sản phẩm mini. Nếu muốn bắt đầu skincare nghiêm túc, bạn nên nâng lên khoảng 200–300k."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "gần 150k", "hơn 140k", "140k 150k", "tầm hơn 140k", "khoảng 140–150k" },
                Answer = "Tầm ~150k chủ yếu là mask, phụ kiện, mini size. Bạn có thể chờ chương trình sale để săn được sữa rửa mặt hoặc sản phẩm tốt hơn trong tầm giá."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "không quá 150k", "giới hạn 150k", "max 150k", "trên 100k dưới 150k", "chị có 150k" },
                Answer = "Giới hạn 150k phù hợp để mua vài món nhỏ (mask, phụ kiện). Sản phẩm dưỡng da/ làm sạch chất lượng sẽ dễ chọn hơn nếu ngân sách lên từ 200–300k."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "200k", "200.000", "200000", "tầm 200k", "khoảng 200k" },
                Answer = "Khoảng 200k là tầm giá vừa để bạn chọn sữa rửa mặt cơ bản, nước tẩy trang mini hoặc vài mask cao cấp hơn. Đây là mức bắt đầu hợp lý cho skincare cơ bản."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "em có 200k", "200k mua được gì", "skincare 200k", "ngân sách 200k", "200k thôi" },
                Answer = "Với ngân sách 200k, bạn có thể chọn sữa rửa mặt dịu nhẹ, hoặc combo mask + phụ kiện. Nếu muốn thêm toner/dưỡng ẩm, nên nâng ngân sách lên khoảng 300–400k."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "180k 200k", "khoảng 180 đến 200k", "gần 200k", "hơn 180k", "tầm 180k" },
                Answer = "Từ 180–200k là phân khúc sữa rửa mặt/ tẩy trang cơ bản và một số sản phẩm mini. Đây là mức giá ổn để bắt đầu chu trình làm sạch cho da."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "không quá 200k", "dưới 200k", "max 200k thôi", "budget 200k", "giới hạn 200k" },
                Answer = "Dưới 200k bạn có thể chọn một sản phẩm làm sạch tốt hoặc nhiều món nhỏ. Nếu muốn combo đầy đủ (rửa mặt + toner + dưỡng) nên tăng ngân sách để dễ lựa hơn."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "từ 150k đến 200k", "150–200k", "range 150 200k", "giá 150k 200k", "khoảng 150 200k" },
                Answer = "Khoảng 150–200k phù hợp để mua sữa rửa mặt, tẩy da chết mini hoặc vài mask tốt. Đây là phân khúc được nhiều bạn học sinh/sinh viên lựa chọn."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "250k", "250.000", "250000", "tầm 250k", "khoảng 250k" },
                Answer = "Khoảng 250k bạn có thể mua sữa rửa mặt fullsize, tẩy trang cơ bản hoặc một số serum mini. Đây là mức giá khá thoải mái cho bước làm sạch."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "em có 250k", "250k mua được gì shop", "skincare 250k", "budget 250k", "ngân sách 250k" },
                Answer = "Với 250k, bạn chọn được 1 sản phẩm chủ lực như sữa rửa mặt/tẩy trang tốt hoặc combo mask + phụ kiện. Nếu thêm toner/dưỡng, nên tăng ngân sách lên khoảng 400–500k."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "220k 250k", "tầm 220–250k", "gần 250k", "hơn 220k", "khoảng trên 200k dưới 250k" },
                Answer = "Range ~220–250k rất hợp để đầu tư sản phẩm làm sạch chất lượng (sữa rửa mặt/tẩy trang) cho mọi loại da. Đây là bước nền rất quan trọng trong skincare."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "không quá 250k", "max 250k thôi", "giới hạn 250k", "dưới 250k", "khoảng <=250k" },
                Answer = "Dưới 250k bạn có thể chọn được 1 sản phẩm chính khá tốt hoặc nhiều món nhỏ. Nếu ưu tiên da khỏe, nên bắt đầu bằng một sữa rửa mặt hoặc tẩy trang dịu nhẹ."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "150–250k", "từ 150 đến 250k", "range 150-250k", "giá khoảng 150 250k", "skincare giá 150 250" },
                Answer = "Khoảng 150–250k là tầm giá phổ biến cho học sinh–sinh viên: sữa rửa mặt, tẩy da chết dịu, mask giấy và một số sản phẩm mini đều nằm trong phân khúc này."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "300k", "300.000", "300000", "tầm 300k", "khoảng 300k" },
                Answer = "Với khoảng 300k, bạn đã thoải mái hơn để chọn sữa rửa mặt, toner cơ bản hoặc kem chống nắng mini. Đây là mức giá tốt để bắt đầu một routine đơn giản."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "em có 300k", "300k mua được gì", "budget 300k", "skincare 300k", "ngân sách 300k thôi" },
                Answer = "Ngân sách 300k cho phép bạn mua 1 sản phẩm chính (rửa mặt/toner) + thêm mask/phụ kiện nếu săn thêm khuyến mãi. Đây là tầm giá hợp lý cho routine tối giản."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "250k đến 300k", "250–300k", "khoảng 250 300k", "gần 300k", "trên 250k dưới 300k" },
                Answer = "Từ 250–300k là phân khúc bạn có thể chọn sữa rửa mặt tốt, tẩy da chết dịu hoặc toner cơ bản cho mọi loại da, phù hợp người mới bắt đầu skincare."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "không quá 300k", "max 300k", "dưới 300k", "<=300k", "giới hạn 300k" },
                Answer = "Dưới 300k bạn dễ dàng chọn 1–2 sản phẩm cơ bản (rửa mặt + mask, hoặc tẩy trang + phụ kiện). Nếu muốn thêm serum, ngân sách nên lên từ 400–500k."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "khoảng 280k", "280k", "280.000", "gần 300k thôi", "tầm 280k" },
                Answer = "Khoảng 280–300k là đủ để bạn chọn một sản phẩm làm sạch hoặc toner chất lượng cho da thường, da dầu hoặc da khô tùy nhu cầu."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "400k", "400.000", "400000", "tầm 400k", "khoảng 400k" },
                Answer = "Khoảng 400k cho phép bạn mua sữa rửa mặt + thêm mask, hoặc một chai toner/dưỡng ẩm ở phân khúc trung bình. Routine bắt đầu đầy đủ hơn."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "em có 400k", "ngân sách 400k", "400k mua được gì", "skincare 400k", "budget 400k" },
                Answer = "Với 400k, bạn có thể xây dựng combo 2 sản phẩm cơ bản (rửa mặt + mask, hoặc rửa mặt + toner mini). Đây là tầm giá đẹp cho người mới bắt đầu chăm da."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "350k đến 400k", "350–400k", "range 350-400k", "khoảng 350 400k", "trên 350k dưới 400k" },
                Answer = "Trong tầm 350–400k, bạn đã có nhiều lựa chọn: sữa rửa mặt tốt, toner nhẹ nhàng cho da nhạy cảm và một vài sản phẩm hỗ trợ như mask/tẩy da chết dịu."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "không quá 400k", "max 400k", "dưới 400k", "<=400k thôi", "giới hạn 400k" },
                Answer = "Dưới 400k bạn có thể có 1–2 món chất lượng khá trong routine, ưu tiên làm sạch và cấp ẩm cơ bản. Serum chuyên sâu thường bắt đầu ở tầm giá cao hơn."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "380k", "380.000", "tầm 380k", "khoảng 380k", "gần 400k" },
                Answer = "Khoảng 380–400k là đủ cho 1 chai sữa rửa mặt/toner chất lượng + thêm mask/phụ kiện khi canh được chương trình ưu đãi."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "500k", "500.000", "500000", "tầm 500k", "khoảng 500k" },
                Answer = "Khoảng 500k là ngân sách rất ổn cho 1–2 sản phẩm tốt: ví dụ sữa rửa mặt + kem chống nắng mini, hoặc toner + mask. Routine sẽ cân bằng hơn."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "em có 500k", "500k mua được gì", "budget 500k", "skincare 500k", "ngân sách 500k" },
                Answer = "Với 500k, bạn có thể xây dựng combo: sữa rửa mặt + mask, hoặc toner + tẩy trang, hoặc đầu tư một chai serum cơ bản nếu săn được khuyến mãi."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "450k đến 500k", "450–500k", "range 450 500k", "khoảng 450 500k", "trên 450k dưới 500k" },
                Answer = "Từ 450–500k, bạn có thể nhắm tới các dòng dưỡng ẩm, toner hoặc serum cấp ẩm/ làm sáng cơ bản. Đây là tầm giá phù hợp cho routine 2–3 bước."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "không quá 500k", "max 500k", "dưới 500k thôi", "<=500k", "giới hạn 500k" },
                Answer = "Dưới 500k, bạn xây dựng được routine tối giản: rửa mặt + dưỡng ẩm hoặc rửa mặt + chống nắng. Nếu muốn thêm serum, có thể cần săn sale để tối ưu chi phí."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "470k", "470.000", "khoảng 470k", "tầm 470k", "gần 500k" },
                Answer = "Khoảng 470–500k cho phép bạn chọn 1 sản phẩm chủ lực (serum/kem dưỡng) của dòng trung cấp hoặc combo làm sạch + mask tùy nhu cầu da."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "600k", "600.000", "600000", "tầm 600k", "khoảng 600k" },
                Answer = "Ngân sách 600k đủ để bạn mua 1 serum hoặc kem dưỡng tầm trung + thêm mask/phụ kiện. Nếu biết rõ tình trạng da, chọn serum/dưỡng đúng nhu cầu sẽ rất hiệu quả."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "700k", "700.000", "700000", "tầm 700k", "khoảng 700k" },
                Answer = "Khoảng 700k phù hợp để chọn một serum/kem dưỡng chất lượng hoặc combo 2–3 món (rửa mặt + toner + mask) tùy cách bạn chia ngân sách."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "600–700k", "600k đến 700k", "range 600 700k", "khoảng 600 700k", "trên 600k dưới 700k" },
                Answer = "Từ 600–700k, bạn có thể xây routine nho nhỏ 2–3 bước: rửa mặt + toner + dưỡng nhẹ, hoặc đầu tư một sản phẩm treatment (serum) cho vấn đề da cụ thể."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "không quá 700k", "max 700k", "dưới 700k", "<=700k", "ngân sách dưới 700k" },
                Answer = "Dưới 700k, bạn đã có thể vừa làm sạch, vừa dưỡng ẩm cơ bản và có thêm 1 sản phẩm chuyên sâu nhẹ. Đây là tầm giá đẹp cho routine chuẩn chỉnh hằng ngày."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "650k", "650.000", "tầm 650k", "khoảng 650k", "gần 700k" },
                Answer = "Khoảng 650k cho phép bạn chọn 1 serum ngon + 1 sản phẩm làm sạch, hoặc 3 món basic giá vừa phải. Nếu bạn chia ngân sách khéo, routine sẽ rất ổn áp."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "800k", "800.000", "800000", "tầm 800k", "khoảng 800k" },
                Answer = "Khoảng 800k đủ để bạn mua combo làm sạch + dưỡng ẩm + mask, hoặc một serum cao cấp hơn. Đây là tầm giá phù hợp cho da bắt đầu cần chống lão hóa nhẹ."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "900k", "900.000", "900000", "tầm 900k", "khoảng 900k" },
                Answer = "Với ~900k, bạn có thể đầu tư 1 serum chuyên sâu (làm sáng, phục hồi, chống lão hóa nhẹ) và vẫn còn dư một ít cho sản phẩm làm sạch/dưỡng cơ bản."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "800–900k", "800k đến 900k", "range 800 900k", "khoảng 800 900k", "trên 800k dưới 900k" },
                Answer = "Trong tầm 800–900k, routine của bạn đã khá đầy đủ: rửa mặt, toner, dưỡng ẩm và có thêm 1 sản phẩm treatment nhỏ. Da sẽ cải thiện rõ nếu dùng đều."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "không quá 900k", "max 900k", "dưới 900k", "<=900k", "ngân sách dưới 900k" },
                Answer = "Dưới 900k, bạn có thể vừa sắm basic care (rửa mặt + toner + dưỡng) vừa có thêm serum nhẹ hoặc mask tốt. Đây là phân khúc tối ưu giữa chất lượng và chi phí."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "850k", "850.000", "tầm 850k", "khoảng 850k", "gần 900k" },
                Answer = "Khoảng 850k cho phép bạn chọn 1 combo dưỡng tương đối đầy đủ cho một vấn đề da cụ thể (dầu mụn, khô, xỉn màu...) tùy sản phẩm bạn phân chia."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "1 triệu", "mot trieu", "1tr", "1.000.000", "1000000" },
                Answer = "Ngân sách khoảng 1 triệu cho phép bạn đầu tư một bộ skincare cơ bản 3–4 bước hoặc một serum/bộ dưỡng cao cấp hơn. Đây là tầm giá rất tốt cho chăm da nghiêm túc."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "tầm 1 triệu", "khoảng 1 triệu", "budget 1 triệu", "em có 1 triệu", "ngân sách 1tr" },
                Answer = "Tầm 1 triệu, bạn có thể chọn combo trọn bộ: rửa mặt + toner + dưỡng + mask, hoặc một set chống lão hóa/ làm sáng chuyên sâu hơn tùy nhu cầu da."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "không quá 1 triệu", "dưới 1 triệu", "<=1 triệu", "max 1 triệu", "giới hạn 1 triệu" },
                Answer = "Dưới 1 triệu bạn vẫn xây được routine rất ổn: làm sạch, dưỡng ẩm, chống nắng và có một sản phẩm treatment cơ bản (như serum cấp ẩm/giảm thâm)."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "900k đến 1 triệu", "900–1000k", "khoảng 900k 1 triệu", "range 900 1000k", "gần 1 triệu" },
                Answer = "Từ 900k đến 1 triệu là phân khúc lý tưởng để vừa skincare cơ bản, vừa có sản phẩm chuyên sâu hơn như serum làm sáng hoặc chống lão hóa nhẹ."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "1tr1 trở xuống", "1.1 triệu đổ lại", "khoảng 1tr đổ lại", "gần 1tr1", "dưới 1tr1" },
                Answer = "Dưới khoảng 1tr1 bạn đã có rất nhiều lựa chọn bộ dưỡng, combo chăm da bài bản. Chỉ cần xác định da dầu/khô/nhạy cảm để chọn set phù hợp."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "1tr2", "1.2 triệu", "1200000", "khoảng 1tr2", "tầm 1tr2" },
                Answer = "Khoảng 1tr2 cho phép bạn mua bộ dưỡng cao cấp hơn (toner + emulsion/cream) hoặc một serum treatment mạnh cho nám, xỉn màu, lão hóa nhẹ."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "1tr3", "1.3 triệu", "1300000", "tầm 1tr3", "khoảng 1tr3" },
                Answer = "Tầm 1tr3 bạn có thể đầu tư một combo dưỡng chuyên sâu (bộ chống lão hóa/Phục hồi) hoặc kết hợp nhiều sản phẩm cho cả sáng – tối."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "1tr5", "1.5 triệu", "1500000", "tầm 1tr5", "khoảng 1tr5" },
                Answer = "Khoảng 1tr5 phù hợp để mua một bộ sản phẩm cao cấp (ví dụ set Yehwadam, Dr.Belmuer) dùng lâu dài. Đây là phân khúc hướng đến hiệu quả rõ rệt hơn."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "1.2–1.5 triệu", "1200k 1500k", "khoảng 1tr2 đến 1tr5", "range 1.2 1.5tr", "trên 1tr2 dưới 1tr5" },
                Answer = "Tầm 1.2–1.5tr là phân khúc set dưỡng cao cấp: tập trung vào chống lão hóa, phục hồi, sáng da rõ rệt hơn so với dòng cơ bản."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "dưới 1tr5", "không quá 1.5 triệu", "max 1tr5", "<=1tr5", "ngân sách dưới 1tr5" },
                Answer = "Dưới 1tr5 bạn có thể chọn được một bộ dưỡng cao cấp size lớn dùng vài tháng, rất phù hợp khi muốn chăm da nghiêm túc và ổn định lâu dài."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "2tr", "2 triệu", "2000000", "tầm 2 triệu", "khoảng 2tr" },
                Answer = "Khoảng 2 triệu là phân khúc bộ dưỡng cao cấp, thường gồm nhiều bước (toner, emulsion, cream, eye cream mini…). Thích hợp cho da bắt đầu lão hóa hoặc cần phục hồi mạnh."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "1tr5 đến 2tr", "1.5–2 triệu", "khoảng 1tr5 2tr", "range 1.5 2tr", "trên 1tr5 dưới 2tr" },
                Answer = "Từ 1.5–2tr bạn có thể lựa chọn nhiều set dưỡng chuyên sâu: chống nhăn, nâng cơ, làm sáng rõ nét hơn so với các dòng basic tầm trung."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "dưới 2tr", "không quá 2tr", "max 2 triệu", "<=2tr", "ngân sách dưới 2tr" },
                Answer = "Dưới 2tr bạn đã có thể mua hầu hết các bộ dưỡng cao cấp của brand, dùng được dài ngày. Chỉ cần chọn đúng dòng theo vấn đề da (nám, nhăn, khô, nhạy cảm...)."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "2tr1 đổ lại", "tầm 2tr trở xuống", "gần 2tr", "quanh 2tr", "cỡ 2tr" },
                Answer = "Quanh 2tr là tầm giá lý tưởng nếu bạn muốn đầu tư mạnh một lần cho cả routine: vừa dưỡng, vừa chống lão hóa, cải thiện độ đàn hồi và sáng da."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "2tr mua được những gì", "skincare với 2tr", "ngân sách 2tr mua bộ gì", "2tr nên mua set nào", "2tr nên chọn sản phẩm gì" },
                Answer = "Với 2tr, bạn nên ưu tiên một bộ dưỡng cao cấp theo nhu cầu da (chống nhăn, phục hồi, dưỡng trắng...). Các set này thường dùng được vài tháng, tính ra rất kinh tế."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "3tr", "3 triệu", "3000000", "tầm 3tr", "khoảng 3 triệu" },
                Answer = "Ngân sách 3tr phù hợp với set dưỡng rất cao cấp (ví dụ các dòng chống lão hóa mạnh), thường đi kèm nhiều sản phẩm trong cùng bộ."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "dưới 3tr", "không quá 3tr", "max 3 triệu", "<=3tr", "ngân sách dưới 3tr" },
                Answer = "Dưới 3tr là phân khúc bạn gần như có thể chọn bất kỳ bộ dưỡng cao cấp nào của hãng, chỉ cần chọn đúng dòng theo loại da và độ tuổi."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "2tr đến 3tr", "2–3tr", "khoảng 2 3 triệu", "range 2 3tr", "trên 2tr dưới 3tr" },
                Answer = "Từ 2–3tr là phân khúc set dưỡng full size đầy đủ bước, phù hợp làm quà tặng hoặc bạn dùng lâu dài, tập trung mạnh vào phục hồi, chống lão hóa, nâng tông da."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "3tr đổ lại", "gần 3tr", "khoảng 2tr8 3tr", "2.8 triệu", "2800000" },
                Answer = "Khoảng 2.8–3tr bạn có thể chọn những dòng cao cấp nhất của brand, nhắm đến hiệu quả lâu dài cho da trưởng thành, da có nếp nhăn hoặc nám nhẹ."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "budget 3tr", "em có 3tr", "3tr skincare", "3tr mua bộ gì", "ngân sách 3tr nên mua gì" },
                Answer = "Với 3tr, giải pháp tốt nhất là chọn trọn bộ cao cấp theo nhu cầu da. Bạn sẽ có routine chuẩn nhiều bước, dùng bền và hiệu quả rõ rệt nếu kiên trì."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "4tr", "4 triệu", "khoảng 4tr", "tầm 4 triệu", "4000000" },
                Answer = "Khoảng 4tr phù hợp với các set dưỡng rất cao cấp hoặc kết hợp nhiều sản phẩm riêng lẻ (mụn + nám + dưỡng ẩm + mắt) cho da đang gặp nhiều vấn đề cùng lúc."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "5tr", "5 triệu", "5000000", "tầm 5tr", "khoảng 5tr" },
                Answer = "Ngân sách 5tr cho phép bạn vừa mua set dưỡng cao cấp, vừa bổ sung thêm serum chuyên sâu cho vấn đề riêng như nám, sẹo thâm, lão hóa mạnh."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "4–5tr", "4tr đến 5tr", "khoảng 4 5 triệu", "range 4 5tr", "trên 4tr dưới 5tr" },
                Answer = "Từ 4–5tr là phân khúc dành cho routine cực kỳ chỉnh chu cho da trưởng thành, da có nhiều vấn đề (nám, nhăn, chảy xệ). Lúc này trọng tâm là bộ dưỡng cao cấp."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "dưới 5tr", "không quá 5tr", "max 5tr", "<=5tr", "ngân sách dưới 5tr" },
                Answer = "Dưới 5tr bạn hoàn toàn có thể xây một lộ trình chăm da dài hạn với các dòng cao cấp nhất: vừa dưỡng, vừa đặc trị và chống lão hóa tổng thể."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "4tr rưỡi", "4.5tr", "4500000", "khoảng 4tr5", "tầm 4tr5" },
                Answer = "Khoảng 4tr5 là tầm giá đẹp để sở hữu 1–2 set cao cấp + vài sản phẩm bổ sung. Phù hợp cho người muốn đầu tư mạnh cho làn da trong thời gian dài."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "trên 5tr", "hơn 5tr", ">5tr", "ngân sách lớn hơn 5tr", "budget trên 5tr" },
                Answer = "Trên 5tr là tầm đầu tư rất mạnh: bạn có thể xây combo dài hạn, đủ toàn bộ bước từ làm sạch, dưỡng, đặc trị, mắt, body… dùng trong nhiều tháng."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "10tr", "10 triệu", "10000000", "tầm 10tr", "ngân sách 10tr" },
                Answer = "Ngân sách 10tr thường phù hợp khi bạn muốn mua trọn bộ cao cấp + dự trữ nhiều tháng, hoặc mua cho cả bản thân và người thân cùng dùng."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "5–10tr", "5tr đến 10tr", "range 5 10tr", "khoảng 5 10 triệu", "trên 5tr dưới 10tr" },
                Answer = "Từ 5–10tr bạn có thể lập hẳn một plan chăm da lâu dài với nhiều set cao cấp, vừa dưỡng, vừa đặc trị từng vấn đề như nám, nhăn, khô, nhạy cảm."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "dưới 10tr", "không quá 10tr", "max 10tr", "<=10tr", "ngân sách dưới 10tr" },
                Answer = "Dưới 10tr gần như bạn không bị giới hạn về lựa chọn set dưỡng. Quan trọng là xác định mục tiêu da (trị nám, chống lão hóa, phục hồi sau treatment…) để chọn đúng dòng."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "ngân sách lớn", "budget thoải mái", "chi nhiều cũng được", "không giới hạn tiền", "có thể chi khá nhiều" },
                Answer = "Nếu ngân sách thoải mái, thay vì mua dàn trải rất nhiều món, bạn nên tập trung vào vài dòng cao cấp phù hợp đúng tình trạng da và dùng đều đặn, hiệu quả sẽ tối ưu hơn."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "tầm giá bình dân", "giá bình dân thôi", "cần đồ rẻ", "đồ giá mềm", "tầm rẻ rẻ" },
                Answer = "Đồ bình dân mình gợi ý các sản phẩm từ ~200–300k: sữa rửa mặt, mask, một số toner/kem nhẹ nhàng. Vẫn đủ sạch – dưỡng cơ bản nhưng không quá áp lực chi phí."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "tầm giá trung bình", "giá trung bình", "phân khúc trung bình", "tầm mid", "tầm vừa vừa" },
                Answer = "Phân khúc trung bình thường từ ~300–700k/sản phẩm, chất lượng tốt, thành phần ổn, phù hợp đa số nhu cầu da và dễ duy trì lâu dài."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "tầm giá cao cấp", "giá cao cấp", "phân khúc cao", "hàng cao cấp", "muốn dưỡng xịn" },
                Answer = "Dòng cao cấp thường từ ~800k trở lên mỗi sản phẩm hoặc set 1–3tr, tập trung mạnh vào chống lão hóa, phục hồi và cảm giác dùng rất đã trên da."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "tầm giá học sinh", "sinh viên", "giá học sinh", "budget sinh viên", "rẻ cho sinh viên" },
                Answer = "Học sinh–sinh viên thường nên bắt đầu từ 200–400k: sữa rửa mặt + chống nắng/kem dưỡng nhẹ. Nếu có thể thêm mask hoặc tẩy da chết dịu là rất ổn."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "giá khoảng bao nhiêu", "thường giá tầm nào", "tầm giá nào hợp lý", "tầm giá ok", "giá khoảng nào là ổn" },
                Answer = "Tầm giá hợp lý nhất thường từ 300–700k/sản phẩm: đủ chất lượng, an toàn, hiệu quả, mà vẫn dễ duy trì lâu dài. Tùy da và nhu cầu mình sẽ gợi ý cụ thể hơn."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "rẻ nhất là bao nhiêu", "sản phẩm rẻ nhất", "món nào rẻ nhất", "giá thấp nhất", "min price" },
                Answer = "Sản phẩm rẻ nhất thường là phụ kiện, mask lẻ hoặc mini size, khoảng dưới 100–150k. Nếu muốn skincare cơ bản, bạn nên chuẩn bị thêm chút ngân sách."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "đắt nhất là bao nhiêu", "sản phẩm đắt nhất", "món nào mắc nhất", "giá cao nhất", "max price" },
                Answer = "Những bộ cao cấp full size có thể lên đến vài triệu/set, đổi lại là thành phần xịn, thiết kế sang và tập trung mạnh vào chống lão hóa, phục hồi sâu cho da."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "giá tầm tầm", "không quá rẻ cũng không quá đắt", "giá vừa phải", "tầm trung thôi", "đừng đắt quá" },
                Answer = "Nếu muốn vừa phải, bạn có thể chọn phân khúc 300–500k/sản phẩm: chất lượng ổn áp, an toàn cho da và không quá nặng ví."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "đừng rẻ quá", "miễn đừng rẻ", "sợ hàng rẻ", "muốn hàng tầm khá", "ghét đồ siêu rẻ" },
                Answer = "Bạn có thể nhắm tầm 400–800k/sản phẩm, đây là phân khúc có thành phần khá ổn, thương hiệu uy tín và trải nghiệm dùng tốt hơn rõ rệt so với dòng quá rẻ."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "muốn hàng tốt giá ok", "chất lượng nhưng giá ổn", "ngon bổ rẻ", "đừng quá chát", "xịn nhưng không quá mắc" },
                Answer = "Combo ngon–bổ–hợp lý thường nằm ở tầm 300–700k/sản phẩm. Mình có thể gợi ý các lựa chọn phù hợp da mà vẫn giữ chi phí dễ chịu cho bạn."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "em chưa biết nên chi bao nhiêu", "không biết budget", "không rõ giá nên thế nào", "chưa nghĩ ra nên chi tầm nào", "hỏi trước giá" },
                Answer = "Nếu chưa rõ ngân sách, bạn có thể bắt đầu từ routine đơn giản 300–500k. Khi thấy hợp và da cải thiện, mình nâng dần sản phẩm treatment sau cũng được."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "tùy shop tư vấn giá", "shop tư vấn tầm giá luôn", "tuỳ shop set giá", "shop đề xuất giá", "gợi ý giúp tầm giá" },
                Answer = "Tùy tình trạng da, mình thường chia 3 mức: ~300–500k (cơ bản), 500–1tr (full routine cơ bản) và >1tr (dưỡng cao cấp hơn). Bạn chia sẻ thêm loại da để mình đề xuất chính xác."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "tầm nào là đủ", "chi bao nhiêu là đủ", "bao nhiêu là hợp lý", "chi ít nhất bao nhiêu", "mức tối thiểu" },
                Answer = "Để skincare tương đối đầy đủ, bạn nên có tối thiểu một budget khoảng 400–700k: đủ mua rửa mặt, dưỡng ẩm cơ bản và có thể thêm mask/ chống nắng tùy ưu tiên."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "tối đa bao nhiêu là ổn", "đừng quá tay", "đừng over budget", "sợ tốn tiền quá", "muốn tiết kiệm" },
                Answer = "Nếu muốn tiết kiệm nhưng vẫn hiệu quả, bạn có thể đặt trần khoảng 700k: ưu tiên chọn đúng vài món quan trọng thay vì mua quá nhiều sản phẩm rời rạc."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "giảm chi phí giúp với", "muốn tối ưu chi phí", "giảm budget", "tối giản chi phí skincare", "cho routine rẻ nhất nhưng ổn" },
                Answer = "Để tối ưu chi phí, bạn tập trung vào 3 bước: rửa mặt, dưỡng ẩm, chống nắng. Tầm 300–600k là đã có thể build một routine tối giản nhưng đủ khỏe da."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "thêm tí cũng được", "budget linh động", "có thể nhích thêm chút", "có thể tăng ngân sách một chút", "co giãn giá được" },
                Answer = "Nếu ngân sách linh động, mình sẽ ưu tiên chọn sản phẩm cốt lõi trước (rửa mặt + dưỡng + chống nắng), sau đó thêm serum/ mask tuỳ số tiền bạn sẵn sàng nhích lên."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "em chỉ muốn test thử", "mới dùng thử thôi", "muốn dùng thử giá nhẹ", "test da trước", "dùng chơi chơi" },
                Answer = "Nếu chỉ muốn dùng thử, bạn có thể bắt đầu ở phân khúc 200–400k với những sản phẩm dịu nhẹ, an toàn. Khi thấy hợp da, mình mới nâng dần dòng cao hơn."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "chăm da nghiêm túc", "muốn đầu tư nghiêm túc", "đầu tư skincare hẳn hoi", "chơi lớn chăm da", "muốn cải thiện da rõ rệt" },
                Answer = "Nếu muốn chăm da nghiêm túc, bạn nên chuẩn bị khoảng 800k–2tr cho bộ sản phẩm đầy đủ hơn. Đây là khoảng mà hiệu quả và trải nghiệm sẽ khác biệt rõ."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "giá sao cho hợp thu nhập", "đi làm lương trung bình", "giá hợp dân văn phòng", "phù hợp lương tầm trung", "chi vừa phải hàng tháng" },
                Answer = "Với mức thu nhập trung bình, bạn có thể chọn routine tầm 500–1tr cho 1–2 tháng dùng. Chia nhỏ ra mỗi tháng chi không quá nhiều mà da vẫn được chăm đầy đủ."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "muốn hỏi giá trước rồi tính", "hỏi giá chung trước", "báo giá trước đi", "cho em biết khung giá", "tư vấn theo khung giá" },
                Answer = "Về khung giá chung: phụ kiện/mask ~50–200k; sữa rửa mặt/toner basic ~200–400k; dưỡng/serum tầm trung ~400–800k; set cao cấp thường từ 1–3tr. Bạn chỉ cần chọn khung mình thấy thoải mái, mình sẽ gợi ý cụ thể theo da."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "giao hàng", "ship", "vận chuyển", "freeship", "giao" },
                Answer = "Shop giao nhanh 1-2 ngày tại TP.HCM, 2-4 ngày ở tỉnh. Đơn từ 500.000đ được freeship nội địa; dưới ngưỡng sẽ tính phí theo đơn vị vận chuyển."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "đổi trả", "hoàn", "trả hàng", "bảo hành" },
                Answer = "Bạn được đổi trả trong 7 ngày nếu sản phẩm còn nguyên tem/bao bì và có lỗi từ nhà sản xuất. Liên hệ hotline 1800 2097 hoặc inbox fanpage để được hướng dẫn."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "dầu", "mụn", "oil", "acne" },
                Answer = "Da dầu mụn nên ưu tiên sữa rửa mặt Jeju Volcanic Lava, toner Dr.Belmeur Clarifying, serum Trị Mụn Clean Face và kem chống nắng Oil Control."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "nhạy cảm", "kích ứng", "sensitive" },
                Answer = "Da nhạy cảm hãy chọn dòng Dr.Belmeur (Amino Clear/Sensitive) thành phần dịu nhẹ, không cồn, không paraben; patch test trước khi dùng toàn mặt."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "combo", "routine", "sáng", "tối", "quy trình" },
                Answer = "Routine gợi ý: Sáng: SRM dịu nhẹ → Toner cấp ẩm → Serum Vitamin C nhẹ → Kem dưỡng mỏng → Chống nắng SPF50+. Tối: Tẩy trang → SRM → Toner → Serum treatment (BHA/Retinol luân phiên) → Kem dưỡng phục hồi."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "khuyến mãi", "sale", "ưu đãi", "voucher" },
                Answer = "Hiện có Flash Sale cuối tuần, giảm 20-40% nhiều dòng dưỡng da, mua 1 tặng 1 sheet mask và freeship đơn 500k. Bạn cho mình danh mục quan tâm để gửi link nhé!"
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "son", "lip", "kem lì", "màu" },
                Answer = "Son kem Ink Lasting hoặc Rouge Satin có bảng màu MLBB hot: 01 Rose Wood, 05 Brick Brown, 08 Coral Latte. Chất son mỏng nhẹ, không khô môi nếu tẩy tế bào chết + dưỡng môi trước."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "chính hãng", "auth", "kiểm tra", "qr", "tem" },
                Answer = "Tất cả sản phẩm có tem chống giả, mã vạch/QR rõ ràng, hóa đơn VAT theo yêu cầu. Bạn có thể quét mã trên bao bì hoặc liên hệ hotline để được xác thực."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "quốc tế", "nước ngoài", "ship quốc tế", "international" },
                Answer = "Hiện shop giao nội địa Việt Nam. Nếu cần gửi ra nước ngoài, bạn có thể nhờ đơn vị vận chuyển quốc tế nhận hàng tại Việt Nam."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "quà", "tặng", "gift", "sinh nhật" },
                Answer = "Gợi ý quà: bộ dưỡng da Green Tea cho da dầu, Yehwadam hoa mẫu đơn cho da cần chống lão hóa, set son + mascara Ink Lasting cho makeup. Mình có thể gói quà miễn phí và kèm thiệp."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "thành viên", "tích điểm", "điểm", "membership" },
                Answer = "Tài khoản thành viên tích 3-7% giá trị đơn, nâng hạng Bạc/Vàng/Platinum theo doanh số năm. Điểm đổi được voucher, freeship và quà sinh nhật."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "chống nắng", "spf", "kem chống nắng" },
                Answer = "Da dầu: chọn Natural Sun Eco No Shine SPF50. Da khô/nhạy cảm: Power Long-Lasting Tone Up hoặc dòng không cồn Dr.Belmeur. Thoa lại sau 2-3 giờ khi hoạt động ngoài trời."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "giá", "bao nhiêu", "nhiêu tiền", "cost", "price" },
                Answer = "Giá sản phẩm phụ thuộc dòng dưỡng/loại makeup bạn chọn. Bạn gửi tên sản phẩm mình check giá chính xác và đang có khuyến mãi giúp bạn nhé!"
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "hạn sử dụng", "date", "hạn", "exp" },
                Answer = "Hầu hết sản phẩm đều date mới 2–3 năm, hàng nhập khẩu chính hãng từ Hàn. Bạn có thể yêu cầu shop chụp date trước khi chốt đơn."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "bị kích ứng", "đỏ", "rát", "nhạy cảm sau dùng" },
                Answer = "Nếu da bị đỏ/kích ứng, bạn hãy tạm ngưng sản phẩm, chườm lạnh nhẹ và ưu tiên kem phục hồi Dr.Belmeur. Gửi mình tình trạng da để tư vấn kỹ hơn nhé!"
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "retinol", "tret", "treatment mạnh" },
                Answer = "Retinol nên dùng buổi tối 2–3 lần/tuần, tránh kết hợp AHA/BHA cùng ngày. Bắt đầu với nồng độ thấp như Dr.Belmeur Retinol Serum để hạn chế kích ứng."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "b5", "phục hồi", "làm dịu" },
                Answer = "Kem dưỡng B5 Dr.Belmeur phục hồi cực tốt sau treatment/viêm đỏ, chất kem thấm nhanh, không bí da. Phù hợp mọi loại da, kể cả da mỏng yếu."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "mụn ẩn", "mụn li ti", "đầu đen" },
                Answer = "Bạn nên dùng tẩy da chết BHA 0.5–1%, kết hợp SRM kiềm dầu và toner làm sạch sâu. Dòng Dr.Belmeur Clarifying phù hợp da mụn ẩn."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "mở nắp", "sau mở", "PAO", "dùng bao lâu" },
                Answer = "Sau khi mở nắp, mỹ phẩm thường dùng tốt trong 6–12 tháng tùy loại (theo ký hiệu PAO trên hộp). Bảo quản nơi khô ráo, tránh nắng trực tiếp."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "mặt nạ", "mask", "sheet", "đắp mặt" },
                Answer = "Mặt nạ Real Nature/Jeju mang lại hiệu quả cấp ẩm, sáng da tức thì. Nên đắp 2–3 lần/tuần, không rửa lại bằng sữa rửa mặt sau khi đắp."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "dưỡng trắng", "sáng da", "nám", "thâm" },
                Answer = "Dòng dưỡng trắng Rice Water/White Seed giúp làm sáng đều màu, hỗ trợ mờ thâm. Với nám lâu năm nên kết hợp Vitamin C + chống nắng đều."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "vitamin c", "serum c", "trắng da" },
                Answer = "Serum Vitamin C The Face Shop dạng nhẹ, ít gây châm chích, giúp sáng da và mờ thâm sau 2–4 tuần. Nên dùng buổi sáng kết hợp kem chống nắng."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "aha", "bha", "tẩy da chết" },
                Answer = "AHA làm sáng da, BHA thấm lỗ chân lông giảm mụn ẩn. Nên dùng cách ngày, tối đa 3 lần/tuần. Không dùng chung retinol với AHA/BHA."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "lão hóa", "chống nhăn", "firming" },
                Answer = "Bộ Yehwadam hoa mẫu đơn/nhân sâm giúp giảm nhăn, nâng cơ và tăng đàn hồi rõ rệt sau 4–6 tuần."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "da khô", "tróc vảy", "thiếu ẩm" },
                Answer = "Da khô chọn SRM dịu nhẹ, toner cấp ẩm và kem dưỡng Shea Butter hoặc Dr.Belmeur Cica. Tránh SRM tạo bọt quá mạnh."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "da hỗn hợp", "combo skin", "T-zone" },
                Answer = "Da hỗn hợp nên dùng toner làm sạch vùng T-zone, dưỡng ẩm nhẹ vùng U. Combo Jeju Aloe + Chia Seed cực hợp cho da HH."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "mũi to", "lỗ chân lông", "se khít" },
                Answer = "Bạn có thể dùng Jeju Volcanic Lava để làm sạch sâu, kết hợp toner BHA dịu nhẹ và serum niacinamide để cải thiện lỗ chân lông."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "niacinamide", "nacin", "nmn" },
                Answer = "Niacinamide giúp sáng da, đều màu và giảm dầu. Dùng sáng hoặc tối đều được, hợp với mọi loại da trừ da quá nhạy cảm."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "makeup", "trang điểm", "lớp nền" },
                Answer = "Lớp nền đẹp cần: kem lót + kem nền Ink Lasting + phấn phủ Oil Control. Da dầu dùng foundation dạng matte sẽ bền hơn."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "giá", "gia", "bao nhiêu", "bao nhieu", "bn", "bn sp này", "bn vậy", "nhiêu tiền", "nhieu tien", "money", "cost", "price", "đắt không", "dat khong", "rẻ không", "re khong", "mắc không", "sp này giá", "gia sp", "giá sản phẩm", "gia san pham", "tầm giá", "tam gia", "khoảng giá", "khoang gia", "thuộc phân khúc nào", "phan khuc", "mức giá", "muc gia", "giá bao nhiêu vậy", "gia bao nhieu vay", "giá bn", "gia bn", "giá web", "gia web", "giá shop", "gia shop", "giá hôm nay", "gia hom nay", "giảm giá chưa", "giam gia chua", "giá sale", "gia sale", "sale bn", "sale bao nhieu", "có giảm không", "co giam khong", "có ưu đãi giá không", "co uu dai gia khong", "check giá", "check gia", "xem giá", "xem gia" },
                Answer = "Giá sản phẩm tại shop dao động rộng tùy danh mục: skincare từ **200k–1.5 triệu**, makeup từ **120k–900k**, body/hair từ **150k–700k**. Bạn gửi tên sản phẩm (hoặc mã SP), mình check **giá chính xác + giá sau khuyến mãi** ngay cho bạn nhé."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "lão hóa", "lao hoa", "anti aging", "chống nhăn", "chong nhan", "nếp nhăn", "nep nhan", "da chảy xệ", "chay xe", "mất đàn hồi", "mat dan hoi", "da xệ", "da nhăn", "da nhun", "wrinkle", "fine line", "laugh line", "rãnh cười", "ranh cuoi", "aging skin" },
                Answer = "Da lão hóa nên thêm routine: serum chống oxy hoá (VitC), retinol/bakuchiol, kem mắt, kem dưỡng giàu peptide/ceramide và chống nắng nghiêm ngặt mỗi ngày."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "routine cơ bản", "routine co ban", "skincare cơ bản", "skincare basic", "chu trình cơ bản", "buoc co ban", "mới skincare", "moi skincare", "newbie", "mới bắt đầu", "hoc skincare", "hoc cham da", "step cơ bản", "simple routine", "simple routine da", "chăm da đơn giản", "cham da don gian", "ít bước", "it buoc" },
                Answer = "Routine cơ bản nên có: Tẩy trang (nếu dùng chống nắng/makeup) → SRM → Toner/Toner mist → Serum tùy vấn đề → Kem dưỡng → Chống nắng (buổi sáng). Làm đều đã thấy da khác nhiều rồi."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "routine sáng", "routine sang", "skincare sáng", "sáng dùng gì", "buổi sáng da", "buoi sang da", "sáng skincare", "sang skincare", "morning routine", "am routine", "sáng chống nắng", "sang cn", "sáng toner", "sáng serum", "sáng dưỡng", "sử dụng sáng", "dùng buổi sáng", "sáng tối khác", "different morning", "chu trình sáng" },
                Answer = "Buổi sáng ưu tiên: SRM dịu → Toner → Serum nhẹ (VitC/Nia/HA) → Kem dưỡng mỏng → Chống nắng SPF50. Hạn chế AHA/BHA/Retinol nặng vào buổi sáng."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "routine tối", "routine toi", "skincare tối", "tối dùng gì", "buổi tối da", "buoi toi da", "night routine", "pm routine", "tối treatment", "tối bôi", "tối tẩy trang", "tẩy trang tối", "tối dùng active", "tối dùng retinol", "tối dùng bha", "tối dưỡng phục hồi", "chu trình tối", "toi skincare", "toi cham da" },
                Answer = "Buổi tối có thể đầy đủ hơn: Tẩy trang → SRM → Toner → Treatment (AHA/BHA/Retinol luân phiên) → Serum phục hồi → Kem dưỡng dày hơn hoặc sleeping mask."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "da học sinh", "da hoc sinh", "da tuổi teen", "da tuoi teen", "da tuổi dậy thì", "teen skincare", "skincare teen", "skincare hoc sinh", "hoc sinh dung gi", "da 13", "da 14", "da 15", "tư vấn teen", "mun tuổi teen", "mun teen", "teen routine", "da đi học", "skin di hoc", "hs dùng gì", "student skin" },
                Answer = "Học sinh/tuổi teen nên dùng routine nhẹ: SRM dịu → Kem chống nắng → Ít nhất 1 bước dưỡng ẩm đơn giản. Nếu có mụn, thêm spot trị mụn và hạn chế makeup dày."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "routine 20", "routine 18+", "routine 20+", "da 18", "da 20", "tuoi 18 da", "tuoi 20 cham da", "chăm da tuổi 20", "skincare 20", "start antiaging", "bắt đầu chống lão hóa", "new anti aging", "20 retinol", "20 vitamin c", "20+ routine", "20 plus routine", "đầu 20", "dau 20", "20 tuổi" },
                Answer = "Từ 18–20 tuổi nên duy trì làm sạch chuẩn, dưỡng ẩm, chống nắng mỗi ngày và có thể thêm serum VitC/Niacinamide; retinol chỉ dùng khi thật cần và chọn nồng độ thấp."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "routine 25", "routine 25+", "tuổi 25", "tuoi 25", "da sau 25", "25 chống lão hóa", "25 antiaging", "25 retinol", "25 yehwadam", "da trưởng thành", "da truong thanh", "25+ skincare", "skincare 25", "nếp nhăn nhỏ", "nep nhan nho", "da mệt", "da met", "da stress", "da văn phòng" },
                Answer = "Từ 25+ nên thêm chống lão hóa: serum chống oxy hóa, kem mắt, retinol/bakuchiol tần suất hợp lý và bộ dưỡng chống lão hóa như Yehwadam; vẫn phải giữ chống nắng đều đặn."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "routine nam", "skincare nam", "da nam", "da con trai", "con trai dung gi", "nam cham da", "nam da dau", "nam da kho", "nam mun", "nam skincare", "men routine", "skin male", "anh dùng gì", "anh em da", "skincare cho nam", "sữa rửa mặt nam", "srm nam", "nam chống nắng", "cn nam", "nam dưỡng ẩm" },
                Answer = "Da nam giới cũng cần: SRM sạch nhưng dịu, kem dưỡng gel hoặc lotion không nhờn, chống nắng SPF50 khi ra ngoài. Nếu da dầu/mụn có thể chọn dòng Fresh For Men hoặc Dr.Belmuer."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "son lâu trôi", "son lau troi", "son bền màu", "son ben mau", "son không trôi", "son khong troi", "son mask", "son đeo khẩu trang", "son deo khau trang", "son ít dính", "son it dinh", "son kissing", "son ăn uống", "son an uong", "son ink lasting", "son lâu phai", "son stay", "lip longwear", "matte longwear", "long lasting lip" },
                Answer = "Nếu muốn son lâu trôi, có thể chọn Ink Lasting, tint Water Fit hoặc dòng semi matte. Nên thấm bớt lớp dầu dưỡng trước, tô mỏng nhiều lớp sẽ bền màu hơn."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "son cho học sinh", "son cho hoc sinh", "son di học", "son di hoc", "son tự nhiên", "son tu nhien", "son tiểu học", "son cấp 2", "son cấp 3", "son mlbb nhẹ", "son học đường", "school lip", "son tint nhẹ", "màu nhẹ", "mau nhe", "tint trong", "tint tự nhiên", "tint không đậm", "tint hong nhẹ", "tint coral nhẹ" },
                Answer = "Học sinh nên dùng tint nước nhẹ hoặc son dưỡng có màu: các tông MLBB hồng đất, cam sữa, coral nhẹ. Tint Water Fit, tint bóng mỏng là gợi ý rất ổn."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "combo da dầu mụn", "combo da dau mun", "set da mụn", "set da mun", "bộ da dầu", "bo da dau", "gợi ý set mụn", "goi y set mun", "full bộ mụn", "routine full mụn", "trọn bộ mụn", "tron bo mun", "set dr belmeur", "dr belmeur set", "combo belmeur", "combo acne", "acne set", "mun yehwadam", "mun dr bel", "combo oil control" },
                Answer = "Combo da dầu mụn gợi ý: Dầu tẩy trang dịu → SRM Jeju Volcanic/Dr.Belmuer → Toner Clarifying → Spot trị mụn → Kem dưỡng gel Oil Control + chống nắng không gây bí lcl."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "combo da khô", "combo da kho", "set da khô", "set dưỡng ẩm", "bộ dưỡng ẩm", "bo duong am", "da khô bong", "da kho bong", "routine da khô", "routine kho", "full dưỡng ẩm", "full duong am", "yehwadam nutrition set", "yehwadam bo", "bo yehwadam kho", "combo plum", "combo therapy khô", "therapy kho", "dưỡng ẩm mạnh", "heavy cream" },
                Answer = "Combo da khô: Tẩy trang dịu → SRM Herb Day Aloe/Yehwadam → Toner cấp ẩm → Serum HA/The Therapy → Kem dưỡng ẩm dày + mặt nạ giấy 2–3 lần/tuần."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "quà 20 tuổi", "qua 20 tuoi", "quà sinh nhật 20", "qua sn 20", "quà bạn gái", "qua ban gai", "quà bạn trai", "qua ban trai", "quà mẹ", "qua me", "quà chị", "qua chi", "quà vợ", "qua vo", "gift set", "giftset", "set quà", "set qua", "gợi ý quà", "goi y qua" },
                Answer = "Quà tặng dễ chọn nhất là các giftset skincare/son: cho bạn gái 20–25 có thể chọn set Yehwadam mini, set son + mascara hoặc combo mặt nạ giấy kèm thiệp của shop."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "cách dùng", "cach dung", "dùng sao", "dung sao", "bôi sao", "boi sao", "thứ tự dùng", "thu tu dung", "trước hay sau", "truoc hay sau", "layer sp", "dùng trước", "dùng sau", "kết hợp sp", "ket hop sp", "mix sản phẩm", "mix sp", "dùng chung", "dung chung" },
                Answer = "Nguyên tắc chung: Lỏng → đặc, mỏng → dày. Sau rửa mặt: Toner → Serum/Tinh chất → Emulsion (nếu có) → Kem dưỡng → Chống nắng (ban ngày). Không nên dùng quá nhiều treatment mạnh cùng lúc."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "mẫu thử", "mau thu", "sample", "sachet", "túi sample", "xin sample", "cho xin mẫu", "co sample", "test trước", "test thu", "thử trước", "thu truoc", "dùng thử", "dung thu", "mini size", "size mini", "travel size", "size du lich", "kit nhỏ", "kit nho" },
                Answer = "Shop có một số loại sample/mini size theo chương trình từng đợt. Bạn nhắn kèm loại da + nhu cầu, khi đóng đơn nếu còn sample phù hợp bên mình sẽ cố gắng hỗ trợ cho bạn test trước."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "đặt hàng", "dat hang", "order", "oder", "chốt đơn", "chot don", "mua sao", "mua thế nào", "mua thế nao", "cách mua", "cach mua", "hướng dẫn mua", "huong dan mua", "thêm vào giỏ", "add cart", "check out", "thanh toán sao", "thanh toan sao", "đặt giúp", "dat giup" },
                Answer = "Bạn có thể đặt hàng trực tiếp trên website: chọn sản phẩm → thêm vào giỏ → điền thông tin nhận hàng → chọn hình thức thanh toán → xác nhận đơn. Nếu cần mình có thể hướng dẫn từng bước hoặc chốt đơn trực tiếp qua chat."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "thanh toán", "thanh toan", "cod", "trả sau", "tra sau", "chuyển khoản", "chuyen khoan", "banking", "momo", "momo pay", "zalopay", "vnpay", "visa", "master", "atm", "thẻ atm", "cách thanh toán", "cach thanh toan", "tiền mặt", "tien mat" },
                Answer = "Shop hỗ trợ COD (nhận hàng trả tiền), chuyển khoản ngân hàng, ví Momo/VNPay (tuỳ kênh). Bạn chọn hình thức thuận tiện nhất ở bước thanh toán hoặc nhắn mình để được hướng dẫn."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "lỗi web", "loi web", "không đặt được", "khong dat duoc", "lỗi giỏ hàng", "loi gio hang", "không thêm giỏ", "khong them gio", "web lag", "web lỗi", "web loi", "trang trắng", "trang trang", "bị out", "bi out", "reload hoài", "refresh hoai", "ko bấm được", "không bấm được" },
                Answer = "Nếu web bị lỗi/không đặt được, bạn có thể gửi giúp mình: 1) Tên sản phẩm + số lượng + địa chỉ + SĐT, mình tạo đơn thủ công; đồng thời bên mình sẽ kiểm tra lại hệ thống cho bạn."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "kiểm tra đơn", "kiem tra don", "check đơn", "check don", "trạng thái đơn", "trang thai don", "đơn tới đâu", "don toi dau", "đơn đang giao", "don dang giao", "mã đơn", "ma don", "tra cứu đơn", "tra cuu don", "update đơn", "update don", "đơn hàng của tôi", "don hang cua toi", "don cua em", "đơn của em" },
                Answer = "Bạn gửi giúp mình mã đơn/SĐT đặt hàng, mình kiểm tra trạng thái đơn, vị trí vận chuyển và dự kiến ngày nhận cho bạn ngay."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "bảo quản", "bao quan", "hạn mở nắp", "han mo nap", "dùng trong bao lâu", "dung trong bao lau", "hạn dùng", "thoi han dung", "open date", "paO", "bảo quản serum", "bao quan kem", "để tủ lạnh", "de tu lanh", "để phòng", "de phong", "để chỗ mát", "de cho mat", "tránh nắng", "tranh nang" },
                Answer = "Mỹ phẩm nên để nơi khô ráo, tránh nắng trực tiếp và nhiệt cao. Thường sau khi mở nắp dùng tốt trong 6–12 tháng tuỳ sản phẩm. Một số serum đặc biệt có thể khuyến nghị để ngăn mát – trên hộp sẽ ghi rõ."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "có kích ứng không", "co kich ung khong", "bị rát", "bi rat", "bị đỏ", "bi do", "bị ngứa", "bi ngua", "dị ứng", "di ung", "mụn lên thêm", "mun len them", "purge hay kích ứng", "kich ung hay purge", "hợp da không", "hop da khong", "an toàn không", "an toan khong", "có cồn không", "co con khong" },
                Answer = "Nếu đang dùng mà da đỏ/rát/ngứa bất thường, bạn nên ngưng tất cả treatment mạnh, giữ lại SRM dịu + dưỡng phục hồi đơn giản. Nếu vẫn không đỡ hoặc xuất hiện triệu chứng nặng, bạn nên đi khám da liễu để được chẩn đoán chính xác."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "tư vấn", "tuvan", "tu van", "hỏi da", "hỏi skin", "tư vấn da", "tư vấn sp", "chọn sp", "chon sp", "chọn sản phẩm", "gợi ý sp", "goi y sp", "gợi ý sản phẩm", "da em", "da minh", "da mình", "nên dùng gì", "nen dung gi", "dùng gì", "dung gi" },
                Answer = "Bạn cho mình tuổi, loại da (dầu/khô/hh/nhạy cảm) và tình trạng hiện tại (mụn, thâm, nám...) mình tư vấn routine chi tiết và chọn sản phẩm phù hợp cho nhé."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "da dầu", "da dau", "nhờn", "nhon", "oil skin", "oily", "tiết dầu", "tiet dau", "bóng dầu", "bong dau", "đổ dầu", "do dau", "mặt bóng", "mat bong", "dầu vùng t", "nhờn vùng t", "da hỗn hợp thiên dầu", "hh thiên dầu", "hỗn hợp dầu", "hon hop dau" },
                Answer = "Da dầu/hỗn hợp dầu nên chọn SRM kiềm dầu dịu nhẹ, toner cân bằng, serum Niacinamide/BHA và kem dưỡng gel mỏng, kèm chống nắng không gây bí lcl."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "da khô", "da kho", "khô ráp", "kho rap", "thiếu ẩm", "thieu am", "mất nước", "mat nuoc", "căng khô", "cang kho", "bong tróc", "bong troc", "da sần", "da san", "tight skin", "dry skin", "khô căng", "kho cang", "khô môi", "kho moi" },
                Answer = "Da khô nên ưu tiên SRM dịu, toner cấp ẩm, serum HA, kem dưỡng đặc hơn (cream/balm). Hạn chế tẩy da chết hạt to, nhớ dùng mặt nạ/overnight mask 2–3 lần/tuần."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "da hỗn hợp", "da hon hop", "combination", "da vừa dầu vừa khô", "vùng t dầu", "t zone dầu", "vùng má khô", "da không đều", "hon hop thien kho", "hh thiên khô", "hon hop thien dau", "combo skin", "support da hỗn hợp", "tư vấn hh", "da mix", "mix skin", "many zone", "multi zone", "vùng dầu vùng khô", "vùng khô vùng dầu" },
                Answer = "Da hỗn hợp nên dùng SRM dịu, toner cân bằng, dưỡng gel ở vùng dầu và có thể thêm kem dưỡng đặc hơn vùng má khô. BHA dùng mỏng ở vùng dễ bí lcl thôi."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "mụn ẩn", "mun an", "mụn đầu trắng", "mun dau trang", "mụn li ti", "mun li ti", "da sần", "da sần mụn", "ẩn dưới da", "nhân mụn", "clear face", "tri mun an", "đẩy mụn", "day mun", "purging", "da không mịn", "da khong min", "mụn cám", "mun cam", "mụn nhỏ" },
                Answer = "Mụn ẩn nên ưu tiên tẩy trang sạch, SRM dịu, BHA nồng độ vừa 2–3 lần/tuần và dưỡng phục hồi. Hạn chế bóp nặn; luôn chống nắng đầy đủ để giảm thâm."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "mụn viêm", "mun viem", "mụn sưng", "mun sung", "mụn đỏ", "mun do", "mụn đau", "mun dau", "mụn nang", "mun nang", "mụn bọc", "mun boc", "mụn mủ", "mun mu", "acne viem", "mụn nhiều", "mun nhieu", "bùng mụn", "bung mun", "bị mụn nhiều" },
                Answer = "Mụn viêm nên dùng SRM dịu, xịt/toner làm dịu như Dr.Belmuer, chấm spot trị mụn riêng, dưỡng phục hồi ít active. Không tự ý mix nhiều treatment mạnh cùng lúc."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "thâm mụn", "tham mun", "vết thâm", "vet tham", "thâm đỏ", "tham do", "thâm nâu", "tham nau", "scar", "sẹo mụn", "seo mun", "dark spot", "vết đen", "vet den", "vùng tối", "không đều màu", "khong deu mau", "hyperpig", "pigmentation", "fade spot" },
                Answer = "Thâm mụn nên dùng combo: Vitamin C nhẹ, Niacinamide, dưỡng ẩm tốt + chống nắng SPF50 mỗi ngày. Thâm sẽ mờ dần sau 4–8 tuần tuỳ cơ địa."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "nám", "nam da", "melasma", "đốm nâu", "dom nau", "tàn nhang", "tan nhang", "đốm sạm", "dom sam", "sạm da", "sam da", "flek", "spot nâu", "spot nâu lớn", "điều trị nám", "tri nam", "sạm nám", "sam nam", "da nám", "da tan nhang" },
                Answer = "Nám/tàn nhang cần chống nắng kỹ (SPF50, thoa đủ lượng), kết hợp serum sáng da an toàn như Niacinamide, Vitamin C ổn định và kiên trì thời gian dài. Vấn đề nám sâu nên tham khảo bác sĩ da liễu."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "lỗ chân lông", "lo chan long", "lcl to", "lỗ to", "pore", "se lcl", "se lo", "pore tight", "pore care", "da sần lcl", "da dau lcl", "nhờn lcl to", "oil pore", "mụn đầu đen", "mun dau den", "blackhead", "whitehead", "bít tắc", "bit tac", "tắc lỗ chân lông" },
                Answer = "Lỗ chân lông to nên tập trung làm sạch kép (tẩy trang + SRM), BHA đều đặn, tẩy tế bào chết nhẹ nhàng và tránh makeup quá dày. Dưỡng ẩm vẫn rất cần để da khỏe và đều cấu trúc."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "hi", "hello", "helo", "alo", "a lô" },
                Answer = "Chào bạn 👋 Mình là chatbot hỗ trợ tư vấn. Bạn cần mình giúp gì nè?"
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "chào", "xin chào", "chao shop", "hello shop", "shop ơi" },
                Answer = "Hello bạn, shop đang online nè 🌸 Bạn muốn hỏi về da, routine hay đơn hàng không ạ?"
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "ad ơi", "admin ơi", "ad oi", "ad đây không", "admin đâu" },
                Answer = "Ad có mặt đây ạ 🙋‍♀️ Bạn cứ nhắn điều bạn cần, mình hỗ trợ hết sức."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "có ai không", "có đó không", "có onl không", "có ở đó không", "có ai tư vấn không" },
                Answer = "Mình đang ở đây nè 🥰 Bạn cứ gửi câu hỏi, mình trả lời cho bạn liền."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "good morning", "chào buổi sáng", "sáng vui", "buổi sáng tốt lành", "sáng shop" },
                Answer = "Chào buổi sáng ☀️ Chúc bạn một ngày da đẹp, mood đẹp. Bạn cần tư vấn gì không nè?"
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "good night", "chúc ngủ ngon", "ngủ ngon", "đi ngủ đây", "thôi em ngủ" },
                Answer = "Ngủ ngon nha bạn 😴 Da đẹp cũng cần ngủ đủ đó. Có gì mai mình nói chuyện tiếp ha."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "chào buổi tối", "good evening", "tối rồi", "khuya rồi", "tối khuya" },
                Answer = "Buổi tối skincare là chân ái luôn đó ✨ Bạn đã skincare xong chưa nè?"
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "trưa rồi", "buổi trưa", "giờ nghỉ trưa", "tranh thủ nghỉ trưa", "trưa nay" },
                Answer = "Nghỉ trưa nhớ uống nước và chống nắng lại nếu có ra ngoài nha bạn 🌤️"
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "lâu rồi mới vào", "lâu rồi mới quay lại", "mới quay lại shop", "lâu rồi không mua", "lâu rồi mới ghé" },
                Answer = "Mừng bạn quay lại với tụi mình 🥹 Nếu bạn cần gợi ý routine mới, cứ nói tình trạng da hiện tại nha."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "mới vô", "mới vào", "mới biết shop", "lần đầu vào", "lần đầu ghé" },
                Answer = "Chào mừng bạn lần đầu ghé shop 🌷 Mình có thể tư vấn nhẹ nhàng từ A–Z cho bạn, không áp lực mua đâu nè."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "cảm ơn", "thank", "thanks", "tks", "cám ơn shop" },
                Answer = "Dạ mình cảm ơn bạn nhiều 🥰 Nếu cần hỗ trợ thêm, cứ gọi tên mình nhé."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "cảm ơn nhiều", "cảm ơn nha", "cảm ơn shop nhiều", "thanks shop", "thank you so much" },
                Answer = "Cảm ơn bạn vì đã tin tưởng tụi mình 💚 Chúc bạn luôn da đẹp – tâm trạng đẹp."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "shop dễ thương", "tư vấn dễ thương", "bot dễ thương", "nhiệt tình quá", "shop cute" },
                Answer = "Huhu nghe bạn nói mà mình vui xỉu 🥹 Mình sẽ cố gắng tư vấn kỹ và dễ hiểu nhất cho bạn."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "shop tư vấn ok", "tư vấn có tâm", "tư vấn rõ ràng", "giải thích dễ hiểu", "tư vấn kỹ quá" },
                Answer = "Cảm ơn bạn đã feedback, đó là động lực để tụi mình làm tốt hơn mỗi ngày 💪"
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "love shop", "thích shop", "thương shop", "ưng shop", "mê shop" },
                Answer = "Tụi mình cũng thương bạn nhiều lắm 🫶 Cần gì bạn cứ nói, tụi mình support nhiệt tình."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "xin lỗi", "sr", "sorry", "cho mình xin lỗi", "tại mình nhầm" },
                Answer = "Không sao đâu ạ, mình hiểu mà 😊 Có gì bạn cứ nói lại cho rõ, mình hỗ trợ bạn tiếp."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "hiểu nhầm", "hiểu lầm", "nãy mình hiểu lầm", "mình đọc nhầm", "mình xem nhầm" },
                Answer = "Không vấn đề gì hết, có chỗ nào chưa rõ bạn cứ hỏi lại, mình giải thích kỹ hơn cho."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "khó hiểu quá", "rối quá", "em không hiểu", "chưa hiểu lắm", "giải thích lại được không" },
                Answer = "Mình xin lỗi nếu nãy giải thích hơi khó hiểu 🙏 Để mình nói lại đơn giản hơn cho bạn nè."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "giận rồi đó", "bực rồi đó", "khó chịu quá", "cọc rồi đó", "bực mình" },
                Answer = "Mình xin lỗi nếu trải nghiệm của bạn chưa tốt 😔 Bạn nói rõ giúp mình để mình xử lý và hỗ trợ lại cho bạn nha."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "thôi bỏ đi", "thôi kệ", "thôi không sao", "thôi cũng được", "không sao đâu" },
                Answer = "Vậy mình cùng bỏ qua ha 🤝 Nếu cần hỗ trợ thêm chuyện gì khác, bạn cứ nhắn mình nha."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "bot là ai", "mày là ai", "bạn là ai", "đây là ai", "ai trả lời vậy" },
                Answer = "Mình là chatbot hỗ trợ tư vấn online cho bạn 💻 Có thể hỗ trợ bạn về da, đơn hàng và thông tin cơ bản của shop."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "bot hay người", "người thật không", "có phải người không", "đây là nhân viên hay bot", "máy hay người" },
                Answer = "Hiện tại mình là bot tự động 🤖 nhưng đã được cài kiến thức cơ bản để hỗ trợ bạn nhanh nhất. Nếu có gì phức tạp, bạn có thể để lại thông tin để nhân viên thật hỗ trợ thêm."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "ai tạo ra mày", "ai lập trình", "ai code mày", "ai làm ra cái này", "ai làm bot này" },
                Answer = "Mình được shop cấu hình dựa trên hệ thống AI, để trả lời các câu hỏi thường gặp và gợi ý cho bạn tiện hơn đó."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "bot biết gì", "mày biết làm gì", "biết tư vấn không", "biết gì về da", "biết gì về skincare" },
                Answer = "Mình có thể hỗ trợ cơ bản về loại da, bước skincare, thông tin đơn hàng và vài câu hỏi linh tinh khác. Bạn cứ hỏi thử nha."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "bot ngu", "dốt vậy", "trả lời kì quá", "trả lời sai rồi", "trả lời tào lao" },
                Answer = "Nếu câu trả lời chưa đúng ý bạn, cho mình xin lỗi nha 😢 Bạn có thể nói rõ hơn nhu cầu, mình sẽ cố gắng trả lời chuẩn hơn."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "trời nóng quá", "nóng quá", "trời nắng quá", "nắng kinh khủng", "thời tiết nóng" },
                Answer = "Thời tiết nóng thì da cũng dễ đổ dầu và cháy nắng hơn đó 🌤 Nhớ uống nước và chống nắng đầy đủ nha bạn."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "trời lạnh quá", "lạnh quá", "thời tiết lạnh", "trời se lạnh", "lạnh ghê" },
                Answer = "Trời lạnh da rất dễ khô và bong tróc 🥶 Bạn nhớ dưỡng ẩm đầy đủ hơn bình thường nha."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "mưa quá", "trời mưa", "lại mưa nữa", "mưa tầm tã", "mưa hoài" },
                Answer = "Trời mưa là mood đi skincare, đắp mặt nạ chill nhất luôn đó 🧖‍♀️"
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "máy chủ ở đâu", "shop ở đâu vậy", "ở đâu thế", "cửa hàng nằm ở đâu", "shop ở tỉnh nào" },
                Answer = "Shop mình là hệ thống online, chi tiết địa chỉ/chi nhánh bạn xem ở mục 'Liên hệ' trên website giúp mình nha."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "giờ này còn làm việc không", "còn hoạt động không", "còn tư vấn không", "có onl giờ này không", "giờ này còn mở cửa không" },
                Answer = "Chatbot thì hoạt động 24/7 luôn nha 🤖 Còn giờ làm việc của nhân viên tư vấn bạn xem ở phần thông tin trên web ạ."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "shop uy tín không", "có uy tín không", "hàng có đảm bảo không", "tin tưởng được không", "sợ hàng fake" },
                Answer = "Shop chỉ cung cấp hàng chính hãng từ hãng phân phối. Nếu bạn cần, shop có thể gửi thêm hình bill/tem/hoá đơn để bạn yên tâm hơn."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "có bán offline không", "có cửa hàng không", "có chi nhánh không", "bán trực tiếp không", "tới xem trực tiếp được không" },
                Answer = "Hiện tại kênh chat này là online. Thông tin cửa hàng/chi nhánh bạn xem mục 'Hệ thống cửa hàng' trên website hoặc fanpage giúp mình nha."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "fanpage là gì", "link page", "facebook shop", "cho xin fanpage", "page chính thức" },
                Answer = "Bạn có thể tìm fanpage chính thức bằng tên thương hiệu, hoặc xem mục liên hệ trên website để tránh nhầm page giả nhé."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "hotline", "sđt shop", "số điện thoại", "gọi điện được không", "cho xin hotline" },
                Answer = "Hotline hỗ trợ của shop được hiển thị trên website và fanpage. Bạn có thể gọi trực tiếp để gặp nhân viên tư vấn nhanh hơn nha."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "giờ làm việc", "thời gian làm việc", "giờ mở cửa", "mở cửa lúc mấy giờ", "làm việc mấy giờ đến mấy giờ" },
                Answer = "Khung giờ làm việc chi tiết của shop được cập nhật trên website/fanpage, thường là giờ hành chính và có hỗ trợ ngoài giờ qua chat."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "có khuyến mãi không", "khuyến mãi gì", "đang sale gì", "có sale không", "chương trình ưu đãi" },
                Answer = "Chương trình khuyến mãi sẽ được cập nhật thường xuyên trên banner website và fanpage. Bạn ghé đó xem khung giờ sale/ưu đãi mới nhất nha."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "voucher", "mã giảm giá", "code giảm giá", "có mã không", "cho xin voucher" },
                Answer = "Mã giảm giá thường đi kèm từng đợt khuyến mãi riêng. Bạn xem phần banner, popup hoặc mục khuyến mãi trên web để lấy mã còn áp dụng được nhé."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "free ship không", "freeship không", "miễn ship không", "hỗ trợ tiền ship", "ship free" },
                Answer = "Chính sách freeship thường theo giá trị đơn hoặc khu vực. Bạn xem chi tiết trong mục 'Chính sách giao hàng' trên website nha."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "ưu đãi sinh nhật", "ưu đãi member", "ưu đãi thành viên", "có tích điểm không", "thẻ thành viên" },
                Answer = "Nếu bạn đăng ký thành viên, tuỳ chương trình từng giai đoạn sẽ có ưu đãi sinh nhật, tích điểm, mã riêng. Bạn xem thêm ở mục 'Thành viên' trên web."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "sale sốc", "sale mạnh", "giảm sâu", "flash sale", "big sale" },
                Answer = "Các đợt sale lớn như flash sale/big sale thường được thông báo trước trên banner web và fanpage. Bạn có thể bật theo dõi để không bỏ lỡ nha."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "đơn hàng của em", "đơn của em sao rồi", "đơn tới đâu rồi", "check đơn giúp", "kiểm tra đơn" },
                Answer = "Để kiểm tra đơn chính xác, bạn giúp mình cung cấp mã đơn hoặc số điện thoại đặt hàng, sau đó nhân viên sẽ hỗ trợ chi tiết hơn nhé."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "mới đặt xong", "đặt rồi nè", "đặt đơn rồi", "mới chốt đơn", "chốt rồi nha" },
                Answer = "Dạ mình ghi nhận rồi ạ 📝 Đơn sẽ được xử lý trong thời gian sớm nhất. Nếu cần chỉnh sửa thông tin, bạn báo nhanh giúp shop nhé."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "huỷ đơn được không", "có huỷ đơn được không", "muốn huỷ đơn", "cho em huỷ đơn", "huỷ giúp em" },
                Answer = "Nếu đơn chưa giao cho bên vận chuyển, thường vẫn có thể huỷ được. Bạn cung cấp mã đơn để nhân viên hỗ trợ kiểm tra giúp nha."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "đổi địa chỉ", "sai địa chỉ", "muốn sửa địa chỉ", "thay đổi địa chỉ", "ghi nhầm địa chỉ" },
                Answer = "Bạn nên báo sớm cho shop kèm mã đơn + địa chỉ mới để nhân viên sửa kịp, tránh đơn đã chuyển đi thì hơi khó xử lý hơn ạ."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "trễ quá", "sao lâu vậy", "sao chưa thấy ship", "chờ hoài không thấy", "lâu dữ" },
                Answer = "Cho mình xin lỗi vì sự chậm trễ 😔 Bạn gửi mã đơn/sđt để nhân viên kiểm tra tình trạng vận chuyển, rồi báo lại chính xác cho bạn nha."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "ship bao lâu", "mất mấy ngày", "mấy ngày nhận được", "bao lâu mới tới", "thời gian giao hàng" },
                Answer = "Thời gian giao hàng tùy khu vực: nội thành thường nhanh hơn, tỉnh sẽ lâu hơn 1–2 ngày. Chi tiết bạn xem mục 'Giao hàng' trên website ạ."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "có cho kiểm hàng không", "được kiểm hàng không", "kiểm trước khi nhận", "ktra hàng trước khi trả tiền", "cho xem hàng trước" },
                Answer = "Chính sách kiểm hàng phụ thuộc đơn vị vận chuyển và quy định từng đợt. Bạn xem mục 'Chính sách giao hàng' hoặc hỏi trực tiếp nhân viên để có thông tin mới nhất nha."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "cod không", "thanh toán khi nhận", "trả tiền khi nhận", "có ship cod không", "cho em cod" },
                Answer = "Shop có hỗ trợ COD ở nhiều khu vực. Nhưng để chắc chắn, bạn xem thêm chi tiết ở mục 'Thanh toán & Giao hàng' trên web nhé."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "chuyển khoản được không", "thanh toán chuyển khoản", "banking", "momo", "ví điện tử" },
                Answer = "Shop thường hỗ trợ nhiều hình thức thanh toán như chuyển khoản, ví... Cụ thể bạn xem trong bước thanh toán trên web để biết các tuỳ chọn hiện có."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "phí ship bao nhiêu", "ship nhiêu tiền", "phí vận chuyển", "tiền ship", "ship đắt không" },
                Answer = "Phí ship phụ thuộc địa chỉ nhận và đơn vị vận chuyển. Hệ thống sẽ hiển thị phí chính xác khi bạn nhập địa chỉ trong bước đặt hàng nha."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "bực quá", "ức chế", "không hài lòng", "không thích", "khó chịu với shop" },
                Answer = "Mình rất xin lỗi khi bạn không hài lòng 😢 Bạn chia sẻ cụ thể tình huống giúp mình để bên shop điều chỉnh và hỗ trợ lại tốt hơn cho bạn nha."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "tệ quá", "dịch vụ kém", "chán shop", "không ưng", "thất vọng" },
                Answer = "Mình ghi nhận góp ý của bạn ạ 🙏 Shop luôn muốn cải thiện dịch vụ, nên mong bạn nói rõ hơn để tụi mình kiểm tra và khắc phục."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "trả lời chậm", "rep chậm", "seen không trả lời", "đợi lâu quá", "trả lời gì lâu vậy" },
                Answer = "Mình xin lỗi vì phản hồi chưa kịp thời 😔 Có thể do lượng tin nhắn nhiều, nhưng tụi mình sẽ cố gắng trả lời bạn sớm nhất có thể."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "bot ngáo", "bot dở quá", "trả lời như bot", "ngáo vậy", "kỳ cục ghê" },
                Answer = "Nếu câu trả lời chưa đúng ý bạn, cho mình xin lỗi nha. Bạn thử nói rõ hơn vấn đề, mình sẽ trả lời chi tiết và chuẩn hơn."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "không cần nữa", "thôi khỏi", "khỏi tư vấn", "thôi không mua", "khỏi đi" },
                Answer = "Dạ mình tôn trọng quyết định của bạn ạ 😊 Lần sau nếu cần tham khảo hoặc hỏi thử cho vui, bạn cứ quay lại với mình nha."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "rảnh quá nên vào chơi", "vô chém gió", "vô nói chuyện chơi", "chat cho vui", "vào nghịch tí" },
                Answer = "Không sao, bạn có thể hỏi linh tinh về da, về skincare, mình vẫn tám được hết 😆"
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "ăn cơm chưa", "ăn chưa", "tối ăn gì", "trưa ăn gì", "đi ăn chưa" },
                Answer = "Nếu bạn chưa ăn thì đi ăn rồi hãy skincare nha 😋 Da đẹp cũng cần ăn uống đầy đủ nữa đó."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "bạn khoẻ không", "khỏe không", "ổn không", "ổn chứ", "sống tốt không" },
                Answer = "Mình là bot nên lúc nào cũng online, không ốm không mệt 😆 Chỉ cần bạn cần là mình xuất hiện liền."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "haha", "hihi", "kkk", "cười ỉa", "vui ghê" },
                Answer = "Thấy bạn cười là mình cũng vui lây 😆 Nếu muốn mình gợi ý routine nhẹ nhàng thì cứ nói nha."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "buồn quá", "tụt mood", "mệt mỏi quá", "stress quá", "áp lực quá" },
                Answer = "Mong bạn sớm đỡ hơn nha 🥺 Thử dành chút thời gian chăm da, thư giãn một xíu cũng giúp đỡ căng thẳng đó."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "test bot", "test thử", "thử xem bot biết gì", "test chút", "test xí" },
                Answer = "Bạn cứ thoải mái test mình 😎 Mình sẽ cố gắng trả lời những gì nằm trong khả năng được cài đặt."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "123", "1234", "111", "....", "???" },
                Answer = "Có vẻ bạn đang thử mình 😆 Bạn có thể hỏi về da, routine, đơn hàng hoặc bất cứ điều gì liên quan đến shop nha."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "kk", ":))", ":v", "=))", "hehe" },
                Answer = "Mood vui vậy là tốt rồi 😁 Bạn muốn mình gợi ý gì vui vui cho da đẹp thêm không?"
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "đang làm gì đó", "đang làm gì", "mày đang làm gì", "bot làm gì", "rảnh không" },
                Answer = "Mình đang... chờ tin nhắn của bạn nè 😌 Bạn hỏi cái là mình rep liền."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "biết hát không", "hát đi", "kể chuyện đi", "kể chuyện cười", "biết kể joke không" },
                Answer = "Mình không hát được chứ mình có thể kể chuyện về skincare, về da, về tips giữ da đẹp mỗi ngày cho bạn 😆"
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "ok chưa", "ổn chưa", "ổn không vậy", "được chưa", "vậy được chưa" },
                Answer = "Nếu bạn vẫn còn lăn tăn, cứ nói rõ hơn, mình chỉnh lại tư vấn cho chuẩn hơn nha."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "thiệt không", "có chắc không", "thật không đó", "chắc chứ", "có đúng không" },
                Answer = "Thông tin mình đưa ra là theo kiến thức đã được cài đặt sẵn. Nhưng nếu là vấn đề da bệnh lý nặng, bạn vẫn nên hỏi thêm bác sĩ da liễu nhé."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "ừ", "ok", "okie", "okla", "oke" },
                Answer = "Oke luôn bạn ơi 🙌 Nếu quyết xong rồi mà cần mình nhắc lại routine, mình tổng hợp lại cho bạn nè."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "ghi nhận", "note lại rồi", "ghi chú lại rồi", "để em nhớ", "để em suy nghĩ" },
                Answer = "Dạ bạn cứ từ từ suy nghĩ, không cần gấp đâu. Khi nào cần hỏi lại, chỉ cần nhắn cho mình là được."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "có gì đặc biệt", "khác gì chỗ khác", "hơn chỗ khác chỗ nào", "khác biệt gì", "điểm mạnh là gì" },
                Answer = "Điểm mạnh là tụi mình cố gắng tư vấn kỹ, phù hợp từng loại da và ngân sách của bạn, chứ không ép bạn mua nhiều."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "có lưu info không", "có giữ thông tin không", "bảo mật không", "an toàn không", "lộ thông tin không" },
                Answer = "Thông tin của bạn được dùng để hỗ trợ tư vấn và xử lý đơn hàng, shop luôn cố gắng tuân thủ các quy định về bảo mật dữ liệu."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "sợ bị spam", "spam tin nhắn", "gửi tin nhắn hoài", "spam sms", "spam zalo" },
                Answer = "Nếu bạn cảm thấy bị làm phiền bởi tin nhắn, bạn có thể tắt/huỷ đăng ký nhận thông báo ở các kênh tương ứng nha."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "có lưu lịch sử chat không", "lưu cuộc trò chuyện", "lịch sử chat", "xóa lịch sử chat", "delete chat" },
                Answer = "Lịch sử chat giúp tụi mình hiểu bạn hơn để tư vấn lần sau dễ hơn. Nếu bạn cần xoá, bạn có thể xóa trên giao diện của mình."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "có thu âm không", "có ghi âm không", "có camera không", "có quay lén không", "bị theo dõi không" },
                Answer = "Chatbot chỉ xử lý nội dung bạn gõ vào khung chat, không dùng camera hay ghi âm đâu ạ. Bạn yên tâm nha."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "dùng dữ liệu làm gì", "lấy dữ liệu làm gì", "thu thập dữ liệu", "data của em", "thông tin cá nhân" },
                Answer = "Dữ liệu chủ yếu dùng để tư vấn tốt hơn và xử lý đơn hàng. Shop không khuyến khích chia sẻ thông tin quá nhạy cảm trên khung chat."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "bye", "tạm biệt", "goodbye", "bai bai", "em đi đây" },
                Answer = "Bye bye bạn 👋 Khi nào cần hỏi thêm về da hay đơn hàng, bạn cứ quay lại với mình nha."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "hẹn gặp lại", "lát nói tiếp", "để sau nói tiếp", "tí quay lại", "xíu quay lại" },
                Answer = "Okie mình đợi bạn quay lại nè 🤗 Bạn rảnh cứ vào hỏi tiếp, mình luôn sẵn sàng."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "cảm ơn rồi thôi", "xong rồi đó", "vậy là đủ", "vậy thôi", "thế là được" },
                Answer = "Rất vui vì đã hỗ trợ được cho bạn 🥰 Khi nào có thắc mắc mới, bạn cứ ghé lại hỏi mình tiếp nhé."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "khỏi rep", "khỏi trả lời", "khỏi tư vấn thêm", "đừng rep nữa", "stop" },
                Answer = "Mình xin phép dừng tại đây nha 🌸 Nếu sau này bạn cần hỗ trợ thêm, cứ quay lại chat với mình."
            },
            new ChatBotTrainingItem
            {
                Keywords = new List<string> { "đi làm việc đây", "đi học đây", "em bận xíu", "em off đây", "off nha" },
                Answer = "Chúc bạn một ngày làm việc/học tập thuận lợi nha 💼📚 Nhớ chăm da nhẹ nhàng mỗi ngày nữa là xịn luôn."
            }
        };
    }
}
