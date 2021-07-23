# `PlayerDamage` - PlayerEvent
Event is invoked when a player takes damage. Can be disallowed to prevent the damage from being taken.

## `Player` Player
Get: Yes  
Set: No  
The player who took damage.  

## `AttackInfo` AttackInfo
Get: Yes  
Set: No  
Struct that contains attack information.  

## `float` Damage
Get: Yes  
Set: No  
The amount of damage that was taken. Shorthand of `AttackInfo.Damage`.  

## `GameObject` Attacker
Get: Yes  
Set: No  
The Attacker. Shorthand of `AttackInfo.Attacker`.  

## `DamageType` DamageType
Get: Yes  
Set: No  
The DamageTypes. Shorthand of `AttackInfo.Type`.  