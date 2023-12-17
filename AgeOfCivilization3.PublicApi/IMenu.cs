namespace AgeOfCivilization3.PublicApi;

/// <summary>
/// Интерфейс меню
/// Содержит информацию о сохранениях и тд в меню
/// </summary>
public interface IMenu
{
	/// <summary>
	/// Список сохранённых игр
	/// Находится в формате списка
	/// </summary>
	List<IConservationGames> SaveList { get; }
}