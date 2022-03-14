import typing
from underautomation.universal_robots.rtde.rtde_output_setup_item import RtdeOutputSetupItem
from underautomation.universal_robots.common.joints_double_values import JointsDoubleValues
from underautomation.universal_robots.common.pose import Pose
from underautomation.universal_robots.common.cartesian_coordinates import CartesianCoordinates
from underautomation.universal_robots.common.joints_int_values import JointsIntValues
from underautomation.universal_robots.common.vector3_d import Vector3D
from underautomation.universal_robots.rtde.rtde_bit_registers_value import RtdeBitRegistersValue
from underautomation.universal_robots.rtde.rtde_int_registers_value import RtdeIntRegistersValue
from underautomation.universal_robots.rtde.rtde_double_registers_value import RtdeDoubleRegistersValue
from underautomation.universal_robots.rtde.rtde_base_values_1 import RtdeBaseValues1
from underautomation.universal_robots.rtde.rtde_output_data import RtdeOutputData
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..",  'lib', 'UnderAutomation.UniversalRobots.dll')))
from UnderAutomation.UniversalRobots.Rtde import RtdeOutputValues as rtde_output_values

class RtdeOutputValues(RtdeBaseValues1[RtdeOutputData]):
	def __init__(self, _internal = 0):
		if(_internal == 0):
			self._instance = rtde_output_values()
		else:
			self._instance = _internal
	def get_value(self, item: RtdeOutputSetupItem) -> typing.Any:
		return self._instance.GetValue(item._instance)
	@property
	def timestamp(self) -> float:
		return self._instance.Timestamp
	@timestamp.setter
	def timestamp(self, value: float):
		self._instance.Timestamp = value
	@property
	def target_q(self) -> JointsDoubleValues:
		return JointsDoubleValues(self._instance.TargetQ)
	@target_q.setter
	def target_q(self, value: JointsDoubleValues):
		self._instance.TargetQ = value
	@property
	def target_qd(self) -> JointsDoubleValues:
		return JointsDoubleValues(self._instance.TargetQd)
	@target_qd.setter
	def target_qd(self, value: JointsDoubleValues):
		self._instance.TargetQd = value
	@property
	def target_qdd(self) -> JointsDoubleValues:
		return JointsDoubleValues(self._instance.TargetQdd)
	@target_qdd.setter
	def target_qdd(self, value: JointsDoubleValues):
		self._instance.TargetQdd = value
	@property
	def target_current(self) -> JointsDoubleValues:
		return JointsDoubleValues(self._instance.TargetCurrent)
	@target_current.setter
	def target_current(self, value: JointsDoubleValues):
		self._instance.TargetCurrent = value
	@property
	def target_moment(self) -> JointsDoubleValues:
		return JointsDoubleValues(self._instance.TargetMoment)
	@target_moment.setter
	def target_moment(self, value: JointsDoubleValues):
		self._instance.TargetMoment = value
	@property
	def actual_q(self) -> JointsDoubleValues:
		return JointsDoubleValues(self._instance.ActualQ)
	@actual_q.setter
	def actual_q(self, value: JointsDoubleValues):
		self._instance.ActualQ = value
	@property
	def actual_qd(self) -> JointsDoubleValues:
		return JointsDoubleValues(self._instance.ActualQd)
	@actual_qd.setter
	def actual_qd(self, value: JointsDoubleValues):
		self._instance.ActualQd = value
	@property
	def actual_current(self) -> JointsDoubleValues:
		return JointsDoubleValues(self._instance.ActualCurrent)
	@actual_current.setter
	def actual_current(self, value: JointsDoubleValues):
		self._instance.ActualCurrent = value
	@property
	def joint_control_output(self) -> JointsDoubleValues:
		return JointsDoubleValues(self._instance.JointControlOutput)
	@joint_control_output.setter
	def joint_control_output(self, value: JointsDoubleValues):
		self._instance.JointControlOutput = value
	@property
	def actual_tcp_pose(self) -> Pose:
		return Pose(None, None, None, None, None, None, self._instance.ActualTcpPose)
	@actual_tcp_pose.setter
	def actual_tcp_pose(self, value: Pose):
		self._instance.ActualTcpPose = value
	@property
	def actual_tcp_speed(self) -> Pose:
		return Pose(None, None, None, None, None, None, self._instance.ActualTcpSpeed)
	@actual_tcp_speed.setter
	def actual_tcp_speed(self, value: Pose):
		self._instance.ActualTcpSpeed = value
	@property
	def actual_tcp_force(self) -> CartesianCoordinates:
		return CartesianCoordinates(None, None, None, None, None, None, self._instance.ActualTcpForce)
	@actual_tcp_force.setter
	def actual_tcp_force(self, value: CartesianCoordinates):
		self._instance.ActualTcpForce = value
	@property
	def target_tcp_pose(self) -> Pose:
		return Pose(None, None, None, None, None, None, self._instance.TargetTcpPose)
	@target_tcp_pose.setter
	def target_tcp_pose(self, value: Pose):
		self._instance.TargetTcpPose = value
	@property
	def target_tcp_speed(self) -> Pose:
		return Pose(None, None, None, None, None, None, self._instance.TargetTcpSpeed)
	@target_tcp_speed.setter
	def target_tcp_speed(self, value: Pose):
		self._instance.TargetTcpSpeed = value
	@property
	def actual_digital_input_bits(self) -> int:
		return self._instance.ActualDigitalInputBits
	@actual_digital_input_bits.setter
	def actual_digital_input_bits(self, value: int):
		self._instance.ActualDigitalInputBits = value
	@property
	def joint_temperatures(self) -> JointsDoubleValues:
		return JointsDoubleValues(self._instance.JointTemperatures)
	@joint_temperatures.setter
	def joint_temperatures(self, value: JointsDoubleValues):
		self._instance.JointTemperatures = value
	@property
	def actual_execution_time(self) -> float:
		return self._instance.ActualExecutionTime
	@actual_execution_time.setter
	def actual_execution_time(self, value: float):
		self._instance.ActualExecutionTime = value
	@property
	def robot_mode(self) -> int:
		return self._instance.RobotMode
	@robot_mode.setter
	def robot_mode(self, value: int):
		self._instance.RobotMode = value
	@property
	def joint_mode(self) -> JointsIntValues:
		return JointsIntValues(self._instance.JointMode)
	@joint_mode.setter
	def joint_mode(self, value: JointsIntValues):
		self._instance.JointMode = value
	@property
	def safety_mode(self) -> int:
		return self._instance.SafetyMode
	@safety_mode.setter
	def safety_mode(self, value: int):
		self._instance.SafetyMode = value
	@property
	def safety_status(self) -> int:
		return self._instance.SafetyStatus
	@safety_status.setter
	def safety_status(self, value: int):
		self._instance.SafetyStatus = value
	@property
	def actual_tool_accelerometer(self) -> Vector3D:
		return Vector3D(self._instance.ActualToolAccelerometer)
	@actual_tool_accelerometer.setter
	def actual_tool_accelerometer(self, value: Vector3D):
		self._instance.ActualToolAccelerometer = value
	@property
	def speed_scaling(self) -> float:
		return self._instance.SpeedScaling
	@speed_scaling.setter
	def speed_scaling(self, value: float):
		self._instance.SpeedScaling = value
	@property
	def target_speed_fraction(self) -> float:
		return self._instance.TargetSpeedFraction
	@target_speed_fraction.setter
	def target_speed_fraction(self, value: float):
		self._instance.TargetSpeedFraction = value
	@property
	def actual_momentum(self) -> float:
		return self._instance.ActualMomentum
	@actual_momentum.setter
	def actual_momentum(self, value: float):
		self._instance.ActualMomentum = value
	@property
	def actual_main_voltage(self) -> float:
		return self._instance.ActualMainVoltage
	@actual_main_voltage.setter
	def actual_main_voltage(self, value: float):
		self._instance.ActualMainVoltage = value
	@property
	def actual_robot_voltage(self) -> float:
		return self._instance.ActualRobotVoltage
	@actual_robot_voltage.setter
	def actual_robot_voltage(self, value: float):
		self._instance.ActualRobotVoltage = value
	@property
	def actual_robot_current(self) -> float:
		return self._instance.ActualRobotCurrent
	@actual_robot_current.setter
	def actual_robot_current(self, value: float):
		self._instance.ActualRobotCurrent = value
	@property
	def actual_joint_voltage(self) -> JointsDoubleValues:
		return JointsDoubleValues(self._instance.ActualJointVoltage)
	@actual_joint_voltage.setter
	def actual_joint_voltage(self, value: JointsDoubleValues):
		self._instance.ActualJointVoltage = value
	@property
	def actual_digital_output_bits(self) -> int:
		return self._instance.ActualDigitalOutputBits
	@actual_digital_output_bits.setter
	def actual_digital_output_bits(self, value: int):
		self._instance.ActualDigitalOutputBits = value
	@property
	def runtime_state(self) -> int:
		return self._instance.RuntimeState
	@runtime_state.setter
	def runtime_state(self, value: int):
		self._instance.RuntimeState = value
	@property
	def elbow_position(self) -> Vector3D:
		return Vector3D(self._instance.ElbowPosition)
	@elbow_position.setter
	def elbow_position(self, value: Vector3D):
		self._instance.ElbowPosition = value
	@property
	def elbow_velocity(self) -> Vector3D:
		return Vector3D(self._instance.ElbowVelocity)
	@elbow_velocity.setter
	def elbow_velocity(self, value: Vector3D):
		self._instance.ElbowVelocity = value
	@property
	def robot_status_bits(self) -> int:
		return self._instance.RobotStatusBits
	@robot_status_bits.setter
	def robot_status_bits(self, value: int):
		self._instance.RobotStatusBits = value
	@property
	def safety_status_bits(self) -> int:
		return self._instance.SafetyStatusBits
	@safety_status_bits.setter
	def safety_status_bits(self, value: int):
		self._instance.SafetyStatusBits = value
	@property
	def analog_io_types(self) -> int:
		return self._instance.AnalogIOTypes
	@analog_io_types.setter
	def analog_io_types(self, value: int):
		self._instance.AnalogIOTypes = value
	@property
	def standard_analog_input0(self) -> float:
		return self._instance.StandardAnalogInput0
	@standard_analog_input0.setter
	def standard_analog_input0(self, value: float):
		self._instance.StandardAnalogInput0 = value
	@property
	def standard_analog_input1(self) -> float:
		return self._instance.StandardAnalogInput1
	@standard_analog_input1.setter
	def standard_analog_input1(self, value: float):
		self._instance.StandardAnalogInput1 = value
	@property
	def standard_analog_output0(self) -> float:
		return self._instance.StandardAnalogOutput0
	@standard_analog_output0.setter
	def standard_analog_output0(self, value: float):
		self._instance.StandardAnalogOutput0 = value
	@property
	def standard_analog_output1(self) -> float:
		return self._instance.StandardAnalogOutput1
	@standard_analog_output1.setter
	def standard_analog_output1(self, value: float):
		self._instance.StandardAnalogOutput1 = value
	@property
	def io_current(self) -> float:
		return self._instance.IOCurrent
	@io_current.setter
	def io_current(self, value: float):
		self._instance.IOCurrent = value
	@property
	def euromap67_input_bits(self) -> int:
		return self._instance.Euromap67InputBits
	@euromap67_input_bits.setter
	def euromap67_input_bits(self, value: int):
		self._instance.Euromap67InputBits = value
	@property
	def euromap67_output_bits(self) -> int:
		return self._instance.Euromap67OutputBits
	@euromap67_output_bits.setter
	def euromap67_output_bits(self, value: int):
		self._instance.Euromap67OutputBits = value
	@property
	def euromap67_24_v_voltage(self) -> float:
		return self._instance.Euromap67_24VVoltage
	@euromap67_24_v_voltage.setter
	def euromap67_24_v_voltage(self, value: float):
		self._instance.Euromap67_24VVoltage = value
	@property
	def euromap67_24_v_current(self) -> float:
		return self._instance.Euromap67_24VCurrent
	@euromap67_24_v_current.setter
	def euromap67_24_v_current(self, value: float):
		self._instance.Euromap67_24VCurrent = value
	@property
	def tool_mode(self) -> int:
		return self._instance.ToolMode
	@tool_mode.setter
	def tool_mode(self, value: int):
		self._instance.ToolMode = value
	@property
	def tool_analog_input_types(self) -> int:
		return self._instance.ToolAnalogInputTypes
	@tool_analog_input_types.setter
	def tool_analog_input_types(self, value: int):
		self._instance.ToolAnalogInputTypes = value
	@property
	def tool_analog_input0(self) -> float:
		return self._instance.ToolAnalogInput0
	@tool_analog_input0.setter
	def tool_analog_input0(self, value: float):
		self._instance.ToolAnalogInput0 = value
	@property
	def tool_analog_input1(self) -> float:
		return self._instance.ToolAnalogInput1
	@tool_analog_input1.setter
	def tool_analog_input1(self, value: float):
		self._instance.ToolAnalogInput1 = value
	@property
	def tool_output_voltage(self) -> int:
		return self._instance.ToolOutputVoltage
	@tool_output_voltage.setter
	def tool_output_voltage(self, value: int):
		self._instance.ToolOutputVoltage = value
	@property
	def tool_output_current(self) -> float:
		return self._instance.ToolOutputCurrent
	@tool_output_current.setter
	def tool_output_current(self, value: float):
		self._instance.ToolOutputCurrent = value
	@property
	def tool_temperature(self) -> float:
		return self._instance.ToolTemperature
	@tool_temperature.setter
	def tool_temperature(self, value: float):
		self._instance.ToolTemperature = value
	@property
	def tcp_force_scalar(self) -> float:
		return self._instance.TcpForceScalar
	@tcp_force_scalar.setter
	def tcp_force_scalar(self, value: float):
		self._instance.TcpForceScalar = value
	@property
	def output_bit_registers0_to31(self) -> int:
		return self._instance.OutputBitRegisters0To31
	@output_bit_registers0_to31.setter
	def output_bit_registers0_to31(self, value: int):
		self._instance.OutputBitRegisters0To31 = value
	@property
	def output_bit_registers32_to63(self) -> int:
		return self._instance.OutputBitRegisters32To63
	@output_bit_registers32_to63.setter
	def output_bit_registers32_to63(self, value: int):
		self._instance.OutputBitRegisters32To63 = value
	@property
	def output_bit_registers(self) -> RtdeBitRegistersValue:
		return RtdeBitRegistersValue(self._instance.OutputBitRegisters)
	@property
	def output_int_registers(self) -> RtdeIntRegistersValue:
		return RtdeIntRegistersValue(self._instance.OutputIntRegisters)
	@property
	def output_double_registers(self) -> RtdeDoubleRegistersValue:
		return RtdeDoubleRegistersValue(self._instance.OutputDoubleRegisters)
	@property
	def input_bit_registers0_to31(self) -> int:
		return self._instance.InputBitRegisters0To31
	@input_bit_registers0_to31.setter
	def input_bit_registers0_to31(self, value: int):
		self._instance.InputBitRegisters0To31 = value
	@property
	def input_bit_registers32_to63(self) -> int:
		return self._instance.InputBitRegisters32To63
	@input_bit_registers32_to63.setter
	def input_bit_registers32_to63(self, value: int):
		self._instance.InputBitRegisters32To63 = value
	@property
	def input_bit_registers(self) -> RtdeBitRegistersValue:
		return RtdeBitRegistersValue(self._instance.InputBitRegisters)
	@property
	def input_int_registers(self) -> RtdeIntRegistersValue:
		return RtdeIntRegistersValue(self._instance.InputIntRegisters)
	@property
	def input_double_registers(self) -> RtdeDoubleRegistersValue:
		return RtdeDoubleRegistersValue(self._instance.InputDoubleRegisters)
	@property
	def tool_output_mode(self) -> int:
		return self._instance.ToolOutputMode
	@tool_output_mode.setter
	def tool_output_mode(self, value: int):
		self._instance.ToolOutputMode = value
	@property
	def tool_digital_output0mode(self) -> int:
		return self._instance.ToolDigitalOutput0mode
	@tool_digital_output0mode.setter
	def tool_digital_output0mode(self, value: int):
		self._instance.ToolDigitalOutput0mode = value
	@property
	def tool_digital_output1_mode(self) -> int:
		return self._instance.ToolDigitalOutput1Mode
	@tool_digital_output1_mode.setter
	def tool_digital_output1_mode(self, value: int):
		self._instance.ToolDigitalOutput1Mode = value
	@property
	def payload(self) -> float:
		return self._instance.Payload
	@payload.setter
	def payload(self, value: float):
		self._instance.Payload = value
	@property
	def payload_cog(self) -> Vector3D:
		return Vector3D(self._instance.PayloadCOG)
	@payload_cog.setter
	def payload_cog(self, value: Vector3D):
		self._instance.PayloadCOG = value
	@property
	def payload_inertia(self) -> CartesianCoordinates:
		return CartesianCoordinates(None, None, None, None, None, None, self._instance.PayloadInertia)
	@payload_inertia.setter
	def payload_inertia(self, value: CartesianCoordinates):
		self._instance.PayloadInertia = value
	@property
	def script_control_line(self) -> int:
		return self._instance.ScriptControlLine
	@script_control_line.setter
	def script_control_line(self, value: int):
		self._instance.ScriptControlLine = value
	@property
	def ft_raw_wrench(self) -> CartesianCoordinates:
		return CartesianCoordinates(None, None, None, None, None, None, self._instance.FTRawWrench)
	@ft_raw_wrench.setter
	def ft_raw_wrench(self, value: CartesianCoordinates):
		self._instance.FTRawWrench = value
