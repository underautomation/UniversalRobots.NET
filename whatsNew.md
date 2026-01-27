## Raw Package Received Event

A new event `RawPackageReceived` has been added to the `PrimaryInterface`. This event is raised for every package received from the robot before any decoding happens, giving you access to the raw data.

### Example

```csharp
var robot = new UR();
robot.PrimaryInterface.RawPackageReceived += (sender, e) => 
{
    // Access raw data
    byte[] rawData = e.Data;
    DateTime receiveDate = e.ReceiveDate;
    byte type = e.Type;
    
    Console.WriteLine($"Received {rawData.Length} bytes of type {type}");
};
robot.Connect("192.168.0.1");
```

---

## REST API Support for PolyscopeX

This release introduces full support for the **Universal Robots REST API**, available exclusively on **PolyscopeX** robots. The REST API is the modern replacement for the legacy `Dashboard Server` on new UR controllers running PolyscopeX.

### Why REST API?

On PolyscopeX-based robots, the traditional Dashboard Server is deprecated. The REST API provides a cleaner, HTTP-based interface to control robot and program states. This SDK now seamlessly supports both:
- **Legacy Dashboard Server** for CB-series and e-Series robots
- **REST API** for PolyscopeX robots

### Available Operations

| Category | Method | Description |
|----------|--------|-------------|
| **Robot State** | `PowerOn()` | Power on the robot |
| | `PowerOff()` | Power off the robot |
| | `BrakeRelease()` | Release the robot brakes |
| | `UnlockProtectiveStop()` | Unlock from protective stop |
| | `RestartSafety()` | Restart the safety system |
| **Program Control** | `LoadProgram(name)` | Load a program by name |
| | `Play()` | Start playing the loaded program |
| | `Pause()` | Pause the running program |
| | `Stop()` | Stop the running program |
| | `Resume()` | Resume a paused program |
| | `GetProgramState()` | Get current program state |

### Quick Start Example

```csharp
using UnderAutomation.UniversalRobots;

// Create UR instance
var robot = new UR();

// Connect with REST API enabled (for PolyscopeX)
robot.Connect(new ConnectParameters("192.168.0.1")
{
    Rest = { Enable = true }
});

// Power on and release brakes
robot.Rest.PowerOn();
robot.Rest.BrakeRelease();

// Load and run a program
robot.Rest.LoadProgram("my_program");
robot.Rest.Play();

// Check program state (RUNNING, STOPPED, ...)
var state = robot.Rest.GetProgramState();
Console.WriteLine($"Program state: {state.Value.State}");

// Stop and power off
robot.Rest.Stop();
robot.Rest.PowerOff();
```

### Standalone REST Client

You can also use the REST client independently:

```csharp
using UnderAutomation.UniversalRobots.Rest;

var restClient = new RestClient();
restClient.Enable("192.168.0.1");

restClient.PowerOn();
restClient.BrakeRelease();
restClient.LoadProgram("my_program");
restClient.Play();

restClient.Disable();
```

### Connection Parameters

The `RestConnectParameters` class provides full configuration:

| Property | Default | Description |
|----------|---------|-------------|
| `Enable` | `false` | Enable REST API client |
| `Port` | `80` | HTTP port for REST API |
| `Version` | `Latest` | REST API version (`V1` or `Latest`) |
| `TimeoutMs` | `5000` | Request timeout in milliseconds |

### Migration from Dashboard Server

If you're migrating from a legacy robot to PolyscopeX, update your connection parameters:

```csharp
// Before (CB-series / e-Series with Dashboard Server)
robot.Connect(new ConnectParameters("192.168.0.1")
{
    Dashboard = { Enable = true }
});
robot.Dashboard.PowerOn();

// After (PolyscopeX with REST API)
robot.Connect(new ConnectParameters("192.168.0.1")
{
    Rest = { Enable = true }
});
robot.Rest.PowerOn();
```

REST API is still under development, so it is not yet fully equivalent to the Dashboard Server.

---

## New PRO License

This release introduces a new **PRO License** tier, providing more flexibility in our licensing model. The previous "Site License" has evolved into two distinct offers: **Standard** and **Pro**.

### Key Points

- **Perpetual licenses**: All licenses are perpetual and allow unlimited redistribution of your compiled application
- **Upgrade path**: You can upgrade from Standard → Source or Pro → Source by paying the price difference
- **Pro advantage**: Includes 3 years of maintenance and 2 hours of remote support at a discounted bundle price

For complete pricing and details, visit: https://underautomation.com/license
