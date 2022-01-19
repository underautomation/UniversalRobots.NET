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
from underautomation.universal_robots.internal.urservice_base import URServiceBase
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
	def add__robot_mode_data_received(self, value: typing.Any) -> None:
		self._instance.add_RobotModeDataReceived(value)
	def remove__robot_mode_data_received(self, value: typing.Any) -> None:
		self._instance.remove_RobotModeDataReceived(value)
	def add__joint_data_received(self, value: typing.Any) -> None:
		self._instance.add_JointDataReceived(value)
	def remove__joint_data_received(self, value: typing.Any) -> None:
		self._instance.remove_JointDataReceived(value)
	def add__tool_data_received(self, value: typing.Any) -> None:
		self._instance.add_ToolDataReceived(value)
	def remove__tool_data_received(self, value: typing.Any) -> None:
		self._instance.remove_ToolDataReceived(value)
	def add__masterboard_data_received(self, value: typing.Any) -> None:
		self._instance.add_MasterboardDataReceived(value)
	def remove__masterboard_data_received(self, value: typing.Any) -> None:
		self._instance.remove_MasterboardDataReceived(value)
	def add__cartesian_info_received(self, value: typing.Any) -> None:
		self._instance.add_CartesianInfoReceived(value)
	def remove__cartesian_info_received(self, value: typing.Any) -> None:
		self._instance.remove_CartesianInfoReceived(value)
	def add__kinematics_info_received(self, value: typing.Any) -> None:
		self._instance.add_KinematicsInfoReceived(value)
	def remove__kinematics_info_received(self, value: typing.Any) -> None:
		self._instance.remove_KinematicsInfoReceived(value)
	def add__configuration_data_received(self, value: typing.Any) -> None:
		self._instance.add_ConfigurationDataReceived(value)
	def remove__configuration_data_received(self, value: typing.Any) -> None:
		self._instance.remove_ConfigurationDataReceived(value)
	def add__force_mode_data_received(self, value: typing.Any) -> None:
		self._instance.add_ForceModeDataReceived(value)
	def remove__force_mode_data_received(self, value: typing.Any) -> None:
		self._instance.remove_ForceModeDataReceived(value)
	def add__additional_info_received(self, value: typing.Any) -> None:
		self._instance.add_AdditionalInfoReceived(value)
	def remove__additional_info_received(self, value: typing.Any) -> None:
		self._instance.remove_AdditionalInfoReceived(value)
	def add__calibration_data_received(self, value: typing.Any) -> None:
		self._instance.add_CalibrationDataReceived(value)
	def remove__calibration_data_received(self, value: typing.Any) -> None:
		self._instance.remove_CalibrationDataReceived(value)
	def add__safety_data_received(self, value: typing.Any) -> None:
		self._instance.add_SafetyDataReceived(value)
	def remove__safety_data_received(self, value: typing.Any) -> None:
		self._instance.remove_SafetyDataReceived(value)
	def add__tool_communication_info_received(self, value: typing.Any) -> None:
		self._instance.add_ToolCommunicationInfoReceived(value)
	def remove__tool_communication_info_received(self, value: typing.Any) -> None:
		self._instance.remove_ToolCommunicationInfoReceived(value)
	def add__tool_mode_info_received(self, value: typing.Any) -> None:
		self._instance.add_ToolModeInfoReceived(value)
	def remove__tool_mode_info_received(self, value: typing.Any) -> None:
		self._instance.remove_ToolModeInfoReceived(value)
	def add__singularity_info_received(self, value: typing.Any) -> None:
		self._instance.add_SingularityInfoReceived(value)
	def remove__singularity_info_received(self, value: typing.Any) -> None:
		self._instance.remove_SingularityInfoReceived(value)
	def add__package_received(self, value: typing.Any) -> None:
		self._instance.add_PackageReceived(value)
	def remove__package_received(self, value: typing.Any) -> None:
		self._instance.remove_PackageReceived(value)
	def add__program_threads_received(self, value: typing.Any) -> None:
		self._instance.add_ProgramThreadsReceived(value)
	def remove__program_threads_received(self, value: typing.Any) -> None:
		self._instance.remove_ProgramThreadsReceived(value)
	def add__version_received(self, value: typing.Any) -> None:
		self._instance.add_VersionReceived(value)
	def remove__version_received(self, value: typing.Any) -> None:
		self._instance.remove_VersionReceived(value)
	def add__key_message_received(self, value: typing.Any) -> None:
		self._instance.add_KeyMessageReceived(value)
	def remove__key_message_received(self, value: typing.Any) -> None:
		self._instance.remove_KeyMessageReceived(value)
	def add__popup_message_received(self, value: typing.Any) -> None:
		self._instance.add_PopupMessageReceived(value)
	def remove__popup_message_received(self, value: typing.Any) -> None:
		self._instance.remove_PopupMessageReceived(value)
	def add__text_message_received(self, value: typing.Any) -> None:
		self._instance.add_TextMessageReceived(value)
	def remove__text_message_received(self, value: typing.Any) -> None:
		self._instance.remove_TextMessageReceived(value)
	def add__runtime_exception_message_received(self, value: typing.Any) -> None:
		self._instance.add_RuntimeExceptionMessageReceived(value)
	def remove__runtime_exception_message_received(self, value: typing.Any) -> None:
		self._instance.remove_RuntimeExceptionMessageReceived(value)
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
