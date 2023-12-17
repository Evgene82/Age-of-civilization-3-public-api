namespace AgeOfCivilization3.PublicApi;

/// <summary>
/// Вся информация о игре
/// </summary>
public interface ISavedGame
{
	/// <summary>
	/// Количество провинций
	/// </summary>
	public int ProvincesCount { get; set; }

	/// <summary>
	/// Нынешний ход
	/// Начинается от 0
	/// </summary>
	public int Current { get; set; }

	/// <summary>
	/// Год игры
	/// </summary>
	public int Year { get; set; }

	/// <summary>
	/// Население цивилизации
	/// </summary>
	public int Population { get; set; }

	/// <summary>
	/// Обший уровень развития цивилизации
	/// </summary>
	public int Level { get; set; }

	/// <summary>
	/// Уровень армии
	/// </summary>
	public int ArmyLevel { get; set; }

	/// <summary>
	/// Уровень технологий
	/// </summary>
	public int TechnologyLevel { get; set; }

	/// <summary>
	/// Название цивилизации
	/// </summary>
	public string Name { get; set; }

	/// <summary>
	/// Правитель цивилизации
	/// </summary>
	public IKIngCiv King { get; set; }
}