# `HintType` : `Enum`
Determines to whom a caption should be shown to.

## `0` IgnoreSettings
The caption will be shown to the user regardless if their caption settings.

## `1` Speech
The caption will be shown to the user if their caption setting is "Speech Only" or "All".

## `2` All
The caption will only be shown to the user if their caption setting is set to "All".

## Determine Caption Visibility
Horizontal: User setting  
Vertical: `HintType` enum  

|                | None | Speech Only | All |   |
|----------------|------|-------------|-----|---|
| IgnoreSettings | Yes  | Yes         | Yes |   |
| Speech         | No   | Yes         | Yes |   |
| All            | No   | No          | Yes |   |
