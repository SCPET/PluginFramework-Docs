# `Scp914UpgradeItem` - ScpEvent
Event is invoked when an item is refined. If the event is disallowed, the item will still teleport into the output booth but will not be modified.

## `SCP914` SCP914
Get: Yes  
Set: No  
A reference to the SCP-914 that was upgrading.

## `ItemBase` Item
Get: Yes  
Set: No  
The item that is being upgraded. If Finalized is `false`, this is a reference to the item that was dropped in the SCP-914 Intake booth. If Finalized is `true`, this will be `null`, and `NewItem` should be used instead.

## `ItemType` ItemType
Get: Yes  
Set: No  
The ItemType that is being upgraded. This value will remain the same, regardless of the Finalized status.

## `Scp914Setting` Setting
Get: Yes  
Set: No  
The setting that the item is being refined in.

## `ItemType` NewItemType
Get: Yes  
Set: Yes  
The new item type. This value will remain the same, regardless of the Finalized status. This value can be set if Finalized is `false`, which will change the outcome of the item. This value will throw an `InvalidOperationException` if set when Finalized is `true`.

## `ItemBase` NewItem
Get: Yes  
Set: No  
The new item, after it is upgraded. If Finalized is `false`, this will be `null` and `Item` should be used instead. If Finalized is `true`, this will be the new item in the SCP-914 Output booth.