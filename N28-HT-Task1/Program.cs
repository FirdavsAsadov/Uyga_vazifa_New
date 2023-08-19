using N28_HT_Task1;

var userService = new UserService();
userService.Add("akestostoboy@gmail.com","QgGuio0770Qa");
userService.Add("Qodirali@gmail.com","Qodir7229");
userService.GetUser().ForEach(x => Console.WriteLine($"{x.Id} - {x.EmailAdress} - {x.Password} - {x.isAdmin}"));