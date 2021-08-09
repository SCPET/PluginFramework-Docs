# `Scp294DrinkBuilder`
The Scp294DrinkBuilder class can be used to build a custom SCP-294 drink.

## Constructors
### Scp294DrinkBuilder(`string` id, `params string[]` combinations)
Creates a new Scp294DrinkBuilder using the given ID and combinations. This constructor will throw a `DrinkUnavailableException` if the ID or any of the combinations are already in use.

## Methods

### `SCP294DrinkObject` Build()
Returns the drink object that was created by this builder. This object can be used in `Map.RegisterSCP294Drink(obj)` to register the drink to SCP-294.

### `Scp294DrinkBuilder` WithColor(`Color` color)
Sets the drink builder's color to the given color.

### `Scp294DrinkBuilder` WithEffect(`Scp294Effects` effect, `string[]` arguments)
Adds a drink effect with the given effect type and arguments.

### `Scp294DrinkBuilder` WithEffects(`params Scp294Effect[]` effects)
Adds all of the given drink effects to the drink builder.

### `Scp294DrinkBuilder` WithFlag(`Scp294DrinkFlag` flag)
Adds a flag to the drink builder.

### `Scp294DrinkBuilder` WithFlags(`params Scp294DrinkFlag[]` flags)
Adds all of the given flags to the drink builder.

### `Scp294DrinkBuilder` WithHealthModifier(`int` damageAmount = 0, `int` healAmount = 0)
Sets the drink builder's damage and heal amounts to the given integers, defaulting to 0 for both.

### `Scp294DrinkBuilder` WithMessage(`string` message, `float` duration = 5f, `bool` isTranslated = false)
Adds a message to the drink. If isTranslated is `true`, the `message` parameter will be intepreted as a translation key, rather than a message.


### `Scp294DrinkBuilder` WithMessages(`params DisplayableText[]` messages)
Adds all of the given messages to the drink builder.

### `Scp294DrinkBuilder` WithProperties(`bool` canBeDrank = true, `bool` drinkVisible = true)
Sets the drink builder's canBeDrank and drinkVisible properties. canBeDrank determines whether or not the drink will be refused when attempting to drink, whereas drinkVisible determines whether or not a liquid is visible in the cup.