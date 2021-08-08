# `IHuman` : `IDamageable`
This interface refers to a human. This can be any human, including player-controlled and AI humans. This interface is present on the `PlayerMain` class.

## Fields

### `DimensionType` CurrentDimension
Defines the dimension that the human is present in.

### `bool` IsValidTarget
Determines whether or not this human can be targeted by SCPs and other entities.

### `bool` GodMode
Determines whether or not this human can take damage.

### `GameObject` rot
Determines the GameObject used for rotation.

### `bool` IsBlinking
Determines whether or not this human is currently blinking, allowing SCP-173 to move.

### `float` IsMakingSound
Determines the amount of sound that the human is making.

### `bool` IsInSafeZone
Determines whether or not the human is in a safe zone.

### `SafeZoneTrigger` CurrentSafeZone
Contains a reference to the safe zone the human is in.

## Methods
### `bool` CanTarget(`NPCData` npc)
Returns a value indicating whether or not the given NPC can target this human.