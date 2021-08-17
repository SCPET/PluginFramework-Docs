# `DoorInteract` - ServerEvent
Event is invoked when a player interacts with a door successfully. Can be disallowed to prevent the door interaction.

## NOTICE: AT THE MOMENT, THIS EVENT WILL NOT BE INVOKED. THIS WILL BE FIXED IN A LATER SCP:ET UPDATE.

## `IEntity` Entity
Get: Yes  
Set: No  
The entity that interacted with the door.  
Remarks:  
* This will be null if `InteractionType` is `Other`, `Admin`, `Elevator`, `AirlockAuto`, or `CleanRoomAuto`.
* If `InteractionType` is `Player`, this will be a PlayerMain type (which can be used in `Player.Get(Entity)`).
* If `InteractionType` is `SCP049`, this will be an `SCP049` type.
* If `InteractionType` is `SCP096`, this will be an `SCP096` type.
* If `InteractionType` is `SCP173` OR `SCP173Wandering`, this will be an `SCP173` type.
* If `InteractionType` is `SCP939`, this will be an `SCP939` type.

## `Door` Door
Get: Yes  
Set: No  
The door that was interacted with.  

## `DoorInteractionType` InteractionType
Get: Yes  
Set: No  
The type of interaction that took place.  

## `bool` IsClose
Get: Yes  
Set: No  
If this is `true`, the door is being closed.  Otherwise the door is being opened.

## `bool` IsNPCOrPlayer
Get: Yes  
Set: No  
Determines whether or not the door is being opened by a player or by an entity. If this is `true`, the `Entity` property will not be null.

## `string` DoorName
Get: Yes  
Set: No  
Gets the name of the door. Shorthand of `Door.doorName`.

## `DoorType` DoorType
Get: Yes  
Set: No  
Gets the door type. Shorthand of `Door.doorType`.  

## `DoorAccess` Access
Get: Yes  
Set: No  
Gets a struct representing who can open the door and whether or not it's locked.