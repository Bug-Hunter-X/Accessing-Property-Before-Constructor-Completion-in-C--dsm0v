# Accessing Property Before Constructor Completion in C#

This repository demonstrates a subtle bug in C# related to accessing a class property before the constructor has fully initialized it.  If a property isn't explicitly assigned a value in the constructor, it will be initialized to its default value (0 for integers, null for references, etc.). Accessing this property within the class definition *before* the constructor completes might lead to unexpected results.

The `bug.cs` file shows the erroneous code. The `bugSolution.cs` file provides the corrected version.  The problem is that the property is accessed when it may not yet have the value set by the constructor. To avoid this, ensure all property access within the class definition happens only after the constructor has finished.