import typing
from underautomation.universal_robots.common.robot_modes import RobotModes
from underautomation.universal_robots.common.control_modes import ControlModes
from underautomation.universal_robots.common.package_event_args import PackageEventArgs
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..",  'lib', 'UnderAutomation.UniversalRobots.dll')))
from UnderAutomation.UniversalRobots.PrimaryInterface import RobotModeDataPackageEventArgs as robot_mode_data_package_event_args

class RobotModeDataPackageEventArgs(PackageEventArgs):
	def __init__(self, _internal = 0):
		if(_internal == 0):
			self._instance = robot_mode_data_package_event_args()
		else:
			self._instance = _internal
	@property
	def timestamp(self) -> typing.Any:
		return self._instance.Timestamp
	@timestamp.setter
	def timestamp(self, value: typing.Any):
		self._instance.Timestamp = value
	@property
	def physical_robot_connected(self) -> bool:
		return self._instance.PhysicalRobotConnected
	@physical_robot_connected.setter
	def physical_robot_connected(self, value: bool):
		self._instance.PhysicalRobotConnected = value
	@property
	def real_robot_enabled(self) -> bool:
		return self._instance.RealRobotEnabled
	@real_robot_enabled.setter
	def real_robot_enabled(self, value: bool):
		self._instance.RealRobotEnabled = value
	@property
	def robot_power_on(self) -> bool:
		return self._instance.RobotPowerOn
	@robot_power_on.setter
	def robot_power_on(self, value: bool):
		self._instance.RobotPowerOn = value
	@property
	def emergency_stopped(self) -> bool:
		return self._instance.EmergencyStopped
	@emergency_stopped.setter
	def emergency_stopped(self, value: bool):
		self._instance.EmergencyStopped = value
	@property
	def protective_stopped(self) -> bool:
		return self._instance.ProtectiveStopped
	@protective_stopped.setter
	def protective_stopped(self, value: bool):
		self._instance.ProtectiveStopped = value
	@property
	def program_running(self) -> bool:
		return self._instance.ProgramRunning
	@program_running.setter
	def program_running(self, value: bool):
		self._instance.ProgramRunning = value
	@property
	def program_paused(self) -> bool:
		return self._instance.ProgramPaused
	@program_paused.setter
	def program_paused(self, value: bool):
		self._instance.ProgramPaused = value
	@property
	def robot_mode(self) -> RobotModes:
		return RobotModes(self._instance.RobotMode)
	@robot_mode.setter
	def robot_mode(self, value: RobotModes):
		self._instance.RobotMode = value
	@property
	def control_mode(self) -> ControlModes:
		return ControlModes(self._instance.ControlMode)
	@control_mode.setter
	def control_mode(self, value: ControlModes):
		self._instance.ControlMode = value
	@property
	def target_speed_fraction(self) -> float:
		return self._instance.TargetSpeedFraction
	@target_speed_fraction.setter
	def target_speed_fraction(self, value: float):
		self._instance.TargetSpeedFraction = value
	@property
	def speed_scaling(self) -> float:
		return self._instance.SpeedScaling
	@speed_scaling.setter
	def speed_scaling(self, value: float):
		self._instance.SpeedScaling = value
	@property
	def target_speed_fraction_limit(self) -> float:
		return self._instance.TargetSpeedFractionLimit
	@target_speed_fraction_limit.setter
	def target_speed_fraction_limit(self, value: float):
		self._instance.TargetSpeedFractionLimit = value
