import typing
from underautomation.universal_robots.rtde.rtde_output_setup import RtdeOutputSetup
from underautomation.universal_robots.rtde.rtde_input_setup import RtdeInputSetup
from underautomation.universal_robots.rtde.rtde_versions import RtdeVersions
from underautomation.universal_robots.rtde.internal.rtde_client_base import RtdeClientBase
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..", "..", "..", 'lib', 'UnderAutomation.UniversalRobots.dll')))
from UnderAutomation.UniversalRobots.Internal import RtdeClientInternal as rtde_client_internal

class RtdeClientInternal(RtdeClientBase):
	def __init__(self, _internal = 0):
		if(_internal == 0):
			self._instance = rtde_client_internal()
		else:
			self._instance = _internal
	def connect(self, outputSetup: RtdeOutputSetup, inputSetup: RtdeInputSetup, version: RtdeVersions, frequency: float) -> None:
		self._instance.Connect(outputSetup._instance, inputSetup._instance, version._instance, frequency)
