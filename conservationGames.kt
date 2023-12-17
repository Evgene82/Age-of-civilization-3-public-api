import IsavedGame

// интерфейс сохранённой игры
// Содержит информацию о игре
interface IconservationGames
{
  // Нужно для визуального отображения
  // Название сценария
  val scenarioName : String
  // Нужно для визуального отображения
  // Название цивилизации игрока
  var civilisationName : String
  
  // Вся информация по игре
  // Тоесть год, сохранения итд
  var game : savedGame
}