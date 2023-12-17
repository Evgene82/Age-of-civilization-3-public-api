import IconservationGames

// Интерфейс меню
// Содержит информацию о сохранениях и тд в меню
interface Imenu
{
  // Список сохранённых игр
  // Находится в формате списка
  var saveList = mutableMapOf<IconservationGames>()
}