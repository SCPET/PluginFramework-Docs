# `PlayerDeath` - PlayerEvent
Event is invoked when a player dies. Can be disallowed to prevent the player from dying.

## `Player` Player
Get: Yes  
Set: No  
The player who died.  

## `AttackInfo` AttackInfo
Get: Yes  
Set: No  
Struct that contains attack information.  

## `GameObject` Attacker
Get: Yes  
Set: No  
The Attacker. Shorthand of `AttackInfo.Attacker`.  

## `DamageType` DamageType
Get: Yes  
Set: No  
The DamageTypes. Shorthand of `AttackInfo.Type`.  