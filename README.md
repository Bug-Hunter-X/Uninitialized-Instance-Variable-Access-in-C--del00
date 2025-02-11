# Uninitialized Instance Variable Access in C#

This repository demonstrates a common error in C#: accessing an instance variable before it's been assigned a value.  This can lead to unexpected behavior and hard-to-debug issues.

The `UninitializedBug.cs` file shows the problematic code. The `UninitializedBugSolution.cs` file presents a corrected version.

**Problem:** Uninitialized variables might return a default value or throw an exception at runtime depending on the program’s memory state. This makes the program less predictable.

**Solution:** Always initialize instance variables either in the declaration or within a constructor to ensure they have a defined value before being accessed.