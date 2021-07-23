# SCP: Escape Together Plugin Framework
Welcome to the documentation for the SCP: Escape Together Plugin Framework. The Plugin Framework is made to allow plugin developers to easily and efficiently modify the game's code by overriding the code of certain events, and implementing their own logic.

## Creating a Plugin
1. If you have not already, a programming IDE and a basic understanding of C# is fundamental to mastering the plugin framework.
1. After installing a programming an IDE, create a project. The project should be a Class Library and part of the .NET 4.7.2 framework. 
1. Once the project is created, a reference to the game's Assembly-CSharp.dll is required. This can be found inside of the dedicated server files.
1. Once this reference is added, you are ready to start creating your plugin.

## Navigating the documentation
All of the plugin documentation can be found in the "PluginAPI" folder. However, some plugin API uses base game classes. In order to account for this, there is also a "BaseGame" folder, which contains some base game documentation.

The resources folder has been provided for convenience when accessing certain properties.

TODO: Add examples and such here.
