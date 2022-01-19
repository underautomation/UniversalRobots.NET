import typing
from underautomation.universal_robots.rtde.rtde_text_message_event_args import RtdeTextMessageEventArgs
from underautomation.universal_robots.rtde.rtdestates import RTDEStates
from underautomation.universal_robots.rtde.rtde_versions import RtdeVersions
from underautomation.universal_robots.rtde.rtde_output_setup_item import RtdeOutputSetupItem
from underautomation.universal_robots.rtde.rtde_input_setup_item import RtdeInputSetupItem
from underautomation.universal_robots.rtde.rtde_output_values import RtdeOutputValues
from underautomation.universal_robots.rtde.rtde_input_values import RtdeInputValues
from underautomation.universal_robots.rtde.rtde_protocol_version_event_args import RtdeProtocolVersionEventArgs
from underautomation.universal_robots.rtde.rtde_data_package_event_args import RtdeDataPackageEventArgs
from underautomation.universal_robots.rtde.rtde_control_package_setup_outputs_event_args import RtdeControlPackageSetupOutputsEventArgs
from underautomation.universal_robots.rtde.rtde_control_package_setup_inputs_event_args import RtdeControlPackageSetupInputsEventArgs
from underautomation.universal_robots.rtde.rtde_basic_request_event_args import RtdeBasicRequestEventArgs
from underautomation.universal_robots.common.package_event_args import PackageEventArgs
from underautomation.universal_robots.internal.urservice_base import URServiceBase
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..", "..", "..", "..", 'lib', 'UnderAutomation.UniversalRobots.dll')))
from UnderAutomation.UniversalRobots.Rtde.Internal import RtdeClientBase as rtde_client_base

class RtdeClientBase(URServiceBase):
	def __init__(self, _internal = 0):
		if(_internal == 0):
			self._instance = rtde_client_base()
		else:
			self._instance = _internal
	def protocol_version_received(self, handler):
		self._instance.ProtocolVersionReceived+= lambda sender, e : handler(sender, RtdeProtocolVersionEventArgs(e))
	def text_message_received(self, handler):
		self._instance.TextMessageReceived+= lambda sender, e : handler(sender, RtdeTextMessageEventArgs(e))
	def output_data_received(self, handler):
		self._instance.OutputDataReceived+= lambda sender, e : handler(sender, RtdeDataPackageEventArgs(e))
	def setup_outputs_received(self, handler):
		self._instance.SetupOutputsReceived+= lambda sender, e : handler(sender, RtdeControlPackageSetupOutputsEventArgs(e))
	def setup_inputs_received(self, handler):
		self._instance.SetupInputsReceived+= lambda sender, e : handler(sender, RtdeControlPackageSetupInputsEventArgs(e))
	def start_received(self, handler):
		self._instance.StartReceived+= lambda sender, e : handler(sender, RtdeBasicRequestEventArgs(e))
	def pause_received(self, handler):
		self._instance.PauseReceived+= lambda sender, e : handler(sender, RtdeBasicRequestEventArgs(e))
	def package_received(self, handler):
		self._instance.PackageReceived+= lambda sender, e : handler(sender, PackageEventArgs(e))
	def add__protocol_version_received(self, value: typing.Any) -> None:
		self._instance.add_ProtocolVersionReceived(value)
	def remove__protocol_version_received(self, value: typing.Any) -> None:
		self._instance.remove_ProtocolVersionReceived(value)
	def add__text_message_received(self, value: typing.Any) -> None:
		self._instance.add_TextMessageReceived(value)
	def remove__text_message_received(self, value: typing.Any) -> None:
		self._instance.remove_TextMessageReceived(value)
	def add__output_data_received(self, value: typing.Any) -> None:
		self._instance.add_OutputDataReceived(value)
	def remove__output_data_received(self, value: typing.Any) -> None:
		self._instance.remove_OutputDataReceived(value)
	def add__setup_outputs_received(self, value: typing.Any) -> None:
		self._instance.add_SetupOutputsReceived(value)
	def remove__setup_outputs_received(self, value: typing.Any) -> None:
		self._instance.remove_SetupOutputsReceived(value)
	def add__setup_inputs_received(self, value: typing.Any) -> None:
		self._instance.add_SetupInputsReceived(value)
	def remove__setup_inputs_received(self, value: typing.Any) -> None:
		self._instance.remove_SetupInputsReceived(value)
	def add__start_received(self, value: typing.Any) -> None:
		self._instance.add_StartReceived(value)
	def remove__start_received(self, value: typing.Any) -> None:
		self._instance.remove_StartReceived(value)
	def add__pause_received(self, value: typing.Any) -> None:
		self._instance.add_PauseReceived(value)
	def remove__pause_received(self, value: typing.Any) -> None:
		self._instance.remove_PauseReceived(value)
	def add__package_received(self, value: typing.Any) -> None:
		self._instance.add_PackageReceived(value)
	def remove__package_received(self, value: typing.Any) -> None:
		self._instance.remove_PackageReceived(value)
	def pause(self) -> None:
		self._instance.Pause()
	def resume(self) -> None:
		self._instance.Resume()
	def write_inputs(self, inputValues: RtdeInputValues) -> None:
		self._instance.WriteInputs(inputValues._instance)
	def disconnect(self) -> None:
		self._instance.Disconnect()
	@property
	def last_text_message(self) -> RtdeTextMessageEventArgs:
		return RtdeTextMessageEventArgs(self._instance.LastTextMessage)
	@property
	def state(self) -> RTDEStates:
		return RTDEStates(self._instance.State)
	@property
	def connected(self) -> bool:
		return self._instance.Connected
	@property
	def ip(self) -> str:
		return self._instance.IP
	@property
	def applied_frequency(self) -> float:
		return self._instance.AppliedFrequency
	@property
	def version(self) -> RtdeVersions:
		return RtdeVersions(self._instance.Version)
	@property
	def output_setup(self) -> typing.List[RtdeOutputSetupItem]:
		return [RtdeOutputSetupItem(x) for x in self._instance.OutputSetup]
	@property
	def input_setup(self) -> typing.List[RtdeInputSetupItem]:
		return [RtdeInputSetupItem(x) for x in self._instance.InputSetup]
	@property
	def output_recipe_id(self) -> int:
		return self._instance.OutputRecipeId
	@property
	def input_recipe_id(self) -> int:
		return self._instance.InputRecipeId
	@property
	def measured_frequency(self) -> float:
		return self._instance.MeasuredFrequency
	@property
	def output_data_values(self) -> RtdeOutputValues:
		return RtdeOutputValues(self._instance.OutputDataValues)
