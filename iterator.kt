// Итерирует что то
// Например делает перебор массива наследников
open interface Iiterator
{
  // Создаёт новый итератор 
  // Вернёт итератор
  fun getIter()
  
  // Делает следущий ход в итераторе
  // Если индекс: i стал больше чем длинна итерируемого массива, то прерывается
  // ++i
  fun next()
  
  // Элемент по нынешниму индексу
  // Тоесть index[i]
  var current : Any
}