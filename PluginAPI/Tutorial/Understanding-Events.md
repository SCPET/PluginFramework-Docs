# Understanding Events
An `Event` is a signal that is invoked upon an event occurring in-game. Plugin developers can attach code to execute when events are executed, which allows developers to know when things happen, and can also prevent them from happening (and implement custom behavior).  

## Accessing Events
There are two types of events in Escape Together: `ServerEvents` and `PlayerEvents`. Both event type are their own static class, which is part of the `PluginAPI.Events` namespace (`using PluginAPI.Events;`). The class name determines what events can be found there. For example, events relating to actions inputted by players will be part of the `PlayerEvents` class, whereas events relating to in-game occurrences (eg. round restarting) are part of the `ServerEvents` class.  

## Subscribing Events
An event can be subscribed to using the addition assignment operator (`+=`), and the connection can be unsubscribed using the subtraction assignment operator (`-=`). The lefthand side of the operator is the event that is part of the event class, whereas the righthand side of the operator is the method to be invoked when the event is invoked.  
  
**Example: Calling a method when a player leaves the server.**  
```cs
using PluginAPI.Events;

// Inside the plugin's OnEnabled method.
PlayerEvents.PlayerLeave += OnLeave; // This method should be defined in your code, with a parameter matching the required event arg. More info below.
```

## Event Arguments
Each event has its own event argument. Upon subscribing to an event, the IDE that you are using should inform you the event arg that is expected. All event arguments are under the `PluginAPI.Events.EventArgs` namespace (`using PluginAPI.Events.EventArgs;`). Each event argument contains properties related to the event that can be used to determine certain things about what happened.  
  
**Example: Method when a player leaves.**  
```cs
using PluginAPI.Events;
using PluginAPI.Events.EventArgs;

// Inside the plugin's OnEnabled method.
PlayerEvents.PlayerLeave += OnLeave;

// Elsewhere
private void OnLeave(PlayerLeaveEvent ev)
{
    Log.Info(ev.Player.PlayerName + " has left the server."); // The PlayerLeaveEvent parameter contains the player who left.
}
```

### Disallowing Events
All event arguments have two things in common: A property called `Finalized`, and a method called `Disallow()`. Every event (with a few exceptions) is called twice. The first call is before the event has occurred, and the second call is after it has occurred. During the first call, `Finalized` will be false, and during the second call, `Finalized` will be true. While Finalized is false, the `Disallow()` method can be called on the event arg to prevent the event from occurring. If `Finalized` is true, you can be certain that the event happenened and another plugin didn't deny it. The `Disallow()` method **WILL** throw an `InvalidOperationException` if it is called when `Finalized` is true, so ensure that this value is checked before calling it.  

**Example: Preventing Level 1 keycards from being picked up**  
```cs
using PluginAPI.Events;
using PluginAPI.Events.EventArgs;

// Inside the plugin's OnEnabled method.
PlayerEvents.PlayerPickupItem += OnPickupItem;

// Elsewhere
private void OnPickupItem(PlayerPickupItemEvent ev)
{
    if (ev.Finalized) // Since our event is denying an item pickup, we can put this call at the start to prevent doing any work if it is finalized.
    {
        return;
    }
    
    if (ev.Item.ItemId == "Keycard1") // The PlayerPickupItemEvent passes the item as an ItemBase class. The ID of the level 1 keycard is "Keycard1".
    {
        ev.Disallow(); // Prevents the event from executing.
    }
}
```
  
Some events cannot be disallowed (eg. the `PlayerLeave` event). Events that cannot be disallowed will only be called once, and `Finalized` will be true. For information as to which events cannot be disallowed, reference the event argument documentation.

## Unsubscribing Events
Events should be unsubscribed to on the plugin's `OnDisable` method, so that the connections are not lingering around even though the plugin is disabled.  
  
**Example: Unsubscribing an event when the plugin is disabled.**
```cs
public override void OnEnabled()
{
    PlayerEvents.PlayerPickupItem += OnPickupItem; // Enabling the event when the plugin is enabled.
}

public override void OnDisabled()
{
    PlayerEvents.PlayerPickupItem -= OnPickupItem; // Disabling the event when the plugin is disabled.
}
````