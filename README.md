# Uninitialized Property Access in C#

This repository demonstrates a common error in C#: accessing a property of a class before it has been assigned a value.  The example shows a class with a property that is not explicitly initialized, and a method that tries to use it before any initialization. This can lead to unexpected results or exceptions, depending on the context.

## Bug Description
The `MyProperty` property in the `ExampleClass` is not explicitly initialized in the constructor.  The `MyMethod` function attempts to access `MyProperty` before setting its value, potentially leading to an uninitialized variable error or unpredictable behavior. 

## Solution
The solution involves initializing `MyProperty` in the constructor of the `ExampleClass` to ensure it has a defined value before it is accessed in other parts of the code.