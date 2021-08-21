# Step1 Functional Specification.

## Overview

Activity Monitor for .NET is an application that displays the usage rate of computer CPU, memory, etc. in numerical values and graphs.

**This specification is updated at creation time and is always imperfect.**

This application tracks the process of reorganizing the Windows Froms technology I was using and updating it as .NET technology evolves, but omits overly twisted or overly twisted ones.

Also note that the implementation lacks technical skills and is under-considered.

A similar tool is [dotnet-counters](https://docs.microsoft.com/ja-jp/dotnet/core/diagnostics/dotnet-counters).

I will refer to it because it is just an arrangement of knowledge, but I will not imitate it.(Since the contents are the same, they may be similar)

## Scenarios

## Scenario 1:

`TODO`

## Non Goals

This version will not support the following features:

- Certification. Account management.
- Cross-platform (Windows only).
- Monitor in production environment.

## Diagrams

`TODO`

## Screen by Screen Specification

### Settings

The setting screen specifies the process and counter to be acquired.

It looks like this:

`TODO`

If you do not specify the process to get, you will get the total counter.

Select the value to be acquired from the following values.

- "Processor", "% Processor Time"
- "Network Interface", "Bytes Total/Sec"
- "PhysicalDisk", "% Disk Time"
- "PhysicalDisk", "IO Data Bytes/Sec"
- "Memory", "Available MBytes"
- "Memory", "Pages/Sec"
- "Memory", "Commited Bytes"
- "Process", "Working Set"
- "Process", "IO Data Bytes/Sec"
- "Process", "Page Faults/sec"
- "Process", "% User Time"
- "System", "Processor Queue Length"

### Numerical values View

Displays the CPU, memory, disk, and other usage status (current value, maximum value, average value) during the measurement period.
These are taken from the "Windows Performance Counter".

It looks like this:

`TODO`

### Graph View

The acquired value is displayed as a graph. It redraws at regular intervals, which is done at a different time than the value acquisition interval.

It looks like this:

`TODO`

> Technical Note<br>
I'm wondering if I need to use `System.ComponentModel.BackgroundWorker`.

Also consider that the scale of the graph will change depending on the value obtained.
The data required for the graph needs to be saved.

> Technical Note<br>
Use Sqlite's InMemory Database for data storage. `Microsoft.EntityFrameworkCore.Sqlite`


## References

- https://www.joelonsoftware.com/whattimeisit/
- https://docs.microsoft.com/ja-jp/ef/core/testing/sqlite
