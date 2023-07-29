Person[] persons =
{
    new Person(){Name="タロー",FavItem= Favourite.ミカンが好き},
    new Person(){Name="ジロー",FavItem= Favourite.リンゴが好き},
    new Person(){Name="ハナコ",FavItem= Favourite.メロンが好き|Favourite.リンゴが好き},
};

Console.WriteLine("リンゴが好きな人は");
foreach (Person person in persons)
{
    if ((person.FavItem & Favourite.リンゴが好き) != 0) Console.WriteLine(person.Name);
}

enum Favourite
{
    ミカンが好き = 1,
    リンゴが好き = 2,
    メロンが好き = 4,
}
class Person
{
    internal string? Name;
    internal Favourite FavItem;
}
