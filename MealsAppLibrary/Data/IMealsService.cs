namespace MealsAppLibrary.Data;
public interface IMealsService
{
    Task<IEnumerable<Meal>> LoadMealsAsync();
}
