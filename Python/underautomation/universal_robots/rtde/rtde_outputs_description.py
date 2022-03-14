import typing
from underautomation.universal_robots.rtde.rtde_output_data_description import RtdeOutputDataDescription
from underautomation.universal_robots.rtde.rtde_output_data import RtdeOutputData
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..",  'lib', 'UnderAutomation.UniversalRobots.dll')))
from UnderAutomation.UniversalRobots.Rtde import RtdeOutputsDescription as rtde_outputs_description

class RtdeOutputsDescription:
	def __init__(self, _internal = 0):
		if(_internal == 0):
			self._instance = rtde_outputs_description()
		else:
			self._instance = _internal
	def get(self, data: RtdeOutputData) -> RtdeOutputDataDescription:
		return RtdeOutputDataDescription(self._instance.Get(data._instance))
	@property
	def items(self) -> typing.Any:
		return self._instance.Items
	@property
	def timestamp(self) -> RtdeOutputDataDescription:
		return RtdeOutputDataDescription(self._instance.Timestamp)
	@property
	def target_q(self) -> RtdeOutputDataDescription:
		return RtdeOutputDataDescription(self._instance.TargetQ)
	@property
	def target_qd(self) -> RtdeOutputDataDescription:
		return RtdeOutputDataDescription(self._instance.TargetQd)
	@property
	def target_qdd(self) -> RtdeOutputDataDescription:
		return RtdeOutputDataDescription(self._instance.TargetQdd)
	@property
	def target_current(self) -> RtdeOutputDataDescription:
		return RtdeOutputDataDescription(self._instance.TargetCurrent)
	@property
	def target_moment(self) -> RtdeOutputDataDescription:
		return RtdeOutputDataDescription(self._instance.TargetMoment)
	@property
	def actual_q(self) -> RtdeOutputDataDescription:
		return RtdeOutputDataDescription(self._instance.ActualQ)
	@property
	def actual_qd(self) -> RtdeOutputDataDescription:
		return RtdeOutputDataDescription(self._instance.ActualQd)
	@property
	def actual_current(self) -> RtdeOutputDataDescription:
		return RtdeOutputDataDescription(self._instance.ActualCurrent)
	@property
	def joint_control_output(self) -> RtdeOutputDataDescription:
		return RtdeOutputDataDescription(self._instance.JointControlOutput)
	@property
	def actual_tcp_pose(self) -> RtdeOutputDataDescription:
		return RtdeOutputDataDescription(self._instance.ActualTcpPose)
	@property
	def actual_tcp_speed(self) -> RtdeOutputDataDescription:
		return RtdeOutputDataDescription(self._instance.ActualTcpSpeed)
	@property
	def actual_tcp_force(self) -> RtdeOutputDataDescription:
		return RtdeOutputDataDescription(self._instance.ActualTcpForce)
	@property
	def target_tcp_pose(self) -> RtdeOutputDataDescription:
		return RtdeOutputDataDescription(self._instance.TargetTcpPose)
	@property
	def target_tcp_speed(self) -> RtdeOutputDataDescription:
		return RtdeOutputDataDescription(self._instance.TargetTcpSpeed)
	@property
	def actual_digital_input_bits(self) -> RtdeOutputDataDescription:
		return RtdeOutputDataDescription(self._instance.ActualDigitalInputBits)
	@property
	def joint_temperatures(self) -> RtdeOutputDataDescription:
		return RtdeOutputDataDescription(self._instance.JointTemperatures)
	@property
	def actual_execution_time(self) -> RtdeOutputDataDescription:
		return RtdeOutputDataDescription(self._instance.ActualExecutionTime)
	@property
	def robot_mode(self) -> RtdeOutputDataDescription:
		return RtdeOutputDataDescription(self._instance.RobotMode)
	@property
	def joint_mode(self) -> RtdeOutputDataDescription:
		return RtdeOutputDataDescription(self._instance.JointMode)
	@property
	def safety_mode(self) -> RtdeOutputDataDescription:
		return RtdeOutputDataDescription(self._instance.SafetyMode)
	@property
	def safety_status(self) -> RtdeOutputDataDescription:
		return RtdeOutputDataDescription(self._instance.SafetyStatus)
	@property
	def actual_tool_accelerometer(self) -> RtdeOutputDataDescription:
		return RtdeOutputDataDescription(self._instance.ActualToolAccelerometer)
	@property
	def speed_scaling(self) -> RtdeOutputDataDescription:
		return RtdeOutputDataDescription(self._instance.SpeedScaling)
	@property
	def target_speed_fraction(self) -> RtdeOutputDataDescription:
		return RtdeOutputDataDescription(self._instance.TargetSpeedFraction)
	@property
	def actual_momentum(self) -> RtdeOutputDataDescription:
		return RtdeOutputDataDescription(self._instance.ActualMomentum)
	@property
	def actual_main_voltage(self) -> RtdeOutputDataDescription:
		return RtdeOutputDataDescription(self._instance.ActualMainVoltage)
	@property
	def actual_robot_voltage(self) -> RtdeOutputDataDescription:
		return RtdeOutputDataDescription(self._instance.ActualRobotVoltage)
	@property
	def actual_robot_current(self) -> RtdeOutputDataDescription:
		return RtdeOutputDataDescription(self._instance.ActualRobotCurrent)
	@property
	def actual_joint_voltage(self) -> RtdeOutputDataDescription:
		return RtdeOutputDataDescription(self._instance.ActualJointVoltage)
	@property
	def actual_digital_output_bits(self) -> RtdeOutputDataDescription:
		return RtdeOutputDataDescription(self._instance.ActualDigitalOutputBits)
	@property
	def runtime_state(self) -> RtdeOutputDataDescription:
		return RtdeOutputDataDescription(self._instance.RuntimeState)
	@property
	def elbow_position(self) -> RtdeOutputDataDescription:
		return RtdeOutputDataDescription(self._instance.ElbowPosition)
	@property
	def elbow_velocity(self) -> RtdeOutputDataDescription:
		return RtdeOutputDataDescription(self._instance.ElbowVelocity)
	@property
	def robot_status_bits(self) -> RtdeOutputDataDescription:
		return RtdeOutputDataDescription(self._instance.RobotStatusBits)
	@property
	def safety_status_bits(self) -> RtdeOutputDataDescription:
		return RtdeOutputDataDescription(self._instance.SafetyStatusBits)
	@property
	def analog_io_types(self) -> RtdeOutputDataDescription:
		return RtdeOutputDataDescription(self._instance.AnalogIOTypes)
	@property
	def standard_analog_input0(self) -> RtdeOutputDataDescription:
		return RtdeOutputDataDescription(self._instance.StandardAnalogInput0)
	@property
	def standard_analog_input1(self) -> RtdeOutputDataDescription:
		return RtdeOutputDataDescription(self._instance.StandardAnalogInput1)
	@property
	def standard_analog_output0(self) -> RtdeOutputDataDescription:
		return RtdeOutputDataDescription(self._instance.StandardAnalogOutput0)
	@property
	def standard_analog_output1(self) -> RtdeOutputDataDescription:
		return RtdeOutputDataDescription(self._instance.StandardAnalogOutput1)
	@property
	def io_current(self) -> RtdeOutputDataDescription:
		return RtdeOutputDataDescription(self._instance.IOCurrent)
	@property
	def euromap67_input_bits(self) -> RtdeOutputDataDescription:
		return RtdeOutputDataDescription(self._instance.Euromap67InputBits)
	@property
	def euromap67_output_bits(self) -> RtdeOutputDataDescription:
		return RtdeOutputDataDescription(self._instance.Euromap67OutputBits)
	@property
	def euromap67_24_v_voltage(self) -> RtdeOutputDataDescription:
		return RtdeOutputDataDescription(self._instance.Euromap67_24VVoltage)
	@property
	def euromap67_24_v_current(self) -> RtdeOutputDataDescription:
		return RtdeOutputDataDescription(self._instance.Euromap67_24VCurrent)
	@property
	def tool_mode(self) -> RtdeOutputDataDescription:
		return RtdeOutputDataDescription(self._instance.ToolMode)
	@property
	def tool_analog_input_types(self) -> RtdeOutputDataDescription:
		return RtdeOutputDataDescription(self._instance.ToolAnalogInputTypes)
	@property
	def tool_analog_input0(self) -> RtdeOutputDataDescription:
		return RtdeOutputDataDescription(self._instance.ToolAnalogInput0)
	@property
	def tool_analog_input1(self) -> RtdeOutputDataDescription:
		return RtdeOutputDataDescription(self._instance.ToolAnalogInput1)
	@property
	def tool_output_voltage(self) -> RtdeOutputDataDescription:
		return RtdeOutputDataDescription(self._instance.ToolOutputVoltage)
	@property
	def tool_output_current(self) -> RtdeOutputDataDescription:
		return RtdeOutputDataDescription(self._instance.ToolOutputCurrent)
	@property
	def tool_temperature(self) -> RtdeOutputDataDescription:
		return RtdeOutputDataDescription(self._instance.ToolTemperature)
	@property
	def tcp_force_scalar(self) -> RtdeOutputDataDescription:
		return RtdeOutputDataDescription(self._instance.TcpForceScalar)
	@property
	def output_bit_registers0_to31(self) -> RtdeOutputDataDescription:
		return RtdeOutputDataDescription(self._instance.OutputBitRegisters0To31)
	@property
	def output_bit_registers32_to63(self) -> RtdeOutputDataDescription:
		return RtdeOutputDataDescription(self._instance.OutputBitRegisters32To63)
	@property
	def output_bit_registers(self) -> RtdeOutputDataDescription:
		return RtdeOutputDataDescription(self._instance.OutputBitRegisters)
	@property
	def output_int_registers(self) -> RtdeOutputDataDescription:
		return RtdeOutputDataDescription(self._instance.OutputIntRegisters)
	@property
	def output_double_registers(self) -> RtdeOutputDataDescription:
		return RtdeOutputDataDescription(self._instance.OutputDoubleRegisters)
	@property
	def input_bit_registers0_to31(self) -> RtdeOutputDataDescription:
		return RtdeOutputDataDescription(self._instance.InputBitRegisters0To31)
	@property
	def input_bit_registers32_to63(self) -> RtdeOutputDataDescription:
		return RtdeOutputDataDescription(self._instance.InputBitRegisters32To63)
	@property
	def input_bit_registers(self) -> RtdeOutputDataDescription:
		return RtdeOutputDataDescription(self._instance.InputBitRegisters)
	@property
	def input_int_registers(self) -> RtdeOutputDataDescription:
		return RtdeOutputDataDescription(self._instance.InputIntRegisters)
	@property
	def input_double_registers(self) -> RtdeOutputDataDescription:
		return RtdeOutputDataDescription(self._instance.InputDoubleRegisters)
	@property
	def tool_output_mode(self) -> RtdeOutputDataDescription:
		return RtdeOutputDataDescription(self._instance.ToolOutputMode)
	@property
	def tool_digital_output0mode(self) -> RtdeOutputDataDescription:
		return RtdeOutputDataDescription(self._instance.ToolDigitalOutput0mode)
	@property
	def tool_digital_output1_mode(self) -> RtdeOutputDataDescription:
		return RtdeOutputDataDescription(self._instance.ToolDigitalOutput1Mode)
	@property
	def payload(self) -> RtdeOutputDataDescription:
		return RtdeOutputDataDescription(self._instance.Payload)
	@property
	def payload_cog(self) -> RtdeOutputDataDescription:
		return RtdeOutputDataDescription(self._instance.PayloadCOG)
	@property
	def payload_inertia(self) -> RtdeOutputDataDescription:
		return RtdeOutputDataDescription(self._instance.PayloadInertia)
	@property
	def script_control_line(self) -> RtdeOutputDataDescription:
		return RtdeOutputDataDescription(self._instance.ScriptControlLine)
	@property
	def ft_raw_wrench(self) -> RtdeOutputDataDescription:
		return RtdeOutputDataDescription(self._instance.FTRawWrench)
