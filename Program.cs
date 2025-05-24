//short, int, long
// short student = 30;
// int pupulationRegion = 30000;
// long earth = 7_000_000_000;
// //size
// Console.WriteLine(sizeof(short));
// Console.WriteLine(sizeof(int));
// Console.WriteLine(sizeof(long));
// //range
// Console.WriteLine(short.MaxValue);
// Console.WriteLine(int.MaxValue);
// Console.WriteLine(long.MaxValue);

// string name = "oybek";
// int year = 2007;

// string greeeting = $"welcome {name}";
// Console.WriteLine(greeeting);
// Console.WriteLine($"you probably born in {year}");

//float, double, decimal
//float ~6-9
//double ~15-16
//decimal ~26-29

// //syntax
// decimal height = 0.3;
// decimal length = 1.1;
// decimal sum = 1.4;
// Console.WriteLine(height + length == sum);

// bool isBoy = true;
// bool isGirl = false;
// //faqat true yoki false qabul qiladi
// Console.WriteLine(isBoy);



// Console.WriteLine("Enter your name ; ");
// string info = Console.ReadLine();

// string greeeting = $"welcome our website {info}";
// Console.WriteLine(greeeting);

// Console.WriteLine("enter your school number ;");
// string schoolnum = Console.ReadLine();

// Console.WriteLine($"you completed excellent school {schoolnum}");

// int a = 17;
// int b = 20;
// Console.WriteLine(a + b);

// float q = 2.5f;
// float e = 4.6f;
// float sum = q + e;
// Console.WriteLine(sum);

// short student = 20;
// int teacher = 50;
// long schools = 200;

// Console.WriteLine($"we have {student} students and also we have experianced {teacher} teachers, in our region we have {schools} schools");

// Console.WriteLine(short.MaxValue);
// Console.WriteLine(int.MaxValue);
// Console.WriteLine(long.MaxValue);

// Console.WriteLine(sizeof(short));
// Console.WriteLine(sizeof(int));
// Console.WriteLine(sizeof(long));

// decimal d = 0.7m;
// decimal f = 0.9m;
// decimal sum3 = d + f;
// Console.WriteLine(sum3);




// float pi = 3.14f;
// double bigPi = pi;
// short age = 22;
// decimal deciAge = age;
// //kichkina ma'lumot turlaridan katta ma'lumot turlariga ko'chirlyatgan payt hech qanaqa muamosiz c# amalga oshiradi
// Console.WriteLine(deciAge.ToString());
// //barcha ma'lumot turlarini stringa ko'chirsak bo'ladi.
// //implicit casting. kichkina ma'lumot turini katta ma'lumot turiga ko'chirish.
// // qanday holatlarda ishlaydi short => int =>long => float => double => decimal

// //explicit casting kattadan kichikga o'tqazganda.
// //hatolik beradi chunki biz kattaroq ma'lumot turidan kichkinaroq ma'lumot turiga ko;chiryapmiz.
// //muamoni oldini olish uchun qavs ichida ko'chiryatgon ma'lumot turimzni yozib qo'yamiz.
// //castingda nuqtadan keyin har qanday holat olib tashlanadi.

// int floraTypes = 3232;
// short smallFloratypes =(short)floraTypes;
// int piInteger = (int)bigPi;
// Console.WriteLine(piInteger);

// //coversion 

// int randomnuber = Convert.ToInt32("23");
// Console.WriteLine(randomnuber);
// //int => int32
// //short => int16
// //long => int64





// Console.WriteLine("please write your name");
// string name = Console.ReadLine();
// Console.WriteLine("enter your age");
// string age1 = Console.ReadLine();
// int agecnv = Convert.ToInt32(age1);
// Console.WriteLine($"your age is taken ! {agecnv}");


// float pi = 3.14f;
// double bigPi = pi;
// short age = 22;
// decimal deciAge = age;
// //kichkina ma'lumot turlaridan katta ma'lumot turlariga ko'chirlyatgan payt hech qanaqa muamosiz c# amalga oshiradi
// Console.WriteLine(deciAge.ToString());
// //barcha ma'lumot turlarini stringa ko'chirsak bo'ladi.
// //implicit casting. kichkina ma'lumot turini katta ma'lumot turiga ko'chirish.
// // qanday holatlarda ishlaydi short => int =>long => float => double => decimal

// //explicit casting kattadan kichikga o'tqazganda.
// //hatolik beradi chunki biz kattaroq ma'lumot turidan kichkinaroq ma'lumot turiga ko;chiryapmiz.
// //muamoni oldini olish uchun qavs ichida ko'chiryatgon ma'lumot turimzni yozib qo'yamiz.
// //castingda nuqtadan keyin har qanday holat olib tashlanadi.

// int floraTypes = 3232;
// short smallFloratypes =(short)floraTypes;
// int piInteger = (int)bigPi;
// Console.WriteLine(piInteger);

// //coversion 

// int randomnuber = Convert.ToInt32("23");
// Console.WriteLine(randomnuber);
// //int => int32
// //short => int16
// //long => int64







// Console.WriteLine("please write your name");
// string name = Console.ReadLine();
// Console.WriteLine("enter your age");
// string age1 = Console.ReadLine();
// int agecnv = Convert.ToInt32(age1);
// Console.WriteLine($"your age is taken ! {agecnv}");


Console.WriteLine("radiusni kiriting ;");
int radius = Convert.ToInt32(Console.ReadLine ());

double yuza = 3.14 * radius * radius;
double uzunlik = 2 * 3.14 * radius;
Console.WriteLine($"{radius} aylananing yuzasi; {yuza}");
Console.WriteLine($"aylananing uzunligi; {uzunlik}");


Console.WriteLine("dollorning hozirgi kursi 13.000 so'm");
Console.WriteLine("dollordan so'mga hisoblagich. dollor qiymatni kiriting;");
decimal qiymat = Convert.ToInt32(Console.ReadLine());
decimal dollor = 12_980;
decimal result = qiymat * dollor;
Console.WriteLine($"sizning kiritgan summangiz {qiymat} dollor so'mda {result}");


Console.WriteLine("Tug'ilgan yilingizni kiriting biz uni kunlarda hisoblaymiz;");
int yosh3 = Convert.ToInt32(Console.ReadLine());
int yil = 2025 - yosh3;
int tugilganKun = yil * 365;
Console.WriteLine($"sizning yillingiz kunlarda {tugilganKun} kun bo'ldi. ");

