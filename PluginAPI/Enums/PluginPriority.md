##  `PluginPriority` : `Enum`
Determines the priority of the plugin, which will define the loading order.

### `-2147483648` Lowest
Lowest priority. These plugins will be loaded last. Same as `Last`.

### `-2147483648` Last
Lowest priority. These plugins will be loaded last. Same as `Lowest`.

### `-500` Lower
Low priority.

### `-250` Low
Medium-low priority.

### `0` Default
Default plugin priority.

### `0` Medium
Middle-high priority.

### `250` High
High priority.

### `500` Higher
Higher priority.

### `2147483647` Highest
Highest priority. These plugins will be loaded first. Same as `First`.

### `2147483647` First
Highest priority. These plugins will be loaded first. Same as `Highest`.