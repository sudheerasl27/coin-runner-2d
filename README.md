### Repository Name Suggestions

* **`coin-runner-2d`** (Standard, clean, and descriptive)
* **`unity2d-coin-runner`** (Highlights the engine and project genre)
* **`coin-runner-platformer`** (Emphasizes gameplay mechanics)

---

### `README.md`

```markdown
# Coin Runner 2D

A classic 2D platformer game built with **Unity 6** and **C#**. Players navigate tile-based levels, jump across platforms with precision physics, avoid hazards, and collect coins tracked via a real-time UI.

---

## Features

- **Physics-Based Movement:** Custom 2D character controller handling horizontal motion and single-jump mechanics using `Rigidbody2D` and `CapsuleCollider2D`.
- **Accurate Ground Check:** Overlap circle detection (`Physics2D.OverlapCircle`) with customizable radius and `OnDrawGizmos` visualization to prevent mid-air multi-jumping.
- **Dynamic Camera Follow:** Smooth tracking camera (`Vector3.SmoothDamp`) centered on the player with custom offsets.
- **Coin Collection System:** Trigger-based (`OnTriggerEnter2D`) coin pickups tagged for collision detection.
- **Centralized Game Loop:** Singleton `GameManager` managing score states, real-time TextMeshPro UI updates, and scene reloading.
- **Modular Level Design:** Built with Unity's 2D Grid, Tilemaps, and composite colliders.

---

## Tech Stack & Engine Specifications

- **Engine:** Unity 6 (6000.x)
- **Language:** C# (.NET Standard 2.1)
- **Input System:** Both / Legacy Input Manager (`Input.GetAxisRaw`, `KeyCode.Space`)
- **Rendering:** Universal Render Pipeline (URP 2D) / 2D Sprite-Lit
- **UI:** TextMeshPro (TMP) with dynamic canvas scaling (1920x1080 reference resolution)

---

## Project Structure

```text
Assets/
├── Prefabs/             # Reusable objects (Coin, Hazards, UI Panels)
├── Scenes/              # Game level scenes (SampleScene)
├── Scripts/             # C# source files
│   ├── CameraFollow.cs          # Smooth camera tracking
│   ├── GameManager.cs           # State management & score tracking
│   ├── PlayerInteractions.cs    # Collision/Trigger detection
│   └── PlayerMovement.cs        # Input handling & ground check logic
├── Sprites/             # 2D visual assets & palettes
└── TextMesh Pro/        # Fonts and UI styling assets

```

---

## Getting Started

### Prerequisites

* [Unity Hub](https://unity.com/download)
* Unity Editor version **6000.0.x** (or compatible Unity 6 LTS release) with the **Universal Windows / Mac / Linux Standalone Build Support** module.

### Installation & Setup

1. **Clone the repository:**
```bash
git clone [https://github.com/](https://github.com/)<your-username>/coin-runner-2d.git

```


2. **Open in Unity Hub:**
* Launch Unity Hub.
* Click **Add** -> **Add project from disk**.
* Select the cloned root directory.
* Ensure the Unity version matches **Unity 6**.


3. **Open the Scene:**
* Navigate to `Assets/Scenes/SampleScene.unity` and open it.


4. **Play the Game:**
* Press the **Play (▶)** button in the Unity Editor toolbar.



---

## Controls

| Action | Key Binding |
| --- | --- |
| **Move Left** | `A` or `Left Arrow` |
| **Move Right** | `D` or `Right Arrow` |
| **Jump** | `Space` |

---

## Mechanics Overview

### Ground Detection

```csharp
isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundRadius, groundLayer);

```

Character jump capability is validated every frame by sampling an overlap sphere at the base of the player's collision bounds against a dedicated `Ground` layer mask.

### Score Synchronization

```csharp
public void AddCoin()
{
    coins++;
    UpdateCoinUI();
}

```

Trigger-based pickups notify the static `GameManager` instance, cleanly separating player collision logic from UI and data persistence.

---

## License

This project is licensed under the [MIT License](https://www.google.com/search?q=LICENSE).

```

<FollowUp>Would you like to add automated build instructions, a screenshot section, or hazards/win-state documentation to the README?</FollowUp>

```
