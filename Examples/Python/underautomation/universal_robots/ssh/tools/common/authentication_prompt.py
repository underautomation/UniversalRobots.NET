import typing
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..", "..", "..", "..", "..", 'lib', 'UnderAutomation.UniversalRobots.dll')))
from UnderAutomation.UniversalRobots.Ssh.Tools.Common import AuthenticationPrompt as authentication_prompt

class AuthenticationPrompt:
	def __init__(self, id: int, isEchoed: bool, request: str, _internal = 0):
		if(_internal == 0):
			self._instance = authentication_prompt(id, isEchoed, request)
		else:
			self._instance = _internal
	@property
	def id(self) -> int:
		return self._instance.Id
	@property
	def is_echoed(self) -> bool:
		return self._instance.IsEchoed
	@property
	def request(self) -> str:
		return self._instance.Request
	@property
	def response(self) -> str:
		return self._instance.Response
	@response.setter
	def response(self, value: str):
		self._instance.Response = value
