namespace TemplateMethod;

public abstract class Drink
{
    public void Make()
    {
        BoilerWater();
        Brew();
        PourIntoMug();
        AddСomponents();
    }
    public void BoilerWater()
    {
        Console.WriteLine("Кипятим воду");
    }

    protected abstract void Brew();

    public void PourIntoMug()
    {
        Console.WriteLine("Наливаем в кружку");
    }

    protected abstract void AddСomponents();
    protected abstract bool IsAddish();
}