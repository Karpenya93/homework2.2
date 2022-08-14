Dictionary<string,string> translate=new Dictionary<string,string>()
{
    { "green","Зеленый"},
    { "yellow", "Желтый"},
    { "blue", "Синий"},
    { "garden", "Сад"},
    { "milk", "Молоко"},
    { "mouse", "Мышь"},
    { "vodka", "Водка"},
    { "dog", "Пес"},
    { "cat", "Кошка"},
    { "Game", "Игра"},
    { "car", "Машина"},

};

while (true)
{
    string word = Console.ReadLine().ToLower();
    if (translate.ContainsKey(word))
    {
        Console.WriteLine(translate[word]);
    }
    else Console.WriteLine("Такого значения нету ");
}


