# NUnit Demonstration

This project demonstrates how to use NUnit for unit testing in C# with Visual Studio.

## Project Structure

The project consists of the following files:

- **Triangle.cs**: Contains a simple class `Triangle` with a method `ValidTriangle` to validate if given angles form a valid triangle.
- **TriangleTests.cs**: Contains NUnit tests for the `Triangle` class.
- **Program.cs**: Contains a `Main` method to execute NUnit tests.
- **README.md**: This file, providing an overview of the project.

## Getting Started

### Prerequisites

- Visual Studio installed on your machine.

### Running the Tests

1. Clone or download this repository to your local machine.
2. Open the solution file (`NUnitDemonstration.sln`) in Visual Studio.
3. Build the solution to ensure all dependencies are restored.
4. Run the tests by either:
   - Right-clicking on the `TriangleTests` class or project in Solution Explorer and selecting "Run Tests".
   - Running the application, which will execute the tests automatically.

### Understanding the Tests

- The `TriangleTests` class contains various test methods to validate different scenarios of the `ValidTriangle` method in the `Triangle` class.
- Each test method is annotated with NUnit attributes (`[Test]`, `[SetUp]`, etc.) to indicate that it's a test method.
- Assertions are used within the test methods to verify the expected behavior of the `ValidTriangle` method.
