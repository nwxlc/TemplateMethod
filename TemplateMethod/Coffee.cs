namespace TemplateMethod;

public class Coffee : Drink
{
    private bool _isAddish;

    public Coffee(bool isAddish)
    {
        _isAddish = isAddish;
    }
    
    protected override void Brew()
    {
        Console.WriteLine("Завариваем кофе");
    }
    protected override void AddСomponents()
    {
        if (IsAddish())
        {
            Console.WriteLine("Добавляем молоко");
            
        }
        else
        {
            Console.WriteLine("Без добавок");
        }
    }

    protected override bool IsAddish()
    {
        return _isAddish;
    }
}