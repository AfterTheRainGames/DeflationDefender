# DeflationDefender
Game Jam Submission
DEFENSE Theme | Limitation: Only 1 Resource | December 20-22, 2024

Overview
Deflation Defender flips the tower defense genre on its head by letting the player embody the balloons instead of the towers. As a balloon with a protective shield, you navigate a 3D-styled 2D track while evading tower attacks.

Key Contributions as a Gameplay Engineer

Concept Development: Innovated the core gameplay loop by reversing roles and incorporating the "Only 1 Resource" limitation as a shield mechanic tied to mouse movement.
Pathfinding and Movement: Built a 2D pathing system using OnTriggerEnter events for turns, with a bool-based system to handle continuous rotation smoothly.
Shield Mechanics: Designed and coded shield movement, syncing its rotation to the player's mouse input to block incoming projectiles dynamically.
Tower and Projectile Logic:
Created turret prefabs that spawn projectiles with randomized fire rates.
Implemented bullet tracking to follow the player's updated position in real-time.
Developed damage and blocking systems using trigger-based collision logic, ensuring intuitive gameplay feedback.
Level Design:
Built two distinct levels leveraging Unity's tile snapping tools and asset packs, with thematic elements for variety (grass and winter themes).
Incorporated prefab-based level design to streamline multi-level creation.
UI and Audio: Added a dynamic main menu, level select interface, and immersive sound effects, including shield impacts and background music.
Build Optimization: Resolved aspect ratio issues for WebGL, ensuring consistent gameplay across screen sizes.
Challenges Overcome

Turning at Path Bends:
Issue: The player began turning correctly at corners but never stopped due to incomplete logic in the OnTriggerEnter event.
Solution: Introduced a bool (isTurning) to continuously manage rotation in Update, toggled on/off by triggers.
Projectile Tracking:
Issue: Bullets initially targeted the player’s spawn point instead of their updated position.
Solution: Implemented a real-time object reference using GameObject.FindByName to dynamically track the player’s current location.
Window Scaling:
Issue: Resizing the game window revealed off-screen elements like spawn points.
Solution: Fixed the camera aspect ratio to 16:9 and configured scaling to maintain consistent gameplay visuals.
Bullet-Spawning Collisions:
Issue: Turret bullets would collide with other towers upon spawning.
Solution: Removed tower colliders to allow bullets to spawn within turrets without premature destruction.
Reflection
Deflation Defender challenged me to adapt my skills to a 2D environment while leveraging 3D assets and to solve nuanced gameplay issues, such as turning mechanics and real-time player tracking. The result was a unique take on tower defense, showcasing creativity and technical proficiency under time constraints.
