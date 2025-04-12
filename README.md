🎮 QuizMaster_Unity
Built in Unity (C#) – Designed, coded, and polished solo as part of my game dev learning journey with focus on UI systems, C# scripting, and game flow logic.

🧠 Project Overview
QuizMaster is a neon-themed quiz game where players answer fun, game-themed questions under time pressure. It combines a smooth user experience with responsive UI feedback, animated transitions, score tracking, and real-time logic handled via modular scripts. A great showcase of my growing Unity + C# experience, especially in crafting clean and dynamic UI interactions.

✨ Gameplay Preview
🎞️ Start + Answer Logic
![Gameplay](https://i.imgur.com/au3j5yu.gif)
🎞️ End Screen + Score System
![Score Screen](https://i.imgur.com/FFDJgL2.gif)


🕹️ Some Core Features
Question and answer logic using ScriptableObjects

Fully modular UI elements with UI Canvases, sliders, timers, and end screens

Score is calculated dynamically and displayed with percentage

Timer pressure mechanic + visual fill bar

“Play Again” system resets the game smoothly

TextMeshPro for crisp UI text display

EventSystem and button navigation all managed through code

Dynamic layout handling in different screen sizes

Neon button effects and animated feedback using Unity’s built-in UI system

🧩 Code & Architecture Highlights
Modular scripts: GameManager, ScoreKeeper, Timer, Quiz logic, EndScreen

Separation of concerns for each component (UI logic, game state, questions)

ScriptableObjects used to store and manage each quiz question

Don’tDestroyOnLoad used where needed to persist game objects

Custom methods for UI button behaviors, timer countdown, and score tracking

🔧 Tech & Tools
Unity 6 (2D UI-focused project)

C# scripting

TextMeshPro

Visual Studio Code

Version Control: Git & GitHub

Source control setup with .gitignore to avoid Unity clutter

📌 Scripts Overview
Quiz.cs: Controls quiz logic, answer validation, and progression

Timer.cs: Handles countdown and slider display

ScoreKeeper.cs: Tracks and calculates final score

EndScreen.cs: Displays end result with score + retry button

GameManager.cs: Coordinates UI and state reset across components

QuestionSO.cs: ScriptableObject used to store question/answer data

💬 Developer's Note
This project helped me gain confidence in building a full UI flow from scratch in Unity, learning to handle user input, layout management, score logic, and modular C# scripting. 
I'm especially proud of the clean architecture and professional feel of the final result. I'm now looking forward to applying these skills in real-world Unity development roles. 
And of course, more fun and challenging questions are to be added to this quiz! :-)
