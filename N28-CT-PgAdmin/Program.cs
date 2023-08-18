using N28_CT_PgAdmin;
using Npgsql;

var db = new EFCoreContext();
var person1 = new Person("firdavs","firdavsasadov@gmail.com",34);

db.People.Add(person1);
db.SaveChanges();
/*string sqlquery = "SELECT * FROM person";
using (var cmd = new NpgsqlCommand(sqlquery,)) ;*/
/*var service = new PersonService(db);
db.Add("jasur");
db.*/