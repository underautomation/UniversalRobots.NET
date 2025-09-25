[![UnderAutomation Universal Robots communication SDK](https://raw.githubusercontent.com/underautomation/UniversalRobots.NET/refs/heads/main/.github/assets/banner.png)](https://underautomation.com)

- Implement forward and invert kinematics

```C#
using UnderAutomation.UniversalRobots.Kinematics;

// Get DH parameters
IUrDhParameters dhParameters = KinematicsUtils.GetDhParametersFromModel(RobotModelsExtended.Ur5e);

// Forward kinematics
double[] joints = new double[]{0.0, 0.1, 0.0, 0.2, -0.3, 0};
var fkResult = KinematicsUtils.ForwardKinematics(joints, dhParameters);

// inverse kinematics
Pose cartesianPose = Pose.From4x4MatrixToRotationVector(fkResult.ToolTransform);
var matrix = cartesianPose.FromRotationVectorTo4x4Matrix();
double[][] ikResults = KinematicsUtils.InverseKinematics(matrix, dhParameters);
```
