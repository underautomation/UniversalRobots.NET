import typing
from underautomation.universal_robots.primary_interface.robot_mode_data_package_event_args import RobotModeDataPackageEventArgs
from underautomation.universal_robots.primary_interface.joint_data_package_event_args import JointDataPackageEventArgs
from underautomation.universal_robots.primary_interface.tool_data_package_event_args import ToolDataPackageEventArgs
from underautomation.universal_robots.primary_interface.masterboard_data_package_event_args import MasterboardDataPackageEventArgs
from underautomation.universal_robots.primary_interface.cartesian_info_package_event_args import CartesianInfoPackageEventArgs
from underautomation.universal_robots.primary_interface.kinematics_info_package_event_args import KinematicsInfoPackageEventArgs
from underautomation.universal_robots.primary_interface.configuration_data_package_event_args import ConfigurationDataPackageEventArgs
from underautomation.universal_robots.primary_interface.force_mode_data_package_event_args import ForceModeDataPackageEventArgs
from underautomation.universal_robots.primary_interface.additional_info_package_event_args import AdditionalInfoPackageEventArgs
from underautomation.universal_robots.primary_interface.calibration_data_package_event_args import CalibrationDataPackageEventArgs
from underautomation.universal_robots.primary_interface.safety_data_package_event_args import SafetyDataPackageEventArgs
from underautomation.universal_robots.primary_interface.tool_communication_info_package_event_args import ToolCommunicationInfoPackageEventArgs
from underautomation.universal_robots.primary_interface.tool_mode_info_package_event_args import ToolModeInfoPackageEventArgs
from underautomation.universal_robots.primary_interface.singularity_info_package_event_args import SingularityInfoPackageEventArgs
from underautomation.universal_robots.primary_interface.program_threads_event_args import ProgramThreadsEventArgs
from underautomation.universal_robots.primary_interface.version_event_args import VersionEventArgs
from underautomation.universal_robots.primary_interface.key_message_event_args import KeyMessageEventArgs
from underautomation.universal_robots.primary_interface.popup_message_event_args import PopupMessageEventArgs
from underautomation.universal_robots.primary_interface.text_message_event_args import TextMessageEventArgs
from underautomation.universal_robots.primary_interface.runtime_exception_message_event_args import RuntimeExceptionMessageEventArgs
from underautomation.universal_robots.primary_interface.global_variables import GlobalVariables
from underautomation.universal_robots.primary_interface.interfaces import Interfaces
from underautomation.universal_robots.status_code import StatusCode
from underautomation.universal_robots.internal.ur_service_base import URServiceBase
from underautomation.universal_robots.common.package_event_args import PackageEventArgs
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..", "..", "..", "..", 'lib', 'UnderAutomation.UniversalRobots.dll')))
from UnderAutomation.UniversalRobots.PrimaryInterface.Internal import PrimaryInterfaceClientBase as primary_interface_client_base

class PrimaryInterfaceClientBase(URServiceBase):
	def __init__(self, _internal = 0):
		if(_internal == 0):
			self._instance = primary_interface_client_base()
		else:
			self._instance = _internal
	def robot_mode_data_received(self, handler):
		class Wrapper :
			def __init__(self, _internal):
				self._instance = _internal
		self._instance.RobotModeDataReceived+= lambda sender, e : handler(Wrapper(sender), Wrapper(e))
	def joint_data_received(self, handler):
		class Wrapper :
			def __init__(self, _internal):
				self._instance = _internal
		self._instance.JointDataReceived+= lambda sender, e : handler(Wrapper(sender), Wrapper(e))
	def tool_data_received(self, handler):
		class Wrapper :
			def __init__(self, _internal):
				self._instance = _internal
		self._instance.ToolDataReceived+= lambda sender, e : handler(Wrapper(sender), Wrapper(e))
	def masterboard_data_received(self, handler):
		class Wrapper :
			def __init__(self, _internal):
				self._instance = _internal
		self._instance.MasterboardDataReceived+= lambda sender, e : handler(Wrapper(sender), Wrapper(e))
	def cartesian_info_received(self, handler):
		class Wrapper :
			def __init__(self, _internal):
				self._instance = _internal
		self._instance.CartesianInfoReceived+= lambda sender, e : handler(Wrapper(sender), Wrapper(e))
	def kinematics_info_received(self, handler):
		class Wrapper :
			def __init__(self, _internal):
				self._instance = _internal
		self._instance.KinematicsInfoReceived+= lambda sender, e : handler(Wrapper(sender), Wrapper(e))
	def configuration_data_received(self, handler):
		class Wrapper :
			def __init__(self, _internal):
				self._instance = _internal
		self._instance.ConfigurationDataReceived+= lambda sender, e : handler(Wrapper(sender), Wrapper(e))
	def force_mode_data_received(self, handler):
		class Wrapper :
			def __init__(self, _internal):
				self._instance = _internal
		self._instance.ForceModeDataReceived+= lambda sender, e : handler(Wrapper(sender), Wrapper(e))
	def additional_info_received(self, handler):
		class Wrapper :
			def __init__(self, _internal):
				self._instance = _internal
		self._instance.AdditionalInfoReceived+= lambda sender, e : handler(Wrapper(sender), Wrapper(e))
	def calibration_data_received(self, handler):
		class Wrapper :
			def __init__(self, _internal):
				self._instance = _internal
		self._instance.CalibrationDataReceived+= lambda sender, e : handler(Wrapper(sender), Wrapper(e))
	def safety_data_received(self, handler):
		class Wrapper :
			def __init__(self, _internal):
				self._instance = _internal
		self._instance.SafetyDataReceived+= lambda sender, e : handler(Wrapper(sender), Wrapper(e))
	def tool_communication_info_received(self, handler):
		class Wrapper :
			def __init__(self, _internal):
				self._instance = _internal
		self._instance.ToolCommunicationInfoReceived+= lambda sender, e : handler(Wrapper(sender), Wrapper(e))
	def tool_mode_info_received(self, handler):
		class Wrapper :
			def __init__(self, _internal):
				self._instance = _internal
		self._instance.ToolModeInfoReceived+= lambda sender, e : handler(Wrapper(sender), Wrapper(e))
	def singularity_info_received(self, handler):
		class Wrapper :
			def __init__(self, _internal):
				self._instance = _internal
		self._instance.SingularityInfoReceived+= lambda sender, e : handler(Wrapper(sender), Wrapper(e))
	def package_received(self, handler):
		class Wrapper :
			def __init__(self, _internal):
				self._instance = _internal
		self._instance.PackageReceived+= lambda sender, e : handler(Wrapper(sender), Wrapper(e))
	def program_threads_received(self, handler):
		class Wrapper :
			def __init__(self, _internal):
				self._instance = _internal
		self._instance.ProgramThreadsReceived+= lambda sender, e : handler(Wrapper(sender), Wrapper(e))
	def version_received(self, handler):
		class Wrapper :
			def __init__(self, _internal):
				self._instance = _internal
		self._instance.VersionReceived+= lambda sender, e : handler(Wrapper(sender), Wrapper(e))
	def key_message_received(self, handler):
		class Wrapper :
			def __init__(self, _internal):
				self._instance = _internal
		self._instance.KeyMessageReceived+= lambda sender, e : handler(Wrapper(sender), Wrapper(e))
	def popup_message_received(self, handler):
		class Wrapper :
			def __init__(self, _internal):
				self._instance = _internal
		self._instance.PopupMessageReceived+= lambda sender, e : handler(Wrapper(sender), Wrapper(e))
	def text_message_received(self, handler):
		class Wrapper :
			def __init__(self, _internal):
				self._instance = _internal
		self._instance.TextMessageReceived+= lambda sender, e : handler(Wrapper(sender), Wrapper(e))
	def runtime_exception_message_received(self, handler):
		class Wrapper :
			def __init__(self, _internal):
				self._instance = _internal
		self._instance.RuntimeExceptionMessageReceived+= lambda sender, e : handler(Wrapper(sender), Wrapper(e))
	def disconnect(self) -> None:
		self._instance.Disconnect()
	def send(self, script: str) -> StatusCode:
		return StatusCode(self._instance.Send(script))
	@property
	def robot_mode_data(self) -> RobotModeDataPackageEventArgs:
		return RobotModeDataPackageEventArgs(self._instance.RobotModeData)
	@property
	def joint_data(self) -> JointDataPackageEventArgs:
		return JointDataPackageEventArgs(self._instance.JointData)
	@property
	def tool_data(self) -> ToolDataPackageEventArgs:
		return ToolDataPackageEventArgs(self._instance.ToolData)
	@property
	def masterboard_data(self) -> MasterboardDataPackageEventArgs:
		return MasterboardDataPackageEventArgs(self._instance.MasterboardData)
	@property
	def cartesian_info(self) -> CartesianInfoPackageEventArgs:
		return CartesianInfoPackageEventArgs(self._instance.CartesianInfo)
	@property
	def kinematics_info(self) -> KinematicsInfoPackageEventArgs:
		return KinematicsInfoPackageEventArgs(self._instance.KinematicsInfo)
	@property
	def configuration_data(self) -> ConfigurationDataPackageEventArgs:
		return ConfigurationDataPackageEventArgs(self._instance.ConfigurationData)
	@property
	def force_mode_data(self) -> ForceModeDataPackageEventArgs:
		return ForceModeDataPackageEventArgs(self._instance.ForceModeData)
	@property
	def additional_info(self) -> AdditionalInfoPackageEventArgs:
		return AdditionalInfoPackageEventArgs(self._instance.AdditionalInfo)
	@property
	def calibration_data(self) -> CalibrationDataPackageEventArgs:
		return CalibrationDataPackageEventArgs(self._instance.CalibrationData)
	@property
	def safety_data(self) -> SafetyDataPackageEventArgs:
		return SafetyDataPackageEventArgs(self._instance.SafetyData)
	@property
	def tool_communication_info(self) -> ToolCommunicationInfoPackageEventArgs:
		return ToolCommunicationInfoPackageEventArgs(self._instance.ToolCommunicationInfo)
	@property
	def tool_mode_info(self) -> ToolModeInfoPackageEventArgs:
		return ToolModeInfoPackageEventArgs(self._instance.ToolModeInfo)
	@property
	def singularity_info(self) -> SingularityInfoPackageEventArgs:
		return SingularityInfoPackageEventArgs(self._instance.SingularityInfo)
	@property
	def program_threads(self) -> ProgramThreadsEventArgs:
		return ProgramThreadsEventArgs(self._instance.ProgramThreads)
	@property
	def version(self) -> VersionEventArgs:
		return VersionEventArgs(self._instance.Version)
	@property
	def key_message(self) -> KeyMessageEventArgs:
		return KeyMessageEventArgs(self._instance.KeyMessage)
	@property
	def popup_message(self) -> PopupMessageEventArgs:
		return PopupMessageEventArgs(self._instance.PopupMessage)
	@property
	def text_message(self) -> TextMessageEventArgs:
		return TextMessageEventArgs(self._instance.TextMessage)
	@property
	def runtime_exception_message(self) -> RuntimeExceptionMessageEventArgs:
		return RuntimeExceptionMessageEventArgs(self._instance.RuntimeExceptionMessage)
	@property
	def global_variables(self) -> GlobalVariables:
		return GlobalVariables(self._instance.GlobalVariables)
	@property
	def ip(self) -> str:
		return self._instance.IP
	@property
	def port(self) -> Interfaces:
		return Interfaces(self._instance.Port)
	@property
	def connected(self) -> bool:
		return self._instance.Connected
	@property
	def local_end_point(self) -> typing.Any:
		return self._instance.LocalEndPoint
