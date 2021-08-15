# `Scp294InsertQuarter` - ScpEvent
Event is invoked when a quarter is inserted into SCP-294. Disallowing this event will prevent the quarter from being inserted (the item will still remain in the player's inventory & hand).

## `SCP294Controller` SCP294
Get: Yes  
Set: No  
A reference to the SCP-294 that received a quarter.

## `Player` Player
Get: Yes  
Set: No  
The player who inputted a quarter.

## `int` QuarterCount
Get: Yes  
Set: No  
Determines how many quarters have been inserted into the machine, including this one. This value will either be `1` or `2`. If it is `1`, the machine still requires an additional quarter. If this is `2`, there are enough quarters for the machine to dispense a drink.