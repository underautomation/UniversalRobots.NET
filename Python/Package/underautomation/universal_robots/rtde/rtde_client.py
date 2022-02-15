import typing
from underautomation.universal_robots.rtde.rtde_output_setup import RtdeOutputSetup
from underautomation.universal_robots.rtde.rtde_input_setup import RtdeInputSetup
from underautomation.universal_robots.rtde.rtde_versions import RtdeVersions
from underautomation.universal_robots.rtde.rtde_outputs_description import RtdeOutputsDescription
from underautomation.universal_robots.rtde.rtde_inputs_description import RtdeInputsDescription
from underautomation.universal_robots.rtde.internal.rtde_client_base import RtdeClientBase
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..", "..", "..", 'lib', 'UnderAutomation.UniversalRobots.dll')))
from UnderAutomation.UniversalRobots.Rtde import RtdeClient as rtde_client

class RtdeClient(RtdeClientBase):
	def __init__(self, _internal = 0):
		if(_internal == 0):
			self._instance = rtde_client()
		else:
			self._instance = _internal
	def connect(self, ip: str, outputSetup: RtdeOutputSetup, inputSetup: RtdeInputSetup, version: RtdeVersions, frequency: float) -> None:
		self._instance.Connect(ip, outputSetup._instance, inputSetup._instance, version._instance, frequency)
	@property
	def all_outputs_description(self) -> RtdeOutputsDescription:
		return RtdeOutputsDescription(self._instance.AllOutputsDescription)
	@property
	def all_inputs_description(self) -> RtdeInputsDescription:
		return RtdeInputsDescription(self._instance.AllInputsDescription)
