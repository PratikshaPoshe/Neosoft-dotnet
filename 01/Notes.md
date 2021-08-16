## [Version Control System](https://www.atlassian.com/git/tutorials/what-is-version-control)
- We use VCSs to collaborate as a team of programmars, track changes, do code review and much more...
- This can be of 2 types
	- Distributed VCS
		- Github, BitBucket, Gitlab etc...
	- Centralized VCS
		- TFS, VSTS, SVN
- ![Version control system board work](https://github.com/Tech-Training-2021/Neosoft-dotnet/blob/main/01/Images/1VCS%20.png)
# Git
## VCS -- DVCS and CVCS
## Basic Git and commands
- `cd 'path'` -> change directory
- `cd ..` -> moves a level up
	- use arrow keys to see history of previously use commands
	- history -> gives a track of all commands you have used in the current session
- `cd ./ tab key` -> gives the auto-completion of the file/directory
- `ls` -> list all the files and directories
- `mkdir 'directory name'` -> make directory
- `touch 'file name.extension'` -> creates a file
- `git clone 'url'` -> adds the local workspace in your machine
- `git add` -> adds the file you target to add to git
- `git add -A` -> adds all the file
- `git commit -m 'message'` -> Stage changes and commit to git as a new node
- `git push` -> push changes to git server
- `git status` -> see the new tracks/ changes made in local workspace
- `git pull` -> retrieve changes from the git server (updates your workspace with latest code)
- `pwd` -> print where directory

### Demo	
- `cd C:/Training`   - to navigate to a directory
- `cd Neosoft/`
- `git clone https://github.com/Tech-Training-2021/Neosoft-dotnet` - to make a local copy of the repo
- `cd training-code/`
- `mkdir 01` - create a folder/directory
- `cd 01/`
- `touch Notes.md` - create a file
- `notepad Notes.md` - open the file with notepad
	- add some content
- `git status` - to check changes if any
- `git add` . - stage the changes in all the file(s)
- `git commit -m 'add notes for git basics'` - create a tracking node
- `git push` - add changes to git origin/server
- `git pull` - to get changes from the server
- `git branch` - tells you how many branches you have and which branch are you current;y pointing to.
- `git checkout -b feature-<your firstname>` - creates a new branch `feature-pushpinder` and switch it as a working branch.
- git add Notes.md 
- git  commit -m "Added something about VCS -firstname"
- git push --set-uptream origin feature-<your firstname>
- make a Pull Request for code review


## [Application Architecture:](https://docs.microsoft.com/en-us/dotnet/architecture/modern-web-apps-azure/common-web-application-architectures)
- Tiering vs Layering
- 1-tier, 2-tier, 3-tier, N-tier
- ![Application architecture](https://github.com/Tech-Training-2021/Neosoft-dotnet/blob/main/01/Images/2Application%20architecture.png)

## [Basics of Computer Architecture Hardware and software](https://www.tutorialspoint.com/computer_concepts/computer_concepts_introduction_to_gui_based_os.htm)
- **Operating Systems** : Its a software that controls system's hardware and interact user and application software.
- Function of an OS:	
  - CPU Scheduling - process management 
  - offers UI to interact
  - Manages memory, files and directory management 
  -  ....more
- Unix, Linux, Windows, MacOS, Android 
  
## [Programming language Journey](https://www.geeksforgeeks.org/the-evolution-of-programming-languages/)
- 1883 Charles Babbage created computers. He was inspired by Abacus
-  Hardware only understands 0s and 1s or binary language -> **Machine language**. One of the Lowest level of language. Needs a skills to understand the program.
-  **Assembly Language** - 1949
   -  low-level language
   -  consistes of instructions (symbols) that only machine can understand. REGISTER, STOR, ADD, MOV, ROTATE
   -  FBW systems, medical equiments 
- **High Level** - Fortran, Algol, Cobol, Basic, C, C++, Java, C#
  
## [Journey of High level languages](https://www.geeksforgeeks.org/difference-between-structured-programming-and-object-oriented-programming/)
- Structural/Procedural oriented language: 
  - It gives more importance of code.
  - write functions, modules and program flow
  - What to do and How to do  - lots of programming expertise require along with long efforts.
  - Variables and data was not secured well, program was scattered, reusability was limited 
  - Top down approach
  - Ex - C, ALGOL
  
- Object Oriented Programming 
  - It gives more importance to data. 
  - what to do is more foccussed over how to do
  - brings together data and functions that execute on them.
  - program is more organized in the form of classes, functions/methods and data is secure within them
  - Pillars of OOP - Encapsulation, Abstraction, Polymorphism and Inheritance
  - this model of prgramming is based of real life entities 
  - Bottom up approach
  - Ex - C++, Java, C# etc...
