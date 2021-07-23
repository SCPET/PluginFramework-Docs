# `PlaceDecal` - ServerEvent
Event is invoked when a decal is placed. Can be disallowed to prevent the decal from being placed.  

## `DecalType` DecalType
Get: Yes  
Set: No  
An enum representing the type of decal being placed.  

## `float` Size
Get: Yes  
Set: Yes  
The size of the decal.  

## `bool` Sound
Get: Yes  
Set: Yes  
Whether or not the blood drip sound should be played when the decal is placed. Only applies if the DecalType is == DecalType.Blood.  