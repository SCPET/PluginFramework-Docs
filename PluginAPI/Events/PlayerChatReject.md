# `PlayerChatReject` - PlayerEvent
Event is invoked when a player sends a chat message, and is automatically rejected. Can be disallowed to prevent the chat message from being sent.

## `Player` Player
Get: Yes  
Set: No  
The player who sent a chat message.  

## `string` Message
Get: Yes  
Set: No  
The message that the player attempted to send.  

## `RejectReason` ChatRejectReason
Get: Yes  
Set: No  
Gets the reason why the chat message was rejected.  