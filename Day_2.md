> Day 2 - 10.09.2024

### Function prototype

` <return_type> <function_name>(Argument_list) `

### Function Definiton

><return_type><function_name>(Argument List)  
>{  
> &emsp; Body of the function  
}

### Types of Softwares
1. System Softwares  
2. Application Softwares

> **Note** : Extension of C# -> .cs

#### Path For different files

> .C -> Compiler -> .obj file (Object file) -> Execution -> Output  


>.java -> JDK (Java Development Toolkit) -> Byte Code (Hexadecimal File) -> Output  


> .cs -> C# Compiler -> Intermediate Language [IL] (Either .exe or .dll) -> CLR, Security/JIT (Compiler/Garbage Collevetion) -> Operation System Execution.

#### .NET Framework
- It is a framework for developing and implementing software for PC, web, etc.  
- CLR -> Common Language Runtime  
- .dll -> Dynamic Link Library
- JIT -> Just In Time -> Converts IL code to native machine language.
	
#### C# has 2 basic types of application.
Windows from application  
-> This is GUI based  

Console application  
-> This run on the COmmand prompt
		
#### Some info on C#		
- C# is case sensitive language.
- C# is free format language (no need of indentation)

### First C# Program
>class First_Csharp  
{  
	&emsp;&emsp;public static void Main()  
	&emsp;&emsp;{  
		&emsp;&emsp;&emsp;&emsp;System.Console.WriteLine("Hello World!");  
	&emsp;&emsp;}  
}

### Program Structure of C#
#### Documentation
1. Consists of set of comments giving the name of the program and other details

2. Single Line & Multi Line Comments

#### Using Directive Section
- Used to import Namespaces to the program.

#### Interface Section.
- Class Inheritance, abstract class, etc.
	
#### Classes Section
#### Main Method Section
	

>**Note :**   
Static -> Shares the memory location.  
All C# program should have atleast one main function.  
System is namespace  
Console -> I/O Devices -> Monitor and Keyboard

### Data Types
- Represents the Memory location.

#### Types of Data Types
1. Value Data Types
- All value data types will be stored in stack. 
2. Pointer data Types
- All pointer data types will be loaded in ()
3. Reference Data Types
- All reference Data type will be stored in heap.

#### Value Data Types
	1. Predefined Types
		> Style
		> int
		> bool
		> float
	2. User Defined Types
		> enum
		> struct

	- It is of fixed length and will be stored in stack.

#### Reference Data Types
	> Stored in heap 
	> Variable in length
	> Eg:
		Employee a = new Employee();
		a.age = 26
		Employee b = a;
		b.age = 30

		a is an object of class Employee. It will allocate the memory in the heap in of type Employee.  
		new -> is an operator to allocate dynamic memory.
		Updating age of object a to 26

### Boxing
- Coversion of value type to reference type is called Boxing. In other words, conversion of stack to heap.

- Implicit Type Conversion.

> Eg:   
> int age = 25  
> object reference_type = age;  
> reference_type = age;

### Unboxing
- Conversion from Heap to stack is called unboxing. In other words, conversion of object type to value type.

- Explicit type conversion

> Eg:  
> int age = 25  
> object reference_type = new object();  
> age = (int)reference_type;

### Program 2

> using System;  
> public class Prog_2  
> {  
	&emsp;&emsp;public static void Main()  
	&emsp;&emsp;{   
		&emsp;&emsp;&emsp;&emsp;int num = 2024;  
		&emsp;&emsp;&emsp;&emsp;object obj = num;  
		&emsp;&emsp;&emsp;&emsp;int i = (int)onj;  
		&emsp;&emsp;&emsp;&emsp;Console.WriteLine("Boxing & Unboxing:");
		&emsp;&emsp;&emsp;&emsp;Console.WriteLine("Value of object : "+ obj);
		&emsp;&emsp;&emsp;&emsp;Console.WriteLine("Value of i: "+ i);  
		&emsp;&emsp;
	}  
}