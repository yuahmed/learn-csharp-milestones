# C# Unity Milestones

Below is a list of tasks that correspond roughly to the "Take Action" sections of [Learning C# by Developing Games with Unity](https://www.packtpub.com/product/learning-c-by-developing-games-with-unity-seventh-edition/9781837636877) by Harrison Ferrone. By mid-semester, everyone should...

- Understand what the task is asking
- Be able to do the task
- Make it clear through your actions you understand what's happening



## Contents

1. [Instructions](#Instructions)
1. [Chapter 1](#chapter-1) - Getting to Know Your Environment (9–21)
1. [Chapter 2](#chapter-2) - The Building Blocks of Programming (22–37)
1. [Chapter 3](#chapter-3) - Diving into Variables, Types, and Methods (38–64)
1. [Chapter 4](#chapter-4) - Control Flow and Collection Types (65–93)
1. [Chapter 5](#chapter-5) - Working with Classes, Structs, and OOP (94–119)
1. [Chapter 6](#chapter-6) - Getting Your Hands Dirty with Unity (120–148)
1. [Chapter 7](#chapter-7) - Movement, Camera Controls, and Collisions (149–175)
1. [Chapter 8](#chapter-8) - Scripting Game Mechanics (176–207)






## Instructions

1. Fork this repository (into your own Github account)
1. Complete each task below inside this sample project (the project is the repository)
1. Check off each task as you complete it, creating files and adding content where prompted with ✏️ or  **??**
1. Commit and push your work after each chapter
1. After you finish, celebrate your C# proficiency! 🙌


#### Notes...

- **RTM** - Sometimes I give the command you need and sometimes you have to read the documentation to find it.
- **Details** - Following the instructions, especially those with a ✏️
- **Reference** - If you get stuck compare your code with the book [source code](https://github.com/PacktPublishing/Learning-C-8-by-Developing-Games-with-Unity-2020)






## Chapter 1
Getting to Know Your Environment (9–21)

- [x] ✏️ Open the reference manual for any component from inside Unity. Paste the link: [Ref. Manual](https://docs.unity3d.com/2021.3/Documentation/Manual/class-Light.html) 
- [x] ✏️ Find the button to jump to the scripting reference the any reference manual page. Paste the link:[Scripting Ref.](https://docs.unity3d.com/2021.3/Documentation/ScriptReference/Light.html)
- [x] ✏️ Search for the `Strings` class in [Microsoft's C# documents](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/). Paste the link: [Strings](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/strings/)


## Chapter 2
The Building Blocks of Programming (22–37)

- [x] Open the Unity project contained within this repo
- [x] Create Assets/Scripts/LearningCurve.cs
	- [x] Create C# variables with typeof `int`, `float`, `string`, and `bool`
	- [x] Add a single line, multi line, and summary comment to LearningCurve.cs
	- [x] Run the code in LearningCurve by attaching it to the Main Camera GameObject


## Chapter 3
Diving into Variables, Types, and Methods (38–64)

- [x] Update Assets/Scripts/LearningCurve.cs
	- [x] Variables
		- [x] Use access modifiers to make your variables explicitly `public` and `private`
		- [x] Use `Debug.Log` and `Debug.LogFormat` to log your variables to the console
		- [x] Concatenate strings using the `+` operator, and the string interpolation method `$`
	- [x] Methods
		- [x] Define a simple method with parameters
		- [x] Add a return type and return some data from a method
		- [x] Use data returned from a method
- [x] ✏️ Explain some differences between public and private variables: **Public variables may be used by any script while private variables are declared and available for use only within the class they were declared within.**


## Chapter 4
Control Flow and Collection Types (65–93)

- [x] Update Assets/Scripts/LearningCurve.cs
	- [x] Conditionals
		- [x] Write `if`, `else if`, and `else` statements
		- [x] Test for `true` and `!true` in a conditional
		- [x] Write a nested `if` statement
		- [x] Write a `switch` statement
	- [x] Collections
		- [x] ✏️ What will `arr[1]` return from this array `int[] arr = {'red','green','blue'};` ? : **green**
		- [x] Write an Array of the type `int[]`
		- [x] Write a List of the type `List<string>`
		- [x] Write a Dictionary of the type `Dictionary<string, int>`
	- [x] Loops
		- [x] Use a `for` loop to print a specific index of a `List<string>`
		- [x] Use a `foreach` loop to print all indexes of a `List<string>`
		- [x] Use a `foreach` loop to print the `KeyValuePair.Key` and `KeyValuePair.Value` of all indexes of a `Dictionary<string, int>`



## Chapter 5
Working with Classes, Structs, and OOP (94–119)

- Classes
	- [x] ✏️ Explain the difference between reference and value type variables: ***value* type variables contain the data assinged to them directly within memory. *reference* type variables does not hold the data directly, but points to it within memory.**
	- [x] Create Assets/Scripts/Character.cs
		- [x] Create a `Character` class
		- [x] Create `string` and `int` fields inside the Character class
		- [x] Create a `Character()` constructor and populate the above fields with its parameters
	- [x] Update Assets/Scripts/LearningCurve.cs
		- [x] Instantiate two new Character objects `hero` and `heroine` from the `Character` class
		- [x] Print out each characters data
- [ x Structs
	- [x] Update Assets/Scripts/Character.cs
		- [x] Add a `Weapon` struct
		- [x] Create `string` and `int` fields inside the Weapon struct
		- [x] Create a `Weapon()` constructor and populate the above fields with its parameters
	- [x] Update Assets/Scripts/LearningCurve.cs
		- [x] Instantiate two new Weapon objects `huntingBow` and `warBow` from the `Weapon` struct
		- [x] Print out each weapons' data
- Child classes
	- [x] Update Assets/Scripts/Character.cs
		- [x] Add a `Paladin` child class of `Character`
		- [x] Create a `Weapon` field inside the Paladin class
		- [x] Create a `Paladin()` constructor that calls the `base()` constructor. Populate the weapon in a parameter
	- [x] Update Assets/Scripts/LearningCurve.cs
		- [x] Instantiate a new Paladin object `knight` from the Paladin class
		- [x] Print the Paladin's name and weapon by overriding `PrintStatsInfo` in the base class
- Referencing objects
	- [x] Update Assets/Scripts/LearningCurve.cs
		- [x] Store a reference to the current game object's (Main Camera) `Transform` component using `GetComponent<>()`
		- [x] Log a reference to the `localPosition` field of the Main Camera's `Transform`
		- [x] Store a reference to the Light `GameObject` using `GameObject.Find()`
		- [x] Store a reference to the Light's `Transform` component using `GetComponent<>()`
		- [x] Log a reference to the `localPosition` field of the Light's `Transform`


## Chapter 6
Getting Your Hands Dirty with Unity (120–148)

- [x] Use primitive cubes and move, rotate, and scale tools to create a level or "world" in Unity
- [x] Add materials to primitives in Unity to change their color
- [x] Use parenting and "empty objects" in the Hierarchy tab to organize your project
- [x] Create, update, and use prefab game objects
- [x] Create timeline animations by recording keyframes and editing curves in Unity
- [ ] Add and edit a particle system to a game object in Unity



## Chapter 7
Movement, Camera Controls, and Collisions (149–175)

- [x] Movement
	- [x] Understand the difference between a "position vector" and a "direction vector"
	- [x] Capture keyboard input in C#
	- [x] Move and rotate a game object using `Translate()` and `Rotate()` with direction vectors
- [x] Camera Controls
	- [x] Add a script to the main camera that follows and looks at the player
- [x] Physics and Collisions
	- [x] Use `FixedUpdate()` to control game objects using Unity's physics engine
	- [x] Apply physics forces to a game object RigidBody using `MovePosition()`
	- [x] ✏️ Q: Will a [collision detection](https://docs.unity3d.com/Manual/CollidersOverview.html) occur when a Kinematic Rigidbody Collider touches a Static Collider? : **No, a collision detection does not occurr in this case. A kinematice rigidbody collider can send a trigger message upon collision with a static collider.**
	- [x] Use `OnCollisionEnter()` to check if a game object has run into another collider
	- [x] Use `Destroy()` to remove a game object from the scene
	- [x] Use `OnTriggerEnter()` and `OnTriggerExit()` to detect when two colliders start and stop touching


## Chapter 8
Scripting Game Mechanics (176–207)

- Character Control
	- [ ] Capture keyboard input in C# using the `enum` type and value `KeyCode.Space`
	- [x] Use `AddForce()` to make a character jump
	- [x] Use a `LayerMask` and a new "Ground" layer in Unity to determine if a character is "IsGrounded"
- [x] Add a shooting mechanic
	- [x] Create a "projectile" prefab that moves forward using `RigidBody.velocity`
	- [x] Instantiate the projectile on click and destroy it after `3` seconds
- [x] Create a GameManager
 	- [x] Use `get` and `set` properties to return and assign properties that are used across the game
- [x] Add a simple UI to inform the user of game state(s)
	- [x] Add text to show the health and items counts to the user
	- [x] Add a win condition to the game and display it in the UI
	- [x] Use `Time.timeScale = 0` to pause the game
