//string[] Names = new string[]
//    {
//        "Abdulxayev Jasurbek Anvar O'g'li",
//        "Abdumannonov Botirjon Davlat O'g'li",
//        "Abdurahmonov Azizbek Alisher O'g'li",
//        "Anvarjonov Ozodbek Avazxon O'g'li",
//        "Asadov Firdavs Asqarbek O'g'li",
//        "Eshmurodov Umarali Abduhalim O'g'li",
//        "Ibrohimjonov Shodiyor Ziyodali O'g'li",
//        "Jo'raboyev Boburjon Murodjon O'g'li",
//        "Kamolov Bunyod Maruf O'g'li",
//        "Karimjonov Ilhom Ramzjon O'g'li",
//        "Komiljonov Muhammadaziz Abduraximovich",
//        "Rashidov Asadbek",
//        "Sadriddinov Abdurahmon Jurabek O'g'li",
//        "Sattorova Habiba Shuxrat Qizi",
//        "Tolibov Firdavs Odil O'g'li",
//        "To'rayev Dinur Alisher O'g'li",
//        "Vositov Muhammadrizo Muhammadtolib O'g'li",
//        "Xaybullayev Mexroj Mansurjonovich",
//        "Xolmuratov Qurbonali Suxrob O'g'li",
//    };
//Console.WriteLine("Search: ");
//string search = Console.ReadLine().ToLower();
//foreach (string name in Names)
//{
//    if (name.ToLower().Contains(search)) 
//    {
//        Console.WriteLine(name);
//    }
//}
var changedwords = "{ApplicationDate} {ApplicationNumber} { OrganizationName}rektori " +
    "{ RektorgaAbituriyent ${StudentName} danTel.: ${ StudentNumber}ARIZAMen joriy " +
    "yilda ${OrganizationName}ning ${ Code}- ${ EduSpeciality}ta 'lim yo'nalishini " +
    "${ EduForm}ta 'lim shakli, ${EduLanguage} ta'lim tili " +
    "bo'yicha ${OrderId} - OTM sifatida tanlab, " +
    "davlat test sinovida ishtirok etdim.Davlat test markazi tomonidan " +
    "e'lon qilingan test natijasiga ko'ra ${Ball} " +
    "ball to'pladim va to'lov-kontrakt asosidagi qabul " +
    "chegarasiga ${DifferenceBall} ball yetmay qoldi .Shu munosabat bilan, " +
    "meni qo'shimcha tarzda ${EduContractSumType} tabaqalashtirilgan to'lov-kontrakt " +
    "asosida talabalikka qabul qilishingizni " +
    "hamda menga to`lov shartnomasini taqdim etishingizni so'rayman.Men Oliy ta'lim muassasasining " +
    "ichki tartib qoidalari va " +
    "kontraktni barcha shartlari bilan tanishib chiqdim hamda tasdiqlangan o'quv rejasi bo'yicha " +
    "belgilangan vaqtlarda " +
    "darslarga qatnashishga, belgilangan muddatlarda to'lov-kontrakt pulini to'lashga va to'lov hujjatlarini topshirishga " +
    "shaxsan o`zim mas'ulligimni tasdiqlayman.Abituriyent: ${ Abiturient}ID raqami: ${ AbiturientId}";
var ApplicationDate = "{ApplicationDate}";
var ApplicationNumber = "{ApplicationNumber}";
var OrganizationName = "{OrganizationName}";
var Rektor = "{Rektor}";
var StudentName = "{StudentName}";
var Studentnumber = "{StudentNumber}";
var Code = "{Code}";
var EduSpeciality = "{EduSpeciality}";
var EduForm = "{EduForm}";
var EduLanguage = "{EduLanguage}";
var OrderId = "{OrderId}";
var Ball = "{Ball}";
var DifferenceBall = "{DifferenceBall}";
var EduContractSumType = "{EduContractSumType}";
var Abituriyent = "{Abituriyent}";
var AbituriyentId = "{AbituriyentId}";
var formattedNotifications = changedwords
    .Replace(ApplicationDate, DateTime.Now.ToString())
    .Replace(ApplicationNumber, Guid.NewGuid().ToString())
    .Replace(OrganizationName, "Najot Ta'lim")
    .Replace(Rektor, "Temurbek Adhamov")
    .Replace(StudentName, "Firdavs Asadov")
    .Replace(Studentnumber, "+998888055831")
    .Replace(Code, "Backend N10")
    .Replace(EduSpeciality, "Dasturlash")
    .Replace(EduForm, "bootcamp-result")
    .Replace(EduLanguage, "Uzbek")
    .Replace(OrderId, "8540")
    .Replace(Ball, "100")
    .Replace(DifferenceBall, "-1")
    .Replace(EduContractSumType, "1000000")
    .Replace(Abituriyent, "Firdavs Asadov")
    .Replace(AbituriyentId, "1111");
Console.WriteLine(formattedNotifications);
       
