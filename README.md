### .NET Core Review App - Student Array

Created by me, @nicholaslagoa, this is an application created using .NET Core and C# aimed at the practice of the languages in question. The proposal is to create a system for inserting students from a "class" in a console, where the user can perform the following operations: 

* Add students
* List students
* Calculate students's overall average
* Quit application

The operations are self-explanatory and, at the time of creating this README, the limit of students to be added is 5, so the user can add, consult and average up to 5 students.

To start the application, at the moment, it is necessary to use a console terminal (the standard of Windows, Bash or others), the files of this repository and the .NET Core SDK, made available officially and for free by Microsoft. Navigate to the downloaded application folder and use the command *dotnet run* and the console application will start.


For the development of the app, I chose to organize in a class **Student** the attributes of the students to be inserted and in a struct **Concept**, the concept definitions for the averages. The choice of struct for the concepts was purely didactic, since I do not think it necessary to allocate memory from a struct for such a simple purpose *in this case*, the use of a string would be much more feasible.


I believe that by reading the comments that I wrote in the program's coding, a person can understand what each function does and why I chose that form of problem solving, thus helping both GitHub users to understand my application (as simple as that can be) and myself, finding information to be changed or remembered for some purpose in the future. Here is a list of features (most I believe are exceptions) that I believe would collaborate with the app and that I have not yet added. 

### TODO LIST:

1. Do not let the user calculate the average without entering any students (currently results in UnhandledException) 
2. Add function so that the user can limit the number of students in the class himself or remove the limit (?) of students 
