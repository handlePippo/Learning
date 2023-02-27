using static Theory.OOP.Syntax;


Person filippo = new Person("Filippo", 25);
filippo.Phone = "3938904156";

Person samuele = new Person("Samuele", 24, "3938904157", "1234");

Console.WriteLine("Il pin di samuele e' " + samuele.Pin);
Console.ReadKey();

