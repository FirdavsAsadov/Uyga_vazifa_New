using IMTIHON;
using System.Security.Cryptography.X509Certificates;

RegistrationService regiistration = new RegistrationService();
bool ex = true;
while (ex)
{



    Console.WriteLine("   ______________________________________");
    Console.WriteLine("  /          /             /            /");
    Console.WriteLine(" / 0 - Exit /1 - Register / 2 - Display/");
    Console.WriteLine("/__________/_____________/____________/");
    var chose = Console.ReadKey().KeyChar;
    switch (chose)
    {
        case '0':
            Console.Clear();
            ex = false;
            break;
        case '1':
            Console.Clear();
            Console.WriteLine("Ismingizni kiriting: ");
            var firstName = Console.ReadLine();
            Console.WriteLine("Familyangizni kiriting: ");
            var lastName = Console.ReadLine();
            Console.WriteLine("Sharifingizni kriting: ");
            var midlename = Console.ReadLine();
            Console.WriteLine("Emailingizni kiriting: ");
            var email = Console.ReadLine();
            Console.WriteLine("Username kiriting: ");
            var username = Console.ReadLine();
            regiistration.Register(firstName, lastName, midlename, email, username);
            regiistration.SenEmail(email, username);
            break;
        case '2':
            Console.Clear();
            regiistration.Display();
            break;
        default: Console.Clear(); Console.WriteLine("Notug'ri Amal kiritildi ekranda ko'rsatilgan sonlardan foydalaning!!"); break;
    }

    /*    regiistration.Register(firstName, lastName, midlename, email, username);
    */



    
}
