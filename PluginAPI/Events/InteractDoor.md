# `DoorInteract` - ServerEvent
Event is invoked when a player interacts with a door. Can be disallowed to prevent the door interaction.

## NOTICE: AT THE MOMENT, THIS EVENT WILL NOT BE INVOKED. THIS WILL BE FIXED IN A LATER SCP:ET UPDATE.

## `IEntity` Entity
Get: Yes  
Set: No  
The entity that interacted with the door.  

## `Door` Door
Get: Yes  
Set: No  
The door that was interacted with.  

## `DoorInteractionType` InteractionType
Get: Yes  
Set: No  
The type of interaction that took place.  

## `DoorType` DoorType
Get: Yes  
Set: No  
Gets the door type. Shorthand of `Door.doorType`.  

## `DoorAccess` Access
Get: Yes  
Set: No  
Gets a struct representing who can open the door and whether or not it's locked.