namespace AgeOfCivilization3.PublicApi;

/// <summary>
/// интерфейс сохранённой игры
/// Содержит информацию о игре
/// </summary>
public interface IConservationGames
{
	/// <summary>
	/// Нужно для визуального отображения
	/// Название сценария
	/// </summary>
	public string ScenarioName { get; set; }

	/// <summary>
	/// Нужно для визуального отображения
	/// Название цивилизации игрока
	/// </summary>
	public string CivilisationName { get; set; }

	/// <summary>
	/// Вся информация по игре
	/// Тоесть год, сохранения итд
	/// </summary>
	public ISavedGame Game { get; set; }
}