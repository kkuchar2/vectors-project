# Vectors

This is a C# code sample that provides a `Wektor` class for working with 3D vectors. The class implements various vector operations, including addition, subtraction, dot product, cross product, scalar multiplication, and checking for orthogonality.

## Usage

To use this code, simply include the `Wektor` class in your C# project. You can then create `Wektor` objects and perform various operations on them.

For example, to create a new `Wektor` object with coordinates (1, 2, 3), you can write:

```csharp
Wektor w = new Wektor(1, 2, 3);
Wektor w1 = new Wektor(1, 2, 3);
Wektor w2 = new Wektor(4, 5, 6);

Wektor w3 = w1 + w2; // add two vectors
Wektor w4 = w1 - w2; // subtract two vectors
double dot = Wektor.Dot(w1, w2); // calculate the dot product
Wektor cross = Wektor.Cross(w1, w2); // calculate the cross product
Wektor scalar = w1 * 2; // scalar multiplication
bool orthogonal = Wektor.IsOrthogonal(w1, w2); // check for orthogonality
```

You can also compare Wektor objects based on their length using the CompareTo method:

```
Wektor w1 = new Wektor(1, 2, 3);
Wektor w2 = new Wektor(4, 5, 6);

int comparison = w1.CompareTo(w2); // compare two vectors based on their length
```
