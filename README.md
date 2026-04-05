# NASA Food App

A Unity-based food recipe browser that lets you explore meals by category, search by ingredient or name, and navigate ingredient hierarchies.

## Features

- **Browse Meals by Category** – View meals organized into categories such as Top Meals, Meat, Vegetarians, and Deserts.
- **Search** – Find meals by name, ingredient, or category.
- **Recipe Details** – See full meal information including description, preparation steps, and ingredient list.
- **Ingredient Hierarchy** – Navigate the parent-child taxonomy of ingredients (e.g., Edible → Plants → Corn → Corn Oil).
- **Related Meals** – Discover other meals that share the same ingredients.
- **Web Images** – Meal images are loaded and cached from remote URLs.

## Requirements

| Tool | Version |
|------|---------|
| Unity | 5.4.0f3 |
| .NET / Mono | Compatible with Unity 5.4 |

> **Note:** The project uses the legacy `WWW` class for image loading. Upgrading to a newer Unity version may require migrating to `UnityWebRequest`.

## Getting Started

### 1. Clone the repository

```bash
git clone https://github.com/omar92/NASA-Food-APP.git
```

### 2. Open in Unity

1. Launch **Unity Hub** (or the Unity Editor directly).
2. Click **Open** and navigate to the cloned `NASA-Food-APP` folder.
3. Unity will import assets and generate the `Library/` folder automatically — this may take a few minutes on the first open.

### 3. Open the main scene

In the **Project** panel, navigate to:

```
Assets/AppManager.unity
```

Double-click `AppManager.unity` to load the scene.

### 4. Run the app

Click the **Play** button (▶) in the Unity Editor toolbar to launch the app in the Game window.

## Project Structure

```
NASA-Food-APP/
├── Assets/
│   ├── AppManager.unity          # Main scene
│   ├── Ressources/
│   │   ├── Fonts/                # HindMadurai & MING font families
│   │   └── UI/                   # UI icons (search, download)
│   └── Scripts/
│       ├── Components/
│       │   ├── AppManager.cs     # App entry point & category initialization
│       │   ├── DescriptionScript.cs  # Meal detail view
│       │   ├── HirarchyScript.cs # Ingredient hierarchy navigator
│       │   ├── IItem.cs          # Item interface
│       │   ├── ItemScript.cs     # Individual meal UI element
│       │   ├── RowScript.cs      # Horizontal category row
│       │   └── SearchScript.cs   # Search query handler
│       └── HelperScripts/
│           ├── DataManager.cs    # Central data store & query engine
│           └── ImagesManager.cs  # Web image loader with caching
├── ProjectSettings/              # Unity project configuration
└── .gitignore
```

## How to Use

### Browsing Meals

On launch the app displays meals grouped by category in horizontal scrollable rows. Scroll left/right within a row to see more meals in that category.

### Searching

1. Tap or click the **search icon** in the top bar.
2. Type a meal name, ingredient name, or category name into the search field.
3. Matching meals appear in real time as you type.

### Viewing a Recipe

Click any meal card to open its detail view, which shows:
- Meal name and image
- Description and preparation instructions
- Full ingredient list
- Related meals (meals sharing at least one ingredient)

### Exploring Ingredient Hierarchy

Inside a recipe's detail view, tap any ingredient to open the **Hierarchy** panel. This panel shows the ingredient's family tree — its parent category and sibling ingredients — so you can discover related items.

## Dependencies

| Library | Purpose |
|---------|---------|
| [LitJson](https://lbv.github.io/litjson/) | JSON serialization / deserialization |
| [SmartFox2X](http://www.smartfoxserver.com/) | Real-time networking (SFSObject API used for data modeling) |
| ScrollRectEx | Custom nested scroll rect for smooth UI scrolling |

These libraries are included as pre-compiled DLLs under `Assets/Scripts/PLugins/`.

## Building

1. Go to **File → Build Settings**.
2. Select your target platform (PC, Mac, WebGL, Android, iOS, etc.).
3. Click **Switch Platform**, then **Build** (or **Build and Run**).

Default resolution is **1024 × 768** (desktop) and **960 × 600** (web).

## License

This project was developed as an educational prototype. No explicit license is provided — please contact the repository owner before using it in production.
