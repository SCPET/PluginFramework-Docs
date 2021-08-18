## `Plugin<TConfig>` : `IPlugin<TConfig>`
`Abstract`  
Plugin class represents the base class for all plugins, as well as the entry point for the plugin's source code. Each plugin needs to have one class that inherits from the Plugin class in order to function. The plugin class must have an `OnEnabled` override, as well as an `OnDisabled` override that undoes what `OnEnabled` does.  

## Virtual Properties

### `string` Name 
Determines the name of the plugin. The name will default to the assembly's name.  

### `string` Author
Determines the author of the plugin. The author will default to the assembly's company name.  

### `PluginPriority` Priority
Determines the priority of the plugin. [PluginPriority info](https://github.com/SCPET/PluginFramework-Docs/blob/master/PluginAPI/Enums/PluginPriority.md).  

### `Version` Version
Determines the current version of the plugin. The version will default to the assembly's version, and must change for **every** update, as server hosts use this to determine when their plugin is outdated.  

### `Version` RequiredVersion
Determines the minimum game version that is required in order for this plugin to function properly.  

## Virtual Methods

### `void` OnEnabled()
OnEnabled is called when the plugin is started by the server. This method is called while the server is booting up. All event connections should be connected in this method.  

### `void` OnDisabled()
OnDisabled is called when the plugin is disabled by the server. This method is called when the server is shutting down, or the plugin is disabled by a server staff member. All event connections should be disconnected in this method.  

## Properties
### `Assembly` Assembly
Get: Yes  
Set: No  
Contains a reference to this plugin's assembly.  

### `string` FolderPath
Get: Yes  
Set: No  
Contains a string specifying the path of this plugin's plugin folder (which contains the config file, as well as files placed by the plugin).