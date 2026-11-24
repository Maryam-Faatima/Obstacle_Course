# Obstacle Course (Unity)

A 3D obstacle course game built in Unity. Guide the player past spinning hazards and walls to reach the finish.

## Gameplay and scripts

| Script | What it does |
|--------|--------------|
| `PlayerMovement.cs` | Player controls |
| `Spinner.cs` | Rotating hazards |
| `PlayerKilled.cs` | Handles the player hitting a hazard |
| `Finishing.cs` | Detects reaching the end of the course |

Prefabs for walls, spinners, balls, capsules and cylinders are in `Assets/Prefab`. The project also uses the Input System and Cinemachine for camera work.

## Open it

1. Install **Unity 6000.0.54f1** (Unity 6) through Unity Hub.
2. Choose *Add project from disk* and select this folder.
3. Open `Assets/Scenes/SampleScene` and press Play.

## Tech

Unity 6, C#, Input System, Cinemachine.
