namespace MealsApp.Data;
public interface IMealsService
{
    Task<IEnumerable<Meal>> loadMealsAsync();
}
