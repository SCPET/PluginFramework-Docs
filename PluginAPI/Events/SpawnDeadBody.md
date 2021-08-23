# `SpawnDeadBody` - ServerEvent
Event is invoked when a dead body is spawned. Disallowing this event will destroy the body after it is spawned.

## `DeadBody` DeadBody
Get: Yes  
Set: No  
The body that spawned.

## `string` Name
Get: Yes  
Set: No  
The name of the body. Shorthand of `DeadBody.owner`.

## `int` Class
Get: Yes  
Set: No  
The ID of the class. Shorthand of `DeadBody.ClassId`.

## `ItemBase[]` Items
Get: Yes  
Set: No  
An array of items on the body. Shorthand of `DeadBody.items.ToArray()`.

## `void` AddItem(`ItemBase` ibase)
Adds an item to the body.  

## `void` ClearItems()
Removes all items from the body.
