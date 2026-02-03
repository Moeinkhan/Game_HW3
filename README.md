# Pepsi Man Runner

## Project Introduction
This project is a 3D endless runner game inspired by **Pepsi Man**, developed using **Unity 3D** and **C#**.  
The goal of the project is to practice core game development concepts such as player movement, obstacle handling, environment generation, scoring systems, and UI integration.

In this game, the player character remains in a fixed position while the environment and obstacles move toward the player, creating a continuous running effect. The player must switch between lanes to avoid obstacles and achieve a higher score.

---

## How to Run the Game
### Running from Unity Editor
1. Open the project using **Unity Hub**.
2. Make sure you are using a compatible Unity 3D version.
3. Open the scene named **GameScene** from the `Scenes` folder.
4. Press the **Play** button in Unity to start the game.

### Running the Built Version
A playable build of the game is available in the **Releases** section of this GitHub repository.

👉 **Download the latest build from here:**  
[GitHub Release v1.0.0](https://github.com/Moeinkhan/Game_HW3/releases/tag/v1.0.0)

1. Go to the **Releases** tab.
2. Download the latest build for your operating system.
3. Extract the files.
4. Run the executable file to start the game.

---

## Controls
- **A / Left Arrow** → Move to the left lane  
- **D / Right Arrow** → Move to the right lane  

The player can only move between three lanes: left, middle, and right.

---

## Gameplay Overview
- The environment and obstacles move toward the player to simulate forward motion.
- Obstacles are placed inside environment chunks and generated dynamically.
- The game speed gradually increases over time, making the gameplay more challenging.
- The score increases continuously and scales with the game speed.
- The best score is saved using Unity’s `PlayerPrefs` system.
- When the player collides with an obstacle, the game enters a **Game Over** state.
- A Game Over panel appears, allowing the player to restart the game.

---

## Summary of Work Done
- Implemented lane-based player movement.
- Designed a chunk-based environment generation system.
- Added dynamic difficulty by increasing game speed over time.
- Implemented a scoring system with best score persistence using PlayerPrefs.
- Created a simple and clear UI including score display and Game Over panel.
- Integrated background music that starts with the scene and stops on Game Over.

---

## Notes
This project was developed as part of the **Video Game Design course at Iran University of Science and Technology (IUST)**.
