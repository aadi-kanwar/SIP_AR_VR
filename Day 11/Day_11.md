> Day 11 -> 25.09.2024



### Installing Package.

1. Click on *Windows* tab on top-bar.
2. Choose **Package Manager.**
3. Click on *Packages:* and choose **Unity Register**.
4. Search for **AR Foundation** and install it.
5. Search for **Google ARCore XR Plugin** and install it.



### Player Settings > Other Settings
1. Uncheck *Multithreaded Rendering*
2. Change *Minimum API Level* value to **Android 7.0....**
3. Change *Scripting Backend* value to **IL2CPP**
4. Check the *ARM64* checkbox
5. Uncheck *Auto Graphics API*. Followed by which select the *Vulkan* option and press **-** option on right side to remove the option.
6. From the sidebar, select *XR Plyg-in Management*, the check the *Google AR Core* checkbox on the right workspace.

### Adding Camera for Android
1. Right click on *Hierarchy* window.
2. Choose *XR*.
3. Choose *XR Origin (Mobile AR)*
4. The *Camera Offset* child will help render the image.
5. Right click again and select *AR Session*, under the *XR* option.


### Rendering
1. In teh *Project* window, click on **+** sign.
2. Choose *XR*.
3. Then click on *Reference Image Library*
4. Select the *Reference Image Library* in the *Assets* window.
5. Click on **Add Image** option in the *Inspector Window.*

---
1. Select XR Origin from *Hierarchy* window.
2. In the *Inspector* window, click on **Add Component**
3. Search for *AR Tracked Image Manager*.
4. From the *Assets* window, drag the *Reference Image Library* to the *Serialized Library*
5. Choose a dragon from the imported assets and drag and drop it to the *Hierarchy* window.
6. Change the *Scale* of the dragon from the *Inspector* window.

### Adding Animations
1. Go to *Assets* window.
2. Open *Animator* folder from the imported assets
3. Select the desired animation and double click it.
4. Remove all the states apart from the required ones. 


> There are more steps to be done.after this