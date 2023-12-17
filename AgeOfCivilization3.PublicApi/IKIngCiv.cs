using System.Collections;

namespace AgeOfCivilization3.PublicApi;

/// <summary>
/// Король цивилизации
/// Вся информация о нём
/// </summary>
public interface IKIngCiv : IEnumerable
{
	/// <summary>
	/// Дата рождения короля
	/// </summary>
	public int MinAge { get; set; }

	/// <summary>
	/// Сколько лет королю
	/// </summary>
	public int Age { get; set; }
	
	/// <summary>
	/// Дата смерти
	/// </summary>
	public int MaxAge { get; set; }
	
	/// <summary>
	/// Репутация короля
	/// От репутации зависит настроение народа и дипломатия
	/// </summary>
	public float Reputation { get; set; }
	/// <summary>
	/// Фотография короля
	/// По дефолту грузит из файлов: defaultking.png
	/// </summary>
	public byte[] Image { get; set; }
	
	/// <summary>
	/// Имя короля
	/// todo: Возможно будет изменить имя
	/// todo: еблан переформулируй нормально этот высер
	/// </summary>
	public string Name { get; set; }
	
	/// <summary>
	/// Является ли король правителем
	/// По дефолту он наследник
	/// </summary>
	public bool IsKing { get; set; }
	
	/// <summary>
	/// Список наследников
	/// </summary>
	public List<IKIngCiv> Heirs { get; set; }
	
	/// <summary>
	/// Получить наследника по имени
	/// </summary>
	/// <param name="name">имя</param>
	/// <returns>наследник если найден, null если не найден</returns>
	public IKIngCiv? GetHeir(string name) => Heirs.FirstOrDefault(k => k.Name == name);
	
	/// <summary>
	/// Убивает короля
	/// </summary>
	public void Kill();
	
	/// <summary>
	/// Перевыбирает 1 наследника
	/// Если наследник не найден, то нечего не произойдет
	/// </summary>
	/// <param name="name">имя наследника (для тех кто в танке)</param>
	public void ChoiceHeir(string name);
}