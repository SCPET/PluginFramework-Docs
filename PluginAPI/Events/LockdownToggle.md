# `LockdownToggle` - ServerEvent
Event is invoked when one of the game's lockdowns (Light Containment Zone lockdown, or SCP-008 lockdown) is modified.

## `Player` Player
Get: Yes  
Set: No  
The player that modified the lockdown. This will be `null` if the lockdown is modified by the server (via plugin).

## `bool` Locked
Get: Yes  
Set: No  
If `true`, the lockdown was locked. If `false`, the lockdown was unlocked.

## `LockdownType` LockdownType
Get: Yes  
Set: No  
The type of lockdown that took place.  

## `IInteractable` Interactable
Get: Yes  
Set: No  
Contains a reference to the interactable. This will be of class `ButtonLCZCtrl` for LCZ lockdown, or `SCP008RoomLid` for SCP-008 lockdown.