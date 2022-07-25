var listOfUsers = new List<User>();

listOfUsers.Add(new User("ask", "Andrey", false));
listOfUsers.Add(new User("srg", "Serg", true));
listOfUsers.Add(new User("alin", "Alina", false));

foreach (var user in listOfUsers)
{
	if (user.IsPremium)
    {
		Console.WriteLine($"Hello, {user.Name}");
    } else
    {
		ShowAds();
    }
}

static void ShowAds()
{
	Console.WriteLine("Посетите наш новый сайт с бесплатными играми free.games.for.a.fool.com");
	// Остановка на 1 с
	Thread.Sleep(1000);

	Console.WriteLine("Купите подписку на МыКомбо и слушайте музыку везде и всегда.");
	// Остановка на 2 с
	Thread.Sleep(2000);

	Console.WriteLine("Оформите премиум-подписку на наш сервис, чтобы не видеть рекламу.");
	// Остановка на 3 с
	Thread.Sleep(3000);
}

class User
{
	public User(string login, string name, bool isPremium)
    {
		Login = login;
		Name = name;
		IsPremium = isPremium;
    }

	public string Login { get; set; }
	public string Name { get; set; }
	public bool IsPremium { get; set; }
}