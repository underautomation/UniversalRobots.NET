import typing
from underautomation.universal_robots.ssh.tools.security.host_algorithm import HostAlgorithm
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..", "..", "..", "..", "..", 'lib', 'UnderAutomation.UniversalRobots.dll')))
from UnderAutomation.UniversalRobots.Ssh.Tools.Security import CertificateHostAlgorithm as certificate_host_algorithm

class CertificateHostAlgorithm(HostAlgorithm):
	def __init__(self, name: str, _internal = 0):
		if(_internal == 0):
			self._instance = certificate_host_algorithm(name)
		else:
			self._instance = _internal
	def sign(self, data: typing.List[int]) -> typing.List[int]:
		return self._instance.Sign(data)
	def verify_signature(self, data: typing.List[int], signature: typing.List[int]) -> bool:
		return self._instance.VerifySignature(data, signature)
	@property
	def data(self) -> typing.List[int]:
		return self._instance.Data
