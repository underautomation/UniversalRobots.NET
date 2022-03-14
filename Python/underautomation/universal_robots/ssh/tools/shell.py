import typing
from underautomation.universal_robots.ssh.tools.common.exception_event_args import ExceptionEventArgs
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..", "..",  'lib', 'UnderAutomation.UniversalRobots.dll')))
from UnderAutomation.UniversalRobots.Ssh.Tools import Shell as shell

class Shell:
	def __init__(self, _internal = 0):
		if(_internal == 0):
			self._instance = shell()
		else:
			self._instance = _internal
	def starting(self, handler):
		class Wrapper :
			def __init__(self, _internal):
				self._instance = _internal
		self._instance.Starting+= lambda sender, e : handler(Wrapper(sender), Wrapper(e))
	def started(self, handler):
		class Wrapper :
			def __init__(self, _internal):
				self._instance = _internal
		self._instance.Started+= lambda sender, e : handler(Wrapper(sender), Wrapper(e))
	def stopping(self, handler):
		class Wrapper :
			def __init__(self, _internal):
				self._instance = _internal
		self._instance.Stopping+= lambda sender, e : handler(Wrapper(sender), Wrapper(e))
	def stopped(self, handler):
		class Wrapper :
			def __init__(self, _internal):
				self._instance = _internal
		self._instance.Stopped+= lambda sender, e : handler(Wrapper(sender), Wrapper(e))
	def error_occurred(self, handler):
		class Wrapper :
			def __init__(self, _internal):
				self._instance = _internal
		self._instance.ErrorOccurred+= lambda sender, e : handler(Wrapper(sender), Wrapper(e))
	def start(self) -> None:
		self._instance.Start()
	def stop(self) -> None:
		self._instance.Stop()
	@property
	def is_started(self) -> bool:
		return self._instance.IsStarted
