# MachEightTest

Console app that resolve the next test

he task is to write a function that finds pairs of integers from a list that
sum to a given value. The function will take as input the list of numbers as
well as the target sum.
​
Sample output is shown below.
```
> app 1,9,5,0,20,-4,12,16,7 12
​
+ 12,0
+ 5,7
+ 16,-4
​
```

#Solution description

The solution is an console app developed in .net core 6.0 (multiplatform)

It is compose for:
	main class : program
	interface: ICalculate
	class: Calculate

in the main class run a instace of class calculate that contains a function for print in scream the numbers the solution,
here we used a redundan function that we helped to find the numbers inside in the array for the sum.
  
  ```
  findSumPar(list, sum, 0, 1);
  ```
  
  the logic for the function findSumPar is
   ```
    public Task findSumPar(int[] list, int sum, int x, int y)
    {
          
            if (x < list.Length  && y < list.Length )
            {
                if ((list[x] + list[y] == sum))
                {
                    Console.WriteLine($"{list[x]},{list[y]} ");
                }
                if (y == list.Length-1)
                {
                    Thread thready = new Thread(async() => await findSumPar(list, sum, x + 1, x+2));
                    thready.Start();
                }

                findSumPar(list, sum, x, y + 1);
            }
            return Task.CompletedTask;
    }
```
  
  
#Pre requisites for Run

You need install .net core 6.0, here a guid for how install .net core in linux and windows:

```
for linux:
https://learn.microsoft.com/en-us/dotnet/core/install/linux-ubuntu

for windows:
https://dotnet.microsoft.com/en-us/download
```


#Run the app

For run app, in the root the solution, you need write the next commands in the console


For linux ubuntu:

```
dotnet publish -c release -r ubuntu.16.04-x64 --self-contained

Copy the publish folder to the Ubuntu machine

Open the Ubuntu machine terminal (CLI) and go to the project directory

Provide execute permissions:

chmod 777 ./appname
Execute the application

./appname
```

For windows:
```
dotnet publish -c Release -r win10-x64

Copy the publish

Run .exe application
```



