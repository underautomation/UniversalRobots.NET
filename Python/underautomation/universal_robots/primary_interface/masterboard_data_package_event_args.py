import typing
from underautomation.universal_robots.common.analog_ranges import AnalogRanges
from underautomation.universal_robots.common.safety_status import SafetyStatus
from underautomation.universal_robots.primary_interface.masterboard_digital_io import MasterboardDigitalIO
from underautomation.universal_robots.common.package_event_args import PackageEventArgs
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..",  'lib', 'UnderAutomation.UniversalRobots.dll')))
from UnderAutomation.UniversalRobots.PrimaryInterface import MasterboardDataPackageEventArgs as masterboard_data_package_event_args

class MasterboardDataPackageEventArgs(PackageEventArgs):
	def __init__(self, _internal = 0):
		if(_internal == 0):
			self._instance = masterboard_data_package_event_args()
		else:
			self._instance = _internal
	@property
	def analog_input_range0(self) -> AnalogRanges:
		return AnalogRanges(self._instance.AnalogInputRange0)
	@analog_input_range0.setter
	def analog_input_range0(self, value: AnalogRanges):
		self._instance.AnalogInputRange0 = value
	@property
	def analog_input_range1(self) -> AnalogRanges:
		return AnalogRanges(self._instance.AnalogInputRange1)
	@analog_input_range1.setter
	def analog_input_range1(self, value: AnalogRanges):
		self._instance.AnalogInputRange1 = value
	@property
	def analog_input0(self) -> float:
		return self._instance.AnalogInput0
	@analog_input0.setter
	def analog_input0(self, value: float):
		self._instance.AnalogInput0 = value
	@property
	def analog_input1(self) -> float:
		return self._instance.AnalogInput1
	@analog_input1.setter
	def analog_input1(self, value: float):
		self._instance.AnalogInput1 = value
	@property
	def analog_output_domain0(self) -> AnalogRanges:
		return AnalogRanges(self._instance.AnalogOutputDomain0)
	@analog_output_domain0.setter
	def analog_output_domain0(self, value: AnalogRanges):
		self._instance.AnalogOutputDomain0 = value
	@property
	def analog_output_domain1(self) -> AnalogRanges:
		return AnalogRanges(self._instance.AnalogOutputDomain1)
	@analog_output_domain1.setter
	def analog_output_domain1(self, value: AnalogRanges):
		self._instance.AnalogOutputDomain1 = value
	@property
	def analog_output0(self) -> float:
		return self._instance.AnalogOutput0
	@analog_output0.setter
	def analog_output0(self, value: float):
		self._instance.AnalogOutput0 = value
	@property
	def analog_output1(self) -> float:
		return self._instance.AnalogOutput1
	@analog_output1.setter
	def analog_output1(self, value: float):
		self._instance.AnalogOutput1 = value
	@property
	def masterboard_temperature(self) -> float:
		return self._instance.MasterboardTemperature
	@masterboard_temperature.setter
	def masterboard_temperature(self, value: float):
		self._instance.MasterboardTemperature = value
	@property
	def robot_voltage48_v(self) -> float:
		return self._instance.RobotVoltage48V
	@robot_voltage48_v.setter
	def robot_voltage48_v(self, value: float):
		self._instance.RobotVoltage48V = value
	@property
	def robot_current(self) -> float:
		return self._instance.RobotCurrent
	@robot_current.setter
	def robot_current(self, value: float):
		self._instance.RobotCurrent = value
	@property
	def master_io_current(self) -> float:
		return self._instance.MasterIOCurrent
	@master_io_current.setter
	def master_io_current(self, value: float):
		self._instance.MasterIOCurrent = value
	@property
	def safetymode(self) -> SafetyStatus:
		return SafetyStatus(self._instance.Safetymode)
	@safetymode.setter
	def safetymode(self, value: SafetyStatus):
		self._instance.Safetymode = value
	@property
	def in_reduced_mode(self) -> int:
		return self._instance.InReducedMode
	@in_reduced_mode.setter
	def in_reduced_mode(self, value: int):
		self._instance.InReducedMode = value
	@property
	def operational_mode_selector_input(self) -> int:
		return self._instance.OperationalModeSelectorInput
	@operational_mode_selector_input.setter
	def operational_mode_selector_input(self, value: int):
		self._instance.OperationalModeSelectorInput = value
	@property
	def three_position_enabling_device_input(self) -> int:
		return self._instance.ThreePositionEnablingDeviceInput
	@three_position_enabling_device_input.setter
	def three_position_enabling_device_input(self, value: int):
		self._instance.ThreePositionEnablingDeviceInput = value
	@property
	def digital_inputs(self) -> MasterboardDigitalIO:
		return MasterboardDigitalIO(self._instance.DigitalInputs)
	@digital_inputs.setter
	def digital_inputs(self, value: MasterboardDigitalIO):
		self._instance.DigitalInputs = value
	@property
	def digital_outputs(self) -> MasterboardDigitalIO:
		return MasterboardDigitalIO(self._instance.DigitalOutputs)
	@digital_outputs.setter
	def digital_outputs(self, value: MasterboardDigitalIO):
		self._instance.DigitalOutputs = value
	@property
	def euromap67_installed(self) -> int:
		return self._instance.Euromap67Installed
	@euromap67_installed.setter
	def euromap67_installed(self, value: int):
		self._instance.Euromap67Installed = value
	@property
	def euromap_input_bits(self) -> int:
		return self._instance.EuromapInputBits
	@euromap_input_bits.setter
	def euromap_input_bits(self, value: int):
		self._instance.EuromapInputBits = value
	@property
	def euromap_output_bits(self) -> int:
		return self._instance.EuromapOutputBits
	@euromap_output_bits.setter
	def euromap_output_bits(self, value: int):
		self._instance.EuromapOutputBits = value
	@property
	def euromap_voltage(self) -> float:
		return self._instance.EuromapVoltage
	@euromap_voltage.setter
	def euromap_voltage(self, value: float):
		self._instance.EuromapVoltage = value
	@property
	def euromap_current(self) -> float:
		return self._instance.EuromapCurrent
	@euromap_current.setter
	def euromap_current(self, value: float):
		self._instance.EuromapCurrent = value
