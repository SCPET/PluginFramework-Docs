# `PlayerExecuteCommand` - PlayerEvent
Event is invoked when a player submits a chat or admin command. Cannot be disallowed.

## `Player` Player
Get: Yes  
Set: No  
The player who invoked the command.

## `string` RawInput
Get: Yes  
Set: No  
The literal text that was inputted into the chat/admin menu without any modifications.

## `CommandInvokeInfo` InvokeInfo
Get: Yes  
Set: No  
Class that contains information about the command argument processing.

## `CommandResponse` Response
Get: Yes  
Set: No  
The response, sent from the command's `Invoke` method.

## `CommandType` CommandType
Get: Yes  
Set: No  
An enum describing the type of command.

## `CommandBase` Command
Get: Yes  
Set: No  
The commandbase. Shorthand of `InvokeInfo.command`.

## `string` CommandName
Get: Yes  
Set: No  
The name of the command. Shorthand of `InvokeInfo.CommandName`.

## `bool` HasPermission
Get: Yes  
Set: No  
Determines whether or not the invoker has proper permissions to execute the command. Shorthand of `InvokeInfo.CheckPermission(Player.playerMain)`.

## `bool` IsSuccessful
Get: Yes  
Set: No  
Whether or not the command ran successfully. Shorthand of `Response.success`.

## `bool` IsCheatCommand
Get: Yes  
Set: No  
Returns whether or not the command is marked as a cheat command. Shorthand of `Response.isCheat`.

## `string` ResponseMessage
Get: Yes  
Set: No  
The command response message. Shorthand of `Response.message`.

## `T` GetArgument<T>(`int` index)
Get: Yes  
Set: No  
Returns an argument. The generic argument must be "string", "bool", "long", "int", or "float". Shorthand of `InvokeInfo.GetArgument<T>(index)`.