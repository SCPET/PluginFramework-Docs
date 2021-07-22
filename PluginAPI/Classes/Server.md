## Server
The Server class contains properties used to modify the server.

### `int` Gamemode
Static  
Get: Yes  
Set: Yes  
Determines the gamemode that the server is currently utilizing.

### `bool` IsDedicated
Static  
Get: Yes  
Set: Yes  
Determines if this server is a dedicated server.

### `bool` IsOutdated
Static  
Get: Yes  
Set: No  
Determines if this server is running on an outdated game version.

### `bool` IsPublic
Static  
Get: Yes  
Set: No  
Determines if this server is publicly available on the serverlist.

### `string` MapName
Static  
Get: Yes  
Set: No  
Determines the name of the map.

### `int` MaxPlayers
Static  
Get: Yes  
Set: No  
Determines the maximum amount of players on the server.

### `string` PlayerlistTitle
Static  
Get: Yes  
Set: Yes  
Determines the name of the server that is displayed at the top of the serverlist.

### `int` PlayersOnline
Static  
Get: Yes  
Set: No  
Gets a value indicating the amount of players currently on the server.

### `void` SendChatMessage(`string` message)
Static  
Sends a server message to all clients.