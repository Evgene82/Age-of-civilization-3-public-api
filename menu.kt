import conservationGames

// Интерфейс меню
// Содержит информацию о сохранениях и тд в меню
interface menu
{
  // Список сохранённых игр
  // Находится в формате списка
  var saveList = mutableMapOf<conservationGames>()
}