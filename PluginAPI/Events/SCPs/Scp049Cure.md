# `Scp049Cure` - ScpEvent
Event is invoked when SCP-049 spawns a zombie. Disallowing this event will prevent the SCP-008 instance from spawning.

## `SCP008` SCP008
Get: Yes  
Set: No  
A reference to the SCP-008 instance that was spawned. **This value will be `null` if Finalized is `false`.**

## `SCP049` SCP049
Get: Yes  
Set: No  
A reference to the SCP-049 that is curing.