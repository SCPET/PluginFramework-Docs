# `Scp294Input` - ScpEvent
Event is invoked when an input is entered into SCP-294. Disallowing the event will prevent SCP-294 from responding to the input.

## `SCP294Controller` SCP294
Get: Yes  
Set: No  
A reference to the SCP-294 that was inputted into.

## `Player` Player
Get: Yes  
Set: No  
The player who inputted an input into SCP-294.

## `string` Input
Get: Yes  
Set: No  
The input that was inputted by the player.

## `bool` IsValidDrink
Get: Yes  
Set: No  
Determines whether or not the input exists as a drink, or if it is out of range. If this is `true`, and the event isn't disallowed, a drink will spawn. If this is `false`, and the event isn't disallowed, the machine will display "Out of Range".

## `bool` IsCustomDrink
Get: Yes  
Set: No  
If `IsValidDrink` is true, this property determines whether or not the drink was added or modified by a plugin.