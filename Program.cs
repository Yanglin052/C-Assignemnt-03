/* 03 Object - Oriented Programming
Test your knowledge
1. What are the six combinations of access modifier keywords and what do they do? 
    a.public: public access modifiers are accessible from everywhere in a project without any restrictions;
    b.protected: accessible inside the current class and in all children classes;
    c.private: private access modifier are accessible only inside current class;
    d.internal: the access is limited exclusively to classes defined within the current project assembly;
    e.protected internal: a combination of protected and internal, so we can access the protected internal member only in the same assembly or in a derived class in other assemblies;
    f.private protected: a combination of the private and protected keywords, so we can access members inside the containing class or in a class that derives from a containing class, but only in the same assembly;
2.What is the difference between the static, const, and readonly keywords when applied to a type member?
    Constant and Readonly keyword is used to make a field constant which value cannot be modified, 
    but for the readonly keyword, the latest value is known by the runtime, for the const keyword the value must be known by compile time.
    The static keyword is used to make members static that can be shared by all the class objects.

3. What does a constructor do?
    A constructor is a method whose name is the same as the name of the class and it does not include a return type.
    It is used to create an object of class and initialize class members.
    If there is no constructor in the class, c# compiler will provide a default constructor.
    If we create any constructor ourselves, the default constructor will be replaced.
    It can be overloaded, but cannot be inherited and overriden.

4. Why is the partial keyword useful?
    It provides a special ability to implement the functionality of a single class into multiple files,
    and all these files are combined into a single class file when the application is compiled.

5. What is a tuple?
    A tuple is a data structure that contains a sequence of elements of different data types. 

6. What does the C# record keyword do?
    To define a reference type that provides built-in functionality for encapsulating data
    
7. What does overloading and overriding mean?
    Method overriding happens between base class and the derived class with same method signature, 
    but derived class can have different implementations for the same methods -- runtime polymorphism;
    Method overloading refers to multiple methods in the same class with same method name and access modifiers, 
    but different input or output parameter -- compile time polymorphism.
    
8. What is the difference between a field and a property?
    A field is a variable of any type that is declared directly in the class,
    while property is a member that provides a flexible mechanism to read, write or compute the value of a private field.

9. How do you make a method parameter optional?
    Use Parameter arrays, Default parameter, Use OptionalAttribute or Method Overloading.
    
10. What is an interface and how is it different from abstract class?
    Interface is a collection of methods which are by default abstract and public, and will be implemented by the derived class.
    Differencs:
    a.Abstract class provides a base class to its subclasses -- use when we have a clear class hierachy;
    interface defines common behaviors / functionalities that can be implemented by any classes -- work as a contract;
    b.one class can only inherit from one parent class, but one class can implement multiple interfaces;
    c.methods in abstract class can be abstract methods or non-abstract methods, but methods in interfaces are by default abstract.
    
11.What accessibility level are members of an interface?
    public

12.True/False.Polymorphism allows derived classes to provide different implementations of the same method.
    TRUE

13.True/False.The override keyword is used to indicate that a method in a derived class is providing its own implementation of a method.
    TRUE

14.True/False.The new keyword is used to indicate that a method in a derived class is providing its own implementation of a method.
    TRUE

15.True/False.Abstract methods can be used in a normal (non-abstract) class. 
    FALSE

16.True/False.Normal(non-abstract) methods can be used in an abstract class. 
    TRUE

17.True/False.Derived classes can override methods that were virtual in the base class. 
    TRUE

18.True/False.Derived classes can override methods that were abstract in the base class. 
    TRUE

19.True/False.In a derived class, you can override a method that was neither virtual nor abstract in the base class.
    FALSE

20.True/False.A class that implements an interface does not have to provide an implementation for all of the members of the interface.
    FALSE

21.True/False.A class that implements an interface is allowed to have other members that aren’t defined in the interface.
    TRUE

22.True/False.A class can have more than one base class.
    FALSE

23.True/False.A class can implement more than one interface.
    TRUE
*/

/* Working with methods
1. Let’s make a program that uses methods to accomplish a task. Let’s take an array and reverse the contents of it. 
For example, if you have 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, it would become 10, 9, 8, 7, 6, 5, 4, 3, 2, 1.
To accomplish this, you’ll create three methods: one to create the array, one to reverse the array, and one to print the array at the end.

using System;

class Program
{
    public static int[] GenearteNum()
    {
        int[] num = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        return num;
    }

    static void ReverseNum(int[] num)
    {
        for (int i = 0; i < num.Length/2; i++)
        {
            int a = num[i];
            int b = num[num.Length - i - 1];
            int temp = a;
            a = b;
            b = temp;
            num[i] = a;
            num[num.Length - i - 1] = b;
        }
    }

    static void PrintNum(int[] num)
    {
        foreach (int i in num)
        {
            Console.WriteLine(i);
        }
        Console.WriteLine();
    }

    static void Main(string[] args)
    {
        int[] numbers = GenearteNum();
        ReverseNum(numbers);
        PrintNum(numbers);
    }
}

2. The Fibonacci sequence is a sequence of numbers where the first two numbers are 1 and 1,
and every other number in the sequence after it is the sum of the two numbers before it. 
So the third number is 1 + 1, which is 2. The fourth number is the 2nd number plus the 3rd, which is 1 + 2. 
So the fourth number is 3. The 5th number is the 3rd number plus the 4th number: 2 + 3 = 5. This keeps going forever.
The first few numbers of the Fibonacci sequence are: 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, ...
Because one number is defined by the numbers before it, this sets up a perfect opportunity for using recursion.
Your mission, should you choose to accept it, is to create a method called Fibonacci, which takes in a number 
and returns that number of the Fibonacci sequence.

class FibonacciProgram
{
    public static int Fibonacci(int n)
    {
        int a = 1;
        int b = 1;
        for (int i = 0; i < n; i++)
        {
            int temp = a;
            a = b;
            b = temp + b;
        }
        return a;
    }

    static void Main()
    {
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(Fibonacci(i));
        }
    }
}
*/

/*Designing and Building Classes using object-oriented principles
1. Write a program that that demonstrates use of four basic principles of object-oriented programming 
/Abstraction/, /Encapsulation/, /Inheritance/ and /Polymorphism/.

public abstract class Person //Abstraction
{
    private int id;//Encapsulation
    public int Id //Encapsulation
    {
        get
        {
            return id;
        }
        set
        {
            id = value;
        }
    }
    public string FullName { get; set; }
    public int Age { get; set; }
    public void SchoolWork()
    {
        Console.WriteLine("This person is at school.");//Polymorphism
    }
}

public class Student : Person //Inheritance
{
    public int Grade { get; set; }
    public void SchoolWork()
    {
        Console.WriteLine("Student is studying at school.");//Polymorphism
    }
}

public class Professor : Person //Inheritance
{
    public string Subject { get; set; }
    public void SchoolWork()
    {
        Console.WriteLine("Professor is working at school.");//Polymorphism
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Student student = new Student();
        student.SchoolWork();
        Professor professor = new Professor();
        professor.SchoolWork();
    }
}

2. Use /Abstraction/ to define different classes for each person type such as Student and Instructor.These classes should have behavior for that type of person.

public abstract class Person
{
    public string Name { get; set; }
    public string Gender { get; set; }
    public virtual void Performance() { }
}

public class Student : Person
{
    public int Grade { get; set; }
}

public class Instructor : Person
{
    public string Subject { get; set; }
}

3. Use /Encapsulation/ to keep many details private in each class.

public abstract class Person
{
    public string Name { get; set; }
    public string Gender { get; set; }
    public virtual void Performance() { }
    private int id;
    public int Id
    {
        get { return id; }
        set { id = value; }
    }
}

public class Student : Person
{
    public int Grade { get; set; }
    private decimal gpa;
    public decimal GPA
    {
        get { return gpa; }
        set { gpa = value; }
    }
}

public class Instructor : Person
{
    public string Subject { get; set; }
    private decimal salary;
    public decimal Salary
    {
        get { return salary; }
        set { salary = value; }
    }
}

4. Use /Inheritance/ by leveraging the implementation already created in the Person
class to save code in Student and Instructor classes.

public abstract class Person
{
    public string Name { get; set; }
    public string Gender { get; set; }
    public virtual void Performance() { }
    private int id;
    public int Id
    {
        get { return id; }
        set { id = value; }
    }
}

public class Student : Person
{
    public int Grade { get; set; }
    private decimal gpa;
    public decimal GPA
    {
        get { return gpa; }
        set { gpa = value; }
    }
}

public class Instructor : Person
{
    public string Subject { get; set; }
    private decimal salary;
    public decimal Salary
    {
        get { return salary; }
        set { salary = value; }
    }
}

5. Use /Polymorphism/ to create virtual methods that derived classes could override to
create specific behavior such as salary calculations.

public abstract class Person
{
    public string Name { get; set; }
    public string Gender { get; set; }
    public virtual void Performance() { }
    private int id;
    public int Id
    {
        get { return id; }
        set { id = value; }
    }
}

public class Student : Person
{
    public int Grade { get; set; }
    private decimal gpa;
    public decimal GPA
    {
        get { return gpa; }
        set { gpa = value; }
    }
    public override void Performance()
    {
        Console.WriteLine("Students should attend at least 2 courses each semester.");
    }
}

public class Instructor : Person
{
    public string Subject { get; set; }
    private decimal salary;
    public decimal Salary
    {
        get { return salary; }
        set { salary = value; }
    }
    public override void Performance()
    {
        Console.WriteLine("Instructors should teach at least 1 course each semester.");
    }
}

6. Make sure to create appropriate /interfaces/ such as ICourseService, IStudentService,IInstructorService, 
IDepartmentService, IPersonService, IPersonService (should have person specific methods). 
IStudentService, IInstructorService should inherit from IPersonService.

interface IPersonService
{
    int Age { get; set; }
    decimal Salary { get; set; }
    string Address{ get; set; }
}
interface IInstructorService: IPersonService
{
    string Department { get; set; }
    decimal Bonus { get; set; }
}
interface IStudentService : IPersonService
{
    decimal GPA { get; set; }
}

7. Try creating the two classes below, and make a simple program to work with them, as described below:
Create a Color class:
On a computer, colors are typically represented with a red, green, blue, and alpha (transparency) value, 
usually in the range of 0 to 255. Add these as instance variables.
A constructor that takes a red, green, blue, and alpha value. A constructor that takes just red, green, and blue, while alpha defaults to 255 (opaque).
Methods to get and set the red, green, blue, and alpha values from a Colorinstance.
A method to get the grayscale value for the color, which is the average of the red, green and blue values.

Create a Ball class:
The Ball class should have instance variables for size and color (the Color class you just created).
Let’s also add an instance variable that keeps track of the number of times it has been thrown.
Create any constructors you feel would be useful. Create a Pop method, which changes the ball’s size to 0.
Create a Throw method that adds 1 to the throw count, but only if the ball hasn’t been popped (has a size of 0).
A method that returns the number of times the ball has been thrown.

Write some code in your Main method to create a few balls, throw them around a few times, pop a few, 
and try to throw them again, and print out the number of times that the balls have been thrown. (Popped balls shouldn’t have changed.)*/


class Color
{
    private int red;
    private int green;
    private int blue;
    private int alpha;
    public Color(int red, int green, int blue, int alpha = 255)
    {
        this.red = red;
        this.green = green;
        this.blue = blue;
        this.alpha = alpha;
    }
    public int getRed()
    {
        return red;
    }
    public int getGreen()
    {
        return green;
    }
    public int getBlue()
    {
        return blue;
    }
    public int getAlpha()
    {
        return alpha;
    }
    public void setRed(int red)
    {
        this.red = red;
    }
    public void setGreen(int green)
    {
        this.green = green;
    }
    public void setBlue(int blue)
    {
        this.blue = blue;
    }
    public void setAlpha(int alpha)
    {
        this.alpha = alpha;
    }

    public double getGrayScaleValue()
    {
        return ((red + green + blue) * 1.0) / 3;
    }
}

class Ball
{
    private int size;
    private Color color;
    private int numOfThrows;

    public Ball (int size, Color color)
    {
        this.size = size;
        this.color = color;
        numOfThrows = 0;
    }
    public int getSize()
    {
        return size;
    }
    public Color getColor()
    {
        return color;
    }
    public void Pop()
    {
        size = 0;
    }
    public void Throw()
    {
        if (size != 0)
        {
            numOfThrows++;
        }
    }
    public int getNumOfThrows()
    {
        return numOfThrows;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Color color1 = new Color(2, 55, 111);
        Ball ball1 = new Ball(1, color1);

        ball1.Throw();
        ball1.Throw();
        ball1.Pop();
        ball1.Throw();
        ball1.Throw();
        Console.WriteLine("Ball 1 throw count: " + ball1.getNumOfThrows());
    }
}