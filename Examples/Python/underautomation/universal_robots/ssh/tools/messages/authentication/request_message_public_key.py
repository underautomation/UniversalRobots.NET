import typing
from underautomation.universal_robots.ssh.tools.messages.service_name import ServiceName
from underautomation.universal_robots.ssh.tools.messages.authentication.request_message import RequestMessage
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..", "..", "..", "..", "..", "..", 'lib', 'UnderAutomation.UniversalRobots.dll')))
from UnderAutomation.UniversalRobots.Ssh.Tools.Messages.Authentication import RequestMessagePublicKey as request_message_public_key

class RequestMessagePublicKey(RequestMessage):
	def __init__(self, serviceName: ServiceName, username: str, keyAlgorithmName: str, keyData: typing.List[int], signature: typing.List[int], _internal = 0):
		if(_internal == 0):
			self._instance = request_message_public_key(serviceName, username, keyAlgorithmName, keyData, signature)
		else:
			self._instance = _internal
	@property
	def public_key_algorithm_name(self) -> typing.List[int]:
		return self._instance.PublicKeyAlgorithmName
	@property
	def public_key_data(self) -> typing.List[int]:
		return self._instance.PublicKeyData
	@property
	def signature(self) -> typing.List[int]:
		return self._instance.Signature
	@signature.setter
	def signature(self, value: typing.List[int]):
		self._instance.Signature = value
