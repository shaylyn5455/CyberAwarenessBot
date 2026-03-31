SOUTH AFRICAN CYBERSECURITY AWARENESS ASSISTANT
POE Submission: Information Technology - Software Development
 Project Description
 youtube link : https://youtu.be/N18ztTKoRQA
This application is a specialized C# (.NET 10.0) console-based chatbot designed to educate users on cybersecurity threats within the South African digital landscape. The project demonstrates core programming concepts including user authentication, multimedia integration, and interactive logic.

 Key System Features
Security Access Gate: A mandatory password protection layer (user123) that simulates basic cybersecurity access control.

Multimedia Integration: Implementation of the System.Media namespace to trigger a personalized .wav audio greeting upon successful login.

Dynamic User Interaction: The system captures the user's name to personalize the educational session.

Keyword Intelligence: A logic engine that identifies specific security concerns like "phishing," "scams," and "password safety" to provide targeted advice.

CI/CD Pipeline: The project utilizes GitHub Actions with a Windows-based runner to automate the build and verification process.

 Technical Specifications
Framework: .NET 10.0 (Windows-Compatible)

Primary IDE: Visual Studio 2022

Core Libraries:

System.IO: For file path management.

System.Media: For audio playback handling.

System.Windows.Extensions: For cross-framework compatibility.

Build Tool: MSBuild / NuGet Package Manager

Setup and Execution Instructions
Project Initialization: Open the CyberAwarenessBot.sln solution file in Visual Studio.

Dependency Resolution: Ensure the System.Windows.Extensions package is installed via NuGet to enable the SoundPlayer functionality.

Resource Management: * The greeting.wav file must be located in the Resources folder.

The file property must be set to "Copy to Output Directory: Copy Always" to ensure the executable can find the audio during runtime.

Deployment: Press F5 or the Start button to compile and run the debug executable.

Usage Guide
Step 1: Enter the access code user123 when prompted.

Step 2: Listen to the automated audio greeting.

Step 3: Provide your name to initialize the personalized chatbot.

Step 4: Interact with the assistant by typing security-related keywords to receive educational responses.

 Author Information
Name: Shaylyn Sookan  

Student Number: ST10295211 

Project Name: CyberAwarenessBot v1.0  

<img width="1480" height="757" alt="Screenshot 2026-03-31 221927" src="https://github.com/user-attachments/assets/6a04ec4e-cbf2-4698-a1bd-8b5a93249982" />

Microsoft (2024) C# Docs: Color Structure. Available at: https://learn.microsoft.com/en-us/dotnet/api/system.drawing.color (Accessed: 31 March 2026).

Microsoft (2022) Visual Studio 2022 IDE. [Software] Available at: https://visualstudio.microsoft.com/ (Accessed: 31 March 2026).

ChatGPT. (2026). ChatGPT. [online] Available at: https://chatgpt.com/c/69cc2aff-141c-832a-a450-5f748b1843ac [Accessed 31 Mar. 2026].

‌Emeris (https://advtechonline.sharepoint.com/:w:/r/sites/TertiaryStudents/_layouts/15/Doc.aspx?sour)

 Microsoft Learn (2024) - System.Media.SoundPlayer
