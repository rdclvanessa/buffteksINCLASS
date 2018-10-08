# Starting console project

1. make folder where stuff will go
2. open code
3. navigate to that folder from 1
4. open terminal (ctrl + `)
5. dot net new console (if needed)
6. Do you want to install/download the required files for this project - YOU SAY YES!!
7. dotnet run (dotnet buidla and dotnet restore)


#Github stuff
1. You must have created a repository (github.com)
2. Keep the quick setup instructions on your browser
3. create .gitignore file (place folders and files in here that you don't want tracked)
4. git init (do this once to start up and then never again in this folder)
5. git add . (you'll do this everytime you want to ensure that all files are being tracked)
6. If you skipped step 3, then you have to do this (git rm --cached name-of-thing-to-forget)
7. git commit -m "The commit message that explains what/why things have been changed"
8. git remote add origin https://github.com/rdclvanessa/HelloWorldPractice.git
(only need once)
9. git push -u origin master

* Do a git add before you commit


* git status shows what you are tracking
* git rm --cached .\obj\      removes the folder