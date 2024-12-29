# DeflationDefender
Deflation Defender was my submission for the **DEFENSE** themed game jam that ran December 20th-22nd 2024. This game jam also used the limitation **Only 1 Resouce**. My inital thought when I heard the theme was a tower defense style game, but I wanted to put a spin on the classic genre. I then decided to have the player play as the reverse role (in this case a balloon based on Bloons Tower Defense). Now in the usual tower defense game the enemys dont have any sort of defense besides health so to incorporate the limiation I gave the player a shield. Now that the concept I wanted to make was decided I began work on the project. All of my previous games I'd done up to this point were in full 3D so this time since I was doing a tower defense style game I wanted to take a swing at work with 2D. I have utilized asset packs from (https://kenney.nl/assets) before so I decided to use one of theirs again. I like the style of the 3D assets more so I decided to go with a top down orthographic style camera with 3D assets for the style of the game. To create the inital level I utilized the tiles provided in the asset pack alongside Unity's built in snapping tool. I made a simple tower defense style track and could now start working on the movement. Movement in 2D proved to be very similar to 3D just without the added jumping mechanic. I elected to go with a character controller for the player and added a set speed in the forward direction. The first issue I ran into was causing the player to turn at bends. I utilized OnTriggerEnter commands by setting colliders for either left turns or right turns at the corresponing corners. The issue that arose was that I had set the turning function (which held the code for starting and stopping the turning) in the OnTriggerEnter case, so the turning began but the turing did not stop because the stopping logic would not run since it was only in the "enter" section. The solution to this issue was to set a bool of isTurning to run the Turn() command and isTurning would be set true within the OnTriggerEnter and set false at the end of Turn() which is within update. Once the basic pathing was working I moved onto getting the shield to follow the player mouse. I referenced my previous game Paint the World to get the mouse location on screen code. Once I had the location of the mouse I made the shield look at the mouse and rotate around the player while staying 1 unit away from the player. With player and shield movement now completed I moved onto the towers
