# Player
The Player class contains methods that can be used to get a Player, and properties that can be changed to modify players.

## Getting Players

### `Player` GetPlayer(`GameObject` gameObject)
Gets a player using their GameObject, or null if the GameObject doesn't correspond with a Player.  

### `Player` GetPlayer(`IEntity` entity)
Gets a player via an IEntity interface, or null if the IEntity isn't a player.  

### `Player` GetPlayer(`long` steamId)
Gets a player by their Steam ID, or null if the Steam ID is invalid or isn't found.

### `Player` GetPlayer(`string` nickName)
Gets a player via their in-game name, or null if not found.

## Properties

### `Quaternion` BaseRotation
Get: Yes  
Set: Yes  
Gets or sets a value indicating the base rotation of the player.  

### `Class` Class
Get: Yes  
Set: No  
Gets the current class of the player.  

### `int` ClassID
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

### `float` SprintSpeed
Get: Yes  
Set: Yes  
Gets or sets the player's sprinting speed.  

### `float` Stamina
Get: Yes  
Set: Yes  
Gets or sets the player's stamina.

### `long` SteamID
Get: Yes  
Set: No  
Gets the Player's Steam ID.

### `float` WalkSpeed
Get: Yes  
Set: Yes  
Gets or sets the player's walking speed.  