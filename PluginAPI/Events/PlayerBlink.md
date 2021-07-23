# `PlayerBlink` - PlayerEvent
Event is invoked when a player blinks. Can be disallowed to prevent the player from blinking.

## `Player` Player
Get: Yes  
Set: No  
The player who blinked.  

## `bool` Forced
Get: Yes  
Set: No  
Will be `true` if the player forced a blink using a keybind, or `false` if the blink timer ran out.