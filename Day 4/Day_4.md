> Day 4 - 12.09.2024

### Adding a script in Unity Hub

1. Right click on *Asset* Window.
2. Choose **Create**.
3. Click on **C# Script**.
4. A base script appears in the *Inspector* Section
5. Double click on the script. The editable file opens in Visual Studio.

#### Base Code

    using System.Collections; 
    using System.Collections.Generic; 
    using UnityEngine; 

    public class First_CSharp_with_Unity : MonoBehaviour 
    { 
        // Start is called before the first frame update 
        void Start() 
        { 
            
        } 
        // Update is called once per frame 
        void Update() 
        { 
            
        }
    } 

#### Changes in script to print Hello World!

    void Start() 
    { 
        Debug.Log("Hello World!"); 
    }

### What Next?
- Even on playing the program there is no output shown.
- Select the *Main Camera*
- Drag and drop the C# (.cs file), in the end of the *Inspector* section.
- Click on the play button again. The output is printed at the bottom left of the Unity hub window.

### How to show the text on the screen.
1. Right click *Hierarchy* Section. 
2. Click on *UI*
3. Choose *Text - TextMeshPro* option.
4. Import and dependencies if needed.
5. A Sample text would be displayed on the *Scene* window.
6. Add a new script in the *Assets* Window. Edit the base code as follow....


        using System.Collections; 
        using UnityEngine;
        using TMPro; 

        public class Text : MonoBehaviour 
        {
            public string fname; 
            public TextMeshProUGUI textMeshPro; 
            // Start is called before the first frame update 
            void Start() 
            { 

                textMeshPro = GetComponent<TextMeshProUGUI>(); 
                textMeshPro.text = $"Hello {fname}!"; 
            }
        } 

7. Drag and add the script file from the *Asset* window to *Inspector* Window.
8. Write the name in fname property under the script added in the above step in the *Inspector Section*. 
9. Click on the play button to run the game. The text would appear from the script on the screen!!!

