# CIRCLE OBJECTS
## Objectives: Objects, Methods, Member Variables

## Task: Calculate a circle’s diameter, circumference and area.

## What will the application do?
- The application prompts the user to enter a radius; the user may enter a number with decimals (double).
- The application displays an error if the user enters invalid data and asks the user again for a radius.
- When the user enters valid data, the application creates an instance of a Circle and then uses its methods to display the Diameter, Circumference and Area.
- The application asks the user if the circle should grow.
    - If the user says yes, call the grow method and then loop back to the method calls for the formulas. 
        - The grow method will adjust radius to double its value.
    - If the user says no, the application displays a “goodbye” message that also displays the radius of the circle.

## Build Specifications:
1. Create a class named Circle to store the data about this circle. This class should contain these constructors and methods:
    a. Properties
        i. private double radius
    b. Constructor
        i. public Circle(double radius)
    c. Methods
        i.   public double CalculateDiameter()
        ii.  public double CalculateCircumference()
        iii. public double CalculateArea()
        iv.  public void Grow()
         v. public double GetRadius()

2. For the value of pi, use the PI constant of the System.Math class.
3. Get the user input, create a Circle object, and display the diameter, circumference and area.

## Hints:
- Don’t mess up the formulas for diameter, circumference or area of a circle!

## Extra Challenges:
- Create a class named Validator and use its static methods to validate the data in this application.

## Console Preview:
- Welcome to the Circle Tester.
- Enter radius: 3.
- Diameter: 6
- Circumference: 18.849…
- Area: 28.2743…

- Should the circle grow? (y/n): y
- The circle is magically growing.

- Diameter: 12
- Circumference: 37.699…
- Area:  113.097…
- Should the circle grow? (y/n): n
- Goodbye. The circle’s final radius is 6.

