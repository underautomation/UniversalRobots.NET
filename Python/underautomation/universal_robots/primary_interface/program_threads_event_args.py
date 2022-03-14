import typing
from underautomation.universal_robots.primary_interface.program_thread import ProgramThread
from underautomation.universal_robots.common.package_event_args import PackageEventArgs
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..",  'lib', 'UnderAutomation.UniversalRobots.dll')))
from UnderAutomation.UniversalRobots.PrimaryInterface import ProgramThreadsEventArgs as program_threads_event_args

class ProgramThreadsEventArgs(PackageEventArgs):
	def __init__(self, _internal = 0):
		if(_internal == 0):
			self._instance = program_threads_event_args()
		else:
			self._instance = _internal
	@property
	def threads(self) -> typing.List[ProgramThread]:
		return [ProgramThread(x) for x in self._instance.Threads]
	@threads.setter
	def threads(self, value: typing.List[ProgramThread]):
		self._instance.Threads = value
