> Day 6 - 17.09.2024

### Starting the new Project
While making a new project, choose 3D render Pipeline.

### Changing the Aspect Ratio
1. Click on *Game* tab.  
2. Change *Aspect* to **16:9 Aspect**


### Importing the Custom Package
1. Right Click on *Assets*.  
2. Select **Import Package**  
3. Click on **Custom Package**   
4. Choose the file that you want to import click open.
5. Click **Import** from the pop-up window.

### Importing Scripts
1. Right Click on *Assets*.  
2. Choose **Create**.  
3. Click on **Folder**. Rename the new folder as `Script`.
4. Open the *Script* folder.
5. Right Click on *Assets > Script* window.
6. Choose **Import New Asset**.
7. Select all the scripts that you want to import. Click **Import**.

###  Setting up the Environment
1. Open *Scene* folder. 
2. Double-click on *Prototype 3.unity* file.

### Camera Positioning
1. Switch to *Scene* wondow.
2. Using the scroll key and right click, align the camera such that the you are behind the picture.

### Adding Characters and Obstacles
1. Click on *Course Library* from *Assets* window.
2. Open the folder and choose the desired player character.
3. Drag and drop the player from the *Assets* window to the working space of the *Scene* window.

### Player Settings
1. Under *Inspector* tab, change all position co-ordinates to **0**.
2. Change direction of the player to suit the game.

### Adding obstacles
1. Click on *Course Library* from *Assets* window.
2. Open the folder and choose the desired obstacle from *Obstacles* folder.
3. Ensure all the *Rotation* co-ordinates for all the obstacles is **0**.

### Adding Rigid Body and Collider setting
> Both the settings are for   
> Rigid body will be added for player and obstacles.  
> Box-Collider will be added for player. This is to end the game if the player collides with any obstacle.

#### Rigid Body

1. Choose Player/Character.
2. Under the *Inspector* window. Click on *Add Component*. Choose **Rigid Body**.
3. Change **Mass** value under *Rigid Body* section to **60**.
4. Similarly add the *Rigid Body* component to the obstacle and change its *Mass* value to 10.  
`Ensure that mass of character is more than that of obstacle.`

#### Box-Collider
1. Choose Player/Character.
2. Under the *Inspector* window. Click on *Add Component*. Choose **Box Collider**.
3. Add the same component to ground, character and obstacle.

### Editing
1. Select the Player.
2. Click on **Edit Collider** option under the *Box Collider* section in the *Inspector* window.
3. Adjust the **Green Box** around the player by looking at it from different angles
4. Similarly edit box collider for the obstacle.

### Adding Scripts

#### Background
1. Select the background.
2. Under the *Inspector* window, select **Add Component**, and search for the script names that you want to add. In this game, add `MoveBackground` and `MoveLeft`

#### Obstacle
1. Add `MoveLeft` script to the obstacle

#### Player
1. Add `PlayerControl` Script for the player

#### Misc
1. Drag the obstacle from *Hierarchy* window to the *Assets > Script* folder.
2. Choose **Original Prefab** from the pop-up menu.
3. The obstacle will appear in the *Assets > Script* folder.

#### Spawn Manager
1. Right click on the *Hierarchy* window, and select **Create Empty**.
2. Name the element as `Spawn Manager`.
3. Add `SpawnManager` script to the element.
4. Next, drag and drop the obstacle from the *Assets > Script* to the **Obstacle Prefab** option under the *Spawn Manager Script* section in the *Inspector* window.

---
1. Click Obstacle.
2. Change the *Tag Name* from Untagged.
3. Click on the drop down.
4. Select **Add Tag**.
5. Click on '+' icon.
6. Open the `PlayerController` script. 
7. Copy the name and paste the same as the new tag name. Click **Save**
8. Add the tag name for Obstacle and Ground.

### Adding Animations
1. Choose Window tab from Top bar.
2. Choose **Animation**.
3. Choose **Animator** from next window.
4. Right click the green **Entry button**.
5. Slect **Make Transition**.
6. Attach the arrow to **Run Static** box.
7. Choose *Parameters* tab. 
8. Change *Speed_f* value to **1**.

### Jump Force
1. Select the Player.
2. Under the *Player Controller Script*, Change the *Jump Force* value to **greater than 800**.
3. Change the *Gravity Modifier* value to **5**