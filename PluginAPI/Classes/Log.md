# Log
`static`  
The Log class contains methods used to send logs to the server console.

## `void` Info(object message)
`static`  
Sends an info log to the console.

## `void` Debug(object message, canBeSent = true)
`static`  
Sends a debug log to the console. canBeSent is an optional parameter, and the log will not be sent if its value is equal to `false`.

## `void` Warn(object message)
`static`  
Sends an warning log to the console.

## `void` Error(object message)
`static`  
Sends an error to the console.