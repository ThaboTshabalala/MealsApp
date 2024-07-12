namespace MealsApp.Data;

public class MealsService : IMealsService
{
    public async Task<IEnumerable<Meal>> LoadMealsAsync()
    {
        Meal[] meals = [new Meal("Cheese Pizza", "Just a decent pizza with no toppings"),
        new Meal("Rice Balls", "Made with from Asia")];

        await Task.Delay(50);//server work,delay for 50 ms
        return meals;
    }
}
