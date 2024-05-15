# SUVAT Operations Library

[![MIT License](https://img.shields.io/github/license/DianaBorro/SUVATNuGet?style=flat-square)](LICENSE)
![GitHub last commit](https://img.shields.io/github/last-commit/DianaBorro/SUVATNuGet)
[![Nuget](https://img.shields.io/nuget/v/SUVATNuGet)](https://www.nuget.org/packages/DianaBorro.Physics.SUVATEquations/)

The SUVAT Equations Library is a C# library that provides methods for calculating displacement, initial velocity, final velocity, and acceleration using the SUVAT equations of motion. This library simplifies the process of performing kinematic calculations in C# applications.


## Installation

You can install the SUVAT Operations Library via NuGet Package Manager.


## Usage

To use the SUVAT Operations Library in your C# project, follow these steps:

1. Install the NuGet package.
2. Import the `SUVATNuGet` namespace in your C# file.


## Example

```csharp
using System;
using SUVATNuGet;

class Program
{
    static void Main(string[] args)
    {
        SUVATOperations suvat = new SUVATOperations();

        // Calculate displacement using initial velocity, time, and final velocity
        double displacement = suvat.DisplacementUTV(5.0, 2.0, 10.0);
        Console.WriteLine("Displacement: " + displacement);

        // Calculate final velocity using displacement, initial velocity, and acceleration
        double finalVelocity = suvat.FinalVelocityVAS(0.0, 9.8, 10.0);
        Console.WriteLine("Final Velocity: " + finalVelocity);
    }
}
