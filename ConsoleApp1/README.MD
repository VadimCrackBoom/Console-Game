### Игра
class Game {

 //персонаж
 val user: User

 // Уровни
 var levels : List<Level>

 // Текущий уровень
 var currentLevel: Level?
}

### Пользователь
class User { 
 var name: String
 var hero: Hero
}

### Герой
class Hero {
  var name: String
  // Максимальное здоровье
  var health: UInt
  // Текущее здоровье
  var currentHealth: UInt
  // Сила
  var strong: Int
  // Защита
  var protected: Int
  // Уровень
  var level: UInt
  // Опыт
  var exp: UInt
  // Минимальная атака
  var minAttack: Int
  // Максимальная атака
  var maxAttack: Int
}

### Противник
class Opponent {
    var name: String
    // Максимальное здоровье
    var health: UInt
    // Текущее здоровье
    var currentHealth: UInt
    // Сила
    var strong: Int
    // Защита
    var protected: Int
    // Уровень
    var level: UInt
    // Минимальная атака
    var minAttack: Int
    // Максимальная атака
    var maxAttack: Int
}

### Босс
class Boss {
    var name: String
    // Максимальное здоровье
    var health: UInt
    // Текущее здоровье
    var currentHealth: UInt
    // Сила
    var strong: Int
    // Защита
    var protected: Int
    // Уровень
    var level: UInt
    // Минимальная атака
    var minAttack: Int
    // Максимальная атака
    var maxAttack: Int
}

### Уровень
class Level {
    var number: UInt
    var name: String
    var opponents: List<Opponent>
    var boss: Boss 
    var reward: Reward
}

### Награда
class Reward {
    // Опыт
    var exp: Int
    // Максимальное здоровье
    var health: UInt
    // Сила
    var strong: Int
    // Защита
    var protected: Int
}


