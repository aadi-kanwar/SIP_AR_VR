> Day 8 - 19.09.2024  
> Floppy Bird

### Aspect Raito
1. Change Aspect ratio to **9:16 Aspect**.

### Folders
1. Create 4 folders in the *Aspect Window.*  
    - Animation
    - Prefab
    - Scripts
    - Sprites

2. In the *Sprites* folder, import all the required game objects.

### Background

1. Place the background on the *Scene Window.*
2. Ensure that **Order in Layer** value is **0** under the *Sprite Renderer* section in *Inspection Window.*

### Base / Ground
1. Place the ground on the *Scene Window.*
2. Select the ground, and then add component to from the *Inspector Window*.
3. Add *Box Collider 2D*. Check the **Auto Tiling** checkbox.
4. Ensure that **Order in Layer** value is **2** under the *Sprite Renderer* section in *Inspection Window.*

### Animation
1. Select the three bird files.
2. Drag and drop them onto the *Scene Window*.
3. Select the location where you want the animation to be saved. 
4. Choose the **Animation** folder here and give the name **Fab**
5. Click save.
6. Ensure that **Order in Layer** value is **1** under the *Sprite Renderer* section in *Inspection Window.*

#### Adding Animation
1. Go to the *Animation* folder from the *Assets Section*.
2. Double click on the *Fab.anim* file.
3. From the pop-up menu, click on the right facing arrow before *Sprite* in the sidebar.
4. Three birds appear on the working window.
5. Click on the mid-bird, and copy the bird.
6. Past the bird at the next instance after the up-wing-bird.
7. Similarly, copy the down-wing-bird and paste it at the next instance.
8. Close the window.

### Bird
1. Select the bird, and then add component to from the *Inspector Window*.
2. Add *Box Collider 2D*. Check the **Auto Tiling** checkbox.
3. Ensure that **Order in Layer** value is **1** under the *Sprite Renderer* section in *Inspection Window.*
4. Add *Rigib Body 2D* component.
5. Change *Gravity Scale* under *Rigid Body 2D* section to **0.5** in *Inspector* window.
6. Using the *Edit Collider* option under the *Box Collider 2D* section. 
7. Adjust the bird inside the green box.
8. Add *Polygon Collider 2D* component from the *Inspector* section.
9. 

### Misc

- Click on *Edit* menu from top bar. 
- Select *Project settings*
- Choose *Editor* from the sidebar.
- Scroll down to find, **Enter Play Mode Options**. Enable the checkbox in front of it.

### Scripts

#### To Fly the bird
1. Right click inside the *Script* folder, in the *Assets* window.
2. Choose **Create**
3. Choose **C# Script**
4. Rename the file to **fly**.

### Installing Package.

1. Click on *Windows* tab on top-bar.
2. Choose **Package Manager.**
3. Click on *Packages:* and choose **Unity Register**.
4. Search for **Input System** and install it.
5. Restart Unity Window. and run the game.