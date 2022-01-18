import typing
from underautomation.universal_robots.ssh.tools.common.authentication_event_args import AuthenticationEventArgs
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..", "..", "..", "..", "..", 'lib', 'UnderAutomation.UniversalRobots.dll')))
from UnderAutomation.UniversalRobots.Ssh.Tools.Common import AuthenticationPromptEventArgs as authentication_prompt_event_args

class AuthenticationPromptEventArgs(AuthenticationEventArgs):
	def __init__(self, username: str, instruction: str, language: str, prompts: typing.Any, _internal = 0):
		if(_internal == 0):
			self._instance = authentication_prompt_event_args(username, instruction, language, prompts)
		else:
			self._instance = _internal
	@property
	def language(self) -> str:
		return self._instance.Language
	@property
	def instruction(self) -> str:
		return self._instance.Instruction
	@property
	def prompts(self) -> typing.Any:
		return self._instance.Prompts
