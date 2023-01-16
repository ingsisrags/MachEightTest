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


#Pre requisites

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



