# Player
The Player class contains methods that can be used to get a Player, and properties that can be changed to modify players.

## Getting Players
The below methods are static methods.

### `Player` GetPlayer(`GameObject` gameObject)
Gets a player using their GameObject, or null if the GameObject doesn't correspond with a Player.  

### `Player` GetPlayer(`IEntity` entity)
Gets a player via an IEntity interface, or null if the IEntity isn't a player.  

### `Player` GetPlayer(`long` steamId)
Gets a player by their Steam ID, or null if the Steam ID is invalid or isn't found.

### `Player` GetPlayer(`string` nickName)
Gets a player via their in-game name, or null if not found.

## Static Properties

### `Dictionary<PlayerMain, Player>` Dictionary
Get: Yes  
Set: No  
Gets a dictionary consisted of each `PlayerMain` and their corresponding `Player` class.

### `List<Player>` List
Get: Yes  
Set: No  
Gets a list of `Player`s.

### `Dictionary<ulong, Player>` SteamIdsCache
Get: Yes  
Set: No  
Gets a dictionary consisted of each Steam ID and their corresponding `Player` class.

## Fields

### `CustomDataStorage` DataStorage
Contains a reference to the player's CustomDataStorage.

### `PlayerMain` playerMain
Contains a reference to the player's `PlayerMain`.

## Properties

### `Quaternion` BaseRotation
Get: Yes  
Set: Yes  
Gets or sets a value indicating the base rotation of the player.  

### `Class` Class
Get: Yes  
Set: No  
Gets the current class of the player.  

### `int` ClassId
Get: Yes  
Set: Yes  
Gets or sets the Class ID of the player. Setting the Class ID will change the player's class.  

### `NetworkConnection` Connection
Get: Yes  
Set: No  
Gets the `NetworkConnection` that refers to this player's connection to the client.  

### `float` CrouchSpeed
Get: Yes  
Set: Yes  
Gets or sets the player's crouching speed.  

### `DimensionType` CurrentDimension
Get: Yes  
Set: Yes  
Gets or sets the player's current dimension. The dimension determines whether or not SCP-106 will attack the player, as well as keeping track of where the player is at.  

### `GameObject` GameObject
Get: Yes  
Set: No  
Gets a reference to the player's `GameObject`.  

### `bool` GodMode
Get: Yes  
Set: Yes  
Gets or sets a value indicating whether or not this player has God Mode enabled. God Mode prevents the player from taking damage.  

### `bool` HasRing
Get: Yes  
Set: No  
Gets a value indicating whether or not this player has SCP-714 equipped.  

### `float` HeadRotation
Get: Yes  
Set: Yes  
Gets or sets a value indicating the head rotation of the player.  

### `float` Health
Get: Yes  
Yes: Yes  
Gets or sets the player's health.  

### `bool` InfiniteAmmo
Get: Yes  
Set: Yes  
Gets or sets a value indicating whether or not this player has Infinite Ammo mode enabled.  

### `bool` IsBlinking
Get: Yes  
Set: Yes  
Gets or sets a value indicating whether or not this player is currently blinking.  

### `float` IsMakingSound
Get: Yes  
Set: No  
Gets a value indicating the amount of noise the player is currently producing.  

### `bool` IsMuted
Get: Yes  
Set: Yes  
Gets or sets a value indicating whether or not the player is voice muted.  

### `bool` IsValidTarget
Get: Yes  
Set: No  
Gets a value indicating whether or not this player can be targeted by SCPs.  

### `float` MaxHealth
Get: Yes  
Set: Yes  
Gets or sets a value indicating the maximum amount of health this player can have.  

### `float` MaxStamina
Get: Yes  
Set: Yes  
Gets or sets a value indicating the maximum amount of stamina this player can have.  

### `bool` NoClip
Get: Yes  
Set: Yes  
Gets or sets a value indicating whether or not this player is noclipping.  

### `bool` NoTarget
Get: Yes  
Set: Yes  
Gets or sets a value indicating whether or not this player has NoTarget mode.  

### `string` PlayerName
Get: Yes  
Set: Yes  
Gets or sets a value indicating the player's name.  

### `Vector3` Position
Get: Yes  
Set: Yes  
Gets or sets the player's position on the map.  

### `IRoom` Room
Get: Yes  
Set: No  
Gets an `IRoom` representing the room that the player is currently in. It is recommended to cache this value when appropriate, as every usage of this property performs a raycast to determine which room the player is physically located in.

### `float` SprintSpeed
Get: Yes  
Set: Yes  
Gets or sets the player's sprinting speed.  

### `float` Stamina
Get: Yes  
Set: Yes  
Gets or sets the player's stamina.

### `ulong` SteamId
Get: Yes  
Set: No  
Gets the Player's Steam ID.

### `float` WalkSpeed
Get: Yes  
Set: Yes  
Gets or sets the player's walking speed.  

## Methods

### `void` AddEffect(`IEffect` effect)  
Adds an effect to the player.  

### `void` AddHint(`string` message, `Color` color, `float` time, `HintType` type)  
Adds a hint to the player's screen, with the given message, color, time, and hint type.  

### `void` Ban(`string` reason, `TimeSpan` duration)  
Bans the player, with the given reason and duration.  

### `void` Blink()  
Forces the player to blink.  

### `void` Broadcast(`string` message, `float` duration)  
Displays a broadcast to the player, with the given message and duration.  

### `bool` CheckPermission(`string` perm)  
Returns a boolean specifying whether or not the player has the specified permission.  

### `void` ClearBroadcasts()  
Removes all broadcasts from the player's screen, and clears the broadcast queue.  

### `void` Cough()  
Plays a cough sound from the player.  

### `void` Disconnect(`string` message)  
Disconnects the player with the given message.  

### `bool` HasEffect(`string` effect)  
Determines whether or not the player has the effect with the matching name.  

### `void` Heal()  
Shorthand to set the player's health to their `MaxHealth`.  

### `void` Kill(`DeathTypes` type, `GameObject` attacker)  
Kills the player, with the specified DeathType and attacker GameObject.  

### `void` KillPlayer()  
Kills the player with the Unknown DeathType.  

### `void` Mute(`string` reason, `TimeSpan` duration)  
Mutes the player, with the given reason and duration.  

### `void` RemoveAllEffects()  
Clears all effects from the player.  

### `void` RemoveEffect(`string` effect)  
Removes the effect with the specified name, if it exists.  

### `void` SendPlayerChatMessage(`string` message)  
Sends a message to the player's chat window, with the given message and the default chat color.  

### `void` ShowStatus(`string` status)  
Sets the players status to the given status.  

### `void` TakeDamage(`float` damageAmount, `GameObject` attacker, `DeathTypes` type)  
Invokes the specified amount of damage on the player, with the given attacker and death type.  

### `void` Unmute()  
Unmutes the player if they are muted.  