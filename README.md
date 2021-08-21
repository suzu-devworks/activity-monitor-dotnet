# activity-monitor-dotnet
Implementation plan for computer activity monitoring using .NET

## Scenario

### Step 1

Get CPU and memory usage from Windows Performance Counter and display it on the screen as a graph.

in use:

- Windows Forms (GDI+)
- Performance Counter (System.Diagnostics.PerformanceCounter)

## Step 2

Change to run the monitor on another node and get the value by server push communication.

in use:

- Communication between nodes(gRPC, SignalR, or ...)

## Step 3

Change so that multiple viewers can be displayed at the same time by multicast communication from the monitor.

in use:

- WPF
- Console(CLI interface)

## Step 4?

I want to be able to get non-Windows activity.

