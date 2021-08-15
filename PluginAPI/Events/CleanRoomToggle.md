# `CleanRoomToggle` - ServerEvent
Event is invoked when a clean room is turned on or off. Disallowing this event will prevent the clean room from being toggled on or off.

## `Player` Player
Get: Yes  
Set: No  
The player that toggled the clean room.  

## `CleanRoomController` CleanRoom
Get: Yes  
Set: No  
Gets the clean room that was toggled.  

## `CleanRoomDisable` Button
Get: Yes  
Set: No  
Contains a reference to the `IInteractable` that was interacted with to disable the clean room.

## `bool` IsDisabling
Get: Yes  
Set: No  
If `true`, the clean room is being disabled. If `false`, it is being re-enabled.  