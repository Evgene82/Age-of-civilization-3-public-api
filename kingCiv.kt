import iterator

// Король цивилизации
// Вся информация о нём
interface kingCiv : iterator
{
  // Дата рождения короля
  val minAge : Int
  // Сколько лет королю
  var age : Int
  // Дата смерти
  var maxAge : Int
  
  // Репутация короля
  // От репутации зависит настроение народа и дипломатия
  var reputation : Float

  // Фотография короля
  // По дефолту грузит из файлов: defaultking.png
  val image : BufferedImage 
  
  // Имя короля
  // todo: Возможно будет изменить имя
  val name : String
  
  // Является ли король правителем
  // По дефолту он наследник
  var isKing : Boolean

  // Список наследников
  var heirs = mutableMapOf<kingCiv>()
  
  // Получить наследника по имени
  // Вернет наследника в формате kingCiv
  // Если наследник не будет найден, вернёт false
  fun getHeir(name : String)
  
  // Убивает короля
  fun kill()
  
  // Перевыбирает 1 наследника
  // Если наследник не найден, то нечего не произойдет
  fun choiceHeir(name: String)
}