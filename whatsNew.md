## New arm models: UR18 and UR8L

The SDK now supports two additional robot models: UR18 and UR8 Long (UR8L).

The Dashboard `GetRobotModel()` method returns the correct value for these models. Denavit-Hartenberg parameters for both models are also available for kinematics calculations.

```csharp
// Read the robot model from the Dashboard
CommandResponse<RobotModels> response = ur.Dashboard.GetRobotModel();
// response.Value is now RobotModels.UR18 or RobotModels.UR8L for the new models

// Use DH parameters for UR18 or UR8 Long in kinematics
IUrDhParameters dh = KinematicsUtils.GetDhParametersFromModel(RobotModelsExtended.UR18);
IUrDhParameters dhLong = KinematicsUtils.GetDhParametersFromModel(RobotModelsExtended.UR8Long);
```
