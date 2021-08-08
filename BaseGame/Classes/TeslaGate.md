# `TeslaGate` : `NetworkBehaviour`
The `TeslaGate` class contains code for controlling a tesla gate.

## Fields

### `bool` active
Determines whether or not the tesla gate is active.

## Methods

### `void` Charge(`float` time = 0.7f)
Causes the tesla gate to begin charging up. The `time` parameter determines how long the charge lasts.

### `void` Shock()
Forces a tesla gate shock.

## RPCs

### `void` RpcPlayChargeSound()
Plays the charge sound on all nearby clients, as well as showing the charge caption to nearby players that have them enabled.

### `void` RpcPlayShockSound()
Plays the shock sound on all nearby clients, as well as showing the shock caption to nearby players that have them enabled.