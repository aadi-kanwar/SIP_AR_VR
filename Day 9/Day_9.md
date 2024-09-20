> Day 9 -> 20.09.2024

### Obstacles
1. Add the pipes to the *Scene Window.*
2. Add *Box Collider 2D* component and enable the *Auto Tiling* checkbox.
3. Right Click on the *Hierarchy Window*. 
4. Select *Create Empty* option.
5. Rename the object to **MovePipe**.
6. Drag and drop the two pipe objects inside the *MovePipe* parent object.

#### Adding script
1. Add a new script in *Assets > Scripts* folder. 
2. Add the required code to the script.
3. Add the script to the *MovePipe* parent.

### Making Prefab
1. Drag the *MovePipe* folder from *Hierarchy* window to *Assets > Prefab* in the *Assets window.*
2. A prefab is created.
3. Again select the *MovePipe* folder in *Hierarchy* window. And delete it.

### Pipe Spawner
1. Right Click on the *Hierarchy Window*. 
2. Select *Create Empty* option.
3. Rename the object to **PipeSpawner**.
4. In *Assets > Scripts*, add a new script and name it as **PipeSpawner**.
5. Add the required script.
6. Go to *Assets > Prefab* and select the *MovePipe* prefab.
7. Select the *PipeSpawner* folder in *Hierarchy* window.
8. Drag the prefab from *Assets window* to the **Pipe** option under *PipeSpawner* script in the *Inspector window.*

### Game Over Camvas
1. Right Click on the *Hierarchy Window*. 
2. Choose *UI*.
3. Then choose *Canvas*.
4. Rename it to **GameOver**.
5. Select the *GameOver* object. And then go to *Inspector Window*.
6. Under *Canvas Scaler*, change **UI SCale Mode** value to **Scale with Screen Size.**
7. Select the *GameOver* object and right click
8. Choose *UI*.
9. Then choose **Image.**
10. Similarly create 2 more images.
11. Rename the 3 Image object to: **Play**, **GameOver** and **GetReady**.

### Play
1. Select the *Play* image from the *Hierarchy Section*. 
2. Drag and drop the play button image from *Assets > Sprites* to **Source Image** option under *Image* Section in the *Inspector Window.*
3. 
---
### Game Manager
1. Right Click on the *Hierarchy Window*. 
2. Select *Create Empty* option.
3. Rename the object to **GameManager**.
4. In *Assets > Scripts*, add a new script and name it as **GameManager**.
5. Add the required script.
6. Add the *GameManager* script to the *GameManager* object, in the *Inspector Window*.

### PLay button 
1. Select the *Play* image in *Hierarchy* window.
2. Click on *Add Component* and add a **Button** in *Inspector Window*.
3. Change *Transition* value to **None.**
4. Click on the + button.
5. A new dialog box appears
6. Drag the **GameManager** object from *Hierarchy* to the **None** option in the new dialog box.
7. CLick on the **No Function** dropdown. Choose *GameManager* and choose **RestartGame()**.

> A few more steps to go and the game will be done