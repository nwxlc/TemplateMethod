namespace TemplateMethod;

public class Tea : Drink
{
    private bool _isAddish = true;

    protected override void Brew()
    {
        Console.WriteLine("Завариваем чай");
    }
    protected override void AddСomponents()
    {
        if (IsAddish())
        {
            Console.WriteLine("Добавляем лимон");
        }
    }

    protected override bool IsAddish()
    {
        return _isAddish;
    }
}