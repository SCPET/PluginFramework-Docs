# Custom SCP-294 Drinks
This tutorial will go over creating SCP-294 drinks using plugins.

## Prerequisites
Before following this tutorial, you should have an understanding of SCP: Escape Together events. See [this tutorial](https://github.com/SCPET/PluginFramework-Docs/blob/master/Tutorial/Understanding-Events.md) for more information.  

## Overview
The SCP: Escape Together framework provides a class called `Scp294DrinkBuilder`, which allows plugins to create custom drink. Drinks have to be created and registered **every round**. The best event to use for this is the `RoundStart` event, which is part of the `ServerEvents` class.  

## Plugin Setup

```cs
using PluginAPI;

public override void OnEnabled()
{
    ServerEvents.RoundStart += RegisterDrinks;
}

public override void OnDisabled()
{
    ServerEvents.RoundStart -= RegisterDrinks;
}

void RegisterDrinks()
{
    // Create drinks here
}
```

The Scp294DrinkBuilder has one constructor, which takes an ID of a drink, and a params away of combinations that can be entered into SCP-294 to retrieve the drink. Both the ID and all of the combinations must not conflict with another drink. Conflicts with other drinks will throw a `DrinkUnavailable` exception.  
  
After the drink has been constructed, there are various methods to configure the drink. All of the methods return the object, which means that methods can be chained together.  

```cs
using PluginAPI;

// Creating a drink called "lava", with the color orange, that instantly kills the player and displays an "It burns!" message.
void RegisterDrinks()
{
    Scp294DrinkBuilder lavaBuilder = new Scp294DrinkBuilder("lava", "lava", "magma") // Creates a drink builder with id "lava" and combinations "lava" and "magma".
        .WithColor(new Color(237f/255f, 161f/255f, 62f/255f)) // Sets the color.
        .WithHealthModifier(100, 0) // Deal 100 damage, heal 0.
        .WithMessage("It burns!", 5f) // Display "It burns!" message for 5 seconds.
        .WithFlags(Scp294DrinkFlag.Nongeneric, Scp294DrinkFlag.Deadly); // Flags (see below)
}
```
The above example would create the lava drink. The flags are added to tell the server what kind of drink this is; in this case, it is deadly and non-generic. Because server configs use flags to determine what drinks are and aren't allowed on the server, it is important that the flags are set appropriately.  

The last step to adding a drink is registering it. This can be done via the `Map.RegisterSCP294Drink()` method.  

```cs
using PluginAPI;

void RegisterDrinks()
{
    ...
    DrinkRegisterResult result = Map.RegisterSCP294Drink(lavaBuilder.Build());
}
```
This method returns a `DrinkRegisterResult` struct, which gives information about whether or not the register was successful. If it was successful, the drink is now available in SCP-294.  
  
For more information about the Scp294DrinkBuilder class, see [its documentation](https://github.com/SCPET/PluginFramework-Docs/blob/master/PluginAPI/Helpers/Scp294DrinkBuilder.md).