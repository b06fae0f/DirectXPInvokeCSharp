# About
This program uses PInvoke to create the Win32 window and the Direct3D instance in C#. 
COM Interop was used to include the DirectX interfaces. 
This code make use of the pre-installed csc compiler and d3d9.dll installed on Windows machines.

# How to use
- Open the project directory in powershell.
- Enter: `./build.bat` to compile the *.cs files.
- Enter: `./Program` to start the program.

If everything goes well, you should see a window with a blue background and a colored triangle in the center.

## Requirements:
Windows machine with .NET Framework 4.x. (Windows 7 or later)

## Disclaimer: 
This project contains the minimum code to run successfully, which mean that many of the interfaces, structs and enums are not complete or not included at all. 
If you wish to expand this project, you have to add the missing parts by yourself.

## Resources:
https://winprog.org/tutorial/simple_window.html
http://www.directxtutorial.com/Lesson.aspx?lessonid=9-4-1
