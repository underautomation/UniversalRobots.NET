import typing
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..", "..", "..", "..", "..", 'lib', 'UnderAutomation.UniversalRobots.dll')))
from UnderAutomation.UniversalRobots.Ssh.Tools.Security import HostAlgorithm as host_algorithm

class HostAlgorithm:
	def __init__(self, _internal = 0):
		if(_internal == 0):
			self._instance = host_algorithm()
		else:
			self._instance = _internal
	def sign(self, data: int) -> int:
		return self._instance.Sign(data)
	def verify_signature(self, data: int, signature: int) -> bool:
		return self._instance.VerifySignature(data, signature)
	@property
	def name(self) -> str:
		return self._instance.Name
	@property
	def data(self) -> int:
		return self._instance.Data
