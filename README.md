# Vector Extensions

This package extends the default Unity types `Vector2`, `Vector3`, `Color` and also `float` by adding utility functions to simplify conversions between them.

## Features

- Convert between `Vector2`, `Vector3`, `Color` and `float` types easily.
- Designed to integrate smoothly into any Unity project using `asmdef` files for modularity.

## Installation

### Via Unity Package Manager

1. Clone the repository or download it as a ZIP.
2. Open your Unity project.
3. Go to `Window -> Package Manager` and click the `+` button.
4. Select `Add package from git URL`.
5. Input this repo ssh URL.

### Manual Installation

1. Clone or download the repository.
2. Copy the `BitDuc` folder from `Assets/Scripts` into your project's `Assets` folder.

## Usage

Sum all components of a `Vector3` a `float`.

```csharp
var vector = new Vector3(1, 2, 3);
var result = vector.To((x, y, z) => x + y + z);
```

Convert a `Vector3` to `Vector2` ignoring the `z` component.

```csharp
var vector = new Vector3(1, 2, 3);
var result = vector.To((x, y, z) => (x, y));
```

Convert a `Vector3` to a `Color`

```csharp
var vector = new Vector3(1, 0.5f, 0.25f);
var color = vector.ToColor((r, g, b) => (r, g, b, 1.0f));
```

Convert a `Color` to grayscale

```csharp
var color = new Color(1f, 0.5f, 0.25f);

var grayscale = color
    .To(r, g, b => r * .299f + g * .587f + b * 0.114f)
    .ToColor(gray => (gray, gray, gray));
```
