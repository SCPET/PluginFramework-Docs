# DoorAccess
The DoorAccess struct is a struct used solely in the [DoorInteract](https://github.com/SCPET/PluginFramework-Docs/blob/master/PluginAPI/Events/DoorInteract.md) event.

It specifies which entities can open the door, and whether or not the door is locked.

## Locked
Get: Yes  
Set: No  
Determines whether or not the door is locked. No entities can open a door that is locked.

## SCP049
Get: Yes  
Set: No  
Determines whether or not the door can be opened by SCP-049.

## SCP096
Get: Yes  
Set: No  
Determines whether or not the door can be opened by SCP-096, while in idle mode.

## SCP173
Get: Yes  
Set: No  
Determines whether or not the door can be opened by SCP-173, while in following mode.

## SCP939
Get: Yes  
Set: No  
Determines whether or not the door can be opened by SCP-939.