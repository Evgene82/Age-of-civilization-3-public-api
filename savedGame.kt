import IkingCiv
import Iiterator

// Вся информация о игре
interface IsavedGame : Iiterator
{
  // Количество провинций
  var provincesCount : Int
  // Нынешний ход
  // Начинается от 0
  var current : Int
  // Год игры
  var year : Int
  // Население цивилизации
  var population : Int
  // Обший уровень развития цивилизации
  var level : Int
  // Уровень армии
  var armyLevel : Int
  // Уровень технологий
  var technologyLevel : Int
  
  // Название цивилизации
  var name : String

  // Правитель цивилизации
  var king : kingCiv
}