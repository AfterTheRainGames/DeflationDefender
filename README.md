# Deflation Defender  
**Game Jam Submission**  
*DEFENSE Theme | Limitation: Only 1 Resource | December 20-22, 2024*

## Overview  
Deflation Defender flips the tower defense genre on its head by letting the player embody the balloons instead of the towers. As a balloon with a protective shield, you navigate a 3D-styled 2D track while evading tower attacks.  

---

## Key Contributions as a Gameplay Engineer  
- **Concept Development**  
  - Reversed the traditional tower defense roles, allowing players to play as balloons with a shield, incorporating the "Only 1 Resource" limitation.  

- **Pathfinding and Movement**  
  - Developed a 2D pathing system using `OnTriggerEnter` events to manage turns.  
  - Implemented a `bool`-based system for continuous rotation, ensuring smooth transitions around corners.  

- **Shield Mechanics**  
  - Coded shield movement tied to mouse input, enabling dynamic projectile blocking.  

- **Tower and Projectile Logic**  
  - Created turret prefabs with randomized fire rates.  
  - Programmed projectiles to track the player's real-time position and added responsive collision systems for damage and blocking.  

- **Level Design**  
  - Designed two thematic levels (grass and winter) using Unity's tile snapping tools and asset packs.  
  - Utilized prefab-based design to streamline multi-level creation.  

- **UI and Audio**  
  - Built a dynamic main menu and level select interface.  
  - Integrated sound effects for player interactions and background music to enhance immersion.  

- **Build Optimization**  
  - Fixed aspect ratio and scaling issues for consistent gameplay across window sizes.  

---

## Challenges Overcome  

- **Turning at Path Bends**  
  - **Issue**: Player began turning correctly but never stopped due to incomplete `OnTriggerEnter` logic.  
  - **Solution**: Introduced a `bool` (`isTurning`) to manage continuous rotation in `Update`, toggled by triggers.  

- **Projectile Tracking**  
  - **Issue**: Bullets targeted the player's spawn point instead of their updated position.  
  - **Solution**: Used `GameObject.FindByName` to dynamically track the player's current location.  

- **Window Scaling**  
  - **Issue**: Resizing the game window revealed off-screen elements like spawn points.  
  - **Solution**: Fixed the camera aspect ratio to 16:9 and configured scaling for consistent visuals.  

- **Bullet-Spawning Collisions**  
  - **Issue**: Turret bullets collided with other towers upon spawning.  
  - **Solution**: Removed tower colliders to prevent premature destruction of bullets.  

---

## Reflection  
Deflation Defender challenged me to adapt my skills to a 2D environment while leveraging 3D assets and solving nuanced gameplay issues, such as turning mechanics and real-time player tracking. The result was a unique take on tower defense, showcasing creativity and technical proficiency under time constraints.  

---

## Play the Game  
[Play Deflation Defender on Itch.io](https://aftertheraingames.itch.io/deflation-defender)  
